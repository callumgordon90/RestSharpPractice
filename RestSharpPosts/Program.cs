using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;

namespace RestSharpPosts
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //This is the endpoint, saved in an object called 'url'.
            string url = "https://jsonplaceholder.typicode.com/posts";

            //The client is the entity which launches the request to the external API. Here the object 'client' is an instance of the
            //class 'RestClient', and takes the destination enpoint (url) as a parameter to the method.
            var client = new RestClient (url);

            //The object 'request' is an instance of the 'RestRequest' class.
            var request = new RestRequest ();

            //What we want to do here is send a post request instead of a get request:

            //here we create the body object/body variable, which is a new instance of the 'post' class with attributes set:
            var body = new post { body = "This is the test body", title = "test post request", userId = 2};

            //now we add the body object to our request ..but/and we are going to turn it into JSON so that the external API can read it
            


            Console.WriteLine();

            Console.ReadLine();

        }
    }
}
