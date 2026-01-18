namespace Inheritance;

public class Text : PresentationObject
{
    public int FontsIZE { get; set; }
    public String FontName { get; set; }

    public void AddHyperLink(string url)
    {
        Console.WriteLine($"we added a link to {url}");
    }
}
