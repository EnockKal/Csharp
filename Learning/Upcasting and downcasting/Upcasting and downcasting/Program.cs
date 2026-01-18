namespace Upcasting_and_downcasting;

internal class Program
{
    static void Main(string[] args)
    {
        // Upcasting
        Circle circle = new Circle();
        Shape shape = circle;


        //downcasting
        Circle anotherCiircle = (Circle)shape;
    }
}
