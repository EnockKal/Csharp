namespace Access_Modifiers;

public class Customer
{
    public int id { get; set; }
    public string Name { get; set; }

    public void Promote()
    {
        var rating = CalculateRating();
        if (rating > 0)
        {
            Console.WriteLine("level 1");
        }
        Console.WriteLine("level 2");
    }

    public int CalculateRating()
    {
        return 0;
    }
}
