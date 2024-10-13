using System;
using System.Collections.Generic;

public class Toy
{
    public int X { get; set; }
    public int Y { get; set; }
    public ToyType Type { get; set; } // Shared object (intrinsic state)

    public Toy(int x, int y, ToyType type)
    {
        X = x;
        Y = y;
        Type = type;
    }

    // Draw the toy on the canvas
    public void Draw()
    {
        Type.Draw(X, Y);
    }
}
