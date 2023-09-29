using System;
namespace Inlämnings_Uppgift_2._4

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in månadslönen för dina tre anställda på var sin rad.");
            int lön1 = int.Parse(Console.ReadLine());
            int lön2 = int.Parse(Console.ReadLine());
            int lön3 = int.Parse(Console.ReadLine());
            double medellön = (lön1 + lön2 + lön3) / 3.0;
            Console.WriteLine($"De anställdas medellön är {medellön} kr/ månad.");
            Console.ReadKey();  
        }
    }
}