using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie8._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите абсциссу точки:");
            var x = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите ординату точки:");
            var y = double.Parse(Console.ReadLine());

            if (Podhodit(x, y))
                Console.WriteLine("Точка лежит в указаной области!");

            else 
                Console.WriteLine("Точка не лежит в указанной области...");
        }

        static bool Podhodit(double x, double y) =>
            x >= 1 && y <= -1 || x >= 2 && y >= 0;
    }
}
