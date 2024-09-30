using System;
public class Cat : IPrototype
{
    public string Name { get; set; }
    public int Heads { get; set; }

    public Cat(string name, int heads = 2) 
    {
        Name = name;
        Heads = heads;
    }

    public IPrototype Clone()
    {
        Console.WriteLine($"Cloning the cat: {Name} with {Heads} heads.");
        return (IPrototype)this.MemberwiseClone(); // Shallow copy
    }

    public void Display()
    {
        Console.WriteLine($"Cat: {Name}, Heads: {Heads}");
    }
}
