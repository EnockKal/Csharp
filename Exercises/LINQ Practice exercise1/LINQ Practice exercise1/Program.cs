namespace LINQ_Practice_exercise1
{
    /*
     * Using the people, write LINQ for:
     * 1. Get only people from NYC, return just FirstName (list of strings)
     * 2. Sort by Age descending, take the top 2
     * 3. Group by City and return City + Count
     * 4. Check if there is any minor (Age < 18)
     * 5. Return a dictionary: key = City, value = list of people in that city
     */

    internal class Program
    {
        public record Person(string FirstName, string LastName, int Age, string City);

        static void Main(string[] args)
        {
            var people = new List<Person>()
                {
                    new("Enock", "Kalonji", 29, "Bridgeport"),
                    new("Grace", "K", 27, "Bridgeport"),
                    new("Chris", "M", 29, "NYC"),
                    new("Ruth", "S", 17, "NYC"),
                    new("Alex", "J", 32, "Boston")
                };

            // Exercise 1
            var result1 = people.Where(p => p.City == "NYC")
                                .Select(p => p.FirstName)
                                .ToList();

            foreach (var names in result1)
            {
                Console.WriteLine($"{names}");
            }
            Console.WriteLine();

            // Exercise 2
            var result2 = people.OrderByDescending(p => p.Age)
                                .Take(2)
                                .ToList();

            foreach (var Ages in result2)
            {
                Console.WriteLine($"{Ages}");
            }
            Console.WriteLine();

            // Exercise 3
            var result3 = people.GroupBy(p => p.City)
                                .Select(g => new { City = g.Key, Count = g.Count() })
                                .ToList();

            foreach (var cities in result3)
            {
                Console.WriteLine($"{cities}");
            }
            Console.WriteLine();

            // Exercise 4
            var result4 = people.Any(p => p.Age < 18);

            Console.WriteLine(result4);
            Console.WriteLine();

            // Exercise 5
            var result5 = people.GroupBy(p => p.City)
                                .ToDictionary(g => g.Key, g => g.ToList());

            foreach (var dictionary in result1)
            {
                Console.WriteLine($"{dictionary}");
            }
        }
    }
}
