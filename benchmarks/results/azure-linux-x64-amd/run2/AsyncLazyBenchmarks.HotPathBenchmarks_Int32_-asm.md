## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.HotPathBenchmarks`1[[System.Int32, System.Private.CoreLib]].LazyOfTask()
       mov       rdi,[rdi+10]
       cmp       qword ptr [rdi+8],0
       jne       short M00_L00
       mov       rax,[rdi+18]
       ret
M00_L00:
       jmp       qword ptr [7FDF36C7C438]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
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
       call      qword ptr [7FDF35FE2688]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
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
       call      qword ptr [7FDF35FD9630]
       int       3
       mov       rdi,rbx
       call      qword ptr [7FDF35FE2678]
       jmp       short M01_L01
       mov       rdi,rbx
       xor       esi,esi
       call      qword ptr [7FDF35FE2680]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M01_L01
       mov       rdi,[rbx]
       call      qword ptr [7FDF35FC14E0]
       mov       rdi,rax
       call      qword ptr [7FDF35FC8728]
       mov       rdi,rax
       call      qword ptr [7FDF35FE81A8]
       mov       rdx,rax
       mov       rsi,r15
       mov       rdi,rbx
       call      qword ptr [7FDF35FE2690]
       jmp       near ptr M01_L01
       mov       rax,[rbx+10]
       test      rax,rax
       je        short M01_L05
       mov       rdi,[rax+8]
       call      qword ptr [rax+18]
       mov       rdx,rax
       mov       rsi,r15
       mov       rdi,rbx
       call      qword ptr [7FDF35FE2690]
       jmp       near ptr M01_L01
M01_L05:
       mov       rdi,rbx
       call      qword ptr [7FDF35FE26A0]
       jmp       near ptr M01_L01
       mov       rdi,rbx
       mov       rsi,r15
       mov       edx,1
       call      qword ptr [7FDF35FE2688]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M01_L01
; Total bytes of code 278
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.HotPathBenchmarks`1[[System.Int32, System.Private.CoreLib]].AsyncLazy()
       mov       rdi,[rdi+18]
       mov       rax,[rdi+10]
       test      rax,rax
       je        short M00_L00
       ret
M00_L00:
       xor       esi,esi
       jmp       qword ptr [742428B276C0]; System.Threading.Tasks.AsyncLazy`1[[System.Int32, System.Private.CoreLib]].GetOrStartAttemptAsync(System.Threading.CancellationToken)
; Total bytes of code 22
```
```assembly
; System.Threading.Tasks.AsyncLazy`1[[System.Int32, System.Private.CoreLib]].GetOrStartAttemptAsync(System.Threading.CancellationToken)
       push      rbp
       sub       rsp,0B0
       lea       rbp,[rsp+0B0]
       xor       eax,eax
       mov       [rbp-0A8],rax
       vxorps    xmm8,xmm8,xmm8
       vmovdqu   ymmword ptr [rbp-0A0],ymm8
       vmovdqu   ymmword ptr [rbp-80],ymm8
       vmovdqu   ymmword ptr [rbp-60],ymm8
       mov       [rbp-40],rax
       mov       [rbp-30],rdi
       mov       [rbp-38],rsi
       mov       dword ptr [rbp-90],3E8
M01_L00:
       mov       eax,[rbp-90]
       dec       eax
       mov       [rbp-90],eax
       cmp       dword ptr [rbp-90],0
       jg        short M01_L01
       lea       rdi,[rbp-90]
       xor       esi,esi
       call      CORINFO_HELP_PATCHPOINT
M01_L01:
       mov       rax,[rbp-30]
       mov       rax,[rax+8]
       mov       [rbp-40],rax
       mov       rax,[rbp-40]
       mov       [rbp-88],rax
       mov       rdi,[rbp-88]
       mov       rsi,742428B92B20
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-88]
       mov       [rbp-0A0],rax
       mov       rsi,[rbp-0A0]
       mov       rdi,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      qword ptr [742428056838]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       [rbp-48],rax
       cmp       qword ptr [rbp-48],0
       je        short M01_L02
       mov       rdi,742428B92C28
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-48]
       mov       [rbp-98],rax
       jmp       near ptr M01_L08
M01_L02:
       mov       rsi,[rbp-40]
       mov       rdi,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt
       call      qword ptr [742428056838]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       [rbp-50],rax
       cmp       qword ptr [rbp-50],0
       je        near ptr M01_L04
       mov       rdi,[rbp-50]
       call      qword ptr [742428B27780]
       test      eax,eax
       je        short M01_L03
       mov       rdi,742428B92C2C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdi,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-80],rax
       mov       rdi,[rbp-80]
       mov       rsi,742424407798
       call      qword ptr [7424288B5260]
       mov       rdi,[rbp-80]
       call      qword ptr [742428B27738]; System.Threading.Tasks.Task.FromException[[System.Int32, System.Private.CoreLib]](System.Exception)
       mov       [rbp-98],rax
       jmp       near ptr M01_L08
M01_L03:
       mov       rdi,742428B92C30
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdi,[rbp-50]
       mov       rsi,[rbp-38]
       cmp       [rdi],edi
       call      qword ptr [742428B27798]; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.Int32, System.Private.CoreLib]].WaitAsync(System.Threading.CancellationToken)
       mov       [rbp-98],rax
       jmp       near ptr M01_L08
M01_L04:
       mov       rax,[rbp-30]
       cmp       [rax],al
       mov       rax,[rbp-30]
       lea       rdi,[rax+20]
       call      qword ptr [742428B276A8]; System.Threading.CancellationToken.get_IsCancellationRequested()
       test      eax,eax
       je        short M01_L05
       mov       rdi,742428B92C34
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-30]
       mov       rdi,[rax+20]
       call      qword ptr [742428B27678]
       mov       [rbp-98],rax
       jmp       near ptr M01_L08
M01_L05:
       mov       rdi,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rdi,[rbp-60]
       mov       rsi,[rbp-30]
       call      qword ptr [742428B277B0]; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.Int32, System.Private.CoreLib]]..ctor(System.Threading.Tasks.AsyncLazy`1<Int32>)
       mov       rax,[rbp-60]
       mov       [rbp-58],rax
       mov       rax,[rbp-30]
       cmp       [rax],al
       mov       rax,[rbp-30]
       lea       rdi,[rax+8]
       mov       rsi,[rbp-58]
       xor       edx,edx
       call      qword ptr [742428B277C8]; System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       jne       near ptr M01_L07
       mov       rdi,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>+<>c
       call      qword ptr [742428055710]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,741464800930
       mov       rax,[rax]
       mov       [rbp-68],rax
       mov       rax,[rbp-68]
       mov       [rbp-70],rax
       cmp       qword ptr [rbp-68],0
       jne       near ptr M01_L06
       mov       rdi,742428B92C38
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdi,offset MT_System.Action<System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-78],rax
       mov       rdi,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>+<>c
       call      qword ptr [742428055710]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,741464800928
       mov       rax,[rax]
       mov       [rbp-0A8],rax
       mov       rsi,[rbp-0A8]
       mov       rdi,[rbp-78]
       mov       rdx,offset System.Threading.Tasks.AsyncLazy`1+<>c[[System.Int32, System.Private.CoreLib]].<GetOrStartAttemptAsync>b__11_0(Attempt<Int32>)
       call      qword ptr [742428056E08]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdi,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>+<>c
       call      qword ptr [742428055710]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rsi,[rbp-78]
       mov       rdi,741464800930
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-78]
       mov       [rbp-70],rax
M01_L06:
       mov       rdi,742428B92C3C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdx,[rbp-58]
       mov       rsi,[rbp-70]
       mov       rdi,742428B926E0
       xor       ecx,ecx
       call      qword ptr [742428B276F0]; System.Threading.ThreadPool.QueueUserWorkItem[[System.__Canon, System.Private.CoreLib]](System.Action`1<System.__Canon>, System.__Canon, Boolean)
       mov       rdi,[rbp-58]
       mov       rsi,[rbp-38]
       cmp       [rdi],edi
       call      qword ptr [742428B27798]; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.Int32, System.Private.CoreLib]].WaitAsync(System.Threading.CancellationToken)
       mov       [rbp-98],rax
       jmp       short M01_L08
