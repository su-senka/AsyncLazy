## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.HotPathBenchmarks`1[[System.__Canon, System.Private.CoreLib]].LazyOfTask()
       mov       rdi,[rdi+10]
       cmp       qword ptr [rdi+8],0
       jne       short M00_L00
       mov       rax,[rdi+18]
       ret
M00_L00:
       jmp       qword ptr [73640F4BC438]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
; Total bytes of code 22
```
```assembly
; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       push      rbp
       push      r15
       push      rbx
       sub       rsp,10
       lea       rbp,[rsp+20]
       mov       [rbp-18],rdi
       mov       rbx,rdi
M01_L00:
       mov       r15,[rbx+8]
       test      r15,r15
       je        short M01_L01
       mov       edi,[r15+10]
       cmp       edi,8
       jne       short M01_L03
       mov       rdi,rbx
       mov       rsi,r15
       xor       edx,edx
       call      qword ptr [73640E822688]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
M01_L01:
       cmp       qword ptr [rbx+8],0
       jne       short M01_L02
       mov       rax,[rbx+18]
       add       rsp,10
       pop       rbx
       pop       r15
       pop       rbp
       ret
M01_L02:
       mov       rdi,rbx
       lea       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       add       rsp,10
       pop       rbx
       pop       r15
       pop       rbp
       jmp       qword ptr [rax]
M01_L03:
       cmp       edi,8
       ja        short M01_L04
       mov       edi,edi
       lea       rsi,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       esi,[rsi+rdi*4]
       lea       rdx,[M01_L00]
       add       rsi,rdx
       jmp       rsi
M01_L04:
       mov       rdi,[r15+8]
       cmp       [rdi],edi
       call      qword ptr [73640E819630]
       int       3
       mov       rdi,rbx
       call      qword ptr [73640E822678]
       jmp       short M01_L01
       mov       rdi,rbx
       xor       esi,esi
       call      qword ptr [73640E822680]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M01_L01
       mov       rdi,[rbx]
       call      qword ptr [73640E8014E0]
       mov       rdi,rax
       call      qword ptr [73640E808728]
       mov       rdi,rax
       call      qword ptr [73640E8281A8]
       mov       rdx,rax
       mov       rsi,r15
       mov       rdi,rbx
       call      qword ptr [73640E822690]
       jmp       near ptr M01_L01
       mov       rax,[rbx+10]
       test      rax,rax
       je        short M01_L05
       mov       rdi,[rax+8]
       call      qword ptr [rax+18]
       mov       rdx,rax
       mov       rsi,r15
       mov       rdi,rbx
       call      qword ptr [73640E822690]
       jmp       near ptr M01_L01
M01_L05:
       mov       rdi,rbx
       call      qword ptr [73640E8226A0]
       jmp       near ptr M01_L01
       mov       rdi,rbx
       mov       rsi,r15
       mov       edx,1
       call      qword ptr [73640E822688]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M01_L01
; Total bytes of code 278
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.HotPathBenchmarks`1[[System.__Canon, System.Private.CoreLib]].AsyncLazy()
       mov       rdi,[rdi+18]
       mov       rax,[rdi+10]
       test      rax,rax
       je        short M00_L00
       ret
M00_L00:
       xor       esi,esi
       jmp       qword ptr [73BDDDF07978]; System.Threading.Tasks.AsyncLazy`1[[System.__Canon, System.Private.CoreLib]].GetOrStartAttemptAsync(System.Threading.CancellationToken)
; Total bytes of code 22
```
```assembly
; System.Threading.Tasks.AsyncLazy`1[[System.__Canon, System.Private.CoreLib]].GetOrStartAttemptAsync(System.Threading.CancellationToken)
       push      rbp
       sub       rsp,1A0
       lea       rbp,[rsp+1A0]
       vxorps    xmm8,xmm8,xmm8
       vmovdqu32 [rbp-0F0],zmm8
       vmovdqu32 [rbp-0B0],zmm8
       vmovdqu32 [rbp-80],zmm8
       mov       [rbp-30],rdi
       mov       [rbp-38],rdi
       mov       [rbp-40],rsi
       mov       dword ptr [rbp-0E0],3E8
M01_L00:
       mov       eax,[rbp-0E0]
       dec       eax
       mov       [rbp-0E0],eax
       cmp       dword ptr [rbp-0E0],0
       jg        short M01_L01
       lea       rdi,[rbp-0E0]
       xor       esi,esi
       call      CORINFO_HELP_PATCHPOINT
M01_L01:
       mov       rax,[rbp-38]
       mov       rax,[rax+8]
       mov       [rbp-48],rax
       mov       rax,[rbp-38]
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
       mov       rdi,[rbp-0F8]
       mov       rsi,73BDDDF69498
       call      qword ptr [73BDDD42F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-68],rax
M01_L03:
       mov       rdi,[rbp-68]
       mov       rsi,[rbp-48]
       call      qword ptr [73BDDD426838]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       [rbp-50],rax
       cmp       qword ptr [rbp-50],0
       je        short M01_L04
       mov       rdi,73BDDDF70098
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-50]
       mov       [rbp-0E8],rax
       jmp       near ptr M01_L28
M01_L04:
       mov       rax,[rbp-38]
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
       mov       rdi,[rbp-108]
       mov       rsi,73BDDDF694A8
       call      qword ptr [73BDDD42F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-70],rax
M01_L06:
       mov       rdi,[rbp-70]
       mov       rsi,[rbp-48]
       call      qword ptr [73BDDD426838]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       [rbp-58],rax
       cmp       qword ptr [rbp-58],0
       je        near ptr M01_L10
       mov       rdi,[rbp-58]
       call      qword ptr [73BDDDF07A50]
       test      eax,eax
       je        near ptr M01_L09
       mov       rdi,73BDDDF7009C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdi,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0D0],rax
       mov       rdi,[rbp-0D0]
       mov       rsi,73BDD8807850
       call      qword ptr [73BDDDC85260]
       mov       rax,[rbp-38]
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
       mov       rdi,[rbp-118]
       mov       rsi,73BDDDF6BEA0
       call      qword ptr [73BDDD42F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-0D8],rax
M01_L08:
       mov       rdi,[rbp-0D8]
       mov       rsi,[rbp-0D0]
       call      qword ptr [73BDDDF079F0]; System.Threading.Tasks.Task.FromException[[System.__Canon, System.Private.CoreLib]](System.Exception)
       mov       [rbp-0E8],rax
       jmp       near ptr M01_L28
M01_L09:
       mov       rdi,73BDDDF700A0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdi,[rbp-58]
       mov       rsi,[rbp-40]
       cmp       [rdi],edi
       call      qword ptr [73BDDDF07A68]; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.__Canon, System.Private.CoreLib]].WaitAsync(System.Threading.CancellationToken)
       mov       [rbp-0E8],rax
       jmp       near ptr M01_L28
M01_L10:
       mov       rax,[rbp-38]
       cmp       [rax],al
       mov       rax,[rbp-38]
       lea       rdi,[rax+20]
       call      qword ptr [73BDDDF07960]; System.Threading.CancellationToken.get_IsCancellationRequested()
       test      eax,eax
       je        near ptr M01_L13
       mov       rdi,73BDDDF700A4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-38]
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
       mov       rdi,[rbp-130]
       mov       rsi,73BDDDF692A0
       call      qword ptr [73BDDD42F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-0C8],rax
M01_L12:
       mov       rax,[rbp-38]
       mov       rsi,[rax+20]
       mov       rdi,[rbp-0C8]
       call      qword ptr [73BDDDF07918]
       mov       [rbp-0E8],rax
       jmp       near ptr M01_L28
M01_L13:
       mov       rax,[rbp-38]
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
       mov       rdi,[rbp-140]
       mov       rsi,73BDDDF694A8
       call      qword ptr [73BDDD42F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-80],rax
M01_L15:
       mov       rdi,[rbp-80]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-78],rax
       mov       rdi,[rbp-78]
       mov       rsi,[rbp-38]
       call      qword ptr [73BDDDF07A80]; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.__Canon, System.Private.CoreLib]]..ctor(System.Threading.Tasks.AsyncLazy`1<System.__Canon>)
       mov       rax,[rbp-78]
       mov       [rbp-60],rax
       mov       rax,[rbp-38]
       cmp       [rax],al
       mov       rax,[rbp-38]
       lea       rdi,[rax+8]
       mov       rsi,[rbp-60]
       xor       edx,edx
       call      qword ptr [73BDDDF07A98]; System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       jne       near ptr M01_L27
       mov       rax,[rbp-38]
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
       mov       rdi,[rbp-150]
       mov       rsi,73BDDDF69798
       call      qword ptr [73BDDD42F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-88],rax
