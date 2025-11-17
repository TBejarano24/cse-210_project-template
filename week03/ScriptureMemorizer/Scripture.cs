public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        string[] stringWords = text.Split(" ");

        foreach (string stringWord in stringWords)
        {
            Word newWord = new(stringWord);
            _words.Add(newWord);
        }
    }

    public string GetDisplayText()
    {
        string scriptureText = "";

        foreach (Word word in _words)
        {
            scriptureText += $"{word.GetDisplayText()} ";
        }

        return $"{_reference.GetDisplayText()} {scriptureText}";
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new();
        List<int> indexes = new();

        for (int i = 0; i < numberToHide; i++)
        {
            int index = random.Next(0, _words.Count());

            if (_words[index].isHidden() == true)
            {
                if (indexes.Count() == _words.Count())
                {
                    return;
                }
                else
                {
                    if (!indexes.Contains(index))
                    {
                        indexes.Add(index);
                    }

                    i--;
                }
            }
            else
            {
                _words[index].Hide();
            }
        }
    }

    public bool IsCompletelyHidden()
    {
        bool completelyHidden = false;

        foreach (Word word in _words)
        {

            if (word.isHidden())
            {
                completelyHidden = true;
            }
            else
            {
                completelyHidden = false;
                return completelyHidden;
            }
        }

        return completelyHidden;
    }
}