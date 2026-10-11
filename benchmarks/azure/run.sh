#!/usr/bin/env bash

# Runs the benchmarks on Azure VMs, one VM per environment, and copies the reports into
# benchmarks/results/azure-<environment>/. Every resource is created in a resource group
# of its own, which is deleted when the run ends, however it ends.
#
#   benchmarks/azure/run.sh [options] <environment>... | all
#   benchmarks/azure/run.sh cleanup        delete every resource group this script created
#
# Environments: linux-x64, windows-x64, linux-arm64, linux-x64-amd ("all" runs all four).
# Options:
#   --dry              BenchmarkDotNet's dry job: checks the whole pipeline in about 20 minutes;
#                      results go to a temporary folder, not the repository
#   --parallel         run the environments at the same time (needs quota for all of them)
#   --location <name>  Azure region (default: swedencentral)
#   --keep             don't delete the resource group at the end (debugging only)
#   --allow-dirty      run even with uncommitted changes (they are not benchmarked)

set -euo pipefail

usage() { sed -n '3,17p' "$0" | sed 's/^# \{0,1\}//'; exit "${1:-0}"; }

SCRIPT_DIR=$(cd "$(dirname "$0")" && pwd)
REPO_ROOT=$(cd "$SCRIPT_DIR/../.." && pwd)
ALL_ENVS="linux-x64 windows-x64 linux-arm64 linux-x64-amd"
TAG="purpose=asynclazy-bench"
LOCATION=swedencentral DRY=0 PARALLEL=0 KEEP=0 ALLOW_DIRTY=0 ENVS=""

# Hooks for the local test harness only; never set them for a real run. In them, {account} and
# {env} stand for the run's storage account and environment.
TEST_BLOB_BASE=${BENCH_TEST_BLOB_BASE:-}
TEST_ROOT=${BENCH_TEST_ROOT:-}
POLL_SECONDS=${BENCH_TEST_POLL:-60}

CURRENT_ENV=""
log() { printf '%s %s%s\n' "$(date +%H:%M:%S)" "${CURRENT_ENV:+[$CURRENT_ENV] }" "$*" >&2; }
die() { log "error: $*"; exit 1; }

env_os() { case "$1" in windows-*) echo windows ;; *) echo linux ;; esac; }
# 8 vCPUs by default. BENCH_VM_VCPUS=4 fits the free trial's limit of 4 vCPUs (one VM at a time).
VCPUS_PER_VM=${BENCH_VM_VCPUS:-8}
case "$VCPUS_PER_VM" in 4 | 8 | 16) ;; *) echo "BENCH_VM_VCPUS must be 4, 8 or 16" >&2; exit 1 ;; esac
env_size() {
    case "$1" in
    linux-x64 | windows-x64) echo "Standard_D${VCPUS_PER_VM}s_v5" ;;  # Intel Xeon (Ice Lake or Sapphire Rapids)
    linux-arm64) echo "Standard_D${VCPUS_PER_VM}ps_v5" ;;             # Ampere Altra: a whole core per vCPU
    linux-x64-amd) echo "Standard_D${VCPUS_PER_VM}as_v5" ;;           # AMD EPYC (Milan or Genoa)
    esac
}
env_family() {
    case "$1" in
    linux-x64 | windows-x64) echo standardDSv5Family ;;
    linux-arm64) echo standardDPSv5Family ;;
    linux-x64-amd) echo standardDASv5Family ;;
    esac
}
env_images() {  # candidates, first available wins
    case "$1" in
    linux-x64 | linux-x64-amd) echo "Canonical:ubuntu-24_04-lts:server:latest" ;;
    linux-arm64) echo "Canonical:ubuntu-24_04-lts:server-arm64:latest" ;;
    windows-x64) echo "MicrosoftWindowsServer:WindowsServer:2025-datacenter-g2:latest MicrosoftWindowsServer:WindowsServer:2025-datacenter:latest MicrosoftWindowsServer:WindowsServer:2022-datacenter-g2:latest" ;;
    esac
}

# ---------------------------------------------------------------------------------------------
# Arguments

