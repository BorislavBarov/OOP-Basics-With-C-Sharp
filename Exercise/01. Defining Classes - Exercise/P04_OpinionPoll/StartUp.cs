using System;

public class StartUp
{
    public static void Main()
    {
        var numberOfPeople = int.Parse(Console.ReadLine());
        var family = new Family();

        for (int i = 0; i < numberOfPeople; i++)
        {
            var personInfo = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var name = personInfo[0];
            var age = int.Parse(personInfo[1]);

            var person = new Person(name, age);
            family.AddMember(person);
        }

        var result = family.GetPeopleWhoseAgeIsMore();
        Console.WriteLine(result);
    }
}
