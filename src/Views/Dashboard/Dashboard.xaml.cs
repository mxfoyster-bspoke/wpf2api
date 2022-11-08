using System.Windows;

namespace wpf2api.Views.Dashboard;

public partial class Dashboard : Window
{
    public Dashboard()
    {
        InitializeComponent();
    }

    private void JokeApiBtn_OnClick(object sender, RoutedEventArgs e)
    {
        var jokeApiWindow = new JokeApi();
        jokeApiWindow.Show();
    }
}