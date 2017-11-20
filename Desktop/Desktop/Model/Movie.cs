using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace OnlineCinema.Models
{

    public class Movie
    {
        [XmlElement("Id")]
        public int Id { get; set; }
        [XmlElement("Name")]
        public string Name { get; set; }
        [XmlElement("StarOfShow")]
        public DateTime StarOfShow { get; set; }
        [XmlElement("SoldTickets")]
        public virtual List<Ticket> SoldTickets { get; set; }

        public Movie()
        {
            SoldTickets = new List<Ticket>();
        }
    }
}