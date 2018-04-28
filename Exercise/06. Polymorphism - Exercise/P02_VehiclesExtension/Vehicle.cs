using System;

public abstract class Vehicle : IVehicle
{
    private double fuelQuantity;
    private double fuelConsumptionPerKm;
    private double tankCapacity;

    public Vehicle(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity)
    {
        this.TankCapacity = tankCapacity;
        this.FuelQuantity = fuelQuantity;
        this.FuelConsumptionPerKm = fuelConsumptionPerKm;
    }

    public double FuelQuantity
    {
        get { return this.fuelQuantity; }
        protected set
        {
            if (value > this.TankCapacity)
            {
                value = 0;
            }

            this.fuelQuantity = value;
        }
    }

    public double FuelConsumptionPerKm
    {
        get { return this.fuelConsumptionPerKm; }
        private set { this.fuelConsumptionPerKm = value; }
    }

    public double TankCapacity
    {
        get { return this.tankCapacity; }
        private set { this.tankCapacity = value; }
    }

    public virtual string Drive(double distance)
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
        if (liters <= 0)
        {
            throw new ArgumentException($"Fuel must be a positive number");
        }

        if (this.FuelQuantity + liters > this.TankCapacity)
        {
            throw new ArgumentException($"Cannot fit {liters} fuel in the tank");
        }

        this.FuelQuantity += liters;
    }

    public override string ToString()
    {
        var message = $"{GetType().Name}: {this.FuelQuantity:f2}";
        return message;
    }
}