using System.Collections.Generic;
using System.Text;

public class LeutenantGeneral : Private, ILeutenantGeneral
{
    private ICollection<ISoldier> privates;

    public LeutenantGeneral(int id, string firstName, string lastName, double salary)
        : base(id, firstName, lastName, salary)
    {
        this.privates = new List<ISoldier>();
    }

    public IReadOnlyCollection<ISoldier> Privates
    {
        get { return (IReadOnlyCollection<ISoldier>)this.privates; }
    }

    public void AddPrivate(ISoldier privateSoldier)
    {
        this.privates.Add(privateSoldier);
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        
        sb.AppendLine(base.ToString())
          .AppendLine($"{nameof(this.Privates)}:");

        foreach (var privateSoldier in this.Privates)
        {
            sb.AppendLine($"  {privateSoldier}");
        }

        return sb.ToString().TrimEnd();
    }
}