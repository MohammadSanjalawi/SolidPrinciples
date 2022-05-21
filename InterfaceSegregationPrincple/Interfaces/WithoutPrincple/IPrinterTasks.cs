using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrincple.Interfaces.WithPrincple
{
    internal interface IPrinterTasks
    {
        void Print(string content);
        void Scan(string content);
    }
}
