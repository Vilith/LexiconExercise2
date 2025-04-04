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


            //Checking if 
            if (thirdWord.Length >= 3)
            {
                Console.WriteLine($"{Environment.NewLine}You wrote: {input}" + 
                    $"{Environment.NewLine}The third word in that sentence is: {thirdWord[2]}");
            }
            else
            {

                Console.WriteLine("Sentence shorter than 3 words");
            }
/*
            //This snippet is a draft for testing if it works.
            //Refactor when it works.

            //Test less than 3 words
            //string testString1 = "These words";
            //string[] testArray = testString1.Split(" ");

            //Test exactly 3 words
            //string testString2 = "These three words";
            //string[] testArray = testString2.Split(" ");

            //Test more than 3 words
            string testString3 = "This texts purpose is for testing";            
            string[] testArray = testString3.Split(" ");

            if (testArray.Length >= 3)
            {
                Console.WriteLine($"The third word is: {testArray[2]}");
            } 
            else
            {
                Console.WriteLine("This sentence does not contain enough word to extract the third word.");
            }
*/

           
        }
    }
}