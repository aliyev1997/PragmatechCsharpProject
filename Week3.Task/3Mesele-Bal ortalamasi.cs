using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your last name: ");
            string surname = Console.ReadLine();

            Console.WriteLine("Enter your first exam score: ");
            string examScore1 = Console.ReadLine();
            Console.WriteLine("Enter your second exam score: ");
            string examScore2 = Console.ReadLine();
            Console.WriteLine("Enter your third exam score: ");
            string examScore3 = Console.ReadLine();
            Console.WriteLine("Enter your fourth exam score: ");
            string examScore4 = Console.ReadLine();



            Console.WriteLine("Name and Surname: " + name + " " + surname);

            Console.WriteLine();


            Console.WriteLine("Result: " + examScore1);
            Console.WriteLine("Result: " + examScore2);
            Console.WriteLine("Result: " + examScore3);
            Console.WriteLine("Result: " + examScore4);



            Console.WriteLine();
            int Overall = ((Int32.Parse(examScore1) + Int32.Parse(examScore2) + Int32.Parse(examScore3) + Int32.Parse(examScore4)) / 4);

            if (Overall < 45)
            {
                Console.WriteLine("Average: " + Overall);
                Console.WriteLine("Semestr yekunu: qeyri - kafi Kece bilmediz");
            }
            else if (Overall == 45 || Overall <= 70)
            {
                Console.WriteLine("Average: " + Overall);
                Console.WriteLine("Semestr yekunu: Meqbul");
            }
            else if (Overall == 70 || Overall <= 90)
            {
                Console.WriteLine("Average: " + Overall);
                Console.WriteLine("Semestr yekunu: Yaxsi");

            }
            else if (Overall > 90 || Overall <= 100)
            {
                Console.WriteLine("Average: " + Overall);
                Console.WriteLine("Semestr yekunu: Ela");
            }

        }
    }
}
