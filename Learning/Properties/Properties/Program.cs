namespace Properties;

internal class Program
{
    static void Main(string[] args)
    {
        var person = new Person();
        person.Name = "Enock";

        Console.WriteLine(person.Name);
    }
}
