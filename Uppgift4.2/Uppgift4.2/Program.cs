using System;
using System.Diagnostics.SymbolStore;

namespace Uppgift4._2
{
    class Program
    {
        static void Main(string[]args)
        {


            Console.WriteLine("Skriv in ett heltal");
            int störstatal = int.Parse(Console.ReadLine().ToLower());

            Console.WriteLine("Vill du skriva in ett till heltal, svara ja eller nej");
            string svar = Console.ReadLine().ToLower();

            while (svar == "ja")
            {
                Console.WriteLine("Skriv in ett till heltal");
                int tal = int.Parse(Console.ReadLine().ToLower());

                if (tal>störstatal)
                {
                    tal = störstatal;

                }

                Console.WriteLine("Vill du skriva in ett till heltal, svara ja eller nej");
                svar = Console.ReadLine().ToLower();


            }

            Console.WriteLine("Största talet du skrev var " + störstatal);

            

            

            
            

        }



    }



}