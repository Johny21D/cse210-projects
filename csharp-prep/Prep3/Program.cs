using System;

class GuessingGame
{
    static void Main()
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        int guess = -1;
        int guess_Count = 0;

        do
        {
            Console.Write("What is your guess number?: ");
            guess = int.Parse(Console.ReadLine());
            guess_Count++;

            if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it right!");
                Console.WriteLine($"It took you {guess_Count} guesses.");
            }
        } while (guess != number);
    }
}