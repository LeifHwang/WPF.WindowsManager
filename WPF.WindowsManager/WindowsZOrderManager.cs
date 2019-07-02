//#define PRINT

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Interop;
using System.Windows.Media;
using WPF.WindowsManager.Interop;
using WPF.WindowsManager.Interop.WinPosition;

namespace WPF.WindowsManager
{
    /*
     * 当前管理器主要用于窗口层级管理，主要适用于窗口分层管理
     * 以APP的主窗口为主要的Owner，特别加入了Popup的支持，FileDialog和部分临时窗口的管理
     */

    /// <summary>
    /// 窗口层级管理器
    /// </summary>
    public static class WindowsZOrderManager
    {
        private static readonly ZOrderWinCollection TopWindows = new ZOrderWinCollection("TopWindows");
        private static readonly ZOrderWinCollection NormalWindows = new ZOrderWinCollection("NormalWindows", TopWindows);
        private static readonly ZOrderWinCollection LowWindows = new ZOrderWinCollection("LowWindows", NormalWindows);

        private static Window _owner, _tempMaskLayer;
        private static IntPtr _ownerHandle, _appRegionHandle, _appActiveHandle, _tempDiaologHandle;
        private static bool _owerEnabled = true, _otherDialogShowing;
        private static DateTime _lastLogPrint;  //上一次打印日志的时刻，为了打印分段方便阅读
        private static double _winIndex;  //方便打印日志时可以直观显示窗口层级加入的辅助变量

        #region ZOrder
        public static readonly DependencyProperty ZOrderProperty = DependencyProperty.RegisterAttached("ZOrder", typeof(WindowZOrder),
            typeof(WindowsZOrderManager), new PropertyMetadata(WindowZOrder.Normal));

        public static void SetZOrder(Window window, WindowZOrder value)
        {
            window.SetValue(ZOrderProperty, value);
        }

        [AttachedPropertyBrowsableForType(typeof(Window))]
        public static WindowZOrder GetZOrder(Window window)
        {
            return (WindowZOrder)window.GetValue(ZOrderProperty);
        }
        #endregion

        #region Ignore
        public static readonly DependencyProperty IgnoreProperty = DependencyProperty.RegisterAttached("Ignore", typeof(bool),
            typeof(WindowsZOrderManager), new PropertyMetadata(false));

        public static void SetIgnore(Window window, bool value)
        {
            window.SetValue(IgnoreProperty, value);
        }

        public static bool GetIgnore(Window window)
        {
            return (bool)window.GetValue(IgnoreProperty);
        }
        #endregion

        /// <summary>
        /// Popup控件加入层级管理
        /// </summary>
        /// <param name="popup"></param>
        public static void AddPopup(Popup popup)
        {
            if (popup == null)
                return;

            popup.Opened += (s, e) =>
            {
                if (popup.Child == null)
                    return;

                var visual = ((HwndSource)PresentationSource.FromVisual(popup.Child));
                if (visual == null)
                    return;

                var rect = NativeMethods.GetWindowRectangle(visual.Handle);
                var bottom = NormalWindows.Bottom;
                NativeMethods.SetWindowPos(visual.Handle, bottom, rect.Left, rect.Top, (int)popup.Width, (int)popup.Height, 0);

#if PRINT
                Debug.WriteLine("[Popup]" + visual.Handle + " under " + bottom);
#endif
            };
        }
        /// <summary>
        /// Window手动加入管理
        /// </summary>
        /// <param name="window"></param>
        public static void AddWindow(Window window)
        {
            if (window == null || Equals(window, _owner))
                return;

            //强制置顶的窗口不加入管理
            //模态窗口直接置顶，不加入管理
            if (window.Topmost || IsModalDialog(window))
                return;

            if (window.Owner != null && !Equals(window.Owner, _owner))
            {
                TopWindows.SetChildren(window.Owner, window);
                NormalWindows.SetChildren(window.Owner, window);
                LowWindows.SetChildren(window.Owner, window);
                return;
            }

            window.Owner = _owner;
            switch (GetZOrder(window))
            {
                case WindowZOrder.Low:
                    LowWindows.Add(window);
                    break;
                case WindowZOrder.Normal:
                    NormalWindows.Add(window);
                    break;
                case WindowZOrder.Top:
                    TopWindows.Add(window);
                    break;
            }
        }