M01_L07:
       mov       rdi,742428B92C40
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M01_L00
M01_L08:
       mov       rax,[rbp-98]
       add       rsp,0B0
       pop       rbp
       ret
; Total bytes of code 834
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.HotPathBenchmarks`1[[System.Int32, System.Private.CoreLib]].Nito()
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
       call      000070EBCD2E6020
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
       call      qword ptr [70EB4FC847C8]
       int       3
M00_L02:
       mov       rdi,[rbp-18]
       call      qword ptr [70EB4FC84810]
       jmp       short M00_L00
M00_L03:
       call      qword ptr [70EB4F8BC438]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rbx,rax
M00_L04:
       mov       rdi,[rbp-18]
       call      000070EBCD2E6790
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
       call      qword ptr [70EB4FC847E0]
       jmp       short M00_L05
       push      rax
       cmp       dword ptr [rbp-0C],0
       je        short M00_L08
       cmp       qword ptr [rbp-18],0
       jne       short M00_L07
       xor       edi,edi
       call      qword ptr [70EB4FC847C8]
       int       3
M00_L07:
       mov       rdi,[rbp-18]
       call      000070EBCD2E6790
       test      eax,eax
       je        short M00_L08
       mov       edi,eax
       mov       rsi,[rbp-18]
       call      qword ptr [70EB4FC847E0]
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
       call      qword ptr [70EB4EC22688]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
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
       call      qword ptr [70EB4EC19630]
       int       3
       mov       rdi,rbx
       call      qword ptr [70EB4EC22678]
       jmp       short M01_L01
       mov       rdi,rbx
       xor       esi,esi
       call      qword ptr [70EB4EC22680]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M01_L01
       mov       rdi,[rbx]
       call      qword ptr [70EB4EC014E0]
       mov       rdi,rax
       call      qword ptr [70EB4EC08728]
       mov       rdi,rax
       call      qword ptr [70EB4EC281A8]
       mov       rdx,rax
       mov       rsi,r15
       mov       rdi,rbx
       call      qword ptr [70EB4EC22690]
       jmp       near ptr M01_L01
       mov       rax,[rbx+10]
       test      rax,rax
       je        short M01_L05
       mov       rdi,[rax+8]
       call      qword ptr [rax+18]
       mov       rdx,rax
       mov       rsi,r15
       mov       rdi,rbx
       call      qword ptr [70EB4EC22690]
       jmp       near ptr M01_L01
M01_L05:
       mov       rdi,rbx
       call      qword ptr [70EB4EC226A0]
       jmp       near ptr M01_L01
       mov       rdi,rbx
       mov       rsi,r15
       mov       edx,1
       call      qword ptr [70EB4EC22688]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M01_L01
; Total bytes of code 278
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.HotPathBenchmarks`1[[System.Int32, System.Private.CoreLib]].VsThreading()
       mov       rdi,[rdi+28]
       cmp       [rdi],dil
       xor       esi,esi
       jmp       qword ptr [757E158FCA80]; Microsoft.VisualStudio.Threading.AsyncLazy`1[[System.Int32, System.Private.CoreLib]].GetValueAsync(System.Threading.CancellationToken)
; Total bytes of code 15
```
```assembly
; Microsoft.VisualStudio.Threading.AsyncLazy`1[[System.Int32, System.Private.CoreLib]].GetValueAsync(System.Threading.CancellationToken)
       push      rbp
       push      r15
       push      r14
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-30],rax
       mov       [rbp-38],rdi
       mov       [rbp-20],rsi
       mov       rdi,offset MT_Microsoft.VisualStudio.Threading.AsyncLazy<System.Int32>+<>c__DisplayClass20_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rdi,[rbx+8]
       mov       rsi,[rbp-38]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-38]
       mov       rdi,[rsi+28]
       test      rdi,rdi
       je        short M01_L05
       test      dword ptr [rdi+34],1600000
       je        short M01_L05
