namespace Lambda_Expression;

public class BookRepository
{
    public List<Book> GetBooks()
    {
        return new List<Book>
        {
            new Book() {Title = "Title 1", price = 5},
            new Book() {Title = "Title 2", price = 7},
            new Book() {Title = "Title 3", price = 17}
        };
    }
}
