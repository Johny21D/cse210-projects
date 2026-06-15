using System;

class Program
{
    static void Main(string[] args)
    {

        int choice = 0;
    while (choice != 4)
        {
            DisplayMenu();
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Breathing breath = new Breathing();
                breath.Begin();
            }
            else if (choice == 2)
            {
                Reflection reflect = new Reflection();
                reflect.Begin();
            }
            else if (choice == 3)
            {
                Listing list = new Listing();
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