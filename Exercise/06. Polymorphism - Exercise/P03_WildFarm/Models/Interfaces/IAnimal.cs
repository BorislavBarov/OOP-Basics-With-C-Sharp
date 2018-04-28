public interface IAnimal : IEatable
{
    string Name { get; }

    double Weight { get; }

    int FoodEaten { get; }
}