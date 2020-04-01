﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataHelper
{
    public static class DataSource
    {

        static DataSource()
        {
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

        private static void GenerateVendors()
        {
            _Vendors.Add(new Vendor { ID = 1, Name = "International" });
            _Vendors.Add(new Vendor { ID = 2, Name = "Electronic Bike Repair & Supplies" });
            _Vendors.Add(new Vendor { ID = 3, Name = "Premier Sport, Inc." });
            _Vendors.Add(new Vendor { ID = 4, Name = "Comfort Road Bicycles" });
            _Vendors.Add(new Vendor { ID = 5, Name = "Metro Sport Equipment" });
            _Vendors.Add(new Vendor { ID = 6, Name = "Green Lake Bike Company" });
            _Vendors.Add(new Vendor { ID = 7, Name = "Mountain Works" });
            _Vendors.Add(new Vendor { ID = 8, Name = "Continental Pro Cycles" });
            _Vendors.Add(new Vendor { ID = 10, Name = "Trey Research" });
            _Vendors.Add(new Vendor { ID = 11, Name = "Anderson's Custom Bikes" });
            _Vendors.Add(new Vendor { ID = 12, Name = "Compete, Inc." });
            _Vendors.Add(new Vendor { ID = 13, Name = "Beaumont Bikes" });
            _Vendors.Add(new Vendor { ID = 15, Name = "SUPERSALES INC." });
            _Vendors.Add(new Vendor { ID = 17, Name = "Compete Enterprises, Inc" });
            _Vendors.Add(new Vendor { ID = 18, Name = "G & K Bicycle Corp." });
            _Vendors.Add(new Vendor { ID = 20, Name = "Jeff's Sporting Goods" });
            _Vendors.Add(new Vendor { ID = 21, Name = "Business Equipment Center" });
            _Vendors.Add(new Vendor { ID = 22, Name = "Victory Bikes" });
            _Vendors.Add(new Vendor { ID = 23, Name = "Norstan Bike Hut" });
            _Vendors.Add(new Vendor { ID = 24, Name = "First Rate Bicycles" });
            _Vendors.Add(new Vendor { ID = 25, Name = "Ready Rentals" });
            _Vendors.Add(new Vendor { ID = 26, Name = "First National Sport Co." });
            _Vendors.Add(new Vendor { ID = 27, Name = "Capital Road Cycles" });
            _Vendors.Add(new Vendor { ID = 28, Name = "Wide World Importers" });
            _Vendors.Add(new Vendor { ID = 29, Name = "Integrated Sport Products" });
            _Vendors.Add(new Vendor { ID = 30, Name = "Consumer Cycles" });
            _Vendors.Add(new Vendor { ID = 31, Name = "Federal Sport" });
            _Vendors.Add(new Vendor { ID = 32, Name = "Advanced Bicycles" });
            _Vendors.Add(new Vendor { ID = 33, Name = "Signature Cycles" });
            _Vendors.Add(new Vendor { ID = 35, Name = "Mitchell Sports" });
            _Vendors.Add(new Vendor { ID = 37, Name = "Inner City Bikes" });
            _Vendors.Add(new Vendor { ID = 38, Name = "Allenson Cycles" });
            _Vendors.Add(new Vendor { ID = 39, Name = "Hill's Bicycle Service" });
            _Vendors.Add(new Vendor { ID = 40, Name = "West Junction Cycles" });
            _Vendors.Add(new Vendor { ID = 41, Name = "Speed Corporation" });
            _Vendors.Add(new Vendor { ID = 43, Name = "Inline Accessories" });
            _Vendors.Add(new Vendor { ID = 44, Name = "Competition Bike Training Systems" });
            _Vendors.Add(new Vendor { ID = 45, Name = "Chicago City Saddles" });
            _Vendors.Add(new Vendor { ID = 46, Name = "Burnett Road Warriors" });
            _Vendors.Add(new Vendor { ID = 47, Name = "Bike Satellite Inc." });
            _Vendors.Add(new Vendor { ID = 48, Name = "Gardner Touring Cycles" });
            _Vendors.Add(new Vendor { ID = 50, Name = "Vision Cycles, Inc." });
            _Vendors.Add(new Vendor { ID = 51, Name = "Bergeron Off-Roads" });
            _Vendors.Add(new Vendor { ID = 52, Name = "Hybrid Bicycle Center" });
            _Vendors.Add(new Vendor { ID = 53, Name = "Jackson Authority" });
            _Vendors.Add(new Vendor { ID = 54, Name = "Pro Sport Industries" });
            _Vendors.Add(new Vendor { ID = 55, Name = "Sport Fan Co." });
            _Vendors.Add(new Vendor { ID = 56, Name = "International Bicycles" });
            _Vendors.Add(new Vendor { ID = 57, Name = "Wood Fitness" });
            _Vendors.Add(new Vendor { ID = 58, Name = "Midwest Sport, Inc." });
            _Vendors.Add(new Vendor { ID = 60, Name = "International Sport Assoc." });
            _Vendors.Add(new Vendor { ID = 61, Name = "Lindell" });
            _Vendors.Add(new Vendor { ID = 62, Name = "Training Systems" });
            _Vendors.Add(new Vendor { ID = 64, Name = "Circuit Cycles" });
            _Vendors.Add(new Vendor { ID = 65, Name = "International Trek Center" });
            _Vendors.Add(new Vendor { ID = 66, Name = "Lakewood Bicycle" });
            _Vendors.Add(new Vendor { ID = 68, Name = "Leaf River Terrain" });
            _Vendors.Add(new Vendor { ID = 69, Name = "National Bike Association" });
            _Vendors.Add(new Vendor { ID = 70, Name = "Sport Playground" });
            _Vendors.Add(new Vendor { ID = 71, Name = "Vista Road Bikes" });
            _Vendors.Add(new Vendor { ID = 72, Name = "Varsity Sport Co." });
            _Vendors.Add(new Vendor { ID = 73, Name = "Crowley Sport" });
            _Vendors.Add(new Vendor { ID = 74, Name = "Australia Bike Retailer" });
            _Vendors.Add(new Vendor { ID = 75, Name = "Northern Bike Travel" });
            _Vendors.Add(new Vendor { ID = 76, Name = "Cruger Bike Company" });
            _Vendors.Add(new Vendor { ID = 77, Name = "Custom Frames, Inc." });
            _Vendors.Add(new Vendor { ID = 78, Name = "Aurora Bike Center" });
            _Vendors.Add(new Vendor { ID = 80, Name = "Bicycle Specialists" });
            _Vendors.Add(new Vendor { ID = 81, Name = "Bloomington Multisport" });
            _Vendors.Add(new Vendor { ID = 83, Name = "Litware, Inc." });
            _Vendors.Add(new Vendor { ID = 84, Name = "Proseware, Inc." });
            _Vendors.Add(new Vendor { ID = 85, Name = "American Bicycles and Wheels" });
            _Vendors.Add(new Vendor { ID = 86, Name = "Carlson Specialties" });
            _Vendors.Add(new Vendor { ID = 87, Name = "Expert Bike Co" });
            _Vendors.Add(new Vendor { ID = 88, Name = "Greenwood Athletic Company" });
            _Vendors.Add(new Vendor { ID = 90, Name = "Reliance Fitness, Inc." });
            _Vendors.Add(new Vendor { ID = 91, Name = "WestAmerica Bicycle Co." });
            _Vendors.Add(new Vendor { ID = 92, Name = "American Bikes" });
            _Vendors.Add(new Vendor { ID = 93, Name = "Chicago Rent-All" });
            _Vendors.Add(new Vendor { ID = 94, Name = "Superior Bicycles" });
            _Vendors.Add(new Vendor { ID = 95, Name = "Team Athletic Co." });
            _Vendors.Add(new Vendor { ID = 96, Name = "Hill Bicycle Center" });
            _Vendors.Add(new Vendor { ID = 98, Name = "Trikes, Inc." });
            _Vendors.Add(new Vendor { ID = 102, Name = "Fitness Association" });
            _Vendors.Add(new Vendor { ID = 103, Name = "Morgan Bike Accessories" });
            _Vendors.Add(new Vendor { ID = 104, Name = "Professional Athletic Consultants" });
        }

        private static void GenerateProductVendors()
        {
            _ProductVendors.Add(new ProductVendor { ProductID = 1, VendorID = 83, Price = 47.87M });
            _ProductVendors.Add(new ProductVendor { ProductID = 2, VendorID = 57, Price = 39.92M });
            _ProductVendors.Add(new ProductVendor { ProductID = 4, VendorID = 85, Price = 54.31M });
            _ProductVendors.Add(new ProductVendor { ProductID = 317, VendorID = 50, Price = 28.17M });
            _ProductVendors.Add(new ProductVendor { ProductID = 317, VendorID = 84, Price = 25.77M });
            _ProductVendors.Add(new ProductVendor { ProductID = 318, VendorID = 50, Price = 34.38M });
            _ProductVendors.Add(new ProductVendor { ProductID = 318, VendorID = 84, Price = 31.98M });
            _ProductVendors.Add(new ProductVendor { ProductID = 319, VendorID = 40, Price = 44.21M });
            _ProductVendors.Add(new ProductVendor { ProductID = 319, VendorID = 50, Price = 46.27M });
            _ProductVendors.Add(new ProductVendor { ProductID = 319, VendorID = 84, Price = 43.87M });
            _ProductVendors.Add(new ProductVendor { ProductID = 320, VendorID = 13, Price = 45.21M });
            _ProductVendors.Add(new ProductVendor { ProductID = 320, VendorID = 47, Price = 43.21M });
            _ProductVendors.Add(new ProductVendor { ProductID = 320, VendorID = 62, Price = 47.28M });
            _ProductVendors.Add(new ProductVendor { ProductID = 321, VendorID = 13, Price = 40.76M });
            _ProductVendors.Add(new ProductVendor { ProductID = 321, VendorID = 47, Price = 38.56M });
            _ProductVendors.Add(new ProductVendor { ProductID = 321, VendorID = 62, Price = 42.21M });
            _ProductVendors.Add(new ProductVendor { ProductID = 322, VendorID = 13, Price = 24.21M });
            _ProductVendors.Add(new ProductVendor { ProductID = 322, VendorID = 47, Price = 25.11M });
            _ProductVendors.Add(new ProductVendor { ProductID = 322, VendorID = 62, Price = 27.33M });
            _ProductVendors.Add(new ProductVendor { ProductID = 323, VendorID = 21, Price = 47.87M });
            _ProductVendors.Add(new ProductVendor { ProductID = 325, VendorID = 15, Price = 0.20M });
            _ProductVendors.Add(new ProductVendor { ProductID = 326, VendorID = 15, Price = 0.20M });
            _ProductVendors.Add(new ProductVendor { ProductID = 332, VendorID = 70, Price = 10.30M });
            _ProductVendors.Add(new ProductVendor { ProductID = 341, VendorID = 8, Price = 39.21M });
            _ProductVendors.Add(new ProductVendor { ProductID = 341, VendorID = 41, Price = 45.21M });
            _ProductVendors.Add(new ProductVendor { ProductID = 341, VendorID = 90, Price = 45.31M });
            _ProductVendors.Add(new ProductVendor { ProductID = 342, VendorID = 8, Price = 37.21M });
            _ProductVendors.Add(new ProductVendor { ProductID = 342, VendorID = 41, Price = 43.21M });
            _ProductVendors.Add(new ProductVendor { ProductID = 342, VendorID = 90, Price = 43.31M });
            _ProductVendors.Add(new ProductVendor { ProductID = 343, VendorID = 8, Price = 41.28M });
            _ProductVendors.Add(new ProductVendor { ProductID = 343, VendorID = 41, Price = 47.28M });
            _ProductVendors.Add(new ProductVendor { ProductID = 343, VendorID = 90, Price = 47.38M });
            _ProductVendors.Add(new ProductVendor { ProductID = 344, VendorID = 8, Price = 37.21M });
            _ProductVendors.Add(new ProductVendor { ProductID = 344, VendorID = 41, Price = 43.21M });
            _ProductVendors.Add(new ProductVendor { ProductID = 344, VendorID = 90, Price = 43.31M });
            _ProductVendors.Add(new ProductVendor { ProductID = 345, VendorID = 8, Price = 35.21M });
            _ProductVendors.Add(new ProductVendor { ProductID = 345, VendorID = 41, Price = 41.21M });
            _ProductVendors.Add(new ProductVendor { ProductID = 345, VendorID = 90, Price = 41.31M });
            _ProductVendors.Add(new ProductVendor { ProductID = 346, VendorID = 8, Price = 39.28M });
            _ProductVendors.Add(new ProductVendor { ProductID = 346, VendorID = 41, Price = 45.28M });
            _ProductVendors.Add(new ProductVendor { ProductID = 346, VendorID = 90, Price = 45.38M });
            _ProductVendors.Add(new ProductVendor { ProductID = 347, VendorID = 8, Price = 35.21M });
            _ProductVendors.Add(new ProductVendor { ProductID = 347, VendorID = 41, Price = 41.21M });
            _ProductVendors.Add(new ProductVendor { ProductID = 347, VendorID = 90, Price = 41.31M });
            _ProductVendors.Add(new ProductVendor { ProductID = 348, VendorID = 8, Price = 33.21M });
            _ProductVendors.Add(new ProductVendor { ProductID = 348, VendorID = 41, Price = 39.21M });
            _ProductVendors.Add(new ProductVendor { ProductID = 348, VendorID = 90, Price = 39.31M });
            _ProductVendors.Add(new ProductVendor { ProductID = 349, VendorID = 8, Price = 37.28M });
            _ProductVendors.Add(new ProductVendor { ProductID = 349, VendorID = 41, Price = 43.28M });
            _ProductVendors.Add(new ProductVendor { ProductID = 349, VendorID = 90, Price = 43.38M });
            _ProductVendors.Add(new ProductVendor { ProductID = 351, VendorID = 12, Price = 5.90M });
            _ProductVendors.Add(new ProductVendor { ProductID = 351, VendorID = 64, Price = 5.50M });
            _ProductVendors.Add(new ProductVendor { ProductID = 352, VendorID = 12, Price = 1.40M });
            _ProductVendors.Add(new ProductVendor { ProductID = 352, VendorID = 64, Price = 1.10M });
            _ProductVendors.Add(new ProductVendor { ProductID = 355, VendorID = 17, Price = 1.30M });
            _ProductVendors.Add(new ProductVendor { ProductID = 356, VendorID = 48, Price = 3.43M });
            _ProductVendors.Add(new ProductVendor { ProductID = 356, VendorID = 69, Price = 3.22M });
            _ProductVendors.Add(new ProductVendor { ProductID = 357, VendorID = 48, Price = 3.79M });
            _ProductVendors.Add(new ProductVendor { ProductID = 357, VendorID = 69, Price = 4.11M });
            _ProductVendors.Add(new ProductVendor { ProductID = 358, VendorID = 103, Price = 6.65M });
            _ProductVendors.Add(new ProductVendor { ProductID = 359, VendorID = 32, Price = 45.41M });
            _ProductVendors.Add(new ProductVendor { ProductID = 359, VendorID = 91, Price = 45.26M });
            _ProductVendors.Add(new ProductVendor { ProductID = 360, VendorID = 32, Price = 43.41M });
            _ProductVendors.Add(new ProductVendor { ProductID = 360, VendorID = 91, Price = 43.26M });
            _ProductVendors.Add(new ProductVendor { ProductID = 361, VendorID = 32, Price = 47.48M });
            _ProductVendors.Add(new ProductVendor { ProductID = 361, VendorID = 91, Price = 47.33M });
            _ProductVendors.Add(new ProductVendor { ProductID = 362, VendorID = 32, Price = 43.41M });
            _ProductVendors.Add(new ProductVendor { ProductID = 362, VendorID = 91, Price = 43.26M });
            _ProductVendors.Add(new ProductVendor { ProductID = 363, VendorID = 32, Price = 41.41M });
            _ProductVendors.Add(new ProductVendor { ProductID = 363, VendorID = 91, Price = 41.26M });
            _ProductVendors.Add(new ProductVendor { ProductID = 364, VendorID = 32, Price = 45.48M });
            _ProductVendors.Add(new ProductVendor { ProductID = 364, VendorID = 91, Price = 45.33M });
            _ProductVendors.Add(new ProductVendor { ProductID = 365, VendorID = 32, Price = 41.41M });
            _ProductVendors.Add(new ProductVendor { ProductID = 365, VendorID = 91, Price = 41.26M });
            _ProductVendors.Add(new ProductVendor { ProductID = 366, VendorID = 32, Price = 39.41M });
            _ProductVendors.Add(new ProductVendor { ProductID = 366, VendorID = 91, Price = 39.26M });
            _ProductVendors.Add(new ProductVendor { ProductID = 367, VendorID = 32, Price = 43.48M });
            _ProductVendors.Add(new ProductVendor { ProductID = 367, VendorID = 91, Price = 43.33M });
            _ProductVendors.Add(new ProductVendor { ProductID = 368, VendorID = 32, Price = 39.41M });
            _ProductVendors.Add(new ProductVendor { ProductID = 368, VendorID = 91, Price = 39.26M });
            _ProductVendors.Add(new ProductVendor { ProductID = 369, VendorID = 32, Price = 37.41M });
            _ProductVendors.Add(new ProductVendor { ProductID = 369, VendorID = 91, Price = 37.26M });
            _ProductVendors.Add(new ProductVendor { ProductID = 370, VendorID = 32, Price = 41.48M });
            _ProductVendors.Add(new ProductVendor { ProductID = 370, VendorID = 91, Price = 41.33M });
            _ProductVendors.Add(new ProductVendor { ProductID = 371, VendorID = 32, Price = 37.41M });
            _ProductVendors.Add(new ProductVendor { ProductID = 371, VendorID = 91, Price = 37.26M });
            _ProductVendors.Add(new ProductVendor { ProductID = 372, VendorID = 32, Price = 35.41M });
            _ProductVendors.Add(new ProductVendor { ProductID = 372, VendorID = 91, Price = 35.26M });
            _ProductVendors.Add(new ProductVendor { ProductID = 373, VendorID = 32, Price = 39.48M });
            _ProductVendors.Add(new ProductVendor { ProductID = 373, VendorID = 91, Price = 39.33M });
            _ProductVendors.Add(new ProductVendor { ProductID = 374, VendorID = 32, Price = 35.41M });
            _ProductVendors.Add(new ProductVendor { ProductID = 374, VendorID = 91, Price = 35.26M });
            _ProductVendors.Add(new ProductVendor { ProductID = 375, VendorID = 7, Price = 41.21M });
            _ProductVendors.Add(new ProductVendor { ProductID = 375, VendorID = 23, Price = 41.21M });
            _ProductVendors.Add(new ProductVendor { ProductID = 375, VendorID = 76, Price = 41.28M });
            _ProductVendors.Add(new ProductVendor { ProductID = 376, VendorID = 7, Price = 45.28M });
            _ProductVendors.Add(new ProductVendor { ProductID = 376, VendorID = 23, Price = 39.21M });
            _ProductVendors.Add(new ProductVendor { ProductID = 376, VendorID = 76, Price = 37.21M });
            _ProductVendors.Add(new ProductVendor { ProductID = 377, VendorID = 7, Price = 41.21M });
            _ProductVendors.Add(new ProductVendor { ProductID = 377, VendorID = 23, Price = 43.28M });
            _ProductVendors.Add(new ProductVendor { ProductID = 377, VendorID = 76, Price = 35.21M });
            _ProductVendors.Add(new ProductVendor { ProductID = 378, VendorID = 7, Price = 39.21M });
            _ProductVendors.Add(new ProductVendor { ProductID = 378, VendorID = 23, Price = 39.21M });
            _ProductVendors.Add(new ProductVendor { ProductID = 378, VendorID = 76, Price = 39.28M });
            _ProductVendors.Add(new ProductVendor { ProductID = 379, VendorID = 7, Price = 43.28M });
            _ProductVendors.Add(new ProductVendor { ProductID = 379, VendorID = 23, Price = 37.21M });
            _ProductVendors.Add(new ProductVendor { ProductID = 379, VendorID = 76, Price = 35.21M });
            _ProductVendors.Add(new ProductVendor { ProductID = 380, VendorID = 7, Price = 39.21M });
            _ProductVendors.Add(new ProductVendor { ProductID = 380, VendorID = 23, Price = 41.28M });
            _ProductVendors.Add(new ProductVendor { ProductID = 380, VendorID = 76, Price = 41.16M });
            _ProductVendors.Add(new ProductVendor { ProductID = 381, VendorID = 7, Price = 37.21M });
            _ProductVendors.Add(new ProductVendor { ProductID = 381, VendorID = 23, Price = 37.21M });
            _ProductVendors.Add(new ProductVendor { ProductID = 381, VendorID = 76, Price = 45.23M });
            _ProductVendors.Add(new ProductVendor { ProductID = 382, VendorID = 23, Price = 35.21M });
            _ProductVendors.Add(new ProductVendor { ProductID = 382, VendorID = 76, Price = 41.21M });
            _ProductVendors.Add(new ProductVendor { ProductID = 383, VendorID = 23, Price = 39.28M });
            _ProductVendors.Add(new ProductVendor { ProductID = 383, VendorID = 76, Price = 45.28M });
            _ProductVendors.Add(new ProductVendor { ProductID = 384, VendorID = 23, Price = 35.21M });
            _ProductVendors.Add(new ProductVendor { ProductID = 384, VendorID = 76, Price = 41.21M });
            _ProductVendors.Add(new ProductVendor { ProductID = 385, VendorID = 23, Price = 41.16M });
            _ProductVendors.Add(new ProductVendor { ProductID = 385, VendorID = 76, Price = 39.21M });
            _ProductVendors.Add(new ProductVendor { ProductID = 386, VendorID = 23, Price = 45.23M });
            _ProductVendors.Add(new ProductVendor { ProductID = 386, VendorID = 76, Price = 43.28M });
            _ProductVendors.Add(new ProductVendor { ProductID = 387, VendorID = 23, Price = 41.21M });
            _ProductVendors.Add(new ProductVendor { ProductID = 387, VendorID = 76, Price = 39.21M });
            _ProductVendors.Add(new ProductVendor { ProductID = 388, VendorID = 23, Price = 45.28M });
            _ProductVendors.Add(new ProductVendor { ProductID = 388, VendorID = 76, Price = 37.21M });
            _ProductVendors.Add(new ProductVendor { ProductID = 389, VendorID = 23, Price = 41.21M });
            _ProductVendors.Add(new ProductVendor { ProductID = 389, VendorID = 76, Price = 41.28M });
            _ProductVendors.Add(new ProductVendor { ProductID = 390, VendorID = 23, Price = 39.21M });
            _ProductVendors.Add(new ProductVendor { ProductID = 390, VendorID = 76, Price = 37.21M });
            _ProductVendors.Add(new ProductVendor { ProductID = 391, VendorID = 23, Price = 43.28M });
            _ProductVendors.Add(new ProductVendor { ProductID = 391, VendorID = 76, Price = 35.21M });
            _ProductVendors.Add(new ProductVendor { ProductID = 392, VendorID = 23, Price = 39.21M });
            _ProductVendors.Add(new ProductVendor { ProductID = 392, VendorID = 76, Price = 39.28M });
            _ProductVendors.Add(new ProductVendor { ProductID = 393, VendorID = 23, Price = 37.21M });
            _ProductVendors.Add(new ProductVendor { ProductID = 393, VendorID = 76, Price = 35.21M });
            _ProductVendors.Add(new ProductVendor { ProductID = 394, VendorID = 23, Price = 41.28M });
            _ProductVendors.Add(new ProductVendor { ProductID = 394, VendorID = 76, Price = 41.16M });
            _ProductVendors.Add(new ProductVendor { ProductID = 395, VendorID = 23, Price = 37.21M });
            _ProductVendors.Add(new ProductVendor { ProductID = 395, VendorID = 76, Price = 45.23M });
            _ProductVendors.Add(new ProductVendor { ProductID = 396, VendorID = 23, Price = 35.21M });
            _ProductVendors.Add(new ProductVendor { ProductID = 396, VendorID = 76, Price = 41.21M });
            _ProductVendors.Add(new ProductVendor { ProductID = 397, VendorID = 23, Price = 39.28M });
            _ProductVendors.Add(new ProductVendor { ProductID = 397, VendorID = 76, Price = 45.28M });
            _ProductVendors.Add(new ProductVendor { ProductID = 402, VendorID = 28, Price = 45.21M });
            _ProductVendors.Add(new ProductVendor { ProductID = 403, VendorID = 54, Price = 43.28M });
            _ProductVendors.Add(new ProductVendor { ProductID = 403, VendorID = 78, Price = 45.21M });
            _ProductVendors.Add(new ProductVendor { ProductID = 403, VendorID = 87, Price = 43.21M });
            _ProductVendors.Add(new ProductVendor { ProductID = 404, VendorID = 54, Price = 39.21M });
            _ProductVendors.Add(new ProductVendor { ProductID = 404, VendorID = 78, Price = 43.21M });
            _ProductVendors.Add(new ProductVendor { ProductID = 404, VendorID = 87, Price = 47.28M });
            _ProductVendors.Add(new ProductVendor { ProductID = 405, VendorID = 54, Price = 37.21M });
            _ProductVendors.Add(new ProductVendor { ProductID = 405, VendorID = 78, Price = 47.28M });
            _ProductVendors.Add(new ProductVendor { ProductID = 405, VendorID = 87, Price = 43.21M });
            _ProductVendors.Add(new ProductVendor { ProductID = 406, VendorID = 54, Price = 41.28M });
            _ProductVendors.Add(new ProductVendor { ProductID = 406, VendorID = 78, Price = 43.21M });
            _ProductVendors.Add(new ProductVendor { ProductID = 406, VendorID = 87, Price = 41.21M });
            _ProductVendors.Add(new ProductVendor { ProductID = 407, VendorID = 54, Price = 37.21M });
            _ProductVendors.Add(new ProductVendor { ProductID = 407, VendorID = 78, Price = 41.21M });
            _ProductVendors.Add(new ProductVendor { ProductID = 407, VendorID = 87, Price = 45.28M });
            _ProductVendors.Add(new ProductVendor { ProductID = 408, VendorID = 54, Price = 35.21M });
            _ProductVendors.Add(new ProductVendor { ProductID = 408, VendorID = 78, Price = 45.28M });
            _ProductVendors.Add(new ProductVendor { ProductID = 408, VendorID = 87, Price = 41.21M });
            _ProductVendors.Add(new ProductVendor { ProductID = 409, VendorID = 54, Price = 39.28M });
            _ProductVendors.Add(new ProductVendor { ProductID = 409, VendorID = 78, Price = 41.21M });
            _ProductVendors.Add(new ProductVendor { ProductID = 409, VendorID = 87, Price = 39.21M });
            _ProductVendors.Add(new ProductVendor { ProductID = 410, VendorID = 54, Price = 35.21M });
            _ProductVendors.Add(new ProductVendor { ProductID = 410, VendorID = 78, Price = 39.21M });
            _ProductVendors.Add(new ProductVendor { ProductID = 411, VendorID = 54, Price = 33.21M });
            _ProductVendors.Add(new ProductVendor { ProductID = 411, VendorID = 78, Price = 43.28M });
            _ProductVendors.Add(new ProductVendor { ProductID = 412, VendorID = 54, Price = 37.28M });
            _ProductVendors.Add(new ProductVendor { ProductID = 412, VendorID = 78, Price = 39.21M });
            _ProductVendors.Add(new ProductVendor { ProductID = 413, VendorID = 54, Price = 45.31M });
            _ProductVendors.Add(new ProductVendor { ProductID = 413, VendorID = 78, Price = 37.21M });
            _ProductVendors.Add(new ProductVendor { ProductID = 414, VendorID = 54, Price = 43.31M });
            _ProductVendors.Add(new ProductVendor { ProductID = 414, VendorID = 78, Price = 41.28M });
            _ProductVendors.Add(new ProductVendor { ProductID = 415, VendorID = 54, Price = 47.38M });
            _ProductVendors.Add(new ProductVendor { ProductID = 415, VendorID = 78, Price = 37.21M });
            _ProductVendors.Add(new ProductVendor { ProductID = 416, VendorID = 54, Price = 43.31M });
            _ProductVendors.Add(new ProductVendor { ProductID = 416, VendorID = 78, Price = 35.21M });
            _ProductVendors.Add(new ProductVendor { ProductID = 417, VendorID = 54, Price = 41.31M });
            _ProductVendors.Add(new ProductVendor { ProductID = 417, VendorID = 78, Price = 39.28M });
            _ProductVendors.Add(new ProductVendor { ProductID = 418, VendorID = 54, Price = 45.38M });
            _ProductVendors.Add(new ProductVendor { ProductID = 418, VendorID = 78, Price = 35.21M });
            _ProductVendors.Add(new ProductVendor { ProductID = 419, VendorID = 54, Price = 41.31M });
            _ProductVendors.Add(new ProductVendor { ProductID = 419, VendorID = 78, Price = 33.21M });
            _ProductVendors.Add(new ProductVendor { ProductID = 420, VendorID = 54, Price = 39.31M });
            _ProductVendors.Add(new ProductVendor { ProductID = 420, VendorID = 78, Price = 37.28M });
            _ProductVendors.Add(new ProductVendor { ProductID = 421, VendorID = 54, Price = 43.38M });
            _ProductVendors.Add(new ProductVendor { ProductID = 421, VendorID = 78, Price = 45.31M });
            _ProductVendors.Add(new ProductVendor { ProductID = 422, VendorID = 25, Price = 45.41M });
            _ProductVendors.Add(new ProductVendor { ProductID = 422, VendorID = 68, Price = 45.41M });
            _ProductVendors.Add(new ProductVendor { ProductID = 422, VendorID = 74, Price = 45.26M });
            _ProductVendors.Add(new ProductVendor { ProductID = 423, VendorID = 25, Price = 43.41M });
            _ProductVendors.Add(new ProductVendor { ProductID = 423, VendorID = 68, Price = 43.41M });
            _ProductVendors.Add(new ProductVendor { ProductID = 423, VendorID = 74, Price = 43.26M });
            _ProductVendors.Add(new ProductVendor { ProductID = 424, VendorID = 25, Price = 47.48M });
            _ProductVendors.Add(new ProductVendor { ProductID = 424, VendorID = 68, Price = 47.48M });
            _ProductVendors.Add(new ProductVendor { ProductID = 424, VendorID = 74, Price = 47.33M });
            _ProductVendors.Add(new ProductVendor { ProductID = 425, VendorID = 25, Price = 43.41M });
            _ProductVendors.Add(new ProductVendor { ProductID = 425, VendorID = 68, Price = 43.41M });
            _ProductVendors.Add(new ProductVendor { ProductID = 425, VendorID = 74, Price = 43.26M });
            _ProductVendors.Add(new ProductVendor { ProductID = 426, VendorID = 25, Price = 41.41M });
            _ProductVendors.Add(new ProductVendor { ProductID = 426, VendorID = 68, Price = 41.41M });
            _ProductVendors.Add(new ProductVendor { ProductID = 426, VendorID = 74, Price = 41.26M });
            _ProductVendors.Add(new ProductVendor { ProductID = 427, VendorID = 25, Price = 45.48M });
            _ProductVendors.Add(new ProductVendor { ProductID = 427, VendorID = 68, Price = 45.48M });
            _ProductVendors.Add(new ProductVendor { ProductID = 427, VendorID = 74, Price = 45.33M });
            _ProductVendors.Add(new ProductVendor { ProductID = 428, VendorID = 25, Price = 41.41M });
            _ProductVendors.Add(new ProductVendor { ProductID = 428, VendorID = 68, Price = 41.41M });
            _ProductVendors.Add(new ProductVendor { ProductID = 428, VendorID = 74, Price = 41.26M });
            _ProductVendors.Add(new ProductVendor { ProductID = 429, VendorID = 25, Price = 39.41M });
            _ProductVendors.Add(new ProductVendor { ProductID = 429, VendorID = 68, Price = 39.41M });
            _ProductVendors.Add(new ProductVendor { ProductID = 429, VendorID = 74, Price = 39.26M });
            _ProductVendors.Add(new ProductVendor { ProductID = 430, VendorID = 25, Price = 43.48M });
            _ProductVendors.Add(new ProductVendor { ProductID = 430, VendorID = 68, Price = 43.48M });
            _ProductVendors.Add(new ProductVendor { ProductID = 430, VendorID = 74, Price = 43.33M });
            _ProductVendors.Add(new ProductVendor { ProductID = 431, VendorID = 25, Price = 39.41M });
            _ProductVendors.Add(new ProductVendor { ProductID = 431, VendorID = 68, Price = 39.41M });
            _ProductVendors.Add(new ProductVendor { ProductID = 431, VendorID = 74, Price = 39.26M });
            _ProductVendors.Add(new ProductVendor { ProductID = 432, VendorID = 25, Price = 37.41M });
            _ProductVendors.Add(new ProductVendor { ProductID = 432, VendorID = 68, Price = 37.41M });
            _ProductVendors.Add(new ProductVendor { ProductID = 432, VendorID = 74, Price = 37.26M });
            _ProductVendors.Add(new ProductVendor { ProductID = 433, VendorID = 25, Price = 41.48M });
            _ProductVendors.Add(new ProductVendor { ProductID = 433, VendorID = 68, Price = 41.48M });
            _ProductVendors.Add(new ProductVendor { ProductID = 433, VendorID = 74, Price = 41.33M });
            _ProductVendors.Add(new ProductVendor { ProductID = 434, VendorID = 25, Price = 37.41M });
            _ProductVendors.Add(new ProductVendor { ProductID = 434, VendorID = 68, Price = 37.41M });
            _ProductVendors.Add(new ProductVendor { ProductID = 434, VendorID = 74, Price = 37.26M });
            _ProductVendors.Add(new ProductVendor { ProductID = 435, VendorID = 25, Price = 35.41M });
            _ProductVendors.Add(new ProductVendor { ProductID = 435, VendorID = 68, Price = 35.41M });
            _ProductVendors.Add(new ProductVendor { ProductID = 435, VendorID = 74, Price = 35.26M });
            _ProductVendors.Add(new ProductVendor { ProductID = 436, VendorID = 25, Price = 39.48M });
            _ProductVendors.Add(new ProductVendor { ProductID = 436, VendorID = 68, Price = 39.48M });
            _ProductVendors.Add(new ProductVendor { ProductID = 436, VendorID = 74, Price = 39.33M });
            _ProductVendors.Add(new ProductVendor { ProductID = 437, VendorID = 25, Price = 35.41M });
            _ProductVendors.Add(new ProductVendor { ProductID = 437, VendorID = 68, Price = 35.41M });
            _ProductVendors.Add(new ProductVendor { ProductID = 437, VendorID = 74, Price = 35.26M });
            _ProductVendors.Add(new ProductVendor { ProductID = 438, VendorID = 7, Price = 45.41M });
            _ProductVendors.Add(new ProductVendor { ProductID = 438, VendorID = 51, Price = 39.26M });
            _ProductVendors.Add(new ProductVendor { ProductID = 439, VendorID = 7, Price = 43.41M });
            _ProductVendors.Add(new ProductVendor { ProductID = 439, VendorID = 51, Price = 43.33M });
            _ProductVendors.Add(new ProductVendor { ProductID = 440, VendorID = 7, Price = 47.48M });
            _ProductVendors.Add(new ProductVendor { ProductID = 440, VendorID = 51, Price = 39.26M });
            _ProductVendors.Add(new ProductVendor { ProductID = 441, VendorID = 7, Price = 43.41M });
            _ProductVendors.Add(new ProductVendor { ProductID = 441, VendorID = 51, Price = 37.26M });
            _ProductVendors.Add(new ProductVendor { ProductID = 442, VendorID = 7, Price = 41.41M });
            _ProductVendors.Add(new ProductVendor { ProductID = 442, VendorID = 51, Price = 41.33M });
            _ProductVendors.Add(new ProductVendor { ProductID = 443, VendorID = 7, Price = 45.48M });
            _ProductVendors.Add(new ProductVendor { ProductID = 443, VendorID = 51, Price = 37.26M });
            _ProductVendors.Add(new ProductVendor { ProductID = 444, VendorID = 7, Price = 41.41M });
            _ProductVendors.Add(new ProductVendor { ProductID = 444, VendorID = 51, Price = 35.26M });
            _ProductVendors.Add(new ProductVendor { ProductID = 445, VendorID = 7, Price = 39.41M });
            _ProductVendors.Add(new ProductVendor { ProductID = 445, VendorID = 51, Price = 39.33M });
            _ProductVendors.Add(new ProductVendor { ProductID = 446, VendorID = 7, Price = 43.48M });
            _ProductVendors.Add(new ProductVendor { ProductID = 446, VendorID = 51, Price = 35.26M });
            _ProductVendors.Add(new ProductVendor { ProductID = 447, VendorID = 7, Price = 39.41M });
            _ProductVendors.Add(new ProductVendor { ProductID = 447, VendorID = 51, Price = 45.41M });
            _ProductVendors.Add(new ProductVendor { ProductID = 448, VendorID = 7, Price = 37.41M });
            _ProductVendors.Add(new ProductVendor { ProductID = 448, VendorID = 51, Price = 43.41M });
            _ProductVendors.Add(new ProductVendor { ProductID = 449, VendorID = 7, Price = 41.48M });
            _ProductVendors.Add(new ProductVendor { ProductID = 449, VendorID = 51, Price = 47.48M });
            _ProductVendors.Add(new ProductVendor { ProductID = 450, VendorID = 7, Price = 37.41M });
            _ProductVendors.Add(new ProductVendor { ProductID = 450, VendorID = 51, Price = 43.41M });
            _ProductVendors.Add(new ProductVendor { ProductID = 451, VendorID = 7, Price = 35.41M });
            _ProductVendors.Add(new ProductVendor { ProductID = 451, VendorID = 51, Price = 41.41M });
            _ProductVendors.Add(new ProductVendor { ProductID = 452, VendorID = 7, Price = 39.48M });
            _ProductVendors.Add(new ProductVendor { ProductID = 452, VendorID = 51, Price = 45.48M });
            _ProductVendors.Add(new ProductVendor { ProductID = 453, VendorID = 7, Price = 35.41M });
            _ProductVendors.Add(new ProductVendor { ProductID = 453, VendorID = 51, Price = 41.41M });
            _ProductVendors.Add(new ProductVendor { ProductID = 454, VendorID = 7, Price = 45.26M });
            _ProductVendors.Add(new ProductVendor { ProductID = 454, VendorID = 51, Price = 39.41M });
            _ProductVendors.Add(new ProductVendor { ProductID = 455, VendorID = 7, Price = 43.26M });
            _ProductVendors.Add(new ProductVendor { ProductID = 455, VendorID = 51, Price = 43.48M });
            _ProductVendors.Add(new ProductVendor { ProductID = 456, VendorID = 7, Price = 47.33M });
            _ProductVendors.Add(new ProductVendor { ProductID = 456, VendorID = 51, Price = 39.41M });
            _ProductVendors.Add(new ProductVendor { ProductID = 457, VendorID = 7, Price = 43.26M });
            _ProductVendors.Add(new ProductVendor { ProductID = 457, VendorID = 51, Price = 37.41M });
            _ProductVendors.Add(new ProductVendor { ProductID = 458, VendorID = 7, Price = 41.26M });
            _ProductVendors.Add(new ProductVendor { ProductID = 458, VendorID = 51, Price = 41.48M });
            _ProductVendors.Add(new ProductVendor { ProductID = 459, VendorID = 7, Price = 45.33M });
            _ProductVendors.Add(new ProductVendor { ProductID = 459, VendorID = 51, Price = 37.41M });
            _ProductVendors.Add(new ProductVendor { ProductID = 460, VendorID = 7, Price = 41.26M });
            _ProductVendors.Add(new ProductVendor { ProductID = 460, VendorID = 51, Price = 35.41M });
            _ProductVendors.Add(new ProductVendor { ProductID = 461, VendorID = 51, Price = 39.48M });
            _ProductVendors.Add(new ProductVendor { ProductID = 462, VendorID = 1, Price = 45.41M });
            _ProductVendors.Add(new ProductVendor { ProductID = 463, VendorID = 37, Price = 45.26M });
            _ProductVendors.Add(new ProductVendor { ProductID = 464, VendorID = 37, Price = 43.26M });
            _ProductVendors.Add(new ProductVendor { ProductID = 465, VendorID = 37, Price = 47.33M });
            _ProductVendors.Add(new ProductVendor { ProductID = 466, VendorID = 37, Price = 43.26M });
            _ProductVendors.Add(new ProductVendor { ProductID = 467, VendorID = 37, Price = 41.26M });
            _ProductVendors.Add(new ProductVendor { ProductID = 468, VendorID = 37, Price = 45.33M });
            _ProductVendors.Add(new ProductVendor { ProductID = 469, VendorID = 37, Price = 41.26M });
            _ProductVendors.Add(new ProductVendor { ProductID = 470, VendorID = 37, Price = 39.26M });
            _ProductVendors.Add(new ProductVendor { ProductID = 471, VendorID = 37, Price = 43.33M });
            _ProductVendors.Add(new ProductVendor { ProductID = 472, VendorID = 37, Price = 39.26M });
            _ProductVendors.Add(new ProductVendor { ProductID = 473, VendorID = 37, Price = 37.26M });
            _ProductVendors.Add(new ProductVendor { ProductID = 474, VendorID = 37, Price = 41.33M });
            _ProductVendors.Add(new ProductVendor { ProductID = 475, VendorID = 37, Price = 37.26M });
            _ProductVendors.Add(new ProductVendor { ProductID = 476, VendorID = 77, Price = 15.13M });
            _ProductVendors.Add(new ProductVendor { ProductID = 477, VendorID = 77, Price = 11.11M });
            _ProductVendors.Add(new ProductVendor { ProductID = 478, VendorID = 77, Price = 10.56M });
            _ProductVendors.Add(new ProductVendor { ProductID = 479, VendorID = 77, Price = 15.13M });
            _ProductVendors.Add(new ProductVendor { ProductID = 480, VendorID = 77, Price = 11.11M });
            _ProductVendors.Add(new ProductVendor { ProductID = 481, VendorID = 77, Price = 10.56M });
            _ProductVendors.Add(new ProductVendor { ProductID = 482, VendorID = 77, Price = 8.34M });
            _ProductVendors.Add(new ProductVendor { ProductID = 483, VendorID = 77, Price = 9.23M });
            _ProductVendors.Add(new ProductVendor { ProductID = 484, VendorID = 77, Price = 6.55M });
            _ProductVendors.Add(new ProductVendor { ProductID = 485, VendorID = 77, Price = 7.43M });
            _ProductVendors.Add(new ProductVendor { ProductID = 486, VendorID = 77, Price = 8.34M });
            _ProductVendors.Add(new ProductVendor { ProductID = 487, VendorID = 77, Price = 5.53M });
            _ProductVendors.Add(new ProductVendor { ProductID = 488, VendorID = 77, Price = 8.44M });
            _ProductVendors.Add(new ProductVendor { ProductID = 489, VendorID = 77, Price = 9.97M });
            _ProductVendors.Add(new ProductVendor { ProductID = 490, VendorID = 61, Price = 12.11M });
            _ProductVendors.Add(new ProductVendor { ProductID = 490, VendorID = 75, Price = 11.77M });
            _ProductVendors.Add(new ProductVendor { ProductID = 491, VendorID = 30, Price = 19.03M });
            _ProductVendors.Add(new ProductVendor { ProductID = 491, VendorID = 61, Price = 18.99M });
            _ProductVendors.Add(new ProductVendor { ProductID = 492, VendorID = 10, Price = 48.33M });
            _ProductVendors.Add(new ProductVendor { ProductID = 492, VendorID = 86, Price = 47.87M });
            _ProductVendors.Add(new ProductVendor { ProductID = 493, VendorID = 10, Price = 55.49M });
            _ProductVendors.Add(new ProductVendor { ProductID = 493, VendorID = 86, Price = 54.43M });
            _ProductVendors.Add(new ProductVendor { ProductID = 494, VendorID = 10, Price = 48.33M });
            _ProductVendors.Add(new ProductVendor { ProductID = 494, VendorID = 86, Price = 50.67M });
            _ProductVendors.Add(new ProductVendor { ProductID = 495, VendorID = 10, Price = 59.93M });
            _ProductVendors.Add(new ProductVendor { ProductID = 495, VendorID = 86, Price = 60.66M });
            _ProductVendors.Add(new ProductVendor { ProductID = 496, VendorID = 10, Price = 47.29M });
            _ProductVendors.Add(new ProductVendor { ProductID = 496, VendorID = 86, Price = 46.58M });
            _ProductVendors.Add(new ProductVendor { ProductID = 497, VendorID = 46, Price = 32.56M });
            _ProductVendors.Add(new ProductVendor { ProductID = 504, VendorID = 81, Price = 46.44M });
            _ProductVendors.Add(new ProductVendor { ProductID = 505, VendorID = 58, Price = 42.11M });
            _ProductVendors.Add(new ProductVendor { ProductID = 506, VendorID = 93, Price = 8.76M });
            _ProductVendors.Add(new ProductVendor { ProductID = 507, VendorID = 4, Price = 22.28M });
            _ProductVendors.Add(new ProductVendor { ProductID = 507, VendorID = 44, Price = 21.11M });
            _ProductVendors.Add(new ProductVendor { ProductID = 508, VendorID = 4, Price = 26.33M });
            _ProductVendors.Add(new ProductVendor { ProductID = 508, VendorID = 44, Price = 27.89M });
            _ProductVendors.Add(new ProductVendor { ProductID = 509, VendorID = 53, Price = 34.55M });
            _ProductVendors.Add(new ProductVendor { ProductID = 510, VendorID = 2, Price = 21.98M });
            _ProductVendors.Add(new ProductVendor { ProductID = 510, VendorID = 56, Price = 22.29M });
            _ProductVendors.Add(new ProductVendor { ProductID = 511, VendorID = 2, Price = 27.88M });
            _ProductVendors.Add(new ProductVendor { ProductID = 511, VendorID = 56, Price = 26.54M });
            _ProductVendors.Add(new ProductVendor { ProductID = 512, VendorID = 2, Price = 33.31M });
            _ProductVendors.Add(new ProductVendor { ProductID = 512, VendorID = 92, Price = 35.32M });
            _ProductVendors.Add(new ProductVendor { ProductID = 513, VendorID = 3, Price = 37.33M });
            _ProductVendors.Add(new ProductVendor { ProductID = 513, VendorID = 11, Price = 25.33M });
            _ProductVendors.Add(new ProductVendor { ProductID = 523, VendorID = 27, Price = 10.22M });
            _ProductVendors.Add(new ProductVendor { ProductID = 523, VendorID = 66, Price = 9.89M });
            _ProductVendors.Add(new ProductVendor { ProductID = 524, VendorID = 27, Price = 13.45M });
            _ProductVendors.Add(new ProductVendor { ProductID = 524, VendorID = 96, Price = 12.35M });
            _ProductVendors.Add(new ProductVendor { ProductID = 525, VendorID = 31, Price = 2.21M });
            _ProductVendors.Add(new ProductVendor { ProductID = 526, VendorID = 26, Price = 3.47M });
            _ProductVendors.Add(new ProductVendor { ProductID = 527, VendorID = 60, Price = 6.43M });
            _ProductVendors.Add(new ProductVendor { ProductID = 528, VendorID = 5, Price = 36.34M });
            _ProductVendors.Add(new ProductVendor { ProductID = 530, VendorID = 38, Price = 15.32M });
            _ProductVendors.Add(new ProductVendor { ProductID = 535, VendorID = 17, Price = 3.32M });
            _ProductVendors.Add(new ProductVendor { ProductID = 679, VendorID = 12, Price = 5.90M });
            _ProductVendors.Add(new ProductVendor { ProductID = 679, VendorID = 64, Price = 5.50M });
            _ProductVendors.Add(new ProductVendor { ProductID = 707, VendorID = 18, Price = 13.25M });
            _ProductVendors.Add(new ProductVendor { ProductID = 708, VendorID = 18, Price = 13.25M });
            _ProductVendors.Add(new ProductVendor { ProductID = 709, VendorID = 20, Price = 3.10M });
            _ProductVendors.Add(new ProductVendor { ProductID = 710, VendorID = 20, Price = 3.12M });
            _ProductVendors.Add(new ProductVendor { ProductID = 711, VendorID = 18, Price = 13.88M });
            _ProductVendors.Add(new ProductVendor { ProductID = 712, VendorID = 29, Price = 6.55M });
            _ProductVendors.Add(new ProductVendor { ProductID = 713, VendorID = 29, Price = 37.45M });
            _ProductVendors.Add(new ProductVendor { ProductID = 714, VendorID = 29, Price = 37.80M });
            _ProductVendors.Add(new ProductVendor { ProductID = 715, VendorID = 29, Price = 37.80M });
            _ProductVendors.Add(new ProductVendor { ProductID = 716, VendorID = 29, Price = 38.05M });
            _ProductVendors.Add(new ProductVendor { ProductID = 841, VendorID = 29, Price = 26.75M });
            _ProductVendors.Add(new ProductVendor { ProductID = 842, VendorID = 65, Price = 54.20M });
            _ProductVendors.Add(new ProductVendor { ProductID = 843, VendorID = 65, Price = 8.50M });
            _ProductVendors.Add(new ProductVendor { ProductID = 844, VendorID = 65, Price = 8.50M });
            _ProductVendors.Add(new ProductVendor { ProductID = 845, VendorID = 65, Price = 10.75M });
            _ProductVendors.Add(new ProductVendor { ProductID = 846, VendorID = 65, Price = 4.50M });
            _ProductVendors.Add(new ProductVendor { ProductID = 847, VendorID = 65, Price = 14.50M });
            _ProductVendors.Add(new ProductVendor { ProductID = 848, VendorID = 65, Price = 15.75M });
            _ProductVendors.Add(new ProductVendor { ProductID = 849, VendorID = 102, Price = 24.75M });
            _ProductVendors.Add(new ProductVendor { ProductID = 850, VendorID = 102, Price = 24.75M });
            _ProductVendors.Add(new ProductVendor { ProductID = 851, VendorID = 102, Price = 24.75M });
            _ProductVendors.Add(new ProductVendor { ProductID = 852, VendorID = 102, Price = 32.35M });
            _ProductVendors.Add(new ProductVendor { ProductID = 853, VendorID = 102, Price = 32.35M });
            _ProductVendors.Add(new ProductVendor { ProductID = 854, VendorID = 102, Price = 32.35M });
            _ProductVendors.Add(new ProductVendor { ProductID = 855, VendorID = 102, Price = 38.50M });
            _ProductVendors.Add(new ProductVendor { ProductID = 856, VendorID = 102, Price = 37.50M });
            _ProductVendors.Add(new ProductVendor { ProductID = 857, VendorID = 102, Price = 37.50M });
            _ProductVendors.Add(new ProductVendor { ProductID = 858, VendorID = 95, Price = 8.75M });
            _ProductVendors.Add(new ProductVendor { ProductID = 859, VendorID = 95, Price = 8.75M });
            _ProductVendors.Add(new ProductVendor { ProductID = 860, VendorID = 95, Price = 8.75M });
            _ProductVendors.Add(new ProductVendor { ProductID = 861, VendorID = 95, Price = 15.50M });
            _ProductVendors.Add(new ProductVendor { ProductID = 862, VendorID = 95, Price = 15.50M });
            _ProductVendors.Add(new ProductVendor { ProductID = 863, VendorID = 95, Price = 15.50M });
            _ProductVendors.Add(new ProductVendor { ProductID = 864, VendorID = 95, Price = 23.20M });
            _ProductVendors.Add(new ProductVendor { ProductID = 865, VendorID = 95, Price = 23.20M });
            _ProductVendors.Add(new ProductVendor { ProductID = 866, VendorID = 95, Price = 23.20M });
            _ProductVendors.Add(new ProductVendor { ProductID = 867, VendorID = 95, Price = 25.45M });
            _ProductVendors.Add(new ProductVendor { ProductID = 868, VendorID = 95, Price = 25.45M });
            _ProductVendors.Add(new ProductVendor { ProductID = 869, VendorID = 95, Price = 25.45M });
            _ProductVendors.Add(new ProductVendor { ProductID = 870, VendorID = 6, Price = 1.87M });
            _ProductVendors.Add(new ProductVendor { ProductID = 871, VendorID = 6, Price = 3.74M });
            _ProductVendors.Add(new ProductVendor { ProductID = 872, VendorID = 6, Price = 3.00M });
            _ProductVendors.Add(new ProductVendor { ProductID = 873, VendorID = 6, Price = 0.80M });
            _ProductVendors.Add(new ProductVendor { ProductID = 874, VendorID = 20, Price = 3.00M });
            _ProductVendors.Add(new ProductVendor { ProductID = 875, VendorID = 20, Price = 3.00M });
            _ProductVendors.Add(new ProductVendor { ProductID = 876, VendorID = 6, Price = 48.00M });
            _ProductVendors.Add(new ProductVendor { ProductID = 877, VendorID = 6, Price = 3.00M });
            _ProductVendors.Add(new ProductVendor { ProductID = 878, VendorID = 6, Price = 8.22M });
            _ProductVendors.Add(new ProductVendor { ProductID = 879, VendorID = 6, Price = 49.00M });
            _ProductVendors.Add(new ProductVendor { ProductID = 880, VendorID = 6, Price = 19.00M });
            _ProductVendors.Add(new ProductVendor { ProductID = 881, VendorID = 29, Price = 40.00M });
            _ProductVendors.Add(new ProductVendor { ProductID = 882, VendorID = 29, Price = 40.00M });
            _ProductVendors.Add(new ProductVendor { ProductID = 883, VendorID = 29, Price = 40.00M });
            _ProductVendors.Add(new ProductVendor { ProductID = 884, VendorID = 29, Price = 40.00M });
            _ProductVendors.Add(new ProductVendor { ProductID = 907, VendorID = 94, Price = 78.89M });
            _ProductVendors.Add(new ProductVendor { ProductID = 908, VendorID = 24, Price = 20.09M });
            _ProductVendors.Add(new ProductVendor { ProductID = 908, VendorID = 45, Price = 20.09M });
            _ProductVendors.Add(new ProductVendor { ProductID = 909, VendorID = 24, Price = 28.99M });
            _ProductVendors.Add(new ProductVendor { ProductID = 909, VendorID = 45, Price = 28.99M });
            _ProductVendors.Add(new ProductVendor { ProductID = 910, VendorID = 45, Price = 38.99M });
            _ProductVendors.Add(new ProductVendor { ProductID = 910, VendorID = 52, Price = 38.99M });
            _ProductVendors.Add(new ProductVendor { ProductID = 911, VendorID = 39, Price = 20.09M });
            _ProductVendors.Add(new ProductVendor { ProductID = 911, VendorID = 45, Price = 20.09M });
            _ProductVendors.Add(new ProductVendor { ProductID = 912, VendorID = 39, Price = 28.99M });
            _ProductVendors.Add(new ProductVendor { ProductID = 912, VendorID = 45, Price = 28.99M });
            _ProductVendors.Add(new ProductVendor { ProductID = 913, VendorID = 24, Price = 38.99M });
            _ProductVendors.Add(new ProductVendor { ProductID = 913, VendorID = 45, Price = 38.99M });
            _ProductVendors.Add(new ProductVendor { ProductID = 914, VendorID = 45, Price = 20.09M });
            _ProductVendors.Add(new ProductVendor { ProductID = 914, VendorID = 87, Price = 20.09M });
            _ProductVendors.Add(new ProductVendor { ProductID = 915, VendorID = 45, Price = 28.99M });
            _ProductVendors.Add(new ProductVendor { ProductID = 915, VendorID = 87, Price = 28.99M });
            _ProductVendors.Add(new ProductVendor { ProductID = 916, VendorID = 45, Price = 38.99M });
            _ProductVendors.Add(new ProductVendor { ProductID = 916, VendorID = 87, Price = 38.99M });
            _ProductVendors.Add(new ProductVendor { ProductID = 921, VendorID = 98, Price = 5.32M });
            _ProductVendors.Add(new ProductVendor { ProductID = 922, VendorID = 22, Price = 6.22M });
            _ProductVendors.Add(new ProductVendor { ProductID = 923, VendorID = 22, Price = 5.89M });
            _ProductVendors.Add(new ProductVendor { ProductID = 928, VendorID = 55, Price = 31.21M });
            _ProductVendors.Add(new ProductVendor { ProductID = 928, VendorID = 71, Price = 30.71M });
            _ProductVendors.Add(new ProductVendor { ProductID = 929, VendorID = 55, Price = 35.32M });
            _ProductVendors.Add(new ProductVendor { ProductID = 929, VendorID = 71, Price = 34.82M });
            _ProductVendors.Add(new ProductVendor { ProductID = 930, VendorID = 55, Price = 40.99M });
            _ProductVendors.Add(new ProductVendor { ProductID = 930, VendorID = 98, Price = 40.49M });
            _ProductVendors.Add(new ProductVendor { ProductID = 931, VendorID = 33, Price = 32.71M });
            _ProductVendors.Add(new ProductVendor { ProductID = 931, VendorID = 104, Price = 33.21M });
            _ProductVendors.Add(new ProductVendor { ProductID = 932, VendorID = 33, Price = 37.37M });
            _ProductVendors.Add(new ProductVendor { ProductID = 932, VendorID = 104, Price = 37.87M });
            _ProductVendors.Add(new ProductVendor { ProductID = 933, VendorID = 22, Price = 41.39M });
            _ProductVendors.Add(new ProductVendor { ProductID = 933, VendorID = 104, Price = 41.89M });
            _ProductVendors.Add(new ProductVendor { ProductID = 934, VendorID = 22, Price = 35.83M });
            _ProductVendors.Add(new ProductVendor { ProductID = 934, VendorID = 104, Price = 36.33M });
            _ProductVendors.Add(new ProductVendor { ProductID = 935, VendorID = 73, Price = 29.99M });
            _ProductVendors.Add(new ProductVendor { ProductID = 935, VendorID = 88, Price = 29.99M });
            _ProductVendors.Add(new ProductVendor { ProductID = 936, VendorID = 73, Price = 45.99M });
            _ProductVendors.Add(new ProductVendor { ProductID = 936, VendorID = 88, Price = 45.99M });
            _ProductVendors.Add(new ProductVendor { ProductID = 937, VendorID = 43, Price = 59.99M });
            _ProductVendors.Add(new ProductVendor { ProductID = 938, VendorID = 35, Price = 29.99M });
            _ProductVendors.Add(new ProductVendor { ProductID = 938, VendorID = 53, Price = 29.99M });
            _ProductVendors.Add(new ProductVendor { ProductID = 939, VendorID = 35, Price = 45.99M });
            _ProductVendors.Add(new ProductVendor { ProductID = 939, VendorID = 53, Price = 45.99M });
            _ProductVendors.Add(new ProductVendor { ProductID = 940, VendorID = 17, Price = 59.99M });
            _ProductVendors.Add(new ProductVendor { ProductID = 941, VendorID = 80, Price = 59.99M });
            _ProductVendors.Add(new ProductVendor { ProductID = 948, VendorID = 94, Price = 78.89M });
            _ProductVendors.Add(new ProductVendor { ProductID = 952, VendorID = 72, Price = 14.99M });

        }


        private static void GenerateProducts()
        {
            _Products.Add(new Product { ID = 1, Name = "Adjustable Race" });
            _Products.Add(new Product { ID = 2, Name = "Bearing Ball" });
            _Products.Add(new Product { ID = 4, Name = "Headset Ball Bearings" });
            _Products.Add(new Product { ID = 317, Name = "LL Crankarm" });
            _Products.Add(new Product { ID = 318, Name = "ML Crankarm" });
            _Products.Add(new Product { ID = 319, Name = "HL Crankarm" });
            _Products.Add(new Product { ID = 320, Name = "Chainring Bolts" });
            _Products.Add(new Product { ID = 321, Name = "Chainring Nut" });
            _Products.Add(new Product { ID = 322, Name = "Chainring" });
            _Products.Add(new Product { ID = 323, Name = "Crown Race" });
            _Products.Add(new Product { ID = 325, Name = "Decal 1" });
            _Products.Add(new Product { ID = 326, Name = "Decal 2" });
            _Products.Add(new Product { ID = 332, Name = "Freewheel" });
            _Products.Add(new Product { ID = 341, Name = "Flat Washer 1" });
            _Products.Add(new Product { ID = 342, Name = "Flat Washer 6" });
            _Products.Add(new Product { ID = 343, Name = "Flat Washer 2" });
            _Products.Add(new Product { ID = 344, Name = "Flat Washer 9" });
            _Products.Add(new Product { ID = 345, Name = "Flat Washer 4" });
            _Products.Add(new Product { ID = 346, Name = "Flat Washer 3" });
            _Products.Add(new Product { ID = 347, Name = "Flat Washer 8" });
            _Products.Add(new Product { ID = 348, Name = "Flat Washer 5" });
            _Products.Add(new Product { ID = 349, Name = "Flat Washer 7" });
            _Products.Add(new Product { ID = 351, Name = "Front Derailleur Cage" });
            _Products.Add(new Product { ID = 352, Name = "Front Derailleur Linkage" });
            _Products.Add(new Product { ID = 355, Name = "Guide Pulley" });
            _Products.Add(new Product { ID = 356, Name = "LL Grip Tape" });
            _Products.Add(new Product { ID = 357, Name = "ML Grip Tape" });
            _Products.Add(new Product { ID = 358, Name = "HL Grip Tape" });
            _Products.Add(new Product { ID = 359, Name = "Thin-Jam Hex Nut 9" });
            _Products.Add(new Product { ID = 360, Name = "Thin-Jam Hex Nut 10" });
            _Products.Add(new Product { ID = 361, Name = "Thin-Jam Hex Nut 1" });
            _Products.Add(new Product { ID = 362, Name = "Thin-Jam Hex Nut 2" });
            _Products.Add(new Product { ID = 363, Name = "Thin-Jam Hex Nut 15" });
            _Products.Add(new Product { ID = 364, Name = "Thin-Jam Hex Nut 16" });
            _Products.Add(new Product { ID = 365, Name = "Thin-Jam Hex Nut 5" });
            _Products.Add(new Product { ID = 366, Name = "Thin-Jam Hex Nut 6" });
            _Products.Add(new Product { ID = 367, Name = "Thin-Jam Hex Nut 3" });
            _Products.Add(new Product { ID = 368, Name = "Thin-Jam Hex Nut 4" });
            _Products.Add(new Product { ID = 369, Name = "Thin-Jam Hex Nut 13" });
            _Products.Add(new Product { ID = 370, Name = "Thin-Jam Hex Nut 14" });
            _Products.Add(new Product { ID = 371, Name = "Thin-Jam Hex Nut 7" });
            _Products.Add(new Product { ID = 372, Name = "Thin-Jam Hex Nut 8" });
            _Products.Add(new Product { ID = 373, Name = "Thin-Jam Hex Nut 12" });
            _Products.Add(new Product { ID = 374, Name = "Thin-Jam Hex Nut 11" });
            _Products.Add(new Product { ID = 375, Name = "Hex Nut 5" });
            _Products.Add(new Product { ID = 376, Name = "Hex Nut 6" });
            _Products.Add(new Product { ID = 377, Name = "Hex Nut 16" });
            _Products.Add(new Product { ID = 378, Name = "Hex Nut 17" });
            _Products.Add(new Product { ID = 379, Name = "Hex Nut 7" });
            _Products.Add(new Product { ID = 380, Name = "Hex Nut 8" });
            _Products.Add(new Product { ID = 381, Name = "Hex Nut 9" });
            _Products.Add(new Product { ID = 382, Name = "Hex Nut 22" });
            _Products.Add(new Product { ID = 383, Name = "Hex Nut 23" });
            _Products.Add(new Product { ID = 384, Name = "Hex Nut 12" });
            _Products.Add(new Product { ID = 385, Name = "Hex Nut 13" });
            _Products.Add(new Product { ID = 386, Name = "Hex Nut 1" });
            _Products.Add(new Product { ID = 387, Name = "Hex Nut 10" });
            _Products.Add(new Product { ID = 388, Name = "Hex Nut 11" });
            _Products.Add(new Product { ID = 389, Name = "Hex Nut 2" });
            _Products.Add(new Product { ID = 390, Name = "Hex Nut 20" });
            _Products.Add(new Product { ID = 391, Name = "Hex Nut 21" });
            _Products.Add(new Product { ID = 392, Name = "Hex Nut 3" });
            _Products.Add(new Product { ID = 393, Name = "Hex Nut 14" });
            _Products.Add(new Product { ID = 394, Name = "Hex Nut 15" });
            _Products.Add(new Product { ID = 395, Name = "Hex Nut 4" });
            _Products.Add(new Product { ID = 396, Name = "Hex Nut 18" });
            _Products.Add(new Product { ID = 397, Name = "Hex Nut 19" });
            _Products.Add(new Product { ID = 402, Name = "Keyed Washer" });
            _Products.Add(new Product { ID = 403, Name = "External Lock Washer 3" });
            _Products.Add(new Product { ID = 404, Name = "External Lock Washer 4" });
            _Products.Add(new Product { ID = 405, Name = "External Lock Washer 9" });
            _Products.Add(new Product { ID = 406, Name = "External Lock Washer 5" });
            _Products.Add(new Product { ID = 407, Name = "External Lock Washer 7" });
            _Products.Add(new Product { ID = 408, Name = "External Lock Washer 6" });
            _Products.Add(new Product { ID = 409, Name = "External Lock Washer 1" });
            _Products.Add(new Product { ID = 410, Name = "External Lock Washer 8" });
            _Products.Add(new Product { ID = 411, Name = "External Lock Washer 2" });
            _Products.Add(new Product { ID = 412, Name = "Internal Lock Washer 3" });
            _Products.Add(new Product { ID = 413, Name = "Internal Lock Washer 4" });
            _Products.Add(new Product { ID = 414, Name = "Internal Lock Washer 9" });
            _Products.Add(new Product { ID = 415, Name = "Internal Lock Washer 5" });
            _Products.Add(new Product { ID = 416, Name = "Internal Lock Washer 7" });
            _Products.Add(new Product { ID = 417, Name = "Internal Lock Washer 6" });
            _Products.Add(new Product { ID = 418, Name = "Internal Lock Washer 10" });
            _Products.Add(new Product { ID = 419, Name = "Internal Lock Washer 1" });
            _Products.Add(new Product { ID = 420, Name = "Internal Lock Washer 8" });
            _Products.Add(new Product { ID = 421, Name = "Internal Lock Washer 2" });
            _Products.Add(new Product { ID = 422, Name = "Thin-Jam Lock Nut 9" });
            _Products.Add(new Product { ID = 423, Name = "Thin-Jam Lock Nut 10" });
            _Products.Add(new Product { ID = 424, Name = "Thin-Jam Lock Nut 1" });
            _Products.Add(new Product { ID = 425, Name = "Thin-Jam Lock Nut 2" });
            _Products.Add(new Product { ID = 426, Name = "Thin-Jam Lock Nut 15" });
            _Products.Add(new Product { ID = 427, Name = "Thin-Jam Lock Nut 16" });
            _Products.Add(new Product { ID = 428, Name = "Thin-Jam Lock Nut 5" });
            _Products.Add(new Product { ID = 429, Name = "Thin-Jam Lock Nut 6" });
            _Products.Add(new Product { ID = 430, Name = "Thin-Jam Lock Nut 3" });
            _Products.Add(new Product { ID = 431, Name = "Thin-Jam Lock Nut 4" });
            _Products.Add(new Product { ID = 432, Name = "Thin-Jam Lock Nut 13" });
            _Products.Add(new Product { ID = 433, Name = "Thin-Jam Lock Nut 14" });
            _Products.Add(new Product { ID = 434, Name = "Thin-Jam Lock Nut 7" });
            _Products.Add(new Product { ID = 435, Name = "Thin-Jam Lock Nut 8" });
            _Products.Add(new Product { ID = 436, Name = "Thin-Jam Lock Nut 12" });
            _Products.Add(new Product { ID = 437, Name = "Thin-Jam Lock Nut 11" });
            _Products.Add(new Product { ID = 438, Name = "Lock Nut 5" });
            _Products.Add(new Product { ID = 439, Name = "Lock Nut 6" });
            _Products.Add(new Product { ID = 440, Name = "Lock Nut 16" });
            _Products.Add(new Product { ID = 441, Name = "Lock Nut 17" });
            _Products.Add(new Product { ID = 442, Name = "Lock Nut 7" });
            _Products.Add(new Product { ID = 443, Name = "Lock Nut 8" });
            _Products.Add(new Product { ID = 444, Name = "Lock Nut 9" });
            _Products.Add(new Product { ID = 445, Name = "Lock Nut 22" });
            _Products.Add(new Product { ID = 446, Name = "Lock Nut 23" });
            _Products.Add(new Product { ID = 447, Name = "Lock Nut 12" });
            _Products.Add(new Product { ID = 448, Name = "Lock Nut 13" });
            _Products.Add(new Product { ID = 449, Name = "Lock Nut 1" });
            _Products.Add(new Product { ID = 450, Name = "Lock Nut 10" });
            _Products.Add(new Product { ID = 451, Name = "Lock Nut 11" });
            _Products.Add(new Product { ID = 452, Name = "Lock Nut 2" });
            _Products.Add(new Product { ID = 453, Name = "Lock Nut 20" });
            _Products.Add(new Product { ID = 454, Name = "Lock Nut 21" });
            _Products.Add(new Product { ID = 455, Name = "Lock Nut 3" });
            _Products.Add(new Product { ID = 456, Name = "Lock Nut 14" });
            _Products.Add(new Product { ID = 457, Name = "Lock Nut 15" });
            _Products.Add(new Product { ID = 458, Name = "Lock Nut 4" });
            _Products.Add(new Product { ID = 459, Name = "Lock Nut 19" });
            _Products.Add(new Product { ID = 460, Name = "Lock Nut 18" });
            _Products.Add(new Product { ID = 461, Name = "Lock Ring" });
            _Products.Add(new Product { ID = 462, Name = "Lower Head Race" });
            _Products.Add(new Product { ID = 463, Name = "Lock Washer 4" });
            _Products.Add(new Product { ID = 464, Name = "Lock Washer 5" });
            _Products.Add(new Product { ID = 465, Name = "Lock Washer 10" });
            _Products.Add(new Product { ID = 466, Name = "Lock Washer 6" });
            _Products.Add(new Product { ID = 467, Name = "Lock Washer 13" });
            _Products.Add(new Product { ID = 468, Name = "Lock Washer 8" });
            _Products.Add(new Product { ID = 469, Name = "Lock Washer 1" });
            _Products.Add(new Product { ID = 470, Name = "Lock Washer 7" });
            _Products.Add(new Product { ID = 471, Name = "Lock Washer 12" });
            _Products.Add(new Product { ID = 472, Name = "Lock Washer 2" });
            _Products.Add(new Product { ID = 473, Name = "Lock Washer 9" });
            _Products.Add(new Product { ID = 474, Name = "Lock Washer 3" });
            _Products.Add(new Product { ID = 475, Name = "Lock Washer 11" });
            _Products.Add(new Product { ID = 476, Name = "Metal Angle" });
            _Products.Add(new Product { ID = 477, Name = "Metal Bar 1" });
            _Products.Add(new Product { ID = 478, Name = "Metal Bar 2" });
            _Products.Add(new Product { ID = 479, Name = "Metal Plate 2" });
            _Products.Add(new Product { ID = 480, Name = "Metal Plate 1" });
            _Products.Add(new Product { ID = 481, Name = "Metal Plate 3" });
            _Products.Add(new Product { ID = 482, Name = "Metal Sheet 2" });
            _Products.Add(new Product { ID = 483, Name = "Metal Sheet 3" });
            _Products.Add(new Product { ID = 484, Name = "Metal Sheet 7" });
            _Products.Add(new Product { ID = 485, Name = "Metal Sheet 4" });
            _Products.Add(new Product { ID = 486, Name = "Metal Sheet 5" });
            _Products.Add(new Product { ID = 487, Name = "Metal Sheet 6" });
            _Products.Add(new Product { ID = 488, Name = "Metal Sheet 1" });
            _Products.Add(new Product { ID = 489, Name = "Metal Tread Plate" });
            _Products.Add(new Product { ID = 490, Name = "LL Nipple" });
            _Products.Add(new Product { ID = 491, Name = "HL Nipple" });
            _Products.Add(new Product { ID = 492, Name = "Paint - Black" });
            _Products.Add(new Product { ID = 493, Name = "Paint - Red" });
            _Products.Add(new Product { ID = 494, Name = "Paint - Silver" });
            _Products.Add(new Product { ID = 495, Name = "Paint - Blue" });
            _Products.Add(new Product { ID = 496, Name = "Paint - Yellow" });
            _Products.Add(new Product { ID = 497, Name = "Pinch Bolt" });
            _Products.Add(new Product { ID = 504, Name = "Cup-Shaped Race" });
            _Products.Add(new Product { ID = 505, Name = "Cone-Shaped Race" });
            _Products.Add(new Product { ID = 506, Name = "Reflector" });
            _Products.Add(new Product { ID = 507, Name = "LL Mountain Rim" });
            _Products.Add(new Product { ID = 508, Name = "ML Mountain Rim" });
            _Products.Add(new Product { ID = 509, Name = "HL Mountain Rim" });
            _Products.Add(new Product { ID = 510, Name = "LL Road Rim" });
            _Products.Add(new Product { ID = 511, Name = "ML Road Rim" });
            _Products.Add(new Product { ID = 512, Name = "HL Road Rim" });
            _Products.Add(new Product { ID = 513, Name = "Touring Rim" });
            _Products.Add(new Product { ID = 523, Name = "LL Spindle/Axle" });
            _Products.Add(new Product { ID = 524, Name = "HL Spindle/Axle" });
            _Products.Add(new Product { ID = 525, Name = "LL Shell" });
            _Products.Add(new Product { ID = 526, Name = "HL Shell" });
            _Products.Add(new Product { ID = 527, Name = "Spokes" });
            _Products.Add(new Product { ID = 528, Name = "Seat Lug" });
            _Products.Add(new Product { ID = 530, Name = "Seat Post" });
            _Products.Add(new Product { ID = 535, Name = "Tension Pulley" });
            _Products.Add(new Product { ID = 679, Name = "Rear Derailleur Cage" });
            _Products.Add(new Product { ID = 707, Name = "Sport-100 Helmet, Red" });
            _Products.Add(new Product { ID = 708, Name = "Sport-100 Helmet, Black" });
            _Products.Add(new Product { ID = 709, Name = "Mountain Bike Socks, M" });
            _Products.Add(new Product { ID = 710, Name = "Mountain Bike Socks, L" });
            _Products.Add(new Product { ID = 711, Name = "Sport-100 Helmet, Blue" });
            _Products.Add(new Product { ID = 712, Name = "AWC Logo Cap" });
            _Products.Add(new Product { ID = 713, Name = "Long-Sleeve Logo Jersey, S" });
            _Products.Add(new Product { ID = 714, Name = "Long-Sleeve Logo Jersey, M" });
            _Products.Add(new Product { ID = 715, Name = "Long-Sleeve Logo Jersey, L" });
            _Products.Add(new Product { ID = 716, Name = "Long-Sleeve Logo Jersey, XL" });
            _Products.Add(new Product { ID = 841, Name = "Men's Sports Shorts, S" });
            _Products.Add(new Product { ID = 842, Name = "Touring-Panniers, Large" });
            _Products.Add(new Product { ID = 843, Name = "Cable Lock" });
            _Products.Add(new Product { ID = 844, Name = "Minipump" });
            _Products.Add(new Product { ID = 845, Name = "Mountain Pump" });
            _Products.Add(new Product { ID = 846, Name = "Taillights - Battery-Powered" });
            _Products.Add(new Product { ID = 847, Name = "Headlights - Dual-Beam" });
            _Products.Add(new Product { ID = 848, Name = "Headlights - Weatherproof" });
            _Products.Add(new Product { ID = 849, Name = "Men's Sports Shorts, M" });
            _Products.Add(new Product { ID = 850, Name = "Men's Sports Shorts, L" });
            _Products.Add(new Product { ID = 851, Name = "Men's Sports Shorts, XL" });
            _Products.Add(new Product { ID = 852, Name = "Women's Tights, S" });
            _Products.Add(new Product { ID = 853, Name = "Women's Tights, M" });
            _Products.Add(new Product { ID = 854, Name = "Women's Tights, L" });
            _Products.Add(new Product { ID = 855, Name = "Men's Bib-Shorts, S" });
            _Products.Add(new Product { ID = 856, Name = "Men's Bib-Shorts, M" });
            _Products.Add(new Product { ID = 857, Name = "Men's Bib-Shorts, L" });
            _Products.Add(new Product { ID = 858, Name = "Half-Finger Gloves, S" });
            _Products.Add(new Product { ID = 859, Name = "Half-Finger Gloves, M" });
            _Products.Add(new Product { ID = 860, Name = "Half-Finger Gloves, L" });
            _Products.Add(new Product { ID = 861, Name = "Full-Finger Gloves, S" });
            _Products.Add(new Product { ID = 862, Name = "Full-Finger Gloves, M" });
            _Products.Add(new Product { ID = 863, Name = "Full-Finger Gloves, L" });
            _Products.Add(new Product { ID = 864, Name = "Classic Vest, S" });
            _Products.Add(new Product { ID = 865, Name = "Classic Vest, M" });
            _Products.Add(new Product { ID = 866, Name = "Classic Vest, L" });
            _Products.Add(new Product { ID = 867, Name = "Women's Mountain Shorts, S" });
            _Products.Add(new Product { ID = 868, Name = "Women's Mountain Shorts, M" });
            _Products.Add(new Product { ID = 869, Name = "Women's Mountain Shorts, L" });
            _Products.Add(new Product { ID = 870, Name = "Water Bottle - 30 oz." });
            _Products.Add(new Product { ID = 871, Name = "Mountain Bottle Cage" });
            _Products.Add(new Product { ID = 872, Name = "Road Bottle Cage" });
            _Products.Add(new Product { ID = 873, Name = "Patch Kit/8 Patches" });
            _Products.Add(new Product { ID = 874, Name = "Racing Socks, M" });
            _Products.Add(new Product { ID = 875, Name = "Racing Socks, L" });
            _Products.Add(new Product { ID = 876, Name = "Hitch Rack - 4-Bike" });
            _Products.Add(new Product { ID = 877, Name = "Bike Wash - Dissolver" });
            _Products.Add(new Product { ID = 878, Name = "Fender Set - Mountain" });
            _Products.Add(new Product { ID = 879, Name = "All-Purpose Bike Stand" });
            _Products.Add(new Product { ID = 880, Name = "Hydration Pack - 70 oz." });
            _Products.Add(new Product { ID = 881, Name = "Short-Sleeve Classic Jersey, S" });
            _Products.Add(new Product { ID = 882, Name = "Short-Sleeve Classic Jersey, M" });
            _Products.Add(new Product { ID = 883, Name = "Short-Sleeve Classic Jersey, L" });
            _Products.Add(new Product { ID = 884, Name = "Short-Sleeve Classic Jersey, XL" });
            _Products.Add(new Product { ID = 907, Name = "Rear Brakes" });
            _Products.Add(new Product { ID = 908, Name = "LL Mountain Seat/Saddle" });
            _Products.Add(new Product { ID = 909, Name = "ML Mountain Seat/Saddle" });
            _Products.Add(new Product { ID = 910, Name = "HL Mountain Seat/Saddle" });
            _Products.Add(new Product { ID = 911, Name = "LL Road Seat/Saddle" });
            _Products.Add(new Product { ID = 912, Name = "ML Road Seat/Saddle" });
            _Products.Add(new Product { ID = 913, Name = "HL Road Seat/Saddle" });
            _Products.Add(new Product { ID = 914, Name = "LL Touring Seat/Saddle" });
            _Products.Add(new Product { ID = 915, Name = "ML Touring Seat/Saddle" });
            _Products.Add(new Product { ID = 916, Name = "HL Touring Seat/Saddle" });
            _Products.Add(new Product { ID = 921, Name = "Mountain Tire Tube" });
            _Products.Add(new Product { ID = 922, Name = "Road Tire Tube" });
            _Products.Add(new Product { ID = 923, Name = "Touring Tire Tube" });
            _Products.Add(new Product { ID = 928, Name = "LL Mountain Tire" });
            _Products.Add(new Product { ID = 929, Name = "ML Mountain Tire" });
            _Products.Add(new Product { ID = 930, Name = "HL Mountain Tire" });
            _Products.Add(new Product { ID = 931, Name = "LL Road Tire" });
            _Products.Add(new Product { ID = 932, Name = "ML Road Tire" });
            _Products.Add(new Product { ID = 933, Name = "HL Road Tire" });
            _Products.Add(new Product { ID = 934, Name = "Touring Tire" });
            _Products.Add(new Product { ID = 935, Name = "LL Mountain Pedal" });
            _Products.Add(new Product { ID = 936, Name = "ML Mountain Pedal" });
            _Products.Add(new Product { ID = 937, Name = "HL Mountain Pedal" });
            _Products.Add(new Product { ID = 938, Name = "LL Road Pedal" });
            _Products.Add(new Product { ID = 939, Name = "ML Road Pedal" });
            _Products.Add(new Product { ID = 940, Name = "HL Road Pedal" });
            _Products.Add(new Product { ID = 941, Name = "Touring Pedal" });
            _Products.Add(new Product { ID = 948, Name = "Front Brakes" });
            _Products.Add(new Product { ID = 952, Name = "Chain" });
        }

        private static void GenerateEmployees()
        {
            _Employees.Add(new Employee { ID = 1, Name = "Guy Gilbert", Manager = 16, BirthDate = new DateTime(1972, 5, 15), Gender = 'M', SickLeaveHours = 30 });
            _Employees.Add(new Employee { ID = 2, Name = "Kevin Brown", Manager = 6, BirthDate = new DateTime(1977, 6, 3), Gender = 'M', SickLeaveHours = 41 });
            _Employees.Add(new Employee { ID = 3, Name = "Roberto Tamburello", Manager = 12, BirthDate = new DateTime(1964, 12, 13), Gender = 'M', SickLeaveHours = 21 });
            _Employees.Add(new Employee { ID = 4, Name = "Rob Walters", Manager = 3, BirthDate = new DateTime(1965, 1, 23), Gender = 'M', SickLeaveHours = 80 });
            _Employees.Add(new Employee { ID = 5, Name = "Thierry D'Hers", Manager = 263, BirthDate = new DateTime(1949, 8, 29), Gender = 'M', SickLeaveHours = 24 });
            _Employees.Add(new Employee { ID = 6, Name = "David Bradley", Manager = 109, BirthDate = new DateTime(1965, 4, 19), Gender = 'M', SickLeaveHours = 40 });
            _Employees.Add(new Employee { ID = 7, Name = "JoLynn Dobney", Manager = 21, BirthDate = new DateTime(1946, 2, 16), Gender = 'F', SickLeaveHours = 61 });
            _Employees.Add(new Employee { ID = 8, Name = "Ruth Ellerbrock", Manager = 185, BirthDate = new DateTime(1946, 7, 6), Gender = 'F', SickLeaveHours = 61 });
            _Employees.Add(new Employee { ID = 9, Name = "Gail Erickson", Manager = 3, BirthDate = new DateTime(1942, 10, 29), Gender = 'F', SickLeaveHours = 22 });
            _Employees.Add(new Employee { ID = 10, Name = "Barry Johnson", Manager = 185, BirthDate = new DateTime(1946, 4, 27), Gender = 'M', SickLeaveHours = 64 });
            _Employees.Add(new Employee { ID = 11, Name = "Jossef Goldberg", Manager = 3, BirthDate = new DateTime(1949, 4, 11), Gender = 'M', SickLeaveHours = 23 });
            _Employees.Add(new Employee { ID = 12, Name = "Terri Duffy", Manager = 109, BirthDate = new DateTime(1961, 9, 1), Gender = 'F', SickLeaveHours = 20 });
            _Employees.Add(new Employee { ID = 13, Name = "Sidney Higa", Manager = 185, BirthDate = new DateTime(1946, 10, 1), Gender = 'M', SickLeaveHours = 62 });
            _Employees.Add(new Employee { ID = 14, Name = "Taylor Maxwell", Manager = 21, BirthDate = new DateTime(1946, 5, 3), Gender = 'M', SickLeaveHours = 59 });
            _Employees.Add(new Employee { ID = 15, Name = "Jeffrey Ford", Manager = 185, BirthDate = new DateTime(1946, 8, 12), Gender = 'M', SickLeaveHours = 62 });
            _Employees.Add(new Employee { ID = 16, Name = "Jo Brown", Manager = 21, BirthDate = new DateTime(1946, 11, 9), Gender = 'F', SickLeaveHours = 60 });
            _Employees.Add(new Employee { ID = 17, Name = "Doris Hartwig", Manager = 185, BirthDate = new DateTime(1946, 5, 6), Gender = 'F', SickLeaveHours = 63 });
            _Employees.Add(new Employee { ID = 18, Name = "John Campbell", Manager = 21, BirthDate = new DateTime(1946, 9, 8), Gender = 'M', SickLeaveHours = 60 });
            _Employees.Add(new Employee { ID = 19, Name = "Diane Glimp", Manager = 185, BirthDate = new DateTime(1946, 4, 30), Gender = 'F', SickLeaveHours = 63 });
            _Employees.Add(new Employee { ID = 20, Name = "Steven Selikoff", Manager = 173, BirthDate = new DateTime(1967, 6, 15), Gender = 'M', SickLeaveHours = 40 });
            _Employees.Add(new Employee { ID = 21, Name = "Peter Krebs", Manager = 148, BirthDate = new DateTime(1972, 12, 4), Gender = 'M', SickLeaveHours = 41 });
            _Employees.Add(new Employee { ID = 22, Name = "Stuart Munson", Manager = 197, BirthDate = new DateTime(1952, 10, 14), Gender = 'M', SickLeaveHours = 62 });
            _Employees.Add(new Employee { ID = 23, Name = "Greg Alderson", Manager = 197, BirthDate = new DateTime(1960, 11, 18), Gender = 'M', SickLeaveHours = 62 });
            _Employees.Add(new Employee { ID = 24, Name = "David Johnson", Manager = 184, BirthDate = new DateTime(1969, 12, 3), Gender = 'M', SickLeaveHours = 32 });
            _Employees.Add(new Employee { ID = 25, Name = "Zheng Mu", Manager = 21, BirthDate = new DateTime(1973, 11, 26), Gender = 'M', SickLeaveHours = 53 });
            _Employees.Add(new Employee { ID = 26, Name = "Ivo Salmre", Manager = 108, BirthDate = new DateTime(1972, 2, 4), Gender = 'M', SickLeaveHours = 24 });
            _Employees.Add(new Employee { ID = 27, Name = "Paul Komosinski", Manager = 87, BirthDate = new DateTime(1970, 12, 15), Gender = 'M', SickLeaveHours = 54 });
            _Employees.Add(new Employee { ID = 28, Name = "Ashvini Sharma", Manager = 150, BirthDate = new DateTime(1967, 4, 28), Gender = 'M', SickLeaveHours = 55 });
            _Employees.Add(new Employee { ID = 29, Name = "Kendall Keil", Manager = 14, BirthDate = new DateTime(1976, 6, 30), Gender = 'M', SickLeaveHours = 25 });
            _Employees.Add(new Employee { ID = 30, Name = "Paula Barreto de Mattos", Manager = 140, BirthDate = new DateTime(1966, 3, 14), Gender = 'F', SickLeaveHours = 47 });
            _Employees.Add(new Employee { ID = 31, Name = "Alejandro McGuel", Manager = 210, BirthDate = new DateTime(1979, 1, 6), Gender = 'M', SickLeaveHours = 46 });
            _Employees.Add(new Employee { ID = 32, Name = "Garrett Young", Manager = 184, BirthDate = new DateTime(1974, 9, 26), Gender = 'M', SickLeaveHours = 37 });
            _Employees.Add(new Employee { ID = 33, Name = "Jian Shuo Wang", Manager = 135, BirthDate = new DateTime(1973, 8, 27), Gender = 'M', SickLeaveHours = 38 });
            _Employees.Add(new Employee { ID = 34, Name = "Susan Eaton", Manager = 85, BirthDate = new DateTime(1968, 3, 20), Gender = 'F', SickLeaveHours = 68 });
            _Employees.Add(new Employee { ID = 35, Name = "Vamsi Kuppa", Manager = 85, BirthDate = new DateTime(1967, 4, 19), Gender = 'M', SickLeaveHours = 67 });
            _Employees.Add(new Employee { ID = 36, Name = "Alice Ciccu", Manager = 38, BirthDate = new DateTime(1968, 2, 27), Gender = 'F', SickLeaveHours = 67 });
            _Employees.Add(new Employee { ID = 37, Name = "Simon Rapier", Manager = 7, BirthDate = new DateTime(1980, 6, 17), Gender = 'M', SickLeaveHours = 39 });
            _Employees.Add(new Employee { ID = 38, Name = "Jinghao Liu", Manager = 21, BirthDate = new DateTime(1979, 3, 9), Gender = 'M', SickLeaveHours = 58 });
            _Employees.Add(new Employee { ID = 39, Name = "Michael Hines", Manager = 182, BirthDate = new DateTime(1974, 12, 19), Gender = 'M', SickLeaveHours = 30 });
            _Employees.Add(new Employee { ID = 40, Name = "Yvonne McKay", Manager = 159, BirthDate = new DateTime(1979, 5, 17), Gender = 'F', SickLeaveHours = 59 });
            _Employees.Add(new Employee { ID = 41, Name = "Peng Wu", Manager = 200, BirthDate = new DateTime(1966, 4, 19), Gender = 'M', SickLeaveHours = 60 });
            _Employees.Add(new Employee { ID = 42, Name = "Jean Trenary", Manager = 109, BirthDate = new DateTime(1966, 1, 13), Gender = 'F', SickLeaveHours = 52 });
            _Employees.Add(new Employee { ID = 43, Name = "Russell Hunter", Manager = 74, BirthDate = new DateTime(1962, 12, 27), Gender = 'M', SickLeaveHours = 23 });
            _Employees.Add(new Employee { ID = 44, Name = "A. Scott Wright", Manager = 148, BirthDate = new DateTime(1958, 10, 19), Gender = 'M', SickLeaveHours = 42 });
            _Employees.Add(new Employee { ID = 45, Name = "Fred Northup", Manager = 210, BirthDate = new DateTime(1979, 7, 27), Gender = 'M', SickLeaveHours = 43 });
            _Employees.Add(new Employee { ID = 46, Name = "Sariya Harnpadoungsataya", Manager = 6, BirthDate = new DateTime(1977, 6, 21), Gender = 'M', SickLeaveHours = 42 });
            _Employees.Add(new Employee { ID = 47, Name = "Willis Johnson", Manager = 30, BirthDate = new DateTime(1968, 8, 18), Gender = 'M', SickLeaveHours = 44 });
            _Employees.Add(new Employee { ID = 48, Name = "Jun Cao", Manager = 38, BirthDate = new DateTime(1969, 8, 6), Gender = 'M', SickLeaveHours = 65 });
            _Employees.Add(new Employee { ID = 49, Name = "Christian Kleinerman", Manager = 218, BirthDate = new DateTime(1966, 2, 18), Gender = 'M', SickLeaveHours = 66 });
            _Employees.Add(new Employee { ID = 50, Name = "Susan Metters", Manager = 184, BirthDate = new DateTime(1973, 5, 3), Gender = 'F', SickLeaveHours = 35 });
            _Employees.Add(new Employee { ID = 51, Name = "Reuben D'sa", Manager = 21, BirthDate = new DateTime(1977, 9, 27), Gender = 'M', SickLeaveHours = 56 });
            _Employees.Add(new Employee { ID = 52, Name = "Kirk Koenigsbauer", Manager = 123, BirthDate = new DateTime(1975, 3, 10), Gender = 'M', SickLeaveHours = 57 });
            _Employees.Add(new Employee { ID = 53, Name = "David Ortiz", Manager = 18, BirthDate = new DateTime(1975, 1, 30), Gender = 'M', SickLeaveHours = 36 });
            _Employees.Add(new Employee { ID = 54, Name = "Tengiz Kharatishvili", Manager = 90, BirthDate = new DateTime(1980, 5, 29), Gender = 'M', SickLeaveHours = 58 });
            _Employees.Add(new Employee { ID = 55, Name = "Hanying Feng", Manager = 143, BirthDate = new DateTime(1964, 11, 16), Gender = 'M', SickLeaveHours = 27 });
            _Employees.Add(new Employee { ID = 56, Name = "Kevin Liu", Manager = 210, BirthDate = new DateTime(1976, 1, 26), Gender = 'M', SickLeaveHours = 49 });
            _Employees.Add(new Employee { ID = 57, Name = "Annik Stahl", Manager = 16, BirthDate = new DateTime(1967, 1, 27), Gender = 'M', SickLeaveHours = 28 });
            _Employees.Add(new Employee { ID = 58, Name = "Suroor Fatima", Manager = 38, BirthDate = new DateTime(1968, 3, 28), Gender = 'M', SickLeaveHours = 66 });
            _Employees.Add(new Employee { ID = 59, Name = "Deborah Poe", Manager = 139, BirthDate = new DateTime(1966, 4, 7), Gender = 'F', SickLeaveHours = 50 });
            _Employees.Add(new Employee { ID = 60, Name = "Jim Scardelis", Manager = 74, BirthDate = new DateTime(1976, 10, 9), Gender = 'M', SickLeaveHours = 20 });
            _Employees.Add(new Employee { ID = 61, Name = "Carole Poland", Manager = 173, BirthDate = new DateTime(1973, 11, 19), Gender = 'F', SickLeaveHours = 41 });
            _Employees.Add(new Employee { ID = 62, Name = "George Li", Manager = 184, BirthDate = new DateTime(1967, 5, 18), Gender = 'M', SickLeaveHours = 33 });
            _Employees.Add(new Employee { ID = 63, Name = "Gary Yukish", Manager = 87, BirthDate = new DateTime(1978, 6, 17), Gender = 'M', SickLeaveHours = 54 });
            _Employees.Add(new Employee { ID = 64, Name = "Cristian Petculescu", Manager = 21, BirthDate = new DateTime(1974, 5, 13), Gender = 'M', SickLeaveHours = 53 });
            _Employees.Add(new Employee { ID = 65, Name = "Raymond Sam", Manager = 143, BirthDate = new DateTime(1957, 4, 2), Gender = 'M', SickLeaveHours = 25 });
            _Employees.Add(new Employee { ID = 66, Name = "Janaina Bueno", Manager = 42, BirthDate = new DateTime(1975, 3, 3), Gender = 'F', SickLeaveHours = 55 });
            _Employees.Add(new Employee { ID = 67, Name = "Bob Hohman", Manager = 14, BirthDate = new DateTime(1969, 9, 16), Gender = 'M', SickLeaveHours = 26 });
            _Employees.Add(new Employee { ID = 68, Name = "Shammi Mohamed", Manager = 210, BirthDate = new DateTime(1970, 11, 5), Gender = 'M', SickLeaveHours = 46 });
            _Employees.Add(new Employee { ID = 69, Name = "Linda Moschell", Manager = 38, BirthDate = new DateTime(1977, 8, 17), Gender = 'F', SickLeaveHours = 68 });
            _Employees.Add(new Employee { ID = 70, Name = "Mindy Martin", Manager = 30, BirthDate = new DateTime(1974, 12, 22), Gender = 'F', SickLeaveHours = 45 });
            _Employees.Add(new Employee { ID = 71, Name = "Wendy Kahn", Manager = 140, BirthDate = new DateTime(1974, 11, 12), Gender = 'F', SickLeaveHours = 47 });
            _Employees.Add(new Employee { ID = 72, Name = "Kim Ralls", Manager = 85, BirthDate = new DateTime(1974, 6, 1), Gender = 'F', SickLeaveHours = 69 });
            _Employees.Add(new Employee { ID = 73, Name = "Sandra Reátegui Alayo", Manager = 135, BirthDate = new DateTime(1965, 12, 6), Gender = 'F', SickLeaveHours = 38 });
            _Employees.Add(new Employee { ID = 74, Name = "Kok-Ho Loh", Manager = 21, BirthDate = new DateTime(1970, 5, 30), Gender = 'M', SickLeaveHours = 59 });
            _Employees.Add(new Employee { ID = 75, Name = "Douglas Hite", Manager = 159, BirthDate = new DateTime(1975, 12, 26), Gender = 'M', SickLeaveHours = 60 });
            _Employees.Add(new Employee { ID = 76, Name = "James Kramer", Manager = 7, BirthDate = new DateTime(1974, 8, 26), Gender = 'M', SickLeaveHours = 39 });
            _Employees.Add(new Employee { ID = 77, Name = "Sean Alexander", Manager = 41, BirthDate = new DateTime(1966, 4, 7), Gender = 'M', SickLeaveHours = 61 });
            _Employees.Add(new Employee { ID = 78, Name = "Nitin Mirchandani", Manager = 182, BirthDate = new DateTime(1977, 1, 1), Gender = 'M', SickLeaveHours = 30 });
            _Employees.Add(new Employee { ID = 79, Name = "Diane Margheim", Manager = 158, BirthDate = new DateTime(1976, 7, 6), Gender = 'F', SickLeaveHours = 51 });
            _Employees.Add(new Employee { ID = 80, Name = "Rebecca Laszlo", Manager = 16, BirthDate = new DateTime(1967, 8, 11), Gender = 'F', SickLeaveHours = 31 });
            _Employees.Add(new Employee { ID = 81, Name = "Rajesh Patel", Manager = 210, BirthDate = new DateTime(1967, 11, 5), Gender = 'M', SickLeaveHours = 44 });
            _Employees.Add(new Employee { ID = 82, Name = "Vidur Luthra", Manager = 30, BirthDate = new DateTime(1974, 9, 2), Gender = 'M', SickLeaveHours = 45 });
            _Employees.Add(new Employee { ID = 83, Name = "John Evans", Manager = 38, BirthDate = new DateTime(1968, 7, 1), Gender = 'M', SickLeaveHours = 65 });
            _Employees.Add(new Employee { ID = 84, Name = "Nancy Anderson", Manager = 7, BirthDate = new DateTime(1978, 12, 21), Gender = 'F', SickLeaveHours = 37 });
            _Employees.Add(new Employee { ID = 85, Name = "Pilar Ackerman", Manager = 21, BirthDate = new DateTime(1962, 10, 11), Gender = 'M', SickLeaveHours = 66 });
            _Employees.Add(new Employee { ID = 86, Name = "David Yalovsky", Manager = 184, BirthDate = new DateTime(1971, 9, 4), Gender = 'M', SickLeaveHours = 36 });
            _Employees.Add(new Employee { ID = 87, Name = "David Hamilton", Manager = 21, BirthDate = new DateTime(1973, 8, 2), Gender = 'M', SickLeaveHours = 56 });
            _Employees.Add(new Employee { ID = 88, Name = "Laura Steele", Manager = 123, BirthDate = new DateTime(1971, 1, 26), Gender = 'F', SickLeaveHours = 57 });
            _Employees.Add(new Employee { ID = 89, Name = "Margie Shoop", Manager = 16, BirthDate = new DateTime(1976, 6, 20), Gender = 'F', SickLeaveHours = 29 });
            _Employees.Add(new Employee { ID = 90, Name = "Zainal Arifin", Manager = 200, BirthDate = new DateTime(1966, 3, 2), Gender = 'M', SickLeaveHours = 58 });
            _Employees.Add(new Employee { ID = 91, Name = "Lorraine Nay", Manager = 210, BirthDate = new DateTime(1978, 12, 28), Gender = 'F', SickLeaveHours = 44 });
            _Employees.Add(new Employee { ID = 92, Name = "Fadi Fakhouri", Manager = 143, BirthDate = new DateTime(1979, 3, 19), Gender = 'M', SickLeaveHours = 28 });
            _Employees.Add(new Employee { ID = 93, Name = "Ryan Cornelsen", Manager = 51, BirthDate = new DateTime(1962, 7, 15), Gender = 'M', SickLeaveHours = 49 });
            _Employees.Add(new Employee { ID = 94, Name = "Candy Spoon", Manager = 139, BirthDate = new DateTime(1966, 3, 26), Gender = 'F', SickLeaveHours = 50 });
            _Employees.Add(new Employee { ID = 95, Name = "Nuan Yu", Manager = 74, BirthDate = new DateTime(1969, 4, 29), Gender = 'M', SickLeaveHours = 21 });
            _Employees.Add(new Employee { ID = 96, Name = "William Vong", Manager = 44, BirthDate = new DateTime(1971, 12, 8), Gender = 'M', SickLeaveHours = 42 });
            _Employees.Add(new Employee { ID = 97, Name = "Bjorn Rettig", Manager = 173, BirthDate = new DateTime(1979, 12, 8), Gender = 'M', SickLeaveHours = 41 });
            _Employees.Add(new Employee { ID = 98, Name = "Scott Gode", Manager = 197, BirthDate = new DateTime(1977, 3, 13), Gender = 'M', SickLeaveHours = 63 });
            _Employees.Add(new Employee { ID = 99, Name = "Michael Rothkugel", Manager = 87, BirthDate = new DateTime(1981, 2, 4), Gender = 'M', SickLeaveHours = 55 });
            _Employees.Add(new Employee { ID = 100, Name = "Lane Sacksteder", Manager = 143, BirthDate = new DateTime(1964, 10, 24), Gender = 'M', SickLeaveHours = 25 });
            _Employees.Add(new Employee { ID = 101, Name = "Pete Male", Manager = 14, BirthDate = new DateTime(1967, 3, 7), Gender = 'M', SickLeaveHours = 26 });
            _Employees.Add(new Employee { ID = 102, Name = "Dan Bacon", Manager = 42, BirthDate = new DateTime(1971, 7, 28), Gender = 'M', SickLeaveHours = 56 });
            _Employees.Add(new Employee { ID = 103, Name = "David Barber", Manager = 140, BirthDate = new DateTime(1954, 7, 23), Gender = 'M', SickLeaveHours = 48 });
            _Employees.Add(new Employee { ID = 104, Name = "Lolan Song", Manager = 74, BirthDate = new DateTime(1963, 2, 25), Gender = 'M', SickLeaveHours = 23 });
            _Employees.Add(new Employee { ID = 105, Name = "Paula Nartker", Manager = 210, BirthDate = new DateTime(1977, 3, 13), Gender = 'F', SickLeaveHours = 47 });
            _Employees.Add(new Employee { ID = 106, Name = "Mary Gibson", Manager = 6, BirthDate = new DateTime(1952, 10, 14), Gender = 'F', SickLeaveHours = 43 });
            _Employees.Add(new Employee { ID = 107, Name = "Mindaugas Krapauskas", Manager = 38, BirthDate = new DateTime(1968, 6, 7), Gender = 'M', SickLeaveHours = 68 });
            _Employees.Add(new Employee { ID = 108, Name = "Eric Gubbels", Manager = 21, BirthDate = new DateTime(1975, 2, 20), Gender = 'M', SickLeaveHours = 40 });
            _Employees.Add(new Employee { ID = 109, Name = "Ken Sánchez", Manager = null, BirthDate = new DateTime(1959, 3, 2), Gender = 'M', SickLeaveHours = 69 });
            _Employees.Add(new Employee { ID = 110, Name = "Jason Watters", Manager = 135, BirthDate = new DateTime(1979, 1, 8), Gender = 'M', SickLeaveHours = 39 });
            _Employees.Add(new Employee { ID = 111, Name = "Mark Harrington", Manager = 41, BirthDate = new DateTime(1976, 5, 31), Gender = 'M', SickLeaveHours = 61 });
            _Employees.Add(new Employee { ID = 112, Name = "Janeth Esteves", Manager = 159, BirthDate = new DateTime(1962, 8, 25), Gender = 'F', SickLeaveHours = 60 });
            _Employees.Add(new Employee { ID = 113, Name = "Marc Ingle", Manager = 184, BirthDate = new DateTime(1976, 11, 24), Gender = 'M', SickLeaveHours = 31 });
            _Employees.Add(new Employee { ID = 114, Name = "Gigi Matthew", Manager = 158, BirthDate = new DateTime(1969, 2, 21), Gender = 'F', SickLeaveHours = 51 });
            _Employees.Add(new Employee { ID = 115, Name = "Paul Singh", Manager = 108, BirthDate = new DateTime(1980, 12, 5), Gender = 'M', SickLeaveHours = 23 });
            _Employees.Add(new Employee { ID = 116, Name = "Frank Lee", Manager = 210, BirthDate = new DateTime(1977, 10, 7), Gender = 'M', SickLeaveHours = 48 });
            _Employees.Add(new Employee { ID = 117, Name = "François Ajenstat", Manager = 42, BirthDate = new DateTime(1965, 6, 17), Gender = 'M', SickLeaveHours = 53 });
            _Employees.Add(new Employee { ID = 118, Name = "Diane Tibbott", Manager = 14, BirthDate = new DateTime(1979, 9, 10), Gender = 'F', SickLeaveHours = 24 });
            _Employees.Add(new Employee { ID = 119, Name = "Jill Williams", Manager = 6, BirthDate = new DateTime(1969, 7, 19), Gender = 'F', SickLeaveHours = 43 });
            _Employees.Add(new Employee { ID = 120, Name = "Angela Barbariol", Manager = 38, BirthDate = new DateTime(1981, 7, 1), Gender = 'F', SickLeaveHours = 66 });
            _Employees.Add(new Employee { ID = 121, Name = "Matthias Berndt", Manager = 85, BirthDate = new DateTime(1963, 12, 13), Gender = 'M', SickLeaveHours = 67 });
            _Employees.Add(new Employee { ID = 122, Name = "Bryan Baker", Manager = 7, BirthDate = new DateTime(1963, 9, 28), Gender = 'M', SickLeaveHours = 37 });
            _Employees.Add(new Employee { ID = 123, Name = "Jeff Hay", Manager = 21, BirthDate = new DateTime(1967, 2, 16), Gender = 'M', SickLeaveHours = 57 });
            _Employees.Add(new Employee { ID = 124, Name = "Eugene Zabokritski", Manager = 184, BirthDate = new DateTime(1977, 8, 15), Gender = 'M', SickLeaveHours = 36 });
            _Employees.Add(new Employee { ID = 125, Name = "Barbara Decker", Manager = 182, BirthDate = new DateTime(1969, 8, 2), Gender = 'F', SickLeaveHours = 28 });
            _Employees.Add(new Employee { ID = 126, Name = "Chris Preston", Manager = 123, BirthDate = new DateTime(1979, 1, 17), Gender = 'M', SickLeaveHours = 58 });
            _Employees.Add(new Employee { ID = 127, Name = "Sean Chai", Manager = 90, BirthDate = new DateTime(1977, 4, 12), Gender = 'M', SickLeaveHours = 59 });
            _Employees.Add(new Employee { ID = 128, Name = "Dan Wilson", Manager = 42, BirthDate = new DateTime(1966, 2, 6), Gender = 'M', SickLeaveHours = 53 });
            _Employees.Add(new Employee { ID = 129, Name = "Mark McArthur", Manager = 16, BirthDate = new DateTime(1969, 10, 26), Gender = 'M', SickLeaveHours = 29 });
            _Employees.Add(new Employee { ID = 130, Name = "Bryan Walton", Manager = 139, BirthDate = new DateTime(1974, 10, 22), Gender = 'M', SickLeaveHours = 51 });
            _Employees.Add(new Employee { ID = 131, Name = "Houman Pournasseh", Manager = 74, BirthDate = new DateTime(1961, 9, 30), Gender = 'M', SickLeaveHours = 21 });
            _Employees.Add(new Employee { ID = 132, Name = "Sairaj Uddin", Manager = 44, BirthDate = new DateTime(1978, 1, 22), Gender = 'M', SickLeaveHours = 43 });
            _Employees.Add(new Employee { ID = 133, Name = "Michiko Osada", Manager = 173, BirthDate = new DateTime(1972, 7, 28), Gender = 'M', SickLeaveHours = 42 });
            _Employees.Add(new Employee { ID = 134, Name = "Benjamin Martin", Manager = 184, BirthDate = new DateTime(1976, 2, 6), Gender = 'M', SickLeaveHours = 34 });
            _Employees.Add(new Employee { ID = 135, Name = "Cynthia Randall", Manager = 21, BirthDate = new DateTime(1971, 9, 19), Gender = 'F', SickLeaveHours = 54 });
            _Employees.Add(new Employee { ID = 136, Name = "Kathie Flood", Manager = 197, BirthDate = new DateTime(1980, 12, 2), Gender = 'F', SickLeaveHours = 63 });
            _Employees.Add(new Employee { ID = 137, Name = "Britta Simon", Manager = 16, BirthDate = new DateTime(1979, 10, 30), Gender = 'F', SickLeaveHours = 27 });
            _Employees.Add(new Employee { ID = 138, Name = "Brian Lloyd", Manager = 210, BirthDate = new DateTime(1967, 3, 14), Gender = 'M', SickLeaveHours = 47 });
            _Employees.Add(new Employee { ID = 139, Name = "David Liu", Manager = 140, BirthDate = new DateTime(1973, 8, 8), Gender = 'M', SickLeaveHours = 48 });
            _Employees.Add(new Employee { ID = 140, Name = "Laura Norman", Manager = 109, BirthDate = new DateTime(1966, 2, 6), Gender = 'F', SickLeaveHours = 20 });
            _Employees.Add(new Employee { ID = 141, Name = "Michael Patten", Manager = 38, BirthDate = new DateTime(1964, 6, 3), Gender = 'M', SickLeaveHours = 69 });
            _Employees.Add(new Employee { ID = 142, Name = "Andy Ruth", Manager = 135, BirthDate = new DateTime(1973, 11, 20), Gender = 'M', SickLeaveHours = 39 });
            _Employees.Add(new Employee { ID = 143, Name = "Yuhong Li", Manager = 21, BirthDate = new DateTime(1967, 5, 8), Gender = 'M', SickLeaveHours = 40 });
            _Employees.Add(new Employee { ID = 144, Name = "Robert Rounthwaite", Manager = 159, BirthDate = new DateTime(1975, 4, 1), Gender = 'M', SickLeaveHours = 61 });
            _Employees.Add(new Employee { ID = 145, Name = "Andreas Berglund", Manager = 41, BirthDate = new DateTime(1979, 4, 29), Gender = 'M', SickLeaveHours = 62 });
            _Employees.Add(new Employee { ID = 146, Name = "Reed Koch", Manager = 184, BirthDate = new DateTime(1979, 2, 9), Gender = 'M', SickLeaveHours = 31 });
            _Employees.Add(new Employee { ID = 147, Name = "Linda Randall", Manager = 143, BirthDate = new DateTime(1967, 11, 6), Gender = 'F', SickLeaveHours = 26 });
            _Employees.Add(new Employee { ID = 148, Name = "James Hamilton", Manager = 109, BirthDate = new DateTime(1973, 2, 7), Gender = 'M', SickLeaveHours = 52 });
            _Employees.Add(new Employee { ID = 149, Name = "Ramesh Meyyappan", Manager = 42, BirthDate = new DateTime(1978, 4, 14), Gender = 'M', SickLeaveHours = 56 });
            _Employees.Add(new Employee { ID = 150, Name = "Stephanie Conroy", Manager = 42, BirthDate = new DateTime(1974, 4, 26), Gender = 'F', SickLeaveHours = 54 });
            _Employees.Add(new Employee { ID = 151, Name = "Samantha Smith", Manager = 108, BirthDate = new DateTime(1977, 12, 23), Gender = 'F', SickLeaveHours = 23 });
            _Employees.Add(new Employee { ID = 152, Name = "Tawana Nusbaum", Manager = 210, BirthDate = new DateTime(1979, 12, 12), Gender = 'M', SickLeaveHours = 45 });
            _Employees.Add(new Employee { ID = 153, Name = "Denise Smith", Manager = 14, BirthDate = new DateTime(1978, 8, 7), Gender = 'F', SickLeaveHours = 24 });
            _Employees.Add(new Employee { ID = 154, Name = "Hao Chen", Manager = 30, BirthDate = new DateTime(1967, 5, 19), Gender = 'M', SickLeaveHours = 46 });
            _Employees.Add(new Employee { ID = 155, Name = "Alex Nayberg", Manager = 123, BirthDate = new DateTime(1980, 5, 14), Gender = 'M', SickLeaveHours = 58 });
            _Employees.Add(new Employee { ID = 156, Name = "Eugene Kogan", Manager = 7, BirthDate = new DateTime(1966, 3, 13), Gender = 'M', SickLeaveHours = 38 });
            _Employees.Add(new Employee { ID = 157, Name = "Brandon Heidepriem", Manager = 16, BirthDate = new DateTime(1967, 2, 11), Gender = 'M', SickLeaveHours = 31 });
            _Employees.Add(new Employee { ID = 158, Name = "Dylan Miller", Manager = 3, BirthDate = new DateTime(1977, 3, 27), Gender = 'M', SickLeaveHours = 50 });
            _Employees.Add(new Employee { ID = 159, Name = "Shane Kim", Manager = 21, BirthDate = new DateTime(1980, 6, 24), Gender = 'M', SickLeaveHours = 57 });
            _Employees.Add(new Employee { ID = 160, Name = "John Chen", Manager = 182, BirthDate = new DateTime(1976, 5, 6), Gender = 'M', SickLeaveHours = 29 });
            _Employees.Add(new Employee { ID = 161, Name = "Karen Berge", Manager = 90, BirthDate = new DateTime(1966, 1, 25), Gender = 'F', SickLeaveHours = 59 });
            _Employees.Add(new Employee { ID = 162, Name = "Jose Lugo", Manager = 16, BirthDate = new DateTime(1974, 9, 1), Gender = 'M', SickLeaveHours = 30 });
            _Employees.Add(new Employee { ID = 163, Name = "Mandar Samant", Manager = 74, BirthDate = new DateTime(1976, 4, 21), Gender = 'M', SickLeaveHours = 20 });
            _Employees.Add(new Employee { ID = 164, Name = "Mikael Sandberg", Manager = 274, BirthDate = new DateTime(1974, 9, 18), Gender = 'M', SickLeaveHours = 49 });
            _Employees.Add(new Employee { ID = 165, Name = "Sameer Tejani", Manager = 74, BirthDate = new DateTime(1968, 7, 27), Gender = 'M', SickLeaveHours = 22 });
            _Employees.Add(new Employee { ID = 166, Name = "Dragan Tomic", Manager = 139, BirthDate = new DateTime(1967, 3, 18), Gender = 'M', SickLeaveHours = 51 });
            _Employees.Add(new Employee { ID = 167, Name = "Carol Philips", Manager = 173, BirthDate = new DateTime(1978, 11, 18), Gender = 'F', SickLeaveHours = 42 });
            _Employees.Add(new Employee { ID = 168, Name = "Rob Caron", Manager = 87, BirthDate = new DateTime(1963, 9, 5), Gender = 'M', SickLeaveHours = 55 });
            _Employees.Add(new Employee { ID = 169, Name = "Don Hall", Manager = 38, BirthDate = new DateTime(1961, 7, 14), Gender = 'M', SickLeaveHours = 64 });
            _Employees.Add(new Employee { ID = 170, Name = "Alan Brewer", Manager = 44, BirthDate = new DateTime(1974, 4, 30), Gender = 'M', SickLeaveHours = 43 });
            _Employees.Add(new Employee { ID = 171, Name = "David Lawrence", Manager = 184, BirthDate = new DateTime(1975, 10, 25), Gender = 'M', SickLeaveHours = 34 });
            _Employees.Add(new Employee { ID = 172, Name = "Baris Cetinok", Manager = 87, BirthDate = new DateTime(1980, 11, 7), Gender = 'M', SickLeaveHours = 56 });
            _Employees.Add(new Employee { ID = 173, Name = "Michael Ray", Manager = 21, BirthDate = new DateTime(1979, 3, 2), Gender = 'M', SickLeaveHours = 55 });
            _Employees.Add(new Employee { ID = 174, Name = "Steve Masters", Manager = 18, BirthDate = new DateTime(1981, 5, 7), Gender = 'M', SickLeaveHours = 35 });
            _Employees.Add(new Employee { ID = 175, Name = "Suchitra Mohan", Manager = 16, BirthDate = new DateTime(1977, 7, 11), Gender = 'F', SickLeaveHours = 27 });
            _Employees.Add(new Employee { ID = 176, Name = "Karen Berg", Manager = 42, BirthDate = new DateTime(1968, 6, 19), Gender = 'F', SickLeaveHours = 57 });
            _Employees.Add(new Employee { ID = 177, Name = "Terrence Earls", Manager = 143, BirthDate = new DateTime(1975, 1, 9), Gender = 'M', SickLeaveHours = 26 });
            _Employees.Add(new Employee { ID = 178, Name = "Barbara Moreland", Manager = 139, BirthDate = new DateTime(1966, 2, 4), Gender = 'F', SickLeaveHours = 49 });
            _Employees.Add(new Employee { ID = 179, Name = "Chad Niswonger", Manager = 38, BirthDate = new DateTime(1980, 9, 4), Gender = 'M', SickLeaveHours = 69 });
            _Employees.Add(new Employee { ID = 180, Name = "Rostislav Shabalin", Manager = 135, BirthDate = new DateTime(1967, 10, 15), Gender = 'M', SickLeaveHours = 40 });
            _Employees.Add(new Employee { ID = 181, Name = "Belinda Newman", Manager = 197, BirthDate = new DateTime(1959, 10, 19), Gender = 'F', SickLeaveHours = 61 });
            _Employees.Add(new Employee { ID = 182, Name = "Katie McAskill-White", Manager = 21, BirthDate = new DateTime(1974, 12, 20), Gender = 'F', SickLeaveHours = 41 });
            _Employees.Add(new Employee { ID = 183, Name = "Russell King", Manager = 184, BirthDate = new DateTime(1972, 3, 14), Gender = 'M', SickLeaveHours = 32 });
            _Employees.Add(new Employee { ID = 184, Name = "Jack Richins", Manager = 21, BirthDate = new DateTime(1973, 7, 23), Gender = 'M', SickLeaveHours = 54 });
            _Employees.Add(new Employee { ID = 185, Name = "Andrew Hill", Manager = 21, BirthDate = new DateTime(1978, 10, 8), Gender = 'M', SickLeaveHours = 52 });
            _Employees.Add(new Employee { ID = 186, Name = "Nicole Holliday", Manager = 87, BirthDate = new DateTime(1976, 5, 10), Gender = 'F', SickLeaveHours = 53 });
            _Employees.Add(new Employee { ID = 187, Name = "Frank Miller", Manager = 14, BirthDate = new DateTime(1961, 8, 24), Gender = 'M', SickLeaveHours = 25 });
            _Employees.Add(new Employee { ID = 188, Name = "Peter Connelly", Manager = 150, BirthDate = new DateTime(1970, 6, 29), Gender = 'M', SickLeaveHours = 54 });
            _Employees.Add(new Employee { ID = 189, Name = "Anibal Sousa", Manager = 108, BirthDate = new DateTime(1964, 10, 6), Gender = 'F', SickLeaveHours = 24 });
            _Employees.Add(new Employee { ID = 190, Name = "Ken Myer", Manager = 210, BirthDate = new DateTime(1971, 6, 29), Gender = 'M', SickLeaveHours = 45 });
            _Employees.Add(new Employee { ID = 191, Name = "Grant Culbertson", Manager = 30, BirthDate = new DateTime(1966, 5, 18), Gender = 'M', SickLeaveHours = 46 });
            _Employees.Add(new Employee { ID = 192, Name = "Michael Entin", Manager = 38, BirthDate = new DateTime(1979, 7, 17), Gender = 'M', SickLeaveHours = 67 });
            _Employees.Add(new Employee { ID = 193, Name = "Lionel Penuchot", Manager = 159, BirthDate = new DateTime(1978, 4, 15), Gender = 'M', SickLeaveHours = 59 });
            _Employees.Add(new Employee { ID = 194, Name = "Thomas Michaels", Manager = 7, BirthDate = new DateTime(1976, 2, 11), Gender = 'M', SickLeaveHours = 38 });
            _Employees.Add(new Employee { ID = 195, Name = "Jimmy Bischoff", Manager = 85, BirthDate = new DateTime(1975, 6, 5), Gender = 'M', SickLeaveHours = 68 });
            _Employees.Add(new Employee { ID = 196, Name = "Michael Vanderhyde", Manager = 135, BirthDate = new DateTime(1972, 10, 19), Gender = 'M', SickLeaveHours = 37 });
            _Employees.Add(new Employee { ID = 197, Name = "Lori Kane", Manager = 21, BirthDate = new DateTime(1970, 8, 19), Gender = 'F', SickLeaveHours = 58 });
            _Employees.Add(new Employee { ID = 198, Name = "Arvind Rao", Manager = 274, BirthDate = new DateTime(1964, 9, 21), Gender = 'M', SickLeaveHours = 50 });
            _Employees.Add(new Employee { ID = 199, Name = "Stefen Hesse", Manager = 182, BirthDate = new DateTime(1966, 1, 21), Gender = 'M', SickLeaveHours = 29 });
            _Employees.Add(new Employee { ID = 200, Name = "Hazem Abolrous", Manager = 148, BirthDate = new DateTime(1967, 11, 27), Gender = 'M', SickLeaveHours = 60 });
            _Employees.Add(new Employee { ID = 201, Name = "Janet Sheperdigian", Manager = 139, BirthDate = new DateTime(1969, 4, 9), Gender = 'F', SickLeaveHours = 52 });
            _Employees.Add(new Employee { ID = 202, Name = "Elizabeth Keyser", Manager = 74, BirthDate = new DateTime(1980, 2, 26), Gender = 'F', SickLeaveHours = 22 });
            _Employees.Add(new Employee { ID = 203, Name = "Terry Eminhizer", Manager = 6, BirthDate = new DateTime(1976, 3, 7), Gender = 'M', SickLeaveHours = 42 });
            _Employees.Add(new Employee { ID = 204, Name = "John Frum", Manager = 184, BirthDate = new DateTime(1972, 4, 24), Gender = 'M', SickLeaveHours = 33 });
            _Employees.Add(new Employee { ID = 205, Name = "Merav Netz", Manager = 173, BirthDate = new DateTime(1973, 6, 13), Gender = 'F', SickLeaveHours = 43 });
            _Employees.Add(new Employee { ID = 206, Name = "Brian LaMee", Manager = 44, BirthDate = new DateTime(1974, 9, 12), Gender = 'M', SickLeaveHours = 44 });
            _Employees.Add(new Employee { ID = 207, Name = "Kitti Lertpiriyasuwat", Manager = 38, BirthDate = new DateTime(1977, 7, 7), Gender = 'F', SickLeaveHours = 64 });
            _Employees.Add(new Employee { ID = 208, Name = "Jay Adams", Manager = 18, BirthDate = new DateTime(1966, 3, 14), Gender = 'M', SickLeaveHours = 36 });
            _Employees.Add(new Employee { ID = 209, Name = "Jan Miksovsky", Manager = 184, BirthDate = new DateTime(1964, 12, 16), Gender = 'M', SickLeaveHours = 35 });
            _Employees.Add(new Employee { ID = 210, Name = "Brenda Diaz", Manager = 21, BirthDate = new DateTime(1973, 3, 31), Gender = 'F', SickLeaveHours = 55 });
            _Employees.Add(new Employee { ID = 211, Name = "Andrew Cencini", Manager = 123, BirthDate = new DateTime(1978, 10, 26), Gender = 'M', SickLeaveHours = 56 });
            _Employees.Add(new Employee { ID = 212, Name = "Chris Norred", Manager = 90, BirthDate = new DateTime(1977, 6, 26), Gender = 'M', SickLeaveHours = 57 });
            _Employees.Add(new Employee { ID = 213, Name = "Chris Okelberry", Manager = 16, BirthDate = new DateTime(1976, 9, 7), Gender = 'M', SickLeaveHours = 28 });
            _Employees.Add(new Employee { ID = 214, Name = "Shelley Dyck", Manager = 143, BirthDate = new DateTime(1977, 1, 8), Gender = 'F', SickLeaveHours = 27 });
            _Employees.Add(new Employee { ID = 215, Name = "Gabe Mares", Manager = 210, BirthDate = new DateTime(1978, 6, 11), Gender = 'M', SickLeaveHours = 48 });
            _Employees.Add(new Employee { ID = 216, Name = "Mike Seamans", Manager = 139, BirthDate = new DateTime(1969, 8, 1), Gender = 'M', SickLeaveHours = 49 });
            _Employees.Add(new Employee { ID = 217, Name = "Michael Raheem", Manager = 158, BirthDate = new DateTime(1975, 1, 1), Gender = 'M', SickLeaveHours = 64 });
            _Employees.Add(new Employee { ID = 218, Name = "Gary Altman", Manager = 148, BirthDate = new DateTime(1961, 3, 21), Gender = 'M', SickLeaveHours = 63 });
            _Employees.Add(new Employee { ID = 219, Name = "Charles Fitzgerald", Manager = 18, BirthDate = new DateTime(1961, 10, 3), Gender = 'M', SickLeaveHours = 33 });
            _Employees.Add(new Employee { ID = 220, Name = "Ebru Ersan", Manager = 25, BirthDate = new DateTime(1976, 10, 23), Gender = 'M', SickLeaveHours = 66 });
            _Employees.Add(new Employee { ID = 221, Name = "Sylvester Valdez", Manager = 108, BirthDate = new DateTime(1960, 12, 13), Gender = 'M', SickLeaveHours = 22 });
            _Employees.Add(new Employee { ID = 222, Name = "Brian Goldstein", Manager = 51, BirthDate = new DateTime(1961, 1, 23), Gender = 'M', SickLeaveHours = 51 });
            _Employees.Add(new Employee { ID = 223, Name = "Linda Meisner", Manager = 274, BirthDate = new DateTime(1960, 12, 31), Gender = 'F', SickLeaveHours = 48 });
            _Employees.Add(new Employee { ID = 224, Name = "Betsy Stadick", Manager = 64, BirthDate = new DateTime(1957, 1, 17), Gender = 'F', SickLeaveHours = 69 });
            _Employees.Add(new Employee { ID = 225, Name = "Magnus Hedlund", Manager = 218, BirthDate = new DateTime(1961, 9, 27), Gender = 'M', SickLeaveHours = 63 });
            _Employees.Add(new Employee { ID = 226, Name = "Karan Khanna", Manager = 18, BirthDate = new DateTime(1960, 4, 7), Gender = 'M', SickLeaveHours = 34 });
            _Employees.Add(new Employee { ID = 227, Name = "Mary Baker", Manager = 25, BirthDate = new DateTime(1976, 10, 20), Gender = 'F', SickLeaveHours = 67 });
            _Employees.Add(new Employee { ID = 228, Name = "Kevin Homer", Manager = 25, BirthDate = new DateTime(1976, 10, 20), Gender = 'M', SickLeaveHours = 65 });
            _Employees.Add(new Employee { ID = 229, Name = "Mihail Frintu", Manager = 51, BirthDate = new DateTime(1961, 4, 9), Gender = 'M', SickLeaveHours = 52 });
            _Employees.Add(new Employee { ID = 230, Name = "Bonnie Kearney", Manager = 185, BirthDate = new DateTime(1976, 10, 11), Gender = 'F', SickLeaveHours = 64 });
            _Employees.Add(new Employee { ID = 231, Name = "Fukiko Ogisu", Manager = 274, BirthDate = new DateTime(1960, 12, 25), Gender = 'M', SickLeaveHours = 48 });
            _Employees.Add(new Employee { ID = 232, Name = "Hung-Fu Ting", Manager = 108, BirthDate = new DateTime(1961, 11, 23), Gender = 'M', SickLeaveHours = 20 });
            _Employees.Add(new Employee { ID = 233, Name = "Gordon Hee", Manager = 274, BirthDate = new DateTime(1956, 12, 30), Gender = 'M', SickLeaveHours = 46 });
            _Employees.Add(new Employee { ID = 234, Name = "Kimberly Zimmerman", Manager = 64, BirthDate = new DateTime(1976, 10, 14), Gender = 'F', SickLeaveHours = 67 });
            _Employees.Add(new Employee { ID = 235, Name = "Kim Abercrombie", Manager = 16, BirthDate = new DateTime(1957, 1, 14), Gender = 'F', SickLeaveHours = 32 });
            _Employees.Add(new Employee { ID = 236, Name = "Sandeep Kaliyath", Manager = 51, BirthDate = new DateTime(1961, 1, 3), Gender = 'M', SickLeaveHours = 52 });
            _Employees.Add(new Employee { ID = 237, Name = "Prasanna Samarawickrama", Manager = 108, BirthDate = new DateTime(1943, 6, 1), Gender = 'M', SickLeaveHours = 22 });
            _Employees.Add(new Employee { ID = 238, Name = "Frank Pellow", Manager = 274, BirthDate = new DateTime(1942, 6, 13), Gender = 'M', SickLeaveHours = 49 });
            _Employees.Add(new Employee { ID = 239, Name = "Min Su", Manager = 108, BirthDate = new DateTime(1964, 10, 11), Gender = 'M', SickLeaveHours = 20 });
            _Employees.Add(new Employee { ID = 240, Name = "Eric Brown", Manager = 51, BirthDate = new DateTime(1957, 1, 8), Gender = 'M', SickLeaveHours = 50 });
            _Employees.Add(new Employee { ID = 241, Name = "Eric Kurjan", Manager = 274, BirthDate = new DateTime(1962, 10, 19), Gender = 'M', SickLeaveHours = 47 });
            _Employees.Add(new Employee { ID = 242, Name = "Pat Coleman", Manager = 49, BirthDate = new DateTime(1961, 1, 3), Gender = 'M', SickLeaveHours = 64 });
            _Employees.Add(new Employee { ID = 243, Name = "Maciej Dusza", Manager = 18, BirthDate = new DateTime(1945, 3, 2), Gender = 'M', SickLeaveHours = 35 });
            _Employees.Add(new Employee { ID = 244, Name = "Erin Hagens", Manager = 274, BirthDate = new DateTime(1961, 2, 4), Gender = 'F', SickLeaveHours = 46 });
            _Employees.Add(new Employee { ID = 245, Name = "Patrick Wedge", Manager = 64, BirthDate = new DateTime(1976, 10, 11), Gender = 'M', SickLeaveHours = 68 });
            _Employees.Add(new Employee { ID = 246, Name = "Frank Martinez", Manager = 51, BirthDate = new DateTime(1942, 4, 3), Gender = 'M', SickLeaveHours = 53 });
            _Employees.Add(new Employee { ID = 247, Name = "Ed Dudenhoefer", Manager = 16, BirthDate = new DateTime(1961, 10, 12), Gender = 'M', SickLeaveHours = 32 });
            _Employees.Add(new Employee { ID = 248, Name = "Christopher Hill", Manager = 25, BirthDate = new DateTime(1976, 11, 1), Gender = 'M', SickLeaveHours = 65 });
            _Employees.Add(new Employee { ID = 249, Name = "Patrick Cook", Manager = 51, BirthDate = new DateTime(1964, 1, 24), Gender = 'M', SickLeaveHours = 50 });
            _Employees.Add(new Employee { ID = 250, Name = "Krishna Sunkammurali", Manager = 108, BirthDate = new DateTime(1961, 10, 6), Gender = 'M', SickLeaveHours = 21 });
            _Employees.Add(new Employee { ID = 251, Name = "Lori Penor", Manager = 49, BirthDate = new DateTime(1960, 8, 31), Gender = 'F', SickLeaveHours = 65 });
            _Employees.Add(new Employee { ID = 252, Name = "Danielle Tiedt", Manager = 64, BirthDate = new DateTime(1976, 10, 8), Gender = 'F', SickLeaveHours = 68 });
            _Employees.Add(new Employee { ID = 253, Name = "Sootha Charncherngkha", Manager = 41, BirthDate = new DateTime(1957, 1, 5), Gender = 'M', SickLeaveHours = 62 });
            _Employees.Add(new Employee { ID = 254, Name = "Michael Zwilling", Manager = 18, BirthDate = new DateTime(1963, 10, 7), Gender = 'M', SickLeaveHours = 33 });
            _Employees.Add(new Employee { ID = 255, Name = "Randy Reeves", Manager = 18, BirthDate = new DateTime(1960, 5, 29), Gender = 'M', SickLeaveHours = 34 });
            _Employees.Add(new Employee { ID = 256, Name = "John Kane", Manager = 25, BirthDate = new DateTime(1976, 10, 29), Gender = 'M', SickLeaveHours = 66 });
            _Employees.Add(new Employee { ID = 257, Name = "Jack Creasey", Manager = 51, BirthDate = new DateTime(1963, 9, 30), Gender = 'M', SickLeaveHours = 51 });
            _Employees.Add(new Employee { ID = 258, Name = "Olinda Turner", Manager = 108, BirthDate = new DateTime(1960, 5, 5), Gender = 'F', SickLeaveHours = 21 });
            _Employees.Add(new Employee { ID = 259, Name = "Stuart Macrae", Manager = 49, BirthDate = new DateTime(1962, 1, 17), Gender = 'M', SickLeaveHours = 64 });
            _Employees.Add(new Employee { ID = 260, Name = "Jo Berry", Manager = 49, BirthDate = new DateTime(1944, 5, 25), Gender = 'F', SickLeaveHours = 65 });
            _Employees.Add(new Employee { ID = 261, Name = "Ben Miller", Manager = 274, BirthDate = new DateTime(1963, 7, 5), Gender = 'M', SickLeaveHours = 47 });
            _Employees.Add(new Employee { ID = 262, Name = "Tom Vande Velde", Manager = 64, BirthDate = new DateTime(1976, 11, 1), Gender = 'M', SickLeaveHours = 69 });
            _Employees.Add(new Employee { ID = 263, Name = "Ovidiu Cracium", Manager = 3, BirthDate = new DateTime(1968, 2, 18), Gender = 'M', SickLeaveHours = 23 });
            _Employees.Add(new Employee { ID = 264, Name = "Annette Hill", Manager = 274, BirthDate = new DateTime(1968, 3, 1), Gender = 'F', SickLeaveHours = 45 });
            _Employees.Add(new Employee { ID = 265, Name = "Janice Galvin", Manager = 263, BirthDate = new DateTime(1979, 6, 29), Gender = 'F', SickLeaveHours = 24 });
            _Employees.Add(new Employee { ID = 266, Name = "Reinout Hillmann", Manager = 274, BirthDate = new DateTime(1968, 2, 18), Gender = 'M', SickLeaveHours = 45 });
            _Employees.Add(new Employee { ID = 267, Name = "Michael Sullivan", Manager = 3, BirthDate = new DateTime(1969, 7, 17), Gender = 'M', SickLeaveHours = 21 });
            _Employees.Add(new Employee { ID = 268, Name = "Stephen Jiang", Manager = 273, BirthDate = new DateTime(1941, 11, 17), Gender = 'M', SickLeaveHours = 27 });
            _Employees.Add(new Employee { ID = 269, Name = "Wanida Benshoof", Manager = 6, BirthDate = new DateTime(1965, 4, 17), Gender = 'F', SickLeaveHours = 40 });
            _Employees.Add(new Employee { ID = 270, Name = "Sharon Salavaria", Manager = 3, BirthDate = new DateTime(1951, 6, 3), Gender = 'F', SickLeaveHours = 22 });
            _Employees.Add(new Employee { ID = 271, Name = "John Wood", Manager = 6, BirthDate = new DateTime(1968, 4, 6), Gender = 'M', SickLeaveHours = 44 });
            _Employees.Add(new Employee { ID = 272, Name = "Mary Dempsey", Manager = 6, BirthDate = new DateTime(1968, 3, 1), Gender = 'F', SickLeaveHours = 41 });
            _Employees.Add(new Employee { ID = 273, Name = "Brian Welcker", Manager = 109, BirthDate = new DateTime(1967, 7, 8), Gender = 'M', SickLeaveHours = 25 });
            _Employees.Add(new Employee { ID = 274, Name = "Sheela Word", Manager = 71, BirthDate = new DateTime(1968, 3, 13), Gender = 'F', SickLeaveHours = 44 });
            _Employees.Add(new Employee { ID = 275, Name = "Michael Blythe", Manager = 268, BirthDate = new DateTime(1959, 1, 26), Gender = 'M', SickLeaveHours = 39 });
            _Employees.Add(new Employee { ID = 276, Name = "Linda Mitchell", Manager = 268, BirthDate = new DateTime(1970, 3, 30), Gender = 'F', SickLeaveHours = 33 });
            _Employees.Add(new Employee { ID = 277, Name = "Jillian Carson", Manager = 268, BirthDate = new DateTime(1952, 9, 29), Gender = 'F', SickLeaveHours = 32 });
            _Employees.Add(new Employee { ID = 278, Name = "Garrett Vargas", Manager = 268, BirthDate = new DateTime(1965, 3, 7), Gender = 'M', SickLeaveHours = 36 });
            _Employees.Add(new Employee { ID = 279, Name = "Tsvi Reiter", Manager = 268, BirthDate = new DateTime(1964, 2, 19), Gender = 'M', SickLeaveHours = 34 });
            _Employees.Add(new Employee { ID = 280, Name = "Pamela Ansman-Wolfe", Manager = 268, BirthDate = new DateTime(1965, 1, 6), Gender = 'F', SickLeaveHours = 31 });
            _Employees.Add(new Employee { ID = 281, Name = "Shu Ito", Manager = 268, BirthDate = new DateTime(1958, 4, 10), Gender = 'M', SickLeaveHours = 33 });
            _Employees.Add(new Employee { ID = 282, Name = "José Saraiva", Manager = 268, BirthDate = new DateTime(1954, 1, 11), Gender = 'M', SickLeaveHours = 35 });
            _Employees.Add(new Employee { ID = 283, Name = "David Campbell", Manager = 268, BirthDate = new DateTime(1964, 3, 14), Gender = 'M', SickLeaveHours = 31 });
            _Employees.Add(new Employee { ID = 284, Name = "Amy Alberts", Manager = 273, BirthDate = new DateTime(1947, 10, 22), Gender = 'F', SickLeaveHours = 30 });
            _Employees.Add(new Employee { ID = 285, Name = "Jae Pak", Manager = 284, BirthDate = new DateTime(1958, 4, 18), Gender = 'F', SickLeaveHours = 38 });
            _Employees.Add(new Employee { ID = 286, Name = "Ranjit Varkey Chudukatil", Manager = 284, BirthDate = new DateTime(1965, 10, 31), Gender = 'M', SickLeaveHours = 37 });
            _Employees.Add(new Employee { ID = 287, Name = "Tete Mensa-Annan", Manager = 268, BirthDate = new DateTime(1968, 2, 6), Gender = 'M', SickLeaveHours = 39 });
            _Employees.Add(new Employee { ID = 288, Name = "Syed Abbas", Manager = 273, BirthDate = new DateTime(1965, 2, 11), Gender = 'M', SickLeaveHours = 30 });
            _Employees.Add(new Employee { ID = 289, Name = "Rachel Valdez", Manager = 284, BirthDate = new DateTime(1965, 8, 9), Gender = 'F', SickLeaveHours = 37 });
            _Employees.Add(new Employee { ID = 290, Name = "Lynn Tsoflias", Manager = 288, BirthDate = new DateTime(1961, 4, 18), Gender = 'F', SickLeaveHours = 38 });
        }
    
        private static List<Employee> _Employees = new List<Employee>();
        private static List<Product> _Products = new List<Product>();
        private static List<Vendor> _Vendors = new List<Vendor>();
        private static List<ProductVendor> _ProductVendors = new List<ProductVendor>();

        private static List<DicePlayer> _dicePlayers = new List<DicePlayer>();

        public static IEnumerable<Employee> Employees => _Employees; 
        public static IEnumerable<Product> Products => _Products;
        public static IEnumerable<Vendor> Vendors => _Vendors;
        public static IEnumerable<ProductVendor> ProductVendors => _ProductVendors;
        public static IEnumerable<DicePlayer> DicePlayers => _dicePlayers;

        public static IEnumerable<BuildingCategory> BuildingCategories { get; } =
            new List<BuildingCategory> {
                new BuildingCategory { Category = "Apartment", Description = "A room or set of rooms fitted especially with housekeeping facilities and usually leased as a dwelling"},
                new BuildingCategory { Category = "House", Description = "A building that serves as living quarters for one or a few families "},
                new BuildingCategory { Category = "Garage", Description = "A shelter or repair shop for automotive vehicles"},
                new BuildingCategory { Category = "Construction Field", Description = "An area, usually a land or lot, designated for construction of buildings"},
                new BuildingCategory { Category = "Storage Area", Description = "Space or a place for storing in multiple rooms"},
                new BuildingCategory { Category = "Storage Room", Description = "A room for storing"},
                //new BuildingCategory { Category = "Berth", Description = "the place where a ship lies when at anchor or at a wharf"},
                new BuildingCategory { Category = "Underground Area", Description = "Area beneath the surface of the earth"},
                new BuildingCategory { Category = "Swamp", Description = "Only Shrek lives here and there are no places for sale. GET. OUT. OF. MY. SWAMP!"},
            };
        public static IEnumerable<Building> Buildings { get; } =
            new List<Building> {
                new Building { BuildingID = 1, Address = "Chai", Category = "Apartment", Price = 180_000M, SquareMeters = 39 },
                new Building { BuildingID = 2, Address = "Chang", Category = "Apartment", Price = 190_000M, SquareMeters = 17 },
                new Building { BuildingID = 3, Address = "Aniseed Syrup", Category = "House", Price = 10_0000M, SquareMeters = 13 },
                new Building { BuildingID = 4, Address = "Chef Anton's Cajun Seasoning", Category = "House", Price = 22_0000M, SquareMeters = 53 },
                new Building { BuildingID = 5, Address = "Chef Anton's Gumbo Mix", Category = "House", Price = 21_3500M, SquareMeters = 0 },
                new Building { BuildingID = 6, Address = "Grandma's Boysenberry Spread", Category = "House", Price = 25_0000M, SquareMeters = 120 },
                new Building { BuildingID = 7, Address = "Uncle Bob's Organic Dried Pears", Category = "Garage", Price = 30_0000M, SquareMeters = 15 },
                new Building { BuildingID = 8, Address = "Northwoods Cranberry Sauce", Category = "House", Price = 40_0000M, SquareMeters = 6 },
                new Building { BuildingID = 9, Address = "Mishi Kobe Niku", Category = "Construction Field", Price = 97_0000M, SquareMeters = 29 },
                new Building { BuildingID = 10, Address = "Ikura", Category = "Storage Area", Price = 310_000M, SquareMeters = 31 },
                new Building { BuildingID = 11, Address = "Queso Cabrales", Category = "Storage Room", Price = 210_000M, SquareMeters = 22 },
                new Building { BuildingID = 12, Address = "Queso Manchego La Pastora", Category = "Storage Room", Price = 380_000M, SquareMeters = 86 },
                new Building { BuildingID = 13, Address = "Konbu", Category = "Storage Area", Price = 60_000M, SquareMeters = 24 },
                new Building { BuildingID = 14, Address = "Tofu", Category = "Garage", Price = 530_000M, SquareMeters = 35 },
                new Building { BuildingID = 15, Address = "Genen Shouyu", Category = "House", Price = 155_000M, SquareMeters = 39 },
                new Building { BuildingID = 16, Address = "Pavlova", Category = "Berth", Price = 174_500M, SquareMeters = 29 },
                new Building { BuildingID = 17, Address = "Alice Mutton", Category = "Construction Field", Price = 390_000M, SquareMeters = 0 },
                new Building { BuildingID = 18, Address = "Carnarvon Tigers", Category = "Storage Area", Price = 625_000M, SquareMeters = 42 },
                new Building { BuildingID = 19, Address = "Teatime Chocolate Biscuits", Category = "Berth", Price = 92_000M, SquareMeters = 25 },
                new Building { BuildingID = 20, Address = "Sir Rodney's Marmalade", Category = "Berth", Price = 810_000M, SquareMeters = 40 },
                new Building { BuildingID = 21, Address = "Sir Rodney's Scones", Category = "Berth", Price = 100_000M, SquareMeters = 3 },
                new Building { BuildingID = 22, Address = "Gustaf's Knäckebröd", Category = "Underground Area", Price = 210_000M, SquareMeters = 104 },
                new Building { BuildingID = 23, Address = "Tunnbröd", Category = "Underground Area", Price = 90_000M, SquareMeters = 61 },
                new Building { BuildingID = 24, Address = "Guaraná Fantástica", Category = "Apartment", Price = 45_000M, SquareMeters = 20 },
                new Building { BuildingID = 25, Address = "NuNuCa Nuß-Nougat-Creme", Category = "Berth", Price = 140_000M, SquareMeters = 76 },
                new Building { BuildingID = 26, Address = "Gumbär Gummibärchen", Category = "Berth", Price = 312_300M, SquareMeters = 15 },
                new Building { BuildingID = 27, Address = "Schoggi Schokolade", Category = "Berth", Price = 439_000M, SquareMeters = 49 },
                new Building { BuildingID = 28, Address = "Rössle Sauerkraut", Category = "Garage", Price = 456_000M, SquareMeters = 26 },
                new Building { BuildingID = 29, Address = "Thüringer Rostbratwurst", Category = "Construction Field", Price = 1_237_900M, SquareMeters = 1500 },
                new Building { BuildingID = 30, Address = "Nord-Ost Matjeshering", Category = "Storage Area", Price = 258_900M, SquareMeters = 10 },
                new Building { BuildingID = 31, Address = "Gorgonzola Telino", Category = "Storage Room", Price = 125_000M, SquareMeters = 0 },
                new Building { BuildingID = 32, Address = "Mascarpone Fabioli", Category = "Storage Room", Price = 320_000M, SquareMeters = 9 },
                new Building { BuildingID = 33, Address = "Geitost", Category = "Storage Room", Price = 25_000M, SquareMeters = 112 },
                new Building { BuildingID = 34, Address = "Sasquatch Ale", Category = "Apartment", Price = 140_000M, SquareMeters = 111 },
                new Building { BuildingID = 35, Address = "Steeleye Stout", Category = "Apartment", Price = 180_000M, SquareMeters = 20 },
                new Building { BuildingID = 36, Address = "Inlagd Sill", Category = "Storage Area", Price = 190_000M, SquareMeters = 112 },
                new Building { BuildingID = 37, Address = "Gravad lax", Category = "Storage Area", Price = 260_000M, SquareMeters = 11 },
                new Building { BuildingID = 38, Address = "Côte de Blaye", Category = "Apartment", Price = 2_635_000M, SquareMeters = 700 },
                new Building { BuildingID = 39, Address = "Chartreuse verte", Category = "Apartment", Price = 180_000M, SquareMeters = 269 },
                new Building { BuildingID = 40, Address = "Boston Crab Meat", Category = "Storage Area", Price = 184_000M, SquareMeters = 123 },
                new Building { BuildingID = 41, Address = "Jack's New England Clam Chowder", Category = "Storage Area", Price = 96_500M, SquareMeters = 85 },
                new Building { BuildingID = 42, Address = "Singaporean Hokkien Fried Mee", Category = "Underground Area", Price = 140_000M, SquareMeters = 26 },
                new Building { BuildingID = 43, Address = "Ipoh Coffee", Category = "Apartment", Price = 460_000M, SquareMeters = 17 },
                new Building { BuildingID = 44, Address = "Gula Malacca", Category = "House", Price = 194_500M, SquareMeters = 27 },
                new Building { BuildingID = 45, Address = "Rogede sild", Category = "Storage Area", Price = 95_000M, SquareMeters = 5 },
                new Building { BuildingID = 46, Address = "Spegesild", Category = "Storage Area", Price = 120_000M, SquareMeters = 95 },
                new Building { BuildingID = 47, Address = "Zaanse koeken", Category = "Berth", Price = 95_000M, SquareMeters = 36 },
                new Building { BuildingID = 48, Address = "Chocolade", Category = "Berth", Price = 127_500M, SquareMeters = 15 },
                new Building { BuildingID = 49, Address = "Maxilaku", Category = "Berth", Price = 200_000M, SquareMeters = 10 },
                new Building { BuildingID = 50, Address = "Valkoinen suklaa", Category = "Berth", Price = 162_500M, SquareMeters = 65 },
                new Building { BuildingID = 51, Address = "Manjimup Dried Apples", Category = "Garage", Price = 530_000M, SquareMeters = 20 },
                new Building { BuildingID = 52, Address = "Filo Mix", Category = "Underground Area", Price = 70_000M, SquareMeters = 38 },
                new Building { BuildingID = 53, Address = "Perth Pasties", Category = "Construction Field", Price = 328_000M, SquareMeters = 0 },
                new Building { BuildingID = 54, Address = "Tourtière", Category = "Construction Field", Price = 74_500M, SquareMeters = 21 },
                new Building { BuildingID = 55, Address = "Pâté chinois", Category = "Construction Field", Price = 240_000M, SquareMeters = 115 },
                new Building { BuildingID = 56, Address = "Gnocchi di nonna Alice", Category = "Underground Area", Price = 380_000M, SquareMeters = 21 },
                new Building { BuildingID = 57, Address = "Ravioli Angelo", Category = "Underground Area", Price = 195_000M, SquareMeters = 36 },
                new Building { BuildingID = 58, Address = "Escargots de Bourgogne", Category = "Storage Area", Price = 132_500M, SquareMeters = 62 },
                new Building { BuildingID = 59, Address = "Raclette Courdavault", Category = "Storage Room", Price = 550_000M, SquareMeters = 79 },
                new Building { BuildingID = 60, Address = "Camembert Pierrot", Category = "Storage Room", Price = 340_000M, SquareMeters = 19 },
                new Building { BuildingID = 61, Address = "Sirop d'érable", Category = "House", Price = 285_000M, SquareMeters = 113 },
                new Building { BuildingID = 62, Address = "Tarte au sucre", Category = "Berth", Price = 493_000M, SquareMeters = 17 },
                new Building { BuildingID = 63, Address = "Vegie-spread", Category = "House", Price = 439_000M, SquareMeters = 24 },
                new Building { BuildingID = 64, Address = "Wimmers gute Semmelknödel", Category = "Underground Area", Price = 332_500M, SquareMeters = 22 },
                new Building { BuildingID = 65, Address = "Louisiana Fiery Hot Pepper Sauce", Category = "House", Price = 210_500M, SquareMeters = 76 },
                new Building { BuildingID = 66, Address = "Louisiana Hot Spiced Okra", Category = "House", Price = 170_000M, SquareMeters = 4 },
                new Building { BuildingID = 67, Address = "Laughing Lumberjack Lager", Category = "Apartment", Price = 140_000M, SquareMeters = 52 },
                new Building { BuildingID = 68, Address = "Scottish Longbreads", Category = "Berth", Price = 125_000M, SquareMeters = 6 },
                new Building { BuildingID = 69, Address = "Gudbrandsdalsost", Category = "Storage Room", Price = 360_000M, SquareMeters = 26 },
                new Building { BuildingID = 70, Address = "Outback Lager", Category = "Apartment", Price = 150_000M, SquareMeters = 15 },
                new Building { BuildingID = 71, Address = "Flotemysost", Category = "Storage Room", Price = 215_000M, SquareMeters = 26 },
                new Building { BuildingID = 72, Address = "Mozzarella di Giovanni", Category = "Storage Room", Price = 348_000M, SquareMeters = 14 },
                new Building { BuildingID = 73, Address = "Röd Kaviar", Category = "Storage Area", Price = 150_000M, SquareMeters = 101 },
                new Building { BuildingID = 74, Address = "Longlife Tofu", Category = "Garage", Price = 100_000M, SquareMeters = 4 },
                new Building { BuildingID = 75, Address = "Rhönbräu Klosterbier", Category = "Apartment", Price = 77_500M, SquareMeters = 125 },
                new Building { BuildingID = 76, Address = "Lakkalikööri", Category = "Apartment", Price = 180_000M, SquareMeters = 57 },
                new Building { BuildingID = 77, Address = "Original Frankfurter grüne Soße", Category = "House", Price = 130_000M, SquareMeters = 32 }
            };

        public static string RoyalTitle { get => "His Royal Highness The Prince Philip, Duke of Edinburgh, Earl of Merioneth, Baron Greenwich, Royal Knight of the Most Noble Order of the Garter, Extra Knight of the Most Ancient and Most Noble Order of the Thistle, Member of the Order of Merit, Grand Master and First and Principal Knight Grand Cross of the Most Excellent Order of the British Empire, Knight of the Order of Australia, Additional Member of the Order of New Zealand, Extra Companion of the Queen’s Service Order, Royal Chief of the Order of Logohu, Extraordinary Companion of the Order of Canada, Extraordinary Commander of the Order of Military Merit, Lord of Her Majesty’s Most Honourable Privy Council, Privy Councillor of the Queen’s Privy Council for Canada, Personal Aide-de-Camp to Her Majesty, Lord High Admiral of the United Kingdom"; }
        public static IEnumerable<string> RoyalTitleWords { get => RoyalTitle.Replace(",", "").Split(); }
        public static IEnumerable<string> RoyalTitleTitles { get => RoyalTitle.Split(','); }

    }
}