M01_L00:
       mov       rsi,[rbp-38]
       cmp       qword ptr [rsi+28],0
       je        near ptr M01_L06
M01_L01:
       mov       rsi,[rbp-38]
       lock or   dword ptr [rsp],0
       mov       rdi,[rsi+30]
       test      rdi,rdi
       jne       near ptr M01_L17
       xor       eax,eax
M01_L02:
       test      rax,rax
       jne       short M01_L04
       mov       rsi,[rbp-38]
       mov       rbx,[rsi+28]
       mov       rdi,[rbp-20]
       mov       [rbp-30],rdi
       test      rbx,rbx
       je        near ptr M01_L18
       cmp       qword ptr [rbp-30],0
       jne       near ptr M01_L19
M01_L03:
       mov       rax,rbx
M01_L04:
       add       rsp,28
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L05:
       mov       rdi,[rsi+18]
       test      rdi,rdi
       je        short M01_L00
       mov       rdi,[rdi+8]
       cmp       [rdi],edi
       call      qword ptr [757E158FCBB8]; System.Threading.AsyncLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       test      rax,rax
       je        short M01_L00
       call      qword ptr [757E15A548B8]
       mov       rdi,rax
       mov       rdx,756E50801488
       mov       rdx,[rdx]
       mov       rsi,757E1020C640
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rdi,rax
       xor       eax,eax
       test      rdi,rdi
       cmove     rdi,rax
       call      qword ptr [757E158FD170]
       int       3
M01_L06:
       mov       rdi,[rsi+8]
       call      qword ptr [757E158FD1A0]; System.Threading.Monitor.IsEntered(System.Object)
       test      eax,eax
       je        short M01_L07
       call      qword ptr [757E15A548B8]
       mov       rdi,rax
       mov       rdx,756E50801488
       mov       rdx,[rdx]
       mov       rsi,757E1020C640
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rdi,rax
       xor       eax,eax
       test      rdi,rdi
       cmove     rdi,rax
       call      qword ptr [757E158FD170]
       int       3
M01_L07:
       xor       esi,esi
       mov       [rbx+10],rsi
       mov       rsi,[rbp-38]
       mov       rdi,[rsi+8]
       mov       [rbp-40],rdi
       xor       edi,edi
       mov       [rbp-28],edi
       lea       rsi,[rbp-28]
       mov       rdi,[rbp-40]
       call      qword ptr [757E14E25980]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rsi,[rbp-38]
       cmp       qword ptr [rsi+28],0
       jne       near ptr M01_L15
       lea       rdi,[rbp-20]
       call      qword ptr [757E158F76A8]; System.Threading.CancellationToken.get_IsCancellationRequested()
       test      eax,eax
       je        short M01_L08
       lea       rdi,[rbp-20]
       call      qword ptr [757E15A548D0]
       int       3
