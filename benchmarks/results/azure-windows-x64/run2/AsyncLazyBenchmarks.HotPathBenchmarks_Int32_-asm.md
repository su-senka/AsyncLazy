## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.HotPathBenchmarks`1[[System.Int32, System.Private.CoreLib]].LazyOfTask()
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+8],0
       jne       short M00_L00
       mov       rax,[rcx+18]
       ret
M00_L00:
       jmp       qword ptr [7FF80D085860]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
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
; AsyncLazyBenchmarks.HotPathBenchmarks`1[[System.Int32, System.Private.CoreLib]].AsyncLazy()
       mov       rcx,[rcx+18]
       mov       rax,[rcx+10]
       test      rax,rax
       je        short M00_L00
       ret
M00_L00:
       xor       edx,edx
       jmp       qword ptr [7FF80D144D20]; System.Threading.Tasks.AsyncLazy`1[[System.Int32, System.Private.CoreLib]].GetOrStartAttemptAsync(System.Threading.CancellationToken)
; Total bytes of code 22
```
```assembly
; System.Threading.Tasks.AsyncLazy`1[[System.Int32, System.Private.CoreLib]].GetOrStartAttemptAsync(System.Threading.CancellationToken)
       push      rbp
       sub       rsp,0D0
       lea       rbp,[rsp+0D0]
       xor       eax,eax
       mov       [rbp-0A8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu32 [rbp-0A0],zmm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       [rbp-40],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       dword ptr [rbp-90],3E8
M01_L00:
       mov       eax,[rbp-90]
       dec       eax
       mov       [rbp-90],eax
       cmp       dword ptr [rbp-90],0
       jg        short M01_L01
       lea       rcx,[rbp-90]
       xor       edx,edx
       call      CORINFO_HELP_PATCHPOINT
M01_L01:
       mov       rax,[rbp+10]
       mov       rax,[rax+8]
       mov       [rbp-40],rax
       mov       rax,[rbp-40]
       mov       [rbp-88],rax
       mov       rcx,[rbp-88]
       mov       rdx,7FF80D15EB78
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-88]
       mov       [rbp-0A0],rax
       mov       rdx,[rbp-0A0]
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      qword ptr [7FF80CDD6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       [rbp-48],rax
       cmp       qword ptr [rbp-48],0
       je        short M01_L02
       mov       rcx,7FF80D15EC80
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-48]
       mov       [rbp-98],rax
       jmp       near ptr M01_L08
M01_L02:
       mov       rdx,[rbp-40]
       mov       rcx,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt
       call      qword ptr [7FF80CDD6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       [rbp-50],rax
       cmp       qword ptr [rbp-50],0
       je        near ptr M01_L04
       mov       rcx,[rbp-50]
       call      qword ptr [7FF80D144DE0]
       test      eax,eax
       je        short M01_L03
       mov       rcx,7FF80D15EC84
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-80],rax
       mov       rcx,[rbp-80]
       mov       rdx,28AA5396410
       call      qword ptr [7FF80D0B7D50]
       mov       rcx,[rbp-80]
       call      qword ptr [7FF80D144D98]; System.Threading.Tasks.Task.FromException[[System.Int32, System.Private.CoreLib]](System.Exception)
       mov       [rbp-98],rax
       jmp       near ptr M01_L08
M01_L03:
       mov       rcx,7FF80D15EC88
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp-50]
       mov       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF80D144DF8]; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.Int32, System.Private.CoreLib]].WaitAsync(System.Threading.CancellationToken)
       mov       [rbp-98],rax
       jmp       near ptr M01_L08
M01_L04:
       mov       rax,[rbp+10]
       cmp       [rax],al
       mov       rax,[rbp+10]
       lea       rcx,[rax+20]
       call      qword ptr [7FF80D144D08]; System.Threading.CancellationToken.get_IsCancellationRequested()
       test      eax,eax
       je        short M01_L05
       mov       rcx,7FF80D15EC8C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp+10]
       mov       rcx,[rax+20]
       call      qword ptr [7FF80D144CD8]
       mov       [rbp-98],rax
       jmp       near ptr M01_L08
M01_L05:
       mov       rcx,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       rdx,[rbp+10]
       call      qword ptr [7FF80D144E10]; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.Int32, System.Private.CoreLib]]..ctor(System.Threading.Tasks.AsyncLazy`1<Int32>)
       mov       rax,[rbp-60]
       mov       [rbp-58],rax
       mov       rax,[rbp+10]
       cmp       [rax],al
       mov       rax,[rbp+10]
       lea       rcx,[rax+8]
       mov       rdx,[rbp-58]
       xor       r8d,r8d
       call      qword ptr [7FF80D144E28]; System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       jne       near ptr M01_L07
       mov       rcx,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>+<>c
       call      qword ptr [7FF80CDD5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,28AB50008D8
       mov       rax,[rax]
       mov       [rbp-68],rax
       mov       rax,[rbp-68]
       mov       [rbp-70],rax
       cmp       qword ptr [rbp-68],0
       jne       near ptr M01_L06
       mov       rcx,7FF80D15EC90
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,offset MT_System.Action<System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-78],rax
       mov       rcx,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>+<>c
       call      qword ptr [7FF80CDD5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,28AB50008D0
       mov       rax,[rax]
       mov       [rbp-0A8],rax
       mov       rdx,[rbp-0A8]
       mov       rcx,[rbp-78]
       mov       r8,offset System.Threading.Tasks.AsyncLazy`1+<>c[[System.Int32, System.Private.CoreLib]].<GetOrStartAttemptAsync>b__11_0(Attempt<Int32>)
       call      qword ptr [7FF80CDD6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>+<>c
       call      qword ptr [7FF80CDD5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rbp-78]
       mov       rcx,28AB50008D8
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-78]
       mov       [rbp-70],rax
M01_L06:
       mov       rcx,7FF80D15EC94
       call      CORINFO_HELP_COUNTPROFILE32
       mov       r8,[rbp-58]
       mov       rdx,[rbp-70]
       mov       rcx,7FF80D15E738
       xor       r9d,r9d
       call      qword ptr [7FF80D144D50]; System.Threading.ThreadPool.QueueUserWorkItem[[System.__Canon, System.Private.CoreLib]](System.Action`1<System.__Canon>, System.__Canon, Boolean)
       mov       rcx,[rbp-58]
       mov       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF80D144DF8]; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.Int32, System.Private.CoreLib]].WaitAsync(System.Threading.CancellationToken)
       mov       [rbp-98],rax
       jmp       short M01_L08
