﻿using System.Text;

public class Dog : Animal
{
    public Dog(string name, string favouriteFood) 
        : base(name, favouriteFood) { }

    public override string ExplainSelf()
    {
        var sb = new StringBuilder();

        sb.AppendLine(base.ExplainSelf())
          .AppendLine("DJAAF");

        return sb.ToString().TrimEnd();
    }
}