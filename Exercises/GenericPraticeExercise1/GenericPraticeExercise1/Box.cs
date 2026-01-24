namespace GenericPraticeExercise1;

public class Box<T>
{
    private T _value = default!;

    public T SetValue(T value) => _value = value;

    public T GetValue() => _value;
}
