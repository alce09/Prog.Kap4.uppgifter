using System;

namespace Uppgift4._4
{
    class Program
    {
        static void Main(string[]args)
        {

            string val;
            int tal1;
            int tal2;
            

            do
            {
                Console.WriteLine("Välj ett av följande alternativ:)");
                Console.WriteLine("1. Subtrahera ett tal med ett annat");
                Console.WriteLine("2. Dividera ett tal med ett annat");
                Console.WriteLine("3. Avsluta programmet");

                val = Console.ReadLine().ToLower();

                switch (val)
                {
                    case "1":
                        {
                            Console.WriteLine("Skriv ett tal som ska subtraheras med ett annat.");
                            tal1 = int.Parse(Console.ReadLine());

                            Console.WriteLine("Välj nu de andra talet");
                            tal2 = int.Parse(Console.ReadLine());

                            Console.WriteLine("Differansen av din subtraktion är " + (tal1 - tal2) + "");

                            break;
                        }

                    case "2":
                        {
                            Console.WriteLine("Skriv ett tal som ska divideras med ett annat med ett annat, talet får inte vara noll");
                            tal1 = int.Parse(Console.ReadLine());

                            Console.WriteLine("Välj nu de andra talet");
                            tal2 = int.Parse(Console.ReadLine());

                            if (tal1 == 0 || tal2 == 0)
                            {
                                Console.WriteLine("Talet får inte vara noll!");

                                Console.WriteLine("");

                                Console.WriteLine("Skriv nu istället ett tal som ska divideras med ett annat med ett annat, TALEN FÅR INTE VARA NOLL");
                                tal1 = int.Parse(Console.ReadLine());

                                Console.WriteLine("Välj nu de andra talet");
                                tal2 = int.Parse(Console.ReadLine());

                            }

                            Console.WriteLine("Produkten av din differans är " + (tal1 / tal2));



                            break;
                        }

                    case "3":
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Programmet avslutas");
                            break;
                        }

                    default:
                        Console.WriteLine("Ogiltigt val, försök igen!");
                        break;

                }


















            } while (val != "3");

        }

            

    }



}