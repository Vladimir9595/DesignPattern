using System;
using System.Collections.Generic;

public class Apple : Fruit
{
    public Apple() : base("Apple", "Pome", "Red") { }

    public override void Peel()
    {
        Console.WriteLine("Peeling an apple...");
    }

    public override void Cut()
    {
        Console.WriteLine("Cutting the apple into slices.");
    }
}