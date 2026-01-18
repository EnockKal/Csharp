namespace Properties;

public class Person
{
    private string _name;
    private int _age;

    public int Age
    {
        get { return _age; }
        set
        {
            if (value > 80 && value < 1)
                throw new ArgumentOutOfRangeException("Can't be less than zero");
            _age = value;
        }
    }

    public string Name
    {
        get { return _name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException(nameof(value));
            }
            this._name = value;
        }
    }
}
