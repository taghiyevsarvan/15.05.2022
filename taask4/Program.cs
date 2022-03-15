using System;

namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 23, 34, 45, 56, 67 };
            Console.WriteLine("Arrayin elementleri");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            IntResize(ref arr);

        }
        static void IntResize(ref int[] arr)
        {
            Console.WriteLine("Elave olunacaq reqemi daxil edin");
            string newElement;
            bool result;
            int value;
            do
            {
                newElement = Console.ReadLine();
                result = int.TryParse(newElement, out value);
                if (!result)
                    Console.WriteLine("Sadece reqem daxil edin...");
            } while (!result);
            value = Convert.ToInt32(newElement);
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = value;
            Console.WriteLine("Yeni Array: ");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
