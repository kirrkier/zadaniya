using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie10._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Калькулятор среднего балла студента.");
            Console.WriteLine("Пожалуйста, введите количество экзаменов (k), которое сдал студент:");

            int k;
            int.TryParse(Console.ReadLine(), out k);

            if (k <= 0)
            {
                Console.WriteLine("Ошибка ввода: Введено некорректное количество экзаменов.");
                return;
            }

           
            double totalScore = 0; //общая сумма 
            int currentExamNumber = 1; //номер цикла и номер экза

            Console.WriteLine($"Теперь введите {k} оценок. Одна оценка для каждого экзамена.");

            while (currentExamNumber <= k)
            {
                Console.Write($"Введите оценку за экзамен {currentExamNumber} (от 0 до 100 баллов): ");

                int score; 
                int.TryParse(Console.ReadLine(), out score);


                if (score < 0 || score > 100)
                {
                    Console.WriteLine("Ошибка: Оценка должна быть в диапазоне от 0 до 100 баллов.");
                    continue; //неправильные переделываем
                }

                totalScore += score;
                currentExamNumber++;
            }

            
            double averageScore = totalScore / k; //кол-во баллов делю на экз

           
            Console.WriteLine($"Всего сдано экзаменов: {k}");
            Console.WriteLine($"Сумма всех баллов: {totalScore}");
            Console.WriteLine($"Средний балл студента: {averageScore}");

           
        }
    }
    }

