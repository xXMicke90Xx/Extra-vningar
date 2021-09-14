using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtraÖvningar
{
    class Program
    {
        static void Main(string[] args)
        {

            //Övning 1

            //int nr1 = 1;



            //while (nr1 != 0)
            //{


            //    Console.WriteLine("Skriv ett nummer: ");
            //    while (!int.TryParse(Console.ReadLine(), out nr1));
            //    nr1 *= 10;
            //    Console.WriteLine(nr1);
            //}

            //Övning 2


            //int nr1 = 1;



            //do
            //{


            //    Console.WriteLine("Skriv ett nummer: ");
            //    while (!int.TryParse(Console.ReadLine(), out nr1)) ;
            //    nr1 *= 10;
            //    Console.WriteLine(nr1);

            //} while (nr1 != 0);

            //Övning 3

            //int nr = 15;

            //while(nr != 6)
            //{
            //    if (nr % 2 != 0)
            //    {
            //        Console.WriteLine(nr);
            //    }
            //    nr--;
            //}
            //Console.ReadLine();




            //Övning 4

            // Console.WriteLine("Skriv ett nummer: ");
            // int nr1 = 0;
            // int nr2 = 0;
            //while(!int.TryParse(Console.ReadLine(), out nr1));
            // nr2 = nr1;
            // while(nr1 != 0)
            // {
            //     Console.WriteLine("Skriv ett nummer: ");
            //     while (!int.TryParse(Console.ReadLine(), out nr1));
            //     Console.WriteLine($"{nr1} + {nr2} = {nr1+nr2}" );
            //     nr2 = nr1 + nr2;
            // }






            //========================================================
            //Något att jobba med till labbuppgiften!
            //========================================================

            string test = "Hej på dig 123 mamma 5 m5 k 5k";

            List<int> numbers = new List<int>();


            for (int i = 0; i < test.Length; i++)
            {

                if (Char.IsNumber(test[i]))
                {
                    numbers.Add (Convert.ToInt32(test[i].ToString()));

                    
                }



            }
            //hej


            foreach (int nr in numbers)
                Console.WriteLine(nr);
            Console.ReadLine();
        }
    }
}
