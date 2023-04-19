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
            string url = "https://jsonplaceholder.typicode.com/todos";

        //make a rest client:
        //this client can take the url of the API as a parameter. This 'client' object is an istance of the 'RestClient' class)
            var client = new RestClient(url);

            //create our request (object). (It is an instance of the 'RestRequest' class):
            var request = new RestRequest();

            //here we are going to add a parameter where id = 1
            //we add first the id then the value
            request.AddParameter("id", "2"); 

            //now we can get our response from our 'GET' request petition:
            //It is a client.get because it is a 'GET' request. And we pass in the 'request' as a parameter.
            //(Even though 'request' is an empty object at this point).
            var response = client.Get(request);

            //This Console.WriteLine method will return the response from the GET request.
            //NOTE: 'response' on its own will return: 'RestSharp.RestResponse'
            //Whereas 'response.Content' returns the JSON. The 'ToString' method will covert it to string form (?)
            Console.WriteLine(response.Content.ToString());

            //This line enables us to read what is happening before it dissaspears
            Console.ReadLine();

        }
    }
}
