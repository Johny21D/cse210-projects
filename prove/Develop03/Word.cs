public class Word
{
    private string _text;
    private bool _visible;

    public Word(string text)
    {
        _text = text;
        _visible = true;
    }

    public void DisplayText()
    {
        if (_visible)
            Console.Write(_text);
        else
            Console.Write(new string('_', _text.Length));
    }

    public bool IsVisible()
    {
        return _visible;
    }

    public void Show()
    {
        _visible = true;
    }

    public void Hide()
    {
        _visible = false;
    }
}
