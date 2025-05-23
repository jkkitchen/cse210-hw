using System;

class Program
{
    static void Main(string[] args)
    {
        //Call scripture from ScriptureGenerator class, it will be randomly selected from the 3 scriptures saved there
        ScriptureGenerator generator = new ScriptureGenerator();
        Scripture scripture = generator.GetRandomScripture();

        //Initial value for the number of words that are hidden
        int numberWordsHidden = 0;

        //Use do-while loop to update the counter and display the text of the scripture until IsCompletelyHidden is true
        do
        {
            //Display the Scripture
            Console.WriteLine(scripture.GetDisplayText());

            //Prompt the user to press Enter or type quit
            Console.WriteLine("Press enter to continue, or type quit to finish:");
            string userInput = Console.ReadLine();

            //Use if statement to determine if user entered "quit"
            if (userInput == "quit")
            {
                break;
            }
            else
            {
                //Clear the console
                Console.Clear();

                //Set numberWordsHidden to 1 so it will hide one word each time Enter is pressed
                numberWordsHidden = 1;

                //Update the scripture text to have more words hidden
                scripture.HideRandomWords(numberWordsHidden);
            }

        } while (scripture.IsCompletelyHidden() == false);

    }
}