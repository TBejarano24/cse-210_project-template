using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new("Purple", 5);
        Rectangle rectangle = new("Red", 10, 4);
        Circle circle = new("Green", 3);

        List<Shape> shapes = [square, rectangle, circle];

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"{shape} statistics");
            Console.WriteLine(shape.GetColor());
            Console.WriteLine($"{shape.GetArea():F2}");

            Console.WriteLine("");
        }
    }
}