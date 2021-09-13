﻿using DataHelper;

namespace ConsoleApp;

public static class ElementOperations {

    public static void FirstElement() {
        IEnumerable<Building> buildings = DataSource.Buildings.Where(p => p.Price < 439_000M);

        /*
         * Select only the first element from the buildings whose price is less than 439.000
         */

        Building product = buildings.First();

        Console.WriteLine(product);
    }

    public static void FirstMatchingElement() {
        IEnumerable<Building> buildings = DataSource.Buildings;

        /*
         * Select the first building of the "Storage Area" category
         */

        Building building = buildings.First(b => b.Category == "Storage Area");

        Console.WriteLine($"First Storage Area Building: {building}");

    }

    public static void MaybeFirstElement() {
        IEnumerable<Building> buildings = DataSource.Buildings.Where(b => b.Price < 10_000M);

        /*
         * Select the first building whose price is less than 10_000M.
         * Should there be no building matching this criteria, select null instead
         */

        Building? building = buildings.FirstOrDefault();

        Console.WriteLine(building?.ToString() ?? "No building found whose price is < 10.000");
    }

    public static void MaybeFirstMatchingElement() {
        IEnumerable<Building> buildings = DataSource.Buildings;
        /*
         * Select the first building whose price is less than 10_000M.
         * Should there be no building matching this criteria, select null instead
         */

        Building? building = buildings.FirstOrDefault(b => b.Price < 10_000M);

        Console.WriteLine(building?.ToString() ?? "No building found whose price is < 10.000");
    }

    public static void FirstMatchingElementOrNewBuilding() {
        IEnumerable<Building> buildings = DataSource.Buildings;
        /*
         * Select the first building whose price is less than 10_000M.
         * Should there be no building matching this criteria, select a building with 
         * BuildingID = 0, Address = string.Empty, Category = string.Empty, Price = 0, SquareMeters = 0 
         */

        Building building = buildings.FirstOrDefault(b => b.Price < 10_000M, new Building() { BuildingID = 0, Address = string.Empty, Category = string.Empty, Price = 0, SquareMeters = 0 });

        Console.WriteLine(building);
    }

    public static void ElementAtPosition() {
        IEnumerable<string> titles = DataSource.RoyalTitleTitles;
        /*
         * Extract the 6th title of Prince Philip
         */

        string title = titles.ElementAt(5);  // sixth title because sequences is 0-based

        Console.WriteLine($"The 6th title is: {title}");

    }

    public static void ElementAtFromEnd() {
        IEnumerable<string> titles = DataSource.RoyalTitleTitles;
        /*
         * Extract the last title of Prince Philip
         */

        string title = titles.ElementAt(^1);  // last element

        Console.WriteLine($"The last title is: {title}");
    }
}
