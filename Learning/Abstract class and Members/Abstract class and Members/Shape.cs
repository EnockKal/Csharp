namespace Abstract_class_and_Members;

public abstract class Shape
{
    public int with { get; set; }
    public int height { get; set; }

    public abstract void Draw();

    public void copy()
    {
        Console.WriteLine("copy shape into clipboard");
    }

    public void Select()
    {
        Console.WriteLine("select the shape");
    }
}
