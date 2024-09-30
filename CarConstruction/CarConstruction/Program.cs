using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Building a basic car
        ICar basicCar = new BasicCar();

        // Decorating the car to make it fly
        ICar flyingCar = new FlyingCarDecorator(basicCar);
        flyingCar.Build();

        Console.WriteLine();

        // Decorating the car to make it float
        ICar floatingCar = new FloatingCarDecorator(basicCar);
        floatingCar.Build();
    }
}
