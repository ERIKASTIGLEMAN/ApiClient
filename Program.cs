using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace ApiClient
{
    public class Joke
    // working

    {
        public int id { get; set; }
        public string text { get; set; }
        public string setup { get; set; }
        public string punchline { get; set; }
    }
    class Program
    {
        static async Task Main(string[] args)
        {


            var client = new HttpClient();

            var responseAsStream = await client.GetStreamAsync("https://official-joke-api.appspot.com/random_ten");

            var jokes = await JsonSerializer.DeserializeAsync<List<Joke>>(responseAsStream);

            foreach (var joke in jokes)
            {

                Console.WriteLine($"{joke.text}?");
                Console.WriteLine();
                Console.WriteLine($"{joke.punchline}! HeHeHe");
            }
        }
    }
}
