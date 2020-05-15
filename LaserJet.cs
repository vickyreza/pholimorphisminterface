using System;
using System.Collections.Generic;
using System.Text;

namespace printer2
{
    public class LaserJet : IPrinterkan
    {
        public void Show()
        {
            Console.WriteLine("LaserJet display dimension 12*12");

        }

        public void Print()
        {
            Console.WriteLine("Epson printer printing....");
        }
    }
}
