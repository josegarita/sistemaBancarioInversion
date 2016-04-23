using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace sistemaBancario
{
    class Program
    {
        static void Main(string[] args)
        {
            XElement escribir = new XElement("Foo",
                new XAttribute("Bar", "some and value"),
                new XElement("Nested", "data"));
            System.IO.File.WriteAllText(@"WriteLines.txt", (string)escribir);
            Console.WriteLine(escribir);
           Console.ReadKey();
        }
    }

}
