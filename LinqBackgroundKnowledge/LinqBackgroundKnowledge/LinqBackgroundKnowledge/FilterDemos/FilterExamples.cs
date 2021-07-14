using LinqBackgroundKnowledge.Extensions;
using LinqBackgroundKnowledge.Models;
using System;
using System.Collections.Generic;

namespace LinqBackgroundKnowledge.FilterDemos {
    public class FilterExamples {
        // This is our source: a List with Cars
        private static List<Car> cars = new List<Car>() {
                new Car() { Id = 1, Brand="FIAT", Name = "Punto", Price = 12345 },
                new Car() { Id = 2, Brand="FIAT", Name = "500", Price = 9345 },
                new Car() { Id = 3, Brand="Audi", Name = "A2", Price = 52345 },
                new Car() { Id = 4, Brand="Audi", Name = "A3", Price = 32345 }
            };


        public static void Example01() {
            List<Car> fiats = FilterCarsWhoseBrandIsFIAT(cars);
            /*
               1 - Punto - FIAT - ? 12.345
               2 - 500 - FIAT - ? 9.345
             */
            foreach (var item in fiats) {
                Console.WriteLine(item);
            }


            List<Car> expensive = FilterCarsWhosePriceIsGreaterThan15_000(cars);

            /*
             3 - A2 - Audi - ? 52.345
             4 - A3 - Audi - ? 32.345
             */
            foreach (var item in expensive) {
                Console.WriteLine(item);
            }
        }

        //This method is extremely specific:
        // - It only works if the input is a List of Cars
        // - It always returns a List of Cars
        // - It checks a very specific condition: if the Brand is FIAT
        public static List<Car> FilterCarsWhoseBrandIsFIAT(List<Car> cars) {
            List<Car> result = new List<Car>();
            foreach (Car car in cars) {
                if (IsBrandFiat(car)) {
                    result.Add(car);
                }
            }
            return result;
        }

        //This method is extremely specific:
        // - It only works if the input is a List of Cars
        // - It always returns a List of Cars
        // - It checks a very specific condition: if the Price is Greater than 15000
        public static List<Car> FilterCarsWhosePriceIsGreaterThan15_000(List<Car> cars) {
            List<Car> result = new List<Car>();
            foreach (Car car in cars) {
                if (IsPriceGreaterThan15_000(car)) {
                    result.Add(car);
                }
            }
            return result;
        }

        // Actually, FilterCarsWhoseBrandIsFIAT and FilterCarsWhosePriceIsGreaterThan15_000 are almost the same.
        // The only difference is which method is delegated to decide which car to include in the results
        private static bool IsBrandFiat(Car car) {
            return car.Brand == "FIAT";
        }

        private static bool IsPriceGreaterThan15_000(Car car) {
            return car.Price > 15_000;
        }


        // What we can do is to accept the method as a parameter, thanks to delegates.
        // This way, we can reuse the same method passing different conditions to be checked

        //First, we need to define the delegate
        public delegate bool CarChecker(Car carToCheck);

        //Now, we can use the delegate as a parameter
        public static List<Car> FilterByYouTellMe(List<Car> cars, CarChecker checkTheCar) {
            List<Car> result = new List<Car>();
            foreach (Car car in cars) {
                //we can invoke the delegate
                if (checkTheCar(car)) {
                    result.Add(car);
                }
            }
            return result;
        }

        private static void Example02() {
            //we can pass an existing function as argument
            List<Car> fiats = FilterByYouTellMe(cars, IsBrandFiat);
        }

        private static void Example03() {
            // we can also pass a lambda expression as an argument,
            // without having to create a method upfront each time we need a new condition
            List<Car> fiats = FilterByYouTellMe(cars, c => c.Brand.StartsWith("A"));
        }

        // The previous FilterByYouTellMe gathers all the data in a List before returning the whole list.
        // This means that the caller has to wait the the whole source is looped through before getting any result.
        // On the other hand, we can use a yield return to return one item at a time.
        public static IEnumerable<Car> FilterByYouTellMeYield(IEnumerable<Car> cars, CarChecker checkTheCar) {
            Console.WriteLine("FilterWhereYouTellMe has been invoked");
            foreach (Car car in cars) {
                Console.WriteLine($"next in the loop is {car}");
                if (checkTheCar(car)) {
                    Console.WriteLine($"we found a car that we like: {car}");
                    yield return car;
                }
            }
        }

