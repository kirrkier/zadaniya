using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zavanie2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Вычисление площади кольца по заданным внешнему и внутреннему диаметрам");

            Console.WriteLine("Задайте значение внешнего диаметра");
            var a = double.Parse(Console.ReadLine());

            Console.WriteLine("Задайте значение внутреннего диаметра");
            var b = double.Parse(Console.ReadLine());

            
            var area = Math.Abs(a * a - b * b) * Math.PI;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Значение площади:"); Console.WriteLine(area);

            Console.ResetColor();
        }
    }
}
