global using System.Collections.Generic;
global using System;
global using System.Linq;

namespace DataHelper;

public static class DataSource {
    static DataSource() {
        GenerateEmployees();
        GenerateProducts();
        GenerateProductVendors();
        GenerateVendors();
        GenerateDiceRolls();
    }
    private static void GenerateDiceRolls() {
        _dicePlayers.Add(new DicePlayer() {
            Name = "Justin Bonomo",
            DiceRolls = new List<(int, int)> {
                    (3,5), (2,6), (1,1), (2,4), (6,6), (2,3), (3,2), (1,4)
                }
        });
        _dicePlayers.Add(new DicePlayer() {
            Name = "Daniel Negreanu",
            DiceRolls = new List<(int, int)> {
                    (6,5), (2,3), (4,4), (6,4), (2,3), (4,5), (2,2), (3,4), (1,3), (6,5), (2,6), (5,5)
                }
        });
        _dicePlayers.Add(new DicePlayer() {
            Name = "Erik Seidel",
            DiceRolls = new List<(int, int)> {
                    (5,3), (1,6), (5,1), (2,4), (4,6), (3,1), (1,2), (1,2), (2,3), (4,5), (1,1)
                }
        });
        _dicePlayers.Add(new DicePlayer() {
            Name = "Fedor Holz",
            DiceRolls = new List<(int, int)> {
                    (1,2), (3,4), (5,6), (5,4), (3,2), (1,2), (3,2), (5,3), (2,2), (6,3), (2,6), (5,5), (2,6), (3,3)
                }
        });
        _dicePlayers.Add(new DicePlayer() {
            Name = "David Peters",
            DiceRolls = new List<(int, int)> {
                    (2,5), (5,6), (1,2), (2,2), (4,4), (2,3), (3,2), (1,5), (5,6), (1,5), (3,6), (2,4), (1,2), (5,5), (6,6), (3,3)
                }
        });
    }

    private static void GenerateVendors() {
        _vendors.Add(new() { ID = 1, Name = "International" });
        _vendors.Add(new() { ID = 2, Name = "Electronic Bike Repair & Supplies" });
        _vendors.Add(new() { ID = 3, Name = "Premier Sport, Inc." });
        _vendors.Add(new() { ID = 4, Name = "Comfort Road Bicycles" });
        _vendors.Add(new() { ID = 5, Name = "Metro Sport Equipment" });
        _vendors.Add(new() { ID = 6, Name = "Green Lake Bike Company" });
        _vendors.Add(new() { ID = 7, Name = "Mountain Works" });
        _vendors.Add(new() { ID = 8, Name = "Continental Pro Cycles" });
        _vendors.Add(new() { ID = 10, Name = "Trey Research" });
        _vendors.Add(new() { ID = 11, Name = "Anderson's Custom Bikes" });
        _vendors.Add(new() { ID = 12, Name = "Compete, Inc." });
        _vendors.Add(new() { ID = 13, Name = "Beaumont Bikes" });
        _vendors.Add(new() { ID = 15, Name = "SUPERSALES INC." });
        _vendors.Add(new() { ID = 17, Name = "Compete Enterprises, Inc" });
        _vendors.Add(new() { ID = 18, Name = "G & K Bicycle Corp." });
        _vendors.Add(new() { ID = 20, Name = "Jeff's Sporting Goods" });
        _vendors.Add(new() { ID = 21, Name = "Business Equipment Center" });
        _vendors.Add(new() { ID = 22, Name = "Victory Bikes" });
        _vendors.Add(new() { ID = 23, Name = "Norstan Bike Hut" });
        _vendors.Add(new() { ID = 24, Name = "First Rate Bicycles" });
        _vendors.Add(new() { ID = 25, Name = "Ready Rentals" });
        _vendors.Add(new() { ID = 26, Name = "First National Sport Co." });
        _vendors.Add(new() { ID = 27, Name = "Capital Road Cycles" });
        _vendors.Add(new() { ID = 28, Name = "Wide World Importers" });
        _vendors.Add(new() { ID = 29, Name = "Integrated Sport Products" });
        _vendors.Add(new() { ID = 30, Name = "Consumer Cycles" });
        _vendors.Add(new() { ID = 31, Name = "Federal Sport" });
        _vendors.Add(new() { ID = 32, Name = "Advanced Bicycles" });
        _vendors.Add(new() { ID = 33, Name = "Signature Cycles" });
        _vendors.Add(new() { ID = 35, Name = "Mitchell Sports" });
        _vendors.Add(new() { ID = 37, Name = "Inner City Bikes" });
        _vendors.Add(new() { ID = 38, Name = "Allenson Cycles" });
        _vendors.Add(new() { ID = 39, Name = "Hill's Bicycle Service" });
        _vendors.Add(new() { ID = 40, Name = "West Junction Cycles" });
        _vendors.Add(new() { ID = 41, Name = "Speed Corporation" });
        _vendors.Add(new() { ID = 43, Name = "Inline Accessories" });
        _vendors.Add(new() { ID = 44, Name = "Competition Bike Training Systems" });
        _vendors.Add(new() { ID = 45, Name = "Chicago City Saddles" });
        _vendors.Add(new() { ID = 46, Name = "Burnett Road Warriors" });
        _vendors.Add(new() { ID = 47, Name = "Bike Satellite Inc." });
        _vendors.Add(new() { ID = 48, Name = "Gardner Touring Cycles" });
        _vendors.Add(new() { ID = 50, Name = "Vision Cycles, Inc." });
        _vendors.Add(new() { ID = 51, Name = "Bergeron Off-Roads" });
        _vendors.Add(new() { ID = 52, Name = "Hybrid Bicycle Center" });
        _vendors.Add(new() { ID = 53, Name = "Jackson Authority" });
        _vendors.Add(new() { ID = 54, Name = "Pro Sport Industries" });
        _vendors.Add(new() { ID = 55, Name = "Sport Fan Co." });
        _vendors.Add(new() { ID = 56, Name = "International Bicycles" });
        _vendors.Add(new() { ID = 57, Name = "Wood Fitness" });
        _vendors.Add(new() { ID = 58, Name = "Midwest Sport, Inc." });
        _vendors.Add(new() { ID = 60, Name = "International Sport Assoc." });
        _vendors.Add(new() { ID = 61, Name = "Lindell" });
        _vendors.Add(new() { ID = 62, Name = "Training Systems" });
        _vendors.Add(new() { ID = 64, Name = "Circuit Cycles" });
        _vendors.Add(new() { ID = 65, Name = "International Trek Center" });
        _vendors.Add(new() { ID = 66, Name = "Lakewood Bicycle" });
        _vendors.Add(new() { ID = 68, Name = "Leaf River Terrain" });
        _vendors.Add(new() { ID = 69, Name = "National Bike Association" });
        _vendors.Add(new() { ID = 70, Name = "Sport Playground" });
        _vendors.Add(new() { ID = 71, Name = "Vista Road Bikes" });
        _vendors.Add(new() { ID = 72, Name = "Varsity Sport Co." });
        _vendors.Add(new() { ID = 73, Name = "Crowley Sport" });
        _vendors.Add(new() { ID = 74, Name = "Australia Bike Retailer" });
        _vendors.Add(new() { ID = 75, Name = "Northern Bike Travel" });
        _vendors.Add(new() { ID = 76, Name = "Cruger Bike Company" });
        _vendors.Add(new() { ID = 77, Name = "Custom Frames, Inc." });
        _vendors.Add(new() { ID = 78, Name = "Aurora Bike Center" });
        _vendors.Add(new() { ID = 80, Name = "Bicycle Specialists" });
        _vendors.Add(new() { ID = 81, Name = "Bloomington Multisport" });
        _vendors.Add(new() { ID = 83, Name = "Litware, Inc." });
        _vendors.Add(new() { ID = 84, Name = "Proseware, Inc." });
        _vendors.Add(new() { ID = 85, Name = "American Bicycles and Wheels" });
        _vendors.Add(new() { ID = 86, Name = "Carlson Specialties" });
        _vendors.Add(new() { ID = 87, Name = "Expert Bike Co" });
        _vendors.Add(new() { ID = 88, Name = "Greenwood Athletic Company" });
        _vendors.Add(new() { ID = 90, Name = "Reliance Fitness, Inc." });
        _vendors.Add(new() { ID = 91, Name = "WestAmerica Bicycle Co." });
        _vendors.Add(new() { ID = 92, Name = "American Bikes" });
        _vendors.Add(new() { ID = 93, Name = "Chicago Rent-All" });
        _vendors.Add(new() { ID = 94, Name = "Superior Bicycles" });
        _vendors.Add(new() { ID = 95, Name = "Team Athletic Co." });
        _vendors.Add(new() { ID = 96, Name = "Hill Bicycle Center" });
        _vendors.Add(new() { ID = 98, Name = "Trikes, Inc." });
        _vendors.Add(new() { ID = 102, Name = "Fitness Association" });
        _vendors.Add(new() { ID = 103, Name = "Morgan Bike Accessories" });
        _vendors.Add(new() { ID = 104, Name = "Professional Athletic Consultants" });
    }

