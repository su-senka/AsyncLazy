## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.HotPathBenchmarks`1[[System.Int32, System.Private.CoreLib]].LazyOfTask()
       mov       rdi,[rdi+10]
       cmp       qword ptr [rdi+8],0
       jne       short M00_L00
       mov       rax,[rdi+18]
       ret
M00_L00:
       jmp       qword ptr [76532BC9C438]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
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
       call      qword ptr [76532B002688]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
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
       call      qword ptr [76532AFF9630]
       int       3
       mov       rdi,rbx
       call      qword ptr [76532B002678]
       jmp       short M01_L01
       mov       rdi,rbx
       xor       esi,esi
       call      qword ptr [76532B002680]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M01_L01
       mov       rdi,[rbx]
       call      qword ptr [76532AFE14E0]
       mov       rdi,rax
       call      qword ptr [76532AFE8728]
       mov       rdi,rax
       call      qword ptr [76532B0081A8]
       mov       rdx,rax
       mov       rsi,r15
       mov       rdi,rbx
       call      qword ptr [76532B002690]
       jmp       near ptr M01_L01
       mov       rax,[rbx+10]
       test      rax,rax
       je        short M01_L05
       mov       rdi,[rax+8]
       call      qword ptr [rax+18]
       mov       rdx,rax
       mov       rsi,r15
       mov       rdi,rbx
       call      qword ptr [76532B002690]
       jmp       near ptr M01_L01
M01_L05:
       mov       rdi,rbx
       call      qword ptr [76532B0026A0]
       jmp       near ptr M01_L01
       mov       rdi,rbx
       mov       rsi,r15
       mov       edx,1
       call      qword ptr [76532B002688]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M01_L01
; Total bytes of code 278
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.HotPathBenchmarks`1[[System.Int32, System.Private.CoreLib]].AsyncLazy()
       mov       rdi,[rdi+18]
       mov       rax,[rdi+10]
       test      rax,rax
       je        short M00_L00
       ret
M00_L00:
       xor       esi,esi
       jmp       qword ptr [72FBF0517918]; System.Threading.Tasks.AsyncLazy`1[[System.Int32, System.Private.CoreLib]].GetOrStartAttemptAsync(System.Threading.CancellationToken)
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
       vmovdqu32 [rbp-0A0],zmm8
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
       mov       rsi,72FBF054F4D8
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-88]
       mov       [rbp-0A0],rax
       mov       rsi,[rbp-0A0]
       mov       rdi,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      qword ptr [72FBEFA36838]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       [rbp-48],rax
       cmp       qword ptr [rbp-48],0
       je        short M01_L02
       mov       rdi,72FBF054F5E0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-48]
       mov       [rbp-98],rax
       jmp       near ptr M01_L08
M01_L02:
       mov       rsi,[rbp-40]
       mov       rdi,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt
       call      qword ptr [72FBEFA36838]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       [rbp-50],rax
       cmp       qword ptr [rbp-50],0
       je        near ptr M01_L04
       mov       rdi,[rbp-50]
       call      qword ptr [72FBF05179D8]
       test      eax,eax
       je        short M01_L03
       mov       rdi,72FBF054F5E4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdi,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-80],rax
       mov       rdi,[rbp-80]
       mov       rsi,72EC07007850
       call      qword ptr [72FBF0295260]
       mov       rdi,[rbp-80]
       call      qword ptr [72FBF0517990]; System.Threading.Tasks.Task.FromException[[System.Int32, System.Private.CoreLib]](System.Exception)
       mov       [rbp-98],rax
       jmp       near ptr M01_L08
M01_L03:
       mov       rdi,72FBF054F5E8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdi,[rbp-50]
       mov       rsi,[rbp-38]
       cmp       [rdi],edi
       call      qword ptr [72FBF05179F0]; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.Int32, System.Private.CoreLib]].WaitAsync(System.Threading.CancellationToken)
       mov       [rbp-98],rax
       jmp       near ptr M01_L08
