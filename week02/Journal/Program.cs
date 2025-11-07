using System;

class Program
{
    static void Main(string[] args)
    {
        // To exceed requirements, I added try catch blocks to handle exceptions in case that the user tries to make an invalid input (both for choosing an action and looking up an unexisting file)
        // In order to implement these I had to look up C# documentation at w3schools.com and stackoverflow.com, as well as some trial and error

        Journal journalObject = new();
        PromptGenerator prompts = new();
        prompts._prompts.Add("What was the most bizarre thing that happened to you today?");
        prompts._prompts.Add("Who was the most interesting person you met today?");
        prompts._prompts.Add("What was the funniest thing you saw or heard today?");
        prompts._prompts.Add("What would you like to do tomorrow?");
        prompts._prompts.Add("What goals would you like to set for yourself?");

        string userChoice;
        int intChoice;

        do
        {
            Entry newEntry = new();

            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do?: ");
            userChoice = Console.ReadLine();

            try
            {
                intChoice = int.Parse(userChoice);
            }
            catch (System.FormatException)
            {
                intChoice = 0;
            }

            if (intChoice == 1)
            {
                DateTime currentDate = DateTime.Now;
                newEntry._date = currentDate.ToShortDateString();
                string currentPrompt = prompts.GetRandomPrompt();
                newEntry._promptText = currentPrompt;
                Console.WriteLine(currentPrompt);
                newEntry._entryText = Console.ReadLine();

                journalObject.AddEntry(newEntry);
            }
            else if (intChoice == 2)
            {
                journalObject.DisplayAll();
            }
            else if (intChoice == 3)
            {
                journalObject.SaveToFile();
            }
            else if (intChoice == 4)
            {
                journalObject.LoadFromFile();
            }
            else
            {
                Console.WriteLine("Invalid option!");
            }
        } while (intChoice != 5);
    }
}