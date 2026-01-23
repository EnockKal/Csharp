
namespace Generics;

public class Nullable<T> where T : struct
{
    private object _value;

    public Nullable()
    {
    }

    public Nullable(object value)
    {
        _value = value;
    }

    public bool Hasvalue
    {
        get { return _value != null; }
    }

    public T GetValueOrDefault()
    {
        if (Hasvalue)
            return (T)_value;
        return default(T);
    }
}
