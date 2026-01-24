namespace Lambda_Expression;

internal class Program
{
    static void Main(string[] args)
    {
        // args => expression

        // () => ...
        // (x, y, z) => ...

        const int factor = 5;

        Func<int, int> multiplier = x => x * factor;
        Console.WriteLine(multiplier(3));

        Console.WriteLine();


        //----------------------------------------------------------------

        Func<int, int> square = x => x * x;
        Console.WriteLine(square(5));

        Console.WriteLine();


        //-----------------------------------------------------------------

        var books = new BookRepository().GetBooks();

        var cheapBooks = books.FindAll(book => book.price < 10);

        foreach (var book in cheapBooks)
        {
            Console.WriteLine(book.Title);
        }
    }
}
