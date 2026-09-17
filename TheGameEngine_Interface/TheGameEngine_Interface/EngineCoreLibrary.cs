using System.Runtime.InteropServices;

namespace TheGameEngine_Interface;

public static class EngineCoreLibrary
{
    private const string DllName = "TheGameEngine_Core.dll";

    [DllImport(DllName)]
    public static extern void Hello();
}