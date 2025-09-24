using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Александ Сергеевич Пушкин");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Эпиграмма <На Воронцова>");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Полу-милорд, полу-купец,");
            Console.WriteLine("Полу-мудрец, полу-невежда,");
            Console.WriteLine("Полу-подлец,но есть надежда,");
            Console.WriteLine("Что будет полным наконец.");

            Console.ResetColor();
        }
    }
}
