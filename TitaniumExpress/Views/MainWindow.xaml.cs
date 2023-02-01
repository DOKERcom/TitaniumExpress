using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using TitaniumExpress.Core.Interfaces.View;

namespace TitaniumExpress.View.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly WindowController _windowControl;
        public MainWindow()
        {
            InitializeComponent();

            _windowControl = new WindowController();
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            _windowControl.MoveWindow(this);
        }

        private void BtnClose_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            _windowControl.CloseWindow();
        }

        private void BtnHide_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            _windowControl.Minimize(this);
        }

        private void ScrollViewer_ScrollChanged(object sender, ScrollChangedEventArgs e)
        {
            if (!ScrollViewer.IsFocused)
                ScrollViewer.ScrollToVerticalOffset(e.ExtentHeight);
        }

        private void PasswordChanged(object sender, RoutedEventArgs e)
        {
          if(this.DataContext != null)
              ((IMainViewModel)this.DataContext).User.Password = ((PasswordBox)sender).Password;
        }


        private void Image_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            ((ToolTip)img_offemail.ToolTip).Content = "Email copied!";
            ((ToolTip)img_offemail.ToolTip).IsOpen = true;
        }

        private void img_offemail_MouseLeave(object sender, MouseEventArgs e)
        {
            ((ToolTip)img_offemail.ToolTip).Content = "gclipsa228@gmail.com";
            ((ToolTip)img_offemail.ToolTip).IsOpen = false;
        }
    }
}