M01_L17:
       mov       rdi,[rbp-88]
       call      qword ptr [73BDDD425710]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rax+8]
       mov       [rbp-90],rax
       mov       rax,[rbp-90]
       mov       [rbp-98],rax
       cmp       qword ptr [rbp-90],0
       jne       near ptr M01_L24
       mov       rdi,73BDDDF700A8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-38]
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
       mov       rdi,[rbp-160]
       mov       rsi,73BDDDF69798
       call      qword ptr [73BDDD42F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-0A8],rax
M01_L19:
       mov       rax,[rbp-38]
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
       mov       rdi,[rbp-170]
       mov       rsi,73BDDDF6BDA8
       call      qword ptr [73BDDD42F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-0B8],rax
M01_L21:
       mov       rdi,[rbp-0B8]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0B0],rax
       mov       rdi,[rbp-0A8]
       call      qword ptr [73BDDD425710]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rax]
       mov       [rbp-0F0],rax
       mov       rsi,[rbp-0F0]
       mov       rdi,[rbp-0B0]
       mov       rdx,offset System.Threading.Tasks.AsyncLazy`1+<>c[[System.__Canon, System.Private.CoreLib]].<GetOrStartAttemptAsync>b__11_0(Attempt<System.__Canon>)
       call      qword ptr [73BDDD426E08]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rax,[rbp-38]
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
       mov       rdi,[rbp-188]
       mov       rsi,73BDDDF69798
       call      qword ptr [73BDDD42F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-0C0],rax
M01_L23:
       mov       rdi,[rbp-0C0]
       call      qword ptr [73BDDD425710]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       lea       rdi,[rax+8]
       mov       rsi,[rbp-0B0]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-0B0]
       mov       [rbp-98],rax
M01_L24:
       mov       rdi,73BDDDF700AC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-38]
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
       mov       rdi,[rbp-198]
       mov       rsi,73BDDDF6BCC0
       call      qword ptr [73BDDD42F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-0A0],rax
M01_L26:
       mov       rdi,[rbp-0A0]
       mov       rsi,[rbp-98]
       mov       rdx,[rbp-60]
       xor       ecx,ecx
       call      qword ptr [73BDDDF079A8]; System.Threading.ThreadPool.QueueUserWorkItem[[System.__Canon, System.Private.CoreLib]](System.Action`1<System.__Canon>, System.__Canon, Boolean)
       mov       rdi,[rbp-60]
       mov       rsi,[rbp-40]
       cmp       [rdi],edi
       call      qword ptr [73BDDDF07A68]; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.__Canon, System.Private.CoreLib]].WaitAsync(System.Threading.CancellationToken)
       mov       [rbp-0E8],rax
       jmp       short M01_L28
M01_L27:
       mov       rdi,73BDDDF700B0
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M01_L00
M01_L28:
       mov       rax,[rbp-0E8]
       add       rsp,1A0
       pop       rbp
       ret
; Total bytes of code 1775
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.HotPathBenchmarks`1[[System.__Canon, System.Private.CoreLib]].Nito()
       push      rbp
       push      rbx
       sub       rsp,18
       lea       rbp,[rsp+20]
       mov       rbx,[rdi+20]
       mov       rdi,[rbx+8]
       mov       [rbp-18],rdi
       xor       eax,eax
       mov       [rbp-0C],eax
       test      rdi,rdi
       je        short M00_L01
       call      00007E542D2E6020
       test      eax,eax
       je        short M00_L02
M00_L00:
       mov       dword ptr [rbp-0C],1
       mov       rdi,[rbx+18]
       cmp       qword ptr [rdi+8],0
       jne       short M00_L03
       mov       rbx,[rdi+18]
       jmp       short M00_L04
M00_L01:
       xor       edi,edi
       call      qword ptr [7E53AFC64AF8]
       int       3
M00_L02:
       mov       rdi,[rbp-18]
       call      qword ptr [7E53AFC64B40]
       jmp       short M00_L00
M00_L03:
       call      qword ptr [7E53AF89C438]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rbx,rax
M00_L04:
       mov       rdi,[rbp-18]
       call      00007E542D2E6790
       test      eax,eax
       jne       short M00_L06
M00_L05:
       mov       rax,rbx
       add       rsp,18
       pop       rbx
       pop       rbp
       ret
M00_L06:
       mov       edi,eax
       mov       rsi,[rbp-18]
       call      qword ptr [7E53AFC64B10]
       jmp       short M00_L05
       push      rax
       cmp       dword ptr [rbp-0C],0
       je        short M00_L08
       cmp       qword ptr [rbp-18],0
       jne       short M00_L07
       xor       edi,edi
       call      qword ptr [7E53AFC64AF8]
       int       3
M00_L07:
       mov       rdi,[rbp-18]
       call      00007E542D2E6790
       test      eax,eax
       je        short M00_L08
       mov       edi,eax
       mov       rsi,[rbp-18]
       call      qword ptr [7E53AFC64B10]
M00_L08:
       nop
       add       rsp,8
       ret
; Total bytes of code 187
```
```assembly
; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       push      rbp
       push      r15
       push      rbx
       sub       rsp,10
       lea       rbp,[rsp+20]
       mov       [rbp-18],rdi
       mov       rbx,rdi
M01_L00:
       mov       r15,[rbx+8]
       test      r15,r15
       je        short M01_L01
       mov       edi,[r15+10]
       cmp       edi,8
       jne       short M01_L03
       mov       rdi,rbx
       mov       rsi,r15
       xor       edx,edx
       call      qword ptr [7E53AEC02688]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
M01_L01:
       cmp       qword ptr [rbx+8],0
       jne       short M01_L02
       mov       rax,[rbx+18]
       add       rsp,10
       pop       rbx
       pop       r15
       pop       rbp
       ret
M01_L02:
       mov       rdi,rbx
       lea       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       add       rsp,10
       pop       rbx
       pop       r15
       pop       rbp
       jmp       qword ptr [rax]
M01_L03:
       cmp       edi,8
       ja        short M01_L04
       mov       edi,edi
       lea       rsi,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       esi,[rsi+rdi*4]
       lea       rdx,[M01_L00]
       add       rsi,rdx
       jmp       rsi
M01_L04:
       mov       rdi,[r15+8]
       cmp       [rdi],edi
       call      qword ptr [7E53AEBF9630]
       int       3
       mov       rdi,rbx
       call      qword ptr [7E53AEC02678]
       jmp       short M01_L01
       mov       rdi,rbx
       xor       esi,esi
       call      qword ptr [7E53AEC02680]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M01_L01
       mov       rdi,[rbx]
       call      qword ptr [7E53AEBE14E0]
       mov       rdi,rax
       call      qword ptr [7E53AEBE8728]
       mov       rdi,rax
       call      qword ptr [7E53AEC081A8]
       mov       rdx,rax
       mov       rsi,r15
       mov       rdi,rbx
       call      qword ptr [7E53AEC02690]
       jmp       near ptr M01_L01
       mov       rax,[rbx+10]
       test      rax,rax
       je        short M01_L05
       mov       rdi,[rax+8]
       call      qword ptr [rax+18]
       mov       rdx,rax
       mov       rsi,r15
       mov       rdi,rbx
       call      qword ptr [7E53AEC02690]
       jmp       near ptr M01_L01
M01_L05:
       mov       rdi,rbx
       call      qword ptr [7E53AEC026A0]
       jmp       near ptr M01_L01
       mov       rdi,rbx
       mov       rsi,r15
       mov       edx,1
       call      qword ptr [7E53AEC02688]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M01_L01
; Total bytes of code 278
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.HotPathBenchmarks`1[[System.__Canon, System.Private.CoreLib]].VsThreading()
       mov       rdi,[rdi+28]
       cmp       [rdi],dil
       xor       esi,esi
       jmp       qword ptr [77082FD2C978]; Microsoft.VisualStudio.Threading.AsyncLazy`1[[System.__Canon, System.Private.CoreLib]].GetValueAsync(System.Threading.CancellationToken)
; Total bytes of code 15
```
```assembly
; Microsoft.VisualStudio.Threading.AsyncLazy`1[[System.__Canon, System.Private.CoreLib]].GetValueAsync(System.Threading.CancellationToken)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-38],rax
       mov       [rbp-40],rax
       mov       [rbp-28],rdi
       mov       [rbp-48],rdi
       mov       [rbp-30],rsi
       mov       rbx,[rdi]
       mov       rsi,rbx
       mov       rax,[rsi+30]
       mov       rax,[rax]
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M01_L07
M01_L00:
       mov       rdi,rax
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rdi,[r15+8]
       mov       rsi,[rbp-48]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-48]
       mov       rdi,[rsi+28]
       test      rdi,rdi
       je        near ptr M01_L09
       test      dword ptr [rdi+34],1600000
       je        near ptr M01_L09
