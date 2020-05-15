using System;

namespace printer2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pilih Printer: ");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. LaserJet\n");

            Console.WriteLine("Pilih Nomer Printer [1..3]");
            int nomerPrinter = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");

            IPrinterkan printkan = null;

            if (nomerPrinter == 1)
            {
                printkan = new Epson();
            }
            else if (nomerPrinter == 2)
            {


                printkan = new Canon();

            }
            else if (nomerPrinter == 3)
            {
              printkan = new LaserJet();
            }
            else
            {
                Console.WriteLine("printer yang anda masukkan tidak ada");
            }

            printkan.Show();
            printkan.Print();

            Console.ReadKey();
        }
    }
}
