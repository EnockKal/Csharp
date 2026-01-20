namespace Exercise3_Polymorphism;

public class SqlConnection : DbConnection
{
    public SqlConnection(string connectionString) : base(connectionString)
    {
    }

    public override void Open()
    {
        Console.WriteLine("Opeening SQL Connection...");
    }

    public override void Close()
    {
        Console.WriteLine("Closing SQL Connection...");
    }
}
