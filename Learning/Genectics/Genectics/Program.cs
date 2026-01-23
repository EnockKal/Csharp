
namespace Generics;

internal class Program
{
    static void Main(string[] args)
    {
        var Book = new GeneriList<Book>();
        Book.add(new Book());


        var number = new Nullable<int>();
        Console.WriteLine($"has value? {number.Hasvalue}");
        Console.WriteLine($"value: {number.GetValueOrDefault()}");

    }
}
