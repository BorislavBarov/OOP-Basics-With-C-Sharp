using System.Text;

public class Private : Soldier, IPrivate
{
    public Private(int id, string firstName, string lastName, double salary)
        : base(id, firstName, lastName)
    {
        this.Salary = salary;
    }

    public double Salary { get; }

    public override string ToString()
    {
        var sb = new StringBuilder();
        
        sb.AppendLine($"Name: {this.FirstName} {this.LastName} {nameof(this.Id)}: {this.Id} {nameof(this.Salary)}: {this.Salary:f2}");

        return sb.ToString().TrimEnd();
    }
}