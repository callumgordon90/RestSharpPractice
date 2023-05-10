using System.Xml.Serialization;



namespace Stock
{
    //[XMLRoot("messagePayload")]
	public class MessagePayload
	{

		public MessagePayload()
		{
		}

        //getters and setters:
        [XmlElement("kumoCode")]
        public string KumoCode { get; set; }
		
        [XmlElement("originalId")]
        public string OriginalId { get; set; }

        [XmlElement("delegationId")]
        public string DelegationId { get; set; }

        [XmlElement("warehouseId")]
        public string WarehouseId { get; set; }

        [XmlElement("itemId")]
        public string ItemId { get; set; }

        [XmlElement("providerId")]
        public string ProviderId { get; set; }

        [XmlElement("stock")]
        public string Stock { get; set; }

        [XmlElement("measureType")]
        public string MeasureType { get; set; }
	}

}


