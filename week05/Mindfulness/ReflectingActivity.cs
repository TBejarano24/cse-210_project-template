public class ReflectingActivity : Activity
{
    private List<string> _prompts = new();
    private List<string> _questions = new();

    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public void Run()
    {
        base.DisplayStartingMessage();
        DisplayPrompt();
        base.StartTimer();
        DisplayQuestions();
        base.DisplayEndingMessage();
    }

    private void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine("");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine("");
        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        base.ShowCountdwon(5);
        Console.Clear();
    }

    private string GetRandomPrompt()
    {
        string[] prompts = System.IO.File.ReadAllLines("reflectingPrompts.txt");

        foreach (string prompt in prompts)
        {
            _prompts.Add(prompt);
        }

        Random random = new();
        int index = random.Next(_prompts.Count());

        return _prompts[index];
    }

    private string GetRandomQuestion()
    {
        string[] questions = System.IO.File.ReadAllLines("questions.txt");

        foreach (string question in questions)
        {
            _questions.Add(question);
        }

        Random random = new();
        int index = random.Next(_questions.Count());

        return _questions[index];
    }

    private void DisplayQuestions()
    {
        do
        {

            Console.Write($"{GetRandomQuestion()} ");
            base.ShowSpinner(15);
            Console.WriteLine("");

        } while (DateTime.Now < _endTime);
    }
}