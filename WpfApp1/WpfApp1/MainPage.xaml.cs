using System.Windows.Controls;
using System.Windows.Navigation;
using System.Windows;

public partial class MainPage : Page
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void EditTestButton_Click(object sender, RoutedEventArgs e)
    {
        NavigationService.Navigate(new EditTestPage());
    }

    private void PassTestButton_Click(object sender, RoutedEventArgs e)
    {
        NavigationService.Navigate(new PassTestPage());
    }
}
