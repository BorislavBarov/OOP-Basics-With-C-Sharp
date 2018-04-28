using System.Collections.Generic;

public class Tire
{
    private KeyValuePair<double, int>[] tires;

    public Tire(double tire1Pressure, int tire1Age,
                double tire2Pressure, int tire2Age,
                double tire3Pressure, int tire3age,
                double tire4Pressure, int tire4age)
    {
        this.Tires = new KeyValuePair<double, int>[]
        {
            KeyValuePair.Create(tire1Pressure, tire1Age),
            KeyValuePair.Create(tire2Pressure, tire2Age),
            KeyValuePair.Create(tire3Pressure, tire3age),
            KeyValuePair.Create(tire4Pressure, tire4age)
        };
    }

    public KeyValuePair<double, int>[] Tires
    {
        get { return this.tires; }
        set { this.tires = value; }
    }
}