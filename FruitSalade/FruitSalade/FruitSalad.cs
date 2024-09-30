using System;
using System.Collections.Generic;

public class FruitSalad
{
    public string Name { get; set; }
    public List<Fruit> Fruits { get; set; }

    public FruitSalad(string name)
    {
        Name = name;
        Fruits = new List<Fruit>();
    }

    public void AddFruit(Fruit fruit)
    {
        Fruits.Add(fruit);
        Console.WriteLine($"{fruit.Name} added to the fruit salad.");
    }

    public void RemoveFruit(Fruit fruit)
    {
        Fruits.Remove(fruit);
        Console.WriteLine($"{fruit.Name} removed from the fruit salad.");
    }

    public void Mix()
    {
        Console.WriteLine("Mixing the fruit salad...");
    }
}