public class Rectangle : Shape
{
    private double height;
    private double width;

    public Rectangle(double height, double width)
    {
        this.Height = height;
        this.Width = width;
    }

    public double Height
    {
        get { return this.height; }
        set { this.height = value; }
    }

    public double Width
    {
        get { return this.width; }
        set { this.width = value; }
    }

    public override double CalculateArea()
    {
        var result = this.Height * this.Width;
        return result;
    }

    public override double CalculatePerimeter()
    {
        var result = 2 * (this.Height + this.Width);
        return result;
    }

    public override string Draw()
    {
        var message = $"{base.Draw()} {GetType().Name}";
        return message;
    }
}