public class Program
{
    public static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());      // 1/1
        Console.WriteLine(f1.GetDecimalValue());        // 1

        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());      // 5/1
        Console.WriteLine(f2.GetDecimalValue());        // 5

        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString());      // 3/4
        Console.WriteLine(f3.GetDecimalValue());        // 0.75

        Fraction f4 = new Fraction(1, 3);
        Console.WriteLine(f4.GetFractionString());      // 1/3
        Console.WriteLine(f4.GetDecimalValue());        // 0.3333333333333333

        // Practice Using Fraction Class
        Fraction fraction = new Fraction();
        Random random = new Random();

        for (int i = 1; i <= 20; i++)
        {
            int top = random.Next(1, 11);
            int bottom = random.Next(1, 11);

            fraction.SetTop(top);
            fraction.SetBottom(bottom);

            Console.WriteLine($"Fraction {i}: string: {fraction.GetFractionString()} Number: {fraction.GetDecimalValue():F2}");
        }
    }

    
}