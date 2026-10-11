## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.Int32, System.Private.CoreLib]].LazyOfTask()
       push      rbp
       push      r15
       push      rbx
       lea       rbp,[rsp+10]
       mov       rbx,rdi
       mov       rdi,offset MT_System.Lazy<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M00_L00
       lea       rdi,[r15+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset MT_System.LazyHelper
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+10],8
       lea       rdi,[r15+8]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [r15+8],0
       je        short M00_L01
       mov       rdi,r15
       pop       rbx
       pop       r15
       pop       rbp
       jmp       qword ptr [738373E8C438]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
M00_L00:
       mov       edi,1817
       mov       rsi,738372644000
       call      qword ptr [73837363EF88]
       mov       rdi,rax
       call      qword ptr [73837418C9C0]
       int       3
M00_L01:
       mov       rax,[r15+18]
       pop       rbx
       pop       r15
       pop       rbp
       ret
; Total bytes of code 142
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.Int32, System.Private.CoreLib]](System.Threading.Tasks.Task`1<Int32>)
       push      rbx
       mov       rbx,rdi
       mov       edi,[rbx+34]
       and       edi,11000000
       cmp       edi,1000000
       jne       short M01_L01
M01_L00:
       mov       eax,[rbx+38]
       pop       rbx
       ret
M01_L01:
       mov       rdi,rbx
       xor       esi,esi
       call      qword ptr [73837418CA08]
       jmp       short M01_L00
; Total bytes of code 39
```
```assembly
; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
M02_L00:
       push      rbp
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp-10],rdi
       mov       [rbp-20],rdi
M02_L01:
       mov       rbx,[rdi+8]
       test      rbx,rbx
       je        short M02_L04
       mov       eax,[rbx+10]
       cmp       eax,8
       jne       short M02_L05
       mov       [rbp-28],rbx
       xor       eax,eax
       mov       [rbp-14],eax
       mov       rdi,rbx
       call      00007383F18E6020
       test      eax,eax
       jne       short M02_L02
       mov       rdi,rbx
       call      qword ptr [73837418CAF8]
M02_L02:
       mov       dword ptr [rbp-14],1
       mov       rdi,[rbp-20]
       cmp       [rdi+8],rbx
       jne       short M02_L03
       mov       esi,2
       call      qword ptr [738373E8C468]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       nop
M02_L03:
       mov       rdi,rbx
       call      00007383F18E6790
       test      eax,eax
       jne       near ptr M02_L11
M02_L04:
       mov       rdi,[rbp-20]
       cmp       qword ptr [rdi+8],0
       je        near ptr M02_L12
       add       rsp,28
       pop       rbx
       pop       rbp
       jmp       qword ptr [738373E8C438]
M02_L05:
       cmp       eax,8
       ja        short M02_L06
       mov       eax,eax
       lea       rcx,[7383736AB078]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M02_L01]
       add       rcx,rdx
       jmp       rcx
M02_L06:
       mov       rdi,[rbx+8]
       cmp       [rdi],edi
       call      qword ptr [73837418CB10]
       int       3
       mov       rdi,[rbp-20]
       call      qword ptr [73837418CA98]
       jmp       short M02_L04
       mov       rdi,[rbp-20]
       xor       esi,esi
       call      qword ptr [738373E8C468]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M02_L04
       mov       rdi,[rbp-20]
       mov       rsi,[rdi]
       mov       rax,[rsi+30]
       mov       rax,[rax]
       mov       rax,[rax+10]
       test      rax,rax
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rdi,rsi
       mov       rsi,7383741AA7B8
       call      qword ptr [73837363F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L08:
       mov       rdi,[rax+30]
       mov       rdi,[rdi]
       mov       rdi,[rdi+18]
       test      rdi,rdi
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rdi,rax
       mov       rsi,7383741AA858
       call      qword ptr [73837363F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M02_L10:
       call      qword ptr [73837418CA38]
       mov       rdx,rax
       mov       rsi,rbx
       mov       rdi,[rbp-20]
       call      qword ptr [73837418CAB0]
       jmp       near ptr M02_L04
       mov       rdi,[rbp-20]
       mov       rsi,rbx
       call      qword ptr [73837418CAC8]
       jmp       near ptr M02_L04
       mov       rdi,[rbp-20]
       call      qword ptr [73837418CAE0]
       jmp       near ptr M02_L04
       mov       rdi,[rbp-20]
       mov       rsi,rbx
       mov       edx,1
       call      qword ptr [738373E8C450]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M02_L04
M02_L11:
       mov       edi,eax
       mov       rsi,rbx
       call      qword ptr [73837418C9D8]
       jmp       near ptr M02_L04
M02_L12:
       mov       rax,[rdi+18]
       add       rsp,28
       pop       rbx
       pop       rbp
       ret
       push      rax
       cmp       dword ptr [rbp-14],0
       je        short M02_L13
       mov       rdi,[rbp-28]
       call      00007383F18E6790
       test      eax,eax
       je        short M02_L13
       mov       edi,eax
       mov       rsi,[rbp-28]
       call      qword ptr [73837418C9D8]
M02_L13:
       nop
       add       rsp,8
       ret
; Total bytes of code 438
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.Int32, System.Private.CoreLib]].LazyOfTask_TaskRun()
       push      rbp
       push      r15
       push      rbx
       lea       rbp,[rsp+10]
       mov       rbx,rdi
       mov       rdi,offset MT_System.Lazy<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rsi,[rbx+10]
       test      rsi,rsi
       je        short M00_L00
       lea       rdi,[r15+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset MT_System.LazyHelper
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+10],8
       lea       rdi,[r15+8]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [r15+8],0
       je        short M00_L01
       mov       rdi,r15
       pop       rbx
       pop       r15
       pop       rbp
       jmp       qword ptr [77AFDD89C438]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
M00_L00:
       mov       edi,1817
       mov       rsi,77AFDC054000
       call      qword ptr [77AFDD04EF88]
       mov       rdi,rax
       call      qword ptr [77AFDDB9E850]
       int       3
M00_L01:
       mov       rax,[r15+18]
       pop       rbx
       pop       r15
       pop       rbp
       ret
; Total bytes of code 142
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.Int32, System.Private.CoreLib]](System.Threading.Tasks.Task`1<Int32>)
       push      rbx
       mov       rbx,rdi
       mov       edi,[rbx+34]
       and       edi,11000000
       cmp       edi,1000000
       jne       short M01_L01
M01_L00:
       mov       eax,[rbx+38]
       pop       rbx
       ret
M01_L01:
       mov       rdi,rbx
       xor       esi,esi
       call      qword ptr [77AFDDB974F8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 39
```
```assembly
; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
M02_L00:
       push      rbp
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp-10],rdi
       mov       [rbp-20],rdi
M02_L01:
       mov       rbx,[rdi+8]
       test      rbx,rbx
       je        short M02_L04
       mov       eax,[rbx+10]
       cmp       eax,8
       jne       short M02_L05
       mov       [rbp-28],rbx
       xor       eax,eax
       mov       [rbp-14],eax
       mov       rdi,rbx
       call      000077B05B2E6020
       test      eax,eax
       jne       short M02_L02
       mov       rdi,rbx
       call      qword ptr [77AFDDB9C720]; System.Threading.Monitor.Enter_Slowpath(System.Object)
M02_L02:
       mov       dword ptr [rbp-14],1
       mov       rdi,[rbp-20]
       cmp       [rdi+8],rbx
       jne       short M02_L03
       mov       esi,2
       call      qword ptr [77AFDD89C468]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       nop
M02_L03:
       mov       rdi,rbx
       call      000077B05B2E6790
       test      eax,eax
       jne       near ptr M02_L11
M02_L04:
       mov       rdi,[rbp-20]
       cmp       qword ptr [rdi+8],0
       je        near ptr M02_L12
       add       rsp,28
       pop       rbx
       pop       rbp
       jmp       qword ptr [77AFDD89C438]
M02_L05:
       cmp       eax,8
       ja        short M02_L06
       mov       eax,eax
       lea       rcx,[77AFDD0C8338]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M02_L01]
       add       rcx,rdx
       jmp       rcx
M02_L06:
       mov       rdi,[rbx+8]
       cmp       [rdi],edi
       call      qword ptr [77AFDDB9EEE0]
       int       3
       mov       rdi,[rbp-20]
       call      qword ptr [77AFDDB9F138]
       jmp       short M02_L04
       mov       rdi,[rbp-20]
       xor       esi,esi
       call      qword ptr [77AFDD89C468]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M02_L04
       mov       rdi,[rbp-20]
       mov       rsi,[rdi]
       mov       rax,[rsi+30]
       mov       rax,[rax]
       mov       rax,[rax+10]
       test      rax,rax
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rdi,rsi
       mov       rsi,77AFDDC249E0
       call      qword ptr [77AFDD04F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L08:
       mov       rdi,[rax+30]
       mov       rdi,[rdi]
       mov       rdi,[rdi+18]
       test      rdi,rdi
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rdi,rax
       mov       rsi,77AFDDC24A80
       call      qword ptr [77AFDD04F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M02_L10:
       call      qword ptr [77AFDDB9F0D8]
       mov       rdx,rax
       mov       rsi,rbx
       mov       rdi,[rbp-20]
       call      qword ptr [77AFDDB9F150]
       jmp       near ptr M02_L04
       mov       rdi,[rbp-20]
       mov       rsi,rbx
       call      qword ptr [77AFDDB9F168]
       jmp       near ptr M02_L04
       mov       rdi,[rbp-20]
       call      qword ptr [77AFDDB9F180]
       jmp       near ptr M02_L04
       mov       rdi,[rbp-20]
       mov       rsi,rbx
       mov       edx,1
       call      qword ptr [77AFDD89C450]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M02_L04
M02_L11:
       mov       edi,eax
       mov       rsi,rbx
       call      qword ptr [77AFDDB9E868]
       jmp       near ptr M02_L04
M02_L12:
       mov       rax,[rdi+18]
       add       rsp,28
       pop       rbx
       pop       rbp
       ret
       push      rax
       cmp       dword ptr [rbp-14],0
       je        short M02_L13
       mov       rdi,[rbp-28]
       call      000077B05B2E6790
       test      eax,eax
       je        short M02_L13
       mov       edi,eax
       mov       rsi,[rbp-28]
       call      qword ptr [77AFDDB9E868]
M02_L13:
       nop
       add       rsp,8
       ret
; Total bytes of code 438
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rbp
       push      r15
       push      rbx
       lea       rbp,[rsp+10]
       mov       rbx,rdi
       mov       r15d,esi
       test      dword ptr [rbx+34],1600000
       jne       short M03_L00
       mov       rdi,rbx
       mov       esi,0FFFFFFFF
       xor       edx,edx
       call      qword ptr [77AFDDB97510]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M03_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M03_L03
M03_L01:
       mov       edi,[rbx+34]
       and       edi,1600000
       cmp       edi,1000000
       jne       short M03_L04
M03_L02:
       pop       rbx
       pop       r15
       pop       rbp
       ret
M03_L03:
       mov       rdi,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M03_L01
       mov       rdi,rbx
       call      qword ptr [77AFDDB9F3A8]
       jmp       short M03_L01
M03_L04:
       test      r15b,2
       jne       short M03_L05
       mov       rdi,rbx
       call      qword ptr [77AFDDB9F1F8]
M03_L05:
       mov       rdi,rbx
       call      qword ptr [77AFDDB9F648]
       jmp       short M03_L02
; Total bytes of code 125
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.Int32, System.Private.CoreLib]].AsyncLazy()
       push      rbp
       push      r15
       push      rbx
       lea       rbp,[rsp+10]
       mov       rbx,rdi
       mov       rdi,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M00_L00
       lea       rdi,[r15+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[r15+10]
       test      rax,rax
       jne       short M00_L01
       mov       rdi,r15
       xor       esi,esi
       pop       rbx
       pop       r15
       pop       rbp
       jmp       qword ptr [7277517965B0]; System.Threading.Tasks.AsyncLazy`1[[System.Int32, System.Private.CoreLib]].GetOrStartAttemptAsync(System.Threading.CancellationToken)
M00_L00:
       mov       edi,1
       mov       rsi,7277517CAEC8
       call      qword ptr [727750C4EF88]
       mov       rdi,rax
       call      qword ptr [72775179EC10]
       int       3
M00_L01:
       pop       rbx
       pop       r15
       pop       rbp
       ret
; Total bytes of code 108
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.Int32, System.Private.CoreLib]](System.Threading.Tasks.Task`1<Int32>)
       push      rbx
       mov       rbx,rdi
       mov       edi,[rbx+34]
       and       edi,11000000
       cmp       edi,1000000
       jne       short M01_L01
M01_L00:
       mov       eax,[rbx+38]
       pop       rbx
       ret
M01_L01:
       mov       rdi,rbx
       xor       esi,esi
       call      qword ptr [7277517972D0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 39
```
```assembly
; System.Threading.Tasks.AsyncLazy`1[[System.Int32, System.Private.CoreLib]].GetOrStartAttemptAsync(System.Threading.CancellationToken)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rbx
       push      rax
       lea       rbp,[rsp+30]
       mov       rbx,rdi
       mov       r15,rsi
M02_L00:
       mov       r14,[rbx+8]
       mov       rsi,r14
       mov       rdi,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M02_L18
       test      r14,r14
       je        short M02_L01
       mov       rdi,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt
       cmp       [r14],rdi
       je        near ptr M02_L11
M02_L01:
       lea       rdi,[rbx+20]
       cmp       qword ptr [rdi],0
       jne       near ptr M02_L17
M02_L02:
       mov       rdi,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdi,offset MT_System.Threading.Tasks.TaskCompletionSource<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdi,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       xor       edi,edi
       mov       [rax+8],rdi
       mov       [rax+10],rdi
       mov       [rax+18],rdi
       mov       dword ptr [rax+34],2000440
       lea       rdi,[r14+8]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdi,[r13+10]
       mov       rsi,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdi,[r13+8]
       mov       rsi,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdi,[rbx+8]
       test      rdi,rdi
       je        near ptr M02_L20
       mov       rsi,r13
       xor       edx,edx
       call      00007277CF074060
       test      rax,rax
       jne       near ptr M02_L00
       mov       rdi,72678C801378
       mov       rbx,[rdi]
       test      rbx,rbx
       je        near ptr M02_L21
M02_L03:
       mov       rdi,7277CF2A0D68
       mov       rax,7277CFB0A820
       call      rax
       cmp       dword ptr [rax],4
       jle       near ptr M02_L22
       mov       rdi,[rax+8]
       mov       rax,[rdi+20]
       test      rax,rax
       je        near ptr M02_L22
M02_L04:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M02_L05
       call      qword ptr [72775149C048]; System.Threading.Thread.InitializeCurrentThread()
M02_L05:
       mov       r14,[rax+8]
       test      r14,r14
       jne       near ptr M02_L23
       mov       rdi,72678C801380
       mov       r14,[rdi]
M02_L06:
       test      r14,r14
       je        short M02_L07
       cmp       byte ptr [r14+19],0
       je        near ptr M02_L24
M02_L07:
       mov       rdi,offset MT_System.Threading.QueueUserWorkItemCallbackDefaultContext<System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rdi,[r12+8]
       mov       rsi,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdi,[r12+10]
       mov       rsi,r13
       call      CORINFO_HELP_ASSIGN_REF
M02_L08:
       mov       rdi,72678C801390
       mov       rbx,[rdi]
       cmp       byte ptr [rbx+38],0
       jne       near ptr M02_L25
M02_L09:
       mov       rdi,[rbx+8]
       mov       rsi,[rdi+10]
       mov       rcx,[rsi+8]
M02_L10:
       mov       r14d,[rsi+0A0]
       mov       eax,r14d
       and       eax,[rsi+18]
       cmp       eax,[rcx+8]
       jae       near ptr M02_L28
       shl       rax,4
       lea       rdx,[rcx+rax+10]
       mov       eax,[rdx+8]
       sub       eax,r14d
       jne       near ptr M02_L13
       lea       r8,[rsi+0A0]
       lea       r9d,[r14+1]
       mov       eax,r14d
       lock cmpxchg [r8],r9d
       cmp       eax,r14d
       jne       short M02_L10
       mov       rax,rdx
       mov       [rbp-30],rax
       mov       rdi,rax
       mov       rsi,r12
       call      CORINFO_HELP_ASSIGN_REF
       inc       r14d
       mov       r12,[rbp-30]
       mov       [r12+8],r14d
       jmp       short M02_L14
M02_L11:
       mov       rdi,r14
       call      qword ptr [727751796670]
       test      eax,eax
       je        short M02_L12
       mov       rdi,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdi,r14
       mov       rsi,726767C09F28
       call      qword ptr [727751495260]
       mov       rdi,r14
       add       rsp,8
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [727751796628]
M02_L12:
       mov       rdi,r14
       mov       rsi,r15
       add       rsp,8
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [727751796688]; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.Int32, System.Private.CoreLib]].WaitAsync(System.Threading.CancellationToken)
M02_L13:
       test      eax,eax
       jge       near ptr M02_L10
       mov       rsi,r12
       call      qword ptr [72775179ED18]
M02_L14:
       add       rbx,78
       mov       edi,1
       xchg      edi,[rbx]
       test      edi,edi
       jne       short M02_L15
       mov       rdi,72678C8013B8
       mov       rbx,[rdi]
       lea       rdi,[rbx+160]
       lock inc  dword ptr [rdi]
       mov       rdi,rbx
       call      qword ptr [727751796B20]; System.Threading.PortableThreadPool+WorkerThread.MaybeAddWorkingWorker(System.Threading.PortableThreadPool)
       cmp       dword ptr [rbx+164],6
       jne       near ptr M02_L26
M02_L15:
       test      r15,r15
       jne       near ptr M02_L27
       mov       rdi,[r13+10]
       mov       rax,[rdi+8]
M02_L16:
       add       rsp,8
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L17:
       mov       rdi,[rdi]
       cmp       dword ptr [rdi+20],0
       je        near ptr M02_L02
       jmp       short M02_L19
M02_L18:
       jmp       short M02_L16
M02_L19:
       mov       rdi,[rbx+20]
       add       rsp,8
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [727751796568]
M02_L20:
       call      qword ptr [72775179EB68]
       int       3
M02_L21:
       mov       rdi,offset MT_System.Action<System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdi,72678C801370
       mov       rsi,[rdi]
       lea       rdi,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset System.Threading.Tasks.AsyncLazy`1+<>c[[System.Int32, System.Private.CoreLib]].<GetOrStartAttemptAsync>b__11_0(Attempt<Int32>)
       mov       [rbx+18],rdi
       mov       rdi,72678C801378
       mov       rsi,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L03
M02_L22:
       mov       edi,4
       call      qword ptr [72775179E850]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M02_L04
M02_L23:
       xor       edi,edi
       cmp       byte ptr [r14+18],0
       cmovne    r14,rdi
       jmp       near ptr M02_L06
M02_L24:
       mov       rdi,offset MT_System.Threading.QueueUserWorkItemCallback<System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rdi,r12
       mov       rsi,rbx
       mov       rdx,r13
       mov       rcx,r14
       call      qword ptr [72775179ECD0]
       jmp       near ptr M02_L08
M02_L25:
       mov       rdi,72678C8013A8
       mov       rdi,[rdi]
       cmp       byte ptr [rdi+9D],0
       je        near ptr M02_L09
       mov       rdi,72678C8013A8
       mov       rdi,[rdi]
       mov       rsi,r12
       call      qword ptr [72775179ECE8]
       jmp       near ptr M02_L09
M02_L26:
       mov       rdi,rbx
       call      qword ptr [727751796DA8]; System.Threading.PortableThreadPool+GateThread.EnsureRunningSlow(System.Threading.PortableThreadPool)
       jmp       near ptr M02_L15
M02_L27:
       mov       rdi,[r13+10]
       mov       rbx,[rdi+8]
       cmp       [rbx],bl
       mov       rdi,offset MT_System.TimeProvider
       call      qword ptr [727750C45728]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,72678C801490
       mov       rdx,[rdx]
       mov       rcx,r15
       mov       rdi,rbx
       mov       esi,0FFFFFFFF
       add       rsp,8
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [72775179F1B0]
M02_L28:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1085
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rbp
       push      r15
       push      rbx
       lea       rbp,[rsp+10]
       mov       rbx,rdi
       mov       r15d,esi
       test      dword ptr [rbx+34],1600000
       jne       short M03_L00
       mov       rdi,rbx
       mov       esi,0FFFFFFFF
       xor       edx,edx
       call      qword ptr [7277517972E8]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M03_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M03_L03
M03_L01:
       mov       edi,[rbx+34]
       and       edi,1600000
       cmp       edi,1000000
       jne       short M03_L04
M03_L02:
       pop       rbx
       pop       r15
       pop       rbp
       ret
M03_L03:
       mov       rdi,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M03_L01
       mov       rdi,rbx
       call      qword ptr [72775179EBB0]
       jmp       short M03_L01
M03_L04:
       test      r15b,2
       jne       short M03_L05
       mov       rdi,rbx
       call      qword ptr [72775179ED48]
M03_L05:
       mov       rdi,rbx
       call      qword ptr [72775179F1C8]
       jmp       short M03_L02
; Total bytes of code 125
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.Int32, System.Private.CoreLib]].AsyncLazy_NoHop()
       push      rbp
       push      r15
       push      r14
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+70]
       vxorps    xmm8,xmm8,xmm8
       vmovdqu   ymmword ptr [rbp-50],ymm8
       vmovdqa   xmmword ptr [rbp-30],xmm8
       xor       eax,eax
       mov       [rbp-20],rax
       mov       rbx,rdi
       mov       rdi,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        near ptr M00_L13
       lea       rdi,[r15+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[r15+10]
       test      rax,rax
       jne       near ptr M00_L14
M00_L00:
       mov       rbx,[r15+8]
       mov       rsi,rbx
       mov       rdi,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L16
       test      rbx,rbx
       je        short M00_L01
       mov       rdi,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt
       cmp       [rbx],rdi
       je        near ptr M00_L05
M00_L01:
       lea       rdi,[r15+20]
       cmp       qword ptr [rdi],0
       jne       near ptr M00_L15
M00_L02:
       mov       rdi,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdi,offset MT_System.Threading.Tasks.TaskCompletionSource<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdi,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       xor       edi,edi
       mov       [rax+8],rdi
       mov       [rax+10],rdi
       mov       [rax+18],rdi
       mov       dword ptr [rax+34],2000440
       lea       rdi,[rbx+8]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdi,[r14+10]
       mov       rsi,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdi,[r14+8]
       mov       rsi,r15
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdi,[r15+8]
       test      rdi,rdi
       je        near ptr M00_L18
       mov       rsi,r14
       xor       edx,edx
       call      00007EA796874060
       test      rax,rax
       jne       near ptr M00_L00
       xor       edi,edi
       mov       [rbp-30],rdi
       mov       [rbp-50],r14
       mov       dword ptr [rbp-38],0FFFFFFFF
       mov       rdi,7EA796AA0D68
       mov       rax,7EA797426820
       call      rax
       cmp       dword ptr [rax],4
       jle       near ptr M00_L19
       mov       rdi,[rax+8]
       mov       rax,[rdi+20]
       test      rax,rax
       je        near ptr M00_L19
M00_L03:
       mov       r15,[rax+10]
       test      r15,r15
       jne       short M00_L04
       call      qword ptr [7EA718C9C048]; System.Threading.Thread.InitializeCurrentThread()
       mov       r15,rax
M00_L04:
       mov       [rbp-58],r15
       mov       rsi,[r15+8]
       mov       [rbp-60],rsi
       mov       rsi,[r15+10]
       mov       [rbp-68],rsi
       jmp       short M00_L07
M00_L05:
       mov       rdi,rbx
       call      qword ptr [7EA718F96610]
       test      eax,eax
       je        short M00_L06
       mov       rdi,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdi,rbx
       mov       rsi,7EA714809F28
       call      qword ptr [7EA718C95260]
       mov       rdi,rbx
       call      qword ptr [7EA718F965E0]
       jmp       short M00_L12
M00_L06:
       mov       rdi,rbx
       xor       esi,esi
       call      qword ptr [7EA718F96628]; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.Int32, System.Private.CoreLib]].WaitAsync(System.Threading.CancellationToken)
       jmp       short M00_L12
M00_L07:
       lea       rdi,[rbp-50]
       call      qword ptr [7EA718F96808]; System.Threading.Tasks.AsyncLazy`1+Attempt+<RunAsync>d__4[[System.Int32, System.Private.CoreLib]].MoveNext()
       nop
       mov       rsi,[rbp-68]
       cmp       rsi,[r15+10]
       je        short M00_L08
       lea       rdi,[r15+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L08:
       mov       rdi,[r15+8]
       mov       rbx,rdi
       mov       rsi,[rbp-60]
       cmp       rsi,rbx
       je        short M00_L10
       lea       rdi,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M00_L09
       cmp       qword ptr [rbx+10],0
       jne       near ptr M00_L21
M00_L09:
       cmp       qword ptr [rbp-60],0
       jne       short M00_L20
M00_L10:
       cmp       qword ptr [rbp-30],0
       je        near ptr M00_L22
M00_L11:
       mov       rax,[r14+10]
       mov       rax,[rax+8]
M00_L12:
       add       rsp,58
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L13:
       mov       edi,1
       mov       rsi,7EA718FCAED0
       call      qword ptr [7EA71844EF88]
       mov       rdi,rax
       call      qword ptr [7EA718F9D6E0]
       int       3
M00_L14:
       jmp       short M00_L12
M00_L15:
       mov       rdi,[rdi]
       cmp       dword ptr [rdi+20],0
       je        near ptr M00_L02
       jmp       short M00_L17
M00_L16:
       jmp       short M00_L12
M00_L17:
       mov       rdi,[r15+20]
       call      qword ptr [7EA718F96568]
       jmp       short M00_L12
M00_L18:
       call      qword ptr [7EA718F9D620]
       int       3
M00_L19:
       mov       edi,4
       call      qword ptr [7EA718F9D3F8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L03
M00_L20:
       mov       rsi,[rbp-60]
       cmp       qword ptr [rsi+10],0
       je        short M00_L10
M00_L21:
       mov       rdi,rbx
       mov       rsi,[rbp-60]
       call      qword ptr [7EA718F9D698]
       jmp       near ptr M00_L10
M00_L22:
       lea       rdi,[rbp-30]
       call      qword ptr [7EA718F9D6B0]
       jmp       near ptr M00_L11
       push      rax
       mov       rsi,[rbp-68]
       mov       rax,[rbp-58]
       cmp       rsi,[rax+10]
       je        short M00_L23
       lea       rdi,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-58]
M00_L23:
       mov       r14,[rax+8]
       mov       rsi,[rbp-60]
       cmp       rsi,r14
       je        short M00_L26
       lea       rdi,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      r14,r14
       je        short M00_L24
       cmp       qword ptr [r14+10],0
       jne       short M00_L25
M00_L24:
       cmp       qword ptr [rbp-60],0
       je        short M00_L26
       mov       rsi,[rbp-60]
       cmp       qword ptr [rsi+10],0
       je        short M00_L26
M00_L25:
       mov       rdi,r14
       mov       rsi,[rbp-60]
       call      qword ptr [7EA718F9D698]
M00_L26:
       nop
       add       rsp,8
       ret
; Total bytes of code 816
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.Int32, System.Private.CoreLib]](System.Threading.Tasks.Task`1<Int32>)
       push      rbx
       mov       rbx,rdi
       mov       edi,[rbx+34]
       and       edi,11000000
       cmp       edi,1000000
       jne       short M01_L01
M01_L00:
       mov       eax,[rbx+38]
       pop       rbx
       ret
M01_L01:
       mov       rdi,rbx
       xor       esi,esi
       call      qword ptr [7EA718F9D518]
       jmp       short M01_L00
; Total bytes of code 39
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       push      rbp
       mov       rbp,rsp
       test      rsi,rsi
       jne       short M02_L01
M02_L00:
       mov       rax,rsi
       pop       rbp
       ret
M02_L01:
       cmp       [rsi],rdi
       je        short M02_L00
       mov       rax,[rsi]
       mov       rax,[rax+10]
       cmp       rax,rdi
       je        short M02_L00
M02_L02:
       test      rax,rax
       je        short M02_L03
       mov       rax,[rax+10]
       cmp       rax,rdi
       je        short M02_L00
       test      rax,rax
       je        short M02_L03
       mov       rax,[rax+10]
       cmp       rax,rdi
       je        short M02_L00
       test      rax,rax
       je        short M02_L03
       mov       rax,[rax+10]
       cmp       rax,rdi
       je        short M02_L00
       test      rax,rax
       je        short M02_L03
       mov       rax,[rax+10]
       cmp       rax,rdi
       je        short M02_L00
       jmp       short M02_L02
M02_L03:
       xor       esi,esi
       jmp       short M02_L00
; Total bytes of code 93
```
```assembly
; System.Threading.Thread.InitializeCurrentThread()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rbx
       sub       rsp,68
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-30],rax
       lea       rdi,[rbp-30]
       mov       [rbp-90],rdi
       lea       rdi,[rbp-88]
       call      qword ptr [7EA717FEEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdi,[rbp-90]
       call      qword ptr [rax]
       lea       rdi,[rbp-88]
       call      qword ptr [7EA717FEEF08]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-30]
       call      qword ptr [7EA717FF0B98]
       lea       rdi,[rax+10]
       mov       rsi,[rbp-30]
       call      qword ptr [7EA717FEEEB8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       add       rsp,68
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 123
```
```assembly
; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.Int32, System.Private.CoreLib]].WaitAsync(System.Threading.CancellationToken)
       push      r15
       push      rbx
       push      rax
       mov       rbx,rsi
       test      rbx,rbx
       jne       short M04_L00
       mov       rax,[rdi+10]
       mov       rax,[rax+8]
       add       rsp,8
       pop       rbx
       pop       r15
       ret
