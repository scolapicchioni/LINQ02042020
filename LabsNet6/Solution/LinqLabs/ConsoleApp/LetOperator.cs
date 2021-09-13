using DataHelper;

namespace ConsoleApp;

public static class LetOperator {
    public static void MaxEachGroup() {
        /*
         * For each building category, 
         * select a tuple with (Category, MostExpensiveBuildings)
         * with MostExpensiveBuildings being the list of all buildings whose price is equal
         * to the maximum price for the category
         */

        IEnumerable<Building> buildings = DataSource.Buildings;

        IEnumerable<(string Category, IEnumerable<Building> MostExpensiveBuildings)> categories =
            from b in buildings
            group b by b.Category into g
            let maxPrice = g.Max(p => p.Price)
            select (Category: g.Key, MostExpensiveBuildings: g.Where(p => p.Price == maxPrice));

        foreach (var c in categories) {
            Console.WriteLine($"Category: {c.Category}");
            foreach (var p in c.MostExpensiveBuildings) {
                Console.WriteLine($"\t{p}");
            }
        }

    }

    public static void MinEachGroup() {
        IEnumerable<Building> buildings = DataSource.Buildings;

        /*
         *  Find the buildings with the minimum price in each category.
         *  For each row, select a tuple (Category, CheapestBuildings) 
         *  with the category and the corresponding building(s) with the cheapest price
         */

        var categories = from b in buildings
                         group b by b.Category into g
                         let minPrice = g.Min(b => b.Price)
                         select (Category: g.Key, CheapestBuildings: g.Where(b => b.Price == minPrice));

        foreach (var c in categories) {
            Console.WriteLine($"Category: {c.Category}");
            foreach (var b in c.CheapestBuildings) {
                Console.WriteLine($"\tBuilding: {b}");
            }
        }
    }

    public static void Where_Pension() {
        var employees = DataHelper.DataSource.Employees;
        /*
         * Select all employees that reached their pension
         * men: 68 or older
         * women: 65 or older
         * Use the calculateAge function to calculate the age of each employee
         * For each row, return Name, Gender and Age
         */

        IEnumerable<(string Name, char Gender, int Age)> q1 =
            from e in employees
            let Age = calculateAge(e.BirthDate)
            where (e.Gender == 'F' && Age >= 65) || (e.Gender == 'M' && Age >= 68)
            select (e.Name, e.Gender, Age);

        foreach (var item in q1) {
            Console.WriteLine(item);
        }
    }

    public static void Where_SevenEleven2() {
        IEnumerable<DataHelper.DicePlayer> players = DataHelper.DataSource.DicePlayers;

        /*
         * Select only the players that scored either a 7 or an 11.
         * For the DiceRolls, we only want to see the ones where the player scored either a 7 or an 11.
         */

        var q1 = from p in players
                 let rolls = from d in p.DiceRolls
                             where (d.Item1 + d.Item2 == 7) || (d.Item1 + d.Item2 == 11)
                             select d
                 where rolls.Any()
                 select new {
                     p.Name,
                     DiceRolls = rolls
                 };

        foreach (var player in q1) {
            Console.WriteLine(player.Name);
            foreach (var roll in player.DiceRolls) {
                Console.WriteLine($"\t{roll}");
            }
        }
    }

    private static int calculateAge(DateTime dateOfBirth) {
        int age = DateTime.Now.Year - dateOfBirth.Year;
        if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
            age -= 1;

        return age;
    }
}