M01_L01:
       mov       rsi,[rbp-48]
       cmp       qword ptr [rsi+28],0
       je        near ptr M01_L10
M01_L02:
       mov       rsi,[rbp-48]
       lock or   dword ptr [rsp],0
       mov       rdi,[rsi+30]
       test      rdi,rdi
       jne       near ptr M01_L31
       xor       eax,eax
M01_L03:
       test      rax,rax
       jne       short M01_L06
       mov       rdi,[rbx+30]
       mov       rdi,[rdi]
       mov       r15,[rdi+20]
       test      r15,r15
       je        short M01_L08
M01_L04:
       mov       rsi,[rbp-48]
       mov       rbx,[rsi+28]
       mov       rdi,[rbp-30]
       mov       [rbp-40],rdi
       test      rbx,rbx
       je        near ptr M01_L32
       cmp       qword ptr [rbp-40],0
       jne       near ptr M01_L33
M01_L05:
       mov       rax,rbx
M01_L06:
       add       rsp,30
       pop       rbx
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L07:
       mov       rdi,rsi
       mov       rsi,77082FDB0148
       call      qword ptr [77082F24F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M01_L00
M01_L08:
       mov       rdi,rbx
       mov       rsi,77082FDB13B8
       call      qword ptr [77082F24F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r15,rax
       jmp       short M01_L04
M01_L09:
       mov       rdi,[rsi+18]
       test      rdi,rdi
       je        near ptr M01_L01
       mov       rdi,[rdi+8]
       cmp       [rdi],edi
       call      qword ptr [77082FD2D5F0]; System.Threading.AsyncLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       test      rax,rax
       je        near ptr M01_L01
       call      qword ptr [77082FE74C00]
       mov       rdi,rax
       mov       rdx,76F86CC01498
       mov       rdx,[rdx]
       mov       rsi,77081E40C6F8
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rdi,rax
       xor       eax,eax
       test      rdi,rdi
       cmove     rdi,rax
       call      qword ptr [77082FD2D350]
       int       3
M01_L10:
       mov       rdi,[rsi+8]
       call      qword ptr [77082FD2D368]; System.Threading.Monitor.IsEntered(System.Object)
       test      eax,eax
       je        short M01_L11
       call      qword ptr [77082FE74C00]
       mov       rdi,rax
       mov       rdx,76F86CC01498
       mov       rdx,[rdx]
       mov       rsi,77081E40C6F8
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rdi,rax
       xor       eax,eax
       test      rdi,rdi
       cmove     rdi,rax
       call      qword ptr [77082FD2D350]
       int       3
M01_L11:
       xor       esi,esi
       mov       [r15+10],rsi
       mov       rsi,[rbp-48]
       mov       rdi,[rsi+8]
       mov       [rbp-50],rdi
       xor       edi,edi
       mov       [rbp-38],edi
       lea       rsi,[rbp-38]
       mov       rdi,[rbp-50]
       call      qword ptr [77082F245980]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rsi,[rbp-48]
       cmp       qword ptr [rsi+28],0
       jne       near ptr M01_L29
       lea       rdi,[rbp-30]
       call      qword ptr [77082FD27960]; System.Threading.CancellationToken.get_IsCancellationRequested()
       test      eax,eax
       je        short M01_L12
       lea       rdi,[rbp-30]
       call      qword ptr [77082FE74C18]
       int       3
M01_L12:
       mov       rdi,offset MT_Microsoft.VisualStudio.Threading.InlineResumable
       call      CORINFO_HELP_NEWSFAST
       lea       rdi,[r15+10]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-48]
       mov       rsi,[rsi+20]
       lea       rdi,[r15+18]
       call      CORINFO_HELP_ASSIGN_REF
       xor       edi,edi
       mov       rsi,[rbp-48]
       mov       [rsi+20],rdi
       mov       rdi,[rbx+30]
       mov       rdi,[rdi]
       mov       rdi,[rdi+28]
       test      rdi,rdi
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rdi,rbx
       mov       rsi,77082FDB1630
       call      qword ptr [77082F24F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M01_L14:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdi,r14
       mov       rsi,r15
       mov       rdx,offset Microsoft.VisualStudio.Threading.AsyncLazy`1+<>c__DisplayClass20_0[[System.__Canon, System.Private.CoreLib]].<GetValueAsync>b__0()
       call      qword ptr [77082F246E08]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rsi,[rbp-48]
       cmp       byte ptr [rsi+38],0
       jne       near ptr M01_L18
       cmp       qword ptr [rsi+18],0
       je        short M01_L15
       mov       rdi,77082FE5B3B8
       call      qword ptr [77082FD2D5A8]
M01_L15:
       mov       rdi,offset MT_Microsoft.VisualStudio.Threading.AsyncLocal<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdi,r13
       call      qword ptr [77082FD2D3C8]; Microsoft.VisualStudio.Threading.AsyncLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rdi,[rbx+30]
       mov       rdi,[rdi]
       mov       rdi,[rdi+38]
       test      rdi,rdi
       je        short M01_L16
       jmp       short M01_L17
M01_L16:
       mov       rdi,rbx
       mov       rsi,77082FDB1A70
       call      qword ptr [77082F24F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M01_L17:
       call      qword ptr [77082F245710]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rsi,[rax]
       mov       rdi,[r13+8]
       cmp       [rdi],edi
       call      qword ptr [77082FD2D620]; System.Threading.AsyncLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
       mov       rsi,[rbp-48]
       lea       rdi,[rsi+18]
       mov       rsi,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-48]
M01_L18:
       cmp       qword ptr [rsi+10],0
       je        near ptr M01_L25
       mov       rdi,[rbx+30]
       mov       rdi,[rdi]
       mov       rdi,[rdi+30]
       test      rdi,rdi
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rdi,rbx
       mov       rsi,77082FDB16E0
       call      qword ptr [77082F24F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M01_L20:
       mov       rsi,[rbp-48]
       mov       r13,[rsi+10]
       cmp       [r13],r13b
       mov       rax,[rdi+18]
       mov       rax,[rax+10]
       test      rax,rax
       je        short M01_L21
       jmp       short M01_L22
M01_L21:
       mov       rsi,77082FE47540
       call      qword ptr [77082F24F3A8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
M01_L22:
       mov       rdi,r13
       mov       rsi,rax
       mov       rdx,r14
       xor       ecx,ecx
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [77082FE74B58]
       mov       rsi,[rbp-48]
       lea       rdi,[rsi+30]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       lock or   dword ptr [rsp],0
       mov       rsi,[rbp-48]
       mov       r14,[rsi+30]
       mov       rdi,[r14]
       mov       rax,[rdi+30]
       mov       rax,[rax]
       mov       r13,[rax+10]
       test      r13,r13
       je        short M01_L23
       jmp       short M01_L24
M01_L23:
       mov       rsi,77082FE475D8
       call      qword ptr [77082F24F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r13,rax
M01_L24:
       mov       rdi,r14
       call      qword ptr [77082FE74C30]
       mov       rsi,rax
       mov       rdi,r13
       call      qword ptr [77082F246310]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rsi,[rbp-48]
       lea       rdi,[rsi+28]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L27
M01_L25:
       mov       rdi,[r14+8]
       call      qword ptr [r14+18]
       mov       rsi,[rbp-48]
       lea       rdi,[rsi+28]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L27
M01_L26:
       mov       rdi,[rsi+18]
       mov       rdi,[rdi+8]
       xor       esi,esi
       cmp       [rdi],edi
       call      qword ptr [77082FD2D620]; System.Threading.AsyncLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
       jmp       short M01_L29
M01_L27:
       mov       rsi,[rbp-48]
       cmp       qword ptr [rsi+18],0
       je        short M01_L29
       jmp       short M01_L26
M01_L28:
       mov       rdi,[rbp-50]
       call      qword ptr [77082F246808]; System.Threading.Monitor.Exit(System.Object)
       jmp       short M01_L30
M01_L29:
       cmp       byte ptr [rbp-38],0
       jne       short M01_L28
M01_L30:
       mov       rdi,[r15+10]
       test      rdi,rdi
       je        near ptr M01_L02
       call      qword ptr [77082FD2D428]; Microsoft.VisualStudio.Threading.InlineResumable.Resume()
       jmp       near ptr M01_L02
M01_L31:
       mov       rdx,[rbp-30]
       xor       esi,esi
       call      qword ptr [77082FD2D440]
       jmp       near ptr M01_L03
M01_L32:
       mov       rdi,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       edi,170F
       mov       rsi,77082FD576B0
       call      qword ptr [77082F24EF88]
       mov       rsi,rax
       mov       rdi,rbx
       call      qword ptr [77082FAAE1C0]
       mov       rdi,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L33:
       test      dword ptr [rbx+34],1600000
       jne       near ptr M01_L05
       lea       rdi,[rbp-40]
       call      qword ptr [77082FD27960]; System.Threading.CancellationToken.get_IsCancellationRequested()
       test      eax,eax
       je        short M01_L36
       mov       rdi,[r15+18]
       mov       rdi,[rdi+20]
       test      rdi,rdi
       je        short M01_L34
       jmp       short M01_L35
M01_L34:
       mov       rdi,r15
       mov       rsi,77082FDBA8F8
       call      qword ptr [77082F24F3A8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdi,rax
M01_L35:
       mov       rsi,[rbp-40]
       call      qword ptr [77082FD27918]
       jmp       near ptr M01_L06
M01_L36:
       mov       rdi,[r15+18]
       mov       rdi,[rdi+18]
       test      rdi,rdi
       je        short M01_L37
       jmp       short M01_L38
M01_L37:
       mov       rdi,r15
       mov       rsi,77082FDBA8C0
       call      qword ptr [77082F24F3A8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdi,rax
M01_L38:
       mov       rsi,rbx
       mov       rdx,[rbp-40]
       call      qword ptr [77082FD2F0D8]
       jmp       near ptr M01_L06
       push      rax
       mov       rsi,[rbp-48]
       mov       rdi,[rsi+18]
       test      rdi,rdi
       je        short M01_L39
       mov       rdi,[rdi+8]
       xor       esi,esi
       cmp       [rdi],edi
       call      qword ptr [77082FD2D620]; System.Threading.AsyncLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
M01_L39:
       nop
       add       rsp,8
       ret
       push      rax
       cmp       byte ptr [rbp-38],0
       je        short M01_L40
       mov       rdi,[rbp-50]
       call      qword ptr [77082F246808]; System.Threading.Monitor.Exit(System.Object)
M01_L40:
       nop
       add       rsp,8
       ret
; Total bytes of code 1389
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.HotPathBenchmarks`1[[System.__Canon, System.Private.CoreLib]].LazyOfTask_Token()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rbx
       sub       rsp,10
       lea       rbp,[rsp+30]
       mov       [rbp-28],rdi
       mov       rbx,rdi
       mov       rdi,[rbx+10]
       cmp       qword ptr [rdi+8],0
       jne       near ptr M00_L08
       mov       r15,[rdi+18]
M00_L00:
       mov       r14,[rbx+8]
       cmp       byte ptr [r14+24],0
       jne       near ptr M00_L09
       test      dword ptr [r15+34],1600000
       jne       near ptr M00_L06
       cmp       dword ptr [r14+20],0
       jne       short M00_L03
       mov       rdi,[r15]
       mov       rsi,[rdi+30]
       mov       rsi,[rsi]
       mov       rsi,[rsi+40]
       test      rsi,rsi
       je        short M00_L02
M00_L01:
       mov       rdi,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,736F24C01480
       mov       rcx,[rcx]
       mov       rdi,r13
       mov       rsi,r15
       mov       r8,r14
       mov       edx,0FFFFFFFF
       call      qword ptr [737EE6654BE8]
       jmp       short M00_L07
M00_L02:
       mov       rsi,737EE66269D0
       call      qword ptr [737EE5A2F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       short M00_L01
M00_L03:
       mov       rdi,[r15]
       mov       rsi,[rdi+30]
       mov       rsi,[rsi]
       mov       rax,[rsi+48]
       test      rax,rax
       je        short M00_L05
       mov       rdi,rax
M00_L04:
       mov       rsi,r14
       add       rsp,10
       pop       rbx
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [737EE6507918]
M00_L05:
       mov       rsi,737EE66269F8
       call      qword ptr [737EE5A2F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       short M00_L04
M00_L06:
       mov       r13,r15
M00_L07:
       mov       rax,r13
       add       rsp,10
       pop       rbx
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L08:
       call      qword ptr [737EE628C438]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       r15,rax
       jmp       near ptr M00_L00
M00_L09:
       mov       edi,46
       call      qword ptr [737EE6654B70]
       int       3
; Total bytes of code 274
```
```assembly
; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0B0]
       mov       rdx,rsi
       mov       [rbp-8C],rdx
       mov       rsi,rdi
       mov       [rbp-94],rsi
       xor       edi,edi
       mov       [rbp-9C],rdi
       mov       ecx,0FFFFFFFF
       mov       [rbp-84],ecx
       xor       r8d,r8d
       mov       [rbp-0A4],r8
       lea       rdi,[rbp-80]
       call      qword ptr [737EE55CEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdx,[rbp-8C]
       mov       rsi,[rbp-94]
       mov       rdi,[rbp-9C]
       mov       ecx,[rbp-84]
       mov       r8,[rbp-0A4]
       call      qword ptr [rax]
       mov       rbx,rax
       lea       rdi,[rbp-80]
       call      qword ptr [737EE55CEF08]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rax,rbx
       add       rsp,88
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 162
```
```assembly
; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       push      rbp
       push      r15
       push      rbx
       sub       rsp,10
       lea       rbp,[rsp+20]
       mov       [rbp-18],rdi
       mov       rbx,rdi
M02_L00:
       mov       r15,[rbx+8]
       test      r15,r15
       je        short M02_L01
       mov       edi,[r15+10]
       cmp       edi,8
       jne       short M02_L03
       mov       rdi,rbx
       mov       rsi,r15
       xor       edx,edx
       call      qword ptr [737EE55F2688]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
M02_L01:
       cmp       qword ptr [rbx+8],0
       jne       short M02_L02
       mov       rax,[rbx+18]
       add       rsp,10
       pop       rbx
       pop       r15
       pop       rbp
       ret
M02_L02:
       mov       rdi,rbx
       lea       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       add       rsp,10
       pop       rbx
       pop       r15
       pop       rbp
       jmp       qword ptr [rax]
M02_L03:
       cmp       edi,8
       ja        short M02_L04
       mov       edi,edi
       lea       rsi,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       esi,[rsi+rdi*4]
       lea       rdx,[M02_L00]
       add       rsi,rdx
       jmp       rsi
M02_L04:
       mov       rdi,[r15+8]
       cmp       [rdi],edi
       call      qword ptr [737EE55E9630]
       int       3
       mov       rdi,rbx
       call      qword ptr [737EE55F2678]
       jmp       short M02_L01
       mov       rdi,rbx
       xor       esi,esi
       call      qword ptr [737EE55F2680]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M02_L01
       mov       rdi,[rbx]
       call      qword ptr [737EE55D14E0]
       mov       rdi,rax
       call      qword ptr [737EE55D8728]
       mov       rdi,rax
       call      qword ptr [737EE55F81A8]
       mov       rdx,rax
       mov       rsi,r15
       mov       rdi,rbx
       call      qword ptr [737EE55F2690]
       jmp       near ptr M02_L01
       mov       rax,[rbx+10]
       test      rax,rax
       je        short M02_L05
       mov       rdi,[rax+8]
       call      qword ptr [rax+18]
       mov       rdx,rax
       mov       rsi,r15
       mov       rdi,rbx
       call      qword ptr [737EE55F2690]
       jmp       near ptr M02_L01
M02_L05:
       mov       rdi,rbx
       call      qword ptr [737EE55F26A0]
       jmp       near ptr M02_L01
       mov       rdi,rbx
       mov       rsi,r15
       mov       edx,1
       call      qword ptr [737EE55F2688]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M02_L01
; Total bytes of code 278
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.HotPathBenchmarks`1[[System.__Canon, System.Private.CoreLib]].AsyncLazy_Token()
       push      rbp
       push      r15
       push      rbx
       sub       rsp,10
       lea       rbp,[rsp+20]
       mov       [rbp-18],rdi
       mov       rbx,rdi
       mov       rdi,[rbx+18]
       mov       r15,[rbx+8]
       cmp       byte ptr [r15+24],0
       jne       short M00_L00
       cmp       [rdi],dil
       cmp       dword ptr [r15+20],0
       jne       short M00_L01
       mov       rax,[rdi+10]
       test      rax,rax
       je        short M00_L04
       add       rsp,10
       pop       rbx
       pop       r15
       pop       rbp
       ret
M00_L00:
       mov       edi,46
       call      qword ptr [7455A4C84B40]
       int       3
M00_L01:
       mov       rdi,[rdi]
       mov       rsi,[rdi+30]
       mov       rsi,[rsi]
       mov       rax,[rsi+10]
       test      rax,rax
       je        short M00_L02
       mov       rdi,rax
       jmp       short M00_L03
M00_L02:
       mov       rsi,7455A4B992A0
       call      qword ptr [7455A405F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M00_L03:
       mov       rsi,r15
       add       rsp,10
       pop       rbx
       pop       r15
       pop       rbp
       jmp       qword ptr [7455A4B37918]
M00_L04:
       mov       rsi,r15
       add       rsp,10
       pop       rbx
       pop       r15
       pop       rbp
       jmp       qword ptr [7455A4B37978]; System.Threading.Tasks.AsyncLazy`1[[System.__Canon, System.Private.CoreLib]].GetOrStartAttemptAsync(System.Threading.CancellationToken)
; Total bytes of code 152
```
```assembly
; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0B0]
       mov       rdx,rsi
       mov       [rbp-8C],rdx
       mov       rsi,rdi
       mov       [rbp-94],rsi
       xor       edi,edi
       mov       [rbp-9C],rdi
       mov       ecx,0FFFFFFFF
       mov       [rbp-84],ecx
       xor       r8d,r8d
       mov       [rbp-0A4],r8
       lea       rdi,[rbp-80]
       call      qword ptr [7455A3BFEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdx,[rbp-8C]
       mov       rsi,[rbp-94]
       mov       rdi,[rbp-9C]
       mov       ecx,[rbp-84]
       mov       r8,[rbp-0A4]
       call      qword ptr [rax]
       mov       rbx,rax
       lea       rdi,[rbp-80]
       call      qword ptr [7455A3BFEF08]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rax,rbx
       add       rsp,88
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 162
```
```assembly
; System.Threading.Tasks.AsyncLazy`1[[System.__Canon, System.Private.CoreLib]].GetOrStartAttemptAsync(System.Threading.CancellationToken)
       push      rbp
       sub       rsp,1A0
       lea       rbp,[rsp+1A0]
       vxorps    xmm8,xmm8,xmm8
       vmovdqu32 [rbp-0F0],zmm8
       vmovdqu32 [rbp-0B0],zmm8
       vmovdqu32 [rbp-80],zmm8
       mov       [rbp-30],rdi
       mov       [rbp-38],rdi
       mov       [rbp-40],rsi
       mov       dword ptr [rbp-0E0],3E8
M02_L00:
       mov       eax,[rbp-0E0]
       dec       eax
       mov       [rbp-0E0],eax
       cmp       dword ptr [rbp-0E0],0
       jg        short M02_L01
       lea       rdi,[rbp-0E0]
       xor       esi,esi
       call      CORINFO_HELP_PATCHPOINT
M02_L01:
       mov       rax,[rbp-38]
       mov       rax,[rax+8]
       mov       [rbp-48],rax
       mov       rax,[rbp-38]
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
       mov       rdi,[rbp-0F8]
       mov       rsi,7455A4B99498
       call      qword ptr [7455A405F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-68],rax
M02_L03:
       mov       rdi,[rbp-68]
       mov       rsi,[rbp-48]
       call      qword ptr [7455A4056838]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       [rbp-50],rax
       cmp       qword ptr [rbp-50],0
       je        short M02_L04
       mov       rdi,7455A4BA0098
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-50]
       mov       [rbp-0E8],rax
       jmp       near ptr M02_L28
M02_L04:
       mov       rax,[rbp-38]
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
       mov       rdi,[rbp-108]
       mov       rsi,7455A4B994A8
       call      qword ptr [7455A405F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-70],rax
M02_L06:
       mov       rdi,[rbp-70]
       mov       rsi,[rbp-48]
       call      qword ptr [7455A4056838]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       [rbp-58],rax
       cmp       qword ptr [rbp-58],0
       je        near ptr M02_L10
       mov       rdi,[rbp-58]
       call      qword ptr [7455A4B37A50]
       test      eax,eax
       je        near ptr M02_L09
       mov       rdi,7455A4BA009C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdi,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0D0],rax
       mov       rdi,[rbp-0D0]
       mov       rsi,7455A0407850
       call      qword ptr [7455A48B5260]
       mov       rax,[rbp-38]
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
       mov       rdi,[rbp-118]
       mov       rsi,7455A4B9BEA0
       call      qword ptr [7455A405F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-0D8],rax
M02_L08:
       mov       rdi,[rbp-0D8]
       mov       rsi,[rbp-0D0]
       call      qword ptr [7455A4B379F0]; System.Threading.Tasks.Task.FromException[[System.__Canon, System.Private.CoreLib]](System.Exception)
       mov       [rbp-0E8],rax
       jmp       near ptr M02_L28
M02_L09:
       mov       rdi,7455A4BA00A0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdi,[rbp-58]
       mov       rsi,[rbp-40]
       cmp       [rdi],edi
       call      qword ptr [7455A4B37A68]; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.__Canon, System.Private.CoreLib]].WaitAsync(System.Threading.CancellationToken)
       mov       [rbp-0E8],rax
       jmp       near ptr M02_L28
M02_L10:
       mov       rax,[rbp-38]
       cmp       [rax],al
       mov       rax,[rbp-38]
       lea       rdi,[rax+20]
       call      qword ptr [7455A4B37960]; System.Threading.CancellationToken.get_IsCancellationRequested()
       test      eax,eax
       je        near ptr M02_L13
       mov       rdi,7455A4BA00A4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-38]
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
       mov       rdi,[rbp-130]
       mov       rsi,7455A4B992A0
       call      qword ptr [7455A405F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-0C8],rax
M02_L12:
       mov       rax,[rbp-38]
       mov       rsi,[rax+20]
       mov       rdi,[rbp-0C8]
       call      qword ptr [7455A4B37918]
       mov       [rbp-0E8],rax
       jmp       near ptr M02_L28
M02_L13:
       mov       rax,[rbp-38]
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
       mov       rdi,[rbp-140]
       mov       rsi,7455A4B994A8
       call      qword ptr [7455A405F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-80],rax
M02_L15:
       mov       rdi,[rbp-80]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-78],rax
       mov       rdi,[rbp-78]
       mov       rsi,[rbp-38]
       call      qword ptr [7455A4B37A80]; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.__Canon, System.Private.CoreLib]]..ctor(System.Threading.Tasks.AsyncLazy`1<System.__Canon>)
       mov       rax,[rbp-78]
       mov       [rbp-60],rax
       mov       rax,[rbp-38]
       cmp       [rax],al
       mov       rax,[rbp-38]
       lea       rdi,[rax+8]
       mov       rsi,[rbp-60]
       xor       edx,edx
       call      qword ptr [7455A4B37A98]; System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       jne       near ptr M02_L27
       mov       rax,[rbp-38]
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
       mov       rdi,[rbp-150]
       mov       rsi,7455A4B99798
       call      qword ptr [7455A405F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-88],rax
M02_L17:
       mov       rdi,[rbp-88]
       call      qword ptr [7455A4055710]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rax+8]
       mov       [rbp-90],rax
       mov       rax,[rbp-90]
       mov       [rbp-98],rax
       cmp       qword ptr [rbp-90],0
       jne       near ptr M02_L24
       mov       rdi,7455A4BA00A8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-38]
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
       mov       rdi,[rbp-160]
       mov       rsi,7455A4B99798
       call      qword ptr [7455A405F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-0A8],rax
M02_L19:
       mov       rax,[rbp-38]
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
       mov       rdi,[rbp-170]
       mov       rsi,7455A4B9BDA8
       call      qword ptr [7455A405F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-0B8],rax
M02_L21:
       mov       rdi,[rbp-0B8]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0B0],rax
       mov       rdi,[rbp-0A8]
       call      qword ptr [7455A4055710]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rax]
       mov       [rbp-0F0],rax
       mov       rsi,[rbp-0F0]
       mov       rdi,[rbp-0B0]
       mov       rdx,offset System.Threading.Tasks.AsyncLazy`1+<>c[[System.__Canon, System.Private.CoreLib]].<GetOrStartAttemptAsync>b__11_0(Attempt<System.__Canon>)
       call      qword ptr [7455A4056E08]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rax,[rbp-38]
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
       mov       rdi,[rbp-188]
       mov       rsi,7455A4B99798
       call      qword ptr [7455A405F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-0C0],rax
M02_L23:
       mov       rdi,[rbp-0C0]
       call      qword ptr [7455A4055710]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       lea       rdi,[rax+8]
       mov       rsi,[rbp-0B0]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-0B0]
       mov       [rbp-98],rax
M02_L24:
       mov       rdi,7455A4BA00AC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-38]
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
       mov       rdi,[rbp-198]
       mov       rsi,7455A4B9BCC0
       call      qword ptr [7455A405F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       [rbp-0A0],rax
M02_L26:
       mov       rdi,[rbp-0A0]
       mov       rsi,[rbp-98]
       mov       rdx,[rbp-60]
       xor       ecx,ecx
       call      qword ptr [7455A4B379A8]; System.Threading.ThreadPool.QueueUserWorkItem[[System.__Canon, System.Private.CoreLib]](System.Action`1<System.__Canon>, System.__Canon, Boolean)
       mov       rdi,[rbp-60]
       mov       rsi,[rbp-40]
       cmp       [rdi],edi
       call      qword ptr [7455A4B37A68]; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.__Canon, System.Private.CoreLib]].WaitAsync(System.Threading.CancellationToken)
       mov       [rbp-0E8],rax
       jmp       short M02_L28
