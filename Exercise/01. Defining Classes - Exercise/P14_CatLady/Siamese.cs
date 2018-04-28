public class Siamese : Cat
{
    private int earSize;

    public Siamese(string name, int earSize)
        : base(name)
    {
        this.EarSize = earSize;
    }

    public int EarSize
    {
        get { return this.earSize; }
        set { this.earSize = value; }
    }

    public override string ToString()
    {
        return $"Siamese {base.Name} {this.EarSize}";
    }
}