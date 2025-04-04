using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconExercise2.Helpers
{
    public static class MenuHelper
    {

        public const string CINEMA = "1";
        public const string REPEAT = "2";
        public const string THIRD = "3";        
        public const string QUIT = "0";


        public static void ShowMainMenu()
        {
            Console.WriteLine($"{Environment.NewLine}|    Main Menu   |" +
                $"{Environment.NewLine}{CINEMA}: Cinema" +
                $"{Environment.NewLine}{REPEAT}: Repeating Word" +
                $"{Environment.NewLine}{THIRD}: Third Word" +
                $"{Environment.NewLine}{QUIT}: Quit!");

        }

        public static void InvalidText()
        {
            Console.WriteLine($"{Environment.NewLine}Invalid input!");
            
        }

               
        public static void MainMenu()
        {
            Console.WriteLine();

        }
    }
}