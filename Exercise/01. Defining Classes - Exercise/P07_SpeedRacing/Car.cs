using System;

public class Car
{
    private string model;
    private double fuelAmount;
    private double fuelConsumptionForOneKm;
    private int distanceTraveled;

    public Car(string model, double fuelAmount, double fuelConsumptionForOneKm)
    {
        this.Model = model;
        this.FuelAmount = fuelAmount;
        this.FuelConsumptionForOneKm = fuelConsumptionForOneKm;
        this.DistanceTraveled = 0;
    }

    public string Model
    {
        get { return this.model; }
        set { this.model = value; }
    }

    public double FuelAmount
    {
        get { return this.fuelAmount; }
        set { this.fuelAmount = value; }
    }

    public double FuelConsumptionForOneKm
    {
        get { return this.fuelConsumptionForOneKm; }
        set { this.fuelConsumptionForOneKm = value; }
    }

    public int DistanceTraveled
    {
        get { return this.distanceTraveled; }
        set { this.distanceTraveled = value; }
    }

    public void Drive(int amountOfKm)
    {
        var neededFuel = this.FuelConsumptionForOneKm * amountOfKm;

        if (neededFuel > this.FuelAmount)
        {
            Console.WriteLine("Insufficient fuel for the drive");
            return;
        }

        this.FuelAmount -= neededFuel;
        this.DistanceTraveled += amountOfKm;
    }
}