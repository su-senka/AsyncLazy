## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.Int32, System.Private.CoreLib]].LazyOfTask()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_System.Lazy<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,[rbx+8]
       test      rdx,rdx
       je        short M00_L00
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.LazyHelper
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+10],8
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [rsi+8],0
       je        short M00_L01
       mov       rcx,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF80D085860]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
M00_L00:
       mov       ecx,1687
       mov       rdx,7FF80CCE4000
       call      qword ptr [7FF80CDAF210]
       mov       rcx,rax
       call      qword ptr [7FF80D1A5D10]
       int       3
M00_L01:
       mov       rax,[rsi+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 143
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.Int32, System.Private.CoreLib]](System.Threading.Tasks.Task`1<Int32>)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       ecx,[rbx+34]
       and       ecx,11000000
       cmp       ecx,1000000
       jne       short M01_L01
M01_L00:
       mov       eax,[rbx+38]
       add       rsp,20
       pop       rbx
       ret
M01_L01:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF80D1A5D58]
       jmp       short M01_L00
; Total bytes of code 47
```
```assembly
; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
M02_L00:
       push      rbp
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+40]
       mov       [rbp-10],rcx
       mov       [rbp+10],rcx
M02_L01:
       mov       rbx,[rcx+8]
       test      rbx,rbx
       je        short M02_L04
       mov       eax,[rbx+10]
       cmp       eax,8
       jne       short M02_L05
       mov       [rbp-20],rbx
       xor       eax,eax
       mov       [rbp-14],eax
       mov       rcx,rbx
       call      00007FF86CA5E120
       test      eax,eax
       jne       short M02_L02
       mov       rcx,rbx
       call      qword ptr [7FF80D1A5E48]
M02_L02:
       mov       dword ptr [rbp-14],1
       mov       rcx,[rbp+10]
       cmp       [rcx+8],rbx
       jne       short M02_L03
       mov       edx,2
       call      qword ptr [7FF80D085890]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       nop
M02_L03:
       mov       rcx,rbx
       call      00007FF86CA5E040
       test      eax,eax
       jne       near ptr M02_L11
M02_L04:
       mov       rcx,[rbp+10]
       cmp       qword ptr [rcx+8],0
       je        near ptr M02_L12
       add       rsp,38
       pop       rbx
       pop       rbp
       jmp       qword ptr [7FF80D085860]
M02_L05:
       cmp       eax,8
       ja        short M02_L06
       mov       eax,eax
       lea       rdx,[7FF80CE1A6A0]
       mov       edx,[rdx+rax*4]
       lea       r8,[M02_L01]
       add       rdx,r8
       jmp       rdx
M02_L06:
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF80D1A5E60]
       int       3
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80D1A5DE8]
       jmp       short M02_L04
       mov       rcx,[rbp+10]
       xor       edx,edx
       call      qword ptr [7FF80D085890]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M02_L04
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+10]
       test      rax,rax
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rcx,rdx
       mov       rdx,7FF80D187880
       call      qword ptr [7FF80CDAF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L08:
       mov       rcx,[rax+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rax
       mov       rdx,7FF80D187920
       call      qword ptr [7FF80CDAF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M02_L10:
       call      qword ptr [7FF80D1A5D88]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80D1A5E00]
       jmp       near ptr M02_L04
       mov       rcx,[rbp+10]
       mov       rdx,rbx
       call      qword ptr [7FF80D1A5E18]
       jmp       near ptr M02_L04
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80D1A5E30]
       jmp       near ptr M02_L04
       mov       rcx,[rbp+10]
       mov       rdx,rbx
       mov       r8d,1
       call      qword ptr [7FF80D085878]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M02_L04
M02_L11:
       mov       ecx,eax
       mov       rdx,rbx
       call      qword ptr [7FF80D1A5D28]
       jmp       near ptr M02_L04
M02_L12:
       mov       rax,[rcx+18]
       add       rsp,38
       pop       rbx
       pop       rbp
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-14],0
       je        short M02_L13
       mov       rcx,[rbp-20]
       call      00007FF86CA5E040
       test      eax,eax
       je        short M02_L13
       mov       ecx,eax
       mov       rdx,[rbp-20]
       call      qword ptr [7FF80D1A5D28]
M02_L13:
       nop
       add       rsp,28
       ret
; Total bytes of code 442
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.Int32, System.Private.CoreLib]].LazyOfTask_TaskRun()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_System.Lazy<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,[rbx+10]
       test      rdx,rdx
       je        short M00_L00
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.LazyHelper
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+10],8
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [rsi+8],0
       je        short M00_L01
       mov       rcx,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF80D085860]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
M00_L00:
       mov       ecx,1687
       mov       rdx,7FF80CCE4000
       call      qword ptr [7FF80CDAF210]
       mov       rcx,rax
       call      qword ptr [7FF80D1A7D68]
       int       3
M00_L01:
       mov       rax,[rsi+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 143
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.Int32, System.Private.CoreLib]](System.Threading.Tasks.Task`1<Int32>)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       ecx,[rbx+34]
       and       ecx,11000000
       cmp       ecx,1000000
       jne       short M01_L01
M01_L00:
       mov       eax,[rbx+38]
       add       rsp,20
       pop       rbx
       ret
M01_L01:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF80D1A4DB0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 47
```
```assembly
; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
M02_L00:
       push      rbp
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+40]
       mov       [rbp-10],rcx
       mov       [rbp+10],rcx
M02_L01:
       mov       rbx,[rcx+8]
       test      rbx,rbx
       je        short M02_L04
       mov       eax,[rbx+10]
       cmp       eax,8
       jne       short M02_L05
       mov       [rbp-20],rbx
       xor       eax,eax
       mov       [rbp-14],eax
       mov       rcx,rbx
       call      00007FF86CA5E120
       test      eax,eax
       jne       short M02_L02
       mov       rcx,rbx
       call      qword ptr [7FF80D1A6118]; System.Threading.Monitor.Enter_Slowpath(System.Object)
M02_L02:
       mov       dword ptr [rbp-14],1
       mov       rcx,[rbp+10]
       cmp       [rcx+8],rbx
       jne       short M02_L03
       mov       edx,2
       call      qword ptr [7FF80D085890]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       nop
M02_L03:
       mov       rcx,rbx
       call      00007FF86CA5E040
       test      eax,eax
       jne       near ptr M02_L11
M02_L04:
       mov       rcx,[rbp+10]
       cmp       qword ptr [rcx+8],0
       je        near ptr M02_L12
       add       rsp,38
       pop       rbx
       pop       rbp
       jmp       qword ptr [7FF80D085860]
M02_L05:
       cmp       eax,8
       ja        short M02_L06
       mov       eax,eax
       lea       rdx,[7FF80CE263C0]
       mov       edx,[rdx+rax*4]
       lea       r8,[M02_L01]
       add       rdx,r8
       jmp       rdx
M02_L06:
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF80D1AC1E0]
       int       3
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80D1AC180]
       jmp       short M02_L04
       mov       rcx,[rbp+10]
       xor       edx,edx
       call      qword ptr [7FF80D085890]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M02_L04
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+10]
       test      rax,rax
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rcx,rdx
       mov       rdx,7FF80D200818
       call      qword ptr [7FF80CDAF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L08:
       mov       rcx,[rax+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rax
       mov       rdx,7FF80D2008B8
       call      qword ptr [7FF80CDAF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M02_L10:
       call      qword ptr [7FF80D1AC120]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80D1AC198]
       jmp       near ptr M02_L04
       mov       rcx,[rbp+10]
       mov       rdx,rbx
       call      qword ptr [7FF80D1AC1B0]
       jmp       near ptr M02_L04
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80D1AC1C8]
       jmp       near ptr M02_L04
       mov       rcx,[rbp+10]
       mov       rdx,rbx
       mov       r8d,1
       call      qword ptr [7FF80D085878]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M02_L04
M02_L11:
       mov       ecx,eax
       mov       rdx,rbx
       call      qword ptr [7FF80D1A6100]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       near ptr M02_L04
M02_L12:
       mov       rax,[rcx+18]
       add       rsp,38
       pop       rbx
       pop       rbp
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-14],0
       je        short M02_L13
       mov       rcx,[rbp-20]
       call      00007FF86CA5E040
       test      eax,eax
       je        short M02_L13
       mov       ecx,eax
       mov       rdx,[rbp-20]
       call      qword ptr [7FF80D1A6100]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M02_L13:
       nop
       add       rsp,28
       ret
; Total bytes of code 442
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      dword ptr [rbx+34],1600000
       jne       short M03_L00
       mov       rcx,rbx
       mov       edx,0FFFFFFFF
       xor       r8d,r8d
       call      qword ptr [7FF80D1A4DF8]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M03_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M03_L03
M03_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M03_L04
M03_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M03_L01
       mov       rcx,rbx
       call      qword ptr [7FF80D1AC090]
       jmp       short M03_L01
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FF80D1AC600]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FF80D1ACC48]
       jmp       short M03_L02
; Total bytes of code 124
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.Int32, System.Private.CoreLib]].AsyncLazy()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,[rbx+8]
       test      rdx,rdx
       je        short M00_L00
       lea       rcx,[rsi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsi+10]
       test      rax,rax
       jne       short M00_L01
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF80D14FE28]; System.Threading.Tasks.AsyncLazy`1[[System.Int32, System.Private.CoreLib]].GetOrStartAttemptAsync(System.Threading.CancellationToken)
M00_L00:
       mov       ecx,1
       mov       rdx,7FF80D1C6660
       call      qword ptr [7FF80CDDF210]
       mov       rcx,rax
       call      qword ptr [7FF80D1DC108]
       int       3
M00_L01:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 109
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.Int32, System.Private.CoreLib]](System.Threading.Tasks.Task`1<Int32>)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       ecx,[rbx+34]
       and       ecx,11000000
       cmp       ecx,1000000
       jne       short M01_L01
M01_L00:
       mov       eax,[rbx+38]
       add       rsp,20
       pop       rbx
       ret
M01_L01:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF80D1D4BD0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 47
```
```assembly
; System.Threading.Tasks.AsyncLazy`1[[System.Int32, System.Private.CoreLib]].GetOrStartAttemptAsync(System.Threading.CancellationToken)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
M02_L00:
       mov       rdi,[rbx+8]
       mov       rdx,rdi
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M02_L18
       test      rdi,rdi
       je        short M02_L01
       mov       rcx,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt
       cmp       [rdi],rcx
       je        near ptr M02_L11
M02_L01:
       lea       rcx,[rbx+20]
       cmp       qword ptr [rcx],0
       jne       near ptr M02_L17
M02_L02:
       mov       rcx,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Threading.Tasks.TaskCompletionSource<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       xor       ecx,ecx
       mov       [rax+8],rcx
       mov       [rax+10],rcx
       mov       [rax+18],rcx
       mov       dword ptr [rax+34],2000440
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+8]
       test      rcx,rcx
       je        near ptr M02_L20
       mov       rdx,rbp
       xor       r8d,r8d
       call      00007FF86CA021C0
       test      rax,rax
       jne       near ptr M02_L00
       mov       rcx,1AD14C01328
       mov       rbx,[rcx]
       test      rbx,rbx
       je        near ptr M02_L21
M02_L03:
       mov       rcx,gs:[58]
       mov       rcx,[rcx+48]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M02_L22
       mov       rcx,[rcx+240]
       mov       rax,[rcx+20]
       test      rax,rax
       je        near ptr M02_L22
M02_L04:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M02_L05
       call      qword ptr [7FF80D0B5470]; System.Threading.Thread.InitializeCurrentThread()
M02_L05:
       mov       rdi,[rax+8]
       test      rdi,rdi
       jne       near ptr M02_L23
       mov       rcx,1AD14C01330
       mov       rdi,[rcx]
M02_L06:
       test      rdi,rdi
       je        short M02_L07
       cmp       byte ptr [rdi+19],0
       je        near ptr M02_L24
M02_L07:
       mov       rcx,offset MT_System.Threading.QueueUserWorkItemCallbackDefaultContext<System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M02_L08:
       mov       rcx,1AD14C01340
       mov       rbx,[rcx]
       cmp       byte ptr [rbx+38],0
       jne       near ptr M02_L25
M02_L09:
       mov       rcx,[rbx+8]
       mov       rdx,[rcx+10]
       mov       r8,[rdx+8]
M02_L10:
       mov       edi,[rdx+0A0]
       mov       eax,edi
       and       eax,[rdx+18]
       cmp       eax,[r8+8]
       jae       near ptr M02_L28
       shl       rax,4
       lea       r15,[r8+rax+10]
       mov       eax,[r15+8]
       sub       eax,edi
       jne       near ptr M02_L13
       lea       r10,[rdx+0A0]
       lea       r9d,[rdi+1]
       mov       eax,edi
       lock cmpxchg [r10],r9d
       cmp       eax,edi
       jne       short M02_L10
       mov       rcx,r15
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       inc       edi
       mov       [r15+8],edi
       jmp       short M02_L14
M02_L11:
       mov       rcx,rdi
       call      qword ptr [7FF80D14FEE8]
       test      eax,eax
       je        short M02_L12
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,1BD39288BD8
       call      qword ptr [7FF80D0B7D50]
       mov       rcx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       qword ptr [7FF80D14FEA0]
M02_L12:
       mov       rcx,rdi
       mov       rdx,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       qword ptr [7FF80D14FF00]; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.Int32, System.Private.CoreLib]].WaitAsync(System.Threading.CancellationToken)
M02_L13:
       test      eax,eax
       jge       near ptr M02_L10
       mov       rdx,r14
       call      qword ptr [7FF80D1DC210]
M02_L14:
       add       rbx,78
       mov       ecx,1
       xchg      ecx,[rbx]
       test      ecx,ecx
       jne       short M02_L15
       mov       rcx,1AD14C01368
       mov       rbx,[rcx]
       lea       rcx,[rbx+178]
       lock inc  dword ptr [rcx]
       mov       rcx,rbx
       call      qword ptr [7FF80D1D44B0]; System.Threading.PortableThreadPool+WorkerThread.MaybeAddWorkingWorker(System.Threading.PortableThreadPool)
       cmp       dword ptr [rbx+17C],6
       jne       near ptr M02_L26
M02_L15:
       test      rsi,rsi
       jne       near ptr M02_L27
       mov       rcx,[rbp+10]
       mov       rax,[rcx+8]
M02_L16:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L17:
       mov       rcx,[rcx]
       cmp       dword ptr [rcx+20],0
       je        near ptr M02_L02
       jmp       short M02_L19
M02_L18:
       jmp       short M02_L16
M02_L19:
       mov       rcx,[rbx+20]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       qword ptr [7FF80D14FDE0]
M02_L20:
       call      qword ptr [7FF80D1DC060]
       int       3
M02_L21:
       mov       rcx,offset MT_System.Action<System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,1AD14C01320
       mov       rdx,[rcx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset System.Threading.Tasks.AsyncLazy`1+<>c[[System.Int32, System.Private.CoreLib]].<GetOrStartAttemptAsync>b__11_0(Attempt<Int32>)
       mov       [rbx+18],rcx
       mov       rcx,1AD14C01328
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L03
M02_L22:
       mov       ecx,4
       call      qword ptr [7FF80D1D7D50]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M02_L04
M02_L23:
       xor       ecx,ecx
       cmp       byte ptr [rdi+18],0
       cmovne    rdi,rcx
       jmp       near ptr M02_L06
M02_L24:
       mov       rcx,offset MT_System.Threading.QueueUserWorkItemCallback<System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rbx
       mov       r8,rbp
       mov       r9,rdi
       call      qword ptr [7FF80D1DC1C8]
       jmp       near ptr M02_L08
M02_L25:
       mov       rcx,1AD14C01358
       mov       rcx,[rcx]
       cmp       byte ptr [rcx+9D],0
       je        near ptr M02_L09
       mov       rcx,1AD14C01358
       mov       rcx,[rcx]
       mov       rdx,r14
       call      qword ptr [7FF80D1DC1E0]
       jmp       near ptr M02_L09
M02_L26:
       mov       rcx,rbx
       call      qword ptr [7FF80D1D4690]; System.Threading.PortableThreadPool+GateThread.EnsureRunningSlow(System.Threading.PortableThreadPool)
       jmp       near ptr M02_L15
M02_L27:
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+8]
       cmp       [rbx],bl
       mov       rcx,offset MT_System.TimeProvider
       call      qword ptr [7FF80CDD5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,1AD14C01488
       mov       r8,[r8]
       mov       r9,rsi
       mov       rcx,rbx
       mov       edx,0FFFFFFFF
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       qword ptr [7FF80D1DCAF8]
M02_L28:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1050
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      dword ptr [rbx+34],1600000
       jne       short M03_L00
       mov       rcx,rbx
       mov       edx,0FFFFFFFF
       xor       r8d,r8d
       call      qword ptr [7FF80D1D4C00]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M03_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M03_L03
M03_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M03_L04
M03_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M03_L01
       mov       rcx,rbx
       call      qword ptr [7FF80D1DC0F0]
       jmp       short M03_L01
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FF80D1DC240]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FF80D1DCB10]
       jmp       short M03_L02
; Total bytes of code 124
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.Int32, System.Private.CoreLib]].AsyncLazy_NoHop()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,78
       lea       rbp,[rsp+90]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-50],ymm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       xor       eax,eax
       mov       [rbp-20],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,[rbx+8]
       test      rdx,rdx
       je        near ptr M00_L13
       lea       rcx,[rsi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsi+10]
       test      rax,rax
       jne       near ptr M00_L14
M00_L00:
       mov       rbx,[rsi+8]
       mov       rdx,rbx
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L16
       test      rbx,rbx
       je        short M00_L01
       mov       rcx,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt
       cmp       [rbx],rcx
       je        near ptr M00_L05
M00_L01:
       lea       rcx,[rsi+20]
       cmp       qword ptr [rcx],0
       jne       near ptr M00_L15
M00_L02:
       mov       rcx,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_System.Threading.Tasks.TaskCompletionSource<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       xor       ecx,ecx
       mov       [rax+8],rcx
       mov       [rax+10],rcx
       mov       [rax+18],rcx
       mov       dword ptr [rax+34],2000440
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+8]
       test      rcx,rcx
       je        near ptr M00_L18
       mov       rdx,rdi
       xor       r8d,r8d
       call      00007FF86CA021C0
       test      rax,rax
       jne       near ptr M00_L00
       xor       ecx,ecx
       mov       [rbp-30],rcx
       mov       [rbp-50],rdi
       mov       dword ptr [rbp-38],0FFFFFFFF
       mov       rcx,gs:[58]
       mov       rcx,[rcx+48]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M00_L19
       mov       rcx,[rcx+240]
       mov       rax,[rcx+20]
       test      rax,rax
       je        near ptr M00_L19
M00_L03:
       mov       rsi,[rax+10]
       test      rsi,rsi
       jne       short M00_L04
       call      qword ptr [7FF80D085470]; System.Threading.Thread.InitializeCurrentThread()
       mov       rsi,rax
M00_L04:
       mov       [rbp-58],rsi
       mov       rdx,[rsi+8]
       mov       [rbp-60],rdx
       mov       rdx,[rsi+10]
       mov       [rbp-68],rdx
       jmp       short M00_L07
M00_L05:
       mov       rcx,rbx
       call      qword ptr [7FF80D11FF78]
       test      eax,eax
       je        short M00_L06
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,231A5298BD8
       call      qword ptr [7FF80D087D50]
       mov       rcx,rbx
       call      qword ptr [7FF80D11FF48]
       jmp       short M00_L12
M00_L06:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF80D11FF90]; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.Int32, System.Private.CoreLib]].WaitAsync(System.Threading.CancellationToken)
       jmp       short M00_L12
M00_L07:
       lea       rcx,[rbp-50]
       call      qword ptr [7FF80D1A4150]; System.Threading.Tasks.AsyncLazy`1+Attempt+<RunAsync>d__4[[System.Int32, System.Private.CoreLib]].MoveNext()
       nop
       mov       rdx,[rbp-68]
       cmp       rdx,[rsi+10]
       je        short M00_L08
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L08:
       mov       rcx,[rsi+8]
       mov       rbx,rcx
       mov       rdx,[rbp-60]
       cmp       rdx,rbx
       je        short M00_L10
       lea       rcx,[rsi+8]
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
       mov       rax,[rdi+10]
       mov       rax,[rax+8]
M00_L12:
       add       rsp,78
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M00_L13:
       mov       ecx,1
       mov       rdx,7FF80D196C28
       call      qword ptr [7FF80CDAF210]
       mov       rcx,rax
       call      qword ptr [7FF80D1A69D0]
       int       3
M00_L14:
       jmp       short M00_L12
M00_L15:
       mov       rcx,[rcx]
       cmp       dword ptr [rcx+20],0
       je        near ptr M00_L02
       jmp       short M00_L17
M00_L16:
       jmp       short M00_L12
M00_L17:
       mov       rcx,[rsi+20]
       call      qword ptr [7FF80D11FED0]
       jmp       short M00_L12
M00_L18:
       call      qword ptr [7FF80D1A6910]
       int       3
M00_L19:
       mov       ecx,4
       call      qword ptr [7FF80D1A6718]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L03
M00_L20:
       mov       rdx,[rbp-60]
       cmp       qword ptr [rdx+10],0
       je        short M00_L10
M00_L21:
       mov       rcx,rbx
       mov       rdx,[rbp-60]
       call      qword ptr [7FF80D1A6988]
       jmp       near ptr M00_L10
M00_L22:
       lea       rcx,[rbp-30]
       call      qword ptr [7FF80D1A69A0]
       jmp       near ptr M00_L11
       sub       rsp,28
       mov       rdx,[rbp-68]
       mov       rax,[rbp-58]
       cmp       rdx,[rax+10]
       je        short M00_L23
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-58]
M00_L23:
       mov       rdi,[rax+8]
       mov       rdx,[rbp-60]
       cmp       rdx,rdi
       je        short M00_L26
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M00_L24
       cmp       qword ptr [rdi+10],0
       jne       short M00_L25
M00_L24:
       cmp       qword ptr [rbp-60],0
       je        short M00_L26
       mov       rdx,[rbp-60]
       cmp       qword ptr [rdx+10],0
       je        short M00_L26
M00_L25:
       mov       rcx,rdi
       mov       rdx,[rbp-60]
       call      qword ptr [7FF80D1A6988]
M00_L26:
       nop
       add       rsp,28
       ret
; Total bytes of code 816
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.Int32, System.Private.CoreLib]](System.Threading.Tasks.Task`1<Int32>)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       ecx,[rbx+34]
       and       ecx,11000000
       cmp       ecx,1000000
       jne       short M01_L01
M01_L00:
       mov       eax,[rbx+38]
       add       rsp,20
       pop       rbx
       ret
M01_L01:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF80D1A6808]
       jmp       short M01_L00
; Total bytes of code 47
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       jne       short M02_L01
M02_L00:
       mov       rax,rdx
       ret
M02_L01:
       cmp       [rdx],rcx
       je        short M02_L00
       mov       rax,[rdx]
       mov       rax,[rax+10]
M02_L02:
       cmp       rax,rcx
       je        short M02_L00
       test      rax,rax
       je        short M02_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L00
       test      rax,rax
       je        short M02_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L00
       test      rax,rax
       je        short M02_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L00
       test      rax,rax
       je        short M02_L03
       mov       rax,[rax+10]
       jmp       short M02_L02
M02_L03:
       xor       edx,edx
       jmp       short M02_L00
