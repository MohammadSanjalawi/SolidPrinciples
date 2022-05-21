using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrincple.Interfaces
{
    public interface IPrinterTasks
    {
        void Print(string content);
        void Fax(string content);
        void Scan   (string content);
        void PrintDuplex(string content);
    }
}
