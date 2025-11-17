using System;

class Program
{
    static void Main(string[] args)
    {

        /* This is my Program.cs for the scripture memorizer project
        In an attempt to exceed the requirements, I designed the Scripture.HideRandomWords() method
        specifically to only hide those words that are not hidden; if it comes across a word that is
        already hidden, it will skip it and look for another one until it finds it.
        Another feature of the aforementioned method is that the amount of words hidden per round
        can be customized, and if there is any remainder of words that are less than the specified
        amount, those will be hidden succesfully instead of finishing the program. */

        /* This right here 👇 is an example of a scripture reference with only one verse */

        // Reference reference = new("1 Nephi", 13, 19);
        // Scripture scripture = new(reference, "And I, Nephi, beheld that the Gentiles that had gone out of captivity were delivered by the power of God out of the hands of all other nations.");

        Reference reference = new("Ether", 12, 1, 2);
        Scripture scripture = new(reference, "And it came to pass that the days of Ether were in the days of Coriantumr; and Coriantumr was king over all the land. And Ether was a prophet of the Lord; wherefore Ether came forth in the days of Coriantumr, and began to prophesy unto the people, for he could not be restrained because of the Spirit of the Lord which was in him.");

        string userInput;

        bool allWordsHidden;

        do
        {
            allWordsHidden = scripture.IsCompletelyHidden();
            Console.Clear();

            Console.WriteLine("");
            Console.WriteLine(scripture.GetDisplayText());
            Console.Write("Press 'Enter' to continue or type 'quit' to finish: ");
            userInput = Console.ReadLine();

            if (userInput == "")
            {
                scripture.HideRandomWords(3);
            }
            else if (userInput != "quit")
            {
                Console.WriteLine("Invalid input");
            }

            Console.WriteLine("");


        } while (userInput != "quit" ^ allWordsHidden == true);

    }
}