    private static void GenerateProductVendors() {
        _productVendors.Add(new() { ProductID = 1, VendorID = 83, Price = 47.87M });
        _productVendors.Add(new() { ProductID = 2, VendorID = 57, Price = 39.92M });
        _productVendors.Add(new() { ProductID = 4, VendorID = 85, Price = 54.31M });
        _productVendors.Add(new() { ProductID = 317, VendorID = 50, Price = 28.17M });
        _productVendors.Add(new() { ProductID = 317, VendorID = 84, Price = 25.77M });
        _productVendors.Add(new() { ProductID = 318, VendorID = 50, Price = 34.38M });
        _productVendors.Add(new() { ProductID = 318, VendorID = 84, Price = 31.98M });
        _productVendors.Add(new() { ProductID = 319, VendorID = 40, Price = 44.21M });
        _productVendors.Add(new() { ProductID = 319, VendorID = 50, Price = 46.27M });
        _productVendors.Add(new() { ProductID = 319, VendorID = 84, Price = 43.87M });
        _productVendors.Add(new() { ProductID = 320, VendorID = 13, Price = 45.21M });
        _productVendors.Add(new() { ProductID = 320, VendorID = 47, Price = 43.21M });
        _productVendors.Add(new() { ProductID = 320, VendorID = 62, Price = 47.28M });
        _productVendors.Add(new() { ProductID = 321, VendorID = 13, Price = 40.76M });
        _productVendors.Add(new() { ProductID = 321, VendorID = 47, Price = 38.56M });
        _productVendors.Add(new() { ProductID = 321, VendorID = 62, Price = 42.21M });
        _productVendors.Add(new() { ProductID = 322, VendorID = 13, Price = 24.21M });
        _productVendors.Add(new() { ProductID = 322, VendorID = 47, Price = 25.11M });
        _productVendors.Add(new() { ProductID = 322, VendorID = 62, Price = 27.33M });
        _productVendors.Add(new() { ProductID = 323, VendorID = 21, Price = 47.87M });
        _productVendors.Add(new() { ProductID = 325, VendorID = 15, Price = 0.20M });
        _productVendors.Add(new() { ProductID = 326, VendorID = 15, Price = 0.20M });
        _productVendors.Add(new() { ProductID = 332, VendorID = 70, Price = 10.30M });
        _productVendors.Add(new() { ProductID = 341, VendorID = 8, Price = 39.21M });
        _productVendors.Add(new() { ProductID = 341, VendorID = 41, Price = 45.21M });
        _productVendors.Add(new() { ProductID = 341, VendorID = 90, Price = 45.31M });
        _productVendors.Add(new() { ProductID = 342, VendorID = 8, Price = 37.21M });
        _productVendors.Add(new() { ProductID = 342, VendorID = 41, Price = 43.21M });
        _productVendors.Add(new() { ProductID = 342, VendorID = 90, Price = 43.31M });
        _productVendors.Add(new() { ProductID = 343, VendorID = 8, Price = 41.28M });
        _productVendors.Add(new() { ProductID = 343, VendorID = 41, Price = 47.28M });
        _productVendors.Add(new() { ProductID = 343, VendorID = 90, Price = 47.38M });
        _productVendors.Add(new() { ProductID = 344, VendorID = 8, Price = 37.21M });
        _productVendors.Add(new() { ProductID = 344, VendorID = 41, Price = 43.21M });
        _productVendors.Add(new() { ProductID = 344, VendorID = 90, Price = 43.31M });
        _productVendors.Add(new() { ProductID = 345, VendorID = 8, Price = 35.21M });
        _productVendors.Add(new() { ProductID = 345, VendorID = 41, Price = 41.21M });
        _productVendors.Add(new() { ProductID = 345, VendorID = 90, Price = 41.31M });
        _productVendors.Add(new() { ProductID = 346, VendorID = 8, Price = 39.28M });
        _productVendors.Add(new() { ProductID = 346, VendorID = 41, Price = 45.28M });
        _productVendors.Add(new() { ProductID = 346, VendorID = 90, Price = 45.38M });
        _productVendors.Add(new() { ProductID = 347, VendorID = 8, Price = 35.21M });
        _productVendors.Add(new() { ProductID = 347, VendorID = 41, Price = 41.21M });
        _productVendors.Add(new() { ProductID = 347, VendorID = 90, Price = 41.31M });
        _productVendors.Add(new() { ProductID = 348, VendorID = 8, Price = 33.21M });
        _productVendors.Add(new() { ProductID = 348, VendorID = 41, Price = 39.21M });
        _productVendors.Add(new() { ProductID = 348, VendorID = 90, Price = 39.31M });
        _productVendors.Add(new() { ProductID = 349, VendorID = 8, Price = 37.28M });
        _productVendors.Add(new() { ProductID = 349, VendorID = 41, Price = 43.28M });
        _productVendors.Add(new() { ProductID = 349, VendorID = 90, Price = 43.38M });
        _productVendors.Add(new() { ProductID = 351, VendorID = 12, Price = 5.90M });
        _productVendors.Add(new() { ProductID = 351, VendorID = 64, Price = 5.50M });
        _productVendors.Add(new() { ProductID = 352, VendorID = 12, Price = 1.40M });
        _productVendors.Add(new() { ProductID = 352, VendorID = 64, Price = 1.10M });
        _productVendors.Add(new() { ProductID = 355, VendorID = 17, Price = 1.30M });
        _productVendors.Add(new() { ProductID = 356, VendorID = 48, Price = 3.43M });
        _productVendors.Add(new() { ProductID = 356, VendorID = 69, Price = 3.22M });
        _productVendors.Add(new() { ProductID = 357, VendorID = 48, Price = 3.79M });
        _productVendors.Add(new() { ProductID = 357, VendorID = 69, Price = 4.11M });
        _productVendors.Add(new() { ProductID = 358, VendorID = 103, Price = 6.65M });
        _productVendors.Add(new() { ProductID = 359, VendorID = 32, Price = 45.41M });
        _productVendors.Add(new() { ProductID = 359, VendorID = 91, Price = 45.26M });
        _productVendors.Add(new() { ProductID = 360, VendorID = 32, Price = 43.41M });
        _productVendors.Add(new() { ProductID = 360, VendorID = 91, Price = 43.26M });
        _productVendors.Add(new() { ProductID = 361, VendorID = 32, Price = 47.48M });
        _productVendors.Add(new() { ProductID = 361, VendorID = 91, Price = 47.33M });
        _productVendors.Add(new() { ProductID = 362, VendorID = 32, Price = 43.41M });
        _productVendors.Add(new() { ProductID = 362, VendorID = 91, Price = 43.26M });
        _productVendors.Add(new() { ProductID = 363, VendorID = 32, Price = 41.41M });
        _productVendors.Add(new() { ProductID = 363, VendorID = 91, Price = 41.26M });
        _productVendors.Add(new() { ProductID = 364, VendorID = 32, Price = 45.48M });
        _productVendors.Add(new() { ProductID = 364, VendorID = 91, Price = 45.33M });
        _productVendors.Add(new() { ProductID = 365, VendorID = 32, Price = 41.41M });
        _productVendors.Add(new() { ProductID = 365, VendorID = 91, Price = 41.26M });
        _productVendors.Add(new() { ProductID = 366, VendorID = 32, Price = 39.41M });
        _productVendors.Add(new() { ProductID = 366, VendorID = 91, Price = 39.26M });
        _productVendors.Add(new() { ProductID = 367, VendorID = 32, Price = 43.48M });
        _productVendors.Add(new() { ProductID = 367, VendorID = 91, Price = 43.33M });
        _productVendors.Add(new() { ProductID = 368, VendorID = 32, Price = 39.41M });
        _productVendors.Add(new() { ProductID = 368, VendorID = 91, Price = 39.26M });
        _productVendors.Add(new() { ProductID = 369, VendorID = 32, Price = 37.41M });
        _productVendors.Add(new() { ProductID = 369, VendorID = 91, Price = 37.26M });
        _productVendors.Add(new() { ProductID = 370, VendorID = 32, Price = 41.48M });
        _productVendors.Add(new() { ProductID = 370, VendorID = 91, Price = 41.33M });
        _productVendors.Add(new() { ProductID = 371, VendorID = 32, Price = 37.41M });
        _productVendors.Add(new() { ProductID = 371, VendorID = 91, Price = 37.26M });
        _productVendors.Add(new() { ProductID = 372, VendorID = 32, Price = 35.41M });
        _productVendors.Add(new() { ProductID = 372, VendorID = 91, Price = 35.26M });
        _productVendors.Add(new() { ProductID = 373, VendorID = 32, Price = 39.48M });
        _productVendors.Add(new() { ProductID = 373, VendorID = 91, Price = 39.33M });
        _productVendors.Add(new() { ProductID = 374, VendorID = 32, Price = 35.41M });
        _productVendors.Add(new() { ProductID = 374, VendorID = 91, Price = 35.26M });
        _productVendors.Add(new() { ProductID = 375, VendorID = 7, Price = 41.21M });
        _productVendors.Add(new() { ProductID = 375, VendorID = 23, Price = 41.21M });
        _productVendors.Add(new() { ProductID = 375, VendorID = 76, Price = 41.28M });
        _productVendors.Add(new() { ProductID = 376, VendorID = 7, Price = 45.28M });
        _productVendors.Add(new() { ProductID = 376, VendorID = 23, Price = 39.21M });
        _productVendors.Add(new() { ProductID = 376, VendorID = 76, Price = 37.21M });
        _productVendors.Add(new() { ProductID = 377, VendorID = 7, Price = 41.21M });
        _productVendors.Add(new() { ProductID = 377, VendorID = 23, Price = 43.28M });
        _productVendors.Add(new() { ProductID = 377, VendorID = 76, Price = 35.21M });
        _productVendors.Add(new() { ProductID = 378, VendorID = 7, Price = 39.21M });
        _productVendors.Add(new() { ProductID = 378, VendorID = 23, Price = 39.21M });
        _productVendors.Add(new() { ProductID = 378, VendorID = 76, Price = 39.28M });
        _productVendors.Add(new() { ProductID = 379, VendorID = 7, Price = 43.28M });
        _productVendors.Add(new() { ProductID = 379, VendorID = 23, Price = 37.21M });
        _productVendors.Add(new() { ProductID = 379, VendorID = 76, Price = 35.21M });
        _productVendors.Add(new() { ProductID = 380, VendorID = 7, Price = 39.21M });
        _productVendors.Add(new() { ProductID = 380, VendorID = 23, Price = 41.28M });
        _productVendors.Add(new() { ProductID = 380, VendorID = 76, Price = 41.16M });
        _productVendors.Add(new() { ProductID = 381, VendorID = 7, Price = 37.21M });
        _productVendors.Add(new() { ProductID = 381, VendorID = 23, Price = 37.21M });
        _productVendors.Add(new() { ProductID = 381, VendorID = 76, Price = 45.23M });
        _productVendors.Add(new() { ProductID = 382, VendorID = 23, Price = 35.21M });
        _productVendors.Add(new() { ProductID = 382, VendorID = 76, Price = 41.21M });
        _productVendors.Add(new() { ProductID = 383, VendorID = 23, Price = 39.28M });
        _productVendors.Add(new() { ProductID = 383, VendorID = 76, Price = 45.28M });
        _productVendors.Add(new() { ProductID = 384, VendorID = 23, Price = 35.21M });
        _productVendors.Add(new() { ProductID = 384, VendorID = 76, Price = 41.21M });
        _productVendors.Add(new() { ProductID = 385, VendorID = 23, Price = 41.16M });
        _productVendors.Add(new() { ProductID = 385, VendorID = 76, Price = 39.21M });
        _productVendors.Add(new() { ProductID = 386, VendorID = 23, Price = 45.23M });
        _productVendors.Add(new() { ProductID = 386, VendorID = 76, Price = 43.28M });
        _productVendors.Add(new() { ProductID = 387, VendorID = 23, Price = 41.21M });
        _productVendors.Add(new() { ProductID = 387, VendorID = 76, Price = 39.21M });
        _productVendors.Add(new() { ProductID = 388, VendorID = 23, Price = 45.28M });
        _productVendors.Add(new() { ProductID = 388, VendorID = 76, Price = 37.21M });
        _productVendors.Add(new() { ProductID = 389, VendorID = 23, Price = 41.21M });
        _productVendors.Add(new() { ProductID = 389, VendorID = 76, Price = 41.28M });
        _productVendors.Add(new() { ProductID = 390, VendorID = 23, Price = 39.21M });
        _productVendors.Add(new() { ProductID = 390, VendorID = 76, Price = 37.21M });
        _productVendors.Add(new() { ProductID = 391, VendorID = 23, Price = 43.28M });
        _productVendors.Add(new() { ProductID = 391, VendorID = 76, Price = 35.21M });
        _productVendors.Add(new() { ProductID = 392, VendorID = 23, Price = 39.21M });
        _productVendors.Add(new() { ProductID = 392, VendorID = 76, Price = 39.28M });
        _productVendors.Add(new() { ProductID = 393, VendorID = 23, Price = 37.21M });
        _productVendors.Add(new() { ProductID = 393, VendorID = 76, Price = 35.21M });
        _productVendors.Add(new() { ProductID = 394, VendorID = 23, Price = 41.28M });
        _productVendors.Add(new() { ProductID = 394, VendorID = 76, Price = 41.16M });
        _productVendors.Add(new() { ProductID = 395, VendorID = 23, Price = 37.21M });
        _productVendors.Add(new() { ProductID = 395, VendorID = 76, Price = 45.23M });
        _productVendors.Add(new() { ProductID = 396, VendorID = 23, Price = 35.21M });
        _productVendors.Add(new() { ProductID = 396, VendorID = 76, Price = 41.21M });
        _productVendors.Add(new() { ProductID = 397, VendorID = 23, Price = 39.28M });
        _productVendors.Add(new() { ProductID = 397, VendorID = 76, Price = 45.28M });
        _productVendors.Add(new() { ProductID = 402, VendorID = 28, Price = 45.21M });
        _productVendors.Add(new() { ProductID = 403, VendorID = 54, Price = 43.28M });
        _productVendors.Add(new() { ProductID = 403, VendorID = 78, Price = 45.21M });
        _productVendors.Add(new() { ProductID = 403, VendorID = 87, Price = 43.21M });
        _productVendors.Add(new() { ProductID = 404, VendorID = 54, Price = 39.21M });
        _productVendors.Add(new() { ProductID = 404, VendorID = 78, Price = 43.21M });
        _productVendors.Add(new() { ProductID = 404, VendorID = 87, Price = 47.28M });
        _productVendors.Add(new() { ProductID = 405, VendorID = 54, Price = 37.21M });
        _productVendors.Add(new() { ProductID = 405, VendorID = 78, Price = 47.28M });
        _productVendors.Add(new() { ProductID = 405, VendorID = 87, Price = 43.21M });
        _productVendors.Add(new() { ProductID = 406, VendorID = 54, Price = 41.28M });
        _productVendors.Add(new() { ProductID = 406, VendorID = 78, Price = 43.21M });
        _productVendors.Add(new() { ProductID = 406, VendorID = 87, Price = 41.21M });
        _productVendors.Add(new() { ProductID = 407, VendorID = 54, Price = 37.21M });
        _productVendors.Add(new() { ProductID = 407, VendorID = 78, Price = 41.21M });
        _productVendors.Add(new() { ProductID = 407, VendorID = 87, Price = 45.28M });
        _productVendors.Add(new() { ProductID = 408, VendorID = 54, Price = 35.21M });
        _productVendors.Add(new() { ProductID = 408, VendorID = 78, Price = 45.28M });
        _productVendors.Add(new() { ProductID = 408, VendorID = 87, Price = 41.21M });
        _productVendors.Add(new() { ProductID = 409, VendorID = 54, Price = 39.28M });
        _productVendors.Add(new() { ProductID = 409, VendorID = 78, Price = 41.21M });
        _productVendors.Add(new() { ProductID = 409, VendorID = 87, Price = 39.21M });
        _productVendors.Add(new() { ProductID = 410, VendorID = 54, Price = 35.21M });
        _productVendors.Add(new() { ProductID = 410, VendorID = 78, Price = 39.21M });
        _productVendors.Add(new() { ProductID = 411, VendorID = 54, Price = 33.21M });
        _productVendors.Add(new() { ProductID = 411, VendorID = 78, Price = 43.28M });
        _productVendors.Add(new() { ProductID = 412, VendorID = 54, Price = 37.28M });
        _productVendors.Add(new() { ProductID = 412, VendorID = 78, Price = 39.21M });
        _productVendors.Add(new() { ProductID = 413, VendorID = 54, Price = 45.31M });
        _productVendors.Add(new() { ProductID = 413, VendorID = 78, Price = 37.21M });
        _productVendors.Add(new() { ProductID = 414, VendorID = 54, Price = 43.31M });
        _productVendors.Add(new() { ProductID = 414, VendorID = 78, Price = 41.28M });
        _productVendors.Add(new() { ProductID = 415, VendorID = 54, Price = 47.38M });
        _productVendors.Add(new() { ProductID = 415, VendorID = 78, Price = 37.21M });
        _productVendors.Add(new() { ProductID = 416, VendorID = 54, Price = 43.31M });
        _productVendors.Add(new() { ProductID = 416, VendorID = 78, Price = 35.21M });
        _productVendors.Add(new() { ProductID = 417, VendorID = 54, Price = 41.31M });
        _productVendors.Add(new() { ProductID = 417, VendorID = 78, Price = 39.28M });
        _productVendors.Add(new() { ProductID = 418, VendorID = 54, Price = 45.38M });
        _productVendors.Add(new() { ProductID = 418, VendorID = 78, Price = 35.21M });
        _productVendors.Add(new() { ProductID = 419, VendorID = 54, Price = 41.31M });
        _productVendors.Add(new() { ProductID = 419, VendorID = 78, Price = 33.21M });
        _productVendors.Add(new() { ProductID = 420, VendorID = 54, Price = 39.31M });
        _productVendors.Add(new() { ProductID = 420, VendorID = 78, Price = 37.28M });
        _productVendors.Add(new() { ProductID = 421, VendorID = 54, Price = 43.38M });
        _productVendors.Add(new() { ProductID = 421, VendorID = 78, Price = 45.31M });
        _productVendors.Add(new() { ProductID = 422, VendorID = 25, Price = 45.41M });
        _productVendors.Add(new() { ProductID = 422, VendorID = 68, Price = 45.41M });
        _productVendors.Add(new() { ProductID = 422, VendorID = 74, Price = 45.26M });
        _productVendors.Add(new() { ProductID = 423, VendorID = 25, Price = 43.41M });
        _productVendors.Add(new() { ProductID = 423, VendorID = 68, Price = 43.41M });
        _productVendors.Add(new() { ProductID = 423, VendorID = 74, Price = 43.26M });
        _productVendors.Add(new() { ProductID = 424, VendorID = 25, Price = 47.48M });
        _productVendors.Add(new() { ProductID = 424, VendorID = 68, Price = 47.48M });
        _productVendors.Add(new() { ProductID = 424, VendorID = 74, Price = 47.33M });
        _productVendors.Add(new() { ProductID = 425, VendorID = 25, Price = 43.41M });
        _productVendors.Add(new() { ProductID = 425, VendorID = 68, Price = 43.41M });
        _productVendors.Add(new() { ProductID = 425, VendorID = 74, Price = 43.26M });
        _productVendors.Add(new() { ProductID = 426, VendorID = 25, Price = 41.41M });
        _productVendors.Add(new() { ProductID = 426, VendorID = 68, Price = 41.41M });
        _productVendors.Add(new() { ProductID = 426, VendorID = 74, Price = 41.26M });
        _productVendors.Add(new() { ProductID = 427, VendorID = 25, Price = 45.48M });
        _productVendors.Add(new() { ProductID = 427, VendorID = 68, Price = 45.48M });
        _productVendors.Add(new() { ProductID = 427, VendorID = 74, Price = 45.33M });
        _productVendors.Add(new() { ProductID = 428, VendorID = 25, Price = 41.41M });
        _productVendors.Add(new() { ProductID = 428, VendorID = 68, Price = 41.41M });
        _productVendors.Add(new() { ProductID = 428, VendorID = 74, Price = 41.26M });
        _productVendors.Add(new() { ProductID = 429, VendorID = 25, Price = 39.41M });
        _productVendors.Add(new() { ProductID = 429, VendorID = 68, Price = 39.41M });
        _productVendors.Add(new() { ProductID = 429, VendorID = 74, Price = 39.26M });
        _productVendors.Add(new() { ProductID = 430, VendorID = 25, Price = 43.48M });
        _productVendors.Add(new() { ProductID = 430, VendorID = 68, Price = 43.48M });
        _productVendors.Add(new() { ProductID = 430, VendorID = 74, Price = 43.33M });
        _productVendors.Add(new() { ProductID = 431, VendorID = 25, Price = 39.41M });
        _productVendors.Add(new() { ProductID = 431, VendorID = 68, Price = 39.41M });
        _productVendors.Add(new() { ProductID = 431, VendorID = 74, Price = 39.26M });
        _productVendors.Add(new() { ProductID = 432, VendorID = 25, Price = 37.41M });
        _productVendors.Add(new() { ProductID = 432, VendorID = 68, Price = 37.41M });
        _productVendors.Add(new() { ProductID = 432, VendorID = 74, Price = 37.26M });
        _productVendors.Add(new() { ProductID = 433, VendorID = 25, Price = 41.48M });
        _productVendors.Add(new() { ProductID = 433, VendorID = 68, Price = 41.48M });
        _productVendors.Add(new() { ProductID = 433, VendorID = 74, Price = 41.33M });
        _productVendors.Add(new() { ProductID = 434, VendorID = 25, Price = 37.41M });
        _productVendors.Add(new() { ProductID = 434, VendorID = 68, Price = 37.41M });
        _productVendors.Add(new() { ProductID = 434, VendorID = 74, Price = 37.26M });
        _productVendors.Add(new() { ProductID = 435, VendorID = 25, Price = 35.41M });
        _productVendors.Add(new() { ProductID = 435, VendorID = 68, Price = 35.41M });
        _productVendors.Add(new() { ProductID = 435, VendorID = 74, Price = 35.26M });
        _productVendors.Add(new() { ProductID = 436, VendorID = 25, Price = 39.48M });
        _productVendors.Add(new() { ProductID = 436, VendorID = 68, Price = 39.48M });
        _productVendors.Add(new() { ProductID = 436, VendorID = 74, Price = 39.33M });
        _productVendors.Add(new() { ProductID = 437, VendorID = 25, Price = 35.41M });
        _productVendors.Add(new() { ProductID = 437, VendorID = 68, Price = 35.41M });
        _productVendors.Add(new() { ProductID = 437, VendorID = 74, Price = 35.26M });
        _productVendors.Add(new() { ProductID = 438, VendorID = 7, Price = 45.41M });
        _productVendors.Add(new() { ProductID = 438, VendorID = 51, Price = 39.26M });
        _productVendors.Add(new() { ProductID = 439, VendorID = 7, Price = 43.41M });
        _productVendors.Add(new() { ProductID = 439, VendorID = 51, Price = 43.33M });
        _productVendors.Add(new() { ProductID = 440, VendorID = 7, Price = 47.48M });
        _productVendors.Add(new() { ProductID = 440, VendorID = 51, Price = 39.26M });
        _productVendors.Add(new() { ProductID = 441, VendorID = 7, Price = 43.41M });
        _productVendors.Add(new() { ProductID = 441, VendorID = 51, Price = 37.26M });
        _productVendors.Add(new() { ProductID = 442, VendorID = 7, Price = 41.41M });
        _productVendors.Add(new() { ProductID = 442, VendorID = 51, Price = 41.33M });
        _productVendors.Add(new() { ProductID = 443, VendorID = 7, Price = 45.48M });
        _productVendors.Add(new() { ProductID = 443, VendorID = 51, Price = 37.26M });
        _productVendors.Add(new() { ProductID = 444, VendorID = 7, Price = 41.41M });
        _productVendors.Add(new() { ProductID = 444, VendorID = 51, Price = 35.26M });
        _productVendors.Add(new() { ProductID = 445, VendorID = 7, Price = 39.41M });
        _productVendors.Add(new() { ProductID = 445, VendorID = 51, Price = 39.33M });
        _productVendors.Add(new() { ProductID = 446, VendorID = 7, Price = 43.48M });
        _productVendors.Add(new() { ProductID = 446, VendorID = 51, Price = 35.26M });
        _productVendors.Add(new() { ProductID = 447, VendorID = 7, Price = 39.41M });
        _productVendors.Add(new() { ProductID = 447, VendorID = 51, Price = 45.41M });
        _productVendors.Add(new() { ProductID = 448, VendorID = 7, Price = 37.41M });
        _productVendors.Add(new() { ProductID = 448, VendorID = 51, Price = 43.41M });
        _productVendors.Add(new() { ProductID = 449, VendorID = 7, Price = 41.48M });
        _productVendors.Add(new() { ProductID = 449, VendorID = 51, Price = 47.48M });
        _productVendors.Add(new() { ProductID = 450, VendorID = 7, Price = 37.41M });
        _productVendors.Add(new() { ProductID = 450, VendorID = 51, Price = 43.41M });
        _productVendors.Add(new() { ProductID = 451, VendorID = 7, Price = 35.41M });
        _productVendors.Add(new() { ProductID = 451, VendorID = 51, Price = 41.41M });
        _productVendors.Add(new() { ProductID = 452, VendorID = 7, Price = 39.48M });
        _productVendors.Add(new() { ProductID = 452, VendorID = 51, Price = 45.48M });
        _productVendors.Add(new() { ProductID = 453, VendorID = 7, Price = 35.41M });
        _productVendors.Add(new() { ProductID = 453, VendorID = 51, Price = 41.41M });
        _productVendors.Add(new() { ProductID = 454, VendorID = 7, Price = 45.26M });
        _productVendors.Add(new() { ProductID = 454, VendorID = 51, Price = 39.41M });
        _productVendors.Add(new() { ProductID = 455, VendorID = 7, Price = 43.26M });
        _productVendors.Add(new() { ProductID = 455, VendorID = 51, Price = 43.48M });
        _productVendors.Add(new() { ProductID = 456, VendorID = 7, Price = 47.33M });
        _productVendors.Add(new() { ProductID = 456, VendorID = 51, Price = 39.41M });
        _productVendors.Add(new() { ProductID = 457, VendorID = 7, Price = 43.26M });
        _productVendors.Add(new() { ProductID = 457, VendorID = 51, Price = 37.41M });
        _productVendors.Add(new() { ProductID = 458, VendorID = 7, Price = 41.26M });
        _productVendors.Add(new() { ProductID = 458, VendorID = 51, Price = 41.48M });
        _productVendors.Add(new() { ProductID = 459, VendorID = 7, Price = 45.33M });
        _productVendors.Add(new() { ProductID = 459, VendorID = 51, Price = 37.41M });
        _productVendors.Add(new() { ProductID = 460, VendorID = 7, Price = 41.26M });
        _productVendors.Add(new() { ProductID = 460, VendorID = 51, Price = 35.41M });
        _productVendors.Add(new() { ProductID = 461, VendorID = 51, Price = 39.48M });
        _productVendors.Add(new() { ProductID = 462, VendorID = 1, Price = 45.41M });
        _productVendors.Add(new() { ProductID = 463, VendorID = 37, Price = 45.26M });
        _productVendors.Add(new() { ProductID = 464, VendorID = 37, Price = 43.26M });
        _productVendors.Add(new() { ProductID = 465, VendorID = 37, Price = 47.33M });
        _productVendors.Add(new() { ProductID = 466, VendorID = 37, Price = 43.26M });
        _productVendors.Add(new() { ProductID = 467, VendorID = 37, Price = 41.26M });
        _productVendors.Add(new() { ProductID = 468, VendorID = 37, Price = 45.33M });
        _productVendors.Add(new() { ProductID = 469, VendorID = 37, Price = 41.26M });
        _productVendors.Add(new() { ProductID = 470, VendorID = 37, Price = 39.26M });
        _productVendors.Add(new() { ProductID = 471, VendorID = 37, Price = 43.33M });
        _productVendors.Add(new() { ProductID = 472, VendorID = 37, Price = 39.26M });
        _productVendors.Add(new() { ProductID = 473, VendorID = 37, Price = 37.26M });
        _productVendors.Add(new() { ProductID = 474, VendorID = 37, Price = 41.33M });
        _productVendors.Add(new() { ProductID = 475, VendorID = 37, Price = 37.26M });
        _productVendors.Add(new() { ProductID = 476, VendorID = 77, Price = 15.13M });
        _productVendors.Add(new() { ProductID = 477, VendorID = 77, Price = 11.11M });
        _productVendors.Add(new() { ProductID = 478, VendorID = 77, Price = 10.56M });
        _productVendors.Add(new() { ProductID = 479, VendorID = 77, Price = 15.13M });
        _productVendors.Add(new() { ProductID = 480, VendorID = 77, Price = 11.11M });
        _productVendors.Add(new() { ProductID = 481, VendorID = 77, Price = 10.56M });
        _productVendors.Add(new() { ProductID = 482, VendorID = 77, Price = 8.34M });
        _productVendors.Add(new() { ProductID = 483, VendorID = 77, Price = 9.23M });
        _productVendors.Add(new() { ProductID = 484, VendorID = 77, Price = 6.55M });
        _productVendors.Add(new() { ProductID = 485, VendorID = 77, Price = 7.43M });
        _productVendors.Add(new() { ProductID = 486, VendorID = 77, Price = 8.34M });
        _productVendors.Add(new() { ProductID = 487, VendorID = 77, Price = 5.53M });
        _productVendors.Add(new() { ProductID = 488, VendorID = 77, Price = 8.44M });
        _productVendors.Add(new() { ProductID = 489, VendorID = 77, Price = 9.97M });
        _productVendors.Add(new() { ProductID = 490, VendorID = 61, Price = 12.11M });
        _productVendors.Add(new() { ProductID = 490, VendorID = 75, Price = 11.77M });
        _productVendors.Add(new() { ProductID = 491, VendorID = 30, Price = 19.03M });
        _productVendors.Add(new() { ProductID = 491, VendorID = 61, Price = 18.99M });
        _productVendors.Add(new() { ProductID = 492, VendorID = 10, Price = 48.33M });
        _productVendors.Add(new() { ProductID = 492, VendorID = 86, Price = 47.87M });
        _productVendors.Add(new() { ProductID = 493, VendorID = 10, Price = 55.49M });
        _productVendors.Add(new() { ProductID = 493, VendorID = 86, Price = 54.43M });
        _productVendors.Add(new() { ProductID = 494, VendorID = 10, Price = 48.33M });
        _productVendors.Add(new() { ProductID = 494, VendorID = 86, Price = 50.67M });
        _productVendors.Add(new() { ProductID = 495, VendorID = 10, Price = 59.93M });
        _productVendors.Add(new() { ProductID = 495, VendorID = 86, Price = 60.66M });
        _productVendors.Add(new() { ProductID = 496, VendorID = 10, Price = 47.29M });
        _productVendors.Add(new() { ProductID = 496, VendorID = 86, Price = 46.58M });
        _productVendors.Add(new() { ProductID = 497, VendorID = 46, Price = 32.56M });
        _productVendors.Add(new() { ProductID = 504, VendorID = 81, Price = 46.44M });
        _productVendors.Add(new() { ProductID = 505, VendorID = 58, Price = 42.11M });
        _productVendors.Add(new() { ProductID = 506, VendorID = 93, Price = 8.76M });
        _productVendors.Add(new() { ProductID = 507, VendorID = 4, Price = 22.28M });
        _productVendors.Add(new() { ProductID = 507, VendorID = 44, Price = 21.11M });
        _productVendors.Add(new() { ProductID = 508, VendorID = 4, Price = 26.33M });
        _productVendors.Add(new() { ProductID = 508, VendorID = 44, Price = 27.89M });
        _productVendors.Add(new() { ProductID = 509, VendorID = 53, Price = 34.55M });
        _productVendors.Add(new() { ProductID = 510, VendorID = 2, Price = 21.98M });
        _productVendors.Add(new() { ProductID = 510, VendorID = 56, Price = 22.29M });
        _productVendors.Add(new() { ProductID = 511, VendorID = 2, Price = 27.88M });
        _productVendors.Add(new() { ProductID = 511, VendorID = 56, Price = 26.54M });
        _productVendors.Add(new() { ProductID = 512, VendorID = 2, Price = 33.31M });
        _productVendors.Add(new() { ProductID = 512, VendorID = 92, Price = 35.32M });
        _productVendors.Add(new() { ProductID = 513, VendorID = 3, Price = 37.33M });
        _productVendors.Add(new() { ProductID = 513, VendorID = 11, Price = 25.33M });
        _productVendors.Add(new() { ProductID = 523, VendorID = 27, Price = 10.22M });
        _productVendors.Add(new() { ProductID = 523, VendorID = 66, Price = 9.89M });
        _productVendors.Add(new() { ProductID = 524, VendorID = 27, Price = 13.45M });
        _productVendors.Add(new() { ProductID = 524, VendorID = 96, Price = 12.35M });
        _productVendors.Add(new() { ProductID = 525, VendorID = 31, Price = 2.21M });
        _productVendors.Add(new() { ProductID = 526, VendorID = 26, Price = 3.47M });
        _productVendors.Add(new() { ProductID = 527, VendorID = 60, Price = 6.43M });
        _productVendors.Add(new() { ProductID = 528, VendorID = 5, Price = 36.34M });
        _productVendors.Add(new() { ProductID = 530, VendorID = 38, Price = 15.32M });
        _productVendors.Add(new() { ProductID = 535, VendorID = 17, Price = 3.32M });
        _productVendors.Add(new() { ProductID = 679, VendorID = 12, Price = 5.90M });
        _productVendors.Add(new() { ProductID = 679, VendorID = 64, Price = 5.50M });
        _productVendors.Add(new() { ProductID = 707, VendorID = 18, Price = 13.25M });
        _productVendors.Add(new() { ProductID = 708, VendorID = 18, Price = 13.25M });
        _productVendors.Add(new() { ProductID = 709, VendorID = 20, Price = 3.10M });
        _productVendors.Add(new() { ProductID = 710, VendorID = 20, Price = 3.12M });
        _productVendors.Add(new() { ProductID = 711, VendorID = 18, Price = 13.88M });
        _productVendors.Add(new() { ProductID = 712, VendorID = 29, Price = 6.55M });
        _productVendors.Add(new() { ProductID = 713, VendorID = 29, Price = 37.45M });
        _productVendors.Add(new() { ProductID = 714, VendorID = 29, Price = 37.80M });
        _productVendors.Add(new() { ProductID = 715, VendorID = 29, Price = 37.80M });
        _productVendors.Add(new() { ProductID = 716, VendorID = 29, Price = 38.05M });
        _productVendors.Add(new() { ProductID = 841, VendorID = 29, Price = 26.75M });
        _productVendors.Add(new() { ProductID = 842, VendorID = 65, Price = 54.20M });
        _productVendors.Add(new() { ProductID = 843, VendorID = 65, Price = 8.50M });
        _productVendors.Add(new() { ProductID = 844, VendorID = 65, Price = 8.50M });
        _productVendors.Add(new() { ProductID = 845, VendorID = 65, Price = 10.75M });
        _productVendors.Add(new() { ProductID = 846, VendorID = 65, Price = 4.50M });
        _productVendors.Add(new() { ProductID = 847, VendorID = 65, Price = 14.50M });
        _productVendors.Add(new() { ProductID = 848, VendorID = 65, Price = 15.75M });
        _productVendors.Add(new() { ProductID = 849, VendorID = 102, Price = 24.75M });
        _productVendors.Add(new() { ProductID = 850, VendorID = 102, Price = 24.75M });
        _productVendors.Add(new() { ProductID = 851, VendorID = 102, Price = 24.75M });
        _productVendors.Add(new() { ProductID = 852, VendorID = 102, Price = 32.35M });
        _productVendors.Add(new() { ProductID = 853, VendorID = 102, Price = 32.35M });
        _productVendors.Add(new() { ProductID = 854, VendorID = 102, Price = 32.35M });
        _productVendors.Add(new() { ProductID = 855, VendorID = 102, Price = 38.50M });
        _productVendors.Add(new() { ProductID = 856, VendorID = 102, Price = 37.50M });
        _productVendors.Add(new() { ProductID = 857, VendorID = 102, Price = 37.50M });
        _productVendors.Add(new() { ProductID = 858, VendorID = 95, Price = 8.75M });
        _productVendors.Add(new() { ProductID = 859, VendorID = 95, Price = 8.75M });
        _productVendors.Add(new() { ProductID = 860, VendorID = 95, Price = 8.75M });
        _productVendors.Add(new() { ProductID = 861, VendorID = 95, Price = 15.50M });
        _productVendors.Add(new() { ProductID = 862, VendorID = 95, Price = 15.50M });
        _productVendors.Add(new() { ProductID = 863, VendorID = 95, Price = 15.50M });
        _productVendors.Add(new() { ProductID = 864, VendorID = 95, Price = 23.20M });
        _productVendors.Add(new() { ProductID = 865, VendorID = 95, Price = 23.20M });
        _productVendors.Add(new() { ProductID = 866, VendorID = 95, Price = 23.20M });
        _productVendors.Add(new() { ProductID = 867, VendorID = 95, Price = 25.45M });
        _productVendors.Add(new() { ProductID = 868, VendorID = 95, Price = 25.45M });
        _productVendors.Add(new() { ProductID = 869, VendorID = 95, Price = 25.45M });
        _productVendors.Add(new() { ProductID = 870, VendorID = 6, Price = 1.87M });
        _productVendors.Add(new() { ProductID = 871, VendorID = 6, Price = 3.74M });
        _productVendors.Add(new() { ProductID = 872, VendorID = 6, Price = 3.00M });
        _productVendors.Add(new() { ProductID = 873, VendorID = 6, Price = 0.80M });
        _productVendors.Add(new() { ProductID = 874, VendorID = 20, Price = 3.00M });
        _productVendors.Add(new() { ProductID = 875, VendorID = 20, Price = 3.00M });
        _productVendors.Add(new() { ProductID = 876, VendorID = 6, Price = 48.00M });
        _productVendors.Add(new() { ProductID = 877, VendorID = 6, Price = 3.00M });
        _productVendors.Add(new() { ProductID = 878, VendorID = 6, Price = 8.22M });
        _productVendors.Add(new() { ProductID = 879, VendorID = 6, Price = 49.00M });
        _productVendors.Add(new() { ProductID = 880, VendorID = 6, Price = 19.00M });
        _productVendors.Add(new() { ProductID = 881, VendorID = 29, Price = 40.00M });
        _productVendors.Add(new() { ProductID = 882, VendorID = 29, Price = 40.00M });
        _productVendors.Add(new() { ProductID = 883, VendorID = 29, Price = 40.00M });
        _productVendors.Add(new() { ProductID = 884, VendorID = 29, Price = 40.00M });
        _productVendors.Add(new() { ProductID = 907, VendorID = 94, Price = 78.89M });
        _productVendors.Add(new() { ProductID = 908, VendorID = 24, Price = 20.09M });
        _productVendors.Add(new() { ProductID = 908, VendorID = 45, Price = 20.09M });
        _productVendors.Add(new() { ProductID = 909, VendorID = 24, Price = 28.99M });
        _productVendors.Add(new() { ProductID = 909, VendorID = 45, Price = 28.99M });
        _productVendors.Add(new() { ProductID = 910, VendorID = 45, Price = 38.99M });
        _productVendors.Add(new() { ProductID = 910, VendorID = 52, Price = 38.99M });
        _productVendors.Add(new() { ProductID = 911, VendorID = 39, Price = 20.09M });
        _productVendors.Add(new() { ProductID = 911, VendorID = 45, Price = 20.09M });
        _productVendors.Add(new() { ProductID = 912, VendorID = 39, Price = 28.99M });
        _productVendors.Add(new() { ProductID = 912, VendorID = 45, Price = 28.99M });
        _productVendors.Add(new() { ProductID = 913, VendorID = 24, Price = 38.99M });
        _productVendors.Add(new() { ProductID = 913, VendorID = 45, Price = 38.99M });
        _productVendors.Add(new() { ProductID = 914, VendorID = 45, Price = 20.09M });
        _productVendors.Add(new() { ProductID = 914, VendorID = 87, Price = 20.09M });
        _productVendors.Add(new() { ProductID = 915, VendorID = 45, Price = 28.99M });
        _productVendors.Add(new() { ProductID = 915, VendorID = 87, Price = 28.99M });
        _productVendors.Add(new() { ProductID = 916, VendorID = 45, Price = 38.99M });
        _productVendors.Add(new() { ProductID = 916, VendorID = 87, Price = 38.99M });
        _productVendors.Add(new() { ProductID = 921, VendorID = 98, Price = 5.32M });
        _productVendors.Add(new() { ProductID = 922, VendorID = 22, Price = 6.22M });
        _productVendors.Add(new() { ProductID = 923, VendorID = 22, Price = 5.89M });
        _productVendors.Add(new() { ProductID = 928, VendorID = 55, Price = 31.21M });
        _productVendors.Add(new() { ProductID = 928, VendorID = 71, Price = 30.71M });
        _productVendors.Add(new() { ProductID = 929, VendorID = 55, Price = 35.32M });
        _productVendors.Add(new() { ProductID = 929, VendorID = 71, Price = 34.82M });
        _productVendors.Add(new() { ProductID = 930, VendorID = 55, Price = 40.99M });
        _productVendors.Add(new() { ProductID = 930, VendorID = 98, Price = 40.49M });
        _productVendors.Add(new() { ProductID = 931, VendorID = 33, Price = 32.71M });
        _productVendors.Add(new() { ProductID = 931, VendorID = 104, Price = 33.21M });
        _productVendors.Add(new() { ProductID = 932, VendorID = 33, Price = 37.37M });
        _productVendors.Add(new() { ProductID = 932, VendorID = 104, Price = 37.87M });
        _productVendors.Add(new() { ProductID = 933, VendorID = 22, Price = 41.39M });
        _productVendors.Add(new() { ProductID = 933, VendorID = 104, Price = 41.89M });
        _productVendors.Add(new() { ProductID = 934, VendorID = 22, Price = 35.83M });
        _productVendors.Add(new() { ProductID = 934, VendorID = 104, Price = 36.33M });
        _productVendors.Add(new() { ProductID = 935, VendorID = 73, Price = 29.99M });
        _productVendors.Add(new() { ProductID = 935, VendorID = 88, Price = 29.99M });
        _productVendors.Add(new() { ProductID = 936, VendorID = 73, Price = 45.99M });
        _productVendors.Add(new() { ProductID = 936, VendorID = 88, Price = 45.99M });
        _productVendors.Add(new() { ProductID = 937, VendorID = 43, Price = 59.99M });
        _productVendors.Add(new() { ProductID = 938, VendorID = 35, Price = 29.99M });
        _productVendors.Add(new() { ProductID = 938, VendorID = 53, Price = 29.99M });
        _productVendors.Add(new() { ProductID = 939, VendorID = 35, Price = 45.99M });
        _productVendors.Add(new() { ProductID = 939, VendorID = 53, Price = 45.99M });
        _productVendors.Add(new() { ProductID = 940, VendorID = 17, Price = 59.99M });
        _productVendors.Add(new() { ProductID = 941, VendorID = 80, Price = 59.99M });
        _productVendors.Add(new() { ProductID = 948, VendorID = 94, Price = 78.89M });
        _productVendors.Add(new() { ProductID = 952, VendorID = 72, Price = 14.99M });

    }


