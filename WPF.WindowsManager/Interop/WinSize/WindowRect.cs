using System.Runtime.InteropServices;

namespace WPF.WindowsManager.Interop.WinSize
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct WindowRect
    {
        public int Left;
        public int Top;
        public int Right;
        public int Bottom;
    }

    internal static class WindowRectExtension
    {
        public static int GetWidth(this WindowRect rect)
        {
            return rect.Right - rect.Left;
        }

        public static int GetHeight(this WindowRect rect)
        {
            return rect.Bottom - rect.Top;
        }
    }
}
