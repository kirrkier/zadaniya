using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie4
{
    internal class Program
    {
        static void Main(string[] args)
        { Console.WriteLine("Введите действительное число");
             var x = double.Parse(Console.ReadLine());
             var y = F(x);

            Console.WriteLine("y = " + y);
        }
        static double F(double x) => 1 + Math.Sqrt((Math.Pow(x, 2) - 1) / ((Math.Pow(x, 2)) + 1));
    }
}
 