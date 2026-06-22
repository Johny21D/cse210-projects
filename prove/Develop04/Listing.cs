class Listing : Activity
{
    private Random _random = new Random();

    public Listing() : base("Listing", @"This activity will help you reflect on the good things in your life by having you list 
    as many things as you can in a certain area.")
    {
    }

    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
    };

    private List<string> _availablePrompts = new List<string>();

    public string GetRandomPrompt()
    {
        if (_availablePrompts.Count == 0)
        {
            _availablePrompts = new List<string>(_prompts);
        }
        int index = _random.Next(_availablePrompts.Count);
        string prompt = _availablePrompts[index];
        _availablePrompts.RemoveAt(index);
        return prompt;
    }

    public void Begin()
    {
        DisplayStartingMessage();

        Console.WriteLine(GetRandomPrompt());
        ShowCountDown(5);

        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("List an item: ");
            items.Add(Console.ReadLine());
        }

        Console.WriteLine($"You listed {items.Count} items!");
        DisplayEndingMessage();
    }
}