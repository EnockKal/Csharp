namespace Generics2;

internal class Program
{
    static void Main(string[] args)
    {
        var data1 = new KeyValuePair<string, int>("hello", 123);
        data1.Print();


        Console.WriteLine($"{Utilities.CompareValue(123, 12)}"); //false not the same numner
        Console.WriteLine($"{Utilities.CompareTypes(123, 12)}"); // true. same type
    }
}
