## .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.ContendedFirstCallBenchmarks.LazyOfTask()
       stp       x29, x30, [sp, #-0x60]!
       stp       x19, x20, [sp, #0x18]
       stp       x21, x22, [sp, #0x28]
       stp       x23, x24, [sp, #0x38]
       stp       x25, x26, [sp, #0x48]
       str       x27, [sp, #0x58]
       mov       x29, sp
       mov       x19, x0
       movz      x0, #0xd510
       movk      x0, #0xd4b4, lsl #16
       movk      x0, #0xfb4b, lsl #32
       bl        #0xfb4bd3fe24c0
       mov       x20, x0
       movz      x0, #0xd8b0
       movk      x0, #0xd4b4, lsl #16
       movk      x0, #0xfb4b, lsl #32
       bl        #0xfb4bd3fe24c0
       mov       x21, x0
       movz      x22, #0x1350
       movk      x22, #0x1900, lsl #16
       movk      x22, #0xfb3c, lsl #32
       ldr       x15, [x22]
       add       x14, x21, #0x10
       bl        CORINFO_HELP_ASSIGN_REF
       movz      x0, #0xf1e8
       movk      x0, #0xd49c, lsl #16
       movk      x0, #0xfb4b, lsl #32
       bl        #0xfb4bd3fe24c0
       movz      w14, #0x8
       str       w14, [x0, #0x10]
       add       x14, x21, #8
       mov       x15, x0
       bl        CORINFO_HELP_ASSIGN_REF
       add       x14, x20, #8
       mov       x15, x21
       bl        CORINFO_HELP_ASSIGN_REF
       mov       w21, wzr
       ldr       x23, [x19, #8]
       ldr       w0, [x23, #8]
       cmp       w0, w21
       b.le      #0xfb4bd402bf5c
       ldr       x24, [x20, #0x10]
       cbnz      x24, M00_L00
       movz      x0, #0xd5a0
       movk      x0, #0xd4b4, lsl #16
       movk      x0, #0xfb4b, lsl #32
       bl        #0xfb4bd3fe24c0
       mov       x24, x0
       add       x14, x24, #8
       mov       x15, x20
       bl        CORINFO_HELP_ASSIGN_REF
       movz      x14, #0x17d0
       movk      x14, #0xd4b3, lsl #16
       movk      x14, #0xfb4b, lsl #32
       str       x14, [x24, #0x18]
       add       x14, x20, #0x10
       mov       x15, x24
       bl        CORINFO_HELP_ASSIGN_REF
M00_L00:
       ldr       x1, [x22, #0x20]
       cbz       x1, #0xfb4bd402c0d8
       ldrsb     wzr, [x1]
       ldr       x25, [x22, #0x30]
       movz      x0, #0xf840
       movk      x0, #0xd4b4, lsl #16
       movk      x0, #0xfb4b, lsl #32
       bl        #0xfb4bd3fe24c0
       mov       x26, x0
       add       x14, x26, #8
       mov       x15, x24
       bl        CORINFO_HELP_ASSIGN_REF
       str       xzr, [x26, #0x10]
       add       x14, x26, #0x18
       mov       x15, x25
       bl        CORINFO_HELP_ASSIGN_REF
       movz      w0, #0x2008
       add       x1, x26, #0x34
       stlr      w0, [x1]
       movz      x0, #0x22a0
       movk      x0, #0xd3fd, lsl #16
       movk      x0, #0xfb4b, lsl #32
       movz      x1, #0xe0b8
       movk      x1, #0xd4b3, lsl #16
       movk      x1, #0xfb4b, lsl #32
       ldr       x1, [x1]
       blr       x1; System.Runtime.CompilerServices.StaticsHelpers.GetDynamicGCThreadStaticBase(System.Runtime.CompilerServices.ThreadStaticsInfo*)
       ldr       x0, [x0, #0x10]
       cbnz      x0, M00_L01
       movz      x0, #0x74e0
       movk      x0, #0xd489, lsl #16
       movk      x0, #0xfb4b, lsl #32
       ldr       x0, [x0]
       blr       x0; System.Threading.Thread.InitializeCurrentThread()
M00_L01:
       ldr       x24, [x0, #8]
       cbz       x24, M00_L02
       ldrb      w0, [x24, #0x18]
       cbz       w0, M00_L03
       mov       x24, xzr
       b         M00_L03
M00_L02:
       ldr       x24, [x22, #0x40]
M00_L03:
       cbz       x24, M00_L05
       ldr       x0, [x22, #0x40]
       cmp       x24, x0
       b.eq      #0xfb4bd402bdb4
       ldr       x1, [x26, #0x28]
       cbnz      x1, M00_L04
       movz      x0, #0xbea8
       movk      x0, #0xd4bb, lsl #16
       movk      x0, #0xfb4b, lsl #32
       bl        #0xfb4bd3fe24c0
       mov       x1, x0
       add       x14, x1, #0x3c
       movz      w15, #0x1
       stlr      w15, [x14]
       add       x14, x26, #0x28
       mov       x15, x1
       bl        CORINFO_HELP_ASSIGN_REF
M00_L04:
       add       x14, x1, #8
       mov       x15, x24
       bl        CORINFO_HELP_ASSIGN_REF
       b         #0xfb4bd402bdb4
M00_L05:
       add       x0, x26, #0x34
; Total bytes of code 484
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       stp       x29, x30, [sp, #-0x10]!
       mov       x29, sp
       add       x1, x0, #0x34
; Total bytes of code 12
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetDynamicGCThreadStaticBase(System.Runtime.CompilerServices.ThreadStaticsInfo*)
       stp       x29, x30, [sp, #-0x20]!
       str       x19, [sp, #0x18]
       mov       x29, sp
       ldr       w19, [x0, #4]
       cmn       w19, #1
       b.eq      M02_L04
       movz      w0, #0x8
       bl        #0xfb4bd3fe2510
       sub       x0, x0, #8
       and       w1, w19, #0xffffff
       asr       w2, w1, #0
       asr       w3, w19, #0x18
       cbnz      w3, M02_L01
       ldr       w3, [x0]
       cmp       w3, w1
       b.le      M02_L03
       ldr       x0, [x0, #8]
       ldrsb     wzr, [x0], #0x10
       sub       w2, w2, #2
       ldr       x0, [x0, w2, sxtw #3]
       cbz       x0, M02_L03
M02_L00:
       ldr       x19, [sp, #0x18]
       ldp       x29, x30, [sp], #0x20
       ret       
M02_L01:
       asr       w1, w19, #0x18
       cmp       w1, #2
       b.ne      M02_L02
       add       x0, x0, w2, sxtw
       b         M02_L00
M02_L02:
       ldr       w1, [x0, #4]
       cmp       w1, w2
       b.le      M02_L03
       ldr       x0, [x0, #0x10]
       ldr       x0, [x0, w2, sxtw #3]
       cbz       x0, M02_L03
       ldr       x0, [x0]
       cbz       x0, M02_L03
       b         M02_L00
M02_L03:
       mov       w0, w19
       movz      x1, #0xcbd0
       movk      x1, #0xd3f9, lsl #16
       movk      x1, #0xfb4b, lsl #32
       ldr       x1, [x1]
       ldr       x19, [sp, #0x18]
       ldp       x29, x30, [sp], #0x20
       br        x1; System.Runtime.CompilerServices.StaticsHelpers.GetGCThreadStaticsByIndexSlow(Int32)
M02_L04:
       ldr       x0, [x0, #0x20]
       movz      x1, #0xda70
       movk      x1, #0xd4b3, lsl #16
       movk      x1, #0xfb4b, lsl #32
       ldr       x1, [x1]
       ldr       x19, [sp, #0x18]
       ldp       x29, x30, [sp], #0x20
       br        x1; System.Runtime.CompilerServices.StaticsHelpers.GetGCThreadStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 216
```
```assembly
; System.Threading.Thread.InitializeCurrentThread()
       stp       x29, x30, [sp, #-0xd0]!
       stp       x19, x20, [sp, #0x80]
       stp       x21, x22, [sp, #0x90]
       stp       x23, x24, [sp, #0xa0]
       stp       x25, x26, [sp, #0xb0]
       stp       x27, x28, [sp, #0xc0]
       mov       x29, sp
       str       xzr, [x29, #0x78]
       add       x0, x29, #0x78
       str       x0, [x29, #0x18]
       adrp      x11, #0xfb4bd3ba4000
       add       x11, x11, #0xfe8
       str       x11, [x29, #0x10]
       add       x0, x29, #0x20
       adrp      x1, #0xfb4bd3b8d000
       add       x1, x1, #0x920
       ldr       x1, [x1]
       blr       x1
       adrp      x0, #0xfb4bd3bb6000
       add       x0, x0, #0x280
       ldr       x0, [x0]
       ldr       x1, [x0]
       ldp       x11, x0, [x29, #0x10]
       blr       x1
       add       x0, x29, #0x20
       adrp      x1, #0xfb4bd3b8d000
       add       x1, x1, #0x928
       ldr       x1, [x1]
       blr       x1; CORINFO_HELP_JIT_PINVOKE_END
       ldr       x19, [x29, #0x78]
       adrp      x11, #0xfb4bd3b8f000
       add       x11, x11, #0x5c8
       ldr       x16, [x11]
       blr       x16
       add       x14, x0, #0x10
       ldr       x15, [x29, #0x78]
       adrp      x12, #0xfb4bd3b8d000
       add       x12, x12, #0x8d8
       ldr       x12, [x12]
       blr       x12; CORINFO_HELP_ASSIGN_REF
       mov       x0, x19
       ldp       x27, x28, [sp, #0xc0]
       ldp       x25, x26, [sp, #0xb0]
       ldp       x23, x24, [sp, #0xa0]
       ldp       x21, x22, [sp, #0x90]
       ldp       x19, x20, [sp, #0x80]
       ldp       x29, x30, [sp], #0xd0
       ret       
; Total bytes of code 192
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.ContendedFirstCallBenchmarks.AsyncLazy()
       stp       x29, x30, [sp, #-0x60]!
       stp       x19, x20, [sp, #0x18]
       stp       x21, x22, [sp, #0x28]
       stp       x23, x24, [sp, #0x38]
       stp       x25, x26, [sp, #0x48]
       str       x27, [sp, #0x58]
       mov       x29, sp
       mov       x19, x0
       movz      x0, #0xcf30
       movk      x0, #0x7c36, lsl #16
       movk      x0, #0xe151, lsl #32
       bl        #0xe1517b8024c0
       mov       x20, x0
       movz      x0, #0xd980
       movk      x0, #0x7c36, lsl #16
       movk      x0, #0xe151, lsl #32
       bl        #0xe1517b8024c0
       movz      x21, #0x1350
       movk      x21, #0xc100, lsl #16
       movk      x21, #0xe141, lsl #32
       ldr       x15, [x21]
       add       x14, x0, #0x18
       bl        CORINFO_HELP_ASSIGN_REF
       add       x14, x20, #8
       mov       x15, x0
       bl        CORINFO_HELP_ASSIGN_REF
       mov       w22, wzr
       ldr       x23, [x19, #8]
       ldr       w0, [x23, #8]
       cmp       w0, w22
       b.le      #0xe1517b8593bc
       ldr       x24, [x20, #0x10]
       cbnz      x24, M00_L00
       movz      x0, #0xcfc0
       movk      x0, #0x7c36, lsl #16
       movk      x0, #0xe151, lsl #32
       bl        #0xe1517b8024c0
       mov       x24, x0
       add       x14, x24, #8
       mov       x15, x20
       bl        CORINFO_HELP_ASSIGN_REF
       movz      x14, #0x16f8
       movk      x14, #0x7c35, lsl #16
       movk      x14, #0xe151, lsl #32
       str       x14, [x24, #0x18]
       add       x14, x20, #0x10
       mov       x15, x24
       bl        CORINFO_HELP_ASSIGN_REF
M00_L00:
       ldr       x1, [x21, #0x20]
       cbz       x1, #0xe1517b85955c
       ldrsb     wzr, [x1]
       ldr       x25, [x21, #0x30]
       movz      x0, #0xf8d0
       movk      x0, #0x7c36, lsl #16
       movk      x0, #0xe151, lsl #32
       bl        #0xe1517b8024c0
       mov       x26, x0
       add       x14, x26, #8
       mov       x15, x24
       bl        CORINFO_HELP_ASSIGN_REF
       str       xzr, [x26, #0x10]
       add       x14, x26, #0x18
       mov       x15, x25
       bl        CORINFO_HELP_ASSIGN_REF
       movz      w0, #0x2008
       add       x1, x26, #0x34
       stlr      w0, [x1]
       movz      x0, #0x22a0
       movk      x0, #0x7b7f, lsl #16
       movk      x0, #0xe151, lsl #32
       movz      x1, #0xe8f8
       movk      x1, #0x7c35, lsl #16
       movk      x1, #0xe151, lsl #32
       ldr       x1, [x1]
       blr       x1; System.Runtime.CompilerServices.StaticsHelpers.GetDynamicGCThreadStaticBase(System.Runtime.CompilerServices.ThreadStaticsInfo*)
       ldr       x0, [x0, #0x10]
       cbnz      x0, M00_L01
       movz      x0, #0x74e0
       movk      x0, #0x7c0b, lsl #16
       movk      x0, #0xe151, lsl #32
       ldr       x0, [x0]
       blr       x0; System.Threading.Thread.InitializeCurrentThread()
M00_L01:
       ldr       x24, [x0, #8]
       cbnz      x24, #0xe1517b859594
       ldr       x24, [x21, #0x40]
       cbz       x24, M00_L03
       ldr       x0, [x21, #0x40]
       cmp       x24, x0
       b.eq      #0xe1517b8591fc
       ldr       x1, [x26, #0x28]
       cbnz      x1, M00_L02
       movz      x0, #0xe318
       movk      x0, #0x7c3b, lsl #16
       movk      x0, #0xe151, lsl #32
       bl        #0xe1517b8024c0
       mov       x1, x0
       add       x14, x1, #0x3c
       movz      w15, #0x1
       stlr      w15, [x14]
       add       x14, x26, #0x28
       mov       x15, x1
       bl        CORINFO_HELP_ASSIGN_REF
M00_L02:
       add       x14, x1, #8
       mov       x15, x24
       bl        CORINFO_HELP_ASSIGN_REF
       b         #0xe1517b8591fc
M00_L03:
       add       x0, x26, #0x34
; Total bytes of code 428
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       stp       x29, x30, [sp, #-0x10]!
       mov       x29, sp
       add       x1, x0, #0x34
; Total bytes of code 12
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetDynamicGCThreadStaticBase(System.Runtime.CompilerServices.ThreadStaticsInfo*)
       stp       x29, x30, [sp, #-0x20]!
       str       x19, [sp, #0x18]
       mov       x29, sp
       ldr       w19, [x0, #4]
       cmn       w19, #1
       b.eq      M02_L04
       movz      w0, #0x8
       bl        #0xe1517b802510
       sub       x0, x0, #8
       and       w1, w19, #0xffffff
       asr       w2, w1, #0
       asr       w3, w19, #0x18
       cbnz      w3, M02_L01
       ldr       w3, [x0]
       cmp       w3, w1
       b.le      M02_L03
       ldr       x0, [x0, #8]
       ldrsb     wzr, [x0], #0x10
       sub       w2, w2, #2
       ldr       x0, [x0, w2, sxtw #3]
       cbz       x0, M02_L03
M02_L00:
       ldr       x19, [sp, #0x18]
       ldp       x29, x30, [sp], #0x20
       ret       
M02_L01:
       asr       w1, w19, #0x18
       cmp       w1, #2
       b.ne      M02_L02
       add       x0, x0, w2, sxtw
       b         M02_L00
M02_L02:
       ldr       w1, [x0, #4]
       cmp       w1, w2
       b.le      M02_L03
       ldr       x0, [x0, #0x10]
       ldr       x0, [x0, w2, sxtw #3]
       cbz       x0, M02_L03
       ldr       x0, [x0]
       cbz       x0, M02_L03
       b         M02_L00
M02_L03:
       mov       w0, w19
       movz      x1, #0xcbd0
       movk      x1, #0x7b7b, lsl #16
       movk      x1, #0xe151, lsl #32
       ldr       x1, [x1]
       ldr       x19, [sp, #0x18]
       ldp       x29, x30, [sp], #0x20
       br        x1; System.Runtime.CompilerServices.StaticsHelpers.GetGCThreadStaticsByIndexSlow(Int32)
M02_L04:
       ldr       x0, [x0, #0x20]
       movz      x1, #0xe298
       movk      x1, #0x7c35, lsl #16
       movk      x1, #0xe151, lsl #32
       ldr       x1, [x1]
       ldr       x19, [sp, #0x18]
       ldp       x29, x30, [sp], #0x20
       br        x1; System.Runtime.CompilerServices.StaticsHelpers.GetGCThreadStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 216
```
```assembly
; System.Threading.Thread.InitializeCurrentThread()
       stp       x29, x30, [sp, #-0xd0]!
       stp       x19, x20, [sp, #0x80]
       stp       x21, x22, [sp, #0x90]
       stp       x23, x24, [sp, #0xa0]
       stp       x25, x26, [sp, #0xb0]
       stp       x27, x28, [sp, #0xc0]
       mov       x29, sp
       str       xzr, [x29, #0x78]
       add       x0, x29, #0x78
       str       x0, [x29, #0x18]
       adrp      x11, #0xe1517b3c4000
       add       x11, x11, #0xfe8
       str       x11, [x29, #0x10]
       add       x0, x29, #0x20
       adrp      x1, #0xe1517b3ad000
       add       x1, x1, #0x920
       ldr       x1, [x1]
       blr       x1
       adrp      x0, #0xe1517b3d6000
       add       x0, x0, #0x280
       ldr       x0, [x0]
       ldr       x1, [x0]
       ldp       x11, x0, [x29, #0x10]
       blr       x1
       add       x0, x29, #0x20
       adrp      x1, #0xe1517b3ad000
       add       x1, x1, #0x928
       ldr       x1, [x1]
       blr       x1; CORINFO_HELP_JIT_PINVOKE_END
       ldr       x19, [x29, #0x78]
       adrp      x11, #0xe1517b3af000
       add       x11, x11, #0x5c8
       ldr       x16, [x11]
       blr       x16
       add       x14, x0, #0x10
       ldr       x15, [x29, #0x78]
       adrp      x12, #0xe1517b3ad000
       add       x12, x12, #0x8d8
       ldr       x12, [x12]
       blr       x12; CORINFO_HELP_ASSIGN_REF
       mov       x0, x19
       ldp       x27, x28, [sp, #0xc0]
       ldp       x25, x26, [sp, #0xb0]
       ldp       x23, x24, [sp, #0xa0]
       ldp       x21, x22, [sp, #0x90]
       ldp       x19, x20, [sp, #0x80]
       ldp       x29, x30, [sp], #0xd0
       ret       
; Total bytes of code 192
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.ContendedFirstCallBenchmarks.Nito()
       stp       x29, x30, [sp, #-0x60]!
       stp       x19, x20, [sp, #0x10]
       stp       x21, x22, [sp, #0x20]
       stp       x23, x24, [sp, #0x30]
       stp       x25, x26, [sp, #0x40]
       stp       x27, x28, [sp, #0x50]
       mov       x29, sp
       mov       x19, x0
       movz      x20, #0xd510
       movk      x20, #0x8095, lsl #16
       movk      x20, #0xf42a, lsl #32
       mov       x0, x20
       bl        #0xf42a7fdf24c0
       mov       x21, x0
       movz      x0, #0xe010
       movk      x0, #0x8095, lsl #16
       movk      x0, #0xf42a, lsl #32
       bl        #0xf42a7fdf24c0
       mov       x22, x0
       movz      x23, #0x1350
       movk      x23, #0xc500, lsl #16
       movk      x23, #0xf41a, lsl #32
       ldr       x24, [x23]
       mov       x15, x24
       add       x14, x22, #0x10
       bl        CORINFO_HELP_ASSIGN_REF
       movz      x0, #0xdb8
       movk      x0, #0x8097, lsl #16
       movk      x0, #0xf42a, lsl #32
       bl        #0xf42a7fdf24c0
       mov       x25, x0
       add       x14, x25, #8
       mov       x15, x24
       bl        CORINFO_HELP_ASSIGN_REF
       add       x0, x20, #0x90
       bl        #0xf42a7fdf24c0
       add       x14, x0, #8
       mov       x15, x25
       bl        CORINFO_HELP_ASSIGN_REF
       movz      x14, #0x18f0
       movk      x14, #0x8094, lsl #16
       movk      x14, #0xf42a, lsl #32
       str       x14, [x0, #0x18]
       add       x14, x22, #0x10
       mov       x15, x0
       bl        CORINFO_HELP_ASSIGN_REF
       movz      x0, #0x47b0
       movk      x0, #0x7ec4, lsl #16
       movk      x0, #0xf42a, lsl #32
       bl        #0xf42a7fdf24c0
       mov       x15, x0
       add       x14, x22, #8
       bl        CORINFO_HELP_ASSIGN_REF
       movz      x0, #0x18
       movk      x0, #0x8097, lsl #16
       movk      x0, #0xf42a, lsl #32
       bl        #0xf42a7fdf24c0
       mov       x24, x0
       ldr       x15, [x22, #0x10]
       add       x14, x24, #0x10
       bl        CORINFO_HELP_ASSIGN_REF
       movz      x0, #0xf1e8
       movk      x0, #0x807d, lsl #16
       movk      x0, #0xf42a, lsl #32
       bl        #0xf42a7fdf24c0
       movz      w14, #0x8
       str       w14, [x0, #0x10]
       add       x14, x24, #8
       mov       x15, x0
       bl        CORINFO_HELP_ASSIGN_REF
       add       x14, x22, #0x18
       mov       x15, x24
       bl        CORINFO_HELP_ASSIGN_REF
       add       x14, x21, #8
       mov       x15, x22
       bl        CORINFO_HELP_ASSIGN_REF
       mov       w22, wzr
       ldr       x24, [x19, #8]
       ldr       w0, [x24, #8]
       cmp       w0, w22
       b.le      #0xf42a7fe3eafc
       ldr       x25, [x21, #0x10]
       cbnz      x25, M00_L00
       add       x0, x20, #0x90
       bl        #0xf42a7fdf24c0
       mov       x25, x0
       add       x14, x25, #8
       mov       x15, x21
       bl        CORINFO_HELP_ASSIGN_REF
       movz      x14, #0x17d0
       movk      x14, #0x8094, lsl #16
       movk      x14, #0xf42a, lsl #32
       str       x14, [x25, #0x18]
       add       x14, x21, #0x10
       mov       x15, x25
       bl        CORINFO_HELP_ASSIGN_REF
M00_L00:
       ldr       x1, [x23, #0x20]
       cbz       x1, #0xf42a7fe3ec9c
       ldrsb     wzr, [x1]
       ldr       x26, [x23, #0x30]
       movz      x0, #0x1130
       movk      x0, #0x8097, lsl #16
       movk      x0, #0xf42a, lsl #32
       bl        #0xf42a7fdf24c0
       mov       x27, x0
       add       x14, x27, #8
       mov       x15, x25
       bl        CORINFO_HELP_ASSIGN_REF
       str       xzr, [x27, #0x10]
       add       x14, x27, #0x18
       mov       x15, x26
       bl        CORINFO_HELP_ASSIGN_REF
       movz      w0, #0x2008
       add       x1, x27, #0x34
       stlr      w0, [x1]
       movz      x0, #0x22a0
       movk      x0, #0x7fde, lsl #16
       movk      x0, #0xf42a, lsl #32
       movz      x1, #0xe1c0
       movk      x1, #0x8094, lsl #16
       movk      x1, #0xf42a, lsl #32
       ldr       x1, [x1]
       blr       x1; System.Runtime.CompilerServices.StaticsHelpers.GetDynamicGCThreadStaticBase(System.Runtime.CompilerServices.ThreadStaticsInfo*)
       ldr       x0, [x0, #0x10]
       cbnz      x0, M00_L01
       movz      x0, #0x74e0
       movk      x0, #0x806a, lsl #16
       movk      x0, #0xf42a, lsl #32
       ldr       x0, [x0]
       blr       x0; System.Threading.Thread.InitializeCurrentThread()
M00_L01:
       ldr       x25, [x0, #8]
       cbz       x25, M00_L02
       ldrb      w0, [x25, #0x18]
       cbz       w0, M00_L03
       mov       x25, xzr
       b         M00_L03
M00_L02:
       ldr       x25, [x23, #0x40]
M00_L03:
       cbz       x25, M00_L05
       ldr       x0, [x23, #0x40]
       cmp       x25, x0
       b.eq      #0xf42a7fe3e94c
       ldr       x1, [x27, #0x28]
       cbnz      x1, M00_L04
       movz      x0, #0xc0b0
       movk      x0, #0x809d, lsl #16
       movk      x0, #0xf42a, lsl #32
       bl        #0xf42a7fdf24c0
       mov       x1, x0
       add       x14, x1, #0x3c
       movz      w15, #0x1
       stlr      w15, [x14]
       add       x14, x27, #0x28
       mov       x15, x1
       bl        CORINFO_HELP_ASSIGN_REF
M00_L04:
       add       x14, x1, #8
       mov       x15, x25
       bl        CORINFO_HELP_ASSIGN_REF
       b         #0xf42a7fe3e94c
M00_L05:
       add       x0, x27, #0x34
; Total bytes of code 636
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       stp       x29, x30, [sp, #-0x10]!
       mov       x29, sp
       add       x1, x0, #0x34
; Total bytes of code 12
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetDynamicGCThreadStaticBase(System.Runtime.CompilerServices.ThreadStaticsInfo*)
       stp       x29, x30, [sp, #-0x20]!
       str       x19, [sp, #0x18]
       mov       x29, sp
       ldr       w19, [x0, #4]
       cmn       w19, #1
       b.eq      M02_L04
       movz      w0, #0x8
       bl        #0xf42a7fdf2510
       sub       x0, x0, #8
       and       w1, w19, #0xffffff
       asr       w2, w1, #0
       asr       w3, w19, #0x18
       cbnz      w3, M02_L01
       ldr       w3, [x0]
       cmp       w3, w1
       b.le      M02_L03
       ldr       x0, [x0, #8]
       ldrsb     wzr, [x0], #0x10
       sub       w2, w2, #2
       ldr       x0, [x0, w2, sxtw #3]
       cbz       x0, M02_L03
M02_L00:
       ldr       x19, [sp, #0x18]
       ldp       x29, x30, [sp], #0x20
       ret       
M02_L01:
       asr       w1, w19, #0x18
       cmp       w1, #2
       b.ne      M02_L02
       add       x0, x0, w2, sxtw
       b         M02_L00
M02_L02:
       ldr       w1, [x0, #4]
       cmp       w1, w2
       b.le      M02_L03
       ldr       x0, [x0, #0x10]
       ldr       x0, [x0, w2, sxtw #3]
       cbz       x0, M02_L03
       ldr       x0, [x0]
       cbz       x0, M02_L03
       b         M02_L00
M02_L03:
       mov       w0, w19
       movz      x1, #0xcbd0
       movk      x1, #0x7fda, lsl #16
       movk      x1, #0xf42a, lsl #32
       ldr       x1, [x1]
       ldr       x19, [sp, #0x18]
       ldp       x29, x30, [sp], #0x20
       br        x1; System.Runtime.CompilerServices.StaticsHelpers.GetGCThreadStaticsByIndexSlow(Int32)
M02_L04:
       ldr       x0, [x0, #0x20]
       movz      x1, #0xdb30
       movk      x1, #0x8094, lsl #16
       movk      x1, #0xf42a, lsl #32
       ldr       x1, [x1]
       ldr       x19, [sp, #0x18]
       ldp       x29, x30, [sp], #0x20
       br        x1; System.Runtime.CompilerServices.StaticsHelpers.GetGCThreadStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 216
```
```assembly
; System.Threading.Thread.InitializeCurrentThread()
       stp       x29, x30, [sp, #-0xd0]!
       stp       x19, x20, [sp, #0x80]
       stp       x21, x22, [sp, #0x90]
       stp       x23, x24, [sp, #0xa0]
       stp       x25, x26, [sp, #0xb0]
       stp       x27, x28, [sp, #0xc0]
       mov       x29, sp
       str       xzr, [x29, #0x78]
       add       x0, x29, #0x78
       str       x0, [x29, #0x18]
       adrp      x11, #0xf42a7f9b4000
       add       x11, x11, #0xfe8
       str       x11, [x29, #0x10]
       add       x0, x29, #0x20
       adrp      x1, #0xf42a7f99d000
       add       x1, x1, #0x920
       ldr       x1, [x1]
       blr       x1
       adrp      x0, #0xf42a7f9c6000
       add       x0, x0, #0x280
       ldr       x0, [x0]
       ldr       x1, [x0]
       ldp       x11, x0, [x29, #0x10]
       blr       x1
       add       x0, x29, #0x20
       adrp      x1, #0xf42a7f99d000
       add       x1, x1, #0x928
       ldr       x1, [x1]
       blr       x1; CORINFO_HELP_JIT_PINVOKE_END
       ldr       x19, [x29, #0x78]
       adrp      x11, #0xf42a7f99f000
       add       x11, x11, #0x5c8
       ldr       x16, [x11]
       blr       x16
       add       x14, x0, #0x10
       ldr       x15, [x29, #0x78]
       adrp      x12, #0xf42a7f99d000
       add       x12, x12, #0x8d8
       ldr       x12, [x12]
       blr       x12; CORINFO_HELP_ASSIGN_REF
       mov       x0, x19
       ldp       x27, x28, [sp, #0xc0]
       ldp       x25, x26, [sp, #0xb0]
       ldp       x23, x24, [sp, #0xa0]
       ldp       x21, x22, [sp, #0x90]
       ldp       x19, x20, [sp, #0x80]
       ldp       x29, x30, [sp], #0xd0
       ret       
; Total bytes of code 192
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.ContendedFirstCallBenchmarks.VsThreading()
       stp       x29, x30, [sp, #-0x60]!
       stp       x19, x20, [sp, #0x18]
       stp       x21, x22, [sp, #0x28]
       stp       x23, x24, [sp, #0x38]
       stp       x25, x26, [sp, #0x48]
       str       x27, [sp, #0x58]
       mov       x29, sp
       mov       x19, x0
       movz      x0, #0xcf30
       movk      x0, #0xca95, lsl #16
       movk      x0, #0xe0ff, lsl #32
       bl        #0xe0ffc9df24c0
       mov       x20, x0
       movz      x0, #0xdc40
       movk      x0, #0xca95, lsl #16
       movk      x0, #0xe0ff, lsl #32
       bl        #0xe0ffc9df24c0
       mov       x21, x0
       movz      x22, #0x1350
       movk      x22, #0x1100, lsl #16
       movk      x22, #0xe0f0, lsl #32
       ldr       x23, [x22]
       movz      x0, #0x47b0
       movk      x0, #0xc8c4, lsl #16
       movk      x0, #0xe0ff, lsl #32
       bl        #0xe0ffc9df24c0
       mov       x15, x0
       add       x14, x21, #8
       bl        CORINFO_HELP_ASSIGN_REF
       add       x14, x21, #0x20
       mov       x15, x23
       bl        CORINFO_HELP_ASSIGN_REF
       str       xzr, [x21, #0x10]
       add       x14, x20, #8
       mov       x15, x21
       bl        CORINFO_HELP_ASSIGN_REF
       mov       w21, wzr
       ldr       x23, [x19, #8]
       ldr       w0, [x23, #8]
       cmp       w0, w21
       b.le      #0xe0ffc9e44138
       ldr       x24, [x20, #0x10]
       cbnz      x24, M00_L00
       movz      x0, #0xcfc0
       movk      x0, #0xca95, lsl #16
       movk      x0, #0xe0ff, lsl #32
       bl        #0xe0ffc9df24c0
       mov       x24, x0
       add       x14, x24, #8
       mov       x15, x20
       bl        CORINFO_HELP_ASSIGN_REF
       movz      x14, #0x1728
       movk      x14, #0xca94, lsl #16
       movk      x14, #0xe0ff, lsl #32
       str       x14, [x24, #0x18]
       add       x14, x20, #0x10
       mov       x15, x24
       bl        CORINFO_HELP_ASSIGN_REF
M00_L00:
       ldr       x1, [x22, #0x30]
       cbz       x1, #0xe0ffc9e44294
       ldrsb     wzr, [x1]
       ldr       x25, [x22, #0x40]
       movz      x0, #0x1d70
       movk      x0, #0xca99, lsl #16
       movk      x0, #0xe0ff, lsl #32
       bl        #0xe0ffc9df24c0
       mov       x26, x0
       add       x14, x26, #8
       mov       x15, x24
       bl        CORINFO_HELP_ASSIGN_REF
       str       xzr, [x26, #0x10]
       add       x14, x26, #0x18
       mov       x15, x25
       bl        CORINFO_HELP_ASSIGN_REF
       movz      w0, #0x2008
       add       x1, x26, #0x34
       stlr      w0, [x1]
       movz      x0, #0x22a0
       movk      x0, #0xc9de, lsl #16
       movk      x0, #0xe0ff, lsl #32
       movz      x1, #0xff48
       movk      x1, #0xca94, lsl #16
       movk      x1, #0xe0ff, lsl #32
       ldr       x1, [x1]
       blr       x1; System.Runtime.CompilerServices.StaticsHelpers.GetDynamicGCThreadStaticBase(System.Runtime.CompilerServices.ThreadStaticsInfo*)
       ldr       x0, [x0, #0x10]
       cbnz      x0, M00_L01
       movz      x0, #0x74e0
       movk      x0, #0xca6a, lsl #16
       movk      x0, #0xe0ff, lsl #32
       ldr       x0, [x0]
       blr       x0; System.Threading.Thread.InitializeCurrentThread()
M00_L01:
       ldr       x24, [x0, #8]
       cbnz      x24, #0xe0ffc9e43fb8
       ldr       x24, [x22, #0x50]
       cbnz      x24, #0xe0ffc9e43fc4
       add       x0, x26, #0x34
; Total bytes of code 388
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       stp       x29, x30, [sp, #-0x10]!
       mov       x29, sp
       add       x1, x0, #0x34
; Total bytes of code 12
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetDynamicGCThreadStaticBase(System.Runtime.CompilerServices.ThreadStaticsInfo*)
       stp       x29, x30, [sp, #-0x20]!
       str       x19, [sp, #0x18]
       mov       x29, sp
       ldr       w19, [x0, #4]
       cmn       w19, #1
       b.eq      M02_L04
       movz      w0, #0x8
       bl        #0xe0ffc9df2510
       sub       x0, x0, #8
       and       w1, w19, #0xffffff
       asr       w2, w1, #0
       asr       w3, w19, #0x18
       cbnz      w3, M02_L01
       ldr       w3, [x0]
       cmp       w3, w1
       b.le      M02_L03
       ldr       x0, [x0, #8]
       ldrsb     wzr, [x0], #0x10
       sub       w2, w2, #2
       ldr       x0, [x0, w2, sxtw #3]
       cbz       x0, M02_L03
M02_L00:
       ldr       x19, [sp, #0x18]
       ldp       x29, x30, [sp], #0x20
       ret       
M02_L01:
       asr       w1, w19, #0x18
       cmp       w1, #2
       b.ne      M02_L02
       add       x0, x0, w2, sxtw
       b         M02_L00
M02_L02:
       ldr       w1, [x0, #4]
       cmp       w1, w2
       b.le      M02_L03
       ldr       x0, [x0, #0x10]
       ldr       x0, [x0, w2, sxtw #3]
       cbz       x0, M02_L03
       ldr       x0, [x0]
       cbz       x0, M02_L03
       b         M02_L00
M02_L03:
       mov       w0, w19
       movz      x1, #0xcbd0
       movk      x1, #0xc9da, lsl #16
       movk      x1, #0xe0ff, lsl #32
       ldr       x1, [x1]
       ldr       x19, [sp, #0x18]
       ldp       x29, x30, [sp], #0x20
       br        x1; System.Runtime.CompilerServices.StaticsHelpers.GetGCThreadStaticsByIndexSlow(Int32)
M02_L04:
       ldr       x0, [x0, #0x20]
       movz      x1, #0xf978
       movk      x1, #0xca94, lsl #16
       movk      x1, #0xe0ff, lsl #32
       ldr       x1, [x1]
       ldr       x19, [sp, #0x18]
       ldp       x29, x30, [sp], #0x20
       br        x1; System.Runtime.CompilerServices.StaticsHelpers.GetGCThreadStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 216
```
```assembly
; System.Threading.Thread.InitializeCurrentThread()
       stp       x29, x30, [sp, #-0xd0]!
       stp       x19, x20, [sp, #0x80]
       stp       x21, x22, [sp, #0x90]
       stp       x23, x24, [sp, #0xa0]
       stp       x25, x26, [sp, #0xb0]
       stp       x27, x28, [sp, #0xc0]
       mov       x29, sp
       str       xzr, [x29, #0x78]
       add       x0, x29, #0x78
       str       x0, [x29, #0x18]
       adrp      x11, #0xe0ffc99b4000
       add       x11, x11, #0xfe8
       str       x11, [x29, #0x10]
       add       x0, x29, #0x20
       adrp      x1, #0xe0ffc999d000
       add       x1, x1, #0x920
       ldr       x1, [x1]
       blr       x1
       adrp      x0, #0xe0ffc99c6000
       add       x0, x0, #0x280
       ldr       x0, [x0]
       ldr       x1, [x0]
       ldp       x11, x0, [x29, #0x10]
       blr       x1
       add       x0, x29, #0x20
       adrp      x1, #0xe0ffc999d000
       add       x1, x1, #0x928
       ldr       x1, [x1]
       blr       x1; CORINFO_HELP_JIT_PINVOKE_END
       ldr       x19, [x29, #0x78]
       adrp      x11, #0xe0ffc999f000
       add       x11, x11, #0x5c8
       ldr       x16, [x11]
       blr       x16
       add       x14, x0, #0x10
       ldr       x15, [x29, #0x78]
       adrp      x12, #0xe0ffc999d000
       add       x12, x12, #0x8d8
       ldr       x12, [x12]
       blr       x12; CORINFO_HELP_ASSIGN_REF
       mov       x0, x19
       ldp       x27, x28, [sp, #0xc0]
       ldp       x25, x26, [sp, #0xb0]
       ldp       x23, x24, [sp, #0xa0]
       ldp       x21, x22, [sp, #0x90]
       ldp       x19, x20, [sp, #0x80]
       ldp       x29, x30, [sp], #0xd0
       ret       
; Total bytes of code 192
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.ContendedFirstCallBenchmarks.LazyOfTask()
       stp       x29, x30, [sp, #-0x60]!
       stp       x19, x20, [sp, #0x10]
       stp       x21, x22, [sp, #0x20]
       stp       x23, x24, [sp, #0x30]
       stp       x25, x26, [sp, #0x40]
       stp       x27, x28, [sp, #0x50]
       mov       x29, sp
       mov       x19, x0
       movz      x0, #0xd510
       movk      x0, #0xb716, lsl #16
       movk      x0, #0xefc0, lsl #32
       bl        #0xefc0b66024c0
       mov       x20, x0
       movz      x0, #0xd8b0
       movk      x0, #0xb716, lsl #16
       movk      x0, #0xefc0, lsl #32
       bl        #0xefc0b66024c0
       mov       x21, x0
       movz      x22, #0x1350
       movk      x22, #0xf900, lsl #16
       movk      x22, #0xefb0, lsl #32
       ldr       x15, [x22]
       add       x14, x21, #0x10
       bl        CORINFO_HELP_ASSIGN_REF
       movz      x0, #0xf1e8
       movk      x0, #0xb6fe, lsl #16
       movk      x0, #0xefc0, lsl #32
       bl        #0xefc0b66024c0
       movz      w14, #0x8
       str       w14, [x0, #0x10]
       add       x14, x21, #8
       mov       x15, x0
       bl        CORINFO_HELP_ASSIGN_REF
       add       x14, x20, #8
       mov       x15, x21
       bl        CORINFO_HELP_ASSIGN_REF
       mov       w21, wzr
       ldr       x23, [x19, #8]
       ldr       w0, [x23, #8]
       cmp       w0, w21
       b.le      #0xefc0b664c71c
       ldr       x24, [x20, #0x10]
       cbz       x24, #0xefc0b664c530
       ldr       x1, [x22, #0x20]
       cbz       x1, #0xefc0b664c898
       ldrsb     wzr, [x1]
       ldr       x25, [x22, #0x30]
       movz      x0, #0xf840
       movk      x0, #0xb716, lsl #16
       movk      x0, #0xefc0, lsl #32
       bl        #0xefc0b66024c0
       mov       x26, x0
       add       x14, x26, #8
       mov       x15, x24
       bl        CORINFO_HELP_ASSIGN_REF
       str       xzr, [x26, #0x10]
       add       x14, x26, #0x18
       mov       x15, x25
       bl        CORINFO_HELP_ASSIGN_REF
       movz      w0, #0x2008
       add       x24, x26, #0x34
       stlr      w0, [x24]
       movz      x0, #0x22a0
       movk      x0, #0xb65f, lsl #16
       movk      x0, #0xefc0, lsl #32
       movz      x1, #0xe190
       movk      x1, #0xb715, lsl #16
       movk      x1, #0xefc0, lsl #32
       ldr       x1, [x1]
       blr       x1; System.Runtime.CompilerServices.StaticsHelpers.GetDynamicGCThreadStaticBase(System.Runtime.CompilerServices.ThreadStaticsInfo*)
       ldr       x0, [x0, #0x10]
       cbnz      x0, M00_L00
       movz      x0, #0x74e0
       movk      x0, #0xb6eb, lsl #16
       movk      x0, #0xefc0, lsl #32
       ldr       x0, [x0]
       blr       x0; System.Threading.Thread.InitializeCurrentThread()
M00_L00:
       ldr       x25, [x0, #8]
       cbnz      x25, #0xefc0b664c570
       ldr       x25, [x22, #0x40]
       cbnz      x25, #0xefc0b664c580
; Total bytes of code 324
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       stp       x29, x30, [sp, #-0x10]!
       mov       x29, sp
       add       x1, x0, #0x34
; Total bytes of code 12
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetDynamicGCThreadStaticBase(System.Runtime.CompilerServices.ThreadStaticsInfo*)
       stp       x29, x30, [sp, #-0x20]!
       str       x19, [sp, #0x18]
       mov       x29, sp
       ldr       w19, [x0, #4]
       cmn       w19, #1
       b.eq      M02_L04
       movz      w0, #0x8
       bl        #0xefc0b6602510
       sub       x0, x0, #8
       and       w1, w19, #0xffffff
       asr       w2, w1, #0
       asr       w3, w19, #0x18
       cbnz      w3, M02_L01
       ldr       w3, [x0]
       cmp       w3, w1
       b.le      M02_L03
       ldr       x0, [x0, #8]
       ldrsb     wzr, [x0], #0x10
       sub       w2, w2, #2
       ldr       x0, [x0, w2, sxtw #3]
       cbz       x0, M02_L03
M02_L00:
       ldr       x19, [sp, #0x18]
       ldp       x29, x30, [sp], #0x20
       ret       
M02_L01:
       asr       w1, w19, #0x18
       cmp       w1, #2
       b.ne      M02_L02
       add       x0, x0, w2, sxtw
       b         M02_L00
M02_L02:
       ldr       w1, [x0, #4]
       cmp       w1, w2
       b.le      M02_L03
       ldr       x0, [x0, #0x10]
       ldr       x0, [x0, w2, sxtw #3]
       cbz       x0, M02_L03
       ldr       x0, [x0]
       cbz       x0, M02_L03
       b         M02_L00
M02_L03:
       mov       w0, w19
       movz      x1, #0xcbd0
       movk      x1, #0xb65b, lsl #16
       movk      x1, #0xefc0, lsl #32
       ldr       x1, [x1]
       ldr       x19, [sp, #0x18]
       ldp       x29, x30, [sp], #0x20
       br        x1; System.Runtime.CompilerServices.StaticsHelpers.GetGCThreadStaticsByIndexSlow(Int32)
M02_L04:
       ldr       x0, [x0, #0x20]
       movz      x1, #0xd9b0
       movk      x1, #0xb715, lsl #16
       movk      x1, #0xefc0, lsl #32
       ldr       x1, [x1]
       ldr       x19, [sp, #0x18]
       ldp       x29, x30, [sp], #0x20
       br        x1; System.Runtime.CompilerServices.StaticsHelpers.GetGCThreadStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 216
```
```assembly
; System.Threading.Thread.InitializeCurrentThread()
       stp       x29, x30, [sp, #-0xd0]!
       stp       x19, x20, [sp, #0x80]
       stp       x21, x22, [sp, #0x90]
       stp       x23, x24, [sp, #0xa0]
       stp       x25, x26, [sp, #0xb0]
       stp       x27, x28, [sp, #0xc0]
       mov       x29, sp
       str       xzr, [x29, #0x78]
       add       x0, x29, #0x78
       str       x0, [x29, #0x18]
       adrp      x11, #0xefc0b61c4000
       add       x11, x11, #0xfe8
       str       x11, [x29, #0x10]
       add       x0, x29, #0x20
       adrp      x1, #0xefc0b61ad000
       add       x1, x1, #0x920
       ldr       x1, [x1]
       blr       x1
       adrp      x0, #0xefc0b61d6000
       add       x0, x0, #0x280
       ldr       x0, [x0]
       ldr       x1, [x0]
       ldp       x11, x0, [x29, #0x10]
       blr       x1
       add       x0, x29, #0x20
       adrp      x1, #0xefc0b61ad000
       add       x1, x1, #0x928
       ldr       x1, [x1]
       blr       x1; CORINFO_HELP_JIT_PINVOKE_END
       ldr       x19, [x29, #0x78]
       adrp      x11, #0xefc0b61af000
       add       x11, x11, #0x5c8
       ldr       x16, [x11]
       blr       x16
       add       x14, x0, #0x10
       ldr       x15, [x29, #0x78]
       adrp      x12, #0xefc0b61ad000
       add       x12, x12, #0x8d8
       ldr       x12, [x12]
       blr       x12; CORINFO_HELP_ASSIGN_REF
       mov       x0, x19
       ldp       x27, x28, [sp, #0xc0]
       ldp       x25, x26, [sp, #0xb0]
       ldp       x23, x24, [sp, #0xa0]
       ldp       x21, x22, [sp, #0x90]
       ldp       x19, x20, [sp, #0x80]
       ldp       x29, x30, [sp], #0xd0
       ret       
; Total bytes of code 192
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.ContendedFirstCallBenchmarks.AsyncLazy()
       stp       x29, x30, [sp, #-0x60]!
       stp       x19, x20, [sp, #0x10]
       stp       x21, x22, [sp, #0x20]
       stp       x23, x24, [sp, #0x30]
       stp       x25, x26, [sp, #0x40]
       stp       x27, x28, [sp, #0x50]
       mov       x29, sp
       mov       x19, x0
       movz      x0, #0xd510
       movk      x0, #0x8ad3, lsl #16
       movk      x0, #0xe19f, lsl #32
       bl        #0xe19f8a1d24c0
       mov       x20, x0
       movz      x0, #0xdf60
       movk      x0, #0x8ad3, lsl #16
       movk      x0, #0xe19f, lsl #32
       bl        #0xe19f8a1d24c0
       movz      x21, #0x1350
       movk      x21, #0xd100, lsl #16
       movk      x21, #0xe18f, lsl #32
       ldr       x15, [x21]
       add       x14, x0, #0x18
       bl        CORINFO_HELP_ASSIGN_REF
       add       x14, x20, #8
       mov       x15, x0
       bl        CORINFO_HELP_ASSIGN_REF
       mov       w22, wzr
       ldr       x23, [x19, #8]
       ldr       w0, [x23, #8]
       cmp       w0, w22
       b.le      #0xe19f8a2247b8
       ldr       x24, [x20, #0x10]
       cbz       x24, #0xe19f8a224568
       ldr       x1, [x21, #0x20]
       cbz       x1, #0xe19f8a22493c
       ldrsb     wzr, [x1]
       ldr       x25, [x21, #0x30]
       movz      x0, #0x28
       movk      x0, #0x8ad5, lsl #16
       movk      x0, #0xe19f, lsl #32
       bl        #0xe19f8a1d24c0
       mov       x26, x0
       add       x14, x26, #8
       mov       x15, x24
       bl        CORINFO_HELP_ASSIGN_REF
       str       xzr, [x26, #0x10]
       add       x14, x26, #0x18
       mov       x15, x25
       bl        CORINFO_HELP_ASSIGN_REF
       movz      w0, #0x2008
       add       x24, x26, #0x34
       stlr      w0, [x24]
       movz      x0, #0x22a0
       movk      x0, #0x8a1c, lsl #16
       movk      x0, #0xe19f, lsl #32
       movz      x1, #0xe4f0
       movk      x1, #0x8ad2, lsl #16
       movk      x1, #0xe19f, lsl #32
       ldr       x1, [x1]
       blr       x1; System.Runtime.CompilerServices.StaticsHelpers.GetDynamicGCThreadStaticBase(System.Runtime.CompilerServices.ThreadStaticsInfo*)
       ldr       x0, [x0, #0x10]
       cbnz      x0, M00_L00
       movz      x0, #0x74e0
       movk      x0, #0x8aa8, lsl #16
       movk      x0, #0xe19f, lsl #32
       ldr       x0, [x0]
       blr       x0; System.Threading.Thread.InitializeCurrentThread()
M00_L00:
       ldr       x25, [x0, #8]
       cbnz      x25, #0xe19f8a224974
       ldr       x25, [x21, #0x40]
       cbnz      x25, #0xe19f8a2245a8
; Total bytes of code 284
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       stp       x29, x30, [sp, #-0x10]!
       mov       x29, sp
       add       x1, x0, #0x34
; Total bytes of code 12
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetDynamicGCThreadStaticBase(System.Runtime.CompilerServices.ThreadStaticsInfo*)
       stp       x29, x30, [sp, #-0x20]!
       str       x19, [sp, #0x18]
       mov       x29, sp
       ldr       w19, [x0, #4]
       cmn       w19, #1
       b.eq      M02_L04
       movz      w0, #0x8
       bl        #0xe19f8a1d2510
       sub       x0, x0, #8
       and       w1, w19, #0xffffff
       asr       w2, w1, #0
       asr       w3, w19, #0x18
       cbnz      w3, M02_L01
       ldr       w3, [x0]
       cmp       w3, w1
       b.le      M02_L03
       ldr       x0, [x0, #8]
       ldrsb     wzr, [x0], #0x10
       sub       w2, w2, #2
       ldr       x0, [x0, w2, sxtw #3]
       cbz       x0, M02_L03
M02_L00:
       ldr       x19, [sp, #0x18]
       ldp       x29, x30, [sp], #0x20
       ret       
M02_L01:
       asr       w1, w19, #0x18
       cmp       w1, #2
       b.ne      M02_L02
       add       x0, x0, w2, sxtw
       b         M02_L00
M02_L02:
       ldr       w1, [x0, #4]
       cmp       w1, w2
       b.le      M02_L03
       ldr       x0, [x0, #0x10]
       ldr       x0, [x0, w2, sxtw #3]
       cbz       x0, M02_L03
       ldr       x0, [x0]
       cbz       x0, M02_L03
       b         M02_L00
M02_L03:
       mov       w0, w19
       movz      x1, #0xcbd0
       movk      x1, #0x8a18, lsl #16
       movk      x1, #0xe19f, lsl #32
       ldr       x1, [x1]
       ldr       x19, [sp, #0x18]
       ldp       x29, x30, [sp], #0x20
       br        x1; System.Runtime.CompilerServices.StaticsHelpers.GetGCThreadStaticsByIndexSlow(Int32)
M02_L04:
       ldr       x0, [x0, #0x20]
       movz      x1, #0xe370
       movk      x1, #0x8ad2, lsl #16
       movk      x1, #0xe19f, lsl #32
       ldr       x1, [x1]
       ldr       x19, [sp, #0x18]
       ldp       x29, x30, [sp], #0x20
       br        x1; System.Runtime.CompilerServices.StaticsHelpers.GetGCThreadStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 216
```
```assembly
; System.Threading.Thread.InitializeCurrentThread()
       stp       x29, x30, [sp, #-0xd0]!
       stp       x19, x20, [sp, #0x80]
       stp       x21, x22, [sp, #0x90]
       stp       x23, x24, [sp, #0xa0]
       stp       x25, x26, [sp, #0xb0]
       stp       x27, x28, [sp, #0xc0]
       mov       x29, sp
       str       xzr, [x29, #0x78]
       add       x0, x29, #0x78
       str       x0, [x29, #0x18]
       adrp      x11, #0xe19f89d94000
       add       x11, x11, #0xfe8
       str       x11, [x29, #0x10]
       add       x0, x29, #0x20
       adrp      x1, #0xe19f89d7d000
       add       x1, x1, #0x920
       ldr       x1, [x1]
       blr       x1
       adrp      x0, #0xe19f89da6000
       add       x0, x0, #0x280
       ldr       x0, [x0]
       ldr       x1, [x0]
       ldp       x11, x0, [x29, #0x10]
       blr       x1
       add       x0, x29, #0x20
       adrp      x1, #0xe19f89d7d000
       add       x1, x1, #0x928
       ldr       x1, [x1]
       blr       x1; CORINFO_HELP_JIT_PINVOKE_END
       ldr       x19, [x29, #0x78]
       adrp      x11, #0xe19f89d7f000
       add       x11, x11, #0x5c8
       ldr       x16, [x11]
       blr       x16
       add       x14, x0, #0x10
       ldr       x15, [x29, #0x78]
       adrp      x12, #0xe19f89d7d000
       add       x12, x12, #0x8d8
       ldr       x12, [x12]
       blr       x12; CORINFO_HELP_ASSIGN_REF
       mov       x0, x19
       ldp       x27, x28, [sp, #0xc0]
       ldp       x25, x26, [sp, #0xb0]
       ldp       x23, x24, [sp, #0xa0]
       ldp       x21, x22, [sp, #0x90]
       ldp       x19, x20, [sp, #0x80]
       ldp       x29, x30, [sp], #0xd0
       ret       
; Total bytes of code 192
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.ContendedFirstCallBenchmarks.Nito()
       stp       x29, x30, [sp, #-0x60]!
       stp       x19, x20, [sp, #0x10]
       stp       x21, x22, [sp, #0x20]
       stp       x23, x24, [sp, #0x30]
       stp       x25, x26, [sp, #0x40]
       stp       x27, x28, [sp, #0x50]
       mov       x29, sp
       mov       x19, x0
       movz      x0, #0xd510
       movk      x0, #0xd875, lsl #16
       movk      x0, #0xf062, lsl #32
       bl        #0xf062d7bf24c0
       mov       x20, x0
       movz      x0, #0xe010
       movk      x0, #0xd875, lsl #16
       movk      x0, #0xf062, lsl #32
       bl        #0xf062d7bf24c0
       mov       x21, x0
       movz      x22, #0x1350
       movk      x22, #0x1d00, lsl #16
       movk      x22, #0xf053, lsl #32
       ldr       x23, [x22]
       mov       x15, x23
       add       x14, x21, #0x10
       bl        CORINFO_HELP_ASSIGN_REF
       movz      x0, #0xdb8
       movk      x0, #0xd877, lsl #16
       movk      x0, #0xf062, lsl #32
       bl        #0xf062d7bf24c0
       mov       x24, x0
       add       x14, x24, #8
       mov       x15, x23
       bl        CORINFO_HELP_ASSIGN_REF
       movz      x0, #0xd5a0
       movk      x0, #0xd875, lsl #16
       movk      x0, #0xf062, lsl #32
       bl        #0xf062d7bf24c0
       add       x14, x0, #8
       mov       x15, x24
       bl        CORINFO_HELP_ASSIGN_REF
       movz      x14, #0x18f0
       movk      x14, #0xd874, lsl #16
       movk      x14, #0xf062, lsl #32
       str       x14, [x0, #0x18]
       add       x14, x21, #0x10
       mov       x15, x0
       bl        CORINFO_HELP_ASSIGN_REF
       movz      x0, #0x47b0
       movk      x0, #0xd6a4, lsl #16
       movk      x0, #0xf062, lsl #32
       bl        #0xf062d7bf24c0
       mov       x15, x0
       add       x14, x21, #8
       bl        CORINFO_HELP_ASSIGN_REF
       movz      x0, #0x18
       movk      x0, #0xd877, lsl #16
       movk      x0, #0xf062, lsl #32
       bl        #0xf062d7bf24c0
       mov       x23, x0
       ldr       x15, [x21, #0x10]
       add       x14, x23, #0x10
       bl        CORINFO_HELP_ASSIGN_REF
       movz      x0, #0xf1e8
       movk      x0, #0xd85d, lsl #16
       movk      x0, #0xf062, lsl #32
       bl        #0xf062d7bf24c0
       movz      w14, #0x8
       str       w14, [x0, #0x10]
       add       x14, x23, #8
       mov       x15, x0
       bl        CORINFO_HELP_ASSIGN_REF
       add       x14, x21, #0x18
       mov       x15, x23
       bl        CORINFO_HELP_ASSIGN_REF
       add       x14, x20, #8
       mov       x15, x21
       bl        CORINFO_HELP_ASSIGN_REF
       mov       w21, wzr
       ldr       x23, [x19, #8]
       ldr       w0, [x23, #8]
       cmp       w0, w21
       b.le      #0xf062d7c40054
       ldr       x24, [x20, #0x10]
       cbz       x24, #0xf062d7c3fdf4
       ldr       x1, [x22, #0x20]
       cbz       x1, #0xf062d7c401d0
       ldrsb     wzr, [x1]
       ldr       x25, [x22, #0x30]
       movz      x0, #0x1130
       movk      x0, #0xd877, lsl #16
       movk      x0, #0xf062, lsl #32
       bl        #0xf062d7bf24c0
       mov       x26, x0
       add       x14, x26, #8
       mov       x15, x24
       bl        CORINFO_HELP_ASSIGN_REF
       str       xzr, [x26, #0x10]
       add       x14, x26, #0x18
       mov       x15, x25
       bl        CORINFO_HELP_ASSIGN_REF
       movz      w0, #0x2008
       add       x24, x26, #0x34
       stlr      w0, [x24]
       movz      x0, #0x22a0
       movk      x0, #0xd7be, lsl #16
       movk      x0, #0xf062, lsl #32
       movz      x1, #0xe220
       movk      x1, #0xd874, lsl #16
       movk      x1, #0xf062, lsl #32
       ldr       x1, [x1]
       blr       x1; System.Runtime.CompilerServices.StaticsHelpers.GetDynamicGCThreadStaticBase(System.Runtime.CompilerServices.ThreadStaticsInfo*)
       ldr       x0, [x0, #0x10]
       cbnz      x0, M00_L00
       movz      x0, #0x74e0
       movk      x0, #0xd84a, lsl #16
       movk      x0, #0xf062, lsl #32
       ldr       x0, [x0]
       blr       x0; System.Threading.Thread.InitializeCurrentThread()
M00_L00:
       ldr       x25, [x0, #8]
       cbnz      x25, #0xf062d7c3fe34
       ldr       x25, [x22, #0x40]
       cbnz      x25, #0xf062d7c3fe44
; Total bytes of code 488
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       stp       x29, x30, [sp, #-0x10]!
       mov       x29, sp
       add       x1, x0, #0x34
; Total bytes of code 12
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetDynamicGCThreadStaticBase(System.Runtime.CompilerServices.ThreadStaticsInfo*)
       stp       x29, x30, [sp, #-0x20]!
       str       x19, [sp, #0x18]
       mov       x29, sp
       ldr       w19, [x0, #4]
       cmn       w19, #1
       b.eq      M02_L04
       movz      w0, #0x8
       bl        #0xf062d7bf2510
       sub       x0, x0, #8
       and       w1, w19, #0xffffff
       asr       w2, w1, #0
       asr       w3, w19, #0x18
       cbnz      w3, M02_L01
       ldr       w3, [x0]
       cmp       w3, w1
       b.le      M02_L03
       ldr       x0, [x0, #8]
       ldrsb     wzr, [x0], #0x10
       sub       w2, w2, #2
       ldr       x0, [x0, w2, sxtw #3]
       cbz       x0, M02_L03
M02_L00:
       ldr       x19, [sp, #0x18]
       ldp       x29, x30, [sp], #0x20
       ret       
M02_L01:
       asr       w1, w19, #0x18
       cmp       w1, #2
       b.ne      M02_L02
       add       x0, x0, w2, sxtw
       b         M02_L00
M02_L02:
       ldr       w1, [x0, #4]
       cmp       w1, w2
       b.le      M02_L03
       ldr       x0, [x0, #0x10]
       ldr       x0, [x0, w2, sxtw #3]
       cbz       x0, M02_L03
       ldr       x0, [x0]
       cbz       x0, M02_L03
       b         M02_L00
M02_L03:
       mov       w0, w19
       movz      x1, #0xcbd0
       movk      x1, #0xd7ba, lsl #16
       movk      x1, #0xf062, lsl #32
       ldr       x1, [x1]
       ldr       x19, [sp, #0x18]
       ldp       x29, x30, [sp], #0x20
       br        x1; System.Runtime.CompilerServices.StaticsHelpers.GetGCThreadStaticsByIndexSlow(Int32)
M02_L04:
       ldr       x0, [x0, #0x20]
       movz      x1, #0xdbf0
       movk      x1, #0xd874, lsl #16
       movk      x1, #0xf062, lsl #32
       ldr       x1, [x1]
       ldr       x19, [sp, #0x18]
       ldp       x29, x30, [sp], #0x20
       br        x1; System.Runtime.CompilerServices.StaticsHelpers.GetGCThreadStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 216
```
```assembly
; System.Threading.Thread.InitializeCurrentThread()
       stp       x29, x30, [sp, #-0xd0]!
       stp       x19, x20, [sp, #0x80]
       stp       x21, x22, [sp, #0x90]
       stp       x23, x24, [sp, #0xa0]
       stp       x25, x26, [sp, #0xb0]
       stp       x27, x28, [sp, #0xc0]
       mov       x29, sp
       str       xzr, [x29, #0x78]
       add       x0, x29, #0x78
       str       x0, [x29, #0x18]
       adrp      x11, #0xf062d77b4000
       add       x11, x11, #0xfe8
       str       x11, [x29, #0x10]
       add       x0, x29, #0x20
       adrp      x1, #0xf062d779d000
       add       x1, x1, #0x920
       ldr       x1, [x1]
       blr       x1
       adrp      x0, #0xf062d77c6000
       add       x0, x0, #0x280
       ldr       x0, [x0]
       ldr       x1, [x0]
       ldp       x11, x0, [x29, #0x10]
       blr       x1
       add       x0, x29, #0x20
       adrp      x1, #0xf062d779d000
       add       x1, x1, #0x928
       ldr       x1, [x1]
       blr       x1; CORINFO_HELP_JIT_PINVOKE_END
       ldr       x19, [x29, #0x78]
       adrp      x11, #0xf062d779f000
       add       x11, x11, #0x5c8
       ldr       x16, [x11]
       blr       x16
       add       x14, x0, #0x10
       ldr       x15, [x29, #0x78]
       adrp      x12, #0xf062d779d000
       add       x12, x12, #0x8d8
       ldr       x12, [x12]
       blr       x12; CORINFO_HELP_ASSIGN_REF
       mov       x0, x19
       ldp       x27, x28, [sp, #0xc0]
       ldp       x25, x26, [sp, #0xb0]
       ldp       x23, x24, [sp, #0xa0]
       ldp       x21, x22, [sp, #0x90]
       ldp       x19, x20, [sp, #0x80]
       ldp       x29, x30, [sp], #0xd0
       ret       
; Total bytes of code 192
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), Arm64 RyuJIT armv8.0-a (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.ContendedFirstCallBenchmarks.VsThreading()
       stp       x29, x30, [sp, #-0x60]!
       stp       x19, x20, [sp, #0x10]
       stp       x21, x22, [sp, #0x20]
       stp       x23, x24, [sp, #0x30]
       stp       x25, x26, [sp, #0x40]
       stp       x27, x28, [sp, #0x50]
       mov       x29, sp
       mov       x19, x0
       movz      x0, #0xd510
       movk      x0, #0x6ed3, lsl #16
       movk      x0, #0xef33, lsl #32
       bl        #0xef336e1d24c0
       mov       x20, x0
       movz      x0, #0xe220
       movk      x0, #0x6ed3, lsl #16
       movk      x0, #0xef33, lsl #32
       bl        #0xef336e1d24c0
       mov       x21, x0
       movz      x22, #0x1350
       movk      x22, #0xb500, lsl #16
       movk      x22, #0xef23, lsl #32
       ldr       x23, [x22]
       movz      x0, #0x47b0
       movk      x0, #0x6d02, lsl #16
       movk      x0, #0xef33, lsl #32
       bl        #0xef336e1d24c0
       mov       x15, x0
       add       x14, x21, #8
       bl        CORINFO_HELP_ASSIGN_REF
       add       x14, x21, #0x20
       mov       x15, x23
       bl        CORINFO_HELP_ASSIGN_REF
       str       xzr, [x21, #0x10]
       add       x14, x20, #8
       mov       x15, x21
       bl        CORINFO_HELP_ASSIGN_REF
       mov       w21, wzr
       ldr       x23, [x19, #8]
       ldr       w0, [x23, #8]
       cmp       w0, w21
       b.le      #0xef336e228858
       ldr       x24, [x20, #0x10]
       cbz       x24, #0xef336e228670
       ldr       x1, [x22, #0x30]
       cbz       x1, #0xef336e2289d4
       ldrsb     wzr, [x1]
       ldr       x25, [x22, #0x40]
       movz      x0, #0x1ee0
       movk      x0, #0x6ed7, lsl #16
       movk      x0, #0xef33, lsl #32
       bl        #0xef336e1d24c0
       mov       x26, x0
       add       x14, x26, #8
       mov       x15, x24
       bl        CORINFO_HELP_ASSIGN_REF
       str       xzr, [x26, #0x10]
       add       x14, x26, #0x18
       mov       x15, x25
       bl        CORINFO_HELP_ASSIGN_REF
       movz      w0, #0x2008
       add       x24, x26, #0x34
       stlr      w0, [x24]
       movz      x0, #0x22a0
       movk      x0, #0x6e1c, lsl #16
       movk      x0, #0xef33, lsl #32
       movz      x1, #0x40d8
       movk      x1, #0x6ee0, lsl #16
       movk      x1, #0xef33, lsl #32
       ldr       x1, [x1]
       blr       x1; System.Runtime.CompilerServices.StaticsHelpers.GetDynamicGCThreadStaticBase(System.Runtime.CompilerServices.ThreadStaticsInfo*)
       ldr       x0, [x0, #0x10]
       cbnz      x0, M00_L00
       movz      x0, #0x74e0
       movk      x0, #0x6ea8, lsl #16
       movk      x0, #0xef33, lsl #32
       ldr       x0, [x0]
       blr       x0; System.Threading.Thread.InitializeCurrentThread()
M00_L00:
       ldr       x25, [x0, #8]
       cbnz      x25, #0xef336e2286b0
       ldr       x25, [x22, #0x50]
       cbnz      x25, #0xef336e2286bc
; Total bytes of code 324
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       stp       x29, x30, [sp, #-0x10]!
       mov       x29, sp
       add       x1, x0, #0x34
; Total bytes of code 12
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetDynamicGCThreadStaticBase(System.Runtime.CompilerServices.ThreadStaticsInfo*)
       stp       x29, x30, [sp, #-0x20]!
       str       x19, [sp, #0x18]
       mov       x29, sp
       ldr       w19, [x0, #4]
       cmn       w19, #1
       b.eq      M02_L04
       movz      w0, #0x8
       bl        #0xef336e1d2510
       sub       x0, x0, #8
       and       w1, w19, #0xffffff
       asr       w2, w1, #0
       asr       w3, w19, #0x18
       cbnz      w3, M02_L01
       ldr       w3, [x0]
       cmp       w3, w1
       b.le      M02_L03
       ldr       x0, [x0, #8]
       ldrsb     wzr, [x0], #0x10
       sub       w2, w2, #2
       ldr       x0, [x0, w2, sxtw #3]
       cbz       x0, M02_L03
M02_L00:
       ldr       x19, [sp, #0x18]
       ldp       x29, x30, [sp], #0x20
       ret       
M02_L01:
       asr       w1, w19, #0x18
       cmp       w1, #2
       b.ne      M02_L02
       add       x0, x0, w2, sxtw
       b         M02_L00
M02_L02:
       ldr       w1, [x0, #4]
       cmp       w1, w2
       b.le      M02_L03
       ldr       x0, [x0, #0x10]
       ldr       x0, [x0, w2, sxtw #3]
       cbz       x0, M02_L03
       ldr       x0, [x0]
       cbz       x0, M02_L03
       b         M02_L00
M02_L03:
       mov       w0, w19
       movz      x1, #0xcbd0
       movk      x1, #0x6e18, lsl #16
       movk      x1, #0xef33, lsl #32
       ldr       x1, [x1]
       ldr       x19, [sp, #0x18]
       ldp       x29, x30, [sp], #0x20
       br        x1; System.Runtime.CompilerServices.StaticsHelpers.GetGCThreadStaticsByIndexSlow(Int32)
M02_L04:
       ldr       x0, [x0, #0x20]
       movz      x1, #0xfa38
       movk      x1, #0x6ed2, lsl #16
       movk      x1, #0xef33, lsl #32
       ldr       x1, [x1]
       ldr       x19, [sp, #0x18]
       ldp       x29, x30, [sp], #0x20
       br        x1; System.Runtime.CompilerServices.StaticsHelpers.GetGCThreadStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 216
```
```assembly
; System.Threading.Thread.InitializeCurrentThread()
       stp       x29, x30, [sp, #-0xd0]!
       stp       x19, x20, [sp, #0x80]
       stp       x21, x22, [sp, #0x90]
       stp       x23, x24, [sp, #0xa0]
       stp       x25, x26, [sp, #0xb0]
       stp       x27, x28, [sp, #0xc0]
       mov       x29, sp
       str       xzr, [x29, #0x78]
       add       x0, x29, #0x78
       str       x0, [x29, #0x18]
       adrp      x11, #0xef336dd94000
       add       x11, x11, #0xfe8
       str       x11, [x29, #0x10]
       add       x0, x29, #0x20
       adrp      x1, #0xef336dd7d000
       add       x1, x1, #0x920
       ldr       x1, [x1]
       blr       x1
       adrp      x0, #0xef336dda6000
       add       x0, x0, #0x280
       ldr       x0, [x0]
       ldr       x1, [x0]
       ldp       x11, x0, [x29, #0x10]
       blr       x1
       add       x0, x29, #0x20
       adrp      x1, #0xef336dd7d000
       add       x1, x1, #0x928
       ldr       x1, [x1]
       blr       x1; CORINFO_HELP_JIT_PINVOKE_END
       ldr       x19, [x29, #0x78]
       adrp      x11, #0xef336dd7f000
       add       x11, x11, #0x5c8
       ldr       x16, [x11]
       blr       x16
       add       x14, x0, #0x10
       ldr       x15, [x29, #0x78]
       adrp      x12, #0xef336dd7d000
       add       x12, x12, #0x8d8
       ldr       x12, [x12]
       blr       x12; CORINFO_HELP_ASSIGN_REF
       mov       x0, x19
       ldp       x27, x28, [sp, #0xc0]
       ldp       x25, x26, [sp, #0xb0]
       ldp       x23, x24, [sp, #0xa0]
       ldp       x21, x22, [sp, #0x90]
       ldp       x19, x20, [sp, #0x80]
       ldp       x29, x30, [sp], #0xd0
       ret       
; Total bytes of code 192
```

