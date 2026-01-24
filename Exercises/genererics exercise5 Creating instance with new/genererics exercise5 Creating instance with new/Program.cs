namespace genererics_exercise5_Creating_instance_with_new;

public class ObjectFactory<T> where T : new()
{
    public T Create() => new T();
}

public class Person
{

}

public class Car
{
    public Car(string model) // Non empty constructor
    {
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        var factory = new ObjectFactory<Person>();
        Person p = factory.Create();

        Console.WriteLine(p.GetType().Name);

        //var car = new ObjectFactory<Car>(); // doesn't work bcz the constructor of Car isn't empty
    }
}
