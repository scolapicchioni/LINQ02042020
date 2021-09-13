using DataHelper;

namespace ConsoleApp;

public static class SetOperations {
    public static void DistinctSyntax() {
        IEnumerable<int?> managerIds = DataSource.Employees.Select(e => e.Manager);

        /*
         * Select a list of the managerIds without repetition
         */

        var uniqueManagerIds = managerIds.Distinct();

        Console.WriteLine("Unique manager Ids:");
        foreach (var mid in uniqueManagerIds) {
            Console.WriteLine(mid);
        }

    }

    public static void DistinctPropertyValues() {
        IEnumerable<Building> buildings = DataSource.Buildings;
        IEnumerable<string> categoryNamesRepeated = buildings.Select(b => b.Category);

        /*
         * Select all the category names without repetitions
         */

        IEnumerable<string> categoryNames = categoryNamesRepeated.Distinct();

        Console.WriteLine("Category names:");
        foreach (var n in categoryNames) {
            Console.WriteLine(n);
        }
    }

    public static void DistinctBy() {
        var productsWithPricesPerVendor = from p in DataSource.Products
                                          join pv in DataSource.ProductVendors
                                          on p.ID equals pv.ProductID
                                          join v in DataSource.Vendors
                                          on pv.VendorID equals v.ID
                                          orderby p.ID, pv.Price
                                          select new { ProductName = p.Name, VendorName = v.Name, pv.Price };
        //productsWithPricesPerVendor is a list of products with the corresponding price offered by each vendor,
        //ordered by product and then by price.
        //it looks like this:
        /*
{ ProductName = LL Crankarm, VendorName = Proseware, Inc., Price = 25,77 }
{ ProductName = LL Crankarm, VendorName = Vision Cycles, Inc., Price = 28,17 }
{ ProductName = ML Crankarm, VendorName = Proseware, Inc., Price = 31,98 }
{ ProductName = ML Crankarm, VendorName = Vision Cycles, Inc., Price = 34,38 }
{ ProductName = HL Crankarm, VendorName = Proseware, Inc., Price = 43,87 }
{ ProductName = HL Crankarm, VendorName = West Junction Cycles, Price = 44,21 }
{ ProductName = HL Crankarm, VendorName = Vision Cycles, Inc., Price = 46,27 }
{ ProductName = Chainring Bolts, VendorName = Bike Satellite Inc., Price = 43,21 }
{ ProductName = Chainring Bolts, VendorName = Beaumont Bikes, Price = 45,21 }
{ ProductName = Chainring Bolts, VendorName = Training Systems, Price = 47,28 }
{ ProductName = Chainring Nut, VendorName = Bike Satellite Inc., Price = 38,56 }
{ ProductName = Chainring Nut, VendorName = Beaumont Bikes, Price = 40,76 }
{ ProductName = Chainring Nut, VendorName = Training Systems, Price = 42,21 }
        ...and so on...

        Select only the products and vendors with the lowest offering, like so

{ ProductName = LL Crankarm, VendorName = Proseware, Inc., Price = 25,77 }
{ ProductName = ML Crankarm, VendorName = Proseware, Inc., Price = 31,98 }
{ ProductName = HL Crankarm, VendorName = Proseware, Inc., Price = 43,87 }
{ ProductName = Chainring Bolts, VendorName = Bike Satellite Inc., Price = 43,21 }
{ ProductName = Chainring Nut, VendorName = Bike Satellite Inc., Price = 38,56 }
        */

        var lowestOfferings = productsWithPricesPerVendor.DistinctBy(p => p.ProductName);

        foreach (var item in lowestOfferings) {
            Console.WriteLine(item);
        }
    }

    public static void UnionSyntax() {
        IEnumerable<Building> buildings = DataSource.Buildings;
        IEnumerable<string> categories = DataSource.BuildingCategories.Select(c => c.Category);
        IEnumerable<string> categoryNamesFromProducts = buildings.Select(b => b.Category);

        /*
         * Select all category names from both the sequences, without repetition
         */

        var uniqueCategories = categories.Union(categoryNamesFromProducts);

        Console.WriteLine("Unique categories from both lists:");
        foreach (var n in uniqueCategories) {
            Console.WriteLine(n);
        }
    }

