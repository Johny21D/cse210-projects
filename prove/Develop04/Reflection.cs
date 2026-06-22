class Reflection : Activity
{
    private Random _random = new Random();

    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
    };

    // Pools that get emptied as prompts/questions are used
    private List<string> _availablePrompts = new List<string>();
    private List<string> _availableQuestions = new List<string>();

    public Reflection() : base("Reflection", @"This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
    }

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

    public string GetRandomQuestion()
    {
        if (_availableQuestions.Count == 0)
        {
            _availableQuestions = new List<string>(_questions);
        }
        int index = _random.Next(_availableQuestions.Count);
        string question = _availableQuestions[index];
        _availableQuestions.RemoveAt(index);
        return question;
    }

    public void Begin()
    {
        DisplayStartingMessage();
        Console.WriteLine(GetRandomPrompt());
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine(GetRandomQuestion());
            ShowSpinner(5);
        }
        DisplayEndingMessage();
    }
}