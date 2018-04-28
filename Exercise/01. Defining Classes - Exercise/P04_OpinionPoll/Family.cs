using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Family
{
    private List<Person> members;

    public Family()
    {
        this.members = new List<Person>();
    }

    public void AddMember(Person member)
    {
        this.members.Add(member);
    }

    public string GetPeopleWhoseAgeIsMore()
    {
        var sb = new StringBuilder();
        this.members = this.members.Where(m => m.Age > 30).OrderBy(m => m.Name).ToList();

        foreach (var member in members)
        {
            sb.AppendLine($"{member.Name} - {member.Age}");
        }

        return sb.ToString().TrimEnd();
    }
}