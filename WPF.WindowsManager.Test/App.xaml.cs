using System;
using System.Threading.Tasks;
using System.Windows;

namespace WPF.WindowsManager.Test
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            TaskScheduler.UnobservedTaskException += (s, args) =>
            {
                MessageBox.Show(args.Exception.Message);
                args.SetObserved();
            };
            Current.DispatcherUnhandledException += (s, args) =>
            {
                MessageBox.Show(args.Exception.Message);
                args.Handled = true;
            };
            DispatcherUnhandledException += (s, args) =>
            {
                MessageBox.Show(args.Exception.Message);
                args.Handled = true;
            };
            AppDomain.CurrentDomain.UnhandledException += (s, args) =>
            {
                MessageBox.Show(args.ExceptionObject.ToString());
            };

            try
            {
                var win = new MainWindow();
                win.ShowDialog();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
