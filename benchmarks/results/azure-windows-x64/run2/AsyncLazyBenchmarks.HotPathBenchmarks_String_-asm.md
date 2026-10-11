## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.HotPathBenchmarks`1[[System.__Canon, System.Private.CoreLib]].LazyOfTask()
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+8],0
       jne       short M00_L00
       mov       rax,[rcx+18]
       ret
M00_L00:
       jmp       qword ptr [7FF80D0B5860]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
; Total bytes of code 22
```
```assembly
; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
M01_L00:
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M01_L01
       mov       ecx,[rsi+10]
       cmp       ecx,8
       jne       short M01_L03
       mov       rcx,rbx
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF85062E1B0]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
M01_L01:
       cmp       qword ptr [rbx+8],0
       jne       short M01_L02
       mov       rax,[rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L02:
       mov       rcx,rbx
       lea       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax]
M01_L03:
       cmp       ecx,8
       ja        short M01_L04
       mov       ecx,ecx
       lea       rdx,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       edx,[rdx+rcx*4]
       lea       r8,[M01_L00]
       add       rdx,r8
       jmp       rdx
M01_L04:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF850624C78]
       int       3
       mov       rcx,rbx
       call      qword ptr [7FF85062E1A0]
       jmp       short M01_L01
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF85062E1A8]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M01_L01
       mov       rcx,[rbx]
       call      qword ptr [7FF85060B838]
       mov       rcx,rax
       call      qword ptr [7FF850612EA0]
       mov       rcx,rax
       call      qword ptr [7FF850634008]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF85062E1B8]
       jmp       near ptr M01_L01
       mov       rax,[rbx+10]
       test      rax,rax
       je        short M01_L05
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF85062E1B8]
       jmp       near ptr M01_L01
M01_L05:
       mov       rcx,rbx
       call      qword ptr [7FF85062E1C8]
       jmp       near ptr M01_L01
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,1
       call      qword ptr [7FF85062E1B0]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M01_L01
; Total bytes of code 269
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.HotPathBenchmarks`1[[System.__Canon, System.Private.CoreLib]].AsyncLazy()
       mov       rcx,[rcx+18]
       mov       rax,[rcx+10]
       test      rax,rax
       je        short M00_L00
       ret
M00_L00:
       xor       edx,edx
       jmp       qword ptr [7FF80D164D80]; System.Threading.Tasks.AsyncLazy`1[[System.__Canon, System.Private.CoreLib]].GetOrStartAttemptAsync(System.Threading.CancellationToken)
; Total bytes of code 22
```
```assembly
; System.Threading.Tasks.AsyncLazy`1[[System.__Canon, System.Private.CoreLib]].GetOrStartAttemptAsync(System.Threading.CancellationToken)
       push      rbp
       sub       rsp,1C0
       lea       rbp,[rsp+1C0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu32 [rbp-0F0],zmm4
       vmovdqu32 [rbp-0B0],zmm4
       vmovdqu32 [rbp-80],zmm4
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       dword ptr [rbp-0E0],3E8
M01_L00:
       mov       eax,[rbp-0E0]
       dec       eax
       mov       [rbp-0E0],eax
       cmp       dword ptr [rbp-0E0],0
       jg        short M01_L01
       lea       rcx,[rbp-0E0]
       xor       edx,edx
       call      CORINFO_HELP_PATCHPOINT
M01_L01:
       mov       rax,[rbp+10]
       mov       rax,[rax+8]
       mov       [rbp-48],rax
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       [rbp-0F8],rax
       mov       rax,[rbp-0F8]
       mov       rax,[rax+30]
       mov       rax,[rax]
       mov       rax,[rax+18]
       mov       [rbp-100],rax
       cmp       qword ptr [rbp-100],0
       je        short M01_L02
       mov       rax,[rbp-100]
       mov       [rbp-68],rax
       jmp       short M01_L03
M01_L02:
       mov       rcx,[rbp-0F8]
       mov       rdx,7FF80D18A568
       call      qword ptr [7FF80CDEF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-68],rax
M01_L03:
       mov       rcx,[rbp-68]
       mov       rdx,[rbp-48]
       call      qword ptr [7FF80CDE6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       [rbp-50],rax
       cmp       qword ptr [rbp-50],0
       je        short M01_L04
       mov       rcx,7FF80D15FC40
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-50]
       mov       [rbp-0E8],rax
       jmp       near ptr M01_L28
M01_L04:
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       [rbp-108],rax
       mov       rax,[rbp-108]
       mov       rax,[rax+30]
       mov       rax,[rax]
       mov       rax,[rax+20]
       mov       [rbp-110],rax
       cmp       qword ptr [rbp-110],0
       je        short M01_L05
       mov       rax,[rbp-110]
       mov       [rbp-70],rax
       jmp       short M01_L06
M01_L05:
       mov       rcx,[rbp-108]
       mov       rdx,7FF80D18A578
       call      qword ptr [7FF80CDEF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-70],rax
M01_L06:
       mov       rcx,[rbp-70]
       mov       rdx,[rbp-48]
       call      qword ptr [7FF80CDE6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       [rbp-58],rax
       cmp       qword ptr [rbp-58],0
       je        near ptr M01_L10
       mov       rcx,[rbp-58]
       call      qword ptr [7FF80D164E58]
       test      eax,eax
       je        near ptr M01_L09
       mov       rcx,7FF80D15FC44
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0D0],rax
       mov       rcx,[rbp-0D0]
       mov       rdx,186A5396410
       call      qword ptr [7FF80D0C7D50]
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       [rbp-118],rax
       mov       rax,[rbp-118]
       mov       rax,[rax+30]
       mov       rax,[rax]
       mov       [rbp-120],rax
       mov       rax,[rbp-120]
       cmp       qword ptr [rax+8],40
       jle       short M01_L07
       mov       rax,[rbp-120]
       mov       rax,[rax+40]
       mov       [rbp-128],rax
       cmp       qword ptr [rbp-128],0
       je        short M01_L07
       mov       rax,[rbp-128]
       mov       [rbp-0D8],rax
       jmp       short M01_L08
M01_L07:
       mov       rcx,[rbp-118]
       mov       rdx,7FF80D18CFF8
       call      qword ptr [7FF80CDEF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-0D8],rax
M01_L08:
       mov       rcx,[rbp-0D8]
       mov       rdx,[rbp-0D0]
       call      qword ptr [7FF80D164DF8]; System.Threading.Tasks.Task.FromException[[System.__Canon, System.Private.CoreLib]](System.Exception)
       mov       [rbp-0E8],rax
       jmp       near ptr M01_L28
M01_L09:
       mov       rcx,7FF80D15FC48
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp-58]
       mov       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF80D164E70]; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.__Canon, System.Private.CoreLib]].WaitAsync(System.Threading.CancellationToken)
       mov       [rbp-0E8],rax
       jmp       near ptr M01_L28
M01_L10:
       mov       rax,[rbp+10]
       cmp       [rax],al
       mov       rax,[rbp+10]
       lea       rcx,[rax+20]
       call      qword ptr [7FF80D164D68]; System.Threading.CancellationToken.get_IsCancellationRequested()
       test      eax,eax
       je        near ptr M01_L13
       mov       rcx,7FF80D15FC4C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       [rbp-130],rax
       mov       rax,[rbp-130]
       mov       rax,[rax+30]
       mov       rax,[rax]
       mov       rax,[rax+10]
       mov       [rbp-138],rax
       cmp       qword ptr [rbp-138],0
       je        short M01_L11
       mov       rax,[rbp-138]
       mov       [rbp-0C8],rax
       jmp       short M01_L12
M01_L11:
       mov       rcx,[rbp-130]
       mov       rdx,7FF80D18A348
       call      qword ptr [7FF80CDEF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-0C8],rax
M01_L12:
       mov       rax,[rbp+10]
       mov       rdx,[rax+20]
       mov       rcx,[rbp-0C8]
       call      qword ptr [7FF80D164D20]
       mov       [rbp-0E8],rax
       jmp       near ptr M01_L28
M01_L13:
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       [rbp-140],rax
       mov       rax,[rbp-140]
       mov       rax,[rax+30]
       mov       rax,[rax]
       mov       rax,[rax+20]
       mov       [rbp-148],rax
       cmp       qword ptr [rbp-148],0
       je        short M01_L14
       mov       rax,[rbp-148]
       mov       [rbp-80],rax
       jmp       short M01_L15
M01_L14:
       mov       rcx,[rbp-140]
       mov       rdx,7FF80D18A578
       call      qword ptr [7FF80CDEF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-80],rax
M01_L15:
       mov       rcx,[rbp-80]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-78],rax
       mov       rcx,[rbp-78]
       mov       rdx,[rbp+10]
       call      qword ptr [7FF80D164E88]; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.__Canon, System.Private.CoreLib]]..ctor(System.Threading.Tasks.AsyncLazy`1<System.__Canon>)
       mov       rax,[rbp-78]
       mov       [rbp-60],rax
       mov       rax,[rbp+10]
       cmp       [rax],al
       mov       rax,[rbp+10]
       lea       rcx,[rax+8]
       mov       rdx,[rbp-60]
       xor       r8d,r8d
       call      qword ptr [7FF80D164EA0]; System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       jne       near ptr M01_L27
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       [rbp-150],rax
       mov       rax,[rbp-150]
       mov       rax,[rax+30]
       mov       rax,[rax]
       mov       rax,[rax+28]
       mov       [rbp-158],rax
       cmp       qword ptr [rbp-158],0
       je        short M01_L16
       mov       rax,[rbp-158]
       mov       [rbp-88],rax
       jmp       short M01_L17
