using System;
using System.Collections.Generic;

public class ToyFactory
{
    private Dictionary<string, ToyType> _toyTypes = new Dictionary<string, ToyType>();

    // Get or create a ToyType (shared object) based on name and color
    public ToyType GetToyType(string name, string color)
    {
        string key = $"{name}-{color}";

        if (!_toyTypes.ContainsKey(key))
        {
            _toyTypes[key] = new ToyType(name, color);
            Console.WriteLine($"Creating a new ToyType: {name} with color {color}.");
        }

        return _toyTypes[key];
    }
}