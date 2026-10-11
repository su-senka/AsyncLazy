## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: DefaultJob)

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
       jmp       qword ptr [72C353EAC438]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
M00_L01:
       mov       rsi,72C3541C7248
       call      qword ptr [72C35365F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       short M00_L00
M00_L02:
       mov       edi,1817
       mov       rsi,72C352664000
       call      qword ptr [72C35365EF88]
       mov       rdi,rax
       call      qword ptr [72C3541ACAF8]
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
       call      qword ptr [72C3541ACB40]
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
       call      000072C3D18E6020
       test      eax,eax
       jne       short M02_L02
       mov       rdi,rbx
       call      qword ptr [72C3541ACC30]
M02_L02:
       mov       dword ptr [rbp-14],1
       mov       rdi,[rbp-20]
       cmp       [rdi+8],rbx
       jne       short M02_L03
       mov       esi,2
       call      qword ptr [72C353EAC468]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       nop
M02_L03:
       mov       rdi,rbx
       call      000072C3D18E6790
       test      eax,eax
       jne       near ptr M02_L11
M02_L04:
       mov       rdi,[rbp-20]
       cmp       qword ptr [rdi+8],0
       je        near ptr M02_L12
       add       rsp,28
       pop       rbx
       pop       rbp
       jmp       qword ptr [72C353EAC438]
M02_L05:
       cmp       eax,8
       ja        short M02_L06
       mov       eax,eax
       lea       rcx,[72C3536CB8B8]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M02_L01]
       add       rcx,rdx
       jmp       rcx