M01_L07:
       mov       rcx,7FF80D15EC98
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M01_L00
M01_L08:
       mov       rax,[rbp-98]
       add       rsp,0D0
       pop       rbp
       ret
; Total bytes of code 832
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.HotPathBenchmarks`1[[System.Int32, System.Private.CoreLib]].Nito()
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
       call      qword ptr [7FF80D1DDEF0]
       int       3
M00_L02:
       mov       rcx,[rbp-18]
       call      qword ptr [7FF80D1DDF38]
       jmp       short M00_L00
M00_L03:
       call      qword ptr [7FF80D085860]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
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
       call      qword ptr [7FF80D1DDF08]
       jmp       short M00_L05
       sub       rsp,28
       cmp       dword ptr [rbp-0C],0
       je        short M00_L08
       cmp       qword ptr [rbp-18],0
       jne       short M00_L07
       xor       ecx,ecx
       call      qword ptr [7FF80D1DDEF0]
       int       3
M00_L07:
       mov       rcx,[rbp-18]
       call      00007FF86CA5E040
       test      eax,eax
       je        short M00_L08
       mov       ecx,eax
       mov       rdx,[rbp-18]
       call      qword ptr [7FF80D1DDF08]
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
; AsyncLazyBenchmarks.HotPathBenchmarks`1[[System.Int32, System.Private.CoreLib]].VsThreading()
       mov       rcx,[rcx+28]
       cmp       [rcx],cl
       xor       edx,edx
       jmp       qword ptr [7FF80D135EC0]; Microsoft.VisualStudio.Threading.AsyncLazy`1[[System.Int32, System.Private.CoreLib]].GetValueAsync(System.Threading.CancellationToken)
; Total bytes of code 14
```
```assembly
; Microsoft.VisualStudio.Threading.AsyncLazy`1[[System.Int32, System.Private.CoreLib]].GetValueAsync(System.Threading.CancellationToken)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-20],rax
       mov       [rbp-28],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       rcx,offset MT_Microsoft.VisualStudio.Threading.AsyncLazy<System.Int32>+<>c__DisplayClass20_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp+10]
       mov       rcx,[rdx+28]
       test      rcx,rcx
       je        short M01_L05
       test      dword ptr [rcx+34],1600000
       je        short M01_L05
M01_L00:
       mov       rdx,[rbp+10]
       cmp       qword ptr [rdx+28],0
       je        near ptr M01_L06
