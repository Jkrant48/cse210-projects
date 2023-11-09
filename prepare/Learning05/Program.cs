using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning05 World!");

        List<Shape> shapes = new List<Shape>();

        Square square1 = new Square(4,"Blue");
        shapes.Add(square1);

        Rectangle rectangle1 = new Rectangle(4, 5, "Black");
        shapes.Add(rectangle1);

        Circle circle1 = new Circle(5, "Yellow");
        shapes.Add(circle1);

        foreach(Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}");
        }
        
    }
}