[ $# -gt 0 ] || usage 1
ORIGINAL_ARGS=("$@")
COMMAND=run
while [ $# -gt 0 ]; do
    case "$1" in
    -h | --help) usage 0 ;;
    --dry) DRY=1 ;;
    --parallel) PARALLEL=1 ;;
    --keep) KEEP=1 ;;
    --allow-dirty) ALLOW_DIRTY=1 ;;
    --location) [ $# -ge 2 ] || usage 1; LOCATION=$2; shift ;;
    cleanup) COMMAND=cleanup ;;
    all) ENVS="$ENVS $ALL_ENVS" ;;
    linux-x64 | windows-x64 | linux-arm64 | linux-x64-amd) ENVS="$ENVS $1" ;;
    *) log "unknown argument: $1"; usage 1 ;;
    esac
    shift
done

command -v az >/dev/null || die "the Azure CLI is required (macOS: brew install azure-cli)"
for tool in python3 curl tar git ssh-keygen; do
    command -v "$tool" >/dev/null || die "$tool is required"
done
# 'account show' reads only the local cache; getting a token proves the sign-in is still valid.
az account get-access-token -o none 2>/dev/null || die "not signed in to Azure, or the sign-in expired; run: az login"

if [ "$COMMAND" = cleanup ]; then
    groups=$(az group list --tag "$TAG" --query '[].name' -o tsv)
    [ -n "$groups" ] || { log "no benchmark resource groups found"; exit 0; }
    for group in $groups; do
        log "deleting resource group $group"
        az group delete -n "$group" --yes --no-wait -o none
    done
    log "deletion continues in Azure; it takes a few minutes"
    exit 0
fi

ENVS=$(printf '%s\n' $ENVS | awk '!seen[$0]++' | paste -sd ' ' -)
[ -n "${ENVS// /}" ] || usage 1

# Keep the Mac awake for the whole run (the lid must stay open on battery).
if command -v caffeinate >/dev/null && [ -z "${BENCH_CAFFEINATED:-}" ]; then
    export BENCH_CAFFEINATED=1
    exec caffeinate -is "$0" "${ORIGINAL_ARGS[@]}"
fi

WORK=$(mktemp -d "${TMPDIR:-/tmp}/asynclazy-azure.XXXXXX")
trap 'rm -rf "$WORK"' EXIT

# ---------------------------------------------------------------------------------------------
# Checks, before anything is created

subscription=$(az account show --query name -o tsv)
log "subscription: $subscription; region: $LOCATION; environments: $ENVS$([ "$DRY" = 1 ] && echo ' (dry run)')"

if [ "$ALLOW_DIRTY" = 0 ] && [ -n "$(git -C "$REPO_ROOT" status --porcelain --untracked-files=no)" ]; then
    die "uncommitted changes; the VMs benchmark the last commit. Commit first, or pass --allow-dirty."
fi
COMMIT=$(git -C "$REPO_ROOT" rev-parse --short=12 HEAD)

for namespace in Microsoft.Compute Microsoft.Network Microsoft.Storage Microsoft.DevTestLab; do
    state=$(az provider show -n "$namespace" --query registrationState -o tsv) || die "couldn't read the state of $namespace"
    if [ "$state" != Registered ]; then
        log "registering resource provider $namespace (once per subscription)"
        az provider register -n "$namespace" --wait -o none
    fi
done

usage_json=$(az vm list-usage -l "$LOCATION" -o json)
quota_args=""
for env in $ENVS; do
    size=$(env_size "$env")
    az vm list-skus -l "$LOCATION" --size "$size" --resource-type virtualMachines -o json |
        python3 -c '
import json, sys
size, location = sys.argv[1], sys.argv[2]
skus = [s for s in json.load(sys.stdin) if s["name"] == size]
if not skus:
    sys.exit(f"{size} is not offered in {location}; try another --location")
reasons = [r.get("reasonCode", "") for r in skus[0].get("restrictions", []) if r.get("type") == "Location"]
if reasons:
    sys.exit("%s is restricted for this subscription in %s (%s); try another --location" % (size, location, ", ".join(reasons)))
