using System;
using System.Text;

public class Human
{
    private const int MinLengthOfFirstName = 4;
    private const int MinLengthOfLastName = 3;

    private string firstName;
    private string lastName;

    public Human(string firstName, string lastName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
    }

    public string FirstName
    {
        get { return this.firstName; }
        private set
        {
            this.ValidateName(value, MinLengthOfFirstName, "firstName");
            this.firstName = value;
        }
    }

    public string LastName
    {
        get { return this.lastName; }
        private set
        {
            this.ValidateName(value, MinLengthOfLastName, "lastName");
            this.lastName = value;
        }
    }

    private void ValidateName(string value, int minLength, string name)
    {
        if (!char.IsLetter(value[0]) || !char.IsUpper(value[0]))
        {
            throw new ArgumentException($"Expected upper case letter! Argument: {name}");
        }

        if (value.Length < minLength)
        {
            throw new ArgumentException($"Expected length at least {minLength} symbols! Argument: {name}");
        }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.AppendLine($"First Name: {this.FirstName}")
          .AppendLine($"Last Name: {this.LastName}");

        return sb.ToString().TrimEnd();
    }
}