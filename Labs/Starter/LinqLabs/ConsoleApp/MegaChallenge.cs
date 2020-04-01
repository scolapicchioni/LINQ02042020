using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DataHelper;

namespace ConsoleApp {
    public static class MegaChallenge {
        public static void OMG() {
            /*
             * Display for each product: 
             * the name of the product, 
             * the price and the name of the vendor of the cheapest offering for that product. 
             * When there is more than one vendor offering the lowest price 
             * show all vendors that offer the lowest price.
             */

            var vendors = DataSource.Vendors;
            var products = DataSource.Products;
            var productVendors = DataSource.ProductVendors;

            Console.WriteLine("*****STEP 1: ALL PRODUCTS, GROUPED BY Product ID**************");
            //IEnumerable<IGrouping<int, ProductVendor>> q1 = ??


            //foreach (var group in q1) {
            //    Console.WriteLine(group.Key);
            //    foreach (var item in group) {
            //        Console.WriteLine(item);
            //    }
            //}


            Console.WriteLine("*****STEP 2: PRODUCT NEXT TO MINIMUM PRICES**************");
            //var q2 = ??


            //foreach (var item in q2) {
            //    Console.WriteLine(item.PID);
            //    foreach (var pv in item.Offers) {
            //        Console.WriteLine($"\t{pv}");
            //    }
            //}


            Console.WriteLine("*****STEP 3: PRODUCT NAME NEXT TO MINIMUM PRICES**************");
            //var q3 = ??


            //foreach (var item in q3) {
            //    Console.WriteLine(item.Product);
            //    foreach (var pv in item.Offers) {
            //        Console.WriteLine($"\t{pv}");
            //    }
            //}

            Console.WriteLine("*****STEP 4: PRODUCT NAME NEXT TO MINIMUM PRICES AND VENDOR NAMES**************");
            //var q4 = ??


            //foreach (var item in q4) {
            //    Console.WriteLine(item.Product);
            //    foreach (var pv in item.VendorsWithPrices) {
            //        Console.WriteLine($"\t{pv}");
            //    }
            //}


            Console.WriteLine("*****STEP 5: FLATTEN IT OUT**************");
            //var q5 = ??

            //foreach (var item in q5) {
            //    Console.WriteLine($"{item.Product} - {item.Vendor} - {item.Price}");
            //}
        }
    }
}
