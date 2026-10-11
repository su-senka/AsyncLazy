## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.ContendedFirstCallBenchmarks.LazyOfTask()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       rbx,rdi
       mov       rdi,offset MT_AsyncLazyBenchmarks.ContendedFirstCallBenchmarks+<>c__DisplayClass8_0
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdi,offset MT_System.Lazy<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdi,70F31CC01358
       mov       rsi,[rdi]
       lea       rdi,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset MT_System.LazyHelper
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+10],8
       lea       rdi,[r14+8]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdi,[r15+8]
       mov       rsi,r14
       call      CORINFO_HELP_ASSIGN_REF
       xor       r14d,r14d
M00_L00:
       mov       r13,[rbx+8]
       cmp       [r13+8],r14d
       jle       near ptr M00_L18
       mov       r12,[r15+10]
       test      r12,r12
       jne       short M00_L01
       mov       rdi,offset MT_System.Func<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rdi,[r12+8]
       mov       rsi,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset AsyncLazyBenchmarks.ContendedFirstCallBenchmarks+<>c__DisplayClass8_0.<LazyOfTask>b__0()
       mov       [r12+18],rdi
       lea       rdi,[r15+10]
       mov       rsi,r12
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       mov       rdi,70F31CC01378
       mov       rax,[rdi]
       test      rax,rax
       je        near ptr M00_L29
M00_L02:
       cmp       [rax],al
       mov       rdi,70F31CC01388
       mov       rax,[rdi]
       mov       [rbp-40],rax
       mov       rdi,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-48],rax
       lea       rdi,[rax+8]
       mov       rsi,r12
       call      CORINFO_HELP_ASSIGN_REF
       xor       edi,edi
       mov       r12,[rbp-48]
       mov       [r12+10],rdi
       lea       rdi,[r12+18]
       mov       rsi,[rbp-40]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edi,2008
       mov       [r12+34],edi
       mov       rdi,7103606A0D68
       mov       rax,710360EFD820
       call      rax
       cmp       dword ptr [rax],4
       jle       near ptr M00_L30
       mov       rdi,[rax+8]
       mov       rax,[rdi+20]
       test      rax,rax
       je        near ptr M00_L30
M00_L03:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M00_L04
       call      qword ptr [7102E28AC030]; System.Threading.Thread.InitializeCurrentThread()
M00_L04:
       mov       rax,[rax+8]
       test      rax,rax
       je        short M00_L05
       cmp       byte ptr [rax+18],0
       je        short M00_L06
       xor       eax,eax
       jmp       short M00_L06
M00_L05:
       mov       rax,70F31CC01398
       mov       rax,[rax]
M00_L06:
       test      rax,rax
       je        short M00_L08
       mov       rdi,70F31CC01398
       mov       [rbp-50],rax
       cmp       rax,[rdi]
       je        short M00_L09
       mov       rax,[rbp-50]
       mov       rcx,[r12+28]
       test      rcx,rcx
       jne       short M00_L07
       mov       [rbp-50],rax
       mov       rdi,offset MT_System.Threading.Tasks.Task+ContingentProperties
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,rax
       mov       [rbp-58],rcx
       mov       dword ptr [rcx+3C],1
       lea       rdi,[r12+28]
       mov       rsi,rcx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-58]
       mov       rax,[rbp-50]
M00_L07:
       lea       rdi,[rcx+8]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L09
M00_L08:
       or        dword ptr [r12+34],20000000
M00_L09:
       mov       rdi,r12
       xor       esi,esi
       call      qword ptr [7102E2BB69D0]; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
       mov       rdi,offset MT_System.Threading.Tasks.UnwrapPromise<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       movzx     ecx,word ptr [r12+34]
       and       ecx,4
       mov       [rbp-2C],ecx
       test      ecx,0FFFFFFBB
       jne       near ptr M00_L17
       test      cl,4
       je        near ptr M00_L12
       mov       rdi,7103606A0D68
       mov       rdx,710360EFD820
       call      rdx
       cmp       dword ptr [rax],8
       jle       near ptr M00_L31
       mov       rdi,[rax+8]
       mov       rax,[rdi+40]
       test      rax,rax
       je        near ptr M00_L31
M00_L10:
       mov       rax,[rax+10]
       mov       [rbp-60],rax
       test      rax,rax
       je        short M00_L12
       mov       rax,[rbp-60]
       mov       rcx,[rbp-38]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M00_L11
       mov       rdi,offset MT_System.Threading.Tasks.Task+ContingentProperties
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       [rbp-68],rdx
       mov       dword ptr [rdx+3C],1
       mov       rax,[rbp-38]
       lea       rdi,[rax+28]
       mov       rsi,rdx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-68]
       mov       rax,[rbp-60]
M00_L11:
       lea       rdi,[rdx+30]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L12:
       xor       edi,edi
       mov       rax,[rbp-38]
       mov       [rax+8],rdi
       mov       [rax+10],rdi
       mov       [rax+18],rdi
       mov       ecx,[rbp-2C]
       test      ecx,0FFFFFFA0
       jne       near ptr M00_L17
       mov       edi,ecx
       or        edi,400
       or        edi,2000000
       mov       [rax+34],edi
       mov       rdi,[rax+28]
       test      rdi,rdi
       jne       near ptr M00_L32
M00_L13:
       mov       rax,[rbp-38]
       mov       byte ptr [rax+3D],1
       mov       rdi,70F31CC013A8
       mov       rdi,[rdi]
       cmp       byte ptr [rdi+9D],0
       jne       near ptr M00_L33
M00_L14:
       cmp       byte ptr [7102E106B06C],0
       jne       near ptr M00_L34
M00_L15:
       test      dword ptr [r12+34],1600000
       jne       near ptr M00_L35
       test      dword ptr [r12+34],1600000
       jne       near ptr M00_L38
       cmp       qword ptr [r12+20],0
       jne       near ptr M00_L37
       lea       rdi,[r12+20]
       test      rdi,rdi
       je        near ptr M00_L46
       mov       rsi,rax
       xor       edx,edx
       call      0000710360474060
       test      rax,rax
       jne       near ptr M00_L36
M00_L16:
       movsxd    rsi,r14d
       mov       rdi,r13
       mov       rdx,[rbp-38]
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       r14d
       jmp       near ptr M00_L00
M00_L17:
       mov       edi,2D
       call      qword ptr [7102E205F0D8]
       int       3
M00_L18:
       mov       rsi,r13
       test      rsi,rsi
       je        near ptr M00_L39
       lea       rbx,[rsi+10]
       mov       r15d,[rsi+8]
       test      r15d,r15d
       je        near ptr M00_L40
       mov       esi,r15d
       mov       rdi,offset MT_System.Threading.Tasks.Task<System.Int32>[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       lea       rdi,[r14+10]
       mov       edx,r15d
       shl       rdx,3
       cmp       rdx,4000
       jbe       short M00_L19
       mov       rsi,rbx
       call      qword ptr [7102E2BBF888]
       jmp       short M00_L20
M00_L19:
       mov       rsi,rbx
       call      0000710360470D90
       cmp       dword ptr [7103606CEC80],0
       jne       near ptr M00_L41
M00_L20:
       mov       ebx,[r14+8]
       test      ebx,ebx
       jle       short M00_L22
       lea       rdi,[r14+10]
       mov       esi,ebx
M00_L21:
       cmp       qword ptr [rdi],0
       je        near ptr M00_L42
       add       rdi,8
       dec       esi
       jne       short M00_L21
M00_L22:
       mov       rdi,offset MT_System.Threading.Tasks.Task+WhenAllPromise<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       dword ptr [r15+34],2000400
       lea       rdi,[r15+40]
       mov       rsi,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r15+48],ebx
       mov       rdi,70F31CC013A8
       mov       rdi,[rdi]
       cmp       byte ptr [rdi+9D],0
       jne       near ptr M00_L43
M00_L23:
       cmp       byte ptr [7102E106B06C],0
       jne       near ptr M00_L44
M00_L24:
       xor       r13d,r13d
       test      ebx,ebx
       jle       short M00_L27
M00_L25:
       mov       rbx,[r14+r13*8+10]
       test      dword ptr [rbx+34],1600000
       jne       short M00_L28
       test      dword ptr [rbx+34],1600000
       jne       short M00_L28
       cmp       qword ptr [rbx+20],0
       jne       near ptr M00_L45
       lea       rdi,[rbx+20]
       test      rdi,rdi
       je        near ptr M00_L46
       mov       rsi,r15
       xor       edx,edx
       call      0000710360474060
       test      rax,rax
       jne       near ptr M00_L45
M00_L26:
       inc       r13d
       mov       ebx,[r14+8]
       cmp       ebx,r13d
       jg        short M00_L25
M00_L27:
       mov       rax,r15
       add       rsp,48
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L28:
       mov       rdi,r15
       mov       rsi,rbx
       call      qword ptr [7102E2BF7990]; System.Threading.Tasks.Task+WhenAllPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
       jmp       short M00_L26
M00_L29:
       mov       rdi,offset MT_System.Threading.Tasks.TaskFactory<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,70F31CC01378
       xor       edx,edx
       call      0000710360474060
       test      rax,rax
       jne       near ptr M00_L02
       mov       rax,70F31CC01378
       mov       rax,[rax]
       jmp       near ptr M00_L02
M00_L30:
       mov       edi,4
       call      qword ptr [7102E2BBEF58]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L03
M00_L31:
       mov       edi,8
       call      qword ptr [7102E2BBEF58]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L10
M00_L32:
       mov       rdi,[rdi+30]
       test      rdi,rdi
       je        near ptr M00_L13
       test      cl,4
       je        near ptr M00_L13
       test      byte ptr [rdi+34],8
       jne       near ptr M00_L13
       call      qword ptr [7102E2BBEB38]
       jmp       near ptr M00_L13
M00_L33:
       mov       rdi,rax
       call      qword ptr [7102E2BB7330]
       mov       esi,eax
       mov       rdi,70F31CC013A8
       mov       rdi,[rdi]
       mov       rdx,7102D940AC10
       xor       ecx,ecx
       call      qword ptr [7102E2BB7348]
       mov       rax,[rbp-38]
       jmp       near ptr M00_L14
M00_L34:
       mov       rdi,rax
       call      qword ptr [7102E2BB7360]
       mov       rax,[rbp-38]
       jmp       near ptr M00_L15
M00_L35:
       mov       rdi,rax
       mov       rsi,r12
       call      qword ptr [7102E2BB7390]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].ProcessCompletedOuterTask(System.Threading.Tasks.Task)
       jmp       near ptr M00_L16
M00_L36:
       mov       rax,[rbp-38]
M00_L37:
       mov       rdi,r12
       mov       rsi,rax
       xor       edx,edx
       call      qword ptr [7102E2BBCCA8]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M00_L16
       mov       rax,[rbp-38]
M00_L38:
       mov       rdi,rax
       mov       rsi,r12
       call      qword ptr [7102E2BEA810]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
       jmp       near ptr M00_L16
M00_L39:
       mov       edi,33
       call      qword ptr [7102E205FAE0]
       int       3
M00_L40:
       mov       rdi,offset MT_System.Threading.Tasks.Task<System.Int32[]>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdi,r15
       xor       esi,esi
       mov       rdx,7102D940A258
       xor       ecx,ecx
       xor       r8d,r8d
       call      qword ptr [7102E2BB77C8]
       jmp       near ptr M00_L27
M00_L41:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L20
M00_L42:
       mov       edi,1D
       mov       esi,33
       call      qword ptr [7102E2BB77F8]
       int       3
M00_L43:
       mov       rdi,r15
       call      qword ptr [7102E2BB7330]
       mov       esi,eax
       mov       rdi,70F31CC013A8
       mov       rdi,[rdi]
       mov       rdx,7102D940AF98
       xor       ecx,ecx
       call      qword ptr [7102E2BB7348]
       jmp       near ptr M00_L23
M00_L44:
       mov       rdi,r15
       call      qword ptr [7102E2BB7360]
       jmp       near ptr M00_L24
M00_L45:
       mov       rdi,rbx
       mov       rsi,r15
       xor       edx,edx
       call      qword ptr [7102E2BBCCA8]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M00_L26
       jmp       near ptr M00_L28
M00_L46:
       call      qword ptr [7102E2BBE9D0]
       int       3
; Total bytes of code 1738
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       mov       esi,[rdi+34]
       and       esi,11000000
       cmp       esi,1000000
       jne       short M01_L00
       ret
M01_L00:
       xor       esi,esi
       jmp       qword ptr [7102E2BB7960]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
; Total bytes of code 26
```
```assembly
; AsyncLazyBenchmarks.ContendedFirstCallBenchmarks+<>c__DisplayClass8_0.<LazyOfTask>b__0()
       mov       rdi,[rdi+8]
       cmp       qword ptr [rdi+8],0
       je        short M02_L00
       jmp       qword ptr [7102E28AC420]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
M02_L00:
       mov       rax,[rdi+18]
       ret
; Total bytes of code 22
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
       call      qword ptr [7102E1BFEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdi,[rbp-90]
       call      qword ptr [rax]
       lea       rdi,[rbp-88]
       call      qword ptr [7102E1BFEF08]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-30]
       call      qword ptr [7102E1C00B98]
       lea       rdi,[rax+10]
       mov       rsi,[rbp-30]
       call      qword ptr [7102E1BFEEB8]; CORINFO_HELP_ASSIGN_REF
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
; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
       push      rbp
       push      r15
       push      r14
       push      rbx
       push      rax
       lea       rbp,[rsp+20]
       mov       [rbp-20],rdi
       test      sil,sil
       jne       near ptr M04_L19
       or        dword ptr [rdi+34],10000
M04_L00:
       cmp       byte ptr [7102E106B06C],0
       jne       near ptr M04_L20
M04_L01:
       mov       rax,70F31CC013A8
       mov       rbx,[rax]
       cmp       byte ptr [rbx+9D],0
       jne       near ptr M04_L21
M04_L02:
       mov       r15,[rdi+18]
       cmp       [r15],r15b
       cmp       byte ptr [rbx+9D],0
       jne       near ptr M04_L10
M04_L03:
       mov       rsi,offset MT_System.Threading.Tasks.ThreadPoolTaskScheduler
       cmp       [r15],rsi
       jne       near ptr M04_L17
       movzx     r15d,word ptr [rdi+34]
       test      r15b,2
       jne       near ptr M04_L11
       mov       rsi,70F31CC013B0
       mov       rbx,[rsi]
       cmp       byte ptr [rbx+38],0
       jne       near ptr M04_L12
M04_L04:
       test      r15b,1
       jne       short M04_L06
       mov       rdi,7103606A0D68
       mov       rax,710360EFD820
       call      rax
       cmp       dword ptr [rax],5
       jle       near ptr M04_L13
       mov       rdi,[rax+8]
       mov       rax,[rdi+28]
       test      rax,rax
       je        near ptr M04_L13
M04_L05:
       mov       rdi,[rax+10]
       test      rdi,rdi
       jne       near ptr M04_L14
M04_L06:
       mov       rsi,[rbx+8]
       mov       rcx,[rsi+10]
       mov       rdx,[rcx+8]
M04_L07:
       mov       r15d,[rcx+0A0]
       mov       eax,r15d
       and       eax,[rcx+18]
       cmp       eax,[rdx+8]
       jae       near ptr M04_L15
       shl       rax,4
       lea       r14,[rdx+rax+10]
       mov       eax,[r14+8]
       sub       eax,r15d
       je        short M04_L08
       test      eax,eax
       jge       short M04_L07
       mov       rdi,rsi
       mov       rsi,[rbp-20]
       call      qword ptr [7102E2BBF438]
       jmp       short M04_L09
M04_L08:
       lea       r8,[rcx+0A0]
       lea       r9d,[r15+1]
       mov       eax,r15d
       lock cmpxchg [r8],r9d
       cmp       eax,r15d
       jne       short M04_L07
       mov       rsi,[rbp-20]
       mov       rdi,r14
       call      CORINFO_HELP_ASSIGN_REF
       inc       r15d
       mov       [r14+8],r15d
M04_L09:
       add       rbx,78
       mov       edi,1
       xchg      edi,[rbx]
       test      edi,edi
       jne       near ptr M04_L18
       mov       rdi,70F31CC013D8
       mov       rbx,[rdi]
       lea       rdi,[rbx+160]
       lock inc  dword ptr [rdi]
       mov       rdi,rbx
       call      qword ptr [7102E2BB6DA8]; System.Threading.PortableThreadPool+WorkerThread.MaybeAddWorkingWorker(System.Threading.PortableThreadPool)
       cmp       dword ptr [rbx+164],6
       je        near ptr M04_L18
       jmp       near ptr M04_L16
M04_L10:
       mov       rsi,r15
       call      qword ptr [7102E2BBF300]
       mov       rdi,[rbp-20]
       jmp       near ptr M04_L03
M04_L11:
       mov       rdi,offset MT_System.Threading.Tasks.ThreadPoolTaskScheduler
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdi,70F31CC01470
       mov       rbx,[rdi]
       mov       rdi,offset MT_System.Threading.Thread
       call      CORINFO_HELP_NEWFAST
       mov       r15,rax
       mov       rdi,r15
       mov       rsi,rbx
       call      qword ptr [7102E2BBFD20]
       mov       rdi,r15
       mov       esi,1
       call      qword ptr [7102E2BB6F88]; System.Threading.Thread.set_IsBackground(Boolean)
       mov       rdi,r15
       mov       rsi,7102D940A040
       call      qword ptr [7102E2BB7090]; System.Threading.Thread.set_Name(System.String)
       mov       rdi,r15
       mov       rsi,[rbp-20]
       xor       edx,edx
       call      qword ptr [7102E2BBFD38]
       jmp       near ptr M04_L18
M04_L12:
       mov       rsi,70F31CC013C8
       mov       rsi,[rsi]
       cmp       byte ptr [rsi+9D],0
       je        near ptr M04_L04
       mov       rsi,70F31CC013C8
       mov       rdi,[rsi]
       mov       rsi,[rbp-20]
       call      qword ptr [7102E2BBF408]
       jmp       near ptr M04_L04
M04_L13:
       mov       edi,5
       call      qword ptr [7102E2BBEF58]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M04_L05
M04_L14:
       mov       rdi,[rdi+18]
       mov       rsi,[rbp-20]
       cmp       [rdi],edi
       call      qword ptr [7102E2BBF420]
       jmp       near ptr M04_L09
M04_L15:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M04_L16:
       mov       rdi,rbx
       call      qword ptr [7102E2BB7000]; System.Threading.PortableThreadPool+GateThread.EnsureRunningSlow(System.Threading.PortableThreadPool)
       jmp       short M04_L18
M04_L17:
       mov       rdi,r15
       mov       rsi,[rbp-20]
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       nop
M04_L18:
       add       rsp,8
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       ret
M04_L19:
       call      qword ptr [7102E2BBFD08]
       test      eax,eax
       mov       rdi,[rbp-20]
       jne       near ptr M04_L00
       jmp       short M04_L18
M04_L20:
       call      qword ptr [7102E2BB7360]
       mov       rdi,[rbp-20]
       jmp       near ptr M04_L01
M04_L21:
       test      word ptr [rdi+34],200
       jne       near ptr M04_L02
       call      qword ptr [7102E2BB7330]
       mov       r15d,eax
       mov       rdi,[rbp-20]
       mov       rdi,[rdi+8]
       call      qword ptr [7102E2BBF270]
       mov       rsi,rax
       mov       rdi,7102D9409FB8
       call      qword ptr [7102E205EFA0]; System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       esi,r15d
       mov       rdi,rbx
       xor       ecx,ecx
       call      qword ptr [7102E2BB7348]
       mov       rdi,[rbp-20]
       jmp       near ptr M04_L02
       push      rax
       mov       rbx,rdi
       mov       rdi,offset MT_System.Threading.Tasks.TaskSchedulerException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdi,r15
       mov       rsi,rbx
       call      qword ptr [7102E2BBF288]
       mov       rdi,[rbp-20]
       mov       rsi,r15
       call      qword ptr [7102E2BBF2A0]
       mov       rdi,[rbp-20]
       xor       esi,esi
       call      qword ptr [7102E2BBF2B8]
       mov       rdi,[rbp-20]
       call      qword ptr [7102E2BBF2D0]
       test      eax,200
       jne       short M04_L22
       mov       rdi,[rbp-20]
       mov       rdi,[rdi+28]
       mov       rdi,[rdi+18]
       xor       esi,esi
       cmp       [rdi],edi
       call      qword ptr [7102E2BBF2E8]
M04_L22:
       mov       rdi,r15
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 886
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       push      rbp
       mov       rbp,rsp
       mov       eax,[rdi+8]
       cmp       rax,rsi
       jbe       short M05_L01
       lea       rax,[rdi+rsi*8+10]
       mov       rdi,[rdi]
       mov       rsi,[rdi+30]
       test      rdx,rdx
       jne       short M05_L00
       xor       edx,edx
       mov       [rax],rdx
       pop       rbp
       ret
M05_L00:
       cmp       rsi,[rdx]
       je        short M05_L02
       mov       rcx,offset MT_System.Object[]
       cmp       rdi,rcx
       je        short M05_L02
       mov       rdi,rax
       pop       rbp
       jmp       qword ptr [7102E28A7A68]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
M05_L01:
       call      qword ptr [7102E2BBE898]
       int       3
M05_L02:
       mov       rdi,rax
       mov       rsi,rdx
       pop       rbp
       jmp       near ptr 00007103605FB900
; Total bytes of code 85
```
```assembly
; System.Threading.Tasks.Task+WhenAllPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+50]
       mov       rbx,rdi
       mov       rdi,70F31CC013A8
       mov       r15,[rdi]
       cmp       byte ptr [r15+9D],0
       jne       near ptr M06_L12
M06_L00:
       lea       rsi,[rbx+48]
       mov       edi,0FFFFFFFF
       lock xadd [rsi],edi
       dec       edi
       jne       near ptr M06_L11
       mov       rsi,[rbx+40]
       mov       esi,[rsi+8]
       mov       rdi,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       xor       r13d,r13d
       xor       r12d,r12d
       xor       eax,eax
M06_L01:
       mov       rdi,[rbx+40]
       cmp       [rdi+8],eax
       jle       near ptr M06_L06
       cmp       eax,[rdi+8]
       jae       near ptr M06_L27
       mov       [rbp-2C],eax
       mov       ecx,eax
       mov       [rbp-38],rcx
       mov       r8,[rdi+rcx*8+10]
       mov       [rbp-40],r8
       test      dword ptr [r8+34],200000
       jne       near ptr M06_L13
       mov       edi,[r8+34]
       and       edi,600000
       cmp       edi,400000
       je        near ptr M06_L16
       test      dword ptr [r8+34],1600000
       je        near ptr M06_L17
M06_L02:
       mov       edi,[r8+34]
       and       edi,1600000
       cmp       edi,1000000
       jne       near ptr M06_L18
M06_L03:
       mov       edi,[r8+38]
       mov       eax,[rbp-2C]
       cmp       eax,[r14+8]
       jae       near ptr M06_L27
       mov       rcx,[rbp-38]
       mov       [r14+rcx*4+10],edi
M06_L04:
       test      dword ptr [r8+34],10000000
       jne       near ptr M06_L19
       mov       rdi,[rbx+40]
       mov       eax,[rbp-2C]
       cmp       eax,[rdi+8]
       jae       near ptr M06_L27
       xor       esi,esi
       mov       rcx,[rbp-38]
       mov       [rdi+rcx*8+10],rsi
M06_L05:
       mov       eax,[rbp-2C]
       inc       eax
       jmp       near ptr M06_L01
M06_L06:
       test      r13,r13
       jne       near ptr M06_L20
       test      r12,r12
       jne       near ptr M06_L21
       cmp       byte ptr [r15+9D],0
       jne       near ptr M06_L22
M06_L07:
       cmp       byte ptr [7102E106B06C],0
       jne       near ptr M06_L23
M06_L08:
       mov       eax,[rbx+34]
       mov       [rbp-30],eax
       test      eax,5600000
       jne       short M06_L11
       lea       rdi,[rbx+34]
       mov       esi,eax
       or        esi,4000000
       lock cmpxchg [rdi],esi
       cmp       eax,[rbp-30]
       jne       near ptr M06_L24
M06_L09:
       lea       rdi,[rbx+38]
       mov       rsi,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdi,[rbx+34]
       mov       eax,[rbx+34]
       or        eax,1000000
       xchg      eax,[rdi]
       mov       r12,[rbx+28]
       test      r12,r12
       jne       near ptr M06_L25
M06_L10:
       lea       rdi,[rbx+20]
       test      rdi,rdi
       je        near ptr M06_L26
       mov       rsi,70F31CC00238
       mov       rsi,[rsi]
       call      0000710360474040
       test      rax,rax
       je        short M06_L11
       mov       rdi,rbx
       mov       rsi,rax
       call      qword ptr [7102E2BB7B88]; System.Threading.Tasks.Task.RunContinuations(System.Object)
M06_L11:
       nop
       add       rsp,28
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M06_L12:
       mov       rdi,rbx
       call      qword ptr [7102E2BB7330]
       mov       esi,eax
       mov       rdi,r15
       mov       edx,1
       call      qword ptr [7102E2BB7DE0]
       jmp       near ptr M06_L00
M06_L13:
       test      r13,r13
       jne       short M06_L14
       mov       rdi,offset MT_System.Collections.Generic.List<System.Runtime.ExceptionServices.ExceptionDispatchInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdi,r13
       call      qword ptr [7102E28AF0A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       r8,[rbp-40]
M06_L14:
       mov       rdi,[r8+28]
       mov       rdx,[rdi+18]
       mov       [rbp-48],rdx
       mov       rsi,[rdx+10]
       mov       [rbp-50],rsi
       cmp       byte ptr [rdx+20],0
       jne       short M06_L15
       mov       rdi,rdx
       call      qword ptr [7102E28A6868]; System.GC.SuppressFinalize(System.Object)
       mov       rdi,[rbp-48]
       mov       byte ptr [rdi+20],1
M06_L15:
       mov       rdi,r13
       mov       rsi,[rbp-50]
       cmp       [rdi],edi
       call      qword ptr [7102E2BB7F78]
       mov       r8,[rbp-40]
       jmp       near ptr M06_L04
M06_L16:
       test      r12,r12
       jne       near ptr M06_L04
       mov       r12,r8
       mov       r8,[rbp-40]
       jmp       near ptr M06_L04
M06_L17:
       mov       rdi,r8
       mov       esi,0FFFFFFFF
       xor       edx,edx
       call      qword ptr [7102E2BB7990]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
       mov       r8,[rbp-40]
       jmp       near ptr M06_L02
M06_L18:
       mov       rdi,r8
       mov       esi,1
       call      qword ptr [7102E2BBF180]
       mov       r8,[rbp-40]
       jmp       near ptr M06_L03
M06_L19:
       mov       edi,[rbx+34]
       test      edi,5600000
       jne       near ptr M06_L05
       lea       rsi,[rbx+34]
       mov       edx,edi
       or        edx,10000000
       mov       eax,edi
       lock cmpxchg [rsi],edx
       cmp       eax,edi
       je        near ptr M06_L05
       mov       rdi,rbx
       mov       esi,10000000
       mov       edx,5600000
       call      qword ptr [7102E2BBF198]
       jmp       near ptr M06_L05
M06_L20:
       mov       rdi,rbx
       mov       rsi,r13
       call      qword ptr [7102E2BB7EB8]
       jmp       near ptr M06_L11
M06_L21:
       mov       rdi,r12
       call      qword ptr [7102E2BB7DF8]
       mov       r13,rax
       mov       rdi,r12
       call      qword ptr [7102E2BB7E10]
       mov       rdx,rax
       mov       rsi,r13
       mov       rdi,rbx
       call      qword ptr [7102E2BB7E28]
       jmp       near ptr M06_L11
M06_L22:
       mov       rdi,rbx
       call      qword ptr [7102E2BB7330]
       mov       esi,eax
       mov       rdi,r15
       mov       edx,1
       call      qword ptr [7102E2BB7ED0]
       jmp       near ptr M06_L07
M06_L23:
       mov       rdi,rbx
       call      qword ptr [7102E2BB7EE8]
       jmp       near ptr M06_L08
M06_L24:
       mov       rdi,rbx
       mov       esi,4000000
       mov       edx,5600000
       call      qword ptr [7102E2BBF198]
       test      eax,eax
       je        near ptr M06_L11
       jmp       near ptr M06_L09
M06_L25:
       mov       rdi,rbx
       call      qword ptr [7102E2BBF1B0]
       mov       rdi,r12
       call      qword ptr [7102E2BBF1C8]
       jmp       near ptr M06_L10
M06_L26:
       call      qword ptr [7102E2BBE9D0]
       int       3
M06_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 915
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbp
       push      rbx
       push      rax
       lea       rbp,[rsp+10]
       mov       ebx,edi
       call      qword ptr [7102E1C16AF0]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].ProcessCompletedOuterTask(System.Threading.Tasks.Task)
       push      rbp
       push      r15
       push      r14
       push      rbx
       push      rax
       lea       rbp,[rsp+20]
       mov       rbx,rdi
       mov       r15,rsi
       mov       byte ptr [rbx+3C],1
       mov       esi,[r15+34]
       test      esi,200000
       jne       near ptr M08_L05
       test      esi,400000
       jne       near ptr M08_L06
       test      esi,1000000
       je        near ptr M08_L07
       mov       r14d,5
M08_L00:
       cmp       r14d,5
       jne       near ptr M08_L10
       mov       rdi,r15
       mov       rax,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task<System.Int32>>
       cmp       [rdi],rax
       jne       near ptr M08_L11
M08_L01:
       test      rdi,rdi
       je        near ptr M08_L12
       mov       esi,[rdi+34]
       and       esi,11000000
       cmp       esi,1000000
       jne       near ptr M08_L14
       mov       rsi,[rdi+38]
M08_L02:
       test      rsi,rsi
       je        near ptr M08_L15
       test      dword ptr [rsi+34],1600000
       je        near ptr M08_L16
       mov       rdi,rbx
       xor       edx,edx
       call      qword ptr [7102E2BB7D68]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
M08_L03:
       mov       byte ptr [rbx+3C],2
M08_L04:
       add       rsp,8
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       ret
M08_L05:
       mov       r14d,7
       jmp       short M08_L00
M08_L06:
       mov       r14d,6
       jmp       near ptr M08_L00
M08_L07:
       test      esi,800000
       je        short M08_L08
       mov       r14d,4
       jmp       near ptr M08_L00
M08_L08:
       test      esi,20000
       je        short M08_L09
       mov       r14d,3
       jmp       near ptr M08_L00
M08_L09:
       test      esi,2000000
       setne     r14b
       movzx     r14d,r14b
       mov       edi,2
       test      esi,10000
       cmovne    r14d,edi
       jmp       near ptr M08_L00
M08_L10:
       add       r14d,0FFFFFFFA
       cmp       r14d,1
       ja        short M08_L04
       movzx     edx,byte ptr [rbx+3D]
       mov       rdi,rbx
       mov       rsi,r15
       call      qword ptr [7102E2BB7D68]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       jmp       near ptr M08_L04
M08_L11:
       mov       rsi,r15
       mov       rdi,rax
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M08_L01
M08_L12:
       mov       rdi,r15
       mov       rax,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task>
       cmp       [rdi],rax
       je        short M08_L13
       mov       rsi,r15
       mov       rdi,rax
       call      qword ptr [7102E2484AF8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rdi,rax
M08_L13:
       cmp       [rdi],edi
       call      qword ptr [7102E2BB7D98]; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].get_Result()
       mov       rsi,rax
       jmp       near ptr M08_L02
M08_L14:
       mov       esi,1
       call      qword ptr [7102E2BBF138]
       mov       rsi,rax
       jmp       near ptr M08_L02
M08_L15:
       mov       rdi,rbx
       xor       esi,esi
       xor       edx,edx
       call      qword ptr [7102E2BB7E28]
       jmp       near ptr M08_L03
M08_L16:
       mov       rdi,rsi
       mov       rsi,rbx
       xor       edx,edx
       add       rsp,8
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7102E2BB73A8]; System.Threading.Tasks.Task.AddCompletionAction(System.Threading.Tasks.ITaskCompletionAction, Boolean)
; Total bytes of code 433
```
```assembly
; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rbx
       sub       rsp,18
       lea       rbp,[rsp+40]
       mov       rbx,rdi
       mov       r15,rsi
       mov       r14d,edx
       mov       r13,[rbx+20]
       mov       rsi,70F31CC00238
       cmp       r13,[rsi]
       jne       short M09_L01
M09_L00:
       xor       eax,eax
       add       rsp,18
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M09_L01:
       mov       rsi,r13
       mov       rdi,offset MT_System.Collections.Generic.List<System.Object>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r12,rax
       test      r12,r12
       jne       near ptr M09_L11
       mov       rdi,offset MT_System.Collections.Generic.List<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rdi,r12
       call      qword ptr [7102E28AF0A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       test      r14b,r14b
       je        short M09_L05
       inc       dword ptr [r12+14]
       mov       rdi,[r12+8]
       mov       esi,[r12+10]
       cmp       [rdi+8],esi
       jbe       short M09_L02
       lea       edx,[rsi+1]
       mov       [r12+10],edx
       mov       rdx,r15
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M09_L03
M09_L02:
       mov       rdi,r12
       mov       rsi,r15
       call      qword ptr [7102E20572D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M09_L03:
       inc       dword ptr [r12+14]
       mov       rdi,[r12+8]
       mov       esi,[r12+10]
       cmp       [rdi+8],esi
       jbe       short M09_L04
       lea       edx,[rsi+1]
       mov       [r12+10],edx
       mov       rdx,r13
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M09_L09
M09_L04:
       mov       rdi,r12
       mov       rsi,r13
       call      qword ptr [7102E20572D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M09_L09
M09_L05:
       inc       dword ptr [r12+14]
       mov       rdi,[r12+8]
       mov       esi,[r12+10]
       cmp       [rdi+8],esi
       jbe       short M09_L06
       lea       edx,[rsi+1]
       mov       [r12+10],edx
       mov       rdx,r13
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M09_L07
M09_L06:
       mov       rdi,r12
       mov       rsi,r13
       call      qword ptr [7102E20572D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M09_L07:
       inc       dword ptr [r12+14]
       mov       rdi,[r12+8]
       mov       esi,[r12+10]
       cmp       [rdi+8],esi
       jbe       short M09_L08
       lea       edx,[rsi+1]
       mov       [r12+10],edx
       mov       rdx,r15
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M09_L09
M09_L08:
       mov       rdi,r12
       mov       rsi,r15
       call      qword ptr [7102E20572D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M09_L09:
       lea       rdi,[rbx+20]
       test      rdi,rdi
       jne       short M09_L10
       call      qword ptr [7102E2BBE9D0]
       int       3
M09_L10:
       mov       rsi,r12
       mov       rdx,r13
       call      0000710360474060
       mov       r12,rax
       cmp       r12,r13
       je        near ptr M09_L20
       mov       rsi,r12
       mov       rdi,offset MT_System.Collections.Generic.List<System.Object>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r12,rax
       test      r12,r12
       je        near ptr M09_L00
M09_L11:
       mov       [rbp-40],r12
       xor       esi,esi
       mov       [rbp-30],esi
       lea       rsi,[rbp-30]
       mov       rdi,r12
       call      qword ptr [7102E2055980]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rdi,[rbx+20]
       mov       rax,70F31CC00238
       cmp       rdi,[rax]
       jne       short M09_L12
       xor       edi,edi
       mov       [rbp-34],edi
       jmp       near ptr M09_L18
M09_L12:
       mov       edi,[r12+10]
       mov       rax,[r12+8]
       cmp       edi,[rax+8]
       jne       short M09_L14
       mov       rdi,70F31CC00290
       mov       rsi,[rdi]
       test      rsi,rsi
       jne       short M09_L13
       mov       rdi,offset MT_System.Predicate<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rsi,70F31CC00260
       mov       rsi,[rsi]
       mov       rdi,rbx
       mov       rdx,7102E2BBBB28
       call      qword ptr [7102E2056E08]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdi,70F31CC00290
       mov       rsi,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,rbx
M09_L13:
       mov       rdi,r12
       cmp       [rdi],edi
       call      qword ptr [7102E2BBFB40]
M09_L14:
       test      r14b,r14b
       je        short M09_L15
       mov       rdi,r12
       mov       rdx,r15
       xor       esi,esi
       call      qword ptr [7102E2146A30]
       jmp       short M09_L19
M09_L15:
       inc       dword ptr [r12+14]
       mov       rdi,[r12+8]
       mov       esi,[r12+10]
       cmp       [rdi+8],esi
       jbe       short M09_L16
       lea       edx,[rsi+1]
       mov       [r12+10],edx
       mov       rdx,r15
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M09_L19
M09_L16:
       mov       rdi,r12
       mov       rsi,r15
       call      qword ptr [7102E20572D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M09_L19
M09_L17:
       mov       rdi,r12
       call      qword ptr [7102E2056808]; System.Threading.Monitor.Exit(System.Object)
       jmp       short M09_L20
M09_L18:
       call      M09_L22
       jmp       short M09_L21
M09_L19:
       cmp       byte ptr [rbp-30],0
       jne       short M09_L17
M09_L20:
       mov       eax,1
       add       rsp,18
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M09_L21:
       mov       eax,[rbp-34]
       movzx     eax,al
       add       rsp,18
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M09_L22:
       push      rax
       cmp       byte ptr [rbp-30],0
       je        short M09_L23
       mov       rdi,[rbp-40]
       call      qword ptr [7102E2056808]; System.Threading.Monitor.Exit(System.Object)
M09_L23:
       nop
       add       rsp,8
       ret
; Total bytes of code 724
```
```assembly
; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
       push      rbp
       push      r15
       push      r14
       push      rbx
       push      rax
       lea       rbp,[rsp+20]
       mov       rbx,rdi
       mov       r15,rsi
       call      00007103604F8300
       test      eax,eax
       je        near ptr M10_L18
       movzx     r14d,byte ptr [rbx+3C]
       test      r14d,r14d
       jne       near ptr M10_L05
       mov       byte ptr [rbx+3C],1
       mov       esi,[r15+34]
       test      esi,200000
       jne       near ptr M10_L06
       test      esi,400000
       jne       near ptr M10_L07
       test      esi,1000000
       je        near ptr M10_L08
       mov       r14d,5
M10_L00:
       cmp       r14d,5
       jne       near ptr M10_L11
       mov       rdi,r15
       mov       rax,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task<System.Int32>>
       cmp       [rdi],rax
       jne       near ptr M10_L12
M10_L01:
       test      rdi,rdi
       je        near ptr M10_L13
       mov       esi,[rdi+34]
       and       esi,11000000
       cmp       esi,1000000
       jne       near ptr M10_L15
       mov       rsi,[rdi+38]
M10_L02:
       test      rsi,rsi
       je        near ptr M10_L16
       test      dword ptr [rsi+34],1600000
       je        near ptr M10_L17
       mov       rdi,rbx
       xor       edx,edx
       call      qword ptr [7102E2BB7D68]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
M10_L03:
       mov       byte ptr [rbx+3C],2
M10_L04:
       add       rsp,8
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       ret
M10_L05:
       cmp       r14d,1
       jne       short M10_L04
       mov       rdi,rbx
       mov       rsi,r15
       xor       edx,edx
       call      qword ptr [7102E2BB7D68]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       jmp       short M10_L03
M10_L06:
       mov       r14d,7
       jmp       near ptr M10_L00
M10_L07:
       mov       r14d,6
       jmp       near ptr M10_L00
M10_L08:
       test      esi,800000
       je        short M10_L09
       mov       r14d,4
       jmp       near ptr M10_L00
M10_L09:
       test      esi,20000
       je        short M10_L10
       mov       r14d,3
       jmp       near ptr M10_L00
M10_L10:
       test      esi,2000000
       setne     r14b
       movzx     r14d,r14b
       mov       edi,2
       test      esi,10000
       cmovne    r14d,edi
       jmp       near ptr M10_L00
M10_L11:
       add       r14d,0FFFFFFFA
       cmp       r14d,1
       ja        near ptr M10_L04
       movzx     edx,byte ptr [rbx+3D]
       mov       rdi,rbx
       mov       rsi,r15
       call      qword ptr [7102E2BB7D68]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       jmp       near ptr M10_L04
M10_L12:
       mov       rsi,r15
       mov       rdi,rax
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M10_L01
M10_L13:
       mov       rdi,r15
       mov       rax,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task>
       cmp       [rdi],rax
       je        short M10_L14
       mov       rsi,r15
       mov       rdi,rax
       call      qword ptr [7102E2484AF8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rdi,rax
M10_L14:
       cmp       [rdi],edi
       call      qword ptr [7102E2BB7D98]; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].get_Result()
       mov       rsi,rax
       jmp       near ptr M10_L02
M10_L15:
       mov       esi,1
       call      qword ptr [7102E2BBF138]
       mov       rsi,rax
       jmp       near ptr M10_L02
M10_L16:
       mov       rdi,rbx
       xor       esi,esi
       xor       edx,edx
       call      qword ptr [7102E2BB7E28]
       jmp       near ptr M10_L03
M10_L17:
       mov       rdi,rsi
       mov       rsi,rbx
       xor       edx,edx
       add       rsp,8
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7102E2BB73A8]; System.Threading.Tasks.Task.AddCompletionAction(System.Threading.Tasks.ITaskCompletionAction, Boolean)
M10_L18:
       mov       rdi,rbx
       mov       rsi,r15
       add       rsp,8
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7102E2BB7D50]
; Total bytes of code 511
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
       jne       short M11_L00
       mov       rdi,rbx
       mov       esi,0FFFFFFFF
       xor       edx,edx
       call      qword ptr [7102E2BB7990]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M11_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M11_L03
M11_L01:
       mov       edi,[rbx+34]
       and       edi,1600000
       cmp       edi,1000000
       jne       short M11_L04
M11_L02:
       pop       rbx
       pop       r15
       pop       rbp
       ret
M11_L03:
       mov       rdi,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M11_L01
       mov       rdi,rbx
       call      qword ptr [7102E2BBF8D0]
       jmp       short M11_L01
M11_L04:
       test      r15b,2
       jne       short M11_L05
       mov       rdi,rbx
       call      qword ptr [7102E2BBF8E8]
M11_L05:
       mov       rdi,rbx
       call      qword ptr [7102E2BBFF18]
       jmp       short M11_L02
; Total bytes of code 125
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.ContendedFirstCallBenchmarks.AsyncLazy()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       rbx,rdi
       mov       rdi,offset MT_AsyncLazyBenchmarks.ContendedFirstCallBenchmarks+<>c__DisplayClass9_0
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdi,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdi,75D4BCC01358
       mov       rsi,[rdi]
       lea       rdi,[r14+18]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdi,[r15+8]
       mov       rsi,r14
       call      CORINFO_HELP_ASSIGN_REF
       xor       r14d,r14d
M00_L00:
       mov       r13,[rbx+8]
       cmp       [r13+8],r14d
       jle       near ptr M00_L18
       mov       r12,[r15+10]
       test      r12,r12
       jne       short M00_L01
       mov       rdi,offset MT_System.Func<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rdi,[r12+8]
       mov       rsi,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset AsyncLazyBenchmarks.ContendedFirstCallBenchmarks+<>c__DisplayClass9_0.<AsyncLazy>b__0()
       mov       [r12+18],rdi
       lea       rdi,[r15+10]
       mov       rsi,r12
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       mov       rdi,75D4BCC01378
       mov       rax,[rdi]
       test      rax,rax
       je        near ptr M00_L30
M00_L02:
       cmp       [rax],al
       mov       rdi,75D4BCC01388
       mov       rax,[rdi]
       mov       [rbp-40],rax
       mov       rdi,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-48],rax
       lea       rdi,[rax+8]
       mov       rsi,r12
       call      CORINFO_HELP_ASSIGN_REF
       xor       edi,edi
       mov       r12,[rbp-48]
       mov       [r12+10],rdi
       lea       rdi,[r12+18]
       mov       rsi,[rbp-40]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edi,2008
       mov       [r12+34],edi
       mov       rdi,75E4FE6A0D68
       mov       rax,75E4FEF12820
       call      rax
       cmp       dword ptr [rax],4
       jle       near ptr M00_L31
       mov       rdi,[rax+8]
       mov       rax,[rdi+20]
       test      rax,rax
       je        near ptr M00_L31
M00_L03:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M00_L04
       call      qword ptr [75E48087C030]; System.Threading.Thread.InitializeCurrentThread()
M00_L04:
       mov       rax,[rax+8]
       test      rax,rax
       jne       near ptr M00_L32
       mov       rax,75D4BCC01398
       mov       rax,[rax]
M00_L05:
       test      rax,rax
       je        short M00_L07
       mov       rdi,75D4BCC01398
       mov       [rbp-50],rax
       cmp       rax,[rdi]
       je        short M00_L08
       mov       rax,[rbp-50]
       mov       rcx,[r12+28]
       test      rcx,rcx
       jne       short M00_L06
       mov       [rbp-50],rax
       mov       rdi,offset MT_System.Threading.Tasks.Task+ContingentProperties
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,rax
       mov       [rbp-58],rcx
       mov       dword ptr [rcx+3C],1
       lea       rdi,[r12+28]
       mov       rsi,rcx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-58]
       mov       rax,[rbp-50]
M00_L06:
       lea       rdi,[rcx+8]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L08
M00_L07:
       or        dword ptr [r12+34],20000000
M00_L08:
       mov       rdi,r12
       xor       esi,esi
       call      qword ptr [75E480B86AD8]; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
       mov       rdi,offset MT_System.Threading.Tasks.UnwrapPromise<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       movzx     ecx,word ptr [r12+34]
       and       ecx,4
       mov       [rbp-2C],ecx
       test      ecx,0FFFFFFBB
       jne       near ptr M00_L17
       test      cl,4
       je        near ptr M00_L11
       mov       rdi,75E4FE6A0D68
       mov       rdx,75E4FEF12820
       call      rdx
       cmp       dword ptr [rax],8
       jle       near ptr M00_L33
       mov       rdi,[rax+8]
       mov       rax,[rdi+40]
       test      rax,rax
       je        near ptr M00_L33
M00_L09:
       mov       rax,[rax+10]
       mov       [rbp-60],rax
       test      rax,rax
       je        short M00_L11
       mov       rax,[rbp-60]
       mov       rcx,[rbp-38]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M00_L10
       mov       rdi,offset MT_System.Threading.Tasks.Task+ContingentProperties
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       [rbp-68],rdx
       mov       dword ptr [rdx+3C],1
       mov       rax,[rbp-38]
       lea       rdi,[rax+28]
       mov       rsi,rdx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-68]
       mov       rax,[rbp-60]
M00_L10:
       lea       rdi,[rdx+30]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L11:
       xor       edi,edi
       mov       rax,[rbp-38]
       mov       [rax+8],rdi
       mov       [rax+10],rdi
       mov       [rax+18],rdi
       mov       ecx,[rbp-2C]
       test      ecx,0FFFFFFA0
       jne       near ptr M00_L17
       mov       edi,ecx
       or        edi,400
       or        edi,2000000
       mov       [rax+34],edi
       mov       rdi,[rax+28]
       test      rdi,rdi
       jne       near ptr M00_L34
M00_L12:
       mov       rax,[rbp-38]
       mov       byte ptr [rax+3D],1
       mov       rdi,75D4BCC013A8
       mov       rdi,[rdi]
       cmp       byte ptr [rdi+9D],0
       jne       near ptr M00_L35
M00_L13:
       cmp       byte ptr [75E47F03B06C],0
       jne       near ptr M00_L36
M00_L14:
       test      dword ptr [r12+34],1600000
       jne       near ptr M00_L41
       test      dword ptr [r12+34],1600000
       jne       near ptr M00_L37
       cmp       qword ptr [r12+20],0
       jne       short M00_L16
       lea       rdi,[r12+20]
       test      rdi,rdi
       je        near ptr M00_L49
       mov       rsi,rax
       xor       edx,edx
       call      000075E4FE474060
       test      rax,rax
       jne       near ptr M00_L38
M00_L15:
       movsxd    rsi,r14d
       mov       rdi,r13
       mov       rdx,[rbp-38]
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       r14d
       jmp       near ptr M00_L00
M00_L16:
       mov       rdi,r12
       mov       rsi,rax
       xor       edx,edx
       call      qword ptr [75E480B8C348]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       short M00_L15
       jmp       near ptr M00_L39
M00_L17:
       mov       edi,2D
       call      qword ptr [75E48002F0D8]
       int       3
M00_L18:
       mov       rsi,r13
       test      rsi,rsi
       je        near ptr M00_L43
       lea       rbx,[rsi+10]
       mov       r15d,[rsi+8]
       test      r15d,r15d
       je        near ptr M00_L44
       mov       esi,r15d
       mov       rdi,offset MT_System.Threading.Tasks.Task<System.Int32>[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       lea       rdi,[r14+10]
       mov       edx,r15d
       shl       rdx,3
       cmp       rdx,4000
       jbe       short M00_L19
       mov       rsi,rbx
       call      qword ptr [75E480C34168]
       jmp       short M00_L20
M00_L19:
       mov       rsi,rbx
       call      000075E4FE470D90
       cmp       dword ptr [75E4FE6CEC80],0
       jne       near ptr M00_L45
M00_L20:
       mov       ebx,[r14+8]
       test      ebx,ebx
       jle       short M00_L22
       lea       rdi,[r14+10]
       mov       esi,ebx
M00_L21:
       cmp       qword ptr [rdi],0
       je        near ptr M00_L46
       add       rdi,8
       dec       esi
       jne       short M00_L21
M00_L22:
       mov       rdi,offset MT_System.Threading.Tasks.Task+WhenAllPromise<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       dword ptr [r15+34],2000400
       lea       rdi,[r15+40]
       mov       rsi,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r15+48],ebx
       mov       rdi,75D4BCC013A8
       mov       rdi,[rdi]
       cmp       byte ptr [rdi+9D],0
       jne       near ptr M00_L47
M00_L23:
       cmp       byte ptr [75E47F03B06C],0
       jne       near ptr M00_L48
M00_L24:
       test      ebx,ebx
       jle       short M00_L27
       add       r14,10
M00_L25:
       mov       r13,[r14]
       test      dword ptr [r13+34],1600000
       jne       short M00_L29
       test      dword ptr [r13+34],1600000
       jne       short M00_L29
       cmp       qword ptr [r13+20],0
       jne       short M00_L28
       lea       rdi,[r13+20]
       test      rdi,rdi
       je        near ptr M00_L49
       mov       rsi,r15
       xor       edx,edx
       call      000075E4FE474060
       test      rax,rax
       jne       short M00_L28
M00_L26:
       add       r14,8
       dec       ebx
       jne       short M00_L25
M00_L27:
       mov       rax,r15
       add       rsp,48
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L28:
       mov       rdi,r13
       mov       rsi,r15
       xor       edx,edx
       call      qword ptr [75E480B8C348]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       short M00_L26
M00_L29:
       mov       rdi,r15
       mov       rsi,r13
       call      qword ptr [75E480BC8AC8]; System.Threading.Tasks.Task+WhenAllPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
       jmp       short M00_L26
M00_L30:
       mov       rdi,offset MT_System.Threading.Tasks.TaskFactory<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,75D4BCC01378
       xor       edx,edx
       call      000075E4FE474060
       test      rax,rax
       jne       near ptr M00_L02
       mov       rax,75D4BCC01378
       mov       rax,[rax]
       jmp       near ptr M00_L02
M00_L31:
       mov       edi,4
       call      qword ptr [75E480B8F798]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L03
M00_L32:
       cmp       byte ptr [rax+18],0
       je        near ptr M00_L05
       xor       eax,eax
       jmp       near ptr M00_L05
M00_L33:
       mov       edi,8
       call      qword ptr [75E480B8F798]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L09
M00_L34:
       mov       rdi,[rdi+30]
       test      rdi,rdi
       je        near ptr M00_L12
       test      cl,4
       je        near ptr M00_L12
       test      byte ptr [rdi+34],8
       jne       near ptr M00_L12
       call      qword ptr [75E480B8F6A8]
       jmp       near ptr M00_L12
M00_L35:
       mov       rdi,rax
       call      qword ptr [75E480B87540]
       mov       esi,eax
       mov       rdi,75D4BCC013A8
       mov       rdi,[rdi]
       mov       rdx,75E47C40A930
       xor       ecx,ecx
       call      qword ptr [75E480B87558]
       mov       rax,[rbp-38]
       jmp       near ptr M00_L13
M00_L36:
       mov       rdi,rax
       call      qword ptr [75E480B87570]
       mov       rax,[rbp-38]
       jmp       near ptr M00_L14
M00_L37:
       jmp       short M00_L39
M00_L38:
       mov       rax,[rbp-38]
       jmp       near ptr M00_L16
M00_L39:
       call      000075E4FE4F8300
       test      eax,eax
       je        short M00_L42
       mov       rax,[rbp-38]
       movzx     edi,byte ptr [rax+3C]
       test      edi,edi
       je        short M00_L41
       cmp       edi,1
       jne       short M00_L40
       mov       rdi,rax
       mov       rsi,r12
       xor       edx,edx
       call      qword ptr [75E480B8C1C8]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       mov       r12,[rbp-38]
       mov       byte ptr [r12+3C],2
       jmp       near ptr M00_L15
M00_L40:
       jmp       near ptr M00_L15
M00_L41:
       mov       rdi,rax
       mov       rsi,r12
       call      qword ptr [75E480B875A0]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].ProcessCompletedOuterTask(System.Threading.Tasks.Task)
       jmp       near ptr M00_L15
M00_L42:
       mov       rdi,[rbp-38]
       mov       rsi,r12
       call      qword ptr [75E480B8C180]
       jmp       near ptr M00_L15
M00_L43:
       mov       edi,33
       call      qword ptr [75E48002FAE0]
       int       3
M00_L44:
       mov       rdi,offset MT_System.Threading.Tasks.Task<System.Int32[]>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdi,r15
       xor       esi,esi
       mov       rdx,75E47C40A280
       xor       ecx,ecx
       xor       r8d,r8d
       call      qword ptr [75E480B87A08]
       jmp       near ptr M00_L27
M00_L45:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L20
M00_L46:
       mov       edi,1D
       mov       esi,33
       call      qword ptr [75E480B87A38]
       int       3
M00_L47:
       mov       rdi,r15
       call      qword ptr [75E480B87540]
       mov       esi,eax
       mov       rdi,75D4BCC013A8
       mov       rdi,[rdi]
       mov       rdx,75E47C40AFC0
       xor       ecx,ecx
       call      qword ptr [75E480B87558]
       jmp       near ptr M00_L23
M00_L48:
       mov       rdi,r15
       call      qword ptr [75E480B87570]
       jmp       near ptr M00_L24
M00_L49:
       call      qword ptr [75E480B8F408]
       int       3
; Total bytes of code 1757
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       mov       esi,[rdi+34]
       and       esi,11000000
       cmp       esi,1000000
       jne       short M01_L00
       ret
M01_L00:
       xor       esi,esi
       jmp       qword ptr [75E480B87B70]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
; Total bytes of code 26
```
```assembly
; AsyncLazyBenchmarks.ContendedFirstCallBenchmarks+<>c__DisplayClass9_0.<AsyncLazy>b__0()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rbx
       sub       rsp,10
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       rbx,[rdi+8]
       mov       rax,[rbx+10]
       test      rax,rax
       jne       near ptr M02_L18
M02_L00:
       mov       r15,[rbx+8]
       mov       rax,r15
       test      rax,rax
       je        short M02_L01
       mov       rsi,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt
       cmp       [rax],rsi
       jne       near ptr M02_L19
       xor       eax,eax
M02_L01:
       test      rax,rax
       jne       near ptr M02_L22
       test      r15,r15
       je        short M02_L02
       mov       rdi,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt
       cmp       [r15],rdi
       je        near ptr M02_L11
M02_L02:
       lea       rdi,[rbx+20]
       cmp       qword ptr [rdi],0
       jne       near ptr M02_L21
M02_L03:
       mov       rdi,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdi,offset MT_System.Threading.Tasks.TaskCompletionSource<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdi,offset MT_System.Threading.Tasks.Task<System.Int32>
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
       je        near ptr M02_L27
       mov       rsi,r14
       xor       edx,edx
       call      000075E4FE474060
       test      rax,rax
       jne       near ptr M02_L00
       mov       rdi,75D4BCC01420
       mov       rbx,[rdi]
       test      rbx,rbx
       je        near ptr M02_L28
M02_L04:
       call      qword ptr [75E480B86A90]; System.Threading.ExecutionContext.Capture()
       mov       r15,rax
       test      r15,r15
       je        short M02_L05
       cmp       byte ptr [r15+19],0
       je        near ptr M02_L29
M02_L05:
       mov       rdi,offset MT_System.Threading.QueueUserWorkItemCallbackDefaultContext<System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rdi,[r13+8]
       mov       rsi,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdi,[r13+10]
       mov       rsi,r14
       call      CORINFO_HELP_ASSIGN_REF
M02_L06:
       mov       rdi,75D4BCC013B0
       mov       rbx,[rdi]
       cmp       byte ptr [rbx+38],0
       jne       near ptr M02_L30
M02_L07:
       mov       r15,[rbx+8]
       mov       rdi,[r15+10]
       mov       rsi,r13
       cmp       [rdi],edi
       call      qword ptr [75E480B86D30]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       je        near ptr M02_L31
M02_L08:
       add       rbx,78
       mov       edi,1
       xchg      edi,[rbx]
       test      edi,edi
       jne       short M02_L09
       mov       rdi,75D4BCC013D8
       mov       rbx,[rdi]
       lea       rdi,[rbx+160]
       lock inc  dword ptr [rdi]
       mov       rdi,rbx
       call      qword ptr [75E480B86EB0]; System.Threading.PortableThreadPool+WorkerThread.MaybeAddWorkingWorker(System.Threading.PortableThreadPool)
       cmp       dword ptr [rbx+164],6
       jne       near ptr M02_L32
M02_L09:
       mov       rax,[r14+10]
       mov       rax,[rax+8]
M02_L10:
       add       rsp,10
       pop       rbx
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L11:
       mov       rdi,75D4BCC01430
       mov       r14,[rdi]
       mov       rdi,75E4FE6A0D68
       mov       rax,75E4FEF12820
       call      rax
       cmp       dword ptr [rax],4
       jle       near ptr M02_L20
       mov       rdi,[rax+8]
       mov       rax,[rdi+20]
       test      rax,rax
       je        near ptr M02_L20
M02_L12:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M02_L13
       call      qword ptr [75E48087C030]; System.Threading.Thread.InitializeCurrentThread()
M02_L13:
       mov       rdi,[rax+8]
       test      rdi,rdi
       je        short M02_L14
       mov       rdi,[rdi+8]
       lea       rdx,[rbp-28]
       mov       rsi,r14
       mov       r11,75E47F040580
       call      qword ptr [r11]
       mov       rsi,[rbp-28]
       jmp       short M02_L15
M02_L14:
       xor       esi,esi
M02_L15:
       xor       edi,edi
       mov       [rbp-28],rdi
       mov       rdi,rsi
       test      rdi,rdi
       je        short M02_L16
       mov       rax,offset MT_System.Threading.Tasks.AsyncLazyAttemptFrame
       cmp       [rdi],rax
       jne       short M02_L23
M02_L16:
       test      rdi,rdi
       jne       short M02_L24
M02_L17:
       mov       rdi,[r15+10]
       mov       rax,[rdi+8]
       jmp       near ptr M02_L10
M02_L18:
       jmp       near ptr M02_L10
M02_L19:
       mov       rsi,r15
       mov       rdi,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       jmp       near ptr M02_L01
M02_L20:
       mov       edi,4
       call      qword ptr [75E480B8F798]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M02_L12
M02_L21:
       mov       rdi,[rdi]
       cmp       dword ptr [rdi+20],0
       je        near ptr M02_L03
       jmp       short M02_L26
M02_L22:
       jmp       near ptr M02_L10
M02_L23:
       mov       rdi,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M02_L24:
       cmp       [rdi+8],r15
       je        short M02_L25
       mov       rdi,[rdi+10]
       test      rdi,rdi
       jne       short M02_L24
       jmp       short M02_L17
M02_L25:
       mov       rdi,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdi,rbx
       mov       rsi,75E47C40AFF0
       call      qword ptr [75E480875248]
       mov       rdi,rbx
       call      qword ptr [75E480B87CA8]
       jmp       near ptr M02_L10
M02_L26:
       mov       rdi,[rbx+20]
       call      qword ptr [75E480B86898]
       jmp       near ptr M02_L10
M02_L27:
       call      qword ptr [75E480B8F408]
       int       3
M02_L28:
       mov       rdi,offset MT_System.Action<System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdi,75D4BCC01418
       mov       rsi,[rdi]
       lea       rdi,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset System.Threading.Tasks.AsyncLazy`1+<>c[[System.Int32, System.Private.CoreLib]].<GetOrStartAttemptAsync>b__11_0(Attempt<Int32>)
       mov       [rbx+18],rdi
       mov       rdi,75D4BCC01420
       mov       rsi,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L04
M02_L29:
       mov       rdi,offset MT_System.Threading.QueueUserWorkItemCallback<System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdi,r13
       mov       rsi,rbx
       mov       rdx,r14
       mov       rcx,r15
       call      qword ptr [75E480C340A8]
       jmp       near ptr M02_L06
M02_L30:
       mov       rdi,75D4BCC013C8
       mov       rdi,[rdi]
       cmp       byte ptr [rdi+9D],0
       je        near ptr M02_L07
       mov       rdi,75D4BCC013C8
       mov       rdi,[rdi]
       mov       rsi,r13
       call      qword ptr [75E480B8F8A0]
       jmp       near ptr M02_L07
M02_L31:
       mov       rdi,r15
       mov       rsi,r13
       call      qword ptr [75E480B8F8B8]
       jmp       near ptr M02_L08
M02_L32:
       mov       rdi,rbx
       call      qword ptr [75E480B87108]; System.Threading.PortableThreadPool+GateThread.EnsureRunningSlow(System.Threading.PortableThreadPool)
       jmp       near ptr M02_L09
; Total bytes of code 1009
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
       call      qword ptr [75E47FBCEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdi,[rbp-90]
       call      qword ptr [rax]
       lea       rdi,[rbp-88]
       call      qword ptr [75E47FBCEF08]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-30]
       call      qword ptr [75E47FBD0B98]
       lea       rdi,[rax+10]
       mov       rsi,[rbp-30]
       call      qword ptr [75E47FBCEEB8]; CORINFO_HELP_ASSIGN_REF
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
; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
       push      rbp
       push      r15
       push      r14
       push      rbx
       push      rax
       lea       rbp,[rsp+20]
       mov       [rbp-20],rdi
       test      sil,sil
       jne       near ptr M04_L19
       or        dword ptr [rdi+34],10000
M04_L00:
       cmp       byte ptr [75E47F03B06C],0
       jne       near ptr M04_L20
M04_L01:
       mov       rax,75D4BCC013A8
       mov       rbx,[rax]
       cmp       byte ptr [rbx+9D],0
       jne       near ptr M04_L21
M04_L02:
       mov       r15,[rdi+18]
       cmp       [r15],r15b
       cmp       byte ptr [rbx+9D],0
       jne       near ptr M04_L11
M04_L03:
       mov       rsi,offset MT_System.Threading.Tasks.ThreadPoolTaskScheduler
       cmp       [r15],rsi
       jne       near ptr M04_L17
       movzx     r15d,word ptr [rdi+34]
       test      r15b,2
       jne       near ptr M04_L12
       mov       rsi,75D4BCC013B0
       mov       rbx,[rsi]
       cmp       byte ptr [rbx+38],0
       jne       near ptr M04_L13
M04_L04:
       test      r15b,1
       jne       short M04_L06
       mov       rdi,75E4FE6A0D68
       mov       rax,75E4FEF12820
       call      rax
       cmp       dword ptr [rax],5
       jle       near ptr M04_L14
       mov       rdi,[rax+8]
       mov       rax,[rdi+28]
       test      rax,rax
       je        near ptr M04_L14
M04_L05:
       mov       rdi,[rax+10]
       test      rdi,rdi
       jne       short M04_L08
M04_L06:
       mov       rsi,[rbx+8]
       mov       rcx,[rsi+10]
       mov       rdx,[rcx+8]
M04_L07:
       mov       r15d,[rcx+0A0]
       mov       eax,r15d
       and       eax,[rcx+18]
       cmp       eax,[rdx+8]
       jae       near ptr M04_L15
       shl       rax,4
       lea       r14,[rdx+rax+10]
       mov       eax,[r14+8]
       sub       eax,r15d
       jne       short M04_L09
       lea       r8,[rcx+0A0]
       lea       r9d,[r15+1]
       mov       eax,r15d
       lock cmpxchg [r8],r9d
       cmp       eax,r15d
       jne       short M04_L07
       mov       rsi,[rbp-20]
       mov       rdi,r14
       call      CORINFO_HELP_ASSIGN_REF
       inc       r15d
       mov       [r14+8],r15d
       jmp       short M04_L10
M04_L08:
       mov       rdi,[rdi+18]
       mov       rsi,[rbp-20]
       cmp       [rdi],edi
       call      qword ptr [75E480B8C930]; System.Threading.ThreadPoolWorkQueue+WorkStealingQueue.LocalPush(System.Object)
       jmp       short M04_L10
M04_L09:
       test      eax,eax
       jge       short M04_L07
       mov       rdi,rsi
       mov       rsi,[rbp-20]
       call      qword ptr [75E480B8F8B8]
M04_L10:
       add       rbx,78
       mov       edi,1
       xchg      edi,[rbx]
       test      edi,edi
       jne       near ptr M04_L18
       mov       rdi,75D4BCC013D8
       mov       rbx,[rdi]
       lea       rdi,[rbx+160]
       lock inc  dword ptr [rdi]
       mov       rdi,rbx
       call      qword ptr [75E480B86EB0]; System.Threading.PortableThreadPool+WorkerThread.MaybeAddWorkingWorker(System.Threading.PortableThreadPool)
       cmp       dword ptr [rbx+164],6
       je        near ptr M04_L18
       jmp       near ptr M04_L16
M04_L11:
       mov       rsi,r15
       call      qword ptr [75E480B8FB70]
       mov       rdi,[rbp-20]
       jmp       near ptr M04_L03
M04_L12:
       mov       rdi,offset MT_System.Threading.Tasks.ThreadPoolTaskScheduler
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdi,75D4BCC014A8
       mov       rbx,[rdi]
       mov       rdi,offset MT_System.Threading.Thread
       call      CORINFO_HELP_NEWFAST
       mov       r15,rax
       mov       rdi,r15
       mov       rsi,rbx
       call      qword ptr [75E480C34840]
       mov       rdi,r15
       mov       esi,1
       call      qword ptr [75E480B87090]; System.Threading.Thread.set_IsBackground(Boolean)
       mov       rdi,r15
       mov       rsi,75E47C40A068
       call      qword ptr [75E480B87198]; System.Threading.Thread.set_Name(System.String)
       mov       rdi,r15
       mov       rsi,[rbp-20]
       xor       edx,edx
       call      qword ptr [75E480C34858]
       jmp       short M04_L18
M04_L13:
       mov       rsi,75D4BCC013C8
       mov       rsi,[rsi]
       cmp       byte ptr [rsi+9D],0
       je        near ptr M04_L04
       mov       rsi,75D4BCC013C8
       mov       rdi,[rsi]
       mov       rsi,[rbp-20]
       call      qword ptr [75E480B8F8A0]
       jmp       near ptr M04_L04
M04_L14:
       mov       edi,5
       call      qword ptr [75E480B8F798]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M04_L05
M04_L15:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M04_L16:
       mov       rdi,rbx
       call      qword ptr [75E480B87108]; System.Threading.PortableThreadPool+GateThread.EnsureRunningSlow(System.Threading.PortableThreadPool)
       jmp       short M04_L18
M04_L17:
       mov       rdi,r15
       mov       rsi,[rbp-20]
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       nop
M04_L18:
       add       rsp,8
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       ret
M04_L19:
       call      qword ptr [75E480C34828]
       test      eax,eax
       mov       rdi,[rbp-20]
       jne       near ptr M04_L00
       jmp       short M04_L18
M04_L20:
       call      qword ptr [75E480B87570]
       mov       rdi,[rbp-20]
       jmp       near ptr M04_L01
M04_L21:
       test      word ptr [rdi+34],200
       jne       near ptr M04_L02
       call      qword ptr [75E480B87540]
       mov       r15d,eax
       mov       rdi,[rbp-20]
       mov       rdi,[rdi+8]
       call      qword ptr [75E480B8FAE0]
       mov       rsi,rax
       mov       rdi,75E47C409FE0
       call      qword ptr [75E48002EFA0]; System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       esi,r15d
       mov       rdi,rbx
       xor       ecx,ecx
       call      qword ptr [75E480B87558]
       mov       rdi,[rbp-20]
       jmp       near ptr M04_L02
       push      rax
       mov       rbx,rdi
       mov       rdi,offset MT_System.Threading.Tasks.TaskSchedulerException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdi,r15
       mov       rsi,rbx
       call      qword ptr [75E480B8FAF8]
       mov       rdi,[rbp-20]
       mov       rsi,r15
       call      qword ptr [75E480B8FB10]
       mov       rdi,[rbp-20]
       xor       esi,esi
       call      qword ptr [75E480B8FB28]
       mov       rdi,[rbp-20]
       call      qword ptr [75E480B8FB40]
       test      eax,200
       jne       short M04_L22
       mov       rdi,[rbp-20]
       mov       rdi,[rdi+28]
       mov       rdi,[rdi+18]
       xor       esi,esi
       cmp       [rdi],edi
       call      qword ptr [75E480B8FB58]
M04_L22:
       mov       rdi,r15
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 876
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       push      rbp
       mov       rbp,rsp
       mov       eax,[rdi+8]
       cmp       rax,rsi
       jbe       short M05_L02
       lea       rax,[rdi+rsi*8+10]
       mov       rdi,[rdi]
       mov       rsi,[rdi+30]
       test      rdx,rdx
       je        short M05_L01
       cmp       rsi,[rdx]
       je        short M05_L00
       mov       rcx,offset MT_System.Object[]
       cmp       rdi,rcx
       je        short M05_L00
       mov       rdi,rax
       pop       rbp
       jmp       qword ptr [75E480877A68]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
M05_L00:
       mov       rdi,rax
       mov       rsi,rdx
       pop       rbp
       jmp       near ptr 000075E4FE5FB900
M05_L01:
       xor       ecx,ecx
       mov       [rax],rcx
       pop       rbp
       ret
M05_L02:
       call      qword ptr [75E480B8F2B8]
       int       3
; Total bytes of code 85
```
```assembly
; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rbx
       sub       rsp,18
       lea       rbp,[rsp+40]
       mov       rbx,rdi
       mov       r15,rsi
       mov       r14d,edx
       mov       r13,[rbx+20]
       mov       rsi,75D4BCC00238
       cmp       r13,[rsi]
       je        near ptr M06_L05
       mov       r12,r13
       test      r12,r12
       je        short M06_L00
       mov       rsi,offset MT_System.Threading.Tasks.UnwrapPromise<System.Int32>
       cmp       [r12],rsi
       jne       near ptr M06_L06
       xor       r12d,r12d
M06_L00:
       test      r12,r12
       jne       near ptr M06_L10
       mov       rdi,offset MT_System.Collections.Generic.List<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rdi,75D4BCC00AB8
       mov       rsi,[rdi]
       lea       rdi,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      r14b,r14b
       jne       near ptr M06_L07
       inc       dword ptr [r12+14]
       mov       rdi,r12
       mov       rsi,r13
       call      qword ptr [75E4800272D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       inc       dword ptr [r12+14]
       mov       rdi,[r12+8]
       mov       esi,[r12+10]
       cmp       [rdi+8],esi
       jbe       short M06_L03
       lea       edx,[rsi+1]
       mov       [r12+10],edx
       mov       esi,esi
       mov       rdx,r15
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M06_L01:
       lea       rdi,[rbx+20]
       test      rdi,rdi
       je        near ptr M06_L09
       mov       rsi,r12
       mov       rdx,r13
       call      000075E4FE474060
       mov       r12,rax
       cmp       r12,r13
       jne       short M06_L04
M06_L02:
       mov       eax,1
       add       rsp,18
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M06_L03:
       mov       rdi,r12
       mov       rsi,r15
       call      qword ptr [75E4800272D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M06_L01
M06_L04:
       mov       rsi,r12
       mov       rdi,offset MT_System.Collections.Generic.List<System.Object>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r12,rax
       test      r12,r12
       jne       near ptr M06_L10
M06_L05:
       xor       eax,eax
       add       rsp,18
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M06_L06:
       mov       rsi,r13
       mov       rdi,offset MT_System.Collections.Generic.List<System.Object>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r12,rax
       jmp       near ptr M06_L00
M06_L07:
       inc       dword ptr [r12+14]
       mov       rdi,r12
       mov       rsi,r15
       call      qword ptr [75E4800272D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       inc       dword ptr [r12+14]
       mov       rdi,[r12+8]
       mov       esi,[r12+10]
       cmp       [rdi+8],esi
       jbe       short M06_L08
       lea       edx,[rsi+1]
       mov       [r12+10],edx
       mov       esi,esi
       mov       rdx,r13
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M06_L01
M06_L08:
       mov       rdi,r12
       mov       rsi,r13
       call      qword ptr [75E4800272D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M06_L01
M06_L09:
       call      qword ptr [75E480B8F408]
       int       3
M06_L10:
       mov       [rbp-40],r12
       xor       esi,esi
       mov       [rbp-30],esi
       lea       rsi,[rbp-30]
       mov       rdi,r12
       call      qword ptr [75E480025980]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rdi,[rbx+20]
       mov       rax,75D4BCC00238
       cmp       rdi,[rax]
       jne       short M06_L11
       xor       edi,edi
       mov       [rbp-34],edi
       jmp       near ptr M06_L17
M06_L11:
       mov       edi,[r12+10]
       mov       rax,[r12+8]
       cmp       edi,[rax+8]
       jne       short M06_L13
       mov       rdi,75D4BCC00290
       mov       rsi,[rdi]
       test      rsi,rsi
       jne       short M06_L12
       mov       rdi,offset MT_System.Predicate<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rsi,75D4BCC00260
       mov       rsi,[rsi]
       mov       rdi,rbx
       mov       rdx,75E480C30438
       call      qword ptr [75E480026E08]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdi,75D4BCC00290
       mov       rsi,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,rbx
M06_L12:
       mov       rdi,r12
       cmp       [rdi],edi
       call      qword ptr [75E480C34450]
M06_L13:
       test      r14b,r14b
       je        short M06_L14
       mov       rdi,r12
       mov       rdx,r15
       xor       esi,esi
       call      qword ptr [75E480116A30]
       jmp       short M06_L18
M06_L14:
       inc       dword ptr [r12+14]
       mov       rdi,[r12+8]
       mov       esi,[r12+10]
       cmp       [rdi+8],esi
       jbe       short M06_L15
       lea       edx,[rsi+1]
       mov       [r12+10],edx
       mov       rdx,r15
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M06_L18
M06_L15:
       mov       rdi,r12
       mov       rsi,r15
       call      qword ptr [75E4800272D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M06_L18
M06_L16:
       mov       rdi,r12
       call      qword ptr [75E480026808]; System.Threading.Monitor.Exit(System.Object)
       jmp       near ptr M06_L02
M06_L17:
       call      M06_L20
       jmp       short M06_L19
M06_L18:
       cmp       byte ptr [rbp-30],0
       je        near ptr M06_L02
       jmp       short M06_L16
M06_L19:
       mov       eax,[rbp-34]
       movzx     eax,al
       add       rsp,18
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M06_L20:
       push      rax
       cmp       byte ptr [rbp-30],0
       je        short M06_L21
       mov       rdi,[rbp-40]
       call      qword ptr [75E480026808]; System.Threading.Monitor.Exit(System.Object)
M06_L21:
       nop
       add       rsp,8
       ret
; Total bytes of code 735
```
```assembly
; System.Threading.Tasks.Task+WhenAllPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+50]
       mov       rbx,rdi
       mov       rdi,75D4BCC013A8
       mov       r15,[rdi]
       cmp       byte ptr [r15+9D],0
       jne       near ptr M07_L15
M07_L00:
       lea       rsi,[rbx+48]
       mov       edi,0FFFFFFFF
       lock xadd [rsi],edi
       dec       edi
       jne       near ptr M07_L14
       mov       rsi,[rbx+40]
       mov       esi,[rsi+8]
       mov       rdi,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       xor       r13d,r13d
       xor       r12d,r12d
       xor       eax,eax
M07_L01:
       mov       rdi,[rbx+40]
       cmp       [rdi+8],eax
       jle       near ptr M07_L09
       cmp       eax,[rdi+8]
       jae       near ptr M07_L28
       mov       [rbp-2C],eax
       mov       ecx,eax
       mov       [rbp-38],rcx
       mov       r8,[rdi+rcx*8+10]
       mov       [rbp-40],r8
       test      dword ptr [r8+34],200000
       jne       near ptr M07_L06
       mov       edi,[r8+34]
       and       edi,600000
       cmp       edi,400000
       je        near ptr M07_L17
       test      dword ptr [r8+34],1600000
       je        near ptr M07_L18
M07_L02:
       mov       edi,[r8+34]
       and       edi,1600000
       cmp       edi,1000000
       jne       near ptr M07_L19
M07_L03:
       mov       edi,[r8+38]
       mov       eax,[rbp-2C]
       cmp       eax,[r14+8]
       jae       near ptr M07_L28
       mov       rcx,[rbp-38]
       mov       [r14+rcx*4+10],edi
M07_L04:
       test      dword ptr [r8+34],10000000
       jne       near ptr M07_L20
       mov       rdi,[rbx+40]
       mov       eax,[rbp-2C]
       cmp       eax,[rdi+8]
       jae       near ptr M07_L28
       xor       esi,esi
       mov       rcx,[rbp-38]
       mov       [rdi+rcx*8+10],rsi
M07_L05:
       mov       eax,[rbp-2C]
       inc       eax
       jmp       near ptr M07_L01
M07_L06:
       test      r13,r13
       je        near ptr M07_L16
M07_L07:
       mov       rdi,[r8+28]
       mov       rdx,[rdi+18]
       mov       [rbp-48],rdx
       mov       rsi,[rdx+10]
       mov       [rbp-50],rsi
       cmp       byte ptr [rdx+20],0
       jne       short M07_L08
       mov       rdi,rdx
       call      qword ptr [75E480876868]; System.GC.SuppressFinalize(System.Object)
       mov       rdi,[rbp-48]
       mov       byte ptr [rdi+20],1
M07_L08:
       mov       rdi,r13
       mov       rsi,[rbp-50]
       cmp       [rdi],edi
       call      qword ptr [75E480B8CAE0]
       mov       r8,[rbp-40]
       jmp       short M07_L04
M07_L09:
       test      r13,r13
       jne       near ptr M07_L21
       test      r12,r12
       jne       near ptr M07_L22
       cmp       byte ptr [r15+9D],0
       jne       near ptr M07_L23
M07_L10:
       cmp       byte ptr [75E47F03B06C],0
       jne       near ptr M07_L24
M07_L11:
       mov       eax,[rbx+34]
       mov       [rbp-30],eax
       test      eax,5600000
       jne       short M07_L14
       lea       rdi,[rbx+34]
       mov       esi,eax
       or        esi,4000000
       lock cmpxchg [rdi],esi
       cmp       eax,[rbp-30]
       jne       near ptr M07_L25
M07_L12:
       lea       rdi,[rbx+38]
       mov       rsi,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdi,[rbx+34]
       mov       eax,[rbx+34]
       or        eax,1000000
       xchg      eax,[rdi]
       mov       r12,[rbx+28]
       test      r12,r12
       jne       near ptr M07_L26
M07_L13:
       lea       rdi,[rbx+20]
       test      rdi,rdi
       je        near ptr M07_L27
       mov       rsi,75D4BCC00238
       mov       rsi,[rsi]
       call      000075E4FE474040
       test      rax,rax
       je        short M07_L14
       mov       rdi,rbx
       mov       rsi,rax
       call      qword ptr [75E480B8C0D8]; System.Threading.Tasks.Task.RunContinuations(System.Object)
M07_L14:
       nop
       add       rsp,28
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M07_L15:
       mov       rdi,rbx
       call      qword ptr [75E480B87540]
       mov       esi,eax
       mov       rdi,r15
       mov       edx,1
       call      qword ptr [75E480B8C978]
       jmp       near ptr M07_L00
M07_L16:
       mov       rdi,offset MT_System.Collections.Generic.List<System.Runtime.ExceptionServices.ExceptionDispatchInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdi,r13
       call      qword ptr [75E48087F0A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       r8,[rbp-40]
       jmp       near ptr M07_L07
M07_L17:
       test      r12,r12
       jne       near ptr M07_L04
       mov       r12,r8
       mov       r8,[rbp-40]
       jmp       near ptr M07_L04
M07_L18:
       mov       rdi,r8
       mov       esi,0FFFFFFFF
       xor       edx,edx
       call      qword ptr [75E480B87B88]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
       mov       r8,[rbp-40]
       jmp       near ptr M07_L02
M07_L19:
       mov       rdi,r8
       mov       esi,1
       call      qword ptr [75E480C347F8]
       mov       r8,[rbp-40]
       jmp       near ptr M07_L03
M07_L20:
       mov       edi,[rbx+34]
       test      edi,5600000
       jne       near ptr M07_L05
       lea       rsi,[rbx+34]
       mov       edx,edi
       or        edx,10000000
       mov       eax,edi
       lock cmpxchg [rsi],edx
       cmp       eax,edi
       je        near ptr M07_L05
       mov       rdi,rbx
       mov       esi,10000000
       mov       edx,5600000
       call      qword ptr [75E480B8F990]
       jmp       near ptr M07_L05
M07_L21:
       mov       rdi,rbx
       mov       rsi,r13
       call      qword ptr [75E480B8CA50]
       jmp       near ptr M07_L14
M07_L22:
       mov       rdi,r12
       call      qword ptr [75E480B8C990]
       mov       r13,rax
       mov       rdi,r12
       call      qword ptr [75E480B8C9A8]
       mov       rdx,rax
       mov       rsi,r13
       mov       rdi,rbx
       call      qword ptr [75E480B8C9C0]
       jmp       near ptr M07_L14
M07_L23:
       mov       rdi,rbx
       call      qword ptr [75E480B87540]
       mov       esi,eax
       mov       rdi,r15
       mov       edx,1
       call      qword ptr [75E480B8CA68]
       jmp       near ptr M07_L10
M07_L24:
       mov       rdi,rbx
       call      qword ptr [75E480B8CA80]
       jmp       near ptr M07_L11
M07_L25:
       mov       rdi,rbx
       mov       esi,4000000
       mov       edx,5600000
       call      qword ptr [75E480B8F990]
       test      eax,eax
       je        near ptr M07_L14
       jmp       near ptr M07_L12
M07_L26:
       mov       rdi,rbx
       call      qword ptr [75E480B8F9A8]
       mov       rdi,r12
       call      qword ptr [75E480B8F9C0]
       jmp       near ptr M07_L13
M07_L27:
       call      qword ptr [75E480B8F408]
       int       3
M07_L28:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 921
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbp
       push      rbx
       push      rax
       lea       rbp,[rsp+10]
       mov       ebx,edi
       call      qword ptr [75E47FBE6AF0]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       edi,ebx
       and       edi,0FFFFFF
       mov       ecx,edi
       mov       edx,ebx
       sar       edx,18
       jne       short M08_L01
       cmp       [rax],edi
       jle       short M08_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       ecx,0FFFFFFFE
       movsxd    rdi,ecx
       mov       rax,[rax+rdi*8+10]
       test      rax,rax
       je        short M08_L03
M08_L00:
       add       rsp,8
       pop       rbx
       pop       rbp
       ret
M08_L01:
       mov       edi,ebx
       sar       edi,18
       cmp       edi,2
       jne       short M08_L02
       movsxd    rcx,ecx
       add       rax,rcx
       jmp       short M08_L00
M08_L02:
       cmp       [rax+4],ecx
       jle       short M08_L03
       mov       rdi,[rax+10]
       movsxd    rax,ecx
       mov       rdi,[rdi+rax*8]
       test      rdi,rdi
       je        short M08_L03
       mov       rax,[rdi]
       test      rax,rax
       je        short M08_L03
       jmp       short M08_L00
M08_L03:
       mov       edi,ebx
       lea       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       add       rsp,8
       pop       rbx
       pop       rbp
       jmp       qword ptr [rax]
; Total bytes of code 133
```
```assembly
; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rbx
       sub       rsp,10
       lea       rbp,[rsp+30]
       mov       rbx,rdi
       mov       r15,rsi
       mov       r14d,edx
M09_L00:
       mov       rdi,75D4BCC013A8
       mov       r13,[rdi]
       cmp       byte ptr [r13+9D],0
       jne       near ptr M09_L12
M09_L01:
       xor       eax,eax
       mov       edi,[r15+34]
       test      edi,200000
       jne       near ptr M09_L13
       test      edi,400000
       jne       near ptr M09_L14
       test      edi,1000000
       je        near ptr M09_L15
       mov       ecx,5
M09_L02:
       add       ecx,0FFFFFFFB
       jne       near ptr M09_L18
       cmp       byte ptr [r13+9D],0
       jne       near ptr M09_L20
M09_L03:
       cmp       byte ptr [75E47F03B06C],0
       jne       near ptr M09_L21
M09_L04:
       mov       rdi,r15
       mov       rax,offset MT_System.Threading.Tasks.Task<System.Int32>
       cmp       [rdi],rax
       jne       near ptr M09_L22
M09_L05:
       test      rdi,rdi
       je        near ptr M09_L23
       mov       esi,[rdi+34]
       and       esi,11000000
       cmp       esi,1000000
       jne       near ptr M09_L24
       mov       r15d,[rdi+38]
M09_L06:
       xor       r14d,r14d
       mov       eax,[rbx+34]
       mov       [rbp-24],eax
       test      eax,5600000
       jne       short M09_L10
       lea       rdi,[rbx+34]
       mov       esi,eax
       or        esi,4000000
       lock cmpxchg [rdi],esi
       cmp       eax,[rbp-24]
       jne       near ptr M09_L25
M09_L07:
       mov       [rbx+38],r15d
       lea       rdi,[rbx+34]
       mov       eax,[rbx+34]
       or        eax,1000000
       xchg      eax,[rdi]
       mov       r14,[rbx+28]
       test      r14,r14
       jne       near ptr M09_L26
M09_L08:
       lea       rdi,[rbx+20]
       test      rdi,rdi
       je        near ptr M09_L27
       mov       rsi,75D4BCC00238
       mov       rsi,[rsi]
       call      000075E4FE474040
       test      rax,rax
       je        short M09_L09
       mov       rdi,rbx
       mov       rsi,rax
       call      qword ptr [75E480B8C0D8]; System.Threading.Tasks.Task.RunContinuations(System.Object)
M09_L09:
       mov       r14d,1
M09_L10:
       mov       eax,r14d
M09_L11:
       add       rsp,10
       pop       rbx
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M09_L12:
       mov       rdi,rbx
       call      qword ptr [75E480B87540]
       mov       esi,eax
       mov       rdi,r13
       mov       edx,1
       call      qword ptr [75E480B8C978]
       jmp       near ptr M09_L01
M09_L13:
       mov       ecx,7
       jmp       near ptr M09_L02
M09_L14:
       mov       ecx,6
       jmp       near ptr M09_L02
M09_L15:
       test      edi,800000
       je        short M09_L16
       mov       ecx,4
       jmp       near ptr M09_L02
M09_L16:
       test      edi,20000
       je        short M09_L17
       mov       ecx,3
       jmp       near ptr M09_L02
M09_L17:
       test      edi,2000000
       setne     cl
       movzx     ecx,cl
       mov       edx,2
       test      edi,10000
       cmovne    ecx,edx
       jmp       near ptr M09_L02
M09_L18:
       cmp       ecx,2
       ja        near ptr M09_L11
       mov       edi,ecx
       lea       rax,[75E4800AEF50]
       mov       eax,[rax+rdi*4]
       lea       rcx,[M09_L00]
       add       rax,rcx
       jmp       rax
       mov       rdi,r15
       call      qword ptr [75E480B8C990]
       mov       r14,rax
       mov       rdi,r15
       call      qword ptr [75E480B8C9A8]
       mov       rdx,rax
       mov       rsi,r14
       mov       rdi,rbx
       call      qword ptr [75E480B8C9C0]
       jmp       near ptr M09_L11
       mov       rdi,r15
       call      qword ptr [75E480B8C9D8]
       mov       r15,rax
       test      r14b,r14b
       je        short M09_L19
       cmp       dword ptr [r15+10],0
       jle       short M09_L19
       mov       rdi,r15
       xor       esi,esi
       call      qword ptr [75E4801169B8]
       mov       r13,rax
       test      r13,r13
       je        short M09_L19
       mov       rsi,[r13+8]
       mov       rdi,offset MT_System.OperationCanceledException
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M09_L19
       mov       rsi,[rax+70]
       mov       rdi,rbx
       mov       rdx,r13
       call      qword ptr [75E480B8C9C0]
       jmp       near ptr M09_L11
M09_L19:
       mov       rdi,rbx
       mov       rsi,r15
       call      qword ptr [75E480B8CA50]
       jmp       near ptr M09_L11
M09_L20:
       mov       rdi,rbx
       call      qword ptr [75E480B87540]
       mov       esi,eax
       mov       rdi,r13
       mov       edx,1
       call      qword ptr [75E480B8CA68]
       jmp       near ptr M09_L03
M09_L21:
       mov       rdi,rbx
       call      qword ptr [75E480B8CA80]
       jmp       near ptr M09_L04
M09_L22:
       mov       rsi,r15
       mov       rdi,rax
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M09_L05
M09_L23:
       xor       r15d,r15d
       jmp       near ptr M09_L06
M09_L24:
       mov       esi,1
       call      qword ptr [75E480B8CAF8]; System.Threading.Tasks.Task`1[[System.Int32, System.Private.CoreLib]].GetResultCore(Boolean)
       mov       r15d,eax
       jmp       near ptr M09_L06
M09_L25:
       mov       rdi,rbx
       mov       esi,4000000
       mov       edx,5600000
       call      qword ptr [75E480B8F990]
       test      eax,eax
       je        near ptr M09_L10
       jmp       near ptr M09_L07
M09_L26:
       mov       rdi,rbx
       call      qword ptr [75E480B8F9A8]
       mov       rdi,r14
       call      qword ptr [75E480B8F9C0]
       jmp       near ptr M09_L08
M09_L27:
       call      qword ptr [75E480B8F408]
       int       3
; Total bytes of code 782
```
```assembly
; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].ProcessCompletedOuterTask(System.Threading.Tasks.Task)
       push      rbp
       push      r15
       push      r14
       push      rbx
       push      rax
       lea       rbp,[rsp+20]
       mov       rbx,rdi
       mov       r15,rsi
       mov       byte ptr [rbx+3C],1
       mov       esi,[r15+34]
       test      esi,200000
       jne       near ptr M10_L08
       test      esi,400000
       jne       near ptr M10_L09
       test      esi,1000000
       je        near ptr M10_L10
       mov       r14d,5
M10_L00:
       cmp       r14d,5
       jne       near ptr M10_L07
       mov       rdi,r15
       mov       rax,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task<System.Int32>>
       cmp       [rdi],rax
       jne       near ptr M10_L14
M10_L01:
       test      rdi,rdi
       je        near ptr M10_L15
       mov       esi,[rdi+34]
       and       esi,11000000
       cmp       esi,1000000
       jne       near ptr M10_L17
       mov       r14,[rdi+38]
M10_L02:
       test      r14,r14
       je        near ptr M10_L18
       test      dword ptr [r14+34],1600000
       jne       short M10_L05
       test      dword ptr [r14+34],1600000
       jne       near ptr M10_L20
       cmp       qword ptr [r14+20],0
       jne       short M10_L04
       lea       rdi,[r14+20]
       test      rdi,rdi
       je        near ptr M10_L19
       mov       rsi,rbx
       xor       edx,edx
       call      000075E4FE474060
       test      rax,rax
       jne       short M10_L04
M10_L03:
       add       rsp,8
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       ret
M10_L04:
       mov       rdi,r14
       mov       rsi,rbx
       xor       edx,edx
       call      qword ptr [75E480B8C348]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       short M10_L03
       jmp       near ptr M10_L20
M10_L05:
       mov       rdi,rbx
       mov       rsi,r14
       xor       edx,edx
       call      qword ptr [75E480B8C1C8]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
M10_L06:
       mov       byte ptr [rbx+3C],2
       jmp       short M10_L03
M10_L07:
       add       r14d,0FFFFFFFA
       cmp       r14d,1
       ja        short M10_L03
       jmp       short M10_L13
M10_L08:
       mov       r14d,7
       jmp       near ptr M10_L00
M10_L09:
       mov       r14d,6
       jmp       near ptr M10_L00
M10_L10:
       test      esi,800000
       je        short M10_L11
       mov       r14d,4
       jmp       near ptr M10_L00
M10_L11:
       test      esi,20000
       je        short M10_L12
       mov       r14d,3
       jmp       near ptr M10_L00
M10_L12:
       test      esi,2000000
       setne     r14b
       movzx     r14d,r14b
       mov       edi,2
       test      esi,10000
       cmovne    r14d,edi
       jmp       near ptr M10_L00
M10_L13:
       movzx     edx,byte ptr [rbx+3D]
       mov       rdi,rbx
       mov       rsi,r15
       call      qword ptr [75E480B8C1C8]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       jmp       near ptr M10_L03
M10_L14:
       mov       rsi,r15
       mov       rdi,rax
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M10_L01
M10_L15:
       mov       rdi,r15
       mov       rax,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task>
       cmp       [rdi],rax
       je        short M10_L16
       mov       rsi,r15
       mov       rdi,rax
       call      qword ptr [75E480454AF8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rdi,rax
M10_L16:
       cmp       [rdi],edi
       call      qword ptr [75E480B8C258]; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].get_Result()
       mov       r14,rax
       jmp       near ptr M10_L02
M10_L17:
       mov       esi,1
       call      qword ptr [75E480B8FA68]
       mov       r14,rax
       jmp       near ptr M10_L02
M10_L18:
       mov       rdi,rbx
       xor       esi,esi
       xor       edx,edx
       call      qword ptr [75E480B8C9C0]
       jmp       near ptr M10_L06
M10_L19:
       call      qword ptr [75E480B8F408]
       int       3
M10_L20:
       mov       rdi,rbx
       mov       rsi,r14
       add       rsp,8
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [75E480BBB658]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
; Total bytes of code 517
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
       jne       short M11_L00
       mov       rdi,rbx
       mov       esi,0FFFFFFFF
       xor       edx,edx
       call      qword ptr [75E480B87B88]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M11_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M11_L03
M11_L01:
       mov       edi,[rbx+34]
       and       edi,1600000
       cmp       edi,1000000
       jne       short M11_L04
M11_L02:
       pop       rbx
       pop       r15
       pop       rbp
       ret
M11_L03:
       mov       rdi,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M11_L01
       mov       rdi,rbx
       call      qword ptr [75E480B8FFD8]
       jmp       short M11_L01
M11_L04:
       test      r15b,2
       jne       short M11_L05
       mov       rdi,rbx
       call      qword ptr [75E480C34180]
M11_L05:
       mov       rdi,rbx
       call      qword ptr [75E480C34990]
       jmp       short M11_L02
; Total bytes of code 125
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.ContendedFirstCallBenchmarks.Nito()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       rbx,rdi
       mov       rdi,offset MT_AsyncLazyBenchmarks.ContendedFirstCallBenchmarks+<>c__DisplayClass10_0
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdi,offset MT_Nito.AsyncEx.AsyncLazy<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdi,729CCCC01358
       mov       r13,[rdi]
       mov       rsi,r13
       lea       rdi,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset MT_Nito.AsyncEx.AsyncLazy<System.Int32>+<>c__DisplayClass14_0
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rdi,[r12+8]
       mov       rsi,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset MT_System.Func<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rdi,[r13+8]
       mov       rsi,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset Nito.AsyncEx.AsyncLazy`1+<>c__DisplayClass14_0[[System.Int32, System.Private.CoreLib]].<RunOnThreadPool>b__0()
       mov       [r13+18],rdi
       lea       rdi,[r14+10]
       mov       rsi,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rdi,[r14+8]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset MT_System.Lazy<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rsi,[r14+10]
       lea       rdi,[r13+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset MT_System.LazyHelper
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+10],8
       lea       rdi,[r13+8]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdi,[r14+18]
       mov       rsi,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdi,[r15+8]
       mov       rsi,r14
       call      CORINFO_HELP_ASSIGN_REF
       xor       r14d,r14d
M00_L00:
       mov       r13,[rbx+8]
       cmp       [r13+8],r14d
       jle       near ptr M00_L21
       mov       r12,[r15+10]
       test      r12,r12
       jne       short M00_L01
       mov       rdi,offset MT_System.Func<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rdi,[r12+8]
       mov       rsi,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset AsyncLazyBenchmarks.ContendedFirstCallBenchmarks+<>c__DisplayClass10_0.<Nito>b__0()
       mov       [r12+18],rdi
       lea       rdi,[r15+10]
       mov       rsi,r12
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       mov       rdi,729CCCC01378
       mov       rax,[rdi]
       test      rax,rax
       je        near ptr M00_L33
M00_L02:
       cmp       [rax],al
       mov       rdi,729CCCC01388
       mov       rax,[rdi]
       mov       [rbp-40],rax
       mov       rdi,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-48],rax
       lea       rdi,[rax+8]
       mov       rsi,r12
       call      CORINFO_HELP_ASSIGN_REF
       xor       edi,edi
       mov       r12,[rbp-48]
       mov       [r12+10],rdi
       lea       rdi,[r12+18]
       mov       rsi,[rbp-40]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edi,2008
       mov       [r12+34],edi
       mov       rdi,72AD0DAA0D68
       mov       rax,72AD0E481820
       call      rax
       cmp       dword ptr [rax],4
       jle       near ptr M00_L34
       mov       rdi,[rax+8]
       mov       rax,[rdi+20]
       test      rax,rax
       je        near ptr M00_L34
M00_L03:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M00_L04
       call      qword ptr [72AC8FC8C030]; System.Threading.Thread.InitializeCurrentThread()
M00_L04:
       mov       rax,[rax+8]
       test      rax,rax
       jne       short M00_L08
       mov       rax,729CCCC01398
       mov       rax,[rax]
M00_L05:
       test      rax,rax
       jne       short M00_L09
       or        dword ptr [r12+34],20000000
M00_L06:
       mov       rdi,r12
       xor       esi,esi
       call      qword ptr [72AC8FF96B50]; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
       mov       rdi,offset MT_System.Threading.Tasks.UnwrapPromise<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       movzx     ecx,word ptr [r12+34]
       and       ecx,4
       mov       [rbp-2C],ecx
       test      ecx,0FFFFFFBB
       je        near ptr M00_L11
M00_L07:
       mov       edi,2D
       call      qword ptr [72AC8F43F0D8]
       int       3
M00_L08:
       cmp       byte ptr [rax+18],0
       je        short M00_L05
       xor       eax,eax
       jmp       short M00_L05
M00_L09:
       mov       rdi,729CCCC01398
       mov       [rbp-50],rax
       cmp       rax,[rdi]
       je        short M00_L06
       mov       rax,[rbp-50]
       mov       rcx,[r12+28]
       test      rcx,rcx
       jne       short M00_L10
       mov       [rbp-50],rax
       mov       rdi,offset MT_System.Threading.Tasks.Task+ContingentProperties
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,rax
       mov       [rbp-58],rcx
       mov       dword ptr [rcx+3C],1
       lea       rdi,[r12+28]
       mov       rsi,rcx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-58]
       mov       rax,[rbp-50]
M00_L10:
       lea       rdi,[rcx+8]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L06
M00_L11:
       test      cl,4
       je        near ptr M00_L14
       mov       rdi,72AD0DAA0D68
       mov       rdx,72AD0E481820
       call      rdx
       cmp       dword ptr [rax],8
       jle       near ptr M00_L35
       mov       rdi,[rax+8]
       mov       rax,[rdi+40]
       test      rax,rax
       je        near ptr M00_L35
M00_L12:
       mov       rax,[rax+10]
       mov       [rbp-60],rax
       test      rax,rax
       je        short M00_L14
       mov       rax,[rbp-60]
       mov       rcx,[rbp-38]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M00_L13
       mov       rdi,offset MT_System.Threading.Tasks.Task+ContingentProperties
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       [rbp-68],rdx
       mov       dword ptr [rdx+3C],1
       mov       rax,[rbp-38]
       lea       rdi,[rax+28]
       mov       rsi,rdx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-68]
       mov       rax,[rbp-60]
M00_L13:
       lea       rdi,[rdx+30]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L14:
       xor       edi,edi
       mov       rax,[rbp-38]
       mov       [rax+8],rdi
       mov       [rax+10],rdi
       mov       [rax+18],rdi
       mov       ecx,[rbp-2C]
       test      ecx,0FFFFFFA0
       jne       near ptr M00_L07
       mov       edi,ecx
       or        edi,400
       or        edi,2000000
       mov       [rax+34],edi
       mov       rdi,[rax+28]
       test      rdi,rdi
       jne       near ptr M00_L36
M00_L15:
       mov       rax,[rbp-38]
       mov       byte ptr [rax+3D],1
       mov       rdi,729CCCC013A8
       mov       rdi,[rdi]
       cmp       byte ptr [rdi+9D],0
       jne       near ptr M00_L37
M00_L16:
       cmp       byte ptr [72AC8E44B06C],0
       jne       near ptr M00_L38
M00_L17:
       test      dword ptr [r12+34],1600000
       jne       near ptr M00_L42
       test      dword ptr [r12+34],1600000
       jne       short M00_L20
       cmp       qword ptr [r12+20],0
       jne       short M00_L19
       lea       rdi,[r12+20]
       test      rdi,rdi
       je        near ptr M00_L50
       mov       rsi,rax
       xor       edx,edx
       call      000072AD0D874060
       test      rax,rax
       jne       near ptr M00_L39
M00_L18:
       movsxd    rsi,r14d
       mov       rdi,r13
       mov       rdx,[rbp-38]
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       r14d
       jmp       near ptr M00_L00
M00_L19:
       mov       rdi,r12
       mov       rsi,rax
       xor       edx,edx
       call      qword ptr [72AC8FF9C030]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       short M00_L18
       jmp       short M00_L20
M00_L20:
       call      000072AD0D8F8300
       test      eax,eax
       je        near ptr M00_L43
       mov       rax,[rbp-38]
       movzx     edi,byte ptr [rax+3C]
       test      edi,edi
       je        near ptr M00_L42
       jmp       near ptr M00_L40
M00_L21:
       mov       rsi,r13
       test      rsi,rsi
       je        near ptr M00_L44
       lea       rbx,[rsi+10]
       mov       r15d,[rsi+8]
       test      r15d,r15d
       je        near ptr M00_L45
       mov       esi,r15d
       mov       rdi,offset MT_System.Threading.Tasks.Task<System.Int32>[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       lea       rdi,[r14+10]
       mov       edx,r15d
       shl       rdx,3
       cmp       rdx,4000
       jbe       short M00_L22
       mov       rsi,rbx
       call      qword ptr [72AC8FF9FA98]
       jmp       short M00_L23
M00_L22:
       mov       rsi,rbx
       call      000072AD0D870D90
       cmp       dword ptr [72AD0DACEC80],0
       jne       near ptr M00_L46
M00_L23:
       mov       ebx,[r14+8]
       test      ebx,ebx
       jle       short M00_L25
       lea       rdi,[r14+10]
       mov       esi,ebx
M00_L24:
       cmp       qword ptr [rdi],0
       je        near ptr M00_L47
       add       rdi,8
       dec       esi
       jne       short M00_L24
M00_L25:
       mov       rdi,offset MT_System.Threading.Tasks.Task+WhenAllPromise<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       dword ptr [r15+34],2000400
       lea       rdi,[r15+40]
       mov       rsi,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r15+48],ebx
       mov       rdi,729CCCC013A8
       mov       rdi,[rdi]
       cmp       byte ptr [rdi+9D],0
       jne       near ptr M00_L48
M00_L26:
       cmp       byte ptr [72AC8E44B06C],0
       jne       near ptr M00_L49
M00_L27:
       test      ebx,ebx
       jle       short M00_L30
       add       r14,10
M00_L28:
       mov       r13,[r14]
       test      dword ptr [r13+34],1600000
       jne       short M00_L32
       test      dword ptr [r13+34],1600000
       jne       short M00_L32
       cmp       qword ptr [r13+20],0
       jne       short M00_L31
       lea       rdi,[r13+20]
       test      rdi,rdi
       je        near ptr M00_L50
       mov       rsi,r15
       xor       edx,edx
       call      000072AD0D874060
       test      rax,rax
       jne       short M00_L31
M00_L29:
       add       r14,8
       dec       ebx
       jne       short M00_L28
M00_L30:
       mov       rax,r15
       add       rsp,48
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L31:
       mov       rdi,r13
       mov       rsi,r15
       xor       edx,edx
       call      qword ptr [72AC8FF9C030]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       short M00_L29
M00_L32:
       mov       rdi,r15
       mov       rsi,r13
       call      qword ptr [72AC8FFD99C0]; System.Threading.Tasks.Task+WhenAllPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
       jmp       short M00_L29
M00_L33:
       mov       rdi,offset MT_System.Threading.Tasks.TaskFactory<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,729CCCC01378
       xor       edx,edx
       call      000072AD0D874060
       test      rax,rax
       jne       near ptr M00_L02
       mov       rax,729CCCC01378
       mov       rax,[rax]
       jmp       near ptr M00_L02
M00_L34:
       mov       edi,4
       call      qword ptr [72AC8FF9EFA0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L03
M00_L35:
       mov       edi,8
       call      qword ptr [72AC8FF9EFA0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L12
M00_L36:
       mov       rdi,[rdi+30]
       test      rdi,rdi
       je        near ptr M00_L15
       test      cl,4
       je        near ptr M00_L15
       test      byte ptr [rdi+34],8
       jne       near ptr M00_L15
       call      qword ptr [72AC8FF9EB98]
       jmp       near ptr M00_L15
M00_L37:
       mov       rdi,rax
       call      qword ptr [72AC8FF974C8]
       mov       esi,eax
       mov       rdi,729CCCC013A8
       mov       rdi,[rdi]
       mov       rdx,72AC7E40AC10
       xor       ecx,ecx
       call      qword ptr [72AC8FF974E0]
       mov       rax,[rbp-38]
       jmp       near ptr M00_L16
M00_L38:
       mov       rdi,rax
       call      qword ptr [72AC8FF974F8]
       mov       rax,[rbp-38]
       jmp       near ptr M00_L17
M00_L39:
       mov       rax,[rbp-38]
       jmp       near ptr M00_L19
M00_L40:
       cmp       edi,1
       jne       short M00_L41
       mov       rdi,rax
       mov       rsi,r12
       xor       edx,edx
       call      qword ptr [72AC8FF97F48]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       mov       r12,[rbp-38]
       mov       byte ptr [r12+3C],2
       jmp       near ptr M00_L18
M00_L41:
       jmp       near ptr M00_L18
M00_L42:
       mov       rdi,rax
       mov       rsi,r12
       call      qword ptr [72AC8FF97528]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].ProcessCompletedOuterTask(System.Threading.Tasks.Task)
       jmp       near ptr M00_L18
M00_L43:
       mov       rdi,[rbp-38]
       mov       rsi,r12
       call      qword ptr [72AC8FF97F30]
       jmp       near ptr M00_L18
M00_L44:
       mov       edi,33
       call      qword ptr [72AC8F43FAE0]
       int       3
M00_L45:
       mov       rdi,offset MT_System.Threading.Tasks.Task<System.Int32[]>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdi,r15
       xor       esi,esi
       mov       rdx,72AC7E40A258
       xor       ecx,ecx
       xor       r8d,r8d
       call      qword ptr [72AC8FF97948]
       jmp       near ptr M00_L30
M00_L46:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L23
M00_L47:
       mov       edi,1D
       mov       esi,33
       call      qword ptr [72AC8FF97978]
       int       3
M00_L48:
       mov       rdi,r15
       call      qword ptr [72AC8FF974C8]
       mov       esi,eax
       mov       rdi,729CCCC013A8
       mov       rdi,[rdi]
       mov       rdx,72AC7E40AF98
       xor       ecx,ecx
       call      qword ptr [72AC8FF974E0]
       jmp       near ptr M00_L26
M00_L49:
       mov       rdi,r15
       call      qword ptr [72AC8FF974F8]
       jmp       near ptr M00_L27
M00_L50:
       call      qword ptr [72AC8FF9EB80]
       int       3
; Total bytes of code 1947
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       mov       esi,[rdi+34]
       and       esi,11000000
       cmp       esi,1000000
       jne       short M01_L00
       ret
M01_L00:
       xor       esi,esi
       jmp       qword ptr [72AC8FF97B40]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
; Total bytes of code 26
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
       je        near ptr M02_L18
       mov       r15,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task<System.Int32>>
       mov       rdi,r15
       call      qword ptr [72AC8FF96958]; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].get_Factory()
       cmp       [rax],al
       mov       rdi,729CCCC01388
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
       mov       rdi,72AD0DAA0D68
       mov       rax,72AD0E481820
       call      rax
       cmp       dword ptr [rax],4
       jle       near ptr M02_L17
       mov       rdi,[rax+8]
       mov       rax,[rdi+20]
       test      rax,rax
       je        near ptr M02_L17
M02_L00:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M02_L01
       call      qword ptr [72AC8FC8C030]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       rbx,[rax+8]
       test      rbx,rbx
       je        short M02_L02
       xor       edi,edi
       cmp       byte ptr [rbx+18],0
       cmovne    rbx,rdi
       jmp       short M02_L03
M02_L02:
       mov       rdi,729CCCC01398
       mov       rbx,[rdi]
M02_L03:
       test      rbx,rbx
       je        short M02_L05
       mov       rdi,729CCCC01398
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
       call      qword ptr [72AC8FF96B50]; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
       mov       rdi,offset MT_System.Threading.Tasks.UnwrapPromise<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       movzx     r14d,word ptr [r15+34]
       and       r14d,4
       test      r14d,0FFFFFFBB
       jne       near ptr M02_L16
       test      r14b,4
       je        short M02_L09
       mov       rdi,72AD0DAA0D68
       mov       rax,72AD0E481820
       call      rax
       cmp       dword ptr [rax],8
       jle       near ptr M02_L19
       mov       rdi,[rax+8]
       mov       rax,[rdi+40]
       test      rax,rax
       je        near ptr M02_L19
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
       jne       near ptr M02_L16
       mov       edi,r14d
       or        edi,400
       or        edi,2000000
       mov       [rbx+34],edi
       mov       rdi,[rbx+28]
       test      rdi,rdi
       jne       near ptr M02_L20
M02_L10:
       mov       byte ptr [rbx+3D],1
       mov       rdi,729CCCC013A8
       mov       rdi,[rdi]
       cmp       byte ptr [rdi+9D],0
       jne       near ptr M02_L21
M02_L11:
       cmp       byte ptr [72AC8E44B06C],0
       jne       near ptr M02_L22
M02_L12:
       test      dword ptr [r15+34],1600000
       jne       near ptr M02_L23
       test      dword ptr [r15+34],1600000
       jne       short M02_L15
       cmp       qword ptr [r15+20],0
       jne       short M02_L14
       lea       rdi,[r15+20]
       test      rdi,rdi
       je        near ptr M02_L24
       mov       rsi,rbx
       xor       edx,edx
       call      000072AD0D874060
       test      rax,rax
       jne       short M02_L14
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
       mov       rdi,r15
       mov       rsi,rbx
       xor       edx,edx
       call      qword ptr [72AC8FF9C030]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       short M02_L13
M02_L15:
       mov       rdi,rbx
       mov       rsi,r15
       call      qword ptr [72AC8FFCC800]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
       jmp       short M02_L13
M02_L16:
       mov       edi,2D
       call      qword ptr [72AC8F43F0D8]
       int       3
M02_L17:
       mov       edi,4
       call      qword ptr [72AC8FF9EFA0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M02_L00
M02_L18:
       mov       edi,2E
       call      qword ptr [72AC8F43FAE0]
       int       3
M02_L19:
       mov       edi,8
       call      qword ptr [72AC8FF9EFA0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M02_L07
M02_L20:
       mov       rdi,[rdi+30]
       test      rdi,rdi
       je        near ptr M02_L10
       test      r14b,4
       je        near ptr M02_L10
       test      byte ptr [rdi+34],8
       jne       near ptr M02_L10
       call      qword ptr [72AC8FF9EB98]
       jmp       near ptr M02_L10
M02_L21:
       mov       rdi,rbx
       call      qword ptr [72AC8FF974C8]
       mov       esi,eax
       mov       rdi,729CCCC013A8
       mov       rdi,[rdi]
       mov       rdx,72AC7E40AC10
       xor       ecx,ecx
       call      qword ptr [72AC8FF974E0]
       jmp       near ptr M02_L11
M02_L22:
       mov       rdi,rbx
       call      qword ptr [72AC8FF974F8]
       jmp       near ptr M02_L12
M02_L23:
       mov       rdi,rbx
       mov       rsi,r15
       call      qword ptr [72AC8FF97528]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].ProcessCompletedOuterTask(System.Threading.Tasks.Task)
       jmp       near ptr M02_L13
M02_L24:
       call      qword ptr [72AC8FF9EB80]
       int       3
; Total bytes of code 874
```
```assembly
; AsyncLazyBenchmarks.ContendedFirstCallBenchmarks+<>c__DisplayClass10_0.<Nito>b__0()
       push      rbp
       push      rbx
       sub       rsp,18
       lea       rbp,[rsp+20]
       mov       rbx,[rdi+8]
       mov       rdi,[rbx+8]
       mov       [rbp-18],rdi
       xor       eax,eax
       mov       [rbp-0C],eax
       test      rdi,rdi
       je        short M03_L02
       call      000072AD0D6E6020
       test      eax,eax
       je        short M03_L03
M03_L00:
       mov       dword ptr [rbp-0C],1
       mov       rdi,[rbx+18]
       cmp       qword ptr [rdi+8],0
       je        short M03_L01
       call      qword ptr [72AC8FC8C420]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rbx,rax
       jmp       short M03_L04
M03_L01:
       mov       rbx,[rdi+18]
       jmp       short M03_L04
M03_L02:
       xor       edi,edi
       call      qword ptr [72AC8FF9EF28]
       int       3
M03_L03:
       mov       rdi,[rbp-18]
       call      qword ptr [72AC8FF97C00]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M03_L00
M03_L04:
       mov       rdi,[rbp-18]
       call      000072AD0D6E6790
       test      eax,eax
       jne       short M03_L06
M03_L05:
       mov       rax,rbx
       add       rsp,18
       pop       rbx
       pop       rbp
       ret
M03_L06:
       mov       edi,eax
       mov       rsi,[rbp-18]
       call      qword ptr [72AC8FF97DB0]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       short M03_L05
       push      rax
       cmp       dword ptr [rbp-0C],0
       je        short M03_L08
       cmp       qword ptr [rbp-18],0
       jne       short M03_L07
       xor       edi,edi
       call      qword ptr [72AC8FF9EF28]
       int       3
M03_L07:
       mov       rdi,[rbp-18]
       call      000072AD0D6E6790
       test      eax,eax
       je        short M03_L08
       mov       edi,eax
       mov       rsi,[rbp-18]
       call      qword ptr [72AC8FF97DB0]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M03_L08:
       nop
       add       rsp,8
       ret
; Total bytes of code 189
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
       call      qword ptr [72AC8EFDEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdi,[rbp-90]
       call      qword ptr [rax]
       lea       rdi,[rbp-88]
       call      qword ptr [72AC8EFDEF08]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-30]
       call      qword ptr [72AC8EFE0B98]
       lea       rdi,[rax+10]
       mov       rsi,[rbp-30]
       call      qword ptr [72AC8EFDEEB8]; CORINFO_HELP_ASSIGN_REF
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
; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
       push      rbp
       push      r15
       push      r14
       push      rbx
       sub       rsp,18
       lea       rbp,[rsp+30]
       mov       [rbp-28],rdi
       test      sil,sil
       jne       near ptr M05_L19
       or        dword ptr [rdi+34],10000
M05_L00:
       cmp       byte ptr [72AC8E44B06C],0
       jne       near ptr M05_L20
M05_L01:
       mov       rax,729CCCC013A8
       mov       rbx,[rax]
       cmp       byte ptr [rbx+9D],0
       jne       near ptr M05_L21
M05_L02:
       mov       r15,[rdi+18]
       cmp       [r15],r15b
       cmp       byte ptr [rbx+9D],0
       jne       near ptr M05_L11
M05_L03:
       mov       rsi,offset MT_System.Threading.Tasks.ThreadPoolTaskScheduler
       cmp       [r15],rsi
       jne       near ptr M05_L17
       movzx     r15d,word ptr [rdi+34]
       test      r15b,2
       jne       near ptr M05_L12
       mov       rsi,729CCCC013B0
       mov       rbx,[rsi]
       cmp       byte ptr [rbx+38],0
       jne       near ptr M05_L13
M05_L04:
       test      r15b,1
       jne       short M05_L06
       mov       rdi,72AD0DAA0D68
       mov       rax,72AD0E481820
       call      rax
       cmp       dword ptr [rax],5
       jle       near ptr M05_L14
       mov       rdi,[rax+8]
       mov       rax,[rdi+28]
       test      rax,rax
       je        near ptr M05_L14
M05_L05:
       mov       rdi,[rax+10]
       test      rdi,rdi
       jne       short M05_L08
M05_L06:
       mov       rsi,[rbx+8]
       mov       rcx,[rsi+10]
       mov       rdx,[rcx+8]
M05_L07:
       mov       r15d,[rcx+0A0]
       mov       eax,r15d
       and       eax,[rcx+18]
       cmp       eax,[rdx+8]
       jae       near ptr M05_L15
       shl       rax,4
       lea       r14,[rdx+rax+10]
       mov       eax,[r14+8]
       sub       eax,r15d
       jne       short M05_L09
       lea       r8,[rcx+0A0]
       lea       r9d,[r15+1]
       mov       eax,r15d
       lock cmpxchg [r8],r9d
       cmp       eax,r15d
       jne       short M05_L07
       mov       rsi,[rbp-28]
       mov       rdi,r14
       call      CORINFO_HELP_ASSIGN_REF
       inc       r15d
       mov       [r14+8],r15d
       jmp       short M05_L10
M05_L08:
       mov       rdi,[rdi+18]
       mov       rsi,[rbp-28]
       cmp       [rdi],edi
       call      qword ptr [72AC8FF97CD8]; System.Threading.ThreadPoolWorkQueue+WorkStealingQueue.LocalPush(System.Object)
       jmp       short M05_L10
M05_L09:
       test      eax,eax
       jge       short M05_L07
       mov       rdi,rsi
       mov       rsi,[rbp-28]
       call      qword ptr [72AC8FF9F258]
M05_L10:
       add       rbx,78
       mov       edi,1
       xchg      edi,[rbx]
       test      edi,edi
       jne       near ptr M05_L18
       mov       rdi,729CCCC013D8
       mov       rbx,[rdi]
       lea       rdi,[rbx+160]
       lock inc  dword ptr [rdi]
       mov       rdi,rbx
       call      qword ptr [72AC8FF96F28]; System.Threading.PortableThreadPool+WorkerThread.MaybeAddWorkingWorker(System.Threading.PortableThreadPool)
       cmp       dword ptr [rbx+164],6
       je        near ptr M05_L18
       jmp       near ptr M05_L16
M05_L11:
       mov       rsi,r15
       call      qword ptr [72AC8FF9F150]
       mov       rdi,[rbp-28]
       jmp       near ptr M05_L03
M05_L12:
       mov       rdi,offset MT_System.Threading.Tasks.ThreadPoolTaskScheduler
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdi,729CCCC01460
       mov       rbx,[rdi]
       mov       rdi,offset MT_System.Threading.Thread
       call      CORINFO_HELP_NEWFAST
       mov       r15,rax
       mov       rdi,r15
       mov       rsi,rbx
       call      qword ptr [72AC8FF9FED0]
       mov       rdi,r15
       mov       esi,1
       call      qword ptr [72AC8FF97108]; System.Threading.Thread.set_IsBackground(Boolean)
       mov       rdi,r15
       mov       rsi,72AC7E40A040
       call      qword ptr [72AC8FF97210]; System.Threading.Thread.set_Name(System.String)
       mov       rdi,r15
       mov       rsi,[rbp-28]
       xor       edx,edx
       call      qword ptr [72AC8FF9FEE8]
       jmp       short M05_L18
M05_L13:
       mov       rsi,729CCCC013C8
       mov       rsi,[rsi]
       cmp       byte ptr [rsi+9D],0
       je        near ptr M05_L04
       mov       rsi,729CCCC013C8
       mov       rdi,[rsi]
       mov       rsi,[rbp-28]
       call      qword ptr [72AC8FF9F240]
       jmp       near ptr M05_L04
M05_L14:
       mov       edi,5
       call      qword ptr [72AC8FF9EFA0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M05_L05
M05_L15:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M05_L16:
       mov       rdi,rbx
       call      qword ptr [72AC8FF97180]; System.Threading.PortableThreadPool+GateThread.EnsureRunningSlow(System.Threading.PortableThreadPool)
       jmp       short M05_L18
M05_L17:
       mov       rdi,r15
       mov       rsi,[rbp-28]
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       nop
M05_L18:
       add       rsp,18
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       ret
M05_L19:
       mov       eax,[rdi+34]
       mov       [rbp-1C],eax
       test      eax,410000
       jne       short M05_L18
       lea       rsi,[rdi+34]
       mov       edx,eax
       or        edx,10000
       lock cmpxchg [rsi],edx
       cmp       eax,[rbp-1C]
       je        near ptr M05_L00
       mov       esi,10000
       mov       edx,410000
       call      qword ptr [72AC8FF9F090]
       test      eax,eax
       mov       rdi,[rbp-28]
       jne       near ptr M05_L00
       jmp       short M05_L18
M05_L20:
       call      qword ptr [72AC8FF974F8]
       mov       rdi,[rbp-28]
       jmp       near ptr M05_L01
M05_L21:
       test      word ptr [rdi+34],200
       jne       near ptr M05_L02
       call      qword ptr [72AC8FF974C8]
       mov       r15d,eax
       mov       rdi,[rbp-28]
       mov       rdi,[rdi+8]
       call      qword ptr [72AC8FF9F0C0]
       mov       rsi,rax
       mov       rdi,72AC7E409FB8
       call      qword ptr [72AC8F43EFA0]; System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       esi,r15d
       mov       rdi,rbx
       xor       ecx,ecx
       call      qword ptr [72AC8FF974E0]
       mov       rdi,[rbp-28]
       jmp       near ptr M05_L02
       push      rax
       mov       rbx,rdi
       mov       rdi,offset MT_System.Threading.Tasks.TaskSchedulerException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdi,r15
       mov       rsi,rbx
       call      qword ptr [72AC8FF9F0D8]
       mov       rdi,[rbp-28]
       mov       rsi,r15
       call      qword ptr [72AC8FF9F0F0]
       mov       rdi,[rbp-28]
       xor       esi,esi
       call      qword ptr [72AC8FF9F108]
       mov       rdi,[rbp-28]
       call      qword ptr [72AC8FF9F120]
       test      eax,200
       jne       short M05_L22
       mov       rdi,[rbp-28]
       mov       rdi,[rdi+28]
       mov       rdi,[rdi+18]
       xor       esi,esi
       cmp       [rdi],edi
       call      qword ptr [72AC8FF9F138]
M05_L22:
       mov       rdi,r15
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 927
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       push      rbp
       mov       rbp,rsp
       mov       eax,[rdi+8]
       cmp       rax,rsi
       jbe       short M06_L02
       lea       rax,[rdi+rsi*8+10]
       mov       rdi,[rdi]
       mov       rsi,[rdi+30]
       test      rdx,rdx
       je        short M06_L01
       cmp       rsi,[rdx]
       je        short M06_L00
       mov       rcx,offset MT_System.Object[]
       cmp       rdi,rcx
       je        short M06_L00
       mov       rdi,rax
       pop       rbp
       jmp       qword ptr [72AC8FC87A68]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
M06_L00:
       mov       rdi,rax
       mov       rsi,rdx
       pop       rbp
       jmp       near ptr 000072AD0D9FB900
M06_L01:
       xor       ecx,ecx
       mov       [rax],rcx
       pop       rbp
       ret
M06_L02:
       call      qword ptr [72AC8FF9EAF0]
       int       3
; Total bytes of code 85
```
```assembly
; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rbx
       sub       rsp,18
       lea       rbp,[rsp+40]
       mov       rbx,rdi
       mov       r15,rsi
       mov       r14d,edx
       mov       r13,[rbx+20]
       mov       rsi,729CCCC00238
       cmp       r13,[rsi]
       je        near ptr M07_L05
       mov       r12,r13
       test      r12,r12
       je        short M07_L00
       mov       rsi,offset MT_System.Threading.Tasks.UnwrapPromise<System.Int32>
       cmp       [r12],rsi
       jne       near ptr M07_L06
       xor       r12d,r12d
M07_L00:
       test      r12,r12
       jne       near ptr M07_L10
       mov       rdi,offset MT_System.Collections.Generic.List<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rdi,729CCCC00AB8
       mov       rsi,[rdi]
       lea       rdi,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      r14b,r14b
       jne       near ptr M07_L07
       inc       dword ptr [r12+14]
       mov       rdi,r12
       mov       rsi,r13
       call      qword ptr [72AC8F4372D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       inc       dword ptr [r12+14]
       mov       rdi,[r12+8]
       mov       esi,[r12+10]
       cmp       [rdi+8],esi
       jbe       short M07_L03
       lea       edx,[rsi+1]
       mov       [r12+10],edx
       mov       esi,esi
       mov       rdx,r15
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M07_L01:
       lea       rdi,[rbx+20]
       test      rdi,rdi
       je        near ptr M07_L09
       mov       rsi,r12
       mov       rdx,r13
       call      000072AD0D874060
       mov       r12,rax
       cmp       r12,r13
       jne       short M07_L04
M07_L02:
       mov       eax,1
       add       rsp,18
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M07_L03:
       mov       rdi,r12
       mov       rsi,r15
       call      qword ptr [72AC8F4372D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M07_L01
M07_L04:
       mov       rsi,r12
       mov       rdi,offset MT_System.Collections.Generic.List<System.Object>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r12,rax
       test      r12,r12
       jne       near ptr M07_L10
M07_L05:
       xor       eax,eax
       add       rsp,18
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M07_L06:
       mov       rsi,r13
       mov       rdi,offset MT_System.Collections.Generic.List<System.Object>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r12,rax
       jmp       near ptr M07_L00
M07_L07:
       inc       dword ptr [r12+14]
       mov       rdi,r12
       mov       rsi,r15
       call      qword ptr [72AC8F4372D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       inc       dword ptr [r12+14]
       mov       rdi,[r12+8]
       mov       esi,[r12+10]
       cmp       [rdi+8],esi
       jbe       short M07_L08
       lea       edx,[rsi+1]
       mov       [r12+10],edx
       mov       esi,esi
       mov       rdx,r13
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M07_L01
M07_L08:
       mov       rdi,r12
       mov       rsi,r13
       call      qword ptr [72AC8F4372D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M07_L01
M07_L09:
       call      qword ptr [72AC8FF9EB80]
       int       3
M07_L10:
       mov       [rbp-40],r12
       xor       esi,esi
       mov       [rbp-30],esi
       lea       rsi,[rbp-30]
       mov       rdi,r12
       call      qword ptr [72AC8F435980]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rdi,[rbx+20]
       mov       rax,729CCCC00238
       cmp       rdi,[rax]
       jne       short M07_L11
       xor       edi,edi
       mov       [rbp-34],edi
       jmp       near ptr M07_L17
M07_L11:
       mov       edi,[r12+10]
       mov       rax,[r12+8]
       cmp       edi,[rax+8]
       jne       short M07_L13
       mov       rdi,729CCCC00290
       mov       rsi,[rdi]
       test      rsi,rsi
       jne       short M07_L12
       mov       rdi,offset MT_System.Predicate<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rsi,729CCCC00260
       mov       rsi,[rsi]
       mov       rdi,rbx
       mov       rdx,72AC8FF9BC30
       call      qword ptr [72AC8F436E08]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdi,729CCCC00290
       mov       rsi,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,rbx
M07_L12:
       mov       rdi,r12
       cmp       [rdi],edi
       call      qword ptr [72AC8FF9FC48]
M07_L13:
       test      r14b,r14b
       je        short M07_L14
       mov       rdi,r12
       mov       rdx,r15
       xor       esi,esi
       call      qword ptr [72AC8F526A30]
       jmp       short M07_L18
M07_L14:
       inc       dword ptr [r12+14]
       mov       rdi,[r12+8]
       mov       esi,[r12+10]
       cmp       [rdi+8],esi
       jbe       short M07_L15
       lea       edx,[rsi+1]
       mov       [r12+10],edx
       mov       rdx,r15
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M07_L18
M07_L15:
       mov       rdi,r12
       mov       rsi,r15
       call      qword ptr [72AC8F4372D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M07_L18
M07_L16:
       mov       rdi,r12
       call      qword ptr [72AC8F436808]; System.Threading.Monitor.Exit(System.Object)
       jmp       near ptr M07_L02
M07_L17:
       call      M07_L20
       jmp       short M07_L19
M07_L18:
       cmp       byte ptr [rbp-30],0
       je        near ptr M07_L02
       jmp       short M07_L16
M07_L19:
       mov       eax,[rbp-34]
       movzx     eax,al
       add       rsp,18
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M07_L20:
       push      rax
       cmp       byte ptr [rbp-30],0
       je        short M07_L21
       mov       rdi,[rbp-40]
       call      qword ptr [72AC8F436808]; System.Threading.Monitor.Exit(System.Object)
M07_L21:
       nop
       add       rsp,8
       ret
; Total bytes of code 735
```
```assembly
; System.Threading.Tasks.Task+WhenAllPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+50]
       mov       rbx,rdi
       mov       rdi,729CCCC013A8
       mov       r15,[rdi]
       cmp       byte ptr [r15+9D],0
       jne       near ptr M08_L12
M08_L00:
       lea       rsi,[rbx+48]
       mov       edi,0FFFFFFFF
       lock xadd [rsi],edi
       dec       edi
       jne       near ptr M08_L11
       mov       rsi,[rbx+40]
       mov       esi,[rsi+8]
       mov       rdi,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       xor       r13d,r13d
       xor       r12d,r12d
       xor       eax,eax
M08_L01:
       mov       rdi,[rbx+40]
       cmp       [rdi+8],eax
       jle       near ptr M08_L06
       cmp       eax,[rdi+8]
       jae       near ptr M08_L27
       mov       [rbp-2C],eax
       mov       ecx,eax
       mov       [rbp-38],rcx
       mov       r8,[rdi+rcx*8+10]
       mov       [rbp-40],r8
       test      dword ptr [r8+34],200000
       jne       near ptr M08_L13
       mov       edi,[r8+34]
       and       edi,600000
       cmp       edi,400000
       je        near ptr M08_L16
       test      dword ptr [r8+34],1600000
       je        near ptr M08_L17
M08_L02:
       mov       edi,[r8+34]
       and       edi,1600000
       cmp       edi,1000000
       jne       near ptr M08_L18
M08_L03:
       mov       edi,[r8+38]
       mov       eax,[rbp-2C]
       cmp       eax,[r14+8]
       jae       near ptr M08_L27
       mov       rcx,[rbp-38]
       mov       [r14+rcx*4+10],edi
M08_L04:
       test      dword ptr [r8+34],10000000
       jne       near ptr M08_L19
       mov       rdi,[rbx+40]
       mov       eax,[rbp-2C]
       cmp       eax,[rdi+8]
       jae       near ptr M08_L27
       xor       esi,esi
       mov       rcx,[rbp-38]
       mov       [rdi+rcx*8+10],rsi
M08_L05:
       mov       eax,[rbp-2C]
       inc       eax
       jmp       near ptr M08_L01
M08_L06:
       test      r13,r13
       jne       near ptr M08_L20
       test      r12,r12
       jne       near ptr M08_L21
       cmp       byte ptr [r15+9D],0
       jne       near ptr M08_L22
M08_L07:
       cmp       byte ptr [72AC8E44B06C],0
       jne       near ptr M08_L23
M08_L08:
       mov       eax,[rbx+34]
       mov       [rbp-30],eax
       test      eax,5600000
       jne       short M08_L11
       lea       rdi,[rbx+34]
       mov       esi,eax
       or        esi,4000000
       lock cmpxchg [rdi],esi
       cmp       eax,[rbp-30]
       jne       near ptr M08_L24
M08_L09:
       lea       rdi,[rbx+38]
       mov       rsi,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdi,[rbx+34]
       mov       eax,[rbx+34]
       or        eax,1000000
       xchg      eax,[rdi]
       mov       r12,[rbx+28]
       test      r12,r12
       jne       near ptr M08_L25
M08_L10:
       lea       rdi,[rbx+20]
       test      rdi,rdi
       je        near ptr M08_L26
       mov       rsi,729CCCC00238
       mov       rsi,[rsi]
       call      000072AD0D874040
       test      rax,rax
       je        short M08_L11
       mov       rdi,rbx
       mov       rsi,rax
       call      qword ptr [72AC8FF97EA0]; System.Threading.Tasks.Task.RunContinuations(System.Object)
M08_L11:
       nop
       add       rsp,28
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M08_L12:
       mov       rdi,rbx
       call      qword ptr [72AC8FF974C8]
       mov       esi,eax
       mov       rdi,r15
       mov       edx,1
       call      qword ptr [72AC8FF9C1F8]
       jmp       near ptr M08_L00
M08_L13:
       test      r13,r13
       jne       short M08_L14
       mov       rdi,offset MT_System.Collections.Generic.List<System.Runtime.ExceptionServices.ExceptionDispatchInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdi,r13
       call      qword ptr [72AC8FC8F0A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       r8,[rbp-40]
M08_L14:
       mov       rdi,[r8+28]
       mov       rdx,[rdi+18]
       mov       [rbp-48],rdx
       mov       rsi,[rdx+10]
       mov       [rbp-50],rsi
       cmp       byte ptr [rdx+20],0
       jne       short M08_L15
       mov       rdi,rdx
       call      qword ptr [72AC8FC86868]; System.GC.SuppressFinalize(System.Object)
       mov       rdi,[rbp-48]
       mov       byte ptr [rdi+20],1
M08_L15:
       mov       rdi,r13
       mov       rsi,[rbp-50]
       cmp       [rdi],edi
       call      qword ptr [72AC8FF9C3C0]
       mov       r8,[rbp-40]
       jmp       near ptr M08_L04
M08_L16:
       test      r12,r12
       jne       near ptr M08_L04
       mov       r12,r8
       mov       r8,[rbp-40]
       jmp       near ptr M08_L04
M08_L17:
       mov       rdi,r8
       mov       esi,0FFFFFFFF
       xor       edx,edx
       call      qword ptr [72AC8FF97B58]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
       mov       r8,[rbp-40]
       jmp       near ptr M08_L02
M08_L18:
       mov       rdi,r8
       mov       esi,1
       call      qword ptr [72AC8FF9FFD8]
       mov       r8,[rbp-40]
       jmp       near ptr M08_L03
M08_L19:
       mov       edi,[rbx+34]
       test      edi,5600000
       jne       near ptr M08_L05
       lea       rsi,[rbx+34]
       mov       edx,edi
       or        edx,10000000
       mov       eax,edi
       lock cmpxchg [rsi],edx
       cmp       eax,edi
       je        near ptr M08_L05
       mov       rdi,rbx
       mov       esi,10000000
       mov       edx,5600000
       call      qword ptr [72AC8FF9F090]
       jmp       near ptr M08_L05
M08_L20:
       mov       rdi,rbx
       mov       rsi,r13
       call      qword ptr [72AC8FF9C2D0]
       jmp       near ptr M08_L11
M08_L21:
       mov       rdi,r12
       call      qword ptr [72AC8FF9C210]
       mov       r13,rax
       mov       rdi,r12
       call      qword ptr [72AC8FF9C228]
       mov       rdx,rax
       mov       rsi,r13
       mov       rdi,rbx
       call      qword ptr [72AC8FF9C240]
       jmp       near ptr M08_L11
M08_L22:
       mov       rdi,rbx
       call      qword ptr [72AC8FF974C8]
       mov       esi,eax
       mov       rdi,r15
       mov       edx,1
       call      qword ptr [72AC8FF9C2E8]
       jmp       near ptr M08_L07
M08_L23:
       mov       rdi,rbx
       call      qword ptr [72AC8FF9C300]
       jmp       near ptr M08_L08
M08_L24:
       mov       rdi,rbx
       mov       esi,4000000
       mov       edx,5600000
       call      qword ptr [72AC8FF9F090]
       test      eax,eax
       je        near ptr M08_L11
       jmp       near ptr M08_L09
M08_L25:
       mov       rdi,rbx
       call      qword ptr [72AC8FF9F720]
       mov       rdi,r12
       call      qword ptr [72AC8FF9F738]
       jmp       near ptr M08_L10
M08_L26:
       call      qword ptr [72AC8FF9EB80]
       int       3
M08_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 915
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbp
       push      rbx
       push      rax
       lea       rbp,[rsp+10]
       mov       ebx,edi
       call      qword ptr [72AC8EFF6AF0]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       edi,ebx
       and       edi,0FFFFFF
       mov       ecx,edi
       mov       edx,ebx
       sar       edx,18
       jne       short M09_L01
       cmp       [rax],edi
       jle       short M09_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       ecx,0FFFFFFFE
       movsxd    rdi,ecx
       mov       rax,[rax+rdi*8+10]
       test      rax,rax
       je        short M09_L03
M09_L00:
       add       rsp,8
       pop       rbx
       pop       rbp
       ret
M09_L01:
       mov       edi,ebx
       sar       edi,18
       cmp       edi,2
       jne       short M09_L02
       movsxd    rcx,ecx
       add       rax,rcx
       jmp       short M09_L00
M09_L02:
       cmp       [rax+4],ecx
       jle       short M09_L03
       mov       rdi,[rax+10]
       movsxd    rax,ecx
       mov       rdi,[rdi+rax*8]
       test      rdi,rdi
       je        short M09_L03
       mov       rax,[rdi]
       test      rax,rax
       je        short M09_L03
       jmp       short M09_L00
M09_L03:
       mov       edi,ebx
       lea       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       add       rsp,8
       pop       rbx
       pop       rbp
       jmp       qword ptr [rax]
; Total bytes of code 133
```
```assembly
; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rbx
       sub       rsp,10
       lea       rbp,[rsp+30]
       mov       rbx,rdi
       mov       r15,rsi
       mov       r14d,edx
M10_L00:
       mov       rdi,729CCCC013A8
       mov       r13,[rdi]
       cmp       byte ptr [r13+9D],0
       jne       near ptr M10_L13
M10_L01:
       xor       eax,eax
       mov       edi,[r15+34]
       test      edi,200000
       jne       near ptr M10_L14
       test      edi,400000
       jne       near ptr M10_L15
       test      edi,1000000
       je        near ptr M10_L16
       mov       ecx,5
M10_L02:
       add       ecx,0FFFFFFFB
       jne       near ptr M10_L19
       cmp       byte ptr [r13+9D],0
       jne       near ptr M10_L21
M10_L03:
       cmp       byte ptr [72AC8E44B06C],0
       jne       near ptr M10_L22
M10_L04:
       mov       rdi,r15
       mov       rsi,offset MT_System.Threading.Tasks.UnwrapPromise<System.Int32>
       cmp       [rdi],rsi
       jne       near ptr M10_L12
M10_L05:
       test      rdi,rdi
       je        near ptr M10_L23
       mov       esi,[rdi+34]
       and       esi,11000000
       cmp       esi,1000000
       jne       near ptr M10_L24
       mov       r15d,[rdi+38]
M10_L06:
       xor       r14d,r14d
       mov       eax,[rbx+34]
       mov       [rbp-24],eax
       test      eax,5600000
       jne       short M10_L10
       lea       rdi,[rbx+34]
       mov       esi,eax
       or        esi,4000000
       lock cmpxchg [rdi],esi
       cmp       eax,[rbp-24]
       jne       near ptr M10_L25
M10_L07:
       mov       [rbx+38],r15d
       lea       rdi,[rbx+34]
       mov       eax,[rbx+34]
       or        eax,1000000
       xchg      eax,[rdi]
       mov       r14,[rbx+28]
       test      r14,r14
       jne       near ptr M10_L26
M10_L08:
       lea       rdi,[rbx+20]
       test      rdi,rdi
       je        near ptr M10_L27
       mov       rsi,729CCCC00238
       mov       rsi,[rsi]
       call      000072AD0D874040
       test      rax,rax
       je        short M10_L09
       mov       rdi,rbx
       mov       rsi,rax
       call      qword ptr [72AC8FF97EA0]; System.Threading.Tasks.Task.RunContinuations(System.Object)
M10_L09:
       mov       r14d,1
M10_L10:
       mov       eax,r14d
M10_L11:
       add       rsp,10
       pop       rbx
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M10_L12:
       mov       rsi,r15
       mov       rdi,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M10_L05
M10_L13:
       mov       rdi,rbx
       call      qword ptr [72AC8FF974C8]
       mov       esi,eax
       mov       rdi,r13
       mov       edx,1
       call      qword ptr [72AC8FF9C1F8]
       jmp       near ptr M10_L01
M10_L14:
       mov       ecx,7
       jmp       near ptr M10_L02
M10_L15:
       mov       ecx,6
       jmp       near ptr M10_L02
M10_L16:
       test      edi,800000
       je        short M10_L17
       mov       ecx,4
       jmp       near ptr M10_L02
M10_L17:
       test      edi,20000
       je        short M10_L18
       mov       ecx,3
       jmp       near ptr M10_L02
M10_L18:
       test      edi,2000000
       setne     cl
       movzx     ecx,cl
       mov       edx,2
       test      edi,10000
       cmovne    ecx,edx
       jmp       near ptr M10_L02
M10_L19:
       cmp       ecx,2
       ja        near ptr M10_L11
       mov       edi,ecx
       lea       rax,[72AC8F4BDD28]
       mov       eax,[rax+rdi*4]
       lea       rcx,[M10_L00]
       add       rax,rcx
       jmp       rax
       mov       rdi,r15
       call      qword ptr [72AC8FF9C210]
       mov       r14,rax
       mov       rdi,r15
       call      qword ptr [72AC8FF9C228]
       mov       rdx,rax
       mov       rsi,r14
       mov       rdi,rbx
       call      qword ptr [72AC8FF9C240]
       jmp       near ptr M10_L11
       mov       rdi,r15
       call      qword ptr [72AC8FF9C258]
       mov       r15,rax
       test      r14b,r14b
       je        short M10_L20
       cmp       dword ptr [r15+10],0
       jle       short M10_L20
       mov       rdi,r15
       xor       esi,esi
       call      qword ptr [72AC8F5269B8]
       mov       r13,rax
       test      r13,r13
       je        short M10_L20
       mov       rsi,[r13+8]
       mov       rdi,offset MT_System.OperationCanceledException
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M10_L20
       mov       rsi,[rax+70]
       mov       rdi,rbx
       mov       rdx,r13
       call      qword ptr [72AC8FF9C240]
       jmp       near ptr M10_L11
M10_L20:
       mov       rdi,rbx
       mov       rsi,r15
       call      qword ptr [72AC8FF9C2D0]
       jmp       near ptr M10_L11
M10_L21:
       mov       rdi,rbx
       call      qword ptr [72AC8FF974C8]
       mov       esi,eax
       mov       rdi,r13
       mov       edx,1
       call      qword ptr [72AC8FF9C2E8]
       jmp       near ptr M10_L03
M10_L22:
       mov       rdi,rbx
       call      qword ptr [72AC8FF9C300]
       jmp       near ptr M10_L04
M10_L23:
       xor       r15d,r15d
       jmp       near ptr M10_L06
M10_L24:
       mov       esi,1
       call      qword ptr [72AC8FF9C3F0]; System.Threading.Tasks.Task`1[[System.Int32, System.Private.CoreLib]].GetResultCore(Boolean)
       mov       r15d,eax
       jmp       near ptr M10_L06
M10_L25:
       mov       rdi,rbx
       mov       esi,4000000
       mov       edx,5600000
       call      qword ptr [72AC8FF9F090]
       test      eax,eax
       je        near ptr M10_L10
       jmp       near ptr M10_L07
M10_L26:
       mov       rdi,rbx
       call      qword ptr [72AC8FF9F720]
       mov       rdi,r14
       call      qword ptr [72AC8FF9F738]
       jmp       near ptr M10_L08
M10_L27:
       call      qword ptr [72AC8FF9EB80]
       int       3
; Total bytes of code 789
```
```assembly
; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].ProcessCompletedOuterTask(System.Threading.Tasks.Task)
       push      rbp
       push      r15
       push      r14
       push      rbx
       push      rax
       lea       rbp,[rsp+20]
       mov       rbx,rdi
       mov       r15,rsi
       mov       byte ptr [rbx+3C],1
       mov       esi,[r15+34]
       test      esi,200000
       jne       near ptr M11_L10
       test      esi,400000
       jne       near ptr M11_L11
       test      esi,1000000
       je        near ptr M11_L12
       mov       r14d,5
M11_L00:
       cmp       r14d,5
       jne       near ptr M11_L15
       mov       rdi,r15
       mov       rax,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task<System.Int32>>
       cmp       [rdi],rax
       jne       near ptr M11_L16
M11_L01:
       test      rdi,rdi
       je        short M11_L04
       mov       esi,[rdi+34]
       and       esi,11000000
       cmp       esi,1000000
       jne       near ptr M11_L18
       mov       r14,[rdi+38]
M11_L02:
       test      r14,r14
       je        near ptr M11_L19
       test      dword ptr [r14+34],1600000
       jne       near ptr M11_L08
       test      dword ptr [r14+34],1600000
       jne       short M11_L07
       cmp       qword ptr [r14+20],0
       jne       short M11_L06
       lea       rdi,[r14+20]
       test      rdi,rdi
       je        near ptr M11_L20
       mov       rsi,rbx
       xor       edx,edx
       call      000072AD0D874060
       test      rax,rax
       jne       short M11_L06
M11_L03:
       add       rsp,8
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       ret
M11_L04:
       mov       rdi,r15
       mov       rax,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task>
       cmp       [rdi],rax
       jne       near ptr M11_L17
M11_L05:
       cmp       [rdi],edi
       call      qword ptr [72AC8FF97FA8]; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].get_Result()
       mov       r14,rax
       jmp       short M11_L02
M11_L06:
       mov       rdi,r14
       mov       rsi,rbx
       xor       edx,edx
       call      qword ptr [72AC8FF9C030]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       short M11_L03
M11_L07:
       mov       rdi,rbx
       mov       rsi,r14
       add       rsp,8
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [72AC8FFCC800]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
M11_L08:
       mov       rdi,rbx
       mov       rsi,r14
       xor       edx,edx
       call      qword ptr [72AC8FF97F48]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
M11_L09:
       mov       byte ptr [rbx+3C],2
       jmp       short M11_L03
M11_L10:
       mov       r14d,7
       jmp       near ptr M11_L00
M11_L11:
       mov       r14d,6
       jmp       near ptr M11_L00
M11_L12:
       test      esi,800000
       je        short M11_L13
       mov       r14d,4
       jmp       near ptr M11_L00
M11_L13:
       test      esi,20000
       je        short M11_L14
       mov       r14d,3
       jmp       near ptr M11_L00
M11_L14:
       test      esi,2000000
       setne     r14b
       movzx     r14d,r14b
       mov       edi,2
       test      esi,10000
       cmovne    r14d,edi
       jmp       near ptr M11_L00
M11_L15:
       add       r14d,0FFFFFFFA
       cmp       r14d,1
       ja        near ptr M11_L03
       movzx     edx,byte ptr [rbx+3D]
       mov       rdi,rbx
       mov       rsi,r15
       call      qword ptr [72AC8FF97F48]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       jmp       near ptr M11_L03
M11_L16:
       mov       rsi,r15
       mov       rdi,rax
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M11_L01
M11_L17:
       mov       rsi,r15
       mov       rdi,rax
       call      qword ptr [72AC8F864AF8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M11_L05
M11_L18:
       mov       esi,1
       call      qword ptr [72AC8FF9F600]
       mov       r14,rax
       jmp       near ptr M11_L02
M11_L19:
       mov       rdi,rbx
       xor       esi,esi
       xor       edx,edx
       call      qword ptr [72AC8FF9C240]
       jmp       near ptr M11_L09
M11_L20:
       call      qword ptr [72AC8FF9EB80]
       int       3
; Total bytes of code 516
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
       jne       short M12_L00
       mov       rdi,rbx
       mov       esi,0FFFFFFFF
       xor       edx,edx
       call      qword ptr [72AC8FF97B58]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M12_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M12_L03
M12_L01:
       mov       edi,[rbx+34]
       and       edi,1600000
       cmp       edi,1000000
       jne       short M12_L04
M12_L02:
       pop       rbx
       pop       r15
       pop       rbp
       ret
M12_L03:
       mov       rdi,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M12_L01
       mov       rdi,rbx
       call      qword ptr [72AC8FF9F840]
       jmp       short M12_L01
M12_L04:
       test      r15b,2
       jne       short M12_L05
       mov       rdi,rbx
       call      qword ptr [72AC8FF9FAC8]
M12_L05:
       mov       rdi,rbx
       call      qword ptr [72AC90054090]
       jmp       short M12_L02
; Total bytes of code 125
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.ContendedFirstCallBenchmarks.VsThreading()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       rbx,rdi
       mov       rdi,offset MT_AsyncLazyBenchmarks.ContendedFirstCallBenchmarks+<>c__DisplayClass11_0
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdi,offset MT_Microsoft.VisualStudio.Threading.AsyncLazy<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdi,7975B4C01358
       mov       r13,[rdi]
       mov       rdi,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rdi,[r14+8]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdi,[r14+20]
       mov       rsi,r13
       call      CORINFO_HELP_ASSIGN_REF
       xor       edi,edi
       mov       [r14+10],rdi
       lea       rdi,[r15+8]
       mov       rsi,r14
       call      CORINFO_HELP_ASSIGN_REF
       xor       r14d,r14d
M00_L00:
       mov       r13,[rbx+8]
       cmp       [r13+8],r14d
       jle       near ptr M00_L19
       mov       r12,[r15+10]
       test      r12,r12
       jne       short M00_L01
       mov       rdi,offset MT_System.Func<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rdi,[r12+8]
       mov       rsi,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset AsyncLazyBenchmarks.ContendedFirstCallBenchmarks+<>c__DisplayClass11_0.<VsThreading>b__0()
       mov       [r12+18],rdi
       lea       rdi,[r15+10]
       mov       rsi,r12
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       mov       rdi,7975B4C01388
       mov       rax,[rdi]
       test      rax,rax
       je        near ptr M00_L30
M00_L02:
       cmp       [rax],al
       mov       rdi,7975B4C01398
       mov       rax,[rdi]
       mov       [rbp-40],rax
       mov       rdi,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-48],rax
       lea       rdi,[rax+8]
       mov       rsi,r12
       call      CORINFO_HELP_ASSIGN_REF
       xor       edi,edi
       mov       r12,[rbp-48]
       mov       [r12+10],rdi
       lea       rdi,[r12+18]
       mov       rsi,[rbp-40]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edi,2008
       mov       [r12+34],edi
       mov       rdi,7985F3EA0D68
       mov       rax,7985F4746820
       call      rax
       cmp       dword ptr [rax],4
       jle       near ptr M00_L31
       mov       rdi,[rax+8]
       mov       rax,[rdi+20]
       test      rax,rax
       je        near ptr M00_L31
M00_L03:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M00_L04
       call      qword ptr [79857607C030]; System.Threading.Thread.InitializeCurrentThread()
M00_L04:
       mov       rax,[rax+8]
       test      rax,rax
       je        short M00_L08
       cmp       byte ptr [rax+18],0
       jne       near ptr M00_L32
M00_L05:
       test      rax,rax
       jne       short M00_L09
       or        dword ptr [r12+34],20000000
M00_L06:
       mov       rdi,r12
       xor       esi,esi
       call      qword ptr [798576386A78]; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
       mov       rdi,offset MT_System.Threading.Tasks.UnwrapPromise<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       movzx     ecx,word ptr [r12+34]
       and       ecx,4
       mov       [rbp-2C],ecx
       test      ecx,0FFFFFFBB
       je        near ptr M00_L11
M00_L07:
       mov       edi,2D
       call      qword ptr [79857582F0D8]
       int       3
M00_L08:
       mov       rax,7975B4C013A8
       mov       rax,[rax]
       jmp       short M00_L05
M00_L09:
       mov       rdi,7975B4C013A8
       mov       [rbp-50],rax
       cmp       rax,[rdi]
       je        short M00_L06
       mov       rax,[rbp-50]
       mov       rcx,[r12+28]
       test      rcx,rcx
       jne       short M00_L10
       mov       [rbp-50],rax
       mov       rdi,offset MT_System.Threading.Tasks.Task+ContingentProperties
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,rax
       mov       [rbp-58],rcx
       mov       dword ptr [rcx+3C],1
       lea       rdi,[r12+28]
       mov       rsi,rcx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-58]
       mov       rax,[rbp-50]
M00_L10:
       lea       rdi,[rcx+8]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L06
M00_L11:
       test      cl,4
       je        near ptr M00_L14
       mov       rdi,7985F3EA0D68
       mov       rdx,7985F4746820
       call      rdx
       cmp       dword ptr [rax],8
       jle       near ptr M00_L33
       mov       rdi,[rax+8]
       mov       rax,[rdi+40]
       test      rax,rax
       je        near ptr M00_L33
M00_L12:
       mov       rax,[rax+10]
       mov       [rbp-60],rax
       test      rax,rax
       je        short M00_L14
       mov       rax,[rbp-60]
       mov       rcx,[rbp-38]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M00_L13
       mov       rdi,offset MT_System.Threading.Tasks.Task+ContingentProperties
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       [rbp-68],rdx
       mov       dword ptr [rdx+3C],1
       mov       rax,[rbp-38]
       lea       rdi,[rax+28]
       mov       rsi,rdx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-68]
       mov       rax,[rbp-60]
M00_L13:
       lea       rdi,[rdx+30]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L14:
       xor       edi,edi
       mov       rax,[rbp-38]
       mov       [rax+8],rdi
       mov       [rax+10],rdi
       mov       [rax+18],rdi
       mov       ecx,[rbp-2C]
       test      ecx,0FFFFFFA0
       jne       near ptr M00_L07
       mov       edi,ecx
       or        edi,400
       or        edi,2000000
       mov       [rax+34],edi
       mov       rdi,[rax+28]
       test      rdi,rdi
       jne       near ptr M00_L34
M00_L15:
       mov       rax,[rbp-38]
       mov       byte ptr [rax+3D],1
       mov       rdi,7975B4C013B8
       mov       rdi,[rdi]
       cmp       byte ptr [rdi+9D],0
       jne       near ptr M00_L35
M00_L16:
       cmp       byte ptr [79857483B06C],0
       jne       near ptr M00_L36
M00_L17:
       test      dword ptr [r12+34],1600000
       jne       near ptr M00_L37
       test      dword ptr [r12+34],1600000
       jne       near ptr M00_L40
       cmp       qword ptr [r12+20],0
       jne       near ptr M00_L39
       lea       rdi,[r12+20]
       test      rdi,rdi
       je        near ptr M00_L48
       mov       rsi,rax
       xor       edx,edx
       call      00007985F3C74060
       test      rax,rax
       jne       near ptr M00_L38
M00_L18:
       movsxd    rsi,r14d
       mov       rdi,r13
       mov       rdx,[rbp-38]
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       r14d
       jmp       near ptr M00_L00
M00_L19:
       mov       rsi,r13
       test      rsi,rsi
       je        near ptr M00_L41
       lea       rbx,[rsi+10]
       mov       r15d,[rsi+8]
       test      r15d,r15d
       je        near ptr M00_L42
       mov       esi,r15d
       mov       rdi,offset MT_System.Threading.Tasks.Task<System.Int32>[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       lea       rdi,[r14+10]
       mov       edx,r15d
       shl       rdx,3
       cmp       rdx,4000
       jbe       short M00_L20
       mov       rsi,rbx
       call      qword ptr [798576455758]
       jmp       short M00_L21
M00_L20:
       mov       rsi,rbx
       call      00007985F3C70D90
       cmp       dword ptr [7985F3ECEC80],0
       jne       near ptr M00_L43
M00_L21:
       mov       ebx,[r14+8]
       test      ebx,ebx
       jle       short M00_L23
       lea       rdi,[r14+10]
       mov       esi,ebx
M00_L22:
       cmp       qword ptr [rdi],0
       je        near ptr M00_L44
       add       rdi,8
       dec       esi
       jne       short M00_L22
M00_L23:
       mov       rdi,offset MT_System.Threading.Tasks.Task+WhenAllPromise<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       dword ptr [r15+34],2000400
       lea       rdi,[r15+40]
       mov       rsi,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r15+48],ebx
       mov       rdi,7975B4C013B8
       mov       rdi,[rdi]
       cmp       byte ptr [rdi+9D],0
       jne       near ptr M00_L45
M00_L24:
       cmp       byte ptr [79857483B06C],0
       jne       near ptr M00_L46
M00_L25:
       test      ebx,ebx
       jle       short M00_L28
       add       r14,10
M00_L26:
       mov       r13,[r14]
       test      dword ptr [r13+34],1600000
       jne       short M00_L29
       test      dword ptr [r13+34],1600000
       jne       short M00_L29
       cmp       qword ptr [r13+20],0
       jne       near ptr M00_L47
       lea       rdi,[r13+20]
       test      rdi,rdi
       je        near ptr M00_L48
       mov       rsi,r15
       xor       edx,edx
       call      00007985F3C74060
       test      rax,rax
       jne       near ptr M00_L47
M00_L27:
       add       r14,8
       dec       ebx
       jne       short M00_L26
M00_L28:
       mov       rax,r15
       add       rsp,48
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L29:
       mov       rdi,r15
       mov       rsi,r13
       call      qword ptr [7985763EA198]; System.Threading.Tasks.Task+WhenAllPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
       jmp       short M00_L27
M00_L30:
       mov       rdi,offset MT_System.Threading.Tasks.TaskFactory<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,7975B4C01388
       xor       edx,edx
       call      00007985F3C74060
       test      rax,rax
       jne       near ptr M00_L02
       mov       rax,7975B4C01388
       mov       rax,[rax]
       jmp       near ptr M00_L02
M00_L31:
       mov       edi,4
       call      qword ptr [798576454E88]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L03
M00_L32:
       xor       eax,eax
       jmp       near ptr M00_L05
M00_L33:
       mov       edi,8
       call      qword ptr [798576454E88]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L12
M00_L34:
       mov       rdi,[rdi+30]
       test      rdi,rdi
       je        near ptr M00_L15
       test      cl,4
       je        near ptr M00_L15
       test      byte ptr [rdi+34],8
       jne       near ptr M00_L15
       call      qword ptr [798576454D80]
       jmp       near ptr M00_L15
M00_L35:
       mov       rdi,rax
       call      qword ptr [7985763872D0]
       mov       esi,eax
       mov       rdi,7975B4C013B8
       mov       rdi,[rdi]
       mov       rdx,798570C0AC10
       xor       ecx,ecx
       call      qword ptr [7985763872E8]
       mov       rax,[rbp-38]
       jmp       near ptr M00_L16
M00_L36:
       mov       rdi,rax
       call      qword ptr [798576387300]
       mov       rax,[rbp-38]
       jmp       near ptr M00_L17
M00_L37:
       mov       rdi,rax
       mov       rsi,r12
       call      qword ptr [798576387348]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].ProcessCompletedOuterTask(System.Threading.Tasks.Task)
       jmp       near ptr M00_L18
M00_L38:
       mov       rax,[rbp-38]
M00_L39:
       mov       rdi,r12
       mov       rsi,rax
       xor       edx,edx
       call      qword ptr [79857638E928]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M00_L18
       mov       rax,[rbp-38]
M00_L40:
       mov       rdi,rax
       mov       rsi,r12
       call      qword ptr [7985763BCE90]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
       jmp       near ptr M00_L18
M00_L41:
       mov       edi,33
       call      qword ptr [79857582FAE0]
       int       3
M00_L42:
       mov       rdi,offset MT_System.Threading.Tasks.Task<System.Int32[]>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdi,r15
       xor       esi,esi
       mov       rdx,798570C0A258
       xor       ecx,ecx
       xor       r8d,r8d
       call      qword ptr [798576387900]
       jmp       near ptr M00_L28
M00_L43:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L21
M00_L44:
       mov       edi,1D
       mov       esi,33
       call      qword ptr [798576387930]
       int       3
M00_L45:
       mov       rdi,r15
       call      qword ptr [7985763872D0]
       mov       esi,eax
       mov       rdi,7975B4C013B8
       mov       rdi,[rdi]
       mov       rdx,798570C0AF98
       xor       ecx,ecx
       call      qword ptr [7985763872E8]
       jmp       near ptr M00_L24
M00_L46:
       mov       rdi,r15
       call      qword ptr [798576387300]
       jmp       near ptr M00_L25
M00_L47:
       mov       rdi,r13
       mov       rsi,r15
       xor       edx,edx
       call      qword ptr [79857638E928]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M00_L27
       jmp       near ptr M00_L29
M00_L48:
       call      qword ptr [7985764549D8]
       int       3
; Total bytes of code 1749
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       mov       esi,[rdi+34]
       and       esi,11000000
       cmp       esi,1000000
       jne       short M01_L00
       ret
M01_L00:
       xor       esi,esi
       jmp       qword ptr [798576387B40]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
; Total bytes of code 26
```
```assembly
; AsyncLazyBenchmarks.ContendedFirstCallBenchmarks+<>c__DisplayClass11_0.<VsThreading>b__0()
       mov       rdi,[rdi+8]
       cmp       [rdi],dil
       xor       esi,esi
       jmp       qword ptr [7985763879D8]; Microsoft.VisualStudio.Threading.AsyncLazy`1[[System.Int32, System.Private.CoreLib]].GetValueAsync(System.Threading.CancellationToken)
; Total bytes of code 15
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
       call      qword ptr [7985753CEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdi,[rbp-90]
       call      qword ptr [rax]
       lea       rdi,[rbp-88]
       call      qword ptr [7985753CEF08]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-30]
       call      qword ptr [7985753D0B98]
       lea       rdi,[rax+10]
       mov       rsi,[rbp-30]
       call      qword ptr [7985753CEEB8]; CORINFO_HELP_ASSIGN_REF
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
; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
       push      rbp
       push      r15
       push      r14
       push      rbx
       push      rax
       lea       rbp,[rsp+20]
       mov       [rbp-20],rdi
       test      sil,sil
       jne       near ptr M04_L19
       or        dword ptr [rdi+34],10000
M04_L00:
       cmp       byte ptr [79857483B06C],0
       jne       near ptr M04_L20
M04_L01:
       mov       rax,7975B4C013B8
       mov       rbx,[rax]
       cmp       byte ptr [rbx+9D],0
       jne       near ptr M04_L21
M04_L02:
       mov       r15,[rdi+18]
       cmp       [r15],r15b
       cmp       byte ptr [rbx+9D],0
       jne       near ptr M04_L10
M04_L03:
       mov       rsi,offset MT_System.Threading.Tasks.ThreadPoolTaskScheduler
       cmp       [r15],rsi
       jne       near ptr M04_L17
       movzx     r15d,word ptr [rdi+34]
       test      r15b,2
       jne       near ptr M04_L11
       mov       rsi,7975B4C013C0
       mov       rbx,[rsi]
       cmp       byte ptr [rbx+38],0
       jne       near ptr M04_L12
M04_L04:
       test      r15b,1
       jne       short M04_L06
       mov       rdi,7985F3EA0D68
       mov       rax,7985F4746820
       call      rax
       cmp       dword ptr [rax],5
       jle       near ptr M04_L13
       mov       rdi,[rax+8]
       mov       rax,[rdi+28]
       test      rax,rax
       je        near ptr M04_L13
M04_L05:
       mov       rdi,[rax+10]
       test      rdi,rdi
       jne       near ptr M04_L14
M04_L06:
       mov       rsi,[rbx+8]
       mov       rcx,[rsi+10]
       mov       rdx,[rcx+8]
M04_L07:
       mov       r15d,[rcx+0A0]
       mov       eax,r15d
       and       eax,[rcx+18]
       cmp       eax,[rdx+8]
       jae       near ptr M04_L15
       shl       rax,4
       lea       r14,[rdx+rax+10]
       mov       eax,[r14+8]
       sub       eax,r15d
       je        short M04_L08
       test      eax,eax
       jge       short M04_L07
       mov       rdi,rsi
       mov       rsi,[rbp-20]
       call      qword ptr [798576455578]
       jmp       short M04_L09
M04_L08:
       lea       r8,[rcx+0A0]
       lea       r9d,[r15+1]
       mov       eax,r15d
       lock cmpxchg [r8],r9d
       cmp       eax,r15d
       jne       short M04_L07
       mov       rsi,[rbp-20]
       mov       rdi,r14
       call      CORINFO_HELP_ASSIGN_REF
       inc       r15d
       mov       [r14+8],r15d
M04_L09:
       add       rbx,78
       mov       edi,1
       xchg      edi,[rbx]
       test      edi,edi
       jne       near ptr M04_L18
       mov       rdi,7975B4C013E8
       mov       rbx,[rdi]
       lea       rdi,[rbx+160]
       lock inc  dword ptr [rdi]
       mov       rdi,rbx
       call      qword ptr [798576386E50]; System.Threading.PortableThreadPool+WorkerThread.MaybeAddWorkingWorker(System.Threading.PortableThreadPool)
       cmp       dword ptr [rbx+164],6
       je        near ptr M04_L18
       jmp       near ptr M04_L16
M04_L10:
       mov       rsi,r15
       call      qword ptr [798576455350]
       mov       rdi,[rbp-20]
       jmp       near ptr M04_L03
M04_L11:
       mov       rdi,offset MT_System.Threading.Tasks.ThreadPoolTaskScheduler
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdi,7975B4C014B0
       mov       rbx,[rdi]
       mov       rdi,offset MT_System.Threading.Thread
       call      CORINFO_HELP_NEWFAST
       mov       r15,rax
       mov       rdi,r15
       mov       rsi,rbx
       call      qword ptr [798576455CE0]
       mov       rdi,r15
       mov       esi,1
       call      qword ptr [798576387030]; System.Threading.Thread.set_IsBackground(Boolean)
       mov       rdi,r15
       mov       rsi,798570C0A040
       call      qword ptr [798576387120]; System.Threading.Thread.set_Name(System.String)
       mov       rdi,r15
       mov       rsi,[rbp-20]
       xor       edx,edx
       call      qword ptr [798576455CF8]
       jmp       near ptr M04_L18
M04_L12:
       mov       rsi,7975B4C013D8
       mov       rsi,[rsi]
       cmp       byte ptr [rsi+9D],0
       je        near ptr M04_L04
       mov       rsi,7975B4C013D8
       mov       rdi,[rsi]
       mov       rsi,[rbp-20]
       call      qword ptr [798576455548]
       jmp       near ptr M04_L04
M04_L13:
       mov       edi,5
       call      qword ptr [798576454E88]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M04_L05
M04_L14:
       mov       rdi,[rdi+18]
       mov       rsi,[rbp-20]
       cmp       [rdi],edi
       call      qword ptr [798576455560]
       jmp       near ptr M04_L09
M04_L15:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M04_L16:
       mov       rdi,rbx
       call      qword ptr [7985763870A8]; System.Threading.PortableThreadPool+GateThread.EnsureRunningSlow(System.Threading.PortableThreadPool)
       jmp       short M04_L18
M04_L17:
       mov       rdi,r15
       mov       rsi,[rbp-20]
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       nop
M04_L18:
       add       rsp,8
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       ret
M04_L19:
       call      qword ptr [798576455CC8]
       test      eax,eax
       mov       rdi,[rbp-20]
       jne       near ptr M04_L00
       jmp       short M04_L18
M04_L20:
       call      qword ptr [798576387300]
       mov       rdi,[rbp-20]
       jmp       near ptr M04_L01
M04_L21:
       test      word ptr [rdi+34],200
       jne       near ptr M04_L02
       call      qword ptr [7985763872D0]
       mov       r15d,eax
       mov       rdi,[rbp-20]
       mov       rdi,[rdi+8]
       call      qword ptr [7985764552C0]
       mov       rsi,rax
       mov       rdi,798570C09FB8
       call      qword ptr [79857582EFA0]; System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       esi,r15d
       mov       rdi,rbx
       xor       ecx,ecx
       call      qword ptr [7985763872E8]
       mov       rdi,[rbp-20]
       jmp       near ptr M04_L02
       push      rax
       mov       rbx,rdi
       mov       rdi,offset MT_System.Threading.Tasks.TaskSchedulerException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdi,r15
       mov       rsi,rbx
       call      qword ptr [7985764552D8]
       mov       rdi,[rbp-20]
       mov       rsi,r15
       call      qword ptr [7985764552F0]
       mov       rdi,[rbp-20]
       xor       esi,esi
       call      qword ptr [798576455308]
       mov       rdi,[rbp-20]
       call      qword ptr [798576455320]
       test      eax,200
       jne       short M04_L22
       mov       rdi,[rbp-20]
       mov       rdi,[rdi+28]
       mov       rdi,[rdi+18]
       xor       esi,esi
       cmp       [rdi],edi
       call      qword ptr [798576455338]
M04_L22:
       mov       rdi,r15
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 886
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       push      rbp
       mov       rbp,rsp
       mov       eax,[rdi+8]
       cmp       rax,rsi
       jbe       short M05_L01
       lea       rax,[rdi+rsi*8+10]
       mov       rdi,[rdi]
       mov       rsi,[rdi+30]
       test      rdx,rdx
       jne       short M05_L00
       xor       edx,edx
       mov       [rax],rdx
       pop       rbp
       ret
M05_L00:
       cmp       rsi,[rdx]
       je        short M05_L02
       mov       rcx,offset MT_System.Object[]
       cmp       rdi,rcx
       je        short M05_L02
       mov       rdi,rax
       pop       rbp
       jmp       qword ptr [798576077A68]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
M05_L01:
       call      qword ptr [798576454960]
       int       3
M05_L02:
       mov       rdi,rax
       mov       rsi,rdx
       pop       rbp
       jmp       near ptr 00007985F3DFB900
; Total bytes of code 85
```
```assembly
; System.Threading.Tasks.Task+WhenAllPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+50]
       mov       rbx,rdi
       mov       rdi,7975B4C013B8
       mov       r15,[rdi]
       cmp       byte ptr [r15+9D],0
       jne       near ptr M06_L12
M06_L00:
       lea       rsi,[rbx+48]
       mov       edi,0FFFFFFFF
       lock xadd [rsi],edi
       dec       edi
       jne       near ptr M06_L11
       mov       rsi,[rbx+40]
       mov       esi,[rsi+8]
       mov       rdi,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       xor       r13d,r13d
       xor       r12d,r12d
       xor       eax,eax
M06_L01:
       mov       rdi,[rbx+40]
       cmp       [rdi+8],eax
       jle       near ptr M06_L06
       cmp       eax,[rdi+8]
       jae       near ptr M06_L27
       mov       [rbp-2C],eax
       mov       ecx,eax
       mov       [rbp-38],rcx
       mov       r8,[rdi+rcx*8+10]
       mov       [rbp-40],r8
       test      dword ptr [r8+34],200000
       jne       near ptr M06_L13
       mov       edi,[r8+34]
       and       edi,600000
       cmp       edi,400000
       je        near ptr M06_L16
       test      dword ptr [r8+34],1600000
       je        near ptr M06_L17
M06_L02:
       mov       edi,[r8+34]
       and       edi,1600000
       cmp       edi,1000000
       jne       near ptr M06_L18
M06_L03:
       mov       edi,[r8+38]
       mov       eax,[rbp-2C]
       cmp       eax,[r14+8]
       jae       near ptr M06_L27
       mov       rcx,[rbp-38]
       mov       [r14+rcx*4+10],edi
M06_L04:
       test      dword ptr [r8+34],10000000
       jne       near ptr M06_L19
       mov       rdi,[rbx+40]
       mov       eax,[rbp-2C]
       cmp       eax,[rdi+8]
       jae       near ptr M06_L27
       xor       esi,esi
       mov       rcx,[rbp-38]
       mov       [rdi+rcx*8+10],rsi
M06_L05:
       mov       eax,[rbp-2C]
       inc       eax
       jmp       near ptr M06_L01
M06_L06:
       test      r13,r13
       jne       near ptr M06_L20
       test      r12,r12
       jne       near ptr M06_L21
       cmp       byte ptr [r15+9D],0
       jne       near ptr M06_L22
M06_L07:
       cmp       byte ptr [79857483B06C],0
       jne       near ptr M06_L23
M06_L08:
       mov       eax,[rbx+34]
       mov       [rbp-30],eax
       test      eax,5600000
       jne       short M06_L11
       lea       rdi,[rbx+34]
       mov       esi,eax
       or        esi,4000000
       lock cmpxchg [rdi],esi
       cmp       eax,[rbp-30]
       jne       near ptr M06_L24
M06_L09:
       lea       rdi,[rbx+38]
       mov       rsi,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdi,[rbx+34]
       mov       eax,[rbx+34]
       or        eax,1000000
       xchg      eax,[rdi]
       mov       r12,[rbx+28]
       test      r12,r12
       jne       near ptr M06_L25
M06_L10:
       lea       rdi,[rbx+20]
       test      rdi,rdi
       je        near ptr M06_L26
       mov       rsi,7975B4C00238
       mov       rsi,[rsi]
       call      00007985F3C74040
       test      rax,rax
       je        short M06_L11
       mov       rdi,rbx
       mov       rsi,rax
       call      qword ptr [79857638D788]; System.Threading.Tasks.Task.RunContinuations(System.Object)
M06_L11:
       nop
       add       rsp,28
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M06_L12:
       mov       rdi,rbx
       call      qword ptr [7985763872D0]
       mov       esi,eax
       mov       rdi,r15
       mov       edx,1
       call      qword ptr [79857638DC50]
       jmp       near ptr M06_L00
M06_L13:
       test      r13,r13
       jne       short M06_L14
       mov       rdi,offset MT_System.Collections.Generic.List<System.Runtime.ExceptionServices.ExceptionDispatchInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdi,r13
       call      qword ptr [79857607F0A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       r8,[rbp-40]
M06_L14:
       mov       rdi,[r8+28]
       mov       rdx,[rdi+18]
       mov       [rbp-48],rdx
       mov       rsi,[rdx+10]
       mov       [rbp-50],rsi
       cmp       byte ptr [rdx+20],0
       jne       short M06_L15
       mov       rdi,rdx
       call      qword ptr [798576076868]; System.GC.SuppressFinalize(System.Object)
       mov       rdi,[rbp-48]
       mov       byte ptr [rdi+20],1
M06_L15:
       mov       rdi,r13
       mov       rsi,[rbp-50]
       cmp       [rdi],edi
       call      qword ptr [79857638DDB8]
       mov       r8,[rbp-40]
       jmp       near ptr M06_L04
M06_L16:
       test      r12,r12
       jne       near ptr M06_L04
       mov       r12,r8
       mov       r8,[rbp-40]
       jmp       near ptr M06_L04
M06_L17:
       mov       rdi,r8
       mov       esi,0FFFFFFFF
       xor       edx,edx
       call      qword ptr [798576387B58]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
       mov       r8,[rbp-40]
       jmp       near ptr M06_L02
M06_L18:
       mov       rdi,r8
       mov       esi,1
       call      qword ptr [7985764555F0]
       mov       r8,[rbp-40]
       jmp       near ptr M06_L03
M06_L19:
       mov       rdi,rbx
       mov       esi,1
       call      qword ptr [79857638DE18]
       jmp       near ptr M06_L05
M06_L20:
       mov       rdi,rbx
       mov       rsi,r13
       call      qword ptr [79857638CC90]; System.Threading.Tasks.Task.TrySetException(System.Object)
       jmp       near ptr M06_L11
M06_L21:
       mov       rdi,r12
       call      qword ptr [79857638DC68]
       mov       r13,rax
       mov       rdi,r12
       call      qword ptr [79857638DC80]
       mov       rdx,rax
       mov       rsi,r13
       mov       rdi,rbx
       call      qword ptr [79857638DC98]
       jmp       near ptr M06_L11
M06_L22:
       mov       rdi,rbx
       call      qword ptr [7985763872D0]
       mov       esi,eax
       mov       rdi,r15
       mov       edx,1
       call      qword ptr [79857638DD28]
       jmp       near ptr M06_L07
M06_L23:
       mov       rdi,rbx
       call      qword ptr [79857638DD40]
       jmp       near ptr M06_L08
M06_L24:
       mov       rdi,rbx
       mov       esi,4000000
       mov       edx,5600000
       call      qword ptr [798576454FC0]
       test      eax,eax
       je        near ptr M06_L11
       jmp       near ptr M06_L09
M06_L25:
       mov       rdi,rbx
       call      qword ptr [79857638CD98]; System.Threading.Tasks.Task.NotifyParentIfPotentiallyAttachedTask()
       mov       rdi,r12
       call      qword ptr [798576454FD8]
       jmp       near ptr M06_L10
M06_L26:
       call      qword ptr [7985764549D8]
       int       3
M06_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 869
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbp
       push      rbx
       push      rax
       lea       rbp,[rsp+10]
       mov       ebx,edi
       call      qword ptr [7985753E6AF0]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].ProcessCompletedOuterTask(System.Threading.Tasks.Task)
       push      rbp
       push      r15
       push      r14
       push      rbx
       push      rax
       lea       rbp,[rsp+20]
       mov       rbx,rdi
       mov       r15,rsi
       mov       byte ptr [rbx+3C],1
       mov       esi,[r15+34]
       test      esi,200000
       jne       near ptr M08_L06
       test      esi,400000
       jne       near ptr M08_L07
       test      esi,1000000
       je        near ptr M08_L08
       mov       r14d,5
M08_L00:
       cmp       r14d,5
       jne       near ptr M08_L11
       mov       rdi,r15
       mov       rax,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task<System.Int32>>
       cmp       [rdi],rax
       jne       near ptr M08_L12
M08_L01:
       test      rdi,rdi
       je        near ptr M08_L13
       mov       esi,[rdi+34]
       and       esi,11000000
       cmp       esi,1000000
       jne       near ptr M08_L14
       mov       r14,[rdi+38]
M08_L02:
       test      r14,r14
       je        near ptr M08_L15
       test      dword ptr [r14+34],1600000
       je        short M08_L05
       mov       rdi,rbx
       mov       rsi,r14
       xor       edx,edx
       call      qword ptr [79857638D8F0]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
M08_L03:
       mov       byte ptr [rbx+3C],2
M08_L04:
       add       rsp,8
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       ret
M08_L05:
       test      dword ptr [r14+34],1600000
       jne       near ptr M08_L18
       cmp       qword ptr [r14+20],0
       jne       near ptr M08_L17
       lea       rdi,[r14+20]
       test      rdi,rdi
       je        near ptr M08_L16
       mov       rsi,rbx
       xor       edx,edx
       call      00007985F3C74060
       test      rax,rax
       je        short M08_L04
       jmp       near ptr M08_L17
M08_L06:
       mov       r14d,7
       jmp       near ptr M08_L00
M08_L07:
       mov       r14d,6
       jmp       near ptr M08_L00
M08_L08:
       test      esi,800000
       je        short M08_L09
       mov       r14d,4
       jmp       near ptr M08_L00
M08_L09:
       test      esi,20000
       je        short M08_L10
       mov       r14d,3
       jmp       near ptr M08_L00
M08_L10:
       test      esi,2000000
       setne     r14b
       movzx     r14d,r14b
       mov       edi,2
       test      esi,10000
       cmovne    r14d,edi
       jmp       near ptr M08_L00
M08_L11:
       add       r14d,0FFFFFFFA
       cmp       r14d,1
       ja        near ptr M08_L04
       movzx     edx,byte ptr [rbx+3D]
       mov       rdi,rbx
       mov       rsi,r15
       call      qword ptr [79857638D8F0]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       jmp       near ptr M08_L04
M08_L12:
       mov       rsi,r15
       mov       rdi,rax
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M08_L01
M08_L13:
       mov       rsi,r15
       mov       rdi,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rdi,rax
       cmp       [rdi],edi
       call      qword ptr [79857638D980]; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].get_Result()
       mov       r14,rax
       jmp       near ptr M08_L02
M08_L14:
       mov       esi,1
       call      qword ptr [7985764555D8]
       mov       r14,rax
       jmp       near ptr M08_L02
M08_L15:
       mov       rdi,rbx
       xor       esi,esi
       xor       edx,edx
       call      qword ptr [79857638DC98]
       jmp       near ptr M08_L03
M08_L16:
       call      qword ptr [7985764549D8]
       int       3
M08_L17:
       mov       rdi,r14
       mov       rsi,rbx
       xor       edx,edx
       call      qword ptr [79857638E928]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M08_L04
M08_L18:
       mov       rdi,rbx
       mov       rsi,r14
       add       rsp,8
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7985763BCE90]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
; Total bytes of code 513
```
```assembly
; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rbx
       sub       rsp,18
       lea       rbp,[rsp+40]
       mov       rbx,rdi
       mov       r15,rsi
       mov       r14d,edx
       mov       r13,[rbx+20]
       mov       rsi,7975B4C00238
       cmp       r13,[rsi]
       jne       short M09_L01
M09_L00:
       xor       eax,eax
       add       rsp,18
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M09_L01:
       mov       rsi,r13
       mov       rdi,offset MT_System.Collections.Generic.List<System.Object>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r12,rax
       test      r12,r12
       jne       near ptr M09_L11
       mov       rdi,offset MT_System.Collections.Generic.List<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rdi,r12
       call      qword ptr [79857607F0A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       test      r14b,r14b
       je        short M09_L05
       inc       dword ptr [r12+14]
       mov       rdi,[r12+8]
       mov       esi,[r12+10]
       cmp       [rdi+8],esi
       jbe       short M09_L02
       lea       edx,[rsi+1]
       mov       [r12+10],edx
       mov       rdx,r15
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M09_L03
M09_L02:
       mov       rdi,r12
       mov       rsi,r15
       call      qword ptr [7985758272D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M09_L03:
       inc       dword ptr [r12+14]
       mov       rdi,[r12+8]
       mov       esi,[r12+10]
       cmp       [rdi+8],esi
       jbe       short M09_L04
       lea       edx,[rsi+1]
       mov       [r12+10],edx
       mov       rdx,r13
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M09_L09
M09_L04:
       mov       rdi,r12
       mov       rsi,r13
       call      qword ptr [7985758272D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M09_L09
M09_L05:
       inc       dword ptr [r12+14]
       mov       rdi,[r12+8]
       mov       esi,[r12+10]
       cmp       [rdi+8],esi
       jbe       short M09_L06
       lea       edx,[rsi+1]
       mov       [r12+10],edx
       mov       rdx,r13
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M09_L07
M09_L06:
       mov       rdi,r12
       mov       rsi,r13
       call      qword ptr [7985758272D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M09_L07:
       inc       dword ptr [r12+14]
       mov       rdi,[r12+8]
       mov       esi,[r12+10]
       cmp       [rdi+8],esi
       jbe       short M09_L08
       lea       edx,[rsi+1]
       mov       [r12+10],edx
       mov       rdx,r15
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M09_L09
M09_L08:
       mov       rdi,r12
       mov       rsi,r15
       call      qword ptr [7985758272D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M09_L09:
       lea       rdi,[rbx+20]
       test      rdi,rdi
       jne       short M09_L10
       call      qword ptr [7985764549D8]
       int       3
M09_L10:
       mov       rsi,r12
       mov       rdx,r13
       call      00007985F3C74060
       mov       r12,rax
       cmp       r12,r13
       je        near ptr M09_L20
       mov       rsi,r12
       mov       rdi,offset MT_System.Collections.Generic.List<System.Object>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r12,rax
       test      r12,r12
       je        near ptr M09_L00
M09_L11:
       mov       [rbp-40],r12
       xor       esi,esi
       mov       [rbp-30],esi
       lea       rsi,[rbp-30]
       mov       rdi,r12
       call      qword ptr [798575825980]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rdi,[rbx+20]
       mov       rax,7975B4C00238
       cmp       rdi,[rax]
       jne       short M09_L12
       xor       edi,edi
       mov       [rbp-34],edi
       jmp       near ptr M09_L18
M09_L12:
       mov       edi,[r12+10]
       mov       rax,[r12+8]
       cmp       edi,[rax+8]
       jne       short M09_L14
       mov       rdi,7975B4C00290
       mov       rsi,[rdi]
       test      rsi,rsi
       jne       short M09_L13
       mov       rdi,offset MT_System.Predicate<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rsi,7975B4C00260
       mov       rsi,[rsi]
       mov       rdi,rbx
       mov       rdx,798576451FC8
       call      qword ptr [798575826E08]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdi,7975B4C00290
       mov       rsi,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,rbx
M09_L13:
       mov       rdi,r12
       cmp       [rdi],edi
       call      qword ptr [798576455C80]
M09_L14:
       test      r14b,r14b
       je        short M09_L15
       mov       rdi,r12
       mov       rdx,r15
       xor       esi,esi
       call      qword ptr [798575916A30]
       jmp       short M09_L19
M09_L15:
       inc       dword ptr [r12+14]
       mov       rdi,[r12+8]
       mov       esi,[r12+10]
       cmp       [rdi+8],esi
       jbe       short M09_L16
       lea       edx,[rsi+1]
       mov       [r12+10],edx
       mov       rdx,r15
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M09_L19
M09_L16:
       mov       rdi,r12
       mov       rsi,r15
       call      qword ptr [7985758272D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M09_L19
M09_L17:
       mov       rdi,r12
       call      qword ptr [798575826808]; System.Threading.Monitor.Exit(System.Object)
       jmp       short M09_L20
M09_L18:
       call      M09_L22
       jmp       short M09_L21
M09_L19:
       cmp       byte ptr [rbp-30],0
       jne       short M09_L17
M09_L20:
       mov       eax,1
       add       rsp,18
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M09_L21:
       mov       eax,[rbp-34]
       movzx     eax,al
       add       rsp,18
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M09_L22:
       push      rax
       cmp       byte ptr [rbp-30],0
       je        short M09_L23
       mov       rdi,[rbp-40]
       call      qword ptr [798575826808]; System.Threading.Monitor.Exit(System.Object)
M09_L23:
       nop
       add       rsp,8
       ret
; Total bytes of code 724
```
```assembly
; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
       push      rbp
       push      r15
       push      r14
       push      rbx
       push      rax
       lea       rbp,[rsp+20]
       mov       rbx,rdi
       mov       r15,rsi
M10_L00:
       call      00007985F3CF8300
       test      eax,eax
       je        near ptr M10_L23
       movzx     r14d,byte ptr [rbx+3C]
       test      r14d,r14d
       jne       near ptr M10_L07
       mov       byte ptr [rbx+3C],1
       mov       esi,[r15+34]
       test      esi,200000
       jne       near ptr M10_L08
       test      esi,400000
       jne       near ptr M10_L09
       test      esi,1000000
       je        near ptr M10_L10
       mov       r14d,5
M10_L01:
       cmp       r14d,5
       jne       near ptr M10_L20
       mov       rdi,r15
       mov       rax,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task<System.Int32>>
       cmp       [rdi],rax
       jne       near ptr M10_L15
M10_L02:
       test      rdi,rdi
       je        near ptr M10_L16
       mov       esi,[rdi+34]
       and       esi,11000000
       cmp       esi,1000000
       jne       near ptr M10_L17
       mov       r14,[rdi+38]
M10_L03:
       test      r14,r14
       je        near ptr M10_L21
       test      dword ptr [r14+34],1600000
       je        short M10_L06
       mov       rdi,rbx
       mov       rsi,r14
       xor       edx,edx
       call      qword ptr [79857638D8F0]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
M10_L04:
       mov       byte ptr [rbx+3C],2
M10_L05:
       add       rsp,8
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       ret
M10_L06:
       test      dword ptr [r14+34],1600000
       jne       near ptr M10_L19
       cmp       qword ptr [r14+20],0
       jne       near ptr M10_L18
       lea       rdi,[r14+20]
       test      rdi,rdi
       je        near ptr M10_L22
       mov       rsi,rbx
       xor       edx,edx
       call      00007985F3C74060
       test      rax,rax
       je        short M10_L05
       jmp       near ptr M10_L18
M10_L07:
       cmp       r14d,1
       jne       short M10_L05
       mov       rdi,rbx
       mov       rsi,r15
       xor       edx,edx
       call      qword ptr [79857638D8F0]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       jmp       short M10_L04
M10_L08:
       mov       r14d,7
       jmp       near ptr M10_L01
M10_L09:
       mov       r14d,6
       jmp       near ptr M10_L01
M10_L10:
       test      esi,800000
       je        short M10_L11
       mov       r14d,4
       jmp       near ptr M10_L01
M10_L11:
       test      esi,20000
       je        short M10_L12
       mov       r14d,3
       jmp       near ptr M10_L01
M10_L12:
       test      esi,10000
       je        short M10_L13
       mov       r14d,2
       jmp       near ptr M10_L01
M10_L13:
       test      esi,2000000
       je        short M10_L14
       mov       r14d,1
       jmp       near ptr M10_L01
M10_L14:
       xor       r14d,r14d
       jmp       near ptr M10_L01
M10_L15:
       mov       rsi,r15
       mov       rdi,rax
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M10_L02
M10_L16:
       mov       rsi,r15
       mov       rdi,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rdi,rax
       cmp       [rdi],edi
       call      qword ptr [79857638D980]; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].get_Result()
       mov       r14,rax
       jmp       near ptr M10_L03
M10_L17:
       mov       esi,1
       call      qword ptr [7985764555D8]
       mov       r14,rax
       jmp       near ptr M10_L03
M10_L18:
       mov       rdi,r14
       mov       rsi,rbx
       xor       edx,edx
       call      qword ptr [79857638E928]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M10_L05
M10_L19:
       mov       r15,r14
       jmp       near ptr M10_L00
M10_L20:
       add       r14d,0FFFFFFFA
       cmp       r14d,1
       ja        near ptr M10_L05
       movzx     edx,byte ptr [rbx+3D]
       mov       rdi,rbx
       mov       rsi,r15
       call      qword ptr [79857638D8F0]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       jmp       near ptr M10_L05
M10_L21:
       mov       rdi,rbx
       xor       esi,esi
       xor       edx,edx
       call      qword ptr [79857638DC98]
       jmp       near ptr M10_L04
M10_L22:
       call      qword ptr [7985764549D8]
       int       3
M10_L23:
       mov       rdi,rbx
       mov       rsi,r15
       add       rsp,8
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [79857638D890]
; Total bytes of code 582
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
       jne       short M11_L00
       mov       rdi,rbx
       mov       esi,0FFFFFFFF
       xor       edx,edx
       call      qword ptr [798576387B58]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M11_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M11_L03
M11_L01:
       mov       edi,[rbx+34]
       and       edi,1600000
       cmp       edi,1000000
       jne       short M11_L04
M11_L02:
       pop       rbx
       pop       r15
       pop       rbp
       ret
M11_L03:
       mov       rdi,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M11_L01
       mov       rdi,rbx
       call      qword ptr [798576455668]
       jmp       short M11_L01
M11_L04:
       test      r15b,2
       jne       short M11_L05
       mov       rdi,rbx
       call      qword ptr [798576455788]
M11_L05:
       mov       rdi,rbx
       call      qword ptr [798576455F68]
       jmp       short M11_L02
; Total bytes of code 125
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.ContendedFirstCallBenchmarks.LazyOfTask()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       rbx,rdi
       mov       rdi,offset MT_AsyncLazyBenchmarks.ContendedFirstCallBenchmarks+<>c__DisplayClass8_0
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdi,offset MT_System.Lazy<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdi,7E29ACC01358
       mov       rsi,[rdi]
       lea       rdi,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset MT_System.LazyHelper
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+10],8
       lea       rdi,[r14+8]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdi,[r15+8]
       mov       rsi,r14
       call      CORINFO_HELP_ASSIGN_REF
       xor       r14d,r14d
M00_L00:
       mov       r13,[rbx+8]
       cmp       [r13+8],r14d
       jle       near ptr M00_L21
       mov       r12,[r15+10]
       test      r12,r12
       je        near ptr M00_L08
M00_L01:
       mov       rdi,7E29ACC01378
       mov       rax,[rdi]
       test      rax,rax
       je        near ptr M00_L33
M00_L02:
       cmp       [rax],al
       mov       rdi,7E29ACC01388
       mov       rax,[rdi]
       mov       [rbp-40],rax
       mov       rdi,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-48],rax
       lea       rdi,[rax+8]
       mov       rsi,r12
       call      CORINFO_HELP_ASSIGN_REF
       xor       edi,edi
       mov       r12,[rbp-48]
       mov       [r12+10],rdi
       lea       rdi,[r12+18]
       mov       rsi,[rbp-40]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edi,2008
       mov       [r12+34],edi
       mov       rdi,7E39EE6A0D68
       mov       rax,7E39EEECE820
       call      rax
       cmp       dword ptr [rax],4
       jle       near ptr M00_L34
       mov       rdi,[rax+8]
       mov       rax,[rdi+20]
       test      rax,rax
       je        near ptr M00_L34
M00_L03:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M00_L04
       call      qword ptr [7E39708AC030]; System.Threading.Thread.InitializeCurrentThread()
M00_L04:
       mov       rax,[rax+8]
       test      rax,rax
       jne       near ptr M00_L09
       mov       rax,7E29ACC01398
       mov       rax,[rax]
M00_L05:
       test      rax,rax
       jne       near ptr M00_L10
       or        dword ptr [r12+34],20000000
M00_L06:
       mov       rdi,r12
       xor       esi,esi
       call      qword ptr [7E3970BB69D0]; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
       mov       rdi,offset MT_System.Threading.Tasks.UnwrapPromise<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       movzx     ecx,word ptr [r12+34]
       and       ecx,4
       mov       [rbp-2C],ecx
       test      ecx,0FFFFFFBB
       je        near ptr M00_L12
M00_L07:
       mov       edi,2D
       call      qword ptr [7E397005F0D8]
       int       3
M00_L08:
       mov       rdi,offset MT_System.Func<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rdi,[r12+8]
       mov       rsi,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset AsyncLazyBenchmarks.ContendedFirstCallBenchmarks+<>c__DisplayClass8_0.<LazyOfTask>b__0()
       mov       [r12+18],rdi
       lea       rdi,[r15+10]
       mov       rsi,r12
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L09:
       cmp       byte ptr [rax+18],0
       je        near ptr M00_L05
       xor       eax,eax
       jmp       near ptr M00_L05
M00_L10:
       mov       rdi,7E29ACC01398
       mov       [rbp-50],rax
       cmp       rax,[rdi]
       je        near ptr M00_L06
       mov       rax,[rbp-50]
       mov       rcx,[r12+28]
       test      rcx,rcx
       jne       short M00_L11
       mov       [rbp-50],rax
       mov       rdi,offset MT_System.Threading.Tasks.Task+ContingentProperties
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,rax
       mov       [rbp-58],rcx
       mov       dword ptr [rcx+3C],1
       lea       rdi,[r12+28]
       mov       rsi,rcx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-58]
       mov       rax,[rbp-50]
M00_L11:
       lea       rdi,[rcx+8]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L06
M00_L12:
       test      cl,4
       je        near ptr M00_L15
       mov       rdi,7E39EE6A0D68
       mov       rdx,7E39EEECE820
       call      rdx
       cmp       dword ptr [rax],8
       jle       near ptr M00_L35
       mov       rdi,[rax+8]
       mov       rax,[rdi+40]
       test      rax,rax
       je        near ptr M00_L35
M00_L13:
       mov       rax,[rax+10]
       mov       [rbp-60],rax
       test      rax,rax
       je        short M00_L15
       mov       rax,[rbp-60]
       mov       rcx,[rbp-38]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M00_L14
       mov       rdi,offset MT_System.Threading.Tasks.Task+ContingentProperties
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       [rbp-68],rdx
       mov       dword ptr [rdx+3C],1
       mov       rax,[rbp-38]
       lea       rdi,[rax+28]
       mov       rsi,rdx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-68]
       mov       rax,[rbp-60]
M00_L14:
       lea       rdi,[rdx+30]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L15:
       xor       edi,edi
       mov       rax,[rbp-38]
       mov       [rax+8],rdi
       mov       [rax+10],rdi
       mov       [rax+18],rdi
       mov       ecx,[rbp-2C]
       test      ecx,0FFFFFFA0
       jne       near ptr M00_L07
       mov       edi,ecx
       or        edi,400
       or        edi,2000000
       mov       [rax+34],edi
       mov       rdi,[rax+28]
       test      rdi,rdi
       jne       near ptr M00_L36
M00_L16:
       mov       rax,[rbp-38]
       mov       byte ptr [rax+3D],1
       mov       rdi,7E29ACC013A8
       mov       rdi,[rdi]
       cmp       byte ptr [rdi+9D],0
       jne       near ptr M00_L37
M00_L17:
       cmp       byte ptr [7E396F06B06C],0
       jne       near ptr M00_L38
M00_L18:
       test      dword ptr [r12+34],1600000
       jne       short M00_L20
       test      dword ptr [r12+34],1600000
       jne       near ptr M00_L39
       cmp       qword ptr [r12+20],0
       jne       near ptr M00_L41
       lea       rdi,[r12+20]
       test      rdi,rdi
       je        near ptr M00_L52
       mov       rsi,rax
       xor       edx,edx
       call      00007E39EE474060
       test      rax,rax
       jne       near ptr M00_L40
M00_L19:
       movsxd    rsi,r14d
       mov       rdi,r13
       mov       rdx,[rbp-38]
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       r14d
       jmp       near ptr M00_L00
M00_L20:
       mov       rdi,rax
       mov       rsi,r12
       call      qword ptr [7E3970BB73A8]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].ProcessCompletedOuterTask(System.Threading.Tasks.Task)
       jmp       short M00_L19
M00_L21:
       mov       rsi,r13
       test      rsi,rsi
       je        near ptr M00_L45
       lea       rbx,[rsi+10]
       mov       r15d,[rsi+8]
       test      r15d,r15d
       je        near ptr M00_L46
       mov       esi,r15d
       mov       rdi,offset MT_System.Threading.Tasks.Task<System.Int32>[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       lea       rdi,[r14+10]
       mov       edx,r15d
       shl       rdx,3
       cmp       rdx,4000
       jbe       short M00_L22
       mov       rsi,rbx
       call      qword ptr [7E3970BBF858]
       jmp       short M00_L23
M00_L22:
       mov       rsi,rbx
       call      00007E39EE470D90
       cmp       dword ptr [7E39EE6CEC80],0
       jne       near ptr M00_L47
M00_L23:
       mov       ebx,[r14+8]
       test      ebx,ebx
       jle       short M00_L25
       lea       rdi,[r14+10]
       mov       esi,ebx
M00_L24:
       cmp       qword ptr [rdi],0
       je        near ptr M00_L48
       add       rdi,8
       dec       esi
       jne       short M00_L24
M00_L25:
       mov       rdi,offset MT_System.Threading.Tasks.Task+WhenAllPromise<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       dword ptr [r15+34],2000400
       lea       rdi,[r15+40]
       mov       rsi,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r15+48],ebx
       mov       rdi,7E29ACC013A8
       mov       rdi,[rdi]
       cmp       byte ptr [rdi+9D],0
       jne       near ptr M00_L49
M00_L26:
       cmp       byte ptr [7E396F06B06C],0
       jne       near ptr M00_L50
M00_L27:
       test      ebx,ebx
       jle       short M00_L31
       add       r14,10
M00_L28:
       mov       r13,[r14]
       test      dword ptr [r13+34],1600000
       je        short M00_L32
M00_L29:
       mov       rdi,r15
       mov       rsi,r13
       call      qword ptr [7E3970BF8708]; System.Threading.Tasks.Task+WhenAllPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
M00_L30:
       add       r14,8
       dec       ebx
       jne       short M00_L28
M00_L31:
       mov       rax,r15
       add       rsp,48
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L32:
       test      dword ptr [r13+34],1600000
       jne       short M00_L29
       cmp       qword ptr [r13+20],0
       jne       near ptr M00_L51
       lea       rdi,[r13+20]
       test      rdi,rdi
       je        near ptr M00_L52
       mov       rsi,r15
       xor       edx,edx
       call      00007E39EE474060
       test      rax,rax
       je        short M00_L30
       jmp       near ptr M00_L51
M00_L33:
       mov       rdi,offset MT_System.Threading.Tasks.TaskFactory<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,7E29ACC01378
       xor       edx,edx
       call      00007E39EE474060
       test      rax,rax
       jne       near ptr M00_L02
       mov       rax,7E29ACC01378
       mov       rax,[rax]
       jmp       near ptr M00_L02
M00_L34:
       mov       edi,4
       call      qword ptr [7E3970BBEF58]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L03
M00_L35:
       mov       edi,8
       call      qword ptr [7E3970BBEF58]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L13
M00_L36:
       mov       rdi,[rdi+30]
       test      rdi,rdi
       je        near ptr M00_L16
       test      cl,4
       je        near ptr M00_L16
       test      byte ptr [rdi+34],8
       jne       near ptr M00_L16
       call      qword ptr [7E3970BBEA00]
       jmp       near ptr M00_L16
M00_L37:
       mov       rdi,rax
       call      qword ptr [7E3970BB7348]
       mov       esi,eax
       mov       rdi,7E29ACC013A8
       mov       rdi,[rdi]
       mov       rdx,7E396C20A908
       xor       ecx,ecx
       call      qword ptr [7E3970BB7360]
       mov       rax,[rbp-38]
       jmp       near ptr M00_L17
M00_L38:
       mov       rdi,rax
       call      qword ptr [7E3970BB7378]
       mov       rax,[rbp-38]
       jmp       near ptr M00_L18
M00_L39:
       jmp       short M00_L42
M00_L40:
       mov       rax,[rbp-38]
M00_L41:
       mov       rdi,r12
       mov       rsi,rax
       xor       edx,edx
       call      qword ptr [7E3970BBCC48]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M00_L19
M00_L42:
       call      00007E39EE4F8300
       test      eax,eax
       je        short M00_L44
       mov       rax,[rbp-38]
       movzx     edi,byte ptr [rax+3C]
       test      edi,edi
       je        near ptr M00_L20
       cmp       edi,1
       jne       short M00_L43
       mov       rdi,rax
       mov       rsi,r12
       xor       edx,edx
       call      qword ptr [7E3970BB77F8]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       mov       r12,[rbp-38]
       mov       byte ptr [r12+3C],2
       jmp       near ptr M00_L19
M00_L43:
       jmp       near ptr M00_L19
M00_L44:
       mov       rdi,[rbp-38]
       mov       rsi,r12
       call      qword ptr [7E3970BB77E0]
       jmp       near ptr M00_L19
M00_L45:
       mov       edi,33
       call      qword ptr [7E397005FAE0]
       int       3
M00_L46:
       mov       rdi,offset MT_System.Threading.Tasks.Task<System.Int32[]>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdi,r15
       xor       esi,esi
       mov       rdx,7E396C20A258
       xor       ecx,ecx
       xor       r8d,r8d
       call      qword ptr [7E3970BB79F0]
       jmp       near ptr M00_L31
M00_L47:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L23
M00_L48:
       mov       edi,1D
       mov       esi,33
       call      qword ptr [7E3970BB7A20]
       int       3
M00_L49:
       mov       rdi,r15
       call      qword ptr [7E3970BB7348]
       mov       esi,eax
       mov       rdi,7E29ACC013A8
       mov       rdi,[rdi]
       mov       rdx,7E396C20AF98
       xor       ecx,ecx
       call      qword ptr [7E3970BB7360]
       jmp       near ptr M00_L26
M00_L50:
       mov       rdi,r15
       call      qword ptr [7E3970BB7378]
       jmp       near ptr M00_L27
M00_L51:
       mov       rdi,r13
       mov       rsi,r15
       xor       edx,edx
       call      qword ptr [7E3970BBCC48]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M00_L30
       jmp       near ptr M00_L29
M00_L52:
       call      qword ptr [7E3970BBEAC0]
       int       3
; Total bytes of code 1822
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       mov       esi,[rdi+34]
       and       esi,11000000
       cmp       esi,1000000
       jne       short M01_L00
       ret
M01_L00:
       xor       esi,esi
       jmp       qword ptr [7E3970BB7C18]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
; Total bytes of code 26
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
       call      qword ptr [7E396FBFEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdi,[rbp-90]
       call      qword ptr [rax]
       lea       rdi,[rbp-88]
       call      qword ptr [7E396FBFEF08]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-30]
       call      qword ptr [7E396FC00B98]
       lea       rdi,[rax+10]
       mov       rsi,[rbp-30]
       call      qword ptr [7E396FBFEEB8]; CORINFO_HELP_ASSIGN_REF
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
; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
       push      rbp
       push      r15
       push      r14
       push      rbx
       push      rax
       lea       rbp,[rsp+20]
       mov       [rbp-20],rdi
       test      sil,sil
       jne       near ptr M03_L19
       or        dword ptr [rdi+34],10000
M03_L00:
       cmp       byte ptr [7E396F06B06C],0
       jne       near ptr M03_L20
M03_L01:
       mov       rax,7E29ACC013A8
       mov       rbx,[rax]
       cmp       byte ptr [rbx+9D],0
       jne       near ptr M03_L21
M03_L02:
       mov       r15,[rdi+18]
       cmp       [r15],r15b
       cmp       byte ptr [rbx+9D],0
       jne       near ptr M03_L10
M03_L03:
       mov       rsi,offset MT_System.Threading.Tasks.ThreadPoolTaskScheduler
       cmp       [r15],rsi
       jne       near ptr M03_L17
       movzx     r15d,word ptr [rdi+34]
       test      r15b,2
       jne       near ptr M03_L11
       mov       rsi,7E29ACC013B0
       mov       rbx,[rsi]
       cmp       byte ptr [rbx+38],0
       jne       near ptr M03_L12
M03_L04:
       test      r15b,1
       jne       short M03_L06
       mov       rdi,7E39EE6A0D68
       mov       rax,7E39EEECE820
       call      rax
       cmp       dword ptr [rax],5
       jle       near ptr M03_L13
       mov       rdi,[rax+8]
       mov       rax,[rdi+28]
       test      rax,rax
       je        near ptr M03_L13
M03_L05:
       mov       rdi,[rax+10]
       test      rdi,rdi
       jne       near ptr M03_L14
M03_L06:
       mov       rsi,[rbx+8]
       mov       rcx,[rsi+10]
       mov       rdx,[rcx+8]
M03_L07:
       mov       r15d,[rcx+0A0]
       mov       eax,r15d
       and       eax,[rcx+18]
       cmp       eax,[rdx+8]
       jae       near ptr M03_L15
       shl       rax,4
       lea       r14,[rdx+rax+10]
       mov       eax,[r14+8]
       sub       eax,r15d
       je        short M03_L08
       test      eax,eax
       jge       short M03_L07
       mov       rdi,rsi
       mov       rsi,[rbp-20]
       call      qword ptr [7E3970BBF1C8]
       jmp       short M03_L09
M03_L08:
       lea       r8,[rcx+0A0]
       lea       r9d,[r15+1]
       mov       eax,r15d
       lock cmpxchg [r8],r9d
       cmp       eax,r15d
       jne       short M03_L07
       mov       rsi,[rbp-20]
       mov       rdi,r14
       call      CORINFO_HELP_ASSIGN_REF
       inc       r15d
       mov       [r14+8],r15d
M03_L09:
       add       rbx,78
       mov       edi,1
       xchg      edi,[rbx]
       test      edi,edi
       jne       near ptr M03_L18
       mov       rdi,7E29ACC013D8
       mov       rbx,[rdi]
       lea       rdi,[rbx+160]
       lock inc  dword ptr [rdi]
       mov       rdi,rbx
       call      qword ptr [7E3970BB6DA8]; System.Threading.PortableThreadPool+WorkerThread.MaybeAddWorkingWorker(System.Threading.PortableThreadPool)
       cmp       dword ptr [rbx+164],6
       je        near ptr M03_L18
       jmp       near ptr M03_L16
M03_L10:
       mov       rsi,r15
       call      qword ptr [7E3970BBF090]
       mov       rdi,[rbp-20]
       jmp       near ptr M03_L03
M03_L11:
       mov       rdi,offset MT_System.Threading.Tasks.ThreadPoolTaskScheduler
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdi,7E29ACC01470
       mov       rbx,[rdi]
       mov       rdi,offset MT_System.Threading.Thread
       call      CORINFO_HELP_NEWFAST
       mov       r15,rax
       mov       rdi,r15
       mov       rsi,rbx
       call      qword ptr [7E3970BBFCD8]
       mov       rdi,r15
       mov       esi,1
       call      qword ptr [7E3970BB6F88]; System.Threading.Thread.set_IsBackground(Boolean)
       mov       rdi,r15
       mov       rsi,7E396C20A040
       call      qword ptr [7E3970BB7090]; System.Threading.Thread.set_Name(System.String)
       mov       rdi,r15
       mov       rsi,[rbp-20]
       xor       edx,edx
       call      qword ptr [7E3970BBFCF0]
       jmp       near ptr M03_L18
M03_L12:
       mov       rsi,7E29ACC013C8
       mov       rsi,[rsi]
       cmp       byte ptr [rsi+9D],0
       je        near ptr M03_L04
       mov       rsi,7E29ACC013C8
       mov       rdi,[rsi]
       mov       rsi,[rbp-20]
       call      qword ptr [7E3970BBF198]
       jmp       near ptr M03_L04
M03_L13:
       mov       edi,5
       call      qword ptr [7E3970BBEF58]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M03_L05
M03_L14:
       mov       rdi,[rdi+18]
       mov       rsi,[rbp-20]
       cmp       [rdi],edi
       call      qword ptr [7E3970BBF1B0]
       jmp       near ptr M03_L09
M03_L15:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M03_L16:
       mov       rdi,rbx
       call      qword ptr [7E3970BB7000]; System.Threading.PortableThreadPool+GateThread.EnsureRunningSlow(System.Threading.PortableThreadPool)
       jmp       short M03_L18
M03_L17:
       mov       rdi,r15
       mov       rsi,[rbp-20]
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       nop
M03_L18:
       add       rsp,8
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L19:
       call      qword ptr [7E3970BBFCC0]
       test      eax,eax
       mov       rdi,[rbp-20]
       jne       near ptr M03_L00
       jmp       short M03_L18
M03_L20:
       call      qword ptr [7E3970BB7378]
       mov       rdi,[rbp-20]
       jmp       near ptr M03_L01
M03_L21:
       test      word ptr [rdi+34],200
       jne       near ptr M03_L02
       call      qword ptr [7E3970BB7348]
       mov       r15d,eax
       mov       rdi,[rbp-20]
       mov       rdi,[rdi+8]
       call      qword ptr [7E3970BBF000]
       mov       rsi,rax
       mov       rdi,7E396C209FB8
       call      qword ptr [7E397005EFA0]; System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       esi,r15d
       mov       rdi,rbx
       xor       ecx,ecx
       call      qword ptr [7E3970BB7360]
       mov       rdi,[rbp-20]
       jmp       near ptr M03_L02
       push      rax
       mov       rbx,rdi
       mov       rdi,offset MT_System.Threading.Tasks.TaskSchedulerException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdi,r15
       mov       rsi,rbx
       call      qword ptr [7E3970BBF018]
       mov       rdi,[rbp-20]
       mov       rsi,r15
       call      qword ptr [7E3970BBF030]
       mov       rdi,[rbp-20]
       xor       esi,esi
       call      qword ptr [7E3970BBF048]
       mov       rdi,[rbp-20]
       call      qword ptr [7E3970BBF060]
       test      eax,200
       jne       short M03_L22
       mov       rdi,[rbp-20]
       mov       rdi,[rdi+28]
       mov       rdi,[rdi+18]
       xor       esi,esi
       cmp       [rdi],edi
       call      qword ptr [7E3970BBF078]
M03_L22:
       mov       rdi,r15
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 886
```
```assembly
; AsyncLazyBenchmarks.ContendedFirstCallBenchmarks+<>c__DisplayClass8_0.<LazyOfTask>b__0()
       mov       rdi,[rdi+8]
       cmp       qword ptr [rdi+8],0
       jne       short M04_L00
       mov       rax,[rdi+18]
       ret
M04_L00:
       jmp       qword ptr [7E39708AC420]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
; Total bytes of code 22
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       push      rbp
       mov       rbp,rsp
       mov       eax,[rdi+8]
       cmp       rax,rsi
       jbe       short M05_L01
       lea       rax,[rdi+rsi*8+10]
       mov       rdi,[rdi]
       mov       rsi,[rdi+30]
       test      rdx,rdx
       je        short M05_L00
       cmp       rsi,[rdx]
       je        short M05_L02
       mov       rcx,offset MT_System.Object[]
       cmp       rdi,rcx
       je        short M05_L02
       mov       rdi,rax
       pop       rbp
       jmp       qword ptr [7E39708A7A68]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
M05_L00:
       xor       ecx,ecx
       mov       [rax],rcx
       pop       rbp
       ret
M05_L01:
       call      qword ptr [7E3970BBE8C8]
       int       3
M05_L02:
       mov       rdi,rax
       mov       rsi,rdx
       pop       rbp
       jmp       near ptr 00007E39EE5FB900
; Total bytes of code 85
```
```assembly
; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].ProcessCompletedOuterTask(System.Threading.Tasks.Task)
       push      rbp
       push      r15
       push      r14
       push      rbx
       push      rax
       lea       rbp,[rsp+20]
       mov       rbx,rdi
       mov       r15,rsi
       mov       byte ptr [rbx+3C],1
       mov       esi,[r15+34]
       test      esi,200000
       jne       near ptr M06_L05
       test      esi,400000
       jne       near ptr M06_L07
       test      esi,1000000
       je        near ptr M06_L08
       mov       r14d,5
M06_L00:
       cmp       r14d,5
       jne       short M06_L06
       mov       rdi,r15
       mov       rax,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task<System.Int32>>
       cmp       [rdi],rax
       jne       near ptr M06_L12
M06_L01:
       test      rdi,rdi
       je        near ptr M06_L13
       mov       esi,[rdi+34]
       and       esi,11000000
       cmp       esi,1000000
       jne       near ptr M06_L15
       mov       rsi,[rdi+38]
M06_L02:
       test      rsi,rsi
       je        near ptr M06_L16
       test      dword ptr [rsi+34],1600000
       je        near ptr M06_L17
       mov       rdi,rbx
       xor       edx,edx
       call      qword ptr [7E3970BB77F8]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
M06_L03:
       mov       byte ptr [rbx+3C],2
M06_L04:
       add       rsp,8
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       ret
M06_L05:
       mov       r14d,7
       jmp       short M06_L00
M06_L06:
       add       r14d,0FFFFFFFA
       cmp       r14d,1
       ja        short M06_L04
       jmp       short M06_L11
M06_L07:
       mov       r14d,6
       jmp       near ptr M06_L00
M06_L08:
       test      esi,800000
       je        short M06_L09
       mov       r14d,4
       jmp       near ptr M06_L00
M06_L09:
       test      esi,20000
       je        short M06_L10
       mov       r14d,3
       jmp       near ptr M06_L00
M06_L10:
       test      esi,2000000
       setne     r14b
       movzx     r14d,r14b
       mov       edi,2
       test      esi,10000
       cmovne    r14d,edi
       jmp       near ptr M06_L00
M06_L11:
       movzx     edx,byte ptr [rbx+3D]
       mov       rdi,rbx
       mov       rsi,r15
       call      qword ptr [7E3970BB77F8]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       jmp       near ptr M06_L04
M06_L12:
       mov       rsi,r15
       mov       rdi,rax
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M06_L01
M06_L13:
       mov       rdi,r15
       mov       rax,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task>
       cmp       [rdi],rax
       je        short M06_L14
       mov       rsi,r15
       mov       rdi,rax
       call      qword ptr [7E3970484AF8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rdi,rax
M06_L14:
       cmp       [rdi],edi
       call      qword ptr [7E3970BB78E8]; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].get_Result()
       mov       rsi,rax
       jmp       near ptr M06_L02
M06_L15:
       mov       esi,1
       call      qword ptr [7E3970BBF4E0]
       mov       rsi,rax
       jmp       near ptr M06_L02
M06_L16:
       mov       rdi,rbx
       xor       esi,esi
       xor       edx,edx
       call      qword ptr [7E3970BB7AE0]
       jmp       near ptr M06_L03
M06_L17:
       mov       rdi,rsi
       mov       rsi,rbx
       xor       edx,edx
       add       rsp,8
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7E3970BB73C0]; System.Threading.Tasks.Task.AddCompletionAction(System.Threading.Tasks.ITaskCompletionAction, Boolean)
; Total bytes of code 431
```
```assembly
; System.Threading.Tasks.Task+WhenAllPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+50]
       mov       rbx,rdi
       mov       rdi,7E29ACC013A8
       mov       r15,[rdi]
       cmp       byte ptr [r15+9D],0
       jne       near ptr M07_L11
M07_L00:
       lea       rsi,[rbx+48]
       mov       edi,0FFFFFFFF
       lock xadd [rsi],edi
       dec       edi
       je        short M07_L02
M07_L01:
       add       rsp,28
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M07_L02:
       mov       rsi,[rbx+40]
       mov       esi,[rsi+8]
       mov       rdi,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       xor       r13d,r13d
       xor       r12d,r12d
       xor       eax,eax
M07_L03:
       mov       rdi,[rbx+40]
       cmp       [rdi+8],eax
       jle       near ptr M07_L08
       cmp       eax,[rdi+8]
       jae       near ptr M07_L23
       mov       [rbp-2C],eax
       mov       ecx,eax
       mov       [rbp-38],rcx
       mov       r8,[rdi+rcx*8+10]
       mov       [rbp-40],r8
       test      dword ptr [r8+34],200000
       jne       near ptr M07_L12
       mov       edi,[r8+34]
       and       edi,600000
       cmp       edi,400000
       je        near ptr M07_L15
       test      dword ptr [r8+34],1600000
       je        near ptr M07_L16
M07_L04:
       mov       edi,[r8+34]
       and       edi,1600000
       cmp       edi,1000000
       jne       near ptr M07_L17
M07_L05:
       mov       edi,[r8+38]
       mov       eax,[rbp-2C]
       cmp       eax,[r14+8]
       jae       near ptr M07_L23
       mov       rcx,[rbp-38]
       mov       [r14+rcx*4+10],edi
M07_L06:
       test      dword ptr [r8+34],10000000
       jne       near ptr M07_L18
       mov       rdi,[rbx+40]
       mov       eax,[rbp-2C]
       cmp       eax,[rdi+8]
       jae       near ptr M07_L23
       xor       esi,esi
       mov       rcx,[rbp-38]
       mov       [rdi+rcx*8+10],rsi
M07_L07:
       mov       eax,[rbp-2C]
       inc       eax
       jmp       near ptr M07_L03
M07_L08:
       test      r13,r13
       jne       near ptr M07_L19
       test      r12,r12
       jne       near ptr M07_L20
       cmp       byte ptr [r15+9D],0
       jne       near ptr M07_L21
M07_L09:
       cmp       byte ptr [7E396F06B06C],0
       jne       near ptr M07_L22
M07_L10:
       mov       rdi,rbx
       mov       rsi,r14
       call      qword ptr [7E3970BB7E58]; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].TrySetResult(System.__Canon)
       jmp       near ptr M07_L01
M07_L11:
       mov       rdi,rbx
       call      qword ptr [7E3970BB7348]
       mov       esi,eax
       mov       rdi,r15
       mov       edx,1
       call      qword ptr [7E3970BB7A98]
       jmp       near ptr M07_L00
M07_L12:
       test      r13,r13
       jne       short M07_L13
       mov       rdi,offset MT_System.Collections.Generic.List<System.Runtime.ExceptionServices.ExceptionDispatchInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdi,r13
       call      qword ptr [7E39708AF0A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       r8,[rbp-40]
M07_L13:
       mov       rdi,[r8+28]
       mov       rdx,[rdi+18]
       mov       [rbp-48],rdx
       mov       rsi,[rdx+10]
       mov       [rbp-50],rsi
       cmp       byte ptr [rdx+20],0
       jne       short M07_L14
       mov       rdi,rdx
       call      qword ptr [7E39708A6868]; System.GC.SuppressFinalize(System.Object)
       mov       rdi,[rbp-48]
       mov       byte ptr [rdi+20],1
M07_L14:
       mov       rdi,r13
       mov       rsi,[rbp-50]
       cmp       [rdi],edi
       call      qword ptr [7E3970BB7DE0]
       mov       r8,[rbp-40]
       jmp       near ptr M07_L06
M07_L15:
       test      r12,r12
       jne       near ptr M07_L06
       mov       r12,r8
       mov       r8,[rbp-40]
       jmp       near ptr M07_L06
M07_L16:
       mov       rdi,r8
       mov       esi,0FFFFFFFF
       xor       edx,edx
       call      qword ptr [7E3970BB7C30]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
       mov       r8,[rbp-40]
       jmp       near ptr M07_L04
M07_L17:
       mov       rdi,r8
       mov       esi,1
       call      qword ptr [7E3970BBF3A8]
       mov       r8,[rbp-40]
       jmp       near ptr M07_L05
M07_L18:
       mov       rdi,rbx
       mov       esi,1
       call      qword ptr [7E3970BB7E40]
       jmp       near ptr M07_L07
M07_L19:
       mov       rdi,rbx
       mov       rsi,r13
       call      qword ptr [7E3970BB7B70]
       jmp       near ptr M07_L01
M07_L20:
       mov       rdi,r12
       call      qword ptr [7E3970BB7AB0]
       mov       r13,rax
       mov       rdi,r12
       call      qword ptr [7E3970BB7AC8]
       mov       rdx,rax
       mov       rsi,r13
       mov       rdi,rbx
       call      qword ptr [7E3970BB7AE0]
       jmp       near ptr M07_L01
M07_L21:
       mov       rdi,rbx
       call      qword ptr [7E3970BB7348]
       mov       esi,eax
       mov       rdi,r15
       mov       edx,1
       call      qword ptr [7E3970BB7B88]
       jmp       near ptr M07_L09
M07_L22:
       mov       rdi,rbx
       call      qword ptr [7E3970BB7BA0]
       jmp       near ptr M07_L10
M07_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 694
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbp
       push      rbx
       push      rax
       lea       rbp,[rsp+10]
       mov       ebx,edi
       call      qword ptr [7E396FC16AF0]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       edi,ebx
       and       edi,0FFFFFF
       mov       ecx,edi
       mov       edx,ebx
       sar       edx,18
       jne       short M08_L01
       cmp       [rax],edi
       jle       short M08_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       ecx,0FFFFFFFE
       movsxd    rdi,ecx
       mov       rax,[rax+rdi*8+10]
       test      rax,rax
       je        short M08_L03
M08_L00:
       add       rsp,8
       pop       rbx
       pop       rbp
       ret
M08_L01:
       mov       edi,ebx
       sar       edi,18
       cmp       edi,2
       jne       short M08_L02
       movsxd    rcx,ecx
       add       rax,rcx
       jmp       short M08_L00
M08_L02:
       cmp       [rax+4],ecx
       jle       short M08_L03
       mov       rdi,[rax+10]
       movsxd    rax,ecx
       mov       rdi,[rdi+rax*8]
       test      rdi,rdi
       je        short M08_L03
       mov       rax,[rdi]
       test      rax,rax
       je        short M08_L03
       jmp       short M08_L00
M08_L03:
       mov       edi,ebx
       lea       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       add       rsp,8
       pop       rbx
       pop       rbp
       jmp       qword ptr [rax]
; Total bytes of code 133
```
```assembly
; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rbx
       sub       rsp,18
       lea       rbp,[rsp+40]
       mov       rbx,rdi
       mov       r15,rsi
       mov       r14d,edx
       mov       r13,[rbx+20]
       mov       rsi,7E29ACC00238
       cmp       r13,[rsi]
       jne       short M09_L01
M09_L00:
       xor       eax,eax
       add       rsp,18
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M09_L01:
       mov       rsi,r13
       mov       rdi,offset MT_System.Collections.Generic.List<System.Object>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r12,rax
       test      r12,r12
       jne       near ptr M09_L11
       mov       rdi,offset MT_System.Collections.Generic.List<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rdi,r12
       call      qword ptr [7E39708AF0A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       test      r14b,r14b
       je        short M09_L05
       inc       dword ptr [r12+14]
       mov       rdi,[r12+8]
       mov       esi,[r12+10]
       cmp       [rdi+8],esi
       jbe       short M09_L02
       lea       edx,[rsi+1]
       mov       [r12+10],edx
       mov       rdx,r15
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M09_L03
M09_L02:
       mov       rdi,r12
       mov       rsi,r15
       call      qword ptr [7E39700572D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M09_L03:
       inc       dword ptr [r12+14]
       mov       rdi,[r12+8]
       mov       esi,[r12+10]
       cmp       [rdi+8],esi
       jbe       short M09_L04
       lea       edx,[rsi+1]
       mov       [r12+10],edx
       mov       rdx,r13
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M09_L09
M09_L04:
       mov       rdi,r12
       mov       rsi,r13
       call      qword ptr [7E39700572D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M09_L09
M09_L05:
       inc       dword ptr [r12+14]
       mov       rdi,[r12+8]
       mov       esi,[r12+10]
       cmp       [rdi+8],esi
       jbe       short M09_L06
       lea       edx,[rsi+1]
       mov       [r12+10],edx
       mov       rdx,r13
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M09_L07
M09_L06:
       mov       rdi,r12
       mov       rsi,r13
       call      qword ptr [7E39700572D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M09_L07:
       inc       dword ptr [r12+14]
       mov       rdi,[r12+8]
       mov       esi,[r12+10]
       cmp       [rdi+8],esi
       jbe       short M09_L08
       lea       edx,[rsi+1]
       mov       [r12+10],edx
       mov       rdx,r15
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M09_L09
M09_L08:
       mov       rdi,r12
       mov       rsi,r15
       call      qword ptr [7E39700572D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M09_L09:
       lea       rdi,[rbx+20]
       test      rdi,rdi
       jne       short M09_L10
       call      qword ptr [7E3970BBEAC0]
       int       3
M09_L10:
       mov       rsi,r12
       mov       rdx,r13
       call      00007E39EE474060
       mov       r12,rax
       cmp       r12,r13
       je        near ptr M09_L20
       mov       rsi,r12
       mov       rdi,offset MT_System.Collections.Generic.List<System.Object>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r12,rax
       test      r12,r12
       je        near ptr M09_L00
M09_L11:
       mov       [rbp-40],r12
       xor       esi,esi
       mov       [rbp-30],esi
       lea       rsi,[rbp-30]
       mov       rdi,r12
       call      qword ptr [7E3970055980]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rdi,[rbx+20]
       mov       rax,7E29ACC00238
       cmp       rdi,[rax]
       jne       short M09_L12
       xor       edi,edi
       mov       [rbp-34],edi
       jmp       near ptr M09_L18
M09_L12:
       mov       edi,[r12+10]
       mov       rax,[r12+8]
       cmp       edi,[rax+8]
       jne       short M09_L14
       mov       rdi,7E29ACC00290
       mov       rsi,[rdi]
       test      rsi,rsi
       jne       short M09_L13
       mov       rdi,offset MT_System.Predicate<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rsi,7E29ACC00260
       mov       rsi,[rsi]
       mov       rdi,rbx
       mov       rdx,7E3970BBBB10
       call      qword ptr [7E3970056E08]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdi,7E29ACC00290
       mov       rsi,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,rbx
M09_L13:
       mov       rdi,r12
       cmp       [rdi],edi
       call      qword ptr [7E3970BBFB28]
M09_L14:
       test      r14b,r14b
       je        short M09_L15
       mov       rdi,r12
       mov       rdx,r15
       xor       esi,esi
       call      qword ptr [7E3970146A30]
       jmp       short M09_L19
M09_L15:
       inc       dword ptr [r12+14]
       mov       rdi,[r12+8]
       mov       esi,[r12+10]
       cmp       [rdi+8],esi
       jbe       short M09_L16
       lea       edx,[rsi+1]
       mov       [r12+10],edx
       mov       rdx,r15
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M09_L19
M09_L16:
       mov       rdi,r12
       mov       rsi,r15
       call      qword ptr [7E39700572D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M09_L19
M09_L17:
       mov       rdi,r12
       call      qword ptr [7E3970056808]; System.Threading.Monitor.Exit(System.Object)
       jmp       short M09_L20
M09_L18:
       call      M09_L22
       jmp       short M09_L21
M09_L19:
       cmp       byte ptr [rbp-30],0
       jne       short M09_L17
M09_L20:
       mov       eax,1
       add       rsp,18
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M09_L21:
       mov       eax,[rbp-34]
       movzx     eax,al
       add       rsp,18
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M09_L22:
       push      rax
       cmp       byte ptr [rbp-30],0
       je        short M09_L23
       mov       rdi,[rbp-40]
       call      qword ptr [7E3970056808]; System.Threading.Monitor.Exit(System.Object)
M09_L23:
       nop
       add       rsp,8
       ret
; Total bytes of code 724
```
```assembly
; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rbx
       sub       rsp,10
       lea       rbp,[rsp+30]
       mov       rbx,rdi
       mov       r15,rsi
       mov       r14d,edx
M10_L00:
       mov       rdi,7E29ACC013A8
       mov       r13,[rdi]
       cmp       byte ptr [r13+9D],0
       jne       near ptr M10_L13
M10_L01:
       xor       eax,eax
       mov       edi,[r15+34]
       test      edi,200000
       jne       near ptr M10_L12
       test      edi,400000
       jne       near ptr M10_L14
       test      edi,1000000
       je        near ptr M10_L15
       mov       ecx,5
M10_L02:
       add       ecx,0FFFFFFFB
       jne       near ptr M10_L18
       cmp       byte ptr [r13+9D],0
       jne       near ptr M10_L20
M10_L03:
       cmp       byte ptr [7E396F06B06C],0
       jne       near ptr M10_L21
M10_L04:
       mov       rdi,r15
       mov       rax,offset MT_System.Threading.Tasks.Task<System.Int32>
       cmp       [rdi],rax
       jne       near ptr M10_L22
M10_L05:
       test      rdi,rdi
       je        near ptr M10_L23
       mov       esi,[rdi+34]
       and       esi,11000000
       cmp       esi,1000000
       jne       near ptr M10_L24
       mov       r15d,[rdi+38]
M10_L06:
       xor       r14d,r14d
       mov       eax,[rbx+34]
       mov       [rbp-24],eax
       test      eax,5600000
       jne       short M10_L10
       lea       rdi,[rbx+34]
       mov       esi,eax
       or        esi,4000000
       lock cmpxchg [rdi],esi
       cmp       eax,[rbp-24]
       jne       near ptr M10_L25
M10_L07:
       mov       [rbx+38],r15d
       lea       rdi,[rbx+34]
       mov       eax,[rbx+34]
       or        eax,1000000
       xchg      eax,[rdi]
       mov       r14,[rbx+28]
       test      r14,r14
       jne       near ptr M10_L26
M10_L08:
       lea       rdi,[rbx+20]
       test      rdi,rdi
       je        near ptr M10_L27
       mov       rsi,7E29ACC00238
       mov       rsi,[rsi]
       call      00007E39EE474040
       test      rax,rax
       je        short M10_L09
       mov       rdi,rbx
       mov       rsi,rax
       call      qword ptr [7E3970BB7708]; System.Threading.Tasks.Task.RunContinuations(System.Object)
M10_L09:
       mov       r14d,1
M10_L10:
       mov       eax,r14d
M10_L11:
       add       rsp,10
       pop       rbx
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M10_L12:
       mov       ecx,7
       jmp       near ptr M10_L02
M10_L13:
       mov       rdi,rbx
       call      qword ptr [7E3970BB7348]
       mov       esi,eax
       mov       rdi,r13
       mov       edx,1
       call      qword ptr [7E3970BB7A98]
       jmp       near ptr M10_L01
M10_L14:
       mov       ecx,6
       jmp       near ptr M10_L02
M10_L15:
       test      edi,800000
       je        short M10_L16
       mov       ecx,4
       jmp       near ptr M10_L02
M10_L16:
       test      edi,20000
       je        short M10_L17
       mov       ecx,3
       jmp       near ptr M10_L02
M10_L17:
       test      edi,2000000
       setne     cl
       movzx     ecx,cl
       mov       edx,2
       test      edi,10000
       cmovne    ecx,edx
       jmp       near ptr M10_L02
M10_L18:
       cmp       ecx,2
       ja        near ptr M10_L11
       mov       edi,ecx
       lea       rax,[7E39700DA510]
       mov       eax,[rax+rdi*4]
       lea       rcx,[M10_L00]
       add       rax,rcx
       jmp       rax
       mov       rdi,r15
       call      qword ptr [7E3970BB7AB0]
       mov       r14,rax
       mov       rdi,r15
       call      qword ptr [7E3970BB7AC8]
       mov       rdx,rax
       mov       rsi,r14
       mov       rdi,rbx
       call      qword ptr [7E3970BB7AE0]
       jmp       near ptr M10_L11
       mov       rdi,r15
       call      qword ptr [7E3970BB7AF8]
       mov       r15,rax
       test      r14b,r14b
       je        short M10_L19
       cmp       dword ptr [r15+10],0
       jle       short M10_L19
       mov       rdi,r15
       xor       esi,esi
       call      qword ptr [7E39701469B8]
       mov       r13,rax
       test      r13,r13
       je        short M10_L19
       mov       rsi,[r13+8]
       mov       rdi,offset MT_System.OperationCanceledException
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M10_L19
       mov       rsi,[rax+70]
       mov       rdi,rbx
       mov       rdx,r13
       call      qword ptr [7E3970BB7AE0]
       jmp       near ptr M10_L11
M10_L19:
       mov       rdi,rbx
       mov       rsi,r15
       call      qword ptr [7E3970BB7B70]
       jmp       near ptr M10_L11
M10_L20:
       mov       rdi,rbx
       call      qword ptr [7E3970BB7348]
       mov       esi,eax
       mov       rdi,r13
       mov       edx,1
       call      qword ptr [7E3970BB7B88]
       jmp       near ptr M10_L03
M10_L21:
       mov       rdi,rbx
       call      qword ptr [7E3970BB7BA0]
       jmp       near ptr M10_L04
M10_L22:
       mov       rsi,r15
       mov       rdi,rax
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M10_L05
M10_L23:
       xor       r15d,r15d
       jmp       near ptr M10_L06
M10_L24:
       mov       esi,1
       call      qword ptr [7E3970BB7E10]; System.Threading.Tasks.Task`1[[System.Int32, System.Private.CoreLib]].GetResultCore(Boolean)
       mov       r15d,eax
       jmp       near ptr M10_L06
M10_L25:
       mov       rdi,rbx
       mov       esi,4000000
       mov       edx,5600000
       call      qword ptr [7E3970BBEFD0]
       test      eax,eax
       je        near ptr M10_L10
       jmp       near ptr M10_L07
M10_L26:
       mov       rdi,rbx
       call      qword ptr [7E3970BBF3C0]
       mov       rdi,r14
       call      qword ptr [7E3970BBF3D8]
       jmp       near ptr M10_L08
M10_L27:
       call      qword ptr [7E3970BBEAC0]
       int       3
; Total bytes of code 782
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
       jne       short M11_L00
       mov       rdi,rbx
       mov       esi,0FFFFFFFF
       xor       edx,edx
       call      qword ptr [7E3970BB7C30]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M11_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M11_L03
M11_L01:
       mov       edi,[rbx+34]
       and       edi,1600000
       cmp       edi,1000000
       jne       short M11_L04
M11_L02:
       pop       rbx
       pop       r15
       pop       rbp
       ret
M11_L03:
       mov       rdi,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M11_L01
       mov       rdi,rbx
       call      qword ptr [7E3970BBFAB0]
       jmp       short M11_L01
M11_L04:
       test      r15b,2
       jne       short M11_L05
       mov       rdi,rbx
       call      qword ptr [7E3970BBF900]
M11_L05:
       mov       rdi,rbx
       call      qword ptr [7E3970BBFEB8]
       jmp       short M11_L02
; Total bytes of code 125
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.ContendedFirstCallBenchmarks.AsyncLazy()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm8,xmm8,xmm8
       vmovdqu   ymmword ptr [rbp-50],ymm8
       mov       [rbp-30],rax
       mov       [rbp-38],rdi
       mov       rdi,offset MT_AsyncLazyBenchmarks.ContendedFirstCallBenchmarks+<>c__DisplayClass9_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rdi,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdi,7A3BFCC01358
       mov       rsi,[rdi]
       lea       rdi,[rbx+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-40]
       lea       rdi,[rax+8]
       mov       rsi,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       edi,edi
       mov       [rbp-24],edi
M00_L00:
       mov       rdi,[rbp-38]
       mov       rbx,[rdi+8]
       mov       eax,[rbx+8]
       cmp       eax,[rbp-24]
       jle       near ptr M00_L36
       mov       rax,[rbp-40]
       mov       r15,[rax+10]
       mov       [rbp-48],rbx
       test      r15,r15
       je        near ptr M00_L08
M00_L01:
       mov       rcx,7A3BFCC01378
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L48
M00_L02:
       cmp       [rcx],cl
       mov       rcx,7A3BFCC01388
       mov       rbx,[rcx]
       mov       rdi,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-58],rax
       mov       rdi,[rbp-58]
       lea       rdi,[rdi+8]
       mov       rsi,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbp-58]
       xor       esi,esi
       mov       [rdi+10],rsi
       mov       rdi,[rbp-58]
       lea       rdi,[rdi+18]
       mov       rsi,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       edi,2008
       mov       rax,[rbp-58]
       mov       [rax+34],edi
       mov       rdi,7A4C3D6A0D68
       mov       rax,7A4C3E01B820
       call      rax
       cmp       dword ptr [rax],4
       jle       near ptr M00_L49
       mov       rdi,[rax+8]
       mov       rax,[rdi+20]
       test      rax,rax
       je        near ptr M00_L49
M00_L03:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M00_L04
       call      qword ptr [7A4BBF89C030]; System.Threading.Thread.InitializeCurrentThread()
M00_L04:
       mov       rbx,[rax+8]
       test      rbx,rbx
       jne       near ptr M00_L50
       mov       rdi,7A3BFCC01398
       mov       rbx,[rdi]
M00_L05:
       test      rbx,rbx
       jne       near ptr M00_L09
       mov       rdi,[rbp-58]
       or        dword ptr [rdi+34],20000000
M00_L06:
       mov       rdi,[rbp-58]
       xor       esi,esi
       call      qword ptr [7A4BBFBA6AD8]; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
       mov       rdi,offset MT_System.Threading.Tasks.UnwrapPromise<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-50],rax
       mov       rdi,[rbp-58]
       movzx     ebx,word ptr [rdi+34]
       and       ebx,4
       test      ebx,0FFFFFFBB
       je        near ptr M00_L11
M00_L07:
       mov       edi,2D
       call      qword ptr [7A4BBF04F0D8]
       int       3
M00_L08:
       mov       rdi,offset MT_System.Func<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rdi,[r15+8]
       mov       rsi,[rbp-40]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset AsyncLazyBenchmarks.ContendedFirstCallBenchmarks+<>c__DisplayClass9_0.<AsyncLazy>b__0()
       mov       [r15+18],rdi
       mov       rsi,[rbp-40]
       lea       rdi,[rsi+10]
       mov       rsi,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L09:
       mov       rdi,7A3BFCC01398
       cmp       rbx,[rdi]
       je        near ptr M00_L06
       mov       rdi,[rbp-58]
       mov       rax,[rdi+28]
       test      rax,rax
       jne       short M00_L10
       mov       rdi,offset MT_System.Threading.Tasks.Task+ContingentProperties
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       dword ptr [r15+3C],1
       mov       rdi,[rbp-58]
       lea       rdi,[rdi+28]
       mov       rsi,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,r15
M00_L10:
       lea       rdi,[rax+8]
       mov       rsi,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L06
M00_L11:
       test      bl,4
       je        near ptr M00_L14
       mov       rdi,7A4C3D6A0D68
       mov       rax,7A4C3E01B820
       call      rax
       cmp       dword ptr [rax],8
       jle       near ptr M00_L51
       mov       rdi,[rax+8]
       mov       rax,[rdi+40]
       test      rax,rax
       je        near ptr M00_L51
M00_L12:
       mov       r15,[rax+10]
       test      r15,r15
       je        short M00_L14
       mov       rdi,[rbp-50]
       mov       rax,[rdi+28]
       test      rax,rax
       jne       short M00_L13
       mov       rdi,offset MT_System.Threading.Tasks.Task+ContingentProperties
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [r14+3C],1
       mov       rdi,[rbp-50]
       lea       rdi,[rdi+28]
       mov       rsi,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,r14
M00_L13:
       lea       rdi,[rax+30]
       mov       rsi,r15
       call      CORINFO_HELP_ASSIGN_REF
M00_L14:
       mov       rdi,[rbp-50]
       xor       eax,eax
       mov       [rdi+8],rax
       mov       rdi,[rbp-50]
       mov       [rdi+10],rax
       mov       rdi,[rbp-50]
       mov       [rdi+18],rax
       test      ebx,0FFFFFFA0
       jne       near ptr M00_L07
       mov       edi,ebx
       or        edi,400
       or        edi,2000000
       mov       rax,[rbp-50]
       mov       [rax+34],edi
       mov       rdi,[rbp-50]
       mov       rdi,[rdi+28]
       test      rdi,rdi
       jne       near ptr M00_L52
M00_L15:
       mov       rdi,[rbp-50]
       mov       byte ptr [rdi+3D],1
       mov       rdi,7A3BFCC013A8
       mov       rdi,[rdi]
       cmp       byte ptr [rdi+9D],0
       jne       near ptr M00_L53
M00_L16:
       cmp       byte ptr [7A4BBE05B06C],0
       jne       near ptr M00_L54
M00_L17:
       mov       rdi,[rbp-58]
       test      dword ptr [rdi+34],1600000
       jne       near ptr M00_L55
       mov       rdi,[rbp-58]
       test      dword ptr [rdi+34],1600000
       jne       near ptr M00_L35
       mov       rdi,[rbp-58]
       cmp       qword ptr [rdi+20],0
       jne       short M00_L19
       mov       rdi,[rbp-58]
       add       rdi,20
       test      rdi,rdi
       je        near ptr M00_L76
       mov       rsi,[rbp-50]
       xor       edx,edx
       call      00007A4C3D474060
       test      rax,rax
       jne       short M00_L19
M00_L18:
       movsxd    rsi,dword ptr [rbp-24]
       mov       rdi,[rbp-48]
       mov       rdx,[rbp-50]
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       edi,[rbp-24]
       inc       edi
       mov       [rbp-24],edi
       jmp       near ptr M00_L00
M00_L19:
       mov       rsi,[rbp-58]
       mov       rbx,[rsi+20]
       mov       rsi,7A3BFCC00238
       mov       r15,[rsi]
       cmp       rbx,r15
       je        near ptr M00_L56
       mov       r14,rbx
       test      r14,r14
       je        short M00_L20
       mov       rdi,offset MT_System.Collections.Generic.List<System.Object>
       cmp       [r14],rdi
       jne       short M00_L22
M00_L20:
       test      r14,r14
       je        short M00_L23
M00_L21:
       mov       [rbp-60],r14
       xor       edi,edi
       mov       [rbp-28],edi
       jmp       near ptr M00_L25
M00_L22:
       mov       rsi,rbx
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       jmp       short M00_L20
M00_L23:
       mov       rdi,offset MT_System.Collections.Generic.List<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdi,7A3BFCC00AB8
       mov       rsi,[rdi]
       lea       rdi,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [r14+14]
       mov       rdi,r14
       mov       rsi,rbx
       call      qword ptr [7A4BBF0472D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       inc       dword ptr [r14+14]
       mov       rdi,[r14+8]
       mov       esi,[r14+10]
       cmp       [rdi+8],esi
       jbe       near ptr M00_L57
       lea       edx,[rsi+1]
       mov       [r14+10],edx
       mov       esi,esi
       mov       rdx,[rbp-50]
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M00_L24:
       mov       rdi,[rbp-58]
       add       rdi,20
       test      rdi,rdi
       je        near ptr M00_L76
       mov       rsi,r14
       mov       rdx,rbx
       call      00007A4C3D474060
       mov       r14,rax
       cmp       r14,rbx
       jne       near ptr M00_L58
       jmp       near ptr M00_L33
M00_L25:
       mov       rdi,r14
       call      00007A4C3D2E6020
       test      eax,eax
       jne       short M00_L26
       mov       rdi,r14
       call      qword ptr [7A4BBFBAC240]; System.Threading.Monitor.Enter_Slowpath(System.Object)
M00_L26:
       mov       dword ptr [rbp-28],1
       mov       rdi,[rbp-58]
       cmp       [rdi+20],r15
       je        short M00_L28
       mov       edi,[r14+10]
       mov       rax,[r14+8]
       cmp       edi,[rax+8]
       je        short M00_L29
M00_L27:
       inc       dword ptr [r14+14]
       mov       rdi,[r14+8]
       mov       esi,[r14+10]
       cmp       [rdi+8],esi
       jbe       near ptr M00_L31
       lea       edx,[rsi+1]
       mov       [r14+10],edx
       mov       esi,esi
       mov       rdx,[rbp-50]
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M00_L32
M00_L28:
       xor       edi,edi
       mov       [rbp-2C],edi
       jmp       near ptr M00_L60
M00_L29:
       mov       rdi,7A3BFCC00290
       mov       rsi,[rdi]
       test      rsi,rsi
       jne       short M00_L30
       mov       rdi,offset MT_System.Predicate<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdi,7A3BFCC00260
       mov       rsi,[rdi]
       lea       rdi,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset System.Threading.Tasks.Task+<>c.<AddTaskContinuationComplex>b__211_0(System.Object)
       mov       [rbx+18],rdi
       mov       rdi,7A3BFCC00290
       mov       rsi,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,rbx
M00_L30:
       mov       rdi,r14
       cmp       [rdi],edi
       call      qword ptr [7A4BBFBAC228]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAll(System.Predicate`1<System.__Canon>)
       jmp       near ptr M00_L27
M00_L31:
       mov       rdi,r14
       mov       rsi,[rbp-50]
       call      qword ptr [7A4BBF0472D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       nop
M00_L32:
       mov       rdi,r14
       call      00007A4C3D2E6790
       test      eax,eax
       jne       near ptr M00_L59
M00_L33:
       mov       ebx,1
M00_L34:
       test      ebx,ebx
       jne       near ptr M00_L18
M00_L35:
       call      00007A4C3D4F8300
       test      eax,eax
       je        near ptr M00_L69
       mov       rdi,[rbp-50]
       movzx     ebx,byte ptr [rdi+3C]
       test      ebx,ebx
       je        near ptr M00_L62
       jmp       near ptr M00_L61
M00_L36:
       mov       rsi,rbx
       test      rsi,rsi
       je        near ptr M00_L70
       lea       rbx,[rsi+10]
       mov       r15d,[rsi+8]
       test      r15d,r15d
       je        near ptr M00_L71
       mov       esi,r15d
       mov       rdi,offset MT_System.Threading.Tasks.Task<System.Int32>[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       lea       rdi,[r14+10]
       mov       edx,r15d
       shl       rdx,3
       cmp       rdx,4000
       jbe       short M00_L37
       mov       rsi,rbx
       call      qword ptr [7A4BBFC54108]
       jmp       short M00_L38
M00_L37:
       mov       rsi,rbx
       call      00007A4C3D470D90
       cmp       dword ptr [7A4C3D6CEC80],0
       jne       near ptr M00_L72
M00_L38:
       mov       ebx,[r14+8]
       test      ebx,ebx
       jle       short M00_L40
       lea       rdi,[r14+10]
       mov       esi,ebx
M00_L39:
       cmp       qword ptr [rdi],0
       je        near ptr M00_L73
       add       rdi,8
       dec       esi
       jne       short M00_L39
M00_L40:
       mov       rdi,offset MT_System.Threading.Tasks.Task+WhenAllPromise<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       dword ptr [r15+34],2000400
       lea       rdi,[r15+40]
       mov       rsi,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r15+48],ebx
       mov       rdi,7A3BFCC013A8
       mov       rdi,[rdi]
       cmp       byte ptr [rdi+9D],0
       jne       near ptr M00_L74
M00_L41:
       cmp       byte ptr [7A4BBE05B06C],0
       jne       near ptr M00_L75
M00_L42:
       test      ebx,ebx
       jle       short M00_L47
       add       r14,10
       jmp       short M00_L45
M00_L43:
       mov       rdi,r15
       mov       rsi,r13
       call      qword ptr [7A4BBFBE8A88]; System.Threading.Tasks.Task+WhenAllPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
M00_L44:
       add       r14,8
       dec       ebx
       je        short M00_L47
M00_L45:
       mov       r13,[r14]
       test      dword ptr [r13+34],1600000
       jne       short M00_L43
       test      dword ptr [r13+34],1600000
       jne       short M00_L43
       cmp       qword ptr [r13+20],0
       jne       short M00_L46
       lea       rdi,[r13+20]
       test      rdi,rdi
       je        near ptr M00_L76
       mov       rsi,r15
       xor       edx,edx
       call      00007A4C3D474060
       test      rax,rax
       je        short M00_L44
M00_L46:
       mov       rdi,r13
       mov       rsi,r15
       xor       edx,edx
       call      qword ptr [7A4BBFBAC138]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       short M00_L44
       jmp       short M00_L43
M00_L47:
       mov       rax,r15
       add       rsp,40
       pop       rbx
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L48:
       mov       rdi,offset MT_System.Threading.Tasks.TaskFactory<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,7A3BFCC01378
       xor       edx,edx
       call      00007A4C3D474060
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M00_L02
       mov       rcx,7A3BFCC01378
       mov       rcx,[rcx]
       jmp       near ptr M00_L02
M00_L49:
       mov       edi,4
       call      qword ptr [7A4BBFBAF750]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L03
M00_L50:
       cmp       byte ptr [rbx+18],0
       je        near ptr M00_L05
       xor       ebx,ebx
       jmp       near ptr M00_L05
M00_L51:
       mov       edi,8
       call      qword ptr [7A4BBFBAF750]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L12
M00_L52:
       mov       rdi,[rdi+30]
       test      rdi,rdi
       je        near ptr M00_L15
       test      bl,4
       je        near ptr M00_L15
       test      byte ptr [rdi+34],8
       jne       near ptr M00_L15
       call      qword ptr [7A4BBFBAF4B0]
       jmp       near ptr M00_L15
M00_L53:
       mov       rdi,[rbp-50]
       call      qword ptr [7A4BBFBA7498]
       mov       esi,eax
       mov       rdi,7A3BFCC013A8
       mov       rdi,[rdi]
       mov       rdx,7A4BAE40AC38
       xor       ecx,ecx
       call      qword ptr [7A4BBFBA74B0]
       jmp       near ptr M00_L16
M00_L54:
       mov       rdi,[rbp-50]
       call      qword ptr [7A4BBFBA74C8]
       jmp       near ptr M00_L17
M00_L55:
       mov       rdi,[rbp-50]
       mov       rsi,[rbp-58]
       call      qword ptr [7A4BBFBA74F8]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].ProcessCompletedOuterTask(System.Threading.Tasks.Task)
       jmp       near ptr M00_L18
M00_L56:
       xor       ebx,ebx
       jmp       near ptr M00_L34
M00_L57:
       mov       rdi,r14
       mov       rsi,[rbp-50]
       call      qword ptr [7A4BBF0472D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L24
M00_L58:
       mov       rsi,r14
       mov       rdi,offset MT_System.Collections.Generic.List<System.Object>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       je        short M00_L56
       jmp       near ptr M00_L21
M00_L59:
       mov       edi,eax
       mov       rsi,r14
       call      qword ptr [7A4BBFBAD560]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       near ptr M00_L33
M00_L60:
       call      M00_L77
       nop
       mov       ebx,[rbp-2C]
       jmp       near ptr M00_L34
M00_L61:
       cmp       ebx,1
       jne       near ptr M00_L18
       mov       rdi,[rbp-50]
       mov       rsi,[rbp-58]
       xor       edx,edx
       call      qword ptr [7A4BBFBAC0C0]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       jmp       near ptr M00_L66
M00_L62:
       mov       rdi,[rbp-50]
       mov       byte ptr [rdi+3C],1
       mov       rdi,[rbp-58]
       call      qword ptr [7A4BBFBAC0D8]; System.Threading.Tasks.Task.get_Status()
       cmp       eax,5
       je        short M00_L63
       add       eax,0FFFFFFFA
       cmp       eax,1
       ja        near ptr M00_L18
       mov       rdx,[rbp-50]
       movzx     edx,byte ptr [rdx+3D]
       mov       rdi,[rbp-50]
       mov       rsi,[rbp-58]
       call      qword ptr [7A4BBFBAC0C0]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       jmp       near ptr M00_L18
M00_L63:
       mov       rdi,[rbp-58]
       mov       edi,[rdi+34]
       and       edi,11000000
       cmp       edi,1000000
       jne       short M00_L64
       mov       rdi,[rbp-58]
       mov       rsi,[rdi+38]
       jmp       short M00_L65
M00_L64:
       mov       rdi,[rbp-58]
       mov       esi,1
       call      qword ptr [7A4BBFBAFE88]
       mov       rsi,rax
M00_L65:
       test      rsi,rsi
       jne       short M00_L67
       mov       rdi,[rbp-50]
       xor       esi,esi
       xor       edx,edx
       call      qword ptr [7A4BBFBACA20]
M00_L66:
       mov       rdi,[rbp-50]
       mov       byte ptr [rdi+3C],2
       jmp       near ptr M00_L18
M00_L67:
       test      dword ptr [rsi+34],1600000
       je        short M00_L68
       mov       rdi,[rbp-50]
       xor       edx,edx
       call      qword ptr [7A4BBFBAC0C0]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       jmp       short M00_L66
M00_L68:
       mov       rdi,rsi
       mov       rsi,[rbp-50]
       xor       edx,edx
       call      qword ptr [7A4BBFBA7510]; System.Threading.Tasks.Task.AddCompletionAction(System.Threading.Tasks.ITaskCompletionAction, Boolean)
       jmp       near ptr M00_L18
M00_L69:
       mov       rdi,[rbp-50]
       mov       rsi,[rbp-58]
       call      qword ptr [7A4BBFBAC0A8]
       jmp       near ptr M00_L18
M00_L70:
       mov       edi,33
       call      qword ptr [7A4BBF04FAE0]
       int       3
M00_L71:
       mov       rdi,offset MT_System.Threading.Tasks.Task<System.Int32[]>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdi,r15
       xor       esi,esi
       mov       rdx,7A4BAE40A280
       xor       ecx,ecx
       xor       r8d,r8d
       call      qword ptr [7A4BBFBA7960]
       jmp       near ptr M00_L47
M00_L72:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L38
M00_L73:
       mov       edi,1D
       mov       esi,33
       call      qword ptr [7A4BBFBA7990]
       int       3
M00_L74:
       mov       rdi,r15
       call      qword ptr [7A4BBFBA7498]
       mov       esi,eax
       mov       rdi,7A3BFCC013A8
       mov       rdi,[rdi]
       mov       rdx,7A4BAE40AFC0
       xor       ecx,ecx
       call      qword ptr [7A4BBFBA74B0]
       jmp       near ptr M00_L41
M00_L75:
       mov       rdi,r15
       call      qword ptr [7A4BBFBA74C8]
       jmp       near ptr M00_L42
M00_L76:
       call      qword ptr [7A4BBFBAF318]
       int       3
M00_L77:
       push      rax
       cmp       dword ptr [rbp-28],0
       je        short M00_L78
       mov       rdi,[rbp-60]
       call      00007A4C3D2E6790
       test      eax,eax
       je        short M00_L78
       mov       edi,eax
       mov       rsi,[rbp-60]
       call      qword ptr [7A4BBFBAD560]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M00_L78:
       nop
       add       rsp,8
       ret
; Total bytes of code 2583
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       mov       esi,[rdi+34]
       and       esi,11000000
       cmp       esi,1000000
       jne       short M01_L00
       ret
M01_L00:
       xor       esi,esi
       jmp       qword ptr [7A4BBFBA7AC8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
; Total bytes of code 26
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
       call      qword ptr [7A4BBEBEEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdi,[rbp-90]
       call      qword ptr [rax]
       lea       rdi,[rbp-88]
       call      qword ptr [7A4BBEBEEF08]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-30]
       call      qword ptr [7A4BBEBF0B98]
       lea       rdi,[rax+10]
       mov       rsi,[rbp-30]
       call      qword ptr [7A4BBEBEEEB8]; CORINFO_HELP_ASSIGN_REF
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
; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
       push      rbp
       push      r15
       push      r14
       push      rbx
       push      rax
       lea       rbp,[rsp+20]
       mov       [rbp-20],rdi
       test      sil,sil
       jne       near ptr M03_L19
       or        dword ptr [rdi+34],10000
M03_L00:
       cmp       byte ptr [7A4BBE05B06C],0
       jne       near ptr M03_L20
M03_L01:
       mov       rax,7A3BFCC013A8
       mov       rbx,[rax]
       cmp       byte ptr [rbx+9D],0
       jne       near ptr M03_L21
M03_L02:
       mov       r15,[rdi+18]
       cmp       [r15],r15b
       cmp       byte ptr [rbx+9D],0
       jne       near ptr M03_L11
M03_L03:
       mov       rsi,offset MT_System.Threading.Tasks.ThreadPoolTaskScheduler
       cmp       [r15],rsi
       jne       near ptr M03_L17
       movzx     r15d,word ptr [rdi+34]
       test      r15b,2
       jne       near ptr M03_L12
       mov       rsi,7A3BFCC013B0
       mov       rbx,[rsi]
       cmp       byte ptr [rbx+38],0
       jne       near ptr M03_L13
M03_L04:
       test      r15b,1
       jne       short M03_L06
       mov       rdi,7A4C3D6A0D68
       mov       rax,7A4C3E01B820
       call      rax
       cmp       dword ptr [rax],5
       jle       near ptr M03_L14
       mov       rdi,[rax+8]
       mov       rax,[rdi+28]
       test      rax,rax
       je        near ptr M03_L14
M03_L05:
       mov       rdi,[rax+10]
       test      rdi,rdi
       jne       short M03_L08
M03_L06:
       mov       rsi,[rbx+8]
       mov       rcx,[rsi+10]
       mov       rdx,[rcx+8]
M03_L07:
       mov       r15d,[rcx+0A0]
       mov       eax,r15d
       and       eax,[rcx+18]
       cmp       eax,[rdx+8]
       jae       near ptr M03_L15
       shl       rax,4
       lea       r14,[rdx+rax+10]
       mov       eax,[r14+8]
       sub       eax,r15d
       jne       short M03_L09
       lea       r8,[rcx+0A0]
       lea       r9d,[r15+1]
       mov       eax,r15d
       lock cmpxchg [r8],r9d
       cmp       eax,r15d
       jne       short M03_L07
       mov       rsi,[rbp-20]
       mov       rdi,r14
       call      CORINFO_HELP_ASSIGN_REF
       inc       r15d
       mov       [r14+8],r15d
       jmp       short M03_L10
M03_L08:
       mov       rdi,[rdi+18]
       mov       rsi,[rbp-20]
       cmp       [rdi],edi
       call      qword ptr [7A4BBFBAC948]; System.Threading.ThreadPoolWorkQueue+WorkStealingQueue.LocalPush(System.Object)
       jmp       short M03_L10
M03_L09:
       test      eax,eax
       jge       short M03_L07
       mov       rdi,rsi
       mov       rsi,[rbp-20]
       call      qword ptr [7A4BBFBAF768]
M03_L10:
       add       rbx,78
       mov       edi,1
       xchg      edi,[rbx]
       test      edi,edi
       jne       near ptr M03_L18
       mov       rdi,7A3BFCC013D8
       mov       rbx,[rdi]
       lea       rdi,[rbx+160]
       lock inc  dword ptr [rdi]
       mov       rdi,rbx
       call      qword ptr [7A4BBFBA6EB0]; System.Threading.PortableThreadPool+WorkerThread.MaybeAddWorkingWorker(System.Threading.PortableThreadPool)
       cmp       dword ptr [rbx+164],6
       je        near ptr M03_L18
       jmp       near ptr M03_L16
M03_L11:
       mov       rsi,r15
       call      qword ptr [7A4BBFBAFB10]
       mov       rdi,[rbp-20]
       jmp       near ptr M03_L03
M03_L12:
       mov       rdi,offset MT_System.Threading.Tasks.ThreadPoolTaskScheduler
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdi,7A3BFCC01490
       mov       rbx,[rdi]
       mov       rdi,offset MT_System.Threading.Thread
       call      CORINFO_HELP_NEWFAST
       mov       r15,rax
       mov       rdi,r15
       mov       rsi,rbx
       call      qword ptr [7A4BBFC54768]
       mov       rdi,r15
       mov       esi,1
       call      qword ptr [7A4BBFBA7090]; System.Threading.Thread.set_IsBackground(Boolean)
       mov       rdi,r15
       mov       rsi,7A4BAE40A068
       call      qword ptr [7A4BBFBA7198]; System.Threading.Thread.set_Name(System.String)
       mov       rdi,r15
       mov       rsi,[rbp-20]
       xor       edx,edx
       call      qword ptr [7A4BBFC54780]
       jmp       short M03_L18
M03_L13:
       mov       rsi,7A3BFCC013C8
       mov       rsi,[rsi]
       cmp       byte ptr [rsi+9D],0
       je        near ptr M03_L04
       mov       rsi,7A3BFCC013C8
       mov       rdi,[rsi]
       mov       rsi,[rbp-20]
       call      qword ptr [7A4BBFBAF738]
       jmp       near ptr M03_L04
M03_L14:
       mov       edi,5
       call      qword ptr [7A4BBFBAF750]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M03_L05
M03_L15:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M03_L16:
       mov       rdi,rbx
       call      qword ptr [7A4BBFBA7108]; System.Threading.PortableThreadPool+GateThread.EnsureRunningSlow(System.Threading.PortableThreadPool)
       jmp       short M03_L18
M03_L17:
       mov       rdi,r15
       mov       rsi,[rbp-20]
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       nop
M03_L18:
       add       rsp,8
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L19:
       call      qword ptr [7A4BBFC54750]
       test      eax,eax
       mov       rdi,[rbp-20]
       jne       near ptr M03_L00
       jmp       short M03_L18
M03_L20:
       call      qword ptr [7A4BBFBA74C8]
       mov       rdi,[rbp-20]
       jmp       near ptr M03_L01
M03_L21:
       test      word ptr [rdi+34],200
       jne       near ptr M03_L02
       call      qword ptr [7A4BBFBA7498]
       mov       r15d,eax
       mov       rdi,[rbp-20]
       mov       rdi,[rdi+8]
       call      qword ptr [7A4BBFBAFA80]
       mov       rsi,rax
       mov       rdi,7A4BAE409FE0
       call      qword ptr [7A4BBF04EFA0]; System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       esi,r15d
       mov       rdi,rbx
       xor       ecx,ecx
       call      qword ptr [7A4BBFBA74B0]
       mov       rdi,[rbp-20]
       jmp       near ptr M03_L02
       push      rax
       mov       rbx,rdi
       mov       rdi,offset MT_System.Threading.Tasks.TaskSchedulerException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdi,r15
       mov       rsi,rbx
       call      qword ptr [7A4BBFBAFA98]
       mov       rdi,[rbp-20]
       mov       rsi,r15
       call      qword ptr [7A4BBFBAFAB0]
       mov       rdi,[rbp-20]
       xor       esi,esi
       call      qword ptr [7A4BBFBAFAC8]
       mov       rdi,[rbp-20]
       call      qword ptr [7A4BBFBAFAE0]
       test      eax,200
       jne       short M03_L22
       mov       rdi,[rbp-20]
       mov       rdi,[rdi+28]
       mov       rdi,[rdi+18]
       xor       esi,esi
       cmp       [rdi],edi
       call      qword ptr [7A4BBFBAFAF8]
M03_L22:
       mov       rdi,r15
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 876
```
```assembly
; AsyncLazyBenchmarks.ContendedFirstCallBenchmarks+<>c__DisplayClass9_0.<AsyncLazy>b__0()
       mov       rdi,[rdi+8]
       mov       rax,[rdi+10]
       test      rax,rax
       jne       short M04_L00
       xor       esi,esi
       jmp       qword ptr [7A4BBFBA7A80]; System.Threading.Tasks.AsyncLazy`1[[System.Int32, System.Private.CoreLib]].GetOrStartAttemptAsync(System.Threading.CancellationToken)
M04_L00:
       ret
; Total bytes of code 22
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       push      rbp
       mov       rbp,rsp
       mov       eax,[rdi+8]
       cmp       rax,rsi
       jbe       short M05_L02
       lea       rax,[rdi+rsi*8+10]
       mov       rdi,[rdi]
       mov       rsi,[rdi+30]
       test      rdx,rdx
       je        short M05_L01
       cmp       rsi,[rdx]
       je        short M05_L00
       mov       rcx,offset MT_System.Object[]
       cmp       rdi,rcx
       je        short M05_L00
       mov       rdi,rax
       pop       rbp
       jmp       qword ptr [7A4BBF897A68]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
M05_L00:
       mov       rdi,rax
       mov       rsi,rdx
       pop       rbp
       jmp       near ptr 00007A4C3D5FB900
M05_L01:
       xor       ecx,ecx
       mov       [rax],rcx
       pop       rbp
       ret
M05_L02:
       call      qword ptr [7A4BBFBAF1C8]
       int       3
; Total bytes of code 85
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       push      rbp
       mov       rbp,rsp
       test      rsi,rsi
       je        short M06_L02
       mov       rax,[rsi]
       cmp       rax,rdi
       je        short M06_L02
       mov       rax,[rax+10]
       cmp       rax,rdi
       je        short M06_L02
M06_L00:
       test      rax,rax
       je        short M06_L01
       mov       rax,[rax+10]
       cmp       rax,rdi
       je        short M06_L02
       test      rax,rax
       je        short M06_L01
       mov       rax,[rax+10]
       cmp       rax,rdi
       je        short M06_L02
       test      rax,rax
       je        short M06_L01
       mov       rax,[rax+10]
       cmp       rax,rdi
       je        short M06_L02
       test      rax,rax
       jne       short M06_L03
M06_L01:
       xor       esi,esi
M06_L02:
       mov       rax,rsi
       pop       rbp
       ret
M06_L03:
       mov       rax,[rax+10]
       cmp       rax,rdi
       je        short M06_L02
       jmp       short M06_L00
; Total bytes of code 91
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       mov       r15,rsi
       mov       r14d,[rbx+10]
       mov       r13d,r14d
       lea       edi,[r13+1]
       mov       rsi,[rbx+8]
       cmp       dword ptr [rsi+8],0
       jne       short M07_L01
       mov       r12d,4
M07_L00:
       mov       esi,7FFFFFC7
       cmp       r12d,7FFFFFC7
       cmova     r12d,esi
       cmp       r12d,edi
       cmovl     r12d,edi
       cmp       r12d,r14d
       jge       short M07_L02
       mov       edi,7
       mov       esi,0F
       call      qword ptr [7A4BBFB2C468]
       int       3
M07_L01:
       mov       rsi,[rbx+8]
       mov       r12d,[rsi+8]
       add       r12d,r12d
       jmp       short M07_L00
M07_L02:
       mov       rdi,[rbx+8]
       cmp       [rdi+8],r12d
       je        near ptr M07_L08
       test      r12d,r12d
       jg        short M07_L05
       mov       rdi,[rbx]
       mov       rsi,[rdi+30]
       mov       rsi,[rsi]
       mov       rsi,[rsi+38]
       test      rsi,rsi
       je        short M07_L04
M07_L03:
       mov       rdi,rsi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rsi,[rax]
       lea       rdi,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M07_L08
M07_L04:
       mov       rsi,7A4BBFBFED20
       call      qword ptr [7A4BBF04F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       short M07_L03
M07_L05:
       mov       rdi,[rbx]
       mov       rsi,[rdi+30]
       mov       rsi,[rsi]
       mov       rax,[rsi+40]
       test      rax,rax
       je        short M07_L09
       mov       rdi,rax
M07_L06:
       mov       esi,r12d
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r12,rax
       test      r14d,r14d
       jle       short M07_L07
       mov       rdi,[rbx+8]
       mov       edx,r14d
       mov       rsi,r12
       call      qword ptr [7A4BBF0469E8]; System.Array.Copy(System.Array, System.Array, Int32)
M07_L07:
       lea       rdi,[rbx+8]
       mov       rsi,r12
       call      CORINFO_HELP_ASSIGN_REF
M07_L08:
       lea       edi,[r13+1]
       mov       [rbx+10],edi
       mov       rdi,[rbx+8]
       movsxd    rsi,r13d
       mov       rdx,r15
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       nop
       add       rsp,8
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M07_L09:
       mov       rsi,7A4BBFBFED30
       call      qword ptr [7A4BBF04F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       short M07_L06
; Total bytes of code 317
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
       mov       rax,7A4BBF087D28
       mov       [rbp-58],rax
       lea       rax,[M08_L00]
       mov       [rbp-48],rax
       lea       rax,[rbp-68]
       mov       [rbx+8],rax
       mov       byte ptr [rbx+4],0
       mov       rax,7A4C3D2E5E10
       call      rax
M08_L00:
       mov       byte ptr [rbx+4],1
       cmp       dword ptr [7A4C3D6CEC80],0
       je        short M08_L01
       call      qword ptr [7A4C3D6BB1D8]; CORINFO_HELP_STOP_FOR_GC
M08_L01:
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
; System.Threading.Tasks.Task+<>c.<AddTaskContinuationComplex>b__211_0(System.Object)
       test      rsi,rsi
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 10
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAll(System.Predicate`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rbx
       lea       rbp,[rsp+20]
       mov       rbx,rdi
       mov       r15,rsi
       test      r15,r15
       je        near ptr M10_L04
       xor       r14d,r14d
       cmp       dword ptr [rbx+10],0
       jle       short M10_L01
       mov       rsi,offset System.Threading.Tasks.Task+<>c.<AddTaskContinuationComplex>b__211_0(System.Object)
       cmp       [r15+18],rsi
       jne       short M10_L02
M10_L00:
       mov       rsi,[rbx+8]
       cmp       r14d,[rsi+8]
       jae       near ptr M10_L11
       mov       edi,r14d
       mov       rsi,[rsi+rdi*8+10]
       test      rsi,rsi
       je        short M10_L01
       inc       r14d
       cmp       r14d,[rbx+10]
       jl        short M10_L00
M10_L01:
       cmp       r14d,[rbx+10]
       jl        short M10_L06
       xor       eax,eax
       pop       rbx
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M10_L02:
       mov       rsi,[rbx+8]
       cmp       r14d,[rsi+8]
       jae       near ptr M10_L11
       mov       edi,r14d
       mov       rsi,[rsi+rdi*8+10]
       mov       rdi,offset System.Threading.Tasks.Task+<>c.<AddTaskContinuationComplex>b__211_0(System.Object)
       cmp       [r15+18],rdi
       jne       short M10_L05
       test      rsi,rsi
       je        short M10_L01
M10_L03:
       inc       r14d
       cmp       r14d,[rbx+10]
       jge       short M10_L01
       jmp       short M10_L02
M10_L04:
       mov       edi,1A
       call      qword ptr [7A4BBF04FAE0]
       int       3
M10_L05:
       mov       rdi,[r15+8]
       call      qword ptr [r15+18]
       test      eax,eax
       je        short M10_L03
       jmp       short M10_L01
M10_L06:
       lea       r13d,[r14+1]
       jmp       short M10_L10
M10_L07:
       inc       r13d
M10_L08:
       cmp       r13d,[rbx+10]
       jge       short M10_L09
       mov       rsi,[rbx+8]
       cmp       r13d,[rsi+8]
       jae       short M10_L11
       mov       edi,r13d
       mov       rsi,[rsi+rdi*8+10]
       mov       rdi,[r15+8]
       call      qword ptr [r15+18]
       test      eax,eax
       jne       short M10_L07
M10_L09:
       cmp       r13d,[rbx+10]
       jge       short M10_L10
       mov       esi,r14d
       lea       r14d,[rsi+1]
       mov       edi,r13d
       lea       r13d,[rdi+1]
       mov       rdx,[rbx+8]
       mov       rax,[rbx+8]
       cmp       edi,[rax+8]
       jae       short M10_L11
       mov       rax,[rax+rdi*8+10]
       mov       rdi,rdx
       mov       rdx,rax
       movsxd    rsi,esi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M10_L10:
       cmp       r13d,[rbx+10]
       jl        short M10_L08
       mov       edx,[rbx+10]
       sub       edx,r14d
       mov       rdi,[rbx+8]
       mov       esi,r14d
       call      qword ptr [7A4BBFC544F8]
       mov       eax,[rbx+10]
       sub       eax,r14d
       mov       [rbx+10],r14d
       inc       dword ptr [rbx+14]
       pop       rbx
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M10_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 336
```
```assembly
; System.Threading.Tasks.Task+WhenAllPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+50]
       mov       rbx,rdi
       mov       rdi,7A3BFCC013A8
       mov       r15,[rdi]
       cmp       byte ptr [r15+9D],0
       jne       near ptr M11_L15
M11_L00:
       lea       rsi,[rbx+48]
       mov       edi,0FFFFFFFF
       lock xadd [rsi],edi
       dec       edi
       je        short M11_L02
M11_L01:
       add       rsp,28
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M11_L02:
       mov       rsi,[rbx+40]
       mov       esi,[rsi+8]
       mov       rdi,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       xor       r13d,r13d
       xor       r12d,r12d
       xor       eax,eax
M11_L03:
       mov       rdi,[rbx+40]
       cmp       [rdi+8],eax
       jle       near ptr M11_L12
       cmp       eax,[rdi+8]
       jae       near ptr M11_L25
       mov       [rbp-2C],eax
       mov       ecx,eax
       mov       [rbp-38],rcx
       mov       r8,[rdi+rcx*8+10]
       mov       [rbp-40],r8
       test      dword ptr [r8+34],200000
       jne       near ptr M11_L08
       mov       edi,[r8+34]
       and       edi,600000
       cmp       edi,400000
       je        near ptr M11_L17
       test      dword ptr [r8+34],1600000
       je        near ptr M11_L18
M11_L04:
       mov       edi,[r8+34]
       and       edi,1600000
       cmp       edi,1000000
       jne       near ptr M11_L19
M11_L05:
       mov       edi,[r8+38]
       mov       eax,[rbp-2C]
       cmp       eax,[r14+8]
       jae       near ptr M11_L25
       mov       rcx,[rbp-38]
       mov       [r14+rcx*4+10],edi
M11_L06:
       test      dword ptr [r8+34],10000000
       jne       short M11_L11
       mov       rdi,[rbx+40]
       mov       eax,[rbp-2C]
       cmp       eax,[rdi+8]
       jae       near ptr M11_L25
       xor       esi,esi
       mov       rcx,[rbp-38]
       mov       [rdi+rcx*8+10],rsi
M11_L07:
       mov       eax,[rbp-2C]
       inc       eax
       jmp       near ptr M11_L03
M11_L08:
       test      r13,r13
       je        near ptr M11_L16
M11_L09:
       mov       rdi,[r8+28]
       mov       rdx,[rdi+18]
       mov       [rbp-48],rdx
       mov       rsi,[rdx+10]
       mov       [rbp-50],rsi
       cmp       byte ptr [rdx+20],0
       jne       short M11_L10
       mov       rdi,rdx
       call      qword ptr [7A4BBF896868]; System.GC.SuppressFinalize(System.Object)
       mov       rdi,[rbp-48]
       mov       byte ptr [rdi+20],1
M11_L10:
       mov       rdi,r13
       mov       rsi,[rbp-50]
       cmp       [rdi],edi
       call      qword ptr [7A4BBFBACB40]
       mov       r8,[rbp-40]
       jmp       short M11_L06
M11_L11:
       mov       edi,[rbx+34]
       test      edi,5600000
       jne       short M11_L07
       lea       rsi,[rbx+34]
       mov       edx,edi
       or        edx,10000000
       mov       eax,edi
       lock cmpxchg [rsi],edx
       cmp       eax,edi
       je        short M11_L07
       jmp       near ptr M11_L20
M11_L12:
       test      r13,r13
       jne       near ptr M11_L21
       test      r12,r12
       jne       near ptr M11_L22
       cmp       byte ptr [r15+9D],0
       jne       near ptr M11_L23
M11_L13:
       cmp       byte ptr [7A4BBE05B06C],0
       jne       near ptr M11_L24
M11_L14:
       mov       rdi,rbx
       mov       rsi,r14
       call      qword ptr [7A4BBFBACBA0]; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].TrySetResult(System.__Canon)
       jmp       near ptr M11_L01
M11_L15:
       mov       rdi,rbx
       call      qword ptr [7A4BBFBA7498]
       mov       esi,eax
       mov       rdi,r15
       mov       edx,1
       call      qword ptr [7A4BBFBAC9D8]
       jmp       near ptr M11_L00
M11_L16:
       mov       rdi,offset MT_System.Collections.Generic.List<System.Runtime.ExceptionServices.ExceptionDispatchInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdi,r13
       call      qword ptr [7A4BBF89F0A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       r8,[rbp-40]
       jmp       near ptr M11_L09
M11_L17:
       test      r12,r12
       jne       near ptr M11_L06
       mov       r12,r8
       mov       r8,[rbp-40]
       jmp       near ptr M11_L06
M11_L18:
       mov       rdi,r8
       mov       esi,0FFFFFFFF
       xor       edx,edx
       call      qword ptr [7A4BBFBA7AE0]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
       mov       r8,[rbp-40]
       jmp       near ptr M11_L04
M11_L19:
       mov       rdi,r8
       mov       esi,1
       call      qword ptr [7A4BBFBAF9A8]
       mov       r8,[rbp-40]
       jmp       near ptr M11_L05
M11_L20:
       mov       rdi,rbx
       mov       esi,10000000
       mov       edx,5600000
       call      qword ptr [7A4BBFBAF9C0]
       jmp       near ptr M11_L07
M11_L21:
       mov       rdi,rbx
       mov       rsi,r13
       call      qword ptr [7A4BBFBACAB0]
       jmp       near ptr M11_L01
M11_L22:
       mov       rdi,r12
       call      qword ptr [7A4BBFBAC9F0]
       mov       r13,rax
       mov       rdi,r12
       call      qword ptr [7A4BBFBACA08]
       mov       rdx,rax
       mov       rsi,r13
       mov       rdi,rbx
       call      qword ptr [7A4BBFBACA20]
       jmp       near ptr M11_L01
M11_L23:
       mov       rdi,rbx
       call      qword ptr [7A4BBFBA7498]
       mov       esi,eax
       mov       rdi,r15
       mov       edx,1
       call      qword ptr [7A4BBFBACAC8]
       jmp       near ptr M11_L13
M11_L24:
       mov       rdi,rbx
       call      qword ptr [7A4BBFBACAE0]
       jmp       near ptr M11_L14
M11_L25:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 739
```
```assembly
; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+50]
       mov       rbx,rdi
       mov       r15,rsi
       mov       r14d,edx
       mov       r13,[rbx+20]
       mov       rsi,7A3BFCC00238
       mov       r12,[rsi]
       cmp       r13,r12
       je        near ptr M12_L04
       mov       rax,r13
       test      rax,rax
       je        short M12_L00
       mov       rdi,offset MT_System.Collections.Generic.List<System.Object>
       cmp       [rax],rdi
       je        short M12_L00
       mov       rsi,r13
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
M12_L00:
       test      rax,rax
       je        short M12_L02
M12_L01:
       mov       [rbp-40],rax
       xor       edi,edi
       mov       [rbp-2C],edi
       jmp       near ptr M12_L05
M12_L02:
       mov       rdi,offset MT_System.Collections.Generic.List<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-48],rax
       mov       rdi,7A3BFCC00AB8
       mov       rsi,[rdi]
       lea       rdi,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      r14b,r14b
       jne       near ptr M12_L18
       mov       rax,[rbp-48]
       inc       dword ptr [rax+14]
       mov       rdi,rax
       mov       rsi,r13
       call      qword ptr [7A4BBF0472D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       rax,[rbp-48]
       inc       dword ptr [rax+14]
       mov       rdi,[rax+8]
       mov       esi,[rax+10]
       cmp       [rdi+8],esi
       jbe       near ptr M12_L17
       lea       edx,[rsi+1]
       mov       [rax+10],edx
       mov       esi,esi
       mov       rdx,r15
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M12_L03:
       lea       rdi,[rbx+20]
       test      rdi,rdi
       je        near ptr M12_L20
       mov       rsi,[rbp-48]
       mov       rdx,r13
       call      00007A4C3D474060
       mov       rdi,rax
       cmp       rdi,r13
       je        near ptr M12_L15
       mov       rsi,rdi
       mov       rdi,offset MT_System.Collections.Generic.List<System.Object>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r13,rax
       test      r13,r13
       mov       rax,r13
       jne       near ptr M12_L01
M12_L04:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M12_L05:
       mov       [rbp-38],rax
       mov       rdi,rax
       call      00007A4C3D2E6020
       test      eax,eax
       jne       short M12_L06
       mov       rdi,[rbp-38]
       call      qword ptr [7A4BBFBAC240]; System.Threading.Monitor.Enter_Slowpath(System.Object)
M12_L06:
       mov       dword ptr [rbp-2C],1
       cmp       [rbx+20],r12
       je        short M12_L12
       mov       r13,[rbp-38]
       mov       edi,[r13+10]
       mov       rax,[r13+8]
       cmp       edi,[rax+8]
       je        short M12_L08
M12_L07:
       test      r14b,r14b
       jne       short M12_L11
       inc       dword ptr [r13+14]
       mov       rdi,[r13+8]
       mov       esi,[r13+10]
       cmp       [rdi+8],esi
       jbe       short M12_L10
       lea       edx,[rsi+1]
       mov       [r13+10],edx
       mov       esi,esi
       mov       rdx,r15
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M12_L14
M12_L08:
       mov       rdi,7A3BFCC00290
       mov       rsi,[rdi]
       test      rsi,rsi
       je        short M12_L13
M12_L09:
       mov       rdi,r13
       cmp       [rdi],edi
       call      qword ptr [7A4BBFBAC228]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAll(System.Predicate`1<System.__Canon>)
       jmp       short M12_L07
M12_L10:
       mov       rdi,r13
       mov       rsi,r15
       call      qword ptr [7A4BBF0472D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M12_L14
M12_L11:
       mov       rdi,r13
       mov       rdx,r15
       xor       esi,esi
       call      qword ptr [7A4BBF136A30]
       jmp       short M12_L14
M12_L12:
       xor       edi,edi
       mov       [rbp-30],edi
       jmp       short M12_L16
M12_L13:
       mov       rdi,offset MT_System.Predicate<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rsi,7A3BFCC00260
       mov       rsi,[rsi]
       mov       rdi,rbx
       mov       rdx,offset System.Threading.Tasks.Task+<>c.<AddTaskContinuationComplex>b__211_0(System.Object)
       call      qword ptr [7A4BBF046E08]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdi,7A3BFCC00290
       mov       rsi,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,rbx
       jmp       short M12_L09
M12_L14:
       mov       rdi,r13
       call      00007A4C3D2E6790
       test      eax,eax
       jne       near ptr M12_L21
M12_L15:
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M12_L16:
       call      M12_L22
       nop
       mov       eax,[rbp-30]
       movzx     eax,al
       add       rsp,28
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M12_L17:
       mov       rdi,rax
       mov       rsi,r15
       call      qword ptr [7A4BBF0472D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M12_L03
M12_L18:
       mov       rax,[rbp-48]
       inc       dword ptr [rax+14]
       mov       rdi,rax
       mov       rsi,r15
       call      qword ptr [7A4BBF0472D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       rax,[rbp-48]
       inc       dword ptr [rax+14]
       mov       rdi,[rax+8]
       mov       esi,[rax+10]
       cmp       [rdi+8],esi
       jbe       short M12_L19
       lea       edx,[rsi+1]
       mov       [rax+10],edx
       mov       esi,esi
       mov       rdx,r13
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M12_L03
M12_L19:
       mov       rdi,rax
       mov       rsi,r13
       call      qword ptr [7A4BBF0472D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M12_L03
M12_L20:
       call      qword ptr [7A4BBFBAF318]
       int       3
M12_L21:
       mov       edi,eax
       mov       rsi,r13
       call      qword ptr [7A4BBFBAD560]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       near ptr M12_L15
M12_L22:
       push      rax
       cmp       dword ptr [rbp-2C],0
       je        short M12_L23
       mov       rdi,[rbp-40]
       call      00007A4C3D2E6790
       test      eax,eax
       je        short M12_L23
       mov       edi,eax
       mov       rsi,[rbp-40]
       call      qword ptr [7A4BBFBAD560]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M12_L23:
       nop
       add       rsp,8
       ret
; Total bytes of code 757
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbp
       push      rbx
       push      rax
       lea       rbp,[rsp+10]
       mov       ebx,edi
       call      qword ptr [7A4BBEC06AF0]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       edi,ebx
       and       edi,0FFFFFF
       mov       ecx,edi
       mov       edx,ebx
       sar       edx,18
       jne       short M13_L01
       cmp       [rax],edi
       jle       short M13_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       ecx,0FFFFFFFE
       movsxd    rdi,ecx
       mov       rax,[rax+rdi*8+10]
       test      rax,rax
       je        short M13_L03
M13_L00:
       add       rsp,8
       pop       rbx
       pop       rbp
       ret
M13_L01:
       mov       edi,ebx
       sar       edi,18
       cmp       edi,2
       jne       short M13_L02
       movsxd    rcx,ecx
       add       rax,rcx
       jmp       short M13_L00
M13_L02:
       cmp       [rax+4],ecx
       jle       short M13_L03
       mov       rdi,[rax+10]
       movsxd    rax,ecx
       mov       rdi,[rdi+rax*8]
       test      rdi,rdi
       je        short M13_L03
       mov       rax,[rdi]
       test      rax,rax
       je        short M13_L03
       jmp       short M13_L00
M13_L03:
       mov       edi,ebx
       lea       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       add       rsp,8
       pop       rbx
       pop       rbp
       jmp       qword ptr [rax]
; Total bytes of code 133
```
```assembly
; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].ProcessCompletedOuterTask(System.Threading.Tasks.Task)
       push      rbp
       push      r15
       push      r14
       push      rbx
       push      rax
       lea       rbp,[rsp+20]
       mov       rbx,rdi
       mov       r15,rsi
       mov       byte ptr [rbx+3C],1
       mov       esi,[r15+34]
       test      esi,200000
       jne       near ptr M14_L07
       test      esi,400000
       jne       near ptr M14_L08
       test      esi,1000000
       je        near ptr M14_L09
       mov       r14d,5
M14_L00:
       cmp       r14d,5
       jne       near ptr M14_L12
       mov       rdi,r15
       mov       rax,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task<System.Int32>>
       cmp       [rdi],rax
       jne       near ptr M14_L13
M14_L01:
       test      rdi,rdi
       je        near ptr M14_L14
       mov       esi,[rdi+34]
       and       esi,11000000
       cmp       esi,1000000
       jne       near ptr M14_L16
       mov       r14,[rdi+38]
M14_L02:
       test      r14,r14
       je        near ptr M14_L17
       test      dword ptr [r14+34],1600000
       je        short M14_L05
       mov       rdi,rbx
       mov       rsi,r14
       xor       edx,edx
       call      qword ptr [7A4BBFBAC0C0]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
M14_L03:
       mov       byte ptr [rbx+3C],2
M14_L04:
       add       rsp,8
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       ret
M14_L05:
       test      dword ptr [r14+34],1600000
       jne       near ptr M14_L19
       cmp       qword ptr [r14+20],0
       jne       short M14_L06
       lea       rdi,[r14+20]
       test      rdi,rdi
       je        near ptr M14_L18
       mov       rsi,rbx
       xor       edx,edx
       call      00007A4C3D474060
       test      rax,rax
       je        short M14_L04
M14_L06:
       mov       rdi,r14
       mov       rsi,rbx
       xor       edx,edx
       call      qword ptr [7A4BBFBAC138]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       short M14_L04
       jmp       near ptr M14_L19
M14_L07:
       mov       r14d,7
       jmp       near ptr M14_L00
M14_L08:
       mov       r14d,6
       jmp       near ptr M14_L00
M14_L09:
       test      esi,800000
       je        short M14_L10
       mov       r14d,4
       jmp       near ptr M14_L00
M14_L10:
       test      esi,20000
       je        short M14_L11
       mov       r14d,3
       jmp       near ptr M14_L00
M14_L11:
       test      esi,2000000
       setne     r14b
       movzx     r14d,r14b
       mov       edi,2
       test      esi,10000
       cmovne    r14d,edi
       jmp       near ptr M14_L00
M14_L12:
       add       r14d,0FFFFFFFA
       cmp       r14d,1
       ja        near ptr M14_L04
       movzx     edx,byte ptr [rbx+3D]
       mov       rdi,rbx
       mov       rsi,r15
       call      qword ptr [7A4BBFBAC0C0]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       jmp       near ptr M14_L04
M14_L13:
       mov       rsi,r15
       mov       rdi,rax
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M14_L01
M14_L14:
       mov       rdi,r15
       mov       rax,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task>
       cmp       [rdi],rax
       je        short M14_L15
       mov       rsi,r15
       mov       rdi,rax
       call      qword ptr [7A4BBF474AF8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rdi,rax
M14_L15:
       cmp       [rdi],edi
       call      qword ptr [7A4BBFBAC0F0]; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].get_Result()
       mov       r14,rax
       jmp       near ptr M14_L02
M14_L16:
       mov       esi,1
       call      qword ptr [7A4BBFBAFE88]
       mov       r14,rax
       jmp       near ptr M14_L02
M14_L17:
       mov       rdi,rbx
       xor       esi,esi
       xor       edx,edx
       call      qword ptr [7A4BBFBACA20]
       jmp       near ptr M14_L03
M14_L18:
       call      qword ptr [7A4BBFBAF318]
       int       3
M14_L19:
       mov       rdi,rbx
       mov       rsi,r14
       add       rsp,8
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7A4BBFBDB658]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
; Total bytes of code 517
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
       call      qword ptr [7A4BBEBEEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdi,[rbp-94]
       mov       esi,[rbp-8C]
       call      qword ptr [rax]
       lea       rdi,[rbp-88]
       call      qword ptr [7A4BBEBEEF08]; CORINFO_HELP_JIT_PINVOKE_END
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
; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rbx
       sub       rsp,10
       lea       rbp,[rsp+30]
       mov       rbx,rdi
       mov       r15,rsi
       mov       r14d,edx
M16_L00:
       mov       rdi,7A3BFCC013A8
       mov       r13,[rdi]
       cmp       byte ptr [r13+9D],0
       jne       near ptr M16_L12
M16_L01:
       xor       eax,eax
       mov       edi,[r15+34]
       test      edi,200000
       jne       near ptr M16_L13
       test      edi,400000
       jne       near ptr M16_L14
       test      edi,1000000
       je        near ptr M16_L15
       mov       ecx,5
M16_L02:
       add       ecx,0FFFFFFFB
       jne       near ptr M16_L18
       cmp       byte ptr [r13+9D],0
       jne       near ptr M16_L20
M16_L03:
       cmp       byte ptr [7A4BBE05B06C],0
       jne       near ptr M16_L21
M16_L04:
       mov       rdi,r15
       mov       rax,offset MT_System.Threading.Tasks.Task<System.Int32>
       cmp       [rdi],rax
       jne       near ptr M16_L22
M16_L05:
       test      rdi,rdi
       je        near ptr M16_L23
       mov       esi,[rdi+34]
       and       esi,11000000
       cmp       esi,1000000
       jne       near ptr M16_L24
       mov       r15d,[rdi+38]
M16_L06:
       xor       r14d,r14d
       mov       eax,[rbx+34]
       mov       [rbp-24],eax
       test      eax,5600000
       jne       short M16_L10
       lea       rdi,[rbx+34]
       mov       esi,eax
       or        esi,4000000
       lock cmpxchg [rdi],esi
       cmp       eax,[rbp-24]
       jne       near ptr M16_L25
M16_L07:
       mov       [rbx+38],r15d
       lea       rdi,[rbx+34]
       mov       eax,[rbx+34]
       or        eax,1000000
       xchg      eax,[rdi]
       mov       r14,[rbx+28]
       test      r14,r14
       jne       near ptr M16_L26
M16_L08:
       lea       rdi,[rbx+20]
       test      rdi,rdi
       je        near ptr M16_L27
       mov       rsi,7A3BFCC00238
       mov       rsi,[rsi]
       call      00007A4C3D474040
       test      rax,rax
       je        short M16_L09
       mov       rdi,rbx
       mov       rsi,rax
       call      qword ptr [7A4BBFBAC018]; System.Threading.Tasks.Task.RunContinuations(System.Object)
M16_L09:
       mov       r14d,1
M16_L10:
       mov       eax,r14d
M16_L11:
       add       rsp,10
       pop       rbx
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M16_L12:
       mov       rdi,rbx
       call      qword ptr [7A4BBFBA7498]
       mov       esi,eax
       mov       rdi,r13
       mov       edx,1
       call      qword ptr [7A4BBFBAC9D8]
       jmp       near ptr M16_L01
M16_L13:
       mov       ecx,7
       jmp       near ptr M16_L02
M16_L14:
       mov       ecx,6
       jmp       near ptr M16_L02
M16_L15:
       test      edi,800000
       je        short M16_L16
       mov       ecx,4
       jmp       near ptr M16_L02
M16_L16:
       test      edi,20000
       je        short M16_L17
       mov       ecx,3
       jmp       near ptr M16_L02
M16_L17:
       test      edi,2000000
       setne     cl
       movzx     ecx,cl
       mov       edx,2
       test      edi,10000
       cmovne    ecx,edx
       jmp       near ptr M16_L02
M16_L18:
       cmp       ecx,2
       ja        near ptr M16_L11
       mov       edi,ecx
       lea       rax,[7A4BBF0D09E0]
       mov       eax,[rax+rdi*4]
       lea       rcx,[M16_L00]
       add       rax,rcx
       jmp       rax
       mov       rdi,r15
       call      qword ptr [7A4BBFBAC9F0]
       mov       r14,rax
       mov       rdi,r15
       call      qword ptr [7A4BBFBACA08]
       mov       rdx,rax
       mov       rsi,r14
       mov       rdi,rbx
       call      qword ptr [7A4BBFBACA20]
       jmp       near ptr M16_L11
       mov       rdi,r15
       call      qword ptr [7A4BBFBACA38]
       mov       r15,rax
       test      r14b,r14b
       je        short M16_L19
       cmp       dword ptr [r15+10],0
       jle       short M16_L19
       mov       rdi,r15
       xor       esi,esi
       call      qword ptr [7A4BBF1369B8]
       mov       r13,rax
       test      r13,r13
       je        short M16_L19
       mov       rsi,[r13+8]
       mov       rdi,offset MT_System.OperationCanceledException
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M16_L19
       mov       rsi,[rax+70]
       mov       rdi,rbx
       mov       rdx,r13
       call      qword ptr [7A4BBFBACA20]
       jmp       near ptr M16_L11
M16_L19:
       mov       rdi,rbx
       mov       rsi,r15
       call      qword ptr [7A4BBFBACAB0]
       jmp       near ptr M16_L11
M16_L20:
       mov       rdi,rbx
       call      qword ptr [7A4BBFBA7498]
       mov       esi,eax
       mov       rdi,r13
       mov       edx,1
       call      qword ptr [7A4BBFBACAC8]
       jmp       near ptr M16_L03
M16_L21:
       mov       rdi,rbx
       call      qword ptr [7A4BBFBACAE0]
       jmp       near ptr M16_L04
M16_L22:
       mov       rsi,r15
       mov       rdi,rax
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M16_L05
M16_L23:
       xor       r15d,r15d
       jmp       near ptr M16_L06
M16_L24:
       mov       esi,1
       call      qword ptr [7A4BBFBACB58]; System.Threading.Tasks.Task`1[[System.Int32, System.Private.CoreLib]].GetResultCore(Boolean)
       mov       r15d,eax
       jmp       near ptr M16_L06
M16_L25:
       mov       rdi,rbx
       mov       esi,4000000
       mov       edx,5600000
       call      qword ptr [7A4BBFBAF9C0]
       test      eax,eax
       je        near ptr M16_L10
       jmp       near ptr M16_L07
M16_L26:
       mov       rdi,rbx
       call      qword ptr [7A4BBFBAF9D8]
       mov       rdi,r14
       call      qword ptr [7A4BBFBAF9F0]
       jmp       near ptr M16_L08
M16_L27:
       call      qword ptr [7A4BBFBAF318]
       int       3
; Total bytes of code 782
```
```assembly
; System.Threading.Tasks.Task.get_Status()
       push      rbp
       mov       rbp,rsp
       mov       eax,[rdi+34]
       test      eax,200000
       jne       short M17_L01
       test      eax,400000
       jne       short M17_L02
       test      eax,1000000
       je        short M17_L03
       mov       eax,5
M17_L00:
       pop       rbp
       ret
M17_L01:
       mov       eax,7
       jmp       short M17_L00
M17_L02:
       mov       eax,6
       jmp       short M17_L00
M17_L03:
       test      eax,800000
       je        short M17_L04
       mov       eax,4
       jmp       short M17_L00
M17_L04:
       test      eax,20000
       je        short M17_L05
       mov       eax,3
       jmp       short M17_L00
M17_L05:
       test      eax,2000000
       setne     cl
       movzx     ecx,cl
       mov       edx,2
       test      eax,10000
       mov       eax,edx
       cmove     eax,ecx
       jmp       short M17_L00
; Total bytes of code 105
```
```assembly
; System.Threading.Tasks.Task.AddCompletionAction(System.Threading.Tasks.ITaskCompletionAction, Boolean)
       push      rbp
       push      r15
       push      r14
       push      rbx
       push      rax
       lea       rbp,[rsp+20]
       mov       rbx,rdi
       mov       r15,rsi
       mov       r14d,edx
       test      dword ptr [rbx+34],1600000
       jne       short M18_L02
       cmp       qword ptr [rbx+20],0
       jne       short M18_L01
       lea       rdi,[rbx+20]
       test      rdi,rdi
       je        short M18_L03
       mov       rsi,r15
       xor       edx,edx
       call      00007A4C3D474060
       test      rax,rax
       jne       short M18_L01
M18_L00:
       add       rsp,8
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       ret
M18_L01:
       movzx     edx,r14b
       mov       rdi,rbx
       mov       rsi,r15
       call      qword ptr [7A4BBFBAC138]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       short M18_L00
M18_L02:
       mov       rdi,offset MT_System.Threading.Tasks.UnwrapPromise<System.Int32>
       cmp       [r15],rdi
       jne       short M18_L04
       mov       rdi,r15
       mov       rsi,rbx
       add       rsp,8
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7A4BBFBDB658]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
M18_L03:
       call      qword ptr [7A4BBFBAF318]
       int       3
M18_L04:
       mov       rdi,r15
       mov       rsi,rbx
       mov       r11,7A4BBE060510
       add       rsp,8
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [r11]
; Total bytes of code 165
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
       jne       short M19_L00
       mov       rdi,rbx
       mov       esi,0FFFFFFFF
       xor       edx,edx
       call      qword ptr [7A4BBFBA7AE0]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M19_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M19_L03
M19_L01:
       mov       edi,[rbx+34]
       and       edi,1600000
       cmp       edi,1000000
       jne       short M19_L04
M19_L02:
       pop       rbx
       pop       r15
       pop       rbp
       ret
M19_L03:
       mov       rdi,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M19_L01
       mov       rdi,rbx
       call      qword ptr [7A4BBFC542D0]
       jmp       short M19_L01
M19_L04:
       test      r15b,2
       jne       short M19_L05
       mov       rdi,rbx
       call      qword ptr [7A4BBFC54120]
M19_L05:
       mov       rdi,rbx
       call      qword ptr [7A4BBFC54AB0]
       jmp       short M19_L02
; Total bytes of code 125
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.ContendedFirstCallBenchmarks.Nito()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       rbx,rdi
       mov       rdi,offset MT_AsyncLazyBenchmarks.ContendedFirstCallBenchmarks+<>c__DisplayClass10_0
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdi,offset MT_Nito.AsyncEx.AsyncLazy<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdi,7F02B8C01358
       mov       r13,[rdi]
       mov       rsi,r13
       lea       rdi,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset MT_Nito.AsyncEx.AsyncLazy<System.Int32>+<>c__DisplayClass14_0
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rdi,[r12+8]
       mov       rsi,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset MT_System.Func<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rdi,[r13+8]
       mov       rsi,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset Nito.AsyncEx.AsyncLazy`1+<>c__DisplayClass14_0[[System.Int32, System.Private.CoreLib]].<RunOnThreadPool>b__0()
       mov       [r13+18],rdi
       lea       rdi,[r14+10]
       mov       rsi,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rdi,[r14+8]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset MT_System.Lazy<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rsi,[r14+10]
       lea       rdi,[r13+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset MT_System.LazyHelper
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+10],8
       lea       rdi,[r13+8]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdi,[r14+18]
       mov       rsi,r13
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdi,[r15+8]
       mov       rsi,r14
       call      CORINFO_HELP_ASSIGN_REF
       xor       r14d,r14d
M00_L00:
       mov       r13,[rbx+8]
       cmp       [r13+8],r14d
       jle       near ptr M00_L22
       mov       r12,[r15+10]
       test      r12,r12
       je        near ptr M00_L08
M00_L01:
       mov       rdi,7F02B8C01378
       mov       rax,[rdi]
       test      rax,rax
       je        near ptr M00_L34
M00_L02:
       cmp       [rax],al
       mov       rdi,7F02B8C01388
       mov       rax,[rdi]
       mov       [rbp-40],rax
       mov       rdi,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-48],rax
       lea       rdi,[rax+8]
       mov       rsi,r12
       call      CORINFO_HELP_ASSIGN_REF
       xor       edi,edi
       mov       r12,[rbp-48]
       mov       [r12+10],rdi
       lea       rdi,[r12+18]
       mov       rsi,[rbp-40]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edi,2008
       mov       [r12+34],edi
       mov       rdi,7F12F82A0D68
       mov       rax,7F12F8C72820
       call      rax
       cmp       dword ptr [rax],4
       jle       near ptr M00_L35
       mov       rdi,[rax+8]
       mov       rax,[rdi+20]
       test      rax,rax
       je        near ptr M00_L35
M00_L03:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M00_L04
       call      qword ptr [7F127A46C030]; System.Threading.Thread.InitializeCurrentThread()
M00_L04:
       mov       rax,[rax+8]
       test      rax,rax
       jne       near ptr M00_L09
       mov       rax,7F02B8C01398
       mov       rax,[rax]
M00_L05:
       test      rax,rax
       jne       near ptr M00_L10
       or        dword ptr [r12+34],20000000
M00_L06:
       mov       rdi,r12
       xor       esi,esi
       call      qword ptr [7F127A776A60]; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
       mov       rdi,offset MT_System.Threading.Tasks.UnwrapPromise<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       movzx     ecx,word ptr [r12+34]
       and       ecx,4
       mov       [rbp-2C],ecx
       test      ecx,0FFFFFFBB
       je        near ptr M00_L12
M00_L07:
       mov       edi,2D
       call      qword ptr [7F1279C1F0D8]
       int       3
M00_L08:
       mov       rdi,offset MT_System.Func<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rdi,[r12+8]
       mov       rsi,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset AsyncLazyBenchmarks.ContendedFirstCallBenchmarks+<>c__DisplayClass10_0.<Nito>b__0()
       mov       [r12+18],rdi
       lea       rdi,[r15+10]
       mov       rsi,r12
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L09:
       cmp       byte ptr [rax+18],0
       je        near ptr M00_L05
       xor       eax,eax
       jmp       near ptr M00_L05
M00_L10:
       mov       rdi,7F02B8C01398
       mov       [rbp-50],rax
       cmp       rax,[rdi]
       je        near ptr M00_L06
       mov       rax,[rbp-50]
       mov       rcx,[r12+28]
       test      rcx,rcx
       jne       short M00_L11
       mov       [rbp-50],rax
       mov       rdi,offset MT_System.Threading.Tasks.Task+ContingentProperties
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,rax
       mov       [rbp-58],rcx
       mov       dword ptr [rcx+3C],1
       lea       rdi,[r12+28]
       mov       rsi,rcx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-58]
       mov       rax,[rbp-50]
M00_L11:
       lea       rdi,[rcx+8]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L06
M00_L12:
       test      cl,4
       je        near ptr M00_L15
       mov       rdi,7F12F82A0D68
       mov       rdx,7F12F8C72820
       call      rdx
       cmp       dword ptr [rax],8
       jle       near ptr M00_L36
       mov       rdi,[rax+8]
       mov       rax,[rdi+40]
       test      rax,rax
       je        near ptr M00_L36
M00_L13:
       mov       rax,[rax+10]
       mov       [rbp-60],rax
       test      rax,rax
       je        short M00_L15
       mov       rax,[rbp-60]
       mov       rcx,[rbp-38]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M00_L14
       mov       rdi,offset MT_System.Threading.Tasks.Task+ContingentProperties
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       [rbp-68],rdx
       mov       dword ptr [rdx+3C],1
       mov       rax,[rbp-38]
       lea       rdi,[rax+28]
       mov       rsi,rdx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-68]
       mov       rax,[rbp-60]
M00_L14:
       lea       rdi,[rdx+30]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L15:
       xor       edi,edi
       mov       rax,[rbp-38]
       mov       [rax+8],rdi
       mov       [rax+10],rdi
       mov       [rax+18],rdi
       mov       ecx,[rbp-2C]
       test      ecx,0FFFFFFA0
       jne       near ptr M00_L07
       mov       edi,ecx
       or        edi,400
       or        edi,2000000
       mov       [rax+34],edi
       mov       rdi,[rax+28]
       test      rdi,rdi
       jne       near ptr M00_L37
M00_L16:
       mov       rax,[rbp-38]
       mov       byte ptr [rax+3D],1
       mov       rdi,7F02B8C013A8
       mov       rdi,[rdi]
       cmp       byte ptr [rdi+9D],0
       jne       near ptr M00_L38
M00_L17:
       cmp       byte ptr [7F1278C2B06C],0
       jne       near ptr M00_L39
M00_L18:
       test      dword ptr [r12+34],1600000
       jne       near ptr M00_L40
       test      dword ptr [r12+34],1600000
       jne       short M00_L20
       cmp       qword ptr [r12+20],0
       jne       near ptr M00_L42
       lea       rdi,[r12+20]
       test      rdi,rdi
       je        near ptr M00_L55
       mov       rsi,rax
       xor       edx,edx
       call      00007F12F8074060
       test      rax,rax
       jne       near ptr M00_L41
M00_L19:
       movsxd    rsi,r14d
       mov       rdi,r13
       mov       rdx,[rbp-38]
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       r14d
       jmp       near ptr M00_L00
M00_L20:
       call      00007F12F80F8300
       test      eax,eax
       je        near ptr M00_L47
       mov       rax,[rbp-38]
       movzx     ecx,byte ptr [rax+3C]
       test      ecx,ecx
       jne       near ptr M00_L43
       mov       byte ptr [rax+3C],1
       mov       rdi,r12
       call      qword ptr [7F127A777DB0]; System.Threading.Tasks.Task.get_Status()
       cmp       eax,5
       jne       near ptr M00_L45
       mov       edi,[r12+34]
       and       edi,11000000
       cmp       edi,1000000
       jne       near ptr M00_L46
       mov       rsi,[r12+38]
M00_L21:
       mov       rdi,[rbp-38]
       call      qword ptr [7F127A777DE0]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].ProcessInnerTask(System.Threading.Tasks.Task)
       jmp       short M00_L19
M00_L22:
       mov       rsi,r13
       test      rsi,rsi
       je        near ptr M00_L48
       lea       rbx,[rsi+10]
       mov       r15d,[rsi+8]
       test      r15d,r15d
       je        near ptr M00_L49
       mov       esi,r15d
       mov       rdi,offset MT_System.Threading.Tasks.Task<System.Int32>[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       lea       rdi,[r14+10]
       mov       edx,r15d
       shl       rdx,3
       cmp       rdx,4000
       jbe       short M00_L23
       mov       rsi,rbx
       call      qword ptr [7F127A77FA20]
       jmp       short M00_L24
M00_L23:
       mov       rsi,rbx
       call      00007F12F8070D90
       cmp       dword ptr [7F12F82CEC80],0
       jne       near ptr M00_L50
M00_L24:
       mov       ebx,[r14+8]
       test      ebx,ebx
       jle       short M00_L26
       lea       rdi,[r14+10]
       mov       esi,ebx
M00_L25:
       cmp       qword ptr [rdi],0
       je        near ptr M00_L51
       add       rdi,8
       dec       esi
       jne       short M00_L25
M00_L26:
       mov       rdi,offset MT_System.Threading.Tasks.Task+WhenAllPromise<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       dword ptr [r15+34],2000400
       lea       rdi,[r15+40]
       mov       rsi,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r15+48],ebx
       mov       rdi,7F02B8C013A8
       mov       rdi,[rdi]
       cmp       byte ptr [rdi+9D],0
       jne       near ptr M00_L52
M00_L27:
       cmp       byte ptr [7F1278C2B06C],0
       jne       near ptr M00_L53
M00_L28:
       test      ebx,ebx
       jle       short M00_L33
       add       r14,10
       jmp       short M00_L31
M00_L29:
       test      dword ptr [r13+34],1600000
       jne       short M00_L32
       cmp       qword ptr [r13+20],0
       jne       near ptr M00_L54
       lea       rdi,[r13+20]
       test      rdi,rdi
       je        near ptr M00_L55
       mov       rsi,r15
       xor       edx,edx
       call      00007F12F8074060
       test      rax,rax
       jne       near ptr M00_L54
M00_L30:
       add       r14,8
       dec       ebx
       je        short M00_L33
M00_L31:
       mov       r13,[r14]
       test      dword ptr [r13+34],1600000
       je        short M00_L29
M00_L32:
       mov       rdi,r15
       mov       rsi,r13
       call      qword ptr [7F127A7B91E0]; System.Threading.Tasks.Task+WhenAllPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
       jmp       short M00_L30
M00_L33:
       mov       rax,r15
       add       rsp,48
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L34:
       mov       rdi,offset MT_System.Threading.Tasks.TaskFactory<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,7F02B8C01378
       xor       edx,edx
       call      00007F12F8074060
       test      rax,rax
       jne       near ptr M00_L02
       mov       rax,7F02B8C01378
       mov       rax,[rax]
       jmp       near ptr M00_L02
M00_L35:
       mov       edi,4
       call      qword ptr [7F127A77EFA0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L03
M00_L36:
       mov       edi,8
       call      qword ptr [7F127A77EFA0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L13
M00_L37:
       mov       rdi,[rdi+30]
       test      rdi,rdi
       je        near ptr M00_L16
       test      cl,4
       je        near ptr M00_L16
       test      byte ptr [rdi+34],8
       jne       near ptr M00_L16
       call      qword ptr [7F127A77EB38]
       jmp       near ptr M00_L16
M00_L38:
       mov       rdi,rax
       call      qword ptr [7F127A7773D8]
       mov       esi,eax
       mov       rdi,7F02B8C013A8
       mov       rdi,[rdi]
       mov       rdx,7F1270C0AB20
       xor       ecx,ecx
       call      qword ptr [7F127A7773F0]
       mov       rax,[rbp-38]
       jmp       near ptr M00_L17
M00_L39:
       mov       rdi,rax
       call      qword ptr [7F127A777408]
       mov       rax,[rbp-38]
       jmp       near ptr M00_L18
M00_L40:
       mov       rdi,rax
       mov       rsi,r12
       call      qword ptr [7F127A777438]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].ProcessCompletedOuterTask(System.Threading.Tasks.Task)
       jmp       near ptr M00_L19
M00_L41:
       mov       rax,[rbp-38]
M00_L42:
       mov       rdi,r12
       mov       rsi,rax
       xor       edx,edx
       call      qword ptr [7F127A777E28]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M00_L19
       jmp       near ptr M00_L20
M00_L43:
       cmp       ecx,1
       jne       short M00_L44
       mov       rdi,rax
       mov       rsi,r12
       xor       edx,edx
       call      qword ptr [7F127A777D98]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       mov       r12,[rbp-38]
       mov       byte ptr [r12+3C],2
       jmp       near ptr M00_L19
M00_L44:
       jmp       near ptr M00_L19
M00_L45:
       add       eax,0FFFFFFFA
       cmp       eax,1
       ja        near ptr M00_L19
       mov       rax,[rbp-38]
       movzx     edx,byte ptr [rax+3D]
       mov       rdi,rax
       mov       rsi,r12
       call      qword ptr [7F127A777D98]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       jmp       near ptr M00_L19
M00_L46:
       mov       rdi,r12
       mov       esi,1
       call      qword ptr [7F127A77F5D0]
       mov       rsi,rax
       jmp       near ptr M00_L21
M00_L47:
       mov       rdi,[rbp-38]
       mov       rsi,r12
       call      qword ptr [7F127A777D80]
       jmp       near ptr M00_L19
M00_L48:
       mov       edi,33
       call      qword ptr [7F1279C1FAE0]
       int       3
M00_L49:
       mov       rdi,offset MT_System.Threading.Tasks.Task<System.Int32[]>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdi,r15
       xor       esi,esi
       mov       rdx,7F1270C0A258
       xor       ecx,ecx
       xor       r8d,r8d
       call      qword ptr [7F127A7778E8]
       jmp       near ptr M00_L33
M00_L50:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L24
M00_L51:
       mov       edi,1D
       mov       esi,33
       call      qword ptr [7F127A777918]
       int       3
M00_L52:
       mov       rdi,r15
       call      qword ptr [7F127A7773D8]
       mov       esi,eax
       mov       rdi,7F02B8C013A8
       mov       rdi,[rdi]
       mov       rdx,7F1270C0AF98
       xor       ecx,ecx
       call      qword ptr [7F127A7773F0]
       jmp       near ptr M00_L27
M00_L53:
       mov       rdi,r15
       call      qword ptr [7F127A777408]
       jmp       near ptr M00_L28
M00_L54:
       mov       rdi,r13
       mov       rsi,r15
       xor       edx,edx
       call      qword ptr [7F127A777E28]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M00_L30
       jmp       near ptr M00_L32
M00_L55:
       call      qword ptr [7F127A77EBF8]
       int       3
; Total bytes of code 2115
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       mov       esi,[rdi+34]
       and       esi,11000000
       cmp       esi,1000000
       jne       short M01_L00
       ret
M01_L00:
       xor       esi,esi
       jmp       qword ptr [7F127A777A08]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
; Total bytes of code 26
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
       je        near ptr M02_L17
       mov       r15,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task<System.Int32>>
       mov       rdi,r15
       call      qword ptr [7F127A776868]; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].get_Factory()
       cmp       [rax],al
       mov       rdi,7F02B8C01388
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
       mov       rdi,7F12F82A0D68
       mov       rax,7F12F8C72820
       call      rax
       cmp       dword ptr [rax],4
       jle       near ptr M02_L16
       mov       rdi,[rax+8]
       mov       rax,[rdi+20]
       test      rax,rax
       je        near ptr M02_L16
M02_L00:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M02_L01
       call      qword ptr [7F127A46C030]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       rbx,[rax+8]
       test      rbx,rbx
       je        short M02_L02
       xor       edi,edi
       cmp       byte ptr [rbx+18],0
       cmovne    rbx,rdi
       jmp       short M02_L03
M02_L02:
       mov       rdi,7F02B8C01398
       mov       rbx,[rdi]
M02_L03:
       test      rbx,rbx
       je        short M02_L05
       mov       rdi,7F02B8C01398
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
       call      qword ptr [7F127A776A60]; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
       mov       rdi,offset MT_System.Threading.Tasks.UnwrapPromise<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       movzx     r14d,word ptr [r15+34]
       and       r14d,4
       test      r14d,0FFFFFFBB
       jne       near ptr M02_L15
       test      r14b,4
       je        short M02_L09
       mov       rdi,7F12F82A0D68
       mov       rax,7F12F8C72820
       call      rax
       cmp       dword ptr [rax],8
       jle       near ptr M02_L18
       mov       rdi,[rax+8]
       mov       rax,[rdi+40]
       test      rax,rax
       je        near ptr M02_L18
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
       jne       near ptr M02_L15
       mov       edi,r14d
       or        edi,400
       or        edi,2000000
       mov       [rbx+34],edi
       mov       rdi,[rbx+28]
       test      rdi,rdi
       jne       near ptr M02_L19
M02_L10:
       mov       byte ptr [rbx+3D],1
       mov       rdi,7F02B8C013A8
       mov       rdi,[rdi]
       cmp       byte ptr [rdi+9D],0
       jne       near ptr M02_L20
M02_L11:
       cmp       byte ptr [7F1278C2B06C],0
       jne       near ptr M02_L21
M02_L12:
       test      dword ptr [r15+34],1600000
       jne       near ptr M02_L22
       test      dword ptr [r15+34],1600000
       jne       short M02_L14
       cmp       qword ptr [r15+20],0
       jne       near ptr M02_L24
       lea       rdi,[r15+20]
       test      rdi,rdi
       je        near ptr M02_L23
       mov       rsi,rbx
       xor       edx,edx
       call      00007F12F8074060
       test      rax,rax
       jne       near ptr M02_L24
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
       mov       rdi,rbx
       mov       rsi,r15
       call      qword ptr [7F127A7AC028]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
       jmp       short M02_L13
M02_L15:
       mov       edi,2D
       call      qword ptr [7F1279C1F0D8]
       int       3
M02_L16:
       mov       edi,4
       call      qword ptr [7F127A77EFA0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M02_L00
M02_L17:
       mov       edi,2E
       call      qword ptr [7F1279C1FAE0]
       int       3
M02_L18:
       mov       edi,8
       call      qword ptr [7F127A77EFA0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M02_L07
M02_L19:
       mov       rdi,[rdi+30]
       test      rdi,rdi
       je        near ptr M02_L10
       test      r14b,4
       je        near ptr M02_L10
       test      byte ptr [rdi+34],8
       jne       near ptr M02_L10
       call      qword ptr [7F127A77EB38]
       jmp       near ptr M02_L10
M02_L20:
       mov       rdi,rbx
       call      qword ptr [7F127A7773D8]
       mov       esi,eax
       mov       rdi,7F02B8C013A8
       mov       rdi,[rdi]
       mov       rdx,7F1270C0AB20
       xor       ecx,ecx
       call      qword ptr [7F127A7773F0]
       jmp       near ptr M02_L11
M02_L21:
       mov       rdi,rbx
       call      qword ptr [7F127A777408]
       jmp       near ptr M02_L12
M02_L22:
       mov       rdi,rbx
       mov       rsi,r15
       call      qword ptr [7F127A777438]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].ProcessCompletedOuterTask(System.Threading.Tasks.Task)
       jmp       near ptr M02_L13
M02_L23:
       call      qword ptr [7F127A77EBF8]
       int       3
M02_L24:
       mov       rdi,r15
       mov       rsi,rbx
       xor       edx,edx
       call      qword ptr [7F127A777E28]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M02_L13
       jmp       near ptr M02_L14
; Total bytes of code 891
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
       call      qword ptr [7F12797BEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdi,[rbp-90]
       call      qword ptr [rax]
       lea       rdi,[rbp-88]
       call      qword ptr [7F12797BEF08]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-30]
       call      qword ptr [7F12797C0B98]
       lea       rdi,[rax+10]
       mov       rsi,[rbp-30]
       call      qword ptr [7F12797BEEB8]; CORINFO_HELP_ASSIGN_REF
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
; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
       push      rbp
       push      r15
       push      r14
       push      rbx
       push      rax
       lea       rbp,[rsp+20]
       mov       [rbp-20],rdi
       test      sil,sil
       jne       near ptr M04_L19
       or        dword ptr [rdi+34],10000
M04_L00:
       cmp       byte ptr [7F1278C2B06C],0
       jne       near ptr M04_L20
M04_L01:
       mov       rax,7F02B8C013A8
       mov       rbx,[rax]
       cmp       byte ptr [rbx+9D],0
       jne       near ptr M04_L21
M04_L02:
       mov       r15,[rdi+18]
       cmp       [r15],r15b
       cmp       byte ptr [rbx+9D],0
       jne       near ptr M04_L11
M04_L03:
       mov       rsi,offset MT_System.Threading.Tasks.ThreadPoolTaskScheduler
       cmp       [r15],rsi
       jne       near ptr M04_L17
       movzx     r15d,word ptr [rdi+34]
       test      r15b,2
       jne       near ptr M04_L12
       mov       rsi,7F02B8C013B0
       mov       rbx,[rsi]
       cmp       byte ptr [rbx+38],0
       jne       near ptr M04_L13
M04_L04:
       test      r15b,1
       jne       short M04_L06
       mov       rdi,7F12F82A0D68
       mov       rax,7F12F8C72820
       call      rax
       cmp       dword ptr [rax],5
       jle       near ptr M04_L14
       mov       rdi,[rax+8]
       mov       rax,[rdi+28]
       test      rax,rax
       je        near ptr M04_L14
M04_L05:
       mov       rdi,[rax+10]
       test      rdi,rdi
       jne       short M04_L08
M04_L06:
       mov       rsi,[rbx+8]
       mov       rcx,[rsi+10]
       mov       rdx,[rcx+8]
M04_L07:
       mov       r15d,[rcx+0A0]
       mov       eax,r15d
       and       eax,[rcx+18]
       cmp       eax,[rdx+8]
       jae       near ptr M04_L15
       shl       rax,4
       lea       r14,[rdx+rax+10]
       mov       eax,[r14+8]
       sub       eax,r15d
       jne       short M04_L09
       lea       r8,[rcx+0A0]
       lea       r9d,[r15+1]
       mov       eax,r15d
       lock cmpxchg [r8],r9d
       cmp       eax,r15d
       jne       short M04_L07
       mov       rsi,[rbp-20]
       mov       rdi,r14
       call      CORINFO_HELP_ASSIGN_REF
       inc       r15d
       mov       [r14+8],r15d
       jmp       short M04_L10
M04_L08:
       mov       rdi,[rdi+18]
       mov       rsi,[rbp-20]
       cmp       [rdi],edi
       call      qword ptr [7F127A7779F0]; System.Threading.ThreadPoolWorkQueue+WorkStealingQueue.LocalPush(System.Object)
       jmp       short M04_L10
M04_L09:
       test      eax,eax
       jge       short M04_L07
       mov       rdi,rsi
       mov       rsi,[rbp-20]
       call      qword ptr [7F127A77F090]
M04_L10:
       add       rbx,78
       mov       edi,1
       xchg      edi,[rbx]
       test      edi,edi
       jne       near ptr M04_L18
       mov       rdi,7F02B8C013D8
       mov       rbx,[rdi]
       lea       rdi,[rbx+160]
       lock inc  dword ptr [rdi]
       mov       rdi,rbx
       call      qword ptr [7F127A776E38]; System.Threading.PortableThreadPool+WorkerThread.MaybeAddWorkingWorker(System.Threading.PortableThreadPool)
       cmp       dword ptr [rbx+164],6
       je        near ptr M04_L18
       jmp       near ptr M04_L16
M04_L11:
       mov       rsi,r15
       call      qword ptr [7F127A77F348]
       mov       rdi,[rbp-20]
       jmp       near ptr M04_L03
M04_L12:
       mov       rdi,offset MT_System.Threading.Tasks.ThreadPoolTaskScheduler
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdi,7F02B8C01460
       mov       rbx,[rdi]
       mov       rdi,offset MT_System.Threading.Thread
       call      CORINFO_HELP_NEWFAST
       mov       r15,rax
       mov       rdi,r15
       mov       rsi,rbx
       call      qword ptr [7F127A77FF18]
       mov       rdi,r15
       mov       esi,1
       call      qword ptr [7F127A777018]; System.Threading.Thread.set_IsBackground(Boolean)
       mov       rdi,r15
       mov       rsi,7F1270C0A040
       call      qword ptr [7F127A777120]; System.Threading.Thread.set_Name(System.String)
       mov       rdi,r15
       mov       rsi,[rbp-20]
       xor       edx,edx
       call      qword ptr [7F127A77FF30]
       jmp       short M04_L18
M04_L13:
       mov       rsi,7F02B8C013C8
       mov       rsi,[rsi]
       cmp       byte ptr [rsi+9D],0
       je        near ptr M04_L04
       mov       rsi,7F02B8C013C8
       mov       rdi,[rsi]
       mov       rsi,[rbp-20]
       call      qword ptr [7F127A77F078]
       jmp       near ptr M04_L04
M04_L14:
       mov       edi,5
       call      qword ptr [7F127A77EFA0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M04_L05
M04_L15:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M04_L16:
       mov       rdi,rbx
       call      qword ptr [7F127A777090]; System.Threading.PortableThreadPool+GateThread.EnsureRunningSlow(System.Threading.PortableThreadPool)
       jmp       short M04_L18
M04_L17:
       mov       rdi,r15
       mov       rsi,[rbp-20]
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       nop
M04_L18:
       add       rsp,8
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       ret
M04_L19:
       call      qword ptr [7F127A77FF60]
       test      eax,eax
       mov       rdi,[rbp-20]
       jne       near ptr M04_L00
       jmp       short M04_L18
M04_L20:
       call      qword ptr [7F127A777408]
       mov       rdi,[rbp-20]
       jmp       near ptr M04_L01
M04_L21:
       test      word ptr [rdi+34],200
       jne       near ptr M04_L02
       call      qword ptr [7F127A7773D8]
       mov       r15d,eax
       mov       rdi,[rbp-20]
       mov       rdi,[rdi+8]
       call      qword ptr [7F127A77F2B8]
       mov       rsi,rax
       mov       rdi,7F1270C09FB8
       call      qword ptr [7F1279C1EFA0]; System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       esi,r15d
       mov       rdi,rbx
       xor       ecx,ecx
       call      qword ptr [7F127A7773F0]
       mov       rdi,[rbp-20]
       jmp       near ptr M04_L02
       push      rax
       mov       rbx,rdi
       mov       rdi,offset MT_System.Threading.Tasks.TaskSchedulerException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdi,r15
       mov       rsi,rbx
       call      qword ptr [7F127A77F2D0]
       mov       rdi,[rbp-20]
       mov       rsi,r15
       call      qword ptr [7F127A77F2E8]
       mov       rdi,[rbp-20]
       xor       esi,esi
       call      qword ptr [7F127A77F300]
       mov       rdi,[rbp-20]
       call      qword ptr [7F127A77F318]
       test      eax,200
       jne       short M04_L22
       mov       rdi,[rbp-20]
       mov       rdi,[rdi+28]
       mov       rdi,[rdi+18]
       xor       esi,esi
       cmp       [rdi],edi
       call      qword ptr [7F127A77F330]
M04_L22:
       mov       rdi,r15
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 876
```
```assembly
; AsyncLazyBenchmarks.ContendedFirstCallBenchmarks+<>c__DisplayClass10_0.<Nito>b__0()
       push      rbp
       push      rbx
       sub       rsp,18
       lea       rbp,[rsp+20]
       mov       rbx,[rdi+8]
       mov       rdi,[rbx+8]
       mov       [rbp-18],rdi
       xor       eax,eax
       mov       [rbp-0C],eax
       test      rdi,rdi
       je        short M05_L02
       call      00007F12F7EE6020
       test      eax,eax
       je        short M05_L03
M05_L00:
       mov       dword ptr [rbp-0C],1
       mov       rdi,[rbx+18]
       cmp       qword ptr [rdi+8],0
       jne       short M05_L01
       mov       rbx,[rdi+18]
       jmp       short M05_L04
M05_L01:
       call      qword ptr [7F127A46C420]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rbx,rax
       jmp       short M05_L04
M05_L02:
       xor       edi,edi
       call      qword ptr [7F127A77EE98]
       int       3
M05_L03:
       mov       rdi,[rbp-18]
       call      qword ptr [7F127A7779D8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M05_L00
M05_L04:
       mov       rdi,[rbp-18]
       call      00007F12F7EE6790
       test      eax,eax
       jne       short M05_L06
M05_L05:
       mov       rax,rbx
       add       rsp,18
       pop       rbx
       pop       rbp
       ret
M05_L06:
       mov       edi,eax
       mov       rsi,[rbp-18]
       call      qword ptr [7F127A777A20]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       short M05_L05
       push      rax
       cmp       dword ptr [rbp-0C],0
       je        short M05_L08
       cmp       qword ptr [rbp-18],0
       jne       short M05_L07
       xor       edi,edi
       call      qword ptr [7F127A77EE98]
       int       3
M05_L07:
       mov       rdi,[rbp-18]
       call      00007F12F7EE6790
       test      eax,eax
       je        short M05_L08
       mov       edi,eax
       mov       rsi,[rbp-18]
       call      qword ptr [7F127A777A20]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M05_L08:
       nop
       add       rsp,8
       ret
; Total bytes of code 189
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       push      rbp
       mov       rbp,rsp
       mov       eax,[rdi+8]
       cmp       rax,rsi
       jbe       short M06_L02
       lea       rax,[rdi+rsi*8+10]
       mov       rdi,[rdi]
       mov       rsi,[rdi+30]
       test      rdx,rdx
       je        short M06_L01
       cmp       rsi,[rdx]
       je        short M06_L00
       mov       rcx,offset MT_System.Object[]
       cmp       rdi,rcx
       je        short M06_L00
       mov       rdi,rax
       pop       rbp
       jmp       qword ptr [7F127A467A68]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
M06_L00:
       mov       rdi,rax
       mov       rsi,rdx
       pop       rbp
       jmp       near ptr 00007F12F81FB900
M06_L01:
       xor       ecx,ecx
       mov       [rax],rcx
       pop       rbp
       ret
M06_L02:
       call      qword ptr [7F127A77EB20]
       int       3
; Total bytes of code 85
```
```assembly
; System.Threading.Tasks.Task.get_Status()
       push      rbp
       mov       rbp,rsp
       mov       eax,[rdi+34]
       test      eax,200000
       jne       short M07_L01
       test      eax,400000
       jne       short M07_L02
       test      eax,1000000
       je        short M07_L03
       mov       eax,5
M07_L00:
       pop       rbp
       ret
M07_L01:
       mov       eax,7
       jmp       short M07_L00
M07_L02:
       mov       eax,6
       jmp       short M07_L00
M07_L03:
       test      eax,800000
       je        short M07_L04
       mov       eax,4
       jmp       short M07_L00
M07_L04:
       test      eax,20000
       je        short M07_L05
       mov       eax,3
       jmp       short M07_L00
M07_L05:
       test      eax,2000000
       setne     cl
       movzx     ecx,cl
       mov       edx,2
       test      eax,10000
       mov       eax,edx
       cmove     eax,ecx
       jmp       short M07_L00
; Total bytes of code 105
```
```assembly
; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].ProcessInnerTask(System.Threading.Tasks.Task)
       push      rbp
       push      r15
       push      rbx
       lea       rbp,[rsp+10]
       mov       r15,rdi
       mov       rbx,rsi
       test      rbx,rbx
       je        short M08_L04
       test      dword ptr [rbx+34],1600000
       je        short M08_L02
       mov       rdi,r15
       mov       rsi,rbx
       xor       edx,edx
       call      qword ptr [7F127A777D98]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
M08_L00:
       mov       byte ptr [r15+3C],2
M08_L01:
       pop       rbx
       pop       r15
       pop       rbp
       ret
M08_L02:
       test      dword ptr [rbx+34],1600000
       jne       short M08_L03
       cmp       qword ptr [rbx+20],0
       jne       short M08_L06
       lea       rdi,[rbx+20]
       test      rdi,rdi
       je        short M08_L05
       mov       rsi,r15
       xor       edx,edx
       call      00007F12F8074060
       test      rax,rax
       je        short M08_L01
       jmp       short M08_L06
M08_L03:
       mov       rdi,r15
       mov       rsi,rbx
       cmp       [rdi],edi
       pop       rbx
       pop       r15
       pop       rbp
       jmp       qword ptr [7F127A7AC028]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
M08_L04:
       mov       rdi,r15
       xor       esi,esi
       xor       edx,edx
       call      qword ptr [7F127A77C150]
       jmp       short M08_L00
M08_L05:
       call      qword ptr [7F127A77EBF8]
       int       3
M08_L06:
       mov       rdi,rbx
       mov       rsi,r15
       xor       edx,edx
       call      qword ptr [7F127A777E28]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       short M08_L01
       jmp       short M08_L03
; Total bytes of code 155
```
```assembly
; System.Threading.Tasks.Task+WhenAllPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+50]
       mov       rbx,rdi
       mov       rdi,7F02B8C013A8
       mov       r15,[rdi]
       cmp       byte ptr [r15+9D],0
       jne       near ptr M09_L14
M09_L00:
       lea       rsi,[rbx+48]
       mov       edi,0FFFFFFFF
       lock xadd [rsi],edi
       dec       edi
       je        short M09_L02
M09_L01:
       add       rsp,28
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M09_L02:
       mov       rsi,[rbx+40]
       mov       esi,[rsi+8]
       mov       rdi,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       xor       r13d,r13d
       xor       r12d,r12d
       xor       eax,eax
M09_L03:
       mov       rdi,[rbx+40]
       cmp       [rdi+8],eax
       jle       near ptr M09_L11
       cmp       eax,[rdi+8]
       jae       near ptr M09_L24
       mov       [rbp-2C],eax
       mov       ecx,eax
       mov       [rbp-38],rcx
       mov       r8,[rdi+rcx*8+10]
       mov       [rbp-40],r8
       test      dword ptr [r8+34],200000
       jne       near ptr M09_L08
       mov       edi,[r8+34]
       and       edi,600000
       cmp       edi,400000
       je        near ptr M09_L16
       test      dword ptr [r8+34],1600000
       je        near ptr M09_L17
M09_L04:
       mov       edi,[r8+34]
       and       edi,1600000
       cmp       edi,1000000
       jne       near ptr M09_L18
M09_L05:
       mov       edi,[r8+38]
       mov       eax,[rbp-2C]
       cmp       eax,[r14+8]
       jae       near ptr M09_L24
       mov       rcx,[rbp-38]
       mov       [r14+rcx*4+10],edi
M09_L06:
       test      dword ptr [r8+34],10000000
       jne       near ptr M09_L19
       mov       rdi,[rbx+40]
       mov       eax,[rbp-2C]
       cmp       eax,[rdi+8]
       jae       near ptr M09_L24
       xor       esi,esi
       mov       rcx,[rbp-38]
       mov       [rdi+rcx*8+10],rsi
M09_L07:
       mov       eax,[rbp-2C]
       inc       eax
       jmp       near ptr M09_L03
M09_L08:
       test      r13,r13
       je        near ptr M09_L15
M09_L09:
       mov       rdi,[r8+28]
       mov       rdx,[rdi+18]
       mov       [rbp-48],rdx
       mov       rsi,[rdx+10]
       mov       [rbp-50],rsi
       cmp       byte ptr [rdx+20],0
       jne       short M09_L10
       mov       rdi,rdx
       call      qword ptr [7F127A466868]; System.GC.SuppressFinalize(System.Object)
       mov       rdi,[rbp-48]
       mov       byte ptr [rdi+20],1
M09_L10:
       mov       rdi,r13
       mov       rsi,[rbp-50]
       cmp       [rdi],edi
       call      qword ptr [7F127A77C2D0]
       mov       r8,[rbp-40]
       jmp       short M09_L06
M09_L11:
       test      r13,r13
       jne       near ptr M09_L20
       test      r12,r12
       jne       near ptr M09_L21
       cmp       byte ptr [r15+9D],0
       jne       near ptr M09_L22
M09_L12:
       cmp       byte ptr [7F1278C2B06C],0
       jne       near ptr M09_L23
M09_L13:
       mov       rdi,rbx
       mov       rsi,r14
       call      qword ptr [7F127A77C348]; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].TrySetResult(System.__Canon)
       jmp       near ptr M09_L01
M09_L14:
       mov       rdi,rbx
       call      qword ptr [7F127A7773D8]
       mov       esi,eax
       mov       rdi,r15
       mov       edx,1
       call      qword ptr [7F127A77C108]
       jmp       near ptr M09_L00
M09_L15:
       mov       rdi,offset MT_System.Collections.Generic.List<System.Runtime.ExceptionServices.ExceptionDispatchInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdi,r13
       call      qword ptr [7F127A46F0A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       r8,[rbp-40]
       jmp       near ptr M09_L09
M09_L16:
       test      r12,r12
       jne       near ptr M09_L06
       mov       r12,r8
       mov       r8,[rbp-40]
       jmp       near ptr M09_L06
M09_L17:
       mov       rdi,r8
       mov       esi,0FFFFFFFF
       xor       edx,edx
       call      qword ptr [7F127A777A38]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
       mov       r8,[rbp-40]
       jmp       near ptr M09_L04
M09_L18:
       mov       rdi,r8
       mov       esi,1
       call      qword ptr [7F127A834018]
       mov       r8,[rbp-40]
       jmp       near ptr M09_L05
M09_L19:
       mov       rdi,rbx
       mov       esi,1
       call      qword ptr [7F127A77C330]
       jmp       near ptr M09_L07
M09_L20:
       mov       rdi,rbx
       mov       rsi,r13
       call      qword ptr [7F127A77C1E0]
       jmp       near ptr M09_L01
M09_L21:
       mov       rdi,r12
       call      qword ptr [7F127A77C120]
       mov       r13,rax
       mov       rdi,r12
       call      qword ptr [7F127A77C138]
       mov       rdx,rax
       mov       rsi,r13
       mov       rdi,rbx
       call      qword ptr [7F127A77C150]
       jmp       near ptr M09_L01
M09_L22:
       mov       rdi,rbx
       call      qword ptr [7F127A7773D8]
       mov       esi,eax
       mov       rdi,r15
       mov       edx,1
       call      qword ptr [7F127A77C1F8]
       jmp       near ptr M09_L12
M09_L23:
       mov       rdi,rbx
       call      qword ptr [7F127A77C210]
       jmp       near ptr M09_L13
M09_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 700
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbp
       push      rbx
       push      rax
       lea       rbp,[rsp+10]
       mov       ebx,edi
       call      qword ptr [7F12797D6AF0]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       edi,ebx
       and       edi,0FFFFFF
       mov       ecx,edi
       mov       edx,ebx
       sar       edx,18
       jne       short M10_L01
       cmp       [rax],edi
       jle       short M10_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       ecx,0FFFFFFFE
       movsxd    rdi,ecx
       mov       rax,[rax+rdi*8+10]
       test      rax,rax
       je        short M10_L03
M10_L00:
       add       rsp,8
       pop       rbx
       pop       rbp
       ret
M10_L01:
       mov       edi,ebx
       sar       edi,18
       cmp       edi,2
       jne       short M10_L02
       movsxd    rcx,ecx
       add       rax,rcx
       jmp       short M10_L00
M10_L02:
       cmp       [rax+4],ecx
       jle       short M10_L03
       mov       rdi,[rax+10]
       movsxd    rax,ecx
       mov       rdi,[rdi+rax*8]
       test      rdi,rdi
       je        short M10_L03
       mov       rax,[rdi]
       test      rax,rax
       je        short M10_L03
       jmp       short M10_L00
M10_L03:
       mov       edi,ebx
       lea       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       add       rsp,8
       pop       rbx
       pop       rbp
       jmp       qword ptr [rax]
; Total bytes of code 133
```
```assembly
; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].ProcessCompletedOuterTask(System.Threading.Tasks.Task)
       push      rbp
       push      r15
       push      r14
       push      rbx
       push      rax
       lea       rbp,[rsp+20]
       mov       rbx,rdi
       mov       r15,rsi
       mov       byte ptr [rbx+3C],1
       mov       esi,[r15+34]
       test      esi,200000
       jne       near ptr M11_L07
       test      esi,400000
       jne       near ptr M11_L08
       test      esi,1000000
       je        near ptr M11_L09
       mov       r14d,5
M11_L00:
       cmp       r14d,5
       jne       near ptr M11_L12
       mov       rdi,r15
       mov       rax,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task<System.Int32>>
       cmp       [rdi],rax
       jne       near ptr M11_L13
M11_L01:
       test      rdi,rdi
       je        near ptr M11_L14
       mov       esi,[rdi+34]
       and       esi,11000000
       cmp       esi,1000000
       jne       near ptr M11_L16
       mov       r14,[rdi+38]
M11_L02:
       test      r14,r14
       je        near ptr M11_L17
       test      dword ptr [r14+34],1600000
       je        short M11_L05
       mov       rdi,rbx
       mov       rsi,r14
       xor       edx,edx
       call      qword ptr [7F127A777D98]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
M11_L03:
       mov       byte ptr [rbx+3C],2
M11_L04:
       add       rsp,8
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       ret
M11_L05:
       test      dword ptr [r14+34],1600000
       jne       short M11_L06
       cmp       qword ptr [r14+20],0
       jne       near ptr M11_L19
       lea       rdi,[r14+20]
       test      rdi,rdi
       je        near ptr M11_L18
       mov       rsi,rbx
       xor       edx,edx
       call      00007F12F8074060
       test      rax,rax
       je        short M11_L04
       jmp       near ptr M11_L19
M11_L06:
       mov       rdi,rbx
       mov       rsi,r14
       add       rsp,8
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7F127A7AC028]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
M11_L07:
       mov       r14d,7
       jmp       near ptr M11_L00
M11_L08:
       mov       r14d,6
       jmp       near ptr M11_L00
M11_L09:
       test      esi,800000
       je        short M11_L10
       mov       r14d,4
       jmp       near ptr M11_L00
M11_L10:
       test      esi,20000
       je        short M11_L11
       mov       r14d,3
       jmp       near ptr M11_L00
M11_L11:
       test      esi,2000000
       setne     r14b
       movzx     r14d,r14b
       mov       edi,2
       test      esi,10000
       cmovne    r14d,edi
       jmp       near ptr M11_L00
M11_L12:
       add       r14d,0FFFFFFFA
       cmp       r14d,1
       ja        near ptr M11_L04
       movzx     edx,byte ptr [rbx+3D]
       mov       rdi,rbx
       mov       rsi,r15
       call      qword ptr [7F127A777D98]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       jmp       near ptr M11_L04
M11_L13:
       mov       rsi,r15
       mov       rdi,rax
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M11_L01
M11_L14:
       mov       rdi,r15
       mov       rax,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task>
       cmp       [rdi],rax
       je        short M11_L15
       mov       rsi,r15
       mov       rdi,rax
       call      qword ptr [7F127A044AF8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rdi,rax
M11_L15:
       cmp       [rdi],edi
       call      qword ptr [7F127A777DC8]; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].get_Result()
       mov       r14,rax
       jmp       near ptr M11_L02
M11_L16:
       mov       esi,1
       call      qword ptr [7F127A77F5D0]
       mov       r14,rax
       jmp       near ptr M11_L02
M11_L17:
       mov       rdi,rbx
       xor       esi,esi
       xor       edx,edx
       call      qword ptr [7F127A77C150]
       jmp       near ptr M11_L03
M11_L18:
       call      qword ptr [7F127A77EBF8]
       int       3
M11_L19:
       mov       rdi,r14
       mov       rsi,rbx
       xor       edx,edx
       call      qword ptr [7F127A777E28]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M11_L04
       jmp       near ptr M11_L06
; Total bytes of code 526
```
```assembly
; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rbx
       sub       rsp,18
       lea       rbp,[rsp+40]
       mov       rbx,rdi
       mov       r15,rsi
       mov       r14d,edx
       mov       r13,[rbx+20]
       mov       rsi,7F02B8C00238
       cmp       r13,[rsi]
       je        near ptr M12_L15
       mov       r12,r13
       test      r12,r12
       je        short M12_L00
       mov       rsi,offset MT_System.Threading.Tasks.UnwrapPromise<System.Int32>
       cmp       [r12],rsi
       jne       near ptr M12_L16
       xor       r12d,r12d
M12_L00:
       test      r12,r12
       jne       near ptr M12_L02
       mov       rdi,offset MT_System.Collections.Generic.List<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rdi,7F02B8C00AB8
       mov       rsi,[rdi]
       lea       rdi,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      r14b,r14b
       jne       near ptr M12_L18
       inc       dword ptr [r12+14]
       mov       rdi,r12
       mov       rsi,r13
       call      qword ptr [7F1279C172D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       inc       dword ptr [r12+14]
       mov       rdi,[r12+8]
       mov       esi,[r12+10]
       cmp       [rdi+8],esi
       jbe       near ptr M12_L17
       lea       edx,[rsi+1]
       mov       [r12+10],edx
       mov       esi,esi
       mov       rdx,r15
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M12_L01:
       lea       rdi,[rbx+20]
       test      rdi,rdi
       je        near ptr M12_L20
       mov       rsi,r12
       mov       rdx,r13
       call      00007F12F8074060
       mov       r12,rax
       cmp       r12,r13
       je        near ptr M12_L13
       mov       rsi,r12
       mov       rdi,offset MT_System.Collections.Generic.List<System.Object>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r12,rax
       test      r12,r12
       je        near ptr M12_L15
M12_L02:
       mov       [rbp-38],r12
       xor       edi,edi
       mov       [rbp-2C],edi
       mov       rdi,r12
       call      00007F12F7EE6020
       test      eax,eax
       je        near ptr M12_L09
M12_L03:
       mov       dword ptr [rbp-2C],1
       mov       rdi,[rbx+20]
       mov       rax,7F02B8C00238
       cmp       rdi,[rax]
       je        short M12_L08
       mov       edi,[r12+10]
       mov       rax,[r12+8]
       cmp       edi,[rax+8]
       je        short M12_L05
M12_L04:
       test      r14b,r14b
       jne       near ptr M12_L11
       inc       dword ptr [r12+14]
       mov       rdi,[r12+8]
       mov       esi,[r12+10]
       cmp       [rdi+8],esi
       jbe       short M12_L07
       lea       edx,[rsi+1]
       mov       [r12+10],edx
       mov       esi,esi
       mov       rdx,r15
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M12_L12
M12_L05:
       mov       rdi,7F02B8C00290
       mov       rsi,[rdi]
       test      rsi,rsi
       je        short M12_L10
M12_L06:
       mov       rdi,r12
       cmp       [rdi],edi
       call      qword ptr [7F127A777F18]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAll(System.Predicate`1<System.__Canon>)
       jmp       short M12_L04
M12_L07:
       mov       rdi,r12
       mov       rsi,r15
       call      qword ptr [7F1279C172D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M12_L12
M12_L08:
       xor       edi,edi
       mov       [rbp-30],edi
       jmp       near ptr M12_L14
M12_L09:
       mov       rdi,r12
       call      qword ptr [7F127A7779D8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M12_L03
M12_L10:
       mov       rdi,offset MT_System.Predicate<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rsi,7F02B8C00260
       mov       rsi,[rsi]
       mov       rdi,rbx
       mov       rdx,offset System.Threading.Tasks.Task+<>c.<AddTaskContinuationComplex>b__211_0(System.Object)
       call      qword ptr [7F1279C16E08]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdi,7F02B8C00290
       mov       rsi,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,rbx
       jmp       short M12_L06
M12_L11:
       mov       rdi,r12
       mov       rdx,r15
       xor       esi,esi
       call      qword ptr [7F1279D06A30]
       nop
M12_L12:
       mov       rdi,r12
       call      00007F12F7EE6790
       test      eax,eax
       jne       near ptr M12_L21
M12_L13:
       mov       eax,1
       add       rsp,18
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M12_L14:
       call      M12_L22
       nop
       mov       eax,[rbp-30]
       movzx     eax,al
       add       rsp,18
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M12_L15:
       xor       eax,eax
       add       rsp,18
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M12_L16:
       mov       rsi,r13
       mov       rdi,offset MT_System.Collections.Generic.List<System.Object>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r12,rax
       jmp       near ptr M12_L00
M12_L17:
       mov       rdi,r12
       mov       rsi,r15
       call      qword ptr [7F1279C172D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M12_L01
M12_L18:
       inc       dword ptr [r12+14]
       mov       rdi,r12
       mov       rsi,r15
       call      qword ptr [7F1279C172D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       inc       dword ptr [r12+14]
       mov       rdi,[r12+8]
       mov       esi,[r12+10]
       cmp       [rdi+8],esi
       jbe       short M12_L19
       lea       edx,[rsi+1]
       mov       [r12+10],edx
       mov       esi,esi
       mov       rdx,r13
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M12_L01
M12_L19:
       mov       rdi,r12
       mov       rsi,r13
       call      qword ptr [7F1279C172D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M12_L01
M12_L20:
       call      qword ptr [7F127A77EBF8]
       int       3
M12_L21:
       mov       edi,eax
       mov       rsi,r12
       call      qword ptr [7F127A777A20]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       near ptr M12_L13
M12_L22:
       push      rax
       cmp       dword ptr [rbp-2C],0
       je        short M12_L23
       mov       rdi,[rbp-38]
       call      00007F12F7EE6790
       test      eax,eax
       je        short M12_L23
       mov       edi,eax
       mov       rsi,[rbp-38]
       call      qword ptr [7F127A777A20]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M12_L23:
       nop
       add       rsp,8
       ret
; Total bytes of code 802
```
```assembly
; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rbx
       sub       rsp,10
       lea       rbp,[rsp+30]
       mov       rbx,rdi
       mov       r15,rsi
       mov       r14d,edx
M13_L00:
       mov       rdi,7F02B8C013A8
       mov       r13,[rdi]
       cmp       byte ptr [r13+9D],0
       jne       near ptr M13_L13
M13_L01:
       xor       eax,eax
       mov       edi,[r15+34]
       test      edi,200000
       jne       near ptr M13_L14
       test      edi,400000
       jne       near ptr M13_L15
       test      edi,1000000
       je        near ptr M13_L16
       mov       ecx,5
M13_L02:
       add       ecx,0FFFFFFFB
       jne       near ptr M13_L19
       cmp       byte ptr [r13+9D],0
       jne       near ptr M13_L21
M13_L03:
       cmp       byte ptr [7F1278C2B06C],0
       jne       near ptr M13_L22
M13_L04:
       mov       rdi,r15
       mov       rsi,offset MT_System.Threading.Tasks.UnwrapPromise<System.Int32>
       cmp       [rdi],rsi
       jne       near ptr M13_L12
M13_L05:
       test      rdi,rdi
       je        near ptr M13_L23
       mov       esi,[rdi+34]
       and       esi,11000000
       cmp       esi,1000000
       jne       near ptr M13_L24
       mov       r15d,[rdi+38]
M13_L06:
       xor       r14d,r14d
       mov       eax,[rbx+34]
       mov       [rbp-24],eax
       test      eax,5600000
       jne       short M13_L10
       lea       rdi,[rbx+34]
       mov       esi,eax
       or        esi,4000000
       lock cmpxchg [rdi],esi
       cmp       eax,[rbp-24]
       jne       near ptr M13_L25
M13_L07:
       mov       [rbx+38],r15d
       lea       rdi,[rbx+34]
       mov       eax,[rbx+34]
       or        eax,1000000
       xchg      eax,[rdi]
       mov       r14,[rbx+28]
       test      r14,r14
       jne       near ptr M13_L26
M13_L08:
       lea       rdi,[rbx+20]
       test      rdi,rdi
       je        near ptr M13_L27
       mov       rsi,7F02B8C00238
       mov       rsi,[rsi]
       call      00007F12F8074040
       test      rax,rax
       je        short M13_L09
       mov       rdi,rbx
       mov       rsi,rax
       call      qword ptr [7F127A777B88]; System.Threading.Tasks.Task.RunContinuations(System.Object)
M13_L09:
       mov       r14d,1
M13_L10:
       mov       eax,r14d
M13_L11:
       add       rsp,10
       pop       rbx
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M13_L12:
       mov       rsi,r15
       mov       rdi,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M13_L05
M13_L13:
       mov       rdi,rbx
       call      qword ptr [7F127A7773D8]
       mov       esi,eax
       mov       rdi,r13
       mov       edx,1
       call      qword ptr [7F127A77C108]
       jmp       near ptr M13_L01
M13_L14:
       mov       ecx,7
       jmp       near ptr M13_L02
M13_L15:
       mov       ecx,6
       jmp       near ptr M13_L02
M13_L16:
       test      edi,800000
       je        short M13_L17
       mov       ecx,4
       jmp       near ptr M13_L02
M13_L17:
       test      edi,20000
       je        short M13_L18
       mov       ecx,3
       jmp       near ptr M13_L02
M13_L18:
       test      edi,2000000
       setne     cl
       movzx     ecx,cl
       mov       edx,2
       test      edi,10000
       cmovne    ecx,edx
       jmp       near ptr M13_L02
M13_L19:
       cmp       ecx,2
       ja        near ptr M13_L11
       mov       edi,ecx
       lea       rax,[7F1279C9B338]
       mov       eax,[rax+rdi*4]
       lea       rcx,[M13_L00]
       add       rax,rcx
       jmp       rax
       mov       rdi,r15
       call      qword ptr [7F127A77C120]
       mov       r14,rax
       mov       rdi,r15
       call      qword ptr [7F127A77C138]
       mov       rdx,rax
       mov       rsi,r14
       mov       rdi,rbx
       call      qword ptr [7F127A77C150]
       jmp       near ptr M13_L11
       mov       rdi,r15
       call      qword ptr [7F127A77C168]
       mov       r15,rax
       test      r14b,r14b
       je        short M13_L20
       cmp       dword ptr [r15+10],0
       jle       short M13_L20
       mov       rdi,r15
       xor       esi,esi
       call      qword ptr [7F1279D069B8]
       mov       r13,rax
       test      r13,r13
       je        short M13_L20
       mov       rsi,[r13+8]
       mov       rdi,offset MT_System.OperationCanceledException
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M13_L20
       mov       rsi,[rax+70]
       mov       rdi,rbx
       mov       rdx,r13
       call      qword ptr [7F127A77C150]
       jmp       near ptr M13_L11
M13_L20:
       mov       rdi,rbx
       mov       rsi,r15
       call      qword ptr [7F127A77C1E0]
       jmp       near ptr M13_L11
M13_L21:
       mov       rdi,rbx
       call      qword ptr [7F127A7773D8]
       mov       esi,eax
       mov       rdi,r13
       mov       edx,1
       call      qword ptr [7F127A77C1F8]
       jmp       near ptr M13_L03
M13_L22:
       mov       rdi,rbx
       call      qword ptr [7F127A77C210]
       jmp       near ptr M13_L04
M13_L23:
       xor       r15d,r15d
       jmp       near ptr M13_L06
M13_L24:
       mov       esi,1
       call      qword ptr [7F127A77C300]; System.Threading.Tasks.Task`1[[System.Int32, System.Private.CoreLib]].GetResultCore(Boolean)
       mov       r15d,eax
       jmp       near ptr M13_L06
M13_L25:
       mov       rdi,rbx
       mov       esi,4000000
       mov       edx,5600000
       call      qword ptr [7F127A77F180]
       test      eax,eax
       je        near ptr M13_L10
       jmp       near ptr M13_L07
M13_L26:
       mov       rdi,rbx
       call      qword ptr [7F127A77F198]
       mov       rdi,r14
       call      qword ptr [7F127A77F1B0]
       jmp       near ptr M13_L08
M13_L27:
       call      qword ptr [7F127A77EBF8]
       int       3
; Total bytes of code 789
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
       jne       short M14_L00
       mov       rdi,rbx
       mov       esi,0FFFFFFFF
       xor       edx,edx
       call      qword ptr [7F127A777A38]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M14_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M14_L03
M14_L01:
       mov       edi,[rbx+34]
       and       edi,1600000
       cmp       edi,1000000
       jne       short M14_L04
M14_L02:
       pop       rbx
       pop       r15
       pop       rbp
       ret
M14_L03:
       mov       rdi,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M14_L01
       mov       rdi,rbx
       call      qword ptr [7F127A77FAE0]
       jmp       short M14_L01
M14_L04:
       test      r15b,2
       jne       short M14_L05
       mov       rdi,rbx
       call      qword ptr [7F127A77FAB0]
M14_L05:
       mov       rdi,rbx
       call      qword ptr [7F127A834108]
       jmp       short M14_L02
; Total bytes of code 125
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.ContendedFirstCallBenchmarks.VsThreading()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       rbx,rdi
       mov       rdi,offset MT_AsyncLazyBenchmarks.ContendedFirstCallBenchmarks+<>c__DisplayClass11_0
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdi,offset MT_Microsoft.VisualStudio.Threading.AsyncLazy<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdi,73D354C01358
       mov       r13,[rdi]
       mov       rdi,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rdi,[r14+8]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdi,[r14+20]
       mov       rsi,r13
       call      CORINFO_HELP_ASSIGN_REF
       xor       edi,edi
       mov       [r14+10],rdi
       lea       rdi,[r15+8]
       mov       rsi,r14
       call      CORINFO_HELP_ASSIGN_REF
       xor       r14d,r14d
M00_L00:
       mov       r13,[rbx+8]
       cmp       [r13+8],r14d
       jle       near ptr M00_L22
       mov       r12,[r15+10]
       test      r12,r12
       je        near ptr M00_L08
M00_L01:
       mov       rdi,73D354C01388
       mov       rax,[rdi]
       test      rax,rax
       je        near ptr M00_L33
M00_L02:
       cmp       [rax],al
       mov       rdi,73D354C01398
       mov       rax,[rdi]
       mov       [rbp-40],rax
       mov       rdi,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-48],rax
       lea       rdi,[rax+8]
       mov       rsi,r12
       call      CORINFO_HELP_ASSIGN_REF
       xor       edi,edi
       mov       r12,[rbp-48]
       mov       [r12+10],rdi
       lea       rdi,[r12+18]
       mov       rsi,[rbp-40]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edi,2008
       mov       [r12+34],edi
       mov       rdi,73E394EA0D68
       mov       rax,73E395713820
       call      rax
       cmp       dword ptr [rax],4
       jle       near ptr M00_L34
       mov       rdi,[rax+8]
       mov       rax,[rdi+20]
       test      rax,rax
       je        near ptr M00_L34
M00_L03:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M00_L04
       call      qword ptr [73E31708C030]; System.Threading.Thread.InitializeCurrentThread()
M00_L04:
       mov       rax,[rax+8]
       test      rax,rax
       je        near ptr M00_L09
       cmp       byte ptr [rax+18],0
       jne       near ptr M00_L35
M00_L05:
       test      rax,rax
       jne       near ptr M00_L10
       or        dword ptr [r12+34],20000000
M00_L06:
       mov       rdi,r12
       xor       esi,esi
       call      qword ptr [73E317396A78]; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
       mov       rdi,offset MT_System.Threading.Tasks.UnwrapPromise<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       movzx     ecx,word ptr [r12+34]
       and       ecx,4
       mov       [rbp-2C],ecx
       test      ecx,0FFFFFFBB
       je        near ptr M00_L12
M00_L07:
       mov       edi,2D
       call      qword ptr [73E31683F0D8]
       int       3
M00_L08:
       mov       rdi,offset MT_System.Func<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rdi,[r12+8]
       mov       rsi,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset AsyncLazyBenchmarks.ContendedFirstCallBenchmarks+<>c__DisplayClass11_0.<VsThreading>b__0()
       mov       [r12+18],rdi
       lea       rdi,[r15+10]
       mov       rsi,r12
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L09:
       mov       rax,73D354C013A8
       mov       rax,[rax]
       jmp       near ptr M00_L05
M00_L10:
       mov       rdi,73D354C013A8
       mov       [rbp-50],rax
       cmp       rax,[rdi]
       je        near ptr M00_L06
       mov       rax,[rbp-50]
       mov       rcx,[r12+28]
       test      rcx,rcx
       jne       short M00_L11
       mov       [rbp-50],rax
       mov       rdi,offset MT_System.Threading.Tasks.Task+ContingentProperties
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,rax
       mov       [rbp-58],rcx
       mov       dword ptr [rcx+3C],1
       lea       rdi,[r12+28]
       mov       rsi,rcx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-58]
       mov       rax,[rbp-50]
M00_L11:
       lea       rdi,[rcx+8]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L06
M00_L12:
       test      cl,4
       je        near ptr M00_L15
       mov       rdi,73E394EA0D68
       mov       rdx,73E395713820
       call      rdx
       cmp       dword ptr [rax],8
       jle       near ptr M00_L36
       mov       rdi,[rax+8]
       mov       rax,[rdi+40]
       test      rax,rax
       je        near ptr M00_L36
M00_L13:
       mov       rax,[rax+10]
       mov       [rbp-60],rax
       test      rax,rax
       je        short M00_L15
       mov       rax,[rbp-60]
       mov       rcx,[rbp-38]
       mov       rdx,[rcx+28]
       test      rdx,rdx
       jne       short M00_L14
       mov       rdi,offset MT_System.Threading.Tasks.Task+ContingentProperties
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       [rbp-68],rdx
       mov       dword ptr [rdx+3C],1
       mov       rax,[rbp-38]
       lea       rdi,[rax+28]
       mov       rsi,rdx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-68]
       mov       rax,[rbp-60]
M00_L14:
       lea       rdi,[rdx+30]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L15:
       xor       edi,edi
       mov       rax,[rbp-38]
       mov       [rax+8],rdi
       mov       [rax+10],rdi
       mov       [rax+18],rdi
       mov       ecx,[rbp-2C]
       test      ecx,0FFFFFFA0
       jne       near ptr M00_L07
       mov       edi,ecx
       or        edi,400
       or        edi,2000000
       mov       [rax+34],edi
       mov       rdi,[rax+28]
       test      rdi,rdi
       jne       near ptr M00_L37
M00_L16:
       mov       rax,[rbp-38]
       mov       byte ptr [rax+3D],1
       mov       rdi,73D354C013B8
       mov       rdi,[rdi]
       cmp       byte ptr [rdi+9D],0
       jne       near ptr M00_L38
M00_L17:
       cmp       byte ptr [73E31584B06C],0
       jne       near ptr M00_L39
M00_L18:
       test      dword ptr [r12+34],1600000
       jne       short M00_L21
       test      dword ptr [r12+34],1600000
       jne       short M00_L20
       cmp       qword ptr [r12+20],0
       jne       near ptr M00_L41
       lea       rdi,[r12+20]
       test      rdi,rdi
       je        near ptr M00_L52
       mov       rsi,rax
       xor       edx,edx
       call      000073E394C74060
       test      rax,rax
       jne       near ptr M00_L40
M00_L19:
       movsxd    rsi,r14d
       mov       rdi,r13
       mov       rdx,[rbp-38]
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       r14d
       jmp       near ptr M00_L00
M00_L20:
       call      000073E394CF8300
       test      eax,eax
       je        near ptr M00_L44
       mov       rax,[rbp-38]
       movzx     edi,byte ptr [rax+3C]
       test      edi,edi
       jne       near ptr M00_L42
M00_L21:
       mov       rdi,rax
       mov       rsi,r12
       call      qword ptr [73E317397540]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].ProcessCompletedOuterTask(System.Threading.Tasks.Task)
       jmp       short M00_L19
M00_L22:
       mov       rsi,r13
       test      rsi,rsi
       je        near ptr M00_L45
       lea       rbx,[rsi+10]
       mov       r15d,[rsi+8]
       test      r15d,r15d
       je        near ptr M00_L46
       mov       esi,r15d
       mov       rdi,offset MT_System.Threading.Tasks.Task<System.Int32>[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       lea       rdi,[r14+10]
       mov       edx,r15d
       shl       rdx,3
       cmp       rdx,4000
       jbe       short M00_L23
       mov       rsi,rbx
       call      qword ptr [73E317465788]
       jmp       short M00_L24
M00_L23:
       mov       rsi,rbx
       call      000073E394C70D90
       cmp       dword ptr [73E394ECEC80],0
       jne       near ptr M00_L47
M00_L24:
       mov       ebx,[r14+8]
       test      ebx,ebx
       jle       short M00_L26
       lea       rdi,[r14+10]
       mov       esi,ebx
M00_L25:
       cmp       qword ptr [rdi],0
       je        near ptr M00_L48
       add       rdi,8
       dec       esi
       jne       short M00_L25
M00_L26:
       mov       rdi,offset MT_System.Threading.Tasks.Task+WhenAllPromise<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       dword ptr [r15+34],2000400
       lea       rdi,[r15+40]
       mov       rsi,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r15+48],ebx
       mov       rdi,73D354C013B8
       mov       rdi,[rdi]
       cmp       byte ptr [rdi+9D],0
       jne       near ptr M00_L49
M00_L27:
       cmp       byte ptr [73E31584B06C],0
       jne       near ptr M00_L50
M00_L28:
       test      ebx,ebx
       jle       short M00_L29
       add       r14,10
       jmp       short M00_L32
M00_L29:
       mov       rax,r15
       add       rsp,48
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L30:
       mov       rdi,r15
       mov       rsi,r13
       call      qword ptr [73E3173FA1D8]; System.Threading.Tasks.Task+WhenAllPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
M00_L31:
       add       r14,8
       dec       ebx
       je        short M00_L29
M00_L32:
       mov       r13,[r14]
       test      dword ptr [r13+34],1600000
       jne       short M00_L30
       test      dword ptr [r13+34],1600000
       jne       short M00_L30
       cmp       qword ptr [r13+20],0
       jne       near ptr M00_L51
       lea       rdi,[r13+20]
       test      rdi,rdi
       je        near ptr M00_L52
       mov       rsi,r15
       xor       edx,edx
       call      000073E394C74060
       test      rax,rax
       je        short M00_L31
       jmp       near ptr M00_L51
M00_L33:
       mov       rdi,offset MT_System.Threading.Tasks.TaskFactory<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,73D354C01388
       xor       edx,edx
       call      000073E394C74060
       test      rax,rax
       jne       near ptr M00_L02
       mov       rax,73D354C01388
       mov       rax,[rax]
       jmp       near ptr M00_L02
M00_L34:
       mov       edi,4
       call      qword ptr [73E317464E10]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L03
M00_L35:
       xor       eax,eax
       jmp       near ptr M00_L05
M00_L36:
       mov       edi,8
       call      qword ptr [73E317464E10]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L13
M00_L37:
       mov       rdi,[rdi+30]
       test      rdi,rdi
       je        near ptr M00_L16
       test      cl,4
       je        near ptr M00_L16
       test      byte ptr [rdi+34],8
       jne       near ptr M00_L16
       call      qword ptr [73E3174649D8]
       jmp       near ptr M00_L16
M00_L38:
       mov       rdi,rax
       call      qword ptr [73E3173974E0]
       mov       esi,eax
       mov       rdi,73D354C013B8
       mov       rdi,[rdi]
       mov       rdx,73E305C0A908
       xor       ecx,ecx
       call      qword ptr [73E3173974F8]
       mov       rax,[rbp-38]
       jmp       near ptr M00_L17
M00_L39:
       mov       rdi,rax
       call      qword ptr [73E317397510]
       mov       rax,[rbp-38]
       jmp       near ptr M00_L18
M00_L40:
       mov       rax,[rbp-38]
M00_L41:
       mov       rdi,r12
       mov       rsi,rax
       xor       edx,edx
       call      qword ptr [73E31739D9F8]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M00_L19
       jmp       near ptr M00_L20
M00_L42:
       cmp       edi,1
       jne       short M00_L43
       mov       rdi,rax
       mov       rsi,r12
       xor       edx,edx
       call      qword ptr [73E31739D8C0]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       mov       r12,[rbp-38]
       mov       byte ptr [r12+3C],2
       jmp       near ptr M00_L19
M00_L43:
       jmp       near ptr M00_L19
M00_L44:
       mov       rdi,[rbp-38]
       mov       rsi,r12
       call      qword ptr [73E31739D860]
       jmp       near ptr M00_L19
M00_L45:
       mov       edi,33
       call      qword ptr [73E31683FAE0]
       int       3
M00_L46:
       mov       rdi,offset MT_System.Threading.Tasks.Task<System.Int32[]>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdi,r15
       xor       esi,esi
       mov       rdx,73E305C0A258
       xor       ecx,ecx
       xor       r8d,r8d
       call      qword ptr [73E317397948]
       jmp       near ptr M00_L29
M00_L47:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L24
M00_L48:
       mov       edi,1D
       mov       esi,33
       call      qword ptr [73E317397978]
       int       3
M00_L49:
       mov       rdi,r15
       call      qword ptr [73E3173974E0]
       mov       esi,eax
       mov       rdi,73D354C013B8
       mov       rdi,[rdi]
       mov       rdx,73E305C0AF98
       xor       ecx,ecx
       call      qword ptr [73E3173974F8]
       jmp       near ptr M00_L27
M00_L50:
       mov       rdi,r15
       call      qword ptr [73E317397510]
       jmp       near ptr M00_L28
M00_L51:
       mov       rdi,r13
       mov       rsi,r15
       xor       edx,edx
       call      qword ptr [73E31739D9F8]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M00_L31
       jmp       near ptr M00_L30
M00_L52:
       call      qword ptr [73E317464A98]
       int       3
; Total bytes of code 1834
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       mov       esi,[rdi+34]
       and       esi,11000000
       cmp       esi,1000000
       jne       short M01_L00
       ret
M01_L00:
       xor       esi,esi
       jmp       qword ptr [73E317397C00]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
; Total bytes of code 26
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
       call      qword ptr [73E3163DEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdi,[rbp-90]
       call      qword ptr [rax]
       lea       rdi,[rbp-88]
       call      qword ptr [73E3163DEF08]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-30]
       call      qword ptr [73E3163E0B98]
       lea       rdi,[rax+10]
       mov       rsi,[rbp-30]
       call      qword ptr [73E3163DEEB8]; CORINFO_HELP_ASSIGN_REF
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
; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
       push      rbp
       push      r15
       push      r14
       push      rbx
       push      rax
       lea       rbp,[rsp+20]
       mov       [rbp-20],rdi
       test      sil,sil
       jne       near ptr M03_L19
       or        dword ptr [rdi+34],10000
M03_L00:
       cmp       byte ptr [73E31584B06C],0
       jne       near ptr M03_L20
M03_L01:
       mov       rax,73D354C013B8
       mov       rbx,[rax]
       cmp       byte ptr [rbx+9D],0
       jne       near ptr M03_L21
M03_L02:
       mov       r15,[rdi+18]
       cmp       [r15],r15b
       cmp       byte ptr [rbx+9D],0
       jne       near ptr M03_L10
M03_L03:
       mov       rsi,offset MT_System.Threading.Tasks.ThreadPoolTaskScheduler
       cmp       [r15],rsi
       jne       near ptr M03_L17
       movzx     r15d,word ptr [rdi+34]
       test      r15b,2
       jne       near ptr M03_L11
       mov       rsi,73D354C013C0
       mov       rbx,[rsi]
       cmp       byte ptr [rbx+38],0
       jne       near ptr M03_L12
M03_L04:
       test      r15b,1
       jne       short M03_L06
       mov       rdi,73E394EA0D68
       mov       rax,73E395713820
       call      rax
       cmp       dword ptr [rax],5
       jle       near ptr M03_L13
       mov       rdi,[rax+8]
       mov       rax,[rdi+28]
       test      rax,rax
       je        near ptr M03_L13
M03_L05:
       mov       rdi,[rax+10]
       test      rdi,rdi
       jne       near ptr M03_L14
M03_L06:
       mov       rsi,[rbx+8]
       mov       rcx,[rsi+10]
       mov       rdx,[rcx+8]
M03_L07:
       mov       r15d,[rcx+0A0]
       mov       eax,r15d
       and       eax,[rcx+18]
       cmp       eax,[rdx+8]
       jae       near ptr M03_L15
       shl       rax,4
       lea       r14,[rdx+rax+10]
       mov       eax,[r14+8]
       sub       eax,r15d
       je        short M03_L08
       test      eax,eax
       jge       short M03_L07
       mov       rdi,rsi
       mov       rsi,[rbp-20]
       call      qword ptr [73E3174650E0]
       jmp       short M03_L09
M03_L08:
       lea       r8,[rcx+0A0]
       lea       r9d,[r15+1]
       mov       eax,r15d
       lock cmpxchg [r8],r9d
       cmp       eax,r15d
       jne       short M03_L07
       mov       rsi,[rbp-20]
       mov       rdi,r14
       call      CORINFO_HELP_ASSIGN_REF
       inc       r15d
       mov       [r14+8],r15d
M03_L09:
       add       rbx,78
       mov       edi,1
       xchg      edi,[rbx]
       test      edi,edi
       jne       near ptr M03_L18
       mov       rdi,73D354C013E8
       mov       rbx,[rdi]
       lea       rdi,[rbx+160]
       lock inc  dword ptr [rdi]
       mov       rdi,rbx
       call      qword ptr [73E317396E50]; System.Threading.PortableThreadPool+WorkerThread.MaybeAddWorkingWorker(System.Threading.PortableThreadPool)
       cmp       dword ptr [rbx+164],6
       je        near ptr M03_L18
       jmp       near ptr M03_L16
M03_L10:
       mov       rsi,r15
       call      qword ptr [73E317464FC0]
       mov       rdi,[rbp-20]
       jmp       near ptr M03_L03
M03_L11:
       mov       rdi,offset MT_System.Threading.Tasks.ThreadPoolTaskScheduler
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdi,73D354C014B0
       mov       rbx,[rdi]
       mov       rdi,offset MT_System.Threading.Thread
       call      CORINFO_HELP_NEWFAST
       mov       r15,rax
       mov       rdi,r15
       mov       rsi,rbx
       call      qword ptr [73E317465C98]
       mov       rdi,r15
       mov       esi,1
       call      qword ptr [73E317397030]; System.Threading.Thread.set_IsBackground(Boolean)
       mov       rdi,r15
       mov       rsi,73E305C0A040
       call      qword ptr [73E317397138]; System.Threading.Thread.set_Name(System.String)
       mov       rdi,r15
       mov       rsi,[rbp-20]
       xor       edx,edx
       call      qword ptr [73E317465CB0]
       jmp       near ptr M03_L18
M03_L12:
       mov       rsi,73D354C013D8
       mov       rsi,[rsi]
       cmp       byte ptr [rsi+9D],0
       je        near ptr M03_L04
       mov       rsi,73D354C013D8
       mov       rdi,[rsi]
       mov       rsi,[rbp-20]
       call      qword ptr [73E3174650B0]
       jmp       near ptr M03_L04
M03_L13:
       mov       edi,5
       call      qword ptr [73E317464E10]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M03_L05
M03_L14:
       mov       rdi,[rdi+18]
       mov       rsi,[rbp-20]
       cmp       [rdi],edi
       call      qword ptr [73E3174650C8]
       jmp       near ptr M03_L09
M03_L15:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M03_L16:
       mov       rdi,rbx
       call      qword ptr [73E3173970A8]; System.Threading.PortableThreadPool+GateThread.EnsureRunningSlow(System.Threading.PortableThreadPool)
       jmp       short M03_L18
M03_L17:
       mov       rdi,r15
       mov       rsi,[rbp-20]
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       nop
M03_L18:
       add       rsp,8
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L19:
       call      qword ptr [73E317465C80]
       test      eax,eax
       mov       rdi,[rbp-20]
       jne       near ptr M03_L00
       jmp       short M03_L18
M03_L20:
       call      qword ptr [73E317397510]
       mov       rdi,[rbp-20]
       jmp       near ptr M03_L01
M03_L21:
       test      word ptr [rdi+34],200
       jne       near ptr M03_L02
       call      qword ptr [73E3173974E0]
       mov       r15d,eax
       mov       rdi,[rbp-20]
       mov       rdi,[rdi+8]
       call      qword ptr [73E317464F30]
       mov       rsi,rax
       mov       rdi,73E305C09FB8
       call      qword ptr [73E31683EFA0]; System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       esi,r15d
       mov       rdi,rbx
       xor       ecx,ecx
       call      qword ptr [73E3173974F8]
       mov       rdi,[rbp-20]
       jmp       near ptr M03_L02
       push      rax
       mov       rbx,rdi
       mov       rdi,offset MT_System.Threading.Tasks.TaskSchedulerException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdi,r15
       mov       rsi,rbx
       call      qword ptr [73E317464F48]
       mov       rdi,[rbp-20]
       mov       rsi,r15
       call      qword ptr [73E317464F60]
       mov       rdi,[rbp-20]
       xor       esi,esi
       call      qword ptr [73E317464F78]
       mov       rdi,[rbp-20]
       call      qword ptr [73E317464F90]
       test      eax,200
       jne       short M03_L22
       mov       rdi,[rbp-20]
       mov       rdi,[rdi+28]
       mov       rdi,[rdi+18]
       xor       esi,esi
       cmp       [rdi],edi
       call      qword ptr [73E317464FA8]
M03_L22:
       mov       rdi,r15
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 886
```
```assembly
; AsyncLazyBenchmarks.ContendedFirstCallBenchmarks+<>c__DisplayClass11_0.<VsThreading>b__0()
       mov       rdi,[rdi+8]
       cmp       [rdi],dil
       xor       esi,esi
       jmp       qword ptr [73E317397870]; Microsoft.VisualStudio.Threading.AsyncLazy`1[[System.Int32, System.Private.CoreLib]].GetValueAsync(System.Threading.CancellationToken)
; Total bytes of code 15
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       push      rbp
       mov       rbp,rsp
       mov       eax,[rdi+8]
       cmp       rax,rsi
       jbe       short M05_L01
       lea       rax,[rdi+rsi*8+10]
       mov       rdi,[rdi]
       mov       rsi,[rdi+30]
       test      rdx,rdx
       je        short M05_L00
       cmp       rsi,[rdx]
       je        short M05_L02
       mov       rcx,offset MT_System.Object[]
       cmp       rdi,rcx
       je        short M05_L02
       mov       rdi,rax
       pop       rbp
       jmp       qword ptr [73E317087A68]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
M05_L00:
       xor       ecx,ecx
       mov       [rax],rcx
       pop       rbp
       ret
M05_L01:
       call      qword ptr [73E3174649C0]
       int       3
M05_L02:
       mov       rdi,rax
       mov       rsi,rdx
       pop       rbp
       jmp       near ptr 000073E394DFB900
; Total bytes of code 85
```
```assembly
; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].ProcessCompletedOuterTask(System.Threading.Tasks.Task)
       push      rbp
       push      r15
       push      r14
       push      rbx
       push      rax
       lea       rbp,[rsp+20]
       mov       rbx,rdi
       mov       r15,rsi
       mov       byte ptr [rbx+3C],1
       mov       esi,[r15+34]
       test      esi,200000
       jne       near ptr M06_L07
       test      esi,400000
       jne       near ptr M06_L08
       test      esi,1000000
       je        near ptr M06_L09
       mov       r14d,5
M06_L00:
       cmp       r14d,5
       jne       near ptr M06_L06
       mov       rdi,r15
       mov       rax,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task<System.Int32>>
       cmp       [rdi],rax
       jne       near ptr M06_L13
M06_L01:
       test      rdi,rdi
       je        near ptr M06_L14
       mov       esi,[rdi+34]
       and       esi,11000000
       cmp       esi,1000000
       jne       near ptr M06_L16
       mov       r14,[rdi+38]
M06_L02:
       test      r14,r14
       je        near ptr M06_L17
       test      dword ptr [r14+34],1600000
       je        short M06_L05
       mov       rdi,rbx
       mov       rsi,r14
       xor       edx,edx
       call      qword ptr [73E31739D8C0]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
M06_L03:
       mov       byte ptr [rbx+3C],2
M06_L04:
       add       rsp,8
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       ret
M06_L05:
       test      dword ptr [r14+34],1600000
       jne       near ptr M06_L20
       cmp       qword ptr [r14+20],0
       jne       near ptr M06_L19
       lea       rdi,[r14+20]
       test      rdi,rdi
       je        near ptr M06_L18
       mov       rsi,rbx
       xor       edx,edx
       call      000073E394C74060
       test      rax,rax
       je        short M06_L04
       jmp       near ptr M06_L19
M06_L06:
       add       r14d,0FFFFFFFA
       cmp       r14d,1
       ja        short M06_L04
       jmp       short M06_L12
M06_L07:
       mov       r14d,7
       jmp       near ptr M06_L00
M06_L08:
       mov       r14d,6
       jmp       near ptr M06_L00
M06_L09:
       test      esi,800000
       je        short M06_L10
       mov       r14d,4
       jmp       near ptr M06_L00
M06_L10:
       test      esi,20000
       je        short M06_L11
       mov       r14d,3
       jmp       near ptr M06_L00
M06_L11:
       test      esi,2000000
       setne     r14b
       movzx     r14d,r14b
       mov       edi,2
       test      esi,10000
       cmovne    r14d,edi
       jmp       near ptr M06_L00
M06_L12:
       movzx     edx,byte ptr [rbx+3D]
       mov       rdi,rbx
       mov       rsi,r15
       call      qword ptr [73E31739D8C0]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       jmp       near ptr M06_L04
M06_L13:
       mov       rsi,r15
       mov       rdi,rax
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M06_L01
M06_L14:
       mov       rdi,r15
       mov       rax,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task>
       cmp       [rdi],rax
       je        short M06_L15
       mov       rsi,r15
       mov       rdi,rax
       call      qword ptr [73E316C64AF8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rdi,rax
M06_L15:
       cmp       [rdi],edi
       call      qword ptr [73E31739D950]; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].get_Result()
       mov       r14,rax
       jmp       near ptr M06_L02
M06_L16:
       mov       esi,1
       call      qword ptr [73E3174652D8]
       mov       r14,rax
       jmp       near ptr M06_L02
M06_L17:
       mov       rdi,rbx
       xor       esi,esi
       xor       edx,edx
       call      qword ptr [73E31739DC68]
       jmp       near ptr M06_L03
M06_L18:
       call      qword ptr [73E317464A98]
       int       3
M06_L19:
       mov       rdi,r14
       mov       rsi,rbx
       xor       edx,edx
       call      qword ptr [73E31739D9F8]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M06_L04
M06_L20:
       mov       rdi,rbx
       mov       rsi,r14
       add       rsp,8
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [73E3173CCE90]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
; Total bytes of code 523
```
```assembly
; System.Threading.Tasks.Task+WhenAllPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+50]
       mov       rbx,rdi
       mov       rdi,73D354C013B8
       mov       r15,[rdi]
       cmp       byte ptr [r15+9D],0
       jne       near ptr M07_L14
M07_L00:
       lea       rsi,[rbx+48]
       mov       edi,0FFFFFFFF
       lock xadd [rsi],edi
       dec       edi
       je        short M07_L02
M07_L01:
       add       rsp,28
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M07_L02:
       mov       rsi,[rbx+40]
       mov       esi,[rsi+8]
       mov       rdi,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       xor       r13d,r13d
       xor       r12d,r12d
       xor       eax,eax
M07_L03:
       mov       rdi,[rbx+40]
       cmp       [rdi+8],eax
       jle       near ptr M07_L11
       cmp       eax,[rdi+8]
       jae       near ptr M07_L24
       mov       [rbp-2C],eax
       mov       ecx,eax
       mov       [rbp-38],rcx
       mov       r8,[rdi+rcx*8+10]
       mov       [rbp-40],r8
       test      dword ptr [r8+34],200000
       jne       near ptr M07_L08
       mov       edi,[r8+34]
       and       edi,600000
       cmp       edi,400000
       je        near ptr M07_L16
       test      dword ptr [r8+34],1600000
       je        near ptr M07_L17
M07_L04:
       mov       edi,[r8+34]
       and       edi,1600000
       cmp       edi,1000000
       jne       near ptr M07_L18
M07_L05:
       mov       edi,[r8+38]
       mov       eax,[rbp-2C]
       cmp       eax,[r14+8]
       jae       near ptr M07_L24
       mov       rcx,[rbp-38]
       mov       [r14+rcx*4+10],edi
M07_L06:
       test      dword ptr [r8+34],10000000
       jne       near ptr M07_L19
       mov       rdi,[rbx+40]
       mov       eax,[rbp-2C]
       cmp       eax,[rdi+8]
       jae       near ptr M07_L24
       xor       esi,esi
       mov       rcx,[rbp-38]
       mov       [rdi+rcx*8+10],rsi
M07_L07:
       mov       eax,[rbp-2C]
       inc       eax
       jmp       near ptr M07_L03
M07_L08:
       test      r13,r13
       je        near ptr M07_L15
M07_L09:
       mov       rdi,[r8+28]
       mov       rdx,[rdi+18]
       mov       [rbp-48],rdx
       mov       rsi,[rdx+10]
       mov       [rbp-50],rsi
       cmp       byte ptr [rdx+20],0
       jne       short M07_L10
       mov       rdi,rdx
       call      qword ptr [73E317086868]; System.GC.SuppressFinalize(System.Object)
       mov       rdi,[rbp-48]
       mov       byte ptr [rdi+20],1
M07_L10:
       mov       rdi,r13
       mov       rsi,[rbp-50]
       cmp       [rdi],edi
       call      qword ptr [73E31739DDD0]
       mov       r8,[rbp-40]
       jmp       short M07_L06
M07_L11:
       test      r13,r13
       jne       near ptr M07_L20
       test      r12,r12
       jne       near ptr M07_L21
       cmp       byte ptr [r15+9D],0
       jne       near ptr M07_L22
M07_L12:
       cmp       byte ptr [73E31584B06C],0
       jne       near ptr M07_L23
M07_L13:
       mov       rdi,rbx
       mov       rsi,r14
       call      qword ptr [73E31739DE48]; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].TrySetResult(System.__Canon)
       jmp       near ptr M07_L01
M07_L14:
       mov       rdi,rbx
       call      qword ptr [73E3173974E0]
       mov       esi,eax
       mov       rdi,r15
       mov       edx,1
       call      qword ptr [73E31739DC20]
       jmp       near ptr M07_L00
M07_L15:
       mov       rdi,offset MT_System.Collections.Generic.List<System.Runtime.ExceptionServices.ExceptionDispatchInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdi,r13
       call      qword ptr [73E31708F0A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       r8,[rbp-40]
       jmp       near ptr M07_L09
M07_L16:
       test      r12,r12
       jne       near ptr M07_L06
       mov       r12,r8
       mov       r8,[rbp-40]
       jmp       near ptr M07_L06
M07_L17:
       mov       rdi,r8
       mov       esi,0FFFFFFFF
       xor       edx,edx
       call      qword ptr [73E317397C18]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
       mov       r8,[rbp-40]
       jmp       near ptr M07_L04
M07_L18:
       mov       rdi,r8
       mov       esi,1
       call      qword ptr [73E317465EC0]
       mov       r8,[rbp-40]
       jmp       near ptr M07_L05
M07_L19:
       mov       rdi,rbx
       mov       esi,1
       call      qword ptr [73E31739DE30]
       jmp       near ptr M07_L07
M07_L20:
       mov       rdi,rbx
       mov       rsi,r13
       call      qword ptr [73E31739CC18]; System.Threading.Tasks.Task.TrySetException(System.Object)
       jmp       near ptr M07_L01
M07_L21:
       mov       rdi,r12
       call      qword ptr [73E31739DC38]
       mov       r13,rax
       mov       rdi,r12
       call      qword ptr [73E31739DC50]
       mov       rdx,rax
       mov       rsi,r13
       mov       rdi,rbx
       call      qword ptr [73E31739DC68]
       jmp       near ptr M07_L01
M07_L22:
       mov       rdi,rbx
       call      qword ptr [73E3173974E0]
       mov       esi,eax
       mov       rdi,r15
       mov       edx,1
       call      qword ptr [73E31739DCF8]
       jmp       near ptr M07_L12
M07_L23:
       mov       rdi,rbx
       call      qword ptr [73E31739DD10]
       jmp       near ptr M07_L13
M07_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 700
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbp
       push      rbx
       push      rax
       lea       rbp,[rsp+10]
       mov       ebx,edi
       call      qword ptr [73E3163F6AF0]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       edi,ebx
       and       edi,0FFFFFF
       mov       ecx,edi
       mov       edx,ebx
       sar       edx,18
       jne       short M08_L01
       cmp       [rax],edi
       jle       short M08_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       ecx,0FFFFFFFE
       movsxd    rdi,ecx
       mov       rax,[rax+rdi*8+10]
       test      rax,rax
       je        short M08_L03
M08_L00:
       add       rsp,8
       pop       rbx
       pop       rbp
       ret
M08_L01:
       mov       edi,ebx
       sar       edi,18
       cmp       edi,2
       jne       short M08_L02
       movsxd    rcx,ecx
       add       rax,rcx
       jmp       short M08_L00
M08_L02:
       cmp       [rax+4],ecx
       jle       short M08_L03
       mov       rdi,[rax+10]
       movsxd    rax,ecx
       mov       rdi,[rdi+rax*8]
       test      rdi,rdi
       je        short M08_L03
       mov       rax,[rdi]
       test      rax,rax
       je        short M08_L03
       jmp       short M08_L00
M08_L03:
       mov       edi,ebx
       lea       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       add       rsp,8
       pop       rbx
       pop       rbp
       jmp       qword ptr [rax]
; Total bytes of code 133
```
```assembly
; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rbx
       sub       rsp,18
       lea       rbp,[rsp+40]
       mov       rbx,rdi
       mov       r15,rsi
       mov       r14d,edx
       mov       r13,[rbx+20]
       mov       rsi,73D354C00238
       cmp       r13,[rsi]
       je        near ptr M09_L02
       mov       r12,r13
       test      r12,r12
       je        short M09_L00
       mov       rsi,offset MT_System.Threading.Tasks.UnwrapPromise<System.Int32>
       cmp       [r12],rsi
       jne       near ptr M09_L15
       xor       r12d,r12d
M09_L00:
       test      r12,r12
       jne       near ptr M09_L03
       mov       rdi,offset MT_System.Collections.Generic.List<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rdi,73D354C00AB8
       mov       rsi,[rdi]
       lea       rdi,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      r14b,r14b
       jne       near ptr M09_L17
       inc       dword ptr [r12+14]
       mov       rdi,r12
       mov       rsi,r13
       call      qword ptr [73E3168372D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       inc       dword ptr [r12+14]
       mov       rdi,[r12+8]
       mov       esi,[r12+10]
       cmp       [rdi+8],esi
       jbe       near ptr M09_L16
       lea       edx,[rsi+1]
       mov       [r12+10],edx
       mov       esi,esi
       mov       rdx,r15
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M09_L01:
       lea       rdi,[rbx+20]
       test      rdi,rdi
       je        near ptr M09_L19
       mov       rsi,r12
       mov       rdx,r13
       call      000073E394C74060
       mov       r12,rax
       cmp       r12,r13
       je        near ptr M09_L14
       mov       rsi,r12
       mov       rdi,offset MT_System.Collections.Generic.List<System.Object>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r12,rax
       test      r12,r12
       jne       short M09_L03
M09_L02:
       xor       eax,eax
       add       rsp,18
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M09_L03:
       mov       [rbp-38],r12
       xor       edi,edi
       mov       [rbp-2C],edi
       mov       rdi,r12
       call      000073E394AE6020
       test      eax,eax
       je        short M09_L07
M09_L04:
       mov       dword ptr [rbp-2C],1
       mov       rdi,[rbx+20]
       mov       rax,73D354C00238
       cmp       rdi,[rax]
       je        near ptr M09_L11
       mov       edi,[r12+10]
       mov       rax,[r12+8]
       cmp       edi,[rax+8]
       je        short M09_L08
M09_L05:
       test      r14b,r14b
       jne       near ptr M09_L10
       inc       dword ptr [r12+14]
       mov       rdi,[r12+8]
       mov       esi,[r12+10]
       cmp       [rdi+8],esi
       jbe       short M09_L06
       lea       edx,[rsi+1]
       mov       [r12+10],edx
       mov       esi,esi
       mov       rdx,r15
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M09_L13
M09_L06:
       mov       rdi,r12
       mov       rsi,r15
       call      qword ptr [73E3168372D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M09_L13
M09_L07:
       mov       rdi,r12
       call      qword ptr [73E31739C090]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M09_L04
M09_L08:
       mov       rdi,73D354C00290
       mov       rsi,[rdi]
       test      rsi,rsi
       jne       short M09_L09
       mov       rdi,offset MT_System.Predicate<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rsi,73D354C00260
       mov       rsi,[rsi]
       mov       rdi,rbx
       mov       rdx,offset System.Threading.Tasks.Task+<>c.<AddTaskContinuationComplex>b__211_0(System.Object)
       call      qword ptr [73E316836E08]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdi,73D354C00290
       mov       rsi,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,rbx
M09_L09:
       mov       rdi,r12
       cmp       [rdi],edi
       call      qword ptr [73E31739E988]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAll(System.Predicate`1<System.__Canon>)
       jmp       near ptr M09_L05
M09_L10:
       mov       rdi,r12
       mov       rdx,r15
       xor       esi,esi
       call      qword ptr [73E316926A30]
       jmp       short M09_L13
M09_L11:
       mov       rdi,r12
       call      000073E394AE6790
       test      eax,eax
       jne       near ptr M09_L20
M09_L12:
       xor       eax,eax
       add       rsp,18
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M09_L13:
       call      M09_L21
       nop
M09_L14:
       mov       eax,1
       add       rsp,18
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M09_L15:
       mov       rsi,r13
       mov       rdi,offset MT_System.Collections.Generic.List<System.Object>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r12,rax
       jmp       near ptr M09_L00
M09_L16:
       mov       rdi,r12
       mov       rsi,r15
       call      qword ptr [73E3168372D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M09_L01
M09_L17:
       inc       dword ptr [r12+14]
       mov       rdi,r12
       mov       rsi,r15
       call      qword ptr [73E3168372D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       inc       dword ptr [r12+14]
       mov       rdi,[r12+8]
       mov       esi,[r12+10]
       cmp       [rdi+8],esi
       jbe       short M09_L18
       lea       edx,[rsi+1]
       mov       [r12+10],edx
       mov       esi,esi
       mov       rdx,r13
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M09_L01
M09_L18:
       mov       rdi,r12
       mov       rsi,r13
       call      qword ptr [73E3168372D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M09_L01
M09_L19:
       call      qword ptr [73E317464A98]
       int       3
M09_L20:
       mov       edi,eax
       mov       rsi,r12
       call      qword ptr [73E31739D5C0]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       near ptr M09_L12
M09_L21:
       push      rax
       cmp       dword ptr [rbp-2C],0
       je        short M09_L22
       mov       rdi,[rbp-38]
       call      000073E394AE6790
       test      eax,eax
       je        short M09_L22
       mov       edi,eax
       mov       rsi,[rbp-38]
       call      qword ptr [73E31739D5C0]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M09_L22:
       nop
       add       rsp,8
       ret
; Total bytes of code 786
```
```assembly
; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rbx
       sub       rsp,10
       lea       rbp,[rsp+30]
       mov       rbx,rdi
       mov       r15,rsi
       mov       r14d,edx
M10_L00:
       mov       rdi,73D354C013B8
       mov       r13,[rdi]
       cmp       byte ptr [r13+9D],0
       jne       near ptr M10_L12
M10_L01:
       xor       eax,eax
       mov       edi,[r15+34]
       test      edi,200000
       jne       near ptr M10_L13
       test      edi,400000
       jne       near ptr M10_L14
       test      edi,1000000
       je        near ptr M10_L15
       mov       ecx,5
M10_L02:
       add       ecx,0FFFFFFFB
       jne       near ptr M10_L18
       cmp       byte ptr [r13+9D],0
       jne       near ptr M10_L20
M10_L03:
       cmp       byte ptr [73E31584B06C],0
       jne       near ptr M10_L21
M10_L04:
       mov       rdi,r15
       mov       rsi,offset MT_System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Int32>+AsyncStateMachineBox<Microsoft.VisualStudio.Threading.AsyncLazy<System.Int32>+<>c__DisplayClass20_0+<<GetValueAsync>b__0>d>
       cmp       [rdi],rsi
       jne       near ptr M10_L22
M10_L05:
       test      rdi,rdi
       je        near ptr M10_L23
       mov       esi,[rdi+34]
       and       esi,11000000
       cmp       esi,1000000
       jne       near ptr M10_L24
       mov       r15d,[rdi+38]
M10_L06:
       xor       r14d,r14d
       mov       eax,[rbx+34]
       mov       [rbp-24],eax
       test      eax,5600000
       jne       short M10_L10
       lea       rdi,[rbx+34]
       mov       esi,eax
       or        esi,4000000
       lock cmpxchg [rdi],esi
       cmp       eax,[rbp-24]
       jne       near ptr M10_L25
M10_L07:
       mov       [rbx+38],r15d
       lea       rdi,[rbx+34]
       mov       eax,[rbx+34]
       or        eax,1000000
       xchg      eax,[rdi]
       mov       r14,[rbx+28]
       test      r14,r14
       jne       near ptr M10_L26
M10_L08:
       lea       rdi,[rbx+20]
       test      rdi,rdi
       je        near ptr M10_L27
       mov       rsi,73D354C00238
       mov       rsi,[rsi]
       call      000073E394C74040
       test      rax,rax
       je        short M10_L09
       mov       rdi,rbx
       mov       rsi,rax
       call      qword ptr [73E31739D788]; System.Threading.Tasks.Task.RunContinuations(System.Object)
M10_L09:
       mov       r14d,1
M10_L10:
       mov       eax,r14d
M10_L11:
       add       rsp,10
       pop       rbx
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M10_L12:
       mov       rdi,rbx
       call      qword ptr [73E3173974E0]
       mov       esi,eax
       mov       rdi,r13
       mov       edx,1
       call      qword ptr [73E31739DC20]
       jmp       near ptr M10_L01
M10_L13:
       mov       ecx,7
       jmp       near ptr M10_L02
M10_L14:
       mov       ecx,6
       jmp       near ptr M10_L02
M10_L15:
       test      edi,800000
       je        short M10_L16
       mov       ecx,4
       jmp       near ptr M10_L02
M10_L16:
       test      edi,20000
       je        short M10_L17
       mov       ecx,3
       jmp       near ptr M10_L02
M10_L17:
       test      edi,2000000
       setne     cl
       movzx     ecx,cl
       mov       edx,2
       test      edi,10000
       cmovne    ecx,edx
       jmp       near ptr M10_L02
M10_L18:
       cmp       ecx,2
       ja        near ptr M10_L11
       mov       edi,ecx
       lea       rax,[73E3168C1398]
       mov       eax,[rax+rdi*4]
       lea       rcx,[M10_L00]
       add       rax,rcx
       jmp       rax
       mov       rdi,r15
       call      qword ptr [73E31739DC38]
       mov       r14,rax
       mov       rdi,r15
       call      qword ptr [73E31739DC50]
       mov       rdx,rax
       mov       rsi,r14
       mov       rdi,rbx
       call      qword ptr [73E31739DC68]
       jmp       near ptr M10_L11
       mov       rdi,r15
       call      qword ptr [73E31739DC80]
       mov       r15,rax
       test      r14b,r14b
       je        short M10_L19
       cmp       dword ptr [r15+10],0
       jle       short M10_L19
       mov       rdi,r15
       xor       esi,esi
       call      qword ptr [73E3169269B8]
       mov       r13,rax
       test      r13,r13
       je        short M10_L19
       mov       rsi,[r13+8]
       mov       rdi,offset MT_System.OperationCanceledException
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M10_L19
       mov       rsi,[rax+70]
       mov       rdi,rbx
       mov       rdx,r13
       call      qword ptr [73E31739DC68]
       jmp       near ptr M10_L11
M10_L19:
       mov       rdi,rbx
       mov       rsi,r15
       call      qword ptr [73E31739CC18]; System.Threading.Tasks.Task.TrySetException(System.Object)
       jmp       near ptr M10_L11
M10_L20:
       mov       rdi,rbx
       call      qword ptr [73E3173974E0]
       mov       esi,eax
       mov       rdi,r13
       mov       edx,1
       call      qword ptr [73E31739DCF8]
       jmp       near ptr M10_L03
M10_L21:
       mov       rdi,rbx
       call      qword ptr [73E31739DD10]
       jmp       near ptr M10_L04
M10_L22:
       mov       rsi,r15
       mov       rdi,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M10_L05
M10_L23:
       xor       r15d,r15d
       jmp       near ptr M10_L06
M10_L24:
       mov       esi,1
       call      qword ptr [73E31739DE00]; System.Threading.Tasks.Task`1[[System.Int32, System.Private.CoreLib]].GetResultCore(Boolean)
       mov       r15d,eax
       jmp       near ptr M10_L06
M10_L25:
       mov       rdi,rbx
       mov       esi,4000000
       mov       edx,5600000
       call      qword ptr [73E317464EA0]
       test      eax,eax
       je        near ptr M10_L10
       jmp       near ptr M10_L07
M10_L26:
       mov       rdi,rbx
       call      qword ptr [73E31739CD20]; System.Threading.Tasks.Task.NotifyParentIfPotentiallyAttachedTask()
       mov       rdi,r14
       call      qword ptr [73E317464EB8]
       jmp       near ptr M10_L08
M10_L27:
       call      qword ptr [73E317464A98]
       int       3
; Total bytes of code 789
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
       jne       short M11_L00
       mov       rdi,rbx
       mov       esi,0FFFFFFFF
       xor       edx,edx
       call      qword ptr [73E317397C18]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M11_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M11_L03
M11_L01:
       mov       edi,[rbx+34]
       and       edi,1600000
       cmp       edi,1000000
       jne       short M11_L04
M11_L02:
       pop       rbx
       pop       r15
       pop       rbp
       ret
M11_L03:
       mov       rdi,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M11_L01
       mov       rdi,rbx
       call      qword ptr [73E317465A10]
       jmp       short M11_L01
M11_L04:
       test      r15b,2
       jne       short M11_L05
       mov       rdi,rbx
       call      qword ptr [73E317465878]
M11_L05:
       mov       rdi,rbx
       call      qword ptr [73E3174661A8]
       jmp       short M11_L02
; Total bytes of code 125
```

