using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {


            DateTime v = DateTime.Now;
            int year = v.Year;
            Console.WriteLine("Enter your birth year: ");
            int old = int.Parse(Console.ReadLine());
            Console.Write(year-old);

        }
    }
}
