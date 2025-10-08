using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var f = Calculate(2, 3) + Calculate(3, 5) + Calculate(5, 7);
            Console.WriteLine(f);
        } 
        static double Calculate(double x, double y) =>
            Math.Pow(Math.E, (- Math.Sqrt(x + Math.Pow(y, 2))));
    }
}
