using DataHelper;

namespace ConsoleApp;

public static class Orderings {

    public static void OrderbySyntax() {
        IEnumerable<string> words = DataSource.RoyalTitleWords;

        /*
         * Sort Alphabetically all the words of the Royal Title of Prince Philip
         */

        //IEnumerable<string> sortedWords = ??


        //Console.WriteLine("The sorted list of words:");
        //foreach (var w in sortedWords) {
        //    Console.WriteLine(w);
        //}

    }

    public static void OrderbyProperty() {
        IEnumerable<string> words = DataSource.RoyalTitleWords;

        /*
         * Sort all the words of the Royal Title of Prince Philip, by word length
         */

        //IEnumerable<string> sortedWords = ??


        //Console.WriteLine("The sorted list of words (by length):");
        //foreach (var w in sortedWords) {
        //    Console.WriteLine(w);
        //}

    }

    public static void OrderByProducts() {
        IEnumerable<Product> products = DataSource.Products;

        /*
         * Sort all the Products by name, alphabetically
         */

        //IEnumerable<Product> sortedProducts = ??


        //foreach (var product in sortedProducts) {
        //    Console.WriteLine(product);
        //}

    }


    public static void OrderByDescendingSyntax() {
        IEnumerable<Building> buildings = DataSource.Buildings;

        /*
         * Sort all the prices of the buildings, from highest to lowest
         */

        //IEnumerable<decimal> sortedPrices = ??


        //Console.WriteLine("The prices from highest to lowest:");
        //foreach (var d in sortedPrices) {
        //    Console.WriteLine(d);
        //}

    }

    public static void OrderBuildingsDescending() {
        IEnumerable<Building> buildings = DataSource.Buildings;

        /*
         * Sort all the buildings by size, from largest to smallest
         */

        //IEnumerable<Building> sortedBuildings = ??


        //foreach (var building in sortedBuildings) {
        //    Console.WriteLine(building);
        //}

    }

    public static void ThenBySyntax() {
        IEnumerable<Building> buildings = DataSource.Buildings;

        /*
         * Sort all the buildings by category and size
         */

        //IEnumerable<Building> sortedBuildings = ??


        //Console.WriteLine("Sorted buildings:");
        //foreach (var b in sortedBuildings) {
        //    Console.WriteLine(b);
        //}

    }

    public static void ThenByDifferentOrdering() {
        IEnumerable<Building> buildings = DataSource.Buildings;

        /*
         * Sort all the buildings by category, then size from largest to smallest
         */

        //IEnumerable<Building> sortedBuildings = ??

        //foreach (var b in sortedBuildings) {
        //    Console.WriteLine(b);
        //}

    }

    public static void SickLeaveHours() {
        IEnumerable<Employee> employees = DataSource.Employees;
        /*
         * For each employee that has less than 21 sick leave hours, display his/her name, gender and number of sick leave hours.
         * Order the list, first by gender and then by name.
         */

        //IEnumerable<Employee> orderedHealthyEmployees = ??


        //foreach (Employee employee in orderedHealthyEmployees) {
        //    Console.WriteLine($"{employee.Name}, {employee.Gender}, { employee.SickLeaveHours}");
        //}
    }

    public static void OrderingReversal() {
        IEnumerable<string> words = DataSource.RoyalTitleWords;
        /*
         * Reverse the order of the list of words
         */

        //IEnumerable<string> reversedWords = ??

        //string royalTitleReversed = string.Concat(reversedWords);

        //Console.WriteLine($"A backwards list of the royal title of Prince Philip: {royalTitleReversed}");
    }
}