M02_L06:
       mov       rdi,[rbx+8]
       cmp       [rdi],edi
       call      qword ptr [72C3541ACC48]
       int       3
       mov       rdi,[rbp-20]
       call      qword ptr [72C3541ACBD0]
       jmp       short M02_L04
       mov       rdi,[rbp-20]
       xor       esi,esi
       call      qword ptr [72C353EAC468]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
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
       mov       rsi,72C3541CAEE8
       call      qword ptr [72C35365F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L08:
       mov       rdi,[rax+30]
       mov       rdi,[rdi]
       mov       rdi,[rdi+18]
       test      rdi,rdi
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rdi,rax
       mov       rsi,72C3541CAF88
       call      qword ptr [72C35365F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M02_L10:
       call      qword ptr [72C3541ACB70]
       mov       rdx,rax
       mov       rsi,rbx
       mov       rdi,[rbp-20]
       call      qword ptr [72C3541ACBE8]
       jmp       near ptr M02_L04
       mov       rdi,[rbp-20]
       mov       rsi,rbx
       call      qword ptr [72C3541ACC00]
       jmp       near ptr M02_L04
       mov       rdi,[rbp-20]
       call      qword ptr [72C3541ACC18]
       jmp       near ptr M02_L04
       mov       rdi,[rbp-20]
       mov       rsi,rbx
       mov       edx,1
       call      qword ptr [72C353EAC450]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M02_L04
M02_L11:
       mov       edi,eax
       mov       rsi,rbx
       call      qword ptr [72C3541ACB10]
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
       call      000072C3D18E6790
       test      eax,eax
       je        short M02_L13
       mov       edi,eax
       mov       rsi,[rbp-28]
       call      qword ptr [72C3541ACB10]
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
       call      qword ptr [72C3531FEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdx,[rbp-8C]
       mov       rsi,[rbp-94]
       mov       rdi,[rbp-9C]
       mov       ecx,[rbp-84]
       mov       r8,[rbp-0A4]
       call      qword ptr [rax]
       mov       rbx,rax
       lea       rdi,[rbp-80]
       call      qword ptr [72C3531FEF08]; CORINFO_HELP_JIT_PINVOKE_END
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

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: DefaultJob)

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
       jmp       qword ptr [7C4352EAC438]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
M00_L01:
       mov       rsi,7C43531C7248
       call      qword ptr [7C435265F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       short M00_L00
M00_L02:
       mov       edi,1817
       mov       rsi,7C4351664000
       call      qword ptr [7C435265EF88]
       mov       rdi,rax
       call      qword ptr [7C43531AE5B0]
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
       call      qword ptr [7C43531A73A8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
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
       call      00007C43D08E6020
       test      eax,eax
       jne       short M02_L02
       mov       rdi,rbx
       call      qword ptr [7C43531AEBF8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
M02_L02:
       mov       dword ptr [rbp-14],1
       mov       rdi,[rbp-20]
       cmp       [rdi+8],rbx
       jne       short M02_L03
       mov       esi,2
       call      qword ptr [7C4352EAC468]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       nop
M02_L03:
       mov       rdi,rbx
       call      00007C43D08E6790
       test      eax,eax
       jne       near ptr M02_L11
M02_L04:
       mov       rdi,[rbp-20]
       cmp       qword ptr [rdi+8],0
       je        near ptr M02_L12
       add       rsp,28
       pop       rbx
       pop       rbp
       jmp       qword ptr [7C4352EAC438]
M02_L05:
       cmp       eax,8
       ja        short M02_L06
       mov       eax,eax
       lea       rcx,[7C43526D6618]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M02_L01]
       add       rcx,rdx
       jmp       rcx
M02_L06:
       mov       rdi,[rbx+8]
       cmp       [rdi],edi
       call      qword ptr [7C43531AEC10]
       int       3
       mov       rdi,[rbp-20]
       call      qword ptr [7C43531AEB98]
       jmp       short M02_L04
       mov       rdi,[rbp-20]
       xor       esi,esi
       call      qword ptr [7C4352EAC468]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
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
       mov       rsi,7C4353222988
       call      qword ptr [7C435265F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L08:
       mov       rdi,[rax+30]
       mov       rdi,[rdi]
       mov       rdi,[rdi+18]
       test      rdi,rdi
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rdi,rax
       mov       rsi,7C4353222A28
       call      qword ptr [7C435265F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M02_L10:
       call      qword ptr [7C43531AEB38]
       mov       rdx,rax
       mov       rsi,rbx
       mov       rdi,[rbp-20]
       call      qword ptr [7C43531AEBB0]
       jmp       near ptr M02_L04
       mov       rdi,[rbp-20]
       mov       rsi,rbx
       call      qword ptr [7C43531AEBC8]
       jmp       near ptr M02_L04
       mov       rdi,[rbp-20]
       call      qword ptr [7C43531AEBE0]
       jmp       near ptr M02_L04
       mov       rdi,[rbp-20]
       mov       rsi,rbx
       mov       edx,1
       call      qword ptr [7C4352EAC450]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M02_L04
M02_L11:
       mov       edi,eax
       mov       rsi,rbx
       call      qword ptr [7C43531AE5C8]
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
       call      00007C43D08E6790
       test      eax,eax
       je        short M02_L13
       mov       edi,eax
       mov       rsi,[rbp-28]
       call      qword ptr [7C43531AE5C8]
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
       call      qword ptr [7C43521FEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdx,[rbp-8C]
       mov       rsi,[rbp-94]
       mov       rdi,[rbp-9C]
       mov       ecx,[rbp-84]
       mov       r8,[rbp-0A4]
       call      qword ptr [rax]
       mov       rbx,rax
       lea       rdi,[rbp-80]
       call      qword ptr [7C43521FEF08]; CORINFO_HELP_JIT_PINVOKE_END
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
       call      qword ptr [7C43531A73C0]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7C43531AEAD8]
       jmp       short M04_L01
M04_L04:
       test      r15b,2
       jne       short M04_L05
       mov       rdi,rbx
       call      qword ptr [7C43531AF120]
M04_L05:
       mov       rdi,rbx
       call      qword ptr [7C43531AF5E8]
       jmp       short M04_L02
; Total bytes of code 125
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: DefaultJob)

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
       jmp       qword ptr [7CFED35866D0]; System.Threading.Tasks.AsyncLazy`1[[System.__Canon, System.Private.CoreLib]].GetOrStartAttemptAsync(System.Threading.CancellationToken)
M00_L01:
       mov       rsi,7CFED35A9CB0
       call      qword ptr [7CFED2A3F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       short M00_L00
M00_L02:
       mov       edi,1
       mov       rsi,7CFED35BBE28
       call      qword ptr [7CFED2A3EF88]
       mov       rdi,rax
       call      qword ptr [7CFED358ECD0]
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
       call      qword ptr [7CFED3587408]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
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
       call      00007CFF50E74060
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
       mov       rdi,7CFF510A0D68
       mov       rax,7CFF518D6820
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
       call      qword ptr [7CFED328C048]; System.Threading.Thread.InitializeCurrentThread()
M02_L11:
       mov       rdi,[rax+8]
       test      rdi,rdi
       jne       near ptr M02_L48
       mov       rdi,7CEF10801388
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
       mov       rdi,7CEF10801398
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
       mov       rsi,7CFED35AA228
       call      qword ptr [7CFED2A3F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M02_L01
M02_L19:
       mov       rdi,r13
       mov       rsi,7CFED35AA238
       call      qword ptr [7CFED2A3F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M02_L02
M02_L20:
       cmp       [r14],rax
       jne       near ptr M02_L03
       mov       rdi,r14
       call      qword ptr [7CFED35867A8]
       test      eax,eax
       je        near ptr M02_L25
       mov       rdi,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdi,r14
       mov       rsi,7CFEC1C09F28
       call      qword ptr [7CFED3285260]
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
       jmp       qword ptr [7CFED3586748]
M02_L22:
       mov       rsi,7CFED35ACEB0
       call      qword ptr [7CFED2A3F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M02_L05
M02_L23:
       mov       rsi,7CFED35D7E60
       call      qword ptr [7CFED2A3F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M02_L06
M02_L24:
       mov       rdi,r13
       mov       rsi,7CFED35ACB38
       call      qword ptr [7CFED2A3F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       jmp       qword ptr [7CFED35867C0]; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.__Canon, System.Private.CoreLib]].WaitAsync(System.Threading.CancellationToken)
M02_L26:
       mov       rdi,r13
       mov       rsi,7CFED35AA430
       call      qword ptr [7CFED2A3F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M02_L07
M02_L27:
       mov       rdi,r13
       mov       rsi,7CFED35AC958
       call      qword ptr [7CFED2A3F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M02_L09
M02_L28:
       mov       rdi,r13
       mov       rsi,7CFED35D8188
       call      qword ptr [7CFED2A3F3A8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M02_L14
M02_L29:
       test      eax,eax
       jge       near ptr M02_L17
       mov       rsi,r13
       call      qword ptr [7CFED358EE08]
M02_L30:
       add       r14,78
       mov       edi,1
       xchg      edi,[r14]
       test      edi,edi
       jne       short M02_L31
       mov       rdi,7CEF108013C0
       mov       r14,[rdi]
       lea       rdi,[r14+160]
       lock inc  dword ptr [rdi]
       mov       rdi,r14
       call      qword ptr [7CFED3586C28]; System.Threading.PortableThreadPool+WorkerThread.MaybeAddWorkingWorker(System.Threading.PortableThreadPool)
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
       mov       rsi,7CFED35AA030
       call      qword ptr [7CFED2A3F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       jmp       qword ptr [7CFED3586670]
M02_L38:
       call      qword ptr [7CFED358EC58]
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
       mov       rsi,7CFED35AA430
       call      qword ptr [7CFED2A3F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rsi,7CFED35ACA40
       call      qword ptr [7CFED2A3F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M02_L43:
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rdi,r14
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rsi,[rax]
       test      rsi,rsi
       jne       short M02_L44
       call      qword ptr [7CFED358F2B8]
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
       mov       rsi,7CFED35AA430
       call      qword ptr [7CFED2A3F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M02_L46:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       lea       rdi,[rax+8]
       mov       rsi,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L08
M02_L47:
       mov       edi,4
       call      qword ptr [7CFED358E940]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
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
       mov       rsi,7CFED35D8320
       call      qword ptr [7CFED2A3F3A8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
M02_L51:
       mov       rdi,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdi,r13
       mov       rsi,r14
       mov       rdx,r12
       mov       rcx,[rbp-48]
       call      qword ptr [7CFED358EDC0]
       jmp       near ptr M02_L15
M02_L52:
       mov       rdi,7CEF108013B0
       mov       rdi,[rdi]
       cmp       byte ptr [rdi+9D],0
       je        near ptr M02_L16
       mov       rdi,7CEF108013B0
       mov       rdi,[rdi]
       mov       rsi,r13
       call      qword ptr [7CFED358EDD8]
       jmp       near ptr M02_L16
M02_L53:
       mov       rdi,r14
       call      qword ptr [7CFED3586E98]; System.Threading.PortableThreadPool+GateThread.EnsureRunningSlow(System.Threading.PortableThreadPool)
       jmp       near ptr M02_L31
M02_L54:
       mov       rdi,[r12+10]
       mov       r14,[rdi+8]
       cmp       [r14],r14b
       mov       rdi,offset MT_System.TimeProvider
       call      qword ptr [7CFED2A35728]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,7CEF10801480
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
       jmp       qword ptr [7CFED358F2D0]
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
       call      qword ptr [7CFED25DEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdx,[rbp-8C]
       mov       rsi,[rbp-94]
       mov       rdi,[rbp-9C]
       mov       ecx,[rbp-84]
       mov       r8,[rbp-0A4]
       call      qword ptr [rax]
       mov       rbx,rax
       lea       rdi,[rbp-80]
       call      qword ptr [7CFED25DEF08]; CORINFO_HELP_JIT_PINVOKE_END
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
       call      qword ptr [7CFED3587420]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7CFED358ECA0]
       jmp       short M04_L01
M04_L04:
       test      r15b,2
       jne       short M04_L05
       mov       rdi,rbx
       call      qword ptr [7CFED358EE50]
M04_L05:
       mov       rdi,rbx
       call      qword ptr [7CFED358F468]
       jmp       short M04_L02
; Total bytes of code 125
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: DefaultJob)

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
       call      000076DFE6C74060
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
       mov       rdi,76DFE6EA0D68
       mov       rax,76DFE76B8820
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
       call      qword ptr [76DF6907C048]; System.Threading.Thread.InitializeCurrentThread()
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
       mov       rsi,76DF6939B0E0
       call      qword ptr [76DF6882F3A8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rsi,76DF69399C10
       call      qword ptr [76DF6882F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M00_L00
M00_L21:
       mov       rsi,76DF6939A188
       call      qword ptr [76DF6882F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L22:
       mov       rsi,76DF6939A198
       call      qword ptr [76DF6882F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M00_L03
M00_L23:
       cmp       [r15],rax
       jne       near ptr M00_L04
       mov       rdi,r15
       call      qword ptr [76DF69376658]
       test      eax,eax
       je        near ptr M00_L28
       mov       rdi,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdi,r15
       mov       rsi,76DF64A09F28
       call      qword ptr [76DF69075260]
       mov       rdi,[rbx]
       mov       rsi,[rdi+30]
       mov       rsi,[rsi]
       mov       rax,[rsi+28]
       test      rax,rax
       je        short M00_L27
       mov       rdi,rax
M00_L24:
       mov       rsi,r15
       call      qword ptr [76DF69376610]
       jmp       near ptr M00_L19
M00_L25:
       mov       rsi,76DF6939A640
       call      qword ptr [76DF6882F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M00_L06
M00_L26:
       mov       rsi,76DF693E16F0
       call      qword ptr [76DF6882F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M00_L07
M00_L27:
       mov       rsi,76DF6939A2E0
       call      qword ptr [76DF6882F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       short M00_L24
M00_L28:
       mov       rdi,r15
       xor       esi,esi
       call      qword ptr [76DF69376670]; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.__Canon, System.Private.CoreLib]].WaitAsync(System.Threading.CancellationToken)
       jmp       near ptr M00_L19
M00_L29:
       mov       rsi,76DF6939AD80
       call      qword ptr [76DF6882F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M00_L08
M00_L30:
       mov       rsi,76DF6939AF58
       call      qword ptr [76DF6882F3A8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rbx,rax
       jmp       near ptr M00_L09
M00_L31:
       mov       edi,1
       mov       rsi,76DF693AB778
       call      qword ptr [76DF6882EF88]
       mov       rdi,rax
       call      qword ptr [76DF6937D668]
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
       mov       rsi,76DF69399F90
       call      qword ptr [76DF6882F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M00_L37:
       mov       rsi,[rbx+20]
       call      qword ptr [76DF69376580]
       jmp       near ptr M00_L19
M00_L38:
       call      qword ptr [76DF6937D5A8]
       int       3
M00_L39:
       mov       edi,4
       call      qword ptr [76DF6937D680]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L10
M00_L40:
       mov       rsi,[rbp-70]
       cmp       qword ptr [rsi+10],0
       je        near ptr M00_L17
M00_L41:
       mov       rdi,rbx
       mov       rsi,[rbp-70]
       call      qword ptr [76DF6937D620]
       jmp       near ptr M00_L17
M00_L42:
       lea       rdi,[rbp-38]
       call      qword ptr [76DF6937D638]
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
       call      qword ptr [76DF6937D620]
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
       call      qword ptr [76DF6937D4D0]
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
       call      qword ptr [76DF683CEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdi,[rbp-90]
       call      qword ptr [rax]
       lea       rdi,[rbp-88]
       call      qword ptr [76DF683CEF08]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-30]
       call      qword ptr [76DF683D0B98]
       lea       rdi,[rax+10]
       mov       rsi,[rbp-30]
       call      qword ptr [76DF683CEEB8]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [76DF683CEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdi,[rbp-8C]
       mov       rdx,[rbp-94]
       mov       rsi,[rbp-9C]
       mov       ecx,[rbp-84]
       mov       r8,[rbp-0A4]
       call      qword ptr [rax]
       mov       rbx,rax
       lea       rdi,[rbp-80]
       call      qword ptr [76DF683CEF08]; CORINFO_HELP_JIT_PINVOKE_END
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
       call      qword ptr [76DF683CEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdx,[rbp-8C]
       mov       rsi,[rbp-94]
       mov       rdi,[rbp-9C]
       mov       ecx,[rbp-84]
       mov       r8,[rbp-0A4]
       call      qword ptr [rax]
       mov       rbx,rax
       lea       rdi,[rbp-80]
       call      qword ptr [76DF683CEF08]; CORINFO_HELP_JIT_PINVOKE_END
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
       call      qword ptr [76DF68825728]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,76CFA48013C0
       mov       rdx,[rdx]
       mov       rcx,rbx
       mov       rdi,r15
       mov       esi,0FFFFFFFF
       add       rsp,8
       pop       rbx
       pop       r15
       jmp       qword ptr [76DF6937D920]
; Total bytes of code 92
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbp
       push      rbx
       push      rax
       lea       rbp,[rsp+10]
       mov       ebx,edi
       call      qword ptr [76DF683E6AF0]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: DefaultJob)

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
       jmp       qword ptr [7871C3D865E0]; System.Threading.Tasks.AsyncLazy`1[[System.__Canon, System.Private.CoreLib]].GetOrStartAttemptAsync(System.Threading.CancellationToken)
M00_L01:
       mov       rsi,7871C3DA9CA0
       call      qword ptr [7871C323F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       short M00_L00
M00_L02:
       mov       edi,1
       mov       rsi,7871C3DBB780
       call      qword ptr [7871C323EF88]
       mov       rdi,rax
       call      qword ptr [7871C3D8EA30]
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
       call      qword ptr [7871C3D872B8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
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
       call      0000787241674060
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
       mov       rdi,7872418A0D68
       mov       rax,787242218820
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
       call      qword ptr [7871C3A8C048]; System.Threading.Thread.InitializeCurrentThread()
M02_L11:
       mov       rdi,[rax+8]
       test      rdi,rdi
       jne       near ptr M02_L44
       mov       rdi,786200801388
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
       mov       rdi,786200801398
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
       mov       rsi,7871C3DAA218
       call      qword ptr [7871C323F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M02_L01
M02_L19:
       mov       rdi,r13
       mov       rsi,7871C3DAA228
       call      qword ptr [7871C323F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       jmp       qword ptr [7871C3D86670]; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.__Canon, System.Private.CoreLib]].WaitAsync(System.Threading.CancellationToken)
M02_L21:
       mov       rsi,7871C3DACDA8
       call      qword ptr [7871C323F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M02_L05
M02_L22:
       mov       rsi,7871C3DD6EC0
       call      qword ptr [7871C323F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M02_L06
M02_L23:
       mov       rdi,r13
       mov       rsi,7871C3DAA420
       call      qword ptr [7871C323F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M02_L07
M02_L24:
       mov       rdi,r13
       mov       rsi,7871C3DAC948
       call      qword ptr [7871C323F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M02_L09
M02_L25:
       mov       rdi,r13
       mov       rsi,7871C3DD71E8
       call      qword ptr [7871C323F3A8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M02_L14
M02_L26:
       test      eax,eax
       jge       near ptr M02_L17
       mov       rsi,r13
       call      qword ptr [7871C3D8EB68]
M02_L27:
       add       r14,78
       mov       edi,1
       xchg      edi,[r14]
       test      edi,edi
       jne       short M02_L28
       mov       rdi,7862008013C0
       mov       r14,[rdi]
       lea       rdi,[r14+160]
       lock inc  dword ptr [rdi]
       mov       rdi,r14
       call      qword ptr [7871C3D86AD8]; System.Threading.PortableThreadPool+WorkerThread.MaybeAddWorkingWorker(System.Threading.PortableThreadPool)
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
       mov       rsi,7871C3DAA020
       call      qword ptr [7871C323F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       jmp       qword ptr [7871C3D86580]
M02_L34:
       call      qword ptr [7871C3D8E9E8]
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
       mov       rsi,7871C3DAA420
       call      qword ptr [7871C323F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rsi,7871C3DACA30
       call      qword ptr [7871C323F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M02_L39:
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rdi,r14
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rsi,[rax]
       test      rsi,rsi
       jne       short M02_L40
       call      qword ptr [7871C3D8F048]
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
       mov       rsi,7871C3DAA420
       call      qword ptr [7871C323F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M02_L42:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       lea       rdi,[rax+8]
       mov       rsi,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L08
M02_L43:
       mov       edi,4
       call      qword ptr [7871C3D8E808]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
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
       mov       rsi,7871C3DD7380
       call      qword ptr [7871C323F3A8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
M02_L47:
       mov       rdi,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdi,r13
       mov       rsi,r14
       mov       rdx,r12
       mov       rcx,[rbp-48]
       call      qword ptr [7871C3D8EB20]
       jmp       near ptr M02_L15
M02_L48:
       mov       rdi,7862008013B0
       mov       rdi,[rdi]
       cmp       byte ptr [rdi+9D],0
       je        near ptr M02_L16
       mov       rdi,7862008013B0
       mov       rdi,[rdi]
       mov       rsi,r13
       call      qword ptr [7871C3D8EB38]
       jmp       near ptr M02_L16
M02_L49:
       mov       rdi,r14
       call      qword ptr [7871C3D86D48]; System.Threading.PortableThreadPool+GateThread.EnsureRunningSlow(System.Threading.PortableThreadPool)
       jmp       near ptr M02_L28
M02_L50:
       mov       rdi,[r12+10]
       mov       r14,[rdi+8]
       cmp       [r14],r14b
       mov       rdi,offset MT_System.TimeProvider
       call      qword ptr [7871C3235728]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,786200801470
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
       jmp       qword ptr [7871C3D8F060]
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
       call      qword ptr [7871C2DDEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdx,[rbp-8C]
       mov       rsi,[rbp-94]
       mov       rdi,[rbp-9C]
       mov       ecx,[rbp-84]
       mov       r8,[rbp-0A4]
       call      qword ptr [rax]
       mov       rbx,rax
       lea       rdi,[rbp-80]
       call      qword ptr [7871C2DDEF08]; CORINFO_HELP_JIT_PINVOKE_END
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
       call      qword ptr [7871C3D872D0]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7871C3D8EBB0]
       jmp       short M04_L01
M04_L04:
       test      r15b,2
       jne       short M04_L05
       mov       rdi,rbx
       call      qword ptr [7871C3D8EBE0]
M04_L05:
       mov       rdi,rbx
       call      qword ptr [7871C3D8F1F8]
       jmp       short M04_L02
; Total bytes of code 125
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: DefaultJob)

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
       call      000072B10E6E6020
       test      eax,eax
       je        short M00_L05
M00_L04:
       mov       dword ptr [rbp-24],1
       cmp       qword ptr [rbx+8],0
       je        short M00_L06
       mov       rdi,rbx
       call      qword ptr [72B090CAC438]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       r15,rax
       jmp       short M00_L07
M00_L05:
       mov       rdi,r14
       call      qword ptr [72B090FAEBE0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L04
M00_L06:
       mov       r15,[rbx+18]
M00_L07:
       mov       rdi,r14
       call      000072B10E6E6790
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
       mov       rsi,72B090FCBA18
       call      qword ptr [72B09045F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rbx,rax
       jmp       near ptr M00_L00
M00_L10:
       mov       rdi,rbx
       mov       rsi,72B090FCBE20
       call      qword ptr [72B09045F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M00_L01
M00_L11:
       mov       rdi,rbx
       mov       rsi,72B090FCBE48
       call      qword ptr [72B09045F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L12:
       mov       rdi,rbx
       mov       rsi,72B090FCBBE8
       call      qword ptr [72B09045F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M00_L03
M00_L13:
       mov       rdi,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       edi,10E
       mov       rsi,72B090FDBE30
       call      qword ptr [72B09045EF88]
       mov       rsi,rax
       mov       rdi,rbx
       call      qword ptr [72B090CADF68]
       mov       rdi,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L14:
       mov       edi,eax
       mov       rsi,r14
       call      qword ptr [72B090FAE418]
       jmp       near ptr M00_L08
       push      rax
       cmp       dword ptr [rbp-24],0
       je        short M00_L15
       mov       rdi,[rbp-38]
       call      000072B10E6E6790
       test      eax,eax
       je        short M00_L15
       mov       edi,eax
       mov       rsi,[rbp-38]
       call      qword ptr [72B090FAE418]
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
       call      qword ptr [72B090FA7450]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
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
       call      qword ptr [72B09045FAE0]
       int       3
M02_L02:
       mov       rsi,72B090FCC0A8
       call      qword ptr [72B09045F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       short M02_L00
M02_L03:
       mov       rdi,rsi
       mov       rsi,72B090FF7F38
       call      qword ptr [72B09045F3A8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r14,rax
       jmp       short M02_L01
M02_L04:
       mov       rdi,[r14+18]
       mov       rdi,[rdi+20]
       test      rdi,rdi
       je        near ptr M02_L09
M02_L05:
       call      qword ptr [72B090FA6718]; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].get_Factory()
       mov       rdi,[rax]
       mov       rsi,[rdi+30]
       mov       rsi,[rsi]
       mov       rsi,[rsi+18]
       test      rsi,rsi
       je        near ptr M02_L10
M02_L06:
       mov       rdi,72A0CC801390
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
       mov       rdi,72B10EAA0D68
       mov       rax,72B10F2F3820
       call      rax
       cmp       dword ptr [rax],4
       jle       near ptr M02_L33
       mov       rdi,[rax+8]
       mov       rax,[rdi+20]
       test      rax,rax
       je        near ptr M02_L33
M02_L07:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M02_L08
       call      qword ptr [72B090CAC048]; System.Threading.Thread.InitializeCurrentThread()
M02_L08:
       mov       r15,[rax+8]
       test      r15,r15
       jne       short M02_L11
       mov       rdi,72A0CC8013A0
       mov       r15,[rdi]
       jmp       short M02_L12
M02_L09:
       mov       rdi,r14
       mov       rsi,72B090FF80C8
       call      qword ptr [72B09045F3A8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M02_L05
M02_L10:
       mov       rsi,72B090FF8308
       call      qword ptr [72B09045F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M02_L06
M02_L11:
       xor       edi,edi
       cmp       byte ptr [r15+18],0
       cmovne    r15,rdi
M02_L12:
       test      r15,r15
       je        short M02_L13
       mov       rdi,72A0CC8013A0
       cmp       r15,[rdi]
       je        short M02_L14
       mov       rdi,r12
       call      qword ptr [72B090FAEDF0]
       lea       rdi,[rax+8]
       mov       rsi,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M02_L14
M02_L13:
       or        dword ptr [r12+34],20000000
M02_L14:
       mov       rdi,r12
       xor       esi,esi
       call      qword ptr [72B090FA68B0]; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
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
       call      qword ptr [72B09045F0D8]
       int       3
M02_L17:
       mov       rdi,r14
       mov       rsi,72B090FF8160
       call      qword ptr [72B09045F3A8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       short M02_L15
M02_L18:
       test      r14b,4
       je        short M02_L20
       mov       rdi,72B10EAA0D68
       mov       rax,72B10F2F3820
       call      rax
       cmp       dword ptr [rax],8
       jle       near ptr M02_L34
       mov       rdi,[rax+8]
       mov       rax,[rdi+40]
       test      rax,rax
       je        near ptr M02_L34
M02_L19:
       mov       r13,[rax+10]
       test      r13,r13
       je        short M02_L20
       mov       rdi,r15
       call      qword ptr [72B090FAEDF0]
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
       jne       near ptr M02_L35
M02_L21:
       mov       byte ptr [r15+41],1
       mov       rax,72A0CC8013B0
       mov       rax,[rax]
       cmp       byte ptr [rax+9D],0
       je        short M02_L23
       cmp       dword ptr [r15+30],0
       jne       short M02_L22
       call      qword ptr [72B090FAEA90]
       mov       esi,eax
       lea       rdi,[r15+30]
       xor       eax,eax
       lock cmpxchg [rdi],esi
M02_L22:
       mov       esi,[r15+30]
       mov       rdi,72A0CC8013B0
       mov       rdi,[rdi]
       mov       rdx,72B08C80AB58
       xor       ecx,ecx
       call      qword ptr [72B090FAEE08]
M02_L23:
       cmp       byte ptr [72B08F46B06C],0
       je        short M02_L24
       mov       rdi,r15
       call      qword ptr [72B090FAEE20]
M02_L24:
       test      dword ptr [r12+34],1600000
       jne       short M02_L27
       test      dword ptr [r12+34],1600000
       jne       short M02_L26
       cmp       qword ptr [r12+20],0
       jne       short M02_L25
       lea       rdi,[r12+20]
       test      rdi,rdi
       je        near ptr M02_L39
       mov       rsi,r15
       xor       edx,edx
       call      000072B10E874060
       test      rax,rax
       je        near ptr M02_L32
M02_L25:
       mov       rdi,r12
       mov       rsi,r15
       xor       edx,edx
       call      qword ptr [72B090FAC558]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M02_L32
M02_L26:
       mov       rdi,r15
       mov       rsi,r12
       call      qword ptr [72B090FEA240]; System.Threading.Tasks.UnwrapPromise`1[[System.__Canon, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
       jmp       near ptr M02_L32
M02_L27:
       mov       byte ptr [r15+40],1
       mov       rdi,r12
       call      qword ptr [72B090FA7918]; System.Threading.Tasks.Task.get_Status()
       cmp       eax,5
       jne       near ptr M02_L36
       mov       rdi,[r15]
       mov       rsi,[rdi+30]
       mov       rsi,[rsi+8]
       mov       rax,[rsi+20]
       test      rax,rax
       je        short M02_L29
       mov       rdi,rax
M02_L28:
       mov       rsi,r12
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M02_L37
       mov       edi,[rax+34]
       and       edi,11000000
       cmp       edi,1000000
       jne       short M02_L30
       mov       rsi,[rax+38]
       jmp       short M02_L31
M02_L29:
       mov       rsi,72B090FF6F48
       call      qword ptr [72B09045F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       short M02_L28
M02_L30:
       mov       rdi,rax
       mov       esi,1
       call      qword ptr [72B090FAEB20]
       mov       rsi,rax
M02_L31:
       mov       rdi,r15
       call      qword ptr [72B090FA7930]; System.Threading.Tasks.UnwrapPromise`1[[System.__Canon, System.Private.CoreLib]].ProcessInnerTask(System.Threading.Tasks.Task)
M02_L32:
       mov       rax,r15
       add       rsp,8
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L33:
       mov       edi,4
       call      qword ptr [72B090FAE580]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M02_L07
M02_L34:
       mov       edi,8
       call      qword ptr [72B090FAE580]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M02_L19
M02_L35:
       mov       rdi,[rdi+30]
       test      rdi,rdi
       je        near ptr M02_L21
       test      r14b,4
       je        near ptr M02_L21
       test      byte ptr [rdi+34],8
       jne       near ptr M02_L21
       call      qword ptr [72B090FAE490]
       jmp       near ptr M02_L21
M02_L36:
       add       eax,0FFFFFFFA
       cmp       eax,1
       ja        short M02_L32
       movzx     edx,byte ptr [r15+41]
       mov       rdi,r15
       mov       rsi,r12
       call      qword ptr [72B090FA7948]; System.Threading.Tasks.UnwrapPromise`1[[System.__Canon, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       jmp       short M02_L32
M02_L37:
       mov       rdi,r12
       mov       rax,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task>
       cmp       [rdi],rax
       je        short M02_L38
       mov       rsi,r12
       mov       rdi,rax
       call      qword ptr [72B090884AF8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rdi,rax
M02_L38:
       cmp       [rdi],edi
       call      qword ptr [72B090FA7960]; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].get_Result()
       mov       rsi,rax
       jmp       near ptr M02_L31
M02_L39:
       call      qword ptr [72B090FAE448]
       int       3
; Total bytes of code 1182
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
       call      000072B10E6E6020
       test      eax,eax
       je        short M03_L03
M03_L02:
       mov       dword ptr [rbp-14],1
       mov       rdi,[rbp-20]
       cmp       [rdi+8],rbx
       jne       short M03_L04
       mov       esi,2
       call      qword ptr [72B090CAC468]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M03_L04
M03_L03:
       mov       rdi,rbx
       call      qword ptr [72B090FAEBE0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M03_L02
M03_L04:
       mov       rdi,rbx
       call      000072B10E6E6790
       test      eax,eax
       jne       near ptr M03_L12
M03_L05:
       mov       rdi,[rbp-20]
       cmp       qword ptr [rdi+8],0
       je        near ptr M03_L13
       add       rsp,28
       pop       rbx
       pop       rbp
       jmp       qword ptr [72B090CAC438]
M03_L06:
       cmp       eax,8
       ja        short M03_L07
       mov       eax,eax
       lea       rcx,[72B0904D7820]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M03_L01]
       add       rcx,rdx
       jmp       rcx
M03_L07:
       mov       rdi,[rbx+8]
       cmp       [rdi],edi
       call      qword ptr [72B090FAECB8]
       int       3
       mov       rdi,[rbp-20]
       call      qword ptr [72B090FAEC58]
       jmp       short M03_L05
       mov       rdi,[rbp-20]
       xor       esi,esi
       call      qword ptr [72B090CAC468]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
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
       mov       rsi,72B090FF79A0
       call      qword ptr [72B09045F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M03_L09:
       mov       rdi,[rax+30]
       mov       rdi,[rdi]
       mov       rdi,[rdi+18]
       test      rdi,rdi
       je        short M03_L10
       jmp       short M03_L11
M03_L10:
       mov       rdi,rax
       mov       rsi,72B090FF7A40
       call      qword ptr [72B09045F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M03_L11:
       call      qword ptr [72B090FAEBF8]
       mov       rdx,rax
       mov       rsi,rbx
       mov       rdi,[rbp-20]
       call      qword ptr [72B090FAEC70]
       jmp       near ptr M03_L05
       mov       rdi,[rbp-20]
       mov       rsi,rbx
       call      qword ptr [72B090FAEC88]
       jmp       near ptr M03_L05
       mov       rdi,[rbp-20]
       call      qword ptr [72B090FAECA0]
       jmp       near ptr M03_L05
       mov       rdi,[rbp-20]
       mov       rsi,rbx
       mov       edx,1
       call      qword ptr [72B090CAC450]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M03_L05
M03_L12:
       mov       edi,eax
       mov       rsi,rbx
       call      qword ptr [72B090FAE418]
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
       call      000072B10E6E6790
       test      eax,eax
       je        short M03_L14
       mov       edi,eax
       mov       rsi,[rbp-28]
       call      qword ptr [72B090FAE418]
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
       call      qword ptr [72B08FFFEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdi,[rbp-90]
       call      qword ptr [rax]
       lea       rdi,[rbp-88]
       call      qword ptr [72B08FFFEF08]; CORINFO_HELP_JIT_PINVOKE_END
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
       call      qword ptr [72B08FFFEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdx,[rbp-8C]
       mov       rsi,[rbp-94]
       mov       rdi,[rbp-9C]
       mov       ecx,[rbp-84]
       mov       r8,[rbp-0A4]
       call      qword ptr [rax]
       mov       rbx,rax
       lea       rdi,[rbp-80]
       call      qword ptr [72B08FFFEF08]; CORINFO_HELP_JIT_PINVOKE_END
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
       jne       short M06_L00
       mov       rdi,rbx
       mov       esi,0FFFFFFFF
       xor       edx,edx
       call      qword ptr [72B090FA7468]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [72B090FAF1C8]
       jmp       short M06_L01
M06_L04:
       test      r15b,2
       jne       short M06_L05
       mov       rdi,rbx
       call      qword ptr [72B090FAF1E0]
M06_L05:
       mov       rdi,rbx
       call      qword ptr [72B090FAF6C0]
       jmp       short M06_L02
; Total bytes of code 125
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: DefaultJob)

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
       call      000072DCD72E6020
       test      eax,eax
       je        short M00_L03
M00_L02:
       mov       dword ptr [rbp-24],1
       cmp       qword ptr [rbx+8],0
       je        short M00_L04
       mov       rdi,rbx
       call      qword ptr [72DC5988C438]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       r15,rax
       jmp       short M00_L05
M00_L03:
       mov       rdi,r14
       call      qword ptr [72DC59B8CBE8]
       jmp       short M00_L02
M00_L04:
       mov       r15,[rbx+18]
M00_L05:
       mov       rdi,r14
       call      000072DCD72E6790
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
       mov       rsi,72DC59BABA18
       call      qword ptr [72DC5903F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rbx,rax
       jmp       near ptr M00_L00
M00_L08:
       mov       rdi,rbx
       mov       rsi,72DC59BABBE8
       call      qword ptr [72DC5903F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M00_L01
M00_L09:
       mov       rdi,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       edi,10E
       mov       rsi,72DC59BBBE30
       call      qword ptr [72DC5903EF88]
       mov       rsi,rax
       mov       rdi,rbx
       call      qword ptr [72DC5988DF68]
       mov       rdi,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L10:
       mov       edi,eax
       mov       rsi,r14
       call      qword ptr [72DC59B8CAE0]
       jmp       near ptr M00_L06
       push      rax
       cmp       dword ptr [rbp-24],0
       je        short M00_L11
       mov       rdi,[rbp-38]
       call      000072DCD72E6790
       test      eax,eax
       je        short M00_L11
       mov       edi,eax
       mov       rsi,[rbp-38]
       call      qword ptr [72DC59B8CAE0]
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
       call      qword ptr [72DC59B8CBA0]
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
       call      000072DCD72E6020
       test      eax,eax
       je        short M02_L03
M02_L02:
       mov       dword ptr [rbp-14],1
       mov       rdi,[rbp-20]
       cmp       [rdi+8],rbx
       jne       short M02_L04
       mov       esi,2
       call      qword ptr [72DC5988C468]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M02_L04
M02_L03:
       mov       rdi,rbx
       call      qword ptr [72DC59B8CBE8]
       jmp       short M02_L02
M02_L04:
       mov       rdi,rbx
       call      000072DCD72E6790
       test      eax,eax
       jne       near ptr M02_L12
M02_L05:
       mov       rdi,[rbp-20]
       cmp       qword ptr [rdi+8],0
       je        near ptr M02_L13
       add       rsp,28
       pop       rbx
       pop       rbp
       jmp       qword ptr [72DC5988C438]
M02_L06:
       cmp       eax,8
       ja        short M02_L07
       mov       eax,eax
       lea       rcx,[72DC590AC330]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M02_L01]
       add       rcx,rdx
       jmp       rcx
M02_L07:
       mov       rdi,[rbx+8]
       cmp       [rdi],edi
       call      qword ptr [72DC59B8CCC0]
       int       3
       mov       rdi,[rbp-20]
       call      qword ptr [72DC59B8CC60]
       jmp       short M02_L05
       mov       rdi,[rbp-20]
       xor       esi,esi
       call      qword ptr [72DC5988C468]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
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
       mov       rsi,72DC59BAFAE8
       call      qword ptr [72DC5903F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L09:
       mov       rdi,[rax+30]
       mov       rdi,[rdi]
       mov       rdi,[rdi+18]
       test      rdi,rdi
       je        short M02_L10
       jmp       short M02_L11
M02_L10:
       mov       rdi,rax
       mov       rsi,72DC59BAFB88
       call      qword ptr [72DC5903F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M02_L11:
       call      qword ptr [72DC59B8CC00]
       mov       rdx,rax
       mov       rsi,rbx
       mov       rdi,[rbp-20]
       call      qword ptr [72DC59B8CC78]
       jmp       near ptr M02_L05
       mov       rdi,[rbp-20]
       mov       rsi,rbx
       call      qword ptr [72DC59B8CC90]
       jmp       near ptr M02_L05
       mov       rdi,[rbp-20]
       call      qword ptr [72DC59B8CCA8]
       jmp       near ptr M02_L05
       mov       rdi,[rbp-20]
       mov       rsi,rbx
       mov       edx,1
       call      qword ptr [72DC5988C450]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M02_L05
M02_L12:
       mov       edi,eax
       mov       rsi,rbx
       call      qword ptr [72DC59B8CAE0]
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
       call      000072DCD72E6790
       test      eax,eax
       je        short M02_L14
       mov       edi,eax
       mov       rsi,[rbp-28]
       call      qword ptr [72DC59B8CAE0]
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
       call      qword ptr [72DC58BDEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdx,[rbp-8C]
       mov       rsi,[rbp-94]
       mov       rdi,[rbp-9C]
       mov       ecx,[rbp-84]
       mov       r8,[rbp-0A4]
       call      qword ptr [rax]
       mov       rbx,rax
       lea       rdi,[rbp-80]
       call      qword ptr [72DC58BDEF08]; CORINFO_HELP_JIT_PINVOKE_END
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

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: DefaultJob)

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
       jmp       qword ptr [7357161866E8]; Microsoft.VisualStudio.Threading.AsyncLazy`1[[System.__Canon, System.Private.CoreLib]].GetValueAsync(System.Threading.CancellationToken)
M00_L01:
       mov       rsi,7357161D46B0
       call      qword ptr [73571563F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       short M00_L00
M00_L02:
       mov       rdi,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       edi,164
       mov       rsi,7357161BBE40
       call      qword ptr [73571563EF88]
       mov       rsi,rax
       mov       rdi,r15
       call      qword ptr [735715E8DF68]
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
       call      qword ptr [73571618EF88]
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
       vmovdqu   ymmword ptr [rbp-0D0],ymm8
       vmovdqu   ymmword ptr [rbp-0B0],ymm8
       vmovdqu   ymmword ptr [rbp-90],ymm8
       vmovdqu   ymmword ptr [rbp-70],ymm8
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
       call      00007357938E5C00
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
       call      00007357938E6020
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
       mov       rdi,735793CA0D68
       mov       rax,73579467C820
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
       call      qword ptr [735715E8C048]; System.Threading.Thread.InitializeCurrentThread()
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
       mov       r11,735714650558
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
       mov       r11,735714650550
       call      qword ptr [r11]
       mov       [rbp-0E0],rax
       mov       rdx,[rbp-0D8]
       mov       rdx,[rdx+10]
       mov       [rbp-58],rdx
       jmp       near ptr M02_L16
M02_L11:
       mov       rsi,7357161D8F30
       call      qword ptr [73571563F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L05
M02_L12:
       mov       rsi,7357161D9338
       call      qword ptr [73571563F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdi,7357161F4F98
       call      qword ptr [735715A6C480]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       esi,[rbp-60]
       mov       rdi,[rbp-58]
       mov       rdx,r13
       call      qword ptr [7357156357A0]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
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
       call      qword ptr [735715E8C048]; System.Threading.Thread.InitializeCurrentThread()
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
       call      qword ptr [7357156358C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
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
       call      qword ptr [7357161879C0]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[Microsoft.VisualStudio.Threading.AsyncLazy`1+<>c__DisplayClass20_0+<<GetValueAsync>b__0>d[[System.__Canon, System.Private.CoreLib]], Microsoft.VisualStudio.Threading]](<<GetValueAsync>b__0>d<System.__Canon> ByRef)
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
       mov       rsi,7357161DC1B0
       call      qword ptr [73571563F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       short M02_L26
M02_L31:
       mov       rsi,7357161DC3A8
       call      qword ptr [73571563F3A8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       short M02_L27
M02_L32:
       mov       rsi,7357161DC028
       call      qword ptr [73571563F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rsi,7357161D8FE0
       call      qword ptr [73571563F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rsi,7357162193F8
       call      qword ptr [73571563F3A8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M02_L37:
       mov       rdi,r15
       mov       rsi,rcx
       mov       rdx,rbx
       xor       ecx,ecx
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [73571618F5B8]
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
       mov       rsi,735716219490
       call      qword ptr [73571563F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r15,rax
M02_L39:
       mov       rdi,rbx
       call      qword ptr [73571618F690]
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
       call      qword ptr [73571618F0C0]
       jmp       near ptr M02_L29
M02_L42:
       mov       rdi,[rbx+8]
       call      qword ptr [rbx+18]
       jmp       near ptr M02_L29
M02_L43:
       call      M02_L99
       jmp       near ptr M02_L56
M02_L44:
       mov       rdi,7347508013B0
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
       call      qword ptr [7357156358C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r12,rax
M02_L47:
       jmp       near ptr M02_L22
M02_L48:
       xor       eax,eax
       jmp       near ptr M02_L23
M02_L49:
       xor       edi,edi
       call      qword ptr [73571618F0F0]
       int       3
M02_L50:
       mov       rdi,[rbp-0D0]
       call      qword ptr [73571618F2A0]
       jmp       near ptr M02_L03
M02_L51:
       lea       rdi,[rbp-38]
       call      qword ptr [73571618F2B8]
       int       3
M02_L52:
       mov       rdi,735716241BB0
       call      qword ptr [735716186B50]
       jmp       near ptr M02_L06
M02_L53:
       mov       edi,4
       call      qword ptr [73571618EF40]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M02_L08
M02_L54:
       test      r12d,r12d
       jne       short M02_L55
       mov       rdi,7347508013B0
       mov       rsi,[rdi]
       mov       [rbp-4C],r8d
       mov       rax,rsi
       jmp       near ptr M02_L15
M02_L55:
       mov       [rbp-4C],r8d
       jmp       near ptr M02_L14
M02_L56:
       mov       rdi,[rbp-0D0]
       call      00007357938E6790
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
       mov       rdi,735793CA0D68
       mov       rax,73579467C820
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
       call      qword ptr [735715E8C048]; System.Threading.Thread.InitializeCurrentThread()
M02_L59:
       mov       r14,[rax+10]
       mov       rax,[r13+10]
       test      rax,rax
       jne       short M02_L60
       call      qword ptr [735715E8C048]; System.Threading.Thread.InitializeCurrentThread()
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
       mov       rdi,7347508013A8
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
       call      qword ptr [73571618C348]; System.Threading.ExecutionContext.RunInternal(System.Threading.ExecutionContext, System.Threading.ContextCallback, System.Object)
M02_L63:
       mov       edi,[rbx+34]
       test      edi,1600000
       je        short M02_L66
       cmp       byte ptr [73571464B06C],0
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
       mov       rsi,7357161DE870
       call      qword ptr [73571563F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M02_L62
M02_L68:
       mov       rdi,rbx
       call      qword ptr [73571618C318]
       mov       esi,eax
       mov       rdi,r15
       mov       edx,2
       call      qword ptr [73571618C330]
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
       mov       rsi,7357161DE8F8
       call      qword ptr [73571563F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L71:
       lea       rdi,[rbx+40]
       call      rax
       jmp       near ptr M02_L63
M02_L72:
       mov       rdi,rbx
       call      qword ptr [73571618C5E8]
       jmp       near ptr M02_L64
M02_L73:
       mov       rdi,rbx
       call      qword ptr [735715E86880]; System.GC.SuppressFinalize(System.Object)
       jmp       near ptr M02_L66
M02_L74:
       mov       rdi,r15
       mov       esi,2
       call      qword ptr [73571618C390]
       jmp       short M02_L76
M02_L75:
       mov       rdi,[rbx+8]
       call      qword ptr [rbx+18]
       nop
M02_L76:
       mov       rax,[r13+10]
       test      rax,rax
       jne       short M02_L77
       call      qword ptr [735715E8C048]; System.Threading.Thread.InitializeCurrentThread()
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
       mov       rsi,7357161D8E38
       call      qword ptr [73571563F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rbx,rax
       jmp       short M02_L80
M02_L84:
       mov       rdi,rsi
       mov       rsi,7357161D8400
       call      qword ptr [73571563F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L00
M02_L85:
       test      dword ptr [rdi+34],1600000
       jne       near ptr M02_L02
       jmp       near ptr M02_L01
M02_L86:
       mov       rdi,[rdi+8]
       cmp       [rdi],edi
       call      qword ptr [73571618F660]
       test      rax,rax
       je        near ptr M02_L02
       call      qword ptr [73571618F678]
       mov       rdi,rax
       mov       rdx,734750801418
       mov       rdx,[rdx]
       mov       rsi,735710A0A7B0
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rdi,rax
       xor       eax,eax
       test      rdi,rdi
       cmove     rdi,rax
       call      qword ptr [735716186A30]
       int       3
M02_L87:
       mov       edi,94D
       mov       rsi,735714644000
       call      qword ptr [73571563EF88]
       mov       rdi,rax
       call      qword ptr [73571618F0F0]
       int       3
M02_L88:
       call      qword ptr [73571618F678]
       mov       rdi,rax
       mov       rdx,734750801418
       mov       rdx,[rdx]
       mov       rsi,735710A0A7B0
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rdi,rax
       xor       eax,eax
       test      rdi,rdi
       cmove     rdi,rax
       call      qword ptr [735716186A30]
       int       3
M02_L89:
       mov       edi,eax
       mov       rsi,[rbp-0D0]
       call      qword ptr [73571618F108]
       jmp       near ptr M02_L57
M02_L90:
       mov       edi,4
       call      qword ptr [73571618EF40]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r13,rax
       jmp       near ptr M02_L58
M02_L91:
       mov       rdx,[rbp-38]
       xor       esi,esi
       call      qword ptr [735716186B20]
       jmp       near ptr M02_L79
M02_L92:
       mov       rdi,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       edi,170F
       mov       rsi,7357161BBE40
       call      qword ptr [73571563EF88]
       mov       rsi,rax
       mov       rdi,rbx
       call      qword ptr [735715E8DF68]
       mov       rdi,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L93:
       test      dword ptr [r15+34],1600000
       jne       near ptr M02_L81
       lea       rdi,[rbp-0B8]
       call      qword ptr [73571618C6D8]
       test      eax,eax
       je        short M02_L96
       mov       rdi,[rbx+18]
       mov       rdi,[rdi+20]
       test      rdi,rdi
       je        short M02_L94
       jmp       short M02_L95
M02_L94:
       mov       rdi,rbx
       mov       rsi,7357161DF778
       call      qword ptr [73571563F3A8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdi,rax
M02_L95:
       mov       rsi,[rbp-0B8]
       call      qword ptr [73571618C678]
       jmp       near ptr M02_L82
M02_L96:
       mov       rdi,[rbx+18]
       mov       rdi,[rdi+18]
       test      rdi,rdi
       je        short M02_L97
       jmp       short M02_L98
M02_L97:
       mov       rdi,rbx
       mov       rsi,7357161DF6C8
       call      qword ptr [73571563F3A8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdi,rax
M02_L98:
       mov       rsi,r15
       mov       rdx,[rbp-0B8]
       call      qword ptr [73571618C630]
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
       mov       rdi,735793CA0D68
       mov       rax,73579467C820
       call      rax
       cmp       dword ptr [rax],4
       jle       short M02_L100
       mov       rdi,[rax+8]
       mov       rcx,[rdi+20]
       test      rcx,rcx
       jne       short M02_L101
M02_L100:
       mov       edi,4
       call      qword ptr [73571618EF40]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rcx,rax
M02_L101:
       mov       r13,rcx
       mov       rax,[r13+10]
       test      rax,rax
       jne       short M02_L102
       call      qword ptr [735715E8C048]; System.Threading.Thread.InitializeCurrentThread()
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
       mov       r11,735714650570
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
       mov       r11,735714650568
       xor       edx,edx
       call      qword ptr [r11]
       mov       [rbp-110],rax
       mov       rdx,[r12+10]
       mov       [rbp-0A8],rdx
       jmp       short M02_L107
M02_L104:
       test      r14d,r14d
       jne       short M02_L105
       mov       rdi,7347508013B0
       mov       r12,[rdi]
       jmp       short M02_L106
M02_L105:
       mov       [rbp-9C],eax
       mov       rdi,offset MT_System.Threading.AsyncLocalValueMap+OneElementAsyncLocalValueMap
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rsi,r15
       mov       rdi,735716207B10
       xor       edx,edx
       call      qword ptr [73571618F000]
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
       mov       rdi,7357161F4F98
       call      qword ptr [735715A6C480]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       esi,r12d
       mov       rdi,[rbp-0A8]
       mov       rdx,r15
       call      qword ptr [7357156357A0]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M02_L109:
       mov       r13,[r13+10]
       test      r13,r13
       jne       short M02_L110
       call      qword ptr [735715E8C048]; System.Threading.Thread.InitializeCurrentThread()
       mov       r13,rax
M02_L110:
       mov       r12d,[rbp-0AC]
       test      r12d,r12d
       jne       short M02_L111
       mov       rdi,7347508013B0
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
       call      qword ptr [7357156358C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
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
       call      qword ptr [73571618F0F0]
       int       3
M02_L119:
       mov       rdi,[rbp-0D0]
       call      00007357938E6790
       test      eax,eax
       je        short M02_L120
       mov       edi,eax
       mov       rsi,[rbp-0D0]
       call      qword ptr [73571618F108]
M02_L120:
       nop
       add       rsp,18
       ret
       sub       rsp,18
       mov       rdi,735793CA0D68
       mov       rax,73579467C820
       call      rax
       cmp       dword ptr [rax],4
       jle       short M02_L121
       mov       rdi,[rax+8]
       mov       r13,[rdi+20]
       test      r13,r13
       jne       short M02_L122
M02_L121:
       mov       edi,4
       call      qword ptr [73571618EF40]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r13,rax
M02_L122:
       mov       r14,[r13+10]
       test      r14,r14
       jne       short M02_L123
       call      qword ptr [735715E8C048]; System.Threading.Thread.InitializeCurrentThread()
       mov       r14,rax
M02_L123:
       lea       rdi,[r14+10]
       mov       rsi,[rbp-138]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,18
       ret
; Total bytes of code 4256
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
       call      qword ptr [7357151DEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdx,[rbp-8C]
       mov       rsi,[rbp-94]
       mov       rdi,[rbp-9C]
       mov       ecx,[rbp-84]
       mov       r8,[rbp-0A4]
       call      qword ptr [rax]
       mov       rbx,rax
       lea       rdi,[rbp-80]
       call      qword ptr [7357151DEF08]; CORINFO_HELP_JIT_PINVOKE_END
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

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: DefaultJob)

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
       jmp       qword ptr [75D57C8AC438]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
M00_L01:
       mov       rsi,75D57CBC7248
       call      qword ptr [75D57C05F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       short M00_L00
M00_L02:
       mov       edi,1817
       mov       rsi,75D57B064000
       call      qword ptr [75D57C05EF88]
       mov       rdi,rax
       call      qword ptr [75D57CBAE8E0]
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
       call      qword ptr [75D57CBA7798]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
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
       call      000075D5FA2E6020
       test      eax,eax
       jne       short M02_L02
       mov       rdi,rbx
       call      qword ptr [75D57CBAEEC8]
M02_L02:
       mov       dword ptr [rbp-14],1
       mov       rdi,[rbp-20]
       cmp       [rdi+8],rbx
       jne       short M02_L03
       mov       esi,2
       call      qword ptr [75D57C8AC468]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       nop
M02_L03:
       mov       rdi,rbx
       call      000075D5FA2E6790
       test      eax,eax
       jne       near ptr M02_L11
M02_L04:
       mov       rdi,[rbp-20]
       cmp       qword ptr [rdi+8],0
       je        near ptr M02_L12
       add       rsp,28
       pop       rbx
       pop       rbp
       jmp       qword ptr [75D57C8AC438]
M02_L05:
       cmp       eax,8
       ja        short M02_L06
       mov       eax,eax
       lea       rcx,[75D57C0D4ED8]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M02_L01]
       add       rcx,rdx
       jmp       rcx
M02_L06:
       mov       rdi,[rbx+8]
       cmp       [rdi],edi
       call      qword ptr [75D57CBAEA60]
       int       3
       mov       rdi,[rbp-20]
       call      qword ptr [75D57CBAEE68]
       jmp       short M02_L04
       mov       rdi,[rbp-20]
       xor       esi,esi
       call      qword ptr [75D57C8AC468]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
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
       mov       rsi,75D57CC22868
       call      qword ptr [75D57C05F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L08:
       mov       rdi,[rax+30]
       mov       rdi,[rdi]
       mov       rdi,[rdi+18]
       test      rdi,rdi
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rdi,rax
       mov       rsi,75D57CC22908
       call      qword ptr [75D57C05F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M02_L10:
       call      qword ptr [75D57CBAEE08]
       mov       rdx,rax
       mov       rsi,rbx
       mov       rdi,[rbp-20]
       call      qword ptr [75D57CBAEE80]
       jmp       near ptr M02_L04
       mov       rdi,[rbp-20]
       mov       rsi,rbx
       call      qword ptr [75D57CBAEE98]
       jmp       near ptr M02_L04
       mov       rdi,[rbp-20]
       call      qword ptr [75D57CBAEEB0]
       jmp       near ptr M02_L04
       mov       rdi,[rbp-20]
       mov       rsi,rbx
       mov       edx,1
       call      qword ptr [75D57C8AC450]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M02_L04
M02_L11:
       mov       edi,eax
       mov       rsi,rbx
       call      qword ptr [75D57CBAE8F8]
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
       call      000075D5FA2E6790
       test      eax,eax
       je        short M02_L13
       mov       edi,eax
       mov       rsi,[rbp-28]
       call      qword ptr [75D57CBAE8F8]
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
       call      qword ptr [75D57BBFEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdx,[rbp-8C]
       mov       rsi,[rbp-94]
       mov       rdi,[rbp-9C]
       mov       ecx,[rbp-84]
       mov       r8,[rbp-0A4]
       call      qword ptr [rax]
       mov       rbx,rax
       lea       rdi,[rbp-80]
       call      qword ptr [75D57BBFEF08]; CORINFO_HELP_JIT_PINVOKE_END
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
       call      qword ptr [75D57CBA77B0]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [75D57CBAEDA8]
       jmp       short M04_L01
M04_L04:
       test      r15b,2
       jne       short M04_L05
       mov       rdi,rbx
       call      qword ptr [75D57CBAEA30]
M04_L05:
       mov       rdi,rbx
       call      qword ptr [75D57CBAF150]
       jmp       short M04_L02
; Total bytes of code 125
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: DefaultJob)

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
       jmp       qword ptr [705698E9C438]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
M00_L01:
       mov       rsi,7056991B7248
       call      qword ptr [70569864F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       short M00_L00
M00_L02:
       mov       edi,1817
       mov       rsi,705697654000
       call      qword ptr [70569864EF88]
       mov       rdi,rax
       call      qword ptr [70569919F1F8]
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
       call      qword ptr [7056991973A8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
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
       call      00007057168E6020
       test      eax,eax
       jne       short M02_L02
       mov       rdi,rbx
       call      qword ptr [70569919F240]; System.Threading.Monitor.Enter_Slowpath(System.Object)
M02_L02:
       mov       dword ptr [rbp-14],1
       mov       rdi,[rbp-20]
       cmp       [rdi+8],rbx
       jne       short M02_L03
       mov       esi,2
       call      qword ptr [705698E9C468]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       nop
M02_L03:
       mov       rdi,rbx
       call      00007057168E6790
       test      eax,eax
       jne       near ptr M02_L11
M02_L04:
       mov       rdi,[rbp-20]
       cmp       qword ptr [rdi+8],0
       je        near ptr M02_L12
       add       rsp,28
       pop       rbx
       pop       rbp
       jmp       qword ptr [705698E9C438]
M02_L05:
       cmp       eax,8
       ja        short M02_L06
       mov       eax,eax
       lea       rcx,[7056986CDD98]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M02_L01]
       add       rcx,rdx
       jmp       rcx
M02_L06:
       mov       rdi,[rbx+8]
       cmp       [rdi],edi
       call      qword ptr [70569919ED78]
       int       3
       mov       rdi,[rbp-20]
       call      qword ptr [70569919F8E8]
       jmp       short M02_L04
       mov       rdi,[rbp-20]
       xor       esi,esi
       call      qword ptr [705698E9C468]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
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
       mov       rsi,7056992177F8
       call      qword ptr [70569864F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L08:
       mov       rdi,[rax+30]
       mov       rdi,[rdi]
       mov       rdi,[rdi+18]
       test      rdi,rdi
       je        short M02_L09
       jmp       short M02_L10
M02_L09:
       mov       rdi,rax
       mov       rsi,705699217898
       call      qword ptr [70569864F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M02_L10:
       call      qword ptr [70569919F888]
       mov       rdx,rax
       mov       rsi,rbx
       mov       rdi,[rbp-20]
       call      qword ptr [70569919F900]
       jmp       near ptr M02_L04
       mov       rdi,[rbp-20]
       mov       rsi,rbx
       call      qword ptr [70569919F918]
       jmp       near ptr M02_L04
       mov       rdi,[rbp-20]
       call      qword ptr [70569919F930]
       jmp       near ptr M02_L04
       mov       rdi,[rbp-20]
       mov       rsi,rbx
       mov       edx,1
       call      qword ptr [705698E9C450]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M02_L04
M02_L11:
       mov       edi,eax
       mov       rsi,rbx
       call      qword ptr [70569919F258]
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
       call      00007057168E6790
       test      eax,eax
       je        short M02_L13
       mov       edi,eax
       mov       rsi,[rbp-28]
       call      qword ptr [70569919F258]
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
       call      qword ptr [7056981EEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdx,[rbp-8C]
       mov       rsi,[rbp-94]
       mov       rdi,[rbp-9C]
       mov       ecx,[rbp-84]
       mov       r8,[rbp-0A4]
       call      qword ptr [rax]
       mov       rbx,rax
       lea       rdi,[rbp-80]
       call      qword ptr [7056981EEF08]; CORINFO_HELP_JIT_PINVOKE_END
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
       call      qword ptr [7056991973C0]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [70569919F858]
       jmp       short M04_L01
M04_L04:
       test      r15b,2
       jne       short M04_L05
       mov       rdi,rbx
       call      qword ptr [70569919F420]
M04_L05:
       mov       rdi,rbx
       call      qword ptr [70569919FC78]
       jmp       short M04_L02
; Total bytes of code 125
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: DefaultJob)

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
       jmp       qword ptr [7F7B6DFA65E0]; System.Threading.Tasks.AsyncLazy`1[[System.__Canon, System.Private.CoreLib]].GetOrStartAttemptAsync(System.Threading.CancellationToken)
M00_L01:
       mov       rsi,7F7B6DFC9CB0
       call      qword ptr [7F7B6D45F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       short M00_L00
M00_L02:
       mov       edi,1
       mov       rsi,7F7B6DFDB770
       call      qword ptr [7F7B6D45EF88]
       mov       rdi,rax
       call      qword ptr [7F7B6DFAFC60]
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
       call      qword ptr [7F7B6DFA7318]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
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
       call      00007F7BEB874060
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
       mov       rdi,7F7BEBAA0D68
       mov       rax,7F7BEC449820
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
       call      qword ptr [7F7B6DCAC048]; System.Threading.Thread.InitializeCurrentThread()
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
       mov       rdi,7F6BA8801398
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
       mov       rsi,7F7B6DFCA228
       call      qword ptr [7F7B6D45F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M02_L01
M02_L19:
       mov       rdi,r13
       mov       rsi,7F7B6DFCA238
       call      qword ptr [7F7B6D45F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M02_L02
M02_L20:
       cmp       [r14],rax
       jne       near ptr M02_L03
       mov       rdi,r14
       call      qword ptr [7F7B6DFA66B8]
       test      eax,eax
       je        near ptr M02_L25
       mov       rdi,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdi,r14
       mov       rsi,7F7B68809F28
       call      qword ptr [7F7B6DCA5260]
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
       jmp       qword ptr [7F7B6DFA6658]
M02_L22:
       mov       rsi,7F7B6DFCCEB0
       call      qword ptr [7F7B6D45F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M02_L05
M02_L23:
       mov       rsi,7F7B6DFFD368
       call      qword ptr [7F7B6D45F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M02_L06
M02_L24:
       mov       rdi,r13
       mov       rsi,7F7B6DFCCB38
       call      qword ptr [7F7B6D45F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       jmp       qword ptr [7F7B6DFA66D0]; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.__Canon, System.Private.CoreLib]].WaitAsync(System.Threading.CancellationToken)
M02_L26:
       mov       rdi,r13
       mov       rsi,7F7B6DFCA430
       call      qword ptr [7F7B6D45F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M02_L07
M02_L27:
       mov       rdi,r13
       mov       rsi,7F7B6DFCC958
       call      qword ptr [7F7B6D45F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M02_L09
M02_L28:
       mov       rdi,7F6BA8801388
       mov       rdi,[rdi]
       mov       rax,rdi
       mov       rdi,rax
       jmp       near ptr M02_L12
M02_L29:
       mov       rdi,r13
       mov       rsi,7F7B6DFFD648
       call      qword ptr [7F7B6D45F3A8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M02_L14
M02_L30:
       test      eax,eax
       jge       near ptr M02_L17
       mov       rsi,r13
       call      qword ptr [7F7B6DFAF6F0]
M02_L31:
       add       r14,78
       mov       edi,1
       xchg      edi,[r14]
       test      edi,edi
       jne       short M02_L32
       mov       rdi,7F6BA88013C0
       mov       r14,[rdi]
       lea       rdi,[r14+160]
       lock inc  dword ptr [rdi]
       mov       rdi,r14
       call      qword ptr [7F7B6DFA6B38]; System.Threading.PortableThreadPool+WorkerThread.MaybeAddWorkingWorker(System.Threading.PortableThreadPool)
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
       mov       rsi,7F7B6DFCA030
       call      qword ptr [7F7B6D45F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       jmp       qword ptr [7F7B6DFA6580]
M02_L39:
       call      qword ptr [7F7B6DFAF660]
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
       mov       rsi,7F7B6DFCA430
       call      qword ptr [7F7B6D45F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rsi,7F7B6DFCCA40
       call      qword ptr [7F7B6D45F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M02_L44:
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rdi,r14
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rsi,[rax]
       test      rsi,rsi
       jne       short M02_L45
       call      qword ptr [7F7B6E064258]
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
       mov       rsi,7F7B6DFCA430
       call      qword ptr [7F7B6D45F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M02_L47:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       lea       rdi,[rax+8]
       mov       rsi,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L08
M02_L48:
       mov       edi,4
       call      qword ptr [7F7B6DFAF510]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M02_L10
M02_L49:
       mov       rsi,[r13+18]
       mov       rsi,[rsi+20]
       test      rsi,rsi
       je        short M02_L50
       jmp       short M02_L51
M02_L50:
       mov       rdi,r13
       mov       rsi,7F7B6DFFD7E0
       call      qword ptr [7F7B6D45F3A8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
M02_L51:
       mov       rdi,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdi,r13
       mov       rsi,r14
       mov       rdx,r12
       mov       rcx,[rbp-48]
       call      qword ptr [7F7B6DFAFD20]
       jmp       near ptr M02_L15
M02_L52:
       mov       rdi,7F6BA88013B0
       mov       rdi,[rdi]
       cmp       byte ptr [rdi+9D],0
       je        near ptr M02_L16
       mov       rdi,7F6BA88013B0
       mov       rdi,[rdi]
       mov       rsi,r13
       call      qword ptr [7F7B6DFAF6D8]
       jmp       near ptr M02_L16
M02_L53:
       mov       rdi,r14
       call      qword ptr [7F7B6DFA6DA8]; System.Threading.PortableThreadPool+GateThread.EnsureRunningSlow(System.Threading.PortableThreadPool)
       jmp       near ptr M02_L32
M02_L54:
       mov       rdi,[r12+10]
       mov       r14,[rdi+8]
       cmp       [r14],r14b
       mov       rdi,offset MT_System.TimeProvider
       call      qword ptr [7F7B6D455728]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,7F6BA88014F8
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
       jmp       qword ptr [7F7B6E064270]
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
       call      qword ptr [7F7B6CFFEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdx,[rbp-8C]
       mov       rsi,[rbp-94]
       mov       rdi,[rbp-9C]
       mov       ecx,[rbp-84]
       mov       r8,[rbp-0A4]
       call      qword ptr [rax]
       mov       rbx,rax
       lea       rdi,[rbp-80]
       call      qword ptr [7F7B6CFFEF08]; CORINFO_HELP_JIT_PINVOKE_END
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
       call      qword ptr [7F7B6DFA7330]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7F7B6DFAFC48]
       jmp       short M04_L01
M04_L04:
       test      r15b,2
       jne       short M04_L05
       mov       rdi,rbx
       call      qword ptr [7F7B6DFAFD68]
M04_L05:
       mov       rdi,rbx
       call      qword ptr [7F7B6E064288]
       jmp       short M04_L02
; Total bytes of code 125
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: DefaultJob)

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
       call      00007770F6274060
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
       mov       rdi,7770F64A0D68
       mov       rax,7770F6DA2820
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
       call      qword ptr [7770786AC048]; System.Threading.Thread.InitializeCurrentThread()
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
       mov       rsi,7770789CB0E0
       call      qword ptr [777077E5F3A8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       mov       rsi,7770789C9C10
       call      qword ptr [777077E5F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M00_L00
M00_L22:
       mov       rsi,7770789CA188
       call      qword ptr [777077E5F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L23:
       mov       rsi,7770789CA198
       call      qword ptr [777077E5F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M00_L03
M00_L24:
       cmp       [r15],rax
       jne       near ptr M00_L04
       mov       rdi,r15
       call      qword ptr [7770789A6658]
       test      eax,eax
       je        near ptr M00_L29
       mov       rdi,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdi,r15
       mov       rsi,777074209F28
       call      qword ptr [7770786A5260]
       mov       rdi,[rbx]
       mov       rsi,[rdi+30]
       mov       rsi,[rsi]
       mov       rax,[rsi+28]
       test      rax,rax
       je        short M00_L28
       mov       rdi,rax
M00_L25:
       mov       rsi,r15
       call      qword ptr [7770789A6610]
       jmp       near ptr M00_L19
M00_L26:
       mov       rsi,7770789CA640
       call      qword ptr [777077E5F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M00_L06
M00_L27:
       mov       rsi,777078A0AC90
       call      qword ptr [777077E5F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M00_L07
M00_L28:
       mov       rsi,7770789CA2E0
       call      qword ptr [777077E5F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       short M00_L25
M00_L29:
       mov       rdi,r15
       xor       esi,esi
       call      qword ptr [7770789A6670]; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.__Canon, System.Private.CoreLib]].WaitAsync(System.Threading.CancellationToken)
       jmp       near ptr M00_L19
M00_L30:
       mov       rsi,7770789CAD80
       call      qword ptr [777077E5F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M00_L08
M00_L31:
       mov       rsi,7770789CAF58
       call      qword ptr [777077E5F3A8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rbx,rax
       jmp       near ptr M00_L09
M00_L32:
       mov       edi,1
       mov       rsi,7770789DB778
       call      qword ptr [777077E5EF88]
       mov       rdi,rax
       call      qword ptr [7770789AFC18]
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
       mov       rsi,7770789C9F90
       call      qword ptr [777077E5F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M00_L38:
       mov       rsi,[rbx+20]
       call      qword ptr [7770789A6580]
       jmp       near ptr M00_L19
M00_L39:
       call      qword ptr [7770789AF1E0]
       int       3
M00_L40:
       mov       edi,4
       call      qword ptr [7770789AF3D8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L10
M00_L41:
       mov       rdi,rbx
       mov       rsi,[rbp-70]
       call      qword ptr [7770789AF1F8]
       jmp       near ptr M00_L17
M00_L42:
       lea       rdi,[rbp-38]
       call      qword ptr [7770789AF9A8]
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
       call      qword ptr [7770789AF1F8]
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
       call      qword ptr [7770789AC2A0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
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
       call      qword ptr [7770779FEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdi,[rbp-90]
       call      qword ptr [rax]
       lea       rdi,[rbp-88]
       call      qword ptr [7770779FEF08]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-30]
       call      qword ptr [777077A00B98]
       lea       rdi,[rax+10]
       mov       rsi,[rbp-30]
       call      qword ptr [7770779FEEB8]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7770779FEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdi,[rbp-8C]
       mov       rdx,[rbp-94]
       mov       rsi,[rbp-9C]
       mov       ecx,[rbp-84]
       mov       r8,[rbp-0A4]
       call      qword ptr [rax]
       mov       rbx,rax
       lea       rdi,[rbp-80]
       call      qword ptr [7770779FEF08]; CORINFO_HELP_JIT_PINVOKE_END
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
       call      qword ptr [7770779FEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdx,[rbp-8C]
       mov       rsi,[rbp-94]
       mov       rdi,[rbp-9C]
       mov       ecx,[rbp-84]
       mov       r8,[rbp-0A4]
       call      qword ptr [rax]
       mov       rbx,rax
       lea       rdi,[rbp-80]
       call      qword ptr [7770779FEF08]; CORINFO_HELP_JIT_PINVOKE_END
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
       call      qword ptr [777077E55728]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,7760B48014D8
       mov       rdx,[rdx]
       mov       rcx,rbx
       mov       rdi,r15
       mov       esi,0FFFFFFFF
       add       rsp,8
       pop       rbx
       pop       r15
       jmp       qword ptr [7770789AFF30]
; Total bytes of code 92
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbp
       push      rbx
       push      rax
       lea       rbp,[rsp+10]
       mov       ebx,edi
       call      qword ptr [777077A16AF0]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       call      qword ptr [7770789AC2B8]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7770789AFC00]
       jmp       short M08_L01
M08_L04:
       test      r15b,2
       jne       short M08_L05
       mov       rdi,rbx
       call      qword ptr [7770789AF9F0]
M08_L05:
       mov       rdi,rbx
       call      qword ptr [7770789AFF48]
       jmp       short M08_L02
; Total bytes of code 125
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: DefaultJob)

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
       jmp       qword ptr [7CB4DE1966D0]; System.Threading.Tasks.AsyncLazy`1[[System.__Canon, System.Private.CoreLib]].GetOrStartAttemptAsync(System.Threading.CancellationToken)
M00_L01:
       mov       rsi,7CB4DE1B9CA0
       call      qword ptr [7CB4DD64F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       short M00_L00
M00_L02:
       mov       edi,1
       mov       rsi,7CB4DE1CBE38
       call      qword ptr [7CB4DD64EF88]
       mov       rdi,rax
       call      qword ptr [7CB4DE19F7B0]
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
       call      qword ptr [7CB4DE1973A8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
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
       call      00007CB55BA74060
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
       mov       rdi,7CB55BCA0D68
       mov       rax,7CB55C69E820
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
       call      qword ptr [7CB4DDE9C048]; System.Threading.Thread.InitializeCurrentThread()
M02_L11:
       mov       rdi,[rax+8]
       test      rdi,rdi
       jne       near ptr M02_L44
       mov       rdi,7CA518801388
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
       mov       rdi,7CA518801398
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
       mov       rsi,7CB4DE1BA218
       call      qword ptr [7CB4DD64F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M02_L01
M02_L19:
       mov       rdi,r13
       mov       rsi,7CB4DE1BA228
       call      qword ptr [7CB4DD64F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       jmp       qword ptr [7CB4DE196760]; System.Threading.Tasks.AsyncLazy`1+Attempt[[System.__Canon, System.Private.CoreLib]].WaitAsync(System.Threading.CancellationToken)
M02_L21:
       mov       rsi,7CB4DE1BCDA8
       call      qword ptr [7CB4DD64F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M02_L05
M02_L22:
       mov       rsi,7CB4DE1EA848
       call      qword ptr [7CB4DD64F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M02_L06
M02_L23:
       mov       rdi,r13
       mov       rsi,7CB4DE1BA420
       call      qword ptr [7CB4DD64F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M02_L07
M02_L24:
       mov       rdi,r13
       mov       rsi,7CB4DE1BC948
       call      qword ptr [7CB4DD64F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r13,rax
       jmp       near ptr M02_L09
M02_L25:
       mov       rdi,r13
       mov       rsi,7CB4DE1EAB28
       call      qword ptr [7CB4DD64F3A8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M02_L14
M02_L26:
       test      eax,eax
       jge       near ptr M02_L17
       mov       rsi,r13
       call      qword ptr [7CB4DE19F540]
M02_L27:
       add       r14,78
       mov       edi,1
       xchg      edi,[r14]
       test      edi,edi
       jne       short M02_L28
       mov       rdi,7CA5188013C0
       mov       r14,[rdi]
       lea       rdi,[r14+160]
       lock inc  dword ptr [rdi]
       mov       rdi,r14
       call      qword ptr [7CB4DE196BC8]; System.Threading.PortableThreadPool+WorkerThread.MaybeAddWorkingWorker(System.Threading.PortableThreadPool)
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
       mov       rsi,7CB4DE1BA020
       call      qword ptr [7CB4DD64F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       jmp       qword ptr [7CB4DE196670]
M02_L34:
       call      qword ptr [7CB4DE19F360]
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
       mov       rsi,7CB4DE1BA420
       call      qword ptr [7CB4DD64F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rsi,7CB4DE1BCA30
       call      qword ptr [7CB4DD64F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M02_L39:
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rdi,r14
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rsi,[rax]
       test      rsi,rsi
       jne       short M02_L40
       call      qword ptr [7CB4DE19FFC0]
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
       mov       rsi,7CB4DE1BA420
       call      qword ptr [7CB4DD64F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M02_L42:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       lea       rdi,[rax+8]
       mov       rsi,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L08
M02_L43:
       mov       edi,4
       call      qword ptr [7CB4DE19F408]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
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
       mov       rsi,7CB4DE1EACC0
       call      qword ptr [7CB4DD64F3A8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rsi,rax
M02_L47:
       mov       rdi,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdi,r13
       mov       rsi,r14
       mov       rdx,r12
       mov       rcx,[rbp-48]
       call      qword ptr [7CB4DE19F870]
       jmp       near ptr M02_L15
M02_L48:
       mov       rdi,7CA5188013B0
       mov       rdi,[rdi]
       cmp       byte ptr [rdi+9D],0
       je        near ptr M02_L16
       mov       rdi,7CA5188013B0
       mov       rdi,[rdi]
       mov       rsi,r13
       call      qword ptr [7CB4DE19F528]
       jmp       near ptr M02_L16
M02_L49:
       mov       rdi,r14
       call      qword ptr [7CB4DE196E38]; System.Threading.PortableThreadPool+GateThread.EnsureRunningSlow(System.Threading.PortableThreadPool)
       jmp       near ptr M02_L28
M02_L50:
       mov       rdi,[r12+10]
       mov       r14,[rdi+8]
       cmp       [r14],r14b
       mov       rdi,offset MT_System.TimeProvider
       call      qword ptr [7CB4DD645728]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,7CA5188014E0
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
       jmp       qword ptr [7CB4DE19FFD8]
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
       call      qword ptr [7CB4DD1EEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdx,[rbp-8C]
       mov       rsi,[rbp-94]
       mov       rdi,[rbp-9C]
       mov       ecx,[rbp-84]
       mov       r8,[rbp-0A4]
       call      qword ptr [rax]
       mov       rbx,rax
       lea       rdi,[rbp-80]
       call      qword ptr [7CB4DD1EEF08]; CORINFO_HELP_JIT_PINVOKE_END
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
       call      qword ptr [7CB4DE1973C0]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7CB4DE19F798]
       jmp       short M04_L01
M04_L04:
       test      r15b,2
       jne       short M04_L05
       mov       rdi,rbx
       call      qword ptr [7CB4DE19F8B8]
M04_L05:
       mov       rdi,rbx
       call      qword ptr [7CB4DE254000]
       jmp       short M04_L02
; Total bytes of code 125
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: DefaultJob)

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
       call      000075A5EA4E6020
       test      eax,eax
       je        short M00_L05
M00_L04:
       mov       dword ptr [rbp-24],1
       cmp       qword ptr [rbx+8],0
       je        short M00_L06
       mov       rdi,rbx
       call      qword ptr [75A56CAAC438]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       r15,rax
       jmp       short M00_L07
M00_L05:
       mov       rdi,r14
       call      qword ptr [75A56CDACC78]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L04
M00_L06:
       mov       r15,[rbx+18]
M00_L07:
       mov       rdi,r14
       call      000075A5EA4E6790
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
       mov       rsi,75A56CDCBA18
       call      qword ptr [75A56C25F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rbx,rax
       jmp       near ptr M00_L00
M00_L10:
       mov       rdi,rbx
       mov       rsi,75A56CDCBE20
       call      qword ptr [75A56C25F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M00_L01
M00_L11:
       mov       rdi,rbx
       mov       rsi,75A56CDCBE48
       call      qword ptr [75A56C25F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L12:
       mov       rdi,rbx
       mov       rsi,75A56CDCBBE8
       call      qword ptr [75A56C25F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M00_L03
M00_L13:
       mov       rdi,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       edi,10E
       mov       rsi,75A56CDDB778
       call      qword ptr [75A56C25EF88]
       mov       rsi,rax
       mov       rdi,rbx
       call      qword ptr [75A56CAADF68]
       mov       rdi,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L14:
       mov       edi,eax
       mov       rsi,r14
       call      qword ptr [75A56CDAEDD8]
       jmp       near ptr M00_L08
       push      rax
       cmp       dword ptr [rbp-24],0
       je        short M00_L15
       mov       rdi,[rbp-38]
       call      000075A5EA4E6790
       test      eax,eax
       je        short M00_L15
       mov       edi,eax
       mov       rsi,[rbp-38]
       call      qword ptr [75A56CDAEDD8]
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
       call      qword ptr [75A56CDA7360]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
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
       call      qword ptr [75A56C25FAE0]
       int       3
M02_L02:
       mov       rsi,75A56CDCC0A8
       call      qword ptr [75A56C25F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       short M02_L00
M02_L03:
       mov       rdi,rsi
       mov       rsi,75A56CDFC440
       call      qword ptr [75A56C25F3A8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r14,rax
       jmp       short M02_L01
M02_L04:
       mov       rdi,[r14+18]
       mov       rdi,[rdi+20]
       test      rdi,rdi
       je        near ptr M02_L10
M02_L05:
       call      qword ptr [75A56CDA6628]; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].get_Factory()
       mov       rdi,[rax]
       mov       rsi,[rdi+30]
       mov       rsi,[rsi]
       mov       rsi,[rsi+18]
       test      rsi,rsi
       je        near ptr M02_L11
M02_L06:
       mov       rdi,7595A8801390
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
       mov       eax,2008
       mov       [r12+34],eax
       call      qword ptr [75A56CDA6778]; System.Threading.ExecutionContext.Capture()
       mov       r15,rax
       test      r15,r15
       jne       near ptr M02_L12
       or        dword ptr [r12+34],20000000
M02_L07:
       mov       rdi,r12
       xor       esi,esi
       call      qword ptr [75A56CDA67C0]; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
       mov       rdi,[r14+18]
       mov       rdi,[rdi+28]
       test      rdi,rdi
       je        near ptr M02_L13
M02_L08:
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       movzx     r14d,word ptr [r12+34]
       and       r14d,4
       test      r14d,0FFFFFFBB
       je        near ptr M02_L14
M02_L09:
       mov       edi,2D
       call      qword ptr [75A56C25F0D8]
       int       3
M02_L10:
       mov       rdi,r14
       mov       rsi,75A56CDFC5D0
       call      qword ptr [75A56C25F3A8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M02_L05
M02_L11:
       mov       rsi,75A56CDFC810
       call      qword ptr [75A56C25F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M02_L06
M02_L12:
       mov       rdi,7595A88013A0
       cmp       r15,[rdi]
       je        near ptr M02_L07
       mov       rdi,r12
       call      qword ptr [75A56CDAF108]
       lea       rdi,[rax+8]
       mov       rsi,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L07
M02_L13:
       mov       rdi,r14
       mov       rsi,75A56CDFC668
       call      qword ptr [75A56C25F3A8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M02_L08
M02_L14:
       test      r14b,4
       je        short M02_L16
       mov       rdi,75A5EA8A0D68
       mov       rax,75A5EB194820
       call      rax
       cmp       dword ptr [rax],8
       jle       near ptr M02_L21
       mov       rdi,[rax+8]
       mov       rax,[rdi+40]
       test      rax,rax
       je        near ptr M02_L21
M02_L15:
       mov       r13,[rax+10]
       test      r13,r13
       je        short M02_L16
       mov       rdi,r15
       call      qword ptr [75A56CDAF108]
       lea       rdi,[rax+30]
       mov       rsi,r13
       call      CORINFO_HELP_ASSIGN_REF
M02_L16:
       xor       edi,edi
       mov       [r15+8],rdi
       mov       [r15+10],rdi
       mov       [r15+18],rdi
       test      r14d,0FFFFFFA0
       jne       near ptr M02_L09
       mov       edi,r14d
       or        edi,400
       or        edi,2000000
       mov       [r15+34],edi
       mov       rdi,[r15+28]
       test      rdi,rdi
       jne       near ptr M02_L22
M02_L17:
       mov       byte ptr [r15+41],1
       mov       rdi,7595A88013B0
       mov       rdi,[rdi]
       cmp       byte ptr [rdi+9D],0
       jne       near ptr M02_L23
M02_L18:
       cmp       byte ptr [75A56B26B06C],0
       jne       near ptr M02_L24
M02_L19:
       test      dword ptr [r12+34],1600000
       jne       near ptr M02_L25
       test      dword ptr [r12+34],1600000
       jne       near ptr M02_L28
       cmp       qword ptr [r12+20],0
       jne       near ptr M02_L27
       lea       rdi,[r12+20]
       test      rdi,rdi
       je        near ptr M02_L26
       mov       rsi,r15
       xor       edx,edx
       call      000075A5EA674060
       test      rax,rax
       jne       near ptr M02_L27
M02_L20:
       mov       rax,r15
       add       rsp,8
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L21:
       mov       edi,8
       call      qword ptr [75A56CDAEC88]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M02_L15
M02_L22:
       mov       rdi,[rdi+30]
       test      rdi,rdi
       je        near ptr M02_L17
       test      r14b,4
       je        near ptr M02_L17
       test      byte ptr [rdi+34],8
       jne       near ptr M02_L17
       call      qword ptr [75A56CDAEDF0]
       jmp       near ptr M02_L17
M02_L23:
       mov       rdi,r15
       call      qword ptr [75A56CDAC048]
       mov       esi,eax
       mov       rdi,7595A88013B0
       mov       rdi,[rdi]
       mov       rdx,75A56860AB58
       xor       ecx,ecx
       call      qword ptr [75A56CDAF1B0]
       jmp       near ptr M02_L18
M02_L24:
       mov       rdi,r15
       call      qword ptr [75A56CDA7C18]
       jmp       near ptr M02_L19
M02_L25:
       mov       rdi,r15
       mov       rsi,r12
       call      qword ptr [75A56CDA7E10]; System.Threading.Tasks.UnwrapPromise`1[[System.__Canon, System.Private.CoreLib]].ProcessCompletedOuterTask(System.Threading.Tasks.Task)
       jmp       near ptr M02_L20
M02_L26:
       call      qword ptr [75A56CDAEDA8]
       int       3
M02_L27:
       mov       rdi,r12
       mov       rsi,r15
       xor       edx,edx
       call      qword ptr [75A56CDACC90]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M02_L20
M02_L28:
       mov       rdi,r15
       mov       rsi,r12
       call      qword ptr [75A56CDE9B08]; System.Threading.Tasks.UnwrapPromise`1[[System.__Canon, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
       jmp       near ptr M02_L20
; Total bytes of code 919
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
       call      000075A5EA4E6020
       test      eax,eax
       je        short M03_L03
M03_L02:
       mov       dword ptr [rbp-14],1
       mov       rdi,[rbp-20]
       cmp       [rdi+8],rbx
       jne       short M03_L04
       mov       esi,2
       call      qword ptr [75A56CAAC468]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M03_L04
M03_L03:
       mov       rdi,rbx
       call      qword ptr [75A56CDACC78]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M03_L02
M03_L04:
       mov       rdi,rbx
       call      000075A5EA4E6790
       test      eax,eax
       jne       near ptr M03_L12
M03_L05:
       mov       rdi,[rbp-20]
       cmp       qword ptr [rdi+8],0
       je        near ptr M03_L13
       add       rsp,28
       pop       rbx
       pop       rbp
       jmp       qword ptr [75A56CAAC438]
M03_L06:
       cmp       eax,8
       ja        short M03_L07
       mov       eax,eax
       lea       rcx,[75A56C2DE470]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M03_L01]
       add       rcx,rdx
       jmp       rcx
M03_L07:
       mov       rdi,[rbx+8]
       cmp       [rdi],edi
       call      qword ptr [75A56CDAEE68]
       int       3
       mov       rdi,[rbp-20]
       call      qword ptr [75A56CDAF810]
       jmp       short M03_L05
       mov       rdi,[rbp-20]
       xor       esi,esi
       call      qword ptr [75A56CAAC468]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
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
       mov       rsi,75A56CDFBEA8
       call      qword ptr [75A56C25F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M03_L09:
       mov       rdi,[rax+30]
       mov       rdi,[rdi]
       mov       rdi,[rdi+18]
       test      rdi,rdi
       je        short M03_L10
       jmp       short M03_L11
M03_L10:
       mov       rdi,rax
       mov       rsi,75A56CDFBF48
       call      qword ptr [75A56C25F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M03_L11:
       call      qword ptr [75A56CDAF7B0]
       mov       rdx,rax
       mov       rsi,rbx
       mov       rdi,[rbp-20]
       call      qword ptr [75A56CDAF828]
       jmp       near ptr M03_L05
       mov       rdi,[rbp-20]
       mov       rsi,rbx
       call      qword ptr [75A56CDAF840]
       jmp       near ptr M03_L05
       mov       rdi,[rbp-20]
       call      qword ptr [75A56CDAF858]
       jmp       near ptr M03_L05
       mov       rdi,[rbp-20]
       mov       rsi,rbx
       mov       edx,1
       call      qword ptr [75A56CAAC450]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M03_L05
M03_L12:
       mov       edi,eax
       mov       rsi,rbx
       call      qword ptr [75A56CDAEDD8]
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
       call      000075A5EA4E6790
       test      eax,eax
       je        short M03_L14
       mov       edi,eax
       mov       rsi,[rbp-28]
       call      qword ptr [75A56CDAEDD8]
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
       call      qword ptr [75A56BDFEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdi,[rbp-90]
       call      qword ptr [rax]
       lea       rdi,[rbp-88]
       call      qword ptr [75A56BDFEF08]; CORINFO_HELP_JIT_PINVOKE_END
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
       call      qword ptr [75A56BDFEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdx,[rbp-8C]
       mov       rsi,[rbp-94]
       mov       rdi,[rbp-9C]
       mov       ecx,[rbp-84]
       mov       r8,[rbp-0A4]
       call      qword ptr [rax]
       mov       rbx,rax
       lea       rdi,[rbp-80]
       call      qword ptr [75A56BDFEF08]; CORINFO_HELP_JIT_PINVOKE_END
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
       jne       short M06_L00
       mov       rdi,rbx
       mov       esi,0FFFFFFFF
       xor       edx,edx
       call      qword ptr [75A56CDA7378]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [75A56CDAFB10]
       jmp       short M06_L01
M06_L04:
       test      r15b,2
       jne       short M06_L05
       mov       rdi,rbx
       call      qword ptr [75A56CDAF978]
M06_L05:
       mov       rdi,rbx
       call      qword ptr [75A56CDAFEA0]
       jmp       short M06_L02
; Total bytes of code 125
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: DefaultJob)

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
       call      00007206E88E6020
       test      eax,eax
       je        short M00_L03
M00_L02:
       mov       dword ptr [rbp-24],1
       cmp       qword ptr [rbx+8],0
       je        short M00_L04
       mov       rdi,rbx
       call      qword ptr [72066AEAC438]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       r15,rax
       jmp       short M00_L05
M00_L03:
       mov       rdi,r14
       call      qword ptr [72066B1AEB38]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L02
M00_L04:
       mov       r15,[rbx+18]
M00_L05:
       mov       rdi,r14
       call      00007206E88E6790
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
       mov       rsi,72066B1CBA18
       call      qword ptr [72066A65F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rbx,rax
       jmp       near ptr M00_L00
M00_L08:
       mov       rdi,rbx
       mov       rsi,72066B1CBBE8
       call      qword ptr [72066A65F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M00_L01
M00_L09:
       mov       rdi,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       edi,10E
       mov       rsi,72066B1DBE30
       call      qword ptr [72066A65EF88]
       mov       rsi,rax
       mov       rdi,rbx
       call      qword ptr [72066AEADF68]
       mov       rdi,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L10:
       mov       edi,eax
       mov       rsi,r14
       call      qword ptr [72066B1AE760]
       jmp       near ptr M00_L06
       push      rax
       cmp       dword ptr [rbp-24],0
       je        short M00_L11
       mov       rdi,[rbp-38]
       call      00007206E88E6790
       test      eax,eax
       je        short M00_L11
       mov       edi,eax
       mov       rsi,[rbp-38]
       call      qword ptr [72066B1AE760]
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
       call      qword ptr [72066B1A7858]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
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
       call      00007206E88E6020
       test      eax,eax
       je        short M02_L03
M02_L02:
       mov       dword ptr [rbp-14],1
       mov       rdi,[rbp-20]
       cmp       [rdi+8],rbx
       jne       short M02_L04
       mov       esi,2
       call      qword ptr [72066AEAC468]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M02_L04
M02_L03:
       mov       rdi,rbx
       call      qword ptr [72066B1AEB38]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M02_L02
M02_L04:
       mov       rdi,rbx
       call      00007206E88E6790
       test      eax,eax
       jne       near ptr M02_L12
M02_L05:
       mov       rdi,[rbp-20]
       cmp       qword ptr [rdi+8],0
       je        near ptr M02_L13
       add       rsp,28
       pop       rbx
       pop       rbp
       jmp       qword ptr [72066AEAC438]
M02_L06:
       cmp       eax,8
       ja        short M02_L07
       mov       eax,eax
       lea       rcx,[72066A6D4380]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M02_L01]
       add       rcx,rdx
       jmp       rcx
M02_L07:
       mov       rdi,[rbx+8]
       cmp       [rdi],edi
       call      qword ptr [72066B1AEC10]
       int       3
       mov       rdi,[rbp-20]
       call      qword ptr [72066B1AEBB0]
       jmp       short M02_L05
       mov       rdi,[rbp-20]
       xor       esi,esi
       call      qword ptr [72066AEAC468]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
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
       mov       rsi,72066B1F5E90
       call      qword ptr [72066A65F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L09:
       mov       rdi,[rax+30]
       mov       rdi,[rdi]
       mov       rdi,[rdi+18]
       test      rdi,rdi
       je        short M02_L10
       jmp       short M02_L11
M02_L10:
       mov       rdi,rax
       mov       rsi,72066B1F5F30
       call      qword ptr [72066A65F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M02_L11:
       call      qword ptr [72066B1AEB50]
       mov       rdx,rax
       mov       rsi,rbx
       mov       rdi,[rbp-20]
       call      qword ptr [72066B1AEBC8]
       jmp       near ptr M02_L05
       mov       rdi,[rbp-20]
       mov       rsi,rbx
       call      qword ptr [72066B1AEBE0]
       jmp       near ptr M02_L05
       mov       rdi,[rbp-20]
       call      qword ptr [72066B1AEBF8]
       jmp       near ptr M02_L05
       mov       rdi,[rbp-20]
       mov       rsi,rbx
       mov       edx,1
       call      qword ptr [72066AEAC450]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M02_L05
M02_L12:
       mov       edi,eax
       mov       rsi,rbx
       call      qword ptr [72066B1AE760]
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
       call      00007206E88E6790
       test      eax,eax
       je        short M02_L14
       mov       edi,eax
       mov       rsi,[rbp-28]
       call      qword ptr [72066B1AE760]
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
       call      qword ptr [72066A1FEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdi,[rbp-90]
       call      qword ptr [rax]
       lea       rdi,[rbp-88]
       call      qword ptr [72066A1FEF08]; CORINFO_HELP_JIT_PINVOKE_END
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
       call      qword ptr [72066A1FEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdx,[rbp-8C]
       mov       rsi,[rbp-94]
       mov       rdi,[rbp-9C]
       mov       ecx,[rbp-84]
       mov       r8,[rbp-0A4]
       call      qword ptr [rax]
       mov       rbx,rax
       lea       rdi,[rbp-80]
       call      qword ptr [72066A1FEF08]; CORINFO_HELP_JIT_PINVOKE_END
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
       jne       short M05_L00
       mov       rdi,rbx
       mov       esi,0FFFFFFFF
       xor       edx,edx
       call      qword ptr [72066B1A7870]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [72066B1AEDA8]
       jmp       short M05_L01
M05_L04:
       test      r15b,2
       jne       short M05_L05
       mov       rdi,rbx
       call      qword ptr [72066B1AEDD8]
M05_L05:
       mov       rdi,rbx
       call      qword ptr [72066B1AF258]
       jmp       short M05_L02
; Total bytes of code 125
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: DefaultJob)

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
       jmp       qword ptr [785FE21865F8]; Microsoft.VisualStudio.Threading.AsyncLazy`1[[System.__Canon, System.Private.CoreLib]].GetValueAsync(System.Threading.CancellationToken)
M00_L01:
       mov       rsi,785FE21D46B0
       call      qword ptr [785FE163F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       short M00_L00
M00_L02:
       mov       rdi,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       edi,164
       mov       rsi,785FE21BB788
       call      qword ptr [785FE163EF88]
       mov       rsi,rax
       mov       rdi,r15
       call      qword ptr [785FE1E8DF68]
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
       call      qword ptr [785FE218DD40]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
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
       vmovdqu   ymmword ptr [rbp-0D0],ymm8
       vmovdqu   ymmword ptr [rbp-0B0],ymm8
       vmovdqu   ymmword ptr [rbp-90],ymm8
       vmovdqu   ymmword ptr [rbp-70],ymm8
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
       call      000078605F8E5C00
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
       call      000078605F8E6020
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
       mov       rdi,78605FCA0D68
       mov       rax,786060692820
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
       call      qword ptr [785FE1E8C048]; System.Threading.Thread.InitializeCurrentThread()
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
       mov       r11,785FE06505A0
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
       mov       r11,785FE0650598
       call      qword ptr [r11]
       mov       [rbp-0E0],rax
       mov       rdx,[rbp-0D8]
       mov       rdx,[rdx+10]
       mov       [rbp-58],rdx
       jmp       near ptr M02_L16
M02_L11:
       mov       rsi,785FE21D8F30
       call      qword ptr [785FE163F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L05
M02_L12:
       mov       rsi,785FE21D9338
       call      qword ptr [785FE163F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rdi,785FE21F49A8
       call      qword ptr [785FE1A6C480]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       esi,[rbp-60]
       mov       rdi,[rbp-58]
       mov       rdx,r13
       call      qword ptr [785FE16357A0]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
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
       call      qword ptr [785FE1E8C048]; System.Threading.Thread.InitializeCurrentThread()
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
       call      qword ptr [785FE16358C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
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
       call      qword ptr [785FE21878D0]; System.Runtime.CompilerServices.AsyncMethodBuilderCore.Start[[Microsoft.VisualStudio.Threading.AsyncLazy`1+<>c__DisplayClass20_0+<<GetValueAsync>b__0>d[[System.__Canon, System.Private.CoreLib]], Microsoft.VisualStudio.Threading]](<<GetValueAsync>b__0>d<System.__Canon> ByRef)
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
       mov       rsi,785FE21DC1B0
       call      qword ptr [785FE163F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       short M02_L26
M02_L31:
       mov       rsi,785FE21DC3A8
       call      qword ptr [785FE163F3A8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       short M02_L27
M02_L32:
       mov       rsi,785FE21DC028
       call      qword ptr [785FE163F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rsi,785FE21D8FE0
       call      qword ptr [785FE163F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
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
       mov       rsi,785FE2279AE0
       call      qword ptr [785FE163F3A8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M02_L37:
       mov       rdi,r15
       mov       rsi,rcx
       mov       rdx,rbx
       xor       ecx,ecx
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [785FE2255B60]
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
       mov       rsi,785FE2279D08
       call      qword ptr [785FE163F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r15,rax
M02_L39:
       mov       rdi,rbx
       call      qword ptr [785FE2255C38]
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
       call      qword ptr [785FE2254AC8]
       jmp       near ptr M02_L29
M02_L42:
       mov       rdi,[rbx+8]
       call      qword ptr [rbx+18]
       jmp       near ptr M02_L29
M02_L43:
       call      M02_L99
       jmp       near ptr M02_L56
M02_L44:
       mov       rdi,78501C8013B0
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
       call      qword ptr [785FE16358C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r12,rax
M02_L47:
       jmp       near ptr M02_L22
M02_L48:
       xor       eax,eax
       jmp       near ptr M02_L23
M02_L49:
       xor       edi,edi
       call      qword ptr [785FE2254F30]
       int       3
M02_L50:
       mov       rdi,[rbp-0D0]
       call      qword ptr [785FE22555D8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M02_L03
M02_L51:
       lea       rdi,[rbp-38]
       call      qword ptr [785FE22555F0]
       int       3
M02_L52:
       mov       rdi,785FE226B490
       call      qword ptr [785FE2186A60]
       jmp       near ptr M02_L06
M02_L53:
       mov       edi,4
       call      qword ptr [785FE22548A0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M02_L08
M02_L54:
       test      r12d,r12d
       jne       short M02_L55
       mov       rdi,78501C8013B0
       mov       rsi,[rdi]
       mov       [rbp-4C],r8d
       mov       rax,rsi
       jmp       near ptr M02_L15
M02_L55:
       mov       [rbp-4C],r8d
       jmp       near ptr M02_L14
M02_L56:
       mov       rdi,[rbp-0D0]
       call      000078605F8E6790
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
       mov       rdi,78605FCA0D68
       mov       rax,786060692820
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
       call      qword ptr [785FE1E8C048]; System.Threading.Thread.InitializeCurrentThread()
M02_L59:
       mov       r14,[rax+10]
       mov       rax,[r13+10]
       test      rax,rax
       jne       short M02_L60
       call      qword ptr [785FE1E8C048]; System.Threading.Thread.InitializeCurrentThread()
M02_L60:
       lea       rdi,[rax+10]
       mov       rsi,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-130],r14
       test      rbx,rbx
       je        near ptr M02_L76
       mov       rdi,offset System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1+AsyncStateMachineBox`1[[System.__Canon, System.Private.CoreLib],[Microsoft.VisualStudio.Threading.AsyncLazy`1+<>c__DisplayClass20_0+<<GetValueAsync>b__0>d[[System.__Canon, System.Private.CoreLib]], Microsoft.VisualStudio.Threading]].MoveNext()
       cmp       [rbx+18],rdi
       jne       near ptr M02_L75
       mov       rbx,[rbx+8]
       mov       rdi,78501C8013A8
       mov       rdi,[rdi]
       movzx     r15d,byte ptr [rdi+9D]
       test      r15d,r15d
       jne       near ptr M02_L68
M02_L61:
       mov       r12,[rbx+10]
       test      r12,r12
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
       mov       rdi,r12
       mov       rdx,rbx
       call      qword ptr [785FE218C258]; System.Threading.ExecutionContext.RunInternal(System.Threading.ExecutionContext, System.Threading.ContextCallback, System.Object)
M02_L63:
       mov       edi,[rbx+34]
       test      edi,1600000
       je        short M02_L66
       cmp       byte ptr [785FE064B06C],0
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
       mov       rdi,78501C8013A8
       mov       rdi,[rdi]
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
       test      r15d,r15d
       je        near ptr M02_L76
       jmp       near ptr M02_L74
M02_L67:
       mov       rsi,785FE21DE870
       call      qword ptr [785FE163F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       near ptr M02_L62
M02_L68:
       mov       rdi,rbx
       call      qword ptr [785FE218C228]
       mov       esi,eax
       mov       rdi,78501C8013A8
       mov       rdi,[rdi]
       mov       edx,2
       call      qword ptr [785FE218C240]
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
       mov       rsi,785FE21DE8F8
       call      qword ptr [785FE163F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M02_L71:
       lea       rdi,[rbx+40]
       call      rax
       jmp       near ptr M02_L63
M02_L72:
       mov       rdi,rbx
       call      qword ptr [785FE218D560]
       jmp       near ptr M02_L64
M02_L73:
       mov       rdi,rbx
       call      qword ptr [785FE1E86880]; System.GC.SuppressFinalize(System.Object)
       jmp       near ptr M02_L66
M02_L74:
       mov       rdi,78501C8013A8
       mov       rdi,[rdi]
       mov       esi,2
       call      qword ptr [785FE218C2A0]
       jmp       short M02_L76
M02_L75:
       mov       rdi,[rbx+8]
       call      qword ptr [rbx+18]
       nop
M02_L76:
       mov       rax,[r13+10]
       test      rax,rax
       jne       short M02_L77
       call      qword ptr [785FE1E8C048]; System.Threading.Thread.InitializeCurrentThread()
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
       add       rsp,128
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L83:
       mov       rsi,785FE21D8E38
       call      qword ptr [785FE163F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rbx,rax
       jmp       short M02_L80
M02_L84:
       mov       rdi,rsi
       mov       rsi,785FE21D8400
       call      qword ptr [785FE163F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       jmp       near ptr M02_L00
M02_L85:
       test      dword ptr [rdi+34],1600000
       jne       near ptr M02_L02
       jmp       near ptr M02_L01
M02_L86:
       mov       rdi,[rdi+8]
       cmp       [rdi],edi
       call      qword ptr [785FE2255C08]
       test      rax,rax
       je        near ptr M02_L02
       call      qword ptr [785FE2255C20]
       mov       rdi,rax
       mov       rdx,78501C801510
       mov       rdx,[rdx]
       mov       rsi,785FDCA0C370
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rdi,rax
       xor       eax,eax
       test      rdi,rdi
       cmove     rdi,rax
       call      qword ptr [785FE2186940]
       int       3
M02_L87:
       mov       edi,94D
       mov       rsi,785FE0644000
       call      qword ptr [785FE163EF88]
       mov       rdi,rax
       call      qword ptr [785FE2254F30]
       int       3
M02_L88:
       call      qword ptr [785FE2255C20]
       mov       rdi,rax
       mov       rdx,78501C801510
       mov       rdx,[rdx]
       mov       rsi,785FDCA0C370
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rdi,rax
       xor       eax,eax
       test      rdi,rdi
       cmove     rdi,rax
       call      qword ptr [785FE2186940]
       int       3
M02_L89:
       mov       edi,eax
       mov       rsi,[rbp-0D0]
       call      qword ptr [785FE2254F48]
       jmp       near ptr M02_L57
M02_L90:
       mov       edi,4
       call      qword ptr [785FE22548A0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r13,rax
       jmp       near ptr M02_L58
M02_L91:
       mov       rdx,[rbp-38]
       xor       esi,esi
       call      qword ptr [785FE2186A30]
       jmp       near ptr M02_L79
M02_L92:
       mov       rdi,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       edi,170F
       mov       rsi,785FE21BB788
       call      qword ptr [785FE163EF88]
       mov       rsi,rax
       mov       rdi,rbx
       call      qword ptr [785FE1E8DF68]
       mov       rdi,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L93:
       test      dword ptr [r15+34],1600000
       jne       near ptr M02_L81
       lea       rdi,[rbp-0B8]
       call      qword ptr [785FE218DAA0]
       test      eax,eax
       je        short M02_L96
       mov       rdi,[rbx+18]
       mov       rdi,[rdi+20]
       test      rdi,rdi
       je        short M02_L94
       jmp       short M02_L95
M02_L94:
       mov       rdi,rbx
       mov       rsi,785FE2213810
       call      qword ptr [785FE163F3A8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdi,rax
M02_L95:
       mov       rsi,[rbp-0B8]
       call      qword ptr [785FE218DA40]
       jmp       near ptr M02_L82
M02_L96:
       mov       rdi,[rbx+18]
       mov       rdi,[rdi+18]
       test      rdi,rdi
       je        short M02_L97
       jmp       short M02_L98
M02_L97:
       mov       rdi,rbx
       mov       rsi,785FE2213760
       call      qword ptr [785FE163F3A8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdi,rax
M02_L98:
       mov       rsi,r15
       mov       rdx,[rbp-0B8]
       call      qword ptr [785FE218D9F8]
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
       mov       rdi,78605FCA0D68
       mov       rax,786060692820
       call      rax
       cmp       dword ptr [rax],4
       jle       short M02_L100
       mov       rdi,[rax+8]
       mov       rcx,[rdi+20]
       test      rcx,rcx
       jne       short M02_L101
M02_L100:
       mov       edi,4
       call      qword ptr [785FE22548A0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rcx,rax
M02_L101:
       mov       r13,rcx
       mov       rax,[r13+10]
       test      rax,rax
       jne       short M02_L102
       call      qword ptr [785FE1E8C048]; System.Threading.Thread.InitializeCurrentThread()
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
       mov       r11,785FE06505B8
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
       mov       r11,785FE06505B0
       xor       edx,edx
       call      qword ptr [r11]
       mov       [rbp-110],rax
       mov       rdx,[r12+10]
       mov       [rbp-0A8],rdx
       jmp       short M02_L107
M02_L104:
       test      r14d,r14d
       jne       short M02_L105
       mov       rdi,78501C8013B0
       mov       r12,[rdi]
       jmp       short M02_L106
M02_L105:
       mov       [rbp-9C],eax
       mov       rdi,offset MT_System.Threading.AsyncLocalValueMap+OneElementAsyncLocalValueMap
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rsi,r15
       mov       rdi,785FE222B620
       xor       edx,edx
       call      qword ptr [785FE2254DF8]
       mov       [rbp-128],rdx
       lea       rdi,[r12+8]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdi,[r12+10]
       mov       rsi,[rbp-128]
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
       mov       rdi,785FE21F49A8
       call      qword ptr [785FE1A6C480]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       esi,r12d
       mov       rdi,[rbp-0A8]
       mov       rdx,r15
       call      qword ptr [785FE16357A0]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M02_L109:
       mov       r13,[r13+10]
       test      r13,r13
       jne       short M02_L110
       call      qword ptr [785FE1E8C048]; System.Threading.Thread.InitializeCurrentThread()
       mov       r13,rax
M02_L110:
       mov       r12d,[rbp-0AC]
       test      r12d,r12d
       jne       short M02_L111
       mov       rdi,78501C8013B0
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
       call      qword ptr [785FE16358C0]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
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
       call      qword ptr [785FE2254F30]
       int       3
M02_L119:
       mov       rdi,[rbp-0D0]
       call      000078605F8E6790
       test      eax,eax
       je        short M02_L120
       mov       edi,eax
       mov       rsi,[rbp-0D0]
       call      qword ptr [785FE2254F48]
M02_L120:
       nop
       add       rsp,18
       ret
       sub       rsp,18
       mov       rdi,78605FCA0D68
       mov       rax,786060692820
       call      rax
       cmp       dword ptr [rax],4
       jle       short M02_L121
       mov       rdi,[rax+8]
       mov       r13,[rdi+20]
       test      r13,r13
       jne       short M02_L122
M02_L121:
       mov       edi,4
       call      qword ptr [785FE22548A0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r13,rax
M02_L122:
       mov       r14,[r13+10]
       test      r14,r14
       jne       short M02_L123
       call      qword ptr [785FE1E8C048]; System.Threading.Thread.InitializeCurrentThread()
       mov       r14,rax
M02_L123:
       lea       rdi,[r14+10]
       mov       rsi,[rbp-130]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,18
       ret
; Total bytes of code 4275
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
       call      qword ptr [785FE11DEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdx,[rbp-8C]
       mov       rsi,[rbp-94]
       mov       rdi,[rbp-9C]
       mov       ecx,[rbp-84]
       mov       r8,[rbp-0A4]
       call      qword ptr [rax]
       mov       rbx,rax
       lea       rdi,[rbp-80]
       call      qword ptr [785FE11DEF08]; CORINFO_HELP_JIT_PINVOKE_END
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
       call      qword ptr [785FE218DD58]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [785FE2254F18]
       jmp       short M04_L01
M04_L04:
       test      r15b,2
       jne       short M04_L05
       mov       rdi,rbx
       call      qword ptr [785FE2255740]
M04_L05:
       mov       rdi,rbx
       call      qword ptr [785FE2255C50]
       jmp       short M04_L02
; Total bytes of code 125
```

