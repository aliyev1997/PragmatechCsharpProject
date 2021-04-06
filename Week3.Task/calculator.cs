using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose one of the these operations: +, -, *, /. Enter operation type to perform: ");
            string operation = Console.ReadLine();

            Console.WriteLine("Enter first number: ");
            int x = int.Parse( Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int y  = int.Parse( Console.ReadLine());





            switch (operation)
            {
                case ("+"):
                    Console.WriteLine("Result: "+(x+y));
                    break;
                case ("-"):
                    Console.WriteLine("Result: " + (x - y));
                    break;
                case ("*"):
                    Console.WriteLine("Result: " + (x *y));
                    break;
                case ("/"):
                    Console.WriteLine("Result: " + (x / y));
                    break;
                default:
                    Console.WriteLine("Please choose one of the options: +, -, *, /. ");

                    break;
            }
        }
    }
}
