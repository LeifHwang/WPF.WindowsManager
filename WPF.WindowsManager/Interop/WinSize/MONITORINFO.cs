using System.Runtime.InteropServices;

namespace WPF.WindowsManager.Interop.WinSize
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    internal class MONITORINFO
    {
        /// <summary>
        /// </summary>            
        public int cbSize = Marshal.SizeOf(typeof(MONITORINFO));

        /// <summary>
        /// </summary>            
        public WindowRect rcMonitor;

        /// <summary>
        /// </summary>            
        public WindowRect rcWork;

        /// <summary>
        /// </summary>            
        public int dwFlags;
    }
}