; Total bytes of code 83
```
```assembly
; System.Threading.Thread.InitializeCurrentThread()
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
       xor       eax,eax
       mov       [rbp-40],rax
       lea       rcx,[rbp-40]
       mov       [rbp-0A0],rcx
       lea       rcx,[rbp-98]
       call      qword ptr [7FF850609030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FF850609038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FF85060AEB8]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FF850608FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
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
; Total bytes of code 133
```
```assembly
; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.Int32, System.Private.CoreLib]].WaitAsync(System.Threading.CancellationToken)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rdx
       test      rbx,rbx
       jne       short M04_L00
       mov       rax,[rcx+10]
       mov       rax,[rax+8]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       mov       rcx,[rcx+10]
       mov       rsi,[rcx+8]
       cmp       [rsi],sil
       mov       rcx,offset MT_System.TimeProvider
       call      qword ptr [7FF80CDA5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,231E8801390
       mov       r8,[r8]
       mov       r9,rbx
       mov       rcx,rsi
       mov       edx,0FFFFFFFF
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF80D1A6B80]
; Total bytes of code 92
```
```assembly
; System.Threading.Tasks.AsyncLazy`1+Attempt+<RunAsync>d__4[[System.Int32, System.Private.CoreLib]].MoveNext()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,78
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu32 [rbp-80],zmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp+10],rcx
       mov       eax,[rcx+18]
       mov       rbx,[rcx]
       test      eax,eax
       je        near ptr M05_L30
       mov       rax,231E8801320
       mov       rsi,[rax]
       mov       rdi,rsi
       mov       rax,gs:[58]
       mov       rax,[rax+48]
       cmp       dword ptr [rax+238],4
       jle       near ptr M05_L26
       mov       rax,[rax+240]
       mov       r14,[rax+20]
       test      r14,r14
       je        near ptr M05_L26
M05_L00:
       mov       rax,[r14+10]
       test      rax,rax
       jne       short M05_L01
       call      qword ptr [7FF80D085470]; System.Threading.Thread.InitializeCurrentThread()
M05_L01:
       mov       r8,[rax+8]
       test      r8,r8
       je        short M05_L02
       mov       rcx,[r8+8]
       lea       r8,[rbp-50]
       mov       rdx,rdi
       mov       r11,7FF80CCF0518
       call      qword ptr [r11]
       mov       rdx,[rbp-50]
       jmp       short M05_L03
M05_L02:
       xor       edx,edx
M05_L03:
       xor       eax,eax
       mov       [rbp-50],rax
       mov       rdi,rdx
       test      rdi,rdi
       je        short M05_L04
       mov       rax,offset MT_System.Threading.Tasks.AsyncLazyAttemptFrame
       cmp       [rdi],rax
       jne       near ptr M05_L27
M05_L04:
       mov       rcx,offset MT_System.Threading.Tasks.AsyncLazyAttemptFrame
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [rsi+8],0
       setne     dil
       movzx     edi,dil
       mov       rax,[r14+10]
       test      rax,rax
       jne       short M05_L05
       call      qword ptr [7FF80D085470]; System.Threading.Thread.InitializeCurrentThread()
M05_L05:
       mov       r13,[rax+8]
       xor       ecx,ecx
       mov       [rbp-58],rcx
       xor       r12d,r12d
       test      r13,r13
       je        short M05_L06
       mov       rcx,[r13+8]
       lea       r8,[rbp-58]
       mov       rdx,rsi
       mov       r11,7FF80CCF0530
       call      qword ptr [r11]
       mov       r12d,eax
M05_L06:
       cmp       [rbp-58],r15
       je        near ptr M05_L15
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       [rbp-64],ecx
       test      r13,r13
       jne       short M05_L07
       mov       rcx,offset MT_System.Threading.AsyncLocalValueMap+OneElementAsyncLocalValueMap
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rcx,[r13+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-88],r13
       jmp       short M05_L08
M05_L07:
       movzx     eax,byte ptr [r13+18]
       mov       [rbp-64],eax
       test      edi,edi
       sete      r9b
       movzx     r9d,r9b
       mov       rcx,[r13+8]
       mov       rdx,rsi
       mov       r8,r15
       mov       r11,7FF80CCF0528
       call      qword ptr [r11]
       mov       [rbp-88],rax
       mov       r8,[r13+10]
       mov       [rbp-60],r8
M05_L08:
       test      edi,edi
       je        short M05_L10
       test      r12d,r12d
       jne       short M05_L10
       cmp       qword ptr [rbp-60],0
       je        short M05_L09
       mov       r8,[rbp-60]
       mov       r13d,[r8+8]
       lea       r8d,[r13+1]
       lea       rdx,[rbp-60]
       mov       rcx,7FF80D19CB60
       call      qword ptr [7FF80CF8C5D0]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       edx,r13d
       mov       rcx,[rbp-60]
       mov       r8,rsi
       call      qword ptr [7FF80CDA57B8]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M05_L10
M05_L09:
       mov       rcx,offset MT_System.Threading.IAsyncLocal[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r13,rax
       lea       rcx,[r13+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-60],r13
M05_L10:
       mov       r14,[r14+10]
       test      r14,r14
       jne       short M05_L11
       call      qword ptr [7FF80D085470]; System.Threading.Thread.InitializeCurrentThread()
       mov       r14,rax
M05_L11:
       mov       r13d,[rbp-64]
       test      r13d,r13d
       jne       short M05_L12
       mov       rcx,231E8801328
       mov       rax,[rbp-88]
       cmp       rax,[rcx]
       jne       short M05_L12
       xor       edx,edx
       jmp       short M05_L13
M05_L12:
       mov       rcx,offset MT_System.Threading.ExecutionContext
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rax,[rbp-60]
       mov       [rbp-90],rax
       lea       rcx,[r12+8]
       mov       rdx,[rbp-88]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+10]
       mov       rdx,[rbp-90]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r12+18],r13b
       mov       rdx,r12
M05_L13:
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      edi,edi
       je        short M05_L15
       mov       rdx,[rbp-58]
       test      rdx,rdx
       jne       near ptr M05_L25
       xor       ecx,ecx
M05_L14:
       mov       rax,[rsi+8]
       mov       [rbp-80],rcx
       mov       [rbp-78],r15
       mov       byte ptr [rbp-70],0
       lea       rdx,[rbp-80]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
M05_L15:
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-60],rcx
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,r15
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,rbx
       call      qword ptr [7FF80D1A41C8]; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.Int32, System.Private.CoreLib]].InvokeFactory()
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       cmp       [rdx],dl
       mov       [rbp-48],rdx
       mov       dword ptr [rbp-40],2
       test      byte ptr [rbp-40],4
       jne       near ptr M05_L29
       mov       rdx,[rbp-48]
       test      dword ptr [rdx+34],1600000
       je        near ptr M05_L29
M05_L16:
       mov       rdx,[rbp-48]
       mov       eax,[rbp-40]
       mov       r8d,[rdx+34]
       and       r8d,11000000
       cmp       r8d,1000000
       jne       near ptr M05_L31
M05_L17:
       mov       rdx,[rcx+8]
       xor       eax,eax
       mov       [rdx+8],rax
       mov       rsi,[rcx+10]
       mov       edx,[rsi+34]
       and       edx,1600000
       cmp       edx,1000000
       jne       near ptr M05_L39
       mov       edx,[rsi+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       near ptr M05_L32
       mov       edi,[rsi+38]
M05_L18:
       mov       rax,[rbx+8]
       xor       edx,edx
       mov       [rax+18],rdx
       mov       [rax+20],rdx
       lea       eax,[rdi+1]
       cmp       eax,0A
       jb        near ptr M05_L33
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+34],1000000
       mov       [rsi+38],edi
M05_L19:
       mov       rcx,[rbx+8]
       lea       rcx,[rcx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+8]
       lea       rcx,[rcx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbx,[rbx+10]
       mov       rsi,[rbx+8]
       xor       r14d,r14d
       mov       eax,[rsi+34]
       mov       [rbp-68],eax
       test      eax,5600000
       jne       short M05_L23
       lea       rcx,[rsi+34]
       mov       edx,eax
       or        edx,4000000
       lock cmpxchg [rcx],edx
       cmp       eax,[rbp-68]
       jne       near ptr M05_L34
M05_L20:
       mov       [rsi+38],edi
       lea       rcx,[rsi+34]
       mov       eax,[rsi+34]
       or        eax,1000000
       xchg      eax,[rcx]
       mov       r14,[rsi+28]
       test      r14,r14
       jne       near ptr M05_L35
M05_L21:
       lea       rcx,[rsi+20]
       test      rcx,rcx
       je        near ptr M05_L36
       mov       rdx,231E8800218
       mov       rdx,[rdx]
       call      00007FF86CA0C330
       test      rax,rax
       je        short M05_L22
       mov       rcx,rsi
       mov       rdx,rax
       call      qword ptr [7FF80D1A6928]
M05_L22:
       mov       r14d,1
M05_L23:
       test      r14d,r14d
       je        near ptr M05_L37
M05_L24:
       test      r14b,r14b
       jne       near ptr M05_L42
       jmp       near ptr M05_L38
M05_L25:
       mov       rcx,rdx
       mov       rax,offset MT_System.Threading.Tasks.AsyncLazyAttemptFrame
       cmp       [rcx],rax
       jne       short M05_L28
       jmp       near ptr M05_L14
M05_L26:
       mov       ecx,4
       call      qword ptr [7FF80D1A6718]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r14,rax
       jmp       near ptr M05_L00
M05_L27:
       mov       rcx,rax
       call      qword ptr [7FF80CDA6328]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M05_L28:
       mov       rcx,rax
       call      qword ptr [7FF80CDA6328]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M05_L29:
       xor       edx,edx
       mov       [rcx+18],edx
       lea       rcx,[rcx+28]
       mov       rdx,[rbp-48]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       edx,[rbp-40]
       mov       rcx,[rbp+10]
       mov       [rcx+30],edx
       lea       rdx,[rcx+20]
       call      qword ptr [7FF80D1A6BF8]
       mov       rdx,rax
       lea       rcx,[rbp-48]
       call      qword ptr [7FF80D1A6C10]
       jmp       near ptr M05_L43
M05_L30:
       mov       rcx,[rbp+10]
       vmovdqu   xmm0,xmmword ptr [rcx+28]
       vmovdqu   xmmword ptr [rbp-48],xmm0
       xor       edx,edx
       mov       [rcx+28],rdx
       mov       [rcx+30],rdx
       mov       dword ptr [rcx+18],0FFFFFFFF
       mov       rcx,[rbp+10]
       jmp       near ptr M05_L16
M05_L31:
       mov       rcx,rdx
       mov       edx,eax
       call      qword ptr [7FF80D1A6808]
       mov       rcx,[rbp+10]
       jmp       near ptr M05_L17
M05_L32:
       mov       rcx,rsi
       mov       edx,1
       call      qword ptr [7FF80D1A6B68]
       mov       edi,eax
       jmp       near ptr M05_L18
M05_L33:
       mov       rcx,offset MT_System.Threading.Tasks.TaskCache
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,231E8801360
       mov       rcx,[rcx]
       lea       edx,[rdi+1]
       cmp       edx,[rcx+8]
       jae       near ptr M05_L40
       lea       edx,[rdi+1]
       mov       rsi,[rcx+rdx*8+10]
       jmp       near ptr M05_L19
M05_L34:
       mov       rcx,rsi
       mov       edx,4000000
       mov       r8d,5600000
       call      qword ptr [7FF80D1A68C8]
       test      eax,eax
       je        near ptr M05_L23
       jmp       near ptr M05_L20
M05_L35:
       mov       rcx,rsi
       call      qword ptr [7FF80D1A68E0]
       mov       rcx,r14
       call      qword ptr [7FF80D1A68F8]
       jmp       near ptr M05_L21
M05_L36:
       call      qword ptr [7FF80D1A6910]
       int       3
M05_L37:
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF80D1A6898]
       jmp       near ptr M05_L24
M05_L38:
       mov       ecx,18
       call      qword ptr [7FF80D1A45B8]
       int       3
M05_L39:
       mov       rax,[rbx+8]
       xor       edx,edx
       mov       [rax+8],rdx
       mov       rcx,rsi
       call      qword ptr [7FF80D1A44F8]
       test      eax,eax
       je        short M05_L41
       mov       rbx,[rbx+10]
       mov       rcx,rsi
       call      qword ptr [7FF80D1A4510]
       mov       rdx,rax
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF80D1A4528]
       jmp       short M05_L42
M05_L40:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M05_L41:
       mov       rdi,[rbx+10]
       mov       rcx,rsi
       call      qword ptr [7FF80D1A4540]
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF80D1A4558]
       mov       rdx,rax
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FF80D1A4570]
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF80D1A4540]
       nop
M05_L42:
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+18],0FFFFFFFE
       xor       edx,edx
       mov       [rcx+8],rdx
       mov       [rcx+10],rdx
       add       rcx,20
       cmp       qword ptr [rcx],0
       jne       short M05_L44
       mov       rdx,231E8800230
       mov       rdx,[rdx]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M05_L43:
       nop
       add       rsp,78
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M05_L44:
       mov       rcx,[rcx]
       xor       edx,edx
       call      qword ptr [7FF80D1A6970]
       jmp       short M05_L43
       sub       rsp,28
       mov       rdx,rcx
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+18],0FFFFFFFE
       xor       eax,eax
       mov       [rcx+8],rax
       mov       [rcx+10],rax
       add       rcx,20
       call      qword ptr [7FF80D1A4288]
       lea       rax,[M05_L43]
       add       rsp,28
       ret
; Total bytes of code 1758
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FF850621D18]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M06_L01
       cmp       [rax],ecx
       jle       short M06_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M06_L03
M06_L00:
       add       rsp,20
       pop       rbx
       ret
M06_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M06_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M06_L00
M06_L02:
       cmp       [rax+4],edx
       jle       short M06_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M06_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M06_L03
       jmp       short M06_L00
M06_L03:
       mov       ecx,ebx
       lea       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.Int32, System.Private.CoreLib]].AsyncLazy_NoRecursionDetection()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,[rbx+8]
       test      rdx,rdx
       je        near ptr M00_L16
       lea       rcx,[rsi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsi+10]
       test      rax,rax
       jne       near ptr M00_L17
M00_L00:
       mov       rbx,[rsi+8]
       mov       rdx,rbx
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L19
       test      rbx,rbx
       je        short M00_L01
       mov       rcx,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt
       cmp       [rbx],rcx
       je        near ptr M00_L11
M00_L01:
       lea       rcx,[rsi+20]
       cmp       qword ptr [rcx],0
       jne       near ptr M00_L18
M00_L02:
       mov       rcx,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_System.Threading.Tasks.TaskCompletionSource<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       xor       ecx,ecx
       mov       [rax+8],rcx
       mov       [rax+10],rcx
       mov       [rax+18],rcx
       mov       dword ptr [rax+34],2000440
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+8]
       test      rcx,rcx
       je        near ptr M00_L21
       mov       rdx,rdi
       xor       r8d,r8d
       call      00007FF86CA021C0
       test      rax,rax
       jne       near ptr M00_L00
       mov       rcx,2444D801328
       mov       rsi,[rcx]
       test      rsi,rsi
       je        near ptr M00_L22
M00_L03:
       mov       rcx,gs:[58]
       mov       rcx,[rcx+48]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M00_L23
       mov       rcx,[rcx+240]
       mov       rax,[rcx+20]
       test      rax,rax
       je        near ptr M00_L23
M00_L04:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M00_L05
       call      qword ptr [7FF80D095470]; System.Threading.Thread.InitializeCurrentThread()
M00_L05:
       mov       rbx,[rax+8]
       test      rbx,rbx
       jne       near ptr M00_L24
       mov       rcx,2444D801330
       mov       rbx,[rcx]
M00_L06:
       test      rbx,rbx
       je        short M00_L07
       cmp       byte ptr [rbx+19],0
       je        near ptr M00_L25
M00_L07:
       mov       rcx,offset MT_System.Threading.QueueUserWorkItemCallbackDefaultContext<System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M00_L08:
       mov       rcx,2444D801340
       mov       rbx,[rcx]
       cmp       byte ptr [rbx+38],0
       jne       near ptr M00_L26
M00_L09:
       mov       rcx,[rbx+8]
       mov       rdx,[rcx+10]
       mov       r8,[rdx+8]
M00_L10:
       mov       esi,[rdx+0A0]
       mov       eax,esi
       and       eax,[rdx+18]
       cmp       eax,[r8+8]
       jae       near ptr M00_L28
       shl       rax,4
       lea       r14,[r8+rax+10]
       mov       eax,[r14+8]
       sub       eax,esi
       jne       short M00_L12
       lea       r10,[rdx+0A0]
       lea       r9d,[rsi+1]
       mov       eax,esi
       lock cmpxchg [r10],r9d
       cmp       eax,esi
       jne       short M00_L10
       mov       rcx,r14
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       inc       esi
       mov       [r14+8],esi
       jmp       short M00_L13
M00_L11:
       mov       rcx,rbx
       xor       edx,edx
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FF80D12FFA8]; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.Int32, System.Private.CoreLib]].WaitAsync(System.Threading.CancellationToken)
M00_L12:
       test      eax,eax
       jge       short M00_L10
       mov       rdx,rbp
       call      qword ptr [7FF80D1B7F78]
M00_L13:
       add       rbx,78
       mov       ecx,1
       xchg      ecx,[rbx]
       test      ecx,ecx
       jne       short M00_L14
       mov       rcx,2444D801368
       mov       rbx,[rcx]
       lea       rcx,[rbx+178]
       lock inc  dword ptr [rcx]
       mov       rcx,rbx
       call      qword ptr [7FF80D1B4558]; System.Threading.PortableThreadPool+WorkerThread.MaybeAddWorkingWorker(System.Threading.PortableThreadPool)
       cmp       dword ptr [rbx+17C],6
       jne       near ptr M00_L27
M00_L14:
       mov       rax,[rdi+10]
       mov       rax,[rax+8]
M00_L15:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L16:
       mov       ecx,1
       mov       rdx,7FF80D1A6C30
       call      qword ptr [7FF80CDBF210]
       mov       rcx,rax
       call      qword ptr [7FF80D1B7E70]
       int       3
M00_L17:
       jmp       short M00_L15
M00_L18:
       mov       rcx,[rcx]
       cmp       dword ptr [rcx+20],0
       je        near ptr M00_L02
       jmp       short M00_L20
M00_L19:
       jmp       short M00_L15
M00_L20:
       mov       rcx,[rsi+20]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FF80D12FED0]
M00_L21:
       call      qword ptr [7FF80D1B7DF8]
       int       3
M00_L22:
       mov       rcx,offset MT_System.Action<System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,2444D801320
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset System.Threading.Tasks.AsyncLazy`1+<>c[[System.Int32, System.Private.CoreLib]].<GetOrStartAttemptAsync>b__11_0(Attempt<Int32>)
       mov       [rsi+18],rcx
       mov       rcx,2444D801328
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L03
M00_L23:
       mov       ecx,4
       call      qword ptr [7FF80D1B7BE8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L04
M00_L24:
       xor       ecx,ecx
       cmp       byte ptr [rbx+18],0
       cmovne    rbx,rcx
       jmp       near ptr M00_L06
M00_L25:
       mov       rcx,offset MT_System.Threading.QueueUserWorkItemCallback<System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rsi
       mov       r8,rdi
       mov       r9,rbx
       call      qword ptr [7FF80D1B7F30]
       jmp       near ptr M00_L08
M00_L26:
       mov       rcx,2444D801358
       mov       rcx,[rcx]
       cmp       byte ptr [rcx+9D],0
       je        near ptr M00_L09
       mov       rcx,2444D801358
       mov       rcx,[rcx]
       mov       rdx,rbp
       call      qword ptr [7FF80D1B7F48]
       jmp       near ptr M00_L09
M00_L27:
       mov       rcx,rbx
       call      qword ptr [7FF80D1B4738]; System.Threading.PortableThreadPool+GateThread.EnsureRunningSlow(System.Threading.PortableThreadPool)
       jmp       near ptr M00_L14
M00_L28:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 968
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.Int32, System.Private.CoreLib]](System.Threading.Tasks.Task`1<Int32>)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       ecx,[rbx+34]
       and       ecx,11000000
       cmp       ecx,1000000
       jne       short M01_L01
M01_L00:
       mov       eax,[rbx+38]
       add       rsp,20
       pop       rbx
       ret
M01_L01:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF80D1B4AE0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 47
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M02_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M02_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
M02_L00:
       test      rax,rax
       je        short M02_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
       test      rax,rax
       je        short M02_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
       test      rax,rax
       jne       short M02_L03
M02_L01:
       xor       edx,edx
M02_L02:
       mov       rax,rdx
       ret
M02_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
       test      rax,rax
       je        short M02_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
       jmp       short M02_L00
; Total bytes of code 86
```
```assembly
; System.Threading.Thread.InitializeCurrentThread()
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
       xor       eax,eax
       mov       [rbp-40],rax
       lea       rcx,[rbp-40]
       mov       [rbp-0A0],rcx
       lea       rcx,[rbp-98]
       call      qword ptr [7FF850609030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FF850609038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FF85060AEB8]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FF850608FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
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
; Total bytes of code 133
```
```assembly
; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.Int32, System.Private.CoreLib]].WaitAsync(System.Threading.CancellationToken)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rdx
       test      rbx,rbx
       jne       short M04_L00
       mov       rax,[rcx+10]
       mov       rax,[rax+8]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       mov       rcx,[rcx+10]
       mov       rsi,[rcx+8]
       cmp       [rsi],sil
       mov       rcx,offset MT_System.TimeProvider
       call      qword ptr [7FF80CDB5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,2444D801478
       mov       r8,[r8]
       mov       r9,rbx
       mov       rcx,rsi
       mov       edx,0FFFFFFFF
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF80D1BC948]
; Total bytes of code 92
```
```assembly
; System.Threading.PortableThreadPool+WorkerThread.MaybeAddWorkingWorker(System.Threading.PortableThreadPool)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rax,[rcx+0B8]
       movsx     rdx,ax
       mov       r8,rax
       shr       r8,20
       movsx     r8,r8w
       cmp       edx,r8d
       jge       near ptr M05_L08
M05_L00:
       lea       r8d,[rdx+1]
       movsx     rbx,r8w
       mov       r8,rax
       shr       r8,10
       movsx     r8,r8w
       cmp       r8d,ebx
       jge       near ptr M05_L09
       mov       esi,ebx
M05_L01:
       test      ebx,ebx
       jle       near ptr M05_L10
       mov       r10d,ebx
M05_L02:
       mov       r9,rax
       and       r9,0FFFFFFFFFFFF0000
       movzx     r10d,r10w
       or        r10,r9
       test      esi,esi
       jle       near ptr M05_L11
       mov       r9d,esi
M05_L03:
       mov       r11,0FFFFFFFF0000FFFF
       and       r10,r11
       movzx     r9d,r9w
       shl       r9,10
       or        r10,r9
       lea       r9,[rcx+0B8]
       mov       [rsp+28],rax
       lock cmpxchg [r9],r10
       mov       r10,[rsp+28]
       cmp       rax,r10
       jne       near ptr M05_L17
       sub       esi,r8d
       sub       ebx,edx
       test      ebx,ebx
       jle       short M05_L07
       mov       rcx,2444D801370
       mov       rdi,[rcx]
       mov       rbp,[rdi+60]
M05_L04:
       mov       [rsp+30],rbp
       mov       ecx,ebx
       add       rcx,[rsp+30]
       mov       [rsp+30],rcx
       mov       r14d,[rsp+30]
       mov       r15,rbp
       shr       r15,20
       movzx     r15d,r15w
       mov       rcx,rbp
       shr       rcx,30
       movzx     ecx,cl
       add       r15d,ecx
       cmp       r14d,r15d
       ja        short M05_L12
M05_L05:
       sub       r14d,ecx
       mov       rcx,rbp
       shr       rcx,38
       movzx     ecx,cl
       sub       r14d,ecx
       test      r14d,r14d
       jg        short M05_L13
M05_L06:
       lea       rcx,[rdi+60]
       mov       rdx,[rsp+30]
       mov       rax,rbp
       lock cmpxchg [rcx],rdx
       cmp       rax,rbp
       jne       short M05_L15
       test      r14d,r14d
       jg        short M05_L16
M05_L07:
       test      esi,esi
       jg        short M05_L19
M05_L08:
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M05_L09:
       mov       esi,r8d
       jmp       near ptr M05_L01
M05_L10:
       xor       r10d,r10d
       jmp       near ptr M05_L02
M05_L11:
       xor       r9d,r9d
       jmp       near ptr M05_L03
M05_L12:
       mov       r14d,r15d
       jmp       short M05_L05
M05_L13:
       cmp       r14d,ebx
       jg        short M05_L18
M05_L14:
       lea       rcx,[rsp+30]
       mov       edx,r14d
       call      qword ptr [7FF80D1BC7C8]; System.Threading.LowLevelLifoSemaphore+Counts.AddUpToMaxCountOfWaitersSignaledToWake(UInt32)
       jmp       short M05_L06
M05_L15:
       mov       rbp,rax
       jmp       near ptr M05_L04
M05_L16:
       mov       rcx,rdi
       mov       edx,r14d
       call      qword ptr [7FF80D1B59F8]; System.Threading.LowLevelLifoSemaphore.ReleaseCore(Int32)
       jmp       short M05_L07
M05_L17:
       mov       r10,rax
       movsx     rdx,r10w
       mov       r8,r10
       shr       r8,20
       movsx     r8,r8w
       cmp       edx,r8d
       mov       rax,r10
       jl        near ptr M05_L00
       jmp       short M05_L08
M05_L18:
       mov       r14d,ebx
       jmp       short M05_L14
M05_L19:
       call      qword ptr [7FF80D1B4690]; System.Threading.PortableThreadPool+WorkerThread.CreateWorkerThread()
       dec       esi
       test      esi,esi
       jg        short M05_L19
       jmp       near ptr M05_L08
; Total bytes of code 435
```
```assembly
; System.Threading.Tasks.AsyncLazy`1+<>c[[System.Int32, System.Private.CoreLib]].<GetOrStartAttemptAsync>b__11_0(Attempt<Int32>)
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,70
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-40],ymm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       cmp       [rdx],dl
       mov       [rbp-40],rdx
       mov       dword ptr [rbp-30],0FFFFFFFF
       mov       rcx,gs:[58]
       mov       rcx,[rcx+48]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M06_L08
       mov       rcx,[rcx+240]
       mov       rax,[rcx+20]
       test      rax,rax
       je        near ptr M06_L08
