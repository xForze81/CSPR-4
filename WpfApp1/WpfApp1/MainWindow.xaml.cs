using System.Windows;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        NavigateToAuthorizationPage(); // Начинаем с страницы авторизации
    }

    public void NavigateToAuthorizationPage()
    {
        MainFrame.NavigationService.Navigate(new AuthorizationPage());
    }

    public void NavigateToMainPage()
    {
        MainFrame.NavigationService.Navigate(new MainPage());
    }

    public void NavigateToEditTestPage()
    {
        MainFrame.NavigationService.Navigate(new EditTestPage());
    }

    public void NavigateToPassTestPage()
    {
        MainFrame.NavigationService.Navigate(new PassTestPage());
    }

    public void NavigateToNoTestPage()
    {
        MainFrame.NavigationService.Navigate(new NoTestPage());
    }
}