' "$size" "$LOCATION" || die "size check failed for $env"

    image=""
    for candidate in $(env_images "$env"); do
        if az vm image show --urn "$candidate" -o none 2>/dev/null; then image=$candidate; break; fi
    done
    [ -n "$image" ] || die "no image found for $env in $LOCATION (tried: $(env_images "$env"))"
    echo "$image" >"$WORK/image.$env"
    quota_args="$quota_args $(env_family "$env")"
done

python3 -c '
import json, sys
parallel, per_vm, families = sys.argv[1] == "1", int(sys.argv[2]), sys.argv[3:]
usage = {u["name"]["value"]: u for u in json.load(sys.stdin)}
need = {}
for family in families:
    need[family] = need.get(family, 0) + per_vm if parallel else per_vm
need["cores"] = per_vm * len(families) if parallel else per_vm
short = False
for name, n in need.items():
    u = usage.get(name)
    if u is None:
        print(f"  quota {name}: not listed; assuming it is enough", file=sys.stderr)
        continue
    free = int(u["limit"]) - int(u["currentValue"])
    label = "total regional vCPUs" if name == "cores" else name
    ok = free >= n
    short |= not ok
    print("  quota %s: need %d, free %d%s" % (label, n, free, "" if ok else "  <-- not enough"), file=sys.stderr)
if short:
    sys.exit("Request a quota increase: Azure portal > Quotas > Compute, for the region and families above. Or run without --parallel.")
' "$PARALLEL" "$VCPUS_PER_VM" $quota_args <<<"$usage_json" || die "not enough quota"

SDK_VERSION=${BENCH_SDK_VERSION:-$(curl -fsSL https://builds.dotnet.microsoft.com/dotnet/release-metadata/10.0/releases.json |
    python3 -c 'import json,sys; print(json.load(sys.stdin)["latest-sdk"])')}
log "commit $COMMIT, .NET SDK $SDK_VERSION (the same on every VM)"

git -C "$REPO_ROOT" archive --format=tar.gz -o "$WORK/source.tar.gz" HEAD

if [ "$DRY" = 1 ]; then
    RESULTS_ROOT="${TMPDIR:-/tmp}/asynclazy-azure-dry"
    TIMEOUT_SECONDS=$((90 * 60))
else
    RESULTS_ROOT="$REPO_ROOT/benchmarks/results"
    TIMEOUT_SECONDS=$((6 * 3600))
fi

# ---------------------------------------------------------------------------------------------
# One environment, start to finish. Always started in the background (run_env ... &), so it is a
# child process of its own: its variables stay local, and its EXIT trap deletes its resources. The
# body is { } rather than ( ): a ( ) body would fork a second process, and a TERM sent to the
# first would leave the second running.

render() {  # render <template> <output>: replaces __NAME__ placeholders with values from the environment
    python3 - "$1" "$2" <<'EOF'
import os, sys
text = open(sys.argv[1]).read()
for key in ("ROOT", "BASE", "SAS", "SDK", "ENV", "COMMIT", "MODE", "RUNID"):
    text = text.replace(f"__{key}__", os.environ["R_" + key])
open(sys.argv[2], "w").write(text)
EOF
}

