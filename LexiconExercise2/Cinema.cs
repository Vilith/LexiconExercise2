using LexiconExercise2.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace LexiconExercise2
{
    class Cinema
    {
        internal static void Start()
        {
            //Age, Price & Costs tend to be positive figures so i've chosen to use uint
            uint age;
            uint price = 0;
            uint totalCost = 0;

            //Getting the amount of visitors with help from a method in Utils
            uint cinemaVisitors = Utils.GetValidUint("How many will you be? ");

            //Counter to keep track on how many visitors
            for (uint i = 1; i <= cinemaVisitors; i++)
            {

                //Loops through until correct input is made
                while (true)
                {
                    Console.WriteLine($"Enter age for person {i}: ");

                    if (uint.TryParse(Console.ReadLine(), out age) && age >= 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Try again.");
                    }
                }

                //Setting price based on age
                if (age < 5 || age > 100)
                {
                    price = 0;
                }
                else if (age >= 5 && age < 20)
                {
                    price = 80;
                }
                else if (age > 64 && age <= 100)
                {
                    price = 90;
                }
                else
                {
                    price = 120;
                }

                totalCost += price;
            }

            //Writes the total amount of visitors and the total cost
            Console.WriteLine($"{Environment.NewLine}Total amount of visitors: {cinemaVisitors}");
            Console.WriteLine($"{Environment.NewLine}Total cost: {totalCost}");

            //Waiting for user input before returning to menu
            Utils.AwaitUserInput();
        }
    }
}
