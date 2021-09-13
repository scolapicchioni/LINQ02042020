using DataHelper;

namespace ConsoleApp;

public static class SelectManyOperations {
    public static void Where_SevenEleven1() {
        IEnumerable<DicePlayer> players = DataSource.DicePlayers;

        /*
         * Select the name of the players and the dice rolls whose sum is either 7 or 11
         */

        IEnumerable<(DicePlayer Player, (int, int) DiceRoll)> q1 =
            from p in players
            from d in p.DiceRolls
            where (d.Item1 + d.Item2 == 7) || (d.Item1 + d.Item2 == 11)
            select (Player: p, DiceRoll: d);

        foreach (var p in q1) {
            Console.WriteLine($"{p.Player.Name} - {p.DiceRoll}");
        }
    }

    public static void Where_SevenEleven2() {
        IEnumerable<DicePlayer> players = DataSource.DicePlayers;

        /*
         * Select the name of the players and the dice rolls whose sum is either 7 or 11.
         * Group the selection by Player Name
         */

        var q1 = from p in players
                 from d in p.DiceRolls
                 where (d.Item1 + d.Item2 == 7) || (d.Item1 + d.Item2 == 11)
                 group d by p.Name;

        foreach (var group in q1) {
            Console.WriteLine(group.Key);
            foreach (var item in group) {
                Console.WriteLine($"\t{item}");
            }
        }
    }

    public static void SelectFromChildSequence() {
        IEnumerable<DicePlayer> players = DataSource.DicePlayers;

        /*
         * For each DiceRoll, select
         * (Player, DiceRoll)
         */

        IEnumerable<(DicePlayer Player, (int, int) DiceRoll)> playersWithRolls =
            from p in players
            from d in p.DiceRolls
            select (Player: p, DiceRoll: d);

        Console.WriteLine("Player with roll:");
        foreach (var pair in playersWithRolls) {
            Console.WriteLine($"{pair.Player} - {pair.DiceRoll}");
        }
    }


    public static void SelectManyWithWhere() {
        IEnumerable<DicePlayer> players = DataSource.DicePlayers;

        /*
         * For each DiceRoll whose sum is either a 7 or an 11, select
         * (Player, DiceRoll)
         */

        IEnumerable<(DicePlayer Player, (int, int) DiceRoll)> playersWithRolls =
            from p in players
            from d in p.DiceRolls
            where d.Item1 + d.Item2 == 7 || d.Item1 + d.Item2 == 11
            select (Player: p, DiceRoll: d);

        Console.WriteLine("Player with rolls either 7 or 11:");
        foreach (var pair in playersWithRolls) {
            Console.WriteLine($"{pair.Player} - {pair.DiceRoll}");
        }
    }

    public static void SelectMultipleWhereClauses() {
        IEnumerable<DicePlayer> players = DataSource.DicePlayers;

        /*
         * For each Player whose name begins with Da,
         * For each DiceRoll whose sum is either a 7 or an 11, select
         * (Player, DiceRoll)
         */

        IEnumerable<(DicePlayer Player, (int, int) DiceRoll)> playersWithRolls =
            from p in players
            where p.Name.StartsWith("Da")
            from d in p.DiceRolls
            where d.Item1 + d.Item2 == 7 || d.Item1 + d.Item2 == 11
            select (Player: p, DiceRoll: d);

        Console.WriteLine("Player starting with Da with rolls either 7 or 11:");
        foreach (var pair in playersWithRolls) {
            Console.WriteLine($"{pair.Player} - {pair.DiceRoll}");
        }
    }

}
