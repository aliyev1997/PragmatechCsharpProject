using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            while (num > 0)
            {
                Console.WriteLine(num);
                num--;
            }

        }
    }
}
