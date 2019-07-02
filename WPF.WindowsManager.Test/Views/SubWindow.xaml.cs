using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using Microsoft.Win32;

namespace WPF.WindowsManager.Test.Views
{
    /// <summary>
    /// SubWindow.xaml 的交互逻辑
    /// </summary>
    [DebuggerDisplay("{Title}")]
    public partial class SubWindow
    {
        private static readonly List<SubWindow> CachedWindows = new List<SubWindow>();
        private static readonly Dictionary<string, int> Orders = new Dictionary<string, int>();
        private readonly string _key;

        public static SubWindow Create(string key)
        {
            if (string.IsNullOrWhiteSpace(key))
                throw new ArgumentNullException("key");

            if (CachedWindows.Any(w => w._key == key && !w.IsVisible))
            {
                return CachedWindows.Last(w => w._key == key && !w.IsVisible);
            }

            var win = new SubWindow(key) { Title = key + GetOrder(key) };
            return win;
        }
        public static SubWindow Create(WindowZOrder zOrder)
        {
            var win = Create(zOrder + " Window");
            win.Owner = Application.Current.MainWindow;
            WindowsZOrderManager.SetZOrder(win, zOrder);
            return win;
        }

        public static int GetOrder(string key)
        {
            if (string.IsNullOrWhiteSpace(key))
                throw new ArgumentNullException("key");

            return Orders.ContainsKey(key) ? Orders[key] : 0;
        }

        private SubWindow()
            : this(null)
        {
            CloseHide.IsEnabled = false;
        }
        private SubWindow(string key)
        {
            InitializeComponent();

            _key = key;
            if (!string.IsNullOrWhiteSpace(key))
            {
                if (Orders.ContainsKey(key))
                    Orders[key]++;
                else
                    Orders.Add(key, 1);
            }
        }

        private void SubWindow_OnClosing(object sender, CancelEventArgs e)
        {
            if (CloseHide.IsChecked == true)
            {
                e.Cancel = true;
                Visibility = Visibility.Hidden;
            }
        }

        private void SubWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            if (ResizeMode == ResizeMode.CanResize)
                ResizeCk.IsChecked = true;
            if (ShowInTaskbar)
                TaskbarCk.IsChecked = true;

            if (WindowsZOrderManager.GetZOrder(this) == WindowZOrder.Top)
                BtnHigher.Visibility = Visibility.Collapsed;
        }

        private void TitleBorder_OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
                BtnMax_OnClick(null, null);
            else
                DragMove();
        }

        private void BtnMin_OnClick(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void BtnMax_OnClick(object sender, RoutedEventArgs e)
        {
            if (!BtnWinMax.IsEnabled)
                return;

            if (WindowState == WindowState.Normal)
            {
                WindowState = WindowState.Maximized;
                BtnWinMax.IsChecked = true;
            }
            else if (WindowState == WindowState.Maximized)
            {
                WindowState = WindowState.Normal;
                BtnWinMax.IsChecked = false;
            }
        }

        private void BtnClose_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }


        private void ResizeCk_Checked(object sender, RoutedEventArgs e)
        {
            ResizeMode = ResizeMode.CanResize;
        }
        private void ResizeCk_OnUnchecked(object sender, RoutedEventArgs e)
        {
            ResizeMode = ResizeMode.CanMinimize;
        }

        private void TaskbarCk_Checked(object sender, RoutedEventArgs e)
        {
            ShowInTaskbar = true;
        }
        private void TaskbarCk_OnUnchecked(object sender, RoutedEventArgs e)
        {
            ShowInTaskbar = false;
        }

        private void Hide_Checked(object sender, RoutedEventArgs e)
        {
            if (!CachedWindows.Contains(this))
                CachedWindows.Add(this);
        }
        private void Hide_OnUnchecked(object sender, RoutedEventArgs e)
        {
            if (CachedWindows.Contains(this))
                CachedWindows.Remove(this);
        }

        private void BtnSub_OnClick(object sender, RoutedEventArgs e)
        {
            var win = new SubWindow { Owner = this };
            win.Show();
        }

        private void BtnHigher_OnClick(object sender, RoutedEventArgs e)
        {
            var zOrder = WindowsZOrderManager.GetZOrder(this) + 1;
            var win = Create(zOrder);
            win.Show();
        }

        private void BtnFile_OnClick(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.ShowDialog();
        }
    }
}
