using System;

namespace Training_Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = 7;
            int factorial = 1;
            while(true)
            {
                if (n <= 1)
                {
                    break;
                }
                factorial *= n;
                n--;
            }
            Console.WriteLine(factorial);
            
        }
    }
}
