using System;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace OnlineCinema.Models
{
    public class Ticket
    {
        [XmlElement("Id")]
        public int Id { get; set; }
        [XmlElement("QuantitySold")]
        public int QuantitySold { get; set; }
        [XmlElement("SalesTime")]
        public DateTime SalesTime { get; set; }

        public Ticket()
        {

        }
    }
}