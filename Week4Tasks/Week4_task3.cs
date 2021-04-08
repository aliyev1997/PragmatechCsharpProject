using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 6, 9, 12, 15, 7, 3, 20, 14, 36, 24 };

            int i = 1;
            

            while (i < arr.Length+1)
            {
                Console.WriteLine(arr[arr.Length - i]);
                    i++;
            }


        }
    }
}