M01_L01:
       mov       rdx,[rbp+10]
       lock or   dword ptr [rsp],0
       mov       rcx,[rdx+30]
       test      rcx,rcx
       jne       near ptr M01_L17
       xor       eax,eax
M01_L02:
       test      rax,rax
       jne       short M01_L04
       mov       rdx,[rbp+10]
       mov       rbx,[rdx+28]
       mov       rcx,[rbp+18]
       mov       [rbp-28],rcx
       test      rbx,rbx
       je        near ptr M01_L18
       cmp       qword ptr [rbp-28],0
       jne       near ptr M01_L19
M01_L03:
       mov       rax,rbx
M01_L04:
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L05:
       mov       rcx,[rdx+18]
       test      rcx,rcx
       je        short M01_L00
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF80D1368B0]; System.Threading.AsyncLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       test      rax,rax
       je        short M01_L00
       call      qword ptr [7FF80D1FDFC8]
       mov       rcx,rax
       mov       r8,24FDD801438
       mov       r8,[r8]
       mov       rdx,24FA52AB590
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rcx,rax
       xor       eax,eax
       test      rcx,rcx
       cmove     rcx,rax
       call      qword ptr [7FF80D136208]
       int       3
M01_L06:
       mov       rcx,[rdx+8]
       call      qword ptr [7FF80D136220]; System.Threading.Monitor.IsEntered(System.Object)
       test      eax,eax
       je        short M01_L07
       call      qword ptr [7FF80D1FDFC8]
       mov       rcx,rax
       mov       r8,24FDD801438
       mov       r8,[r8]
       mov       rdx,24FA52AB590
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rcx,rax
       xor       eax,eax
       test      rcx,rcx
       cmove     rcx,rax
       call      qword ptr [7FF80D136208]
       int       3
