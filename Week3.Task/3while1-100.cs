using System;
using System.Linq;

namespace exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int[] group = new int[50];
            while (i <100)  
            {
                i++;
                if (i % 2 != 0)
                {
                    for (int x = 0; x < group.Length; )
                    {
                        group[x] = i;
                        x++;
                    }


                }
            }
            Console.WriteLine(group.Sum());

        }
    }
}
