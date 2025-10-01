using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Дано трехзначное число. Найти число, полученное перестановкой второй и третьей  цифр");
            Console.WriteLine("Введите трехзначное число:");

            var n = int.Parse(Console.ReadLine());

            var sotny = n / 100;
            var desyatky = (n / 10) % 10;
            var edinitsy = n % 10;

            var result = sotny * 100 + edinitsy * 10 + desyatky;

            Console.WriteLine("Результат:" + result);


        }
    }
}
