# Runs on the Windows benchmark VM, started in the background by run.sh. Never run it by hand.
#
# Reads config.json next to it, which run.sh writes: BlobBase and BlobSas (the run's storage
# container), SdkVersion, EnvName, Commit, Mode (full or dry), RunId. Reports progress to
# status.txt in the container as "RunId|text", and uploads results.tar.gz when it's done.
# Written for Windows PowerShell 5.1, which is what runs it.

$ErrorActionPreference = 'Stop'
$ProgressPreference = 'SilentlyContinue'   # the progress bar slows downloads a lot in 5.1
[Net.ServicePointManager]::SecurityProtocol = [Net.SecurityProtocolType]::Tls12

$Root = $PSScriptRoot   # the launcher puts this script, as run.ps1, next to config.json
$Config = Get-Content -Raw (Join-Path $Root 'config.json') | ConvertFrom-Json
$Log = Join-Path $Root 'vm.log'
$OnWindows = [Environment]::OSVersion.Platform -eq 'Win32NT'

function Write-Log([string] $Text) {
    Add-Content -Path $Log -Value $Text
}

function Send-Blob([string] $Name, [string] $Path) {
    $uri = "$($Config.BlobBase)/$Name`?$($Config.BlobSas)"
    Invoke-WebRequest -UseBasicParsing -Method Put -Uri $uri -InFile $Path -Headers @{ 'x-ms-blob-type' = 'BlockBlob' } | Out-Null
}

function Get-Blob([string] $Name, [string] $Path) {
    Invoke-WebRequest -UseBasicParsing -Uri "$($Config.BlobBase)/$Name`?$($Config.BlobSas)" -OutFile $Path
}

function Set-Status([string] $Text) {
    Write-Log "== $([DateTime]::UtcNow.ToString('s'))Z $Text"
    $file = Join-Path $Root 'status.txt'
    Set-Content -Path $file -Value "$($Config.RunId)|$Text"
    try { Send-Blob 'status.txt' $file } catch { Write-Log "status upload failed: $($_.Exception.Message)" }
}

# Runs a native command, logs its output, and fails on a nonzero exit code. In Windows PowerShell
# 5.1, redirected stderr output becomes an error record, which 'Stop' would turn into a failure.
function Invoke-Logged([string] $File, [string[]] $Arguments) {
    $ErrorActionPreference = 'Continue'
    & $File @Arguments 2>&1 | ForEach-Object { Write-Log "$_" }
    if ($LASTEXITCODE -ne 0) { throw "$File exited with code $LASTEXITCODE" }
}

# BenchmarkDotNet exits with 0 even when a filter matches nothing or validation fails, so check
# that each run produced reports.
function Assert-Reports([string] $Run) {
    $results = Join-Path (Join-Path (Join-Path $Root 'artifacts') $Run) 'results'
    if (-not (Get-ChildItem -Path $results -Filter '*-report-github.md' -ErrorAction SilentlyContinue)) {
        throw "$Run produced no reports; see vm.log"
    }
}

