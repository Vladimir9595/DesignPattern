using System;
public class CatArmy
{
    public Cat PrototypeCat { get; set; }

    public CatArmy(Cat prototypeCat)
    {
        PrototypeCat = prototypeCat;
    }

    // Method to clone the prototype cat
    public Cat CloneCat()
    {
        return (Cat)PrototypeCat.Clone();
    }
}