M01_L08:
       mov       rdi,offset MT_Microsoft.VisualStudio.Threading.InlineResumable
       call      CORINFO_HELP_NEWSFAST
       lea       rdi,[rbx+10]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-38]
       mov       rsi,[rsi+20]
       lea       rdi,[rbx+18]
       call      CORINFO_HELP_ASSIGN_REF
       xor       edi,edi
       mov       rsi,[rbp-38]
       mov       [rsi+20],rdi
       mov       rdi,offset MT_System.Func<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdi,r15
       mov       rsi,rbx
       mov       rdx,offset Microsoft.VisualStudio.Threading.AsyncLazy`1+<>c__DisplayClass20_0[[System.Int32, System.Private.CoreLib]].<GetValueAsync>b__0()
       call      qword ptr [757E14E26E08]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rsi,[rbp-38]
       cmp       byte ptr [rsi+38],0
       jne       short M01_L10
       cmp       qword ptr [rsi+18],0
       je        short M01_L09
       mov       rdi,757E15A2F178
       call      qword ptr [757E158FD3F8]
M01_L09:
       mov       rdi,offset MT_Microsoft.VisualStudio.Threading.AsyncLocal<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdi,r14
       call      qword ptr [757E158FD200]; Microsoft.VisualStudio.Threading.AsyncLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rdi,[r14+8]
       mov       rsi,756E50800918
       mov       rsi,[rsi]
       cmp       [rdi],edi
       call      qword ptr [757E158FCBE8]; System.Threading.AsyncLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
       mov       rsi,[rbp-38]
       lea       rdi,[rsi+18]
       mov       rsi,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-38]
M01_L10:
       cmp       qword ptr [rsi+10],0
       je        short M01_L11
       mov       rdi,[rsi+10]
       cmp       [rdi],dil
       mov       rsi,r15
       xor       edx,edx
       xor       ecx,ecx
       xor       r8d,r8d
       call      qword ptr [757E15A54840]
       mov       rsi,[rbp-38]
       lea       rdi,[rsi+30]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       lock or   dword ptr [rsp],0
       mov       rsi,[rbp-38]
       mov       rdi,[rsi+30]
       cmp       [rdi],dil
       call      qword ptr [757E15A548E8]
       mov       rsi,rax
       mov       rdi,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      qword ptr [757E14E26310]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rsi,[rbp-38]
       lea       rdi,[rsi+28]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L13
M01_L11:
       mov       rdi,[r15+8]
       call      qword ptr [r15+18]
       mov       rsi,[rbp-38]
       lea       rdi,[rsi+28]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L13
M01_L12:
       mov       rdi,[rsi+18]
       mov       rdi,[rdi+8]
       xor       esi,esi
       cmp       [rdi],edi
       call      qword ptr [757E158FCBE8]; System.Threading.AsyncLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
       jmp       short M01_L15
M01_L13:
       mov       rsi,[rbp-38]
       cmp       qword ptr [rsi+18],0
       je        short M01_L15
       jmp       short M01_L12
M01_L14:
       mov       rdi,[rbp-40]
       call      qword ptr [757E14E26808]; System.Threading.Monitor.Exit(System.Object)
       jmp       short M01_L16
M01_L15:
       cmp       byte ptr [rbp-28],0
       jne       short M01_L14
M01_L16:
       mov       rdi,[rbx+10]
       test      rdi,rdi
       je        near ptr M01_L01
       call      qword ptr [757E158FD260]; Microsoft.VisualStudio.Threading.InlineResumable.Resume()
       jmp       near ptr M01_L01
M01_L17:
       mov       rdx,[rbp-20]
       xor       esi,esi
       call      qword ptr [757E158FD278]
       jmp       near ptr M01_L02
M01_L18:
       mov       rdi,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       edi,170F
       mov       rsi,757E1592A928
       call      qword ptr [757E14E2EF88]
       mov       rsi,rax
       mov       rdi,rbx
       call      qword ptr [757E1568DF68]
       mov       rdi,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L19:
       test      dword ptr [rbx+34],1600000
       jne       near ptr M01_L03
       lea       rdi,[rbp-30]
       call      qword ptr [757E158F76A8]; System.Threading.CancellationToken.get_IsCancellationRequested()
       test      eax,eax
       je        short M01_L20
       mov       rdi,[rbp-30]
       call      qword ptr [757E158F7678]
       jmp       near ptr M01_L04
M01_L20:
       mov       rdi,rbx
       mov       rsi,[rbp-30]
       call      qword ptr [757E158FEE08]
       jmp       near ptr M01_L04
       push      rax
       mov       rsi,[rbp-38]
       mov       rdi,[rsi+18]
       test      rdi,rdi
       je        short M01_L21
       mov       rdi,[rdi+8]
       xor       esi,esi
       cmp       [rdi],edi
       call      qword ptr [757E158FCBE8]; System.Threading.AsyncLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
M01_L21:
       nop
       add       rsp,8
       ret
       push      rax
       cmp       byte ptr [rbp-28],0
       je        short M01_L22
       mov       rdi,[rbp-40]
       call      qword ptr [757E14E26808]; System.Threading.Monitor.Exit(System.Object)
M01_L22:
       nop
       add       rsp,8
       ret
; Total bytes of code 1018
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.HotPathBenchmarks`1[[System.Int32, System.Private.CoreLib]].LazyOfTask_Token()
       push      rbp
       push      r15
       push      r14
       push      rbx
       push      rax
       lea       rbp,[rsp+20]
       mov       rbx,rdi
       mov       rdi,[rbx+10]
       cmp       qword ptr [rdi+8],0
       jne       short M00_L04
       mov       r15,[rdi+18]
M00_L00:
       mov       rbx,[rbx+8]
       cmp       byte ptr [rbx+24],0
       jne       short M00_L05
       test      dword ptr [r15+34],1600000
       jne       short M00_L02
       cmp       dword ptr [rbx+20],0
       jne       short M00_L01
       mov       rdi,offset MT_System.Threading.Tasks.Task+CancellationPromise<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,765068801470
       mov       rcx,[rcx]
       mov       rdi,r14
       mov       rsi,r15
       mov       r8,rbx
       mov       edx,0FFFFFFFF
       call      qword ptr [76602D8548B8]
       jmp       short M00_L03
M00_L01:
       mov       rdi,rbx
       add       rsp,8
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [76602D6F7678]
M00_L02:
       mov       r14,r15
M00_L03:
       mov       rax,r14
       add       rsp,8
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L04:
       call      qword ptr [76602D48C438]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       r15,rax
       jmp       short M00_L00
M00_L05:
       mov       edi,46
       call      qword ptr [76602D854888]
       int       3
; Total bytes of code 168
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
       call      qword ptr [76602C7F2688]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
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
       call      qword ptr [76602C7E9630]
       int       3
       mov       rdi,rbx
       call      qword ptr [76602C7F2678]
       jmp       short M01_L01
       mov       rdi,rbx
       xor       esi,esi
       call      qword ptr [76602C7F2680]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M01_L01
       mov       rdi,[rbx]
       call      qword ptr [76602C7D14E0]
       mov       rdi,rax
       call      qword ptr [76602C7D8728]
       mov       rdi,rax
       call      qword ptr [76602C7F81A8]
       mov       rdx,rax
       mov       rsi,r15
       mov       rdi,rbx
       call      qword ptr [76602C7F2690]
       jmp       near ptr M01_L01
       mov       rax,[rbx+10]
       test      rax,rax
       je        short M01_L05
       mov       rdi,[rax+8]
       call      qword ptr [rax+18]
       mov       rdx,rax
       mov       rsi,r15
       mov       rdi,rbx
       call      qword ptr [76602C7F2690]
       jmp       near ptr M01_L01
