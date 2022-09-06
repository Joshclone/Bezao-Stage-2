
using System;

namespace GuessGame

{
    class Program
    {
        static void Main(string[] args)
        {

            int count = 0;
            int leapyear = 2022;


            //this condition checks
            //if a given year is not century, and it's completely divisible by 4 = leapyear
            //if a given year is a century, and it's completely divisible by 400 = leapyear, otherwise non leapyear.

            while (count < 20)

            {

                if (((leapyear % 4 == 0) && (leapyear % 100 != 0)) || (leapyear % 400 == 0))
                {

                    Console.WriteLine(leapyear);
                    count++;
                }
                leapyear++;
            }
            Console.ReadLine();

        }





    }
}


