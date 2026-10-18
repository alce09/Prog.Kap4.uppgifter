using System; 
namespace Uppgift4._5
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Skriv in ett heltal på cirka 4 - 5 siffror");
            string tal = Console.ReadLine();

            string resultat = "";

            for (int i = 0; i < tal.Length; i++)
            {

                int siffra = tal[i] - '0';

                if (siffra ==9)
                {

                    siffra = 0;

                }

                else
                {

                    siffra = siffra + 1;

                }

                resultat = resultat + siffra;



            }


            Console.WriteLine(resultat);
        }



    }



}