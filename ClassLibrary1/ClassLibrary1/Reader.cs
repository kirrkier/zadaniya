using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Reader
    {   
        public string Name { get; set; }

        public string Surname { get; set; }

        public readonly string ReaderCardNumber;

        public List<string> Books { get; set; }

        public DateTime IssueDate { get; set; }

        public TimeSpan LoanPeriod { get; set; }

        public double DepositAmount { get; set; }

        public DateTime ReturnDate =>
            IssueDate.Add(LoanPeriod);

        public Reader(
            string name,
            string surname,
            string readerNumber)
        {
            Name = name;
            Surname = surname;
            ReaderCardNumber = readerNumber;

            Books = new List<string>();

            IssueDate = DateTime.Now;

            LoanPeriod = TimeSpan.FromDays(14);

            DepositAmount = 0;
        }

        public virtual string[] GetInfo()
        {
            string[] info = new string[2];

            info[0] =
                $"{Name} {Surname}";

            info[1] =
                $"Билет № {ReaderCardNumber}. " +
                $"Книг: {Books.Count}. " +
                $"Дата выдачи: {IssueDate:d}. " +
                $"Срок выдачи: {LoanPeriod.Days} дней. " +
                $"Вернуть до: {ReturnDate:d}. " +
                $"Залог: {DepositAmount} руб.";

            return info;
        }
    }
}

