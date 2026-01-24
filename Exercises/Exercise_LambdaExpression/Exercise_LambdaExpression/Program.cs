namespace Exercise_LambdaExpression;

// Square a number
public class SquareNumber
{
    public Func<int, int> square = x => x * x;
}

// Combine First and Last name to get full name
public class CombineFirstLastName
{
    public Func<string, string, string> fullName = (first, last) => first + " " + last;
}

// Check if numnber is even or not
public class CheckEvenNumber
{
    public Func<int, bool> number = x => x.;
}


internal class Program
{
    static void Main(string[] args)
    {
        var square = new SquareNumber();
        Console.WriteLine(square.square(5));

        Console.WriteLine();

        var name = new CombineFirstLastName();
        Console.WriteLine(name.fullName("Enock", "kalonji"));

        Console.WriteLine();

        var evenNumber = new CheckEvenNumber();
        var check = evenNumber.number(4);

        if (check)
        {
            Console.WriteLine("Even");
        }
        else
            Console.WriteLine("Odd");
    }
}
