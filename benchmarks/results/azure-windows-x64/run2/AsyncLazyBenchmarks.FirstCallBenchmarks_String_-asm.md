## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.__Canon, System.Private.CoreLib]].LazyOfTask()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+28]
       test      rdx,rdx
       je        short M00_L01
M00_L00:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,[rbx+8]
       test      rdx,rdx
       je        short M00_L02
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.LazyHelper
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+10],8
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [rsi+8],0
       je        short M00_L03
       mov       rcx,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF80D095860]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
M00_L01:
       mov       rdx,7FF80D194480
       call      qword ptr [7FF80CDBF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M00_L00
M00_L02:
       mov       ecx,1687
       mov       rdx,7FF80CCF4000
       call      qword ptr [7FF80CDBF210]
       mov       rcx,rax
       call      qword ptr [7FF80D1B5E48]
       int       3
M00_L03:
       mov       rax,[rsi+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 181
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.__Canon, System.Private.CoreLib]](System.Threading.Tasks.Task`1<System.__Canon>)
       push      rbx
       sub       rsp,20
       mov       rbx,rdx
       mov       ecx,[rbx+34]
       and       ecx,11000000
       cmp       ecx,1000000
       jne       short M01_L01
M01_L00:
       mov       rax,[rbx+38]
       add       rsp,20
       pop       rbx
       ret
M01_L01:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF80D1B5E90]
       jmp       short M01_L00
; Total bytes of code 48
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
       call      qword ptr [7FF80D1B5F80]
M02_L02:
       mov       dword ptr [rbp-14],1
       mov       rcx,[rbp+10]
       cmp       [rcx+8],rbx
       jne       short M02_L03
       mov       edx,2
       call      qword ptr [7FF80D095890]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
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
       jmp       qword ptr [7FF80D095860]
M02_L05:
       cmp       eax,8
       ja        short M02_L06
       mov       eax,eax
       lea       rdx,[7FF80CE2AED0]
       mov       edx,[rdx+rax*4]
       lea       r8,[M02_L01]
       add       rdx,r8
       jmp       rdx
M02_L06:
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF80D1B5F98]
       int       3
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80D1B5F20]
       jmp       short M02_L04
       mov       rcx,[rbp+10]
       xor       edx,edx
       call      qword ptr [7FF80D095890]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
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
       mov       rdx,7FF80D198170
       call      qword ptr [7FF80CDBF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L08:
       mov       rcx,[rax+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rax
       mov       rdx,7FF80D198210
       call      qword ptr [7FF80CDBF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M02_L10:
       call      qword ptr [7FF80D1B5EC0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80D1B5F38]
       jmp       near ptr M02_L04
       mov       rcx,[rbp+10]
       mov       rdx,rbx
       call      qword ptr [7FF80D1B5F50]
       jmp       near ptr M02_L04
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80D1B5F68]
       jmp       near ptr M02_L04
       mov       rcx,[rbp+10]
       mov       rdx,rbx
       mov       r8d,1
       call      qword ptr [7FF80D095878]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M02_L04
M02_L11:
       mov       ecx,eax
       mov       rdx,rbx
       call      qword ptr [7FF80D1B5E60]
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
       call      qword ptr [7FF80D1B5E60]
M02_L13:
       nop
       add       rsp,28
       ret
; Total bytes of code 442
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
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.__Canon, System.Private.CoreLib]].LazyOfTask_TaskRun()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+28]
       test      rdx,rdx
       je        short M00_L01
M00_L00:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,[rbx+10]
       test      rdx,rdx
       je        short M00_L02
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.LazyHelper
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+10],8
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [rsi+8],0
       je        short M00_L03
       mov       rcx,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF80D095860]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
M00_L01:
       mov       rdx,7FF80D1A4398
       call      qword ptr [7FF80CDBF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M00_L00
M00_L02:
       mov       ecx,1687
       mov       rdx,7FF80CCF4000
       call      qword ptr [7FF80CDBF210]
       mov       rcx,rax
       call      qword ptr [7FF80D1B7AC8]
       int       3
M00_L03:
       mov       rax,[rsi+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 181
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.__Canon, System.Private.CoreLib]](System.Threading.Tasks.Task`1<System.__Canon>)
       push      rbx
       sub       rsp,20
       mov       rbx,rdx
       mov       ecx,[rbx+34]
       and       ecx,11000000
       cmp       ecx,1000000
       jne       short M01_L01
M01_L00:
       mov       rax,[rbx+38]
       add       rsp,20
       pop       rbx
       ret
M01_L01:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF80D1B4B70]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 48
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
       call      qword ptr [7FF80D1B5E90]; System.Threading.Monitor.Enter_Slowpath(System.Object)
M02_L02:
       mov       dword ptr [rbp-14],1
       mov       rcx,[rbp+10]
       cmp       [rcx+8],rbx
       jne       short M02_L03
       mov       edx,2
       call      qword ptr [7FF80D095890]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
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
       jmp       qword ptr [7FF80D095860]
M02_L05:
       cmp       eax,8
       ja        short M02_L06
       mov       eax,eax
       lea       rdx,[7FF80CE370E0]
       mov       edx,[rdx+rax*4]
       lea       r8,[M02_L01]
       add       rdx,r8
       jmp       rdx
M02_L06:
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF80D1BC0F0]
       int       3
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80D1BC090]
       jmp       short M02_L04
       mov       rcx,[rbp+10]
       xor       edx,edx
       call      qword ptr [7FF80D095890]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
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
       mov       rdx,7FF80D211220
       call      qword ptr [7FF80CDBF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L08:
       mov       rcx,[rax+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rax
       mov       rdx,7FF80D2112C0
       call      qword ptr [7FF80CDBF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M02_L10:
       call      qword ptr [7FF80D1BC030]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80D1BC0A8]
       jmp       near ptr M02_L04
       mov       rcx,[rbp+10]
       mov       rdx,rbx
       call      qword ptr [7FF80D1BC0C0]
       jmp       near ptr M02_L04
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80D1BC0D8]
       jmp       near ptr M02_L04
       mov       rcx,[rbp+10]
       mov       rdx,rbx
       mov       r8d,1
       call      qword ptr [7FF80D095878]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M02_L04
M02_L11:
       mov       ecx,eax
       mov       rdx,rbx
       call      qword ptr [7FF80D1B5EC0]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
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
       call      qword ptr [7FF80D1B5EC0]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M02_L13:
       nop
       add       rsp,28
       ret
; Total bytes of code 442
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
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      dword ptr [rbx+34],1600000
       jne       short M04_L00
       mov       rcx,rbx
       mov       edx,0FFFFFFFF
       xor       r8d,r8d
       call      qword ptr [7FF80D1B4BD0]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M04_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M04_L03
M04_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L04
M04_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M04_L01
       mov       rcx,rbx
       call      qword ptr [7FF80D1BC5B8]
       jmp       short M04_L01
M04_L04:
       test      sil,2
       jne       short M04_L05
       mov       rcx,rbx
       call      qword ptr [7FF80D1BC5D0]
M04_L05:
       mov       rcx,rbx
       call      qword ptr [7FF80D1BCBD0]
       jmp       short M04_L02
; Total bytes of code 124
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.__Canon, System.Private.CoreLib]].AsyncLazy()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+28]
       test      rdx,rdx
       je        short M00_L01
M00_L00:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,[rbx+8]
       test      rdx,rdx
       je        short M00_L02
       lea       rcx,[rsi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsi+10]
       test      rax,rax
       jne       short M00_L03
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF80D12FF48]; System.Threading.Tasks.AsyncLazy`1[[System.__Canon, System.Private.CoreLib]].GetOrStartAttemptAsync(System.Threading.CancellationToken)
M00_L01:
       mov       rdx,7FF80D1A6E38
       call      qword ptr [7FF80CDBF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M00_L00
M00_L02:
       mov       ecx,1
       mov       rdx,7FF80D1972A0
       call      qword ptr [7FF80CDBF210]
       mov       rcx,rax
       call      qword ptr [7FF80D1BC210]
       int       3
M00_L03:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 147
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.__Canon, System.Private.CoreLib]](System.Threading.Tasks.Task`1<System.__Canon>)
       push      rbx
       sub       rsp,20
       mov       rbx,rdx
       mov       ecx,[rbx+34]
       and       ecx,11000000
       cmp       ecx,1000000
       jne       short M01_L01
M01_L00:
       mov       rax,[rbx+38]
       add       rsp,20
       pop       rbx
       ret
M01_L01:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF80D1B4D20]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 48
```
```assembly
; System.Threading.Tasks.AsyncLazy`1[[System.__Canon, System.Private.CoreLib]].GetOrStartAttemptAsync(System.Threading.CancellationToken)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
M02_L00:
       mov       rdi,[rbx+8]
       mov       rbp,[rbx]
       mov       rcx,rbp
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+18]
       test      rax,rax
       je        near ptr M02_L18
       mov       rcx,rax
M02_L01:
       mov       rdx,rdi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M02_L34
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        near ptr M02_L19
M02_L02:
       mov       rax,rcx
       test      rdi,rdi
       jne       near ptr M02_L20
M02_L03:
       lea       rax,[rbx+20]
       cmp       qword ptr [rax],0
       jne       near ptr M02_L33
M02_L04:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        near ptr M02_L22
M02_L05:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,[rdi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        near ptr M02_L23
M02_L06:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       xor       ecx,ecx
       mov       [rax+8],rcx
       mov       [rax+10],rcx
       mov       [rax+18],rcx
       mov       dword ptr [rax+34],2000440
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+8]
       test      rcx,rcx
       je        near ptr M02_L38
       mov       rdx,r14
       xor       r8d,r8d
       call      00007FF86CA021C0
       test      rax,rax
       jne       near ptr M02_L00
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        near ptr M02_L26
M02_L07:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdi,[rax+8]
       test      rdi,rdi
       je        near ptr M02_L39
M02_L08:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r15,[rcx+30]
       test      r15,r15
       je        near ptr M02_L27
M02_L09:
       mov       rcx,gs:[58]
       mov       rcx,[rcx+48]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M02_L47
       mov       rcx,[rcx+240]
       mov       rax,[rcx+20]
       test      rax,rax
       je        near ptr M02_L47
M02_L10:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M02_L11
       call      qword ptr [7FF80D095470]; System.Threading.Thread.InitializeCurrentThread()
M02_L11:
       mov       rbp,[rax+8]
       test      rbp,rbp
       jne       near ptr M02_L48
       mov       rcx,28C4E001338
       mov       rbp,[rcx]
M02_L12:
       test      rbp,rbp
       je        short M02_L13
       cmp       byte ptr [rbp+19],0
       je        near ptr M02_L49
M02_L13:
       mov       rcx,[r15+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M02_L28
M02_L14:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rcx,[r13+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M02_L15:
       mov       rcx,28C4E001348
       mov       rdi,[rcx]
       cmp       byte ptr [rdi+38],0
       jne       near ptr M02_L52
M02_L16:
       mov       rcx,[rdi+8]
       mov       rdx,[rcx+10]
       mov       r8,[rdx+8]
M02_L17:
       mov       ebp,[rdx+0A0]
       mov       eax,ebp
       and       eax,[rdx+18]
       cmp       eax,[r8+8]
       jae       near ptr M02_L55
       shl       rax,4
       lea       r15,[r8+rax+10]
       mov       eax,[r15+8]
       sub       eax,ebp
       jne       near ptr M02_L29
       lea       r10,[rdx+0A0]
       lea       r9d,[rbp+1]
       mov       eax,ebp
       lock cmpxchg [r10],r9d
       cmp       eax,ebp
       jne       short M02_L17
       mov       rcx,r15
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       inc       ebp
       mov       [r15+8],ebp
       jmp       near ptr M02_L30
M02_L18:
       mov       rdx,7FF80D1A8368
       call      qword ptr [7FF80CDBF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L01
M02_L19:
       mov       rcx,rbp
       mov       rdx,7FF80D1A8378
       call      qword ptr [7FF80CDBF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L02
M02_L20:
       cmp       [rdi],rax
       jne       near ptr M02_L03
       mov       rcx,rdi
       call      qword ptr [7FF80D1B4030]
       test      eax,eax
       je        near ptr M02_L25
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,28C25298BD8
       call      qword ptr [7FF80D097D50]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],40
       jle       short M02_L24
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M02_L24
M02_L21:
       mov       rdx,rdi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF80D12FFC0]
M02_L22:
       mov       rdx,7FF80D1AB088
       call      qword ptr [7FF80CDBF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M02_L05
M02_L23:
       mov       rdx,7FF80D1D7780
       call      qword ptr [7FF80CDBF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M02_L06
M02_L24:
       mov       rcx,rbp
       mov       rdx,7FF80D1AACE0
       call      qword ptr [7FF80CDBF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M02_L21
M02_L25:
       mov       rcx,rdi
       mov       rdx,rsi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF80D1B4048]; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.__Canon, System.Private.CoreLib]].WaitAsync(System.Threading.CancellationToken)
M02_L26:
       mov       rcx,rbp
       mov       rdx,7FF80D1A85B8
       call      qword ptr [7FF80CDBF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L07
M02_L27:
       mov       rcx,rbp
       mov       rdx,7FF80D1AAAF0
       call      qword ptr [7FF80CDBF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r15,rax
       jmp       near ptr M02_L09
M02_L28:
       mov       rcx,r15
       mov       rdx,7FF80D1D7AC8
       call      qword ptr [7FF80CDBF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L14
M02_L29:
       test      eax,eax
       jge       near ptr M02_L17
       mov       rdx,r13
       call      qword ptr [7FF80D1BC318]
M02_L30:
       add       rdi,78
       mov       ecx,1
       xchg      ecx,[rdi]
       test      ecx,ecx
       jne       short M02_L31
       mov       rcx,28C4E001370
       mov       rdi,[rcx]
       lea       rcx,[rdi+178]
       lock inc  dword ptr [rcx]
       mov       rcx,rdi
       call      qword ptr [7FF80D1B45B8]; System.Threading.PortableThreadPool+WorkerThread.MaybeAddWorkingWorker(System.Threading.PortableThreadPool)
       cmp       dword ptr [rdi+17C],6
       jne       near ptr M02_L53
M02_L31:
       test      rsi,rsi
       jne       near ptr M02_L54
       mov       rcx,[r14+10]
       mov       rax,[rcx+8]
M02_L32:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L33:
       mov       rax,[rax]
       cmp       dword ptr [rax+20],0
       je        near ptr M02_L04
       jmp       short M02_L35
M02_L34:
       jmp       short M02_L32
M02_L35:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L36
       jmp       short M02_L37
M02_L36:
       mov       rcx,rbp
       mov       rdx,7FF80D1A8148
       call      qword ptr [7FF80CDBF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M02_L37:
       mov       rdx,[rbx+20]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF80D12FEE8]
M02_L38:
       call      qword ptr [7FF80D1BC168]
       int       3
M02_L39:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rdi,[rcx+28]
       test      rdi,rdi
       je        short M02_L40
       jmp       short M02_L41
M02_L40:
       mov       rcx,rbp
       mov       rdx,7FF80D1A85B8
       call      qword ptr [7FF80CDBF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M02_L41:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],38
       jle       short M02_L42
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M02_L42
       jmp       short M02_L43
M02_L42:
       mov       rcx,rbp
       mov       rdx,7FF80D1AABD8
       call      qword ptr [7FF80CDBF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M02_L43:
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       test      rdx,rdx
       jne       short M02_L44
       call      qword ptr [7FF80D1BCB10]
       int       3
M02_L44:
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset System.Threading.Tasks.AsyncLazy`1+<>c[[System.__Canon, System.Private.CoreLib]].<GetOrStartAttemptAsync>b__11_0(Attempt<System.__Canon>)
       mov       [r15+18],rcx
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M02_L45
       jmp       short M02_L46
M02_L45:
       mov       rcx,rbp
       mov       rdx,7FF80D1A85B8
       call      qword ptr [7FF80CDBF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M02_L46:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       lea       rcx,[rax+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,r15
       jmp       near ptr M02_L08
M02_L47:
       mov       ecx,4
       call      qword ptr [7FF80D1B7E58]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M02_L10
M02_L48:
       xor       ecx,ecx
       cmp       byte ptr [rbp+18],0
       cmovne    rbp,rcx
       jmp       near ptr M02_L12
M02_L49:
       mov       rcx,[r15+18]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M02_L50
       jmp       short M02_L51
M02_L50:
       mov       rcx,r15
       mov       rdx,7FF80D1D7C98
       call      qword ptr [7FF80CDBF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M02_L51:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       rdx,rdi
       mov       r8,r14
       mov       r9,rbp
       call      qword ptr [7FF80D1BC2D0]
       jmp       near ptr M02_L15
M02_L52:
       mov       rcx,28C4E001360
       mov       rcx,[rcx]
       cmp       byte ptr [rcx+9D],0
       je        near ptr M02_L16
       mov       rcx,28C4E001360
       mov       rcx,[rcx]
       mov       rdx,r13
       call      qword ptr [7FF80D1BC2E8]
       jmp       near ptr M02_L16
M02_L53:
       mov       rcx,rdi
       call      qword ptr [7FF80D1B47B0]; System.Threading.PortableThreadPool+GateThread.EnsureRunningSlow(System.Threading.PortableThreadPool)
       jmp       near ptr M02_L31
M02_L54:
       mov       rcx,[r14+10]
       mov       rdi,[rcx+8]
       cmp       [rdi],dil
       mov       rcx,offset MT_System.TimeProvider
       call      qword ptr [7FF80CDB5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,28C4E001478
       mov       r8,[r8]
       mov       r9,rsi
       mov       rcx,rdi
       mov       edx,0FFFFFFFF
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF80D1BCB28]
M02_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1599
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
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      dword ptr [rbx+34],1600000
       jne       short M04_L00
       mov       rcx,rbx
       mov       edx,0FFFFFFFF
       xor       r8d,r8d
       call      qword ptr [7FF80D1B4D38]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M04_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M04_L03
M04_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L04
M04_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M04_L01
       mov       rcx,rbx
       call      qword ptr [7FF80D1BC1F8]
       jmp       short M04_L01
M04_L04:
       test      sil,2
       jne       short M04_L05
       mov       rcx,rbx
       call      qword ptr [7FF80D1BC360]
M04_L05:
       mov       rcx,rbx
       call      qword ptr [7FF80D1BCB40]
       jmp       short M04_L02
; Total bytes of code 124
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.__Canon, System.Private.CoreLib]].AsyncLazy_NoHop()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,78
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-50],ymm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+28]
       test      rax,rax
       je        near ptr M00_L20
M00_L00:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       test      rdx,rdx
       je        near ptr M00_L31
       lea       rcx,[rbx+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbx+10]
       test      rax,rax
       jne       near ptr M00_L32
M00_L01:
       mov       rsi,[rbx+8]
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+18]
       test      rax,rax
       je        near ptr M00_L21
       mov       rcx,rax
M00_L02:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L34
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+20]
       test      rax,rax
       je        near ptr M00_L22
       mov       rcx,rax
M00_L03:
       mov       rax,rcx
       test      rsi,rsi
       jne       near ptr M00_L23
M00_L04:
       lea       rax,[rbx+20]
       cmp       qword ptr [rax],0
       jne       near ptr M00_L33
M00_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,[rdi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        near ptr M00_L25
M00_L06:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        near ptr M00_L26
M00_L07:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       xor       ecx,ecx
       mov       [rax+8],rcx
       mov       [rax+10],rcx
       mov       [rax+18],rcx
       mov       dword ptr [rax+34],2000440
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+8]
       test      rcx,rcx
       je        near ptr M00_L38
       mov       rdx,rdi
       xor       r8d,r8d
       call      00007FF86CA021C0
       test      rax,rax
       jne       near ptr M00_L01
       xor       ecx,ecx
       mov       [rbp-38],rcx
       mov       [rbp-58],rdi
       mov       dword ptr [rbp-40],0FFFFFFFF
       mov       rcx,[rdi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+18]
       test      rax,rax
       je        near ptr M00_L29
       mov       rcx,rax
M00_L08:
       mov       rdx,[rcx+18]
       mov       rbx,[rdx+10]
       test      rbx,rbx
       je        near ptr M00_L30
M00_L09:
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M00_L39
       mov       rcx,[rcx+240]
       mov       rax,[rcx+20]
       test      rax,rax
       je        near ptr M00_L39
M00_L10:
       mov       rsi,[rax+10]
       test      rsi,rsi
       jne       short M00_L11
       call      qword ptr [7FF80D095470]; System.Threading.Thread.InitializeCurrentThread()
       mov       rsi,rax
M00_L11:
       mov       [rbp-60],rsi
       mov       rdx,[rsi+8]
       mov       [rbp-68],rdx
       mov       rdx,[rsi+10]
       mov       [rbp-70],rdx
       mov       rcx,[rbx+18]
       mov       rax,[rcx+10]
       test      rax,rax
       je        short M00_L13
M00_L12:
       lea       rcx,[rbp-58]
       call      rax
       jmp       short M00_L14
