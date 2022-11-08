namespace wpf2api.Domain;

// https://sv443.net/jokeapi/v2/

public class Joke
{
    public string? joke { get; set; }
    
    public string? setup { get; set; }
    
    public string? type { get; set; }
    
    public string? delivery { get; set; }
    public string? JokeCategory { get; set; }
    public string? Error { get; set; }
}