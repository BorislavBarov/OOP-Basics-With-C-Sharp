public class StreetExtraordinaire : Cat
{
    private int decibelsOfMeows;

    public StreetExtraordinaire(string name, int decibelsOfMeows)
        : base(name)
    {
        this.DecibelsOfMeows = decibelsOfMeows;
    }

    public int DecibelsOfMeows
    {
        get { return this.decibelsOfMeows; }
        set { this.decibelsOfMeows = value; }
    }

    public override string ToString()
    {
        return $"StreetExtraordinaire {base.Name} {this.DecibelsOfMeows}";
    }
}