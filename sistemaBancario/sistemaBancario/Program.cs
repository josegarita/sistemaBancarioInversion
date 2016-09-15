using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Controler.CSVGeneration;


namespace sistemaBancario
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            /// <summary>
            /// Simple CSV export
            /// Example:
            CsvExport myExport = new CsvExport();
            ///
            myExport.AddRow();
            myExport["Nombre"] = "Jose";
            myExport["CuentaMonto"] = 100000;
            myExport["Date Opened"] = new DateTime(2003, 12, 31);
            ///
            myExport.AddRow();
            myExport["Nombre"] = "Mario";
            myExport["CuentaMonto"] = 50000;
            myExport["Date Opened"] = new DateTime(2005, 1, 1, 9, 30, 0);
            ///
            /// Then you can do any of the following three output options:
            string myCsv = myExport.Export();
            myExport.ExportToFile("archivoCSV.csv");
            byte[] myCsvData = myExport.ExportToBytes();
            /// </summary>
            /// 
            Console.WriteLine("Listo");
              /**/
            Console.ReadKey();
        }
    }

}
