using System;
using System.Formats.Asn1;

class Program
{
    static void Main(string[] args)
    {
        bool answer;

        do
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int intGuess;

            do
            {
                Console.Write("What is your guess? ");
                string stringGuess = Console.ReadLine();
                intGuess = int.Parse(stringGuess);

                if (intGuess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if (intGuess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }

            } while (intGuess != magicNumber);

            Console.Write("Would you like to play again? (yes/no) ");
            string stringAnswer = Console.ReadLine();

            if (stringAnswer == "yes")
            {
                answer = true;
            }
            else
            {
                answer = false;
            }

        } while (answer == true);

    }
}