M04_L00:
       mov       rdi,[rdi+10]
       mov       r15,[rdi+8]
       cmp       [r15],r15b
       mov       rdi,offset MT_System.TimeProvider
       call      qword ptr [7EA718445728]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,7E97548013E0
       mov       rdx,[rdx]
       mov       rcx,rbx
       mov       rdi,r15
       mov       esi,0FFFFFFFF
       add       rsp,8
       pop       rbx
       pop       r15
       jmp       qword ptr [7EA718F9D890]
; Total bytes of code 92
```
```assembly
; System.Threading.Tasks.AsyncLazy`1+Attempt+<RunAsync>d__4[[System.Int32, System.Private.CoreLib]].MoveNext()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rbx
       sub       rsp,98
       lea       rbp,[rsp+0C0]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm8,xmm8,xmm8
       vmovdqu   ymmword ptr [rbp-50],ymm8
       mov       [rbp-30],rax
       mov       [rbp-70],rdi
       mov       eax,[rdi+18]
       mov       rbx,[rdi]
       test      eax,eax
       je        near ptr M05_L30
       mov       rax,7E9754801370
       mov       r15,[rax]
       mov       r14,r15
       mov       rdi,7EA796AA0D68
       mov       rax,7EA797426820
       call      rax
       cmp       dword ptr [rax],4
       jle       near ptr M05_L26
       mov       rdi,[rax+8]
       mov       r13,[rdi+20]
       test      r13,r13
       je        near ptr M05_L26
M05_L00:
       mov       rax,[r13+10]
       test      rax,rax
       jne       short M05_L01
       call      qword ptr [7EA718C9C048]; System.Threading.Thread.InitializeCurrentThread()
M05_L01:
       mov       rdi,[rax+8]
       test      rdi,rdi
       je        short M05_L02
       mov       rdi,[rdi+8]
       lea       rdx,[rbp-40]
       mov       rsi,r14
       mov       r11,7EA717460500
       call      qword ptr [r11]
       mov       rsi,[rbp-40]
       jmp       short M05_L03
M05_L02:
       xor       esi,esi
M05_L03:
       xor       edi,edi
       mov       [rbp-40],rdi
       mov       r14,rsi
       test      r14,r14
       je        short M05_L04
       mov       rdi,offset MT_System.Threading.Tasks.AsyncLazyAttemptFrame
       cmp       [r14],rdi
       jne       near ptr M05_L27
M05_L04:
       mov       rdi,offset MT_System.Threading.Tasks.AsyncLazyAttemptFrame
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rdi,[r12+8]
       mov       rsi,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdi,[r12+10]
       mov       rsi,r14
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [r15+8],0
       setne     r14b
       movzx     r14d,r14b
       mov       rax,[r13+10]
       test      rax,rax
       jne       short M05_L05
       call      qword ptr [7EA718C9C048]; System.Threading.Thread.InitializeCurrentThread()
M05_L05:
       mov       rax,[rax+8]
       mov       [rbp-78],rax
       xor       edi,edi
       mov       [rbp-48],rdi
       xor       ecx,ecx
       test      rax,rax
       je        short M05_L06
       mov       rdi,[rax+8]
       lea       rdx,[rbp-48]
       mov       rsi,r15
       mov       r11,7EA717460518
       call      qword ptr [r11]
       mov       [rbp-4C],eax
       mov       rax,[rbp-78]
       mov       ecx,[rbp-4C]
M05_L06:
       cmp       [rbp-48],r12
       je        near ptr M05_L15
       xor       edi,edi
       mov       [rbp-58],rdi
       mov       [rbp-5C],edi
       test      rax,rax
       jne       short M05_L07
       mov       [rbp-4C],ecx
       mov       rdi,offset MT_System.Threading.AsyncLocalValueMap+OneElementAsyncLocalValueMap
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-98],rax
       lea       rdi,[rax+8]
       mov       rsi,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-98]
       lea       rdi,[rax+10]
       mov       rsi,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-98]
       mov       [rbp-80],rax
       jmp       short M05_L08
M05_L07:
       mov       [rbp-4C],ecx
       movzx     edx,byte ptr [rax+18]
       mov       [rbp-5C],edx
       test      r14d,r14d
       sete      cl
       movzx     ecx,cl
       mov       rdi,[rax+8]
       mov       rsi,r15
       mov       rdx,r12
       mov       r11,7EA717460510
       call      qword ptr [r11]
       mov       [rbp-80],rax
       mov       rdx,[rbp-78]
       mov       rdx,[rdx+10]
       mov       [rbp-58],rdx
M05_L08:
       test      r14d,r14d
       je        short M05_L10
       cmp       dword ptr [rbp-4C],0
       jne       short M05_L10
       cmp       qword ptr [rbp-58],0
       je        short M05_L09
       mov       rdx,[rbp-58]
       mov       ecx,[rdx+8]
       mov       [rbp-60],ecx
       lea       edx,[rcx+1]
       lea       rsi,[rbp-58]
       mov       rdi,7EA718FD08F0
       call      qword ptr [7EA71887C480]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       esi,[rbp-60]
       mov       rdi,[rbp-58]
       mov       rdx,r15
       call      qword ptr [7EA7184457A0]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M05_L10
M05_L09:
       mov       rdi,offset MT_System.Threading.IAsyncLocal[]
       mov       esi,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rbp-90],rax
       lea       rdi,[rax+10]
       mov       rsi,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-90]
       mov       [rbp-58],rax
M05_L10:
       mov       r13,[r13+10]
       test      r13,r13
       jne       short M05_L11
       call      qword ptr [7EA718C9C048]; System.Threading.Thread.InitializeCurrentThread()
       mov       r13,rax
M05_L11:
       cmp       dword ptr [rbp-5C],0
       jne       short M05_L12
       mov       rdi,7E9754801378
       mov       rax,[rbp-80]
       cmp       rax,[rdi]
       jne       short M05_L12
       xor       esi,esi
       jmp       short M05_L13
M05_L12:
       mov       rdi,offset MT_System.Threading.ExecutionContext
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       [rbp-88],rsi
       mov       rax,[rbp-58]
       mov       [rbp-0A0],rax
       lea       rdi,[rsi+8]
       mov       rsi,[rbp-80]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-88]
       lea       rdi,[rsi+10]
       mov       rsi,[rbp-0A0]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-88]
       mov       edi,[rbp-5C]
       mov       [rsi+18],dil
M05_L13:
       lea       rdi,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      r14d,r14d
       je        short M05_L15
       mov       rsi,[rbp-48]
       test      rsi,rsi
       jne       near ptr M05_L25
       xor       edi,edi
M05_L14:
       mov       rax,[r15+8]
       xor       ecx,ecx
       mov       [rsp],rdi
       mov       [rsp+8],r12
       mov       [rsp+10],cl
       mov       rdi,[rax+8]
       call      qword ptr [rax+18]
M05_L15:
       xor       edi,edi
       mov       [rbp-48],rdi
       mov       [rbp-58],rdi
       mov       rdi,[rbp-70]
       lea       rdi,[rdi+8]
       mov       rsi,r12
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rdi,rbx
       call      qword ptr [7EA718F96880]; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.Int32, System.Private.CoreLib]].InvokeFactory()
       mov       rdi,[rbp-70]
       lea       rdi,[rdi+10]
       mov       rsi,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rdi,[rbp-70]
       mov       rsi,[rdi+10]
       cmp       [rsi],sil
       mov       [rbp-38],rsi
       mov       dword ptr [rbp-30],2
       test      byte ptr [rbp-30],4
       jne       near ptr M05_L29
       mov       rsi,[rbp-38]
       test      dword ptr [rsi+34],1600000
       je        near ptr M05_L29
M05_L16:
       mov       rsi,[rbp-38]
       mov       eax,[rbp-30]
       mov       ecx,[rsi+34]
       and       ecx,11000000
       cmp       ecx,1000000
       jne       near ptr M05_L31
M05_L17:
       mov       rsi,[rdi+8]
       xor       eax,eax
       mov       [rsi+8],rax
       mov       r15,[rdi+10]
       mov       esi,[r15+34]
       and       esi,1600000
       cmp       esi,1000000
       jne       near ptr M05_L39
       mov       esi,[r15+34]
       and       esi,11000000
       cmp       esi,1000000
       jne       near ptr M05_L32
       mov       r14d,[r15+38]
M05_L18:
       mov       rax,[rbx+8]
       xor       ecx,ecx
       mov       [rax+18],rcx
       mov       [rax+20],rcx
       lea       eax,[r14+1]
       cmp       eax,0A
       jb        near ptr M05_L33
       mov       rdi,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       dword ptr [r15+34],1000000
       mov       [r15+38],r14d
M05_L19:
       mov       rdi,[rbx+8]
       lea       rdi,[rdi+10]
       mov       rsi,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+8]
       lea       rdi,[rdi+8]
       mov       rsi,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbx,[rbx+10]
       mov       r15,[rbx+8]
       xor       r13d,r13d
       mov       eax,[r15+34]
       mov       [rbp-64],eax
       test      eax,5600000
       jne       short M05_L23
       lea       rdi,[r15+34]
       mov       esi,eax
       or        esi,4000000
       lock cmpxchg [rdi],esi
       cmp       eax,[rbp-64]
       jne       near ptr M05_L34
M05_L20:
       mov       [r15+38],r14d
       lea       rdi,[r15+34]
       mov       eax,[r15+34]
       or        eax,1000000
       xchg      eax,[rdi]
       mov       r13,[r15+28]
       test      r13,r13
       jne       near ptr M05_L35
M05_L21:
       lea       rdi,[r15+20]
       test      rdi,rdi
       je        near ptr M05_L36
       mov       rsi,7E9754800238
       mov       rsi,[rsi]
       call      00007EA796874040
       test      rax,rax
       je        short M05_L22
       mov       rdi,r15
       mov       rsi,rax
       call      qword ptr [7EA718F9D638]
M05_L22:
       mov       r13d,1
M05_L23:
       test      r13d,r13d
       je        near ptr M05_L37
M05_L24:
       test      r13b,r13b
       jne       near ptr M05_L42
       jmp       near ptr M05_L38
M05_L25:
       mov       rdi,rsi
       mov       rax,offset MT_System.Threading.Tasks.AsyncLazyAttemptFrame
       cmp       [rdi],rax
       jne       short M05_L28
       jmp       near ptr M05_L14
M05_L26:
       mov       edi,4
       call      qword ptr [7EA718F9D3F8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r13,rax
       jmp       near ptr M05_L00
M05_L27:
       call      qword ptr [7EA718446310]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M05_L28:
       mov       rdi,rax
       call      qword ptr [7EA718446310]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M05_L29:
       xor       esi,esi
       mov       [rdi+18],esi
       lea       rdi,[rdi+28]
       mov       rsi,[rbp-38]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       esi,[rbp-30]
       mov       rdi,[rbp-70]
       mov       [rdi+30],esi
       lea       rsi,[rdi+20]
       call      qword ptr [7EA718F9D908]
       mov       rsi,rax
       lea       rdi,[rbp-38]
       call      qword ptr [7EA718F9D920]
       jmp       near ptr M05_L43
M05_L30:
       mov       rdi,[rbp-70]
       vmovdqu   xmm0,xmmword ptr [rdi+28]
       vmovdqu   xmmword ptr [rbp-38],xmm0
       xor       esi,esi
       mov       [rdi+28],rsi
       mov       [rdi+30],rsi
       mov       dword ptr [rdi+18],0FFFFFFFF
       mov       rdi,[rbp-70]
       jmp       near ptr M05_L16
M05_L31:
       mov       rdi,rsi
       mov       esi,eax
       call      qword ptr [7EA718F9D518]
       mov       rdi,[rbp-70]
       jmp       near ptr M05_L17
M05_L32:
       mov       rdi,r15
       mov       esi,1
       call      qword ptr [7EA718F9D878]
       mov       r14d,eax
       jmp       near ptr M05_L18
M05_L33:
       mov       rdi,offset MT_System.Threading.Tasks.TaskCache
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdi,7E97548013B0
       mov       rdi,[rdi]
       lea       esi,[r14+1]
       cmp       esi,[rdi+8]
       jae       near ptr M05_L40
       lea       esi,[r14+1]
       mov       r15,[rdi+rsi*8+10]
       jmp       near ptr M05_L19
M05_L34:
       mov       rdi,r15
       mov       esi,4000000
       mov       edx,5600000
       call      qword ptr [7EA718F9D5D8]
       test      eax,eax
       je        near ptr M05_L23
       jmp       near ptr M05_L20
M05_L35:
       mov       rdi,r15
       call      qword ptr [7EA718F9D5F0]
       mov       rdi,r13
       call      qword ptr [7EA718F9D608]
       jmp       near ptr M05_L21
M05_L36:
       call      qword ptr [7EA718F9D620]
       int       3
M05_L37:
       mov       rdi,[rbx+8]
       cmp       [rdi],edi
       call      qword ptr [7EA718F9D5A8]
       jmp       near ptr M05_L24
M05_L38:
       mov       edi,18
       call      qword ptr [7EA718F96C70]
       int       3
M05_L39:
       mov       rax,[rbx+8]
       xor       ecx,ecx
       mov       [rax+8],rcx
       mov       rdi,r15
       call      qword ptr [7EA718F96BB0]
       test      eax,eax
       je        short M05_L41
       mov       rbx,[rbx+10]
       mov       rdi,r15
       call      qword ptr [7EA718F96BC8]
       mov       rsi,rax
       mov       rdi,rbx
       cmp       [rdi],edi
       call      qword ptr [7EA718F96BE0]
       jmp       short M05_L42
M05_L40:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M05_L41:
       mov       r14,[rbx+10]
       mov       rdi,r15
       call      qword ptr [7EA718F96BF8]
       mov       rdi,rax
       cmp       [rdi],edi
       call      qword ptr [7EA718F96C10]
       mov       rsi,rax
       mov       rdi,r14
       cmp       [rdi],edi
       call      qword ptr [7EA718F96C28]
       mov       rdi,[rbx+10]
       mov       rdi,[rdi+8]
       cmp       [rdi],edi
       call      qword ptr [7EA718F96BF8]
       nop
M05_L42:
       mov       rdi,[rbp-70]
       mov       dword ptr [rdi+18],0FFFFFFFE
       xor       esi,esi
       mov       [rdi+8],rsi
       mov       [rdi+10],rsi
       add       rdi,20
       cmp       qword ptr [rdi],0
       jne       short M05_L44
       mov       rsi,7E9754800250
       mov       rsi,[rsi]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M05_L43:
       nop
       add       rsp,98
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M05_L44:
       mov       rdi,[rdi]
       xor       esi,esi
       call      qword ptr [7EA718F9D680]
       jmp       short M05_L43
       sub       rsp,18
       mov       rsi,rdi
       mov       rdi,[rbp-70]
       mov       dword ptr [rdi+18],0FFFFFFFE
       xor       eax,eax
       mov       [rdi+8],rax
       mov       [rdi+10],rax
       add       rdi,20
       call      qword ptr [7EA718F96940]
       lea       rax,[M05_L43]
       add       rsp,18
       ret
; Total bytes of code 1826
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbp
       push      rbx
       push      rax
       lea       rbp,[rsp+10]
       mov       ebx,edi
       call      qword ptr [7EA718006AF0]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       edi,ebx
       and       edi,0FFFFFF
       mov       ecx,edi
       mov       edx,ebx
       sar       edx,18
       jne       short M06_L01
       cmp       [rax],edi
       jle       short M06_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       ecx,0FFFFFFFE
       movsxd    rdi,ecx
       mov       rax,[rax+rdi*8+10]
       test      rax,rax
       je        short M06_L03
M06_L00:
       add       rsp,8
       pop       rbx
       pop       rbp
       ret
M06_L01:
       mov       edi,ebx
       sar       edi,18
       cmp       edi,2
       jne       short M06_L02
       movsxd    rcx,ecx
       add       rax,rcx
       jmp       short M06_L00
M06_L02:
       cmp       [rax+4],ecx
       jle       short M06_L03
       mov       rdi,[rax+10]
       movsxd    rax,ecx
       mov       rdi,[rdi+rax*8]
       test      rdi,rdi
       je        short M06_L03
       mov       rax,[rdi]
       test      rax,rax
       je        short M06_L03
       jmp       short M06_L00
M06_L03:
       mov       edi,ebx
       lea       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       add       rsp,8
       pop       rbx
       pop       rbp
       jmp       qword ptr [rax]
; Total bytes of code 133
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.Int32, System.Private.CoreLib]].AsyncLazy_NoRecursionDetection()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rbx
       push      rax
       lea       rbp,[rsp+30]
       mov       rbx,rdi
       mov       rdi,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        near ptr M00_L16
       lea       rdi,[r15+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[r15+10]
       test      rax,rax
       jne       near ptr M00_L17
M00_L00:
       mov       rbx,[r15+8]
       mov       rsi,rbx
       mov       rdi,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L19
       test      rbx,rbx
       je        short M00_L01
       mov       rdi,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt
       cmp       [rbx],rdi
       je        near ptr M00_L11
M00_L01:
       lea       rdi,[r15+20]
       cmp       qword ptr [rdi],0
       jne       near ptr M00_L18
M00_L02:
       mov       rdi,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdi,offset MT_System.Threading.Tasks.TaskCompletionSource<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdi,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       xor       edi,edi
       mov       [rax+8],rdi
       mov       [rax+10],rdi
       mov       [rax+18],rdi
       mov       dword ptr [rax+34],2000440
       lea       rdi,[rbx+8]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdi,[r14+10]
       mov       rsi,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdi,[r14+8]
       mov       rsi,r15
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdi,[r15+8]
       test      rdi,rdi
       je        near ptr M00_L21
       mov       rsi,r14
       xor       edx,edx
       call      00007949F7274060
       test      rax,rax
       jne       near ptr M00_L00
       mov       rdi,7939B4801378
       mov       r15,[rdi]
       test      r15,r15
       je        near ptr M00_L22
M00_L03:
       mov       rdi,7949F74A0D68
       mov       rax,7949F7DDA820
       call      rax
       cmp       dword ptr [rax],4
       jle       near ptr M00_L23
       mov       rdi,[rax+8]
       mov       rax,[rdi+20]
       test      rax,rax
       je        near ptr M00_L23
M00_L04:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M00_L05
       call      qword ptr [79497968C048]; System.Threading.Thread.InitializeCurrentThread()
M00_L05:
       mov       rbx,[rax+8]
       test      rbx,rbx
       jne       near ptr M00_L24
       mov       rdi,7939B4801380
       mov       rbx,[rdi]
M00_L06:
       test      rbx,rbx
       je        short M00_L07
       cmp       byte ptr [rbx+19],0
       je        near ptr M00_L25
M00_L07:
       mov       rdi,offset MT_System.Threading.QueueUserWorkItemCallbackDefaultContext<System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rdi,[r13+8]
       mov       rsi,r15
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdi,[r13+10]
       mov       rsi,r14
       call      CORINFO_HELP_ASSIGN_REF
M00_L08:
       mov       rdi,7939B4801390
       mov       rbx,[rdi]
       cmp       byte ptr [rbx+38],0
       jne       near ptr M00_L26
M00_L09:
       mov       rdi,[rbx+8]
       mov       rsi,[rdi+10]
       mov       rcx,[rsi+8]
M00_L10:
       mov       r15d,[rsi+0A0]
       mov       eax,r15d
       and       eax,[rsi+18]
       cmp       eax,[rcx+8]
       jae       near ptr M00_L28
       shl       rax,4
       lea       r12,[rcx+rax+10]
       mov       eax,[r12+8]
       sub       eax,r15d
       jne       short M00_L12
       lea       rdx,[rsi+0A0]
       lea       r8d,[r15+1]
       mov       eax,r15d
       lock cmpxchg [rdx],r8d
       cmp       eax,r15d
       jne       short M00_L10
       mov       rdi,r12
       mov       rsi,r13
       call      CORINFO_HELP_ASSIGN_REF
       inc       r15d
       mov       [r12+8],r15d
       jmp       short M00_L13
M00_L11:
       mov       rdi,rbx
       xor       esi,esi
       add       rsp,8
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [794979986730]; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.Int32, System.Private.CoreLib]].WaitAsync(System.Threading.CancellationToken)
M00_L12:
       test      eax,eax
       jge       short M00_L10
       mov       rsi,r13
       call      qword ptr [79497998E8F8]
M00_L13:
       add       rbx,78
       mov       edi,1
       xchg      edi,[rbx]
       test      edi,edi
       jne       short M00_L14
       mov       rdi,7939B48013B8
       mov       rbx,[rdi]
       lea       rdi,[rbx+160]
       lock inc  dword ptr [rdi]
       mov       rdi,rbx
       call      qword ptr [794979986BC8]; System.Threading.PortableThreadPool+WorkerThread.MaybeAddWorkingWorker(System.Threading.PortableThreadPool)
       cmp       dword ptr [rbx+164],6
       jne       near ptr M00_L27
M00_L14:
       mov       rax,[r14+10]
       mov       rax,[rax+8]
M00_L15:
       add       rsp,8
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L16:
       mov       edi,1
       mov       rsi,7949799BB4E0
       call      qword ptr [794978E3EF88]
       mov       rdi,rax
       call      qword ptr [79497998EA60]
       int       3
M00_L17:
       jmp       short M00_L15
M00_L18:
       mov       rdi,[rdi]
       cmp       dword ptr [rdi+20],0
       je        near ptr M00_L02
       jmp       short M00_L20
M00_L19:
       jmp       short M00_L15
M00_L20:
       mov       rdi,[r15+20]
       add       rsp,8
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [794979986658]
M00_L21:
       call      qword ptr [79497998E9E8]
       int       3
M00_L22:
       mov       rdi,offset MT_System.Action<System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdi,7939B4801370
       mov       rsi,[rdi]
       lea       rdi,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset System.Threading.Tasks.AsyncLazy`1+<>c[[System.Int32, System.Private.CoreLib]].<GetOrStartAttemptAsync>b__11_0(Attempt<Int32>)
       mov       [r15+18],rdi
       mov       rdi,7939B4801378
       mov       rsi,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L03
M00_L23:
       mov       edi,4
       call      qword ptr [79497998E730]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L04
M00_L24:
       xor       edi,edi
       cmp       byte ptr [rbx+18],0
       cmovne    rbx,rdi
       jmp       near ptr M00_L06
M00_L25:
       mov       rdi,offset MT_System.Threading.QueueUserWorkItemCallback<System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdi,r13
       mov       rsi,r15
       mov       rdx,r14
       mov       rcx,rbx
       call      qword ptr [79497998E8B0]
       jmp       near ptr M00_L08
M00_L26:
       mov       rdi,7939B48013A8
       mov       rdi,[rdi]
       cmp       byte ptr [rdi+9D],0
       je        near ptr M00_L09
       mov       rdi,7939B48013A8
       mov       rdi,[rdi]
       mov       rsi,r13
       call      qword ptr [79497998E8C8]
       jmp       near ptr M00_L09
M00_L27:
       mov       rdi,rbx
       call      qword ptr [794979986E38]; System.Threading.PortableThreadPool+GateThread.EnsureRunningSlow(System.Threading.PortableThreadPool)
       jmp       near ptr M00_L14
M00_L28:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 994
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.Int32, System.Private.CoreLib]](System.Threading.Tasks.Task`1<Int32>)
       push      rbx
       mov       rbx,rdi
       mov       edi,[rbx+34]
       and       edi,11000000
       cmp       edi,1000000
       jne       short M01_L01
M01_L00:
       mov       eax,[rbx+38]
       pop       rbx
       ret
M01_L01:
       mov       rdi,rbx
       xor       esi,esi
       call      qword ptr [7949799873A8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 39
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       push      rbp
       mov       rbp,rsp
       test      rsi,rsi
       je        short M02_L02
       mov       rax,[rsi]
       cmp       rax,rdi
       je        short M02_L02
       mov       rax,[rax+10]
       cmp       rax,rdi
       je        short M02_L02
M02_L00:
       test      rax,rax
       je        short M02_L01
       mov       rax,[rax+10]
       cmp       rax,rdi
       je        short M02_L02
       test      rax,rax
       je        short M02_L01
       mov       rax,[rax+10]
       cmp       rax,rdi
       je        short M02_L02
       test      rax,rax
       jne       short M02_L03
M02_L01:
       xor       esi,esi
M02_L02:
       mov       rax,rsi
       pop       rbp
       ret
M02_L03:
       mov       rax,[rax+10]
       cmp       rax,rdi
       je        short M02_L02
       test      rax,rax
       je        short M02_L01
       mov       rax,[rax+10]
       cmp       rax,rdi
       je        short M02_L02
       jmp       short M02_L00
; Total bytes of code 91
```
```assembly
; System.Threading.Thread.InitializeCurrentThread()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rbx
       sub       rsp,68
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-30],rax
       lea       rdi,[rbp-30]
       mov       [rbp-90],rdi
       lea       rdi,[rbp-88]
       call      qword ptr [7949789DEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdi,[rbp-90]
       call      qword ptr [rax]
       lea       rdi,[rbp-88]
       call      qword ptr [7949789DEF08]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-30]
       call      qword ptr [7949789E0B98]
       lea       rdi,[rax+10]
       mov       rsi,[rbp-30]
       call      qword ptr [7949789DEEB8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       add       rsp,68
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 123
```
```assembly
; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.Int32, System.Private.CoreLib]].WaitAsync(System.Threading.CancellationToken)
       push      r15
       push      rbx
       push      rax
       mov       rbx,rsi
       test      rbx,rbx
       jne       short M04_L00
       mov       rax,[rdi+10]
       mov       rax,[rax+8]
       add       rsp,8
       pop       rbx
       pop       r15
       ret
M04_L00:
       mov       rdi,[rdi+10]
       mov       r15,[rdi+8]
       cmp       [r15],r15b
       mov       rdi,offset MT_System.TimeProvider
       call      qword ptr [794978E35728]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,7939B4801480
       mov       rdx,[rdx]
       mov       rcx,rbx
       mov       rdi,r15
       mov       esi,0FFFFFFFF
       add       rsp,8
       pop       rbx
       pop       r15
       jmp       qword ptr [79497998EE50]
; Total bytes of code 92
```
```assembly
; System.Threading.PortableThreadPool+WorkerThread.MaybeAddWorkingWorker(System.Threading.PortableThreadPool)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rbx
       sub       rsp,18
       lea       rbp,[rsp+40]
       mov       rax,[rdi+0A0]
       movsx     rsi,ax
       mov       rcx,rax
       shr       rcx,20
       movsx     rcx,cx
       cmp       esi,ecx
       jge       near ptr M05_L08
M05_L00:
       lea       ecx,[rsi+1]
       movsx     rbx,cx
       mov       rcx,rax
       shr       rcx,10
       movsx     rcx,cx
       cmp       ecx,ebx
       jge       near ptr M05_L09
       mov       r15d,ebx
M05_L01:
       test      ebx,ebx
       jle       near ptr M05_L10
       mov       edx,ebx
M05_L02:
       mov       r8,rax
       and       r8,0FFFFFFFFFFFF0000
       movzx     edx,dx
       or        rdx,r8
       test      r15d,r15d
       jle       near ptr M05_L11
       mov       r8d,r15d
M05_L03:
       mov       r9,0FFFFFFFF0000FFFF
       and       rdx,r9
       movzx     r8d,r8w
       shl       r8,10
       or        rdx,r8
       lea       r8,[rdi+0A0]
       mov       [rbp-38],rax
       lock cmpxchg [r8],rdx
       mov       rdx,[rbp-38]
       cmp       rax,rdx
       jne       near ptr M05_L12
       sub       r15d,ecx
       sub       ebx,esi
       test      ebx,ebx
       jle       short M05_L07
       mov       rdi,7939B48013C0
       mov       r14,[rdi]
       mov       r13,[r14+60]
M05_L04:
       mov       [rbp-30],r13
       mov       edi,ebx
       add       rdi,[rbp-30]
       mov       [rbp-30],rdi
       mov       r12d,[rbp-30]
       mov       rax,r13
       shr       rax,20
       movzx     eax,ax
       mov       rdi,r13
       shr       rdi,30
       movzx     edi,dil
       add       eax,edi
       cmp       r12d,eax
       ja        near ptr M05_L13
M05_L05:
       sub       r12d,edi
       mov       rdi,r13
       shr       rdi,38
       movzx     edi,dil
       sub       r12d,edi
       test      r12d,r12d
       jg        short M05_L15
M05_L06:
       lea       rdi,[r14+60]
       mov       rsi,[rbp-30]
       mov       rax,r13
       lock cmpxchg [rdi],rsi
       cmp       rax,r13
       jne       short M05_L14
       test      r12d,r12d
       jg        short M05_L17
M05_L07:
       test      r15d,r15d
       jg        near ptr M05_L18
M05_L08:
       add       rsp,18
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M05_L09:
       mov       r15d,ecx
       jmp       near ptr M05_L01
M05_L10:
       xor       edx,edx
       jmp       near ptr M05_L02
M05_L11:
       xor       r8d,r8d
       jmp       near ptr M05_L03
M05_L12:
       mov       rdx,rax
       movsx     rsi,dx
       mov       rcx,rdx
       shr       rcx,20
       movsx     rcx,cx
       cmp       esi,ecx
       mov       rax,rdx
       jl        near ptr M05_L00
       jmp       short M05_L08
M05_L13:
       mov       r12d,eax
       jmp       near ptr M05_L05
M05_L14:
       mov       r13,rax
       jmp       near ptr M05_L04
M05_L15:
       cmp       r12d,ebx
       jle       short M05_L16
       mov       r12d,ebx
M05_L16:
       lea       rdi,[rbp-30]
       mov       esi,r12d
       call      qword ptr [79497998EE08]; System.Threading.LowLevelLifoSemaphore+Counts.AddUpToMaxCountOfWaitersSignaledToWake(UInt32)
       jmp       near ptr M05_L06
M05_L17:
       mov       rdi,[r14+8]
       mov       esi,r12d
       cmp       [rdi],edi
       call      qword ptr [79497998EE20]; System.Threading.Semaphore.Release(Int32)
       jmp       near ptr M05_L07
M05_L18:
       call      qword ptr [794979986D78]; System.Threading.PortableThreadPool+WorkerThread.CreateWorkerThread()
       dec       r15d
       jmp       near ptr M05_L07
; Total bytes of code 447
```
```assembly
; System.Threading.Tasks.AsyncLazy`1+<>c[[System.Int32, System.Private.CoreLib]].<GetOrStartAttemptAsync>b__11_0(Attempt<Int32>)
       push      rbp
       push      r15
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+60]
       vxorps    xmm8,xmm8,xmm8
       vmovdqu   ymmword ptr [rbp-40],ymm8
       vmovdqa   xmmword ptr [rbp-20],xmm8
       cmp       [rsi],sil
       mov       [rbp-40],rsi
       mov       dword ptr [rbp-30],0FFFFFFFF
       mov       rdi,7949F74A0D68
       mov       rax,7949F7DDA820
       call      rax
       cmp       dword ptr [rax],4
       jle       near ptr M06_L08
       mov       rdi,[rax+8]
       mov       rax,[rdi+20]
       test      rax,rax
       je        near ptr M06_L08