    private static void GenerateProducts() {
        _products.Add(new() { ID = 1, Name = "Adjustable Race" });
        _products.Add(new() { ID = 2, Name = "Bearing Ball" });
        _products.Add(new() { ID = 4, Name = "Headset Ball Bearings" });
        _products.Add(new() { ID = 317, Name = "LL Crankarm" });
        _products.Add(new() { ID = 318, Name = "ML Crankarm" });
        _products.Add(new() { ID = 319, Name = "HL Crankarm" });
        _products.Add(new() { ID = 320, Name = "Chainring Bolts" });
        _products.Add(new() { ID = 321, Name = "Chainring Nut" });
        _products.Add(new() { ID = 322, Name = "Chainring" });
        _products.Add(new() { ID = 323, Name = "Crown Race" });
        _products.Add(new() { ID = 325, Name = "Decal 1" });
        _products.Add(new() { ID = 326, Name = "Decal 2" });
        _products.Add(new() { ID = 332, Name = "Freewheel" });
        _products.Add(new() { ID = 341, Name = "Flat Washer 1" });
        _products.Add(new() { ID = 342, Name = "Flat Washer 6" });
        _products.Add(new() { ID = 343, Name = "Flat Washer 2" });
        _products.Add(new() { ID = 344, Name = "Flat Washer 9" });
        _products.Add(new() { ID = 345, Name = "Flat Washer 4" });
        _products.Add(new() { ID = 346, Name = "Flat Washer 3" });
        _products.Add(new() { ID = 347, Name = "Flat Washer 8" });
        _products.Add(new() { ID = 348, Name = "Flat Washer 5" });
        _products.Add(new() { ID = 349, Name = "Flat Washer 7" });
        _products.Add(new() { ID = 351, Name = "Front Derailleur Cage" });
        _products.Add(new() { ID = 352, Name = "Front Derailleur Linkage" });
        _products.Add(new() { ID = 355, Name = "Guide Pulley" });
        _products.Add(new() { ID = 356, Name = "LL Grip Tape" });
        _products.Add(new() { ID = 357, Name = "ML Grip Tape" });
        _products.Add(new() { ID = 358, Name = "HL Grip Tape" });
        _products.Add(new() { ID = 359, Name = "Thin-Jam Hex Nut 9" });
        _products.Add(new() { ID = 360, Name = "Thin-Jam Hex Nut 10" });
        _products.Add(new() { ID = 361, Name = "Thin-Jam Hex Nut 1" });
        _products.Add(new() { ID = 362, Name = "Thin-Jam Hex Nut 2" });
        _products.Add(new() { ID = 363, Name = "Thin-Jam Hex Nut 15" });
        _products.Add(new() { ID = 364, Name = "Thin-Jam Hex Nut 16" });
        _products.Add(new() { ID = 365, Name = "Thin-Jam Hex Nut 5" });
        _products.Add(new() { ID = 366, Name = "Thin-Jam Hex Nut 6" });
        _products.Add(new() { ID = 367, Name = "Thin-Jam Hex Nut 3" });
        _products.Add(new() { ID = 368, Name = "Thin-Jam Hex Nut 4" });
        _products.Add(new() { ID = 369, Name = "Thin-Jam Hex Nut 13" });
        _products.Add(new() { ID = 370, Name = "Thin-Jam Hex Nut 14" });
        _products.Add(new() { ID = 371, Name = "Thin-Jam Hex Nut 7" });
        _products.Add(new() { ID = 372, Name = "Thin-Jam Hex Nut 8" });
        _products.Add(new() { ID = 373, Name = "Thin-Jam Hex Nut 12" });
        _products.Add(new() { ID = 374, Name = "Thin-Jam Hex Nut 11" });
        _products.Add(new() { ID = 375, Name = "Hex Nut 5" });
        _products.Add(new() { ID = 376, Name = "Hex Nut 6" });
        _products.Add(new() { ID = 377, Name = "Hex Nut 16" });
        _products.Add(new() { ID = 378, Name = "Hex Nut 17" });
        _products.Add(new() { ID = 379, Name = "Hex Nut 7" });
        _products.Add(new() { ID = 380, Name = "Hex Nut 8" });
        _products.Add(new() { ID = 381, Name = "Hex Nut 9" });
        _products.Add(new() { ID = 382, Name = "Hex Nut 22" });
        _products.Add(new() { ID = 383, Name = "Hex Nut 23" });
        _products.Add(new() { ID = 384, Name = "Hex Nut 12" });
        _products.Add(new() { ID = 385, Name = "Hex Nut 13" });
        _products.Add(new() { ID = 386, Name = "Hex Nut 1" });
        _products.Add(new() { ID = 387, Name = "Hex Nut 10" });
        _products.Add(new() { ID = 388, Name = "Hex Nut 11" });
        _products.Add(new() { ID = 389, Name = "Hex Nut 2" });
        _products.Add(new() { ID = 390, Name = "Hex Nut 20" });
        _products.Add(new() { ID = 391, Name = "Hex Nut 21" });
        _products.Add(new() { ID = 392, Name = "Hex Nut 3" });
        _products.Add(new() { ID = 393, Name = "Hex Nut 14" });
        _products.Add(new() { ID = 394, Name = "Hex Nut 15" });
        _products.Add(new() { ID = 395, Name = "Hex Nut 4" });
        _products.Add(new() { ID = 396, Name = "Hex Nut 18" });
        _products.Add(new() { ID = 397, Name = "Hex Nut 19" });
        _products.Add(new() { ID = 402, Name = "Keyed Washer" });
        _products.Add(new() { ID = 403, Name = "External Lock Washer 3" });
        _products.Add(new() { ID = 404, Name = "External Lock Washer 4" });
        _products.Add(new() { ID = 405, Name = "External Lock Washer 9" });
        _products.Add(new() { ID = 406, Name = "External Lock Washer 5" });
        _products.Add(new() { ID = 407, Name = "External Lock Washer 7" });
        _products.Add(new() { ID = 408, Name = "External Lock Washer 6" });
        _products.Add(new() { ID = 409, Name = "External Lock Washer 1" });
        _products.Add(new() { ID = 410, Name = "External Lock Washer 8" });
        _products.Add(new() { ID = 411, Name = "External Lock Washer 2" });
        _products.Add(new() { ID = 412, Name = "Internal Lock Washer 3" });
        _products.Add(new() { ID = 413, Name = "Internal Lock Washer 4" });
        _products.Add(new() { ID = 414, Name = "Internal Lock Washer 9" });
        _products.Add(new() { ID = 415, Name = "Internal Lock Washer 5" });
        _products.Add(new() { ID = 416, Name = "Internal Lock Washer 7" });
        _products.Add(new() { ID = 417, Name = "Internal Lock Washer 6" });
        _products.Add(new() { ID = 418, Name = "Internal Lock Washer 10" });
        _products.Add(new() { ID = 419, Name = "Internal Lock Washer 1" });
        _products.Add(new() { ID = 420, Name = "Internal Lock Washer 8" });
        _products.Add(new() { ID = 421, Name = "Internal Lock Washer 2" });
        _products.Add(new() { ID = 422, Name = "Thin-Jam Lock Nut 9" });
        _products.Add(new() { ID = 423, Name = "Thin-Jam Lock Nut 10" });
        _products.Add(new() { ID = 424, Name = "Thin-Jam Lock Nut 1" });
        _products.Add(new() { ID = 425, Name = "Thin-Jam Lock Nut 2" });
        _products.Add(new() { ID = 426, Name = "Thin-Jam Lock Nut 15" });
        _products.Add(new() { ID = 427, Name = "Thin-Jam Lock Nut 16" });
        _products.Add(new() { ID = 428, Name = "Thin-Jam Lock Nut 5" });
        _products.Add(new() { ID = 429, Name = "Thin-Jam Lock Nut 6" });
        _products.Add(new() { ID = 430, Name = "Thin-Jam Lock Nut 3" });
        _products.Add(new() { ID = 431, Name = "Thin-Jam Lock Nut 4" });
        _products.Add(new() { ID = 432, Name = "Thin-Jam Lock Nut 13" });
        _products.Add(new() { ID = 433, Name = "Thin-Jam Lock Nut 14" });
        _products.Add(new() { ID = 434, Name = "Thin-Jam Lock Nut 7" });
        _products.Add(new() { ID = 435, Name = "Thin-Jam Lock Nut 8" });
        _products.Add(new() { ID = 436, Name = "Thin-Jam Lock Nut 12" });
        _products.Add(new() { ID = 437, Name = "Thin-Jam Lock Nut 11" });
        _products.Add(new() { ID = 438, Name = "Lock Nut 5" });
        _products.Add(new() { ID = 439, Name = "Lock Nut 6" });
        _products.Add(new() { ID = 440, Name = "Lock Nut 16" });
        _products.Add(new() { ID = 441, Name = "Lock Nut 17" });
        _products.Add(new() { ID = 442, Name = "Lock Nut 7" });
        _products.Add(new() { ID = 443, Name = "Lock Nut 8" });
        _products.Add(new() { ID = 444, Name = "Lock Nut 9" });
        _products.Add(new() { ID = 445, Name = "Lock Nut 22" });
        _products.Add(new() { ID = 446, Name = "Lock Nut 23" });
        _products.Add(new() { ID = 447, Name = "Lock Nut 12" });
        _products.Add(new() { ID = 448, Name = "Lock Nut 13" });
        _products.Add(new() { ID = 449, Name = "Lock Nut 1" });
        _products.Add(new() { ID = 450, Name = "Lock Nut 10" });
        _products.Add(new() { ID = 451, Name = "Lock Nut 11" });
        _products.Add(new() { ID = 452, Name = "Lock Nut 2" });
        _products.Add(new() { ID = 453, Name = "Lock Nut 20" });
        _products.Add(new() { ID = 454, Name = "Lock Nut 21" });
        _products.Add(new() { ID = 455, Name = "Lock Nut 3" });
        _products.Add(new() { ID = 456, Name = "Lock Nut 14" });
        _products.Add(new() { ID = 457, Name = "Lock Nut 15" });
        _products.Add(new() { ID = 458, Name = "Lock Nut 4" });
        _products.Add(new() { ID = 459, Name = "Lock Nut 19" });
        _products.Add(new() { ID = 460, Name = "Lock Nut 18" });
        _products.Add(new() { ID = 461, Name = "Lock Ring" });
        _products.Add(new() { ID = 462, Name = "Lower Head Race" });
        _products.Add(new() { ID = 463, Name = "Lock Washer 4" });
        _products.Add(new() { ID = 464, Name = "Lock Washer 5" });
        _products.Add(new() { ID = 465, Name = "Lock Washer 10" });
        _products.Add(new() { ID = 466, Name = "Lock Washer 6" });
        _products.Add(new() { ID = 467, Name = "Lock Washer 13" });
        _products.Add(new() { ID = 468, Name = "Lock Washer 8" });
        _products.Add(new() { ID = 469, Name = "Lock Washer 1" });
        _products.Add(new() { ID = 470, Name = "Lock Washer 7" });
        _products.Add(new() { ID = 471, Name = "Lock Washer 12" });
        _products.Add(new() { ID = 472, Name = "Lock Washer 2" });
        _products.Add(new() { ID = 473, Name = "Lock Washer 9" });
        _products.Add(new() { ID = 474, Name = "Lock Washer 3" });
        _products.Add(new() { ID = 475, Name = "Lock Washer 11" });
        _products.Add(new() { ID = 476, Name = "Metal Angle" });
        _products.Add(new() { ID = 477, Name = "Metal Bar 1" });
        _products.Add(new() { ID = 478, Name = "Metal Bar 2" });
        _products.Add(new() { ID = 479, Name = "Metal Plate 2" });
        _products.Add(new() { ID = 480, Name = "Metal Plate 1" });
        _products.Add(new() { ID = 481, Name = "Metal Plate 3" });
        _products.Add(new() { ID = 482, Name = "Metal Sheet 2" });
        _products.Add(new() { ID = 483, Name = "Metal Sheet 3" });
        _products.Add(new() { ID = 484, Name = "Metal Sheet 7" });
        _products.Add(new() { ID = 485, Name = "Metal Sheet 4" });
        _products.Add(new() { ID = 486, Name = "Metal Sheet 5" });
        _products.Add(new() { ID = 487, Name = "Metal Sheet 6" });
        _products.Add(new() { ID = 488, Name = "Metal Sheet 1" });
        _products.Add(new() { ID = 489, Name = "Metal Tread Plate" });
        _products.Add(new() { ID = 490, Name = "LL Nipple" });
        _products.Add(new() { ID = 491, Name = "HL Nipple" });
        _products.Add(new() { ID = 492, Name = "Paint - Black" });
        _products.Add(new() { ID = 493, Name = "Paint - Red" });
        _products.Add(new() { ID = 494, Name = "Paint - Silver" });
        _products.Add(new() { ID = 495, Name = "Paint - Blue" });
        _products.Add(new() { ID = 496, Name = "Paint - Yellow" });
        _products.Add(new() { ID = 497, Name = "Pinch Bolt" });
        _products.Add(new() { ID = 504, Name = "Cup-Shaped Race" });
        _products.Add(new() { ID = 505, Name = "Cone-Shaped Race" });
        _products.Add(new() { ID = 506, Name = "Reflector" });
        _products.Add(new() { ID = 507, Name = "LL Mountain Rim" });
        _products.Add(new() { ID = 508, Name = "ML Mountain Rim" });
        _products.Add(new() { ID = 509, Name = "HL Mountain Rim" });
        _products.Add(new() { ID = 510, Name = "LL Road Rim" });
        _products.Add(new() { ID = 511, Name = "ML Road Rim" });
        _products.Add(new() { ID = 512, Name = "HL Road Rim" });
        _products.Add(new() { ID = 513, Name = "Touring Rim" });
        _products.Add(new() { ID = 523, Name = "LL Spindle/Axle" });
        _products.Add(new() { ID = 524, Name = "HL Spindle/Axle" });
        _products.Add(new() { ID = 525, Name = "LL Shell" });
        _products.Add(new() { ID = 526, Name = "HL Shell" });
        _products.Add(new() { ID = 527, Name = "Spokes" });
        _products.Add(new() { ID = 528, Name = "Seat Lug" });
        _products.Add(new() { ID = 530, Name = "Seat Post" });
        _products.Add(new() { ID = 535, Name = "Tension Pulley" });
        _products.Add(new() { ID = 679, Name = "Rear Derailleur Cage" });
        _products.Add(new() { ID = 707, Name = "Sport-100 Helmet, Red" });
        _products.Add(new() { ID = 708, Name = "Sport-100 Helmet, Black" });
        _products.Add(new() { ID = 709, Name = "Mountain Bike Socks, M" });
        _products.Add(new() { ID = 710, Name = "Mountain Bike Socks, L" });
        _products.Add(new() { ID = 711, Name = "Sport-100 Helmet, Blue" });
        _products.Add(new() { ID = 712, Name = "AWC Logo Cap" });
        _products.Add(new() { ID = 713, Name = "Long-Sleeve Logo Jersey, S" });
        _products.Add(new() { ID = 714, Name = "Long-Sleeve Logo Jersey, M" });
        _products.Add(new() { ID = 715, Name = "Long-Sleeve Logo Jersey, L" });
        _products.Add(new() { ID = 716, Name = "Long-Sleeve Logo Jersey, XL" });
        _products.Add(new() { ID = 841, Name = "Men's Sports Shorts, S" });
        _products.Add(new() { ID = 842, Name = "Touring-Panniers, Large" });
        _products.Add(new() { ID = 843, Name = "Cable Lock" });
        _products.Add(new() { ID = 844, Name = "Minipump" });
        _products.Add(new() { ID = 845, Name = "Mountain Pump" });
        _products.Add(new() { ID = 846, Name = "Taillights - Battery-Powered" });
        _products.Add(new() { ID = 847, Name = "Headlights - Dual-Beam" });
        _products.Add(new() { ID = 848, Name = "Headlights - Weatherproof" });
        _products.Add(new() { ID = 849, Name = "Men's Sports Shorts, M" });
        _products.Add(new() { ID = 850, Name = "Men's Sports Shorts, L" });
        _products.Add(new() { ID = 851, Name = "Men's Sports Shorts, XL" });
        _products.Add(new() { ID = 852, Name = "Women's Tights, S" });
        _products.Add(new() { ID = 853, Name = "Women's Tights, M" });
        _products.Add(new() { ID = 854, Name = "Women's Tights, L" });
        _products.Add(new() { ID = 855, Name = "Men's Bib-Shorts, S" });
        _products.Add(new() { ID = 856, Name = "Men's Bib-Shorts, M" });
        _products.Add(new() { ID = 857, Name = "Men's Bib-Shorts, L" });
        _products.Add(new() { ID = 858, Name = "Half-Finger Gloves, S" });
        _products.Add(new() { ID = 859, Name = "Half-Finger Gloves, M" });
        _products.Add(new() { ID = 860, Name = "Half-Finger Gloves, L" });
        _products.Add(new() { ID = 861, Name = "Full-Finger Gloves, S" });
        _products.Add(new() { ID = 862, Name = "Full-Finger Gloves, M" });
        _products.Add(new() { ID = 863, Name = "Full-Finger Gloves, L" });
        _products.Add(new() { ID = 864, Name = "Classic Vest, S" });
        _products.Add(new() { ID = 865, Name = "Classic Vest, M" });
        _products.Add(new() { ID = 866, Name = "Classic Vest, L" });
        _products.Add(new() { ID = 867, Name = "Women's Mountain Shorts, S" });
        _products.Add(new() { ID = 868, Name = "Women's Mountain Shorts, M" });
        _products.Add(new() { ID = 869, Name = "Women's Mountain Shorts, L" });
        _products.Add(new() { ID = 870, Name = "Water Bottle - 30 oz." });
        _products.Add(new() { ID = 871, Name = "Mountain Bottle Cage" });
        _products.Add(new() { ID = 872, Name = "Road Bottle Cage" });
        _products.Add(new() { ID = 873, Name = "Patch Kit/8 Patches" });
        _products.Add(new() { ID = 874, Name = "Racing Socks, M" });
        _products.Add(new() { ID = 875, Name = "Racing Socks, L" });
        _products.Add(new() { ID = 876, Name = "Hitch Rack - 4-Bike" });
        _products.Add(new() { ID = 877, Name = "Bike Wash - Dissolver" });
        _products.Add(new() { ID = 878, Name = "Fender Set - Mountain" });
        _products.Add(new() { ID = 879, Name = "All-Purpose Bike Stand" });
        _products.Add(new() { ID = 880, Name = "Hydration Pack - 70 oz." });
        _products.Add(new() { ID = 881, Name = "Short-Sleeve Classic Jersey, S" });
        _products.Add(new() { ID = 882, Name = "Short-Sleeve Classic Jersey, M" });
        _products.Add(new() { ID = 883, Name = "Short-Sleeve Classic Jersey, L" });
        _products.Add(new() { ID = 884, Name = "Short-Sleeve Classic Jersey, XL" });
        _products.Add(new() { ID = 907, Name = "Rear Brakes" });
        _products.Add(new() { ID = 908, Name = "LL Mountain Seat/Saddle" });
        _products.Add(new() { ID = 909, Name = "ML Mountain Seat/Saddle" });
        _products.Add(new() { ID = 910, Name = "HL Mountain Seat/Saddle" });
        _products.Add(new() { ID = 911, Name = "LL Road Seat/Saddle" });
        _products.Add(new() { ID = 912, Name = "ML Road Seat/Saddle" });
        _products.Add(new() { ID = 913, Name = "HL Road Seat/Saddle" });
        _products.Add(new() { ID = 914, Name = "LL Touring Seat/Saddle" });
        _products.Add(new() { ID = 915, Name = "ML Touring Seat/Saddle" });
        _products.Add(new() { ID = 916, Name = "HL Touring Seat/Saddle" });
        _products.Add(new() { ID = 921, Name = "Mountain Tire Tube" });
        _products.Add(new() { ID = 922, Name = "Road Tire Tube" });
        _products.Add(new() { ID = 923, Name = "Touring Tire Tube" });
        _products.Add(new() { ID = 928, Name = "LL Mountain Tire" });
        _products.Add(new() { ID = 929, Name = "ML Mountain Tire" });
        _products.Add(new() { ID = 930, Name = "HL Mountain Tire" });
        _products.Add(new() { ID = 931, Name = "LL Road Tire" });
        _products.Add(new() { ID = 932, Name = "ML Road Tire" });
        _products.Add(new() { ID = 933, Name = "HL Road Tire" });
        _products.Add(new() { ID = 934, Name = "Touring Tire" });
        _products.Add(new() { ID = 935, Name = "LL Mountain Pedal" });
        _products.Add(new() { ID = 936, Name = "ML Mountain Pedal" });
        _products.Add(new() { ID = 937, Name = "HL Mountain Pedal" });
        _products.Add(new() { ID = 938, Name = "LL Road Pedal" });
        _products.Add(new() { ID = 939, Name = "ML Road Pedal" });
        _products.Add(new() { ID = 940, Name = "HL Road Pedal" });
        _products.Add(new() { ID = 941, Name = "Touring Pedal" });
        _products.Add(new() { ID = 948, Name = "Front Brakes" });
        _products.Add(new() { ID = 952, Name = "Chain" });
    }