M06_L00:
       mov       rbx,[rax+10]
       test      rbx,rbx
       jne       short M06_L01
       call      qword ptr [7FF80D095470]; System.Threading.Thread.InitializeCurrentThread()
       mov       rbx,rax
M06_L01:
       mov       [rbp-48],rbx
       mov       rdx,[rbx+8]
       mov       [rbp-50],rdx
       mov       rdx,[rbx+10]
       mov       [rbp-58],rdx
       lea       rcx,[rbp-40]
       call      qword ptr [7FF80D1B5218]; System.Threading.Tasks.AsyncLazy`1+Attempt+<RunAsync>d__4[[System.Int32, System.Private.CoreLib]].MoveNext()
       nop
       mov       rdx,[rbp-58]
       cmp       rdx,[rbx+10]
       je        short M06_L02
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
M06_L02:
       mov       rsi,[rbx+8]
       mov       rdx,[rbp-50]
       cmp       rdx,rsi
       je        short M06_L04
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M06_L03
       cmp       qword ptr [rsi+10],0
       jne       short M06_L07
M06_L03:
       cmp       qword ptr [rbp-50],0
       jne       short M06_L06
M06_L04:
       cmp       qword ptr [rbp-28],0
       je        short M06_L09
M06_L05:
       add       rsp,70
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M06_L06:
       mov       rdx,[rbp-50]
       cmp       qword ptr [rdx+10],0
       je        short M06_L04
M06_L07:
       mov       rcx,rsi
       mov       rdx,[rbp-50]
       call      qword ptr [7FF80D1B7C90]
       jmp       short M06_L04
M06_L08:
       mov       ecx,4
       call      qword ptr [7FF80D1B7BE8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M06_L00
M06_L09:
       lea       rcx,[rbp-28]
       call      qword ptr [7FF80D1B7E28]
       jmp       short M06_L05
       sub       rsp,28
       mov       rdx,[rbp-58]
       mov       rax,[rbp-48]
       cmp       rdx,[rax+10]
       je        short M06_L10
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-48]
M06_L10:
       mov       rsi,[rax+8]
       mov       rdx,[rbp-50]
       cmp       rdx,rsi
       je        short M06_L13
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M06_L11
       cmp       qword ptr [rsi+10],0
       jne       short M06_L12
M06_L11:
       cmp       qword ptr [rbp-50],0
       je        short M06_L13
       mov       rdx,[rbp-50]
       cmp       qword ptr [rdx+10],0
       je        short M06_L13
M06_L12:
       mov       rcx,rsi
       mov       rdx,[rbp-50]
       call      qword ptr [7FF80D1B7C90]
M06_L13:
       nop
       add       rsp,28
       ret
; Total bytes of code 368
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FF850621D18]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M07_L01
       cmp       [rax],ecx
       jle       short M07_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M07_L03
M07_L00:
       add       rsp,20
       pop       rbx
       ret
M07_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M07_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M07_L00
M07_L02:
       cmp       [rax+4],edx
       jle       short M07_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M07_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M07_L03
       jmp       short M07_L00
M07_L03:
       mov       ecx,ebx
       lea       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Threading.PortableThreadPool+GateThread.EnsureRunningSlow(System.Threading.PortableThreadPool)
       sub       rsp,28
       add       rcx,17C
       mov       eax,6
       xchg      eax,[rcx]
       cmp       eax,4
       je        short M08_L03
       test      al,4
       je        short M08_L02
M08_L00:
       mov       rcx,7FF80D2B6168
       call      CORINFO_HELP_COUNTPROFILE32
M08_L01:
       nop
       add       rsp,28
       ret
M08_L02:
       mov       rcx,7FF80D2B6164
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FF80D1B4750]; System.Threading.PortableThreadPool+GateThread.CreateGateThread()
       jmp       short M08_L00
M08_L03:
       mov       rcx,7FF80D2B6160
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,2444D801390
       mov       rcx,[rcx]
       call      qword ptr [7FF80D1BC3A8]
       jmp       short M08_L01
; Total bytes of code 107
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      dword ptr [rbx+34],1600000
       jne       short M09_L00
       mov       rcx,rbx
       mov       edx,0FFFFFFFF
       xor       r8d,r8d
       call      qword ptr [7FF80D1B4AF8]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M09_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M09_L03
M09_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M09_L04
M09_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M09_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M09_L01
       mov       rcx,rbx
       call      qword ptr [7FF80D1B7FC0]
       jmp       short M09_L01
M09_L04:
       test      sil,2
       jne       short M09_L05
       mov       rcx,rbx
       call      qword ptr [7FF80D1B7FD8]
M09_L05:
       mov       rcx,rbx
       call      qword ptr [7FF80D1BC960]
       jmp       short M09_L02
; Total bytes of code 124
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.Int32, System.Private.CoreLib]].Nito()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       rbx,[rcx+8]
       test      rbx,rbx
       je        near ptr M00_L05
       mov       rcx,offset MT_Nito.AsyncEx.AsyncLazy<System.Int32>+<>c__DisplayClass14_0
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Func<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset Nito.AsyncEx.AsyncLazy`1+<>c__DisplayClass14_0[[System.Int32, System.Private.CoreLib]].<RunOnThreadPool>b__0()
       mov       [rbx+18],rcx
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_System.Lazy<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.LazyHelper
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+10],8
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-28],rsi
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       mov       rcx,rsi
       call      00007FF86CA5E120
       test      eax,eax
       je        short M00_L01
M00_L00:
       mov       dword ptr [rbp-1C],1
       cmp       qword ptr [rdi+8],0
       je        short M00_L02
       mov       rcx,rdi
       call      qword ptr [7FF80D0A5860]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rbx,rax
       jmp       short M00_L03
M00_L01:
       mov       rcx,rsi
       call      qword ptr [7FF80D1C61A8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L00
M00_L02:
       mov       rbx,[rdi+18]
M00_L03:
       mov       rcx,rsi
       call      00007FF86CA5E040
       test      eax,eax
       jne       short M00_L06
M00_L04:
       mov       rax,rbx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M00_L05:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,10E
       mov       rdx,7FF80D1B6C28
       call      qword ptr [7FF80CDCF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80D0A75B8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FF80D1C79D8]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       short M00_L04
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M00_L07
       mov       rcx,[rbp-28]
       call      00007FF86CA5E040
       test      eax,eax
       je        short M00_L07
       mov       ecx,eax
       mov       rdx,[rbp-28]
       call      qword ptr [7FF80D1C79D8]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M00_L07:
       nop
       add       rsp,28
       ret
; Total bytes of code 384
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.Int32, System.Private.CoreLib]](System.Threading.Tasks.Task`1<Int32>)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       ecx,[rbx+34]
       and       ecx,11000000
       cmp       ecx,1000000
       jne       short M01_L01
M01_L00:
       mov       eax,[rbx+38]
       add       rsp,20
       pop       rbx
       ret
M01_L01:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF80D1C4D38]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 47
```
```assembly
; Nito.AsyncEx.AsyncLazy`1+<>c__DisplayClass14_0[[System.Int32, System.Private.CoreLib]].<RunOnThreadPool>b__0()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,[rcx+8]
       test      rbx,rbx
       je        near ptr M02_L16
       mov       rsi,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task<System.Int32>>
       mov       rcx,rsi
       call      qword ptr [7FF80D13FFC0]; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].get_Factory()
       cmp       [rax],al
       mov       rcx,1663F401338
       mov       rdi,[rcx]
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+10],rcx
       lea       rcx,[rsi+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,2008
       mov       [rsi+34],ecx
       mov       rcx,gs:[58]
       mov       rcx,[rcx+48]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M02_L15
       mov       rcx,[rcx+240]
       mov       rax,[rcx+20]
       test      rax,rax
       je        near ptr M02_L15
M02_L00:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M02_L01
       call      qword ptr [7FF80D0A5470]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       rbx,[rax+8]
       test      rbx,rbx
       je        short M02_L02
       xor       ecx,ecx
       cmp       byte ptr [rbx+18],0
       cmovne    rbx,rcx
       jmp       short M02_L03
M02_L02:
       mov       rcx,1663F401348
       mov       rbx,[rcx]
M02_L03:
       test      rbx,rbx
       je        short M02_L05
       mov       rcx,1663F401348
       cmp       rbx,[rcx]
       je        short M02_L06
       mov       rax,[rsi+28]
       test      rax,rax
       jne       short M02_L04
       mov       rcx,offset MT_System.Threading.Tasks.Task+ContingentProperties
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+3C],1
       lea       rcx,[rsi+28]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
M02_L04:
       lea       rcx,[rax+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M02_L06
M02_L05:
       or        dword ptr [rsi+34],20000000
M02_L06:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF80D1C41C8]; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
       mov       rcx,offset MT_System.Threading.Tasks.UnwrapPromise<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       movzx     edi,word ptr [rsi+34]
       and       edi,4
       test      edi,0FFFFFFBB
       jne       near ptr M02_L14
       test      dil,4
       je        short M02_L09
       mov       rcx,gs:[58]
       mov       rcx,[rcx+48]
       cmp       dword ptr [rcx+238],8
       jle       near ptr M02_L17
       mov       rcx,[rcx+240]
       mov       rax,[rcx+40]
       test      rax,rax
       je        near ptr M02_L17
M02_L07:
       mov       rbp,[rax+10]
       test      rbp,rbp
       je        short M02_L09
       mov       rax,[rbx+28]
       test      rax,rax
       jne       short M02_L08
       mov       rcx,offset MT_System.Threading.Tasks.Task+ContingentProperties
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [r14+3C],1
       lea       rcx,[rbx+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,r14
M02_L08:
       lea       rcx,[rax+30]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M02_L09:
       xor       ecx,ecx
       mov       [rbx+8],rcx
       mov       [rbx+10],rcx
       mov       [rbx+18],rcx
       test      edi,0FFFFFFA0
       jne       near ptr M02_L14
       mov       ecx,edi
       or        ecx,400
       or        ecx,2000000
       mov       [rbx+34],ecx
       mov       rcx,[rbx+28]
       test      rcx,rcx
       jne       near ptr M02_L18
M02_L10:
       mov       byte ptr [rbx+3D],1
       mov       rcx,1663F401358
       mov       rcx,[rcx]
       cmp       byte ptr [rcx+9D],0
       jne       near ptr M02_L19
M02_L11:
       cmp       byte ptr [7FF80CD0B074],0
       jne       near ptr M02_L20
M02_L12:
       test      dword ptr [rsi+34],1600000
       jne       near ptr M02_L21
       test      dword ptr [rsi+34],1600000
       jne       near ptr M02_L24
       cmp       qword ptr [rsi+20],0
       jne       near ptr M02_L23
       lea       rcx,[rsi+20]
       test      rcx,rcx
       je        near ptr M02_L22
       mov       rdx,rbx
       xor       r8d,r8d
       call      00007FF86CA021C0
       test      rax,rax
       jne       near ptr M02_L23
M02_L13:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L14:
       mov       ecx,2D
       call      qword ptr [7FF80CDCF348]
       int       3
M02_L15:
       mov       ecx,4
       call      qword ptr [7FF80D1C7CF0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M02_L00
M02_L16:
       mov       ecx,2E
       call      qword ptr [7FF80CDCFD38]
       int       3
M02_L17:
       mov       ecx,8
       call      qword ptr [7FF80D1C7CF0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M02_L07
M02_L18:
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M02_L10
       test      dil,4
       je        near ptr M02_L10
       test      byte ptr [rcx+34],8
       jne       near ptr M02_L10
       call      qword ptr [7FF80D1C7B88]
       jmp       near ptr M02_L10
M02_L19:
       mov       rcx,rbx
       call      qword ptr [7FF80D1C49F0]
       mov       edx,eax
       mov       rcx,1663F401358
       mov       rcx,[rcx]
       mov       r8,166252A9790
       xor       r9d,r9d
       call      qword ptr [7FF80D1C4A08]
       jmp       near ptr M02_L11
M02_L20:
       mov       rcx,rbx
       call      qword ptr [7FF80D1C4A20]
       jmp       near ptr M02_L12
M02_L21:
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF80D1C4A50]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].ProcessCompletedOuterTask(System.Threading.Tasks.Task)
       jmp       near ptr M02_L13
M02_L22:
       call      qword ptr [7FF80D1C7C60]
       int       3
M02_L23:
       mov       rcx,rsi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FF80D1C61C0]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M02_L13
M02_L24:
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF80D1BD318]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
       jmp       near ptr M02_L13
; Total bytes of code 871
```
```assembly
; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
M03_L00:
       push      rbp
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+40]
       mov       [rbp-10],rcx
       mov       [rbp+10],rcx
M03_L01:
       mov       rbx,[rcx+8]
       test      rbx,rbx
       je        short M03_L05
       mov       eax,[rbx+10]
       cmp       eax,8
       jne       short M03_L06
       mov       [rbp-20],rbx
       xor       eax,eax
       mov       [rbp-14],eax
       mov       rcx,rbx
       call      00007FF86CA5E120
       test      eax,eax
       je        short M03_L03
M03_L02:
       mov       dword ptr [rbp-14],1
       mov       rcx,[rbp+10]
       cmp       [rcx+8],rbx
       jne       short M03_L04
       mov       edx,2
       call      qword ptr [7FF80D0A5890]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M03_L04
M03_L03:
       mov       rcx,rbx
       call      qword ptr [7FF80D1C61A8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M03_L02
M03_L04:
       mov       rcx,rbx
       call      00007FF86CA5E040
       test      eax,eax
       jne       near ptr M03_L12
M03_L05:
       mov       rcx,[rbp+10]
       cmp       qword ptr [rcx+8],0
       je        near ptr M03_L13
       add       rsp,38
       pop       rbx
       pop       rbp
       jmp       qword ptr [7FF80D0A5860]
M03_L06:
       cmp       eax,8
       ja        short M03_L07
       mov       eax,eax
       lea       rdx,[7FF80CE47450]
       mov       edx,[rdx+rax*4]
       lea       r8,[M03_L01]
       add       rdx,r8
       jmp       rdx
M03_L07:
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF80D1CC2E8]
       int       3
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80D1CC288]
       jmp       short M03_L05
       mov       rcx,[rbp+10]
       xor       edx,edx
       call      qword ptr [7FF80D0A5890]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M03_L05
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+10]
       test      rax,rax
       je        short M03_L08
       jmp       short M03_L09
M03_L08:
       mov       rcx,rdx
       mov       rdx,7FF80D1F64A0
       call      qword ptr [7FF80CDCF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M03_L09:
       mov       rcx,[rax+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M03_L10
       jmp       short M03_L11
M03_L10:
       mov       rcx,rax
       mov       rdx,7FF80D1F6540
       call      qword ptr [7FF80CDCF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M03_L11:
       call      qword ptr [7FF80D1CC228]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80D1CC2A0]
       jmp       near ptr M03_L05
       mov       rcx,[rbp+10]
       mov       rdx,rbx
       call      qword ptr [7FF80D1CC2B8]
       jmp       near ptr M03_L05
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80D1CC2D0]
       jmp       near ptr M03_L05
       mov       rcx,[rbp+10]
       mov       rdx,rbx
       mov       r8d,1
       call      qword ptr [7FF80D0A5878]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M03_L05
M03_L12:
       mov       ecx,eax
       mov       rdx,rbx
       call      qword ptr [7FF80D1C79D8]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       near ptr M03_L05
M03_L13:
       mov       rax,[rcx+18]
       add       rsp,38
       pop       rbx
       pop       rbp
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-14],0
       je        short M03_L14
       mov       rcx,[rbp-20]
       call      00007FF86CA5E040
       test      eax,eax
       je        short M03_L14
       mov       ecx,eax
       mov       rdx,[rbp-20]
       call      qword ptr [7FF80D1C79D8]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M03_L14:
       nop
       add       rsp,28
       ret
; Total bytes of code 445
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
       sub       rsp,58
       vzeroupper
       lea       rbp,[rsp+90]
       mov       [rbp+10],rcx
       lea       rcx,[rbp-70]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rbx,rax
       mov       rcx,rsp
       mov       [rbp-58],rcx
       mov       rcx,rbp
       mov       [rbp-48],rcx
       lea       rcx,[rbp+10]
       mov       rax,7FF80CE08210
       mov       [rbp-60],rax
       lea       rax,[M04_L00]
       mov       [rbp-50],rax
       lea       rax,[rbp-70]
       mov       [rbx+8],rax
       mov       byte ptr [rbx+4],0
       mov       rax,7FF86CA5E560
       call      rax
M04_L00:
       mov       byte ptr [rbx+4],1
       cmp       dword ptr [7FF86CD13A90],0
       je        short M04_L01
       call      qword ptr [7FF86CD02648]; CORINFO_HELP_STOP_FOR_GC
M04_L01:
       mov       rax,[rbp-68]
       mov       [rbx+8],rax
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 154
```
```assembly
; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
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
       mov       [rbp+18],rdx
       mov       edx,ecx
       lea       rcx,[rbp+18]
       mov       [rbp-9C],rcx
       mov       [rbp-94],edx
       lea       rcx,[rbp-90]
       call      qword ptr [7FF850609030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rcx,[rbp-9C]
       mov       edx,[rbp-94]
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
; Total bytes of code 119
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      dword ptr [rbx+34],1600000
       jne       short M06_L00
       mov       rcx,rbx
       mov       edx,0FFFFFFFF
       xor       r8d,r8d
       call      qword ptr [7FF80D1C4D50]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M06_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M06_L03
M06_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M06_L04
M06_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M06_L01
       mov       rcx,rbx
       call      qword ptr [7FF80D1CC198]
       jmp       short M06_L01
M06_L04:
       test      sil,2
       jne       short M06_L05
       mov       rcx,rbx
       call      qword ptr [7FF80D1CC6F0]
M06_L05:
       mov       rcx,rbx
       call      qword ptr [7FF80D1CCE88]
       jmp       short M06_L02
; Total bytes of code 124
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.Int32, System.Private.CoreLib]].Nito_ExecuteOnCallingThread()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       rbx,[rcx+8]
       test      rbx,rbx
       je        near ptr M00_L05
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_System.Lazy<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.LazyHelper
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+10],8
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-28],rsi
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       mov       rcx,rsi
       call      00007FF86CA5E120
       test      eax,eax
       je        short M00_L01
M00_L00:
       mov       dword ptr [rbp-1C],1
       cmp       qword ptr [rdi+8],0
       je        short M00_L02
       mov       rcx,rdi
       call      qword ptr [7FF80D095860]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rbx,rax
       jmp       short M00_L03
M00_L01:
       mov       rcx,rsi
       call      qword ptr [7FF80D1B5E18]
       jmp       short M00_L00
M00_L02:
       mov       rbx,[rdi+18]
M00_L03:
       mov       rcx,rsi
       call      00007FF86CA5E040
       test      eax,eax
       jne       short M00_L06
M00_L04:
       mov       rax,rbx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M00_L05:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,10E
       mov       rdx,7FF80D1A6C28
       call      qword ptr [7FF80CDBF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80D0975B8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FF80D1B5DA0]
       jmp       short M00_L04
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M00_L07
       mov       rcx,[rbp-28]
       call      00007FF86CA5E040
       test      eax,eax
       je        short M00_L07
       mov       ecx,eax
       mov       rdx,[rbp-28]
       call      qword ptr [7FF80D1B5DA0]
M00_L07:
       nop
       add       rsp,28
       ret
