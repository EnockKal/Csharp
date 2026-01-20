namespace Exercise3_Polymorphism;

public class OracleConnection : DbConnection
{
    public OracleConnection(string connectionString) : base(connectionString)
    {
    }

    public override void Open()
    {
        Console.WriteLine("Opeening Oracle Connection...");
    }

    public override void Close()
    {
        Console.WriteLine("Closing Oracle Connection...");
    }
}
