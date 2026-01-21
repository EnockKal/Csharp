namespace Interfaces_Extensibility;

internal class Program
{
    static void Main(string[] args)
    {
        /* we can use both implimentations (change behavior of the program)
        whenever we want without breaking the code*/

        //var dbMigrator = new DbMigrartor(new ConsoleLogger())
        var dbMigrator = new DbMigrartor(new FileLogger("File-path"));
        dbMigrator.Migrate();

    }
}
