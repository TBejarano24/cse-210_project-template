public class MathAssignment : Assignment
{
    private string _textBookSection;
    private string _problems;

    public MathAssignment(string topic, string name, string textBookSection, string problems) : base(topic, name)
    {
        _textBookSection = textBookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section: {_textBookSection} Problems: {_problems}";
    }
}