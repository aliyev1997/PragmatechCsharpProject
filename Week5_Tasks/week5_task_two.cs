using System;

namespace Bankomat
{
    
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Pin daxil edin: ");
            string pin = Console.ReadLine();

            int a;
            bool pass = int.TryParse(pin, out a);
            if (pass == true)
            {
                if (a == 1234)
                {
                    Bank.Menu();
                    int emeliyyat = int.Parse(Console.ReadLine());
                    switch (emeliyyat)
                    {

                        case 1:
                            Bank.Balance();
                            break;
                        case 2:
                            Bank.Banking();
                            break;
                        case 3:
                            Bank.Mexaric();
                            break;
                        default:
                            Console.WriteLine("Zehmet olmasa menyudan bir emeliyyat secin..");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Duzgun pin-le yeniden yoxlayin");
                }


            }
            else
            {
                Console.WriteLine("Zehmet olmasa reqemli pin daxil edin.");
            }
            
          
            
//public static void Balance()
//{
//    Console.WriteLine("Balansinizda 1000 azn var.");           
//}

//public static void Banking()
//{
//    int[] money = new int[7] { 200, 100, 50, 20, 10, 5, 1 };
//    Console.WriteLine("Istediyiniz meblegi daxil edin");
//
//    int user_request = int.Parse(Console.ReadLine());
//
//
//    if (user_request > 0 && user_request < 1001)
//    {
//        for (int i = 0; i < money.Length; i++)
//        {
//            if (user_request >= money[i])
//            {
//                int bankomat = user_request / money[i];
//                user_request -= bankomat * money[i];
//
//                System.Console.WriteLine(bankomat + " - " + money[i]);
//            }
//        }
//           Console.WriteLine("Balansinizda qalan mebleg: ");
//           Console.WriteLine(1000 - user_request);
//    }
//}
//
//
//public static void Mexaric()
//{
//    Console.WriteLine("Hesabinizda balans: 1000 AZN");
//}
//
//public static void Menu()
//{
//    Console.WriteLine("Istediyiniz emeliyyati daxil edin. Menu: ");
//    Console.WriteLine("1.Balans.");
//    Console.WriteLine("2.Negd pul cixarishi.");
//    Console.WriteLine("3.Umumi hesabdan cixarish.");
//}
//

        }
    }
}
