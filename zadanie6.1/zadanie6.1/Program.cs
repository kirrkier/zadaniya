using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace zadanie6 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку на английском языке");

            var text = Console.ReadLine();

            Console.WriteLine("Результат перевода на язык Leet:");
            Console.WriteLine(Translate(text));
        }
        static string Translate(string s)
        {
            var result = s.ToUpper()
            .Replace("A", "4")
            .Replace("B", "8")
            .Replace("C", "(")
            .Replace("D", "|)")
            .Replace("E", "3")
            .Replace("F", "|=")
            .Replace("G", "6")
            .Replace("H", "|-|")
            .Replace("I", "!")
            .Replace("J", ")")
            .Replace("K", "|<")
            .Replace("L", "1")
            .Replace("M", "|\\//|")
            .Replace("N", "|\\|")
            .Replace("O", "0")
            .Replace("P", "|>")
            .Replace("Q", "9")
            .Replace("R", "|2")
            .Replace("S", "5")
            .Replace("T", "7")
            .Replace("U", "|_|")
            .Replace("V", "\\/")
            .Replace("W", "\\/\\/")
            .Replace("X", "><")
            .Replace("Y", "'/")
            .Replace("Z", "2");


            return result; 
    }
    }
}
