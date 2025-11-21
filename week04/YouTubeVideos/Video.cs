public class Video
{
    private string _title;
    private string _author;
    private int _lengthSec;
    private List<Comment> _comments = new();

    public Video(string title, string author, int lengthSec, List<Comment> comments)
    {
        _title = title;
        _author = author;
        _lengthSec = lengthSec;

        foreach (Comment comment in comments)
        {
            _comments.Add(comment);
        }
    }

    public void DisplayInfo()
    {
        Console.WriteLine("");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length (Seconds): {_lengthSec}");
        Console.WriteLine($"Comments: {TotalComments()}");
        Console.WriteLine("");
        DisplayComments();
    }

    private int TotalComments()
    {
        return _comments.Count();
    }

    private void DisplayComments()
    {
        foreach (Comment comment in _comments)
        {
            Console.WriteLine(comment.GetContent());
        }
    }
}