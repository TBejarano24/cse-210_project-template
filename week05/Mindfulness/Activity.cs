public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    protected DateTime _startTime = new();
    protected DateTime _endTime = new();

    protected void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine("");

        Console.WriteLine($"{_description}.");
        Console.WriteLine("");

        do
        {
            try
            {
                Console.Write("How long, in seconds, would you like for your session? ");
                _duration = int.Parse(Console.ReadLine());
            }
            catch (System.FormatException)
            {
                Console.WriteLine("");
                Console.WriteLine("Invalid input!");
                Console.WriteLine("");
                _duration = -1;
            }
        } while (_duration == -1);

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
    }

    protected void StartTimer()
    {
        _startTime = DateTime.Now;
        _endTime = _startTime.AddSeconds(_duration);
    }

    protected void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!");
        ShowSpinner(5);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(5);
        Console.Clear();
    }

    protected void ShowSpinner(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b \b");
        }
        Console.WriteLine("");
    }

    protected void ShowCountdwon(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine("");
    }
}