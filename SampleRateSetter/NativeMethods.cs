using System;
using System.Runtime.InteropServices;

namespace SampleRateSetter
{
    public static class NativeMethods
    {
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindow(IntPtr ZeroOnly, string lpWindowName);
    }
}
