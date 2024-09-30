using System;
using System.Collections.Generic;

// Abstract Fruit class
public abstract class Fruit
{
    public string Name { get; set; }
    public string Type { get; set; }
    public string Color { get; set; }

    protected Fruit(string name, string type, string color)
    {
        Name = name;
        Type = type;
        Color = color;
    }

    public abstract void Peel();
    public abstract void Cut();
}
