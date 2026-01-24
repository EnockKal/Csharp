namespace LINQ;

internal class Program
{
    /*
     * Filter: Where
     * Transform or project: Select
     * Sort: OrderBy, ThenBy, OrderByDescending
     * Check: Any, All
     * Get one: FirstOrDefault, SingleOrDefault (use Single* only when you expect exactly one)
     * Aggregate: Count, Sum, Average, Min, Max
     * Group: GroupBy
     * Combine: Join, Concat, Union, Intersect, Except
     * Flatten: SelectMany
     * Paging: Skip, Take
     */

    static void Main(string[] args)
    {
        var books = new BookRepository().GetBooks();
        var cheapBooks = books
                            .Where(b => b.Price < 10)
                            .OrderBy(b => b.Title)
                            .Select(b => b.Title);


        foreach (var book in cheapBooks)
        {
            //Console.WriteLine($"{book.Title} {book.Price}");
            Console.WriteLine(book);
        }
    }
}
