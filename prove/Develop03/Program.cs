// Exceeds requirements:
// It's stores multiple scriptures and picks one at random
// each time the program runs, so the user gets a different scripture every session.

//Only hides VISIBLE words, words that are hidden will stay hidden

// Input validation only 'continue' or 'quit' are accepted, if user type different 
//input, prompt them again until they enter right word what the prompt ask.

class Program
{
    static void Main(string[] args)
    {
        ScriptureLibrary library = new ScriptureLibrary();
        Scripture scripture = library.GetRandomScripture();

        while (true)
        {
            Console.WriteLine();
            scripture.Display();
            Console.WriteLine();

            if (scripture.AllWordsHidden())
            {
                Console.WriteLine("All words are hidden. Great memorizing!");
                break;
            }

            Console.Write("Press Enter to continue or type 'quit' to exit: ");
            string input = Console.ReadLine()?.Trim().ToLower();

            if (input == "quit")
                break;
            else if (input == "continue")
                scripture.HideWords(3);
            else
                Console.WriteLine("Invalid input. type continue or type 'quit'.");
        }
    }
}