run_env() {
    CURRENT_ENV=$1
    env=$1
    os=$(env_os "$env")
    size=$(env_size "$env")
    image=$(cat "$WORK/image.$env")
    rg="asynclazy-bench-$env-$(date +%Y%m%d-%H%M%S)"
    created=0

    cleanup() {
        [ "$created" = 1 ] || return 0
        if [ "$KEEP" = 1 ]; then
            log "kept resource group $rg (--keep); delete it with: az group delete -n $rg --yes"
        else
            log "deleting resource group $rg (continues in Azure)"
            az group delete -n "$rg" --yes --no-wait -o none ||
                log "warning: couldn't delete $rg; run: benchmarks/azure/run.sh cleanup"
        fi
    }
    trap cleanup EXIT
    trap 'kill $(jobs -p) 2>/dev/null || true; exit 143' TERM

    log "creating resource group $rg"
    az group create -n "$rg" -l "$LOCATION" --tags "$TAG" -o none
    created=1

    account="albench$(python3 -c 'import secrets; print(secrets.token_hex(6))')"
    az storage account create -g "$rg" -n "$account" -l "$LOCATION" --sku Standard_LRS --kind StorageV2 \
        --min-tls-version TLS1_2 --allow-blob-public-access false --tags "$TAG" -o none
    key=$(az storage account keys list -g "$rg" -n "$account" --query '[0].value' -o tsv)
    az storage container create --name bench --account-name "$account" --account-key "$key" -o none
    expiry=$(python3 -c 'import datetime as d; print((d.datetime.now(d.timezone.utc) + d.timedelta(hours=12)).strftime("%Y-%m-%dT%H:%MZ"))')
    sas=$(az storage container generate-sas --name bench --account-name "$account" --account-key "$key" \
        --permissions racwl --expiry "$expiry" --https-only -o tsv)
    base=${TEST_BLOB_BASE:-https://$account.blob.core.windows.net/bench}
    base=${base//\{account\}/$account}

    put_blob() { curl -fsS --retry 3 -X PUT -H 'x-ms-blob-type: BlockBlob' --data-binary "@$2" "$base/$1?$sas" >/dev/null; }
    get_blob() { curl -fsS --retry 3 -o "$2" "$base/$1?$sas"; }

    put_blob source.tar.gz "$WORK/source.tar.gz"
    if [ "$os" = windows ]; then put_blob vm-windows.ps1 "$SCRIPT_DIR/vm-windows.ps1"; else put_blob vm-linux.sh "$SCRIPT_DIR/vm-linux.sh"; fi

    log "creating VM: $size, $image"
    create=(vm create -g "$rg" -n bench -l "$LOCATION" --size "$size" --image "$image"
        --admin-username benchadmin --public-ip-sku Standard --nsg-rule NONE --tags "$TAG" -o none --only-show-errors)
    if [ "$os" = windows ]; then
        password=$(python3 -c 'import secrets, string; a = string.ascii_letters + string.digits; print("Aa1!" + "".join(secrets.choice(a) for _ in range(28)))')
        create+=(--admin-password "$password" --patch-mode Manual --enable-auto-update false)
    else
        ssh-keygen -q -t rsa -b 3072 -N '' -C asynclazy-bench -f "$WORK/key.$env" # never used; no inbound port is open
        create+=(--authentication-type ssh --ssh-key-values "$WORK/key.$env.pub")
    fi
    az "${create[@]}"

    # A backstop if this script dies without cleaning up: the VM shuts itself down (and stops
    # costing compute) a few hours after the run's expected end.
    shutdown=$(python3 -c 'import datetime as d, sys; print((d.datetime.now(d.timezone.utc) + d.timedelta(seconds=int(sys.argv[1]) + 3600)).strftime("%H%M"))' "$TIMEOUT_SECONDS")
    az vm auto-shutdown -g "$rg" -n bench --time "$shutdown" -o none 2>/dev/null ||
        log "warning: couldn't set auto-shutdown; the VM is still deleted at the end"

    # Every status line the VM writes starts with this ID, so a stale status can never be mistaken for this run's.
    run_id=$(python3 -c 'import secrets; print(secrets.token_hex(8))')
    export R_ROOT R_BASE="$base" R_SAS="$sas" R_SDK="$SDK_VERSION" R_ENV="$env" R_COMMIT="$COMMIT" R_MODE R_RUNID="$run_id"
    R_MODE=$([ "$DRY" = 1 ] && echo dry || echo full)
    if [ "$os" = windows ]; then
        R_ROOT=${TEST_ROOT:-C:\\bench}
        R_ROOT=${R_ROOT//\{env\}/$env}
        render "$SCRIPT_DIR/launch-windows.ps1.template" "$WORK/launch.$env"
        command_id=RunPowerShellScript
    else
        R_ROOT=${TEST_ROOT:-/opt/bench}
        R_ROOT=${R_ROOT//\{env\}/$env}
        render "$SCRIPT_DIR/launch-linux.sh.template" "$WORK/launch.$env"
        command_id=RunShellScript
    fi

    log "starting the benchmarks on the VM"
    az vm run-command invoke -g "$rg" -n bench --command-id "$command_id" --scripts @"$WORK/launch.$env" -o json >"$WORK/launch.$env.json"
    python3 -c '
import json, sys
messages = " ".join(v.get("message", "") for v in json.load(open(sys.argv[1])).get("value", []))
sys.exit(0 if "launched" in messages else "the VM did not start the benchmarks:\n" + messages[-2000:])
' "$WORK/launch.$env.json" || die "launch failed"
    rm -f "$WORK/launch.$env"  # it contains the storage token

    started=$(date +%s)
    deadline=$((started + TIMEOUT_SECONDS))
    last=""
    while :; do
        status=$(curl -fsS "$base/status.txt?$sas" 2>/dev/null | tr -d '\r' || true)  # Windows writes CRLF
        case "$status" in "$run_id|"*) status=${status#"$run_id|"} ;; *) status="" ;; esac
        if [ -n "$status" ] && [ "$status" != "$last" ]; then log "$status"; last=$status; fi
        case "$status" in
        done) break ;;
        failed*)
            failure_log="${TMPDIR:-/tmp}/asynclazy-azure-$env-vm.log"
            get_blob vm.log "$failure_log" 2>/dev/null && log "VM log: $failure_log"
            die "the run failed on the VM"
            ;;
        esac
        if [ -z "$last" ] && [ "$(date +%s)" -ge $((started + 15 * 60)) ]; then
            die "the VM never reported progress; its script didn't start (see the VM's boot diagnostics in the portal, or rerun with --keep)"
        fi
        if [ "$(date +%s)" -ge "$deadline" ]; then die "timed out after $((TIMEOUT_SECONDS / 60)) minutes"; fi
        sleep "$POLL_SECONDS" &
        wait $!  # unlike a foreground sleep, an interrupt doesn't have to wait for this to end
    done

    dest="$RESULTS_ROOT/azure-$env"
    if [ -e "$dest" ]; then
        previous="${TMPDIR:-/tmp}/asynclazy-azure-previous/azure-$env-$(date +%Y%m%d-%H%M%S)"
        mkdir -p "$(dirname "$previous")"
        mv "$dest" "$previous"
        log "moved the previous results to $previous"
    fi
    mkdir -p "$dest"
    get_blob results.tar.gz "$WORK/results.$env.tar.gz"
    tar -xzf "$WORK/results.$env.tar.gz" -C "$dest"
    log "results: $dest"
}

# ---------------------------------------------------------------------------------------------
# Run, sequentially or in parallel. Each environment is a child process, so Ctrl-C can tell each
# one to clean up (it finishes its current Azure call first, which can take a minute or two).

children=""
on_interrupt() {
    log "interrupted; deleting what was created (this can take a minute or two; don't press Ctrl-C again)"
    for pid in $children; do kill -TERM "$pid" 2>/dev/null || true; done
    # 'wait' returns early inside a trap handler, so poll until every child has cleaned up and exited.
    for pid in $children; do while kill -0 "$pid" 2>/dev/null; do sleep 1; done; done
    exit 130
}
trap on_interrupt INT TERM

failed=""
if [ "$PARALLEL" = 1 ]; then
    for env in $ENVS; do
        run_env "$env" &
        children="$children $!"
        echo "$env" >"$WORK/pid.$!"
    done
    for pid in $children; do
        wait "$pid" || failed="$failed $(cat "$WORK/pid.$pid")"
    done
else
    for env in $ENVS; do
        run_env "$env" &
        children=$!
        wait "$children" || failed="$failed $env"
        children=""
    done
fi

if [ -n "$failed" ]; then die "failed:$failed (the other environments, if any, succeeded)"; fi
log "all done; results are in $RESULTS_ROOT/azure-*"
