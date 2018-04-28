using System;

public class Truck : Vehicle
{
    private const double AcConsumptionMod = 1.6;
    private const double FuelLossFactor = 0.95;

    public Truck(double fuelQuantity, double fuelConsumptionPerKm, double tankCapacity) 
        : base(fuelQuantity, fuelConsumptionPerKm + AcConsumptionMod, tankCapacity) { }

    public override void Refuel(double liters)
    {
        if (base.FuelQuantity + liters > base.TankCapacity)
        {
            throw new ArgumentException($"Cannot fit {liters} fuel in the tank");
        }

        base.Refuel(liters * FuelLossFactor);
    }
}