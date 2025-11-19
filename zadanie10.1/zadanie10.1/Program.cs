using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie10._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число n");
            int n;
            long sum = 0;

            int.TryParse(Console.ReadLine(), out n);
            {
                if (n >= 1)
                {
                    for (int i = n; i <= 2 * n; i++) {
                        sum += (long)i * i;
                    }

                    Console.WriteLine($"Значение выражения равно: {sum}" );

                }
                else
                    Console.WriteLine("Введите корректное значение для n. n - натуральное число.");
            }
        }
    }
}
 