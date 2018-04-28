using System.Collections.Generic;
using System.Text;

public class Person
{
    private string name;
    private Company company;
    private List<Pokemon> pokemons;
    private List<Person> parents;
    private List<Person> children;
    private Car car;
    private string birthday;

    public Person(string name)
    {
        this.Name = name;
        this.Company = company;
        this.Pokemons = new List<Pokemon>();
        this.Parents = new List<Person>();
        this.Children = new List<Person>();
        this.Car = car;
        this.Birthday = birthday;
    }

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public Company Company
    {
        get { return this.company; }
        set { this.company = value; }
    }

    public List<Pokemon> Pokemons
    {
        get { return this.pokemons; }
        set { this.pokemons = value; }
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

    public Car Car
    {
        get { return this.car; }
        set { this.car = value; }
    }

    public string Birthday
    {
        get { return this.birthday; }
        set { this.birthday = value; }
    }

    public void AddParent(Person parent)
    {
        this.Parents.Add(parent);
    }

    public void AddChild(Person child)
    {
        this.Children.Add(child);
    }

    public void AddPokemon(Pokemon pokemon)
    {
        this.Pokemons.Add(pokemon);
    }

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.AppendLine(this.Name);
        sb.AppendLine("Company:");

        if (this.Company != null)
        {
            sb.AppendLine($"{this.Company.Name} {this.Company.Department} {this.Company.Salary:f2}");
        }

        sb.AppendLine("Car:");

        if (this.Car != null)
        {
            sb.AppendLine($"{this.Car.Model} {this.Car.Speed}");
        }

        sb.AppendLine("Pokemon:");

        if (this.Pokemons.Count > 0)
        {
            this.Pokemons.ForEach(p => sb.AppendLine($"{p.Name} {p.Type}"));
        }

        sb.AppendLine("Parents:");

        if (this.Parents.Count > 0)
        {
            this.Parents.ForEach(p => sb.AppendLine($"{p.Name} {p.Birthday}"));
        }

        sb.AppendLine("Children:");

        if (this.Children.Count > 0)
        {
            this.Children.ForEach(p => sb.AppendLine($"{p.Name} {p.Birthday}"));
        }

        return sb.ToString().TrimEnd();
    }
}