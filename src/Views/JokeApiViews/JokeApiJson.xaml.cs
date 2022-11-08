using System.Text.Json;
using System.Windows;
using wpf2api.Domain;
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
        var joke = DeserializeJson(await jokeApiService.GetJokeAsJson());
        if (joke.type == "twopart")
        {
            JokeTextBlock.Text = joke.setup + "\n \n" + joke.delivery;
        }
        else
        {
            JokeTextBlock.Text = joke.joke;    
        }
        
    }

    private Joke DeserializeJson(string json)
    {
        var thisJoke = JsonSerializer.Deserialize<Joke>(json);

        if (thisJoke != null)
        {
            return thisJoke;
        }
        else
        {
            var emptyJoke = new Joke()
            {
                Error = "true",
                joke = "Sorry, couldn't retrieve joke",
                JokeCategory = "none"
                
            };

            return emptyJoke;
        } 
    }
}