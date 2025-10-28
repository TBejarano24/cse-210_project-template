using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int favNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(favNumber);
        DisplayResult(squaredNumber, userName);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();

        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string strNumber = Console.ReadLine();
        int userNumber = int.Parse(strNumber);

        return userNumber;
    }

    static int SquareNumber(int number)
    {
        int numberSquared = number * number;
        return numberSquared;
    }

    static void DisplayResult(int number, string name)
    {
        Console.WriteLine($"{name}, the square of your number is: {number}");
    }
}