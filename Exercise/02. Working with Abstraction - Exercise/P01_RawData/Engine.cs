﻿public class Engine
{
    private int engineSpeed;
    private int enginePower;

    public Engine(int engineSpeed, int enginePower)
    {
        this.EngineSpeed = engineSpeed;
        this.EnginePower = enginePower;
    }

    public int EngineSpeed
    {
        get { return this.enginePower; }
        set { this.enginePower = value; }
    }

    public int EnginePower
    {
        get { return this.enginePower; }
        set { this.enginePower = value; }
    }
}