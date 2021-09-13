using DataHelper;

namespace ConsoleApp;

public static class Partitions {

    public static void TakeSyntax() {
        IEnumerable<DicePlayer> players = DataSource.DicePlayers;

        IEnumerable<(string Name, int TotalScore)> playersWithScore =
            from p in players
            let TotalScore = p.DiceRolls.Sum(d => d.FirstDice + d.SecondDice)
            orderby TotalScore
            select (p.Name, TotalScore);

        //Select the first three players 
        var first3Players = playersWithScore.Take(3);

        Console.WriteLine("First 3 players:");
        foreach (var p in first3Players) {
            Console.WriteLine($"{p.Name} : {p.TotalScore}");
        }

    }

    public static void NestedTake() {
        IEnumerable<DicePlayer> players = DataSource.DicePlayers;
        IEnumerable<(string Name, int FirstDice, int SecondDice)> playersWithRolls =
            from p in players
            from r in p.DiceRolls
            where r.FirstDice + r.SecondDice == 7 || r.FirstDice + r.FirstDice == 11
            select (p.Name, r.FirstDice, r.SecondDice);

        // Select the first three players

        IEnumerable<(string Name, int FirstDice, int SecondDice)> first3Rolls = playersWithRolls.Take(3);

        Console.WriteLine("First 3 with at least a 7 or an 11:");
        foreach (var player in first3Rolls) {
            Console.WriteLine($"{player.Name}: ({player.FirstDice}, {player.SecondDice})");
        }
    }

    public static void TakeWithRange() {
        IEnumerable<DicePlayer> players = DataSource.DicePlayers;
        IEnumerable<(string Name, int FirstDice, int SecondDice)> playersWithRolls =
            from p in players
            from r in p.DiceRolls
            where r.FirstDice + r.SecondDice == 7 || r.FirstDice + r.FirstDice == 11
            select (p.Name, r.FirstDice, r.SecondDice);

        // Select the first three players

        IEnumerable<(string Name, int FirstDice, int SecondDice)> first3Rolls = playersWithRolls.Take(3);

        Console.WriteLine("First 3 with at least a 7 or an 11:");
        foreach (var player in first3Rolls) {
            Console.WriteLine($"{player.Name}: ({player.FirstDice}, {player.SecondDice})");
        }
    }


    public static void SkipSyntax() {
        IEnumerable<Vendor> vendors = DataSource.Vendors.OrderBy(v => v.Name);

        //Select all but first 20 vendors:

        var allButFirst20Vendors = vendors.Skip(20);

        Console.WriteLine("All but first 20 vendors:");
        foreach (var n in allButFirst20Vendors) {
            Console.WriteLine(n);
        }
    }

    public static void NestedSkip() {
        IEnumerable<DicePlayer> players = DataSource.DicePlayers;

        var diceRolls = from p in players
                        from dr in p.DiceRolls
                        orderby p.Name, dr.FirstDice + dr.SecondDice descending
                        select new { p.Name, DiceRoll = dr };

        //Select all but first 3 dice rolls:

        var allButFirst3DiceRolls = diceRolls.Skip(3);

        Console.WriteLine("All but first 3 dice rolls:");
        foreach (var order in allButFirst3DiceRolls) {
            Console.WriteLine(order);
        }
    }

    public static void TakeWhileSyntax() {
        IEnumerable<Employee> employees = DataSource.Employees;

        //Select the First Employees having Sick Leave Hours Less Than 80

        var firstSickLeaveHoursLessThan80 = employees.TakeWhile(e => e.SickLeaveHours < 80);

        Console.WriteLine("first Sick Leave Hours Less Than 80:");
        foreach (var employee in firstSickLeaveHoursLessThan80) {
            Console.WriteLine($"{employee.Name} - {employee.SickLeaveHours}");
        }
    }

    public static void SkipWhileSyntax() {
        IEnumerable<BuildingCategory> categories = DataSource.BuildingCategories;

        //Select all categories, starting from Storage and following:

        var fromStorageOn = categories.SkipWhile(c => !c.Category.StartsWith("Storage"));

        Console.WriteLine("All elements, beginning with Storage and following:");
        foreach (var c in fromStorageOn) {
            Console.WriteLine(c.Category);
        }

    }

}
