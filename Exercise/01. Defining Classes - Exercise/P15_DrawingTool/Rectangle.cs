public class Rectangle : DrawingTool
{
    public Rectangle(int firstSide, int secondSide) :
            base(firstSide)
    {
        base.SecondSide = secondSide;
    }
}