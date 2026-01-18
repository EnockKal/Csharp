namespace Inheritance;

internal class Program
{
    static void Main(string[] args)
    {
        var text = new Text();
        //text inherited everything from presentation class

        text.Width = 100;
        text.copy();
    }
}
