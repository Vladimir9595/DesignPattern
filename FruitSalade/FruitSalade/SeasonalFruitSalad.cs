using System;
using System.Collections.Generic;

public class SeasonalFruitSalad : FruitSalad
{
    public Season Season { get; set; }

    public SeasonalFruitSalad(string name, Season season) : base(name)
    {
        Season = season;
    }
}