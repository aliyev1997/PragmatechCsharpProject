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
            
            
            //method Sum();

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

  //  Method
//    Sum(x,y);
       //
       //
       //
       //}
       //
       //public static void Sum(int x,int y)
       //{
       //    int[] array = new int[x];
       //    int i = 0;
       //    while (i < x)
       //    {
       //        array[i] = y;
       //        i++;
       //    }
       //
       //    Console.WriteLine(array.Sum());
