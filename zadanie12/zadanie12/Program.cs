using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = 0, n = 0;

            while (true)
            {
                Console.WriteLine("Введите через пробел два натуральных числа m и n от 5 до 20");
                Console.WriteLine("(Enter - отказ от ввода)");
                var input = Console.ReadLine();

                if (input == string.Empty)
                    return;

                var parts = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries );

                if (parts.Length == 2 &&
                    int.TryParse(parts[0], out m) &&
                    int.TryParse(parts[1], out n) &&
                    5 <= m && m <= 20 &&
                    5 <= n && n <= 20)
                    break;

                Console.WriteLine("Ошибка ввода");
            }

            var matrix = new int[m, n];
            var rnd = new Random();

            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    matrix[i, j] = rnd.Next(0, 100);

            Console.WriteLine();
            PrintTable(matrix);
            Console.WriteLine();

            // а)
            if (AreColumnsDecreasing(matrix, out int BadRow, out int BadCol))
                Console.WriteLine("Столбцы массива упорядочены по убыванию");
            else
                Console.WriteLine($"Нарушение порядка: строка {BadRow}, столбцы {BadCol} и {BadCol + 1}");

            Console.WriteLine();

            // б)
            var avgs = GetRowAverages(matrix);
            for (int i = 0; i < avgs.Length; i++)
                Console.WriteLine($"Строка {i}: среднее арифметическое = {avgs[i]:F2}");
        }

        static void PrintTable(int[,] table)
        {
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                    Console.Write($"{table[i, j],4}");
                Console.WriteLine();
            }
        }

        static bool AreColumnsDecreasing(int[,] table, out int badRow, out int badCol)
        {
            for (int j = 0; j < table.GetLength(1); j++)
                for (int i = 0; i < table.GetLength(0) - 1; i++)
                    if (table[i, j] <= table[i + 1, j])
                    {
                        badRow = i;
                        badCol = j;
                        return false;
                    }

            badRow = -1;
            badCol = -1;
            return true;
        }

        static double[] GetRowAverages(int[,] table)
        {
            int rows = table.GetLength(0);
            int cols = table.GetLength(1);
            var result = new double[rows];

            for (int i = 0; i < rows; i++)
            {
                int sum = 0;

                for (int j = 0; j < cols; j++)
                    sum += table[i, j];

                result[i] = (double)sum / cols;
            }

            return result;
        }
    }
}