using NUnit.Framework;
using System;
using LibraryReaders;

namespace LibraryReaders.UnitTests
{
    [TestFixture]
    public class ReaderUnitTests
    {
            [Test]
            public void ConstructorTest()
            {
                var reader = CreateTestReader();

                Assert.That(reader.Name, Is.EqualTo("Иван"));

                Assert.That(reader.Surname, Is.EqualTo("Петров"));

                Assert.That(reader.ReaderCardNumber, Is.EqualTo("12345"));
            }

            [Test]
            public void ReturnDateTest()
            {
                var reader = CreateTestReader();

                DateTime expected = reader.IssueDate.AddDays(30);

                Assert.That(reader.ReturnDate, Is.EqualTo(expected));
            }

            [Test]
            public void GetInfoTest()
            {
                var reader = CreateTestReader();

                string[] info = reader.GetInfo();

                Assert.That(info.Length, Is.EqualTo(2));

                Assert.That(info[0], Is.EqualTo("Иван Петров"));

                Assert.That(info[1].Contains("12345"),Is.True);
            }

            private Reader CreateTestReader()
            {
                var reader =
                    new Reader(
                        "Иван",
                        "Петров",
                        "12345");

                reader.Books.Add("Война и мир");
                reader.Books.Add("Преступление и наказание");
                reader.Books.Add("Евгений Онегин");

            reader.IssueDate =
                    new DateTime(2025, 5, 1);

                reader.LoanPeriod =
                    TimeSpan.FromDays(30);

                reader.DepositAmount = 1000;

                return reader;
            }
        }
    }

