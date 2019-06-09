using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Net;
using ConsoleApp4WebJob.Model;
using RestSharp;
using Newtonsoft.Json;

namespace ConsoleApp4WebJob
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://icanhazdadjoke.com";
            var client = new RestClient(url);
            var request = new RestRequest("/", Method.GET);

            IRestResponse response = client.Execute(request);
            DadJoke dadJoke = JsonConvert.DeserializeObject<DadJoke>(response.Content);
            Console.WriteLine(dadJoke.Joke);

        }
    }
}
