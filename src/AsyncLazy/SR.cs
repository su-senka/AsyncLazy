namespace System
{
    /// <summary>
    /// Stand-in for the resource strings that dotnet/runtime generates from Strings.resx
    /// </summary>
    internal static class SR
    {
        internal const string AsyncLazy_FactoryReturnedNull = "The value factory returned a null task.";
        internal const string AsyncLazy_RecursiveAccess = "The value was requested from inside the attempt that produces it, directly or through a cycle of instances, so waiting would never finish. If the request comes from work the value factory started without awaiting, start that work with execution context flow suppressed (ExecutionContext.SuppressFlow).";
    }
}
