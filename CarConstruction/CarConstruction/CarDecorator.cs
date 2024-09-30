using System;
public abstract class CarDecorator : ICar
{
    protected ICar _car;

    public CarDecorator(ICar car)
    {
        _car = car;
    }

    public virtual void Build()
    {
        _car.Build(); // Call the base car's Build method
    }
}