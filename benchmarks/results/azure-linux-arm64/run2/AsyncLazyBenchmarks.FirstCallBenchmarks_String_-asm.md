## .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.__Canon, System.Private.CoreLib]].LazyOfTask()
       stp       x29, x30, [sp, #-0x30]!
       stp       x19, x20, [sp, #0x20]
       mov       x29, sp
       str       x0, [x29, #0x18]
       mov       x19, x0
       ldr       x0, [x19]
       ldr       x1, [x0, #0x30]
       ldr       x1, [x1]
       ldr       x1, [x1, #0x28]
       cbz       x1, #0xf1a272a158a4
       mov       x0, x1
       bl        #0xf1a2729e24c0
       mov       x20, x0
       ldr       x15, [x19, #8]
       cbz       x15, #0xf1a272a158cc
       add       x14, x20, #0x10
       bl        CORINFO_HELP_ASSIGN_REF
       movz      x0, #0xfa00
       movk      x0, #0x733c, lsl #16
       movk      x0, #0xf1a2, lsl #32
       bl        #0xf1a2729e24c0
       movz      w14, #0x8
       str       w14, [x0, #0x10]
       add       x1, x20, #8
       mov       x14, x1
       mov       x15, x0
       bl        CORINFO_HELP_ASSIGN_REF
; Total bytes of code 108
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.__Canon, System.Private.CoreLib]](System.Threading.Tasks.Task`1<System.__Canon>)
       stp       x29, x30, [sp, #-0x20]!
       str       x19, [sp, #0x18]
       mov       x29, sp
       mov       x19, x1
       add       x0, x19, #0x34
; Total bytes of code 20
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.__Canon, System.Private.CoreLib]].LazyOfTask_TaskRun()
       stp       x29, x30, [sp, #-0x30]!
       stp       x19, x20, [sp, #0x20]
       mov       x29, sp
       str       x0, [x29, #0x18]
       mov       x19, x0
       ldr       x0, [x19]
       ldr       x1, [x0, #0x30]
       ldr       x1, [x1]
       ldr       x1, [x1, #0x28]
       cbz       x1, #0xf9c87704680c
       mov       x0, x1
       bl        #0xf9c8770024c0
       mov       x20, x0
       ldr       x15, [x19, #0x10]
       cbz       x15, #0xf9c877046834
       add       x14, x20, #0x10
       bl        CORINFO_HELP_ASSIGN_REF
       movz      x0, #0xfa00
       movk      x0, #0x779e, lsl #16
       movk      x0, #0xf9c8, lsl #32
       bl        #0xf9c8770024c0
       movz      w14, #0x8
       str       w14, [x0, #0x10]
       add       x1, x20, #8
       mov       x14, x1
       mov       x15, x0
       bl        CORINFO_HELP_ASSIGN_REF
; Total bytes of code 108
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.__Canon, System.Private.CoreLib]](System.Threading.Tasks.Task`1<System.__Canon>)
       stp       x29, x30, [sp, #-0x20]!
       str       x19, [sp, #0x18]
       mov       x29, sp
       mov       x19, x1
       add       x0, x19, #0x34
; Total bytes of code 20
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.__Canon, System.Private.CoreLib]].AsyncLazy()
       stp       x29, x30, [sp, #-0x20]!
       str       x19, [sp, #0x18]
       mov       x29, sp
       str       x0, [x29, #0x10]
       mov       x19, x0
       ldr       x0, [x19]
       ldr       x1, [x0, #0x30]
       ldr       x1, [x1]
       ldr       x1, [x1, #0x28]
       cbz       x1, #0xf11beec22c3c
       mov       x0, x1
       bl        #0xf11beebe24c0
       ldr       x15, [x19, #8]
       cbz       x15, #0xf11beec22c64
       add       x14, x0, #0x18
       bl        CORINFO_HELP_ASSIGN_REF
       add       x1, x0, #0x10
; Total bytes of code 68
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.__Canon, System.Private.CoreLib]](System.Threading.Tasks.Task`1<System.__Canon>)
       stp       x29, x30, [sp, #-0x20]!
       str       x19, [sp, #0x18]
       mov       x29, sp
       mov       x19, x1
       add       x0, x19, #0x34
; Total bytes of code 20
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.__Canon, System.Private.CoreLib]].AsyncLazy_NoHop()
       stp       x29, x30, [sp, #-0x90]!
       stp       x19, x20, [sp, #0x78]
       str       x21, [sp, #0x88]
       mov       x29, sp
       add       x9, x29, #0x38
       movi      v16.16b, #0
       stp       q16, q16, [x9]
       stp       xzr, xzr, [x9, #0x20]
       str       xzr, [x9, #0x30]
       str       x0, [x29, #0x70]
       str       x0, [x29, #0x30]
       ldr       x1, [x0]
       ldr       x2, [x1, #0x30]
       ldr       x2, [x2]
       ldr       x2, [x2, #0x28]
       cbz       x2, #0xeae043e3ad08
       mov       x0, x2
       bl        #0xeae043e024c0
       mov       x19, x0
       ldr       x0, [x29, #0x30]
       ldr       x15, [x0, #8]
       cbz       x15, #0xeae043e3af00
       add       x14, x19, #0x18
       bl        CORINFO_HELP_ASSIGN_REF
       add       x1, x19, #0x10
; Total bytes of code 100
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.__Canon, System.Private.CoreLib]](System.Threading.Tasks.Task`1<System.__Canon>)
       stp       x29, x30, [sp, #-0x20]!
       str       x19, [sp, #0x18]
       mov       x29, sp
       mov       x19, x1
       add       x0, x19, #0x34
; Total bytes of code 20
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.__Canon, System.Private.CoreLib]].AsyncLazy_NoRecursionDetection()
       stp       x29, x30, [sp, #-0x20]!
       str       x19, [sp, #0x18]
       mov       x29, sp
       str       x0, [x29, #0x10]
       mov       x19, x0
       ldr       x0, [x19]
       ldr       x1, [x0, #0x30]
       ldr       x1, [x1]
       ldr       x1, [x1, #0x28]
       cbz       x1, #0xe8845de43cfc
       mov       x0, x1
       bl        #0xe8845de024c0
       ldr       x15, [x19, #8]
       cbz       x15, #0xe8845de43d24
       add       x14, x0, #0x18
       bl        CORINFO_HELP_ASSIGN_REF
       add       x1, x0, #0x10
; Total bytes of code 68
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.__Canon, System.Private.CoreLib]](System.Threading.Tasks.Task`1<System.__Canon>)
       stp       x29, x30, [sp, #-0x20]!
       str       x19, [sp, #0x18]
       mov       x29, sp
       mov       x19, x1
       add       x0, x19, #0x34
; Total bytes of code 20
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.__Canon, System.Private.CoreLib]].Nito()
       stp       x29, x30, [sp, #-0x50]!
       stp       x19, x20, [sp, #0x38]
       str       x21, [sp, #0x48]
       mov       x29, sp
       str       x0, [x29, #0x30]
       str       x0, [x29, #0x20]
       ldr       x1, [x0]
       ldr       x2, [x1, #0x30]
       ldr       x2, [x2]
       ldr       x19, [x2, #0x28]
       cbz       x19, #0xe943c6016640
       ldr       x0, [x29, #0x20]
       ldr       x20, [x0, #8]
       cbz       x20, #0xe943c60166e8
       ldr       x1, [x19, #0x30]
       ldr       x1, [x1]
       ldr       x1, [x1, #0x18]
       cbz       x1, #0xe943c601666c
       mov       x0, x1
       bl        #0xe943c5fd24c0
       mov       x21, x0
       add       x14, x21, #8
       mov       x15, x20
       bl        CORINFO_HELP_ASSIGN_REF
       ldr       x0, [x19, #0x30]
       ldr       x0, [x0]
       ldr       x0, [x0, #0x20]
       cbz       x0, #0xe943c6016698
       bl        #0xe943c5fd24c0
       mov       x20, x0
       add       x14, x20, #8
       mov       x15, x21
       bl        CORINFO_HELP_ASSIGN_REF
       movz      x0, #0x1920
       movk      x0, #0xc6b2, lsl #16
       movk      x0, #0xe943, lsl #32
       str       x0, [x20, #0x18]
       movz      x0, #0x47b0
       movk      x0, #0xc4e2, lsl #16
       movk      x0, #0xe943, lsl #32
       bl        #0xe943c5fd24c0
       mov       x21, x0
       ldr       x0, [x19, #0x30]
       ldr       x0, [x0]
       ldr       x0, [x0, #0x10]
       cbz       x0, #0xe943c60166c0
       bl        #0xe943c5fd24c0
       mov       x19, x0
       add       x14, x19, #0x10
       mov       x15, x20
       bl        CORINFO_HELP_ASSIGN_REF
       movz      x0, #0xfa00
       movk      x0, #0xc69b, lsl #16
       movk      x0, #0xe943, lsl #32
       bl        #0xe943c5fd24c0
       movz      w14, #0x8
       str       w14, [x0, #0x10]
       add       x20, x19, #8
       mov       x14, x20
       mov       x15, x0
       bl        CORINFO_HELP_ASSIGN_REF
       str       x21, [x29, #0x18]
       str       wzr, [x29, #0x2c]
       mov       x0, x21
       bl        #0xe943c5fd2620
       cbz       w0, #0xe943c6016600
       movz      w0, #0x1
       str       w0, [x29, #0x2c]
; Total bytes of code 272
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.__Canon, System.Private.CoreLib]](System.Threading.Tasks.Task`1<System.__Canon>)
       stp       x29, x30, [sp, #-0x20]!
       str       x19, [sp, #0x18]
       mov       x29, sp
       mov       x19, x1
       add       x0, x19, #0x34
; Total bytes of code 20
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.__Canon, System.Private.CoreLib]].Nito_ExecuteOnCallingThread()
       stp       x29, x30, [sp, #-0x50]!
       stp       x19, x20, [sp, #0x38]
       str       x21, [sp, #0x48]
       mov       x29, sp
       str       x0, [x29, #0x30]
       str       x0, [x29, #0x20]
       ldr       x1, [x0]
       ldr       x2, [x1, #0x30]
       ldr       x2, [x2]
       ldr       x19, [x2, #0x28]
       cbz       x19, #0xf35245a161bc
       ldr       x0, [x29, #0x20]
       ldr       x20, [x0, #8]
       cbz       x20, #0xf35245a16210
       movz      x0, #0x47b0
       movk      x0, #0x4483, lsl #16
       movk      x0, #0xf352, lsl #32
       bl        #0xf352459e24c0
       mov       x21, x0
       ldr       x0, [x19, #0x30]
       ldr       x0, [x0]
       ldr       x0, [x0, #0x10]
       cbz       x0, #0xf35245a161e8
       bl        #0xf352459e24c0
       mov       x19, x0
       add       x14, x19, #0x10
       mov       x15, x20
       bl        CORINFO_HELP_ASSIGN_REF
       movz      x0, #0xfa00
       movk      x0, #0x463c, lsl #16
       movk      x0, #0xf352, lsl #32
       bl        #0xf352459e24c0
       movz      w14, #0x8
       str       w14, [x0, #0x10]
       add       x20, x19, #8
       mov       x14, x20
       mov       x15, x0
       bl        CORINFO_HELP_ASSIGN_REF
       str       x21, [x29, #0x18]
       str       wzr, [x29, #0x2c]
       mov       x0, x21
       bl        #0xf352459e25e0
       cbz       w0, #0xf35245a1617c
       movz      w0, #0x1
       str       w0, [x29, #0x2c]
; Total bytes of code 180
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.__Canon, System.Private.CoreLib]](System.Threading.Tasks.Task`1<System.__Canon>)
       stp       x29, x30, [sp, #-0x20]!
       str       x19, [sp, #0x18]
       mov       x29, sp
       mov       x19, x1
       add       x0, x19, #0x34
; Total bytes of code 20
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.__Canon, System.Private.CoreLib]].VsThreading()
       stp       x29, x30, [sp, #-0x30]!
       stp       x19, x20, [sp, #0x18]
       str       x21, [sp, #0x28]
       mov       x29, sp
       str       x0, [x29, #0x10]
       mov       x19, x0
       ldr       x0, [x19]
       ldr       x1, [x0, #0x30]
       ldr       x1, [x1]
       ldr       x1, [x1, #0x28]
       cbz       x1, M00_L01
M00_L00:
       mov       x0, x1
       bl        #0xf0d0783d24c0
       mov       x20, x0
       ldr       x21, [x19, #8]
       movz      x0, #0x47b0
       movk      x0, #0x7722, lsl #16
       movk      x0, #0xf0d0, lsl #32
       bl        #0xf0d0783d24c0
       mov       x15, x0
       add       x14, x20, #8
       bl        CORINFO_HELP_ASSIGN_REF
       cbz       x21, M00_L02
       add       x14, x20, #0x20
       mov       x15, x21
       bl        CORINFO_HELP_ASSIGN_REF
       str       xzr, [x20, #0x10]
       mov       x0, x20
       mov       x1, xzr
       movz      x2, #0x58d8
       movk      x2, #0x78f2, lsl #16
       movk      x2, #0xf0d0, lsl #32
       ldr       x2, [x2]
       ldr       x21, [sp, #0x28]
       ldp       x19, x20, [sp, #0x18]
       ldp       x29, x30, [sp], #0x30
       br        x2; Microsoft.VisualStudio.Threading.AsyncLazy`1[[System.__Canon, System.Private.CoreLib]].GetValueAsync(System.Threading.CancellationToken)
M00_L01:
       movz      x1, #0x46a0
       movk      x1, #0x78f7, lsl #16
       movk      x1, #0xf0d0, lsl #32
       movz      x2, #0xf270
       movk      x2, #0x7838, lsl #16
       movk      x2, #0xf0d0, lsl #32
       ldr       x2, [x2]
       blr       x2; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       x1, x0
       b         M00_L00
M00_L02:
       movz      x0, #0x52f0
       movk      x0, #0x787b, lsl #16
       movk      x0, #0xf0d0, lsl #32
       bl        #0xf0d0783d24c0
       mov       x20, x0
       movz      w0, #0x164
       movz      x1, #0x1a8
       movk      x1, #0x78f5, lsl #16
       movk      x1, #0xf0d0, lsl #32
       movz      x2, #0xef88
       movk      x2, #0x7838, lsl #16
       movk      x2, #0xf0d0, lsl #32
       ldr       x2, [x2]
       blr       x2
       mov       x1, x0
       mov       x0, x20
       movz      x2, #0xd350
       movk      x2, #0x78c8, lsl #16
       movk      x2, #0xf0d0, lsl #32
       ldr       x2, [x2]
       blr       x2
       mov       x0, x20
       bl        #0xf0d0783d2520
       brk       #0xf000
; Total bytes of code 284
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.__Canon, System.Private.CoreLib]](System.Threading.Tasks.Task`1<System.__Canon>)
       stp       x29, x30, [sp, #-0x20]!
       str       x19, [sp, #0x18]
       mov       x29, sp
       mov       x19, x1
       add       x0, x19, #0x34
; Total bytes of code 20
```
```assembly
; Microsoft.VisualStudio.Threading.AsyncLazy`1[[System.__Canon, System.Private.CoreLib]].GetValueAsync(System.Threading.CancellationToken)
       stp       x29, x30, [sp, #-0x110]!
       stp       x19, x20, [sp, #0xc0]
       stp       x21, x22, [sp, #0xd0]
       stp       x23, x24, [sp, #0xe0]
       stp       x25, x26, [sp, #0xf0]
       stp       x27, x28, [sp, #0x100]
       mov       x29, sp
       add       x9, x29, #0x20
       movi      v16.16b, #0
       stp       q16, q16, [x9]
       stp       q16, q16, [x9, #0x20]
       stp       q16, q16, [x9, #0x40]
       stp       q16, q16, [x9, #0x60]
       str       xzr, [x9, #0x80]
       str       x0, [x29, #0xb8]
       str       x0, [x29, #0x30]
       str       x1, [x29, #0xb0]
       ldr       x1, [x0]
       ldr       x2, [x1, #0x30]
       ldr       x2, [x2]
       ldr       x2, [x2, #0x18]
       cbz       x2, #0xf0d0784117c0
       mov       x0, x2
       bl        #0xf0d0783d24c0
       str       x0, [x29, #0x28]
       add       x14, x0, #8
       ldr       x15, [x29, #0x30]
       bl        CORINFO_HELP_ASSIGN_REF
       ldr       x15, [x29, #0x30]
       ldr       x1, [x15, #0x28]
       cbnz      x1, #0xf0d0784117ec
       ldr       x1, [x15, #0x18]
       cbnz      x1, #0xf0d078411804
       ldr       x15, [x29, #0x30]
       ldr       x1, [x15, #0x28]
       cbnz      x1, #0xf0d078411728
       ldr       x1, [x15, #8]
       cbz       x1, #0xf0d078411884
       mov       x0, x1
       bl        #0xf0d0783d25e0
       cbnz      w0, #0xf0d0784118c0
       ldr       x0, [x29, #0x28]
       str       xzr, [x0, #0x10]
       ldr       x15, [x29, #0x30]
       ldr       x1, [x15, #8]
       str       x1, [x29, #0x20]
       str       wzr, [x29, #0xac]
       ldr       x1, [x29, #0x20]
       cbz       x1, #0xf0d0784113d4
       mov       x0, x1
       bl        #0xf0d0783d25f0
       cbz       w0, #0xf0d0784113f0
       movz      w0, #0x1
       str       w0, [x29, #0xac]
       ldr       x15, [x29, #0x30]
       ldr       x0, [x15, #0x28]
       cbnz      x0, #0xf0d078411464
       ldr       x0, [x29, #0xb0]
       cbz       x0, #0xf0d078410d34
       ldr       x0, [x29, #0xb0]
       add       x0, x0, #0x20
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       stp       x29, x30, [sp, #-0xf0]!
       stp       x19, x20, [sp, #0xa0]
       stp       x21, x22, [sp, #0xb0]
       stp       x23, x24, [sp, #0xc0]
       stp       x25, x26, [sp, #0xd0]
       stp       x27, x28, [sp, #0xe0]
       mov       x29, sp
       mov       x2, x1
       mov       x1, x0
       stur      x1, [x29, #0x3c]
       stur      x2, [x29, #0x34]
       adrp      x11, #0xf0d077f97000
       add       x11, x11, #0x6e0
       stur      x11, [x29, #0x2c]
       mov       x0, xzr
       stur      x0, [x29, #0x24]
       movn      w3, #0
       str       w3, [x29, #0x44]
       mov       x4, xzr
       stur      x4, [x29, #0x1c]
       add       x0, x29, #0x48
       adrp      x5, #0xf0d077f7d000
       add       x5, x5, #0x920
       ldr       x5, [x5]
       blr       x5
       adrp      x0, #0xf0d077fa6000
       add       x0, x0, #0x4c0
       ldr       x0, [x0]
       ldr       x5, [x0]
       ldur      x1, [x29, #0x3c]
       ldur      x2, [x29, #0x34]
       ldur      x11, [x29, #0x2c]
       ldur      x0, [x29, #0x24]
       ldr       w3, [x29, #0x44]
       ldur      x4, [x29, #0x1c]
       blr       x5
       mov       x19, x0
       add       x0, x29, #0x48
       adrp      x1, #0xf0d077f7d000
       add       x1, x1, #0x928
       ldr       x1, [x1]
       blr       x1; CORINFO_HELP_JIT_PINVOKE_END
       mov       x0, x19
       ldp       x27, x28, [sp, #0xe0]
       ldp       x25, x26, [sp, #0xd0]
       ldp       x23, x24, [sp, #0xc0]
       ldp       x21, x22, [sp, #0xb0]
       ldp       x19, x20, [sp, #0xa0]
       ldp       x29, x30, [sp], #0xf0
       ret       
; Total bytes of code 200
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.__Canon, System.Private.CoreLib]].LazyOfTask()
       stp       x29, x30, [sp, #-0x30]!
       stp       x19, x20, [sp, #0x20]
       mov       x29, sp
       str       x0, [x29, #0x18]
       mov       x19, x0
       ldr       x0, [x19]
       ldr       x1, [x0, #0x30]
       ldr       x1, [x1]
       ldr       x1, [x1, #0x28]
       cbz       x1, #0xe9555ec408dc
       mov       x0, x1
       bl        #0xe9555ec024c0
       mov       x20, x0
       ldr       x15, [x19, #8]
       cbz       x15, #0xe9555ec40904
       add       x14, x20, #0x10
       bl        CORINFO_HELP_ASSIGN_REF
       movz      x0, #0xfa00
       movk      x0, #0x5f5e, lsl #16
       movk      x0, #0xe955, lsl #32
       bl        #0xe9555ec024c0
       movz      w14, #0x8
       str       w14, [x0, #0x10]
       add       x1, x20, #8
       mov       x14, x1
       mov       x15, x0
       bl        CORINFO_HELP_ASSIGN_REF
; Total bytes of code 108
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.__Canon, System.Private.CoreLib]](System.Threading.Tasks.Task`1<System.__Canon>)
       stp       x29, x30, [sp, #-0x20]!
       str       x19, [sp, #0x18]
       mov       x29, sp
       mov       x19, x1
       add       x0, x19, #0x34
; Total bytes of code 20
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.__Canon, System.Private.CoreLib]].LazyOfTask_TaskRun()
       stp       x29, x30, [sp, #-0x30]!
       stp       x19, x20, [sp, #0x20]
       mov       x29, sp
       str       x0, [x29, #0x18]
       mov       x19, x0
       ldr       x0, [x19]
       ldr       x1, [x0, #0x30]
       ldr       x1, [x1]
       ldr       x1, [x1, #0x28]
       cbz       x1, #0xeaf8bc019b2c
       mov       x0, x1
       bl        #0xeaf8bbfd24c0
       mov       x20, x0
       ldr       x15, [x19, #0x10]
       cbz       x15, #0xeaf8bc019b54
       add       x14, x20, #0x10
       bl        CORINFO_HELP_ASSIGN_REF
       movz      x0, #0xfa00
       movk      x0, #0xbc9b, lsl #16
       movk      x0, #0xeaf8, lsl #32
       bl        #0xeaf8bbfd24c0
       movz      w14, #0x8
       str       w14, [x0, #0x10]
       add       x1, x20, #8
       mov       x14, x1
       mov       x15, x0
       bl        CORINFO_HELP_ASSIGN_REF
; Total bytes of code 108
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.__Canon, System.Private.CoreLib]](System.Threading.Tasks.Task`1<System.__Canon>)
       stp       x29, x30, [sp, #-0x20]!
       str       x19, [sp, #0x18]
       mov       x29, sp
       mov       x19, x1
       add       x0, x19, #0x34
; Total bytes of code 20
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.__Canon, System.Private.CoreLib]].AsyncLazy()
       stp       x29, x30, [sp, #-0x20]!
       str       x19, [sp, #0x18]
       mov       x29, sp
       str       x0, [x29, #0x10]
       mov       x19, x0
       ldr       x0, [x19]
       ldr       x1, [x0, #0x30]
       ldr       x1, [x1]
       ldr       x1, [x1, #0x28]
       cbz       x1, #0xf5bad402480c
       mov       x0, x1
       bl        #0xf5bad3fd24c0
       ldr       x15, [x19, #8]
       cbz       x15, #0xf5bad4024834
       add       x14, x0, #0x18
       bl        CORINFO_HELP_ASSIGN_REF
       add       x1, x0, #0x10
; Total bytes of code 68
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.__Canon, System.Private.CoreLib]](System.Threading.Tasks.Task`1<System.__Canon>)
       stp       x29, x30, [sp, #-0x20]!
       str       x19, [sp, #0x18]
       mov       x29, sp
       mov       x19, x1
       add       x0, x19, #0x34
; Total bytes of code 20
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.__Canon, System.Private.CoreLib]].AsyncLazy_NoHop()
       stp       x29, x30, [sp, #-0x90]!
       stp       x19, x20, [sp, #0x78]
       str       x21, [sp, #0x88]
       mov       x29, sp
       add       x9, x29, #0x38
       movi      v16.16b, #0
       stp       q16, q16, [x9]
       stp       xzr, xzr, [x9, #0x20]
       str       xzr, [x9, #0x30]
       str       x0, [x29, #0x70]
       str       x0, [x29, #0x30]
       ldr       x1, [x0]
       ldr       x2, [x1, #0x30]
       ldr       x2, [x2]
       ldr       x2, [x2, #0x28]
       cbz       x2, #0xf357eb43be94
       mov       x0, x2
       bl        #0xf357eb3f24c0
       mov       x19, x0
       ldr       x0, [x29, #0x30]
       ldr       x15, [x0, #8]
       cbz       x15, #0xf357eb43c08c
       add       x14, x19, #0x18
       bl        CORINFO_HELP_ASSIGN_REF
       add       x1, x19, #0x10
; Total bytes of code 100
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.__Canon, System.Private.CoreLib]](System.Threading.Tasks.Task`1<System.__Canon>)
       stp       x29, x30, [sp, #-0x20]!
       str       x19, [sp, #0x18]
       mov       x29, sp
       mov       x19, x1
       add       x0, x19, #0x34
; Total bytes of code 20
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.__Canon, System.Private.CoreLib]].AsyncLazy_NoRecursionDetection()
       stp       x29, x30, [sp, #-0x20]!
       str       x19, [sp, #0x18]
       mov       x29, sp
       str       x0, [x29, #0x10]
       mov       x19, x0
       ldr       x0, [x19]
       ldr       x1, [x0, #0x30]
       ldr       x1, [x1]
       ldr       x1, [x1, #0x28]
       cbz       x1, #0xe9521482fd2c
       mov       x0, x1
       bl        #0xe952147e24c0
       ldr       x15, [x19, #8]
       cbz       x15, #0xe9521482fd54
       add       x14, x0, #0x18
       bl        CORINFO_HELP_ASSIGN_REF
       add       x1, x0, #0x10
; Total bytes of code 68
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.__Canon, System.Private.CoreLib]](System.Threading.Tasks.Task`1<System.__Canon>)
       stp       x29, x30, [sp, #-0x20]!
       str       x19, [sp, #0x18]
       mov       x29, sp
       mov       x19, x1
       add       x0, x19, #0x34
; Total bytes of code 20
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.__Canon, System.Private.CoreLib]].Nito()
       stp       x29, x30, [sp, #-0x50]!
       stp       x19, x20, [sp, #0x38]
       str       x21, [sp, #0x48]
       mov       x29, sp
       str       x0, [x29, #0x30]
       str       x0, [x29, #0x20]
       ldr       x1, [x0]
       ldr       x2, [x1, #0x30]
       ldr       x2, [x2]
       ldr       x19, [x2, #0x28]
       cbz       x19, #0xf4e69002edd0
       ldr       x0, [x29, #0x20]
       ldr       x20, [x0, #8]
       cbz       x20, #0xf4e69002ee78
       ldr       x1, [x19, #0x30]
       ldr       x1, [x1]
       ldr       x1, [x1, #0x18]
       cbz       x1, #0xf4e69002edfc
       mov       x0, x1
       bl        #0xf4e68ffe24c0
       mov       x21, x0
       add       x14, x21, #8
       mov       x15, x20
       bl        CORINFO_HELP_ASSIGN_REF
       ldr       x0, [x19, #0x30]
       ldr       x0, [x0]
       ldr       x0, [x0, #0x20]
       cbz       x0, #0xf4e69002ee28
       bl        #0xf4e68ffe24c0
       mov       x20, x0
       add       x14, x20, #8
       mov       x15, x21
       bl        CORINFO_HELP_ASSIGN_REF
       movz      x0, #0x1920
       movk      x0, #0x90b3, lsl #16
       movk      x0, #0xf4e6, lsl #32
       str       x0, [x20, #0x18]
       movz      x0, #0x47b0
       movk      x0, #0x8ee3, lsl #16
       movk      x0, #0xf4e6, lsl #32
       bl        #0xf4e68ffe24c0
       mov       x21, x0
       ldr       x0, [x19, #0x30]
       ldr       x0, [x0]
       ldr       x0, [x0, #0x10]
       cbz       x0, #0xf4e69002ee50
       bl        #0xf4e68ffe24c0
       mov       x19, x0
       add       x14, x19, #0x10
       mov       x15, x20
       bl        CORINFO_HELP_ASSIGN_REF
       movz      x0, #0xfa00
       movk      x0, #0x909c, lsl #16
       movk      x0, #0xf4e6, lsl #32
       bl        #0xf4e68ffe24c0
       movz      w14, #0x8
       str       w14, [x0, #0x10]
       add       x20, x19, #8
       mov       x14, x20
       mov       x15, x0
       bl        CORINFO_HELP_ASSIGN_REF
       str       x21, [x29, #0x18]
       str       wzr, [x29, #0x2c]
       mov       x0, x21
       bl        #0xf4e68ffe2620
       cbz       w0, #0xf4e69002ed90
       movz      w0, #0x1
       str       w0, [x29, #0x2c]
; Total bytes of code 272
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.__Canon, System.Private.CoreLib]](System.Threading.Tasks.Task`1<System.__Canon>)
       stp       x29, x30, [sp, #-0x20]!
       str       x19, [sp, #0x18]
       mov       x29, sp
       mov       x19, x1
       add       x0, x19, #0x34
; Total bytes of code 20
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.__Canon, System.Private.CoreLib]].Nito_ExecuteOnCallingThread()
       stp       x29, x30, [sp, #-0x50]!
       stp       x19, x20, [sp, #0x38]
       str       x21, [sp, #0x48]
       mov       x29, sp
       str       x0, [x29, #0x30]
       str       x0, [x29, #0x20]
       ldr       x1, [x0]
       ldr       x2, [x1, #0x30]
       ldr       x2, [x2]
       ldr       x19, [x2, #0x28]
       cbz       x19, #0xe16677431394
       ldr       x0, [x29, #0x20]
       ldr       x20, [x0, #8]
       cbz       x20, #0xe166774313e8
       movz      x0, #0x47b0
       movk      x0, #0x7624, lsl #16
       movk      x0, #0xe166, lsl #32
       bl        #0xe166773f24c0
       mov       x21, x0
       ldr       x0, [x19, #0x30]
       ldr       x0, [x0]
       ldr       x0, [x0, #0x10]
       cbz       x0, #0xe166774313c0
       bl        #0xe166773f24c0
       mov       x19, x0
       add       x14, x19, #0x10
       mov       x15, x20
       bl        CORINFO_HELP_ASSIGN_REF
       movz      x0, #0xfa00
       movk      x0, #0x77dd, lsl #16
       movk      x0, #0xe166, lsl #32
       bl        #0xe166773f24c0
       movz      w14, #0x8
       str       w14, [x0, #0x10]
       add       x20, x19, #8
       mov       x14, x20
       mov       x15, x0
       bl        CORINFO_HELP_ASSIGN_REF
       str       x21, [x29, #0x18]
       str       wzr, [x29, #0x2c]
       mov       x0, x21
       bl        #0xe166773f2600
       cbz       w0, #0xe16677431354
       movz      w0, #0x1
       str       w0, [x29, #0x2c]
; Total bytes of code 180
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.__Canon, System.Private.CoreLib]](System.Threading.Tasks.Task`1<System.__Canon>)
       stp       x29, x30, [sp, #-0x20]!
       str       x19, [sp, #0x18]
       mov       x29, sp
       mov       x19, x1
       add       x0, x19, #0x34
; Total bytes of code 20
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.__Canon, System.Private.CoreLib]].VsThreading()
       stp       x29, x30, [sp, #-0x30]!
       stp       x19, x20, [sp, #0x18]
       str       x21, [sp, #0x28]
       mov       x29, sp
       str       x0, [x29, #0x10]
       mov       x19, x0
       ldr       x0, [x19]
       ldr       x1, [x0, #0x30]
       ldr       x1, [x1]
       ldr       x1, [x1, #0x28]
       cbz       x1, M00_L01
M00_L00:
       mov       x0, x1
       bl        #0xfc0da21e24c0
       mov       x20, x0
       ldr       x21, [x19, #8]
       movz      x0, #0x47b0
       movk      x0, #0xa103, lsl #16
       movk      x0, #0xfc0d, lsl #32
       bl        #0xfc0da21e24c0
       mov       x15, x0
       add       x14, x20, #8
       bl        CORINFO_HELP_ASSIGN_REF
       cbz       x21, M00_L02
       add       x14, x20, #0x20
       mov       x15, x21
       bl        CORINFO_HELP_ASSIGN_REF
       str       xzr, [x20, #0x10]
       mov       x0, x20
       mov       x1, xzr
       movz      x2, #0x59b0
       movk      x2, #0xa2d3, lsl #16
       movk      x2, #0xfc0d, lsl #32
       ldr       x2, [x2]
       ldr       x21, [sp, #0x28]
       ldp       x19, x20, [sp, #0x18]
       ldp       x29, x30, [sp], #0x30
       br        x2; Microsoft.VisualStudio.Threading.AsyncLazy`1[[System.__Canon, System.Private.CoreLib]].GetValueAsync(System.Threading.CancellationToken)
M00_L01:
       movz      x1, #0x46a0
       movk      x1, #0xa2d8, lsl #16
       movk      x1, #0xfc0d, lsl #32
       movz      x2, #0xf270
       movk      x2, #0xa219, lsl #16
       movk      x2, #0xfc0d, lsl #32
       ldr       x2, [x2]
       blr       x2; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       x1, x0
       b         M00_L00
M00_L02:
       movz      x0, #0x52f0
       movk      x0, #0xa25c, lsl #16
       movk      x0, #0xfc0d, lsl #32
       bl        #0xfc0da21e24c0
       mov       x20, x0
       movz      w0, #0x164
       movz      x1, #0x830
       movk      x1, #0xa2d6, lsl #16
       movk      x1, #0xfc0d, lsl #32
       movz      x2, #0xef88
       movk      x2, #0xa219, lsl #16
       movk      x2, #0xfc0d, lsl #32
       ldr       x2, [x2]
       blr       x2
       mov       x1, x0
       mov       x0, x20
       movz      x2, #0xd350
       movk      x2, #0xa2a9, lsl #16
       movk      x2, #0xfc0d, lsl #32
       ldr       x2, [x2]
       blr       x2
       mov       x0, x20
       bl        #0xfc0da21e2520
       brk       #0xf000
; Total bytes of code 284
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.__Canon, System.Private.CoreLib]](System.Threading.Tasks.Task`1<System.__Canon>)
       stp       x29, x30, [sp, #-0x20]!
       str       x19, [sp, #0x18]
       mov       x29, sp
       mov       x19, x1
       add       x0, x19, #0x34
; Total bytes of code 20
```
```assembly
; Microsoft.VisualStudio.Threading.AsyncLazy`1[[System.__Canon, System.Private.CoreLib]].GetValueAsync(System.Threading.CancellationToken)
       stp       x29, x30, [sp, #-0x110]!
       stp       x19, x20, [sp, #0xc0]
       stp       x21, x22, [sp, #0xd0]
       stp       x23, x24, [sp, #0xe0]
       stp       x25, x26, [sp, #0xf0]
       stp       x27, x28, [sp, #0x100]
       mov       x29, sp
       add       x9, x29, #0x20
       movi      v16.16b, #0
       stp       q16, q16, [x9]
       stp       q16, q16, [x9, #0x20]
       stp       q16, q16, [x9, #0x40]
       stp       q16, q16, [x9, #0x60]
       str       xzr, [x9, #0x80]
       str       x0, [x29, #0xb8]
       str       x0, [x29, #0x30]
       str       x1, [x29, #0xb0]
       ldr       x1, [x0]
       ldr       x2, [x1, #0x30]
       ldr       x2, [x2]
       ldr       x2, [x2, #0x18]
       cbz       x2, #0xfc0da22368f0
       mov       x0, x2
       bl        #0xfc0da21e24c0
       str       x0, [x29, #0x28]
       add       x14, x0, #8
       ldr       x15, [x29, #0x30]
       bl        CORINFO_HELP_ASSIGN_REF
       ldr       x15, [x29, #0x30]
       ldr       x1, [x15, #0x28]
       cbnz      x1, #0xfc0da223691c
       ldr       x1, [x15, #0x18]
       cbnz      x1, #0xfc0da2236934
       ldr       x15, [x29, #0x30]
       ldr       x1, [x15, #0x28]
       cbnz      x1, #0xfc0da2236858
       ldr       x1, [x15, #8]
       cbz       x1, #0xfc0da22369b4
       mov       x0, x1
       bl        #0xfc0da21e2610
       cbnz      w0, #0xfc0da22369f0
       ldr       x0, [x29, #0x28]
       str       xzr, [x0, #0x10]
       ldr       x15, [x29, #0x30]
       ldr       x1, [x15, #8]
       str       x1, [x29, #0x20]
       str       wzr, [x29, #0xac]
       ldr       x1, [x29, #0x20]
       cbz       x1, #0xfc0da2236504
       mov       x0, x1
       bl        #0xfc0da21e2620
       cbz       w0, #0xfc0da2236520
       movz      w0, #0x1
       str       w0, [x29, #0xac]
       ldr       x15, [x29, #0x30]
       ldr       x0, [x15, #0x28]
       cbnz      x0, #0xfc0da2236594
       ldr       x0, [x29, #0xb0]
       cbz       x0, #0xfc0da2235e64
       ldr       x0, [x29, #0xb0]
       add       x0, x0, #0x20
; Total bytes of code 244
```
```assembly
; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       stp       x29, x30, [sp, #-0xf0]!
       stp       x19, x20, [sp, #0xa0]
       stp       x21, x22, [sp, #0xb0]
       stp       x23, x24, [sp, #0xc0]
       stp       x25, x26, [sp, #0xd0]
       stp       x27, x28, [sp, #0xe0]
       mov       x29, sp
       mov       x2, x1
       mov       x1, x0
       stur      x1, [x29, #0x3c]
       stur      x2, [x29, #0x34]
       adrp      x11, #0xfc0da1da7000
       add       x11, x11, #0x6e0
       stur      x11, [x29, #0x2c]
       mov       x0, xzr
       stur      x0, [x29, #0x24]
       movn      w3, #0
       str       w3, [x29, #0x44]
       mov       x4, xzr
       stur      x4, [x29, #0x1c]
       add       x0, x29, #0x48
       adrp      x5, #0xfc0da1d8d000
       add       x5, x5, #0x920
       ldr       x5, [x5]
       blr       x5
       adrp      x0, #0xfc0da1db6000
       add       x0, x0, #0x4c0
       ldr       x0, [x0]
       ldr       x5, [x0]
       ldur      x1, [x29, #0x3c]
       ldur      x2, [x29, #0x34]
       ldur      x11, [x29, #0x2c]
       ldur      x0, [x29, #0x24]
       ldr       w3, [x29, #0x44]
       ldur      x4, [x29, #0x1c]
       blr       x5
       mov       x19, x0
       add       x0, x29, #0x48
       adrp      x1, #0xfc0da1d8d000
       add       x1, x1, #0x928
       ldr       x1, [x1]
       blr       x1; CORINFO_HELP_JIT_PINVOKE_END
       mov       x0, x19
       ldp       x27, x28, [sp, #0xe0]
       ldp       x25, x26, [sp, #0xd0]
       ldp       x23, x24, [sp, #0xc0]
       ldp       x21, x22, [sp, #0xb0]
       ldp       x19, x20, [sp, #0xa0]
       ldp       x29, x30, [sp], #0xf0
       ret       
; Total bytes of code 200
```

