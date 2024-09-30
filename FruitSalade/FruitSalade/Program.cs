using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        // Create a fruit salad for winter
        FruitSalad winterSalad = FruitSaladFactory.CreateFruitSalad(Season.WINTER);
        winterSalad.Mix();

        // Create a fruit salad for summer
        FruitSalad summerSalad = FruitSaladFactory.CreateFruitSalad(Season.SUMMER);
        summerSalad.Mix();
    }
}
