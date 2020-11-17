using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesi cijenu bez PDV-a: ");
            double bezPDV = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Unesite istu cijenu sa PDV-om");

            double saPDV = bezPDV * 1.25; 

            Console.WriteLine("Cijena sa PDV-om je :"+saPDV);
            Console.ReadKey();
        }
    }
}
