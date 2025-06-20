using System;

// Singleton Class
class Singleton
{
    // Static instance initialized at the time of class loading
    public static Singleton Instance = new Singleton();

    // Private constructor to prevent external instantiation
    private Singleton()
    {
        Console.WriteLine("Singleton Created.");
    }

    // Public method
    public void HelloWorld()
    {
        Console.WriteLine("Hello World!");
    }
}

// Main Class
class Exercise1
{
    static void Main(string[] args)
    {
        Singleton.Instance.HelloWorld();
    }
}
