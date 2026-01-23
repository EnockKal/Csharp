namespace Generics2;

public class Utilities
{
    //comparing values
    public static bool CompareValue<T01, T02>(T01 value1, T02 value2) => value1.Equals(value2);

    //Comparing type of data
    public static bool CompareTypes<T01, T02>(T01 Type1, T02 type2) => typeof(T01).Equals(typeof(T02));

}
