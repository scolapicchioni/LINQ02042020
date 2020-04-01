using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DataHelper;

namespace ConsoleApp {
    public static class GroupingInto {
        public static void MaxGrouped() {
            /*
             * For each building category, find the most expensive price.
             * Select a tuple with (Category, MostExpensivePrice)
             */

            IEnumerable<Building> buildings = DataSource.Buildings;

            IEnumerable<(string Category, decimal MostExpensivePrice)> categories = from b in buildings
                                                                                    group b by b.Category into g
                                                                                    select (Category: g.Key, MostExpensivePrice: g.Max(p => p.Price));

            foreach (var c in categories) {
                Console.WriteLine($"Category: {c.Category} Most expensive price: {c.MostExpensivePrice}");
            }
        }

        public static void AverageGrouped() {
            IEnumerable<Building> buildings = DataSource.Buildings;

            /*
             * For each category, select a tuple (Category, AveragePrice) 
             * containing the name of the category and the average price for the category
             */

            IEnumerable<(string Category, decimal AveragePrice)> categories =
                from b in buildings
                group b by b.Category into g
                select (Category: g.Key, AveragePrice: g.Average(b => b.Price));

            foreach (var c in categories) {
                Console.WriteLine($"Category: {c.Category}, Average price: {c.AveragePrice:C}");
            }

        }

        public static void GroupedCount() {
            IEnumerable<Employee> employees = DataSource.Employees;
            /*
             * How many employees are born in each year?
             * List the Year and the Count
             */

            IEnumerable<(int Year, int Count)> yearCount =
                from e in employees
                group e by e.BirthDate.Year into g
                select (Year: g.Key, Count: g.Count());

            foreach (var e in yearCount) {
                Console.WriteLine($"Year: {e.Year}: Count: {e.Count}");
            }
        }

        public static void SumGrouped() {
            IEnumerable<Employee> employees = DataSource.Employees;

            /*
             * how many sick leave hours per gender?
             */


            IEnumerable<(char Gender, int TotalSickLeaveHours)> totalSickLeaveHoursByGender =
                from e in employees
                group e by e.Gender into employeesByGender
                select (Gender: employeesByGender.Key, TotalSickLeaveHours: employeesByGender.Sum(b => b.SickLeaveHours));

            foreach (var gender in totalSickLeaveHoursByGender) {
                Console.WriteLine($"The total of sick leave hours for {gender.Gender} is {gender.TotalSickLeaveHours}");
            }

        }

        public static void GroupedAnyMatchedElements() {
            IEnumerable<Building> buildings = DataSource.Buildings;

            /*
             * Is there any building of 0 square meters?
             * If so, we would like to know which one they are, grouping them by category.
             * Note: We only want to see the categories and the buildings with 0square maters
             */

            var buildingGroups = from b in buildings
                                 group b by b.Category into g
                                 where g.Any(p => p.SquareMeters == 0)
                                 select (Category: g.Key, Buildings: g.Where(b => b.SquareMeters == 0));

            foreach (var group in buildingGroups) {
                Console.WriteLine(group.Category);
                foreach (var building in group.Buildings) {
                    Console.WriteLine($"\t{building}");
                }
            }
        }

        public static void GroupedAllMatchedElements() {
            IEnumerable<Building> buildings = DataSource.Buildings;

            /*
             * We would like to see only the categories where all the buildings are > 0 square meters
             * We would also like to see the buildings in those categories.
             * Group the result by category.
             * Note: We do not want to see buildings in categories where there are buildings of 0 square meters
             */

            var buildingGroups = from b in buildings
                                 group b by b.Category into g
                                 where g.All(p => p.SquareMeters > 0)
                                 select (Category: g.Key, Buildings: g);

            foreach (var group in buildingGroups) {
                Console.WriteLine(group.Category);
                foreach (var building in group.Buildings) {
                    Console.WriteLine($"\t{building}");
                }
            }

        }
    }
}
