using Zoo.Common;

namespace Zoo.Data;

public class ZooData
{
    private Animal[] Animals { get; init; } = new[] {
        new Animal(1, "Lion", true),
        new Animal(2, "Giraffe", false),
        new Animal(3, "Quagga", false),
        new Animal(4, "Tiger", true)
    };

    public Animal[] GetAnimals(bool p) { 
        return Animals.Where(a => a.Predator == p).ToArray(); 
    }

    public Animal[] GetAnimals() => Animals;

    public Animal GetAnimal(int id) => 
        Animals.SingleOrDefault(a => a.Id == id);

}
