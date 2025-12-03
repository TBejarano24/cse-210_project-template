public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing";
    }

    public void Run()
    {
        base.DisplayStartingMessage();
        base.StartTimer();

        do
        {

            Console.Write($"Breathe in... ");
            base.ShowCountdwon(4);

            Console.Write($"Now breathe out... ");
            base.ShowCountdwon(6);
            Console.WriteLine("");

        } while (DateTime.Now < _endTime);

        base.DisplayEndingMessage();
    }
}