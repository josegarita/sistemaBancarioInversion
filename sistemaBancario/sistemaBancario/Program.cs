using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Controller.CSVGeneration;
using GUI;

namespace sistemaBancario
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string bienvenida = "Bienvenido (a) al cálculo de intereses de productos de ahorro e inversión\n";
            string resultado = "---Datos del cliente y su operacipón bancaria---";
            string cliente = "Cliente: ";
            string sistemaAhorro = "Sistema de ahorro e inversión: ";
            string monto = "Monto de ahorro e inversión: ";
            string plazo = "Plazo de inversión en días: ";
            string moneda = "Moneda: ";
            string nameInput;

            Console.WriteLine(typeof(Model.Factory.AbstractProductServiceFactory).Namespace);

            Console.WriteLine(bienvenida);

            string line;
            Console.WriteLine("Enter one or more lines of text (press CTRL+Z to exit):");


            Console.Write(cliente);
                line = Console.ReadLine();
                Console.Write(sistemaAhorro);
                line = Console.ReadLine();
                Console.Write(monto);
                line = Console.ReadLine();
                Console.Write(plazo);
                line = Console.ReadLine();
                Console.Write(moneda);
                line = Console.ReadLine();

                Console.WriteLine();
                Console.WriteLine(resultado);

          /* */

            ventanaPrincipal vent = new ventanaPrincipal();
            
            vent.ShowDialog();

            
            //System.Net.Mime.MediaTypeNames.Application.run(new ventanaPrincipal);

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