M06_L00:
       mov       rbx,[rax+10]
       test      rbx,rbx
       jne       short M06_L01
       call      qword ptr [79497968C048]; System.Threading.Thread.InitializeCurrentThread()
       mov       rbx,rax
M06_L01:
       mov       [rbp-48],rbx
       mov       rsi,[rbx+8]
       mov       [rbp-50],rsi
       mov       rsi,[rbx+10]
       mov       [rbp-58],rsi
       lea       rdi,[rbp-40]
       call      qword ptr [794979987828]; System.Threading.Tasks.AsyncLazy`1+Attempt+<RunAsync>d__4[[System.Int32, System.Private.CoreLib]].MoveNext()
       nop
       mov       rsi,[rbp-58]
       cmp       rsi,[rbx+10]
       je        short M06_L02
       lea       rdi,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
M06_L02:
       mov       r15,[rbx+8]
       mov       rsi,[rbp-50]
       cmp       rsi,r15
       je        short M06_L04
       lea       rdi,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      r15,r15
       je        short M06_L03
       cmp       qword ptr [r15+10],0
       jne       short M06_L07
M06_L03:
       cmp       qword ptr [rbp-50],0
       jne       short M06_L06
M06_L04:
       cmp       qword ptr [rbp-28],0
       je        short M06_L09
M06_L05:
       add       rsp,50
       pop       rbx
       pop       r15
       pop       rbp
       ret
M06_L06:
       mov       rsi,[rbp-50]
       cmp       qword ptr [rsi+10],0
       je        short M06_L04
M06_L07:
       mov       rdi,r15
       mov       rsi,[rbp-50]
       call      qword ptr [79497998E7A8]
       jmp       short M06_L04
M06_L08:
       mov       edi,4
       call      qword ptr [79497998E730]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M06_L00
M06_L09:
       lea       rdi,[rbp-28]
       call      qword ptr [79497998EA18]
       jmp       short M06_L05
       push      rax
       mov       rsi,[rbp-58]
       mov       rax,[rbp-48]
       cmp       rsi,[rax+10]
       je        short M06_L10
       lea       rdi,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-48]
M06_L10:
       mov       r15,[rax+8]
       mov       rsi,[rbp-50]
       cmp       rsi,r15
       je        short M06_L13
       lea       rdi,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      r15,r15
       je        short M06_L11
       cmp       qword ptr [r15+10],0
       jne       short M06_L12
M06_L11:
       cmp       qword ptr [rbp-50],0
       je        short M06_L13
       mov       rsi,[rbp-50]
       cmp       qword ptr [rsi+10],0
       je        short M06_L13
M06_L12:
       mov       rdi,r15
       mov       rsi,[rbp-50]
       call      qword ptr [79497998E7A8]
M06_L13:
       nop
       add       rsp,8
       ret
; Total bytes of code 368
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbp
       push      rbx
       push      rax
       lea       rbp,[rsp+10]
       mov       ebx,edi
       call      qword ptr [7949789F6AF0]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       edi,ebx
       and       edi,0FFFFFF
       mov       ecx,edi
       mov       edx,ebx
       sar       edx,18
       jne       short M07_L01
       cmp       [rax],edi
       jle       short M07_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       ecx,0FFFFFFFE
       movsxd    rdi,ecx
       mov       rax,[rax+rdi*8+10]
       test      rax,rax
       je        short M07_L03
M07_L00:
       add       rsp,8
       pop       rbx
       pop       rbp
       ret
M07_L01:
       mov       edi,ebx
       sar       edi,18
       cmp       edi,2
       jne       short M07_L02
       movsxd    rcx,ecx
       add       rax,rcx
       jmp       short M07_L00
M07_L02:
       cmp       [rax+4],ecx
       jle       short M07_L03
       mov       rdi,[rax+10]
       movsxd    rax,ecx
       mov       rdi,[rdi+rax*8]
       test      rdi,rdi
       je        short M07_L03
       mov       rax,[rdi]
       test      rax,rax
       je        short M07_L03
       jmp       short M07_L00
M07_L03:
       mov       edi,ebx
       lea       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       add       rsp,8
       pop       rbx
       pop       rbp
       jmp       qword ptr [rax]
; Total bytes of code 133
```
```assembly
; System.Threading.PortableThreadPool+GateThread.EnsureRunningSlow(System.Threading.PortableThreadPool)
       push      rbp
       mov       rbp,rsp
       add       rdi,164
       mov       eax,6
       xchg      eax,[rdi]
       cmp       eax,4
       je        short M08_L03
       test      al,4
       je        short M08_L02
M08_L00:
       mov       rdi,794979AAC8C8
       call      CORINFO_HELP_COUNTPROFILE32
M08_L01:
       nop
       pop       rbp
       ret
M08_L02:
       mov       rdi,794979AAC8C4
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [794979986E68]; System.Threading.PortableThreadPool+GateThread.CreateGateThread()
       jmp       short M08_L00
M08_L03:
       mov       rdi,794979AAC8C0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rdi,7939B48013E0
       mov       rdi,[rdi]
       call      qword ptr [794979A47450]
       jmp       short M08_L01
; Total bytes of code 104
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rbp
       push      r15
       push      rbx
       lea       rbp,[rsp+10]
       mov       rbx,rdi
       mov       r15d,esi
       test      dword ptr [rbx+34],1600000
       jne       short M09_L00
       mov       rdi,rbx
       mov       esi,0FFFFFFFF
       xor       edx,edx
       call      qword ptr [7949799873C0]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M09_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M09_L03
M09_L01:
       mov       edi,[rbx+34]
       and       edi,1600000
       cmp       edi,1000000
       jne       short M09_L04
M09_L02:
       pop       rbx
       pop       r15
       pop       rbp
       ret
M09_L03:
       mov       rdi,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M09_L01
       mov       rdi,rbx
       call      qword ptr [79497998ED90]
       jmp       short M09_L01
M09_L04:
       test      r15b,2
       jne       short M09_L05
       mov       rdi,rbx
       call      qword ptr [79497998EAC0]
M09_L05:
       mov       rdi,rbx
       call      qword ptr [79497998F0D8]
       jmp       short M09_L02
; Total bytes of code 125
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.Int32, System.Private.CoreLib]].Nito()
       push      rbp
       push      r15
       push      r14
       push      rbx
       sub       rsp,18
       lea       rbp,[rsp+30]
       mov       rbx,[rdi+8]
       test      rbx,rbx
       je        near ptr M00_L05
       mov       rdi,offset MT_Nito.AsyncEx.AsyncLazy<System.Int32>+<>c__DisplayClass14_0
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rdi,[r15+8]
       mov       rsi,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset MT_System.Func<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rdi,[rbx+8]
       mov       rsi,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset Nito.AsyncEx.AsyncLazy`1+<>c__DisplayClass14_0[[System.Int32, System.Private.CoreLib]].<RunOnThreadPool>b__0()
       mov       [rbx+18],rdi
       mov       rdi,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdi,offset MT_System.Lazy<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rdi,[r14+10]
       mov       rsi,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset MT_System.LazyHelper
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+10],8
       lea       rdi,[r14+8]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-28],r15
       xor       edi,edi
       mov       [rbp-1C],edi
       mov       rdi,r15
       call      000076CC3C8E6020
       test      eax,eax
       je        short M00_L01
M00_L00:
       mov       dword ptr [rbp-1C],1
       cmp       qword ptr [r14+8],0
       je        short M00_L02
       mov       rdi,r14
       call      qword ptr [76CBBEEAC438]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rbx,rax
       jmp       short M00_L03
M00_L01:
       mov       rdi,r15
       call      qword ptr [76CBBF1AEB20]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L00
M00_L02:
       mov       rbx,[r14+18]
M00_L03:
       mov       rdi,r15
       call      000076CC3C8E6790
       test      eax,eax
       jne       short M00_L06
M00_L04:
       mov       rax,rbx
       add       rsp,18
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L05:
       mov       rdi,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       edi,10E
       mov       rsi,76CBBF1DAED0
       call      qword ptr [76CBBE65EF88]
       mov       rsi,rax
       mov       rdi,rbx
       call      qword ptr [76CBBEEADF68]
       mov       rdi,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       mov       edi,eax
       mov       rsi,r15
       call      qword ptr [76CBBF1AE628]
       jmp       short M00_L04
       push      rax
       cmp       dword ptr [rbp-1C],0
       je        short M00_L07
       mov       rdi,[rbp-28]
       call      000076CC3C8E6790
       test      eax,eax
       je        short M00_L07
       mov       edi,eax
       mov       rsi,[rbp-28]
       call      qword ptr [76CBBF1AE628]
M00_L07:
       nop
       add       rsp,8
       ret
; Total bytes of code 385
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.Int32, System.Private.CoreLib]](System.Threading.Tasks.Task`1<Int32>)
       push      rbx
       mov       rbx,rdi
       mov       edi,[rbx+34]
       and       edi,11000000
       cmp       edi,1000000
       jne       short M01_L01
M01_L00:
       mov       eax,[rbx+38]
       pop       rbx
       ret
M01_L01:
       mov       rdi,rbx
       xor       esi,esi
       call      qword ptr [76CBBF1A74B0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 39
```
```assembly
; Nito.AsyncEx.AsyncLazy`1+<>c__DisplayClass14_0[[System.Int32, System.Private.CoreLib]].<RunOnThreadPool>b__0()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rbx
       push      rax
       lea       rbp,[rsp+30]
       mov       rbx,[rdi+8]
       test      rbx,rbx
       je        near ptr M02_L16
       mov       r15,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task<System.Int32>>
       mov       rdi,r15
       call      qword ptr [76CBBF1A6670]; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].get_Factory()
       cmp       [rax],al
       mov       rdi,76BBF8801388
       mov       r14,[rdi]
       mov       rdi,r15
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rdi,[r15+8]
       mov       rsi,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       edi,edi
       mov       [r15+10],rdi
       lea       rdi,[r15+18]
       mov       rsi,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       edi,2008
       mov       [r15+34],edi
       mov       rdi,76CC3CCA0D68
       mov       rax,76CC3D522820
       call      rax
       cmp       dword ptr [rax],4
       jle       near ptr M02_L15
       mov       rdi,[rax+8]
       mov       rax,[rdi+20]
       test      rax,rax
       je        near ptr M02_L15
M02_L00:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M02_L01
       call      qword ptr [76CBBEEAC048]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       rbx,[rax+8]
       test      rbx,rbx
       je        short M02_L02
       xor       edi,edi
       cmp       byte ptr [rbx+18],0
       cmovne    rbx,rdi
       jmp       short M02_L03
M02_L02:
       mov       rdi,76BBF8801398
       mov       rbx,[rdi]
M02_L03:
       test      rbx,rbx
       je        short M02_L05
       mov       rdi,76BBF8801398
       cmp       rbx,[rdi]
       je        short M02_L06
       mov       rax,[r15+28]
       test      rax,rax
       jne       short M02_L04
       mov       rdi,offset MT_System.Threading.Tasks.Task+ContingentProperties
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [r14+3C],1
       lea       rdi,[r15+28]
       mov       rsi,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,r14
M02_L04:
       lea       rdi,[rax+8]
       mov       rsi,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M02_L06
M02_L05:
       or        dword ptr [r15+34],20000000
M02_L06:
       mov       rdi,r15
       xor       esi,esi
       call      qword ptr [76CBBF1A6868]; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
       mov       rdi,offset MT_System.Threading.Tasks.UnwrapPromise<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       movzx     r14d,word ptr [r15+34]
       and       r14d,4
       test      r14d,0FFFFFFBB
       jne       near ptr M02_L14
       test      r14b,4
       je        short M02_L09
       mov       rdi,76CC3CCA0D68
       mov       rax,76CC3D522820
       call      rax
       cmp       dword ptr [rax],8
       jle       near ptr M02_L17
       mov       rdi,[rax+8]
       mov       rax,[rdi+40]
       test      rax,rax
       je        near ptr M02_L17
M02_L07:
       mov       r13,[rax+10]
       test      r13,r13
       je        short M02_L09
       mov       rax,[rbx+28]
       test      rax,rax
       jne       short M02_L08
       mov       rdi,offset MT_System.Threading.Tasks.Task+ContingentProperties
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       dword ptr [r12+3C],1
       lea       rdi,[rbx+28]
       mov       rsi,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,r12
M02_L08:
       lea       rdi,[rax+30]
       mov       rsi,r13
       call      CORINFO_HELP_ASSIGN_REF
M02_L09:
       xor       edi,edi
       mov       [rbx+8],rdi
       mov       [rbx+10],rdi
       mov       [rbx+18],rdi
       test      r14d,0FFFFFFA0
       jne       near ptr M02_L14
       mov       edi,r14d
       or        edi,400
       or        edi,2000000
       mov       [rbx+34],edi
       mov       rdi,[rbx+28]
       test      rdi,rdi
       jne       near ptr M02_L18
M02_L10:
       mov       byte ptr [rbx+3D],1
       mov       rdi,76BBF88013A8
       mov       rdi,[rdi]
       cmp       byte ptr [rdi+9D],0
       jne       near ptr M02_L19
M02_L11:
       cmp       byte ptr [76CBBD66B06C],0
       jne       near ptr M02_L20
M02_L12:
       test      dword ptr [r15+34],1600000
       jne       near ptr M02_L21
       test      dword ptr [r15+34],1600000
       jne       near ptr M02_L24
       cmp       qword ptr [r15+20],0
       jne       near ptr M02_L23
       lea       rdi,[r15+20]
       test      rdi,rdi
       je        near ptr M02_L22
       mov       rsi,rbx
       xor       edx,edx
       call      000076CC3CA74060
       test      rax,rax
       jne       near ptr M02_L23
M02_L13:
       mov       rax,rbx
       add       rsp,8
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L14:
       mov       edi,2D
       call      qword ptr [76CBBE65F0D8]
       int       3
M02_L15:
       mov       edi,4
       call      qword ptr [76CBBF1AE7F0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M02_L00
M02_L16:
       mov       edi,2E
       call      qword ptr [76CBBE65FAE0]
       int       3
M02_L17:
       mov       edi,8
       call      qword ptr [76CBBF1AE7F0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M02_L07
M02_L18:
       mov       rdi,[rdi+30]
       test      rdi,rdi
       je        near ptr M02_L10
       test      r14b,4
       je        near ptr M02_L10
       test      byte ptr [rdi+34],8
       jne       near ptr M02_L10
       call      qword ptr [76CBBF1AE640]
       jmp       near ptr M02_L10
M02_L19:
       mov       rdi,rbx
       call      qword ptr [76CBBF1A71E0]
       mov       esi,eax
       mov       rdi,76BBF88013A8
       mov       rdi,[rdi]
       mov       rdx,76CBBC20A850
       xor       ecx,ecx
       call      qword ptr [76CBBF1A71F8]
       jmp       near ptr M02_L11
M02_L20:
       mov       rdi,rbx
       call      qword ptr [76CBBF1A7210]
       jmp       near ptr M02_L12
M02_L21:
       mov       rdi,rbx
       mov       rsi,r15
       call      qword ptr [76CBBF1A7258]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].ProcessCompletedOuterTask(System.Threading.Tasks.Task)
       jmp       near ptr M02_L13
M02_L22:
       call      qword ptr [76CBBF1AE718]
       int       3
M02_L23:
       mov       rdi,r15
       mov       rsi,rbx
       xor       edx,edx
       call      qword ptr [76CBBF1AF0A8]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M02_L13
M02_L24:
       mov       rdi,rbx
       mov       rsi,r15
       call      qword ptr [76CBBF1E10A8]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
       jmp       near ptr M02_L13
; Total bytes of code 893
```
```assembly
; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
M03_L00:
       push      rbp
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp-10],rdi
       mov       [rbp-20],rdi
M03_L01:
       mov       rbx,[rdi+8]
       test      rbx,rbx
       je        short M03_L05
       mov       eax,[rbx+10]
       cmp       eax,8
       jne       short M03_L06
       mov       [rbp-28],rbx
       xor       eax,eax
       mov       [rbp-14],eax
       mov       rdi,rbx
       call      000076CC3C8E6020
       test      eax,eax
       je        short M03_L03
M03_L02:
       mov       dword ptr [rbp-14],1
       mov       rdi,[rbp-20]
       cmp       [rdi+8],rbx
       jne       short M03_L04
       mov       esi,2
       call      qword ptr [76CBBEEAC468]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M03_L04
M03_L03:
       mov       rdi,rbx
       call      qword ptr [76CBBF1AEB20]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M03_L02
M03_L04:
       mov       rdi,rbx
       call      000076CC3C8E6790
       test      eax,eax
       jne       near ptr M03_L12
M03_L05:
       mov       rdi,[rbp-20]
       cmp       qword ptr [rdi+8],0
       je        near ptr M03_L13
       add       rsp,28
       pop       rbx
       pop       rbp
       jmp       qword ptr [76CBBEEAC438]
M03_L06:
       cmp       eax,8
       ja        short M03_L07
       mov       eax,eax
       lea       rcx,[76CBBE6D82D0]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M03_L01]
       add       rcx,rdx
       jmp       rcx
M03_L07:
       mov       rdi,[rbx+8]
       cmp       [rdi],edi
       call      qword ptr [76CBBF1AED48]
       int       3
       mov       rdi,[rbp-20]
       call      qword ptr [76CBBF1AEFE8]
       jmp       short M03_L05
       mov       rdi,[rbp-20]
       xor       esi,esi
       call      qword ptr [76CBBEEAC468]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M03_L05
       mov       rdi,[rbp-20]
       mov       rsi,[rdi]
       mov       rax,[rsi+30]
       mov       rax,[rax]
       mov       rax,[rax+10]
       test      rax,rax
       je        short M03_L08
       jmp       short M03_L09
M03_L08:
       mov       rdi,rsi
       mov       rsi,76CBBF1F84F0
       call      qword ptr [76CBBE65F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M03_L09:
       mov       rdi,[rax+30]
       mov       rdi,[rdi]
       mov       rdi,[rdi+18]
       test      rdi,rdi
       je        short M03_L10
       jmp       short M03_L11
M03_L10:
       mov       rdi,rax
       mov       rsi,76CBBF1F8590
       call      qword ptr [76CBBE65F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M03_L11:
       call      qword ptr [76CBBF1AEF88]
       mov       rdx,rax
       mov       rsi,rbx
       mov       rdi,[rbp-20]
       call      qword ptr [76CBBF1AF000]
       jmp       near ptr M03_L05
       mov       rdi,[rbp-20]
       mov       rsi,rbx
       call      qword ptr [76CBBF1AF018]
       jmp       near ptr M03_L05
       mov       rdi,[rbp-20]
       call      qword ptr [76CBBF1AF030]
       jmp       near ptr M03_L05
       mov       rdi,[rbp-20]
       mov       rsi,rbx
       mov       edx,1
       call      qword ptr [76CBBEEAC450]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M03_L05
M03_L12:
       mov       edi,eax
       mov       rsi,rbx
       call      qword ptr [76CBBF1AE628]
       jmp       near ptr M03_L05
M03_L13:
       mov       rax,[rdi+18]
       add       rsp,28
       pop       rbx
       pop       rbp
       ret
       push      rax
       cmp       dword ptr [rbp-14],0
       je        short M03_L14
       mov       rdi,[rbp-28]
       call      000076CC3C8E6790
       test      eax,eax
       je        short M03_L14
       mov       edi,eax
       mov       rsi,[rbp-28]
       call      qword ptr [76CBBF1AE628]
M03_L14:
       nop
       add       rsp,8
       ret
; Total bytes of code 441
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
       call      qword ptr [76CBBE1FEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdi,[rbp-90]
       call      qword ptr [rax]
       lea       rdi,[rbp-88]
       call      qword ptr [76CBBE1FEF08]; CORINFO_HELP_JIT_PINVOKE_END
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
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rbp
       push      r15
       push      rbx
       lea       rbp,[rsp+10]
       mov       rbx,rdi
       mov       r15d,esi
       test      dword ptr [rbx+34],1600000
       jne       short M05_L00
       mov       rdi,rbx
       mov       esi,0FFFFFFFF
       xor       edx,edx
       call      qword ptr [76CBBF1A74C8]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M05_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M05_L03
M05_L01:
       mov       edi,[rbx+34]
       and       edi,1600000
       cmp       edi,1000000
       jne       short M05_L04
M05_L02:
       pop       rbx
       pop       r15
       pop       rbp
       ret
M05_L03:
       mov       rdi,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M05_L01
       mov       rdi,rbx
       call      qword ptr [76CBBF1AF300]
       jmp       short M05_L01
M05_L04:
       test      r15b,2
       jne       short M05_L05
       mov       rdi,rbx
       call      qword ptr [76CBBF1AF2D0]
M05_L05:
       mov       rdi,rbx
       call      qword ptr [76CBBF1AF708]
       jmp       short M05_L02
; Total bytes of code 125
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.Int32, System.Private.CoreLib]].Nito_ExecuteOnCallingThread()
       push      rbp
       push      r15
       push      r14
       push      rbx
       sub       rsp,18
       lea       rbp,[rsp+30]
       mov       rbx,[rdi+8]
       test      rbx,rbx
       je        near ptr M00_L05
       mov       rdi,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdi,offset MT_System.Lazy<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rdi,[r14+10]
       mov       rsi,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset MT_System.LazyHelper
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+10],8
       lea       rdi,[r14+8]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-28],r15
       xor       edi,edi
       mov       [rbp-1C],edi
       mov       rdi,r15
       call      000075B2F6AE6020
       test      eax,eax
       je        short M00_L01
M00_L00:
       mov       dword ptr [rbp-1C],1
       cmp       qword ptr [r14+8],0
       je        short M00_L02
       mov       rdi,r14
       call      qword ptr [75B27908C438]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rbx,rax
       jmp       short M00_L03
M00_L01:
       mov       rdi,r15
       call      qword ptr [75B27938CAE0]
       jmp       short M00_L00
M00_L02:
       mov       rbx,[r14+18]
M00_L03:
       mov       rdi,r15
       call      000075B2F6AE6790
       test      eax,eax
       jne       short M00_L06
M00_L04:
       mov       rax,rbx
       add       rsp,18
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L05:
       mov       rdi,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       edi,10E
       mov       rsi,75B2793BAED0
       call      qword ptr [75B27883EF88]
       mov       rsi,rax
       mov       rdi,rbx
       call      qword ptr [75B27908DF68]
       mov       rdi,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       mov       edi,eax
       mov       rsi,r15
       call      qword ptr [75B27938CA68]
       jmp       short M00_L04
       push      rax
       cmp       dword ptr [rbp-1C],0
       je        short M00_L07
       mov       rdi,[rbp-28]
       call      000075B2F6AE6790
       test      eax,eax
       je        short M00_L07
       mov       edi,eax
       mov       rsi,[rbp-28]
       call      qword ptr [75B27938CA68]
M00_L07:
       nop
       add       rsp,8
       ret
; Total bytes of code 311
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.Int32, System.Private.CoreLib]](System.Threading.Tasks.Task`1<Int32>)
       push      rbx
       mov       rbx,rdi
       mov       edi,[rbx+34]
       and       edi,11000000
       cmp       edi,1000000
       jne       short M01_L01
M01_L00:
       mov       eax,[rbx+38]
       pop       rbx
       ret
M01_L01:
       mov       rdi,rbx
       xor       esi,esi
       call      qword ptr [75B27938CA98]
       jmp       short M01_L00
; Total bytes of code 39
```
```assembly
; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
M02_L00:
       push      rbp
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp-10],rdi
       mov       [rbp-20],rdi
M02_L01:
       mov       rbx,[rdi+8]
       test      rbx,rbx
       je        short M02_L05
       mov       eax,[rbx+10]
       cmp       eax,8
       jne       short M02_L06
       mov       [rbp-28],rbx
       xor       eax,eax
       mov       [rbp-14],eax
       mov       rdi,rbx
       call      000075B2F6AE6020
       test      eax,eax
       je        short M02_L03
M02_L02:
       mov       dword ptr [rbp-14],1
       mov       rdi,[rbp-20]
       cmp       [rdi+8],rbx
       jne       short M02_L04
       mov       esi,2
       call      qword ptr [75B27908C468]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M02_L04
M02_L03:
       mov       rdi,rbx
       call      qword ptr [75B27938CAE0]
       jmp       short M02_L02
M02_L04:
       mov       rdi,rbx
       call      000075B2F6AE6790
       test      eax,eax
       jne       near ptr M02_L12
M02_L05:
       mov       rdi,[rbp-20]
       cmp       qword ptr [rdi+8],0
       je        near ptr M02_L13
       add       rsp,28
       pop       rbx
       pop       rbp
       jmp       qword ptr [75B27908C438]
M02_L06:
       cmp       eax,8
       ja        short M02_L07
       mov       eax,eax
       lea       rcx,[75B2788ABA10]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M02_L01]
       add       rcx,rdx
       jmp       rcx
M02_L07:
       mov       rdi,[rbx+8]
       cmp       [rdi],edi
       call      qword ptr [75B27938CBB8]
       int       3
       mov       rdi,[rbp-20]
       call      qword ptr [75B27938CB58]
       jmp       short M02_L05
       mov       rdi,[rbp-20]
       xor       esi,esi
       call      qword ptr [75B27908C468]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M02_L05
       mov       rdi,[rbp-20]
       mov       rsi,[rdi]
       mov       rax,[rsi+30]
       mov       rax,[rax]
       mov       rax,[rax+10]
       test      rax,rax
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rdi,rsi
       mov       rsi,75B2793AF3A8
       call      qword ptr [75B27883F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L09:
       mov       rdi,[rax+30]
       mov       rdi,[rdi]
       mov       rdi,[rdi+18]
       test      rdi,rdi
       je        short M02_L10
       jmp       short M02_L11
M02_L10:
       mov       rdi,rax
       mov       rsi,75B2793AF448
       call      qword ptr [75B27883F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M02_L11:
       call      qword ptr [75B27938CAF8]
       mov       rdx,rax
       mov       rsi,rbx
       mov       rdi,[rbp-20]
       call      qword ptr [75B27938CB70]
       jmp       near ptr M02_L05
       mov       rdi,[rbp-20]
       mov       rsi,rbx
       call      qword ptr [75B27938CB88]
       jmp       near ptr M02_L05
       mov       rdi,[rbp-20]
       call      qword ptr [75B27938CBA0]
       jmp       near ptr M02_L05
       mov       rdi,[rbp-20]
       mov       rsi,rbx
       mov       edx,1
       call      qword ptr [75B27908C450]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M02_L05
M02_L12:
       mov       edi,eax
       mov       rsi,rbx
       call      qword ptr [75B27938CA68]
       jmp       near ptr M02_L05
M02_L13:
       mov       rax,[rdi+18]
       add       rsp,28
       pop       rbx
       pop       rbp
       ret
       push      rax
       cmp       dword ptr [rbp-14],0
       je        short M02_L14
       mov       rdi,[rbp-28]
       call      000075B2F6AE6790
       test      eax,eax
       je        short M02_L14
       mov       edi,eax
       mov       rsi,[rbp-28]
       call      qword ptr [75B27938CA68]
M02_L14:
       nop
       add       rsp,8
       ret
; Total bytes of code 441
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.Int32, System.Private.CoreLib]].VsThreading()
       push      r15
       push      rbx
       push      rax
       mov       rbx,rdi
       mov       rdi,offset MT_Microsoft.VisualStudio.Threading.AsyncLazy<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rbx,[rbx+8]
       mov       rdi,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rdi,[r15+8]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M00_L00
       lea       rdi,[r15+20]
       mov       rsi,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       edi,edi
       mov       [r15+10],rdi
       mov       rdi,r15
       xor       esi,esi
       add       rsp,8
       pop       rbx
       pop       r15
       jmp       qword ptr [7C8DB41866B8]; Microsoft.VisualStudio.Threading.AsyncLazy`1[[System.Int32, System.Private.CoreLib]].GetValueAsync(System.Threading.CancellationToken)
M00_L00:
       mov       rdi,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       edi,164
       mov       rsi,7C8DB41BB4E8
       call      qword ptr [7C8DB363EF88]
       mov       rsi,rax
       mov       rdi,rbx
       call      qword ptr [7C8DB3E8DF68]
       mov       rdi,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 157
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.Int32, System.Private.CoreLib]](System.Threading.Tasks.Task`1<Int32>)
       push      rbx
       mov       rbx,rdi
       mov       edi,[rbx+34]
       and       edi,11000000
       cmp       edi,1000000
       jne       short M01_L01
M01_L00:
       mov       eax,[rbx+38]
       pop       rbx
       ret
M01_L01:
       mov       rdi,rbx
       xor       esi,esi
       call      qword ptr [7C8DB418ECE8]
       jmp       short M01_L00
; Total bytes of code 39
```
```assembly
; Microsoft.VisualStudio.Threading.AsyncLazy`1[[System.Int32, System.Private.CoreLib]].GetValueAsync(System.Threading.CancellationToken)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rbx
       sub       rsp,128
       lea       rbp,[rsp+150]
       xor       eax,eax
       mov       [rbp-0C8],rax
       vxorps    xmm8,xmm8,xmm8
       vmovdqu   ymmword ptr [rbp-0C0],ymm8
       vmovdqu   ymmword ptr [rbp-0A0],ymm8
       vmovdqu   ymmword ptr [rbp-80],ymm8
       vmovdqu   ymmword ptr [rbp-60],ymm8
       mov       [rbp-40],rax
       mov       [rbp-0B8],rdi
       mov       [rbp-30],rsi
       mov       rdi,offset MT_Microsoft.VisualStudio.Threading.AsyncLazy<System.Int32>+<>c__DisplayClass20_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0C0],rax
       lea       rdi,[rax+8]
       mov       rsi,[rbp-0B8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-0B8]
       mov       rdi,[rsi+28]
       test      rdi,rdi
       jne       near ptr M02_L56