M01_L16:
       mov       rcx,[rbp-150]
       mov       rdx,7FF80D18A8D0
       call      qword ptr [7FF80CDEF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-88],rax
M01_L17:
       mov       rcx,[rbp-88]
       call      qword ptr [7FF80CDE5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rax+8]
       mov       [rbp-90],rax
       mov       rax,[rbp-90]
       mov       [rbp-98],rax
       cmp       qword ptr [rbp-90],0
       jne       near ptr M01_L24
       mov       rcx,7FF80D15FC50
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       [rbp-160],rax
       mov       rax,[rbp-160]
       mov       rax,[rax+30]
       mov       rax,[rax]
       mov       rax,[rax+28]
       mov       [rbp-168],rax
       cmp       qword ptr [rbp-168],0
       je        short M01_L18
       mov       rax,[rbp-168]
       mov       [rbp-0A8],rax
       jmp       short M01_L19
M01_L18:
       mov       rcx,[rbp-160]
       mov       rdx,7FF80D18A8D0
       call      qword ptr [7FF80CDEF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-0A8],rax
M01_L19:
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       [rbp-170],rax
       mov       rax,[rbp-170]
       mov       rax,[rax+30]
       mov       rax,[rax]
       mov       [rbp-178],rax
       mov       rax,[rbp-178]
       cmp       qword ptr [rax+8],38
       jle       short M01_L20
       mov       rax,[rbp-178]
       mov       rax,[rax+38]
       mov       [rbp-180],rax
       cmp       qword ptr [rbp-180],0
       je        short M01_L20
       mov       rax,[rbp-180]
       mov       [rbp-0B8],rax
       jmp       short M01_L21
M01_L20:
       mov       rcx,[rbp-170]
       mov       rdx,7FF80D18CEF0
       call      qword ptr [7FF80CDEF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-0B8],rax
M01_L21:
       mov       rcx,[rbp-0B8]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0B0],rax
       mov       rcx,[rbp-0A8]
       call      qword ptr [7FF80CDE5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rax]
       mov       [rbp-0F0],rax
       mov       rdx,[rbp-0F0]
       mov       rcx,[rbp-0B0]
       mov       r8,offset System.Threading.Tasks.AsyncLazy`1+<>c[[System.__Canon, System.Private.CoreLib]].<GetOrStartAttemptAsync>b__11_0(Attempt<System.__Canon>)
       call      qword ptr [7FF80CDE6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       [rbp-188],rax
       mov       rax,[rbp-188]
       mov       rax,[rax+30]
       mov       rax,[rax]
       mov       rax,[rax+28]
       mov       [rbp-190],rax
       cmp       qword ptr [rbp-190],0
       je        short M01_L22
       mov       rax,[rbp-190]
       mov       [rbp-0C0],rax
       jmp       short M01_L23
M01_L22:
       mov       rcx,[rbp-188]
       mov       rdx,7FF80D18A8D0
       call      qword ptr [7FF80CDEF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-0C0],rax
M01_L23:
       mov       rcx,[rbp-0C0]
       call      qword ptr [7FF80CDE5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       lea       rcx,[rax+8]
       mov       rdx,[rbp-0B0]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-0B0]
       mov       [rbp-98],rax
M01_L24:
       mov       rcx,7FF80D15FC54
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       [rbp-198],rax
       mov       rax,[rbp-198]
       mov       rax,[rax+30]
       mov       rax,[rax]
       mov       rax,[rax+30]
       mov       [rbp-1A0],rax
       cmp       qword ptr [rbp-1A0],0
       je        short M01_L25
       mov       rax,[rbp-1A0]
       mov       [rbp-0A0],rax
       jmp       short M01_L26
M01_L25:
       mov       rcx,[rbp-198]
       mov       rdx,7FF80D18CE08
       call      qword ptr [7FF80CDEF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-0A0],rax
M01_L26:
       mov       rcx,[rbp-0A0]
       mov       rdx,[rbp-98]
       mov       r8,[rbp-60]
       xor       r9d,r9d
       call      qword ptr [7FF80D164DB0]; System.Threading.ThreadPool.QueueUserWorkItem[[System.__Canon, System.Private.CoreLib]](System.Action`1<System.__Canon>, System.__Canon, Boolean)
       mov       rcx,[rbp-60]
       mov       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF80D164E70]; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.__Canon, System.Private.CoreLib]].WaitAsync(System.Threading.CancellationToken)
       mov       [rbp-0E8],rax
       jmp       short M01_L28
M01_L27:
       mov       rcx,7FF80D15FC58
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M01_L00
M01_L28:
       mov       rax,[rbp-0E8]
       add       rsp,1C0
       pop       rbp
       ret
