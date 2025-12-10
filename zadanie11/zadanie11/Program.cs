using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie11
{
    internal class Program

    {
        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");

                if ((i + 1) % 10 == 0)
                    Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void TransformArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = 9 - arr[i];
            }
        }

        static int Count(int[] arr, int m)
        {
            int count = 0;

            foreach (int x in arr)
            {
                if (x == m)
                    count++;
            }

            return count;
        }

        static int[] BinaryArray(int[] arr)
        {
            int[] result = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                result[i] = (arr[i] % 2 == 0) ? 0 : 1;
            }

            return result;
        }

        static void Main()
        {
            string PiZnach = "31415926535897932384626433832795028841971693993751";

            Console.Write("Введите положительное целое число n: ");
            int n = int.Parse(Console.ReadLine());

            if (n > PiZnach.Length)
            {
                Console.WriteLine($"Ошибка: доступно только {PiZnach.Length} цифр Пи.");
                return;
            }

            // Создание массива
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = PiZnach[i] - '0';
            }

            Console.WriteLine("Массив из задания 1:");
            PrintArray(arr);

            TransformArray(arr);

            Console.WriteLine("Массив из задания 2:");
            PrintArray(arr);

            
            Console.Write("Введите число m от 0 до 9: ");
            int m = int.Parse(Console.ReadLine());

            int Vstrech = Count(arr, m);
            Console.WriteLine($"Число {m} встречается в массиве {Vstrech} раз.");

            int[] binaryArr = BinaryArray(arr);

            Console.WriteLine("Массив из задания 4:");
            PrintArray(binaryArr);
        }
    }
}
