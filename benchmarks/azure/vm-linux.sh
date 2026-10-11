#!/usr/bin/env bash

# Runs on the Linux benchmark VM, started in the background by run.sh. Never run it by hand.
#
# Reads $BENCH_ROOT/config.env, which run.sh writes: BLOB_BASE and BLOB_SAS (the run's storage
# container), SDK_VERSION, ENV_NAME, COMMIT, BENCH_MODE (full or dry), RUN_ID. Reports progress to
# status.txt in the container as "RUN_ID|text", and uploads results.tar.gz when it's done.

set -eEuo pipefail

ROOT=${BENCH_ROOT:-/opt/bench}
# shellcheck source=/dev/null
source "$ROOT/config.env"

LOG=$ROOT/vm.log
exec >>"$LOG" 2>&1

put() { curl -fsS --retry 5 -X PUT -H 'x-ms-blob-type: BlockBlob' --data-binary "@$2" "$BLOB_BASE/$1?$BLOB_SAS"; }
get() { curl -fsSL --retry 5 -o "$2" "$BLOB_BASE/$1?$BLOB_SAS"; }
status() {
    echo "== $(date -u +%FT%TZ) $1"
    printf '%s|%s\n' "$RUN_ID" "$1" >"$ROOT/status.txt"
    put status.txt "$ROOT/status.txt" || true
}
fail() {
    trap - ERR
    status "failed: $1"
    put vm.log "$LOG" || true
    exit 1
}
trap 'fail "line $LINENO: $BASH_COMMAND"' ERR

status "preparing the machine"

# Quiet the machine: no package updates or other scheduled work during the run.
if command -v cloud-init >/dev/null; then cloud-init status --wait >/dev/null || true; fi
if command -v systemctl >/dev/null; then
    for unit in unattended-upgrades.service apt-daily.timer apt-daily-upgrade.timer apt-daily.service apt-daily-upgrade.service; do
        systemctl stop "$unit" 2>/dev/null || true
        systemctl mask "$unit" 2>/dev/null || true
    done
fi

# .NET needs ICU; most images have it, minimal ones don't.
if command -v apt-get >/dev/null && ! ldconfig -p 2>/dev/null | grep -q libicuuc; then
    export DEBIAN_FRONTEND=noninteractive
    apt-get update -q
    apt-get install -yq libicu74 || apt-get install -yq libicu-dev
fi

if [ "$BENCH_MODE" = dry ]; then sleep 30; else sleep 120; fi  # let first-boot activity settle

status "installing .NET SDK $SDK_VERSION"
export DOTNET_ROOT=$ROOT/dotnet HOME=${HOME:-/root}
export DOTNET_CLI_HOME=$ROOT/home NUGET_PACKAGES=$ROOT/nuget
export DOTNET_CLI_TELEMETRY_OPTOUT=1 DOTNET_NOLOGO=1 DOTNET_SKIP_FIRST_TIME_EXPERIENCE=1
export PATH=$DOTNET_ROOT:$PATH
if [ -n "${BENCH_DOTNET:-}" ]; then
    export PATH=$(dirname "$BENCH_DOTNET"):$PATH  # local testing only
else
    curl -fsSL --retry 5 -o "$ROOT/dotnet-install.sh" https://dot.net/v1/dotnet-install.sh
    bash "$ROOT/dotnet-install.sh" --version "$SDK_VERSION" --install-dir "$DOTNET_ROOT" --no-path
fi

rm -rf "$ROOT/src" && mkdir -p "$ROOT/src"
get source.tar.gz "$ROOT/source.tar.gz"
tar -xzf "$ROOT/source.tar.gz" -C "$ROOT/src"

OUT=$ROOT/out
rm -rf "$OUT" && mkdir -p "$OUT"
{
    echo "environment: $ENV_NAME"
    echo "commit: $COMMIT"
    echo "mode: $BENCH_MODE"
    echo "date (UTC): $(date -u +%FT%TZ)"
    imds=$(curl -fsS -m 3 -H Metadata:true 'http://169.254.169.254/metadata/instance/compute?api-version=2021-02-01' 2>/dev/null || true)
    if [ -n "$imds" ]; then
        python3 -c 'import json,sys; c=json.load(sys.stdin); print("vm size:", c["vmSize"]); print("region:", c["location"]); print("image:", c["storageProfile"]["imageReference"]["offer"], c["storageProfile"]["imageReference"]["sku"])' <<<"$imds" || true
    fi
    if command -v lscpu >/dev/null; then lscpu | grep -E '^(Architecture|Model name|CPU\(s\)|Thread\(s\) per core|Core\(s\) per socket|Hypervisor vendor)' || true; fi
    if [ -r /etc/os-release ]; then echo "os: $(. /etc/os-release && echo "$PRETTY_NAME")"; fi
    echo "kernel: $(uname -sr)"
    echo "sdk: $(dotnet --version)"
} >"$OUT/environment.txt"

cd "$ROOT/src"
bench() { dotnet run -c Release --project benchmarks/AsyncLazy.Benchmarks -- "$@"; }
# BenchmarkDotNet exits with 0 even when a filter matches nothing or validation fails, so check
# that each run produced reports.
require_reports() { ls "$ROOT/artifacts/$1/results/"*-report-github.md >/dev/null 2>&1 || fail "$1 produced no reports; see vm.log"; }
job=()
if [ "$BENCH_MODE" = dry ]; then job=(--job dry); fi

status "run 1 of 2: all benchmarks"
bench --filter 'AsyncLazyBenchmarks.*' ${job[@]+"${job[@]}"} --artifacts "$ROOT/artifacts/run1"
require_reports run1

# The second run repeats the scenarios that are most sensitive to a noisy machine, so the two runs
# can be compared, and records the disassembly of the hot path (x64 and arm64 alike).
status "run 2 of 2: hot path and first call again"
disasm=(--disasm)
if [ "$(uname -s)" = Darwin ]; then disasm=(); fi  # local testing: no disassembler on macOS
bench --filter '*HotPath*' '*FirstCall*' ${job[@]+"${job[@]}"} ${disasm[@]+"${disasm[@]}"} --artifacts "$ROOT/artifacts/run2"
require_reports run2

status "packaging results"
for run in "$ROOT"/artifacts/*; do
    [ -d "$run" ] || continue
    name=$(basename "$run")
    mkdir -p "$OUT/$name"
    find "$run" -maxdepth 2 \( -name '*.md' -o -name '*.log' \) -exec cp {} "$OUT/$name/" \;
done
cp "$LOG" "$OUT/vm.log"
tar -czf "$ROOT/results.tar.gz" -C "$OUT" .
put results.tar.gz "$ROOT/results.tar.gz"
status "done"
