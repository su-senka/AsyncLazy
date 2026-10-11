## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.ContendedFirstCallBenchmarks.LazyOfTask()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rbx,rcx
       mov       rcx,offset MT_AsyncLazyBenchmarks.ContendedFirstCallBenchmarks+<>c__DisplayClass8_0
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_System.Lazy<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,1AD26001300
       mov       rdx,[rcx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.LazyHelper
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+10],8
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       edi,edi
M00_L00:
       mov       rbp,[rbx+8]
       cmp       [rbp+8],edi
       jle       near ptr M00_L20
       mov       r14,[rsi+10]
       test      r14,r14
       jne       short M00_L01
       mov       rcx,offset MT_System.Func<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset AsyncLazyBenchmarks.ContendedFirstCallBenchmarks+<>c__DisplayClass8_0.<LazyOfTask>b__0()
       mov       [r14+18],rcx
       lea       rcx,[rsi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       mov       rcx,1AD26001320
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M00_L31
M00_L02:
       cmp       [rax],al
       mov       rcx,1AD26001330
       mov       r15,[rcx]
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rcx,[r13+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r13+10],rcx
       lea       rcx,[r13+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,2008
       mov       [r13+34],ecx
       mov       rcx,gs:[58]
       mov       rcx,[rcx+48]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M00_L32
       mov       rcx,[rcx+240]
       mov       rax,[rcx+20]
       test      rax,rax
       je        near ptr M00_L32
M00_L03:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M00_L04
       call      qword ptr [7FF80D0C5458]; System.Threading.Thread.InitializeCurrentThread()
M00_L04:
       mov       r14,[rax+8]
       test      r14,r14
       jne       short M00_L08
       mov       rcx,1AD26001340
       mov       r14,[rcx]
M00_L05:
       test      r14,r14
       jne       short M00_L09
       or        dword ptr [r13+34],20000000
M00_L06:
       mov       rcx,r13
       xor       edx,edx
       call      qword ptr [7FF80D1E40C0]; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
       mov       rcx,offset MT_System.Threading.Tasks.UnwrapPromise<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       movzx     r15d,word ptr [r13+34]
       and       r15d,4
       test      r15d,0FFFFFFBB
       je        short M00_L11
M00_L07:
       mov       ecx,2D
       call      qword ptr [7FF80CDEF348]
       int       3
M00_L08:
       cmp       byte ptr [r14+18],0
       je        short M00_L05
       xor       r14d,r14d
       jmp       short M00_L05
M00_L09:
       mov       rcx,1AD26001340
       cmp       r14,[rcx]
       je        short M00_L06
       mov       rax,[r13+28]
       test      rax,rax
       jne       short M00_L10
       mov       rcx,offset MT_System.Threading.Tasks.Task+ContingentProperties
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       dword ptr [r15+3C],1
       lea       rcx,[r13+28]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,r15
M00_L10:
       lea       rcx,[rax+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L06
M00_L11:
       test      r15b,4
       je        short M00_L14
       mov       rcx,gs:[58]
       mov       rcx,[rcx+48]
       cmp       dword ptr [rcx+238],8
       jle       near ptr M00_L33
       mov       rcx,[rcx+240]
       mov       rax,[rcx+40]
       test      rax,rax
       je        near ptr M00_L33
M00_L12:
       mov       r12,[rax+10]
       test      r12,r12
       je        short M00_L14
       mov       rax,[r14+28]
       test      rax,rax
       jne       short M00_L13
       mov       rcx,offset MT_System.Threading.Tasks.Task+ContingentProperties
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+30],rax
       mov       dword ptr [rax+3C],1
       lea       rcx,[r14+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+30]
M00_L13:
       lea       rcx,[rax+30]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
M00_L14:
       xor       ecx,ecx
       mov       [r14+8],rcx
       mov       [r14+10],rcx
       mov       [r14+18],rcx
       test      r15d,0FFFFFFA0
       jne       near ptr M00_L07
       mov       ecx,r15d
       or        ecx,400
       or        ecx,2000000
       mov       [r14+34],ecx
       mov       rcx,[r14+28]
       test      rcx,rcx
       jne       near ptr M00_L34
M00_L15:
       mov       byte ptr [r14+3D],1
       mov       rcx,1AD26001350
       mov       rcx,[rcx]
       cmp       byte ptr [rcx+9D],0
       jne       near ptr M00_L35
M00_L16:
       cmp       byte ptr [7FF80CD2B074],0
       jne       near ptr M00_L36
M00_L17:
       test      dword ptr [r13+34],1600000
       jne       near ptr M00_L37
       test      dword ptr [r13+34],1600000
       jne       short M00_L19
       cmp       qword ptr [r13+20],0
       jne       near ptr M00_L38
       lea       rcx,[r13+20]
       test      rcx,rcx
       je        near ptr M00_L46
       mov       rdx,r14
       xor       r8d,r8d
       call      00007FF86CA021C0
       test      rax,rax
       jne       near ptr M00_L38
M00_L18:
       movsxd    rdx,edi
       mov       rcx,rbp
       mov       r8,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       edi
       jmp       near ptr M00_L00
M00_L19:
       mov       rcx,r14
       mov       rdx,r13
       call      qword ptr [7FF80D1D9660]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
       jmp       short M00_L18
M00_L20:
       mov       rdx,rbp
       test      rdx,rdx
       je        near ptr M00_L39
       lea       rbx,[rdx+10]
       mov       esi,[rdx+8]
       test      esi,esi
       je        near ptr M00_L40
       mov       edx,esi
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Int32>[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       r8d,esi
       shl       r8,3
       cmp       r8,4000
       jbe       short M00_L21
       mov       rdx,rbx
       call      qword ptr [7FF80D1ECAE0]
       jmp       short M00_L22
M00_L21:
       mov       rdx,rbx
       call      00007FF86C9D37A0
       cmp       dword ptr [7FF86CD13A90],0
       jne       near ptr M00_L41
M00_L22:
       mov       ebx,[rdi+8]
       test      ebx,ebx
       jle       short M00_L24
       lea       rcx,[rdi+10]
       mov       edx,ebx
M00_L23:
       cmp       qword ptr [rcx],0
       je        near ptr M00_L42
       add       rcx,8
       dec       edx
       jne       short M00_L23
M00_L24:
       mov       rcx,offset MT_System.Threading.Tasks.Task+WhenAllPromise<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+34],2000400
       lea       rcx,[rsi+40]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsi+48],ebx
       mov       rcx,1AD26001350
       mov       rcx,[rcx]
       cmp       byte ptr [rcx+9D],0
       jne       near ptr M00_L43
M00_L25:
       cmp       byte ptr [7FF80CD2B074],0
       jne       near ptr M00_L44
M00_L26:
       test      ebx,ebx
       jle       short M00_L29
       add       rdi,10
M00_L27:
       mov       rbp,[rdi]
       test      dword ptr [rbp+34],1600000
       jne       short M00_L30
       test      dword ptr [rbp+34],1600000
       jne       short M00_L30
       cmp       qword ptr [rbp+20],0
       jne       near ptr M00_L45
       lea       rcx,[rbp+20]
       test      rcx,rcx
       je        near ptr M00_L46
       mov       rdx,rsi
       xor       r8d,r8d
       call      00007FF86CA021C0
       test      rax,rax
       jne       near ptr M00_L45
M00_L28:
       add       rdi,8
       dec       ebx
       jne       short M00_L27
M00_L29:
       mov       rax,rsi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L30:
       mov       rcx,rsi
       mov       rdx,rbp
       call      qword ptr [7FF80D1F9B30]; System.Threading.Tasks.Task+WhenAllPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
       jmp       short M00_L28
M00_L31:
       mov       rcx,offset MT_System.Threading.Tasks.TaskFactory<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       rcx,1AD26001320
       xor       r8d,r8d
       call      00007FF86CA021C0
       test      rax,rax
       jne       near ptr M00_L02
       mov       rax,1AD26001320
       mov       rax,[rax]
       jmp       near ptr M00_L02
M00_L32:
       mov       ecx,4
       call      qword ptr [7FF80D1EC198]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L03
M00_L33:
       mov       ecx,8
       call      qword ptr [7FF80D1EC198]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L12
M00_L34:
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M00_L15
       test      r15b,4
       je        near ptr M00_L15
       test      byte ptr [rcx+34],8
       jne       near ptr M00_L15
       call      qword ptr [7FF80D1E7ED0]
       jmp       near ptr M00_L15
M00_L35:
       mov       rcx,r14
       call      qword ptr [7FF80D1E48E8]
       mov       edx,eax
       mov       rcx,1AD26001350
       mov       rcx,[rcx]
       mov       r8,1BD25419790
       xor       r9d,r9d
       call      qword ptr [7FF80D1E4900]
       jmp       near ptr M00_L16
M00_L36:
       mov       rcx,r14
       call      qword ptr [7FF80D1E4918]
       jmp       near ptr M00_L17
M00_L37:
       mov       rcx,r14
       mov       rdx,r13
       call      qword ptr [7FF80D1E4948]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].ProcessCompletedOuterTask(System.Threading.Tasks.Task)
       jmp       near ptr M00_L18
M00_L38:
       mov       rcx,r13
       mov       rdx,r14
       xor       r8d,r8d
       call      qword ptr [7FF80D1E6430]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M00_L18
       jmp       near ptr M00_L19
M00_L39:
       mov       ecx,33
       call      qword ptr [7FF80CDEFD38]
       int       3
M00_L40:
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Int32[]>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rsi
       xor       edx,edx
       mov       r8,1BD25418F30
       xor       r9d,r9d
       call      qword ptr [7FF80D1E4F60]
       jmp       near ptr M00_L29
M00_L41:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L22
M00_L42:
       mov       ecx,1D
       mov       edx,33
       call      qword ptr [7FF80D1E4F90]
       int       3
M00_L43:
       mov       rcx,rsi
       call      qword ptr [7FF80D1E48E8]
       mov       edx,eax
       mov       rcx,1AD26001350
       mov       rcx,[rcx]
       mov       r8,1BD25419E48
       xor       r9d,r9d
       call      qword ptr [7FF80D1E4900]
       jmp       near ptr M00_L25
M00_L44:
       mov       rcx,rsi
       call      qword ptr [7FF80D1E4918]
       jmp       near ptr M00_L26
M00_L45:
       mov       rcx,rbp
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF80D1E6430]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M00_L28
       jmp       near ptr M00_L30
M00_L46:
       call      qword ptr [7FF80D1E7CD8]
       int       3
; Total bytes of code 1638
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M01_L00
       ret
M01_L00:
       xor       edx,edx
       jmp       qword ptr [7FF80D1E5020]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
; Total bytes of code 26
```
```assembly
; AsyncLazyBenchmarks.ContendedFirstCallBenchmarks+<>c__DisplayClass8_0.<LazyOfTask>b__0()
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+8],0
       je        short M02_L00
       jmp       qword ptr [7FF80D0C5848]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
M02_L00:
       mov       rax,[rcx+18]
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
; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       [rbp+10],rcx
       test      dl,dl
       jne       near ptr M04_L19
       or        dword ptr [rcx+34],10000
M04_L00:
       cmp       byte ptr [7FF80CD2B074],0
       jne       near ptr M04_L20
M04_L01:
       mov       rax,1AD26001350
       mov       rbx,[rax]
       cmp       byte ptr [rbx+9D],0
       jne       near ptr M04_L21
M04_L02:
       mov       rsi,[rcx+18]
       cmp       [rsi],sil
       cmp       byte ptr [rbx+9D],0
       jne       near ptr M04_L10
M04_L03:
       mov       rdx,offset MT_System.Threading.Tasks.ThreadPoolTaskScheduler
       cmp       [rsi],rdx
       jne       near ptr M04_L17
       movzx     esi,word ptr [rcx+34]
       test      sil,2
       jne       near ptr M04_L11
       mov       rdx,1AD26001358
       mov       rbx,[rdx]
       cmp       byte ptr [rbx+38],0
       jne       near ptr M04_L12
M04_L04:
       test      sil,1
       jne       short M04_L06
       mov       rax,gs:[58]
       mov       rax,[rax+48]
       cmp       dword ptr [rax+238],5
       jle       near ptr M04_L13
       mov       rax,[rax+240]
       mov       rax,[rax+28]
       test      rax,rax
       je        near ptr M04_L13
M04_L05:
       mov       rdx,[rax+10]
       test      rdx,rdx
       jne       near ptr M04_L14
M04_L06:
       mov       rdx,[rbx+8]
       mov       r8,[rdx+10]
       mov       r10,[r8+8]
M04_L07:
       mov       esi,[r8+0A0]
       mov       eax,esi
       and       eax,[r8+18]
       cmp       eax,[r10+8]
       jae       near ptr M04_L15
       shl       rax,4
       lea       rdi,[r10+rax+10]
       mov       eax,[rdi+8]
       sub       eax,esi
       je        short M04_L08
       test      eax,eax
       jge       short M04_L07
       mov       rcx,rdx
       mov       rdx,[rbp+10]
       call      qword ptr [7FF80D1EC768]
       jmp       short M04_L09
M04_L08:
       lea       r9,[r8+0A0]
       lea       r11d,[rsi+1]
       mov       eax,esi
       lock cmpxchg [r9],r11d
       cmp       eax,esi
       jne       short M04_L07
       mov       rdx,[rbp+10]
       mov       rcx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       inc       esi
       mov       [rdi+8],esi
M04_L09:
       add       rbx,78
       mov       ecx,1
       xchg      ecx,[rbx]
       test      ecx,ecx
       jne       near ptr M04_L18
       mov       rcx,1AD26001380
       mov       rbx,[rcx]
       lea       rcx,[rbx+178]
       lock inc  dword ptr [rcx]
       mov       rcx,rbx
       call      qword ptr [7FF80D1E45A0]; System.Threading.PortableThreadPool+WorkerThread.MaybeAddWorkingWorker(System.Threading.PortableThreadPool)
       cmp       dword ptr [rbx+17C],6
       je        near ptr M04_L18
       jmp       near ptr M04_L16
M04_L10:
       mov       rdx,rsi
       call      qword ptr [7FF80D1EC5E8]
       mov       rcx,[rbp+10]
       jmp       near ptr M04_L03
M04_L11:
       mov       rcx,offset MT_System.Threading.Tasks.ThreadPoolTaskScheduler
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1AD26001438
       mov       rbx,[rcx]
       mov       rcx,offset MT_System.Threading.Thread
       call      CORINFO_HELP_NEWFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF80D1ECFD8]
       mov       rcx,rsi
       mov       edx,1
       call      qword ptr [7FF80D1E4708]; System.Threading.Thread.set_IsBackground(Boolean)
       mov       rcx,rsi
       mov       rdx,1BD25418C38
       call      qword ptr [7FF80D1E4810]; System.Threading.Thread.set_Name(System.String)
       mov       rcx,rsi
       mov       rdx,[rbp+10]
       xor       r8d,r8d
       call      qword ptr [7FF80D1ECFF0]
       jmp       near ptr M04_L18
M04_L12:
       mov       rdx,1AD26001370
       mov       rdx,[rdx]
       cmp       byte ptr [rdx+9D],0
       je        near ptr M04_L04
       mov       rdx,1AD26001370
       mov       rcx,[rdx]
       mov       rdx,[rbp+10]
       call      qword ptr [7FF80D1EC738]
       jmp       near ptr M04_L04
M04_L13:
       mov       ecx,5
       call      qword ptr [7FF80D1EC198]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M04_L05
M04_L14:
       mov       rcx,[rdx+18]
       mov       rdx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF80D1EC750]
       jmp       near ptr M04_L09
M04_L15:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M04_L16:
       mov       rcx,rbx
       call      qword ptr [7FF80D1E4780]; System.Threading.PortableThreadPool+GateThread.EnsureRunningSlow(System.Threading.PortableThreadPool)
       jmp       short M04_L18
M04_L17:
       mov       rcx,rsi
       mov       rdx,[rbp+10]
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       nop
M04_L18:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M04_L19:
       call      qword ptr [7FF80D1ECFC0]
       test      eax,eax
       mov       rcx,[rbp+10]
       jne       near ptr M04_L00
       jmp       short M04_L18
M04_L20:
       call      qword ptr [7FF80D1E4918]
       mov       rcx,[rbp+10]
       jmp       near ptr M04_L01
M04_L21:
       test      word ptr [rcx+34],200
       jne       near ptr M04_L02
       call      qword ptr [7FF80D1E48E8]
       mov       esi,eax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       call      qword ptr [7FF80D1EC558]
       mov       rdx,rax
       mov       rcx,1BD25418BB0
       call      qword ptr [7FF80CDED9C8]; System.String.Concat(System.String, System.String)
       mov       r8,rax
       mov       edx,esi
       mov       rcx,rbx
       xor       r9d,r9d
       call      qword ptr [7FF80D1E4900]
       mov       rcx,[rbp+10]
       jmp       near ptr M04_L02
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_System.Threading.Tasks.TaskSchedulerException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF80D1EC570]
       mov       rcx,[rbp+10]
       mov       rdx,rsi
       call      qword ptr [7FF80D1EC588]
       mov       rcx,[rbp+10]
       xor       edx,edx
       call      qword ptr [7FF80D1EC5A0]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80D1EC5B8]
       test      eax,200
       jne       short M04_L22
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+28]
       mov       rcx,[rcx+18]
       xor       edx,edx
       cmp       [rcx],ecx
       call      qword ptr [7FF80D1EC5D0]
M04_L22:
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 879
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M05_L01
       lea       rax,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       mov       rdx,[rcx+30]
       test      r8,r8
       je        short M05_L00
       cmp       rdx,[r8]
       je        short M05_L02
       mov       r10,offset MT_System.Object[]
       cmp       rcx,r10
       je        short M05_L02
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FF80D0C4EB8]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
M05_L00:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M05_L01:
       call      qword ptr [7FF80D1E7B58]
       int       3
M05_L02:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FF86CA540D0
; Total bytes of code 94
```
```assembly
; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       call      00007FF86CA10B20
       test      eax,eax
       je        near ptr M06_L19
       movzx     edi,byte ptr [rbx+3C]
       test      edi,edi
       jne       near ptr M06_L08
       mov       byte ptr [rbx+3C],1
       mov       edx,[rsi+34]
       test      edx,200000
       jne       near ptr M06_L09
       test      edx,400000
       jne       near ptr M06_L10
       test      edx,1000000
       je        near ptr M06_L11
       mov       edi,5
M06_L00:
       cmp       edi,5
       jne       near ptr M06_L07
       mov       rcx,rsi
       mov       rax,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task<System.Int32>>
       cmp       [rcx],rax
       jne       near ptr M06_L15
M06_L01:
       test      rcx,rcx
       je        short M06_L05
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       near ptr M06_L16
       mov       rdx,[rcx+38]
M06_L02:
       test      rdx,rdx
       je        near ptr M06_L17
       test      dword ptr [rdx+34],1600000
       je        near ptr M06_L18
       mov       rcx,rbx
       xor       r8d,r8d
       call      qword ptr [7FF80D1E55F0]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
M06_L03:
       mov       byte ptr [rbx+3C],2
M06_L04:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M06_L05:
       mov       rcx,rsi
       mov       rax,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task>
       cmp       [rcx],rax
       je        short M06_L06
       mov       rdx,rsi
       mov       rcx,rax
       call      qword ptr [7FF80CFC4D20]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rcx,rax
M06_L06:
       cmp       [rcx],ecx
       call      qword ptr [7FF80D1E5620]; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].get_Result()
       mov       rdx,rax
       jmp       short M06_L02
M06_L07:
       add       edi,0FFFFFFFA
       cmp       edi,1
       ja        short M06_L04
       jmp       short M06_L14
M06_L08:
       cmp       edi,1
       jne       short M06_L04
       mov       rcx,rbx
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF80D1E55F0]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       jmp       short M06_L03
M06_L09:
       mov       edi,7
       jmp       near ptr M06_L00
M06_L10:
       mov       edi,6
       jmp       near ptr M06_L00
M06_L11:
       test      edx,800000
       je        short M06_L12
       mov       edi,4
       jmp       near ptr M06_L00
M06_L12:
       test      edx,20000
       je        short M06_L13
       mov       edi,3
       jmp       near ptr M06_L00
M06_L13:
       test      edx,2000000
       setne     dil
       movzx     edi,dil
       mov       ecx,2
       test      edx,10000
       cmovne    edi,ecx
       jmp       near ptr M06_L00
M06_L14:
       movzx     r8d,byte ptr [rbx+3D]
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF80D1E55F0]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       jmp       near ptr M06_L04
M06_L15:
       mov       rdx,rsi
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rcx,rax
       jmp       near ptr M06_L01
M06_L16:
       mov       edx,1
       call      qword ptr [7FF80D1EC4E0]
       mov       rdx,rax
       jmp       near ptr M06_L02
M06_L17:
       mov       rcx,rbx
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FF80D1E56B0]
       jmp       near ptr M06_L03
M06_L18:
       mov       rcx,rdx
       mov       rdx,rbx
       xor       r8d,r8d
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF80D1E4960]; System.Threading.Tasks.Task.AddCompletionAction(System.Threading.Tasks.ITaskCompletionAction, Boolean)
M06_L19:
       mov       rcx,rbx
       mov       rdx,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF80D1E55D8]
; Total bytes of code 481
```
```assembly
; System.Threading.Tasks.Task+WhenAllPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rbx,rcx
       mov       rcx,1AD26001350
       mov       rsi,[rcx]
       cmp       byte ptr [rsi+9D],0
       jne       near ptr M07_L12
M07_L00:
       lea       rdx,[rbx+48]
       mov       ecx,0FFFFFFFF
       lock xadd [rdx],ecx
       dec       ecx
       jne       near ptr M07_L11
       mov       rdx,[rbx+40]
       mov       edx,[rdx+8]
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       xor       ebp,ebp
       xor       r14d,r14d
       xor       r15d,r15d
       jmp       near ptr M07_L06
M07_L01:
       cmp       r15d,[rcx+8]
       jae       near ptr M07_L27
       mov       r13d,r15d
       mov       r12,[rcx+r13*8+10]
       test      dword ptr [r12+34],200000
       jne       near ptr M07_L13
       mov       ecx,[r12+34]
       and       ecx,600000
       cmp       ecx,400000
       je        near ptr M07_L16
       test      dword ptr [r12+34],1600000
       je        near ptr M07_L17
M07_L02:
       mov       ecx,[r12+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       near ptr M07_L18
M07_L03:
       mov       ecx,[r12+38]
       cmp       r15d,[rdi+8]
       jae       near ptr M07_L27
       mov       [rdi+r13*4+10],ecx
M07_L04:
       test      dword ptr [r12+34],10000000
       jne       near ptr M07_L19
       mov       rcx,[rbx+40]
       cmp       r15d,[rcx+8]
       jae       near ptr M07_L27
       xor       edx,edx
       mov       [rcx+r13*8+10],rdx
M07_L05:
       inc       r15d
M07_L06:
       mov       rcx,[rbx+40]
       cmp       [rcx+8],r15d
       jg        near ptr M07_L01
       test      rbp,rbp
       jne       near ptr M07_L20
       test      r14,r14
       jne       near ptr M07_L21
       cmp       byte ptr [rsi+9D],0
       jne       near ptr M07_L22
M07_L07:
       cmp       byte ptr [7FF80CD2B074],0
       jne       near ptr M07_L23
M07_L08:
       mov       eax,[rbx+34]
       mov       [rsp+34],eax
       test      eax,5600000
       jne       short M07_L11
       lea       rcx,[rbx+34]
       mov       edx,eax
       or        edx,4000000
       lock cmpxchg [rcx],edx
       cmp       eax,[rsp+34]
       jne       near ptr M07_L24
M07_L09:
       lea       rcx,[rbx+38]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+34]
       mov       eax,[rbx+34]
       or        eax,1000000
       xchg      eax,[rcx]
       mov       r14,[rbx+28]
       test      r14,r14
       jne       near ptr M07_L25
M07_L10:
       lea       rcx,[rbx+20]
       test      rcx,rcx
       je        near ptr M07_L26
       mov       rdx,1AD26000218
       mov       rdx,[rdx]
       call      00007FF86CA0C330
       test      rax,rax
       je        short M07_L11
       mov       rcx,rbx
       mov       rdx,rax
       call      qword ptr [7FF80D1E5560]; System.Threading.Tasks.Task.RunContinuations(System.Object)
M07_L11:
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M07_L12:
       mov       rcx,rbx
       call      qword ptr [7FF80D1E48E8]
       mov       edx,eax
       mov       rcx,rsi
       mov       r8d,1
       call      qword ptr [7FF80D1E5668]
       jmp       near ptr M07_L00
M07_L13:
       test      rbp,rbp
       jne       short M07_L14
       mov       rcx,offset MT_System.Collections.Generic.List<System.Runtime.ExceptionServices.ExceptionDispatchInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FF80D0CC4C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
M07_L14:
       mov       rcx,[r12+28]
       mov       rax,[rcx+18]
       mov       [rsp+28],rax
       mov       rdx,[rax+10]
       mov       [rsp+20],rdx
       cmp       byte ptr [rax+20],0
       jne       short M07_L15
       mov       rcx,rax
       call      qword ptr [7FF80D0C55F0]; System.GC.SuppressFinalize(System.Object)
       mov       rcx,[rsp+28]
       mov       byte ptr [rcx+20],1
M07_L15:
       mov       rcx,rbp
       mov       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF80D1E5800]
       jmp       near ptr M07_L04
M07_L16:
       test      r14,r14
       jne       near ptr M07_L04
       mov       r14,r12
       jmp       near ptr M07_L04
M07_L17:
       mov       rcx,r12
       mov       edx,0FFFFFFFF
       xor       r8d,r8d
       call      qword ptr [7FF80D1E5038]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
       jmp       near ptr M07_L02
M07_L18:
       mov       rcx,r12
       mov       edx,1
       call      qword ptr [7FF80D1EC618]
       jmp       near ptr M07_L03
M07_L19:
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FF80D1E5860]
       jmp       near ptr M07_L05
M07_L20:
       mov       rcx,rbx
       mov       rdx,rbp
       call      qword ptr [7FF80D1E5740]
       jmp       near ptr M07_L11
M07_L21:
       mov       rcx,r14
       call      qword ptr [7FF80D1E5680]
       mov       rbp,rax
       mov       rcx,r14
       call      qword ptr [7FF80D1E5698]
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      qword ptr [7FF80D1E56B0]
       jmp       near ptr M07_L11
M07_L22:
       mov       rcx,rbx
       call      qword ptr [7FF80D1E48E8]
       mov       edx,eax
       mov       rcx,rsi
       mov       r8d,1
       call      qword ptr [7FF80D1E5758]
       jmp       near ptr M07_L07
M07_L23:
       mov       rcx,rbx
       call      qword ptr [7FF80D1E5770]
       jmp       near ptr M07_L08
M07_L24:
       mov       rcx,rbx
       mov       edx,4000000
       mov       r8d,5600000
       call      qword ptr [7FF80D1EC528]
       test      eax,eax
       je        near ptr M07_L11
       jmp       near ptr M07_L09
M07_L25:
       mov       rcx,rbx
       call      qword ptr [7FF80D1EC708]
       mov       rcx,r14
       call      qword ptr [7FF80D1EC720]
       jmp       near ptr M07_L10
M07_L26:
       call      qword ptr [7FF80D1E7CD8]
       int       3
M07_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 840
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
       jne       short M08_L01
       cmp       [rax],ecx
       jle       short M08_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M08_L03
M08_L00:
       add       rsp,20
       pop       rbx
       ret
M08_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M08_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M08_L00
M08_L02:
       cmp       [rax+4],edx
       jle       short M08_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M08_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M08_L03
       jmp       short M08_L00
M08_L03:
       mov       ecx,ebx
       lea       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].ProcessCompletedOuterTask(System.Threading.Tasks.Task)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       byte ptr [rbx+3C],1
       mov       edx,[rsi+34]
       test      edx,200000
       jne       near ptr M09_L08
       test      edx,400000
       jne       near ptr M09_L09
       test      edx,1000000
       je        near ptr M09_L10
       mov       edi,5
M09_L00:
       cmp       edi,5
       jne       near ptr M09_L07
       mov       rcx,rsi
       mov       rax,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task<System.Int32>>
       cmp       [rcx],rax
       jne       near ptr M09_L14
M09_L01:
       test      rcx,rcx
       je        short M09_L05
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       near ptr M09_L15
       mov       rdx,[rcx+38]
M09_L02:
       test      rdx,rdx
       je        near ptr M09_L16
       test      dword ptr [rdx+34],1600000
       je        near ptr M09_L17
       mov       rcx,rbx
       xor       r8d,r8d
       call      qword ptr [7FF80D1E55F0]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
M09_L03:
       mov       byte ptr [rbx+3C],2
M09_L04:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M09_L05:
       mov       rcx,rsi
       mov       rax,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task>
       cmp       [rcx],rax
       je        short M09_L06
       mov       rdx,rsi
       mov       rcx,rax
       call      qword ptr [7FF80CFC4D20]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rcx,rax
M09_L06:
       cmp       [rcx],ecx
       call      qword ptr [7FF80D1E5620]; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].get_Result()
       mov       rdx,rax
       jmp       short M09_L02
M09_L07:
       add       edi,0FFFFFFFA
       cmp       edi,1
       ja        short M09_L04
       jmp       short M09_L13
M09_L08:
       mov       edi,7
       jmp       near ptr M09_L00
M09_L09:
       mov       edi,6
       jmp       near ptr M09_L00
M09_L10:
       test      edx,800000
       je        short M09_L11
       mov       edi,4
       jmp       near ptr M09_L00
M09_L11:
       test      edx,20000
       je        short M09_L12
       mov       edi,3
       jmp       near ptr M09_L00
M09_L12:
       test      edx,2000000
       setne     dil
       movzx     edi,dil
       mov       ecx,2
       test      edx,10000
       cmovne    edi,ecx
       jmp       near ptr M09_L00
M09_L13:
       movzx     r8d,byte ptr [rbx+3D]
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF80D1E55F0]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       jmp       near ptr M09_L04
M09_L14:
       mov       rdx,rsi
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rcx,rax
       jmp       near ptr M09_L01
M09_L15:
       mov       edx,1
       call      qword ptr [7FF80D1EC4E0]
       mov       rdx,rax
       jmp       near ptr M09_L02
M09_L16:
       mov       rcx,rbx
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FF80D1E56B0]
       jmp       near ptr M09_L03
M09_L17:
       mov       rcx,rdx
       mov       rdx,rbx
       xor       r8d,r8d
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF80D1E4960]; System.Threading.Tasks.Task.AddCompletionAction(System.Threading.Tasks.ITaskCompletionAction, Boolean)
; Total bytes of code 414
```
```assembly
; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       r14,[rbx+20]
       mov       rdx,1AD26000218
       cmp       r14,[rdx]
       jne       short M10_L01
M10_L00:
       xor       eax,eax
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M10_L01:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.List<System.Object>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       jne       near ptr M10_L11
       mov       rcx,offset MT_System.Collections.Generic.List<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FF80D0CC4C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       test      dil,dil
       je        short M10_L05
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M10_L02
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rsi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M10_L03
M10_L02:
       mov       rcx,r15
       mov       rdx,rsi
       call      qword ptr [7FF80CDE71C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M10_L03:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M10_L04
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M10_L09
M10_L04:
       mov       rcx,r15
       mov       rdx,r14
       call      qword ptr [7FF80CDE71C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M10_L09
M10_L05:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M10_L06
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M10_L07
M10_L06:
       mov       rcx,r15
       mov       rdx,r14
       call      qword ptr [7FF80CDE71C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M10_L07:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M10_L08
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rsi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M10_L09
M10_L08:
       mov       rcx,r15
       mov       rdx,rsi
       call      qword ptr [7FF80CDE71C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M10_L09:
       lea       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M10_L10
       call      qword ptr [7FF80D1E7CD8]
       int       3
M10_L10:
       mov       rdx,r15
       mov       r8,r14
       call      00007FF86CA021C0
       mov       r15,rax
       cmp       r15,r14
       je        near ptr M10_L20
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.List<System.Object>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       je        near ptr M10_L00
M10_L11:
       mov       [rbp-40],r15
       xor       edx,edx
       mov       [rbp-30],edx
       lea       rdx,[rbp-30]
       mov       rcx,r15
       call      qword ptr [7FF80CDE5998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rbx+20]
       mov       rax,1AD26000218
       cmp       rcx,[rax]
       jne       short M10_L12
       xor       ecx,ecx
       mov       [rbp-34],ecx
       jmp       near ptr M10_L18
M10_L12:
       mov       ecx,[r15+10]
       mov       rax,[r15+8]
       cmp       ecx,[rax+8]
       jne       short M10_L14
       mov       rcx,1AD26000270
       mov       rdx,[rcx]
       test      rdx,rdx
       jne       short M10_L13
       mov       rcx,offset MT_System.Predicate<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1AD26000240
       mov       rdx,[rdx]
       mov       rcx,rbx
       mov       r8,7FF80D1E8D50
       call      qword ptr [7FF80CDE6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1AD26000270
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rbx
M10_L13:
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FF80D1ECD68]
M10_L14:
       test      dil,dil
       je        short M10_L15
       mov       rcx,r15
       mov       r8,rsi
       xor       edx,edx
       call      qword ptr [7FF80CED35F0]
       jmp       short M10_L19
M10_L15:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M10_L16
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rsi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M10_L19
M10_L16:
       mov       rcx,r15
       mov       rdx,rsi
       call      qword ptr [7FF80CDE71C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M10_L19
M10_L17:
       mov       rcx,r15
       call      qword ptr [7FF80CDE6820]; System.Threading.Monitor.Exit(System.Object)
       jmp       short M10_L20
M10_L18:
       call      M10_L22
       jmp       short M10_L21
M10_L19:
       cmp       byte ptr [rbp-30],0
       jne       short M10_L17
M10_L20:
       mov       eax,1
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M10_L21:
       mov       eax,[rbp-34]
       movzx     eax,al
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M10_L22:
       sub       rsp,28
       cmp       byte ptr [rbp-30],0
       je        short M10_L23
       mov       rcx,[rbp-40]
       call      qword ptr [7FF80CDE6820]; System.Threading.Monitor.Exit(System.Object)
M10_L23:
       nop
       add       rsp,28
       ret
; Total bytes of code 702
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      dword ptr [rbx+34],1600000
       jne       short M11_L00
       mov       rcx,rbx
       mov       edx,0FFFFFFFF
       xor       r8d,r8d
       call      qword ptr [7FF80D1E5038]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M11_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M11_L03
M11_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M11_L04
M11_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M11_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M11_L01
       mov       rcx,rbx
       call      qword ptr [7FF80D1ECB10]
       jmp       short M11_L01
M11_L04:
       test      sil,2
       jne       short M11_L05
       mov       rcx,rbx
       call      qword ptr [7FF80D1ECB28]
M11_L05:
       mov       rcx,rbx
       call      qword ptr [7FF80D1ED110]
       jmp       short M11_L02
; Total bytes of code 124
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.ContendedFirstCallBenchmarks.AsyncLazy()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_AsyncLazyBenchmarks.ContendedFirstCallBenchmarks+<>c__DisplayClass9_0
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,1B7B0801300
       mov       rdx,[rcx]
       lea       rcx,[rdi+18]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       edi,edi
       jmp       near ptr M00_L07
M00_L00:
       or        dword ptr [r13+34],20000000
M00_L01:
       mov       rcx,r13
       xor       edx,edx
       call      qword ptr [7FF80D1A4018]; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
       mov       rcx,offset MT_System.Threading.Tasks.UnwrapPromise<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       movzx     r15d,word ptr [r13+34]
       and       r15d,4
       test      r15d,0FFFFFFBB
       jne       near ptr M00_L38
       test      r15b,4
       jne       near ptr M00_L31
M00_L02:
       xor       ecx,ecx
       mov       [r14+8],rcx
       mov       [r14+10],rcx
       mov       [r14+18],rcx
       test      r15d,0FFFFFFA0
       jne       near ptr M00_L38
       mov       ecx,r15d
       or        ecx,400
       or        ecx,2000000
       mov       [r14+34],ecx
       mov       rcx,[r14+28]
       test      rcx,rcx
       jne       near ptr M00_L32
M00_L03:
       mov       byte ptr [r14+3D],1
       mov       rcx,1B7B0801350
       mov       rcx,[rcx]
       cmp       byte ptr [rcx+9D],0
       jne       near ptr M00_L33
M00_L04:
       cmp       byte ptr [7FF80CCEB074],0
       jne       near ptr M00_L34
M00_L05:
       test      dword ptr [r13+34],1600000
       jne       near ptr M00_L36
       test      dword ptr [r13+34],1600000
       jne       near ptr M00_L15
       cmp       qword ptr [r13+20],0
       jne       near ptr M00_L14
       lea       rcx,[r13+20]
       test      rcx,rcx
       je        near ptr M00_L45
       mov       rdx,r14
       xor       r8d,r8d
       call      00007FF86CA021C0
       test      rax,rax
       jne       near ptr M00_L14
M00_L06:
       movsxd    rdx,edi
       mov       rcx,rbp
       mov       r8,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       edi
M00_L07:
       mov       rbp,[rbx+8]
       cmp       [rbp+8],edi
       jle       near ptr M00_L16
       mov       r14,[rsi+10]
       test      r14,r14
       jne       short M00_L08
       mov       rcx,offset MT_System.Func<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset AsyncLazyBenchmarks.ContendedFirstCallBenchmarks+<>c__DisplayClass9_0.<AsyncLazy>b__0()
       mov       [r14+18],rcx
       lea       rcx,[rsi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M00_L08:
       mov       rcx,1B7B0801320
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M00_L28
M00_L09:
       cmp       [rax],al
       mov       rcx,1B7B0801330
       mov       r15,[rcx]
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rcx,[r13+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r13+10],rcx
       lea       rcx,[r13+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,2008
       mov       [r13+34],ecx
       mov       rcx,gs:[58]
       mov       rcx,[rcx+48]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M00_L29
       mov       rcx,[rcx+240]
       mov       rax,[rcx+20]
       test      rax,rax
       je        near ptr M00_L29
M00_L10:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M00_L11
       call      qword ptr [7FF80D085458]; System.Threading.Thread.InitializeCurrentThread()
M00_L11:
       mov       r14,[rax+8]
       test      r14,r14
       jne       near ptr M00_L30
       mov       rcx,1B7B0801340
       mov       r14,[rcx]
M00_L12:
       test      r14,r14
       je        near ptr M00_L00
       mov       rcx,1B7B0801340
       cmp       r14,[rcx]
       je        near ptr M00_L01
       mov       rax,[r13+28]
       test      rax,rax
       jne       short M00_L13
       mov       rcx,offset MT_System.Threading.Tasks.Task+ContingentProperties
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       dword ptr [r15+3C],1
       lea       rcx,[r13+28]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,r15
M00_L13:
       lea       rcx,[rax+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L14:
       mov       rcx,r13
       mov       rdx,r14
       xor       r8d,r8d
       call      qword ptr [7FF80D1A5968]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M00_L06
M00_L15:
       call      00007FF86CA10B20
       test      eax,eax
       je        near ptr M00_L37
       movzx     ecx,byte ptr [r14+3C]
       test      ecx,ecx
       je        near ptr M00_L36
       jmp       near ptr M00_L35
M00_L16:
       mov       rdx,rbp
       test      rdx,rdx
       je        near ptr M00_L39
       lea       rbx,[rdx+10]
       mov       esi,[rdx+8]
       test      esi,esi
       je        near ptr M00_L40
       mov       edx,esi
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Int32>[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       r8d,esi
       shl       r8,3
       cmp       r8,4000
       jbe       short M00_L17
       mov       rdx,rbx
       call      qword ptr [7FF80D1AD350]
       jmp       short M00_L18
M00_L17:
       mov       rdx,rbx
       call      00007FF86C9D37A0
       cmp       dword ptr [7FF86CD13A90],0
       jne       near ptr M00_L41
M00_L18:
       mov       ebx,[rdi+8]
       test      ebx,ebx
       jle       short M00_L20
       lea       rcx,[rdi+10]
       mov       edx,ebx
M00_L19:
       cmp       qword ptr [rcx],0
       je        near ptr M00_L42
       add       rcx,8
       dec       edx
       jne       short M00_L19
M00_L20:
       mov       rcx,offset MT_System.Threading.Tasks.Task+WhenAllPromise<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+34],2000400
       lea       rcx,[rsi+40]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsi+48],ebx
       mov       rcx,1B7B0801350
       mov       rcx,[rcx]
       cmp       byte ptr [rcx+9D],0
       jne       near ptr M00_L43
M00_L21:
       cmp       byte ptr [7FF80CCEB074],0
       jne       near ptr M00_L44
M00_L22:
       test      ebx,ebx
       jle       short M00_L25
       add       rdi,10
M00_L23:
       mov       rbp,[rdi]
       test      dword ptr [rbp+34],1600000
       jne       short M00_L27
       test      dword ptr [rbp+34],1600000
       jne       short M00_L27
       cmp       qword ptr [rbp+20],0
       jne       short M00_L26
       lea       rcx,[rbp+20]
       test      rcx,rcx
       je        near ptr M00_L45
       mov       rdx,rsi
       xor       r8d,r8d
       call      00007FF86CA021C0
       test      rax,rax
       jne       short M00_L26
M00_L24:
       add       rdi,8
       dec       ebx
       jne       short M00_L23
M00_L25:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L26:
       mov       rcx,rbp
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF80D1A5968]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       short M00_L24
M00_L27:
       mov       rcx,rsi
       mov       rdx,rbp
       call      qword ptr [7FF80D1B97C8]; System.Threading.Tasks.Task+WhenAllPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
       jmp       short M00_L24
M00_L28:
       mov       rcx,offset MT_System.Threading.Tasks.TaskFactory<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       rcx,1B7B0801320
       xor       r8d,r8d
       call      00007FF86CA021C0
       test      rax,rax
       jne       near ptr M00_L09
       mov       rax,1B7B0801320
       mov       rax,[rax]
       jmp       near ptr M00_L09
M00_L29:
       mov       ecx,4
       call      qword ptr [7FF80D1AC960]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L10
M00_L30:
       cmp       byte ptr [r14+18],0
       je        near ptr M00_L12
       xor       r14d,r14d
       jmp       near ptr M00_L12
M00_L31:
       mov       ecx,8
       call      qword ptr [7FF80D1AC960]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r12,[rax+10]
       test      r12,r12
       je        near ptr M00_L02
       mov       rcx,r14
       call      qword ptr [7FF80D1ACBB8]
       lea       rcx,[rax+30]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L02
M00_L32:
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M00_L03
       test      r15b,4
       je        near ptr M00_L03
       test      byte ptr [rcx+34],8
       jne       near ptr M00_L03
       call      qword ptr [7FF80D1AC900]
       jmp       near ptr M00_L03
M00_L33:
       mov       rcx,r14
       call      qword ptr [7FF80D1A4840]
       mov       edx,eax
       mov       rcx,1B7B0801350
       mov       rcx,[rcx]
       mov       r8,1B7A52997B8
       xor       r9d,r9d
       call      qword ptr [7FF80D1A4858]
       jmp       near ptr M00_L04
M00_L34:
       mov       rcx,r14
       call      qword ptr [7FF80D1A4870]
       jmp       near ptr M00_L05
M00_L35:
       cmp       ecx,1
       jne       near ptr M00_L06
       mov       rcx,r14
       mov       rdx,r13
       xor       r8d,r8d
       call      qword ptr [7FF80D1A5830]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       mov       byte ptr [r14+3C],2
       jmp       near ptr M00_L06
M00_L36:
       mov       rcx,r14
       mov       rdx,r13
       call      qword ptr [7FF80D1A48A0]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].ProcessCompletedOuterTask(System.Threading.Tasks.Task)
       jmp       near ptr M00_L06
M00_L37:
       mov       rcx,r14
       mov       rdx,r13
       call      qword ptr [7FF80D1A5800]
       jmp       near ptr M00_L06
M00_L38:
       mov       ecx,2D
       call      qword ptr [7FF80CDAF348]
       int       3
M00_L39:
       mov       ecx,33
       call      qword ptr [7FF80CDAFD38]
       int       3
M00_L40:
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Int32[]>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rsi
       xor       edx,edx
       mov       r8,1B7A5298F58
       xor       r9d,r9d
       call      qword ptr [7FF80D1A4EB8]
       jmp       near ptr M00_L25
M00_L41:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L18
M00_L42:
       mov       ecx,1D
       mov       edx,33
       call      qword ptr [7FF80D1A4EE8]
       int       3
M00_L43:
       mov       rcx,rsi
       call      qword ptr [7FF80D1A4840]
       mov       edx,eax
       mov       rcx,1B7B0801350
       mov       rcx,[rcx]
       mov       r8,1B7A5299E70
       xor       r9d,r9d
       call      qword ptr [7FF80D1A4858]
       jmp       near ptr M00_L21
M00_L44:
       mov       rcx,rsi
       call      qword ptr [7FF80D1A4870]
       jmp       near ptr M00_L22
M00_L45:
       call      qword ptr [7FF80D1AC690]
       int       3
; Total bytes of code 1595
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M01_L00
       ret
M01_L00:
       xor       edx,edx
       jmp       qword ptr [7FF80D1A4F78]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
; Total bytes of code 26
```
```assembly
; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       [rbp+10],rcx
       test      dl,dl
       jne       near ptr M02_L19
       or        dword ptr [rcx+34],10000
M02_L00:
       cmp       byte ptr [7FF80CCEB074],0
       jne       near ptr M02_L20
M02_L01:
       mov       rax,1B7B0801350
       mov       rbx,[rax]
       cmp       byte ptr [rbx+9D],0
       jne       near ptr M02_L21
M02_L02:
       mov       rsi,[rcx+18]
       cmp       [rsi],sil
       cmp       byte ptr [rbx+9D],0
       jne       near ptr M02_L11
M02_L03:
       mov       rdx,offset MT_System.Threading.Tasks.ThreadPoolTaskScheduler
       cmp       [rsi],rdx
       jne       near ptr M02_L17
       movzx     esi,word ptr [rcx+34]
       test      sil,2
       jne       near ptr M02_L12
       mov       rdx,1B7B0801358
       mov       rbx,[rdx]
       cmp       byte ptr [rbx+38],0
       jne       near ptr M02_L13
M02_L04:
       test      sil,1
       jne       short M02_L06
       mov       rax,gs:[58]
       mov       rax,[rax+48]
       cmp       dword ptr [rax+238],5
       jle       near ptr M02_L14
       mov       rax,[rax+240]
       mov       rax,[rax+28]
       test      rax,rax
       je        near ptr M02_L14
M02_L05:
       mov       rdx,[rax+10]
       test      rdx,rdx
       jne       short M02_L08
M02_L06:
       mov       rdx,[rbx+8]
       mov       r8,[rdx+10]
       mov       r10,[r8+8]
M02_L07:
       mov       esi,[r8+0A0]
       mov       eax,esi
       and       eax,[r8+18]
       cmp       eax,[r10+8]
       jae       near ptr M02_L15
       shl       rax,4
       lea       rdi,[r10+rax+10]
       mov       eax,[rdi+8]
       sub       eax,esi
       jne       near ptr M02_L10
       lea       r9,[r8+0A0]
       lea       r11d,[rsi+1]
       mov       eax,esi
       lock cmpxchg [r9],r11d
       cmp       eax,esi
       jne       short M02_L07
       mov       rdx,[rbp+10]
       mov       rcx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       inc       esi
       mov       [rdi+8],esi
       jmp       short M02_L09
M02_L08:
       mov       rcx,[rdx+18]
       mov       rdx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF80D1A5FF8]; System.Threading.ThreadPoolWorkQueue+WorkStealingQueue.LocalPush(System.Object)
M02_L09:
       add       rbx,78
       mov       ecx,1
       xchg      ecx,[rbx]
       test      ecx,ecx
       jne       near ptr M02_L18
       mov       rcx,1B7B0801380
       mov       rbx,[rcx]
       lea       rcx,[rbx+178]
       lock inc  dword ptr [rcx]
       mov       rcx,rbx
       call      qword ptr [7FF80D1A44F8]; System.Threading.PortableThreadPool+WorkerThread.MaybeAddWorkingWorker(System.Threading.PortableThreadPool)
       cmp       dword ptr [rbx+17C],6
       je        near ptr M02_L18
       jmp       near ptr M02_L16
M02_L10:
       test      eax,eax
       jge       near ptr M02_L07
       mov       rcx,rdx
       mov       rdx,[rbp+10]
       call      qword ptr [7FF80D1AC978]
       jmp       short M02_L09
M02_L11:
       mov       rdx,rsi
       call      qword ptr [7FF80D1ACDC8]
       mov       rcx,[rbp+10]
       jmp       near ptr M02_L03
M02_L12:
       mov       rcx,offset MT_System.Threading.Tasks.ThreadPoolTaskScheduler
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1B7B0801470
       mov       rbx,[rcx]
       mov       rcx,offset MT_System.Threading.Thread
       call      CORINFO_HELP_NEWFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF80D1ADAB8]
       mov       rcx,rsi
       mov       edx,1
       call      qword ptr [7FF80D1A4660]; System.Threading.Thread.set_IsBackground(Boolean)
       mov       rcx,rsi
       mov       rdx,1B7A5298C60
       call      qword ptr [7FF80D1A4750]; System.Threading.Thread.set_Name(System.String)
       mov       rcx,rsi
       mov       rdx,[rbp+10]
       xor       r8d,r8d
       call      qword ptr [7FF80D1ADAD0]
       jmp       short M02_L18
M02_L13:
       mov       rdx,1B7B0801370
       mov       rdx,[rdx]
       cmp       byte ptr [rdx+9D],0
       je        near ptr M02_L04
       mov       rdx,1B7B0801370
       mov       rcx,[rdx]
       mov       rdx,[rbp+10]
       call      qword ptr [7FF80D1AC948]
       jmp       near ptr M02_L04
M02_L14:
       mov       ecx,5
       call      qword ptr [7FF80D1AC960]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M02_L05
M02_L15:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L16:
       mov       rcx,rbx
       call      qword ptr [7FF80D1A46D8]; System.Threading.PortableThreadPool+GateThread.EnsureRunningSlow(System.Threading.PortableThreadPool)
       jmp       short M02_L18
M02_L17:
       mov       rcx,rsi
       mov       rdx,[rbp+10]
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       nop
M02_L18:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L19:
       call      qword ptr [7FF80D1ADAA0]
       test      eax,eax
       mov       rcx,[rbp+10]
       jne       near ptr M02_L00
       jmp       short M02_L18
M02_L20:
       call      qword ptr [7FF80D1A4870]
       mov       rcx,[rbp+10]
       jmp       near ptr M02_L01
M02_L21:
       test      word ptr [rcx+34],200
       jne       near ptr M02_L02
       call      qword ptr [7FF80D1A4840]
       mov       esi,eax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       call      qword ptr [7FF80D1ACD38]
       mov       rdx,rax
       mov       rcx,1B7A5298BD8
       call      qword ptr [7FF80CDAD9C8]; System.String.Concat(System.String, System.String)
       mov       r8,rax
       mov       edx,esi
       mov       rcx,rbx
       xor       r9d,r9d
       call      qword ptr [7FF80D1A4858]
       mov       rcx,[rbp+10]
       jmp       near ptr M02_L02
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_System.Threading.Tasks.TaskSchedulerException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF80D1ACD50]
       mov       rcx,[rbp+10]
       mov       rdx,rsi
       call      qword ptr [7FF80D1ACD68]
       mov       rcx,[rbp+10]
       xor       edx,edx
       call      qword ptr [7FF80D1ACD80]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80D1ACD98]
       test      eax,200
       jne       short M02_L22
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+28]
       mov       rcx,[rcx+18]
       xor       edx,edx
       cmp       [rcx],ecx
       call      qword ptr [7FF80D1ACDB0]
M02_L22:
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 877
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M03_L02
       lea       rax,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       mov       rdx,[rcx+30]
       test      r8,r8
       je        short M03_L01
       cmp       rdx,[r8]
       je        short M03_L00
       mov       r10,offset MT_System.Object[]
       cmp       rcx,r10
       je        short M03_L00
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FF80D084EB8]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
M03_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FF86CA540D0
M03_L01:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M03_L02:
       call      qword ptr [7FF80D1AC540]
       int       3
; Total bytes of code 94
```
```assembly
; AsyncLazyBenchmarks.ContendedFirstCallBenchmarks+<>c__DisplayClass9_0.<AsyncLazy>b__0()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,[rcx+8]
       mov       rax,[rbx+10]
       test      rax,rax
       jne       near ptr M04_L18
M04_L00:
       mov       rsi,[rbx+8]
       mov       rax,rsi
       test      rax,rax
       je        short M04_L01
       mov       rdx,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt
       cmp       [rax],rdx
       jne       near ptr M04_L19
       xor       eax,eax
M04_L01:
       test      rax,rax
       jne       near ptr M04_L22
       test      rsi,rsi
       je        short M04_L02
       mov       rcx,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt
       cmp       [rsi],rcx
       je        near ptr M04_L11
M04_L02:
       lea       rcx,[rbx+20]
       cmp       qword ptr [rcx],0
       jne       near ptr M04_L21
M04_L03:
       mov       rcx,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_System.Threading.Tasks.TaskCompletionSource<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Int32>
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
       je        near ptr M04_L27
       mov       rdx,rdi
       xor       r8d,r8d
       call      00007FF86CA021C0
       test      rax,rax
       jne       near ptr M04_L00
       mov       rcx,1B7B08013D0
       mov       rbx,[rcx]
       test      rbx,rbx
       je        near ptr M04_L28
M04_L04:
       call      qword ptr [7FF80D11FFC0]; System.Threading.ExecutionContext.Capture()
       mov       rsi,rax
       test      rsi,rsi
       je        short M04_L05
       cmp       byte ptr [rsi+19],0
       je        near ptr M04_L29
M04_L05:
       mov       rcx,offset MT_System.Threading.QueueUserWorkItemCallbackDefaultContext<System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M04_L06:
       mov       rcx,1B7B0801358
       mov       rbx,[rcx]
       cmp       byte ptr [rbx+38],0
       jne       near ptr M04_L30
M04_L07:
       mov       rsi,[rbx+8]
       mov       rcx,[rsi+10]
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FF80D1A42E8]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       je        near ptr M04_L31
M04_L08:
       add       rbx,78
       mov       eax,1
       xchg      eax,[rbx]
       test      eax,eax
       jne       short M04_L09
       call      qword ptr [7FF80D1A4300]; System.Threading.ThreadPool.RequestWorkerThread()
M04_L09:
       mov       rax,[rdi+10]
       mov       rax,[rax+8]
M04_L10:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L11:
       mov       rcx,1B7B08013D8
       mov       rdi,[rcx]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+48]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M04_L20
       mov       rcx,[rcx+240]
       mov       rax,[rcx+20]
       test      rax,rax
       je        near ptr M04_L20
M04_L12:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M04_L13
       call      qword ptr [7FF80D085458]; System.Threading.Thread.InitializeCurrentThread()
M04_L13:
       mov       rcx,[rax+8]
       test      rcx,rcx
       je        short M04_L14
       mov       rcx,[rcx+8]
       lea       r8,[rsp+20]
       mov       rdx,rdi
       mov       r11,7FF80CCF0598
       call      qword ptr [r11]
       mov       rdx,[rsp+20]
       jmp       short M04_L15
M04_L14:
       xor       edx,edx
M04_L15:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rdx
       test      rcx,rcx
       je        short M04_L16
       mov       rax,offset MT_System.Threading.Tasks.AsyncLazyAttemptFrame
       cmp       [rcx],rax
       jne       short M04_L23
M04_L16:
       test      rcx,rcx
       jne       short M04_L24
M04_L17:
       mov       rcx,[rsi+10]
       mov       rax,[rcx+8]
       jmp       near ptr M04_L10
M04_L18:
       jmp       near ptr M04_L10
M04_L19:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       jmp       near ptr M04_L01
M04_L20:
       mov       ecx,4
       call      qword ptr [7FF80D1AC960]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M04_L12
M04_L21:
       mov       rcx,[rcx]
       cmp       dword ptr [rcx+20],0
       je        near ptr M04_L03
       jmp       short M04_L26
M04_L22:
       jmp       near ptr M04_L10
M04_L23:
       mov       rcx,rax
       call      qword ptr [7FF80CDA6328]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M04_L24:
       cmp       [rcx+8],rsi
       je        short M04_L25
       mov       rcx,[rcx+10]
       test      rcx,rcx
       jne       short M04_L24
       jmp       short M04_L17
M04_L25:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,1B7A5299EC8
       call      qword ptr [7FF80D087D38]
       mov       rcx,rbx
       call      qword ptr [7FF80D1A5500]
       jmp       near ptr M04_L10
M04_L26:
       mov       rcx,[rbx+20]
       call      qword ptr [7FF80D11FDC8]
       jmp       near ptr M04_L10
M04_L27:
       call      qword ptr [7FF80D1AC690]
       int       3
M04_L28:
       mov       rcx,offset MT_System.Action<System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,1B7B08013C8
       mov       rdx,[rcx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset System.Threading.Tasks.AsyncLazy`1+<>c[[System.Int32, System.Private.CoreLib]].<GetOrStartAttemptAsync>b__11_0(Attempt<Int32>)
       mov       [rbx+18],rcx
       mov       rcx,1B7B08013D0
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M04_L04
M04_L29:
       mov       rcx,offset MT_System.Threading.QueueUserWorkItemCallback<System.Threading.Tasks.AsyncLazy<System.Int32>+Attempt>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rbx
       mov       r8,rdi
       mov       r9,rsi
       call      qword ptr [7FF80D1AD290]
       jmp       near ptr M04_L06
M04_L30:
       mov       rcx,1B7B0801370
       mov       rcx,[rcx]
       cmp       byte ptr [rcx+9D],0
       je        near ptr M04_L07
       mov       rcx,1B7B0801370
       mov       rcx,[rcx]
       mov       rdx,rbp
       call      qword ptr [7FF80D1AC948]
       jmp       near ptr M04_L07
M04_L31:
       mov       rcx,rsi
       mov       rdx,rbp
       call      qword ptr [7FF80D1AC978]
       jmp       near ptr M04_L08
; Total bytes of code 946
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
; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       r14,[rbx+20]
       mov       rdx,1B7B0800218
       cmp       r14,[rdx]
       je        near ptr M06_L05
       mov       r15,r14
       test      r15,r15
       je        short M06_L00
       mov       rdx,offset MT_System.Threading.Tasks.UnwrapPromise<System.Int32>
       cmp       [r15],rdx
       jne       near ptr M06_L06
       xor       r15d,r15d
M06_L00:
       test      r15,r15
       jne       near ptr M06_L10
       mov       rcx,offset MT_System.Collections.Generic.List<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,1B7B0800A60
       mov       rdx,[rcx]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      dil,dil
       jne       near ptr M06_L07
       inc       dword ptr [r15+14]
       mov       rcx,r15
       mov       rdx,r14
       call      qword ptr [7FF80CDA71C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M06_L03
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       edx,edx
       mov       r8,rsi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M06_L01:
       lea       rcx,[rbx+20]
       test      rcx,rcx
       je        near ptr M06_L09
       mov       rdx,r15
       mov       r8,r14
       call      00007FF86CA021C0
       mov       r15,rax
       cmp       r15,r14
       jne       short M06_L04
M06_L02:
       mov       eax,1
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M06_L03:
       mov       rcx,r15
       mov       rdx,rsi
       call      qword ptr [7FF80CDA71C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M06_L01
M06_L04:
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.List<System.Object>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       jne       short M06_L10
M06_L05:
       xor       eax,eax
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M06_L06:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.List<System.Object>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r15,rax
       jmp       near ptr M06_L00
M06_L07:
       inc       dword ptr [r15+14]
       mov       rcx,r15
       mov       rdx,rsi
       call      qword ptr [7FF80CDA71C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M06_L08
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       edx,edx
       mov       r8,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M06_L01
M06_L08:
       mov       rcx,r15
       mov       rdx,r14
       call      qword ptr [7FF80CDA71C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M06_L01
M06_L09:
       call      qword ptr [7FF80D1AC690]
       int       3
M06_L10:
       mov       [rbp-40],r15
       xor       edx,edx
       mov       [rbp-30],edx
       lea       rdx,[rbp-30]
       mov       rcx,r15
       call      qword ptr [7FF80CDA5998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rbx+20]
       mov       rax,1B7B0800218
       cmp       rcx,[rax]
       jne       short M06_L11
       xor       ecx,ecx
       mov       [rbp-34],ecx
       jmp       near ptr M06_L17
M06_L11:
       mov       ecx,[r15+10]
       mov       rax,[r15+8]
       cmp       ecx,[rax+8]
       jne       short M06_L13
       mov       rcx,1B7B0800270
       mov       rdx,[rcx]
       test      rdx,rdx
       jne       short M06_L12
       mov       rcx,offset MT_System.Predicate<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1B7B0800240
       mov       rdx,[rdx]
       mov       rcx,rbx
       mov       r8,7FF80D1A9668
       call      qword ptr [7FF80CDA6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1B7B0800270
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rbx
M06_L12:
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FF80D1AD680]
M06_L13:
       test      dil,dil
       je        short M06_L14
       mov       rcx,r15
       mov       r8,rsi
       xor       edx,edx
       call      qword ptr [7FF80CE935F0]
       jmp       short M06_L18
M06_L14:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M06_L15
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rsi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M06_L18
M06_L15:
       mov       rcx,r15
       mov       rdx,rsi
       call      qword ptr [7FF80CDA71C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M06_L18
M06_L16:
       mov       rcx,r15
       call      qword ptr [7FF80CDA6820]; System.Threading.Monitor.Exit(System.Object)
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
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M06_L20:
       sub       rsp,28
       cmp       byte ptr [rbp-30],0
       je        short M06_L21
       mov       rcx,[rbp-40]
       call      qword ptr [7FF80CDA6820]; System.Threading.Monitor.Exit(System.Object)
M06_L21:
       nop
       add       rsp,28
       ret
; Total bytes of code 711
```
```assembly
; System.Threading.Tasks.Task+WhenAllPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rbx,rcx
       mov       rcx,1B7B0801350
       mov       rsi,[rcx]
       cmp       byte ptr [rsi+9D],0
       jne       near ptr M07_L16
M07_L00:
       lea       rdx,[rbx+48]
       mov       ecx,0FFFFFFFF
       lock xadd [rdx],ecx
       dec       ecx
       jne       near ptr M07_L15
       mov       rdx,[rbx+40]
       mov       edx,[rdx+8]
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       xor       ebp,ebp
       xor       r14d,r14d
       xor       r15d,r15d
M07_L01:
       mov       rcx,[rbx+40]
       cmp       [rcx+8],r15d
       jle       near ptr M07_L10
       cmp       r15d,[rcx+8]
       jae       near ptr M07_L29
       mov       r13d,r15d
       mov       r12,[rcx+r13*8+10]
       test      dword ptr [r12+34],200000
       jne       short M07_L06
       mov       ecx,[r12+34]
       and       ecx,600000
       cmp       ecx,400000
       je        near ptr M07_L18
       test      dword ptr [r12+34],1600000
       je        near ptr M07_L19
M07_L02:
       mov       ecx,[r12+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       near ptr M07_L20
M07_L03:
       mov       ecx,[r12+38]
       cmp       r15d,[rdi+8]
       jae       near ptr M07_L29
       mov       [rdi+r13*4+10],ecx
M07_L04:
       test      dword ptr [r12+34],10000000
       jne       short M07_L09
       mov       rax,[rbx+40]
       cmp       r15d,[rax+8]
       jae       near ptr M07_L29
       xor       ecx,ecx
       mov       [rax+r13*8+10],rcx
M07_L05:
       inc       r15d
       jmp       near ptr M07_L01
M07_L06:
       test      rbp,rbp
       je        near ptr M07_L17
M07_L07:
       mov       rcx,[r12+28]
       mov       rax,[rcx+18]
       mov       [rsp+28],rax
       mov       rdx,[rax+10]
       mov       [rsp+20],rdx
       cmp       byte ptr [rax+20],0
       jne       short M07_L08
       mov       rcx,rax
       call      qword ptr [7FF80D0855F0]; System.GC.SuppressFinalize(System.Object)
       mov       rcx,[rsp+28]
       mov       byte ptr [rcx+20],1
M07_L08:
       mov       rcx,rbp
       mov       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF80D1A61C0]
       jmp       short M07_L04
M07_L09:
       mov       eax,[rbx+34]
       mov       [rsp+34],eax
       test      eax,5600000
       jne       short M07_L05
       lea       rcx,[rbx+34]
       mov       edx,eax
       or        edx,10000000
       lock cmpxchg [rcx],edx
       cmp       eax,[rsp+34]
       je        short M07_L05
       jmp       near ptr M07_L21
M07_L10:
       test      rbp,rbp
       jne       near ptr M07_L22
       test      r14,r14
       jne       near ptr M07_L23
       cmp       byte ptr [rsi+9D],0
       jne       near ptr M07_L24
M07_L11:
       cmp       byte ptr [7FF80CCEB074],0
       jne       near ptr M07_L25
M07_L12:
       mov       eax,[rbx+34]
       mov       [rsp+30],eax
       test      eax,5600000
       jne       short M07_L15
       lea       rcx,[rbx+34]
       mov       edx,eax
       or        edx,4000000
       lock cmpxchg [rcx],edx
       cmp       eax,[rsp+30]
       jne       near ptr M07_L26
M07_L13:
       lea       rcx,[rbx+38]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+34]
       mov       eax,[rbx+34]
       or        eax,1000000
       xchg      eax,[rcx]
       mov       r14,[rbx+28]
       test      r14,r14
       jne       near ptr M07_L27
M07_L14:
       lea       rcx,[rbx+20]
       test      rcx,rcx
       je        near ptr M07_L28
       mov       rdx,1B7B0800218
       mov       rdx,[rdx]
       call      00007FF86CA0C330
       test      rax,rax
       je        short M07_L15
       mov       rcx,rbx
       mov       rdx,rax
       call      qword ptr [7FF80D1A5788]; System.Threading.Tasks.Task.RunContinuations(System.Object)
M07_L15:
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M07_L16:
       mov       rcx,rbx
       call      qword ptr [7FF80D1A4840]
       mov       edx,eax
       mov       rcx,rsi
       mov       r8d,1
       call      qword ptr [7FF80D1A6058]
       jmp       near ptr M07_L00
M07_L17:
       mov       rcx,offset MT_System.Collections.Generic.List<System.Runtime.ExceptionServices.ExceptionDispatchInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FF80D08C4C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       jmp       near ptr M07_L07
M07_L18:
       test      r14,r14
       jne       near ptr M07_L04
       mov       r14,r12
       jmp       near ptr M07_L04
M07_L19:
       mov       rcx,r12
       mov       edx,0FFFFFFFF
       xor       r8d,r8d
       call      qword ptr [7FF80D1A4F90]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
       jmp       near ptr M07_L02
M07_L20:
       mov       rcx,r12
       mov       edx,1
       call      qword ptr [7FF80D1ADA70]
       jmp       near ptr M07_L03
M07_L21:
       mov       rcx,rbx
       mov       edx,10000000
       mov       r8d,5600000
       call      qword ptr [7FF80D1ACC30]
       jmp       near ptr M07_L05
M07_L22:
       mov       rcx,rbx
       mov       rdx,rbp
       call      qword ptr [7FF80D1A6130]
       jmp       near ptr M07_L15
M07_L23:
       mov       rcx,r14
       call      qword ptr [7FF80D1A6070]
       mov       rbp,rax
       mov       rcx,r14
       call      qword ptr [7FF80D1A6088]
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      qword ptr [7FF80D1A60A0]
       jmp       near ptr M07_L15
M07_L24:
       mov       rcx,rbx
       call      qword ptr [7FF80D1A4840]
       mov       edx,eax
       mov       rcx,rsi
       mov       r8d,1
       call      qword ptr [7FF80D1A6148]
       jmp       near ptr M07_L11
M07_L25:
       mov       rcx,rbx
       call      qword ptr [7FF80D1A6160]
       jmp       near ptr M07_L12
M07_L26:
       mov       rcx,rbx
       mov       edx,4000000
       mov       r8d,5600000
       call      qword ptr [7FF80D1ACC30]
       test      eax,eax
       je        near ptr M07_L15
       jmp       near ptr M07_L13
M07_L27:
       mov       rcx,rbx
       call      qword ptr [7FF80D1ACC48]
       mov       rcx,r14
       call      qword ptr [7FF80D1ACC60]
       jmp       near ptr M07_L14
M07_L28:
       call      qword ptr [7FF80D1AC690]
       int       3
M07_L29:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 885
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
       jne       short M08_L01
       cmp       [rax],ecx
       jle       short M08_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M08_L03
M08_L00:
       add       rsp,20
       pop       rbx
       ret
M08_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M08_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M08_L00
M08_L02:
       cmp       [rax+4],edx
       jle       short M08_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M08_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M08_L03
       jmp       short M08_L00
M08_L03:
       mov       ecx,ebx
       lea       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
M09_L00:
       mov       rcx,1B7B0801350
       mov       rbp,[rcx]
       cmp       byte ptr [rbp+9D],0
       jne       near ptr M09_L12
M09_L01:
       xor       eax,eax
       mov       ecx,[rsi+34]
       test      ecx,200000
       jne       near ptr M09_L13
       test      ecx,400000
       jne       near ptr M09_L14
       test      ecx,1000000
       je        near ptr M09_L15
       mov       edx,5
M09_L02:
       add       edx,0FFFFFFFB
       jne       near ptr M09_L18
       cmp       byte ptr [rbp+9D],0
       jne       near ptr M09_L20
M09_L03:
       cmp       byte ptr [7FF80CCEB074],0
       jne       near ptr M09_L21
M09_L04:
       mov       rcx,rsi
       mov       rax,offset MT_System.Threading.Tasks.Task<System.Int32>
       cmp       [rcx],rax
       jne       near ptr M09_L22
M09_L05:
       test      rcx,rcx
       je        near ptr M09_L23
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       near ptr M09_L24
       mov       esi,[rcx+38]
M09_L06:
       xor       edi,edi
       mov       eax,[rbx+34]
       mov       [rsp+24],eax
       test      eax,5600000
       jne       short M09_L10
       lea       rcx,[rbx+34]
       mov       edx,eax
       or        edx,4000000
       lock cmpxchg [rcx],edx
       cmp       eax,[rsp+24]
       jne       near ptr M09_L25
M09_L07:
       mov       [rbx+38],esi
       lea       rcx,[rbx+34]
       mov       eax,[rbx+34]
       or        eax,1000000
       xchg      eax,[rcx]
       mov       rdi,[rbx+28]
       test      rdi,rdi
       jne       near ptr M09_L26
M09_L08:
       lea       rcx,[rbx+20]
       test      rcx,rcx
       je        near ptr M09_L27
       mov       rdx,1B7B0800218
       mov       rdx,[rdx]
       call      00007FF86CA0C330
       test      rax,rax
       je        short M09_L09
       mov       rcx,rbx
       mov       rdx,rax
       call      qword ptr [7FF80D1A5788]; System.Threading.Tasks.Task.RunContinuations(System.Object)
M09_L09:
       mov       edi,1
M09_L10:
       mov       eax,edi
M09_L11:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M09_L12:
       mov       rcx,rbx
       call      qword ptr [7FF80D1A4840]
       mov       edx,eax
       mov       rcx,rbp
       mov       r8d,1
       call      qword ptr [7FF80D1A6058]
       jmp       near ptr M09_L01
M09_L13:
       mov       edx,7
       jmp       near ptr M09_L02
M09_L14:
       mov       edx,6
       jmp       near ptr M09_L02
M09_L15:
       test      ecx,800000
       je        short M09_L16
       mov       edx,4
       jmp       near ptr M09_L02
M09_L16:
       test      ecx,20000
       je        short M09_L17
       mov       edx,3
       jmp       near ptr M09_L02
M09_L17:
       test      ecx,2000000
       setne     dl
       movzx     edx,dl
       mov       r8d,2
       test      ecx,10000
       cmovne    edx,r8d
       jmp       near ptr M09_L02
M09_L18:
       cmp       edx,2
       ja        near ptr M09_L11
       mov       ecx,edx
       lea       rax,[7FF80CE2DDE0]
       mov       eax,[rax+rcx*4]
       lea       rdx,[M09_L00]
       add       rax,rdx
       jmp       rax
       mov       rcx,rsi
       call      qword ptr [7FF80D1A6070]
       mov       rdi,rax
       mov       rcx,rsi
       call      qword ptr [7FF80D1A6088]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF80D1A60A0]
       jmp       near ptr M09_L11
       mov       rcx,rsi
       call      qword ptr [7FF80D1A60B8]
       mov       rsi,rax
       test      dil,dil
       je        short M09_L19
       cmp       dword ptr [rsi+10],0
       jle       short M09_L19
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF80CE93578]
       mov       rbp,rax
       test      rbp,rbp
       je        short M09_L19
       mov       rdx,[rbp+8]
       mov       rcx,offset MT_System.OperationCanceledException
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M09_L19
       mov       rdx,[rax+70]
       mov       rcx,rbx
       mov       r8,rbp
       call      qword ptr [7FF80D1A60A0]
       jmp       near ptr M09_L11
M09_L19:
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF80D1A6130]
       jmp       near ptr M09_L11
M09_L20:
       mov       rcx,rbx
       call      qword ptr [7FF80D1A4840]
       mov       edx,eax
       mov       rcx,rbp
       mov       r8d,1
       call      qword ptr [7FF80D1A6148]
       jmp       near ptr M09_L03
M09_L21:
       mov       rcx,rbx
       call      qword ptr [7FF80D1A6160]
       jmp       near ptr M09_L04
M09_L22:
       mov       rdx,rsi
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rcx,rax
       jmp       near ptr M09_L05
M09_L23:
       xor       esi,esi
       jmp       near ptr M09_L06
M09_L24:
       mov       edx,1
       call      qword ptr [7FF80D1A61D8]; System.Threading.Tasks.Task`1[[System.Int32, System.Private.CoreLib]].GetResultCore(Boolean)
       mov       esi,eax
       jmp       near ptr M09_L06
M09_L25:
       mov       rcx,rbx
       mov       edx,4000000
       mov       r8d,5600000
       call      qword ptr [7FF80D1ACC30]
       test      eax,eax
       je        near ptr M09_L10
       jmp       near ptr M09_L07
M09_L26:
       mov       rcx,rbx
       call      qword ptr [7FF80D1ACC48]
       mov       rcx,rdi
       call      qword ptr [7FF80D1ACC60]
       jmp       near ptr M09_L08
M09_L27:
       call      qword ptr [7FF80D1AC690]
       int       3
; Total bytes of code 765
```
```assembly
; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].ProcessCompletedOuterTask(System.Threading.Tasks.Task)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       byte ptr [rbx+3C],1
       mov       edx,[rsi+34]
       test      edx,200000
       jne       near ptr M10_L07
       test      edx,400000
       jne       near ptr M10_L08
       test      edx,1000000
       je        near ptr M10_L09
       mov       edi,5
M10_L00:
       cmp       edi,5
       jne       near ptr M10_L12
       mov       rcx,rsi
       mov       rax,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task<System.Int32>>
       cmp       [rcx],rax
       jne       near ptr M10_L13
M10_L01:
       test      rcx,rcx
       je        near ptr M10_L14
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       near ptr M10_L16
       mov       rdi,[rcx+38]
M10_L02:
       test      rdi,rdi
       je        near ptr M10_L17
       test      dword ptr [rdi+34],1600000
       jne       short M10_L05
       test      dword ptr [rdi+34],1600000
       jne       near ptr M10_L19
       cmp       qword ptr [rdi+20],0
       jne       short M10_L04
       lea       rcx,[rdi+20]
       test      rcx,rcx
       je        near ptr M10_L18
       mov       rdx,rbx
       xor       r8d,r8d
       call      00007FF86CA021C0
       test      rax,rax
       jne       short M10_L04
M10_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M10_L04:
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FF80D1A5968]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       short M10_L03
       jmp       near ptr M10_L19
M10_L05:
       mov       rcx,rbx
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FF80D1A5830]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
M10_L06:
       mov       byte ptr [rbx+3C],2
       jmp       short M10_L03
M10_L07:
       mov       edi,7
       jmp       near ptr M10_L00
M10_L08:
       mov       edi,6
       jmp       near ptr M10_L00
M10_L09:
       test      edx,800000
       je        short M10_L10
       mov       edi,4
       jmp       near ptr M10_L00
M10_L10:
       test      edx,20000
       je        short M10_L11
       mov       edi,3
       jmp       near ptr M10_L00
M10_L11:
       test      edx,2000000
       setne     dil
       movzx     edi,dil
       mov       ecx,2
       test      edx,10000
       cmovne    edi,ecx
       jmp       near ptr M10_L00
M10_L12:
       add       edi,0FFFFFFFA
       cmp       edi,1
       ja        near ptr M10_L03
       movzx     r8d,byte ptr [rbx+3D]
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF80D1A5830]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       jmp       near ptr M10_L03
M10_L13:
       mov       rdx,rsi
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rcx,rax
       jmp       near ptr M10_L01
M10_L14:
       mov       rcx,rsi
       mov       rax,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task>
       cmp       [rcx],rax
       je        short M10_L15
       mov       rdx,rsi
       mov       rcx,rax
       call      qword ptr [7FF80CF84D20]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rcx,rax
M10_L15:
       cmp       [rcx],ecx
       call      qword ptr [7FF80D1A5860]; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].get_Result()
       mov       rdi,rax
       jmp       near ptr M10_L02
M10_L16:
       mov       edx,1
       call      qword ptr [7FF80D1AD0B0]
       mov       rdi,rax
       jmp       near ptr M10_L02
M10_L17:
       mov       rcx,rbx
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FF80D1A60A0]
       jmp       near ptr M10_L06
M10_L18:
       call      qword ptr [7FF80D1AC690]
       int       3
M10_L19:
       mov       rcx,rbx
       mov       rdx,rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF80D1994E8]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
; Total bytes of code 501
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      dword ptr [rbx+34],1600000
       jne       short M11_L00
       mov       rcx,rbx
       mov       edx,0FFFFFFFF
       xor       r8d,r8d
       call      qword ptr [7FF80D1A4F90]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M11_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M11_L03
M11_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M11_L04
M11_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M11_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M11_L01
       mov       rcx,rbx
       call      qword ptr [7FF80D1AD1D0]
       jmp       short M11_L01
M11_L04:
       test      sil,2
       jne       short M11_L05
       mov       rcx,rbx
       call      qword ptr [7FF80D1AD368]
M11_L05:
       mov       rcx,rbx
       call      qword ptr [7FF80D1ADBD8]
       jmp       short M11_L02
; Total bytes of code 124
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.ContendedFirstCallBenchmarks.Nito()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rbx,rcx
       mov       rcx,offset MT_AsyncLazyBenchmarks.ContendedFirstCallBenchmarks+<>c__DisplayClass10_0
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_Nito.AsyncEx.AsyncLazy<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,220F9801300
       mov       rbp,[rcx]
       mov       rdx,rbp
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_Nito.AsyncEx.AsyncLazy<System.Int32>+<>c__DisplayClass14_0
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Func<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset Nito.AsyncEx.AsyncLazy`1+<>c__DisplayClass14_0[[System.Int32, System.Private.CoreLib]].<RunOnThreadPool>b__0()
       mov       [rbp+18],rcx
       lea       rcx,[rdi+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Lazy<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,[rdi+10]
       lea       rcx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.LazyHelper
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+10],8
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       edi,edi
M00_L00:
       mov       rbp,[rbx+8]
       cmp       [rbp+8],edi
       jle       near ptr M00_L23
       mov       r14,[rsi+10]
       test      r14,r14
       jne       short M00_L01
       mov       rcx,offset MT_System.Func<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset AsyncLazyBenchmarks.ContendedFirstCallBenchmarks+<>c__DisplayClass10_0.<Nito>b__0()
       mov       [r14+18],rcx
       lea       rcx,[rsi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       mov       rcx,220F9801320
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M00_L35
M00_L02:
       cmp       [rax],al
       mov       rcx,220F9801330
       mov       r15,[rcx]
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rcx,[r13+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r13+10],rcx
       lea       rcx,[r13+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,2008
       mov       [r13+34],ecx
       mov       rcx,gs:[58]
       mov       rcx,[rcx+48]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M00_L36
       mov       rcx,[rcx+240]
       mov       rax,[rcx+20]
       test      rax,rax
       je        near ptr M00_L36
M00_L03:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M00_L04
       call      qword ptr [7FF80D095458]; System.Threading.Thread.InitializeCurrentThread()
M00_L04:
       mov       r14,[rax+8]
       test      r14,r14
       jne       short M00_L08
       mov       rcx,220F9801340
       mov       r14,[rcx]
M00_L05:
       test      r14,r14
       jne       short M00_L09
       or        dword ptr [r13+34],20000000
M00_L06:
       mov       rcx,r13
       xor       edx,edx
       call      qword ptr [7FF80D1B4078]; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
       mov       rcx,offset MT_System.Threading.Tasks.UnwrapPromise<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       movzx     r15d,word ptr [r13+34]
       and       r15d,4
       test      r15d,0FFFFFFBB
       je        short M00_L11
M00_L07:
       mov       ecx,2D
       call      qword ptr [7FF80CDBF348]
       int       3
M00_L08:
       cmp       byte ptr [r14+18],0
       je        short M00_L05
       xor       r14d,r14d
       jmp       short M00_L05
M00_L09:
       mov       rcx,220F9801340
       cmp       r14,[rcx]
       je        short M00_L06
       mov       rax,[r13+28]
       test      rax,rax
       jne       short M00_L10
       mov       rcx,offset MT_System.Threading.Tasks.Task+ContingentProperties
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       dword ptr [r15+3C],1
       lea       rcx,[r13+28]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,r15
M00_L10:
       lea       rcx,[rax+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L06
M00_L11:
       test      r15b,4
       je        short M00_L14
       mov       rcx,gs:[58]
       mov       rcx,[rcx+48]
       cmp       dword ptr [rcx+238],8
       jle       near ptr M00_L37
       mov       rcx,[rcx+240]
       mov       rax,[rcx+40]
       test      rax,rax
       je        near ptr M00_L37
M00_L12:
       mov       r12,[rax+10]
       test      r12,r12
       je        short M00_L14
       mov       rax,[r14+28]
       test      rax,rax
       jne       short M00_L13
       mov       rcx,offset MT_System.Threading.Tasks.Task+ContingentProperties
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+30],rax
       mov       dword ptr [rax+3C],1
       lea       rcx,[r14+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+30]
M00_L13:
       lea       rcx,[rax+30]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
M00_L14:
       xor       ecx,ecx
       mov       [r14+8],rcx
       mov       [r14+10],rcx
       mov       [r14+18],rcx
       test      r15d,0FFFFFFA0
       jne       near ptr M00_L07
       mov       ecx,r15d
       or        ecx,400
       or        ecx,2000000
       mov       [r14+34],ecx
       mov       rcx,[r14+28]
       test      rcx,rcx
       jne       near ptr M00_L38
M00_L15:
       mov       byte ptr [r14+3D],1
       mov       rcx,220F9801350
       mov       rcx,[rcx]
       cmp       byte ptr [rcx+9D],0
       jne       near ptr M00_L39
M00_L16:
       cmp       byte ptr [7FF80CCFB074],0
       jne       near ptr M00_L40
M00_L17:
       test      dword ptr [r13+34],1600000
       jne       short M00_L21
       test      dword ptr [r13+34],1600000
       jne       short M00_L20
       cmp       qword ptr [r13+20],0
       jne       short M00_L19
       lea       rcx,[r13+20]
       test      rcx,rcx
       je        near ptr M00_L48
       mov       rdx,r14
       xor       r8d,r8d
       call      00007FF86CA021C0
       test      rax,rax
       jne       short M00_L19
M00_L18:
       movsxd    rdx,edi
       mov       rcx,rbp
       mov       r8,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       edi
       jmp       near ptr M00_L00
M00_L19:
       mov       rcx,r13
       mov       rdx,r14
       xor       r8d,r8d
       call      qword ptr [7FF80D1B56C8]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       short M00_L18
M00_L20:
       call      00007FF86CA10B20
       test      eax,eax
       je        near ptr M00_L41
       movzx     ecx,byte ptr [r14+3C]
       test      ecx,ecx
       jne       short M00_L22
M00_L21:
       mov       rcx,r14
       mov       rdx,r13
       call      qword ptr [7FF80D1B4900]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].ProcessCompletedOuterTask(System.Threading.Tasks.Task)
       jmp       short M00_L18
M00_L22:
       cmp       ecx,1
       jne       short M00_L18
       mov       rcx,r14
       mov       rdx,r13
       xor       r8d,r8d
       call      qword ptr [7FF80D1B55F0]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       mov       byte ptr [r14+3C],2
       jmp       short M00_L18
M00_L23:
       mov       rdx,rbp
       test      rdx,rdx
       je        near ptr M00_L42
       lea       rbx,[rdx+10]
       mov       esi,[rdx+8]
       test      esi,esi
       je        near ptr M00_L43
       mov       edx,esi
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Int32>[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       r8d,esi
       shl       r8,3
       cmp       r8,4000
       jbe       short M00_L24
       mov       rdx,rbx
       call      qword ptr [7FF80D1BCC00]
       jmp       short M00_L25
M00_L24:
       mov       rdx,rbx
       call      00007FF86C9D37A0
       cmp       dword ptr [7FF86CD13A90],0
       jne       near ptr M00_L44
M00_L25:
       mov       ebx,[rdi+8]
       test      ebx,ebx
       jle       short M00_L27
       lea       rcx,[rdi+10]
       mov       edx,ebx
M00_L26:
       cmp       qword ptr [rcx],0
       je        near ptr M00_L45
       add       rcx,8
       dec       edx
       jne       short M00_L26
M00_L27:
       mov       rcx,offset MT_System.Threading.Tasks.Task+WhenAllPromise<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+34],2000400
       lea       rcx,[rsi+40]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsi+48],ebx
       mov       rcx,220F9801350
       mov       rcx,[rcx]
       cmp       byte ptr [rcx+9D],0
       jne       near ptr M00_L46
M00_L28:
       cmp       byte ptr [7FF80CCFB074],0
       jne       near ptr M00_L47
M00_L29:
       test      ebx,ebx
       jle       short M00_L32
       add       rdi,10
M00_L30:
       mov       rbp,[rdi]
       test      dword ptr [rbp+34],1600000
       jne       short M00_L34
       test      dword ptr [rbp+34],1600000
       jne       short M00_L34
       cmp       qword ptr [rbp+20],0
       jne       short M00_L33
       lea       rcx,[rbp+20]
       test      rcx,rcx
       je        near ptr M00_L48
       mov       rdx,rsi
       xor       r8d,r8d
       call      00007FF86CA021C0
       test      rax,rax
       jne       short M00_L33
M00_L31:
       add       rdi,8
       dec       ebx
       jne       short M00_L30
M00_L32:
       mov       rax,rsi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L33:
       mov       rcx,rbp
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF80D1B56C8]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       short M00_L31
M00_L34:
       mov       rcx,rsi
       mov       rdx,rbp
       call      qword ptr [7FF80D1CA990]; System.Threading.Tasks.Task+WhenAllPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
       jmp       short M00_L31
M00_L35:
       mov       rcx,offset MT_System.Threading.Tasks.TaskFactory<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       rcx,220F9801320
       xor       r8d,r8d
       call      00007FF86CA021C0
       test      rax,rax
       jne       near ptr M00_L02
       mov       rax,220F9801320
       mov       rax,[rax]
       jmp       near ptr M00_L02
M00_L36:
       mov       ecx,4
       call      qword ptr [7FF80D1BC2E8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L03
M00_L37:
       mov       ecx,8
       call      qword ptr [7FF80D1BC2E8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L12
M00_L38:
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M00_L15
       test      r15b,4
       je        near ptr M00_L15
       test      byte ptr [rcx+34],8
       jne       near ptr M00_L15
       call      qword ptr [7FF80D1B7E10]
       jmp       near ptr M00_L15
M00_L39:
       mov       rcx,r14
       call      qword ptr [7FF80D1B48A0]
       mov       edx,eax
       mov       rcx,220F9801350
       mov       rcx,[rcx]
       mov       r8,220A5299790
       xor       r9d,r9d
       call      qword ptr [7FF80D1B48B8]
       jmp       near ptr M00_L16
M00_L40:
       mov       rcx,r14
       call      qword ptr [7FF80D1B48D0]
       jmp       near ptr M00_L17
M00_L41:
       mov       rcx,r14
       mov       rdx,r13
       call      qword ptr [7FF80D1B55D8]
       jmp       near ptr M00_L18
M00_L42:
       mov       ecx,33
       call      qword ptr [7FF80CDBFD38]
       int       3
M00_L43:
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Int32[]>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rsi
       xor       edx,edx
       mov       r8,220A5298F30
       xor       r9d,r9d
       call      qword ptr [7FF80D1B4F18]
       jmp       near ptr M00_L32
M00_L44:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L25
M00_L45:
       mov       ecx,1D
       mov       edx,33
       call      qword ptr [7FF80D1B4F48]
       int       3
M00_L46:
       mov       rcx,rsi
       call      qword ptr [7FF80D1B48A0]
       mov       edx,eax
       mov       rcx,220F9801350
       mov       rcx,[rcx]
       mov       r8,220A5299E48
       xor       r9d,r9d
       call      qword ptr [7FF80D1B48B8]
       jmp       near ptr M00_L28
M00_L47:
       mov       rcx,rsi
       call      qword ptr [7FF80D1B48D0]
       jmp       near ptr M00_L29
M00_L48:
       call      qword ptr [7FF80D1B7DE0]
       int       3
; Total bytes of code 1808
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M01_L00
       ret
M01_L00:
       xor       edx,edx
       jmp       qword ptr [7FF80D1B4FD8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
; Total bytes of code 26
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
       je        near ptr M02_L18
       mov       rsi,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task<System.Int32>>
       mov       rcx,rsi
       call      qword ptr [7FF80D12FE70]; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].get_Factory()
       cmp       [rax],al
       mov       rcx,220F9801330
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
       jle       near ptr M02_L17
       mov       rcx,[rcx+240]
       mov       rax,[rcx+20]
       test      rax,rax
       je        near ptr M02_L17
M02_L00:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M02_L01
       call      qword ptr [7FF80D095458]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       rbx,[rax+8]
       test      rbx,rbx
       je        short M02_L02
       xor       ecx,ecx
       cmp       byte ptr [rbx+18],0
       cmovne    rbx,rcx
       jmp       short M02_L03
M02_L02:
       mov       rcx,220F9801340
       mov       rbx,[rcx]
M02_L03:
       test      rbx,rbx
       je        short M02_L05
       mov       rcx,220F9801340
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
       call      qword ptr [7FF80D1B4078]; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
       mov       rcx,offset MT_System.Threading.Tasks.UnwrapPromise<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       movzx     edi,word ptr [rsi+34]
       and       edi,4
       test      edi,0FFFFFFBB
       jne       near ptr M02_L16
       test      dil,4
       je        short M02_L09
       mov       rcx,gs:[58]
       mov       rcx,[rcx+48]
       cmp       dword ptr [rcx+238],8
       jle       near ptr M02_L19
       mov       rcx,[rcx+240]
       mov       rax,[rcx+40]
       test      rax,rax
       je        near ptr M02_L19
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
       jne       near ptr M02_L16
       mov       ecx,edi
       or        ecx,400
       or        ecx,2000000
       mov       [rbx+34],ecx
       mov       rcx,[rbx+28]
       test      rcx,rcx
       jne       near ptr M02_L20
M02_L10:
       mov       byte ptr [rbx+3D],1
       mov       rcx,220F9801350
       mov       rcx,[rcx]
       cmp       byte ptr [rcx+9D],0
       jne       near ptr M02_L21
M02_L11:
       cmp       byte ptr [7FF80CCFB074],0
       jne       near ptr M02_L22
M02_L12:
       test      dword ptr [rsi+34],1600000
       jne       near ptr M02_L23
       test      dword ptr [rsi+34],1600000
       jne       short M02_L15
       cmp       qword ptr [rsi+20],0
       jne       short M02_L14
       lea       rcx,[rsi+20]
       test      rcx,rcx
       je        near ptr M02_L24
       mov       rdx,rbx
       xor       r8d,r8d
       call      00007FF86CA021C0
       test      rax,rax
       jne       short M02_L14
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
       mov       rcx,rsi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FF80D1B56C8]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       short M02_L13
M02_L15:
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF80D1AA680]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
       jmp       short M02_L13
M02_L16:
       mov       ecx,2D
       call      qword ptr [7FF80CDBF348]
       int       3
M02_L17:
       mov       ecx,4
       call      qword ptr [7FF80D1BC2E8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M02_L00
M02_L18:
       mov       ecx,2E
       call      qword ptr [7FF80CDBFD38]
       int       3
M02_L19:
       mov       ecx,8
       call      qword ptr [7FF80D1BC2E8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M02_L07
M02_L20:
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M02_L10
       test      dil,4
       je        near ptr M02_L10
       test      byte ptr [rcx+34],8
       jne       near ptr M02_L10
       call      qword ptr [7FF80D1B7E10]
       jmp       near ptr M02_L10
M02_L21:
       mov       rcx,rbx
       call      qword ptr [7FF80D1B48A0]
       mov       edx,eax
       mov       rcx,220F9801350
       mov       rcx,[rcx]
       mov       r8,220A5299790
       xor       r9d,r9d
       call      qword ptr [7FF80D1B48B8]
       jmp       near ptr M02_L11
M02_L22:
       mov       rcx,rbx
       call      qword ptr [7FF80D1B48D0]
       jmp       near ptr M02_L12
M02_L23:
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF80D1B4900]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].ProcessCompletedOuterTask(System.Threading.Tasks.Task)
       jmp       near ptr M02_L13
M02_L24:
       call      qword ptr [7FF80D1B7DE0]
       int       3
; Total bytes of code 852
```
```assembly
; AsyncLazyBenchmarks.ContendedFirstCallBenchmarks+<>c__DisplayClass10_0.<Nito>b__0()
       push      rbp
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+40]
       mov       rbx,[rcx+8]
       mov       rcx,[rbx+8]
       mov       [rbp-18],rcx
       xor       eax,eax
       mov       [rbp-0C],eax
       test      rcx,rcx
       je        short M03_L02
       call      00007FF86CA5E120
       test      eax,eax
       je        short M03_L03
M03_L00:
       mov       dword ptr [rbp-0C],1
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],0
       jne       short M03_L01
       mov       rbx,[rcx+18]
       jmp       short M03_L04
M03_L01:
       call      qword ptr [7FF80D095848]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rbx,rax
       jmp       short M03_L04
M03_L02:
       xor       ecx,ecx
       call      qword ptr [7FF80D1BC1E0]
       int       3
M03_L03:
       mov       rcx,[rbp-18]
       call      qword ptr [7FF80D1B5470]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M03_L00
M03_L04:
       mov       rcx,[rbp-18]
       call      00007FF86CA5E040
       test      eax,eax
       jne       short M03_L06
M03_L05:
       mov       rax,rbx
       add       rsp,38
       pop       rbx
       pop       rbp
       ret
M03_L06:
       mov       ecx,eax
       mov       rdx,[rbp-18]
       call      qword ptr [7FF80D1B54D0]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       short M03_L05
       sub       rsp,28
       cmp       dword ptr [rbp-0C],0
       je        short M03_L08
       cmp       qword ptr [rbp-18],0
       jne       short M03_L07
       xor       ecx,ecx
       call      qword ptr [7FF80D1BC1E0]
       int       3
M03_L07:
       mov       rcx,[rbp-18]
       call      00007FF86CA5E040
       test      eax,eax
       je        short M03_L08
       mov       ecx,eax
       mov       rdx,[rbp-18]
       call      qword ptr [7FF80D1B54D0]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M03_L08:
       nop
       add       rsp,28
       ret
; Total bytes of code 192
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
; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       [rbp+10],rcx
       test      dl,dl
       jne       near ptr M05_L19
       or        dword ptr [rcx+34],10000
M05_L00:
       cmp       byte ptr [7FF80CCFB074],0
       jne       near ptr M05_L20
M05_L01:
       mov       rax,220F9801350
       mov       rbx,[rax]
       cmp       byte ptr [rbx+9D],0
       jne       near ptr M05_L21
M05_L02:
       mov       rsi,[rcx+18]
       cmp       [rsi],sil
       cmp       byte ptr [rbx+9D],0
       jne       near ptr M05_L11
M05_L03:
       mov       rdx,offset MT_System.Threading.Tasks.ThreadPoolTaskScheduler
       cmp       [rsi],rdx
       jne       near ptr M05_L17
       movzx     esi,word ptr [rcx+34]
       test      sil,2
       jne       near ptr M05_L12
       mov       rdx,220F9801358
       mov       rbx,[rdx]
       cmp       byte ptr [rbx+38],0
       jne       near ptr M05_L13
M05_L04:
       test      sil,1
       jne       short M05_L06
       mov       rax,gs:[58]
       mov       rax,[rax+48]
       cmp       dword ptr [rax+238],5
       jle       near ptr M05_L14
       mov       rax,[rax+240]
       mov       rax,[rax+28]
       test      rax,rax
       je        near ptr M05_L14
M05_L05:
       mov       rdx,[rax+10]
       test      rdx,rdx
       jne       short M05_L08
M05_L06:
       mov       rdx,[rbx+8]
       mov       r8,[rdx+10]
       mov       r10,[r8+8]
M05_L07:
       mov       esi,[r8+0A0]
       mov       eax,esi
       and       eax,[r8+18]
       cmp       eax,[r10+8]
       jae       near ptr M05_L15
       shl       rax,4
       lea       rdi,[r10+rax+10]
       mov       eax,[rdi+8]
       sub       eax,esi
       jne       short M05_L09
       lea       r9,[r8+0A0]
       lea       r11d,[rsi+1]
       mov       eax,esi
       lock cmpxchg [r9],r11d
       cmp       eax,esi
       jne       short M05_L07
       mov       rdx,[rbp+10]
       mov       rcx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       inc       esi
       mov       [rdi+8],esi
       jmp       short M05_L10
M05_L08:
       mov       rcx,[rdx+18]
       mov       rdx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF80D1B54A0]; System.Threading.ThreadPoolWorkQueue+WorkStealingQueue.LocalPush(System.Object)
       jmp       short M05_L10
M05_L09:
       test      eax,eax
       jge       short M05_L07
       mov       rcx,rdx
       mov       rdx,[rbp+10]
       call      qword ptr [7FF80D1BC6A8]
M05_L10:
       add       rbx,78
       mov       ecx,1
       xchg      ecx,[rbx]
       test      ecx,ecx
       jne       near ptr M05_L18
       mov       rcx,220F9801380
       mov       rbx,[rcx]
       lea       rcx,[rbx+178]
       lock inc  dword ptr [rcx]
       mov       rcx,rbx
       call      qword ptr [7FF80D1B4558]; System.Threading.PortableThreadPool+WorkerThread.MaybeAddWorkingWorker(System.Threading.PortableThreadPool)
       cmp       dword ptr [rbx+17C],6
       je        near ptr M05_L18
       jmp       near ptr M05_L16
M05_L11:
       mov       rdx,rsi
       call      qword ptr [7FF80D1BC5A0]
       mov       rcx,[rbp+10]
       jmp       near ptr M05_L03
M05_L12:
       mov       rcx,offset MT_System.Threading.Tasks.ThreadPoolTaskScheduler
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,220F9801428
       mov       rbx,[rcx]
       mov       rcx,offset MT_System.Threading.Thread
       call      CORINFO_HELP_NEWFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF80D1BD380]
       mov       rcx,rsi
       mov       edx,1
       call      qword ptr [7FF80D1B46C0]; System.Threading.Thread.set_IsBackground(Boolean)
       mov       rcx,rsi
       mov       rdx,220A5298C38
       call      qword ptr [7FF80D1B47B0]; System.Threading.Thread.set_Name(System.String)
       mov       rcx,rsi
       mov       rdx,[rbp+10]
       xor       r8d,r8d
       call      qword ptr [7FF80D1BD398]
       jmp       short M05_L18
M05_L13:
       mov       rdx,220F9801370
       mov       rdx,[rdx]
       cmp       byte ptr [rdx+9D],0
       je        near ptr M05_L04
       mov       rdx,220F9801370
       mov       rcx,[rdx]
       mov       rdx,[rbp+10]
       call      qword ptr [7FF80D1BC690]
       jmp       near ptr M05_L04
M05_L14:
       mov       ecx,5
       call      qword ptr [7FF80D1BC2E8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M05_L05
M05_L15:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M05_L16:
       mov       rcx,rbx
       call      qword ptr [7FF80D1B4738]; System.Threading.PortableThreadPool+GateThread.EnsureRunningSlow(System.Threading.PortableThreadPool)
       jmp       short M05_L18
M05_L17:
       mov       rcx,rsi
       mov       rdx,[rbp+10]
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       nop
M05_L18:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M05_L19:
       call      qword ptr [7FF80D1BD368]
       test      eax,eax
       mov       rcx,[rbp+10]
       jne       near ptr M05_L00
       jmp       short M05_L18
M05_L20:
       call      qword ptr [7FF80D1B48D0]
       mov       rcx,[rbp+10]
       jmp       near ptr M05_L01
M05_L21:
       test      word ptr [rcx+34],200
       jne       near ptr M05_L02
       call      qword ptr [7FF80D1B48A0]
       mov       esi,eax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       call      qword ptr [7FF80D1BC510]
       mov       rdx,rax
       mov       rcx,220A5298BB0
       call      qword ptr [7FF80CDBD9C8]; System.String.Concat(System.String, System.String)
       mov       r8,rax
       mov       edx,esi
       mov       rcx,rbx
       xor       r9d,r9d
       call      qword ptr [7FF80D1B48B8]
       mov       rcx,[rbp+10]
       jmp       near ptr M05_L02
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_System.Threading.Tasks.TaskSchedulerException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF80D1BC528]
       mov       rcx,[rbp+10]
       mov       rdx,rsi
       call      qword ptr [7FF80D1BC540]
       mov       rcx,[rbp+10]
       xor       edx,edx
       call      qword ptr [7FF80D1BC558]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80D1BC570]
       test      eax,200
       jne       short M05_L22
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+28]
       mov       rcx,[rcx+18]
       xor       edx,edx
       cmp       [rcx],ecx
       call      qword ptr [7FF80D1BC588]
M05_L22:
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 869
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M06_L02
       lea       rax,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       mov       rdx,[rcx+30]
       test      r8,r8
       je        short M06_L01
       cmp       rdx,[r8]
       je        short M06_L00
       mov       r10,offset MT_System.Object[]
       cmp       rcx,r10
       je        short M06_L00
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FF80D094EB8]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
M06_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FF86CA540D0
M06_L01:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M06_L02:
       call      qword ptr [7FF80D1B7DB0]
       int       3
; Total bytes of code 94
```
```assembly
; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       r14,[rbx+20]
       mov       rdx,220F9800218
       cmp       r14,[rdx]
       je        near ptr M07_L05
       mov       r15,r14
       test      r15,r15
       je        short M07_L00
       mov       rdx,offset MT_System.Threading.Tasks.UnwrapPromise<System.Int32>
       cmp       [r15],rdx
       jne       near ptr M07_L06
       xor       r15d,r15d
M07_L00:
       test      r15,r15
       jne       near ptr M07_L10
       mov       rcx,offset MT_System.Collections.Generic.List<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,220F9800A60
       mov       rdx,[rcx]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      dil,dil
       jne       near ptr M07_L07
       inc       dword ptr [r15+14]
       mov       rcx,r15
       mov       rdx,r14
       call      qword ptr [7FF80CDB71C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M07_L03
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       edx,edx
       mov       r8,rsi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M07_L01:
       lea       rcx,[rbx+20]
       test      rcx,rcx
       je        near ptr M07_L09
       mov       rdx,r15
       mov       r8,r14
       call      00007FF86CA021C0
       mov       r15,rax
       cmp       r15,r14
       jne       short M07_L04
M07_L02:
       mov       eax,1
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M07_L03:
       mov       rcx,r15
       mov       rdx,rsi
       call      qword ptr [7FF80CDB71C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M07_L01
M07_L04:
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.List<System.Object>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       jne       short M07_L10
M07_L05:
       xor       eax,eax
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M07_L06:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.List<System.Object>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r15,rax
       jmp       near ptr M07_L00
M07_L07:
       inc       dword ptr [r15+14]
       mov       rcx,r15
       mov       rdx,rsi
       call      qword ptr [7FF80CDB71C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M07_L08
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       edx,edx
       mov       r8,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M07_L01
M07_L08:
       mov       rcx,r15
       mov       rdx,r14
       call      qword ptr [7FF80CDB71C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M07_L01
M07_L09:
       call      qword ptr [7FF80D1B7DE0]
       int       3
M07_L10:
       mov       [rbp-40],r15
       xor       edx,edx
       mov       [rbp-30],edx
       lea       rdx,[rbp-30]
       mov       rcx,r15
       call      qword ptr [7FF80CDB5998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rbx+20]
       mov       rax,220F9800218
       cmp       rcx,[rax]
       jne       short M07_L11
       xor       ecx,ecx
       mov       [rbp-34],ecx
       jmp       near ptr M07_L17
M07_L11:
       mov       ecx,[r15+10]
       mov       rax,[r15+8]
       cmp       ecx,[rax+8]
       jne       short M07_L13
       mov       rcx,220F9800270
       mov       rdx,[rcx]
       test      rdx,rdx
       jne       short M07_L12
       mov       rcx,offset MT_System.Predicate<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,220F9800240
       mov       rdx,[rdx]
       mov       rcx,rbx
       mov       r8,7FF80D1B8ED0
       call      qword ptr [7FF80CDB6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,220F9800270
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rbx
M07_L12:
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FF80D1BCEE8]
M07_L13:
       test      dil,dil
       je        short M07_L14
       mov       rcx,r15
       mov       r8,rsi
       xor       edx,edx
       call      qword ptr [7FF80CEA35F0]
       jmp       short M07_L18
M07_L14:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M07_L15
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rsi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M07_L18
M07_L15:
       mov       rcx,r15
       mov       rdx,rsi
       call      qword ptr [7FF80CDB71C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M07_L18
M07_L16:
       mov       rcx,r15
       call      qword ptr [7FF80CDB6820]; System.Threading.Monitor.Exit(System.Object)
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
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M07_L20:
       sub       rsp,28
       cmp       byte ptr [rbp-30],0
       je        short M07_L21
       mov       rcx,[rbp-40]
       call      qword ptr [7FF80CDB6820]; System.Threading.Monitor.Exit(System.Object)
M07_L21:
       nop
       add       rsp,28
       ret
; Total bytes of code 711
```
```assembly
; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].ProcessCompletedOuterTask(System.Threading.Tasks.Task)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       byte ptr [rbx+3C],1
       mov       edx,[rsi+34]
       test      edx,200000
       jne       near ptr M08_L08
       test      edx,400000
       jne       near ptr M08_L09
       test      edx,1000000
       je        near ptr M08_L10
       mov       edi,5
M08_L00:
       cmp       edi,5
       jne       near ptr M08_L13
       mov       rcx,rsi
       mov       rax,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task<System.Int32>>
       cmp       [rcx],rax
       jne       near ptr M08_L14
M08_L01:
       test      rcx,rcx
       je        near ptr M08_L15
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       near ptr M08_L17
       mov       rdi,[rcx+38]
M08_L02:
       test      rdi,rdi
       je        near ptr M08_L18
       test      dword ptr [rdi+34],1600000
       jne       short M08_L06
       test      dword ptr [rdi+34],1600000
       jne       short M08_L05
       cmp       qword ptr [rdi+20],0
       jne       short M08_L04
       lea       rcx,[rdi+20]
       test      rcx,rcx
       je        near ptr M08_L19
       mov       rdx,rbx
       xor       r8d,r8d
       call      00007FF86CA021C0
       test      rax,rax
       jne       short M08_L04
M08_L03:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M08_L04:
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FF80D1B56C8]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       short M08_L03
M08_L05:
       mov       rcx,rbx
       mov       rdx,rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF80D1AA680]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
M08_L06:
       mov       rcx,rbx
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FF80D1B55F0]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
M08_L07:
       mov       byte ptr [rbx+3C],2
       jmp       short M08_L03
M08_L08:
       mov       edi,7
       jmp       near ptr M08_L00
M08_L09:
       mov       edi,6
       jmp       near ptr M08_L00
M08_L10:
       test      edx,800000
       je        short M08_L11
       mov       edi,4
       jmp       near ptr M08_L00
M08_L11:
       test      edx,20000
       je        short M08_L12
       mov       edi,3
       jmp       near ptr M08_L00
M08_L12:
       test      edx,2000000
       setne     dil
       movzx     edi,dil
       mov       ecx,2
       test      edx,10000
       cmovne    edi,ecx
       jmp       near ptr M08_L00
M08_L13:
       add       edi,0FFFFFFFA
       cmp       edi,1
       ja        near ptr M08_L03
       movzx     r8d,byte ptr [rbx+3D]
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF80D1B55F0]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       jmp       near ptr M08_L03
M08_L14:
       mov       rdx,rsi
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rcx,rax
       jmp       near ptr M08_L01
M08_L15:
       mov       rcx,rsi
       mov       rax,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task>
       cmp       [rcx],rax
       je        short M08_L16
       mov       rdx,rsi
       mov       rcx,rax
       call      qword ptr [7FF80CF94D20]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rcx,rax
M08_L16:
       cmp       [rcx],ecx
       call      qword ptr [7FF80D1B5650]; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].get_Result()
       mov       rdi,rax
       jmp       near ptr M08_L02
M08_L17:
       mov       edx,1
       call      qword ptr [7FF80D1BC8D0]
       mov       rdi,rax
       jmp       near ptr M08_L02
M08_L18:
       mov       rcx,rbx
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FF80D1B5908]
       jmp       near ptr M08_L07
M08_L19:
       call      qword ptr [7FF80D1B7DE0]
       int       3
; Total bytes of code 492
```
```assembly
; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
M09_L00:
       mov       rcx,220F9801350
       mov       rbp,[rcx]
       cmp       byte ptr [rbp+9D],0
       jne       near ptr M09_L12
M09_L01:
       xor       eax,eax
       mov       ecx,[rsi+34]
       test      ecx,200000
       jne       near ptr M09_L13
       test      ecx,400000
       jne       near ptr M09_L14
       test      ecx,1000000
       je        near ptr M09_L15
       mov       edx,5
M09_L02:
       add       edx,0FFFFFFFB
       jne       near ptr M09_L18
       cmp       byte ptr [rbp+9D],0
       jne       near ptr M09_L20
M09_L03:
       cmp       byte ptr [7FF80CCFB074],0
       jne       near ptr M09_L21
M09_L04:
       mov       rcx,rsi
       mov       rdx,offset MT_System.Threading.Tasks.UnwrapPromise<System.Int32>
       cmp       [rcx],rdx
       je        short M09_L05
       mov       rdx,rsi
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rcx,rax
M09_L05:
       test      rcx,rcx
       je        near ptr M09_L22
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       near ptr M09_L23
       mov       esi,[rcx+38]
M09_L06:
       xor       edi,edi
       mov       eax,[rbx+34]
       mov       [rsp+24],eax
       test      eax,5600000
       jne       short M09_L10
       lea       rcx,[rbx+34]
       mov       edx,eax
       or        edx,4000000
       lock cmpxchg [rcx],edx
       cmp       eax,[rsp+24]
       jne       near ptr M09_L24
M09_L07:
       mov       [rbx+38],esi
       lea       rcx,[rbx+34]
       mov       eax,[rbx+34]
       or        eax,1000000
       xchg      eax,[rcx]
       mov       rdi,[rbx+28]
       test      rdi,rdi
       jne       near ptr M09_L25
M09_L08:
       lea       rcx,[rbx+20]
       test      rcx,rcx
       je        near ptr M09_L26
       mov       rdx,220F9800218
       mov       rdx,[rdx]
       call      00007FF86CA0C330
       test      rax,rax
       je        short M09_L09
       mov       rcx,rbx
       mov       rdx,rax
       call      qword ptr [7FF80D1B5560]; System.Threading.Tasks.Task.RunContinuations(System.Object)
M09_L09:
       mov       edi,1
M09_L10:
       mov       eax,edi
M09_L11:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M09_L12:
       mov       rcx,rbx
       call      qword ptr [7FF80D1B48A0]
       mov       edx,eax
       mov       rcx,rbp
       mov       r8d,1
       call      qword ptr [7FF80D1B58C0]
       jmp       near ptr M09_L01
M09_L13:
       mov       edx,7
       jmp       near ptr M09_L02
M09_L14:
       mov       edx,6
       jmp       near ptr M09_L02
M09_L15:
       test      ecx,800000
       je        short M09_L16
       mov       edx,4
       jmp       near ptr M09_L02
M09_L16:
       test      ecx,20000
       je        short M09_L17
       mov       edx,3
       jmp       near ptr M09_L02
M09_L17:
       test      ecx,2000000
       setne     dl
       movzx     edx,dl
       mov       r8d,2
       test      ecx,10000
       cmovne    edx,r8d
       jmp       near ptr M09_L02
M09_L18:
       cmp       edx,2
       ja        near ptr M09_L11
       mov       ecx,edx
       lea       rax,[7FF80CE3CE80]
       mov       eax,[rax+rcx*4]
       lea       rdx,[M09_L00]
       add       rax,rdx
       jmp       rax
       mov       rcx,rsi
       call      qword ptr [7FF80D1B58D8]
       mov       rdi,rax
       mov       rcx,rsi
       call      qword ptr [7FF80D1B58F0]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF80D1B5908]
       jmp       near ptr M09_L11
       mov       rcx,rsi
       call      qword ptr [7FF80D1B5920]
       mov       rsi,rax
       test      dil,dil
       je        short M09_L19
       cmp       dword ptr [rsi+10],0
       jle       short M09_L19
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF80CEA3578]
       mov       rbp,rax
       test      rbp,rbp
       je        short M09_L19
       mov       rdx,[rbp+8]
       mov       rcx,offset MT_System.OperationCanceledException
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M09_L19
       mov       rdx,[rax+70]
       mov       rcx,rbx
       mov       r8,rbp
       call      qword ptr [7FF80D1B5908]
       jmp       near ptr M09_L11
M09_L19:
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF80D1B5998]
       jmp       near ptr M09_L11
M09_L20:
       mov       rcx,rbx
       call      qword ptr [7FF80D1B48A0]
       mov       edx,eax
       mov       rcx,rbp
       mov       r8d,1
       call      qword ptr [7FF80D1B59B0]
       jmp       near ptr M09_L03
M09_L21:
       mov       rcx,rbx
       call      qword ptr [7FF80D1B59C8]
       jmp       near ptr M09_L04
M09_L22:
       xor       esi,esi
       jmp       near ptr M09_L06
M09_L23:
       mov       edx,1
       call      qword ptr [7FF80D1B5B00]; System.Threading.Tasks.Task`1[[System.Int32, System.Private.CoreLib]].GetResultCore(Boolean)
       mov       esi,eax
       jmp       near ptr M09_L06
M09_L24:
       mov       rcx,rbx
       mov       edx,4000000
       mov       r8d,5600000
       call      qword ptr [7FF80D1BC4E0]
       test      eax,eax
       je        near ptr M09_L10
       jmp       near ptr M09_L07
M09_L25:
       mov       rcx,rbx
       call      qword ptr [7FF80D1BC978]
       mov       rcx,rdi
       call      qword ptr [7FF80D1BC990]
       jmp       near ptr M09_L08
M09_L26:
       call      qword ptr [7FF80D1B7DE0]
       int       3
; Total bytes of code 763
```
```assembly
; System.Threading.Tasks.Task+WhenAllPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rbx,rcx
       mov       rcx,220F9801350
       mov       rsi,[rcx]
       cmp       byte ptr [rsi+9D],0
       jne       near ptr M10_L16
M10_L00:
       lea       rdx,[rbx+48]
       mov       ecx,0FFFFFFFF
       lock xadd [rdx],ecx
       dec       ecx
       jne       near ptr M10_L15
       mov       rdx,[rbx+40]
       mov       edx,[rdx+8]
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       xor       ebp,ebp
       xor       r14d,r14d
       xor       r15d,r15d
M10_L01:
       mov       rcx,[rbx+40]
       cmp       [rcx+8],r15d
       jle       near ptr M10_L10
       cmp       r15d,[rcx+8]
       jae       near ptr M10_L29
       mov       r13d,r15d
       mov       r12,[rcx+r13*8+10]
       test      dword ptr [r12+34],200000
       jne       short M10_L06
       mov       ecx,[r12+34]
       and       ecx,600000
       cmp       ecx,400000
       je        near ptr M10_L18
       test      dword ptr [r12+34],1600000
       je        near ptr M10_L19
M10_L02:
       mov       ecx,[r12+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       near ptr M10_L20
M10_L03:
       mov       ecx,[r12+38]
       cmp       r15d,[rdi+8]
       jae       near ptr M10_L29
       mov       [rdi+r13*4+10],ecx
M10_L04:
       test      dword ptr [r12+34],10000000
       jne       short M10_L09
       mov       rax,[rbx+40]
       cmp       r15d,[rax+8]
       jae       near ptr M10_L29
       xor       ecx,ecx
       mov       [rax+r13*8+10],rcx
M10_L05:
       inc       r15d
       jmp       near ptr M10_L01
M10_L06:
       test      rbp,rbp
       je        near ptr M10_L17
M10_L07:
       mov       rcx,[r12+28]
       mov       rax,[rcx+18]
       mov       [rsp+28],rax
       mov       rdx,[rax+10]
       mov       [rsp+20],rdx
       cmp       byte ptr [rax+20],0
       jne       short M10_L08
       mov       rcx,rax
       call      qword ptr [7FF80D0955F0]; System.GC.SuppressFinalize(System.Object)
       mov       rcx,[rsp+28]
       mov       byte ptr [rcx+20],1
M10_L08:
       mov       rcx,rbp
       mov       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF80D1B5AD0]
       jmp       short M10_L04
M10_L09:
       mov       eax,[rbx+34]
       mov       [rsp+34],eax
       test      eax,5600000
       jne       short M10_L05
       lea       rcx,[rbx+34]
       mov       edx,eax
       or        edx,10000000
       lock cmpxchg [rcx],edx
       cmp       eax,[rsp+34]
       je        short M10_L05
       jmp       near ptr M10_L21
M10_L10:
       test      rbp,rbp
       jne       near ptr M10_L22
       test      r14,r14
       jne       near ptr M10_L23
       cmp       byte ptr [rsi+9D],0
       jne       near ptr M10_L24
M10_L11:
       cmp       byte ptr [7FF80CCFB074],0
       jne       near ptr M10_L25
M10_L12:
       mov       eax,[rbx+34]
       mov       [rsp+30],eax
       test      eax,5600000
       jne       short M10_L15
       lea       rcx,[rbx+34]
       mov       edx,eax
       or        edx,4000000
       lock cmpxchg [rcx],edx
       cmp       eax,[rsp+30]
       jne       near ptr M10_L26
M10_L13:
       lea       rcx,[rbx+38]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+34]
       mov       eax,[rbx+34]
       or        eax,1000000
       xchg      eax,[rcx]
       mov       r14,[rbx+28]
       test      r14,r14
       jne       near ptr M10_L27
M10_L14:
       lea       rcx,[rbx+20]
       test      rcx,rcx
       je        near ptr M10_L28
       mov       rdx,220F9800218
       mov       rdx,[rdx]
       call      00007FF86CA0C330
       test      rax,rax
       je        short M10_L15
       mov       rcx,rbx
       mov       rdx,rax
       call      qword ptr [7FF80D1B5560]; System.Threading.Tasks.Task.RunContinuations(System.Object)
M10_L15:
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M10_L16:
       mov       rcx,rbx
       call      qword ptr [7FF80D1B48A0]
       mov       edx,eax
       mov       rcx,rsi
       mov       r8d,1
       call      qword ptr [7FF80D1B58C0]
       jmp       near ptr M10_L00
M10_L17:
       mov       rcx,offset MT_System.Collections.Generic.List<System.Runtime.ExceptionServices.ExceptionDispatchInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FF80D09C4C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       jmp       near ptr M10_L07
M10_L18:
       test      r14,r14
       jne       near ptr M10_L04
       mov       r14,r12
       jmp       near ptr M10_L04
M10_L19:
       mov       rcx,r12
       mov       edx,0FFFFFFFF
       xor       r8d,r8d
       call      qword ptr [7FF80D1B4FF0]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
       jmp       near ptr M10_L02
M10_L20:
       mov       rcx,r12
       mov       edx,1
       call      qword ptr [7FF80D1BD428]
       jmp       near ptr M10_L03
M10_L21:
       mov       rcx,rbx
       mov       edx,10000000
       mov       r8d,5600000
       call      qword ptr [7FF80D1BC4E0]
       jmp       near ptr M10_L05
M10_L22:
       mov       rcx,rbx
       mov       rdx,rbp
       call      qword ptr [7FF80D1B5998]
       jmp       near ptr M10_L15
M10_L23:
       mov       rcx,r14
       call      qword ptr [7FF80D1B58D8]
       mov       rbp,rax
       mov       rcx,r14
       call      qword ptr [7FF80D1B58F0]
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      qword ptr [7FF80D1B5908]
       jmp       near ptr M10_L15
M10_L24:
       mov       rcx,rbx
       call      qword ptr [7FF80D1B48A0]
       mov       edx,eax
       mov       rcx,rsi
       mov       r8d,1
       call      qword ptr [7FF80D1B59B0]
       jmp       near ptr M10_L11
M10_L25:
       mov       rcx,rbx
       call      qword ptr [7FF80D1B59C8]
       jmp       near ptr M10_L12
M10_L26:
       mov       rcx,rbx
       mov       edx,4000000
       mov       r8d,5600000
       call      qword ptr [7FF80D1BC4E0]
       test      eax,eax
       je        near ptr M10_L15
       jmp       near ptr M10_L13
M10_L27:
       mov       rcx,rbx
       call      qword ptr [7FF80D1BC978]
       mov       rcx,r14
       call      qword ptr [7FF80D1BC990]
       jmp       near ptr M10_L14
M10_L28:
       call      qword ptr [7FF80D1B7DE0]
       int       3
M10_L29:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 885
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
       jne       short M11_L01
       cmp       [rax],ecx
       jle       short M11_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M11_L03
M11_L00:
       add       rsp,20
       pop       rbx
       ret
M11_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M11_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M11_L00
M11_L02:
       cmp       [rax+4],edx
       jle       short M11_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M11_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M11_L03
       jmp       short M11_L00
M11_L03:
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
       jne       short M12_L00
       mov       rcx,rbx
       mov       edx,0FFFFFFFF
       xor       r8d,r8d
       call      qword ptr [7FF80D1B4FF0]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M12_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M12_L03
M12_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M12_L04
M12_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M12_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M12_L01
       mov       rcx,rbx
       call      qword ptr [7FF80D1BCCD8]
       jmp       short M12_L01
M12_L04:
       test      sil,2
       jne       short M12_L05
       mov       rcx,rbx
       call      qword ptr [7FF80D1BCCF0]
M12_L05:
       mov       rcx,rbx
       call      qword ptr [7FF80D1BD4D0]
       jmp       short M12_L02
; Total bytes of code 124
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.ContendedFirstCallBenchmarks.VsThreading()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rbx,rcx
       mov       rcx,offset MT_AsyncLazyBenchmarks.ContendedFirstCallBenchmarks+<>c__DisplayClass11_0
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_Microsoft.VisualStudio.Threading.AsyncLazy<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,16CD0001300
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+10],rcx
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       edi,edi
M00_L00:
       mov       rbp,[rbx+8]
       cmp       [rbp+8],edi
       jle       near ptr M00_L19
       mov       r14,[rsi+10]
       test      r14,r14
       jne       short M00_L01
       mov       rcx,offset MT_System.Func<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset AsyncLazyBenchmarks.ContendedFirstCallBenchmarks+<>c__DisplayClass11_0.<VsThreading>b__0()
       mov       [r14+18],rcx
       lea       rcx,[rsi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       mov       rcx,16CD0001330
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M00_L30
M00_L02:
       cmp       [rax],al
       mov       rcx,16CD0001340
       mov       r15,[rcx]
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rcx,[r13+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r13+10],rcx
       lea       rcx,[r13+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,2008
       mov       [r13+34],ecx
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M00_L31
       mov       rcx,[rcx+240]
       mov       rax,[rcx+20]
       test      rax,rax
       je        near ptr M00_L31
M00_L03:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M00_L04
       call      qword ptr [7FF80D095458]; System.Threading.Thread.InitializeCurrentThread()
M00_L04:
       mov       r14,[rax+8]
       test      r14,r14
       je        short M00_L08
       cmp       byte ptr [r14+18],0
       jne       near ptr M00_L32
M00_L05:
       test      r14,r14
       jne       short M00_L09
       or        dword ptr [r13+34],20000000
M00_L06:
       mov       rcx,r13
       xor       edx,edx
       call      qword ptr [7FF80D1D4180]; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
       mov       rcx,offset MT_System.Threading.Tasks.UnwrapPromise<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       movzx     r15d,word ptr [r13+34]
       and       r15d,4
       test      r15d,0FFFFFFBB
       je        short M00_L11
M00_L07:
       mov       ecx,2D
       call      qword ptr [7FF80CDBF348]
       int       3
M00_L08:
       mov       rcx,16CD0001350
       mov       r14,[rcx]
       jmp       short M00_L05
M00_L09:
       mov       rcx,16CD0001350
       cmp       r14,[rcx]
       je        short M00_L06
       mov       rax,[r13+28]
       test      rax,rax
       jne       short M00_L10
       mov       rcx,offset MT_System.Threading.Tasks.Task+ContingentProperties
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       dword ptr [r15+3C],1
       lea       rcx,[r13+28]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,r15
M00_L10:
       lea       rcx,[rax+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L06
M00_L11:
       test      r15b,4
       je        short M00_L14
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],8
       jle       near ptr M00_L33
       mov       rcx,[rcx+240]
       mov       rax,[rcx+40]
       test      rax,rax
       je        near ptr M00_L33
M00_L12:
       mov       r12,[rax+10]
       test      r12,r12
       je        short M00_L14
       mov       rax,[r14+28]
       test      rax,rax
       jne       short M00_L13
       mov       rcx,offset MT_System.Threading.Tasks.Task+ContingentProperties
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+30],rax
       mov       dword ptr [rax+3C],1
       lea       rcx,[r14+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+30]
M00_L13:
       lea       rcx,[rax+30]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
M00_L14:
       xor       ecx,ecx
       mov       [r14+8],rcx
       mov       [r14+10],rcx
       mov       [r14+18],rcx
       test      r15d,0FFFFFFA0
       jne       near ptr M00_L07
       mov       ecx,r15d
       or        ecx,400
       or        ecx,2000000
       mov       [r14+34],ecx
       mov       rcx,[r14+28]
       test      rcx,rcx
       jne       near ptr M00_L34
M00_L15:
       mov       byte ptr [r14+3D],1
       mov       rcx,16CD0001360
       mov       rcx,[rcx]
       cmp       byte ptr [rcx+9D],0
       jne       near ptr M00_L35
M00_L16:
       cmp       byte ptr [7FF80CCFB074],0
       jne       near ptr M00_L36
M00_L17:
       test      dword ptr [r13+34],1600000
       jne       near ptr M00_L37
       test      dword ptr [r13+34],1600000
       jne       near ptr M00_L39
       cmp       qword ptr [r13+20],0
       jne       near ptr M00_L38
       lea       rcx,[r13+20]
       test      rcx,rcx
       je        near ptr M00_L47
       mov       rdx,r14
       xor       r8d,r8d
       call      00007FF86CA021C0
       test      rax,rax
       jne       near ptr M00_L38
M00_L18:
       movsxd    rdx,edi
       mov       rcx,rbp
       mov       r8,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       edi
       jmp       near ptr M00_L00
M00_L19:
       mov       rdx,rbp
       test      rdx,rdx
       je        near ptr M00_L40
       lea       rbx,[rdx+10]
       mov       esi,[rdx+8]
       test      esi,esi
       je        near ptr M00_L41
       mov       edx,esi
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Int32>[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       r8d,esi
       shl       r8,3
       cmp       r8,4000
       jbe       short M00_L20
       mov       rdx,rbx
       call      qword ptr [7FF80D1DEB08]
       jmp       short M00_L21
M00_L20:
       mov       rdx,rbx
       call      00007FF86C9D37A0
       cmp       dword ptr [7FF86CD13A90],0
       jne       near ptr M00_L42
M00_L21:
       mov       ebx,[rdi+8]
       test      ebx,ebx
       jle       short M00_L23
       lea       rcx,[rdi+10]
       mov       edx,ebx
M00_L22:
       cmp       qword ptr [rcx],0
       je        near ptr M00_L43
       add       rcx,8
       dec       edx
       jne       short M00_L22
M00_L23:
       mov       rcx,offset MT_System.Threading.Tasks.Task+WhenAllPromise<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+34],2000400
       lea       rcx,[rsi+40]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsi+48],ebx
       mov       rcx,16CD0001360
       mov       rcx,[rcx]
       cmp       byte ptr [rcx+9D],0
       jne       near ptr M00_L44
M00_L24:
       cmp       byte ptr [7FF80CCFB074],0
       jne       near ptr M00_L45
M00_L25:
       test      ebx,ebx
       jle       short M00_L28
       add       rdi,10
M00_L26:
       mov       rbp,[rdi]
       test      dword ptr [rbp+34],1600000
       jne       short M00_L29
       test      dword ptr [rbp+34],1600000
       jne       short M00_L29
       cmp       qword ptr [rbp+20],0
       jne       near ptr M00_L46
       lea       rcx,[rbp+20]
       test      rcx,rcx
       je        near ptr M00_L47
       mov       rdx,rsi
       xor       r8d,r8d
       call      00007FF86CA021C0
       test      rax,rax
       jne       near ptr M00_L46
M00_L27:
       add       rdi,8
       dec       ebx
       jne       short M00_L26
M00_L28:
       mov       rax,rsi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L29:
       mov       rcx,rsi
       mov       rdx,rbp
       call      qword ptr [7FF80D1EB578]; System.Threading.Tasks.Task+WhenAllPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
       jmp       short M00_L27
M00_L30:
       mov       rcx,offset MT_System.Threading.Tasks.TaskFactory<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       rcx,16CD0001330
       xor       r8d,r8d
       call      00007FF86CA021C0
       test      rax,rax
       jne       near ptr M00_L02
       mov       rax,16CD0001330
       mov       rax,[rax]
       jmp       near ptr M00_L02
M00_L31:
       mov       ecx,4
       call      qword ptr [7FF80D1DE268]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L03
M00_L32:
       xor       r14d,r14d
       jmp       near ptr M00_L05
M00_L33:
       mov       ecx,8
       call      qword ptr [7FF80D1DE268]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L12
M00_L34:
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M00_L15
       test      r15b,4
       je        near ptr M00_L15
       test      byte ptr [rcx+34],8
       jne       near ptr M00_L15
       call      qword ptr [7FF80D1DE148]
       jmp       near ptr M00_L15
M00_L35:
       mov       rcx,r14
       call      qword ptr [7FF80D1D4990]
       mov       edx,eax
       mov       rcx,16CD0001360
       mov       rcx,[rcx]
       mov       r8,16CA5299790
       xor       r9d,r9d
       call      qword ptr [7FF80D1D49A8]
       jmp       near ptr M00_L16
M00_L36:
       mov       rcx,r14
       call      qword ptr [7FF80D1D49C0]
       jmp       near ptr M00_L17
M00_L37:
       mov       rcx,r14
       mov       rdx,r13
       call      qword ptr [7FF80D1D49F0]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].ProcessCompletedOuterTask(System.Threading.Tasks.Task)
       jmp       near ptr M00_L18
M00_L38:
       mov       rcx,r13
       mov       rdx,r14
       xor       r8d,r8d
       call      qword ptr [7FF80D1DC270]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M00_L18
M00_L39:
       mov       rcx,r14
       mov       rdx,r13
       call      qword ptr [7FF80D1ABC30]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
       jmp       near ptr M00_L18
M00_L40:
       mov       ecx,33
       call      qword ptr [7FF80CDBFD38]
       int       3
M00_L41:
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Int32[]>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rsi
       xor       edx,edx
       mov       r8,16CA5298F30
       xor       r9d,r9d
       call      qword ptr [7FF80D1D5020]
       jmp       near ptr M00_L28
M00_L42:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L21
M00_L43:
       mov       ecx,1D
       mov       edx,33
       call      qword ptr [7FF80D1D5050]
       int       3
M00_L44:
       mov       rcx,rsi
       call      qword ptr [7FF80D1D4990]
       mov       edx,eax
       mov       rcx,16CD0001360
       mov       rcx,[rcx]
       mov       r8,16CA5299E48
       xor       r9d,r9d
       call      qword ptr [7FF80D1D49A8]
       jmp       near ptr M00_L24
M00_L45:
       mov       rcx,rsi
       call      qword ptr [7FF80D1D49C0]
       jmp       near ptr M00_L25
M00_L46:
       mov       rcx,rbp
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF80D1DC270]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M00_L27
       jmp       near ptr M00_L29
M00_L47:
       call      qword ptr [7FF80D1DDE78]
       int       3
; Total bytes of code 1651
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M01_L00
       ret
M01_L00:
       xor       edx,edx
       jmp       qword ptr [7FF80D1D50E0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
; Total bytes of code 26
```
```assembly
; AsyncLazyBenchmarks.ContendedFirstCallBenchmarks+<>c__DisplayClass11_0.<VsThreading>b__0()
       mov       rcx,[rcx+8]
       cmp       [rcx],cl
       xor       edx,edx
       jmp       qword ptr [7FF80D1D5530]; Microsoft.VisualStudio.Threading.AsyncLazy`1[[System.Int32, System.Private.CoreLib]].GetValueAsync(System.Threading.CancellationToken)
; Total bytes of code 14
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
; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       [rbp+10],rcx
       test      dl,dl
       jne       near ptr M04_L19
       or        dword ptr [rcx+34],10000
M04_L00:
       cmp       byte ptr [7FF80CCFB074],0
       jne       near ptr M04_L20
M04_L01:
       mov       rax,16CD0001360
       mov       rbx,[rax]
       cmp       byte ptr [rbx+9D],0
       jne       near ptr M04_L21
M04_L02:
       mov       rsi,[rcx+18]
       cmp       [rsi],sil
       cmp       byte ptr [rbx+9D],0
       jne       near ptr M04_L10
M04_L03:
       mov       rdx,offset MT_System.Threading.Tasks.ThreadPoolTaskScheduler
       cmp       [rsi],rdx
       jne       near ptr M04_L17
       movzx     esi,word ptr [rcx+34]
       test      sil,2
       jne       near ptr M04_L11
       mov       rdx,16CD0001368
       mov       rbx,[rdx]
       cmp       byte ptr [rbx+38],0
       jne       near ptr M04_L12
M04_L04:
       test      sil,1
       jne       short M04_L06
       mov       rax,gs:[58]
       mov       rax,[rax+40]
       cmp       dword ptr [rax+238],5
       jle       near ptr M04_L13
       mov       rax,[rax+240]
       mov       rax,[rax+28]
       test      rax,rax
       je        near ptr M04_L13
M04_L05:
       mov       rdx,[rax+10]
       test      rdx,rdx
       jne       near ptr M04_L14
M04_L06:
       mov       rdx,[rbx+8]
       mov       r8,[rdx+10]
       mov       r10,[r8+8]
M04_L07:
       mov       esi,[r8+0A0]
       mov       eax,esi
       and       eax,[r8+18]
       cmp       eax,[r10+8]
       jae       near ptr M04_L15
       shl       rax,4
       lea       rdi,[r10+rax+10]
       mov       eax,[rdi+8]
       sub       eax,esi
       je        short M04_L08
       test      eax,eax
       jge       short M04_L07
       mov       rcx,rdx
       mov       rdx,[rbp+10]
       call      qword ptr [7FF80D1DE790]
       jmp       short M04_L09
M04_L08:
       lea       r9,[r8+0A0]
       lea       r11d,[rsi+1]
       mov       eax,esi
       lock cmpxchg [r9],r11d
       cmp       eax,esi
       jne       short M04_L07
       mov       rdx,[rbp+10]
       mov       rcx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       inc       esi
       mov       [rdi+8],esi
M04_L09:
       add       rbx,78
       mov       ecx,1
       xchg      ecx,[rbx]
       test      ecx,ecx
       jne       near ptr M04_L18
       mov       rcx,16CD0001390
       mov       rbx,[rcx]
       lea       rcx,[rbx+178]
       lock inc  dword ptr [rcx]
       mov       rcx,rbx
       call      qword ptr [7FF80D1D4660]; System.Threading.PortableThreadPool+WorkerThread.MaybeAddWorkingWorker(System.Threading.PortableThreadPool)
       cmp       dword ptr [rbx+17C],6
       je        near ptr M04_L18
       jmp       near ptr M04_L16
M04_L10:
       mov       rdx,rsi
       call      qword ptr [7FF80D1DE658]
       mov       rcx,[rbp+10]
       jmp       near ptr M04_L03
M04_L11:
       mov       rcx,offset MT_System.Threading.Tasks.ThreadPoolTaskScheduler
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,16CD0001478
       mov       rbx,[rcx]
       mov       rcx,offset MT_System.Threading.Thread
       call      CORINFO_HELP_NEWFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF80D1DF030]
       mov       rcx,rsi
       mov       edx,1
       call      qword ptr [7FF80D1D47C8]; System.Threading.Thread.set_IsBackground(Boolean)
       mov       rcx,rsi
       mov       rdx,16CA5298C38
       call      qword ptr [7FF80D1D48D0]; System.Threading.Thread.set_Name(System.String)
       mov       rcx,rsi
       mov       rdx,[rbp+10]
       xor       r8d,r8d
       call      qword ptr [7FF80D1DF048]
       jmp       near ptr M04_L18
M04_L12:
       mov       rdx,16CD0001380
       mov       rdx,[rdx]
       cmp       byte ptr [rdx+9D],0
       je        near ptr M04_L04
       mov       rdx,16CD0001380
       mov       rcx,[rdx]
       mov       rdx,[rbp+10]
       call      qword ptr [7FF80D1DE760]
       jmp       near ptr M04_L04
M04_L13:
       mov       ecx,5
       call      qword ptr [7FF80D1DE268]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M04_L05
M04_L14:
       mov       rcx,[rdx+18]
       mov       rdx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF80D1DE778]
       jmp       near ptr M04_L09
M04_L15:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M04_L16:
       mov       rcx,rbx
       call      qword ptr [7FF80D1D4840]; System.Threading.PortableThreadPool+GateThread.EnsureRunningSlow(System.Threading.PortableThreadPool)
       jmp       short M04_L18
M04_L17:
       mov       rcx,rsi
       mov       rdx,[rbp+10]
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       nop
M04_L18:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M04_L19:
       call      qword ptr [7FF80D1DF018]
       test      eax,eax
       mov       rcx,[rbp+10]
       jne       near ptr M04_L00
       jmp       short M04_L18
M04_L20:
       call      qword ptr [7FF80D1D49C0]
       mov       rcx,[rbp+10]
       jmp       near ptr M04_L01
M04_L21:
       test      word ptr [rcx+34],200
       jne       near ptr M04_L02
       call      qword ptr [7FF80D1D4990]
       mov       esi,eax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       call      qword ptr [7FF80D1DE5C8]
       mov       rdx,rax
       mov       rcx,16CA5298BB0
       call      qword ptr [7FF80CDBD9C8]; System.String.Concat(System.String, System.String)
       mov       r8,rax
       mov       edx,esi
       mov       rcx,rbx
       xor       r9d,r9d
       call      qword ptr [7FF80D1D49A8]
       mov       rcx,[rbp+10]
       jmp       near ptr M04_L02
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_System.Threading.Tasks.TaskSchedulerException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF80D1DE5E0]
       mov       rcx,[rbp+10]
       mov       rdx,rsi
       call      qword ptr [7FF80D1DE5F8]
       mov       rcx,[rbp+10]
       xor       edx,edx
       call      qword ptr [7FF80D1DE610]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80D1DE628]
       test      eax,200
       jne       short M04_L22
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+28]
       mov       rcx,[rcx+18]
       xor       edx,edx
       cmp       [rcx],ecx
       call      qword ptr [7FF80D1DE640]
M04_L22:
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 879
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M05_L01
       lea       rax,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       mov       rdx,[rcx+30]
       test      r8,r8
       je        short M05_L00
       cmp       rdx,[r8]
       je        short M05_L02
       mov       r10,offset MT_System.Object[]
       cmp       rcx,r10
       je        short M05_L02
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FF80D094EB8]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
M05_L00:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M05_L01:
       call      qword ptr [7FF80D1DDE48]
       int       3
M05_L02:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FF86CA540D0
; Total bytes of code 94
```
```assembly
; System.Threading.Tasks.Task+WhenAllPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rbx,rcx
       mov       rcx,16CD0001360
       mov       rsi,[rcx]
       cmp       byte ptr [rsi+9D],0
       jne       near ptr M06_L12
M06_L00:
       lea       rdx,[rbx+48]
       mov       ecx,0FFFFFFFF
       lock xadd [rdx],ecx
       dec       ecx
       jne       near ptr M06_L11
       mov       rdx,[rbx+40]
       mov       edx,[rdx+8]
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       xor       ebp,ebp
       xor       r14d,r14d
       xor       r15d,r15d
       jmp       near ptr M06_L06
M06_L01:
       cmp       r15d,[rcx+8]
       jae       near ptr M06_L27
       mov       r13d,r15d
       mov       r12,[rcx+r13*8+10]
       test      dword ptr [r12+34],200000
       jne       near ptr M06_L13
       mov       ecx,[r12+34]
       and       ecx,600000
       cmp       ecx,400000
       je        near ptr M06_L16
       test      dword ptr [r12+34],1600000
       je        near ptr M06_L17
M06_L02:
       mov       ecx,[r12+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       near ptr M06_L18
M06_L03:
       mov       ecx,[r12+38]
       cmp       r15d,[rdi+8]
       jae       near ptr M06_L27
       mov       [rdi+r13*4+10],ecx
M06_L04:
       test      dword ptr [r12+34],10000000
       jne       near ptr M06_L19
       mov       rcx,[rbx+40]
       cmp       r15d,[rcx+8]
       jae       near ptr M06_L27
       xor       edx,edx
       mov       [rcx+r13*8+10],rdx
M06_L05:
       inc       r15d
M06_L06:
       mov       rcx,[rbx+40]
       cmp       [rcx+8],r15d
       jg        near ptr M06_L01
       test      rbp,rbp
       jne       near ptr M06_L20
       test      r14,r14
       jne       near ptr M06_L21
       cmp       byte ptr [rsi+9D],0
       jne       near ptr M06_L22
M06_L07:
       cmp       byte ptr [7FF80CCFB074],0
       jne       near ptr M06_L23
M06_L08:
       mov       eax,[rbx+34]
       mov       [rsp+34],eax
       test      eax,5600000
       jne       short M06_L11
       lea       rcx,[rbx+34]
       mov       edx,eax
       or        edx,4000000
       lock cmpxchg [rcx],edx
       cmp       eax,[rsp+34]
       jne       near ptr M06_L24
M06_L09:
       lea       rcx,[rbx+38]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+34]
       mov       eax,[rbx+34]
       or        eax,1000000
       xchg      eax,[rcx]
       mov       r14,[rbx+28]
       test      r14,r14
       jne       near ptr M06_L25
M06_L10:
       lea       rcx,[rbx+20]
       test      rcx,rcx
       je        near ptr M06_L26
       mov       rdx,16CD0000218
       mov       rdx,[rdx]
       call      00007FF86CA0C330
       test      rax,rax
       je        short M06_L11
       mov       rcx,rbx
       mov       rdx,rax
       call      qword ptr [7FF80D1D71C8]; System.Threading.Tasks.Task.RunContinuations(System.Object)
M06_L11:
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M06_L12:
       mov       rcx,rbx
       call      qword ptr [7FF80D1D4990]
       mov       edx,eax
       mov       rcx,rsi
       mov       r8d,1
       call      qword ptr [7FF80D1D7708]
       jmp       near ptr M06_L00
M06_L13:
       test      rbp,rbp
       jne       short M06_L14
       mov       rcx,offset MT_System.Collections.Generic.List<System.Runtime.ExceptionServices.ExceptionDispatchInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FF80D09C4C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
M06_L14:
       mov       rcx,[r12+28]
       mov       rax,[rcx+18]
       mov       [rsp+28],rax
       mov       rdx,[rax+10]
       mov       [rsp+20],rdx
       cmp       byte ptr [rax+20],0
       jne       short M06_L15
       mov       rcx,rax
       call      qword ptr [7FF80D0955F0]; System.GC.SuppressFinalize(System.Object)
       mov       rcx,[rsp+28]
       mov       byte ptr [rcx+20],1
M06_L15:
       mov       rcx,rbp
       mov       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF80D1D7870]
       jmp       near ptr M06_L04
M06_L16:
       test      r14,r14
       jne       near ptr M06_L04
       mov       r14,r12
       jmp       near ptr M06_L04
M06_L17:
       mov       rcx,r12
       mov       edx,0FFFFFFFF
       xor       r8d,r8d
       call      qword ptr [7FF80D1D50F8]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
       jmp       near ptr M06_L02
M06_L18:
       mov       rcx,r12
       mov       edx,1
       call      qword ptr [7FF80D1DF1F8]
       jmp       near ptr M06_L03
M06_L19:
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FF80D1D78D0]
       jmp       near ptr M06_L05
M06_L20:
       mov       rcx,rbx
       mov       rdx,rbp
       call      qword ptr [7FF80D1D6778]; System.Threading.Tasks.Task.TrySetException(System.Object)
       jmp       near ptr M06_L11
M06_L21:
       mov       rcx,r14
       call      qword ptr [7FF80D1D7720]
       mov       rbp,rax
       mov       rcx,r14
       call      qword ptr [7FF80D1D7738]
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      qword ptr [7FF80D1D7750]
       jmp       near ptr M06_L11
M06_L22:
       mov       rcx,rbx
       call      qword ptr [7FF80D1D4990]
       mov       edx,eax
       mov       rcx,rsi
       mov       r8d,1
       call      qword ptr [7FF80D1D77E0]
       jmp       near ptr M06_L07
M06_L23:
       mov       rcx,rbx
       call      qword ptr [7FF80D1D77F8]
       jmp       near ptr M06_L08
M06_L24:
       mov       rcx,rbx
       mov       edx,4000000
       mov       r8d,5600000
       call      qword ptr [7FF80D1DE280]
       test      eax,eax
       je        near ptr M06_L11
       jmp       near ptr M06_L09
M06_L25:
       mov       rcx,rbx
       call      qword ptr [7FF80D1D6880]; System.Threading.Tasks.Task.NotifyParentIfPotentiallyAttachedTask()
       mov       rcx,r14
       call      qword ptr [7FF80D1DE298]
       jmp       near ptr M06_L10
M06_L26:
       call      qword ptr [7FF80D1DDE78]
       int       3
M06_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 840
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
; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].ProcessCompletedOuterTask(System.Threading.Tasks.Task)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       byte ptr [rbx+3C],1
       mov       edx,[rsi+34]
       test      edx,200000
       jne       near ptr M08_L05
       test      edx,400000
       jne       near ptr M08_L07
       test      edx,1000000
       je        near ptr M08_L08
       mov       edi,5
M08_L00:
       cmp       edi,5
       jne       near ptr M08_L11
       mov       rcx,rsi
       mov       rax,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task<System.Int32>>
       cmp       [rcx],rax
       jne       near ptr M08_L12
M08_L01:
       test      rcx,rcx
       je        near ptr M08_L13
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       near ptr M08_L15
       mov       rdi,[rcx+38]
M08_L02:
       test      rdi,rdi
       je        near ptr M08_L16
       test      dword ptr [rdi+34],1600000
       je        short M08_L06
       mov       rcx,rbx
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FF80D1D72D0]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
M08_L03:
       mov       byte ptr [rbx+3C],2
M08_L04:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M08_L05:
       mov       edi,7
       jmp       short M08_L00
M08_L06:
       test      dword ptr [rdi+34],1600000
       jne       near ptr M08_L19
       cmp       qword ptr [rdi+20],0
       jne       near ptr M08_L18
       lea       rcx,[rdi+20]
       test      rcx,rcx
       je        near ptr M08_L17
       mov       rdx,rbx
       xor       r8d,r8d
       call      00007FF86CA021C0
       test      rax,rax
       je        short M08_L04
       jmp       near ptr M08_L18
M08_L07:
       mov       edi,6
       jmp       near ptr M08_L00
M08_L08:
       test      edx,800000
       je        short M08_L09
       mov       edi,4
       jmp       near ptr M08_L00
M08_L09:
       test      edx,20000
       je        short M08_L10
       mov       edi,3
       jmp       near ptr M08_L00
M08_L10:
       test      edx,2000000
       setne     dil
       movzx     edi,dil
       mov       ecx,2
       test      edx,10000
       cmovne    edi,ecx
       jmp       near ptr M08_L00
M08_L11:
       add       edi,0FFFFFFFA
       cmp       edi,1
       ja        near ptr M08_L04
       movzx     r8d,byte ptr [rbx+3D]
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF80D1D72D0]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       jmp       near ptr M08_L04
M08_L12:
       mov       rdx,rsi
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rcx,rax
       jmp       near ptr M08_L01
M08_L13:
       mov       rcx,rsi
       mov       rax,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task>
       cmp       [rcx],rax
       je        short M08_L14
       mov       rdx,rsi
       mov       rcx,rax
       call      qword ptr [7FF80CF94D20]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rcx,rax
M08_L14:
       cmp       [rcx],ecx
       call      qword ptr [7FF80D1D7360]; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].get_Result()
       mov       rdi,rax
       jmp       near ptr M08_L02
M08_L15:
       mov       edx,1
       call      qword ptr [7FF80D1DE928]
       mov       rdi,rax
       jmp       near ptr M08_L02
M08_L16:
       mov       rcx,rbx
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FF80D1D7750]
       jmp       near ptr M08_L03
M08_L17:
       call      qword ptr [7FF80D1DDE78]
       int       3
M08_L18:
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FF80D1DC270]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M08_L04
M08_L19:
       mov       rcx,rbx
       mov       rdx,rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF80D1ABC30]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
; Total bytes of code 504
```
```assembly
; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       r14,[rbx+20]
       mov       rdx,16CD0000218
       cmp       r14,[rdx]
       jne       short M09_L01
M09_L00:
       xor       eax,eax
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M09_L01:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.List<System.Object>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       jne       near ptr M09_L11
       mov       rcx,offset MT_System.Collections.Generic.List<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FF80D09C4C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       test      dil,dil
       je        short M09_L05
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M09_L02
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rsi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M09_L03
M09_L02:
       mov       rcx,r15
       mov       rdx,rsi
       call      qword ptr [7FF80CDB71C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M09_L03:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M09_L04
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M09_L09
M09_L04:
       mov       rcx,r15
       mov       rdx,r14
       call      qword ptr [7FF80CDB71C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M09_L09
M09_L05:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M09_L06
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M09_L07
M09_L06:
       mov       rcx,r15
       mov       rdx,r14
       call      qword ptr [7FF80CDB71C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M09_L07:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M09_L08
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rsi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M09_L09
M09_L08:
       mov       rcx,r15
       mov       rdx,rsi
       call      qword ptr [7FF80CDB71C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M09_L09:
       lea       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M09_L10
       call      qword ptr [7FF80D1DDE78]
       int       3
M09_L10:
       mov       rdx,r15
       mov       r8,r14
       call      00007FF86CA021C0
       mov       r15,rax
       cmp       r15,r14
       je        near ptr M09_L20
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.List<System.Object>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       je        near ptr M09_L00
M09_L11:
       mov       [rbp-40],r15
       xor       edx,edx
       mov       [rbp-30],edx
       lea       rdx,[rbp-30]
       mov       rcx,r15
       call      qword ptr [7FF80CDB5998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rbx+20]
       mov       rax,16CD0000218
       cmp       rcx,[rax]
       jne       short M09_L12
       xor       ecx,ecx
       mov       [rbp-34],ecx
       jmp       near ptr M09_L18
M09_L12:
       mov       ecx,[r15+10]
       mov       rax,[r15+8]
       cmp       ecx,[rax+8]
       jne       short M09_L14
       mov       rcx,16CD0000270
       mov       rdx,[rcx]
       test      rdx,rdx
       jne       short M09_L13
       mov       rcx,offset MT_System.Predicate<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,16CD0000240
       mov       rdx,[rdx]
       mov       rcx,rbx
       mov       r8,7FF80D1DAF58
       call      qword ptr [7FF80CDB6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,16CD0000270
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rbx
M09_L13:
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FF80D1DEF70]
M09_L14:
       test      dil,dil
       je        short M09_L15
       mov       rcx,r15
       mov       r8,rsi
       xor       edx,edx
       call      qword ptr [7FF80CEA35F0]
       jmp       short M09_L19
M09_L15:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M09_L16
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rsi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M09_L19
M09_L16:
       mov       rcx,r15
       mov       rdx,rsi
       call      qword ptr [7FF80CDB71C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M09_L19
M09_L17:
       mov       rcx,r15
       call      qword ptr [7FF80CDB6820]; System.Threading.Monitor.Exit(System.Object)
       jmp       short M09_L20
M09_L18:
       call      M09_L22
       jmp       short M09_L21
M09_L19:
       cmp       byte ptr [rbp-30],0
       jne       short M09_L17
M09_L20:
       mov       eax,1
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M09_L21:
       mov       eax,[rbp-34]
       movzx     eax,al
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M09_L22:
       sub       rsp,28
       cmp       byte ptr [rbp-30],0
       je        short M09_L23
       mov       rcx,[rbp-40]
       call      qword ptr [7FF80CDB6820]; System.Threading.Monitor.Exit(System.Object)
M09_L23:
       nop
       add       rsp,28
       ret
; Total bytes of code 702
```
```assembly
; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
M10_L00:
       call      00007FF86CA10B20
       test      eax,eax
       je        near ptr M10_L24
       movzx     edi,byte ptr [rbx+3C]
       test      edi,edi
       jne       near ptr M10_L08
       mov       byte ptr [rbx+3C],1
       mov       edx,[rsi+34]
       test      edx,200000
       jne       near ptr M10_L06
       test      edx,400000
       jne       near ptr M10_L09
       test      edx,1000000
       je        near ptr M10_L10
       mov       edi,5
M10_L01:
       cmp       edi,5
       jne       near ptr M10_L21
       mov       rcx,rsi
       mov       rax,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task<System.Int32>>
       cmp       [rcx],rax
       jne       near ptr M10_L15
M10_L02:
       test      rcx,rcx
       je        near ptr M10_L16
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       near ptr M10_L18
       mov       rdi,[rcx+38]
M10_L03:
       test      rdi,rdi
       je        near ptr M10_L22
       test      dword ptr [rdi+34],1600000
       je        short M10_L07
       mov       rcx,rbx
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FF80D1D72D0]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
M10_L04:
       mov       byte ptr [rbx+3C],2
M10_L05:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M10_L06:
       mov       edi,7
       jmp       short M10_L01
M10_L07:
       test      dword ptr [rdi+34],1600000
       jne       near ptr M10_L20
       cmp       qword ptr [rdi+20],0
       jne       near ptr M10_L19
       lea       rcx,[rdi+20]
       test      rcx,rcx
       je        near ptr M10_L23
       mov       rdx,rbx
       xor       r8d,r8d
       call      00007FF86CA021C0
       test      rax,rax
       je        short M10_L05
       jmp       near ptr M10_L19
M10_L08:
       cmp       edi,1
       jne       short M10_L05
       mov       rcx,rbx
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF80D1D72D0]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       jmp       short M10_L04
M10_L09:
       mov       edi,6
       jmp       near ptr M10_L01
M10_L10:
       test      edx,800000
       je        short M10_L11
       mov       edi,4
       jmp       near ptr M10_L01
M10_L11:
       test      edx,20000
       je        short M10_L12
       mov       edi,3
       jmp       near ptr M10_L01
M10_L12:
       test      edx,10000
       je        short M10_L13
       mov       edi,2
       jmp       near ptr M10_L01
M10_L13:
       test      edx,2000000
       je        short M10_L14
       mov       edi,1
       jmp       near ptr M10_L01
M10_L14:
       xor       edi,edi
       jmp       near ptr M10_L01
M10_L15:
       mov       rdx,rsi
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rcx,rax
       jmp       near ptr M10_L02
M10_L16:
       mov       rcx,rsi
       mov       rax,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task>
       cmp       [rcx],rax
       je        short M10_L17
       mov       rdx,rsi
       mov       rcx,rax
       call      qword ptr [7FF80CF94D20]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rcx,rax
M10_L17:
       cmp       [rcx],ecx
       call      qword ptr [7FF80D1D7360]; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].get_Result()
       mov       rdi,rax
       jmp       near ptr M10_L03
M10_L18:
       mov       edx,1
       call      qword ptr [7FF80D1DE928]
       mov       rdi,rax
       jmp       near ptr M10_L03
M10_L19:
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FF80D1DC270]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M10_L05
M10_L20:
       mov       rsi,rdi
       jmp       near ptr M10_L00
M10_L21:
       add       edi,0FFFFFFFA
       cmp       edi,1
       ja        near ptr M10_L05
       movzx     r8d,byte ptr [rbx+3D]
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF80D1D72D0]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       jmp       near ptr M10_L05
M10_L22:
       mov       rcx,rbx
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FF80D1D7750]
       jmp       near ptr M10_L04
M10_L23:
       call      qword ptr [7FF80D1DDE78]
       int       3
M10_L24:
       mov       rcx,rbx
       mov       rdx,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF80D1D7258]
; Total bytes of code 570
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      dword ptr [rbx+34],1600000
       jne       short M11_L00
       mov       rcx,rbx
       mov       edx,0FFFFFFFF
       xor       r8d,r8d
       call      qword ptr [7FF80D1D50F8]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M11_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M11_L03
M11_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M11_L04
M11_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M11_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M11_L01
       mov       rcx,rbx
       call      qword ptr [7FF80D1DED90]
       jmp       short M11_L01
M11_L04:
       test      sil,2
       jne       short M11_L05
       mov       rcx,rbx
       call      qword ptr [7FF80D1DEB20]
M11_L05:
       mov       rcx,rbx
       call      qword ptr [7FF80D1DF2A0]
       jmp       short M11_L02
; Total bytes of code 124
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.ContendedFirstCallBenchmarks.LazyOfTask()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rbx,rcx
       mov       rcx,offset MT_AsyncLazyBenchmarks.ContendedFirstCallBenchmarks+<>c__DisplayClass8_0
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_System.Lazy<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,26FCE001300
       mov       rdx,[rcx]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.LazyHelper
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+10],8
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       edi,edi
M00_L00:
       mov       rbp,[rbx+8]
       cmp       [rbp+8],edi
       jle       near ptr M00_L22
       mov       r14,[rsi+10]
       test      r14,r14
       je        near ptr M00_L08
M00_L01:
       mov       rcx,26FCE001320
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M00_L34
M00_L02:
       cmp       [rax],al
       mov       rcx,26FCE001330
       mov       r15,[rcx]
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rcx,[r13+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r13+10],rcx
       lea       rcx,[r13+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,2008
       mov       [r13+34],ecx
       mov       rcx,gs:[58]
       mov       rcx,[rcx+48]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M00_L35
       mov       rcx,[rcx+240]
       mov       rax,[rcx+20]
       test      rax,rax
       je        near ptr M00_L35
M00_L03:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M00_L04
       call      qword ptr [7FF80D0A5458]; System.Threading.Thread.InitializeCurrentThread()
M00_L04:
       mov       r14,[rax+8]
       test      r14,r14
       jne       near ptr M00_L09
       mov       rcx,26FCE001340
       mov       r14,[rcx]
M00_L05:
       test      r14,r14
       jne       near ptr M00_L10
       or        dword ptr [r13+34],20000000
M00_L06:
       mov       rcx,r13
       xor       edx,edx
       call      qword ptr [7FF80D13FFD8]; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
       mov       rcx,offset MT_System.Threading.Tasks.UnwrapPromise<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       movzx     r15d,word ptr [r13+34]
       and       r15d,4
       test      r15d,0FFFFFFBB
       je        near ptr M00_L12
M00_L07:
       mov       ecx,2D
       call      qword ptr [7FF80CDCF348]
       int       3
M00_L08:
       mov       rcx,offset MT_System.Func<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset AsyncLazyBenchmarks.ContendedFirstCallBenchmarks+<>c__DisplayClass8_0.<LazyOfTask>b__0()
       mov       [r14+18],rcx
       lea       rcx,[rsi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L09:
       cmp       byte ptr [r14+18],0
       je        near ptr M00_L05
       xor       r14d,r14d
       jmp       near ptr M00_L05
M00_L10:
       mov       rcx,26FCE001340
       cmp       r14,[rcx]
       je        near ptr M00_L06
       mov       rax,[r13+28]
       test      rax,rax
       jne       short M00_L11
       mov       rcx,offset MT_System.Threading.Tasks.Task+ContingentProperties
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       dword ptr [r15+3C],1
       lea       rcx,[r13+28]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,r15
M00_L11:
       lea       rcx,[rax+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L06
M00_L12:
       test      r15b,4
       je        short M00_L15
       mov       rcx,gs:[58]
       mov       rcx,[rcx+48]
       cmp       dword ptr [rcx+238],8
       jle       near ptr M00_L36
       mov       rcx,[rcx+240]
       mov       rax,[rcx+40]
       test      rax,rax
       je        near ptr M00_L36
M00_L13:
       mov       r12,[rax+10]
       test      r12,r12
       je        short M00_L15
       mov       rax,[r14+28]
       test      rax,rax
       jne       short M00_L14
       mov       rcx,offset MT_System.Threading.Tasks.Task+ContingentProperties
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+30],rax
       mov       dword ptr [rax+3C],1
       lea       rcx,[r14+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+30]
M00_L14:
       lea       rcx,[rax+30]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
M00_L15:
       xor       ecx,ecx
       mov       [r14+8],rcx
       mov       [r14+10],rcx
       mov       [r14+18],rcx
       test      r15d,0FFFFFFA0
       jne       near ptr M00_L07
       mov       ecx,r15d
       or        ecx,400
       or        ecx,2000000
       mov       [r14+34],ecx
       mov       rcx,[r14+28]
       test      rcx,rcx
       jne       near ptr M00_L37
M00_L16:
       mov       byte ptr [r14+3D],1
       mov       rcx,26FCE001350
       mov       rcx,[rcx]
       cmp       byte ptr [rcx+9D],0
       jne       near ptr M00_L38
M00_L17:
       cmp       byte ptr [7FF80CD0B074],0
       jne       near ptr M00_L39
M00_L18:
       test      dword ptr [r13+34],1600000
       jne       short M00_L20
       test      dword ptr [r13+34],1600000
       jne       near ptr M00_L43
       cmp       qword ptr [r13+20],0
       jne       near ptr M00_L42
       lea       rcx,[r13+20]
       test      rcx,rcx
       je        near ptr M00_L53
       mov       rdx,r14
       xor       r8d,r8d
       call      00007FF86CA021C0
       test      rax,rax
       jne       near ptr M00_L42
M00_L19:
       movsxd    rdx,edi
       mov       rcx,rbp
       mov       r8,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       edi
       jmp       near ptr M00_L00
M00_L20:
       mov       byte ptr [r14+3C],1
       mov       rcx,r13
       call      qword ptr [7FF80D1C54D0]; System.Threading.Tasks.Task.get_Status()
       cmp       eax,5
       jne       near ptr M00_L40
       mov       ecx,[r13+34]
       and       ecx,11000000
       cmp       ecx,1000000
       jne       near ptr M00_L41
       mov       rdx,[r13+38]
M00_L21:
       mov       rcx,r14
       call      qword ptr [7FF80D1C5500]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].ProcessInnerTask(System.Threading.Tasks.Task)
       jmp       short M00_L19
M00_L22:
       mov       rdx,rbp
       test      rdx,rdx
       je        near ptr M00_L46
       lea       rbx,[rdx+10]
       mov       esi,[rdx+8]
       test      esi,esi
       je        near ptr M00_L47
       mov       edx,esi
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Int32>[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       r8d,esi
       shl       r8,3
       cmp       r8,4000
       jbe       short M00_L23
       mov       rdx,rbx
       call      qword ptr [7FF80D1CCA80]
       jmp       short M00_L24
M00_L23:
       mov       rdx,rbx
       call      00007FF86C9D37A0
       cmp       dword ptr [7FF86CD13A90],0
       jne       near ptr M00_L48
M00_L24:
       mov       ebx,[rdi+8]
       test      ebx,ebx
       jle       short M00_L26
       lea       rcx,[rdi+10]
       mov       edx,ebx
M00_L25:
       cmp       qword ptr [rcx],0
       je        near ptr M00_L49
       add       rcx,8
       dec       edx
       jne       short M00_L25
M00_L26:
       mov       rcx,offset MT_System.Threading.Tasks.Task+WhenAllPromise<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+34],2000400
       lea       rcx,[rsi+40]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsi+48],ebx
       mov       rcx,26FCE001350
       mov       rcx,[rcx]
       cmp       byte ptr [rcx+9D],0
       jne       near ptr M00_L50
M00_L27:
       cmp       byte ptr [7FF80CD0B074],0
       jne       near ptr M00_L51
M00_L28:
       test      ebx,ebx
       jle       short M00_L32
       add       rdi,10
M00_L29:
       mov       rbp,[rdi]
       test      dword ptr [rbp+34],1600000
       je        short M00_L33
M00_L30:
       mov       rcx,rsi
       mov       rdx,rbp
       call      qword ptr [7FF80D1D91D0]; System.Threading.Tasks.Task+WhenAllPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
M00_L31:
       add       rdi,8
       dec       ebx
       jne       short M00_L29
M00_L32:
       mov       rax,rsi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L33:
       test      dword ptr [rbp+34],1600000
       jne       short M00_L30
       cmp       qword ptr [rbp+20],0
       jne       near ptr M00_L52
       lea       rcx,[rbp+20]
       test      rcx,rcx
       je        near ptr M00_L53
       mov       rdx,rsi
       xor       r8d,r8d
       call      00007FF86CA021C0
       test      rax,rax
       je        short M00_L31
       jmp       near ptr M00_L52
M00_L34:
       mov       rcx,offset MT_System.Threading.Tasks.TaskFactory<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       rcx,26FCE001320
       xor       r8d,r8d
       call      00007FF86CA021C0
       test      rax,rax
       jne       near ptr M00_L02
       mov       rax,26FCE001320
       mov       rax,[rax]
       jmp       near ptr M00_L02
M00_L35:
       mov       ecx,4
       call      qword ptr [7FF80D1CC210]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L03
M00_L36:
       mov       ecx,8
       call      qword ptr [7FF80D1CC210]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L13
M00_L37:
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M00_L16
       test      r15b,4
       je        near ptr M00_L16
       test      byte ptr [rcx+34],8
       jne       near ptr M00_L16
       call      qword ptr [7FF80D1C7CC0]
       jmp       near ptr M00_L16
M00_L38:
       mov       rcx,r14
       call      qword ptr [7FF80D1C4810]
       mov       edx,eax
       mov       rcx,26FCE001350
       mov       rcx,[rcx]
       mov       r8,26FA5299790
       xor       r9d,r9d
       call      qword ptr [7FF80D1C4828]
       jmp       near ptr M00_L17
M00_L39:
       mov       rcx,r14
       call      qword ptr [7FF80D1C4840]
       jmp       near ptr M00_L18
M00_L40:
       add       eax,0FFFFFFFA
       cmp       eax,1
       ja        near ptr M00_L19
       movzx     r8d,byte ptr [r14+3D]
       mov       rcx,r14
       mov       rdx,r13
       call      qword ptr [7FF80D1C54B8]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       jmp       near ptr M00_L19
M00_L41:
       mov       rcx,r13
       mov       edx,1
       call      qword ptr [7FF80D1CC6D8]
       mov       rdx,rax
       jmp       near ptr M00_L21
M00_L42:
       mov       rcx,r13
       mov       rdx,r14
       xor       r8d,r8d
       call      qword ptr [7FF80D1C6400]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M00_L19
M00_L43:
       call      00007FF86CA10B20
       test      eax,eax
       je        short M00_L45
       movzx     r15d,byte ptr [r14+3C]
       test      r15d,r15d
       je        short M00_L44
       cmp       r15d,1
       jne       near ptr M00_L19
       mov       rcx,r14
       mov       rdx,r13
       xor       r8d,r8d
       call      qword ptr [7FF80D1C54B8]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       mov       byte ptr [r14+3C],2
       jmp       near ptr M00_L19
M00_L44:
       mov       rcx,r14
       mov       rdx,r13
       call      qword ptr [7FF80D1C4870]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].ProcessCompletedOuterTask(System.Threading.Tasks.Task)
       jmp       near ptr M00_L19
M00_L45:
       mov       rcx,r14
       mov       rdx,r13
       call      qword ptr [7FF80D1C54A0]
       jmp       near ptr M00_L19
M00_L46:
       mov       ecx,33
       call      qword ptr [7FF80CDCFD38]
       int       3
M00_L47:
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Int32[]>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rsi
       xor       edx,edx
       mov       r8,26FA5298F30
       xor       r9d,r9d
       call      qword ptr [7FF80D1C4E88]
       jmp       near ptr M00_L32
M00_L48:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L24
M00_L49:
       mov       ecx,1D
       mov       edx,33
       call      qword ptr [7FF80D1C4EB8]
       int       3
M00_L50:
       mov       rcx,rsi
       call      qword ptr [7FF80D1C4810]
       mov       edx,eax
       mov       rcx,26FCE001350
       mov       rcx,[rcx]
       mov       r8,26FA5299E48
       xor       r9d,r9d
       call      qword ptr [7FF80D1C4828]
       jmp       near ptr M00_L27
M00_L51:
       mov       rcx,rsi
       call      qword ptr [7FF80D1C4840]
       jmp       near ptr M00_L28
M00_L52:
       mov       rcx,rbp
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF80D1C6400]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M00_L31
       jmp       near ptr M00_L30
M00_L53:
       call      qword ptr [7FF80D1C7D80]
       int       3
; Total bytes of code 1837
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M01_L00
       ret
M01_L00:
       xor       edx,edx
       jmp       qword ptr [7FF80D1C4F48]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
; Total bytes of code 26
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
; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       [rbp+10],rcx
       test      dl,dl
       jne       near ptr M03_L19
       or        dword ptr [rcx+34],10000
M03_L00:
       cmp       byte ptr [7FF80CD0B074],0
       jne       near ptr M03_L20
M03_L01:
       mov       rax,26FCE001350
       mov       rbx,[rax]
       cmp       byte ptr [rbx+9D],0
       jne       near ptr M03_L21
M03_L02:
       mov       rsi,[rcx+18]
       cmp       [rsi],sil
       cmp       byte ptr [rbx+9D],0
       jne       near ptr M03_L10
M03_L03:
       mov       rdx,offset MT_System.Threading.Tasks.ThreadPoolTaskScheduler
       cmp       [rsi],rdx
       jne       near ptr M03_L17
       movzx     esi,word ptr [rcx+34]
       test      sil,2
       jne       near ptr M03_L11
       mov       rdx,26FCE001358
       mov       rbx,[rdx]
       cmp       byte ptr [rbx+38],0
       jne       near ptr M03_L12
M03_L04:
       test      sil,1
       jne       short M03_L06
       mov       rax,gs:[58]
       mov       rax,[rax+48]
       cmp       dword ptr [rax+238],5
       jle       near ptr M03_L13
       mov       rax,[rax+240]
       mov       rax,[rax+28]
       test      rax,rax
       je        near ptr M03_L13
M03_L05:
       mov       rdx,[rax+10]
       test      rdx,rdx
       jne       near ptr M03_L14
M03_L06:
       mov       rdx,[rbx+8]
       mov       r8,[rdx+10]
       mov       r10,[r8+8]
M03_L07:
       mov       esi,[r8+0A0]
       mov       eax,esi
       and       eax,[r8+18]
       cmp       eax,[r10+8]
       jae       near ptr M03_L15
       shl       rax,4
       lea       rdi,[r10+rax+10]
       mov       eax,[rdi+8]
       sub       eax,esi
       je        short M03_L08
       test      eax,eax
       jge       short M03_L07
       mov       rcx,rdx
       mov       rdx,[rbp+10]
       call      qword ptr [7FF80D1CC480]
       jmp       short M03_L09
M03_L08:
       lea       r9,[r8+0A0]
       lea       r11d,[rsi+1]
       mov       eax,esi
       lock cmpxchg [r9],r11d
       cmp       eax,esi
       jne       short M03_L07
       mov       rdx,[rbp+10]
       mov       rcx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       inc       esi
       mov       [rdi+8],esi
M03_L09:
       add       rbx,78
       mov       ecx,1
       xchg      ecx,[rbx]
       test      ecx,ecx
       jne       near ptr M03_L18
       mov       rcx,26FCE001380
       mov       rbx,[rcx]
       lea       rcx,[rbx+178]
       lock inc  dword ptr [rcx]
       mov       rcx,rbx
       call      qword ptr [7FF80D1C44C8]; System.Threading.PortableThreadPool+WorkerThread.MaybeAddWorkingWorker(System.Threading.PortableThreadPool)
       cmp       dword ptr [rbx+17C],6
       je        near ptr M03_L18
       jmp       near ptr M03_L16
M03_L10:
       mov       rdx,rsi
       call      qword ptr [7FF80D1CC348]
       mov       rcx,[rbp+10]
       jmp       near ptr M03_L03
M03_L11:
       mov       rcx,offset MT_System.Threading.Tasks.ThreadPoolTaskScheduler
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,26FCE001418
       mov       rbx,[rcx]
       mov       rcx,offset MT_System.Threading.Thread
       call      CORINFO_HELP_NEWFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF80D1CCF60]
       mov       rcx,rsi
       mov       edx,1
       call      qword ptr [7FF80D1C4630]; System.Threading.Thread.set_IsBackground(Boolean)
       mov       rcx,rsi
       mov       rdx,26FA5298C38
       call      qword ptr [7FF80D1C4738]; System.Threading.Thread.set_Name(System.String)
       mov       rcx,rsi
       mov       rdx,[rbp+10]
       xor       r8d,r8d
       call      qword ptr [7FF80D1CCF78]
       jmp       near ptr M03_L18
M03_L12:
       mov       rdx,26FCE001370
       mov       rdx,[rdx]
       cmp       byte ptr [rdx+9D],0
       je        near ptr M03_L04
       mov       rdx,26FCE001370
       mov       rcx,[rdx]
       mov       rdx,[rbp+10]
       call      qword ptr [7FF80D1CC450]
       jmp       near ptr M03_L04
M03_L13:
       mov       ecx,5
       call      qword ptr [7FF80D1CC210]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M03_L05
M03_L14:
       mov       rcx,[rdx+18]
       mov       rdx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF80D1CC468]
       jmp       near ptr M03_L09
M03_L15:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M03_L16:
       mov       rcx,rbx
       call      qword ptr [7FF80D1C46A8]; System.Threading.PortableThreadPool+GateThread.EnsureRunningSlow(System.Threading.PortableThreadPool)
       jmp       short M03_L18
M03_L17:
       mov       rcx,rsi
       mov       rdx,[rbp+10]
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       nop
M03_L18:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L19:
       call      qword ptr [7FF80D1CCF48]
       test      eax,eax
       mov       rcx,[rbp+10]
       jne       near ptr M03_L00
       jmp       short M03_L18
M03_L20:
       call      qword ptr [7FF80D1C4840]
       mov       rcx,[rbp+10]
       jmp       near ptr M03_L01
M03_L21:
       test      word ptr [rcx+34],200
       jne       near ptr M03_L02
       call      qword ptr [7FF80D1C4810]
       mov       esi,eax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       call      qword ptr [7FF80D1CC2B8]
       mov       rdx,rax
       mov       rcx,26FA5298BB0
       call      qword ptr [7FF80CDCD9C8]; System.String.Concat(System.String, System.String)
       mov       r8,rax
       mov       edx,esi
       mov       rcx,rbx
       xor       r9d,r9d
       call      qword ptr [7FF80D1C4828]
       mov       rcx,[rbp+10]
       jmp       near ptr M03_L02
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_System.Threading.Tasks.TaskSchedulerException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF80D1CC2D0]
       mov       rcx,[rbp+10]
       mov       rdx,rsi
       call      qword ptr [7FF80D1CC2E8]
       mov       rcx,[rbp+10]
       xor       edx,edx
       call      qword ptr [7FF80D1CC300]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80D1CC318]
       test      eax,200
       jne       short M03_L22
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+28]
       mov       rcx,[rcx+18]
       xor       edx,edx
       cmp       [rcx],ecx
       call      qword ptr [7FF80D1CC330]
M03_L22:
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 879
```
```assembly
; AsyncLazyBenchmarks.ContendedFirstCallBenchmarks+<>c__DisplayClass8_0.<LazyOfTask>b__0()
       mov       rcx,[rcx+8]
       cmp       qword ptr [rcx+8],0
       jne       short M04_L00
       mov       rax,[rcx+18]
       ret
M04_L00:
       jmp       qword ptr [7FF80D0A5848]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
; Total bytes of code 22
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M05_L01
       lea       rax,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       mov       rdx,[rcx+30]
       test      r8,r8
       je        short M05_L00
       cmp       rdx,[r8]
       je        short M05_L02
       mov       r10,offset MT_System.Object[]
       cmp       rcx,r10
       je        short M05_L02
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FF80D0A4EB8]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
M05_L00:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M05_L01:
       call      qword ptr [7FF80D1C7BA0]
       int       3
M05_L02:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FF86CA540D0
; Total bytes of code 94
```
```assembly
; System.Threading.Tasks.Task.get_Status()
       mov       eax,[rcx+34]
       test      eax,200000
       jne       short M06_L01
       test      eax,400000
       jne       short M06_L02
       test      eax,1000000
       je        short M06_L03
       mov       eax,5
M06_L00:
       ret
M06_L01:
       mov       eax,7
       jmp       short M06_L00
M06_L02:
       mov       eax,6
       jmp       short M06_L00
M06_L03:
       test      eax,800000
       je        short M06_L04
       mov       eax,4
       jmp       short M06_L00
M06_L04:
       test      eax,20000
       je        short M06_L05
       mov       eax,3
       jmp       short M06_L00
M06_L05:
       test      eax,2000000
       setne     cl
       movzx     ecx,cl
       mov       edx,2
       test      eax,10000
       mov       eax,edx
       cmove     eax,ecx
       jmp       short M06_L00
; Total bytes of code 100
```
```assembly
; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].ProcessInnerTask(System.Threading.Tasks.Task)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       test      rdx,rdx
       je        short M07_L01
       test      dword ptr [rdx+34],1600000
       je        short M07_L02
       mov       rcx,rbx
       xor       r8d,r8d
       call      qword ptr [7FF80D1C54B8]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
M07_L00:
       mov       byte ptr [rbx+3C],2
       add       rsp,20
       pop       rbx
       ret
M07_L01:
       mov       rcx,rbx
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FF80D1C5578]
       jmp       short M07_L00
M07_L02:
       mov       rcx,rdx
       mov       rdx,rbx
       xor       r8d,r8d
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF80D1C4888]; System.Threading.Tasks.Task.AddCompletionAction(System.Threading.Tasks.ITaskCompletionAction, Boolean)
; Total bytes of code 80
```
```assembly
; System.Threading.Tasks.Task+WhenAllPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rbx,rcx
       mov       rcx,26FCE001350
       mov       rsi,[rcx]
       cmp       byte ptr [rsi+9D],0
       jne       near ptr M08_L11
M08_L00:
       lea       rdx,[rbx+48]
       mov       ecx,0FFFFFFFF
       lock xadd [rdx],ecx
       dec       ecx
       je        short M08_L02
M08_L01:
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M08_L02:
       mov       rdx,[rbx+40]
       mov       edx,[rdx+8]
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       xor       ebp,ebp
       xor       r14d,r14d
       xor       r15d,r15d
M08_L03:
       mov       rcx,[rbx+40]
       cmp       [rcx+8],r15d
       jle       near ptr M08_L08
       cmp       r15d,[rcx+8]
       jae       near ptr M08_L23
       mov       r13d,r15d
       mov       r12,[rcx+r13*8+10]
       test      dword ptr [r12+34],200000
       jne       near ptr M08_L12
       mov       ecx,[r12+34]
       and       ecx,600000
       cmp       ecx,400000
       je        near ptr M08_L15
       test      dword ptr [r12+34],1600000
       je        near ptr M08_L16
M08_L04:
       mov       ecx,[r12+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       near ptr M08_L17
M08_L05:
       mov       ecx,[r12+38]
       cmp       r15d,[rdi+8]
       jae       near ptr M08_L23
       mov       [rdi+r13*4+10],ecx
M08_L06:
       test      dword ptr [r12+34],10000000
       jne       near ptr M08_L18
       mov       rcx,[rbx+40]
       cmp       r15d,[rcx+8]
       jae       near ptr M08_L23
       xor       edx,edx
       mov       [rcx+r13*8+10],rdx
M08_L07:
       inc       r15d
       jmp       near ptr M08_L03
M08_L08:
       test      rbp,rbp
       jne       near ptr M08_L19
       test      r14,r14
       jne       near ptr M08_L20
       cmp       byte ptr [rsi+9D],0
       jne       near ptr M08_L21
M08_L09:
       cmp       byte ptr [7FF80CD0B074],0
       jne       near ptr M08_L22
M08_L10:
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7FF80D1C5740]; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].TrySetResult(System.__Canon)
       jmp       near ptr M08_L01
M08_L11:
       mov       rcx,rbx
       call      qword ptr [7FF80D1C4810]
       mov       edx,eax
       mov       rcx,rsi
       mov       r8d,1
       call      qword ptr [7FF80D1C5530]
       jmp       near ptr M08_L00
M08_L12:
       test      rbp,rbp
       jne       short M08_L13
       mov       rcx,offset MT_System.Collections.Generic.List<System.Runtime.ExceptionServices.ExceptionDispatchInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FF80D0AC4C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
M08_L13:
       mov       rcx,[r12+28]
       mov       rax,[rcx+18]
       mov       [rsp+30],rax
       mov       rdx,[rax+10]
       mov       [rsp+28],rdx
       cmp       byte ptr [rax+20],0
       jne       short M08_L14
       mov       rcx,rax
       call      qword ptr [7FF80D0A55F0]; System.GC.SuppressFinalize(System.Object)
       mov       rcx,[rsp+30]
       mov       byte ptr [rcx+20],1
M08_L14:
       mov       rcx,rbp
       mov       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF80D1C56C8]
       jmp       near ptr M08_L06
M08_L15:
       test      r14,r14
       jne       near ptr M08_L06
       mov       r14,r12
       jmp       near ptr M08_L06
M08_L16:
       mov       rcx,r12
       mov       edx,0FFFFFFFF
       xor       r8d,r8d
       call      qword ptr [7FF80D1C4F60]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
       jmp       near ptr M08_L04
M08_L17:
       mov       rcx,r12
       mov       edx,1
       call      qword ptr [7FF80D1CC6F0]
       jmp       near ptr M08_L05
M08_L18:
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FF80D1C5728]
       jmp       near ptr M08_L07
M08_L19:
       mov       rcx,rbx
       mov       rdx,rbp
       call      qword ptr [7FF80D1C5608]
       jmp       near ptr M08_L01
M08_L20:
       mov       rcx,r14
       call      qword ptr [7FF80D1C5548]
       mov       rbp,rax
       mov       rcx,r14
       call      qword ptr [7FF80D1C5560]
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      qword ptr [7FF80D1C5578]
       jmp       near ptr M08_L01
M08_L21:
       mov       rcx,rbx
       call      qword ptr [7FF80D1C4810]
       mov       edx,eax
       mov       rcx,rsi
       mov       r8d,1
       call      qword ptr [7FF80D1C5620]
       jmp       near ptr M08_L09
M08_L22:
       mov       rcx,rbx
       call      qword ptr [7FF80D1C5638]
       jmp       near ptr M08_L10
M08_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 662
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
       jne       short M09_L01
       cmp       [rax],ecx
       jle       short M09_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M09_L03
M09_L00:
       add       rsp,20
       pop       rbx
       ret
M09_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M09_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M09_L00
M09_L02:
       cmp       [rax+4],edx
       jle       short M09_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M09_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M09_L03
       jmp       short M09_L00
M09_L03:
       mov       ecx,ebx
       lea       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
M10_L00:
       mov       rcx,26FCE001350
       mov       rbp,[rcx]
       cmp       byte ptr [rbp+9D],0
       jne       near ptr M10_L13
M10_L01:
       xor       eax,eax
       mov       ecx,[rsi+34]
       test      ecx,200000
       jne       near ptr M10_L14
       test      ecx,400000
       jne       near ptr M10_L15
       test      ecx,1000000
       je        near ptr M10_L16
       mov       edx,5
M10_L02:
       add       edx,0FFFFFFFB
       jne       near ptr M10_L19
       cmp       byte ptr [rbp+9D],0
       jne       near ptr M10_L21
M10_L03:
       cmp       byte ptr [7FF80CD0B074],0
       jne       near ptr M10_L22
M10_L04:
       mov       rcx,rsi
       mov       rax,offset MT_System.Threading.Tasks.Task<System.Int32>
       cmp       [rcx],rax
       jne       near ptr M10_L23
M10_L05:
       test      rcx,rcx
       je        near ptr M10_L12
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       near ptr M10_L24
       mov       esi,[rcx+38]
M10_L06:
       xor       edi,edi
       mov       eax,[rbx+34]
       mov       [rsp+24],eax
       test      eax,5600000
       jne       short M10_L10
       lea       rcx,[rbx+34]
       mov       edx,eax
       or        edx,4000000
       lock cmpxchg [rcx],edx
       cmp       eax,[rsp+24]
       jne       near ptr M10_L25
M10_L07:
       mov       [rbx+38],esi
       lea       rcx,[rbx+34]
       mov       eax,[rbx+34]
       or        eax,1000000
       xchg      eax,[rcx]
       mov       rdi,[rbx+28]
       test      rdi,rdi
       jne       near ptr M10_L26
M10_L08:
       lea       rcx,[rbx+20]
       test      rcx,rcx
       je        near ptr M10_L27
       mov       rdx,26FCE000218
       mov       rdx,[rdx]
       call      00007FF86CA0C330
       test      rax,rax
       je        short M10_L09
       mov       rcx,rbx
       mov       rdx,rax
       call      qword ptr [7FF80D1C5428]; System.Threading.Tasks.Task.RunContinuations(System.Object)
M10_L09:
       mov       edi,1
M10_L10:
       mov       eax,edi
M10_L11:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M10_L12:
       xor       esi,esi
       jmp       near ptr M10_L06
M10_L13:
       mov       rcx,rbx
       call      qword ptr [7FF80D1C4810]
       mov       edx,eax
       mov       rcx,rbp
       mov       r8d,1
       call      qword ptr [7FF80D1C5530]
       jmp       near ptr M10_L01
M10_L14:
       mov       edx,7
       jmp       near ptr M10_L02
M10_L15:
       mov       edx,6
       jmp       near ptr M10_L02
M10_L16:
       test      ecx,800000
       je        short M10_L17
       mov       edx,4
       jmp       near ptr M10_L02
M10_L17:
       test      ecx,20000
       je        short M10_L18
       mov       edx,3
       jmp       near ptr M10_L02
M10_L18:
       test      ecx,2000000
       setne     dl
       movzx     edx,dl
       mov       r8d,2
       test      ecx,10000
       cmovne    edx,r8d
       jmp       near ptr M10_L02
M10_L19:
       cmp       edx,2
       ja        near ptr M10_L11
       mov       ecx,edx
       lea       rax,[7FF80CE49900]
       mov       eax,[rax+rcx*4]
       lea       rdx,[M10_L00]
       add       rax,rdx
       jmp       rax
       mov       rcx,rsi
       call      qword ptr [7FF80D1C5548]
       mov       rdi,rax
       mov       rcx,rsi
       call      qword ptr [7FF80D1C5560]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF80D1C5578]
       jmp       near ptr M10_L11
       mov       rcx,rsi
       call      qword ptr [7FF80D1C5590]
       mov       rsi,rax
       test      dil,dil
       je        short M10_L20
       cmp       dword ptr [rsi+10],0
       jle       short M10_L20
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF80CEB3578]
       mov       rbp,rax
       test      rbp,rbp
       je        short M10_L20
       mov       rdx,[rbp+8]
       mov       rcx,offset MT_System.OperationCanceledException
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M10_L20
       mov       rdx,[rax+70]
       mov       rcx,rbx
       mov       r8,rbp
       call      qword ptr [7FF80D1C5578]
       jmp       near ptr M10_L11
M10_L20:
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF80D1C5608]
       jmp       near ptr M10_L11
M10_L21:
       mov       rcx,rbx
       call      qword ptr [7FF80D1C4810]
       mov       edx,eax
       mov       rcx,rbp
       mov       r8d,1
       call      qword ptr [7FF80D1C5620]
       jmp       near ptr M10_L03
M10_L22:
       mov       rcx,rbx
       call      qword ptr [7FF80D1C5638]
       jmp       near ptr M10_L04
M10_L23:
       mov       rdx,rsi
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rcx,rax
       jmp       near ptr M10_L05
M10_L24:
       mov       edx,1
       call      qword ptr [7FF80D1C56F8]; System.Threading.Tasks.Task`1[[System.Int32, System.Private.CoreLib]].GetResultCore(Boolean)
       mov       esi,eax
       jmp       near ptr M10_L06
M10_L25:
       mov       rcx,rbx
       mov       edx,4000000
       mov       r8d,5600000
       call      qword ptr [7FF80D1CC288]
       test      eax,eax
       je        near ptr M10_L10
       jmp       near ptr M10_L07
M10_L26:
       mov       rcx,rbx
       call      qword ptr [7FF80D1CC708]
       mov       rcx,rdi
       call      qword ptr [7FF80D1CC720]
       jmp       near ptr M10_L08
M10_L27:
       call      qword ptr [7FF80D1C7D80]
       int       3
; Total bytes of code 765
```
```assembly
; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       r14,[rbx+20]
       mov       rdx,26FCE000218
       cmp       r14,[rdx]
       jne       short M11_L01
M11_L00:
       xor       eax,eax
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M11_L01:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.List<System.Object>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       jne       near ptr M11_L11
       mov       rcx,offset MT_System.Collections.Generic.List<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FF80D0AC4C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       test      dil,dil
       je        short M11_L05
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M11_L02
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rsi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M11_L03
M11_L02:
       mov       rcx,r15
       mov       rdx,rsi
       call      qword ptr [7FF80CDC71C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M11_L03:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M11_L04
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M11_L09
M11_L04:
       mov       rcx,r15
       mov       rdx,r14
       call      qword ptr [7FF80CDC71C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M11_L09
M11_L05:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M11_L06
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M11_L07
M11_L06:
       mov       rcx,r15
       mov       rdx,r14
       call      qword ptr [7FF80CDC71C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M11_L07:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M11_L08
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rsi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M11_L09
M11_L08:
       mov       rcx,r15
       mov       rdx,rsi
       call      qword ptr [7FF80CDC71C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M11_L09:
       lea       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M11_L10
       call      qword ptr [7FF80D1C7D80]
       int       3
M11_L10:
       mov       rdx,r15
       mov       r8,r14
       call      00007FF86CA021C0
       mov       r15,rax
       cmp       r15,r14
       je        near ptr M11_L20
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.List<System.Object>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       je        near ptr M11_L00
M11_L11:
       mov       [rbp-40],r15
       xor       edx,edx
       mov       [rbp-30],edx
       lea       rdx,[rbp-30]
       mov       rcx,r15
       call      qword ptr [7FF80CDC5998]; System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rcx,[rbx+20]
       mov       rax,26FCE000218
       cmp       rcx,[rax]
       jne       short M11_L12
       xor       ecx,ecx
       mov       [rbp-34],ecx
       jmp       near ptr M11_L18
M11_L12:
       mov       ecx,[r15+10]
       mov       rax,[r15+8]
       cmp       ecx,[rax+8]
       jne       short M11_L14
       mov       rcx,26FCE000270
       mov       rdx,[rcx]
       test      rdx,rdx
       jne       short M11_L13
       mov       rcx,offset MT_System.Predicate<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,26FCE000240
       mov       rdx,[rdx]
       mov       rcx,rbx
       mov       r8,7FF80D1C8CD8
       call      qword ptr [7FF80CDC6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,26FCE000270
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rbx
M11_L13:
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FF80D1CCCF0]
M11_L14:
       test      dil,dil
       je        short M11_L15
       mov       rcx,r15
       mov       r8,rsi
       xor       edx,edx
       call      qword ptr [7FF80CEB35F0]
       jmp       short M11_L19
M11_L15:
       inc       dword ptr [r15+14]
       mov       rcx,[r15+8]
       mov       edx,[r15+10]
       cmp       [rcx+8],edx
       jbe       short M11_L16
       lea       r8d,[rdx+1]
       mov       [r15+10],r8d
       mov       r8,rsi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M11_L19
M11_L16:
       mov       rcx,r15
       mov       rdx,rsi
       call      qword ptr [7FF80CDC71C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M11_L19
M11_L17:
       mov       rcx,r15
       call      qword ptr [7FF80CDC6820]; System.Threading.Monitor.Exit(System.Object)
       jmp       short M11_L20
M11_L18:
       call      M11_L22
       jmp       short M11_L21
M11_L19:
       cmp       byte ptr [rbp-30],0
       jne       short M11_L17
M11_L20:
       mov       eax,1
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M11_L21:
       mov       eax,[rbp-34]
       movzx     eax,al
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M11_L22:
       sub       rsp,28
       cmp       byte ptr [rbp-30],0
       je        short M11_L23
       mov       rcx,[rbp-40]
       call      qword ptr [7FF80CDC6820]; System.Threading.Monitor.Exit(System.Object)
M11_L23:
       nop
       add       rsp,28
       ret
; Total bytes of code 702
```
```assembly
; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].ProcessCompletedOuterTask(System.Threading.Tasks.Task)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       byte ptr [rbx+3C],1
       mov       edx,[rsi+34]
       test      edx,200000
       jne       near ptr M12_L05
       test      edx,400000
       jne       near ptr M12_L06
       test      edx,1000000
       je        near ptr M12_L07
       mov       edi,5
M12_L00:
       cmp       edi,5
       jne       near ptr M12_L10
       mov       rcx,rsi
       mov       rax,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task<System.Int32>>
       cmp       [rcx],rax
       jne       near ptr M12_L11
M12_L01:
       test      rcx,rcx
       je        near ptr M12_L12
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       near ptr M12_L14
       mov       rdx,[rcx+38]
M12_L02:
       test      rdx,rdx
       je        near ptr M12_L15
       test      dword ptr [rdx+34],1600000
       je        near ptr M12_L16
       mov       rcx,rbx
       xor       r8d,r8d
       call      qword ptr [7FF80D1C54B8]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
M12_L03:
       mov       byte ptr [rbx+3C],2
M12_L04:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M12_L05:
       mov       edi,7
       jmp       short M12_L00
M12_L06:
       mov       edi,6
       jmp       short M12_L00
M12_L07:
       test      edx,800000
       je        short M12_L08
       mov       edi,4
       jmp       near ptr M12_L00
M12_L08:
       test      edx,20000
       je        short M12_L09
       mov       edi,3
       jmp       near ptr M12_L00
M12_L09:
       test      edx,2000000
       setne     dil
       movzx     edi,dil
       mov       ecx,2
       test      edx,10000
       cmovne    edi,ecx
       jmp       near ptr M12_L00
M12_L10:
       add       edi,0FFFFFFFA
       cmp       edi,1
       ja        short M12_L04
       movzx     r8d,byte ptr [rbx+3D]
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF80D1C54B8]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       jmp       short M12_L04
M12_L11:
       mov       rdx,rsi
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rcx,rax
       jmp       near ptr M12_L01
M12_L12:
       mov       rcx,rsi
       mov       rax,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task>
       cmp       [rcx],rax
       je        short M12_L13
       mov       rdx,rsi
       mov       rcx,rax
       call      qword ptr [7FF80CFA4D20]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rcx,rax
M12_L13:
       cmp       [rcx],ecx
       call      qword ptr [7FF80D1C54E8]; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].get_Result()
       mov       rdx,rax
       jmp       near ptr M12_L02
M12_L14:
       mov       edx,1
       call      qword ptr [7FF80D1CC6D8]
       mov       rdx,rax
       jmp       near ptr M12_L02
M12_L15:
       mov       rcx,rbx
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FF80D1C5578]
       jmp       near ptr M12_L03
M12_L16:
       mov       rcx,rdx
       mov       rdx,rbx
       xor       r8d,r8d
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF80D1C4888]; System.Threading.Tasks.Task.AddCompletionAction(System.Threading.Tasks.ITaskCompletionAction, Boolean)
; Total bytes of code 410
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      dword ptr [rbx+34],1600000
       jne       short M13_L00
       mov       rcx,rbx
       mov       edx,0FFFFFFFF
       xor       r8d,r8d
       call      qword ptr [7FF80D1C4F60]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M13_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M13_L03
M13_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M13_L04
M13_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M13_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M13_L01
       mov       rcx,rbx
       call      qword ptr [7FF80D1CCCC0]
       jmp       short M13_L01
M13_L04:
       test      sil,2
       jne       short M13_L05
       mov       rcx,rbx
       call      qword ptr [7FF80D1CCB10]
M13_L05:
       mov       rcx,rbx
       call      qword ptr [7FF80D1CD128]
       jmp       short M13_L02
; Total bytes of code 124
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.ContendedFirstCallBenchmarks.AsyncLazy()
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,90
       lea       rbp,[rsp+0B0]
       xor       eax,eax
       mov       [rbp-78],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu32 [rbp-70],zmm4
       mov       [rbp-30],rax
       mov       [rbp+10],rcx
       mov       rcx,offset MT_AsyncLazyBenchmarks.ContendedFirstCallBenchmarks+<>c__DisplayClass9_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rcx,offset MT_System.Threading.Tasks.AsyncLazy<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,187D4401300
       mov       rdx,[rcx]
       lea       rcx,[rbx+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-40]
       lea       rcx,[rax+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbp-24],ecx
M00_L00:
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+8]
       mov       eax,[rbx+8]
       cmp       eax,[rbp-24]
       jle       near ptr M00_L34
       mov       rax,[rbp-40]
       mov       rsi,[rax+10]
       mov       [rbp-48],rbx
       test      rsi,rsi
       je        near ptr M00_L08
M00_L01:
       mov       rdx,187D4401320
       mov       rdx,[rdx]
       test      rdx,rdx
       je        near ptr M00_L66
M00_L02:
       cmp       [rdx],dl
       mov       rdx,187D4401330
       mov       rbx,[rdx]
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-58],rax
       mov       rcx,[rbp-58]
       lea       rcx,[rcx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-58]
       xor       edx,edx
       mov       [rcx+10],rdx
       mov       rcx,[rbp-58]
       lea       rcx,[rcx+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,2008
       mov       rax,[rbp-58]
       mov       [rax+34],ecx
       mov       rcx,gs:[58]
       mov       rcx,[rcx+48]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M00_L67
       mov       rcx,[rcx+240]
       mov       rax,[rcx+20]
       test      rax,rax
       je        near ptr M00_L67
M00_L03:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M00_L04
       call      qword ptr [7FF80D0B5458]; System.Threading.Thread.InitializeCurrentThread()
M00_L04:
       mov       rbx,[rax+8]
       test      rbx,rbx
       jne       near ptr M00_L68
       mov       rcx,187D4401340
       mov       rbx,[rcx]
M00_L05:
       test      rbx,rbx
       jne       near ptr M00_L09
       mov       rcx,[rbp-58]
       or        dword ptr [rcx+34],20000000
M00_L06:
       mov       rcx,[rbp-58]
       xor       edx,edx
       call      qword ptr [7FF80D1D4108]; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
       mov       rcx,offset MT_System.Threading.Tasks.UnwrapPromise<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-50],rax
       mov       rcx,[rbp-58]
       movzx     ebx,word ptr [rcx+34]
       and       ebx,4
       test      ebx,0FFFFFFBB
       je        near ptr M00_L11
M00_L07:
       mov       ecx,2D
       call      qword ptr [7FF80CDDF348]
       int       3
M00_L08:
       mov       rcx,offset MT_System.Func<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,[rbp-40]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset AsyncLazyBenchmarks.ContendedFirstCallBenchmarks+<>c__DisplayClass9_0.<AsyncLazy>b__0()
       mov       [rsi+18],rcx
       mov       rdx,[rbp-40]
       lea       rcx,[rdx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L09:
       mov       rcx,187D4401340
       cmp       rbx,[rcx]
       je        near ptr M00_L06
       mov       rcx,[rbp-58]
       mov       rax,[rcx+28]
       test      rax,rax
       jne       short M00_L10
       mov       rcx,offset MT_System.Threading.Tasks.Task+ContingentProperties
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+3C],1
       mov       rcx,[rbp-58]
       lea       rcx,[rcx+28]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
M00_L10:
       lea       rcx,[rax+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L06
M00_L11:
       test      bl,4
       je        near ptr M00_L14
       mov       rcx,gs:[58]
       mov       rcx,[rcx+48]
       cmp       dword ptr [rcx+238],8
       jle       near ptr M00_L69
       mov       rcx,[rcx+240]
       mov       rax,[rcx+40]
       test      rax,rax
       je        near ptr M00_L69
M00_L12:
       mov       rsi,[rax+10]
       test      rsi,rsi
       je        short M00_L14
       mov       rcx,[rbp-50]
       mov       rax,[rcx+28]
       test      rax,rax
       jne       short M00_L13
       mov       rcx,offset MT_System.Threading.Tasks.Task+ContingentProperties
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+3C],1
       mov       rcx,[rbp-50]
       lea       rcx,[rcx+28]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
M00_L13:
       lea       rcx,[rax+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M00_L14:
       mov       rcx,[rbp-50]
       xor       eax,eax
       mov       [rcx+8],rax
       mov       rcx,[rbp-50]
       mov       [rcx+10],rax
       mov       rcx,[rbp-50]
       mov       [rcx+18],rax
       test      ebx,0FFFFFFA0
       jne       near ptr M00_L07
       mov       ecx,ebx
       or        ecx,400
       or        ecx,2000000
       mov       rax,[rbp-50]
       mov       [rax+34],ecx
       mov       rcx,[rbp-50]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       jne       near ptr M00_L70
M00_L15:
       mov       rcx,[rbp-50]
       mov       byte ptr [rcx+3D],1
       mov       rcx,187D4401350
       mov       rcx,[rcx]
       cmp       byte ptr [rcx+9D],0
       jne       near ptr M00_L71
M00_L16:
       cmp       byte ptr [7FF80CD1B074],0
       jne       near ptr M00_L72
M00_L17:
       mov       rcx,[rbp-58]
       test      dword ptr [rcx+34],1600000
       jne       near ptr M00_L73
       mov       rcx,[rbp-58]
       test      dword ptr [rcx+34],1600000
       jne       near ptr M00_L32
       mov       rcx,[rbp-58]
       cmp       qword ptr [rcx+20],0
       jne       short M00_L19
       mov       rcx,[rbp-58]
       add       rcx,20
       test      rcx,rcx
       je        near ptr M00_L90
       mov       rdx,[rbp-50]
       xor       r8d,r8d
       call      00007FF86CA021C0
       test      rax,rax
       jne       short M00_L19
M00_L18:
       movsxd    rdx,dword ptr [rbp-24]
       mov       rcx,[rbp-48]
       mov       r8,[rbp-50]
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       ecx,[rbp-24]
       inc       ecx
       mov       [rbp-24],ecx
       jmp       near ptr M00_L00
M00_L19:
       mov       rdx,[rbp-58]
       mov       rbx,[rdx+20]
       mov       rdx,187D4400218
       mov       rsi,[rdx]
       cmp       rbx,rsi
       je        near ptr M00_L74
       mov       rdi,rbx
       test      rdi,rdi
       je        short M00_L20
       mov       rcx,offset MT_System.Collections.Generic.List<System.Object>
       cmp       [rdi],rcx
       je        short M00_L20
       mov       rdx,rbx
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
M00_L20:
       test      rdi,rdi
       je        near ptr M00_L64
M00_L21:
       mov       [rbp-60],rdi
       xor       ecx,ecx
       mov       [rbp-28],ecx
       mov       rcx,rdi
       call      00007FF86CA5E120
       test      eax,eax
       jne       short M00_L22
       mov       rcx,rdi
       call      qword ptr [7FF80D1D59F8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
M00_L22:
       mov       dword ptr [rbp-28],1
       mov       rcx,[rbp-58]
       cmp       [rcx+20],rsi
       je        short M00_L27
       mov       ecx,[rdi+10]
       mov       rax,[rdi+8]
       cmp       ecx,[rax+8]
       je        short M00_L24
M00_L23:
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       short M00_L26
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       mov       edx,edx
       mov       r8,[rbp-50]
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M00_L29
M00_L24:
       mov       rcx,187D4400270
       mov       rdx,[rcx]
       test      rdx,rdx
       je        short M00_L28
M00_L25:
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FF80D1D5A10]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAll(System.Predicate`1<System.__Canon>)
       jmp       short M00_L23
M00_L26:
       mov       rcx,rdi
       mov       rdx,[rbp-50]
       call      qword ptr [7FF80CDD71C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L29
M00_L27:
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       jmp       near ptr M00_L33
M00_L28:
       mov       rcx,offset MT_System.Predicate<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,187D4400240
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset System.Threading.Tasks.Task+<>c.<AddTaskContinuationComplex>b__211_0(System.Object)
       mov       [rsi+18],rcx
       mov       rcx,187D4400270
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rsi
       jmp       short M00_L25
M00_L29:
       mov       rcx,rdi
       call      00007FF86CA5E040
       test      eax,eax
       jne       near ptr M00_L75
M00_L30:
       mov       ebx,1
M00_L31:
       test      ebx,ebx
       jne       near ptr M00_L18
M00_L32:
       call      00007FF86CA10B20
       test      eax,eax
       je        near ptr M00_L81
       mov       rcx,[rbp-50]
       movzx     ebx,byte ptr [rcx+3C]
       test      ebx,ebx
       je        near ptr M00_L77
       jmp       near ptr M00_L76
M00_L33:
       call      M00_L92
       nop
       mov       ebx,[rbp-2C]
       jmp       short M00_L31
M00_L34:
       mov       rdx,rbx
       test      rdx,rdx
       je        near ptr M00_L82
       lea       rbx,[rdx+10]
       mov       esi,[rdx+8]
       test      esi,esi
       je        near ptr M00_L83
       mov       edx,esi
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Int32>[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       r8d,esi
       shl       r8,3
       cmp       r8,4000
       jbe       short M00_L35
       mov       rdx,rbx
       call      qword ptr [7FF80D1DD4A0]
       jmp       short M00_L36
M00_L35:
       mov       rdx,rbx
       call      00007FF86C9D37A0
       cmp       dword ptr [7FF86CD13A90],0
       jne       near ptr M00_L84
M00_L36:
       mov       ebx,[rdi+8]
       test      ebx,ebx
       jle       short M00_L38
       lea       rcx,[rdi+10]
       mov       edx,ebx
M00_L37:
       cmp       qword ptr [rcx],0
       je        near ptr M00_L85
       add       rcx,8
       dec       edx
       jne       short M00_L37
M00_L38:
       mov       rcx,offset MT_System.Threading.Tasks.Task+WhenAllPromise<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-68],rax
       mov       rcx,[rbp-68]
       mov       dword ptr [rcx+34],2000400
       lea       rcx,[rcx+40]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-68]
       mov       [rcx+48],ebx
       mov       rax,187D4401350
       mov       rax,[rax]
       cmp       byte ptr [rax+9D],0
       jne       near ptr M00_L86
M00_L39:
       cmp       byte ptr [7FF80CD1B074],0
       jne       near ptr M00_L87
M00_L40:
       mov       [rbp-70],rdi
       xor       edx,edx
       mov       [rbp-30],edx
       jmp       short M00_L46
M00_L41:
       mov       rcx,r14
       call      00007FF86CA5E040
       test      eax,eax
       jne       near ptr M00_L89
M00_L42:
       mov       ebx,1
M00_L43:
       test      ebx,ebx
       jne       short M00_L45
M00_L44:
       mov       rcx,[rbp-68]
       mov       rdx,[rbp-78]
       call      qword ptr [7FF80D1E9F88]; System.Threading.Tasks.Task+WhenAllPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
M00_L45:
       mov       ecx,[rbp-30]
       inc       ecx
       mov       [rbp-30],ecx
       mov       rcx,[rbp-68]
M00_L46:
       mov       rdi,[rbp-70]
       mov       ebx,[rdi+8]
       cmp       ebx,[rbp-30]
       jle       near ptr M00_L58
       cmp       [rbp-30],ebx
       jae       near ptr M00_L91
       mov       edx,[rbp-30]
       mov       rdx,[rdi+rdx*8+10]
       mov       [rbp-78],rdx
       mov       rdx,[rbp-78]
       test      dword ptr [rdx+34],1600000
       jne       short M00_L44
       mov       rdx,[rbp-78]
       test      dword ptr [rdx+34],1600000
       jne       short M00_L44
       mov       rdx,[rbp-78]
       cmp       qword ptr [rdx+20],0
       jne       short M00_L47
       mov       rdx,[rbp-78]
       add       rdx,20
       test      rdx,rdx
       je        near ptr M00_L90
       mov       rcx,rdx
       mov       rdx,[rbp-68]
       xor       r8d,r8d
       call      00007FF86CA021C0
       test      rax,rax
       je        short M00_L45
M00_L47:
       mov       rcx,[rbp-68]
       mov       rdx,[rbp-78]
       mov       rbx,[rdx+20]
       mov       rdx,187D4400218
       mov       rsi,[rdx]
       cmp       rbx,rsi
       je        near ptr M00_L88
       mov       r14,rbx
       test      r14,r14
       je        short M00_L48
       mov       rax,offset MT_System.Collections.Generic.List<System.Object>
       cmp       [r14],rax
       je        short M00_L48
       mov       rdx,rbx
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       mov       rcx,[rbp-68]
M00_L48:
       test      r14,r14
       je        near ptr M00_L61
M00_L49:
       mov       [rbp-80],r14
       xor       eax,eax
       mov       [rbp-34],eax
       mov       rcx,r14
       call      00007FF86CA5E120
       test      eax,eax
       jne       short M00_L50
       mov       rcx,r14
       call      qword ptr [7FF80D1D59F8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
M00_L50:
       mov       dword ptr [rbp-34],1
       mov       rcx,[rbp-78]
       cmp       [rcx+20],rsi
       je        short M00_L52
       mov       ecx,[r14+10]
       mov       rax,[r14+8]
       cmp       ecx,[rax+8]
       je        short M00_L53
M00_L51:
       inc       dword ptr [r14+14]
       mov       rcx,[r14+8]
       mov       edx,[r14+10]
       cmp       [rcx+8],edx
       jbe       short M00_L55
       lea       r8d,[rdx+1]
       mov       [r14+10],r8d
       movsxd    rdx,edx
       mov       r8,[rbp-68]
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M00_L41
M00_L52:
       xor       ecx,ecx
       mov       [rbp-38],ecx
       jmp       near ptr M00_L57
M00_L53:
       mov       rcx,187D4400270
       mov       rdx,[rcx]
       test      rdx,rdx
       je        short M00_L56
M00_L54:
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FF80D1D5A10]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAll(System.Predicate`1<System.__Canon>)
       jmp       short M00_L51
M00_L55:
       mov       rcx,r14
       mov       rdx,[rbp-68]
       call      qword ptr [7FF80CDD71C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L41
M00_L56:
       mov       rcx,offset MT_System.Predicate<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,187D4400240
       mov       rdx,[rcx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset System.Threading.Tasks.Task+<>c.<AddTaskContinuationComplex>b__211_0(System.Object)
       mov       [rbx+18],rcx
       mov       rcx,187D4400270
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rbx
       jmp       short M00_L54
M00_L57:
       call      M00_L94
       nop
       mov       ebx,[rbp-38]
       mov       rdi,[rbp-70]
       jmp       near ptr M00_L43
M00_L58:
       mov       rax,rcx
M00_L59:
       add       rsp,90
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M00_L60:
       mov       rcx,r14
       mov       rdx,[rbp-68]
       call      qword ptr [7FF80CDD71C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L62
M00_L61:
       mov       rcx,offset MT_System.Collections.Generic.List<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,187D4400A60
       mov       rdx,[rcx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [r14+14]
       mov       rcx,r14
       mov       rdx,rbx
       call      qword ptr [7FF80CDD71C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       inc       dword ptr [r14+14]
       mov       rcx,[r14+8]
       mov       edx,[r14+10]
       cmp       [rcx+8],edx
       jbe       short M00_L60
       lea       r8d,[rdx+1]
       mov       [r14+10],r8d
       movsxd    rdx,edx
       mov       r8,[rbp-68]
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M00_L62:
       mov       rcx,[rbp-78]
       add       rcx,20
       test      rcx,rcx
       je        near ptr M00_L90
       mov       rdx,r14
       mov       r8,rbx
       call      00007FF86CA021C0
       mov       r14,rax
       cmp       r14,rbx
       je        near ptr M00_L42
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.List<System.Object>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       mov       rcx,[rbp-68]
       je        near ptr M00_L88
       jmp       near ptr M00_L49
M00_L63:
       mov       rcx,rdi
       mov       rdx,[rbp-50]
       call      qword ptr [7FF80CDD71C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L65
M00_L64:
       mov       rcx,offset MT_System.Collections.Generic.List<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,187D4400A60
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rdi+14]
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [7FF80CDD71C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       short M00_L63
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       mov       edx,edx
       mov       r8,[rbp-50]
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M00_L65:
       mov       rcx,[rbp-58]
       add       rcx,20
       test      rcx,rcx
       je        near ptr M00_L90
       mov       rdx,rdi
       mov       r8,rbx
       call      00007FF86CA021C0
       mov       rdi,rax
       cmp       rdi,rbx
       je        near ptr M00_L30
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.Generic.List<System.Object>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M00_L74
       jmp       near ptr M00_L21
M00_L66:
       mov       rcx,offset MT_System.Threading.Tasks.TaskFactory<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       rcx,187D4401320
       xor       r8d,r8d
       call      00007FF86CA021C0
       mov       rdx,rax
       test      rdx,rdx
       jne       near ptr M00_L02
       mov       rdx,187D4401320
       mov       rdx,[rdx]
       jmp       near ptr M00_L02
M00_L67:
       mov       ecx,4
       call      qword ptr [7FF80D1DC990]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L03
M00_L68:
       cmp       byte ptr [rbx+18],0
       je        near ptr M00_L05
       xor       ebx,ebx
       jmp       near ptr M00_L05
M00_L69:
       mov       ecx,8
       call      qword ptr [7FF80D1DC990]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L12
M00_L70:
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M00_L15
       test      bl,4
       je        near ptr M00_L15
       test      byte ptr [rcx+34],8
       jne       near ptr M00_L15
       call      qword ptr [7FF80D1DC9C0]
       jmp       near ptr M00_L15
M00_L71:
       mov       rcx,[rbp-50]
       call      qword ptr [7FF80D1D4930]
       mov       edx,eax
       mov       rcx,187D4401350
       mov       rcx,[rcx]
       mov       r8,187A53997B8
       xor       r9d,r9d
       call      qword ptr [7FF80D1D4948]
       jmp       near ptr M00_L16
M00_L72:
       mov       rcx,[rbp-50]
       call      qword ptr [7FF80D1D4960]
       jmp       near ptr M00_L17
M00_L73:
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-58]
       call      qword ptr [7FF80D1D4990]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].ProcessCompletedOuterTask(System.Threading.Tasks.Task)
       jmp       near ptr M00_L18
M00_L74:
       xor       ebx,ebx
       jmp       near ptr M00_L31
M00_L75:
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FF80D1D5A28]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       near ptr M00_L30
M00_L76:
       cmp       ebx,1
       jne       near ptr M00_L18
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-58]
       xor       r8d,r8d
       call      qword ptr [7FF80D1D5890]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       mov       rcx,[rbp-50]
       mov       byte ptr [rcx+3C],2
       jmp       near ptr M00_L18
M00_L77:
       mov       rcx,[rbp-50]
       mov       byte ptr [rcx+3C],1
       mov       rcx,[rbp-58]
       call      qword ptr [7FF80D1D58A8]; System.Threading.Tasks.Task.get_Status()
       cmp       eax,5
       je        short M00_L78
       add       eax,0FFFFFFFA
       cmp       eax,1
       ja        near ptr M00_L18
       mov       r8,[rbp-50]
       movzx     r8d,byte ptr [r8+3D]
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-58]
       call      qword ptr [7FF80D1D5890]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       jmp       near ptr M00_L18
M00_L78:
       mov       rcx,[rbp-58]
       mov       ecx,[rcx+34]
       and       ecx,11000000
       cmp       ecx,1000000
       jne       short M00_L79
       mov       rcx,[rbp-58]
       mov       rdx,[rcx+38]
       jmp       short M00_L80
M00_L79:
       mov       rcx,[rbp-58]
       mov       edx,1
       call      qword ptr [7FF80D1DCE28]
       mov       rdx,rax
M00_L80:
       mov       rcx,[rbp-50]
       call      qword ptr [7FF80D1D58D8]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].ProcessInnerTask(System.Threading.Tasks.Task)
       jmp       near ptr M00_L18
M00_L81:
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-58]
       call      qword ptr [7FF80D1D5878]
       jmp       near ptr M00_L18
M00_L82:
       mov       ecx,33
       call      qword ptr [7FF80CDDFD38]
       int       3
M00_L83:
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Int32[]>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rbx
       xor       edx,edx
       mov       r8,187A5398F58
       xor       r9d,r9d
       call      qword ptr [7FF80D1D4FA8]
       mov       rax,rbx
       jmp       near ptr M00_L59
M00_L84:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L36
M00_L85:
       mov       ecx,1D
       mov       edx,33
       call      qword ptr [7FF80D1D4FD8]
       int       3
M00_L86:
       call      qword ptr [7FF80D1D4930]
       mov       edx,eax
       mov       rcx,187D4401350
       mov       rcx,[rcx]
       mov       r8,187A5399E70
       xor       r9d,r9d
       call      qword ptr [7FF80D1D4948]
       mov       rcx,[rbp-68]
       jmp       near ptr M00_L39
M00_L87:
       call      qword ptr [7FF80D1D4960]
       mov       rcx,[rbp-68]
       jmp       near ptr M00_L40
M00_L88:
       xor       ebx,ebx
       jmp       near ptr M00_L43
M00_L89:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF80D1D5A28]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       near ptr M00_L42
M00_L90:
       call      qword ptr [7FF80D1DC720]
       int       3
M00_L91:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L92:
       sub       rsp,28
       cmp       dword ptr [rbp-28],0
       je        short M00_L93
       mov       rcx,[rbp-60]
       call      00007FF86CA5E040
       test      eax,eax
       je        short M00_L93
       mov       ecx,eax
       mov       rdx,[rbp-60]
       call      qword ptr [7FF80D1D5A28]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M00_L93:
       nop
       add       rsp,28
       ret
M00_L94:
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L96
       cmp       qword ptr [rbp-80],0
       jne       short M00_L95
       xor       ecx,ecx
       call      qword ptr [7FF80D1DCA38]
       int       3
M00_L95:
       mov       rcx,[rbp-80]
       call      00007FF86CA5E040
       test      eax,eax
       je        short M00_L96
       mov       ecx,eax
       mov       rdx,[rbp-80]
       call      qword ptr [7FF80D1D5A28]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M00_L96:
       nop
       add       rsp,28
       ret
; Total bytes of code 3212
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M01_L00
       ret
M01_L00:
       xor       edx,edx
       jmp       qword ptr [7FF80D1D5068]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
; Total bytes of code 26
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
; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       [rbp+10],rcx
       test      dl,dl
       jne       near ptr M03_L19
       or        dword ptr [rcx+34],10000
M03_L00:
       cmp       byte ptr [7FF80CD1B074],0
       jne       near ptr M03_L20
M03_L01:
       mov       rax,187D4401350
       mov       rbx,[rax]
       cmp       byte ptr [rbx+9D],0
       jne       near ptr M03_L21
M03_L02:
       mov       rsi,[rcx+18]
       cmp       [rsi],sil
       cmp       byte ptr [rbx+9D],0
       jne       near ptr M03_L11
M03_L03:
       mov       rdx,offset MT_System.Threading.Tasks.ThreadPoolTaskScheduler
       cmp       [rsi],rdx
       jne       near ptr M03_L17
       movzx     esi,word ptr [rcx+34]
       test      sil,2
       jne       near ptr M03_L12
       mov       rdx,187D4401358
       mov       rbx,[rdx]
       cmp       byte ptr [rbx+38],0
       jne       near ptr M03_L13
M03_L04:
       test      sil,1
       jne       short M03_L06
       mov       rax,gs:[58]
       mov       rax,[rax+48]
       cmp       dword ptr [rax+238],5
       jle       near ptr M03_L14
       mov       rax,[rax+240]
       mov       rax,[rax+28]
       test      rax,rax
       je        near ptr M03_L14
M03_L05:
       mov       rdx,[rax+10]
       test      rdx,rdx
       jne       short M03_L08
M03_L06:
       mov       rdx,[rbx+8]
       mov       r8,[rdx+10]
       mov       r10,[r8+8]
M03_L07:
       mov       esi,[r8+0A0]
       mov       eax,esi
       and       eax,[r8+18]
       cmp       eax,[r10+8]
       jae       near ptr M03_L15
       shl       rax,4
       lea       rdi,[r10+rax+10]
       mov       eax,[rdi+8]
       sub       eax,esi
       jne       short M03_L09
       lea       r9,[r8+0A0]
       lea       r11d,[rsi+1]
       mov       eax,esi
       lock cmpxchg [r9],r11d
       cmp       eax,esi
       jne       short M03_L07
       mov       rdx,[rbp+10]
       mov       rcx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       inc       esi
       mov       [rdi+8],esi
       jmp       short M03_L10
M03_L08:
       mov       rcx,[rdx+18]
       mov       rdx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF80D1D6130]; System.Threading.ThreadPoolWorkQueue+WorkStealingQueue.LocalPush(System.Object)
       jmp       short M03_L10
M03_L09:
       test      eax,eax
       jge       short M03_L07
       mov       rcx,rdx
       mov       rdx,[rbp+10]
       call      qword ptr [7FF80D1DC9A8]
M03_L10:
       add       rbx,78
       mov       ecx,1
       xchg      ecx,[rbx]
       test      ecx,ecx
       jne       near ptr M03_L18
       mov       rcx,187D4401380
       mov       rbx,[rcx]
       lea       rcx,[rbx+178]
       lock inc  dword ptr [rcx]
       mov       rcx,rbx
       call      qword ptr [7FF80D1D45E8]; System.Threading.PortableThreadPool+WorkerThread.MaybeAddWorkingWorker(System.Threading.PortableThreadPool)
       cmp       dword ptr [rbx+17C],6
       je        near ptr M03_L18
       jmp       near ptr M03_L16
M03_L11:
       mov       rdx,rsi
       call      qword ptr [7FF80D1DCC90]
       mov       rcx,[rbp+10]
       jmp       near ptr M03_L03
M03_L12:
       mov       rcx,offset MT_System.Threading.Tasks.ThreadPoolTaskScheduler
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,187D4401448
       mov       rbx,[rcx]
       mov       rcx,offset MT_System.Threading.Thread
       call      CORINFO_HELP_NEWFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF80D1DD980]
       mov       rcx,rsi
       mov       edx,1
       call      qword ptr [7FF80D1D4750]; System.Threading.Thread.set_IsBackground(Boolean)
       mov       rcx,rsi
       mov       rdx,187A5398C60
       call      qword ptr [7FF80D1D4858]; System.Threading.Thread.set_Name(System.String)
       mov       rcx,rsi
       mov       rdx,[rbp+10]
       xor       r8d,r8d
       call      qword ptr [7FF80D1DD998]
       jmp       short M03_L18
M03_L13:
       mov       rdx,187D4401370
       mov       rdx,[rdx]
       cmp       byte ptr [rdx+9D],0
       je        near ptr M03_L04
       mov       rdx,187D4401370
       mov       rcx,[rdx]
       mov       rdx,[rbp+10]
       call      qword ptr [7FF80D1DC978]
       jmp       near ptr M03_L04
M03_L14:
       mov       ecx,5
       call      qword ptr [7FF80D1DC990]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M03_L05
M03_L15:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M03_L16:
       mov       rcx,rbx
       call      qword ptr [7FF80D1D47C8]; System.Threading.PortableThreadPool+GateThread.EnsureRunningSlow(System.Threading.PortableThreadPool)
       jmp       short M03_L18
M03_L17:
       mov       rcx,rsi
       mov       rdx,[rbp+10]
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       nop
M03_L18:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L19:
       call      qword ptr [7FF80D1DD968]
       test      eax,eax
       mov       rcx,[rbp+10]
       jne       near ptr M03_L00
       jmp       short M03_L18
M03_L20:
       call      qword ptr [7FF80D1D4960]
       mov       rcx,[rbp+10]
       jmp       near ptr M03_L01
M03_L21:
       test      word ptr [rcx+34],200
       jne       near ptr M03_L02
       call      qword ptr [7FF80D1D4930]
       mov       esi,eax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       call      qword ptr [7FF80D1DCC00]
       mov       rdx,rax
       mov       rcx,187A5398BD8
       call      qword ptr [7FF80CDDD9C8]; System.String.Concat(System.String, System.String)
       mov       r8,rax
       mov       edx,esi
       mov       rcx,rbx
       xor       r9d,r9d
       call      qword ptr [7FF80D1D4948]
       mov       rcx,[rbp+10]
       jmp       near ptr M03_L02
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_System.Threading.Tasks.TaskSchedulerException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF80D1DCC18]
       mov       rcx,[rbp+10]
       mov       rdx,rsi
       call      qword ptr [7FF80D1DCC30]
       mov       rcx,[rbp+10]
       xor       edx,edx
       call      qword ptr [7FF80D1DCC48]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80D1DCC60]
       test      eax,200
       jne       short M03_L22
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+28]
       mov       rcx,[rcx+18]
       xor       edx,edx
       cmp       [rcx],ecx
       call      qword ptr [7FF80D1DCC78]
M03_L22:
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 869
```
```assembly
; AsyncLazyBenchmarks.ContendedFirstCallBenchmarks+<>c__DisplayClass9_0.<AsyncLazy>b__0()
       mov       rcx,[rcx+8]
       mov       rax,[rcx+10]
       test      rax,rax
       jne       short M04_L00
       xor       edx,edx
       jmp       qword ptr [7FF80D1D5518]; System.Threading.Tasks.AsyncLazy`1[[System.Int32, System.Private.CoreLib]].GetOrStartAttemptAsync(System.Threading.CancellationToken)
M04_L00:
       ret
; Total bytes of code 22
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M05_L02
       lea       rax,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       mov       rdx,[rcx+30]
       test      r8,r8
       je        short M05_L01
       cmp       rdx,[r8]
       je        short M05_L00
       mov       r10,offset MT_System.Object[]
       cmp       rcx,r10
       je        short M05_L00
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FF80D0B4EB8]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
M05_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FF86CA540D0
M05_L01:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M05_L02:
       call      qword ptr [7FF80D1DC528]
       int       3
; Total bytes of code 94
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M06_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M06_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M06_L02
M06_L00:
       test      rax,rax
       je        short M06_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M06_L02
       test      rax,rax
       je        short M06_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M06_L02
       test      rax,rax
       je        short M06_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M06_L02
       test      rax,rax
       jne       short M06_L03
M06_L01:
       xor       edx,edx
M06_L02:
       mov       rax,rdx
       ret
M06_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M06_L02
       jmp       short M06_L00
; Total bytes of code 86
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
       mov       rax,7FF80CE18210
       mov       [rbp-60],rax
       lea       rax,[M07_L00]
       mov       [rbp-50],rax
       lea       rax,[rbp-70]
       mov       [rbx+8],rax
       mov       byte ptr [rbx+4],0
       mov       rax,7FF86CA5E560
       call      rax
M07_L00:
       mov       byte ptr [rbx+4],1
       cmp       dword ptr [7FF86CD13A90],0
       je        short M07_L01
       call      qword ptr [7FF86CD02648]; CORINFO_HELP_STOP_FOR_GC
M07_L01:
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
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAll(System.Predicate`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M08_L04
       nop       dword ptr [rax]
       xor       edi,edi
       cmp       dword ptr [rbx+10],0
       jle       short M08_L01
       mov       rdx,offset System.Threading.Tasks.Task+<>c.<AddTaskContinuationComplex>b__211_0(System.Object)
       cmp       [rsi+18],rdx
       jne       short M08_L02
       nop
M08_L00:
       mov       rdx,[rbx+8]
       cmp       edi,[rdx+8]
       jae       near ptr M08_L11
       mov       ecx,edi
       mov       rdx,[rdx+rcx*8+10]
       test      rdx,rdx
       je        short M08_L01
       inc       edi
       cmp       edi,[rbx+10]
       jl        short M08_L00
M08_L01:
       cmp       edi,[rbx+10]
       jl        short M08_L06
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M08_L02:
       mov       rdx,[rbx+8]
       cmp       edi,[rdx+8]
       jae       near ptr M08_L11
       mov       ecx,edi
       mov       rdx,[rdx+rcx*8+10]
       mov       rcx,offset System.Threading.Tasks.Task+<>c.<AddTaskContinuationComplex>b__211_0(System.Object)
       cmp       [rsi+18],rcx
       jne       short M08_L05
       test      rdx,rdx
       je        short M08_L01
M08_L03:
       inc       edi
       cmp       edi,[rbx+10]
       jge       short M08_L01
       jmp       short M08_L02
M08_L04:
       mov       ecx,1A
       call      qword ptr [7FF80CDDFD38]
       int       3
M08_L05:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M08_L03
       jmp       short M08_L01
M08_L06:
       lea       ebp,[rdi+1]
       jmp       short M08_L10
M08_L07:
       inc       ebp
M08_L08:
       cmp       ebp,[rbx+10]
       jge       short M08_L09
       mov       rdx,[rbx+8]
       cmp       ebp,[rdx+8]
       jae       short M08_L11
       mov       ecx,ebp
       mov       rdx,[rdx+rcx*8+10]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M08_L07
M08_L09:
       cmp       ebp,[rbx+10]
       jge       short M08_L10
       mov       edx,edi
       lea       edi,[rdx+1]
       mov       ecx,ebp
       lea       ebp,[rcx+1]
       mov       r8,[rbx+8]
       mov       rax,[rbx+8]
       cmp       ecx,[rax+8]
       jae       short M08_L11
       mov       rax,[rax+rcx*8+10]
       mov       rcx,r8
       mov       r8,rax
       movsxd    rdx,edx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M08_L10:
       cmp       ebp,[rbx+10]
       jl        short M08_L08
       mov       r8d,[rbx+10]
       sub       r8d,edi
       mov       rcx,[rbx+8]
       mov       edx,edi
       call      qword ptr [7FF80D1DD6B0]
       mov       eax,[rbx+10]
       sub       eax,edi
       mov       [rbx+10],edi
       inc       dword ptr [rbx+14]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M08_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 307
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,[rbx+10]
       mov       ebp,edi
       lea       ecx,[rbp+1]
       mov       r14,[rbx+8]
       cmp       dword ptr [r14+8],0
       jne       near ptr M09_L04
       mov       r15d,4
M09_L00:
       mov       edx,7FFFFFC7
       cmp       r15d,7FFFFFC7
       cmova     r15d,edx
       cmp       r15d,ecx
       cmovl     r15d,ecx
       cmp       r15d,edi
       jl        near ptr M09_L07
       cmp       [r14+8],r15d
       je        short M09_L03
       test      r15d,r15d
       jle       near ptr M09_L08
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+40]
       test      rax,rax
       je        short M09_L05
       mov       rcx,rax
M09_L01:
       mov       edx,r15d
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r15,rax
       test      edi,edi
       jg        short M09_L06
M09_L02:
       lea       rcx,[rbx+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M09_L03:
       lea       ecx,[rbp+1]
       mov       [rbx+10],ecx
       mov       rcx,[rbx+8]
       movsxd    rdx,ebp
       mov       r8,rsi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M09_L04:
       mov       r15d,[r14+8]
       add       r15d,r15d
       jmp       near ptr M09_L00
M09_L05:
       mov       rdx,7FF80D1FCF10
       call      qword ptr [7FF80CDDF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M09_L01
M09_L06:
       mov       rcx,r14
       mov       r8d,edi
       mov       rdx,r15
       call      qword ptr [7FF80CDDF588]; System.Array.Copy(System.Array, System.Array, Int32)
       jmp       short M09_L02
M09_L07:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FF80D145800]
       int       3
M09_L08:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+38]
       test      rdx,rdx
       je        short M09_L09
       jmp       short M09_L10
M09_L09:
       mov       rdx,7FF80D1FCF00
       call      qword ptr [7FF80CDDF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M09_L10:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M09_L03
; Total bytes of code 315
```
```assembly
; System.Threading.Tasks.Task+<>c.<AddTaskContinuationComplex>b__211_0(System.Object)
       test      rdx,rdx
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 10
```
```assembly
; System.Threading.Tasks.Task+WhenAllPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rbx,rcx
       mov       rcx,187D4401350
       mov       rsi,[rcx]
       cmp       byte ptr [rsi+9D],0
       jne       near ptr M11_L12
M11_L00:
       lea       rdx,[rbx+48]
       mov       ecx,0FFFFFFFF
       lock xadd [rdx],ecx
       dec       ecx
       je        short M11_L02
M11_L01:
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M11_L02:
       mov       rdx,[rbx+40]
       mov       edx,[rdx+8]
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       xor       ebp,ebp
       xor       r14d,r14d
       xor       r15d,r15d
M11_L03:
       mov       rcx,[rbx+40]
       cmp       [rcx+8],r15d
       jle       near ptr M11_L09
       cmp       r15d,[rcx+8]
       jae       near ptr M11_L24
       mov       r13d,r15d
       mov       r12,[rcx+r13*8+10]
       test      dword ptr [r12+34],200000
       jne       near ptr M11_L13
       mov       ecx,[r12+34]
       and       ecx,600000
       cmp       ecx,400000
       je        near ptr M11_L16
       test      dword ptr [r12+34],1600000
       je        near ptr M11_L17
M11_L04:
       mov       ecx,[r12+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       near ptr M11_L18
M11_L05:
       mov       ecx,[r12+38]
       cmp       r15d,[rdi+8]
       jae       near ptr M11_L24
       mov       [rdi+r13*4+10],ecx
M11_L06:
       test      dword ptr [r12+34],10000000
       jne       short M11_L08
       mov       rax,[rbx+40]
       cmp       r15d,[rax+8]
       jae       near ptr M11_L24
       xor       ecx,ecx
       mov       [rax+r13*8+10],rcx
M11_L07:
       inc       r15d
       jmp       near ptr M11_L03
M11_L08:
       mov       eax,[rbx+34]
       mov       [rsp+34],eax
       test      eax,5600000
       jne       short M11_L07
       lea       rcx,[rbx+34]
       mov       edx,eax
       or        edx,10000000
       lock cmpxchg [rcx],edx
       cmp       eax,[rsp+34]
       je        short M11_L07
       jmp       near ptr M11_L19
M11_L09:
       test      rbp,rbp
       jne       near ptr M11_L20
       test      r14,r14
       jne       near ptr M11_L21
       cmp       byte ptr [rsi+9D],0
       jne       near ptr M11_L22
M11_L10:
       cmp       byte ptr [7FF80CD1B074],0
       jne       near ptr M11_L23
M11_L11:
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7FF80D1D6370]; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].TrySetResult(System.__Canon)
       jmp       near ptr M11_L01
M11_L12:
       mov       rcx,rbx
       call      qword ptr [7FF80D1D4930]
       mov       edx,eax
       mov       rcx,rsi
       mov       r8d,1
       call      qword ptr [7FF80D1D61A8]
       jmp       near ptr M11_L00
M11_L13:
       test      rbp,rbp
       jne       short M11_L14
       mov       rcx,offset MT_System.Collections.Generic.List<System.Runtime.ExceptionServices.ExceptionDispatchInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FF80D0BC4C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
M11_L14:
       mov       rcx,[r12+28]
       mov       rax,[rcx+18]
       mov       [rsp+28],rax
       mov       rdx,[rax+10]
       mov       [rsp+20],rdx
       cmp       byte ptr [rax+20],0
       jne       short M11_L15
       mov       rcx,rax
       call      qword ptr [7FF80D0B55F0]; System.GC.SuppressFinalize(System.Object)
       mov       rcx,[rsp+28]
       mov       byte ptr [rcx+20],1
M11_L15:
       mov       rcx,rbp
       mov       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF80D1D6310]
       jmp       near ptr M11_L06
M11_L16:
       test      r14,r14
       jne       near ptr M11_L06
       mov       r14,r12
       jmp       near ptr M11_L06
M11_L17:
       mov       rcx,r12
       mov       edx,0FFFFFFFF
       xor       r8d,r8d
       call      qword ptr [7FF80D1D5080]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
       jmp       near ptr M11_L04
M11_L18:
       mov       rcx,r12
       mov       edx,1
       call      qword ptr [7FF80D1DD920]
       jmp       near ptr M11_L05
M11_L19:
       mov       rcx,rbx
       mov       edx,10000000
       mov       r8d,5600000
       call      qword ptr [7FF80D1DCA50]
       jmp       near ptr M11_L07
M11_L20:
       mov       rcx,rbx
       mov       rdx,rbp
       call      qword ptr [7FF80D1D6280]
       jmp       near ptr M11_L01
M11_L21:
       mov       rcx,r14
       call      qword ptr [7FF80D1D61C0]
       mov       rbp,rax
       mov       rcx,r14
       call      qword ptr [7FF80D1D61D8]
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      qword ptr [7FF80D1D61F0]
       jmp       near ptr M11_L01
M11_L22:
       mov       rcx,rbx
       call      qword ptr [7FF80D1D4930]
       mov       edx,eax
       mov       rcx,rsi
       mov       r8d,1
       call      qword ptr [7FF80D1D6298]
       jmp       near ptr M11_L10
M11_L23:
       mov       rcx,rbx
       call      qword ptr [7FF80D1D62B0]
       jmp       near ptr M11_L11
M11_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 705
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
       jne       short M12_L01
       cmp       [rax],ecx
       jle       short M12_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M12_L03
M12_L00:
       add       rsp,20
       pop       rbx
       ret
M12_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M12_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M12_L00
M12_L02:
       cmp       [rax+4],edx
       jle       short M12_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M12_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M12_L03
       jmp       short M12_L00
M12_L03:
       mov       ecx,ebx
       lea       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].ProcessCompletedOuterTask(System.Threading.Tasks.Task)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       byte ptr [rbx+3C],1
       mov       edx,[rsi+34]
       test      edx,200000
       jne       near ptr M13_L07
       test      edx,400000
       jne       near ptr M13_L08
       test      edx,1000000
       je        near ptr M13_L09
       mov       edi,5
M13_L00:
       cmp       edi,5
       jne       near ptr M13_L12
       mov       rcx,rsi
       mov       rax,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task<System.Int32>>
       cmp       [rcx],rax
       jne       near ptr M13_L13
M13_L01:
       test      rcx,rcx
       je        near ptr M13_L14
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       near ptr M13_L16
       mov       rdi,[rcx+38]
M13_L02:
       test      rdi,rdi
       je        near ptr M13_L17
       test      dword ptr [rdi+34],1600000
       je        short M13_L05
       mov       rcx,rbx
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FF80D1D5890]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
M13_L03:
       mov       byte ptr [rbx+3C],2
M13_L04:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M13_L05:
       test      dword ptr [rdi+34],1600000
       jne       near ptr M13_L19
       cmp       qword ptr [rdi+20],0
       jne       short M13_L06
       lea       rcx,[rdi+20]
       test      rcx,rcx
       je        near ptr M13_L18
       mov       rdx,rbx
       xor       r8d,r8d
       call      00007FF86CA021C0
       test      rax,rax
       je        short M13_L04
M13_L06:
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FF80D1D5920]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       short M13_L04
       jmp       near ptr M13_L19
M13_L07:
       mov       edi,7
       jmp       near ptr M13_L00
M13_L08:
       mov       edi,6
       jmp       near ptr M13_L00
M13_L09:
       test      edx,800000
       je        short M13_L10
       mov       edi,4
       jmp       near ptr M13_L00
M13_L10:
       test      edx,20000
       je        short M13_L11
       mov       edi,3
       jmp       near ptr M13_L00
M13_L11:
       test      edx,2000000
       setne     dil
       movzx     edi,dil
       mov       ecx,2
       test      edx,10000
       cmovne    edi,ecx
       jmp       near ptr M13_L00
M13_L12:
       add       edi,0FFFFFFFA
       cmp       edi,1
       ja        near ptr M13_L04
       movzx     r8d,byte ptr [rbx+3D]
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF80D1D5890]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       jmp       near ptr M13_L04
M13_L13:
       mov       rdx,rsi
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rcx,rax
       jmp       near ptr M13_L01
M13_L14:
       mov       rcx,rsi
       mov       rax,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task>
       cmp       [rcx],rax
       je        short M13_L15
       mov       rdx,rsi
       mov       rcx,rax
       call      qword ptr [7FF80CFB4D20]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rcx,rax
M13_L15:
       cmp       [rcx],ecx
       call      qword ptr [7FF80D1D58C0]; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].get_Result()
       mov       rdi,rax
       jmp       near ptr M13_L02
M13_L16:
       mov       edx,1
       call      qword ptr [7FF80D1DCE28]
       mov       rdi,rax
       jmp       near ptr M13_L02
M13_L17:
       mov       rcx,rbx
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FF80D1D61F0]
       jmp       near ptr M13_L03
M13_L18:
       call      qword ptr [7FF80D1DC720]
       int       3
M13_L19:
       mov       rcx,rbx
       mov       rdx,rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF80D1C9C90]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
; Total bytes of code 499
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
       sub       rsp,58
       vzeroupper
       lea       rbp,[rsp+90]
       mov       [rbp+18],rdx
       mov       ebx,ecx
       lea       rcx,[rbp-70]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-58],rcx
       mov       rcx,rbp
       mov       [rbp-48],rcx
       lea       rcx,[rbp+18]
       mov       edx,ebx
       mov       rax,7FF80CE18350
       mov       [rbp-60],rax
       lea       rax,[M14_L00]
       mov       [rbp-50],rax
       lea       rax,[rbp-70]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF86CA5E630
       call      rax
M14_L00:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF86CD13A90],0
       je        short M14_L01
       call      qword ptr [7FF86CD02648]; CORINFO_HELP_STOP_FOR_GC
M14_L01:
       mov       rax,[rbp-68]
       mov       [rsi+8],rax
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
; Total bytes of code 158
```
```assembly
; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
M15_L00:
       mov       rcx,187D4401350
       mov       rbp,[rcx]
       cmp       byte ptr [rbp+9D],0
       jne       near ptr M15_L12
M15_L01:
       xor       eax,eax
       mov       ecx,[rsi+34]
       test      ecx,200000
       jne       near ptr M15_L13
       test      ecx,400000
       jne       near ptr M15_L14
       test      ecx,1000000
       je        near ptr M15_L15
       mov       edx,5
M15_L02:
       add       edx,0FFFFFFFB
       jne       near ptr M15_L18
       cmp       byte ptr [rbp+9D],0
       jne       near ptr M15_L20
M15_L03:
       cmp       byte ptr [7FF80CD1B074],0
       jne       near ptr M15_L21
M15_L04:
       mov       rcx,rsi
       mov       rax,offset MT_System.Threading.Tasks.Task<System.Int32>
       cmp       [rcx],rax
       jne       near ptr M15_L22
M15_L05:
       test      rcx,rcx
       je        near ptr M15_L23
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       near ptr M15_L24
       mov       esi,[rcx+38]
M15_L06:
       xor       edi,edi
       mov       eax,[rbx+34]
       mov       [rsp+24],eax
       test      eax,5600000
       jne       short M15_L10
       lea       rcx,[rbx+34]
       mov       edx,eax
       or        edx,4000000
       lock cmpxchg [rcx],edx
       cmp       eax,[rsp+24]
       jne       near ptr M15_L25
M15_L07:
       mov       [rbx+38],esi
       lea       rcx,[rbx+34]
       mov       eax,[rbx+34]
       or        eax,1000000
       xchg      eax,[rcx]
       mov       rdi,[rbx+28]
       test      rdi,rdi
       jne       near ptr M15_L26
M15_L08:
       lea       rcx,[rbx+20]
       test      rcx,rcx
       je        near ptr M15_L27
       mov       rdx,187D4400218
       mov       rdx,[rdx]
       call      00007FF86CA0C330
       test      rax,rax
       je        short M15_L09
       mov       rcx,rbx
       mov       rdx,rax
       call      qword ptr [7FF80D1D57E8]; System.Threading.Tasks.Task.RunContinuations(System.Object)
M15_L09:
       mov       edi,1
M15_L10:
       mov       eax,edi
M15_L11:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M15_L12:
       mov       rcx,rbx
       call      qword ptr [7FF80D1D4930]
       mov       edx,eax
       mov       rcx,rbp
       mov       r8d,1
       call      qword ptr [7FF80D1D61A8]
       jmp       near ptr M15_L01
M15_L13:
       mov       edx,7
       jmp       near ptr M15_L02
M15_L14:
       mov       edx,6
       jmp       near ptr M15_L02
M15_L15:
       test      ecx,800000
       je        short M15_L16
       mov       edx,4
       jmp       near ptr M15_L02
M15_L16:
       test      ecx,20000
       je        short M15_L17
       mov       edx,3
       jmp       near ptr M15_L02
M15_L17:
       test      ecx,2000000
       setne     dl
       movzx     edx,dl
       mov       r8d,2
       test      ecx,10000
       cmovne    edx,r8d
       jmp       near ptr M15_L02
M15_L18:
       cmp       edx,2
       ja        near ptr M15_L11
       mov       ecx,edx
       lea       rax,[7FF80CE5BA30]
       mov       eax,[rax+rcx*4]
       lea       rdx,[M15_L00]
       add       rax,rdx
       jmp       rax
       mov       rcx,rsi
       call      qword ptr [7FF80D1D61C0]
       mov       rdi,rax
       mov       rcx,rsi
       call      qword ptr [7FF80D1D61D8]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF80D1D61F0]
       jmp       near ptr M15_L11
       mov       rcx,rsi
       call      qword ptr [7FF80D1D6208]
       mov       rsi,rax
       test      dil,dil
       je        short M15_L19
       cmp       dword ptr [rsi+10],0
       jle       short M15_L19
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF80CEC3578]
       mov       rbp,rax
       test      rbp,rbp
       je        short M15_L19
       mov       rdx,[rbp+8]
       mov       rcx,offset MT_System.OperationCanceledException
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M15_L19
       mov       rdx,[rax+70]
       mov       rcx,rbx
       mov       r8,rbp
       call      qword ptr [7FF80D1D61F0]
       jmp       near ptr M15_L11
M15_L19:
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF80D1D6280]
       jmp       near ptr M15_L11
M15_L20:
       mov       rcx,rbx
       call      qword ptr [7FF80D1D4930]
       mov       edx,eax
       mov       rcx,rbp
       mov       r8d,1
       call      qword ptr [7FF80D1D6298]
       jmp       near ptr M15_L03
M15_L21:
       mov       rcx,rbx
       call      qword ptr [7FF80D1D62B0]
       jmp       near ptr M15_L04
M15_L22:
       mov       rdx,rsi
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rcx,rax
       jmp       near ptr M15_L05
M15_L23:
       xor       esi,esi
       jmp       near ptr M15_L06
M15_L24:
       mov       edx,1
       call      qword ptr [7FF80D1D6328]; System.Threading.Tasks.Task`1[[System.Int32, System.Private.CoreLib]].GetResultCore(Boolean)
       mov       esi,eax
       jmp       near ptr M15_L06
M15_L25:
       mov       rcx,rbx
       mov       edx,4000000
       mov       r8d,5600000
       call      qword ptr [7FF80D1DCA50]
       test      eax,eax
       je        near ptr M15_L10
       jmp       near ptr M15_L07
M15_L26:
       mov       rcx,rbx
       call      qword ptr [7FF80D1DCA68]
       mov       rcx,rdi
       call      qword ptr [7FF80D1DCA80]
       jmp       near ptr M15_L08
M15_L27:
       call      qword ptr [7FF80D1DC720]
       int       3
; Total bytes of code 765
```
```assembly
; System.Threading.Tasks.Task.get_Status()
       mov       eax,[rcx+34]
       test      eax,200000
       jne       short M16_L01
       test      eax,400000
       jne       short M16_L02
       test      eax,1000000
       je        short M16_L03
       mov       eax,5
M16_L00:
       ret
M16_L01:
       mov       eax,7
       jmp       short M16_L00
M16_L02:
       mov       eax,6
       jmp       short M16_L00
M16_L03:
       test      eax,800000
       je        short M16_L04
       mov       eax,4
       jmp       short M16_L00
M16_L04:
       test      eax,20000
       je        short M16_L05
       mov       eax,3
       jmp       short M16_L00
M16_L05:
       test      eax,2000000
       setne     cl
       movzx     ecx,cl
       mov       edx,2
       test      eax,10000
       mov       eax,edx
       cmove     eax,ecx
       jmp       short M16_L00
; Total bytes of code 100
```
```assembly
; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].ProcessInnerTask(System.Threading.Tasks.Task)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        short M17_L04
       test      dword ptr [rbx+34],1600000
       je        short M17_L02
       mov       rcx,rsi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FF80D1D5890]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
M17_L00:
       mov       byte ptr [rsi+3C],2
M17_L01:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M17_L02:
       test      dword ptr [rbx+34],1600000
       jne       short M17_L06
       cmp       qword ptr [rbx+20],0
       jne       short M17_L03
       lea       rcx,[rbx+20]
       test      rcx,rcx
       je        short M17_L05
       mov       rdx,rsi
       xor       r8d,r8d
       call      00007FF86CA021C0
       test      rax,rax
       je        short M17_L01
M17_L03:
       mov       rcx,rbx
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF80D1D5920]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       short M17_L01
       jmp       short M17_L06
M17_L04:
       mov       rcx,rsi
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FF80D1D61F0]
       jmp       short M17_L00
M17_L05:
       call      qword ptr [7FF80D1DC720]
       int       3
M17_L06:
       mov       rcx,rsi
       mov       rdx,rbx
       cmp       [rcx],ecx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF80D1C9C90]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
; Total bytes of code 157
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      dword ptr [rbx+34],1600000
       jne       short M18_L00
       mov       rcx,rbx
       mov       edx,0FFFFFFFF
       xor       r8d,r8d
       call      qword ptr [7FF80D1D5080]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M18_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M18_L03
M18_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M18_L04
M18_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M18_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M18_L01
       mov       rcx,rbx
       call      qword ptr [7FF80D1DD4D0]
       jmp       short M18_L01
M18_L04:
       test      sil,2
       jne       short M18_L05
       mov       rcx,rbx
       call      qword ptr [7FF80D1DD4E8]
M18_L05:
       mov       rcx,rbx
       call      qword ptr [7FF80D1DDDA0]
       jmp       short M18_L02
; Total bytes of code 124
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.ContendedFirstCallBenchmarks.Nito()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-40],ymm4
       mov       [rbp+10],rcx
       mov       rcx,offset MT_AsyncLazyBenchmarks.ContendedFirstCallBenchmarks+<>c__DisplayClass10_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-30],rax
       mov       rcx,offset MT_Nito.AsyncEx.AsyncLazy<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,2BDDB401300
       mov       rsi,[rcx]
       mov       rdx,rsi
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_Nito.AsyncEx.AsyncLazy<System.Int32>+<>c__DisplayClass14_0
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Func<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset Nito.AsyncEx.AsyncLazy`1+<>c__DisplayClass14_0[[System.Int32, System.Private.CoreLib]].<RunOnThreadPool>b__0()
       mov       [rsi+18],rcx
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Lazy<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,[rbx+10]
       lea       rcx,[rsi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.LazyHelper
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+10],8
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-30]
       lea       rcx,[rax+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbp-1C],ecx
M00_L00:
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+8]
       mov       eax,[rbx+8]
       cmp       eax,[rbp-1C]
       jle       near ptr M00_L38
       mov       rax,[rbp-30]
       mov       rsi,[rax+10]
       mov       [rbp-38],rbx
       test      rsi,rsi
       je        near ptr M00_L08
M00_L01:
       mov       rdx,2BDDB401320
       mov       rdx,[rdx]
       test      rdx,rdx
       je        near ptr M00_L46
M00_L02:
       cmp       [rdx],dl
       mov       rdx,2BDDB401330
       mov       rbx,[rdx]
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-48],rax
       mov       rcx,[rbp-48]
       lea       rcx,[rcx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-48]
       xor       edx,edx
       mov       [rcx+10],rdx
       mov       rcx,[rbp-48]
       lea       rcx,[rcx+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,2008
       mov       rax,[rbp-48]
       mov       [rax+34],ecx
       mov       rcx,gs:[58]
       mov       rcx,[rcx+48]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M00_L47
       mov       rcx,[rcx+240]
       mov       rax,[rcx+20]
       test      rax,rax
       je        near ptr M00_L47
M00_L03:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M00_L04
       call      qword ptr [7FF80D095458]; System.Threading.Thread.InitializeCurrentThread()
M00_L04:
       mov       rbx,[rax+8]
       test      rbx,rbx
       jne       near ptr M00_L09
       mov       rcx,2BDDB401340
       mov       rbx,[rcx]
M00_L05:
       test      rbx,rbx
       jne       near ptr M00_L10
       mov       rcx,[rbp-48]
       or        dword ptr [rcx+34],20000000
M00_L06:
       mov       rcx,[rbp-48]
       xor       edx,edx
       call      qword ptr [7FF80D1B4168]; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
       mov       rcx,offset MT_System.Threading.Tasks.UnwrapPromise<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rcx,[rbp-48]
       movzx     ebx,word ptr [rcx+34]
       and       ebx,4
       test      ebx,0FFFFFFBB
       je        near ptr M00_L12
M00_L07:
       mov       ecx,2D
       call      qword ptr [7FF80CDBF348]
       int       3
M00_L08:
       mov       rcx,offset MT_System.Func<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset AsyncLazyBenchmarks.ContendedFirstCallBenchmarks+<>c__DisplayClass10_0.<Nito>b__0()
       mov       [rsi+18],rcx
       mov       rdx,[rbp-30]
       lea       rcx,[rdx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L09:
       cmp       byte ptr [rbx+18],0
       je        near ptr M00_L05
       xor       ebx,ebx
       jmp       near ptr M00_L05
M00_L10:
       mov       rcx,2BDDB401340
       cmp       rbx,[rcx]
       je        near ptr M00_L06
       mov       rcx,[rbp-48]
       mov       rax,[rcx+28]
       test      rax,rax
       jne       short M00_L11
       mov       rcx,offset MT_System.Threading.Tasks.Task+ContingentProperties
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+3C],1
       mov       rcx,[rbp-48]
       lea       rcx,[rcx+28]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
M00_L11:
       lea       rcx,[rax+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L06
M00_L12:
       test      bl,4
       je        near ptr M00_L15
       mov       rcx,gs:[58]
       mov       rcx,[rcx+48]
       cmp       dword ptr [rcx+238],8
       jle       near ptr M00_L48
       mov       rcx,[rcx+240]
       mov       rax,[rcx+40]
       test      rax,rax
       je        near ptr M00_L48
M00_L13:
       mov       rsi,[rax+10]
       test      rsi,rsi
       je        short M00_L15
       mov       rcx,[rbp-40]
       mov       rax,[rcx+28]
       test      rax,rax
       jne       short M00_L14
       mov       rcx,offset MT_System.Threading.Tasks.Task+ContingentProperties
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+3C],1
       mov       rcx,[rbp-40]
       lea       rcx,[rcx+28]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
M00_L14:
       lea       rcx,[rax+30]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M00_L15:
       mov       rcx,[rbp-40]
       xor       eax,eax
       mov       [rcx+8],rax
       mov       rcx,[rbp-40]
       mov       [rcx+10],rax
       mov       rcx,[rbp-40]
       mov       [rcx+18],rax
       test      ebx,0FFFFFFA0
       jne       near ptr M00_L07
       mov       ecx,ebx
       or        ecx,400
       or        ecx,2000000
       mov       rax,[rbp-40]
       mov       [rax+34],ecx
       mov       rcx,[rbp-40]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       jne       near ptr M00_L49
M00_L16:
       mov       rcx,[rbp-40]
       mov       byte ptr [rcx+3D],1
       mov       rcx,2BDDB401350
       mov       rcx,[rcx]
       cmp       byte ptr [rcx+9D],0
       jne       near ptr M00_L50
M00_L17:
       cmp       byte ptr [7FF80CCFB074],0
       jne       near ptr M00_L51
M00_L18:
       mov       rcx,[rbp-48]
       test      dword ptr [rcx+34],1600000
       jne       near ptr M00_L52
       mov       rcx,[rbp-48]
       test      dword ptr [rcx+34],1600000
       jne       near ptr M00_L34
       mov       rcx,[rbp-48]
       cmp       qword ptr [rcx+20],0
       jne       short M00_L20
       mov       rcx,[rbp-48]
       add       rcx,20
       test      rcx,rcx
       je        near ptr M00_L62
       mov       rdx,[rbp-40]
       xor       r8d,r8d
       call      00007FF86CA021C0
       test      rax,rax
       jne       short M00_L20
M00_L19:
       movsxd    rdx,dword ptr [rbp-1C]
       mov       rcx,[rbp-38]
       mov       r8,[rbp-40]
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       eax,[rbp-1C]
       inc       eax
       mov       [rbp-1C],eax
       jmp       near ptr M00_L00
M00_L20:
       mov       rdx,[rbp-48]
       mov       rbx,[rdx+20]
       mov       rdx,2BDDB400218
       mov       rsi,[rdx]
       cmp       rbx,rsi
       je        near ptr M00_L53
       mov       rdi,rbx
       test      rdi,rdi
       je        short M00_L21
       mov       rdx,offset MT_System.Threading.Tasks.UnwrapPromise<System.Int32>
       cmp       [rdi],rdx
       jne       near ptr M00_L44
       xor       edi,edi
M00_L21:
       test      rdi,rdi
       jne       near ptr M00_L23
       mov       rcx,offset MT_System.Collections.Generic.List<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,2BDDB400A60
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rdi+14]
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [7FF80CDB71C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       near ptr M00_L45
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       mov       edx,edx
       mov       r8,[rbp-40]
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M00_L22:
       mov       rcx,[rbp-48]
       add       rcx,20
       test      rcx,rcx
       je        near ptr M00_L62
       mov       rdx,rdi
       mov       r8,rbx
       call      00007FF86CA021C0
       mov       rdi,rax
       cmp       rdi,rbx
       je        near ptr M00_L32
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.Generic.List<System.Object>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M00_L53
M00_L23:
       mov       [rbp-50],rdi
       xor       ecx,ecx
       mov       [rbp-20],ecx
       mov       rcx,rdi
       call      00007FF86CA5E120
       test      eax,eax
       je        short M00_L27
M00_L24:
       mov       dword ptr [rbp-20],1
       mov       rcx,[rbp-48]
       cmp       [rcx+20],rsi
       je        short M00_L26
       mov       ecx,[rdi+10]
       mov       rax,[rdi+8]
       cmp       ecx,[rax+8]
       je        short M00_L28
M00_L25:
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       near ptr M00_L30
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       mov       edx,edx
       mov       r8,[rbp-40]
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M00_L31
M00_L26:
       xor       ecx,ecx
       mov       [rbp-24],ecx
       jmp       near ptr M00_L36
M00_L27:
       mov       rcx,rdi
       call      qword ptr [7FF80D1B5500]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L24
M00_L28:
       mov       rcx,2BDDB400270
       mov       rdx,[rcx]
       test      rdx,rdx
       jne       short M00_L29
       mov       rcx,offset MT_System.Predicate<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,2BDDB400240
       mov       rdx,[rcx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset System.Threading.Tasks.Task+<>c.<AddTaskContinuationComplex>b__211_0(System.Object)
       mov       [rbx+18],rcx
       mov       rcx,2BDDB400270
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rbx
M00_L29:
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FF80D1B57D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAll(System.Predicate`1<System.__Canon>)
       jmp       near ptr M00_L25
M00_L30:
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FF80CDB71C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       nop
M00_L31:
       mov       rcx,rdi
       call      00007FF86CA5E040
       test      eax,eax
       jne       near ptr M00_L54
M00_L32:
       mov       ebx,1
M00_L33:
       test      ebx,ebx
       jne       near ptr M00_L19
M00_L34:
       call      00007FF86CA10B20
       test      eax,eax
       je        near ptr M00_L61
       mov       rcx,[rbp-40]
       movzx     ebx,byte ptr [rcx+3C]
       test      ebx,ebx
       jne       near ptr M00_L55
       mov       rcx,[rbp-40]
       mov       byte ptr [rcx+3C],1
       mov       rcx,[rbp-48]
       call      qword ptr [7FF80D1B5668]; System.Threading.Tasks.Task.get_Status()
       cmp       eax,5
       jne       near ptr M00_L56
       mov       rcx,[rbp-48]
       mov       ecx,[rcx+34]
       and       ecx,11000000
       cmp       ecx,1000000
       jne       near ptr M00_L57
       mov       rcx,[rbp-48]
       mov       rdx,[rcx+38]
M00_L35:
       test      rdx,rdx
       je        near ptr M00_L58
       test      dword ptr [rdx+34],1600000
       je        near ptr M00_L60
       jmp       near ptr M00_L59
M00_L36:
       call      M00_L67
       nop
       mov       ebx,[rbp-24]
       jmp       near ptr M00_L33
M00_L37:
       mov       rcx,[rbp-40]
       mov       byte ptr [rcx+3C],2
       jmp       near ptr M00_L19
M00_L38:
       mov       rdx,rbx
       test      rdx,rdx
       je        near ptr M00_L63
       lea       rbx,[rdx+10]
       mov       esi,[rdx+8]
       test      esi,esi
       je        near ptr M00_L64
       mov       edx,esi
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Int32>[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       r8d,esi
       shl       r8,3
       cmp       r8,4000
       jbe       short M00_L39
       mov       rdx,rbx
       call      qword ptr [7FF80D1BCB40]
       jmp       short M00_L40
M00_L39:
       mov       rdx,rbx
       call      00007FF86C9D37A0
       cmp       dword ptr [7FF86CD13A90],0
       jne       near ptr M00_L65
M00_L40:
       mov       ecx,[rdi+8]
       test      ecx,ecx
       jle       short M00_L42
       lea       rdx,[rdi+10]
M00_L41:
       cmp       qword ptr [rdx],0
       je        near ptr M00_L66
       add       rdx,8
       dec       ecx
       jne       short M00_L41
M00_L42:
       mov       rcx,offset MT_System.Threading.Tasks.Task+WhenAllPromise<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7FF80D1B5050]; System.Threading.Tasks.Task+WhenAllPromise`1[[System.Int32, System.Private.CoreLib]]..ctor(System.Threading.Tasks.Task`1<Int32>[])
M00_L43:
       mov       rax,rbx
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M00_L44:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.List<System.Object>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       jmp       near ptr M00_L21
M00_L45:
       mov       rcx,rdi
       mov       rdx,[rbp-40]
       call      qword ptr [7FF80CDB71C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M00_L22
M00_L46:
       mov       rcx,offset MT_System.Threading.Tasks.TaskFactory<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       rcx,2BDDB401320
       xor       r8d,r8d
       call      00007FF86CA021C0
       mov       rdx,rax
       test      rdx,rdx
       jne       near ptr M00_L02
       mov       rdx,2BDDB401320
       mov       rdx,[rdx]
       jmp       near ptr M00_L02
M00_L47:
       mov       ecx,4
       call      qword ptr [7FF80D1BC2D0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L03
M00_L48:
       mov       ecx,8
       call      qword ptr [7FF80D1BC2D0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L13
M00_L49:
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M00_L16
       test      bl,4
       je        near ptr M00_L16
       test      byte ptr [rcx+34],8
       jne       near ptr M00_L16
       call      qword ptr [7FF80D1B7E40]
       jmp       near ptr M00_L16
M00_L50:
       mov       rcx,[rbp-40]
       call      qword ptr [7FF80D1B4990]
       mov       edx,eax
       mov       rcx,2BDDB401350
       mov       rcx,[rcx]
       mov       r8,2BDA5399790
       xor       r9d,r9d
       call      qword ptr [7FF80D1B49A8]
       jmp       near ptr M00_L17
M00_L51:
       mov       rcx,[rbp-40]
       call      qword ptr [7FF80D1B49C0]
       jmp       near ptr M00_L18
M00_L52:
       mov       rcx,[rbp-40]
       mov       rdx,[rbp-48]
       call      qword ptr [7FF80D1B49F0]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].ProcessCompletedOuterTask(System.Threading.Tasks.Task)
       jmp       near ptr M00_L19
M00_L53:
       xor       ebx,ebx
       jmp       near ptr M00_L33
M00_L54:
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FF80D1B5548]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       near ptr M00_L32
M00_L55:
       cmp       ebx,1
       jne       near ptr M00_L19
       mov       rcx,[rbp-40]
       mov       rdx,[rbp-48]
       xor       r8d,r8d
       call      qword ptr [7FF80D1B5620]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       jmp       near ptr M00_L37
M00_L56:
       add       eax,0FFFFFFFA
       cmp       eax,1
       ja        near ptr M00_L19
       mov       r8,[rbp-40]
       movzx     r8d,byte ptr [r8+3D]
       mov       rcx,[rbp-40]
       mov       rdx,[rbp-48]
       call      qword ptr [7FF80D1B5620]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       jmp       near ptr M00_L19
M00_L57:
       mov       rcx,[rbp-48]
       mov       edx,1
       call      qword ptr [7FF80D1BC648]
       mov       rdx,rax
       jmp       near ptr M00_L35
M00_L58:
       mov       rcx,[rbp-40]
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FF80D1B5A58]
       jmp       near ptr M00_L37
M00_L59:
       mov       rcx,[rbp-40]
       xor       r8d,r8d
       call      qword ptr [7FF80D1B5620]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       jmp       near ptr M00_L37
M00_L60:
       mov       rcx,rdx
       mov       rdx,[rbp-40]
       xor       r8d,r8d
       call      qword ptr [7FF80D1B4A08]; System.Threading.Tasks.Task.AddCompletionAction(System.Threading.Tasks.ITaskCompletionAction, Boolean)
       jmp       near ptr M00_L19
M00_L61:
       mov       rcx,[rbp-40]
       mov       rdx,[rbp-48]
       call      qword ptr [7FF80D1B5638]
       jmp       near ptr M00_L19
M00_L62:
       call      qword ptr [7FF80D1B7F30]
       int       3
M00_L63:
       mov       ecx,33
       call      qword ptr [7FF80CDBFD38]
       int       3
M00_L64:
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Int32[]>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rbx
       xor       edx,edx
       mov       r8,2BDA5398F30
       xor       r9d,r9d
       call      qword ptr [7FF80D1B5008]
       jmp       near ptr M00_L43
M00_L65:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L40
M00_L66:
       mov       ecx,1D
       mov       edx,33
       call      qword ptr [7FF80D1B5038]
       int       3
M00_L67:
       sub       rsp,28
       cmp       dword ptr [rbp-20],0
       je        short M00_L68
       mov       rcx,[rbp-50]
       call      00007FF86CA5E040
       test      eax,eax
       je        short M00_L68
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FF80D1B5548]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M00_L68:
       nop
       add       rsp,28
       ret
; Total bytes of code 2587
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M01_L00
       ret
M01_L00:
       xor       edx,edx
       jmp       qword ptr [7FF80D1B50C8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
; Total bytes of code 26
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
       je        near ptr M02_L18
       mov       rsi,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task<System.Int32>>
       mov       rcx,rsi
       call      qword ptr [7FF80D12FF60]; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].get_Factory()
       cmp       [rax],al
       mov       rcx,2BDDB401330
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
       jle       near ptr M02_L17
       mov       rcx,[rcx+240]
       mov       rax,[rcx+20]
       test      rax,rax
       je        near ptr M02_L17
M02_L00:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M02_L01
       call      qword ptr [7FF80D095458]; System.Threading.Thread.InitializeCurrentThread()
M02_L01:
       mov       rbx,[rax+8]
       test      rbx,rbx
       je        short M02_L02
       xor       ecx,ecx
       cmp       byte ptr [rbx+18],0
       cmovne    rbx,rcx
       jmp       short M02_L03
M02_L02:
       mov       rcx,2BDDB401340
       mov       rbx,[rcx]
M02_L03:
       test      rbx,rbx
       je        short M02_L05
       mov       rcx,2BDDB401340
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
       call      qword ptr [7FF80D1B4168]; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
       mov       rcx,offset MT_System.Threading.Tasks.UnwrapPromise<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       movzx     edi,word ptr [rsi+34]
       and       edi,4
       test      edi,0FFFFFFBB
       jne       near ptr M02_L16
       test      dil,4
       je        short M02_L09
       mov       rcx,gs:[58]
       mov       rcx,[rcx+48]
       cmp       dword ptr [rcx+238],8
       jle       near ptr M02_L19
       mov       rcx,[rcx+240]
       mov       rax,[rcx+40]
       test      rax,rax
       je        near ptr M02_L19
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
       jne       near ptr M02_L16
       mov       ecx,edi
       or        ecx,400
       or        ecx,2000000
       mov       [rbx+34],ecx
       mov       rcx,[rbx+28]
       test      rcx,rcx
       jne       near ptr M02_L20
M02_L10:
       mov       byte ptr [rbx+3D],1
       mov       rcx,2BDDB401350
       mov       rcx,[rcx]
       cmp       byte ptr [rcx+9D],0
       jne       near ptr M02_L21
M02_L11:
       cmp       byte ptr [7FF80CCFB074],0
       jne       near ptr M02_L22
M02_L12:
       test      dword ptr [rsi+34],1600000
       jne       near ptr M02_L23
       test      dword ptr [rsi+34],1600000
       jne       short M02_L15
       cmp       qword ptr [rsi+20],0
       jne       short M02_L14
       lea       rcx,[rsi+20]
       test      rcx,rcx
       je        near ptr M02_L24
       mov       rdx,rbx
       xor       r8d,r8d
       call      00007FF86CA021C0
       test      rax,rax
       jne       short M02_L14
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
       mov       rcx,rsi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FF80D1B56F8]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       short M02_L13
M02_L15:
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF80D1AAE28]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
       jmp       short M02_L13
M02_L16:
       mov       ecx,2D
       call      qword ptr [7FF80CDBF348]
       int       3
M02_L17:
       mov       ecx,4
       call      qword ptr [7FF80D1BC2D0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M02_L00
M02_L18:
       mov       ecx,2E
       call      qword ptr [7FF80CDBFD38]
       int       3
M02_L19:
       mov       ecx,8
       call      qword ptr [7FF80D1BC2D0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M02_L07
M02_L20:
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M02_L10
       test      dil,4
       je        near ptr M02_L10
       test      byte ptr [rcx+34],8
       jne       near ptr M02_L10
       call      qword ptr [7FF80D1B7E40]
       jmp       near ptr M02_L10
M02_L21:
       mov       rcx,rbx
       call      qword ptr [7FF80D1B4990]
       mov       edx,eax
       mov       rcx,2BDDB401350
       mov       rcx,[rcx]
       mov       r8,2BDA5399790
       xor       r9d,r9d
       call      qword ptr [7FF80D1B49A8]
       jmp       near ptr M02_L11
M02_L22:
       mov       rcx,rbx
       call      qword ptr [7FF80D1B49C0]
       jmp       near ptr M02_L12
M02_L23:
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF80D1B49F0]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].ProcessCompletedOuterTask(System.Threading.Tasks.Task)
       jmp       near ptr M02_L13
M02_L24:
       call      qword ptr [7FF80D1B7F30]
       int       3
; Total bytes of code 852
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
; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       [rbp+10],rcx
       test      dl,dl
       jne       near ptr M04_L19
       or        dword ptr [rcx+34],10000
M04_L00:
       cmp       byte ptr [7FF80CCFB074],0
       jne       near ptr M04_L20
M04_L01:
       mov       rax,2BDDB401350
       mov       rbx,[rax]
       cmp       byte ptr [rbx+9D],0
       jne       near ptr M04_L21
M04_L02:
       mov       rsi,[rcx+18]
       cmp       [rsi],sil
       cmp       byte ptr [rbx+9D],0
       jne       near ptr M04_L11
M04_L03:
       mov       rdx,offset MT_System.Threading.Tasks.ThreadPoolTaskScheduler
       cmp       [rsi],rdx
       jne       near ptr M04_L17
       movzx     esi,word ptr [rcx+34]
       test      sil,2
       jne       near ptr M04_L12
       mov       rdx,2BDDB401358
       mov       rbx,[rdx]
       cmp       byte ptr [rbx+38],0
       jne       near ptr M04_L13
M04_L04:
       test      sil,1
       jne       short M04_L06
       mov       rax,gs:[58]
       mov       rax,[rax+48]
       cmp       dword ptr [rax+238],5
       jle       near ptr M04_L14
       mov       rax,[rax+240]
       mov       rax,[rax+28]
       test      rax,rax
       je        near ptr M04_L14
M04_L05:
       mov       rdx,[rax+10]
       test      rdx,rdx
       jne       short M04_L08
M04_L06:
       mov       rdx,[rbx+8]
       mov       r8,[rdx+10]
       mov       r10,[r8+8]
M04_L07:
       mov       esi,[r8+0A0]
       mov       eax,esi
       and       eax,[r8+18]
       cmp       eax,[r10+8]
       jae       near ptr M04_L15
       shl       rax,4
       lea       rdi,[r10+rax+10]
       mov       eax,[rdi+8]
       sub       eax,esi
       jne       short M04_L09
       lea       r9,[r8+0A0]
       lea       r11d,[rsi+1]
       mov       eax,esi
       lock cmpxchg [r9],r11d
       cmp       eax,esi
       jne       short M04_L07
       mov       rdx,[rbp+10]
       mov       rcx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       inc       esi
       mov       [rdi+8],esi
       jmp       short M04_L10
M04_L08:
       mov       rcx,[rdx+18]
       mov       rdx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF80D1B5530]; System.Threading.ThreadPoolWorkQueue+WorkStealingQueue.LocalPush(System.Object)
       jmp       short M04_L10
M04_L09:
       test      eax,eax
       jge       short M04_L07
       mov       rcx,rdx
       mov       rdx,[rbp+10]
       call      qword ptr [7FF80D1BC528]
M04_L10:
       add       rbx,78
       mov       ecx,1
       xchg      ecx,[rbx]
       test      ecx,ecx
       jne       near ptr M04_L18
       mov       rcx,2BDDB401380
       mov       rbx,[rcx]
       lea       rcx,[rbx+178]
       lock inc  dword ptr [rcx]
       mov       rcx,rbx
       call      qword ptr [7FF80D1B4648]; System.Threading.PortableThreadPool+WorkerThread.MaybeAddWorkingWorker(System.Threading.PortableThreadPool)
       cmp       dword ptr [rbx+17C],6
       je        near ptr M04_L18
       jmp       near ptr M04_L16
M04_L11:
       mov       rdx,rsi
       call      qword ptr [7FF80D1BC420]
       mov       rcx,[rbp+10]
       jmp       near ptr M04_L03
M04_L12:
       mov       rcx,offset MT_System.Threading.Tasks.ThreadPoolTaskScheduler
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2BDDB401408
       mov       rbx,[rcx]
       mov       rcx,offset MT_System.Threading.Thread
       call      CORINFO_HELP_NEWFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF80D1BD1B8]
       mov       rcx,rsi
       mov       edx,1
       call      qword ptr [7FF80D1B47B0]; System.Threading.Thread.set_IsBackground(Boolean)
       mov       rcx,rsi
       mov       rdx,2BDA5398C38
       call      qword ptr [7FF80D1B48A0]; System.Threading.Thread.set_Name(System.String)
       mov       rcx,rsi
       mov       rdx,[rbp+10]
       xor       r8d,r8d
       call      qword ptr [7FF80D1BD1D0]
       jmp       short M04_L18
M04_L13:
       mov       rdx,2BDDB401370
       mov       rdx,[rdx]
       cmp       byte ptr [rdx+9D],0
       je        near ptr M04_L04
       mov       rdx,2BDDB401370
       mov       rcx,[rdx]
       mov       rdx,[rbp+10]
       call      qword ptr [7FF80D1BC510]
       jmp       near ptr M04_L04
M04_L14:
       mov       ecx,5
       call      qword ptr [7FF80D1BC2D0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M04_L05
M04_L15:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M04_L16:
       mov       rcx,rbx
       call      qword ptr [7FF80D1B4828]; System.Threading.PortableThreadPool+GateThread.EnsureRunningSlow(System.Threading.PortableThreadPool)
       jmp       short M04_L18
M04_L17:
       mov       rcx,rsi
       mov       rdx,[rbp+10]
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       nop
M04_L18:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M04_L19:
       call      qword ptr [7FF80D1BD1A0]
       test      eax,eax
       mov       rcx,[rbp+10]
       jne       near ptr M04_L00
       jmp       short M04_L18
M04_L20:
       call      qword ptr [7FF80D1B49C0]
       mov       rcx,[rbp+10]
       jmp       near ptr M04_L01
M04_L21:
       test      word ptr [rcx+34],200
       jne       near ptr M04_L02
       call      qword ptr [7FF80D1B4990]
       mov       esi,eax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       call      qword ptr [7FF80D1BC390]
       mov       rdx,rax
       mov       rcx,2BDA5398BB0
       call      qword ptr [7FF80CDBD9C8]; System.String.Concat(System.String, System.String)
       mov       r8,rax
       mov       edx,esi
       mov       rcx,rbx
       xor       r9d,r9d
       call      qword ptr [7FF80D1B49A8]
       mov       rcx,[rbp+10]
       jmp       near ptr M04_L02
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_System.Threading.Tasks.TaskSchedulerException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF80D1BC3A8]
       mov       rcx,[rbp+10]
       mov       rdx,rsi
       call      qword ptr [7FF80D1BC3C0]
       mov       rcx,[rbp+10]
       xor       edx,edx
       call      qword ptr [7FF80D1BC3D8]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80D1BC3F0]
       test      eax,200
       jne       short M04_L22
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+28]
       mov       rcx,[rcx+18]
       xor       edx,edx
       cmp       [rcx],ecx
       call      qword ptr [7FF80D1BC408]
M04_L22:
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 869
```
```assembly
; AsyncLazyBenchmarks.ContendedFirstCallBenchmarks+<>c__DisplayClass10_0.<Nito>b__0()
       push      rbp
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+40]
       mov       rbx,[rcx+8]
       mov       rcx,[rbx+8]
       mov       [rbp-18],rcx
       xor       eax,eax
       mov       [rbp-0C],eax
       test      rcx,rcx
       je        short M05_L02
       call      00007FF86CA5E120
       test      eax,eax
       je        short M05_L03
M05_L00:
       mov       dword ptr [rbp-0C],1
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],0
       jne       short M05_L01
       mov       rbx,[rcx+18]
       jmp       short M05_L04
M05_L01:
       call      qword ptr [7FF80D095848]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rbx,rax
       jmp       short M05_L04
M05_L02:
       xor       ecx,ecx
       call      qword ptr [7FF80D1B7F48]
       int       3
M05_L03:
       mov       rcx,[rbp-18]
       call      qword ptr [7FF80D1B5500]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M05_L00
M05_L04:
       mov       rcx,[rbp-18]
       call      00007FF86CA5E040
       test      eax,eax
       jne       short M05_L06
M05_L05:
       mov       rax,rbx
       add       rsp,38
       pop       rbx
       pop       rbp
       ret
M05_L06:
       mov       ecx,eax
       mov       rdx,[rbp-18]
       call      qword ptr [7FF80D1B5548]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       short M05_L05
       sub       rsp,28
       cmp       dword ptr [rbp-0C],0
       je        short M05_L08
       cmp       qword ptr [rbp-18],0
       jne       short M05_L07
       xor       ecx,ecx
       call      qword ptr [7FF80D1B7F48]
       int       3
M05_L07:
       mov       rcx,[rbp-18]
       call      00007FF86CA5E040
       test      eax,eax
       je        short M05_L08
       mov       ecx,eax
       mov       rdx,[rbp-18]
       call      qword ptr [7FF80D1B5548]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M05_L08:
       nop
       add       rsp,28
       ret
; Total bytes of code 192
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M06_L02
       lea       rax,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       mov       rdx,[rcx+30]
       test      r8,r8
       je        short M06_L01
       cmp       rdx,[r8]
       je        short M06_L00
       mov       r10,offset MT_System.Object[]
       cmp       rcx,r10
       je        short M06_L00
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FF80D094EB8]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
M06_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FF86CA540D0
M06_L01:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M06_L02:
       call      qword ptr [7FF80D1B7D20]
       int       3
; Total bytes of code 94
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,[rbx+10]
       mov       ebp,edi
       lea       ecx,[rbp+1]
       mov       rdx,[rbx+8]
       cmp       dword ptr [rdx+8],0
       jne       short M07_L01
       mov       r14d,4
M07_L00:
       mov       edx,7FFFFFC7
       cmp       r14d,7FFFFFC7
       cmova     r14d,edx
       cmp       r14d,ecx
       cmovl     r14d,ecx
       cmp       r14d,edi
       jge       short M07_L02
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FF80D125800]
       int       3
M07_L01:
       mov       rdx,[rbx+8]
       mov       r14d,[rdx+8]
       add       r14d,r14d
       jmp       short M07_L00
M07_L02:
       mov       rcx,[rbx+8]
       cmp       [rcx+8],r14d
       je        near ptr M07_L08
       test      r14d,r14d
       jg        short M07_L05
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+38]
       test      rdx,rdx
       je        short M07_L04
M07_L03:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M07_L08
M07_L04:
       mov       rdx,7FF80D1D9D30
       call      qword ptr [7FF80CDBF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M07_L03
M07_L05:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+40]
       test      rax,rax
       je        short M07_L09
       mov       rcx,rax
M07_L06:
       mov       edx,r14d
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       test      edi,edi
       jle       short M07_L07
       mov       rcx,[rbx+8]
       mov       r8d,edi
       mov       rdx,r14
       call      qword ptr [7FF80CDBF588]; System.Array.Copy(System.Array, System.Array, Int32)
M07_L07:
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M07_L08:
       lea       ecx,[rbp+1]
       mov       [rbx+10],ecx
       mov       rcx,[rbx+8]
       movsxd    rdx,ebp
       mov       r8,rsi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M07_L09:
       mov       rdx,7FF80D1D9D40
       call      qword ptr [7FF80CDBF4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M07_L06
; Total bytes of code 303
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M08_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M08_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M08_L02
M08_L00:
       test      rax,rax
       je        short M08_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M08_L02
       test      rax,rax
       je        short M08_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M08_L02
       test      rax,rax
       je        short M08_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M08_L02
       test      rax,rax
       jne       short M08_L03
M08_L01:
       xor       edx,edx
M08_L02:
       mov       rax,rdx
       ret
M08_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M08_L02
       jmp       short M08_L00
; Total bytes of code 86
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
       mov       rax,7FF80CDF8210
       mov       [rbp-60],rax
       lea       rax,[M09_L00]
       mov       [rbp-50],rax
       lea       rax,[rbp-70]
       mov       [rbx+8],rax
       mov       byte ptr [rbx+4],0
       mov       rax,7FF86CA5E560
       call      rax
M09_L00:
       mov       byte ptr [rbx+4],1
       cmp       dword ptr [7FF86CD13A90],0
       je        short M09_L01
       call      qword ptr [7FF86CD02648]; CORINFO_HELP_STOP_FOR_GC
M09_L01:
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
; System.Threading.Tasks.Task+<>c.<AddTaskContinuationComplex>b__211_0(System.Object)
       test      rdx,rdx
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 10
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAll(System.Predicate`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M11_L04
       nop       dword ptr [rax]
       xor       edi,edi
       cmp       dword ptr [rbx+10],0
       jle       short M11_L01
       mov       rdx,offset System.Threading.Tasks.Task+<>c.<AddTaskContinuationComplex>b__211_0(System.Object)
       cmp       [rsi+18],rdx
       jne       short M11_L02
       nop
M11_L00:
       mov       rdx,[rbx+8]
       cmp       edi,[rdx+8]
       jae       near ptr M11_L11
       mov       ecx,edi
       mov       rdx,[rdx+rcx*8+10]
       test      rdx,rdx
       je        short M11_L01
       inc       edi
       cmp       edi,[rbx+10]
       jl        short M11_L00
M11_L01:
       cmp       edi,[rbx+10]
       jl        short M11_L06
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M11_L02:
       mov       rdx,[rbx+8]
       cmp       edi,[rdx+8]
       jae       near ptr M11_L11
       mov       ecx,edi
       mov       rdx,[rdx+rcx*8+10]
       mov       rcx,offset System.Threading.Tasks.Task+<>c.<AddTaskContinuationComplex>b__211_0(System.Object)
       cmp       [rsi+18],rcx
       jne       short M11_L05
       test      rdx,rdx
       je        short M11_L01
M11_L03:
       inc       edi
       cmp       edi,[rbx+10]
       jge       short M11_L01
       jmp       short M11_L02
M11_L04:
       mov       ecx,1A
       call      qword ptr [7FF80CDBFD38]
       int       3
M11_L05:
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M11_L03
       jmp       short M11_L01
M11_L06:
       lea       ebp,[rdi+1]
       jmp       short M11_L10
M11_L07:
       inc       ebp
M11_L08:
       cmp       ebp,[rbx+10]
       jge       short M11_L09
       mov       rdx,[rbx+8]
       cmp       ebp,[rdx+8]
       jae       short M11_L11
       mov       ecx,ebp
       mov       rdx,[rdx+rcx*8+10]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M11_L07
M11_L09:
       cmp       ebp,[rbx+10]
       jge       short M11_L10
       mov       edx,edi
       lea       edi,[rdx+1]
       mov       ecx,ebp
       lea       ebp,[rcx+1]
       mov       r8,[rbx+8]
       mov       rax,[rbx+8]
       cmp       ecx,[rax+8]
       jae       short M11_L11
       mov       rax,[rax+rcx*8+10]
       mov       rcx,r8
       mov       r8,rax
       movsxd    rdx,edx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M11_L10:
       cmp       ebp,[rbx+10]
       jl        short M11_L08
       mov       r8d,[rbx+10]
       sub       r8d,edi
       mov       rcx,[rbx+8]
       mov       edx,edi
       call      qword ptr [7FF80D1BCF48]
       mov       eax,[rbx+10]
       sub       eax,edi
       mov       [rbx+10],edi
       inc       dword ptr [rbx+14]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M11_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 307
```
```assembly
; System.Threading.Tasks.Task.get_Status()
       mov       eax,[rcx+34]
       test      eax,200000
       jne       short M12_L01
       test      eax,400000
       jne       short M12_L02
       test      eax,1000000
       je        short M12_L03
       mov       eax,5
M12_L00:
       ret
M12_L01:
       mov       eax,7
       jmp       short M12_L00
M12_L02:
       mov       eax,6
       jmp       short M12_L00
M12_L03:
       test      eax,800000
       je        short M12_L04
       mov       eax,4
       jmp       short M12_L00
M12_L04:
       test      eax,20000
       je        short M12_L05
       mov       eax,3
       jmp       short M12_L00
M12_L05:
       test      eax,2000000
       setne     cl
       movzx     ecx,cl
       mov       edx,2
       test      eax,10000
       mov       eax,edx
       cmove     eax,ecx
       jmp       short M12_L00
; Total bytes of code 100
```
```assembly
; System.Threading.Tasks.Task+WhenAllPromise`1[[System.Int32, System.Private.CoreLib]]..ctor(System.Threading.Tasks.Task`1<Int32>[])
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       mov       [rbp-40],rax
       mov       [rbp+10],rcx
       mov       rbx,rdx
       mov       dword ptr [rcx+34],2000400
       lea       rcx,[rcx+40]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       esi,[rbx+8]
       mov       rcx,[rbp+10]
       mov       [rcx+48],esi
       mov       rax,2BDDB401350
       mov       rax,[rax]
       cmp       byte ptr [rax+9D],0
       jne       near ptr M13_L25
M13_L00:
       cmp       byte ptr [7FF80CCFB074],0
       jne       near ptr M13_L26
M13_L01:
       mov       [rbp-38],rbx
       xor       edx,edx
       mov       [rbp-24],edx
       jmp       short M13_L09
M13_L02:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.List<System.Object>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       mov       rcx,[rbp+10]
       jmp       near ptr M13_L11
M13_L03:
       mov       rcx,r14
       mov       rdx,[rbp+10]
       call      qword ptr [7FF80CDB71C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M13_L12
M13_L04:
       mov       rcx,r14
       call      00007FF86CA5E040
       test      eax,eax
       jne       near ptr M13_L27
M13_L05:
       mov       esi,1
M13_L06:
       test      esi,esi
       jne       short M13_L08
M13_L07:
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FF80D1CB108]; System.Threading.Tasks.Task+WhenAllPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
M13_L08:
       mov       eax,[rbp-24]
       inc       eax
       mov       [rbp-24],eax
       mov       rcx,[rbp+10]
M13_L09:
       mov       rbx,[rbp-38]
       mov       esi,[rbx+8]
       cmp       esi,[rbp-24]
       jle       near ptr M13_L22
       mov       edx,[rbp-24]
       mov       rdx,[rbx+rdx*8+10]
       mov       [rbp-40],rdx
       mov       rdx,[rbp-40]
       test      dword ptr [rdx+34],1600000
       jne       short M13_L07
       mov       rdx,[rbp-40]
       test      dword ptr [rdx+34],1600000
       jne       short M13_L07
       mov       rdx,[rbp-40]
       cmp       qword ptr [rdx+20],0
       jne       short M13_L10
       mov       rdx,[rbp-40]
       add       rdx,20
       test      rdx,rdx
       je        near ptr M13_L28
       mov       rcx,rdx
       mov       rdx,[rbp+10]
       xor       r8d,r8d
       call      00007FF86CA021C0
       test      rax,rax
       je        short M13_L08
M13_L10:
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-40]
       mov       rsi,[rdx+20]
       mov       rdx,2BDDB400218
       mov       rdi,[rdx]
       cmp       rsi,rdi
       je        near ptr M13_L24
       mov       r14,rsi
       test      r14,r14
       je        short M13_L11
       mov       rdx,offset MT_System.Threading.Tasks.UnwrapPromise<System.Int32>
       cmp       [r14],rdx
       jne       near ptr M13_L02
       xor       r14d,r14d
M13_L11:
       test      r14,r14
       jne       near ptr M13_L13
       mov       rcx,offset MT_System.Collections.Generic.List<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,2BDDB400A60
       mov       rdx,[rcx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [r14+14]
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [7FF80CDB71C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       inc       dword ptr [r14+14]
       mov       rcx,[r14+8]
       mov       edx,[r14+10]
       cmp       [rcx+8],edx
       jbe       near ptr M13_L03
       lea       r8d,[rdx+1]
       mov       [r14+10],r8d
       mov       edx,edx
       mov       r8,[rbp+10]
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M13_L12:
       mov       rcx,[rbp-40]
       add       rcx,20
       test      rcx,rcx
       je        near ptr M13_L28
       mov       rdx,r14
       mov       r8,rsi
       call      00007FF86CA021C0
       mov       r14,rax
       cmp       r14,rsi
       je        near ptr M13_L05
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.List<System.Object>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       mov       rcx,[rbp+10]
       je        near ptr M13_L24
M13_L13:
       mov       [rbp-48],r14
       xor       eax,eax
       mov       [rbp-28],eax
       mov       rcx,r14
       call      00007FF86CA5E120
       test      eax,eax
       je        near ptr M13_L20
M13_L14:
       mov       dword ptr [rbp-28],1
       mov       rcx,[rbp-40]
       cmp       [rcx+20],rdi
       je        short M13_L16
       mov       ecx,[r14+10]
       mov       rax,[r14+8]
       cmp       ecx,[rax+8]
       je        short M13_L17
M13_L15:
       inc       dword ptr [r14+14]
       mov       rcx,[r14+8]
       mov       edx,[r14+10]
       cmp       [rcx+8],edx
       jbe       short M13_L19
       lea       r8d,[rdx+1]
       mov       [r14+10],r8d
       mov       edx,edx
       mov       r8,[rbp+10]
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M13_L04
M13_L16:
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       jmp       near ptr M13_L23
M13_L17:
       mov       rcx,2BDDB400270
       mov       rdx,[rcx]
       test      rdx,rdx
       je        short M13_L21
M13_L18:
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FF80D1B57D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAll(System.Predicate`1<System.__Canon>)
       jmp       short M13_L15
M13_L19:
       mov       rcx,r14
       mov       rdx,[rbp+10]
       call      qword ptr [7FF80CDB71C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M13_L04
M13_L20:
       mov       rcx,r14
       call      qword ptr [7FF80D1B5500]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       near ptr M13_L14
M13_L21:
       mov       rcx,offset MT_System.Predicate<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,2BDDB400240
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset System.Threading.Tasks.Task+<>c.<AddTaskContinuationComplex>b__211_0(System.Object)
       mov       [rsi+18],rcx
       mov       rcx,2BDDB400270
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rsi
       jmp       short M13_L18
M13_L22:
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M13_L23:
       call      M13_L29
       nop
       mov       esi,[rbp-2C]
       mov       rbx,[rbp-38]
       jmp       near ptr M13_L06
M13_L24:
       xor       esi,esi
       jmp       near ptr M13_L06
M13_L25:
       call      qword ptr [7FF80D1B4990]
       mov       edx,eax
       mov       rcx,2BDDB401350
       mov       rcx,[rcx]
       mov       r8,2BDA5399E48
       xor       r9d,r9d
       call      qword ptr [7FF80D1B49A8]
       mov       rcx,[rbp+10]
       jmp       near ptr M13_L00
M13_L26:
       call      qword ptr [7FF80D1B49C0]
       mov       rcx,[rbp+10]
       jmp       near ptr M13_L01
M13_L27:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF80D1B5548]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       near ptr M13_L05
M13_L28:
       call      qword ptr [7FF80D1B7F30]
       int       3
M13_L29:
       sub       rsp,28
       cmp       dword ptr [rbp-28],0
       je        short M13_L30
       mov       rcx,[rbp-48]
       call      00007FF86CA5E040
       test      eax,eax
       je        short M13_L30
       mov       ecx,eax
       mov       rdx,[rbp-48]
       call      qword ptr [7FF80D1B5548]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M13_L30:
       nop
       add       rsp,28
       ret
; Total bytes of code 965
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
       jne       short M14_L01
       cmp       [rax],ecx
       jle       short M14_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M14_L03
M14_L00:
       add       rsp,20
       pop       rbx
       ret
M14_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M14_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M14_L00
M14_L02:
       cmp       [rax+4],edx
       jle       short M14_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M14_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M14_L03
       jmp       short M14_L00
M14_L03:
       mov       ecx,ebx
       lea       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].ProcessCompletedOuterTask(System.Threading.Tasks.Task)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       byte ptr [rbx+3C],1
       mov       edx,[rsi+34]
       test      edx,200000
       jne       near ptr M15_L11
       test      edx,400000
       jne       near ptr M15_L12
       test      edx,1000000
       je        near ptr M15_L13
       mov       edi,5
M15_L00:
       cmp       edi,5
       jne       near ptr M15_L10
       mov       rcx,rsi
       mov       rax,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task<System.Int32>>
       cmp       [rcx],rax
       jne       near ptr M15_L17
M15_L01:
       test      rcx,rcx
       je        short M15_L05
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       near ptr M15_L19
       mov       rdi,[rcx+38]
M15_L02:
       test      rdi,rdi
       je        near ptr M15_L20
       test      dword ptr [rdi+34],1600000
       je        short M15_L07
       mov       rcx,rbx
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FF80D1B5620]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
M15_L03:
       mov       byte ptr [rbx+3C],2
M15_L04:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M15_L05:
       mov       rcx,rsi
       mov       rax,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task>
       cmp       [rcx],rax
       jne       near ptr M15_L18
M15_L06:
       cmp       [rcx],ecx
       call      qword ptr [7FF80D1B5680]; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].get_Result()
       mov       rdi,rax
       jmp       short M15_L02
M15_L07:
       test      dword ptr [rdi+34],1600000
       jne       short M15_L09
       cmp       qword ptr [rdi+20],0
       jne       short M15_L08
       lea       rcx,[rdi+20]
       test      rcx,rcx
       je        near ptr M15_L21
       mov       rdx,rbx
       xor       r8d,r8d
       call      00007FF86CA021C0
       test      rax,rax
       je        short M15_L04
M15_L08:
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FF80D1B56F8]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       short M15_L04
M15_L09:
       mov       rcx,rbx
       mov       rdx,rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF80D1AAE28]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
M15_L10:
       add       edi,0FFFFFFFA
       cmp       edi,1
       ja        near ptr M15_L04
       jmp       short M15_L16
M15_L11:
       mov       edi,7
       jmp       near ptr M15_L00
M15_L12:
       mov       edi,6
       jmp       near ptr M15_L00
M15_L13:
       test      edx,800000
       je        short M15_L14
       mov       edi,4
       jmp       near ptr M15_L00
M15_L14:
       test      edx,20000
       je        short M15_L15
       mov       edi,3
       jmp       near ptr M15_L00
M15_L15:
       test      edx,2000000
       setne     dil
       movzx     edi,dil
       mov       ecx,2
       test      edx,10000
       cmovne    edi,ecx
       jmp       near ptr M15_L00
M15_L16:
       movzx     r8d,byte ptr [rbx+3D]
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF80D1B5620]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       jmp       near ptr M15_L04
M15_L17:
       mov       rdx,rsi
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rcx,rax
       jmp       near ptr M15_L01
M15_L18:
       mov       rdx,rsi
       mov       rcx,rax
       call      qword ptr [7FF80CF94D20]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rcx,rax
       jmp       near ptr M15_L06
M15_L19:
       mov       edx,1
       call      qword ptr [7FF80D1BC648]
       mov       rdi,rax
       jmp       near ptr M15_L02
M15_L20:
       mov       rcx,rbx
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FF80D1B5A58]
       jmp       near ptr M15_L03
M15_L21:
       call      qword ptr [7FF80D1B7F30]
       int       3
; Total bytes of code 494
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
       sub       rsp,58
       vzeroupper
       lea       rbp,[rsp+90]
       mov       [rbp+18],rdx
       mov       ebx,ecx
       lea       rcx,[rbp-70]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-58],rcx
       mov       rcx,rbp
       mov       [rbp-48],rcx
       lea       rcx,[rbp+18]
       mov       edx,ebx
       mov       rax,7FF80CDF8350
       mov       [rbp-60],rax
       lea       rax,[M16_L00]
       mov       [rbp-50],rax
       lea       rax,[rbp-70]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF86CA5E630
       call      rax
M16_L00:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF86CD13A90],0
       je        short M16_L01
       call      qword ptr [7FF86CD02648]; CORINFO_HELP_STOP_FOR_GC
M16_L01:
       mov       rax,[rbp-68]
       mov       [rsi+8],rax
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
; Total bytes of code 158
```
```assembly
; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
M17_L00:
       mov       rcx,2BDDB401350
       mov       rbp,[rcx]
       cmp       byte ptr [rbp+9D],0
       jne       near ptr M17_L13
M17_L01:
       xor       eax,eax
       mov       ecx,[rsi+34]
       test      ecx,200000
       jne       near ptr M17_L14
       test      ecx,400000
       jne       near ptr M17_L15
       test      ecx,1000000
       je        near ptr M17_L16
       mov       edx,5
M17_L02:
       add       edx,0FFFFFFFB
       jne       near ptr M17_L19
       cmp       byte ptr [rbp+9D],0
       jne       near ptr M17_L21
M17_L03:
       cmp       byte ptr [7FF80CCFB074],0
       jne       near ptr M17_L22
M17_L04:
       mov       rcx,rsi
       mov       rdx,offset MT_System.Threading.Tasks.UnwrapPromise<System.Int32>
       cmp       [rcx],rdx
       jne       near ptr M17_L12
M17_L05:
       test      rcx,rcx
       je        near ptr M17_L23
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       near ptr M17_L24
       mov       esi,[rcx+38]
M17_L06:
       xor       edi,edi
       mov       eax,[rbx+34]
       mov       [rsp+24],eax
       test      eax,5600000
       jne       short M17_L10
       lea       rcx,[rbx+34]
       mov       edx,eax
       or        edx,4000000
       lock cmpxchg [rcx],edx
       cmp       eax,[rsp+24]
       jne       near ptr M17_L25
M17_L07:
       mov       [rbx+38],esi
       lea       rcx,[rbx+34]
       mov       eax,[rbx+34]
       or        eax,1000000
       xchg      eax,[rcx]
       mov       rdi,[rbx+28]
       test      rdi,rdi
       jne       near ptr M17_L26
M17_L08:
       lea       rcx,[rbx+20]
       test      rcx,rcx
       je        near ptr M17_L27
       mov       rdx,2BDDB400218
       mov       rdx,[rdx]
       call      00007FF86CA0C330
       test      rax,rax
       je        short M17_L09
       mov       rcx,rbx
       mov       rdx,rax
       call      qword ptr [7FF80D1B55C0]; System.Threading.Tasks.Task.RunContinuations(System.Object)
M17_L09:
       mov       edi,1
M17_L10:
       mov       eax,edi
M17_L11:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M17_L12:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rcx,rax
       jmp       near ptr M17_L05
M17_L13:
       mov       rcx,rbx
       call      qword ptr [7FF80D1B4990]
       mov       edx,eax
       mov       rcx,rbp
       mov       r8d,1
       call      qword ptr [7FF80D1B5A10]
       jmp       near ptr M17_L01
M17_L14:
       mov       edx,7
       jmp       near ptr M17_L02
M17_L15:
       mov       edx,6
       jmp       near ptr M17_L02
M17_L16:
       test      ecx,800000
       je        short M17_L17
       mov       edx,4
       jmp       near ptr M17_L02
M17_L17:
       test      ecx,20000
       je        short M17_L18
       mov       edx,3
       jmp       near ptr M17_L02
M17_L18:
       test      ecx,2000000
       setne     dl
       movzx     edx,dl
       mov       r8d,2
       test      ecx,10000
       cmovne    edx,r8d
       jmp       near ptr M17_L02
M17_L19:
       cmp       edx,2
       ja        near ptr M17_L11
       mov       ecx,edx
       lea       rax,[7FF80CE3C528]
       mov       eax,[rax+rcx*4]
       lea       rdx,[M17_L00]
       add       rax,rdx
       jmp       rax
       mov       rcx,rsi
       call      qword ptr [7FF80D1B5A28]
       mov       rdi,rax
       mov       rcx,rsi
       call      qword ptr [7FF80D1B5A40]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF80D1B5A58]
       jmp       near ptr M17_L11
       mov       rcx,rsi
       call      qword ptr [7FF80D1B5A70]
       mov       rsi,rax
       test      dil,dil
       je        short M17_L20
       cmp       dword ptr [rsi+10],0
       jle       short M17_L20
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF80CEA3578]
       mov       rbp,rax
       test      rbp,rbp
       je        short M17_L20
       mov       rdx,[rbp+8]
       mov       rcx,offset MT_System.OperationCanceledException
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M17_L20
       mov       rdx,[rax+70]
       mov       rcx,rbx
       mov       r8,rbp
       call      qword ptr [7FF80D1B5A58]
       jmp       near ptr M17_L11
M17_L20:
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF80D1B5AE8]
       jmp       near ptr M17_L11
M17_L21:
       mov       rcx,rbx
       call      qword ptr [7FF80D1B4990]
       mov       edx,eax
       mov       rcx,rbp
       mov       r8d,1
       call      qword ptr [7FF80D1B5B00]
       jmp       near ptr M17_L03
M17_L22:
       mov       rcx,rbx
       call      qword ptr [7FF80D1B5B18]
       jmp       near ptr M17_L04
M17_L23:
       xor       esi,esi
       jmp       near ptr M17_L06
M17_L24:
       mov       edx,1
       call      qword ptr [7FF80D1B5C08]; System.Threading.Tasks.Task`1[[System.Int32, System.Private.CoreLib]].GetResultCore(Boolean)
       mov       esi,eax
       jmp       near ptr M17_L06
M17_L25:
       mov       rcx,rbx
       mov       edx,4000000
       mov       r8d,5600000
       call      qword ptr [7FF80D1BC360]
       test      eax,eax
       je        near ptr M17_L10
       jmp       near ptr M17_L07
M17_L26:
       mov       rcx,rbx
       call      qword ptr [7FF80D1BC870]
       mov       rcx,rdi
       call      qword ptr [7FF80D1BC888]
       jmp       near ptr M17_L08
M17_L27:
       call      qword ptr [7FF80D1B7F30]
       int       3
; Total bytes of code 772
```
```assembly
; System.Threading.Tasks.Task.AddCompletionAction(System.Threading.Tasks.ITaskCompletionAction, Boolean)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       test      dword ptr [rbx+34],1600000
       jne       short M18_L02
       cmp       qword ptr [rbx+20],0
       jne       short M18_L01
       lea       rcx,[rbx+20]
       test      rcx,rcx
       je        short M18_L03
       mov       rdx,rsi
       xor       r8d,r8d
       call      00007FF86CA021C0
       test      rax,rax
       jne       short M18_L01
M18_L00:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M18_L01:
       movzx     r8d,dil
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF80D1B56F8]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       short M18_L00
M18_L02:
       mov       rcx,offset MT_System.Threading.Tasks.UnwrapPromise<System.Int32>
       cmp       [rsi],rcx
       jne       short M18_L04
       mov       rcx,rsi
       mov       rdx,rbx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF80D1AAE28]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
M18_L03:
       call      qword ptr [7FF80D1B7F30]
       int       3
M18_L04:
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r11,7FF80CD004E0
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [r11]
; Total bytes of code 152
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      dword ptr [rbx+34],1600000
       jne       short M19_L00
       mov       rcx,rbx
       mov       edx,0FFFFFFFF
       xor       r8d,r8d
       call      qword ptr [7FF80D1B50E0]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M19_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M19_L03
M19_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M19_L04
M19_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M19_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M19_L01
       mov       rcx,rbx
       call      qword ptr [7FF80D1BCEE8]
       jmp       short M19_L01
M19_L04:
       test      sil,2
       jne       short M19_L05
       mov       rcx,rbx
       call      qword ptr [7FF80D1BCD38]
M19_L05:
       mov       rcx,rbx
       call      qword ptr [7FF80D1BD368]
       jmp       short M19_L02
; Total bytes of code 124
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v4 (Job: DefaultJob)

```assembly
; AsyncLazyBenchmarks.ContendedFirstCallBenchmarks.VsThreading()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rbx,rcx
       mov       rcx,offset MT_AsyncLazyBenchmarks.ContendedFirstCallBenchmarks+<>c__DisplayClass11_0
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,offset MT_Microsoft.VisualStudio.Threading.AsyncLazy<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,25FE9001300
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_NEWSFAST
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+20]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+10],rcx
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       edi,edi
M00_L00:
       mov       rbp,[rbx+8]
       cmp       [rbp+8],edi
       jle       near ptr M00_L22
       mov       r14,[rsi+10]
       test      r14,r14
       je        near ptr M00_L08
M00_L01:
       mov       rcx,25FE9001330
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M00_L34
M00_L02:
       cmp       [rax],al
       mov       rcx,25FE9001340
       mov       r15,[rcx]
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rcx,[r13+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r13+10],rcx
       lea       rcx,[r13+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,2008
       mov       [r13+34],ecx
       mov       rcx,gs:[58]
       mov       rcx,[rcx+48]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M00_L35
       mov       rcx,[rcx+240]
       mov       rax,[rcx+20]
       test      rax,rax
       je        near ptr M00_L35
M00_L03:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M00_L04
       call      qword ptr [7FF80D0C5458]; System.Threading.Thread.InitializeCurrentThread()
M00_L04:
       mov       r14,[rax+8]
       test      r14,r14
       jne       near ptr M00_L09
       mov       rcx,25FE9001350
       mov       r14,[rcx]
M00_L05:
       test      r14,r14
       jne       near ptr M00_L10
       or        dword ptr [r13+34],20000000
M00_L06:
       mov       rcx,r13
       xor       edx,edx
       call      qword ptr [7FF80D204090]; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
       mov       rcx,offset MT_System.Threading.Tasks.UnwrapPromise<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       movzx     r15d,word ptr [r13+34]
       and       r15d,4
       test      r15d,0FFFFFFBB
       je        near ptr M00_L12
M00_L07:
       mov       ecx,2D
       call      qword ptr [7FF80CDEF348]
       int       3
M00_L08:
       mov       rcx,offset MT_System.Func<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset AsyncLazyBenchmarks.ContendedFirstCallBenchmarks+<>c__DisplayClass11_0.<VsThreading>b__0()
       mov       [r14+18],rcx
       lea       rcx,[rsi+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L09:
       cmp       byte ptr [r14+18],0
       je        near ptr M00_L05
       jmp       near ptr M00_L36
M00_L10:
       mov       rcx,25FE9001350
       cmp       r14,[rcx]
       je        near ptr M00_L06
       mov       rax,[r13+28]
       test      rax,rax
       jne       short M00_L11
       mov       rcx,offset MT_System.Threading.Tasks.Task+ContingentProperties
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       dword ptr [r15+3C],1
       lea       rcx,[r13+28]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,r15
M00_L11:
       lea       rcx,[rax+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L06
M00_L12:
       test      r15b,4
       je        short M00_L15
       mov       rcx,gs:[58]
       mov       rcx,[rcx+48]
       cmp       dword ptr [rcx+238],8
       jle       near ptr M00_L37
       mov       rcx,[rcx+240]
       mov       rax,[rcx+40]
       test      rax,rax
       je        near ptr M00_L37
M00_L13:
       mov       r12,[rax+10]
       test      r12,r12
       je        short M00_L15
       mov       rax,[r14+28]
       test      rax,rax
       jne       short M00_L14
       mov       rcx,offset MT_System.Threading.Tasks.Task+ContingentProperties
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+30],rax
       mov       dword ptr [rax+3C],1
       lea       rcx,[r14+28]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+30]
M00_L14:
       lea       rcx,[rax+30]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
M00_L15:
       xor       ecx,ecx
       mov       [r14+8],rcx
       mov       [r14+10],rcx
       mov       [r14+18],rcx
       test      r15d,0FFFFFFA0
       jne       near ptr M00_L07
       mov       ecx,r15d
       or        ecx,400
       or        ecx,2000000
       mov       [r14+34],ecx
       mov       rcx,[r14+28]
       test      rcx,rcx
       jne       near ptr M00_L38
M00_L16:
       mov       byte ptr [r14+3D],1
       mov       rcx,25FE9001360
       mov       rcx,[rcx]
       cmp       byte ptr [rcx+9D],0
       jne       near ptr M00_L39
M00_L17:
       cmp       byte ptr [7FF80CD2B074],0
       jne       near ptr M00_L40
M00_L18:
       test      dword ptr [r13+34],1600000
       jne       short M00_L21
       test      dword ptr [r13+34],1600000
       jne       short M00_L20
       cmp       qword ptr [r13+20],0
       jne       near ptr M00_L41
       lea       rcx,[r13+20]
       test      rcx,rcx
       je        near ptr M00_L51
       mov       rdx,r14
       xor       r8d,r8d
       call      00007FF86CA021C0
       test      rax,rax
       jne       near ptr M00_L41
M00_L19:
       movsxd    rdx,edi
       mov       rcx,rbp
       mov       r8,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       inc       edi
       jmp       near ptr M00_L00
M00_L20:
       call      00007FF86CA10B20
       test      eax,eax
       je        near ptr M00_L43
       movzx     ecx,byte ptr [r14+3C]
       test      ecx,ecx
       jne       near ptr M00_L42
M00_L21:
       mov       rcx,r14
       mov       rdx,r13
       call      qword ptr [7FF80D204918]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].ProcessCompletedOuterTask(System.Threading.Tasks.Task)
       jmp       short M00_L19
M00_L22:
       mov       rdx,rbp
       test      rdx,rdx
       je        near ptr M00_L44
       lea       rbx,[rdx+10]
       mov       esi,[rdx+8]
       test      esi,esi
       je        near ptr M00_L45
       mov       edx,esi
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Int32>[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       r8d,esi
       shl       r8,3
       cmp       r8,4000
       jbe       short M00_L23
       mov       rdx,rbx
       call      qword ptr [7FF80D20EBC8]
       jmp       short M00_L24
M00_L23:
       mov       rdx,rbx
       call      00007FF86C9D37A0
       cmp       dword ptr [7FF86CD13A90],0
       jne       near ptr M00_L46
M00_L24:
       mov       ebx,[rdi+8]
       test      ebx,ebx
       jle       short M00_L26
       lea       rcx,[rdi+10]
       mov       edx,ebx
M00_L25:
       cmp       qword ptr [rcx],0
       je        near ptr M00_L47
       add       rcx,8
       dec       edx
       jne       short M00_L25
M00_L26:
       mov       rcx,offset MT_System.Threading.Tasks.Task+WhenAllPromise<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+34],2000400
       lea       rcx,[rsi+40]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsi+48],ebx
       mov       rcx,25FE9001360
       mov       rcx,[rcx]
       cmp       byte ptr [rcx+9D],0
       jne       near ptr M00_L48
M00_L27:
       cmp       byte ptr [7FF80CD2B074],0
       jne       near ptr M00_L49
M00_L28:
       test      ebx,ebx
       jle       short M00_L33
       add       rdi,10
       jmp       short M00_L31
M00_L29:
       test      dword ptr [rbp+34],1600000
       jne       short M00_L32
       cmp       qword ptr [rbp+20],0
       jne       near ptr M00_L50
       lea       rcx,[rbp+20]
       test      rcx,rcx
       je        near ptr M00_L51
       mov       rdx,rsi
       xor       r8d,r8d
       call      00007FF86CA021C0
       test      rax,rax
       jne       near ptr M00_L50
M00_L30:
       add       rdi,8
       dec       ebx
       je        short M00_L33
M00_L31:
       mov       rbp,[rdi]
       test      dword ptr [rbp+34],1600000
       je        short M00_L29
M00_L32:
       mov       rcx,rsi
       mov       rdx,rbp
       call      qword ptr [7FF80D21B820]; System.Threading.Tasks.Task+WhenAllPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
       jmp       short M00_L30
M00_L33:
       mov       rax,rsi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L34:
       mov       rcx,offset MT_System.Threading.Tasks.TaskFactory<System.Threading.Tasks.Task<System.Int32>>
       call      CORINFO_HELP_NEWSFAST
       mov       rdx,rax
       mov       rcx,25FE9001330
       xor       r8d,r8d
       call      00007FF86CA021C0
       test      rax,rax
       jne       near ptr M00_L02
       mov       rax,25FE9001330
       mov       rax,[rax]
       jmp       near ptr M00_L02
M00_L35:
       mov       ecx,4
       call      qword ptr [7FF80D20E280]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L03
M00_L36:
       xor       r14d,r14d
       jmp       near ptr M00_L05
M00_L37:
       mov       ecx,8
       call      qword ptr [7FF80D20E280]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L13
M00_L38:
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M00_L16
       test      r15b,4
       je        near ptr M00_L16
       test      byte ptr [rcx+34],8
       jne       near ptr M00_L16
       call      qword ptr [7FF80D20DEC0]
       jmp       near ptr M00_L16
M00_L39:
       mov       rcx,r14
       call      qword ptr [7FF80D2048B8]
       mov       edx,eax
       mov       rcx,25FE9001360
       mov       rcx,[rcx]
       mov       r8,25FA5299790
       xor       r9d,r9d
       call      qword ptr [7FF80D2048D0]
       jmp       near ptr M00_L17
M00_L40:
       mov       rcx,r14
       call      qword ptr [7FF80D2048E8]
       jmp       near ptr M00_L18
M00_L41:
       mov       rcx,r13
       mov       rdx,r14
       xor       r8d,r8d
       call      qword ptr [7FF80D207330]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M00_L19
       jmp       near ptr M00_L20
M00_L42:
       cmp       ecx,1
       jne       near ptr M00_L19
       mov       rcx,r14
       mov       rdx,r13
       xor       r8d,r8d
       call      qword ptr [7FF80D2071B0]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       mov       byte ptr [r14+3C],2
       jmp       near ptr M00_L19
M00_L43:
       mov       rcx,r14
       mov       rdx,r13
       call      qword ptr [7FF80D207168]
       jmp       near ptr M00_L19
M00_L44:
       mov       ecx,33
       call      qword ptr [7FF80CDEFD38]
       int       3
M00_L45:
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Int32[]>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,rsi
       xor       edx,edx
       mov       r8,25FA5298F30
       xor       r9d,r9d
       call      qword ptr [7FF80D204F30]
       jmp       near ptr M00_L33
M00_L46:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L24
M00_L47:
       mov       ecx,1D
       mov       edx,33
       call      qword ptr [7FF80D204F60]
       int       3
M00_L48:
       mov       rcx,rsi
       call      qword ptr [7FF80D2048B8]
       mov       edx,eax
       mov       rcx,25FE9001360
       mov       rcx,[rcx]
       mov       r8,25FA5299E48
       xor       r9d,r9d
       call      qword ptr [7FF80D2048D0]
       jmp       near ptr M00_L27
M00_L49:
       mov       rcx,rsi
       call      qword ptr [7FF80D2048E8]
       jmp       near ptr M00_L28
M00_L50:
       mov       rcx,rbp
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF80D207330]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M00_L30
       jmp       near ptr M00_L32
M00_L51:
       call      qword ptr [7FF80D20DF80]
       int       3
; Total bytes of code 1735
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M01_L00
       ret
M01_L00:
       xor       edx,edx
       jmp       qword ptr [7FF80D204FF0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
; Total bytes of code 26
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
; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       [rbp+10],rcx
       test      dl,dl
       jne       near ptr M03_L19
       or        dword ptr [rcx+34],10000
M03_L00:
       cmp       byte ptr [7FF80CD2B074],0
       jne       near ptr M03_L20
M03_L01:
       mov       rax,25FE9001360
       mov       rbx,[rax]
       cmp       byte ptr [rbx+9D],0
       jne       near ptr M03_L21
M03_L02:
       mov       rsi,[rcx+18]
       cmp       [rsi],sil
       cmp       byte ptr [rbx+9D],0
       jne       near ptr M03_L10
M03_L03:
       mov       rdx,offset MT_System.Threading.Tasks.ThreadPoolTaskScheduler
       cmp       [rsi],rdx
       jne       near ptr M03_L17
       movzx     esi,word ptr [rcx+34]
       test      sil,2
       jne       near ptr M03_L11
       mov       rdx,25FE9001368
       mov       rbx,[rdx]
       cmp       byte ptr [rbx+38],0
       jne       near ptr M03_L12
M03_L04:
       test      sil,1
       jne       short M03_L06
       mov       rax,gs:[58]
       mov       rax,[rax+48]
       cmp       dword ptr [rax+238],5
       jle       near ptr M03_L13
       mov       rax,[rax+240]
       mov       rax,[rax+28]
       test      rax,rax
       je        near ptr M03_L13
M03_L05:
       mov       rdx,[rax+10]
       test      rdx,rdx
       jne       near ptr M03_L14
M03_L06:
       mov       rdx,[rbx+8]
       mov       r8,[rdx+10]
       mov       r10,[r8+8]
M03_L07:
       mov       esi,[r8+0A0]
       mov       eax,esi
       and       eax,[r8+18]
       cmp       eax,[r10+8]
       jae       near ptr M03_L15
       shl       rax,4
       lea       rdi,[r10+rax+10]
       mov       eax,[rdi+8]
       sub       eax,esi
       je        short M03_L08
       test      eax,eax
       jge       short M03_L07
       mov       rcx,rdx
       mov       rdx,[rbp+10]
       call      qword ptr [7FF80D20E538]
       jmp       short M03_L09
M03_L08:
       lea       r9,[r8+0A0]
       lea       r11d,[rsi+1]
       mov       eax,esi
       lock cmpxchg [r9],r11d
       cmp       eax,esi
       jne       short M03_L07
       mov       rdx,[rbp+10]
       mov       rcx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       inc       esi
       mov       [rdi+8],esi
M03_L09:
       add       rbx,78
       mov       ecx,1
       xchg      ecx,[rbx]
       test      ecx,ecx
       jne       near ptr M03_L18
       mov       rcx,25FE9001390
       mov       rbx,[rcx]
       lea       rcx,[rbx+178]
       lock inc  dword ptr [rcx]
       mov       rcx,rbx
       call      qword ptr [7FF80D204570]; System.Threading.PortableThreadPool+WorkerThread.MaybeAddWorkingWorker(System.Threading.PortableThreadPool)
       cmp       dword ptr [rbx+17C],6
       je        near ptr M03_L18
       jmp       near ptr M03_L16
M03_L10:
       mov       rdx,rsi
       call      qword ptr [7FF80D20E400]
       mov       rcx,[rbp+10]
       jmp       near ptr M03_L03
M03_L11:
       mov       rcx,offset MT_System.Threading.Tasks.ThreadPoolTaskScheduler
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,25FE9001410
       mov       rbx,[rcx]
       mov       rcx,offset MT_System.Threading.Thread
       call      CORINFO_HELP_NEWFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF80D20F078]
       mov       rcx,rsi
       mov       edx,1
       call      qword ptr [7FF80D2046D8]; System.Threading.Thread.set_IsBackground(Boolean)
       mov       rcx,rsi
       mov       rdx,25FA5298C38
       call      qword ptr [7FF80D2047E0]; System.Threading.Thread.set_Name(System.String)
       mov       rcx,rsi
       mov       rdx,[rbp+10]
       xor       r8d,r8d
       call      qword ptr [7FF80D20F090]
       jmp       near ptr M03_L18
M03_L12:
       mov       rdx,25FE9001380
       mov       rdx,[rdx]
       cmp       byte ptr [rdx+9D],0
       je        near ptr M03_L04
       mov       rdx,25FE9001380
       mov       rcx,[rdx]
       mov       rdx,[rbp+10]
       call      qword ptr [7FF80D20E508]
       jmp       near ptr M03_L04
M03_L13:
       mov       ecx,5
       call      qword ptr [7FF80D20E280]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M03_L05
M03_L14:
       mov       rcx,[rdx+18]
       mov       rdx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF80D20E520]
       jmp       near ptr M03_L09
M03_L15:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M03_L16:
       mov       rcx,rbx
       call      qword ptr [7FF80D204750]; System.Threading.PortableThreadPool+GateThread.EnsureRunningSlow(System.Threading.PortableThreadPool)
       jmp       short M03_L18
M03_L17:
       mov       rcx,rsi
       mov       rdx,[rbp+10]
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       nop
M03_L18:
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M03_L19:
       call      qword ptr [7FF80D20F060]
       test      eax,eax
       mov       rcx,[rbp+10]
       jne       near ptr M03_L00
       jmp       short M03_L18
M03_L20:
       call      qword ptr [7FF80D2048E8]
       mov       rcx,[rbp+10]
       jmp       near ptr M03_L01
M03_L21:
       test      word ptr [rcx+34],200
       jne       near ptr M03_L02
       call      qword ptr [7FF80D2048B8]
       mov       esi,eax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       call      qword ptr [7FF80D20E370]
       mov       rdx,rax
       mov       rcx,25FA5298BB0
       call      qword ptr [7FF80CDED9C8]; System.String.Concat(System.String, System.String)
       mov       r8,rax
       mov       edx,esi
       mov       rcx,rbx
       xor       r9d,r9d
       call      qword ptr [7FF80D2048D0]
       mov       rcx,[rbp+10]
       jmp       near ptr M03_L02
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,offset MT_System.Threading.Tasks.TaskSchedulerException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF80D20E388]
       mov       rcx,[rbp+10]
       mov       rdx,rsi
       call      qword ptr [7FF80D20E3A0]
       mov       rcx,[rbp+10]
       xor       edx,edx
       call      qword ptr [7FF80D20E3B8]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF80D20E3D0]
       test      eax,200
       jne       short M03_L22
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+28]
       mov       rcx,[rcx+18]
       xor       edx,edx
       cmp       [rcx],ecx
       call      qword ptr [7FF80D20E3E8]
M03_L22:
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 879
```
```assembly
; AsyncLazyBenchmarks.ContendedFirstCallBenchmarks+<>c__DisplayClass11_0.<VsThreading>b__0()
       mov       rcx,[rcx+8]
       cmp       [rcx],cl
       xor       edx,edx
       jmp       qword ptr [7FF80D205440]; Microsoft.VisualStudio.Threading.AsyncLazy`1[[System.Int32, System.Private.CoreLib]].GetValueAsync(System.Threading.CancellationToken)
; Total bytes of code 14
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M05_L01
       lea       rax,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       mov       rdx,[rcx+30]
       test      r8,r8
       je        short M05_L00
       cmp       rdx,[r8]
       je        short M05_L02
       mov       r10,offset MT_System.Object[]
       cmp       rcx,r10
       je        short M05_L02
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FF80D0C4EB8]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
M05_L00:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M05_L01:
       call      qword ptr [7FF80D20DEA8]
       int       3
M05_L02:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FF86CA540D0
; Total bytes of code 94
```
```assembly
; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].ProcessCompletedOuterTask(System.Threading.Tasks.Task)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       mov       byte ptr [rbx+3C],1
       mov       edx,[rsi+34]
       test      edx,200000
       jne       near ptr M06_L07
       test      edx,400000
       jne       near ptr M06_L08
       test      edx,1000000
       je        near ptr M06_L09
       mov       edi,5
M06_L00:
       cmp       edi,5
       jne       near ptr M06_L06
       mov       rcx,rsi
       mov       rax,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task<System.Int32>>
       cmp       [rcx],rax
       jne       near ptr M06_L13
M06_L01:
       test      rcx,rcx
       je        near ptr M06_L14
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       near ptr M06_L16
       mov       rdi,[rcx+38]
M06_L02:
       test      rdi,rdi
       je        near ptr M06_L17
       test      dword ptr [rdi+34],1600000
       je        short M06_L05
       mov       rcx,rbx
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FF80D2071B0]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
M06_L03:
       mov       byte ptr [rbx+3C],2
M06_L04:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M06_L05:
       test      dword ptr [rdi+34],1600000
       jne       near ptr M06_L20
       cmp       qword ptr [rdi+20],0
       jne       near ptr M06_L19
       lea       rcx,[rdi+20]
       test      rcx,rcx
       je        near ptr M06_L18
       mov       rdx,rbx
       xor       r8d,r8d
       call      00007FF86CA021C0
       test      rax,rax
       je        short M06_L04
       jmp       near ptr M06_L19
M06_L06:
       add       edi,0FFFFFFFA
       cmp       edi,1
       ja        short M06_L04
       jmp       short M06_L12
M06_L07:
       mov       edi,7
       jmp       near ptr M06_L00
M06_L08:
       mov       edi,6
       jmp       near ptr M06_L00
M06_L09:
       test      edx,800000
       je        short M06_L10
       mov       edi,4
       jmp       near ptr M06_L00
M06_L10:
       test      edx,20000
       je        short M06_L11
       mov       edi,3
       jmp       near ptr M06_L00
M06_L11:
       test      edx,2000000
       setne     dil
       movzx     edi,dil
       mov       ecx,2
       test      edx,10000
       cmovne    edi,ecx
       jmp       near ptr M06_L00
M06_L12:
       movzx     r8d,byte ptr [rbx+3D]
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF80D2071B0]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       jmp       near ptr M06_L04
M06_L13:
       mov       rdx,rsi
       mov       rcx,rax
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rcx,rax
       jmp       near ptr M06_L01
M06_L14:
       mov       rcx,rsi
       mov       rax,offset MT_System.Threading.Tasks.Task<System.Threading.Tasks.Task>
       cmp       [rcx],rax
       je        short M06_L15
       mov       rdx,rsi
       mov       rcx,rax
       call      qword ptr [7FF80CFC4D20]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       rcx,rax
M06_L15:
       cmp       [rcx],ecx
       call      qword ptr [7FF80D207258]; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].get_Result()
       mov       rdi,rax
       jmp       near ptr M06_L02
M06_L16:
       mov       edx,1
       call      qword ptr [7FF80D20E730]
       mov       rdi,rax
       jmp       near ptr M06_L02
M06_L17:
       mov       rcx,rbx
       xor       edx,edx
       xor       r8d,r8d
       call      qword ptr [7FF80D2075B8]
       jmp       near ptr M06_L03
M06_L18:
       call      qword ptr [7FF80D20DF80]
       int       3
M06_L19:
       mov       rcx,rdi
       mov       rdx,rbx
       xor       r8d,r8d
       call      qword ptr [7FF80D207330]; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M06_L04
M06_L20:
       mov       rcx,rbx
       mov       rdx,rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF80D1DB488]; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
; Total bytes of code 505
```
```assembly
; System.Threading.Tasks.Task+WhenAllPromise`1[[System.Int32, System.Private.CoreLib]].Invoke(System.Threading.Tasks.Task)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rbx,rcx
       mov       rcx,25FE9001360
       mov       rsi,[rcx]
       cmp       byte ptr [rsi+9D],0
       jne       near ptr M07_L11
M07_L00:
       lea       rdx,[rbx+48]
       mov       ecx,0FFFFFFFF
       lock xadd [rdx],ecx
       dec       ecx
       je        short M07_L02
M07_L01:
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M07_L02:
       mov       rdx,[rbx+40]
       mov       edx,[rdx+8]
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       xor       ebp,ebp
       xor       r14d,r14d
       xor       r15d,r15d
       jmp       near ptr M07_L08
M07_L03:
       cmp       r15d,[rcx+8]
       jae       near ptr M07_L23
       mov       r13d,r15d
       mov       r12,[rcx+r13*8+10]
       test      dword ptr [r12+34],200000
       jne       near ptr M07_L12
       mov       ecx,[r12+34]
       and       ecx,600000
       cmp       ecx,400000
       je        near ptr M07_L15
       test      dword ptr [r12+34],1600000
       je        near ptr M07_L16
M07_L04:
       mov       ecx,[r12+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       near ptr M07_L17
M07_L05:
       mov       ecx,[r12+38]
       cmp       r15d,[rdi+8]
       jae       near ptr M07_L23
       mov       [rdi+r13*4+10],ecx
M07_L06:
       test      dword ptr [r12+34],10000000
       jne       near ptr M07_L18
       mov       rcx,[rbx+40]
       cmp       r15d,[rcx+8]
       jae       near ptr M07_L23
       xor       edx,edx
       mov       [rcx+r13*8+10],rdx
M07_L07:
       inc       r15d
M07_L08:
       mov       rcx,[rbx+40]
       cmp       [rcx+8],r15d
       jg        near ptr M07_L03
       test      rbp,rbp
       jne       near ptr M07_L19
       test      r14,r14
       jne       near ptr M07_L20
       cmp       byte ptr [rsi+9D],0
       jne       near ptr M07_L21
M07_L09:
       cmp       byte ptr [7FF80CD2B074],0
       jne       near ptr M07_L22
M07_L10:
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7FF80D207888]; System.Threading.Tasks.Task`1[[System.__Canon, System.Private.CoreLib]].TrySetResult(System.__Canon)
       jmp       near ptr M07_L01
M07_L11:
       mov       rcx,rbx
       call      qword ptr [7FF80D2048B8]
       mov       edx,eax
       mov       rcx,rsi
       mov       r8d,1
       call      qword ptr [7FF80D207570]
       jmp       near ptr M07_L00
M07_L12:
       test      rbp,rbp
       jne       short M07_L13
       mov       rcx,offset MT_System.Collections.Generic.List<System.Runtime.ExceptionServices.ExceptionDispatchInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FF80D0CC4C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
M07_L13:
       mov       rcx,[r12+28]
       mov       rax,[rcx+18]
       mov       [rsp+30],rax
       mov       rdx,[rax+10]
       mov       [rsp+28],rdx
       cmp       byte ptr [rax+20],0
       jne       short M07_L14
       mov       rcx,rax
       call      qword ptr [7FF80D0C55F0]; System.GC.SuppressFinalize(System.Object)
       mov       rcx,[rsp+30]
       mov       byte ptr [rcx+20],1
M07_L14:
       mov       rcx,rbp
       mov       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FF80D207810]
       jmp       near ptr M07_L06
M07_L15:
       test      r14,r14
       jne       near ptr M07_L06
       mov       r14,r12
       jmp       near ptr M07_L06
M07_L16:
       mov       rcx,r12
       mov       edx,0FFFFFFFF
       xor       r8d,r8d
       call      qword ptr [7FF80D205008]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
       jmp       near ptr M07_L04
M07_L17:
       mov       rcx,r12
       mov       edx,1
       call      qword ptr [7FF80D20F1E0]
       jmp       near ptr M07_L05
M07_L18:
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FF80D207870]
       jmp       near ptr M07_L07
M07_L19:
       mov       rcx,rbx
       mov       rdx,rbp
       call      qword ptr [7FF80D206628]; System.Threading.Tasks.Task.TrySetException(System.Object)
       jmp       near ptr M07_L01
M07_L20:
       mov       rcx,r14
       call      qword ptr [7FF80D207588]
       mov       rbp,rax
       mov       rcx,r14
       call      qword ptr [7FF80D2075A0]
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,rbx
       call      qword ptr [7FF80D2075B8]
       jmp       near ptr M07_L01
M07_L21:
       mov       rcx,rbx
       call      qword ptr [7FF80D2048B8]
       mov       edx,eax
       mov       rcx,rsi
       mov       r8d,1
       call      qword ptr [7FF80D207648]
       jmp       near ptr M07_L09
M07_L22:
       mov       rcx,rbx
       call      qword ptr [7FF80D207660]
       jmp       near ptr M07_L10
M07_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 662
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
       jne       short M08_L01
       cmp       [rax],ecx
       jle       short M08_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M08_L03
M08_L00:
       add       rsp,20
       pop       rbx
       ret
M08_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M08_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M08_L00
M08_L02:
       cmp       [rax+4],edx
       jle       short M08_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M08_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M08_L03
       jmp       short M08_L00
M08_L03:
       mov       ecx,ebx
       lea       rax,[System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Threading.Tasks.Task.AddTaskContinuationComplex(System.Object, Boolean)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+60]
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       mov       r14,[rbx+20]
       mov       rdx,25FE9000218
       mov       r15,[rdx]
       cmp       r14,r15
       je        near ptr M09_L02
       mov       r13,r14
       test      r13,r13
       je        short M09_L00
       mov       rdx,offset MT_System.Threading.Tasks.UnwrapPromise<System.Int32>
       cmp       [r13],rdx
       jne       near ptr M09_L15
       xor       r13d,r13d
M09_L00:
       test      r13,r13
       jne       near ptr M09_L03
       mov       rcx,offset MT_System.Collections.Generic.List<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,25FE9000A60
       mov       rdx,[rcx]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      dil,dil
       jne       near ptr M09_L17
       inc       dword ptr [r13+14]
       mov       rcx,r13
       mov       rdx,r14
       call      qword ptr [7FF80CDE71C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       inc       dword ptr [r13+14]
       mov       rcx,[r13+8]
       mov       edx,[r13+10]
       cmp       [rcx+8],edx
       jbe       near ptr M09_L16
       lea       r8d,[rdx+1]
       mov       [r13+10],r8d
       mov       edx,edx
       mov       r8,rsi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M09_L01:
       lea       rcx,[rbx+20]
       test      rcx,rcx
       je        near ptr M09_L19
       mov       rdx,r13
       mov       r8,r14
       call      00007FF86CA021C0
       mov       r13,rax
       cmp       r13,r14
       je        near ptr M09_L14
       mov       rdx,r13
       mov       rcx,offset MT_System.Collections.Generic.List<System.Object>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r13,rax
       test      r13,r13
       jne       short M09_L03
M09_L02:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M09_L03:
       mov       [rbp-40],r13
       xor       ecx,ecx
       mov       [rbp-34],ecx
       mov       rcx,r13
       call      00007FF86CA5E120
       test      eax,eax
       je        short M09_L07
M09_L04:
       mov       dword ptr [rbp-34],1
       cmp       [rbx+20],r15
       je        near ptr M09_L11
       mov       ecx,[r13+10]
       mov       rax,[r13+8]
       cmp       ecx,[rax+8]
       je        short M09_L08
M09_L05:
       test      dil,dil
       jne       near ptr M09_L10
       inc       dword ptr [r13+14]
       mov       rcx,[r13+8]
       mov       edx,[r13+10]
       cmp       [rcx+8],edx
       jbe       short M09_L06
       lea       r8d,[rdx+1]
       mov       [r13+10],r8d
       mov       edx,edx
       mov       r8,rsi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M09_L13
M09_L06:
       mov       rcx,r13
       mov       rdx,rsi
       call      qword ptr [7FF80CDE71C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M09_L13
M09_L07:
       mov       rcx,r13
       call      qword ptr [7FF80D205788]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M09_L04
M09_L08:
       mov       rcx,25FE9000270
       mov       rdx,[rcx]
       test      rdx,rdx
       jne       short M09_L09
       mov       rcx,offset MT_System.Predicate<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,25FE9000240
       mov       rdx,[rdx]
       mov       rcx,rbx
       mov       r8,offset System.Threading.Tasks.Task+<>c.<AddTaskContinuationComplex>b__211_0(System.Object)
       call      qword ptr [7FF80CDE6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,25FE9000270
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rbx
M09_L09:
       mov       rcx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FF80D2073A8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].RemoveAll(System.Predicate`1<System.__Canon>)
       jmp       near ptr M09_L05
M09_L10:
       mov       rcx,r13
       mov       r8,rsi
       xor       edx,edx
       call      qword ptr [7FF80CED35F0]
       jmp       short M09_L13
M09_L11:
       mov       rcx,r13
       call      00007FF86CA5E040
       test      eax,eax
       jne       near ptr M09_L20
M09_L12:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
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
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M09_L15:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.List<System.Object>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r13,rax
       jmp       near ptr M09_L00
M09_L16:
       mov       rcx,r13
       mov       rdx,rsi
       call      qword ptr [7FF80CDE71C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M09_L01
M09_L17:
       inc       dword ptr [r13+14]
       mov       rcx,r13
       mov       rdx,rsi
       call      qword ptr [7FF80CDE71C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       inc       dword ptr [r13+14]
       mov       rcx,[r13+8]
       mov       edx,[r13+10]
       cmp       [rcx+8],edx
       jbe       short M09_L18
       lea       r8d,[rdx+1]
       mov       [r13+10],r8d
       mov       edx,edx
       mov       r8,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M09_L01
M09_L18:
       mov       rcx,r13
       mov       rdx,r14
       call      qword ptr [7FF80CDE71C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M09_L01
M09_L19:
       call      qword ptr [7FF80D20DF80]
       int       3
M09_L20:
       mov       ecx,eax
       mov       rdx,r13
       call      qword ptr [7FF80D206F40]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
       jmp       near ptr M09_L12
M09_L21:
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M09_L22
       mov       rcx,[rbp-40]
       call      00007FF86CA5E040
       test      eax,eax
       je        short M09_L22
       mov       ecx,eax
       mov       rdx,[rbp-40]
       call      qword ptr [7FF80D206F40]; System.Threading.Monitor.Exit_Slowpath(LeaveHelperAction, System.Object)
M09_L22:
       nop
       add       rsp,28
       ret
; Total bytes of code 765
```
```assembly
; System.Threading.Tasks.UnwrapPromise`1[[System.Int32, System.Private.CoreLib]].TrySetFromTask(System.Threading.Tasks.Task, Boolean)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
M10_L00:
       mov       rcx,25FE9001360
       mov       rbp,[rcx]
       cmp       byte ptr [rbp+9D],0
       jne       near ptr M10_L13
M10_L01:
       xor       eax,eax
       mov       ecx,[rsi+34]
       test      ecx,200000
       jne       near ptr M10_L14
       test      ecx,400000
       jne       near ptr M10_L15
       test      ecx,1000000
       je        near ptr M10_L16
       mov       edx,5
M10_L02:
       add       edx,0FFFFFFFB
       jne       near ptr M10_L19
       cmp       byte ptr [rbp+9D],0
       jne       near ptr M10_L21
M10_L03:
       cmp       byte ptr [7FF80CD2B074],0
       jne       near ptr M10_L22
M10_L04:
       mov       rcx,rsi
       mov       rdx,offset MT_System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Int32>+AsyncStateMachineBox<Microsoft.VisualStudio.Threading.AsyncLazy<System.Int32>+<>c__DisplayClass20_0+<<GetValueAsync>b__0>d>
       cmp       [rcx],rdx
       jne       near ptr M10_L23
M10_L05:
       test      rcx,rcx
       je        near ptr M10_L12
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       near ptr M10_L24
       mov       esi,[rcx+38]
M10_L06:
       xor       edi,edi
       mov       eax,[rbx+34]
       mov       [rsp+24],eax
       test      eax,5600000
       jne       short M10_L10
       lea       rcx,[rbx+34]
       mov       edx,eax
       or        edx,4000000
       lock cmpxchg [rcx],edx
       cmp       eax,[rsp+24]
       jne       near ptr M10_L25
M10_L07:
       mov       [rbx+38],esi
       lea       rcx,[rbx+34]
       mov       eax,[rbx+34]
       or        eax,1000000
       xchg      eax,[rcx]
       mov       rdi,[rbx+28]
       test      rdi,rdi
       jne       near ptr M10_L26
M10_L08:
       lea       rcx,[rbx+20]
       test      rcx,rcx
       je        near ptr M10_L27
       mov       rdx,25FE9000218
       mov       rdx,[rdx]
       call      00007FF86CA0C330
       test      rax,rax
       je        short M10_L09
       mov       rcx,rbx
       mov       rdx,rax
       call      qword ptr [7FF80D207090]; System.Threading.Tasks.Task.RunContinuations(System.Object)
M10_L09:
       mov       edi,1
M10_L10:
       mov       eax,edi
M10_L11:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M10_L12:
       xor       esi,esi
       jmp       near ptr M10_L06
M10_L13:
       mov       rcx,rbx
       call      qword ptr [7FF80D2048B8]
       mov       edx,eax
       mov       rcx,rbp
       mov       r8d,1
       call      qword ptr [7FF80D207570]
       jmp       near ptr M10_L01
M10_L14:
       mov       edx,7
       jmp       near ptr M10_L02
M10_L15:
       mov       edx,6
       jmp       near ptr M10_L02
M10_L16:
       test      ecx,800000
       je        short M10_L17
       mov       edx,4
       jmp       near ptr M10_L02
M10_L17:
       test      ecx,20000
       je        short M10_L18
       mov       edx,3
       jmp       near ptr M10_L02
M10_L18:
       test      ecx,2000000
       setne     dl
       movzx     edx,dl
       mov       r8d,2
       test      ecx,10000
       cmovne    edx,r8d
       jmp       near ptr M10_L02
M10_L19:
       cmp       edx,2
       ja        near ptr M10_L11
       mov       ecx,edx
       lea       rax,[7FF80CE6FB38]
       mov       eax,[rax+rcx*4]
       lea       rdx,[M10_L00]
       add       rax,rdx
       jmp       rax
       mov       rcx,rsi
       call      qword ptr [7FF80D207588]
       mov       rdi,rax
       mov       rcx,rsi
       call      qword ptr [7FF80D2075A0]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF80D2075B8]
       jmp       near ptr M10_L11
       mov       rcx,rsi
       call      qword ptr [7FF80D2075D0]
       mov       rsi,rax
       test      dil,dil
       je        short M10_L20
       cmp       dword ptr [rsi+10],0
       jle       short M10_L20
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF80CED3578]
       mov       rbp,rax
       test      rbp,rbp
       je        short M10_L20
       mov       rdx,[rbp+8]
       mov       rcx,offset MT_System.OperationCanceledException
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M10_L20
       mov       rdx,[rax+70]
       mov       rcx,rbx
       mov       r8,rbp
       call      qword ptr [7FF80D2075B8]
       jmp       near ptr M10_L11
M10_L20:
       mov       rcx,rbx
       mov       rdx,rsi
       call      qword ptr [7FF80D206628]; System.Threading.Tasks.Task.TrySetException(System.Object)
       jmp       near ptr M10_L11
M10_L21:
       mov       rcx,rbx
       call      qword ptr [7FF80D2048B8]
       mov       edx,eax
       mov       rcx,rbp
       mov       r8d,1
       call      qword ptr [7FF80D207648]
       jmp       near ptr M10_L03
M10_L22:
       mov       rcx,rbx
       call      qword ptr [7FF80D207660]
       jmp       near ptr M10_L04
M10_L23:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rcx,rax
       jmp       near ptr M10_L05
M10_L24:
       mov       edx,1
       call      qword ptr [7FF80D207840]; System.Threading.Tasks.Task`1[[System.Int32, System.Private.CoreLib]].GetResultCore(Boolean)
       mov       esi,eax
       jmp       near ptr M10_L06
M10_L25:
       mov       rcx,rbx
       mov       edx,4000000
       mov       r8d,5600000
       call      qword ptr [7FF80D20E340]
       test      eax,eax
       je        near ptr M10_L10
       jmp       near ptr M10_L07
M10_L26:
       mov       rcx,rbx
       call      qword ptr [7FF80D206730]; System.Threading.Tasks.Task.NotifyParentIfPotentiallyAttachedTask()
       mov       rcx,rdi
       call      qword ptr [7FF80D20E550]
       jmp       near ptr M10_L08
M10_L27:
       call      qword ptr [7FF80D20DF80]
       int       3
; Total bytes of code 772
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      dword ptr [rbx+34],1600000
       jne       short M11_L00
       mov       rcx,rbx
       mov       edx,0FFFFFFFF
       xor       r8d,r8d
       call      qword ptr [7FF80D205008]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M11_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M11_L03
M11_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M11_L04
M11_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M11_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M11_L01
       mov       rcx,rbx
       call      qword ptr [7FF80D20EDF0]
       jmp       short M11_L01
M11_L04:
       test      sil,2
       jne       short M11_L05
       mov       rcx,rbx
       call      qword ptr [7FF80D20ECA0]
M11_L05:
       mov       rcx,rbx
       call      qword ptr [7FF80D20F3C0]
       jmp       short M11_L02
; Total bytes of code 124
```

