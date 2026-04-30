using System;
using System.Globalization;

class Numbers
{
    static void Main()
    
    {
        List<int> numbers=new List<int>();
        int input;
        Console.Write("ENter a list of numbers, type 0 when finsihed. ");
        do
        {
            Console.Write("Enter number: ");
            input = int.Parse(Console.ReadLine());
            if (input != 0)
            {
                numbers.Add(input);
            }
        } while (input!=0);

        int sum = 0;
        foreach (int n in numbers)
        {
            sum += n;
        }

        // Calculate average
        double average = (double)sum / numbers.Count;

        // Find the largest
        int largest = numbers[0];
        foreach (int n in numbers)
        {
            if (n > largest)
            {
                largest = n;
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}