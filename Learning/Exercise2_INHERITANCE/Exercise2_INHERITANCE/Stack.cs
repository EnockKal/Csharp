namespace Exercise2_INHERITANCE;

public class Stack
{
    private readonly List<Object> _object;

    public Stack()
    {
        _object = new List<object>();
    }

    public void Push(object obj)
    {

        if (obj == null)
        {
            throw new InvalidOperationException("Stack cannot be null");
        }
        _object.Add(obj);
    }

    public Object Pop()
    {
        if (_object.Count == 0)
        {
            throw new InvalidOperationException("Stack is empty");
        }
        int lastIndex = _object.Count - 1;

        Object LastObj = _object[lastIndex];
        _object.RemoveAt(lastIndex);

        return LastObj;
    }

    public void Clear()
    {
        _object.Clear();
    }
}
