class Program
{
    static void Main(string[] args)
    {
        ScriptureLibrary library = new ScriptureLibrary();
        Scripture scripture = library.GetRandomScripture();

        while (true)
        {
            Console.Clear();
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

            scripture.HideWords(3);
        }
    }
}
