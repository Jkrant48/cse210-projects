

public class Rectangle : Shape
{
    private double _length;
    private double _width;

    public Rectangle(double width, double length, string color) : base (color)
    {
        _length = length;
        _width = width;
    }

    public override double GetArea()
    {
        return _length * _width;
    }
}