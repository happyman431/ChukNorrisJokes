using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace ChuckNorrisJokesLibrary
{
    public class JokeGenerator
    {
        public async System.Threading.Tasks.Task<string> GetRandomJokeAsync()
        {
            var client = new HttpClient();

            string randomJokeString = await client.GetStringAsync("https://api.chucknorris.io/jokes/random");

            var joke = JsonConvert.DeserializeObject<Joke>(randomJokeString);

                return joke.value;


        }
    }
}
