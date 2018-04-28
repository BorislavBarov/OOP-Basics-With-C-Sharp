using System.Collections.Generic;
using System.Text;

public class Engineer : SpecialisedSoldier, IEngineer
{
    private ICollection<IRepair> repairs;

    public Engineer(int id, string firstName, string lastName, double salary, Corps corps)
        : base(id, firstName, lastName, salary, corps)
    {
        this.repairs = new List<IRepair>();
    }
    
    public IReadOnlyCollection<IRepair> Repairs
    {
        get { return (IReadOnlyCollection<IRepair>)this.repairs; }
    }

    public void AddRepair(IRepair repair)
    {
        this.repairs.Add(repair);
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        
        sb.AppendLine(base.ToString())
          .AppendLine($"{nameof(this.Corps)}: {this.Corps}")
          .AppendLine($"{nameof(this.Repairs)}:");

        foreach (var repair in this.Repairs)
        {
            sb.AppendLine($"  {repair}");
        }

        return sb.ToString().TrimEnd();
    }
}