## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.__Canon, System.Private.CoreLib]].LazyOfTask()
       push      rbp
       push      r15
       push      rbx
       sub       rsp,10
       lea       rbp,[rsp+20]
       mov       [rbp-18],rdi
       mov       rbx,rdi
       mov       rdi,[rbx]
       mov       rsi,[rdi+30]
       mov       rsi,[rsi]
       mov       rsi,[rsi+28]
       test      rsi,rsi
       je        short M00_L01
M00_L00:
       mov       rdi,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M00_L02
       lea       rdi,[r15+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset MT_System.LazyHelper
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+10],8
       lea       rdi,[r15+8]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [r15+8],0
       je        short M00_L03
       mov       rdi,r15
       add       rsp,10
       pop       rbx
       pop       r15
       pop       rbp
       jmp       qword ptr [7CFFA32AC438]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
M00_L01:
       mov       rsi,7CFFA35D7648
       call      qword ptr [7CFFA2A5F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       short M00_L00
M00_L02:
       mov       edi,1817
       mov       rsi,7CFFA1A64000
       call      qword ptr [7CFFA2A5EF88]
       mov       rdi,rax
       call      qword ptr [7CFFA35BCD50]
       int       3
M00_L03:
       mov       rax,[r15+18]
       add       rsp,10
       pop       rbx
       pop       r15
       pop       rbp
       ret
; Total bytes of code 191
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.__Canon, System.Private.CoreLib]](System.Threading.Tasks.Task`1<System.__Canon>)
       push      rbx
       mov       rbx,rsi
       mov       edi,[rbx+34]
       and       edi,11000000
       cmp       edi,1000000
       jne       short M01_L01
M01_L00:
       mov       rax,[rbx+38]
       pop       rbx
       ret
M01_L01:
       mov       rdi,rbx
       xor       esi,esi
       call      qword ptr [7CFFA35BCD98]
       jmp       short M01_L00
; Total bytes of code 40
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
       call      00007D0020CE6020
       test      eax,eax
       jne       short M02_L02
       mov       rdi,rbx
       call      qword ptr [7CFFA35BCE88]
M02_L02:
       mov       dword ptr [rbp-14],1
       mov       rdi,[rbp-20]
       cmp       [rdi+8],rbx
       jne       short M02_L03
       mov       esi,2
       call      qword ptr [7CFFA32AC468]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       nop
M02_L03:
       mov       rdi,rbx
       call      00007D0020CE6790
       test      eax,eax
       jne       near ptr M02_L11
M02_L04:
       mov       rdi,[rbp-20]
       cmp       qword ptr [rdi+8],0
       je        near ptr M02_L12
       add       rsp,28
       pop       rbx
       pop       rbp
       jmp       qword ptr [7CFFA32AC438]
M02_L05:
       cmp       eax,8
       ja        short M02_L06
       mov       eax,eax
       lea       rcx,[7CFFA2ACB8C8]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M02_L01]
       add       rcx,rdx
       jmp       rcx
M02_L06:
       mov       rdi,[rbx+8]
       cmp       [rdi],edi
       call      qword ptr [7CFFA35BCEA0]
       int       3
       mov       rdi,[rbp-20]
       call      qword ptr [7CFFA35BCE28]
       jmp       short M02_L04
       mov       rdi,[rbp-20]
       xor       esi,esi
       call      qword ptr [7CFFA32AC468]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
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
       mov       rsi,7CFFA35DB2E0
       call      qword ptr [7CFFA2A5F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L08:
       mov       rdi,[rax+30]
       mov       rdi,[rdi]
       mov       rdi,[rdi+18]
       test      rdi,rdi
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rdi,rax
       mov       rsi,7CFFA35DB380
       call      qword ptr [7CFFA2A5F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M02_L10:
       call      qword ptr [7CFFA35BCDC8]
       mov       rdx,rax
       mov       rsi,rbx
       mov       rdi,[rbp-20]
       call      qword ptr [7CFFA35BCE40]
       jmp       near ptr M02_L04
       mov       rdi,[rbp-20]
       mov       rsi,rbx
       call      qword ptr [7CFFA35BCE58]
       jmp       near ptr M02_L04
       mov       rdi,[rbp-20]
       call      qword ptr [7CFFA35BCE70]
       jmp       near ptr M02_L04
       mov       rdi,[rbp-20]
       mov       rsi,rbx
       mov       edx,1
       call      qword ptr [7CFFA32AC450]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M02_L04
M02_L11:
       mov       edi,eax
       mov       rsi,rbx
       call      qword ptr [7CFFA35BCD68]
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
       call      00007D0020CE6790
       test      eax,eax
       je        short M02_L13
       mov       edi,eax
       mov       rsi,[rbp-28]
       call      qword ptr [7CFFA35BCD68]
M02_L13:
       nop
       add       rsp,8
       ret
; Total bytes of code 438
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
       call      qword ptr [7CFFA25FEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdx,[rbp-8C]
       mov       rsi,[rbp-94]
       mov       rdi,[rbp-9C]
       mov       ecx,[rbp-84]
       mov       r8,[rbp-0A4]
       call      qword ptr [rax]
       mov       rbx,rax
       lea       rdi,[rbp-80]
       call      qword ptr [7CFFA25FEF08]; CORINFO_HELP_JIT_PINVOKE_END
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
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.__Canon, System.Private.CoreLib]].LazyOfTask_TaskRun()
       push      rbp
       push      r15
       push      rbx
       sub       rsp,10
       lea       rbp,[rsp+20]
       mov       [rbp-18],rdi
       mov       rbx,rdi
       mov       rdi,[rbx]
       mov       rsi,[rdi+30]
       mov       rsi,[rsi]
       mov       rsi,[rsi+28]
       test      rsi,rsi
       je        short M00_L01
M00_L00:
       mov       rdi,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rsi,[rbx+10]
       test      rsi,rsi
       je        short M00_L02
       lea       rdi,[r15+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset MT_System.LazyHelper
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+10],8
       lea       rdi,[r15+8]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [r15+8],0
       je        short M00_L03
       mov       rdi,r15
       add       rsp,10
       pop       rbx
       pop       r15
       pop       rbp
       jmp       qword ptr [77A2CC6AC438]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
M00_L01:
       mov       rsi,77A2CC9D7648
       call      qword ptr [77A2CBE5F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       short M00_L00
M00_L02:
       mov       edi,1817
       mov       rsi,77A2CAE64000
       call      qword ptr [77A2CBE5EF88]
       mov       rdi,rax
       call      qword ptr [77A2CC9BE838]
       int       3
M00_L03:
       mov       rax,[r15+18]
       add       rsp,10
       pop       rbx
       pop       r15
       pop       rbp
       ret
; Total bytes of code 191
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.__Canon, System.Private.CoreLib]](System.Threading.Tasks.Task`1<System.__Canon>)
       push      rbx
       mov       rbx,rsi
       mov       edi,[rbx+34]
       and       edi,11000000
       cmp       edi,1000000
       jne       short M01_L01
M01_L00:
       mov       rax,[rbx+38]
       pop       rbx
       ret
M01_L01:
       mov       rdi,rbx
       xor       esi,esi
       call      qword ptr [77A2CC9B7600]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 40
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
       call      000077A34A0E6020
       test      eax,eax
       jne       short M02_L02
       mov       rdi,rbx
       call      qword ptr [77A2CC9B7C60]; System.Threading.Monitor.Enter_Slowpath(System.Object)
M02_L02:
       mov       dword ptr [rbp-14],1
       mov       rdi,[rbp-20]
       cmp       [rdi+8],rbx
       jne       short M02_L03
       mov       esi,2
       call      qword ptr [77A2CC6AC468]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       nop
M02_L03:
       mov       rdi,rbx
       call      000077A34A0E6790
       test      eax,eax
       jne       near ptr M02_L11
M02_L04:
       mov       rdi,[rbp-20]
       cmp       qword ptr [rdi+8],0
       je        near ptr M02_L12
       add       rsp,28
       pop       rbx
       pop       rbp
       jmp       qword ptr [77A2CC6AC438]
M02_L05:
       cmp       eax,8
       ja        short M02_L06
       mov       eax,eax
       lea       rcx,[77A2CBED7848]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M02_L01]
       add       rcx,rdx
       jmp       rcx
