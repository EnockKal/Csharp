namespace Constructors_and_inhrintance;

public class Car : Vehicle
{
    // using based just like we use super in java
    public Car(string registration) : base(registration)
    {
        Console.WriteLine("car....");
    }
}
