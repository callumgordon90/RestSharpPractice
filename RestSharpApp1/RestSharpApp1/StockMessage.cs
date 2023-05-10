using System;
using System.Xml.Serialization;



namespace Stock
{
    [XmlRoot("StockMessage")]
    public class StockMessage
{
	    public StockMessage()
	    { 

	    }

        //getters and setters:
        [XmlElement("messageNumber")]
        public string MessageNumber { get; set; }

        [XmlElement("messageLine")]
        public string MessageLine { get; set; }

        [XmlElement("messageType")]
        public string MessageType { get; set; }

        [XmlElement("messagePayload")]
        public MessagePayload MessagePayload { get; set; }

        [XmlElement("messageLangCode")]
        public string MessageLangCode { get; set; }

        [XmlElement("messageDate")]
        public string MessageDate { get; set; }

    }

}
