using System.Windows;
using System.Windows.Input;

namespace WPF.WindowsManager.Demo.Views
{
    /// <summary>
    /// CallWindow.xaml 的交互逻辑
    /// </summary>
    public partial class CoverWindow
    {
        public CoverWindow()
        {
            InitializeComponent();
        }

        private void UIElement_OnMouseLeftButtonDown_(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void CoverWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            if (Owner != null)
            {
                Owner.StateChanged += (s, e1) =>
                {
                    if (Owner.WindowState == WindowState.Minimized)
                        WindowState = WindowState.Minimized;
                };
                Owner.Closed += (s, e1) => Close();
            }
        }
    }
}
