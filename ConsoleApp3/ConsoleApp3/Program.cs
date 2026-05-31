using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 5)
            {
                Console.WriteLine("Написать значение i" + i);
                i++;
            }

            string password = "";
            while (password != "1234")
            {
                Console.WriteLine("Введите пароль:");
                password = Console.ReadLine();
            }
            Console.WriteLine("Доступ разрешен");
        }
    }
}