M01_L07:
       xor       edx,edx
       mov       [rbx+10],rdx
       mov       rdx,[rbp+10]
       mov       rcx,[rdx+8]
       mov       [rbp-30],rcx
       xor       ecx,ecx
       mov       [rbp-20],ecx
       lea       rdx,[rbp-20]
       mov       rcx,[rbp-30]
       call      qword ptr [7FF80CDC5998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rdx,[rbp+10]
       cmp       qword ptr [rdx+28],0
       jne       near ptr M01_L15
       lea       rcx,[rbp+18]
       call      qword ptr [7FF80D134D08]; System.Threading.CancellationToken.get_IsCancellationRequested()
       test      eax,eax
       je        short M01_L08
       lea       rcx,[rbp+18]
       call      qword ptr [7FF80D1FDFE0]
       int       3
M01_L08:
       mov       rcx,offset MT_Microsoft.VisualStudio.Threading.InlineResumable
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rbx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       lea       rcx,[rbx+18]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       rdx,[rbp+10]
       mov       [rdx+20],rcx
       mov       rcx,offset MT_System.Func<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r8,offset Microsoft.VisualStudio.Threading.AsyncLazy`1+<>c__DisplayClass20_0[[System.Int32, System.Private.CoreLib]].<GetValueAsync>b__0()
       call      qword ptr [7FF80CDC6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp+10]
       cmp       byte ptr [rdx+38],0
       jne       short M01_L10
       cmp       qword ptr [rdx+18],0
       je        short M01_L09
       mov       rcx,7FF80D2608D0
       call      qword ptr [7FF80D1365E0]
M01_L09:
       mov       rcx,offset MT_Microsoft.VisualStudio.Threading.AsyncLocal<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      qword ptr [7FF80D136280]; Microsoft.VisualStudio.Threading.AsyncLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rdi+8]
       mov       rdx,24FDD8008C0
       mov       rdx,[rdx]
       cmp       [rcx],ecx
       call      qword ptr [7FF80D1368E0]; System.Threading.AsyncLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
       mov       rdx,[rbp+10]
       lea       rcx,[rdx+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp+10]
M01_L10:
       cmp       qword ptr [rdx+10],0
       je        short M01_L11
       mov       rcx,[rdx+10]
       cmp       [rcx],cl
       xor       r8d,r8d
       mov       [rsp+20],r8d
       mov       rdx,rsi
       xor       r9d,r9d
       call      qword ptr [7FF80D1FDF68]
       mov       rdx,[rbp+10]
       lea       rcx,[rdx+30]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lock or   dword ptr [rsp],0
       mov       rdx,[rbp+10]
       mov       rcx,[rdx+30]
       cmp       [rcx],cl
       call      qword ptr [7FF80D1FDFF8]
       mov       rdx,rax
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      qword ptr [7FF80CDC6328]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rdx,[rbp+10]
       lea       rcx,[rdx+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L13
M01_L11:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       rdx,[rbp+10]
       lea       rcx,[rdx+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L13
M01_L12:
       mov       rcx,[rdx+18]
       mov       rcx,[rcx+8]
       xor       edx,edx
       cmp       [rcx],ecx
       call      qword ptr [7FF80D1368E0]; System.Threading.AsyncLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
       jmp       short M01_L15
M01_L13:
       mov       rdx,[rbp+10]
       cmp       qword ptr [rdx+18],0
       je        short M01_L15
       jmp       short M01_L12
M01_L14:
       mov       rcx,[rbp-30]
       call      qword ptr [7FF80CDC6820]; System.Threading.Monitor.Exit(System.Object)
       jmp       short M01_L16
M01_L15:
       cmp       byte ptr [rbp-20],0
       jne       short M01_L14
M01_L16:
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        near ptr M01_L01
       call      qword ptr [7FF80D1362E0]; Microsoft.VisualStudio.Threading.InlineResumable.Resume()
       jmp       near ptr M01_L01
M01_L17:
       mov       r8,[rbp+18]
       xor       edx,edx
       call      qword ptr [7FF80D1362F8]
       jmp       near ptr M01_L02
M01_L18:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,170F
       mov       rdx,7FF80D1467E8
       call      qword ptr [7FF80CDCF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80D0A75B8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L19:
       test      dword ptr [rbx+34],1600000
       jne       near ptr M01_L03
       lea       rcx,[rbp-28]
       call      qword ptr [7FF80D134D08]; System.Threading.CancellationToken.get_IsCancellationRequested()
       test      eax,eax
       je        short M01_L20
       mov       rcx,[rbp-28]
       call      qword ptr [7FF80D134CD8]
       jmp       near ptr M01_L04
M01_L20:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      qword ptr [7FF80D13CB28]
       jmp       near ptr M01_L04
       sub       rsp,28
       mov       rdx,[rbp+10]
       mov       rcx,[rdx+18]
       test      rcx,rcx
       je        short M01_L21
       mov       rcx,[rcx+8]
       xor       edx,edx
       cmp       [rcx],ecx
       call      qword ptr [7FF80D1368E0]; System.Threading.AsyncLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
M01_L21:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       byte ptr [rbp-20],0
       je        short M01_L22
       mov       rcx,[rbp-30]
       call      qword ptr [7FF80CDC6820]; System.Threading.Monitor.Exit(System.Object)
M01_L22:
       nop
       add       rsp,28
       ret
; Total bytes of code 1021
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.HotPathBenchmarks`1[[System.Int32, System.Private.CoreLib]].LazyOfTask_Token()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rcx,[rbx+10]
       cmp       qword ptr [rcx+8],0
       jne       short M00_L04
       mov       rsi,[rcx+18]
M00_L00:
       mov       rbx,[rbx+8]
       cmp       byte ptr [rbx+24],0
       jne       short M00_L05
       test      dword ptr [rsi+34],1600000
       jne       short M00_L02
       cmp       dword ptr [rbx+20],0
       jne       short M00_L01
       mov       rcx,offset MT_System.Threading.Tasks.Task+CancellationPromise<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rsp+20],rbx
       mov       r9,2E797401420
       mov       r9,[r9]
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8d,0FFFFFFFF
       call      qword ptr [7FF80D1DDFC8]
       jmp       short M00_L03
M00_L01:
       mov       rcx,rbx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF80D114CD8]
M00_L02:
       mov       rdi,rsi
M00_L03:
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L04:
       call      qword ptr [7FF80D085860]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rsi,rax
       jmp       short M00_L00
M00_L05:
       mov       ecx,46
       call      qword ptr [7FF80D1DDF98]
       int       3
; Total bytes of code 159
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
; AsyncLazyBenchmarks.HotPathBenchmarks`1[[System.Int32, System.Private.CoreLib]].AsyncLazy_Token()
       sub       rsp,28
       mov       rdx,[rcx+18]
       mov       r8,[rcx+8]
       cmp       byte ptr [r8+24],0
       jne       short M00_L00
       cmp       [rdx],dl
       cmp       dword ptr [r8+20],0
       jne       short M00_L01
       mov       rax,[rdx+10]
       test      rax,rax
       je        short M00_L02
       add       rsp,28
       ret
M00_L00:
       mov       ecx,46
       call      qword ptr [7FF80D21DF08]
       int       3
M00_L01:
       mov       rcx,r8
       add       rsp,28
       jmp       qword ptr [7FF80D154CD8]
M00_L02:
       mov       rcx,rdx
       mov       rdx,r8
       add       rsp,28
       jmp       qword ptr [7FF80D154D20]; System.Threading.Tasks.AsyncLazy`1[[System.Int32, System.Private.CoreLib]].GetOrStartAttemptAsync(System.Threading.CancellationToken)