    public static void UnionBy() {
        (int pId, int vId)[] pIdAnna = { (317, 50), (321, 47), (341, 90), (425, 25) };
        (int pId, int vId)[] pIdJan = { (317, 50), (425, 68), (524, 27) };

        var productsBoughtByAnna = from p in DataSource.Products
                                   join pv in DataSource.ProductVendors
                                   on p.ID equals pv.ProductID
                                   join v in DataSource.Vendors
                                   on pv.VendorID equals v.ID
                                   where pIdAnna.Select(x => x.pId).Contains(p.ID)
                                   && pIdAnna.Select(x => x.vId).Contains(v.ID)
                                   select new { Product = p.Name, pv.Price, Vendor = v.Name };

        var productsBoughtByJan = from p in DataSource.Products
                                  join pv in DataSource.ProductVendors
                                  on p.ID equals pv.ProductID
                                  join v in DataSource.Vendors
                                  on pv.VendorID equals v.ID
                                  where pIdJan.Select(x => x.pId).Contains(p.ID)
                                  && pIdJan.Select(x => x.vId).Contains(v.ID)
                                  select new { Product = p.Name, pv.Price, Vendor = v.Name };

        /* these are the products bought by Anna:
{ Product = LL Crankarm, Price = 28,17, Vendor = Vision Cycles, Inc. }
{ Product = Chainring Nut, Price = 38,56, Vendor = Bike Satellite Inc. }
{ Product = Flat Washer 1, Price = 45,31, Vendor = Reliance Fitness, Inc. }
{ Product = Thin-Jam Lock Nut 2, Price = 43,41, Vendor = Ready Rentals }

        and these are the products bought by Jan:
{ Product = LL Crankarm, Price = 28,17, Vendor = Vision Cycles, Inc. }
{ Product = Thin-Jam Lock Nut 2, Price = 43,41, Vendor = Leaf River Terrain }
{ Product = HL Spindle/Axle, Price = 13,45, Vendor = Capital Road Cycles }
        
         Select all the products bought by either Anna or Jan, no matter the vendor, without repetition

{ Product = LL Crankarm, Price = 28,17, Vendor = Vision Cycles, Inc. }
{ Product = Chainring Nut, Price = 38,56, Vendor = Bike Satellite Inc. }
{ Product = Flat Washer 1, Price = 45,31, Vendor = Reliance Fitness, Inc. }
{ Product = Thin-Jam Lock Nut 2, Price = 43,41, Vendor = Ready Rentals }
{ Product = HL Spindle/Axle, Price = 13,45, Vendor = Capital Road Cycles }
         */

        var productsByAnnaOrJan = productsBoughtByAnna.UnionBy(productsBoughtByJan, p => p.Product);

        foreach (var item in productsByAnnaOrJan) {
            Console.WriteLine(item);
        }
    }


    public static void IntersectSynxtax() {
        IEnumerable<Building> buildings = DataSource.Buildings;
        IEnumerable<string> categories = DataSource.BuildingCategories.Select(c => c.Category);
        IEnumerable<string> categoryNamesFromProducts = buildings.Select(b => b.Category);

        /*
         * Select the categories from both sequences, without repetition 
         */

        var commonCategories = categories.Intersect(categoryNamesFromProducts);

        Console.WriteLine("Common categories shared by both lists:");
        foreach (var n in commonCategories) {
            Console.WriteLine(n);
        }
    }

    public static void IntersectBy() {
        (int pId, int vId)[] pIdAnna = { (317, 50), (321, 47), (341, 90), (425, 25) };
        (int pId, int vId)[] pIdJan = { (317, 50), (425, 68), (524, 27) };

        var productsBoughtByAnna = from p in DataSource.Products
                                   join pv in DataSource.ProductVendors
                                   on p.ID equals pv.ProductID
                                   join v in DataSource.Vendors
                                   on pv.VendorID equals v.ID
                                   where pIdAnna.Select(x => x.pId).Contains(p.ID)
                                   && pIdAnna.Select(x => x.vId).Contains(v.ID)
                                   select new { Product = p.Name, pv.Price, Vendor = v.Name };

        var productsBoughtByJan = from p in DataSource.Products
                                  join pv in DataSource.ProductVendors
                                  on p.ID equals pv.ProductID
                                  join v in DataSource.Vendors
                                  on pv.VendorID equals v.ID
                                  where pIdJan.Select(x => x.pId).Contains(p.ID)
                                  && pIdJan.Select(x => x.vId).Contains(v.ID)
                                  select new { Product = p.Name, pv.Price, Vendor = v.Name };

        /* these are the products bought by Anna:
{ Product = LL Crankarm, Price = 28,17, Vendor = Vision Cycles, Inc. }
{ Product = Chainring Nut, Price = 38,56, Vendor = Bike Satellite Inc. }
{ Product = Flat Washer 1, Price = 45,31, Vendor = Reliance Fitness, Inc. }
{ Product = Thin-Jam Lock Nut 2, Price = 43,41, Vendor = Ready Rentals }

        and these are the products bought by Jane:
{ Product = LL Crankarm, Price = 28,17, Vendor = Vision Cycles, Inc. }
{ Product = Thin-Jam Lock Nut 2, Price = 43,41, Vendor = Leaf River Terrain }
{ Product = HL Spindle/Axle, Price = 13,45, Vendor = Capital Road Cycles }
        
         Select all the products bought both by Anna and Jan, no matter the vendor

{ Product = LL Crankarm, Price = 28,17, Vendor = Vision Cycles, Inc. }
{ Product = Thin-Jam Lock Nut 2, Price = 43,41, Vendor = Ready Rentals }
         */

        var productsByBothAnnaAndJan = productsBoughtByAnna.IntersectBy(productsBoughtByJan.Select(p => p.Product), p => p.Product);

        foreach (var item in productsByBothAnnaAndJan) {
            Console.WriteLine(item);
        }
    }

