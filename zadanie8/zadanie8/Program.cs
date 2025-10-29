using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число n:");
            var n = int.Parse(Console.ReadLine());

            if (IfLogicalExspressionTrue(n))
            Console.WriteLine("Введенное число кратно 5 или кратно 7");

           else 
            Console.WriteLine("Либо число не кратно 5," + "либо число не кратно 7");
        }
        static bool IfLogicalExspressionTrue(int n) =>
            (n % 5 == 0) || (n % 7 == 0);
    }
}
