using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                string Nachalnoeslovo = "клавиатура";

                string pervoeslovo = string.Concat(

                    Nachalnoeslovo.Substring(6, 1),
                    Nachalnoeslovo.Substring(4, 2),
                    Nachalnoeslovo.Substring(8, 2));

                string vtoroeslovo = string.Concat(

                    Nachalnoeslovo.Substring(8, 1),
                    Nachalnoeslovo.Substring(7, 1),
                    Nachalnoeslovo.Substring(0, 1),
                    Nachalnoeslovo.Substring(2, 1));


                Console.WriteLine(pervoeslovo);
                Console.WriteLine(vtoroeslovo);
            
        }
    }
}
