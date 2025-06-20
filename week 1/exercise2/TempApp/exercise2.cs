using System;

// Animal Interface
interface IAnimal
{
    void MakeSound();
}

// Dog class implementing IAnimal
class Dog : IAnimal
{
    public void MakeSound()
    {
        Console.WriteLine("Woof!");
    }
}

// Cat class implementing IAnimal
class Cat : IAnimal
{
    public void MakeSound()
    {
        Console.WriteLine("Meow!");
    }
}

// Factory class
class AnimalFactory
{
    public static IAnimal CreateAnimal(string animalType)
    {
        if (animalType.Equals("dog", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Dog Object created.");
            return new Dog();
        }
        else if (animalType.Equals("cat", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Cat Object created.");
            return new Cat();
        }
        else
        {
            Console.WriteLine("Invalid animal type.");
            return null;
        }
    }
}

// Main class
class Exercise2
{
    static void Main(string[] args)
    {
        // Requesting Dog Obj.
        Console.WriteLine("Requesting Dog:");
        IAnimal a1 = AnimalFactory.CreateAnimal("dog");
        a1?.MakeSound();

        // Requesting Cat Obj.
        Console.WriteLine("Requesting Cat:");
        IAnimal a2 = AnimalFactory.CreateAnimal("cat");
        a2?.MakeSound();

        // Requesting Horse Obj.
        Console.WriteLine("Requesting Horse:");
        IAnimal a3 = AnimalFactory.CreateAnimal("horse");
        a3?.MakeSound(); // Safe call using null-conditional operator
    }
}