M02_L00:
       mov       rdi,[rsi+18]
       test      rdi,rdi
       jne       near ptr M02_L57
M02_L01:
       mov       rsi,[rbp-0B8]
       cmp       qword ptr [rsi+28],0
       jne       near ptr M02_L52
       mov       rdi,[rsi+8]
       test      rdi,rdi
       je        near ptr M02_L58
       call      00007C8E318E5C00
       test      eax,eax
       jne       near ptr M02_L59
       xor       edi,edi
       mov       rax,[rbp-0C0]
       mov       [rax+10],rdi
       mov       rsi,[rbp-0B8]
       mov       rdi,[rsi+8]
       mov       [rbp-0C8],rdi
       xor       edi,edi
       mov       [rbp-34],edi
       cmp       qword ptr [rbp-0C8],0
       je        near ptr M02_L29
       mov       rdi,[rbp-0C8]
       call      00007C8E318E6020
       test      eax,eax
       je        near ptr M02_L30
M02_L02:
       mov       dword ptr [rbp-34],1
       mov       rsi,[rbp-0B8]
       cmp       qword ptr [rsi+28],0
       jne       near ptr M02_L34
       cmp       qword ptr [rbp-30],0
       je        short M02_L03
       mov       rdi,[rbp-30]
       cmp       dword ptr [rdi+20],0
       jne       near ptr M02_L31
M02_L03:
       mov       rdi,offset MT_Microsoft.VisualStudio.Threading.InlineResumable
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,[rbp-0C0]
       lea       rdi,[rcx+10]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-0B8]
       mov       rsi,[rsi+20]
       mov       rcx,[rbp-0C0]
       lea       rdi,[rcx+18]
       call      CORINFO_HELP_ASSIGN_REF
       xor       edi,edi
       mov       rsi,[rbp-0B8]
       mov       [rsi+20],rdi
       mov       rdi,offset MT_System.Func<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rdi,[rbx+8]
       mov       rsi,[rbp-0C0]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset Microsoft.VisualStudio.Threading.AsyncLazy`1+<>c__DisplayClass20_0[[System.Int32, System.Private.CoreLib]].<GetValueAsync>b__0()
       mov       [rbx+18],rdi
       mov       rsi,[rbp-0B8]
       cmp       byte ptr [rsi+38],0
       jne       near ptr M02_L18
       cmp       qword ptr [rsi+18],0
       jne       near ptr M02_L32
M02_L04:
       mov       rdi,offset MT_Microsoft.VisualStudio.Threading.AsyncLocal<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdi,offset MT_System.Threading.AsyncLocal<System.Object>
       call      CORINFO_HELP_NEWSFAST
       lea       rdi,[r15+8]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14,[r15+8]
       mov       rdi,7C7DF0801370
       mov       r13,[rdi]
       cmp       qword ptr [r14+8],0
       setne     r12b
       movzx     r12d,r12b
       mov       rdi,7C8E31CA0D68
       mov       rax,7C8E3261F820
       call      rax
       cmp       dword ptr [rax],4
       jle       near ptr M02_L33
       mov       rdi,[rax+8]
       mov       rax,[rdi+20]
       test      rax,rax
       je        near ptr M02_L33
M02_L05:
       mov       [rbp-130],rax
       mov       rcx,[rax+10]
       test      rcx,rcx
       jne       short M02_L06
       call      qword ptr [7C8DB3E8C048]; System.Threading.Thread.InitializeCurrentThread()
       mov       rcx,rax
M02_L06:
       mov       rcx,[rcx+8]
       mov       [rbp-0D0],rcx
       xor       edi,edi
       mov       [rbp-40],rdi
       xor       r8d,r8d
       test      rcx,rcx
       je        short M02_L07
       mov       rdi,[rcx+8]
       lea       rdx,[rbp-40]
       mov       rsi,r14
       mov       r11,7C8DB2650558
       call      qword ptr [r11]
       mov       [rbp-44],eax
       mov       rcx,[rbp-0D0]
       mov       r8d,[rbp-44]
M02_L07:
       cmp       [rbp-40],r13
       je        near ptr M02_L17
       xor       edi,edi
       mov       [rbp-50],rdi
       mov       [rbp-54],edi
       test      rcx,rcx
       je        short M02_L08
       mov       [rbp-44],r8d
       movzx     edx,byte ptr [rcx+18]
       mov       [rbp-54],edx
       test      r12d,r12d
       sete      cl
       movzx     ecx,cl
       mov       r10,[rbp-0D0]
       mov       rdi,[r10+8]
       mov       rsi,r14
       mov       rdx,r13
       mov       r11,7C8DB2650550
       call      qword ptr [r11]
       mov       [rbp-0D8],rax
       mov       rdx,[rbp-0D0]
       mov       rdx,[rdx+10]
       mov       [rbp-50],rdx
       jmp       short M02_L09
M02_L08:
       mov       [rbp-44],r8d
       mov       rdi,offset MT_System.Threading.AsyncLocalValueMap+OneElementAsyncLocalValueMap
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0F0],rax
       lea       rdi,[rax+8]
       mov       rsi,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-0F0]
       lea       rdi,[rax+10]
       mov       rsi,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-0F0]
       mov       [rbp-0D8],rax
M02_L09:
       test      r12d,r12d
       je        short M02_L11
       cmp       dword ptr [rbp-44],0
       jne       short M02_L11
       cmp       qword ptr [rbp-50],0
       je        short M02_L10
       mov       rdx,[rbp-50]
       mov       ecx,[rdx+8]
       mov       [rbp-58],ecx
       lea       edx,[rcx+1]
       lea       rsi,[rbp-50]
       mov       rdi,7C8DB41F4128
       call      qword ptr [7C8DB3A6C480]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       esi,[rbp-58]
       mov       rdi,[rbp-50]
       mov       rdx,r14
       call      qword ptr [7C8DB36357A0]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M02_L11
M02_L10:
       mov       rdi,offset MT_System.Threading.IAsyncLocal[]
       mov       esi,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rbp-0E8],rax
       lea       rdi,[rax+10]
       mov       rsi,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-0E8]
       mov       [rbp-50],rax
M02_L11:
       mov       rcx,[rbp-130]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       short M02_L12
       call      qword ptr [7C8DB3E8C048]; System.Threading.Thread.InitializeCurrentThread()
       mov       [rbp-0F8],rax
       mov       rcx,[rbp-0F8]
M02_L12:
       cmp       dword ptr [rbp-54],0
       je        near ptr M02_L25
       mov       [rbp-0F8],rcx
M02_L13:
       mov       rdi,offset MT_System.Threading.ExecutionContext
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       [rbp-0E0],rsi
       mov       rax,[rbp-50]
       mov       [rbp-100],rax
       lea       rdi,[rsi+8]
       mov       rsi,[rbp-0D8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-0E0]
       lea       rdi,[rsi+10]
       mov       rsi,[rbp-100]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-0E0]
       mov       edi,[rbp-54]
       mov       [rsi+18],dil
M02_L14:
       mov       rdi,[rbp-0F8]
       lea       rdi,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      r12d,r12d
       je        short M02_L17
       mov       rsi,[rbp-40]
       test      rsi,rsi
       jne       near ptr M02_L27
       xor       r12d,r12d
M02_L15:
       mov       rdi,[r14]
       mov       rdi,[rdi+30]
       mov       rdi,[rdi]
       mov       rdi,[rdi]
       mov       rax,r13
       cmp       [rax],rdi
       je        short M02_L16
       mov       rsi,r13
       call      qword ptr [7C8DB36358C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
M02_L16:
       mov       rcx,[r14+8]
       xor       edi,edi
       mov       [rsp],r12
       mov       [rsp+8],rax
       mov       [rsp+10],dil
       mov       rdi,[rcx+8]
       call      qword ptr [rcx+18]
M02_L17:
       xor       edi,edi
       mov       [rbp-40],rdi
       mov       [rbp-50],rdi
       mov       rsi,[rbp-0B8]
       lea       rdi,[rsi+18]
       mov       rsi,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-0B8]
M02_L18:
       cmp       qword ptr [rsi+10],0
       jne       short M02_L20
       mov       rdi,offset Microsoft.VisualStudio.Threading.AsyncLazy`1+<>c__DisplayClass20_0[[System.Int32, System.Private.CoreLib]].<GetValueAsync>b__0()
       cmp       [rbx+18],rdi
       jne       near ptr M02_L23
       mov       rdi,[rbx+8]
       xor       eax,eax
       mov       [rbp-68],rax
       mov       [rbp-88],rdi
       mov       dword ptr [rbp-70],0FFFFFFFF
       lea       rdi,[rbp-88]
       call      qword ptr [7C8DB4187900]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[Microsoft.VisualStudio.Threading.AsyncLazy`1+<>c__DisplayClass20_0+<<GetValueAsync>b__0>d[[System.Int32, System.Private.CoreLib]], Microsoft.VisualStudio.Threading]](<<GetValueAsync>b__0>d<Int32> ByRef)
       mov       rsi,[rbp-68]
       test      rsi,rsi
       je        near ptr M02_L22
M02_L19:
       mov       r15,[rbp-0B8]
       lea       rdi,[r15+28]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L24
M02_L20:
       mov       rsi,[rbp-0B8]
       mov       rdi,[rsi+10]
       cmp       [rdi],dil
       mov       rsi,rbx
       xor       edx,edx
       xor       ecx,ecx
       xor       r8d,r8d
       call      qword ptr [7C8DB418F1F8]
       mov       r15,[rbp-0B8]
       lea       rdi,[r15+30]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       lock or   dword ptr [rsp],0
       mov       rdi,[r15+30]
       cmp       [rdi],dil
       call      qword ptr [7C8DB418F2A0]
       mov       rsi,rax
       test      rsi,rsi
       je        short M02_L21
       mov       rdi,offset MT_System.Threading.Tasks.Task<System.Int32>
       cmp       [rsi],rdi
       je        short M02_L21
       mov       rsi,rax
       call      qword ptr [7C8DB3A64AF8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rsi,rax
M02_L21:
       lea       rdi,[r15+28]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M02_L24
M02_L22:
       lea       rdi,[rbp-68]
       call      qword ptr [7C8DB418EE20]
       mov       rsi,rax
       jmp       near ptr M02_L19
M02_L23:
       mov       rdi,[rbx+8]
       call      qword ptr [rbx+18]
       mov       rsi,rax
       jmp       near ptr M02_L19
M02_L24:
       call      M02_L66
       jmp       near ptr M02_L34
M02_L25:
       mov       rdi,7C7DF08013A8
       mov       rax,[rbp-0D8]
       cmp       rax,[rdi]
       jne       short M02_L26
       xor       esi,esi
       mov       [rbp-0F8],rcx
       jmp       near ptr M02_L14
M02_L26:
       mov       [rbp-0F8],rcx
       jmp       near ptr M02_L13
M02_L27:
       mov       rdi,[r14]
       mov       rdi,[rdi+30]
       mov       rdi,[rdi]
       mov       rdi,[rdi]
       mov       r12,rsi
       cmp       [r12],rdi
       je        short M02_L28
       call      qword ptr [7C8DB36358C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r12,rax
M02_L28:
       jmp       near ptr M02_L15
M02_L29:
       xor       edi,edi
       call      qword ptr [7C8DB418EE50]
       int       3
M02_L30:
       mov       rdi,[rbp-0C8]
       call      qword ptr [7C8DB418EFB8]
       jmp       near ptr M02_L02
M02_L31:
       lea       rdi,[rbp-30]
       call      qword ptr [7C8DB418EFD0]
       int       3
M02_L32:
       mov       rdi,7C8DB420F000
       call      qword ptr [7C8DB4186AF0]
       jmp       near ptr M02_L04
M02_L33:
       mov       edi,4
       call      qword ptr [7C8DB418ECA0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M02_L05
M02_L34:
       mov       rdi,[rbp-0C8]
       call      00007C8E318E6790
       test      eax,eax
       jne       near ptr M02_L60
M02_L35:
       mov       rsi,[rbp-0C0]
       mov       rdi,[rsi+10]
       test      rdi,rdi
       je        near ptr M02_L52
       mov       byte ptr [rdi+18],1
       mov       rbx,[rdi+8]
       xor       eax,eax
       mov       [rdi+8],rax
       mov       r15,[rdi+10]
       mov       rdi,7C8E31CA0D68
       mov       rax,7C8E3261F820
       call      rax
       cmp       dword ptr [rax],4
       jle       near ptr M02_L61
       mov       rdi,[rax+8]
       mov       r13,[rdi+20]
       test      r13,r13
       je        near ptr M02_L61
M02_L36:
       mov       rax,[r13+10]
       test      rax,rax
       jne       short M02_L37
       call      qword ptr [7C8DB3E8C048]; System.Threading.Thread.InitializeCurrentThread()
M02_L37:
       mov       r14,[rax+10]
       mov       rax,[r13+10]
       test      rax,rax
       jne       short M02_L38
       call      qword ptr [7C8DB3E8C048]; System.Threading.Thread.InitializeCurrentThread()
M02_L38:
       lea       rdi,[rax+10]
       mov       rsi,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-128],r14
       test      rbx,rbx
       je        near ptr M02_L50
       mov       rdi,offset System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1+AsyncStateMachineBox`1[[System.Int32, System.Private.CoreLib],[Microsoft.VisualStudio.Threading.AsyncLazy`1+<>c__DisplayClass20_0+<<GetValueAsync>b__0>d[[System.Int32, System.Private.CoreLib]], Microsoft.VisualStudio.Threading]].MoveNext()
       cmp       [rbx+18],rdi
       jne       near ptr M02_L49
       mov       rbx,[rbx+8]
       mov       rdi,7C7DF08013A0
       mov       r15,[rdi]
       movzx     r12d,byte ptr [r15+9D]
       test      r12d,r12d
       jne       near ptr M02_L45
M02_L39:
       mov       rdi,[rbx+10]
       test      rdi,rdi
       je        near ptr M02_L44
       mov       rsi,7C7DF08013B0
       mov       rsi,[rsi]
       mov       rdx,rbx
       call      qword ptr [7C8DB418C198]; System.Threading.ExecutionContext.RunInternal(System.Threading.ExecutionContext, System.Threading.ContextCallback, System.Object)
M02_L40:
       mov       edi,[rbx+34]
       test      edi,1600000
       je        short M02_L43
       cmp       byte ptr [7C8DB264B06C],0
       jne       near ptr M02_L46
M02_L41:
       xor       edi,edi
       mov       [rbx+40],rdi
       mov       [rbx+48],rdi
       mov       [rbx+50],rdi
       mov       [rbx+58],rdi
       mov       [rbx+60],rdi
       mov       [rbx+68],rdi
       mov       [rbx+10],rdi
       mov       rdi,r15
       cmp       byte ptr [rdi+9D],0
       je        short M02_L43
       movzx     eax,byte ptr [rdi+9D]
       mov       ecx,[rdi+98]
       mov       rdi,[rdi+80]
       test      eax,eax
       je        short M02_L43
       test      ecx,ecx
       je        short M02_L42
       cmp       ecx,3
       jl        short M02_L43
M02_L42:
       test      rdi,rdi
       je        short M02_L47
       test      edi,100
       jne       short M02_L47
M02_L43:
       test      r12d,r12d
       je        short M02_L50
       jmp       short M02_L48
M02_L44:
       lea       rdi,[rbx+40]
       call      qword ptr [7C8DB4187960]; Microsoft.VisualStudio.Threading.AsyncLazy`1+<>c__DisplayClass20_0+<<GetValueAsync>b__0>d[[System.Int32, System.Private.CoreLib]].MoveNext()
       jmp       near ptr M02_L40
M02_L45:
       mov       rdi,rbx
       call      qword ptr [7C8DB418C168]
       mov       esi,eax
       mov       rdi,r15
       mov       edx,2
       call      qword ptr [7C8DB418C180]
       jmp       near ptr M02_L39
M02_L46:
       mov       rdi,rbx
       call      qword ptr [7C8DB418C390]
       jmp       near ptr M02_L41
M02_L47:
       mov       rdi,rbx
       call      qword ptr [7C8DB3E86880]; System.GC.SuppressFinalize(System.Object)
       jmp       short M02_L43
M02_L48:
       mov       rdi,r15
       mov       esi,2
       call      qword ptr [7C8DB418C1E0]
       jmp       short M02_L50
M02_L49:
       mov       rdi,[rbx+8]
       call      qword ptr [rbx+18]
       nop
M02_L50:
       mov       rax,[r13+10]
       test      rax,rax
       jne       short M02_L51
       call      qword ptr [7C8DB3E8C048]; System.Threading.Thread.InitializeCurrentThread()
M02_L51:
       lea       rdi,[rax+10]
       mov       rsi,r14
       call      CORINFO_HELP_ASSIGN_REF
M02_L52:
       mov       rsi,[rbp-0B8]
       lock or   dword ptr [rsp],0
       mov       rdi,[rsi+30]
       test      rdi,rdi
       jne       near ptr M02_L62
       xor       eax,eax
M02_L53:
       test      rax,rax
       jne       short M02_L55
       mov       rsi,[rbp-0B8]
       mov       rbx,[rsi+28]
       mov       rdi,[rbp-30]
       mov       [rbp-0B0],rdi
       test      rbx,rbx
       je        near ptr M02_L63
       cmp       qword ptr [rbp-0B0],0
       jne       near ptr M02_L64
M02_L54:
       mov       rax,rbx
M02_L55:
       add       rsp,128
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L56:
       test      dword ptr [rdi+34],1600000
       jne       near ptr M02_L01
       jmp       near ptr M02_L00
M02_L57:
       mov       rdi,[rdi+8]
       cmp       [rdi],edi
       call      qword ptr [7C8DB418F270]
       test      rax,rax
       je        near ptr M02_L01
       call      qword ptr [7C8DB418F288]
       mov       rdi,rax
       mov       rdx,7C7DF0801428
       mov       rdx,[rdx]
       mov       rsi,7C8DB020A7B0
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rdi,rax
       xor       eax,eax
       test      rdi,rdi
       cmove     rdi,rax
       call      qword ptr [7C8DB41869D0]
       int       3
M02_L58:
       mov       edi,94D
       mov       rsi,7C8DB2644000
       call      qword ptr [7C8DB363EF88]
       mov       rdi,rax
       call      qword ptr [7C8DB418EE50]
       int       3
M02_L59:
       call      qword ptr [7C8DB418F288]
       mov       rdi,rax
       mov       rdx,7C7DF0801428
       mov       rdx,[rdx]
       mov       rsi,7C8DB020A7B0
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rdi,rax
       xor       eax,eax
       test      rdi,rdi
       cmove     rdi,rax
       call      qword ptr [7C8DB41869D0]
       int       3
M02_L60:
       mov       edi,eax
       mov       rsi,[rbp-0C8]
       call      qword ptr [7C8DB418EE68]
       jmp       near ptr M02_L35
M02_L61:
       mov       edi,4
       call      qword ptr [7C8DB418ECA0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r13,rax
       jmp       near ptr M02_L36
M02_L62:
       mov       rdx,[rbp-30]
       xor       esi,esi
       call      qword ptr [7C8DB4186AC0]
       jmp       near ptr M02_L53
M02_L63:
       mov       rdi,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       edi,170F
       mov       rsi,7C8DB41BB4E8
       call      qword ptr [7C8DB363EF88]
       mov       rsi,rax
       mov       rdi,rbx
       call      qword ptr [7C8DB3E8DF68]
       mov       rdi,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L64:
       test      dword ptr [rbx+34],1600000
       jne       near ptr M02_L54
       lea       rdi,[rbp-0B0]
       call      qword ptr [7C8DB418C438]
       test      eax,eax
       je        short M02_L65
       mov       rdi,[rbp-0B0]
       call      qword ptr [7C8DB418C3F0]
       jmp       near ptr M02_L55
M02_L65:
       mov       rdi,rbx
       mov       rsi,[rbp-0B0]
       call      qword ptr [7C8DB418C3C0]
       jmp       near ptr M02_L55
M02_L66:
       sub       rsp,18
       mov       r15,[rbp-0B8]
       mov       rdi,[r15+18]
       test      rdi,rdi
       je        near ptr M02_L85
       mov       rbx,[rdi+8]
       cmp       qword ptr [rbx+8],0
       setne     r14b
       movzx     r14d,r14b
       mov       rdi,7C8E31CA0D68
       mov       rax,7C8E3261F820
       call      rax
       cmp       dword ptr [rax],4
       jle       short M02_L67
       mov       rdi,[rax+8]
       mov       rcx,[rdi+20]
       test      rcx,rcx
       jne       short M02_L68
M02_L67:
       mov       edi,4
       call      qword ptr [7C8DB418ECA0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rcx,rax
M02_L68:
       mov       r13,rcx
       mov       rax,[r13+10]
       test      rax,rax
       jne       short M02_L69
       call      qword ptr [7C8DB3E8C048]; System.Threading.Thread.InitializeCurrentThread()
M02_L69:
       mov       r12,[rax+8]
       xor       edi,edi
       mov       [rbp-90],rdi
       xor       eax,eax
       test      r12,r12
       je        short M02_L70
       mov       rdi,[r12+8]
       lea       rdx,[rbp-90]
       mov       rsi,rbx
       mov       r11,7C8DB2650570
       call      qword ptr [r11]
       mov       [rbp-94],eax
       mov       eax,[rbp-94]
M02_L70:
       cmp       qword ptr [rbp-90],0
       je        near ptr M02_L84
       xor       edi,edi
       mov       [rbp-0A0],rdi
       mov       [rbp-0A4],edi
       test      r12,r12
       je        short M02_L71
       mov       [rbp-94],eax
       movzx     ecx,byte ptr [r12+18]
       mov       [rbp-0A4],ecx
       test      r14d,r14d
       sete      cl
       movzx     ecx,cl
       mov       rdi,[r12+8]
       mov       rsi,rbx
       mov       r11,7C8DB2650568
       xor       edx,edx
       call      qword ptr [r11]
       mov       [rbp-108],rax
       mov       rdx,[r12+10]
       mov       [rbp-0A0],rdx
       jmp       short M02_L74
M02_L71:
       test      r14d,r14d
       jne       short M02_L72
       mov       rdi,7C7DF08013A8
       mov       r12,[rdi]
       jmp       short M02_L73
M02_L72:
       mov       [rbp-94],eax
       mov       rdi,offset MT_System.Threading.AsyncLocalValueMap+OneElementAsyncLocalValueMap
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rsi,rbx
       mov       rdi,7C8DB42054D8
       xor       edx,edx
       call      qword ptr [7C8DB418ED60]
       mov       [rbp-120],rdx
       lea       rdi,[r12+8]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdi,[r12+10]
       mov       rsi,[rbp-120]
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,[rbp-94]
M02_L73:
       mov       [rbp-94],eax
       mov       [rbp-108],r12
M02_L74:
       test      r14d,r14d
       je        short M02_L76
       cmp       dword ptr [rbp-94],0
       jne       short M02_L76
       cmp       qword ptr [rbp-0A0],0
       jne       short M02_L75
       mov       rdi,offset MT_System.Threading.IAsyncLocal[]
       mov       esi,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r12,rax
       lea       rdi,[r12+10]
       mov       rsi,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-0A0],r12
       jmp       short M02_L76
M02_L75:
       mov       rdx,[rbp-0A0]
       mov       r12d,[rdx+8]
       lea       edx,[r12+1]
       lea       rsi,[rbp-0A0]
       mov       rdi,7C8DB41F4128
       call      qword ptr [7C8DB3A6C480]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       esi,r12d
       mov       rdi,[rbp-0A0]
       mov       rdx,rbx
       call      qword ptr [7C8DB36357A0]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M02_L76:
       mov       r13,[r13+10]
       test      r13,r13
       jne       short M02_L77
       call      qword ptr [7C8DB3E8C048]; System.Threading.Thread.InitializeCurrentThread()
       mov       r13,rax
M02_L77:
       mov       r12d,[rbp-0A4]
       test      r12d,r12d
       jne       short M02_L78
       mov       rdi,7C7DF08013A8
       mov       rax,[rbp-108]
       cmp       rax,[rdi]
       je        short M02_L79
M02_L78:
       mov       rdi,offset MT_System.Threading.ExecutionContext
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       [rbp-110],rsi
       mov       rax,[rbp-0A0]
       mov       [rbp-118],rax
       lea       rdi,[rsi+8]
       mov       rsi,[rbp-108]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-110]
       lea       rdi,[rsi+10]
       mov       rsi,[rbp-118]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-110]
       mov       [rsi+18],r12b
       jmp       short M02_L80
M02_L79:
       xor       esi,esi
M02_L80:
       lea       rdi,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      r14d,r14d
       je        short M02_L84
       mov       rsi,[rbp-90]
       test      rsi,rsi
       je        short M02_L82
       mov       rdi,[rbx]
       mov       rdi,[rdi+30]
       mov       rdi,[rdi]
       mov       rdi,[rdi]
       mov       r14,rsi
       cmp       [r14],rdi
       je        short M02_L81
       call      qword ptr [7C8DB36358C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r14,rax
M02_L81:
       jmp       short M02_L83
M02_L82:
       xor       r14d,r14d
M02_L83:
       mov       rax,[rbx+8]
       xor       edi,edi
       xor       ecx,ecx
       mov       [rsp],r14
       mov       [rsp+8],rdi
       mov       [rsp+10],cl
       mov       rdi,[rax+8]
       call      qword ptr [rax+18]
M02_L84:
       xor       edi,edi
       mov       [rbp-90],rdi
       mov       [rbp-0A0],rdi
M02_L85:
       add       rsp,18
       ret
       sub       rsp,18
       cmp       dword ptr [rbp-34],0
       je        short M02_L87
       cmp       qword ptr [rbp-0C8],0
       jne       short M02_L86
       xor       edi,edi
       call      qword ptr [7C8DB418EE50]
       int       3
M02_L86:
       mov       rdi,[rbp-0C8]
       call      00007C8E318E6790
       test      eax,eax
       je        short M02_L87
       mov       edi,eax
       mov       rsi,[rbp-0C8]
       call      qword ptr [7C8DB418EE68]
M02_L87:
       nop
       add       rsp,18
       ret
       sub       rsp,18
       mov       rdi,7C8E31CA0D68
       mov       rax,7C8E3261F820
       call      rax
       cmp       dword ptr [rax],4
       jle       short M02_L88
       mov       rdi,[rax+8]
       mov       r13,[rdi+20]
       test      r13,r13
       jne       short M02_L89
M02_L88:
       mov       edi,4
       call      qword ptr [7C8DB418ECA0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r13,rax
M02_L89:
       mov       r14,[r13+10]
       test      r14,r14
       jne       short M02_L90
       call      qword ptr [7C8DB3E8C048]; System.Threading.Thread.InitializeCurrentThread()
       mov       r14,rax
M02_L90:
       lea       rdi,[r14+10]
       mov       rsi,[rbp-128]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,18
       ret
; Total bytes of code 3562
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.Int32, System.Private.CoreLib]].LazyOfTask()
       push      rbp
       push      r15
       push      rbx
       lea       rbp,[rsp+10]
       mov       rbx,rdi
       mov       rdi,offset MT_System.Lazy<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M00_L00
       lea       rdi,[r15+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset MT_System.LazyHelper
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+10],8
       lea       rdi,[r15+8]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [r15+8],0
       je        short M00_L01
       mov       rdi,r15
       pop       rbx
       pop       r15
       pop       rbp
       jmp       qword ptr [764FC129C438]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
M00_L00:
       mov       edi,1817
       mov       rsi,764FBFA54000
       call      qword ptr [764FC0A4EF88]
       mov       rdi,rax
       call      qword ptr [764FC159E748]
       int       3
M00_L01:
       mov       rax,[r15+18]
       pop       rbx
       pop       r15
       pop       rbp
       ret
; Total bytes of code 142
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.Int32, System.Private.CoreLib]](System.Threading.Tasks.Task`1<Int32>)
       push      rbx
       mov       rbx,rdi
       mov       edi,[rbx+34]
       and       edi,11000000
       cmp       edi,1000000
       jne       short M01_L01
M01_L00:
       mov       eax,[rbx+38]
       pop       rbx
       ret
M01_L01:
       mov       rdi,rbx
       xor       esi,esi
       call      qword ptr [764FC1597618]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 39
```
```assembly
; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
M02_L00:
       push      rbp
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp-10],rdi
       mov       [rbp-20],rdi
M02_L01:
       mov       rbx,[rdi+8]
       test      rbx,rbx
       je        short M02_L04
       mov       eax,[rbx+10]
       cmp       eax,8
       jne       short M02_L05
       mov       [rbp-28],rbx
       xor       eax,eax
       mov       [rbp-14],eax
       mov       rdi,rbx
       call      000076503ECE6020
       test      eax,eax
       jne       short M02_L02
       mov       rdi,rbx
       call      qword ptr [764FC159C720]; System.Threading.Monitor.Enter_Slowpath(System.Object)
M02_L02:
       mov       dword ptr [rbp-14],1
       mov       rdi,[rbp-20]
       cmp       [rdi+8],rbx
       jne       short M02_L03
       mov       esi,2
       call      qword ptr [764FC129C468]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       nop
M02_L03:
       mov       rdi,rbx
       call      000076503ECE6790
       test      eax,eax
       jne       near ptr M02_L11
M02_L04:
       mov       rdi,[rbp-20]
       cmp       qword ptr [rdi+8],0
       je        near ptr M02_L12
       add       rsp,28
       pop       rbx
       pop       rbp
       jmp       qword ptr [764FC129C438]
M02_L05:
       cmp       eax,8
       ja        short M02_L06
       mov       eax,eax
       lea       rcx,[764FC0AC39C8]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M02_L01]
       add       rcx,rdx
       jmp       rcx
M02_L06:
       mov       rdi,[rbx+8]
       cmp       [rdi],edi
       call      qword ptr [764FC159E8E0]
       int       3
       mov       rdi,[rbp-20]
       call      qword ptr [764FC159ECB8]
       jmp       short M02_L04
       mov       rdi,[rbp-20]
       xor       esi,esi
       call      qword ptr [764FC129C468]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M02_L04
       mov       rdi,[rbp-20]
       mov       rsi,[rdi]
       mov       rax,[rsi+30]
       mov       rax,[rax]
       mov       rax,[rax+10]
       test      rax,rax
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rdi,rsi
       mov       rsi,764FC1612110
       call      qword ptr [764FC0A4F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L08:
       mov       rdi,[rax+30]
       mov       rdi,[rdi]
       mov       rdi,[rdi+18]
       test      rdi,rdi
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rdi,rax
       mov       rsi,764FC16121B0
       call      qword ptr [764FC0A4F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M02_L10:
       call      qword ptr [764FC159EC58]
       mov       rdx,rax
       mov       rsi,rbx
       mov       rdi,[rbp-20]
       call      qword ptr [764FC159ECD0]
       jmp       near ptr M02_L04
       mov       rdi,[rbp-20]
       mov       rsi,rbx
       call      qword ptr [764FC159ECE8]
       jmp       near ptr M02_L04
       mov       rdi,[rbp-20]
       call      qword ptr [764FC159ED00]
       jmp       near ptr M02_L04
       mov       rdi,[rbp-20]
       mov       rsi,rbx
       mov       edx,1
       call      qword ptr [764FC129C450]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M02_L04
M02_L11:
       mov       edi,eax
       mov       rsi,rbx
       call      qword ptr [764FC159E760]
       jmp       near ptr M02_L04
M02_L12:
       mov       rax,[rdi+18]
       add       rsp,28
       pop       rbx
       pop       rbp
       ret
       push      rax
       cmp       dword ptr [rbp-14],0
       je        short M02_L13
       mov       rdi,[rbp-28]
       call      000076503ECE6790
       test      eax,eax
       je        short M02_L13
       mov       edi,eax
       mov       rsi,[rbp-28]
       call      qword ptr [764FC159E760]
M02_L13:
       nop
       add       rsp,8
       ret
; Total bytes of code 438
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rbp
       push      r15
       push      rbx
       lea       rbp,[rsp+10]
       mov       rbx,rdi
       mov       r15d,esi
       test      dword ptr [rbx+34],1600000
       jne       short M03_L00
       mov       rdi,rbx
       mov       esi,0FFFFFFFF
       xor       edx,edx
       call      qword ptr [764FC1597630]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M03_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M03_L03
M03_L01:
       mov       edi,[rbx+34]
       and       edi,1600000
       cmp       edi,1000000
       jne       short M03_L04
M03_L02:
       pop       rbx
       pop       r15
       pop       rbp
       ret
M03_L03:
       mov       rdi,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M03_L01
       mov       rdi,rbx
       call      qword ptr [764FC159EBF8]
       jmp       short M03_L01
M03_L04:
       test      r15b,2
       jne       short M03_L05
       mov       rdi,rbx
       call      qword ptr [764FC159E8B0]
M03_L05:
       mov       rdi,rbx
       call      qword ptr [764FC159EF70]
       jmp       short M03_L02
; Total bytes of code 125
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.Int32, System.Private.CoreLib]].LazyOfTask_TaskRun()
       push      rbp
       push      r15
       push      rbx
       lea       rbp,[rsp+10]
       mov       rbx,rdi
       mov       rdi,offset MT_System.Lazy<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rsi,[rbx+10]
       test      rsi,rsi
       je        short M00_L00
       lea       rdi,[r15+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset MT_System.LazyHelper
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+10],8
       lea       rdi,[r15+8]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [r15+8],0
       je        short M00_L01
       mov       rdi,r15
       pop       rbx
       pop       r15
       pop       rbp
       jmp       qword ptr [7D0C11A8C438]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
M00_L00:
       mov       edi,1817
       mov       rsi,7D0C10244000
       call      qword ptr [7D0C1123EF88]
       mov       rdi,rax
       call      qword ptr [7D0C11D8F0A8]
       int       3
M00_L01:
       mov       rax,[r15+18]
       pop       rbx
       pop       r15
       pop       rbp
       ret
; Total bytes of code 142
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.Int32, System.Private.CoreLib]](System.Threading.Tasks.Task`1<Int32>)
       push      rbx
       mov       rbx,rdi
       mov       edi,[rbx+34]
       and       edi,11000000
       cmp       edi,1000000
       jne       short M01_L01
