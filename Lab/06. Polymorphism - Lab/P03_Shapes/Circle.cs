using System;

public class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.Radius = radius;
    }

    public double Radius
    {
        get { return this.radius; }
        set { this.radius = value; }
    }

    public override double CalculateArea()
    {
        var result = Math.PI * (this.Radius * this.Radius);
        return result;
    }

    public override double CalculatePerimeter()
    {
        var result = 2 * Math.PI * this.Radius;
        return result;
    }

    public override string Draw()
    {
        var message = $"{base.Draw()} {GetType().Name}";
        return message;
    }
}