try {
    Set-Status 'preparing the machine'

    if ($OnWindows) {
        # Quiet the machine: no scanning of the files the benchmarks build and load, no updates,
        # and the High performance power plan. The VM is deleted afterwards.
        try { Set-MpPreference -DisableRealtimeMonitoring $true } catch { Write-Log "Defender: $($_.Exception.Message)" }
        try { Add-MpPreference -ExclusionPath $Root } catch { Write-Log "Defender exclusion: $($_.Exception.Message)" }
        foreach ($service in 'wuauserv', 'UsoSvc', 'BITS') {
            try {
                Stop-Service -Name $service -Force -ErrorAction Stop
                Set-Service -Name $service -StartupType Disabled -ErrorAction Stop
            } catch { Write-Log "${service}: $($_.Exception.Message)" }
        }
        Invoke-Logged 'powercfg' @('/setactive', '8c5e7fda-e8bf-4a96-9a85-a6e23a8c635c')
    }

    # Let first-boot activity (image optimization, agent setup) settle.
    if ($Config.Mode -eq 'dry') { Start-Sleep -Seconds 30 } else { Start-Sleep -Seconds 300 }

    Set-Status "installing .NET SDK $($Config.SdkVersion)"
    $env:DOTNET_ROOT = Join-Path $Root 'dotnet'
    $env:DOTNET_CLI_HOME = Join-Path $Root 'home'
    $env:NUGET_PACKAGES = Join-Path $Root 'nuget'
    $env:DOTNET_CLI_TELEMETRY_OPTOUT = '1'
    $env:DOTNET_NOLOGO = '1'
    $env:DOTNET_SKIP_FIRST_TIME_EXPERIENCE = '1'
    if ($env:BENCH_DOTNET) {
        $dotnet = $env:BENCH_DOTNET   # local testing only
    } else {
        $installer = Join-Path $Root 'dotnet-install.ps1'
        Invoke-WebRequest -UseBasicParsing -Uri 'https://dot.net/v1/dotnet-install.ps1' -OutFile $installer
        & $installer -Version $Config.SdkVersion -InstallDir $env:DOTNET_ROOT -NoPath *>&1 | ForEach-Object { Write-Log "$_" }
        if (-not (Test-Path (Join-Path $env:DOTNET_ROOT 'dotnet.exe'))) { throw 'The .NET SDK installation failed; see vm.log.' }
        $dotnet = Join-Path $env:DOTNET_ROOT 'dotnet.exe'
    }
    # BenchmarkDotNet finds the SDK through PATH to build each benchmark's process.
    $env:PATH = (Split-Path $dotnet) + [IO.Path]::PathSeparator + $env:PATH

    $src = Join-Path $Root 'src'
    if (Test-Path $src) { Remove-Item -Recurse -Force $src }
    New-Item -ItemType Directory -Path $src | Out-Null
    $archive = Join-Path $Root 'source.tar.gz'
    Get-Blob 'source.tar.gz' $archive
    Invoke-Logged 'tar' @('-xzf', $archive, '-C', $src)

    $out = Join-Path $Root 'out'
    if (Test-Path $out) { Remove-Item -Recurse -Force $out }
    New-Item -ItemType Directory -Path $out | Out-Null
    $env_ = @(
        "environment: $($Config.EnvName)",
        "commit: $($Config.Commit)",
        "mode: $($Config.Mode)",
        "date (UTC): $([DateTime]::UtcNow.ToString('s'))Z"
    )
    try {
        $imds = Invoke-RestMethod -UseBasicParsing -TimeoutSec 3 -Headers @{ Metadata = 'true' } -Uri 'http://169.254.169.254/metadata/instance/compute?api-version=2021-02-01'
        $env_ += "vm size: $($imds.vmSize)", "region: $($imds.location)", "image: $($imds.storageProfile.imageReference.offer) $($imds.storageProfile.imageReference.sku)"
    } catch { }
    if ($OnWindows) {
        $cpu = Get-CimInstance Win32_Processor | Select-Object -First 1
        $os = Get-CimInstance Win32_OperatingSystem
        $env_ += "cpu: $($cpu.Name.Trim()) ($($cpu.NumberOfCores) cores, $($cpu.NumberOfLogicalProcessors) logical)", "os: $($os.Caption) $($os.Version)"
    }
    $env_ += "sdk: $(& $dotnet --version)"
    Set-Content -Path (Join-Path $out 'environment.txt') -Value $env_

    Push-Location $src
    $bench = @('run', '-c', 'Release', '--project', 'benchmarks/AsyncLazy.Benchmarks', '--')
    $job = @()
    if ($Config.Mode -eq 'dry') { $job = @('--job', 'dry') }
    $artifacts = Join-Path $Root 'artifacts'

    Set-Status 'run 1 of 2: all benchmarks'
    # Not '*': PowerShell 7 on Unix would expand it into file names (Windows PowerShell doesn't).
    Invoke-Logged $dotnet ($bench + @('--filter', 'AsyncLazyBenchmarks.*') + $job + @('--artifacts', (Join-Path $artifacts 'run1')))
    Assert-Reports 'run1'

    # The second run repeats the scenarios that are most sensitive to a noisy machine, so the two
    # runs can be compared, and records the disassembly of the hot path.
    Set-Status 'run 2 of 2: hot path and first call again'
    Invoke-Logged $dotnet ($bench + @('--filter', '*HotPath*', '*FirstCall*') + $job + @('--disasm', '--artifacts', (Join-Path $artifacts 'run2')))
    Assert-Reports 'run2'
    Pop-Location

    Set-Status 'packaging results'
    foreach ($run in Get-ChildItem -Directory $artifacts) {
        $target = Join-Path $out $run.Name
        New-Item -ItemType Directory -Path $target | Out-Null
        Get-ChildItem -Path $run.FullName -Recurse -Depth 1 -Include '*.md', '*.log' -File |
            ForEach-Object { Copy-Item $_.FullName $target }
    }
    Copy-Item $Log (Join-Path $out 'vm.log')
    $results = Join-Path $Root 'results.tar.gz'
    Invoke-Logged 'tar' @('-czf', $results, '-C', $out, '.')
    Send-Blob 'results.tar.gz' $results
    Set-Status 'done'
}
catch {
    Write-Log ($_ | Out-String)
    Set-Status "failed: $($_.Exception.Message)"
    try { Send-Blob 'vm.log' $Log } catch { }
    exit 1
}
