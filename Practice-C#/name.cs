using System;

class NameProgram
{
    static void MainName()
    {
        // 1. Ask for the first name and save it
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        // 2. Ask for the last name and save it
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        // 3. Print them both out together
        Console.WriteLine($"Your name is  {firstName} {lastName}.");
    }
}