using static System.Net.Mime.MediaTypeNames;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Windows;

public partial class EditTestPage : Page
{
    private ObservableCollection<Test> tests = new ObservableCollection<Test>();

    public EditTestPage()
    {
        InitializeComponent();
        DataGrid.ItemsSource = tests;
    }



    private void SaveButton_Click(object sender, RoutedEventArgs e)
    {

    }
}
