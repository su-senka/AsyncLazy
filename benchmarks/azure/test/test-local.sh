#!/usr/bin/env bash

# Exercises run.sh end to end without Azure: a fake `az` (test/az), a local stand-in for the blob
# container (test/blob-server.py), and the VM scripts running on this machine in dry mode.

set -euo pipefail
here=$(cd "$(dirname "$0")" && pwd)
repo=$(cd "$here/../../.." && pwd)
work=$(mktemp -d "${TMPDIR:-/tmp}/asynclazy-azure-test.XXXXXX")
trap 'status=$?; kill $server 2>/dev/null || true; if [ $status -eq 0 ]; then rm -rf "$work"; else echo "kept for inspection: $work"; fi' EXIT

mkdir -p "$work/blobs" "$work/state"
python3 "$here/blob-server.py" "$work/blobs" "$work/port" &
server=$!
for _ in $(seq 50); do [ -s "$work/port" ] && break; sleep 0.1; done

export PATH="$here:$PATH" FAKE_AZ_STATE="$work/state"
export BENCH_TEST_BLOB_BASE="http://127.0.0.1:$(cat "$work/port")/{account}" BENCH_TEST_ROOT="$work/vm-{env}"
export BENCH_TEST_POLL=2 BENCH_CAFFEINATED=1 BENCH_SDK_VERSION=$(dotnet --version)
[ "${1:-}" = --with-sdk-install ] || export BENCH_DOTNET=$(command -v dotnet)
export TMPDIR="$work/tmp"; mkdir -p "$TMPDIR"
pass() { echo "PASS: $*"; }
fail() { echo "FAIL: $*"; exit 1; }

echo "== 1. Linux environment, dry run"
"$repo/benchmarks/azure/run.sh" --dry --allow-dirty linux-x64 || fail "linux-x64 run failed"
results="$TMPDIR/asynclazy-azure-dry/azure-linux-x64"
[ -s "$results/environment.txt" ] && pass "environment.txt" || fail "no environment.txt"
ls "$results"/run1/*HotPath*-report-github.md >/dev/null && pass "run 1 reports" || fail "no run 1 reports"
ls "$results"/run2/*FirstCall*-report-github.md >/dev/null && pass "run 2 reports" || fail "no run 2 reports"
[ -s "$results/vm.log" ] && pass "vm.log" || fail "no vm.log"
! grep -q 'sig=' "$results/vm.log" && pass "no storage token in the log" || fail "storage token leaked into the log"
grep -q -- '--nsg-rule NONE' "$work/state/calls" && pass "no inbound ports" || fail "inbound ports opened"

echo "== 2. Windows environment under pwsh (expected to fail at the disassembler on macOS)"
# Microsoft's dotnet-install.ps1 works only on Windows, so the Windows script always uses this machine's SDK here.
if BENCH_DOTNET=$(command -v dotnet) "$repo/benchmarks/azure/run.sh" --dry --allow-dirty windows-x64; then fail "windows-x64 should have failed on macOS"; fi
grep -q 'run 2 of 2' "$work/vm-windows-x64/vm.log" && pass "Windows script reached run 2" || fail "Windows script stopped early"
grep -q 'run2 produced no reports' "$work/vm-windows-x64/vm.log" && pass "failed for the expected reason (no disassembler on macOS)" || fail "failed for another reason; see $work/vm-windows-x64/vm.log"
ls "$work/vm-windows-x64/artifacts/run1/results/"*HotPath*-report-github.md >/dev/null && pass "Windows run 1 reports" || fail "no Windows run 1 reports"
grep -q -- '--admin-password' "$work/state/calls" && pass "Windows password passed" || fail "no Windows password"
grep -q -- '--patch-mode Manual' "$work/state/calls" && pass "Windows updates off" || fail "Windows patch mode not set"

echo "== 3. Every resource group was deleted"
created=$(sort "$work/state/groups"); deleted=$(sort "$work/state/deleted")
[ "$created" = "$deleted" ] && pass "$(wc -l <"$work/state/groups" | tr -d ' ') created, all deleted" || fail "created: $created / deleted: $deleted"

echo "== 4. Interrupted while a VM is being created"
FAKE_AZ_CREATE_SECONDS=20 "$repo/benchmarks/azure/run.sh" --dry --allow-dirty linux-arm64 &
run=$!
for _ in $(seq 100); do grep -q 'vm create' "$work/state/calls" 2>/dev/null && [ "$(grep -c 'vm create' "$work/state/calls")" -ge 3 ] && break; sleep 0.2; done
kill -TERM "$run"
wait "$run" && fail "an interrupted run should not succeed" || true
created=$(sort "$work/state/groups"); deleted=$(sort "$work/state/deleted")
[ "$created" = "$deleted" ] && pass "interrupted run deleted its resource group" || fail "left behind: $(comm -23 <(echo "$created") <(echo "$deleted"))"

echo "== 5. Two environments in parallel"
"$repo/benchmarks/azure/run.sh" --dry --allow-dirty --parallel linux-x64 linux-x64-amd 2>&1 | tail -3 || true
for env in linux-x64 linux-x64-amd; do
    ls "$TMPDIR/asynclazy-azure-dry/azure-$env"/run1/*-report-github.md >/dev/null 2>&1 && pass "parallel: $env results" || fail "parallel: no $env results"
done
created=$(sort "$work/state/groups"); deleted=$(sort "$work/state/deleted")
[ "$created" = "$deleted" ] && pass "parallel: all resource groups deleted" || fail "parallel: left behind: $(comm -23 <(echo "$created") <(echo "$deleted"))"

echo "== 6. cleanup finds nothing left"
"$repo/benchmarks/azure/run.sh" cleanup 2>&1 | grep -q 'no benchmark resource groups' && pass "cleanup" || fail "cleanup found leftovers"
echo "All checks passed."
