using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                int[] money = new int[7] { 200, 100, 50, 20, 10, 5, 1 };

                Console.WriteLine("Istediyiniz meblegi daxil edin: ");
                string want = Console.ReadLine();

                if (want == "" || want == " ")
                {
                    Console.WriteLine("Zehmet olmasa meblegi daxil edin: ");

                }
                else
                {
                    int user_request = int.Parse(want);
                    for (int i = 0; i < money.Length; i++)
                    {
                        if (user_request >= money[i])
                        {
                            int bankomat = user_request / money[i];
                            user_request -= bankomat * money[i];
                            Console.WriteLine(bankomat + " - " + money[i]);
                        }
                    }
                }
            }

        }
    }
}
