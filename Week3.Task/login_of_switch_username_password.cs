using System;

namespace task_of_switch_username_password
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                * Username ve password deye deyisenler teyin edin.
                *
                *  Username : admin
                *  Password : 6gH123
                *
                * Istifadeciden  username ve Password daxil etmesini isteyin.
                *
                * Daxil edilen username ve passwordun teyin edilen
                * deyisenlerin deyerine beraber olub olmamasini yoxlayin,
                *
                * Netice olaraq login emeliyyatinin ugurlu ve ya
                *
                *  daxil edilen username ve ya sifrenin dogru olmadigi mesajini verin.
                *
                * ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                *  qeyd:  taski switch ile yazin
                *
                */


            Console.WriteLine("Enter username: ");
            string user_name = Console.ReadLine();

            switch (user_name)
            {
                case ("admin"):
                    Console.WriteLine("Username exists. ");
                    break;
                default:
                    Console.WriteLine("Invalid username used. Try again.");

                    break;
            }

            //Daxil olunan username admindirse password istenilir.
            if (user_name == "admin")
            {
                Console.WriteLine("Enter password: ");
                string user_password = Console.ReadLine();

                switch (user_password)
                {
                    case ("6gH123"):
                        Console.WriteLine("Successfull login");
                        break;
                    default:
                        Console.WriteLine("Invalid password used.");
                        break;
                }
            }
        }
    }
}
