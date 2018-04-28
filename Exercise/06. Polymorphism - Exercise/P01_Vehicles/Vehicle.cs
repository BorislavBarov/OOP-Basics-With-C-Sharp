public abstract class Vehicle : IVehicle
{
    private double fuelQuantity;
    private double fuelConsumptionPerKm;
    private double distanceTraveled;

    public Vehicle(double fuelQuantity, double fuelConsumptionPerKm)
    {
        this.FuelQuantity = fuelQuantity;
        this.FuelConsumptionPerKm = fuelConsumptionPerKm;
    }

    public double FuelQuantity
    {
        get { return this.fuelQuantity; }
        private set { this.fuelQuantity = value; }
    }

    public double FuelConsumptionPerKm
    {
        get { return this.fuelConsumptionPerKm; }
        private set { this.fuelConsumptionPerKm = value; }
    }
    
    public string Drive(double distance)
    {
        var neededFuel = distance * this.FuelConsumptionPerKm;
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

    public virtual void Refuel(double liters)
    {
        this.FuelQuantity += liters;
    }

    public override string ToString()
    {
        var message = $"{GetType().Name}: {this.FuelQuantity:f2}";
        return message;
    }
}