; Total bytes of code 310
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.Int32, System.Private.CoreLib]](System.Threading.Tasks.Task`1<Int32>)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       ecx,[rbx+34]
       and       ecx,11000000
       cmp       ecx,1000000
       jne       short M01_L01
M01_L00:
       mov       eax,[rbx+38]
       add       rsp,20
       pop       rbx
       ret
M01_L01:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF80D1B5DD0]
       jmp       short M01_L00
; Total bytes of code 47
```
```assembly
; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
M02_L00:
       push      rbp
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+40]
       mov       [rbp-10],rcx
       mov       [rbp+10],rcx
M02_L01:
       mov       rbx,[rcx+8]
       test      rbx,rbx
       je        short M02_L05
       mov       eax,[rbx+10]
       cmp       eax,8
       jne       short M02_L06
       mov       [rbp-20],rbx
       xor       eax,eax
       mov       [rbp-14],eax
       mov       rcx,rbx
       call      00007FF86CA5E120
       test      eax,eax
       je        short M02_L03
M02_L02:
       mov       dword ptr [rbp-14],1
       mov       rcx,[rbp+10]
       cmp       [rcx+8],rbx
       jne       short M02_L04
       mov       edx,2
       call      qword ptr [7FF80D095890]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M02_L04
M02_L03:
       mov       rcx,rbx
       call      qword ptr [7FF80D1B5E18]
       jmp       short M02_L02
M02_L04:
       mov       rcx,rbx
       call      00007FF86CA5E040
       test      eax,eax
       jne       near ptr M02_L12
M02_L05:
       mov       rcx,[rbp+10]
       cmp       qword ptr [rcx+8],0
       je        near ptr M02_L13
       add       rsp,38
       pop       rbx
       pop       rbp
       jmp       qword ptr [7FF80D095860]
M02_L06:
       cmp       eax,8
       ja        short M02_L07
       mov       eax,eax
       lea       rdx,[7FF80CE2AFF0]
       mov       edx,[rdx+rax*4]
       lea       r8,[M02_L01]
       add       rdx,r8
       jmp       rdx
M02_L07:
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF80D1B5EF0]
       int       3
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80D1B5E90]
       jmp       short M02_L05
       mov       rcx,[rbp+10]
       xor       edx,edx
       call      qword ptr [7FF80D095890]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M02_L05
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+10]
       test      rax,rax
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rdx
       mov       rdx,7FF80D19D418
       call      qword ptr [7FF80CDBF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L09:
       mov       rcx,[rax+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M02_L10
       jmp       short M02_L11
M02_L10:
       mov       rcx,rax
       mov       rdx,7FF80D19D4B8
       call      qword ptr [7FF80CDBF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M02_L11:
       call      qword ptr [7FF80D1B5E30]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80D1B5EA8]
       jmp       near ptr M02_L05
       mov       rcx,[rbp+10]
       mov       rdx,rbx
       call      qword ptr [7FF80D1B5EC0]
       jmp       near ptr M02_L05
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80D1B5ED8]
       jmp       near ptr M02_L05
       mov       rcx,[rbp+10]
       mov       rdx,rbx
       mov       r8d,1
       call      qword ptr [7FF80D095878]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M02_L05
M02_L12:
       mov       ecx,eax
       mov       rdx,rbx
       call      qword ptr [7FF80D1B5DA0]
       jmp       near ptr M02_L05
M02_L13:
       mov       rax,[rcx+18]
       add       rsp,38
       pop       rbx
       pop       rbp
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-14],0
       je        short M02_L14
       mov       rcx,[rbp-20]
       call      00007FF86CA5E040
       test      eax,eax
       je        short M02_L14
       mov       ecx,eax
       mov       rdx,[rbp-20]
       call      qword ptr [7FF80D1B5DA0]
M02_L14:
       nop
       add       rsp,28
       ret
; Total bytes of code 445
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.Int32, System.Private.CoreLib]].VsThreading()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_Microsoft.VisualStudio.Threading.AsyncLazy<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rbx,[rbx+8]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M00_L00
       lea       rcx,[rsi+20]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+10],rcx
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF80D11FF18]; Microsoft.VisualStudio.Threading.AsyncLazy`1[[System.Int32, System.Private.CoreLib]].GetValueAsync(System.Threading.CancellationToken)
M00_L00:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,164
       mov       rdx,7FF80D196C38
       call      qword ptr [7FF80CDAF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80D0875B8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 158
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.Int32, System.Private.CoreLib]](System.Threading.Tasks.Task`1<Int32>)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       ecx,[rbx+34]
       and       ecx,11000000
       cmp       ecx,1000000
       jne       short M01_L01
M01_L00:
       mov       eax,[rbx+38]
       add       rsp,20
       pop       rbx
       ret
M01_L01:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF80D1CC210]
       jmp       short M01_L00
; Total bytes of code 47
```
```assembly
; Microsoft.VisualStudio.Threading.AsyncLazy`1[[System.Int32, System.Private.CoreLib]].GetValueAsync(System.Threading.CancellationToken)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,118
       lea       rbp,[rsp+150]
       xor       eax,eax
       mov       [rbp-0E8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu32 [rbp-0E0],zmm4
       vmovdqu32 [rbp-0A0],zmm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       rsi,rcx
       mov       rcx,offset MT_Microsoft.VisualStudio.Threading.AsyncLazy<System.Int32>+<>c__DisplayClass20_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0E0],rax
       lea       rcx,[rax+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+28]
       test      rcx,rcx
       jne       near ptr M02_L54
M02_L00:
       mov       rcx,[rsi+18]
       test      rcx,rcx
       jne       near ptr M02_L55
M02_L01:
       cmp       qword ptr [rsi+28],0
       jne       near ptr M02_L50
       mov       rcx,[rsi+8]
       test      rcx,rcx
       je        near ptr M02_L56
       call      00007FF86CA5DFD0
       test      eax,eax
       jne       near ptr M02_L57
       xor       ecx,ecx
       mov       rax,[rbp-0E0]
       mov       [rax+10],rcx
       mov       rdx,[rsi+8]
       mov       [rbp-0E8],rdx
       mov       [rbp-3C],ecx
       cmp       qword ptr [rbp-0E8],0
       je        near ptr M02_L27
       mov       rcx,[rbp-0E8]
       call      00007FF86CA5E120
       test      eax,eax
       je        near ptr M02_L28
M02_L02:
       mov       dword ptr [rbp-3C],1
       cmp       qword ptr [rsi+28],0
       jne       near ptr M02_L32
       cmp       qword ptr [rbp+18],0
       je        short M02_L03
       mov       rcx,[rbp+18]
       cmp       dword ptr [rcx+20],0
       jne       near ptr M02_L29
M02_L03:
       mov       rcx,offset MT_Microsoft.VisualStudio.Threading.InlineResumable
       call      CORINFO_HELP_NEWSFAST
       mov       r8,[rbp-0E0]
       lea       rcx,[r8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+20]
       mov       r8,[rbp-0E0]
       lea       rcx,[r8+18]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+20],rcx
       mov       rcx,offset MT_System.Func<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,[rbp-0E0]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset Microsoft.VisualStudio.Threading.AsyncLazy`1+<>c__DisplayClass20_0[[System.Int32, System.Private.CoreLib]].<GetValueAsync>b__0()
       mov       [rdi+18],rcx
       cmp       byte ptr [rsi+38],0
       jne       near ptr M02_L18
       cmp       qword ptr [rsi+18],0
       jne       near ptr M02_L30
M02_L04:
       mov       rcx,offset MT_Microsoft.VisualStudio.Threading.AsyncLocal<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,offset MT_System.Threading.AsyncLocal<System.Object>
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14,[rbx+8]
       mov       rcx,247C7401320
       mov       r15,[rcx]
       cmp       qword ptr [r14+8],0
       setne     r13b
       movzx     r13d,r13b
       mov       rcx,gs:[58]
       mov       rcx,[rcx+48]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M02_L31
       mov       rcx,[rcx+240]
       mov       r12,[rcx+20]
       test      r12,r12
       je        near ptr M02_L31
M02_L05:
       mov       rax,[r12+10]
       test      rax,rax
       jne       short M02_L06
       call      qword ptr [7FF80D085470]; System.Threading.Thread.InitializeCurrentThread()
M02_L06:
       mov       rax,[rax+8]
       mov       [rbp-0F0],rax
       xor       ecx,ecx
       mov       [rbp-48],rcx
       xor       r10d,r10d
       test      rax,rax
       je        short M02_L07
       mov       rcx,[rax+8]
       lea       r8,[rbp-48]
       mov       rdx,r14
       mov       r11,7FF80CCF0568
       call      qword ptr [r11]
       mov       [rbp-4C],eax
       mov       rax,[rbp-0F0]
       mov       r10d,[rbp-4C]
M02_L07:
       cmp       [rbp-48],r15
       je        near ptr M02_L17
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-5C],ecx
       test      rax,rax
       je        short M02_L08
       mov       [rbp-4C],r10d
       movzx     edx,byte ptr [rax+18]
       mov       [rbp-5C],edx
       test      r13d,r13d
       sete      r9b
       movzx     r9d,r9b
       mov       rcx,[rax+8]
       mov       rdx,r14
       mov       r8,r15
       mov       r11,7FF80CCF0560
       call      qword ptr [r11]
       mov       [rbp-0F8],rax
       mov       r8,[rbp-0F0]
       mov       r8,[r8+10]
       mov       [rbp-58],r8
       jmp       short M02_L09
M02_L08:
       mov       [rbp-4C],r10d
       mov       rcx,offset MT_System.Threading.AsyncLocalValueMap+OneElementAsyncLocalValueMap
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-110],rax
       lea       rcx,[rax+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-110]
       lea       rcx,[rax+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-110]
       mov       [rbp-0F8],rax
M02_L09:
       test      r13d,r13d
       je        short M02_L11
       cmp       dword ptr [rbp-4C],0
       jne       short M02_L11
       cmp       qword ptr [rbp-58],0
       je        short M02_L10
       mov       r8,[rbp-58]
       mov       r10d,[r8+8]
       mov       [rbp-60],r10d
       lea       r8d,[r10+1]
       lea       rdx,[rbp-58]
       mov       rcx,7FF80D1E1488
       call      qword ptr [7FF80CF8C5D0]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       edx,[rbp-60]
       mov       rcx,[rbp-58]
       mov       r8,r14
       call      qword ptr [7FF80CDA57B8]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M02_L11
M02_L10:
       mov       rcx,offset MT_System.Threading.IAsyncLocal[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rbp-108],rax
       lea       rcx,[rax+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-108]
       mov       [rbp-58],rax
M02_L11:
       mov       r12,[r12+10]
       test      r12,r12
       jne       short M02_L12
       call      qword ptr [7FF80D085470]; System.Threading.Thread.InitializeCurrentThread()
       mov       r12,rax
M02_L12:
       cmp       dword ptr [rbp-5C],0
       jne       short M02_L13
       mov       rcx,247C7401358
       mov       rax,[rbp-0F8]
       cmp       rax,[rcx]
       jne       short M02_L13
       xor       edx,edx
       jmp       short M02_L14
M02_L13:
       mov       rcx,offset MT_System.Threading.ExecutionContext
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       [rbp-100],rdx
       mov       rax,[rbp-58]
       mov       [rbp-118],rax
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-0F8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-100]
       lea       rcx,[rdx+10]
       mov       rdx,[rbp-118]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-100]
       mov       ecx,[rbp-5C]
       mov       [rdx+18],cl
M02_L14:
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      r13d,r13d
       je        short M02_L17
       mov       rdx,[rbp-48]
       test      rdx,rdx
       jne       near ptr M02_L25
       xor       r13d,r13d
M02_L15:
       mov       rcx,[r14]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       r12,r15
       cmp       [r12],rcx
       je        short M02_L16
       mov       rdx,r15
       call      qword ptr [7FF80CDA58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r12,rax
M02_L16:
       mov       rax,[r14+8]
       mov       [rbp-0D8],r13
       mov       [rbp-0D0],r12
       mov       byte ptr [rbp-0C8],0
       lea       rdx,[rbp-0D8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
M02_L17:
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       [rbp-58],rcx
       lea       rcx,[rsi+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       nop
M02_L18:
       cmp       qword ptr [rsi+10],0
       jne       short M02_L20
       mov       rcx,offset Microsoft.VisualStudio.Threading.AsyncLazy`1+<>c__DisplayClass20_0[[System.Int32, System.Private.CoreLib]].<GetValueAsync>b__0()
       cmp       [rdi+18],rcx
       jne       near ptr M02_L23
       mov       rcx,[rdi+8]
       xor       eax,eax
       mov       [rbp-70],rax
       mov       [rbp-90],rcx
       mov       dword ptr [rbp-78],0FFFFFFFF
       lea       rcx,[rbp-90]
       call      qword ptr [7FF80D1C5380]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[Microsoft.VisualStudio.Threading.AsyncLazy`1+<>c__DisplayClass20_0+<<GetValueAsync>b__0>d[[System.Int32, System.Private.CoreLib]], Microsoft.VisualStudio.Threading]](<<GetValueAsync>b__0>d<Int32> ByRef)
       mov       rdx,[rbp-70]
       test      rdx,rdx
       je        short M02_L22
M02_L19:
       lea       rcx,[rsi+28]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L24
M02_L20:
       mov       rcx,[rsi+10]
       cmp       [rcx],cl
       xor       edx,edx
       mov       [rsp+20],edx
       mov       rdx,rdi
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FF80D1CC708]
       lea       rcx,[rsi+30]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lock or   dword ptr [rsp],0
       mov       rcx,[rsi+30]
       cmp       [rcx],cl
       call      qword ptr [7FF80D1CC798]
       mov       rdx,rax
       test      rdx,rdx
       je        short M02_L21
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Int32>
       cmp       [rdx],rcx
       je        short M02_L21
       mov       rdx,rax
       call      qword ptr [7FF80CF84D20]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rdx,rax
M02_L21:
       lea       rcx,[rsi+28]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M02_L24
M02_L22:
       lea       rcx,[rbp-70]
       call      qword ptr [7FF80D1CC4E0]
       mov       rdx,rax
       jmp       near ptr M02_L19
M02_L23:
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       rdx,rax
       jmp       near ptr M02_L19
M02_L24:
       call      M02_L64
       jmp       short M02_L32
M02_L25:
       mov       rcx,[r14]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       r13,rdx
       cmp       [r13],rcx
       je        short M02_L26
       call      qword ptr [7FF80CDA58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r13,rax
M02_L26:
       jmp       near ptr M02_L15
M02_L27:
       xor       ecx,ecx
       call      qword ptr [7FF80D1CC348]
       int       3
M02_L28:
       mov       rcx,[rbp-0E8]
       call      qword ptr [7FF80D1CC498]
       jmp       near ptr M02_L02
M02_L29:
       lea       rcx,[rbp+18]
       call      qword ptr [7FF80D1CC4B0]
       int       3
M02_L30:
       mov       rcx,7FF80D20C2F0
       call      qword ptr [7FF80D1C4288]
       jmp       near ptr M02_L04
M02_L31:
       mov       ecx,4
       call      qword ptr [7FF80D1CC300]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r12,rax
       jmp       near ptr M02_L05
M02_L32:
       mov       rcx,[rbp-0E8]
       call      00007FF86CA5E040
       test      eax,eax
       jne       near ptr M02_L58
M02_L33:
       mov       rdx,[rbp-0E0]
       mov       rcx,[rdx+10]
       test      rcx,rcx
       je        near ptr M02_L50
       mov       byte ptr [rcx+18],1
       mov       rbx,[rcx+8]
       xor       eax,eax
       mov       [rcx+8],rax
       mov       rsi,[rcx+10]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+48]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M02_L59
       mov       rcx,[rcx+240]
       mov       r12,[rcx+20]
       test      r12,r12
       je        near ptr M02_L59
M02_L34:
       mov       rax,[r12+10]
       test      rax,rax
       jne       short M02_L35
       call      qword ptr [7FF80D085470]; System.Threading.Thread.InitializeCurrentThread()
M02_L35:
       mov       rdi,[rax+10]
       mov       rax,[r12+10]
       test      rax,rax
       jne       short M02_L36
       call      qword ptr [7FF80D085470]; System.Threading.Thread.InitializeCurrentThread()
M02_L36:
       lea       rcx,[rax+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-128],rdi
       test      rbx,rbx
       je        near ptr M02_L48
       mov       rcx,offset System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1+AsyncStateMachineBox`1[[System.Int32, System.Private.CoreLib],[Microsoft.VisualStudio.Threading.AsyncLazy`1+<>c__DisplayClass20_0+<<GetValueAsync>b__0>d[[System.Int32, System.Private.CoreLib]], Microsoft.VisualStudio.Threading]].MoveNext()
       cmp       [rbx+18],rcx
       jne       near ptr M02_L47
       mov       rbx,[rbx+8]
       mov       rcx,247C7401350
       mov       rsi,[rcx]
       movzx     r14d,byte ptr [rsi+9D]
       test      r14d,r14d
       jne       near ptr M02_L43
M02_L37:
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        near ptr M02_L42
       mov       rdx,247C7401360
       mov       rdx,[rdx]
       mov       r8,rbx
       call      qword ptr [7FF80D1C5BA8]; System.Threading.ExecutionContext.RunInternal(System.Threading.ExecutionContext, System.Threading.ContextCallback, System.Object)
M02_L38:
       mov       ecx,[rbx+34]
       test      ecx,1600000
       je        short M02_L41
       cmp       byte ptr [7FF80CCEB074],0
       jne       near ptr M02_L44
M02_L39:
       xor       ecx,ecx
       mov       [rbx+40],rcx
       mov       [rbx+48],rcx
       mov       [rbx+50],rcx
       mov       [rbx+58],rcx
       mov       [rbx+60],rcx
       mov       [rbx+68],rcx
       mov       [rbx+10],rcx
       mov       rcx,rsi
       cmp       byte ptr [rcx+9D],0
       je        short M02_L41
       movzx     eax,byte ptr [rcx+9D]
       mov       edx,[rcx+98]
       mov       rcx,[rcx+80]
       test      eax,eax
       je        short M02_L41
       test      edx,edx
       je        short M02_L40
       cmp       edx,3
       jl        short M02_L41
M02_L40:
       test      rcx,rcx
       je        short M02_L45
       test      ecx,100
       jne       short M02_L45
M02_L41:
       test      r14d,r14d
       je        short M02_L48
       jmp       short M02_L46
M02_L42:
       lea       rcx,[rbx+40]
       call      qword ptr [7FF80D1C53E0]; Microsoft.VisualStudio.Threading.AsyncLazy`1+<>c__DisplayClass20_0+<<GetValueAsync>b__0>d[[System.Int32, System.Private.CoreLib]].MoveNext()
       jmp       near ptr M02_L38
M02_L43:
       mov       rcx,rbx
       call      qword ptr [7FF80D1C5B78]
       mov       edx,eax
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FF80D1C5B90]
       jmp       near ptr M02_L37
M02_L44:
       mov       rcx,rbx
       call      qword ptr [7FF80D1C5DA0]
       jmp       near ptr M02_L39
M02_L45:
       mov       rcx,rbx
       call      qword ptr [7FF80D085608]; System.GC.SuppressFinalize(System.Object)
       jmp       short M02_L41
M02_L46:
       mov       rcx,rsi
       mov       edx,2
       call      qword ptr [7FF80D1C5BF0]
       jmp       short M02_L48
M02_L47:
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       nop
M02_L48:
       mov       rax,[r12+10]
       test      rax,rax
       jne       short M02_L49
       call      qword ptr [7FF80D085470]; System.Threading.Thread.InitializeCurrentThread()
M02_L49:
       lea       rcx,[rax+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M02_L50:
       mov       rsi,[rbp+10]
       lock or   dword ptr [rsp],0
       mov       rcx,[rsi+30]
       test      rcx,rcx
       jne       near ptr M02_L60
       xor       eax,eax
M02_L51:
       test      rax,rax
       jne       short M02_L53
       mov       rbx,[rsi+28]
       mov       rcx,[rbp+18]
       mov       [rbp-0C0],rcx
       test      rbx,rbx
       je        near ptr M02_L61
       cmp       qword ptr [rbp-0C0],0
       jne       near ptr M02_L62
M02_L52:
       mov       rax,rbx
M02_L53:
       add       rsp,118
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L54:
       test      dword ptr [rcx+34],1600000
       jne       near ptr M02_L01
       jmp       near ptr M02_L00
M02_L55:
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF80D1CC768]
       test      rax,rax
       je        near ptr M02_L01
       call      qword ptr [7FF80D1CC780]
       mov       rcx,rax
       mov       r8,247C74013D8
       mov       r8,[r8]
       mov       rdx,247A52A9448
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rcx,rax
       xor       eax,eax
       test      rcx,rcx
       cmove     rcx,rax
       call      qword ptr [7FF80D1C4168]
       int       3
M02_L56:
       mov       ecx,707
       mov       rdx,7FF80CCE4000
       call      qword ptr [7FF80CDAF210]
       mov       rcx,rax
       call      qword ptr [7FF80D1CC348]
       int       3
M02_L57:
       call      qword ptr [7FF80D1CC780]
       mov       rcx,rax
       mov       r8,247C74013D8
       mov       r8,[r8]
       mov       rdx,247A52A9448
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rcx,rax
       xor       eax,eax
       test      rcx,rcx
       cmove     rcx,rax
       call      qword ptr [7FF80D1C4168]
       int       3
M02_L58:
       mov       ecx,eax
       mov       rdx,[rbp-0E8]
       call      qword ptr [7FF80D1CC360]
       jmp       near ptr M02_L33
M02_L59:
       mov       ecx,4
       call      qword ptr [7FF80D1CC300]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r12,rax
       jmp       near ptr M02_L34
M02_L60:
       mov       r8,[rbp+18]
       xor       edx,edx
       call      qword ptr [7FF80D1C4258]
       jmp       near ptr M02_L51
M02_L61:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,170F
       mov       rdx,7FF80D196C38
       call      qword ptr [7FF80CDAF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80D0875B8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L62:
       test      dword ptr [rbx+34],1600000
       jne       near ptr M02_L52
       lea       rcx,[rbp-0C0]
       call      qword ptr [7FF80D1C5E48]
       test      eax,eax
       je        short M02_L63
       mov       rcx,[rbp-0C0]
       call      qword ptr [7FF80D1C5E00]
       jmp       near ptr M02_L53
M02_L63:
       mov       rcx,rbx
       mov       rdx,[rbp-0C0]
       call      qword ptr [7FF80D1C5DD0]
       jmp       near ptr M02_L53
M02_L64:
       sub       rsp,28
       mov       rsi,[rbp+10]
       mov       rcx,[rsi+18]
       test      rcx,rcx
       je        near ptr M02_L83
       mov       rbx,[rcx+8]
       cmp       qword ptr [rbx+8],0
       setne     r14b
       movzx     r14d,r14b
       mov       rcx,gs:[58]
       mov       rcx,[rcx+48]
       cmp       dword ptr [rcx+238],4
       jle       short M02_L65
       mov       rcx,[rcx+240]
       mov       r12,[rcx+20]
       test      r12,r12
       jne       short M02_L66
M02_L65:
       mov       ecx,4
       call      qword ptr [7FF80D1CC300]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r12,rax
M02_L66:
       mov       rax,[r12+10]
       test      rax,rax
       jne       short M02_L67
       call      qword ptr [7FF80D085470]; System.Threading.Thread.InitializeCurrentThread()
M02_L67:
       mov       r15,[rax+8]
       xor       ecx,ecx
       mov       [rbp-98],rcx
       xor       r13d,r13d
       test      r15,r15
       je        short M02_L68
       mov       rcx,[r15+8]
       lea       r8,[rbp-98]
       mov       rdx,rbx
       mov       r11,7FF80CCF0580
       call      qword ptr [r11]
       mov       r13d,eax
M02_L68:
       cmp       qword ptr [rbp-98],0
       je        near ptr M02_L82
       xor       ecx,ecx
       mov       [rbp-0A0],rcx
       mov       [rbp-0A4],ecx
       test      r15,r15
       je        short M02_L69
       movzx     edi,byte ptr [r15+18]
       test      r14d,r14d
       sete      r9b
       movzx     r9d,r9b
       mov       rcx,[r15+8]
       mov       rdx,rbx
       mov       r11,7FF80CCF0578
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       [rbp-120],rax
       mov       r8,[r15+10]
       mov       [rbp-0A0],r8
       jmp       short M02_L72
M02_L69:
       test      r14d,r14d
       jne       short M02_L70
       mov       rcx,247C7401358
       mov       r15,[rcx]
       jmp       short M02_L71
M02_L70:
       mov       rcx,offset MT_System.Threading.AsyncLocalValueMap+OneElementAsyncLocalValueMap
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[rbp-0B8]
       mov       r8,rbx
       mov       rdx,7FF80D2028E8
       xor       r9d,r9d
       call      qword ptr [7FF80D1CC270]
       lea       rdi,[r15+8]
       lea       rsi,[rbp-0B8]
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
M02_L71:
       mov       [rbp-120],r15
       mov       edi,[rbp-0A4]
M02_L72:
       test      r14d,r14d
       je        short M02_L74
       test      r13d,r13d
       jne       short M02_L74
       cmp       qword ptr [rbp-0A0],0
       jne       short M02_L73
       mov       rcx,offset MT_System.Threading.IAsyncLocal[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r15,rax
       lea       rcx,[r15+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-0A0],r15
       jmp       short M02_L74
M02_L73:
       mov       r8,[rbp-0A0]
       mov       r15d,[r8+8]
       lea       r8d,[r15+1]
       lea       rdx,[rbp-0A0]
       mov       rcx,7FF80D1E1488
       call      qword ptr [7FF80CF8C5D0]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       edx,r15d
       mov       rcx,[rbp-0A0]
       mov       r8,rbx
       call      qword ptr [7FF80CDA57B8]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M02_L74:
       mov       r12,[r12+10]
       test      r12,r12
       jne       short M02_L75
       call      qword ptr [7FF80D085470]; System.Threading.Thread.InitializeCurrentThread()
       mov       r12,rax
M02_L75:
       test      edi,edi
       jne       short M02_L76
       mov       rcx,247C7401358
       mov       rax,[rbp-120]
       cmp       rax,[rcx]
       je        short M02_L77
M02_L76:
       mov       rcx,offset MT_System.Threading.ExecutionContext
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r13,[rbp-0A0]
       lea       rcx,[r15+8]
       mov       rdx,[rbp-120]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r15+18],dil
       mov       rdx,r15
       jmp       short M02_L78
M02_L77:
       xor       edx,edx
M02_L78:
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      r14d,r14d
       je        short M02_L82
       mov       rdx,[rbp-98]
       test      rdx,rdx
       je        short M02_L80
       mov       rcx,[rbx]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rdi,rdx
       cmp       [rdi],rcx
       je        short M02_L79
       call      qword ptr [7FF80CDA58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
M02_L79:
       jmp       short M02_L81
M02_L80:
       xor       edi,edi
M02_L81:
       mov       rax,[rbx+8]
       mov       [rbp-0D8],rdi
       xor       edx,edx
       mov       [rbp-0D0],rdx
       mov       byte ptr [rbp-0C8],0
       lea       rdx,[rbp-0D8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
M02_L82:
       xor       ecx,ecx
       mov       [rbp-98],rcx
       mov       [rbp-0A0],rcx
M02_L83:
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M02_L85
       cmp       qword ptr [rbp-0E8],0
       jne       short M02_L84
       xor       ecx,ecx
       call      qword ptr [7FF80D1CC348]
       int       3
M02_L84:
       mov       rcx,[rbp-0E8]
       call      00007FF86CA5E040
       test      eax,eax
       je        short M02_L85
       mov       ecx,eax
       mov       rdx,[rbp-0E8]
       call      qword ptr [7FF80D1CC360]
M02_L85:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       mov       rcx,gs:[58]
       mov       rcx,[rcx+48]
       cmp       dword ptr [rcx+238],4
       jle       short M02_L86
       mov       rcx,[rcx+240]
       mov       r12,[rcx+20]
       test      r12,r12
       jne       short M02_L87
M02_L86:
       mov       ecx,4
       call      qword ptr [7FF80D1CC300]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r12,rax
M02_L87:
       mov       rdi,[r12+10]
       test      rdi,rdi
       jne       short M02_L88
       call      qword ptr [7FF80D085470]; System.Threading.Thread.InitializeCurrentThread()
       mov       rdi,rax
M02_L88:
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-128]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       ret
; Total bytes of code 3330
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.Int32, System.Private.CoreLib]].LazyOfTask()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_System.Lazy<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,[rbx+8]
       test      rdx,rdx
       je        short M00_L00
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.LazyHelper
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+10],8
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [rsi+8],0
       je        short M00_L01
       mov       rcx,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF80D0A5860]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
M00_L00:
       mov       ecx,1687
       mov       rdx,7FF80CD04000
       call      qword ptr [7FF80CDCF210]
       mov       rcx,rax
       call      qword ptr [7FF80D1C7C00]
       int       3
