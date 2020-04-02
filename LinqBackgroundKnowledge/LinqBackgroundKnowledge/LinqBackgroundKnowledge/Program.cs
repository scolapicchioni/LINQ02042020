using System;
using System.Collections.Generic;
using ExtensionsNameSpace;
using System.Linq;
namespace LinqBackgroundKnowledge {
    class Program {
        static void Main(string[] args) {
            FilterExample2();

        }

        private static void FilterExample() {
            List<Car> cars = new List<Car>() {
                new Car() { Id = 1, Brand="FIAT", Name = "Punto", Price = 12345 },
                new Car() { Id = 2, Brand="FIAT", Name = "500", Price = 9345 },
                new Car() { Id = 3, Brand="Audi", Name = "A2", Price = 52345 },
                new Car() { Id = 4, Brand="Audi", Name = "A3", Price = 32345 }
            };

            List<Car> fiats = FilterWhereBrandIsFIAT(cars);

            /*
               1 - Punto - FIAT - ? 12.345
               2 - 500 - FIAT - ? 9.345
             */
            foreach (var item in fiats) {
                Console.WriteLine(item);
            }


            List<Car> expensive = FilterWherePriceGreaterThan15_000(cars);

            /*
             3 - A2 - Audi - ? 52.345
             4 - A3 - Audi - ? 32.345
             */
            foreach (var item in expensive) {
                Console.WriteLine(item);
            }
        }

        private static void FilterExample2() {
            List<Car> cars = new List<Car>() {
                new Car() { Id = 1, Brand="FIAT", Name = "Punto", Price = 12345 },
                new Car() { Id = 2, Brand="FIAT", Name = "500", Price = 9345 },
                new Car() { Id = 3, Brand="Audi", Name = "A2", Price = 52345 },
                new Car() { Id = 4, Brand="Audi", Name = "A3", Price = 32345 }
            };

            //List<Car> fiats = Filter(cars, IsBrandFiat);

            IEnumerable<Car> fiats = cars.Filter(IsBrandFiat);


            /*
               1 - Punto - FIAT - ? 12.345
               2 - 500 - FIAT - ? 9.345
             */
            foreach (var item in fiats) {
                Console.WriteLine(item);
            }


            IEnumerable<Car> expensive = MyExtensions.Filter(cars, IsPriceGreaterThan15_000);

            /*
             3 - A2 - Audi - ? 52.345
             4 - A3 - Audi - ? 32.345
             */
            foreach (var item in expensive) {
                Console.WriteLine(item);
            }

            List<int> numbers = new List<int>() { 1, 3, 6, 3, 6, 89, 5, 5, 2 };
            IEnumerable<int> evenNumbers = numbers.Filter(isNumberEven);

            string x = "a B c d E f g h";

            IEnumerable<char> res = x.Filter(checkLetter);
            foreach (char item in res) {
                Console.WriteLine(item);
            }

            Action action = () => { 
                Console.WriteLine("oh HI!");
                Console.WriteLine("oh HI again!");
            };

            Action action2 = () => Console.WriteLine("oh HI!");

            Action<Car> action3 = (c) => {
                Console.WriteLine(c);
            };

            action3(new Car() { Id = 3 });

            IEnumerable<int> numbersGreaterThan3 = numbers.Filter(n => n > 3);

            IEnumerable<char> res2 = x.Filter( n => Char.IsUpper(n) );

            IEnumerable<int> query = x.Select(c=>(int)c);

            var queryForBrand = cars.Select(c => new { Brand = c.Brand, LenghtOfTheBrand = c.Brand.Length });

            var bla = "";
            //bla = 3;

            var myAnonObject = new { SomeProperty = "some value", AnIntProperty = 5, ABoolProperty = false };

            
            foreach (var item in queryForBrand) {
                Console.WriteLine(item.LenghtOfTheBrand); 
            }

            //(string SomeProperty, int AnIntProperty, bool ABoolProperty) = ( SomeProperty : "some value", AnIntProperty : 5, ABoolProperty : false );


            IEnumerable<(string Brand, int LenghtOfTheBrand)> queryForBrandTuple = cars.Select(c => (Brand : c.Brand, LenghtOfTheBrand : c.Brand.Length ));
            foreach (var (item1,item2) in queryForBrandTuple) {
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
            List<Car> cars = new List<Car>() {
                new Car() { Id = 1, Brand="FIAT", Name = "Punto", Price = 12345 },
                new Car() { Id = 2, Brand="FIAT", Name = "500", Price = 9345 },
                new Car() { Id = 3, Brand="Audi", Name = "A2", Price = 52345 },
                new Car() { Id = 4, Brand="Audi", Name = "A3", Price = 32345 }
            };

            return cars.Select(c => new { Brand = c.Brand, LenghtOfTheBrand = c.Brand.Length });

        }


        public static IEnumerable<(string Brand, int LenghtOfTheBrand)> TheQuery2() {
            List<Car> cars = new List<Car>() {
                new Car() { Id = 1, Brand="FIAT", Name = "Punto", Price = 12345 },
                new Car() { Id = 2, Brand="FIAT", Name = "500", Price = 9345 },
                new Car() { Id = 3, Brand="Audi", Name = "A2", Price = 52345 },
                new Car() { Id = 4, Brand="Audi", Name = "A3", Price = 32345 }
            };

            return cars.Select(c => (Brand : c.Brand, LenghtOfTheBrand : c.Brand.Length) );

        }


        public static void myMethodWithACar(Car bshjkfbhsjk) { 
            
        }

        private static void m() {
            Console.WriteLine("oh HI!");
        }

        public static bool checkLetter(char letter) {
            return !Char.IsWhiteSpace(letter);
        }

        public static bool isNumberEven (int item){
            return item % 2 == 0;
        }
        

        public static List<Car> FilterWhereBrandIsFIAT(List<Car> cars) {
            List<Car> result = new List<Car>();
            foreach (Car car in cars) {
                if (IsBrandFiat(car)) {
                    result.Add(car);
                }
            }
            return result;
        }

        

        public static List<Car> FilterWherePriceGreaterThan15_000(List<Car> cars) {
            List<Car> result = new List<Car>();
            foreach (Car car in cars) {
                if (IsPriceGreaterThan15_000(car)) {
                    result.Add(car);
                }
            }
            return result;
        }

        private static bool IsBrandFiat(Car car) {
            return car.Brand == "FIAT";
        }

        private static bool IsPriceGreaterThan15_000(Car car) {
            return car.Price > 15_000;
        }



        public static void DelegatesExample() {
            

            void myMethod01() {
                Console.WriteLine("I'm in method1 now!");
            }

            //Action doStuff = myMethod01;

            //myMethod01();

            //doStuff();

            AMethodThatRequiresAnAction(myMethod01);
        }

        public static void AMethodThatRequiresAnAction(Action theMethodToInvoke) {
            Console.WriteLine("the beginning of my method");
            theMethodToInvoke();
            Console.WriteLine("the rest of my method");
        }

        
    }
}
