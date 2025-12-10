using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie10._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double proizv = 1;
            int count = 0;       
            double currentNumber; 
            string input;

            Console.WriteLine("Калькулятор среднего геометрического.");

            while (true)
            {
                Console.Write($"Введите число (или 0 для завершения):");
                input = Console.ReadLine();

                double.TryParse(input, out currentNumber);

                if (currentNumber < 0)
                {
                    Console.WriteLine("Введено отрицательное число. Пожалуйста, введите неотрицательное число.");
                    continue;
                }

                if (currentNumber == 0)
                {
                    break;
                }

                proizv *= currentNumber;
                count++;
            }

            double geomznach;
            if (count == 0)
            {
                Console.WriteLine("Пустая последовательность.");
            }
            else
            {
                geomznach = Math.Pow(proizv, (double)1 / count); 
                Console.WriteLine($"Среднее геометрическое: {geomznach:F4}");
            }
        }
    }
}
    