; Total bytes of code 1776
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.HotPathBenchmarks`1[[System.__Canon, System.Private.CoreLib]].Nito()
       push      rbp
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+40]
       mov       rbx,[rcx+20]
       mov       rcx,[rbx+8]
       mov       [rbp-18],rcx
       xor       eax,eax
       mov       [rbp-0C],eax
       test      rcx,rcx
       je        short M00_L01
       call      00007FF86CA5E120
       test      eax,eax
       je        short M00_L02
M00_L00:
       mov       dword ptr [rbp-0C],1
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],0
       jne       short M00_L03
       mov       rbx,[rcx+18]
       jmp       short M00_L04
M00_L01:
       xor       ecx,ecx
       call      qword ptr [7FF80D21DFE0]
       int       3
M00_L02:
       mov       rcx,[rbp-18]
       call      qword ptr [7FF80D21E028]
       jmp       short M00_L00
M00_L03:
       call      qword ptr [7FF80D0C5860]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rbx,rax
M00_L04:
       mov       rcx,[rbp-18]
       call      00007FF86CA5E040
       test      eax,eax
       jne       short M00_L06
M00_L05:
       mov       rax,rbx
       add       rsp,38
       pop       rbx
       pop       rbp
       ret
M00_L06:
       mov       ecx,eax
       mov       rdx,[rbp-18]
       call      qword ptr [7FF80D21DFF8]
       jmp       short M00_L05
       sub       rsp,28
       cmp       dword ptr [rbp-0C],0
       je        short M00_L08
       cmp       qword ptr [rbp-18],0
       jne       short M00_L07
       xor       ecx,ecx
       call      qword ptr [7FF80D21DFE0]
       int       3
M00_L07:
       mov       rcx,[rbp-18]
       call      00007FF86CA5E040
       test      eax,eax
       je        short M00_L08
       mov       ecx,eax
       mov       rdx,[rbp-18]
       call      qword ptr [7FF80D21DFF8]
M00_L08:
       nop
       add       rsp,28
       ret
; Total bytes of code 190
```
```assembly
; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
M01_L00:
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M01_L01
       mov       ecx,[rsi+10]
       cmp       ecx,8
       jne       short M01_L03
       mov       rcx,rbx
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF85062E1B0]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
M01_L01:
       cmp       qword ptr [rbx+8],0
       jne       short M01_L02
       mov       rax,[rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L02:
       mov       rcx,rbx
       lea       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax]
M01_L03:
       cmp       ecx,8
       ja        short M01_L04
       mov       ecx,ecx
       lea       rdx,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       edx,[rdx+rcx*4]
       lea       r8,[M01_L00]
       add       rdx,r8
       jmp       rdx
M01_L04:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF850624C78]
       int       3
       mov       rcx,rbx
       call      qword ptr [7FF85062E1A0]
       jmp       short M01_L01
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF85062E1A8]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M01_L01
       mov       rcx,[rbx]
       call      qword ptr [7FF85060B838]
       mov       rcx,rax
       call      qword ptr [7FF850612EA0]
       mov       rcx,rax
       call      qword ptr [7FF850634008]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF85062E1B8]
       jmp       near ptr M01_L01
       mov       rax,[rbx+10]
       test      rax,rax
       je        short M01_L05
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF85062E1B8]
       jmp       near ptr M01_L01
M01_L05:
       mov       rcx,rbx
       call      qword ptr [7FF85062E1C8]
       jmp       near ptr M01_L01
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,1
       call      qword ptr [7FF85062E1B0]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M01_L01
; Total bytes of code 269
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.HotPathBenchmarks`1[[System.__Canon, System.Private.CoreLib]].VsThreading()
       mov       rcx,[rcx+28]
       cmp       [rcx],cl
       xor       edx,edx
       jmp       qword ptr [7FF80D145DE8]; Microsoft.VisualStudio.Threading.AsyncLazy`1[[System.__Canon, System.Private.CoreLib]].GetValueAsync(System.Threading.CancellationToken)
; Total bytes of code 14
```
```assembly
; Microsoft.VisualStudio.Threading.AsyncLazy`1[[System.__Canon, System.Private.CoreLib]].GetValueAsync(System.Threading.CancellationToken)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-30],rax
       mov       [rbp-38],rax
       mov       [rbp-28],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       rbx,[rcx]
       mov       rdx,rbx
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M01_L07
M01_L00:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp+10]
       mov       rcx,[rdx+28]
       test      rcx,rcx
       je        near ptr M01_L08
       test      dword ptr [rcx+34],1600000
       je        near ptr M01_L08
M01_L01:
       mov       rdx,[rbp+10]
       cmp       qword ptr [rdx+28],0
       je        near ptr M01_L11
M01_L02:
       mov       rdx,[rbp+10]
       lock or   dword ptr [rsp],0
       mov       rcx,[rdx+30]
       test      rcx,rcx
       jne       near ptr M01_L32
       xor       eax,eax
M01_L03:
       test      rax,rax
       jne       short M01_L06
       mov       rcx,[rbx+30]
       mov       rcx,[rcx]
       mov       rsi,[rcx+20]
       test      rsi,rsi
       je        short M01_L09
M01_L04:
       mov       rdx,[rbp+10]
       mov       rbx,[rdx+28]
       mov       rcx,[rbp+18]
       mov       [rbp-38],rcx
       test      rbx,rbx
       je        near ptr M01_L33
       cmp       qword ptr [rbp-38],0
       jne       near ptr M01_L34
M01_L05:
       mov       rax,rbx
