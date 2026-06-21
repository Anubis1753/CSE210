
public class Program
{
    public static void Main()
    {
        List<Animal> myAnimals = new List<Animal> ();
        myAnimals.Add(new Animal("liger"));
        myAnimals.Add(new Dog("Zorro"));
        myAnimals.Add(new Cat("Oscar"));
        myAnimals.Add(new Fox("Swipper"));

        foreach (Animal criter in myAnimals)
        {
            criter.MakeNoise();
        }
    }
}