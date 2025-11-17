public class Word
{
    private string _text;
    private bool _isHidden = false;

    public Word(string text)
    {
        _text = text;
    }

    public void Hide()
    {
        string wordHidden = "";

        foreach (char character in _text)
        {
            wordHidden += "_";
        }

        _text = wordHidden;

        _isHidden = true;
    }

    public bool isHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        return _text;
    }
}