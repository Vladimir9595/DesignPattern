using System;
public class FloatingCarDecorator : CarDecorator
{
    public FloatingCarDecorator(ICar car) : base(car) { }

    public override void Build()
    {
        base.Build(); // Build the basic car
        AddWaterPropulsionSystem();
        AddWaterNavigationSystem();
    }

    private void AddWaterPropulsionSystem()
    {
        Console.WriteLine("Adding water propulsion system to the car.");
    }

    private void AddWaterNavigationSystem()
    {
        Console.WriteLine("Adding water navigation system to the car.");
    }
}