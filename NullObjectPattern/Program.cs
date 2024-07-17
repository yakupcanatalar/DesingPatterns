using NullObjectPattern;

class Program
{
    static void Main(string[] args)
    {
        IAnimal dog = GetAnimal("Dog");
        dog.MakeSound();

        //Olmayan bi animal
        IAnimal cat = GetAnimal("Cat");
        cat.MakeSound();

        // Null kontrol olmadan null referans yerine Null Object kullanımı
        IAnimal animal = GetAnimal("Unknown");
        animal.MakeSound();  // Hiçbir şey yapmaz

    }

    public static IAnimal GetAnimal(string type)
    {
        if (type == "Dog")
        {
            return new Dog();
        }
        else
        {
            return new NullAnimal(); // null yerine NullObjectAnimal döndürüyoruz
        }
    }
}