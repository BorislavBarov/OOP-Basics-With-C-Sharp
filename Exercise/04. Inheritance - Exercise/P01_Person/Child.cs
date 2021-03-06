﻿using System;

public class Child : Person
{
    private const int MaxAge = 15;

    public Child(string name, int age)
        : base(name, age) { }

    public override int Age
    {
        get { return base.Age; }
        protected set
        {
            if (value > MaxAge)
            {
                throw new ArgumentException($"{GetType().Name}'s age must be less than {MaxAge}!");
            }

            base.Age = value;
        }
    }
}