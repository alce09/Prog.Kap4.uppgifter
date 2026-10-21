using System;
namespace Uppgift4._9
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Hur många X per grupp?");
            int antalx = int.Parse(Console.ReadLine());

            Console.WriteLine("Hur många O per grupp?");
            int antalo = int.Parse(Console.ReadLine());

            Console.WriteLine("Hur många O mönster per rad?");
            int mönstero = int.Parse(Console.ReadLine());

            Console.WriteLine("Hur många rader vill du skriva ut?");
            int antalrader = int.Parse(Console.ReadLine());

            for (int i = 0; i < antalrader; i++) 
            {
                for(int j = 0; j < mönstero; j++)
                {
                    for (int k = 0; 
                }
            }
        }
   
    }

}