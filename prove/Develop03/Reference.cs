public class Reference
{
    private string _book;
    private int _chapter;
    private List<int> _verses;

    // Single verse: e.g. "John 3:16"
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verses = new List<int> { verse };
    }

    // Verse range: e.g. "Proverbs 3:5-6"
    public Reference(string book, int chapter, List<int> verses)
    {
        _book = book;
        _chapter = chapter;
        _verses = verses;
    }

    public void Display()
    {
        if (_verses.Count == 1)
            Console.Write($"{_book} {_chapter}:{_verses[0]}");
        else
            Console.Write($"{_book} {_chapter}:{_verses[0]}-{_verses[_verses.Count - 1]}");
    }
}
