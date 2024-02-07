using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("Blue", 3);
        shapes.Add(s1);

        Rectangle s2 = new Rectangle("Red", 2, 5);
        shapes.Add(s2);

        Circle s3 = new Circle("Purple", 2);
        shapes.Add(s3);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();

            Console.WriteLine($"The {color} shape area is {area}.");
        }
    }
}