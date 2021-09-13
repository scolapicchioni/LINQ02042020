using DataHelper;

namespace ConsoleApp;

public static class ConversionOperators {
    public static void ConvertToArray() {
        /*
         * Generate an array from the following query
         */

        IEnumerable<decimal> prices = DataSource.Buildings.Select(b => b.Price).OrderByDescending(p => p);

        var pricesArray = prices.ToArray();

        Console.WriteLine("First ten prices from highest to lowest:");
        for (int i = 0; i < 10; i++) {
            Console.WriteLine($"{pricesArray[i]:C0}");
        }

    }

    public static void ConvertToList() {
        /*
         * Generate a List<string> from the following query
         */

        IEnumerable<string> categories = DataSource.Buildings.Select(b => b.Category).OrderBy(c => c).Distinct();

        List<string> listOfCategories = categories.ToList();

        listOfCategories.Insert(0, "Please Select a Category");

        foreach (var category in listOfCategories) {
            Console.WriteLine(category);
        }

    }

    public static void ConvertToDictionary() {
        /*
         * Convert the following query into a Dictionary whose key is the name of the player
         */
        var scoreRecords = from p in DataSource.DicePlayers
                           select new { p.Name, BestScore = p.DiceRolls.Max(d => d.FirstDice + d.SecondDice) };

        var scoreRecordsDict = scoreRecords.ToDictionary(sr => sr.Name);

        Console.WriteLine("Daniel Negreanu's score: {0}", scoreRecordsDict["Daniel Negreanu"]);

    }

    public static void ConvertSelectedItems() {
        /*
         * Select only the items of type double
         */

        object[] numbers = { null, 1.0, "two", 3, "four", 5, "six", 7.0 };

        var doubles = numbers.OfType<double>();

        Console.WriteLine("Numbers stored as doubles:");
        foreach (var d in doubles) {
            Console.WriteLine(d);
        }

    }
}
