using DataHelper;

namespace ConsoleApp;

public static class LeftJoin {
    public static void LeftJoinQquery() {
        var buildings = DataSource.Buildings;
        var categories = DataSource.BuildingCategories;

        /*
         * For each Category (regardless if there are buildings for it or not) select
         * Category, Description, Buildings (collection of buildings for the category).
         * If there are no buildings for the category, select an empty collection
         */

        IEnumerable<(string Category, string Description, IEnumerable<Building> Buildings)> buildingsWithCategory =
            from c in categories
            join b in buildings on c.Category equals b.Category into buildings_for_category
            select (c.Category, c.Description, Buildings: buildings_for_category);

        Console.WriteLine($"There are {buildings.Count()} buildings in total.");
        Console.WriteLine($"There are {categories.Count()} categories in total.");
        Console.WriteLine($"There are {buildingsWithCategory.Count()} buildings With Categories in total.");

        foreach (var v in buildingsWithCategory) {
            Console.WriteLine($"{v.Category} ({v.Description})");
            foreach (var p in v.Buildings) {
                Console.WriteLine($"\t{p.Address}");
            }
        }

    }

    public static void LeftJoinQqueryWithDefaultBuilding() {
        var buildings = DataSource.Buildings;
        var categories = DataSource.BuildingCategories;

        /*
         * For each Category (regardless if there are buildings for it or not) select
         * Category, Description, Buildings (collection of buildings for the category).
         * If there are no buildings for the category, select a collection with one Building with Address "NO BUILDING"
         */

        IEnumerable<(string Category, string Description, IEnumerable<Building> Buildings)> buildingsWithCategory =
            from c in categories
            join b in buildings on c.Category equals b.Category into buildings_for_category
            select (c.Category, c.Description, Buildings: buildings_for_category.DefaultIfEmpty(new Building() { Address = "NO BUILDING" }));

        Console.WriteLine($"There are {buildings.Count()} buildings in total.");
        Console.WriteLine($"There are {categories.Count()} categories in total.");
        Console.WriteLine($"There are {buildingsWithCategory.Count()} buildings With Categories in total.");

        foreach (var v in buildingsWithCategory) {
            Console.WriteLine($"{v.Category} ({v.Description})");
            foreach (var p in v.Buildings) {
                Console.WriteLine($"\t{p.Address}");
            }
        }

    }

    public static void GroupJoinQquery() {
        var buildings = DataSource.Buildings;
        var categories = DataSource.BuildingCategories;

        /*
         * For each Category (ONLY if there are buildings for it) select
         * Category, Description, Buildings (collection of buildings for the category).
         */

        IEnumerable<(string Category, string Description, IEnumerable<Building> Buildings)> buildingsWithCategory =
            from c in categories
            join b in buildings on c.Category equals b.Category into buildings_for_category
            where buildings_for_category.Any()
            select (c.Category, c.Description, Buildings: buildings_for_category);

        Console.WriteLine($"There are {buildings.Count()} buildings in total.");
        Console.WriteLine($"There are {categories.Count()} categories in total.");
        Console.WriteLine($"There are {buildingsWithCategory.Count()} buildings With Categories in total.");

        foreach (var v in buildingsWithCategory) {
            Console.WriteLine($"{v.Category} ({v.Description})");
            foreach (var p in v.Buildings) {
                Console.WriteLine($"\t{p.Address}");
            }
        }

    }

    public static void LeftOuterJoin() {
        var buildings = DataSource.Buildings;
        var categories = DataSource.BuildingCategories;

        /*
         * For each Building select
         * Category, Description, Building Address 
         * Select the category even if there are no buildings for it
         */

        IEnumerable<(string Category, string Description, string Address)> buildingsWithCategory =
            from c in categories
            join b in buildings on c.Category equals b.Category into buildings_for_category
            from b in buildings_for_category.DefaultIfEmpty(new Building() { Address = "No Buildings For This Category" })
            select (c.Category, c.Description, b.Address);

        Console.WriteLine($"There are {buildings.Count()} buildings in total.");
        Console.WriteLine($"There are {categories.Count()} categories in total.");
        Console.WriteLine($"There are {buildingsWithCategory.Count()} buildings With Categories in total.");

        foreach (var v in buildingsWithCategory) {
            Console.WriteLine($"{v.Category} ({v.Description}): {v.Address}");
        }

    }

}
