using DataHelper;

namespace ConsoleApp;

public class Restrictions {
    public static void SelectWithWhere() {
        IEnumerable<Building> buildings = DataSource.Buildings;

        /*
         * Select all Houses with a price less than 100.000
         */

        IEnumerable<Building> cheapHouses =
            from b in buildings
            where b.Category == "House" && b.Price <= 100_000M
            select b;

        Console.WriteLine("Houses with price < 100.000:");
        foreach (var house in cheapHouses) {
            Console.WriteLine(house);
        }
    }

    public static void SickLeaveHours() {
        IEnumerable<Employee> employees = DataSource.Employees;

        // For each employee that has less than 21 sick leave hours, display his/ her name, gender and number of sick leave hours
        IEnumerable<Employee> healthyEmployees = employees.Where(employee => employee.SickLeaveHours < 21);

        foreach (Employee employee in healthyEmployees) {
            Console.WriteLine($"{employee.Name}, {employee.Gender}, { employee.SickLeaveHours}");
        }
    }

    public static void Where_Vendor_With_Bike_Or_Bycicle_In_Name() {
        var vendors = DataHelper.DataSource.Vendors;

        /*
         Select all the vendors with either "bike" or "bycicle" in their name
         */

        //var q1 = vendors.Where(v => v.Name.ToLower().Contains("bike") || v.Name.ToLower().Contains("bicycle"));

        IEnumerable<Vendor> q1 =
            from v in vendors
            where v.Name.ToLower().Contains("bike") || v.Name.ToLower().Contains("bicycle")
            select v;

        Console.WriteLine("All VENDORS WITH NAME BIKE OR BICYCLE");

        foreach (var item in q1) {
            Console.WriteLine(item);
        }

    }

    public static void Where_SevenEleven1() {
        IEnumerable<DataHelper.DicePlayer> players = DataHelper.DataSource.DicePlayers;

        /*
         * Select All the players, no matter what their scores are.
         * But for the DiceRolls, we only want to see the ones where the player scored either a 7 or an 11.
         */

        IEnumerable<(string Name, IEnumerable<(int, int)> DiceRolls)> q1 =
            from p in players
            select (
                    p.Name,
                    DiceRolls: from d in p.DiceRolls
                               where (d.Item1 + d.Item2 == 7) || (d.Item1 + d.Item2 == 11)
                               select d
                );

        foreach (var player in q1) {
            Console.WriteLine(player.Name);
            foreach (var roll in player.DiceRolls) {
                Console.WriteLine($"\t{roll}");
            }
        }
    }
}