M00_L01:
       mov       rax,[rsi+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 143
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.Int32, System.Private.CoreLib]](System.Threading.Tasks.Task`1<Int32>)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       ecx,[rbx+34]
       and       ecx,11000000
       cmp       ecx,1000000
       jne       short M01_L01
M01_L00:
       mov       eax,[rbx+38]
       add       rsp,20
       pop       rbx
       ret
M01_L01:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF80D1C4CD8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 47
```
```assembly
; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
M02_L00:
       push      rbp
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+40]
       mov       [rbp-10],rcx
       mov       [rbp+10],rcx
M02_L01:
       mov       rbx,[rcx+8]
       test      rbx,rbx
       je        short M02_L04
       mov       eax,[rbx+10]
       cmp       eax,8
       jne       short M02_L05
       mov       [rbp-20],rbx
       xor       eax,eax
       mov       [rbp-14],eax
       mov       rcx,rbx
       call      00007FF86CA5E120
       test      eax,eax
       jne       short M02_L02
       mov       rcx,rbx
       call      qword ptr [7FF80D1C55D8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
M02_L02:
       mov       dword ptr [rbp-14],1
       mov       rcx,[rbp+10]
       cmp       [rcx+8],rbx
       jne       short M02_L03
       mov       edx,2
       call      qword ptr [7FF80D0A5890]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       nop
M02_L03:
       mov       rcx,rbx
       call      00007FF86CA5E040
       test      eax,eax
       jne       near ptr M02_L11
M02_L04:
       mov       rcx,[rbp+10]
       cmp       qword ptr [rcx+8],0
       je        near ptr M02_L12
       add       rsp,38
       pop       rbx
       pop       rbp
       jmp       qword ptr [7FF80D0A5860]
M02_L05:
       cmp       eax,8
       ja        short M02_L06
       mov       eax,eax
       lea       rdx,[7FF80CE42BE0]
       mov       edx,[rdx+rax*4]
       lea       r8,[M02_L01]
       add       rdx,r8
       jmp       rdx
M02_L06:
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF80D1C7CF0]
       int       3
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80D1C7F00]
       jmp       short M02_L04
       mov       rcx,[rbp+10]
       xor       edx,edx
       call      qword ptr [7FF80D0A5890]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M02_L04
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+10]
       test      rax,rax
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rcx,rdx
       mov       rdx,7FF80D1AF560
       call      qword ptr [7FF80CDCF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L08:
       mov       rcx,[rax+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rax
       mov       rdx,7FF80D1AF600
       call      qword ptr [7FF80CDCF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M02_L10:
       call      qword ptr [7FF80D1C7EA0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80D1C7F18]
       jmp       near ptr M02_L04
       mov       rcx,[rbp+10]
       mov       rdx,rbx
       call      qword ptr [7FF80D1C7F30]
       jmp       near ptr M02_L04
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80D1C7F48]
       jmp       near ptr M02_L04
       mov       rcx,[rbp+10]
       mov       rdx,rbx
       mov       r8d,1
       call      qword ptr [7FF80D0A5878]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M02_L04
M02_L11:
       mov       ecx,eax
       mov       rdx,rbx
       call      qword ptr [7FF80D1C60B8]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       near ptr M02_L04
M02_L12:
       mov       rax,[rcx+18]
       add       rsp,38
       pop       rbx
       pop       rbp
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-14],0
       je        short M02_L13
       mov       rcx,[rbp-20]
       call      00007FF86CA5E040
       test      eax,eax
       je        short M02_L13
       mov       ecx,eax
       mov       rdx,[rbp-20]
       call      qword ptr [7FF80D1C60B8]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M02_L13:
       nop
       add       rsp,28
       ret
; Total bytes of code 442
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      dword ptr [rbx+34],1600000
       jne       short M03_L00
       mov       rcx,rbx
       mov       edx,0FFFFFFFF
       xor       r8d,r8d
       call      qword ptr [7FF80D1C4CF0]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M03_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M03_L03
M03_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M03_L04
M03_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M03_L01
       mov       rcx,rbx
       call      qword ptr [7FF80D1CC1E0]
       jmp       short M03_L01
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FF80D1C7FC0]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FF80D1CC4B0]
       jmp       short M03_L02
; Total bytes of code 124
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.Int32, System.Private.CoreLib]].LazyOfTask_TaskRun()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_System.Lazy<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,[rbx+10]
       test      rdx,rdx
       je        short M00_L00
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.LazyHelper
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+10],8
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [rsi+8],0
       je        short M00_L01
       mov       rcx,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF80D0A5860]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
M00_L00:
       mov       ecx,1687
       mov       rdx,7FF80CD04000
       call      qword ptr [7FF80CDCF210]
       mov       rcx,rax
       call      qword ptr [7FF80D1C7E70]
       int       3
M00_L01:
       mov       rax,[rsi+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 143
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.Int32, System.Private.CoreLib]](System.Threading.Tasks.Task`1<Int32>)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       ecx,[rbx+34]
       and       ecx,11000000
       cmp       ecx,1000000
       jne       short M01_L01
M01_L00:
       mov       eax,[rbx+38]
       add       rsp,20
       pop       rbx
       ret
M01_L01:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF80D1C4CF0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 47
```
```assembly
; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
M02_L00:
       push      rbp
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+40]
       mov       [rbp-10],rcx
       mov       [rbp+10],rcx
M02_L01:
       mov       rbx,[rcx+8]
       test      rbx,rbx
       je        short M02_L04
       mov       eax,[rbx+10]
       cmp       eax,8
       jne       short M02_L05
       mov       [rbp-20],rbx
       xor       eax,eax
       mov       [rbp-14],eax
       mov       rcx,rbx
       call      00007FF86CA5E120
       test      eax,eax
       jne       short M02_L02
       mov       rcx,rbx
       call      qword ptr [7FF80D1C6628]; System.Threading.Monitor.Enter_Slowpath(System.Object)
M02_L02:
       mov       dword ptr [rbp-14],1
       mov       rcx,[rbp+10]
       cmp       [rcx+8],rbx
       jne       short M02_L03
       mov       edx,2
       call      qword ptr [7FF80D0A5890]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       nop
M02_L03:
       mov       rcx,rbx
       call      00007FF86CA5E040
       test      eax,eax
       jne       near ptr M02_L11
M02_L04:
       mov       rcx,[rbp+10]
       cmp       qword ptr [rcx+8],0
       je        near ptr M02_L12
       add       rsp,38
       pop       rbx
       pop       rbp
       jmp       qword ptr [7FF80D0A5860]
M02_L05:
       cmp       eax,8
       ja        short M02_L06
       mov       eax,eax
       lea       rdx,[7FF80CE490B0]
       mov       edx,[rdx+rax*4]
       lea       r8,[M02_L01]
       add       rdx,r8
       jmp       rdx
M02_L06:
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF80D1CC4C8]
       int       3
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80D1CC5E8]
       jmp       short M02_L04
       mov       rcx,[rbp+10]
       xor       edx,edx
       call      qword ptr [7FF80D0A5890]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M02_L04
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+10]
       test      rax,rax
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rcx,rdx
       mov       rdx,7FF80D211EF8
       call      qword ptr [7FF80CDCF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L08:
       mov       rcx,[rax+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rax
       mov       rdx,7FF80D211F98
       call      qword ptr [7FF80CDCF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M02_L10:
       call      qword ptr [7FF80D1CC588]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80D1CC600]
       jmp       near ptr M02_L04
       mov       rcx,[rbp+10]
       mov       rdx,rbx
       call      qword ptr [7FF80D1CC618]
       jmp       near ptr M02_L04
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80D1CC630]
       jmp       near ptr M02_L04
       mov       rcx,[rbp+10]
       mov       rdx,rbx
       mov       r8d,1
       call      qword ptr [7FF80D0A5878]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M02_L04
M02_L11:
       mov       ecx,eax
       mov       rdx,rbx
       call      qword ptr [7FF80D1C6640]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       near ptr M02_L04
M02_L12:
       mov       rax,[rcx+18]
       add       rsp,38
       pop       rbx
       pop       rbp
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-14],0
       je        short M02_L13
       mov       rcx,[rbp-20]
       call      00007FF86CA5E040
       test      eax,eax
       je        short M02_L13
       mov       ecx,eax
       mov       rdx,[rbp-20]
       call      qword ptr [7FF80D1C6640]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M02_L13:
       nop
       add       rsp,28
       ret
; Total bytes of code 442
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      dword ptr [rbx+34],1600000
       jne       short M03_L00
       mov       rcx,rbx
       mov       edx,0FFFFFFFF
       xor       r8d,r8d
       call      qword ptr [7FF80D1C4D08]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M03_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M03_L03
M03_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M03_L04
M03_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M03_L01
       mov       rcx,rbx
       call      qword ptr [7FF80D1CCDE0]
       jmp       short M03_L01
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FF80D1CC9F0]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FF80D1CD200]
       jmp       short M03_L02
; Total bytes of code 124
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.Int32, System.Private.CoreLib]].AsyncLazy()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,[rbx+8]
       test      rdx,rdx
       je        short M00_L00
       lea       rcx,[rsi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsi+10]
       test      rax,rax
       jne       short M00_L01
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF80D14FF18]; System.Threading.Tasks.AsyncLazy`1[[System.Int32, System.Private.CoreLib]].GetOrStartAttemptAsync(System.Threading.CancellationToken)
M00_L00:
       mov       ecx,1
       mov       rdx,7FF80D1C6C20
       call      qword ptr [7FF80CDDF210]
       mov       rcx,rax
       call      qword ptr [7FF80D1DCAC8]
       int       3
M00_L01:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 109
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.Int32, System.Private.CoreLib]](System.Threading.Tasks.Task`1<Int32>)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       ecx,[rbx+34]
       and       ecx,11000000
       cmp       ecx,1000000
       jne       short M01_L01
M01_L00:
       mov       eax,[rbx+38]
       add       rsp,20
       pop       rbx
       ret
M01_L01:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF80D1D4BA0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 47
```
```assembly
; System.Threading.Tasks.AsyncLazy`1[[System.Int32, System.Private.CoreLib]].GetOrStartAttemptAsync(System.Threading.CancellationToken)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
M02_L00:
       mov       rdi,[rbx+8]
       mov       rdx,rdi
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M02_L19
       test      rdi,rdi
       je        short M02_L01
       mov       rcx,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt
       cmp       [rdi],rcx
       je        near ptr M02_L11
M02_L01:
       lea       rcx,[rbx+20]
       cmp       qword ptr [rcx],0
       jne       near ptr M02_L18
M02_L02:
       mov       rcx,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Threading.Tasks.TaskCompletionSource<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       xor       ecx,ecx
       mov       [rax+8],rcx
       mov       [rax+10],rcx
       mov       [rax+18],rcx
       mov       dword ptr [rax+34],2000440
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+8]
       test      rcx,rcx
       je        near ptr M02_L21
       mov       rdx,rbp
       xor       r8d,r8d
       call      00007FF86CA021C0
       test      rax,rax
       jne       near ptr M02_L00
       mov       rcx,13D1B001328
       mov       rbx,[rcx]
       test      rbx,rbx
       je        near ptr M02_L22
M02_L03:
       mov       rcx,gs:[58]
       mov       rcx,[rcx+48]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M02_L23
       mov       rcx,[rcx+240]
       mov       rax,[rcx+20]
       test      rax,rax
       je        near ptr M02_L23
M02_L04:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M02_L05
       call      qword ptr [7FF80D0B5470]; System.Threading.Thread.InitializeCurrentThread()
M02_L05:
       mov       rdi,[rax+8]
       test      rdi,rdi
       je        near ptr M02_L13
       xor       ecx,ecx
       cmp       byte ptr [rdi+18],0
       cmovne    rdi,rcx
M02_L06:
       test      rdi,rdi
       je        short M02_L07
       cmp       byte ptr [rdi+19],0
       je        near ptr M02_L24
M02_L07:
       mov       rcx,offset MT_System.Threading.QueueUserWorkItemCallbackDefaultContext<System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M02_L08:
       mov       rcx,13D1B001340
       mov       rbx,[rcx]
       cmp       byte ptr [rbx+38],0
       jne       near ptr M02_L25
M02_L09:
       mov       rcx,[rbx+8]
       mov       rdx,[rcx+10]
       mov       r8,[rdx+8]
M02_L10:
       mov       edi,[rdx+0A0]
       mov       eax,edi
       and       eax,[rdx+18]
       cmp       eax,[r8+8]
       jae       near ptr M02_L28
       shl       rax,4
       lea       r15,[r8+rax+10]
       mov       eax,[r15+8]
       sub       eax,edi
       jne       near ptr M02_L14
       lea       r10,[rdx+0A0]
       lea       r9d,[rdi+1]
       mov       eax,edi
       lock cmpxchg [r10],r9d
       cmp       eax,edi
       jne       short M02_L10
       mov       rcx,r15
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       inc       edi
       mov       [r15+8],edi
       jmp       near ptr M02_L15
M02_L11:
       mov       rcx,rdi
       call      qword ptr [7FF80D14FFD8]
       test      eax,eax
       je        short M02_L12
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,14D3F4B8BD8
       call      qword ptr [7FF80D0B7D50]
       mov       rcx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       qword ptr [7FF80D14FF90]
M02_L12:
       mov       rcx,rdi
       mov       rdx,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       qword ptr [7FF80D1D4000]; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.Int32, System.Private.CoreLib]].WaitAsync(System.Threading.CancellationToken)
M02_L13:
       mov       rcx,13D1B001330
       mov       rdi,[rcx]
       jmp       near ptr M02_L06
M02_L14:
       test      eax,eax
       jge       near ptr M02_L10
       mov       rdx,r14
       call      qword ptr [7FF80D1DC930]
M02_L15:
       add       rbx,78
       mov       ecx,1
       xchg      ecx,[rbx]
       test      ecx,ecx
       jne       short M02_L16
       mov       rcx,13D1B001368
       mov       rbx,[rcx]
       lea       rcx,[rbx+178]
       lock inc  dword ptr [rcx]
       mov       rcx,rbx
       call      qword ptr [7FF80D1D45A0]; System.Threading.PortableThreadPool+WorkerThread.MaybeAddWorkingWorker(System.Threading.PortableThreadPool)
       cmp       dword ptr [rbx+17C],6
       jne       near ptr M02_L26
M02_L16:
       test      rsi,rsi
       jne       near ptr M02_L27
       mov       rcx,[rbp+10]
       mov       rax,[rcx+8]
M02_L17:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L18:
       mov       rcx,[rcx]
       cmp       dword ptr [rcx+20],0
       je        near ptr M02_L02
       jmp       short M02_L20
M02_L19:
       jmp       short M02_L17
M02_L20:
       mov       rcx,[rbx+20]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       qword ptr [7FF80D14FED0]
M02_L21:
       call      qword ptr [7FF80D1DC648]
       int       3
M02_L22:
       mov       rcx,offset MT_System.Action<System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,13D1B001320
       mov       rdx,[rcx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset System.Threading.Tasks.AsyncLazy`1+<>c[[System.Int32, System.Private.CoreLib]].<GetOrStartAttemptAsync>b__11_0(Attempt<Int32>)
       mov       [rbx+18],rcx
       mov       rcx,13D1B001328
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L03
M02_L23:
       mov       ecx,4
       call      qword ptr [7FF80D1DC660]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M02_L04
M02_L24:
       mov       rcx,offset MT_System.Threading.QueueUserWorkItemCallback<System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rbx
       mov       r8,rbp
       mov       r9,rdi
       call      qword ptr [7FF80D1DCED0]
       jmp       near ptr M02_L08
M02_L25:
       mov       rcx,13D1B001358
       mov       rcx,[rcx]
       cmp       byte ptr [rcx+9D],0
       je        near ptr M02_L09
       mov       rcx,13D1B001358
       mov       rcx,[rcx]
       mov       rdx,r14
       call      qword ptr [7FF80D1DC918]
       jmp       near ptr M02_L09
M02_L26:
       mov       rcx,rbx
       call      qword ptr [7FF80D1D4780]; System.Threading.PortableThreadPool+GateThread.EnsureRunningSlow(System.Threading.PortableThreadPool)
       jmp       near ptr M02_L16
M02_L27:
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+8]
       cmp       [rbx],bl
       mov       rcx,offset MT_System.TimeProvider
       call      qword ptr [7FF80CDD5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,13D1B0014F8
       mov       r8,[r8]
       mov       r9,rsi
       mov       rcx,rbx
       mov       edx,0FFFFFFFF
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       qword ptr [7FF80D1DD5A8]
M02_L28:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1053
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      dword ptr [rbx+34],1600000
       jne       short M03_L00
       mov       rcx,rbx
       mov       edx,0FFFFFFFF
       xor       r8d,r8d
       call      qword ptr [7FF80D1D4BB8]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M03_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M03_L03
M03_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M03_L04
M03_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M03_L01
       mov       rcx,rbx
       call      qword ptr [7FF80D1DCE10]
       jmp       short M03_L01
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FF80D1DCF00]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FF80D1DD5C0]
       jmp       short M03_L02
; Total bytes of code 124
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.Int32, System.Private.CoreLib]].AsyncLazy_NoHop()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,78
       lea       rbp,[rsp+90]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-50],ymm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       xor       eax,eax
       mov       [rbp-20],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,[rbx+8]
       test      rdx,rdx
       je        near ptr M00_L14
       lea       rcx,[rsi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsi+10]
       test      rax,rax
       jne       near ptr M00_L15
M00_L00:
       mov       rbx,[rsi+8]
       mov       rdx,rbx
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L17
       test      rbx,rbx
       je        short M00_L01
       mov       rcx,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt
       cmp       [rbx],rcx
       je        near ptr M00_L05
M00_L01:
       lea       rcx,[rsi+20]
       cmp       qword ptr [rcx],0
       jne       near ptr M00_L16
M00_L02:
       mov       rcx,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_System.Threading.Tasks.TaskCompletionSource<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       xor       ecx,ecx
       mov       [rax+8],rcx
       mov       [rax+10],rcx
       mov       [rax+18],rcx
       mov       dword ptr [rax+34],2000440
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+8]
       test      rcx,rcx
       je        near ptr M00_L19
       mov       rdx,rdi
       xor       r8d,r8d
       call      00007FF86CA021C0
       test      rax,rax
       jne       near ptr M00_L00
       xor       ecx,ecx
       mov       [rbp-30],rcx
       mov       [rbp-50],rdi
       mov       dword ptr [rbp-38],0FFFFFFFF
       mov       rcx,gs:[58]
       mov       rcx,[rcx+48]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M00_L20
       mov       rcx,[rcx+240]
       mov       rax,[rcx+20]
       test      rax,rax
       je        near ptr M00_L20
M00_L03:
       mov       rsi,[rax+10]
       test      rsi,rsi
       jne       short M00_L04
       call      qword ptr [7FF80D095470]; System.Threading.Thread.InitializeCurrentThread()
       mov       rsi,rax
M00_L04:
       mov       [rbp-58],rsi
       mov       rdx,[rsi+8]
       mov       [rbp-60],rdx
       mov       rdx,[rsi+10]
       mov       [rbp-68],rdx
       jmp       short M00_L07
M00_L05:
       mov       rcx,rbx
       call      qword ptr [7FF80D12FF78]
       test      eax,eax
       je        short M00_L06
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,207A52A8BD8
       call      qword ptr [7FF80D097D50]
       mov       rcx,rbx
       call      qword ptr [7FF80D12FF48]
       jmp       short M00_L12
M00_L06:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF80D12FF90]; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.Int32, System.Private.CoreLib]].WaitAsync(System.Threading.CancellationToken)
       jmp       short M00_L12
M00_L07:
       lea       rcx,[rbp-50]
       call      qword ptr [7FF80D1B4150]; System.Threading.Tasks.AsyncLazy`1+Attempt+<RunAsync>d__4[[System.Int32, System.Private.CoreLib]].MoveNext()
       nop
       mov       rdx,[rbp-68]
       cmp       rdx,[rsi+10]
       je        short M00_L08
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L08:
       mov       rcx,[rsi+8]
       mov       rbx,rcx
       mov       rdx,[rbp-60]
       cmp       rdx,rbx
       je        short M00_L10
       lea       rcx,[rsi+8]
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
       mov       rax,[rdi+10]
       mov       rax,[rax+8]
M00_L12:
       add       rsp,78
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M00_L13:
       mov       rdx,[rbp-60]
       cmp       qword ptr [rdx+10],0
       je        short M00_L10
       jmp       short M00_L21
M00_L14:
       mov       ecx,1
       mov       rdx,7FF80D1A6C28
       call      qword ptr [7FF80CDBF210]
       mov       rcx,rax
       call      qword ptr [7FF80D1BC930]
       int       3
M00_L15:
       jmp       short M00_L12
M00_L16:
       mov       rcx,[rcx]
       cmp       dword ptr [rcx+20],0
       je        near ptr M00_L02
       jmp       short M00_L18
M00_L17:
       jmp       short M00_L12
M00_L18:
       mov       rcx,[rsi+20]
       call      qword ptr [7FF80D12FED0]
       jmp       short M00_L12
M00_L19:
       call      qword ptr [7FF80D1BC510]
       int       3
M00_L20:
       mov       ecx,4
       call      qword ptr [7FF80D1BC5B8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L03
M00_L21:
       mov       rcx,rbx
       mov       rdx,[rbp-60]
       call      qword ptr [7FF80D1BC390]
       jmp       near ptr M00_L10
M00_L22:
       lea       rcx,[rbp-30]
       call      qword ptr [7FF80D1BCB10]
       jmp       near ptr M00_L11
       sub       rsp,28
       mov       rdx,[rbp-68]
       mov       rax,[rbp-58]
       cmp       rdx,[rax+10]
       je        short M00_L23
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-58]
M00_L23:
       mov       rdi,[rax+8]
       mov       rdx,[rbp-60]
       cmp       rdx,rdi
       je        short M00_L26
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M00_L24
       cmp       qword ptr [rdi+10],0
       jne       short M00_L25
M00_L24:
       cmp       qword ptr [rbp-60],0
       je        short M00_L26
       mov       rdx,[rbp-60]
       cmp       qword ptr [rdx+10],0
       je        short M00_L26
M00_L25:
       mov       rcx,rdi
       mov       rdx,[rbp-60]
       call      qword ptr [7FF80D1BC390]
M00_L26:
       nop
       add       rsp,28
       ret
; Total bytes of code 818
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.Int32, System.Private.CoreLib]](System.Threading.Tasks.Task`1<Int32>)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       ecx,[rbx+34]
       and       ecx,11000000
       cmp       ecx,1000000
       jne       short M01_L01
M01_L00:
       mov       eax,[rbx+38]
       add       rsp,20
       pop       rbx
       ret
M01_L01:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF80D1B56C8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 47
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       jne       short M02_L01
M02_L00:
       mov       rax,rdx
       ret
M02_L01:
       cmp       [rdx],rcx
       je        short M02_L00
       mov       rax,[rdx]
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L00
M02_L02:
       test      rax,rax
       je        short M02_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L00
       test      rax,rax
       je        short M02_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L00
       test      rax,rax
       je        short M02_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L00
       test      rax,rax
       je        short M02_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L00
       jmp       short M02_L02
M02_L03:
       xor       edx,edx
       jmp       short M02_L00
