## .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.HotPathBenchmarks`1[[System.Int32, System.Private.CoreLib]].LazyOfTask()
       stp       x29, x30, [sp, #-0x10]!
       mov       x29, sp
       ldr       x0, [x0, #0x10]
       add       x1, x0, #8
; Total bytes of code 16
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.HotPathBenchmarks`1[[System.Int32, System.Private.CoreLib]].AsyncLazy()
       stp       x29, x30, [sp, #-0x10]!
       mov       x29, sp
       ldr       x0, [x0, #0x18]
       add       x1, x0, #0x10
; Total bytes of code 16
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.HotPathBenchmarks`1[[System.Int32, System.Private.CoreLib]].Nito()
       stp       x29, x30, [sp, #-0x30]!
       str       x19, [sp, #0x28]
       mov       x29, sp
       ldr       x19, [x0, #0x20]
       ldr       x0, [x19, #8]
       str       x0, [x29, #0x18]
       str       wzr, [x29, #0x24]
       cbz       x0, #0xf5bcee42a0d8
       bl        #0xf5bcee3f25f0
       cbz       w0, #0xf5bcee42a0f4
       movz      w0, #0x1
       str       w0, [x29, #0x24]
       ldr       x0, [x19, #0x18]
       add       x1, x0, #8
; Total bytes of code 56
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.HotPathBenchmarks`1[[System.Int32, System.Private.CoreLib]].VsThreading()
       stp       x29, x30, [sp, #-0x10]!
       mov       x29, sp
       ldr       x0, [x0, #0x28]
       ldrsb     wzr, [x0]
       mov       x1, xzr
       movz      x2, #0x7db0
       movk      x2, #0xbf4d, lsl #16
       movk      x2, #0xf223, lsl #32
       ldr       x2, [x2]
       ldp       x29, x30, [sp], #0x10
       br        x2; Microsoft.VisualStudio.Threading.AsyncLazy`1[[System.Int32, System.Private.CoreLib]].GetValueAsync(System.Threading.CancellationToken)
; Total bytes of code 44
```
```assembly
; Microsoft.VisualStudio.Threading.AsyncLazy`1[[System.Int32, System.Private.CoreLib]].GetValueAsync(System.Threading.CancellationToken)
       stp       x29, x30, [sp, #-0x50]!
       stp       x19, x20, [sp, #0x38]
       str       x21, [sp, #0x48]
       mov       x29, sp
       stp       xzr, xzr, [x29, #0x20]
       str       x0, [x29, #0x18]
       str       x1, [x29, #0x30]
       movz      x0, #0xbea0
       movk      x0, #0xbf52, lsl #16
       movk      x0, #0xf223, lsl #32
       bl        #0xf223be9f24c0
       mov       x19, x0
       add       x14, x19, #8
       ldr       x15, [x29, #0x18]
       bl        CORINFO_HELP_ASSIGN_REF
       ldr       x15, [x29, #0x18]
       ldr       x0, [x15, #0x28]
       cbz       x0, #0xf223bea2aaac
       add       x0, x0, #0x34
; Total bytes of code 76
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.HotPathBenchmarks`1[[System.Int32, System.Private.CoreLib]].LazyOfTask_Token()
       stp       x29, x30, [sp, #-0x30]!
       stp       x19, x20, [sp, #0x18]
       str       x21, [sp, #0x28]
       mov       x29, sp
       mov       x19, x0
       ldr       x0, [x19, #0x10]
       add       x1, x0, #8
; Total bytes of code 28
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.HotPathBenchmarks`1[[System.Int32, System.Private.CoreLib]].AsyncLazy_Token()
       stp       x29, x30, [sp, #-0x10]!
       mov       x29, sp
       ldr       x1, [x0, #0x18]
       ldr       x2, [x0, #8]
       ldrb      w0, [x2, #0x24]
       cbnz      w0, #0xec3348c0a01c
       ldrsb     wzr, [x1]
       add       x0, x2, #0x20
; Total bytes of code 32
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.HotPathBenchmarks`1[[System.Int32, System.Private.CoreLib]].Nito_Token()
       stp       x29, x30, [sp, #-0x40]!
       stp       x19, x20, [sp, #0x28]
       str       x21, [sp, #0x38]
       mov       x29, sp
       mov       x19, x0
       ldr       x20, [x19, #0x20]
       ldr       x0, [x20, #8]
       str       x0, [x29, #0x18]
       str       wzr, [x29, #0x24]
       cbz       x0, #0xf8b41e40a5e0
       bl        #0xf8b41e3d25f0
       cbz       w0, #0xf8b41e40a5fc
       movz      w0, #0x1
       str       w0, [x29, #0x24]
       ldr       x0, [x20, #0x18]
       add       x1, x0, #8
; Total bytes of code 64
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.HotPathBenchmarks`1[[System.Int32, System.Private.CoreLib]].VsThreading_Token()
       stp       x29, x30, [sp, #-0x10]!
       mov       x29, sp
       ldr       x1, [x0, #0x28]
       ldr       x2, [x0, #8]
       ldrb      w0, [x2, #0x24]
       cbnz      w0, M00_L00
       mov       x0, x1
       mov       x1, x2
       movz      x2, #0x7ed0
       movk      x2, #0x4bad, lsl #16
       movk      x2, #0xe876, lsl #32
       ldr       x2, [x2]
       ldr       wzr, [x0]
       ldp       x29, x30, [sp], #0x10
       br        x2; Microsoft.VisualStudio.Threading.AsyncLazy`1[[System.Int32, System.Private.CoreLib]].GetValueAsync(System.Threading.CancellationToken)
M00_L00:
       movz      w0, #0x46
       movz      x1, #0xfac8
       movk      x1, #0x4bb8, lsl #16
       movk      x1, #0xe876, lsl #32
       ldr       x1, [x1]
       blr       x1
       brk       #0xf000
; Total bytes of code 88
```
```assembly
; Microsoft.VisualStudio.Threading.AsyncLazy`1[[System.Int32, System.Private.CoreLib]].GetValueAsync(System.Threading.CancellationToken)
       stp       x29, x30, [sp, #-0x50]!
       stp       x19, x20, [sp, #0x38]
       str       x21, [sp, #0x48]
       mov       x29, sp
       stp       xzr, xzr, [x29, #0x20]
       str       x0, [x29, #0x18]
       str       x1, [x29, #0x30]
       movz      x0, #0xbf40
       movk      x0, #0x4bb2, lsl #16
       movk      x0, #0xe876, lsl #32
       bl        #0xe8764aff24c0
       mov       x19, x0
       add       x14, x19, #8
       ldr       x15, [x29, #0x18]
       bl        CORINFO_HELP_ASSIGN_REF
       ldr       x15, [x29, #0x18]
       ldr       x0, [x15, #0x28]
       cbz       x0, #0xe8764b02aad8
       add       x0, x0, #0x34
; Total bytes of code 76
```

