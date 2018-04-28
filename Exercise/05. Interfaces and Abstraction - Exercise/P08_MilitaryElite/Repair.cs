using System.Text;

public class Repair : IRepair
{
    public Repair(string partName, int hoursWorked)
    {
        this.PartName = partName;
        this.HoursWorked = hoursWorked;
    }

    public string PartName { get; }

    public int HoursWorked { get; }

    public override string ToString()
    {
        var sb = new StringBuilder();
        
        sb.AppendLine($"Part Name: {this.PartName} Hours Worked: {this.HoursWorked}");

        return sb.ToString().TrimEnd();
    }
}