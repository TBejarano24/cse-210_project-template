public class PromptGenerator
{
    public List<string> _prompts = new();

    public string GetRandomPrompt()
    {
        Random randomNumber = new();
        int randomInt = randomNumber.Next(0, _prompts.Count);

        return _prompts[randomInt];
    }
}