M01_L04:
       mov       rax,[rbp-30]
       cmp       [rax],al
       mov       rax,[rbp-30]
       lea       rdi,[rax+20]
       call      qword ptr [72FBF0517900]; System.Threading.CancellationToken.get_IsCancellationRequested()
       test      eax,eax
       je        short M01_L05
       mov       rdi,72FBF054F5EC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-30]
       mov       rdi,[rax+20]
       call      qword ptr [72FBF05178D0]
       mov       [rbp-98],rax
       jmp       near ptr M01_L08
M01_L05:
       mov       rdi,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rdi,[rbp-60]
       mov       rsi,[rbp-30]
       call      qword ptr [72FBF0517A08]; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.Int32, System.Private.CoreLib]]..ctor(System.Threading.Tasks.AsyncLazy`1<Int32>)
       mov       rax,[rbp-60]
       mov       [rbp-58],rax
       mov       rax,[rbp-30]
       cmp       [rax],al
       mov       rax,[rbp-30]
       lea       rdi,[rax+8]
       mov       rsi,[rbp-58]
       xor       edx,edx
       call      qword ptr [72FBF0517A20]; System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       jne       near ptr M01_L07
       mov       rdi,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>+<>c
       call      qword ptr [72FBEFA35710]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,72EC2CC00938
       mov       rax,[rax]
       mov       [rbp-68],rax
       mov       rax,[rbp-68]
       mov       [rbp-70],rax
       cmp       qword ptr [rbp-68],0
       jne       near ptr M01_L06
       mov       rdi,72FBF054F5F0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdi,offset MT_System.Action<System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-78],rax
       mov       rdi,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>+<>c
       call      qword ptr [72FBEFA35710]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,72EC2CC00930
       mov       rax,[rax]
       mov       [rbp-0A8],rax
       mov       rsi,[rbp-0A8]
       mov       rdi,[rbp-78]
       mov       rdx,offset System.Threading.Tasks.AsyncLazy`1+<>c[[System.Int32, System.Private.CoreLib]].<GetOrStartAttemptAsync>b__11_0(Attempt<Int32>)
       call      qword ptr [72FBEFA36E08]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdi,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>+<>c
       call      qword ptr [72FBEFA35710]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rsi,[rbp-78]
       mov       rdi,72EC2CC00938
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-78]
       mov       [rbp-70],rax
