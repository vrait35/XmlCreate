using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace XmlHelpDescriptionStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xml = new XmlDocument();
            XmlNode rootElement = xml.CreateElement("Shag");
           
                var studentElement = xml.CreateElement("student");
                studentElement.SetAttribute("Name", "Anuar");
                studentElement.SetAttribute("age", "20");
                studentElement.SetAttribute("gender","male" );           
                rootElement.AppendChild(studentElement);
            var node = xml.CreateElement("raiting");
            node.InnerText = "12";
            studentElement.AppendChild(node);
            xml.AppendChild(rootElement);
            xml.Save("data.txt");
        }
    }
}