M01_L00:
       mov       eax,[rbx+38]
       pop       rbx
       ret
M01_L01:
       mov       rdi,rbx
       xor       esi,esi
       call      qword ptr [7D0C11D874F8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 39
```
```assembly
; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
M02_L00:
       push      rbp
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp-10],rdi
       mov       [rbp-20],rdi
M02_L01:
       mov       rbx,[rdi+8]
       test      rbx,rbx
       je        short M02_L04
       mov       eax,[rbx+10]
       cmp       eax,8
       jne       short M02_L05
       mov       [rbp-28],rbx
       xor       eax,eax
       mov       [rbp-14],eax
       mov       rdi,rbx
       call      00007D0C8F4E6020
       test      eax,eax
       jne       short M02_L02
       mov       rdi,rbx
       call      qword ptr [7D0C11D8CC90]; System.Threading.Monitor.Enter_Slowpath(System.Object)
M02_L02:
       mov       dword ptr [rbp-14],1
       mov       rdi,[rbp-20]
       cmp       [rdi+8],rbx
       jne       short M02_L03
       mov       esi,2
       call      qword ptr [7D0C11A8C468]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       nop
M02_L03:
       mov       rdi,rbx
       call      00007D0C8F4E6790
       test      eax,eax
       jne       near ptr M02_L11
M02_L04:
       mov       rdi,[rbp-20]
       cmp       qword ptr [rdi+8],0
       je        near ptr M02_L12
       add       rsp,28
       pop       rbx
       pop       rbp
       jmp       qword ptr [7D0C11A8C438]
M02_L05:
       cmp       eax,8
       ja        short M02_L06
       mov       eax,eax
       lea       rcx,[7D0C112B9188]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M02_L01]
       add       rcx,rdx
       jmp       rcx
M02_L06:
       mov       rdi,[rbx+8]
       cmp       [rdi],edi
       call      qword ptr [7D0C11D8EFA0]
       int       3
       mov       rdi,[rbp-20]
       call      qword ptr [7D0C11D8F2A0]
       jmp       short M02_L04
       mov       rdi,[rbp-20]
       xor       esi,esi
       call      qword ptr [7D0C11A8C468]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M02_L04
       mov       rdi,[rbp-20]
       mov       rsi,[rdi]
       mov       rax,[rsi+30]
       mov       rax,[rax]
       mov       rax,[rax+10]
       test      rax,rax
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rdi,rsi
       mov       rsi,7D0C11E03EE8
       call      qword ptr [7D0C1123F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L08:
       mov       rdi,[rax+30]
       mov       rdi,[rdi]
       mov       rdi,[rdi+18]
       test      rdi,rdi
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rdi,rax
       mov       rsi,7D0C11E03F88
       call      qword ptr [7D0C1123F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M02_L10:
       call      qword ptr [7D0C11D8F240]
       mov       rdx,rax
       mov       rsi,rbx
       mov       rdi,[rbp-20]
       call      qword ptr [7D0C11D8F2B8]
       jmp       near ptr M02_L04
       mov       rdi,[rbp-20]
       mov       rsi,rbx
       call      qword ptr [7D0C11D8F2D0]
       jmp       near ptr M02_L04
       mov       rdi,[rbp-20]
       call      qword ptr [7D0C11D8F2E8]
       jmp       near ptr M02_L04
       mov       rdi,[rbp-20]
       mov       rsi,rbx
       mov       edx,1
       call      qword ptr [7D0C11A8C450]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M02_L04
M02_L11:
       mov       edi,eax
       mov       rsi,rbx
       call      qword ptr [7D0C11D8F0C0]
       jmp       near ptr M02_L04
M02_L12:
       mov       rax,[rdi+18]
       add       rsp,28
       pop       rbx
       pop       rbp
       ret
       push      rax
       cmp       dword ptr [rbp-14],0
       je        short M02_L13
       mov       rdi,[rbp-28]
       call      00007D0C8F4E6790
       test      eax,eax
       je        short M02_L13
       mov       edi,eax
       mov       rsi,[rbp-28]
       call      qword ptr [7D0C11D8F0C0]
M02_L13:
       nop
       add       rsp,8
       ret
; Total bytes of code 438
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rbp
       push      r15
       push      rbx
       lea       rbp,[rsp+10]
       mov       rbx,rdi
       mov       r15d,esi
       test      dword ptr [rbx+34],1600000
       jne       short M03_L00
       mov       rdi,rbx
       mov       esi,0FFFFFFFF
       xor       edx,edx
       call      qword ptr [7D0C11D87510]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M03_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M03_L03
M03_L01:
       mov       edi,[rbx+34]
       and       edi,1600000
       cmp       edi,1000000
       jne       short M03_L04
M03_L02:
       pop       rbx
       pop       r15
       pop       rbp
       ret
M03_L03:
       mov       rdi,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M03_L01
       mov       rdi,rbx
       call      qword ptr [7D0C11D8F210]
       jmp       short M03_L01
M03_L04:
       test      r15b,2
       jne       short M03_L05
       mov       rdi,rbx
       call      qword ptr [7D0C11D8F6D8]
M03_L05:
       mov       rdi,rbx
       call      qword ptr [7D0C11D8FCC0]
       jmp       short M03_L02
; Total bytes of code 125
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.Int32, System.Private.CoreLib]].AsyncLazy()
       push      rbp
       push      r15
       push      rbx
       lea       rbp,[rsp+10]
       mov       rbx,rdi
       mov       rdi,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M00_L00
       lea       rdi,[r15+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[r15+10]
       test      rax,rax
       jne       short M00_L01
       mov       rdi,r15
       xor       esi,esi
       pop       rbx
       pop       r15
       pop       rbp
       jmp       qword ptr [7351561966A0]; System.Threading.Tasks.AsyncLazy`1[[System.Int32, System.Private.CoreLib]].GetOrStartAttemptAsync(System.Threading.CancellationToken)
M00_L00:
       mov       edi,1
       mov       rsi,7351561CB4D0
       call      qword ptr [73515564EF88]
       mov       rdi,rax
       call      qword ptr [73515619F828]
       int       3
M00_L01:
       pop       rbx
       pop       r15
       pop       rbp
       ret
; Total bytes of code 108
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.Int32, System.Private.CoreLib]](System.Threading.Tasks.Task`1<Int32>)
       push      rbx
       mov       rbx,rdi
       mov       edi,[rbx+34]
       and       edi,11000000
       cmp       edi,1000000
       jne       short M01_L01
M01_L00:
       mov       eax,[rbx+38]
       pop       rbx
       ret
M01_L01:
       mov       rdi,rbx
       xor       esi,esi
       call      qword ptr [7351561973F0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 39
```
```assembly
; System.Threading.Tasks.AsyncLazy`1[[System.Int32, System.Private.CoreLib]].GetOrStartAttemptAsync(System.Threading.CancellationToken)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rbx
       push      rax
       lea       rbp,[rsp+30]
       mov       rbx,rdi
       mov       r15,rsi
M02_L00:
       mov       r14,[rbx+8]
       mov       rsi,r14
       mov       rdi,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M02_L19
       test      r14,r14
       je        short M02_L01
       mov       rdi,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt
       cmp       [r14],rdi
       je        near ptr M02_L11
M02_L01:
       lea       rdi,[rbx+20]
       cmp       qword ptr [rdi],0
       jne       near ptr M02_L18
M02_L02:
       mov       rdi,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdi,offset MT_System.Threading.Tasks.TaskCompletionSource<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdi,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       xor       edi,edi
       mov       [rax+8],rdi
       mov       [rax+10],rdi
       mov       [rax+18],rdi
       mov       dword ptr [rax+34],2000440
       lea       rdi,[r14+8]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdi,[r13+10]
       mov       rsi,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdi,[r13+8]
       mov       rsi,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdi,[rbx+8]
       test      rdi,rdi
       je        near ptr M02_L21
       mov       rsi,r13
       xor       edx,edx
       call      00007351D3A74060
       test      rax,rax
       jne       near ptr M02_L00
       mov       rdi,734190801378
       mov       rbx,[rdi]
       test      rbx,rbx
       je        near ptr M02_L22
M02_L03:
       mov       rdi,7351D3CA0D68
       mov       rax,7351D4547820
       call      rax
       cmp       dword ptr [rax],4
       jle       near ptr M02_L23
       mov       rdi,[rax+8]
       mov       rax,[rdi+20]
       test      rax,rax
       je        near ptr M02_L23
M02_L04:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M02_L05
       call      qword ptr [735155E9C048]; System.Threading.Thread.InitializeCurrentThread()
M02_L05:
       mov       r14,[rax+8]
       test      r14,r14
       je        near ptr M02_L13
       xor       edi,edi
       cmp       byte ptr [r14+18],0
       cmovne    r14,rdi
M02_L06:
       test      r14,r14
       je        short M02_L07
       cmp       byte ptr [r14+19],0
       je        near ptr M02_L24
M02_L07:
       mov       rdi,offset MT_System.Threading.QueueUserWorkItemCallbackDefaultContext<System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rdi,[r12+8]
       mov       rsi,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdi,[r12+10]
       mov       rsi,r13
       call      CORINFO_HELP_ASSIGN_REF
M02_L08:
       mov       rdi,734190801390
       mov       rbx,[rdi]
       cmp       byte ptr [rbx+38],0
       jne       near ptr M02_L25
M02_L09:
       mov       rdi,[rbx+8]
       mov       rsi,[rdi+10]
       mov       rcx,[rsi+8]
M02_L10:
       mov       r14d,[rsi+0A0]
       mov       eax,r14d
       and       eax,[rsi+18]
       cmp       eax,[rcx+8]
       jae       near ptr M02_L28
       shl       rax,4
       lea       rdx,[rcx+rax+10]
       mov       eax,[rdx+8]
       sub       eax,r14d
       jne       near ptr M02_L14
       lea       r8,[rsi+0A0]
       lea       r9d,[r14+1]
       mov       eax,r14d
       lock cmpxchg [r8],r9d
       cmp       eax,r14d
       jne       short M02_L10
       mov       rax,rdx
       mov       [rbp-30],rax
       mov       rdi,rax
       mov       rsi,r12
       call      CORINFO_HELP_ASSIGN_REF
       inc       r14d
       mov       r12,[rbp-30]
       mov       [r12+8],r14d
       jmp       near ptr M02_L15
M02_L11:
       mov       rdi,r14
       call      qword ptr [735156196760]
       test      eax,eax
       je        short M02_L12
       mov       rdi,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdi,r14
       mov       rsi,735150A09F28
       call      qword ptr [735155E95260]
       mov       rdi,r14
       add       rsp,8
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [735156196718]
M02_L12:
       mov       rdi,r14
       mov       rsi,r15
       add       rsp,8
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [735156196778]; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.Int32, System.Private.CoreLib]].WaitAsync(System.Threading.CancellationToken)
M02_L13:
       mov       rdi,734190801380
       mov       r14,[rdi]
       jmp       near ptr M02_L06
M02_L14:
       test      eax,eax
       jge       near ptr M02_L10
       mov       rsi,r12
       call      qword ptr [73515619F3F0]
M02_L15:
       add       rbx,78
       mov       edi,1
       xchg      edi,[rbx]
       test      edi,edi
       jne       short M02_L16
       mov       rdi,7341908013B8
       mov       rbx,[rdi]
       lea       rdi,[rbx+160]
       lock inc  dword ptr [rdi]
       mov       rdi,rbx
       call      qword ptr [735156196C10]; System.Threading.PortableThreadPool+WorkerThread.MaybeAddWorkingWorker(System.Threading.PortableThreadPool)
       cmp       dword ptr [rbx+164],6
       jne       near ptr M02_L26
M02_L16:
       test      r15,r15
       jne       near ptr M02_L27
       mov       rdi,[r13+10]
       mov       rax,[rdi+8]
M02_L17:
       add       rsp,8
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L18:
       mov       rdi,[rdi]
       cmp       dword ptr [rdi+20],0
       je        near ptr M02_L02
       jmp       short M02_L20
M02_L19:
       jmp       short M02_L17
M02_L20:
       mov       rdi,[rbx+20]
       add       rsp,8
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [735156196658]
M02_L21:
       call      qword ptr [73515619F348]
       int       3
M02_L22:
       mov       rdi,offset MT_System.Action<System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdi,734190801370
       mov       rsi,[rdi]
       lea       rdi,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset System.Threading.Tasks.AsyncLazy`1+<>c[[System.Int32, System.Private.CoreLib]].<GetOrStartAttemptAsync>b__11_0(Attempt<Int32>)
       mov       [rbx+18],rdi
       mov       rdi,734190801378
       mov       rsi,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L03
M02_L23:
       mov       edi,4
       call      qword ptr [73515619F210]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M02_L04
M02_L24:
       mov       rdi,offset MT_System.Threading.QueueUserWorkItemCallback<System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rdi,r12
       mov       rsi,rbx
       mov       rdx,r13
       mov       rcx,r14
       call      qword ptr [73515619F8E8]
       jmp       near ptr M02_L08
M02_L25:
       mov       rdi,7341908013A8
       mov       rdi,[rdi]
       cmp       byte ptr [rdi+9D],0
       je        near ptr M02_L09
       mov       rdi,7341908013A8
       mov       rdi,[rdi]
       mov       rsi,r12
       call      qword ptr [73515619F3D8]
       jmp       near ptr M02_L09
M02_L26:
       mov       rdi,rbx
       call      qword ptr [735156196E80]; System.Threading.PortableThreadPool+GateThread.EnsureRunningSlow(System.Threading.PortableThreadPool)
       jmp       near ptr M02_L16
M02_L27:
       mov       rdi,[r13+10]
       mov       rbx,[rdi+8]
       cmp       [rbx],bl
       mov       rdi,offset MT_System.TimeProvider
       call      qword ptr [735155645728]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,734190801510
       mov       rdx,[rdx]
       mov       rcx,r15
       mov       rdi,rbx
       mov       esi,0FFFFFFFF
       add       rsp,8
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [73515619FF30]
M02_L28:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1088
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rbp
       push      r15
       push      rbx
       lea       rbp,[rsp+10]
       mov       rbx,rdi
       mov       r15d,esi
       test      dword ptr [rbx+34],1600000
       jne       short M03_L00
       mov       rdi,rbx
       mov       esi,0FFFFFFFF
       xor       edx,edx
       call      qword ptr [735156197408]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M03_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M03_L03
M03_L01:
       mov       edi,[rbx+34]
       and       edi,1600000
       cmp       edi,1000000
       jne       short M03_L04
M03_L02:
       pop       rbx
       pop       r15
       pop       rbp
       ret
M03_L03:
       mov       rdi,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M03_L01
       mov       rdi,rbx
       call      qword ptr [73515619F810]
       jmp       short M03_L01
M03_L04:
       test      r15b,2
       jne       short M03_L05
       mov       rdi,rbx
       call      qword ptr [73515619F918]
M03_L05:
       mov       rdi,rbx
       call      qword ptr [73515619FF48]
       jmp       short M03_L02
; Total bytes of code 125
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.Int32, System.Private.CoreLib]].AsyncLazy_NoHop()
       push      rbp
       push      r15
       push      r14
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+70]
       vxorps    xmm8,xmm8,xmm8
       vmovdqu   ymmword ptr [rbp-50],ymm8
       vmovdqa   xmmword ptr [rbp-30],xmm8
       xor       eax,eax
       mov       [rbp-20],rax
       mov       rbx,rdi
       mov       rdi,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        near ptr M00_L14
       lea       rdi,[r15+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[r15+10]
       test      rax,rax
       jne       near ptr M00_L15
M00_L00:
       mov       rbx,[r15+8]
       mov       rsi,rbx
       mov       rdi,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L17
       test      rbx,rbx
       je        short M00_L01
       mov       rdi,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt
       cmp       [rbx],rdi
       je        near ptr M00_L05
M00_L01:
       lea       rdi,[r15+20]
       cmp       qword ptr [rdi],0
       jne       near ptr M00_L16
M00_L02:
       mov       rdi,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdi,offset MT_System.Threading.Tasks.TaskCompletionSource<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdi,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       xor       edi,edi
       mov       [rax+8],rdi
       mov       [rax+10],rdi
       mov       [rax+18],rdi
       mov       dword ptr [rax+34],2000440
       lea       rdi,[rbx+8]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdi,[r14+10]
       mov       rsi,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdi,[r14+8]
       mov       rsi,r15
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdi,[r15+8]
       test      rdi,rdi
       je        near ptr M00_L19
       mov       rsi,r14
       xor       edx,edx
       call      0000733361074060
       test      rax,rax
       jne       near ptr M00_L00
       xor       edi,edi
       mov       [rbp-30],rdi
       mov       [rbp-50],r14
       mov       dword ptr [rbp-38],0FFFFFFFF
       mov       rdi,7333612A0D68
       mov       rax,733361BD0820
       call      rax
       cmp       dword ptr [rax],4
       jle       near ptr M00_L20
       mov       rdi,[rax+8]
       mov       rax,[rdi+20]
       test      rax,rax
       je        near ptr M00_L20
M00_L03:
       mov       r15,[rax+10]
       test      r15,r15
       jne       short M00_L04
       call      qword ptr [7332E349C048]; System.Threading.Thread.InitializeCurrentThread()
       mov       r15,rax
M00_L04:
       mov       [rbp-58],r15
       mov       rsi,[r15+8]
       mov       [rbp-60],rsi
       mov       rsi,[r15+10]
       mov       [rbp-68],rsi
       jmp       short M00_L07
M00_L05:
       mov       rdi,rbx
       call      qword ptr [7332E3796700]
       test      eax,eax
       je        short M00_L06
       mov       rdi,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdi,rbx
       mov       rsi,7332D1C09F28
       call      qword ptr [7332E3495260]
       mov       rdi,rbx
       call      qword ptr [7332E37966D0]
       jmp       short M00_L12
M00_L06:
       mov       rdi,rbx
       xor       esi,esi
       call      qword ptr [7332E3796718]; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.Int32, System.Private.CoreLib]].WaitAsync(System.Threading.CancellationToken)
       jmp       short M00_L12
M00_L07:
       lea       rdi,[rbp-50]
       call      qword ptr [7332E37968F8]; System.Threading.Tasks.AsyncLazy`1+Attempt+<RunAsync>d__4[[System.Int32, System.Private.CoreLib]].MoveNext()
       nop
       mov       rsi,[rbp-68]
       cmp       rsi,[r15+10]
       je        short M00_L08
       lea       rdi,[r15+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L08:
       mov       rdi,[r15+8]
       mov       rbx,rdi
       mov       rsi,[rbp-60]
       cmp       rsi,rbx
       je        short M00_L10
       lea       rdi,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M00_L09
       cmp       qword ptr [rbx+10],0
       jne       near ptr M00_L21
M00_L09:
       cmp       qword ptr [rbp-60],0
       jne       short M00_L13
M00_L10:
       cmp       qword ptr [rbp-30],0
       je        near ptr M00_L22
M00_L11:
       mov       rax,[r14+10]
       mov       rax,[rax+8]
M00_L12:
       add       rsp,58
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L13:
       mov       rsi,[rbp-60]
       cmp       qword ptr [rsi+10],0
       je        short M00_L10
       jmp       short M00_L21
M00_L14:
       mov       edi,1
       mov       rsi,7332E37CB4D8
       call      qword ptr [7332E2C4EF88]
       mov       rdi,rax
       call      qword ptr [7332E379F438]
       int       3
M00_L15:
       jmp       short M00_L12
M00_L16:
       mov       rdi,[rdi]
       cmp       dword ptr [rdi+20],0
       je        near ptr M00_L02
       jmp       short M00_L18
M00_L17:
       jmp       short M00_L12
M00_L18:
       mov       rdi,[r15+20]
       call      qword ptr [7332E3796658]
       jmp       short M00_L12
M00_L19:
       call      qword ptr [7332E379F030]
       int       3
M00_L20:
       mov       edi,4
       call      qword ptr [7332E379F0D8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L03
M00_L21:
       mov       rdi,rbx
       mov       rsi,[rbp-60]
       call      qword ptr [7332E379EEB0]
       jmp       near ptr M00_L10
M00_L22:
       lea       rdi,[rbp-30]
       call      qword ptr [7332E379F6C0]
       jmp       near ptr M00_L11
       push      rax
       mov       rsi,[rbp-68]
       mov       rax,[rbp-58]
       cmp       rsi,[rax+10]
       je        short M00_L23
       lea       rdi,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-58]
M00_L23:
       mov       r14,[rax+8]
       mov       rsi,[rbp-60]
       cmp       rsi,r14
       je        short M00_L26
       lea       rdi,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      r14,r14
       je        short M00_L24
       cmp       qword ptr [r14+10],0
       jne       short M00_L25
M00_L24:
       cmp       qword ptr [rbp-60],0
       je        short M00_L26
       mov       rsi,[rbp-60]
       cmp       qword ptr [rsi+10],0
       je        short M00_L26
M00_L25:
       mov       rdi,r14
       mov       rsi,[rbp-60]
       call      qword ptr [7332E379EEB0]
M00_L26:
       nop
       add       rsp,8
       ret
; Total bytes of code 818
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.Int32, System.Private.CoreLib]](System.Threading.Tasks.Task`1<Int32>)
       push      rbx
       mov       rbx,rdi
       mov       edi,[rbx+34]
       and       edi,11000000
       cmp       edi,1000000
       jne       short M01_L01
M01_L00:
       mov       eax,[rbx+38]
       pop       rbx
       ret
M01_L01:
       mov       rdi,rbx
       xor       esi,esi
       call      qword ptr [7332E379C0A8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 39
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       push      rbp
       mov       rbp,rsp
       test      rsi,rsi
       jne       short M02_L01
M02_L00:
       mov       rax,rsi
       pop       rbp
       ret
M02_L01:
       cmp       [rsi],rdi
       je        short M02_L00
       mov       rax,[rsi]
       mov       rax,[rax+10]
       cmp       rax,rdi
       je        short M02_L00
M02_L02:
       test      rax,rax
       je        short M02_L03
       mov       rax,[rax+10]
       cmp       rax,rdi
       je        short M02_L00
       test      rax,rax
       je        short M02_L03
       mov       rax,[rax+10]
       cmp       rax,rdi
       je        short M02_L00
       test      rax,rax
       je        short M02_L03
       mov       rax,[rax+10]
       cmp       rax,rdi
       je        short M02_L00
       test      rax,rax
       je        short M02_L03
       mov       rax,[rax+10]
       cmp       rax,rdi
       je        short M02_L00
       jmp       short M02_L02
M02_L03:
       xor       esi,esi
       jmp       short M02_L00
; Total bytes of code 93
```
```assembly
; System.Threading.Thread.InitializeCurrentThread()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rbx
       sub       rsp,68
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-30],rax
       lea       rdi,[rbp-30]
       mov       [rbp-90],rdi
       lea       rdi,[rbp-88]
       call      qword ptr [7332E27EEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdi,[rbp-90]
       call      qword ptr [rax]
       lea       rdi,[rbp-88]
       call      qword ptr [7332E27EEF08]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-30]
       call      qword ptr [7332E27F0B98]
       lea       rdi,[rax+10]
       mov       rsi,[rbp-30]
       call      qword ptr [7332E27EEEB8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       add       rsp,68
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 123
```
```assembly
; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.Int32, System.Private.CoreLib]].WaitAsync(System.Threading.CancellationToken)
       push      r15
       push      rbx
       push      rax
       mov       rbx,rsi
       test      rbx,rbx
       jne       short M04_L00
       mov       rax,[rdi+10]
       mov       rax,[rax+8]
       add       rsp,8
       pop       rbx
       pop       r15
       ret