M01_L05:
       mov       rdi,rbx
       call      qword ptr [76602C7F26A0]
       jmp       near ptr M01_L01
       mov       rdi,rbx
       mov       rsi,r15
       mov       edx,1
       call      qword ptr [76602C7F2688]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M01_L01
; Total bytes of code 278
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.HotPathBenchmarks`1[[System.Int32, System.Private.CoreLib]].AsyncLazy_Token()
       push      rbp
       mov       rbp,rsp
       mov       rsi,[rdi+18]
       mov       rcx,[rdi+8]
       cmp       byte ptr [rcx+24],0
       jne       short M00_L00
       cmp       [rsi],sil
       cmp       dword ptr [rcx+20],0
       jne       short M00_L01
       mov       rax,[rsi+10]
       test      rax,rax
       je        short M00_L02
       pop       rbp
       ret
M00_L00:
       mov       edi,46
       call      qword ptr [76E98B6547F8]
       int       3
M00_L01:
       mov       rdi,rcx
       pop       rbp
       jmp       qword ptr [76E98B4F7678]
M00_L02:
       mov       rdi,rsi
       mov       rsi,rcx
       pop       rbp
       jmp       qword ptr [76E98B4F76C0]; System.Threading.Tasks.AsyncLazy`1[[System.Int32, System.Private.CoreLib]].GetOrStartAttemptAsync(System.Threading.CancellationToken)
; Total bytes of code 73
```
```assembly
; System.Threading.Tasks.AsyncLazy`1[[System.Int32, System.Private.CoreLib]].GetOrStartAttemptAsync(System.Threading.CancellationToken)
       push      rbp
       sub       rsp,0B0
       lea       rbp,[rsp+0B0]
       xor       eax,eax
       mov       [rbp-0A8],rax
       vxorps    xmm8,xmm8,xmm8
       vmovdqu   ymmword ptr [rbp-0A0],ymm8
       vmovdqu   ymmword ptr [rbp-80],ymm8
       vmovdqu   ymmword ptr [rbp-60],ymm8
       mov       [rbp-40],rax
       mov       [rbp-30],rdi
       mov       [rbp-38],rsi
       mov       dword ptr [rbp-90],3E8
M01_L00:
       mov       eax,[rbp-90]
       dec       eax
       mov       [rbp-90],eax
       cmp       dword ptr [rbp-90],0
       jg        short M01_L01
       lea       rdi,[rbp-90]
       xor       esi,esi
       call      CORINFO_HELP_PATCHPOINT
M01_L01:
       mov       rax,[rbp-30]
       mov       rax,[rax+8]
       mov       [rbp-40],rax
       mov       rax,[rbp-40]
       mov       [rbp-88],rax
       mov       rdi,[rbp-88]
       mov       rsi,76E98B562B20
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-88]
       mov       [rbp-0A0],rax
       mov       rsi,[rbp-0A0]
       mov       rdi,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      qword ptr [76E98AA26838]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       [rbp-48],rax
       cmp       qword ptr [rbp-48],0
       je        short M01_L02
       mov       rdi,76E98B562C28
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-48]
       mov       [rbp-98],rax
       jmp       near ptr M01_L08
M01_L02:
       mov       rsi,[rbp-40]
       mov       rdi,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt
       call      qword ptr [76E98AA26838]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       [rbp-50],rax
       cmp       qword ptr [rbp-50],0
       je        near ptr M01_L04
       mov       rdi,[rbp-50]
       call      qword ptr [76E98B4F7780]
       test      eax,eax
       je        short M01_L03
       mov       rdi,76E98B562C2C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdi,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-80],rax
       mov       rdi,[rbp-80]
       mov       rsi,76E979C07798
       call      qword ptr [76E98B285260]
       mov       rdi,[rbp-80]
       call      qword ptr [76E98B4F7738]; System.Threading.Tasks.Task.FromException[[System.Int32, System.Private.CoreLib]](System.Exception)
       mov       [rbp-98],rax
       jmp       near ptr M01_L08
M01_L03:
       mov       rdi,76E98B562C30
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdi,[rbp-50]
       mov       rsi,[rbp-38]
       cmp       [rdi],edi
       call      qword ptr [76E98B4F7798]; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.Int32, System.Private.CoreLib]].WaitAsync(System.Threading.CancellationToken)
       mov       [rbp-98],rax
       jmp       near ptr M01_L08
M01_L04:
       mov       rax,[rbp-30]
       cmp       [rax],al
       mov       rax,[rbp-30]
       lea       rdi,[rax+20]
       call      qword ptr [76E98B4F76A8]; System.Threading.CancellationToken.get_IsCancellationRequested()
       test      eax,eax
       je        short M01_L05
       mov       rdi,76E98B562C34
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-30]
       mov       rdi,[rax+20]
       call      qword ptr [76E98B4F7678]
       mov       [rbp-98],rax
       jmp       near ptr M01_L08
M01_L05:
       mov       rdi,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rdi,[rbp-60]
       mov       rsi,[rbp-30]
       call      qword ptr [76E98B4F77B0]; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.Int32, System.Private.CoreLib]]..ctor(System.Threading.Tasks.AsyncLazy`1<Int32>)
       mov       rax,[rbp-60]
       mov       [rbp-58],rax
       mov       rax,[rbp-30]
       cmp       [rax],al
       mov       rax,[rbp-30]
       lea       rdi,[rax+8]
       mov       rsi,[rbp-58]
       xor       edx,edx
       call      qword ptr [76E98B4F77C8]; System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       jne       near ptr M01_L07
       mov       rdi,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>+<>c
       call      qword ptr [76E98AA25710]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,76D9C8800930
       mov       rax,[rax]
       mov       [rbp-68],rax
       mov       rax,[rbp-68]
       mov       [rbp-70],rax
       cmp       qword ptr [rbp-68],0
       jne       near ptr M01_L06
       mov       rdi,76E98B562C38
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdi,offset MT_System.Action<System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-78],rax
       mov       rdi,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>+<>c
       call      qword ptr [76E98AA25710]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,76D9C8800928
       mov       rax,[rax]
       mov       [rbp-0A8],rax
       mov       rsi,[rbp-0A8]
       mov       rdi,[rbp-78]
       mov       rdx,offset System.Threading.Tasks.AsyncLazy`1+<>c[[System.Int32, System.Private.CoreLib]].<GetOrStartAttemptAsync>b__11_0(Attempt<Int32>)
       call      qword ptr [76E98AA26E08]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdi,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>+<>c
       call      qword ptr [76E98AA25710]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rsi,[rbp-78]
       mov       rdi,76D9C8800930
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-78]
       mov       [rbp-70],rax
M01_L06:
       mov       rdi,76E98B562C3C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdx,[rbp-58]
       mov       rsi,[rbp-70]
       mov       rdi,76E98B5626E0
       xor       ecx,ecx
       call      qword ptr [76E98B4F76F0]; System.Threading.ThreadPool.QueueUserWorkItem[[System.__Canon, System.Private.CoreLib]](System.Action`1<System.__Canon>, System.__Canon, Boolean)
       mov       rdi,[rbp-58]
       mov       rsi,[rbp-38]
       cmp       [rdi],edi
       call      qword ptr [76E98B4F7798]; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.Int32, System.Private.CoreLib]].WaitAsync(System.Threading.CancellationToken)
       mov       [rbp-98],rax
       jmp       short M01_L08
