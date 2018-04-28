using System.Collections.Generic;
using System.Text;

public class Commando : SpecialisedSoldier, ICommando
{
    private ICollection<IMission> missions;

    public Commando(int id, string firstName, string lastName, double salary, Corps corps)
        : base(id, firstName, lastName, salary, corps)
    {
        this.missions = new List<IMission>();
    }

    public IReadOnlyCollection<IMission> Missions
    {
        get { return (IReadOnlyCollection<IMission>)this.missions; }
    }

    public void AddMission(IMission mission)
    {
        this.missions.Add(mission);
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        
        sb.AppendLine(base.ToString())
          .AppendLine($"{nameof(this.Corps)}: {this.Corps}")
          .AppendLine($"{nameof(this.Missions)}:");

        foreach (var mission in this.Missions)
        {
            sb.AppendLine($"  {mission}");
        }

        return sb.ToString().TrimEnd();
    }
}