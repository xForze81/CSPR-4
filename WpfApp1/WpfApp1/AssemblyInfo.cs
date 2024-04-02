public class Test
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string Option1 { get; set; }
    public string Option2 { get; set; }
    public string Option3 { get; set; }
    public CorrectOption CorrectAnswer { get; set; }
}

public enum CorrectOption
{
    Option1,
    Option2,
    Option3
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
