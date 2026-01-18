namespace Classes_Exercise1;

internal class Program
{
    static void Main(string[] args)
    {
        var stopwatch = new Stopwatch();
        stopwatch.Start();

        Thread.Sleep(3000);

        stopwatch.Stop();

        var duration = stopwatch.getDuration();
        Console.WriteLine($"The duration is {duration}");
    }
}
