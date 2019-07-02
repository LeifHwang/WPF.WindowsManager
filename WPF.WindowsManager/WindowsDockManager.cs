using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using WPF.WindowsManager.Interop;

namespace WPF.WindowsManager
{
    /// <summary>
    /// 窗口停靠关系的管理器
    /// </summary>
    public static class WindowsDockManager
    {
        private static readonly Dictionary<Window, List<FrameworkElement>> DockRegions = new Dictionary<Window, List<FrameworkElement>>();

        #region DockRegionName
        public static readonly DependencyProperty DockRegionNameProperty = DependencyProperty.RegisterAttached("DockRegionName", typeof(string),
            typeof(WindowsDockManager), new FrameworkPropertyMetadata(default(string), (d, e) =>
            {
                var control = d as FrameworkElement;
                if (control == null)
                    return;

                var name = e.NewValue as string;
                if (string.IsNullOrWhiteSpace(name))
                    throw new ArgumentException("DockRegionName cannot null!");

                var win = Window.GetWindow(d);
                if (win != null)
                {
                    if (DockRegions.ContainsKey(win))
                    {
                        var list = DockRegions[win];
                        if (list.Any(c => GetDockRegionName(c) == name))
                            throw new ArgumentException(string.Format("DockRegionName '{0}' exist!", name));

                        list.Add(control);
                    }
                    else
                    {
                        DockRegions.Add(win, new List<FrameworkElement> { control });

                        win.LocationChanged += DockOwner_LocationChanged;
                        win.Closed += DockOwner_Closed;
                    }
                    control.SizeChanged += DockRegion_SizeChanged;
                }
            }));

        public static void SetDockRegionName(DependencyObject element, string value)
        {
            element.SetValue(DockRegionNameProperty, value);
        }

        public static string GetDockRegionName(DependencyObject element)
        {
            return (string)element.GetValue(DockRegionNameProperty);
        }
        #endregion

        #region DockBehavior
        public static readonly DependencyProperty DockBehaviorProperty = DependencyProperty.RegisterAttached("DockBehavior", typeof(DockBehavior),
            typeof(WindowsDockManager), new PropertyMetadata(default(DockBehavior), (d, e) =>
            {
                var win = d as Window;
                if (win == null)
                    return;

                var dockBehavior = e.NewValue as DockBehavior;
                if (dockBehavior != null && win.Owner != null && win.Owner.IsLoaded)
                {
                    var dockRegion = DockRegions[win.Owner].FirstOrDefault(c => GetDockRegionName(c) == dockBehavior.RegionName);
                    if (dockRegion != null)
                        WindowDockToRegion(win, dockRegion, true);
                }
            }));

        public static void SetDockBehavior(Window window, DockBehavior value)
        {
            window.SetValue(DockBehaviorProperty, value);
        }

        public static DockBehavior GetDockBehavior(Window window)
        {
            return (DockBehavior)window.GetValue(DockBehaviorProperty);
        }
        #endregion

        public static void SetDockOwner(this Window win, Window owner)
        {
            if (win == null || owner == null)
                return;

            win.Owner = owner;
        }

        static WindowsDockManager()
        {
            EventManager.RegisterClassHandler(typeof(Window), FrameworkElement.LoadedEvent, new RoutedEventHandler((s, e) =>
            {
                var window = s as Window;
                if (window == null || window.Owner == null || !DockRegions.ContainsKey(window.Owner))
                    return;

                var dockBehavior = GetDockBehavior(window);
                if (dockBehavior != null && window.Owner != null && window.Owner.IsLoaded)
                {
                    var dockRegion = DockRegions[window.Owner].FirstOrDefault(c => GetDockRegionName(c) == dockBehavior.RegionName);
                    if (dockRegion != null)
                        WindowDockToRegion(window, dockRegion, true);
                }
            }));
        }


        private static void DockOwner_LocationChanged(object sender, EventArgs e)
        {
            var window = sender as Window;
            if (window == null)
                return;

            if (!DockRegions.ContainsKey(window))
                return;

            foreach (var control in DockRegions[window])
            {
                DockRegion_SizeChanged(control, EventArgs.Empty);
            }
        }

        private static void DockOwner_Closed(object sender, EventArgs e)
        {
            var window = sender as Window;
            if (window == null || !DockRegions.ContainsKey(window))
                return;

            foreach (var element in DockRegions[window])
                element.SizeChanged -= DockRegion_SizeChanged;

            window.LocationChanged -= DockOwner_LocationChanged;
            window.Closed -= DockOwner_Closed;

            DockRegions.Remove(window);
        }