M04_L00:
       mov       rdi,[rdi+10]
       mov       r15,[rdi+8]
       cmp       [r15],r15b
       mov       rdi,offset MT_System.TimeProvider
       call      qword ptr [7332E2C45728]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,7323208014F0
       mov       rdx,[rdx]
       mov       rcx,rbx
       mov       rdi,r15
       mov       esi,0FFFFFFFF
       add       rsp,8
       pop       rbx
       pop       r15
       jmp       qword ptr [7332E379FC18]
; Total bytes of code 92
```
```assembly
; System.Threading.Tasks.AsyncLazy`1+Attempt+<RunAsync>d__4[[System.Int32, System.Private.CoreLib]].MoveNext()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rbx
       sub       rsp,98
       lea       rbp,[rsp+0C0]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm8,xmm8,xmm8
       vmovdqu   ymmword ptr [rbp-50],ymm8
       mov       [rbp-30],rax
       mov       [rbp-70],rdi
       mov       eax,[rdi+18]
       mov       rbx,[rdi]
       test      eax,eax
       je        near ptr M05_L18
       mov       rax,732320801370
       mov       r15,[rax]
       mov       r14,r15
       mov       rdi,7333612A0D68
       mov       rax,733361BD0820
       call      rax
       cmp       dword ptr [rax],4
       jle       near ptr M05_L21
       mov       rdi,[rax+8]
       mov       r13,[rdi+20]
       test      r13,r13
       je        near ptr M05_L21
M05_L00:
       mov       rax,[r13+10]
       test      rax,rax
       jne       short M05_L01
       call      qword ptr [7332E349C048]; System.Threading.Thread.InitializeCurrentThread()
M05_L01:
       mov       rdi,[rax+8]
       test      rdi,rdi
       je        short M05_L02
       mov       rdi,[rdi+8]
       lea       rdx,[rbp-40]
       mov       rsi,r14
       mov       r11,7332E1C60540
       call      qword ptr [r11]
       mov       rsi,[rbp-40]
       jmp       short M05_L03
M05_L02:
       xor       esi,esi
M05_L03:
       xor       edi,edi
       mov       [rbp-40],rdi
       mov       r14,rsi
       test      r14,r14
       je        short M05_L04
       mov       rdi,offset MT_System.Threading.Tasks.AsyncLazyAttemptFrame
       cmp       [r14],rdi
       jne       near ptr M05_L22
M05_L04:
       mov       rdi,offset MT_System.Threading.Tasks.AsyncLazyAttemptFrame
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rdi,[r12+8]
       mov       rsi,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdi,[r12+10]
       mov       rsi,r14
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [r15+8],0
       setne     r14b
       movzx     r14d,r14b
       mov       rax,[r13+10]
       test      rax,rax
       jne       short M05_L05
       call      qword ptr [7332E349C048]; System.Threading.Thread.InitializeCurrentThread()
M05_L05:
       mov       rax,[rax+8]
       mov       [rbp-78],rax
       xor       edi,edi
       mov       [rbp-48],rdi
       xor       ecx,ecx
       test      rax,rax
       je        short M05_L06
       mov       rdi,[rax+8]
       lea       rdx,[rbp-48]
       mov       rsi,r15
       mov       r11,7332E1C60558
       call      qword ptr [r11]
       mov       [rbp-4C],eax
       mov       rax,[rbp-78]
       mov       ecx,[rbp-4C]
M05_L06:
       cmp       [rbp-48],r12
       je        near ptr M05_L15
       xor       edi,edi
       mov       [rbp-58],rdi
       mov       [rbp-5C],edi
       test      rax,rax
       jne       short M05_L07
       mov       [rbp-4C],ecx
       mov       rdi,offset MT_System.Threading.AsyncLocalValueMap+OneElementAsyncLocalValueMap
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-98],rax
       lea       rdi,[rax+8]
       mov       rsi,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-98]
       lea       rdi,[rax+10]
       mov       rsi,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-98]
       mov       [rbp-80],rax
       jmp       short M05_L08
M05_L07:
       mov       [rbp-4C],ecx
       movzx     edx,byte ptr [rax+18]
       mov       [rbp-5C],edx
       test      r14d,r14d
       sete      cl
       movzx     ecx,cl
       mov       rdi,[rax+8]
       mov       rsi,r15
       mov       rdx,r12
       mov       r11,7332E1C60550
       call      qword ptr [r11]
       mov       [rbp-80],rax
       mov       rdx,[rbp-78]
       mov       rdx,[rdx+10]
       mov       [rbp-58],rdx
M05_L08:
       test      r14d,r14d
       je        short M05_L10
       cmp       dword ptr [rbp-4C],0
       jne       short M05_L10
       cmp       qword ptr [rbp-58],0
       je        short M05_L09
       mov       rdx,[rbp-58]
       mov       ecx,[rdx+8]
       mov       [rbp-60],ecx
       lea       edx,[rcx+1]
       lea       rsi,[rbp-58]
       mov       rdi,7332E37D1158
       call      qword ptr [7332E307C480]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       esi,[rbp-60]
       mov       rdi,[rbp-58]
       mov       rdx,r15
       call      qword ptr [7332E2C457A0]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M05_L10
M05_L09:
       mov       rdi,offset MT_System.Threading.IAsyncLocal[]
       mov       esi,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rbp-90],rax
       lea       rdi,[rax+10]
       mov       rsi,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-90]
       mov       [rbp-58],rax
M05_L10:
       mov       r13,[r13+10]
       test      r13,r13
       jne       short M05_L11
       call      qword ptr [7332E349C048]; System.Threading.Thread.InitializeCurrentThread()
       mov       r13,rax
M05_L11:
       cmp       dword ptr [rbp-5C],0
       jne       short M05_L12
       mov       rdi,732320801378
       mov       rax,[rbp-80]
       cmp       rax,[rdi]
       jne       short M05_L12
       xor       esi,esi
       jmp       short M05_L13
M05_L12:
       mov       rdi,offset MT_System.Threading.ExecutionContext
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       [rbp-88],rsi
       mov       rax,[rbp-58]
       mov       [rbp-0A0],rax
       lea       rdi,[rsi+8]
       mov       rsi,[rbp-80]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-88]
       lea       rdi,[rsi+10]
       mov       rsi,[rbp-0A0]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-88]
       mov       edi,[rbp-5C]
       mov       [rsi+18],dil
M05_L13:
       lea       rdi,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      r14d,r14d
       je        short M05_L15
       mov       rsi,[rbp-48]
       test      rsi,rsi
       jne       near ptr M05_L17
       xor       edi,edi
M05_L14:
       mov       rax,[r15+8]
       xor       ecx,ecx
       mov       [rsp],rdi
       mov       [rsp+8],r12
       mov       [rsp+10],cl
       mov       rdi,[rax+8]
       call      qword ptr [rax+18]
M05_L15:
       xor       edi,edi
       mov       [rbp-48],rdi
       mov       [rbp-58],rdi
       mov       rdi,[rbp-70]
       lea       rdi,[rdi+8]
       mov       rsi,r12
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rdi,rbx
       call      qword ptr [7332E3796970]; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.Int32, System.Private.CoreLib]].InvokeFactory()
       mov       rdi,[rbp-70]
       lea       rdi,[rdi+10]
       mov       rsi,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rdi,[rbp-70]
       mov       rsi,[rdi+10]
       cmp       [rsi],sil
       mov       [rbp-38],rsi
       mov       dword ptr [rbp-30],2
       test      byte ptr [rbp-30],4
       jne       short M05_L16
       mov       rsi,[rbp-38]
       test      dword ptr [rsi+34],1600000
       jne       short M05_L19
M05_L16:
       xor       esi,esi
       mov       [rdi+18],esi
       lea       rdi,[rdi+28]
       mov       rsi,[rbp-38]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       esi,[rbp-30]
       mov       rdi,[rbp-70]
       mov       [rdi+30],esi
       lea       rsi,[rdi+20]
       call      qword ptr [7332E3797A80]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].GetStateMachineBox[[System.Threading.Tasks.AsyncLazy`1+Attempt+<RunAsync>d__4[[System.Int32, System.Private.CoreLib]], AsyncLazy.Ablation.NoHop]](<RunAsync>d__4<Int32> ByRef, System.Threading.Tasks.Task`1<System.Threading.Tasks.VoidTaskResult> ByRef)
       mov       rsi,rax
       lea       rdi,[rbp-38]
       call      qword ptr [7332E3797A98]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].AwaitUnsafeOnCompleted[[System.Runtime.CompilerServices.ConfiguredTaskAwaitable+ConfiguredTaskAwaiter, System.Private.CoreLib]](ConfiguredTaskAwaiter ByRef, System.Runtime.CompilerServices.IAsyncStateMachineBox)
       jmp       near ptr M05_L29
M05_L17:
       mov       rdi,rsi
       mov       rax,offset MT_System.Threading.Tasks.AsyncLazyAttemptFrame
       cmp       [rdi],rax
       jne       short M05_L23
       jmp       near ptr M05_L14
M05_L18:
       mov       rdi,[rbp-70]
       vmovdqu   xmm0,xmmword ptr [rdi+28]
       vmovdqu   xmmword ptr [rbp-38],xmm0
       xor       esi,esi
       mov       [rdi+28],rsi
       mov       [rdi+30],rsi
       mov       dword ptr [rdi+18],0FFFFFFFF
       mov       rdi,[rbp-70]
M05_L19:
       mov       rsi,[rbp-38]
       mov       eax,[rbp-30]
       mov       ecx,[rsi+34]
       and       ecx,11000000
       cmp       ecx,1000000
       jne       short M05_L24
M05_L20:
       mov       rsi,[rdi+8]
       xor       eax,eax
       mov       [rsi+8],rax
       mov       rsi,[rdi+10]
       mov       rdi,rbx
       call      qword ptr [7332E3796A00]; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.Int32, System.Private.CoreLib]].Complete(System.Threading.Tasks.Task`1<Int32>)
       jmp       short M05_L25
M05_L21:
       mov       edi,4
       call      qword ptr [7332E379F0D8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r13,rax
       jmp       near ptr M05_L00
M05_L22:
       call      qword ptr [7332E2C46310]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M05_L23:
       mov       rdi,rax
       call      qword ptr [7332E2C46310]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M05_L24:
       mov       rdi,rsi
       mov       esi,eax
       call      qword ptr [7332E379C0A8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       mov       rdi,[rbp-70]
       jmp       short M05_L20
M05_L25:
       mov       rdi,[rbp-70]
       mov       dword ptr [rdi+18],0FFFFFFFE
       xor       eax,eax
       mov       [rdi+8],rax
       mov       [rdi+10],rax
       add       rdi,20
       mov       rbx,[rdi]
       test      rbx,rbx
       je        near ptr M05_L31
       mov       rdi,732320801380
       mov       rdi,[rdi]
       cmp       byte ptr [rdi+9D],0
       jne       near ptr M05_L32
M05_L26:
       mov       eax,[rbx+34]
       mov       [rbp-64],eax
       test      eax,5600000
       jne       near ptr M05_L34
       lea       rdi,[rbx+34]
       mov       esi,eax
       or        esi,4000000
       lock cmpxchg [rdi],esi
       cmp       eax,[rbp-64]
       jne       near ptr M05_L33
M05_L27:
       mov       byte ptr [rbx+38],0
       lea       rdi,[rbx+34]
       mov       eax,[rbx+34]
       or        eax,1000000
       xchg      eax,[rdi]
       mov       r15,[rbx+28]
       test      r15,r15
       je        short M05_L28
       mov       rdi,rbx
       call      qword ptr [7332E379F2A0]
       mov       rdi,[r15+10]
       test      rdi,rdi
       jne       near ptr M05_L35
M05_L28:
       lea       rdi,[rbx+20]
       test      rdi,rdi
       je        near ptr M05_L36
       mov       rsi,732320800238
       mov       rsi,[rsi]
       call      0000733361074040
       test      rax,rax
       jne       short M05_L30
M05_L29:
       add       rsp,98
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M05_L30:
       mov       rdi,rbx
       mov       rsi,rax
       call      qword ptr [7332E3797FA8]; System.Threading.Tasks.Task.RunContinuations(System.Object)
       jmp       short M05_L29
M05_L31:
       mov       rsi,732320800250
       mov       rsi,[rsi]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M05_L29
M05_L32:
       mov       rdi,rbx
       cmp       [rdi],edi
       call      qword ptr [7332E3797D38]
       mov       esi,eax
       mov       rdi,732320801380
       mov       rdi,[rdi]
       mov       edx,1
       call      qword ptr [7332E379F6A8]
       jmp       near ptr M05_L26
M05_L33:
       mov       rdi,rbx
       mov       esi,4000000
       mov       edx,5600000
       call      qword ptr [7332E379F288]
       test      eax,eax
       jne       near ptr M05_L27
M05_L34:
       mov       edi,18
       call      qword ptr [7332E379C540]
       int       3
M05_L35:
       call      qword ptr [7332E379FBA0]
       jmp       near ptr M05_L28
M05_L36:
       call      qword ptr [7332E379F030]
       int       3
       sub       rsp,18
       mov       rsi,rdi
       mov       rdi,[rbp-70]
       mov       dword ptr [rdi+18],0FFFFFFFE
       xor       eax,eax
       mov       [rdi+8],rax
       mov       [rdi+10],rax
       add       rdi,20
       call      qword ptr [7332E3796A30]
       lea       rax,[M05_L29]
       add       rsp,18
       ret
; Total bytes of code 1500
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbp
       push      rbx
       push      rax
       lea       rbp,[rsp+10]
       mov       ebx,edi
       call      qword ptr [7332E2806AF0]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       edi,ebx
       and       edi,0FFFFFF
       mov       ecx,edi
       mov       edx,ebx
       sar       edx,18
       jne       short M06_L01
       cmp       [rax],edi
       jle       short M06_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       ecx,0FFFFFFFE
       movsxd    rdi,ecx
       mov       rax,[rax+rdi*8+10]
       test      rax,rax
       je        short M06_L03
M06_L00:
       add       rsp,8
       pop       rbx
       pop       rbp
       ret
M06_L01:
       mov       edi,ebx
       sar       edi,18
       cmp       edi,2
       jne       short M06_L02
       movsxd    rcx,ecx
       add       rax,rcx
       jmp       short M06_L00
M06_L02:
       cmp       [rax+4],ecx
       jle       short M06_L03
       mov       rdi,[rax+10]
       movsxd    rax,ecx
       mov       rdi,[rdi+rax*8]
       test      rdi,rdi
       je        short M06_L03
       mov       rax,[rdi]
       test      rax,rax
       je        short M06_L03
       jmp       short M06_L00
M06_L03:
       mov       edi,ebx
       lea       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       add       rsp,8
       pop       rbx
       pop       rbp
       jmp       qword ptr [rax]
; Total bytes of code 133
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rbp
       push      r15
       push      rbx
       lea       rbp,[rsp+10]
       mov       rbx,rdi
       mov       r15d,esi
       test      dword ptr [rbx+34],1600000
       jne       short M07_L00
       mov       rdi,rbx
       mov       esi,0FFFFFFFF
       xor       edx,edx
       call      qword ptr [7332E379C0C0]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M07_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M07_L03
M07_L01:
       mov       edi,[rbx+34]
       and       edi,1600000
       cmp       edi,1000000
       jne       short M07_L04
M07_L02:
       pop       rbx
       pop       r15
       pop       rbp
       ret
M07_L03:
       mov       rdi,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M07_L01
       mov       rdi,rbx
       call      qword ptr [7332E379F768]
       jmp       short M07_L01
M07_L04:
       test      r15b,2
       jne       short M07_L05
       mov       rdi,rbx
       call      qword ptr [7332E379F8B8]
M07_L05:
       mov       rdi,rbx
       call      qword ptr [7332E379FCD8]
       jmp       short M07_L02
; Total bytes of code 125
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.Int32, System.Private.CoreLib]].AsyncLazy_NoRecursionDetection()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rbx
       push      rax
       lea       rbp,[rsp+30]
       mov       rbx,rdi
       mov       rdi,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        near ptr M00_L16
       lea       rdi,[r15+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[r15+10]
       test      rax,rax
       jne       near ptr M00_L17
M00_L00:
       mov       rbx,[r15+8]
       mov       rsi,rbx
       mov       rdi,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L19
       test      rbx,rbx
       je        short M00_L01
       mov       rdi,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt
       cmp       [rbx],rdi
       je        near ptr M00_L11
M00_L01:
       lea       rdi,[r15+20]
       cmp       qword ptr [rdi],0
       jne       near ptr M00_L18
M00_L02:
       mov       rdi,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdi,offset MT_System.Threading.Tasks.TaskCompletionSource<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdi,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       xor       edi,edi
       mov       [rax+8],rdi
       mov       [rax+10],rdi
       mov       [rax+18],rdi
       mov       dword ptr [rax+34],2000440
       lea       rdi,[rbx+8]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdi,[r14+10]
       mov       rsi,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdi,[r14+8]
       mov       rsi,r15
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdi,[r15+8]
       test      rdi,rdi
       je        near ptr M00_L21
       mov       rsi,r14
       xor       edx,edx
       call      00007AC23DA74060
       test      rax,rax
       jne       near ptr M00_L00
       mov       rdi,7AB1FC801378
       mov       r15,[rdi]
       test      r15,r15
       je        near ptr M00_L22
M00_L03:
       mov       rdi,7AC23DCA0D68
       mov       rax,7AC23E5CD820
       call      rax
       cmp       dword ptr [rax],4
       jle       near ptr M00_L23
       mov       rdi,[rax+8]
       mov       rax,[rdi+20]
       test      rax,rax
       je        near ptr M00_L23
M00_L04:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M00_L05
       call      qword ptr [7AC1BFE9C048]; System.Threading.Thread.InitializeCurrentThread()
M00_L05:
       mov       rbx,[rax+8]
       test      rbx,rbx
       jne       near ptr M00_L24
       mov       rdi,7AB1FC801380
       mov       rbx,[rdi]
M00_L06:
       test      rbx,rbx
       je        short M00_L07
       cmp       byte ptr [rbx+19],0
       je        near ptr M00_L25
M00_L07:
       mov       rdi,offset MT_System.Threading.QueueUserWorkItemCallbackDefaultContext<System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rdi,[r13+8]
       mov       rsi,r15
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdi,[r13+10]
       mov       rsi,r14
       call      CORINFO_HELP_ASSIGN_REF
M00_L08:
       mov       rdi,7AB1FC801390
       mov       rbx,[rdi]
       cmp       byte ptr [rbx+38],0
       jne       near ptr M00_L26
M00_L09:
       mov       rdi,[rbx+8]
       mov       rsi,[rdi+10]
       mov       rcx,[rsi+8]
M00_L10:
       mov       r15d,[rsi+0A0]
       mov       eax,r15d
       and       eax,[rsi+18]
       cmp       eax,[rcx+8]
       jae       near ptr M00_L28
       shl       rax,4
       lea       r12,[rcx+rax+10]
       mov       eax,[r12+8]
       sub       eax,r15d
       jne       short M00_L12
       lea       rdx,[rsi+0A0]
       lea       r8d,[r15+1]
       mov       eax,r15d
       lock cmpxchg [rdx],r8d
       cmp       eax,r15d
       jne       short M00_L10
       mov       rdi,r12
       mov       rsi,r13
       call      CORINFO_HELP_ASSIGN_REF
       inc       r15d
       mov       [r12+8],r15d
       jmp       short M00_L13
M00_L11:
       mov       rdi,rbx
       xor       esi,esi
       add       rsp,8
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7AC1C0196730]; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.Int32, System.Private.CoreLib]].WaitAsync(System.Threading.CancellationToken)
M00_L12:
       test      eax,eax
       jge       short M00_L10
       mov       rsi,r13
       call      qword ptr [7AC1C019F228]
M00_L13:
       add       rbx,78
       mov       edi,1
       xchg      edi,[rbx]
       test      edi,edi
       jne       short M00_L14
       mov       rdi,7AB1FC8013B8
       mov       rbx,[rdi]
       lea       rdi,[rbx+160]
       lock inc  dword ptr [rdi]
       mov       rdi,rbx
       call      qword ptr [7AC1C0196BC8]; System.Threading.PortableThreadPool+WorkerThread.MaybeAddWorkingWorker(System.Threading.PortableThreadPool)
       cmp       dword ptr [rbx+164],6
       jne       near ptr M00_L27
M00_L14:
       mov       rax,[r14+10]
       mov       rax,[rax+8]
M00_L15:
       add       rsp,8
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L16:
       mov       edi,1
       mov       rsi,7AC1C01CB4E0
       call      qword ptr [7AC1BF64EF88]
       mov       rdi,rax
       call      qword ptr [7AC1C019F798]
       int       3
M00_L17:
       jmp       short M00_L15
M00_L18:
       mov       rdi,[rdi]
       cmp       dword ptr [rdi+20],0
       je        near ptr M00_L02
       jmp       short M00_L20
M00_L19:
       jmp       short M00_L15
M00_L20:
       mov       rdi,[r15+20]
       add       rsp,8
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7AC1C0196658]
M00_L21:
       call      qword ptr [7AC1C019F1F8]
       int       3
M00_L22:
       mov       rdi,offset MT_System.Action<System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdi,7AB1FC801370
       mov       rsi,[rdi]
       lea       rdi,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset System.Threading.Tasks.AsyncLazy`1+<>c[[System.Int32, System.Private.CoreLib]].<GetOrStartAttemptAsync>b__11_0(Attempt<Int32>)
       mov       [r15+18],rdi
       mov       rdi,7AB1FC801378
       mov       rsi,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L03
M00_L23:
       mov       edi,4
       call      qword ptr [7AC1C019F0C0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L04
M00_L24:
       xor       edi,edi
       cmp       byte ptr [rbx+18],0
       cmovne    rbx,rdi
       jmp       near ptr M00_L06
M00_L25:
       mov       rdi,offset MT_System.Threading.QueueUserWorkItemCallback<System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdi,r13
       mov       rsi,r15
       mov       rdx,r14
       mov       rcx,rbx
       call      qword ptr [7AC1C019F3D8]
       jmp       near ptr M00_L08
M00_L26:
       mov       rdi,7AB1FC8013A8
       mov       rdi,[rdi]
       cmp       byte ptr [rdi+9D],0
       je        near ptr M00_L09
       mov       rdi,7AB1FC8013A8
       mov       rdi,[rdi]
       mov       rsi,r13
       call      qword ptr [7AC1C019F210]
       jmp       near ptr M00_L09
M00_L27:
       mov       rdi,rbx
       call      qword ptr [7AC1C0196E50]; System.Threading.PortableThreadPool+GateThread.EnsureRunningSlow(System.Threading.PortableThreadPool)
       jmp       near ptr M00_L14
M00_L28:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 994
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.Int32, System.Private.CoreLib]](System.Threading.Tasks.Task`1<Int32>)
       push      rbx
       mov       rbx,rdi
       mov       edi,[rbx+34]
       and       edi,11000000
       cmp       edi,1000000
       jne       short M01_L01
M01_L00:
       mov       eax,[rbx+38]
       pop       rbx
       ret
M01_L01:
       mov       rdi,rbx
       xor       esi,esi
       call      qword ptr [7AC1C01973A8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 39
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       push      rbp
       mov       rbp,rsp
       test      rsi,rsi
       jne       short M02_L01
M02_L00:
       mov       rax,rsi
       pop       rbp
       ret
M02_L01:
       cmp       [rsi],rdi
       je        short M02_L00
       mov       rax,[rsi]
       mov       rax,[rax+10]
       cmp       rax,rdi
       je        short M02_L00
M02_L02:
       test      rax,rax
       je        short M02_L03
       mov       rax,[rax+10]
       cmp       rax,rdi
       je        short M02_L00
       test      rax,rax
       je        short M02_L03
       mov       rax,[rax+10]
       cmp       rax,rdi
       je        short M02_L00
       test      rax,rax
       jne       short M02_L04
M02_L03:
       xor       esi,esi
       jmp       short M02_L00
M02_L04:
       mov       rax,[rax+10]
       cmp       rax,rdi
       je        short M02_L00
       test      rax,rax
       je        short M02_L03
       mov       rax,[rax+10]
       cmp       rax,rdi
       je        short M02_L00
       jmp       short M02_L02
; Total bytes of code 93
```
```assembly
; System.Threading.Thread.InitializeCurrentThread()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rbx
       sub       rsp,68
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-30],rax
       lea       rdi,[rbp-30]
       mov       [rbp-90],rdi
       lea       rdi,[rbp-88]
       call      qword ptr [7AC1BF1EEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdi,[rbp-90]
       call      qword ptr [rax]
       lea       rdi,[rbp-88]
       call      qword ptr [7AC1BF1EEF08]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-30]
       call      qword ptr [7AC1BF1F0B98]
       lea       rdi,[rax+10]
       mov       rsi,[rbp-30]
       call      qword ptr [7AC1BF1EEEB8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       add       rsp,68
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 123
```
```assembly
; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.Int32, System.Private.CoreLib]].WaitAsync(System.Threading.CancellationToken)
       push      r15
       push      rbx
       push      rax
       mov       rbx,rsi
       test      rbx,rbx
       jne       short M04_L00
       mov       rax,[rdi+10]
       mov       rax,[rax+8]
       add       rsp,8
       pop       rbx
       pop       r15
       ret
M04_L00:
       mov       rdi,[rdi+10]
       mov       r15,[rdi+8]
       cmp       [r15],r15b
       mov       rdi,offset MT_System.TimeProvider
       call      qword ptr [7AC1BF645728]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,7AB1FC8014F0
       mov       rdx,[rdx]
       mov       rcx,rbx
       mov       rdi,r15
       mov       esi,0FFFFFFFF
       add       rsp,8
       pop       rbx
       pop       r15
       jmp       qword ptr [7AC1C019FB88]
; Total bytes of code 92
```
```assembly
; System.Threading.PortableThreadPool+WorkerThread.MaybeAddWorkingWorker(System.Threading.PortableThreadPool)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rbx
       sub       rsp,18
       lea       rbp,[rsp+40]
       mov       rax,[rdi+0A0]
       movsx     rsi,ax
       mov       rcx,rax
       shr       rcx,20
       movsx     rcx,cx
       cmp       esi,ecx
       jge       near ptr M05_L08
M05_L00:
       lea       ecx,[rsi+1]
       movsx     rbx,cx
       mov       rcx,rax
       shr       rcx,10
       movsx     rcx,cx
       cmp       ecx,ebx
       jge       near ptr M05_L09
       mov       r15d,ebx
M05_L01:
       test      ebx,ebx
       jle       near ptr M05_L10
       mov       edx,ebx
M05_L02:
       mov       r8,rax
       and       r8,0FFFFFFFFFFFF0000
       movzx     edx,dx
       or        rdx,r8
       test      r15d,r15d
       jle       near ptr M05_L11
       mov       r8d,r15d
M05_L03:
       mov       r9,0FFFFFFFF0000FFFF
       and       rdx,r9
       movzx     r8d,r8w
       shl       r8,10
       or        rdx,r8
       lea       r8,[rdi+0A0]
       mov       [rbp-38],rax
       lock cmpxchg [r8],rdx
       mov       rdx,[rbp-38]
       cmp       rax,rdx
       jne       near ptr M05_L12
       sub       r15d,ecx
       sub       ebx,esi
       test      ebx,ebx
       jle       short M05_L07
       mov       rdi,7AB1FC8013C0
       mov       r14,[rdi]
       mov       r13,[r14+60]
M05_L04:
       mov       [rbp-30],r13
       mov       edi,ebx
       add       rdi,[rbp-30]
       mov       [rbp-30],rdi
       mov       r12d,[rbp-30]
       mov       rax,r13
       shr       rax,20
       movzx     eax,ax
       mov       rdi,r13
       shr       rdi,30
       movzx     edi,dil
       add       eax,edi
       cmp       r12d,eax
       ja        near ptr M05_L13
M05_L05:
       sub       r12d,edi
       mov       rdi,r13
       shr       rdi,38
       movzx     edi,dil
       sub       r12d,edi
       test      r12d,r12d
       jg        short M05_L15
M05_L06:
       lea       rdi,[r14+60]
       mov       rsi,[rbp-30]
       mov       rax,r13
       lock cmpxchg [rdi],rsi
       cmp       rax,r13
       jne       short M05_L14
       test      r12d,r12d
       jg        short M05_L17
M05_L07:
       test      r15d,r15d
       jg        near ptr M05_L18
M05_L08:
       add       rsp,18
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M05_L09:
       mov       r15d,ecx
       jmp       near ptr M05_L01
M05_L10:
       xor       edx,edx
       jmp       near ptr M05_L02
M05_L11:
       xor       r8d,r8d
       jmp       near ptr M05_L03
M05_L12:
       mov       rdx,rax
       movsx     rsi,dx
       mov       rcx,rdx
       shr       rcx,20
       movsx     rcx,cx
       cmp       esi,ecx
       mov       rax,rdx
       jl        near ptr M05_L00
       jmp       short M05_L08
M05_L13:
       mov       r12d,eax
       jmp       near ptr M05_L05
M05_L14:
       mov       r13,rax
       jmp       near ptr M05_L04
M05_L15:
       cmp       r12d,ebx
       jle       short M05_L16
       mov       r12d,ebx
M05_L16:
       lea       rdi,[rbp-30]
       mov       esi,r12d
       call      qword ptr [7AC1C019FAC8]; System.Threading.LowLevelLifoSemaphore+Counts.AddUpToMaxCountOfWaitersSignaledToWake(UInt32)
       jmp       near ptr M05_L06
M05_L17:
       mov       rdi,[r14+8]
       mov       esi,r12d
       cmp       [rdi],edi
       call      qword ptr [7AC1C019FAE0]; System.Threading.Semaphore.Release(Int32)
       jmp       near ptr M05_L07
