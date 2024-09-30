using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Create a prototype 2-headed cat
        Cat prototypeCat = new Cat("MadCat", 2);

        // Create an army of cloned cats
        CatArmy catArmy = new CatArmy(prototypeCat);

        // Clone the cat multiple times
        Cat clonedCat1 = catArmy.CloneCat();
        Cat clonedCat2 = catArmy.CloneCat();

        // Display the cloned cats
        clonedCat1.Display();
        clonedCat2.Display();
    }
}