    private static void GenerateEmployees() {
        _employees.Add(new() { ID = 1, Name = "Guy Gilbert", Manager = 16, BirthDate = new DateTime(1972, 5, 15), Gender = 'M', SickLeaveHours = 30 });
        _employees.Add(new() { ID = 2, Name = "Kevin Brown", Manager = 6, BirthDate = new DateTime(1977, 6, 3), Gender = 'M', SickLeaveHours = 41 });
        _employees.Add(new() { ID = 3, Name = "Roberto Tamburello", Manager = 12, BirthDate = new DateTime(1964, 12, 13), Gender = 'M', SickLeaveHours = 21 });
        _employees.Add(new() { ID = 4, Name = "Rob Walters", Manager = 3, BirthDate = new DateTime(1965, 1, 23), Gender = 'M', SickLeaveHours = 80 });
        _employees.Add(new() { ID = 5, Name = "Thierry D'Hers", Manager = 263, BirthDate = new DateTime(1949, 8, 29), Gender = 'M', SickLeaveHours = 24 });
        _employees.Add(new() { ID = 6, Name = "David Bradley", Manager = 109, BirthDate = new DateTime(1965, 4, 19), Gender = 'M', SickLeaveHours = 40 });
        _employees.Add(new() { ID = 7, Name = "JoLynn Dobney", Manager = 21, BirthDate = new DateTime(1946, 2, 16), Gender = 'F', SickLeaveHours = 61 });
        _employees.Add(new() { ID = 8, Name = "Ruth Ellerbrock", Manager = 185, BirthDate = new DateTime(1946, 7, 6), Gender = 'F', SickLeaveHours = 61 });
        _employees.Add(new() { ID = 9, Name = "Gail Erickson", Manager = 3, BirthDate = new DateTime(1942, 10, 29), Gender = 'F', SickLeaveHours = 22 });
        _employees.Add(new() { ID = 10, Name = "Barry Johnson", Manager = 185, BirthDate = new DateTime(1946, 4, 27), Gender = 'M', SickLeaveHours = 64 });
        _employees.Add(new() { ID = 11, Name = "Jossef Goldberg", Manager = 3, BirthDate = new DateTime(1949, 4, 11), Gender = 'M', SickLeaveHours = 23 });
        _employees.Add(new() { ID = 12, Name = "Terri Duffy", Manager = 109, BirthDate = new DateTime(1961, 9, 1), Gender = 'F', SickLeaveHours = 20 });
        _employees.Add(new() { ID = 13, Name = "Sidney Higa", Manager = 185, BirthDate = new DateTime(1946, 10, 1), Gender = 'M', SickLeaveHours = 62 });
        _employees.Add(new() { ID = 14, Name = "Taylor Maxwell", Manager = 21, BirthDate = new DateTime(1946, 5, 3), Gender = 'M', SickLeaveHours = 59 });
        _employees.Add(new() { ID = 15, Name = "Jeffrey Ford", Manager = 185, BirthDate = new DateTime(1946, 8, 12), Gender = 'M', SickLeaveHours = 62 });
        _employees.Add(new() { ID = 16, Name = "Jo Brown", Manager = 21, BirthDate = new DateTime(1946, 11, 9), Gender = 'F', SickLeaveHours = 60 });
        _employees.Add(new() { ID = 17, Name = "Doris Hartwig", Manager = 185, BirthDate = new DateTime(1946, 5, 6), Gender = 'F', SickLeaveHours = 63 });
        _employees.Add(new() { ID = 18, Name = "John Campbell", Manager = 21, BirthDate = new DateTime(1946, 9, 8), Gender = 'M', SickLeaveHours = 60 });
        _employees.Add(new() { ID = 19, Name = "Diane Glimp", Manager = 185, BirthDate = new DateTime(1946, 4, 30), Gender = 'F', SickLeaveHours = 63 });
        _employees.Add(new() { ID = 20, Name = "Steven Selikoff", Manager = 173, BirthDate = new DateTime(1967, 6, 15), Gender = 'M', SickLeaveHours = 40 });
        _employees.Add(new() { ID = 21, Name = "Peter Krebs", Manager = 148, BirthDate = new DateTime(1972, 12, 4), Gender = 'M', SickLeaveHours = 41 });
        _employees.Add(new() { ID = 22, Name = "Stuart Munson", Manager = 197, BirthDate = new DateTime(1952, 10, 14), Gender = 'M', SickLeaveHours = 62 });
        _employees.Add(new() { ID = 23, Name = "Greg Alderson", Manager = 197, BirthDate = new DateTime(1960, 11, 18), Gender = 'M', SickLeaveHours = 62 });
        _employees.Add(new() { ID = 24, Name = "David Johnson", Manager = 184, BirthDate = new DateTime(1969, 12, 3), Gender = 'M', SickLeaveHours = 32 });
        _employees.Add(new() { ID = 25, Name = "Zheng Mu", Manager = 21, BirthDate = new DateTime(1973, 11, 26), Gender = 'M', SickLeaveHours = 53 });
        _employees.Add(new() { ID = 26, Name = "Ivo Salmre", Manager = 108, BirthDate = new DateTime(1972, 2, 4), Gender = 'M', SickLeaveHours = 24 });
        _employees.Add(new() { ID = 27, Name = "Paul Komosinski", Manager = 87, BirthDate = new DateTime(1970, 12, 15), Gender = 'M', SickLeaveHours = 54 });
        _employees.Add(new() { ID = 28, Name = "Ashvini Sharma", Manager = 150, BirthDate = new DateTime(1967, 4, 28), Gender = 'M', SickLeaveHours = 55 });
        _employees.Add(new() { ID = 29, Name = "Kendall Keil", Manager = 14, BirthDate = new DateTime(1976, 6, 30), Gender = 'M', SickLeaveHours = 25 });
        _employees.Add(new() { ID = 30, Name = "Paula Barreto de Mattos", Manager = 140, BirthDate = new DateTime(1966, 3, 14), Gender = 'F', SickLeaveHours = 47 });
        _employees.Add(new() { ID = 31, Name = "Alejandro McGuel", Manager = 210, BirthDate = new DateTime(1979, 1, 6), Gender = 'M', SickLeaveHours = 46 });
        _employees.Add(new() { ID = 32, Name = "Garrett Young", Manager = 184, BirthDate = new DateTime(1974, 9, 26), Gender = 'M', SickLeaveHours = 37 });
        _employees.Add(new() { ID = 33, Name = "Jian Shuo Wang", Manager = 135, BirthDate = new DateTime(1973, 8, 27), Gender = 'M', SickLeaveHours = 38 });
        _employees.Add(new() { ID = 34, Name = "Susan Eaton", Manager = 85, BirthDate = new DateTime(1968, 3, 20), Gender = 'F', SickLeaveHours = 68 });
        _employees.Add(new() { ID = 35, Name = "Vamsi Kuppa", Manager = 85, BirthDate = new DateTime(1967, 4, 19), Gender = 'M', SickLeaveHours = 67 });
        _employees.Add(new() { ID = 36, Name = "Alice Ciccu", Manager = 38, BirthDate = new DateTime(1968, 2, 27), Gender = 'F', SickLeaveHours = 67 });
        _employees.Add(new() { ID = 37, Name = "Simon Rapier", Manager = 7, BirthDate = new DateTime(1980, 6, 17), Gender = 'M', SickLeaveHours = 39 });
        _employees.Add(new() { ID = 38, Name = "Jinghao Liu", Manager = 21, BirthDate = new DateTime(1979, 3, 9), Gender = 'M', SickLeaveHours = 58 });
        _employees.Add(new() { ID = 39, Name = "Michael Hines", Manager = 182, BirthDate = new DateTime(1974, 12, 19), Gender = 'M', SickLeaveHours = 30 });
        _employees.Add(new() { ID = 40, Name = "Yvonne McKay", Manager = 159, BirthDate = new DateTime(1979, 5, 17), Gender = 'F', SickLeaveHours = 59 });
        _employees.Add(new() { ID = 41, Name = "Peng Wu", Manager = 200, BirthDate = new DateTime(1966, 4, 19), Gender = 'M', SickLeaveHours = 60 });
        _employees.Add(new() { ID = 42, Name = "Jean Trenary", Manager = 109, BirthDate = new DateTime(1966, 1, 13), Gender = 'F', SickLeaveHours = 52 });
        _employees.Add(new() { ID = 43, Name = "Russell Hunter", Manager = 74, BirthDate = new DateTime(1962, 12, 27), Gender = 'M', SickLeaveHours = 23 });
        _employees.Add(new() { ID = 44, Name = "A. Scott Wright", Manager = 148, BirthDate = new DateTime(1958, 10, 19), Gender = 'M', SickLeaveHours = 42 });
        _employees.Add(new() { ID = 45, Name = "Fred Northup", Manager = 210, BirthDate = new DateTime(1979, 7, 27), Gender = 'M', SickLeaveHours = 43 });
        _employees.Add(new() { ID = 46, Name = "Sariya Harnpadoungsataya", Manager = 6, BirthDate = new DateTime(1977, 6, 21), Gender = 'M', SickLeaveHours = 42 });
        _employees.Add(new() { ID = 47, Name = "Willis Johnson", Manager = 30, BirthDate = new DateTime(1968, 8, 18), Gender = 'M', SickLeaveHours = 44 });
        _employees.Add(new() { ID = 48, Name = "Jun Cao", Manager = 38, BirthDate = new DateTime(1969, 8, 6), Gender = 'M', SickLeaveHours = 65 });
        _employees.Add(new() { ID = 49, Name = "Christian Kleinerman", Manager = 218, BirthDate = new DateTime(1966, 2, 18), Gender = 'M', SickLeaveHours = 66 });
        _employees.Add(new() { ID = 50, Name = "Susan Metters", Manager = 184, BirthDate = new DateTime(1973, 5, 3), Gender = 'F', SickLeaveHours = 35 });
        _employees.Add(new() { ID = 51, Name = "Reuben D'sa", Manager = 21, BirthDate = new DateTime(1977, 9, 27), Gender = 'M', SickLeaveHours = 56 });
        _employees.Add(new() { ID = 52, Name = "Kirk Koenigsbauer", Manager = 123, BirthDate = new DateTime(1975, 3, 10), Gender = 'M', SickLeaveHours = 57 });
        _employees.Add(new() { ID = 53, Name = "David Ortiz", Manager = 18, BirthDate = new DateTime(1975, 1, 30), Gender = 'M', SickLeaveHours = 36 });
        _employees.Add(new() { ID = 54, Name = "Tengiz Kharatishvili", Manager = 90, BirthDate = new DateTime(1980, 5, 29), Gender = 'M', SickLeaveHours = 58 });
        _employees.Add(new() { ID = 55, Name = "Hanying Feng", Manager = 143, BirthDate = new DateTime(1964, 11, 16), Gender = 'M', SickLeaveHours = 27 });
        _employees.Add(new() { ID = 56, Name = "Kevin Liu", Manager = 210, BirthDate = new DateTime(1976, 1, 26), Gender = 'M', SickLeaveHours = 49 });
        _employees.Add(new() { ID = 57, Name = "Annik Stahl", Manager = 16, BirthDate = new DateTime(1967, 1, 27), Gender = 'M', SickLeaveHours = 28 });
        _employees.Add(new() { ID = 58, Name = "Suroor Fatima", Manager = 38, BirthDate = new DateTime(1968, 3, 28), Gender = 'M', SickLeaveHours = 66 });
        _employees.Add(new() { ID = 59, Name = "Deborah Poe", Manager = 139, BirthDate = new DateTime(1966, 4, 7), Gender = 'F', SickLeaveHours = 50 });
        _employees.Add(new() { ID = 60, Name = "Jim Scardelis", Manager = 74, BirthDate = new DateTime(1976, 10, 9), Gender = 'M', SickLeaveHours = 20 });
        _employees.Add(new() { ID = 61, Name = "Carole Poland", Manager = 173, BirthDate = new DateTime(1973, 11, 19), Gender = 'F', SickLeaveHours = 41 });
        _employees.Add(new() { ID = 62, Name = "George Li", Manager = 184, BirthDate = new DateTime(1967, 5, 18), Gender = 'M', SickLeaveHours = 33 });
        _employees.Add(new() { ID = 63, Name = "Gary Yukish", Manager = 87, BirthDate = new DateTime(1978, 6, 17), Gender = 'M', SickLeaveHours = 54 });
        _employees.Add(new() { ID = 64, Name = "Cristian Petculescu", Manager = 21, BirthDate = new DateTime(1974, 5, 13), Gender = 'M', SickLeaveHours = 53 });
        _employees.Add(new() { ID = 65, Name = "Raymond Sam", Manager = 143, BirthDate = new DateTime(1957, 4, 2), Gender = 'M', SickLeaveHours = 25 });
        _employees.Add(new() { ID = 66, Name = "Janaina Bueno", Manager = 42, BirthDate = new DateTime(1975, 3, 3), Gender = 'F', SickLeaveHours = 55 });
        _employees.Add(new() { ID = 67, Name = "Bob Hohman", Manager = 14, BirthDate = new DateTime(1969, 9, 16), Gender = 'M', SickLeaveHours = 26 });
        _employees.Add(new() { ID = 68, Name = "Shammi Mohamed", Manager = 210, BirthDate = new DateTime(1970, 11, 5), Gender = 'M', SickLeaveHours = 46 });
        _employees.Add(new() { ID = 69, Name = "Linda Moschell", Manager = 38, BirthDate = new DateTime(1977, 8, 17), Gender = 'F', SickLeaveHours = 68 });
        _employees.Add(new() { ID = 70, Name = "Mindy Martin", Manager = 30, BirthDate = new DateTime(1974, 12, 22), Gender = 'F', SickLeaveHours = 45 });
        _employees.Add(new() { ID = 71, Name = "Wendy Kahn", Manager = 140, BirthDate = new DateTime(1974, 11, 12), Gender = 'F', SickLeaveHours = 47 });
        _employees.Add(new() { ID = 72, Name = "Kim Ralls", Manager = 85, BirthDate = new DateTime(1974, 6, 1), Gender = 'F', SickLeaveHours = 69 });
        _employees.Add(new() { ID = 73, Name = "Sandra Reátegui Alayo", Manager = 135, BirthDate = new DateTime(1965, 12, 6), Gender = 'F', SickLeaveHours = 38 });
        _employees.Add(new() { ID = 74, Name = "Kok-Ho Loh", Manager = 21, BirthDate = new DateTime(1970, 5, 30), Gender = 'M', SickLeaveHours = 59 });
        _employees.Add(new() { ID = 75, Name = "Douglas Hite", Manager = 159, BirthDate = new DateTime(1975, 12, 26), Gender = 'M', SickLeaveHours = 60 });
        _employees.Add(new() { ID = 76, Name = "James Kramer", Manager = 7, BirthDate = new DateTime(1974, 8, 26), Gender = 'M', SickLeaveHours = 39 });
        _employees.Add(new() { ID = 77, Name = "Sean Alexander", Manager = 41, BirthDate = new DateTime(1966, 4, 7), Gender = 'M', SickLeaveHours = 61 });
        _employees.Add(new() { ID = 78, Name = "Nitin Mirchandani", Manager = 182, BirthDate = new DateTime(1977, 1, 1), Gender = 'M', SickLeaveHours = 30 });
        _employees.Add(new() { ID = 79, Name = "Diane Margheim", Manager = 158, BirthDate = new DateTime(1976, 7, 6), Gender = 'F', SickLeaveHours = 51 });
        _employees.Add(new() { ID = 80, Name = "Rebecca Laszlo", Manager = 16, BirthDate = new DateTime(1967, 8, 11), Gender = 'F', SickLeaveHours = 31 });
        _employees.Add(new() { ID = 81, Name = "Rajesh Patel", Manager = 210, BirthDate = new DateTime(1967, 11, 5), Gender = 'M', SickLeaveHours = 44 });
        _employees.Add(new() { ID = 82, Name = "Vidur Luthra", Manager = 30, BirthDate = new DateTime(1974, 9, 2), Gender = 'M', SickLeaveHours = 45 });
        _employees.Add(new() { ID = 83, Name = "John Evans", Manager = 38, BirthDate = new DateTime(1968, 7, 1), Gender = 'M', SickLeaveHours = 65 });
        _employees.Add(new() { ID = 84, Name = "Nancy Anderson", Manager = 7, BirthDate = new DateTime(1978, 12, 21), Gender = 'F', SickLeaveHours = 37 });
        _employees.Add(new() { ID = 85, Name = "Pilar Ackerman", Manager = 21, BirthDate = new DateTime(1962, 10, 11), Gender = 'M', SickLeaveHours = 66 });
        _employees.Add(new() { ID = 86, Name = "David Yalovsky", Manager = 184, BirthDate = new DateTime(1971, 9, 4), Gender = 'M', SickLeaveHours = 36 });
        _employees.Add(new() { ID = 87, Name = "David Hamilton", Manager = 21, BirthDate = new DateTime(1973, 8, 2), Gender = 'M', SickLeaveHours = 56 });
        _employees.Add(new() { ID = 88, Name = "Laura Steele", Manager = 123, BirthDate = new DateTime(1971, 1, 26), Gender = 'F', SickLeaveHours = 57 });
        _employees.Add(new() { ID = 89, Name = "Margie Shoop", Manager = 16, BirthDate = new DateTime(1976, 6, 20), Gender = 'F', SickLeaveHours = 29 });
        _employees.Add(new() { ID = 90, Name = "Zainal Arifin", Manager = 200, BirthDate = new DateTime(1966, 3, 2), Gender = 'M', SickLeaveHours = 58 });
        _employees.Add(new() { ID = 91, Name = "Lorraine Nay", Manager = 210, BirthDate = new DateTime(1978, 12, 28), Gender = 'F', SickLeaveHours = 44 });
        _employees.Add(new() { ID = 92, Name = "Fadi Fakhouri", Manager = 143, BirthDate = new DateTime(1979, 3, 19), Gender = 'M', SickLeaveHours = 28 });
        _employees.Add(new() { ID = 93, Name = "Ryan Cornelsen", Manager = 51, BirthDate = new DateTime(1962, 7, 15), Gender = 'M', SickLeaveHours = 49 });
        _employees.Add(new() { ID = 94, Name = "Candy Spoon", Manager = 139, BirthDate = new DateTime(1966, 3, 26), Gender = 'F', SickLeaveHours = 50 });
        _employees.Add(new() { ID = 95, Name = "Nuan Yu", Manager = 74, BirthDate = new DateTime(1969, 4, 29), Gender = 'M', SickLeaveHours = 21 });
        _employees.Add(new() { ID = 96, Name = "William Vong", Manager = 44, BirthDate = new DateTime(1971, 12, 8), Gender = 'M', SickLeaveHours = 42 });
        _employees.Add(new() { ID = 97, Name = "Bjorn Rettig", Manager = 173, BirthDate = new DateTime(1979, 12, 8), Gender = 'M', SickLeaveHours = 41 });
        _employees.Add(new() { ID = 98, Name = "Scott Gode", Manager = 197, BirthDate = new DateTime(1977, 3, 13), Gender = 'M', SickLeaveHours = 63 });
        _employees.Add(new() { ID = 99, Name = "Michael Rothkugel", Manager = 87, BirthDate = new DateTime(1981, 2, 4), Gender = 'M', SickLeaveHours = 55 });
        _employees.Add(new() { ID = 100, Name = "Lane Sacksteder", Manager = 143, BirthDate = new DateTime(1964, 10, 24), Gender = 'M', SickLeaveHours = 25 });
        _employees.Add(new() { ID = 101, Name = "Pete Male", Manager = 14, BirthDate = new DateTime(1967, 3, 7), Gender = 'M', SickLeaveHours = 26 });
        _employees.Add(new() { ID = 102, Name = "Dan Bacon", Manager = 42, BirthDate = new DateTime(1971, 7, 28), Gender = 'M', SickLeaveHours = 56 });
        _employees.Add(new() { ID = 103, Name = "David Barber", Manager = 140, BirthDate = new DateTime(1954, 7, 23), Gender = 'M', SickLeaveHours = 48 });
        _employees.Add(new() { ID = 104, Name = "Lolan Song", Manager = 74, BirthDate = new DateTime(1963, 2, 25), Gender = 'M', SickLeaveHours = 23 });
        _employees.Add(new() { ID = 105, Name = "Paula Nartker", Manager = 210, BirthDate = new DateTime(1977, 3, 13), Gender = 'F', SickLeaveHours = 47 });
        _employees.Add(new() { ID = 106, Name = "Mary Gibson", Manager = 6, BirthDate = new DateTime(1952, 10, 14), Gender = 'F', SickLeaveHours = 43 });
        _employees.Add(new() { ID = 107, Name = "Mindaugas Krapauskas", Manager = 38, BirthDate = new DateTime(1968, 6, 7), Gender = 'M', SickLeaveHours = 68 });
        _employees.Add(new() { ID = 108, Name = "Eric Gubbels", Manager = 21, BirthDate = new DateTime(1975, 2, 20), Gender = 'M', SickLeaveHours = 40 });
        _employees.Add(new() { ID = 109, Name = "Ken Sánchez", Manager = null, BirthDate = new DateTime(1959, 3, 2), Gender = 'M', SickLeaveHours = 69 });
        _employees.Add(new() { ID = 110, Name = "Jason Watters", Manager = 135, BirthDate = new DateTime(1979, 1, 8), Gender = 'M', SickLeaveHours = 39 });
        _employees.Add(new() { ID = 111, Name = "Mark Harrington", Manager = 41, BirthDate = new DateTime(1976, 5, 31), Gender = 'M', SickLeaveHours = 61 });
        _employees.Add(new() { ID = 112, Name = "Janeth Esteves", Manager = 159, BirthDate = new DateTime(1962, 8, 25), Gender = 'F', SickLeaveHours = 60 });
        _employees.Add(new() { ID = 113, Name = "Marc Ingle", Manager = 184, BirthDate = new DateTime(1976, 11, 24), Gender = 'M', SickLeaveHours = 31 });
        _employees.Add(new() { ID = 114, Name = "Gigi Matthew", Manager = 158, BirthDate = new DateTime(1969, 2, 21), Gender = 'F', SickLeaveHours = 51 });
        _employees.Add(new() { ID = 115, Name = "Paul Singh", Manager = 108, BirthDate = new DateTime(1980, 12, 5), Gender = 'M', SickLeaveHours = 23 });
        _employees.Add(new() { ID = 116, Name = "Frank Lee", Manager = 210, BirthDate = new DateTime(1977, 10, 7), Gender = 'M', SickLeaveHours = 48 });
        _employees.Add(new() { ID = 117, Name = "François Ajenstat", Manager = 42, BirthDate = new DateTime(1965, 6, 17), Gender = 'M', SickLeaveHours = 53 });
        _employees.Add(new() { ID = 118, Name = "Diane Tibbott", Manager = 14, BirthDate = new DateTime(1979, 9, 10), Gender = 'F', SickLeaveHours = 24 });
        _employees.Add(new() { ID = 119, Name = "Jill Williams", Manager = 6, BirthDate = new DateTime(1969, 7, 19), Gender = 'F', SickLeaveHours = 43 });
        _employees.Add(new() { ID = 120, Name = "Angela Barbariol", Manager = 38, BirthDate = new DateTime(1981, 7, 1), Gender = 'F', SickLeaveHours = 66 });
        _employees.Add(new() { ID = 121, Name = "Matthias Berndt", Manager = 85, BirthDate = new DateTime(1963, 12, 13), Gender = 'M', SickLeaveHours = 67 });
        _employees.Add(new() { ID = 122, Name = "Bryan Baker", Manager = 7, BirthDate = new DateTime(1963, 9, 28), Gender = 'M', SickLeaveHours = 37 });
        _employees.Add(new() { ID = 123, Name = "Jeff Hay", Manager = 21, BirthDate = new DateTime(1967, 2, 16), Gender = 'M', SickLeaveHours = 57 });
        _employees.Add(new() { ID = 124, Name = "Eugene Zabokritski", Manager = 184, BirthDate = new DateTime(1977, 8, 15), Gender = 'M', SickLeaveHours = 36 });
        _employees.Add(new() { ID = 125, Name = "Barbara Decker", Manager = 182, BirthDate = new DateTime(1969, 8, 2), Gender = 'F', SickLeaveHours = 28 });
        _employees.Add(new() { ID = 126, Name = "Chris Preston", Manager = 123, BirthDate = new DateTime(1979, 1, 17), Gender = 'M', SickLeaveHours = 58 });
        _employees.Add(new() { ID = 127, Name = "Sean Chai", Manager = 90, BirthDate = new DateTime(1977, 4, 12), Gender = 'M', SickLeaveHours = 59 });
        _employees.Add(new() { ID = 128, Name = "Dan Wilson", Manager = 42, BirthDate = new DateTime(1966, 2, 6), Gender = 'M', SickLeaveHours = 53 });
        _employees.Add(new() { ID = 129, Name = "Mark McArthur", Manager = 16, BirthDate = new DateTime(1969, 10, 26), Gender = 'M', SickLeaveHours = 29 });
        _employees.Add(new() { ID = 130, Name = "Bryan Walton", Manager = 139, BirthDate = new DateTime(1974, 10, 22), Gender = 'M', SickLeaveHours = 51 });
        _employees.Add(new() { ID = 131, Name = "Houman Pournasseh", Manager = 74, BirthDate = new DateTime(1961, 9, 30), Gender = 'M', SickLeaveHours = 21 });
        _employees.Add(new() { ID = 132, Name = "Sairaj Uddin", Manager = 44, BirthDate = new DateTime(1978, 1, 22), Gender = 'M', SickLeaveHours = 43 });
        _employees.Add(new() { ID = 133, Name = "Michiko Osada", Manager = 173, BirthDate = new DateTime(1972, 7, 28), Gender = 'M', SickLeaveHours = 42 });
        _employees.Add(new() { ID = 134, Name = "Benjamin Martin", Manager = 184, BirthDate = new DateTime(1976, 2, 6), Gender = 'M', SickLeaveHours = 34 });
        _employees.Add(new() { ID = 135, Name = "Cynthia Randall", Manager = 21, BirthDate = new DateTime(1971, 9, 19), Gender = 'F', SickLeaveHours = 54 });
        _employees.Add(new() { ID = 136, Name = "Kathie Flood", Manager = 197, BirthDate = new DateTime(1980, 12, 2), Gender = 'F', SickLeaveHours = 63 });
        _employees.Add(new() { ID = 137, Name = "Britta Simon", Manager = 16, BirthDate = new DateTime(1979, 10, 30), Gender = 'F', SickLeaveHours = 27 });
        _employees.Add(new() { ID = 138, Name = "Brian Lloyd", Manager = 210, BirthDate = new DateTime(1967, 3, 14), Gender = 'M', SickLeaveHours = 47 });
        _employees.Add(new() { ID = 139, Name = "David Liu", Manager = 140, BirthDate = new DateTime(1973, 8, 8), Gender = 'M', SickLeaveHours = 48 });
        _employees.Add(new() { ID = 140, Name = "Laura Norman", Manager = 109, BirthDate = new DateTime(1966, 2, 6), Gender = 'F', SickLeaveHours = 20 });
        _employees.Add(new() { ID = 141, Name = "Michael Patten", Manager = 38, BirthDate = new DateTime(1964, 6, 3), Gender = 'M', SickLeaveHours = 69 });
        _employees.Add(new() { ID = 142, Name = "Andy Ruth", Manager = 135, BirthDate = new DateTime(1973, 11, 20), Gender = 'M', SickLeaveHours = 39 });
        _employees.Add(new() { ID = 143, Name = "Yuhong Li", Manager = 21, BirthDate = new DateTime(1967, 5, 8), Gender = 'M', SickLeaveHours = 40 });
        _employees.Add(new() { ID = 144, Name = "Robert Rounthwaite", Manager = 159, BirthDate = new DateTime(1975, 4, 1), Gender = 'M', SickLeaveHours = 61 });
        _employees.Add(new() { ID = 145, Name = "Andreas Berglund", Manager = 41, BirthDate = new DateTime(1979, 4, 29), Gender = 'M', SickLeaveHours = 62 });
        _employees.Add(new() { ID = 146, Name = "Reed Koch", Manager = 184, BirthDate = new DateTime(1979, 2, 9), Gender = 'M', SickLeaveHours = 31 });
        _employees.Add(new() { ID = 147, Name = "Linda Randall", Manager = 143, BirthDate = new DateTime(1967, 11, 6), Gender = 'F', SickLeaveHours = 26 });
        _employees.Add(new() { ID = 148, Name = "James Hamilton", Manager = 109, BirthDate = new DateTime(1973, 2, 7), Gender = 'M', SickLeaveHours = 52 });
        _employees.Add(new() { ID = 149, Name = "Ramesh Meyyappan", Manager = 42, BirthDate = new DateTime(1978, 4, 14), Gender = 'M', SickLeaveHours = 56 });
        _employees.Add(new() { ID = 150, Name = "Stephanie Conroy", Manager = 42, BirthDate = new DateTime(1974, 4, 26), Gender = 'F', SickLeaveHours = 54 });
        _employees.Add(new() { ID = 151, Name = "Samantha Smith", Manager = 108, BirthDate = new DateTime(1977, 12, 23), Gender = 'F', SickLeaveHours = 23 });
        _employees.Add(new() { ID = 152, Name = "Tawana Nusbaum", Manager = 210, BirthDate = new DateTime(1979, 12, 12), Gender = 'M', SickLeaveHours = 45 });
        _employees.Add(new() { ID = 153, Name = "Denise Smith", Manager = 14, BirthDate = new DateTime(1978, 8, 7), Gender = 'F', SickLeaveHours = 24 });
        _employees.Add(new() { ID = 154, Name = "Hao Chen", Manager = 30, BirthDate = new DateTime(1967, 5, 19), Gender = 'M', SickLeaveHours = 46 });
        _employees.Add(new() { ID = 155, Name = "Alex Nayberg", Manager = 123, BirthDate = new DateTime(1980, 5, 14), Gender = 'M', SickLeaveHours = 58 });
        _employees.Add(new() { ID = 156, Name = "Eugene Kogan", Manager = 7, BirthDate = new DateTime(1966, 3, 13), Gender = 'M', SickLeaveHours = 38 });
        _employees.Add(new() { ID = 157, Name = "Brandon Heidepriem", Manager = 16, BirthDate = new DateTime(1967, 2, 11), Gender = 'M', SickLeaveHours = 31 });
        _employees.Add(new() { ID = 158, Name = "Dylan Miller", Manager = 3, BirthDate = new DateTime(1977, 3, 27), Gender = 'M', SickLeaveHours = 50 });
        _employees.Add(new() { ID = 159, Name = "Shane Kim", Manager = 21, BirthDate = new DateTime(1980, 6, 24), Gender = 'M', SickLeaveHours = 57 });
        _employees.Add(new() { ID = 160, Name = "John Chen", Manager = 182, BirthDate = new DateTime(1976, 5, 6), Gender = 'M', SickLeaveHours = 29 });
        _employees.Add(new() { ID = 161, Name = "Karen Berge", Manager = 90, BirthDate = new DateTime(1966, 1, 25), Gender = 'F', SickLeaveHours = 59 });
        _employees.Add(new() { ID = 162, Name = "Jose Lugo", Manager = 16, BirthDate = new DateTime(1974, 9, 1), Gender = 'M', SickLeaveHours = 30 });
        _employees.Add(new() { ID = 163, Name = "Mandar Samant", Manager = 74, BirthDate = new DateTime(1976, 4, 21), Gender = 'M', SickLeaveHours = 20 });
        _employees.Add(new() { ID = 164, Name = "Mikael Sandberg", Manager = 274, BirthDate = new DateTime(1974, 9, 18), Gender = 'M', SickLeaveHours = 49 });
        _employees.Add(new() { ID = 165, Name = "Sameer Tejani", Manager = 74, BirthDate = new DateTime(1968, 7, 27), Gender = 'M', SickLeaveHours = 22 });
        _employees.Add(new() { ID = 166, Name = "Dragan Tomic", Manager = 139, BirthDate = new DateTime(1967, 3, 18), Gender = 'M', SickLeaveHours = 51 });
        _employees.Add(new() { ID = 167, Name = "Carol Philips", Manager = 173, BirthDate = new DateTime(1978, 11, 18), Gender = 'F', SickLeaveHours = 42 });
        _employees.Add(new() { ID = 168, Name = "Rob Caron", Manager = 87, BirthDate = new DateTime(1963, 9, 5), Gender = 'M', SickLeaveHours = 55 });
        _employees.Add(new() { ID = 169, Name = "Don Hall", Manager = 38, BirthDate = new DateTime(1961, 7, 14), Gender = 'M', SickLeaveHours = 64 });
        _employees.Add(new() { ID = 170, Name = "Alan Brewer", Manager = 44, BirthDate = new DateTime(1974, 4, 30), Gender = 'M', SickLeaveHours = 43 });
        _employees.Add(new() { ID = 171, Name = "David Lawrence", Manager = 184, BirthDate = new DateTime(1975, 10, 25), Gender = 'M', SickLeaveHours = 34 });
        _employees.Add(new() { ID = 172, Name = "Baris Cetinok", Manager = 87, BirthDate = new DateTime(1980, 11, 7), Gender = 'M', SickLeaveHours = 56 });
        _employees.Add(new() { ID = 173, Name = "Michael Ray", Manager = 21, BirthDate = new DateTime(1979, 3, 2), Gender = 'M', SickLeaveHours = 55 });
        _employees.Add(new() { ID = 174, Name = "Steve Masters", Manager = 18, BirthDate = new DateTime(1981, 5, 7), Gender = 'M', SickLeaveHours = 35 });
        _employees.Add(new() { ID = 175, Name = "Suchitra Mohan", Manager = 16, BirthDate = new DateTime(1977, 7, 11), Gender = 'F', SickLeaveHours = 27 });
        _employees.Add(new() { ID = 176, Name = "Karen Berg", Manager = 42, BirthDate = new DateTime(1968, 6, 19), Gender = 'F', SickLeaveHours = 57 });
        _employees.Add(new() { ID = 177, Name = "Terrence Earls", Manager = 143, BirthDate = new DateTime(1975, 1, 9), Gender = 'M', SickLeaveHours = 26 });
        _employees.Add(new() { ID = 178, Name = "Barbara Moreland", Manager = 139, BirthDate = new DateTime(1966, 2, 4), Gender = 'F', SickLeaveHours = 49 });
        _employees.Add(new() { ID = 179, Name = "Chad Niswonger", Manager = 38, BirthDate = new DateTime(1980, 9, 4), Gender = 'M', SickLeaveHours = 69 });
        _employees.Add(new() { ID = 180, Name = "Rostislav Shabalin", Manager = 135, BirthDate = new DateTime(1967, 10, 15), Gender = 'M', SickLeaveHours = 40 });
        _employees.Add(new() { ID = 181, Name = "Belinda Newman", Manager = 197, BirthDate = new DateTime(1959, 10, 19), Gender = 'F', SickLeaveHours = 61 });
        _employees.Add(new() { ID = 182, Name = "Katie McAskill-White", Manager = 21, BirthDate = new DateTime(1974, 12, 20), Gender = 'F', SickLeaveHours = 41 });
        _employees.Add(new() { ID = 183, Name = "Russell King", Manager = 184, BirthDate = new DateTime(1972, 3, 14), Gender = 'M', SickLeaveHours = 32 });
        _employees.Add(new() { ID = 184, Name = "Jack Richins", Manager = 21, BirthDate = new DateTime(1973, 7, 23), Gender = 'M', SickLeaveHours = 54 });
        _employees.Add(new() { ID = 185, Name = "Andrew Hill", Manager = 21, BirthDate = new DateTime(1978, 10, 8), Gender = 'M', SickLeaveHours = 52 });
        _employees.Add(new() { ID = 186, Name = "Nicole Holliday", Manager = 87, BirthDate = new DateTime(1976, 5, 10), Gender = 'F', SickLeaveHours = 53 });
        _employees.Add(new() { ID = 187, Name = "Frank Miller", Manager = 14, BirthDate = new DateTime(1961, 8, 24), Gender = 'M', SickLeaveHours = 25 });
        _employees.Add(new() { ID = 188, Name = "Peter Connelly", Manager = 150, BirthDate = new DateTime(1970, 6, 29), Gender = 'M', SickLeaveHours = 54 });
        _employees.Add(new() { ID = 189, Name = "Anibal Sousa", Manager = 108, BirthDate = new DateTime(1964, 10, 6), Gender = 'F', SickLeaveHours = 24 });
        _employees.Add(new() { ID = 190, Name = "Ken Myer", Manager = 210, BirthDate = new DateTime(1971, 6, 29), Gender = 'M', SickLeaveHours = 45 });
        _employees.Add(new() { ID = 191, Name = "Grant Culbertson", Manager = 30, BirthDate = new DateTime(1966, 5, 18), Gender = 'M', SickLeaveHours = 46 });
        _employees.Add(new() { ID = 192, Name = "Michael Entin", Manager = 38, BirthDate = new DateTime(1979, 7, 17), Gender = 'M', SickLeaveHours = 67 });
        _employees.Add(new() { ID = 193, Name = "Lionel Penuchot", Manager = 159, BirthDate = new DateTime(1978, 4, 15), Gender = 'M', SickLeaveHours = 59 });
        _employees.Add(new() { ID = 194, Name = "Thomas Michaels", Manager = 7, BirthDate = new DateTime(1976, 2, 11), Gender = 'M', SickLeaveHours = 38 });
        _employees.Add(new() { ID = 195, Name = "Jimmy Bischoff", Manager = 85, BirthDate = new DateTime(1975, 6, 5), Gender = 'M', SickLeaveHours = 68 });
        _employees.Add(new() { ID = 196, Name = "Michael Vanderhyde", Manager = 135, BirthDate = new DateTime(1972, 10, 19), Gender = 'M', SickLeaveHours = 37 });
        _employees.Add(new() { ID = 197, Name = "Lori Kane", Manager = 21, BirthDate = new DateTime(1970, 8, 19), Gender = 'F', SickLeaveHours = 58 });
        _employees.Add(new() { ID = 198, Name = "Arvind Rao", Manager = 274, BirthDate = new DateTime(1964, 9, 21), Gender = 'M', SickLeaveHours = 50 });
        _employees.Add(new() { ID = 199, Name = "Stefen Hesse", Manager = 182, BirthDate = new DateTime(1966, 1, 21), Gender = 'M', SickLeaveHours = 29 });
        _employees.Add(new() { ID = 200, Name = "Hazem Abolrous", Manager = 148, BirthDate = new DateTime(1967, 11, 27), Gender = 'M', SickLeaveHours = 60 });
        _employees.Add(new() { ID = 201, Name = "Janet Sheperdigian", Manager = 139, BirthDate = new DateTime(1969, 4, 9), Gender = 'F', SickLeaveHours = 52 });
        _employees.Add(new() { ID = 202, Name = "Elizabeth Keyser", Manager = 74, BirthDate = new DateTime(1980, 2, 26), Gender = 'F', SickLeaveHours = 22 });
        _employees.Add(new() { ID = 203, Name = "Terry Eminhizer", Manager = 6, BirthDate = new DateTime(1976, 3, 7), Gender = 'M', SickLeaveHours = 42 });
        _employees.Add(new() { ID = 204, Name = "John Frum", Manager = 184, BirthDate = new DateTime(1972, 4, 24), Gender = 'M', SickLeaveHours = 33 });
        _employees.Add(new() { ID = 205, Name = "Merav Netz", Manager = 173, BirthDate = new DateTime(1973, 6, 13), Gender = 'F', SickLeaveHours = 43 });
        _employees.Add(new() { ID = 206, Name = "Brian LaMee", Manager = 44, BirthDate = new DateTime(1974, 9, 12), Gender = 'M', SickLeaveHours = 44 });
        _employees.Add(new() { ID = 207, Name = "Kitti Lertpiriyasuwat", Manager = 38, BirthDate = new DateTime(1977, 7, 7), Gender = 'F', SickLeaveHours = 64 });
        _employees.Add(new() { ID = 208, Name = "Jay Adams", Manager = 18, BirthDate = new DateTime(1966, 3, 14), Gender = 'M', SickLeaveHours = 36 });
        _employees.Add(new() { ID = 209, Name = "Jan Miksovsky", Manager = 184, BirthDate = new DateTime(1964, 12, 16), Gender = 'M', SickLeaveHours = 35 });
        _employees.Add(new() { ID = 210, Name = "Brenda Diaz", Manager = 21, BirthDate = new DateTime(1973, 3, 31), Gender = 'F', SickLeaveHours = 55 });
        _employees.Add(new() { ID = 211, Name = "Andrew Cencini", Manager = 123, BirthDate = new DateTime(1978, 10, 26), Gender = 'M', SickLeaveHours = 56 });
        _employees.Add(new() { ID = 212, Name = "Chris Norred", Manager = 90, BirthDate = new DateTime(1977, 6, 26), Gender = 'M', SickLeaveHours = 57 });
        _employees.Add(new() { ID = 213, Name = "Chris Okelberry", Manager = 16, BirthDate = new DateTime(1976, 9, 7), Gender = 'M', SickLeaveHours = 28 });
        _employees.Add(new() { ID = 214, Name = "Shelley Dyck", Manager = 143, BirthDate = new DateTime(1977, 1, 8), Gender = 'F', SickLeaveHours = 27 });
        _employees.Add(new() { ID = 215, Name = "Gabe Mares", Manager = 210, BirthDate = new DateTime(1978, 6, 11), Gender = 'M', SickLeaveHours = 48 });
        _employees.Add(new() { ID = 216, Name = "Mike Seamans", Manager = 139, BirthDate = new DateTime(1969, 8, 1), Gender = 'M', SickLeaveHours = 49 });
        _employees.Add(new() { ID = 217, Name = "Michael Raheem", Manager = 158, BirthDate = new DateTime(1975, 1, 1), Gender = 'M', SickLeaveHours = 64 });
        _employees.Add(new() { ID = 218, Name = "Gary Altman", Manager = 148, BirthDate = new DateTime(1961, 3, 21), Gender = 'M', SickLeaveHours = 63 });
        _employees.Add(new() { ID = 219, Name = "Charles Fitzgerald", Manager = 18, BirthDate = new DateTime(1961, 10, 3), Gender = 'M', SickLeaveHours = 33 });
        _employees.Add(new() { ID = 220, Name = "Ebru Ersan", Manager = 25, BirthDate = new DateTime(1976, 10, 23), Gender = 'M', SickLeaveHours = 66 });
        _employees.Add(new() { ID = 221, Name = "Sylvester Valdez", Manager = 108, BirthDate = new DateTime(1960, 12, 13), Gender = 'M', SickLeaveHours = 22 });
        _employees.Add(new() { ID = 222, Name = "Brian Goldstein", Manager = 51, BirthDate = new DateTime(1961, 1, 23), Gender = 'M', SickLeaveHours = 51 });
        _employees.Add(new() { ID = 223, Name = "Linda Meisner", Manager = 274, BirthDate = new DateTime(1960, 12, 31), Gender = 'F', SickLeaveHours = 48 });
        _employees.Add(new() { ID = 224, Name = "Betsy Stadick", Manager = 64, BirthDate = new DateTime(1957, 1, 17), Gender = 'F', SickLeaveHours = 69 });
        _employees.Add(new() { ID = 225, Name = "Magnus Hedlund", Manager = 218, BirthDate = new DateTime(1961, 9, 27), Gender = 'M', SickLeaveHours = 63 });
        _employees.Add(new() { ID = 226, Name = "Karan Khanna", Manager = 18, BirthDate = new DateTime(1960, 4, 7), Gender = 'M', SickLeaveHours = 34 });
        _employees.Add(new() { ID = 227, Name = "Mary Baker", Manager = 25, BirthDate = new DateTime(1976, 10, 20), Gender = 'F', SickLeaveHours = 67 });
        _employees.Add(new() { ID = 228, Name = "Kevin Homer", Manager = 25, BirthDate = new DateTime(1976, 10, 20), Gender = 'M', SickLeaveHours = 65 });
        _employees.Add(new() { ID = 229, Name = "Mihail Frintu", Manager = 51, BirthDate = new DateTime(1961, 4, 9), Gender = 'M', SickLeaveHours = 52 });
        _employees.Add(new() { ID = 230, Name = "Bonnie Kearney", Manager = 185, BirthDate = new DateTime(1976, 10, 11), Gender = 'F', SickLeaveHours = 64 });
        _employees.Add(new() { ID = 231, Name = "Fukiko Ogisu", Manager = 274, BirthDate = new DateTime(1960, 12, 25), Gender = 'M', SickLeaveHours = 48 });
        _employees.Add(new() { ID = 232, Name = "Hung-Fu Ting", Manager = 108, BirthDate = new DateTime(1961, 11, 23), Gender = 'M', SickLeaveHours = 20 });
        _employees.Add(new() { ID = 233, Name = "Gordon Hee", Manager = 274, BirthDate = new DateTime(1956, 12, 30), Gender = 'M', SickLeaveHours = 46 });
        _employees.Add(new() { ID = 234, Name = "Kimberly Zimmerman", Manager = 64, BirthDate = new DateTime(1976, 10, 14), Gender = 'F', SickLeaveHours = 67 });
        _employees.Add(new() { ID = 235, Name = "Kim Abercrombie", Manager = 16, BirthDate = new DateTime(1957, 1, 14), Gender = 'F', SickLeaveHours = 32 });
        _employees.Add(new() { ID = 236, Name = "Sandeep Kaliyath", Manager = 51, BirthDate = new DateTime(1961, 1, 3), Gender = 'M', SickLeaveHours = 52 });
        _employees.Add(new() { ID = 237, Name = "Prasanna Samarawickrama", Manager = 108, BirthDate = new DateTime(1943, 6, 1), Gender = 'M', SickLeaveHours = 22 });
        _employees.Add(new() { ID = 238, Name = "Frank Pellow", Manager = 274, BirthDate = new DateTime(1942, 6, 13), Gender = 'M', SickLeaveHours = 49 });
        _employees.Add(new() { ID = 239, Name = "Min Su", Manager = 108, BirthDate = new DateTime(1964, 10, 11), Gender = 'M', SickLeaveHours = 20 });
        _employees.Add(new() { ID = 240, Name = "Eric Brown", Manager = 51, BirthDate = new DateTime(1957, 1, 8), Gender = 'M', SickLeaveHours = 50 });
        _employees.Add(new() { ID = 241, Name = "Eric Kurjan", Manager = 274, BirthDate = new DateTime(1962, 10, 19), Gender = 'M', SickLeaveHours = 47 });
        _employees.Add(new() { ID = 242, Name = "Pat Coleman", Manager = 49, BirthDate = new DateTime(1961, 1, 3), Gender = 'M', SickLeaveHours = 64 });
        _employees.Add(new() { ID = 243, Name = "Maciej Dusza", Manager = 18, BirthDate = new DateTime(1945, 3, 2), Gender = 'M', SickLeaveHours = 35 });
        _employees.Add(new() { ID = 244, Name = "Erin Hagens", Manager = 274, BirthDate = new DateTime(1961, 2, 4), Gender = 'F', SickLeaveHours = 46 });
        _employees.Add(new() { ID = 245, Name = "Patrick Wedge", Manager = 64, BirthDate = new DateTime(1976, 10, 11), Gender = 'M', SickLeaveHours = 68 });
        _employees.Add(new() { ID = 246, Name = "Frank Martinez", Manager = 51, BirthDate = new DateTime(1942, 4, 3), Gender = 'M', SickLeaveHours = 53 });
        _employees.Add(new() { ID = 247, Name = "Ed Dudenhoefer", Manager = 16, BirthDate = new DateTime(1961, 10, 12), Gender = 'M', SickLeaveHours = 32 });
        _employees.Add(new() { ID = 248, Name = "Christopher Hill", Manager = 25, BirthDate = new DateTime(1976, 11, 1), Gender = 'M', SickLeaveHours = 65 });
        _employees.Add(new() { ID = 249, Name = "Patrick Cook", Manager = 51, BirthDate = new DateTime(1964, 1, 24), Gender = 'M', SickLeaveHours = 50 });
        _employees.Add(new() { ID = 250, Name = "Krishna Sunkammurali", Manager = 108, BirthDate = new DateTime(1961, 10, 6), Gender = 'M', SickLeaveHours = 21 });
        _employees.Add(new() { ID = 251, Name = "Lori Penor", Manager = 49, BirthDate = new DateTime(1960, 8, 31), Gender = 'F', SickLeaveHours = 65 });
        _employees.Add(new() { ID = 252, Name = "Danielle Tiedt", Manager = 64, BirthDate = new DateTime(1976, 10, 8), Gender = 'F', SickLeaveHours = 68 });
        _employees.Add(new() { ID = 253, Name = "Sootha Charncherngkha", Manager = 41, BirthDate = new DateTime(1957, 1, 5), Gender = 'M', SickLeaveHours = 62 });
        _employees.Add(new() { ID = 254, Name = "Michael Zwilling", Manager = 18, BirthDate = new DateTime(1963, 10, 7), Gender = 'M', SickLeaveHours = 33 });
        _employees.Add(new() { ID = 255, Name = "Randy Reeves", Manager = 18, BirthDate = new DateTime(1960, 5, 29), Gender = 'M', SickLeaveHours = 34 });
        _employees.Add(new() { ID = 256, Name = "John Kane", Manager = 25, BirthDate = new DateTime(1976, 10, 29), Gender = 'M', SickLeaveHours = 66 });
        _employees.Add(new() { ID = 257, Name = "Jack Creasey", Manager = 51, BirthDate = new DateTime(1963, 9, 30), Gender = 'M', SickLeaveHours = 51 });
        _employees.Add(new() { ID = 258, Name = "Olinda Turner", Manager = 108, BirthDate = new DateTime(1960, 5, 5), Gender = 'F', SickLeaveHours = 21 });
        _employees.Add(new() { ID = 259, Name = "Stuart Macrae", Manager = 49, BirthDate = new DateTime(1962, 1, 17), Gender = 'M', SickLeaveHours = 64 });
        _employees.Add(new() { ID = 260, Name = "Jo Berry", Manager = 49, BirthDate = new DateTime(1944, 5, 25), Gender = 'F', SickLeaveHours = 65 });
        _employees.Add(new() { ID = 261, Name = "Ben Miller", Manager = 274, BirthDate = new DateTime(1963, 7, 5), Gender = 'M', SickLeaveHours = 47 });
        _employees.Add(new() { ID = 262, Name = "Tom Vande Velde", Manager = 64, BirthDate = new DateTime(1976, 11, 1), Gender = 'M', SickLeaveHours = 69 });
        _employees.Add(new() { ID = 263, Name = "Ovidiu Cracium", Manager = 3, BirthDate = new DateTime(1968, 2, 18), Gender = 'M', SickLeaveHours = 23 });
        _employees.Add(new() { ID = 264, Name = "Annette Hill", Manager = 274, BirthDate = new DateTime(1968, 3, 1), Gender = 'F', SickLeaveHours = 45 });
        _employees.Add(new() { ID = 265, Name = "Janice Galvin", Manager = 263, BirthDate = new DateTime(1979, 6, 29), Gender = 'F', SickLeaveHours = 24 });
        _employees.Add(new() { ID = 266, Name = "Reinout Hillmann", Manager = 274, BirthDate = new DateTime(1968, 2, 18), Gender = 'M', SickLeaveHours = 45 });
        _employees.Add(new() { ID = 267, Name = "Michael Sullivan", Manager = 3, BirthDate = new DateTime(1969, 7, 17), Gender = 'M', SickLeaveHours = 21 });
        _employees.Add(new() { ID = 268, Name = "Stephen Jiang", Manager = 273, BirthDate = new DateTime(1941, 11, 17), Gender = 'M', SickLeaveHours = 27 });
        _employees.Add(new() { ID = 269, Name = "Wanida Benshoof", Manager = 6, BirthDate = new DateTime(1965, 4, 17), Gender = 'F', SickLeaveHours = 40 });
        _employees.Add(new() { ID = 270, Name = "Sharon Salavaria", Manager = 3, BirthDate = new DateTime(1951, 6, 3), Gender = 'F', SickLeaveHours = 22 });
        _employees.Add(new() { ID = 271, Name = "John Wood", Manager = 6, BirthDate = new DateTime(1968, 4, 6), Gender = 'M', SickLeaveHours = 44 });
        _employees.Add(new() { ID = 272, Name = "Mary Dempsey", Manager = 6, BirthDate = new DateTime(1968, 3, 1), Gender = 'F', SickLeaveHours = 41 });
        _employees.Add(new() { ID = 273, Name = "Brian Welcker", Manager = 109, BirthDate = new DateTime(1967, 7, 8), Gender = 'M', SickLeaveHours = 25 });
        _employees.Add(new() { ID = 274, Name = "Sheela Word", Manager = 71, BirthDate = new DateTime(1968, 3, 13), Gender = 'F', SickLeaveHours = 44 });
        _employees.Add(new() { ID = 275, Name = "Michael Blythe", Manager = 268, BirthDate = new DateTime(1959, 1, 26), Gender = 'M', SickLeaveHours = 39 });
        _employees.Add(new() { ID = 276, Name = "Linda Mitchell", Manager = 268, BirthDate = new DateTime(1970, 3, 30), Gender = 'F', SickLeaveHours = 33 });
        _employees.Add(new() { ID = 277, Name = "Jillian Carson", Manager = 268, BirthDate = new DateTime(1952, 9, 29), Gender = 'F', SickLeaveHours = 32 });
        _employees.Add(new() { ID = 278, Name = "Garrett Vargas", Manager = 268, BirthDate = new DateTime(1965, 3, 7), Gender = 'M', SickLeaveHours = 36 });
        _employees.Add(new() { ID = 279, Name = "Tsvi Reiter", Manager = 268, BirthDate = new DateTime(1964, 2, 19), Gender = 'M', SickLeaveHours = 34 });
        _employees.Add(new() { ID = 280, Name = "Pamela Ansman-Wolfe", Manager = 268, BirthDate = new DateTime(1965, 1, 6), Gender = 'F', SickLeaveHours = 31 });
        _employees.Add(new() { ID = 281, Name = "Shu Ito", Manager = 268, BirthDate = new DateTime(1958, 4, 10), Gender = 'M', SickLeaveHours = 33 });
        _employees.Add(new() { ID = 282, Name = "José Saraiva", Manager = 268, BirthDate = new DateTime(1954, 1, 11), Gender = 'M', SickLeaveHours = 35 });
        _employees.Add(new() { ID = 283, Name = "David Campbell", Manager = 268, BirthDate = new DateTime(1964, 3, 14), Gender = 'M', SickLeaveHours = 31 });
        _employees.Add(new() { ID = 284, Name = "Amy Alberts", Manager = 273, BirthDate = new DateTime(1947, 10, 22), Gender = 'F', SickLeaveHours = 30 });
        _employees.Add(new() { ID = 285, Name = "Jae Pak", Manager = 284, BirthDate = new DateTime(1958, 4, 18), Gender = 'F', SickLeaveHours = 38 });
        _employees.Add(new() { ID = 286, Name = "Ranjit Varkey Chudukatil", Manager = 284, BirthDate = new DateTime(1965, 10, 31), Gender = 'M', SickLeaveHours = 37 });
        _employees.Add(new() { ID = 287, Name = "Tete Mensa-Annan", Manager = 268, BirthDate = new DateTime(1968, 2, 6), Gender = 'M', SickLeaveHours = 39 });
        _employees.Add(new() { ID = 288, Name = "Syed Abbas", Manager = 273, BirthDate = new DateTime(1965, 2, 11), Gender = 'M', SickLeaveHours = 30 });
        _employees.Add(new() { ID = 289, Name = "Rachel Valdez", Manager = 284, BirthDate = new DateTime(1965, 8, 9), Gender = 'F', SickLeaveHours = 37 });
        _employees.Add(new() { ID = 290, Name = "Lynn Tsoflias", Manager = 288, BirthDate = new DateTime(1961, 4, 18), Gender = 'F', SickLeaveHours = 38 });
    }

