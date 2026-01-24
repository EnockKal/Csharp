namespace GenericPraticeExercise1;

internal class Program
{
    static void Main(string[] args)
    {
        var box = new Box<int>();
        box.SetValue(42);

        Console.WriteLine(box.GetValue());
    }
}
