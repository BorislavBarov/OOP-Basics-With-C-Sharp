public class Bus : Vehicle
{
    private const double AcConsumptionMod = 1.4;

    public Bus(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity)
        : base(fuelQuantity, fuelConsumptionPerKm, tankCapacity) { }

    public string DriveEmpty(double distance)
    {
        var neededFuel = distance * this.FuelConsumptionPerKm;
        return ExecuteDriveCommand(distance, neededFuel);
    }
    
    public override string Drive(double distance)
    {
        var neededFuel = distance * (this.FuelConsumptionPerKm + AcConsumptionMod);
        return ExecuteDriveCommand(distance, neededFuel);
    }

    private string ExecuteDriveCommand(double distance, double neededFuel)
    {
        var message = string.Empty;

        if (neededFuel > this.FuelQuantity)
        {
            message = $"{GetType().Name} needs refueling";
            return message;
        }

        this.FuelQuantity -= neededFuel;

        message = $"{GetType().Name} travelled {distance} km";
        return message;
    }
}