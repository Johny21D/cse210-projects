using System;

class GradeProgram
{
    static void MainGRade()
    {
        Console.Write("Enter your grade Percentage: ");
        string input=Console.ReadLine();
        double gradePercentage = double.Parse(input);
        string letter = "";
        
        if (gradePercentage >= 90)
        {
            letter="A";
        }
        
        else if (gradePercentage >= 80)
        {
            letter="B";
        }
        else if (gradePercentage >= 70)
        {
            letter="C";
        }

        else if (gradePercentage >= 60)
        {
            letter="D";
        }

        else
        {
            letter="F";
        }
        Console.WriteLine($"Your letter grade is:{letter}");

        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Don't give up! Keep working hard for the next time.");
        }
    }
}