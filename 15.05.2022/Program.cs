using System;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sozu daxilde en az 1 boyuk 1 kicik herf ve en az 1 reqem olsun)");
            string sentence;
            do
            {
                sentence = Console.ReadLine();
                Console.WriteLine(Chec(sentence));
            } while (!Chec(sentence));
        }
        static bool Chec(string sentence)
        {
            int upLetter = 0;
            int lowLetter = 0;
            int digit = 0;
            for (int i = 0; i < sentence.Length; i++)
            {
                if (char.IsUpper(sentence[i]))
                {
                    upLetter++;
                }
                else if (char.IsLower(sentence[i]))
                {
                    lowLetter++;
                }
                else if (char.IsDigit(sentence[i]))
                {
                    digit++;
                }
            }
            if (upLetter >= 1 && lowLetter >= 1 && digit >= 1)
            {
                return true;
            }
            return false;
        }
    }
}