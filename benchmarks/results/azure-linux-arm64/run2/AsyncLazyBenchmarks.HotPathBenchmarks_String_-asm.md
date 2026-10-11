## .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.HotPathBenchmarks`1[[System.__Canon, System.Private.CoreLib]].LazyOfTask()
       stp       x29, x30, [sp, #-0x10]!
       mov       x29, sp
       ldr       x0, [x0, #0x10]
       add       x1, x0, #8
; Total bytes of code 16
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.HotPathBenchmarks`1[[System.__Canon, System.Private.CoreLib]].AsyncLazy()
       stp       x29, x30, [sp, #-0x10]!
       mov       x29, sp
       ldr       x0, [x0, #0x18]
       add       x1, x0, #0x10
; Total bytes of code 16
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.HotPathBenchmarks`1[[System.__Canon, System.Private.CoreLib]].Nito()
       stp       x29, x30, [sp, #-0x30]!
       str       x19, [sp, #0x28]
       mov       x29, sp
       ldr       x19, [x0, #0x20]
       ldr       x0, [x19, #8]
       str       x0, [x29, #0x18]
       str       wzr, [x29, #0x24]
       cbz       x0, #0xe8219fc3b438
       bl        #0xe8219fc025e0
       cbz       w0, #0xe8219fc3b454
       movz      w0, #0x1
       str       w0, [x29, #0x24]
       ldr       x0, [x19, #0x18]
       add       x1, x0, #8
; Total bytes of code 56
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.HotPathBenchmarks`1[[System.__Canon, System.Private.CoreLib]].VsThreading()
       stp       x29, x30, [sp, #-0x10]!
       mov       x29, sp
       ldr       x0, [x0, #0x28]
       ldrsb     wzr, [x0]
       mov       x1, xzr
       movz      x2, #0x7c78
       movk      x2, #0x3dcd, lsl #16
       movk      x2, #0xe901, lsl #32
       ldr       x2, [x2]
       ldp       x29, x30, [sp], #0x10
       br        x2; Microsoft.VisualStudio.Threading.AsyncLazy`1[[System.__Canon, System.Private.CoreLib]].GetValueAsync(System.Threading.CancellationToken)
; Total bytes of code 44
```
```assembly
; Microsoft.VisualStudio.Threading.AsyncLazy`1[[System.__Canon, System.Private.CoreLib]].GetValueAsync(System.Threading.CancellationToken)
       stp       x29, x30, [sp, #-0x60]!
       stp       x19, x20, [sp, #0x40]
       stp       x21, x22, [sp, #0x50]
       mov       x29, sp
       stp       xzr, xzr, [x29, #0x20]
       str       x0, [x29, #0x38]
       str       x0, [x29, #0x18]
       str       x1, [x29, #0x30]
       ldr       x19, [x0]
       mov       x1, x19
       ldr       x2, [x1, #0x30]
       ldr       x2, [x2]
       ldr       x2, [x2, #0x18]
       cbz       x2, #0xe9013d22c180
       mov       x0, x2
       bl        #0xe9013d1f24c0
       mov       x20, x0
       add       x14, x20, #8
       ldr       x15, [x29, #0x18]
       bl        CORINFO_HELP_ASSIGN_REF
       ldr       x15, [x29, #0x18]
       ldr       x0, [x15, #0x28]
       cbz       x0, #0xe9013d22c1d8
       add       x0, x0, #0x34
; Total bytes of code 96
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.HotPathBenchmarks`1[[System.__Canon, System.Private.CoreLib]].LazyOfTask_Token()
       stp       x29, x30, [sp, #-0x40]!
       stp       x19, x20, [sp, #0x20]
       stp       x21, x22, [sp, #0x30]
       mov       x29, sp
       str       x0, [x29, #0x18]
       mov       x19, x0
       ldr       x0, [x19, #0x10]
       add       x1, x0, #8
; Total bytes of code 32
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.HotPathBenchmarks`1[[System.__Canon, System.Private.CoreLib]].AsyncLazy_Token()
       stp       x29, x30, [sp, #-0x30]!
       stp       x19, x20, [sp, #0x20]
       mov       x29, sp
       str       x0, [x29, #0x18]
       mov       x19, x0
       ldr       x0, [x19, #0x18]
       ldr       x20, [x19, #8]
       ldrb      w1, [x20, #0x24]
       cbnz      w1, #0xf185cfc2b458
       ldrsb     wzr, [x0]
       add       x1, x20, #0x20
; Total bytes of code 44
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.HotPathBenchmarks`1[[System.__Canon, System.Private.CoreLib]].Nito_Token()
       stp       x29, x30, [sp, #-0x50]!
       stp       x19, x20, [sp, #0x38]
       str       x21, [sp, #0x48]
       mov       x29, sp
       str       x0, [x29, #0x30]
       str       x0, [x29, #0x20]
       ldr       x19, [x0, #0x20]
       ldr       x1, [x19, #8]
       str       x1, [x29, #0x18]
       str       wzr, [x29, #0x2c]
       cbz       x1, #0xecb7bcc3bad8
       mov       x0, x1
       bl        #0xecb7bcc025e0
       cbz       w0, #0xecb7bcc3baf4
       movz      w0, #0x1
       str       w0, [x29, #0x2c]
       ldr       x0, [x19, #0x18]
       add       x1, x0, #8
; Total bytes of code 72
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.HotPathBenchmarks`1[[System.__Canon, System.Private.CoreLib]].VsThreading_Token()
       stp       x29, x30, [sp, #-0x10]!
       mov       x29, sp
       ldr       x1, [x0, #0x28]
       ldr       x2, [x0, #8]
       ldrb      w0, [x2, #0x24]
       cbnz      w0, M00_L00
       mov       x0, x1
       mov       x1, x2
       movz      x2, #0x7cc0
       movk      x2, #0xb32d, lsl #16
       movk      x2, #0xfffd, lsl #32
       ldr       x2, [x2]
       ldr       wzr, [x0]
       ldp       x29, x30, [sp], #0x10
       br        x2; Microsoft.VisualStudio.Threading.AsyncLazy`1[[System.__Canon, System.Private.CoreLib]].GetValueAsync(System.Threading.CancellationToken)
M00_L00:
       movz      w0, #0x46
       movz      x1, #0xfba0
       movk      x1, #0xb338, lsl #16
       movk      x1, #0xfffd, lsl #32
       ldr       x1, [x1]
       blr       x1
       brk       #0xf000
; Total bytes of code 88
```
```assembly
; Microsoft.VisualStudio.Threading.AsyncLazy`1[[System.__Canon, System.Private.CoreLib]].GetValueAsync(System.Threading.CancellationToken)
       stp       x29, x30, [sp, #-0x60]!
       stp       x19, x20, [sp, #0x40]
       stp       x21, x22, [sp, #0x50]
       mov       x29, sp
       stp       xzr, xzr, [x29, #0x20]
       str       x0, [x29, #0x38]
       str       x0, [x29, #0x18]
       str       x1, [x29, #0x30]
       ldr       x19, [x0]
       mov       x1, x19
       ldr       x2, [x1, #0x30]
       ldr       x2, [x2]
       ldr       x2, [x2, #0x18]
       cbz       x2, #0xfffdb282c1ac
       mov       x0, x2
       bl        #0xfffdb27f24c0
       mov       x20, x0
       add       x14, x20, #8
       ldr       x15, [x29, #0x18]
       bl        CORINFO_HELP_ASSIGN_REF
       ldr       x15, [x29, #0x18]
       ldr       x0, [x15, #0x28]
       cbz       x0, #0xfffdb282c204
       add       x0, x0, #0x34
; Total bytes of code 96
```

