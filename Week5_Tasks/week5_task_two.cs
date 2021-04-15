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



        }
    }
}