        /// <summary>
        /// 通过层级控制显示窗口
        /// </summary>
        /// <param name="window"></param>
        /// <param name="zOrder"></param>
        public static void Show(this Window window, WindowZOrder zOrder = WindowZOrder.Normal)
        {
            if (window == null)
                return;

            SetZOrder(window, zOrder);
            window.Show();
        }
        /// <summary>
        /// 扩展的ShowDialog
        /// </summary>
        /// <param name="window"></param>
        /// <param name="cover">若遮罩，则只是弹窗，但是可以继续弹其他窗口；非遮罩则是标准ShowDialog</param>
        public static void ShowDialog(this Window window, bool cover = false)
        {
            if (window == null)
                return;

            if (!cover)
                window.ShowDialog();
            else
            {
                _tempMaskLayer = new MaskLayer(window);
                _tempMaskLayer.Show(WindowZOrder.Low);

                window.Show();
            }
        }

        /// <summary>
        /// 手动设置是否有其他非管理窗口展示时
        /// </summary>
        /// <param name="isShowing"></param>
        public static void SetOtherDialogShowing(bool isShowing)
        {
            if (_otherDialogShowing == isShowing)
                throw new ArgumentException("仅能用于单次使用！");

            _otherDialogShowing = isShowing;
        }

        /// <summary>
        /// 设置管理器的Owner
        /// </summary>
        /// <param name="window"></param>
        public static void SetManagerOwner(Window window)
        {
            if (window == null)
                throw new ArgumentNullException("window");
            if (_owner != null)
                throw new Exception("WinZOrderManager仅支持设置一次Owner！");

            _owner = window;
        }

        static WindowsZOrderManager()
        {
            //点击任务栏，强制唤起主窗口
            //Application.Current.Activated += (s, e) => _owner.Activate();

            EventManager.RegisterClassHandler(typeof(Window), FrameworkElement.LoadedEvent, new RoutedEventHandler((s, e) =>
            {
                var window = s as Window;
                if (window == null || GetIgnore(window))
                    return;

                if (Equals(window, _owner))
                {
                    _ownerHandle = new WindowInteropHelper(window).Handle;
                    var source = HwndSource.FromHwnd(_ownerHandle);
                    if (source != null)
                        source.AddHook(WindowProc);
                    return;
                }

                AddWindow(window);
            }));
        }

        private static IntPtr WindowProc(IntPtr hwnd, int msg, IntPtr wParam, IntPtr lParam, ref bool handled)
        {
            switch ((WindowsMessages)msg)
            {
                case WindowsMessages.WM_WINDOWPOSCHANGING:
                    var pos = NativeMethods.PtrToStructure<WindowPos>(lParam);
                    if (!_owerEnabled)
                        _tempDiaologHandle = NativeMethods.GetActiveWindow();

                    if (pos.hwnd == _ownerHandle)
                    {
                        if (pos.flags.HasFlag(SetWindowPosFlag.ShowWindow))
                            _appRegionHandle = pos.hwndInsertAfter;
                        else
                        {
                            if (pos.flags.HasFlag(SetWindowPosFlag.NoActivate) &&
                               pos.hwndInsertAfter != IntPtr.Zero &&
                               _appActiveHandle == IntPtr.Zero)
                                _appActiveHandle = pos.hwndInsertAfter;

                            if (LowWindows.Bottom != IntPtr.Zero)
                                pos.hwndInsertAfter = LowWindows.Bottom;
                        }
                    }
                    else
                    {
                        if (_otherDialogShowing)
                            pos.flags |= SetWindowPosFlag.NoZOrder;
                        else
                        {
                            LowWindows.PositonChaning(ref pos);
                            NormalWindows.PositonChaning(ref pos);
                            TopWindows.PositonChaning(ref pos);
                        }
                    }

                    handled = true;
                    pos.UpdateMessage(lParam);
                    PrintWindowPos(pos);
                    break;
                case WindowsMessages.WM_WINDOWPOSCHANGED:
                    //var posChaned = NativeMethods.PtrToStructure<WindowPos>(lParam);
                    //PrintWindowPos(posChaned, true);
                    break;
                case WindowsMessages.WM_ENTERIDLE:
                    //ShowDialog被调用
                    //if (_tempDiaologHandle == IntPtr.Zero)
                    //    _tempDiaologHandle = lParam;
                    //Debug.WriteLine("ShowDialog {0}", GetWinTitle(lParam));
                    break;
                case WindowsMessages.WM_ENABLE:
                    var enabled = wParam != IntPtr.Zero;
                    //Debug.WriteLine("{0} enabled set {1}.", GetWinTitle(hwnd), enabled);

                    TopWindows.SetAllEnable(enabled);
                    NormalWindows.SetAllEnable(enabled);
                    LowWindows.SetAllEnable(enabled);

                    if (hwnd != _ownerHandle && _owerEnabled != enabled)
                        NativeMethods.EnableWindow(_ownerHandle, enabled);
                    _owerEnabled = enabled;

                    //ShowDialog结束时
                    if (_owerEnabled)
                        _tempDiaologHandle = IntPtr.Zero;
                    break;
            }
            return IntPtr.Zero;
        }

