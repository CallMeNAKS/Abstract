internal class Program
{
    public static void Main()
    {
        var car = new Car();
        var ship = new Ship();
        var plane = new Plane();
     
        car.Go();
        ship.Go();
        plane.Go();
    }
}

public abstract class Vehicle
{
    public abstract void Go();
}

public class Car : Vehicle
{
    public override void Go()
    {
        Console.WriteLine("Car go");
    }
}
public class Ship : Vehicle
{
    public override void Go()
    {
        Console.WriteLine("Ship go");
    }
}
public class Plane : Vehicle
{
    public override void Go()
    {
        Console.WriteLine("Plane go");
    }
}
