namespace Zoo.Common;

public struct Animal
{
    public string AnimalType { get; init; }
    public bool Predator { get; private set; }

    public Animal(string animalType, bool predator) => 
        (AnimalType, Predator) = (animalType, predator);

   public void Change(bool predator) => Predator = predator;
}