M01_L06:
       mov       rdi,72FBF054F5F4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdx,[rbp-58]
       mov       rsi,[rbp-70]
       mov       rdi,72FBF054F098
       xor       ecx,ecx
       call      qword ptr [72FBF0517948]; System.Threading.ThreadPool.QueueUserWorkItem[[System.__Canon, System.Private.CoreLib]](System.Action`1<System.__Canon>, System.__Canon, Boolean)
       mov       rdi,[rbp-58]
       mov       rsi,[rbp-38]
       cmp       [rdi],edi
       call      qword ptr [72FBF05179F0]; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.Int32, System.Private.CoreLib]].WaitAsync(System.Threading.CancellationToken)
       mov       [rbp-98],rax
       jmp       short M01_L08
M01_L07:
       mov       rdi,72FBF054F5F8
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M01_L00
M01_L08:
       mov       rax,[rbp-98]
       add       rsp,0B0
       pop       rbp
       ret
; Total bytes of code 831
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

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
       call      000077B827EE6020
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
       call      qword ptr [77B7AA884A50]
       int       3
M00_L02:
       mov       rdi,[rbp-18]
       call      qword ptr [77B7AA7FEBC8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L00
M00_L03:
       call      qword ptr [77B7AA4BC438]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rbx,rax
M00_L04:
       mov       rdi,[rbp-18]
       call      000077B827EE6790
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
       call      qword ptr [77B7AA884A68]
       jmp       short M00_L05
       push      rax
       cmp       dword ptr [rbp-0C],0
       je        short M00_L08
       cmp       qword ptr [rbp-18],0
       jne       short M00_L07
       xor       edi,edi
       call      qword ptr [77B7AA884A50]
       int       3
M00_L07:
       mov       rdi,[rbp-18]
       call      000077B827EE6790
       test      eax,eax
       je        short M00_L08
       mov       edi,eax
       mov       rsi,[rbp-18]
       call      qword ptr [77B7AA884A68]
M00_L08:
       nop
       add       rsp,8
       ret
; Total bytes of code 187
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
       call      qword ptr [77B7A97FEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdi,[rbp-90]
       call      qword ptr [rax]
       lea       rdi,[rbp-88]
       call      qword ptr [77B7A97FEF08]; CORINFO_HELP_JIT_PINVOKE_END
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
       call      qword ptr [77B7A9822688]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
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
       call      qword ptr [77B7A9819630]
       int       3
       mov       rdi,rbx
       call      qword ptr [77B7A9822678]
       jmp       short M02_L01
       mov       rdi,rbx
       xor       esi,esi
       call      qword ptr [77B7A9822680]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M02_L01
       mov       rdi,[rbx]
       call      qword ptr [77B7A98014E0]
       mov       rdi,rax
       call      qword ptr [77B7A9808728]
       mov       rdi,rax
       call      qword ptr [77B7A98281A8]
       mov       rdx,rax
       mov       rsi,r15
       mov       rdi,rbx
       call      qword ptr [77B7A9822690]
       jmp       near ptr M02_L01
       mov       rax,[rbx+10]
       test      rax,rax
       je        short M02_L05
       mov       rdi,[rax+8]
       call      qword ptr [rax+18]
       mov       rdx,rax
       mov       rsi,r15
       mov       rdi,rbx
       call      qword ptr [77B7A9822690]
       jmp       near ptr M02_L01
M02_L05:
       mov       rdi,rbx
       call      qword ptr [77B7A98226A0]
       jmp       near ptr M02_L01
       mov       rdi,rbx
       mov       rsi,r15
       mov       edx,1
       call      qword ptr [77B7A9822688]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M02_L01
; Total bytes of code 278
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.HotPathBenchmarks`1[[System.Int32, System.Private.CoreLib]].VsThreading()
       mov       rdi,[rdi+28]
       cmp       [rdi],dil
       xor       esi,esi
       jmp       qword ptr [752D87B3CC30]; Microsoft.VisualStudio.Threading.AsyncLazy`1[[System.Int32, System.Private.CoreLib]].GetValueAsync(System.Threading.CancellationToken)
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
       call      qword ptr [752D87B3D008]; System.Threading.AsyncLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       test      rax,rax
       je        short M01_L00
       call      qword ptr [752D87C94AF8]
       mov       rdi,rax
       mov       rdx,751DC4C01490
       mov       rdx,[rdx]
       mov       rsi,752D7640C6F8
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rdi,rax
       xor       eax,eax
       test      rdi,rdi
       cmove     rdi,rax
       call      qword ptr [752D87B3D350]
       int       3
M01_L06:
       mov       rdi,[rsi+8]
       call      qword ptr [752D87B3D368]; System.Threading.Monitor.IsEntered(System.Object)
       test      eax,eax
       je        short M01_L07
       call      qword ptr [752D87C94AF8]
       mov       rdi,rax
       mov       rdx,751DC4C01490
       mov       rdx,[rdx]
       mov       rsi,752D7640C6F8
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rdi,rax
       xor       eax,eax
       test      rdi,rdi
       cmove     rdi,rax
       call      qword ptr [752D87B3D350]
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
       call      qword ptr [752D87055980]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rsi,[rbp-38]
       cmp       qword ptr [rsi+28],0
       jne       near ptr M01_L15
       lea       rdi,[rbp-20]
       call      qword ptr [752D87B37900]; System.Threading.CancellationToken.get_IsCancellationRequested()
       test      eax,eax
       je        short M01_L08
       lea       rdi,[rbp-20]
       call      qword ptr [752D87C94B10]
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
       call      qword ptr [752D87056E08]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rsi,[rbp-38]
       cmp       byte ptr [rsi+38],0
       jne       short M01_L10
       cmp       qword ptr [rsi+18],0
       je        short M01_L09
       mov       rdi,752D87C6B808
       call      qword ptr [752D87B3D650]
M01_L09:
       mov       rdi,offset MT_Microsoft.VisualStudio.Threading.AsyncLocal<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdi,r14
       call      qword ptr [752D87B3D3C8]; Microsoft.VisualStudio.Threading.AsyncLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rdi,[r14+8]
       mov       rsi,751DC4C00920
       mov       rsi,[rsi]
       cmp       [rdi],edi
       call      qword ptr [752D87B3D068]; System.Threading.AsyncLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
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
       call      qword ptr [752D87C94A80]
       mov       rsi,[rbp-38]
       lea       rdi,[rsi+30]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       lock or   dword ptr [rsp],0
       mov       rsi,[rbp-38]
       mov       rdi,[rsi+30]
       cmp       [rdi],dil
       call      qword ptr [752D87C94B28]
       mov       rsi,rax
       mov       rdi,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      qword ptr [752D87056310]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
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
       call      qword ptr [752D87B3D068]; System.Threading.AsyncLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
       jmp       short M01_L15
M01_L13:
       mov       rsi,[rbp-38]
       cmp       qword ptr [rsi+18],0
       je        short M01_L15
       jmp       short M01_L12
M01_L14:
       mov       rdi,[rbp-40]
       call      qword ptr [752D87056808]; System.Threading.Monitor.Exit(System.Object)
       jmp       short M01_L16
M01_L15:
       cmp       byte ptr [rbp-28],0
       jne       short M01_L14
M01_L16:
       mov       rdi,[rbx+10]
       test      rdi,rdi
       je        near ptr M01_L01
       call      qword ptr [752D87B3D428]; Microsoft.VisualStudio.Threading.InlineResumable.Resume()
       jmp       near ptr M01_L01
M01_L17:
       mov       rdx,[rbp-20]
       xor       esi,esi
       call      qword ptr [752D87B3D440]
       jmp       near ptr M01_L02
M01_L18:
       mov       rdi,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       edi,170F
       mov       rsi,752D87B676C8
       call      qword ptr [752D8705EF88]
       mov       rsi,rax
       mov       rdi,rbx
       call      qword ptr [752D878BE1C0]
       mov       rdi,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L19:
       test      dword ptr [rbx+34],1600000
       jne       near ptr M01_L03
       lea       rdi,[rbp-30]
       call      qword ptr [752D87B37900]; System.Threading.CancellationToken.get_IsCancellationRequested()
       test      eax,eax
       je        short M01_L20
       mov       rdi,[rbp-30]
       call      qword ptr [752D87B378D0]
       jmp       near ptr M01_L04
M01_L20:
       mov       rdi,rbx
       mov       rsi,[rbp-30]
       call      qword ptr [752D87B3F048]
       jmp       near ptr M01_L04
       push      rax
       mov       rsi,[rbp-38]
       mov       rdi,[rsi+18]
       test      rdi,rdi
       je        short M01_L21
       mov       rdi,[rdi+8]
       xor       esi,esi
       cmp       [rdi],edi
       call      qword ptr [752D87B3D068]; System.Threading.AsyncLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
M01_L21:
       nop
       add       rsp,8
       ret
       push      rax
       cmp       byte ptr [rbp-28],0
       je        short M01_L22
       mov       rdi,[rbp-40]
       call      qword ptr [752D87056808]; System.Threading.Monitor.Exit(System.Object)
M01_L22:
       nop
       add       rsp,8
       ret
; Total bytes of code 1018
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

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
       mov       rcx,78D454C01478
       mov       rcx,[rcx]
       mov       rdi,r14
       mov       rsi,r15
       mov       r8,rbx
       mov       edx,0FFFFFFFF
       call      qword ptr [78E419674B28]
       jmp       short M00_L03
M00_L01:
       mov       rdi,rbx
       add       rsp,8
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [78E4195278D0]
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
       call      qword ptr [78E4192AC438]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       r15,rax
       jmp       short M00_L00
M00_L05:
       mov       edi,46
       call      qword ptr [78E419674AF8]
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
       call      qword ptr [78E418612688]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
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
       call      qword ptr [78E418609630]
       int       3
       mov       rdi,rbx
       call      qword ptr [78E418612678]
       jmp       short M01_L01
       mov       rdi,rbx
       xor       esi,esi
       call      qword ptr [78E418612680]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M01_L01
       mov       rdi,[rbx]
       call      qword ptr [78E4185F14E0]
       mov       rdi,rax
       call      qword ptr [78E4185F8728]
       mov       rdi,rax
       call      qword ptr [78E4186181A8]
       mov       rdx,rax
       mov       rsi,r15
       mov       rdi,rbx
       call      qword ptr [78E418612690]
       jmp       near ptr M01_L01
       mov       rax,[rbx+10]
       test      rax,rax
       je        short M01_L05
       mov       rdi,[rax+8]
       call      qword ptr [rax+18]
       mov       rdx,rax
       mov       rsi,r15
       mov       rdi,rbx
       call      qword ptr [78E418612690]
       jmp       near ptr M01_L01
M01_L05:
       mov       rdi,rbx
       call      qword ptr [78E4186126A0]
       jmp       near ptr M01_L01
       mov       rdi,rbx
       mov       rsi,r15
       mov       edx,1
       call      qword ptr [78E418612688]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M01_L01
; Total bytes of code 278
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

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
       call      qword ptr [7A088D864A98]
       int       3
M00_L01:
       mov       rdi,rcx
       pop       rbp
       jmp       qword ptr [7A088D7178D0]
M00_L02:
       mov       rdi,rsi
       mov       rsi,rcx
       pop       rbp
       jmp       qword ptr [7A088D717918]; System.Threading.Tasks.AsyncLazy`1[[System.Int32, System.Private.CoreLib]].GetOrStartAttemptAsync(System.Threading.CancellationToken)
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
       vmovdqu32 [rbp-0A0],zmm8
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
       mov       rsi,7A088D74F4D8
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-88]
       mov       [rbp-0A0],rax
       mov       rsi,[rbp-0A0]
       mov       rdi,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      qword ptr [7A088CC36838]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       [rbp-48],rax
       cmp       qword ptr [rbp-48],0
       je        short M01_L02
       mov       rdi,7A088D74F5E0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-48]
       mov       [rbp-98],rax
       jmp       near ptr M01_L08
