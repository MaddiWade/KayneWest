using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Linq;

namespace KayneWest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            var client = new HttpClient();
            var kayneapi = "https://api.kanye.rest";
           


            var ronapi = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
           

            for (int i = 0; i < 5 ; i++)
            {
                var kanyeResponse = client.GetStringAsync(kayneapi).Result;
                var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

                var ronResponse = client.GetStringAsync(ronapi).Result;
                var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

                Console.WriteLine(kanyeQuote);
                Console.WriteLine(ronQuote);
                Console.WriteLine();
                Console.WriteLine();
            }



        }
    }
}