M01_L06:
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L07:
       mov       rcx,rdx
       mov       rdx,7FF80D182280
       call      qword ptr [7FF80CDCF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M01_L00
M01_L08:
       mov       rcx,[rdx+18]
       test      rcx,rcx
       je        near ptr M01_L01
       jmp       short M01_L10
M01_L09:
       mov       rcx,rbx
       mov       rdx,7FF80D182D00
       call      qword ptr [7FF80CDCF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       short M01_L04
M01_L10:
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF80D146D30]; System.Threading.AsyncLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       test      rax,rax
       je        near ptr M01_L01
       call      qword ptr [7FF80D1FE0E8]
       mov       rcx,rax
       mov       r8,20A4D001440
       mov       r8,[r8]
       mov       rdx,20A2529B590
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rcx,rax
       xor       eax,eax
       test      rcx,rcx
       cmove     rcx,rax
       call      qword ptr [7FF80D146100]
       int       3
M01_L11:
       mov       rcx,[rdx+8]
       call      qword ptr [7FF80D146118]; System.Threading.Monitor.IsEntered(System.Object)
       test      eax,eax
       je        short M01_L12
       call      qword ptr [7FF80D1FE0E8]
       mov       rcx,rax
       mov       r8,20A4D001440
       mov       r8,[r8]
       mov       rdx,20A2529B590
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rcx,rax
       xor       eax,eax
       test      rcx,rcx
       cmove     rcx,rax
       call      qword ptr [7FF80D146100]
       int       3
M01_L12:
       xor       edx,edx
       mov       [rsi+10],rdx
       mov       rdx,[rbp+10]
       mov       rcx,[rdx+8]
       mov       [rbp-40],rcx
       xor       ecx,ecx
       mov       [rbp-30],ecx
       lea       rdx,[rbp-30]
       mov       rcx,[rbp-40]
       call      qword ptr [7FF80CDC5998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rdx,[rbp+10]
       cmp       qword ptr [rdx+28],0
       jne       near ptr M01_L30
       lea       rcx,[rbp+18]
       call      qword ptr [7FF80D144D68]; System.Threading.CancellationToken.get_IsCancellationRequested()
       test      eax,eax
       je        short M01_L13
       lea       rcx,[rbp+18]
       call      qword ptr [7FF80D1FE100]
       int       3
M01_L13:
       mov       rcx,offset MT_Microsoft.VisualStudio.Threading.InlineResumable
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       lea       rcx,[rsi+18]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       rdx,[rbp+10]
       mov       [rdx+20],rcx
       mov       rcx,[rbx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rbx
       mov       rdx,7FF80D182D90
       call      qword ptr [7FF80CDCF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L15:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8,offset Microsoft.VisualStudio.Threading.AsyncLazy`1+<>c__DisplayClass20_0[[System.__Canon, System.Private.CoreLib]].<GetValueAsync>b__0()
       call      qword ptr [7FF80CDC6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp+10]
       cmp       byte ptr [rdx+38],0
       jne       near ptr M01_L19
       cmp       qword ptr [rdx+18],0
       je        short M01_L16
       mov       rcx,7FF80D241B28
       call      qword ptr [7FF80D146298]
M01_L16:
       mov       rcx,offset MT_Microsoft.VisualStudio.Threading.AsyncLocal<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FF80D146178]; Microsoft.VisualStudio.Threading.AsyncLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rcx,rbx
       mov       rdx,7FF80D1831A8
       call      qword ptr [7FF80CDCF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L18:
       call      qword ptr [7FF80CDC5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       mov       rcx,[r14+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF80D146D60]; System.Threading.AsyncLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
       mov       rdx,[rbp+10]
       lea       rcx,[rdx+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp+10]
M01_L19:
       cmp       qword ptr [rdx+10],0
       je        near ptr M01_L26
       mov       rcx,[rbx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L20
       jmp       short M01_L21
M01_L20:
       mov       rcx,rbx
       mov       rdx,7FF80D182E40
       call      qword ptr [7FF80CDCF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L21:
       mov       rdx,[rbp+10]
       mov       r14,[rdx+10]
       cmp       [r14],r14b
       mov       rax,[rcx+18]
       mov       rax,[rax+10]
       test      rax,rax
       je        short M01_L22
       jmp       short M01_L23
M01_L22:
       mov       rdx,7FF80D21AC60
       call      qword ptr [7FF80CDCF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
M01_L23:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       [rsp+28],ecx
       mov       rcx,r14
       mov       rdx,rax
       mov       r8,rdi
       xor       r9d,r9d
       call      qword ptr [7FF80D1FE058]
       mov       rdx,[rbp+10]
       lea       rcx,[rdx+30]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lock or   dword ptr [rsp],0
       mov       rdx,[rbp+10]
       mov       rdi,[rdx+30]
       mov       rcx,[rdi]
       mov       rax,[rcx+30]
       mov       rax,[rax]
       mov       r14,[rax+10]
       test      r14,r14
       je        short M01_L24
       jmp       short M01_L25
M01_L24:
       mov       rdx,7FF80D21ACF8
       call      qword ptr [7FF80CDCF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
M01_L25:
       mov       rcx,rdi
       call      qword ptr [7FF80D1FE118]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FF80CDC6328]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rdx,[rbp+10]
       lea       rcx,[rdx+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L28
M01_L26:
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       rdx,[rbp+10]
       lea       rcx,[rdx+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L28
M01_L27:
       mov       rcx,[rdx+18]
       mov       rcx,[rcx+8]
       xor       edx,edx
       cmp       [rcx],ecx
       call      qword ptr [7FF80D146D60]; System.Threading.AsyncLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
       jmp       short M01_L30
M01_L28:
       mov       rdx,[rbp+10]
       cmp       qword ptr [rdx+18],0
       je        short M01_L30
       jmp       short M01_L27
M01_L29:
       mov       rcx,[rbp-40]
       call      qword ptr [7FF80CDC6820]; System.Threading.Monitor.Exit(System.Object)
       jmp       short M01_L31
M01_L30:
       cmp       byte ptr [rbp-30],0
       jne       short M01_L29
M01_L31:
       mov       rcx,[rsi+10]
       test      rcx,rcx
       je        near ptr M01_L02
       call      qword ptr [7FF80D1461D8]; Microsoft.VisualStudio.Threading.InlineResumable.Resume()
       jmp       near ptr M01_L02
M01_L32:
       mov       r8,[rbp+18]
       xor       edx,edx
       call      qword ptr [7FF80D1461F0]
       jmp       near ptr M01_L03
M01_L33:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,170F
       mov       rdx,7FF80D136CF0
       call      qword ptr [7FF80CDCF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80D0A75B8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L34:
       test      dword ptr [rbx+34],1600000
       jne       near ptr M01_L05
       lea       rcx,[rbp-38]
       call      qword ptr [7FF80D144D68]; System.Threading.CancellationToken.get_IsCancellationRequested()
       test      eax,eax
       je        short M01_L37
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L35
       jmp       short M01_L36
M01_L35:
       mov       rcx,rsi
       mov       rdx,7FF80D18D480
       call      qword ptr [7FF80CDCF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L36:
       mov       rdx,[rbp-38]
       call      qword ptr [7FF80D144D20]
       jmp       near ptr M01_L06
M01_L37:
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L38
       jmp       short M01_L39
M01_L38:
       mov       rcx,rsi
       mov       rdx,7FF80D18D448
       call      qword ptr [7FF80CDCF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L39:
       mov       rdx,rbx
       mov       r8,[rbp-38]
       call      qword ptr [7FF80D14CBE8]
       jmp       near ptr M01_L06
       sub       rsp,38
       mov       rdx,[rbp+10]
       mov       rcx,[rdx+18]
       test      rcx,rcx
       je        short M01_L40
       mov       rcx,[rcx+8]
       xor       edx,edx
       cmp       [rcx],ecx
       call      qword ptr [7FF80D146D60]; System.Threading.AsyncLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
M01_L40:
       nop
       add       rsp,38
       ret
       sub       rsp,38
       cmp       byte ptr [rbp-30],0
       je        short M01_L41
       mov       rcx,[rbp-40]
       call      qword ptr [7FF80CDC6820]; System.Threading.Monitor.Exit(System.Object)
M01_L41:
       nop
       add       rsp,38
       ret
; Total bytes of code 1397
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.HotPathBenchmarks`1[[System.__Canon, System.Private.CoreLib]].LazyOfTask_Token()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M00_L08
       mov       rsi,[rcx+18]
M00_L00:
       mov       rdi,[rbx+8]
       cmp       byte ptr [rdi+24],0
       jne       near ptr M00_L09
       test      dword ptr [rsi+34],1600000
       jne       near ptr M00_L06
       cmp       dword ptr [rdi+20],0
       jne       short M00_L03
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+40]
       test      rdx,rdx
       je        short M00_L02
M00_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       [rsp+20],rdi
       mov       r9,1EB4CC01428
       mov       r9,[r9]
       mov       rcx,rbp
       mov       rdx,rsi
       mov       r8d,0FFFFFFFF
       call      qword ptr [7FF80D1DE0A0]
       jmp       short M00_L07
M00_L02:
       mov       rdx,7FF80D1FA1D0
       call      qword ptr [7FF80CDAF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M00_L01
M00_L03:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+48]
       test      rax,rax
       je        short M00_L05
       mov       rcx,rax
M00_L04:
       mov       rdx,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF80D124D20]
M00_L05:
       mov       rdx,7FF80D1FA1F8
       call      qword ptr [7FF80CDAF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M00_L04
M00_L06:
       mov       rbp,rsi
M00_L07:
       mov       rax,rbp
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L08:
       call      qword ptr [7FF80D085860]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rsi,rax
       jmp       near ptr M00_L00
M00_L09:
       mov       ecx,46
       call      qword ptr [7FF80D1DE028]
       int       3
; Total bytes of code 258
```
```assembly
; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0A8
       lea       rbp,[rsp+0E0]
       xor       r8d,r8d
       mov       [rsp+20],r8
       mov       r8,rdx
       mov       [rbp-9C],r8
       mov       rdx,rcx
       mov       [rbp-0A4],rdx
       xor       ecx,ecx
       mov       [rbp-0AC],rcx
       mov       r9d,0FFFFFFFF
       mov       [rbp-94],r9d
       lea       rcx,[rbp-90]
       call      qword ptr [7FF850609030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       r8,[rbp-9C]
       mov       rdx,[rbp-0A4]
       mov       rcx,[rbp-0AC]
       mov       r9d,[rbp-94]
       call      qword ptr [rax]
       mov       rbx,rax
       lea       rcx,[rbp-90]
       call      qword ptr [7FF850609038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rax,rbx
       add       rsp,0A8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 166
```
```assembly
; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
M02_L00:
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M02_L01
       mov       ecx,[rsi+10]
       cmp       ecx,8
       jne       short M02_L03
       mov       rcx,rbx
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF85062E1B0]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
M02_L01:
       cmp       qword ptr [rbx+8],0
       jne       short M02_L02
       mov       rax,[rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L02:
       mov       rcx,rbx
       lea       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax]
M02_L03:
       cmp       ecx,8
       ja        short M02_L04
       mov       ecx,ecx
       lea       rdx,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       edx,[rdx+rcx*4]
       lea       r8,[M02_L00]
       add       rdx,r8
       jmp       rdx
M02_L04:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF850624C78]
       int       3
       mov       rcx,rbx
       call      qword ptr [7FF85062E1A0]
       jmp       short M02_L01
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF85062E1A8]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M02_L01
       mov       rcx,[rbx]
       call      qword ptr [7FF85060B838]
       mov       rcx,rax
       call      qword ptr [7FF850612EA0]
       mov       rcx,rax
       call      qword ptr [7FF850634008]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF85062E1B8]
       jmp       near ptr M02_L01
       mov       rax,[rbx+10]
       test      rax,rax
       je        short M02_L05
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF85062E1B8]
       jmp       near ptr M02_L01