M01_L02:
       mov       rsi,[rbp-40]
       mov       rdi,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt
       call      qword ptr [7A088CC36838]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       [rbp-50],rax
       cmp       qword ptr [rbp-50],0
       je        near ptr M01_L04
       mov       rdi,[rbp-50]
       call      qword ptr [7A088D7179D8]
       test      eax,eax
       je        short M01_L03
       mov       rdi,7A088D74F5E4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdi,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-80],rax
       mov       rdi,[rbp-80]
       mov       rsi,79F8A3E07850
       call      qword ptr [7A088D495260]
       mov       rdi,[rbp-80]
       call      qword ptr [7A088D717990]; System.Threading.Tasks.Task.FromException[[System.Int32, System.Private.CoreLib]](System.Exception)
       mov       [rbp-98],rax
       jmp       near ptr M01_L08
M01_L03:
       mov       rdi,7A088D74F5E8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdi,[rbp-50]
       mov       rsi,[rbp-38]
       cmp       [rdi],edi
       call      qword ptr [7A088D7179F0]; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.Int32, System.Private.CoreLib]].WaitAsync(System.Threading.CancellationToken)
       mov       [rbp-98],rax
       jmp       near ptr M01_L08
M01_L04:
       mov       rax,[rbp-30]
       cmp       [rax],al
       mov       rax,[rbp-30]
       lea       rdi,[rax+20]
       call      qword ptr [7A088D717900]; System.Threading.CancellationToken.get_IsCancellationRequested()
       test      eax,eax
       je        short M01_L05
       mov       rdi,7A088D74F5EC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-30]
       mov       rdi,[rax+20]
       call      qword ptr [7A088D7178D0]
       mov       [rbp-98],rax
       jmp       near ptr M01_L08
