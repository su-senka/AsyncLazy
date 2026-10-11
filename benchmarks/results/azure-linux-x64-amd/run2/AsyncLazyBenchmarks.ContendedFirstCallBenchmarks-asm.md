## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: DefaultJob)

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
       mov       rdi,74A3E0801350
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
       mov       rdi,offset AsyncLazyBenchmarks.ContendedFirstCallBenchmarks+<>c__DisplayClass8_0.<LazyOfTask>b__0()
       mov       [r12+18],rdi
       lea       rdi,[r15+10]
       mov       rsi,r12
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       mov       rdi,74A3E0801370
       mov       rax,[rdi]
       test      rax,rax
       je        near ptr M00_L30
M00_L02:
       cmp       [rax],al
       mov       rdi,74A3E0801380
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
       mov       rdi,74B4202A0D68
       mov       rax,74B420B37820
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
       call      qword ptr [74B3A249C030]; System.Threading.Thread.InitializeCurrentThread()
M00_L04:
       mov       rax,[rax+8]
       test      rax,rax
       jne       short M00_L08
       mov       rax,74A3E0801390
       mov       rax,[rax]
M00_L05:
       test      rax,rax
       jne       short M00_L09
       or        dword ptr [r12+34],20000000
M00_L06:
       mov       rdi,r12
       xor       esi,esi
       call      qword ptr [74B3A2796868]; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
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
       call      qword ptr [74B3A1C4F0D8]
       int       3
M00_L08:
       cmp       byte ptr [rax+18],0
       je        short M00_L05
       xor       eax,eax
       jmp       short M00_L05
M00_L09:
       mov       rdi,74A3E0801390
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
       mov       rdi,74B4202A0D68
       mov       rdx,74B420B37820
       call      rdx
       cmp       dword ptr [rax],8
       jle       near ptr M00_L32
       mov       rdi,[rax+8]
       mov       rax,[rdi+40]
       test      rax,rax
       je        near ptr M00_L32
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
       jne       near ptr M00_L33
M00_L15:
       mov       rax,[rbp-38]
       mov       byte ptr [rax+3D],1
       mov       rdi,74A3E08013A0
       mov       rdi,[rdi]
       cmp       byte ptr [rdi+9D],0
       jne       near ptr M00_L34
M00_L16:
       cmp       byte ptr [74B3A0C5B06C],0
       jne       near ptr M00_L35
M00_L17:
       test      dword ptr [r12+34],1600000
       jne       near ptr M00_L36
       test      dword ptr [r12+34],1600000
       jne       near ptr M00_L39
       cmp       qword ptr [r12+20],0
       jne       near ptr M00_L38
       lea       rdi,[r12+20]
       test      rdi,rdi
       je        near ptr M00_L47
       mov       rsi,rax
       xor       edx,edx
       call      000074B420074060
       test      rax,rax
       jne       near ptr M00_L37
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
       je        near ptr M00_L40
       lea       rbx,[rsi+10]
       mov       r15d,[rsi+8]
       test      r15d,r15d
       je        near ptr M00_L41
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
       call      qword ptr [74B3A279F5D0]
       jmp       short M00_L21
M00_L20:
       mov       rsi,rbx
       call      000074B420070D90
       cmp       dword ptr [74B4202CEC80],0
       jne       near ptr M00_L42
M00_L21:
       mov       ebx,[r14+8]
       test      ebx,ebx
       jle       short M00_L23
       lea       rdi,[r14+10]
       mov       esi,ebx
M00_L22:
       cmp       qword ptr [rdi],0
       je        near ptr M00_L43
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
       mov       rdi,74A3E08013A0
       mov       rdi,[rdi]
       cmp       byte ptr [rdi+9D],0
       jne       near ptr M00_L44
M00_L24:
       cmp       byte ptr [74B3A0C5B06C],0
       jne       near ptr M00_L45
M00_L25:
       xor       r13d,r13d
       test      ebx,ebx
       jle       short M00_L28
M00_L26:
       mov       rbx,[r14+r13*8+10]
       test      dword ptr [rbx+34],1600000
       jne       short M00_L29
       test      dword ptr [rbx+34],1600000
       jne       short M00_L29
       cmp       qword ptr [rbx+20],0
       jne       near ptr M00_L46
       lea       rdi,[rbx+20]
       test      rdi,rdi
       je        near ptr M00_L47
       mov       rsi,r15
       xor       edx,edx
       call      000074B420074060
       test      rax,rax
       jne       near ptr M00_L46
M00_L27:
       inc       r13d
       mov       ebx,[r14+8]
       cmp       ebx,r13d
       jg        short M00_L26
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
       mov       rsi,rbx
       call      qword ptr [74B3A27DB220]; System.Threading.Tasks.Task+WhenAllPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
       jmp       short M00_L27
M00_L30:
       mov       rdi,offset MT_System.Threading.Tasks.TaskFactory<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,74A3E0801370
       xor       edx,edx
       call      000074B420074060
       test      rax,rax
       jne       near ptr M00_L02
       mov       rax,74A3E0801370
       mov       rax,[rax]
       jmp       near ptr M00_L02
M00_L31:
       mov       edi,4
       call      qword ptr [74B3A279ED00]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L03
M00_L32:
       mov       edi,8
       call      qword ptr [74B3A279ED00]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L12
M00_L33:
       mov       rdi,[rdi+30]
       test      rdi,rdi
       je        near ptr M00_L15
       test      cl,4
       je        near ptr M00_L15
       test      byte ptr [rdi+34],8
       jne       near ptr M00_L15
       call      qword ptr [74B3A279E850]
       jmp       near ptr M00_L15
M00_L34:
       mov       rdi,rax
       call      qword ptr [74B3A2797258]
       mov       esi,eax
       mov       rdi,74A3E08013A0
       mov       rdi,[rdi]
       mov       rdx,74B398C0A850
       xor       ecx,ecx
       call      qword ptr [74B3A2797270]
       mov       rax,[rbp-38]
       jmp       near ptr M00_L16
M00_L35:
       mov       rdi,rax
       call      qword ptr [74B3A2797288]
       mov       rax,[rbp-38]
       jmp       near ptr M00_L17
M00_L36:
       mov       rdi,rax
       mov       rsi,r12
       call      qword ptr [74B3A27972B8]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].ProcessCompletedOuterTask(System.Threading.Tasks.Task)
       jmp       near ptr M00_L18
M00_L37:
       mov       rax,[rbp-38]
M00_L38:
       mov       rdi,r12
       mov       rsi,rax
       xor       edx,edx
       call      qword ptr [74B3A279CA20]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M00_L18
       mov       rax,[rbp-38]
M00_L39:
       mov       rdi,rax
       mov       rsi,r12
       call      qword ptr [74B3A27CDEB0]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
       jmp       near ptr M00_L18
M00_L40:
       mov       edi,33
       call      qword ptr [74B3A1C4FAE0]
       int       3
M00_L41:
       mov       rdi,offset MT_System.Threading.Tasks.Task<System.Int32[]>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdi,r15
       xor       esi,esi
       mov       rdx,74B398C0A1A0
       xor       ecx,ecx
       xor       r8d,r8d
       call      qword ptr [74B3A27976F0]
       jmp       near ptr M00_L28
M00_L42:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L21
M00_L43:
       mov       edi,1D
       mov       esi,33
       call      qword ptr [74B3A2797720]
       int       3
M00_L44:
       mov       rdi,r15
       call      qword ptr [74B3A2797258]
       mov       esi,eax
       mov       rdi,74A3E08013A0
       mov       rdi,[rdi]
       mov       rdx,74B398C0AEE0
       xor       ecx,ecx
       call      qword ptr [74B3A2797270]
       jmp       near ptr M00_L24
M00_L45:
       mov       rdi,r15
       call      qword ptr [74B3A2797288]
       jmp       near ptr M00_L25
M00_L46:
       mov       rdi,rbx
       mov       rsi,r15
       xor       edx,edx
       call      qword ptr [74B3A279CA20]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M00_L27
       jmp       near ptr M00_L29
M00_L47:
       call      qword ptr [74B3A279E7C0]
       int       3
; Total bytes of code 1741
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
       jmp       qword ptr [74B3A2797990]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
; Total bytes of code 26
```
```assembly
; AsyncLazyBenchmarks.ContendedFirstCallBenchmarks+<>c__DisplayClass8_0.<LazyOfTask>b__0()
       mov       rdi,[rdi+8]
       cmp       qword ptr [rdi+8],0
       je        short M02_L00
       jmp       qword ptr [74B3A249C420]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
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
       call      qword ptr [74B3A17EEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdi,[rbp-90]
       call      qword ptr [rax]
       lea       rdi,[rbp-88]
       call      qword ptr [74B3A17EEF08]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-30]
       call      qword ptr [74B3A17F0B98]
       lea       rdi,[rax+10]
       mov       rsi,[rbp-30]
       call      qword ptr [74B3A17EEEB8]; CORINFO_HELP_ASSIGN_REF
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
       cmp       byte ptr [74B3A0C5B06C],0
       jne       near ptr M04_L20
M04_L01:
       mov       rax,74A3E08013A0
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
       mov       rsi,74A3E08013A8
       mov       rbx,[rsi]
       cmp       byte ptr [rbx+38],0
       jne       near ptr M04_L12
M04_L04:
       test      r15b,1
       jne       short M04_L06
       mov       rdi,74B4202A0D68
       mov       rax,74B420B37820
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
       call      qword ptr [74B3A279F120]
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
       mov       rdi,74A3E08013D0
       mov       rbx,[rdi]
       lea       rdi,[rbx+160]
       lock inc  dword ptr [rdi]
       mov       rdi,rbx
       call      qword ptr [74B3A2796C40]; System.Threading.PortableThreadPool+WorkerThread.MaybeAddWorkingWorker(System.Threading.PortableThreadPool)
       cmp       dword ptr [rbx+164],6
       je        near ptr M04_L18
       jmp       near ptr M04_L16
M04_L10:
       mov       rsi,r15
       call      qword ptr [74B3A279EFE8]
       mov       rdi,[rbp-20]
       jmp       near ptr M04_L03
M04_L11:
       mov       rdi,offset MT_System.Threading.Tasks.ThreadPoolTaskScheduler
       call      qword ptr [74B3A1C45710]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdi,74A3E0801468
       mov       rbx,[rdi]
       mov       rdi,offset MT_System.Threading.Thread
       call      CORINFO_HELP_NEWFAST
       mov       r15,rax
       mov       rdi,r15
       mov       rsi,rbx
       call      qword ptr [74B3A279F960]
       mov       rdi,r15
       mov       esi,1
       call      qword ptr [74B3A2796E20]; System.Threading.Thread.set_IsBackground(Boolean)
       mov       rdi,r15
       mov       rsi,74B398C09F88
       call      qword ptr [74B3A2796F28]; System.Threading.Thread.set_Name(System.String)
       mov       rdi,r15
       mov       rsi,[rbp-20]
       xor       edx,edx
       call      qword ptr [74B3A279F978]
       jmp       near ptr M04_L18
M04_L12:
       mov       rsi,74A3E08013C0
       mov       rsi,[rsi]
       cmp       byte ptr [rsi+9D],0
       je        near ptr M04_L04
       mov       rsi,74A3E08013C0
       mov       rdi,[rsi]
       mov       rsi,[rbp-20]
       call      qword ptr [74B3A279F0F0]
       jmp       near ptr M04_L04
M04_L13:
       mov       edi,5
       call      qword ptr [74B3A279ED00]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M04_L05
M04_L14:
       mov       rdi,[rdi+18]
       mov       rsi,[rbp-20]
       cmp       [rdi],edi
       call      qword ptr [74B3A279F108]
       jmp       near ptr M04_L09
M04_L15:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M04_L16:
       mov       rdi,rbx
       call      qword ptr [74B3A2796EC8]; System.Threading.PortableThreadPool+GateThread.EnsureRunningSlow(System.Threading.PortableThreadPool)
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
       call      qword ptr [74B3A279F948]
       test      eax,eax
       mov       rdi,[rbp-20]
       jne       near ptr M04_L00
       jmp       short M04_L18
M04_L20:
       call      qword ptr [74B3A2797288]
       mov       rdi,[rbp-20]
       jmp       near ptr M04_L01
M04_L21:
       test      word ptr [rdi+34],200
       jne       near ptr M04_L02
       call      qword ptr [74B3A2797258]
       mov       r15d,eax
       mov       rdi,[rbp-20]
       mov       rdi,[rdi+8]
       call      qword ptr [74B3A279EF58]
       mov       rsi,rax
       mov       rdi,74B398C09F00
       call      qword ptr [74B3A1C4EFA0]; System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       esi,r15d
       mov       rdi,rbx
       xor       ecx,ecx
       call      qword ptr [74B3A2797270]
       mov       rdi,[rbp-20]
       jmp       near ptr M04_L02
       push      rax
       mov       rbx,rdi
       mov       rdi,offset MT_System.Threading.Tasks.TaskSchedulerException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdi,r15
       mov       rsi,rbx
       call      qword ptr [74B3A279EF70]
       mov       rdi,[rbp-20]
       mov       rsi,r15
       call      qword ptr [74B3A279EF88]
       mov       rdi,[rbp-20]
       xor       esi,esi
       call      qword ptr [74B3A279EFA0]
       mov       rdi,[rbp-20]
       call      qword ptr [74B3A279EFB8]
       test      eax,200
       jne       short M04_L22
       mov       rdi,[rbp-20]
       mov       rdi,[rdi+28]
       mov       rdi,[rdi+18]
       xor       esi,esi
       cmp       [rdi],edi
       call      qword ptr [74B3A279EFD0]
M04_L22:
       mov       rdi,r15
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 887
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
       jmp       qword ptr [74B3A2497A68]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
M05_L01:
       call      qword ptr [74B3A279E688]
       int       3
M05_L02:
       mov       rdi,rax
       mov       rsi,rdx
       pop       rbp
       jmp       near ptr 000074B4201FB900
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
       mov       rdi,74A3E08013A0
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
       jmp       near ptr M06_L06
M06_L01:
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
M06_L06:
       mov       rdi,[rbx+40]
       cmp       [rdi+8],eax
       jg        near ptr M06_L01
       test      r13,r13
       jne       near ptr M06_L20
       test      r12,r12
       jne       near ptr M06_L21
       cmp       byte ptr [r15+9D],0
       jne       near ptr M06_L22
M06_L07:
       cmp       byte ptr [74B3A0C5B06C],0
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
       mov       rsi,74A3E0800238
       mov       rsi,[rsi]
       call      000074B420074040
       test      rax,rax
       je        short M06_L11
       mov       rdi,rbx
       mov       rsi,rax
       call      qword ptr [74B3A2797828]; System.Threading.Tasks.Task.RunContinuations(System.Object)
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
       call      qword ptr [74B3A2797258]
       mov       esi,eax
       mov       rdi,r15
       mov       edx,1
       call      qword ptr [74B3A2797C48]
       jmp       near ptr M06_L00
M06_L13:
       test      r13,r13
       jne       short M06_L14
       mov       rdi,offset MT_System.Collections.Generic.List<System.Runtime.ExceptionServices.ExceptionDispatchInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdi,r13
       call      qword ptr [74B3A249EE50]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
       call      qword ptr [74B3A2496868]; System.GC.SuppressFinalize(System.Object)
       mov       rdi,[rbp-48]
       mov       byte ptr [rdi+20],1
M06_L15:
       mov       rdi,r13
       mov       rsi,[rbp-50]
       cmp       [rdi],edi
       call      qword ptr [74B3A2797DE0]
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
       call      qword ptr [74B3A27979A8]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
       mov       r8,[rbp-40]
       jmp       near ptr M06_L02
M06_L18:
       mov       rdi,r8
       mov       esi,1
       call      qword ptr [74B3A279F3C0]
       mov       r8,[rbp-40]
       jmp       near ptr M06_L03
M06_L19:
       mov       rdi,rbx
       mov       esi,1
       call      qword ptr [74B3A2797E40]
       jmp       near ptr M06_L05
M06_L20:
       mov       rdi,rbx
       mov       rsi,r13
       call      qword ptr [74B3A2797D20]
       jmp       near ptr M06_L11
M06_L21:
       mov       rdi,r12
       call      qword ptr [74B3A2797C60]
       mov       r13,rax
       mov       rdi,r12
       call      qword ptr [74B3A2797C78]
       mov       rdx,rax
       mov       rsi,r13
       mov       rdi,rbx
       call      qword ptr [74B3A2797C90]
       jmp       near ptr M06_L11
M06_L22:
       mov       rdi,rbx
       call      qword ptr [74B3A2797258]
       mov       esi,eax
       mov       rdi,r15
       mov       edx,1
       call      qword ptr [74B3A2797D38]
       jmp       near ptr M06_L07
M06_L23:
       mov       rdi,rbx
       call      qword ptr [74B3A2797D50]
       jmp       near ptr M06_L08
M06_L24:
       mov       rdi,rbx
       mov       esi,4000000
       mov       edx,5600000
       call      qword ptr [74B3A279EF28]
       test      eax,eax
       je        near ptr M06_L11
       jmp       near ptr M06_L09
M06_L25:
       mov       rdi,rbx
       call      qword ptr [74B3A279F3D8]
       mov       rdi,r12
       call      qword ptr [74B3A279F3F0]
       jmp       near ptr M06_L10
M06_L26:
       call      qword ptr [74B3A279E7C0]
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
       call      qword ptr [74B3A1806AF0]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       jne       near ptr M08_L08
       test      esi,1000000
       je        near ptr M08_L09
       mov       r14d,5
M08_L00:
       cmp       r14d,5
       jne       near ptr M08_L12
       mov       rdi,r15
       mov       rax,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task<System.Int32>>
       cmp       [rdi],rax
       jne       near ptr M08_L13
M08_L01:
       test      rdi,rdi
       je        short M08_L06
       mov       esi,[rdi+34]
       and       esi,11000000
       cmp       esi,1000000
       jne       near ptr M08_L15
       mov       rsi,[rdi+38]
M08_L02:
       test      rsi,rsi
       je        near ptr M08_L16
       test      dword ptr [rsi+34],1600000
       je        near ptr M08_L17
       mov       rdi,rbx
       xor       edx,edx
       call      qword ptr [74B3A2797948]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
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
       mov       rdi,r15
       mov       rax,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task>
       cmp       [rdi],rax
       jne       near ptr M08_L14
M08_L07:
       cmp       [rdi],edi
       call      qword ptr [74B3A2797A20]; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].get_Result()
       mov       rsi,rax
       jmp       short M08_L02
M08_L08:
       mov       r14d,6
       jmp       near ptr M08_L00
M08_L09:
       test      esi,800000
       je        short M08_L10
       mov       r14d,4
       jmp       near ptr M08_L00
M08_L10:
       test      esi,20000
       je        short M08_L11
       mov       r14d,3
       jmp       near ptr M08_L00
M08_L11:
       test      esi,2000000
       setne     r14b
       movzx     r14d,r14b
       mov       edi,2
       test      esi,10000
       cmovne    r14d,edi
       jmp       near ptr M08_L00
M08_L12:
       add       r14d,0FFFFFFFA
       cmp       r14d,1
       ja        near ptr M08_L04
       movzx     edx,byte ptr [rbx+3D]
       mov       rdi,rbx
       mov       rsi,r15
       call      qword ptr [74B3A2797948]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       jmp       near ptr M08_L04
