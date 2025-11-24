using System.Runtime.CompilerServices;

public class Assignment
{
    private string _studentName;
    private string _topic;

    public Assignment(string topic, string name)
    {
        _studentName = name;
        _topic = topic;
    }

    protected string GetStudentName()
    {
        return _studentName;
    }

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}