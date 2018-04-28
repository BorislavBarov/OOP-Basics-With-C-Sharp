using System;
using System.Text;

public abstract class DrawingTool
{
    private int firstSide;
    private int secondSide;

    public DrawingTool(int firstSide)
    {
        this.FirstSide = firstSide;
        this.SecondSide = firstSide;
    }

    public int FirstSide
    {
        get { return this.firstSide; }
        set { this.firstSide = value; }
    }

    public int SecondSide
    {
        get { return this.secondSide; }
        set { this.secondSide = value; }
    }

    public void Draw()
    {
        var sb = new StringBuilder();

        string topAndBotRow = "|" + new string('-', this.FirstSide) + "|";
        sb.AppendLine(topAndBotRow);

        for (int row = 0; row < this.SecondSide - 2; row++)
        {
            sb.AppendLine("|" + new string(' ', this.FirstSide) + "|");
        }

        sb.AppendLine(topAndBotRow);

        Console.WriteLine(sb.ToString().TrimEnd());
    }
}