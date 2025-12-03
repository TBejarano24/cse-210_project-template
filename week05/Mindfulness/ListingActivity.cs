public class ListingActivity : Activity
{
    private int _count = 0;
    private List<string> _prompts = new();

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public void Run()
    {
        base.DisplayStartingMessage();
        DisplayPrompt();
        base.StartTimer();
        UserListing();
        base.DisplayEndingMessage();
    }

    private void DisplayPrompt()
    {
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine("");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine("");
        Console.Write("You may begin in: ");
        base.ShowCountdwon(5);
        Console.WriteLine("");
    }

    private string GetRandomPrompt()
    {
        string[] prompts = System.IO.File.ReadAllLines("listingPrompts.txt");

        foreach (string prompt in prompts)
        {
            _prompts.Add(prompt);
        }

        Random random = new();
        int index = random.Next(_prompts.Count());

        return _prompts[index];
    }

    private void UserListing()
    {
        do
        {

            Console.Write("> ");
            Console.ReadLine();
            _count += 1;

        } while (DateTime.Now < _endTime);

        Console.WriteLine("");
        Console.WriteLine($"You listed {_count} items!");
        Console.WriteLine("");
    }
}