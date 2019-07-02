using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;
using WPF.WindowsManager.Test.Views;

namespace WPF.WindowsManager.Test
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow
    {
        private Process _curProcess;
        private DockButton _dockButton;

        public MainWindow()
        {
            InitializeComponent();

            WindowsZOrderManager.SetManagerOwner(this);
            var full = new FullScreenManager(this);

            WindowsZOrderManager.AddPopup(TestPopup);
        }

        private async void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            _curProcess = Process.GetCurrentProcess();
            var counter = await Task.Run(() => new PerformanceCounter("Process", "Working Set - Private", _curProcess.ProcessName));
            MemoryStartInfo.Text = string.Format("启动时内存占用：{0}M\r\n", counter.NextValue() / 1024 / 1024);
            counter.Dispose();

            await Dispatcher.BeginInvoke(new Action(() =>
             {
                 var timer = new Timer(3000);
                 timer.Elapsed += (o, e1) => ShowMemorySize();
                 timer.Enabled = true;
             }));
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


        private void BtnLow_OnClick(object sender, RoutedEventArgs e)
        {
            var win = SubWindow.Create("Low Window");
            win.Show(WindowZOrder.Low);

            ShowMemorySize();
        }

        private void BtnNormal_OnClick(object sender, RoutedEventArgs e)
        {
            var win = SubWindow.Create("Normal Window");
            win.Show();

            ShowMemorySize();
        }

        private void BtnTop_OnClick(object sender, RoutedEventArgs e)
        {
            var win = SubWindow.Create("Top Window");
            win.Show(WindowZOrder.Top);

            ShowMemorySize();
        }

        private void BtnDialo_OnClick(object sender, RoutedEventArgs e)
        {
            var win = SubWindow.Create("Model Dialog");
            win.Title = "Model Dialog";
            win.Owner = this;
            win.ShowDialog();

            ShowMemorySize();
        }

        private void BtnCover_OnClick(object sender, RoutedEventArgs e)
        {
            var win = SubWindow.Create("Cover Dialog");
            win.Show(WindowZOrder.Top);

            var coverWin = new CoverWindow
            {
                Owner = win,
                Top = win.Top,
                Left = win.Left,
                Background = Brushes.Black,
                Title = "CoverWindow" + SubWindow.GetOrder("Cover Dialog")
            };
            WindowsDockManager.SetDockBehavior(coverWin, new DockBehavior
            {
                Dock = WinPosDockFlag.Full,
                RegionName = "CoverRegion",
                IsDockKeep = true
            });
            coverWin.SetDockOwner(win);
            coverWin.Show();
            coverWin.Hide();

            var coverWin1 = new CoverWindow
            {
                Owner = win,
                Top = win.Top,
                Left = win.Left,
                Background = Brushes.Gray,
                Title = "CoverWindow" + SubWindow.GetOrder("Cover Dialog") + "_1"
            };
            WindowsDockManager.SetDockBehavior(coverWin1, new DockBehavior
            {
                Dock = WinPosDockFlag.Full,
                RegionName = "CoverRegion",
                IsDockKeep = true
            });
            coverWin1.SetDockOwner(win);
            coverWin1.Show();

            ShowMemorySize();
        }

        private void BtnFileDialo_OnClick(object sender, RoutedEventArgs e)
        {
            var dialog = new SaveFileDialog();
            if (dialog.ShowDialog() != true)
            {
            }
        }

        private void DockBtn_OnChecked(object sender, RoutedEventArgs e)
        {
            if(_dockButton==null)
                _dockButton = new DockButton { Owner = this };
            _dockButton.Show();
        }
        private void DockBtn_OnUnChecked(object sender, RoutedEventArgs e)
        {
            if (_dockButton != null)
            {
                _dockButton.Close();
                _dockButton = null;
            }
        }

        private void ShowMemorySize()
        {
            Dispatcher.BeginInvoke(new Action(() =>
            {
                WinCounter.Text = string.Format("当前窗口总数：{0}", Application.Current.Windows.Count - 1);
                ThreadCounter.Text = string.Format("当前线程总数：{0}", _curProcess.Threads.Count);
                HandleCounter.Text = string.Format("当前句柄总数：{0}", _curProcess.HandleCount);

                using (var counter = new PerformanceCounter("Process", "Working Set - Private", _curProcess.ProcessName))
                {
                    MemoryInfo.Text = string.Format("当前内存占用：{0}M\r\n", counter.NextValue() / 1024 / 1024);
                }
            }), DispatcherPriority.Background);
        }
    }
}
