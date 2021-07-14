using LinqBackgroundKnowledge.Extensions;
using LinqBackgroundKnowledge.Models;
using System;
using System.Collections.Generic;

namespace LinqBackgroundKnowledge {
    class Program {
        static void Main(string[] args) {
            // Our goal is to manipulate data:
            // Go from a set of items to a different set of items.
            // Examples
            // 1 - from a collection of cars to only the expensive cars (filter)
            // 2 - from a collection of games to only the game names (change the shape of the output)
            // We want to be able to work on any sort of collections (Arrays, Lists, Queues, Stacks, Sets...)
            // We want to be able to filter by any condition
            // We want to be able to select any kind of shape
            // We want to be able to construct a query by chaining multiple statements


            List<Car> cars = new List<Car>() {
                new(){Id = 1, Brand = "FIAT", Name = "Punto", Price = 12_345},
                new(){Id = 2, Brand = "Audi", Name = "A3", Price = 23_345}
            };
            var query1 = cars.Where(c => c.Price > 20_000);
            foreach (var item in query1) {
                Console.WriteLine(item);
            }

            List<Game> games = new List<Game>() {
                new Game() {Id = 1, GameName = "WOW", Genre = "RPG", Year = 2003},
                new Game() {Id = 2, GameName = "Carto", Genre = "Puzzle", Year = 2021},
                new Game() {Id = 3, GameName = "Sea of Thieves", Genre = "Adventure", Year = 2018}
            };
            var query2 = games.Select(g => new { Name = g.GameName, g.Year });
            foreach (var item in query2) {
                Console.WriteLine(item);
            }

            string[] words = new string[] { "some", "word", "in", "my", "list", "abracadabra", "supercalifragilistisomething" };
            var resultingItems = words.Where(w => w.Length > 4).Select(w => new { w.Length, Word = w });

            foreach (var item in resultingItems) {
                Console.WriteLine($"{item.Word} is {item.Length} letters long.");
            }

            // In order to achieve that we need some language construct that can help us.
            // First, Learn about IEnumerables by cheching the IEnumerables demos
            // Second, learn about generics by checking the Generics Demos 
            // Third, learn about delegates by checking the Filter Demos
            // Last, learn about the anonymous types by checking the Select Demos
        }
    }
}