M01_L05:
       mov       rdi,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rdi,[rbp-60]
       mov       rsi,[rbp-30]
       call      qword ptr [7A088D717A08]; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.Int32, System.Private.CoreLib]]..ctor(System.Threading.Tasks.AsyncLazy`1<Int32>)
       mov       rax,[rbp-60]
       mov       [rbp-58],rax
       mov       rax,[rbp-30]
       cmp       [rax],al
       mov       rax,[rbp-30]
       lea       rdi,[rax+8]
       mov       rsi,[rbp-58]
       xor       edx,edx
       call      qword ptr [7A088D717A20]; System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       jne       near ptr M01_L07
       mov       rdi,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>+<>c
       call      qword ptr [7A088CC35710]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,79F8C8C00938
       mov       rax,[rax]
       mov       [rbp-68],rax
       mov       rax,[rbp-68]
       mov       [rbp-70],rax
       cmp       qword ptr [rbp-68],0
       jne       near ptr M01_L06
       mov       rdi,7A088D74F5F0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdi,offset MT_System.Action<System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-78],rax
       mov       rdi,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>+<>c
       call      qword ptr [7A088CC35710]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,79F8C8C00930
       mov       rax,[rax]
       mov       [rbp-0A8],rax
       mov       rsi,[rbp-0A8]
       mov       rdi,[rbp-78]
       mov       rdx,offset System.Threading.Tasks.AsyncLazy`1+<>c[[System.Int32, System.Private.CoreLib]].<GetOrStartAttemptAsync>b__11_0(Attempt<Int32>)
       call      qword ptr [7A088CC36E08]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdi,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>+<>c
       call      qword ptr [7A088CC35710]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rsi,[rbp-78]
       mov       rdi,79F8C8C00938
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-78]
       mov       [rbp-70],rax
