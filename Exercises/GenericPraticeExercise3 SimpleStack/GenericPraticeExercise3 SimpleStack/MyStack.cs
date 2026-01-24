namespace GenericPraticeExercise3_SimpleStack;

public class MyStack<T>
{
    private readonly List<T> _item = new();

    public int Count => _item.Count;

    public void Push(T item)
    {
        if (item is null)
        {
            throw new ArgumentNullException(nameof(item), "Cannot be null");
        }
        _item.Add(item);
    }

    public T Pop()
    {
        if (_item.Count == 0)
        {
            throw new InvalidOperationException("Nothing to pop");
        }
        int lastIndex = _item.Count - 1;
        T item = _item[lastIndex];
        _item.RemoveAt(lastIndex);
        return item;
    }
}
