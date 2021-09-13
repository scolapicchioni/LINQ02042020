using DataHelper;

namespace ConsoleApp;

public static class SequenceOperations {

    public static void EqualSequence() {
        IEnumerable<string> categoriesA = DataSource.BuildingCategories.Select(c => c.Category).OrderBy(c => c);
        IEnumerable<string> categoriesB = DataSource.Buildings.Select(c => c.Category).Distinct().OrderBy(c => c);

        //are the categories in the BuildingCategories table equal to the categories in the buildings table?

        //bool match = ??

        //Console.WriteLine($"The sequences match: {match}");

    }

    public static void ConcatProjection() {
        IEnumerable<int> firstRolls = from p in DataSource.DicePlayers
                                      from d in p.DiceRolls
                                      select d.FirstDice;

        IEnumerable<int> secondRolls = from p in DataSource.DicePlayers
                                       from d in p.DiceRolls
                                       select d.SecondDice;

        // select a collection with all the FirstDice followed by all the SecondDice from the dice rolls

        //IEnumerable<int> allRolls = ??

        //Console.WriteLine("All rolls from both dices:");
        //foreach (var n in allRolls) {
        //    Console.WriteLine(n);
        //}
    }

    public static void Zip() {
        IEnumerable<string> englishDays = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        IEnumerable<string> dutchDays = new List<string> { "Maandag", "Disndag", "Woensdag", "Donderdag", "Vrijdag", "Zaterdag", "Zondag" };
        IEnumerable<string> italianDays = new List<string> { "Lunedì", "Martedì", "Mercoledì", "Giovedì", "Venerdì", "Sabato", "Domenica" };

        //Select one list items containing the english day next to its corresponding dutch and italian version
        //IEnumerable<(string English, string Dutch, string Italian)> triple = ??

        //foreach (var (English, Dutch, Italian) in triple) {
        //    Console.WriteLine($"{English} - {Dutch} - {Italian}");
        //}
    }
}
