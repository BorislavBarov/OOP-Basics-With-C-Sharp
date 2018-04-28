public interface ICitizen : IInhabitant, IBirthdate
{
    string Name { get; }

    int Age { get; }
}