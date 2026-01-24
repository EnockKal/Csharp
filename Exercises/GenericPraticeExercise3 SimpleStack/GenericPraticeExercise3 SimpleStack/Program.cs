namespace GenericPraticeExercise3_SimpleStack;

internal class Program
{
    static void Main(string[] args)
    {
        var stack = new MyStack<int>();
        for (int i = 1; i <= 10; i++)
        {
            stack.Push(i);
        }

        Console.WriteLine(stack.Pop());
    }
}
