using System;
using System.Xml.Serialization;

namespace Stock { 

    [XmlRoot("Materiales")]
    public class StockRequestBody
    {
        public StockRequestBody()
        {
        }

        public string Material { get; set; }
    }
}



