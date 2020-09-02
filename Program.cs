using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


namespace ApiClient
{
    class Program
    {
        class Joke
        {
            [JsonPropertyName("id")]
            public int id { get; set; }
            [JsonPropertyName("type")]
            public string type { get; set; }
            [JsonPropertyName("setup")]
            public string setup { get; set; }
            [JsonPropertyName("punchline")]
            public string punchline { get; set; }


        }
        static async Task Main(string[] args)
        {
            var apijoke = new HttpClient();

            var responseAsStream = await apijoke.GetStreamAsync("https://official-joke-api.appspot.com/random_joke");
            var joke = await JsonSerializer.DeserializeAsync<Joke>(responseAsStream);

            Console.WriteLine(joke.setup);
            Console.WriteLine(joke.punchline);


            Console.WriteLine(responseAsStream);
        }
    }
}
/*  
-- 1. After choosing your API read the documentation.
-- 2. Create a new application for accessing the API. (For C# use sdg-console, for JS use app-app)
-- 3. For C# create a class to store information that comes back from your API.
{
  "id": last joke id + 1,
  "type": "programming",
  "setup": "What's the best thing about a Boolean?",
  "punchline": "Even if you're wrong, you're only off by a bit."
}
-- 4. Write code to query the API and show results.
-- 5. If your API has more than one endpoint (URL) support a few options, perhaps by creating a menu system in your application. */
