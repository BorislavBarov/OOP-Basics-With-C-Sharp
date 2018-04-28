public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
{
    public SpecialisedSoldier(int id, string firstName, string lastName, double salary, Corps corps)
        : base(id, firstName, lastName, salary)
    {
        this.Corps = corps;
    }

    public Corps Corps { get; }
}