using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie10._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите вес m: ");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Способы уравновесить вес {0} кг:", m);

            for (int a = 0; a <= m; a++)           
            {
                for (int b = 0; b <= m / 2; b++)     
                {
                    for (int c = 0; c <= m / 5; c++) 
                    {
                        if (a + 2 * b + 5 * c == m)
                        {
                            Console.WriteLine($"1кг={a}, 2кг={b}, 5кг={c}");
                        }
                    }
                }
            }
        }
    }
}
