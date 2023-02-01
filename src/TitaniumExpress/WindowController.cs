using System.Windows;
using System.Windows.Controls;

namespace TitaniumExpress.View;

public class WindowController
{
    public void MoveWindow(Window window)
    {
        window.DragMove();
    }

    public void CloseWindow()
    {
        Application.Current.Shutdown();
    }

    public void CheckSizeOnMaximize(Window window, Grid MainGrid)
    {
        if (window.WindowState == WindowState.Maximized)
        {
            MainGrid.Margin = new Thickness(5);
        }
        else
        {
            MainGrid.Margin = new Thickness(0);
        }
    }

    public void Maximize(Window window, Grid MainGrid)
    {
        if (window.WindowState == WindowState.Normal)
        {
            window.WindowState = WindowState.Maximized;
            MainGrid.Margin = new Thickness(5);
        }
        else
        {
            MainGrid.Margin = new Thickness(0);
            window.WindowState = WindowState.Normal;
        }
    }

    public void Minimize(Window window)
    {
        window.WindowState = WindowState.Minimized;
    }
}