; Total bytes of code 83
```
```assembly
; System.Threading.Tasks.AsyncLazy`1[[System.Int32, System.Private.CoreLib]].GetOrStartAttemptAsync(System.Threading.CancellationToken)
       push      rbp
       sub       rsp,0D0
       lea       rbp,[rsp+0D0]
       xor       eax,eax
       mov       [rbp-0A8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu32 [rbp-0A0],zmm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       [rbp-40],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       dword ptr [rbp-90],3E8
M01_L00:
       mov       eax,[rbp-90]
       dec       eax
       mov       [rbp-90],eax
       cmp       dword ptr [rbp-90],0
       jg        short M01_L01
       lea       rcx,[rbp-90]
       xor       edx,edx
       call      CORINFO_HELP_PATCHPOINT
M01_L01:
       mov       rax,[rbp+10]
       mov       rax,[rax+8]
       mov       [rbp-40],rax
       mov       rax,[rbp-40]
       mov       [rbp-88],rax
       mov       rcx,[rbp-88]
       mov       rdx,7FF80D16EB78
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rax,[rbp-88]
       mov       [rbp-0A0],rax
       mov       rdx,[rbp-0A0]
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      qword ptr [7FF80CDE6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       [rbp-48],rax
       cmp       qword ptr [rbp-48],0
       je        short M01_L02
       mov       rcx,7FF80D16EC80
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-48]
       mov       [rbp-98],rax
       jmp       near ptr M01_L08
M01_L02:
       mov       rdx,[rbp-40]
       mov       rcx,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt
       call      qword ptr [7FF80CDE6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       [rbp-50],rax
       cmp       qword ptr [rbp-50],0
       je        near ptr M01_L04
       mov       rcx,[rbp-50]
       call      qword ptr [7FF80D154DE0]
       test      eax,eax
       je        short M01_L03
       mov       rcx,7FF80D16EC84
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-80],rax
       mov       rcx,[rbp-80]
       mov       rdx,165B0AD6410
       call      qword ptr [7FF80D0C7D50]
       mov       rcx,[rbp-80]
       call      qword ptr [7FF80D154D98]; System.Threading.Tasks.Task.FromException[[System.Int32, System.Private.CoreLib]](System.Exception)
       mov       [rbp-98],rax
       jmp       near ptr M01_L08
M01_L03:
       mov       rcx,7FF80D16EC88
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp-50]
       mov       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF80D154DF8]; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.Int32, System.Private.CoreLib]].WaitAsync(System.Threading.CancellationToken)
       mov       [rbp-98],rax
       jmp       near ptr M01_L08
M01_L04:
       mov       rax,[rbp+10]
       cmp       [rax],al
       mov       rax,[rbp+10]
       lea       rcx,[rax+20]
       call      qword ptr [7FF80D154D08]; System.Threading.CancellationToken.get_IsCancellationRequested()
       test      eax,eax
       je        short M01_L05
       mov       rcx,7FF80D16EC8C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp+10]
       mov       rcx,[rax+20]
       call      qword ptr [7FF80D154CD8]
       mov       [rbp-98],rax
       jmp       near ptr M01_L08
M01_L05:
       mov       rcx,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       rdx,[rbp+10]
       call      qword ptr [7FF80D154E10]; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.Int32, System.Private.CoreLib]]..ctor(System.Threading.Tasks.AsyncLazy`1<Int32>)
       mov       rax,[rbp-60]
       mov       [rbp-58],rax
       mov       rax,[rbp+10]
       cmp       [rax],al
       mov       rax,[rbp+10]
       lea       rcx,[rax+8]
       mov       rdx,[rbp-58]
       xor       r8d,r8d
       call      qword ptr [7FF80D154E28]; System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       test      rax,rax
       jne       near ptr M01_L07
       mov       rcx,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>+<>c
       call      qword ptr [7FF80CDE5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,1558C4008D8
       mov       rax,[rax]
       mov       [rbp-68],rax
       mov       rax,[rbp-68]
       mov       [rbp-70],rax
       cmp       qword ptr [rbp-68],0
       jne       near ptr M01_L06
       mov       rcx,7FF80D16EC90
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,offset MT_System.Action<System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-78],rax
       mov       rcx,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>+<>c
       call      qword ptr [7FF80CDE5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,1558C4008D0
       mov       rax,[rax]
       mov       [rbp-0A8],rax
       mov       rdx,[rbp-0A8]
       mov       rcx,[rbp-78]
       mov       r8,offset System.Threading.Tasks.AsyncLazy`1+<>c[[System.Int32, System.Private.CoreLib]].<GetOrStartAttemptAsync>b__11_0(Attempt<Int32>)
       call      qword ptr [7FF80CDE6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>+<>c
       call      qword ptr [7FF80CDE5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rbp-78]
       mov       rcx,1558C4008D8
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-78]
       mov       [rbp-70],rax
M01_L06:
       mov       rcx,7FF80D16EC94
       call      CORINFO_HELP_COUNTPROFILE32
       mov       r8,[rbp-58]
       mov       rdx,[rbp-70]
       mov       rcx,7FF80D16E738
       xor       r9d,r9d
       call      qword ptr [7FF80D154D50]; System.Threading.ThreadPool.QueueUserWorkItem[[System.__Canon, System.Private.CoreLib]](System.Action`1<System.__Canon>, System.__Canon, Boolean)
       mov       rcx,[rbp-58]
       mov       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF80D154DF8]; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.Int32, System.Private.CoreLib]].WaitAsync(System.Threading.CancellationToken)
       mov       [rbp-98],rax
       jmp       short M01_L08
