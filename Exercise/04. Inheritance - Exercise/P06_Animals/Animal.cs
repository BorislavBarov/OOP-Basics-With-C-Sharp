using System;
using System.Text;

public class Animal : ISoundProducable
{
    private const string ErrorMessage = "Invalid input!";

    private string name;
    private int age;
    private string gender;

    public Animal(string name, int age, string gender)
    {
        this.Name = name;
        this.Age = age;
        this.Gender = gender;
    }

    public string Name
    {
        get { return this.name; }
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(ErrorMessage);
            }

            this.name = value;
        }
    }

    public int Age
    {
        get { return this.age; }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException(ErrorMessage);
            }

            this.age = value;
        }
    }

    public string Gender
    {
        get { return this.gender; }
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(ErrorMessage);
            }

            this.gender = value;
        }
    }

    public virtual string ProduceSound()
    {
        return "animal sounds";
    }

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.AppendLine($"{this.GetType().Name}")
          .AppendLine($"{this.Name} {this.Age} {this.Gender}")
          .AppendLine($"{this.ProduceSound()}");

        return sb.ToString().TrimEnd();
    }
}