namespace Exercise3_Polymorphism;

public abstract class DbConnection
{
    private string _connectionString { get; }
    private TimeSpan _timeout { get; }

    public DbConnection(string connectionString)
    {
        if (connectionString == null || connectionString == "")
            throw new ArgumentNullException("Connection string cannot be null or empty");
        this._connectionString = connectionString;
        _timeout = TimeSpan.FromSeconds(3);
    }

    public abstract void Open();

    public abstract void Close();
}
