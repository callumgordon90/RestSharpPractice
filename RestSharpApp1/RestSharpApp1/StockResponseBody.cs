using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Stock
{
    [XmlRoot("StockMessages")]
    public class StockResponseBody
	{

		public StockResponseBody()
		{

		}

        [XmlElement("StockMessage")]
        public List<StockMessage> Messages { get; set; }
        
    }
}