M02_L06:
       mov       rdi,[rbx+8]
       cmp       [rdi],edi
       call      qword ptr [77A2CC9BEBF8]
       int       3
       mov       rdi,[rbp-20]
       call      qword ptr [77A2CC9BEB98]
       jmp       short M02_L04
       mov       rdi,[rbp-20]
       xor       esi,esi
       call      qword ptr [77A2CC6AC468]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
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
       mov       rsi,77A2CCA31D60
       call      qword ptr [77A2CBE5F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L08:
       mov       rdi,[rax+30]
       mov       rdi,[rdi]
       mov       rdi,[rdi+18]
       test      rdi,rdi
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rdi,rax
       mov       rsi,77A2CCA31E00
       call      qword ptr [77A2CBE5F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M02_L10:
       call      qword ptr [77A2CC9BEB38]
       mov       rdx,rax
       mov       rsi,rbx
       mov       rdi,[rbp-20]
       call      qword ptr [77A2CC9BEBB0]
       jmp       near ptr M02_L04
       mov       rdi,[rbp-20]
       mov       rsi,rbx
       call      qword ptr [77A2CC9BEBC8]
       jmp       near ptr M02_L04
       mov       rdi,[rbp-20]
       call      qword ptr [77A2CC9BEBE0]
       jmp       near ptr M02_L04
       mov       rdi,[rbp-20]
       mov       rsi,rbx
       mov       edx,1
       call      qword ptr [77A2CC6AC450]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M02_L04
M02_L11:
       mov       edi,eax
       mov       rsi,rbx
       call      qword ptr [77A2CC9BC738]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
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
       call      000077A34A0E6790
       test      eax,eax
       je        short M02_L13
       mov       edi,eax
       mov       rsi,[rbp-28]
       call      qword ptr [77A2CC9BC738]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M02_L13:
       nop
       add       rsp,8
       ret
; Total bytes of code 438
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
       call      qword ptr [77A2CB9FEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdx,[rbp-8C]
       mov       rsi,[rbp-94]
       mov       rdi,[rbp-9C]
       mov       ecx,[rbp-84]
       mov       r8,[rbp-0A4]
       call      qword ptr [rax]
       mov       rbx,rax
       lea       rdi,[rbp-80]
       call      qword ptr [77A2CB9FEF08]; CORINFO_HELP_JIT_PINVOKE_END
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
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rbp
       push      r15
       push      rbx
       lea       rbp,[rsp+10]
       mov       rbx,rdi
       mov       r15d,esi
       test      dword ptr [rbx+34],1600000
       jne       short M04_L00
       mov       rdi,rbx
       mov       esi,0FFFFFFFF
       xor       edx,edx
       call      qword ptr [77A2CC9B7618]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M04_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M04_L03
M04_L01:
       mov       edi,[rbx+34]
       and       edi,1600000
       cmp       edi,1000000
       jne       short M04_L04
M04_L02:
       pop       rbx
       pop       r15
       pop       rbp
       ret
M04_L03:
       mov       rdi,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M04_L01
       mov       rdi,rbx
       call      qword ptr [77A2CC9BF348]
       jmp       short M04_L01
M04_L04:
       test      r15b,2
       jne       short M04_L05
       mov       rdi,rbx
       call      qword ptr [77A2CC9BF360]
M04_L05:
       mov       rdi,rbx
       call      qword ptr [77A2CC9BF948]
       jmp       short M04_L02
; Total bytes of code 125
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.__Canon, System.Private.CoreLib]].AsyncLazy()
       push      rbp
       push      r15
       push      rbx
       sub       rsp,10
       lea       rbp,[rsp+20]
       mov       [rbp-18],rdi
       mov       rbx,rdi
       mov       rdi,[rbx]
       mov       rsi,[rdi+30]
       mov       rsi,[rsi]
       mov       rsi,[rsi+28]
       test      rsi,rsi
       je        short M00_L01
M00_L00:
       mov       rdi,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M00_L02
       lea       rdi,[r15+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[r15+10]
       test      rax,rax
       jne       short M00_L03
       mov       rdi,r15
       xor       esi,esi
       add       rsp,10
       pop       rbx
       pop       r15
       pop       rbp
       jmp       qword ptr [7BC1A3B86928]; System.Threading.Tasks.AsyncLazy`1[[System.__Canon, System.Private.CoreLib]].GetOrStartAttemptAsync(System.Threading.CancellationToken)
M00_L01:
       mov       rsi,7BC1A3BAA0B0
       call      qword ptr [7BC1A302F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       short M00_L00
M00_L02:
       mov       edi,1
       mov       rsi,7BC1A3BB7E90
       call      qword ptr [7BC1A302EF88]
       mov       rdi,rax
       call      qword ptr [7BC1A3B8F018]
       int       3
M00_L03:
       add       rsp,10
       pop       rbx
       pop       r15
       pop       rbp
       ret
; Total bytes of code 157
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.__Canon, System.Private.CoreLib]](System.Threading.Tasks.Task`1<System.__Canon>)
       push      rbx
       mov       rbx,rsi
       mov       edi,[rbx+34]
       and       edi,11000000
       cmp       edi,1000000
       jne       short M01_L01
M01_L00:
       mov       rax,[rbx+38]
       pop       rbx
       ret
M01_L01:
       mov       rdi,rbx
       xor       esi,esi
       call      qword ptr [7BC1A3B87660]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 40
```
```assembly
; System.Threading.Tasks.AsyncLazy`1[[System.__Canon, System.Private.CoreLib]].GetOrStartAttemptAsync(System.Threading.CancellationToken)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+50]
       mov       [rbp-30],rdi
       mov       rbx,rdi
       mov       r15,rsi
M02_L00:
       mov       r14,[rbx+8]
       mov       r13,[rbx]
       mov       rdi,r13
       mov       rsi,[rdi+30]
       mov       rsi,[rsi]
       mov       rax,[rsi+18]
       test      rax,rax
       je        near ptr M02_L18
       mov       rdi,rax
M02_L01:
       mov       rsi,r14
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M02_L34
       mov       rdi,[r13+30]
       mov       rdi,[rdi]
       mov       rdi,[rdi+20]
       test      rdi,rdi
       je        near ptr M02_L19
M02_L02:
       mov       rax,rdi
       test      r14,r14
       jne       near ptr M02_L20
M02_L03:
       lea       rax,[rbx+20]
       cmp       qword ptr [rax],0
       jne       near ptr M02_L33
M02_L04:
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rdi,[r12]
       mov       rsi,[rdi+30]
       mov       rsi,[rsi]
       mov       rsi,[rsi+10]
       test      rsi,rsi
       je        near ptr M02_L22
M02_L05:
       mov       rdi,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdi,[r14]
       mov       rsi,[rdi+30]
       mov       rsi,[rsi]
       mov       rsi,[rsi+18]
       test      rsi,rsi
       je        near ptr M02_L23
M02_L06:
       mov       rdi,rsi
       call      CORINFO_HELP_NEWSFAST
       xor       edi,edi
       mov       [rax+8],rdi
       mov       [rax+10],rdi
       mov       [rax+18],rdi
       mov       dword ptr [rax+34],2000440
       lea       rdi,[r14+8]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdi,[r12+10]
       mov       rsi,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdi,[r12+8]
       mov       rsi,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdi,[rbx+8]
       test      rdi,rdi
       je        near ptr M02_L38
       mov       rsi,r12
       xor       edx,edx
       call      00007BC221474060
       test      rax,rax
       jne       near ptr M02_L00
       mov       rdi,[r13+30]
       mov       rdi,[rdi]
       mov       rdi,[rdi+28]
       test      rdi,rdi
       je        near ptr M02_L26
M02_L07:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r14,[rax+8]
       test      r14,r14
       je        near ptr M02_L39
M02_L08:
       mov       rdi,[r13+30]
       mov       rdi,[rdi]
       mov       rax,[rdi+30]
       test      rax,rax
       je        near ptr M02_L27
       mov       r13,rax
M02_L09:
       mov       rdi,7BC2216A0D68
       mov       rax,7BC221EF8820
       call      rax
       cmp       dword ptr [rax],4
       jle       near ptr M02_L47
       mov       rdi,[rax+8]
       mov       rax,[rdi+20]
       test      rax,rax
       je        near ptr M02_L47
M02_L10:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M02_L11
       call      qword ptr [7BC1A387C048]; System.Threading.Thread.InitializeCurrentThread()
M02_L11:
       mov       rdi,[rax+8]
       test      rdi,rdi
       jne       near ptr M02_L48
       mov       rdi,7BB1E0C01390
       mov       rdi,[rdi]
M02_L12:
       test      rdi,rdi
       je        short M02_L13
       mov       [rbp-48],rdi
       cmp       byte ptr [rdi+19],0
       je        near ptr M02_L49
M02_L13:
       mov       rdi,[r13+18]
       mov       rdi,[rdi+18]
       test      rdi,rdi
       je        near ptr M02_L28
M02_L14:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rdi,[r13+8]
       mov       rsi,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdi,[r13+10]
       mov       rsi,r12
       call      CORINFO_HELP_ASSIGN_REF
M02_L15:
       mov       rdi,7BB1E0C013A0
       mov       r14,[rdi]
       cmp       byte ptr [r14+38],0
       jne       near ptr M02_L52
M02_L16:
       mov       rdi,[r14+8]
       mov       rsi,[rdi+10]
       mov       rcx,[rsi+8]
M02_L17:
       mov       edx,[rsi+0A0]
       mov       eax,edx
       and       eax,[rsi+18]
       cmp       eax,[rcx+8]
       jae       near ptr M02_L55
       shl       rax,4
       lea       r8,[rcx+rax+10]
       mov       eax,[r8+8]
       sub       eax,edx
       jne       near ptr M02_L29
       lea       r9,[rsi+0A0]
       lea       r10d,[rdx+1]
       mov       eax,edx
       lock cmpxchg [r9],r10d
       cmp       eax,edx
       mov       [rbp-34],edx
       jne       short M02_L17
       mov       rcx,r8
       mov       [rbp-50],rcx
       mov       rdi,rcx
       mov       rsi,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13d,[rbp-34]
       inc       r13d
       mov       rdi,[rbp-50]
       mov       [rdi+8],r13d
       jmp       near ptr M02_L30
M02_L18:
       mov       rsi,7BC1A3BAA628
       call      qword ptr [7BC1A302F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M02_L01
M02_L19:
       mov       rdi,r13
       mov       rsi,7BC1A3BAA638
       call      qword ptr [7BC1A302F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M02_L02
M02_L20:
       cmp       [r14],rax
       jne       near ptr M02_L03
       mov       rdi,r14
       call      qword ptr [7BC1A3B86A00]
       test      eax,eax
       je        near ptr M02_L25
       mov       rdi,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdi,r14
       mov       rsi,7BC192409FE0
       call      qword ptr [7BC1A3875260]
       mov       rdi,[r13+30]
       mov       rdi,[rdi]
       cmp       qword ptr [rdi+8],40
       jle       short M02_L24
       mov       rdi,[rdi+40]
       test      rdi,rdi
       je        short M02_L24
M02_L21:
       mov       rsi,r14
       add       rsp,28
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7BC1A3B869A0]
M02_L22:
       mov       rsi,7BC1A3BAD2A8
       call      qword ptr [7BC1A302F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M02_L05
M02_L23:
       mov       rsi,7BC1A3BD9220
       call      qword ptr [7BC1A302F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M02_L06
M02_L24:
       mov       rdi,r13
       mov       rsi,7BC1A3BACF38
       call      qword ptr [7BC1A302F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       short M02_L21
M02_L25:
       mov       rdi,r14
       mov       rsi,r15
       add       rsp,28
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7BC1A3B86A18]; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.__Canon, System.Private.CoreLib]].WaitAsync(System.Threading.CancellationToken)
M02_L26:
       mov       rdi,r13
       mov       rsi,7BC1A3BAA830
       call      qword ptr [7BC1A302F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M02_L07
M02_L27:
       mov       rdi,r13
       mov       rsi,7BC1A3BACD58
       call      qword ptr [7BC1A302F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M02_L09
M02_L28:
       mov       rdi,r13
       mov       rsi,7BC1A3BD6B30
       call      qword ptr [7BC1A302F3A8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M02_L14
M02_L29:
       test      eax,eax
       jge       near ptr M02_L17
       mov       rsi,r13
       call      qword ptr [7BC1A3B8ED78]
M02_L30:
       add       r14,78
       mov       edi,1
       xchg      edi,[r14]
       test      edi,edi
       jne       short M02_L31
       mov       rdi,7BB1E0C013C8
       mov       r14,[rdi]
       lea       rdi,[r14+160]
       lock inc  dword ptr [rdi]
       mov       rdi,r14
       call      qword ptr [7BC1A3B86E80]; System.Threading.PortableThreadPool+WorkerThread.MaybeAddWorkingWorker(System.Threading.PortableThreadPool)
       cmp       dword ptr [r14+164],6
       jne       near ptr M02_L53
M02_L31:
       test      r15,r15
       jne       near ptr M02_L54
       mov       rdi,[r12+10]
       mov       rax,[rdi+8]
M02_L32:
       add       rsp,28
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L33:
       mov       rax,[rax]
       cmp       dword ptr [rax+20],0
       je        near ptr M02_L04
       jmp       short M02_L35
M02_L34:
       jmp       short M02_L32
M02_L35:
       mov       rdi,[r13+30]
       mov       rdi,[rdi]
       mov       rdi,[rdi+10]
       test      rdi,rdi
       je        short M02_L36
       jmp       short M02_L37
M02_L36:
       mov       rdi,r13
       mov       rsi,7BC1A3BAA430
       call      qword ptr [7BC1A302F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M02_L37:
       mov       rsi,[rbx+20]
       add       rsp,28
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7BC1A3B868C8]
M02_L38:
       call      qword ptr [7BC1A3B8EFA0]
       int       3
M02_L39:
       mov       rdi,[r13+30]
       mov       rdi,[rdi]
       mov       r14,[rdi+28]
       test      r14,r14
       je        short M02_L40
       jmp       short M02_L41
M02_L40:
       mov       rdi,r13
       mov       rsi,7BC1A3BAA830
       call      qword ptr [7BC1A302F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
M02_L41:
       mov       rdi,[r13+30]
       mov       rdi,[rdi]
       cmp       qword ptr [rdi+8],38
       jle       short M02_L42
       mov       rdi,[rdi+38]
       test      rdi,rdi
       je        short M02_L42
       jmp       short M02_L43
M02_L42:
       mov       rdi,r13
       mov       rsi,7BC1A3BACE40
       call      qword ptr [7BC1A302F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M02_L43:
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rdi,r14
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rsi,[rax]
       test      rsi,rsi
       jne       short M02_L44
       call      qword ptr [7BC1A3B8F9D8]
       int       3
M02_L44:
       mov       r14,[rbp-40]
       lea       rdi,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset System.Threading.Tasks.AsyncLazy`1+<>c[[System.__Canon, System.Private.CoreLib]].<GetOrStartAttemptAsync>b__11_0(Attempt<System.__Canon>)
       mov       [r14+18],rdi
       mov       rdi,[r13+30]
       mov       rdi,[rdi]
       mov       rdi,[rdi+28]
       test      rdi,rdi
       je        short M02_L45
       jmp       short M02_L46
M02_L45:
       mov       rdi,r13
       mov       rsi,7BC1A3BAA830
       call      qword ptr [7BC1A302F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M02_L46:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       lea       rdi,[rax+8]
       mov       rsi,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L08
M02_L47:
       mov       edi,4
       call      qword ptr [7BC1A3B8EBB0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M02_L10
M02_L48:
       xor       esi,esi
       cmp       byte ptr [rdi+18],0
       cmovne    rdi,rsi
       jmp       near ptr M02_L12
M02_L49:
       mov       rsi,[r13+18]
       mov       rsi,[rsi+20]
       test      rsi,rsi
       je        short M02_L50
       jmp       short M02_L51
M02_L50:
       mov       rdi,r13
       mov       rsi,7BC1A3BD6CC8
       call      qword ptr [7BC1A302F3A8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
M02_L51:
       mov       rdi,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdi,r13
       mov       rsi,r14
       mov       rdx,r12
       mov       rcx,[rbp-48]
       call      qword ptr [7BC1A3B8ED30]
       jmp       near ptr M02_L15
M02_L52:
       mov       rdi,7BB1E0C013B8
       mov       rdi,[rdi]
       cmp       byte ptr [rdi+9D],0
       je        near ptr M02_L16
       mov       rdi,7BB1E0C013B8
       mov       rdi,[rdi]
       mov       rsi,r13
       call      qword ptr [7BC1A3B8ED48]
       jmp       near ptr M02_L16
M02_L53:
       mov       rdi,r14
       call      qword ptr [7BC1A3B870D8]; System.Threading.PortableThreadPool+GateThread.EnsureRunningSlow(System.Threading.PortableThreadPool)
       jmp       near ptr M02_L31
M02_L54:
       mov       rdi,[r12+10]
       mov       r14,[rdi+8]
       cmp       [r14],r14b
       mov       rdi,offset MT_System.TimeProvider
       call      qword ptr [7BC1A3025728]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,7BB1E0C01490
       mov       rdx,[rdx]
       mov       rcx,r15
       mov       rdi,r14
       mov       esi,0FFFFFFFF
       add       rsp,28
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7BC1A3B8F828]
M02_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1643
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
       call      qword ptr [7BC1A2BCEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdx,[rbp-8C]
       mov       rsi,[rbp-94]
       mov       rdi,[rbp-9C]
       mov       ecx,[rbp-84]
       mov       r8,[rbp-0A4]
       call      qword ptr [rax]
       mov       rbx,rax
       lea       rdi,[rbp-80]
       call      qword ptr [7BC1A2BCEF08]; CORINFO_HELP_JIT_PINVOKE_END
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
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rbp
       push      r15
       push      rbx
       lea       rbp,[rsp+10]
       mov       rbx,rdi
       mov       r15d,esi
       test      dword ptr [rbx+34],1600000
       jne       short M04_L00
       mov       rdi,rbx
       mov       esi,0FFFFFFFF
       xor       edx,edx
       call      qword ptr [7BC1A3B87678]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M04_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M04_L03
M04_L01:
       mov       edi,[rbx+34]
       and       edi,1600000
       cmp       edi,1000000
       jne       short M04_L04
M04_L02:
       pop       rbx
       pop       r15
       pop       rbp
       ret
M04_L03:
       mov       rdi,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M04_L01
       mov       rdi,rbx
       call      qword ptr [7BC1A3B8F330]
       jmp       short M04_L01
M04_L04:
       test      r15b,2
       jne       short M04_L05
       mov       rdi,rbx
       call      qword ptr [7BC1A3B8F090]
M04_L05:
       mov       rdi,rbx
       call      qword ptr [7BC1A3B8F9F0]
       jmp       short M04_L02
; Total bytes of code 125
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.__Canon, System.Private.CoreLib]].AsyncLazy_NoHop()
       push      rbp
       push      r15
       push      r14
       push      rbx
       sub       rsp,68
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm8,xmm8,xmm8
       vmovdqu   ymmword ptr [rbp-50],ymm8
       vmovdqa   xmmword ptr [rbp-30],xmm8
       mov       [rbp-20],rdi
       mov       [rbp-60],rdi
       mov       rsi,[rdi]
       mov       rax,[rsi+30]
       mov       rax,[rax]
       mov       rax,[rax+28]
       test      rax,rax
       je        near ptr M00_L20
M00_L00:
       mov       rdi,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdi,[rbp-60]
       mov       rsi,[rdi+8]
       test      rsi,rsi
       je        near ptr M00_L31
       lea       rdi,[rbx+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbx+10]
       test      rax,rax
       jne       near ptr M00_L32
M00_L01:
       mov       r15,[rbx+8]
       mov       rdi,[rbx]
       mov       rsi,[rdi+30]
       mov       rsi,[rsi]
       mov       rax,[rsi+18]
       test      rax,rax
       je        near ptr M00_L21
       mov       rdi,rax
M00_L02:
       mov       rsi,r15
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L34
       mov       rdi,[rbx]
       mov       rsi,[rdi+30]
       mov       rsi,[rsi]
       mov       rax,[rsi+20]
       test      rax,rax
       je        near ptr M00_L22
       mov       rdi,rax
M00_L03:
       mov       rax,rdi
       test      r15,r15
       jne       near ptr M00_L23
M00_L04:
       lea       rax,[rbx+20]
       cmp       qword ptr [rax],0
       jne       near ptr M00_L33
M00_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdi,[r14]
       mov       rsi,[rdi+30]
       mov       rsi,[rsi]
       mov       rsi,[rsi+10]
       test      rsi,rsi
       je        near ptr M00_L25
M00_L06:
       mov       rdi,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdi,[r15]
       mov       rsi,[rdi+30]
       mov       rsi,[rsi]
       mov       rsi,[rsi+18]
       test      rsi,rsi
       je        near ptr M00_L26
M00_L07:
       mov       rdi,rsi
       call      CORINFO_HELP_NEWSFAST
       xor       edi,edi
       mov       [rax+8],rdi
       mov       [rax+10],rdi
       mov       [rax+18],rdi
       mov       dword ptr [rax+34],2000440
       lea       rdi,[r15+8]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdi,[r14+10]
       mov       rsi,r15
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdi,[r14+8]
       mov       rsi,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdi,[rbx+8]
       test      rdi,rdi
       je        near ptr M00_L38
       mov       rsi,r14
       xor       edx,edx
       call      0000742B7C074060
       test      rax,rax
       jne       near ptr M00_L01
       xor       edi,edi
       mov       [rbp-38],rdi
       mov       [rbp-58],r14
       mov       dword ptr [rbp-40],0FFFFFFFF
       mov       rdi,[r14]
       mov       rsi,[rdi+30]
       mov       rsi,[rsi]
       mov       rax,[rsi+18]
       test      rax,rax
       je        near ptr M00_L29
       mov       rdi,rax
M00_L08:
       mov       rsi,[rdi+18]
       mov       rbx,[rsi+10]
       test      rbx,rbx
       je        near ptr M00_L30
M00_L09:
       mov       rdi,742B7C2A0D68
       mov       rax,742B7CC57820
       call      rax
       cmp       dword ptr [rax],4
       jle       near ptr M00_L39
       mov       rdi,[rax+8]
       mov       rax,[rdi+20]
       test      rax,rax
       je        near ptr M00_L39
M00_L10:
       mov       r15,[rax+10]
       test      r15,r15
       jne       short M00_L11
       call      qword ptr [742AFE4AC048]; System.Threading.Thread.InitializeCurrentThread()
       mov       r15,rax
M00_L11:
       mov       [rbp-68],r15
       mov       rsi,[r15+8]
       mov       [rbp-70],rsi
       mov       rsi,[r15+10]
       mov       [rbp-78],rsi
       mov       rdi,[rbx+18]
       mov       rax,[rdi+10]
       test      rax,rax
       je        short M00_L13
M00_L12:
       lea       rdi,[rbp-58]
       call      rax
       jmp       short M00_L14
M00_L13:
       mov       rdi,rbx
       mov       rsi,742AFE7DB4E0
       call      qword ptr [742AFDC5F3A8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       jmp       short M00_L12
M00_L14:
       mov       rsi,[rbp-78]
       cmp       rsi,[r15+10]
       je        short M00_L15
       lea       rdi,[r15+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L15:
       mov       rdi,[r15+8]
       mov       rbx,rdi
       mov       rsi,[rbp-70]
       cmp       rsi,rbx
       je        short M00_L17
       lea       rdi,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M00_L16
       cmp       qword ptr [rbx+10],0
       jne       near ptr M00_L41
M00_L16:
       cmp       qword ptr [rbp-70],0
       jne       near ptr M00_L40
M00_L17:
       cmp       qword ptr [rbp-38],0
       je        near ptr M00_L42
M00_L18:
       mov       rax,[r14+10]
       mov       rax,[rax+8]
M00_L19:
       add       rsp,68
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L20:
       mov       rdi,rsi
       mov       rsi,742AFE7DA010
       call      qword ptr [742AFDC5F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M00_L00
M00_L21:
       mov       rsi,742AFE7DA588
       call      qword ptr [742AFDC5F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L22:
       mov       rsi,742AFE7DA598
       call      qword ptr [742AFDC5F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M00_L03
M00_L23:
       cmp       [r15],rax
       jne       near ptr M00_L04
       mov       rdi,r15
       call      qword ptr [742AFE7B68B0]
       test      eax,eax
       je        near ptr M00_L28
       mov       rdi,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdi,r15
       mov       rsi,742AF4C09FE0
       call      qword ptr [742AFE4A5260]
       mov       rdi,[rbx]
       mov       rsi,[rdi+30]
       mov       rsi,[rsi]
       mov       rax,[rsi+28]
       test      rax,rax
       je        short M00_L27
       mov       rdi,rax
M00_L24:
       mov       rsi,r15
       call      qword ptr [742AFE7B6868]
       jmp       near ptr M00_L19
M00_L25:
       mov       rsi,742AFE7DAA40
       call      qword ptr [742AFDC5F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M00_L06
M00_L26:
       mov       rsi,742AFE821AE0
       call      qword ptr [742AFDC5F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M00_L07
M00_L27:
       mov       rsi,742AFE7DA6E0
       call      qword ptr [742AFDC5F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       short M00_L24
M00_L28:
       mov       rdi,r15
       xor       esi,esi
       call      qword ptr [742AFE7B68C8]; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.__Canon, System.Private.CoreLib]].WaitAsync(System.Threading.CancellationToken)
       jmp       near ptr M00_L19
M00_L29:
       mov       rsi,742AFE7DB180
       call      qword ptr [742AFDC5F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M00_L08
M00_L30:
       mov       rsi,742AFE7DB358
       call      qword ptr [742AFDC5F3A8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rbx,rax
       jmp       near ptr M00_L09
M00_L31:
       mov       edi,1
       mov       rsi,742AFE7E7CB0
       call      qword ptr [742AFDC5EF88]
       mov       rdi,rax
       call      qword ptr [742AFE7BD8C0]
       int       3
M00_L32:
       jmp       near ptr M00_L19
M00_L33:
       mov       rax,[rax]
       cmp       dword ptr [rax+20],0
       je        near ptr M00_L05
       jmp       short M00_L35
M00_L34:
       jmp       near ptr M00_L19
M00_L35:
       mov       rdi,[rbx]
       mov       rsi,[rdi+30]
       mov       rsi,[rsi]
       mov       rax,[rsi+10]
       test      rax,rax
       je        short M00_L36
       mov       rdi,rax
       jmp       short M00_L37
M00_L36:
       mov       rsi,742AFE7DA390
       call      qword ptr [742AFDC5F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M00_L37:
       mov       rsi,[rbx+20]
       call      qword ptr [742AFE7B67D8]
       jmp       near ptr M00_L19
M00_L38:
       call      qword ptr [742AFE7BD800]
       int       3
M00_L39:
       mov       edi,4
       call      qword ptr [742AFE7BD8D8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L10
M00_L40:
       mov       rsi,[rbp-70]
       cmp       qword ptr [rsi+10],0
       je        near ptr M00_L17
M00_L41:
       mov       rdi,rbx
       mov       rsi,[rbp-70]
       call      qword ptr [742AFE7BD878]
       jmp       near ptr M00_L17
M00_L42:
       lea       rdi,[rbp-38]
       call      qword ptr [742AFE7BD890]
       jmp       near ptr M00_L18
       push      rax
       mov       rsi,[rbp-78]
       mov       rax,[rbp-68]
       cmp       rsi,[rax+10]
       je        short M00_L43
       lea       rdi,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-68]
M00_L43:
       mov       r14,[rax+8]
       mov       rsi,[rbp-70]
       cmp       rsi,r14
       je        short M00_L46
       lea       rdi,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      r14,r14
       je        short M00_L44
       cmp       qword ptr [r14+10],0
       jne       short M00_L45
M00_L44:
       cmp       qword ptr [rbp-70],0
       je        short M00_L46
       mov       rsi,[rbp-70]
       cmp       qword ptr [rsi+10],0
       je        short M00_L46
M00_L45:
       mov       rdi,r14
       mov       rsi,[rbp-70]
       call      qword ptr [742AFE7BD878]
M00_L46:
       nop
       add       rsp,8
       ret
; Total bytes of code 1258
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.__Canon, System.Private.CoreLib]](System.Threading.Tasks.Task`1<System.__Canon>)
       push      rbx
       mov       rbx,rsi
       mov       edi,[rbx+34]
       and       edi,11000000
       cmp       edi,1000000
       jne       short M01_L01
M01_L00:
       mov       rax,[rbx+38]
       pop       rbx
       ret
M01_L01:
       mov       rdi,rbx
       xor       esi,esi
       call      qword ptr [742AFE7BD728]
       jmp       short M01_L00
; Total bytes of code 40
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
M02_L02:
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
       test      rax,rax
       je        short M02_L03
       mov       rax,[rax+10]
       jmp       short M02_L02
M02_L03:
       xor       esi,esi
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
       push      rbx
       sub       rsp,68
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-30],rax
       lea       rdi,[rbp-30]
       mov       [rbp-90],rdi
       lea       rdi,[rbp-88]
       call      qword ptr [742AFD7FEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdi,[rbp-90]
       call      qword ptr [rax]
       lea       rdi,[rbp-88]
       call      qword ptr [742AFD7FEF08]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-30]
       call      qword ptr [742AFD800B98]
       lea       rdi,[rax+10]
       mov       rsi,[rbp-30]
       call      qword ptr [742AFD7FEEB8]; CORINFO_HELP_ASSIGN_REF
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
; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0B0]
       mov       [rbp-8C],rdi
       mov       rdx,rsi
       mov       [rbp-94],rdx
       xor       esi,esi
       mov       [rbp-9C],rsi
       mov       ecx,0FFFFFFFF
       mov       [rbp-84],ecx
       xor       r8d,r8d
       mov       [rbp-0A4],r8
       lea       rdi,[rbp-80]
       call      qword ptr [742AFD7FEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdi,[rbp-8C]
       mov       rdx,[rbp-94]
       mov       rsi,[rbp-9C]
       mov       ecx,[rbp-84]
       mov       r8,[rbp-0A4]
       call      qword ptr [rax]
       mov       rbx,rax
       lea       rdi,[rbp-80]
       call      qword ptr [742AFD7FEF08]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rax,rbx
       add       rsp,88
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 159
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
       call      qword ptr [742AFD7FEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdx,[rbp-8C]
       mov       rsi,[rbp-94]
       mov       rdi,[rbp-9C]
       mov       ecx,[rbp-84]
       mov       r8,[rbp-0A4]
       call      qword ptr [rax]
       mov       rbx,rax
       lea       rdi,[rbp-80]
       call      qword ptr [742AFD7FEF08]; CORINFO_HELP_JIT_PINVOKE_END
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
; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.__Canon, System.Private.CoreLib]].WaitAsync(System.Threading.CancellationToken)
       push      r15
       push      rbx
       push      rax
       mov       rbx,rsi
       test      rbx,rbx
       jne       short M06_L00
       mov       rax,[rdi+10]
       mov       rax,[rax+8]
       add       rsp,8
       pop       rbx
       pop       r15
       ret
M06_L00:
       mov       rdi,[rdi+10]
       mov       r15,[rdi+8]
       cmp       [r15],r15b
       mov       rdi,offset MT_System.TimeProvider
       call      qword ptr [742AFDC55728]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,741B3CC013C8
       mov       rdx,[rdx]
       mov       rcx,rbx
       mov       rdi,r15
       mov       esi,0FFFFFFFF
       add       rsp,8
       pop       rbx
       pop       r15
       jmp       qword ptr [742AFE7BDB78]
; Total bytes of code 92
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbp
       push      rbx
       push      rax
       lea       rbp,[rsp+10]
       mov       ebx,edi
       call      qword ptr [742AFD816AF0]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.__Canon, System.Private.CoreLib]].AsyncLazy_NoRecursionDetection()
       push      rbp
       push      r15
       push      rbx
       sub       rsp,10
       lea       rbp,[rsp+20]
       mov       [rbp-18],rdi
       mov       rbx,rdi
       mov       rdi,[rbx]
       mov       rsi,[rdi+30]
       mov       rsi,[rsi]
       mov       rsi,[rsi+28]
       test      rsi,rsi
       je        short M00_L01
M00_L00:
       mov       rdi,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M00_L02
       lea       rdi,[r15+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[r15+10]
       test      rax,rax
       jne       short M00_L03
       mov       rdi,r15
       xor       esi,esi
       add       rsp,10
       pop       rbx
       pop       r15
       pop       rbp
       jmp       qword ptr [7D4292B96928]; System.Threading.Tasks.AsyncLazy`1[[System.__Canon, System.Private.CoreLib]].GetOrStartAttemptAsync(System.Threading.CancellationToken)
M00_L01:
       mov       rsi,7D4292BBA0A0
       call      qword ptr [7D429203F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       short M00_L00
M00_L02:
       mov       edi,1
       mov       rsi,7D4292BC7EA0
       call      qword ptr [7D429203EF88]
       mov       rdi,rax
       call      qword ptr [7D4292B9ECB8]
       int       3
M00_L03:
       add       rsp,10
       pop       rbx
       pop       r15
       pop       rbp
       ret
; Total bytes of code 157
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.__Canon, System.Private.CoreLib]](System.Threading.Tasks.Task`1<System.__Canon>)
       push      rbx
       mov       rbx,rsi
       mov       edi,[rbx+34]
       and       edi,11000000
       cmp       edi,1000000
       jne       short M01_L01
M01_L00:
       mov       rax,[rbx+38]
       pop       rbx
       ret
M01_L01:
       mov       rdi,rbx
       xor       esi,esi
       call      qword ptr [7D4292B97600]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 40
```
```assembly
; System.Threading.Tasks.AsyncLazy`1[[System.__Canon, System.Private.CoreLib]].GetOrStartAttemptAsync(System.Threading.CancellationToken)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+50]
       mov       [rbp-30],rdi
       mov       rbx,rdi
       mov       r15,rsi
M02_L00:
       mov       r14,[rbx+8]
       mov       r13,[rbx]
       mov       rdi,r13
       mov       rsi,[rdi+30]
       mov       rsi,[rsi]
       mov       rax,[rsi+18]
       test      rax,rax
       je        near ptr M02_L18
       mov       rdi,rax
M02_L01:
       mov       rsi,r14
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M02_L30
       mov       rdi,[r13+30]
       mov       rdi,[rdi]
       mov       rdi,[rdi+20]
       test      rdi,rdi
       je        near ptr M02_L19
M02_L02:
       mov       rax,rdi
       test      r14,r14
       jne       near ptr M02_L20
M02_L03:
       lea       rax,[rbx+20]
       cmp       qword ptr [rax],0
       jne       near ptr M02_L29
M02_L04:
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rdi,[r12]
       mov       rsi,[rdi+30]
       mov       rsi,[rsi]
       mov       rsi,[rsi+10]
       test      rsi,rsi
       je        near ptr M02_L21
M02_L05:
       mov       rdi,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdi,[r14]
       mov       rsi,[rdi+30]
       mov       rsi,[rsi]
       mov       rsi,[rsi+18]
       test      rsi,rsi
       je        near ptr M02_L22
M02_L06:
       mov       rdi,rsi
       call      CORINFO_HELP_NEWSFAST
       xor       edi,edi
       mov       [rax+8],rdi
       mov       [rax+10],rdi
       mov       [rax+18],rdi
       mov       dword ptr [rax+34],2000440
       lea       rdi,[r14+8]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdi,[r12+10]
       mov       rsi,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdi,[r12+8]
       mov       rsi,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdi,[rbx+8]
       test      rdi,rdi
       je        near ptr M02_L34
       mov       rsi,r12
       xor       edx,edx
       call      00007D4310474060
       test      rax,rax
       jne       near ptr M02_L00
       mov       rdi,[r13+30]
       mov       rdi,[rdi]
       mov       rdi,[rdi+28]
       test      rdi,rdi
       je        near ptr M02_L23
M02_L07:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r14,[rax+8]
       test      r14,r14
       je        near ptr M02_L35
M02_L08:
       mov       rdi,[r13+30]
       mov       rdi,[rdi]
       mov       rax,[rdi+30]
       test      rax,rax
       je        near ptr M02_L24
       mov       r13,rax
M02_L09:
       mov       rdi,7D43106A0D68
       mov       rax,7D4311086820
       call      rax
       cmp       dword ptr [rax],4
       jle       near ptr M02_L43
       mov       rdi,[rax+8]
       mov       rax,[rdi+20]
       test      rax,rax
       je        near ptr M02_L43
M02_L10:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M02_L11
       call      qword ptr [7D429288C048]; System.Threading.Thread.InitializeCurrentThread()
M02_L11:
       mov       rdi,[rax+8]
       test      rdi,rdi
       jne       near ptr M02_L44
       mov       rdi,7D32CCC01390
       mov       rdi,[rdi]
M02_L12:
       test      rdi,rdi
       je        short M02_L13
       mov       [rbp-48],rdi
       cmp       byte ptr [rdi+19],0
       je        near ptr M02_L45
M02_L13:
       mov       rdi,[r13+18]
       mov       rdi,[rdi+18]
       test      rdi,rdi
       je        near ptr M02_L25
M02_L14:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rdi,[r13+8]
       mov       rsi,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdi,[r13+10]
       mov       rsi,r12
       call      CORINFO_HELP_ASSIGN_REF
M02_L15:
       mov       rdi,7D32CCC013A0
       mov       r14,[rdi]
       cmp       byte ptr [r14+38],0
       jne       near ptr M02_L48
M02_L16:
       mov       rdi,[r14+8]
       mov       rsi,[rdi+10]
       mov       rcx,[rsi+8]
M02_L17:
       mov       edx,[rsi+0A0]
       mov       eax,edx
       and       eax,[rsi+18]
       cmp       eax,[rcx+8]
       jae       near ptr M02_L51
       shl       rax,4
       lea       r8,[rcx+rax+10]
       mov       eax,[r8+8]
       sub       eax,edx
       jne       near ptr M02_L26
       lea       r9,[rsi+0A0]
       lea       r10d,[rdx+1]
       mov       eax,edx
       lock cmpxchg [r9],r10d
       cmp       eax,edx
       mov       [rbp-34],edx
       jne       short M02_L17
       mov       rcx,r8
       mov       [rbp-50],rcx
       mov       rdi,rcx
       mov       rsi,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13d,[rbp-34]
       inc       r13d
       mov       rdi,[rbp-50]
       mov       [rdi+8],r13d
       jmp       near ptr M02_L27
M02_L18:
       mov       rsi,7D4292BBA618
       call      qword ptr [7D429203F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M02_L01
M02_L19:
       mov       rdi,r13
       mov       rsi,7D4292BBA628
       call      qword ptr [7D429203F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M02_L02
M02_L20:
       cmp       [r14],rax
       jne       near ptr M02_L03
       mov       rdi,r14
       mov       rsi,r15
       add       rsp,28
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7D4292B969B8]; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.__Canon, System.Private.CoreLib]].WaitAsync(System.Threading.CancellationToken)
M02_L21:
       mov       rsi,7D4292BBD1A8
       call      qword ptr [7D429203F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M02_L05
M02_L22:
       mov       rsi,7D4292BE73F0
       call      qword ptr [7D429203F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M02_L06
M02_L23:
       mov       rdi,r13
       mov       rsi,7D4292BBA820
       call      qword ptr [7D429203F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M02_L07
M02_L24:
       mov       rdi,r13
       mov       rsi,7D4292BBCD48
       call      qword ptr [7D429203F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M02_L09
M02_L25:
       mov       rdi,r13
       mov       rsi,7D4292BE7718
       call      qword ptr [7D429203F3A8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M02_L14
M02_L26:
       test      eax,eax
       jge       near ptr M02_L17
       mov       rsi,r13
       call      qword ptr [7D4292B9EDF0]
M02_L27:
       add       r14,78
       mov       edi,1
       xchg      edi,[r14]
       test      edi,edi
       jne       short M02_L28
       mov       rdi,7D32CCC013C8
       mov       r14,[rdi]
       lea       rdi,[r14+160]
       lock inc  dword ptr [rdi]
       mov       rdi,r14
       call      qword ptr [7D4292B96E20]; System.Threading.PortableThreadPool+WorkerThread.MaybeAddWorkingWorker(System.Threading.PortableThreadPool)
       cmp       dword ptr [r14+164],6
       jne       near ptr M02_L49
M02_L28:
       test      r15,r15
       jne       near ptr M02_L50
       mov       rax,[r12+10]
       mov       rax,[rax+8]
       add       rsp,28
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L29:
       mov       rax,[rax]
       cmp       dword ptr [rax+20],0
       je        near ptr M02_L04
       jmp       short M02_L31
M02_L30:
       add       rsp,28
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L31:
       mov       rdi,[r13+30]
       mov       rdi,[rdi]
       mov       rdi,[rdi+10]
       test      rdi,rdi
       je        short M02_L32
       jmp       short M02_L33
M02_L32:
       mov       rdi,r13
       mov       rsi,7D4292BBA420
       call      qword ptr [7D429203F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M02_L33:
       mov       rsi,[rbx+20]
       add       rsp,28
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7D4292B968C8]
M02_L34:
       call      qword ptr [7D4292B9EC70]
       int       3
M02_L35:
       mov       rdi,[r13+30]
       mov       rdi,[rdi]
       mov       r14,[rdi+28]
       test      r14,r14
       je        short M02_L36
       jmp       short M02_L37
M02_L36:
       mov       rdi,r13
       mov       rsi,7D4292BBA820
       call      qword ptr [7D429203F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
M02_L37:
       mov       rdi,[r13+30]
       mov       rdi,[rdi]
       cmp       qword ptr [rdi+8],38
       jle       short M02_L38
       mov       rdi,[rdi+38]
       test      rdi,rdi
       je        short M02_L38
       jmp       short M02_L39
M02_L38:
       mov       rdi,r13
       mov       rsi,7D4292BBCE30
       call      qword ptr [7D429203F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M02_L39:
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rdi,r14
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rsi,[rax]
       test      rsi,rsi
       jne       short M02_L40
       call      qword ptr [7D4292B9F378]
       int       3
M02_L40:
       mov       r14,[rbp-40]
       lea       rdi,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset System.Threading.Tasks.AsyncLazy`1+<>c[[System.__Canon, System.Private.CoreLib]].<GetOrStartAttemptAsync>b__11_0(Attempt<System.__Canon>)
       mov       [r14+18],rdi
       mov       rdi,[r13+30]
       mov       rdi,[rdi]
       mov       rdi,[rdi+28]
       test      rdi,rdi
       je        short M02_L41
       jmp       short M02_L42
M02_L41:
       mov       rdi,r13
       mov       rsi,7D4292BBA820
       call      qword ptr [7D429203F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M02_L42:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       lea       rdi,[rax+8]
       mov       rsi,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L08
M02_L43:
       mov       edi,4
       call      qword ptr [7D4292B9EA90]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M02_L10
M02_L44:
       xor       esi,esi
       cmp       byte ptr [rdi+18],0
       cmovne    rdi,rsi
       jmp       near ptr M02_L12
M02_L45:
       mov       rsi,[r13+18]
       mov       rsi,[rsi+20]
       test      rsi,rsi
       je        short M02_L46
       jmp       short M02_L47
M02_L46:
       mov       rdi,r13
       mov       rsi,7D4292BE78B0
       call      qword ptr [7D429203F3A8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
M02_L47:
       mov       rdi,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdi,r13
       mov       rsi,r14
       mov       rdx,r12
       mov       rcx,[rbp-48]
       call      qword ptr [7D4292B9EDA8]
       jmp       near ptr M02_L15
M02_L48:
       mov       rdi,7D32CCC013B8
       mov       rdi,[rdi]
       cmp       byte ptr [rdi+9D],0
       je        near ptr M02_L16
       mov       rdi,7D32CCC013B8
       mov       rdi,[rdi]
       mov       rsi,r13
       call      qword ptr [7D4292B9EDC0]
       jmp       near ptr M02_L16
M02_L49:
       mov       rdi,r14
       call      qword ptr [7D4292B97078]; System.Threading.PortableThreadPool+GateThread.EnsureRunningSlow(System.Threading.PortableThreadPool)
       jmp       near ptr M02_L28
M02_L50:
       mov       rdi,[r12+10]
       mov       r14,[rdi+8]
       cmp       [r14],r14b
       mov       rdi,offset MT_System.TimeProvider
       call      qword ptr [7D4292035728]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,7D32CCC01478
       mov       rdx,[rdx]
       mov       rcx,r15
       mov       rdi,r14
       mov       esi,0FFFFFFFF
       add       rsp,28
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7D4292B9F390]
M02_L51:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1532
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
       call      qword ptr [7D4291BDEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdx,[rbp-8C]
       mov       rsi,[rbp-94]
       mov       rdi,[rbp-9C]
       mov       ecx,[rbp-84]
       mov       r8,[rbp-0A4]
       call      qword ptr [rax]
       mov       rbx,rax
       lea       rdi,[rbp-80]
       call      qword ptr [7D4291BDEF08]; CORINFO_HELP_JIT_PINVOKE_END
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
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rbp
       push      r15
       push      rbx
       lea       rbp,[rsp+10]
       mov       rbx,rdi
       mov       r15d,esi
       test      dword ptr [rbx+34],1600000
       jne       short M04_L00
       mov       rdi,rbx
       mov       esi,0FFFFFFFF
       xor       edx,edx
       call      qword ptr [7D4292B97618]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M04_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M04_L03
M04_L01:
       mov       edi,[rbx+34]
       and       edi,1600000
       cmp       edi,1000000
       jne       short M04_L04
M04_L02:
       pop       rbx
       pop       r15
       pop       rbp
       ret
M04_L03:
       mov       rdi,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M04_L01
       mov       rdi,rbx
       call      qword ptr [7D4292B9EE50]
       jmp       short M04_L01
M04_L04:
       test      r15b,2
       jne       short M04_L05
       mov       rdi,rbx
       call      qword ptr [7D4292B9EE80]
M04_L05:
       mov       rdi,rbx
       call      qword ptr [7D4292B9F828]
       jmp       short M04_L02
; Total bytes of code 125
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.__Canon, System.Private.CoreLib]].Nito()
       push      rbp
       push      r15
       push      r14
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       [rbp-20],rdi
       mov       [rbp-30],rdi
       mov       rsi,[rdi]
       mov       rax,[rsi+30]
       mov       rax,[rax]
       mov       rbx,[rax+28]
       test      rbx,rbx
       je        near ptr M00_L09
M00_L00:
       mov       rdi,[rbp-30]
       mov       r15,[rdi+8]
       test      r15,r15
       je        near ptr M00_L13
       mov       rsi,[rbx+30]
       mov       rsi,[rsi]
       mov       rsi,[rsi+18]
       test      rsi,rsi
       je        near ptr M00_L10
M00_L01:
       mov       rdi,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rdi,[r14+8]
       mov       rsi,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+30]
       mov       rdi,[rdi]
       mov       rdi,[rdi+20]
       test      rdi,rdi
       je        near ptr M00_L11
M00_L02:
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rdi,[r15+8]
       mov       rsi,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset Nito.AsyncEx.AsyncLazy`1+<>c__DisplayClass14_0[[System.__Canon, System.Private.CoreLib]].<RunOnThreadPool>b__0()
       mov       [r15+18],rdi
       mov       rdi,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdi,[rbx+30]
       mov       rdi,[rdi]
       mov       rdi,[rdi+10]
       test      rdi,rdi
       je        near ptr M00_L12
M00_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rdi,[rbx+10]
       mov       rsi,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset MT_System.LazyHelper
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+10],8
       lea       rdi,[rbx+8]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-38],r14
       xor       edi,edi
       mov       [rbp-24],edi
       mov       rdi,r14
       call      00007E3F9C6E6020
       test      eax,eax
       je        short M00_L05
M00_L04:
       mov       dword ptr [rbp-24],1
       cmp       qword ptr [rbx+8],0
       je        short M00_L06
       mov       rdi,rbx
       call      qword ptr [7E3F1EC9C438]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       r15,rax
       jmp       short M00_L07
M00_L05:
       mov       rdi,r14
       call      qword ptr [7E3F1EFAC7F8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L04
M00_L06:
       mov       r15,[rbx+18]
M00_L07:
       mov       rdi,r14
       call      00007E3F9C6E6790
       test      eax,eax
       jne       near ptr M00_L14
M00_L08:
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L09:
       mov       rdi,rsi
       mov       rsi,7E3F1EFCBE18
       call      qword ptr [7E3F1E44F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rbx,rax
       jmp       near ptr M00_L00
M00_L10:
       mov       rdi,rbx
       mov       rsi,7E3F1EFCC220
       call      qword ptr [7E3F1E44F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M00_L01
M00_L11:
       mov       rdi,rbx
       mov       rsi,7E3F1EFCC248
       call      qword ptr [7E3F1E44F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L12:
       mov       rdi,rbx
       mov       rsi,7E3F1EFCBFE8
       call      qword ptr [7E3F1E44F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M00_L03
M00_L13:
       mov       rdi,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       edi,10E
       mov       rsi,7E3F1EFD7CB0
       call      qword ptr [7E3F1E44EF88]
       mov       rsi,rax
       mov       rdi,rbx
       call      qword ptr [7E3F1EC9E1C0]
       mov       rdi,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L14:
       mov       edi,eax
       mov       rsi,r14
       call      qword ptr [7E3F1EFAC7C8]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       near ptr M00_L08
       push      rax
       cmp       dword ptr [rbp-24],0
       je        short M00_L15
       mov       rdi,[rbp-38]
       call      00007E3F9C6E6790
       test      eax,eax
       je        short M00_L15
       mov       edi,eax
       mov       rsi,[rbp-38]
       call      qword ptr [7E3F1EFAC7C8]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M00_L15:
       nop
       add       rsp,8
       ret
; Total bytes of code 568
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.__Canon, System.Private.CoreLib]](System.Threading.Tasks.Task`1<System.__Canon>)
       push      rbx
       mov       rbx,rsi
       mov       edi,[rbx+34]
       and       edi,11000000
       cmp       edi,1000000
       jne       short M01_L01
M01_L00:
       mov       rax,[rbx+38]
       pop       rbx
       ret
M01_L01:
       mov       rdi,rbx
       xor       esi,esi
       call      qword ptr [7E3F1EFA75B8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 40
```
```assembly
; Nito.AsyncEx.AsyncLazy`1+<>c__DisplayClass14_0[[System.__Canon, System.Private.CoreLib]].<RunOnThreadPool>b__0()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rbx
       push      rax
       lea       rbp,[rsp+30]
       mov       [rbp-30],rdi
       mov       rbx,rdi
       mov       rdi,[rbx]
       mov       rsi,[rdi+30]
       mov       rsi,[rsi]
       mov       rsi,[rsi+10]
       test      rsi,rsi
       je        short M02_L02
M02_L00:
       mov       r15,[rbx+8]
       mov       rdi,[rsi+18]
       mov       r14,[rdi+18]
       test      r14,r14
       je        short M02_L03
M02_L01:
       test      r15,r15
       jne       short M02_L04
       mov       edi,2E
       call      qword ptr [7E3F1E44FAE0]
       int       3
M02_L02:
       mov       rsi,7E3F1EFCC4A8
       call      qword ptr [7E3F1E44F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       short M02_L00
M02_L03:
       mov       rdi,rsi
       mov       rsi,7E3F1EFF7E10
       call      qword ptr [7E3F1E44F3A8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r14,rax
       jmp       short M02_L01
M02_L04:
       mov       rdi,[r14+18]
       mov       rdi,[rdi+20]
       test      rdi,rdi
       je        near ptr M02_L09
M02_L05:
       call      qword ptr [7E3F1EFA6880]; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].get_Factory()
       mov       rdi,[rax]
       mov       rsi,[rdi+30]
       mov       rsi,[rsi]
       mov       rsi,[rsi+18]
       test      rsi,rsi
       je        near ptr M02_L10
M02_L06:
       mov       rdi,7E2F58C01398
       mov       r13,[rdi]
       mov       rdi,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rdi,[r12+8]
       mov       rsi,r15
       call      CORINFO_HELP_ASSIGN_REF
       xor       edi,edi
       mov       [r12+10],rdi
       lea       rdi,[r12+18]
       mov       rsi,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       edi,2008
       mov       [r12+34],edi
       mov       rdi,7E3F9CAA0D68
       mov       rax,7E3F9D37C820
       call      rax
       cmp       dword ptr [rax],4
       jle       near ptr M02_L32
       mov       rdi,[rax+8]
       mov       rax,[rdi+20]
       test      rax,rax
       je        near ptr M02_L32
M02_L07:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M02_L08
       call      qword ptr [7E3F1EC9C048]; System.Threading.Thread.InitializeCurrentThread()
M02_L08:
       mov       r15,[rax+8]
       test      r15,r15
       jne       short M02_L11
       mov       rdi,7E2F58C013A8
       mov       r15,[rdi]
       jmp       short M02_L12
M02_L09:
       mov       rdi,r14
       mov       rsi,7E3F1EFF7FA0
       call      qword ptr [7E3F1E44F3A8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M02_L05
M02_L10:
       mov       rsi,7E3F1EFF81E0
       call      qword ptr [7E3F1E44F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M02_L06
M02_L11:
       xor       edi,edi
       cmp       byte ptr [r15+18],0
       cmovne    r15,rdi
M02_L12:
       test      r15,r15
       je        short M02_L13
       mov       rdi,7E2F58C013A8
       cmp       r15,[rdi]
       je        short M02_L14
       mov       rdi,r12
       call      qword ptr [7E3F1EFAEF58]
       lea       rdi,[rax+8]
       mov       rsi,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M02_L14
M02_L13:
       or        dword ptr [r12+34],20000000
M02_L14:
       mov       rdi,r12
       xor       esi,esi
       call      qword ptr [7E3F1EFA6A18]; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
       mov       rdi,[r14+18]
       mov       rdi,[rdi+28]
       test      rdi,rdi
       je        short M02_L17
M02_L15:
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       movzx     r14d,word ptr [r12+34]
       and       r14d,4
       test      r14d,0FFFFFFBB
       je        short M02_L18
M02_L16:
       mov       edi,2D
       call      qword ptr [7E3F1E44F0D8]
       int       3
M02_L17:
       mov       rdi,r14
       mov       rsi,7E3F1EFF8038
       call      qword ptr [7E3F1E44F3A8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       short M02_L15
M02_L18:
       test      r14b,4
       je        short M02_L20
       mov       rdi,7E3F9CAA0D68
       mov       rax,7E3F9D37C820
       call      rax
       cmp       dword ptr [rax],8
       jle       near ptr M02_L33
       mov       rdi,[rax+8]
       mov       rax,[rdi+40]
       test      rax,rax
       je        near ptr M02_L33
M02_L19:
       mov       r13,[rax+10]
       test      r13,r13
       je        short M02_L20
       mov       rdi,r15
       call      qword ptr [7E3F1EFAEF58]
       lea       rdi,[rax+30]
       mov       rsi,r13
       call      CORINFO_HELP_ASSIGN_REF
M02_L20:
       xor       edi,edi
       mov       [r15+8],rdi
       mov       [r15+10],rdi
       mov       [r15+18],rdi
       test      r14d,0FFFFFFA0
       jne       near ptr M02_L16
       mov       edi,r14d
       or        edi,400
       or        edi,2000000
       mov       [r15+34],edi
       mov       rdi,[r15+28]
       test      rdi,rdi
       jne       near ptr M02_L34
M02_L21:
       mov       byte ptr [r15+41],1
       mov       rax,7E2F58C013B8
       mov       rax,[rax]
       cmp       byte ptr [rax+9D],0
       je        short M02_L23
       cmp       dword ptr [r15+30],0
       jne       short M02_L22
       call      qword ptr [7E3F1EFAEC10]
       mov       esi,eax
       lea       rdi,[r15+30]
       xor       eax,eax
       lock cmpxchg [rdi],esi
M02_L22:
       mov       esi,[r15+30]
       mov       rdi,7E2F58C013B8
       mov       rdi,[rdi]
       mov       rdx,7E3F1540AF68
       xor       ecx,ecx
       call      qword ptr [7E3F1EFAEF70]
M02_L23:
       cmp       byte ptr [7E3F1D45B06C],0
       je        short M02_L24
       mov       rdi,r15
       call      qword ptr [7E3F1EFAEF88]
M02_L24:
       test      dword ptr [r12+34],1600000
       jne       short M02_L26
       test      dword ptr [r12+34],1600000
       jne       short M02_L25
       cmp       qword ptr [r12+20],0
       jne       near ptr M02_L39
       lea       rdi,[r12+20]
       test      rdi,rdi
       je        near ptr M02_L38
       mov       rsi,r15
       xor       edx,edx
       call      00007E3F9C874060
       test      rax,rax
       je        near ptr M02_L31
       jmp       near ptr M02_L39
M02_L25:
       mov       rdi,r15
       mov       rsi,r12
       call      qword ptr [7E3F1EFE6228]; System.Threading.Tasks.UnwrapPromise`1[[System.__Canon, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
       jmp       near ptr M02_L31
M02_L26:
       mov       byte ptr [r15+40],1
       mov       rdi,r12
       call      qword ptr [7E3F1EFA7A80]; System.Threading.Tasks.Task.get_Status()
       cmp       eax,5
       jne       near ptr M02_L35
       mov       rdi,[r15]
       mov       rsi,[rdi+30]
       mov       rsi,[rsi+8]
       mov       rax,[rsi+20]
       test      rax,rax
       je        short M02_L28
       mov       rdi,rax
M02_L27:
       mov       rsi,r12
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M02_L36
       mov       edi,[rax+34]
       and       edi,11000000
       cmp       edi,1000000
       jne       short M02_L29
       mov       rsi,[rax+38]
       jmp       short M02_L30
M02_L28:
       mov       rsi,7E3F1EFF6480
       call      qword ptr [7E3F1E44F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       short M02_L27
M02_L29:
       mov       rdi,rax
       mov       esi,1
       call      qword ptr [7E3F1EFAECB8]
       mov       rsi,rax
M02_L30:
       mov       rdi,r15
       call      qword ptr [7E3F1EFA7A98]; System.Threading.Tasks.UnwrapPromise`1[[System.__Canon, System.Private.CoreLib]].ProcessInnerTask(System.Threading.Tasks.Task)
M02_L31:
       mov       rax,r15
       add       rsp,8
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L32:
       mov       edi,4
       call      qword ptr [7E3F1EFAE7F0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M02_L07
M02_L33:
       mov       edi,8
       call      qword ptr [7E3F1EFAE7F0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M02_L19
M02_L34:
       mov       rdi,[rdi+30]
       test      rdi,rdi
       je        near ptr M02_L21
       test      r14b,4
       je        near ptr M02_L21
       test      byte ptr [rdi+34],8
       jne       near ptr M02_L21
       call      qword ptr [7E3F1EFAE6A0]
       jmp       near ptr M02_L21
M02_L35:
       add       eax,0FFFFFFFA
       cmp       eax,1
       ja        short M02_L31
       movzx     edx,byte ptr [r15+41]
       mov       rdi,r15
       mov       rsi,r12
       call      qword ptr [7E3F1EFA7AB0]; System.Threading.Tasks.UnwrapPromise`1[[System.__Canon, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       jmp       short M02_L31
M02_L36:
       mov       rdi,r12
       mov       rax,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task>
       cmp       [rdi],rax
       je        short M02_L37
       mov       rsi,r12
       mov       rdi,rax
       call      qword ptr [7E3F1E874AF8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rdi,rax
M02_L37:
       cmp       [rdi],edi
       call      qword ptr [7E3F1EFA7AC8]; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].get_Result()
       mov       rsi,rax
       jmp       near ptr M02_L30
M02_L38:
       call      qword ptr [7E3F1EFAE718]
       int       3
M02_L39:
       mov       rdi,r12
       mov       rsi,r15
       xor       edx,edx
       call      qword ptr [7E3F1EFAC798]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M02_L31
       jmp       near ptr M02_L25
; Total bytes of code 1196
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
       call      00007E3F9C6E6020
       test      eax,eax
       je        short M03_L03
M03_L02:
       mov       dword ptr [rbp-14],1
       mov       rdi,[rbp-20]
       cmp       [rdi+8],rbx
       jne       short M03_L04
       mov       esi,2
       call      qword ptr [7E3F1EC9C468]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M03_L04
M03_L03:
       mov       rdi,rbx
       call      qword ptr [7E3F1EFAC7F8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M03_L02
M03_L04:
       mov       rdi,rbx
       call      00007E3F9C6E6790
       test      eax,eax
       jne       near ptr M03_L12
M03_L05:
       mov       rdi,[rbp-20]
       cmp       qword ptr [rdi+8],0
       je        near ptr M03_L13
       add       rsp,28
       pop       rbx
       pop       rbp
       jmp       qword ptr [7E3F1EC9C438]
M03_L06:
       cmp       eax,8
       ja        short M03_L07
       mov       eax,eax
       lea       rcx,[7E3F1E4C7840]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M03_L01]
       add       rcx,rdx
       jmp       rcx
M03_L07:
       mov       rdi,[rbx+8]
       cmp       [rdi],edi
       call      qword ptr [7E3F1EFAEE20]
       int       3
       mov       rdi,[rbp-20]
       call      qword ptr [7E3F1EFAEDC0]
       jmp       short M03_L05
       mov       rdi,[rbp-20]
       xor       esi,esi
       call      qword ptr [7E3F1EC9C468]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
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
       mov       rsi,7E3F1EFF7878
       call      qword ptr [7E3F1E44F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M03_L09:
       mov       rdi,[rax+30]
       mov       rdi,[rdi]
       mov       rdi,[rdi+18]
       test      rdi,rdi
       je        short M03_L10
       jmp       short M03_L11
M03_L10:
       mov       rdi,rax
       mov       rsi,7E3F1EFF7918
       call      qword ptr [7E3F1E44F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M03_L11:
       call      qword ptr [7E3F1EFAED60]
       mov       rdx,rax
       mov       rsi,rbx
       mov       rdi,[rbp-20]
       call      qword ptr [7E3F1EFAEDD8]
       jmp       near ptr M03_L05
       mov       rdi,[rbp-20]
       mov       rsi,rbx
       call      qword ptr [7E3F1EFAEDF0]
       jmp       near ptr M03_L05
       mov       rdi,[rbp-20]
       call      qword ptr [7E3F1EFAEE08]
       jmp       near ptr M03_L05
       mov       rdi,[rbp-20]
       mov       rsi,rbx
       mov       edx,1
       call      qword ptr [7E3F1EC9C450]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M03_L05
M03_L12:
       mov       edi,eax
       mov       rsi,rbx
       call      qword ptr [7E3F1EFAC7C8]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
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
       call      00007E3F9C6E6790
       test      eax,eax
       je        short M03_L14
       mov       edi,eax
       mov       rsi,[rbp-28]
       call      qword ptr [7E3F1EFAC7C8]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
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
       call      qword ptr [7E3F1DFEEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdi,[rbp-90]
       call      qword ptr [rax]
       lea       rdi,[rbp-88]
       call      qword ptr [7E3F1DFEEF08]; CORINFO_HELP_JIT_PINVOKE_END
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
       call      qword ptr [7E3F1DFEEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdx,[rbp-8C]
       mov       rsi,[rbp-94]
       mov       rdi,[rbp-9C]
       mov       ecx,[rbp-84]
       mov       r8,[rbp-0A4]
       call      qword ptr [rax]
       mov       rbx,rax
       lea       rdi,[rbp-80]
       call      qword ptr [7E3F1DFEEF08]; CORINFO_HELP_JIT_PINVOKE_END
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
; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rbx
       sub       rsp,78
       lea       rbp,[rsp+0A0]
       mov       [rbp-30],rsi
       mov       esi,edi
       lea       rdi,[rbp-30]
       mov       [rbp-94],rdi
       mov       [rbp-8C],esi
       lea       rdi,[rbp-88]
       call      qword ptr [7E3F1DFEEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdi,[rbp-94]
       mov       esi,[rbp-8C]
       call      qword ptr [rax]
       lea       rdi,[rbp-88]
       call      qword ptr [7E3F1DFEEF08]; CORINFO_HELP_JIT_PINVOKE_END
       nop
       add       rsp,78
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 109
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
       call      qword ptr [7E3F1EFA75D0]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7E3F1EFAF420]
       jmp       short M07_L01
M07_L04:
       test      r15b,2
       jne       short M07_L05
       mov       rdi,rbx
       call      qword ptr [7E3F1EFAF438]
M07_L05:
       mov       rdi,rbx
       call      qword ptr [7E3F1EFAF948]
       jmp       short M07_L02
; Total bytes of code 125
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.__Canon, System.Private.CoreLib]].Nito_ExecuteOnCallingThread()
       push      rbp
       push      r15
       push      r14
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       [rbp-20],rdi
       mov       [rbp-30],rdi
       mov       rsi,[rdi]
       mov       rax,[rsi+30]
       mov       rax,[rax]
       mov       rbx,[rax+28]
       test      rbx,rbx
       je        near ptr M00_L07
M00_L00:
       mov       rdi,[rbp-30]
       mov       r15,[rdi+8]
       test      r15,r15
       je        near ptr M00_L09
       mov       rdi,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdi,[rbx+30]
       mov       rdi,[rdi]
       mov       rdi,[rdi+10]
       test      rdi,rdi
       je        near ptr M00_L08
M00_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rdi,[rbx+10]
       mov       rsi,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset MT_System.LazyHelper
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+10],8
       lea       rdi,[rbx+8]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-38],r14
       xor       edi,edi
       mov       [rbp-24],edi
       mov       rdi,r14
       call      00007B508E4E6020
       test      eax,eax
       je        short M00_L03
M00_L02:
       mov       dword ptr [rbp-24],1
       cmp       qword ptr [rbx+8],0
       je        short M00_L04
       mov       rdi,rbx
       call      qword ptr [7B5010AAC438]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       r15,rax
       jmp       short M00_L05
M00_L03:
       mov       rdi,r14
       call      qword ptr [7B5010DBCE58]
       jmp       short M00_L02
M00_L04:
       mov       r15,[rbx+18]
M00_L05:
       mov       rdi,r14
       call      00007B508E4E6790
       test      eax,eax
       jne       near ptr M00_L10
M00_L06:
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L07:
       mov       rdi,rsi
       mov       rsi,7B5010DDBE18
       call      qword ptr [7B501025F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rbx,rax
       jmp       near ptr M00_L00
M00_L08:
       mov       rdi,rbx
       mov       rsi,7B5010DDBFE8
       call      qword ptr [7B501025F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M00_L01
M00_L09:
       mov       rdi,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       edi,10E
       mov       rsi,7B5010DE7E98
       call      qword ptr [7B501025EF88]
       mov       rsi,rax
       mov       rdi,rbx
       call      qword ptr [7B5010AAE1C0]
       mov       rdi,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L10:
       mov       edi,eax
       mov       rsi,r14
       call      qword ptr [7B5010DBCD50]
       jmp       near ptr M00_L06
       push      rax
       cmp       dword ptr [rbp-24],0
       je        short M00_L11
       mov       rdi,[rbp-38]
       call      00007B508E4E6790
       test      eax,eax
       je        short M00_L11
       mov       edi,eax
       mov       rsi,[rbp-38]
       call      qword ptr [7B5010DBCD50]
M00_L11:
       nop
       add       rsp,8
       ret
; Total bytes of code 417
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.__Canon, System.Private.CoreLib]](System.Threading.Tasks.Task`1<System.__Canon>)
       push      rbx
       mov       rbx,rsi
       mov       edi,[rbx+34]
       and       edi,11000000
       cmp       edi,1000000
       jne       short M01_L01
M01_L00:
       mov       rax,[rbx+38]
       pop       rbx
       ret
M01_L01:
       mov       rdi,rbx
       xor       esi,esi
       call      qword ptr [7B5010DBCE10]
       jmp       short M01_L00
; Total bytes of code 40
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
       call      00007B508E4E6020
       test      eax,eax
       je        short M02_L03
M02_L02:
       mov       dword ptr [rbp-14],1
       mov       rdi,[rbp-20]
       cmp       [rdi+8],rbx
       jne       short M02_L04
       mov       esi,2
       call      qword ptr [7B5010AAC468]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M02_L04
M02_L03:
       mov       rdi,rbx
       call      qword ptr [7B5010DBCE58]
       jmp       short M02_L02
M02_L04:
       mov       rdi,rbx
       call      00007B508E4E6790
       test      eax,eax
       jne       near ptr M02_L12
M02_L05:
       mov       rdi,[rbp-20]
       cmp       qword ptr [rdi+8],0
       je        near ptr M02_L13
       add       rsp,28
       pop       rbx
       pop       rbp
       jmp       qword ptr [7B5010AAC438]
M02_L06:
       cmp       eax,8
       ja        short M02_L07
       mov       eax,eax
       lea       rcx,[7B50102CC340]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M02_L01]
       add       rcx,rdx
       jmp       rcx
M02_L07:
       mov       rdi,[rbx+8]
       cmp       [rdi],edi
       call      qword ptr [7B5010DBCF30]
       int       3
       mov       rdi,[rbp-20]
       call      qword ptr [7B5010DBCED0]
       jmp       short M02_L05
       mov       rdi,[rbp-20]
       xor       esi,esi
       call      qword ptr [7B5010AAC468]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
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
       mov       rsi,7B5010DDFEE0
       call      qword ptr [7B501025F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L09:
       mov       rdi,[rax+30]
       mov       rdi,[rdi]
       mov       rdi,[rdi+18]
       test      rdi,rdi
       je        short M02_L10
       jmp       short M02_L11
M02_L10:
       mov       rdi,rax
       mov       rsi,7B5010DDFF80
       call      qword ptr [7B501025F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M02_L11:
       call      qword ptr [7B5010DBCE70]
       mov       rdx,rax
       mov       rsi,rbx
       mov       rdi,[rbp-20]
       call      qword ptr [7B5010DBCEE8]
       jmp       near ptr M02_L05
       mov       rdi,[rbp-20]
       mov       rsi,rbx
       call      qword ptr [7B5010DBCF00]
       jmp       near ptr M02_L05
       mov       rdi,[rbp-20]
       call      qword ptr [7B5010DBCF18]
       jmp       near ptr M02_L05
       mov       rdi,[rbp-20]
       mov       rsi,rbx
       mov       edx,1
       call      qword ptr [7B5010AAC450]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M02_L05
M02_L12:
       mov       edi,eax
       mov       rsi,rbx
       call      qword ptr [7B5010DBCD50]
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
       call      00007B508E4E6790
       test      eax,eax
       je        short M02_L14
       mov       edi,eax
       mov       rsi,[rbp-28]
       call      qword ptr [7B5010DBCD50]
M02_L14:
       nop
       add       rsp,8
       ret
; Total bytes of code 441
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
       call      qword ptr [7B500FDFEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdx,[rbp-8C]
       mov       rsi,[rbp-94]
       mov       rdi,[rbp-9C]
       mov       ecx,[rbp-84]
       mov       r8,[rbp-0A4]
       call      qword ptr [rax]
       mov       rbx,rax
       lea       rdi,[rbp-80]
       call      qword ptr [7B500FDFEF08]; CORINFO_HELP_JIT_PINVOKE_END
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
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.__Canon, System.Private.CoreLib]].VsThreading()
       push      rbp
       push      r15
       push      r14
       push      rbx
       push      rax
       lea       rbp,[rsp+20]
       mov       [rbp-20],rdi
       mov       rbx,rdi
       mov       rdi,[rbx]
       mov       rsi,[rdi+30]
       mov       rsi,[rsi]
       mov       rsi,[rsi+28]
       test      rsi,rsi
       je        short M00_L01
M00_L00:
       mov       rdi,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r14,[rbx+8]
       mov       rdi,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rdi,[r15+8]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      r14,r14
       je        short M00_L02
       lea       rdi,[r15+20]
       mov       rsi,r14
       call      CORINFO_HELP_ASSIGN_REF
       xor       edi,edi
       mov       [r15+10],rdi
       mov       rdi,r15
       xor       esi,esi
       add       rsp,8
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [71CF6B1B6940]; Microsoft.VisualStudio.Threading.AsyncLazy`1[[System.__Canon, System.Private.CoreLib]].GetValueAsync(System.Threading.CancellationToken)
M00_L01:
       mov       rsi,71CF6B2046B0
       call      qword ptr [71CF6A65F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       short M00_L00
M00_L02:
       mov       rdi,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       edi,164
       mov       rsi,71CF6B1E7EA8
       call      qword ptr [71CF6A65EF88]
       mov       rsi,rax
       mov       rdi,r15
       call      qword ptr [71CF6AEAE1C0]
       mov       rdi,r15
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 205
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.__Canon, System.Private.CoreLib]](System.Threading.Tasks.Task`1<System.__Canon>)
       push      rbx
       mov       rbx,rsi
       mov       edi,[rbx+34]
       and       edi,11000000
       cmp       edi,1000000
       jne       short M01_L01
M01_L00:
       mov       rax,[rbx+38]
       pop       rbx
       ret
M01_L01:
       mov       rdi,rbx
       xor       esi,esi
       call      qword ptr [71CF6B1BF1E0]
       jmp       short M01_L00
; Total bytes of code 40
```
```assembly
; Microsoft.VisualStudio.Threading.AsyncLazy`1[[System.__Canon, System.Private.CoreLib]].GetValueAsync(System.Threading.CancellationToken)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rbx
       sub       rsp,138
       lea       rbp,[rsp+160]
       vxorps    xmm8,xmm8,xmm8
       vmovdqu32 [rbp-0D0],zmm8
       vmovdqu32 [rbp-90],zmm8
       vmovdqa   xmmword ptr [rbp-50],xmm8
       mov       [rbp-30],rdi
       mov       [rbp-0C0],rdi
       mov       [rbp-38],rsi
       mov       rsi,[rdi]
       mov       rax,[rsi+30]
       mov       rax,[rax]
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M02_L84
M02_L00:
       mov       rdi,rax
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0C8],rax
       lea       rdi,[rax+8]
       mov       rsi,[rbp-0C0]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-0C0]
       mov       rdi,[rsi+28]
       test      rdi,rdi
       jne       near ptr M02_L85
M02_L01:
       mov       rdi,[rsi+18]
       test      rdi,rdi
       jne       near ptr M02_L86
M02_L02:
       mov       rsi,[rbp-0C0]
       cmp       qword ptr [rsi+28],0
       jne       near ptr M02_L78
       mov       rdi,[rsi+8]
       test      rdi,rdi
       je        near ptr M02_L87
       call      000071CFE88E5C00
       test      eax,eax
       jne       near ptr M02_L88
       xor       edi,edi
       mov       rax,[rbp-0C8]
       mov       [rax+10],rdi
       mov       rsi,[rbp-0C0]
       mov       rdi,[rsi+8]
       mov       [rbp-0D0],rdi
       xor       edi,edi
       mov       [rbp-3C],edi
       cmp       qword ptr [rbp-0D0],0
       je        near ptr M02_L49
       mov       rdi,[rbp-0D0]
       call      000071CFE88E6020
       test      eax,eax
       je        near ptr M02_L50
M02_L03:
       mov       dword ptr [rbp-3C],1
       mov       rsi,[rbp-0C0]
       cmp       qword ptr [rsi+28],0
       jne       near ptr M02_L56
       cmp       qword ptr [rbp-38],0
       je        short M02_L04
       mov       rdi,[rbp-38]
       cmp       dword ptr [rdi+20],0
       jne       near ptr M02_L51
M02_L04:
       mov       rdi,offset MT_Microsoft.VisualStudio.Threading.InlineResumable
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,[rbp-0C8]
       lea       rdi,[rcx+10]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-0C0]
       mov       rsi,[rsi+20]
       mov       rcx,[rbp-0C8]
       lea       rdi,[rcx+18]
       call      CORINFO_HELP_ASSIGN_REF
       xor       edi,edi
       mov       rsi,[rbp-0C0]
       mov       [rsi+20],rdi
       mov       rdi,[rsi]
       mov       rax,[rdi+30]
       mov       rax,[rax]
       mov       rax,[rax+28]
       test      rax,rax
       je        near ptr M02_L11
M02_L05:
       mov       rdi,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rdi,[rbx+8]
       mov       rsi,[rbp-0C8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset Microsoft.VisualStudio.Threading.AsyncLazy`1+<>c__DisplayClass20_0[[System.__Canon, System.Private.CoreLib]].<GetValueAsync>b__0()
       mov       [rbx+18],rdi
       mov       rsi,[rbp-0C0]
       cmp       byte ptr [rsi+38],0
       jne       near ptr M02_L25
       cmp       qword ptr [rsi+18],0
       jne       near ptr M02_L52
M02_L06:
       mov       rdi,offset MT_Microsoft.VisualStudio.Threading.AsyncLocal<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdi,offset MT_System.Threading.AsyncLocal<System.Object>
       call      CORINFO_HELP_NEWSFAST
       lea       rdi,[r15+8]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-0C0]
       mov       rdi,[rsi]
       mov       rax,[rdi+30]
       mov       rax,[rax]
       mov       rax,[rax+38]
       test      rax,rax
       je        near ptr M02_L12
M02_L07:
       mov       rdi,rax
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r14,[rax]
       mov       r13,[r15+8]
       cmp       qword ptr [r13+8],0
       setne     r12b
       movzx     r12d,r12b
       mov       rdi,71CFE8CA0D68
       mov       rax,71CFE950E820
       call      rax
       cmp       dword ptr [rax],4
       jle       near ptr M02_L53
       mov       rdi,[rax+8]
       mov       rax,[rdi+20]
       test      rax,rax
       je        near ptr M02_L53
M02_L08:
       mov       [rbp-140],rax
       mov       rcx,[rax+10]
       test      rcx,rcx
       jne       short M02_L09
       call      qword ptr [71CF6AEAC048]; System.Threading.Thread.InitializeCurrentThread()
       mov       rcx,rax
M02_L09:
       mov       rcx,[rcx+8]
       mov       [rbp-0D8],rcx
       xor       edi,edi
       mov       [rbp-48],rdi
       xor       r8d,r8d
       test      rcx,rcx
       je        short M02_L10
       mov       rdi,[rcx+8]
       lea       rdx,[rbp-48]
       mov       rsi,r13
       mov       r11,71CF69670558
       call      qword ptr [r11]
       mov       [rbp-4C],eax
       mov       rcx,[rbp-0D8]
       mov       r8d,[rbp-4C]
M02_L10:
       cmp       [rbp-48],r14
       je        near ptr M02_L24
       xor       edi,edi
       mov       [rbp-58],rdi
       mov       [rbp-5C],edi
       test      rcx,rcx
       je        short M02_L13
       mov       [rbp-4C],r8d
       movzx     edx,byte ptr [rcx+18]
       mov       [rbp-5C],edx
       test      r12d,r12d
       sete      cl
       movzx     ecx,cl
       mov       r10,[rbp-0D8]
       mov       rdi,[r10+8]
       mov       rsi,r13
       mov       rdx,r14
       mov       r11,71CF69670550
       call      qword ptr [r11]
       mov       [rbp-0E0],rax
       mov       rdx,[rbp-0D8]
       mov       rdx,[rdx+10]
       mov       [rbp-58],rdx
       jmp       near ptr M02_L16
M02_L11:
       mov       rsi,71CF6B208F30
       call      qword ptr [71CF6A65F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L05
M02_L12:
       mov       rsi,71CF6B209338
       call      qword ptr [71CF6A65F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L07
M02_L13:
       test      r14,r14
       je        near ptr M02_L54
       mov       [rbp-4C],r8d
M02_L14:
       mov       rdi,offset MT_System.Threading.AsyncLocalValueMap+OneElementAsyncLocalValueMap
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       [rbp-0F8],rsi
       lea       rdi,[rsi+8]
       mov       rsi,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-0F8]
       lea       rdi,[rsi+10]
       mov       rsi,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-0F8]
       mov       rax,rsi
M02_L15:
       mov       [rbp-0E0],rax
M02_L16:
       test      r12d,r12d
       je        short M02_L18
       cmp       dword ptr [rbp-4C],0
       jne       short M02_L18
       cmp       qword ptr [rbp-58],0
       je        short M02_L17
       mov       rdx,[rbp-58]
       mov       ecx,[rdx+8]
       mov       [rbp-60],ecx
       lea       edx,[rcx+1]
       lea       rsi,[rbp-58]
       mov       rdi,71CF6B221728
       call      qword ptr [71CF6AA8C480]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       esi,[rbp-60]
       mov       rdi,[rbp-58]
       mov       rdx,r13
       call      qword ptr [71CF6A6557A0]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M02_L18
M02_L17:
       mov       rdi,offset MT_System.Threading.IAsyncLocal[]
       mov       esi,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rbp-0F0],rax
       lea       rdi,[rax+10]
       mov       rsi,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-0F0]
       mov       [rbp-58],rax
M02_L18:
       mov       rcx,[rbp-140]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       short M02_L19
       call      qword ptr [71CF6AEAC048]; System.Threading.Thread.InitializeCurrentThread()
       mov       [rbp-100],rax
       mov       rcx,[rbp-100]
M02_L19:
       cmp       dword ptr [rbp-5C],0
       je        near ptr M02_L44
       mov       [rbp-100],rcx
M02_L20:
       mov       rdi,offset MT_System.Threading.ExecutionContext
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       [rbp-0E8],rsi
       mov       rax,[rbp-58]
       mov       [rbp-108],rax
       lea       rdi,[rsi+8]
       mov       rsi,[rbp-0E0]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-0E8]
       lea       rdi,[rsi+10]
       mov       rsi,[rbp-108]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-0E8]
       mov       edi,[rbp-5C]
       mov       [rsi+18],dil
M02_L21:
       mov       rdi,[rbp-100]
       lea       rdi,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      r12d,r12d
       je        short M02_L24
       mov       rsi,[rbp-48]
       test      rsi,rsi
       jne       near ptr M02_L46
       xor       r12d,r12d
M02_L22:
       test      r14,r14
       je        near ptr M02_L48
       mov       rdi,[r13]
       mov       rdi,[rdi+30]
       mov       rdi,[rdi]
       mov       rdi,[rdi]
       mov       rax,r14
       cmp       [rax],rdi
       je        short M02_L23
       mov       rsi,r14
       call      qword ptr [71CF6A6558C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
M02_L23:
       mov       rcx,[r13+8]
       xor       edi,edi
       mov       [rsp],r12
       mov       [rsp+8],rax
       mov       [rsp+10],dil
       mov       rdi,[rcx+8]
       call      qword ptr [rcx+18]
M02_L24:
       xor       edi,edi
       mov       [rbp-48],rdi
       mov       [rbp-58],rdi
       mov       rsi,[rbp-0C0]
       lea       rdi,[rsi+18]
       mov       rsi,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-0C0]
M02_L25:
       cmp       qword ptr [rsi+10],0
       jne       near ptr M02_L33
       mov       rdi,offset Microsoft.VisualStudio.Threading.AsyncLazy`1+<>c__DisplayClass20_0[[System.__Canon, System.Private.CoreLib]].<GetValueAsync>b__0()
       cmp       [rbx+18],rdi
       jne       near ptr M02_L42
       mov       rbx,[rbx+8]
       cmp       [rbx],ebx
       xor       edi,edi
       mov       [rbp-70],rdi
       mov       [rbp-90],rbx
       mov       dword ptr [rbp-78],0FFFFFFFF
       mov       rdi,[rbx]
       mov       rax,[rdi+30]
       mov       rax,[rax]
       mov       rax,[rax+18]
       test      rax,rax
       je        short M02_L30
       mov       rdi,rax
M02_L26:
       mov       rax,[rdi+18]
       mov       rax,[rax+10]
       test      rax,rax
       je        short M02_L31
       mov       rdi,rax
M02_L27:
       lea       rsi,[rbp-90]
       call      qword ptr [71CF6B1B7C18]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[Microsoft.VisualStudio.Threading.AsyncLazy`1+<>c__DisplayClass20_0+<<GetValueAsync>b__0>d[[System.__Canon, System.Private.CoreLib]], Microsoft.VisualStudio.Threading]](<<GetValueAsync>b__0>d<System.__Canon> ByRef)
       mov       rdi,[rbx]
       mov       rsi,[rdi+30]
       mov       rsi,[rsi]
       mov       rsi,[rsi+10]
       test      rsi,rsi
       je        short M02_L32
M02_L28:
       mov       rax,[rbp-70]
       test      rax,rax
       je        near ptr M02_L41
M02_L29:
       mov       rsi,[rbp-0C0]
       lea       rdi,[rsi+28]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L43
M02_L30:
       mov       rsi,71CF6B20C1B0
       call      qword ptr [71CF6A65F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       short M02_L26
M02_L31:
       mov       rsi,71CF6B20C3A8
       call      qword ptr [71CF6A65F3A8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       short M02_L27
M02_L32:
       mov       rsi,71CF6B20C028
       call      qword ptr [71CF6A65F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       short M02_L28
M02_L33:
       mov       rsi,[rbp-0C0]
       mov       rdi,[rsi]
       mov       rax,[rdi+30]
       mov       rax,[rax]
       mov       rax,[rax+30]
       test      rax,rax
       je        short M02_L34
       jmp       short M02_L35
M02_L34:
       mov       rsi,71CF6B208FE0
       call      qword ptr [71CF6A65F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L35:
       mov       rsi,[rbp-0C0]
       mov       r15,[rsi+10]
       cmp       [r15],r15b
       mov       rdi,[rax+18]
       mov       rdi,[rdi+10]
       test      rdi,rdi
       je        short M02_L36
       mov       rcx,rdi
       jmp       short M02_L37
M02_L36:
       mov       rdi,rax
       mov       rsi,71CF6B2393E8
       call      qword ptr [71CF6A65F3A8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M02_L37:
       mov       rdi,r15
       mov       rsi,rcx
       mov       rdx,rbx
       xor       ecx,ecx
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [71CF6B1BF810]
       mov       rsi,[rbp-0C0]
       lea       rdi,[rsi+30]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       lock or   dword ptr [rsp],0
       mov       rsi,[rbp-0C0]
       mov       rbx,[rsi+30]
       mov       rdi,[rbx]
       mov       rax,[rdi+30]
       mov       rax,[rax]
       mov       r15,[rax+10]
       test      r15,r15
       je        short M02_L38
       jmp       short M02_L39
M02_L38:
       mov       rsi,71CF6B239480
       call      qword ptr [71CF6A65F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r15,rax
M02_L39:
       mov       rdi,rbx
       call      qword ptr [71CF6B1BF8E8]
       mov       rsi,rax
       test      rsi,rsi
       je        short M02_L40
       mov       rdi,r15
       cmp       [rsi],rdi
       je        short M02_L40
       mov       rsi,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rsi,rax
M02_L40:
       mov       rbx,[rbp-0C0]
       lea       rdi,[rbx+28]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M02_L43
M02_L41:
       lea       rdi,[rbp-70]
       call      qword ptr [71CF6B1BF318]
       jmp       near ptr M02_L29
M02_L42:
       mov       rdi,[rbx+8]
       call      qword ptr [rbx+18]
       jmp       near ptr M02_L29
M02_L43:
       call      M02_L99
       jmp       near ptr M02_L56
M02_L44:
       mov       rdi,71BFA4C013B8
       mov       rax,[rbp-0E0]
       cmp       rax,[rdi]
       jne       short M02_L45
       xor       esi,esi
       mov       [rbp-100],rcx
       jmp       near ptr M02_L21
M02_L45:
       mov       [rbp-100],rcx
       jmp       near ptr M02_L20
M02_L46:
       mov       rdi,[r13]
       mov       rdi,[rdi+30]
       mov       rdi,[rdi]
       mov       rdi,[rdi]
       mov       r12,rsi
       cmp       [r12],rdi
       je        short M02_L47
       call      qword ptr [71CF6A6558C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r12,rax
M02_L47:
       jmp       near ptr M02_L22
M02_L48:
       xor       eax,eax
       jmp       near ptr M02_L23
M02_L49:
       xor       edi,edi
       call      qword ptr [71CF6B1BF348]
       int       3
M02_L50:
       mov       rdi,[rbp-0D0]
       call      qword ptr [71CF6B1BF4F8]
       jmp       near ptr M02_L03
M02_L51:
       lea       rdi,[rbp-38]
       call      qword ptr [71CF6B1BF510]
       int       3
M02_L52:
       mov       rdi,71CF6B24E340
       call      qword ptr [71CF6B1B6DA8]
       jmp       near ptr M02_L06
M02_L53:
       mov       edi,4
       call      qword ptr [71CF6B1BF198]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M02_L08
M02_L54:
       test      r12d,r12d
       jne       short M02_L55
       mov       rdi,71BFA4C013B8
       mov       rsi,[rdi]
       mov       [rbp-4C],r8d
       mov       rax,rsi
       jmp       near ptr M02_L15
M02_L55:
       mov       [rbp-4C],r8d
       jmp       near ptr M02_L14
M02_L56:
       mov       rdi,[rbp-0D0]
       call      000071CFE88E6790
       test      eax,eax
       jne       near ptr M02_L89
M02_L57:
       mov       rsi,[rbp-0C8]
       mov       rdi,[rsi+10]
       test      rdi,rdi
       je        near ptr M02_L78
       mov       byte ptr [rdi+18],1
       mov       rbx,[rdi+8]
       xor       eax,eax
       mov       [rdi+8],rax
       mov       r15,[rdi+10]
       mov       rdi,71CFE8CA0D68
       mov       rax,71CFE950E820
       call      rax
       cmp       dword ptr [rax],4
       jle       near ptr M02_L90
       mov       rdi,[rax+8]
       mov       r13,[rdi+20]
       test      r13,r13
       je        near ptr M02_L90
M02_L58:
       mov       rax,[r13+10]
       test      rax,rax
       jne       short M02_L59
       call      qword ptr [71CF6AEAC048]; System.Threading.Thread.InitializeCurrentThread()
M02_L59:
       mov       r14,[rax+10]
       mov       rax,[r13+10]
       test      rax,rax
       jne       short M02_L60
       call      qword ptr [71CF6AEAC048]; System.Threading.Thread.InitializeCurrentThread()
M02_L60:
       lea       rdi,[rax+10]
       mov       rsi,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-138],r14
       test      rbx,rbx
       je        near ptr M02_L76
       mov       rdi,offset System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1+AsyncStateMachineBox`1[[System.__Canon, System.Private.CoreLib],[Microsoft.VisualStudio.Threading.AsyncLazy`1+<>c__DisplayClass20_0+<<GetValueAsync>b__0>d[[System.__Canon, System.Private.CoreLib]], Microsoft.VisualStudio.Threading]].MoveNext()
       cmp       [rbx+18],rdi
       jne       near ptr M02_L75
       mov       rbx,[rbx+8]
       mov       rdi,71BFA4C013B0
       mov       r15,[rdi]
       movzx     r12d,byte ptr [r15+9D]
       test      r12d,r12d
       jne       near ptr M02_L68
M02_L61:
       mov       rax,[rbx+10]
       mov       [rbp-128],rax
       test      rax,rax
       je        near ptr M02_L69
       mov       rdi,[rbx]
       mov       rsi,[rdi+30]
       mov       rsi,[rsi+8]
       mov       rsi,[rsi+18]
       test      rsi,rsi
       je        near ptr M02_L67
M02_L62:
       mov       rdi,rsi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rsi,[rax]
       mov       rdi,[rbp-128]
       mov       rdx,rbx
       call      qword ptr [71CF6B1BC5A0]; System.Threading.ExecutionContext.RunInternal(System.Threading.ExecutionContext, System.Threading.ContextCallback, System.Object)
M02_L63:
       mov       edi,[rbx+34]
       test      edi,1600000
       je        short M02_L66
       cmp       byte ptr [71CF6966B06C],0
       jne       near ptr M02_L72
M02_L64:
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
       je        short M02_L66
       movzx     eax,byte ptr [rdi+9D]
       mov       ecx,[rdi+98]
       mov       rdi,[rdi+80]
       test      eax,eax
       je        short M02_L66
       test      ecx,ecx
       je        short M02_L65
       cmp       ecx,3
       jl        short M02_L66
M02_L65:
       test      rdi,rdi
       je        near ptr M02_L73
       test      edi,100
       jne       near ptr M02_L73
M02_L66:
       test      r12d,r12d
       je        near ptr M02_L76
       jmp       near ptr M02_L74
M02_L67:
       mov       rsi,71CF6B20E870
       call      qword ptr [71CF6A65F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M02_L62
M02_L68:
       mov       rdi,rbx
       call      qword ptr [71CF6B1BC570]
       mov       esi,eax
       mov       rdi,r15
       mov       edx,2
       call      qword ptr [71CF6B1BC588]
       jmp       near ptr M02_L61
M02_L69:
       mov       rdi,[rbx]
       mov       rsi,[rdi+30]
       mov       rsi,[rsi+8]
       mov       rax,[rsi+20]
       test      rax,rax
       je        short M02_L70
       jmp       short M02_L71
M02_L70:
       mov       rsi,71CF6B20E8F8
       call      qword ptr [71CF6A65F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L71:
       lea       rdi,[rbx+40]
       call      rax
       jmp       near ptr M02_L63
M02_L72:
       mov       rdi,rbx
       call      qword ptr [71CF6B1BC840]
       jmp       near ptr M02_L64
M02_L73:
       mov       rdi,rbx
       call      qword ptr [71CF6AEA6880]; System.GC.SuppressFinalize(System.Object)
       jmp       near ptr M02_L66
M02_L74:
       mov       rdi,r15
       mov       esi,2
       call      qword ptr [71CF6B1BC5E8]
       jmp       short M02_L76
M02_L75:
       mov       rdi,[rbx+8]
       call      qword ptr [rbx+18]
       nop
M02_L76:
       mov       rax,[r13+10]
       test      rax,rax
       jne       short M02_L77
       call      qword ptr [71CF6AEAC048]; System.Threading.Thread.InitializeCurrentThread()
M02_L77:
       lea       rdi,[rax+10]
       mov       rsi,r14
       call      CORINFO_HELP_ASSIGN_REF
M02_L78:
       mov       rsi,[rbp-0C0]
       lock or   dword ptr [rsp],0
       mov       rdi,[rsi+30]
       test      rdi,rdi
       jne       near ptr M02_L91
       xor       eax,eax
M02_L79:
       test      rax,rax
       jne       short M02_L82
       mov       rsi,[rbp-0C0]
       mov       rdi,[rsi]
       mov       rax,[rdi+30]
       mov       rax,[rax]
       mov       rbx,[rax+20]
       test      rbx,rbx
       je        short M02_L83
M02_L80:
       mov       rsi,[rbp-0C0]
       mov       r15,[rsi+28]
       mov       rdi,[rbp-38]
       mov       [rbp-0B8],rdi
       test      r15,r15
       je        near ptr M02_L92
       cmp       qword ptr [rbp-0B8],0
       jne       near ptr M02_L93
M02_L81:
       mov       rax,r15
M02_L82:
       add       rsp,138
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L83:
       mov       rsi,71CF6B208E38
       call      qword ptr [71CF6A65F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rbx,rax
       jmp       short M02_L80
M02_L84:
       mov       rdi,rsi
       mov       rsi,71CF6B208400
       call      qword ptr [71CF6A65F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L00
M02_L85:
       test      dword ptr [rdi+34],1600000
       jne       near ptr M02_L02
       jmp       near ptr M02_L01
M02_L86:
       mov       rdi,[rdi+8]
       cmp       [rdi],edi
       call      qword ptr [71CF6B1BF8B8]
       test      rax,rax
       je        near ptr M02_L02
       call      qword ptr [71CF6B1BF8D0]
       mov       rdi,rax
       mov       rdx,71BFA4C01420
       mov       rdx,[rdx]
       mov       rsi,71CF6820A868
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rdi,rax
       xor       eax,eax
       test      rdi,rdi
       cmove     rdi,rax
       call      qword ptr [71CF6B1B6C88]
       int       3
M02_L87:
       mov       edi,94D
       mov       rsi,71CF69664000
       call      qword ptr [71CF6A65EF88]
       mov       rdi,rax
       call      qword ptr [71CF6B1BF348]
       int       3
M02_L88:
       call      qword ptr [71CF6B1BF8D0]
       mov       rdi,rax
       mov       rdx,71BFA4C01420
       mov       rdx,[rdx]
       mov       rsi,71CF6820A868
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rdi,rax
       xor       eax,eax
       test      rdi,rdi
       cmove     rdi,rax
       call      qword ptr [71CF6B1B6C88]
       int       3
M02_L89:
       mov       edi,eax
       mov       rsi,[rbp-0D0]
       call      qword ptr [71CF6B1BF360]
       jmp       near ptr M02_L57
M02_L90:
       mov       edi,4
       call      qword ptr [71CF6B1BF198]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r13,rax
       jmp       near ptr M02_L58
M02_L91:
       mov       rdx,[rbp-38]
       xor       esi,esi
       call      qword ptr [71CF6B1B6D78]
       jmp       near ptr M02_L79
M02_L92:
       mov       rdi,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       edi,170F
       mov       rsi,71CF6B1E7EA8
       call      qword ptr [71CF6A65EF88]
       mov       rsi,rax
       mov       rdi,rbx
       call      qword ptr [71CF6AEAE1C0]
       mov       rdi,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L93:
       test      dword ptr [r15+34],1600000
       jne       near ptr M02_L81
       lea       rdi,[rbp-0B8]
       call      qword ptr [71CF6B1BC930]
       test      eax,eax
       je        short M02_L96
       mov       rdi,[rbx+18]
       mov       rdi,[rdi+20]
       test      rdi,rdi
       je        short M02_L94
       jmp       short M02_L95
M02_L94:
       mov       rdi,rbx
       mov       rsi,71CF6B20F778
       call      qword ptr [71CF6A65F3A8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdi,rax
M02_L95:
       mov       rsi,[rbp-0B8]
       call      qword ptr [71CF6B1BC8D0]
       jmp       near ptr M02_L82
M02_L96:
       mov       rdi,[rbx+18]
       mov       rdi,[rdi+18]
       test      rdi,rdi
       je        short M02_L97
       jmp       short M02_L98
M02_L97:
       mov       rdi,rbx
       mov       rsi,71CF6B20F6C8
       call      qword ptr [71CF6A65F3A8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdi,rax
M02_L98:
       mov       rsi,r15
       mov       rdx,[rbp-0B8]
       call      qword ptr [71CF6B1BC888]
       jmp       near ptr M02_L82
M02_L99:
       sub       rsp,18
       mov       rbx,[rbp-0C0]
       mov       rdi,[rbx+18]
       test      rdi,rdi
       je        near ptr M02_L118
       mov       r15,[rdi+8]
       cmp       qword ptr [r15+8],0
       setne     r14b
       movzx     r14d,r14b
       mov       rdi,71CFE8CA0D68
       mov       rax,71CFE950E820
       call      rax
       cmp       dword ptr [rax],4
       jle       short M02_L100
       mov       rdi,[rax+8]
       mov       rcx,[rdi+20]
       test      rcx,rcx
       jne       short M02_L101
M02_L100:
       mov       edi,4
       call      qword ptr [71CF6B1BF198]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rcx,rax
M02_L101:
       mov       r13,rcx
       mov       rax,[r13+10]
       test      rax,rax
       jne       short M02_L102
       call      qword ptr [71CF6AEAC048]; System.Threading.Thread.InitializeCurrentThread()
M02_L102:
       mov       r12,[rax+8]
       xor       edi,edi
       mov       [rbp-98],rdi
       xor       eax,eax
       test      r12,r12
       je        short M02_L103
       mov       rdi,[r12+8]
       lea       rdx,[rbp-98]
       mov       rsi,r15
       mov       r11,71CF69670570
       call      qword ptr [r11]
       mov       [rbp-9C],eax
       mov       eax,[rbp-9C]
M02_L103:
       cmp       qword ptr [rbp-98],0
       je        near ptr M02_L117
       xor       edi,edi
       mov       [rbp-0A8],rdi
       mov       [rbp-0AC],edi
       test      r12,r12
       je        short M02_L104
       mov       [rbp-9C],eax
       movzx     ecx,byte ptr [r12+18]
       mov       [rbp-0AC],ecx
       test      r14d,r14d
       sete      cl
       movzx     ecx,cl
       mov       rdi,[r12+8]
       mov       rsi,r15
       mov       r11,71CF69670568
       xor       edx,edx
       call      qword ptr [r11]
       mov       [rbp-110],rax
       mov       rdx,[r12+10]
       mov       [rbp-0A8],rdx
       jmp       short M02_L107
M02_L104:
       test      r14d,r14d
       jne       short M02_L105
       mov       rdi,71BFA4C013B8
       mov       r12,[rdi]
       jmp       short M02_L106
M02_L105:
       mov       [rbp-9C],eax
       mov       rdi,offset MT_System.Threading.AsyncLocalValueMap+OneElementAsyncLocalValueMap
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rsi,r15
       mov       rdi,71CF6B2442E8
       xor       edx,edx
       call      qword ptr [71CF6B1BF258]
       mov       [rbp-130],rdx
       lea       rdi,[r12+8]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdi,[r12+10]
       mov       rsi,[rbp-130]
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,[rbp-9C]
M02_L106:
       mov       [rbp-9C],eax
       mov       [rbp-110],r12
M02_L107:
       test      r14d,r14d
       je        short M02_L109
       cmp       dword ptr [rbp-9C],0
       jne       short M02_L109
       cmp       qword ptr [rbp-0A8],0
       jne       short M02_L108
       mov       rdi,offset MT_System.Threading.IAsyncLocal[]
       mov       esi,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r12,rax
       lea       rdi,[r12+10]
       mov       rsi,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-0A8],r12
       jmp       short M02_L109
M02_L108:
       mov       rdx,[rbp-0A8]
       mov       r12d,[rdx+8]
       lea       edx,[r12+1]
       lea       rsi,[rbp-0A8]
       mov       rdi,71CF6B221728
       call      qword ptr [71CF6AA8C480]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       esi,r12d
       mov       rdi,[rbp-0A8]
       mov       rdx,r15
       call      qword ptr [71CF6A6557A0]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M02_L109:
       mov       r13,[r13+10]
       test      r13,r13
       jne       short M02_L110
       call      qword ptr [71CF6AEAC048]; System.Threading.Thread.InitializeCurrentThread()
       mov       r13,rax
M02_L110:
       mov       r12d,[rbp-0AC]
       test      r12d,r12d
       jne       short M02_L111
       mov       rdi,71BFA4C013B8
       mov       rax,[rbp-110]
       cmp       rax,[rdi]
       je        short M02_L112
M02_L111:
       mov       rdi,offset MT_System.Threading.ExecutionContext
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       [rbp-118],rsi
       mov       rax,[rbp-0A8]
       mov       [rbp-120],rax
       lea       rdi,[rsi+8]
       mov       rsi,[rbp-110]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-118]
       lea       rdi,[rsi+10]
       mov       rsi,[rbp-120]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-118]
       mov       [rsi+18],r12b
       jmp       short M02_L113
M02_L112:
       xor       esi,esi
M02_L113:
       lea       rdi,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      r14d,r14d
       je        short M02_L117
       mov       rsi,[rbp-98]
       test      rsi,rsi
       je        short M02_L115
       mov       rdi,[r15]
       mov       rdi,[rdi+30]
       mov       rdi,[rdi]
       mov       rdi,[rdi]
       mov       r14,rsi
       cmp       [r14],rdi
       je        short M02_L114
       call      qword ptr [71CF6A6558C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r14,rax
M02_L114:
       jmp       short M02_L116
M02_L115:
       xor       r14d,r14d
M02_L116:
       mov       rax,[r15+8]
       xor       edi,edi
       xor       ecx,ecx
       mov       [rsp],r14
       mov       [rsp+8],rdi
       mov       [rsp+10],cl
       mov       rdi,[rax+8]
       call      qword ptr [rax+18]
M02_L117:
       xor       edi,edi
       mov       [rbp-98],rdi
       mov       [rbp-0A8],rdi
M02_L118:
       add       rsp,18
       ret
       sub       rsp,18
       cmp       dword ptr [rbp-3C],0
       je        short M02_L120
       cmp       qword ptr [rbp-0D0],0
       jne       short M02_L119
       xor       edi,edi
       call      qword ptr [71CF6B1BF348]
       int       3
M02_L119:
       mov       rdi,[rbp-0D0]
       call      000071CFE88E6790
       test      eax,eax
       je        short M02_L120
       mov       edi,eax
       mov       rsi,[rbp-0D0]
       call      qword ptr [71CF6B1BF360]
M02_L120:
       nop
       add       rsp,18
       ret
       sub       rsp,18
       mov       rdi,71CFE8CA0D68
       mov       rax,71CFE950E820
       call      rax
       cmp       dword ptr [rax],4
       jle       short M02_L121
       mov       rdi,[rax+8]
       mov       r13,[rdi+20]
       test      r13,r13
       jne       short M02_L122
M02_L121:
       mov       edi,4
       call      qword ptr [71CF6B1BF198]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r13,rax
M02_L122:
       mov       r14,[r13+10]
       test      r14,r14
       jne       short M02_L123
       call      qword ptr [71CF6AEAC048]; System.Threading.Thread.InitializeCurrentThread()
       mov       r14,rax
M02_L123:
       lea       rdi,[r14+10]
       mov       rsi,[rbp-138]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,18
       ret
; Total bytes of code 4247
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
       call      qword ptr [71CF6A1FEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdx,[rbp-8C]
       mov       rsi,[rbp-94]
       mov       rdi,[rbp-9C]
       mov       ecx,[rbp-84]
       mov       r8,[rbp-0A4]
       call      qword ptr [rax]
       mov       rbx,rax
       lea       rdi,[rbp-80]
       call      qword ptr [71CF6A1FEF08]; CORINFO_HELP_JIT_PINVOKE_END
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
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.__Canon, System.Private.CoreLib]].LazyOfTask()
       push      rbp
       push      r15
       push      rbx
       sub       rsp,10
       lea       rbp,[rsp+20]
       mov       [rbp-18],rdi
       mov       rbx,rdi
       mov       rdi,[rbx]
       mov       rsi,[rdi+30]
       mov       rsi,[rsi]
       mov       rsi,[rsi+28]
       test      rsi,rsi
       je        short M00_L01
M00_L00:
       mov       rdi,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M00_L02
       lea       rdi,[r15+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset MT_System.LazyHelper
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+10],8
       lea       rdi,[r15+8]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [r15+8],0
       je        short M00_L03
       mov       rdi,r15
       add       rsp,10
       pop       rbx
       pop       r15
       pop       rbp
       jmp       qword ptr [778292A9C438]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
M00_L01:
       mov       rsi,778292DC7648
       call      qword ptr [77829224F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       short M00_L00
M00_L02:
       mov       edi,1817
       mov       rsi,778291254000
       call      qword ptr [77829224EF88]
       mov       rdi,rax
       call      qword ptr [778292DAEB68]
       int       3
M00_L03:
       mov       rax,[r15+18]
       add       rsp,10
       pop       rbx
       pop       r15
       pop       rbp
       ret
; Total bytes of code 191
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.__Canon, System.Private.CoreLib]](System.Threading.Tasks.Task`1<System.__Canon>)
       push      rbx
       mov       rbx,rsi
       mov       edi,[rbx+34]
       and       edi,11000000
       cmp       edi,1000000
       jne       short M01_L01
M01_L00:
       mov       rax,[rbx+38]
       pop       rbx
       ret
M01_L01:
       mov       rdi,rbx
       xor       esi,esi
       call      qword ptr [778292DA7948]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 40
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
       call      00007783104E6020
       test      eax,eax
       jne       short M02_L02
       mov       rdi,rbx
       call      qword ptr [778292DAE6A0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
M02_L02:
       mov       dword ptr [rbp-14],1
       mov       rdi,[rbp-20]
       cmp       [rdi+8],rbx
       jne       short M02_L03
       mov       esi,2
       call      qword ptr [778292A9C468]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       nop
M02_L03:
       mov       rdi,rbx
       call      00007783104E6790
       test      eax,eax
       jne       near ptr M02_L11
M02_L04:
       mov       rdi,[rbp-20]
       cmp       qword ptr [rdi+8],0
       je        near ptr M02_L12
       add       rsp,28
       pop       rbx
       pop       rbp
       jmp       qword ptr [778292A9C438]
M02_L05:
       cmp       eax,8
       ja        short M02_L06
       mov       eax,eax
       lea       rcx,[7782922C4788]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M02_L01]
       add       rcx,rdx
       jmp       rcx
M02_L06:
       mov       rdi,[rbx+8]
       cmp       [rdi],edi
       call      qword ptr [778292DAECA0]
       int       3
       mov       rdi,[rbp-20]
       call      qword ptr [778292DAEE98]
       jmp       short M02_L04
       mov       rdi,[rbp-20]
       xor       esi,esi
       call      qword ptr [778292A9C468]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
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
       mov       rsi,778292E21FA0
       call      qword ptr [77829224F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L08:
       mov       rdi,[rax+30]
       mov       rdi,[rdi]
       mov       rdi,[rdi+18]
       test      rdi,rdi
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rdi,rax
       mov       rsi,778292E22040
       call      qword ptr [77829224F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M02_L10:
       call      qword ptr [778292DAEE38]
       mov       rdx,rax
       mov       rsi,rbx
       mov       rdi,[rbp-20]
       call      qword ptr [778292DAEEB0]
       jmp       near ptr M02_L04
       mov       rdi,[rbp-20]
       mov       rsi,rbx
       call      qword ptr [778292DAEEC8]
       jmp       near ptr M02_L04
       mov       rdi,[rbp-20]
       call      qword ptr [778292DAEEE0]
       jmp       near ptr M02_L04
       mov       rdi,[rbp-20]
       mov       rsi,rbx
       mov       edx,1
       call      qword ptr [778292A9C450]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M02_L04
M02_L11:
       mov       edi,eax
       mov       rsi,rbx
       call      qword ptr [778292DAEB80]
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
       call      00007783104E6790
       test      eax,eax
       je        short M02_L13
       mov       edi,eax
       mov       rsi,[rbp-28]
       call      qword ptr [778292DAEB80]
M02_L13:
       nop
       add       rsp,8
       ret
; Total bytes of code 438
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
       call      qword ptr [778291DEEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdx,[rbp-8C]
       mov       rsi,[rbp-94]
       mov       rdi,[rbp-9C]
       mov       ecx,[rbp-84]
       mov       r8,[rbp-0A4]
       call      qword ptr [rax]
       mov       rbx,rax
       lea       rdi,[rbp-80]
       call      qword ptr [778291DEEF08]; CORINFO_HELP_JIT_PINVOKE_END
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
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rbp
       push      r15
       push      rbx
       lea       rbp,[rsp+10]
       mov       rbx,rdi
       mov       r15d,esi
       test      dword ptr [rbx+34],1600000
       jne       short M04_L00
       mov       rdi,rbx
       mov       esi,0FFFFFFFF
       xor       edx,edx
       call      qword ptr [778292DA7960]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M04_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M04_L03
M04_L01:
       mov       edi,[rbx+34]
       and       edi,1600000
       cmp       edi,1000000
       jne       short M04_L04
M04_L02:
       pop       rbx
       pop       r15
       pop       rbp
       ret
M04_L03:
       mov       rdi,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M04_L01
       mov       rdi,rbx
       call      qword ptr [778292DAF168]
       jmp       short M04_L01
M04_L04:
       test      r15b,2
       jne       short M04_L05
       mov       rdi,rbx
       call      qword ptr [778292DAEF58]
M04_L05:
       mov       rdi,rbx
       call      qword ptr [778292DAF438]
       jmp       short M04_L02
; Total bytes of code 125
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.__Canon, System.Private.CoreLib]].LazyOfTask_TaskRun()
       push      rbp
       push      r15
       push      rbx
       sub       rsp,10
       lea       rbp,[rsp+20]
       mov       [rbp-18],rdi
       mov       rbx,rdi
       mov       rdi,[rbx]
       mov       rsi,[rdi+30]
       mov       rsi,[rsi]
       mov       rsi,[rsi+28]
       test      rsi,rsi
       je        short M00_L01
M00_L00:
       mov       rdi,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rsi,[rbx+10]
       test      rsi,rsi
       je        short M00_L02
       lea       rdi,[r15+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset MT_System.LazyHelper
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+10],8
       lea       rdi,[r15+8]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [r15+8],0
       je        short M00_L03
       mov       rdi,r15
       add       rsp,10
       pop       rbx
       pop       r15
       pop       rbp
       jmp       qword ptr [776BC8E7C438]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
M00_L01:
       mov       rsi,776BC91A7648
       call      qword ptr [776BC862F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       short M00_L00
M00_L02:
       mov       edi,1817
       mov       rsi,776BC7634000
       call      qword ptr [776BC862EF88]
       mov       rdi,rax
       call      qword ptr [776BC918F2A0]
       int       3
M00_L03:
       mov       rax,[r15+18]
       add       rsp,10
       pop       rbx
       pop       r15
       pop       rbp
       ret
; Total bytes of code 191
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.__Canon, System.Private.CoreLib]](System.Threading.Tasks.Task`1<System.__Canon>)
       push      rbx
       mov       rbx,rsi
       mov       edi,[rbx+34]
       and       edi,11000000
       cmp       edi,1000000
       jne       short M01_L01
M01_L00:
       mov       rax,[rbx+38]
       pop       rbx
       ret
M01_L01:
       mov       rdi,rbx
       xor       esi,esi
       call      qword ptr [776BC9187510]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 40
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
       call      0000776C468E6020
       test      eax,eax
       jne       short M02_L02
       mov       rdi,rbx
       call      qword ptr [776BC918CE58]; System.Threading.Monitor.Enter_Slowpath(System.Object)
M02_L02:
       mov       dword ptr [rbp-14],1
       mov       rdi,[rbp-20]
       cmp       [rdi+8],rbx
       jne       short M02_L03
       mov       esi,2
       call      qword ptr [776BC8E7C468]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       nop
M02_L03:
       mov       rdi,rbx
       call      0000776C468E6790
       test      eax,eax
       jne       near ptr M02_L11
M02_L04:
       mov       rdi,[rbp-20]
       cmp       qword ptr [rdi+8],0
       je        near ptr M02_L12
       add       rsp,28
       pop       rbx
       pop       rbp
       jmp       qword ptr [776BC8E7C438]
M02_L05:
       cmp       eax,8
       ja        short M02_L06
       mov       eax,eax
       lea       rcx,[776BC86AFA58]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M02_L01]
       add       rcx,rdx
       jmp       rcx
M02_L06:
       mov       rdi,[rbx+8]
       cmp       [rdi],edi
       call      qword ptr [776BC918F1E0]
       int       3
       mov       rdi,[rbp-20]
       call      qword ptr [776BC918FB40]
       jmp       short M02_L04
       mov       rdi,[rbp-20]
       xor       esi,esi
       call      qword ptr [776BC8E7C468]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
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
       mov       rsi,776BC91E7CB0
       call      qword ptr [776BC862F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L08:
       mov       rdi,[rax+30]
       mov       rdi,[rdi]
       mov       rdi,[rdi+18]
       test      rdi,rdi
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rdi,rax
       mov       rsi,776BC91E7D50
       call      qword ptr [776BC862F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M02_L10:
       call      qword ptr [776BC918FAE0]
       mov       rdx,rax
       mov       rsi,rbx
       mov       rdi,[rbp-20]
       call      qword ptr [776BC918FB58]
       jmp       near ptr M02_L04
       mov       rdi,[rbp-20]
       mov       rsi,rbx
       call      qword ptr [776BC918FB70]
       jmp       near ptr M02_L04
       mov       rdi,[rbp-20]
       call      qword ptr [776BC918FB88]
       jmp       near ptr M02_L04
       mov       rdi,[rbp-20]
       mov       rsi,rbx
       mov       edx,1
       call      qword ptr [776BC8E7C450]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M02_L04
M02_L11:
       mov       edi,eax
       mov       rsi,rbx
       call      qword ptr [776BC918CE70]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
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
       call      0000776C468E6790
       test      eax,eax
       je        short M02_L13
       mov       edi,eax
       mov       rsi,[rbp-28]
       call      qword ptr [776BC918CE70]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M02_L13:
       nop
       add       rsp,8
       ret
; Total bytes of code 438
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
       call      qword ptr [776BC81CEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdx,[rbp-8C]
       mov       rsi,[rbp-94]
       mov       rdi,[rbp-9C]
       mov       ecx,[rbp-84]
       mov       r8,[rbp-0A4]
       call      qword ptr [rax]
       mov       rbx,rax
       lea       rdi,[rbp-80]
       call      qword ptr [776BC81CEF08]; CORINFO_HELP_JIT_PINVOKE_END
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
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rbp
       push      r15
       push      rbx
       lea       rbp,[rsp+10]
       mov       rbx,rdi
       mov       r15d,esi
       test      dword ptr [rbx+34],1600000
       jne       short M04_L00
       mov       rdi,rbx
       mov       esi,0FFFFFFFF
       xor       edx,edx
       call      qword ptr [776BC9187528]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M04_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M04_L03
M04_L01:
       mov       edi,[rbx+34]
       and       edi,1600000
       cmp       edi,1000000
       jne       short M04_L04
M04_L02:
       pop       rbx
       pop       r15
       pop       rbp
       ret
M04_L03:
       mov       rdi,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M04_L01
       mov       rdi,rbx
       call      qword ptr [776BC918FAB0]
       jmp       short M04_L01
M04_L04:
       test      r15b,2
       jne       short M04_L05
       mov       rdi,rbx
       call      qword ptr [776BC918F660]
M04_L05:
       mov       rdi,rbx
       call      qword ptr [776BC9234048]
       jmp       short M04_L02
; Total bytes of code 125
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.__Canon, System.Private.CoreLib]].AsyncLazy()
       push      rbp
       push      r15
       push      rbx
       sub       rsp,10
       lea       rbp,[rsp+20]
       mov       [rbp-18],rdi
       mov       rbx,rdi
       mov       rdi,[rbx]
       mov       rsi,[rdi+30]
       mov       rsi,[rsi]
       mov       rsi,[rsi+28]
       test      rsi,rsi
       je        short M00_L01
M00_L00:
       mov       rdi,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M00_L02
       lea       rdi,[r15+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[r15+10]
       test      rax,rax
       jne       short M00_L03
       mov       rdi,r15
       xor       esi,esi
       add       rsp,10
       pop       rbx
       pop       r15
       pop       rbp
       jmp       qword ptr [735761BB6928]; System.Threading.Tasks.AsyncLazy`1[[System.__Canon, System.Private.CoreLib]].GetOrStartAttemptAsync(System.Threading.CancellationToken)
M00_L01:
       mov       rsi,735761BDA0B0
       call      qword ptr [73576105F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       short M00_L00
M00_L02:
       mov       edi,1
       mov       rsi,735761BE7E90
       call      qword ptr [73576105EF88]
       mov       rdi,rax
       call      qword ptr [735761BBFBB8]
       int       3
M00_L03:
       add       rsp,10
       pop       rbx
       pop       r15
       pop       rbp
       ret
; Total bytes of code 157
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.__Canon, System.Private.CoreLib]](System.Threading.Tasks.Task`1<System.__Canon>)
       push      rbx
       mov       rbx,rsi
       mov       edi,[rbx+34]
       and       edi,11000000
       cmp       edi,1000000
       jne       short M01_L01
M01_L00:
       mov       rax,[rbx+38]
       pop       rbx
       ret
M01_L01:
       mov       rdi,rbx
       xor       esi,esi
       call      qword ptr [735761BB7720]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 40
```
```assembly
; System.Threading.Tasks.AsyncLazy`1[[System.__Canon, System.Private.CoreLib]].GetOrStartAttemptAsync(System.Threading.CancellationToken)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+50]
       mov       [rbp-30],rdi
       mov       rbx,rdi
       mov       r15,rsi
M02_L00:
       mov       r14,[rbx+8]
       mov       r13,[rbx]
       mov       rdi,r13
       mov       rsi,[rdi+30]
       mov       rsi,[rsi]
       mov       rax,[rsi+18]
       test      rax,rax
       je        near ptr M02_L18
       mov       rdi,rax
M02_L01:
       mov       rsi,r14
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M02_L35
       mov       rdi,[r13+30]
       mov       rdi,[rdi]
       mov       rdi,[rdi+20]
       test      rdi,rdi
       je        near ptr M02_L19
M02_L02:
       mov       rax,rdi
       test      r14,r14
       jne       near ptr M02_L20
M02_L03:
       lea       rax,[rbx+20]
       cmp       qword ptr [rax],0
       jne       near ptr M02_L34
M02_L04:
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rdi,[r12]
       mov       rsi,[rdi+30]
       mov       rsi,[rsi]
       mov       rsi,[rsi+10]
       test      rsi,rsi
       je        near ptr M02_L22
M02_L05:
       mov       rdi,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdi,[r14]
       mov       rsi,[rdi+30]
       mov       rsi,[rsi]
       mov       rsi,[rsi+18]
       test      rsi,rsi
       je        near ptr M02_L23
M02_L06:
       mov       rdi,rsi
       call      CORINFO_HELP_NEWSFAST
       xor       edi,edi
       mov       [rax+8],rdi
       mov       [rax+10],rdi
       mov       [rax+18],rdi
       mov       dword ptr [rax+34],2000440
       lea       rdi,[r14+8]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdi,[r12+10]
       mov       rsi,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdi,[r12+8]
       mov       rsi,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdi,[rbx+8]
       test      rdi,rdi
       je        near ptr M02_L39
       mov       rsi,r12
       xor       edx,edx
       call      00007357DF474060
       test      rax,rax
       jne       near ptr M02_L00
       mov       rdi,[r13+30]
       mov       rdi,[rdi]
       mov       rdi,[rdi+28]
       test      rdi,rdi
       je        near ptr M02_L26
M02_L07:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r14,[rax+8]
       test      r14,r14
       je        near ptr M02_L40
M02_L08:
       mov       rdi,[r13+30]
       mov       rdi,[rdi]
       mov       rax,[rdi+30]
       test      rax,rax
       je        near ptr M02_L27
       mov       r13,rax
M02_L09:
       mov       rdi,7357DF6A0D68
       mov       rax,7357E0012820
       call      rax
       cmp       dword ptr [rax],4
       jle       near ptr M02_L48
       mov       rdi,[rax+8]
       mov       rax,[rdi+20]
       test      rax,rax
       je        near ptr M02_L48
M02_L10:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M02_L11
       call      qword ptr [7357618AC048]; System.Threading.Thread.InitializeCurrentThread()
M02_L11:
       mov       rdi,[rax+8]
       test      rdi,rdi
       je        near ptr M02_L28
       xor       esi,esi
       cmp       byte ptr [rdi+18],0
       cmovne    rdi,rsi
M02_L12:
       test      rdi,rdi
       je        short M02_L13
       mov       [rbp-48],rdi
       cmp       byte ptr [rdi+19],0
       je        near ptr M02_L49
M02_L13:
       mov       rdi,[r13+18]
       mov       rdi,[rdi+18]
       test      rdi,rdi
       je        near ptr M02_L29
M02_L14:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rdi,[r13+8]
       mov       rsi,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdi,[r13+10]
       mov       rsi,r12
       call      CORINFO_HELP_ASSIGN_REF
M02_L15:
       mov       rdi,73479CC013A0
       mov       r14,[rdi]
       cmp       byte ptr [r14+38],0
       jne       near ptr M02_L52
M02_L16:
       mov       rdi,[r14+8]
       mov       rsi,[rdi+10]
       mov       rcx,[rsi+8]
M02_L17:
       mov       edx,[rsi+0A0]
       mov       eax,edx
       and       eax,[rsi+18]
       cmp       eax,[rcx+8]
       jae       near ptr M02_L55
       shl       rax,4
       lea       r8,[rcx+rax+10]
       mov       eax,[r8+8]
       sub       eax,edx
       jne       near ptr M02_L30
       lea       r9,[rsi+0A0]
       lea       r10d,[rdx+1]
       mov       eax,edx
       lock cmpxchg [r9],r10d
       cmp       eax,edx
       mov       [rbp-34],edx
       jne       short M02_L17
       mov       rcx,r8
       mov       [rbp-50],rcx
       mov       rdi,rcx
       mov       rsi,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13d,[rbp-34]
       inc       r13d
       mov       rdi,[rbp-50]
       mov       [rdi+8],r13d
       jmp       near ptr M02_L31
M02_L18:
       mov       rsi,735761BDA628
       call      qword ptr [73576105F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M02_L01
M02_L19:
       mov       rdi,r13
       mov       rsi,735761BDA638
       call      qword ptr [73576105F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M02_L02
M02_L20:
       cmp       [r14],rax
       jne       near ptr M02_L03
       mov       rdi,r14
       call      qword ptr [735761BB6A00]
       test      eax,eax
       je        near ptr M02_L25
       mov       rdi,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdi,r14
       mov       rsi,73575C409FE0
       call      qword ptr [7357618A5260]
       mov       rdi,[r13+30]
       mov       rdi,[rdi]
       cmp       qword ptr [rdi+8],40
       jle       short M02_L24
       mov       rdi,[rdi+40]
       test      rdi,rdi
       je        short M02_L24
M02_L21:
       mov       rsi,r14
       add       rsp,28
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [735761BB69A0]
M02_L22:
       mov       rsi,735761BDD2A8
       call      qword ptr [73576105F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M02_L05
M02_L23:
       mov       rsi,735761C0BFB0
       call      qword ptr [73576105F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M02_L06
M02_L24:
       mov       rdi,r13
       mov       rsi,735761BDCF38
       call      qword ptr [73576105F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       short M02_L21
M02_L25:
       mov       rdi,r14
       mov       rsi,r15
       add       rsp,28
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [735761BB6A18]; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.__Canon, System.Private.CoreLib]].WaitAsync(System.Threading.CancellationToken)
M02_L26:
       mov       rdi,r13
       mov       rsi,735761BDA830
       call      qword ptr [73576105F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M02_L07
M02_L27:
       mov       rdi,r13
       mov       rsi,735761BDCD58
       call      qword ptr [73576105F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M02_L09
M02_L28:
       mov       rdi,73479CC01390
       mov       rdi,[rdi]
       mov       rax,rdi
       mov       rdi,rax
       jmp       near ptr M02_L12
M02_L29:
       mov       rdi,r13
       mov       rsi,735761C0C290
       call      qword ptr [73576105F3A8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M02_L14
M02_L30:
       test      eax,eax
       jge       near ptr M02_L17
       mov       rsi,r13
       call      qword ptr [735761BBF978]
M02_L31:
       add       r14,78
       mov       edi,1
       xchg      edi,[r14]
       test      edi,edi
       jne       short M02_L32
       mov       rdi,73479CC013C8
       mov       r14,[rdi]
       lea       rdi,[r14+160]
       lock inc  dword ptr [rdi]
       mov       rdi,r14
       call      qword ptr [735761BB6E80]; System.Threading.PortableThreadPool+WorkerThread.MaybeAddWorkingWorker(System.Threading.PortableThreadPool)
       cmp       dword ptr [r14+164],6
       jne       near ptr M02_L53
M02_L32:
       test      r15,r15
       jne       near ptr M02_L54
       mov       rdi,[r12+10]
       mov       rax,[rdi+8]
M02_L33:
       add       rsp,28
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L34:
       mov       rax,[rax]
       cmp       dword ptr [rax+20],0
       je        near ptr M02_L04
       jmp       short M02_L36
M02_L35:
       jmp       short M02_L33
M02_L36:
       mov       rdi,[r13+30]
       mov       rdi,[rdi]
       mov       rdi,[rdi+10]
       test      rdi,rdi
       je        short M02_L37
       jmp       short M02_L38
M02_L37:
       mov       rdi,r13
       mov       rsi,735761BDA430
       call      qword ptr [73576105F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M02_L38:
       mov       rsi,[rbx+20]
       add       rsp,28
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [735761BB68C8]
M02_L39:
       call      qword ptr [735761BBF738]
       int       3
M02_L40:
       mov       rdi,[r13+30]
       mov       rdi,[rdi]
       mov       r14,[rdi+28]
       test      r14,r14
       je        short M02_L41
       jmp       short M02_L42
M02_L41:
       mov       rdi,r13
       mov       rsi,735761BDA830
       call      qword ptr [73576105F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
M02_L42:
       mov       rdi,[r13+30]
       mov       rdi,[rdi]
       cmp       qword ptr [rdi+8],38
       jle       short M02_L43
       mov       rdi,[rdi+38]
       test      rdi,rdi
       je        short M02_L43
       jmp       short M02_L44
M02_L43:
       mov       rdi,r13
       mov       rsi,735761BDCE40
       call      qword ptr [73576105F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M02_L44:
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rdi,r14
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rsi,[rax]
       test      rsi,rsi
       jne       short M02_L45
       call      qword ptr [735761C64660]
       int       3
M02_L45:
       mov       r14,[rbp-40]
       lea       rdi,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset System.Threading.Tasks.AsyncLazy`1+<>c[[System.__Canon, System.Private.CoreLib]].<GetOrStartAttemptAsync>b__11_0(Attempt<System.__Canon>)
       mov       [r14+18],rdi
       mov       rdi,[r13+30]
       mov       rdi,[rdi]
       mov       rdi,[rdi+28]
       test      rdi,rdi
       je        short M02_L46
       jmp       short M02_L47
M02_L46:
       mov       rdi,r13
       mov       rsi,735761BDA830
       call      qword ptr [73576105F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M02_L47:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       lea       rdi,[rax+8]
       mov       rsi,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L08
M02_L48:
       mov       edi,4
       call      qword ptr [735761BBF6F0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M02_L10
M02_L49:
       mov       rsi,[r13+18]
       mov       rsi,[rsi+20]
       test      rsi,rsi
       je        short M02_L50
       jmp       short M02_L51
M02_L50:
       mov       rdi,r13
       mov       rsi,735761C0C428
       call      qword ptr [73576105F3A8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
M02_L51:
       mov       rdi,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdi,r13
       mov       rsi,r14
       mov       rdx,r12
       mov       rcx,[rbp-48]
       call      qword ptr [735761BBFDF8]
       jmp       near ptr M02_L15
M02_L52:
       mov       rdi,73479CC013B8
       mov       rdi,[rdi]
       cmp       byte ptr [rdi+9D],0
       je        near ptr M02_L16
       mov       rdi,73479CC013B8
       mov       rdi,[rdi]
       mov       rsi,r13
       call      qword ptr [735761BBF960]
       jmp       near ptr M02_L16
M02_L53:
       mov       rdi,r14
       call      qword ptr [735761BB70D8]; System.Threading.PortableThreadPool+GateThread.EnsureRunningSlow(System.Threading.PortableThreadPool)
       jmp       near ptr M02_L32
M02_L54:
       mov       rdi,[r12+10]
       mov       r14,[rdi+8]
       cmp       [r14],r14b
       mov       rdi,offset MT_System.TimeProvider
       call      qword ptr [735761055728]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,73479CC01500
       mov       rdx,[rdx]
       mov       rcx,r15
       mov       rdi,r14
       mov       esi,0FFFFFFFF
       add       rsp,28
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [735761C64678]
M02_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1649
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
       call      qword ptr [735760BFEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdx,[rbp-8C]
       mov       rsi,[rbp-94]
       mov       rdi,[rbp-9C]
       mov       ecx,[rbp-84]
       mov       r8,[rbp-0A4]
       call      qword ptr [rax]
       mov       rbx,rax
       lea       rdi,[rbp-80]
       call      qword ptr [735760BFEF08]; CORINFO_HELP_JIT_PINVOKE_END
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
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rbp
       push      r15
       push      rbx
       lea       rbp,[rsp+10]
       mov       rbx,rdi
       mov       r15d,esi
       test      dword ptr [rbx+34],1600000
       jne       short M04_L00
       mov       rdi,rbx
       mov       esi,0FFFFFFFF
       xor       edx,edx
       call      qword ptr [735761BB7738]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M04_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M04_L03
M04_L01:
       mov       edi,[rbx+34]
       and       edi,1600000
       cmp       edi,1000000
       jne       short M04_L04
M04_L02:
       pop       rbx
       pop       r15
       pop       rbp
       ret
M04_L03:
       mov       rdi,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M04_L01
       mov       rdi,rbx
       call      qword ptr [735761BBFD20]
       jmp       short M04_L01
M04_L04:
       test      r15b,2
       jne       short M04_L05
       mov       rdi,rbx
       call      qword ptr [735761BBFE40]
M04_L05:
       mov       rdi,rbx
       call      qword ptr [735761C646A8]
       jmp       short M04_L02
; Total bytes of code 125
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.__Canon, System.Private.CoreLib]].AsyncLazy_NoHop()
       push      rbp
       push      r15
       push      r14
       push      rbx
       sub       rsp,68
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm8,xmm8,xmm8
       vmovdqu   ymmword ptr [rbp-50],ymm8
       vmovdqa   xmmword ptr [rbp-30],xmm8
       mov       [rbp-20],rdi
       mov       [rbp-60],rdi
       mov       rsi,[rdi]
       mov       rax,[rsi+30]
       mov       rax,[rax]
       mov       rax,[rax+28]
       test      rax,rax
       je        near ptr M00_L21
M00_L00:
       mov       rdi,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdi,[rbp-60]
       mov       rsi,[rdi+8]
       test      rsi,rsi
       je        near ptr M00_L32
       lea       rdi,[rbx+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbx+10]
       test      rax,rax
       jne       near ptr M00_L33
M00_L01:
       mov       r15,[rbx+8]
       mov       rdi,[rbx]
       mov       rsi,[rdi+30]
       mov       rsi,[rsi]
       mov       rax,[rsi+18]
       test      rax,rax
       je        near ptr M00_L22
       mov       rdi,rax
M00_L02:
       mov       rsi,r15
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L35
       mov       rdi,[rbx]
       mov       rsi,[rdi+30]
       mov       rsi,[rsi]
       mov       rax,[rsi+20]
       test      rax,rax
       je        near ptr M00_L23
       mov       rdi,rax
M00_L03:
       mov       rax,rdi
       test      r15,r15
       jne       near ptr M00_L24
M00_L04:
       lea       rax,[rbx+20]
       cmp       qword ptr [rax],0
       jne       near ptr M00_L34
M00_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdi,[r14]
       mov       rsi,[rdi+30]
       mov       rsi,[rsi]
       mov       rsi,[rsi+10]
       test      rsi,rsi
       je        near ptr M00_L26
M00_L06:
       mov       rdi,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdi,[r15]
       mov       rsi,[rdi+30]
       mov       rsi,[rsi]
       mov       rsi,[rsi+18]
       test      rsi,rsi
       je        near ptr M00_L27
M00_L07:
       mov       rdi,rsi
       call      CORINFO_HELP_NEWSFAST
       xor       edi,edi
       mov       [rax+8],rdi
       mov       [rax+10],rdi
       mov       [rax+18],rdi
       mov       dword ptr [rax+34],2000440
       lea       rdi,[r15+8]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdi,[r14+10]
       mov       rsi,r15
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdi,[r14+8]
       mov       rsi,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdi,[rbx+8]
       test      rdi,rdi
       je        near ptr M00_L39
       mov       rsi,r14
       xor       edx,edx
       call      00007A4384474060
       test      rax,rax
       jne       near ptr M00_L01
       xor       edi,edi
       mov       [rbp-38],rdi
       mov       [rbp-58],r14
       mov       dword ptr [rbp-40],0FFFFFFFF
       mov       rdi,[r14]
       mov       rsi,[rdi+30]
       mov       rsi,[rsi]
       mov       rax,[rsi+18]
       test      rax,rax
       je        near ptr M00_L30
       mov       rdi,rax
M00_L08:
       mov       rsi,[rdi+18]
       mov       rbx,[rsi+10]
       test      rbx,rbx
       je        near ptr M00_L31
M00_L09:
       mov       rdi,7A43846A0D68
       mov       rax,7A4384FB6820
       call      rax
       cmp       dword ptr [rax],4
       jle       near ptr M00_L40
       mov       rdi,[rax+8]
       mov       rax,[rdi+20]
       test      rax,rax
       je        near ptr M00_L40
M00_L10:
       mov       r15,[rax+10]
       test      r15,r15
       jne       short M00_L11
       call      qword ptr [7A430688C048]; System.Threading.Thread.InitializeCurrentThread()
       mov       r15,rax
M00_L11:
       mov       [rbp-68],r15
       mov       rsi,[r15+8]
       mov       [rbp-70],rsi
       mov       rsi,[r15+10]
       mov       [rbp-78],rsi
       mov       rdi,[rbx+18]
       mov       rax,[rdi+10]
       test      rax,rax
       je        short M00_L13
M00_L12:
       lea       rdi,[rbp-58]
       call      rax
       jmp       short M00_L14
M00_L13:
       mov       rdi,rbx
       mov       rsi,7A4306BBB4E0
       call      qword ptr [7A430603F3A8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       jmp       short M00_L12
M00_L14:
       mov       rsi,[rbp-78]
       cmp       rsi,[r15+10]
       je        short M00_L15
       lea       rdi,[r15+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L15:
       mov       rdi,[r15+8]
       mov       rbx,rdi
       mov       rsi,[rbp-70]
       cmp       rsi,rbx
       je        short M00_L17
       lea       rdi,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M00_L16
       cmp       qword ptr [rbx+10],0
       jne       near ptr M00_L41
M00_L16:
       cmp       qword ptr [rbp-70],0
       jne       short M00_L20
M00_L17:
       cmp       qword ptr [rbp-38],0
       je        near ptr M00_L42
M00_L18:
       mov       rax,[r14+10]
       mov       rax,[rax+8]
M00_L19:
       add       rsp,68
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L20:
       mov       rsi,[rbp-70]
       cmp       qword ptr [rsi+10],0
       je        short M00_L17
       jmp       near ptr M00_L41
M00_L21:
       mov       rdi,rsi
       mov       rsi,7A4306BBA010
       call      qword ptr [7A430603F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M00_L00
M00_L22:
       mov       rsi,7A4306BBA588
       call      qword ptr [7A430603F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L23:
       mov       rsi,7A4306BBA598
       call      qword ptr [7A430603F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M00_L03
M00_L24:
       cmp       [r15],rax
       jne       near ptr M00_L04
       mov       rdi,r15
       call      qword ptr [7A4306B969A0]
       test      eax,eax
       je        near ptr M00_L29
       mov       rdi,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdi,r15
       mov       rsi,7A42FD409FE0
       call      qword ptr [7A4306885260]
       mov       rdi,[rbx]
       mov       rsi,[rdi+30]
       mov       rsi,[rsi]
       mov       rax,[rsi+28]
       test      rax,rax
       je        short M00_L28
       mov       rdi,rax
M00_L25:
       mov       rsi,r15
       call      qword ptr [7A4306B96958]
       jmp       near ptr M00_L19
M00_L26:
       mov       rsi,7A4306BBAA40
       call      qword ptr [7A430603F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M00_L06
M00_L27:
       mov       rsi,7A4306BE8C58
       call      qword ptr [7A430603F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M00_L07
M00_L28:
       mov       rsi,7A4306BBA6E0
       call      qword ptr [7A430603F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       short M00_L25
M00_L29:
       mov       rdi,r15
       xor       esi,esi
       call      qword ptr [7A4306B969B8]; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.__Canon, System.Private.CoreLib]].WaitAsync(System.Threading.CancellationToken)
       jmp       near ptr M00_L19
M00_L30:
       mov       rsi,7A4306BBB180
       call      qword ptr [7A430603F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M00_L08
M00_L31:
       mov       rsi,7A4306BBB358
       call      qword ptr [7A430603F3A8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rbx,rax
       jmp       near ptr M00_L09
M00_L32:
       mov       edi,1
       mov       rsi,7A4306BC7E98
       call      qword ptr [7A430603EF88]
       mov       rdi,rax
       call      qword ptr [7A4306B9FB10]
       int       3
M00_L33:
       jmp       near ptr M00_L19
M00_L34:
       mov       rax,[rax]
       cmp       dword ptr [rax+20],0
       je        near ptr M00_L05
       jmp       short M00_L36
M00_L35:
       jmp       near ptr M00_L19
M00_L36:
       mov       rdi,[rbx]
       mov       rsi,[rdi+30]
       mov       rsi,[rsi]
       mov       rax,[rsi+10]
       test      rax,rax
       je        short M00_L37
       mov       rdi,rax
       jmp       short M00_L38
M00_L37:
       mov       rsi,7A4306BBA390
       call      qword ptr [7A430603F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M00_L38:
       mov       rsi,[rbx+20]
       call      qword ptr [7A4306B968C8]
       jmp       near ptr M00_L19
M00_L39:
       call      qword ptr [7A4306B9F588]
       int       3
M00_L40:
       mov       edi,4
       call      qword ptr [7A4306B9F690]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L10
M00_L41:
       mov       rdi,rbx
       mov       rsi,[rbp-70]
       call      qword ptr [7A4306B9F408]
       jmp       near ptr M00_L17
M00_L42:
       lea       rdi,[rbp-38]
       call      qword ptr [7A4306B9FAE0]
       jmp       near ptr M00_L18
       push      rax
       mov       rsi,[rbp-78]
       mov       rax,[rbp-68]
       cmp       rsi,[rax+10]
       je        short M00_L43
       lea       rdi,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-68]
M00_L43:
       mov       r14,[rax+8]
       mov       rsi,[rbp-70]
       cmp       rsi,r14
       je        short M00_L46
       lea       rdi,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      r14,r14
       je        short M00_L44
       cmp       qword ptr [r14+10],0
       jne       short M00_L45
M00_L44:
       cmp       qword ptr [rbp-70],0
       je        short M00_L46
       mov       rsi,[rbp-70]
       cmp       qword ptr [rsi+10],0
       je        short M00_L46
M00_L45:
       mov       rdi,r14
       mov       rsi,[rbp-70]
       call      qword ptr [7A4306B9F408]
M00_L46:
       nop
       add       rsp,8
       ret
; Total bytes of code 1255
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.__Canon, System.Private.CoreLib]](System.Threading.Tasks.Task`1<System.__Canon>)
       push      rbx
       mov       rbx,rsi
       mov       edi,[rbx+34]
       and       edi,11000000
       cmp       edi,1000000
       jne       short M01_L01
M01_L00:
       mov       rax,[rbx+38]
       pop       rbx
       ret
M01_L01:
       mov       rdi,rbx
       xor       esi,esi
       call      qword ptr [7A4306B9C588]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 40
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
       call      qword ptr [7A4305BDEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdi,[rbp-90]
       call      qword ptr [rax]
       lea       rdi,[rbp-88]
       call      qword ptr [7A4305BDEF08]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-30]
       call      qword ptr [7A4305BE0B98]
       lea       rdi,[rax+10]
       mov       rsi,[rbp-30]
       call      qword ptr [7A4305BDEEB8]; CORINFO_HELP_ASSIGN_REF
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
; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0B0]
       mov       [rbp-8C],rdi
       mov       rdx,rsi
       mov       [rbp-94],rdx
       xor       esi,esi
       mov       [rbp-9C],rsi
       mov       ecx,0FFFFFFFF
       mov       [rbp-84],ecx
       xor       r8d,r8d
       mov       [rbp-0A4],r8
       lea       rdi,[rbp-80]
       call      qword ptr [7A4305BDEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdi,[rbp-8C]
       mov       rdx,[rbp-94]
       mov       rsi,[rbp-9C]
       mov       ecx,[rbp-84]
       mov       r8,[rbp-0A4]
       call      qword ptr [rax]
       mov       rbx,rax
       lea       rdi,[rbp-80]
       call      qword ptr [7A4305BDEF08]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rax,rbx
       add       rsp,88
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 159
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
       call      qword ptr [7A4305BDEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdx,[rbp-8C]
       mov       rsi,[rbp-94]
       mov       rdi,[rbp-9C]
       mov       ecx,[rbp-84]
       mov       r8,[rbp-0A4]
       call      qword ptr [rax]
       mov       rbx,rax
       lea       rdi,[rbp-80]
       call      qword ptr [7A4305BDEF08]; CORINFO_HELP_JIT_PINVOKE_END
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
; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.__Canon, System.Private.CoreLib]].WaitAsync(System.Threading.CancellationToken)
       push      r15
       push      rbx
       push      rax
       mov       rbx,rsi
       test      rbx,rbx
       jne       short M06_L00
       mov       rax,[rdi+10]
       mov       rax,[rax+8]
       add       rsp,8
       pop       rbx
       pop       r15
       ret
M06_L00:
       mov       rdi,[rdi+10]
       mov       r15,[rdi+8]
       cmp       [r15],r15b
       mov       rdi,offset MT_System.TimeProvider
       call      qword ptr [7A4306035728]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,7A3340C014E0
       mov       rdx,[rdx]
       mov       rcx,rbx
       mov       rdi,r15
       mov       esi,0FFFFFFFF
       add       rsp,8
       pop       rbx
       pop       r15
       jmp       qword ptr [7A4306C443D8]
; Total bytes of code 92
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbp
       push      rbx
       push      rax
       lea       rbp,[rsp+10]
       mov       ebx,edi
       call      qword ptr [7A4305BF6AF0]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rbp
       push      r15
       push      rbx
       lea       rbp,[rsp+10]
       mov       rbx,rdi
       mov       r15d,esi
       test      dword ptr [rbx+34],1600000
       jne       short M08_L00
       mov       rdi,rbx
       mov       esi,0FFFFFFFF
       xor       edx,edx
       call      qword ptr [7A4306B9C5B8]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M08_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M08_L03
M08_L01:
       mov       edi,[rbx+34]
       and       edi,1600000
       cmp       edi,1000000
       jne       short M08_L04
M08_L02:
       pop       rbx
       pop       r15
       pop       rbp
       ret
M08_L03:
       mov       rdi,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M08_L01
       mov       rdi,rbx
       call      qword ptr [7A4306B9FEE8]
       jmp       short M08_L01
M08_L04:
       test      r15b,2
       jne       short M08_L05
       mov       rdi,rbx
       call      qword ptr [7A4306B9FD20]
M08_L05:
       mov       rdi,rbx
       call      qword ptr [7A4306C44468]
       jmp       short M08_L02
; Total bytes of code 125
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.__Canon, System.Private.CoreLib]].AsyncLazy_NoRecursionDetection()
       push      rbp
       push      r15
       push      rbx
       sub       rsp,10
       lea       rbp,[rsp+20]
       mov       [rbp-18],rdi
       mov       rbx,rdi
       mov       rdi,[rbx]
       mov       rsi,[rdi+30]
       mov       rsi,[rsi]
       mov       rsi,[rsi+28]
       test      rsi,rsi
       je        short M00_L01
M00_L00:
       mov       rdi,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M00_L02
       lea       rdi,[r15+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[r15+10]
       test      rax,rax
       jne       short M00_L03
       mov       rdi,r15
       xor       esi,esi
       add       rsp,10
       pop       rbx
       pop       r15
       pop       rbp
       jmp       qword ptr [700062986838]; System.Threading.Tasks.AsyncLazy`1[[System.__Canon, System.Private.CoreLib]].GetOrStartAttemptAsync(System.Threading.CancellationToken)
M00_L01:
       mov       rsi,7000629AA0A0
       call      qword ptr [700061E2F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       short M00_L00
M00_L02:
       mov       edi,1
       mov       rsi,7000629B7CB8
       call      qword ptr [700061E2EF88]
       mov       rdi,rax
       call      qword ptr [70006298FB70]
       int       3
M00_L03:
       add       rsp,10
       pop       rbx
       pop       r15
       pop       rbp
       ret
; Total bytes of code 157
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.__Canon, System.Private.CoreLib]](System.Threading.Tasks.Task`1<System.__Canon>)
       push      rbx
       mov       rbx,rsi
       mov       edi,[rbx+34]
       and       edi,11000000
       cmp       edi,1000000
       jne       short M01_L01
M01_L00:
       mov       rax,[rbx+38]
       pop       rbx
       ret
M01_L01:
       mov       rdi,rbx
       xor       esi,esi
       call      qword ptr [700062987510]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 40
```
```assembly
; System.Threading.Tasks.AsyncLazy`1[[System.__Canon, System.Private.CoreLib]].GetOrStartAttemptAsync(System.Threading.CancellationToken)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+50]
       mov       [rbp-30],rdi
       mov       rbx,rdi
       mov       r15,rsi
M02_L00:
       mov       r14,[rbx+8]
       mov       r13,[rbx]
       mov       rdi,r13
       mov       rsi,[rdi+30]
       mov       rsi,[rsi]
       mov       rax,[rsi+18]
       test      rax,rax
       je        near ptr M02_L18
       mov       rdi,rax
M02_L01:
       mov       rsi,r14
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M02_L30
       mov       rdi,[r13+30]
       mov       rdi,[rdi]
       mov       rdi,[rdi+20]
       test      rdi,rdi
       je        near ptr M02_L19
M02_L02:
       mov       rax,rdi
       test      r14,r14
       jne       near ptr M02_L20
M02_L03:
       lea       rax,[rbx+20]
       cmp       qword ptr [rax],0
       jne       near ptr M02_L29
M02_L04:
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rdi,[r12]
       mov       rsi,[rdi+30]
       mov       rsi,[rsi]
       mov       rsi,[rsi+10]
       test      rsi,rsi
       je        near ptr M02_L21
M02_L05:
       mov       rdi,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdi,[r14]
       mov       rsi,[rdi+30]
       mov       rsi,[rsi]
       mov       rsi,[rsi+18]
       test      rsi,rsi
       je        near ptr M02_L22
M02_L06:
       mov       rdi,rsi
       call      CORINFO_HELP_NEWSFAST
       xor       edi,edi
       mov       [rax+8],rdi
       mov       [rax+10],rdi
       mov       [rax+18],rdi
       mov       dword ptr [rax+34],2000440
       lea       rdi,[r14+8]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdi,[r12+10]
       mov       rsi,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdi,[r12+8]
       mov       rsi,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdi,[rbx+8]
       test      rdi,rdi
       je        near ptr M02_L34
       mov       rsi,r12
       xor       edx,edx
       call      00007000E0274060
       test      rax,rax
       jne       near ptr M02_L00
       mov       rdi,[r13+30]
       mov       rdi,[rdi]
       mov       rdi,[rdi+28]
       test      rdi,rdi
       je        near ptr M02_L23
M02_L07:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r14,[rax+8]
       test      r14,r14
       je        near ptr M02_L35
M02_L08:
       mov       rdi,[r13+30]
       mov       rdi,[rdi]
       mov       rax,[rdi+30]
       test      rax,rax
       je        near ptr M02_L24
       mov       r13,rax
M02_L09:
       mov       rdi,7000E04A0D68
       mov       rax,7000E0E87820
       call      rax
       cmp       dword ptr [rax],4
       jle       near ptr M02_L43
       mov       rdi,[rax+8]
       mov       rax,[rdi+20]
       test      rax,rax
       je        near ptr M02_L43
M02_L10:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M02_L11
       call      qword ptr [70006267C048]; System.Threading.Thread.InitializeCurrentThread()
M02_L11:
       mov       rdi,[rax+8]
       test      rdi,rdi
       jne       near ptr M02_L44
       mov       rdi,6FF0A0C01390
       mov       rdi,[rdi]
M02_L12:
       test      rdi,rdi
       je        short M02_L13
       mov       [rbp-48],rdi
       cmp       byte ptr [rdi+19],0
       je        near ptr M02_L45
M02_L13:
       mov       rdi,[r13+18]
       mov       rdi,[rdi+18]
       test      rdi,rdi
       je        near ptr M02_L25
M02_L14:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rdi,[r13+8]
       mov       rsi,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdi,[r13+10]
       mov       rsi,r12
       call      CORINFO_HELP_ASSIGN_REF
M02_L15:
       mov       rdi,6FF0A0C013A0
       mov       r14,[rdi]
       cmp       byte ptr [r14+38],0
       jne       near ptr M02_L48
M02_L16:
       mov       rdi,[r14+8]
       mov       rsi,[rdi+10]
       mov       rcx,[rsi+8]
M02_L17:
       mov       edx,[rsi+0A0]
       mov       eax,edx
       and       eax,[rsi+18]
       cmp       eax,[rcx+8]
       jae       near ptr M02_L51
       shl       rax,4
       lea       r8,[rcx+rax+10]
       mov       eax,[r8+8]
       sub       eax,edx
       jne       near ptr M02_L26
       lea       r9,[rsi+0A0]
       lea       r10d,[rdx+1]
       mov       eax,edx
       lock cmpxchg [r9],r10d
       cmp       eax,edx
       mov       [rbp-34],edx
       jne       short M02_L17
       mov       rcx,r8
       mov       [rbp-50],rcx
       mov       rdi,rcx
       mov       rsi,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13d,[rbp-34]
       inc       r13d
       mov       rdi,[rbp-50]
       mov       [rdi+8],r13d
       jmp       near ptr M02_L27
M02_L18:
       mov       rsi,7000629AA618
       call      qword ptr [700061E2F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M02_L01
M02_L19:
       mov       rdi,r13
       mov       rsi,7000629AA628
       call      qword ptr [700061E2F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M02_L02
M02_L20:
       cmp       [r14],rax
       jne       near ptr M02_L03
       mov       rdi,r14
       mov       rsi,r15
       add       rsp,28
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7000629868C8]; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.__Canon, System.Private.CoreLib]].WaitAsync(System.Threading.CancellationToken)
M02_L21:
       mov       rsi,7000629AD1A8
       call      qword ptr [700061E2F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M02_L05
M02_L22:
       mov       rsi,7000629DB6F8
       call      qword ptr [700061E2F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M02_L06
M02_L23:
       mov       rdi,r13
       mov       rsi,7000629AA820
       call      qword ptr [700061E2F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M02_L07
M02_L24:
       mov       rdi,r13
       mov       rsi,7000629ACD48
       call      qword ptr [700061E2F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M02_L09
M02_L25:
       mov       rdi,r13
       mov       rsi,7000629DB9D8
       call      qword ptr [700061E2F3A8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M02_L14
M02_L26:
       test      eax,eax
       jge       near ptr M02_L17
       mov       rsi,r13
       call      qword ptr [70006298F8A0]
M02_L27:
       add       r14,78
       mov       edi,1
       xchg      edi,[r14]
       test      edi,edi
       jne       short M02_L28
       mov       rdi,6FF0A0C013C8
       mov       r14,[rdi]
       lea       rdi,[r14+160]
       lock inc  dword ptr [rdi]
       mov       rdi,r14
       call      qword ptr [700062986D30]; System.Threading.PortableThreadPool+WorkerThread.MaybeAddWorkingWorker(System.Threading.PortableThreadPool)
       cmp       dword ptr [r14+164],6
       jne       near ptr M02_L49
M02_L28:
       test      r15,r15
       jne       near ptr M02_L50
       mov       rax,[r12+10]
       mov       rax,[rax+8]
       add       rsp,28
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L29:
       mov       rax,[rax]
       cmp       dword ptr [rax+20],0
       je        near ptr M02_L04
       jmp       short M02_L31
M02_L30:
       add       rsp,28
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L31:
       mov       rdi,[r13+30]
       mov       rdi,[rdi]
       mov       rdi,[rdi+10]
       test      rdi,rdi
       je        short M02_L32
       jmp       short M02_L33
M02_L32:
       mov       rdi,r13
       mov       rsi,7000629AA420
       call      qword ptr [700061E2F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M02_L33:
       mov       rsi,[rbx+20]
       add       rsp,28
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7000629867D8]
M02_L34:
       call      qword ptr [70006298F780]
       int       3
M02_L35:
       mov       rdi,[r13+30]
       mov       rdi,[rdi]
       mov       r14,[rdi+28]
       test      r14,r14
       je        short M02_L36
       jmp       short M02_L37
M02_L36:
       mov       rdi,r13
       mov       rsi,7000629AA820
       call      qword ptr [700061E2F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r14,rax
M02_L37:
       mov       rdi,[r13+30]
       mov       rdi,[rdi]
       cmp       qword ptr [rdi+8],38
       jle       short M02_L38
       mov       rdi,[rdi+38]
       test      rdi,rdi
       je        short M02_L38
       jmp       short M02_L39
M02_L38:
       mov       rdi,r13
       mov       rsi,7000629ACE30
       call      qword ptr [700061E2F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M02_L39:
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rdi,r14
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rsi,[rax]
       test      rsi,rsi
       jne       short M02_L40
       call      qword ptr [700062A34438]
       int       3
M02_L40:
       mov       r14,[rbp-40]
       lea       rdi,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset System.Threading.Tasks.AsyncLazy`1+<>c[[System.__Canon, System.Private.CoreLib]].<GetOrStartAttemptAsync>b__11_0(Attempt<System.__Canon>)
       mov       [r14+18],rdi
       mov       rdi,[r13+30]
       mov       rdi,[rdi]
       mov       rdi,[rdi+28]
       test      rdi,rdi
       je        short M02_L41
       jmp       short M02_L42
M02_L41:
       mov       rdi,r13
       mov       rsi,7000629AA820
       call      qword ptr [700061E2F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M02_L42:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       lea       rdi,[rax+8]
       mov       rsi,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L08
M02_L43:
       mov       edi,4
       call      qword ptr [70006298F648]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M02_L10
M02_L44:
       xor       esi,esi
       cmp       byte ptr [rdi+18],0
       cmovne    rdi,rsi
       jmp       near ptr M02_L12
M02_L45:
       mov       rsi,[r13+18]
       mov       rsi,[rsi+20]
       test      rsi,rsi
       je        short M02_L46
       jmp       short M02_L47
M02_L46:
       mov       rdi,r13
       mov       rsi,7000629DBB70
       call      qword ptr [700061E2F3A8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
M02_L47:
       mov       rdi,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdi,r13
       mov       rsi,r14
       mov       rdx,r12
       mov       rcx,[rbp-48]
       call      qword ptr [70006298FC30]
       jmp       near ptr M02_L15
M02_L48:
       mov       rdi,6FF0A0C013B8
       mov       rdi,[rdi]
       cmp       byte ptr [rdi+9D],0
       je        near ptr M02_L16
       mov       rdi,6FF0A0C013B8
       mov       rdi,[rdi]
       mov       rsi,r13
       call      qword ptr [70006298F888]
       jmp       near ptr M02_L16
M02_L49:
       mov       rdi,r14
       call      qword ptr [700062986F88]; System.Threading.PortableThreadPool+GateThread.EnsureRunningSlow(System.Threading.PortableThreadPool)
       jmp       near ptr M02_L28
M02_L50:
       mov       rdi,[r12+10]
       mov       r14,[rdi+8]
       cmp       [r14],r14b
       mov       rdi,offset MT_System.TimeProvider
       call      qword ptr [700061E25728]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,6FF0A0C014F0
       mov       rdx,[rdx]
       mov       rcx,r15
       mov       rdi,r14
       mov       esi,0FFFFFFFF
       add       rsp,28
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [700062A34450]
M02_L51:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1532
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
       call      qword ptr [7000619CEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdx,[rbp-8C]
       mov       rsi,[rbp-94]
       mov       rdi,[rbp-9C]
       mov       ecx,[rbp-84]
       mov       r8,[rbp-0A4]
       call      qword ptr [rax]
       mov       rbx,rax
       lea       rdi,[rbp-80]
       call      qword ptr [7000619CEF08]; CORINFO_HELP_JIT_PINVOKE_END
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
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rbp
       push      r15
       push      rbx
       lea       rbp,[rsp+10]
       mov       rbx,rdi
       mov       r15d,esi
       test      dword ptr [rbx+34],1600000
       jne       short M04_L00
       mov       rdi,rbx
       mov       esi,0FFFFFFFF
       xor       edx,edx
       call      qword ptr [700062987540]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M04_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M04_L03
M04_L01:
       mov       edi,[rbx+34]
       and       edi,1600000
       cmp       edi,1000000
       jne       short M04_L04
M04_L02:
       pop       rbx
       pop       r15
       pop       rbp
       ret
M04_L03:
       mov       rdi,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M04_L01
       mov       rdi,rbx
       call      qword ptr [70006298FB58]
       jmp       short M04_L01
M04_L04:
       test      r15b,2
       jne       short M04_L05
       mov       rdi,rbx
       call      qword ptr [70006298FC78]
M04_L05:
       mov       rdi,rbx
       call      qword ptr [700062A34468]
       jmp       short M04_L02
; Total bytes of code 125
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.__Canon, System.Private.CoreLib]].Nito()
       push      rbp
       push      r15
       push      r14
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       [rbp-20],rdi
       mov       [rbp-30],rdi
       mov       rsi,[rdi]
       mov       rax,[rsi+30]
       mov       rax,[rax]
       mov       rbx,[rax+28]
       test      rbx,rbx
       je        near ptr M00_L09
M00_L00:
       mov       rdi,[rbp-30]
       mov       r15,[rdi+8]
       test      r15,r15
       je        near ptr M00_L13
       mov       rsi,[rbx+30]
       mov       rsi,[rsi]
       mov       rsi,[rsi+18]
       test      rsi,rsi
       je        near ptr M00_L10
M00_L01:
       mov       rdi,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rdi,[r14+8]
       mov       rsi,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbx+30]
       mov       rdi,[rdi]
       mov       rdi,[rdi+20]
       test      rdi,rdi
       je        near ptr M00_L11
M00_L02:
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rdi,[r15+8]
       mov       rsi,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset Nito.AsyncEx.AsyncLazy`1+<>c__DisplayClass14_0[[System.__Canon, System.Private.CoreLib]].<RunOnThreadPool>b__0()
       mov       [r15+18],rdi
       mov       rdi,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdi,[rbx+30]
       mov       rdi,[rdi]
       mov       rdi,[rdi+10]
       test      rdi,rdi
       je        near ptr M00_L12
M00_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rdi,[rbx+10]
       mov       rsi,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset MT_System.LazyHelper
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+10],8
       lea       rdi,[rbx+8]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-38],r14
       xor       edi,edi
       mov       [rbp-24],edi
       mov       rdi,r14
       call      00007EC78C4E6020
       test      eax,eax
       je        short M00_L05
M00_L04:
       mov       dword ptr [rbp-24],1
       cmp       qword ptr [rbx+8],0
       je        short M00_L06
       mov       rdi,rbx
       call      qword ptr [7EC70EA8C438]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       r15,rax
       jmp       short M00_L07
M00_L05:
       mov       rdi,r14
       call      qword ptr [7EC70ED9CF00]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L04
M00_L06:
       mov       r15,[rbx+18]
M00_L07:
       mov       rdi,r14
       call      00007EC78C4E6790
       test      eax,eax
       jne       near ptr M00_L14
M00_L08:
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L09:
       mov       rdi,rsi
       mov       rsi,7EC70EDBBE18
       call      qword ptr [7EC70E23F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rbx,rax
       jmp       near ptr M00_L00
M00_L10:
       mov       rdi,rbx
       mov       rsi,7EC70EDBC220
       call      qword ptr [7EC70E23F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M00_L01
M00_L11:
       mov       rdi,rbx
       mov       rsi,7EC70EDBC248
       call      qword ptr [7EC70E23F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L12:
       mov       rdi,rbx
       mov       rsi,7EC70EDBBFE8
       call      qword ptr [7EC70E23F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M00_L03
M00_L13:
       mov       rdi,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       edi,10E
       mov       rsi,7EC70EDC7CB0
       call      qword ptr [7EC70E23EF88]
       mov       rsi,rax
       mov       rdi,rbx
       call      qword ptr [7EC70EA8E1C0]
       mov       rdi,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L14:
       mov       edi,eax
       mov       rsi,r14
       call      qword ptr [7EC70ED9CF30]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       near ptr M00_L08
       push      rax
       cmp       dword ptr [rbp-24],0
       je        short M00_L15
       mov       rdi,[rbp-38]
       call      00007EC78C4E6790
       test      eax,eax
       je        short M00_L15
       mov       edi,eax
       mov       rsi,[rbp-38]
       call      qword ptr [7EC70ED9CF30]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M00_L15:
       nop
       add       rsp,8
       ret
; Total bytes of code 568
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.__Canon, System.Private.CoreLib]](System.Threading.Tasks.Task`1<System.__Canon>)
       push      rbx
       mov       rbx,rsi
       mov       edi,[rbx+34]
       and       edi,11000000
       cmp       edi,1000000
       jne       short M01_L01
M01_L00:
       mov       rax,[rbx+38]
       pop       rbx
       ret
M01_L01:
       mov       rdi,rbx
       xor       esi,esi
       call      qword ptr [7EC70ED97690]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 40
```
```assembly
; Nito.AsyncEx.AsyncLazy`1+<>c__DisplayClass14_0[[System.__Canon, System.Private.CoreLib]].<RunOnThreadPool>b__0()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rbx
       push      rax
       lea       rbp,[rsp+30]
       mov       [rbp-30],rdi
       mov       rbx,rdi
       mov       rdi,[rbx]
       mov       rsi,[rdi+30]
       mov       rsi,[rsi]
       mov       rsi,[rsi+10]
       test      rsi,rsi
       je        short M02_L02
M02_L00:
       mov       r15,[rbx+8]
       mov       rdi,[rsi+18]
       mov       r14,[rdi+18]
       test      r14,r14
       je        short M02_L03
M02_L01:
       test      r15,r15
       jne       short M02_L04
       mov       edi,2E
       call      qword ptr [7EC70E23FAE0]
       int       3
M02_L02:
       mov       rsi,7EC70EDBC4A8
       call      qword ptr [7EC70E23F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       short M02_L00
M02_L03:
       mov       rdi,rsi
       mov       rsi,7EC70EDEA200
       call      qword ptr [7EC70E23F3A8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r14,rax
       jmp       short M02_L01
M02_L04:
       mov       rdi,[r14+18]
       mov       rdi,[rdi+20]
       test      rdi,rdi
       je        near ptr M02_L13
M02_L05:
       call      qword ptr [7EC70ED96880]; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].get_Factory()
       mov       rdi,[rax]
       mov       rsi,[rdi+30]
       mov       rsi,[rsi]
       mov       rsi,[rsi+18]
       test      rsi,rsi
       je        near ptr M02_L14
M02_L06:
       mov       rdi,7EB748C01398
       mov       r13,[rdi]
       mov       rdi,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rdi,[r12+8]
       mov       rsi,r15
       call      CORINFO_HELP_ASSIGN_REF
       xor       edi,edi
       mov       [r12+10],rdi
       lea       rdi,[r12+18]
       mov       rsi,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       edi,2008
       mov       [r12+34],edi
       mov       rdi,7EC78C8A0D68
       mov       rax,7EC78D1F0820
       call      rax
       cmp       dword ptr [rax],4
       jle       near ptr M02_L30
       mov       rdi,[rax+8]
       mov       rax,[rdi+20]
       test      rax,rax
       je        near ptr M02_L30
M02_L07:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M02_L08
       call      qword ptr [7EC70EA8C048]; System.Threading.Thread.InitializeCurrentThread()
M02_L08:
       mov       r15,[rax+8]
       test      r15,r15
       jne       near ptr M02_L31
       mov       rdi,7EB748C013A8
       mov       r15,[rdi]
M02_L09:
       test      r15,r15
       jne       near ptr M02_L15
       or        dword ptr [r12+34],20000000
M02_L10:
       mov       rdi,r12
       xor       esi,esi
       call      qword ptr [7EC70ED96A18]; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
       mov       rdi,[r14+18]
       mov       rdi,[rdi+28]
       test      rdi,rdi
       je        near ptr M02_L16
M02_L11:
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       movzx     r14d,word ptr [r12+34]
       and       r14d,4
       test      r14d,0FFFFFFBB
       je        near ptr M02_L17
M02_L12:
       mov       edi,2D
       call      qword ptr [7EC70E23F0D8]
       int       3
M02_L13:
       mov       rdi,r14
       mov       rsi,7EC70EDEA390
       call      qword ptr [7EC70E23F3A8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M02_L05
M02_L14:
       mov       rsi,7EC70EDEA5D0
       call      qword ptr [7EC70E23F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M02_L06
M02_L15:
       mov       rdi,7EB748C013A8
       cmp       r15,[rdi]
       je        near ptr M02_L10
       mov       rdi,r12
       call      qword ptr [7EC70ED9F6C0]
       lea       rdi,[rax+8]
       mov       rsi,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L10
M02_L16:
       mov       rdi,r14
       mov       rsi,7EC70EDEA428
       call      qword ptr [7EC70E23F3A8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M02_L11
M02_L17:
       test      r14b,4
       je        short M02_L19
       mov       rdi,7EC78C8A0D68
       mov       rax,7EC78D1F0820
       call      rax
       cmp       dword ptr [rax],8
       jle       near ptr M02_L32
       mov       rdi,[rax+8]
       mov       rax,[rdi+40]
       test      rax,rax
       je        near ptr M02_L32
M02_L18:
       mov       r13,[rax+10]
       test      r13,r13
       je        short M02_L19
       mov       rdi,r15
       call      qword ptr [7EC70ED9F6C0]
       lea       rdi,[rax+30]
       mov       rsi,r13
       call      CORINFO_HELP_ASSIGN_REF
M02_L19:
       xor       edi,edi
       mov       [r15+8],rdi
       mov       [r15+10],rdi
       mov       [r15+18],rdi
       test      r14d,0FFFFFFA0
       jne       near ptr M02_L12
       mov       edi,r14d
       or        edi,400
       or        edi,2000000
       mov       [r15+34],edi
       mov       rdi,[r15+28]
       test      rdi,rdi
       jne       near ptr M02_L33
M02_L20:
       mov       byte ptr [r15+41],1
       mov       rax,7EB748C013B8
       mov       rax,[rax]
       cmp       byte ptr [rax+9D],0
       je        short M02_L22
       cmp       dword ptr [r15+30],0
       jne       short M02_L21
       call      qword ptr [7EC70ED9F3C0]
       mov       esi,eax
       lea       rdi,[r15+30]
       xor       eax,eax
       lock cmpxchg [rdi],esi
M02_L21:
       mov       esi,[r15+30]
       mov       rdi,7EB748C013B8
       mov       rdi,[rdi]
       mov       rdx,7EC70540AC10
       xor       ecx,ecx
       call      qword ptr [7EC70ED9F6D8]
M02_L22:
       cmp       byte ptr [7EC70D24B06C],0
       je        short M02_L23
       mov       rdi,r15
       call      qword ptr [7EC70ED97E70]
M02_L23:
       test      dword ptr [r12+34],1600000
       jne       short M02_L25
       test      dword ptr [r12+34],1600000
       jne       near ptr M02_L39
       cmp       qword ptr [r12+20],0
       jne       near ptr M02_L38
       lea       rdi,[r12+20]
       test      rdi,rdi
       je        near ptr M02_L37
       mov       rsi,r15
       xor       edx,edx
       call      00007EC78C674060
       test      rax,rax
       jne       near ptr M02_L38
M02_L24:
       mov       rax,r15
       add       rsp,8
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L25:
       mov       byte ptr [r15+40],1
       mov       rdi,r12
       call      qword ptr [7EC70ED9C090]; System.Threading.Tasks.Task.get_Status()
       cmp       eax,5
       jne       near ptr M02_L34
       mov       rdi,[r15]
       mov       rsi,[rdi+30]
       mov       rsi,[rsi+8]
       mov       rax,[rsi+28]
       test      rax,rax
       je        short M02_L27
       mov       rdi,rax
M02_L26:
       mov       rsi,r12
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M02_L35
       mov       edi,[rax+34]
       and       edi,11000000
       cmp       edi,1000000
       jne       short M02_L28
       mov       rsi,[rax+38]
       jmp       short M02_L29
M02_L27:
       mov       rsi,7EC70EDED8E0
       call      qword ptr [7EC70E23F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       short M02_L26
M02_L28:
       mov       rdi,rax
       mov       esi,1
       call      qword ptr [7EC70ED9F450]
       mov       rsi,rax
M02_L29:
       mov       rdi,r15
       call      qword ptr [7EC70ED9C0A8]; System.Threading.Tasks.UnwrapPromise`1[[System.__Canon, System.Private.CoreLib]].ProcessInnerTask(System.Threading.Tasks.Task)
       jmp       near ptr M02_L24
M02_L30:
       mov       edi,4
       call      qword ptr [7EC70ED9EF40]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M02_L07
M02_L31:
       xor       edi,edi
       cmp       byte ptr [r15+18],0
       cmovne    r15,rdi
       jmp       near ptr M02_L09
M02_L32:
       mov       edi,8
       call      qword ptr [7EC70ED9EF40]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M02_L18
M02_L33:
       mov       rdi,[rdi+30]
       test      rdi,rdi
       je        near ptr M02_L20
       test      r14b,4
       je        near ptr M02_L20
       test      byte ptr [rdi+34],8
       jne       near ptr M02_L20
       call      qword ptr [7EC70ED9F228]
       jmp       near ptr M02_L20
M02_L34:
       add       eax,0FFFFFFFA
       cmp       eax,1
       ja        near ptr M02_L24
       movzx     edx,byte ptr [r15+41]
       mov       rdi,r15
       mov       rsi,r12
       call      qword ptr [7EC70ED9C3F0]; System.Threading.Tasks.UnwrapPromise`1[[System.__Canon, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       jmp       near ptr M02_L24
M02_L35:
       mov       rdi,r12
       mov       rax,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task>
       cmp       [rdi],rax
       je        short M02_L36
       mov       rsi,r12
       mov       rdi,rax
       call      qword ptr [7EC70E664AF8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rdi,rax
M02_L36:
       cmp       [rdi],edi
       call      qword ptr [7EC70ED9C408]; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].get_Result()
       mov       rsi,rax
       jmp       near ptr M02_L29
M02_L37:
       call      qword ptr [7EC70ED9EE20]
       int       3
M02_L38:
       mov       rdi,r12
       mov       rsi,r15
       xor       edx,edx
       call      qword ptr [7EC70ED9CED0]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M02_L24
M02_L39:
       mov       rdi,r15
       mov       rsi,r12
       call      qword ptr [7EC70EDD6AD8]; System.Threading.Tasks.UnwrapPromise`1[[System.__Canon, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
       jmp       near ptr M02_L24
; Total bytes of code 1231
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
       call      00007EC78C4E6020
       test      eax,eax
       je        short M03_L03
M03_L02:
       mov       dword ptr [rbp-14],1
       mov       rdi,[rbp-20]
       cmp       [rdi+8],rbx
       jne       short M03_L04
       mov       esi,2
       call      qword ptr [7EC70EA8C468]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M03_L04
M03_L03:
       mov       rdi,rbx
       call      qword ptr [7EC70ED9CF00]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M03_L02
M03_L04:
       mov       rdi,rbx
       call      00007EC78C4E6790
       test      eax,eax
       jne       near ptr M03_L12
M03_L05:
       mov       rdi,[rbp-20]
       cmp       qword ptr [rdi+8],0
       je        near ptr M03_L13
       add       rsp,28
       pop       rbx
       pop       rbp
       jmp       qword ptr [7EC70EA8C438]
M03_L06:
       cmp       eax,8
       ja        short M03_L07
       mov       eax,eax
       lea       rcx,[7EC70E2BC630]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M03_L01]
       add       rcx,rdx
       jmp       rcx
M03_L07:
       mov       rdi,[rbx+8]
       cmp       [rdi],edi
       call      qword ptr [7EC70ED9F2A0]
       int       3
       mov       rdi,[rbp-20]
       call      qword ptr [7EC70ED9F540]
       jmp       short M03_L05
       mov       rdi,[rbp-20]
       xor       esi,esi
       call      qword ptr [7EC70EA8C468]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
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
       mov       rsi,7EC70EDE9C68
       call      qword ptr [7EC70E23F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M03_L09:
       mov       rdi,[rax+30]
       mov       rdi,[rdi]
       mov       rdi,[rdi+18]
       test      rdi,rdi
       je        short M03_L10
       jmp       short M03_L11
M03_L10:
       mov       rdi,rax
       mov       rsi,7EC70EDE9D08
       call      qword ptr [7EC70E23F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M03_L11:
       call      qword ptr [7EC70ED9F4E0]
       mov       rdx,rax
       mov       rsi,rbx
       mov       rdi,[rbp-20]
       call      qword ptr [7EC70ED9F558]
       jmp       near ptr M03_L05
       mov       rdi,[rbp-20]
       mov       rsi,rbx
       call      qword ptr [7EC70ED9F570]
       jmp       near ptr M03_L05
       mov       rdi,[rbp-20]
       call      qword ptr [7EC70ED9F588]
       jmp       near ptr M03_L05
       mov       rdi,[rbp-20]
       mov       rsi,rbx
       mov       edx,1
       call      qword ptr [7EC70EA8C450]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M03_L05
M03_L12:
       mov       edi,eax
       mov       rsi,rbx
       call      qword ptr [7EC70ED9CF30]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
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
       call      00007EC78C4E6790
       test      eax,eax
       je        short M03_L14
       mov       edi,eax
       mov       rsi,[rbp-28]
       call      qword ptr [7EC70ED9CF30]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
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
       sub       rsp,48
       vzeroupper
       lea       rbp,[rsp+70]
       mov       [rbp-30],rdi
       lea       rdi,[rbp-68]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rbx,rax
       mov       rdi,rsp
       mov       [rbp-50],rdi
       mov       rdi,rbp
       mov       [rbp-40],rdi
       lea       rdi,[rbp-30]
       mov       rax,7EC70E277D28
       mov       [rbp-58],rax
       lea       rax,[M04_L00]
       mov       [rbp-48],rax
       lea       rax,[rbp-68]
       mov       [rbx+8],rax
       mov       byte ptr [rbx+4],0
       mov       rax,7EC78C4E5E10
       call      rax
M04_L00:
       mov       byte ptr [rbx+4],1
       cmp       dword ptr [7EC78C8CEC80],0
       je        short M04_L01
       call      qword ptr [7EC78C8BB1D8]; CORINFO_HELP_STOP_FOR_GC
M04_L01:
       mov       rax,[rbp-60]
       mov       [rbx+8],rax
       add       rsp,48
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 147
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
       call      qword ptr [7EC70DDDEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdx,[rbp-8C]
       mov       rsi,[rbp-94]
       mov       rdi,[rbp-9C]
       mov       ecx,[rbp-84]
       mov       r8,[rbp-0A4]
       call      qword ptr [rax]
       mov       rbx,rax
       lea       rdi,[rbp-80]
       call      qword ptr [7EC70DDDEF08]; CORINFO_HELP_JIT_PINVOKE_END
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
; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rbx
       sub       rsp,78
       lea       rbp,[rsp+0A0]
       mov       [rbp-30],rsi
       mov       esi,edi
       lea       rdi,[rbp-30]
       mov       [rbp-94],rdi
       mov       [rbp-8C],esi
       lea       rdi,[rbp-88]
       call      qword ptr [7EC70DDDEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdi,[rbp-94]
       mov       esi,[rbp-8C]
       call      qword ptr [rax]
       lea       rdi,[rbp-88]
       call      qword ptr [7EC70DDDEF08]; CORINFO_HELP_JIT_PINVOKE_END
       nop
       add       rsp,78
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 109
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
       call      qword ptr [7EC70ED976A8]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7EC70ED9F480]
       jmp       short M07_L01
M07_L04:
       test      r15b,2
       jne       short M07_L05
       mov       rdi,rbx
       call      qword ptr [7EC70ED9FA08]
M07_L05:
       mov       rdi,rbx
       call      qword ptr [7EC70EE541B0]
       jmp       short M07_L02
; Total bytes of code 125
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.__Canon, System.Private.CoreLib]].Nito_ExecuteOnCallingThread()
       push      rbp
       push      r15
       push      r14
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       [rbp-20],rdi
       mov       [rbp-30],rdi
       mov       rsi,[rdi]
       mov       rax,[rsi+30]
       mov       rax,[rax]
       mov       rbx,[rax+28]
       test      rbx,rbx
       je        near ptr M00_L07
M00_L00:
       mov       rdi,[rbp-30]
       mov       r15,[rdi+8]
       test      r15,r15
       je        near ptr M00_L09
       mov       rdi,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdi,[rbx+30]
       mov       rdi,[rdi]
       mov       rdi,[rdi+10]
       test      rdi,rdi
       je        near ptr M00_L08
M00_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rdi,[rbx+10]
       mov       rsi,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset MT_System.LazyHelper
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+10],8
       lea       rdi,[rbx+8]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-38],r14
       xor       edi,edi
       mov       [rbp-24],edi
       mov       rdi,r14
       call      0000765CF1AE6020
       test      eax,eax
       je        short M00_L03
M00_L02:
       mov       dword ptr [rbp-24],1
       cmp       qword ptr [rbx+8],0
       je        short M00_L04
       mov       rdi,rbx
       call      qword ptr [765C7409C438]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       r15,rax
       jmp       short M00_L05
M00_L03:
       mov       rdi,r14
       call      qword ptr [765C743AEDC0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L02
M00_L04:
       mov       r15,[rbx+18]
M00_L05:
       mov       rdi,r14
       call      0000765CF1AE6790
       test      eax,eax
       jne       near ptr M00_L10
M00_L06:
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L07:
       mov       rdi,rsi
       mov       rsi,765C743CBE18
       call      qword ptr [765C7384F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rbx,rax
       jmp       near ptr M00_L00
M00_L08:
       mov       rdi,rbx
       mov       rsi,765C743CBFE8
       call      qword ptr [765C7384F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M00_L01
M00_L09:
       mov       rdi,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       edi,10E
       mov       rsi,765C743D7CB0
       call      qword ptr [765C7384EF88]
       mov       rsi,rax
       mov       rdi,rbx
       call      qword ptr [765C7409E1C0]
       mov       rdi,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L10:
       mov       edi,eax
       mov       rsi,r14
       call      qword ptr [765C743AE9B8]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       near ptr M00_L06
       push      rax
       cmp       dword ptr [rbp-24],0
       je        short M00_L11
       mov       rdi,[rbp-38]
       call      0000765CF1AE6790
       test      eax,eax
       je        short M00_L11
       mov       edi,eax
       mov       rsi,[rbp-38]
       call      qword ptr [765C743AE9B8]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M00_L11:
       nop
       add       rsp,8
       ret
; Total bytes of code 417
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.__Canon, System.Private.CoreLib]](System.Threading.Tasks.Task`1<System.__Canon>)
       push      rbx
       mov       rbx,rsi
       mov       edi,[rbx+34]
       and       edi,11000000
       cmp       edi,1000000
       jne       short M01_L01
M01_L00:
       mov       rax,[rbx+38]
       pop       rbx
       ret
M01_L01:
       mov       rdi,rbx
       xor       esi,esi
       call      qword ptr [765C743A79D8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 40
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
       call      0000765CF1AE6020
       test      eax,eax
       je        short M02_L03
M02_L02:
       mov       dword ptr [rbp-14],1
       mov       rdi,[rbp-20]
       cmp       [rdi+8],rbx
       jne       short M02_L04
       mov       esi,2
       call      qword ptr [765C7409C468]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M02_L04
M02_L03:
       mov       rdi,rbx
       call      qword ptr [765C743AEDC0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M02_L02
M02_L04:
       mov       rdi,rbx
       call      0000765CF1AE6790
       test      eax,eax
       jne       near ptr M02_L12
M02_L05:
       mov       rdi,[rbp-20]
       cmp       qword ptr [rdi+8],0
       je        near ptr M02_L13
       add       rsp,28
       pop       rbx
       pop       rbp
       jmp       qword ptr [765C7409C438]
M02_L06:
       cmp       eax,8
       ja        short M02_L07
       mov       eax,eax
       lea       rcx,[765C738C44A0]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M02_L01]
       add       rcx,rdx
       jmp       rcx
M02_L07:
       mov       rdi,[rbx+8]
       cmp       [rdi],edi
       call      qword ptr [765C743AEE98]
       int       3
       mov       rdi,[rbp-20]
       call      qword ptr [765C743AEE38]
       jmp       short M02_L05
       mov       rdi,[rbp-20]
       xor       esi,esi
       call      qword ptr [765C7409C468]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
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
       mov       rsi,765C743F63A8
       call      qword ptr [765C7384F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L09:
       mov       rdi,[rax+30]
       mov       rdi,[rdi]
       mov       rdi,[rdi+18]
       test      rdi,rdi
       je        short M02_L10
       jmp       short M02_L11
M02_L10:
       mov       rdi,rax
       mov       rsi,765C743F6448
       call      qword ptr [765C7384F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M02_L11:
       call      qword ptr [765C743AEDD8]
       mov       rdx,rax
       mov       rsi,rbx
       mov       rdi,[rbp-20]
       call      qword ptr [765C743AEE50]
       jmp       near ptr M02_L05
       mov       rdi,[rbp-20]
       mov       rsi,rbx
       call      qword ptr [765C743AEE68]
       jmp       near ptr M02_L05
       mov       rdi,[rbp-20]
       call      qword ptr [765C743AEE80]
       jmp       near ptr M02_L05
       mov       rdi,[rbp-20]
       mov       rsi,rbx
       mov       edx,1
       call      qword ptr [765C7409C450]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M02_L05
M02_L12:
       mov       edi,eax
       mov       rsi,rbx
       call      qword ptr [765C743AE9B8]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
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
       call      0000765CF1AE6790
       test      eax,eax
       je        short M02_L14
       mov       edi,eax
       mov       rsi,[rbp-28]
       call      qword ptr [765C743AE9B8]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M02_L14:
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
       call      qword ptr [765C733EEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdi,[rbp-90]
       call      qword ptr [rax]
       lea       rdi,[rbp-88]
       call      qword ptr [765C733EEF08]; CORINFO_HELP_JIT_PINVOKE_END
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
       call      qword ptr [765C733EEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdx,[rbp-8C]
       mov       rsi,[rbp-94]
       mov       rdi,[rbp-9C]
       mov       ecx,[rbp-84]
       mov       r8,[rbp-0A4]
       call      qword ptr [rax]
       mov       rbx,rax
       lea       rdi,[rbp-80]
       call      qword ptr [765C733EEF08]; CORINFO_HELP_JIT_PINVOKE_END
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
; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rbx
       sub       rsp,78
       lea       rbp,[rsp+0A0]
       mov       [rbp-30],rsi
       mov       esi,edi
       lea       rdi,[rbp-30]
       mov       [rbp-94],rdi
       mov       [rbp-8C],esi
       lea       rdi,[rbp-88]
       call      qword ptr [765C733EEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdi,[rbp-94]
       mov       esi,[rbp-8C]
       call      qword ptr [rax]
       lea       rdi,[rbp-88]
       call      qword ptr [765C733EEF08]; CORINFO_HELP_JIT_PINVOKE_END
       nop
       add       rsp,78
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 109
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
       jne       short M06_L00
       mov       rdi,rbx
       mov       esi,0FFFFFFFF
       xor       edx,edx
       call      qword ptr [765C743A79F0]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M06_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M06_L03
M06_L01:
       mov       edi,[rbx+34]
       and       edi,1600000
       cmp       edi,1000000
       jne       short M06_L04
M06_L02:
       pop       rbx
       pop       r15
       pop       rbp
       ret
M06_L03:
       mov       rdi,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M06_L01
       mov       rdi,rbx
       call      qword ptr [765C743AED48]
       jmp       short M06_L01
M06_L04:
       test      r15b,2
       jne       short M06_L05
       mov       rdi,rbx
       call      qword ptr [765C743AF030]
M06_L05:
       mov       rdi,rbx
       call      qword ptr [765C743AF498]
       jmp       short M06_L02
; Total bytes of code 125
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.__Canon, System.Private.CoreLib]].VsThreading()
       push      rbp
       push      r15
       push      r14
       push      rbx
       push      rax
       lea       rbp,[rsp+20]
       mov       [rbp-20],rdi
       mov       rbx,rdi
       mov       rdi,[rbx]
       mov       rsi,[rdi+30]
       mov       rsi,[rsi]
       mov       rsi,[rsi+28]
       test      rsi,rsi
       je        short M00_L01
M00_L00:
       mov       rdi,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r14,[rbx+8]
       mov       rdi,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rdi,[r15+8]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      r14,r14
       je        short M00_L02
       lea       rdi,[r15+20]
       mov       rsi,r14
       call      CORINFO_HELP_ASSIGN_REF
       xor       edi,edi
       mov       [r15+10],rdi
       mov       rdi,r15
       xor       esi,esi
       add       rsp,8
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7AE53E7A6850]; Microsoft.VisualStudio.Threading.AsyncLazy`1[[System.__Canon, System.Private.CoreLib]].GetValueAsync(System.Threading.CancellationToken)
M00_L01:
       mov       rsi,7AE53E7F46B0
       call      qword ptr [7AE53DC4F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       short M00_L00
M00_L02:
       mov       rdi,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       edi,164
       mov       rsi,7AE53E7D7CC0
       call      qword ptr [7AE53DC4EF88]
       mov       rsi,rax
       mov       rdi,r15
       call      qword ptr [7AE53E49E1C0]
       mov       rdi,r15
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 205
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.__Canon, System.Private.CoreLib]](System.Threading.Tasks.Task`1<System.__Canon>)
       push      rbx
       mov       rbx,rsi
       mov       edi,[rbx+34]
       and       edi,11000000
       cmp       edi,1000000
       jne       short M01_L01
M01_L00:
       mov       rax,[rbx+38]
       pop       rbx
       ret
M01_L01:
       mov       rdi,rbx
       xor       esi,esi
       call      qword ptr [7AE53E7ADF98]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 40
```
```assembly
; Microsoft.VisualStudio.Threading.AsyncLazy`1[[System.__Canon, System.Private.CoreLib]].GetValueAsync(System.Threading.CancellationToken)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rbx
       sub       rsp,128
       lea       rbp,[rsp+150]
       vxorps    xmm8,xmm8,xmm8
       vmovdqu32 [rbp-0D0],zmm8
       vmovdqu32 [rbp-90],zmm8
       vmovdqa   xmmword ptr [rbp-50],xmm8
       mov       [rbp-30],rdi
       mov       [rbp-0C0],rdi
       mov       [rbp-38],rsi
       mov       rsi,[rdi]
       mov       rax,[rsi+30]
       mov       rax,[rax]
       mov       rax,[rax+18]
       test      rax,rax
       je        near ptr M02_L85
M02_L00:
       mov       rdi,rax
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0C8],rax
       lea       rdi,[rax+8]
       mov       rsi,[rbp-0C0]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-0C0]
       mov       rdi,[rsi+28]
       test      rdi,rdi
       jne       near ptr M02_L86
M02_L01:
       mov       rdi,[rsi+18]
       test      rdi,rdi
       jne       near ptr M02_L87
M02_L02:
       mov       rsi,[rbp-0C0]
       cmp       qword ptr [rsi+28],0
       jne       near ptr M02_L79
       mov       rdi,[rsi+8]
       test      rdi,rdi
       je        near ptr M02_L88
       call      00007AE5BBEE5C00
       test      eax,eax
       jne       near ptr M02_L89
       xor       edi,edi
       mov       rax,[rbp-0C8]
       mov       [rax+10],rdi
       mov       rsi,[rbp-0C0]
       mov       rdi,[rsi+8]
       mov       [rbp-0D0],rdi
       xor       edi,edi
       mov       [rbp-3C],edi
       cmp       qword ptr [rbp-0D0],0
       je        near ptr M02_L49
       mov       rdi,[rbp-0D0]
       call      00007AE5BBEE6020
       test      eax,eax
       je        near ptr M02_L50
M02_L03:
       mov       dword ptr [rbp-3C],1
       mov       rsi,[rbp-0C0]
       cmp       qword ptr [rsi+28],0
       jne       near ptr M02_L56
       cmp       qword ptr [rbp-38],0
       je        short M02_L04
       mov       rdi,[rbp-38]
       cmp       dword ptr [rdi+20],0
       jne       near ptr M02_L51
M02_L04:
       mov       rdi,offset MT_Microsoft.VisualStudio.Threading.InlineResumable
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,[rbp-0C8]
       lea       rdi,[rcx+10]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-0C0]
       mov       rsi,[rsi+20]
       mov       rcx,[rbp-0C8]
       lea       rdi,[rcx+18]
       call      CORINFO_HELP_ASSIGN_REF
       xor       edi,edi
       mov       rsi,[rbp-0C0]
       mov       [rsi+20],rdi
       mov       rdi,[rsi]
       mov       rax,[rdi+30]
       mov       rax,[rax]
       mov       rax,[rax+28]
       test      rax,rax
       je        near ptr M02_L11
M02_L05:
       mov       rdi,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rdi,[rbx+8]
       mov       rsi,[rbp-0C8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset Microsoft.VisualStudio.Threading.AsyncLazy`1+<>c__DisplayClass20_0[[System.__Canon, System.Private.CoreLib]].<GetValueAsync>b__0()
       mov       [rbx+18],rdi
       mov       rsi,[rbp-0C0]
       cmp       byte ptr [rsi+38],0
       jne       near ptr M02_L25
       cmp       qword ptr [rsi+18],0
       jne       near ptr M02_L52
M02_L06:
       mov       rdi,offset MT_Microsoft.VisualStudio.Threading.AsyncLocal<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdi,offset MT_System.Threading.AsyncLocal<System.Object>
       call      CORINFO_HELP_NEWSFAST
       lea       rdi,[r15+8]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-0C0]
       mov       rdi,[rsi]
       mov       rax,[rdi+30]
       mov       rax,[rax]
       mov       rax,[rax+38]
       test      rax,rax
       je        near ptr M02_L12
M02_L07:
       mov       rdi,rax
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r14,[rax]
       mov       r13,[r15+8]
       cmp       qword ptr [r13+8],0
       setne     r12b
       movzx     r12d,r12b
       mov       rdi,7AE5BC2A0D68
       mov       rax,7AE5BCBD0820
       call      rax
       cmp       dword ptr [rax],4
       jle       near ptr M02_L53
       mov       rdi,[rax+8]
       mov       rax,[rdi+20]
       test      rax,rax
       je        near ptr M02_L53
M02_L08:
       mov       [rbp-138],rax
       mov       rcx,[rax+10]
       test      rcx,rcx
       jne       short M02_L09
       call      qword ptr [7AE53E49C048]; System.Threading.Thread.InitializeCurrentThread()
       mov       rcx,rax
M02_L09:
       mov       rcx,[rcx+8]
       mov       [rbp-0D8],rcx
       xor       edi,edi
       mov       [rbp-48],rdi
       xor       r8d,r8d
       test      rcx,rcx
       je        short M02_L10
       mov       rdi,[rcx+8]
       lea       rdx,[rbp-48]
       mov       rsi,r13
       mov       r11,7AE53CC60598
       call      qword ptr [r11]
       mov       [rbp-4C],eax
       mov       rcx,[rbp-0D8]
       mov       r8d,[rbp-4C]
M02_L10:
       cmp       [rbp-48],r14
       je        near ptr M02_L24
       xor       edi,edi
       mov       [rbp-58],rdi
       mov       [rbp-5C],edi
       test      rcx,rcx
       je        short M02_L13
       mov       [rbp-4C],r8d
       movzx     edx,byte ptr [rcx+18]
       mov       [rbp-5C],edx
       test      r12d,r12d
       sete      cl
       movzx     ecx,cl
       mov       r10,[rbp-0D8]
       mov       rdi,[r10+8]
       mov       rsi,r13
       mov       rdx,r14
       mov       r11,7AE53CC60590
       call      qword ptr [r11]
       mov       [rbp-0E0],rax
       mov       rdx,[rbp-0D8]
       mov       rdx,[rdx+10]
       mov       [rbp-58],rdx
       jmp       near ptr M02_L16
M02_L11:
       mov       rsi,7AE53E7F8F30
       call      qword ptr [7AE53DC4F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L05
M02_L12:
       mov       rsi,7AE53E7F9338
       call      qword ptr [7AE53DC4F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L07
M02_L13:
       test      r14,r14
       je        near ptr M02_L54
       mov       [rbp-4C],r8d
M02_L14:
       mov       rdi,offset MT_System.Threading.AsyncLocalValueMap+OneElementAsyncLocalValueMap
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       [rbp-0F8],rsi
       lea       rdi,[rsi+8]
       mov       rsi,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-0F8]
       lea       rdi,[rsi+10]
       mov       rsi,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-0F8]
       mov       rax,rsi
M02_L15:
       mov       [rbp-0E0],rax
M02_L16:
       test      r12d,r12d
       je        short M02_L18
       cmp       dword ptr [rbp-4C],0
       jne       short M02_L18
       cmp       qword ptr [rbp-58],0
       je        short M02_L17
       mov       rdx,[rbp-58]
       mov       ecx,[rdx+8]
       mov       [rbp-60],ecx
       lea       edx,[rcx+1]
       lea       rsi,[rbp-58]
       mov       rdi,7AE53E810D58
       call      qword ptr [7AE53E07C480]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       esi,[rbp-60]
       mov       rdi,[rbp-58]
       mov       rdx,r13
       call      qword ptr [7AE53DC457A0]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M02_L18
M02_L17:
       mov       rdi,offset MT_System.Threading.IAsyncLocal[]
       mov       esi,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rbp-0F0],rax
       lea       rdi,[rax+10]
       mov       rsi,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-0F0]
       mov       [rbp-58],rax
M02_L18:
       mov       rcx,[rbp-138]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       short M02_L19
       call      qword ptr [7AE53E49C048]; System.Threading.Thread.InitializeCurrentThread()
       mov       [rbp-100],rax
       mov       rcx,[rbp-100]
M02_L19:
       cmp       dword ptr [rbp-5C],0
       je        near ptr M02_L44
       mov       [rbp-100],rcx
M02_L20:
       mov       rdi,offset MT_System.Threading.ExecutionContext
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       [rbp-0E8],rsi
       mov       rax,[rbp-58]
       mov       [rbp-108],rax
       lea       rdi,[rsi+8]
       mov       rsi,[rbp-0E0]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-0E8]
       lea       rdi,[rsi+10]
       mov       rsi,[rbp-108]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-0E8]
       mov       edi,[rbp-5C]
       mov       [rsi+18],dil
M02_L21:
       mov       rdi,[rbp-100]
       lea       rdi,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      r12d,r12d
       je        short M02_L24
       mov       rsi,[rbp-48]
       test      rsi,rsi
       jne       near ptr M02_L46
       xor       r12d,r12d
M02_L22:
       test      r14,r14
       je        near ptr M02_L48
       mov       rdi,[r13]
       mov       rdi,[rdi+30]
       mov       rdi,[rdi]
       mov       rdi,[rdi]
       mov       rax,r14
       cmp       [rax],rdi
       je        short M02_L23
       mov       rsi,r14
       call      qword ptr [7AE53DC458C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
M02_L23:
       mov       rcx,[r13+8]
       xor       edi,edi
       mov       [rsp],r12
       mov       [rsp+8],rax
       mov       [rsp+10],dil
       mov       rdi,[rcx+8]
       call      qword ptr [rcx+18]
M02_L24:
       xor       edi,edi
       mov       [rbp-48],rdi
       mov       [rbp-58],rdi
       mov       rsi,[rbp-0C0]
       lea       rdi,[rsi+18]
       mov       rsi,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-0C0]
M02_L25:
       cmp       qword ptr [rsi+10],0
       jne       near ptr M02_L33
       mov       rdi,offset Microsoft.VisualStudio.Threading.AsyncLazy`1+<>c__DisplayClass20_0[[System.__Canon, System.Private.CoreLib]].<GetValueAsync>b__0()
       cmp       [rbx+18],rdi
       jne       near ptr M02_L42
       mov       rbx,[rbx+8]
       cmp       [rbx],ebx
       xor       edi,edi
       mov       [rbp-70],rdi
       mov       [rbp-90],rbx
       mov       dword ptr [rbp-78],0FFFFFFFF
       mov       rdi,[rbx]
       mov       rax,[rdi+30]
       mov       rax,[rax]
       mov       rax,[rax+18]
       test      rax,rax
       je        short M02_L30
       mov       rdi,rax
M02_L26:
       mov       rax,[rdi+18]
       mov       rax,[rax+10]
       test      rax,rax
       je        short M02_L31
       mov       rdi,rax
M02_L27:
       lea       rsi,[rbp-90]
       call      qword ptr [7AE53E7A7B28]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[Microsoft.VisualStudio.Threading.AsyncLazy`1+<>c__DisplayClass20_0+<<GetValueAsync>b__0>d[[System.__Canon, System.Private.CoreLib]], Microsoft.VisualStudio.Threading]](<<GetValueAsync>b__0>d<System.__Canon> ByRef)
       mov       rdi,[rbx]
       mov       rsi,[rdi+30]
       mov       rsi,[rsi]
       mov       rsi,[rsi+10]
       test      rsi,rsi
       je        short M02_L32
M02_L28:
       mov       rax,[rbp-70]
       test      rax,rax
       je        near ptr M02_L41
M02_L29:
       mov       rsi,[rbp-0C0]
       lea       rdi,[rsi+28]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L43
M02_L30:
       mov       rsi,7AE53E7FC1B0
       call      qword ptr [7AE53DC4F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       short M02_L26
M02_L31:
       mov       rsi,7AE53E7FC3A8
       call      qword ptr [7AE53DC4F3A8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       short M02_L27
M02_L32:
       mov       rsi,7AE53E7FC028
       call      qword ptr [7AE53DC4F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       short M02_L28
M02_L33:
       mov       rsi,[rbp-0C0]
       mov       rdi,[rsi]
       mov       rax,[rdi+30]
       mov       rax,[rax]
       mov       rax,[rax+30]
       test      rax,rax
       je        short M02_L34
       jmp       short M02_L35
M02_L34:
       mov       rsi,7AE53E7F8FE0
       call      qword ptr [7AE53DC4F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L35:
       mov       rsi,[rbp-0C0]
       mov       r15,[rsi+10]
       cmp       [r15],r15b
       mov       rdi,[rax+18]
       mov       rdi,[rdi+10]
       test      rdi,rdi
       je        short M02_L36
       mov       rcx,rdi
       jmp       short M02_L37
M02_L36:
       mov       rdi,rax
       mov       rsi,7AE53E887298
       call      qword ptr [7AE53DC4F3A8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M02_L37:
       mov       rdi,r15
       mov       rsi,rcx
       mov       rdx,rbx
       xor       ecx,ecx
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7AE53E875CF8]
       mov       rsi,[rbp-0C0]
       lea       rdi,[rsi+30]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       lock or   dword ptr [rsp],0
       mov       rsi,[rbp-0C0]
       mov       rbx,[rsi+30]
       mov       rdi,[rbx]
       mov       rax,[rdi+30]
       mov       rax,[rax]
       mov       r15,[rax+10]
       test      r15,r15
       je        short M02_L38
       jmp       short M02_L39
M02_L38:
       mov       rsi,7AE53E8874C0
       call      qword ptr [7AE53DC4F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r15,rax
M02_L39:
       mov       rdi,rbx
       call      qword ptr [7AE53E875DD0]
       mov       rsi,rax
       test      rsi,rsi
       je        short M02_L40
       mov       rdi,r15
       cmp       [rsi],rdi
       je        short M02_L40
       mov       rsi,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rsi,rax
M02_L40:
       mov       rbx,[rbp-0C0]
       lea       rdi,[rbx+28]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M02_L43
M02_L41:
       lea       rdi,[rbp-70]
       call      qword ptr [7AE53E875038]
       jmp       near ptr M02_L29
M02_L42:
       mov       rdi,[rbx+8]
       call      qword ptr [rbx+18]
       jmp       near ptr M02_L29
M02_L43:
       call      M02_L100
       jmp       near ptr M02_L56
M02_L44:
       mov       rdi,7AD57CC013B8
       mov       rax,[rbp-0E0]
       cmp       rax,[rdi]
       jne       short M02_L45
       xor       esi,esi
       mov       [rbp-100],rcx
       jmp       near ptr M02_L21
M02_L45:
       mov       [rbp-100],rcx
       jmp       near ptr M02_L20
M02_L46:
       mov       rdi,[r13]
       mov       rdi,[rdi+30]
       mov       rdi,[rdi]
       mov       rdi,[rdi]
       mov       r12,rsi
       cmp       [r12],rdi
       je        short M02_L47
       call      qword ptr [7AE53DC458C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r12,rax
M02_L47:
       jmp       near ptr M02_L22
M02_L48:
       xor       eax,eax
       jmp       near ptr M02_L23
M02_L49:
       xor       edi,edi
       call      qword ptr [7AE53E875188]
       int       3
M02_L50:
       mov       rdi,[rbp-0D0]
       call      qword ptr [7AE53E7AEAC0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M02_L03
M02_L51:
       lea       rdi,[rbp-38]
       call      qword ptr [7AE53E8752C0]
       int       3
M02_L52:
       mov       rdi,7AE53E897718
       call      qword ptr [7AE53E7A6CB8]
       jmp       near ptr M02_L06
M02_L53:
       mov       edi,4
       call      qword ptr [7AE53E874AE0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M02_L08
M02_L54:
       test      r12d,r12d
       jne       short M02_L55
       mov       rdi,7AD57CC013B8
       mov       rsi,[rdi]
       mov       [rbp-4C],r8d
       mov       rax,rsi
       jmp       near ptr M02_L15
M02_L55:
       mov       [rbp-4C],r8d
       jmp       near ptr M02_L14
M02_L56:
       mov       rdi,[rbp-0D0]
       call      00007AE5BBEE6790
       test      eax,eax
       jne       near ptr M02_L90
M02_L57:
       mov       rsi,[rbp-0C8]
       mov       rdi,[rsi+10]
       test      rdi,rdi
       je        near ptr M02_L79
       mov       byte ptr [rdi+18],1
       mov       rbx,[rdi+8]
       xor       eax,eax
       mov       [rdi+8],rax
       mov       r15,[rdi+10]
       mov       rdi,7AE5BC2A0D68
       mov       rax,7AE5BCBD0820
       call      rax
       cmp       dword ptr [rax],4
       jle       near ptr M02_L91
       mov       rdi,[rax+8]
       mov       r13,[rdi+20]
       test      r13,r13
       je        near ptr M02_L91
M02_L58:
       mov       rax,[r13+10]
       test      rax,rax
       jne       short M02_L59
       call      qword ptr [7AE53E49C048]; System.Threading.Thread.InitializeCurrentThread()
M02_L59:
       mov       r14,[rax+10]
       mov       rax,[r13+10]
       test      rax,rax
       jne       short M02_L60
       call      qword ptr [7AE53E49C048]; System.Threading.Thread.InitializeCurrentThread()
M02_L60:
       lea       rdi,[rax+10]
       mov       rsi,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-130],r14
       test      rbx,rbx
       je        near ptr M02_L77
       mov       rdi,offset System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1+AsyncStateMachineBox`1[[System.__Canon, System.Private.CoreLib],[Microsoft.VisualStudio.Threading.AsyncLazy`1+<>c__DisplayClass20_0+<<GetValueAsync>b__0>d[[System.__Canon, System.Private.CoreLib]], Microsoft.VisualStudio.Threading]].MoveNext()
       cmp       [rbx+18],rdi
       jne       near ptr M02_L76
       mov       rbx,[rbx+8]
       mov       rdi,7AD57CC013B0
       mov       rdi,[rdi]
       movzx     r15d,byte ptr [rdi+9D]
       test      r15d,r15d
       jne       near ptr M02_L69
M02_L61:
       mov       r12,[rbx+10]
       test      r12,r12
       je        near ptr M02_L70
       mov       rdi,[rbx]
       mov       rsi,[rdi+30]
       mov       rsi,[rsi+8]
       mov       rsi,[rsi+18]
       test      rsi,rsi
       je        short M02_L65
M02_L62:
       mov       rdi,rsi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rsi,[rax]
       mov       rdi,r12
       mov       rdx,rbx
       call      qword ptr [7AE53E7AC4B0]; System.Threading.ExecutionContext.RunInternal(System.Threading.ExecutionContext, System.Threading.ContextCallback, System.Object)
M02_L63:
       mov       edi,[rbx+34]
       test      edi,1600000
       jne       short M02_L66
M02_L64:
       test      r15d,r15d
       je        near ptr M02_L77
       jmp       near ptr M02_L75
M02_L65:
       mov       rsi,7AE53E7FE870
       call      qword ptr [7AE53DC4F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       short M02_L62
M02_L66:
       cmp       byte ptr [7AE53CC5B06C],0
       jne       near ptr M02_L73
M02_L67:
       xor       edi,edi
       mov       [rbx+40],rdi
       mov       [rbx+48],rdi
       mov       [rbx+50],rdi
       mov       [rbx+58],rdi
       mov       [rbx+60],rdi
       mov       [rbx+68],rdi
       mov       [rbx+10],rdi
       mov       rdi,7AD57CC013B0
       mov       rdi,[rdi]
       movzx     eax,byte ptr [rdi+9D]
       test      eax,eax
       je        short M02_L64
       mov       ecx,[rdi+98]
       mov       rdi,[rdi+80]
       test      eax,eax
       je        short M02_L64
       test      ecx,ecx
       je        short M02_L68
       cmp       ecx,3
       jl        short M02_L64
M02_L68:
       test      rdi,rdi
       je        short M02_L74
       test      edi,100
       je        near ptr M02_L64
       jmp       short M02_L74
M02_L69:
       mov       rdi,rbx
       call      qword ptr [7AE53E7AC480]
       mov       esi,eax
       mov       rdi,7AD57CC013B0
       mov       rdi,[rdi]
       mov       edx,2
       call      qword ptr [7AE53E7AC498]
       jmp       near ptr M02_L61
M02_L70:
       mov       rdi,[rbx]
       mov       rsi,[rdi+30]
       mov       rsi,[rsi+8]
       mov       rax,[rsi+20]
       test      rax,rax
       je        short M02_L71
       jmp       short M02_L72
M02_L71:
       mov       rsi,7AE53E7FE8F8
       call      qword ptr [7AE53DC4F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L72:
       lea       rdi,[rbx+40]
       call      rax
       jmp       near ptr M02_L63
M02_L73:
       mov       rdi,rbx
       call      qword ptr [7AE53E7AD800]
       jmp       near ptr M02_L67
M02_L74:
       mov       rdi,rbx
       call      qword ptr [7AE53E496880]; System.GC.SuppressFinalize(System.Object)
       jmp       near ptr M02_L64
M02_L75:
       mov       rdi,7AD57CC013B0
       mov       rdi,[rdi]
       mov       esi,2
       call      qword ptr [7AE53E7AC4F8]
       jmp       short M02_L77
M02_L76:
       mov       rdi,[rbx+8]
       call      qword ptr [rbx+18]
       nop
M02_L77:
       mov       rax,[r13+10]
       test      rax,rax
       jne       short M02_L78
       call      qword ptr [7AE53E49C048]; System.Threading.Thread.InitializeCurrentThread()
M02_L78:
       lea       rdi,[rax+10]
       mov       rsi,r14
       call      CORINFO_HELP_ASSIGN_REF
M02_L79:
       mov       rsi,[rbp-0C0]
       lock or   dword ptr [rsp],0
       mov       rdi,[rsi+30]
       test      rdi,rdi
       jne       near ptr M02_L92
       xor       eax,eax
M02_L80:
       test      rax,rax
       jne       short M02_L83
       mov       rsi,[rbp-0C0]
       mov       rdi,[rsi]
       mov       rax,[rdi+30]
       mov       rax,[rax]
       mov       rbx,[rax+20]
       test      rbx,rbx
       je        short M02_L84
M02_L81:
       mov       rsi,[rbp-0C0]
       mov       r15,[rsi+28]
       mov       rdi,[rbp-38]
       mov       [rbp-0B8],rdi
       test      r15,r15
       je        near ptr M02_L93
       cmp       qword ptr [rbp-0B8],0
       jne       near ptr M02_L94
M02_L82:
       mov       rax,r15
M02_L83:
       add       rsp,128
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L84:
       mov       rsi,7AE53E7F8E38
       call      qword ptr [7AE53DC4F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rbx,rax
       jmp       short M02_L81
M02_L85:
       mov       rdi,rsi
       mov       rsi,7AE53E7F8400
       call      qword ptr [7AE53DC4F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L00
M02_L86:
       test      dword ptr [rdi+34],1600000
       jne       near ptr M02_L02
       jmp       near ptr M02_L01
M02_L87:
       mov       rdi,[rdi+8]
       cmp       [rdi],edi
       call      qword ptr [7AE53E875DA0]
       test      rax,rax
       je        near ptr M02_L02
       call      qword ptr [7AE53E875DB8]
       mov       rdi,rax
       mov       rdx,7AD57CC01518
       mov       rdx,[rdx]
       mov       rsi,7AE534C0C428
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rdi,rax
       xor       eax,eax
       test      rdi,rdi
       cmove     rdi,rax
       call      qword ptr [7AE53E7A6B98]
       int       3
M02_L88:
       mov       edi,94D
       mov       rsi,7AE53CC54000
       call      qword ptr [7AE53DC4EF88]
       mov       rdi,rax
       call      qword ptr [7AE53E875188]
       int       3
M02_L89:
       call      qword ptr [7AE53E875DB8]
       mov       rdi,rax
       mov       rdx,7AD57CC01518
       mov       rdx,[rdx]
       mov       rsi,7AE534C0C428
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rdi,rax
       xor       eax,eax
       test      rdi,rdi
       cmove     rdi,rax
       call      qword ptr [7AE53E7A6B98]
       int       3
M02_L90:
       mov       edi,eax
       mov       rsi,[rbp-0D0]
       call      qword ptr [7AE53E8751A0]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       near ptr M02_L57
M02_L91:
       mov       edi,4
       call      qword ptr [7AE53E874AE0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r13,rax
       jmp       near ptr M02_L58
M02_L92:
       mov       rdx,[rbp-38]
       xor       esi,esi
       call      qword ptr [7AE53E7A6C88]
       jmp       near ptr M02_L80
M02_L93:
       mov       rdi,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       edi,170F
       mov       rsi,7AE53E7D7CC0
       call      qword ptr [7AE53DC4EF88]
       mov       rsi,rax
       mov       rdi,rbx
       call      qword ptr [7AE53E49E1C0]
       mov       rdi,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L94:
       test      dword ptr [r15+34],1600000
       jne       near ptr M02_L82
       lea       rdi,[rbp-0B8]
       call      qword ptr [7AE53E7ADCF8]
       test      eax,eax
       je        short M02_L97
       mov       rdi,[rbx+18]
       mov       rdi,[rdi+20]
       test      rdi,rdi
       je        short M02_L95
       jmp       short M02_L96
M02_L95:
       mov       rdi,rbx
       mov       rsi,7AE53E823810
       call      qword ptr [7AE53DC4F3A8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdi,rax
M02_L96:
       mov       rsi,[rbp-0B8]
       call      qword ptr [7AE53E7ADC98]
       jmp       near ptr M02_L83
M02_L97:
       mov       rdi,[rbx+18]
       mov       rdi,[rdi+18]
       test      rdi,rdi
       je        short M02_L98
       jmp       short M02_L99
M02_L98:
       mov       rdi,rbx
       mov       rsi,7AE53E823760
       call      qword ptr [7AE53DC4F3A8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdi,rax
M02_L99:
       mov       rsi,r15
       mov       rdx,[rbp-0B8]
       call      qword ptr [7AE53E7ADC50]
       jmp       near ptr M02_L83
M02_L100:
       sub       rsp,18
       mov       rbx,[rbp-0C0]
       mov       rdi,[rbx+18]
       test      rdi,rdi
       je        near ptr M02_L119
       mov       r15,[rdi+8]
       cmp       qword ptr [r15+8],0
       setne     r14b
       movzx     r14d,r14b
       mov       rdi,7AE5BC2A0D68
       mov       rax,7AE5BCBD0820
       call      rax
       cmp       dword ptr [rax],4
       jle       short M02_L101
       mov       rdi,[rax+8]
       mov       rcx,[rdi+20]
       test      rcx,rcx
       jne       short M02_L102
M02_L101:
       mov       edi,4
       call      qword ptr [7AE53E874AE0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rcx,rax
M02_L102:
       mov       r13,rcx
       mov       rax,[r13+10]
       test      rax,rax
       jne       short M02_L103
       call      qword ptr [7AE53E49C048]; System.Threading.Thread.InitializeCurrentThread()
M02_L103:
       mov       r12,[rax+8]
       xor       edi,edi
       mov       [rbp-98],rdi
       xor       eax,eax
       test      r12,r12
       je        short M02_L104
       mov       rdi,[r12+8]
       lea       rdx,[rbp-98]
       mov       rsi,r15
       mov       r11,7AE53CC605B0
       call      qword ptr [r11]
       mov       [rbp-9C],eax
       mov       eax,[rbp-9C]
M02_L104:
       cmp       qword ptr [rbp-98],0
       je        near ptr M02_L118
       xor       edi,edi
       mov       [rbp-0A8],rdi
       mov       [rbp-0AC],edi
       test      r12,r12
       je        short M02_L105
       mov       [rbp-9C],eax
       movzx     ecx,byte ptr [r12+18]
       mov       [rbp-0AC],ecx
       test      r14d,r14d
       sete      cl
       movzx     ecx,cl
       mov       rdi,[r12+8]
       mov       rsi,r15
       mov       r11,7AE53CC605A8
       xor       edx,edx
       call      qword ptr [r11]
       mov       [rbp-110],rax
       mov       rdx,[r12+10]
       mov       [rbp-0A8],rdx
       jmp       short M02_L108
M02_L105:
       test      r14d,r14d
       jne       short M02_L106
       mov       rdi,7AD57CC013B8
       mov       r12,[rdi]
       jmp       short M02_L107
M02_L106:
       mov       [rbp-9C],eax
       mov       rdi,offset MT_System.Threading.AsyncLocalValueMap+OneElementAsyncLocalValueMap
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rsi,r15
       mov       rdi,7AE53E847C50
       xor       edx,edx
       call      qword ptr [7AE53E8750B0]
       mov       [rbp-128],rdx
       lea       rdi,[r12+8]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdi,[r12+10]
       mov       rsi,[rbp-128]
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,[rbp-9C]
M02_L107:
       mov       [rbp-9C],eax
       mov       [rbp-110],r12
M02_L108:
       test      r14d,r14d
       je        short M02_L110
       cmp       dword ptr [rbp-9C],0
       jne       short M02_L110
       cmp       qword ptr [rbp-0A8],0
       jne       short M02_L109
       mov       rdi,offset MT_System.Threading.IAsyncLocal[]
       mov       esi,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r12,rax
       lea       rdi,[r12+10]
       mov       rsi,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-0A8],r12
       jmp       short M02_L110
M02_L109:
       mov       rdx,[rbp-0A8]
       mov       r12d,[rdx+8]
       lea       edx,[r12+1]
       lea       rsi,[rbp-0A8]
       mov       rdi,7AE53E810D58
       call      qword ptr [7AE53E07C480]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       esi,r12d
       mov       rdi,[rbp-0A8]
       mov       rdx,r15
       call      qword ptr [7AE53DC457A0]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M02_L110:
       mov       r13,[r13+10]
       test      r13,r13
       jne       short M02_L111
       call      qword ptr [7AE53E49C048]; System.Threading.Thread.InitializeCurrentThread()
       mov       r13,rax
M02_L111:
       mov       r12d,[rbp-0AC]
       test      r12d,r12d
       jne       short M02_L112
       mov       rdi,7AD57CC013B8
       mov       rax,[rbp-110]
       cmp       rax,[rdi]
       je        short M02_L113
M02_L112:
       mov       rdi,offset MT_System.Threading.ExecutionContext
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       [rbp-118],rsi
       mov       rax,[rbp-0A8]
       mov       [rbp-120],rax
       lea       rdi,[rsi+8]
       mov       rsi,[rbp-110]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-118]
       lea       rdi,[rsi+10]
       mov       rsi,[rbp-120]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-118]
       mov       [rsi+18],r12b
       jmp       short M02_L114
M02_L113:
       xor       esi,esi
M02_L114:
       lea       rdi,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      r14d,r14d
       je        short M02_L118
       mov       rsi,[rbp-98]
       test      rsi,rsi
       je        short M02_L116
       mov       rdi,[r15]
       mov       rdi,[rdi+30]
       mov       rdi,[rdi]
       mov       rdi,[rdi]
       mov       r14,rsi
       cmp       [r14],rdi
       je        short M02_L115
       call      qword ptr [7AE53DC458C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r14,rax
M02_L115:
       jmp       short M02_L117
M02_L116:
       xor       r14d,r14d
M02_L117:
       mov       rax,[r15+8]
       xor       edi,edi
       xor       ecx,ecx
       mov       [rsp],r14
       mov       [rsp+8],rdi
       mov       [rsp+10],cl
       mov       rdi,[rax+8]
       call      qword ptr [rax+18]
M02_L118:
       xor       edi,edi
       mov       [rbp-98],rdi
       mov       [rbp-0A8],rdi
M02_L119:
       add       rsp,18
       ret
       sub       rsp,18
       cmp       dword ptr [rbp-3C],0
       je        short M02_L121
       cmp       qword ptr [rbp-0D0],0
       jne       short M02_L120
       xor       edi,edi
       call      qword ptr [7AE53E875188]
       int       3
M02_L120:
       mov       rdi,[rbp-0D0]
       call      00007AE5BBEE6790
       test      eax,eax
       je        short M02_L121
       mov       edi,eax
       mov       rsi,[rbp-0D0]
       call      qword ptr [7AE53E8751A0]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M02_L121:
       nop
       add       rsp,18
       ret
       sub       rsp,18
       mov       rdi,7AE5BC2A0D68
       mov       rax,7AE5BCBD0820
       call      rax
       cmp       dword ptr [rax],4
       jle       short M02_L122
       mov       rdi,[rax+8]
       mov       r13,[rdi+20]
       test      r13,r13
       jne       short M02_L123
M02_L122:
       mov       edi,4
       call      qword ptr [7AE53E874AE0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r13,rax
M02_L123:
       mov       r14,[r13+10]
       test      r14,r14
       jne       short M02_L124
       call      qword ptr [7AE53E49C048]; System.Threading.Thread.InitializeCurrentThread()
       mov       r14,rax
M02_L124:
       lea       rdi,[r14+10]
       mov       rsi,[rbp-130]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,18
       ret
; Total bytes of code 4252
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
       call      qword ptr [7AE53D7EEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdx,[rbp-8C]
       mov       rsi,[rbp-94]
       mov       rdi,[rbp-9C]
       mov       ecx,[rbp-84]
       mov       r8,[rbp-0A4]
       call      qword ptr [rax]
       mov       rbx,rax
       lea       rdi,[rbp-80]
       call      qword ptr [7AE53D7EEF08]; CORINFO_HELP_JIT_PINVOKE_END
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
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rbp
       push      r15
       push      rbx
       lea       rbp,[rsp+10]
       mov       rbx,rdi
       mov       r15d,esi
       test      dword ptr [rbx+34],1600000
       jne       short M04_L00
       mov       rdi,rbx
       mov       esi,0FFFFFFFF
       xor       edx,edx
       call      qword ptr [7AE53E7ADFB0]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M04_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M04_L03
M04_L01:
       mov       edi,[rbx+34]
       and       edi,1600000
       cmp       edi,1000000
       jne       short M04_L04
M04_L02:
       pop       rbx
       pop       r15
       pop       rbp
       ret
M04_L03:
       mov       rdi,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M04_L01
       mov       rdi,rbx
       call      qword ptr [7AE53E875170]
       jmp       short M04_L01
M04_L04:
       test      r15b,2
       jne       short M04_L05
       mov       rdi,rbx
       call      qword ptr [7AE53E875980]
M04_L05:
       mov       rdi,rbx
       call      qword ptr [7AE53E875E90]
       jmp       short M04_L02
; Total bytes of code 125
```

