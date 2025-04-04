using LexiconExercise2.Helpers;

namespace LexiconExercise2
{
    class Repeat
    {
        internal static void Start()
        {
            //For-loop that outputs the input for each iteration
            Console.WriteLine("Input text:");
            string textInput = Console.ReadLine();

            Console.WriteLine($"{Environment.NewLine}You seem to be very fond of: ");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"{i}.{textInput} ");
            }

            //Waiting for user input before returning to menu
            Utils.AwaitUserInput();
        }
    }
}