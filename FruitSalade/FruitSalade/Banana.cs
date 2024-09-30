using System;
using System.Collections.Generic;

public class Banana : Fruit
{
    public Banana() : base("Banana", "Berry", "Yellow") { }

    public override void Peel()
    {
        Console.WriteLine("Peeling a banana...");
    }

    public override void Cut()
    {
        Console.WriteLine("Slicing the banana.");
    }
}