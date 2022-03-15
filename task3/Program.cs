using System;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Metini daxil edin");
            string Str = Console.ReadLine();
            Checker(Str);
        }
        static void Checker(string Str)
        {

            int First = Str.IndexOf(' ');
            int Last = Str.LastIndexOf(' ');
            int value = Last - First;
            Str = Str.Remove(First, value);
            string[] Array = Str.Split(' ');
            for (int i = 0; i < Array.Length; i++)
            {
                char[] Elements = Array[i].ToCharArray();
                char.ToUpper(Elements[0]);
            }

        }
    }
}