M02_L05:
       mov       rcx,rbx
       call      qword ptr [7FF85062E1C8]
       jmp       near ptr M02_L01
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,1
       call      qword ptr [7FF85062E1B0]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M02_L01
; Total bytes of code 269
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.HotPathBenchmarks`1[[System.__Canon, System.Private.CoreLib]].AsyncLazy_Token()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rcx,[rbx+18]
       mov       rsi,[rbx+8]
       cmp       byte ptr [rsi+24],0
       jne       short M00_L00
       cmp       [rcx],cl
       cmp       dword ptr [rsi+20],0
       jne       short M00_L01
       mov       rax,[rcx+10]
       test      rax,rax
       je        short M00_L04
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M00_L00:
       mov       ecx,46
       call      qword ptr [7FF80D1FDFE0]
       int       3
M00_L01:
       mov       rcx,[rcx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+10]
       test      rax,rax
       je        short M00_L02
       mov       rcx,rax
       jmp       short M00_L03
M00_L02:
       mov       rdx,7FF80D16A348
       call      qword ptr [7FF80CDCF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M00_L03:
       mov       rdx,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF80D144D20]
M00_L04:
       mov       rdx,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF80D144D80]; System.Threading.Tasks.AsyncLazy`1[[System.__Canon, System.Private.CoreLib]].GetOrStartAttemptAsync(System.Threading.CancellationToken)
