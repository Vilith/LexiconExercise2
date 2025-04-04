namespace LexiconExercise2.Helpers
{
    public static class Utils
    {

        //Method for getting a valid uint
        public static uint GetValidUint(string prompt)
        {
            uint result;
            Console.WriteLine(prompt);

            while (!uint.TryParse(Console.ReadLine(), out result) || result == 0)
            {
                Console.WriteLine("Invalid input!");
            }
            return result;
        }


        //Method for awaiting userinput before continuing
        public static void AwaitUserInput()
        {
            Console.WriteLine($"{Environment.NewLine}Press any key to continue!");
            Console.ReadKey();
        }
    }
}
