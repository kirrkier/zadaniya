using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie10._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите m: ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Введите n: ");
            int n = int.Parse(Console.ReadLine());

            int limit = m * n;

            Console.WriteLine($"Числа от 1 до {limit}, взаимно простые с {m} и {n}:");

            for (int k = 1; k <= limit; k++)
            {
                int a = k, b = m;
                while (b != 0)
                {
                    int t = b;
                    b = a % b;
                    a = t;
                }
                int k_m = a;

                a = k; b = n;
                while (b != 0)
                {
                    int t = b;
                    b = a % b;
                    a = t;
                }
                int k_n = a;

                if (k_m == 1 && k_n == 1)
                {
                    Console.WriteLine(k);
                }
            }
        }
    }
    }

