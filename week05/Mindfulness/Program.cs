using System;

/*
To exceed requirements I added exception handling to all user inputs through try catch statements.
These statements make sure that the user only enters values of the right data type.
*/

class Program
{
    static void Main(string[] args)
    {
        string userChoice;
        int userChoiceInt;

        do
        {

            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");

            userChoice = Console.ReadLine();

            try
            {
                userChoiceInt = int.Parse(userChoice);
                Console.Clear();
                Console.WriteLine("\x1b[3J");
            }
            catch (System.Exception)
            {
                userChoiceInt = 0;
            }

            if (userChoiceInt == 1)
            {
                BreathingActivity activity = new();
                activity.Run();
            }
            else if (userChoiceInt == 2)
            {
                ReflectingActivity activity = new();
                activity.Run();
            }
            else if (userChoiceInt == 3)
            {
                ListingActivity activity = new();
                activity.Run();
            }
            else if (userChoiceInt == 4)
            {
                break;
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Invalid input!");
                Console.WriteLine("");
            }

        } while (userChoiceInt != 4);

    }
}