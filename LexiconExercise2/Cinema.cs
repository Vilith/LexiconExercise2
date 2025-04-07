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
            uint maxCinemaVisitors = 10;

            //Getting the amount of visitors with help from a method in Utils
            uint cinemaVisitors = Utils.GetValidUint("How many tickets do you want to buy? ");


            while (cinemaVisitors > maxCinemaVisitors)
            {
                Console.WriteLine($"For reasons unknown you may only buy a total of {maxCinemaVisitors} tickets." +
                    $"{Environment.NewLine}Please enter an amount smaller than {maxCinemaVisitors}: ");
                cinemaVisitors = Utils.GetValidUint("How many tickets do you want to buy? ");
            }


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

                /*
                //Nested if-statement
                if (age < 5 || age > 100)
                {
                    price = 0;
                }
                else
                {
                    if (age < 20)
                    {
                        if (age >= 5)
                        {
                            price = 80;
                        }
                    }
                    else
                    {
                        if (age > 64)
                        {
                            price = 90;
                        }
                        else
                        {
                            price = 120;
                        }
                    }                    
                }
                totalCost += price;
                */

                
                //Setting price based on age
                if (age < 5 || age > 100)
                {
                    price = 0; //Under 4 year olds & 101 years and older watch movies for free
                }
                else if (age >= 5 && age < 20)
                {
                    price = 80; //Youths aged between 5 and 19 pays 80 SEK
                }
                else if (age > 64 && age <= 100)
                {
                    price = 90; //Seniors aged 65 to 100 pays 90 SEK
                }
                else
                {
                    price = 120; //People aged 20 - 64 pays 120 SEK
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

