using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp4WebJob.Model;
using RestSharp;
using Newtonsoft.Json;

namespace ConsoleApp4WebJob.Controller
{
    class DJController
    {
        //Call Dad Joke Http REST get Service
        public DadJoke GetRandomDadJoke()
        {
           
            //Call Dad Joke Service
            var client = new RestClient("https://icanhazdadjoke.com");
            var request = new RestRequest("/", Method.GET);

            //Get Response from GET Http Call
            IRestResponse response = client.Execute(request);

            //Deserialize Response
            DadJoke joke = JsonConvert.DeserializeObject<DadJoke>(response.Content);
            return joke;

            
        }
    }
}
