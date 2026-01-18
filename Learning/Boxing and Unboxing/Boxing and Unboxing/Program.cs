using System.Collections;

namespace Boxing_and_Unboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList();
            list.Add(1);
            list.Add("Enock");
            list.Add(DateTime.Today);


            // Using List is better than using arraylist
            var anotherList = new List<int>();
            anotherList.Add(list.Add(1));
            //anotherList.Add("Enock");   // compilation error bcz of type

        }
    }
}
