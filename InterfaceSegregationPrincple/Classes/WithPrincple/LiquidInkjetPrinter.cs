using InterfaceSegregationPrincple.Interfaces.WithPrincple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrincple.Classes.WithPrincple
{
    internal class LiquidInkjetPrinter : IPrinterTasks
    {
        public void Print(string content)
        {
            Console.WriteLine("Print Done");    
        }

        public void Scan(string content)
        {
            Console.WriteLine("Scan content");
        }
    }
}
