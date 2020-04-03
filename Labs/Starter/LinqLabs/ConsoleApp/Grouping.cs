using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DataHelper;

namespace ConsoleApp {
    public static class Groupings {
        public static void GroupEmployeeByGender() {
            IEnumerable<Employee> employees = DataSource.Employees;

            /*
             * Create two groups, one for each gender.
             * Select the Gender as a key and put the matching employees in each group
             */

            //IEnumerable<IGrouping<char, Employee>> employeesGroupedByGender = ??

            //foreach (IGrouping<char,Employee> group in employeesGroupedByGender) {
            //    Console.WriteLine("Gender: " + group.Key);
            //    foreach (Employee employee in group) {
            //        Console.WriteLine($"\t{employee.Name}");
            //    }
            //}
        }

        public static void Group_Vendor_With_Bike_Or_Bycicle_In_Its_Name() {
            IEnumerable<Vendor> vendors = DataSource.Vendors;

            /*
             Group the vendors by 
             1) "bike" or "bycicle" in their name
             2) no "bike" or "bycicle" in their name
             */

            //IEnumerable<IGrouping<bool,Vendor>> groupedVendors = ??

            //Console.WriteLine("All VENDORS WITH NAME BIKE OR BICYCLE");

            //foreach (var group in groupedVendors) {
            //    Console.WriteLine($"Bike or bicycle: {group.Key} ({group.Count()})");
            //    foreach (var item in group) {
            //        Console.WriteLine($"\t{item}");
            //    }
            //}

        }


        public static void GroupByProperty() {
            string[] words = DataHelper.DataSource.RoyalTitleWords.ToArray();
            /*
             * Group the words of the royal title by initial.
             * For each row, select a tuple with (FirstLetter, Words)
             * where Words is the set of all the words starting with the initial in the group
             */

            //IEnumerable<IGrouping<char, string>> wordGroups = ??

            //foreach (var g in wordGroups) {
            //    Console.WriteLine("Words that start with the letter '{0}':", g.Key);
            //    foreach (var w in g) {
            //        Console.WriteLine(w);
            //    }
            //}

        }

        public static void GroupByCategory() {
            /*
             * Group the buildings by category.
             * In each resultin row select a tuple with (Category, Buildings)
             * where Buildings is the set of the buildings for the category
             */

            IEnumerable<Building> buildings = DataSource.Buildings;

            //IEnumerable<IGrouping<string, Building>> orderGroups = ??

            //foreach (var orderGroup in orderGroups) {
            //    Console.WriteLine($"Buildings in {orderGroup.Key} category:");
            //    foreach (var building in orderGroup) {
            //        Console.WriteLine($"\t{building}");
            //    }
            //}
        }

        

    }
}
