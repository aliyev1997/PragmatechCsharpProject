using System;

namespace task7_menfi_musbet_eded
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("0-dan ferqli bir eded daxil edin: ");
            int n = Int32.Parse(Console.ReadLine());
            string b = (n > 0) ? "Eded Musbetdir" : "Eded Menfidir";
            Console.WriteLine(b);

        }
    }
}