M01_L06:
       mov       rdi,7A088D74F5F4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdx,[rbp-58]
       mov       rsi,[rbp-70]
       mov       rdi,7A088D74F098
       xor       ecx,ecx
       call      qword ptr [7A088D717948]; System.Threading.ThreadPool.QueueUserWorkItem[[System.__Canon, System.Private.CoreLib]](System.Action`1<System.__Canon>, System.__Canon, Boolean)
       mov       rdi,[rbp-58]
       mov       rsi,[rbp-38]
       cmp       [rdi],edi
       call      qword ptr [7A088D7179F0]; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.Int32, System.Private.CoreLib]].WaitAsync(System.Threading.CancellationToken)
       mov       [rbp-98],rax
       jmp       short M01_L08
M01_L07:
       mov       rdi,7A088D74F5F8
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M01_L00
M01_L08:
       mov       rax,[rbp-98]
       add       rsp,0B0
       pop       rbp
       ret
; Total bytes of code 831
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

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
       call      00007F71A0AE6020
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
       call      qword ptr [7F7123454B10]
       int       3
M00_L02:
       mov       rdi,[rbp-28]
       call      qword ptr [7F7123454BB8]
       jmp       short M00_L00
M00_L03:
       call      qword ptr [7F712308C438]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       r15,rax
M00_L04:
       mov       rdi,[rbp-28]
       call      00007F71A0AE6790
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
       mov       rcx,7F6160C01478
       mov       rcx,[rcx]
       mov       rdi,r14
       mov       rsi,r15
       mov       r8,rbx
       mov       edx,0FFFFFFFF
       call      qword ptr [7F7123454B70]
       jmp       short M00_L08
M00_L06:
       mov       rdi,rbx
       add       rsp,18
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7F71233078D0]
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
       call      qword ptr [7F7123454B28]
       jmp       near ptr M00_L05
M00_L10:
       mov       edi,46
       call      qword ptr [7F7123454B40]
       int       3
       push      rax
       cmp       dword ptr [rbp-1C],0
       je        short M00_L12
       cmp       qword ptr [rbp-28],0
       jne       short M00_L11
       xor       edi,edi
       call      qword ptr [7F7123454B10]
       int       3
M00_L11:
       mov       rdi,[rbp-28]
       call      00007F71A0AE6790
       test      eax,eax
       je        short M00_L12
       mov       edi,eax
       mov       rsi,[rbp-28]
       call      qword ptr [7F7123454B28]
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
       call      qword ptr [7F71223F2688]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
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
       call      qword ptr [7F71223E9630]
       int       3
       mov       rdi,rbx
       call      qword ptr [7F71223F2678]
       jmp       short M01_L01
       mov       rdi,rbx
       xor       esi,esi
       call      qword ptr [7F71223F2680]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M01_L01
       mov       rdi,[rbx]
       call      qword ptr [7F71223D14E0]
       mov       rdi,rax
       call      qword ptr [7F71223D8728]
       mov       rdi,rax
       call      qword ptr [7F71223F81A8]
       mov       rdx,rax
       mov       rsi,r15
       mov       rdi,rbx
       call      qword ptr [7F71223F2690]
       jmp       near ptr M01_L01
       mov       rax,[rbx+10]
       test      rax,rax
       je        short M01_L05
       mov       rdi,[rax+8]
       call      qword ptr [rax+18]
       mov       rdx,rax
       mov       rsi,r15
       mov       rdi,rbx
       call      qword ptr [7F71223F2690]
       jmp       near ptr M01_L01
M01_L05:
       mov       rdi,rbx
       call      qword ptr [7F71223F26A0]
       jmp       near ptr M01_L01
       mov       rdi,rbx
       mov       rsi,r15
       mov       edx,1
       call      qword ptr [7F71223F2688]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M01_L01
; Total bytes of code 278
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

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
       jmp       qword ptr [714A5E10CC30]; Microsoft.VisualStudio.Threading.AsyncLazy`1[[System.Int32, System.Private.CoreLib]].GetValueAsync(System.Threading.CancellationToken)
M00_L00:
       mov       edi,46
       call      qword ptr [714A5E254A50]
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
       call      qword ptr [714A5E10D038]; System.Threading.AsyncLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       test      rax,rax
       je        near ptr M01_L00
       call      qword ptr [714A5E254B40]
       mov       rdi,rax
       mov       rdx,713A98C014A8
       mov       rdx,[rdx]
       mov       rsi,714A58A0C6F8
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rdi,rax
       xor       eax,eax
       test      rdi,rdi
       cmove     rdi,rax
       call      qword ptr [714A5E10D350]
       int       3
M01_L06:
       mov       rdi,[rsi+8]
       call      qword ptr [714A5E10D368]; System.Threading.Monitor.IsEntered(System.Object)
       test      eax,eax
       je        short M01_L07
       call      qword ptr [714A5E254B40]
       mov       rdi,rax
       mov       rdx,713A98C014A8
       mov       rdx,[rdx]
       mov       rsi,714A58A0C6F8
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rdi,rax
       xor       eax,eax
       test      rdi,rdi
       cmove     rdi,rax
       call      qword ptr [714A5E10D350]
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
       call      qword ptr [714A5D625980]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rsi,[rbp-38]
       cmp       qword ptr [rsi+28],0
       jne       near ptr M01_L15
       lea       rdi,[rbp-20]
       call      qword ptr [714A5E107900]; System.Threading.CancellationToken.get_IsCancellationRequested()
       test      eax,eax
       je        short M01_L08
       lea       rdi,[rbp-20]
       call      qword ptr [714A5E254B58]
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
       call      qword ptr [714A5D626E08]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rsi,[rbp-38]
       cmp       byte ptr [rsi+38],0
       jne       short M01_L10
       cmp       qword ptr [rsi+18],0
       je        short M01_L09
       mov       rdi,714A5E23B4F0
       call      qword ptr [714A5E10D500]
M01_L09:
       mov       rdi,offset MT_Microsoft.VisualStudio.Threading.AsyncLocal<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdi,r14
       call      qword ptr [714A5E10D3C8]; Microsoft.VisualStudio.Threading.AsyncLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rdi,[r14+8]
       mov       rsi,713A98C00920
       mov       rsi,[rsi]
       cmp       [rdi],edi
       call      qword ptr [714A5E10D068]; System.Threading.AsyncLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
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
       call      qword ptr [714A5E254AC8]
       mov       rsi,[rbp-38]
       lea       rdi,[rsi+30]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       lock or   dword ptr [rsp],0
       mov       rsi,[rbp-38]
       mov       rdi,[rsi+30]
       cmp       [rdi],dil
       call      qword ptr [714A5E254B70]
       mov       rsi,rax
       mov       rdi,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      qword ptr [714A5D626310]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
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
       call      qword ptr [714A5E10D068]; System.Threading.AsyncLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
       jmp       short M01_L15
M01_L13:
       mov       rsi,[rbp-38]
       cmp       qword ptr [rsi+18],0
       je        short M01_L15
       jmp       short M01_L12
M01_L14:
       mov       rdi,[rbp-40]
       call      qword ptr [714A5D626808]; System.Threading.Monitor.Exit(System.Object)
       jmp       short M01_L16
M01_L15:
       cmp       byte ptr [rbp-28],0
       jne       short M01_L14
M01_L16:
       mov       rdi,[rbx+10]
       test      rdi,rdi
       je        near ptr M01_L01
       call      qword ptr [714A5E10D428]; Microsoft.VisualStudio.Threading.InlineResumable.Resume()
       jmp       near ptr M01_L01
M01_L17:
       mov       rdx,[rbp-20]
       xor       esi,esi
       call      qword ptr [714A5E10D440]
       jmp       near ptr M01_L02
M01_L18:
       mov       rdi,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       edi,170F
       mov       rsi,714A5E1376C8
       call      qword ptr [714A5D62EF88]
       mov       rsi,rax
       mov       rdi,rbx
       call      qword ptr [714A5DE8E1C0]
       mov       rdi,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L19:
       lea       rdi,[rbp-30]
       call      qword ptr [714A5E107900]; System.Threading.CancellationToken.get_IsCancellationRequested()
       test      eax,eax
       je        short M01_L20
       mov       rdi,[rbp-30]
       call      qword ptr [714A5E1078D0]
       jmp       near ptr M01_L04
M01_L20:
       mov       rdi,rbx
       mov       rsi,[rbp-30]
       call      qword ptr [714A5E10F060]
       jmp       near ptr M01_L04
       push      rax
       mov       rsi,[rbp-38]
       mov       rdi,[rsi+18]
       test      rdi,rdi
       je        short M01_L21
       mov       rdi,[rdi+8]
       xor       esi,esi
       cmp       [rdi],edi
       call      qword ptr [714A5E10D068]; System.Threading.AsyncLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
M01_L21:
       nop
       add       rsp,8
       ret
       push      rax
       cmp       byte ptr [rbp-28],0
       je        short M01_L22
       mov       rdi,[rbp-40]
       call      qword ptr [714A5D626808]; System.Threading.Monitor.Exit(System.Object)
M01_L22:
       nop
       add       rsp,8
       ret
; Total bytes of code 1018
```

