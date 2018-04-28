using System.Text;

public class Mission : IMission
{
    public Mission(string codeName, State state)
    {
        this.CodeName = codeName;
        this.State = state;
    }

    public string CodeName { get; }

    public State State { get; private set; }

    public void CompleteMission()
    {
        this.State = State.Finished;
    }

    public override string ToString()   
    {
        var sb = new StringBuilder();
        
        sb.AppendLine($"Code Name: {this.CodeName} State: {this.State}");

        return sb.ToString().TrimEnd();
    }
}