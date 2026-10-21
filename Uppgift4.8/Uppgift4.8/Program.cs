using System;
namespace Uppgift4._8
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Ange triangelns sido längd!");
            int sidolangd = int.Parse(Console.ReadLine());

            for (int rad = 0; rad < sidolangd; rad++) 
            {
                for (int i = 0; i < rad + 1; i++ )
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
        
            
        }
    

    }


}