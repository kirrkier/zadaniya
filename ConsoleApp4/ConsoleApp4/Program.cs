using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            do
            {
                Console.WriteLine(x);
            }
            while (x < 5);

            int n;

            do
            {
                Console.WriteLine("Введите число больше 0:");
                n = int.Parse(Console.ReadLine());
            }
            while (n <= 0); 
        }
    }
}
