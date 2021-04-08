using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Application
{

    [STAThread]
    public static void Main()
    {
        var app = new MainWindow();
        Window root = new Window();
        root.Title = "Title";

        root.Content = "test content";
        root.Show();
        app.MainWindow = root;
        app.Run();
    }
}