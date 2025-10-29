using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie8._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите позицию белой ладьи:");
            var whitePos = Console.ReadLine();
            Console.WriteLine("Введите позицию черного ферзя:");
            var blackPos = Console.ReadLine();

            if (whitePos == blackPos)
            {
                Console.WriteLine("Позиции фигур не должны совпадать!");
                return;
            }
            if (!IsValidPosition(whitePos) || !IsValidPosition(blackPos))
            {
                Console.WriteLine("Некорректный ввод позиции. Используйте формат 'a1' - 'h8'.");
                return;
            }

            int whiteLadyaH, whiteLadyaV;
            int blackFerzH, blackFerzV;

            DecodePosition(whitePos, out whiteLadyaH, out whiteLadyaV);
            DecodePosition(blackPos, out blackFerzH, out blackFerzV);

            bool isFerzAttackingLadya = UnderStrikeByBlackFerz(whitePos, blackPos);

            bool isLadyaAttackingFerz = UnderStrikeByWhiteLadya(blackPos, whitePos);

            
            if (isFerzAttackingLadya && isLadyaAttackingFerz)
            {
                Console.WriteLine("Фигуры бьют друг друга");
            }
            else if (isFerzAttackingLadya)
            {
                Console.WriteLine("Белая ладья под боем черного ферзя");
            }
            else if (isLadyaAttackingFerz)
            {
                Console.WriteLine("Черный ферзь под боем белой ладьи");
            }
            else
            {
                Console.WriteLine("Фигуры не бьют друг друга");
            }
        }

        
        static void DecodePosition(string position, out int vert, out int hor)
        {
            vert = (int)position[0] - 0x60;
            hor = int.Parse(position[1].ToString());

        }

        static bool IsValidPosition(string position)
        {
            if (string.IsNullOrEmpty(position) || position.Length != 2)
                return false;

            char firstsymb = position[0];
            char secondsymb = position[1];

            if (firstsymb < 'a' || firstsymb > 'h')
                return false;

            if (!int.TryParse(secondsymb.ToString(), out int rank) || rank < 1 || rank > 8)
                return false;

            return true;
        }



        static bool UnderStrikeByBlackFerz(string position, string blackPos)
        {
            int lV, lH; // l - ладья
            int bfV, bfH; // bf - черный ферзь

            DecodePosition(position, out lV, out lH);
            DecodePosition(blackPos, out bfV, out bfH);

            if (lV == bfV) 
            return true;

            
            if (lH == bfH) 
            return true;

            
            if (Math.Abs(lV - bfV) == Math.Abs(lH - bfH)) return true;

            else return false;

        }
        static bool UnderStrikeByWhiteLadya(string position, string whitePos) 
        {
            int lV, lH; // l - ладья
            int bfV, bfH; // bf - черный ферзь

            DecodePosition(position, out bfV, out bfH);     
            DecodePosition(whitePos, out lV, out lH);  


       
            if (lV == bfV) 
            return true;

            
            if (lH == bfH) 
            return true;

            else return false;
        }
    }
}
    
