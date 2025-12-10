using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie10._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа для определения порядкового номера минимальной цифры в натуральном числе.");
            Console.WriteLine("По условию, все цифры в числе должны быть различны.");

            int PervZnach;
            while (true)
            {
                Console.Write("Введите натуральное число: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out PervZnach) && PervZnach > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Введите корректное натуральное число.");
                }
            }

            
            int totalDigits = 0;
            int tempCountNum = PervZnach;

           
            while (tempCountNum > 0)
            {
                tempCountNum /= 10;
                totalDigits++;
            }
            
            int minDigit = 9; 
            int minDigitLeft = 0; 
            int currentRP = 1; 
            int numToProcess = PervZnach; 

            while (numToProcess > 0)
            {
               
                int currentDigit = numToProcess % 10; 

                int currentLeftPosition = totalDigits - currentRP + 1;

                if (currentDigit < minDigit)
                {
                    minDigit = currentDigit;
                    minDigitLeft = currentLeftPosition;
                }

                numToProcess /= 10;
                currentRP++;
            }


            Console.WriteLine($"Порядковый номер минимальной цифры в числе: {minDigitLeft}");

        }
    }
}
   