using LexiconExercise2.Helpers;

namespace LexiconExercise2
{
     class Third
    {
        internal static void Start()
        {
                       
            Console.WriteLine("Input a sentence with at least 3 words separated with whitespace");

            //Input is sent into a stringarray by using Split.method with a whitespace
            //StringSplitOptions.RemoveEmptyEntries generally ignores all whitespaces
            string input = Console.ReadLine();
            string[] thirdWord = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);


            //Checking if the stringarray contains 3 words separated with whitespace
            if (thirdWord.Length >= 3)
            {
                Console.WriteLine($"{Environment.NewLine}You wrote: {input}" + 
                    $"{Environment.NewLine}The third word in that sentence is: {thirdWord[2]}");
            }
            else
            {

                Console.WriteLine("Sentence shorter than 3 words");
            }           
        }
    }
}