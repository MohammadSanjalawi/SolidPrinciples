using InterfaceSegregationPrincple.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrincple.Classes.WithoutPrincple
{
    internal class HPLaserJetPrinter : IPrinterTasks
    {
        public void Fax(string content)
        {
            Console.WriteLine("Fax Done");
        }

        public void Print(string content)
        {
            Console.WriteLine("print Done");
        }

        public void PrintDuplex(string content)
        {
            Console.WriteLine("printDuplex Done");
        }

        public void Scan(string content)
        {
            Console.WriteLine("Scan Done");
        }
    }
}
