using System;

namespace login
{
    class Program
    {
        static void Main(string[] args)
        {
            string Username = "admin";
            string Password = "6gH123";

            Console.WriteLine("Enter username: ");
            string user_name = Console.ReadLine();

            Console.WriteLine("Enter password: ");
            string user_password = Console.ReadLine();

            if (user_name == Username && user_password == Password) 
            {
                Console.WriteLine("Successfull login. ");
            }
            else
            {
                Console.WriteLine("Invalid login or password. ");
            }
           

        }
    }
}
