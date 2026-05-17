using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator prompts = new PromptGenerator();
        bool running = true;

        Console.WriteLine("Welcome to the Journal Program!");

        while (running)
        {
            Console.WriteLine();
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Search");
            Console.WriteLine("6. Stats");
            Console.WriteLine("7. Quit");
            Console.Write("What would you like to do? ");

            string input = Console.ReadLine();
            int choice;
            if (!int.TryParse(input, out choice))
            {
                Console.WriteLine("Please enter a number from 1 to 7.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    WriteNewEntry(journal, prompts);
                    break;
                case 2:
                    journal.DisplayAll();
                    break;
                case 3:
                    Console.Write("What is the filename? ");
                    string loadName = Console.ReadLine();
                    journal.LoadFromFile(loadName);
                    break;
                case 4:
                    Console.Write("What is the filename? ");
                    string saveName = Console.ReadLine();
                    journal.SaveToFile(saveName);
                    break;
                case 5:
                    Console.Write("Enter a keyword to search for: ");
                    string keyword = Console.ReadLine();
                    journal.Search(keyword);
                    break;
                case 6:
                    journal.ShowStats();
                    break;
                case 7:
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Please enter a number from 1 to 7.");
                    break;
            }
        }
    }

    static void WriteNewEntry(Journal journal, PromptGenerator prompts)
    {
        string prompt = prompts.GetRandomPrompt();
        Console.WriteLine(prompt);
        Console.Write("> ");
        string response = Console.ReadLine();

        Console.Write("In one word, how would you describe your mood today? ");
        string mood = Console.ReadLine();

        Entry entry = new Entry();
        entry.Date = DateTime.Now.ToShortDateString();
        entry.PromptText = prompt;
        entry.EntryText = response;
        entry.Mood = mood;

        journal.AddEntry(entry);
        Console.WriteLine("Entry saved.");
    }
}
    }
}
