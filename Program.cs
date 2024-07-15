using System;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            // int hour = 10;
            // if (hour > 0 && hour < 12)
            // {
            //     Console.WriteLine("It's morning.");
            // }
            // else if (hour >= 12 && hour < 18)
            // {
            //     Console.WriteLine("It's afternoon.");
            // }
            // else 
            // {
            //     Console.WriteLine("It's evening.");
            // }

            // bool isGoldCustomer = true;

            // //float price;
            // //if (isGoldCustomer)
            //     //price = 19.95f;
            // //else
            //     //price = 29.95f;

            // float price = (isGoldCustomer) ? 19.59 : 29.95f;
            // //? = if and : = else
            // Console.WriteLine(price);

            var season = Season.Autumn;
            switch (season)
            {
                case Season.Autumn:
                case Season.Summer:
                    // Console.WriteLine("Fall is a beautiful season.");
                    Console.WriteLine("We have a promotion");
                    break;

                // case Season.Summer:
                    // Console.WriteLine("Perfect beach weather");
                    // break;

                default:
                    Console.WriteLine("I don't know the season!");
                    break;
            }


        }
    }
}