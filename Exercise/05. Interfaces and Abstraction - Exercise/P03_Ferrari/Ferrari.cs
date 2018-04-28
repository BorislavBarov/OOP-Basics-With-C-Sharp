public class Ferrari : ICar
{
    public Ferrari(string driverName)
    {
        this.Model = "488-Spider";
        this.DriverName = driverName;
    }

    public string Model { get; }

    public string DriverName { get; }

    public string PushTheGasPedal()
    {
        return "Zadu6avam sA!";
    }

    public string UseBrakes()
    {
        return "Brakes!";
    }

    public override string ToString()
    {
        return $"{this.Model}/{this.UseBrakes()}/{this.PushTheGasPedal()}/{this.DriverName}";
    }
}