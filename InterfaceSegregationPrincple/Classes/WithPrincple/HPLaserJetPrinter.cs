using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceSegregationPrincple.Interfaces.WithPrincple;

namespace InterfaceSegregationPrincple.Classes.WithPrincple
{
    public class HPLaserJetPrinter : IPrinterTasks, IFaxTasks, IPrintDuplexTasks
    {
        public void Fax(string content)
        {
            Console.WriteLine("Fax Done");
        }

        public void Print(string content)
        {
            Console.WriteLine("Print Done");
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