; Total bytes of code 137
```
```assembly
; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0A8
       lea       rbp,[rsp+0E0]
       xor       r8d,r8d
       mov       [rsp+20],r8
       mov       r8,rdx
       mov       [rbp-9C],r8
       mov       rdx,rcx
       mov       [rbp-0A4],rdx
       xor       ecx,ecx
       mov       [rbp-0AC],rcx
       mov       r9d,0FFFFFFFF
       mov       [rbp-94],r9d
       lea       rcx,[rbp-90]
       call      qword ptr [7FF850609030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       r8,[rbp-9C]
       mov       rdx,[rbp-0A4]
       mov       rcx,[rbp-0AC]
       mov       r9d,[rbp-94]
       call      qword ptr [rax]
       mov       rbx,rax
       lea       rcx,[rbp-90]
       call      qword ptr [7FF850609038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rax,rbx
       add       rsp,0A8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 166
```
```assembly
; System.Threading.Tasks.AsyncLazy`1[[System.__Canon, System.Private.CoreLib]].GetOrStartAttemptAsync(System.Threading.CancellationToken)
       push      rbp
       sub       rsp,1C0
       lea       rbp,[rsp+1C0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu32 [rbp-0F0],zmm4
       vmovdqu32 [rbp-0B0],zmm4
       vmovdqu32 [rbp-80],zmm4
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       dword ptr [rbp-0E0],3E8
M02_L00:
       mov       eax,[rbp-0E0]
       dec       eax
       mov       [rbp-0E0],eax
       cmp       dword ptr [rbp-0E0],0
       jg        short M02_L01
       lea       rcx,[rbp-0E0]
       xor       edx,edx
       call      CORINFO_HELP_PATCHPOINT
M02_L01:
       mov       rax,[rbp+10]
       mov       rax,[rax+8]
       mov       [rbp-48],rax
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       [rbp-0F8],rax
       mov       rax,[rbp-0F8]
       mov       rax,[rax+30]
       mov       rax,[rax]
       mov       rax,[rax+18]
       mov       [rbp-100],rax
       cmp       qword ptr [rbp-100],0
       je        short M02_L02
       mov       rax,[rbp-100]
       mov       [rbp-68],rax
       jmp       short M02_L03
M02_L02:
       mov       rcx,[rbp-0F8]
       mov       rdx,7FF80D16A568
       call      qword ptr [7FF80CDCF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-68],rax
M02_L03:
       mov       rcx,[rbp-68]
       mov       rdx,[rbp-48]
       call      qword ptr [7FF80CDC6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       [rbp-50],rax
       cmp       qword ptr [rbp-50],0
       je        short M02_L04
       mov       rcx,7FF80D13FC40
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-50]
       mov       [rbp-0E8],rax
       jmp       near ptr M02_L28
M02_L04:
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       [rbp-108],rax
       mov       rax,[rbp-108]
       mov       rax,[rax+30]
       mov       rax,[rax]
       mov       rax,[rax+20]
       mov       [rbp-110],rax
       cmp       qword ptr [rbp-110],0
       je        short M02_L05
       mov       rax,[rbp-110]
       mov       [rbp-70],rax
       jmp       short M02_L06
M02_L05:
       mov       rcx,[rbp-108]
       mov       rdx,7FF80D16A578
       call      qword ptr [7FF80CDCF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-70],rax
M02_L06:
       mov       rcx,[rbp-70]
       mov       rdx,[rbp-48]
       call      qword ptr [7FF80CDC6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       [rbp-58],rax
       cmp       qword ptr [rbp-58],0
       je        near ptr M02_L10
       mov       rcx,[rbp-58]
       call      qword ptr [7FF80D144E58]
       test      eax,eax
       je        near ptr M02_L09
       mov       rcx,7FF80D13FC44
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0D0],rax
       mov       rcx,[rbp-0D0]
       mov       rdx,1A225396410
       call      qword ptr [7FF80D0A7D50]
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       [rbp-118],rax
       mov       rax,[rbp-118]
       mov       rax,[rax+30]
       mov       rax,[rax]
       mov       [rbp-120],rax
       mov       rax,[rbp-120]
       cmp       qword ptr [rax+8],40
       jle       short M02_L07
       mov       rax,[rbp-120]
       mov       rax,[rax+40]
       mov       [rbp-128],rax
       cmp       qword ptr [rbp-128],0
       je        short M02_L07
       mov       rax,[rbp-128]
       mov       [rbp-0D8],rax
       jmp       short M02_L08
M02_L07:
       mov       rcx,[rbp-118]
       mov       rdx,7FF80D16CFF8
       call      qword ptr [7FF80CDCF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-0D8],rax
M02_L08:
       mov       rcx,[rbp-0D8]
       mov       rdx,[rbp-0D0]
       call      qword ptr [7FF80D144DF8]; System.Threading.Tasks.Task.FromException[[System.__Canon, System.Private.CoreLib]](System.Exception)
       mov       [rbp-0E8],rax
       jmp       near ptr M02_L28
M02_L09:
       mov       rcx,7FF80D13FC48
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp-58]
       mov       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF80D144E70]; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.__Canon, System.Private.CoreLib]].WaitAsync(System.Threading.CancellationToken)
       mov       [rbp-0E8],rax
       jmp       near ptr M02_L28
M02_L10:
       mov       rax,[rbp+10]
       cmp       [rax],al
       mov       rax,[rbp+10]
       lea       rcx,[rax+20]
       call      qword ptr [7FF80D144D68]; System.Threading.CancellationToken.get_IsCancellationRequested()
       test      eax,eax
       je        near ptr M02_L13
       mov       rcx,7FF80D13FC4C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       [rbp-130],rax
       mov       rax,[rbp-130]
       mov       rax,[rax+30]
       mov       rax,[rax]
       mov       rax,[rax+10]
       mov       [rbp-138],rax
       cmp       qword ptr [rbp-138],0
       je        short M02_L11
       mov       rax,[rbp-138]
       mov       [rbp-0C8],rax
       jmp       short M02_L12
M02_L11:
       mov       rcx,[rbp-130]
       mov       rdx,7FF80D16A348
       call      qword ptr [7FF80CDCF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-0C8],rax
M02_L12:
       mov       rax,[rbp+10]
       mov       rdx,[rax+20]
       mov       rcx,[rbp-0C8]
       call      qword ptr [7FF80D144D20]
       mov       [rbp-0E8],rax
       jmp       near ptr M02_L28
M02_L13:
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       [rbp-140],rax
       mov       rax,[rbp-140]
       mov       rax,[rax+30]
       mov       rax,[rax]
       mov       rax,[rax+20]
       mov       [rbp-148],rax
       cmp       qword ptr [rbp-148],0
       je        short M02_L14
       mov       rax,[rbp-148]
       mov       [rbp-80],rax
       jmp       short M02_L15
M02_L14:
       mov       rcx,[rbp-140]
       mov       rdx,7FF80D16A578
       call      qword ptr [7FF80CDCF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-80],rax
M02_L15:
       mov       rcx,[rbp-80]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-78],rax
       mov       rcx,[rbp-78]
       mov       rdx,[rbp+10]
       call      qword ptr [7FF80D144E88]; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.__Canon, System.Private.CoreLib]]..ctor(System.Threading.Tasks.AsyncLazy`1<System.__Canon>)
       mov       rax,[rbp-78]
       mov       [rbp-60],rax
       mov       rax,[rbp+10]
       cmp       [rax],al
       mov       rax,[rbp+10]
       lea       rcx,[rax+8]
       mov       rdx,[rbp-60]
       xor       r8d,r8d
       call      qword ptr [7FF80D144EA0]; System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       jne       near ptr M02_L27
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       [rbp-150],rax
       mov       rax,[rbp-150]
       mov       rax,[rax+30]
       mov       rax,[rax]
       mov       rax,[rax+28]
       mov       [rbp-158],rax
       cmp       qword ptr [rbp-158],0
       je        short M02_L16
       mov       rax,[rbp-158]
       mov       [rbp-88],rax
       jmp       short M02_L17
M02_L16:
       mov       rcx,[rbp-150]
       mov       rdx,7FF80D16A8D0
       call      qword ptr [7FF80CDCF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-88],rax
M02_L17:
       mov       rcx,[rbp-88]
       call      qword ptr [7FF80CDC5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rax+8]
       mov       [rbp-90],rax
       mov       rax,[rbp-90]
       mov       [rbp-98],rax
       cmp       qword ptr [rbp-90],0
       jne       near ptr M02_L24
       mov       rcx,7FF80D13FC50
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       [rbp-160],rax
       mov       rax,[rbp-160]
       mov       rax,[rax+30]
       mov       rax,[rax]
       mov       rax,[rax+28]
       mov       [rbp-168],rax
       cmp       qword ptr [rbp-168],0
       je        short M02_L18
       mov       rax,[rbp-168]
       mov       [rbp-0A8],rax
       jmp       short M02_L19
M02_L18:
       mov       rcx,[rbp-160]
       mov       rdx,7FF80D16A8D0
       call      qword ptr [7FF80CDCF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-0A8],rax
M02_L19:
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       [rbp-170],rax
       mov       rax,[rbp-170]
       mov       rax,[rax+30]
       mov       rax,[rax]
       mov       [rbp-178],rax
       mov       rax,[rbp-178]
       cmp       qword ptr [rax+8],38
       jle       short M02_L20
       mov       rax,[rbp-178]
       mov       rax,[rax+38]
       mov       [rbp-180],rax
       cmp       qword ptr [rbp-180],0
       je        short M02_L20
       mov       rax,[rbp-180]
       mov       [rbp-0B8],rax
       jmp       short M02_L21
M02_L20:
       mov       rcx,[rbp-170]
       mov       rdx,7FF80D16CEF0
       call      qword ptr [7FF80CDCF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-0B8],rax
M02_L21:
       mov       rcx,[rbp-0B8]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0B0],rax
       mov       rcx,[rbp-0A8]
       call      qword ptr [7FF80CDC5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rax]
       mov       [rbp-0F0],rax
       mov       rdx,[rbp-0F0]
       mov       rcx,[rbp-0B0]
       mov       r8,offset System.Threading.Tasks.AsyncLazy`1+<>c[[System.__Canon, System.Private.CoreLib]].<GetOrStartAttemptAsync>b__11_0(Attempt<System.__Canon>)
       call      qword ptr [7FF80CDC6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       [rbp-188],rax
       mov       rax,[rbp-188]
       mov       rax,[rax+30]
       mov       rax,[rax]
       mov       rax,[rax+28]
       mov       [rbp-190],rax
       cmp       qword ptr [rbp-190],0
       je        short M02_L22
       mov       rax,[rbp-190]
       mov       [rbp-0C0],rax
       jmp       short M02_L23
M02_L22:
       mov       rcx,[rbp-188]
       mov       rdx,7FF80D16A8D0
       call      qword ptr [7FF80CDCF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-0C0],rax
M02_L23:
       mov       rcx,[rbp-0C0]
       call      qword ptr [7FF80CDC5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       lea       rcx,[rax+8]
       mov       rdx,[rbp-0B0]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-0B0]
       mov       [rbp-98],rax
M02_L24:
       mov       rcx,7FF80D13FC54
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       [rbp-198],rax
       mov       rax,[rbp-198]
       mov       rax,[rax+30]
       mov       rax,[rax]
       mov       rax,[rax+30]
       mov       [rbp-1A0],rax
       cmp       qword ptr [rbp-1A0],0
       je        short M02_L25
       mov       rax,[rbp-1A0]
       mov       [rbp-0A0],rax
       jmp       short M02_L26
M02_L25:
       mov       rcx,[rbp-198]
       mov       rdx,7FF80D16CE08
       call      qword ptr [7FF80CDCF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-0A0],rax
M02_L26:
       mov       rcx,[rbp-0A0]
       mov       rdx,[rbp-98]
       mov       r8,[rbp-60]
       xor       r9d,r9d
       call      qword ptr [7FF80D144DB0]; System.Threading.ThreadPool.QueueUserWorkItem[[System.__Canon, System.Private.CoreLib]](System.Action`1<System.__Canon>, System.__Canon, Boolean)
       mov       rcx,[rbp-60]
       mov       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF80D144E70]; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.__Canon, System.Private.CoreLib]].WaitAsync(System.Threading.CancellationToken)
       mov       [rbp-0E8],rax
       jmp       short M02_L28
M02_L27:
       mov       rcx,7FF80D13FC58
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M02_L00
M02_L28:
       mov       rax,[rbp-0E8]
       add       rsp,1C0
       pop       rbp
       ret
