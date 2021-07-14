using LinqBackgroundKnowledge.Extensions;
using LinqBackgroundKnowledge.Models;
using System;
using System.Collections.Generic;

namespace LinqBackgroundKnowledge.SelectDemos {
    public static class SelectExamples {
        // this is our source: a list with games
        static List<Game> games = new List<Game>() {
            new Game() {Id = 1, GameName = "WOW", Genre = "RPG", Year = 2003},
            new Game() {Id = 2, GameName = "Carto", Genre = "Puzzle", Year = 2021},
            new Game() {Id = 3, GameName = "Sea of Thieves", Genre = "Adventure", Year = 2018}
        };

        // Let's say we want to select only two "columns" of our "table"
        // (or rather, two properties of our class)

        // First, we should create a data structure that can contain the two columns:
        // a class GameNameAndGenre with a GameName and Genre properties.
        // Then, we can write a method that selects a new instance of GameNameAnd Genre
        // for each item found in the original games list
        public static List<GameNameAndGenre> SelectGameNameAndGenre(List<Game> games) {
            List<GameNameAndGenre> result = new List<GameNameAndGenre>();
            foreach (Game game in games) {
                result.Add(new GameNameAndGenre() { GameName = game.GameName, Genre = game.Genre });
            }

            return result;
        }

        // We can now invoke that method and get the results
        public static void Example01() {
            List<GameNameAndGenre> gameNameAndGenres = SelectGameNameAndGenre(games);

            foreach (GameNameAndGenre item in gameNameAndGenres) {
                Console.WriteLine($"{item.GameName} - {item.Genre}");
            }
        }

        // The previous SelectGameNameAndGenre gathers all the data in a List before returning the whole list.
        // This means that the caller has to wait the the whole source is looped through before getting any result.
        // On the other hand, we can use a yield return to return one item at a time.
        public static IEnumerable<GameNameAndGenre> SelectGameNameAndGenreIEnumerables(IEnumerable<Game> games) {
            foreach (Game game in games) {
                yield return new GameNameAndGenre() { GameName = game.GameName, Genre = game.Genre };
            }
        }

        // We can invoke the method just like before
        // But this time we need to loop through the results in order to actually start
        // to pull in the items, otherwise not much happens
        public static void Example02() {
            // this is not a list, this is just an enumerator that can give use the next item
            IEnumerable<GameNameAndGenre> gameNameAndGenres = SelectGameNameAndGenreIEnumerables(games);

            //this is where we ask the next item
            foreach (GameNameAndGenre item in gameNameAndGenres) {
                Console.WriteLine($"{item.GameName} - {item.Genre}");
            }
        }

        // The SelectGameNameAndGenreIEnumerables is pretty specific:
        // - It only works with a collection of Game
        // - It only returns a collection of GameNameAndGenre

        // If we ever wanted to select other fields, we would have to start the whole process all over again:
        // - New DataStructure
        // - New Method 
        public static IEnumerable<GameNameAndYear> SelectGameNameAndYearIEnumerables(IEnumerable<Game> games) {
            foreach (Game game in games) {
                yield return new GameNameAndYear() { Name = game.GameName, Year = game.Year };
            }
        }

        // But if we compare SelectGameNameAndGenreIEnumerables and SelectGameNameAndYearIEnumerables
        // We notice that they almost look the same.
        // The only thing that changes is the decision of which data structure to return.

        // So let's start refactoring a bit to see if we can find a way to make it more generic

        public static IEnumerable<GameNameAndGenre> SelectGameNameAndGenreIEnumerablesWithExtractedMethod(IEnumerable<Game> games) {
            foreach (Game game in games) {
                yield return SelectGameNameAndGenreFromGame(game);
            }
        }


        public static GameNameAndGenre SelectGameNameAndGenreFromGame(Game game) {
            return new GameNameAndGenre() { GameName = game.GameName, Genre = game.Genre };
        }

        public static IEnumerable<GameNameAndYear> SelectGameNameAndYearIEnumerablesWithExtractedMethod(IEnumerable<Game> games) {
            foreach (Game game in games) {
                yield return SelectGameNameAndYearFromGame(game);
            }
        }


        public static GameNameAndYear SelectGameNameAndYearFromGame(Game game) {
            return new GameNameAndYear() { Name = game.GameName, Year = game.Year };
        }

        // We can now start to see the pattern:
        // Both the SelectGameNameAndGenreIEnumerablesWithExtractedMethod and the SelectGameNameAndYearIEnumerablesWithExtractedMethod
        // - Invoke a method that accepts one Game and returns some type
        // - Return an IEnumerable of the same type returned by the method they invoke

        // This means that we can ask the method as a parameter.
        // If we only needed GameNameAndGenre, we could create a specific delegate, like so
        public delegate GameNameAndGenre GameAndGenreSelector(Game inputGame);