M01_L07:
       mov       rdi,76E98B562C40
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M01_L00
M01_L08:
       mov       rax,[rbp-98]
       add       rsp,0B0
       pop       rbp
       ret
; Total bytes of code 834
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.HotPathBenchmarks`1[[System.Int32, System.Private.CoreLib]].Nito_Token()
       push      rbp
       push      r15
       push      r14
       push      rbx
       sub       rsp,18
       lea       rbp,[rsp+30]
       mov       rbx,rdi
       mov       r15,[rbx+20]
       mov       rdi,[r15+8]
       mov       [rbp-28],rdi
       xor       eax,eax
       mov       [rbp-1C],eax
       test      rdi,rdi
       je        short M00_L01
       call      00007B6BBD2E6020
       test      eax,eax
       je        short M00_L02
M00_L00:
       mov       dword ptr [rbp-1C],1
       mov       rdi,[r15+18]
       cmp       qword ptr [rdi+8],0
       jne       short M00_L03
       mov       r15,[rdi+18]
       jmp       short M00_L04
M00_L01:
       xor       edi,edi
       call      qword ptr [7B6B3FC64888]
       int       3
M00_L02:
       mov       rdi,[rbp-28]
       call      qword ptr [7B6B3FC64930]
       jmp       short M00_L00
M00_L03:
       call      qword ptr [7B6B3F89C438]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       r15,rax
M00_L04:
       mov       rdi,[rbp-28]
       call      00007B6BBD2E6790
       test      eax,eax
       jne       short M00_L09
M00_L05:
       mov       rbx,[rbx+8]
       cmp       byte ptr [rbx+24],0
       jne       short M00_L10
       test      dword ptr [r15+34],1600000
       jne       short M00_L07
       cmp       dword ptr [rbx+20],0
       jne       short M00_L06
       mov       rdi,offset MT_System.Threading.Tasks.Task+CancellationPromise<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,7B5B7C801470
       mov       rcx,[rcx]
       mov       rdi,r14
       mov       rsi,r15
       mov       r8,rbx
       mov       edx,0FFFFFFFF
       call      qword ptr [7B6B3FC648E8]
       jmp       short M00_L08
M00_L06:
       mov       rdi,rbx
       add       rsp,18
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7B6B3FB07678]
M00_L07:
       mov       r14,r15
M00_L08:
       mov       rax,r14
       add       rsp,18
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L09:
       mov       edi,eax
       mov       rsi,[rbp-28]
       call      qword ptr [7B6B3FC648A0]
       jmp       near ptr M00_L05
M00_L10:
       mov       edi,46
       call      qword ptr [7B6B3FC648B8]
       int       3
       push      rax
       cmp       dword ptr [rbp-1C],0
       je        short M00_L12
       cmp       qword ptr [rbp-28],0
       jne       short M00_L11
       xor       edi,edi
       call      qword ptr [7B6B3FC64888]
       int       3
M00_L11:
       mov       rdi,[rbp-28]
       call      00007B6BBD2E6790
       test      eax,eax
       je        short M00_L12
       mov       edi,eax
       mov       rsi,[rbp-28]
       call      qword ptr [7B6B3FC648A0]
M00_L12:
       nop
       add       rsp,8
       ret
; Total bytes of code 314
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
       call      qword ptr [7B6B3EC02688]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
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
       call      qword ptr [7B6B3EBF9630]
       int       3
       mov       rdi,rbx
       call      qword ptr [7B6B3EC02678]
       jmp       short M01_L01
       mov       rdi,rbx
       xor       esi,esi
       call      qword ptr [7B6B3EC02680]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M01_L01
       mov       rdi,[rbx]
       call      qword ptr [7B6B3EBE14E0]
       mov       rdi,rax
       call      qword ptr [7B6B3EBE8728]
       mov       rdi,rax
       call      qword ptr [7B6B3EC081A8]
       mov       rdx,rax
       mov       rsi,r15
       mov       rdi,rbx
       call      qword ptr [7B6B3EC02690]
       jmp       near ptr M01_L01
       mov       rax,[rbx+10]
       test      rax,rax
       je        short M01_L05
       mov       rdi,[rax+8]
       call      qword ptr [rax+18]
       mov       rdx,rax
       mov       rsi,r15
       mov       rdi,rbx
       call      qword ptr [7B6B3EC02690]
       jmp       near ptr M01_L01
M01_L05:
       mov       rdi,rbx
       call      qword ptr [7B6B3EC026A0]
       jmp       near ptr M01_L01
       mov       rdi,rbx
       mov       rsi,r15
       mov       edx,1
       call      qword ptr [7B6B3EC02688]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M01_L01
; Total bytes of code 278
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.HotPathBenchmarks`1[[System.Int32, System.Private.CoreLib]].VsThreading_Token()
       push      rax
       mov       rsi,[rdi+28]
       mov       rax,[rdi+8]
       cmp       byte ptr [rax+24],0
       jne       short M00_L00
       mov       rdi,rsi
       mov       rsi,rax
       cmp       [rdi],edi
       add       rsp,8
       jmp       qword ptr [771A7AF0C9D8]; Microsoft.VisualStudio.Threading.AsyncLazy`1[[System.Int32, System.Private.CoreLib]].GetValueAsync(System.Threading.CancellationToken)
M00_L00:
       mov       edi,46
       call      qword ptr [771A7B0647F8]
       int       3
; Total bytes of code 45
```
```assembly
; Microsoft.VisualStudio.Threading.AsyncLazy`1[[System.Int32, System.Private.CoreLib]].GetValueAsync(System.Threading.CancellationToken)
       push      rbp
       push      r15
       push      r14
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-30],rax
       mov       [rbp-38],rdi
       mov       [rbp-20],rsi
       mov       rdi,offset MT_Microsoft.VisualStudio.Threading.AsyncLazy<System.Int32>+<>c__DisplayClass20_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rdi,[rbx+8]
       mov       rsi,[rbp-38]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-38]
       mov       rdi,[rsi+28]
       test      rdi,rdi
       je        short M01_L05
       test      dword ptr [rdi+34],1600000
       je        short M01_L05
