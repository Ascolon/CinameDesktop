using OnlineCinema.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace OnlineCinema
{
    static public class Helper
    {
        static public List<Movie> List()
        {
            var request = (HttpWebRequest)WebRequest.Create("http://cinema.somee.com/api/values");
            request.ContentType = "application/xml";
            var root = new XmlRootAttribute("ArrayOfMovie")
            {
                Namespace = "http://schemas.datacontract.org/2004/07/BackendPart.Models"
            };
            XmlSerializer serializer = new XmlSerializer(typeof(List<Movie>), root);
            var result = new List<Movie>();
            XmlDocument c = new XmlDocument();
            using (Stream stream = request.GetResponse().GetResponseStream())
            {
                result = (List<Movie>)serializer.Deserialize(stream);
            }
            return result;
        }


        static public Task<List<Movie>> GetListAsync()
        {
            return Task.Run(() => List());
        }


        static public Task Order(int id, int count)
        {
            return Task.Run(() =>
            {
                var request = (HttpWebRequest)WebRequest.Create($"http://cinema.somee.com/Home/AddTicket/?id={id}&count={count}");
                var t = request.GetResponse();
            });              
        }
    }
}