M08_L13:
       mov       rsi,r15
       mov       rdi,rax
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M08_L01
M08_L14:
       mov       rsi,r15
       mov       rdi,rax
       call      qword ptr [74B3A2074AF8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M08_L07
M08_L15:
       mov       esi,1
       call      qword ptr [74B3A279F3A8]
       mov       rsi,rax
       jmp       near ptr M08_L02
M08_L16:
       mov       rdi,rbx
       xor       esi,esi
       xor       edx,edx
       call      qword ptr [74B3A2797C90]
       jmp       near ptr M08_L03
M08_L17:
       mov       rdi,rsi
       mov       rsi,rbx
       xor       edx,edx
       add       rsp,8
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [74B3A27972D0]; System.Threading.Tasks.Task.AddCompletionAction(System.Threading.Tasks.ITaskCompletionAction, Boolean)
; Total bytes of code 439
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
       mov       rsi,74A3E0800238
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
       call      qword ptr [74B3A249EE50]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
       call      qword ptr [74B3A1C472D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      qword ptr [74B3A1C472D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      qword ptr [74B3A1C472D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      qword ptr [74B3A1C472D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M09_L09:
       lea       rdi,[rbx+20]
       test      rdi,rdi
       jne       short M09_L10
       call      qword ptr [74B3A279E7C0]
       int       3
M09_L10:
       mov       rsi,r12
       mov       rdx,r13
       call      000074B420074060
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
       call      qword ptr [74B3A1C45980]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rdi,[rbx+20]
       mov       rax,74A3E0800238
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
       mov       rdi,74A3E0800290
       mov       rsi,[rdi]
       test      rsi,rsi
       jne       short M09_L13
       mov       rdi,offset MT_System.Predicate<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rsi,74A3E0800260
       mov       rsi,[rsi]
       mov       rdi,rbx
       mov       rdx,74B3A279B888
       call      qword ptr [74B3A1C46E08]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdi,74A3E0800290
       mov       rsi,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,rbx
M09_L13:
       mov       rdi,r12
       cmp       [rdi],edi
       call      qword ptr [74B3A279F8A0]
M09_L14:
       test      r14b,r14b
       je        short M09_L15
       mov       rdi,r12
       mov       rdx,r15
       xor       esi,esi
       call      qword ptr [74B3A1D36A30]
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
       call      qword ptr [74B3A1C472D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M09_L19
M09_L17:
       mov       rdi,r12
       call      qword ptr [74B3A1C46808]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [74B3A1C46808]; System.Threading.Monitor.Exit(System.Object)
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
       call      000074B4200F8300
       test      eax,eax
       je        near ptr M10_L19
       movzx     r14d,byte ptr [rbx+3C]
       test      r14d,r14d
       jne       near ptr M10_L08
       mov       byte ptr [rbx+3C],1
       mov       esi,[r15+34]
       test      esi,200000
       jne       near ptr M10_L05
       test      esi,400000
       jne       near ptr M10_L09
       test      esi,1000000
       je        near ptr M10_L10
       mov       r14d,5
M10_L00:
       cmp       r14d,5
       jne       near ptr M10_L13
       mov       rdi,r15
       mov       rax,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task<System.Int32>>
       cmp       [rdi],rax
       jne       near ptr M10_L14
M10_L01:
       test      rdi,rdi
       je        short M10_L06
       mov       esi,[rdi+34]
       and       esi,11000000
       cmp       esi,1000000
       jne       near ptr M10_L16
       mov       rsi,[rdi+38]
M10_L02:
       test      rsi,rsi
       je        near ptr M10_L17
       test      dword ptr [rsi+34],1600000
       je        near ptr M10_L18
       mov       rdi,rbx
       xor       edx,edx
       call      qword ptr [74B3A2797948]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
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
       mov       r14d,7
       jmp       short M10_L00
M10_L06:
       mov       rdi,r15
       mov       rax,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task>
       cmp       [rdi],rax
       jne       near ptr M10_L15
M10_L07:
       cmp       [rdi],edi
       call      qword ptr [74B3A2797A20]; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].get_Result()
       mov       rsi,rax
       jmp       short M10_L02
M10_L08:
       cmp       r14d,1
       jne       short M10_L04
       mov       rdi,rbx
       mov       rsi,r15
       xor       edx,edx
       call      qword ptr [74B3A2797948]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       jmp       short M10_L03
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
       add       r14d,0FFFFFFFA
       cmp       r14d,1
       ja        near ptr M10_L04
       movzx     edx,byte ptr [rbx+3D]
       mov       rdi,rbx
       mov       rsi,r15
       call      qword ptr [74B3A2797948]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       jmp       near ptr M10_L04
M10_L14:
       mov       rsi,r15
       mov       rdi,rax
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M10_L01
M10_L15:
       mov       rsi,r15
       mov       rdi,rax
       call      qword ptr [74B3A2074AF8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M10_L07
M10_L16:
       mov       esi,1
       call      qword ptr [74B3A279F3A8]
       mov       rsi,rax
       jmp       near ptr M10_L02
M10_L17:
       mov       rdi,rbx
       xor       esi,esi
       xor       edx,edx
       call      qword ptr [74B3A2797C90]
       jmp       near ptr M10_L03
M10_L18:
       mov       rdi,rsi
       mov       rsi,rbx
       xor       edx,edx
       add       rsp,8
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [74B3A27972D0]; System.Threading.Tasks.Task.AddCompletionAction(System.Threading.Tasks.ITaskCompletionAction, Boolean)
M10_L19:
       mov       rdi,rbx
       mov       rsi,r15
       add       rsp,8
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [74B3A2797930]
; Total bytes of code 510
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
       call      qword ptr [74B3A27979A8]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [74B3A279F690]
       jmp       short M11_L01
M11_L04:
       test      r15b,2
       jne       short M11_L05
       mov       rdi,rbx
       call      qword ptr [74B3A279F660]
M11_L05:
       mov       rdi,rbx
       call      qword ptr [74B3A279FB10]
       jmp       short M11_L02
; Total bytes of code 125
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: DefaultJob)

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
       mov       rdi,7760A8801350
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
       mov       rdi,7760A8801370
       mov       rax,[rdi]
       test      rax,rax
       je        near ptr M00_L29
M00_L02:
       cmp       [rax],al
       mov       rdi,7760A8801380
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
       mov       rdi,7770E80A0D68
       mov       rax,7770E8A02820
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
       call      qword ptr [77706A29C030]; System.Threading.Thread.InitializeCurrentThread()
M00_L04:
       mov       rax,[rax+8]
       test      rax,rax
       jne       near ptr M00_L31
       mov       rax,7760A8801390
       mov       rax,[rax]
M00_L05:
       test      rax,rax
       je        short M00_L07
       mov       rdi,7760A8801390
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
       call      qword ptr [77706A596880]; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
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
       mov       rdi,7770E80A0D68
       mov       rdx,7770E8A02820
       call      rdx
       cmp       dword ptr [rax],8
       jle       near ptr M00_L32
       mov       rdi,[rax+8]
       mov       rax,[rdi+40]
       test      rax,rax
       je        near ptr M00_L32
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
       jne       near ptr M00_L33
M00_L12:
       mov       rax,[rbp-38]
       mov       byte ptr [rax+3D],1
       mov       rdi,7760A88013A0
       mov       rdi,[rdi]
       cmp       byte ptr [rdi+9D],0
       jne       near ptr M00_L34
M00_L13:
       cmp       byte ptr [777068A5B06C],0
       jne       near ptr M00_L35
M00_L14:
       test      dword ptr [r12+34],1600000
       jne       near ptr M00_L40
       test      dword ptr [r12+34],1600000
       jne       near ptr M00_L36
       cmp       qword ptr [r12+20],0
       jne       short M00_L16
       lea       rdi,[r12+20]
       test      rdi,rdi
       je        near ptr M00_L49
       mov       rsi,rax
       xor       edx,edx
       call      00007770E7E74060
       test      rax,rax
       jne       near ptr M00_L37
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
       call      qword ptr [77706A59C108]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       short M00_L15
       jmp       near ptr M00_L38
M00_L17:
       mov       edi,2D
       call      qword ptr [777069A4F0D8]
       int       3
M00_L18:
       mov       rsi,r13
       test      rsi,rsi
       je        near ptr M00_L42
       lea       rbx,[rsi+10]
       mov       r15d,[rsi+8]
       test      r15d,r15d
       je        near ptr M00_L43
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
       call      qword ptr [77706A59FDE0]
       jmp       short M00_L20
M00_L19:
       mov       rsi,rbx
       call      00007770E7E70D90
       cmp       dword ptr [7770E80CEC80],0
       jne       near ptr M00_L44
M00_L20:
       mov       ebx,[r14+8]
       test      ebx,ebx
       jle       short M00_L22
       lea       rdi,[r14+10]
       mov       esi,ebx
M00_L21:
       cmp       qword ptr [rdi],0
       je        near ptr M00_L45
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
       mov       rdi,7760A88013A0
       mov       rdi,[rdi]
       cmp       byte ptr [rdi+9D],0
       jne       near ptr M00_L46
M00_L23:
       cmp       byte ptr [777068A5B06C],0
       jne       near ptr M00_L47
M00_L24:
       test      ebx,ebx
       jle       short M00_L27
       add       r14,10
M00_L25:
       mov       r13,[r14]
       test      dword ptr [r13+34],1600000
       jne       near ptr M00_L48
       test      dword ptr [r13+34],1600000
       jne       near ptr M00_L48
       cmp       qword ptr [r13+20],0
       jne       short M00_L28
       lea       rdi,[r13+20]
       test      rdi,rdi
       je        near ptr M00_L49
       mov       rsi,r15
       xor       edx,edx
       call      00007770E7E74060
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
       call      qword ptr [77706A59C108]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       short M00_L26
       jmp       near ptr M00_L48
M00_L29:
       mov       rdi,offset MT_System.Threading.Tasks.TaskFactory<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,7760A8801370
       xor       edx,edx
       call      00007770E7E74060
       test      rax,rax
       jne       near ptr M00_L02
       mov       rax,7760A8801370
       mov       rax,[rax]
       jmp       near ptr M00_L02
M00_L30:
       mov       edi,4
       call      qword ptr [77706A59F480]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L03
M00_L31:
       cmp       byte ptr [rax+18],0
       je        near ptr M00_L05
       xor       eax,eax
       jmp       near ptr M00_L05
M00_L32:
       mov       edi,8
       call      qword ptr [77706A59F480]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L09
M00_L33:
       mov       rdi,[rdi+30]
       test      rdi,rdi
       je        near ptr M00_L12
       test      cl,4
       je        near ptr M00_L12
       test      byte ptr [rdi+34],8
       jne       near ptr M00_L12
       call      qword ptr [77706A59F138]
       jmp       near ptr M00_L12
M00_L34:
       mov       rdi,rax
       call      qword ptr [77706A597270]
       mov       esi,eax
       mov       rdi,7760A88013A0
       mov       rdi,[rdi]
       mov       rdx,777060C0A878
       xor       ecx,ecx
       call      qword ptr [77706A597288]
       mov       rax,[rbp-38]
       jmp       near ptr M00_L13
M00_L35:
       mov       rdi,rax
       call      qword ptr [77706A5972A0]
       mov       rax,[rbp-38]
       jmp       near ptr M00_L14
M00_L36:
       jmp       short M00_L38
M00_L37:
       mov       rax,[rbp-38]
       jmp       near ptr M00_L16
M00_L38:
       call      00007770E7EF8300
       test      eax,eax
       je        short M00_L41
       mov       rax,[rbp-38]
       movzx     edi,byte ptr [rax+3C]
       test      edi,edi
       je        short M00_L40
       cmp       edi,1
       jne       short M00_L39
       mov       rdi,rax
       mov       rsi,r12
       xor       edx,edx
       call      qword ptr [77706A597F60]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       mov       r12,[rbp-38]
       mov       byte ptr [r12+3C],2
       jmp       near ptr M00_L15
M00_L39:
       jmp       near ptr M00_L15
M00_L40:
       mov       rdi,rax
       mov       rsi,r12
       call      qword ptr [77706A5972D0]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].ProcessCompletedOuterTask(System.Threading.Tasks.Task)
       jmp       near ptr M00_L15
M00_L41:
       mov       rdi,[rbp-38]
       mov       rsi,r12
       call      qword ptr [77706A597F18]
       jmp       near ptr M00_L15
M00_L42:
       mov       edi,33
       call      qword ptr [777069A4FAE0]
       int       3
M00_L43:
       mov       rdi,offset MT_System.Threading.Tasks.Task<System.Int32[]>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdi,r15
       xor       esi,esi
       mov       rdx,777060C0A1C8
       xor       ecx,ecx
       xor       r8d,r8d
       call      qword ptr [77706A597720]
       jmp       near ptr M00_L27
M00_L44:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L20
M00_L45:
       mov       edi,1D
       mov       esi,33
       call      qword ptr [77706A597750]
       int       3
M00_L46:
       mov       rdi,r15
       call      qword ptr [77706A597270]
       mov       esi,eax
       mov       rdi,7760A88013A0
       mov       rdi,[rdi]
       mov       rdx,777060C0AF08
       xor       ecx,ecx
       call      qword ptr [77706A597288]
       jmp       near ptr M00_L23
M00_L47:
       mov       rdi,r15
       call      qword ptr [77706A5972A0]
       jmp       near ptr M00_L24
M00_L48:
       mov       rdi,r15
       mov       rsi,r13
       call      qword ptr [77706A5DB888]; System.Threading.Tasks.Task+WhenAllPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
       jmp       near ptr M00_L26
M00_L49:
       call      qword ptr [77706A59F078]
       int       3
; Total bytes of code 1773
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
       jmp       qword ptr [77706A597918]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
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
       call      00007770E7E74060
       test      rax,rax
       jne       near ptr M02_L00
       mov       rdi,7760A8801418
       mov       rbx,[rdi]
       test      rbx,rbx
       je        near ptr M02_L28
M02_L04:
       call      qword ptr [77706A596838]; System.Threading.ExecutionContext.Capture()
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
       mov       rdi,7760A88013A8
       mov       rbx,[rdi]
       cmp       byte ptr [rbx+38],0
       jne       near ptr M02_L30
M02_L07:
       mov       r15,[rbx+8]
       mov       rdi,[r15+10]
       mov       rsi,r13
       cmp       [rdi],edi
       call      qword ptr [77706A596AD8]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       je        near ptr M02_L31
M02_L08:
       add       rbx,78
       mov       edi,1
       xchg      edi,[rbx]
       test      edi,edi
       jne       short M02_L09
       mov       rdi,7760A88013D0
       mov       rbx,[rdi]
       lea       rdi,[rbx+160]
       lock inc  dword ptr [rdi]
       mov       rdi,rbx
       call      qword ptr [77706A596C58]; System.Threading.PortableThreadPool+WorkerThread.MaybeAddWorkingWorker(System.Threading.PortableThreadPool)
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
       mov       rdi,7760A8801428
       mov       r14,[rdi]
       mov       rdi,7770E80A0D68
       mov       rax,7770E8A02820
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
       call      qword ptr [77706A29C030]; System.Threading.Thread.InitializeCurrentThread()
M02_L13:
       mov       rdi,[rax+8]
       test      rdi,rdi
       je        short M02_L14
       mov       rdi,[rdi+8]
       lea       rdx,[rbp-28]
       mov       rsi,r14
       mov       r11,777068A60580
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
       call      qword ptr [77706A59F480]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
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
       call      qword ptr [777069A46310]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
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
       mov       rsi,777060C0AF38
       call      qword ptr [77706A295248]
       mov       rdi,rbx
       call      qword ptr [77706A597A38]
       jmp       near ptr M02_L10
M02_L26:
       mov       rdi,[rbx+20]
       call      qword ptr [77706A596640]
       jmp       near ptr M02_L10
M02_L27:
       call      qword ptr [77706A59F078]
       int       3
M02_L28:
       mov       rdi,offset MT_System.Action<System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdi,7760A8801410
       mov       rsi,[rdi]
       lea       rdi,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset System.Threading.Tasks.AsyncLazy`1+<>c[[System.Int32, System.Private.CoreLib]].<GetOrStartAttemptAsync>b__11_0(Attempt<Int32>)
       mov       [rbx+18],rdi
       mov       rdi,7760A8801418
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
       call      qword ptr [77706A59FEE8]
       jmp       near ptr M02_L06
M02_L30:
       mov       rdi,7760A88013C0
       mov       rdi,[rdi]
       cmp       byte ptr [rdi+9D],0
       je        near ptr M02_L07
       mov       rdi,7760A88013C0
       mov       rdi,[rdi]
       mov       rsi,r13
       call      qword ptr [77706A59F468]
       jmp       near ptr M02_L07
M02_L31:
       mov       rdi,r15
       mov       rsi,r13
       call      qword ptr [77706A59F498]
       jmp       near ptr M02_L08
M02_L32:
       mov       rdi,rbx
       call      qword ptr [77706A596EC8]; System.Threading.PortableThreadPool+GateThread.EnsureRunningSlow(System.Threading.PortableThreadPool)
       jmp       near ptr M02_L09
; Total bytes of code 1010
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
       call      qword ptr [7770695EEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdi,[rbp-90]
       call      qword ptr [rax]
       lea       rdi,[rbp-88]
       call      qword ptr [7770695EEF08]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-30]
       call      qword ptr [7770695F0B98]
       lea       rdi,[rax+10]
       mov       rsi,[rbp-30]
       call      qword ptr [7770695EEEB8]; CORINFO_HELP_ASSIGN_REF
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
       cmp       byte ptr [777068A5B06C],0
       jne       near ptr M04_L20
M04_L01:
       mov       rax,7760A88013A0
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
       mov       rsi,7760A88013A8
       mov       rbx,[rsi]
       cmp       byte ptr [rbx+38],0
       jne       near ptr M04_L13
M04_L04:
       test      r15b,1
       jne       short M04_L06
       mov       rdi,7770E80A0D68
       mov       rax,7770E8A02820
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
       jne       near ptr M04_L10
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
       jmp       short M04_L09
M04_L08:
       mov       rdi,[rdi+18]
       mov       rsi,[rbp-20]
       cmp       [rdi],edi
       call      qword ptr [77706A59C6D8]; System.Threading.ThreadPoolWorkQueue+WorkStealingQueue.LocalPush(System.Object)
M04_L09:
       add       rbx,78
       mov       edi,1
       xchg      edi,[rbx]
       test      edi,edi
       jne       near ptr M04_L18
       mov       rdi,7760A88013D0
       mov       rbx,[rdi]
       lea       rdi,[rbx+160]
       lock inc  dword ptr [rdi]
       mov       rdi,rbx
       call      qword ptr [77706A596C58]; System.Threading.PortableThreadPool+WorkerThread.MaybeAddWorkingWorker(System.Threading.PortableThreadPool)
       cmp       dword ptr [rbx+164],6
       je        near ptr M04_L18
       jmp       near ptr M04_L16
M04_L10:
       test      eax,eax
       jge       near ptr M04_L07
       mov       rdi,rsi
       mov       rsi,[rbp-20]
       call      qword ptr [77706A59F498]
       jmp       short M04_L09
M04_L11:
       mov       rsi,r15
       call      qword ptr [77706A59F888]
       mov       rdi,[rbp-20]
       jmp       near ptr M04_L03
M04_L12:
       mov       rdi,offset MT_System.Threading.Tasks.ThreadPoolTaskScheduler
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdi,7760A8801488
       mov       rbx,[rdi]
       mov       rdi,offset MT_System.Threading.Thread
       call      CORINFO_HELP_NEWFAST
       mov       r15,rax
       mov       rdi,r15
       mov       rsi,rbx
       call      qword ptr [77706A654378]
       mov       rdi,r15
       mov       esi,1
       call      qword ptr [77706A596E38]; System.Threading.Thread.set_IsBackground(Boolean)
       mov       rdi,r15
       mov       rsi,777060C09FB0
       call      qword ptr [77706A596F40]; System.Threading.Thread.set_Name(System.String)
       mov       rdi,r15
       mov       rsi,[rbp-20]
       xor       edx,edx
       call      qword ptr [77706A654390]
       jmp       short M04_L18
M04_L13:
       mov       rsi,7760A88013C0
       mov       rsi,[rsi]
       cmp       byte ptr [rsi+9D],0
       je        near ptr M04_L04
       mov       rsi,7760A88013C0
       mov       rdi,[rsi]
       mov       rsi,[rbp-20]
       call      qword ptr [77706A59F468]
       jmp       near ptr M04_L04
M04_L14:
       mov       edi,5
       call      qword ptr [77706A59F480]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M04_L05
M04_L15:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M04_L16:
       mov       rdi,rbx
       call      qword ptr [77706A596EC8]; System.Threading.PortableThreadPool+GateThread.EnsureRunningSlow(System.Threading.PortableThreadPool)
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
       call      qword ptr [77706A654360]
       test      eax,eax
       mov       rdi,[rbp-20]
       jne       near ptr M04_L00
       jmp       short M04_L18
M04_L20:
       call      qword ptr [77706A5972A0]
       mov       rdi,[rbp-20]
       jmp       near ptr M04_L01
M04_L21:
       test      word ptr [rdi+34],200
       jne       near ptr M04_L02
       call      qword ptr [77706A597270]
       mov       r15d,eax
       mov       rdi,[rbp-20]
       mov       rdi,[rdi+8]
       call      qword ptr [77706A59F7F8]
       mov       rsi,rax
       mov       rdi,777060C09F28
       call      qword ptr [777069A4EFA0]; System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       esi,r15d
       mov       rdi,rbx
       xor       ecx,ecx
       call      qword ptr [77706A597288]
       mov       rdi,[rbp-20]
       jmp       near ptr M04_L02
       push      rax
       mov       rbx,rdi
       mov       rdi,offset MT_System.Threading.Tasks.TaskSchedulerException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdi,r15
       mov       rsi,rbx
       call      qword ptr [77706A59F810]
       mov       rdi,[rbp-20]
       mov       rsi,r15
       call      qword ptr [77706A59F828]
       mov       rdi,[rbp-20]
       xor       esi,esi
       call      qword ptr [77706A59F840]
       mov       rdi,[rbp-20]
       call      qword ptr [77706A59F858]
       test      eax,200
       jne       short M04_L22
       mov       rdi,[rbp-20]
       mov       rdi,[rdi+28]
       mov       rdi,[rdi+18]
       xor       esi,esi
       cmp       [rdi],edi
       call      qword ptr [77706A59F870]
M04_L22:
       mov       rdi,r15
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 884
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
       jmp       qword ptr [77706A297A68]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
M05_L00:
       mov       rdi,rax
       mov       rsi,rdx
       pop       rbp
       jmp       near ptr 00007770E7FFB900
M05_L01:
       xor       ecx,ecx
       mov       [rax],rcx
       pop       rbp
       ret
M05_L02:
       call      qword ptr [77706A59F048]
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
       mov       rsi,7760A8800238
       cmp       r13,[rsi]
       je        near ptr M06_L06
       mov       r12,r13
       test      r12,r12
       je        short M06_L00
       mov       rsi,offset MT_System.Threading.Tasks.UnwrapPromise<System.Int32>
       cmp       [r12],rsi
       jne       near ptr M06_L07
       xor       r12d,r12d
M06_L00:
       test      r12,r12
       jne       near ptr M06_L10
       mov       rdi,offset MT_System.Collections.Generic.List<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rdi,7760A8800AB0
       mov       rsi,[rdi]
       lea       rdi,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      r14b,r14b
       jne       short M06_L04
       inc       dword ptr [r12+14]
       mov       rdi,r12
       mov       rsi,r13
       call      qword ptr [777069A472D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      00007770E7E74060
       mov       r12,rax
       cmp       r12,r13
       jne       short M06_L05
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
       call      qword ptr [777069A472D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M06_L01
M06_L04:
       inc       dword ptr [r12+14]
       mov       rdi,r12
       mov       rsi,r15
       call      qword ptr [777069A472D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       jmp       short M06_L01
M06_L05:
       mov       rsi,r12
       mov       rdi,offset MT_System.Collections.Generic.List<System.Object>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r12,rax
       test      r12,r12
       jne       short M06_L10
M06_L06:
       xor       eax,eax
       add       rsp,18
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M06_L07:
       mov       rsi,r13
       mov       rdi,offset MT_System.Collections.Generic.List<System.Object>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r12,rax
       jmp       near ptr M06_L00
M06_L08:
       mov       rdi,r12
       mov       rsi,r13
       call      qword ptr [777069A472D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M06_L01
M06_L09:
       call      qword ptr [77706A59F078]
       int       3
M06_L10:
       mov       [rbp-40],r12
       xor       esi,esi
       mov       [rbp-30],esi
       lea       rsi,[rbp-30]
       mov       rdi,r12
       call      qword ptr [777069A45980]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rdi,[rbx+20]
       mov       rax,7760A8800238
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
       mov       rdi,7760A8800290
       mov       rsi,[rdi]
       test      rsi,rsi
       jne       short M06_L12
       mov       rdi,offset MT_System.Predicate<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rsi,7760A8800260
       mov       rsi,[rsi]
       mov       rdi,rbx
       mov       rdx,77706A650198
       call      qword ptr [777069A46E08]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdi,7760A8800290
       mov       rsi,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,rbx
M06_L12:
       mov       rdi,r12
       cmp       [rdi],edi
       call      qword ptr [77706A6541B0]
M06_L13:
       test      r14b,r14b
       je        short M06_L14
       mov       rdi,r12
       mov       rdx,r15
       xor       esi,esi
       call      qword ptr [777069B36A30]
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
       call      qword ptr [777069A472D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M06_L18
M06_L16:
       mov       rdi,r12
       call      qword ptr [777069A46808]; System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [777069A46808]; System.Threading.Monitor.Exit(System.Object)
M06_L21:
       nop
       add       rsp,8
       ret
; Total bytes of code 724
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbp
       push      rbx
       push      rax
       lea       rbp,[rsp+10]
       mov       ebx,edi
       call      qword ptr [777069606AF0]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
M08_L00:
       mov       rdi,7760A88013A0
       mov       r13,[rdi]
       cmp       byte ptr [r13+9D],0
       jne       near ptr M08_L12
M08_L01:
       xor       eax,eax
       mov       edi,[r15+34]
       test      edi,200000
       jne       near ptr M08_L13
       test      edi,400000
       jne       near ptr M08_L14
       test      edi,1000000
       je        near ptr M08_L15
       mov       ecx,5
M08_L02:
       add       ecx,0FFFFFFFB
       jne       near ptr M08_L18
       cmp       byte ptr [r13+9D],0
       jne       near ptr M08_L20
M08_L03:
       cmp       byte ptr [777068A5B06C],0
       jne       near ptr M08_L21
M08_L04:
       mov       rdi,r15
       mov       rax,offset MT_System.Threading.Tasks.Task<System.Int32>
       cmp       [rdi],rax
       jne       near ptr M08_L22
M08_L05:
       test      rdi,rdi
       je        near ptr M08_L23
       mov       esi,[rdi+34]
       and       esi,11000000
       cmp       esi,1000000
       jne       near ptr M08_L24
       mov       r15d,[rdi+38]
M08_L06:
       xor       r14d,r14d
       mov       eax,[rbx+34]
       mov       [rbp-24],eax
       test      eax,5600000
       jne       short M08_L10
       lea       rdi,[rbx+34]
       mov       esi,eax
       or        esi,4000000
       lock cmpxchg [rdi],esi
       cmp       eax,[rbp-24]
       jne       near ptr M08_L25
M08_L07:
       mov       [rbx+38],r15d
       lea       rdi,[rbx+34]
       mov       eax,[rbx+34]
       or        eax,1000000
       xchg      eax,[rdi]
       mov       r14,[rbx+28]
       test      r14,r14
       jne       near ptr M08_L26
M08_L08:
       lea       rdi,[rbx+20]
       test      rdi,rdi
       je        near ptr M08_L27
       mov       rsi,7760A8800238
       mov       rsi,[rsi]
       call      00007770E7E74040
       test      rax,rax
       je        short M08_L09
       mov       rdi,rbx
       mov       rsi,rax
       call      qword ptr [77706A597E70]; System.Threading.Tasks.Task.RunContinuations(System.Object)
M08_L09:
       mov       r14d,1
M08_L10:
       mov       eax,r14d
M08_L11:
       add       rsp,10
       pop       rbx
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M08_L12:
       mov       rdi,rbx
       call      qword ptr [77706A597270]
       mov       esi,eax
       mov       rdi,r13
       mov       edx,1
       call      qword ptr [77706A59C720]
       jmp       near ptr M08_L01
M08_L13:
       mov       ecx,7
       jmp       near ptr M08_L02
M08_L14:
       mov       ecx,6
       jmp       near ptr M08_L02
M08_L15:
       test      edi,800000
       je        short M08_L16
       mov       ecx,4
       jmp       near ptr M08_L02
M08_L16:
       test      edi,20000
       je        short M08_L17
       mov       ecx,3
       jmp       near ptr M08_L02
M08_L17:
       test      edi,2000000
       setne     cl
       movzx     ecx,cl
       mov       edx,2
       test      edi,10000
       cmovne    ecx,edx
       jmp       near ptr M08_L02
M08_L18:
       cmp       ecx,2
       ja        near ptr M08_L11
       mov       edi,ecx
       lea       rax,[777069ACEF20]
       mov       eax,[rax+rdi*4]
       lea       rcx,[M08_L00]
       add       rax,rcx
       jmp       rax
       mov       rdi,r15
       call      qword ptr [77706A59C738]
       mov       r14,rax
       mov       rdi,r15
       call      qword ptr [77706A59C750]
       mov       rdx,rax
       mov       rsi,r14
       mov       rdi,rbx
       call      qword ptr [77706A59C768]
       jmp       near ptr M08_L11
       mov       rdi,r15
       call      qword ptr [77706A59C780]
       mov       r15,rax
       test      r14b,r14b
       je        short M08_L19
       cmp       dword ptr [r15+10],0
       jle       short M08_L19
       mov       rdi,r15
       xor       esi,esi
       call      qword ptr [777069B369B8]
       mov       r13,rax
       test      r13,r13
       je        short M08_L19
       mov       rsi,[r13+8]
       mov       rdi,offset MT_System.OperationCanceledException
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M08_L19
       mov       rsi,[rax+70]
       mov       rdi,rbx
       mov       rdx,r13
       call      qword ptr [77706A59C768]
       jmp       near ptr M08_L11
M08_L19:
       mov       rdi,rbx
       mov       rsi,r15
       call      qword ptr [77706A59C7F8]
       jmp       near ptr M08_L11
M08_L20:
       mov       rdi,rbx
       call      qword ptr [77706A597270]
       mov       esi,eax
       mov       rdi,r13
       mov       edx,1
       call      qword ptr [77706A59C810]
       jmp       near ptr M08_L03
M08_L21:
       mov       rdi,rbx
       call      qword ptr [77706A59C828]
       jmp       near ptr M08_L04
M08_L22:
       mov       rsi,r15
       mov       rdi,rax
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M08_L05
M08_L23:
       xor       r15d,r15d
       jmp       near ptr M08_L06
M08_L24:
       mov       esi,1
       call      qword ptr [77706A59C8A0]; System.Threading.Tasks.Task`1[[System.Int32, System.Private.CoreLib]].GetResultCore(Boolean)
       mov       r15d,eax
       jmp       near ptr M08_L06
M08_L25:
       mov       rdi,rbx
       mov       esi,4000000
       mov       edx,5600000
       call      qword ptr [77706A59F720]
       test      eax,eax
       je        near ptr M08_L10
       jmp       near ptr M08_L07
M08_L26:
       mov       rdi,rbx
       call      qword ptr [77706A59F738]
       mov       rdi,r14
       call      qword ptr [77706A59F750]
       jmp       near ptr M08_L08
M08_L27:
       call      qword ptr [77706A59F078]
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
       jne       near ptr M09_L07
       test      esi,400000
       jne       near ptr M09_L08
       test      esi,1000000
       je        near ptr M09_L09
       mov       r14d,5
M09_L00:
       cmp       r14d,5
       jne       near ptr M09_L12
       mov       rdi,r15
       mov       rax,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task<System.Int32>>
       cmp       [rdi],rax
       jne       near ptr M09_L13
M09_L01:
       test      rdi,rdi
       je        near ptr M09_L14
       mov       esi,[rdi+34]
       and       esi,11000000
       cmp       esi,1000000
       jne       near ptr M09_L16
       mov       r14,[rdi+38]
M09_L02:
       test      r14,r14
       je        near ptr M09_L17
       test      dword ptr [r14+34],1600000
       jne       short M09_L05
       test      dword ptr [r14+34],1600000
       jne       near ptr M09_L19
       cmp       qword ptr [r14+20],0
       jne       short M09_L04
       lea       rdi,[r14+20]
       test      rdi,rdi
       je        near ptr M09_L18
       mov       rsi,rbx
       xor       edx,edx
       call      00007770E7E74060
       test      rax,rax
       jne       short M09_L04
M09_L03:
       add       rsp,8
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       ret
M09_L04:
       mov       rdi,r14
       mov       rsi,rbx
       xor       edx,edx
       call      qword ptr [77706A59C108]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       short M09_L03
       jmp       near ptr M09_L19
M09_L05:
       mov       rdi,rbx
       mov       rsi,r14
       xor       edx,edx
       call      qword ptr [77706A597F60]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
M09_L06:
       mov       byte ptr [rbx+3C],2
       jmp       short M09_L03
M09_L07:
       mov       r14d,7
       jmp       near ptr M09_L00
M09_L08:
       mov       r14d,6
       jmp       near ptr M09_L00
M09_L09:
       test      esi,800000
       je        short M09_L10
       mov       r14d,4
       jmp       near ptr M09_L00
M09_L10:
       test      esi,20000
       je        short M09_L11
       mov       r14d,3
       jmp       near ptr M09_L00
M09_L11:
       test      esi,2000000
       setne     r14b
       movzx     r14d,r14b
       mov       edi,2
       test      esi,10000
       cmovne    r14d,edi
       jmp       near ptr M09_L00
M09_L12:
       add       r14d,0FFFFFFFA
       cmp       r14d,1
       ja        near ptr M09_L03
       movzx     edx,byte ptr [rbx+3D]
       mov       rdi,rbx
       mov       rsi,r15
       call      qword ptr [77706A597F60]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       jmp       near ptr M09_L03
M09_L13:
       mov       rsi,r15
       mov       rdi,rax
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M09_L01
M09_L14:
       mov       rdi,r15
       mov       rax,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task>
       cmp       [rdi],rax
       je        short M09_L15
       mov       rsi,r15
       mov       rdi,rax
       call      qword ptr [777069E74AF8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rdi,rax
M09_L15:
       cmp       [rdi],edi
       call      qword ptr [77706A59C000]; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].get_Result()
       mov       r14,rax
       jmp       near ptr M09_L02
M09_L16:
       mov       esi,1
       call      qword ptr [77706A59FBE8]
       mov       r14,rax
       jmp       near ptr M09_L02
M09_L17:
       mov       rdi,rbx
       xor       esi,esi
       xor       edx,edx
       call      qword ptr [77706A59C768]
       jmp       near ptr M09_L06
M09_L18:
       call      qword ptr [77706A59F078]
       int       3
M09_L19:
       mov       rdi,rbx
       mov       rsi,r14
       add       rsp,8
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [77706A5CE520]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
; Total bytes of code 519
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
       mov       rdi,7760A88013A0
       mov       r15,[rdi]
       cmp       byte ptr [r15+9D],0
       jne       near ptr M10_L12
M10_L00:
       lea       rsi,[rbx+48]
       mov       edi,0FFFFFFFF
       lock xadd [rsi],edi
       dec       edi
       jne       near ptr M10_L11
       mov       rsi,[rbx+40]
       mov       esi,[rsi+8]
       mov       rdi,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       xor       r13d,r13d
       xor       r12d,r12d
       xor       eax,eax
M10_L01:
       mov       rdi,[rbx+40]
       cmp       [rdi+8],eax
       jle       near ptr M10_L06
       cmp       eax,[rdi+8]
       jae       near ptr M10_L27
       mov       [rbp-2C],eax
       mov       ecx,eax
       mov       [rbp-38],rcx
       mov       r8,[rdi+rcx*8+10]
       mov       [rbp-40],r8
       test      dword ptr [r8+34],200000
       jne       near ptr M10_L13
       mov       edi,[r8+34]
       and       edi,600000
       cmp       edi,400000
       je        near ptr M10_L16
       test      dword ptr [r8+34],1600000
       je        near ptr M10_L17
M10_L02:
       mov       edi,[r8+34]
       and       edi,1600000
       cmp       edi,1000000
       jne       near ptr M10_L18
M10_L03:
       mov       edi,[r8+38]
       mov       eax,[rbp-2C]
       cmp       eax,[r14+8]
       jae       near ptr M10_L27
       mov       rcx,[rbp-38]
       mov       [r14+rcx*4+10],edi
M10_L04:
       test      dword ptr [r8+34],10000000
       jne       near ptr M10_L19
       mov       rdi,[rbx+40]
       mov       eax,[rbp-2C]
       cmp       eax,[rdi+8]
       jae       near ptr M10_L27
       xor       esi,esi
       mov       rcx,[rbp-38]
       mov       [rdi+rcx*8+10],rsi
M10_L05:
       mov       eax,[rbp-2C]
       inc       eax
       jmp       near ptr M10_L01
M10_L06:
       test      r13,r13
       jne       near ptr M10_L20
       test      r12,r12
       jne       near ptr M10_L21
       cmp       byte ptr [r15+9D],0
       jne       near ptr M10_L22
M10_L07:
       cmp       byte ptr [777068A5B06C],0
       jne       near ptr M10_L23
M10_L08:
       mov       eax,[rbx+34]
       mov       [rbp-30],eax
       test      eax,5600000
       jne       short M10_L11
       lea       rdi,[rbx+34]
       mov       esi,eax
       or        esi,4000000
       lock cmpxchg [rdi],esi
       cmp       eax,[rbp-30]
       jne       near ptr M10_L24
M10_L09:
       lea       rdi,[rbx+38]
       mov       rsi,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdi,[rbx+34]
       mov       eax,[rbx+34]
       or        eax,1000000
       xchg      eax,[rdi]
       mov       r12,[rbx+28]
       test      r12,r12
       jne       near ptr M10_L25
M10_L10:
       lea       rdi,[rbx+20]
       test      rdi,rdi
       je        near ptr M10_L26
       mov       rsi,7760A8800238
       mov       rsi,[rsi]
       call      00007770E7E74040
       test      rax,rax
       je        short M10_L11
       mov       rdi,rbx
       mov       rsi,rax
       call      qword ptr [77706A597E70]; System.Threading.Tasks.Task.RunContinuations(System.Object)
M10_L11:
       nop
       add       rsp,28
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M10_L12:
       mov       rdi,rbx
       call      qword ptr [77706A597270]
       mov       esi,eax
       mov       rdi,r15
       mov       edx,1
       call      qword ptr [77706A59C720]
       jmp       near ptr M10_L00
M10_L13:
       test      r13,r13
       jne       short M10_L14
       mov       rdi,offset MT_System.Collections.Generic.List<System.Runtime.ExceptionServices.ExceptionDispatchInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdi,r13
       call      qword ptr [77706A29EE50]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       r8,[rbp-40]
M10_L14:
       mov       rdi,[r8+28]
       mov       rdx,[rdi+18]
       mov       [rbp-48],rdx
       mov       rsi,[rdx+10]
       mov       [rbp-50],rsi
       cmp       byte ptr [rdx+20],0
       jne       short M10_L15
       mov       rdi,rdx
       call      qword ptr [77706A296868]; System.GC.SuppressFinalize(System.Object)
       mov       rdi,[rbp-48]
       mov       byte ptr [rdi+20],1
M10_L15:
       mov       rdi,r13
       mov       rsi,[rbp-50]
       cmp       [rdi],edi
       call      qword ptr [77706A59C888]
       mov       r8,[rbp-40]
       jmp       near ptr M10_L04
M10_L16:
       test      r12,r12
       jne       near ptr M10_L04
       mov       r12,r8
       mov       r8,[rbp-40]
       jmp       near ptr M10_L04
M10_L17:
       mov       rdi,r8
       mov       esi,0FFFFFFFF
       xor       edx,edx
       call      qword ptr [77706A597930]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
       mov       r8,[rbp-40]
       jmp       near ptr M10_L02
M10_L18:
       mov       rdi,r8
       mov       esi,1
       call      qword ptr [77706A654348]
       mov       r8,[rbp-40]
       jmp       near ptr M10_L03
M10_L19:
       mov       edi,[rbx+34]
       test      edi,5600000
       jne       near ptr M10_L05
       lea       rsi,[rbx+34]
       mov       edx,edi
       or        edx,10000000
       mov       eax,edi
       lock cmpxchg [rsi],edx
       cmp       eax,edi
       je        near ptr M10_L05
       mov       rdi,rbx
       mov       esi,10000000
       mov       edx,5600000
       call      qword ptr [77706A59F720]
       jmp       near ptr M10_L05
M10_L20:
       mov       rdi,rbx
       mov       rsi,r13
       call      qword ptr [77706A59C7F8]
       jmp       near ptr M10_L11
M10_L21:
       mov       rdi,r12
       call      qword ptr [77706A59C738]
       mov       r13,rax
       mov       rdi,r12
       call      qword ptr [77706A59C750]
       mov       rdx,rax
       mov       rsi,r13
       mov       rdi,rbx
       call      qword ptr [77706A59C768]
       jmp       near ptr M10_L11
M10_L22:
       mov       rdi,rbx
       call      qword ptr [77706A597270]
       mov       esi,eax
       mov       rdi,r15
       mov       edx,1
       call      qword ptr [77706A59C810]
       jmp       near ptr M10_L07
M10_L23:
       mov       rdi,rbx
       call      qword ptr [77706A59C828]
       jmp       near ptr M10_L08
M10_L24:
       mov       rdi,rbx
       mov       esi,4000000
       mov       edx,5600000
       call      qword ptr [77706A59F720]
       test      eax,eax
       je        near ptr M10_L11
       jmp       near ptr M10_L09
M10_L25:
       mov       rdi,rbx
       call      qword ptr [77706A59F738]
       mov       rdi,r12
       call      qword ptr [77706A59F750]
       jmp       near ptr M10_L10
M10_L26:
       call      qword ptr [77706A59F078]
       int       3
M10_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 915
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
       call      qword ptr [77706A597930]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [77706A654180]
       jmp       short M11_L01
M11_L04:
       test      r15b,2
       jne       short M11_L05
       mov       rdi,rbx
       call      qword ptr [77706A59FE10]
M11_L05:
       mov       rdi,rbx
       call      qword ptr [77706A6544E0]
       jmp       short M11_L02
; Total bytes of code 125
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: DefaultJob)

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
       mov       rdi,7F48BC801350
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
       mov       rdi,offset AsyncLazyBenchmarks.ContendedFirstCallBenchmarks+<>c__DisplayClass10_0.<Nito>b__0()
       mov       [r12+18],rdi
       lea       rdi,[r15+10]
       mov       rsi,r12
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       mov       rdi,7F48BC801370
       mov       rax,[rdi]
       test      rax,rax
       je        near ptr M00_L29
M00_L02:
       cmp       [rax],al
       mov       rdi,7F48BC801380
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
       mov       rdi,7F58FF0A0D68
       mov       rax,7F58FF946820
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
       call      qword ptr [7F588129C030]; System.Threading.Thread.InitializeCurrentThread()
M00_L04:
       mov       rax,[rax+8]
       test      rax,rax
       jne       short M00_L08
       mov       rax,7F48BC801390
       mov       rax,[rax]
M00_L05:
       test      rax,rax
       jne       short M00_L09
       or        dword ptr [r12+34],20000000
M00_L06:
       mov       rdi,r12
       xor       esi,esi
       call      qword ptr [7F58815968F8]; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
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
       call      qword ptr [7F5880A4F0D8]
       int       3
M00_L08:
       cmp       byte ptr [rax+18],0
       je        short M00_L05
       xor       eax,eax
       jmp       short M00_L05
M00_L09:
       mov       rdi,7F48BC801390
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
       mov       rdi,7F58FF0A0D68
       mov       rdx,7F58FF946820
       call      rdx
       cmp       dword ptr [rax],8
       jle       near ptr M00_L31
       mov       rdi,[rax+8]
       mov       rax,[rdi+40]
       test      rax,rax
       je        near ptr M00_L31
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
       jne       near ptr M00_L32
M00_L15:
       mov       rax,[rbp-38]
       mov       byte ptr [rax+3D],1
       mov       rdi,7F48BC8013A0
       mov       rdi,[rdi]
       cmp       byte ptr [rdi+9D],0
       jne       near ptr M00_L33
M00_L16:
       cmp       byte ptr [7F587FA5B06C],0
       jne       near ptr M00_L34
M00_L17:
       test      dword ptr [r12+34],1600000
       jne       near ptr M00_L40
       test      dword ptr [r12+34],1600000
       jne       near ptr M00_L35
       cmp       qword ptr [r12+20],0
       jne       near ptr M00_L37
       lea       rdi,[r12+20]
       test      rdi,rdi
       je        near ptr M00_L50
       mov       rsi,rax
       xor       edx,edx
       call      00007F58FEE74060
       test      rax,rax
       jne       near ptr M00_L36
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
       je        near ptr M00_L42
       lea       rbx,[rsi+10]
       mov       r15d,[rsi+8]
       test      r15d,r15d
       je        near ptr M00_L43
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
       call      qword ptr [7F588159F7C8]
       jmp       short M00_L21
M00_L20:
       mov       rsi,rbx
       call      00007F58FEE70D90
       cmp       dword ptr [7F58FF0CEC80],0
       jne       near ptr M00_L44
M00_L21:
       mov       ebx,[r14+8]
       test      ebx,ebx
       jle       short M00_L23
       lea       rdi,[r14+10]
       mov       esi,ebx
M00_L22:
       cmp       qword ptr [rdi],0
       je        near ptr M00_L45
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
       mov       rdi,7F48BC8013A0
       mov       rdi,[rdi]
       cmp       byte ptr [rdi+9D],0
       jne       near ptr M00_L46
M00_L24:
       cmp       byte ptr [7F587FA5B06C],0
       jne       near ptr M00_L47
M00_L25:
       xor       r13d,r13d
       test      ebx,ebx
       jle       short M00_L28
M00_L26:
       mov       rbx,[r14+r13*8+10]
       test      dword ptr [rbx+34],1600000
       jne       near ptr M00_L49
       test      dword ptr [rbx+34],1600000
       jne       near ptr M00_L49
       cmp       qword ptr [rbx+20],0
       jne       near ptr M00_L48
       lea       rdi,[rbx+20]
       test      rdi,rdi
       je        near ptr M00_L50
       mov       rsi,r15
       xor       edx,edx
       call      00007F58FEE74060
       test      rax,rax
       jne       near ptr M00_L48
M00_L27:
       inc       r13d
       mov       ebx,[r14+8]
       cmp       ebx,r13d
       jg        short M00_L26
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
       mov       rdi,offset MT_System.Threading.Tasks.TaskFactory<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,7F48BC801370
       xor       edx,edx
       call      00007F58FEE74060
       test      rax,rax
       jne       near ptr M00_L02
       mov       rax,7F48BC801370
       mov       rax,[rax]
       jmp       near ptr M00_L02
M00_L30:
       mov       edi,4
       call      qword ptr [7F588159EE50]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L03
M00_L31:
       mov       edi,8
       call      qword ptr [7F588159EE50]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L12
M00_L32:
       mov       rdi,[rdi+30]
       test      rdi,rdi
       je        near ptr M00_L15
       test      cl,4
       je        near ptr M00_L15
       test      byte ptr [rdi+34],8
       jne       near ptr M00_L15
       call      qword ptr [7F588159E940]
       jmp       near ptr M00_L15
M00_L33:
       mov       rdi,rax
       call      qword ptr [7F5881597240]
       mov       esi,eax
       mov       rdi,7F48BC8013A0
       mov       rdi,[rdi]
       mov       rdx,7F4897C0A850
       xor       ecx,ecx
       call      qword ptr [7F5881597258]
       mov       rax,[rbp-38]
       jmp       near ptr M00_L16
M00_L34:
       mov       rdi,rax
       call      qword ptr [7F5881597270]
       mov       rax,[rbp-38]
       jmp       near ptr M00_L17
M00_L35:
       jmp       short M00_L38
M00_L36:
       mov       rax,[rbp-38]
M00_L37:
       mov       rdi,r12
       mov       rsi,rax
       xor       edx,edx
       call      qword ptr [7F5881597DC8]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M00_L18
M00_L38:
       call      00007F58FEEF8300
       test      eax,eax
       je        short M00_L41
       mov       rax,[rbp-38]
       movzx     edi,byte ptr [rax+3C]
       test      edi,edi
       je        short M00_L40
       cmp       edi,1
       jne       short M00_L39
       mov       rdi,rax
       mov       rsi,r12
       xor       edx,edx
       call      qword ptr [7F5881597D20]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       mov       r12,[rbp-38]
       mov       byte ptr [r12+3C],2
       jmp       near ptr M00_L18
M00_L39:
       jmp       near ptr M00_L18
M00_L40:
       mov       rdi,rax
       mov       rsi,r12
       call      qword ptr [7F58815972A0]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].ProcessCompletedOuterTask(System.Threading.Tasks.Task)
       jmp       near ptr M00_L18
M00_L41:
       mov       rdi,[rbp-38]
       mov       rsi,r12
       call      qword ptr [7F5881597CD8]
       jmp       near ptr M00_L18
M00_L42:
       mov       edi,33
       call      qword ptr [7F5880A4FAE0]
       int       3
M00_L43:
       mov       rdi,offset MT_System.Threading.Tasks.Task<System.Int32[]>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdi,r15
       xor       esi,esi
       mov       rdx,7F4897C0A1A0
       xor       ecx,ecx
       xor       r8d,r8d
       call      qword ptr [7F58815976F0]
       jmp       near ptr M00_L28
M00_L44:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L21
M00_L45:
       mov       edi,1D
       mov       esi,33
       call      qword ptr [7F5881597720]
       int       3
M00_L46:
       mov       rdi,r15
       call      qword ptr [7F5881597240]
       mov       esi,eax
       mov       rdi,7F48BC8013A0
       mov       rdi,[rdi]
       mov       rdx,7F4897C0AEE0
       xor       ecx,ecx
       call      qword ptr [7F5881597258]
       jmp       near ptr M00_L24
M00_L47:
       mov       rdi,r15
       call      qword ptr [7F5881597270]
       jmp       near ptr M00_L25
M00_L48:
       mov       rdi,rbx
       mov       rsi,r15
       xor       edx,edx
       call      qword ptr [7F5881597DC8]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M00_L27
M00_L49:
       mov       rdi,r15
       mov       rsi,rbx
       call      qword ptr [7F58815DC7F8]; System.Threading.Tasks.Task+WhenAllPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
       jmp       near ptr M00_L27
M00_L50:
       call      qword ptr [7F588159E8C8]
       int       3
; Total bytes of code 1967
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
       jmp       qword ptr [7F5881597918]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
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
       je        near ptr M02_L16
       mov       r15,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task<System.Int32>>
       mov       rdi,r15
       call      qword ptr [7F5881596700]; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].get_Factory()
       cmp       [rax],al
       mov       rdi,7F48BC801380
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
       mov       rdi,7F58FF0A0D68
       mov       rax,7F58FF946820
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
       call      qword ptr [7F588129C030]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       rbx,[rax+8]
       test      rbx,rbx
       je        short M02_L02
       xor       edi,edi
       cmp       byte ptr [rbx+18],0
       cmovne    rbx,rdi
       jmp       short M02_L03
M02_L02:
       mov       rdi,7F48BC801390
       mov       rbx,[rdi]
M02_L03:
       test      rbx,rbx
       je        short M02_L05
       mov       rdi,7F48BC801390
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
       call      qword ptr [7F58815968F8]; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
       mov       rdi,offset MT_System.Threading.Tasks.UnwrapPromise<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       movzx     r14d,word ptr [r15+34]
       and       r14d,4
       test      r14d,0FFFFFFBB
       jne       near ptr M02_L14
       test      r14b,4
       je        short M02_L09
       mov       rdi,7F58FF0A0D68
       mov       rax,7F58FF946820
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
       mov       rdi,7F48BC8013A0
       mov       rdi,[rdi]
       cmp       byte ptr [rdi+9D],0
       jne       near ptr M02_L19
M02_L11:
       cmp       byte ptr [7F587FA5B06C],0
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
       call      00007F58FEE74060
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
       call      qword ptr [7F5880A4F0D8]
       int       3
M02_L15:
       mov       edi,4
       call      qword ptr [7F588159EE50]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M02_L00
M02_L16:
       mov       edi,2E
       call      qword ptr [7F5880A4FAE0]
       int       3
M02_L17:
       mov       edi,8
       call      qword ptr [7F588159EE50]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M02_L07
M02_L18:
       mov       rdi,[rdi+30]
       test      rdi,rdi
       je        near ptr M02_L10
       test      r14b,4
       je        near ptr M02_L10
       test      byte ptr [rdi+34],8
       jne       near ptr M02_L10
       call      qword ptr [7F588159E940]
       jmp       near ptr M02_L10
M02_L19:
       mov       rdi,rbx
       call      qword ptr [7F5881597240]
       mov       esi,eax
       mov       rdi,7F48BC8013A0
       mov       rdi,[rdi]
       mov       rdx,7F4897C0A850
       xor       ecx,ecx
       call      qword ptr [7F5881597258]
       jmp       near ptr M02_L11
M02_L20:
       mov       rdi,rbx
       call      qword ptr [7F5881597270]
       jmp       near ptr M02_L12
M02_L21:
       mov       rdi,rbx
       mov       rsi,r15
       call      qword ptr [7F58815972A0]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].ProcessCompletedOuterTask(System.Threading.Tasks.Task)
       jmp       near ptr M02_L13
M02_L22:
       call      qword ptr [7F588159E8C8]
       int       3
M02_L23:
       mov       rdi,r15
       mov       rsi,rbx
       xor       edx,edx
       call      qword ptr [7F5881597DC8]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M02_L13
M02_L24:
       mov       rdi,rbx
       mov       rsi,r15
       call      qword ptr [7F58815CF6C8]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
       jmp       near ptr M02_L13
; Total bytes of code 893
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
       call      00007F58FECE6020
       test      eax,eax
       je        short M03_L03
M03_L00:
       mov       dword ptr [rbp-0C],1
       mov       rdi,[rbx+18]
       cmp       qword ptr [rdi+8],0
       je        short M03_L01
       call      qword ptr [7F588129C420]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rbx,rax
       jmp       short M03_L04
M03_L01:
       mov       rbx,[rdi+18]
       jmp       short M03_L04
M03_L02:
       xor       edi,edi
       call      qword ptr [7F588159ED78]
       int       3
