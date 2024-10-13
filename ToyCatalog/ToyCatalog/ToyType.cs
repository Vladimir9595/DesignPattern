using System;
using System.Collections.Generic;

public class ToyType
{
    public string Name { get; private set; }
    public string Color { get; private set; }

    public ToyType(string name, string color)
    {
        Name = name;
        Color = color;
    }

    // Method to draw the toy on the canvas at position (x, y)
    public void Draw(int x, int y)
    {
        Console.WriteLine($"Drawing {Name} in {Color} at position ({x}, {y}).");
    }
}