        private static void DockRegion_SizeChanged(object sender, EventArgs e)
        {
            var control = sender as FrameworkElement;
            if (control == null)
                return;

            var regionName = GetDockRegionName(control);
            if (string.IsNullOrWhiteSpace(regionName)) 
                return;

            var window = Window.GetWindow(control);
            if (window == null) 
                return;

            foreach (Window win in window.OwnedWindows)
            {
                var dock = GetDockBehavior(win);
                if (dock != null && dock.RegionName == regionName)
                {
                    if (dock.IsDockKeep)
                        WindowDockToRegion(win, control);
                    else
                    {
                        var dockSize = dock as DockAndSizeBehavior;
                        if (dockSize != null && dockSize.IsSizeFollowKeep)
                            WindowDockToRegion(win, control);
                    }
                }
            }
        }


        /// <summary>
        /// 设置停靠地图区域的窗口位置
        /// </summary>
        /// <param name="window"></param>
        /// <param name="dockRegion"></param>
        /// <param name="loaded"></param>
        private static void WindowDockToRegion(Window window, FrameworkElement dockRegion, bool loaded = false)
        {
            if (window == null || window.Owner == null || dockRegion == null)
                return;

            var dockBehavior = GetDockBehavior(window);
            if (dockBehavior == null)
                return;

            var owner = window.Owner;
            var ownerTop = owner.Top;
            var ownerLeft = owner.Left;

            //考虑多屏情况
            if (owner.WindowState == WindowState.Maximized)
            {
                var rect = NativeMethods.GetWindowRectangle(owner);

                ownerTop = rect.Top;
                ownerLeft = rect.Left;
            }

            var dockSize = dockBehavior as DockAndSizeBehavior;
            if (dockSize != null && (loaded || dockSize.IsSizeFollowKeep))
            {
                if (dockSize.SizeFollow.HasFlag(WinSizeFollowFlag.Width))
                    window.Width = dockRegion.ActualWidth;
                if (dockSize.SizeFollow.HasFlag(WinSizeFollowFlag.Height))
                    window.Height = dockRegion.ActualHeight;
            }

            if (!loaded && !dockBehavior.IsDockKeep)
                return;

            var regionLeftTop = dockRegion.TranslatePoint(new Point(0, 0), owner);
            var top = ownerTop + regionLeftTop.Y + dockBehavior.Offset.Y;
            var left = ownerLeft + regionLeftTop.X + dockBehavior.Offset.X;
            switch (dockBehavior.Dock)
            {
                case WinPosDockFlag.Full:
                    window.Height = dockRegion.ActualHeight;
                    window.Width = dockRegion.ActualWidth;
                    break;
                case WinPosDockFlag.Left:
                    window.Height = dockRegion.ActualHeight;
                    break;
                case WinPosDockFlag.Right:
                    left += dockRegion.ActualWidth - window.ActualWidth;
                    window.Height = dockRegion.ActualHeight;
                    break;
                case WinPosDockFlag.Left | WinPosDockFlag.Top:
                    break;
                case WinPosDockFlag.Right | WinPosDockFlag.Top:
                    left += dockRegion.ActualWidth - window.ActualWidth;
                    break;
                case WinPosDockFlag.Right | WinPosDockFlag.Bottom:
                    top += dockRegion.ActualHeight - window.ActualHeight;
                    left += dockRegion.ActualWidth - window.ActualWidth;
                    break;
                case WinPosDockFlag.Left | WinPosDockFlag.Bottom:
                    top += dockRegion.ActualHeight - window.ActualHeight;
                    break;
            }
            window.Top = top;
            window.Left = left;
        }
    }

    /// <summary>
    /// 窗口的停靠信息
    /// </summary>
    public class DockBehavior
    {
        private string _regionName;
        /// <summary>
        /// 要停靠区域的名称
        /// </summary>
        public string RegionName
        {
            get { return _regionName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("value", @"RegionName cannot null!");
                _regionName = value;
            }
        }

        /// <summary>
        /// 相对位置
        /// </summary>
        public WinPosDockFlag Dock { get; set; }
        /// <summary>
        /// 偏差值
        /// Dock设置为Full或者Custom时，当前值失效
        /// </summary>
        public Point Offset { get; set; }
        /// <summary>
        /// 停靠是否一直跟随
        /// </summary>
        public bool IsDockKeep { get; set; }
    }
    /// <summary>
    /// 包含窗口停靠消息和大小跟随消息
    /// </summary>
    public class DockAndSizeBehavior : DockBehavior
    {
        /// <summary>
        /// 大小跟随标识
        /// </summary>
        public WinSizeFollowFlag SizeFollow { get; set; }
        /// <summary>
        /// 大小是否一直跟随
        /// </summary>
        public bool IsSizeFollowKeep { get; set; }
    }

    /// <summary>
    /// 窗口停靠位置的标识
    /// </summary>
    [Flags]
    public enum WinPosDockFlag
    {
        Custom = 0x0,
        Left = 0x1,
        Right = 0x2,
        Top = 0x4,
        Bottom = 0x8,
        Full = 0x10
    }
    /// <summary>
    /// 窗口大小跟随的标识
    /// </summary>
    [Flags]
    public enum WinSizeFollowFlag
    {
        Custom = 0x0,
        Width = 0x1,
        Height = 0x2
    }
}