        private static bool IsModalDialog(Window win)
        {
            var filed = typeof(Window).GetField("_showingAsDialog", BindingFlags.Instance | BindingFlags.NonPublic);
            return filed != null && (bool)filed.GetValue(win);
        }

        private static string GetWinTitle(IntPtr handle)
        {
            if (handle == _ownerHandle)
                return string.Format("({0}){1}", handle, GetWinTitle(_owner));

            var lowWin = LowWindows.GetWindow(handle, out _winIndex);
            if (lowWin != null)
                return string.Format("[Low_{2}]({0}){1}", handle, GetWinTitle(lowWin), _winIndex);

            var normalWin = NormalWindows.GetWindow(handle, out _winIndex);
            if (normalWin != null)
                return string.Format("[Normal_{2}]({0}){1}", handle, GetWinTitle(normalWin), _winIndex);

            var topWin = TopWindows.GetWindow(handle, out _winIndex);
            if (topWin != null)
                return string.Format("[Top_{2}]({0}){1}", handle, GetWinTitle(topWin), _winIndex);

            return handle.ToString();
        }

        private static string GetWinTitle(Window win)
        {
            return string.IsNullOrWhiteSpace(win.Title) ? win.ToString() : win.Title;
        }

        [Conditional("DEBUG")]
        private static void PrintWindowPos(WindowPos winPos, bool changed = false)
        {
            if (winPos.x > 0 || winPos.y > 0)
                return;

#if PRINT
            //调试时，在关键时机停顿5秒以上，可以分段打印，方便阅读
            if (_lastLogPrint != default && (DateTime.Now - _lastLogPrint).TotalSeconds >= 5)
                Debug.WriteLine("");

            winPos.PrintDebugInfo(GetWinTitle, changed);
            _lastLogPrint = DateTime.Now;
#endif
        }

        /// <summary>
        /// 用于管理同一层级窗口的对象
        /// </summary>
        [DebuggerDisplay("{_name},Windows Count = {_windows.Count}")]
        private class ZOrderWinCollection
        {
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private readonly string _name;
            [DebuggerBrowsable(DebuggerBrowsableState.Never)]
            private readonly ZOrderWinCollection _levelAfter;

            private readonly List<WindowInfo> _windows = new List<WindowInfo>();

            public IntPtr Bottom
            {
                get
                {
                    var last = _windows.LastOrDefault(w => w.Win.IsVisible);
                    if (last != null)
                        return last.Handle;

                    if (_levelAfter != null)
                        return _levelAfter.Bottom;
                    return IntPtr.Zero;
                }
            }

