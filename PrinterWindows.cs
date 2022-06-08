using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism
{
    public  class PrinterWindows 
    {
        public int display { get; set; }

        public virtual void nomorPrinter ()
        {
            Console.WriteLine("Inputkan Nomor Printer: ");
        }
    }
}
