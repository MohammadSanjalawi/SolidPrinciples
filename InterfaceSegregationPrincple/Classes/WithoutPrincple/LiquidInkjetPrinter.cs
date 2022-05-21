using InterfaceSegregationPrincple.Interfaces;
using InterfaceSegregationPrincple.Interfaces.WithoutPrinciple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrincple.Classes.WithoutPrincple
{
    internal class LiquidInkjetPrinter : IPrinterTasks
    {
        public void Print(string PrintContent)
        {
            Console.WriteLine("Print Done");
        }
        public void Scan(string ScanContent)
        {
            Console.WriteLine("Scan content");
        }


        /*
         The bellow tows methods are not required by this class so this violating interfaces segregation princple
         
         */
        public void Fax(string FaxContent)
        {
            throw new NotImplementedException();
        }
        public void PrintDuplex(string PrintDuplexContent)
        {
            throw new NotImplementedException();
        }
    }
}