M05_L18:
       call      qword ptr [7AC1C0196D78]; System.Threading.PortableThreadPool+WorkerThread.CreateWorkerThread()
       dec       r15d
       jmp       near ptr M05_L07
; Total bytes of code 447
```
```assembly
; System.Threading.Tasks.AsyncLazy`1+<>c[[System.Int32, System.Private.CoreLib]].<GetOrStartAttemptAsync>b__11_0(Attempt<Int32>)
       push      rbp
       push      r15
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+60]
       vxorps    xmm8,xmm8,xmm8
       vmovdqu   ymmword ptr [rbp-40],ymm8
       vmovdqa   xmmword ptr [rbp-20],xmm8
       cmp       [rsi],sil
       mov       [rbp-40],rsi
       mov       dword ptr [rbp-30],0FFFFFFFF
       mov       rdi,7AC23DCA0D68
       mov       rax,7AC23E5CD820
       call      rax
       cmp       dword ptr [rax],4
       jle       near ptr M06_L08
       mov       rdi,[rax+8]
       mov       rax,[rdi+20]
       test      rax,rax
       je        near ptr M06_L08
M06_L00:
       mov       rbx,[rax+10]
       test      rbx,rbx
       jne       short M06_L01
       call      qword ptr [7AC1BFE9C048]; System.Threading.Thread.InitializeCurrentThread()
       mov       rbx,rax
M06_L01:
       mov       [rbp-48],rbx
       mov       rsi,[rbx+8]
       mov       [rbp-50],rsi
       mov       rsi,[rbx+10]
       mov       [rbp-58],rsi
       lea       rdi,[rbp-40]
       call      qword ptr [7AC1C0197828]; System.Threading.Tasks.AsyncLazy`1+Attempt+<RunAsync>d__4[[System.Int32, System.Private.CoreLib]].MoveNext()
       nop
       mov       rsi,[rbp-58]
       cmp       rsi,[rbx+10]
       je        short M06_L02
       lea       rdi,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
M06_L02:
       mov       r15,[rbx+8]
       mov       rsi,[rbp-50]
       cmp       rsi,r15
       je        short M06_L04
       lea       rdi,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      r15,r15
       je        short M06_L03
       cmp       qword ptr [r15+10],0
       jne       short M06_L07
M06_L03:
       cmp       qword ptr [rbp-50],0
       jne       short M06_L06
M06_L04:
       cmp       qword ptr [rbp-28],0
       je        short M06_L09
M06_L05:
       add       rsp,50
       pop       rbx
       pop       r15
       pop       rbp
       ret
M06_L06:
       mov       rsi,[rbp-50]
       cmp       qword ptr [rsi+10],0
       je        short M06_L04
M06_L07:
       mov       rdi,r15
       mov       rsi,[rbp-50]
       call      qword ptr [7AC1C019F138]
       jmp       short M06_L04
M06_L08:
       mov       edi,4
       call      qword ptr [7AC1C019F0C0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M06_L00
M06_L09:
       lea       rdi,[rbp-28]
       call      qword ptr [7AC1C019F690]
       jmp       short M06_L05
       push      rax
       mov       rsi,[rbp-58]
       mov       rax,[rbp-48]
       cmp       rsi,[rax+10]
       je        short M06_L10
       lea       rdi,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-48]
M06_L10:
       mov       r15,[rax+8]
       mov       rsi,[rbp-50]
       cmp       rsi,r15
       je        short M06_L13
       lea       rdi,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      r15,r15
       je        short M06_L11
       cmp       qword ptr [r15+10],0
       jne       short M06_L12
M06_L11:
       cmp       qword ptr [rbp-50],0
       je        short M06_L13
       mov       rsi,[rbp-50]
       cmp       qword ptr [rsi+10],0
       je        short M06_L13
M06_L12:
       mov       rdi,r15
       mov       rsi,[rbp-50]
       call      qword ptr [7AC1C019F138]
M06_L13:
       nop
       add       rsp,8
       ret
; Total bytes of code 368
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbp
       push      rbx
       push      rax
       lea       rbp,[rsp+10]
       mov       ebx,edi
       call      qword ptr [7AC1BF206AF0]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       edi,ebx
       and       edi,0FFFFFF
       mov       ecx,edi
       mov       edx,ebx
       sar       edx,18
       jne       short M07_L01
       cmp       [rax],edi
       jle       short M07_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       ecx,0FFFFFFFE
       movsxd    rdi,ecx
       mov       rax,[rax+rdi*8+10]
       test      rax,rax
       je        short M07_L03
M07_L00:
       add       rsp,8
       pop       rbx
       pop       rbp
       ret
M07_L01:
       mov       edi,ebx
       sar       edi,18
       cmp       edi,2
       jne       short M07_L02
       movsxd    rcx,ecx
       add       rax,rcx
       jmp       short M07_L00
M07_L02:
       cmp       [rax+4],ecx
       jle       short M07_L03
       mov       rdi,[rax+10]
       movsxd    rax,ecx
       mov       rdi,[rdi+rax*8]
       test      rdi,rdi
       je        short M07_L03
       mov       rax,[rdi]
       test      rax,rax
       je        short M07_L03
       jmp       short M07_L00
M07_L03:
       mov       edi,ebx
       lea       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       add       rsp,8
       pop       rbx
       pop       rbp
       jmp       qword ptr [rax]
; Total bytes of code 133
```
```assembly
; System.Threading.PortableThreadPool+GateThread.EnsureRunningSlow(System.Threading.PortableThreadPool)
       push      rbp
       mov       rbp,rsp
       add       rdi,164
       mov       eax,6
       xchg      eax,[rdi]
       cmp       eax,4
       je        short M08_L01
       test      al,4
       je        short M08_L02
M08_L00:
       pop       rbp
       ret
M08_L01:
       mov       rdi,7AB1FC8013E8
       mov       rdi,[rdi]
       call      qword ptr [7AC1C02572A0]
       jmp       short M08_L00
M08_L02:
       call      qword ptr [7AC1C0196E68]; System.Threading.PortableThreadPool+GateThread.CreateGateThread()
       jmp       short M08_L00
; Total bytes of code 58
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rbp
       push      r15
       push      rbx
       lea       rbp,[rsp+10]
       mov       rbx,rdi
       mov       r15d,esi
       test      dword ptr [rbx+34],1600000
       jne       short M09_L00
       mov       rdi,rbx
       mov       esi,0FFFFFFFF
       xor       edx,edx
       call      qword ptr [7AC1C01973C0]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M09_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M09_L03
M09_L01:
       mov       edi,[rbx+34]
       and       edi,1600000
       cmp       edi,1000000
       jne       short M09_L04
M09_L02:
       pop       rbx
       pop       r15
       pop       rbp
       ret
M09_L03:
       mov       rdi,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M09_L01
       mov       rdi,rbx
       call      qword ptr [7AC1C019F780]
       jmp       short M09_L01
M09_L04:
       test      r15b,2
       jne       short M09_L05
       mov       rdi,rbx
       call      qword ptr [7AC1C019F420]
M09_L05:
       mov       rdi,rbx
       call      qword ptr [7AC1C019FBA0]
       jmp       short M09_L02
; Total bytes of code 125
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.Int32, System.Private.CoreLib]].Nito()
       push      rbp
       push      r15
       push      r14
       push      rbx
       sub       rsp,18
       lea       rbp,[rsp+30]
       mov       rbx,[rdi+8]
       test      rbx,rbx
       je        near ptr M00_L05
       mov       rdi,offset MT_Nito.AsyncEx.AsyncLazy<System.Int32>+<>c__DisplayClass14_0
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rdi,[r15+8]
       mov       rsi,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset MT_System.Func<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rdi,[rbx+8]
       mov       rsi,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset Nito.AsyncEx.AsyncLazy`1+<>c__DisplayClass14_0[[System.Int32, System.Private.CoreLib]].<RunOnThreadPool>b__0()
       mov       [rbx+18],rdi
       mov       rdi,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdi,offset MT_System.Lazy<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rdi,[r14+10]
       mov       rsi,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset MT_System.LazyHelper
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+10],8
       lea       rdi,[r14+8]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-28],r15
       xor       edi,edi
       mov       [rbp-1C],edi
       mov       rdi,r15
       call      00007F289BAE6020
       test      eax,eax
       je        short M00_L01
M00_L00:
       mov       dword ptr [rbp-1C],1
       cmp       qword ptr [r14+8],0
       je        short M00_L02
       mov       rdi,r14
       call      qword ptr [7F281E07C438]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rbx,rax
       jmp       short M00_L03
M00_L01:
       mov       rdi,r15
       call      qword ptr [7F281E37CD20]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L00
M00_L02:
       mov       rbx,[r14+18]
M00_L03:
       mov       rdi,r15
       call      00007F289BAE6790
       test      eax,eax
       jne       short M00_L06
M00_L04:
       mov       rax,rbx
       add       rsp,18
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L05:
       mov       rdi,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       edi,10E
       mov       rsi,7F281E3AB4D8
       call      qword ptr [7F281D82EF88]
       mov       rsi,rax
       mov       rdi,rbx
       call      qword ptr [7F281E07DF68]
       mov       rdi,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       mov       edi,eax
       mov       rsi,r15
       call      qword ptr [7F281E37EE08]
       jmp       short M00_L04
       push      rax
       cmp       dword ptr [rbp-1C],0
       je        short M00_L07
       mov       rdi,[rbp-28]
       call      00007F289BAE6790
       test      eax,eax
       je        short M00_L07
       mov       edi,eax
       mov       rsi,[rbp-28]
       call      qword ptr [7F281E37EE08]
M00_L07:
       nop
       add       rsp,8
       ret
; Total bytes of code 385
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.Int32, System.Private.CoreLib]](System.Threading.Tasks.Task`1<Int32>)
       push      rbx
       mov       rbx,rdi
       mov       edi,[rbx+34]
       and       edi,11000000
       cmp       edi,1000000
       jne       short M01_L01
M01_L00:
       mov       eax,[rbx+38]
       pop       rbx
       ret
M01_L01:
       mov       rdi,rbx
       xor       esi,esi
       call      qword ptr [7F281E3775A0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 39
```
```assembly
; Nito.AsyncEx.AsyncLazy`1+<>c__DisplayClass14_0[[System.Int32, System.Private.CoreLib]].<RunOnThreadPool>b__0()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rbx
       push      rax
       lea       rbp,[rsp+30]
       mov       rbx,[rdi+8]
       test      rbx,rbx
       je        near ptr M02_L15
       mov       r15,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task<System.Int32>>
       mov       rdi,r15
       call      qword ptr [7F281E376760]; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].get_Factory()
       cmp       [rax],al
       mov       rdi,7F185C801388
       mov       r14,[rdi]
       mov       rdi,r15
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rdi,[r15+8]
       mov       rsi,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       edi,edi
       mov       [r15+10],rdi
       lea       rdi,[r15+18]
       mov       rsi,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       edi,2008
       mov       [r15+34],edi
       mov       rdi,7F289BEA0D68
       mov       rax,7F289C898820
       call      rax
       cmp       dword ptr [rax],4
       jle       near ptr M02_L14
       mov       rdi,[rax+8]
       mov       rax,[rdi+20]
       test      rax,rax
       je        near ptr M02_L14
M02_L00:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M02_L01
       call      qword ptr [7F281E07C048]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       rbx,[rax+8]
       test      rbx,rbx
       jne       near ptr M02_L16
       mov       rdi,7F185C801398
       mov       rbx,[rdi]
M02_L02:
       test      rbx,rbx
       je        short M02_L04
       mov       rdi,7F185C801398
       cmp       rbx,[rdi]
       je        short M02_L05
       mov       rax,[r15+28]
       test      rax,rax
       jne       short M02_L03
       mov       rdi,offset MT_System.Threading.Tasks.Task+ContingentProperties
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [r14+3C],1
       lea       rdi,[r15+28]
       mov       rsi,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,r14
M02_L03:
       lea       rdi,[rax+8]
       mov       rsi,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M02_L05
M02_L04:
       or        dword ptr [r15+34],20000000
M02_L05:
       mov       rdi,r15
       xor       esi,esi
       call      qword ptr [7F281E376958]; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
       mov       rdi,offset MT_System.Threading.Tasks.UnwrapPromise<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       movzx     r14d,word ptr [r15+34]
       and       r14d,4
       test      r14d,0FFFFFFBB
       jne       near ptr M02_L13
       test      r14b,4
       je        short M02_L08
       mov       rdi,7F289BEA0D68
       mov       rax,7F289C898820
       call      rax
       cmp       dword ptr [rax],8
       jle       near ptr M02_L17
       mov       rdi,[rax+8]
       mov       rax,[rdi+40]
       test      rax,rax
       je        near ptr M02_L17
M02_L06:
       mov       r13,[rax+10]
       test      r13,r13
       je        short M02_L08
       mov       rax,[rbx+28]
       test      rax,rax
       jne       short M02_L07
       mov       rdi,offset MT_System.Threading.Tasks.Task+ContingentProperties
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       dword ptr [r12+3C],1
       lea       rdi,[rbx+28]
       mov       rsi,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,r12
M02_L07:
       lea       rdi,[rax+30]
       mov       rsi,r13
       call      CORINFO_HELP_ASSIGN_REF
M02_L08:
       xor       edi,edi
       mov       [rbx+8],rdi
       mov       [rbx+10],rdi
       mov       [rbx+18],rdi
       test      r14d,0FFFFFFA0
       jne       near ptr M02_L13
       mov       edi,r14d
       or        edi,400
       or        edi,2000000
       mov       [rbx+34],edi
       mov       rdi,[rbx+28]
       test      rdi,rdi
       jne       near ptr M02_L18
M02_L09:
       mov       byte ptr [rbx+3D],1
       mov       rdi,7F185C8013A8
       mov       rdi,[rdi]
       cmp       byte ptr [rdi+9D],0
       jne       near ptr M02_L19
M02_L10:
       cmp       byte ptr [7F281C83B06C],0
       jne       near ptr M02_L20
M02_L11:
       test      dword ptr [r15+34],1600000
       jne       near ptr M02_L21
       test      dword ptr [r15+34],1600000
       jne       near ptr M02_L24
       cmp       qword ptr [r15+20],0
       jne       near ptr M02_L23
       lea       rdi,[r15+20]
       test      rdi,rdi
       je        near ptr M02_L22
       mov       rsi,rbx
       xor       edx,edx
       call      00007F289BC74060
       test      rax,rax
       jne       near ptr M02_L23
M02_L12:
       mov       rax,rbx
       add       rsp,8
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L13:
       mov       edi,2D
       call      qword ptr [7F281D82F0D8]
       int       3
M02_L14:
       mov       edi,4
       call      qword ptr [7F281E37ECE8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M02_L00
M02_L15:
       mov       edi,2E
       call      qword ptr [7F281D82FAE0]
       int       3
M02_L16:
       xor       edi,edi
       cmp       byte ptr [rbx+18],0
       cmovne    rbx,rdi
       jmp       near ptr M02_L02
M02_L17:
       mov       edi,8
       call      qword ptr [7F281E37ECE8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M02_L06
M02_L18:
       mov       rdi,[rdi+30]
       test      rdi,rdi
       je        near ptr M02_L09
       test      r14b,4
       je        near ptr M02_L09
       test      byte ptr [rdi+34],8
       jne       near ptr M02_L09
       call      qword ptr [7F281E37EE20]
       jmp       near ptr M02_L09
M02_L19:
       mov       rdi,rbx
       call      qword ptr [7F281E377198]
       mov       esi,eax
       mov       rdi,7F185C8013A8
       mov       rdi,[rdi]
       mov       rdx,7F2818C0A890
       xor       ecx,ecx
       call      qword ptr [7F281E3771B0]
       jmp       near ptr M02_L10
M02_L20:
       mov       rdi,rbx
       call      qword ptr [7F281E3771C8]
       jmp       near ptr M02_L11
M02_L21:
       mov       rdi,rbx
       mov       rsi,r15
       call      qword ptr [7F281E3771F8]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].ProcessCompletedOuterTask(System.Threading.Tasks.Task)
       jmp       near ptr M02_L12
M02_L22:
       call      qword ptr [7F281E37EBE0]
       int       3
M02_L23:
       mov       rdi,r15
       mov       rsi,rbx
       xor       edx,edx
       call      qword ptr [7F281E37CD38]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M02_L12
M02_L24:
       mov       rdi,rbx
       mov       rsi,r15
       call      qword ptr [7F281E3B1838]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
       jmp       near ptr M02_L12
; Total bytes of code 900
```
```assembly
; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
M03_L00:
       push      rbp
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp-10],rdi
       mov       [rbp-20],rdi
M03_L01:
       mov       rbx,[rdi+8]
       test      rbx,rbx
       je        short M03_L05
       mov       eax,[rbx+10]
       cmp       eax,8
       jne       short M03_L06
       mov       [rbp-28],rbx
       xor       eax,eax
       mov       [rbp-14],eax
       mov       rdi,rbx
       call      00007F289BAE6020
       test      eax,eax
       je        short M03_L03
M03_L02:
       mov       dword ptr [rbp-14],1
       mov       rdi,[rbp-20]
       cmp       [rdi+8],rbx
       jne       short M03_L04
       mov       esi,2
       call      qword ptr [7F281E07C468]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M03_L04
M03_L03:
       mov       rdi,rbx
       call      qword ptr [7F281E37CD20]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M03_L02
M03_L04:
       mov       rdi,rbx
       call      00007F289BAE6790
       test      eax,eax
       jne       near ptr M03_L12
M03_L05:
       mov       rdi,[rbp-20]
       cmp       qword ptr [rdi+8],0
       je        near ptr M03_L13
       add       rsp,28
       pop       rbx
       pop       rbp
       jmp       qword ptr [7F281E07C438]
M03_L06:
       cmp       eax,8
       ja        short M03_L07
       mov       eax,eax
       lea       rcx,[7F281D8AD9C0]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M03_L01]
       add       rcx,rdx
       jmp       rcx
M03_L07:
       mov       rdi,[rbx+8]
       cmp       [rdi],edi
       call      qword ptr [7F281E37EEF8]
       int       3
       mov       rdi,[rbp-20]
       call      qword ptr [7F281E37F9D8]
       jmp       short M03_L05
       mov       rdi,[rbp-20]
       xor       esi,esi
       call      qword ptr [7F281E07C468]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M03_L05
       mov       rdi,[rbp-20]
       mov       rsi,[rdi]
       mov       rax,[rsi+30]
       mov       rax,[rax]
       mov       rax,[rax+10]
       test      rax,rax
       je        short M03_L08
       jmp       short M03_L09
M03_L08:
       mov       rdi,rsi
       mov       rsi,7F281E3CC540
       call      qword ptr [7F281D82F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M03_L09:
       mov       rdi,[rax+30]
       mov       rdi,[rdi]
       mov       rdi,[rdi+18]
       test      rdi,rdi
       je        short M03_L10
       jmp       short M03_L11
M03_L10:
       mov       rdi,rax
       mov       rsi,7F281E3CC5E0
       call      qword ptr [7F281D82F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M03_L11:
       call      qword ptr [7F281E37F978]
       mov       rdx,rax
       mov       rsi,rbx
       mov       rdi,[rbp-20]
       call      qword ptr [7F281E37F9F0]
       jmp       near ptr M03_L05
       mov       rdi,[rbp-20]
       mov       rsi,rbx
       call      qword ptr [7F281E37FA08]
       jmp       near ptr M03_L05
       mov       rdi,[rbp-20]
       call      qword ptr [7F281E37FA20]
       jmp       near ptr M03_L05
       mov       rdi,[rbp-20]
       mov       rsi,rbx
       mov       edx,1
       call      qword ptr [7F281E07C450]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M03_L05
M03_L12:
       mov       edi,eax
       mov       rsi,rbx
       call      qword ptr [7F281E37EE08]
       jmp       near ptr M03_L05
M03_L13:
       mov       rax,[rdi+18]
       add       rsp,28
       pop       rbx
       pop       rbp
       ret
       push      rax
       cmp       dword ptr [rbp-14],0
       je        short M03_L14
       mov       rdi,[rbp-28]
       call      00007F289BAE6790
       test      eax,eax
       je        short M03_L14
       mov       edi,eax
       mov       rsi,[rbp-28]
       call      qword ptr [7F281E37EE08]
M03_L14:
       nop
       add       rsp,8
       ret
; Total bytes of code 441
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
       call      qword ptr [7F281D3CEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdi,[rbp-90]
       call      qword ptr [rax]
       lea       rdi,[rbp-88]
       call      qword ptr [7F281D3CEF08]; CORINFO_HELP_JIT_PINVOKE_END
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
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rbp
       push      r15
       push      rbx
       lea       rbp,[rsp+10]
       mov       rbx,rdi
       mov       r15d,esi
       test      dword ptr [rbx+34],1600000
       jne       short M05_L00
       mov       rdi,rbx
       mov       esi,0FFFFFFFF
       xor       edx,edx
       call      qword ptr [7F281E3775B8]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M05_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M05_L03
M05_L01:
       mov       edi,[rbx+34]
       and       edi,1600000
       cmp       edi,1000000
       jne       short M05_L04
M05_L02:
       pop       rbx
       pop       r15
       pop       rbp
       ret
M05_L03:
       mov       rdi,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M05_L01
       mov       rdi,rbx
       call      qword ptr [7F281E37F918]
       jmp       short M05_L01
M05_L04:
       test      r15b,2
       jne       short M05_L05
       mov       rdi,rbx
       call      qword ptr [7F281E37F510]
M05_L05:
       mov       rdi,rbx
       call      qword ptr [7F281E37FCD8]
       jmp       short M05_L02
; Total bytes of code 125
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.Int32, System.Private.CoreLib]].Nito_ExecuteOnCallingThread()
       push      rbp
       push      r15
       push      r14
       push      rbx
       sub       rsp,18
       lea       rbp,[rsp+30]
       mov       rbx,[rdi+8]
       test      rbx,rbx
       je        near ptr M00_L05
       mov       rdi,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdi,offset MT_System.Lazy<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rdi,[r14+10]
       mov       rsi,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset MT_System.LazyHelper
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+10],8
       lea       rdi,[r14+8]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-28],r15
       xor       edi,edi
       mov       [rbp-1C],edi
       mov       rdi,r15
       call      00007237066E6020
       test      eax,eax
       je        short M00_L01
M00_L00:
       mov       dword ptr [rbp-1C],1
       cmp       qword ptr [r14+8],0
       je        short M00_L02
       mov       rdi,r14
       call      qword ptr [723688CAC438]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rbx,rax
       jmp       short M00_L03
M00_L01:
       mov       rdi,r15
       call      qword ptr [723688FAEA90]
       jmp       short M00_L00
M00_L02:
       mov       rbx,[r14+18]
M00_L03:
       mov       rdi,r15
       call      00007237066E6790
       test      eax,eax
       jne       short M00_L06
M00_L04:
       mov       rax,rbx
       add       rsp,18
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L05:
       mov       rdi,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       edi,10E
       mov       rsi,723688FDB4D8
       call      qword ptr [72368845EF88]
       mov       rsi,rax
       mov       rdi,rbx
       call      qword ptr [723688CADF68]
       mov       rdi,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       mov       edi,eax
       mov       rsi,r15
       call      qword ptr [723688FAE5B0]
       jmp       short M00_L04
       push      rax
       cmp       dword ptr [rbp-1C],0
       je        short M00_L07
       mov       rdi,[rbp-28]
       call      00007237066E6790
       test      eax,eax
       je        short M00_L07
       mov       edi,eax
       mov       rsi,[rbp-28]
       call      qword ptr [723688FAE5B0]
M00_L07:
       nop
       add       rsp,8
       ret
; Total bytes of code 311
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.Int32, System.Private.CoreLib]](System.Threading.Tasks.Task`1<Int32>)
       push      rbx
       mov       rbx,rdi
       mov       edi,[rbx+34]
       and       edi,11000000
       cmp       edi,1000000
       jne       short M01_L01
M01_L00:
       mov       eax,[rbx+38]
       pop       rbx
       ret
M01_L01:
       mov       rdi,rbx
       xor       esi,esi
       call      qword ptr [723688FA7690]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 39
```
```assembly
; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
M02_L00:
       push      rbp
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp-10],rdi
       mov       [rbp-20],rdi
M02_L01:
       mov       rbx,[rdi+8]
       test      rbx,rbx
       je        short M02_L05
       mov       eax,[rbx+10]
       cmp       eax,8
       jne       short M02_L06
       mov       [rbp-28],rbx
       xor       eax,eax
       mov       [rbp-14],eax
       mov       rdi,rbx
       call      00007237066E6020
       test      eax,eax
       je        short M02_L03
M02_L02:
       mov       dword ptr [rbp-14],1
       mov       rdi,[rbp-20]
       cmp       [rdi+8],rbx
       jne       short M02_L04
       mov       esi,2
       call      qword ptr [723688CAC468]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M02_L04
M02_L03:
       mov       rdi,rbx
       call      qword ptr [723688FAEA90]
       jmp       short M02_L02
M02_L04:
       mov       rdi,rbx
       call      00007237066E6790
       test      eax,eax
       jne       near ptr M02_L12
M02_L05:
       mov       rdi,[rbp-20]
       cmp       qword ptr [rdi+8],0
       je        near ptr M02_L13
       add       rsp,28
       pop       rbx
       pop       rbp
       jmp       qword ptr [723688CAC438]
M02_L06:
       cmp       eax,8
       ja        short M02_L07
       mov       eax,eax
       lea       rcx,[7236884D34D0]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M02_L01]
       add       rcx,rdx
       jmp       rcx
M02_L07:
       mov       rdi,[rbx+8]
       cmp       [rdi],edi
       call      qword ptr [723688FAE8E0]
       int       3
       mov       rdi,[rbp-20]
       call      qword ptr [723688FAEB08]
       jmp       short M02_L05
       mov       rdi,[rbp-20]
       xor       esi,esi
       call      qword ptr [723688CAC468]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M02_L05
       mov       rdi,[rbp-20]
       mov       rsi,[rdi]
       mov       rax,[rsi+30]
       mov       rax,[rax]
       mov       rax,[rax+10]
       test      rax,rax
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rdi,rsi
       mov       rsi,723688FF5C18
       call      qword ptr [72368845F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L09:
       mov       rdi,[rax+30]
       mov       rdi,[rdi]
       mov       rdi,[rdi+18]
       test      rdi,rdi
       je        short M02_L10
       jmp       short M02_L11
M02_L10:
       mov       rdi,rax
       mov       rsi,723688FF5CB8
       call      qword ptr [72368845F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M02_L11:
       call      qword ptr [723688FAEAA8]
       mov       rdx,rax
       mov       rsi,rbx
       mov       rdi,[rbp-20]
       call      qword ptr [723688FAEB20]
       jmp       near ptr M02_L05
       mov       rdi,[rbp-20]
       mov       rsi,rbx
       call      qword ptr [723688FAEB38]
       jmp       near ptr M02_L05
       mov       rdi,[rbp-20]
       call      qword ptr [723688FAEB50]
       jmp       near ptr M02_L05
       mov       rdi,[rbp-20]
       mov       rsi,rbx
       mov       edx,1
       call      qword ptr [723688CAC450]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M02_L05
M02_L12:
       mov       edi,eax
       mov       rsi,rbx
       call      qword ptr [723688FAE5B0]
       jmp       near ptr M02_L05
M02_L13:
       mov       rax,[rdi+18]
       add       rsp,28
       pop       rbx
       pop       rbp
       ret
       push      rax
       cmp       dword ptr [rbp-14],0
       je        short M02_L14
       mov       rdi,[rbp-28]
       call      00007237066E6790
       test      eax,eax
       je        short M02_L14
       mov       edi,eax
       mov       rsi,[rbp-28]
       call      qword ptr [723688FAE5B0]
M02_L14:
       nop
       add       rsp,8
       ret
; Total bytes of code 441
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rbp
       push      r15
       push      rbx
       lea       rbp,[rsp+10]
       mov       rbx,rdi
       mov       r15d,esi
       test      dword ptr [rbx+34],1600000
       jne       short M03_L00
       mov       rdi,rbx
       mov       esi,0FFFFFFFF
       xor       edx,edx
       call      qword ptr [723688FA76C0]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M03_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M03_L03
M03_L01:
       mov       edi,[rbx+34]
       and       edi,1600000
       cmp       edi,1000000
       jne       short M03_L04
M03_L02:
       pop       rbx
       pop       r15
       pop       rbp
       ret
M03_L03:
       mov       rdi,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M03_L01
       mov       rdi,rbx
       call      qword ptr [723688FAEDC0]
       jmp       short M03_L01
M03_L04:
       test      r15b,2
       jne       short M03_L05
       mov       rdi,rbx
       call      qword ptr [723688FAEBC8]
M03_L05:
       mov       rdi,rbx
       call      qword ptr [723688FAF030]
       jmp       short M03_L02
; Total bytes of code 125
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.Int32, System.Private.CoreLib]].VsThreading()
       push      r15
       push      rbx
       push      rax
       mov       rbx,rdi
       mov       rdi,offset MT_Microsoft.VisualStudio.Threading.AsyncLazy<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rbx,[rbx+8]
       mov       rdi,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rdi,[r15+8]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M00_L00
       lea       rdi,[r15+20]
       mov       rsi,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       edi,edi
       mov       [r15+10],rdi
       mov       rdi,r15
       xor       esi,esi
       add       rsp,8
       pop       rbx
       pop       r15
       jmp       qword ptr [73C5E6D966B8]; Microsoft.VisualStudio.Threading.AsyncLazy`1[[System.Int32, System.Private.CoreLib]].GetValueAsync(System.Threading.CancellationToken)
M00_L00:
       mov       rdi,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       edi,164
       mov       rsi,73C5E6DCB4E8
       call      qword ptr [73C5E624EF88]
       mov       rsi,rax
       mov       rdi,rbx
       call      qword ptr [73C5E6A9DF68]
       mov       rdi,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 157
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.Int32, System.Private.CoreLib]](System.Threading.Tasks.Task`1<Int32>)
       push      rbx
       mov       rbx,rdi
       mov       edi,[rbx+34]
       and       edi,11000000
       cmp       edi,1000000
       jne       short M01_L01
