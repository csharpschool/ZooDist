using Zoo.Common;

namespace Zoo.Data;

public class ZooData
{
    private Animal[] Animals { get; init; } = new[] {
        new Animal("Lion", true),
        new Animal("Giraffe", false),
        new Animal("Quagga", false),
        new Animal("Tiger", true)
    };

    public Animal[] GetAnimals(bool p) { 
        return Animals.Where(a => a.Predator == p).ToArray(); }
}