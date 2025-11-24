public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string topic, string name, string title) : base(topic, name)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return $"{_title} by {base.GetStudentName()}";
    }
}