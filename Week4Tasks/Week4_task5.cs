using System;
using System.Linq;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        { 
            int i = 0;
            int x = 0;
            int[] numbers = new int [10];
            while(i<11)
            {
                if (i % 2 != 0)
                {
                    int m = i * i * i;
                    
                    numbers[x] = m;
                    x++;
                    i++;
                                     
                         }
                else
                {
                    i++;
                }
            }

                Console.WriteLine(numbers.Sum());
            


                
                
                
                



            
        
}
    }
}
