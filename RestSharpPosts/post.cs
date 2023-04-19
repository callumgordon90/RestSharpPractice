using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharpPosts
{
    //We are going to add 3 different properties to the class 'post'
    //These are the 3 parts of the body that we are going to send with the POST request
    public class post
    {
        public int userId { get; set; }

        public string body { get; set; }

        public string title { get; set; }

        //Now we can create an object from this ('post') class, and put in the values that we want for these three attributes,
        //and convert it to JSON and send it with our request

    }
}