            /// <summary>
            /// 向当前组新增窗口对象
            /// </summary>
            /// <param name="win"></param>
            public void Add(Window win)
            {
                if (_windows.Any(w => Equals(w.Win, win)))
                    return;

                var item = new WindowInfo(win, this);
                _windows.Insert(0, item);

                WindowLoaded(item);
            }
            /// <summary>
            /// 查询指定窗口
            /// </summary>
            /// <param name="handle"></param>
            /// <param name="index"></param>
            /// <returns></returns>
            public Window GetWindow(IntPtr handle, out double index)
            {
                var item = GetWindowInfo(handle, out index);
                if (item != null)
                    return item.Win;
                return null;
            }
            /// <summary>
            /// 处理PositonChaning消息，重新排序
            /// </summary>
            /// <param name="pos"></param>
            public void PositonChaning(ref WindowPos pos)
            {
                if ((pos.flags.HasFlag(SetWindowPosFlag.NoActivate) || pos.flags.HasFlag(SetWindowPosFlag.ShowWindow)) &&
                    pos.hwndInsertAfter == _appRegionHandle)
                    return;

                var handle = pos.hwnd;
                var item = GetWindowInfo(handle, out _winIndex);
                if (item == null || !item.Win.IsVisible)
                    return;

                var top = _levelAfter == null ? IntPtr.Zero : _levelAfter.Bottom;
                if (!_owerEnabled && top == IntPtr.Zero)
                    top = _tempDiaologHandle;

                if (!pos.flags.HasFlag(SetWindowPosFlag.NoActivate) &&
                    top != IntPtr.Zero &&
                    pos.hwndInsertAfter == _appActiveHandle)
                    return;

                pos.hwndInsertAfter = top;
                item.PosChanging(ref pos);
            }
            /// <summary>
            /// 批量设置窗口是否可用
            /// </summary>
            /// <param name="enable"></param>
            public void SetAllEnable(bool enable)
            {
                foreach (var item in _windows)
                    item.SetEnabled(enable);
            }
            /// <summary>
            /// 判断是否子窗口，并加入管理
            /// </summary>
            /// <param name="owner"></param>
            /// <param name="child"></param>
            public void SetChildren(Window owner, Window child)
            {
                var index = _windows.FindIndex(w => Equals(w.Win, owner));
                if (index >= 0)
                {
                    if (!(_windows[index] is GroupWindowInfo))
                        _windows[index] = new GroupWindowInfo(owner, this);
                    var groupItem = (GroupWindowInfo)_windows[index];

                    var item = new ChildWindowInfo(groupItem, child, this);
                    groupItem.Children.Insert(0, item);

                    WindowLoaded(item);
                }
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="name"></param>
            /// <param name="after">当前集合的顶部集合</param>
            public ZOrderWinCollection(string name, ZOrderWinCollection after = null)
            {
                _name = name;
                _levelAfter = after;
            }

            private void WindowLoaded(WindowInfo item)
            {
                //确保打开时的位置正确
                var top = _levelAfter == null ? IntPtr.Zero : _levelAfter.Bottom;
                NativeMethods.SetPosition(item.Handle, top);

                var source = HwndSource.FromHwnd(item.Handle);
                if (source != null)
                    source.AddHook(WindowProc);

                item.Win.Closed += Win_Closed;
            }
            private void Win_Closed(object sender, EventArgs e)
            {
                var window = sender as Window;
                if (window == null)
                    return;

                if (_tempMaskLayer != null && Equals(((MaskLayer)_tempMaskLayer).UpperWindow, window))
                {
                    _tempMaskLayer.Close();
                    _tempMaskLayer = null;
                }

                var item = _windows.FirstOrDefault(w => Equals(w.Win, window));
                if (item != null)
                {
                    var source = HwndSource.FromHwnd(item.Handle);
                    if (source != null)
                        source.RemoveHook(WindowProc);

                    _windows.Remove(item);

                    if (_windows.Count == 0)
                        //强制刷新主界面位置，防止主界面非激活状态
                        NativeMethods.SetPosition(_ownerHandle, IntPtr.Zero);
                }
                window.Closed -= Win_Closed;
            }

            private WindowInfo GetWindowInfo(IntPtr handle, out double index)
            {
                var count = 0;
                foreach (var item in _windows)
                {
                    if (item.Handle == handle)
                    {
                        index = count;
                        return item;
                    }

                    var groupItem = item as GroupWindowInfo;
                    if (groupItem != null)
                    {
                        var subIndex = 0.1;
                        foreach (var child in groupItem.Children)
                        {
                            if (child.Handle == handle)
                            {
                                index = count + subIndex;
                                return child;
                            }
                            subIndex += 0.1;
                        }
                    }
                    count++;
                }
                index = -1;
                return null;
            }
            private bool HasUpperWin(WindowInfo win, out IntPtr handle)
            {
                handle = IntPtr.Zero;
                var index = _windows.IndexOf(win);
                if (index > 0)
                {
                    var lastVisible = _windows.Take(index).LastOrDefault(w => w.Win.IsVisible);
                    if (lastVisible != null)
                    {
                        handle = lastVisible.Handle;
                        return true;
                    }
                }
                return false;
            }

            /// <summary>
            /// 窗口对象
            /// </summary>
            [DebuggerDisplay("[{Handle}]{Win.Title}")]
            private class WindowInfo
            {
                protected readonly ZOrderWinCollection Owner;

                public Window Win { get; private set; }
                public IntPtr Handle { get; private set; }

                /// <summary>
                /// 设置窗口是否可用
                /// </summary>
                /// <param name="enabled"></param>
                public virtual void SetEnabled(bool enabled)
                {
                    NativeMethods.EnableWindow(Handle, enabled);
                }
                /// <summary>
                /// 处理WindowPos
                /// </summary>
                /// <param name="pos"></param>
                public virtual void PosChanging(ref WindowPos pos)
                {
                    if (!pos.flags.HasFlag(SetWindowPosFlag.NoActivate))
                    {
                        Owner._windows.Remove(this);
                        Owner._windows.Insert(0, this);
                    }
                    else
                    {
                        IntPtr handle;
                        if (Owner.HasUpperWin(this, out handle))
                            pos.hwndInsertAfter = handle;
                    }
                }

                public WindowInfo(Window win, ZOrderWinCollection owner)
                {
                    Win = win;
                    Handle = new WindowInteropHelper(win).Handle;

                    Owner = owner;
                }
            }
            [DebuggerDisplay("[{Handle}]{Win.Title}")]
            private class ChildWindowInfo : WindowInfo
            {
                public GroupWindowInfo Parent { get; private set; }

                public override void PosChanging(ref WindowPos pos)
                {
                    if (!Win.IsVisible)
                        return;

                    //父窗口置顶
                    if (!pos.flags.HasFlag(SetWindowPosFlag.NoActivate))
                    {
                        Owner._windows.Remove(Parent);
                        Owner._windows.Insert(0, Parent);
                    }

                    //查询同级的上层窗口
                    var index = Parent.Children.IndexOf(this);
                    if (index > 0)
                    {
                        var upperItem = Parent.Children.Take(index).LastOrDefault(w => w.Win.IsVisible);
                        if (upperItem != null)
                        {
                            pos.hwndInsertAfter = upperItem.Handle;
                            return;
                        }
                    }

                    //在当前子集中的最前，则放到父窗口的上层窗口之下
                    IntPtr handle;
                    if (Owner.HasUpperWin(Parent, out handle))
                        pos.hwndInsertAfter = handle;
                }

                public ChildWindowInfo(GroupWindowInfo parent, Window win, ZOrderWinCollection owner)
                    : base(win, owner)
                {
                    Parent = parent;
                }
            }
            /// <summary>
            /// 包含子窗口的窗口对象
            /// </summary>
            [DebuggerDisplay("[{Handle}]{Win.Title}, Children Count = {Children.Count}")]
            private class GroupWindowInfo : WindowInfo
            {
                public List<WindowInfo> Children { get; private set; }

                public override void SetEnabled(bool enabled)
                {
                    base.SetEnabled(enabled);

                    foreach (var child in Children)
                    {
                        child.SetEnabled(enabled);
                    }
                }
                public override void PosChanging(ref WindowPos pos)
                {
                    var lastChildItem = Children.LastOrDefault(p => p.Win.IsVisible);
                    if (lastChildItem != null)
                        pos.hwndInsertAfter = lastChildItem.Handle;
                    else
                    {
                        IntPtr handle;
                        if (Owner.HasUpperWin(this, out handle))
                            pos.hwndInsertAfter = handle;
                    }

                    //激活窗口置顶
                    if (!pos.flags.HasFlag(SetWindowPosFlag.NoActivate))
                    {
                        Owner._windows.Remove(this);
                        Owner._windows.Insert(0, this);
                    }
                }

                public GroupWindowInfo(Window win, ZOrderWinCollection owner)
                    : base(win, owner)
                {
                    Children = new List<WindowInfo>();
                }
            }
        }