        private static void Example04() {
            IEnumerable<Car> fiats = FilterByYouTellMeYield(cars, IsBrandFiat);

            //this time we MUST use the foreach to actively pull the items
            foreach (Car car in fiats) {
                Console.WriteLine($"\t the foreach has gotten {car}");
            }
        }

        // We can still use labdas to pass a newly created method 
        private static void Example05() {
            IEnumerable<Car> fiats = FilterByYouTellMeYield(cars, car => {
                Console.WriteLine($"This is the lambda, the car that we got is: {car}");
                return car.Brand.StartsWith("A");
            });

            foreach (Car car in fiats) {
                Console.WriteLine($"\t the foreach has gotten {car}");
            }
        }


        // The FilterByYouTellMeYield is still pretty specific:
        // - It only works with a collection of Cars as input collection
        // - It only returns a collection of Cars

        //To make it more generic, we can use Generics

        // First, we need to define a generic delegate,
        // so that the item to check is not necessarily a car anymore
        public delegate bool GenericChecker<TypeOfItemToCheck>(TypeOfItemToCheck itemToCheck);

        // Then, we can change the Filter so that it accepts a generic enumerable
        // and returns an enumerable of the same generic type
        public static IEnumerable<TheTypeOfItemToFilter> FilterByYouTellMeYieldGeneric<TheTypeOfItemToFilter>(IEnumerable<TheTypeOfItemToFilter> collectionToFilter, GenericChecker<TheTypeOfItemToFilter> checkTheItem) {
            Console.WriteLine("FilterWhereYouTellMe has been invoked");
            foreach (TheTypeOfItemToFilter item in collectionToFilter) {
                Console.WriteLine($"next in the loop is {item}");
                if (checkTheItem(item)) {
                    Console.WriteLine($"we found an item that we like: {item}");
                    yield return item;
                }
            }
        }


        //Now we can use the new method
        private static void Example06() {
            //we can still use the method as we did before
            IEnumerable<Car> fiats = FilterByYouTellMeYieldGeneric(cars, car => {
                Console.WriteLine($"This is the lambda, the car that we got is: {car}");
                return car.Brand.StartsWith("A");
            });

            foreach (Car car in fiats) {
                Console.WriteLine($"\t the foreach has gotten {car}");
            }


            // But now we can use it with any possible collection, not just cars
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 1, 3, 6, 3, 45, 8, };

            foreach (int n in FilterByYouTellMeYieldGeneric(numbers, item => item % 2 == 0)) {
                Console.WriteLine(n);
            }
        }

        // The last step is to make add our Filter to any IEnumerable,
        // so that we can use it as an instance method.
        // To do this, we can create an Extension Method.
        // Check the MyExtensions class to see how.
        private static void Example07() {
            IEnumerable<Car> fiats = cars.Where(car => {
                Console.WriteLine($"This is the lambda, the car that we got is: {car}");
                return car.Brand.StartsWith("A");
            });

            foreach (Car car in fiats) {
                Console.WriteLine($"\t the foreach has gotten {car}");
            }


            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 1, 3, 6, 3, 45, 8, };

            foreach (int n in numbers.Where(item => item % 2 == 0)) {
                Console.WriteLine(n);
            }

            foreach (int n in MyExtensions.Where(numbers, item => item % 2 == 0)) {
                Console.WriteLine(n);
            }
        }

        // Nowadays, we can also use tuples instead of anonymous types
        private static void FilterExample08() {

            IEnumerable<(string Brand, int LenghtOfTheBrand)> queryForBrandTuple = cars.Select(c => (Brand: c.Brand, LenghtOfTheBrand: c.Brand.Length));
            foreach (var (item1, item2) in queryForBrandTuple) {
                //Console.WriteLine(item);

            }

            foreach (var item in TheQuery()) {
                Console.WriteLine(item.LenghtofTheBrand);
            }

            foreach (var item in TheQuery2()) {
                Console.WriteLine(item.LenghtOfTheBrand);
            }

        }

        public static IEnumerable<dynamic> TheQuery() {
            return cars.Select(c => new { Brand = c.Brand, LenghtOfTheBrand = c.Brand.Length });
        }

        public static IEnumerable<(string Brand, int LenghtOfTheBrand)> TheQuery2() {
            return cars.Select(c => (Brand: c.Brand, LenghtOfTheBrand: c.Brand.Length));
        }


    }
}
