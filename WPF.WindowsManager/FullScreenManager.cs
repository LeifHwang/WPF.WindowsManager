using System;
using System.Windows;
using System.Windows.Interop;
using WPF.WindowsManager.Interop;
using WPF.WindowsManager.Interop.WinSize;

namespace WPF.WindowsManager
{
    public class FullScreenManager
    {
        private readonly int _minWidth;
        private readonly int _minHeight;

        /// <summary>
        /// 最大化时，是否遮挡任务栏
        /// 此属性建议仅主窗口可设置
        /// </summary>
        public static bool IsCoveringTaskBar { get; set; }

        public FullScreenManager(Window window)
        {
            if (window == null)
                return;

            _minWidth = (int)window.MinWidth;
            _minHeight = (int)window.MinHeight;

            Init(window);
        }

        private void Init(Window window)
        {
            var handle = new WindowInteropHelper(window).Handle;
            if (handle == IntPtr.Zero)
            {
                window.SourceInitialized += (s, e) => Init(window);
                return;
            }

            var source = HwndSource.FromHwnd(handle);
            if (source != null)
                source.AddHook(WindowProc);
        }

        private IntPtr WindowProc(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam, ref bool handled)
        {
            switch ((WindowsMessages)msg)
            {
                case WindowsMessages.WM_GETMINMAXINFO:
                    WmGetMinMaxInfo(hwnd, lParam);
                    handled = true;
                    break;
            }
            return IntPtr.Zero;
        }

        private void WmGetMinMaxInfo(IntPtr hwnd, IntPtr lParam)
        {
            var mmi = NativeMethods.PtrToStructure<MINMAXINFO>(lParam);

            var MONITOR_DEFAULTTONEAREST = 0x00000002;
            var monitor = NativeMethods.MonitorFromWindow(hwnd, MONITOR_DEFAULTTONEAREST);

            if (monitor != IntPtr.Zero)
            {
                var monitorInfo = new MONITORINFO();
                NativeMethods.GetMonitorInfo(monitor, monitorInfo);

                var rcWorkArea = monitorInfo.rcWork;
                var rcMonitorArea = monitorInfo.rcMonitor;

                mmi.ptMaxPosition.x = Math.Abs(rcWorkArea.Left - rcMonitorArea.Left);
                mmi.ptMaxPosition.y = Math.Abs(rcWorkArea.Top - rcMonitorArea.Top);

                mmi.ptMinTrackSize.x = _minWidth;
                mmi.ptMinTrackSize.y = _minHeight;

                if (!IsCoveringTaskBar)
                {
                    mmi.ptMaxSize.x = Math.Abs(rcWorkArea.Right - rcWorkArea.Left);
                    mmi.ptMaxSize.y = Math.Abs(rcWorkArea.Bottom - rcWorkArea.Top);
                }
                else
                {
                    mmi.ptMaxSize.x = Math.Abs(rcMonitorArea.Right - rcWorkArea.Left);
                    mmi.ptMaxSize.y = Math.Abs(rcMonitorArea.Bottom - rcWorkArea.Top);
                }
            }
            mmi.UpdateMessage(lParam);
        }
    }
}