        private class MaskLayer : Window
        {
            public Window UpperWindow { get; private set; }

            public MaskLayer(Window upperWindow)
            {
                UpperWindow = upperWindow;
                UpperWindow.Closing += (s, e) => Close();

                ShowInTaskbar = false;
                Background = Brushes.Transparent;
                WindowStyle = WindowStyle.None;
                AllowsTransparency = true;
                ResizeMode = ResizeMode.NoResize;
                SnapsToDevicePixels = true;
                Owner = _owner;

                Left = Owner.Left;
                Top = Owner.Top;
                Width = Owner.ActualWidth;
                Height = Owner.ActualHeight;

                if (Owner.WindowState == WindowState.Maximized)
                {
                    //考虑多屏情况
                    var rect = NativeMethods.GetWindowRectangle(Owner);

                    Left = rect.Left;
                    Top = rect.Top;
                    Width = rect.Right - rect.Left;
                    Height = rect.Bottom - rect.Top;
                }

                var backGround = new Border
                {
                    Background = new SolidColorBrush(Colors.Black),
                    Opacity = 0.01
                };
                Content = backGround;
            }
        }
    }

    /// <summary>
    /// 窗口的层级位置标识
    /// </summary>
    public enum WindowZOrder
    {
        Low,
        Normal,
        Top
    }
}
