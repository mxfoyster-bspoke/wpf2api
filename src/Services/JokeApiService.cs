using System.Net.Http;
using System.Threading.Tasks;

namespace wpf2api.Services;

public class JokeApiService
{
    public async Task<string> GetJoke()
    {
        var  client = new HttpClient();
        var joke = "";
        var response = await client.GetAsync("https://v2.jokeapi.dev/joke/Any?format=txt");
        if (response.IsSuccessStatusCode)
        {
            // joke = await response.Content.ReadAsAsync<string>();
            joke = await response.Content.ReadAsStringAsync();
        }
        return joke;
    }
}