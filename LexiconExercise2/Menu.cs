using LexiconExercise2.Helpers;

namespace LexiconExercise2
{
    internal class Menu
    {
        public Menu()
        {
            //Setting a bool as true, so as long as it's true the program is running.
            bool welcome = true;

            do
            {
                MenuHelper.ShowMainMenu();

                string input = Console.ReadLine();

                switch (input)
                {
                    case MenuHelper.CINEMA:
                        Cinema cinema = new Cinema();
                        Cinema.Start();
                        break;

                    case MenuHelper.REPEAT:
                        Repeat repeat = new Repeat();
                        Repeat.Start();
                        break;

                    case MenuHelper.THIRD:
                        Third third = new Third();
                        Third.Start();
                        break;

                    case MenuHelper.QUIT:
                        welcome = false;
                        break;

                    default:
                        MenuHelper.InvalidText();
                        break;

                }
            }             
            while (welcome);
        }
    }
}