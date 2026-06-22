using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square("Red", 4);
        Rectangle rectangle = new Rectangle("Blue", 3, 5);
        Circle circle = new Circle("Green", 2);

        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}, Area: {shape.GetArea():F2}");
        }
    }
}
