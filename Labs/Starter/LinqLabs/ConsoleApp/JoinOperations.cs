using DataHelper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp {
    public static class JoinOperations {
        
        public static void InnerJoinQuery() {
            var buildings = DataSource.Buildings;
            var categories = DataSource.BuildingCategories;
            
            /*
             * For each building, display the Category Name, the Category Description and the Building Address
             */

            //IEnumerable<(string Address, string Category, string Description)> buildingsWithCategory = ??
            

            //Console.WriteLine($"There are {buildings.Count()} buildings in total.");
            //Console.WriteLine($"There are {categories.Count()} categories in total.");
            //Console.WriteLine($"There are {buildingsWithCategory.Count()} buildings With Categories in total.");

            //foreach (var b in buildingsWithCategory) {
            //    Console.WriteLine($"{b.Address} - {b.Category} - {b.Description}");
            //}
            
        }

        public static void ProductsWithPrices() {
            IEnumerable<Product> products = DataSource.Products;
            IEnumerable<ProductVendor> productVendors = DataSource.ProductVendors;

            /*
             * For each product, display the name of the product and all the prices it is being offered for 
             */

            //IEnumerable<(string ProductName, decimal Price)> productOfferings = ??
            

            //foreach (var productOffering in productOfferings) {
            //    Console.WriteLine("Product: {0}: {1}", productOffering.ProductName, productOffering.Price);
            //}
        }

        public static void ProductVendorOfferings() {
            IEnumerable<Product> products = DataSource.Products;
            IEnumerable<ProductVendor> productVendors = DataSource.ProductVendors;
            IEnumerable<Vendor> vendors = DataSource.Vendors;

            /*
             * For each product, display the name of the product, all the prices it is being offered for and the name of the Vendor. 
             */

            //IEnumerable<(string ProductName, decimal Price, string VendorName)> productVendorOfferings = ??

            //foreach (var productOffering in productVendorOfferings) {
            //    Console.WriteLine("Product: {0}: {1} by {2}", productOffering.ProductName, productOffering.Price, productOffering.VendorName);
            //}
        }

        public static void ProductVendorOfferingsGrouped() {
            IEnumerable<Product> products = DataSource.Products;
            IEnumerable<ProductVendor> productVendors = DataSource.ProductVendors;
            IEnumerable<Vendor> vendors = DataSource.Vendors;

            /*
             * For each product, display the name of the product, all the prices it is being offered for and the name of the Vendor. 
             * Group the results by product and display the offerings in groups like this:

                Product: LL Mountain Rim
                Offering: 22,28 by Comfort Road Bicycles
                Offering: 21,11 by Competition Bike Training Systems

                Product: ML Mountain Rim
                Offering: 26,33 by Comfort Road Bicycles
                Offering: 27,89 by Competition Bike Training Systems

                Product: HL Road Pedal
                Offering: 59,99 by Compete Enterprises, Inc
                ...
              */

            //var productVendorOfferingsGrouped = ??
            
            
            //foreach (var productOfferingGroup in productVendorOfferingsGrouped) {
            //    Console.WriteLine("\nProduct: {0}", productOfferingGroup.Key);
            //    foreach (var productOffering in productOfferingGroup) {
            //        Console.WriteLine("Offering: {0} by {1}", productOffering.Price, productOffering.VendorName);
            //    }
            //}
        }
        
    }
}
