using System;
using System.Linq;
using System.Text;

public class Student : Human
{
    private const int MinLength = 5;
    private const int MaxLength = 10;

    private string facultyNumber;

    public Student(string firstName, string lastName, string facultyNumber)
        : base (firstName, lastName)
    {
        this.FacultyNumber = facultyNumber;
    }

    public string FacultyNumber
    {
        get { return this.facultyNumber; }
        private set
        {
            if (!value.All(x => char.IsLetterOrDigit(x)) || value.Length < MinLength || value.Length > MaxLength)
            {
                throw new ArgumentException("Invalid faculty number!");
            }

            this.facultyNumber = value;
        }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.AppendLine(base.ToString())
          .AppendLine($"Faculty number: {this.FacultyNumber}");

        return sb.ToString();
    }
}