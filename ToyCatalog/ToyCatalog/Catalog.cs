using System;
using System.Collections.Generic;

public class Catalog
{
    private List<Toy> toys = new List<Toy>();
    private ToyFactory toyFactory = new ToyFactory();

    // Create a new toy and add it to the catalog
    public void TypeToy(int x, int y, string name, string color)
    {
        ToyType toyType = toyFactory.GetToyType(name, color);
        Toy toy = new Toy(x, y, toyType);
        toys.Add(toy);
    }

    // Draw all toys on the canvas
    public void Draw()
    {
        foreach (var toy in toys)
        {
            toy.Draw();
        }
    }
}