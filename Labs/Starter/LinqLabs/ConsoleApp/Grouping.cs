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

            //var groupedVendors = vendors.GroupBy(v => v.Name.ToLower().Contains("bike") || v.Name.ToLower().Contains("bicycle"));

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

            //IEnumerable<(char FirstLetter, IGrouping<char, string> Words)> wordGroups = ??

            //foreach (var g in wordGroups) {
            //    Console.WriteLine("Words that start with the letter '{0}':", g.FirstLetter);
            //    foreach (var w in g.Words) {
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

            //IEnumerable<(string Category, IGrouping<string, Building> Buildings)> orderGroups = ??

            //foreach (var orderGroup in orderGroups) {
            //    Console.WriteLine($"Buildings in {orderGroup.Category} category:");
            //    foreach (var building in orderGroup.Buildings) {
            //        Console.WriteLine($"\t{building}");
            //    }
            //}
        }

        public static void NestedGrouBy() {
            /*
             * Group all the employees by year of birth, then by month, then by day, like so
   * Year: 1977
        Month: 1
                Day: 1
                        Employee: Nitin Mirchandani - 01-01-1977
                Day: 8
                        Employee: Shelley Dyck - 08-01-1977
        Month: 3
                Day: 13
                        Employee: Scott Gode - 13-03-1977
                        Employee: Paula Nartker - 13-03-1977
                Day: 27
                        Employee: Dylan Miller - 27-03-1977
        Month: 4
                Day: 12
                        Employee: Sean Chai - 12-04-1977
        Month: 6
                Day: 3
                        Employee: Kevin Brown - 03-06-1977
                Day: 21
                        Employee: Sariya Harnpadoungsataya - 21-06-1977
                Day: 26
                        Employee: Chris Norred - 26-06-1977
        Month: 7
                Day: 7
                        Employee: Kitti Lertpiriyasuwat - 07-07-1977
                Day: 11
                        Employee: Suchitra Mohan - 11-07-1977
        Month: 8
                Day: 15
                        Employee: Eugene Zabokritski - 15-08-1977
                Day: 17
                        Employee: Linda Moschell - 17-08-1977
        Month: 9
                Day: 27
                        Employee: Reuben D'sa - 27-09-1977
        Month: 10
                Day: 7
                        Employee: Frank Lee - 07-10-1977
        Month: 12
                Day: 23
                        Employee: Samantha Smith - 23-12-1977
Year: 1978
        Month: 1
                Day: 22
                        Employee: Sairaj Uddin - 22-01-1978
        Month: 4
                Day: 14
                        Employee: Ramesh Meyyappan - 14-04-1978
                Day: 15
                        Employee: Lionel Penuchot - 15-04-1978
        Month: 6
                Day: 11
                        Employee: Gabe Mares - 11-06-1978
                Day: 17
                        Employee: Gary Yukish - 17-06-1978
        Month: 8
                Day: 7
                        Employee: Denise Smith - 07-08-1978
        Month: 10
                Day: 8
                        Employee: Andrew Hill - 08-10-1978
                Day: 26
                        Employee: Andrew Cencini - 26-10-1978
        Month: 11
                Day: 18
                        Employee: Carol Philips - 18-11-1978
        Month: 12
                Day: 21
                        Employee: Nancy Anderson - 21-12-1978
                Day: 28
                        Employee: Lorraine Nay - 28-12-1978
                
             ...and so on...
             */
            IEnumerable<Employee> employees = DataSource.Employees;

            //var employeesGroups = ??

            //foreach (var yeargroup in employeesGroups) {
            //    Console.WriteLine($"Year: {yeargroup.Year}");
            //    foreach (var monthgroup in yeargroup.Months) {
            //        Console.WriteLine($"\tMonth: {monthgroup.Month}");
            //        foreach (var daygroup in monthgroup.Days) {
            //            Console.WriteLine($"\t\tDay: {daygroup.Day}");
            //            foreach (var employee in daygroup.Employees) {
            //                Console.WriteLine($"\t\t\tEmployee: {employee.Name} - {employee.BirthDate:dd-MM-yyyy}");
            //            }
            //        }
            //    }
            //}

        }

    }
}
