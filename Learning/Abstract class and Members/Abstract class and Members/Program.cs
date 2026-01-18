namespace Abstract_class_and_Members;

internal class Program
{
    static void Main(string[] args)
    {
        //var shape = new Shape(); //WE Can't create an instance of an abstract class.

        var circle = new Circle();
        circle.Draw();

        var rectangle = new Rectangle();
        rectangle.Draw();
    }
}
