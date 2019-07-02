using System;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Interop;
using WPF.WindowsManager.Interop.WinPosition;
using WPF.WindowsManager.Interop.WinSize;

namespace WPF.WindowsManager.Interop
{
    internal static class NativeMethods
    {
        internal static void SetPosition(IntPtr handle, IntPtr top, bool noZOrder = false)
        {
            var winFlags = SetWindowPosFlag.NoMove | SetWindowPosFlag.NoSize;
            if (noZOrder)
                winFlags |= SetWindowPosFlag.NoZOrder;
            SetWindowPos(handle, top, 0, 0, 0, 0, (uint)winFlags);
        }

        internal static WindowRect GetWindowRectangle(IntPtr handle)
        {
            WindowRect rect;
            GetWindowRect(handle, out rect);
            return rect;
        }
        public static WindowRect GetWindowRectangle(Window window)
        {
            var rect = new WindowRect();
            if (window == null)
                return rect;

            var interop = new WindowInteropHelper(window);
            return interop.Handle != IntPtr.Zero ? GetWindowRectangle(interop.Handle) : rect;
        }

        /// <summary>
        /// 指定内存转换为结构体信息
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="lParam"></param>
        /// <returns></returns>
        internal static T PtrToStructure<T>(IntPtr lParam)
            where T : struct
        {
            return (T)Marshal.PtrToStructure(lParam, typeof(T));
        }
        /// <summary>
        /// 更新结构体信息到内存
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="structure"></param>
        /// <param name="lParam"></param>
        internal static void UpdateMessage<T>(this T structure, IntPtr lParam)
            where T : struct
        {
            Marshal.StructureToPtr(structure, lParam, true);
        }

        #region WinAPI
        [DllImport("User32.dll")]
        internal static extern bool EnableWindow(IntPtr hwnd, bool enable);

        [DllImport("User32.dll")]
        internal static extern int SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int x, int y, int cx, int cy, uint flags);

        [DllImport("user32.dll")]
        internal static extern IntPtr GetActiveWindow();

        [DllImport("user32.dll")]
        private static extern bool GetWindowRect(IntPtr hWnd, out WindowRect lpRect);


        [DllImport("user32")]
        internal static extern bool GetMonitorInfo(IntPtr hMonitor, MONITORINFO lpmi);
        [DllImport("User32")]
        internal static extern IntPtr MonitorFromWindow(IntPtr handle, int flags);
        #endregion
    }
}