; Total bytes of code 88
```
```assembly
; System.Threading.Thread.InitializeCurrentThread()
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
       xor       eax,eax
       mov       [rbp-40],rax
       lea       rcx,[rbp-40]
       mov       [rbp-0A0],rcx
       lea       rcx,[rbp-98]
       call      qword ptr [7FF850609030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FF850609038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FF85060AEB8]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FF850608FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
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
; Total bytes of code 133
```
```assembly
; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.Int32, System.Private.CoreLib]].WaitAsync(System.Threading.CancellationToken)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rdx
       test      rbx,rbx
       jne       short M04_L00
       mov       rax,[rcx+10]
       mov       rax,[rax+8]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       mov       rcx,[rcx+10]
       mov       rsi,[rcx+8]
       cmp       [rsi],sil
       mov       rcx,offset MT_System.TimeProvider
       call      qword ptr [7FF80CDB5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,207E24014D0
       mov       r8,[r8]
       mov       r9,rbx
       mov       rcx,rsi
       mov       edx,0FFFFFFFF
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF80D1BD0B0]
; Total bytes of code 92
```
```assembly
; System.Threading.Tasks.AsyncLazy`1+Attempt+<RunAsync>d__4[[System.Int32, System.Private.CoreLib]].MoveNext()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,78
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu32 [rbp-80],zmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp+10],rcx
       mov       eax,[rcx+18]
       mov       rbx,[rcx]
       test      eax,eax
       je        near ptr M05_L18
       mov       rax,207E2401320
       mov       rsi,[rax]
       mov       rdi,rsi
       mov       rax,gs:[58]
       mov       rax,[rax+48]
       cmp       dword ptr [rax+238],4
       jle       near ptr M05_L21
       mov       rax,[rax+240]
       mov       r14,[rax+20]
       test      r14,r14
       je        near ptr M05_L21
M05_L00:
       mov       rax,[r14+10]
       test      rax,rax
       jne       short M05_L01
       call      qword ptr [7FF80D095470]; System.Threading.Thread.InitializeCurrentThread()
M05_L01:
       mov       r8,[rax+8]
       test      r8,r8
       je        short M05_L02
       mov       rcx,[r8+8]
       lea       r8,[rbp-50]
       mov       rdx,rdi
       mov       r11,7FF80CD00558
       call      qword ptr [r11]
       mov       rdx,[rbp-50]
       jmp       short M05_L03
M05_L02:
       xor       edx,edx
M05_L03:
       xor       eax,eax
       mov       [rbp-50],rax
       mov       rdi,rdx
       test      rdi,rdi
       je        short M05_L04
       mov       rax,offset MT_System.Threading.Tasks.AsyncLazyAttemptFrame
       cmp       [rdi],rax
       jne       near ptr M05_L22
M05_L04:
       mov       rcx,offset MT_System.Threading.Tasks.AsyncLazyAttemptFrame
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [rsi+8],0
       setne     dil
       movzx     edi,dil
       mov       rax,[r14+10]
       test      rax,rax
       jne       short M05_L05
       call      qword ptr [7FF80D095470]; System.Threading.Thread.InitializeCurrentThread()
M05_L05:
       mov       r13,[rax+8]
       xor       ecx,ecx
       mov       [rbp-58],rcx
       xor       r12d,r12d
       test      r13,r13
       je        short M05_L06
       mov       rcx,[r13+8]
       lea       r8,[rbp-58]
       mov       rdx,rsi
       mov       r11,7FF80CD00570
       call      qword ptr [r11]
       mov       r12d,eax
M05_L06:
       cmp       [rbp-58],r15
       je        near ptr M05_L15
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       [rbp-64],ecx
       test      r13,r13
       jne       short M05_L07
       mov       rcx,offset MT_System.Threading.AsyncLocalValueMap+OneElementAsyncLocalValueMap
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rcx,[r13+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-88],r13
       jmp       short M05_L08
M05_L07:
       movzx     eax,byte ptr [r13+18]
       mov       [rbp-64],eax
       test      edi,edi
       sete      r9b
       movzx     r9d,r9b
       mov       rcx,[r13+8]
       mov       rdx,rsi
       mov       r8,r15
       mov       r11,7FF80CD00568
       call      qword ptr [r11]
       mov       [rbp-88],rax
       mov       r8,[r13+10]
       mov       [rbp-60],r8
M05_L08:
       test      edi,edi
       je        short M05_L10
       test      r12d,r12d
       jne       short M05_L10
       cmp       qword ptr [rbp-60],0
       je        short M05_L09
       mov       r8,[rbp-60]
       mov       r13d,[r8+8]
       lea       r8d,[r13+1]
       lea       rdx,[rbp-60]
       mov       rcx,7FF80D1ACB60
       call      qword ptr [7FF80CF9C5D0]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       edx,r13d
       mov       rcx,[rbp-60]
       mov       r8,rsi
       call      qword ptr [7FF80CDB57B8]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M05_L10
M05_L09:
       mov       rcx,offset MT_System.Threading.IAsyncLocal[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r13,rax
       lea       rcx,[r13+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-60],r13
M05_L10:
       mov       r14,[r14+10]
       test      r14,r14
       jne       short M05_L11
       call      qword ptr [7FF80D095470]; System.Threading.Thread.InitializeCurrentThread()
       mov       r14,rax
M05_L11:
       mov       r13d,[rbp-64]
       test      r13d,r13d
       jne       short M05_L12
       mov       rcx,207E2401328
       mov       rax,[rbp-88]
       cmp       rax,[rcx]
       jne       short M05_L12
       xor       edx,edx
       jmp       short M05_L13
M05_L12:
       mov       rcx,offset MT_System.Threading.ExecutionContext
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rax,[rbp-60]
       mov       [rbp-90],rax
       lea       rcx,[r12+8]
       mov       rdx,[rbp-88]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r12+10]
       mov       rdx,[rbp-90]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r12+18],r13b
       mov       rdx,r12
M05_L13:
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      edi,edi
       je        short M05_L15
       mov       rdx,[rbp-58]
       test      rdx,rdx
       jne       near ptr M05_L17
       xor       ecx,ecx
M05_L14:
       mov       rax,[rsi+8]
       mov       [rbp-80],rcx
       mov       [rbp-78],r15
       mov       byte ptr [rbp-70],0
       lea       rdx,[rbp-80]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
M05_L15:
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-60],rcx
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       mov       rdx,r15
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,rbx
       call      qword ptr [7FF80D1B41C8]; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.Int32, System.Private.CoreLib]].InvokeFactory()
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+10]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+10]
       cmp       [rdx],dl
       mov       [rbp-48],rdx
       mov       dword ptr [rbp-40],2
       test      byte ptr [rbp-40],4
       jne       short M05_L16
       mov       rdx,[rbp-48]
       test      dword ptr [rdx+34],1600000
       jne       short M05_L19
M05_L16:
       xor       edx,edx
       mov       [rcx+18],edx
       lea       rcx,[rcx+28]
       mov       rdx,[rbp-48]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       edx,[rbp-40]
       mov       rcx,[rbp+10]
       mov       [rcx+30],edx
       lea       rdx,[rcx+20]
       call      qword ptr [7FF80D1B5158]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].GetStateMachineBox[[System.Threading.Tasks.AsyncLazy`1+Attempt+<RunAsync>d__4[[System.Int32, System.Private.CoreLib]], AsyncLazy.Ablation.NoHop]](<RunAsync>d__4<Int32> ByRef, System.Threading.Tasks.Task`1<System.Threading.Tasks.VoidTaskResult> ByRef)
       mov       rdx,rax
       lea       rcx,[rbp-48]
       call      qword ptr [7FF80D1B51B8]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].AwaitUnsafeOnCompleted[[System.Runtime.CompilerServices.ConfiguredTaskAwaitable+ConfiguredTaskAwaiter, System.Private.CoreLib]](ConfiguredTaskAwaiter ByRef, System.Runtime.CompilerServices.IAsyncStateMachineBox)
       jmp       near ptr M05_L29
M05_L17:
       mov       rcx,rdx
       mov       rax,offset MT_System.Threading.Tasks.AsyncLazyAttemptFrame
       cmp       [rcx],rax
       jne       short M05_L23
       jmp       near ptr M05_L14
M05_L18:
       mov       rcx,[rbp+10]
       vmovdqu   xmm0,xmmword ptr [rcx+28]
       vmovdqu   xmmword ptr [rbp-48],xmm0
       xor       edx,edx
       mov       [rcx+28],rdx
       mov       [rcx+30],rdx
       mov       dword ptr [rcx+18],0FFFFFFFF
       mov       rcx,[rbp+10]
M05_L19:
       mov       rdx,[rbp-48]
       mov       eax,[rbp-40]
       mov       r8d,[rdx+34]
       and       r8d,11000000
       cmp       r8d,1000000
       jne       short M05_L24
M05_L20:
       mov       rdx,[rcx+8]
       xor       eax,eax
       mov       [rdx+8],rax
       mov       rdx,[rcx+10]
       mov       rcx,rbx
       call      qword ptr [7FF80D1B4258]; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.Int32, System.Private.CoreLib]].Complete(System.Threading.Tasks.Task`1<Int32>)
       jmp       short M05_L25
M05_L21:
       mov       ecx,4
       call      qword ptr [7FF80D1BC5B8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r14,rax
       jmp       near ptr M05_L00
M05_L22:
       mov       rcx,rax
       call      qword ptr [7FF80CDB6328]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M05_L23:
       mov       rcx,rax
       call      qword ptr [7FF80CDB6328]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M05_L24:
       mov       rcx,rdx
       mov       edx,eax
       call      qword ptr [7FF80D1B56C8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       mov       rcx,[rbp+10]
       jmp       short M05_L20
M05_L25:
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+18],0FFFFFFFE
       xor       eax,eax
       mov       [rcx+8],rax
       mov       [rcx+10],rax
       add       rcx,20
       mov       rbx,[rcx]
       test      rbx,rbx
       je        near ptr M05_L31
       mov       rcx,207E2401330
       mov       rcx,[rcx]
       cmp       byte ptr [rcx+9D],0
       jne       near ptr M05_L32
M05_L26:
       mov       eax,[rbx+34]
       mov       [rbp-68],eax
       test      eax,5600000
       jne       near ptr M05_L34
       lea       rcx,[rbx+34]
       mov       edx,eax
       or        edx,4000000
       lock cmpxchg [rcx],edx
       cmp       eax,[rbp-68]
       jne       near ptr M05_L33
M05_L27:
       mov       byte ptr [rbx+38],0
       lea       rcx,[rbx+34]
       mov       eax,[rbx+34]
       or        eax,1000000
       xchg      eax,[rcx]
       mov       rsi,[rbx+28]
       test      rsi,rsi
       je        short M05_L28
       mov       rcx,rbx
       call      qword ptr [7FF80D1BC6F0]
       mov       rcx,[rsi+10]
       test      rcx,rcx
       jne       near ptr M05_L35
M05_L28:
       lea       rcx,[rbx+20]
       test      rcx,rcx
       je        near ptr M05_L36
       mov       rdx,207E2400218
       mov       rdx,[rdx]
       call      00007FF86CA0C330
       test      rax,rax
       jne       short M05_L30
M05_L29:
       add       rsp,78
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M05_L30:
       mov       rcx,rbx
       mov       rdx,rax
       call      qword ptr [7FF80D1B5C38]; System.Threading.Tasks.Task.RunContinuations(System.Object)
       jmp       short M05_L29
M05_L31:
       mov       rdx,207E2400230
       mov       rdx,[rdx]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M05_L29
M05_L32:
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF80D1B5AD0]
       mov       edx,eax
       mov       rcx,207E2401330
       mov       rcx,[rcx]
       mov       r8d,1
       call      qword ptr [7FF80D1BC8B8]
       jmp       near ptr M05_L26
M05_L33:
       mov       rcx,rbx
       mov       edx,4000000
       mov       r8d,5600000
       call      qword ptr [7FF80D1BC6D8]
       test      eax,eax
       jne       near ptr M05_L27
M05_L34:
       mov       ecx,18
       call      qword ptr [7FF80D1B5F08]
       int       3
M05_L35:
       call      qword ptr [7FF80D1BD038]
       jmp       near ptr M05_L28
M05_L36:
       call      qword ptr [7FF80D1BC510]
       int       3
       sub       rsp,28
       mov       rdx,rcx
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+18],0FFFFFFFE
       xor       eax,eax
       mov       [rcx+8],rax
       mov       [rcx+10],rax
       add       rcx,20
       call      qword ptr [7FF80D1B4288]
       lea       rax,[M05_L29]
       add       rsp,28
       ret
; Total bytes of code 1445
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FF850621D18]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M06_L01
       cmp       [rax],ecx
       jle       short M06_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M06_L03
M06_L00:
       add       rsp,20
       pop       rbx
       ret
M06_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M06_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M06_L00
M06_L02:
       cmp       [rax+4],edx
       jle       short M06_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M06_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M06_L03
       jmp       short M06_L00
M06_L03:
       mov       ecx,ebx
       lea       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      dword ptr [rbx+34],1600000
       jne       short M07_L00
       mov       rcx,rbx
       mov       edx,0FFFFFFFF
       xor       r8d,r8d
       call      qword ptr [7FF80D1B56E0]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M07_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M07_L03
M07_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M07_L04
M07_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M07_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M07_L01
       mov       rcx,rbx
       call      qword ptr [7FF80D1BCB58]
       jmp       short M07_L01
M07_L04:
       test      sil,2
       jne       short M07_L05
       mov       rcx,rbx
       call      qword ptr [7FF80D1BCBD0]
M07_L05:
       mov       rcx,rbx
       call      qword ptr [7FF80D1BD320]
       jmp       short M07_L02
; Total bytes of code 124
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.Int32, System.Private.CoreLib]].AsyncLazy_NoRecursionDetection()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,[rbx+8]
       test      rdx,rdx
       je        near ptr M00_L16
       lea       rcx,[rsi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsi+10]
       test      rax,rax
       jne       near ptr M00_L17
M00_L00:
       mov       rbx,[rsi+8]
       mov       rdx,rbx
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L19
       test      rbx,rbx
       je        short M00_L01
       mov       rcx,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt
       cmp       [rbx],rcx
       je        near ptr M00_L11
M00_L01:
       lea       rcx,[rsi+20]
       cmp       qword ptr [rcx],0
       jne       near ptr M00_L18
M00_L02:
       mov       rcx,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_System.Threading.Tasks.TaskCompletionSource<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       xor       ecx,ecx
       mov       [rax+8],rcx
       mov       [rax+10],rcx
       mov       [rax+18],rcx
       mov       dword ptr [rax+34],2000440
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+8]
       test      rcx,rcx
       je        near ptr M00_L21
       mov       rdx,rdi
       xor       r8d,r8d
       call      00007FF86CA021C0
       test      rax,rax
       jne       near ptr M00_L00
       mov       rcx,2335D001328
       mov       rsi,[rcx]
       test      rsi,rsi
       je        near ptr M00_L22
M00_L03:
       mov       rcx,gs:[58]
       mov       rcx,[rcx+48]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M00_L23
       mov       rcx,[rcx+240]
       mov       rax,[rcx+20]
       test      rax,rax
       je        near ptr M00_L23
M00_L04:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M00_L05
       call      qword ptr [7FF80D0B5470]; System.Threading.Thread.InitializeCurrentThread()
M00_L05:
       mov       rbx,[rax+8]
       test      rbx,rbx
       jne       near ptr M00_L24
       mov       rcx,2335D001330
       mov       rbx,[rcx]
M00_L06:
       test      rbx,rbx
       je        short M00_L07
       cmp       byte ptr [rbx+19],0
       je        near ptr M00_L25
M00_L07:
       mov       rcx,offset MT_System.Threading.QueueUserWorkItemCallbackDefaultContext<System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M00_L08:
       mov       rcx,2335D001340
       mov       rbx,[rcx]
       cmp       byte ptr [rbx+38],0
       jne       near ptr M00_L26
M00_L09:
       mov       rcx,[rbx+8]
       mov       rdx,[rcx+10]
       mov       r8,[rdx+8]
M00_L10:
       mov       esi,[rdx+0A0]
       mov       eax,esi
       and       eax,[rdx+18]
       cmp       eax,[r8+8]
       jae       near ptr M00_L28
       shl       rax,4
       lea       r14,[r8+rax+10]
       mov       eax,[r14+8]
       sub       eax,esi
       jne       short M00_L12
       lea       r10,[rdx+0A0]
       lea       r9d,[rsi+1]
       mov       eax,esi
       lock cmpxchg [r10],r9d
       cmp       eax,esi
       jne       short M00_L10
       mov       rcx,r14
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       inc       esi
       mov       [r14+8],esi
       jmp       short M00_L13
M00_L11:
       mov       rcx,rbx
       xor       edx,edx
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FF80D14FEB8]; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.Int32, System.Private.CoreLib]].WaitAsync(System.Threading.CancellationToken)
M00_L12:
       test      eax,eax
       jge       short M00_L10
       mov       rdx,rbp
       call      qword ptr [7FF80D1DC708]
M00_L13:
       add       rbx,78
       mov       ecx,1
       xchg      ecx,[rbx]
       test      ecx,ecx
       jne       short M00_L14
       mov       rcx,2335D001368
       mov       rbx,[rcx]
       lea       rcx,[rbx+178]
       lock inc  dword ptr [rcx]
       mov       rcx,rbx
       call      qword ptr [7FF80D1D4468]; System.Threading.PortableThreadPool+WorkerThread.MaybeAddWorkingWorker(System.Threading.PortableThreadPool)
       cmp       dword ptr [rbx+17C],6
       jne       near ptr M00_L27
M00_L14:
       mov       rax,[rdi+10]
       mov       rax,[rax+8]
M00_L15:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L16:
       mov       ecx,1
       mov       rdx,7FF80D1C6670
       call      qword ptr [7FF80CDDF210]
       mov       rcx,rax
       call      qword ptr [7FF80D1DCCC0]
       int       3
M00_L17:
       jmp       short M00_L15
M00_L18:
       mov       rcx,[rcx]
       cmp       dword ptr [rcx+20],0
       je        near ptr M00_L02
       jmp       short M00_L20
M00_L19:
       jmp       short M00_L15
M00_L20:
       mov       rcx,[rsi+20]
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [7FF80D14FDE0]
M00_L21:
       call      qword ptr [7FF80D1DC6D8]
       int       3
M00_L22:
       mov       rcx,offset MT_System.Action<System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,2335D001320
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset System.Threading.Tasks.AsyncLazy`1+<>c[[System.Int32, System.Private.CoreLib]].<GetOrStartAttemptAsync>b__11_0(Attempt<Int32>)
       mov       [rsi+18],rcx
       mov       rcx,2335D001328
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L03
M00_L23:
       mov       ecx,4
       call      qword ptr [7FF80D1DC588]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L04
M00_L24:
       xor       ecx,ecx
       cmp       byte ptr [rbx+18],0
       cmovne    rbx,rcx
       jmp       near ptr M00_L06
M00_L25:
       mov       rcx,offset MT_System.Threading.QueueUserWorkItemCallback<System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rsi
       mov       r8,rdi
       mov       r9,rbx
       call      qword ptr [7FF80D1DC8A0]
       jmp       near ptr M00_L08
M00_L26:
       mov       rcx,2335D001358
       mov       rcx,[rcx]
       cmp       byte ptr [rcx+9D],0
       je        near ptr M00_L09
       mov       rcx,2335D001358
       mov       rcx,[rcx]
       mov       rdx,rbp
       call      qword ptr [7FF80D1DC6F0]
       jmp       near ptr M00_L09
M00_L27:
       mov       rcx,rbx
       call      qword ptr [7FF80D1D4648]; System.Threading.PortableThreadPool+GateThread.EnsureRunningSlow(System.Threading.PortableThreadPool)
       jmp       near ptr M00_L14
M00_L28:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 968
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.Int32, System.Private.CoreLib]](System.Threading.Tasks.Task`1<Int32>)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       ecx,[rbx+34]
       and       ecx,11000000
       cmp       ecx,1000000
       jne       short M01_L01
M01_L00:
       mov       eax,[rbx+38]
       add       rsp,20
       pop       rbx
       ret
M01_L01:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF80D1D4A80]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 47
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       jne       short M02_L01
M02_L00:
       mov       rax,rdx
       ret
M02_L01:
       cmp       [rdx],rcx
       je        short M02_L00
       mov       rax,[rdx]
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L00
M02_L02:
       test      rax,rax
       je        short M02_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L00
       test      rax,rax
       je        short M02_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L00
       test      rax,rax
       jne       short M02_L04
M02_L03:
       xor       edx,edx
       jmp       short M02_L00
M02_L04:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L00
       test      rax,rax
       je        short M02_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L00
       jmp       short M02_L02
; Total bytes of code 88
```
```assembly
; System.Threading.Thread.InitializeCurrentThread()
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
       xor       eax,eax
       mov       [rbp-40],rax
       lea       rcx,[rbp-40]
       mov       [rbp-0A0],rcx
       lea       rcx,[rbp-98]
       call      qword ptr [7FF850609030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FF850609038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FF85060AEB8]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FF850608FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
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
; Total bytes of code 133
```
```assembly
; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.Int32, System.Private.CoreLib]].WaitAsync(System.Threading.CancellationToken)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rdx
       test      rbx,rbx
       jne       short M04_L00
       mov       rax,[rcx+10]
       mov       rax,[rax+8]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       mov       rcx,[rcx+10]
       mov       rsi,[rcx+8]
       cmp       [rsi],sil
       mov       rcx,offset MT_System.TimeProvider
       call      qword ptr [7FF80CDD5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,2335D0014D8
       mov       r8,[r8]
       mov       r9,rbx
       mov       rcx,rsi
       mov       edx,0FFFFFFFF
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF80D1DD398]
; Total bytes of code 92
```
```assembly
; System.Threading.PortableThreadPool+WorkerThread.MaybeAddWorkingWorker(System.Threading.PortableThreadPool)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rax,[rcx+0B8]
       movsx     rdx,ax
       mov       r8,rax
       shr       r8,20
       movsx     r8,r8w
       cmp       edx,r8d
       jge       near ptr M05_L08
M05_L00:
       lea       r8d,[rdx+1]
       movsx     rbx,r8w
       mov       r8,rax
       shr       r8,10
       movsx     r8,r8w
       cmp       r8d,ebx
       jge       near ptr M05_L09
       mov       esi,ebx
M05_L01:
       test      ebx,ebx
       jle       near ptr M05_L10
       mov       r10d,ebx
M05_L02:
       mov       r9,rax
       and       r9,0FFFFFFFFFFFF0000
       movzx     r10d,r10w
       or        r10,r9
       test      esi,esi
       jle       near ptr M05_L11
       mov       r9d,esi
M05_L03:
       mov       r11,0FFFFFFFF0000FFFF
       and       r10,r11
       movzx     r9d,r9w
       shl       r9,10
       or        r10,r9
       lea       r9,[rcx+0B8]
       mov       [rsp+28],rax
       lock cmpxchg [r9],r10
       mov       r10,[rsp+28]
       cmp       rax,r10
       jne       near ptr M05_L17
       sub       esi,r8d
       sub       ebx,edx
       test      ebx,ebx
       jle       short M05_L07
       mov       rcx,2335D001370
       mov       rdi,[rcx]
       mov       rbp,[rdi+60]
M05_L04:
       mov       [rsp+30],rbp
       mov       ecx,ebx
       add       rcx,[rsp+30]
       mov       [rsp+30],rcx
       mov       r14d,[rsp+30]
       mov       r15,rbp
       shr       r15,20
       movzx     r15d,r15w
       mov       rcx,rbp
       shr       rcx,30
       movzx     ecx,cl
       add       r15d,ecx
       cmp       r14d,r15d
       ja        short M05_L12
M05_L05:
       sub       r14d,ecx
       mov       rcx,rbp
       shr       rcx,38
       movzx     ecx,cl
       sub       r14d,ecx
       test      r14d,r14d
       jg        short M05_L13
M05_L06:
       lea       rcx,[rdi+60]
       mov       rdx,[rsp+30]
       mov       rax,rbp
       lock cmpxchg [rcx],rdx
       cmp       rax,rbp
       jne       short M05_L15
       test      r14d,r14d
       jg        short M05_L16
M05_L07:
       test      esi,esi
       jg        short M05_L19
M05_L08:
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M05_L09:
       mov       esi,r8d
       jmp       near ptr M05_L01
M05_L10:
       xor       r10d,r10d
       jmp       near ptr M05_L02
M05_L11:
       xor       r9d,r9d
       jmp       near ptr M05_L03
M05_L12:
       mov       r14d,r15d
       jmp       short M05_L05
M05_L13:
       cmp       r14d,ebx
       jg        short M05_L18
M05_L14:
       lea       rcx,[rsp+30]
       mov       edx,r14d
       call      qword ptr [7FF80D1DD290]; System.Threading.LowLevelLifoSemaphore+Counts.AddUpToMaxCountOfWaitersSignaledToWake(UInt32)
       jmp       short M05_L06
M05_L15:
       mov       rbp,rax
       jmp       near ptr M05_L04
M05_L16:
       mov       rcx,rdi
       mov       edx,r14d
       call      qword ptr [7FF80D1D5788]; System.Threading.LowLevelLifoSemaphore.ReleaseCore(Int32)
       jmp       short M05_L07
M05_L17:
       mov       r10,rax
       movsx     rdx,r10w
       mov       r8,r10
       shr       r8,20
       movsx     r8,r8w
       cmp       edx,r8d
       mov       rax,r10
       jl        near ptr M05_L00
       jmp       short M05_L08
M05_L18:
       mov       r14d,ebx
       jmp       short M05_L14
M05_L19:
       call      qword ptr [7FF80D1D45A0]; System.Threading.PortableThreadPool+WorkerThread.CreateWorkerThread()
       dec       esi
       jmp       near ptr M05_L07