M01_L07:
       mov       rcx,7FF80D16EC98
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M01_L00
M01_L08:
       mov       rax,[rbp-98]
       add       rsp,0D0
       pop       rbp
       ret
; Total bytes of code 832
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.HotPathBenchmarks`1[[System.Int32, System.Private.CoreLib]].Nito_Token()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       rbx,rcx
       mov       rsi,[rbx+20]
       mov       rcx,[rsi+8]
       mov       [rbp-28],rcx
       xor       eax,eax
       mov       [rbp-1C],eax
       test      rcx,rcx
       je        short M00_L01
       call      00007FF86CA5E120
       test      eax,eax
       je        short M00_L02
M00_L00:
       mov       dword ptr [rbp-1C],1
       mov       rcx,[rsi+18]
       cmp       qword ptr [rcx+8],0
       jne       short M00_L03
       mov       rsi,[rcx+18]
       jmp       short M00_L04
M00_L01:
       xor       ecx,ecx
       call      qword ptr [7FF80D1FDFB0]
       int       3
M00_L02:
       mov       rcx,[rbp-28]
       call      qword ptr [7FF80D1FC5D0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L00
M00_L03:
       call      qword ptr [7FF80D0A5860]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rsi,rax
M00_L04:
       mov       rcx,[rbp-28]
       call      00007FF86CA5E040
       test      eax,eax
       jne       short M00_L09
M00_L05:
       mov       rbx,[rbx+8]
       cmp       byte ptr [rbx+24],0
       jne       short M00_L10
       test      dword ptr [rsi+34],1600000
       jne       short M00_L07
       cmp       dword ptr [rbx+20],0
       jne       short M00_L06
       mov       rcx,offset MT_System.Threading.Tasks.Task+CancellationPromise<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rsp+20],rbx
       mov       r9,26F5F801420
       mov       r9,[r9]
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8d,0FFFFFFFF
       call      qword ptr [7FF80D1FE010]
       jmp       short M00_L08
M00_L06:
       mov       rcx,rbx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       jmp       qword ptr [7FF80D134CD8]
M00_L07:
       mov       rdi,rsi
M00_L08:
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M00_L09:
       mov       ecx,eax
       mov       rdx,[rbp-28]
       call      qword ptr [7FF80D1FDFC8]
       jmp       short M00_L05
M00_L10:
       mov       ecx,46
       call      qword ptr [7FF80D1FDFE0]
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M00_L12
       cmp       qword ptr [rbp-28],0
       jne       short M00_L11
       xor       ecx,ecx
       call      qword ptr [7FF80D1FDFB0]
       int       3
M00_L11:
       mov       rcx,[rbp-28]
       call      00007FF86CA5E040
       test      eax,eax
       je        short M00_L12
       mov       ecx,eax
       mov       rdx,[rbp-28]
       call      qword ptr [7FF80D1FDFC8]
M00_L12:
       nop
       add       rsp,28
       ret
; Total bytes of code 310
```
```assembly
; System.Threading.Monitor.Enter_Slowpath(System.Object)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       mov       [rbp+10],rcx
       lea       rcx,[rbp+10]
       mov       [rbp-98],rcx
       lea       rcx,[rbp-90]
       call      qword ptr [7FF850609030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FF850609038]; CORINFO_HELP_JIT_PINVOKE_END
       nop
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 105
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
; AsyncLazyBenchmarks.HotPathBenchmarks`1[[System.Int32, System.Private.CoreLib]].VsThreading_Token()
       sub       rsp,28
       mov       rdx,[rcx+28]
       mov       rax,[rcx+8]
       cmp       byte ptr [rax+24],0
       jne       short M00_L00
       mov       rcx,rdx
       mov       rdx,rax
       cmp       [rcx],ecx
       add       rsp,28
       jmp       qword ptr [7FF80D145EC0]; Microsoft.VisualStudio.Threading.AsyncLazy`1[[System.Int32, System.Private.CoreLib]].GetValueAsync(System.Threading.CancellationToken)
M00_L00:
       mov       ecx,46
       call      qword ptr [7FF80D20DF20]
       int       3
; Total bytes of code 48
```
```assembly
; Microsoft.VisualStudio.Threading.AsyncLazy`1[[System.Int32, System.Private.CoreLib]].GetValueAsync(System.Threading.CancellationToken)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-20],rax
       mov       [rbp-28],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       rcx,offset MT_Microsoft.VisualStudio.Threading.AsyncLazy<System.Int32>+<>c__DisplayClass20_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp+10]
       mov       rcx,[rdx+28]
       test      rcx,rcx
       je        short M01_L05
       test      dword ptr [rcx+34],1600000
       je        short M01_L05
