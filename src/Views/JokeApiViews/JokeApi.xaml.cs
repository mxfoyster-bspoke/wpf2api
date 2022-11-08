using System.Windows;
using wpf2api.Services;

namespace wpf2api.Views.JokeApiViews;

public partial class JokeApi : Window
{
    public JokeApi()
    {
        InitializeComponent();
        Loaded += JokeApi_Loaded;
    }

    private async void JokeApi_Loaded( object sender, RoutedEventArgs e)
    {
        var jokeApiService = new JokeApiService();
        JokeTextBlock.Text = await jokeApiService.GetJoke();
    }
}