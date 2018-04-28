using System;

public class Citizen : ICitizen
{
    public Citizen(string name, int age, string id, DateTime birthdate)
    {
        this.Name = name;
        this.Age = age;
        this.Id = id;
        this.Birthdate = birthdate;
    }

    public string Name { get; }

    public int Age { get; }

    public string Id { get; }

    public DateTime Birthdate { get; }
}