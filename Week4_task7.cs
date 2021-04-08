using System;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter number");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("enter number");
            int y = int.Parse(Console.ReadLine());

            int[] array = new int[x];
            int i = 0;
            while (i < x)
            {
                array[i] = y;
                i++;
            }
           
                Console.WriteLine(array.Sum());
            


        }
    }
}
