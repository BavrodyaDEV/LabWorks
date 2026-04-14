using Avalonia.Controls;
using Avalonia.Interactivity;
using System;
using System.Diagnostics;

namespace AvaloniaApplication1;

public partial class MainWindow : Window
{
    const double water = 1.0;
    const double g = 9.8;
    public MainWindow()
    {
        InitializeComponent();
    }

    void Button_click(object? sender, RoutedEventArgs e)
    {
        
        
        Result.Text = Convert.ToString(Math.Round((Convert.ToDouble(WOWater.Text) - Convert.ToDouble(WWater.Text)) / water / g, 2));
        
        
        
    }
}