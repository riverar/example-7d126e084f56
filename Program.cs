using Microsoft.ApplicationModel.Resources;
using System.Runtime.InteropServices;

namespace example_7d126e084f56
{
    class Program
    {
        [DllImport("Microsoft.WindowsAppSDK.Bootstrap", EntryPoint = "MddBootstrapInitialize", ExactSpelling = true, PreserveSig = true)]
        public static extern uint MddBootstrapInitialize(
            uint majorMinorVersion,
            [MarshalAs(UnmanagedType.LPWStr)]
            string versionTag,
            ulong packageVersion);

        static void Main(string[] args)
        {
            if (MddBootstrapInitialize(1 << 16 | 0, "experimental1", 0) == 0)
            {
                var manager = new ResourceManager("UnpackagedWpfApp.pri");
            }
        }
    }
}
