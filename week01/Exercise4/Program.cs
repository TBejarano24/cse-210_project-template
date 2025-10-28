using System;
using System.Collections.Generic; // It's not necessary, but it is necessary!

class Program
{
    static void Main(string[] args)
    {
        List<int> userNumbers = new List<int>();
        int intInput;
        int numbersSum = 0;
        double numbersAvg;
        int numbersMax;

        Console.WriteLine("Enter a series of numbers, write 0 when you're done");

        do
        {

            Console.Write("Enter a number: ");
            string strInput = Console.ReadLine();
            intInput = int.Parse(strInput);

            if (intInput != 0)
            {
                userNumbers.Add(intInput);
            }

        } while (intInput != 0);

        foreach (int number in userNumbers)
        {
            numbersSum += number;
        }

        numbersAvg = (float)numbersSum / userNumbers.Count;
        numbersMax = userNumbers.Max();

        Console.WriteLine($"The sum is: {numbersSum}");
        Console.WriteLine($"The average is: {numbersAvg:F2}");
        Console.WriteLine($"The largest number is: {numbersMax}");
    }
}