M01_L00:
       mov       rsi,[rbp-38]
       cmp       qword ptr [rsi+28],0
       je        near ptr M01_L06
M01_L01:
       mov       rsi,[rbp-38]
       lock or   dword ptr [rsp],0
       mov       rdi,[rsi+30]
       test      rdi,rdi
       jne       near ptr M01_L17
       xor       eax,eax
M01_L02:
       test      rax,rax
       jne       short M01_L04
       mov       rsi,[rbp-38]
       mov       rbx,[rsi+28]
       mov       rdi,[rbp-20]
       mov       [rbp-30],rdi
       test      rbx,rbx
       je        near ptr M01_L18
       cmp       qword ptr [rbp-30],0
       je        short M01_L03
       test      dword ptr [rbx+34],1600000
       je        near ptr M01_L19
M01_L03:
       mov       rax,rbx
M01_L04:
       add       rsp,28
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L05:
       mov       rdi,[rsi+18]
       test      rdi,rdi
       je        short M01_L00
       mov       rdi,[rdi+8]
       cmp       [rdi],edi
       call      qword ptr [771A7AF0CCC0]; System.Threading.AsyncLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       test      rax,rax
       je        near ptr M01_L00
       call      qword ptr [771A7B0648E8]
       mov       rdi,rax
       mov       rdx,770AB48014A0
       mov       rdx,[rdx]
       mov       rsi,771A7140C640
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rdi,rax
       xor       eax,eax
       test      rdi,rdi
       cmove     rdi,rax
       call      qword ptr [771A7AF0D0E0]
       int       3
M01_L06:
       mov       rdi,[rsi+8]
       call      qword ptr [771A7AF0D0F8]; System.Threading.Monitor.IsEntered(System.Object)
       test      eax,eax
       je        short M01_L07
       call      qword ptr [771A7B0648E8]
       mov       rdi,rax
       mov       rdx,770AB48014A0
       mov       rdx,[rdx]
       mov       rsi,771A7140C640
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rdi,rax
       xor       eax,eax
       test      rdi,rdi
       cmove     rdi,rax
       call      qword ptr [771A7AF0D0E0]
       int       3
M01_L07:
       xor       esi,esi
       mov       [rbx+10],rsi
       mov       rsi,[rbp-38]
       mov       rdi,[rsi+8]
       mov       [rbp-40],rdi
       xor       edi,edi
       mov       [rbp-28],edi
       lea       rsi,[rbp-28]
       mov       rdi,[rbp-40]
       call      qword ptr [771A7A435980]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rsi,[rbp-38]
       cmp       qword ptr [rsi+28],0
       jne       near ptr M01_L15
       lea       rdi,[rbp-20]
       call      qword ptr [771A7AF076A8]; System.Threading.CancellationToken.get_IsCancellationRequested()
       test      eax,eax
       je        short M01_L08
       lea       rdi,[rbp-20]
       call      qword ptr [771A7B064900]
       int       3