    public static void DifferenceOfSets() {
        IEnumerable<Building> buildings = DataSource.Buildings;
        IEnumerable<string> categories = DataSource.BuildingCategories.Select(c => c.Category);
        IEnumerable<string> categoryNamesFromProducts = buildings.Select(b => b.Category);

        /*
         * Select all the categories appearing in the Categories table and not in the Buildings table
         */
        var CategoriesOnly = categories.Except(categoryNamesFromProducts);

        /*
         * Select all the categories appearing in the Buildings table and not in the Categories table
         */
        var buildingOnly = categoryNamesFromProducts.Except(categories);

        Console.WriteLine("Categories from Categories table not present in Buildings table:");
        foreach (var n in CategoriesOnly) {
            Console.WriteLine(n);
        }

        Console.WriteLine("Categories from Buildings table not present in Categories table:");
        foreach (var n in buildingOnly) {
            Console.WriteLine(n);
        }
    }

    public static void ExceptBy() {
        (int pId, int vId)[] pIdAnna = { (317, 50), (321, 47), (341, 90), (425, 25) };
        (int pId, int vId)[] pIdJan = { (317, 50), (425, 68), (524, 27) };

        var productsBoughtByAnna = from p in DataSource.Products
                                   join pv in DataSource.ProductVendors
                                   on p.ID equals pv.ProductID
                                   join v in DataSource.Vendors
                                   on pv.VendorID equals v.ID
                                   where pIdAnna.Select(x => x.pId).Contains(p.ID)
                                   && pIdAnna.Select(x => x.vId).Contains(v.ID)
                                   select new { Product = p.Name, pv.Price, Vendor = v.Name };

        var productsBoughtByJan = from p in DataSource.Products
                                  join pv in DataSource.ProductVendors
                                  on p.ID equals pv.ProductID
                                  join v in DataSource.Vendors
                                  on pv.VendorID equals v.ID
                                  where pIdJan.Select(x => x.pId).Contains(p.ID)
                                  && pIdJan.Select(x => x.vId).Contains(v.ID)
                                  select new { Product = p.Name, pv.Price, Vendor = v.Name };

        /* these are the products bought by Anna:
{ Product = LL Crankarm, Price = 28,17, Vendor = Vision Cycles, Inc. }
{ Product = Chainring Nut, Price = 38,56, Vendor = Bike Satellite Inc. }
{ Product = Flat Washer 1, Price = 45,31, Vendor = Reliance Fitness, Inc. }
{ Product = Thin-Jam Lock Nut 2, Price = 43,41, Vendor = Ready Rentals }

        and these are the products bought by Jane:
{ Product = LL Crankarm, Price = 28,17, Vendor = Vision Cycles, Inc. }
{ Product = Thin-Jam Lock Nut 2, Price = 43,41, Vendor = Leaf River Terrain }
{ Product = HL Spindle/Axle, Price = 13,45, Vendor = Capital Road Cycles }
        
         Select all the products bought by Anna but not by Jan, no matter the vendor

{ Product = Chainring Nut, Price = 38,56, Vendor = Bike Satellite Inc. }
{ Product = Flat Washer 1, Price = 45,31, Vendor = Reliance Fitness, Inc. }
         */

        var productsByAnnaButNotJan = productsBoughtByAnna.ExceptBy(productsBoughtByJan.Select(p => p.Product), p => p.Product);

        foreach (var item in productsByAnnaButNotJan) {
            Console.WriteLine(item);
        }
    }
}
