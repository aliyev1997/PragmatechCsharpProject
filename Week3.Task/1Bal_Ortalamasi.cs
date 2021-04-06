using System;

namespace _1Bal_ortalamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first exam score: ");
            int result_1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second exam score: ");
            int result_2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your third exam score: ");
            int result_3 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Result: " + result_1);
            Console.WriteLine("Result: " + result_2);
            Console.WriteLine("Result: " + result_3);
            Console.WriteLine();

            int overall = (result_1 + result_2 + result_3) / 3;

            Console.WriteLine("Overall: " + overall);
            Console.WriteLine();


            int y = 45;
            var b = overall == y || overall>y ? "Netice 45-den beraber ve ya boyukdur.": "Netice 45den azdir.";
            Console.WriteLine(b);






        }
    }
}
