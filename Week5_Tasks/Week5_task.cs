using System;



namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adinizi daxil edin: ");
            string ad = Console.ReadLine();
            Console.WriteLine("Soyadinizi daxil edin: ");
            string soyad = Console.ReadLine();
            
            Console.WriteLine("1ci imtahan neticenizi daxil edin: ");
            int imtahan1= int.Parse(Console.ReadLine());
            Console.WriteLine("2ci imtahan neticenizi daxil edin: ");
            int imtahan2 = int.Parse(Console.ReadLine());
            Console.WriteLine("3cu imtahan neticenizi daxil edin: ");
            int imtahan3= int.Parse(Console.ReadLine());

            Student.Calculate(imtahan2,  imtahan3,  ad,  soyad, imtahan1);





        }
      //static void Calculate(int imtahan1, int imtahan2, int imtahan3, string ad, string soyad)
      //{
      //    int Result = (imtahan1 + imtahan2 + imtahan3) / 3;
      //    Console.WriteLine(ad.ToUpper() +" "+ soyad.ToUpper() + " imtahan neticeleriniz: ");
      //    Console.WriteLine(imtahan1);
      //    Console.WriteLine(imtahan2);
      //    Console.WriteLine(imtahan3);
      //    
      //    Console.WriteLine("Ortalamaniz: ");
      //    Console.WriteLine(Result);
      //    
      //    if(Result>81 ^ Result == 81)
      //    {
      //        Console.WriteLine("Siz diplom ishine dusmursuz. ");
      //    }
      //    else
      //    {
      //        Console.WriteLine("Siz diplom ishine dusursuz.");
      //    }
      //
      //
      //}
    }
}
