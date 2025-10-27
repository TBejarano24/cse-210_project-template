using System;

class Program
{
    static void Main(string[] args)
    {
        string letter;
        string symbol;

        Console.Write("What is your grade percentage?: ");
        string userInput = Console.ReadLine();
        int gradePercentage = int.Parse(userInput);

        if (gradePercentage % 10 >= 7)
        {
            symbol = "+";
        }
        else if (gradePercentage % 10 < 3)
        {
            symbol = "-";
        }
        else
        {
            symbol = "";
        }

        Console.WriteLine("");

        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (letter == "F" || (letter == "A" && symbol == "+"))
        {
            Console.WriteLine($"Your grade is {letter}");
        }
        else
        {
            Console.WriteLine($"Your grade is: {letter}{symbol}");
        }

        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        else
        {
            Console.WriteLine("You didn't pass, prepare for next time!");
        }
    }
}