using System;

public class Person
{
    private const int MinLength = 3;

    private string name;
    private int age;

    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public string Name
    {
        get { return this.name; }
        private set
        {
            if (value.Length < MinLength)
            {
                throw new ArgumentException($"{nameof(this.Name)}'s length should not be less than {MinLength} symbols!");
            }

            this.name = value;
        }
    }

    public virtual int Age
    {
        get { return this.age; }
        protected set
        {
            if (value < 0)
            {
                throw new ArgumentException($"{nameof(this.Age)} must be positive!");
            }

            this.age = value;
        }
    }

    public override string ToString()
    {
        return $"{nameof(this.Name)}: {this.Name}, {nameof(this.Age)}: {this.Age}";
    }
}