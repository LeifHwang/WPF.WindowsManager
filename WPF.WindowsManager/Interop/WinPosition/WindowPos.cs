using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace WPF.WindowsManager.Interop.WinPosition
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct WindowPos
    {
        public IntPtr hwnd;
        public IntPtr hwndInsertAfter;
        public int x;
        public int y;
        public int cx;
        public int cy;
        public SetWindowPosFlag flags;

        [Conditional("DEBUG")]
        public void PrintDebugInfo(Func<IntPtr, string> findWinTitle, bool changed = false)
        {
            var temp = new StringBuilder();
            temp.Append(string.Format("{0:T} WindowPosChang{1} ", DateTime.Now, changed ? "ed" : "ing"));
            temp.Append(string.Format("[({0}){1}]", hwnd, findWinTitle(hwnd)));
            temp.Append(",under:" + findWinTitle(hwndInsertAfter));
            temp.Append(",  flags:" + flags);

            Debug.WriteLine(temp);
        }
    }
}
