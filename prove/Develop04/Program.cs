using System;

class Program
{
    static void Main(string[] args)
    {
        Breathing breath = new Breathing();
        Reflection reflect = new Reflection();
        Listing list = new Listing();

        int choice = 0;
        while (choice != 4)
        {
            DisplayMenu();
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                breath.Begin();
            }
            else if (choice == 2)
            {
                reflect.Begin();
            }
            else if (choice == 3)
            {
                list.Begin();
            }
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflection activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Quit");
        Console.Write("Choose an option: ");
    }
}