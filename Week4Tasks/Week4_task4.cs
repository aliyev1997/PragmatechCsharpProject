using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
               
                Console.WriteLine("Istediyiniz meblegi daxil edin: ");
                string want = Console.ReadLine();

                if (want == "" || want == " ")
                {
                    Console.WriteLine("Zehmet olmasa meblegi daxil edin: ");

                }
                else
                {
                    int user_request = int.Parse(want);
                    //method Balans(); can be used
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


//method
// public static void Balans(int user_request)
      // {
      //     int[] money = new int[7] { 200, 100, 50, 20, 10, 5, 1 };
      //     for (int i = 0; i < money.Length; i++)
      //     {
      //         if (user_request >= money[i])
      //         {
      //             int bankomat = user_request / money[i];
      //             user_request -= bankomat * money[i];
      //             Console.WriteLine(bankomat + " - " + money[i]);
      //         }
      //         
      //     }
      // }
