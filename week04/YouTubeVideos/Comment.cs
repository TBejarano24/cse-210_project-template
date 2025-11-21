public class Comment
{
    private string _user;
    private string _text;

    public Comment(string user, string text)
    {
        _user = user;
        _text = text;
    }

    public string GetContent()
    {
        string fullComment = $"{_user} \n {_text}";

        return fullComment;
    }
}