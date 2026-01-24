namespace GenericPraticeExercise2;


// Exercise: Swap two value
internal class Program
{

    static void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        a = temp;
    }

    static void Main(string[] args)
    {
        int a = 1;
        int b = 2;
        Console.WriteLine($"A = {a}");
        Console.WriteLine($"B = {b}");

        Console.WriteLine();

        Swap(ref a, ref b);
        Console.WriteLine($"A = {a}");
        Console.WriteLine($"B = {b}");
    }
}
