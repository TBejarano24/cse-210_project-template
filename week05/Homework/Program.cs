using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment basicAssignment = new("Biodiversity in the West Coast", "Tomas Bejarano");
        MathAssignment mathematics = new("Fractions", "Jorge Alvarez", "8.1", "10-15");
        WritingAssignment writing = new("Understanding Society", "Romina Rodriguez", "Consequences of Global Events");

        Console.WriteLine(basicAssignment.GetSummary());

        Console.WriteLine(mathematics.GetSummary());
        Console.WriteLine(mathematics.GetHomeworkList());

        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());
    }
}