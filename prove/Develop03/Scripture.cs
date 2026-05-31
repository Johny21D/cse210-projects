public class Scripture
{
    private List<Word> _scriptText;
    private Reference _reference;
    private static Random _random = new Random();

    // Single verse constructor
    public Scripture(string text, string book, int chapter, int verse)
    {
        _reference = new Reference(book, chapter, verse);
        _scriptText = text.Split(' ').Select(w => new Word(w)).ToList();
    }

    // Verse range constructor
    public Scripture(string text, string book, int chapter, List<int> verses)
    {
        _reference = new Reference(book, chapter, verses);
        _scriptText = text.Split(' ').Select(w => new Word(w)).ToList();
    }

    public void HideWords(int count)
    {
        List<Word> visibleWords = _scriptText.Where(w => w.IsVisible()).ToList();
        int toHide = Math.Min(count, visibleWords.Count);

        for (int i = 0; i < toHide; i++)
        {
            int pick = _random.Next(visibleWords.Count);
            visibleWords[pick].Hide();
            visibleWords.RemoveAt(pick);
        }
    }

    public void ShowWords()
    {
        foreach (Word word in _scriptText)
            word.Show();
    }

    public bool AllWordsHidden()
    {
        return _scriptText.All(w => !w.IsVisible());
    }

    public void Display()
    {
        _reference.Display();
        Console.Write(" ");
        for (int i = 0; i < _scriptText.Count; i++)
        {
            _scriptText[i].DisplayText();
            if (i < _scriptText.Count - 1)
                Console.Write(" ");
        }
        Console.WriteLine();
    }
}
