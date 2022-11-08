using System.Windows;
using wpf2api.Services;

namespace wpf2api.Views.JokeApiViews;

public partial class JokeApiJson : Window
{
    public JokeApiJson()
    {
        InitializeComponent();
        Loaded += JokeApiJson_Loaded;
    }
    
    private async void JokeApiJson_Loaded( object sender, RoutedEventArgs e)
    {
        var jokeApiService = new JokeApiService();
        JokeTextBlock.Text = await jokeApiService.GetJokeAsJson();
    }
}