    private static readonly List<Employee> _employees = new();
    private static readonly List<Product> _products = new();
    private static readonly List<Vendor> _vendors = new();
    private static readonly List<ProductVendor> _productVendors = new();
    private static readonly List<DicePlayer> _dicePlayers = new();

    public static IEnumerable<Employee> Employees => _employees;
    public static IEnumerable<Product> Products => _products;
    public static IEnumerable<Vendor> Vendors => _vendors;
    public static IEnumerable<ProductVendor> ProductVendors => _productVendors;
    public static IEnumerable<DicePlayer> DicePlayers => _dicePlayers;

    public static IEnumerable<BuildingCategory> BuildingCategories { get; } =
        new List<BuildingCategory> {
                new () { Category = "Apartment", Description = "A room or set of rooms fitted especially with housekeeping facilities and usually leased as a dwelling"},
                new () { Category = "House", Description = "A building that serves as living quarters for one or a few families "},
                new () { Category = "Garage", Description = "A shelter or repair shop for automotive vehicles"},
                new () { Category = "Construction Field", Description = "An area, usually a land or lot, designated for construction of buildings"},
                new () { Category = "Storage Area", Description = "Space or a place for storing in multiple rooms"},
                new () { Category = "Storage Room", Description = "A room for storing"},
                new () { Category = "Berth", Description = "the place where a ship lies when at anchor or at a wharf"},
                new () { Category = "Underground Area", Description = "Area beneath the surface of the earth"},
                new () { Category = "Swamp", Description = "Only Shrek lives here and there are no places for sale. GET. OUT. OF. MY. SWAMP!"},
        };
    public static IEnumerable<Building> Buildings { get; } =
        new List<Building> {
                new () { BuildingID = 1, Address = "Chai", Category = "Apartment", Price = 180_000M, SquareMeters = 39 },
                new () { BuildingID = 2, Address = "Chang", Category = "Apartment", Price = 190_000M, SquareMeters = 17 },
                new () { BuildingID = 3, Address = "Aniseed Syrup", Category = "House", Price = 10_0000M, SquareMeters = 13 },
                new () { BuildingID = 4, Address = "Chef Anton's Cajun Seasoning", Category = "House", Price = 22_0000M, SquareMeters = 53 },
                new () { BuildingID = 5, Address = "Chef Anton's Gumbo Mix", Category = "House", Price = 21_3500M, SquareMeters = 0 },
                new () { BuildingID = 6, Address = "Grandma's Boysenberry Spread", Category = "House", Price = 25_0000M, SquareMeters = 120 },
                new () { BuildingID = 7, Address = "Uncle Bob's Organic Dried Pears", Category = "Garage", Price = 30_0000M, SquareMeters = 15 },
                new () { BuildingID = 8, Address = "Northwoods Cranberry Sauce", Category = "House", Price = 40_0000M, SquareMeters = 6 },
                new () { BuildingID = 9, Address = "Mishi Kobe Niku", Category = "Construction Field", Price = 97_0000M, SquareMeters = 29 },
                new () { BuildingID = 10, Address = "Ikura", Category = "Storage Area", Price = 310_000M, SquareMeters = 31 },
                new () { BuildingID = 11, Address = "Queso Cabrales", Category = "Storage Room", Price = 210_000M, SquareMeters = 22 },
                new () { BuildingID = 12, Address = "Queso Manchego La Pastora", Category = "Storage Room", Price = 380_000M, SquareMeters = 86 },
                new () { BuildingID = 13, Address = "Konbu", Category = "Storage Area", Price = 60_000M, SquareMeters = 24 },
                new () { BuildingID = 14, Address = "Tofu", Category = "Garage", Price = 530_000M, SquareMeters = 35 },
                new () { BuildingID = 15, Address = "Genen Shouyu", Category = "House", Price = 155_000M, SquareMeters = 39 },
                new () { BuildingID = 16, Address = "Pavlova", Category = "Berth", Price = 174_500M, SquareMeters = 29 },
                new () { BuildingID = 17, Address = "Alice Mutton", Category = "Construction Field", Price = 390_000M, SquareMeters = 0 },
                new () { BuildingID = 18, Address = "Carnarvon Tigers", Category = "Storage Area", Price = 625_000M, SquareMeters = 42 },
                new () { BuildingID = 19, Address = "Teatime Chocolate Biscuits", Category = "Berth", Price = 92_000M, SquareMeters = 25 },
                new () { BuildingID = 20, Address = "Sir Rodney's Marmalade", Category = "Berth", Price = 810_000M, SquareMeters = 40 },
                new () { BuildingID = 21, Address = "Sir Rodney's Scones", Category = "Berth", Price = 100_000M, SquareMeters = 3 },
                new () { BuildingID = 22, Address = "Gustaf's Knäckebröd", Category = "Underground Area", Price = 210_000M, SquareMeters = 104 },
                new () { BuildingID = 23, Address = "Tunnbröd", Category = "Underground Area", Price = 90_000M, SquareMeters = 61 },
                new () { BuildingID = 24, Address = "Guaraná Fantástica", Category = "Apartment", Price = 45_000M, SquareMeters = 20 },
                new () { BuildingID = 25, Address = "NuNuCa Nuß-Nougat-Creme", Category = "Berth", Price = 140_000M, SquareMeters = 76 },
                new () { BuildingID = 26, Address = "Gumbär Gummibärchen", Category = "Berth", Price = 312_300M, SquareMeters = 15 },
                new () { BuildingID = 27, Address = "Schoggi Schokolade", Category = "Berth", Price = 439_000M, SquareMeters = 49 },
                new () { BuildingID = 28, Address = "Rössle Sauerkraut", Category = "Garage", Price = 456_000M, SquareMeters = 26 },
                new () { BuildingID = 29, Address = "Thüringer Rostbratwurst", Category = "Construction Field", Price = 1_237_900M, SquareMeters = 1500 },
                new () { BuildingID = 30, Address = "Nord-Ost Matjeshering", Category = "Storage Area", Price = 258_900M, SquareMeters = 10 },
                new () { BuildingID = 31, Address = "Gorgonzola Telino", Category = "Storage Room", Price = 125_000M, SquareMeters = 0 },
                new () { BuildingID = 32, Address = "Mascarpone Fabioli", Category = "Storage Room", Price = 320_000M, SquareMeters = 9 },
                new () { BuildingID = 33, Address = "Geitost", Category = "Storage Room", Price = 25_000M, SquareMeters = 112 },
                new () { BuildingID = 34, Address = "Sasquatch Ale", Category = "Apartment", Price = 140_000M, SquareMeters = 111 },
                new () { BuildingID = 35, Address = "Steeleye Stout", Category = "Apartment", Price = 180_000M, SquareMeters = 20 },
                new () { BuildingID = 36, Address = "Inlagd Sill", Category = "Storage Area", Price = 190_000M, SquareMeters = 112 },
                new () { BuildingID = 37, Address = "Gravad lax", Category = "Storage Area", Price = 260_000M, SquareMeters = 11 },
                new () { BuildingID = 38, Address = "Côte de Blaye", Category = "Apartment", Price = 2_635_000M, SquareMeters = 700 },
                new () { BuildingID = 39, Address = "Chartreuse verte", Category = "Apartment", Price = 180_000M, SquareMeters = 269 },
                new () { BuildingID = 40, Address = "Boston Crab Meat", Category = "Storage Area", Price = 184_000M, SquareMeters = 123 },
                new () { BuildingID = 41, Address = "Jack's New England Clam Chowder", Category = "Storage Area", Price = 96_500M, SquareMeters = 85 },
                new () { BuildingID = 42, Address = "Singaporean Hokkien Fried Mee", Category = "Underground Area", Price = 140_000M, SquareMeters = 26 },
                new () { BuildingID = 43, Address = "Ipoh Coffee", Category = "Apartment", Price = 460_000M, SquareMeters = 17 },
                new () { BuildingID = 44, Address = "Gula Malacca", Category = "House", Price = 194_500M, SquareMeters = 27 },
                new () { BuildingID = 45, Address = "Rogede sild", Category = "Storage Area", Price = 95_000M, SquareMeters = 5 },
                new () { BuildingID = 46, Address = "Spegesild", Category = "Storage Area", Price = 120_000M, SquareMeters = 95 },
                new () { BuildingID = 47, Address = "Zaanse koeken", Category = "Berth", Price = 95_000M, SquareMeters = 36 },
                new () { BuildingID = 48, Address = "Chocolade", Category = "Berth", Price = 127_500M, SquareMeters = 15 },
                new () { BuildingID = 49, Address = "Maxilaku", Category = "Berth", Price = 200_000M, SquareMeters = 10 },
                new () { BuildingID = 50, Address = "Valkoinen suklaa", Category = "Berth", Price = 162_500M, SquareMeters = 65 },
                new () { BuildingID = 51, Address = "Manjimup Dried Apples", Category = "Garage", Price = 530_000M, SquareMeters = 20 },
                new () { BuildingID = 52, Address = "Filo Mix", Category = "Underground Area", Price = 70_000M, SquareMeters = 38 },
                new () { BuildingID = 53, Address = "Perth Pasties", Category = "Construction Field", Price = 328_000M, SquareMeters = 0 },
                new () { BuildingID = 54, Address = "Tourtière", Category = "Construction Field", Price = 74_500M, SquareMeters = 21 },
                new () { BuildingID = 55, Address = "Pâté chinois", Category = "Construction Field", Price = 240_000M, SquareMeters = 115 },
                new () { BuildingID = 56, Address = "Gnocchi di nonna Alice", Category = "Underground Area", Price = 380_000M, SquareMeters = 21 },
                new () { BuildingID = 57, Address = "Ravioli Angelo", Category = "Underground Area", Price = 195_000M, SquareMeters = 36 },
                new () { BuildingID = 58, Address = "Escargots de Bourgogne", Category = "Storage Area", Price = 132_500M, SquareMeters = 62 },
                new () { BuildingID = 59, Address = "Raclette Courdavault", Category = "Storage Room", Price = 550_000M, SquareMeters = 79 },
                new () { BuildingID = 60, Address = "Camembert Pierrot", Category = "Storage Room", Price = 340_000M, SquareMeters = 19 },
                new () { BuildingID = 61, Address = "Sirop d'érable", Category = "House", Price = 285_000M, SquareMeters = 113 },
                new () { BuildingID = 62, Address = "Tarte au sucre", Category = "Berth", Price = 493_000M, SquareMeters = 17 },
                new () { BuildingID = 63, Address = "Vegie-spread", Category = "House", Price = 439_000M, SquareMeters = 24 },
                new () { BuildingID = 64, Address = "Wimmers gute Semmelknödel", Category = "Underground Area", Price = 332_500M, SquareMeters = 22 },
                new () { BuildingID = 65, Address = "Louisiana Fiery Hot Pepper Sauce", Category = "House", Price = 210_500M, SquareMeters = 76 },
                new () { BuildingID = 66, Address = "Louisiana Hot Spiced Okra", Category = "House", Price = 170_000M, SquareMeters = 4 },
                new () { BuildingID = 67, Address = "Laughing Lumberjack Lager", Category = "Apartment", Price = 140_000M, SquareMeters = 52 },
                new () { BuildingID = 68, Address = "Scottish Longbreads", Category = "Berth", Price = 125_000M, SquareMeters = 6 },
                new () { BuildingID = 69, Address = "Gudbrandsdalsost", Category = "Storage Room", Price = 360_000M, SquareMeters = 26 },
                new () { BuildingID = 70, Address = "Outback Lager", Category = "Apartment", Price = 150_000M, SquareMeters = 15 },
                new () { BuildingID = 71, Address = "Flotemysost", Category = "Storage Room", Price = 215_000M, SquareMeters = 26 },
                new () { BuildingID = 72, Address = "Mozzarella di Giovanni", Category = "Storage Room", Price = 348_000M, SquareMeters = 14 },
                new () { BuildingID = 73, Address = "Röd Kaviar", Category = "Storage Area", Price = 150_000M, SquareMeters = 101 },
                new () { BuildingID = 74, Address = "Longlife Tofu", Category = "Garage", Price = 100_000M, SquareMeters = 4 },
                new () { BuildingID = 75, Address = "Rhönbräu Klosterbier", Category = "Apartment", Price = 77_500M, SquareMeters = 125 },
                new () { BuildingID = 76, Address = "Lakkalikööri", Category = "Apartment", Price = 180_000M, SquareMeters = 57 },
                new () { BuildingID = 77, Address = "Original Frankfurter grüne Soße", Category = "House", Price = 130_000M, SquareMeters = 32 }
        };

    public static string RoyalTitle { get => "His Royal Highness The Prince Philip, Duke of Edinburgh, Earl of Merioneth, Baron Greenwich, Royal Knight of the Most Noble Order of the Garter, Extra Knight of the Most Ancient and Most Noble Order of the Thistle, Member of the Order of Merit, Grand Master and First and Principal Knight Grand Cross of the Most Excellent Order of the British Empire, Knight of the Order of Australia, Additional Member of the Order of New Zealand, Extra Companion of the Queen’s Service Order, Royal Chief of the Order of Logohu, Extraordinary Companion of the Order of Canada, Extraordinary Commander of the Order of Military Merit, Lord of Her Majesty’s Most Honourable Privy Council, Privy Councillor of the Queen’s Privy Council for Canada, Personal Aide-de-Camp to Her Majesty, Lord High Admiral of the United Kingdom"; }
    public static IEnumerable<string> RoyalTitleWords { get => RoyalTitle.Replace(",", "").Split(); }
    public static IEnumerable<string> RoyalTitleTitles { get => RoyalTitle.Split(','); }

}