M01_L00:
       mov       eax,[rbx+38]
       pop       rbx
       ret
M01_L01:
       mov       rdi,rbx
       xor       esi,esi
       call      qword ptr [73C5E6D9D8F0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 39
```
```assembly
; Microsoft.VisualStudio.Threading.AsyncLazy`1[[System.Int32, System.Private.CoreLib]].GetValueAsync(System.Threading.CancellationToken)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rbx
       sub       rsp,128
       lea       rbp,[rsp+150]
       xor       eax,eax
       mov       [rbp-0C8],rax
       vxorps    xmm8,xmm8,xmm8
       vmovdqu   ymmword ptr [rbp-0C0],ymm8
       vmovdqu   ymmword ptr [rbp-0A0],ymm8
       vmovdqu   ymmword ptr [rbp-80],ymm8
       vmovdqu   ymmword ptr [rbp-60],ymm8
       mov       [rbp-40],rax
       mov       [rbp-0B8],rdi
       mov       [rbp-30],rsi
       mov       rdi,offset MT_Microsoft.VisualStudio.Threading.AsyncLazy<System.Int32>+<>c__DisplayClass20_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0C0],rax
       lea       rdi,[rax+8]
       mov       rsi,[rbp-0B8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-0B8]
       mov       rdi,[rsi+28]
       test      rdi,rdi
       jne       near ptr M02_L56
M02_L00:
       mov       rdi,[rsi+18]
       test      rdi,rdi
       jne       near ptr M02_L57
M02_L01:
       mov       rsi,[rbp-0B8]
       cmp       qword ptr [rsi+28],0
       jne       near ptr M02_L52
       mov       rdi,[rsi+8]
       test      rdi,rdi
       je        near ptr M02_L58
       call      000073C6644E5C00
       test      eax,eax
       jne       near ptr M02_L59
       xor       edi,edi
       mov       rax,[rbp-0C0]
       mov       [rax+10],rdi
       mov       rsi,[rbp-0B8]
       mov       rdi,[rsi+8]
       mov       [rbp-0C8],rdi
       xor       edi,edi
       mov       [rbp-34],edi
       cmp       qword ptr [rbp-0C8],0
       je        near ptr M02_L29
       mov       rdi,[rbp-0C8]
       call      000073C6644E6020
       test      eax,eax
       je        near ptr M02_L30
M02_L02:
       mov       dword ptr [rbp-34],1
       mov       rsi,[rbp-0B8]
       cmp       qword ptr [rsi+28],0
       jne       near ptr M02_L34
       cmp       qword ptr [rbp-30],0
       je        short M02_L03
       mov       rdi,[rbp-30]
       cmp       dword ptr [rdi+20],0
       jne       near ptr M02_L31
M02_L03:
       mov       rdi,offset MT_Microsoft.VisualStudio.Threading.InlineResumable
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,[rbp-0C0]
       lea       rdi,[rcx+10]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-0B8]
       mov       rsi,[rsi+20]
       mov       rcx,[rbp-0C0]
       lea       rdi,[rcx+18]
       call      CORINFO_HELP_ASSIGN_REF
       xor       edi,edi
       mov       rsi,[rbp-0B8]
       mov       [rsi+20],rdi
       mov       rdi,offset MT_System.Func<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rdi,[rbx+8]
       mov       rsi,[rbp-0C0]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset Microsoft.VisualStudio.Threading.AsyncLazy`1+<>c__DisplayClass20_0[[System.Int32, System.Private.CoreLib]].<GetValueAsync>b__0()
       mov       [rbx+18],rdi
       mov       rsi,[rbp-0B8]
       cmp       byte ptr [rsi+38],0
       jne       near ptr M02_L18
       cmp       qword ptr [rsi+18],0
       jne       near ptr M02_L32
M02_L04:
       mov       rdi,offset MT_Microsoft.VisualStudio.Threading.AsyncLocal<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdi,offset MT_System.Threading.AsyncLocal<System.Object>
       call      CORINFO_HELP_NEWSFAST
       lea       rdi,[r15+8]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14,[r15+8]
       mov       rdi,73B620801370
       mov       r13,[rdi]
       cmp       qword ptr [r14+8],0
       setne     r12b
       movzx     r12d,r12b
       mov       rdi,73C6648A0D68
       mov       rax,73C665197820
       call      rax
       cmp       dword ptr [rax],4
       jle       near ptr M02_L33
       mov       rdi,[rax+8]
       mov       rax,[rdi+20]
       test      rax,rax
       je        near ptr M02_L33
M02_L05:
       mov       [rbp-130],rax
       mov       rcx,[rax+10]
       test      rcx,rcx
       jne       short M02_L06
       call      qword ptr [73C5E6A9C048]; System.Threading.Thread.InitializeCurrentThread()
       mov       rcx,rax
M02_L06:
       mov       rcx,[rcx+8]
       mov       [rbp-0D0],rcx
       xor       edi,edi
       mov       [rbp-40],rdi
       xor       r8d,r8d
       test      rcx,rcx
       je        short M02_L07
       mov       rdi,[rcx+8]
       lea       rdx,[rbp-40]
       mov       rsi,r14
       mov       r11,73C5E5260590
       call      qword ptr [r11]
       mov       [rbp-44],eax
       mov       rcx,[rbp-0D0]
       mov       r8d,[rbp-44]
M02_L07:
       cmp       [rbp-40],r13
       je        near ptr M02_L17
       xor       edi,edi
       mov       [rbp-50],rdi
       mov       [rbp-54],edi
       test      rcx,rcx
       je        short M02_L08
       mov       [rbp-44],r8d
       movzx     edx,byte ptr [rcx+18]
       mov       [rbp-54],edx
       test      r12d,r12d
       sete      cl
       movzx     ecx,cl
       mov       r10,[rbp-0D0]
       mov       rdi,[r10+8]
       mov       rsi,r14
       mov       rdx,r13
       mov       r11,73C5E5260588
       call      qword ptr [r11]
       mov       [rbp-0D8],rax
       mov       rdx,[rbp-0D0]
       mov       rdx,[rdx+10]
       mov       [rbp-50],rdx
       jmp       short M02_L09
M02_L08:
       mov       [rbp-44],r8d
       mov       rdi,offset MT_System.Threading.AsyncLocalValueMap+OneElementAsyncLocalValueMap
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0F0],rax
       lea       rdi,[rax+8]
       mov       rsi,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-0F0]
       lea       rdi,[rax+10]
       mov       rsi,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-0F0]
       mov       [rbp-0D8],rax
M02_L09:
       test      r12d,r12d
       je        short M02_L11
       cmp       dword ptr [rbp-44],0
       jne       short M02_L11
       cmp       qword ptr [rbp-50],0
       je        short M02_L10
       mov       rdx,[rbp-50]
       mov       ecx,[rdx+8]
       mov       [rbp-58],ecx
       lea       edx,[rcx+1]
       lea       rsi,[rbp-50]
       mov       rdi,73C5E6E04128
       call      qword ptr [73C5E667C480]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       esi,[rbp-58]
       mov       rdi,[rbp-50]
       mov       rdx,r14
       call      qword ptr [73C5E62457A0]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M02_L11
M02_L10:
       mov       rdi,offset MT_System.Threading.IAsyncLocal[]
       mov       esi,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rbp-0E8],rax
       lea       rdi,[rax+10]
       mov       rsi,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-0E8]
       mov       [rbp-50],rax
M02_L11:
       mov       rcx,[rbp-130]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       short M02_L12
       call      qword ptr [73C5E6A9C048]; System.Threading.Thread.InitializeCurrentThread()
       mov       [rbp-0F8],rax
       mov       rcx,[rbp-0F8]
M02_L12:
       cmp       dword ptr [rbp-54],0
       je        near ptr M02_L25
       mov       [rbp-0F8],rcx
M02_L13:
       mov       rdi,offset MT_System.Threading.ExecutionContext
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       [rbp-0E0],rsi
       mov       rax,[rbp-50]
       mov       [rbp-100],rax
       lea       rdi,[rsi+8]
       mov       rsi,[rbp-0D8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-0E0]
       lea       rdi,[rsi+10]
       mov       rsi,[rbp-100]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-0E0]
       mov       edi,[rbp-54]
       mov       [rsi+18],dil
M02_L14:
       mov       rdi,[rbp-0F8]
       lea       rdi,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      r12d,r12d
       je        short M02_L17
       mov       rsi,[rbp-40]
       test      rsi,rsi
       jne       near ptr M02_L27
       xor       r12d,r12d
M02_L15:
       mov       rdi,[r14]
       mov       rdi,[rdi+30]
       mov       rdi,[rdi]
       mov       rdi,[rdi]
       mov       rax,r13
       cmp       [rax],rdi
       je        short M02_L16
       mov       rsi,r13
       call      qword ptr [73C5E62458C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
M02_L16:
       mov       rcx,[r14+8]
       xor       edi,edi
       mov       [rsp],r12
       mov       [rsp+8],rax
       mov       [rsp+10],dil
       mov       rdi,[rcx+8]
       call      qword ptr [rcx+18]
M02_L17:
       xor       edi,edi
       mov       [rbp-40],rdi
       mov       [rbp-50],rdi
       mov       rsi,[rbp-0B8]
       lea       rdi,[rsi+18]
       mov       rsi,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-0B8]
M02_L18:
       cmp       qword ptr [rsi+10],0
       jne       short M02_L20
       mov       rdi,offset Microsoft.VisualStudio.Threading.AsyncLazy`1+<>c__DisplayClass20_0[[System.Int32, System.Private.CoreLib]].<GetValueAsync>b__0()
       cmp       [rbx+18],rdi
       jne       near ptr M02_L23
       mov       rdi,[rbx+8]
       xor       eax,eax
       mov       [rbp-68],rax
       mov       [rbp-88],rdi
       mov       dword ptr [rbp-70],0FFFFFFFF
       lea       rdi,[rbp-88]
       call      qword ptr [73C5E6D97900]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[Microsoft.VisualStudio.Threading.AsyncLazy`1+<>c__DisplayClass20_0+<<GetValueAsync>b__0>d[[System.Int32, System.Private.CoreLib]], Microsoft.VisualStudio.Threading]](<<GetValueAsync>b__0>d<Int32> ByRef)
       mov       rsi,[rbp-68]
       test      rsi,rsi
       je        near ptr M02_L22
M02_L19:
       mov       r15,[rbp-0B8]
       lea       rdi,[r15+28]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L24
M02_L20:
       mov       rsi,[rbp-0B8]
       mov       rdi,[rsi+10]
       cmp       [rdi],dil
       mov       rsi,rbx
       xor       edx,edx
       xor       ecx,ecx
       xor       r8d,r8d
       call      qword ptr [73C5E6E65620]
       mov       r15,[rbp-0B8]
       lea       rdi,[r15+30]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       lock or   dword ptr [rsp],0
       mov       rdi,[r15+30]
       cmp       [rdi],dil
       call      qword ptr [73C5E6E656C8]
       mov       rsi,rax
       test      rsi,rsi
       je        short M02_L21
       mov       rdi,offset MT_System.Threading.Tasks.Task<System.Int32>
       cmp       [rsi],rdi
       je        short M02_L21
       mov       rsi,rax
       call      qword ptr [73C5E6674AF8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rsi,rax
M02_L21:
       lea       rdi,[r15+28]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M02_L24
M02_L22:
       lea       rdi,[rbp-68]
       call      qword ptr [73C5E6E647E0]
       mov       rsi,rax
       jmp       near ptr M02_L19
M02_L23:
       mov       rdi,[rbx+8]
       call      qword ptr [rbx+18]
       mov       rsi,rax
       jmp       near ptr M02_L19
M02_L24:
       call      M02_L66
       jmp       near ptr M02_L34
M02_L25:
       mov       rdi,73B6208013A8
       mov       rax,[rbp-0D8]
       cmp       rax,[rdi]
       jne       short M02_L26
       xor       esi,esi
       mov       [rbp-0F8],rcx
       jmp       near ptr M02_L14
M02_L26:
       mov       [rbp-0F8],rcx
       jmp       near ptr M02_L13
M02_L27:
       mov       rdi,[r14]
       mov       rdi,[rdi+30]
       mov       rdi,[rdi]
       mov       rdi,[rdi]
       mov       r12,rsi
       cmp       [r12],rdi
       je        short M02_L28
       call      qword ptr [73C5E62458C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r12,rax
M02_L28:
       jmp       near ptr M02_L15
M02_L29:
       xor       edi,edi
       call      qword ptr [73C5E6E64A98]
       int       3
M02_L30:
       mov       rdi,[rbp-0C8]
       call      qword ptr [73C5E6D9D8A8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M02_L02
M02_L31:
       lea       rdi,[rbp-30]
       call      qword ptr [73C5E6E65038]
       int       3
M02_L32:
       mov       rdi,73C5E6E78AE8
       call      qword ptr [73C5E6D96AF0]
       jmp       near ptr M02_L04
M02_L33:
       mov       edi,4
       call      qword ptr [73C5E6E64480]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M02_L05
M02_L34:
       mov       rdi,[rbp-0C8]
       call      000073C6644E6790
       test      eax,eax
       jne       near ptr M02_L60
M02_L35:
       mov       rsi,[rbp-0C0]
       mov       rdi,[rsi+10]
       test      rdi,rdi
       je        near ptr M02_L52
       mov       byte ptr [rdi+18],1
       mov       rbx,[rdi+8]
       xor       eax,eax
       mov       [rdi+8],rax
       mov       r15,[rdi+10]
       mov       rdi,73C6648A0D68
       mov       rax,73C665197820
       call      rax
       cmp       dword ptr [rax],4
       jle       near ptr M02_L61
       mov       rdi,[rax+8]
       mov       r13,[rdi+20]
       test      r13,r13
       je        near ptr M02_L61
M02_L36:
       mov       rax,[r13+10]
       test      rax,rax
       jne       short M02_L37
       call      qword ptr [73C5E6A9C048]; System.Threading.Thread.InitializeCurrentThread()
M02_L37:
       mov       r14,[rax+10]
       mov       rax,[r13+10]
       test      rax,rax
       jne       short M02_L38
       call      qword ptr [73C5E6A9C048]; System.Threading.Thread.InitializeCurrentThread()
M02_L38:
       lea       rdi,[rax+10]
       mov       rsi,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-128],r14
       test      rbx,rbx
       je        near ptr M02_L50
       mov       rdi,offset System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1+AsyncStateMachineBox`1[[System.Int32, System.Private.CoreLib],[Microsoft.VisualStudio.Threading.AsyncLazy`1+<>c__DisplayClass20_0+<<GetValueAsync>b__0>d[[System.Int32, System.Private.CoreLib]], Microsoft.VisualStudio.Threading]].MoveNext()
       cmp       [rbx+18],rdi
       jne       near ptr M02_L49
       mov       rbx,[rbx+8]
       mov       rdi,73B6208013A0
       mov       rdi,[rdi]
       movzx     r15d,byte ptr [rdi+9D]
       test      r15d,r15d
       jne       near ptr M02_L44
M02_L39:
       mov       rdi,[rbx+10]
       test      rdi,rdi
       je        near ptr M02_L45
       mov       rsi,73B6208013B0
       mov       rsi,[rsi]
       mov       rdx,rbx
       call      qword ptr [73C5E6D9C198]; System.Threading.ExecutionContext.RunInternal(System.Threading.ExecutionContext, System.Threading.ContextCallback, System.Object)
M02_L40:
       mov       edi,[rbx+34]
       test      edi,1600000
       je        short M02_L43
       cmp       byte ptr [73C5E525B06C],0
       jne       near ptr M02_L46
M02_L41:
       xor       edi,edi
       mov       [rbx+40],rdi
       mov       [rbx+48],rdi
       mov       [rbx+50],rdi
       mov       [rbx+58],rdi
       mov       [rbx+60],rdi
       mov       [rbx+68],rdi
       mov       [rbx+10],rdi
       mov       rdi,73B6208013A0
       mov       rdi,[rdi]
       cmp       byte ptr [rdi+9D],0
       je        short M02_L43
       movzx     eax,byte ptr [rdi+9D]
       mov       ecx,[rdi+98]
       mov       rdi,[rdi+80]
       test      eax,eax
       je        short M02_L43
       test      ecx,ecx
       je        short M02_L42
       cmp       ecx,3
       jl        short M02_L43
M02_L42:
       test      rdi,rdi
       je        short M02_L47
       test      edi,100
       jne       short M02_L47
M02_L43:
       test      r15d,r15d
       je        short M02_L50
       jmp       short M02_L48
M02_L44:
       mov       rdi,rbx
       call      qword ptr [73C5E6D9C168]
       mov       esi,eax
       mov       rdi,73B6208013A0
       mov       rdi,[rdi]
       mov       edx,2
       call      qword ptr [73C5E6D9C180]
       jmp       near ptr M02_L39
M02_L45:
       lea       rdi,[rbx+40]
       call      qword ptr [73C5E6D97960]; Microsoft.VisualStudio.Threading.AsyncLazy`1+<>c__DisplayClass20_0+<<GetValueAsync>b__0>d[[System.Int32, System.Private.CoreLib]].MoveNext()
       jmp       near ptr M02_L40
M02_L46:
       mov       rdi,rbx
       call      qword ptr [73C5E6D9D248]
       jmp       near ptr M02_L41
M02_L47:
       mov       rdi,rbx
       call      qword ptr [73C5E6A96880]; System.GC.SuppressFinalize(System.Object)
       jmp       short M02_L43
M02_L48:
       mov       rdi,73B6208013A0
       mov       rdi,[rdi]
       mov       esi,2
       call      qword ptr [73C5E6D9C1E0]
       jmp       short M02_L50
M02_L49:
       mov       rdi,[rbx+8]
       call      qword ptr [rbx+18]
       nop
M02_L50:
       mov       rax,[r13+10]
       test      rax,rax
       jne       short M02_L51
       call      qword ptr [73C5E6A9C048]; System.Threading.Thread.InitializeCurrentThread()
M02_L51:
       lea       rdi,[rax+10]
       mov       rsi,r14
       call      CORINFO_HELP_ASSIGN_REF
M02_L52:
       mov       rsi,[rbp-0B8]
       lock or   dword ptr [rsp],0
       mov       rdi,[rsi+30]
       test      rdi,rdi
       jne       near ptr M02_L62
       xor       eax,eax
M02_L53:
       test      rax,rax
       jne       short M02_L55
       mov       rsi,[rbp-0B8]
       mov       rbx,[rsi+28]
       mov       rdi,[rbp-30]
       mov       [rbp-0B0],rdi
       test      rbx,rbx
       je        near ptr M02_L63
       cmp       qword ptr [rbp-0B0],0
       jne       near ptr M02_L64
M02_L54:
       mov       rax,rbx
M02_L55:
       add       rsp,128
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L56:
       test      dword ptr [rdi+34],1600000
       jne       near ptr M02_L01
       jmp       near ptr M02_L00
M02_L57:
       mov       rdi,[rdi+8]
       cmp       [rdi],edi
       call      qword ptr [73C5E6E65698]
       test      rax,rax
       je        near ptr M02_L01
       call      qword ptr [73C5E6E656B0]
       mov       rdi,rax
       mov       rdx,73B620801528
       mov       rdx,[rdx]
       mov       rsi,73C5DD40C398
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rdi,rax
       xor       eax,eax
       test      rdi,rdi
       cmove     rdi,rax
       call      qword ptr [73C5E6D969D0]
       int       3
M02_L58:
       mov       edi,94D
       mov       rsi,73C5E5254000
       call      qword ptr [73C5E624EF88]
       mov       rdi,rax
       call      qword ptr [73C5E6E64A98]
       int       3
M02_L59:
       call      qword ptr [73C5E6E656B0]
       mov       rdi,rax
       mov       rdx,73B620801528
       mov       rdx,[rdx]
       mov       rsi,73C5DD40C398
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rdi,rax
       xor       eax,eax
       test      rdi,rdi
       cmove     rdi,rax
       call      qword ptr [73C5E6D969D0]
       int       3
M02_L60:
       mov       edi,eax
       mov       rsi,[rbp-0C8]
       call      qword ptr [73C5E6E64AB0]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       near ptr M02_L35
M02_L61:
       mov       edi,4
       call      qword ptr [73C5E6E64480]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r13,rax
       jmp       near ptr M02_L36
M02_L62:
       mov       rdx,[rbp-30]
       xor       esi,esi
       call      qword ptr [73C5E6D96AC0]
       jmp       near ptr M02_L53
M02_L63:
       mov       rdi,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       edi,170F
       mov       rsi,73C5E6DCB4E8
       call      qword ptr [73C5E624EF88]
       mov       rsi,rax
       mov       rdi,rbx
       call      qword ptr [73C5E6A9DF68]
       mov       rdi,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L64:
       test      dword ptr [rbx+34],1600000
       jne       near ptr M02_L54
       lea       rdi,[rbp-0B0]
       call      qword ptr [73C5E6D9D710]
       test      eax,eax
       je        short M02_L65
       mov       rdi,[rbp-0B0]
       call      qword ptr [73C5E6D9D6C8]
       jmp       near ptr M02_L55
M02_L65:
       mov       rdi,rbx
       mov       rsi,[rbp-0B0]
       call      qword ptr [73C5E6D9D698]
       jmp       near ptr M02_L55
M02_L66:
       sub       rsp,18
       mov       r15,[rbp-0B8]
       mov       rdi,[r15+18]
       test      rdi,rdi
       je        near ptr M02_L85
       mov       rbx,[rdi+8]
       cmp       qword ptr [rbx+8],0
       setne     r14b
       movzx     r14d,r14b
       mov       rdi,73C6648A0D68
       mov       rax,73C665197820
       call      rax
       cmp       dword ptr [rax],4
       jle       short M02_L67
       mov       rdi,[rax+8]
       mov       rcx,[rdi+20]
       test      rcx,rcx
       jne       short M02_L68
M02_L67:
       mov       edi,4
       call      qword ptr [73C5E6E64480]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rcx,rax
M02_L68:
       mov       r13,rcx
       mov       rax,[r13+10]
       test      rax,rax
       jne       short M02_L69
       call      qword ptr [73C5E6A9C048]; System.Threading.Thread.InitializeCurrentThread()
M02_L69:
       mov       r12,[rax+8]
       xor       edi,edi
       mov       [rbp-90],rdi
       xor       eax,eax
       test      r12,r12
       je        short M02_L70
       mov       rdi,[r12+8]
       lea       rdx,[rbp-90]
       mov       rsi,rbx
       mov       r11,73C5E52605A8
       call      qword ptr [r11]
       mov       [rbp-94],eax
       mov       eax,[rbp-94]
M02_L70:
       cmp       qword ptr [rbp-90],0
       je        near ptr M02_L84
       xor       edi,edi
       mov       [rbp-0A0],rdi
       mov       [rbp-0A4],edi
       test      r12,r12
       je        short M02_L71
       mov       [rbp-94],eax
       movzx     ecx,byte ptr [r12+18]
       mov       [rbp-0A4],ecx
       test      r14d,r14d
       sete      cl
       movzx     ecx,cl
       mov       rdi,[r12+8]
       mov       rsi,rbx
       mov       r11,73C5E52605A0
       xor       edx,edx
       call      qword ptr [r11]
       mov       [rbp-108],rax
       mov       rdx,[r12+10]
       mov       [rbp-0A0],rdx
       jmp       short M02_L74
M02_L71:
       test      r14d,r14d
       jne       short M02_L72
       mov       rdi,73B6208013A8
       mov       r12,[rdi]
       jmp       short M02_L73
M02_L72:
       mov       [rbp-94],eax
       mov       rdi,offset MT_System.Threading.AsyncLocalValueMap+OneElementAsyncLocalValueMap
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rsi,rbx
       mov       rdi,73C5E6E354A0
       xor       edx,edx
       call      qword ptr [73C5E6E64720]
       mov       [rbp-120],rdx
       lea       rdi,[r12+8]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdi,[r12+10]
       mov       rsi,[rbp-120]
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,[rbp-94]
M02_L73:
       mov       [rbp-94],eax
       mov       [rbp-108],r12
M02_L74:
       test      r14d,r14d
       je        short M02_L76
       cmp       dword ptr [rbp-94],0
       jne       short M02_L76
       cmp       qword ptr [rbp-0A0],0
       jne       short M02_L75
       mov       rdi,offset MT_System.Threading.IAsyncLocal[]
       mov       esi,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r12,rax
       lea       rdi,[r12+10]
       mov       rsi,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-0A0],r12
       jmp       short M02_L76
M02_L75:
       mov       rdx,[rbp-0A0]
       mov       r12d,[rdx+8]
       lea       edx,[r12+1]
       lea       rsi,[rbp-0A0]
       mov       rdi,73C5E6E04128
       call      qword ptr [73C5E667C480]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       esi,r12d
       mov       rdi,[rbp-0A0]
       mov       rdx,rbx
       call      qword ptr [73C5E62457A0]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M02_L76:
       mov       r13,[r13+10]
       test      r13,r13
       jne       short M02_L77
       call      qword ptr [73C5E6A9C048]; System.Threading.Thread.InitializeCurrentThread()
       mov       r13,rax
M02_L77:
       mov       r12d,[rbp-0A4]
       test      r12d,r12d
       jne       short M02_L78
       mov       rdi,73B6208013A8
       mov       rax,[rbp-108]
       cmp       rax,[rdi]
       je        short M02_L79
M02_L78:
       mov       rdi,offset MT_System.Threading.ExecutionContext
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       [rbp-110],rsi
       mov       rax,[rbp-0A0]
       mov       [rbp-118],rax
       lea       rdi,[rsi+8]
       mov       rsi,[rbp-108]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-110]
       lea       rdi,[rsi+10]
       mov       rsi,[rbp-118]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-110]
       mov       [rsi+18],r12b
       jmp       short M02_L80
M02_L79:
       xor       esi,esi
M02_L80:
       lea       rdi,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      r14d,r14d
       je        short M02_L84
       mov       rsi,[rbp-90]
       test      rsi,rsi
       je        short M02_L82
       mov       rdi,[rbx]
       mov       rdi,[rdi+30]
       mov       rdi,[rdi]
       mov       rdi,[rdi]
       mov       r14,rsi
       cmp       [r14],rdi
       je        short M02_L81
       call      qword ptr [73C5E62458C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r14,rax
M02_L81:
       jmp       short M02_L83
M02_L82:
       xor       r14d,r14d
M02_L83:
       mov       rax,[rbx+8]
       xor       edi,edi
       xor       ecx,ecx
       mov       [rsp],r14
       mov       [rsp+8],rdi
       mov       [rsp+10],cl
       mov       rdi,[rax+8]
       call      qword ptr [rax+18]
M02_L84:
       xor       edi,edi
       mov       [rbp-90],rdi
       mov       [rbp-0A0],rdi
M02_L85:
       add       rsp,18
       ret
       sub       rsp,18
       cmp       dword ptr [rbp-34],0
       je        short M02_L87
       cmp       qword ptr [rbp-0C8],0
       jne       short M02_L86
       xor       edi,edi
       call      qword ptr [73C5E6E64A98]
       int       3
M02_L86:
       mov       rdi,[rbp-0C8]
       call      000073C6644E6790
       test      eax,eax
       je        short M02_L87
       mov       edi,eax
       mov       rsi,[rbp-0C8]
       call      qword ptr [73C5E6E64AB0]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M02_L87:
       nop
       add       rsp,18
       ret
       sub       rsp,18
       mov       rdi,73C6648A0D68
       mov       rax,73C665197820
       call      rax
       cmp       dword ptr [rax],4
       jle       short M02_L88
       mov       rdi,[rax+8]
       mov       r13,[rdi+20]
       test      r13,r13
       jne       short M02_L89
M02_L88:
       mov       edi,4
       call      qword ptr [73C5E6E64480]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r13,rax
M02_L89:
       mov       r14,[r13+10]
       test      r14,r14
       jne       short M02_L90
       call      qword ptr [73C5E6A9C048]; System.Threading.Thread.InitializeCurrentThread()
       mov       r14,rax
M02_L90:
       lea       rdi,[r14+10]
       mov       rsi,[rbp-128]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,18
       ret
; Total bytes of code 3592
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rbp
       push      r15
       push      rbx
       lea       rbp,[rsp+10]
       mov       rbx,rdi
       mov       r15d,esi
       test      dword ptr [rbx+34],1600000
       jne       short M03_L00
       mov       rdi,rbx
       mov       esi,0FFFFFFFF
       xor       edx,edx
       call      qword ptr [73C5E6D9D908]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M03_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M03_L03
M03_L01:
       mov       edi,[rbx+34]
       and       edi,1600000
       cmp       edi,1000000
       jne       short M03_L04
M03_L02:
       pop       rbx
       pop       r15
       pop       rbp
       ret
M03_L03:
       mov       rdi,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M03_L01
       mov       rdi,rbx
       call      qword ptr [73C5E6E64A80]
       jmp       short M03_L01
M03_L04:
       test      r15b,2
       jne       short M03_L05
       mov       rdi,rbx
       call      qword ptr [73C5E6E652A8]
M03_L05:
       mov       rdi,rbx
       call      qword ptr [73C5E6E65728]
       jmp       short M03_L02
; Total bytes of code 125
```

