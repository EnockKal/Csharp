namespace Interfaces_Extensibility;

public class DbMigrartor
{
    private readonly ILogger _logger;

    public DbMigrartor(ILogger logger)
    {
        this._logger = logger;
    }

    public void Migrate()
    {
        _logger.LogInfo($"migration started at {DateTime.Now}");

        //details of mgrating the BD

        _logger.LogInfo($"migration ended at {DateTime.Now}");
    }
}