; Total bytes of code 431
```
```assembly
; System.Threading.Tasks.AsyncLazy`1+<>c[[System.Int32, System.Private.CoreLib]].<GetOrStartAttemptAsync>b__11_0(Attempt<Int32>)
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,70
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-40],ymm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       cmp       [rdx],dl
       mov       [rbp-40],rdx
       mov       dword ptr [rbp-30],0FFFFFFFF
       mov       rcx,gs:[58]
       mov       rcx,[rcx+48]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M06_L08
       mov       rcx,[rcx+240]
       mov       rax,[rcx+20]
       test      rax,rax
       je        near ptr M06_L08
M06_L00:
       mov       rbx,[rax+10]
       test      rbx,rbx
       jne       short M06_L01
       call      qword ptr [7FF80D0B5470]; System.Threading.Thread.InitializeCurrentThread()
       mov       rbx,rax
M06_L01:
       mov       [rbp-48],rbx
       mov       rdx,[rbx+8]
       mov       [rbp-50],rdx
       mov       rdx,[rbx+10]
       mov       [rbp-58],rdx
       lea       rcx,[rbp-40]
       call      qword ptr [7FF80D1D5128]; System.Threading.Tasks.AsyncLazy`1+Attempt+<RunAsync>d__4[[System.Int32, System.Private.CoreLib]].MoveNext()
       nop
       mov       rdx,[rbp-58]
       cmp       rdx,[rbx+10]
       je        short M06_L02
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
M06_L02:
       mov       rsi,[rbx+8]
       mov       rdx,[rbp-50]
       cmp       rdx,rsi
       je        short M06_L04
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M06_L03
       cmp       qword ptr [rsi+10],0
       jne       short M06_L07
M06_L03:
       cmp       qword ptr [rbp-50],0
       jne       short M06_L06
M06_L04:
       cmp       qword ptr [rbp-28],0
       je        short M06_L09
M06_L05:
       add       rsp,70
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M06_L06:
       mov       rdx,[rbp-50]
       cmp       qword ptr [rdx+10],0
       je        short M06_L04
M06_L07:
       mov       rcx,rsi
       mov       rdx,[rbp-50]
       call      qword ptr [7FF80D1DC618]
       jmp       short M06_L04
M06_L08:
       mov       ecx,4
       call      qword ptr [7FF80D1DC588]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M06_L00
M06_L09:
       lea       rcx,[rbp-28]
       call      qword ptr [7FF80D1DCC30]
       jmp       short M06_L05
       sub       rsp,28
       mov       rdx,[rbp-58]
       mov       rax,[rbp-48]
       cmp       rdx,[rax+10]
       je        short M06_L10
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-48]
M06_L10:
       mov       rsi,[rax+8]
       mov       rdx,[rbp-50]
       cmp       rdx,rsi
       je        short M06_L13
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M06_L11
       cmp       qword ptr [rsi+10],0
       jne       short M06_L12
M06_L11:
       cmp       qword ptr [rbp-50],0
       je        short M06_L13
       mov       rdx,[rbp-50]
       cmp       qword ptr [rdx+10],0
       je        short M06_L13
M06_L12:
       mov       rcx,rsi
       mov       rdx,[rbp-50]
       call      qword ptr [7FF80D1DC618]
M06_L13:
       nop
       add       rsp,28
       ret
; Total bytes of code 368
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FF850621D18]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M07_L01
       cmp       [rax],ecx
       jle       short M07_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M07_L03
M07_L00:
       add       rsp,20
       pop       rbx
       ret
M07_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M07_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M07_L00
M07_L02:
       cmp       [rax+4],edx
       jle       short M07_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M07_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M07_L03
       jmp       short M07_L00
M07_L03:
       mov       ecx,ebx
       lea       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Threading.PortableThreadPool+GateThread.EnsureRunningSlow(System.Threading.PortableThreadPool)
       sub       rsp,28
       add       rcx,17C
       mov       eax,6
       xchg      eax,[rcx]
       cmp       eax,4
       je        short M08_L02
       test      al,4
       je        short M08_L01
M08_L00:
       add       rsp,28
       ret
M08_L01:
       call      qword ptr [7FF850622CD0]
       jmp       short M08_L00
M08_L02:
       call      qword ptr [7FF850609A00]
       mov       rcx,[rax]
       cmp       [rcx],ecx
       call      qword ptr [7FF8506220D0]
       jmp       short M08_L00
; Total bytes of code 59
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      dword ptr [rbx+34],1600000
       jne       short M09_L00
       mov       rcx,rbx
       mov       edx,0FFFFFFFF
       xor       r8d,r8d
       call      qword ptr [7FF80D1D4AB0]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M09_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M09_L03
M09_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M09_L04
M09_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M09_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M09_L01
       mov       rcx,rbx
       call      qword ptr [7FF80D1DCCA8]
       jmp       short M09_L01
M09_L04:
       test      sil,2
       jne       short M09_L05
       mov       rcx,rbx
       call      qword ptr [7FF80D1DC8E8]
M09_L05:
       mov       rcx,rbx
       call      qword ptr [7FF80D1DD3B0]
       jmp       short M09_L02
; Total bytes of code 124
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.Int32, System.Private.CoreLib]].Nito()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       rbx,[rcx+8]
       test      rbx,rbx
       je        near ptr M00_L05
       mov       rcx,offset MT_Nito.AsyncEx.AsyncLazy<System.Int32>+<>c__DisplayClass14_0
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Func<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset Nito.AsyncEx.AsyncLazy`1+<>c__DisplayClass14_0[[System.Int32, System.Private.CoreLib]].<RunOnThreadPool>b__0()
       mov       [rbx+18],rcx
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_System.Lazy<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.LazyHelper
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+10],8
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-28],rsi
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       mov       rcx,rsi
       call      00007FF86CA5E120
       test      eax,eax
       je        short M00_L01
M00_L00:
       mov       dword ptr [rbp-1C],1
       cmp       qword ptr [rdi+8],0
       je        short M00_L02
       mov       rcx,rdi
       call      qword ptr [7FF80D0A5860]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rbx,rax
       jmp       short M00_L03
M00_L01:
       mov       rcx,rsi
       call      qword ptr [7FF80D1C66B8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L00
M00_L02:
       mov       rbx,[rdi+18]
M00_L03:
       mov       rcx,rsi
       call      00007FF86CA5E040
       test      eax,eax
       jne       short M00_L06
M00_L04:
       mov       rax,rbx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M00_L05:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,10E
       mov       rdx,7FF80D1B6668
       call      qword ptr [7FF80CDCF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80D0A75B8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FF80D1C66E8]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       short M00_L04
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M00_L07
       mov       rcx,[rbp-28]
       call      00007FF86CA5E040
       test      eax,eax
       je        short M00_L07
       mov       ecx,eax
       mov       rdx,[rbp-28]
       call      qword ptr [7FF80D1C66E8]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M00_L07:
       nop
       add       rsp,28
       ret
; Total bytes of code 384
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.Int32, System.Private.CoreLib]](System.Threading.Tasks.Task`1<Int32>)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       ecx,[rbx+34]
       and       ecx,11000000
       cmp       ecx,1000000
       jne       short M01_L01
M01_L00:
       mov       eax,[rbx+38]
       add       rsp,20
       pop       rbx
       ret
M01_L01:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF80D1C4D80]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 47
```
```assembly
; Nito.AsyncEx.AsyncLazy`1+<>c__DisplayClass14_0[[System.Int32, System.Private.CoreLib]].<RunOnThreadPool>b__0()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,[rcx+8]
       test      rbx,rbx
       je        near ptr M02_L15
       mov       rsi,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task<System.Int32>>
       mov       rcx,rsi
       call      qword ptr [7FF80D13FED0]; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].get_Factory()
       cmp       [rax],al
       mov       rcx,1FF87401338
       mov       rdi,[rcx]
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+10],rcx
       lea       rcx,[rsi+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,2008
       mov       [rsi+34],ecx
       mov       rcx,gs:[58]
       mov       rcx,[rcx+48]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M02_L14
       mov       rcx,[rcx+240]
       mov       rax,[rcx+20]
       test      rax,rax
       je        near ptr M02_L14
M02_L00:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M02_L01
       call      qword ptr [7FF80D0A5470]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       rbx,[rax+8]
       test      rbx,rbx
       jne       near ptr M02_L16
       mov       rcx,1FF87401348
       mov       rbx,[rcx]
M02_L02:
       test      rbx,rbx
       je        short M02_L04
       mov       rcx,1FF87401348
       cmp       rbx,[rcx]
       je        short M02_L05
       mov       rax,[rsi+28]
       test      rax,rax
       jne       short M02_L03
       mov       rcx,offset MT_System.Threading.Tasks.Task+ContingentProperties
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+3C],1
       lea       rcx,[rsi+28]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
M02_L03:
       lea       rcx,[rax+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M02_L05
M02_L04:
       or        dword ptr [rsi+34],20000000
M02_L05:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF80D1C40D8]; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
       mov       rcx,offset MT_System.Threading.Tasks.UnwrapPromise<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       movzx     edi,word ptr [rsi+34]
       and       edi,4
       test      edi,0FFFFFFBB
       jne       near ptr M02_L13
       test      dil,4
       je        short M02_L08
       mov       rcx,gs:[58]
       mov       rcx,[rcx+48]
       cmp       dword ptr [rcx+238],8
       jle       near ptr M02_L17
       mov       rcx,[rcx+240]
       mov       rax,[rcx+40]
       test      rax,rax
       je        near ptr M02_L17
M02_L06:
       mov       rbp,[rax+10]
       test      rbp,rbp
       je        short M02_L08
       mov       rax,[rbx+28]
       test      rax,rax
       jne       short M02_L07
       mov       rcx,offset MT_System.Threading.Tasks.Task+ContingentProperties
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [r14+3C],1
       lea       rcx,[rbx+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,r14
M02_L07:
       lea       rcx,[rax+30]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M02_L08:
       xor       ecx,ecx
       mov       [rbx+8],rcx
       mov       [rbx+10],rcx
       mov       [rbx+18],rcx
       test      edi,0FFFFFFA0
       jne       near ptr M02_L13
       mov       ecx,edi
       or        ecx,400
       or        ecx,2000000
       mov       [rbx+34],ecx
       mov       rcx,[rbx+28]
       test      rcx,rcx
       jne       near ptr M02_L18
M02_L09:
       mov       byte ptr [rbx+3D],1
       mov       rcx,1FF87401358
       mov       rcx,[rcx]
       cmp       byte ptr [rcx+9D],0
       jne       near ptr M02_L19
M02_L10:
       cmp       byte ptr [7FF80CD0B074],0
       jne       near ptr M02_L20
M02_L11:
       test      dword ptr [rsi+34],1600000
       jne       near ptr M02_L21
       test      dword ptr [rsi+34],1600000
       jne       near ptr M02_L24
       cmp       qword ptr [rsi+20],0
       jne       near ptr M02_L23
       lea       rcx,[rsi+20]
       test      rcx,rcx
       je        near ptr M02_L22
       mov       rdx,rbx
       xor       r8d,r8d
       call      00007FF86CA021C0
       test      rax,rax
       jne       near ptr M02_L23
M02_L12:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L13:
       mov       ecx,2D
       call      qword ptr [7FF80CDCF348]
       int       3
M02_L14:
       mov       ecx,4
       call      qword ptr [7FF80D1CC168]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M02_L00
M02_L15:
       mov       ecx,2E
       call      qword ptr [7FF80CDCFD38]
       int       3
M02_L16:
       xor       ecx,ecx
       cmp       byte ptr [rbx+18],0
       cmovne    rbx,rcx
       jmp       near ptr M02_L02
M02_L17:
       mov       ecx,8
       call      qword ptr [7FF80D1CC168]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M02_L06
M02_L18:
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M02_L09
       test      dil,4
       je        near ptr M02_L09
       test      byte ptr [rcx+34],8
       jne       near ptr M02_L09
       call      qword ptr [7FF80D1CC4B0]
       jmp       near ptr M02_L09
M02_L19:
       mov       rcx,rbx
       call      qword ptr [7FF80D1C48E8]
       mov       edx,eax
       mov       rcx,1FF87401358
       mov       rcx,[rcx]
       mov       r8,20FAB989790
       xor       r9d,r9d
       call      qword ptr [7FF80D1C4900]
       jmp       near ptr M02_L10
M02_L20:
       mov       rcx,rbx
       call      qword ptr [7FF80D1C4930]
       jmp       near ptr M02_L11
M02_L21:
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF80D1C4960]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].ProcessCompletedOuterTask(System.Threading.Tasks.Task)
       jmp       near ptr M02_L12
M02_L22:
       call      qword ptr [7FF80D1CC2A0]
       int       3
M02_L23:
       mov       rcx,rsi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FF80D1C66D0]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M02_L12
M02_L24:
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF80D1BCD58]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
       jmp       near ptr M02_L12
; Total bytes of code 878
```
```assembly
; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
M03_L00:
       push      rbp
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+40]
       mov       [rbp-10],rcx
       mov       [rbp+10],rcx
M03_L01:
       mov       rbx,[rcx+8]
       test      rbx,rbx
       je        short M03_L05
       mov       eax,[rbx+10]
       cmp       eax,8
       jne       short M03_L06
       mov       [rbp-20],rbx
       xor       eax,eax
       mov       [rbp-14],eax
       mov       rcx,rbx
       call      00007FF86CA5E120
       test      eax,eax
       je        short M03_L03
M03_L02:
       mov       dword ptr [rbp-14],1
       mov       rcx,[rbp+10]
       cmp       [rcx+8],rbx
       jne       short M03_L04
       mov       edx,2
       call      qword ptr [7FF80D0A5890]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M03_L04
M03_L03:
       mov       rcx,rbx
       call      qword ptr [7FF80D1C66B8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M03_L02
M03_L04:
       mov       rcx,rbx
       call      00007FF86CA5E040
       test      eax,eax
       jne       near ptr M03_L12
M03_L05:
       mov       rcx,[rbp+10]
       cmp       qword ptr [rcx+8],0
       je        near ptr M03_L13
       add       rsp,38
       pop       rbx
       pop       rbp
       jmp       qword ptr [7FF80D0A5860]
M03_L06:
       cmp       eax,8
       ja        short M03_L07
       mov       eax,eax
       lea       rdx,[7FF80CE4A540]
       mov       edx,[rdx+rax*4]
       lea       r8,[M03_L01]
       add       rdx,r8
       jmp       rdx
M03_L07:
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF80D1CC5B8]
       int       3
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80D1CC7F8]
       jmp       short M03_L05
       mov       rcx,[rbp+10]
       xor       edx,edx
       call      qword ptr [7FF80D0A5890]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M03_L05
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+10]
       test      rax,rax
       je        short M03_L08
       jmp       short M03_L09
M03_L08:
       mov       rcx,rdx
       mov       rdx,7FF80D1F8188
       call      qword ptr [7FF80CDCF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M03_L09:
       mov       rcx,[rax+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M03_L10
       jmp       short M03_L11
M03_L10:
       mov       rcx,rax
       mov       rdx,7FF80D1F8228
       call      qword ptr [7FF80CDCF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M03_L11:
       call      qword ptr [7FF80D1CC798]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80D1CC810]
       jmp       near ptr M03_L05
       mov       rcx,[rbp+10]
       mov       rdx,rbx
       call      qword ptr [7FF80D1CC828]
       jmp       near ptr M03_L05
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80D1CC840]
       jmp       near ptr M03_L05
       mov       rcx,[rbp+10]
       mov       rdx,rbx
       mov       r8d,1
       call      qword ptr [7FF80D0A5878]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M03_L05
M03_L12:
       mov       ecx,eax
       mov       rdx,rbx
       call      qword ptr [7FF80D1C66E8]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       near ptr M03_L05
M03_L13:
       mov       rax,[rcx+18]
       add       rsp,38
       pop       rbx
       pop       rbp
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-14],0
       je        short M03_L14
       mov       rcx,[rbp-20]
       call      00007FF86CA5E040
       test      eax,eax
       je        short M03_L14
       mov       ecx,eax
       mov       rdx,[rbp-20]
       call      qword ptr [7FF80D1C66E8]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M03_L14:
       nop
       add       rsp,28
       ret
; Total bytes of code 445
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
       sub       rsp,58
       vzeroupper
       lea       rbp,[rsp+90]
       mov       [rbp+10],rcx
       lea       rcx,[rbp-70]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rbx,rax
       mov       rcx,rsp
       mov       [rbp-58],rcx
       mov       rcx,rbp
       mov       [rbp-48],rcx
       lea       rcx,[rbp+10]
       mov       rax,7FF80CE08210
       mov       [rbp-60],rax
       lea       rax,[M04_L00]
       mov       [rbp-50],rax
       lea       rax,[rbp-70]
       mov       [rbx+8],rax
       mov       byte ptr [rbx+4],0
       mov       rax,7FF86CA5E560
       call      rax
M04_L00:
       mov       byte ptr [rbx+4],1
       cmp       dword ptr [7FF86CD13A90],0
       je        short M04_L01
       call      qword ptr [7FF86CD02648]; CORINFO_HELP_STOP_FOR_GC
M04_L01:
       mov       rax,[rbp-68]
       mov       [rbx+8],rax
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 154
```
```assembly
; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
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
       mov       [rbp+18],rdx
       mov       edx,ecx
       lea       rcx,[rbp+18]
       mov       [rbp-9C],rcx
       mov       [rbp-94],edx
       lea       rcx,[rbp-90]
       call      qword ptr [7FF850609030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rcx,[rbp-9C]
       mov       edx,[rbp-94]
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
; Total bytes of code 119
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      dword ptr [rbx+34],1600000
       jne       short M06_L00
       mov       rcx,rbx
       mov       edx,0FFFFFFFF
       xor       r8d,r8d
       call      qword ptr [7FF80D1C4D98]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M06_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M06_L03
M06_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M06_L04
M06_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M06_L01
       mov       rcx,rbx
       call      qword ptr [7FF80D1CC738]
       jmp       short M06_L01
M06_L04:
       test      sil,2
       jne       short M06_L05
       mov       rcx,rbx
       call      qword ptr [7FF80D1CCBD0]
M06_L05:
       mov       rcx,rbx
       call      qword ptr [7FF80D1CD458]
       jmp       short M06_L02
; Total bytes of code 124
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.Int32, System.Private.CoreLib]].Nito_ExecuteOnCallingThread()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       rbx,[rcx+8]
       test      rbx,rbx
       je        near ptr M00_L05
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_System.Lazy<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.LazyHelper
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+10],8
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-28],rsi
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       mov       rcx,rsi
       call      00007FF86CA5E120
       test      eax,eax
       je        short M00_L01
M00_L00:
       mov       dword ptr [rbp-1C],1
       cmp       qword ptr [rdi+8],0
       je        short M00_L02
       mov       rcx,rdi
       call      qword ptr [7FF80D0A5860]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rbx,rax
       jmp       short M00_L03
M00_L01:
       mov       rcx,rsi
       call      qword ptr [7FF80D1C6130]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L00
M00_L02:
       mov       rbx,[rdi+18]
M00_L03:
       mov       rcx,rsi
       call      00007FF86CA5E040
       test      eax,eax
       jne       short M00_L06
M00_L04:
       mov       rax,rbx
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M00_L05:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,10E
       mov       rdx,7FF80D1B6C28
       call      qword ptr [7FF80CDCF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80D0A75B8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FF80D1C6178]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       short M00_L04
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M00_L07
       mov       rcx,[rbp-28]
       call      00007FF86CA5E040
       test      eax,eax
       je        short M00_L07
       mov       ecx,eax
       mov       rdx,[rbp-28]
       call      qword ptr [7FF80D1C6178]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M00_L07:
       nop
       add       rsp,28
       ret
; Total bytes of code 310
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.Int32, System.Private.CoreLib]](System.Threading.Tasks.Task`1<Int32>)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       ecx,[rbx+34]
       and       ecx,11000000
       cmp       ecx,1000000
       jne       short M01_L01
M01_L00:
       mov       eax,[rbx+38]
       add       rsp,20
       pop       rbx
       ret
M01_L01:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF80D1C4D68]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 47
```
```assembly
; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
M02_L00:
       push      rbp
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+40]
       mov       [rbp-10],rcx
       mov       [rbp+10],rcx
M02_L01:
       mov       rbx,[rcx+8]
       test      rbx,rbx
       je        short M02_L05
       mov       eax,[rbx+10]
       cmp       eax,8
       jne       short M02_L06
       mov       [rbp-20],rbx
       xor       eax,eax
       mov       [rbp-14],eax
       mov       rcx,rbx
       call      00007FF86CA5E120
       test      eax,eax
       je        short M02_L03
M02_L02:
       mov       dword ptr [rbp-14],1
       mov       rcx,[rbp+10]
       cmp       [rcx+8],rbx
       jne       short M02_L04
       mov       edx,2
       call      qword ptr [7FF80D0A5890]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M02_L04
M02_L03:
       mov       rcx,rbx
       call      qword ptr [7FF80D1C6130]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M02_L02
M02_L04:
       mov       rcx,rbx
       call      00007FF86CA5E040
       test      eax,eax
       jne       near ptr M02_L12
M02_L05:
       mov       rcx,[rbp+10]
       cmp       qword ptr [rcx+8],0
       je        near ptr M02_L13
       add       rsp,38
       pop       rbx
       pop       rbp
       jmp       qword ptr [7FF80D0A5860]
M02_L06:
       cmp       eax,8
       ja        short M02_L07
       mov       eax,eax
       lea       rdx,[7FF80CE42EB0]
       mov       edx,[rdx+rax*4]
       lea       r8,[M02_L01]
       add       rdx,r8
       jmp       rdx
M02_L07:
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF80D1C7CA8]
       int       3
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80D1C7EB8]
       jmp       short M02_L05
       mov       rcx,[rbp+10]
       xor       edx,edx
       call      qword ptr [7FF80D0A5890]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M02_L05
       mov       rcx,[rbp+10]
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+10]
       test      rax,rax
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rdx
       mov       rdx,7FF80D1F4CF0
       call      qword ptr [7FF80CDCF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L09:
       mov       rcx,[rax+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M02_L10
       jmp       short M02_L11
M02_L10:
       mov       rcx,rax
       mov       rdx,7FF80D1F4D90
       call      qword ptr [7FF80CDCF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M02_L11:
       call      qword ptr [7FF80D1C7E58]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80D1C7ED0]
       jmp       near ptr M02_L05
       mov       rcx,[rbp+10]
       mov       rdx,rbx
       call      qword ptr [7FF80D1C7EE8]
       jmp       near ptr M02_L05
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80D1C7F00]
       jmp       near ptr M02_L05
       mov       rcx,[rbp+10]
       mov       rdx,rbx
       mov       r8d,1
       call      qword ptr [7FF80D0A5878]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M02_L05
M02_L12:
       mov       ecx,eax
       mov       rdx,rbx
       call      qword ptr [7FF80D1C6178]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       near ptr M02_L05
M02_L13:
       mov       rax,[rcx+18]
       add       rsp,38
       pop       rbx
       pop       rbp
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-14],0
       je        short M02_L14
       mov       rcx,[rbp-20]
       call      00007FF86CA5E040
       test      eax,eax
       je        short M02_L14
       mov       ecx,eax
       mov       rdx,[rbp-20]
       call      qword ptr [7FF80D1C6178]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M02_L14:
       nop
       add       rsp,28
       ret
; Total bytes of code 445
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
; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
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
       mov       [rbp+18],rdx
       mov       edx,ecx
       lea       rcx,[rbp+18]
       mov       [rbp-9C],rcx
       mov       [rbp-94],edx
       lea       rcx,[rbp-90]
       call      qword ptr [7FF850609030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rcx,[rbp-9C]
       mov       edx,[rbp-94]
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
; Total bytes of code 119
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      dword ptr [rbx+34],1600000
       jne       short M05_L00
       mov       rcx,rbx
       mov       edx,0FFFFFFFF
       xor       r8d,r8d
       call      qword ptr [7FF80D1C4D98]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M05_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M05_L03
M05_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M05_L04
M05_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M05_L01
       mov       rcx,rbx
       call      qword ptr [7FF80D1CC078]
       jmp       short M05_L01
M05_L04:
       test      sil,2
       jne       short M05_L05
       mov       rcx,rbx
       call      qword ptr [7FF80D1CC0A8]
M05_L05:
       mov       rcx,rbx
       call      qword ptr [7FF80D1CC510]
       jmp       short M05_L02
; Total bytes of code 124
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.Int32, System.Private.CoreLib]].VsThreading()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_Microsoft.VisualStudio.Threading.AsyncLazy<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rbx,[rbx+8]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M00_L00
       lea       rcx,[rsi+20]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+10],rcx
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF80D14FF18]; Microsoft.VisualStudio.Threading.AsyncLazy`1[[System.Int32, System.Private.CoreLib]].GetValueAsync(System.Threading.CancellationToken)
M00_L00:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,164
       mov       rdx,7FF80D1C6C38
       call      qword ptr [7FF80CDDF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80D0B75B8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 158
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.Int32, System.Private.CoreLib]](System.Threading.Tasks.Task`1<Int32>)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       ecx,[rbx+34]
       and       ecx,11000000
       cmp       ecx,1000000
       jne       short M01_L01
M01_L00:
       mov       eax,[rbx+38]
       add       rsp,20
       pop       rbx
       ret
