## .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.Int32, System.Private.CoreLib]].LazyOfTask()
       stp       x29, x30, [sp, #-0x20]!
       stp       x19, x20, [sp, #0x10]
       mov       x29, sp
       mov       x19, x0
       movz      x0, #0x360
       movk      x0, #0x7075, lsl #16
       movk      x0, #0xef71, lsl #32
       bl        #0xef716fbd24c0
       mov       x20, x0
       ldr       x15, [x19, #8]
       cbz       x15, #0xef716fc04ef4
       add       x14, x20, #0x10
       bl        CORINFO_HELP_ASSIGN_REF
       movz      x0, #0xfa00
       movk      x0, #0x705b, lsl #16
       movk      x0, #0xef71, lsl #32
       bl        #0xef716fbd24c0
       movz      w14, #0x8
       str       w14, [x0, #0x10]
       add       x1, x20, #8
       mov       x14, x1
       mov       x15, x0
       bl        CORINFO_HELP_ASSIGN_REF
; Total bytes of code 92
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.Int32, System.Private.CoreLib]](System.Threading.Tasks.Task`1<Int32>)
       stp       x29, x30, [sp, #-0x20]!
       str       x19, [sp, #0x18]
       mov       x29, sp
       mov       x19, x0
       add       x0, x19, #0x34
; Total bytes of code 20
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.Int32, System.Private.CoreLib]].LazyOfTask_TaskRun()
       stp       x29, x30, [sp, #-0x20]!
       stp       x19, x20, [sp, #0x10]
       mov       x29, sp
       mov       x19, x0
       movz      x0, #0xfc38
       movk      x0, #0xaed3, lsl #16
       movk      x0, #0xf7c0, lsl #32
       bl        #0xf7c0ae1d24c0
       mov       x20, x0
       ldr       x15, [x19, #0x10]
       cbz       x15, #0xf7c0ae213d9c
       add       x14, x20, #0x10
       bl        CORINFO_HELP_ASSIGN_REF
       movz      x0, #0xfa00
       movk      x0, #0xaebb, lsl #16
       movk      x0, #0xf7c0, lsl #32
       bl        #0xf7c0ae1d24c0
       movz      w14, #0x8
       str       w14, [x0, #0x10]
       add       x1, x20, #8
       mov       x14, x1
       mov       x15, x0
       bl        CORINFO_HELP_ASSIGN_REF
; Total bytes of code 92
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.Int32, System.Private.CoreLib]](System.Threading.Tasks.Task`1<Int32>)
       stp       x29, x30, [sp, #-0x20]!
       str       x19, [sp, #0x18]
       mov       x29, sp
       mov       x19, x0
       add       x0, x19, #0x34
; Total bytes of code 20
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.Int32, System.Private.CoreLib]].AsyncLazy()
       stp       x29, x30, [sp, #-0x20]!
       str       x19, [sp, #0x18]
       mov       x29, sp
       mov       x19, x0
       movz      x0, #0xa10
       movk      x0, #0xf935, lsl #16
       movk      x0, #0xe602, lsl #32
       bl        #0xe602f87d24c0
       ldr       x15, [x19, #8]
       cbz       x15, #0xe602f8814654
       add       x14, x0, #0x18
       bl        CORINFO_HELP_ASSIGN_REF
       add       x1, x0, #0x10
; Total bytes of code 52
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.Int32, System.Private.CoreLib]](System.Threading.Tasks.Task`1<Int32>)
       stp       x29, x30, [sp, #-0x20]!
       str       x19, [sp, #0x18]
       mov       x29, sp
       mov       x19, x0
       add       x0, x19, #0x34
; Total bytes of code 20
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.Int32, System.Private.CoreLib]].AsyncLazy_NoHop()
       stp       x29, x30, [sp, #-0x90]!
       stp       x19, x20, [sp, #0x68]
       stp       x21, x22, [sp, #0x78]
       str       x23, [sp, #0x88]
       mov       x29, sp
       add       x9, x29, #0x30
       movi      v16.16b, #0
       stp       q16, q16, [x9]
       stp       xzr, xzr, [x9, #0x20]
       str       xzr, [x9, #0x30]
       mov       x19, x0
       movz      x0, #0xa18
       movk      x0, #0x5e77, lsl #16
       movk      x0, #0xf16f, lsl #32
       bl        #0xf16f5dbf24c0
       mov       x20, x0
       ldr       x15, [x19, #8]
       cbz       x15, #0xf16f5dc2a2a0
       add       x14, x20, #0x18
       bl        CORINFO_HELP_ASSIGN_REF
       add       x1, x20, #0x10
; Total bytes of code 84
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.Int32, System.Private.CoreLib]](System.Threading.Tasks.Task`1<Int32>)
       stp       x29, x30, [sp, #-0x20]!
       str       x19, [sp, #0x18]
       mov       x29, sp
       mov       x19, x0
       add       x0, x19, #0x34
; Total bytes of code 20
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.Int32, System.Private.CoreLib]].AsyncLazy_NoRecursionDetection()
       stp       x29, x30, [sp, #-0x40]!
       stp       x19, x20, [sp, #0x10]
       stp       x21, x22, [sp, #0x20]
       stp       x23, x24, [sp, #0x30]
       mov       x29, sp
       mov       x19, x0
       movz      x0, #0x630
       movk      x0, #0x1955, lsl #16
       movk      x0, #0xe78c, lsl #32
       bl        #0xe78c189d24c0
       mov       x20, x0
       ldr       x15, [x19, #8]
       cbz       x15, #0xe78c18a14034
       add       x14, x20, #0x18
       bl        CORINFO_HELP_ASSIGN_REF
       add       x1, x20, #0x10
; Total bytes of code 64
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.Int32, System.Private.CoreLib]](System.Threading.Tasks.Task`1<Int32>)
       stp       x29, x30, [sp, #-0x20]!
       str       x19, [sp, #0x18]
       mov       x29, sp
       mov       x19, x0
       add       x0, x19, #0x34
; Total bytes of code 20
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.Int32, System.Private.CoreLib]].Nito()
       stp       x29, x30, [sp, #-0x40]!
       stp       x19, x20, [sp, #0x28]
       str       x21, [sp, #0x38]
       mov       x29, sp
       ldr       x19, [x0, #8]
       cbz       x19, #0xfaf777045ab8
       movz      x0, #0x1c30
       movk      x0, #0x77b8, lsl #16
       movk      x0, #0xfaf7, lsl #32
       bl        #0xfaf7770024c0
       mov       x20, x0
       add       x14, x20, #8
       mov       x15, x19
       bl        CORINFO_HELP_ASSIGN_REF
       movz      x0, #0xe0b8
       movk      x0, #0x77af, lsl #16
       movk      x0, #0xfaf7, lsl #32
       bl        #0xfaf7770024c0
       mov       x19, x0
       add       x14, x19, #8
       mov       x15, x20
       bl        CORINFO_HELP_ASSIGN_REF
       movz      x0, #0x1908
       movk      x0, #0x77b5, lsl #16
       movk      x0, #0xfaf7, lsl #32
       str       x0, [x19, #0x18]
       movz      x0, #0x47b0
       movk      x0, #0x75e5, lsl #16
       movk      x0, #0xfaf7, lsl #32
       bl        #0xfaf7770024c0
       mov       x20, x0
       movz      x0, #0xe90
       movk      x0, #0x77b8, lsl #16
       movk      x0, #0xfaf7, lsl #32
       bl        #0xfaf7770024c0
       mov       x21, x0
       add       x14, x21, #0x10
       mov       x15, x19
       bl        CORINFO_HELP_ASSIGN_REF
       movz      x0, #0xfa00
       movk      x0, #0x779e, lsl #16
       movk      x0, #0xfaf7, lsl #32
       bl        #0xfaf7770024c0
       movz      w14, #0x8
       str       w14, [x0, #0x10]
       add       x19, x21, #8
       mov       x14, x19
       mov       x15, x0
       bl        CORINFO_HELP_ASSIGN_REF
       str       x20, [x29, #0x18]
       str       wzr, [x29, #0x24]
       mov       x0, x20
       bl        #0xfaf777002610
       cbz       w0, #0xfaf777045a78
       movz      w0, #0x1
       str       w0, [x29, #0x24]
; Total bytes of code 224
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.Int32, System.Private.CoreLib]](System.Threading.Tasks.Task`1<Int32>)
       stp       x29, x30, [sp, #-0x20]!
       str       x19, [sp, #0x18]
       mov       x29, sp
       mov       x19, x0
       add       x0, x19, #0x34
; Total bytes of code 20
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.Int32, System.Private.CoreLib]].Nito_ExecuteOnCallingThread()
       stp       x29, x30, [sp, #-0x40]!
       stp       x19, x20, [sp, #0x28]
       str       x21, [sp, #0x38]
       mov       x29, sp
       ldr       x19, [x0, #8]
       cbz       x19, #0xf78731e05728
       movz      x0, #0x47b0
       movk      x0, #0x30c2, lsl #16
       movk      x0, #0xf787, lsl #32
       bl        #0xf78731dd24c0
       mov       x20, x0
       movz      x0, #0xaa8
       movk      x0, #0x3295, lsl #16
       movk      x0, #0xf787, lsl #32
       bl        #0xf78731dd24c0
       mov       x21, x0
       add       x14, x21, #0x10
       mov       x15, x19
       bl        CORINFO_HELP_ASSIGN_REF
       movz      x0, #0xfa00
       movk      x0, #0x327b, lsl #16
       movk      x0, #0xf787, lsl #32
       bl        #0xf78731dd24c0
       movz      w14, #0x8
       str       w14, [x0, #0x10]
       add       x19, x21, #8
       mov       x14, x19
       mov       x15, x0
       bl        CORINFO_HELP_ASSIGN_REF
       str       x20, [x29, #0x18]
       str       wzr, [x29, #0x24]
       mov       x0, x20
       bl        #0xf78731dd25e0
       cbz       w0, #0xf78731e056e8
       movz      w0, #0x1
       str       w0, [x29, #0x24]
; Total bytes of code 144
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.Int32, System.Private.CoreLib]](System.Threading.Tasks.Task`1<Int32>)
       stp       x29, x30, [sp, #-0x20]!
       str       x19, [sp, #0x18]
       mov       x29, sp
       mov       x19, x0
       add       x0, x19, #0x34
; Total bytes of code 20
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.Int32, System.Private.CoreLib]].VsThreading()
       stp       x29, x30, [sp, #-0x20]!
       stp       x19, x20, [sp, #0x10]
       mov       x29, sp
       mov       x19, x0
       movz      x0, #0x8d8
       movk      x0, #0x3016, lsl #16
       movk      x0, #0xea89, lsl #32
       bl        #0xea892f5e24c0
       mov       x20, x0
       ldr       x19, [x19, #8]
       movz      x0, #0x47b0
       movk      x0, #0x2e43, lsl #16
       movk      x0, #0xea89, lsl #32
       bl        #0xea892f5e24c0
       mov       x15, x0
       add       x14, x20, #8
       bl        CORINFO_HELP_ASSIGN_REF
       cbz       x19, M00_L00
       add       x14, x20, #0x20
       mov       x15, x19
       bl        CORINFO_HELP_ASSIGN_REF
       str       xzr, [x20, #0x10]
       mov       x0, x20
       mov       x1, xzr
       movz      x2, #0x58a8
       movk      x2, #0x3013, lsl #16
       movk      x2, #0xea89, lsl #32
       ldr       x2, [x2]
       ldp       x19, x20, [sp, #0x10]
       ldp       x29, x30, [sp], #0x20
       br        x2; Microsoft.VisualStudio.Threading.AsyncLazy`1[[System.Int32, System.Private.CoreLib]].GetValueAsync(System.Threading.CancellationToken)
M00_L00:
       movz      x0, #0x52f0
       movk      x0, #0x2f9c, lsl #16
       movk      x0, #0xea89, lsl #32
       bl        #0xea892f5e24c0
       mov       x19, x0
       movz      w0, #0x164
       movz      x1, #0x3016, lsl #16
       movk      x1, #0xea89, lsl #32
       movz      x2, #0xef88
       movk      x2, #0x2f59, lsl #16
       movk      x2, #0xea89, lsl #32
       ldr       x2, [x2]
       blr       x2
       mov       x1, x0
       mov       x0, x19
       movz      x2, #0xd350
       movk      x2, #0x2fe9, lsl #16
       movk      x2, #0xea89, lsl #32
       ldr       x2, [x2]
       blr       x2
       mov       x0, x19
       bl        #0xea892f5e2520
       brk       #0xf000
; Total bytes of code 216
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.Int32, System.Private.CoreLib]](System.Threading.Tasks.Task`1<Int32>)
       stp       x29, x30, [sp, #-0x20]!
       str       x19, [sp, #0x18]
       mov       x29, sp
       mov       x19, x0
       add       x0, x19, #0x34
; Total bytes of code 20
```
```assembly
; Microsoft.VisualStudio.Threading.AsyncLazy`1[[System.Int32, System.Private.CoreLib]].GetValueAsync(System.Threading.CancellationToken)
       stp       x29, x30, [sp, #-0x110]!
       stp       x19, x20, [sp, #0xc0]
       stp       x21, x22, [sp, #0xd0]
       stp       x23, x24, [sp, #0xe0]
       stp       x25, x26, [sp, #0xf0]
       stp       x27, x28, [sp, #0x100]
       mov       x29, sp
       add       x9, x29, #0x28
       movi      v16.16b, #0
       stp       q16, q16, [x9]
       stp       q16, q16, [x9, #0x20]
       stp       q16, q16, [x9, #0x40]
       stp       q16, q16, [x9, #0x60]
       str       xzr, [x9, #0x80]
       str       x0, [x29, #0x38]
       str       x1, [x29, #0xb8]
       mov       x19, x0
       movz      x0, #0x2c20
       movk      x0, #0x3016, lsl #16
       movk      x0, #0xea89, lsl #32
       bl        #0xea892f5e24c0
       str       x0, [x29, #0x30]
       add       x14, x0, #8
       mov       x15, x19
       bl        CORINFO_HELP_ASSIGN_REF
       ldr       x1, [x19, #0x28]
       cbnz      x1, #0xea892f61ebd0
       ldr       x1, [x19, #0x18]
       cbnz      x1, #0xea892f61ebe8
       ldr       x1, [x19, #0x28]
       cbnz      x1, #0xea892f61eb7c
       ldr       x1, [x19, #8]
       cbz       x1, #0xea892f61ec68
       mov       x0, x1
       bl        #0xea892f5e25e0
       cbnz      w0, #0xea892f61eca4
       ldr       x0, [x29, #0x30]
       str       xzr, [x0, #0x10]
       ldr       x1, [x19, #8]
       str       x1, [x29, #0x28]
       str       wzr, [x29, #0xb4]
       ldr       x1, [x29, #0x28]
       cbz       x1, #0xea892f61e8a8
       mov       x0, x1
       bl        #0xea892f5e25f0
       cbz       w0, #0xea892f61e8c4
       movz      w0, #0x1
       str       w0, [x29, #0xb4]
       ldr       x0, [x19, #0x28]
       cbnz      x0, #0xea892f61e920
       ldr       x0, [x29, #0xb8]
       cbz       x0, #0xea892f61e3f0
       ldr       x0, [x29, #0xb8]
       add       x0, x0, #0x20
; Total bytes of code 216
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.Int32, System.Private.CoreLib]].LazyOfTask()
       stp       x29, x30, [sp, #-0x20]!
       stp       x19, x20, [sp, #0x10]
       mov       x29, sp
       mov       x19, x0
       movz      x0, #0xfc38
       movk      x0, #0x8e15, lsl #16
       movk      x0, #0xe3cc, lsl #32
       bl        #0xe3cc8d5f24c0
       mov       x20, x0
       ldr       x15, [x19, #8]
       cbz       x15, #0xe3cc8d630cac
       add       x14, x20, #0x10
       bl        CORINFO_HELP_ASSIGN_REF
       movz      x0, #0xfa00
       movk      x0, #0x8dfd, lsl #16
       movk      x0, #0xe3cc, lsl #32
       bl        #0xe3cc8d5f24c0
       movz      w14, #0x8
       str       w14, [x0, #0x10]
       add       x1, x20, #8
       mov       x14, x1
       mov       x15, x0
       bl        CORINFO_HELP_ASSIGN_REF
; Total bytes of code 92
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.Int32, System.Private.CoreLib]](System.Threading.Tasks.Task`1<Int32>)
       stp       x29, x30, [sp, #-0x20]!
       str       x19, [sp, #0x18]
       mov       x29, sp
       mov       x19, x0
       add       x0, x19, #0x34
; Total bytes of code 20
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.Int32, System.Private.CoreLib]].LazyOfTask_TaskRun()
       stp       x29, x30, [sp, #-0x20]!
       stp       x19, x20, [sp, #0x10]
       mov       x29, sp
       mov       x19, x0
       movz      x0, #0x360
       movk      x0, #0x4355, lsl #16
       movk      x0, #0xefcb, lsl #32
       bl        #0xefcb429d24c0
       mov       x20, x0
       ldr       x15, [x19, #0x10]
       cbz       x15, #0xefcb42a190f4
       add       x14, x20, #0x10
       bl        CORINFO_HELP_ASSIGN_REF
       movz      x0, #0xfa00
       movk      x0, #0x433b, lsl #16
       movk      x0, #0xefcb, lsl #32
       bl        #0xefcb429d24c0
       movz      w14, #0x8
       str       w14, [x0, #0x10]
       add       x1, x20, #8
       mov       x14, x1
       mov       x15, x0
       bl        CORINFO_HELP_ASSIGN_REF
; Total bytes of code 92
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.Int32, System.Private.CoreLib]](System.Threading.Tasks.Task`1<Int32>)
       stp       x29, x30, [sp, #-0x20]!
       str       x19, [sp, #0x18]
       mov       x29, sp
       mov       x19, x0
       add       x0, x19, #0x34
; Total bytes of code 20
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.Int32, System.Private.CoreLib]].AsyncLazy()
       stp       x29, x30, [sp, #-0x20]!
       str       x19, [sp, #0x18]
       mov       x29, sp
       mov       x19, x0
       movz      x0, #0x630
       movk      x0, #0xd1f8, lsl #16
       movk      x0, #0xeb76, lsl #32
       bl        #0xeb76d14024c0
       ldr       x15, [x19, #8]
       cbz       x15, #0xeb76d144f8bc
       add       x14, x0, #0x18
       bl        CORINFO_HELP_ASSIGN_REF
       add       x1, x0, #0x10
; Total bytes of code 52
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.Int32, System.Private.CoreLib]](System.Threading.Tasks.Task`1<Int32>)
       stp       x29, x30, [sp, #-0x20]!
       str       x19, [sp, #0x18]
       mov       x29, sp
       mov       x19, x0
       add       x0, x19, #0x34
; Total bytes of code 20
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.Int32, System.Private.CoreLib]].AsyncLazy_NoHop()
       stp       x29, x30, [sp, #-0x80]!
       stp       x19, x20, [sp, #0x60]
       stp       x21, x22, [sp, #0x70]
       mov       x29, sp
       add       x9, x29, #0x28
       movi      v16.16b, #0
       stp       q16, q16, [x9]
       stp       xzr, xzr, [x9, #0x20]
       str       xzr, [x9, #0x30]
       mov       x19, x0
       movz      x0, #0x630
       movk      x0, #0x4af8, lsl #16
       movk      x0, #0xebde, lsl #32
       bl        #0xebde4a4024c0
       mov       x20, x0
       ldr       x15, [x19, #8]
       cbz       x15, #0xebde4a44c8c8
       add       x14, x20, #0x18
       bl        CORINFO_HELP_ASSIGN_REF
       add       x1, x20, #0x10
; Total bytes of code 80
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.Int32, System.Private.CoreLib]](System.Threading.Tasks.Task`1<Int32>)
       stp       x29, x30, [sp, #-0x20]!
       str       x19, [sp, #0x18]
       mov       x29, sp
       mov       x19, x0
       add       x0, x19, #0x34
; Total bytes of code 20
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.Int32, System.Private.CoreLib]].AsyncLazy_NoRecursionDetection()
       stp       x29, x30, [sp, #-0x40]!
       stp       x19, x20, [sp, #0x10]
       stp       x21, x22, [sp, #0x20]
       stp       x23, x24, [sp, #0x30]
       mov       x29, sp
       mov       x19, x0
       movz      x0, #0xa20
       movk      x0, #0x3d38, lsl #16
       movk      x0, #0xf7fc, lsl #32
       bl        #0xf7fc3c8024c0
       mov       x20, x0
       ldr       x15, [x19, #8]
       cbz       x15, #0xf7fc3c84e554
       add       x14, x20, #0x18
       bl        CORINFO_HELP_ASSIGN_REF
       add       x1, x20, #0x10
; Total bytes of code 64
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.Int32, System.Private.CoreLib]](System.Threading.Tasks.Task`1<Int32>)
       stp       x29, x30, [sp, #-0x20]!
       str       x19, [sp, #0x18]
       mov       x29, sp
       mov       x19, x0
       add       x0, x19, #0x34
; Total bytes of code 20
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.Int32, System.Private.CoreLib]].Nito()
       stp       x29, x30, [sp, #-0x40]!
       stp       x19, x20, [sp, #0x28]
       str       x21, [sp, #0x38]
       mov       x29, sp
       ldr       x19, [x0, #8]
       cbz       x19, #0xfec82da39e58
       movz      x0, #0x1848
       movk      x0, #0x2e57, lsl #16
       movk      x0, #0xfec8, lsl #32
       bl        #0xfec82d9f24c0
       mov       x20, x0
       add       x14, x20, #8
       mov       x15, x19
       bl        CORINFO_HELP_ASSIGN_REF
       movz      x0, #0xe0b8
       movk      x0, #0x2e4e, lsl #16
       movk      x0, #0xfec8, lsl #32
       bl        #0xfec82d9f24c0
       mov       x19, x0
       add       x14, x19, #8
       mov       x15, x20
       bl        CORINFO_HELP_ASSIGN_REF
       movz      x0, #0x1830
       movk      x0, #0x2e54, lsl #16
       movk      x0, #0xfec8, lsl #32
       str       x0, [x19, #0x18]
       movz      x0, #0x47b0
       movk      x0, #0x2c84, lsl #16
       movk      x0, #0xfec8, lsl #32
       bl        #0xfec82d9f24c0
       mov       x20, x0
       movz      x0, #0xaa8
       movk      x0, #0x2e57, lsl #16
       movk      x0, #0xfec8, lsl #32
       bl        #0xfec82d9f24c0
       mov       x21, x0
       add       x14, x21, #0x10
       mov       x15, x19
       bl        CORINFO_HELP_ASSIGN_REF
       movz      x0, #0xfa00
       movk      x0, #0x2e3d, lsl #16
       movk      x0, #0xfec8, lsl #32
       bl        #0xfec82d9f24c0
       movz      w14, #0x8
       str       w14, [x0, #0x10]
       add       x19, x21, #8
       mov       x14, x19
       mov       x15, x0
       bl        CORINFO_HELP_ASSIGN_REF
       str       x20, [x29, #0x18]
       str       wzr, [x29, #0x24]
       mov       x0, x20
       bl        #0xfec82d9f2620
       cbz       w0, #0xfec82da39e18
       movz      w0, #0x1
       str       w0, [x29, #0x24]
; Total bytes of code 224
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.Int32, System.Private.CoreLib]](System.Threading.Tasks.Task`1<Int32>)
       stp       x29, x30, [sp, #-0x20]!
       str       x19, [sp, #0x18]
       mov       x29, sp
       mov       x19, x0
       add       x0, x19, #0x34
; Total bytes of code 20
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.Int32, System.Private.CoreLib]].Nito_ExecuteOnCallingThread()
       stp       x29, x30, [sp, #-0x40]!
       stp       x19, x20, [sp, #0x28]
       str       x21, [sp, #0x38]
       mov       x29, sp
       ldr       x19, [x0, #8]
       cbz       x19, #0xf34ae8a1ffc8
       movz      x0, #0x47b0
       movk      x0, #0xe783, lsl #16
       movk      x0, #0xf34a, lsl #32
       bl        #0xf34ae89e24c0
       mov       x20, x0
       movz      x0, #0xe90
       movk      x0, #0xe956, lsl #16
       movk      x0, #0xf34a, lsl #32
       bl        #0xf34ae89e24c0
       mov       x21, x0
       add       x14, x21, #0x10
       mov       x15, x19
       bl        CORINFO_HELP_ASSIGN_REF
       movz      x0, #0xfa00
       movk      x0, #0xe93c, lsl #16
       movk      x0, #0xf34a, lsl #32
       bl        #0xf34ae89e24c0
       movz      w14, #0x8
       str       w14, [x0, #0x10]
       add       x19, x21, #8
       mov       x14, x19
       mov       x15, x0
       bl        CORINFO_HELP_ASSIGN_REF
       str       x20, [x29, #0x18]
       str       wzr, [x29, #0x24]
       mov       x0, x20
       bl        #0xf34ae89e2600
       cbz       w0, #0xf34ae8a1ff88
       movz      w0, #0x1
       str       w0, [x29, #0x24]
; Total bytes of code 144
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.Int32, System.Private.CoreLib]](System.Threading.Tasks.Task`1<Int32>)
       stp       x29, x30, [sp, #-0x20]!
       str       x19, [sp, #0x18]
       mov       x29, sp
       mov       x19, x0
       add       x0, x19, #0x34
; Total bytes of code 20
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.Int32, System.Private.CoreLib]].VsThreading()
       stp       x29, x30, [sp, #-0x20]!
       stp       x19, x20, [sp, #0x10]
       mov       x29, sp
       mov       x19, x0
       movz      x0, #0x8d8
       movk      x0, #0x5b77, lsl #16
       movk      x0, #0xe8bf, lsl #32
       bl        #0xe8bf5abf24c0
       mov       x20, x0
       ldr       x19, [x19, #8]
       movz      x0, #0x47b0
       movk      x0, #0x59a4, lsl #16
       movk      x0, #0xe8bf, lsl #32
       bl        #0xe8bf5abf24c0
       mov       x15, x0
       add       x14, x20, #8
       bl        CORINFO_HELP_ASSIGN_REF
       cbz       x19, M00_L00
       add       x14, x20, #0x20
       mov       x15, x19
       bl        CORINFO_HELP_ASSIGN_REF
       str       xzr, [x20, #0x10]
       mov       x0, x20
       mov       x1, xzr
       movz      x2, #0x58a8
       movk      x2, #0x5b74, lsl #16
       movk      x2, #0xe8bf, lsl #32
       ldr       x2, [x2]
       ldp       x19, x20, [sp, #0x10]
       ldp       x29, x30, [sp], #0x20
       br        x2; Microsoft.VisualStudio.Threading.AsyncLazy`1[[System.Int32, System.Private.CoreLib]].GetValueAsync(System.Threading.CancellationToken)
M00_L00:
       movz      x0, #0x52f0
       movk      x0, #0x5afd, lsl #16
       movk      x0, #0xe8bf, lsl #32
       bl        #0xe8bf5abf24c0
       mov       x19, x0
       movz      w0, #0x164
       movz      x1, #0x5b77, lsl #16
       movk      x1, #0xe8bf, lsl #32
       movz      x2, #0xef88
       movk      x2, #0x5aba, lsl #16
       movk      x2, #0xe8bf, lsl #32
       ldr       x2, [x2]
       blr       x2
       mov       x1, x0
       mov       x0, x19
       movz      x2, #0xd350
       movk      x2, #0x5b4a, lsl #16
       movk      x2, #0xe8bf, lsl #32
       ldr       x2, [x2]
       blr       x2
       mov       x0, x19
       bl        #0xe8bf5abf2520
       brk       #0xf000
; Total bytes of code 216
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.Int32, System.Private.CoreLib]](System.Threading.Tasks.Task`1<Int32>)
       stp       x29, x30, [sp, #-0x20]!
       str       x19, [sp, #0x18]
       mov       x29, sp
       mov       x19, x0
       add       x0, x19, #0x34
; Total bytes of code 20
```
```assembly
; Microsoft.VisualStudio.Threading.AsyncLazy`1[[System.Int32, System.Private.CoreLib]].GetValueAsync(System.Threading.CancellationToken)
       stp       x29, x30, [sp, #-0x110]!
       stp       x19, x20, [sp, #0xc0]
       stp       x21, x22, [sp, #0xd0]
       stp       x23, x24, [sp, #0xe0]
       stp       x25, x26, [sp, #0xf0]
       stp       x27, x28, [sp, #0x100]
       mov       x29, sp
       add       x9, x29, #0x28
       movi      v16.16b, #0
       stp       q16, q16, [x9]
       stp       q16, q16, [x9, #0x20]
       stp       q16, q16, [x9, #0x40]
       stp       q16, q16, [x9, #0x60]
       str       xzr, [x9, #0x80]
       str       x0, [x29, #0x38]
       str       x1, [x29, #0xb8]
       mov       x19, x0
       movz      x0, #0x2c20
       movk      x0, #0x5b77, lsl #16
       movk      x0, #0xe8bf, lsl #32
       bl        #0xe8bf5abf24c0
       str       x0, [x29, #0x30]
       add       x14, x0, #8
       mov       x15, x19
       bl        CORINFO_HELP_ASSIGN_REF
       ldr       x1, [x19, #0x28]
       cbnz      x1, #0xe8bf5ac43304
       ldr       x1, [x19, #0x18]
       cbnz      x1, #0xe8bf5ac4331c
       ldr       x1, [x19, #0x28]
       cbnz      x1, #0xe8bf5ac432b0
       ldr       x1, [x19, #8]
       cbz       x1, #0xe8bf5ac4339c
       mov       x0, x1
       bl        #0xe8bf5abf2620
       cbnz      w0, #0xe8bf5ac433d8
       ldr       x0, [x29, #0x30]
       str       xzr, [x0, #0x10]
       ldr       x1, [x19, #8]
       str       x1, [x29, #0x28]
       str       wzr, [x29, #0xb4]
       ldr       x1, [x29, #0x28]
       cbz       x1, #0xe8bf5ac42fdc
       mov       x0, x1
       bl        #0xe8bf5abf2630
       cbz       w0, #0xe8bf5ac42ff8
       movz      w0, #0x1
       str       w0, [x29, #0xb4]
       ldr       x0, [x19, #0x28]
       cbnz      x0, #0xe8bf5ac43054
       ldr       x0, [x29, #0xb8]
       cbz       x0, #0xe8bf5ac42b20
       ldr       x0, [x29, #0xb8]
       add       x0, x0, #0x20
; Total bytes of code 216
```

