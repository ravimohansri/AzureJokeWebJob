using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;

namespace ConsoleApp4WebJob.Model
{
    class DadJoke
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("joke")]
        public string Joke { get; set; }

        [JsonProperty("status")]
        public HttpStatusCode Status { get; set; }

        public DadJoke(string id, string content, HttpStatusCode status)
        {
            this.Id = id;
            this.Joke = content;
            this.Status = status;
        }
        
    }
}
