using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ApiClient
{
    class Joke
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

            var responseAsString = await client.GetStringAsync("https://official-joke-api.appspot.com/random_ten");

            Console.WriteLine(responseAsString);


        }
    }
}
