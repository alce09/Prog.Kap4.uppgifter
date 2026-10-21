using System;
namespace Uppgift4._7
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Skriv in en sträng");
            string text = Console.ReadLine();

            Console.WriteLine("Skriv in en sträng exakt med två tecken");
            string tecken = Console.ReadLine();


            if (tecken.Length != 2)
            {
                Console.WriteLine("Du måste skriva in exakt två tecken!");
            }

            else
            {
                bool finnstecken1 = false;
                bool finnstecken2 = false;

                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i] == tecken[0])
                    {
                        finnstecken1 = true;
                    }
                    
                    if (text[i] == tecken[1])
                    {
                        finnstecken2 = true;
                    }
                
                }
           
                if (finnstecken1 && finnstecken2)
                {
                    Console.WriteLine("Båda tecknen finns i strängen");
                }
                else
                {
                    Console.WriteLine("Båda tecknen finns inte i strängen");
                }
            
            }



        }



    }


}