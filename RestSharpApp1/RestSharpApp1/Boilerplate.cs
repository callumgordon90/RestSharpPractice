using RestSharp.Authenticators;
using RestSharp;
using Stock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharpApp1
{
    internal class Boilerplate
    {

        //create a string variable to hold the url of the fake API:
        string url = "https://l700179-iflmap.hcisbp.eu2.hana.ondemand.com/http/Calidad/ConsultaStock";

        //make a rest client:
        //this client can take the url of the API as a parameter. This 'client' object is an instance of the 'RestClient' class)

        //Now we put the authorisation credentials inside the 'options' object
        var options = new RestClientOptions(url)
        {
            Authenticator = new HttpBasicAuthenticator("P2002227617", "438add1cc9758ab33612b28f9be899A_")
        };

        var client = new RestClient(options);


        //create our request (object). (It is an instance of the 'RestRequest' class):
        var request = new RestRequest();
        request.RequestFormat = DataFormat.Xml;

            //here we are going to add a parameter where id = 1
            //we add first the id then the value
            //request.AddParameter("id", "2"); 
            //request.AddXmlBody("<Materiales><Material>9200010</Material></Materiales>", ContentType.Xml);

            StockRequestBody requestBody = new StockRequestBody()
            {
                Material = "9200010"
            };
        request.AddXmlBody(requestBody, ContentType.Xml);

            //now we can get our response from our 'GET' request petition:
            //It is a client.get because it is a 'GET' request. And we pass in the 'request' as a parameter.
            //(Even though 'request' is an empty object at this point).

            //the petition 'Get' made from the object 'client', taking 'request' as a parameter, returns an object called 'response'
            var response = client.Post(request);

        StockResponseBody responseBody = client.Serializers.DeserializeContent<StockResponseBody>(response);

        //This Console.WriteLine method will return the response from the GET request.
        //NOTE: 'response' on its own will return: 'RestSharp.RestResponse'
        //Whereas 'response.Content' returns the JSON. The 'ToString' method will covert it to string form (?)



        //Boiler plate for the function called from Microsoft SQL Server Management Studio:


        Console.WriteLine(responseBody);
            // Console.WriteLine(responseBody.ToString());


            //This line enables us to read what is happening before it dissaspears
            Console.ReadLine();

    }
}
