namespace Inheritance;

public class PresentationObject
{
    public int Width { get; set; }
    public int Height { get; set; }

    public void copy()
    {
        Console.WriteLine("copied to clipboard");
    }

    public void Duplicate()
    {
        Console.WriteLine("copied to clipboard");
    }
}