M01_L01:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF80D1F6E08]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 47
```
```assembly
; Microsoft.VisualStudio.Threading.AsyncLazy`1[[System.Int32, System.Private.CoreLib]].GetValueAsync(System.Threading.CancellationToken)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,118
       lea       rbp,[rsp+150]
       xor       eax,eax
       mov       [rbp-0E8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu32 [rbp-0E0],zmm4
       vmovdqu32 [rbp-0A0],zmm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       rsi,rcx
       mov       rcx,offset MT_Microsoft.VisualStudio.Threading.AsyncLazy<System.Int32>+<>c__DisplayClass20_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0E0],rax
       lea       rcx,[rax+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+28]
       test      rcx,rcx
       jne       near ptr M02_L54
M02_L00:
       mov       rcx,[rsi+18]
       test      rcx,rcx
       jne       near ptr M02_L55
M02_L01:
       cmp       qword ptr [rsi+28],0
       jne       near ptr M02_L50
       mov       rcx,[rsi+8]
       test      rcx,rcx
       je        near ptr M02_L56
       call      00007FF86CA5DFD0
       test      eax,eax
       jne       near ptr M02_L57
       xor       ecx,ecx
       mov       rax,[rbp-0E0]
       mov       [rax+10],rcx
       mov       rdx,[rsi+8]
       mov       [rbp-0E8],rdx
       mov       [rbp-3C],ecx
       cmp       qword ptr [rbp-0E8],0
       je        near ptr M02_L27
       mov       rcx,[rbp-0E8]
       call      00007FF86CA5E120
       test      eax,eax
       je        near ptr M02_L28
M02_L02:
       mov       dword ptr [rbp-3C],1
       cmp       qword ptr [rsi+28],0
       jne       near ptr M02_L32
       cmp       qword ptr [rbp+18],0
       je        short M02_L03
       mov       rcx,[rbp+18]
       cmp       dword ptr [rcx+20],0
       jne       near ptr M02_L29
M02_L03:
       mov       rcx,offset MT_Microsoft.VisualStudio.Threading.InlineResumable
       call      CORINFO_HELP_NEWSFAST
       mov       r8,[rbp-0E0]
       lea       rcx,[r8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+20]
       mov       r8,[rbp-0E0]
       lea       rcx,[r8+18]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+20],rcx
       mov       rcx,offset MT_System.Func<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,[rbp-0E0]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset Microsoft.VisualStudio.Threading.AsyncLazy`1+<>c__DisplayClass20_0[[System.Int32, System.Private.CoreLib]].<GetValueAsync>b__0()
       mov       [rdi+18],rcx
       cmp       byte ptr [rsi+38],0
       jne       near ptr M02_L18
       cmp       qword ptr [rsi+18],0
       jne       near ptr M02_L30
M02_L04:
       mov       rcx,offset MT_Microsoft.VisualStudio.Threading.AsyncLocal<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,offset MT_System.Threading.AsyncLocal<System.Object>
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14,[rbx+8]
       mov       rcx,207DBC01320
       mov       r15,[rcx]
       cmp       qword ptr [r14+8],0
       setne     r13b
       movzx     r13d,r13b
       mov       rcx,gs:[58]
       mov       rcx,[rcx+48]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M02_L31
       mov       rcx,[rcx+240]
       mov       r12,[rcx+20]
       test      r12,r12
       je        near ptr M02_L31
M02_L05:
       mov       rax,[r12+10]
       test      rax,rax
       jne       short M02_L06
       call      qword ptr [7FF80D0B5470]; System.Threading.Thread.InitializeCurrentThread()
M02_L06:
       mov       rax,[rax+8]
       mov       [rbp-0F0],rax
       xor       ecx,ecx
       mov       [rbp-48],rcx
       xor       r10d,r10d
       test      rax,rax
       je        short M02_L07
       mov       rcx,[rax+8]
       lea       r8,[rbp-48]
       mov       rdx,r14
       mov       r11,7FF80CD205A0
       call      qword ptr [r11]
       mov       [rbp-4C],eax
       mov       rax,[rbp-0F0]
       mov       r10d,[rbp-4C]
M02_L07:
       cmp       [rbp-48],r15
       je        near ptr M02_L17
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-5C],ecx
       test      rax,rax
       je        short M02_L08
       mov       [rbp-4C],r10d
       movzx     edx,byte ptr [rax+18]
       mov       [rbp-5C],edx
       test      r13d,r13d
       sete      r9b
       movzx     r9d,r9b
       mov       rcx,[rax+8]
       mov       rdx,r14
       mov       r8,r15
       mov       r11,7FF80CD20598
       call      qword ptr [r11]
       mov       [rbp-0F8],rax
       mov       r8,[rbp-0F0]
       mov       r8,[r8+10]
       mov       [rbp-58],r8
       jmp       short M02_L09
M02_L08:
       mov       [rbp-4C],r10d
       mov       rcx,offset MT_System.Threading.AsyncLocalValueMap+OneElementAsyncLocalValueMap
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-110],rax
       lea       rcx,[rax+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-110]
       lea       rcx,[rax+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-110]
       mov       [rbp-0F8],rax
M02_L09:
       test      r13d,r13d
       je        short M02_L11
       cmp       dword ptr [rbp-4C],0
       jne       short M02_L11
       cmp       qword ptr [rbp-58],0
       je        short M02_L10
       mov       r8,[rbp-58]
       mov       r10d,[r8+8]
       mov       [rbp-60],r10d
       lea       r8d,[r10+1]
       lea       rdx,[rbp-58]
       mov       rcx,7FF80D211488
       call      qword ptr [7FF80CFBC5D0]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       edx,[rbp-60]
       mov       rcx,[rbp-58]
       mov       r8,r14
       call      qword ptr [7FF80CDD57B8]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M02_L11
M02_L10:
       mov       rcx,offset MT_System.Threading.IAsyncLocal[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rbp-108],rax
       lea       rcx,[rax+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-108]
       mov       [rbp-58],rax
M02_L11:
       mov       r12,[r12+10]
       test      r12,r12
       jne       short M02_L12
       call      qword ptr [7FF80D0B5470]; System.Threading.Thread.InitializeCurrentThread()
       mov       r12,rax
M02_L12:
       cmp       dword ptr [rbp-5C],0
       jne       short M02_L13
       mov       rcx,207DBC01358
       mov       rax,[rbp-0F8]
       cmp       rax,[rcx]
       jne       short M02_L13
       xor       edx,edx
       jmp       short M02_L14
M02_L13:
       mov       rcx,offset MT_System.Threading.ExecutionContext
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       [rbp-100],rdx
       mov       rax,[rbp-58]
       mov       [rbp-118],rax
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-0F8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-100]
       lea       rcx,[rdx+10]
       mov       rdx,[rbp-118]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-100]
       mov       ecx,[rbp-5C]
       mov       [rdx+18],cl
M02_L14:
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      r13d,r13d
       je        short M02_L17
       mov       rdx,[rbp-48]
       test      rdx,rdx
       jne       near ptr M02_L25
       xor       r13d,r13d
M02_L15:
       mov       rcx,[r14]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       r12,r15
       cmp       [r12],rcx
       je        short M02_L16
       mov       rdx,r15
       call      qword ptr [7FF80CDD58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r12,rax
M02_L16:
       mov       rax,[r14+8]
       mov       [rbp-0D8],r13
       mov       [rbp-0D0],r12
       mov       byte ptr [rbp-0C8],0
       lea       rdx,[rbp-0D8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
M02_L17:
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       [rbp-58],rcx
       lea       rcx,[rsi+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       nop
M02_L18:
       cmp       qword ptr [rsi+10],0
       jne       short M02_L20
       mov       rcx,offset Microsoft.VisualStudio.Threading.AsyncLazy`1+<>c__DisplayClass20_0[[System.Int32, System.Private.CoreLib]].<GetValueAsync>b__0()
       cmp       [rdi+18],rcx
       jne       near ptr M02_L23
       mov       rcx,[rdi+8]
       xor       eax,eax
       mov       [rbp-70],rax
       mov       [rbp-90],rcx
       mov       dword ptr [rbp-78],0FFFFFFFF
       lea       rcx,[rbp-90]
       call      qword ptr [7FF80D1F5380]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[Microsoft.VisualStudio.Threading.AsyncLazy`1+<>c__DisplayClass20_0+<<GetValueAsync>b__0>d[[System.Int32, System.Private.CoreLib]], Microsoft.VisualStudio.Threading]](<<GetValueAsync>b__0>d<Int32> ByRef)
       mov       rdx,[rbp-70]
       test      rdx,rdx
       je        short M02_L22
M02_L19:
       lea       rcx,[rsi+28]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L24
M02_L20:
       mov       rcx,[rsi+10]
       cmp       [rcx],cl
       xor       edx,edx
       mov       [rsp+20],edx
       mov       rdx,rdi
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FF80D1FEC40]
       lea       rcx,[rsi+30]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lock or   dword ptr [rsp],0
       mov       rcx,[rsi+30]
       cmp       [rcx],cl
       call      qword ptr [7FF80D1FECD0]
       mov       rdx,rax
       test      rdx,rdx
       je        short M02_L21
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Int32>
       cmp       [rdx],rcx
       je        short M02_L21
       mov       rdx,rax
       call      qword ptr [7FF80CFB4D20]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rdx,rax
M02_L21:
       lea       rcx,[rsi+28]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M02_L24
M02_L22:
       lea       rcx,[rbp-70]
       call      qword ptr [7FF80D1FDE90]
       mov       rdx,rax
       jmp       near ptr M02_L19
M02_L23:
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       mov       rdx,rax
       jmp       near ptr M02_L19
M02_L24:
       call      M02_L64
       jmp       short M02_L32
M02_L25:
       mov       rcx,[r14]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       r13,rdx
       cmp       [r13],rcx
       je        short M02_L26
       call      qword ptr [7FF80CDD58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r13,rax
M02_L26:
       jmp       near ptr M02_L15
M02_L27:
       xor       ecx,ecx
       call      qword ptr [7FF80D1FE148]
       int       3
M02_L28:
       mov       rcx,[rbp-0E8]
       call      qword ptr [7FF80D1F7F78]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M02_L02
M02_L29:
       lea       rcx,[rbp+18]
       call      qword ptr [7FF80D1FE190]
       int       3
M02_L30:
       mov       rcx,7FF80D278820
       call      qword ptr [7FF80D1F4288]
       jmp       near ptr M02_L04
M02_L31:
       mov       ecx,4
       call      qword ptr [7FF80D1FDB90]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r12,rax
       jmp       near ptr M02_L05
M02_L32:
       mov       rcx,[rbp-0E8]
       call      00007FF86CA5E040
       test      eax,eax
       jne       near ptr M02_L58
M02_L33:
       mov       rdx,[rbp-0E0]
       mov       rcx,[rdx+10]
       test      rcx,rcx
       je        near ptr M02_L50
       mov       byte ptr [rcx+18],1
       mov       rbx,[rcx+8]
       xor       eax,eax
       mov       [rcx+8],rax
       mov       rsi,[rcx+10]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+48]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M02_L59
       mov       rcx,[rcx+240]
       mov       r12,[rcx+20]
       test      r12,r12
       je        near ptr M02_L59
M02_L34:
       mov       rax,[r12+10]
       test      rax,rax
       jne       short M02_L35
       call      qword ptr [7FF80D0B5470]; System.Threading.Thread.InitializeCurrentThread()
M02_L35:
       mov       rdi,[rax+10]
       mov       rax,[r12+10]
       test      rax,rax
       jne       short M02_L36
       call      qword ptr [7FF80D0B5470]; System.Threading.Thread.InitializeCurrentThread()
M02_L36:
       lea       rcx,[rax+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-128],rdi
       test      rbx,rbx
       je        near ptr M02_L48
       mov       rcx,offset System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1+AsyncStateMachineBox`1[[System.Int32, System.Private.CoreLib],[Microsoft.VisualStudio.Threading.AsyncLazy`1+<>c__DisplayClass20_0+<<GetValueAsync>b__0>d[[System.Int32, System.Private.CoreLib]], Microsoft.VisualStudio.Threading]].MoveNext()
       cmp       [rbx+18],rcx
       jne       near ptr M02_L47
       mov       rbx,[rbx+8]
       mov       rcx,207DBC01350
       mov       rcx,[rcx]
       movzx     esi,byte ptr [rcx+9D]
       test      esi,esi
       jne       near ptr M02_L42
M02_L37:
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        near ptr M02_L43
       mov       rdx,207DBC01360
       mov       rdx,[rdx]
       mov       r8,rbx
       call      qword ptr [7FF80D1F5BA8]; System.Threading.ExecutionContext.RunInternal(System.Threading.ExecutionContext, System.Threading.ContextCallback, System.Object)
M02_L38:
       mov       ecx,[rbx+34]
       test      ecx,1600000
       je        short M02_L41
       cmp       byte ptr [7FF80CD1B074],0
       jne       near ptr M02_L44
M02_L39:
       xor       ecx,ecx
       mov       [rbx+40],rcx
       mov       [rbx+48],rcx
       mov       [rbx+50],rcx
       mov       [rbx+58],rcx
       mov       [rbx+60],rcx
       mov       [rbx+68],rcx
       mov       [rbx+10],rcx
       mov       rcx,207DBC01350
       mov       rcx,[rcx]
       cmp       byte ptr [rcx+9D],0
       je        short M02_L41
       movzx     eax,byte ptr [rcx+9D]
       mov       edx,[rcx+98]
       mov       rcx,[rcx+80]
       test      eax,eax
       je        short M02_L41
       test      edx,edx
       je        short M02_L40
       cmp       edx,3
       jl        short M02_L41
M02_L40:
       test      rcx,rcx
       je        short M02_L45
       test      ecx,100
       jne       short M02_L45
M02_L41:
       test      esi,esi
       je        short M02_L48
       jmp       short M02_L46
M02_L42:
       mov       rcx,rbx
       call      qword ptr [7FF80D1F5B78]
       mov       edx,eax
       mov       rcx,207DBC01350
       mov       rcx,[rcx]
       mov       r8d,2
       call      qword ptr [7FF80D1F5B90]
       jmp       near ptr M02_L37
M02_L43:
       lea       rcx,[rbx+40]
       call      qword ptr [7FF80D1F53E0]; Microsoft.VisualStudio.Threading.AsyncLazy`1+<>c__DisplayClass20_0+<<GetValueAsync>b__0>d[[System.Int32, System.Private.CoreLib]].MoveNext()
       jmp       near ptr M02_L38
M02_L44:
       mov       rcx,rbx
       call      qword ptr [7FF80D1F7420]
       jmp       near ptr M02_L39
M02_L45:
       mov       rcx,rbx
       call      qword ptr [7FF80D0B5608]; System.GC.SuppressFinalize(System.Object)
       jmp       short M02_L41
M02_L46:
       mov       rcx,207DBC01350
       mov       rcx,[rcx]
       mov       edx,2
       call      qword ptr [7FF80D1F5BF0]
       jmp       short M02_L48
M02_L47:
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       nop
M02_L48:
       mov       rax,[r12+10]
       test      rax,rax
       jne       short M02_L49
       call      qword ptr [7FF80D0B5470]; System.Threading.Thread.InitializeCurrentThread()
M02_L49:
       lea       rcx,[rax+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M02_L50:
       mov       rsi,[rbp+10]
       lock or   dword ptr [rsp],0
       mov       rcx,[rsi+30]
       test      rcx,rcx
       jne       near ptr M02_L60
       xor       eax,eax
M02_L51:
       test      rax,rax
       jne       short M02_L53
       mov       rbx,[rsi+28]
       mov       rcx,[rbp+18]
       mov       [rbp-0C0],rcx
       test      rbx,rbx
       je        near ptr M02_L61
       cmp       qword ptr [rbp-0C0],0
       jne       near ptr M02_L62
M02_L52:
       mov       rax,rbx
M02_L53:
       add       rsp,118
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L54:
       test      dword ptr [rcx+34],1600000
       jne       near ptr M02_L01
       jmp       near ptr M02_L00
M02_L55:
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF80D1FECA0]
       test      rax,rax
       je        near ptr M02_L01
       call      qword ptr [7FF80D1FECB8]
       mov       rcx,rax
       mov       r8,207DBC014F8
       mov       r8,[r8]
       mov       rdx,207A52AB348
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rcx,rax
       xor       eax,eax
       test      rcx,rcx
       cmove     rcx,rax
       call      qword ptr [7FF80D1F4168]
       int       3
M02_L56:
       mov       ecx,707
       mov       rdx,7FF80CD14000
       call      qword ptr [7FF80CDDF210]
       mov       rcx,rax
       call      qword ptr [7FF80D1FE148]
       int       3
M02_L57:
       call      qword ptr [7FF80D1FECB8]
       mov       rcx,rax
       mov       r8,207DBC014F8
       mov       r8,[r8]
       mov       rdx,207A52AB348
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rcx,rax
       xor       eax,eax
       test      rcx,rcx
       cmove     rcx,rax
       call      qword ptr [7FF80D1F4168]
       int       3
M02_L58:
       mov       ecx,eax
       mov       rdx,[rbp-0E8]
       call      qword ptr [7FF80D1FE160]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       near ptr M02_L33
M02_L59:
       mov       ecx,4
       call      qword ptr [7FF80D1FDB90]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r12,rax
       jmp       near ptr M02_L34
M02_L60:
       mov       r8,[rbp+18]
       xor       edx,edx
       call      qword ptr [7FF80D1F4258]
       jmp       near ptr M02_L51
M02_L61:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,170F
       mov       rdx,7FF80D1C6C38
       call      qword ptr [7FF80CDDF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80D0B75B8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L62:
       test      dword ptr [rbx+34],1600000
       jne       near ptr M02_L52
       lea       rcx,[rbp-0C0]
       call      qword ptr [7FF80D1F6DA8]
       test      eax,eax
       je        short M02_L63
       mov       rcx,[rbp-0C0]
       call      qword ptr [7FF80D1F6D60]
       jmp       near ptr M02_L53
M02_L63:
       mov       rcx,rbx
       mov       rdx,[rbp-0C0]
       call      qword ptr [7FF80D1F6D30]
       jmp       near ptr M02_L53
M02_L64:
       sub       rsp,28
       mov       rsi,[rbp+10]
       mov       rcx,[rsi+18]
       test      rcx,rcx
       je        near ptr M02_L83
       mov       rbx,[rcx+8]
       cmp       qword ptr [rbx+8],0
       setne     r14b
       movzx     r14d,r14b
       mov       rcx,gs:[58]
       mov       rcx,[rcx+48]
       cmp       dword ptr [rcx+238],4
       jle       short M02_L65
       mov       rcx,[rcx+240]
       mov       r12,[rcx+20]
       test      r12,r12
       jne       short M02_L66
M02_L65:
       mov       ecx,4
       call      qword ptr [7FF80D1FDB90]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r12,rax
M02_L66:
       mov       rax,[r12+10]
       test      rax,rax
       jne       short M02_L67
       call      qword ptr [7FF80D0B5470]; System.Threading.Thread.InitializeCurrentThread()
M02_L67:
       mov       r15,[rax+8]
       xor       ecx,ecx
       mov       [rbp-98],rcx
       xor       r13d,r13d
       test      r15,r15
       je        short M02_L68
       mov       rcx,[r15+8]
       lea       r8,[rbp-98]
       mov       rdx,rbx
       mov       r11,7FF80CD205B8
       call      qword ptr [r11]
       mov       r13d,eax
M02_L68:
       cmp       qword ptr [rbp-98],0
       je        near ptr M02_L82
       xor       ecx,ecx
       mov       [rbp-0A0],rcx
       mov       [rbp-0A4],ecx
       test      r15,r15
       je        short M02_L69
       movzx     edi,byte ptr [r15+18]
       test      r14d,r14d
       sete      r9b
       movzx     r9d,r9b
       mov       rcx,[r15+8]
       mov       rdx,rbx
       mov       r11,7FF80CD205B0
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       [rbp-120],rax
       mov       r8,[r15+10]
       mov       [rbp-0A0],r8
       jmp       short M02_L72
M02_L69:
       test      r14d,r14d
       jne       short M02_L70
       mov       rcx,207DBC01358
       mov       r15,[rcx]
       jmp       short M02_L71
M02_L70:
       mov       rcx,offset MT_System.Threading.AsyncLocalValueMap+OneElementAsyncLocalValueMap
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[rbp-0B8]
       mov       r8,rbx
       mov       rdx,7FF80D245EC8
       xor       r9d,r9d
       call      qword ptr [7FF80D1FDDD0]
       lea       rdi,[r15+8]
       lea       rsi,[rbp-0B8]
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
M02_L71:
       mov       [rbp-120],r15
       mov       edi,[rbp-0A4]
M02_L72:
       test      r14d,r14d
       je        short M02_L74
       test      r13d,r13d
       jne       short M02_L74
       cmp       qword ptr [rbp-0A0],0
       jne       short M02_L73
       mov       rcx,offset MT_System.Threading.IAsyncLocal[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r15,rax
       lea       rcx,[r15+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-0A0],r15
       jmp       short M02_L74
M02_L73:
       mov       r8,[rbp-0A0]
       mov       r15d,[r8+8]
       lea       r8d,[r15+1]
       lea       rdx,[rbp-0A0]
       mov       rcx,7FF80D211488
       call      qword ptr [7FF80CFBC5D0]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       edx,r15d
       mov       rcx,[rbp-0A0]
       mov       r8,rbx
       call      qword ptr [7FF80CDD57B8]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M02_L74:
       mov       r12,[r12+10]
       test      r12,r12
       jne       short M02_L75
       call      qword ptr [7FF80D0B5470]; System.Threading.Thread.InitializeCurrentThread()
       mov       r12,rax
M02_L75:
       test      edi,edi
       jne       short M02_L76
       mov       rcx,207DBC01358
       mov       rax,[rbp-120]
       cmp       rax,[rcx]
       je        short M02_L77
M02_L76:
       mov       rcx,offset MT_System.Threading.ExecutionContext
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r13,[rbp-0A0]
       lea       rcx,[r15+8]
       mov       rdx,[rbp-120]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r15+18],dil
       mov       rdx,r15
       jmp       short M02_L78
M02_L77:
       xor       edx,edx
M02_L78:
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      r14d,r14d
       je        short M02_L82
       mov       rdx,[rbp-98]
       test      rdx,rdx
       je        short M02_L80
       mov       rcx,[rbx]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rdi,rdx
       cmp       [rdi],rcx
       je        short M02_L79
       call      qword ptr [7FF80CDD58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
M02_L79:
       jmp       short M02_L81
M02_L80:
       xor       edi,edi
M02_L81:
       mov       rax,[rbx+8]
       mov       [rbp-0D8],rdi
       xor       edx,edx
       mov       [rbp-0D0],rdx
       mov       byte ptr [rbp-0C8],0
       lea       rdx,[rbp-0D8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
M02_L82:
       xor       ecx,ecx
       mov       [rbp-98],rcx
       mov       [rbp-0A0],rcx
M02_L83:
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M02_L85
       cmp       qword ptr [rbp-0E8],0
       jne       short M02_L84
       xor       ecx,ecx
       call      qword ptr [7FF80D1FE148]
       int       3
M02_L84:
       mov       rcx,[rbp-0E8]
       call      00007FF86CA5E040
       test      eax,eax
       je        short M02_L85
       mov       ecx,eax
       mov       rdx,[rbp-0E8]
       call      qword ptr [7FF80D1FE160]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M02_L85:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       mov       rcx,gs:[58]
       mov       rcx,[rcx+48]
       cmp       dword ptr [rcx+238],4
       jle       short M02_L86
       mov       rcx,[rcx+240]
       mov       r12,[rcx+20]
       test      r12,r12
       jne       short M02_L87
M02_L86:
       mov       ecx,4
       call      qword ptr [7FF80D1FDB90]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r12,rax
M02_L87:
       mov       rdi,[r12+10]
       test      rdi,rdi
       jne       short M02_L88
       call      qword ptr [7FF80D0B5470]; System.Threading.Thread.InitializeCurrentThread()
       mov       rdi,rax
M02_L88:
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-128]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       ret
; Total bytes of code 3358
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      dword ptr [rbx+34],1600000
       jne       short M03_L00
       mov       rcx,rbx
       mov       edx,0FFFFFFFF
       xor       r8d,r8d
       call      qword ptr [7FF80D1F6E20]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M03_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M03_L03
M03_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M03_L04
M03_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M03_L01
       mov       rcx,rbx
       call      qword ptr [7FF80D1FE130]
       jmp       short M03_L01
M03_L04:
       test      sil,2
       jne       short M03_L05
       mov       rcx,rbx
       call      qword ptr [7FF80D1FE8E0]
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FF80D1FEDD8]
       jmp       short M03_L02
; Total bytes of code 124
```

