#define ICALL_TABLE_corlib 1

static int corlib_icall_indexes [] = {
182,
189,
190,
191,
192,
193,
194,
195,
196,
197,
200,
201,
365,
366,
368,
396,
397,
398,
418,
419,
420,
421,
422,
501,
502,
503,
506,
544,
545,
547,
549,
551,
553,
558,
566,
567,
568,
569,
570,
571,
572,
573,
574,
575,
576,
577,
578,
579,
580,
581,
582,
583,
584,
585,
586,
587,
588,
589,
590,
591,
592,
674,
675,
676,
677,
678,
679,
680,
681,
682,
683,
684,
685,
686,
687,
688,
689,
690,
691,
692,
693,
694,
695,
696,
697,
698,
821,
822,
829,
832,
834,
839,
840,
842,
843,
847,
848,
849,
850,
852,
853,
854,
857,
858,
861,
862,
863,
932,
933,
935,
943,
944,
945,
946,
947,
951,
952,
953,
954,
955,
956,
958,
959,
960,
962,
963,
964,
968,
969,
970,
1238,
1418,
1419,
7395,
7396,
7398,
7399,
7400,
7401,
7402,
7404,
7406,
7408,
7409,
7410,
7418,
7420,
7424,
7425,
7427,
7429,
7431,
7443,
7452,
7453,
7455,
7456,
7457,
7458,
7459,
7461,
7463,
8398,
8402,
8404,
8405,
8406,
8407,
8453,
8454,
8455,
8472,
8473,
8474,
8475,
8507,
8552,
8555,
8563,
8564,
8565,
8948,
8952,
8953,
8985,
8986,
8987,
9005,
9011,
9018,
9028,
9032,
9112,
9113,
9123,
9124,
9125,
9126,
9127,
9128,
9135,
9148,
9168,
9169,
9177,
9179,
9186,
9187,
9190,
9192,
9197,
9203,
9204,
9211,
9213,
9223,
9226,
9227,
9228,
9238,
9249,
9255,
9256,
9257,
9259,
9260,
9270,
9288,
9303,
9304,
9322,
9327,
9357,
9358,
9788,
9929,
10175,
10176,
10184,
10185,
10186,
10192,
10265,
10425,
10426,
11689,
11708,
11715,
11716,
11718,
};
void ves_icall_System_Array_InternalCreate (int,int,int,int,int);
int ves_icall_System_Array_GetCorElementTypeOfElementType_raw (int,int);
int ves_icall_System_Array_IsValueOfElementType_raw (int,int,int);
int ves_icall_System_Array_CanChangePrimitive (int,int,int);
int ves_icall_System_Array_FastCopy_raw (int,int,int,int,int,int);
int ves_icall_System_Array_GetLength_raw (int,int,int);
int ves_icall_System_Array_GetLowerBound_raw (int,int,int);
void ves_icall_System_Array_GetGenericValue_icall (int,int,int);
int ves_icall_System_Array_GetValueImpl_raw (int,int,int);
void ves_icall_System_Array_SetGenericValue_icall (int,int,int);
void ves_icall_System_Array_SetValueImpl_raw (int,int,int,int);
void ves_icall_System_Array_SetValueRelaxedImpl_raw (int,int,int,int);
void ves_icall_System_Runtime_RuntimeImports_Memmove (int,int,int);
void ves_icall_System_Buffer_BulkMoveWithWriteBarrier (int,int,int,int);
void ves_icall_System_Runtime_RuntimeImports_ZeroMemory (int,int);
int ves_icall_System_Delegate_AllocDelegateLike_internal_raw (int,int);
int ves_icall_System_Delegate_CreateDelegate_internal_raw (int,int,int,int,int);
int ves_icall_System_Delegate_GetVirtualMethod_internal_raw (int,int);
int ves_icall_System_Enum_GetEnumValuesAndNames_raw (int,int,int,int);
int ves_icall_System_Enum_ToObject_raw (int,int64_t,int);
int ves_icall_System_Enum_InternalGetCorElementType_raw (int,int);
int ves_icall_System_Enum_get_underlying_type_raw (int,int);
int ves_icall_System_Enum_InternalHasFlag_raw (int,int,int);
int ves_icall_System_Environment_get_ProcessorCount ();
int ves_icall_System_Environment_get_TickCount ();
int64_t ves_icall_System_Environment_get_TickCount64 ();
void ves_icall_System_Environment_FailFast_raw (int,int,int,int);
void ves_icall_System_GC_register_ephemeron_array_raw (int,int);
int ves_icall_System_GC_get_ephemeron_tombstone_raw (int);
void ves_icall_System_GC_SuppressFinalize_raw (int,int);
void ves_icall_System_GC_ReRegisterForFinalize_raw (int,int);
void ves_icall_System_GC_GetGCMemoryInfo (int,int,int,int,int,int);
int ves_icall_System_GC_AllocPinnedArray_raw (int,int,int);
int ves_icall_System_Object_MemberwiseClone_raw (int,int);
double ves_icall_System_Math_Abs_double (double);
float ves_icall_System_Math_Abs_single (float);
double ves_icall_System_Math_Acos (double);
double ves_icall_System_Math_Acosh (double);
double ves_icall_System_Math_Asin (double);
double ves_icall_System_Math_Asinh (double);
double ves_icall_System_Math_Atan (double);
double ves_icall_System_Math_Atan2 (double,double);
double ves_icall_System_Math_Atanh (double);
double ves_icall_System_Math_Cbrt (double);
double ves_icall_System_Math_Ceiling (double);
double ves_icall_System_Math_Cos (double);
double ves_icall_System_Math_Cosh (double);
double ves_icall_System_Math_Exp (double);
double ves_icall_System_Math_Floor (double);
double ves_icall_System_Math_Log (double);
double ves_icall_System_Math_Log10 (double);
double ves_icall_System_Math_Pow (double,double);
double ves_icall_System_Math_Sin (double);
double ves_icall_System_Math_Sinh (double);
double ves_icall_System_Math_Sqrt (double);
double ves_icall_System_Math_Tan (double);
double ves_icall_System_Math_Tanh (double);
double ves_icall_System_Math_FusedMultiplyAdd (double,double,double);
int ves_icall_System_Math_ILogB (double);
double ves_icall_System_Math_Log2 (double);
double ves_icall_System_Math_ModF (double,int);
float ves_icall_System_MathF_Acos (float);
float ves_icall_System_MathF_Acosh (float);
float ves_icall_System_MathF_Asin (float);
float ves_icall_System_MathF_Asinh (float);
float ves_icall_System_MathF_Atan (float);
float ves_icall_System_MathF_Atan2 (float,float);
float ves_icall_System_MathF_Atanh (float);
float ves_icall_System_MathF_Cbrt (float);
float ves_icall_System_MathF_Ceiling (float);
float ves_icall_System_MathF_Cos (float);
float ves_icall_System_MathF_Cosh (float);
float ves_icall_System_MathF_Exp (float);
float ves_icall_System_MathF_Floor (float);
float ves_icall_System_MathF_Log (float);
float ves_icall_System_MathF_Log10 (float);
float ves_icall_System_MathF_Pow (float,float);
float ves_icall_System_MathF_Sin (float);
float ves_icall_System_MathF_Sinh (float);
float ves_icall_System_MathF_Sqrt (float);
float ves_icall_System_MathF_Tan (float);
float ves_icall_System_MathF_Tanh (float);
float ves_icall_System_MathF_FusedMultiplyAdd (float,float,float);
int ves_icall_System_MathF_ILogB (float);
float ves_icall_System_MathF_Log2 (float);
float ves_icall_System_MathF_ModF (float,int);
int ves_icall_RuntimeType_GetCorrespondingInflatedMethod_raw (int,int,int);
int ves_icall_RuntimeType_GetCorrespondingInflatedMethod_raw (int,int,int);
int ves_icall_RuntimeType_make_array_type_raw (int,int,int);
int ves_icall_RuntimeType_make_byref_type_raw (int,int);
int ves_icall_RuntimeType_MakePointerType_raw (int,int);
int ves_icall_RuntimeType_MakeGenericType_raw (int,int,int);
int ves_icall_RuntimeType_GetMethodsByName_native_raw (int,int,int,int,int);
int ves_icall_RuntimeType_GetPropertiesByName_native_raw (int,int,int,int,int);
int ves_icall_RuntimeType_GetConstructors_native_raw (int,int,int);
int ves_icall_System_Activator_CreateInstanceInternal_raw (int,int);
int ves_icall_RuntimeType_get_DeclaringMethod_raw (int,int);
int ves_icall_System_RuntimeType_getFullName_raw (int,int,int,int);
int ves_icall_RuntimeType_GetGenericArguments_raw (int,int,int);
int ves_icall_RuntimeType_GetGenericParameterPosition_raw (int,int);
int ves_icall_RuntimeType_GetEvents_native_raw (int,int,int,int);
int ves_icall_RuntimeType_GetFields_native_raw (int,int,int,int,int);
int ves_icall_RuntimeType_GetInterfaces_raw (int,int);
int ves_icall_RuntimeType_GetNestedTypes_native_raw (int,int,int,int,int);
int ves_icall_RuntimeType_get_DeclaringType_raw (int,int);
int ves_icall_RuntimeType_get_Name_raw (int,int);
int ves_icall_RuntimeType_get_Namespace_raw (int,int);
int ves_icall_RuntimeTypeHandle_GetAttributes_raw (int,int);
int ves_icall_reflection_get_token_raw (int,int);
int ves_icall_RuntimeTypeHandle_GetGenericTypeDefinition_impl_raw (int,int);
int ves_icall_RuntimeTypeHandle_GetCorElementType_raw (int,int);
int ves_icall_RuntimeTypeHandle_HasInstantiation_raw (int,int);
int ves_icall_RuntimeTypeHandle_IsComObject_raw (int,int);
int ves_icall_RuntimeTypeHandle_IsInstanceOfType_raw (int,int,int);
int ves_icall_RuntimeTypeHandle_HasReferences_raw (int,int);
int ves_icall_RuntimeTypeHandle_GetArrayRank_raw (int,int);
int ves_icall_RuntimeTypeHandle_GetAssembly_raw (int,int);
int ves_icall_RuntimeTypeHandle_GetElementType_raw (int,int);
int ves_icall_RuntimeTypeHandle_GetModule_raw (int,int);
int ves_icall_RuntimeTypeHandle_IsGenericVariable_raw (int,int);
int ves_icall_RuntimeTypeHandle_GetBaseType_raw (int,int);
int ves_icall_RuntimeTypeHandle_type_is_assignable_from_raw (int,int,int);
int ves_icall_RuntimeTypeHandle_IsGenericTypeDefinition_raw (int,int);
int ves_icall_RuntimeTypeHandle_GetGenericParameterInfo_raw (int,int);
int ves_icall_RuntimeTypeHandle_is_subclass_of (int,int);
int ves_icall_RuntimeTypeHandle_IsByRefLike_raw (int,int);
int ves_icall_System_RuntimeTypeHandle_internal_from_name_raw (int,int,int,int,int,int);
int ves_icall_System_String_FastAllocateString_raw (int,int);
int ves_icall_System_String_InternalIsInterned_raw (int,int);
int ves_icall_System_String_InternalIntern_raw (int,int);
int ves_icall_System_Type_internal_from_handle_raw (int,int);
int ves_icall_System_ValueType_InternalGetHashCode_raw (int,int,int);
int ves_icall_System_ValueType_Equals_raw (int,int,int,int);
int ves_icall_System_Threading_Interlocked_CompareExchange_Int (int,int,int);
void ves_icall_System_Threading_Interlocked_CompareExchange_Object (int,int,int,int);
int ves_icall_System_Threading_Interlocked_Decrement_Int (int);
int ves_icall_System_Threading_Interlocked_Increment_Int (int);
int64_t ves_icall_System_Threading_Interlocked_Increment_Long (int);
int ves_icall_System_Threading_Interlocked_Exchange_Int (int,int);
void ves_icall_System_Threading_Interlocked_Exchange_Object (int,int,int);
int64_t ves_icall_System_Threading_Interlocked_CompareExchange_Long (int,int64_t,int64_t);
int64_t ves_icall_System_Threading_Interlocked_Exchange_Long (int,int64_t);
int64_t ves_icall_System_Threading_Interlocked_Read_Long (int);
int ves_icall_System_Threading_Interlocked_Add_Int (int,int);
int64_t ves_icall_System_Threading_Interlocked_Add_Long (int,int64_t);
void ves_icall_System_Threading_Monitor_Monitor_Enter_raw (int,int);
void mono_monitor_exit_icall_raw (int,int);
int ves_icall_System_Threading_Monitor_Monitor_test_synchronised_raw (int,int);
void ves_icall_System_Threading_Monitor_Monitor_pulse_raw (int,int);
void ves_icall_System_Threading_Monitor_Monitor_pulse_all_raw (int,int);
int ves_icall_System_Threading_Monitor_Monitor_wait_raw (int,int,int,int);
void ves_icall_System_Threading_Monitor_Monitor_try_enter_with_atomic_var_raw (int,int,int,int,int);
int ves_icall_System_Threading_Thread_GetCurrentProcessorNumber_raw (int);
void ves_icall_System_Threading_Thread_InitInternal_raw (int,int);
int ves_icall_System_Threading_Thread_GetCurrentThread ();
void ves_icall_System_Threading_InternalThread_Thread_free_internal_raw (int,int);
int ves_icall_System_Threading_Thread_GetState_raw (int,int);
void ves_icall_System_Threading_Thread_SetState_raw (int,int,int);
void ves_icall_System_Threading_Thread_ClrState_raw (int,int,int);
void ves_icall_System_Threading_Thread_SetName_icall_raw (int,int,int,int);
int ves_icall_System_Threading_Thread_YieldInternal ();
void ves_icall_System_Threading_Thread_SetPriority_raw (int,int,int);
void ves_icall_System_Runtime_Loader_AssemblyLoadContext_PrepareForAssemblyLoadContextRelease_raw (int,int,int);
int ves_icall_System_Runtime_Loader_AssemblyLoadContext_GetLoadContextForAssembly_raw (int,int);
int ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalLoadFile_raw (int,int,int,int);
int ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalInitializeNativeALC_raw (int,int,int,int,int);
int ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalLoadFromStream_raw (int,int,int,int,int,int);
int ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalGetLoadedAssemblies_raw (int);
int ves_icall_System_GCHandle_InternalAlloc_raw (int,int,int);
void ves_icall_System_GCHandle_InternalFree_raw (int,int);
int ves_icall_System_GCHandle_InternalGet_raw (int,int);
int ves_icall_System_Runtime_InteropServices_Marshal_GetLastPInvokeError ();
void ves_icall_System_Runtime_InteropServices_Marshal_SetLastPInvokeError (int);
void ves_icall_System_Runtime_InteropServices_Marshal_StructureToPtr_raw (int,int,int,int);
int ves_icall_System_Runtime_InteropServices_Marshal_IsPinnableType_raw (int,int);
int ves_icall_System_Runtime_InteropServices_NativeLibrary_LoadByName_raw (int,int,int,int,int,int);
int mono_object_hash_icall_raw (int,int);
int ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetObjectValue_raw (int,int);
int ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetUninitializedObjectInternal_raw (int,int);
void ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_InitializeArray_raw (int,int,int);
int ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_SufficientExecutionStack ();
int ves_icall_System_Reflection_Assembly_GetEntryAssembly_raw (int);
int ves_icall_System_Reflection_Assembly_InternalLoad_raw (int,int,int,int);
int ves_icall_System_Reflection_Assembly_InternalGetType_raw (int,int,int,int,int,int);
void mono_digest_get_public_token (int,int,int);
int ves_icall_System_Reflection_AssemblyName_GetNativeName (int);
int ves_icall_System_Reflection_AssemblyName_ParseAssemblyName (int,int,int,int);
int ves_icall_MonoCustomAttrs_GetCustomAttributesInternal_raw (int,int,int,int);
int ves_icall_MonoCustomAttrs_GetCustomAttributesDataInternal_raw (int,int);
int ves_icall_MonoCustomAttrs_IsDefinedInternal_raw (int,int,int);
int ves_icall_System_Reflection_FieldInfo_internal_from_handle_type_raw (int,int,int);
int ves_icall_System_Reflection_FieldInfo_get_marshal_info_raw (int,int);
int ves_icall_System_Reflection_RuntimeAssembly_GetManifestResourceNames_raw (int,int);
int ves_icall_System_Reflection_RuntimeAssembly_GetExportedTypes_raw (int,int);
int ves_icall_System_Reflection_RuntimeAssembly_get_location_raw (int,int);
int ves_icall_System_Reflection_RuntimeAssembly_get_code_base_raw (int,int);
int ves_icall_System_Reflection_RuntimeAssembly_get_fullname_raw (int,int);
int ves_icall_System_Reflection_RuntimeAssembly_GetManifestResourceInternal_raw (int,int,int,int,int);
int ves_icall_System_Reflection_Assembly_GetManifestModuleInternal_raw (int,int);
int ves_icall_System_Reflection_RuntimeAssembly_GetModulesInternal_raw (int,int);
void ves_icall_System_Reflection_RuntimeCustomAttributeData_ResolveArgumentsInternal_raw (int,int,int,int,int,int,int);
void ves_icall_RuntimeEventInfo_get_event_info_raw (int,int,int);
int ves_icall_reflection_get_token_raw (int,int);
int ves_icall_System_Reflection_EventInfo_internal_from_handle_type_raw (int,int,int);
int ves_icall_RuntimeFieldInfo_ResolveType_raw (int,int);
int ves_icall_RuntimeFieldInfo_GetParentType_raw (int,int,int);
int ves_icall_RuntimeFieldInfo_GetFieldOffset_raw (int,int);
int ves_icall_RuntimeFieldInfo_GetValueInternal_raw (int,int,int);
void ves_icall_RuntimeFieldInfo_SetValueInternal_raw (int,int,int,int);
int ves_icall_RuntimeFieldInfo_GetRawConstantValue_raw (int,int);
int ves_icall_reflection_get_token_raw (int,int);
void ves_icall_get_method_info_raw (int,int,int);
int ves_icall_get_method_attributes (int);
int ves_icall_System_Reflection_MonoMethodInfo_get_parameter_info_raw (int,int,int);
int ves_icall_System_MonoMethodInfo_get_retval_marshal_raw (int,int);
int ves_icall_System_Reflection_RuntimeMethodInfo_GetMethodFromHandleInternalType_native_raw (int,int,int,int);
int ves_icall_RuntimeMethodInfo_get_name_raw (int,int);
int ves_icall_RuntimeMethodInfo_get_base_method_raw (int,int,int);
int ves_icall_reflection_get_token_raw (int,int);
int ves_icall_InternalInvoke_raw (int,int,int,int,int);
void ves_icall_RuntimeMethodInfo_GetPInvoke_raw (int,int,int,int,int);
int ves_icall_RuntimeMethodInfo_MakeGenericMethod_impl_raw (int,int,int);
int ves_icall_RuntimeMethodInfo_GetGenericArguments_raw (int,int);
int ves_icall_RuntimeMethodInfo_GetGenericMethodDefinition_raw (int,int);
int ves_icall_RuntimeMethodInfo_get_IsGenericMethodDefinition_raw (int,int);
int ves_icall_RuntimeMethodInfo_get_IsGenericMethod_raw (int,int);
int ves_icall_InternalInvoke_raw (int,int,int,int,int);
int ves_icall_reflection_get_token_raw (int,int);
int ves_icall_System_Reflection_RuntimeModule_InternalGetTypes_raw (int,int);
int ves_icall_System_Reflection_RuntimeModule_ResolveMethodToken_raw (int,int,int,int,int,int);
int ves_icall_RuntimeParameterInfo_GetTypeModifiers_raw (int,int,int,int,int);
void ves_icall_RuntimePropertyInfo_get_property_info_raw (int,int,int,int);
int ves_icall_reflection_get_token_raw (int,int);
int ves_icall_System_Reflection_RuntimePropertyInfo_internal_from_handle_type_raw (int,int,int);
void ves_icall_AssemblyBuilder_basic_init_raw (int,int);
void ves_icall_DynamicMethod_create_dynamic_method_raw (int,int);
void ves_icall_ModuleBuilder_basic_init_raw (int,int);
void ves_icall_ModuleBuilder_set_wrappers_type_raw (int,int,int);
int ves_icall_ModuleBuilder_getUSIndex_raw (int,int,int);
int ves_icall_ModuleBuilder_getToken_raw (int,int,int,int);
int ves_icall_ModuleBuilder_getMethodToken_raw (int,int,int,int);
void ves_icall_ModuleBuilder_RegisterToken_raw (int,int,int,int);
int ves_icall_TypeBuilder_create_runtime_class_raw (int,int);
int ves_icall_System_IO_Stream_HasOverriddenBeginEndRead_raw (int,int);
int ves_icall_System_IO_Stream_HasOverriddenBeginEndWrite_raw (int,int);
int ves_icall_Mono_RuntimeClassHandle_GetTypeFromClass (int);
void ves_icall_Mono_RuntimeGPtrArrayHandle_GPtrArrayFree (int);
void ves_icall_Mono_RuntimeMarshal_FreeAssemblyName (int,int);
int ves_icall_Mono_SafeStringMarshal_StringToUtf8 (int);
void ves_icall_Mono_SafeStringMarshal_GFree (int);
static void *corlib_icall_funcs [] = {
// token 182,
ves_icall_System_Array_InternalCreate,
// token 189,
ves_icall_System_Array_GetCorElementTypeOfElementType_raw,
// token 190,
ves_icall_System_Array_IsValueOfElementType_raw,
// token 191,
ves_icall_System_Array_CanChangePrimitive,
// token 192,
ves_icall_System_Array_FastCopy_raw,
// token 193,
ves_icall_System_Array_GetLength_raw,
// token 194,
ves_icall_System_Array_GetLowerBound_raw,
// token 195,
ves_icall_System_Array_GetGenericValue_icall,
// token 196,
ves_icall_System_Array_GetValueImpl_raw,
// token 197,
ves_icall_System_Array_SetGenericValue_icall,
// token 200,
ves_icall_System_Array_SetValueImpl_raw,
// token 201,
ves_icall_System_Array_SetValueRelaxedImpl_raw,
// token 365,
ves_icall_System_Runtime_RuntimeImports_Memmove,
// token 366,
ves_icall_System_Buffer_BulkMoveWithWriteBarrier,
// token 368,
ves_icall_System_Runtime_RuntimeImports_ZeroMemory,
// token 396,
ves_icall_System_Delegate_AllocDelegateLike_internal_raw,
// token 397,
ves_icall_System_Delegate_CreateDelegate_internal_raw,
// token 398,
ves_icall_System_Delegate_GetVirtualMethod_internal_raw,
// token 418,
ves_icall_System_Enum_GetEnumValuesAndNames_raw,
// token 419,
ves_icall_System_Enum_ToObject_raw,
// token 420,
ves_icall_System_Enum_InternalGetCorElementType_raw,
// token 421,
ves_icall_System_Enum_get_underlying_type_raw,
// token 422,
ves_icall_System_Enum_InternalHasFlag_raw,
// token 501,
ves_icall_System_Environment_get_ProcessorCount,
// token 502,
ves_icall_System_Environment_get_TickCount,
// token 503,
ves_icall_System_Environment_get_TickCount64,
// token 506,
ves_icall_System_Environment_FailFast_raw,
// token 544,
ves_icall_System_GC_register_ephemeron_array_raw,
// token 545,
ves_icall_System_GC_get_ephemeron_tombstone_raw,
// token 547,
ves_icall_System_GC_SuppressFinalize_raw,
// token 549,
ves_icall_System_GC_ReRegisterForFinalize_raw,
// token 551,
ves_icall_System_GC_GetGCMemoryInfo,
// token 553,
ves_icall_System_GC_AllocPinnedArray_raw,
// token 558,
ves_icall_System_Object_MemberwiseClone_raw,
// token 566,
ves_icall_System_Math_Abs_double,
// token 567,
ves_icall_System_Math_Abs_single,
// token 568,
ves_icall_System_Math_Acos,
// token 569,
ves_icall_System_Math_Acosh,
// token 570,
ves_icall_System_Math_Asin,
// token 571,
ves_icall_System_Math_Asinh,
// token 572,
ves_icall_System_Math_Atan,
// token 573,
ves_icall_System_Math_Atan2,
// token 574,
ves_icall_System_Math_Atanh,
// token 575,
ves_icall_System_Math_Cbrt,
// token 576,
ves_icall_System_Math_Ceiling,
// token 577,
ves_icall_System_Math_Cos,
// token 578,
ves_icall_System_Math_Cosh,
// token 579,
ves_icall_System_Math_Exp,
// token 580,
ves_icall_System_Math_Floor,
// token 581,
ves_icall_System_Math_Log,
// token 582,
ves_icall_System_Math_Log10,
// token 583,
ves_icall_System_Math_Pow,
// token 584,
ves_icall_System_Math_Sin,
// token 585,
ves_icall_System_Math_Sinh,
// token 586,
ves_icall_System_Math_Sqrt,
// token 587,
ves_icall_System_Math_Tan,
// token 588,
ves_icall_System_Math_Tanh,
// token 589,
ves_icall_System_Math_FusedMultiplyAdd,
// token 590,
ves_icall_System_Math_ILogB,
// token 591,
ves_icall_System_Math_Log2,
// token 592,
ves_icall_System_Math_ModF,
// token 674,
ves_icall_System_MathF_Acos,
// token 675,
ves_icall_System_MathF_Acosh,
// token 676,
ves_icall_System_MathF_Asin,
// token 677,
ves_icall_System_MathF_Asinh,
// token 678,
ves_icall_System_MathF_Atan,
// token 679,
ves_icall_System_MathF_Atan2,
// token 680,
ves_icall_System_MathF_Atanh,
// token 681,
ves_icall_System_MathF_Cbrt,
// token 682,
ves_icall_System_MathF_Ceiling,
// token 683,
ves_icall_System_MathF_Cos,
// token 684,
ves_icall_System_MathF_Cosh,
// token 685,
ves_icall_System_MathF_Exp,
// token 686,
ves_icall_System_MathF_Floor,
// token 687,
ves_icall_System_MathF_Log,
// token 688,
ves_icall_System_MathF_Log10,
// token 689,
ves_icall_System_MathF_Pow,
// token 690,
ves_icall_System_MathF_Sin,
// token 691,
ves_icall_System_MathF_Sinh,
// token 692,
ves_icall_System_MathF_Sqrt,
// token 693,
ves_icall_System_MathF_Tan,
// token 694,
ves_icall_System_MathF_Tanh,
// token 695,
ves_icall_System_MathF_FusedMultiplyAdd,
// token 696,
ves_icall_System_MathF_ILogB,
// token 697,
ves_icall_System_MathF_Log2,
// token 698,
ves_icall_System_MathF_ModF,
// token 821,
ves_icall_RuntimeType_GetCorrespondingInflatedMethod_raw,
// token 822,
ves_icall_RuntimeType_GetCorrespondingInflatedMethod_raw,
// token 829,
ves_icall_RuntimeType_make_array_type_raw,
// token 832,
ves_icall_RuntimeType_make_byref_type_raw,
// token 834,
ves_icall_RuntimeType_MakePointerType_raw,
// token 839,
ves_icall_RuntimeType_MakeGenericType_raw,
// token 840,
ves_icall_RuntimeType_GetMethodsByName_native_raw,
// token 842,
ves_icall_RuntimeType_GetPropertiesByName_native_raw,
// token 843,
ves_icall_RuntimeType_GetConstructors_native_raw,
// token 847,
ves_icall_System_Activator_CreateInstanceInternal_raw,
// token 848,
ves_icall_RuntimeType_get_DeclaringMethod_raw,
// token 849,
ves_icall_System_RuntimeType_getFullName_raw,
// token 850,
ves_icall_RuntimeType_GetGenericArguments_raw,
// token 852,
ves_icall_RuntimeType_GetGenericParameterPosition_raw,
// token 853,
ves_icall_RuntimeType_GetEvents_native_raw,
// token 854,
ves_icall_RuntimeType_GetFields_native_raw,
// token 857,
ves_icall_RuntimeType_GetInterfaces_raw,
// token 858,
ves_icall_RuntimeType_GetNestedTypes_native_raw,
// token 861,
ves_icall_RuntimeType_get_DeclaringType_raw,
// token 862,
ves_icall_RuntimeType_get_Name_raw,
// token 863,
ves_icall_RuntimeType_get_Namespace_raw,
// token 932,
ves_icall_RuntimeTypeHandle_GetAttributes_raw,
// token 933,
ves_icall_reflection_get_token_raw,
// token 935,
ves_icall_RuntimeTypeHandle_GetGenericTypeDefinition_impl_raw,
// token 943,
ves_icall_RuntimeTypeHandle_GetCorElementType_raw,
// token 944,
ves_icall_RuntimeTypeHandle_HasInstantiation_raw,
// token 945,
ves_icall_RuntimeTypeHandle_IsComObject_raw,
// token 946,
ves_icall_RuntimeTypeHandle_IsInstanceOfType_raw,
// token 947,
ves_icall_RuntimeTypeHandle_HasReferences_raw,
// token 951,
ves_icall_RuntimeTypeHandle_GetArrayRank_raw,
// token 952,
ves_icall_RuntimeTypeHandle_GetAssembly_raw,
// token 953,
ves_icall_RuntimeTypeHandle_GetElementType_raw,
// token 954,
ves_icall_RuntimeTypeHandle_GetModule_raw,
// token 955,
ves_icall_RuntimeTypeHandle_IsGenericVariable_raw,
// token 956,
ves_icall_RuntimeTypeHandle_GetBaseType_raw,
// token 958,
ves_icall_RuntimeTypeHandle_type_is_assignable_from_raw,
// token 959,
ves_icall_RuntimeTypeHandle_IsGenericTypeDefinition_raw,
// token 960,
ves_icall_RuntimeTypeHandle_GetGenericParameterInfo_raw,
// token 962,
ves_icall_RuntimeTypeHandle_is_subclass_of,
// token 963,
ves_icall_RuntimeTypeHandle_IsByRefLike_raw,
// token 964,
ves_icall_System_RuntimeTypeHandle_internal_from_name_raw,
// token 968,
ves_icall_System_String_FastAllocateString_raw,
// token 969,
ves_icall_System_String_InternalIsInterned_raw,
// token 970,
ves_icall_System_String_InternalIntern_raw,
// token 1238,
ves_icall_System_Type_internal_from_handle_raw,
// token 1418,
ves_icall_System_ValueType_InternalGetHashCode_raw,
// token 1419,
ves_icall_System_ValueType_Equals_raw,
// token 7395,
ves_icall_System_Threading_Interlocked_CompareExchange_Int,
// token 7396,
ves_icall_System_Threading_Interlocked_CompareExchange_Object,
// token 7398,
ves_icall_System_Threading_Interlocked_Decrement_Int,
// token 7399,
ves_icall_System_Threading_Interlocked_Increment_Int,
// token 7400,
ves_icall_System_Threading_Interlocked_Increment_Long,
// token 7401,
ves_icall_System_Threading_Interlocked_Exchange_Int,
// token 7402,
ves_icall_System_Threading_Interlocked_Exchange_Object,
// token 7404,
ves_icall_System_Threading_Interlocked_CompareExchange_Long,
// token 7406,
ves_icall_System_Threading_Interlocked_Exchange_Long,
// token 7408,
ves_icall_System_Threading_Interlocked_Read_Long,
// token 7409,
ves_icall_System_Threading_Interlocked_Add_Int,
// token 7410,
ves_icall_System_Threading_Interlocked_Add_Long,
// token 7418,
ves_icall_System_Threading_Monitor_Monitor_Enter_raw,
// token 7420,
mono_monitor_exit_icall_raw,
// token 7424,
ves_icall_System_Threading_Monitor_Monitor_test_synchronised_raw,
// token 7425,
ves_icall_System_Threading_Monitor_Monitor_pulse_raw,
// token 7427,
ves_icall_System_Threading_Monitor_Monitor_pulse_all_raw,
// token 7429,
ves_icall_System_Threading_Monitor_Monitor_wait_raw,
// token 7431,
ves_icall_System_Threading_Monitor_Monitor_try_enter_with_atomic_var_raw,
// token 7443,
ves_icall_System_Threading_Thread_GetCurrentProcessorNumber_raw,
// token 7452,
ves_icall_System_Threading_Thread_InitInternal_raw,
// token 7453,
ves_icall_System_Threading_Thread_GetCurrentThread,
// token 7455,
ves_icall_System_Threading_InternalThread_Thread_free_internal_raw,
// token 7456,
ves_icall_System_Threading_Thread_GetState_raw,
// token 7457,
ves_icall_System_Threading_Thread_SetState_raw,
// token 7458,
ves_icall_System_Threading_Thread_ClrState_raw,
// token 7459,
ves_icall_System_Threading_Thread_SetName_icall_raw,
// token 7461,
ves_icall_System_Threading_Thread_YieldInternal,
// token 7463,
ves_icall_System_Threading_Thread_SetPriority_raw,
// token 8398,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_PrepareForAssemblyLoadContextRelease_raw,
// token 8402,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_GetLoadContextForAssembly_raw,
// token 8404,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalLoadFile_raw,
// token 8405,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalInitializeNativeALC_raw,
// token 8406,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalLoadFromStream_raw,
// token 8407,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalGetLoadedAssemblies_raw,
// token 8453,
ves_icall_System_GCHandle_InternalAlloc_raw,
// token 8454,
ves_icall_System_GCHandle_InternalFree_raw,
// token 8455,
ves_icall_System_GCHandle_InternalGet_raw,
// token 8472,
ves_icall_System_Runtime_InteropServices_Marshal_GetLastPInvokeError,
// token 8473,
ves_icall_System_Runtime_InteropServices_Marshal_SetLastPInvokeError,
// token 8474,
ves_icall_System_Runtime_InteropServices_Marshal_StructureToPtr_raw,
// token 8475,
ves_icall_System_Runtime_InteropServices_Marshal_IsPinnableType_raw,
// token 8507,
ves_icall_System_Runtime_InteropServices_NativeLibrary_LoadByName_raw,
// token 8552,
mono_object_hash_icall_raw,
// token 8555,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetObjectValue_raw,
// token 8563,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetUninitializedObjectInternal_raw,
// token 8564,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_InitializeArray_raw,
// token 8565,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_SufficientExecutionStack,
// token 8948,
ves_icall_System_Reflection_Assembly_GetEntryAssembly_raw,
// token 8952,
ves_icall_System_Reflection_Assembly_InternalLoad_raw,
// token 8953,
ves_icall_System_Reflection_Assembly_InternalGetType_raw,
// token 8985,
mono_digest_get_public_token,
// token 8986,
ves_icall_System_Reflection_AssemblyName_GetNativeName,
// token 8987,
ves_icall_System_Reflection_AssemblyName_ParseAssemblyName,
// token 9005,
ves_icall_MonoCustomAttrs_GetCustomAttributesInternal_raw,
// token 9011,
ves_icall_MonoCustomAttrs_GetCustomAttributesDataInternal_raw,
// token 9018,
ves_icall_MonoCustomAttrs_IsDefinedInternal_raw,
// token 9028,
ves_icall_System_Reflection_FieldInfo_internal_from_handle_type_raw,
// token 9032,
ves_icall_System_Reflection_FieldInfo_get_marshal_info_raw,
// token 9112,
ves_icall_System_Reflection_RuntimeAssembly_GetManifestResourceNames_raw,
// token 9113,
ves_icall_System_Reflection_RuntimeAssembly_GetExportedTypes_raw,
// token 9123,
ves_icall_System_Reflection_RuntimeAssembly_get_location_raw,
// token 9124,
ves_icall_System_Reflection_RuntimeAssembly_get_code_base_raw,
// token 9125,
ves_icall_System_Reflection_RuntimeAssembly_get_fullname_raw,
// token 9126,
ves_icall_System_Reflection_RuntimeAssembly_GetManifestResourceInternal_raw,
// token 9127,
ves_icall_System_Reflection_Assembly_GetManifestModuleInternal_raw,
// token 9128,
ves_icall_System_Reflection_RuntimeAssembly_GetModulesInternal_raw,
// token 9135,
ves_icall_System_Reflection_RuntimeCustomAttributeData_ResolveArgumentsInternal_raw,
// token 9148,
ves_icall_RuntimeEventInfo_get_event_info_raw,
// token 9168,
ves_icall_reflection_get_token_raw,
// token 9169,
ves_icall_System_Reflection_EventInfo_internal_from_handle_type_raw,
// token 9177,
ves_icall_RuntimeFieldInfo_ResolveType_raw,
// token 9179,
ves_icall_RuntimeFieldInfo_GetParentType_raw,
// token 9186,
ves_icall_RuntimeFieldInfo_GetFieldOffset_raw,
// token 9187,
ves_icall_RuntimeFieldInfo_GetValueInternal_raw,
// token 9190,
ves_icall_RuntimeFieldInfo_SetValueInternal_raw,
// token 9192,
ves_icall_RuntimeFieldInfo_GetRawConstantValue_raw,
// token 9197,
ves_icall_reflection_get_token_raw,
// token 9203,
ves_icall_get_method_info_raw,
// token 9204,
ves_icall_get_method_attributes,
// token 9211,
ves_icall_System_Reflection_MonoMethodInfo_get_parameter_info_raw,
// token 9213,
ves_icall_System_MonoMethodInfo_get_retval_marshal_raw,
// token 9223,
ves_icall_System_Reflection_RuntimeMethodInfo_GetMethodFromHandleInternalType_native_raw,
// token 9226,
ves_icall_RuntimeMethodInfo_get_name_raw,
// token 9227,
ves_icall_RuntimeMethodInfo_get_base_method_raw,
// token 9228,
ves_icall_reflection_get_token_raw,
// token 9238,
ves_icall_InternalInvoke_raw,
// token 9249,
ves_icall_RuntimeMethodInfo_GetPInvoke_raw,
// token 9255,
ves_icall_RuntimeMethodInfo_MakeGenericMethod_impl_raw,
// token 9256,
ves_icall_RuntimeMethodInfo_GetGenericArguments_raw,
// token 9257,
ves_icall_RuntimeMethodInfo_GetGenericMethodDefinition_raw,
// token 9259,
ves_icall_RuntimeMethodInfo_get_IsGenericMethodDefinition_raw,
// token 9260,
ves_icall_RuntimeMethodInfo_get_IsGenericMethod_raw,
// token 9270,
ves_icall_InternalInvoke_raw,
// token 9288,
ves_icall_reflection_get_token_raw,
// token 9303,
ves_icall_System_Reflection_RuntimeModule_InternalGetTypes_raw,
// token 9304,
ves_icall_System_Reflection_RuntimeModule_ResolveMethodToken_raw,
// token 9322,
ves_icall_RuntimeParameterInfo_GetTypeModifiers_raw,
// token 9327,
ves_icall_RuntimePropertyInfo_get_property_info_raw,
// token 9357,
ves_icall_reflection_get_token_raw,
// token 9358,
ves_icall_System_Reflection_RuntimePropertyInfo_internal_from_handle_type_raw,
// token 9788,
ves_icall_AssemblyBuilder_basic_init_raw,
// token 9929,
ves_icall_DynamicMethod_create_dynamic_method_raw,
// token 10175,
ves_icall_ModuleBuilder_basic_init_raw,
// token 10176,
ves_icall_ModuleBuilder_set_wrappers_type_raw,
// token 10184,
ves_icall_ModuleBuilder_getUSIndex_raw,
// token 10185,
ves_icall_ModuleBuilder_getToken_raw,
// token 10186,
ves_icall_ModuleBuilder_getMethodToken_raw,
// token 10192,
ves_icall_ModuleBuilder_RegisterToken_raw,
// token 10265,
ves_icall_TypeBuilder_create_runtime_class_raw,
// token 10425,
ves_icall_System_IO_Stream_HasOverriddenBeginEndRead_raw,
// token 10426,
ves_icall_System_IO_Stream_HasOverriddenBeginEndWrite_raw,
// token 11689,
ves_icall_Mono_RuntimeClassHandle_GetTypeFromClass,
// token 11708,
ves_icall_Mono_RuntimeGPtrArrayHandle_GPtrArrayFree,
// token 11715,
ves_icall_Mono_RuntimeMarshal_FreeAssemblyName,
// token 11716,
ves_icall_Mono_SafeStringMarshal_StringToUtf8,
// token 11718,
ves_icall_Mono_SafeStringMarshal_GFree,
};
static uint8_t corlib_icall_handles [] = {
0,
1,
1,
0,
1,
1,
1,
0,
1,
0,
1,
1,
0,
0,
0,
1,
1,
1,
1,
1,
1,
1,
1,
0,
0,
0,
1,
1,
1,
1,
1,
0,
1,
1,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
0,
1,
1,
1,
1,
1,
1,
1,
1,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
1,
1,
1,
1,
1,
1,
1,
1,
1,
0,
1,
1,
1,
1,
1,
0,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
0,
0,
1,
1,
1,
1,
1,
1,
1,
0,
1,
1,
1,
0,
0,
0,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
0,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
1,
0,
0,
0,
0,
0,
};
