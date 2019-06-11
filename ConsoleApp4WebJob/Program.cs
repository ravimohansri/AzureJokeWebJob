using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Net;
using ConsoleApp4WebJob.View;
using RestSharp;
using Newtonsoft.Json;

namespace ConsoleApp4WebJob
{
    class Program
    {
        static void Main(string[] args)
        {
            DadJokeView djv = new DadJokeView();
            Console.WriteLine(djv.GetRandomDadJokeView());

        }
    }
}
