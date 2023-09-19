namespace Zoo.Common;

public class Animal
{
    public int Id { get; init; }
    public string AnimalType { get; init; }
    public bool Predator { get; private set; }

    public Animal(int id, string animalType, bool predator) => 
        (Id, AnimalType, Predator) = (id, animalType, predator);

   public void Change(bool predator) => Predator = predator;
}