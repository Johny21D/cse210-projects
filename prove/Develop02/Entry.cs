class Entry
{
    //attributes
    public string _date;
    public string _prompt;
    public string _response;
    public string _mood;

    //behavior
    public void Display()
    {
        Console.WriteLine($"{_date} (mood: {_mood}) - {_prompt} - {_response}");
    }
}