; Total bytes of code 1776
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.HotPathBenchmarks`1[[System.__Canon, System.Private.CoreLib]].Nito_Token()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       mov       rbx,[rcx+20]
       mov       rdx,[rbx+8]
       mov       [rbp-30],rdx
       xor       eax,eax
       mov       [rbp-24],eax
       test      rdx,rdx
       je        short M00_L01
       mov       rcx,rdx
       call      00007FF86CA5E120
       test      eax,eax
       je        short M00_L02
M00_L00:
       mov       dword ptr [rbp-24],1
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],0
       jne       short M00_L03
       mov       rbx,[rcx+18]
       jmp       short M00_L04
M00_L01:
       xor       ecx,ecx
       call      qword ptr [7FF80D1DE040]
       int       3
M00_L02:
       mov       rcx,[rbp-30]
       call      qword ptr [7FF80D1DE130]
       jmp       short M00_L00
M00_L03:
       call      qword ptr [7FF80D085860]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rbx,rax
M00_L04:
       mov       rcx,[rbp-30]
       call      00007FF86CA5E040
       test      eax,eax
       jne       near ptr M00_L13
M00_L05:
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+8]
       cmp       byte ptr [rsi+24],0
       jne       near ptr M00_L14
       test      dword ptr [rbx+34],1600000
       jne       near ptr M00_L11
       cmp       dword ptr [rsi+20],0
       jne       short M00_L08
       mov       rdx,[rbx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       test      rax,rax
       je        short M00_L07
M00_L06:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rsp+20],rsi
       mov       r9,22BF5801428
       mov       r9,[r9]
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8d,0FFFFFFFF
       call      qword ptr [7FF80D1DE0E8]
       jmp       short M00_L12
M00_L07:
       mov       rcx,rdx
       mov       rdx,7FF80D1FA1E0
       call      qword ptr [7FF80CDAF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       short M00_L06
M00_L08:
       mov       rdx,[rbx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+48]
       test      rax,rax
       je        short M00_L10
M00_L09:
       mov       rcx,rax
       mov       rdx,rsi
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       jmp       qword ptr [7FF80D124D20]
M00_L10:
       mov       rcx,rdx
       mov       rdx,7FF80D1FA208
       call      qword ptr [7FF80CDAF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       short M00_L09
M00_L11:
       mov       rdi,rbx
M00_L12:
       mov       rax,rdi
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M00_L13:
       mov       ecx,eax
       mov       rdx,[rbp-30]
       call      qword ptr [7FF80D1DE058]
       jmp       near ptr M00_L05
M00_L14:
       mov       ecx,46
       call      qword ptr [7FF80D1DE070]
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-24],0
       je        short M00_L16
       cmp       qword ptr [rbp-30],0
       jne       short M00_L15
       xor       ecx,ecx
       call      qword ptr [7FF80D1DE040]
       int       3
M00_L15:
       mov       rcx,[rbp-30]
       call      00007FF86CA5E040
       test      eax,eax
       je        short M00_L16
       mov       ecx,eax
       mov       rdx,[rbp-30]
       call      qword ptr [7FF80D1DE058]
M00_L16:
       nop
       add       rsp,28
       ret
; Total bytes of code 413
```
```assembly
; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
M01_L00:
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M01_L01
       mov       ecx,[rsi+10]
       cmp       ecx,8
       jne       short M01_L03
       mov       rcx,rbx
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF85062E1B0]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
M01_L01:
       cmp       qword ptr [rbx+8],0
       jne       short M01_L02
       mov       rax,[rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L02:
       mov       rcx,rbx
       lea       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax]
M01_L03:
       cmp       ecx,8
       ja        short M01_L04
       mov       ecx,ecx
       lea       rdx,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       edx,[rdx+rcx*4]
       lea       r8,[M01_L00]
       add       rdx,r8
       jmp       rdx
M01_L04:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF850624C78]
       int       3
       mov       rcx,rbx
       call      qword ptr [7FF85062E1A0]
       jmp       short M01_L01
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF85062E1A8]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M01_L01
       mov       rcx,[rbx]
       call      qword ptr [7FF85060B838]
       mov       rcx,rax
       call      qword ptr [7FF850612EA0]
       mov       rcx,rax
       call      qword ptr [7FF850634008]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF85062E1B8]
       jmp       near ptr M01_L01
       mov       rax,[rbx+10]
       test      rax,rax
       je        short M01_L05
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF85062E1B8]
       jmp       near ptr M01_L01
M01_L05:
       mov       rcx,rbx
       call      qword ptr [7FF85062E1C8]
       jmp       near ptr M01_L01
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,1
       call      qword ptr [7FF85062E1B0]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M01_L01
; Total bytes of code 269
```
```assembly
; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0A8
       lea       rbp,[rsp+0E0]
       xor       r8d,r8d
       mov       [rsp+20],r8
       mov       r8,rdx
       mov       [rbp-9C],r8
       mov       rdx,rcx
       mov       [rbp-0A4],rdx
       xor       ecx,ecx
       mov       [rbp-0AC],rcx
       mov       r9d,0FFFFFFFF
       mov       [rbp-94],r9d
       lea       rcx,[rbp-90]
       call      qword ptr [7FF850609030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       r8,[rbp-9C]
       mov       rdx,[rbp-0A4]
       mov       rcx,[rbp-0AC]
       mov       r9d,[rbp-94]
       call      qword ptr [rax]
       mov       rbx,rax
       lea       rcx,[rbp-90]
       call      qword ptr [7FF850609038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rax,rbx
       add       rsp,0A8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 166
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.HotPathBenchmarks`1[[System.__Canon, System.Private.CoreLib]].VsThreading_Token()
       sub       rsp,28
       mov       rdx,[rcx+28]
       mov       rax,[rcx+8]
       cmp       byte ptr [rax+24],0
       jne       short M00_L00
       mov       rcx,rdx
       mov       rdx,rax
       cmp       [rcx],ecx
       add       rsp,28
       jmp       qword ptr [7FF80D125DE8]; Microsoft.VisualStudio.Threading.AsyncLazy`1[[System.__Canon, System.Private.CoreLib]].GetValueAsync(System.Threading.CancellationToken)
M00_L00:
       mov       ecx,46
       call      qword ptr [7FF80D1DDFF8]
       int       3
; Total bytes of code 48
```
```assembly
; Microsoft.VisualStudio.Threading.AsyncLazy`1[[System.__Canon, System.Private.CoreLib]].GetValueAsync(System.Threading.CancellationToken)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-30],rax
       mov       [rbp-38],rax
       mov       [rbp-28],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       rbx,[rcx]
       mov       rdx,rbx
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M01_L07
M01_L00:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp+10]
       mov       rcx,[rdx+28]
       test      rcx,rcx
       je        near ptr M01_L09
       test      dword ptr [rcx+34],1600000
       je        near ptr M01_L09
M01_L01:
       mov       rdx,[rbp+10]
       cmp       qword ptr [rdx+28],0
       je        near ptr M01_L10
M01_L02:
       mov       rdx,[rbp+10]
       lock or   dword ptr [rsp],0
       mov       rcx,[rdx+30]
       test      rcx,rcx
       jne       near ptr M01_L31
       xor       eax,eax
M01_L03:
       test      rax,rax
       jne       short M01_L06
       mov       rcx,[rbx+30]
       mov       rcx,[rcx]
       mov       rsi,[rcx+20]
       test      rsi,rsi
       je        short M01_L08
M01_L04:
       mov       rdx,[rbp+10]
       mov       rbx,[rdx+28]
       mov       rcx,[rbp+18]
       mov       [rbp-38],rcx
       test      rbx,rbx
       je        near ptr M01_L32
       cmp       qword ptr [rbp-38],0
       je        short M01_L05
       test      dword ptr [rbx+34],1600000
       je        near ptr M01_L33
M01_L05:
       mov       rax,rbx
