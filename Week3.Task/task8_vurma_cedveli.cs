using System;

namespace _8_vurma_cedveli
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            while (x < 11)
            {

                int i = 0;
                while (i < 11)
                {
                    Console.Write(x + "*" + i + "=" + x * i+" ");
                    i++;
                }
                Console.WriteLine();
                x++;

            }

        }
    }
}