M03_L03:
       mov       rdi,[rbp-18]
       call      qword ptr [7F58815978E8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M03_L00
M03_L04:
       mov       rdi,[rbp-18]
       call      00007F58FECE6790
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
       call      qword ptr [7F5881597A50]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       short M03_L05
       push      rax
       cmp       dword ptr [rbp-0C],0
       je        short M03_L08
       cmp       qword ptr [rbp-18],0
       jne       short M03_L07
       xor       edi,edi
       call      qword ptr [7F588159ED78]
       int       3
M03_L07:
       mov       rdi,[rbp-18]
       call      00007F58FECE6790
       test      eax,eax
       je        short M03_L08
       mov       edi,eax
       mov       rsi,[rbp-18]
       call      qword ptr [7F5881597A50]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
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
       call      qword ptr [7F58805EEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdi,[rbp-90]
       call      qword ptr [rax]
       lea       rdi,[rbp-88]
       call      qword ptr [7F58805EEF08]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-30]
       call      qword ptr [7F58805F0B98]
       lea       rdi,[rax+10]
       mov       rsi,[rbp-30]
       call      qword ptr [7F58805EEEB8]; CORINFO_HELP_ASSIGN_REF
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
       jne       near ptr M05_L19
       or        dword ptr [rdi+34],10000
M05_L00:
       cmp       byte ptr [7F587FA5B06C],0
       jne       near ptr M05_L20
M05_L01:
       mov       rax,7F48BC8013A0
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
       mov       rsi,7F48BC8013A8
       mov       rbx,[rsi]
       cmp       byte ptr [rbx+38],0
       jne       near ptr M05_L13
M05_L04:
       test      r15b,1
       jne       short M05_L06
       mov       rdi,7F58FF0A0D68
       mov       rax,7F58FF946820
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
       jne       near ptr M05_L10
       lea       r8,[rcx+0A0]
       lea       r9d,[r15+1]
       mov       eax,r15d
       lock cmpxchg [r8],r9d
       cmp       eax,r15d
       jne       short M05_L07
       mov       rsi,[rbp-20]
       mov       rdi,r14
       call      CORINFO_HELP_ASSIGN_REF
       inc       r15d
       mov       [r14+8],r15d
       jmp       short M05_L09
M05_L08:
       mov       rdi,[rdi+18]
       mov       rsi,[rbp-20]
       cmp       [rdi],edi
       call      qword ptr [7F5881597990]; System.Threading.ThreadPoolWorkQueue+WorkStealingQueue.LocalPush(System.Object)
M05_L09:
       add       rbx,78
       mov       edi,1
       xchg      edi,[rbx]
       test      edi,edi
       jne       near ptr M05_L18
       mov       rdi,7F48BC8013D0
       mov       rbx,[rdi]
       lea       rdi,[rbx+160]
       lock inc  dword ptr [rdi]
       mov       rdi,rbx
       call      qword ptr [7F5881596CD0]; System.Threading.PortableThreadPool+WorkerThread.MaybeAddWorkingWorker(System.Threading.PortableThreadPool)
       cmp       dword ptr [rbx+164],6
       je        near ptr M05_L18
       jmp       near ptr M05_L16
M05_L10:
       test      eax,eax
       jge       near ptr M05_L07
       mov       rdi,rsi
       mov       rsi,[rbp-20]
       call      qword ptr [7F588159F228]
       jmp       short M05_L09
M05_L11:
       mov       rsi,r15
       call      qword ptr [7F588159F120]
       mov       rdi,[rbp-20]
       jmp       near ptr M05_L03
M05_L12:
       mov       rdi,offset MT_System.Threading.Tasks.ThreadPoolTaskScheduler
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdi,7F48BC801458
       mov       rbx,[rdi]
       mov       rdi,offset MT_System.Threading.Thread
       call      CORINFO_HELP_NEWFAST
       mov       r15,rax
       mov       rdi,r15
       mov       rsi,rbx
       call      qword ptr [7F588159FD68]
       mov       rdi,r15
       mov       esi,1
       call      qword ptr [7F5881596EB0]; System.Threading.Thread.set_IsBackground(Boolean)
       mov       rdi,r15
       mov       rsi,7F4897C09F88
       call      qword ptr [7F5881596FB8]; System.Threading.Thread.set_Name(System.String)
       mov       rdi,r15
       mov       rsi,[rbp-20]
       xor       edx,edx
       call      qword ptr [7F588159FD80]
       jmp       short M05_L18
M05_L13:
       mov       rsi,7F48BC8013C0
       mov       rsi,[rsi]
       cmp       byte ptr [rsi+9D],0
       je        near ptr M05_L04
       mov       rsi,7F48BC8013C0
       mov       rdi,[rsi]
       mov       rsi,[rbp-20]
       call      qword ptr [7F588159F210]
       jmp       near ptr M05_L04
M05_L14:
       mov       edi,5
       call      qword ptr [7F588159EE50]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M05_L05
M05_L15:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M05_L16:
       mov       rdi,rbx
       call      qword ptr [7F5881596F40]; System.Threading.PortableThreadPool+GateThread.EnsureRunningSlow(System.Threading.PortableThreadPool)
       jmp       short M05_L18
M05_L17:
       mov       rdi,r15
       mov       rsi,[rbp-20]
       mov       rax,[r15]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       nop
M05_L18:
       add       rsp,8
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       ret
M05_L19:
       call      qword ptr [7F588159FD50]
       test      eax,eax
       mov       rdi,[rbp-20]
       jne       near ptr M05_L00
       jmp       short M05_L18
M05_L20:
       call      qword ptr [7F5881597270]
       mov       rdi,[rbp-20]
       jmp       near ptr M05_L01
M05_L21:
       test      word ptr [rdi+34],200
       jne       near ptr M05_L02
       call      qword ptr [7F5881597240]
       mov       r15d,eax
       mov       rdi,[rbp-20]
       mov       rdi,[rdi+8]
       call      qword ptr [7F588159F090]
       mov       rsi,rax
       mov       rdi,7F4897C09F00
       call      qword ptr [7F5880A4EFA0]; System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       esi,r15d
       mov       rdi,rbx
       xor       ecx,ecx
       call      qword ptr [7F5881597258]
       mov       rdi,[rbp-20]
       jmp       near ptr M05_L02
       push      rax
       mov       rbx,rdi
       mov       rdi,offset MT_System.Threading.Tasks.TaskSchedulerException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdi,r15
       mov       rsi,rbx
       call      qword ptr [7F588159F0A8]
       mov       rdi,[rbp-20]
       mov       rsi,r15
       call      qword ptr [7F588159F0C0]
       mov       rdi,[rbp-20]
       xor       esi,esi
       call      qword ptr [7F588159F0D8]
       mov       rdi,[rbp-20]
       call      qword ptr [7F588159F0F0]
       test      eax,200
       jne       short M05_L22
       mov       rdi,[rbp-20]
       mov       rdi,[rdi+28]
       mov       rdi,[rdi+18]
       xor       esi,esi
       cmp       [rdi],edi
       call      qword ptr [7F588159F108]
M05_L22:
       mov       rdi,r15
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 884
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
       jmp       qword ptr [7F5881297A68]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
M06_L00:
       mov       rdi,rax
       mov       rsi,rdx
       pop       rbp
       jmp       near ptr 00007F58FEFFB900
M06_L01:
       xor       ecx,ecx
       mov       [rax],rcx
       pop       rbp
       ret
M06_L02:
       call      qword ptr [7F588159E898]
       int       3
; Total bytes of code 85
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbp
       push      rbx
       push      rax
       lea       rbp,[rsp+10]
       mov       ebx,edi
       call      qword ptr [7F5880606AF0]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       mov       rsi,7F48BC800238
       cmp       r13,[rsi]
       je        near ptr M08_L05
       mov       r12,r13
       test      r12,r12
       je        short M08_L00
       mov       rsi,offset MT_System.Threading.Tasks.UnwrapPromise<System.Int32>
       cmp       [r12],rsi
       jne       near ptr M08_L06
       xor       r12d,r12d
M08_L00:
       test      r12,r12
       jne       near ptr M08_L10
       mov       rdi,offset MT_System.Collections.Generic.List<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rdi,7F48BC800AB0
       mov       rsi,[rdi]
       lea       rdi,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      r14b,r14b
       jne       near ptr M08_L07
       inc       dword ptr [r12+14]
       mov       rdi,r12
       mov       rsi,r13
       call      qword ptr [7F5880A472D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       inc       dword ptr [r12+14]
       mov       rdi,[r12+8]
       mov       esi,[r12+10]
       cmp       [rdi+8],esi
       jbe       short M08_L03
       lea       edx,[rsi+1]
       mov       [r12+10],edx
       mov       esi,esi
       mov       rdx,r15
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M08_L01:
       lea       rdi,[rbx+20]
       test      rdi,rdi
       je        near ptr M08_L09
       mov       rsi,r12
       mov       rdx,r13
       call      00007F58FEE74060
       mov       r12,rax
       cmp       r12,r13
       jne       short M08_L04
M08_L02:
       mov       eax,1
       add       rsp,18
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M08_L03:
       mov       rdi,r12
       mov       rsi,r15
       call      qword ptr [7F5880A472D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M08_L01
M08_L04:
       mov       rsi,r12
       mov       rdi,offset MT_System.Collections.Generic.List<System.Object>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r12,rax
       test      r12,r12
       jne       near ptr M08_L10
M08_L05:
       xor       eax,eax
       add       rsp,18
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M08_L06:
       mov       rsi,r13
       mov       rdi,offset MT_System.Collections.Generic.List<System.Object>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r12,rax
       jmp       near ptr M08_L00
M08_L07:
       inc       dword ptr [r12+14]
       mov       rdi,r12
       mov       rsi,r15
       call      qword ptr [7F5880A472D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       inc       dword ptr [r12+14]
       mov       rdi,[r12+8]
       mov       esi,[r12+10]
       cmp       [rdi+8],esi
       jbe       short M08_L08
       lea       edx,[rsi+1]
       mov       [r12+10],edx
       mov       esi,esi
       mov       rdx,r13
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M08_L01
M08_L08:
       mov       rdi,r12
       mov       rsi,r13
       call      qword ptr [7F5880A472D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M08_L01
M08_L09:
       call      qword ptr [7F588159E8C8]
       int       3
M08_L10:
       mov       [rbp-40],r12
       xor       esi,esi
       mov       [rbp-30],esi
       lea       rsi,[rbp-30]
       mov       rdi,r12
       call      qword ptr [7F5880A45980]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rdi,[rbx+20]
       mov       rax,7F48BC800238
       cmp       rdi,[rax]
       jne       short M08_L11
       xor       edi,edi
       mov       [rbp-34],edi
       jmp       near ptr M08_L17
M08_L11:
       mov       edi,[r12+10]
       mov       rax,[r12+8]
       cmp       edi,[rax+8]
       jne       short M08_L13
       mov       rdi,7F48BC800290
       mov       rsi,[rdi]
       test      rsi,rsi
       jne       short M08_L12
       mov       rdi,offset MT_System.Predicate<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rsi,7F48BC800260
       mov       rsi,[rsi]
       mov       rdi,rbx
       mov       rdx,7F588159BA38
       call      qword ptr [7F5880A46E08]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdi,7F48BC800290
       mov       rsi,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,rbx
M08_L12:
       mov       rdi,r12
       cmp       [rdi],edi
       call      qword ptr [7F588159FA50]
M08_L13:
       test      r14b,r14b
       je        short M08_L14
       mov       rdi,r12
       mov       rdx,r15
       xor       esi,esi
       call      qword ptr [7F5880B36A30]
       jmp       short M08_L18
M08_L14:
       inc       dword ptr [r12+14]
       mov       rdi,[r12+8]
       mov       esi,[r12+10]
       cmp       [rdi+8],esi
       jbe       short M08_L15
       lea       edx,[rsi+1]
       mov       [r12+10],edx
       mov       rdx,r15
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M08_L18
M08_L15:
       mov       rdi,r12
       mov       rsi,r15
       call      qword ptr [7F5880A472D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M08_L18
M08_L16:
       mov       rdi,r12
       call      qword ptr [7F5880A46808]; System.Threading.Monitor.Exit(System.Object)
       jmp       near ptr M08_L02
M08_L17:
       call      M08_L20
       jmp       short M08_L19
M08_L18:
       cmp       byte ptr [rbp-30],0
       je        near ptr M08_L02
       jmp       short M08_L16
M08_L19:
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
M08_L20:
       push      rax
       cmp       byte ptr [rbp-30],0
       je        short M08_L21
       mov       rdi,[rbp-40]
       call      qword ptr [7F5880A46808]; System.Threading.Monitor.Exit(System.Object)
M08_L21:
       nop
       add       rsp,8
       ret
; Total bytes of code 735
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
       mov       rdi,7F48BC8013A0
       mov       r13,[rdi]
       cmp       byte ptr [r13+9D],0
       jne       near ptr M09_L13
M09_L01:
       xor       eax,eax
       mov       edi,[r15+34]
       test      edi,200000
       jne       near ptr M09_L14
       test      edi,400000
       jne       near ptr M09_L15
       test      edi,1000000
       je        near ptr M09_L16
       mov       ecx,5
M09_L02:
       add       ecx,0FFFFFFFB
       jne       near ptr M09_L19
       cmp       byte ptr [r13+9D],0
       jne       near ptr M09_L21
M09_L03:
       cmp       byte ptr [7F587FA5B06C],0
       jne       near ptr M09_L22
M09_L04:
       mov       rdi,r15
       mov       rsi,offset MT_System.Threading.Tasks.UnwrapPromise<System.Int32>
       cmp       [rdi],rsi
       jne       near ptr M09_L12
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
       mov       rsi,7F48BC800238
       mov       rsi,[rsi]
       call      00007F58FEE74040
       test      rax,rax
       je        short M09_L09
       mov       rdi,rbx
       mov       rsi,rax
       call      qword ptr [7F5881597BD0]; System.Threading.Tasks.Task.RunContinuations(System.Object)
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
       mov       rsi,r15
       mov       rdi,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M09_L05
M09_L13:
       mov       rdi,rbx
       call      qword ptr [7F5881597240]
       mov       esi,eax
       mov       rdi,r13
       mov       edx,1
       call      qword ptr [7F5881597F90]
       jmp       near ptr M09_L01
M09_L14:
       mov       ecx,7
       jmp       near ptr M09_L02
M09_L15:
       mov       ecx,6
       jmp       near ptr M09_L02
M09_L16:
       test      edi,800000
       je        short M09_L17
       mov       ecx,4
       jmp       near ptr M09_L02
M09_L17:
       test      edi,20000
       je        short M09_L18
       mov       ecx,3
       jmp       near ptr M09_L02
M09_L18:
       test      edi,2000000
       setne     cl
       movzx     ecx,cl
       mov       edx,2
       test      edi,10000
       cmovne    ecx,edx
       jmp       near ptr M09_L02
M09_L19:
       cmp       ecx,2
       ja        near ptr M09_L11
       mov       edi,ecx
       lea       rax,[7F5880ACC3E8]
       mov       eax,[rax+rdi*4]
       lea       rcx,[M09_L00]
       add       rax,rcx
       jmp       rax
       mov       rdi,r15
       call      qword ptr [7F5881597FA8]
       mov       r14,rax
       mov       rdi,r15
       call      qword ptr [7F5881597FC0]
       mov       rdx,rax
       mov       rsi,r14
       mov       rdi,rbx
       call      qword ptr [7F5881597FD8]
       jmp       near ptr M09_L11
       mov       rdi,r15
       call      qword ptr [7F588159C000]
       mov       r15,rax
       test      r14b,r14b
       je        short M09_L20
       cmp       dword ptr [r15+10],0
       jle       short M09_L20
       mov       rdi,r15
       xor       esi,esi
       call      qword ptr [7F5880B369B8]
       mov       r13,rax
       test      r13,r13
       je        short M09_L20
       mov       rsi,[r13+8]
       mov       rdi,offset MT_System.OperationCanceledException
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M09_L20
       mov       rsi,[rax+70]
       mov       rdi,rbx
       mov       rdx,r13
       call      qword ptr [7F5881597FD8]
       jmp       near ptr M09_L11
M09_L20:
       mov       rdi,rbx
       mov       rsi,r15
       call      qword ptr [7F588159C078]
       jmp       near ptr M09_L11
M09_L21:
       mov       rdi,rbx
       call      qword ptr [7F5881597240]
       mov       esi,eax
       mov       rdi,r13
       mov       edx,1
       call      qword ptr [7F588159C090]
       jmp       near ptr M09_L03
M09_L22:
       mov       rdi,rbx
       call      qword ptr [7F588159C0A8]
       jmp       near ptr M09_L04
M09_L23:
       xor       r15d,r15d
       jmp       near ptr M09_L06
M09_L24:
       mov       esi,1
       call      qword ptr [7F588159C198]; System.Threading.Tasks.Task`1[[System.Int32, System.Private.CoreLib]].GetResultCore(Boolean)
       mov       r15d,eax
       jmp       near ptr M09_L06
M09_L25:
       mov       rdi,rbx
       mov       esi,4000000
       mov       edx,5600000
       call      qword ptr [7F588159F060]
       test      eax,eax
       je        near ptr M09_L10
       jmp       near ptr M09_L07
M09_L26:
       mov       rdi,rbx
       call      qword ptr [7F588159F558]
       mov       rdi,r14
       call      qword ptr [7F588159F570]
       jmp       near ptr M09_L08
M09_L27:
       call      qword ptr [7F588159E8C8]
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
       mov       r14,[rdi+38]
M10_L02:
       test      r14,r14
       je        near ptr M10_L16
       test      dword ptr [r14+34],1600000
       jne       short M10_L04
       test      dword ptr [r14+34],1600000
       jne       near ptr M10_L19
       cmp       qword ptr [r14+20],0
       jne       near ptr M10_L18
       lea       rdi,[r14+20]
       test      rdi,rdi
       je        near ptr M10_L17
       mov       rsi,rbx
       xor       edx,edx
       call      00007F58FEE74060
       test      rax,rax
       jne       near ptr M10_L18
M10_L03:
       add       rsp,8
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       ret
M10_L04:
       mov       rdi,rbx
       mov       rsi,r14
       xor       edx,edx
       call      qword ptr [7F5881597D20]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
M10_L05:
       mov       byte ptr [rbx+3C],2
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
       ja        near ptr M10_L03
       movzx     edx,byte ptr [rbx+3D]
       mov       rdi,rbx
       mov       rsi,r15
       call      qword ptr [7F5881597D20]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       jmp       near ptr M10_L03
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
       call      qword ptr [7F5880E74AF8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rdi,rax
M10_L14:
       cmp       [rdi],edi
       call      qword ptr [7F5881597D50]; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].get_Result()
       mov       r14,rax
       jmp       near ptr M10_L02
M10_L15:
       mov       esi,1
       call      qword ptr [7F588159F3C0]
       mov       r14,rax
       jmp       near ptr M10_L02
M10_L16:
       mov       rdi,rbx
       xor       esi,esi
       xor       edx,edx
       call      qword ptr [7F5881597FD8]
       jmp       near ptr M10_L05
M10_L17:
       call      qword ptr [7F588159E8C8]
       int       3
M10_L18:
       mov       rdi,r14
       mov       rsi,rbx
       xor       edx,edx
       call      qword ptr [7F5881597DC8]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M10_L03
M10_L19:
       mov       rdi,rbx
       mov       rsi,r14
       add       rsp,8
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7F58815CF6C8]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
; Total bytes of code 526
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
       mov       rdi,7F48BC8013A0
       mov       r15,[rdi]
       cmp       byte ptr [r15+9D],0
       jne       near ptr M11_L12
M11_L00:
       lea       rsi,[rbx+48]
       mov       edi,0FFFFFFFF
       lock xadd [rsi],edi
       dec       edi
       jne       near ptr M11_L11
       mov       rsi,[rbx+40]
       mov       esi,[rsi+8]
       mov       rdi,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       xor       r13d,r13d
       xor       r12d,r12d
       xor       eax,eax
M11_L01:
       mov       rdi,[rbx+40]
       cmp       [rdi+8],eax
       jle       near ptr M11_L06
       cmp       eax,[rdi+8]
       jae       near ptr M11_L27
       mov       [rbp-2C],eax
       mov       ecx,eax
       mov       [rbp-38],rcx
       mov       r8,[rdi+rcx*8+10]
       mov       [rbp-40],r8
       test      dword ptr [r8+34],200000
       jne       near ptr M11_L13
       mov       edi,[r8+34]
       and       edi,600000
       cmp       edi,400000
       je        near ptr M11_L16
       test      dword ptr [r8+34],1600000
       je        near ptr M11_L17
M11_L02:
       mov       edi,[r8+34]
       and       edi,1600000
       cmp       edi,1000000
       jne       near ptr M11_L18
M11_L03:
       mov       edi,[r8+38]
       mov       eax,[rbp-2C]
       cmp       eax,[r14+8]
       jae       near ptr M11_L27
       mov       rcx,[rbp-38]
       mov       [r14+rcx*4+10],edi
M11_L04:
       test      dword ptr [r8+34],10000000
       jne       near ptr M11_L19
       mov       rdi,[rbx+40]
       mov       eax,[rbp-2C]
       cmp       eax,[rdi+8]
       jae       near ptr M11_L27
       xor       esi,esi
       mov       rcx,[rbp-38]
       mov       [rdi+rcx*8+10],rsi
M11_L05:
       mov       eax,[rbp-2C]
       inc       eax
       jmp       near ptr M11_L01
M11_L06:
       test      r13,r13
       jne       near ptr M11_L20
       test      r12,r12
       jne       near ptr M11_L21
       cmp       byte ptr [r15+9D],0
       jne       near ptr M11_L22
M11_L07:
       cmp       byte ptr [7F587FA5B06C],0
       jne       near ptr M11_L23
M11_L08:
       mov       eax,[rbx+34]
       mov       [rbp-30],eax
       test      eax,5600000
       jne       short M11_L11
       lea       rdi,[rbx+34]
       mov       esi,eax
       or        esi,4000000
       lock cmpxchg [rdi],esi
       cmp       eax,[rbp-30]
       jne       near ptr M11_L24
M11_L09:
       lea       rdi,[rbx+38]
       mov       rsi,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdi,[rbx+34]
       mov       eax,[rbx+34]
       or        eax,1000000
       xchg      eax,[rdi]
       mov       r12,[rbx+28]
       test      r12,r12
       jne       near ptr M11_L25
M11_L10:
       lea       rdi,[rbx+20]
       test      rdi,rdi
       je        near ptr M11_L26
       mov       rsi,7F48BC800238
       mov       rsi,[rsi]
       call      00007F58FEE74040
       test      rax,rax
       je        short M11_L11
       mov       rdi,rbx
       mov       rsi,rax
       call      qword ptr [7F5881597BD0]; System.Threading.Tasks.Task.RunContinuations(System.Object)
M11_L11:
       nop
       add       rsp,28
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M11_L12:
       mov       rdi,rbx
       call      qword ptr [7F5881597240]
       mov       esi,eax
       mov       rdi,r15
       mov       edx,1
       call      qword ptr [7F5881597F90]
       jmp       near ptr M11_L00
M11_L13:
       test      r13,r13
       jne       short M11_L14
       mov       rdi,offset MT_System.Collections.Generic.List<System.Runtime.ExceptionServices.ExceptionDispatchInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdi,r13
       call      qword ptr [7F588129EE50]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       r8,[rbp-40]
M11_L14:
       mov       rdi,[r8+28]
       mov       rdx,[rdi+18]
       mov       [rbp-48],rdx
       mov       rsi,[rdx+10]
       mov       [rbp-50],rsi
       cmp       byte ptr [rdx+20],0
       jne       short M11_L15
       mov       rdi,rdx
       call      qword ptr [7F5881296868]; System.GC.SuppressFinalize(System.Object)
       mov       rdi,[rbp-48]
       mov       byte ptr [rdi+20],1
M11_L15:
       mov       rdi,r13
       mov       rsi,[rbp-50]
       cmp       [rdi],edi
       call      qword ptr [7F588159C168]
       mov       r8,[rbp-40]
       jmp       near ptr M11_L04
M11_L16:
       test      r12,r12
       jne       near ptr M11_L04
       mov       r12,r8
       mov       r8,[rbp-40]
       jmp       near ptr M11_L04
M11_L17:
       mov       rdi,r8
       mov       esi,0FFFFFFFF
       xor       edx,edx
       call      qword ptr [7F5881597930]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
       mov       r8,[rbp-40]
       jmp       near ptr M11_L02
M11_L18:
       mov       rdi,r8
       mov       esi,1
       call      qword ptr [7F588159FE40]
       mov       r8,[rbp-40]
       jmp       near ptr M11_L03
M11_L19:
       mov       edi,[rbx+34]
       test      edi,5600000
       jne       near ptr M11_L05
       lea       rsi,[rbx+34]
       mov       edx,edi
       or        edx,10000000
       mov       eax,edi
       lock cmpxchg [rsi],edx
       cmp       eax,edi
       je        near ptr M11_L05
       mov       rdi,rbx
       mov       esi,10000000
       mov       edx,5600000
       call      qword ptr [7F588159F060]
       jmp       near ptr M11_L05
M11_L20:
       mov       rdi,rbx
       mov       rsi,r13
       call      qword ptr [7F588159C078]
       jmp       near ptr M11_L11
M11_L21:
       mov       rdi,r12
       call      qword ptr [7F5881597FA8]
       mov       r13,rax
       mov       rdi,r12
       call      qword ptr [7F5881597FC0]
       mov       rdx,rax
       mov       rsi,r13
       mov       rdi,rbx
       call      qword ptr [7F5881597FD8]
       jmp       near ptr M11_L11
M11_L22:
       mov       rdi,rbx
       call      qword ptr [7F5881597240]
       mov       esi,eax
       mov       rdi,r15
       mov       edx,1
       call      qword ptr [7F588159C090]
       jmp       near ptr M11_L07
M11_L23:
       mov       rdi,rbx
       call      qword ptr [7F588159C0A8]
       jmp       near ptr M11_L08
M11_L24:
       mov       rdi,rbx
       mov       esi,4000000
       mov       edx,5600000
       call      qword ptr [7F588159F060]
       test      eax,eax
       je        near ptr M11_L11
       jmp       near ptr M11_L09
M11_L25:
       mov       rdi,rbx
       call      qword ptr [7F588159F558]
       mov       rdi,r12
       call      qword ptr [7F588159F570]
       jmp       near ptr M11_L10
M11_L26:
       call      qword ptr [7F588159E8C8]
       int       3
M11_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 915
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
       call      qword ptr [7F5881597930]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7F588159F870]
       jmp       short M12_L01
M12_L04:
       test      r15b,2
       jne       short M12_L05
       mov       rdi,rbx
       call      qword ptr [7F588159F888]
M12_L05:
       mov       rdi,rbx
       call      qword ptr [7F588159FEE8]
       jmp       short M12_L02
; Total bytes of code 125
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: DefaultJob)

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
       mov       rdi,769AA0801350
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
       mov       rdi,769AA0801380
       mov       rax,[rdi]
       test      rax,rax
       je        near ptr M00_L29
M00_L02:
       cmp       [rax],al
       mov       rdi,769AA0801390
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
       mov       rdi,76AAE4AA0D68
       mov       rax,76AAE539E820
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
       call      qword ptr [76AA66C7C030]; System.Threading.Thread.InitializeCurrentThread()
M00_L04:
       mov       rax,[rax+8]
       test      rax,rax
       je        short M00_L08
       cmp       byte ptr [rax+18],0
       jne       near ptr M00_L31
M00_L05:
       test      rax,rax
       jne       short M00_L09
       or        dword ptr [r12+34],20000000
M00_L06:
       mov       rdi,r12
       xor       esi,esi
       call      qword ptr [76AA66F76910]; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
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
       call      qword ptr [76AA6642F0D8]
       int       3
M00_L08:
       mov       rax,769AA08013A0
       mov       rax,[rax]
       jmp       short M00_L05
M00_L09:
       mov       rdi,769AA08013A0
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
       mov       rdi,76AAE4AA0D68
       mov       rdx,76AAE539E820
       call      rdx
       cmp       dword ptr [rax],8
       jle       near ptr M00_L32
       mov       rdi,[rax+8]
       mov       rax,[rdi+40]
       test      rax,rax
       je        near ptr M00_L32
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
       jne       near ptr M00_L33
M00_L15:
       mov       rax,[rbp-38]
       mov       byte ptr [rax+3D],1
       mov       rdi,769AA08013B0
       mov       rdi,[rdi]
       cmp       byte ptr [rdi+9D],0
       jne       near ptr M00_L34
M00_L16:
       cmp       byte ptr [76AA6543B06C],0
       jne       near ptr M00_L35
M00_L17:
       test      dword ptr [r12+34],1600000
       jne       near ptr M00_L36
       test      dword ptr [r12+34],1600000
       jne       near ptr M00_L39
       cmp       qword ptr [r12+20],0
       jne       near ptr M00_L38
       lea       rdi,[r12+20]
       test      rdi,rdi
       je        near ptr M00_L48
       mov       rsi,rax
       xor       edx,edx
       call      000076AAE4874060
       test      rax,rax
       jne       near ptr M00_L37
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
       je        near ptr M00_L40
       lea       rbx,[rsi+10]
       mov       r15d,[rsi+8]
       test      r15d,r15d
       je        near ptr M00_L41
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
       call      qword ptr [76AA670454A0]
       jmp       short M00_L21
M00_L20:
       mov       rsi,rbx
       call      000076AAE4870D90
       cmp       dword ptr [76AAE4ACEC80],0
       jne       near ptr M00_L42
M00_L21:
       mov       ebx,[r14+8]
       test      ebx,ebx
       jle       short M00_L23
       lea       rdi,[r14+10]
       mov       esi,ebx
M00_L22:
       cmp       qword ptr [rdi],0
       je        near ptr M00_L43
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
       mov       rdi,769AA08013B0
       mov       rdi,[rdi]
       cmp       byte ptr [rdi+9D],0
       jne       near ptr M00_L44
M00_L24:
       cmp       byte ptr [76AA6543B06C],0
       jne       near ptr M00_L45
M00_L25:
       xor       r13d,r13d
       test      ebx,ebx
       jle       short M00_L28
M00_L26:
       mov       rbx,[r14+r13*8+10]
       test      dword ptr [rbx+34],1600000
       jne       near ptr M00_L47
       test      dword ptr [rbx+34],1600000
       jne       near ptr M00_L47
       cmp       qword ptr [rbx+20],0
       jne       near ptr M00_L46
       lea       rdi,[rbx+20]
       test      rdi,rdi
       je        near ptr M00_L48
       mov       rsi,r15
       xor       edx,edx
       call      000076AAE4874060
       test      rax,rax
       jne       near ptr M00_L46
M00_L27:
       inc       r13d
       mov       ebx,[r14+8]
       cmp       ebx,r13d
       jg        short M00_L26
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
       mov       rdi,offset MT_System.Threading.Tasks.TaskFactory<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,769AA0801380
       xor       edx,edx
       call      000076AAE4874060
       test      rax,rax
       jne       near ptr M00_L02
       mov       rax,769AA0801380
       mov       rax,[rax]
       jmp       near ptr M00_L02
M00_L30:
       mov       edi,4
       call      qword ptr [76AA67044BA0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L03
M00_L31:
       xor       eax,eax
       jmp       near ptr M00_L05
M00_L32:
       mov       edi,8
       call      qword ptr [76AA67044BA0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L12
M00_L33:
       mov       rdi,[rdi+30]
       test      rdi,rdi
       je        near ptr M00_L15
       test      cl,4
       je        near ptr M00_L15
       test      byte ptr [rdi+34],8
       jne       near ptr M00_L15
       call      qword ptr [76AA670448E8]
       jmp       near ptr M00_L15
M00_L34:
       mov       rdi,rax
       call      qword ptr [76AA66F77258]
       mov       esi,eax
       mov       rdi,769AA08013B0
       mov       rdi,[rdi]
       mov       rdx,76AA5D40A850
       xor       ecx,ecx
       call      qword ptr [76AA66F77270]
       mov       rax,[rbp-38]
       jmp       near ptr M00_L16
M00_L35:
       mov       rdi,rax
       call      qword ptr [76AA66F772A0]
       mov       rax,[rbp-38]
       jmp       near ptr M00_L17
M00_L36:
       mov       rdi,rax
       mov       rsi,r12
       call      qword ptr [76AA66F772D0]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].ProcessCompletedOuterTask(System.Threading.Tasks.Task)
       jmp       near ptr M00_L18
M00_L37:
       mov       rax,[rbp-38]
M00_L38:
       mov       rdi,r12
       mov       rsi,rax
       xor       edx,edx
       call      qword ptr [76AA66F7E6D0]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M00_L18
       mov       rax,[rbp-38]
M00_L39:
       mov       rdi,rax
       mov       rsi,r12
       call      qword ptr [76AA66FD06E8]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
       jmp       near ptr M00_L18
M00_L40:
       mov       edi,33
       call      qword ptr [76AA6642FAE0]
       int       3
M00_L41:
       mov       rdi,offset MT_System.Threading.Tasks.Task<System.Int32[]>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdi,r15
       xor       esi,esi
       mov       rdx,76AA5D40A1A0
       xor       ecx,ecx
       xor       r8d,r8d
       call      qword ptr [76AA66F77798]
       jmp       near ptr M00_L28
M00_L42:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L21
M00_L43:
       mov       edi,1D
       mov       esi,33
       call      qword ptr [76AA66F777C8]
       int       3
M00_L44:
       mov       rdi,r15
       call      qword ptr [76AA66F77258]
       mov       esi,eax
       mov       rdi,769AA08013B0
       mov       rdi,[rdi]
       mov       rdx,76AA5D40AEE0
       xor       ecx,ecx
       call      qword ptr [76AA66F77270]
       jmp       near ptr M00_L24
M00_L45:
       mov       rdi,r15
       call      qword ptr [76AA66F772A0]
       jmp       near ptr M00_L25
M00_L46:
       mov       rdi,rbx
       mov       rsi,r15
       xor       edx,edx
       call      qword ptr [76AA66F7E6D0]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M00_L27
M00_L47:
       mov       rdi,r15
       mov       rsi,rbx
       call      qword ptr [76AA66FDD848]; System.Threading.Tasks.Task+WhenAllPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
       jmp       near ptr M00_L27
M00_L48:
       call      qword ptr [76AA67044780]
       int       3
; Total bytes of code 1758
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
       jmp       qword ptr [76AA66F779D8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
; Total bytes of code 26
```
```assembly
; AsyncLazyBenchmarks.ContendedFirstCallBenchmarks+<>c__DisplayClass11_0.<VsThreading>b__0()
       mov       rdi,[rdi+8]
       cmp       [rdi],dil
       xor       esi,esi
       jmp       qword ptr [76AA66F77828]; Microsoft.VisualStudio.Threading.AsyncLazy`1[[System.Int32, System.Private.CoreLib]].GetValueAsync(System.Threading.CancellationToken)
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
       call      qword ptr [76AA65FCEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdi,[rbp-90]
       call      qword ptr [rax]
       lea       rdi,[rbp-88]
       call      qword ptr [76AA65FCEF08]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-30]
       call      qword ptr [76AA65FD0B98]
       lea       rdi,[rax+10]
       mov       rsi,[rbp-30]
       call      qword ptr [76AA65FCEEB8]; CORINFO_HELP_ASSIGN_REF
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
       cmp       byte ptr [76AA6543B06C],0
       jne       near ptr M04_L20
M04_L01:
       mov       rax,769AA08013B0
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
       mov       rsi,769AA08013B8
       mov       rbx,[rsi]
       cmp       byte ptr [rbx+38],0
       jne       near ptr M04_L12
M04_L04:
       test      r15b,1
       jne       short M04_L06
       mov       rdi,76AAE4AA0D68
       mov       rax,76AAE539E820
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
       call      qword ptr [76AA670450F8]
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
       mov       rdi,769AA08013E0
       mov       rbx,[rdi]
       lea       rdi,[rbx+160]
       lock inc  dword ptr [rdi]
       mov       rdi,rbx
       call      qword ptr [76AA66F76CE8]; System.Threading.PortableThreadPool+WorkerThread.MaybeAddWorkingWorker(System.Threading.PortableThreadPool)
       cmp       dword ptr [rbx+164],6
       je        near ptr M04_L18
       jmp       near ptr M04_L16
M04_L10:
       mov       rsi,r15
       call      qword ptr [76AA67044FC0]
       mov       rdi,[rbp-20]
       jmp       near ptr M04_L03
M04_L11:
       mov       rdi,offset MT_System.Threading.Tasks.ThreadPoolTaskScheduler
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdi,769AA08014B0
       mov       rbx,[rdi]
       mov       rdi,offset MT_System.Threading.Thread
       call      CORINFO_HELP_NEWFAST
       mov       r15,rax
       mov       rdi,r15
       mov       rsi,rbx
       call      qword ptr [76AA670459F8]
       mov       rdi,r15
       mov       esi,1
       call      qword ptr [76AA66F76EC8]; System.Threading.Thread.set_IsBackground(Boolean)
       mov       rdi,r15
       mov       rsi,76AA5D409F88
       call      qword ptr [76AA66F76FD0]; System.Threading.Thread.set_Name(System.String)
       mov       rdi,r15
       mov       rsi,[rbp-20]
       xor       edx,edx
       call      qword ptr [76AA67045A10]
       jmp       near ptr M04_L18
M04_L12:
       mov       rsi,769AA08013D0
       mov       rsi,[rsi]
       cmp       byte ptr [rsi+9D],0
       je        near ptr M04_L04
       mov       rsi,769AA08013D0
       mov       rdi,[rsi]
       mov       rsi,[rbp-20]
       call      qword ptr [76AA670450C8]
       jmp       near ptr M04_L04
M04_L13:
       mov       edi,5
       call      qword ptr [76AA67044BA0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M04_L05
M04_L14:
       mov       rdi,[rdi+18]
       mov       rsi,[rbp-20]
       cmp       [rdi],edi
       call      qword ptr [76AA670450E0]
       jmp       near ptr M04_L09
M04_L15:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M04_L16:
       mov       rdi,rbx
       call      qword ptr [76AA66F76F58]; System.Threading.PortableThreadPool+GateThread.EnsureRunningSlow(System.Threading.PortableThreadPool)
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
       call      qword ptr [76AA670459E0]
       test      eax,eax
       mov       rdi,[rbp-20]
       jne       near ptr M04_L00
       jmp       short M04_L18
M04_L20:
       call      qword ptr [76AA66F772A0]
       mov       rdi,[rbp-20]
       jmp       near ptr M04_L01
M04_L21:
       test      word ptr [rdi+34],200
       jne       near ptr M04_L02
       call      qword ptr [76AA66F77258]
       mov       r15d,eax
       mov       rdi,[rbp-20]
       mov       rdi,[rdi+8]
       call      qword ptr [76AA67044F30]
       mov       rsi,rax
       mov       rdi,76AA5D409F00
       call      qword ptr [76AA6642EFA0]; System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       esi,r15d
       mov       rdi,rbx
       xor       ecx,ecx
       call      qword ptr [76AA66F77270]
       mov       rdi,[rbp-20]
       jmp       near ptr M04_L02
       push      rax
       mov       rbx,rdi
       mov       rdi,offset MT_System.Threading.Tasks.TaskSchedulerException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdi,r15
       mov       rsi,rbx
       call      qword ptr [76AA67044F48]
       mov       rdi,[rbp-20]
       mov       rsi,r15
       call      qword ptr [76AA67044F60]
       mov       rdi,[rbp-20]
       xor       esi,esi
       call      qword ptr [76AA67044F78]
       mov       rdi,[rbp-20]
       call      qword ptr [76AA67044F90]
       test      eax,200
       jne       short M04_L22
       mov       rdi,[rbp-20]
       mov       rdi,[rdi+28]
       mov       rdi,[rdi+18]
       xor       esi,esi
       cmp       [rdi],edi
       call      qword ptr [76AA67044FA8]
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
       je        short M05_L00
       cmp       rsi,[rdx]
       je        short M05_L02
       mov       rcx,offset MT_System.Object[]
       cmp       rdi,rcx
       je        short M05_L02
       mov       rdi,rax
       pop       rbp
       jmp       qword ptr [76AA66C77A68]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
M05_L00:
       xor       ecx,ecx
       mov       [rax],rcx
       pop       rbp
       ret
M05_L01:
       call      qword ptr [76AA67044750]
       int       3
M05_L02:
       mov       rdi,rax
       mov       rsi,rdx
       pop       rbp
       jmp       near ptr 000076AAE49FB900
; Total bytes of code 85
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbp
       push      rbx
       push      rax
       lea       rbp,[rsp+10]
       mov       ebx,edi
       call      qword ptr [76AA65FE6AF0]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       jne       near ptr M07_L07
       test      esi,400000
       jne       near ptr M07_L08
       test      esi,1000000
       je        near ptr M07_L09
       mov       r14d,5
M07_L00:
       cmp       r14d,5
       jne       near ptr M07_L06
       mov       rdi,r15
       mov       rax,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task<System.Int32>>
       cmp       [rdi],rax
       jne       near ptr M07_L13
M07_L01:
       test      rdi,rdi
       je        near ptr M07_L14
       mov       esi,[rdi+34]
       and       esi,11000000
       cmp       esi,1000000
       jne       near ptr M07_L16
       mov       r14,[rdi+38]
M07_L02:
       test      r14,r14
       je        near ptr M07_L17
       test      dword ptr [r14+34],1600000
       je        short M07_L05
       mov       rdi,rbx
       mov       rsi,r14
       xor       edx,edx
       call      qword ptr [76AA66F7D728]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
M07_L03:
       mov       byte ptr [rbx+3C],2
M07_L04:
       add       rsp,8
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       ret
M07_L05:
       test      dword ptr [r14+34],1600000
       jne       near ptr M07_L20
       cmp       qword ptr [r14+20],0
       jne       near ptr M07_L19
       lea       rdi,[r14+20]
       test      rdi,rdi
       je        near ptr M07_L18
       mov       rsi,rbx
       xor       edx,edx
       call      000076AAE4874060
       test      rax,rax
       je        short M07_L04
       jmp       near ptr M07_L19
M07_L06:
       add       r14d,0FFFFFFFA
       cmp       r14d,1
       ja        short M07_L04
       jmp       short M07_L12
M07_L07:
       mov       r14d,7
       jmp       near ptr M07_L00
M07_L08:
       mov       r14d,6
       jmp       near ptr M07_L00
M07_L09:
       test      esi,800000
       je        short M07_L10
       mov       r14d,4
       jmp       near ptr M07_L00
M07_L10:
       test      esi,20000
       je        short M07_L11
       mov       r14d,3
       jmp       near ptr M07_L00
M07_L11:
       test      esi,2000000
       setne     r14b
       movzx     r14d,r14b
       mov       edi,2
       test      esi,10000
       cmovne    r14d,edi
       jmp       near ptr M07_L00
M07_L12:
       movzx     edx,byte ptr [rbx+3D]
       mov       rdi,rbx
       mov       rsi,r15
       call      qword ptr [76AA66F7D728]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       jmp       near ptr M07_L04
M07_L13:
       mov       rsi,r15
       mov       rdi,rax
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M07_L01
M07_L14:
       mov       rdi,r15
       mov       rax,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task>
       cmp       [rdi],rax
       je        short M07_L15
       mov       rsi,r15
       mov       rdi,rax
       call      qword ptr [76AA66854AF8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rdi,rax
M07_L15:
       cmp       [rdi],edi
       call      qword ptr [76AA66F7D788]; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].get_Result()
       mov       r14,rax
       jmp       near ptr M07_L02
M07_L16:
       mov       esi,1
       call      qword ptr [76AA67044DE0]
       mov       r14,rax
       jmp       near ptr M07_L02
M07_L17:
       mov       rdi,rbx
       xor       esi,esi
       xor       edx,edx
       call      qword ptr [76AA66F7DB30]
       jmp       near ptr M07_L03
M07_L18:
       call      qword ptr [76AA67044780]
       int       3
M07_L19:
       mov       rdi,r14
       mov       rsi,rbx
       xor       edx,edx
       call      qword ptr [76AA66F7E6D0]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M07_L04
M07_L20:
       mov       rdi,rbx
       mov       rsi,r14
       add       rsp,8
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [76AA66FD06E8]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
; Total bytes of code 523
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
       mov       rsi,769AA0800238
       cmp       r13,[rsi]
       jne       short M08_L01
M08_L00:
       xor       eax,eax
       add       rsp,18
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M08_L01:
       mov       rsi,r13
       mov       rdi,offset MT_System.Collections.Generic.List<System.Object>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r12,rax
       test      r12,r12
       jne       near ptr M08_L11
       mov       rdi,offset MT_System.Collections.Generic.List<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rdi,r12
       call      qword ptr [76AA66C7EE50]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       test      r14b,r14b
       je        short M08_L05
       inc       dword ptr [r12+14]
       mov       rdi,[r12+8]
       mov       esi,[r12+10]
       cmp       [rdi+8],esi
       jbe       short M08_L02
       lea       edx,[rsi+1]
       mov       [r12+10],edx
       mov       rdx,r15
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M08_L03
M08_L02:
       mov       rdi,r12
       mov       rsi,r15
       call      qword ptr [76AA664272D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M08_L03:
       inc       dword ptr [r12+14]
       mov       rdi,[r12+8]
       mov       esi,[r12+10]
       cmp       [rdi+8],esi
       jbe       short M08_L04
       lea       edx,[rsi+1]
       mov       [r12+10],edx
       mov       rdx,r13
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M08_L09
M08_L04:
       mov       rdi,r12
       mov       rsi,r13
       call      qword ptr [76AA664272D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M08_L09
M08_L05:
       inc       dword ptr [r12+14]
       mov       rdi,[r12+8]
       mov       esi,[r12+10]
       cmp       [rdi+8],esi
       jbe       short M08_L06
       lea       edx,[rsi+1]
       mov       [r12+10],edx
       mov       rdx,r13
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M08_L07
M08_L06:
       mov       rdi,r12
       mov       rsi,r13
       call      qword ptr [76AA664272D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M08_L07:
       inc       dword ptr [r12+14]
       mov       rdi,[r12+8]
       mov       esi,[r12+10]
       cmp       [rdi+8],esi
       jbe       short M08_L08
       lea       edx,[rsi+1]
       mov       [r12+10],edx
       mov       rdx,r15
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M08_L09
M08_L08:
       mov       rdi,r12
       mov       rsi,r15
       call      qword ptr [76AA664272D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M08_L09:
       lea       rdi,[rbx+20]
       test      rdi,rdi
       jne       short M08_L10
       call      qword ptr [76AA67044780]
       int       3
M08_L10:
       mov       rsi,r12
       mov       rdx,r13
       call      000076AAE4874060
       mov       r12,rax
       cmp       r12,r13
       je        near ptr M08_L20
       mov       rsi,r12
       mov       rdi,offset MT_System.Collections.Generic.List<System.Object>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r12,rax
       test      r12,r12
       je        near ptr M08_L00
M08_L11:
       mov       [rbp-40],r12
       xor       esi,esi
       mov       [rbp-30],esi
       lea       rsi,[rbp-30]
       mov       rdi,r12
       call      qword ptr [76AA66425980]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rdi,[rbx+20]
       mov       rax,769AA0800238
       cmp       rdi,[rax]
       jne       short M08_L12
       xor       edi,edi
       mov       [rbp-34],edi
       jmp       near ptr M08_L18
M08_L12:
       mov       edi,[r12+10]
       mov       rax,[r12+8]
       cmp       edi,[rax+8]
       jne       short M08_L14
       mov       rdi,769AA0800290
       mov       rsi,[rdi]
       test      rsi,rsi
       jne       short M08_L13
       mov       rdi,offset MT_System.Predicate<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rsi,769AA0800260
       mov       rsi,[rsi]
       mov       rdi,rbx
       mov       rdx,76AA670418D8
       call      qword ptr [76AA66426E08]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdi,769AA0800290
       mov       rsi,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,rbx
M08_L13:
       mov       rdi,r12
       cmp       [rdi],edi
       call      qword ptr [76AA670458F0]
M08_L14:
       test      r14b,r14b
       je        short M08_L15
       mov       rdi,r12
       mov       rdx,r15
       xor       esi,esi
       call      qword ptr [76AA66516A30]
       jmp       short M08_L19
M08_L15:
       inc       dword ptr [r12+14]
       mov       rdi,[r12+8]
       mov       esi,[r12+10]
       cmp       [rdi+8],esi
       jbe       short M08_L16
       lea       edx,[rsi+1]
       mov       [r12+10],edx
       mov       rdx,r15
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M08_L19
M08_L16:
       mov       rdi,r12
       mov       rsi,r15
       call      qword ptr [76AA664272D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M08_L19
M08_L17:
       mov       rdi,r12
       call      qword ptr [76AA66426808]; System.Threading.Monitor.Exit(System.Object)
       jmp       short M08_L20
M08_L18:
       call      M08_L22
       jmp       short M08_L21
M08_L19:
       cmp       byte ptr [rbp-30],0
       jne       short M08_L17
M08_L20:
       mov       eax,1
       add       rsp,18
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M08_L21:
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
M08_L22:
       push      rax
       cmp       byte ptr [rbp-30],0
       je        short M08_L23
       mov       rdi,[rbp-40]
       call      qword ptr [76AA66426808]; System.Threading.Monitor.Exit(System.Object)
M08_L23:
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
M09_L00:
       call      000076AAE48F8300
       test      eax,eax
       je        near ptr M09_L24
       movzx     r14d,byte ptr [rbx+3C]
       test      r14d,r14d
       jne       near ptr M09_L07
       mov       byte ptr [rbx+3C],1
       mov       esi,[r15+34]
       test      esi,200000
       jne       near ptr M09_L08
       test      esi,400000
       jne       near ptr M09_L09
       test      esi,1000000
       je        near ptr M09_L10
       mov       r14d,5
M09_L01:
       cmp       r14d,5
       jne       near ptr M09_L21
       mov       rdi,r15
       mov       rax,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task<System.Int32>>
       cmp       [rdi],rax
       jne       near ptr M09_L15
M09_L02:
       test      rdi,rdi
       je        near ptr M09_L16
       mov       esi,[rdi+34]
       and       esi,11000000
       cmp       esi,1000000
       jne       near ptr M09_L18
       mov       r14,[rdi+38]
M09_L03:
       test      r14,r14
       je        near ptr M09_L22
       test      dword ptr [r14+34],1600000
       je        short M09_L06
       mov       rdi,rbx
       mov       rsi,r14
       xor       edx,edx
       call      qword ptr [76AA66F7D728]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
M09_L04:
       mov       byte ptr [rbx+3C],2
M09_L05:
       add       rsp,8
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       ret
M09_L06:
       test      dword ptr [r14+34],1600000
       jne       near ptr M09_L20
       cmp       qword ptr [r14+20],0
       jne       near ptr M09_L19
       lea       rdi,[r14+20]
       test      rdi,rdi
       je        near ptr M09_L23
       mov       rsi,rbx
       xor       edx,edx
       call      000076AAE4874060
       test      rax,rax
       je        short M09_L05
       jmp       near ptr M09_L19
M09_L07:
       cmp       r14d,1
       jne       short M09_L05
       mov       rdi,rbx
       mov       rsi,r15
       xor       edx,edx
       call      qword ptr [76AA66F7D728]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       jmp       short M09_L04
M09_L08:
       mov       r14d,7
       jmp       near ptr M09_L01
M09_L09:
       mov       r14d,6
       jmp       near ptr M09_L01
M09_L10:
       test      esi,800000
       je        short M09_L11
       mov       r14d,4
       jmp       near ptr M09_L01
M09_L11:
       test      esi,20000
       je        short M09_L12
       mov       r14d,3
       jmp       near ptr M09_L01
M09_L12:
       test      esi,10000
       je        short M09_L13
       mov       r14d,2
       jmp       near ptr M09_L01
M09_L13:
       test      esi,2000000
       je        short M09_L14
       mov       r14d,1
       jmp       near ptr M09_L01
M09_L14:
       xor       r14d,r14d
       jmp       near ptr M09_L01
M09_L15:
       mov       rsi,r15
       mov       rdi,rax
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M09_L02
M09_L16:
       mov       rdi,r15
       mov       rax,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task>
       cmp       [rdi],rax
       je        short M09_L17
       mov       rsi,r15
       mov       rdi,rax
       call      qword ptr [76AA66854AF8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rdi,rax
M09_L17:
       cmp       [rdi],edi
       call      qword ptr [76AA66F7D788]; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].get_Result()
       mov       r14,rax
       jmp       near ptr M09_L03
M09_L18:
       mov       esi,1
       call      qword ptr [76AA67044DE0]
       mov       r14,rax
       jmp       near ptr M09_L03
M09_L19:
       mov       rdi,r14
       mov       rsi,rbx
       xor       edx,edx
       call      qword ptr [76AA66F7E6D0]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M09_L05
M09_L20:
       mov       r15,r14
       jmp       near ptr M09_L00
M09_L21:
       add       r14d,0FFFFFFFA
       cmp       r14d,1
       ja        near ptr M09_L05
       movzx     edx,byte ptr [rbx+3D]
       mov       rdi,rbx
       mov       rsi,r15
       call      qword ptr [76AA66F7D728]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       jmp       near ptr M09_L05
M09_L22:
       mov       rdi,rbx
       xor       esi,esi
       xor       edx,edx
       call      qword ptr [76AA66F7DB30]
       jmp       near ptr M09_L04
M09_L23:
       call      qword ptr [76AA67044780]
       int       3
M09_L24:
       mov       rdi,rbx
       mov       rsi,r15
       add       rsp,8
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [76AA66F7D6B0]
; Total bytes of code 594
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
       mov       rdi,769AA08013B0
       mov       r15,[rdi]
       cmp       byte ptr [r15+9D],0
       jne       near ptr M10_L12
M10_L00:
       lea       rsi,[rbx+48]
       mov       edi,0FFFFFFFF
       lock xadd [rsi],edi
       dec       edi
       jne       near ptr M10_L11
       mov       rsi,[rbx+40]
       mov       esi,[rsi+8]
       mov       rdi,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       xor       r13d,r13d
       xor       r12d,r12d
       xor       eax,eax
       jmp       near ptr M10_L06
M10_L01:
       cmp       eax,[rdi+8]
       jae       near ptr M10_L27
       mov       [rbp-2C],eax
       mov       ecx,eax
       mov       [rbp-38],rcx
       mov       r8,[rdi+rcx*8+10]
       mov       [rbp-40],r8
       test      dword ptr [r8+34],200000
       jne       near ptr M10_L13
       mov       edi,[r8+34]
       and       edi,600000
       cmp       edi,400000
       je        near ptr M10_L16
       test      dword ptr [r8+34],1600000
       je        near ptr M10_L17
M10_L02:
       mov       edi,[r8+34]
       and       edi,1600000
       cmp       edi,1000000
       jne       near ptr M10_L18
M10_L03:
       mov       edi,[r8+38]
       mov       eax,[rbp-2C]
       cmp       eax,[r14+8]
       jae       near ptr M10_L27
       mov       rcx,[rbp-38]
       mov       [r14+rcx*4+10],edi
M10_L04:
       test      dword ptr [r8+34],10000000
       jne       near ptr M10_L19
       mov       rdi,[rbx+40]
       mov       eax,[rbp-2C]
       cmp       eax,[rdi+8]
       jae       near ptr M10_L27
       xor       esi,esi
       mov       rcx,[rbp-38]
       mov       [rdi+rcx*8+10],rsi
M10_L05:
       mov       eax,[rbp-2C]
       inc       eax
M10_L06:
       mov       rdi,[rbx+40]
       cmp       [rdi+8],eax
       jg        near ptr M10_L01
       test      r13,r13
       jne       near ptr M10_L20
       test      r12,r12
       jne       near ptr M10_L21
       cmp       byte ptr [r15+9D],0
       jne       near ptr M10_L22
M10_L07:
       cmp       byte ptr [76AA6543B06C],0
       jne       near ptr M10_L23
M10_L08:
       mov       eax,[rbx+34]
       mov       [rbp-30],eax
       test      eax,5600000
       jne       short M10_L11
       lea       rdi,[rbx+34]
       mov       esi,eax
       or        esi,4000000
       lock cmpxchg [rdi],esi
       cmp       eax,[rbp-30]
       jne       near ptr M10_L24
M10_L09:
       lea       rdi,[rbx+38]
       mov       rsi,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdi,[rbx+34]
       mov       eax,[rbx+34]
       or        eax,1000000
       xchg      eax,[rdi]
       mov       r12,[rbx+28]
       test      r12,r12
       jne       near ptr M10_L25
M10_L10:
       lea       rdi,[rbx+20]
       test      rdi,rdi
       je        near ptr M10_L26
       mov       rsi,769AA0800238
       mov       rsi,[rsi]
       call      000076AAE4874040
       test      rax,rax
       je        short M10_L11
       mov       rdi,rbx
       mov       rsi,rax
       call      qword ptr [76AA66F7D608]; System.Threading.Tasks.Task.RunContinuations(System.Object)
M10_L11:
       nop
       add       rsp,28
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M10_L12:
       mov       rdi,rbx
       call      qword ptr [76AA66F77258]
       mov       esi,eax
       mov       rdi,r15
       mov       edx,1
       call      qword ptr [76AA66F7DAE8]
       jmp       near ptr M10_L00
M10_L13:
       test      r13,r13
       jne       short M10_L14
       mov       rdi,offset MT_System.Collections.Generic.List<System.Runtime.ExceptionServices.ExceptionDispatchInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdi,r13
       call      qword ptr [76AA66C7EE50]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       r8,[rbp-40]
M10_L14:
       mov       rdi,[r8+28]
       mov       rdx,[rdi+18]
       mov       [rbp-48],rdx
       mov       rsi,[rdx+10]
       mov       [rbp-50],rsi
       cmp       byte ptr [rdx+20],0
       jne       short M10_L15
       mov       rdi,rdx
       call      qword ptr [76AA66C76868]; System.GC.SuppressFinalize(System.Object)
       mov       rdi,[rbp-48]
       mov       byte ptr [rdi+20],1
M10_L15:
       mov       rdi,r13
       mov       rsi,[rbp-50]
       cmp       [rdi],edi
       call      qword ptr [76AA66F7DC50]
       mov       r8,[rbp-40]
       jmp       near ptr M10_L04
M10_L16:
       test      r12,r12
       jne       near ptr M10_L04
       mov       r12,r8
       mov       r8,[rbp-40]
       jmp       near ptr M10_L04
M10_L17:
       mov       rdi,r8
       mov       esi,0FFFFFFFF
       xor       edx,edx
       call      qword ptr [76AA66F779F0]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
       mov       r8,[rbp-40]
       jmp       near ptr M10_L02
M10_L18:
       mov       rdi,r8
       mov       esi,1
       call      qword ptr [76AA67045998]
       mov       r8,[rbp-40]
       jmp       near ptr M10_L03
M10_L19:
       mov       rdi,rbx
       mov       esi,1
       call      qword ptr [76AA66F7DCB0]
       jmp       near ptr M10_L05
M10_L20:
       mov       rdi,rbx
       mov       rsi,r13
       call      qword ptr [76AA66F7CB28]; System.Threading.Tasks.Task.TrySetException(System.Object)
       jmp       near ptr M10_L11
M10_L21:
       mov       rdi,r12
       call      qword ptr [76AA66F7DB00]
       mov       r13,rax
       mov       rdi,r12
       call      qword ptr [76AA66F7DB18]
       mov       rdx,rax
       mov       rsi,r13
       mov       rdi,rbx
       call      qword ptr [76AA66F7DB30]
       jmp       near ptr M10_L11
M10_L22:
       mov       rdi,rbx
       call      qword ptr [76AA66F77258]
       mov       esi,eax
       mov       rdi,r15
       mov       edx,1
       call      qword ptr [76AA66F7DBC0]
       jmp       near ptr M10_L07
M10_L23:
       mov       rdi,rbx
       call      qword ptr [76AA66F7DBD8]
       jmp       near ptr M10_L08
M10_L24:
       mov       rdi,rbx
       mov       esi,4000000
       mov       edx,5600000
       call      qword ptr [76AA67044B70]
       test      eax,eax
       je        near ptr M10_L11
       jmp       near ptr M10_L09
M10_L25:
       mov       rdi,rbx
       call      qword ptr [76AA66F7CC30]; System.Threading.Tasks.Task.NotifyParentIfPotentiallyAttachedTask()
       mov       rdi,r12
       call      qword ptr [76AA67044B88]
       jmp       near ptr M10_L10
M10_L26:
       call      qword ptr [76AA67044780]
       int       3
M10_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 869
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
       call      qword ptr [76AA66F779F0]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [76AA67045728]
       jmp       short M11_L01
M11_L04:
       test      r15b,2
       jne       short M11_L05
       mov       rdi,rbx
       call      qword ptr [76AA67045590]
M11_L05:
       mov       rdi,rbx
       call      qword ptr [76AA67045CF8]
       jmp       short M11_L02
; Total bytes of code 125
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.ContendedFirstCallBenchmarks.LazyOfTask()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+70]
       vxorps    xmm8,xmm8,xmm8
       vmovdqu   ymmword ptr [rbp-60],ymm8
       vmovdqa   xmmword ptr [rbp-40],xmm8
       xor       eax,eax
       mov       [rbp-30],rax
       mov       [rbp-40],rdi
       mov       rdi,offset MT_AsyncLazyBenchmarks.ContendedFirstCallBenchmarks+<>c__DisplayClass8_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-48],rax
       mov       rdi,offset MT_System.Lazy<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdi,70FA78801350
       mov       rsi,[rdi]
       lea       rdi,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset MT_System.LazyHelper
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+10],8
       lea       rdi,[rbx+8]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-48]
       lea       rdi,[rax+8]
       mov       rsi,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       edi,edi
       mov       [rbp-24],edi
M00_L00:
       mov       rdi,[rbp-40]
       mov       rbx,[rdi+8]
       mov       eax,[rbx+8]
       cmp       eax,[rbp-24]
       jle       near ptr M00_L25
       mov       rax,[rbp-48]
       mov       r15,[rax+10]
       mov       [rbp-50],rbx
       test      r15,r15
       je        near ptr M00_L08
M00_L01:
       mov       rcx,70FA78801370
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L38
M00_L02:
       cmp       [rcx],cl
       mov       rcx,70FA78801380
       mov       rbx,[rcx]
       mov       rdi,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rdi,[rbp-60]
       lea       rdi,[rdi+8]
       mov       rsi,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbp-60]
       xor       esi,esi
       mov       [rdi+10],rsi
       mov       rdi,[rbp-60]
       lea       rdi,[rdi+18]
       mov       rsi,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       edi,2008
       mov       rax,[rbp-60]
       mov       [rax+34],edi
       mov       rdi,710ABC6A0D68
       mov       rax,710ABCEEB820
       call      rax
       cmp       dword ptr [rax],4
       jle       near ptr M00_L39
       mov       rdi,[rax+8]
       mov       rax,[rdi+20]
       test      rax,rax
       je        near ptr M00_L39
M00_L03:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M00_L04
       call      qword ptr [710A3E8AC030]; System.Threading.Thread.InitializeCurrentThread()
M00_L04:
       mov       rbx,[rax+8]
       test      rbx,rbx
       jne       near ptr M00_L09
       mov       rdi,70FA78801390
       mov       rbx,[rdi]
M00_L05:
       test      rbx,rbx
       jne       near ptr M00_L10
       mov       rdi,[rbp-60]
       or        dword ptr [rdi+34],20000000
M00_L06:
       mov       rdi,[rbp-60]
       xor       esi,esi
       call      qword ptr [710A3EBA6778]; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
       mov       rdi,offset MT_System.Threading.Tasks.UnwrapPromise<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-58],rax
       mov       rdi,[rbp-60]
       movzx     ebx,word ptr [rdi+34]
       and       ebx,4
       test      ebx,0FFFFFFBB
       je        near ptr M00_L12
M00_L07:
       mov       edi,2D
       call      qword ptr [710A3E05F0D8]
       int       3
M00_L08:
       mov       rdi,offset MT_System.Func<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rdi,[r15+8]
       mov       rsi,[rbp-48]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset AsyncLazyBenchmarks.ContendedFirstCallBenchmarks+<>c__DisplayClass8_0.<LazyOfTask>b__0()
       mov       [r15+18],rdi
       mov       rsi,[rbp-48]
       lea       rdi,[rsi+10]
       mov       rsi,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L09:
       cmp       byte ptr [rbx+18],0
       je        near ptr M00_L05
       xor       ebx,ebx
       jmp       near ptr M00_L05
M00_L10:
       mov       rdi,70FA78801390
       cmp       rbx,[rdi]
       je        near ptr M00_L06
       mov       rdi,[rbp-60]
       mov       rax,[rdi+28]
       test      rax,rax
       jne       short M00_L11
       mov       rdi,offset MT_System.Threading.Tasks.Task+ContingentProperties
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       dword ptr [r15+3C],1
       mov       rdi,[rbp-60]
       lea       rdi,[rdi+28]
       mov       rsi,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,r15
M00_L11:
       lea       rdi,[rax+8]
       mov       rsi,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L06
M00_L12:
       test      bl,4
       je        near ptr M00_L15
       mov       rdi,710ABC6A0D68
       mov       rax,710ABCEEB820
       call      rax
       cmp       dword ptr [rax],8
       jle       near ptr M00_L40
       mov       rdi,[rax+8]
       mov       rax,[rdi+40]
       test      rax,rax
       je        near ptr M00_L40
M00_L13:
       mov       r15,[rax+10]
       test      r15,r15
       je        short M00_L15
       mov       rdi,[rbp-58]
       mov       rax,[rdi+28]
       test      rax,rax
       jne       short M00_L14
       mov       rdi,offset MT_System.Threading.Tasks.Task+ContingentProperties
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [r14+3C],1
       mov       rdi,[rbp-58]
       lea       rdi,[rdi+28]
       mov       rsi,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,r14
M00_L14:
       lea       rdi,[rax+30]
       mov       rsi,r15
       call      CORINFO_HELP_ASSIGN_REF
M00_L15:
       mov       rdi,[rbp-58]
       xor       eax,eax
       mov       [rdi+8],rax
       mov       rdi,[rbp-58]
       mov       [rdi+10],rax
       mov       rdi,[rbp-58]
       mov       [rdi+18],rax
       test      ebx,0FFFFFFA0
       jne       near ptr M00_L07
       mov       edi,ebx
       or        edi,400
       or        edi,2000000
       mov       rax,[rbp-58]
       mov       [rax+34],edi
       mov       rdi,[rbp-58]
       mov       rdi,[rdi+28]
       test      rdi,rdi
       jne       near ptr M00_L41
M00_L16:
       mov       rdi,[rbp-58]
       mov       byte ptr [rdi+3D],1
       mov       rdi,70FA788013A0
       mov       rdi,[rdi]
       cmp       byte ptr [rdi+9D],0
       jne       near ptr M00_L42
M00_L17:
       cmp       byte ptr [710A3D06B06C],0
       jne       near ptr M00_L43
M00_L18:
       mov       rdi,[rbp-60]
       test      dword ptr [rdi+34],1600000
       jne       short M00_L23
       mov       rdi,[rbp-60]
       test      dword ptr [rdi+34],1600000
       jne       short M00_L22
       mov       rdi,[rbp-60]
       cmp       qword ptr [rdi+20],0
       jne       short M00_L19
       mov       rdi,[rbp-60]
       add       rdi,20
       test      rdi,rdi
       je        near ptr M00_L66
       mov       rsi,[rbp-58]
       xor       edx,edx
       call      0000710ABC474060
       test      rax,rax
       je        short M00_L24
M00_L19:
       mov       rsi,[rbp-60]
       mov       rbx,[rsi+20]
       mov       rsi,70FA78800238
       cmp       rbx,[rsi]
       jne       near ptr M00_L44
M00_L20:
       xor       ebx,ebx
M00_L21:
       test      ebx,ebx
       jne       short M00_L24
M00_L22:
       call      0000710ABC4F8300
       test      eax,eax
       je        near ptr M00_L59
       mov       rdi,[rbp-58]
       movzx     edi,byte ptr [rdi+3C]
       test      edi,edi
       jne       near ptr M00_L58
M00_L23:
       mov       rdi,[rbp-58]
       mov       rsi,[rbp-60]
       call      qword ptr [710A3EBA7120]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].ProcessCompletedOuterTask(System.Threading.Tasks.Task)
M00_L24:
       movsxd    rsi,dword ptr [rbp-24]
       mov       rdi,[rbp-50]
       mov       rdx,[rbp-58]
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       edi,[rbp-24]
       inc       edi
       mov       [rbp-24],edi
       jmp       near ptr M00_L00
M00_L25:
       mov       rsi,rbx
       test      rsi,rsi
       je        near ptr M00_L60
       lea       rbx,[rsi+10]
       mov       r15d,[rsi+8]
       test      r15d,r15d
       je        near ptr M00_L61
       mov       esi,r15d
       mov       rdi,offset MT_System.Threading.Tasks.Task<System.Int32>[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       lea       rdi,[r14+10]
       mov       edx,r15d
       shl       rdx,3
       cmp       rdx,4000
       jbe       short M00_L26
       mov       rsi,rbx
       call      qword ptr [710A3EBAF618]
       jmp       short M00_L27
M00_L26:
       mov       rsi,rbx
       call      0000710ABC470D90
       cmp       dword ptr [710ABC6CEC80],0
       jne       near ptr M00_L62
M00_L27:
       mov       ebx,[r14+8]
       test      ebx,ebx
       jle       short M00_L29
       lea       rdi,[r14+10]
       mov       esi,ebx
M00_L28:
       cmp       qword ptr [rdi],0
       je        near ptr M00_L63
       add       rdi,8
       dec       esi
       jne       short M00_L28
M00_L29:
       mov       rdi,offset MT_System.Threading.Tasks.Task+WhenAllPromise<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       dword ptr [r15+34],2000400
       lea       rdi,[r15+40]
       mov       rsi,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       [r15+48],ebx
       mov       rdi,70FA788013A0
       mov       rdi,[rdi]
       cmp       byte ptr [rdi+9D],0
       jne       near ptr M00_L64
M00_L30:
       cmp       byte ptr [710A3D06B06C],0
       jne       near ptr M00_L65
M00_L31:
       test      ebx,ebx
       jle       short M00_L35
       add       r14,10
M00_L32:
       mov       r13,[r14]
       test      dword ptr [r13+34],1600000
       je        short M00_L36
M00_L33:
       mov       rdi,r15
       mov       rsi,r13
       call      qword ptr [710A3EBEAA28]; System.Threading.Tasks.Task+WhenAllPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
M00_L34:
       add       r14,8
       dec       ebx
       jne       short M00_L32
M00_L35:
       mov       rax,r15
       add       rsp,50
       pop       rbx
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L36:
       test      dword ptr [r13+34],1600000
       jne       short M00_L33
       cmp       qword ptr [r13+20],0
       jne       short M00_L37
       lea       rdi,[r13+20]
       test      rdi,rdi
       je        near ptr M00_L66
       mov       rsi,r15
       xor       edx,edx
       call      0000710ABC474060
       test      rax,rax
       je        short M00_L34
M00_L37:
       mov       rdi,r13
       mov       rsi,r15
       xor       edx,edx
       call      qword ptr [710A3EBACA50]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       short M00_L34
       jmp       short M00_L33
M00_L38:
       mov       rdi,offset MT_System.Threading.Tasks.TaskFactory<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,70FA78801370
       xor       edx,edx
       call      0000710ABC474060
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M00_L02
       mov       rcx,70FA78801370
       mov       rcx,[rcx]
       jmp       near ptr M00_L02
M00_L39:
       mov       edi,4
       call      qword ptr [710A3EBAEDD8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L03
M00_L40:
       mov       edi,8
       call      qword ptr [710A3EBAEDD8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L13
M00_L41:
       mov       rdi,[rdi+30]
       test      rdi,rdi
       je        near ptr M00_L16
       test      bl,4
       je        near ptr M00_L16
       test      byte ptr [rdi+34],8
       jne       near ptr M00_L16
       call      qword ptr [710A3EBAE7D8]
       jmp       near ptr M00_L16
M00_L42:
       mov       rdi,[rbp-58]
       call      qword ptr [710A3EBA70C0]
       mov       esi,eax
       mov       rdi,70FA788013A0
       mov       rdi,[rdi]
       mov       rdx,710A3540A850
       xor       ecx,ecx
       call      qword ptr [710A3EBA70D8]
       jmp       near ptr M00_L17
M00_L43:
       mov       rdi,[rbp-58]
       call      qword ptr [710A3EBA70F0]
       jmp       near ptr M00_L18
M00_L44:
       mov       rsi,rbx
       mov       rdi,offset MT_System.Collections.Generic.List<System.Object>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       jne       near ptr M00_L49
       mov       rdi,offset MT_System.Collections.Generic.List<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdi,r15
       call      qword ptr [710A3E8AEE50]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       inc       dword ptr [r15+14]
       mov       rdi,[r15+8]
       mov       esi,[r15+10]
       cmp       [rdi+8],esi
       jbe       short M00_L45
       lea       edx,[rsi+1]
       mov       [r15+10],edx
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M00_L46
M00_L45:
       mov       rdi,r15
       mov       rsi,rbx
       call      qword ptr [710A3E0572D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M00_L46:
       inc       dword ptr [r15+14]
       mov       rdi,[r15+8]
       mov       esi,[r15+10]
       cmp       [rdi+8],esi
       jbe       short M00_L47
       lea       edx,[rsi+1]
       mov       [r15+10],edx
       mov       rdx,[rbp-58]
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M00_L48
M00_L47:
       mov       rdi,r15
       mov       rsi,[rbp-58]
       call      qword ptr [710A3E0572D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M00_L48:
       mov       rdi,[rbp-60]
       add       rdi,20
       test      rdi,rdi
       je        near ptr M00_L66
       mov       rsi,r15
       mov       rdx,rbx
       call      0000710ABC474060
       mov       r15,rax
       cmp       r15,rbx
       je        near ptr M00_L56
       mov       rsi,r15
       mov       rdi,offset MT_System.Collections.Generic.List<System.Object>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       je        near ptr M00_L20
M00_L49:
       mov       [rbp-68],r15
       mov       byte ptr [rbp-30],0
       lea       rsi,[rbp-30]
       mov       rdi,r15
       call      qword ptr [710A3E055980]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rdi,[rbp-60]
       mov       rdi,[rdi+20]
       mov       rax,70FA78800238
       cmp       rdi,[rax]
       jne       short M00_L50
       xor       edi,edi
       mov       [rbp-34],edi
       jmp       near ptr M00_L55
M00_L50:
       mov       edi,[r15+10]
       mov       rax,[r15+8]
       cmp       edi,[rax+8]
       jne       short M00_L52
       mov       rdi,70FA78800290
       mov       rsi,[rdi]
       test      rsi,rsi
       jne       short M00_L51
       mov       rdi,offset MT_System.Predicate<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdi,70FA78800260
       mov       rsi,[rdi]
       lea       rdi,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,710A3EBAB8A0
       mov       [rbx+18],rdi
       mov       rdi,70FA78800290
       mov       rsi,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,rbx
M00_L51:
       mov       rdi,r15
       cmp       [rdi],edi
       call      qword ptr [710A3EBAF8B8]
M00_L52:
       inc       dword ptr [r15+14]
       mov       rdi,[r15+8]
       mov       esi,[r15+10]
       cmp       [rdi+8],esi
       jbe       short M00_L53
       lea       edx,[rsi+1]
       mov       [r15+10],edx
       mov       rdx,[rbp-58]
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M00_L54
M00_L53:
       mov       rdi,r15
       mov       rsi,[rbp-58]
       call      qword ptr [710A3E0572D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       nop
M00_L54:
       cmp       byte ptr [rbp-30],0
       je        short M00_L56
       mov       rdi,r15
       call      qword ptr [710A3E056808]; System.Threading.Monitor.Exit(System.Object)
       jmp       short M00_L56
M00_L55:
       call      M00_L67
       jmp       short M00_L57
M00_L56:
       mov       ebx,1
       jmp       near ptr M00_L21
M00_L57:
       mov       ebx,[rbp-34]
       jmp       near ptr M00_L21
M00_L58:
       cmp       edi,1
       jne       near ptr M00_L24
       mov       rdi,[rbp-58]
       mov       rsi,[rbp-60]
       xor       edx,edx
       call      qword ptr [710A3EBA7840]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       mov       rdi,[rbp-58]
       mov       byte ptr [rdi+3C],2
       jmp       near ptr M00_L24
M00_L59:
       mov       rdi,[rbp-58]
       mov       rsi,[rbp-60]
       call      qword ptr [710A3EBA77E0]
       jmp       near ptr M00_L24
M00_L60:
       mov       edi,33
       call      qword ptr [710A3E05FAE0]
       int       3
M00_L61:
       mov       rdi,offset MT_System.Threading.Tasks.Task<System.Int32[]>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdi,r15
       xor       esi,esi
       mov       rdx,710A3540A1A0
       xor       ecx,ecx
       xor       r8d,r8d
       call      qword ptr [710A3EBA7600]
       jmp       near ptr M00_L35
M00_L62:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L27
M00_L63:
       mov       edi,1D
       mov       esi,33
       call      qword ptr [710A3EBA7630]
       int       3
M00_L64:
       mov       rdi,r15
       call      qword ptr [710A3EBA70C0]
       mov       esi,eax
       mov       rdi,70FA788013A0
       mov       rdi,[rdi]
       mov       rdx,710A3540AEE0
       xor       ecx,ecx
       call      qword ptr [710A3EBA70D8]
       jmp       near ptr M00_L30
M00_L65:
       mov       rdi,r15
       call      qword ptr [710A3EBA70F0]
       jmp       near ptr M00_L31
M00_L66:
       call      qword ptr [710A3EBAE820]
       int       3
M00_L67:
       push      rax
       cmp       byte ptr [rbp-30],0
       je        short M00_L68
       mov       rdi,[rbp-68]
       call      qword ptr [710A3E056808]; System.Threading.Monitor.Exit(System.Object)
M00_L68:
       nop
       add       rsp,8
       ret
; Total bytes of code 2354
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
       jmp       qword ptr [710A3EBA77F8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
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
       call      qword ptr [710A3DBFEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdi,[rbp-90]
       call      qword ptr [rax]
       lea       rdi,[rbp-88]
       call      qword ptr [710A3DBFEF08]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-30]
       call      qword ptr [710A3DC00B98]
       lea       rdi,[rax+10]
       mov       rsi,[rbp-30]
       call      qword ptr [710A3DBFEEB8]; CORINFO_HELP_ASSIGN_REF
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
       cmp       byte ptr [710A3D06B06C],0
       jne       near ptr M03_L20
M03_L01:
       mov       rax,70FA788013A0
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
       mov       rsi,70FA788013A8
       mov       rbx,[rsi]
       cmp       byte ptr [rbx+38],0
       jne       near ptr M03_L12
M03_L04:
       test      r15b,1
       jne       short M03_L06
       mov       rdi,710ABC6A0D68
       mov       rax,710ABCEEB820
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
       call      qword ptr [710A3EBAF030]
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
       mov       rdi,70FA788013D0
       mov       rbx,[rdi]
       lea       rdi,[rbx+160]
       lock inc  dword ptr [rdi]
       mov       rdi,rbx
       call      qword ptr [710A3EBA6B50]; System.Threading.PortableThreadPool+WorkerThread.MaybeAddWorkingWorker(System.Threading.PortableThreadPool)
       cmp       dword ptr [rbx+164],6
       je        near ptr M03_L18
       jmp       near ptr M03_L16
M03_L10:
       mov       rsi,r15
       call      qword ptr [710A3EBAEEF8]
       mov       rdi,[rbp-20]
       jmp       near ptr M03_L03
M03_L11:
       mov       rdi,offset MT_System.Threading.Tasks.ThreadPoolTaskScheduler
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdi,70FA78801468
       mov       rbx,[rdi]
       mov       rdi,offset MT_System.Threading.Thread
       call      CORINFO_HELP_NEWFAST
       mov       r15,rax
       mov       rdi,r15
       mov       rsi,rbx
       call      qword ptr [710A3EBAF948]
       mov       rdi,r15
       mov       esi,1
       call      qword ptr [710A3EBA6D30]; System.Threading.Thread.set_IsBackground(Boolean)
       mov       rdi,r15
       mov       rsi,710A35409F88
       call      qword ptr [710A3EBA6E38]; System.Threading.Thread.set_Name(System.String)
       mov       rdi,r15
       mov       rsi,[rbp-20]
       xor       edx,edx
       call      qword ptr [710A3EBAF960]
       jmp       near ptr M03_L18
M03_L12:
       mov       rsi,70FA788013C0
       mov       rsi,[rsi]
       cmp       byte ptr [rsi+9D],0
       je        near ptr M03_L04
       mov       rsi,70FA788013C0
       mov       rdi,[rsi]
       mov       rsi,[rbp-20]
       call      qword ptr [710A3EBAF000]
       jmp       near ptr M03_L04
M03_L13:
       mov       edi,5
       call      qword ptr [710A3EBAEDD8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M03_L05
M03_L14:
       mov       rdi,[rdi+18]
       mov       rsi,[rbp-20]
       cmp       [rdi],edi
       call      qword ptr [710A3EBAF018]
       jmp       near ptr M03_L09
M03_L15:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M03_L16:
       mov       rdi,rbx
       call      qword ptr [710A3EBA6DC0]; System.Threading.PortableThreadPool+GateThread.EnsureRunningSlow(System.Threading.PortableThreadPool)
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
       call      qword ptr [710A3EBAF930]
       test      eax,eax
       mov       rdi,[rbp-20]
       jne       near ptr M03_L00
       jmp       short M03_L18
M03_L20:
       call      qword ptr [710A3EBA70F0]
       mov       rdi,[rbp-20]
       jmp       near ptr M03_L01
M03_L21:
       test      word ptr [rdi+34],200
       jne       near ptr M03_L02
       call      qword ptr [710A3EBA70C0]
       mov       r15d,eax
       mov       rdi,[rbp-20]
       mov       rdi,[rdi+8]
       call      qword ptr [710A3EBAEE68]
       mov       rsi,rax
       mov       rdi,710A35409F00
       call      qword ptr [710A3E05EFA0]; System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       esi,r15d
       mov       rdi,rbx
       xor       ecx,ecx
       call      qword ptr [710A3EBA70D8]
       mov       rdi,[rbp-20]
       jmp       near ptr M03_L02
       push      rax
       mov       rbx,rdi
       mov       rdi,offset MT_System.Threading.Tasks.TaskSchedulerException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdi,r15
       mov       rsi,rbx
       call      qword ptr [710A3EBAEE80]
       mov       rdi,[rbp-20]
       mov       rsi,r15
       call      qword ptr [710A3EBAEE98]
       mov       rdi,[rbp-20]
       xor       esi,esi
       call      qword ptr [710A3EBAEEB0]
       mov       rdi,[rbp-20]
       call      qword ptr [710A3EBAEEC8]
       test      eax,200
       jne       short M03_L22
       mov       rdi,[rbp-20]
       mov       rdi,[rdi+28]
       mov       rdi,[rdi+18]
       xor       esi,esi
       cmp       [rdi],edi
       call      qword ptr [710A3EBAEEE0]
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
       jmp       qword ptr [710A3E8AC420]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
; Total bytes of code 22
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
       jne       near ptr M05_L06
       test      esi,400000
       jne       near ptr M05_L07
       test      esi,1000000
       je        near ptr M05_L08
       mov       r14d,5
M05_L00:
       cmp       r14d,5
       jne       short M05_L05
       mov       rdi,r15
       mov       rax,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task<System.Int32>>
       cmp       [rdi],rax
       jne       near ptr M05_L12
M05_L01:
       test      rdi,rdi
       je        near ptr M05_L13
       mov       esi,[rdi+34]
       and       esi,11000000
       cmp       esi,1000000
       jne       near ptr M05_L15
       mov       rsi,[rdi+38]
M05_L02:
       test      rsi,rsi
       je        near ptr M05_L16
       test      dword ptr [rsi+34],1600000
       je        near ptr M05_L17
       mov       rdi,rbx
       xor       edx,edx
       call      qword ptr [710A3EBA7840]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
M05_L03:
       mov       byte ptr [rbx+3C],2
M05_L04:
       add       rsp,8
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       ret
M05_L05:
       add       r14d,0FFFFFFFA
       cmp       r14d,1
       ja        short M05_L04
       jmp       short M05_L11
M05_L06:
       mov       r14d,7
       jmp       near ptr M05_L00
M05_L07:
       mov       r14d,6
       jmp       near ptr M05_L00
M05_L08:
       test      esi,800000
       je        short M05_L09
       mov       r14d,4
       jmp       near ptr M05_L00
M05_L09:
       test      esi,20000
       je        short M05_L10
       mov       r14d,3
       jmp       near ptr M05_L00
M05_L10:
       test      esi,2000000
       setne     r14b
       movzx     r14d,r14b
       mov       edi,2
       test      esi,10000
       cmovne    r14d,edi
       jmp       near ptr M05_L00
M05_L11:
       movzx     edx,byte ptr [rbx+3D]
       mov       rdi,rbx
       mov       rsi,r15
       call      qword ptr [710A3EBA7840]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       jmp       near ptr M05_L04
M05_L12:
       mov       rsi,r15
       mov       rdi,rax
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M05_L01
M05_L13:
       mov       rdi,r15
       mov       rax,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task>
       cmp       [rdi],rax
       je        short M05_L14
       mov       rsi,r15
       mov       rdi,rax
       call      qword ptr [710A3E484AF8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rdi,rax
M05_L14:
       cmp       [rdi],edi
       call      qword ptr [710A3EBA7948]; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].get_Result()
       mov       rsi,rax
       jmp       near ptr M05_L02
M05_L15:
       mov       esi,1
       call      qword ptr [710A3EBAED30]
       mov       rsi,rax
       jmp       near ptr M05_L02
M05_L16:
       mov       rdi,rbx
       xor       esi,esi
       xor       edx,edx
       call      qword ptr [710A3EBA7B28]
       jmp       near ptr M05_L03
M05_L17:
       mov       rdi,rsi
       mov       rsi,rbx
       xor       edx,edx
       add       rsp,8
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [710A3EBA7138]; System.Threading.Tasks.Task.AddCompletionAction(System.Threading.Tasks.ITaskCompletionAction, Boolean)
; Total bytes of code 434
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       push      rbp
       mov       rbp,rsp
       mov       eax,[rdi+8]
       cmp       rax,rsi
       jbe       short M06_L01
       lea       rax,[rdi+rsi*8+10]
       mov       rdi,[rdi]
       mov       rsi,[rdi+30]
       test      rdx,rdx
       je        short M06_L00
       cmp       rsi,[rdx]
       je        short M06_L02
       mov       rcx,offset MT_System.Object[]
       cmp       rdi,rcx
       je        short M06_L02
       mov       rdi,rax
       pop       rbp
       jmp       qword ptr [710A3E8A7A68]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
M06_L00:
       xor       ecx,ecx
       mov       [rax],rcx
       pop       rbp
       ret
M06_L01:
       call      qword ptr [710A3EBAE610]
       int       3
M06_L02:
       mov       rdi,rax
       mov       rsi,rdx
       pop       rbp
       jmp       near ptr 0000710ABC5FB900
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
       mov       rdi,70FA788013A0
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
       cmp       byte ptr [710A3D06B06C],0
       jne       near ptr M07_L22
M07_L10:
       mov       rdi,rbx
       mov       rsi,r14
       call      qword ptr [710A3EBA7CF0]; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].TrySetResult(System.__Canon)
       jmp       near ptr M07_L01
M07_L11:
       mov       rdi,rbx
       call      qword ptr [710A3EBA70C0]
       mov       esi,eax
       mov       rdi,r15
       mov       edx,1
       call      qword ptr [710A3EBA7AE0]
       jmp       near ptr M07_L00
M07_L12:
       test      r13,r13
       jne       short M07_L13
       mov       rdi,offset MT_System.Collections.Generic.List<System.Runtime.ExceptionServices.ExceptionDispatchInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdi,r13
       call      qword ptr [710A3E8AEE50]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
       call      qword ptr [710A3E8A6868]; System.GC.SuppressFinalize(System.Object)
       mov       rdi,[rbp-48]
       mov       byte ptr [rdi+20],1
M07_L14:
       mov       rdi,r13
       mov       rsi,[rbp-50]
       cmp       [rdi],edi
       call      qword ptr [710A3EBA7C78]
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
       call      qword ptr [710A3EBA7810]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
       mov       r8,[rbp-40]
       jmp       near ptr M07_L04
M07_L17:
       mov       rdi,r8
       mov       esi,1
       call      qword ptr [710A3EBAECE8]
       mov       r8,[rbp-40]
       jmp       near ptr M07_L05
M07_L18:
       mov       rdi,rbx
       mov       esi,1
       call      qword ptr [710A3EBA7CD8]
       jmp       near ptr M07_L07
M07_L19:
       mov       rdi,rbx
       mov       rsi,r13
       call      qword ptr [710A3EBA7BB8]
       jmp       near ptr M07_L01
M07_L20:
       mov       rdi,r12
       call      qword ptr [710A3EBA7AF8]
       mov       r13,rax
       mov       rdi,r12
       call      qword ptr [710A3EBA7B10]
       mov       rdx,rax
       mov       rsi,r13
       mov       rdi,rbx
       call      qword ptr [710A3EBA7B28]
       jmp       near ptr M07_L01
M07_L21:
       mov       rdi,rbx
       call      qword ptr [710A3EBA70C0]
       mov       esi,eax
       mov       rdi,r15
       mov       edx,1
       call      qword ptr [710A3EBA7BD0]
       jmp       near ptr M07_L09
M07_L22:
       mov       rdi,rbx
       call      qword ptr [710A3EBA7BE8]
       jmp       near ptr M07_L10
M07_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 694
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
       mov       rsi,70FA78800238
       cmp       r13,[rsi]
       jne       short M08_L01
M08_L00:
       xor       eax,eax
       add       rsp,18
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M08_L01:
       mov       rsi,r13
       mov       rdi,offset MT_System.Collections.Generic.List<System.Object>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r12,rax
       test      r12,r12
       jne       near ptr M08_L11
       mov       rdi,offset MT_System.Collections.Generic.List<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rdi,r12
       call      qword ptr [710A3E8AEE50]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       test      r14b,r14b
       je        short M08_L05
       inc       dword ptr [r12+14]
       mov       rdi,[r12+8]
       mov       esi,[r12+10]
       cmp       [rdi+8],esi
       jbe       short M08_L02
       lea       edx,[rsi+1]
       mov       [r12+10],edx
       mov       rdx,r15
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M08_L03
M08_L02:
       mov       rdi,r12
       mov       rsi,r15
       call      qword ptr [710A3E0572D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M08_L03:
       inc       dword ptr [r12+14]
       mov       rdi,[r12+8]
       mov       esi,[r12+10]
       cmp       [rdi+8],esi
       jbe       short M08_L04
       lea       edx,[rsi+1]
       mov       [r12+10],edx
       mov       rdx,r13
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M08_L09
M08_L04:
       mov       rdi,r12
       mov       rsi,r13
       call      qword ptr [710A3E0572D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M08_L09
M08_L05:
       inc       dword ptr [r12+14]
       mov       rdi,[r12+8]
       mov       esi,[r12+10]
       cmp       [rdi+8],esi
       jbe       short M08_L06
       lea       edx,[rsi+1]
       mov       [r12+10],edx
       mov       rdx,r13
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M08_L07
M08_L06:
       mov       rdi,r12
       mov       rsi,r13
       call      qword ptr [710A3E0572D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M08_L07:
       inc       dword ptr [r12+14]
       mov       rdi,[r12+8]
       mov       esi,[r12+10]
       cmp       [rdi+8],esi
       jbe       short M08_L08
       lea       edx,[rsi+1]
       mov       [r12+10],edx
       mov       rdx,r15
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M08_L09
M08_L08:
       mov       rdi,r12
       mov       rsi,r15
       call      qword ptr [710A3E0572D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M08_L09:
       lea       rdi,[rbx+20]
       test      rdi,rdi
       jne       short M08_L10
       call      qword ptr [710A3EBAE820]
       int       3
M08_L10:
       mov       rsi,r12
       mov       rdx,r13
       call      0000710ABC474060
       mov       r12,rax
       cmp       r12,r13
       je        near ptr M08_L20
       mov       rsi,r12
       mov       rdi,offset MT_System.Collections.Generic.List<System.Object>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r12,rax
       test      r12,r12
       je        near ptr M08_L00
M08_L11:
       mov       [rbp-40],r12
       xor       esi,esi
       mov       [rbp-30],esi
       lea       rsi,[rbp-30]
       mov       rdi,r12
       call      qword ptr [710A3E055980]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rdi,[rbx+20]
       mov       rax,70FA78800238
       cmp       rdi,[rax]
       jne       short M08_L12
       xor       edi,edi
       mov       [rbp-34],edi
       jmp       near ptr M08_L18
M08_L12:
       mov       edi,[r12+10]
       mov       rax,[r12+8]
       cmp       edi,[rax+8]
       jne       short M08_L14
       mov       rdi,70FA78800290
       mov       rsi,[rdi]
       test      rsi,rsi
       jne       short M08_L13
       mov       rdi,offset MT_System.Predicate<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rsi,70FA78800260
       mov       rsi,[rsi]
       mov       rdi,rbx
       mov       rdx,710A3EBAB8A0
       call      qword ptr [710A3E056E08]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdi,70FA78800290
       mov       rsi,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,rbx
M08_L13:
       mov       rdi,r12
       cmp       [rdi],edi
       call      qword ptr [710A3EBAF8B8]
M08_L14:
       test      r14b,r14b
       je        short M08_L15
       mov       rdi,r12
       mov       rdx,r15
       xor       esi,esi
       call      qword ptr [710A3E146A30]
       jmp       short M08_L19
M08_L15:
       inc       dword ptr [r12+14]
       mov       rdi,[r12+8]
       mov       esi,[r12+10]
       cmp       [rdi+8],esi
       jbe       short M08_L16
       lea       edx,[rsi+1]
       mov       [r12+10],edx
       mov       rdx,r15
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M08_L19
M08_L16:
       mov       rdi,r12
       mov       rsi,r15
       call      qword ptr [710A3E0572D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M08_L19
M08_L17:
       mov       rdi,r12
       call      qword ptr [710A3E056808]; System.Threading.Monitor.Exit(System.Object)
       jmp       short M08_L20
M08_L18:
       call      M08_L22
       jmp       short M08_L21
M08_L19:
       cmp       byte ptr [rbp-30],0
       jne       short M08_L17
M08_L20:
       mov       eax,1
       add       rsp,18
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M08_L21:
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
M08_L22:
       push      rax
       cmp       byte ptr [rbp-30],0
       je        short M08_L23
       mov       rdi,[rbp-40]
       call      qword ptr [710A3E056808]; System.Threading.Monitor.Exit(System.Object)
M08_L23:
       nop
       add       rsp,8
       ret
; Total bytes of code 724
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbp
       push      rbx
       push      rax
       lea       rbp,[rsp+10]
       mov       ebx,edi
       call      qword ptr [710A3DC16AF0]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       push      rbp
       mov       rbp,rsp
       test      rsi,rsi
       je        short M10_L02
       mov       rax,[rsi]
       cmp       rax,rdi
       je        short M10_L02
       mov       rax,[rax+10]
       cmp       rax,rdi
       je        short M10_L02
M10_L00:
       test      rax,rax
       je        short M10_L01
       mov       rax,[rax+10]
       cmp       rax,rdi
       je        short M10_L02
       test      rax,rax
       je        short M10_L01
       mov       rax,[rax+10]
       cmp       rax,rdi
       je        short M10_L02
       test      rax,rax
       je        short M10_L01
       mov       rax,[rax+10]
       cmp       rax,rdi
       je        short M10_L02
       test      rax,rax
       jne       short M10_L03
M10_L01:
       xor       esi,esi
M10_L02:
       mov       rax,rsi
       pop       rbp
       ret
M10_L03:
       mov       rax,[rax+10]
       cmp       rax,rdi
       je        short M10_L02
       jmp       short M10_L00
; Total bytes of code 91
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       push      rbx
       sub       rsp,10
       mov       [rsp+8],rdi
       mov       rbx,rdi
       mov       rdi,[rbx]
       call      qword ptr [710A3DC021B0]
       mov       rdi,rax
       call      qword ptr [710A3DBFEF70]; Precode of System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rsi,[rax]
       lea       rdi,[rbx+8]
       call      qword ptr [710A3DBFEEB8]; CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,10
       pop       rbx
       ret
; Total bytes of code 51
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rbx
       lea       rbp,[rsp+20]
       mov       rbx,rdi
       mov       r15,rsi
       mov       r14d,[rbx+10]
       lea       r13d,[r14+1]
       mov       edi,r13d
       mov       rsi,[rbx+8]
       cmp       dword ptr [rsi+8],0
       jne       short M12_L01
       mov       esi,4
M12_L00:
       mov       eax,7FFFFFC7
       cmp       esi,7FFFFFC7
       cmova     esi,eax
       cmp       esi,edi
       cmovl     esi,edi
       mov       rdi,rbx
       call      qword ptr [710A3DC23198]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
       mov       [rbx+10],r13d
       mov       rdi,[rbx+8]
       movsxd    rsi,r14d
       mov       rdx,r15
       call      qword ptr [710A3DBFEED8]; Precode of System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       nop
       pop       rbx
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M12_L01:
       mov       rsi,[rbx+8]
       mov       esi,[rsi+8]
       add       esi,esi
       jmp       short M12_L00
; Total bytes of code 114
```
```assembly
; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       push      rbp
       push      r15
       push      rbx
       lea       rbp,[rsp+10]
       mov       r15,rdi
       mov       rbx,rsi
       cmp       byte ptr [rbx],0
       je        short M13_L00
       call      qword ptr [710A3DC169F0]
       int       3
M13_L00:
       test      r15,r15
       je        short M13_L02
       mov       rdi,r15
       call      qword ptr [710A3DC169B0]
       test      eax,eax
       jne       short M13_L01
       mov       rdi,r15
       call      qword ptr [710A3DC169C0]; Precode of System.Threading.Monitor.Enter_Slowpath(System.Object)
M13_L01:
       mov       byte ptr [rbx],1
       pop       rbx
       pop       r15
       pop       rbp
       ret
M13_L02:
       xor       edi,edi
       call      qword ptr [710A3DC11208]
       int       3
; Total bytes of code 71
```
```assembly
; System.Threading.Monitor.Exit(System.Object)
       push      rbp
       push      rbx
       push      rax
       lea       rbp,[rsp+10]
       mov       rbx,rdi
       test      rbx,rbx
       je        short M14_L00
       mov       rdi,rbx
       call      0000710ABC2E6790
       test      eax,eax
       jne       short M14_L01
       add       rsp,8
       pop       rbx
       pop       rbp
       ret
M14_L00:
       xor       edi,edi
       call      qword ptr [710A3EBAEFA0]
       int       3
M14_L01:
       mov       edi,eax
       mov       rsi,rbx
       add       rsp,8
       pop       rbx
       pop       rbp
       jmp       qword ptr [710A3EBACA20]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
; Total bytes of code 61
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
M15_L00:
       mov       rdi,70FA788013A0
       mov       r13,[rdi]
       cmp       byte ptr [r13+9D],0
       jne       near ptr M15_L12
M15_L01:
       xor       eax,eax
       mov       edi,[r15+34]
       test      edi,200000
       jne       near ptr M15_L13
       test      edi,400000
       jne       near ptr M15_L14
       test      edi,1000000
       je        near ptr M15_L15
       mov       ecx,5
M15_L02:
       add       ecx,0FFFFFFFB
       jne       near ptr M15_L18
       cmp       byte ptr [r13+9D],0
       jne       near ptr M15_L20
M15_L03:
       cmp       byte ptr [710A3D06B06C],0
       jne       near ptr M15_L21
M15_L04:
       mov       rdi,r15
       mov       rax,offset MT_System.Threading.Tasks.Task<System.Int32>
       cmp       [rdi],rax
       jne       near ptr M15_L22
M15_L05:
       test      rdi,rdi
       je        near ptr M15_L23
       mov       esi,[rdi+34]
       and       esi,11000000
       cmp       esi,1000000
       jne       near ptr M15_L24
       mov       r15d,[rdi+38]
M15_L06:
       xor       r14d,r14d
       mov       eax,[rbx+34]
       mov       [rbp-24],eax
       test      eax,5600000
       jne       short M15_L10
       lea       rdi,[rbx+34]
       mov       esi,eax
       or        esi,4000000
       lock cmpxchg [rdi],esi
       cmp       eax,[rbp-24]
       jne       near ptr M15_L25
M15_L07:
       mov       [rbx+38],r15d
       lea       rdi,[rbx+34]
       mov       eax,[rbx+34]
       or        eax,1000000
       xchg      eax,[rdi]
       mov       r14,[rbx+28]
       test      r14,r14
       jne       near ptr M15_L26
M15_L08:
       lea       rdi,[rbx+20]
       test      rdi,rdi
       je        near ptr M15_L27
       mov       rsi,70FA78800238
       mov       rsi,[rsi]
       call      0000710ABC474040
       test      rax,rax
       je        short M15_L09
       mov       rdi,rbx
       mov       rsi,rax
       call      qword ptr [710A3EBA7720]; System.Threading.Tasks.Task.RunContinuations(System.Object)
M15_L09:
       mov       r14d,1
M15_L10:
       mov       eax,r14d
M15_L11:
       add       rsp,10
       pop       rbx
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M15_L12:
       mov       rdi,rbx
       call      qword ptr [710A3EBA70C0]
       mov       esi,eax
       mov       rdi,r13
       mov       edx,1
       call      qword ptr [710A3EBA7AE0]
       jmp       near ptr M15_L01
M15_L13:
       mov       ecx,7
       jmp       near ptr M15_L02
M15_L14:
       mov       ecx,6
       jmp       near ptr M15_L02
M15_L15:
       test      edi,800000
       je        short M15_L16
       mov       ecx,4
       jmp       near ptr M15_L02
M15_L16:
       test      edi,20000
       je        short M15_L17
       mov       ecx,3
       jmp       near ptr M15_L02
M15_L17:
       test      edi,2000000
       setne     cl
       movzx     ecx,cl
       mov       edx,2
       test      edi,10000
       cmovne    ecx,edx
       jmp       near ptr M15_L02
M15_L18:
       cmp       ecx,2
       ja        near ptr M15_L11
       mov       edi,ecx
       lea       rax,[710A3E0D6BA0]
       mov       eax,[rax+rdi*4]
       lea       rcx,[M15_L00]
       add       rax,rcx
       jmp       rax
       mov       rdi,r15
       call      qword ptr [710A3EBA7AF8]
       mov       r14,rax
       mov       rdi,r15
       call      qword ptr [710A3EBA7B10]
       mov       rdx,rax
       mov       rsi,r14
       mov       rdi,rbx
       call      qword ptr [710A3EBA7B28]
       jmp       near ptr M15_L11
       mov       rdi,r15
       call      qword ptr [710A3EBA7B40]
       mov       r15,rax
       test      r14b,r14b
       je        short M15_L19
       cmp       dword ptr [r15+10],0
       jle       short M15_L19
       mov       rdi,r15
       xor       esi,esi
       call      qword ptr [710A3E1469B8]
       mov       r13,rax
       test      r13,r13
       je        short M15_L19
       mov       rsi,[r13+8]
       mov       rdi,offset MT_System.OperationCanceledException
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M15_L19
       mov       rsi,[rax+70]
       mov       rdi,rbx
       mov       rdx,r13
       call      qword ptr [710A3EBA7B28]
       jmp       near ptr M15_L11
M15_L19:
       mov       rdi,rbx
       mov       rsi,r15
       call      qword ptr [710A3EBA7BB8]
       jmp       near ptr M15_L11
M15_L20:
       mov       rdi,rbx
       call      qword ptr [710A3EBA70C0]
       mov       esi,eax
       mov       rdi,r13
       mov       edx,1
       call      qword ptr [710A3EBA7BD0]
       jmp       near ptr M15_L03
M15_L21:
       mov       rdi,rbx
       call      qword ptr [710A3EBA7BE8]
       jmp       near ptr M15_L04
M15_L22:
       mov       rsi,r15
       mov       rdi,rax
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M15_L05
M15_L23:
       xor       r15d,r15d
       jmp       near ptr M15_L06
M15_L24:
       mov       esi,1
       call      qword ptr [710A3EBA7CA8]; System.Threading.Tasks.Task`1[[System.Int32, System.Private.CoreLib]].GetResultCore(Boolean)
       mov       r15d,eax
       jmp       near ptr M15_L06
M15_L25:
       mov       rdi,rbx
       mov       esi,4000000
       mov       edx,5600000
       call      qword ptr [710A3EBAED48]
       test      eax,eax
       je        near ptr M15_L10
       jmp       near ptr M15_L07
M15_L26:
       mov       rdi,rbx
       call      qword ptr [710A3EBAED60]
       mov       rdi,r14
       call      qword ptr [710A3EBAED78]
       jmp       near ptr M15_L08
M15_L27:
       call      qword ptr [710A3EBAE820]
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
       jne       short M16_L00
       mov       rdi,rbx
       mov       esi,0FFFFFFFF
       xor       edx,edx
       call      qword ptr [710A3EBA7810]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M16_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M16_L03
M16_L01:
       mov       edi,[rbx+34]
       and       edi,1600000
       cmp       edi,1000000
       jne       short M16_L04
M16_L02:
       pop       rbx
       pop       r15
       pop       rbp
       ret
M16_L03:
       mov       rdi,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M16_L01
       mov       rdi,rbx
       call      qword ptr [710A3EBAF840]
       jmp       short M16_L01
M16_L04:
       test      r15b,2
       jne       short M16_L05
       mov       rdi,rbx
       call      qword ptr [710A3EBAF690]
M16_L05:
       mov       rdi,rbx
       call      qword ptr [710A3EBAFAC8]
       jmp       short M16_L02
; Total bytes of code 125
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: DefaultJob)

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
       mov       rdi,7D82E4801350
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
       mov       rcx,7D82E4801370
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L48
M00_L02:
       cmp       [rcx],cl
       mov       rcx,7D82E4801380
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
       mov       rdi,7D9325AA0D68
       mov       rax,7D93263BE820
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
       call      qword ptr [7D92A7C8C030]; System.Threading.Thread.InitializeCurrentThread()
M00_L04:
       mov       rbx,[rax+8]
       test      rbx,rbx
       jne       near ptr M00_L50
       mov       rdi,7D82E4801390
       mov       rbx,[rdi]
M00_L05:
       test      rbx,rbx
       jne       near ptr M00_L09
       mov       rdi,[rbp-58]
       or        dword ptr [rdi+34],20000000
M00_L06:
       mov       rdi,[rbp-58]
       xor       esi,esi
       call      qword ptr [7D92A7F86880]; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
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
       call      qword ptr [7D92A743F0D8]
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
       mov       rdi,7D82E4801390
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
       mov       rdi,7D9325AA0D68
       mov       rax,7D93263BE820
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
       mov       rdi,7D82E48013A0
       mov       rdi,[rdi]
       cmp       byte ptr [rdi+9D],0
       jne       near ptr M00_L53
M00_L16:
       cmp       byte ptr [7D92A644B06C],0
       jne       near ptr M00_L54
M00_L17:
       mov       rdi,[rbp-58]
       test      dword ptr [rdi+34],1600000
       jne       near ptr M00_L55
       mov       rdi,[rbp-58]
       test      dword ptr [rdi+34],1600000
       jne       near ptr M00_L32
       mov       rdi,[rbp-58]
       cmp       qword ptr [rdi+20],0
       jne       short M00_L19
       mov       rdi,[rbp-58]
       add       rdi,20
       test      rdi,rdi
       je        near ptr M00_L72
       mov       rsi,[rbp-50]
       xor       edx,edx
       call      00007D9325874060
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
       mov       rsi,7D82E4800238
       mov       r15,[rsi]
       cmp       rbx,r15
       je        near ptr M00_L56
       mov       r14,rbx
       test      r14,r14
       je        short M00_L20
       mov       rdi,offset MT_System.Collections.Generic.List<System.Object>
       cmp       [r14],rdi
       jne       near ptr M00_L57
M00_L20:
       test      r14,r14
       jne       near ptr M00_L22
       mov       rdi,offset MT_System.Collections.Generic.List<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdi,7D82E4800AB0
       mov       rsi,[rdi]
       lea       rdi,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [r14+14]
       mov       rdi,r14
       mov       rsi,rbx
       call      qword ptr [7D92A74372D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       inc       dword ptr [r14+14]
       mov       rdi,[r14+8]
       mov       esi,[r14+10]
       cmp       [rdi+8],esi
       jbe       near ptr M00_L58
       lea       edx,[rsi+1]
       mov       [r14+10],edx
       mov       esi,esi
       mov       rdx,[rbp-50]
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M00_L21:
       mov       rdi,[rbp-58]
       add       rdi,20
       test      rdi,rdi
       je        near ptr M00_L72
       mov       rsi,r14
       mov       rdx,rbx
       call      00007D9325874060
       mov       r14,rax
       cmp       r14,rbx
       je        near ptr M00_L30
       mov       rsi,r14
       mov       rdi,offset MT_System.Collections.Generic.List<System.Object>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       je        near ptr M00_L56
M00_L22:
       mov       [rbp-60],r14
       xor       edi,edi
       mov       [rbp-28],edi
       mov       rdi,r14
       call      00007D93256E6020
       test      eax,eax
       jne       short M00_L23
       mov       rdi,r14
       call      qword ptr [7D92A7F87F78]; System.Threading.Monitor.Enter_Slowpath(System.Object)
M00_L23:
       mov       dword ptr [rbp-28],1
       mov       rdi,[rbp-58]
       cmp       [rdi+20],r15
       je        short M00_L25
       mov       edi,[r14+10]
       mov       rax,[r14+8]
       cmp       edi,[rax+8]
       je        short M00_L26
M00_L24:
       inc       dword ptr [r14+14]
       mov       rdi,[r14+8]
       mov       esi,[r14+10]
       cmp       [rdi+8],esi
       jbe       near ptr M00_L28
       lea       edx,[rsi+1]
       mov       [r14+10],edx
       mov       esi,esi
       mov       rdx,[rbp-50]
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M00_L29
M00_L25:
       xor       edi,edi
       mov       [rbp-2C],edi
       jmp       near ptr M00_L35
M00_L26:
       mov       rdi,7D82E4800290
       mov       rsi,[rdi]
       test      rsi,rsi
       jne       short M00_L27
       mov       rdi,offset MT_System.Predicate<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdi,7D82E4800260
       mov       rsi,[rdi]
       lea       rdi,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset System.Threading.Tasks.Task+<>c.<AddTaskContinuationComplex>b__211_0(System.Object)
       mov       [rbx+18],rdi
       mov       rdi,7D82E4800290
       mov       rsi,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,rbx
M00_L27:
       mov       rdi,r14
       cmp       [rdi],edi
       call      qword ptr [7D92A7F87F60]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAll(System.Predicate`1<System.__Canon>)
       jmp       near ptr M00_L24
M00_L28:
       mov       rdi,r14
       mov       rsi,[rbp-50]
       call      qword ptr [7D92A74372D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       nop
M00_L29:
       mov       rdi,r14
       call      00007D93256E6790
       test      eax,eax
       jne       near ptr M00_L59
M00_L30:
       mov       ebx,1
M00_L31:
       test      ebx,ebx
       jne       near ptr M00_L18
M00_L32:
       call      00007D93258F8300
       test      eax,eax
       je        near ptr M00_L65
       mov       rdi,[rbp-50]
       movzx     ebx,byte ptr [rdi+3C]
       test      ebx,ebx
       jne       near ptr M00_L60
       mov       rdi,[rbp-50]
       mov       byte ptr [rdi+3C],1
       mov       rdi,[rbp-58]
       call      qword ptr [7D92A7F87E70]; System.Threading.Tasks.Task.get_Status()
       cmp       eax,5
       jne       near ptr M00_L61
       mov       rdi,[rbp-58]
       mov       edi,[rdi+34]
       and       edi,11000000
       cmp       edi,1000000
       jne       near ptr M00_L62
       mov       rdi,[rbp-58]
       mov       rsi,[rdi+38]
M00_L33:
       test      rsi,rsi
       je        near ptr M00_L63
       test      dword ptr [rsi+34],1600000
       je        near ptr M00_L64
       mov       rdi,[rbp-50]
       xor       edx,edx
       call      qword ptr [7D92A7F87E58]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
M00_L34:
       mov       rdi,[rbp-50]
       mov       byte ptr [rdi+3C],2
       jmp       near ptr M00_L18
M00_L35:
       call      M00_L73
       nop
       mov       ebx,[rbp-2C]
       jmp       near ptr M00_L31
M00_L36:
       mov       rsi,rbx
       test      rsi,rsi
       je        near ptr M00_L66
       lea       rbx,[rsi+10]
       mov       r15d,[rsi+8]
       test      r15d,r15d
       je        near ptr M00_L67
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
       call      qword ptr [7D92A7F8FE28]
       jmp       short M00_L38
M00_L37:
       mov       rsi,rbx
       call      00007D9325870D90
       cmp       dword ptr [7D9325ACEC80],0
       jne       near ptr M00_L68
M00_L38:
       mov       ebx,[r14+8]
       test      ebx,ebx
       jle       short M00_L40
       lea       rdi,[r14+10]
       mov       esi,ebx
M00_L39:
       cmp       qword ptr [rdi],0
       je        near ptr M00_L69
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
       mov       rdi,7D82E48013A0
       mov       rdi,[rdi]
       cmp       byte ptr [rdi+9D],0
       jne       near ptr M00_L70
M00_L41:
       cmp       byte ptr [7D92A644B06C],0
       jne       near ptr M00_L71
M00_L42:
       test      ebx,ebx
       jle       short M00_L47
       add       r14,10
       jmp       short M00_L45
M00_L43:
       mov       rdi,r15
       mov       rsi,r13
       call      qword ptr [7D92A7FCB718]; System.Threading.Tasks.Task+WhenAllPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
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
       je        near ptr M00_L72
       mov       rsi,r15
       xor       edx,edx
       call      00007D9325874060
       test      rax,rax
       je        short M00_L44
M00_L46:
       mov       rdi,r13
       mov       rsi,r15
       xor       edx,edx
       call      qword ptr [7D92A7F87F00]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
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
       mov       rdi,7D82E4801370
       xor       edx,edx
       call      00007D9325874060
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M00_L02
       mov       rcx,7D82E4801370
       mov       rcx,[rcx]
       jmp       near ptr M00_L02
M00_L49:
       mov       edi,4
       call      qword ptr [7D92A7F8F468]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L03
M00_L50:
       cmp       byte ptr [rbx+18],0
       je        near ptr M00_L05
       xor       ebx,ebx
       jmp       near ptr M00_L05
M00_L51:
       mov       edi,8
       call      qword ptr [7D92A7F8F468]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L12
M00_L52:
       mov       rdi,[rdi+30]
       test      rdi,rdi
       je        near ptr M00_L15
       test      bl,4
       je        near ptr M00_L15
       test      byte ptr [rdi+34],8
       jne       near ptr M00_L15
       call      qword ptr [7D92A7F8F138]
       jmp       near ptr M00_L15
M00_L53:
       mov       rdi,[rbp-50]
       call      qword ptr [7D92A7F87228]
       mov       esi,eax
       mov       rdi,7D82E48013A0
       mov       rdi,[rdi]
       mov       rdx,7D929640A878
       xor       ecx,ecx
       call      qword ptr [7D92A7F87240]
       jmp       near ptr M00_L16
M00_L54:
       mov       rdi,[rbp-50]
       call      qword ptr [7D92A7F87258]
       jmp       near ptr M00_L17
M00_L55:
       mov       rdi,[rbp-50]
       mov       rsi,[rbp-58]
       call      qword ptr [7D92A7F87288]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].ProcessCompletedOuterTask(System.Threading.Tasks.Task)
       jmp       near ptr M00_L18
M00_L56:
       xor       ebx,ebx
       jmp       near ptr M00_L31
M00_L57:
       mov       rsi,rbx
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       jmp       near ptr M00_L20
M00_L58:
       mov       rdi,r14
       mov       rsi,[rbp-50]
       call      qword ptr [7D92A74372D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L21
M00_L59:
       mov       edi,eax
       mov       rsi,r14
       call      qword ptr [7D92A7F8CB28]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       near ptr M00_L30
M00_L60:
       cmp       ebx,1
       jne       near ptr M00_L18
       mov       rdi,[rbp-50]
       mov       rsi,[rbp-58]
       xor       edx,edx
       call      qword ptr [7D92A7F87E58]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       jmp       near ptr M00_L34
M00_L61:
       add       eax,0FFFFFFFA
       cmp       eax,1
       ja        near ptr M00_L18
       mov       rdx,[rbp-50]
       movzx     edx,byte ptr [rdx+3D]
       mov       rdi,[rbp-50]
       mov       rsi,[rbp-58]
       call      qword ptr [7D92A7F87E58]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       jmp       near ptr M00_L18
M00_L62:
       mov       rdi,[rbp-58]
       mov       esi,1
       call      qword ptr [7D92A7F8FA98]
       mov       rsi,rax
       jmp       near ptr M00_L33
M00_L63:
       mov       rdi,[rbp-50]
       xor       esi,esi
       xor       edx,edx
       call      qword ptr [7D92A7F8C7C8]
       jmp       near ptr M00_L34
M00_L64:
       mov       rdi,rsi
       mov       rsi,[rbp-50]
       xor       edx,edx
       call      qword ptr [7D92A7F872A0]; System.Threading.Tasks.Task.AddCompletionAction(System.Threading.Tasks.ITaskCompletionAction, Boolean)
       jmp       near ptr M00_L18
M00_L65:
       mov       rdi,[rbp-50]
       mov       rsi,[rbp-58]
       call      qword ptr [7D92A7F87E40]
       jmp       near ptr M00_L18
M00_L66:
       mov       edi,33
       call      qword ptr [7D92A743FAE0]
       int       3
M00_L67:
       mov       rdi,offset MT_System.Threading.Tasks.Task<System.Int32[]>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdi,r15
       xor       esi,esi
       mov       rdx,7D929640A1C8
       xor       ecx,ecx
       xor       r8d,r8d
       call      qword ptr [7D92A7F876C0]
       jmp       near ptr M00_L47
M00_L68:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L38
M00_L69:
       mov       edi,1D
       mov       esi,33
       call      qword ptr [7D92A7F87720]
       int       3
M00_L70:
       mov       rdi,r15
       call      qword ptr [7D92A7F87228]
       mov       esi,eax
       mov       rdi,7D82E48013A0
       mov       rdi,[rdi]
       mov       rdx,7D929640AF08
       xor       ecx,ecx
       call      qword ptr [7D92A7F87240]
       jmp       near ptr M00_L41
M00_L71:
       mov       rdi,r15
       call      qword ptr [7D92A7F87258]
       jmp       near ptr M00_L42
M00_L72:
       call      qword ptr [7D92A7F8F0C0]
       int       3
M00_L73:
       push      rax
       cmp       dword ptr [rbp-28],0
       je        short M00_L74
       mov       rdi,[rbp-60]
       call      00007D93256E6790
       test      eax,eax
       je        short M00_L74
       mov       edi,eax
       mov       rsi,[rbp-60]
       call      qword ptr [7D92A7F8CB28]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M00_L74:
       nop
       add       rsp,8
       ret
; Total bytes of code 2600
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
       jmp       qword ptr [7D92A7F87888]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
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
       call      qword ptr [7D92A6FDEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdi,[rbp-90]
       call      qword ptr [rax]
       lea       rdi,[rbp-88]
       call      qword ptr [7D92A6FDEF08]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-30]
       call      qword ptr [7D92A6FE0B98]
       lea       rdi,[rax+10]
       mov       rsi,[rbp-30]
       call      qword ptr [7D92A6FDEEB8]; CORINFO_HELP_ASSIGN_REF
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
       cmp       byte ptr [7D92A644B06C],0
       jne       near ptr M03_L20
M03_L01:
       mov       rax,7D82E48013A0
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
       mov       rsi,7D82E48013A8
       mov       rbx,[rsi]
       cmp       byte ptr [rbx+38],0
       jne       near ptr M03_L13
M03_L04:
       test      r15b,1
       jne       short M03_L06
       mov       rdi,7D9325AA0D68
       mov       rax,7D93263BE820
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
       call      qword ptr [7D92A7F8C6F0]; System.Threading.ThreadPoolWorkQueue+WorkStealingQueue.LocalPush(System.Object)
       jmp       short M03_L10
M03_L09:
       test      eax,eax
       jge       short M03_L07
       mov       rdi,rsi
       mov       rsi,[rbp-20]
       call      qword ptr [7D92A7F8F480]
M03_L10:
       add       rbx,78
       mov       edi,1
       xchg      edi,[rbx]
       test      edi,edi
       jne       near ptr M03_L18
       mov       rdi,7D82E48013D0
       mov       rbx,[rdi]
       lea       rdi,[rbx+160]
       lock inc  dword ptr [rdi]
       mov       rdi,rbx
       call      qword ptr [7D92A7F86C58]; System.Threading.PortableThreadPool+WorkerThread.MaybeAddWorkingWorker(System.Threading.PortableThreadPool)
       cmp       dword ptr [rbx+164],6
       je        near ptr M03_L18
       jmp       near ptr M03_L16
M03_L11:
       mov       rsi,r15
       call      qword ptr [7D92A7F8F708]
       mov       rdi,[rbp-20]
       jmp       near ptr M03_L03
M03_L12:
       mov       rdi,offset MT_System.Threading.Tasks.ThreadPoolTaskScheduler
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdi,7D82E4801488
       mov       rbx,[rdi]
       mov       rdi,offset MT_System.Threading.Thread
       call      CORINFO_HELP_NEWFAST
       mov       r15,rax
       mov       rdi,r15
       mov       rsi,rbx
       call      qword ptr [7D92A8044330]
       mov       rdi,r15
       mov       esi,1
       call      qword ptr [7D92A7F86E38]; System.Threading.Thread.set_IsBackground(Boolean)
       mov       rdi,r15
       mov       rsi,7D9296409FB0
       call      qword ptr [7D92A7F86F40]; System.Threading.Thread.set_Name(System.String)
       mov       rdi,r15
       mov       rsi,[rbp-20]
       xor       edx,edx
       call      qword ptr [7D92A8044348]
       jmp       short M03_L18
M03_L13:
       mov       rsi,7D82E48013C0
       mov       rsi,[rsi]
       cmp       byte ptr [rsi+9D],0
       je        near ptr M03_L04
       mov       rsi,7D82E48013C0
       mov       rdi,[rsi]
       mov       rsi,[rbp-20]
       call      qword ptr [7D92A7F8F450]
       jmp       near ptr M03_L04
M03_L14:
       mov       edi,5
       call      qword ptr [7D92A7F8F468]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M03_L05
M03_L15:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M03_L16:
       mov       rdi,rbx
       call      qword ptr [7D92A7F86EC8]; System.Threading.PortableThreadPool+GateThread.EnsureRunningSlow(System.Threading.PortableThreadPool)
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
       call      qword ptr [7D92A8044318]
       test      eax,eax
       mov       rdi,[rbp-20]
       jne       near ptr M03_L00
       jmp       short M03_L18
M03_L20:
       call      qword ptr [7D92A7F87258]
       mov       rdi,[rbp-20]
       jmp       near ptr M03_L01
M03_L21:
       test      word ptr [rdi+34],200
       jne       near ptr M03_L02
       call      qword ptr [7D92A7F87228]
       mov       r15d,eax
       mov       rdi,[rbp-20]
       mov       rdi,[rdi+8]
       call      qword ptr [7D92A7F8F678]
       mov       rsi,rax
       mov       rdi,7D9296409F28
       call      qword ptr [7D92A743EFA0]; System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       esi,r15d
       mov       rdi,rbx
       xor       ecx,ecx
       call      qword ptr [7D92A7F87240]
       mov       rdi,[rbp-20]
       jmp       near ptr M03_L02
       push      rax
       mov       rbx,rdi
       mov       rdi,offset MT_System.Threading.Tasks.TaskSchedulerException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdi,r15
       mov       rsi,rbx
       call      qword ptr [7D92A7F8F690]
       mov       rdi,[rbp-20]
       mov       rsi,r15
       call      qword ptr [7D92A7F8F6A8]
       mov       rdi,[rbp-20]
       xor       esi,esi
       call      qword ptr [7D92A7F8F6C0]
       mov       rdi,[rbp-20]
       call      qword ptr [7D92A7F8F6D8]
       test      eax,200
       jne       short M03_L22
       mov       rdi,[rbp-20]
       mov       rdi,[rdi+28]
       mov       rdi,[rdi+18]
       xor       esi,esi
       cmp       [rdi],edi
       call      qword ptr [7D92A7F8F6F0]
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
       jmp       qword ptr [7D92A7F87828]; System.Threading.Tasks.AsyncLazy`1[[System.Int32, System.Private.CoreLib]].GetOrStartAttemptAsync(System.Threading.CancellationToken)
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
       jmp       qword ptr [7D92A7C87A68]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
M05_L00:
       mov       rdi,rax
       mov       rsi,rdx
       pop       rbp
       jmp       near ptr 00007D93259FB900
M05_L01:
       xor       ecx,ecx
       mov       [rax],rcx
       pop       rbp
       ret
M05_L02:
       call      qword ptr [7D92A7F8EF70]
       int       3
; Total bytes of code 85
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
       jne       short M06_L01
       mov       r12d,4
M06_L00:
       mov       esi,7FFFFFC7
       cmp       r12d,7FFFFFC7
       cmova     r12d,esi
       cmp       r12d,edi
       cmovl     r12d,edi
       cmp       r12d,r14d
       jge       short M06_L02
       mov       edi,7
       mov       esi,0F
       call      qword ptr [7D92A7F0C210]
       int       3
M06_L01:
       mov       rsi,[rbx+8]
       mov       r12d,[rsi+8]
       add       r12d,r12d
       jmp       short M06_L00
M06_L02:
       mov       rdi,[rbx+8]
       cmp       [rdi+8],r12d
       je        near ptr M06_L08
       test      r12d,r12d
       jg        short M06_L05
       mov       rdi,[rbx]
       mov       rsi,[rdi+30]
       mov       rsi,[rsi]
       mov       rsi,[rsi+38]
       test      rsi,rsi
       je        short M06_L04
M06_L03:
       mov       rdi,rsi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rsi,[rax]
       lea       rdi,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M06_L08
M06_L04:
       mov       rsi,7D92A7FDED98
       call      qword ptr [7D92A743F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
       jmp       short M06_L03
M06_L05:
       mov       rdi,[rbx]
       mov       rsi,[rdi+30]
       mov       rsi,[rsi]
       mov       rax,[rsi+40]
       test      rax,rax
       je        short M06_L09
       mov       rdi,rax
M06_L06:
       mov       esi,r12d
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r12,rax
       test      r14d,r14d
       jle       short M06_L07
       mov       rdi,[rbx+8]
       mov       edx,r14d
       mov       rsi,r12
       call      qword ptr [7D92A74369E8]; System.Array.Copy(System.Array, System.Array, Int32)
M06_L07:
       lea       rdi,[rbx+8]
       mov       rsi,r12
       call      CORINFO_HELP_ASSIGN_REF
M06_L08:
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
M06_L09:
       mov       rsi,7D92A7FDEDA8
       call      qword ptr [7D92A743F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       short M06_L06
; Total bytes of code 317
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       push      rbp
       mov       rbp,rsp
       test      rsi,rsi
       je        short M07_L02
       mov       rax,[rsi]
       cmp       rax,rdi
       je        short M07_L02
       mov       rax,[rax+10]
       cmp       rax,rdi
       je        short M07_L02
M07_L00:
       test      rax,rax
       je        short M07_L01
       mov       rax,[rax+10]
       cmp       rax,rdi
       je        short M07_L02
       test      rax,rax
       je        short M07_L01
       mov       rax,[rax+10]
       cmp       rax,rdi
       je        short M07_L02
       test      rax,rax
       je        short M07_L01
       mov       rax,[rax+10]
       cmp       rax,rdi
       je        short M07_L02
       test      rax,rax
       jne       short M07_L03
M07_L01:
       xor       esi,esi
M07_L02:
       mov       rax,rsi
       pop       rbp
       ret
M07_L03:
       mov       rax,[rax+10]
       cmp       rax,rdi
       je        short M07_L02
       jmp       short M07_L00
; Total bytes of code 91
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
       mov       rax,7D92A7477D28
       mov       [rbp-58],rax
       lea       rax,[M08_L00]
       mov       [rbp-48],rax
       lea       rax,[rbp-68]
       mov       [rbx+8],rax
       mov       byte ptr [rbx+4],0
       mov       rax,7D93256E5E10
       call      rax
M08_L00:
       mov       byte ptr [rbx+4],1
       cmp       dword ptr [7D9325ACEC80],0
       je        short M08_L01
       call      qword ptr [7D9325ABB1D8]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7D92A743FAE0]
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
       call      qword ptr [7D92A80442B8]
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
; System.Threading.Tasks.Task.get_Status()
       push      rbp
       mov       rbp,rsp
       mov       eax,[rdi+34]
       test      eax,200000
       jne       short M11_L01
       test      eax,400000
       jne       short M11_L02
       test      eax,1000000
       je        short M11_L03
       mov       eax,5
M11_L00:
       pop       rbp
       ret
M11_L01:
       mov       eax,7
       jmp       short M11_L00
M11_L02:
       mov       eax,6
       jmp       short M11_L00
M11_L03:
       test      eax,800000
       je        short M11_L04
       mov       eax,4
       jmp       short M11_L00
M11_L04:
       test      eax,20000
       je        short M11_L05
       mov       eax,3
       jmp       short M11_L00
M11_L05:
       test      eax,2000000
       setne     cl
       movzx     ecx,cl
       mov       edx,2
       test      eax,10000
       mov       eax,edx
       cmove     eax,ecx
       jmp       short M11_L00
; Total bytes of code 105
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
M12_L00:
       mov       rdi,7D82E48013A0
       mov       r13,[rdi]
       cmp       byte ptr [r13+9D],0
       jne       near ptr M12_L12
M12_L01:
       xor       eax,eax
       mov       edi,[r15+34]
       test      edi,200000
       jne       near ptr M12_L13
       test      edi,400000
       jne       near ptr M12_L14
       test      edi,1000000
       je        near ptr M12_L15
       mov       ecx,5
M12_L02:
       add       ecx,0FFFFFFFB
       jne       near ptr M12_L18
       cmp       byte ptr [r13+9D],0
       jne       near ptr M12_L20
M12_L03:
       cmp       byte ptr [7D92A644B06C],0
       jne       near ptr M12_L21
M12_L04:
       mov       rdi,r15
       mov       rax,offset MT_System.Threading.Tasks.Task<System.Int32>
       cmp       [rdi],rax
       jne       near ptr M12_L22
M12_L05:
       test      rdi,rdi
       je        near ptr M12_L23
       mov       esi,[rdi+34]
       and       esi,11000000
       cmp       esi,1000000
       jne       near ptr M12_L24
       mov       r15d,[rdi+38]
M12_L06:
       xor       r14d,r14d
       mov       eax,[rbx+34]
       mov       [rbp-24],eax
       test      eax,5600000
       jne       short M12_L10
       lea       rdi,[rbx+34]
       mov       esi,eax
       or        esi,4000000
       lock cmpxchg [rdi],esi
       cmp       eax,[rbp-24]
       jne       near ptr M12_L25
M12_L07:
       mov       [rbx+38],r15d
       lea       rdi,[rbx+34]
       mov       eax,[rbx+34]
       or        eax,1000000
       xchg      eax,[rdi]
       mov       r14,[rbx+28]
       test      r14,r14
       jne       near ptr M12_L26
M12_L08:
       lea       rdi,[rbx+20]
       test      rdi,rdi
       je        near ptr M12_L27
       mov       rsi,7D82E4800238
       mov       rsi,[rsi]
       call      00007D9325874040
       test      rax,rax
       je        short M12_L09
       mov       rdi,rbx
       mov       rsi,rax
       call      qword ptr [7D92A7F87DC8]; System.Threading.Tasks.Task.RunContinuations(System.Object)
M12_L09:
       mov       r14d,1
M12_L10:
       mov       eax,r14d
M12_L11:
       add       rsp,10
       pop       rbx
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M12_L12:
       mov       rdi,rbx
       call      qword ptr [7D92A7F87228]
       mov       esi,eax
       mov       rdi,r13
       mov       edx,1
       call      qword ptr [7D92A7F8C780]
       jmp       near ptr M12_L01
M12_L13:
       mov       ecx,7
       jmp       near ptr M12_L02
M12_L14:
       mov       ecx,6
       jmp       near ptr M12_L02
M12_L15:
       test      edi,800000
       je        short M12_L16
       mov       ecx,4
       jmp       near ptr M12_L02
M12_L16:
       test      edi,20000
       je        short M12_L17
       mov       ecx,3
       jmp       near ptr M12_L02
M12_L17:
       test      edi,2000000
       setne     cl
       movzx     ecx,cl
       mov       edx,2
       test      edi,10000
       cmovne    ecx,edx
       jmp       near ptr M12_L02
M12_L18:
       cmp       ecx,2
       ja        near ptr M12_L11
       mov       edi,ecx
       lea       rax,[7D92A74BDCA0]
       mov       eax,[rax+rdi*4]
       lea       rcx,[M12_L00]
       add       rax,rcx
       jmp       rax
       mov       rdi,r15
       call      qword ptr [7D92A7F8C798]
       mov       r14,rax
       mov       rdi,r15
       call      qword ptr [7D92A7F8C7B0]
       mov       rdx,rax
       mov       rsi,r14
       mov       rdi,rbx
       call      qword ptr [7D92A7F8C7C8]
       jmp       near ptr M12_L11
       mov       rdi,r15
       call      qword ptr [7D92A7F8C7E0]
       mov       r15,rax
       test      r14b,r14b
       je        short M12_L19
       cmp       dword ptr [r15+10],0
       jle       short M12_L19
       mov       rdi,r15
       xor       esi,esi
       call      qword ptr [7D92A75269B8]
       mov       r13,rax
       test      r13,r13
       je        short M12_L19
       mov       rsi,[r13+8]
       mov       rdi,offset MT_System.OperationCanceledException
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M12_L19
       mov       rsi,[rax+70]
       mov       rdi,rbx
       mov       rdx,r13
       call      qword ptr [7D92A7F8C7C8]
       jmp       near ptr M12_L11
M12_L19:
       mov       rdi,rbx
       mov       rsi,r15
       call      qword ptr [7D92A7F8C858]
       jmp       near ptr M12_L11
M12_L20:
       mov       rdi,rbx
       call      qword ptr [7D92A7F87228]
       mov       esi,eax
       mov       rdi,r13
       mov       edx,1
       call      qword ptr [7D92A7F8C870]
       jmp       near ptr M12_L03
M12_L21:
       mov       rdi,rbx
       call      qword ptr [7D92A7F8C888]
       jmp       near ptr M12_L04
M12_L22:
       mov       rsi,r15
       mov       rdi,rax
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M12_L05
M12_L23:
       xor       r15d,r15d
       jmp       near ptr M12_L06
M12_L24:
       mov       esi,1
       call      qword ptr [7D92A7F8C900]; System.Threading.Tasks.Task`1[[System.Int32, System.Private.CoreLib]].GetResultCore(Boolean)
       mov       r15d,eax
       jmp       near ptr M12_L06
M12_L25:
       mov       rdi,rbx
       mov       esi,4000000
       mov       edx,5600000
       call      qword ptr [7D92A7F8F5B8]
       test      eax,eax
       je        near ptr M12_L10
       jmp       near ptr M12_L07
M12_L26:
       mov       rdi,rbx
       call      qword ptr [7D92A7F8F5D0]
       mov       rdi,r14
       call      qword ptr [7D92A7F8F5E8]
       jmp       near ptr M12_L08
M12_L27:
       call      qword ptr [7D92A7F8F0C0]
       int       3
; Total bytes of code 782
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
       mov       rdi,7D82E48013A0
       mov       r15,[rdi]
       cmp       byte ptr [r15+9D],0
       jne       near ptr M13_L11
M13_L00:
       lea       rsi,[rbx+48]
       mov       edi,0FFFFFFFF
       lock xadd [rsi],edi
       dec       edi
       je        short M13_L02
M13_L01:
       add       rsp,28
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M13_L02:
       mov       rsi,[rbx+40]
       mov       esi,[rsi+8]
       mov       rdi,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       xor       r13d,r13d
       xor       r12d,r12d
       xor       eax,eax
M13_L03:
       mov       rdi,[rbx+40]
       cmp       [rdi+8],eax
       jle       near ptr M13_L08
       cmp       eax,[rdi+8]
       jae       near ptr M13_L23
       mov       [rbp-2C],eax
       mov       ecx,eax
       mov       [rbp-38],rcx
       mov       r8,[rdi+rcx*8+10]
       mov       [rbp-40],r8
       test      dword ptr [r8+34],200000
       jne       near ptr M13_L12
       mov       edi,[r8+34]
       and       edi,600000
       cmp       edi,400000
       je        near ptr M13_L15
       test      dword ptr [r8+34],1600000
       je        near ptr M13_L16
M13_L04:
       mov       edi,[r8+34]
       and       edi,1600000
       cmp       edi,1000000
       jne       near ptr M13_L17
M13_L05:
       mov       edi,[r8+38]
       mov       eax,[rbp-2C]
       cmp       eax,[r14+8]
       jae       near ptr M13_L23
       mov       rcx,[rbp-38]
       mov       [r14+rcx*4+10],edi
M13_L06:
       test      dword ptr [r8+34],10000000
       jne       near ptr M13_L18
       mov       rdi,[rbx+40]
       mov       eax,[rbp-2C]
       cmp       eax,[rdi+8]
       jae       near ptr M13_L23
       xor       esi,esi
       mov       rcx,[rbp-38]
       mov       [rdi+rcx*8+10],rsi
M13_L07:
       mov       eax,[rbp-2C]
       inc       eax
       jmp       near ptr M13_L03
M13_L08:
       test      r13,r13
       jne       near ptr M13_L19
       test      r12,r12
       jne       near ptr M13_L20
       cmp       byte ptr [r15+9D],0
       jne       near ptr M13_L21
M13_L09:
       cmp       byte ptr [7D92A644B06C],0
       jne       near ptr M13_L22
M13_L10:
       mov       rdi,rbx
       mov       rsi,r14
       call      qword ptr [7D92A7F8C948]; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].TrySetResult(System.__Canon)
       jmp       near ptr M13_L01
M13_L11:
       mov       rdi,rbx
       call      qword ptr [7D92A7F87228]
       mov       esi,eax
       mov       rdi,r15
       mov       edx,1
       call      qword ptr [7D92A7F8C780]
       jmp       near ptr M13_L00
M13_L12:
       test      r13,r13
       jne       short M13_L13
       mov       rdi,offset MT_System.Collections.Generic.List<System.Runtime.ExceptionServices.ExceptionDispatchInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdi,r13
       call      qword ptr [7D92A7C8EE50]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       r8,[rbp-40]
M13_L13:
       mov       rdi,[r8+28]
       mov       rdx,[rdi+18]
       mov       [rbp-48],rdx
       mov       rsi,[rdx+10]
       mov       [rbp-50],rsi
       cmp       byte ptr [rdx+20],0
       jne       short M13_L14
       mov       rdi,rdx
       call      qword ptr [7D92A7C86868]; System.GC.SuppressFinalize(System.Object)
       mov       rdi,[rbp-48]
       mov       byte ptr [rdi+20],1
M13_L14:
       mov       rdi,r13
       mov       rsi,[rbp-50]
       cmp       [rdi],edi
       call      qword ptr [7D92A7F8C8E8]
       mov       r8,[rbp-40]
       jmp       near ptr M13_L06
M13_L15:
       test      r12,r12
       jne       near ptr M13_L06
       mov       r12,r8
       mov       r8,[rbp-40]
       jmp       near ptr M13_L06
M13_L16:
       mov       rdi,r8
       mov       esi,0FFFFFFFF
       xor       edx,edx
       call      qword ptr [7D92A7F878A0]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
       mov       r8,[rbp-40]
       jmp       near ptr M13_L04
M13_L17:
       mov       rdi,r8
       mov       esi,1
       call      qword ptr [7D92A8044300]
       mov       r8,[rbp-40]
       jmp       near ptr M13_L05
M13_L18:
       mov       rdi,rbx
       mov       esi,1
       call      qword ptr [7D92A7F8C930]
       jmp       near ptr M13_L07
M13_L19:
       mov       rdi,rbx
       mov       rsi,r13
       call      qword ptr [7D92A7F8C858]
       jmp       near ptr M13_L01
M13_L20:
       mov       rdi,r12
       call      qword ptr [7D92A7F8C798]
       mov       r13,rax
       mov       rdi,r12
       call      qword ptr [7D92A7F8C7B0]
       mov       rdx,rax
       mov       rsi,r13
       mov       rdi,rbx
       call      qword ptr [7D92A7F8C7C8]
       jmp       near ptr M13_L01
M13_L21:
       mov       rdi,rbx
       call      qword ptr [7D92A7F87228]
       mov       esi,eax
       mov       rdi,r15
       mov       edx,1
       call      qword ptr [7D92A7F8C870]
       jmp       near ptr M13_L09
M13_L22:
       mov       rdi,rbx
       call      qword ptr [7D92A7F8C888]
       jmp       near ptr M13_L10
M13_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 694
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
       mov       rsi,7D82E4800238
       cmp       r13,[rsi]
       je        near ptr M14_L14
       mov       r12,r13
       test      r12,r12
       je        short M14_L00
       mov       rdi,offset MT_System.Collections.Generic.List<System.Object>
       cmp       [r12],rdi
       jne       near ptr M14_L15
M14_L00:
       test      r12,r12
       jne       near ptr M14_L02
       mov       rdi,offset MT_System.Collections.Generic.List<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rdi,7D82E4800AB0
       mov       rsi,[rdi]
       lea       rdi,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      r14b,r14b
       jne       near ptr M14_L17
       inc       dword ptr [r12+14]
       mov       rdi,r12
       mov       rsi,r13
       call      qword ptr [7D92A74372D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       inc       dword ptr [r12+14]
       mov       rdi,[r12+8]
       mov       esi,[r12+10]
       cmp       [rdi+8],esi
       jbe       near ptr M14_L16
       lea       edx,[rsi+1]
       mov       [r12+10],edx
       mov       esi,esi
       mov       rdx,r15
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M14_L01:
       lea       rdi,[rbx+20]
       test      rdi,rdi
       je        near ptr M14_L19
       mov       rsi,r12
       mov       rdx,r13
       call      00007D9325874060
       mov       r12,rax
       cmp       r12,r13
       je        near ptr M14_L12
       mov       rsi,r12
       mov       rdi,offset MT_System.Collections.Generic.List<System.Object>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r12,rax
       test      r12,r12
       je        near ptr M14_L14
M14_L02:
       mov       [rbp-38],r12
       xor       edi,edi
       mov       [rbp-2C],edi
       mov       rdi,r12
       call      00007D93256E6020
       test      eax,eax
       jne       short M14_L03
       mov       rdi,r12
       call      qword ptr [7D92A7F87F78]; System.Threading.Monitor.Enter_Slowpath(System.Object)
M14_L03:
       mov       dword ptr [rbp-2C],1
       mov       rdi,[rbx+20]
       mov       rax,7D82E4800238
       cmp       rdi,[rax]
       je        short M14_L08
       mov       edi,[r12+10]
       mov       rax,[r12+8]
       cmp       edi,[rax+8]
       je        short M14_L05
M14_L04:
       test      r14b,r14b
       jne       near ptr M14_L10
       inc       dword ptr [r12+14]
       mov       rdi,[r12+8]
       mov       esi,[r12+10]
       cmp       [rdi+8],esi
       jbe       short M14_L07
       lea       edx,[rsi+1]
       mov       [r12+10],edx
       mov       esi,esi
       mov       rdx,r15
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M14_L11
M14_L05:
       mov       rdi,7D82E4800290
       mov       rsi,[rdi]
       test      rsi,rsi
       je        short M14_L09
M14_L06:
       mov       rdi,r12
       cmp       [rdi],edi
       call      qword ptr [7D92A7F87F60]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAll(System.Predicate`1<System.__Canon>)
       jmp       short M14_L04
M14_L07:
       mov       rdi,r12
       mov       rsi,r15
       call      qword ptr [7D92A74372D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M14_L11
M14_L08:
       xor       edi,edi
       mov       [rbp-30],edi
       jmp       short M14_L13
M14_L09:
       mov       rdi,offset MT_System.Predicate<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rsi,7D82E4800260
       mov       rsi,[rsi]
       mov       rdi,rbx
       mov       rdx,offset System.Threading.Tasks.Task+<>c.<AddTaskContinuationComplex>b__211_0(System.Object)
       call      qword ptr [7D92A7436E08]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdi,7D82E4800290
       mov       rsi,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,rbx
       jmp       short M14_L06
M14_L10:
       mov       rdi,r12
       mov       rdx,r15
       xor       esi,esi
       call      qword ptr [7D92A7526A30]
       nop
M14_L11:
       mov       rdi,r12
       call      00007D93256E6790
       test      eax,eax
       jne       near ptr M14_L20
M14_L12:
       mov       eax,1
       add       rsp,18
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M14_L13:
       call      M14_L21
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
M14_L14:
       xor       eax,eax
       add       rsp,18
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M14_L15:
       mov       rsi,r13
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r12,rax
       jmp       near ptr M14_L00
M14_L16:
       mov       rdi,r12
       mov       rsi,r15
       call      qword ptr [7D92A74372D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M14_L01
M14_L17:
       inc       dword ptr [r12+14]
       mov       rdi,r12
       mov       rsi,r15
       call      qword ptr [7D92A74372D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       inc       dword ptr [r12+14]
       mov       rdi,[r12+8]
       mov       esi,[r12+10]
       cmp       [rdi+8],esi
       jbe       short M14_L18
       lea       edx,[rsi+1]
       mov       [r12+10],edx
       mov       esi,esi
       mov       rdx,r13
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M14_L01
M14_L18:
       mov       rdi,r12
       mov       rsi,r13
       call      qword ptr [7D92A74372D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M14_L01
M14_L19:
       call      qword ptr [7D92A7F8F0C0]
       int       3
M14_L20:
       mov       edi,eax
       mov       rsi,r12
       call      qword ptr [7D92A7F8CB28]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       near ptr M14_L12
M14_L21:
       push      rax
       cmp       dword ptr [rbp-2C],0
       je        short M14_L22
       mov       rdi,[rbp-38]
       call      00007D93256E6790
       test      eax,eax
       je        short M14_L22
       mov       edi,eax
       mov       rsi,[rbp-38]
       call      qword ptr [7D92A7F8CB28]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M14_L22:
       nop
       add       rsp,8
       ret
; Total bytes of code 777
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbp
       push      rbx
       push      rax
       lea       rbp,[rsp+10]
       mov       ebx,edi
       call      qword ptr [7D92A6FF6AF0]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       edi,ebx
       and       edi,0FFFFFF
       mov       ecx,edi
       mov       edx,ebx
       sar       edx,18
       jne       short M15_L01
       cmp       [rax],edi
       jle       short M15_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       ecx,0FFFFFFFE
       movsxd    rdi,ecx
       mov       rax,[rax+rdi*8+10]
       test      rax,rax
       je        short M15_L03
M15_L00:
       add       rsp,8
       pop       rbx
       pop       rbp
       ret
M15_L01:
       mov       edi,ebx
       sar       edi,18
       cmp       edi,2
       jne       short M15_L02
       movsxd    rcx,ecx
       add       rax,rcx
       jmp       short M15_L00
M15_L02:
       cmp       [rax+4],ecx
       jle       short M15_L03
       mov       rdi,[rax+10]
       movsxd    rax,ecx
       mov       rdi,[rdi+rax*8]
       test      rdi,rdi
       je        short M15_L03
       mov       rax,[rdi]
       test      rax,rax
       je        short M15_L03
       jmp       short M15_L00
M15_L03:
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
       jne       near ptr M16_L10
       test      esi,400000
       jne       near ptr M16_L11
       test      esi,1000000
       je        near ptr M16_L12
       mov       r14d,5
M16_L00:
       cmp       r14d,5
       jne       near ptr M16_L15
       mov       rdi,r15
       mov       rax,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task<System.Int32>>
       cmp       [rdi],rax
       jne       near ptr M16_L16
M16_L01:
       test      rdi,rdi
       je        short M16_L05
       mov       esi,[rdi+34]
       and       esi,11000000
       cmp       esi,1000000
       jne       near ptr M16_L18
       mov       r14,[rdi+38]
M16_L02:
       test      r14,r14
       je        near ptr M16_L19
       test      dword ptr [r14+34],1600000
       je        short M16_L07
       mov       rdi,rbx
       mov       rsi,r14
       xor       edx,edx
       call      qword ptr [7D92A7F87E58]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
M16_L03:
       mov       byte ptr [rbx+3C],2
M16_L04:
       add       rsp,8
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       ret
M16_L05:
       mov       rdi,r15
       mov       rax,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task>
       cmp       [rdi],rax
       jne       near ptr M16_L17
M16_L06:
       cmp       [rdi],edi
       call      qword ptr [7D92A7F87E88]; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].get_Result()
       mov       r14,rax
       jmp       short M16_L02
M16_L07:
       test      dword ptr [r14+34],1600000
       jne       short M16_L09
       cmp       qword ptr [r14+20],0
       jne       short M16_L08
       lea       rdi,[r14+20]
       test      rdi,rdi
       je        near ptr M16_L20
       mov       rsi,rbx
       xor       edx,edx
       call      00007D9325874060
       test      rax,rax
       je        short M16_L04
M16_L08:
       mov       rdi,r14
       mov       rsi,rbx
       xor       edx,edx
       call      qword ptr [7D92A7F87F00]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       short M16_L04
M16_L09:
       mov       rdi,rbx
       mov       rsi,r14
       add       rsp,8
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7D92A7FBE520]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
M16_L10:
       mov       r14d,7
       jmp       near ptr M16_L00
M16_L11:
       mov       r14d,6
       jmp       near ptr M16_L00
M16_L12:
       test      esi,800000
       je        short M16_L13
       mov       r14d,4
       jmp       near ptr M16_L00
M16_L13:
       test      esi,20000
       je        short M16_L14
       mov       r14d,3
       jmp       near ptr M16_L00
M16_L14:
       test      esi,2000000
       setne     r14b
       movzx     r14d,r14b
       mov       edi,2
       test      esi,10000
       cmovne    r14d,edi
       jmp       near ptr M16_L00
M16_L15:
       add       r14d,0FFFFFFFA
       cmp       r14d,1
       ja        near ptr M16_L04
       movzx     edx,byte ptr [rbx+3D]
       mov       rdi,rbx
       mov       rsi,r15
       call      qword ptr [7D92A7F87E58]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       jmp       near ptr M16_L04
M16_L16:
       mov       rsi,r15
       mov       rdi,rax
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M16_L01
M16_L17:
       mov       rsi,r15
       mov       rdi,rax
       call      qword ptr [7D92A7864AF8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M16_L06
M16_L18:
       mov       esi,1
       call      qword ptr [7D92A7F8FA98]
       mov       r14,rax
       jmp       near ptr M16_L02
M16_L19:
       mov       rdi,rbx
       xor       esi,esi
       xor       edx,edx
       call      qword ptr [7D92A7F8C7C8]
       jmp       near ptr M16_L03
M16_L20:
       call      qword ptr [7D92A7F8F0C0]
       int       3
; Total bytes of code 510
```
```assembly
; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rbx
       sub       rsp,48
       vzeroupper
       lea       rbp,[rsp+70]
       mov       [rbp-30],rsi
       mov       ebx,edi
       lea       rdi,[rbp-68]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       r15,rax
       mov       rdi,rsp
       mov       [rbp-50],rdi
       mov       rdi,rbp
       mov       [rbp-40],rdi
       lea       rdi,[rbp-30]
       mov       esi,ebx
       mov       rax,7D92A7477E68
       mov       [rbp-58],rax
       lea       rax,[M17_L00]
       mov       [rbp-48],rax
       lea       rax,[rbp-68]
       mov       [r15+8],rax
       mov       byte ptr [r15+4],0
       mov       rax,7D93256E64A0
       call      rax
M17_L00:
       mov       byte ptr [r15+4],1
       cmp       dword ptr [7D9325ACEC80],0
       je        short M17_L01
       call      qword ptr [7D9325ABB1D8]; CORINFO_HELP_STOP_FOR_GC
M17_L01:
       mov       rax,[rbp-60]
       mov       [r15+8],rax
       add       rsp,48
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 153
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
       call      00007D9325874060
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
       call      qword ptr [7D92A7F87F00]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
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
       jmp       qword ptr [7D92A7FBE520]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
M18_L03:
       call      qword ptr [7D92A7F8F0C0]
       int       3
M18_L04:
       mov       rdi,r15
       mov       rsi,rbx
       mov       r11,7D92A6450510
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
       call      qword ptr [7D92A7F878A0]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7D92A8044060]
       jmp       short M19_L01
M19_L04:
       test      r15b,2
       jne       short M19_L05
       mov       rdi,rbx
       call      qword ptr [7D92A8044030]
M19_L05:
       mov       rdi,rbx
       call      qword ptr [7D92A80447B0]
       jmp       short M19_L02
; Total bytes of code 125
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.ContendedFirstCallBenchmarks.Nito()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rbx
       sub       rsp,70
       lea       rbp,[rsp+90]
       vxorps    xmm8,xmm8,xmm8
       vmovdqu   ymmword ptr [rbp-80],ymm8
       vmovdqu   ymmword ptr [rbp-60],ymm8
       vmovdqa   xmmword ptr [rbp-40],xmm8
       xor       eax,eax
       mov       [rbp-30],rax
       mov       [rbp-40],rdi
       mov       rdi,offset MT_AsyncLazyBenchmarks.ContendedFirstCallBenchmarks+<>c__DisplayClass10_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-48],rax
       mov       rdi,offset MT_Nito.AsyncEx.AsyncLazy<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdi,79E82C801350
       mov       r15,[rdi]
       mov       rsi,r15
       lea       rdi,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset MT_Nito.AsyncEx.AsyncLazy<System.Int32>+<>c__DisplayClass14_0
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rdi,[r14+8]
       mov       rsi,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset MT_System.Func<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rdi,[r15+8]
       mov       rsi,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset Nito.AsyncEx.AsyncLazy`1+<>c__DisplayClass14_0[[System.Int32, System.Private.CoreLib]].<RunOnThreadPool>b__0()
       mov       [r15+18],rdi
       lea       rdi,[rbx+10]
       mov       rsi,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rdi,[rbx+8]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset MT_System.Lazy<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rsi,[rbx+10]
       lea       rdi,[r15+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset MT_System.LazyHelper
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+10],8
       lea       rdi,[r15+8]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rdi,[rbx+18]
       mov       rsi,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-48]
       lea       rdi,[rax+8]
       mov       rsi,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       edi,edi
       mov       [rbp-24],edi
M00_L00:
       mov       rdi,[rbp-40]
       mov       rbx,[rdi+8]
       mov       eax,[rbx+8]
       cmp       eax,[rbp-24]
       jle       near ptr M00_L35
       mov       rax,[rbp-48]
       mov       r15,[rax+10]
       mov       [rbp-50],rbx
       test      r15,r15
       je        near ptr M00_L08
M00_L01:
       mov       rcx,79E82C801370
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L66
M00_L02:
       cmp       [rcx],cl
       mov       rcx,79E82C801380
       mov       rbx,[rcx]
       mov       rdi,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       rdi,[rbp-60]
       lea       rdi,[rdi+8]
       mov       rsi,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbp-60]
       xor       esi,esi
       mov       [rdi+10],rsi
       mov       rdi,[rbp-60]
       lea       rdi,[rdi+18]
       mov       rsi,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       edi,2008
       mov       rax,[rbp-60]
       mov       [rax+34],edi
       mov       rdi,79F86DAA0D68
       mov       rax,79F86E361820
       call      rax
       cmp       dword ptr [rax],4
       jle       near ptr M00_L67
       mov       rdi,[rax+8]
       mov       rax,[rdi+20]
       test      rax,rax
       je        near ptr M00_L67
M00_L03:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M00_L04
       call      qword ptr [79F7EFCAC030]; System.Threading.Thread.InitializeCurrentThread()
M00_L04:
       mov       rbx,[rax+8]
       test      rbx,rbx
       jne       near ptr M00_L09
       mov       rdi,79E82C801390
       mov       rbx,[rdi]
M00_L05:
       test      rbx,rbx
       jne       near ptr M00_L10
       mov       rdi,[rbp-60]
       or        dword ptr [rdi+34],20000000
M00_L06:
       mov       rdi,[rbp-60]
       xor       esi,esi
       call      qword ptr [79F7EFFA68F8]; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
       mov       rdi,offset MT_System.Threading.Tasks.UnwrapPromise<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-58],rax
       mov       rdi,[rbp-60]
       movzx     ebx,word ptr [rdi+34]
       and       ebx,4
       test      ebx,0FFFFFFBB
       je        near ptr M00_L12
M00_L07:
       mov       edi,2D
       call      qword ptr [79F7EF45F0D8]
       int       3
M00_L08:
       mov       rdi,offset MT_System.Func<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rdi,[r15+8]
       mov       rsi,[rbp-48]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset AsyncLazyBenchmarks.ContendedFirstCallBenchmarks+<>c__DisplayClass10_0.<Nito>b__0()
       mov       [r15+18],rdi
       mov       rsi,[rbp-48]
       lea       rdi,[rsi+10]
       mov       rsi,r15
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L09:
       cmp       byte ptr [rbx+18],0
       je        near ptr M00_L05
       xor       ebx,ebx
       jmp       near ptr M00_L05
M00_L10:
       mov       rdi,79E82C801390
       cmp       rbx,[rdi]
       je        near ptr M00_L06
       mov       rdi,[rbp-60]
       mov       rax,[rdi+28]
       test      rax,rax
       jne       short M00_L11
       mov       rdi,offset MT_System.Threading.Tasks.Task+ContingentProperties
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       dword ptr [r15+3C],1
       mov       rdi,[rbp-60]
       lea       rdi,[rdi+28]
       mov       rsi,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,r15
M00_L11:
       lea       rdi,[rax+8]
       mov       rsi,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L06
M00_L12:
       test      bl,4
       je        near ptr M00_L15
       mov       rdi,79F86DAA0D68
       mov       rax,79F86E361820
       call      rax
       cmp       dword ptr [rax],8
       jle       near ptr M00_L68
       mov       rdi,[rax+8]
       mov       rax,[rdi+40]
       test      rax,rax
       je        near ptr M00_L68
M00_L13:
       mov       r15,[rax+10]
       test      r15,r15
       je        short M00_L15
       mov       rdi,[rbp-58]
       mov       rax,[rdi+28]
       test      rax,rax
       jne       short M00_L14
       mov       rdi,offset MT_System.Threading.Tasks.Task+ContingentProperties
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [r14+3C],1
       mov       rdi,[rbp-58]
       lea       rdi,[rdi+28]
       mov       rsi,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,r14
M00_L14:
       lea       rdi,[rax+30]
       mov       rsi,r15
       call      CORINFO_HELP_ASSIGN_REF
M00_L15:
       mov       rdi,[rbp-58]
       xor       eax,eax
       mov       [rdi+8],rax
       mov       rdi,[rbp-58]
       mov       [rdi+10],rax
       mov       rdi,[rbp-58]
       mov       [rdi+18],rax
       test      ebx,0FFFFFFA0
       jne       near ptr M00_L07
       mov       edi,ebx
       or        edi,400
       or        edi,2000000
       mov       rax,[rbp-58]
       mov       [rax+34],edi
       mov       rdi,[rbp-58]
       mov       rdi,[rdi+28]
       test      rdi,rdi
       jne       near ptr M00_L69
M00_L16:
       mov       rdi,[rbp-58]
       mov       byte ptr [rdi+3D],1
       mov       rdi,79E82C8013A0
       mov       rdi,[rdi]
       cmp       byte ptr [rdi+9D],0
       jne       near ptr M00_L70
M00_L17:
       cmp       byte ptr [79F7EE46B06C],0
       jne       near ptr M00_L71
M00_L18:
       mov       rdi,[rbp-60]
       test      dword ptr [rdi+34],1600000
       jne       near ptr M00_L72
       mov       rdi,[rbp-60]
       test      dword ptr [rdi+34],1600000
       jne       near ptr M00_L76
       mov       rdi,[rbp-60]
       cmp       qword ptr [rdi+20],0
       jne       short M00_L20
       mov       rdi,[rbp-60]
       add       rdi,20
       test      rdi,rdi
       je        near ptr M00_L91
       mov       rsi,[rbp-58]
       xor       edx,edx
       call      000079F86D874060
       test      rax,rax
       jne       short M00_L20
M00_L19:
       movsxd    rsi,dword ptr [rbp-24]
       mov       rdi,[rbp-50]
       mov       rdx,[rbp-58]
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       edi,[rbp-24]
       inc       edi
       mov       [rbp-24],edi
       jmp       near ptr M00_L00
M00_L20:
       mov       rsi,[rbp-60]
       mov       rbx,[rsi+20]
       mov       rsi,79E82C800238
       mov       r15,[rsi]
       cmp       rbx,r15
       je        near ptr M00_L73
       mov       r14,rbx
       test      r14,r14
       je        short M00_L21
       mov       rsi,offset MT_System.Threading.Tasks.UnwrapPromise<System.Int32>
       cmp       [r14],rsi
       jne       near ptr M00_L64
       xor       r14d,r14d
M00_L21:
       test      r14,r14
       jne       near ptr M00_L23
       mov       rdi,offset MT_System.Collections.Generic.List<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdi,79E82C800AB0
       mov       rsi,[rdi]
       lea       rdi,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [r14+14]
       mov       rdi,r14
       mov       rsi,rbx
       call      qword ptr [79F7EF4572D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       inc       dword ptr [r14+14]
       mov       rdi,[r14+8]
       mov       esi,[r14+10]
       cmp       [rdi+8],esi
       jbe       near ptr M00_L62
       lea       edx,[rsi+1]
       mov       [r14+10],edx
       mov       esi,esi
       mov       rdx,[rbp-58]
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M00_L22:
       mov       rdi,[rbp-60]
       add       rdi,20
       test      rdi,rdi
       je        near ptr M00_L91
       mov       rsi,r14
       mov       rdx,rbx
       call      000079F86D874060
       mov       r14,rax
       cmp       r14,rbx
       je        near ptr M00_L33
       mov       rsi,r14
       mov       rdi,offset MT_System.Collections.Generic.List<System.Object>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       je        near ptr M00_L73
M00_L23:
       mov       [rbp-68],r14
       xor       edi,edi
       mov       [rbp-28],edi
       mov       rdi,r14
       call      000079F86D6E6020
       test      eax,eax
       je        short M00_L29
M00_L24:
       mov       dword ptr [rbp-28],1
       mov       rdi,[rbp-60]
       cmp       [rdi+20],r15
       je        short M00_L30
       mov       edi,[r14+10]
       mov       rax,[r14+8]
       cmp       edi,[rax+8]
       je        short M00_L26
M00_L25:
       inc       dword ptr [r14+14]
       mov       rdi,[r14+8]
       mov       esi,[r14+10]
       cmp       [rdi+8],esi
       jbe       short M00_L28
       lea       edx,[rsi+1]
       mov       [r14+10],edx
       mov       esi,esi
       mov       rdx,[rbp-58]
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M00_L32
M00_L26:
       mov       rdi,79E82C800290
       mov       rsi,[rdi]
       test      rsi,rsi
       je        short M00_L31
M00_L27:
       mov       rdi,r14
       cmp       [rdi],edi
       call      qword ptr [79F7EFFA7D38]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAll(System.Predicate`1<System.__Canon>)
       jmp       short M00_L25
M00_L28:
       mov       rdi,r14
       mov       rsi,[rbp-58]
       call      qword ptr [79F7EF4572D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L32
M00_L29:
       mov       rdi,r14
       call      qword ptr [79F7EFFA7828]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L24
M00_L30:
       xor       edi,edi
       mov       [rbp-2C],edi
       jmp       near ptr M00_L75
M00_L31:
       mov       rdi,offset MT_System.Predicate<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdi,79E82C800260
       mov       rsi,[rdi]
       lea       rdi,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset System.Threading.Tasks.Task+<>c.<AddTaskContinuationComplex>b__211_0(System.Object)
       mov       [r15+18],rdi
       mov       rdi,79E82C800290
       mov       rsi,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,r15
       jmp       short M00_L27
M00_L32:
       mov       rdi,r14
       call      000079F86D6E6790
       test      eax,eax
       jne       near ptr M00_L74
M00_L33:
       mov       ebx,1
M00_L34:
       test      ebx,ebx
       jne       near ptr M00_L19
       jmp       near ptr M00_L76
M00_L35:
       mov       rsi,rbx
       test      rsi,rsi
       je        near ptr M00_L82
       lea       rbx,[rsi+10]
       mov       r15d,[rsi+8]
       test      r15d,r15d
       je        near ptr M00_L83
       mov       esi,r15d
       mov       rdi,offset MT_System.Threading.Tasks.Task<System.Int32>[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       lea       rdi,[r14+10]
       mov       edx,r15d
       shl       rdx,3
       cmp       rdx,4000
       jbe       short M00_L36
       mov       rsi,rbx
       call      qword ptr [79F7EFFAF678]
       jmp       short M00_L37
M00_L36:
       mov       rsi,rbx
       call      000079F86D870D90
       cmp       dword ptr [79F86DACEC80],0
       jne       near ptr M00_L84
M00_L37:
       mov       ebx,[r14+8]
       test      ebx,ebx
       jle       short M00_L39
       lea       rdi,[r14+10]
       mov       esi,ebx
M00_L38:
       cmp       qword ptr [rdi],0
       je        near ptr M00_L85
       add       rdi,8
       dec       esi
       jne       short M00_L38
M00_L39:
       mov       rdi,offset MT_System.Threading.Tasks.Task+WhenAllPromise<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-70],rax
       mov       rdi,[rbp-70]
       mov       dword ptr [rdi+34],2000400
       lea       rdi,[rdi+40]
       mov       rsi,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,[rbp-70]
       mov       [rdi+48],ebx
       mov       rax,79E82C8013A0
       mov       rax,[rax]
       cmp       byte ptr [rax+9D],0
       jne       near ptr M00_L86
M00_L40:
       cmp       byte ptr [79F7EE46B06C],0
       jne       near ptr M00_L87
M00_L41:
       mov       [rbp-78],r14
       xor       esi,esi
       mov       [rbp-30],esi
       jmp       short M00_L47
M00_L42:
       mov       rdi,r13
       call      000079F86D6E6790
       test      eax,eax
       jne       near ptr M00_L89
M00_L43:
       mov       ebx,1
M00_L44:
       test      ebx,ebx
       jne       short M00_L46
M00_L45:
       mov       rdi,[rbp-70]
       mov       rsi,[rbp-80]
       call      qword ptr [79F7EFFEC7F8]; System.Threading.Tasks.Task+WhenAllPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
M00_L46:
       mov       edi,[rbp-30]
       inc       edi
       mov       [rbp-30],edi
       mov       rdi,[rbp-70]
M00_L47:
       mov       r14,[rbp-78]
       mov       ebx,[r14+8]
       cmp       ebx,[rbp-30]
       jle       near ptr M00_L60
       cmp       [rbp-30],ebx
       jae       near ptr M00_L92
       mov       esi,[rbp-30]
       mov       rsi,[r14+rsi*8+10]
       mov       [rbp-80],rsi
       mov       rsi,[rbp-80]
       test      dword ptr [rsi+34],1600000
       jne       short M00_L45
       mov       rsi,[rbp-80]
       test      dword ptr [rsi+34],1600000
       jne       short M00_L45
       mov       rsi,[rbp-80]
       cmp       qword ptr [rsi+20],0
       jne       short M00_L48
       mov       rsi,[rbp-80]
       add       rsi,20
       test      rsi,rsi
       je        near ptr M00_L91
       mov       rdi,rsi
       mov       rsi,[rbp-70]
       xor       edx,edx
       call      000079F86D874060
       test      rax,rax
       je        short M00_L46
M00_L48:
       mov       rdi,[rbp-70]
       mov       rsi,[rbp-80]
       mov       rbx,[rsi+20]
       mov       rsi,79E82C800238
       mov       r15,[rsi]
       cmp       rbx,r15
       je        near ptr M00_L88
       mov       r13,rbx
       test      r13,r13
       je        short M00_L49
       mov       rsi,offset MT_System.Threading.Tasks.UnwrapPromise<System.Int32>
       cmp       [r13],rsi
       jne       near ptr M00_L65
       xor       r13d,r13d
M00_L49:
       test      r13,r13
       jne       near ptr M00_L51
       mov       rdi,offset MT_System.Collections.Generic.List<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdi,79E82C800AB0
       mov       rsi,[rdi]
       lea       rdi,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [r13+14]
       mov       rdi,r13
       mov       rsi,rbx
       call      qword ptr [79F7EF4572D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       inc       dword ptr [r13+14]
       mov       rdi,[r13+8]
       mov       esi,[r13+10]
       cmp       [rdi+8],esi
       jbe       near ptr M00_L63
       lea       edx,[rsi+1]
       mov       [r13+10],edx
       movsxd    rsi,esi
       mov       rdx,[rbp-70]
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M00_L50:
       mov       rdi,[rbp-80]
       add       rdi,20
       test      rdi,rdi
       je        near ptr M00_L91
       mov       rsi,r13
       mov       rdx,rbx
       call      000079F86D874060
       mov       r13,rax
       cmp       r13,rbx
       je        near ptr M00_L43
       mov       rsi,r13
       mov       rdi,offset MT_System.Collections.Generic.List<System.Object>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r13,rax
       test      r13,r13
       mov       rdi,[rbp-70]
       je        near ptr M00_L88
M00_L51:
       mov       [rbp-88],r13
       xor       eax,eax
       mov       [rbp-34],eax
       mov       rdi,r13
       call      000079F86D6E6020
       test      eax,eax
       je        short M00_L57
M00_L52:
       mov       dword ptr [rbp-34],1
       mov       rdi,[rbp-80]
       cmp       [rdi+20],r15
       je        short M00_L58
       mov       edi,[r13+10]
       mov       rax,[r13+8]
       cmp       edi,[rax+8]
       je        short M00_L54
M00_L53:
       inc       dword ptr [r13+14]
       mov       rdi,[r13+8]
       mov       esi,[r13+10]
       cmp       [rdi+8],esi
       jbe       short M00_L56
       lea       edx,[rsi+1]
       mov       [r13+10],edx
       movsxd    rsi,esi
       mov       rdx,[rbp-70]
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M00_L42
M00_L54:
       mov       rdi,79E82C800290
       mov       rsi,[rdi]
       test      rsi,rsi
       je        short M00_L59
M00_L55:
       mov       rdi,r13
       cmp       [rdi],edi
       call      qword ptr [79F7EFFA7D38]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAll(System.Predicate`1<System.__Canon>)
       jmp       short M00_L53
M00_L56:
       mov       rdi,r13
       mov       rsi,[rbp-70]
       call      qword ptr [79F7EF4572D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L42
M00_L57:
       mov       rdi,r13
       call      qword ptr [79F7EFFA7828]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M00_L52
M00_L58:
       xor       edi,edi
       mov       [rbp-38],edi
       jmp       near ptr M00_L90
M00_L59:
       mov       rdi,offset MT_System.Predicate<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdi,79E82C800260
       mov       rsi,[rdi]
       lea       rdi,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdi,offset System.Threading.Tasks.Task+<>c.<AddTaskContinuationComplex>b__211_0(System.Object)
       mov       [rbx+18],rdi
       mov       rdi,79E82C800290
       mov       rsi,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,rbx
       jmp       near ptr M00_L55
M00_L60:
       mov       rax,rdi
M00_L61:
       add       rsp,70
       pop       rbx
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L62:
       mov       rdi,r14
       mov       rsi,[rbp-58]
       call      qword ptr [79F7EF4572D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L22
M00_L63:
       mov       rdi,r13
       mov       rsi,[rbp-70]
       call      qword ptr [79F7EF4572D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L50
M00_L64:
       mov       rsi,rbx
       mov       rdi,offset MT_System.Collections.Generic.List<System.Object>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       jmp       near ptr M00_L21
M00_L65:
       mov       rsi,rbx
       mov       rdi,offset MT_System.Collections.Generic.List<System.Object>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r13,rax
       mov       rdi,[rbp-70]
       jmp       near ptr M00_L49
M00_L66:
       mov       rdi,offset MT_System.Threading.Tasks.TaskFactory<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,79E82C801370
       xor       edx,edx
       call      000079F86D874060
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M00_L02
       mov       rcx,79E82C801370
       mov       rcx,[rcx]
       jmp       near ptr M00_L02
M00_L67:
       mov       edi,4
       call      qword ptr [79F7EFFAECA0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L03
M00_L68:
       mov       edi,8
       call      qword ptr [79F7EFFAECA0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L13
M00_L69:
       mov       rdi,[rdi+30]
       test      rdi,rdi
       je        near ptr M00_L16
       test      bl,4
       je        near ptr M00_L16
       test      byte ptr [rdi+34],8
       jne       near ptr M00_L16
       call      qword ptr [79F7EFFAE958]
       jmp       near ptr M00_L16
M00_L70:
       mov       rdi,[rbp-58]
       call      qword ptr [79F7EFFA7240]
       mov       esi,eax
       mov       rdi,79E82C8013A0
       mov       rdi,[rdi]
       mov       rdx,79F7DE40A850
       xor       ecx,ecx
       call      qword ptr [79F7EFFA7258]
       jmp       near ptr M00_L17
M00_L71:
       mov       rdi,[rbp-58]
       call      qword ptr [79F7EFFA7270]
       jmp       near ptr M00_L18
M00_L72:
       mov       rdi,[rbp-58]
       mov       rsi,[rbp-60]
       call      qword ptr [79F7EFFA72A0]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].ProcessCompletedOuterTask(System.Threading.Tasks.Task)
       jmp       near ptr M00_L19
M00_L73:
       xor       ebx,ebx
       jmp       near ptr M00_L34
M00_L74:
       mov       edi,eax
       mov       rsi,r14
       call      qword ptr [79F7EFFA78A0]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       near ptr M00_L33
M00_L75:
       call      M00_L93
       nop
       mov       ebx,[rbp-2C]
       jmp       near ptr M00_L34
M00_L76:
       call      000079F86D8F8300
       test      eax,eax
       je        near ptr M00_L81
       mov       rdi,[rbp-58]
       movzx     ebx,byte ptr [rdi+3C]
       test      ebx,ebx
       je        short M00_L77
       cmp       ebx,1
       jne       near ptr M00_L19
       mov       rdi,[rbp-58]
       mov       rsi,[rbp-60]
       xor       edx,edx
       call      qword ptr [79F7EFFA7BB8]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       mov       rdi,[rbp-58]
       mov       byte ptr [rdi+3C],2
       jmp       near ptr M00_L19
M00_L77:
       mov       rdi,[rbp-58]
       mov       byte ptr [rdi+3C],1
       mov       rdi,[rbp-60]
       call      qword ptr [79F7EFFA7C48]; System.Threading.Tasks.Task.get_Status()
       cmp       eax,5
       je        short M00_L78
       add       eax,0FFFFFFFA
       cmp       eax,1
       ja        near ptr M00_L19
       mov       rdx,[rbp-58]
       movzx     edx,byte ptr [rdx+3D]
       mov       rdi,[rbp-58]
       mov       rsi,[rbp-60]
       call      qword ptr [79F7EFFA7BB8]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       jmp       near ptr M00_L19
M00_L78:
       mov       rdi,[rbp-60]
       mov       edi,[rdi+34]
       and       edi,11000000
       cmp       edi,1000000
       jne       short M00_L79
       mov       rdi,[rbp-60]
       mov       rsi,[rdi+38]
       jmp       short M00_L80
M00_L79:
       mov       rdi,[rbp-60]
       mov       esi,1
       call      qword ptr [79F7EFFAF288]
       mov       rsi,rax
M00_L80:
       mov       rdi,[rbp-58]
       call      qword ptr [79F7EFFA7C78]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].ProcessInnerTask(System.Threading.Tasks.Task)
       jmp       near ptr M00_L19
M00_L81:
       mov       rdi,[rbp-58]
       mov       rsi,[rbp-60]
       call      qword ptr [79F7EFFA7AB0]
       jmp       near ptr M00_L19
M00_L82:
       mov       edi,33
       call      qword ptr [79F7EF45FAE0]
       int       3
M00_L83:
       mov       rdi,offset MT_System.Threading.Tasks.Task<System.Int32[]>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdi,rbx
       xor       esi,esi
       mov       rdx,79F7DE40A1A0
       xor       ecx,ecx
       xor       r8d,r8d
       call      qword ptr [79F7EFFA7738]
       mov       rax,rbx
       jmp       near ptr M00_L61
M00_L84:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L37
M00_L85:
       mov       edi,1D
       mov       esi,33
       call      qword ptr [79F7EFFA7768]
       int       3
M00_L86:
       call      qword ptr [79F7EFFA7240]
       mov       esi,eax
       mov       rdi,79E82C8013A0
       mov       rdi,[rdi]
       mov       rdx,79F7DE40AEE0
       xor       ecx,ecx
       call      qword ptr [79F7EFFA7258]
       mov       rdi,[rbp-70]
       jmp       near ptr M00_L40
M00_L87:
       call      qword ptr [79F7EFFA7270]
       mov       rdi,[rbp-70]
       jmp       near ptr M00_L41
M00_L88:
       xor       ebx,ebx
       jmp       near ptr M00_L44
M00_L89:
       mov       edi,eax
       mov       rsi,r13
       call      qword ptr [79F7EFFA78A0]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       near ptr M00_L43
M00_L90:
       call      M00_L95
       nop
       mov       ebx,[rbp-38]
       mov       r14,[rbp-78]
       jmp       near ptr M00_L44
M00_L91:
       call      qword ptr [79F7EFFAE940]
       int       3
M00_L92:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L93:
       push      rax
       cmp       dword ptr [rbp-28],0
       je        short M00_L94
       mov       rdi,[rbp-68]
       call      000079F86D6E6790
       test      eax,eax
       je        short M00_L94
       mov       edi,eax
       mov       rsi,[rbp-68]
       call      qword ptr [79F7EFFA78A0]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M00_L94:
       nop
       add       rsp,8
       ret
M00_L95:
       push      rax
       cmp       dword ptr [rbp-34],0
       je        short M00_L97
       cmp       qword ptr [rbp-88],0
       jne       short M00_L96
       xor       edi,edi
       call      qword ptr [79F7EFFAECD0]
       int       3
M00_L96:
       mov       rdi,[rbp-88]
       call      000079F86D6E6790
       test      eax,eax
       je        short M00_L97
       mov       edi,eax
       mov       rsi,[rbp-88]
       call      qword ptr [79F7EFFA78A0]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M00_L97:
       nop
       add       rsp,8
       ret
; Total bytes of code 3467
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
       jmp       qword ptr [79F7EFFA78D0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
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
       call      qword ptr [79F7EFFA6700]; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].get_Factory()
       cmp       [rax],al
       mov       rdi,79E82C801380
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
       mov       rdi,79F86DAA0D68
       mov       rax,79F86E361820
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
       call      qword ptr [79F7EFCAC030]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       rbx,[rax+8]
       test      rbx,rbx
       je        short M02_L02
       xor       edi,edi
       cmp       byte ptr [rbx+18],0
       cmovne    rbx,rdi
       jmp       short M02_L03
M02_L02:
       mov       rdi,79E82C801390
       mov       rbx,[rdi]
M02_L03:
       test      rbx,rbx
       je        short M02_L05
       mov       rdi,79E82C801390
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
       call      qword ptr [79F7EFFA68F8]; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
       mov       rdi,offset MT_System.Threading.Tasks.UnwrapPromise<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       movzx     r14d,word ptr [r15+34]
       and       r14d,4
       test      r14d,0FFFFFFBB
       jne       near ptr M02_L15
       test      r14b,4
       je        short M02_L09
       mov       rdi,79F86DAA0D68
       mov       rax,79F86E361820
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
       mov       rdi,79E82C8013A0
       mov       rdi,[rdi]
       cmp       byte ptr [rdi+9D],0
       jne       near ptr M02_L20
M02_L11:
       cmp       byte ptr [79F7EE46B06C],0
       jne       near ptr M02_L21
M02_L12:
       test      dword ptr [r15+34],1600000
       jne       near ptr M02_L22
       test      dword ptr [r15+34],1600000
       jne       near ptr M02_L24
       cmp       qword ptr [r15+20],0
       jne       short M02_L14
       lea       rdi,[r15+20]
       test      rdi,rdi
       je        near ptr M02_L23
       mov       rsi,rbx
       xor       edx,edx
       call      000079F86D874060
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
       call      qword ptr [79F7EFFA7CF0]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       short M02_L13
       jmp       near ptr M02_L24
M02_L15:
       mov       edi,2D
       call      qword ptr [79F7EF45F0D8]
       int       3
M02_L16:
       mov       edi,4
       call      qword ptr [79F7EFFAECA0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M02_L00
M02_L17:
       mov       edi,2E
       call      qword ptr [79F7EF45FAE0]
       int       3
M02_L18:
       mov       edi,8
       call      qword ptr [79F7EFFAECA0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M02_L07
M02_L19:
       mov       rdi,[rdi+30]
       test      rdi,rdi
       je        near ptr M02_L10
       test      r14b,4
       je        near ptr M02_L10
       test      byte ptr [rdi+34],8
       jne       near ptr M02_L10
       call      qword ptr [79F7EFFAE958]
       jmp       near ptr M02_L10
M02_L20:
       mov       rdi,rbx
       call      qword ptr [79F7EFFA7240]
       mov       esi,eax
       mov       rdi,79E82C8013A0
       mov       rdi,[rdi]
       mov       rdx,79F7DE40A850
       xor       ecx,ecx
       call      qword ptr [79F7EFFA7258]
       jmp       near ptr M02_L11
M02_L21:
       mov       rdi,rbx
       call      qword ptr [79F7EFFA7270]
       jmp       near ptr M02_L12
M02_L22:
       mov       rdi,rbx
       mov       rsi,r15
       call      qword ptr [79F7EFFA72A0]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].ProcessCompletedOuterTask(System.Threading.Tasks.Task)
       jmp       near ptr M02_L13
M02_L23:
       call      qword ptr [79F7EFFAE940]
       int       3
M02_L24:
       mov       rdi,rbx
       mov       rsi,r15
       call      qword ptr [79F7EFFDF6C8]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
       jmp       near ptr M02_L13
; Total bytes of code 886
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
       call      qword ptr [79F7EEFFEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdi,[rbp-90]
       call      qword ptr [rax]
       lea       rdi,[rbp-88]
       call      qword ptr [79F7EEFFEF08]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-30]
       call      qword ptr [79F7EF000B98]
       lea       rdi,[rax+10]
       mov       rsi,[rbp-30]
       call      qword ptr [79F7EEFFEEB8]; CORINFO_HELP_ASSIGN_REF
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
       cmp       byte ptr [79F7EE46B06C],0
       jne       near ptr M04_L20
M04_L01:
       mov       rax,79E82C8013A0
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
       mov       rsi,79E82C8013A8
       mov       rbx,[rsi]
       cmp       byte ptr [rbx+38],0
       jne       near ptr M04_L13
M04_L04:
       test      r15b,1
       jne       short M04_L06
       mov       rdi,79F86DAA0D68
       mov       rax,79F86E361820
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
       call      qword ptr [79F7EFFA7888]; System.Threading.ThreadPoolWorkQueue+WorkStealingQueue.LocalPush(System.Object)
       jmp       short M04_L10
M04_L09:
       test      eax,eax
       jge       short M04_L07
       mov       rdi,rsi
       mov       rsi,[rbp-20]
       call      qword ptr [79F7EFFAEFE8]
M04_L10:
       add       rbx,78
       mov       edi,1
       xchg      edi,[rbx]
       test      edi,edi
       jne       near ptr M04_L18
       mov       rdi,79E82C8013D0
       mov       rbx,[rdi]
       lea       rdi,[rbx+160]
       lock inc  dword ptr [rdi]
       mov       rdi,rbx
       call      qword ptr [79F7EFFA6CD0]; System.Threading.PortableThreadPool+WorkerThread.MaybeAddWorkingWorker(System.Threading.PortableThreadPool)
       cmp       dword ptr [rbx+164],6
       je        near ptr M04_L18
       jmp       near ptr M04_L16
M04_L11:
       mov       rsi,r15
       call      qword ptr [79F7EFFAEEE0]
       mov       rdi,[rbp-20]
       jmp       near ptr M04_L03
M04_L12:
       mov       rdi,offset MT_System.Threading.Tasks.ThreadPoolTaskScheduler
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdi,79E82C801458
       mov       rbx,[rdi]
       mov       rdi,offset MT_System.Threading.Thread
       call      CORINFO_HELP_NEWFAST
       mov       r15,rax
       mov       rdi,r15
       mov       rsi,rbx
       call      qword ptr [79F7EFFAFB88]
       mov       rdi,r15
       mov       esi,1
       call      qword ptr [79F7EFFA6EB0]; System.Threading.Thread.set_IsBackground(Boolean)
       mov       rdi,r15
       mov       rsi,79F7DE409F88
       call      qword ptr [79F7EFFA6FB8]; System.Threading.Thread.set_Name(System.String)
       mov       rdi,r15
       mov       rsi,[rbp-20]
       xor       edx,edx
       call      qword ptr [79F7EFFAFBA0]
       jmp       short M04_L18
M04_L13:
       mov       rsi,79E82C8013C0
       mov       rsi,[rsi]
       cmp       byte ptr [rsi+9D],0
       je        near ptr M04_L04
       mov       rsi,79E82C8013C0
       mov       rdi,[rsi]
       mov       rsi,[rbp-20]
       call      qword ptr [79F7EFFAEFD0]
       jmp       near ptr M04_L04
M04_L14:
       mov       edi,5
       call      qword ptr [79F7EFFAECA0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M04_L05
M04_L15:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M04_L16:
       mov       rdi,rbx
       call      qword ptr [79F7EFFA6F40]; System.Threading.PortableThreadPool+GateThread.EnsureRunningSlow(System.Threading.PortableThreadPool)
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
       call      qword ptr [79F7EFFAFB70]
       test      eax,eax
       mov       rdi,[rbp-20]
       jne       near ptr M04_L00
       jmp       short M04_L18
M04_L20:
       call      qword ptr [79F7EFFA7270]
       mov       rdi,[rbp-20]
       jmp       near ptr M04_L01
M04_L21:
       test      word ptr [rdi+34],200
       jne       near ptr M04_L02
       call      qword ptr [79F7EFFA7240]
       mov       r15d,eax
       mov       rdi,[rbp-20]
       mov       rdi,[rdi+8]
       call      qword ptr [79F7EFFAEE50]
       mov       rsi,rax
       mov       rdi,79F7DE409F00
       call      qword ptr [79F7EF45EFA0]; System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       esi,r15d
       mov       rdi,rbx
       xor       ecx,ecx
       call      qword ptr [79F7EFFA7258]
       mov       rdi,[rbp-20]
       jmp       near ptr M04_L02
       push      rax
       mov       rbx,rdi
       mov       rdi,offset MT_System.Threading.Tasks.TaskSchedulerException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdi,r15
       mov       rsi,rbx
       call      qword ptr [79F7EFFAEE68]
       mov       rdi,[rbp-20]
       mov       rsi,r15
       call      qword ptr [79F7EFFAEE80]
       mov       rdi,[rbp-20]
       xor       esi,esi
       call      qword ptr [79F7EFFAEE98]
       mov       rdi,[rbp-20]
       call      qword ptr [79F7EFFAEEB0]
       test      eax,200
       jne       short M04_L22
       mov       rdi,[rbp-20]
       mov       rdi,[rdi+28]
       mov       rdi,[rdi+18]
       xor       esi,esi
       cmp       [rdi],edi
       call      qword ptr [79F7EFFAEEC8]
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
       call      000079F86D6E6020
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
       call      qword ptr [79F7EFCAC420]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rbx,rax
       jmp       short M05_L04
M05_L02:
       xor       edi,edi
       call      qword ptr [79F7EFFAECD0]
       int       3
M05_L03:
       mov       rdi,[rbp-18]
       call      qword ptr [79F7EFFA7828]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M05_L00
M05_L04:
       mov       rdi,[rbp-18]
       call      000079F86D6E6790
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
       call      qword ptr [79F7EFFA78A0]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       short M05_L05
       push      rax
       cmp       dword ptr [rbp-0C],0
       je        short M05_L08
       cmp       qword ptr [rbp-18],0
       jne       short M05_L07
       xor       edi,edi
       call      qword ptr [79F7EFFAECD0]
       int       3
M05_L07:
       mov       rdi,[rbp-18]
       call      000079F86D6E6790
       test      eax,eax
       je        short M05_L08
       mov       edi,eax
       mov       rsi,[rbp-18]
       call      qword ptr [79F7EFFA78A0]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
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
       jmp       qword ptr [79F7EFCA7A68]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
M06_L00:
       mov       rdi,rax
       mov       rsi,rdx
       pop       rbp
       jmp       near ptr 000079F86D9FB900
M06_L01:
       xor       ecx,ecx
       mov       [rax],rcx
       pop       rbp
       ret
M06_L02:
       call      qword ptr [79F7EFFAE808]
       int       3
; Total bytes of code 85
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rbx
       sub       rsp,18
       lea       rbp,[rsp+40]
       mov       [rbp-30],rdi
       mov       rbx,rdi
       mov       r15,rsi
       mov       r14d,[rbx+10]
       mov       r13d,r14d
       lea       edi,[r13+1]
       mov       r12,[rbx+8]
       cmp       dword ptr [r12+8],0
       jne       near ptr M07_L04
       mov       esi,4
M07_L00:
       mov       eax,7FFFFFC7
       cmp       esi,7FFFFFC7
       cmova     esi,eax
       cmp       esi,edi
       cmovl     esi,edi
       cmp       esi,r14d
       jl        near ptr M07_L08
       cmp       [r12+8],esi
       je        short M07_L03
       mov       [rbp-34],esi
       test      esi,esi
       jle       near ptr M07_L18
       mov       rdi,[rbx]
       mov       rax,[rdi+30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       test      rax,rax
       je        short M07_L05
       mov       rdi,rax
M07_L01:
       mov       esi,[rbp-34]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rbp-40],rax
       test      r14d,r14d
       jg        short M07_L06
M07_L02:
       lea       rdi,[rbx+8]
       mov       rsi,rax
       call      CORINFO_HELP_ASSIGN_REF
M07_L03:
       lea       edi,[r13+1]
       mov       [rbx+10],edi
       mov       rdi,[rbx+8]
       movsxd    rsi,r13d
       mov       rdx,r15
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       nop
       add       rsp,18
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M07_L04:
       mov       esi,[r12+8]
       add       esi,esi
       jmp       near ptr M07_L00
M07_L05:
       mov       rsi,79F7EFFFA5E8
       call      qword ptr [79F7EF45F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       short M07_L01
M07_L06:
       test      r12,r12
       je        near ptr M07_L15
       mov       rdi,[r12]
       cmp       rdi,[rax]
       jne       near ptr M07_L13
       cmp       dword ptr [rdi+4],18
       jne       near ptr M07_L12
       cmp       r14d,[r12+8]
       ja        short M07_L11
       cmp       r14d,[rax+8]
       ja        short M07_L10
       mov       edx,r14d
       movzx     esi,word ptr [rdi]
       imul      rdx,rsi
       lea       rsi,[r12+10]
       lea       rcx,[rax+10]
       test      dword ptr [rdi],1000000
       je        short M07_L14
       mov       rax,[rbp-40]
       cmp       rdx,4000
       jbe       short M07_L07
       mov       rdi,rcx
       call      qword ptr [79F7EFFAF678]
       mov       rax,[rbp-40]
       jmp       near ptr M07_L02
M07_L07:
       mov       rdi,rcx
       call      000079F86D870D90
       cmp       dword ptr [79F86DACEC80],0
       jne       short M07_L09
       mov       rax,[rbp-40]
       jmp       near ptr M07_L02
M07_L08:
       mov       edi,7
       mov       esi,0F
       call      qword ptr [79F7EFF2C210]
       int       3
M07_L09:
       call      CORINFO_HELP_POLL_GC
       mov       rax,[rbp-40]
       jmp       near ptr M07_L02
M07_L10:
       jmp       short M07_L16
M07_L11:
       jmp       short M07_L16
M07_L12:
       jmp       short M07_L16
M07_L13:
       jmp       short M07_L16
M07_L14:
       mov       rdi,rcx
       call      qword ptr [79F7EF455800]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,[rbp-40]
       jmp       near ptr M07_L02
M07_L15:
       xor       edi,edi
       mov       [rbp-38],edi
       jmp       short M07_L17
M07_L16:
       mov       rdi,r12
       xor       esi,esi
       call      qword ptr [79F7EFFAFE40]; System.Array.GetLowerBound(Int32)
       mov       [rbp-38],eax
       mov       rax,[rbp-40]
M07_L17:
       mov       rdi,rax
       xor       esi,esi
       call      qword ptr [79F7EFFAFE40]; System.Array.GetLowerBound(Int32)
       mov       ecx,eax
       mov       rdi,r12
       mov       esi,[rbp-38]
       mov       rdx,[rbp-40]
       mov       r8d,r14d
       xor       r9d,r9d
       call      qword ptr [79F7EFFAFA80]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       mov       rax,[rbp-40]
       jmp       near ptr M07_L02
M07_L18:
       mov       rdi,[rbx]
       mov       rsi,[rdi+30]
       mov       rsi,[rsi]
       mov       rsi,[rsi+38]
       test      rsi,rsi
       je        short M07_L19
       jmp       short M07_L20
M07_L19:
       mov       rsi,79F7EFFFA5D8
       call      qword ptr [79F7EF45F270]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rsi,rax
M07_L20:
       mov       rdi,rsi
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rsi,[rax]
       lea       rdi,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M07_L03
; Total bytes of code 549
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       push      rbp
       mov       rbp,rsp
       test      rsi,rsi
       je        short M08_L02
       mov       rax,[rsi]
       cmp       rax,rdi
       je        short M08_L02
       mov       rax,[rax+10]
       cmp       rax,rdi
       je        short M08_L02
M08_L00:
       test      rax,rax
       je        short M08_L01
       mov       rax,[rax+10]
       cmp       rax,rdi
       je        short M08_L02
       test      rax,rax
       je        short M08_L01
       mov       rax,[rax+10]
       cmp       rax,rdi
       je        short M08_L02
       test      rax,rax
       je        short M08_L01
       mov       rax,[rax+10]
       cmp       rax,rdi
       je        short M08_L02
       test      rax,rax
       jne       short M08_L03
M08_L01:
       xor       esi,esi
M08_L02:
       mov       rax,rsi
       pop       rbp
       ret
M08_L03:
       mov       rax,[rax+10]
       cmp       rax,rdi
       je        short M08_L02
       jmp       short M08_L00
; Total bytes of code 91
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
       je        near ptr M09_L04
       xor       r14d,r14d
       cmp       dword ptr [rbx+10],0
       jle       short M09_L01
       mov       rsi,offset System.Threading.Tasks.Task+<>c.<AddTaskContinuationComplex>b__211_0(System.Object)
       cmp       [r15+18],rsi
       jne       short M09_L02
M09_L00:
       mov       rsi,[rbx+8]
       cmp       r14d,[rsi+8]
       jae       near ptr M09_L11
       mov       edi,r14d
       mov       rsi,[rsi+rdi*8+10]
       test      rsi,rsi
       je        short M09_L01
       inc       r14d
       cmp       r14d,[rbx+10]
       jl        short M09_L00
M09_L01:
       cmp       r14d,[rbx+10]
       jl        short M09_L06
       xor       eax,eax
       pop       rbx
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M09_L02:
       mov       rsi,[rbx+8]
       cmp       r14d,[rsi+8]
       jae       near ptr M09_L11
       mov       edi,r14d
       mov       rsi,[rsi+rdi*8+10]
       mov       rdi,offset System.Threading.Tasks.Task+<>c.<AddTaskContinuationComplex>b__211_0(System.Object)
       cmp       [r15+18],rdi
       jne       short M09_L05
       test      rsi,rsi
       je        short M09_L01
M09_L03:
       inc       r14d
       cmp       r14d,[rbx+10]
       jge       short M09_L01
       jmp       short M09_L02
M09_L04:
       mov       edi,1A
       call      qword ptr [79F7EF45FAE0]
       int       3
M09_L05:
       mov       rdi,[r15+8]
       call      qword ptr [r15+18]
       test      eax,eax
       je        short M09_L03
       jmp       short M09_L01
M09_L06:
       lea       r13d,[r14+1]
       jmp       short M09_L10
M09_L07:
       inc       r13d
M09_L08:
       cmp       r13d,[rbx+10]
       jge       short M09_L09
       mov       rsi,[rbx+8]
       cmp       r13d,[rsi+8]
       jae       short M09_L11
       mov       edi,r13d
       mov       rsi,[rsi+rdi*8+10]
       mov       rdi,[r15+8]
       call      qword ptr [r15+18]
       test      eax,eax
       jne       short M09_L07
M09_L09:
       cmp       r13d,[rbx+10]
       jge       short M09_L10
       mov       esi,r14d
       lea       r14d,[rsi+1]
       mov       edi,r13d
       lea       r13d,[rdi+1]
       mov       rdx,[rbx+8]
       mov       rax,[rbx+8]
       cmp       edi,[rax+8]
       jae       short M09_L11
       mov       rax,[rax+rdi*8+10]
       mov       rdi,rdx
       mov       rdx,rax
       movsxd    rsi,esi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M09_L10:
       cmp       r13d,[rbx+10]
       jl        short M09_L08
       mov       edx,[rbx+10]
       sub       edx,r14d
       mov       rdi,[rbx+8]
       mov       esi,r14d
       call      qword ptr [79F7EFFAFA68]
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
M09_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 336
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
       mov       rax,79F7EF497D28
       mov       [rbp-58],rax
       lea       rax,[M10_L00]
       mov       [rbp-48],rax
       lea       rax,[rbp-68]
       mov       [rbx+8],rax
       mov       byte ptr [rbx+4],0
       mov       rax,79F86D6E5E10
       call      rax
M10_L00:
       mov       byte ptr [rbx+4],1
       cmp       dword ptr [79F86DACEC80],0
       je        short M10_L01
       call      qword ptr [79F86DABB1D8]; CORINFO_HELP_STOP_FOR_GC
M10_L01:
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
       mov       rdi,79E82C8013A0
       mov       r15,[rdi]
       cmp       byte ptr [r15+9D],0
       jne       near ptr M12_L11
M12_L00:
       lea       rsi,[rbx+48]
       mov       edi,0FFFFFFFF
       lock xadd [rsi],edi
       dec       edi
       je        short M12_L02
M12_L01:
       add       rsp,28
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M12_L02:
       mov       rsi,[rbx+40]
       mov       esi,[rsi+8]
       mov       rdi,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       xor       r13d,r13d
       xor       r12d,r12d
       xor       eax,eax
       jmp       near ptr M12_L08
M12_L03:
       cmp       eax,[rdi+8]
       jae       near ptr M12_L23
       mov       [rbp-2C],eax
       mov       ecx,eax
       mov       [rbp-38],rcx
       mov       r8,[rdi+rcx*8+10]
       mov       [rbp-40],r8
       test      dword ptr [r8+34],200000
       jne       near ptr M12_L12
       mov       edi,[r8+34]
       and       edi,600000
       cmp       edi,400000
       je        near ptr M12_L15
       test      dword ptr [r8+34],1600000
       je        near ptr M12_L16
M12_L04:
       mov       edi,[r8+34]
       and       edi,1600000
       cmp       edi,1000000
       jne       near ptr M12_L17
M12_L05:
       mov       edi,[r8+38]
       mov       eax,[rbp-2C]
       cmp       eax,[r14+8]
       jae       near ptr M12_L23
       mov       rcx,[rbp-38]
       mov       [r14+rcx*4+10],edi
M12_L06:
       test      dword ptr [r8+34],10000000
       jne       near ptr M12_L18
       mov       rdi,[rbx+40]
       mov       eax,[rbp-2C]
       cmp       eax,[rdi+8]
       jae       near ptr M12_L23
       xor       esi,esi
       mov       rcx,[rbp-38]
       mov       [rdi+rcx*8+10],rsi
M12_L07:
       mov       eax,[rbp-2C]
       inc       eax
M12_L08:
       mov       rdi,[rbx+40]
       cmp       [rdi+8],eax
       jg        near ptr M12_L03
       test      r13,r13
       jne       near ptr M12_L19
       test      r12,r12
       jne       near ptr M12_L20
       cmp       byte ptr [r15+9D],0
       jne       near ptr M12_L21
M12_L09:
       cmp       byte ptr [79F7EE46B06C],0
       jne       near ptr M12_L22
M12_L10:
       mov       rdi,rbx
       mov       rsi,r14
       call      qword ptr [79F7EFFAC1E0]; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].TrySetResult(System.__Canon)
       jmp       near ptr M12_L01
M12_L11:
       mov       rdi,rbx
       call      qword ptr [79F7EFFA7240]
       mov       esi,eax
       mov       rdi,r15
       mov       edx,1
       call      qword ptr [79F7EFFA7F90]
       jmp       near ptr M12_L00
M12_L12:
       test      r13,r13
       jne       short M12_L13
       mov       rdi,offset MT_System.Collections.Generic.List<System.Runtime.ExceptionServices.ExceptionDispatchInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdi,r13
       call      qword ptr [79F7EFCAEE50]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       r8,[rbp-40]
M12_L13:
       mov       rdi,[r8+28]
       mov       rdx,[rdi+18]
       mov       [rbp-48],rdx
       mov       rsi,[rdx+10]
       mov       [rbp-50],rsi
       cmp       byte ptr [rdx+20],0
       jne       short M12_L14
       mov       rdi,rdx
       call      qword ptr [79F7EFCA6868]; System.GC.SuppressFinalize(System.Object)
       mov       rdi,[rbp-48]
       mov       byte ptr [rdi+20],1
M12_L14:
       mov       rdi,r13
       mov       rsi,[rbp-50]
       cmp       [rdi],edi
       call      qword ptr [79F7EFFAC168]
       mov       r8,[rbp-40]
       jmp       near ptr M12_L06
M12_L15:
       test      r12,r12
       jne       near ptr M12_L06
       mov       r12,r8
       mov       r8,[rbp-40]
       jmp       near ptr M12_L06
M12_L16:
       mov       rdi,r8
       mov       esi,0FFFFFFFF
       xor       edx,edx
       call      qword ptr [79F7EFFA7900]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
       mov       r8,[rbp-40]
       jmp       near ptr M12_L04
M12_L17:
       mov       rdi,r8
       mov       esi,1
       call      qword ptr [79F7EFFAFC78]
       mov       r8,[rbp-40]
       jmp       near ptr M12_L05
M12_L18:
       mov       rdi,rbx
       mov       esi,1
       call      qword ptr [79F7EFFAC1C8]
       jmp       near ptr M12_L07
M12_L19:
       mov       rdi,rbx
       mov       rsi,r13
       call      qword ptr [79F7EFFAC078]
       jmp       near ptr M12_L01
M12_L20:
       mov       rdi,r12
       call      qword ptr [79F7EFFA7F78]
       mov       r13,rax
       mov       rdi,r12
       call      qword ptr [79F7EFFA7FA8]
       mov       rdx,rax
       mov       rsi,r13
       mov       rdi,rbx
       call      qword ptr [79F7EFFA7FD8]
       jmp       near ptr M12_L01
M12_L21:
       mov       rdi,rbx
       call      qword ptr [79F7EFFA7240]
       mov       esi,eax
       mov       rdi,r15
       mov       edx,1
       call      qword ptr [79F7EFFAC090]
       jmp       near ptr M12_L09
M12_L22:
       mov       rdi,rbx
       call      qword ptr [79F7EFFAC0A8]
       jmp       near ptr M12_L10
M12_L23:
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
       call      qword ptr [79F7EF016AF0]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       jne       short M14_L04
       test      dword ptr [r14+34],1600000
       jne       near ptr M14_L19
       cmp       qword ptr [r14+20],0
       jne       short M14_L03
       lea       rdi,[r14+20]
       test      rdi,rdi
       je        near ptr M14_L18
       mov       rsi,rbx
       xor       edx,edx
       call      000079F86D874060
       test      rax,rax
       je        short M14_L06
M14_L03:
       mov       rdi,r14
       mov       rsi,rbx
       xor       edx,edx
       call      qword ptr [79F7EFFA7CF0]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       short M14_L06
       jmp       near ptr M14_L19
M14_L04:
       mov       rdi,rbx
       mov       rsi,r14
       xor       edx,edx
       call      qword ptr [79F7EFFA7BB8]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
M14_L05:
       mov       byte ptr [rbx+3C],2
M14_L06:
       add       rsp,8
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       ret
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
       ja        short M14_L06
       movzx     edx,byte ptr [rbx+3D]
       mov       rdi,rbx
       mov       rsi,r15
       call      qword ptr [79F7EFFA7BB8]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       jmp       near ptr M14_L06
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
       call      qword ptr [79F7EF884AF8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rdi,rax
M14_L15:
       cmp       [rdi],edi
       call      qword ptr [79F7EFFA7C60]; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].get_Result()
       mov       r14,rax
       jmp       near ptr M14_L02
M14_L16:
       mov       esi,1
       call      qword ptr [79F7EFFAF288]
       mov       r14,rax
       jmp       near ptr M14_L02
M14_L17:
       mov       rdi,rbx
       xor       esi,esi
       xor       edx,edx
       call      qword ptr [79F7EFFA7FD8]
       jmp       near ptr M14_L05
M14_L18:
       call      qword ptr [79F7EFFAE940]
       int       3
M14_L19:
       mov       rdi,rbx
       mov       rsi,r14
       add       rsp,8
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [79F7EFFDF6C8]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
; Total bytes of code 513
```
```assembly
; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rbx
       sub       rsp,48
       vzeroupper
       lea       rbp,[rsp+70]
       mov       [rbp-30],rsi
       mov       ebx,edi
       lea       rdi,[rbp-68]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       r15,rax
       mov       rdi,rsp
       mov       [rbp-50],rdi
       mov       rdi,rbp
       mov       [rbp-40],rdi
       lea       rdi,[rbp-30]
       mov       esi,ebx
       mov       rax,79F7EF497E68
       mov       [rbp-58],rax
       lea       rax,[M15_L00]
       mov       [rbp-48],rax
       lea       rax,[rbp-68]
       mov       [r15+8],rax
       mov       byte ptr [r15+4],0
       mov       rax,79F86D6E64A0
       call      rax
M15_L00:
       mov       byte ptr [r15+4],1
       cmp       dword ptr [79F86DACEC80],0
       je        short M15_L01
       call      qword ptr [79F86DABB1D8]; CORINFO_HELP_STOP_FOR_GC
M15_L01:
       mov       rax,[rbp-60]
       mov       [r15+8],rax
       add       rsp,48
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 153
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
       mov       rdi,79E82C8013A0
       mov       r13,[rdi]
       cmp       byte ptr [r13+9D],0
       jne       near ptr M16_L15
M16_L01:
       xor       eax,eax
       mov       edi,[r15+34]
       test      edi,200000
       jne       near ptr M16_L12
       test      edi,400000
       jne       near ptr M16_L16
       test      edi,1000000
       je        near ptr M16_L17
       mov       ecx,5
M16_L02:
       add       ecx,0FFFFFFFB
       jne       near ptr M16_L20
       cmp       byte ptr [r13+9D],0
       jne       near ptr M16_L22
M16_L03:
       cmp       byte ptr [79F7EE46B06C],0
       jne       near ptr M16_L23
M16_L04:
       mov       rdi,r15
       mov       rsi,offset MT_System.Threading.Tasks.UnwrapPromise<System.Int32>
       cmp       [rdi],rsi
       jne       near ptr M16_L13
M16_L05:
       test      rdi,rdi
       je        near ptr M16_L14
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
       mov       rsi,79E82C800238
       mov       rsi,[rsi]
       call      000079F86D874040
       test      rax,rax
       je        short M16_L09
       mov       rdi,rbx
       mov       rsi,rax
       call      qword ptr [79F7EFFA7960]; System.Threading.Tasks.Task.RunContinuations(System.Object)
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
       mov       ecx,7
       jmp       near ptr M16_L02
M16_L13:
       mov       rsi,r15
       mov       rdi,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M16_L05
M16_L14:
       xor       r15d,r15d
       jmp       near ptr M16_L06
M16_L15:
       mov       rdi,rbx
       call      qword ptr [79F7EFFA7240]
       mov       esi,eax
       mov       rdi,r13
       mov       edx,1
       call      qword ptr [79F7EFFA7F90]
       jmp       near ptr M16_L01
M16_L16:
       mov       ecx,6
       jmp       near ptr M16_L02
M16_L17:
       test      edi,800000
       je        short M16_L18
       mov       ecx,4
       jmp       near ptr M16_L02
M16_L18:
       test      edi,20000
       je        short M16_L19
       mov       ecx,3
       jmp       near ptr M16_L02
M16_L19:
       test      edi,2000000
       setne     cl
       movzx     ecx,cl
       mov       edx,2
       test      edi,10000
       cmovne    ecx,edx
       jmp       near ptr M16_L02
M16_L20:
       cmp       ecx,2
       ja        near ptr M16_L11
       mov       edi,ecx
       lea       rax,[79F7EF4DB568]
       mov       eax,[rax+rdi*4]
       lea       rcx,[M16_L00]
       add       rax,rcx
       jmp       rax
       mov       rdi,r15
       call      qword ptr [79F7EFFA7F78]
       mov       r14,rax
       mov       rdi,r15
       call      qword ptr [79F7EFFA7FA8]
       mov       rdx,rax
       mov       rsi,r14
       mov       rdi,rbx
       call      qword ptr [79F7EFFA7FD8]
       jmp       near ptr M16_L11
       mov       rdi,r15
       call      qword ptr [79F7EFFAC000]
       mov       r15,rax
       test      r14b,r14b
       je        short M16_L21
       cmp       dword ptr [r15+10],0
       jle       short M16_L21
       mov       rdi,r15
       xor       esi,esi
       call      qword ptr [79F7EF5469B8]
       mov       r13,rax
       test      r13,r13
       je        short M16_L21
       mov       rsi,[r13+8]
       mov       rdi,offset MT_System.OperationCanceledException
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M16_L21
       mov       rsi,[rax+70]
       mov       rdi,rbx
       mov       rdx,r13
       call      qword ptr [79F7EFFA7FD8]
       jmp       near ptr M16_L11
M16_L21:
       mov       rdi,rbx
       mov       rsi,r15
       call      qword ptr [79F7EFFAC078]
       jmp       near ptr M16_L11
M16_L22:
       mov       rdi,rbx
       call      qword ptr [79F7EFFA7240]
       mov       esi,eax
       mov       rdi,r13
       mov       edx,1
       call      qword ptr [79F7EFFAC090]
       jmp       near ptr M16_L03
M16_L23:
       mov       rdi,rbx
       call      qword ptr [79F7EFFAC0A8]
       jmp       near ptr M16_L04
M16_L24:
       mov       esi,1
       call      qword ptr [79F7EFFAC198]; System.Threading.Tasks.Task`1[[System.Int32, System.Private.CoreLib]].GetResultCore(Boolean)
       mov       r15d,eax
       jmp       near ptr M16_L06
M16_L25:
       mov       rdi,rbx
       mov       esi,4000000
       mov       edx,5600000
       call      qword ptr [79F7EFFAEE20]
       test      eax,eax
       je        near ptr M16_L10
       jmp       near ptr M16_L07
M16_L26:
       mov       rdi,rbx
       call      qword ptr [79F7EFFAF330]
       mov       rdi,r14
       call      qword ptr [79F7EFFAF348]
       jmp       near ptr M16_L08
M16_L27:
       call      qword ptr [79F7EFFAE940]
       int       3
; Total bytes of code 789
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
; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].ProcessInnerTask(System.Threading.Tasks.Task)
       push      rbp
       push      r15
       push      rbx
       lea       rbp,[rsp+10]
       mov       r15,rdi
       mov       rbx,rsi
       test      rbx,rbx
       je        short M18_L04
       test      dword ptr [rbx+34],1600000
       jne       short M18_L01
       test      dword ptr [rbx+34],1600000
       jne       short M18_L06
       cmp       qword ptr [rbx+20],0
       jne       short M18_L00
       lea       rdi,[rbx+20]
       test      rdi,rdi
       je        short M18_L05
       mov       rsi,r15
       xor       edx,edx
       call      000079F86D874060
       test      rax,rax
       je        short M18_L03
M18_L00:
       mov       rdi,rbx
       mov       rsi,r15
       xor       edx,edx
       call      qword ptr [79F7EFFA7CF0]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       short M18_L03
       jmp       short M18_L06
M18_L01:
       mov       rdi,r15
       mov       rsi,rbx
       xor       edx,edx
       call      qword ptr [79F7EFFA7BB8]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
M18_L02:
       mov       byte ptr [r15+3C],2
M18_L03:
       pop       rbx
       pop       r15
       pop       rbp
       ret
M18_L04:
       mov       rdi,r15
       xor       esi,esi
       xor       edx,edx
       call      qword ptr [79F7EFFA7FD8]
       jmp       short M18_L02
M18_L05:
       call      qword ptr [79F7EFFAE940]
       int       3
M18_L06:
       mov       rdi,r15
       mov       rsi,rbx
       cmp       [rdi],edi
       pop       rbx
       pop       r15
       pop       rbp
       jmp       qword ptr [79F7EFFDF6C8]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
; Total bytes of code 153
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
       call      qword ptr [79F7EFFA7900]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [79F7EFFAFA20]
       jmp       short M19_L01
M19_L04:
       test      r15b,2
       jne       short M19_L05
       mov       rdi,rbx
       call      qword ptr [79F7EFFAF858]
M19_L05:
       mov       rdi,rbx
       call      qword ptr [79F7EFFAFEE8]
       jmp       short M19_L02
; Total bytes of code 125
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: DefaultJob)

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
       mov       rdi,7C6940801350
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
       mov       rdi,7C6940801380
       mov       rax,[rdi]
       test      rax,rax
       je        near ptr M00_L33
M00_L02:
       cmp       [rax],al
       mov       rdi,7C6940801390
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
       mov       rdi,7C79812A0D68
       mov       rax,7C7981C39820
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
       call      qword ptr [7C790349C030]; System.Threading.Thread.InitializeCurrentThread()
M00_L04:
       mov       rax,[rax+8]
       test      rax,rax
       jne       near ptr M00_L09
       mov       rax,7C69408013A0
       mov       rax,[rax]
M00_L05:
       test      rax,rax
       jne       near ptr M00_L10
       or        dword ptr [r12+34],20000000
M00_L06:
       mov       rdi,r12
       xor       esi,esi
       call      qword ptr [7C7903796910]; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
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
       call      qword ptr [7C7902C4F0D8]
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
       cmp       byte ptr [rax+18],0
       je        near ptr M00_L05
       jmp       near ptr M00_L35
M00_L10:
       mov       rdi,7C69408013A0
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
       mov       rdi,7C79812A0D68
       mov       rdx,7C7981C39820
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
       mov       rdi,7C69408013B0
       mov       rdi,[rdi]
       cmp       byte ptr [rdi+9D],0
       jne       near ptr M00_L38
M00_L17:
       cmp       byte ptr [7C7901C5B06C],0
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
       call      00007C7981074060
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
       call      00007C79810F8300
       test      eax,eax
       je        near ptr M00_L44
       mov       rax,[rbp-38]
       movzx     edi,byte ptr [rax+3C]
       test      edi,edi
       jne       near ptr M00_L42
M00_L21:
       mov       rdi,rax
       mov       rsi,r12
       call      qword ptr [7C79037972D0]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].ProcessCompletedOuterTask(System.Threading.Tasks.Task)
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
       call      qword ptr [7C7903865500]
       jmp       short M00_L24
M00_L23:
       mov       rsi,rbx
       call      00007C7981070D90
       cmp       dword ptr [7C79812CEC80],0
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
       mov       rdi,7C69408013B0
       mov       rdi,[rdi]
       cmp       byte ptr [rdi+9D],0
       jne       near ptr M00_L49
M00_L27:
       cmp       byte ptr [7C7901C5B06C],0
       jne       near ptr M00_L50
M00_L28:
       test      ebx,ebx
       jle       short M00_L32
       add       r14,10
       jmp       short M00_L31
M00_L29:
       mov       rdi,r15
       mov       rsi,r13
       call      qword ptr [7C79037FD858]; System.Threading.Tasks.Task+WhenAllPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
M00_L30:
       add       r14,8
       dec       ebx
       je        short M00_L32
M00_L31:
       mov       r13,[r14]
       test      dword ptr [r13+34],1600000
       jne       short M00_L29
       test      dword ptr [r13+34],1600000
       jne       short M00_L29
       cmp       qword ptr [r13+20],0
       jne       near ptr M00_L51
       lea       rdi,[r13+20]
       test      rdi,rdi
       je        near ptr M00_L52
       mov       rsi,r15
       xor       edx,edx
       call      00007C7981074060
       test      rax,rax
       je        short M00_L30
       jmp       near ptr M00_L51
M00_L32:
       mov       rax,r15
       add       rsp,48
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L33:
       mov       rdi,offset MT_System.Threading.Tasks.TaskFactory<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,7C6940801380
       xor       edx,edx
       call      00007C7981074060
       test      rax,rax
       jne       near ptr M00_L02
       mov       rax,7C6940801380
       mov       rax,[rax]
       jmp       near ptr M00_L02
M00_L34:
       mov       edi,4
       call      qword ptr [7C7903864BA0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L03
M00_L35:
       xor       eax,eax
       jmp       near ptr M00_L05
M00_L36:
       mov       edi,8
       call      qword ptr [7C7903864BA0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L13
M00_L37:
       mov       rdi,[rdi+30]
       test      rdi,rdi
       je        near ptr M00_L16
       test      cl,4
       je        near ptr M00_L16
       test      byte ptr [rdi+34],8
       jne       near ptr M00_L16
       call      qword ptr [7C79038647C8]
       jmp       near ptr M00_L16
M00_L38:
       mov       rdi,rax
       call      qword ptr [7C7903797270]
       mov       esi,eax
       mov       rdi,7C69408013B0
       mov       rdi,[rdi]
       mov       rdx,7C78F1C0A850
       xor       ecx,ecx
       call      qword ptr [7C7903797288]
       mov       rax,[rbp-38]
       jmp       near ptr M00_L17
M00_L39:
       mov       rdi,rax
       call      qword ptr [7C79037972A0]
       mov       rax,[rbp-38]
       jmp       near ptr M00_L18
M00_L40:
       mov       rax,[rbp-38]
M00_L41:
       mov       rdi,r12
       mov       rsi,rax
       xor       edx,edx
       call      qword ptr [7C790379D800]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M00_L19
       jmp       near ptr M00_L20
M00_L42:
       cmp       edi,1
       jne       short M00_L43
       mov       rdi,rax
       mov       rsi,r12
       xor       edx,edx
       call      qword ptr [7C790379D650]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       mov       r12,[rbp-38]
       mov       byte ptr [r12+3C],2
       jmp       near ptr M00_L19
M00_L43:
       jmp       near ptr M00_L19
M00_L44:
       mov       rdi,[rbp-38]
       mov       rsi,r12
       call      qword ptr [7C790379D620]
       jmp       near ptr M00_L19
M00_L45:
       mov       edi,33
       call      qword ptr [7C7902C4FAE0]
       int       3
M00_L46:
       mov       rdi,offset MT_System.Threading.Tasks.Task<System.Int32[]>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdi,r15
       xor       esi,esi
       mov       rdx,7C78F1C0A1A0
       xor       ecx,ecx
       xor       r8d,r8d
       call      qword ptr [7C7903797798]
       jmp       near ptr M00_L32
M00_L47:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L24
M00_L48:
       mov       edi,1D
       mov       esi,33
       call      qword ptr [7C79037977C8]
       int       3
M00_L49:
       mov       rdi,r15
       call      qword ptr [7C7903797270]
       mov       esi,eax
       mov       rdi,7C69408013B0
       mov       rdi,[rdi]
       mov       rdx,7C78F1C0AEE0
       xor       ecx,ecx
       call      qword ptr [7C7903797288]
       jmp       near ptr M00_L27
M00_L50:
       mov       rdi,r15
       call      qword ptr [7C79037972A0]
       jmp       near ptr M00_L28
M00_L51:
       mov       rdi,r13
       mov       rsi,r15
       xor       edx,edx
       call      qword ptr [7C790379D800]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M00_L30
       jmp       near ptr M00_L29
M00_L52:
       call      qword ptr [7C7903864888]
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
       jmp       qword ptr [7C7903797948]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
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
       call      qword ptr [7C79027EEF00]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       mov       rdi,[rbp-90]
       call      qword ptr [rax]
       lea       rdi,[rbp-88]
       call      qword ptr [7C79027EEF08]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-30]
       call      qword ptr [7C79027F0B98]
       lea       rdi,[rax+10]
       mov       rsi,[rbp-30]
       call      qword ptr [7C79027EEEB8]; CORINFO_HELP_ASSIGN_REF
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
       cmp       byte ptr [7C7901C5B06C],0
       jne       near ptr M03_L20
M03_L01:
       mov       rax,7C69408013B0
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
       mov       rsi,7C69408013B8
       mov       rbx,[rsi]
       cmp       byte ptr [rbx+38],0
       jne       near ptr M03_L12
M03_L04:
       test      r15b,1
       jne       short M03_L06
       mov       rdi,7C79812A0D68
       mov       rax,7C7981C39820
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
       call      qword ptr [7C7903864E28]
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
       mov       rdi,7C69408013E0
       mov       rbx,[rdi]
       lea       rdi,[rbx+160]
       lock inc  dword ptr [rdi]
       mov       rdi,rbx
       call      qword ptr [7C7903796CE8]; System.Threading.PortableThreadPool+WorkerThread.MaybeAddWorkingWorker(System.Threading.PortableThreadPool)
       cmp       dword ptr [rbx+164],6
       je        near ptr M03_L18
       jmp       near ptr M03_L16
M03_L10:
       mov       rsi,r15
       call      qword ptr [7C7903864CF0]
       mov       rdi,[rbp-20]
       jmp       near ptr M03_L03
M03_L11:
       mov       rdi,offset MT_System.Threading.Tasks.ThreadPoolTaskScheduler
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdi,7C6940801498
       mov       rbx,[rdi]
       mov       rdi,offset MT_System.Threading.Thread
       call      CORINFO_HELP_NEWFAST
       mov       r15,rax
       mov       rdi,r15
       mov       rsi,rbx
       call      qword ptr [7C7903865860]
       mov       rdi,r15
       mov       esi,1
       call      qword ptr [7C7903796EC8]; System.Threading.Thread.set_IsBackground(Boolean)
       mov       rdi,r15
       mov       rsi,7C78F1C09F88
       call      qword ptr [7C7903796FD0]; System.Threading.Thread.set_Name(System.String)
       mov       rdi,r15
       mov       rsi,[rbp-20]
       xor       edx,edx
       call      qword ptr [7C7903865878]
       jmp       near ptr M03_L18
M03_L12:
       mov       rsi,7C69408013D0
       mov       rsi,[rsi]
       cmp       byte ptr [rsi+9D],0
       je        near ptr M03_L04
       mov       rsi,7C69408013D0
       mov       rdi,[rsi]
       mov       rsi,[rbp-20]
       call      qword ptr [7C7903864DF8]
       jmp       near ptr M03_L04
M03_L13:
       mov       edi,5
       call      qword ptr [7C7903864BA0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M03_L05
M03_L14:
       mov       rdi,[rdi+18]
       mov       rsi,[rbp-20]
       cmp       [rdi],edi
       call      qword ptr [7C7903864E10]
       jmp       near ptr M03_L09
M03_L15:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M03_L16:
       mov       rdi,rbx
       call      qword ptr [7C7903796F58]; System.Threading.PortableThreadPool+GateThread.EnsureRunningSlow(System.Threading.PortableThreadPool)
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
       call      qword ptr [7C7903865848]
       test      eax,eax
       mov       rdi,[rbp-20]
       jne       near ptr M03_L00
       jmp       short M03_L18
M03_L20:
       call      qword ptr [7C79037972A0]
       mov       rdi,[rbp-20]
       jmp       near ptr M03_L01
M03_L21:
       test      word ptr [rdi+34],200
       jne       near ptr M03_L02
       call      qword ptr [7C7903797270]
       mov       r15d,eax
       mov       rdi,[rbp-20]
       mov       rdi,[rdi+8]
       call      qword ptr [7C7903864C60]
       mov       rsi,rax
       mov       rdi,7C78F1C09F00
       call      qword ptr [7C7902C4EFA0]; System.String.Concat(System.String, System.String)
       mov       rdx,rax
       mov       esi,r15d
       mov       rdi,rbx
       xor       ecx,ecx
       call      qword ptr [7C7903797288]
       mov       rdi,[rbp-20]
       jmp       near ptr M03_L02
       push      rax
       mov       rbx,rdi
       mov       rdi,offset MT_System.Threading.Tasks.TaskSchedulerException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdi,r15
       mov       rsi,rbx
       call      qword ptr [7C7903864C78]
       mov       rdi,[rbp-20]
       mov       rsi,r15
       call      qword ptr [7C7903864C90]
       mov       rdi,[rbp-20]
       xor       esi,esi
       call      qword ptr [7C7903864CA8]
       mov       rdi,[rbp-20]
       call      qword ptr [7C7903864CC0]
       test      eax,200
       jne       short M03_L22
       mov       rdi,[rbp-20]
       mov       rdi,[rdi+28]
       mov       rdi,[rdi+18]
       xor       esi,esi
       cmp       [rdi],edi
       call      qword ptr [7C7903864CD8]
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
       jmp       qword ptr [7C7903797828]; Microsoft.VisualStudio.Threading.AsyncLazy`1[[System.Int32, System.Private.CoreLib]].GetValueAsync(System.Threading.CancellationToken)
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
       jmp       qword ptr [7C7903497A68]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
M05_L01:
       call      qword ptr [7C79038647B0]
       int       3
M05_L02:
       mov       rdi,rax
       mov       rsi,rdx
       pop       rbp
       jmp       near ptr 00007C79811FB900
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
       jne       near ptr M06_L06
       test      esi,400000
       jne       near ptr M06_L07
       test      esi,1000000
       je        near ptr M06_L08
       mov       r14d,5
M06_L00:
       cmp       r14d,5
       jne       near ptr M06_L11
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
       mov       r14,[rdi+38]
M06_L02:
       test      r14,r14
       je        near ptr M06_L16
       test      dword ptr [r14+34],1600000
       je        short M06_L05
       mov       rdi,rbx
       mov       rsi,r14
       xor       edx,edx
       call      qword ptr [7C790379D650]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
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
       jne       near ptr M06_L19
       cmp       qword ptr [r14+20],0
       jne       near ptr M06_L18
       lea       rdi,[r14+20]
       test      rdi,rdi
       je        near ptr M06_L17
       mov       rsi,rbx
       xor       edx,edx
       call      00007C7981074060
       test      rax,rax
       je        short M06_L04
       jmp       near ptr M06_L18
M06_L06:
       mov       r14d,7
       jmp       near ptr M06_L00
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
       add       r14d,0FFFFFFFA
       cmp       r14d,1
       ja        near ptr M06_L04
       movzx     edx,byte ptr [rbx+3D]
       mov       rdi,rbx
       mov       rsi,r15
       call      qword ptr [7C790379D650]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
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
       call      qword ptr [7C7903074AF8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rdi,rax
M06_L14:
       cmp       [rdi],edi
       call      qword ptr [7C790379D710]; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].get_Result()
       mov       r14,rax
       jmp       near ptr M06_L02
M06_L15:
       mov       esi,1
       call      qword ptr [7C7903865038]
       mov       r14,rax
       jmp       near ptr M06_L02
M06_L16:
       mov       rdi,rbx
       xor       esi,esi
       xor       edx,edx
       call      qword ptr [7C790379DBC0]
       jmp       near ptr M06_L03
M06_L17:
       call      qword ptr [7C7903864888]
       int       3
M06_L18:
       mov       rdi,r14
       mov       rsi,rbx
       xor       edx,edx
       call      qword ptr [7C790379D800]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M06_L04
M06_L19:
       mov       rdi,rbx
       mov       rsi,r14
       add       rsp,8
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       jmp       qword ptr [7C79037F06E8]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
; Total bytes of code 525
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
       mov       rdi,7C69408013B0
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
       jmp       near ptr M07_L08
M07_L03:
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
M07_L08:
       mov       rdi,[rbx+40]
       cmp       [rdi+8],eax
       jg        near ptr M07_L03
       test      r13,r13
       jne       near ptr M07_L19
       test      r12,r12
       jne       near ptr M07_L20
       cmp       byte ptr [r15+9D],0
       jne       near ptr M07_L21
M07_L09:
       cmp       byte ptr [7C7901C5B06C],0
       jne       near ptr M07_L22
M07_L10:
       mov       rdi,rbx
       mov       rsi,r14
       call      qword ptr [7C790379DD58]; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].TrySetResult(System.__Canon)
       jmp       near ptr M07_L01
M07_L11:
       mov       rdi,rbx
       call      qword ptr [7C7903797270]
       mov       esi,eax
       mov       rdi,r15
       mov       edx,1
       call      qword ptr [7C790379DB78]
       jmp       near ptr M07_L00
M07_L12:
       test      r13,r13
       jne       short M07_L13
       mov       rdi,offset MT_System.Collections.Generic.List<System.Runtime.ExceptionServices.ExceptionDispatchInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rdi,r13
       call      qword ptr [7C790349EE50]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
       call      qword ptr [7C7903496868]; System.GC.SuppressFinalize(System.Object)
       mov       rdi,[rbp-48]
       mov       byte ptr [rdi+20],1
M07_L14:
       mov       rdi,r13
       mov       rsi,[rbp-50]
       cmp       [rdi],edi
       call      qword ptr [7C790379DCE0]
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
       call      qword ptr [7C7903797960]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
       mov       r8,[rbp-40]
       jmp       near ptr M07_L04
M07_L17:
       mov       rdi,r8
       mov       esi,1
       call      qword ptr [7C7903865A28]
       mov       r8,[rbp-40]
       jmp       near ptr M07_L05
M07_L18:
       mov       rdi,rbx
       mov       esi,1
       call      qword ptr [7C790379DD40]
       jmp       near ptr M07_L07
M07_L19:
       mov       rdi,rbx
       mov       rsi,r13
       call      qword ptr [7C790379CAB0]; System.Threading.Tasks.Task.TrySetException(System.Object)
       jmp       near ptr M07_L01
M07_L20:
       mov       rdi,r12
       call      qword ptr [7C790379DB90]
       mov       r13,rax
       mov       rdi,r12
       call      qword ptr [7C790379DBA8]
       mov       rdx,rax
       mov       rsi,r13
       mov       rdi,rbx
       call      qword ptr [7C790379DBC0]
       jmp       near ptr M07_L01
M07_L21:
       mov       rdi,rbx
       call      qword ptr [7C7903797270]
       mov       esi,eax
       mov       rdi,r15
       mov       edx,1
       call      qword ptr [7C790379DC50]
       jmp       near ptr M07_L09
M07_L22:
       mov       rdi,rbx
       call      qword ptr [7C790379DC68]
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
       call      qword ptr [7C7902806AF0]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       mov       rsi,7C6940800238
       cmp       r13,[rsi]
       je        near ptr M09_L02
       mov       r12,r13
       test      r12,r12
       je        short M09_L00
       mov       rsi,offset MT_System.Threading.Tasks.UnwrapPromise<System.Int32>
       cmp       [r12],rsi
       jne       near ptr M09_L03
       xor       r12d,r12d
M09_L00:
       test      r12,r12
       jne       near ptr M09_L05
       mov       rdi,offset MT_System.Collections.Generic.List<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rdi,7C6940800AB0
       mov       rsi,[rdi]
       lea       rdi,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      r14b,r14b
       jne       near ptr M09_L17
       inc       dword ptr [r12+14]
       mov       rdi,r12
       mov       rsi,r13
       call      qword ptr [7C7902C472D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       inc       dword ptr [r12+14]
       mov       rdi,[r12+8]
       mov       esi,[r12+10]
       cmp       [rdi+8],esi
       jbe       short M09_L04
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
       call      00007C7981074060
       mov       r12,rax
       cmp       r12,r13
       je        near ptr M09_L16
       mov       rsi,r12
       mov       rdi,offset MT_System.Collections.Generic.List<System.Object>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r12,rax
       test      r12,r12
       jne       short M09_L05
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
       mov       rsi,r13
       mov       rdi,offset MT_System.Collections.Generic.List<System.Object>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r12,rax
       jmp       near ptr M09_L00
M09_L04:
       mov       rdi,r12
       mov       rsi,r15
       call      qword ptr [7C7902C472D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M09_L01
M09_L05:
       mov       [rbp-38],r12
       xor       edi,edi
       mov       [rbp-2C],edi
       mov       rdi,r12
       call      00007C7980EE6020
       test      eax,eax
       je        short M09_L09
M09_L06:
       mov       dword ptr [rbp-2C],1
       mov       rdi,[rbx+20]
       mov       rax,7C6940800238
       cmp       rdi,[rax]
       je        near ptr M09_L13
       mov       edi,[r12+10]
       mov       rax,[r12+8]
       cmp       edi,[rax+8]
       je        short M09_L10
M09_L07:
       test      r14b,r14b
       jne       near ptr M09_L12
       inc       dword ptr [r12+14]
       mov       rdi,[r12+8]
       mov       esi,[r12+10]
       cmp       [rdi+8],esi
       jbe       short M09_L08
       lea       edx,[rsi+1]
       mov       [r12+10],edx
       mov       esi,esi
       mov       rdx,r15
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M09_L15
M09_L08:
       mov       rdi,r12
       mov       rsi,r15
       call      qword ptr [7C7902C472D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M09_L15
M09_L09:
       mov       rdi,r12
       call      qword ptr [7C7903797F18]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M09_L06
M09_L10:
       mov       rdi,7C6940800290
       mov       rsi,[rdi]
       test      rsi,rsi
       jne       short M09_L11
       mov       rdi,offset MT_System.Predicate<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rsi,7C6940800260
       mov       rsi,[rsi]
       mov       rdi,rbx
       mov       rdx,offset System.Threading.Tasks.Task+<>c.<AddTaskContinuationComplex>b__211_0(System.Object)
       call      qword ptr [7C7902C46E08]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdi,7C6940800290
       mov       rsi,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,rbx
M09_L11:
       mov       rdi,r12
       cmp       [rdi],edi
       call      qword ptr [7C790379D890]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAll(System.Predicate`1<System.__Canon>)
       jmp       near ptr M09_L07
M09_L12:
       mov       rdi,r12
       mov       rdx,r15
       xor       esi,esi
       call      qword ptr [7C7902D36A30]
       jmp       short M09_L15
M09_L13:
       mov       rdi,r12
       call      00007C7980EE6790
       test      eax,eax
       jne       near ptr M09_L20
M09_L14:
       xor       eax,eax
       add       rsp,18
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M09_L15:
       call      M09_L21
       nop
M09_L16:
       mov       eax,1
       add       rsp,18
       pop       rbx
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M09_L17:
       inc       dword ptr [r12+14]
       mov       rdi,r12
       mov       rsi,r15
       call      qword ptr [7C7902C472D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      qword ptr [7C7902C472D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M09_L01
M09_L19:
       call      qword ptr [7C7903864888]
       int       3
M09_L20:
       mov       edi,eax
       mov       rsi,r12
       call      qword ptr [7C790379D458]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       near ptr M09_L14
M09_L21:
       push      rax
       cmp       dword ptr [rbp-2C],0
       je        short M09_L22
       mov       rdi,[rbp-38]
       call      00007C7980EE6790
       test      eax,eax
       je        short M09_L22
       mov       edi,eax
       mov       rsi,[rbp-38]
       call      qword ptr [7C790379D458]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M09_L22:
       nop
       add       rsp,8
       ret
; Total bytes of code 779
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
       mov       rdi,7C69408013B0
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
       cmp       byte ptr [7C7901C5B06C],0
       jne       near ptr M10_L22
M10_L04:
       mov       rdi,r15
       mov       rsi,offset MT_System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Int32>+AsyncStateMachineBox<Microsoft.VisualStudio.Threading.AsyncLazy<System.Int32>+<>c__DisplayClass20_0+<<GetValueAsync>b__0>d>
       cmp       [rdi],rsi
       jne       near ptr M10_L23
M10_L05:
       test      rdi,rdi
       je        near ptr M10_L12
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
       mov       rsi,7C6940800238
       mov       rsi,[rsi]
       call      00007C7981074040
       test      rax,rax
       je        short M10_L09
       mov       rdi,rbx
       mov       rsi,rax
       call      qword ptr [7C790379D578]; System.Threading.Tasks.Task.RunContinuations(System.Object)
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
       xor       r15d,r15d
       jmp       near ptr M10_L06
M10_L13:
       mov       rdi,rbx
       call      qword ptr [7C7903797270]
       mov       esi,eax
       mov       rdi,r13
       mov       edx,1
       call      qword ptr [7C790379DB78]
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
       lea       rax,[7C7902CCF0D8]
       mov       eax,[rax+rdi*4]
       lea       rcx,[M10_L00]
       add       rax,rcx
       jmp       rax
       mov       rdi,r15
       call      qword ptr [7C790379DB90]
       mov       r14,rax
       mov       rdi,r15
       call      qword ptr [7C790379DBA8]
       mov       rdx,rax
       mov       rsi,r14
       mov       rdi,rbx
       call      qword ptr [7C790379DBC0]
       jmp       near ptr M10_L11
       mov       rdi,r15
       call      qword ptr [7C790379DBD8]
       mov       r15,rax
       test      r14b,r14b
       je        short M10_L20
       cmp       dword ptr [r15+10],0
       jle       short M10_L20
       mov       rdi,r15
       xor       esi,esi
       call      qword ptr [7C7902D369B8]
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
       call      qword ptr [7C790379DBC0]
       jmp       near ptr M10_L11
M10_L20:
       mov       rdi,rbx
       mov       rsi,r15
       call      qword ptr [7C790379CAB0]; System.Threading.Tasks.Task.TrySetException(System.Object)
       jmp       near ptr M10_L11
M10_L21:
       mov       rdi,rbx
       call      qword ptr [7C7903797270]
       mov       esi,eax
       mov       rdi,r13
       mov       edx,1
       call      qword ptr [7C790379DC50]
       jmp       near ptr M10_L03
M10_L22:
       mov       rdi,rbx
       call      qword ptr [7C790379DC68]
       jmp       near ptr M10_L04
M10_L23:
       mov       rsi,r15
       mov       rdi,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M10_L05
M10_L24:
       mov       esi,1
       call      qword ptr [7C790379DD10]; System.Threading.Tasks.Task`1[[System.Int32, System.Private.CoreLib]].GetResultCore(Boolean)
       mov       r15d,eax
       jmp       near ptr M10_L06
M10_L25:
       mov       rdi,rbx
       mov       esi,4000000
       mov       edx,5600000
       call      qword ptr [7C7903864C30]
       test      eax,eax
       je        near ptr M10_L10
       jmp       near ptr M10_L07
M10_L26:
       mov       rdi,rbx
       call      qword ptr [7C790379CBB8]; System.Threading.Tasks.Task.NotifyParentIfPotentiallyAttachedTask()
       mov       rdi,r14
       call      qword ptr [7C7903864E40]
       jmp       near ptr M10_L08
M10_L27:
       call      qword ptr [7C7903864888]
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
       call      qword ptr [7C7903797960]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7C7903865788]
       jmp       short M11_L01
M11_L04:
       test      r15b,2
       jne       short M11_L05
       mov       rdi,rbx
       call      qword ptr [7C79038655F0]
M11_L05:
       mov       rdi,rbx
       call      qword ptr [7C7903865BF0]
       jmp       short M11_L02
; Total bytes of code 125
```

