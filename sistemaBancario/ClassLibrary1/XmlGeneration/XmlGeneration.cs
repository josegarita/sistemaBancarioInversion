using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Controler.XmlGeneration
{
    class XmlGeneration
    {
        public void escribir()
        {
            XElement escribir = new XElement("Foo",
               new XAttribute("Bar", "some and value"),
               new XElement("Nested", "data"));
            System.IO.File.WriteAllText(@"WriteLines.txt", escribir.ToString());
             Console.WriteLine(escribir);
        }
    }
}
