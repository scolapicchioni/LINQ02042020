﻿using DataHelper;
namespace ConsoleApp;

public static class Projections {
    public static void SelectProperty() {
        IEnumerable<Building> buildings = DataSource.Buildings;

        /*
         * Select the sqaremeters of each building
         */

        IEnumerable<int> squareMeters = from b in buildings
                                        select b.SquareMeters;

        Console.WriteLine("Building areas in square meters:");
        foreach (var area in squareMeters) {
            Console.WriteLine(area);
        }
    }

    public static void SelectProperty2() {
        IEnumerable<Employee> employees = DataSource.Employees;
        /*
         * Select the name of each employee
         */

        IEnumerable<string> employeeNames = from e in employees
                                            select e.Name;

        Console.WriteLine("Name of the employees:");
        foreach (string name in employeeNames) {
            Console.WriteLine(name);
        }
    }

    public static void TransformWithSelect() {
        Building[] buildings = DataSource.Buildings.ToArray();

        /*
         * A User selected some building. 
         * We stored the indexes of the selected buildings in an array
         */

        int[] selectedBuildingIndexes = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

        /*
         * Select the buildings chosen by the user
         */

        var selectedBuildings = from n in selectedBuildingIndexes
                                select buildings[n];

        Console.WriteLine("Selected Buildings:");
        foreach (var b in selectedBuildings) {
            Console.WriteLine(b);
        }
    }

    public static void SelectByCaseAnonymous() {
        IEnumerable<string> titles = DataSource.RoyalTitleTitles;

        /*
         * Select all the titles of the Prince Philip.
         * For each row, create a new object with Upper and Lower properties.
         * Store 
         * - in Upper the title in UpperCase format
         * - in Lower the title in LowerCase format
         */

        var upperLowerTitles = from t in titles
                               select new { Upper = t.ToUpper(), Lower = t.ToLower() };

        foreach (var t in upperLowerTitles) {
            Console.WriteLine($"Uppercase: {t.Upper}, Lowercase: {t.Lower}");
        }
    }

    public static void SelectByCaseTuple() {
        IEnumerable<string> titles = DataSource.RoyalTitleTitles;

        /*
         * Select all the titles of the Prince Philip.
         * For each row, create a new tuple with Upper and Lower items.
         * Store 
         * - in Upper the title in UpperCase format
         * - in Lower the title in LowerCase format
         */

        IEnumerable<(string Upper, string Lower)> upperLowerTitles = from t in titles
                                                                     select (Upper: t.ToUpper(), Lower: t.ToLower());

        foreach (var t in upperLowerTitles) {
            Console.WriteLine($"Uppercase: {t.Upper}, Lowercase: {t.Lower}");
        }
    }

    public static void SelectNewAnonymous() {
        IEnumerable<Employee> employees = DataSource.Employees;

        /*
         * Select all the employees
         * For each row, create a new object with the following properties:
         * Name (the name of the employee)
         * Age (the age of the employee calculated invoking the calculateAge function
         */

        var q1 = from e in employees
                 select new { e.Name, Age = calculateAge(e.BirthDate) };

        foreach (var employee in q1) {
            Console.WriteLine($"{employee.Name} - {employee.Age}");
        }
    }

    public static void SelectTuple() {
        IEnumerable<Employee> employees = DataSource.Employees;

        /*
         * Select all the employees
         * For each row, create a tuple with the following items:
         * Name (the name of the employee)
         * Age (the age of the employee calculated invoking the calculateAge function)
         */

        IEnumerable<(string Name, int Age)> q1 = from e in DataSource.Employees
                                                 select (e.Name, Age: calculateAge(e.BirthDate));

        foreach (var employee in q1) {
            Console.WriteLine($"{employee.Name} - {employee.Age}");
        }
    }

    public static void SelectPropertySubset() {
        IEnumerable<Employee> employees = DataSource.Employees;

        /*
         * Select all the employees
         * For each row, create a tuple with the following items:
         * Name (the name of the employee)
         * Gender ("Female" if Gender is 'F', "Male" if Gender is 'M') 
         */

        IEnumerable<(string Name, string Gender)> employeeInfos = from e in employees
                                                                  select (e.Name, Gender: e.Gender == 'F' ? "Female" : "Male");

        Console.WriteLine("Employee Info:");
        foreach (var employeeInfo in employeeInfos) {
            Console.WriteLine($"{employeeInfo.Name} is {employeeInfo.Gender}.");
        }
    }

    public static void SelectWithIndex() {
        IEnumerable<BuildingCategory> categories = DataSource.BuildingCategories;

        /*
         * We want to show the user a list of choices such as
         * 1 - Apartment
         * 2 - House
         * 3 - Garage
         * and so on
         * 
         * Select an enumeration of strings such as the aformentioned ones. Use the Select method with an index overload.
         */

        IEnumerable<string> choices = categories.Select((cat, index) => $"{index + 1} - {cat.Category}");

        Console.WriteLine("Please select a category");
        foreach (var choice in choices) {
            Console.WriteLine(choice);
        }
    }

    public static void LowestScoreOfEachPlayer() {
        var players = DataSource.DicePlayers;

        /*
         * What's the lowest score of each player?
         * Select Name and LowestScore
         * with LowestScore being sum of the two dices where the player scored the lowest
         */

        IEnumerable<(string Name, int LowestScore)> q = from p in players
                                                        select (p.Name, LowestScore: p.DiceRolls.Min(d => d.Item1 + d.Item2));

        foreach (var p in q) {
            Console.WriteLine($"Category: {p.Name}, Lowest score: {p.LowestScore}");
        }

    }

    public static void Single_EmployeesWithManager() {
        var employees = DataSource.Employees;

        /*
         * Select the name of the employee and the name of her manager.
         * Note: the boss has no manager. Select his own name in that case
         */

        var q1 = from e in employees
                 select (
                     Employee: e.Name,
                     Manager: employees.SingleOrDefault(m => m.ID == e.Manager)?.Name ?? e.Name
                 );

        Console.WriteLine("Employee and Manager");
        foreach (var e in q1) {
            Console.WriteLine($"{e.Employee} works for {e.Manager}");
        }
    }


    private static int calculateAge(DateTime dateOfBirth) {
        int age = DateTime.Now.Year - dateOfBirth.Year;
        if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
            age -= 1;

        return age;
    }
}
