using System;
using System.Collections.Generic;

public class FruitSaladFactory
{
    public static FruitSalad CreateFruitSalad(Season season)
    {
        if (season == Season.WINTER)
        {
            var winterSalad = new SeasonalFruitSalad("Winter Salad", season);
            winterSalad.AddFruit(new Apple());
            winterSalad.AddFruit(new Kiwi());
            return winterSalad;
        }
        else if (season == Season.SUMMER)
        {
            var summerSalad = new SeasonalFruitSalad("Summer Salad", season);
            summerSalad.AddFruit(new Banana());
            summerSalad.AddFruit(new Kiwi());
            return summerSalad;
        }

        return null;
    }
}