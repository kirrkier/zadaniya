using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace экзамен
{
    internal class Program
    {
        static int C(int n)
        {
            int count = 0;
            for (int m = 2; m < n; m++)
            {
                long cube = (long)m * m * m;
                if (cube % n == 1)
                {
                    count++;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            long sum = 0;
            for (int n = 1; n < 100000; n++)
            {
                int value = C(n);
                if (value == 8)
                    {
                    sum += n;
                    Console.WriteLine("Подходит n =" + n);
                }
            }
            Console.WriteLine("Сумма всех таких n(ответ) =" + sum);
        }

    }
}
