using System;

namespace face
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
            *  qeyd: ,ternary operator  ile yazin
            *
            */


            string Username = "admin";
            string Password = "6gH123";
            
            Console.WriteLine("Enter username: ");
            string user_name = Console.ReadLine();
            
            Console.WriteLine("Enter password: ");
            string user_password = Console.ReadLine();


            var b = user_name == Username && user_password == Password ? "Successfull login. " : "Invalid login or password.";
             Console.WriteLine(b);



        }
    }
}


           