M02_L27:
       mov       rdi,7455A4BA00B0
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M02_L00
M02_L28:
       mov       rax,[rbp-0E8]
       add       rsp,1A0
       pop       rbp
       ret
; Total bytes of code 1775
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.HotPathBenchmarks`1[[System.__Canon, System.Private.CoreLib]].Nito_Token()
       push      rbp
       push      r15
       push      r14
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       [rbp-20],rdi
       mov       [rbp-30],rdi
       mov       rbx,[rdi+20]
       mov       rsi,[rbx+8]
       mov       [rbp-38],rsi
       xor       eax,eax
       mov       [rbp-24],eax
       test      rsi,rsi
       je        short M00_L01
       mov       rdi,rsi
       call      00007F9FB34E6020
       test      eax,eax
       je        short M00_L02
M00_L00:
       mov       dword ptr [rbp-24],1
       mov       rdi,[rbx+18]
       cmp       qword ptr [rdi+8],0
       jne       short M00_L03
       mov       rbx,[rdi+18]
       jmp       short M00_L04
M00_L01:
       xor       edi,edi
       call      qword ptr [7F9F35E74BA0]
       int       3
M00_L02:
       mov       rdi,[rbp-38]
       call      qword ptr [7F9F35DEED18]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L00
M00_L03:
       call      qword ptr [7F9F35AAC438]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rbx,rax
M00_L04:
       mov       rdi,[rbp-38]
       call      00007F9FB34E6790
       test      eax,eax
       jne       near ptr M00_L13
M00_L05:
       mov       rdi,[rbp-30]
       mov       r15,[rdi+8]
       cmp       byte ptr [r15+24],0
       jne       near ptr M00_L14
       test      dword ptr [rbx+34],1600000
       jne       near ptr M00_L11
       cmp       dword ptr [r15+20],0
       jne       short M00_L08
       mov       rsi,[rbx]
       mov       rax,[rsi+30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       test      rax,rax
       je        short M00_L07
M00_L06:
       mov       rdi,rax
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,7F8F70C01480
       mov       rcx,[rcx]
       mov       rdi,r14
       mov       rsi,rbx
       mov       r8,r15
       mov       edx,0FFFFFFFF
       call      qword ptr [7F9F35E74C48]
       jmp       short M00_L12
M00_L07:
       mov       rdi,rsi
       mov       rsi,7F9F35E46A80
       call      qword ptr [7F9F3524F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       short M00_L06
M00_L08:
       mov       rsi,[rbx]
       mov       rax,[rsi+30]
       mov       rax,[rax]
       mov       rax,[rax+48]
       test      rax,rax
       je        short M00_L10
M00_L09:
       mov       rdi,rax
       mov       rsi,r15
       add       rsp,28
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7F9F35D27918]
M00_L10:
       mov       rdi,rsi
       mov       rsi,7F9F35E46AA8
       call      qword ptr [7F9F3524F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       short M00_L09
M00_L11:
       mov       r14,rbx
M00_L12:
       mov       rax,r14
       add       rsp,28
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L13:
       mov       edi,eax
       mov       rsi,[rbp-38]
       call      qword ptr [7F9F35E74BB8]
       jmp       near ptr M00_L05
M00_L14:
       mov       edi,46
       call      qword ptr [7F9F35E74BD0]
       int       3
       push      rax
       cmp       dword ptr [rbp-24],0
       je        short M00_L16
       cmp       qword ptr [rbp-38],0
       jne       short M00_L15
       xor       edi,edi
       call      qword ptr [7F9F35E74BA0]
       int       3
M00_L15:
       mov       rdi,[rbp-38]
       call      00007F9FB34E6790
       test      eax,eax
       je        short M00_L16
       mov       edi,eax
       mov       rsi,[rbp-38]
       call      qword ptr [7F9F35E74BB8]
M00_L16:
       nop
       add       rsp,8
       ret
; Total bytes of code 415
```
```assembly
; System.Threading.Monitor.Enter_Slowpath(System.Object)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rbx
       sub       rsp,68
       lea       rbp,[rsp+90]
       mov       [rbp-30],rdi
       lea       rdi,[rbp-30]
       mov       [rbp-90],rdi
       lea       rdi,[rbp-88]
       call      qword ptr [7F9F34DEEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdi,[rbp-90]
       call      qword ptr [rax]
       lea       rdi,[rbp-88]
       call      qword ptr [7F9F34DEEF08]; CORINFO_HELP_JIT_PINVOKE_END
       nop
       add       rsp,68
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 95
```
```assembly
; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       push      rbp
       push      r15
       push      rbx
       sub       rsp,10
       lea       rbp,[rsp+20]
       mov       [rbp-18],rdi
       mov       rbx,rdi
M02_L00:
       mov       r15,[rbx+8]
       test      r15,r15
       je        short M02_L01
       mov       edi,[r15+10]
       cmp       edi,8
       jne       short M02_L03
       mov       rdi,rbx
       mov       rsi,r15
       xor       edx,edx
       call      qword ptr [7F9F34E12688]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
M02_L01:
       cmp       qword ptr [rbx+8],0
       jne       short M02_L02
       mov       rax,[rbx+18]
       add       rsp,10
       pop       rbx
       pop       r15
       pop       rbp
       ret
M02_L02:
       mov       rdi,rbx
       lea       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       add       rsp,10
       pop       rbx
       pop       r15
       pop       rbp
       jmp       qword ptr [rax]
M02_L03:
       cmp       edi,8
       ja        short M02_L04
       mov       edi,edi
       lea       rsi,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       esi,[rsi+rdi*4]
       lea       rdx,[M02_L00]
       add       rsi,rdx
       jmp       rsi
M02_L04:
       mov       rdi,[r15+8]
       cmp       [rdi],edi
       call      qword ptr [7F9F34E09630]
       int       3
       mov       rdi,rbx
       call      qword ptr [7F9F34E12678]
       jmp       short M02_L01
       mov       rdi,rbx
       xor       esi,esi
       call      qword ptr [7F9F34E12680]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M02_L01
       mov       rdi,[rbx]
       call      qword ptr [7F9F34DF14E0]
       mov       rdi,rax
       call      qword ptr [7F9F34DF8728]
       mov       rdi,rax
       call      qword ptr [7F9F34E181A8]
       mov       rdx,rax
       mov       rsi,r15
       mov       rdi,rbx
       call      qword ptr [7F9F34E12690]
       jmp       near ptr M02_L01
       mov       rax,[rbx+10]
       test      rax,rax
       je        short M02_L05
       mov       rdi,[rax+8]
       call      qword ptr [rax+18]
       mov       rdx,rax
       mov       rsi,r15
       mov       rdi,rbx
       call      qword ptr [7F9F34E12690]
       jmp       near ptr M02_L01
M02_L05:
       mov       rdi,rbx
       call      qword ptr [7F9F34E126A0]
       jmp       near ptr M02_L01
       mov       rdi,rbx
       mov       rsi,r15
       mov       edx,1
       call      qword ptr [7F9F34E12688]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M02_L01
; Total bytes of code 278
```
```assembly
; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0B0]
       mov       rdx,rsi
       mov       [rbp-8C],rdx
       mov       rsi,rdi
       mov       [rbp-94],rsi
       xor       edi,edi
       mov       [rbp-9C],rdi
       mov       ecx,0FFFFFFFF
       mov       [rbp-84],ecx
       xor       r8d,r8d
       mov       [rbp-0A4],r8
       lea       rdi,[rbp-80]
       call      qword ptr [7F9F34DEEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdx,[rbp-8C]
       mov       rsi,[rbp-94]
       mov       rdi,[rbp-9C]
       mov       ecx,[rbp-84]
       mov       r8,[rbp-0A4]
       call      qword ptr [rax]
       mov       rbx,rax
       lea       rdi,[rbp-80]
       call      qword ptr [7F9F34DEEF08]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rax,rbx
       add       rsp,88
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 162
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.HotPathBenchmarks`1[[System.__Canon, System.Private.CoreLib]].VsThreading_Token()
       push      rax
       mov       rsi,[rdi+28]
       mov       rax,[rdi+8]
       cmp       byte ptr [rax+24],0
       jne       short M00_L00
       mov       rdi,rsi
       mov       rsi,rax
       cmp       [rdi],edi
       add       rsp,8
       jmp       qword ptr [71301070CA68]; Microsoft.VisualStudio.Threading.AsyncLazy`1[[System.__Canon, System.Private.CoreLib]].GetValueAsync(System.Threading.CancellationToken)
M00_L00:
       mov       edi,46
       call      qword ptr [713010854B40]
       int       3
; Total bytes of code 45
```
```assembly
; Microsoft.VisualStudio.Threading.AsyncLazy`1[[System.__Canon, System.Private.CoreLib]].GetValueAsync(System.Threading.CancellationToken)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-38],rax
       mov       [rbp-40],rax
       mov       [rbp-28],rdi
       mov       [rbp-48],rdi
       mov       [rbp-30],rsi
       mov       rbx,[rdi]
       mov       rsi,rbx
       mov       rax,[rsi+30]
       mov       rax,[rax]
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M01_L07
M01_L00:
       mov       rdi,rax
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rdi,[r15+8]
       mov       rsi,[rbp-48]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-48]
       mov       rdi,[rsi+28]
       test      rdi,rdi
       je        near ptr M01_L09
       test      dword ptr [rdi+34],1600000
       je        near ptr M01_L09
