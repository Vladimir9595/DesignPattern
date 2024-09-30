using System;
using System.Collections.Generic;

public class Kiwi : Fruit
{
    public Kiwi() : base("Kiwi", "Berry", "Brown") { }

    public override void Peel()
    {
        Console.WriteLine("Peeling a kiwi...");
    }

    public override void Cut()
    {
        Console.WriteLine("Cutting the kiwi into rounds.");
    }
}