using System;

namespace Selahiyyet_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your credentials: ");
            string user_cred = Console.ReadLine();
            
            switch (user_cred)
            {
                case ("AA"):
                case ("CC"):
                case ("BB"):
                    Console.WriteLine("Admin selahiyyetlerine sahibsiniz.");
                    break;
                case ("MM"):
                    Console.WriteLine("Moderator selahiyyetlerine sahibsiniz.");
                    break;
                case ("MH"):
                    Console.WriteLine("Muhasib selahiyyetlerine sahibsiniz.");
                    break;
                case ("UU"):
                    Console.WriteLine("Standart istifadeci selahiyyetlerine sahibsiniz.");
                    break;
            
                default:
                    Console.WriteLine("Daxil edilen selahiyyet dogru deyil");
                    break;
            
            
            }   
        }
    }
}
