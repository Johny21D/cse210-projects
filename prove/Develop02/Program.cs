using System;
class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        // List of prompts to choose from
        List<string> prompts = new List<string>();
        prompts.Add("Who was the most interesting person I interacted with today?");
        prompts.Add("What was the best part of my day?");
        prompts.Add("How did I see the hand of the Lord in my life today?");
        prompts.Add("What was the strongest emotion I felt today?");
        prompts.Add("If I had one thing I could do over today, what would it be?");
        prompts.Add("What is something new I learned today?");
        prompts.Add("What is one thing I am grateful for today?");
        prompts.Add("What is one small win I had today?");

        Random random = new Random();

        Console.WriteLine("Welcome to the Journal Program!");

        string choice = "";
        while (choice != "5")
        {
            Console.WriteLine();
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

            if (choice == "1")
            {

                string prompt = "";
                string response = "";
                while (true)
                {
                    int index = random.Next(prompts.Count);
                    prompt = prompts[index];
                    Console.WriteLine(prompt);
                    Console.WriteLine("(Type 'skip' if you want a different prompt)");
                    Console.Write("> ");
                    response = Console.ReadLine();

                    if (response != "skip")
                    {
                        break;
                    }
                    Console.WriteLine("Okay, here's a different one...");
                    Console.WriteLine();
                }

                Console.Write("In one word, how would you describe your mood today? ");
                string mood = Console.ReadLine();

                // Build the entry
                Entry entry = new Entry();
                entry._date = DateTime.Now.ToString("ddd M/d/yyyy");
                entry._prompt = prompt;
                entry._response = response;
                entry._mood = mood;

                journal.AddEntry(entry);
                Console.WriteLine("Entry saved.");
            }
            else if (choice == "2")
            {
                Console.WriteLine($"You have {journal._entries.Count} entries:");
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }
            else if (choice == "4")
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
            else if (choice == "5")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Please enter a number from 1 to 5.");
            }
        }
    }
}