M01_L00:
       mov       rdx,[rbp+10]
       cmp       qword ptr [rdx+28],0
       je        near ptr M01_L06
M01_L01:
       mov       rdx,[rbp+10]
       lock or   dword ptr [rsp],0
       mov       rcx,[rdx+30]
       test      rcx,rcx
       jne       near ptr M01_L17
       xor       eax,eax
M01_L02:
       test      rax,rax
       jne       short M01_L04
       mov       rdx,[rbp+10]
       mov       rbx,[rdx+28]
       mov       rcx,[rbp+18]
       mov       [rbp-28],rcx
       test      rbx,rbx
       je        near ptr M01_L18
       cmp       qword ptr [rbp-28],0
       je        short M01_L03
       test      dword ptr [rbx+34],1600000
       je        near ptr M01_L19
M01_L03:
       mov       rax,rbx
M01_L04:
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L05:
       mov       rcx,[rdx+18]
       test      rcx,rcx
       je        short M01_L00
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF80D1468B0]; System.Threading.AsyncLocal`1[[System.__Canon, System.Private.CoreLib]].get_Value()
       test      rax,rax
       je        short M01_L00
       call      qword ptr [7FF80D20DFF8]
       mov       rcx,rax
       mov       r8,27789001450
       mov       r8,[r8]
       mov       rdx,287AD5AB590
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rcx,rax
       xor       eax,eax
       test      rcx,rcx
       cmove     rcx,rax
       call      qword ptr [7FF80D146208]
       int       3
M01_L06:
       mov       rcx,[rdx+8]
       call      qword ptr [7FF80D146220]; System.Threading.Monitor.IsEntered(System.Object)
       test      eax,eax
       je        short M01_L07
       call      qword ptr [7FF80D20DFF8]
       mov       rcx,rax
       mov       r8,27789001450
       mov       r8,[r8]
       mov       rdx,287AD5AB590
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rcx,rax
       xor       eax,eax
       test      rcx,rcx
       cmove     rcx,rax
       call      qword ptr [7FF80D146208]
       int       3
M01_L07:
       xor       edx,edx
       mov       [rbx+10],rdx
       mov       rdx,[rbp+10]
       mov       rcx,[rdx+8]
       mov       [rbp-30],rcx
       xor       ecx,ecx
       mov       [rbp-20],ecx
       lea       rdx,[rbp-20]
       mov       rcx,[rbp-30]
       call      qword ptr [7FF80CDD5998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rdx,[rbp+10]
       cmp       qword ptr [rdx+28],0
       jne       near ptr M01_L15
       lea       rcx,[rbp+18]
       call      qword ptr [7FF80D144D08]; System.Threading.CancellationToken.get_IsCancellationRequested()
       test      eax,eax
       je        short M01_L08
       lea       rcx,[rbp+18]
       call      qword ptr [7FF80D20E010]
       int       3
M01_L08:
       mov       rcx,offset MT_Microsoft.VisualStudio.Threading.InlineResumable
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rbx+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+20]
       lea       rcx,[rbx+18]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       rdx,[rbp+10]
       mov       [rdx+20],rcx
       mov       rcx,offset MT_System.Func<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r8,offset Microsoft.VisualStudio.Threading.AsyncLazy`1+<>c__DisplayClass20_0[[System.Int32, System.Private.CoreLib]].<GetValueAsync>b__0()
       call      qword ptr [7FF80CDD6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp+10]
       cmp       byte ptr [rdx+38],0
       jne       short M01_L10
       cmp       qword ptr [rdx+18],0
       je        short M01_L09
       mov       rcx,7FF80D2708D0
       call      qword ptr [7FF80D1465B0]
