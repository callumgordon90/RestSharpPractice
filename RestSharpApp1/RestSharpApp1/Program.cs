using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Authenticators;
using Stock;
using System.Data.SqlTypes;
using System.Collections;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace RestSharpApp1
{
    //program class of the whole solution
    public class Program
    {

        //Main class where the code is executed
        public static void Main(string[] args)
        {
            Method1  M = new Method1();

            Console.WriteLine(());

            Console.ReadLine();

        }


        

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public class Method1
        {

            string url = "https://l700179-iflmap.hcisbp.eu2.hana.ondemand.com/http/Calidad/ConsultaStock";


            var options = new RestClientOptions(url)
            {
                Authenticator = new HttpBasicAuthenticator("P2002227617", "438add1cc9758ab33612b28f9be899A_")
            };


            var client = new RestClient(options);


            var request = new RestRequest();

            request.RequestFormat = DataFormat.Xml;

            StockRequestBody requestBody = new StockRequestBody()
            {
                Material = "9200010"
            };

            request.AddXmlBody(requestBody, ContentType.Xml);

            var response = client.Post(request);

            StockResponseBody responseBody = client.Serializers.DeserializeContent<StockResponseBody>(response);

            return responseBody;

           
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public string Method2(SqlString idArticulo) {
            requestBody = (string)idArticulo;

            return responseBody;

        };

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////



    }

}
