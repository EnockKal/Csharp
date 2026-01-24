namespace NullableTypes;

internal class Program
{
    static void Main(string[] args)
    {
        Nullable<DateTime> date = null; // using Nullable<>
        //or 
        //DateTime? dateTime = null; // using ?

        Console.WriteLine($"GetValueOrDefault(): {date.GetValueOrDefault()}"); // returned the defauld value for the data type bcz date is null
        Console.WriteLine($"HasValue: {date.HasValue}"); // returned false bcz date has no value 
        Console.WriteLine($"alue: {date.Value}"); // Execption bcz there's no value.

        // The GetValueOrDefault() is prefered bcz it get returns a default value even if the Object is null.


        DateTime? date2 = new DateTime(2014, 1, 1);
        //DateTime date3 = date2; // Compile time error, bcz you can't put a null object into a normal object (Compiler doesn't know how to handle it.
        DateTime? date4 = date2; // work fine.

        //-----------------------------------------------------------------------------------------------------------

        DateTime? datee = null;
        DateTime datee2;

        // instead of this:
        //if (date != null)
        //    date2 = date.GetValueOrDefault();
        //else
        //    date2 = DateTime.Today;

        // we can use a short form:
        datee2 = date ?? DateTime.Today; // this is better.
    }
}