M01_L09:
       mov       rcx,offset MT_Microsoft.VisualStudio.Threading.AsyncLocal<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      qword ptr [7FF80D146280]; Microsoft.VisualStudio.Threading.AsyncLocal`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rdi+8]
       mov       rdx,277890008C0
       mov       rdx,[rdx]
       cmp       [rcx],ecx
       call      qword ptr [7FF80D1468E0]; System.Threading.AsyncLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
       mov       rdx,[rbp+10]
       lea       rcx,[rdx+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp+10]
M01_L10:
       cmp       qword ptr [rdx+10],0
       je        short M01_L11
       mov       rcx,[rdx+10]
       cmp       [rcx],cl
       xor       r8d,r8d
       mov       [rsp+20],r8d
       mov       rdx,rsi
       xor       r9d,r9d
       call      qword ptr [7FF80D20DF98]
       mov       rdx,[rbp+10]
       lea       rcx,[rdx+30]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lock or   dword ptr [rsp],0
       mov       rdx,[rbp+10]
       mov       rcx,[rdx+30]
       cmp       [rcx],cl
       call      qword ptr [7FF80D20E028]
       mov       rdx,rax
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      qword ptr [7FF80CDD6328]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rdx,[rbp+10]
       lea       rcx,[rdx+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L13
M01_L11:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       rdx,[rbp+10]
       lea       rcx,[rdx+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L13
M01_L12:
       mov       rcx,[rdx+18]
       mov       rcx,[rcx+8]
       xor       edx,edx
       cmp       [rcx],ecx
       call      qword ptr [7FF80D1468E0]; System.Threading.AsyncLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
       jmp       short M01_L15
M01_L13:
       mov       rdx,[rbp+10]
       cmp       qword ptr [rdx+18],0
       je        short M01_L15
       jmp       short M01_L12
M01_L14:
       mov       rcx,[rbp-30]
       call      qword ptr [7FF80CDD6820]; System.Threading.Monitor.Exit(System.Object)
       jmp       short M01_L16
M01_L15:
       cmp       byte ptr [rbp-20],0
       jne       short M01_L14
M01_L16:
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        near ptr M01_L01
       call      qword ptr [7FF80D1462E0]; Microsoft.VisualStudio.Threading.InlineResumable.Resume()
       jmp       near ptr M01_L01
M01_L17:
       mov       r8,[rbp+18]
       xor       edx,edx
       call      qword ptr [7FF80D1462F8]
       jmp       near ptr M01_L02
M01_L18:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,170F
       mov       rdx,7FF80D1567E8
       call      qword ptr [7FF80CDDF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80D0B75B8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L19:
       lea       rcx,[rbp-28]
       call      qword ptr [7FF80D144D08]; System.Threading.CancellationToken.get_IsCancellationRequested()
       test      eax,eax
       je        short M01_L20
       mov       rcx,[rbp-28]
       call      qword ptr [7FF80D144CD8]
       jmp       near ptr M01_L04
M01_L20:
       mov       rcx,rbx
       mov       rdx,[rbp-28]
       call      qword ptr [7FF80D14CB28]
       jmp       near ptr M01_L04
       sub       rsp,28
       mov       rdx,[rbp+10]
       mov       rcx,[rdx+18]
       test      rcx,rcx
       je        short M01_L21
       mov       rcx,[rcx+8]
       xor       edx,edx
       cmp       [rcx],ecx
       call      qword ptr [7FF80D1468E0]; System.Threading.AsyncLocal`1[[System.__Canon, System.Private.CoreLib]].set_Value(System.__Canon)
M01_L21:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       byte ptr [rbp-20],0
       je        short M01_L22
       mov       rcx,[rbp-30]
       call      qword ptr [7FF80CDD6820]; System.Threading.Monitor.Exit(System.Object)
M01_L22:
       nop
       add       rsp,28
       ret
; Total bytes of code 1017
```

