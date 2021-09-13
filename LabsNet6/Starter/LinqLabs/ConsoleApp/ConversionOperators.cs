using DataHelper;

namespace ConsoleApp;

public static class ConversionOperators {
    public static void ConvertToArray() {
        /*
         * Generate an array from the following query
         */

        IEnumerable<decimal> prices = DataSource.Buildings.Select(b => b.Price).OrderByDescending(p => p);

        //decimal[] pricesArray = ??

        //Console.WriteLine("First ten prices from highest to lowest:");
        //for (int i = 0; i < 10; i++) {
        //    Console.WriteLine($"{pricesArray[i]:C0}");
        //}

    }

    public static void ConvertToList() {
        /*
         * Generate a List<string> from the following query
         */

        IEnumerable<string> categories = DataSource.Buildings.Select(b => b.Category).OrderBy(c => c).Distinct();

        //List<string> listOfCategories = ??

        //listOfCategories.Insert(0, "Please Select a Category");

        //foreach (var category in listOfCategories) {
        //    Console.WriteLine(category);
        //}

    }

    public static void ConvertToDictionary() {
        /*
         * Convert the following query into a Dictionary whose key is the name of the player
         */
        IEnumerable<(string Name, int BestScore)> scoreRecords =
            from p in DataSource.DicePlayers
            select (p.Name, BestScore: p.DiceRolls.Max(d => d.FirstDice + d.SecondDice));

        //Dictionary<string, (string Name, int BestScore)> scoreRecordsDict = ??

        //Console.WriteLine("Daniel Negreanu's score: {0}", scoreRecordsDict["Daniel Negreanu"]);
    }

    public static void ConvertSelectedItems() {
        /*
         * Select only the items of type double
         */

        object[] numbers = { null, 1.0, "two", 3, "four", 5, "six", 7.0 };

        //IEnumerable<double> doubles = ??

        //Console.WriteLine("Numbers stored as doubles:");
        //foreach (var d in doubles) {
        //    Console.WriteLine(d);
        //}

    }
}