M01_L01:
       mov       rsi,[rbp-48]
       cmp       qword ptr [rsi+28],0
       je        near ptr M01_L10
M01_L02:
       mov       rsi,[rbp-48]
       lock or   dword ptr [rsp],0
       mov       rdi,[rsi+30]
       test      rdi,rdi
       jne       near ptr M01_L31
       xor       eax,eax
M01_L03:
       test      rax,rax
       jne       short M01_L06
       mov       rdi,[rbx+30]
       mov       rdi,[rdi]
       mov       r15,[rdi+20]
       test      r15,r15
       je        short M01_L08
M01_L04:
       mov       rsi,[rbp-48]
       mov       rbx,[rsi+28]
       mov       rdi,[rbp-30]
       mov       [rbp-40],rdi
       test      rbx,rbx
       je        near ptr M01_L32
       cmp       qword ptr [rbp-40],0
       je        short M01_L05
       test      dword ptr [rbx+34],1600000
       je        near ptr M01_L33
M01_L05:
       mov       rax,rbx
M01_L06:
       add       rsp,30
       pop       rbx
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L07:
       mov       rdi,rsi
       mov       rsi,713010790520
       call      qword ptr [71300FC2F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M01_L00
M01_L08:
       mov       rdi,rbx
       mov       rsi,713010791750
       call      qword ptr [71300FC2F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r15,rax
       jmp       short M01_L04
M01_L09:
       mov       rdi,[rsi+18]
       test      rdi,rdi
       je        near ptr M01_L01
       mov       rdi,[rdi+8]
       cmp       [rdi],edi
       call      qword ptr [71301070D5C0]; System.Threading.AsyncLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       test      rax,rax
       je        near ptr M01_L01
       call      qword ptr [713010854C78]
       mov       rdi,rax
       mov       rdx,71204CC014B0
       mov       rdx,[rdx]
       mov       rsi,71202700C6F8
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rdi,rax
       xor       eax,eax
       test      rdi,rdi
       cmove     rdi,rax
       call      qword ptr [71301070D4B8]
       int       3
M01_L10:
       mov       rdi,[rsi+8]
       call      qword ptr [71301070D4D0]; System.Threading.Monitor.IsEntered(System.Object)
       test      eax,eax
       je        short M01_L11
       call      qword ptr [713010854C78]
       mov       rdi,rax
       mov       rdx,71204CC014B0
       mov       rdx,[rdx]
       mov       rsi,71202700C6F8
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rdi,rax
       xor       eax,eax
       test      rdi,rdi
       cmove     rdi,rax
       call      qword ptr [71301070D4B8]
       int       3
M01_L11:
       xor       esi,esi
       mov       [r15+10],rsi
       mov       rsi,[rbp-48]
       mov       rdi,[rsi+8]
       mov       [rbp-50],rdi
       xor       edi,edi
       mov       [rbp-38],edi
       lea       rsi,[rbp-38]
       mov       rdi,[rbp-50]
       call      qword ptr [71300FC25980]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rsi,[rbp-48]
       cmp       qword ptr [rsi+28],0
       jne       near ptr M01_L29
       lea       rdi,[rbp-30]
       call      qword ptr [713010707960]; System.Threading.CancellationToken.get_IsCancellationRequested()
       test      eax,eax
       je        short M01_L12
       lea       rdi,[rbp-30]
       call      qword ptr [713010854C90]
       int       3
M01_L12:
       mov       rdi,offset MT_Microsoft.VisualStudio.Threading.InlineResumable
       call      CORINFO_HELP_NEWSFAST
       lea       rdi,[r15+10]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-48]
       mov       rsi,[rsi+20]
       lea       rdi,[r15+18]
       call      CORINFO_HELP_ASSIGN_REF
       xor       edi,edi
       mov       rsi,[rbp-48]
       mov       [rsi+20],rdi
       mov       rdi,[rbx+30]
       mov       rdi,[rdi]
       mov       rdi,[rdi+28]
       test      rdi,rdi
       je        short M01_L13
       jmp       short M01_L14
M01_L13:
       mov       rdi,rbx
       mov       rsi,713010791840
       call      qword ptr [71300FC2F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M01_L14:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdi,r14
       mov       rsi,r15
       mov       rdx,offset Microsoft.VisualStudio.Threading.AsyncLazy`1+<>c__DisplayClass20_0[[System.__Canon, System.Private.CoreLib]].<GetValueAsync>b__0()
       call      qword ptr [71300FC26E08]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rsi,[rbp-48]
       cmp       byte ptr [rsi+38],0
       jne       near ptr M01_L18
       cmp       qword ptr [rsi+18],0
       je        short M01_L15
       mov       rdi,71301083B2F8
       call      qword ptr [71301070D6B0]
M01_L15:
       mov       rdi,offset MT_Microsoft.VisualStudio.Threading.AsyncLocal<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdi,r13
       call      qword ptr [71301070D530]; Microsoft.VisualStudio.Threading.AsyncLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rdi,[rbx+30]
       mov       rdi,[rdi]
       mov       rdi,[rdi+38]
       test      rdi,rdi
       je        short M01_L16
       jmp       short M01_L17
M01_L16:
       mov       rdi,rbx
       mov       rsi,713010791D10
       call      qword ptr [71300FC2F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M01_L17:
       call      qword ptr [71300FC25710]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rsi,[rax]
       mov       rdi,[r13+8]
       cmp       [rdi],edi
       call      qword ptr [71301070D5F0]; System.Threading.AsyncLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
       mov       rsi,[rbp-48]
       lea       rdi,[rsi+18]
       mov       rsi,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-48]
M01_L18:
       cmp       qword ptr [rsi+10],0
       je        near ptr M01_L25
       mov       rdi,[rbx+30]
       mov       rdi,[rdi]
       mov       rdi,[rdi+30]
       test      rdi,rdi
       je        short M01_L19
       jmp       short M01_L20
M01_L19:
       mov       rdi,rbx
       mov       rsi,713010791968
       call      qword ptr [71300FC2F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M01_L20:
       mov       rsi,[rbp-48]
       mov       r13,[rsi+10]
       cmp       [r13],r13b
       mov       rax,[rdi+18]
       mov       rax,[rax+10]
       test      rax,rax
       je        short M01_L21
       jmp       short M01_L22
M01_L21:
       mov       rsi,713010827500
       call      qword ptr [71300FC2F3A8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
M01_L22:
       mov       rdi,r13
       mov       rsi,rax
       mov       rdx,r14
       xor       ecx,ecx
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [713010854BD0]
       mov       rsi,[rbp-48]
       lea       rdi,[rsi+30]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       lock or   dword ptr [rsp],0
       mov       rsi,[rbp-48]
       mov       r14,[rsi+30]
       mov       rdi,[r14]
       mov       rax,[rdi+30]
       mov       rax,[rax]
       mov       r13,[rax+10]
       test      r13,r13
       je        short M01_L23
       jmp       short M01_L24
M01_L23:
       mov       rsi,713010827598
       call      qword ptr [71300FC2F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r13,rax
M01_L24:
       mov       rdi,r14
       call      qword ptr [713010854CA8]
       mov       rsi,rax
       mov       rdi,r13
       call      qword ptr [71300FC26310]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rsi,[rbp-48]
       lea       rdi,[rsi+28]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L27
M01_L25:
       mov       rdi,[r14+8]
       call      qword ptr [r14+18]
       mov       rsi,[rbp-48]
       lea       rdi,[rsi+28]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L27
M01_L26:
       mov       rdi,[rsi+18]
       mov       rdi,[rdi+8]
       xor       esi,esi
       cmp       [rdi],edi
       call      qword ptr [71301070D5F0]; System.Threading.AsyncLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
       jmp       short M01_L29
M01_L27:
       mov       rsi,[rbp-48]
       cmp       qword ptr [rsi+18],0
       je        short M01_L29
       jmp       short M01_L26
M01_L28:
       mov       rdi,[rbp-50]
       call      qword ptr [71300FC26808]; System.Threading.Monitor.Exit(System.Object)
       jmp       short M01_L30
M01_L29:
       cmp       byte ptr [rbp-38],0
       jne       short M01_L28
M01_L30:
       mov       rdi,[r15+10]
       test      rdi,rdi
       je        near ptr M01_L02
       call      qword ptr [71301070D590]; Microsoft.VisualStudio.Threading.InlineResumable.Resume()
       jmp       near ptr M01_L02
M01_L31:
       mov       rdx,[rbp-30]
       xor       esi,esi
       call      qword ptr [71301070D5A8]
       jmp       near ptr M01_L03
M01_L32:
       mov       rdi,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       edi,170F
       mov       rsi,7130107376B0
       call      qword ptr [71300FC2EF88]
       mov       rsi,rax
       mov       rdi,rbx
       call      qword ptr [71301048E1C0]
       mov       rdi,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L33:
       lea       rdi,[rbp-40]
       call      qword ptr [713010707960]; System.Threading.CancellationToken.get_IsCancellationRequested()
       test      eax,eax
       je        short M01_L36
       mov       rdi,[r15+18]
       mov       rdi,[rdi+20]
       test      rdi,rdi
       je        short M01_L34
       jmp       short M01_L35
M01_L34:
       mov       rdi,r15
       mov       rsi,71301079A950
       call      qword ptr [71300FC2F3A8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdi,rax
M01_L35:
       mov       rsi,[rbp-40]
       call      qword ptr [713010707918]
       jmp       near ptr M01_L06
M01_L36:
       mov       rdi,[r15+18]
       mov       rdi,[rdi+18]
       test      rdi,rdi
       je        short M01_L37
       jmp       short M01_L38
M01_L37:
       mov       rdi,r15
       mov       rsi,71301079A918
       call      qword ptr [71300FC2F3A8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdi,rax
M01_L38:
       mov       rsi,rbx
       mov       rdx,[rbp-40]
       call      qword ptr [71301070F108]
       jmp       near ptr M01_L06
       push      rax
       mov       rsi,[rbp-48]
       mov       rdi,[rsi+18]
       test      rdi,rdi
       je        short M01_L39
       mov       rdi,[rdi+8]
       xor       esi,esi
       cmp       [rdi],edi
       call      qword ptr [71301070D5F0]; System.Threading.AsyncLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
M01_L39:
       nop
       add       rsp,8
       ret
       push      rax
       cmp       byte ptr [rbp-38],0
       je        short M01_L40
       mov       rdi,[rbp-50]
       call      qword ptr [71300FC26808]; System.Threading.Monitor.Exit(System.Object)
M01_L40:
       nop
       add       rsp,8
       ret
; Total bytes of code 1385
```

