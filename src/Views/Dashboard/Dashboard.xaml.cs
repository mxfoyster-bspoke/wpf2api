using System.Windows;
using wpf2api.Views.JokeApiViews;

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

    private void JokeApiJsonBtn_OnClick(object sender, RoutedEventArgs e)
    {
        var jokeApiJsonWindow = new JokeApiJson();
        jokeApiJsonWindow.Show();
    }
}