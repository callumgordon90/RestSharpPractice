using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;

namespace RestSharpPosts
{
    class Program
    {
        static void Main(string[] args)
        {

            //This is the endpoint, saved in an object called 'url'.
            string url = "https://jsonplaceholder.typicode.com/posts";

            //The client is the entity which launches the request to the external API. Here the object 'client' is an instance of the
            //class 'RestClient', and takes the destination endpoint (url) as a parameter to the method.
            var client = new RestClient(url);

            //The object 'request' is an instance of the 'RestRequest' class.
            var request = new RestRequest();

            //What we want to do here is send a post request instead of a get request:

            //Here we create the body object/body variable, which is a new instance of the 'post' class with attributes set:
            //var body = new post { body = "Hola Callum", title = "Estoy aprendiendo C#", userId = 2222};
            var body = new post();
            body.userId = 23;

            //now we add the body object to our request ..but/and we are going to turn it into JSON so that the external API can read it:
            request.AddJsonBody(body);

            //Here we create our response:
            var response = client.Post(request);
            
            //Now the response should be printed in the console along with its status code:
            Console.WriteLine(response.StatusCode + "\n" + response.Content.ToString());

            Console.ReadLine();

        }
    }
}