        // Then we would write the method to use that delegate
        public static IEnumerable<GameNameAndGenre> SelectGameNameAndGenreIEnumerablesWithDelegate(IEnumerable<Game> games, GameAndGenreSelector selectOneGameNameAndGenre) {
            foreach (Game game in games) {
                yield return selectOneGameNameAndGenre(game);
            }
        }

        // Then we could use the method like so
        public static void Example03() {
            IEnumerable<GameNameAndGenre> gameNameAndGenres = SelectGameNameAndGenreIEnumerablesWithDelegate(games, SelectGameNameAndGenreFromGame);

            foreach (GameNameAndGenre item in gameNameAndGenres) {
                Console.WriteLine($"{item.GameName} - {item.Genre}");
            }

        }

        // But this would still constraint us to only return a GameNameAndGenre.
        // If we wanted to return GameNameAndYear, we would have to start all over again:
        // Delegate first
        public delegate GameNameAndYear GameAndYearSelector(Game inputGame);
        // Then we would write the method to use that delegate
        public static IEnumerable<GameNameAndYear> SelectGameNameAndYearIEnumerablesWithDelegate(IEnumerable<Game> games, GameAndYearSelector selectOneGameNameAndYear) {
            foreach (Game game in games) {
                yield return selectOneGameNameAndYear(game);
            }
        }

        // But with generics, we can just change the type and we're done:

        // The delegate becomes a generic delegate that can return whatever type
        public delegate TypeOfTheOutputSelection GenericOutputSelector<TypeOfTheOutputSelection>(Game inputGame);

        //The method now accepts a generic delegate and returns whatever type the delegate returns
        public static IEnumerable<TypeOfTheOutput> SelectGameNameAndGenreIEnumerablesWithGenericDelegate<TypeOfTheOutput>
            (IEnumerable<Game> games, GenericOutputSelector<TypeOfTheOutput> selectOneGameNameAndGenre) {
            foreach (Game game in games) {
                yield return selectOneGameNameAndGenre(game);
            }
        }

        // We can stiil use it as we did before, but we can also pass methods that can return whatever structure we want
        public static int YearSelector(Game game) {
            return game.Year;
        }

        public static void Example04() {
            IEnumerable<int> gameYears = SelectGameNameAndGenreIEnumerablesWithGenericDelegate(games, YearSelector);

            foreach (int item in gameYears) {
                Console.WriteLine($"{item}");
            }

        }

        //we can also pass a lambda 
        public static void Example05() {
            IEnumerable<string> gameNames = SelectGameNameAndGenreIEnumerablesWithGenericDelegate(games, inputGame => inputGame.GameName);

            foreach (string item in gameNames) {
                Console.WriteLine($"{item}");
            }

        }

        // our lambda can of course return anonymous types if we want, so no need for an additional class for every new query
        public static void Example06() {
            var gameYearsAndGenres = SelectGameNameAndGenreIEnumerablesWithGenericDelegate(games, inputGame => new { inputGame.Year, inputGame.Genre });

            foreach (var item in gameYearsAndGenres) {
                Console.WriteLine($"{item.Genre} {item.Year}");
            }
        }


        // The input type is still only a collection of games, though.
        // We can improve it by also requiring a generic type as input

        // The delegate requires now two generic types: one for the input and one for the output
        public delegate TypeOfTheOutputSelection GenericInputAndOutputSelector<TypeOfTheInputSelection, TypeOfTheOutputSelection>(TypeOfTheInputSelection inputGame);

        // The method also needs the same two types
        public static IEnumerable<TypeOfTheOutput> SelectGameNameAndGenreIEnumerablesWithGenericInputOutputDelegate<TypeOfTheInput, TypeOfTheOutput>
            (IEnumerable<TypeOfTheInput> inputCollection, GenericInputAndOutputSelector<TypeOfTheInput, TypeOfTheOutput> selectTheOutputResult) {
            foreach (TypeOfTheInput item in inputCollection) {
                yield return selectTheOutputResult(item);
            }
        }

        // Now we can use this method with any collection, returning any data structure we want
        public static void Example07() {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            var squares = SelectGameNameAndGenreIEnumerablesWithGenericInputOutputDelegate(numbers, n => n * n);

            foreach (var item in squares) {
                Console.WriteLine($"{item}");
            }
        }


        // The last step is to make add our method to any IEnumerable,
        // so that we can use it as an instance method.
        // To do this, we can create an Extension Method.
        // Check the MyExtensions class to see how.
        public static void Example08() {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            var squares = numbers.Select(n => n * n);

            foreach (var item in squares) {
                Console.WriteLine($"{item}");
            }
        }


    }
}
