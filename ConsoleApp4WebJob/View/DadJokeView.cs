using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp4WebJob.Controller;

namespace ConsoleApp4WebJob.View
{
    class DadJokeView
    {

        public string GetRandomDadJokeView()
        {
            //Change the View Here
            StringBuilder dadJokeView = new StringBuilder();
            dadJokeView.Append("************Hi Awesome********************");

            DJController djc = new DJController();
            dadJokeView.Append(djc.GetRandomDadJoke().Joke);

            dadJokeView.Append("************Bye Awesome********************");

            return dadJokeView.ToString();

        }
    }
}
