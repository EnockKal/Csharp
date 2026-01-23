namespace Generics2;

public class KeyValuePair<TKey, TValue>
{
    public TKey Key;
    public TValue Value;

    public KeyValuePair(TKey key, TValue value)
    {
        Key = key;
        Value = value;
    }

    public void Print()
    {
        Console.WriteLine($"Key; {this.Key}");
        Console.WriteLine($"Value; {this.Value}");
    }
}
