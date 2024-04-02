using System.Windows.Controls;
using System.Windows;

public partial class AuthorizationPage : Page
{
    public AuthorizationPage()
    {
        InitializeComponent();
    }

    private void LoginButton_Click(object sender, RoutedEventArgs e)
    {
        string password = PasswordBox.Password;
        if (password == "your_password")
        {
            NavigateToMainPage();
        }
        else
        {
            MessageBox.Show("Неверное кодовое слово");
        }
    }

    private void EditTestButton_Click(object sender, RoutedEventArgs e)
    {
        NavigateToEditTestPage();
    }

    private void PassTestButton_Click(object sender, RoutedEventArgs e)
    {
        NavigateToPassTestPage();
    }
