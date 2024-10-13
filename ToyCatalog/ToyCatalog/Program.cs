using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        Catalog catalog = new Catalog();

        // Adding toys to the catalog
        catalog.TypeToy(10, 20, "Robot", "Red");
        catalog.TypeToy(30, 40, "Doll", "Blue");
        catalog.TypeToy(50, 60, "Robot", "Red"); // Reuses the "Robot-Red" ToyType

        // Drawing all toys on the canvas
        catalog.Draw();
    }
}
