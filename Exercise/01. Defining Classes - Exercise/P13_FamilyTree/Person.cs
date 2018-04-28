using System.Collections.Generic;
using System.Text;

public class Person
{
    private string name;
    private string birthdate;
    public List<Person> parents;
    public List<Person> children;

    public Person()
    {
        this.Name = name;
        this.Birthdate = birthdate;
        this.Parents = new List<Person>();
        this.Children = new List<Person>();
    }

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public string Birthdate
    {
        get { return this.birthdate; }
        set { this.birthdate = value; }
    }

    public List<Person> Parents
    {
        get { return this.parents; }
        set { this.parents = value; }
    }

    public List<Person> Children
    {
        get { return this.children; }
        set { this.children = value; }
    }

    public void AddParent(Person parent)
    {
        this.Parents.Add(parent);
    }

    public void AddChild(Person child)
    {
        this.Children.Add(child);
    }

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.AppendLine($"{this.Name} {this.Birthdate}");
        sb.AppendLine("Parents:");
        this.Parents.ForEach(p => sb.AppendLine($"{p.Name} {p.Birthdate}"));
        sb.AppendLine("Children:");
        this.Children.ForEach(c => sb.AppendLine($"{c.Name} {c.Birthdate}"));

        return sb.ToString().TrimEnd();
    }
}