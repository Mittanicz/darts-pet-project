using Avalonia;
using Avalonia.Controls;

namespace Darts.Avalonia.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        this.AttachDevTools();
    }
}