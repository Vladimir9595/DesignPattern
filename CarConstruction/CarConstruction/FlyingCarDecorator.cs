using System;
public class FlyingCarDecorator : CarDecorator
{
    public FlyingCarDecorator(ICar car) : base(car) { }

    public override void Build()
    {
        base.Build(); // Build the basic car
        AddAirPropulsionSystem();
        AddAirNavigationSystem();
    }

    private void AddAirPropulsionSystem()
    {
        Console.WriteLine("Adding air propulsion system to the car.");
    }

    private void AddAirNavigationSystem()
    {
        Console.WriteLine("Adding air navigation system to the car.");
    }
}