using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace RestSharpApp1
{
    //program class of the whole solution
    class Program
    {
        //Main class where the code is executed
        static void Main(string[] args)
        {
        //create a string variable to hold the url of the fake API:
            string url = 'https://jsonplaceholder.typicode.com/todos/1';

        //make a rest client:
        //this client can take the url of the API as a parameter. This 'client' object is an istance of the 'RestClient' class)
            var client = new RestClient(url);

            //create our request (object). (It is an instance of the 'RestRequest' class:
            var request = new RestRequest();


        }
    }
}
