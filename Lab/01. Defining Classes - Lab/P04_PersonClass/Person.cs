using System.Collections.Generic;
using System.Linq;

public class Person
{
    private string name;
    private int age;
    private List<BankAccount> accounts;

    public Person(string name, int age)
        : this(name, age, new List<BankAccount>())
    { }

    public Person(string name, int age, List<BankAccount> accounts)
    {
        this.Name = name;
        this.Age = age;
        this.accounts = accounts;
    }

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public int Age
    {
        get { return this.age; }
        set { this.age = value; }
    }

    public decimal GetBalance()
    {
        return this.accounts.Sum(x => x.Balance);
    }
}
