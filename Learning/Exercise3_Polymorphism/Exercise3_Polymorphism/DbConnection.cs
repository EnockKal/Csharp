namespace Exercise3_Polymorphism;

public abstract class DbConnection
{
    public string ConnectionString { get; }
    public TimeSpan Timeout { get; }

    public DbConnection(string connectionString, TimeSpan? timeout = null)
    {
        if (connectionString == null || connectionString == "")
            throw new ArgumentNullException("Connection string cannot be null or empty", nameof(connectionString));
        this.ConnectionString = connectionString;
        Timeout = timeout ?? TimeSpan.FromSeconds(30);
    }

    public abstract void Open();

    public abstract void Close();
}