M00_L13:
       mov       rcx,rbx
       mov       rdx,7FF80D1A92A8
       call      qword ptr [7FF80CDBF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       jmp       short M00_L12
M00_L14:
       mov       rdx,[rbp-70]
       cmp       rdx,[rsi+10]
       je        short M00_L15
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L15:
       mov       rcx,[rsi+8]
       mov       rbx,rcx
       mov       rdx,[rbp-68]
       cmp       rdx,rbx
       je        short M00_L17
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M00_L16
       cmp       qword ptr [rbx+10],0
       jne       near ptr M00_L41
M00_L16:
       cmp       qword ptr [rbp-68],0
       jne       near ptr M00_L40
M00_L17:
       cmp       qword ptr [rbp-38],0
       je        near ptr M00_L42
M00_L18:
       mov       rax,[rdi+10]
       mov       rax,[rax+8]
M00_L19:
       add       rsp,78
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M00_L20:
       mov       rcx,rdx
       mov       rdx,7FF80D1A6D98
       call      qword ptr [7FF80CDBF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M00_L00
M00_L21:
       mov       rdx,7FF80D1A82C8
       call      qword ptr [7FF80CDBF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M00_L02
M00_L22:
       mov       rdx,7FF80D1A82D8
       call      qword ptr [7FF80CDBF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M00_L03
M00_L23:
       cmp       [rsi],rax
       jne       near ptr M00_L04
       mov       rcx,rsi
       call      qword ptr [7FF80D12FFA8]
       test      eax,eax
       je        near ptr M00_L28
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,27BA52A8BD8
       call      qword ptr [7FF80D097D50]
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+28]
       test      rax,rax
       je        short M00_L27
       mov       rcx,rax
M00_L24:
       mov       rdx,rsi
       call      qword ptr [7FF80D12FF60]
       jmp       near ptr M00_L19
M00_L25:
       mov       rdx,7FF80D1A87D8
       call      qword ptr [7FF80CDBF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M00_L06
M00_L26:
       mov       rdx,7FF80D1AFA68
       call      qword ptr [7FF80CDBF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M00_L07
M00_L27:
       mov       rdx,7FF80D1A8440
       call      qword ptr [7FF80CDBF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M00_L24
M00_L28:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF80D12FFC0]; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.__Canon, System.Private.CoreLib]].WaitAsync(System.Threading.CancellationToken)
       jmp       near ptr M00_L19
M00_L29:
       mov       rdx,7FF80D1A8F18
       call      qword ptr [7FF80CDBF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M00_L08
M00_L30:
       mov       rdx,7FF80D1A9100
       call      qword ptr [7FF80CDBF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rbx,rax
       jmp       near ptr M00_L09
M00_L31:
       mov       ecx,1
       mov       rdx,7FF80D197298
       call      qword ptr [7FF80CDBF210]
       mov       rcx,rax
       call      qword ptr [7FF80D1B69B8]
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
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+10]
       test      rax,rax
       je        short M00_L36
       mov       rcx,rax
       jmp       short M00_L37
M00_L36:
       mov       rdx,7FF80D1A80A8
       call      qword ptr [7FF80CDBF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M00_L37:
       mov       rdx,[rbx+20]
       call      qword ptr [7FF80D12FED0]
       jmp       near ptr M00_L19
M00_L38:
       call      qword ptr [7FF80D1B68F8]
       int       3
M00_L39:
       mov       ecx,4
       call      qword ptr [7FF80D1B69D0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L10
M00_L40:
       mov       rdx,[rbp-68]
       cmp       qword ptr [rdx+10],0
       je        near ptr M00_L17
M00_L41:
       mov       rcx,rbx
       mov       rdx,[rbp-68]
       call      qword ptr [7FF80D1B6970]
       jmp       near ptr M00_L17
M00_L42:
       lea       rcx,[rbp-38]
       call      qword ptr [7FF80D1B6988]
       jmp       near ptr M00_L18
       sub       rsp,28
       mov       rdx,[rbp-70]
       mov       rax,[rbp-60]
       cmp       rdx,[rax+10]
       je        short M00_L43
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-60]
M00_L43:
       mov       rdi,[rax+8]
       mov       rdx,[rbp-68]
       cmp       rdx,rdi
       je        short M00_L46
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M00_L44
       cmp       qword ptr [rdi+10],0
       jne       short M00_L45
M00_L44:
       cmp       qword ptr [rbp-68],0
       je        short M00_L46
       mov       rdx,[rbp-68]
       cmp       qword ptr [rdx+10],0
       je        short M00_L46
M00_L45:
       mov       rcx,rdi
       mov       rdx,[rbp-68]
       call      qword ptr [7FF80D1B6970]
M00_L46:
       nop
       add       rsp,28
       ret
; Total bytes of code 1255
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.__Canon, System.Private.CoreLib]](System.Threading.Tasks.Task`1<System.__Canon>)
       push      rbx
       sub       rsp,20
       mov       rbx,rdx
       mov       ecx,[rbx+34]
       and       ecx,11000000
       cmp       ecx,1000000
       jne       short M01_L01
M01_L00:
       mov       rax,[rbx+38]
       add       rsp,20
       pop       rbx
       ret
M01_L01:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF80D1B6820]
       jmp       short M01_L00
; Total bytes of code 48
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
; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       [rbp-9C],rcx
       mov       r8,rdx
       mov       [rbp-0A4],r8
       xor       edx,edx
       mov       [rbp-0AC],rdx
       mov       r9d,0FFFFFFFF
       mov       [rbp-94],r9d
       lea       rcx,[rbp-90]
       call      qword ptr [7FF850609030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rcx,[rbp-9C]
       mov       r8,[rbp-0A4]
       mov       rdx,[rbp-0AC]
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
; Total bytes of code 163
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
; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.__Canon, System.Private.CoreLib]].WaitAsync(System.Threading.CancellationToken)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rdx
       test      rbx,rbx
       jne       short M06_L00
       mov       rax,[rcx+10]
       mov       rax,[rax+8]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L00:
       mov       rcx,[rcx+10]
       mov       rsi,[rcx+8]
       cmp       [rsi],sil
       mov       rcx,offset MT_System.TimeProvider
       call      qword ptr [7FF80CDB5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,27BF4401370
       mov       r8,[r8]
       mov       r9,rbx
       mov       rcx,rsi
       mov       edx,0FFFFFFFF
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF80D1B6C28]
; Total bytes of code 92
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

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.__Canon, System.Private.CoreLib]].AsyncLazy_NoRecursionDetection()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+28]
       test      rdx,rdx
       je        short M00_L01
M00_L00:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,[rbx+8]
       test      rdx,rdx
       je        short M00_L02
       lea       rcx,[rsi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsi+10]
       test      rax,rax
       jne       short M00_L03
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF80D12FF48]; System.Threading.Tasks.AsyncLazy`1[[System.__Canon, System.Private.CoreLib]].GetOrStartAttemptAsync(System.Threading.CancellationToken)
M00_L01:
       mov       rdx,7FF80D1A6E28
       call      qword ptr [7FF80CDBF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M00_L00
M00_L02:
       mov       ecx,1
       mov       rdx,7FF80D1972B0
       call      qword ptr [7FF80CDBF210]
       mov       rcx,rax
       call      qword ptr [7FF80D1B7FA8]
       int       3
M00_L03:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 147
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.__Canon, System.Private.CoreLib]](System.Threading.Tasks.Task`1<System.__Canon>)
       push      rbx
       sub       rsp,20
       mov       rbx,rdx
       mov       ecx,[rbx+34]
       and       ecx,11000000
       cmp       ecx,1000000
       jne       short M01_L01
M01_L00:
       mov       rax,[rbx+38]
       add       rsp,20
       pop       rbx
       ret
M01_L01:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF80D1B4CC0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 48
```
```assembly
; System.Threading.Tasks.AsyncLazy`1[[System.__Canon, System.Private.CoreLib]].GetOrStartAttemptAsync(System.Threading.CancellationToken)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
M02_L00:
       mov       rdi,[rbx+8]
       mov       rbp,[rbx]
       mov       rcx,rbp
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+18]
       test      rax,rax
       je        near ptr M02_L18
       mov       rcx,rax
M02_L01:
       mov       rdx,rdi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M02_L30
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        near ptr M02_L19
M02_L02:
       mov       rax,rcx
       test      rdi,rdi
       jne       near ptr M02_L20
M02_L03:
       lea       rax,[rbx+20]
       cmp       qword ptr [rax],0
       jne       near ptr M02_L29
M02_L04:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        near ptr M02_L21
M02_L05:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,[rdi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        near ptr M02_L22
M02_L06:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       xor       ecx,ecx
       mov       [rax+8],rcx
       mov       [rax+10],rcx
       mov       [rax+18],rcx
       mov       dword ptr [rax+34],2000440
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+8]
       test      rcx,rcx
       je        near ptr M02_L34
       mov       rdx,r14
       xor       r8d,r8d
       call      00007FF86CA021C0
       test      rax,rax
       jne       near ptr M02_L00
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        near ptr M02_L23
M02_L07:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdi,[rax+8]
       test      rdi,rdi
       je        near ptr M02_L35
M02_L08:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r15,[rcx+30]
       test      r15,r15
       je        near ptr M02_L24
M02_L09:
       mov       rcx,gs:[58]
       mov       rcx,[rcx+48]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M02_L43
       mov       rcx,[rcx+240]
       mov       rax,[rcx+20]
       test      rax,rax
       je        near ptr M02_L43
M02_L10:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M02_L11
       call      qword ptr [7FF80D095470]; System.Threading.Thread.InitializeCurrentThread()
M02_L11:
       mov       rbp,[rax+8]
       test      rbp,rbp
       jne       near ptr M02_L44
       mov       rcx,23389401338
       mov       rbp,[rcx]
M02_L12:
       test      rbp,rbp
       je        short M02_L13
       cmp       byte ptr [rbp+19],0
       je        near ptr M02_L45
M02_L13:
       mov       rcx,[r15+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M02_L25
M02_L14:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rcx,[r13+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M02_L15:
       mov       rcx,23389401348
       mov       rdi,[rcx]
       cmp       byte ptr [rdi+38],0
       jne       near ptr M02_L48
M02_L16:
       mov       rcx,[rdi+8]
       mov       rdx,[rcx+10]
       mov       r8,[rdx+8]
M02_L17:
       mov       ebp,[rdx+0A0]
       mov       eax,ebp
       and       eax,[rdx+18]
       cmp       eax,[r8+8]
       jae       near ptr M02_L51
       shl       rax,4
       lea       r15,[r8+rax+10]
       mov       eax,[r15+8]
       sub       eax,ebp
       jne       near ptr M02_L26
       lea       r10,[rdx+0A0]
       lea       r9d,[rbp+1]
       mov       eax,ebp
       lock cmpxchg [r10],r9d
       cmp       eax,ebp
       jne       short M02_L17
       mov       rcx,r15
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       inc       ebp
       mov       [r15+8],ebp
       jmp       near ptr M02_L27
M02_L18:
       mov       rdx,7FF80D1A8358
       call      qword ptr [7FF80CDBF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L01
M02_L19:
       mov       rcx,rbp
       mov       rdx,7FF80D1A8368
       call      qword ptr [7FF80CDBF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L02
M02_L20:
       cmp       [rdi],rax
       jne       near ptr M02_L03
       mov       rcx,rdi
       mov       rdx,rsi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF80D12FFD8]; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.__Canon, System.Private.CoreLib]].WaitAsync(System.Threading.CancellationToken)
M02_L21:
       mov       rdx,7FF80D1AAF70
       call      qword ptr [7FF80CDBF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M02_L05
M02_L22:
       mov       rdx,7FF80D1D6E00
       call      qword ptr [7FF80CDBF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M02_L06
M02_L23:
       mov       rcx,rbp
       mov       rdx,7FF80D1A85A8
       call      qword ptr [7FF80CDBF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L07
M02_L24:
       mov       rcx,rbp
       mov       rdx,7FF80D1AAAE0
       call      qword ptr [7FF80CDBF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r15,rax
       jmp       near ptr M02_L09
M02_L25:
       mov       rcx,r15
       mov       rdx,7FF80D1D7148
       call      qword ptr [7FF80CDBF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L14
M02_L26:
       test      eax,eax
       jge       near ptr M02_L17
       mov       rdx,r13
       call      qword ptr [7FF80D1BC0C0]
M02_L27:
       add       rdi,78
       mov       ecx,1
       xchg      ecx,[rdi]
       test      ecx,ecx
       jne       short M02_L28
       mov       rcx,23389401370
       mov       rdi,[rcx]
       lea       rcx,[rdi+178]
       lock inc  dword ptr [rcx]
       mov       rcx,rdi
       call      qword ptr [7FF80D1B4558]; System.Threading.PortableThreadPool+WorkerThread.MaybeAddWorkingWorker(System.Threading.PortableThreadPool)
       cmp       dword ptr [rdi+17C],6
       jne       near ptr M02_L49
M02_L28:
       test      rsi,rsi
       jne       near ptr M02_L50
       mov       rax,[r14+10]
       mov       rax,[rax+8]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L29:
       mov       rax,[rax]
       cmp       dword ptr [rax+20],0
       je        near ptr M02_L04
       jmp       short M02_L31
M02_L30:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L31:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L32
       jmp       short M02_L33
M02_L32:
       mov       rcx,rbp
       mov       rdx,7FF80D1A8138
       call      qword ptr [7FF80CDBF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M02_L33:
       mov       rdx,[rbx+20]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF80D12FEE8]
M02_L34:
       call      qword ptr [7FF80D1B7F00]
       int       3
M02_L35:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rdi,[rcx+28]
       test      rdi,rdi
       je        short M02_L36
       jmp       short M02_L37
M02_L36:
       mov       rcx,rbp
       mov       rdx,7FF80D1A85A8
       call      qword ptr [7FF80CDBF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M02_L37:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],38
       jle       short M02_L38
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M02_L38
       jmp       short M02_L39
M02_L38:
       mov       rcx,rbp
       mov       rdx,7FF80D1AABC8
       call      qword ptr [7FF80CDBF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M02_L39:
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       test      rdx,rdx
       jne       short M02_L40
       call      qword ptr [7FF80D1BC930]
       int       3
M02_L40:
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset System.Threading.Tasks.AsyncLazy`1+<>c[[System.__Canon, System.Private.CoreLib]].<GetOrStartAttemptAsync>b__11_0(Attempt<System.__Canon>)
       mov       [r15+18],rcx
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M02_L41
       jmp       short M02_L42
M02_L41:
       mov       rcx,rbp
       mov       rdx,7FF80D1A85A8
       call      qword ptr [7FF80CDBF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M02_L42:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       lea       rcx,[rax+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,r15
       jmp       near ptr M02_L08
M02_L43:
       mov       ecx,4
       call      qword ptr [7FF80D1B7CF0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M02_L10
M02_L44:
       xor       ecx,ecx
       cmp       byte ptr [rbp+18],0
       cmovne    rbp,rcx
       jmp       near ptr M02_L12
M02_L45:
       mov       rcx,[r15+18]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M02_L46
       jmp       short M02_L47
M02_L46:
       mov       rcx,r15
       mov       rdx,7FF80D1D7318
       call      qword ptr [7FF80CDBF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M02_L47:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       rdx,rdi
       mov       r8,r14
       mov       r9,rbp
       call      qword ptr [7FF80D1BC078]
       jmp       near ptr M02_L15
M02_L48:
       mov       rcx,23389401360
       mov       rcx,[rcx]
       cmp       byte ptr [rcx+9D],0
       je        near ptr M02_L16
       mov       rcx,23389401360
       mov       rcx,[rcx]
       mov       rdx,r13
       call      qword ptr [7FF80D1BC090]
       jmp       near ptr M02_L16
M02_L49:
       mov       rcx,rdi
       call      qword ptr [7FF80D1B4738]; System.Threading.PortableThreadPool+GateThread.EnsureRunningSlow(System.Threading.PortableThreadPool)
       jmp       near ptr M02_L28
M02_L50:
       mov       rcx,[r14+10]
       mov       rdi,[rcx+8]
       cmp       [rdi],dil
       mov       rcx,offset MT_System.TimeProvider
       call      qword ptr [7FF80CDB5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,23389401458
       mov       r8,[r8]
       mov       r9,rsi
       mov       rcx,rdi
       mov       edx,0FFFFFFFF
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF80D1BC948]
M02_L51:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1488
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
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      dword ptr [rbx+34],1600000
       jne       short M04_L00
       mov       rcx,rbx
       mov       edx,0FFFFFFFF
       xor       r8d,r8d
       call      qword ptr [7FF80D1B4CF0]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M04_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M04_L03
M04_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L04
M04_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M04_L01
       mov       rcx,rbx
       call      qword ptr [7FF80D1B7F30]
       jmp       short M04_L01
M04_L04:
       test      sil,2
       jne       short M04_L05
       mov       rcx,rbx
       call      qword ptr [7FF80D1BC108]
M04_L05:
       mov       rcx,rbx
       call      qword ptr [7FF80D1BC960]
       jmp       short M04_L02
; Total bytes of code 124
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.__Canon, System.Private.CoreLib]].Nito()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rbx,[rax+28]
       test      rbx,rbx
       je        near ptr M00_L09
M00_L00:
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+8]
       test      rsi,rsi
       je        near ptr M00_L13
       mov       rdx,[rbx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        near ptr M00_L10
M00_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        near ptr M00_L11
M00_L02:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset Nito.AsyncEx.AsyncLazy`1+<>c__DisplayClass14_0[[System.__Canon, System.Private.CoreLib]].<RunOnThreadPool>b__0()
       mov       [rsi+18],rcx
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,[rbx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M00_L12
M00_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.LazyHelper
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+10],8
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-30],rdi
       xor       ecx,ecx
       mov       [rbp-24],ecx
       mov       rcx,rdi
       call      00007FF86CA5E120
       test      eax,eax
       je        short M00_L05
M00_L04:
       mov       dword ptr [rbp-24],1
       cmp       qword ptr [rbx+8],0
       je        short M00_L06
       mov       rcx,rbx
       call      qword ptr [7FF80D0A5860]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rsi,rax
       jmp       short M00_L07
M00_L05:
       mov       rcx,rdi
       call      qword ptr [7FF80D1C5F38]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L04
M00_L06:
       mov       rsi,[rbx+18]
M00_L07:
       mov       rcx,rdi
       call      00007FF86CA5E040
       test      eax,eax
       jne       near ptr M00_L14
M00_L08:
       mov       rax,rsi
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M00_L09:
       mov       rcx,rdx
       mov       rdx,7FF80D1A8BA0
       call      qword ptr [7FF80CDCF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rbx,rax
       jmp       near ptr M00_L00
M00_L10:
       mov       rcx,rbx
       mov       rdx,7FF80D1A8FD8
       call      qword ptr [7FF80CDCF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M00_L01
M00_L11:
       mov       rcx,rbx
       mov       rdx,7FF80D1A9000
       call      qword ptr [7FF80CDCF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M00_L02
M00_L12:
       mov       rcx,rbx
       mov       rdx,7FF80D1A8D68
       call      qword ptr [7FF80CDCF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M00_L03
M00_L13:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,10E
       mov       rdx,7FF80D1B6CC8
       call      qword ptr [7FF80CDCF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80D0A75B8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L14:
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FF80D1C77E0]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       near ptr M00_L08
       sub       rsp,28
       cmp       dword ptr [rbp-24],0
       je        short M00_L15
       mov       rcx,[rbp-30]
       call      00007FF86CA5E040
       test      eax,eax
       je        short M00_L15
       mov       ecx,eax
       mov       rdx,[rbp-30]
       call      qword ptr [7FF80D1C77E0]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M00_L15:
       nop
       add       rsp,28
       ret
; Total bytes of code 567
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.__Canon, System.Private.CoreLib]](System.Threading.Tasks.Task`1<System.__Canon>)
       push      rbx
       sub       rsp,20
       mov       rbx,rdx
       mov       ecx,[rbx+34]
       and       ecx,11000000
       cmp       ecx,1000000
       jne       short M01_L01
M01_L00:
       mov       rax,[rbx+38]
       add       rsp,20
       pop       rbx
       ret
M01_L01:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF80D1C4A98]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 48
```
```assembly
; Nito.AsyncEx.AsyncLazy`1+<>c__DisplayClass14_0[[System.__Canon, System.Private.CoreLib]].<RunOnThreadPool>b__0()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M02_L02
M02_L00:
       mov       rsi,[rbx+8]
       mov       rcx,[rdx+18]
       mov       rdi,[rcx+18]
       test      rdi,rdi
       je        short M02_L03
M02_L01:
       test      rsi,rsi
       jne       short M02_L04
       mov       ecx,2E
       call      qword ptr [7FF80CDCFD38]
       int       3
M02_L02:
       mov       rdx,7FF80D1AA1D0
       call      qword ptr [7FF80CDCF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M02_L00
M02_L03:
       mov       rcx,rdx
       mov       rdx,7FF80D1E75B0
       call      qword ptr [7FF80CDCF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       short M02_L01
M02_L04:
       mov       rcx,[rdi+18]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        near ptr M02_L09
M02_L05:
       call      qword ptr [7FF80D13FE88]; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].get_Factory()
       mov       rcx,[rax]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        near ptr M02_L10
M02_L06:
       mov       rcx,29908401340
       mov       rbp,[rcx]
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+10],rcx
       lea       rcx,[r14+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,2008
       mov       [r14+34],ecx
       mov       rcx,gs:[58]
       mov       rcx,[rcx+48]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M02_L32
       mov       rcx,[rcx+240]
       mov       rax,[rcx+20]
       test      rax,rax
       je        near ptr M02_L32
M02_L07:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M02_L08
       call      qword ptr [7FF80D0A5470]; System.Threading.Thread.InitializeCurrentThread()
M02_L08:
       mov       rsi,[rax+8]
       test      rsi,rsi
       jne       short M02_L11
       mov       rcx,29908401350
       mov       rsi,[rcx]
       jmp       short M02_L12
M02_L09:
       mov       rcx,rdi
       mov       rdx,7FF80D1E7750
       call      qword ptr [7FF80CDCF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L05
M02_L10:
       mov       rdx,7FF80D1E79B0
       call      qword ptr [7FF80CDCF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M02_L06
M02_L11:
       xor       ecx,ecx
       cmp       byte ptr [rsi+18],0
       cmovne    rsi,rcx
M02_L12:
       test      rsi,rsi
       je        short M02_L13
       mov       rcx,29908401350
       cmp       rsi,[rcx]
       je        short M02_L14
       mov       rcx,r14
       call      qword ptr [7FF80D1CC2D0]
       lea       rcx,[rax+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M02_L14
M02_L13:
       or        dword ptr [r14+34],20000000
M02_L14:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FF80D1C4030]; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
       mov       rcx,[rdi+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M02_L17
M02_L15:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       movzx     edi,word ptr [r14+34]
       and       edi,4
       test      edi,0FFFFFFBB
       je        short M02_L18
M02_L16:
       mov       ecx,2D
       call      qword ptr [7FF80CDCF348]
       int       3
M02_L17:
       mov       rcx,rdi
       mov       rdx,7FF80D1E77F8
       call      qword ptr [7FF80CDCF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M02_L15
M02_L18:
       test      dil,4
       je        short M02_L20
       mov       rcx,gs:[58]
       mov       rcx,[rcx+48]
       cmp       dword ptr [rcx+238],8
       jle       near ptr M02_L33
       mov       rcx,[rcx+240]
       mov       rax,[rcx+40]
       test      rax,rax
       je        near ptr M02_L33
M02_L19:
       mov       rbp,[rax+10]
       test      rbp,rbp
       je        short M02_L20
       mov       rcx,rsi
       call      qword ptr [7FF80D1CC2D0]
       lea       rcx,[rax+30]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M02_L20:
       xor       ecx,ecx
       mov       [rsi+8],rcx
       mov       [rsi+10],rcx
       mov       [rsi+18],rcx
       test      edi,0FFFFFFA0
       jne       near ptr M02_L16
       mov       ecx,edi
       or        ecx,400
       or        ecx,2000000
       mov       [rsi+34],ecx
       mov       rcx,[rsi+28]
       test      rcx,rcx
       jne       near ptr M02_L34
M02_L21:
       mov       byte ptr [rsi+41],1
       mov       rax,29908401360
       mov       rax,[rax]
       cmp       byte ptr [rax+9D],0
       je        short M02_L23
       cmp       dword ptr [rsi+30],0
       jne       short M02_L22
       call      qword ptr [7FF80D1CC348]
       mov       edx,eax
       lea       rcx,[rsi+30]
       xor       eax,eax
       lock cmpxchg [rcx],edx
M02_L22:
       mov       edx,[rsi+30]
       mov       rcx,29908401360
       mov       rcx,[rcx]
       mov       r8,2A92C9B9A98
       xor       r9d,r9d
       call      qword ptr [7FF80D1CC2E8]
M02_L23:
       cmp       byte ptr [7FF80CD0B074],0
       je        short M02_L24
       mov       rcx,rsi
       call      qword ptr [7FF80D1CC300]
M02_L24:
       test      dword ptr [r14+34],1600000
       jne       short M02_L27
       test      dword ptr [r14+34],1600000
       jne       short M02_L26
       cmp       qword ptr [r14+20],0
       jne       short M02_L25
       lea       rcx,[r14+20]
       test      rcx,rcx
       je        near ptr M02_L39
       mov       rdx,rsi
       xor       r8d,r8d
       call      00007FF86CA021C0
       test      rax,rax
       je        near ptr M02_L30
M02_L25:
       mov       rcx,r14
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF80D1C5F08]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       short M02_L30
M02_L26:
       mov       rcx,rsi
       mov       rdx,r14
       call      qword ptr [7FF80D1D4DD8]; System.Threading.Tasks.UnwrapPromise`1[[System.__Canon, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
       jmp       short M02_L30
M02_L27:
       mov       byte ptr [rsi+40],1
       mov       rcx,r14
       call      qword ptr [7FF80D1C5230]; System.Threading.Tasks.Task.get_Status()
       cmp       eax,5
       jne       near ptr M02_L35
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       rax,[rdx+20]
       test      rax,rax
       je        short M02_L31
       mov       rcx,rax
M02_L28:
       mov       rdx,r14
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M02_L36
       mov       ecx,[rax+34]
       and       ecx,11000000
       cmp       ecx,1000000
       jne       near ptr M02_L38
       mov       rdx,[rax+38]
M02_L29:
       mov       rcx,rsi
       call      qword ptr [7FF80D1C5248]; System.Threading.Tasks.UnwrapPromise`1[[System.__Canon, System.Private.CoreLib]].ProcessInnerTask(System.Threading.Tasks.Task)
M02_L30:
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L31:
       mov       rdx,7FF80D1E66E8
       call      qword ptr [7FF80CDCF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M02_L28
M02_L32:
       mov       ecx,4
       call      qword ptr [7FF80D1C7A68]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M02_L07
M02_L33:
       mov       ecx,8
       call      qword ptr [7FF80D1C7A68]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M02_L19
M02_L34:
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M02_L21
       test      dil,4
       je        near ptr M02_L21
       test      byte ptr [rcx+34],8
       jne       near ptr M02_L21
       call      qword ptr [7FF80D1C7978]
       jmp       near ptr M02_L21
M02_L35:
       add       eax,0FFFFFFFA
       cmp       eax,1
       ja        short M02_L30
       movzx     r8d,byte ptr [rsi+41]
       mov       rcx,rsi
       mov       rdx,r14
       call      qword ptr [7FF80D1C5260]; System.Threading.Tasks.UnwrapPromise`1[[System.__Canon, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       jmp       near ptr M02_L30
M02_L36:
       mov       rcx,r14
       mov       rax,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task>
       cmp       [rcx],rax
       je        short M02_L37
       mov       rdx,r14
       mov       rcx,rax
       call      qword ptr [7FF80CFA4D20]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rcx,rax
M02_L37:
       cmp       [rcx],ecx
       call      qword ptr [7FF80D1C7F48]
       mov       rdx,rax
       jmp       near ptr M02_L29
M02_L38:
       mov       rcx,rax
       mov       edx,1
       call      qword ptr [7FF80D1CD788]
       mov       rdx,rax
       jmp       near ptr M02_L29
M02_L39:
       call      qword ptr [7FF80D1C7960]
       int       3
; Total bytes of code 1155
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
       call      qword ptr [7FF80D1C5F38]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       lea       rdx,[7FF80CE4CBF0]
       mov       edx,[rdx+rax*4]
       lea       r8,[M03_L01]
       add       rdx,r8
       jmp       rdx
M03_L07:
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF80D1CC198]
       int       3
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80D1CC138]
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
       mov       rdx,7FF80D1E6FF8
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
       mov       rdx,7FF80D1E7098
       call      qword ptr [7FF80CDCF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M03_L11:
       call      qword ptr [7FF80D1CC0D8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80D1CC150]
       jmp       near ptr M03_L05
       mov       rcx,[rbp+10]
       mov       rdx,rbx
       call      qword ptr [7FF80D1CC168]
       jmp       near ptr M03_L05
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80D1CC180]
       jmp       near ptr M03_L05
       mov       rcx,[rbp+10]
       mov       rdx,rbx
       mov       r8d,1
       call      qword ptr [7FF80D0A5878]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M03_L05
M03_L12:
       mov       ecx,eax
       mov       rdx,rbx
       call      qword ptr [7FF80D1C77E0]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
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
       call      qword ptr [7FF80D1C77E0]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
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
       jne       short M07_L00
       mov       rcx,rbx
       mov       edx,0FFFFFFFF
       xor       r8d,r8d
       call      qword ptr [7FF80D1C4AB0]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FF80D1CC678]
       jmp       short M07_L01
M07_L04:
       test      sil,2
       jne       short M07_L05
       mov       rcx,rbx
       call      qword ptr [7FF80D1CC690]
M07_L05:
       mov       rcx,rbx
       call      qword ptr [7FF80D1CD908]
       jmp       short M07_L02
; Total bytes of code 124
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.__Canon, System.Private.CoreLib]].Nito_ExecuteOnCallingThread()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rbx,[rax+28]
       test      rbx,rbx
       je        near ptr M00_L07
M00_L00:
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+8]
       test      rsi,rsi
       je        near ptr M00_L09
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,[rbx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M00_L08
M00_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.LazyHelper
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+10],8
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-30],rdi
       xor       ecx,ecx
       mov       [rbp-24],ecx
       mov       rcx,rdi
       call      00007FF86CA5E120
       test      eax,eax
       je        short M00_L03
M00_L02:
       mov       dword ptr [rbp-24],1
       cmp       qword ptr [rbx+8],0
       je        short M00_L04
       mov       rcx,rbx
       call      qword ptr [7FF80D0A5860]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rsi,rax
       jmp       short M00_L05
M00_L03:
       mov       rcx,rdi
       call      qword ptr [7FF80D1C5F38]
       jmp       short M00_L02
M00_L04:
       mov       rsi,[rbx+18]
M00_L05:
       mov       rcx,rdi
       call      00007FF86CA5E040
       test      eax,eax
       jne       near ptr M00_L10
M00_L06:
       mov       rax,rsi
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M00_L07:
       mov       rcx,rdx
       mov       rdx,7FF80D1A8BA0
       call      qword ptr [7FF80CDCF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rbx,rax
       jmp       near ptr M00_L00
M00_L08:
       mov       rcx,rbx
       mov       rdx,7FF80D1A8D68
       call      qword ptr [7FF80CDCF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M00_L01
M00_L09:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,10E
       mov       rdx,7FF80D1B6CC8
       call      qword ptr [7FF80CDCF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80D0A75B8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L10:
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FF80D1C5E30]
       jmp       near ptr M00_L06
       sub       rsp,28
       cmp       dword ptr [rbp-24],0
       je        short M00_L11
       mov       rcx,[rbp-30]
       call      00007FF86CA5E040
       test      eax,eax
       je        short M00_L11
       mov       ecx,eax
       mov       rdx,[rbp-30]
       call      qword ptr [7FF80D1C5E30]
M00_L11:
       nop
       add       rsp,28
       ret
; Total bytes of code 416
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.__Canon, System.Private.CoreLib]](System.Threading.Tasks.Task`1<System.__Canon>)
       push      rbx
       sub       rsp,20
       mov       rbx,rdx
       mov       ecx,[rbx+34]
       and       ecx,11000000
       cmp       ecx,1000000
       jne       short M01_L01
M01_L00:
       mov       rax,[rbx+38]
       add       rsp,20
       pop       rbx
       ret
M01_L01:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF80D1C5EF0]
       jmp       short M01_L00
; Total bytes of code 48
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
       call      qword ptr [7FF80D1C5F38]
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
       lea       rdx,[7FF80CE3B910]
       mov       edx,[rdx+rax*4]
       lea       r8,[M02_L01]
       add       rdx,r8
       jmp       rdx
M02_L07:
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF80D1C6010]
       int       3
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80D1C5FB0]
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
       mov       rdx,7FF80D1ADDD8
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
       mov       rdx,7FF80D1ADE78
       call      qword ptr [7FF80CDCF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M02_L11:
       call      qword ptr [7FF80D1C5F50]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80D1C5FC8]
       jmp       near ptr M02_L05
       mov       rcx,[rbp+10]
       mov       rdx,rbx
       call      qword ptr [7FF80D1C5FE0]
       jmp       near ptr M02_L05
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80D1C5FF8]
       jmp       near ptr M02_L05
       mov       rcx,[rbp+10]
       mov       rdx,rbx
       mov       r8d,1
       call      qword ptr [7FF80D0A5878]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M02_L05
M02_L12:
       mov       ecx,eax
       mov       rdx,rbx
       call      qword ptr [7FF80D1C5E30]
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
       call      qword ptr [7FF80D1C5E30]
M02_L14:
       nop
       add       rsp,28
       ret
; Total bytes of code 445
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
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.__Canon, System.Private.CoreLib]].VsThreading()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+28]
       test      rdx,rdx
       je        short M00_L01
M00_L00:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,[rbx+8]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M00_L02
       lea       rcx,[rsi+20]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+10],rcx
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF80D13FF48]; Microsoft.VisualStudio.Threading.AsyncLazy`1[[System.__Canon, System.Private.CoreLib]].GetValueAsync(System.Threading.CancellationToken)
M00_L01:
       mov       rdx,7FF80D1D46E8
       call      qword ptr [7FF80CDCF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M00_L00
M00_L02:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,164
       mov       rdx,7FF80D1A72B8
       call      qword ptr [7FF80CDCF210]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF80D0A75B8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 198
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.__Canon, System.Private.CoreLib]](System.Threading.Tasks.Task`1<System.__Canon>)
       push      rbx
       sub       rsp,20
       mov       rbx,rdx
       mov       ecx,[rbx+34]
       and       ecx,11000000
       cmp       ecx,1000000
       jne       short M01_L01
M01_L00:
       mov       rax,[rbx+38]
       add       rsp,20
       pop       rbx
       ret
M01_L01:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF80D1EC4B0]
       jmp       short M01_L00
; Total bytes of code 48
```
```assembly
; Microsoft.VisualStudio.Threading.AsyncLazy`1[[System.__Canon, System.Private.CoreLib]].GetValueAsync(System.Threading.CancellationToken)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,128
       lea       rbp,[rsp+160]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu32 [rbp-0F0],zmm4
       vmovdqu32 [rbp-0B0],zmm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       xor       eax,eax
       mov       [rbp-50],rax
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       rsi,rcx
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        near ptr M02_L83
M02_L00:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0E8],rax
       lea       rcx,[rax+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+28]
       test      rcx,rcx
       jne       near ptr M02_L84
M02_L01:
       mov       rcx,[rsi+18]
       test      rcx,rcx
       jne       near ptr M02_L85
M02_L02:
       cmp       qword ptr [rsi+28],0
       jne       near ptr M02_L77
       mov       rcx,[rsi+8]
       test      rcx,rcx
       je        near ptr M02_L86
       call      00007FF86CA5DFD0
       test      eax,eax
       jne       near ptr M02_L87
       xor       ecx,ecx
       mov       rax,[rbp-0E8]
       mov       [rax+10],rcx
       mov       rdx,[rsi+8]
       mov       [rbp-0F0],rdx
       mov       [rbp-44],ecx
       cmp       qword ptr [rbp-0F0],0
       je        near ptr M02_L48
       mov       rcx,[rbp-0F0]
       call      00007FF86CA5E120
       test      eax,eax
       je        near ptr M02_L49
M02_L03:
       mov       dword ptr [rbp-44],1
       cmp       qword ptr [rsi+28],0
       jne       near ptr M02_L55
       cmp       qword ptr [rbp+18],0
       je        short M02_L04
       mov       rcx,[rbp+18]
       cmp       dword ptr [rcx+20],0
       jne       near ptr M02_L50
M02_L04:
       mov       rcx,offset MT_Microsoft.VisualStudio.Threading.InlineResumable
       call      CORINFO_HELP_NEWSFAST
       mov       r8,[rbp-0E8]
       lea       rcx,[r8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+20]
       mov       r8,[rbp-0E8]
       lea       rcx,[r8+18]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+20],rcx
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+28]
       test      rdx,rdx
       je        near ptr M02_L11
M02_L05:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,[rbp-0E8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset Microsoft.VisualStudio.Threading.AsyncLazy`1+<>c__DisplayClass20_0[[System.__Canon, System.Private.CoreLib]].<GetValueAsync>b__0()
       mov       [rdi+18],rcx
       cmp       byte ptr [rsi+38],0
       jne       near ptr M02_L25
       cmp       qword ptr [rsi+18],0
       jne       near ptr M02_L51
M02_L06:
       mov       rcx,offset MT_Microsoft.VisualStudio.Threading.AsyncLocal<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,offset MT_System.Threading.AsyncLocal<System.Object>
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+38]
       test      rdx,rdx
       je        near ptr M02_L12
M02_L07:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r14,[rax]
       mov       r15,[rbx+8]
       cmp       qword ptr [r15+8],0
       setne     r13b
       movzx     r13d,r13b
       mov       rcx,gs:[58]
       mov       rcx,[rcx+48]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M02_L52
       mov       rcx,[rcx+240]
       mov       r12,[rcx+20]
       test      r12,r12
       je        near ptr M02_L52
M02_L08:
       mov       rax,[r12+10]
       test      rax,rax
       jne       short M02_L09
       call      qword ptr [7FF80D0A5470]; System.Threading.Thread.InitializeCurrentThread()
M02_L09:
       mov       rax,[rax+8]
       mov       [rbp-0F8],rax
       xor       ecx,ecx
       mov       [rbp-50],rcx
       xor       r10d,r10d
       test      rax,rax
       je        short M02_L10
       mov       rcx,[rax+8]
       lea       r8,[rbp-50]
       mov       rdx,r15
       mov       r11,7FF80CD10568
       call      qword ptr [r11]
       mov       [rbp-54],eax
       mov       rax,[rbp-0F8]
       mov       r10d,[rbp-54]
M02_L10:
       cmp       [rbp-50],r14
       je        near ptr M02_L24
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       [rbp-64],ecx
       test      rax,rax
       je        short M02_L13
       mov       [rbp-54],r10d
       movzx     edx,byte ptr [rax+18]
       mov       [rbp-64],edx
       test      r13d,r13d
       sete      r9b
       movzx     r9d,r9b
       mov       rcx,[rax+8]
       mov       rdx,r15
       mov       r8,r14
       mov       r11,7FF80CD10560
       call      qword ptr [r11]
       mov       [rbp-100],rax
       mov       r8,[rbp-0F8]
       mov       r8,[r8+10]
       mov       [rbp-60],r8
       jmp       near ptr M02_L16
M02_L11:
       mov       rdx,7FF80D1D9FE0
       call      qword ptr [7FF80CDCF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M02_L05
M02_L12:
       mov       rdx,7FF80D1DA3F8
       call      qword ptr [7FF80CDCF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M02_L07
M02_L13:
       test      r14,r14
       je        near ptr M02_L53
       mov       [rbp-54],r10d
M02_L14:
       mov       rcx,offset MT_System.Threading.AsyncLocalValueMap+OneElementAsyncLocalValueMap
       call      CORINFO_HELP_NEWSFAST
       mov       r8,rax
       mov       [rbp-118],r8
       lea       rcx,[r8+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-118]
       lea       rcx,[r8+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-118]
       mov       rax,r8
M02_L15:
       mov       [rbp-100],rax
M02_L16:
       test      r13d,r13d
       je        short M02_L18
       cmp       dword ptr [rbp-54],0
       jne       short M02_L18
       cmp       qword ptr [rbp-60],0
       je        short M02_L17
       mov       r8,[rbp-60]
       mov       r10d,[r8+8]
       mov       [rbp-68],r10d
       lea       r8d,[r10+1]
       lea       rdx,[rbp-60]
       mov       rcx,7FF80D2022B0
       call      qword ptr [7FF80CFAC5D0]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       edx,[rbp-68]
       mov       rcx,[rbp-60]
       mov       r8,r15
       call      qword ptr [7FF80CDC57B8]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M02_L18
M02_L17:
       mov       rcx,offset MT_System.Threading.IAsyncLocal[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rbp-110],rax
       lea       rcx,[rax+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-110]
       mov       [rbp-60],rax
M02_L18:
       mov       r12,[r12+10]
       test      r12,r12
       jne       short M02_L19
       call      qword ptr [7FF80D0A5470]; System.Threading.Thread.InitializeCurrentThread()
       mov       r12,rax
M02_L19:
       cmp       dword ptr [rbp-64],0
       jne       short M02_L20
       mov       rcx,1DC54C01360
       mov       rax,[rbp-100]
       cmp       rax,[rcx]
       jne       short M02_L20
       xor       edx,edx
       jmp       short M02_L21
M02_L20:
       mov       rcx,offset MT_System.Threading.ExecutionContext
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       [rbp-108],rdx
       mov       rax,[rbp-60]
       mov       [rbp-120],rax
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-100]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-108]
       lea       rcx,[rdx+10]
       mov       rdx,[rbp-120]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-108]
       mov       ecx,[rbp-64]
       mov       [rdx+18],cl
M02_L21:
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      r13d,r13d
       je        short M02_L24
       mov       rdx,[rbp-50]
       test      rdx,rdx
       jne       near ptr M02_L45
       xor       r13d,r13d
M02_L22:
       test      r14,r14
       je        near ptr M02_L47
       mov       rcx,[r15]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       r12,r14
       cmp       [r12],rcx
       je        short M02_L23
       mov       rdx,r14
       call      qword ptr [7FF80CDC58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r12,rax
M02_L23:
       mov       rax,[r15+8]
       mov       [rbp-0E0],r13
       mov       [rbp-0D8],r12
       mov       byte ptr [rbp-0D0],0
       lea       rdx,[rbp-0E0]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
M02_L24:
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       [rbp-60],rcx
       lea       rcx,[rsi+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       nop
M02_L25:
       cmp       qword ptr [rsi+10],0
       jne       near ptr M02_L33
       mov       rcx,offset Microsoft.VisualStudio.Threading.AsyncLazy`1+<>c__DisplayClass20_0[[System.__Canon, System.Private.CoreLib]].<GetValueAsync>b__0()
       cmp       [rdi+18],rcx
       jne       near ptr M02_L43
       mov       rdi,[rdi+8]
       cmp       [rdi],edi
       xor       ecx,ecx
       mov       [rbp-78],rcx
       mov       [rbp-98],rdi
       mov       dword ptr [rbp-80],0FFFFFFFF
       mov       rcx,[rdi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M02_L30
       mov       rcx,rax
M02_L26:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+10]
       test      rax,rax
       je        short M02_L31
       mov       rcx,rax
M02_L27:
       lea       rdx,[rbp-98]
       call      qword ptr [7FF80D1E5440]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[Microsoft.VisualStudio.Threading.AsyncLazy`1+<>c__DisplayClass20_0+<<GetValueAsync>b__0>d[[System.__Canon, System.Private.CoreLib]], Microsoft.VisualStudio.Threading]](<<GetValueAsync>b__0>d<System.__Canon> ByRef)
       mov       rcx,[rdi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M02_L32
M02_L28:
       mov       rax,[rbp-78]
       test      rax,rax
       je        near ptr M02_L42
M02_L29:
       lea       rcx,[rsi+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L44
M02_L30:
       mov       rdx,7FF80D1DD618
       call      qword ptr [7FF80CDCF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M02_L26
M02_L31:
       mov       rdx,7FF80D1DD820
       call      qword ptr [7FF80CDCF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M02_L27
M02_L32:
       mov       rdx,7FF80D1DD498
       call      qword ptr [7FF80CDCF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M02_L28
M02_L33:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+30]
       test      rdx,rdx
       je        near ptr M02_L38
M02_L34:
       mov       rbx,[rsi+10]
       cmp       [rbx],bl
       mov       rcx,[rdx+18]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M02_L39
       mov       rdx,rcx
M02_L35:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       [rsp+28],ecx
       mov       rcx,rbx
       mov       r8,rdi
       xor       r9d,r9d
       call      qword ptr [7FF80D1ECAC8]
       lea       rcx,[rsi+30]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lock or   dword ptr [rsp],0
       mov       rdi,[rsi+30]
       mov       rcx,[rdi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rbx,[rdx+10]
       test      rbx,rbx
       je        short M02_L40
M02_L36:
       mov       rcx,rdi
       call      qword ptr [7FF80D1ECB88]
       mov       rdx,rax
       test      rdx,rdx
       je        short M02_L37
       mov       rcx,rbx
       cmp       [rdx],rcx
       jne       short M02_L41
M02_L37:
       lea       rcx,[rsi+28]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M02_L44
M02_L38:
       mov       rdx,7FF80D1DA090
       call      qword ptr [7FF80CDCF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M02_L34
M02_L39:
       mov       rcx,rdx
       mov       rdx,7FF80D21A408
       call      qword ptr [7FF80CDCF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M02_L35
M02_L40:
       mov       rdx,7FF80D21A4A0
       call      qword ptr [7FF80CDCF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rbx,rax
       jmp       short M02_L36
M02_L41:
       mov       rdx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rdx,rax
       jmp       short M02_L37
M02_L42:
       lea       rcx,[rbp-78]
       call      qword ptr [7FF80D1EC7C8]
       jmp       near ptr M02_L29
M02_L43:
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       jmp       near ptr M02_L29
M02_L44:
       call      M02_L98
       jmp       near ptr M02_L55
M02_L45:
       mov       rcx,[r15]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       r13,rdx
       cmp       [r13],rcx
       je        short M02_L46
       call      qword ptr [7FF80CDC58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r13,rax
M02_L46:
       jmp       near ptr M02_L22
M02_L47:
       xor       r12d,r12d
       jmp       near ptr M02_L23
M02_L48:
       xor       ecx,ecx
       call      qword ptr [7FF80D1EC750]
       int       3
M02_L49:
       mov       rcx,[rbp-0F0]
       call      qword ptr [7FF80D1EC780]
       jmp       near ptr M02_L03
M02_L50:
       lea       rcx,[rbp+18]
       call      qword ptr [7FF80D1EC798]
       int       3
M02_L51:
       mov       rcx,7FF80D22EB00
       call      qword ptr [7FF80D1E42E8]
       jmp       near ptr M02_L06
M02_L52:
       mov       ecx,4
       call      qword ptr [7FF80D1EC5B8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r12,rax
       jmp       near ptr M02_L08
M02_L53:
       test      r13d,r13d
       jne       short M02_L54
       mov       rcx,1DC54C01360
       mov       r8,[rcx]
       mov       [rbp-54],r10d
       mov       rax,r8
       jmp       near ptr M02_L15
M02_L54:
       mov       [rbp-54],r10d
       jmp       near ptr M02_L14
M02_L55:
       mov       rcx,[rbp-0F0]
       call      00007FF86CA5E040
       test      eax,eax
       jne       near ptr M02_L88
M02_L56:
       mov       rdx,[rbp-0E8]
       mov       rcx,[rdx+10]
       test      rcx,rcx
       je        near ptr M02_L77
       mov       byte ptr [rcx+18],1
       mov       rbx,[rcx+8]
       xor       eax,eax
       mov       [rcx+8],rax
       mov       rsi,[rcx+10]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+48]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M02_L89
       mov       rcx,[rcx+240]
       mov       r12,[rcx+20]
       test      r12,r12
       je        near ptr M02_L89
M02_L57:
       mov       rax,[r12+10]
       test      rax,rax
       jne       short M02_L58
       call      qword ptr [7FF80D0A5470]; System.Threading.Thread.InitializeCurrentThread()
M02_L58:
       mov       rdi,[rax+10]
       mov       rax,[r12+10]
       test      rax,rax
       jne       short M02_L59
       call      qword ptr [7FF80D0A5470]; System.Threading.Thread.InitializeCurrentThread()
M02_L59:
       lea       rcx,[rax+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-130],rdi
       test      rbx,rbx
       je        near ptr M02_L75
       mov       rcx,offset System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1+AsyncStateMachineBox`1[[System.__Canon, System.Private.CoreLib],[Microsoft.VisualStudio.Threading.AsyncLazy`1+<>c__DisplayClass20_0+<<GetValueAsync>b__0>d[[System.__Canon, System.Private.CoreLib]], Microsoft.VisualStudio.Threading]].MoveNext()
       cmp       [rbx+18],rcx
       jne       near ptr M02_L74
       mov       rbx,[rbx+8]
       mov       rcx,1DC54C01358
       mov       rsi,[rcx]
       movzx     r14d,byte ptr [rsi+9D]
       test      r14d,r14d
       jne       near ptr M02_L67
M02_L60:
       mov       r15,[rbx+10]
       test      r15,r15
       je        near ptr M02_L68
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        near ptr M02_L66
M02_L61:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       mov       rcx,r15
       mov       r8,rbx
       call      qword ptr [7FF80D1E5D58]; System.Threading.ExecutionContext.RunInternal(System.Threading.ExecutionContext, System.Threading.ContextCallback, System.Object)
M02_L62:
       mov       ecx,[rbx+34]
       test      ecx,1600000
       je        short M02_L65
       cmp       byte ptr [7FF80CD0B074],0
       jne       near ptr M02_L71
M02_L63:
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
       je        short M02_L65
       movzx     eax,byte ptr [rcx+9D]
       mov       edx,[rcx+98]
       mov       rcx,[rcx+80]
       test      eax,eax
       je        short M02_L65
       test      edx,edx
       je        short M02_L64
       cmp       edx,3
       jl        short M02_L65
M02_L64:
       test      rcx,rcx
       je        near ptr M02_L72
       test      ecx,100
       jne       near ptr M02_L72
M02_L65:
       test      r14d,r14d
       je        near ptr M02_L75
       jmp       near ptr M02_L73
M02_L66:
       mov       rdx,7FF80D1DFDB8
       call      qword ptr [7FF80CDCF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M02_L61
M02_L67:
       mov       rcx,rbx
       call      qword ptr [7FF80D1E5D28]
       mov       edx,eax
       mov       rcx,rsi
       mov       r8d,2
       call      qword ptr [7FF80D1E5D40]
       jmp       near ptr M02_L60
M02_L68:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       rax,[rdx+20]
       test      rax,rax
       je        short M02_L69
       jmp       short M02_L70
M02_L69:
       mov       rdx,7FF80D1DFE28
       call      qword ptr [7FF80CDCF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L70:
       lea       rcx,[rbx+40]
       call      rax
       jmp       near ptr M02_L62
M02_L71:
       mov       rcx,rbx
       call      qword ptr [7FF80D1E5FF8]
       jmp       near ptr M02_L63
M02_L72:
       mov       rcx,rbx
       call      qword ptr [7FF80D0A5608]; System.GC.SuppressFinalize(System.Object)
       jmp       near ptr M02_L65
M02_L73:
       mov       rcx,rsi
       mov       edx,2
       call      qword ptr [7FF80D1E5DA0]
       jmp       short M02_L75
M02_L74:
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       nop
M02_L75:
       mov       rax,[r12+10]
       test      rax,rax
       jne       short M02_L76
       call      qword ptr [7FF80D0A5470]; System.Threading.Thread.InitializeCurrentThread()
M02_L76:
       lea       rcx,[rax+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M02_L77:
       mov       rsi,[rbp+10]
       lock or   dword ptr [rsp],0
       mov       rcx,[rsi+30]
       test      rcx,rcx
       jne       near ptr M02_L90
       xor       eax,eax
M02_L78:
       test      rax,rax
       jne       short M02_L81
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rbx,[rdx+20]
       test      rbx,rbx
       je        short M02_L82
M02_L79:
       mov       rdi,[rsi+28]
       mov       rcx,[rbp+18]
       mov       [rbp-0C8],rcx
       test      rdi,rdi
       je        near ptr M02_L91
       cmp       qword ptr [rbp-0C8],0
       jne       near ptr M02_L92
M02_L80:
       mov       rax,rdi
M02_L81:
       add       rsp,128
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L82:
       mov       rdx,7FF80D1D8F48
       call      qword ptr [7FF80CDCF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rbx,rax
       jmp       short M02_L79
M02_L83:
       mov       rdx,7FF80D1D84C8
       call      qword ptr [7FF80CDCF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M02_L00
M02_L84:
       test      dword ptr [rcx+34],1600000
       jne       near ptr M02_L02
       jmp       near ptr M02_L01
M02_L85:
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF80D1ECB58]
       test      rax,rax
       je        near ptr M02_L02
       call      qword ptr [7FF80D1ECB70]
       mov       rcx,rax
       mov       r8,1DC54C013C8
       mov       r8,[r8]
       mov       rdx,1DC25399448
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rcx,rax
       xor       eax,eax
       test      rcx,rcx
       cmove     rcx,rax
       call      qword ptr [7FF80D1E41C8]
       int       3
M02_L86:
       mov       ecx,707
       mov       rdx,7FF80CD04000
       call      qword ptr [7FF80CDCF210]
       mov       rcx,rax
       call      qword ptr [7FF80D1EC750]
       int       3
M02_L87:
       call      qword ptr [7FF80D1ECB70]
       mov       rcx,rax
       mov       r8,1DC54C013C8
       mov       r8,[r8]
       mov       rdx,1DC25399448
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rcx,rax
       xor       eax,eax
       test      rcx,rcx
       cmove     rcx,rax
       call      qword ptr [7FF80D1E41C8]
       int       3
M02_L88:
       mov       ecx,eax
       mov       rdx,[rbp-0F0]
       call      qword ptr [7FF80D1EC7F8]
       jmp       near ptr M02_L56
M02_L89:
       mov       ecx,4
       call      qword ptr [7FF80D1EC5B8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r12,rax
       jmp       near ptr M02_L57
M02_L90:
       mov       r8,[rbp+18]
       xor       edx,edx
       call      qword ptr [7FF80D1E42B8]
       jmp       near ptr M02_L78
M02_L91:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,170F
       mov       rdx,7FF80D1A72B8
       call      qword ptr [7FF80CDCF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80D0A75B8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L92:
       test      dword ptr [rdi+34],1600000
       jne       near ptr M02_L80
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FF80D1E60E8]
       test      eax,eax
       je        short M02_L95
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M02_L93
       jmp       short M02_L94
M02_L93:
       mov       rcx,rbx
       mov       rdx,7FF80D210CA0
       call      qword ptr [7FF80CDCF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M02_L94:
       mov       rdx,[rbp-0C8]
       call      qword ptr [7FF80D1E6088]
       jmp       near ptr M02_L81
M02_L95:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M02_L96
       jmp       short M02_L97
M02_L96:
       mov       rcx,rbx
       mov       rdx,7FF80D210BF0
       call      qword ptr [7FF80CDCF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M02_L97:
       mov       rdx,rdi
       mov       r8,[rbp-0C8]
       call      qword ptr [7FF80D1E6040]
       jmp       near ptr M02_L81
M02_L98:
       sub       rsp,38
       mov       rsi,[rbp+10]
       mov       rcx,[rsi+18]
       test      rcx,rcx
       je        near ptr M02_L117
       mov       rbx,[rcx+8]
       cmp       qword ptr [rbx+8],0
       setne     r14b
       movzx     r14d,r14b
       mov       rcx,gs:[58]
       mov       rcx,[rcx+48]
       cmp       dword ptr [rcx+238],4
       jle       short M02_L99
       mov       rcx,[rcx+240]
       mov       r12,[rcx+20]
       test      r12,r12
       jne       short M02_L100
M02_L99:
       mov       ecx,4
       call      qword ptr [7FF80D1EC5B8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r12,rax
M02_L100:
       mov       rax,[r12+10]
       test      rax,rax
       jne       short M02_L101
       call      qword ptr [7FF80D0A5470]; System.Threading.Thread.InitializeCurrentThread()
M02_L101:
       mov       r15,[rax+8]
       xor       ecx,ecx
       mov       [rbp-0A0],rcx
       xor       r13d,r13d
       test      r15,r15
       je        short M02_L102
       mov       rcx,[r15+8]
       lea       r8,[rbp-0A0]
       mov       rdx,rbx
       mov       r11,7FF80CD10580
       call      qword ptr [r11]
       mov       r13d,eax
M02_L102:
       cmp       qword ptr [rbp-0A0],0
       je        near ptr M02_L116
       xor       ecx,ecx
       mov       [rbp-0A8],rcx
       mov       [rbp-0AC],ecx
       test      r15,r15
       je        short M02_L103
       movzx     edi,byte ptr [r15+18]
       test      r14d,r14d
       sete      r9b
       movzx     r9d,r9b
       mov       rcx,[r15+8]
       mov       rdx,rbx
       mov       r11,7FF80CD10578
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       [rbp-128],rax
       mov       r8,[r15+10]
       mov       [rbp-0A8],r8
       jmp       short M02_L106
M02_L103:
       test      r14d,r14d
       jne       short M02_L104
       mov       rcx,1DC54C01360
       mov       r15,[rcx]
       jmp       short M02_L105
M02_L104:
       mov       rcx,offset MT_System.Threading.AsyncLocalValueMap+OneElementAsyncLocalValueMap
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[rbp-0C0]
       mov       r8,rbx
       mov       rdx,7FF80D224ED0
       xor       r9d,r9d
       call      qword ptr [7FF80D1EC528]
       lea       rdi,[r15+8]
       lea       rsi,[rbp-0C0]
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
M02_L105:
       mov       [rbp-128],r15
       mov       edi,[rbp-0AC]
M02_L106:
       test      r14d,r14d
       je        short M02_L108
       test      r13d,r13d
       jne       short M02_L108
       cmp       qword ptr [rbp-0A8],0
       jne       short M02_L107
       mov       rcx,offset MT_System.Threading.IAsyncLocal[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r15,rax
       lea       rcx,[r15+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-0A8],r15
       jmp       short M02_L108
M02_L107:
       mov       r8,[rbp-0A8]
       mov       r15d,[r8+8]
       lea       r8d,[r15+1]
       lea       rdx,[rbp-0A8]
       mov       rcx,7FF80D2022B0
       call      qword ptr [7FF80CFAC5D0]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       edx,r15d
       mov       rcx,[rbp-0A8]
       mov       r8,rbx
       call      qword ptr [7FF80CDC57B8]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M02_L108:
       mov       r12,[r12+10]
       test      r12,r12
       jne       short M02_L109
       call      qword ptr [7FF80D0A5470]; System.Threading.Thread.InitializeCurrentThread()
       mov       r12,rax
M02_L109:
       test      edi,edi
       jne       short M02_L110
       mov       rcx,1DC54C01360
       mov       rax,[rbp-128]
       cmp       rax,[rcx]
       je        short M02_L111
M02_L110:
       mov       rcx,offset MT_System.Threading.ExecutionContext
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r13,[rbp-0A8]
       lea       rcx,[r15+8]
       mov       rdx,[rbp-128]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r15+18],dil
       mov       rdx,r15
       jmp       short M02_L112
M02_L111:
       xor       edx,edx
M02_L112:
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      r14d,r14d
       je        short M02_L116
       mov       rdx,[rbp-0A0]
       test      rdx,rdx
       je        short M02_L114
       mov       rcx,[rbx]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rdi,rdx
       cmp       [rdi],rcx
       je        short M02_L113
       call      qword ptr [7FF80CDC58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
M02_L113:
       jmp       short M02_L115
M02_L114:
       xor       edi,edi
M02_L115:
       mov       rax,[rbx+8]
       mov       [rbp-0E0],rdi
       xor       edx,edx
       mov       [rbp-0D8],rdx
       mov       byte ptr [rbp-0D0],0
       lea       rdx,[rbp-0E0]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
M02_L116:
       xor       ecx,ecx
       mov       [rbp-0A0],rcx
       mov       [rbp-0A8],rcx
M02_L117:
       add       rsp,38
       ret
       sub       rsp,38
       cmp       dword ptr [rbp-44],0
       je        short M02_L119
       cmp       qword ptr [rbp-0F0],0
       jne       short M02_L118
       xor       ecx,ecx
       call      qword ptr [7FF80D1EC750]
       int       3
M02_L118:
       mov       rcx,[rbp-0F0]
       call      00007FF86CA5E040
       test      eax,eax
       je        short M02_L119
       mov       ecx,eax
       mov       rdx,[rbp-0F0]
       call      qword ptr [7FF80D1EC7F8]
M02_L119:
       nop
       add       rsp,38
       ret
       sub       rsp,38
       mov       rcx,gs:[58]
       mov       rcx,[rcx+48]
       cmp       dword ptr [rcx+238],4
       jle       short M02_L120
       mov       rcx,[rcx+240]
       mov       r12,[rcx+20]
       test      r12,r12
       jne       short M02_L121
M02_L120:
       mov       ecx,4
       call      qword ptr [7FF80D1EC5B8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r12,rax
M02_L121:
       mov       rdi,[r12+10]
       test      rdi,rdi
       jne       short M02_L122
       call      qword ptr [7FF80D0A5470]; System.Threading.Thread.InitializeCurrentThread()
       mov       rdi,rax
M02_L122:
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-130]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       ret
; Total bytes of code 4009
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
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.__Canon, System.Private.CoreLib]].LazyOfTask()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+28]
       test      rdx,rdx
       je        short M00_L01
M00_L00:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,[rbx+8]
       test      rdx,rdx
       je        short M00_L02
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.LazyHelper
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+10],8
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [rsi+8],0
       je        short M00_L03
       mov       rcx,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF80D095860]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
M00_L01:
       mov       rdx,7FF80D194398
       call      qword ptr [7FF80CDBF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M00_L00
M00_L02:
       mov       ecx,1687
       mov       rdx,7FF80CCF4000
       call      qword ptr [7FF80CDBF210]
       mov       rcx,rax
       call      qword ptr [7FF80D1B7DC8]
       int       3
M00_L03:
       mov       rax,[rsi+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 181
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.__Canon, System.Private.CoreLib]](System.Threading.Tasks.Task`1<System.__Canon>)
       push      rbx
       sub       rsp,20
       mov       rbx,rdx
       mov       ecx,[rbx+34]
       and       ecx,11000000
       cmp       ecx,1000000
       jne       short M01_L01
M01_L00:
       mov       rax,[rbx+38]
       add       rsp,20
       pop       rbx
       ret
M01_L01:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF80D1B4DB0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 48
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
       call      qword ptr [7FF80D1B6280]; System.Threading.Monitor.Enter_Slowpath(System.Object)
M02_L02:
       mov       dword ptr [rbp-14],1
       mov       rcx,[rbp+10]
       cmp       [rcx+8],rbx
       jne       short M02_L03
       mov       edx,2
       call      qword ptr [7FF80D095890]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
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
       jmp       qword ptr [7FF80D095860]
M02_L05:
       cmp       eax,8
       ja        short M02_L06
       mov       eax,eax
       lea       rdx,[7FF80CE34C20]
       mov       edx,[rdx+rax*4]
       lea       r8,[M02_L01]
       add       rdx,r8
       jmp       rdx
M02_L06:
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF80D1B7EB8]
       int       3
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80D1BC330]
       jmp       short M02_L04
       mov       rcx,[rbp+10]
       xor       edx,edx
       call      qword ptr [7FF80D095890]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
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
       mov       rdx,7FF80D2011D8
       call      qword ptr [7FF80CDBF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L08:
       mov       rcx,[rax+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rax
       mov       rdx,7FF80D201278
       call      qword ptr [7FF80CDBF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M02_L10:
       call      qword ptr [7FF80D1BC2D0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80D1BC348]
       jmp       near ptr M02_L04
       mov       rcx,[rbp+10]
       mov       rdx,rbx
       call      qword ptr [7FF80D1BC360]
       jmp       near ptr M02_L04
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80D1BC378]
       jmp       near ptr M02_L04
       mov       rcx,[rbp+10]
       mov       rdx,rbx
       mov       r8d,1
       call      qword ptr [7FF80D095878]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M02_L04
M02_L11:
       mov       ecx,eax
       mov       rdx,rbx
       call      qword ptr [7FF80D1B6268]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
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
       call      qword ptr [7FF80D1B6268]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M02_L13:
       nop
       add       rsp,28
       ret
; Total bytes of code 442
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
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      dword ptr [rbx+34],1600000
       jne       short M04_L00
       mov       rcx,rbx
       mov       edx,0FFFFFFFF
       xor       r8d,r8d
       call      qword ptr [7FF80D1B4DC8]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M04_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M04_L03
M04_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L04
M04_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M04_L01
       mov       rcx,rbx
       call      qword ptr [7FF80D1BC270]
       jmp       short M04_L01
M04_L04:
       test      sil,2
       jne       short M04_L05
       mov       rcx,rbx
       call      qword ptr [7FF80D1B7F18]
M04_L05:
       mov       rcx,rbx
       call      qword ptr [7FF80D1BC660]
       jmp       short M04_L02
; Total bytes of code 124
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.__Canon, System.Private.CoreLib]].LazyOfTask_TaskRun()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+28]
       test      rdx,rdx
       je        short M00_L01
M00_L00:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,[rbx+10]
       test      rdx,rdx
       je        short M00_L02
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.LazyHelper
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+10],8
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       cmp       qword ptr [rsi+8],0
       je        short M00_L03
       mov       rcx,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF80D0C5860]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
M00_L01:
       mov       rdx,7FF80D1D4398
       call      qword ptr [7FF80CDEF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M00_L00
M00_L02:
       mov       ecx,1687
       mov       rdx,7FF80CD24000
       call      qword ptr [7FF80CDEF210]
       mov       rcx,rax
       call      qword ptr [7FF80D1EC3A8]
       int       3
M00_L03:
       mov       rax,[rsi+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 181
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.__Canon, System.Private.CoreLib]](System.Threading.Tasks.Task`1<System.__Canon>)
       push      rbx
       sub       rsp,20
       mov       rbx,rdx
       mov       ecx,[rbx+34]
       and       ecx,11000000
       cmp       ecx,1000000
       jne       short M01_L01
M01_L00:
       mov       rax,[rbx+38]
       add       rsp,20
       pop       rbx
       ret
M01_L01:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF80D1E4C60]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 48
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
       call      qword ptr [7FF80D1E6580]; System.Threading.Monitor.Enter_Slowpath(System.Object)
M02_L02:
       mov       dword ptr [rbp-14],1
       mov       rcx,[rbp+10]
       cmp       [rcx+8],rbx
       jne       short M02_L03
       mov       edx,2
       call      qword ptr [7FF80D0C5890]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
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
       jmp       qword ptr [7FF80D0C5860]
M02_L05:
       cmp       eax,8
       ja        short M02_L06
       mov       eax,eax
       lea       rdx,[7FF80CE6A500]
       mov       edx,[rdx+rax*4]
       lea       r8,[M02_L01]
       add       rdx,r8
       jmp       rdx
M02_L06:
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF80D1EC480]
       int       3
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80D1EC6C0]
       jmp       short M02_L04
       mov       rcx,[rbp+10]
       xor       edx,edx
       call      qword ptr [7FF80D0C5890]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
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
       mov       rdx,7FF80D232DB0
       call      qword ptr [7FF80CDEF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L08:
       mov       rcx,[rax+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rcx,rax
       mov       rdx,7FF80D232E50
       call      qword ptr [7FF80CDEF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M02_L10:
       call      qword ptr [7FF80D1EC660]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80D1EC6D8]
       jmp       near ptr M02_L04
       mov       rcx,[rbp+10]
       mov       rdx,rbx
       call      qword ptr [7FF80D1EC6F0]
       jmp       near ptr M02_L04
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80D1EC708]
       jmp       near ptr M02_L04
       mov       rcx,[rbp+10]
       mov       rdx,rbx
       mov       r8d,1
       call      qword ptr [7FF80D0C5878]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M02_L04
M02_L11:
       mov       ecx,eax
       mov       rdx,rbx
       call      qword ptr [7FF80D1E6598]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
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
       call      qword ptr [7FF80D1E6598]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M02_L13:
       nop
       add       rsp,28
       ret
; Total bytes of code 442
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
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      dword ptr [rbx+34],1600000
       jne       short M04_L00
       mov       rcx,rbx
       mov       edx,0FFFFFFFF
       xor       r8d,r8d
       call      qword ptr [7FF80D1E4C78]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M04_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M04_L03
M04_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L04
M04_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M04_L01
       mov       rcx,rbx
       call      qword ptr [7FF80D1EC630]
       jmp       short M04_L01
M04_L04:
       test      sil,2
       jne       short M04_L05
       mov       rcx,rbx
       call      qword ptr [7FF80D1ECB28]
M04_L05:
       mov       rcx,rbx
       call      qword ptr [7FF80D1ED2C0]
       jmp       short M04_L02
; Total bytes of code 124
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.__Canon, System.Private.CoreLib]].AsyncLazy()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+28]
       test      rdx,rdx
       je        short M00_L01
M00_L00:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,[rbx+8]
       test      rdx,rdx
       je        short M00_L02
       lea       rcx,[rsi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsi+10]
       test      rax,rax
       jne       short M00_L03
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF80D11FF30]; System.Threading.Tasks.AsyncLazy`1[[System.__Canon, System.Private.CoreLib]].GetOrStartAttemptAsync(System.Threading.CancellationToken)
M00_L01:
       mov       rdx,7FF80D196E38
       call      qword ptr [7FF80CDAF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M00_L00
M00_L02:
       mov       ecx,1
       mov       rdx,7FF80D187290
       call      qword ptr [7FF80CDAF210]
       mov       rcx,rax
       call      qword ptr [7FF80D1ACB70]
       int       3
M00_L03:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 147
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.__Canon, System.Private.CoreLib]](System.Threading.Tasks.Task`1<System.__Canon>)
       push      rbx
       sub       rsp,20
       mov       rbx,rdx
       mov       ecx,[rbx+34]
       and       ecx,11000000
       cmp       ecx,1000000
       jne       short M01_L01
M01_L00:
       mov       rax,[rbx+38]
       add       rsp,20
       pop       rbx
       ret
M01_L01:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF80D1A4CF0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 48
```
```assembly
; System.Threading.Tasks.AsyncLazy`1[[System.__Canon, System.Private.CoreLib]].GetOrStartAttemptAsync(System.Threading.CancellationToken)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
M02_L00:
       mov       rdi,[rbx+8]
       mov       rbp,[rbx]
       mov       rcx,rbp
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+18]
       test      rax,rax
       je        near ptr M02_L18
       mov       rcx,rax
M02_L01:
       mov       rdx,rdi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M02_L35
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        near ptr M02_L19
M02_L02:
       mov       rax,rcx
       test      rdi,rdi
       jne       near ptr M02_L20
M02_L03:
       lea       rax,[rbx+20]
       cmp       qword ptr [rax],0
       jne       near ptr M02_L34
M02_L04:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        near ptr M02_L22
M02_L05:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,[rdi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        near ptr M02_L23
M02_L06:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       xor       ecx,ecx
       mov       [rax+8],rcx
       mov       [rax+10],rcx
       mov       [rax+18],rcx
       mov       dword ptr [rax+34],2000440
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+8]
       test      rcx,rcx
       je        near ptr M02_L39
       mov       rdx,r14
       xor       r8d,r8d
       call      00007FF86CA021C0
       test      rax,rax
       jne       near ptr M02_L00
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        near ptr M02_L26
M02_L07:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdi,[rax+8]
       test      rdi,rdi
       je        near ptr M02_L40
M02_L08:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r15,[rcx+30]
       test      r15,r15
       je        near ptr M02_L27
M02_L09:
       mov       rcx,gs:[58]
       mov       rcx,[rcx+48]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M02_L48
       mov       rcx,[rcx+240]
       mov       rax,[rcx+20]
       test      rax,rax
       je        near ptr M02_L48
M02_L10:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M02_L11
       call      qword ptr [7FF80D085470]; System.Threading.Thread.InitializeCurrentThread()
M02_L11:
       mov       rbp,[rax+8]
       test      rbp,rbp
       je        near ptr M02_L28
       xor       ecx,ecx
       cmp       byte ptr [rbp+18],0
       cmovne    rbp,rcx
M02_L12:
       test      rbp,rbp
       je        short M02_L13
       cmp       byte ptr [rbp+19],0
       je        near ptr M02_L49
M02_L13:
       mov       rcx,[r15+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M02_L29
M02_L14:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rcx,[r13+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M02_L15:
       mov       rcx,1E329C01348
       mov       rdi,[rcx]
       cmp       byte ptr [rdi+38],0
       jne       near ptr M02_L52
M02_L16:
       mov       rcx,[rdi+8]
       mov       rdx,[rcx+10]
       mov       r8,[rdx+8]
M02_L17:
       mov       ebp,[rdx+0A0]
       mov       eax,ebp
       and       eax,[rdx+18]
       cmp       eax,[r8+8]
       jae       near ptr M02_L55
       shl       rax,4
       lea       r15,[r8+rax+10]
       mov       eax,[r15+8]
       sub       eax,ebp
       jne       near ptr M02_L30
       lea       r10,[rdx+0A0]
       lea       r9d,[rbp+1]
       mov       eax,ebp
       lock cmpxchg [r10],r9d
       cmp       eax,ebp
       jne       short M02_L17
       mov       rcx,r15
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       inc       ebp
       mov       [r15+8],ebp
       jmp       near ptr M02_L31
M02_L18:
       mov       rdx,7FF80D198368
       call      qword ptr [7FF80CDAF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L01
M02_L19:
       mov       rcx,rbp
       mov       rdx,7FF80D198378
       call      qword ptr [7FF80CDAF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L02
M02_L20:
       cmp       [rdi],rax
       jne       near ptr M02_L03
       mov       rcx,rdi
       call      qword ptr [7FF80D1A4018]
       test      eax,eax
       je        near ptr M02_L25
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,1E325298BD8
       call      qword ptr [7FF80D087D50]
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],40
       jle       short M02_L24
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M02_L24
M02_L21:
       mov       rdx,rdi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF80D11FFA8]
M02_L22:
       mov       rdx,7FF80D19B088
       call      qword ptr [7FF80CDAF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M02_L05
M02_L23:
       mov       rdx,7FF80D1CB7F0
       call      qword ptr [7FF80CDAF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M02_L06
M02_L24:
       mov       rcx,rbp
       mov       rdx,7FF80D19ACE0
       call      qword ptr [7FF80CDAF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M02_L21
M02_L25:
       mov       rcx,rdi
       mov       rdx,rsi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF80D1A4030]; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.__Canon, System.Private.CoreLib]].WaitAsync(System.Threading.CancellationToken)
M02_L26:
       mov       rcx,rbp
       mov       rdx,7FF80D1985B8
       call      qword ptr [7FF80CDAF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L07
M02_L27:
       mov       rcx,rbp
       mov       rdx,7FF80D19AAF0
       call      qword ptr [7FF80CDAF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r15,rax
       jmp       near ptr M02_L09
M02_L28:
       mov       rcx,1E329C01338
       mov       rbp,[rcx]
       jmp       near ptr M02_L12
M02_L29:
       mov       rcx,r15
       mov       rdx,7FF80D1CBAE0
       call      qword ptr [7FF80CDAF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L14
M02_L30:
       test      eax,eax
       jge       near ptr M02_L17
       mov       rdx,r13
       call      qword ptr [7FF80D1ACBA0]
M02_L31:
       add       rdi,78
       mov       ecx,1
       xchg      ecx,[rdi]
       test      ecx,ecx
       jne       short M02_L32
       mov       rcx,1E329C01370
       mov       rdi,[rcx]
       lea       rcx,[rdi+178]
       lock inc  dword ptr [rcx]
       mov       rcx,rdi
       call      qword ptr [7FF80D1A45A0]; System.Threading.PortableThreadPool+WorkerThread.MaybeAddWorkingWorker(System.Threading.PortableThreadPool)
       cmp       dword ptr [rdi+17C],6
       jne       near ptr M02_L53
M02_L32:
       test      rsi,rsi
       jne       near ptr M02_L54
       mov       rcx,[r14+10]
       mov       rax,[rcx+8]
M02_L33:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L34:
       mov       rax,[rax]
       cmp       dword ptr [rax+20],0
       je        near ptr M02_L04
       jmp       short M02_L36
M02_L35:
       jmp       short M02_L33
M02_L36:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L37
       jmp       short M02_L38
M02_L37:
       mov       rcx,rbp
       mov       rdx,7FF80D198148
       call      qword ptr [7FF80CDAF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M02_L38:
       mov       rdx,[rbx+20]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF80D11FED0]
M02_L39:
       call      qword ptr [7FF80D1ACB28]
       int       3
M02_L40:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rdi,[rcx+28]
       test      rdi,rdi
       je        short M02_L41
       jmp       short M02_L42
M02_L41:
       mov       rcx,rbp
       mov       rdx,7FF80D1985B8
       call      qword ptr [7FF80CDAF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M02_L42:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],38
       jle       short M02_L43
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M02_L43
       jmp       short M02_L44
M02_L43:
       mov       rcx,rbp
       mov       rdx,7FF80D19ABD8
       call      qword ptr [7FF80CDAF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M02_L44:
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       test      rdx,rdx
       jne       short M02_L45
       call      qword ptr [7FF80D1AD968]
       int       3
M02_L45:
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset System.Threading.Tasks.AsyncLazy`1+<>c[[System.__Canon, System.Private.CoreLib]].<GetOrStartAttemptAsync>b__11_0(Attempt<System.__Canon>)
       mov       [r15+18],rcx
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M02_L46
       jmp       short M02_L47
M02_L46:
       mov       rcx,rbp
       mov       rdx,7FF80D1985B8
       call      qword ptr [7FF80CDAF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M02_L47:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       lea       rcx,[rax+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,r15
       jmp       near ptr M02_L08
M02_L48:
       mov       ecx,4
       call      qword ptr [7FF80D1AC9F0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M02_L10
M02_L49:
       mov       rcx,[r15+18]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M02_L50
       jmp       short M02_L51
M02_L50:
       mov       rcx,r15
       mov       rdx,7FF80D1CBCB0
       call      qword ptr [7FF80CDAF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M02_L51:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       rdx,rdi
       mov       r8,r14
       mov       r9,rbp
       call      qword ptr [7FF80D1AD050]
       jmp       near ptr M02_L15
M02_L52:
       mov       rcx,1E329C01360
       mov       rcx,[rcx]
       cmp       byte ptr [rcx+9D],0
       je        near ptr M02_L16
       mov       rcx,1E329C01360
       mov       rcx,[rcx]
       mov       rdx,r13
       call      qword ptr [7FF80D1ACB88]
       jmp       near ptr M02_L16
M02_L53:
       mov       rcx,rdi
       call      qword ptr [7FF80D1A4780]; System.Threading.PortableThreadPool+GateThread.EnsureRunningSlow(System.Threading.PortableThreadPool)
       jmp       near ptr M02_L32
M02_L54:
       mov       rcx,[r14+10]
       mov       rdi,[rcx+8]
       cmp       [rdi],dil
       mov       rcx,offset MT_System.TimeProvider
       call      qword ptr [7FF80CDA5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,1E329C014D8
       mov       r8,[r8]
       mov       r9,rsi
       mov       rcx,rdi
       mov       edx,0FFFFFFFF
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF80D1AD980]
M02_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1599
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
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      dword ptr [rbx+34],1600000
       jne       short M04_L00
       mov       rcx,rbx
       mov       edx,0FFFFFFFF
       xor       r8d,r8d
       call      qword ptr [7FF80D1A4D08]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M04_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M04_L03
M04_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L04
M04_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M04_L01
       mov       rcx,rbx
       call      qword ptr [7FF80D1ACF90]
       jmp       short M04_L01
M04_L04:
       test      sil,2
       jne       short M04_L05
       mov       rcx,rbx
       call      qword ptr [7FF80D1AD098]
M04_L05:
       mov       rcx,rbx
       call      qword ptr [7FF80D1AD998]
       jmp       short M04_L02
; Total bytes of code 124
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.__Canon, System.Private.CoreLib]].AsyncLazy_NoHop()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,78
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-50],ymm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rax,[rax+28]
       test      rax,rax
       je        near ptr M00_L21
M00_L00:
       mov       rcx,rax
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+8]
       test      rdx,rdx
       je        near ptr M00_L32
       lea       rcx,[rbx+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbx+10]
       test      rax,rax
       jne       near ptr M00_L33
M00_L01:
       mov       rsi,[rbx+8]
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+18]
       test      rax,rax
       je        near ptr M00_L22
       mov       rcx,rax
M00_L02:
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L35
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+20]
       test      rax,rax
       je        near ptr M00_L23
       mov       rcx,rax
M00_L03:
       mov       rax,rcx
       test      rsi,rsi
       jne       near ptr M00_L24
M00_L04:
       lea       rax,[rbx+20]
       cmp       qword ptr [rax],0
       jne       near ptr M00_L34
M00_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,[rdi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        near ptr M00_L26
M00_L06:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        near ptr M00_L27
M00_L07:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       xor       ecx,ecx
       mov       [rax+8],rcx
       mov       [rax+10],rcx
       mov       [rax+18],rcx
       mov       dword ptr [rax+34],2000440
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+8]
       test      rcx,rcx
       je        near ptr M00_L39
       mov       rdx,rdi
       xor       r8d,r8d
       call      00007FF86CA021C0
       test      rax,rax
       jne       near ptr M00_L01
       xor       ecx,ecx
       mov       [rbp-38],rcx
       mov       [rbp-58],rdi
       mov       dword ptr [rbp-40],0FFFFFFFF
       mov       rcx,[rdi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+18]
       test      rax,rax
       je        near ptr M00_L30
       mov       rcx,rax
M00_L08:
       mov       rdx,[rcx+18]
       mov       rbx,[rdx+10]
       test      rbx,rbx
       je        near ptr M00_L31
M00_L09:
       mov       rcx,gs:[58]
       mov       rcx,[rcx+48]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M00_L40
       mov       rcx,[rcx+240]
       mov       rax,[rcx+20]
       test      rax,rax
       je        near ptr M00_L40
M00_L10:
       mov       rsi,[rax+10]
       test      rsi,rsi
       jne       short M00_L11
       call      qword ptr [7FF80D085470]; System.Threading.Thread.InitializeCurrentThread()
       mov       rsi,rax
M00_L11:
       mov       [rbp-60],rsi
       mov       rdx,[rsi+8]
       mov       [rbp-68],rdx
       mov       rdx,[rsi+10]
       mov       [rbp-70],rdx
       mov       rcx,[rbx+18]
       mov       rax,[rcx+10]
       test      rax,rax
       je        short M00_L13
M00_L12:
       lea       rcx,[rbp-58]
       call      rax
       jmp       short M00_L14
M00_L13:
       mov       rcx,rbx
       mov       rdx,7FF80D1892A8
       call      qword ptr [7FF80CDAF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       jmp       short M00_L12
M00_L14:
       mov       rdx,[rbp-70]
       cmp       rdx,[rsi+10]
       je        short M00_L15
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L15:
       mov       rcx,[rsi+8]
       mov       rbx,rcx
       mov       rdx,[rbp-68]
       cmp       rdx,rbx
       je        short M00_L17
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        short M00_L16
       cmp       qword ptr [rbx+10],0
       jne       near ptr M00_L41
M00_L16:
       cmp       qword ptr [rbp-68],0
       jne       short M00_L20
M00_L17:
       cmp       qword ptr [rbp-38],0
       je        near ptr M00_L42
M00_L18:
       mov       rax,[rdi+10]
       mov       rax,[rax+8]
M00_L19:
       add       rsp,78
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M00_L20:
       mov       rdx,[rbp-68]
       cmp       qword ptr [rdx+10],0
       je        short M00_L17
       jmp       near ptr M00_L41
M00_L21:
       mov       rcx,rdx
       mov       rdx,7FF80D186D98
       call      qword ptr [7FF80CDAF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M00_L00
M00_L22:
       mov       rdx,7FF80D1882C8
       call      qword ptr [7FF80CDAF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M00_L02
M00_L23:
       mov       rdx,7FF80D1882D8
       call      qword ptr [7FF80CDAF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M00_L03
M00_L24:
       cmp       [rsi],rax
       jne       near ptr M00_L04
       mov       rcx,rsi
       call      qword ptr [7FF80D11FED0]
       test      eax,eax
       je        near ptr M00_L29
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,202A5298BD8
       call      qword ptr [7FF80D087D50]
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+28]
       test      rax,rax
       je        short M00_L28
       mov       rcx,rax
M00_L25:
       mov       rdx,rsi
       call      qword ptr [7FF80D11FE88]
       jmp       near ptr M00_L19
M00_L26:
       mov       rdx,7FF80D1887D8
       call      qword ptr [7FF80CDAF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M00_L06
M00_L27:
       mov       rdx,7FF80D1D7AE8
       call      qword ptr [7FF80CDAF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M00_L07
M00_L28:
       mov       rdx,7FF80D188440
       call      qword ptr [7FF80CDAF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M00_L25
M00_L29:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF80D11FEE8]; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.__Canon, System.Private.CoreLib]].WaitAsync(System.Threading.CancellationToken)
       jmp       near ptr M00_L19
M00_L30:
       mov       rdx,7FF80D188F18
       call      qword ptr [7FF80CDAF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M00_L08
M00_L31:
       mov       rdx,7FF80D189100
       call      qword ptr [7FF80CDAF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rbx,rax
       jmp       near ptr M00_L09
M00_L32:
       mov       ecx,1
       mov       rdx,7FF80D196CC8
       call      qword ptr [7FF80CDAF210]
       mov       rcx,rax
       call      qword ptr [7FF80D1ACC48]
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
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+10]
       test      rax,rax
       je        short M00_L37
       mov       rcx,rax
       jmp       short M00_L38
M00_L37:
       mov       rdx,7FF80D1880A8
       call      qword ptr [7FF80CDAF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M00_L38:
       mov       rdx,[rbx+20]
       call      qword ptr [7FF80D11FDF8]
       jmp       near ptr M00_L19
M00_L39:
       call      qword ptr [7FF80D1AC810]
       int       3
M00_L40:
       mov       ecx,4
       call      qword ptr [7FF80D1AC8B8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L10
M00_L41:
       mov       rcx,rbx
       mov       rdx,[rbp-68]
       call      qword ptr [7FF80D1AC690]
       jmp       near ptr M00_L17
M00_L42:
       lea       rcx,[rbp-38]
       call      qword ptr [7FF80D1ACB58]
       jmp       near ptr M00_L18
       sub       rsp,28
       mov       rdx,[rbp-70]
       mov       rax,[rbp-60]
       cmp       rdx,[rax+10]
       je        short M00_L43
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-60]
M00_L43:
       mov       rdi,[rax+8]
       mov       rdx,[rbp-68]
       cmp       rdx,rdi
       je        short M00_L46
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M00_L44
       cmp       qword ptr [rdi+10],0
       jne       short M00_L45
M00_L44:
       cmp       qword ptr [rbp-68],0
       je        short M00_L46
       mov       rdx,[rbp-68]
       cmp       qword ptr [rdx+10],0
       je        short M00_L46
M00_L45:
       mov       rcx,rdi
       mov       rdx,[rbp-68]
       call      qword ptr [7FF80D1AC690]
M00_L46:
       nop
       add       rsp,28
       ret
; Total bytes of code 1252
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.__Canon, System.Private.CoreLib]](System.Threading.Tasks.Task`1<System.__Canon>)
       push      rbx
       sub       rsp,20
       mov       rbx,rdx
       mov       ecx,[rbx+34]
       and       ecx,11000000
       cmp       ecx,1000000
       jne       short M01_L01
M01_L00:
       mov       rax,[rbx+38]
       add       rsp,20
       pop       rbx
       ret
M01_L01:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF80D1A5878]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 48
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
; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       [rbp-9C],rcx
       mov       r8,rdx
       mov       [rbp-0A4],r8
       xor       edx,edx
       mov       [rbp-0AC],rdx
       mov       r9d,0FFFFFFFF
       mov       [rbp-94],r9d
       lea       rcx,[rbp-90]
       call      qword ptr [7FF850609030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rcx,[rbp-9C]
       mov       r8,[rbp-0A4]
       mov       rdx,[rbp-0AC]
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
; Total bytes of code 163
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
; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.__Canon, System.Private.CoreLib]].WaitAsync(System.Threading.CancellationToken)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rdx
       test      rbx,rbx
       jne       short M06_L00
       mov       rax,[rcx+10]
       mov       rax,[rax+8]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L00:
       mov       rcx,[rcx+10]
       mov       rsi,[rcx+8]
       cmp       [rsi],sil
       mov       rcx,offset MT_System.TimeProvider
       call      qword ptr [7FF80CDA5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,202B58014B8
       mov       r8,[r8]
       mov       r9,rbx
       mov       rcx,rsi
       mov       edx,0FFFFFFFF
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF80D1AD590]
; Total bytes of code 92
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
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      dword ptr [rbx+34],1600000
       jne       short M08_L00
       mov       rcx,rbx
       mov       edx,0FFFFFFFF
       xor       r8d,r8d
       call      qword ptr [7FF80D1A5890]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M08_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M08_L03
M08_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M08_L04
M08_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M08_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M08_L01
       mov       rcx,rbx
       call      qword ptr [7FF80D1AD0B0]
       jmp       short M08_L01
M08_L04:
       test      sil,2
       jne       short M08_L05
       mov       rcx,rbx
       call      qword ptr [7FF80D1ACED0]
M08_L05:
       mov       rcx,rbx
       call      qword ptr [7FF80D1AD668]
       jmp       short M08_L02
; Total bytes of code 124
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.__Canon, System.Private.CoreLib]].AsyncLazy_NoRecursionDetection()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+28]
       test      rdx,rdx
       je        short M00_L01
M00_L00:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,[rbx+8]
       test      rdx,rdx
       je        short M00_L02
       lea       rcx,[rsi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsi+10]
       test      rax,rax
       jne       short M00_L03
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF80D12FF48]; System.Threading.Tasks.AsyncLazy`1[[System.__Canon, System.Private.CoreLib]].GetOrStartAttemptAsync(System.Threading.CancellationToken)
M00_L01:
       mov       rdx,7FF80D1A6E28
       call      qword ptr [7FF80CDBF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M00_L00
M00_L02:
       mov       ecx,1
       mov       rdx,7FF80D1972B0
       call      qword ptr [7FF80CDBF210]
       mov       rcx,rax
       call      qword ptr [7FF80D1BCC90]
       int       3
M00_L03:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 147
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.__Canon, System.Private.CoreLib]](System.Threading.Tasks.Task`1<System.__Canon>)
       push      rbx
       sub       rsp,20
       mov       rbx,rdx
       mov       ecx,[rbx+34]
       and       ecx,11000000
       cmp       ecx,1000000
       jne       short M01_L01
M01_L00:
       mov       rax,[rbx+38]
       add       rsp,20
       pop       rbx
       ret
M01_L01:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF80D1B4B58]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 48
```
```assembly
; System.Threading.Tasks.AsyncLazy`1[[System.__Canon, System.Private.CoreLib]].GetOrStartAttemptAsync(System.Threading.CancellationToken)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
M02_L00:
       mov       rdi,[rbx+8]
       mov       rbp,[rbx]
       mov       rcx,rbp
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+18]
       test      rax,rax
       je        near ptr M02_L18
       mov       rcx,rax
M02_L01:
       mov       rdx,rdi
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M02_L30
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        near ptr M02_L19
M02_L02:
       mov       rax,rcx
       test      rdi,rdi
       jne       near ptr M02_L20
M02_L03:
       lea       rax,[rbx+20]
       cmp       qword ptr [rax],0
       jne       near ptr M02_L29
M02_L04:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,[r14]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        near ptr M02_L21
M02_L05:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,[rdi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        near ptr M02_L22
M02_L06:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       xor       ecx,ecx
       mov       [rax+8],rcx
       mov       [rax+10],rcx
       mov       [rax+18],rcx
       mov       dword ptr [rax+34],2000440
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+8]
       test      rcx,rcx
       je        near ptr M02_L34
       mov       rdx,r14
       xor       r8d,r8d
       call      00007FF86CA021C0
       test      rax,rax
       jne       near ptr M02_L00
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        near ptr M02_L23
M02_L07:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdi,[rax+8]
       test      rdi,rdi
       je        near ptr M02_L35
M02_L08:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       r15,[rcx+30]
       test      r15,r15
       je        near ptr M02_L24
M02_L09:
       mov       rcx,gs:[58]
       mov       rcx,[rcx+48]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M02_L43
       mov       rcx,[rcx+240]
       mov       rax,[rcx+20]
       test      rax,rax
       je        near ptr M02_L43
M02_L10:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M02_L11
       call      qword ptr [7FF80D095470]; System.Threading.Thread.InitializeCurrentThread()
M02_L11:
       mov       rbp,[rax+8]
       test      rbp,rbp
       jne       near ptr M02_L44
       mov       rcx,1DA5F401338
       mov       rbp,[rcx]
M02_L12:
       test      rbp,rbp
       je        short M02_L13
       cmp       byte ptr [rbp+19],0
       je        near ptr M02_L45
M02_L13:
       mov       rcx,[r15+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        near ptr M02_L25
M02_L14:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rcx,[r13+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M02_L15:
       mov       rcx,1DA5F401348
       mov       rdi,[rcx]
       cmp       byte ptr [rdi+38],0
       jne       near ptr M02_L48
M02_L16:
       mov       rcx,[rdi+8]
       mov       rdx,[rcx+10]
       mov       r8,[rdx+8]
M02_L17:
       mov       ebp,[rdx+0A0]
       mov       eax,ebp
       and       eax,[rdx+18]
       cmp       eax,[r8+8]
       jae       near ptr M02_L51
       shl       rax,4
       lea       r15,[r8+rax+10]
       mov       eax,[r15+8]
       sub       eax,ebp
       jne       near ptr M02_L26
       lea       r10,[rdx+0A0]
       lea       r9d,[rbp+1]
       mov       eax,ebp
       lock cmpxchg [r10],r9d
       cmp       eax,ebp
       jne       short M02_L17
       mov       rcx,r15
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       inc       ebp
       mov       [r15+8],ebp
       jmp       near ptr M02_L27
M02_L18:
       mov       rdx,7FF80D1A8358
       call      qword ptr [7FF80CDBF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L01
M02_L19:
       mov       rcx,rbp
       mov       rdx,7FF80D1A8368
       call      qword ptr [7FF80CDBF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L02
M02_L20:
       cmp       [rdi],rax
       jne       near ptr M02_L03
       mov       rcx,rdi
       mov       rdx,rsi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF80D12FFD8]; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.__Canon, System.Private.CoreLib]].WaitAsync(System.Threading.CancellationToken)
M02_L21:
       mov       rdx,7FF80D1AAF70
       call      qword ptr [7FF80CDBF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M02_L05
M02_L22:
       mov       rdx,7FF80D1DADE0
       call      qword ptr [7FF80CDBF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M02_L06
M02_L23:
       mov       rcx,rbp
       mov       rdx,7FF80D1A85A8
       call      qword ptr [7FF80CDBF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L07
M02_L24:
       mov       rcx,rbp
       mov       rdx,7FF80D1AAAE0
       call      qword ptr [7FF80CDBF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r15,rax
       jmp       near ptr M02_L09
M02_L25:
       mov       rcx,r15
       mov       rdx,7FF80D1DB0D0
       call      qword ptr [7FF80CDBF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L14
M02_L26:
       test      eax,eax
       jge       near ptr M02_L17
       mov       rdx,r13
       call      qword ptr [7FF80D1BCA98]
M02_L27:
       add       rdi,78
       mov       ecx,1
       xchg      ecx,[rdi]
       test      ecx,ecx
       jne       short M02_L28
       mov       rcx,1DA5F401370
       mov       rdi,[rcx]
       lea       rcx,[rdi+178]
       lock inc  dword ptr [rcx]
       mov       rcx,rdi
       call      qword ptr [7FF80D1B4558]; System.Threading.PortableThreadPool+WorkerThread.MaybeAddWorkingWorker(System.Threading.PortableThreadPool)
       cmp       dword ptr [rdi+17C],6
       jne       near ptr M02_L49
M02_L28:
       test      rsi,rsi
       jne       near ptr M02_L50
       mov       rax,[r14+10]
       mov       rax,[rax+8]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L29:
       mov       rax,[rax]
       cmp       dword ptr [rax+20],0
       je        near ptr M02_L04
       jmp       short M02_L31
M02_L30:
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M02_L31:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L32
       jmp       short M02_L33
M02_L32:
       mov       rcx,rbp
       mov       rdx,7FF80D1A8138
       call      qword ptr [7FF80CDBF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M02_L33:
       mov       rdx,[rbx+20]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF80D12FEE8]
M02_L34:
       call      qword ptr [7FF80D1BC828]
       int       3
M02_L35:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rdi,[rcx+28]
       test      rdi,rdi
       je        short M02_L36
       jmp       short M02_L37
M02_L36:
       mov       rcx,rbp
       mov       rdx,7FF80D1A85A8
       call      qword ptr [7FF80CDBF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M02_L37:
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],38
       jle       short M02_L38
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M02_L38
       jmp       short M02_L39
M02_L38:
       mov       rcx,rbp
       mov       rdx,7FF80D1AABC8
       call      qword ptr [7FF80CDBF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M02_L39:
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,rdi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       test      rdx,rdx
       jne       short M02_L40
       call      qword ptr [7FF80D1BD728]
       int       3
M02_L40:
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset System.Threading.Tasks.AsyncLazy`1+<>c[[System.__Canon, System.Private.CoreLib]].<GetOrStartAttemptAsync>b__11_0(Attempt<System.__Canon>)
       mov       [r15+18],rcx
       mov       rcx,[rbp+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M02_L41
       jmp       short M02_L42
M02_L41:
       mov       rcx,rbp
       mov       rdx,7FF80D1A85A8
       call      qword ptr [7FF80CDBF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M02_L42:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       lea       rcx,[rax+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,r15
       jmp       near ptr M02_L08
M02_L43:
       mov       ecx,4
       call      qword ptr [7FF80D1BC840]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M02_L10
M02_L44:
       xor       ecx,ecx
       cmp       byte ptr [rbp+18],0
       cmovne    rbp,rcx
       jmp       near ptr M02_L12
M02_L45:
       mov       rcx,[r15+18]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M02_L46
       jmp       short M02_L47
M02_L46:
       mov       rcx,r15
       mov       rdx,7FF80D1DB2A0
       call      qword ptr [7FF80CDBF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M02_L47:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       rdx,rdi
       mov       r8,r14
       mov       r9,rbp
       call      qword ptr [7FF80D1BCEB8]
       jmp       near ptr M02_L15
M02_L48:
       mov       rcx,1DA5F401360
       mov       rcx,[rcx]
       cmp       byte ptr [rcx+9D],0
       je        near ptr M02_L16
       mov       rcx,1DA5F401360
       mov       rcx,[rcx]
       mov       rdx,r13
       call      qword ptr [7FF80D1BCA80]
       jmp       near ptr M02_L16
M02_L49:
       mov       rcx,rdi
       call      qword ptr [7FF80D1B4738]; System.Threading.PortableThreadPool+GateThread.EnsureRunningSlow(System.Threading.PortableThreadPool)
       jmp       near ptr M02_L28
M02_L50:
       mov       rcx,[r14+10]
       mov       rdi,[rcx+8]
       cmp       [rdi],dil
       mov       rcx,offset MT_System.TimeProvider
       call      qword ptr [7FF80CDB5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r8,1DA5F4014C8
       mov       r8,[r8]
       mov       r9,rsi
       mov       rcx,rdi
       mov       edx,0FFFFFFFF
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF80D1BD740]
M02_L51:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1488
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
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      dword ptr [rbx+34],1600000
       jne       short M04_L00
       mov       rcx,rbx
       mov       edx,0FFFFFFFF
       xor       r8d,r8d
       call      qword ptr [7FF80D1B4B88]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M04_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M04_L03
M04_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L04
M04_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M04_L01
       mov       rcx,rbx
       call      qword ptr [7FF80D1BCDF8]
       jmp       short M04_L01
M04_L04:
       test      sil,2
       jne       short M04_L05
       mov       rcx,rbx
       call      qword ptr [7FF80D1BCF00]
M04_L05:
       mov       rcx,rbx
       call      qword ptr [7FF80D1BD758]
       jmp       short M04_L02
; Total bytes of code 124
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.__Canon, System.Private.CoreLib]].Nito()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rbx,[rax+28]
       test      rbx,rbx
       je        near ptr M00_L09
M00_L00:
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+8]
       test      rsi,rsi
       je        near ptr M00_L13
       mov       rdx,[rbx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        near ptr M00_L10
M00_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        near ptr M00_L11
M00_L02:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset Nito.AsyncEx.AsyncLazy`1+<>c__DisplayClass14_0[[System.__Canon, System.Private.CoreLib]].<RunOnThreadPool>b__0()
       mov       [rsi+18],rcx
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,[rbx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M00_L12
M00_L03:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.LazyHelper
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+10],8
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-30],rdi
       xor       ecx,ecx
       mov       [rbp-24],ecx
       mov       rcx,rdi
       call      00007FF86CA5E120
       test      eax,eax
       je        short M00_L05
M00_L04:
       mov       dword ptr [rbp-24],1
       cmp       qword ptr [rbx+8],0
       je        short M00_L06
       mov       rcx,rbx
       call      qword ptr [7FF80D085860]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rsi,rax
       jmp       short M00_L07
M00_L05:
       mov       rcx,rdi
       call      qword ptr [7FF80D1A6628]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L04
M00_L06:
       mov       rsi,[rbx+18]
M00_L07:
       mov       rcx,rdi
       call      00007FF86CA5E040
       test      eax,eax
       jne       near ptr M00_L14
M00_L08:
       mov       rax,rsi
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M00_L09:
       mov       rcx,rdx
       mov       rdx,7FF80D198BA0
       call      qword ptr [7FF80CDAF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rbx,rax
       jmp       near ptr M00_L00
M00_L10:
       mov       rcx,rbx
       mov       rdx,7FF80D198FD8
       call      qword ptr [7FF80CDAF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M00_L01
M00_L11:
       mov       rcx,rbx
       mov       rdx,7FF80D199000
       call      qword ptr [7FF80CDAF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M00_L02
M00_L12:
       mov       rcx,rbx
       mov       rdx,7FF80D198D68
       call      qword ptr [7FF80CDAF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M00_L03
M00_L13:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,10E
       mov       rdx,7FF80D1872A8
       call      qword ptr [7FF80CDAF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80D0875B8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L14:
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FF80D1AC0A8]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       near ptr M00_L08
       sub       rsp,28
       cmp       dword ptr [rbp-24],0
       je        short M00_L15
       mov       rcx,[rbp-30]
       call      00007FF86CA5E040
       test      eax,eax
       je        short M00_L15
       mov       ecx,eax
       mov       rdx,[rbp-30]
       call      qword ptr [7FF80D1AC0A8]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M00_L15:
       nop
       add       rsp,28
       ret
; Total bytes of code 567
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.__Canon, System.Private.CoreLib]](System.Threading.Tasks.Task`1<System.__Canon>)
       push      rbx
       sub       rsp,20
       mov       rbx,rdx
       mov       ecx,[rbx+34]
       and       ecx,11000000
       cmp       ecx,1000000
       jne       short M01_L01
M01_L00:
       mov       rax,[rbx+38]
       add       rsp,20
       pop       rbx
       ret
M01_L01:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF80D1A4B88]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 48
```
```assembly
; Nito.AsyncEx.AsyncLazy`1+<>c__DisplayClass14_0[[System.__Canon, System.Private.CoreLib]].<RunOnThreadPool>b__0()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M02_L02
M02_L00:
       mov       rsi,[rbx+8]
       mov       rcx,[rdx+18]
       mov       rdi,[rcx+18]
       test      rdi,rdi
       je        short M02_L03
M02_L01:
       test      rsi,rsi
       jne       short M02_L04
       mov       ecx,2E
       call      qword ptr [7FF80CDAFD38]
       int       3
M02_L02:
       mov       rdx,7FF80D19A1D0
       call      qword ptr [7FF80CDAF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M02_L00
M02_L03:
       mov       rcx,rdx
       mov       rdx,7FF80D1CB608
       call      qword ptr [7FF80CDAF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       short M02_L01
M02_L04:
       mov       rcx,[rdi+18]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        near ptr M02_L10
M02_L05:
       call      qword ptr [7FF80D11FF78]; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].get_Factory()
       mov       rcx,[rax]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        near ptr M02_L11
M02_L06:
       mov       rcx,1F368401340
       mov       rbp,[rcx]
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+10],rcx
       lea       rcx,[r14+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       eax,2008
       mov       [r14+34],eax
       call      qword ptr [7FF80D1A40D8]; System.Threading.ExecutionContext.Capture()
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M02_L12
       or        dword ptr [r14+34],20000000
M02_L07:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FF80D1A4120]; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
       mov       rcx,[rdi+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        near ptr M02_L13
M02_L08:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       movzx     edi,word ptr [r14+34]
       and       edi,4
       test      edi,0FFFFFFBB
       je        near ptr M02_L14
M02_L09:
       mov       ecx,2D
       call      qword ptr [7FF80CDAF348]
       int       3
M02_L10:
       mov       rcx,rdi
       mov       rdx,7FF80D1CB7A8
       call      qword ptr [7FF80CDAF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L05
M02_L11:
       mov       rdx,7FF80D1CBA08
       call      qword ptr [7FF80CDAF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M02_L06
M02_L12:
       mov       rcx,1F368401350
       cmp       rsi,[rcx]
       je        near ptr M02_L07
       mov       rcx,r14
       call      qword ptr [7FF80D1AC558]
       lea       rcx,[rax+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L07
M02_L13:
       mov       rcx,rdi
       mov       rdx,7FF80D1CB850
       call      qword ptr [7FF80CDAF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M02_L08
M02_L14:
       test      dil,4
       je        short M02_L16
       mov       rcx,gs:[58]
       mov       rcx,[rcx+48]
       cmp       dword ptr [rcx+238],8
       jle       near ptr M02_L21
       mov       rcx,[rcx+240]
       mov       rax,[rcx+40]
       test      rax,rax
       je        near ptr M02_L21
M02_L15:
       mov       rbp,[rax+10]
       test      rbp,rbp
       je        short M02_L16
       mov       rcx,rsi
       call      qword ptr [7FF80D1AC558]
       lea       rcx,[rax+30]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M02_L16:
       xor       ecx,ecx
       mov       [rsi+8],rcx
       mov       [rsi+10],rcx
       mov       [rsi+18],rcx
       test      edi,0FFFFFFA0
       jne       near ptr M02_L09
       mov       ecx,edi
       or        ecx,400
       or        ecx,2000000
       mov       [rsi+34],ecx
       mov       rcx,[rsi+28]
       test      rcx,rcx
       jne       near ptr M02_L22
M02_L17:
       mov       byte ptr [rsi+41],1
       mov       rcx,1F368401360
       mov       rcx,[rcx]
       cmp       byte ptr [rcx+9D],0
       jne       near ptr M02_L23
M02_L18:
       cmp       byte ptr [7FF80CCEB074],0
       jne       near ptr M02_L24
M02_L19:
       test      dword ptr [r14+34],1600000
       jne       near ptr M02_L25
       test      dword ptr [r14+34],1600000
       jne       near ptr M02_L28
       cmp       qword ptr [r14+20],0
       jne       near ptr M02_L27
       lea       rcx,[r14+20]
       test      rcx,rcx
       je        near ptr M02_L26
       mov       rdx,rsi
       xor       r8d,r8d
       call      00007FF86CA021C0
       test      rax,rax
       jne       near ptr M02_L27
M02_L20:
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L21:
       mov       ecx,8
       call      qword ptr [7FF80D1AC168]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M02_L15
M02_L22:
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M02_L17
       test      dil,4
       je        near ptr M02_L17
       test      byte ptr [rcx+34],8
       jne       near ptr M02_L17
       call      qword ptr [7FF80D1AC420]
       jmp       near ptr M02_L17
M02_L23:
       mov       rcx,rsi
       call      qword ptr [7FF80D1A5B48]
       mov       edx,eax
       mov       rcx,1F368401360
       mov       rcx,[rcx]
       mov       r8,1F3252A9A98
       xor       r9d,r9d
       call      qword ptr [7FF80D1AC600]
       jmp       near ptr M02_L18
M02_L24:
       mov       rcx,rsi
       call      qword ptr [7FF80D1A56F8]
       jmp       near ptr M02_L19
M02_L25:
       mov       rcx,rsi
       mov       rdx,r14
       call      qword ptr [7FF80D1A58A8]; System.Threading.Tasks.UnwrapPromise`1[[System.__Canon, System.Private.CoreLib]].ProcessCompletedOuterTask(System.Threading.Tasks.Task)
       jmp       near ptr M02_L20
M02_L26:
       call      qword ptr [7FF80D1AC078]
       int       3
M02_L27:
       mov       rcx,r14
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF80D1A65E0]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M02_L20
M02_L28:
       mov       rcx,rsi
       mov       rdx,r14
       call      qword ptr [7FF80D1B4A38]; System.Threading.Tasks.UnwrapPromise`1[[System.__Canon, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
       jmp       near ptr M02_L20
; Total bytes of code 895
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
       call      qword ptr [7FF80D085890]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M03_L04
M03_L03:
       mov       rcx,rbx
       call      qword ptr [7FF80D1A6628]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       jmp       qword ptr [7FF80D085860]
M03_L06:
       cmp       eax,8
       ja        short M03_L07
       mov       eax,eax
       lea       rdx,[7FF80CE2EBE0]
       mov       edx,[rdx+rax*4]
       lea       r8,[M03_L01]
       add       rdx,r8
       jmp       rdx
M03_L07:
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF80D1AC498]
       int       3
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80D1ACC60]
       jmp       short M03_L05
       mov       rcx,[rbp+10]
       xor       edx,edx
       call      qword ptr [7FF80D085890]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
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
       mov       rdx,7FF80D1CB050
       call      qword ptr [7FF80CDAF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M03_L09:
       mov       rcx,[rax+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M03_L10
       jmp       short M03_L11
M03_L10:
       mov       rcx,rax
       mov       rdx,7FF80D1CB0F0
       call      qword ptr [7FF80CDAF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M03_L11:
       call      qword ptr [7FF80D1ACC00]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80D1ACC78]
       jmp       near ptr M03_L05
       mov       rcx,[rbp+10]
       mov       rdx,rbx
       call      qword ptr [7FF80D1ACC90]
       jmp       near ptr M03_L05
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80D1ACCA8]
       jmp       near ptr M03_L05
       mov       rcx,[rbp+10]
       mov       rdx,rbx
       mov       r8d,1
       call      qword ptr [7FF80D085878]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M03_L05
M03_L12:
       mov       ecx,eax
       mov       rdx,rbx
       call      qword ptr [7FF80D1AC0A8]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
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
       call      qword ptr [7FF80D1AC0A8]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
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
       mov       rax,7FF80CDE8210
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
       jne       short M07_L00
       mov       rcx,rbx
       mov       edx,0FFFFFFFF
       xor       r8d,r8d
       call      qword ptr [7FF80D1A4BA0]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FF80D1ACF60]
       jmp       short M07_L01
M07_L04:
       test      sil,2
       jne       short M07_L05
       mov       rcx,rbx
       call      qword ptr [7FF80D1ACDC8]
M07_L05:
       mov       rcx,rbx
       call      qword ptr [7FF80D1AD590]
       jmp       short M07_L02
; Total bytes of code 124
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.__Canon, System.Private.CoreLib]].Nito_ExecuteOnCallingThread()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp-20],rcx
       mov       [rbp+10],rcx
       mov       rdx,[rcx]
       mov       rax,[rdx+30]
       mov       rax,[rax]
       mov       rbx,[rax+28]
       test      rbx,rbx
       je        near ptr M00_L07
M00_L00:
       mov       rcx,[rbp+10]
       mov       rsi,[rcx+8]
       test      rsi,rsi
       je        near ptr M00_L09
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,[rbx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M00_L08
M00_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.LazyHelper
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+10],8
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-30],rdi
       xor       ecx,ecx
       mov       [rbp-24],ecx
       mov       rcx,rdi
       call      00007FF86CA5E120
       test      eax,eax
       je        short M00_L03
M00_L02:
       mov       dword ptr [rbp-24],1
       cmp       qword ptr [rbx+8],0
       je        short M00_L04
       mov       rcx,rbx
       call      qword ptr [7FF80D0B5860]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rsi,rax
       jmp       short M00_L05
M00_L03:
       mov       rcx,rdi
       call      qword ptr [7FF80D1D5B78]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L02
M00_L04:
       mov       rsi,[rbx+18]
M00_L05:
       mov       rcx,rdi
       call      00007FF86CA5E040
       test      eax,eax
       jne       near ptr M00_L10
M00_L06:
       mov       rax,rsi
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M00_L07:
       mov       rcx,rdx
       mov       rdx,7FF80D1B8BA0
       call      qword ptr [7FF80CDDF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rbx,rax
       jmp       near ptr M00_L00
M00_L08:
       mov       rcx,rbx
       mov       rdx,7FF80D1B8D68
       call      qword ptr [7FF80CDDF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M00_L01
M00_L09:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,10E
       mov       rdx,7FF80D1C6CC8
       call      qword ptr [7FF80CDDF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80D0B75B8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L10:
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FF80D1D7C60]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       near ptr M00_L06
       sub       rsp,28
       cmp       dword ptr [rbp-24],0
       je        short M00_L11
       mov       rcx,[rbp-30]
       call      00007FF86CA5E040
       test      eax,eax
       je        short M00_L11
       mov       ecx,eax
       mov       rdx,[rbp-30]
       call      qword ptr [7FF80D1D7C60]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M00_L11:
       nop
       add       rsp,28
       ret
; Total bytes of code 416
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.__Canon, System.Private.CoreLib]](System.Threading.Tasks.Task`1<System.__Canon>)
       push      rbx
       sub       rsp,20
       mov       rbx,rdx
       mov       ecx,[rbx+34]
       and       ecx,11000000
       cmp       ecx,1000000
       jne       short M01_L01
M01_L00:
       mov       rax,[rbx+38]
       add       rsp,20
       pop       rbx
       ret
M01_L01:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF80D1D4E28]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 48
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
       call      qword ptr [7FF80D0B5890]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M02_L04
M02_L03:
       mov       rcx,rbx
       call      qword ptr [7FF80D1D5B78]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       jmp       qword ptr [7FF80D0B5860]
M02_L06:
       cmp       eax,8
       ja        short M02_L07
       mov       eax,eax
       lea       rdx,[7FF80CE54B90]
       mov       edx,[rdx+rax*4]
       lea       r8,[M02_L01]
       add       rdx,r8
       jmp       rdx
M02_L07:
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF80D1D7F48]
       int       3
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80D1DC1B0]
       jmp       short M02_L05
       mov       rcx,[rbp+10]
       xor       edx,edx
       call      qword ptr [7FF80D0B5890]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
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
       mov       rdx,7FF80D206178
       call      qword ptr [7FF80CDDF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L09:
       mov       rcx,[rax+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M02_L10
       jmp       short M02_L11
M02_L10:
       mov       rcx,rax
       mov       rdx,7FF80D206218
       call      qword ptr [7FF80CDDF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M02_L11:
       call      qword ptr [7FF80D1DC150]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80D1DC1C8]
       jmp       near ptr M02_L05
       mov       rcx,[rbp+10]
       mov       rdx,rbx
       call      qword ptr [7FF80D1DC1E0]
       jmp       near ptr M02_L05
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80D1DC1F8]
       jmp       near ptr M02_L05
       mov       rcx,[rbp+10]
       mov       rdx,rbx
       mov       r8d,1
       call      qword ptr [7FF80D0B5878]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M02_L05
M02_L12:
       mov       ecx,eax
       mov       rdx,rbx
       call      qword ptr [7FF80D1D7C60]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
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
       call      qword ptr [7FF80D1D7C60]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
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
       call      qword ptr [7FF80D1D4E40]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FF80D1DC450]
       jmp       short M06_L01
M06_L04:
       test      sil,2
       jne       short M06_L05
       mov       rcx,rbx
       call      qword ptr [7FF80D1DC270]
M06_L05:
       mov       rcx,rbx
       call      qword ptr [7FF80D1DC720]
       jmp       short M06_L02
; Total bytes of code 124
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.FirstCallBenchmarks`1[[System.__Canon, System.Private.CoreLib]].VsThreading()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+28]
       test      rdx,rdx
       je        short M00_L01
M00_L00:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,[rbx+8]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M00_L02
       lea       rcx,[rsi+20]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+10],rcx
       mov       rcx,rsi
       xor       edx,edx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF80D14FE58]; Microsoft.VisualStudio.Threading.AsyncLazy`1[[System.__Canon, System.Private.CoreLib]].GetValueAsync(System.Threading.CancellationToken)
M00_L01:
       mov       rdx,7FF80D1E46E8
       call      qword ptr [7FF80CDDF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M00_L00
M00_L02:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,164
       mov       rdx,7FF80D1C6CD8
       call      qword ptr [7FF80CDDF210]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF80D0B75B8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 198
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult[[System.__Canon, System.Private.CoreLib]](System.Threading.Tasks.Task`1<System.__Canon>)
       push      rbx
       sub       rsp,20
       mov       rbx,rdx
       mov       ecx,[rbx+34]
       and       ecx,11000000
       cmp       ecx,1000000
       jne       short M01_L01
M01_L00:
       mov       rax,[rbx+38]
       add       rsp,20
       pop       rbx
       ret
M01_L01:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF80D1F72D0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       short M01_L00
; Total bytes of code 48
```
```assembly
; Microsoft.VisualStudio.Threading.AsyncLazy`1[[System.__Canon, System.Private.CoreLib]].GetValueAsync(System.Threading.CancellationToken)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,128
       lea       rbp,[rsp+160]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu32 [rbp-0F0],zmm4
       vmovdqu32 [rbp-0B0],zmm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       xor       eax,eax
       mov       [rbp-50],rax
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       rsi,rcx
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        near ptr M02_L82
M02_L00:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0E8],rax
       lea       rcx,[rax+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+28]
       test      rcx,rcx
       jne       near ptr M02_L83
M02_L01:
       mov       rcx,[rsi+18]
       test      rcx,rcx
       jne       near ptr M02_L84
M02_L02:
       cmp       qword ptr [rsi+28],0
       jne       near ptr M02_L76
       mov       rcx,[rsi+8]
       test      rcx,rcx
       je        near ptr M02_L85
       call      00007FF86CA5DFD0
       test      eax,eax
       jne       near ptr M02_L86
       xor       ecx,ecx
       mov       rax,[rbp-0E8]
       mov       [rax+10],rcx
       mov       rdx,[rsi+8]
       mov       [rbp-0F0],rdx
       mov       [rbp-44],ecx
       cmp       qword ptr [rbp-0F0],0
       je        near ptr M02_L47
       mov       rcx,[rbp-0F0]
       call      00007FF86CA5E120
       test      eax,eax
       je        near ptr M02_L48
M02_L03:
       mov       dword ptr [rbp-44],1
       cmp       qword ptr [rsi+28],0
       jne       near ptr M02_L54
       cmp       qword ptr [rbp+18],0
       je        short M02_L04
       mov       rcx,[rbp+18]
       cmp       dword ptr [rcx+20],0
       jne       near ptr M02_L49
M02_L04:
       mov       rcx,offset MT_Microsoft.VisualStudio.Threading.InlineResumable
       call      CORINFO_HELP_NEWSFAST
       mov       r8,[rbp-0E8]
       lea       rcx,[r8+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsi+20]
       mov       r8,[rbp-0E8]
       lea       rcx,[r8+18]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+20],rcx
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+28]
       test      rdx,rdx
       je        near ptr M02_L11
M02_L05:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,[rbp-0E8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset Microsoft.VisualStudio.Threading.AsyncLazy`1+<>c__DisplayClass20_0[[System.__Canon, System.Private.CoreLib]].<GetValueAsync>b__0()
       mov       [rdi+18],rcx
       cmp       byte ptr [rsi+38],0
       jne       near ptr M02_L25
       cmp       qword ptr [rsi+18],0
       jne       near ptr M02_L50
M02_L06:
       mov       rcx,offset MT_Microsoft.VisualStudio.Threading.AsyncLocal<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,offset MT_System.Threading.AsyncLocal<System.Object>
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+38]
       test      rdx,rdx
       je        near ptr M02_L12
M02_L07:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       r14,[rax]
       mov       r15,[rbx+8]
       cmp       qword ptr [r15+8],0
       setne     r13b
       movzx     r13d,r13b
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M02_L51
       mov       rcx,[rcx+240]
       mov       r12,[rcx+20]
       test      r12,r12
       je        near ptr M02_L51
M02_L08:
       mov       rax,[r12+10]
       test      rax,rax
       jne       short M02_L09
       call      qword ptr [7FF80D0B5470]; System.Threading.Thread.InitializeCurrentThread()
M02_L09:
       mov       rax,[rax+8]
       mov       [rbp-0F8],rax
       xor       ecx,ecx
       mov       [rbp-50],rcx
       xor       r10d,r10d
       test      rax,rax
       je        short M02_L10
       mov       rcx,[rax+8]
       lea       r8,[rbp-50]
       mov       rdx,r15
       mov       r11,7FF80CD205A8
       call      qword ptr [r11]
       mov       [rbp-54],eax
       mov       rax,[rbp-0F8]
       mov       r10d,[rbp-54]
M02_L10:
       cmp       [rbp-50],r14
       je        near ptr M02_L24
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       [rbp-64],ecx
       test      rax,rax
       je        short M02_L13
       mov       [rbp-54],r10d
       movzx     edx,byte ptr [rax+18]
       mov       [rbp-64],edx
       test      r13d,r13d
       sete      r9b
       movzx     r9d,r9b
       mov       rcx,[rax+8]
       mov       rdx,r15
       mov       r8,r14
       mov       r11,7FF80CD205A0
       call      qword ptr [r11]
       mov       [rbp-100],rax
       mov       r8,[rbp-0F8]
       mov       r8,[r8+10]
       mov       [rbp-60],r8
       jmp       near ptr M02_L16
M02_L11:
       mov       rdx,7FF80D1E9FE0
       call      qword ptr [7FF80CDDF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M02_L05
M02_L12:
       mov       rdx,7FF80D1EA3F8
       call      qword ptr [7FF80CDDF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M02_L07
M02_L13:
       test      r14,r14
       je        near ptr M02_L52
       mov       [rbp-54],r10d
M02_L14:
       mov       rcx,offset MT_System.Threading.AsyncLocalValueMap+OneElementAsyncLocalValueMap
       call      CORINFO_HELP_NEWSFAST
       mov       r8,rax
       mov       [rbp-118],r8
       lea       rcx,[r8+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-118]
       lea       rcx,[r8+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,[rbp-118]
       mov       rax,r8
M02_L15:
       mov       [rbp-100],rax
M02_L16:
       test      r13d,r13d
       je        short M02_L18
       cmp       dword ptr [rbp-54],0
       jne       short M02_L18
       cmp       qword ptr [rbp-60],0
       je        short M02_L17
       mov       r8,[rbp-60]
       mov       r10d,[r8+8]
       mov       [rbp-68],r10d
       lea       r8d,[r10+1]
       lea       rdx,[rbp-60]
       mov       rcx,7FF80D211A90
       call      qword ptr [7FF80CFBC5D0]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       edx,[rbp-68]
       mov       rcx,[rbp-60]
       mov       r8,r15
       call      qword ptr [7FF80CDD57B8]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M02_L18
M02_L17:
       mov       rcx,offset MT_System.Threading.IAsyncLocal[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rbp-110],rax
       lea       rcx,[rax+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-110]
       mov       [rbp-60],rax
M02_L18:
       mov       r12,[r12+10]
       test      r12,r12
       jne       short M02_L19
       call      qword ptr [7FF80D0B5470]; System.Threading.Thread.InitializeCurrentThread()
       mov       r12,rax
M02_L19:
       cmp       dword ptr [rbp-64],0
       jne       short M02_L20
       mov       rcx,1F480001360
       mov       rax,[rbp-100]
       cmp       rax,[rcx]
       jne       short M02_L20
       xor       edx,edx
       jmp       short M02_L21
M02_L20:
       mov       rcx,offset MT_System.Threading.ExecutionContext
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       [rbp-108],rdx
       mov       rax,[rbp-60]
       mov       [rbp-120],rax
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-100]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-108]
       lea       rcx,[rdx+10]
       mov       rdx,[rbp-120]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-108]
       mov       ecx,[rbp-64]
       mov       [rdx+18],cl
M02_L21:
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      r13d,r13d
       je        short M02_L24
       mov       rdx,[rbp-50]
       test      rdx,rdx
       jne       near ptr M02_L44
       xor       r13d,r13d
M02_L22:
       test      r14,r14
       je        near ptr M02_L46
       mov       rcx,[r15]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       r12,r14
       cmp       [r12],rcx
       je        short M02_L23
       mov       rdx,r14
       call      qword ptr [7FF80CDD58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r12,rax
M02_L23:
       mov       rax,[r15+8]
       mov       [rbp-0E0],r13
       mov       [rbp-0D8],r12
       mov       byte ptr [rbp-0D0],0
       lea       rdx,[rbp-0E0]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
M02_L24:
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       [rbp-60],rcx
       lea       rcx,[rsi+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       nop
M02_L25:
       cmp       qword ptr [rsi+10],0
       jne       near ptr M02_L33
       mov       rcx,offset Microsoft.VisualStudio.Threading.AsyncLazy`1+<>c__DisplayClass20_0[[System.__Canon, System.Private.CoreLib]].<GetValueAsync>b__0()
       cmp       [rdi+18],rcx
       jne       near ptr M02_L42
       mov       rdi,[rdi+8]
       cmp       [rdi],edi
       xor       ecx,ecx
       mov       [rbp-78],rcx
       mov       [rbp-98],rdi
       mov       dword ptr [rbp-80],0FFFFFFFF
       mov       rcx,[rdi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M02_L30
       mov       rcx,rax
M02_L26:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+10]
       test      rax,rax
       je        short M02_L31
       mov       rcx,rax
M02_L27:
       lea       rdx,[rbp-98]
       call      qword ptr [7FF80D1F5350]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[Microsoft.VisualStudio.Threading.AsyncLazy`1+<>c__DisplayClass20_0+<<GetValueAsync>b__0>d[[System.__Canon, System.Private.CoreLib]], Microsoft.VisualStudio.Threading]](<<GetValueAsync>b__0>d<System.__Canon> ByRef)
       mov       rcx,[rdi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+10]
       test      rdx,rdx
       je        short M02_L32
M02_L28:
       mov       rax,[rbp-78]
       test      rax,rax
       je        near ptr M02_L41
M02_L29:
       lea       rcx,[rsi+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L43
M02_L30:
       mov       rdx,7FF80D1ED618
       call      qword ptr [7FF80CDDF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M02_L26
M02_L31:
       mov       rdx,7FF80D1ED820
       call      qword ptr [7FF80CDDF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M02_L27
M02_L32:
       mov       rdx,7FF80D1ED498
       call      qword ptr [7FF80CDDF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M02_L28
M02_L33:
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+30]
       test      rdx,rdx
       je        short M02_L34
       jmp       short M02_L35
M02_L34:
       mov       rdx,7FF80D1EA090
       call      qword ptr [7FF80CDDF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M02_L35:
       mov       rbx,[rsi+10]
       cmp       [rbx],bl
       mov       rcx,[rdx+18]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L36
       mov       rdx,rcx
       jmp       short M02_L37
M02_L36:
       mov       rcx,rdx
       mov       rdx,7FF80D2891F8
       call      qword ptr [7FF80CDDF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
M02_L37:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       [rsp+28],ecx
       mov       rcx,rbx
       mov       r8,rdi
       xor       r9d,r9d
       call      qword ptr [7FF80D1FF1E0]
       lea       rcx,[rsi+30]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lock or   dword ptr [rsp],0
       mov       rdi,[rsi+30]
       mov       rcx,[rdi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rbx,[rdx+10]
       test      rbx,rbx
       je        short M02_L38
       jmp       short M02_L39
M02_L38:
       mov       rdx,7FF80D289420
       call      qword ptr [7FF80CDDF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rbx,rax
M02_L39:
       mov       rcx,rdi
       call      qword ptr [7FF80D1FF2A0]
       mov       rdx,rax
       test      rdx,rdx
       je        short M02_L40
       mov       rcx,rbx
       cmp       [rdx],rcx
       je        short M02_L40
       mov       rdx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rdx,rax
M02_L40:
       lea       rcx,[rsi+28]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M02_L43
M02_L41:
       lea       rcx,[rbp-78]
       call      qword ptr [7FF80D1FE388]
       jmp       near ptr M02_L29
M02_L42:
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       jmp       near ptr M02_L29
M02_L43:
       call      M02_L97
       jmp       near ptr M02_L54
M02_L44:
       mov       rcx,[r15]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       r13,rdx
       cmp       [r13],rcx
       je        short M02_L45
       call      qword ptr [7FF80CDD58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r13,rax
M02_L45:
       jmp       near ptr M02_L22
M02_L46:
       xor       r12d,r12d
       jmp       near ptr M02_L23
M02_L47:
       xor       ecx,ecx
       call      qword ptr [7FF80D1FE340]
       int       3
M02_L48:
       mov       rcx,[rbp-0F0]
       call      qword ptr [7FF80D1FC420]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M02_L03
M02_L49:
       lea       rcx,[rbp+18]
       call      qword ptr [7FF80D1FE760]
       int       3
M02_L50:
       mov       rcx,7FF80D27B708
       call      qword ptr [7FF80D1F41F8]
       jmp       near ptr M02_L06
M02_L51:
       mov       ecx,4
       call      qword ptr [7FF80D1FE028]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r12,rax
       jmp       near ptr M02_L08
M02_L52:
       test      r13d,r13d
       jne       short M02_L53
       mov       rcx,1F480001360
       mov       r8,[rcx]
       mov       [rbp-54],r10d
       mov       rax,r8
       jmp       near ptr M02_L15
M02_L53:
       mov       [rbp-54],r10d
       jmp       near ptr M02_L14
M02_L54:
       mov       rcx,[rbp-0F0]
       call      00007FF86CA5E040
       test      eax,eax
       jne       near ptr M02_L87
M02_L55:
       mov       rdx,[rbp-0E8]
       mov       rcx,[rdx+10]
       test      rcx,rcx
       je        near ptr M02_L76
       mov       byte ptr [rcx+18],1
       mov       rbx,[rcx+8]
       xor       eax,eax
       mov       [rcx+8],rax
       mov       rsi,[rcx+10]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M02_L88
       mov       rcx,[rcx+240]
       mov       r12,[rcx+20]
       test      r12,r12
       je        near ptr M02_L88
M02_L56:
       mov       rax,[r12+10]
       test      rax,rax
       jne       short M02_L57
       call      qword ptr [7FF80D0B5470]; System.Threading.Thread.InitializeCurrentThread()
M02_L57:
       mov       rdi,[rax+10]
       mov       rax,[r12+10]
       test      rax,rax
       jne       short M02_L58
       call      qword ptr [7FF80D0B5470]; System.Threading.Thread.InitializeCurrentThread()
M02_L58:
       lea       rcx,[rax+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-130],rdi
       test      rbx,rbx
       je        near ptr M02_L74
       mov       rcx,offset System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1+AsyncStateMachineBox`1[[System.__Canon, System.Private.CoreLib],[Microsoft.VisualStudio.Threading.AsyncLazy`1+<>c__DisplayClass20_0+<<GetValueAsync>b__0>d[[System.__Canon, System.Private.CoreLib]], Microsoft.VisualStudio.Threading]].MoveNext()
       cmp       [rbx+18],rcx
       jne       near ptr M02_L73
       mov       rbx,[rbx+8]
       mov       rcx,1F480001358
       mov       rcx,[rcx]
       movzx     esi,byte ptr [rcx+9D]
       test      esi,esi
       jne       near ptr M02_L66
M02_L59:
       mov       r14,[rbx+10]
       test      r14,r14
       je        near ptr M02_L67
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        near ptr M02_L65
M02_L60:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       mov       rcx,r14
       mov       r8,rbx
       call      qword ptr [7FF80D1F5C68]; System.Threading.ExecutionContext.RunInternal(System.Threading.ExecutionContext, System.Threading.ContextCallback, System.Object)
M02_L61:
       mov       ecx,[rbx+34]
       test      ecx,1600000
       je        short M02_L64
       cmp       byte ptr [7FF80CD1B074],0
       jne       near ptr M02_L70
M02_L62:
       xor       ecx,ecx
       mov       [rbx+40],rcx
       mov       [rbx+48],rcx
       mov       [rbx+50],rcx
       mov       [rbx+58],rcx
       mov       [rbx+60],rcx
       mov       [rbx+68],rcx
       mov       [rbx+10],rcx
       mov       rcx,1F480001358
       mov       rcx,[rcx]
       cmp       byte ptr [rcx+9D],0
       je        short M02_L64
       movzx     eax,byte ptr [rcx+9D]
       mov       edx,[rcx+98]
       mov       rcx,[rcx+80]
       test      eax,eax
       je        short M02_L64
       test      edx,edx
       je        short M02_L63
       cmp       edx,3
       jl        short M02_L64
M02_L63:
       test      rcx,rcx
       je        near ptr M02_L71
       test      ecx,100
       jne       near ptr M02_L71
M02_L64:
       test      esi,esi
       je        near ptr M02_L74
       jmp       near ptr M02_L72
M02_L65:
       mov       rdx,7FF80D1EFDB8
       call      qword ptr [7FF80CDDF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M02_L60
M02_L66:
       mov       rcx,rbx
       call      qword ptr [7FF80D1F5C38]
       mov       edx,eax
       mov       rcx,1F480001358
       mov       rcx,[rcx]
       mov       r8d,2
       call      qword ptr [7FF80D1F5C50]
       jmp       near ptr M02_L59
M02_L67:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx+8]
       mov       rax,[rdx+20]
       test      rax,rax
       je        short M02_L68
       jmp       short M02_L69
M02_L68:
       mov       rdx,7FF80D1EFE28
       call      qword ptr [7FF80CDDF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L69:
       lea       rcx,[rbx+40]
       call      rax
       jmp       near ptr M02_L61
M02_L70:
       mov       rcx,rbx
       call      qword ptr [7FF80D1F77B0]
       jmp       near ptr M02_L62
M02_L71:
       mov       rcx,rbx
       call      qword ptr [7FF80D0B5608]; System.GC.SuppressFinalize(System.Object)
       jmp       near ptr M02_L64
M02_L72:
       mov       rcx,1F480001358
       mov       rcx,[rcx]
       mov       edx,2
       call      qword ptr [7FF80D1F5CB0]
       jmp       short M02_L74
M02_L73:
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       nop
M02_L74:
       mov       rax,[r12+10]
       test      rax,rax
       jne       short M02_L75
       call      qword ptr [7FF80D0B5470]; System.Threading.Thread.InitializeCurrentThread()
M02_L75:
       lea       rcx,[rax+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M02_L76:
       mov       rsi,[rbp+10]
       lock or   dword ptr [rsp],0
       mov       rcx,[rsi+30]
       test      rcx,rcx
       jne       near ptr M02_L89
       xor       eax,eax
M02_L77:
       test      rax,rax
       jne       short M02_L80
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rbx,[rdx+20]
       test      rbx,rbx
       je        short M02_L81
M02_L78:
       mov       rdi,[rsi+28]
       mov       rcx,[rbp+18]
       mov       [rbp-0C8],rcx
       test      rdi,rdi
       je        near ptr M02_L90
       cmp       qword ptr [rbp-0C8],0
       jne       near ptr M02_L91
M02_L79:
       mov       rax,rdi
M02_L80:
       add       rsp,128
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L81:
       mov       rdx,7FF80D1E8F48
       call      qword ptr [7FF80CDDF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rbx,rax
       jmp       short M02_L78
M02_L82:
       mov       rdx,7FF80D1E84C8
       call      qword ptr [7FF80CDDF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       near ptr M02_L00
M02_L83:
       test      dword ptr [rcx+34],1600000
       jne       near ptr M02_L02
       jmp       near ptr M02_L01
M02_L84:
       mov       rcx,[rcx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF80D1FF270]
       test      rax,rax
       je        near ptr M02_L02
       call      qword ptr [7FF80D1FF288]
       mov       rcx,rax
       mov       r8,1F4800014F0
       mov       r8,[r8]
       mov       rdx,1F425CBB360
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rcx,rax
       xor       eax,eax
       test      rcx,rcx
       cmove     rcx,rax
       call      qword ptr [7FF80D1F40D8]
       int       3
M02_L85:
       mov       ecx,707
       mov       rdx,7FF80CD14000
       call      qword ptr [7FF80CDDF210]
       mov       rcx,rax
       call      qword ptr [7FF80D1FE340]
       int       3
M02_L86:
       call      qword ptr [7FF80D1FF288]
       mov       rcx,rax
       mov       r8,1F4800014F0
       mov       r8,[r8]
       mov       rdx,1F425CBB360
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rcx,rax
       xor       eax,eax
       test      rcx,rcx
       cmove     rcx,rax
       call      qword ptr [7FF80D1F40D8]
       int       3
M02_L87:
       mov       ecx,eax
       mov       rdx,[rbp-0F0]
       call      qword ptr [7FF80D1FE358]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       near ptr M02_L55
M02_L88:
       mov       ecx,4
       call      qword ptr [7FF80D1FE028]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r12,rax
       jmp       near ptr M02_L56
M02_L89:
       mov       r8,[rbp+18]
       xor       edx,edx
       call      qword ptr [7FF80D1F41C8]
       jmp       near ptr M02_L77
M02_L90:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,170F
       mov       rdx,7FF80D1C6CD8
       call      qword ptr [7FF80CDDF210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF80D0B75B8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L91:
       test      dword ptr [rdi+34],1600000
       jne       near ptr M02_L79
       lea       rcx,[rbp-0C8]
       call      qword ptr [7FF80D1F7210]
       test      eax,eax
       je        short M02_L94
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M02_L92
       jmp       short M02_L93
M02_L92:
       mov       rcx,rbx
       mov       rdx,7FF80D225660
       call      qword ptr [7FF80CDDF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M02_L93:
       mov       rdx,[rbp-0C8]
       call      qword ptr [7FF80D1F7150]
       jmp       near ptr M02_L80
M02_L94:
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M02_L95
       jmp       short M02_L96
M02_L95:
       mov       rcx,rbx
       mov       rdx,7FF80D225598
       call      qword ptr [7FF80CDDF630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M02_L96:
       mov       rdx,rdi
       mov       r8,[rbp-0C8]
       call      qword ptr [7FF80D1F7108]
       jmp       near ptr M02_L80
M02_L97:
       sub       rsp,38
       mov       rsi,[rbp+10]
       mov       rcx,[rsi+18]
       test      rcx,rcx
       je        near ptr M02_L116
       mov       rbx,[rcx+8]
       cmp       qword ptr [rbx+8],0
       setne     r14b
       movzx     r14d,r14b
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],4
       jle       short M02_L98
       mov       rcx,[rcx+240]
       mov       r12,[rcx+20]
       test      r12,r12
       jne       short M02_L99
M02_L98:
       mov       ecx,4
       call      qword ptr [7FF80D1FE028]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r12,rax
M02_L99:
       mov       rax,[r12+10]
       test      rax,rax
       jne       short M02_L100
       call      qword ptr [7FF80D0B5470]; System.Threading.Thread.InitializeCurrentThread()
M02_L100:
       mov       r15,[rax+8]
       xor       ecx,ecx
       mov       [rbp-0A0],rcx
       xor       r13d,r13d
       test      r15,r15
       je        short M02_L101
       mov       rcx,[r15+8]
       lea       r8,[rbp-0A0]
       mov       rdx,rbx
       mov       r11,7FF80CD205C0
       call      qword ptr [r11]
       mov       r13d,eax
M02_L101:
       cmp       qword ptr [rbp-0A0],0
       je        near ptr M02_L115
       xor       ecx,ecx
       mov       [rbp-0A8],rcx
       mov       [rbp-0AC],ecx
       test      r15,r15
       je        short M02_L102
       movzx     edi,byte ptr [r15+18]
       test      r14d,r14d
       sete      r9b
       movzx     r9d,r9b
       mov       rcx,[r15+8]
       mov       rdx,rbx
       mov       r11,7FF80CD205B8
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       [rbp-128],rax
       mov       r8,[r15+10]
       mov       [rbp-0A8],r8
       jmp       short M02_L105
M02_L102:
       test      r14d,r14d
       jne       short M02_L103
       mov       rcx,1F480001360
       mov       r15,[rcx]
       jmp       short M02_L104
M02_L103:
       mov       rcx,offset MT_System.Threading.AsyncLocalValueMap+OneElementAsyncLocalValueMap
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[rbp-0C0]
       mov       r8,rbx
       mov       rdx,7FF80D24B2A8
       xor       r9d,r9d
       call      qword ptr [7FF80D1FE3E8]
       lea       rdi,[r15+8]
       lea       rsi,[rbp-0C0]
       call      CORINFO_HELP_ASSIGN_BYREF
       call      CORINFO_HELP_ASSIGN_BYREF
M02_L104:
       mov       [rbp-128],r15
       mov       edi,[rbp-0AC]
M02_L105:
       test      r14d,r14d
       je        short M02_L107
       test      r13d,r13d
       jne       short M02_L107
       cmp       qword ptr [rbp-0A8],0
       jne       short M02_L106
       mov       rcx,offset MT_System.Threading.IAsyncLocal[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r15,rax
       lea       rcx,[r15+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-0A8],r15
       jmp       short M02_L107
M02_L106:
       mov       r8,[rbp-0A8]
       mov       r15d,[r8+8]
       lea       r8d,[r15+1]
       lea       rdx,[rbp-0A8]
       mov       rcx,7FF80D211A90
       call      qword ptr [7FF80CFBC5D0]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       edx,r15d
       mov       rcx,[rbp-0A8]
       mov       r8,rbx
       call      qword ptr [7FF80CDD57B8]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M02_L107:
       mov       r12,[r12+10]
       test      r12,r12
       jne       short M02_L108
       call      qword ptr [7FF80D0B5470]; System.Threading.Thread.InitializeCurrentThread()
       mov       r12,rax
M02_L108:
       test      edi,edi
       jne       short M02_L109
       mov       rcx,1F480001360
       mov       rax,[rbp-128]
       cmp       rax,[rcx]
       je        short M02_L110
M02_L109:
       mov       rcx,offset MT_System.Threading.ExecutionContext
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r13,[rbp-0A8]
       lea       rcx,[r15+8]
       mov       rdx,[rbp-128]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r15+18],dil
       mov       rdx,r15
       jmp       short M02_L111
M02_L110:
       xor       edx,edx
M02_L111:
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      r14d,r14d
       je        short M02_L115
       mov       rdx,[rbp-0A0]
       test      rdx,rdx
       je        short M02_L113
       mov       rcx,[rbx]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       mov       rdi,rdx
       cmp       [rdi],rcx
       je        short M02_L112
       call      qword ptr [7FF80CDD58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
M02_L112:
       jmp       short M02_L114
M02_L113:
       xor       edi,edi
M02_L114:
       mov       rax,[rbx+8]
       mov       [rbp-0E0],rdi
       xor       edx,edx
       mov       [rbp-0D8],rdx
       mov       byte ptr [rbp-0D0],0
       lea       rdx,[rbp-0E0]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
M02_L115:
       xor       ecx,ecx
       mov       [rbp-0A0],rcx
       mov       [rbp-0A8],rcx
M02_L116:
       add       rsp,38
       ret
       sub       rsp,38
       cmp       dword ptr [rbp-44],0
       je        short M02_L118
       cmp       qword ptr [rbp-0F0],0
       jne       short M02_L117
       xor       ecx,ecx
       call      qword ptr [7FF80D1FE340]
       int       3
M02_L117:
       mov       rcx,[rbp-0F0]
       call      00007FF86CA5E040
       test      eax,eax
       je        short M02_L118
       mov       ecx,eax
       mov       rdx,[rbp-0F0]
       call      qword ptr [7FF80D1FE358]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M02_L118:
       nop
       add       rsp,38
       ret
       sub       rsp,38
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],4
       jle       short M02_L119
       mov       rcx,[rcx+240]
       mov       r12,[rcx+20]
       test      r12,r12
       jne       short M02_L120
M02_L119:
       mov       ecx,4
       call      qword ptr [7FF80D1FE028]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r12,rax
M02_L120:
       mov       rdi,[r12+10]
       test      rdi,rdi
       jne       short M02_L121
       call      qword ptr [7FF80D0B5470]; System.Threading.Thread.InitializeCurrentThread()
       mov       rdi,rax
M02_L121:
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-130]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,38
       ret
; Total bytes of code 4021
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
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      dword ptr [rbx+34],1600000
       jne       short M04_L00
       mov       rcx,rbx
       mov       edx,0FFFFFFFF
       xor       r8d,r8d
       call      qword ptr [7FF80D1F7300]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M04_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M04_L03
M04_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M04_L04
M04_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M04_L01
       mov       rcx,rbx
       call      qword ptr [7FF80D1FE640]
       jmp       short M04_L01
M04_L04:
       test      sil,2
       jne       short M04_L05
       mov       rcx,rbx
       call      qword ptr [7FF80D1FEDA8]
M04_L05:
       mov       rcx,rbx
       call      qword ptr [7FF80D1FF360]
       jmp       short M04_L02
; Total bytes of code 124
```

