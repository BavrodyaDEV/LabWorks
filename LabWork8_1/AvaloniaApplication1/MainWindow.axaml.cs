using System;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace AvaloniaApplication1;

public partial class MainWindow : Window
{
    const double g = 9.81;
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Calculate_OnClick(object? sender, RoutedEventArgs e)
    {
        Result.Text = Convert.ToString(Math.Round(Convert.ToDouble(Ro.Text) * Convert.ToDouble(depth.Text) * g, 2));
    }
    
}