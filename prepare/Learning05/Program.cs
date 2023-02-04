using System;

class Program
{
    static void Main(string[] args)
    {
        
        Square square1 = new Square("red", 3);
        string color = square1.GetColor();
        double area = square1.GetArea();
        Console.WriteLine($"This Shape has {color} color and {area} area");

        Rectangle rectangle1 = new Rectangle("grey", 3,3);
        string color1 = rectangle1.GetColor();
        double area1 = rectangle1.GetArea();
        Console.WriteLine($"This Shape has {color1} color and {area1} area");

        Circle circle1 = new Circle("ambar", 3);
        string color2 = circle1.GetColor();
        double area2 = circle1.GetArea();
        Console.WriteLine($"This Shape has {color2} color and {area2} area");
        
        Console.WriteLine();

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square1);
        shapes.Add(rectangle1);
        shapes.Add(circle1);

        foreach (Shape shape in shapes)
        {
            string colorX = shape.GetColor();
            double areaX = shape.GetArea();
            Console.WriteLine($"This Shape has {colorX} color and {areaX} area");
            
        }

    }
}