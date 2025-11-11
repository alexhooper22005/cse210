using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square s = new Square(10, "red");
        shapes.Add(s);

        Rectangle r = new Rectangle(10, 10, "blue");
        shapes.Add(r);

        Circle c = new Circle(10, "red");
        shapes.Add(c);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Type: {shape.GetName()}. Color: {shape.GetColor()}. Area: {shape.GetArea()}.");
        }


        
    }
}