M01_L06:
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L07:
       mov       rcx,rdx
       mov       rdx,7FF80D162268
       call      qword ptr [7FF80CDAF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M01_L00
M01_L08:
       mov       rcx,rbx
       mov       rdx,7FF80D162CE8
       call      qword ptr [7FF80CDAF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       short M01_L04
M01_L09:
       mov       rcx,[rdx+18]
       test      rcx,rcx
       je        near ptr M01_L01
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF80D126DA8]; System.Threading.AsyncLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       test      rax,rax
       je        near ptr M01_L01
       call      qword ptr [7FF80D1DE118]
       mov       rcx,rax
       mov       r8,21403C01458
       mov       r8,[r8]
       mov       rdx,2242803B590
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rcx,rax
       xor       eax,eax
       test      rcx,rcx
       cmove     rcx,rax
       call      qword ptr [7FF80D126100]
       int       3
M01_L10:
       mov       rcx,[rdx+8]
       call      qword ptr [7FF80D126118]; System.Threading.Monitor.IsEntered(System.Object)
       test      eax,eax
       je        short M01_L11
       call      qword ptr [7FF80D1DE118]
       mov       rcx,rax
       mov       r8,21403C01458
       mov       r8,[r8]
       mov       rdx,2242803B590
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rcx,rax
       xor       eax,eax
       test      rcx,rcx
       cmove     rcx,rax
       call      qword ptr [7FF80D126100]
       int       3
M01_L11:
       xor       edx,edx
       mov       [rsi+10],rdx
       mov       rdx,[rbp+10]
       mov       rcx,[rdx+8]
       mov       [rbp-40],rcx
       xor       ecx,ecx
       mov       [rbp-30],ecx
       lea       rdx,[rbp-30]
       mov       rcx,[rbp-40]
       call      qword ptr [7FF80CDA5998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rdx,[rbp+10]
       cmp       qword ptr [rdx+28],0
       jne       near ptr M01_L29
       lea       rcx,[rbp+18]
       call      qword ptr [7FF80D124D68]; System.Threading.CancellationToken.get_IsCancellationRequested()
       test      eax,eax
       je        short M01_L12
       lea       rcx,[rbp+18]
       call      qword ptr [7FF80D1DE130]
       int       3
M01_L12:
       mov       rcx,offset MT_Microsoft.VisualStudio.Threading.InlineResumable
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       lea       rcx,[rsi+18]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       rdx,[rbp+10]
       mov       [rdx+20],rcx
       mov       rcx,[rbx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rcx,rbx
       mov       rdx,7FF80D162D78
       call      qword ptr [7FF80CDAF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L14:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8,offset Microsoft.VisualStudio.Threading.AsyncLazy`1+<>c__DisplayClass20_0[[System.__Canon, System.Private.CoreLib]].<GetValueAsync>b__0()
       call      qword ptr [7FF80CDA6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp+10]
       cmp       byte ptr [rdx+38],0
       jne       near ptr M01_L18
       cmp       qword ptr [rdx+18],0
       je        short M01_L15
       mov       rcx,7FF80D240F18
       call      qword ptr [7FF80D126298]
M01_L15:
       mov       rcx,offset MT_Microsoft.VisualStudio.Threading.AsyncLocal<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FF80D126178]; Microsoft.VisualStudio.Threading.AsyncLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M01_L16
       jmp       short M01_L17
M01_L16:
       mov       rcx,rbx
       mov       rdx,7FF80D163190
       call      qword ptr [7FF80CDAF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L17:
       call      qword ptr [7FF80CDA5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       mov       rcx,[r14+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF80D126DD8]; System.Threading.AsyncLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
       mov       rdx,[rbp+10]
       lea       rcx,[rdx+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp+10]
M01_L18:
       cmp       qword ptr [rdx+10],0
       je        near ptr M01_L25
       mov       rcx,[rbx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rcx,rbx
       mov       rdx,7FF80D162E28
       call      qword ptr [7FF80CDAF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M01_L20:
       mov       rdx,[rbp+10]
       mov       r14,[rdx+10]
       cmp       [r14],r14b
       mov       rax,[rcx+18]
       mov       rax,[rax+10]
       test      rax,rax
       je        short M01_L21
       jmp       short M01_L22
M01_L21:
       mov       rdx,7FF80D1FABD0
       call      qword ptr [7FF80CDAF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
M01_L22:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       [rsp+28],ecx
       mov       rcx,r14
       mov       rdx,rax
       mov       r8,rdi
       xor       r9d,r9d
       call      qword ptr [7FF80D1DE088]
       mov       rdx,[rbp+10]
       lea       rcx,[rdx+30]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lock or   dword ptr [rsp],0
       mov       rdx,[rbp+10]
       mov       rdi,[rdx+30]
       mov       rcx,[rdi]
       mov       rax,[rcx+30]
       mov       rax,[rax]
       mov       r14,[rax+10]
       test      r14,r14
       je        short M01_L23
       jmp       short M01_L24
M01_L23:
       mov       rdx,7FF80D1FAC68
       call      qword ptr [7FF80CDAF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
M01_L24:
       mov       rcx,rdi
       call      qword ptr [7FF80D1DE148]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FF80CDA6328]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rdx,[rbp+10]
       lea       rcx,[rdx+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L27
M01_L25:
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       rdx,[rbp+10]
       lea       rcx,[rdx+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L27
M01_L26:
       mov       rcx,[rdx+18]
       mov       rcx,[rcx+8]
       xor       edx,edx
       cmp       [rcx],ecx
       call      qword ptr [7FF80D126DD8]; System.Threading.AsyncLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
       jmp       short M01_L29
M01_L27:
       mov       rdx,[rbp+10]
       cmp       qword ptr [rdx+18],0
       je        short M01_L29
       jmp       short M01_L26
M01_L28:
       mov       rcx,[rbp-40]
       call      qword ptr [7FF80CDA6820]; System.Threading.Monitor.Exit(System.Object)
       jmp       short M01_L30
M01_L29:
       cmp       byte ptr [rbp-30],0
       jne       short M01_L28
M01_L30:
       mov       rcx,[rsi+10]
       test      rcx,rcx
       je        near ptr M01_L02
       call      qword ptr [7FF80D1261F0]; Microsoft.VisualStudio.Threading.InlineResumable.Resume()
       jmp       near ptr M01_L02
M01_L31:
       mov       r8,[rbp+18]
       xor       edx,edx
       call      qword ptr [7FF80D126220]
       jmp       near ptr M01_L03
M01_L32:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,170F
       mov       rdx,7FF80D116CF0
       call      qword ptr [7FF80CDAF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80D0875B8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L33:
       lea       rcx,[rbp-38]
       call      qword ptr [7FF80D124D68]; System.Threading.CancellationToken.get_IsCancellationRequested()
       test      eax,eax
       je        short M01_L36
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M01_L34
       jmp       short M01_L35
M01_L34:
       mov       rcx,rsi
       mov       rdx,7FF80D16D468
       call      qword ptr [7FF80CDAF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L35:
       mov       rdx,[rbp-38]
       call      qword ptr [7FF80D124D20]
       jmp       near ptr M01_L06
M01_L36:
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M01_L37
       jmp       short M01_L38
M01_L37:
       mov       rcx,rsi
       mov       rdx,7FF80D16D430
       call      qword ptr [7FF80CDAF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M01_L38:
       mov       rdx,rbx
       mov       r8,[rbp-38]
       call      qword ptr [7FF80D12CBE8]
       jmp       near ptr M01_L06
       sub       rsp,38
       mov       rdx,[rbp+10]
       mov       rcx,[rdx+18]
       test      rcx,rcx
       je        short M01_L39
       mov       rcx,[rcx+8]
       xor       edx,edx
       cmp       [rcx],ecx
       call      qword ptr [7FF80D126DD8]; System.Threading.AsyncLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
M01_L39:
       nop
       add       rsp,38
       ret
       sub       rsp,38
       cmp       byte ptr [rbp-30],0
       je        short M01_L40
       mov       rcx,[rbp-40]
       call      qword ptr [7FF80CDA6820]; System.Threading.Monitor.Exit(System.Object)
M01_L40:
       nop
       add       rsp,38
       ret
; Total bytes of code 1391
```