M01_L08:
       mov       rdi,offset MT_Microsoft.VisualStudio.Threading.InlineResumable
       call      CORINFO_HELP_NEWSFAST
       lea       rdi,[rbx+10]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-38]
       mov       rsi,[rsi+20]
       lea       rdi,[rbx+18]
       call      CORINFO_HELP_ASSIGN_REF
       xor       edi,edi
       mov       rsi,[rbp-38]
       mov       [rsi+20],rdi
       mov       rdi,offset MT_System.Func<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdi,r15
       mov       rsi,rbx
       mov       rdx,offset Microsoft.VisualStudio.Threading.AsyncLazy`1+<>c__DisplayClass20_0[[System.Int32, System.Private.CoreLib]].<GetValueAsync>b__0()
       call      qword ptr [771A7A436E08]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rsi,[rbp-38]
       cmp       byte ptr [rsi+38],0
       jne       short M01_L10
       cmp       qword ptr [rsi+18],0
       je        short M01_L09
       mov       rdi,771A7B03F5A0
       call      qword ptr [771A7AF0D2A8]
M01_L09:
       mov       rdi,offset MT_Microsoft.VisualStudio.Threading.AsyncLocal<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdi,r14
       call      qword ptr [771A7AF0D158]; Microsoft.VisualStudio.Threading.AsyncLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rdi,[r14+8]
       mov       rsi,770AB4800918
       mov       rsi,[rsi]
       cmp       [rdi],edi
       call      qword ptr [771A7AF0CCF0]; System.Threading.AsyncLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
       mov       rsi,[rbp-38]
       lea       rdi,[rsi+18]
       mov       rsi,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-38]
M01_L10:
       cmp       qword ptr [rsi+10],0
       je        short M01_L11
       mov       rdi,[rsi+10]
       cmp       [rdi],dil
       mov       rsi,r15
       xor       edx,edx
       xor       ecx,ecx
       xor       r8d,r8d
       call      qword ptr [771A7B064870]
       mov       rsi,[rbp-38]
       lea       rdi,[rsi+30]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       lock or   dword ptr [rsp],0
       mov       rsi,[rbp-38]
       mov       rdi,[rsi+30]
       cmp       [rdi],dil
       call      qword ptr [771A7B064918]
       mov       rsi,rax
       mov       rdi,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      qword ptr [771A7A436310]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rsi,[rbp-38]
       lea       rdi,[rsi+28]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L13
M01_L11:
       mov       rdi,[r15+8]
       call      qword ptr [r15+18]
       mov       rsi,[rbp-38]
       lea       rdi,[rsi+28]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L13
M01_L12:
       mov       rdi,[rsi+18]
       mov       rdi,[rdi+8]
       xor       esi,esi
       cmp       [rdi],edi
       call      qword ptr [771A7AF0CCF0]; System.Threading.AsyncLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
       jmp       short M01_L15
M01_L13:
       mov       rsi,[rbp-38]
       cmp       qword ptr [rsi+18],0
       je        short M01_L15
       jmp       short M01_L12
M01_L14:
       mov       rdi,[rbp-40]
       call      qword ptr [771A7A436808]; System.Threading.Monitor.Exit(System.Object)
       jmp       short M01_L16
M01_L15:
       cmp       byte ptr [rbp-28],0
       jne       short M01_L14
M01_L16:
       mov       rdi,[rbx+10]
       test      rdi,rdi
       je        near ptr M01_L01
       call      qword ptr [771A7AF0D1B8]; Microsoft.VisualStudio.Threading.InlineResumable.Resume()
       jmp       near ptr M01_L01
M01_L17:
       mov       rdx,[rbp-20]
       xor       esi,esi
       call      qword ptr [771A7AF0D1D0]
       jmp       near ptr M01_L02
M01_L18:
       mov       rdi,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       edi,170F
       mov       rsi,771A7AF3A928
       call      qword ptr [771A7A43EF88]
       mov       rsi,rax
       mov       rdi,rbx
       call      qword ptr [771A7AC9DF68]
       mov       rdi,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L19:
       lea       rdi,[rbp-30]
       call      qword ptr [771A7AF076A8]; System.Threading.CancellationToken.get_IsCancellationRequested()
       test      eax,eax
       je        short M01_L20
       mov       rdi,[rbp-30]
       call      qword ptr [771A7AF07678]
       jmp       near ptr M01_L04
M01_L20:
       mov       rdi,rbx
       mov       rsi,[rbp-30]
       call      qword ptr [771A7AF0EE08]
       jmp       near ptr M01_L04
       push      rax
       mov       rsi,[rbp-38]
       mov       rdi,[rsi+18]
       test      rdi,rdi
       je        short M01_L21
       mov       rdi,[rdi+8]
       xor       esi,esi
       cmp       [rdi],edi
       call      qword ptr [771A7AF0CCF0]; System.Threading.AsyncLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
M01_L21:
       nop
       add       rsp,8
       ret
       push      rax
       cmp       byte ptr [rbp-28],0
       je        short M01_L22
       mov       rdi,[rbp-40]
       call      qword ptr [771A7A436808]; System.Threading.Monitor.Exit(System.Object)
M01_L22:
       nop
       add       rsp,8
       ret
; Total bytes of code 1018
```

