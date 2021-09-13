namespace LinqDemos;

public static class LinqQueries {

    public static void Ex01() {
        //linq is available as extension methods of the Enumerable class
        IEnumerable<Car> cars = Enumerable.Where(Car.GetCars(), c => c.Price > 10000);
        foreach (var item in cars) {
            Console.WriteLine(item);
        }
    }
    public static void Ex02() {
        List<Car> list = Car.GetCars();
        //this line will be compiled as the previous example
        IEnumerable<Car> cars = list.Where(c => c.Price > 10000);
        foreach (var item in cars) {
            Console.WriteLine(item);
        }
    }

    public static void Ex03() {
        //there are more ore less 40 methods.
        //some of them accept no input and generate an output sequence:
        IEnumerable<int> numbers = Enumerable.Range(0, 10);
        foreach (var n in numbers) {
            Console.WriteLine(n);
        }

        IEnumerable<string> song = Enumerable.Repeat("NA", 16);
        foreach (var na in song) {
            Console.Write(na);
        }
        Console.WriteLine("BATMAAAAN!");
    }

    //Go to the Labs, try Generators


    public static void Ex04() {
        //some accept an input sequence and output a scalar value:
        int[] numbers = { 5, 1, 6, 2, 8, 3, 9, 4, 0, 5 };

        int max = numbers.Max();
        int min = numbers.Min();
        double avg = numbers.Average();
        int count = numbers.Count();

        //some can also accept predicates
        List<(int, int)> pairs = new() { (1, 2), (3, 4), (5, 6), (2, 1), (8, 2), (7, 3) };

        int maxItem1 = pairs.Max(n => n.Item1);
        int minItem2 = pairs.Min(n => n.Item2);
        double AverageSum = pairs.Average(n => n.Item1 + n.Item2);
        int countEvenSums = pairs.Count(n => (n.Item1 + n.Item2) % 2 == 0);

        int multiply = numbers.Aggregate((n1, n2) => n1 * n2);

        //new in .NET 6
        List<Car> cars = Car.GetCars();
        Car mostExpensiveCar = cars.MaxBy(c => c.Price); //eventually with a custom comparer
        Car cheapestCar = cars.MinBy(c => c.Price); //eventually with a custom comparer
        bool thisCollectionDoesNotNeedToIterateBecauseItHoldsItsOwnCountInMemoryAlready = numbers.TryGetNonEnumeratedCount(out count);

    }

    public static void Ex04b() {
        IEnumerable<Car> cars = Enumerable.Where(Car.GetCars(), c => c.Price > 10000);
        decimal maxPrice = cars.Max(c => c.Price);
    }

    //go to the labs, try AggregateOperators

    public static void Ex05() {
        //some accept an input sequence and output a scalar value:
        int[] numbers = { 5, 1, 6, 2, 8, 3, 9, 4, 0, 5 };
        bool doesTheCollectionContainAnything = numbers.Any();

        //some can also accept predicates
        bool IsThereAnyEvenNumber = numbers.Any(n => n % 2 == 0);
        bool AreTheyAllEvenNumbers = numbers.All(n => n % 2 == 0);

    }

    //go to the labs, try Quantifiers


    public static void Ex06() {
        //some accept an input sequence and output one element:
        int[] numbers = { 5, 1, 6, 2, 8, 3, 9, 4, 0, 5 };
        int first = numbers.First();
        int firstEven = numbers.First(n => n % 2 == 0); // select the item. throws if item not found
        int firstEven2 = numbers.FirstOrDefault(n => n % 2 == 0); // select the item. returns default value if item not found 
        int last = numbers.Last();
        int lastEven = numbers.Last(n => n % 2 == 0);
        int zero = numbers.Single(n => n == 0); //// select the item. throws if multiple items found
        int thirdElement = numbers.ElementAt(2);

        //New in .NET 6
        first = numbers.FirstOrDefault(-1); //should there be no first item, we'll get a -1 instead of a 0
        first = numbers.FirstOrDefault(n => n % 11 == 0, -1); //should there be no first item, we'll get a -1 instead of a 0
                                                              //also for SingleOrDefault and LastOrDefault
        int secondToLast = numbers.ElementAt(^2); //Index instead of int
        int secondToLastOrDefault = numbers.ElementAtOrDefault(^2); //Index instead of int, but you get a default if the element does not exist
    }

    //go to the labs, try ElementOperations

    public static void Ex07() {
        //some accept one input sequence and output one sequence of non repeated elements
        int[] numbers = { 1, 2, 3, 4, 3 };
        IEnumerable<int> distinct = numbers.Distinct(); //1, 2, 3, 4

        Console.WriteLine("DISTINCT"); //1, 2, 3, 4
        foreach (var n in distinct) {
            Console.Write($"{n}, ");
        }

        //some accept two input sequences and output one sequence of non repeated elements

        int[] numbers2 = { 5, 6, 1, 3, 6 };
        IEnumerable<int> union = numbers.Union(numbers2); //1, 2, 3, 4, 5, 6
        IEnumerable<int> intersection = numbers.Intersect(numbers2); //1, 3
        IEnumerable<int> except = numbers.Except(numbers2); //2, 4

        Console.WriteLine("UNION"); //1, 2, 3, 4, 5, 6
        foreach (var n in union) {
            Console.Write($"{n}, ");
        }
        Console.WriteLine();

        Console.WriteLine("INTERSECTION"); //1, 3
        foreach (var n in intersection) {
            Console.Write($"{n}, ");
        }
        Console.WriteLine();

        Console.WriteLine("EXCEPT");
        foreach (var n in except) { //2, 4
            Console.Write($"{n}, ");
        }
        Console.WriteLine();

        //New in .NET 6

        Console.WriteLine("DISTINCT Cars by brand"); // 2
        foreach (var n in Car.GetCars().DistinctBy(c => c.Brand)) {
            Console.WriteLine($"{n}, ");
        }

        List<Musician> nirvana = Musician.GetNirvana();

        List<Musician> fooFighters = Musician.GetFooFighters();

        var allMembers = nirvana.UnionBy(fooFighters, m => m.Name);
        Console.WriteLine("nirvana union foo fighters by musician name");
        foreach (var musician in allMembers) {
            Console.Write(musician.Name + ": ");
            foreach (var instrument in musician.Instruments) {
                Console.Write(instrument + ", ");
            }
        }

        //with exceptby, we don't get dave grohl because his name is in both groups
        IEnumerable<Musician> nirvanaExceptMusiciansWhoseNameIsInFooFighters = nirvana.ExceptBy(fooFighters.Select(m => m.Name), m => m.Name);
        Console.WriteLine("nirvanaExceptMusiciansWhoseNameIsInFooFighters");
        foreach (var musician in nirvanaExceptMusiciansWhoseNameIsInFooFighters) {
            Console.WriteLine(musician.Name);
        }

        //with except, we do get dave grohl because it's a different object
        //IEnumerable<Musician> nirvanaExceptMusiciansInFooFighters = nirvana.Except(fooFighters);
        //Console.WriteLine("nirvanaExceptMusiciansInFooFighters");
        //foreach (var musician in nirvanaExceptMusiciansInFooFighters) {
        //    Console.Write(musician.Name + ": ");
        //    foreach (var instrument in musician.Instruments) {
        //        Console.Write(instrument + ", ");
        //    }
        //}

        //with IntersectBy, we get dave grohl because his name is in both groups
        IEnumerable<Musician> nirvanaInterceptMusiciansWhoseNameIsInFooFighters = nirvana.IntersectBy(fooFighters.Select(m => m.Name), m => m.Name);
        Console.WriteLine("nirvanaInterceptMusiciansWhoseNameIsInFooFighters");
        foreach (var musician in nirvanaInterceptMusiciansWhoseNameIsInFooFighters) {
            Console.WriteLine(musician.Name);
        }

        //with UnionBy, we get dave grohl once because his name is in both groups
        IEnumerable<Musician> nirvanaUnionMusiciansWhoseNameIsInFooFighters = nirvana.UnionBy(fooFighters, m => m.Name);
        Console.WriteLine("nirvanaUnionMusiciansWhoseNameIsInFooFighters");
        foreach (var musician in nirvanaUnionMusiciansWhoseNameIsInFooFighters) {
            Console.WriteLine(musician.Name);
        }
    }

    //go to the labs, try SetOperations

    public static void Ex08() {
        int[] numbers = { 5, 6, 1, 3, 2 };
        int[] numbers2 = { 5, 6, 1, 3, 2 };
        int[] numbers3 = { 2, 3, 5, 6, 1 };

        //some accept two input sequences and output one sequence of (eventually) repeated elements
        IEnumerable<int> concatenation = numbers.Concat(numbers2); //1, 2, 3, 4, 3, 5, 6, 1, 3, 6
        Console.WriteLine("CONCAT");
        foreach (var n in concatenation) { //1, 2, 3, 4, 3, 5, 6, 1, 3, 6
            Console.Write($"{n}, ");
        }

        //SequenceEquals can tell you if two collections contain the same elements in the same order
        bool se1 = numbers.SequenceEqual(numbers2); //true
        bool se2 = numbers.SequenceEqual(numbers3); //false (same elements but different order)
        Console.WriteLine(se1);
        Console.WriteLine(se2);

        //Zip can link two collections together
        IEnumerable<(int First, int Second)> zippedSequence = numbers.Zip(numbers3);
        foreach (var (First, Second) in zippedSequence) {
            Console.WriteLine($"({First} , {Second})"); // (5,2) (6,3) (1,5) (3,6) (2,1)
        }

        //New in .net 5
        //you can link 3 collections together
        var three = numbers.Zip(numbers3, new[] { "a", "b", "c", "d", "e" });
        foreach (var (First, Second, Third) in three) {
            Console.WriteLine($"({First} , {Second}, {Third})"); // (5,2,a) (6,3,b) (1,5,c) (3,6,d) (2,1,e)
        }
    }

    //go to the labs and try SequenceOperations

    public static void Ex09() {
        // many operators return an IEnumerable
        int[] numbers = { 1, 2, 3, 4, 5 };
        IEnumerable<int> doubles = numbers.Select(n => n * 2);

        // but you can then change the result 
        // into an array
        int[] doublesAsArray = doubles.ToArray();
        Console.WriteLine("The fourth element is " + doublesAsArray[3]);

        // or list 
        List<int> doublesAsList = doubles.ToList();
        doublesAsList.Add(8);
        Console.WriteLine($"The list has {doublesAsList.Count()} elements");

        //or dictionary
        Dictionary<string, int> doublesAsDictionary = doubles.ToDictionary(n => n.ToString());
        Console.WriteLine(doublesAsDictionary["4"]);

        //if your collection contains different types, you can filter by type

        List<Person> people = new() {
            new Driver() { Name = "Mario Andretti" },
            new Supplier() { Name = "Supplying Company" },
            new Musician() { Name = "Plini" },
            new Customer() { Name = "Alice Anderson" },
            new Musician() { Name = "John Petrucci" },
            new Musician() { Name = "Mike Portnoy" },
            new Person() { Name = "Super Mario" }
        };

        foreach (var item in people.OfType<Musician>()) {
            Console.WriteLine(item.Name);
        }

        //New in .NET 6

        /* If the input type cannot be cast to the output type, 
         * the current behavior is to just return an empty sequence. 
         * With the do not use OfType<T>() with impossible types proposal, 
         * the developer will instead get a compiler warning.*/
        var strings = people.OfType<string>();

        IEnumerable<Person[]> chunks = people.Chunk(2);
        foreach (Person[] chunk in chunks) {
            Console.WriteLine("Chunk");
            foreach (Person person in chunk) {
                Console.WriteLine($"\t{person}");
            }
        }
    }

    // go to the Labs and try ConversionOperators

    public static void Ex10() {
        int[] numbers = { 5, 1, 6, 2, 8, 3, 9, 4, 0, 5 };

        //some can be used to partition a collection

        //you can take x elements, starting from the beginning
        IEnumerable<int> firstThree = numbers.Take(3); //5,1,6

        //you can skip x elements and take the rest until the end
        IEnumerable<int> AllButFirstThree = numbers.Skip(3); //2, 8, 3, 9, 4, 0, 5 

        //you can combine the skip and take to get some elements in between
        IEnumerable<int> firstThreeAfterTheFirst4 = numbers.Skip(4).Take(3); // 8, 3, 9

        //you can also use conditions
        IEnumerable<int> firstWhileLessThan8 = numbers.TakeWhile(n => n < 8); //5,1,6,2
        IEnumerable<int> skipWhileLessThan8 = numbers.SkipWhile(n => n > 8); //9,4,0,5

        //New in .NET 6
        IEnumerable<int> fromPosition3IncludedToPosition6Excluded = numbers.Take(3..6); //range => 2, 8, 3, equivalent to skip 3, take 3
        IEnumerable<int> fromPosition3IncludedToTheEnd = numbers.Take(3..); //range => 2, 8, 3, 9, 4, 0, 5, equivalent to skip 3
        IEnumerable<int> fromTheBeginningToPosition6Excluded = numbers.Take(..6); //range => 5, 1, 6, 2, 8, 3, equivalent to Take(Length - 6)

    }

    // go to the labs and try Partitioning

    public static void Ex11() {
        //the methods returning a scalar values are immediately executed,
        //but the ones returning IEnumerables are delayed until the collection
        //is consumed by a foreach
        List<int> numbers = new() { 1, 2, 3 };

        IEnumerable<int> query = numbers.Where(n => {
            Console.WriteLine($"\tWHERE {n}");
            return n % 2 == 0;
        });

        //without the foreach, we don't see anything on screen

        //foreach (var n in result) {
        //    Console.WriteLine(n);
        //}

        //if we add a new item in the list and then we execute the foreach,
        //we will find the new item in the result 

        numbers.Add(4);
        foreach (var n in query) {
            Console.WriteLine(n);
        }
    }

    public static void Ex12() {
        //because many linq methods return an IEnumerable,
        //we can chain them together

        List<string> names = new() { "Tom", "Dick", "Harry", "Mary", "Jay" };
        IEnumerable<string> query =
            names.Where(n => n.Contains('a'))
                 .OrderBy(n => n.Length)
                 .Select(n => n.ToUpper());

        names.Add("Ada");

        foreach (string name in query) {
            Console.WriteLine(name);
        }
    }

    public static void Ex13() {
        //let's print something, to see when and how each methods get executed

        string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };
        IEnumerable<string> query =
            names
            .Where(n => {
                Console.WriteLine($"\tWHERE {n}");
                return n.Contains('a');
            })
            .OrderBy(n => {
                Console.WriteLine($"\t\tORDERBY {n}");
                return n.Length;
            })
            .Select(n => {
                Console.WriteLine($"\t\t\tSELECT {n}");
                return n.ToUpper();
            });

        foreach (string name in query) {
            Console.WriteLine($"foreach: {name}");
        }
    }

    public static void Ex14() {
        //some of the extension methods (but not all)
        //are also available as linq keywords (query syntax)
        //They will be translated as extension methods

        string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };

        IEnumerable<string> query1 = names
                                    .Where(n => n.Contains('a'))
                                    .OrderBy(n => n.Length)
                                    .Select(n => n.ToUpper());

        IEnumerable<string> query = from n in names
                                    where n.Contains('a')
                                    orderby n.Length
                                    select n.ToUpper();

        foreach (string name in query) {
            Console.WriteLine(name);
        }
    }

    public static void Ex15() {
        //so let's explore the syntax of the linq queries
        //each query starts with a from
        //in order to declare a range variable.
        //it ends either with a select or a group by

        /*
                                                    select
                                                   /      \
        from -------------------------------------<        >
                                                  \        /
                                                   group by
        */

        string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };

        IEnumerable<string> query = from n in names //n is a range variable
                                    select n.ToUpper(); //you can use n in the rest of the query

        foreach (var name in query) {
            Console.WriteLine(name);
        }
    }

    public static void Ex16() {
        //a select will always output as many items as the input, 
        //but they may be different shaped items

        string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };

        var query = from n in names
                    select new { Name = n.ToUpper(), n.Length }; //anonymous class, that's why we use var

        foreach (var item in query) {
            Console.WriteLine($"The name {item.Name} is {item.Length} letters long");
        }
    }

    public static void Ex17() {
        //you can output a tuple if you want to,
        //no need to use anonymous type anymore

        string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };

        IEnumerable<(string Name, int Length)> query = from n in names
                                                       select (Name: n.ToUpper(), n.Length); //tuple, so now we know the exact type, no need to use var

        foreach ((string Name, int Length) item in query) {
            Console.WriteLine($"The name {item.Name} is {item.Length} letters long");
        }

        foreach ((string Name, int Length) in query) {
            Console.WriteLine($"The name {Name} is {Length} letters long");
        }
    }

    class NameLength {
        public int Length { get; set; }
        public string Name { get; set; }
    }

    public static void Ex18() {
        //tuples are handy for method results:

        IEnumerable<NameLength> methodReturningSpecificType() { //either we use dynamic or object as a return type
            string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };

            return from n in names
                   select new NameLength() { Name = n.ToUpper(), Length = n.Length }; //anonymous class, that's why we use var
        }

        foreach (NameLength item in methodReturningSpecificType()) {
            Console.WriteLine($"The name {item.Name} is {item.Length} letters long"); //no intellisense here!
        }

        dynamic methodReturningAnonType() { //either we use dynamic or object as a return type
            string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };

            return from n in names
                   select new { Name = n.ToUpper(), n.Length }; //anonymous class, that's why we use var
        }

        IEnumerable<(string Name, int Length)> methodReturningTuple() { //now we can declare the exact shape we're returning
            string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };

            return from n in names
                   select (Name: n.ToUpper(), n.Length); //tuple, so now we know the exact type, no need to use var
        }


        foreach (var item in methodReturningAnonType()) {
            Console.WriteLine($"The name {item.Name} is {item.Length} letters long"); //no intellisense here!
        }

        foreach ((string Name, int Length) item in methodReturningTuple()) {
            Console.WriteLine($"The name {item.Name} is {item.Length} letters long"); //Intellisense!
        }

        string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };

        foreach (string description in names.Select((n, position) => $"The item {n} is at position {position}")) {
            Console.WriteLine(description);
        }
    }

    //go to the Labs and try Projections

    public static void Ex19() {
        //if you want a hyerarchical output,
        //you can use group by instead

        string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay", "Tamara", "Tim", "Dante", "Martha", "Marco", "John", "James" };
        IEnumerable<IGrouping<string, string>> query = from n in names
                                                       group n by n.Substring(0, 1);

        //translated as:
        IEnumerable<IGrouping<string, string>> query2 = names.GroupBy(n => n.Substring(0, 1));

        foreach (IGrouping<string, string> grouping in query) {
            Console.WriteLine(grouping.Key);
            foreach (var item in grouping) {
                Console.WriteLine("\t" + item);
            }
        }
        /*
         * T
                    Tom
                    Tamara
                    Tim
            D
                    Dick
                    Dante
            H
                    Harry
            M
                    Mary
                    Martha
                    Marco
                    */


    }

    public static void Ex20() {
        //you can use any key to group by 
        string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay", "Tamara", "Tim", "Dante", "Martha", "Marco", "Mitch", "Tod", "John", "James" };

        var query = from n in names
                    group n by new { Initial = n.Substring(0, 1), n.Length };

        foreach (var grouping in query) {
            Console.WriteLine($"{grouping.Key.Initial} - {grouping.Key.Length}");
            foreach (var item in grouping) {
                Console.WriteLine("\t" + item);
            }
        }
    }

    public static void Ex21() {
        //you can group anything you need 
        string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay", "Tamara", "Tim", "Dante", "Martha", "Marco", "Mitch", "Tod", "John", "James" };

        var query = from n in names
                    group new { Name = n.ToUpper(), n.Length } by n.Substring(0, 1);

        foreach (var grouping in query) {
            Console.WriteLine($"{grouping.Key}");
            foreach (var item in grouping) {
                Console.WriteLine($"\t{item.Name} - {item.Length}");
            }
        }
    }

    //go to the Labs and try Grouping

    public static void Ex22() {
        //you can also save your query into a new variable, 
        //so that you can select a different shape if you don't like the grouping

        /*
                                                    select
                                                   /      \
        from -------------------------------------<        > [into]----
                                      ^           \        /          |
                                      |            group by           |
                                      |                               |
                                      ---------------------------------
        */

        string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay", "Tamara", "Tim", "Dante", "Martha", "Marco", "Mitch", "Tod", "John", "James" };

        var query = from n in names
                    group new { Name = n.ToUpper(), n.Length } by n.Substring(0, 1) into groupedNames //new range variable
                    select (Initial: groupedNames.Key, Items: groupedNames);

        foreach (var row in query) {
            Console.WriteLine($"{row.Initial}");
            foreach (var item in row.Items) {
                Console.WriteLine($"\t{item.Name} - {item.Length}");
            }
        }
    }

    public static void Ex22a() {
        //you can also save your query into a new variable, 
        //so that you can select a different shape if you don't like the grouping

        /*
                                                    select
                                                   /      \
        from -------------------------------------<        > [into]----
                                      ^           \        /          |
                                      |            group by           |
                                      |                               |
                                      ---------------------------------
        */

        string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay", "Tamara", "Tim", "Dante", "Martha", "Marco", "Mitch", "Tod", "John", "James" };

        var query = from n in names
                    group new { Name = n.ToUpper(), n.Length } by n.Substring(0, 1) into groupedNames
                    select (Initial: groupedNames.Key, LengthOfLongestName: groupedNames.Max(names => names.Length));

        foreach (var row in query) {
            Console.WriteLine($"{row.Initial} {row.LengthOfLongestName}");
        }
    }

    //go to the Labs and try GroupingInto


    public static void Ex23() {
        //between a from and a select (or group by)
        //there are many keywords you can use : where

        /*
                    where
                   /     \                          select
                  /       \                        /      \
        from ----<--------->----------------------<        >
                                                  \        /
                                                   group by
        */

        string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay", "Tamara", "Tim", "Dante", "Martha", "Marco", "Mitch", "Tod", "John", "James" };

        var query = from n in names
                    where n.StartsWith("T")
                    select n;

        foreach (var item in query) {
            Console.WriteLine(item);
        }
        //or
        var query2 = from n in names
                     where n.Length > 3
                     group n by n.Substring(0, 1);

        foreach (var item in query2) {
            Console.WriteLine(item.Key);
            foreach (var name in item) {
                Console.WriteLine($"\t{name}");
            }
        }
    }

    //go to the labs and try Restrictions

    public static void Ex24() {
        //between a from and a select (or group by)
        //there are many keywords you can use : orderby

        /*
                    where
                   /     \                          select
                  /orderby\                        /      \
        from ----<--------->----------------------<        >
                                                  \        /
                                                   group by
        */

        string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay", "Tamara", "Tim", "Dante", "Martha", "Marco", "Mitch", "Tod", "John", "James" };

        var query = from n in names
                    orderby n
                    select n;

        foreach (var item in query) {
            Console.WriteLine(item);
        }

        //or
        var query2 = from n in names
                     orderby n
                     group n by n.Substring(0, 1);

        Console.WriteLine("------------");
        foreach (var item in query2) {
            Console.WriteLine(item.Key);
            foreach (var name in item) {
                Console.WriteLine($"\t{name}");
            }
        }

        //or
        var query3 = from n in names
                     orderby n, n.Length //descending
                     select n;
        Console.WriteLine("------------");
        foreach (var item in query3) {
            Console.WriteLine(item);
        }
        //names.OrderBy(n=>n).ThenBy(n=>n.Length)
    }

    // go to the labs and try Ordering

    public static void Ex25() {
        //between a from and a select (or group by)
        //there are many keywords you can use : let

        /*
                    where
                   /     \                          select
                  /orderby\                        /      \
        from ----<--------->----------------------<        >
                  \  let  /                       \        /
                                                   group by
        */

        string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay", "Tamara", "Tim", "Dante", "Martha", "Marco", "Mitch", "Tod", "John", "James" };

        //let can increase speed and / or readability

        //Example: I want to select the names with more than 3 consonants.
        //it means I have to remove all the vowels aeiou
        //I could do it like this

        var q1 = from n in names
                 where (n.Replace("a", "").Replace("e", "").Replace("i", "").Replace("o", "").Replace("u", "")).Length > 3
                 select n.Replace("a", "").Replace("e", "").Replace("i", "").Replace("o", "").Replace("u", "");

        //but this is not readable and also not performant
        //with the let keyword we can introduce a new range variable (novowel, in this case)
        var q2 = from n in names
                 let novowel = n.Replace("a", "").Replace("e", "").Replace("i", "").Replace("o", "").Replace("u", "") //range variable
                 where novowel.Length > 3
                 select novowel;

        //the previous range variable is still in scope, so we can still use it
        var q3 = from n in names
                 let novowel = n.Replace("a", "").Replace("e", "").Replace("i", "").Replace("o", "").Replace("u", "")
                 where novowel.Length > 3
                 select novowel + " comes from " + n;

        foreach (var item in q1) {
            Console.WriteLine(item);
        }
        Console.WriteLine("-----------------------");
        foreach (var item in q2) {
            Console.WriteLine(item);
        }
        Console.WriteLine("-----------------------");
        foreach (var item in q3) {
            Console.WriteLine(item);
        }

        //another example where the let is used to store the length of the name in each group, so that
        //we can then also select the first anem of the group whose length is the same as the one we just stored


        var query = from n in names
                    group new { Name = n.ToUpper(), n.Length } by n.Substring(0, 1) into groupedNames
                    let LengthOfLongestName = groupedNames.Max(names => names.Length)
                    select (Initial: groupedNames.Key, LengthOfLongestName, LongestName: groupedNames.First(names => names.Length == LengthOfLongestName));
        foreach (var item in query) {
            Console.WriteLine($"{item.Initial} - {item.LongestName} - {item.LengthOfLongestName}");
        }


    }

    // go to the labs and try LetOperator



    public static void Ex26() {
        //you can combine multiple techniques.
        //"progressive building" is a technique where you build multiple queries after each other
        //continuing from where you just left (q2 uses initials as input in this example)
        //You can use hybrid queries if you miss the linq operators (Distinct in this case)
        //You can use let for speed and readability
        //You can use subqueries for grouping into a hyerarchical structure

        string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay", "Tamara", "Tim", "Dante", "Martha", "Marco", "Mitch", "Tod", "John", "James" };

        var initials = (from n in names
                        let initial = n.Substring(0, 1).ToUpper()
                        orderby initial
                        select initial).Distinct();
        var q2 = from initial in initials
                 select new {
                     Initial = initial,
                     Names = from n in names where n.Substring(0, 1).ToUpper() == initial select n
                 };

        foreach (var item in q2) {
            Console.WriteLine(item.Initial);
            foreach (var name in item.Names) {
                Console.WriteLine("\t" + name);
            }

        }
    }

    public static void Ex27() {
        //so far we've seen how to project one list into another list
        //with select
        //or how to project a list into a hierarchycal structure
        //with group by or subqueries.

        //now we have two lists and we want to make one

        /*

        --------    --------      -----------
        |      |    |      |      |         |
        |      |----|      | ---> |         |
        |      |    |      |      |         |
        |      |    |      |      |         |
        --------    --------      -----------

        */
        //we can use the join keyword

        /*
                    where
                   /     \                          select
                  /orderby\                        /      \
        from ----<--------->----------------------<        >
                  \  let  /                       \        /
                   \     /                         group by
                     join
        */
        //the join keyword produces an inner equi join
        //in this example it means
        //that cars with no drivers
        //and drivers with no cars
        //will not show up in the result

        List<Car> cars = Car.GetCars();

        List<Driver> drivers = Driver.GetDrivers();

        var q1 = from c in cars
                 join d in drivers
                 on c.Id equals d.CarId
                 select new { d.Name, c.Brand, c.Model };

        var q2 = from c in cars
                 join d in drivers
                 on c.Id equals d.CarId
                 select new { Car = c, Driver = d };


        foreach (var item in q1) {
            Console.WriteLine(item.Name + " drives " + item.Brand + " " + item.Model);
        }



    }

    //go to the labs and try JoinOperations

    public static void Ex28() {
        //the join keyword also has an optional into keyword
        //with wich we can define a new range variable
        //using this technique we can achieve
        //a left outer join that will produce a hyerarchical output

        //now we have two lists and we want to make one

        /*

        --------    --------      --------
        |      |    |      |      |      |
        |      |----|      | ---> --------
        |      |    |      |          |     ----------
        |      |    |      |          ------|        |
        --------    --------                ----------

        */

        /*
                    where
                   /     \                          select
                  /orderby\                        /      \
        from ----<--------->----------------------<        >
                  \  let  /                       \        /
                   \     /                         group by
                 join [into]
        */

        List<Car> cars = Car.GetCars();

        List<Driver> drivers = Driver.GetDrivers();

        var q1 = from c in cars
                     //--------------------//
                 join d in drivers
                 on c.Id equals d.CarId
                 into cardrivers       //new range variable
                                       //--------------------//
                 orderby c.Brand, c.Model
                 //we selected all the cars up above
                 //so we will also get the cars with no drivers this time
                 //while the cardrivers collection could be empty
                 select new { Car = c, Drivers = cardrivers };

        foreach (var item in q1) {
            Console.WriteLine(item.Car.Brand + " " + item.Car.Model);
            foreach (var d in item.Drivers) {
                Console.WriteLine("\t" + d.Name + " " + d.Surname);
            }
        }
    }



    public static void Ex29() {
        //the join keyword also has an optional into keyword
        //with wich we can define a new range variable
        //using this technique we can achieve
        //a left outer join that will produce a hyerarchical output

        //now we have two lists and we want to make one

        /*

        --------    --------      --------
        |      |    |      |      |      |
        |      |----|      | ---> --------
        |      |    |      |          |     ----------
        |      |    |      |          ------|        |
        --------    --------                ----------

        */

        /*
                    where
                   /     \                          select
                  /orderby\                        /      \
        from ----<--------->----------------------<        >
                  \  let  /                       \        /
                   \     /                         group by
                 join [into]
        */

        List<Car> cars = Car.GetCars();

        List<Driver> drivers = Driver.GetDrivers();

        var q1 = from c in cars
                     //--------------------//
                 join d in drivers
                 on c.Id equals d.CarId
                 into cardrivers       //new range variable
                                       //--------------------//
                 orderby c.Brand, c.Model
                 //we selected all the cars up above
                 //we will get also the cars with no drivers this time
                 //but we can create a default driver if cardrivers is empty
                 select new { Car = c, Drivers = cardrivers.DefaultIfEmpty(new Driver() { Name = "No", Surname = "Driver" }) };

        foreach (var item in q1) {
            Console.WriteLine(item.Car.Brand + " " + item.Car.Model);
            foreach (var d in item.Drivers) {
                Console.WriteLine("\t" + d.Name + " " + d.Surname);
            }
        }
    }

    public static void Ex30() {
        //the join keyword also has an optional into keyword
        //with wich we can define a new range variable
        //using this technique we can achieve
        //a left outer join that will produce a hyerarchical output

        //now we have two lists and we want to make one

        /*

        --------    --------      --------
        |      |    |      |      |      |
        |      |----|      | ---> --------
        |      |    |      |          |     ----------
        |      |    |      |          ------|        |
        --------    --------                ----------

        */

        /*
                    where
                   /     \                          select
                  /orderby\                        /      \
        from ----<--------->----------------------<        >
                  \  let  /                       \        /
                   \     /                         group by
                 join [into]
        */

        List<Car> cars = Car.GetCars();

        List<Driver> drivers = Driver.GetDrivers();

        var q1 = from c in cars
                     //-------------------//
                 join d in drivers
                 on c.Id equals d.CarId
                 into cardrivers         //new range variable
                                         //--------------------//
                 orderby c.Brand, c.Model
                 //we selected all the cars up above
                 //but we can filter
                 //so that we take only the cars with drivers,
                 //effectively going back to an inner join
                 where cardrivers.Any()
                 select new { Car = c, Drivers = cardrivers };

        foreach (var item in q1) {
            Console.WriteLine(item.Car.Brand + " " + item.Car.Model);
            foreach (var d in item.Drivers) {
                Console.WriteLine("\t" + d.Name + " " + d.Surname);
            }
        }
    }

    public static void Ex31() {
        //another left outer join that will produce a hyerarchical output

        /*

        --------    --------      --------
        |      |    |      |      |      |
        |      |----|      | ---> --------
        |      |    |      |          |     ----------
        |      |    |      |          ------|        |
        --------    --------                ----------

        */

        /*
                    where
                   /     \                          select
                  /orderby\                        /      \
        from ----<--------->----------------------<        >
                  \  let  /                       \        /
                   \     /                         group by
                 join [into]
        */

        List<Car> cars = Car.GetCars();

        List<Driver> drivers = Driver.GetDrivers();

        var q1 = from d in drivers
                 join c in cars
                 on d.CarId equals c.Id
                 into carsfordriver
                 select new { Driver = d, Cars = carsfordriver };

        foreach (var item in q1) {
            Console.WriteLine(item.Driver.Name + " " + item.Driver.Surname);
            foreach (var c in item.Cars) {
                Console.WriteLine("\t" + c.Model + " " + c.Price);
            }
        }
    }

    // go to the labs and try LeftJoin


    public static void Ex32() {
        /*
         * An additional from keyword can be use to get a cross join 
         */

        /*
                    where
                   /     \                          select
                  /orderby\                        /      \
        from ----<--------->----------------------<        >
                  \  let  /                       \        /
                   \     /                         group by
                 join [into]
                     \ /
                     from

        */


        int[] numbers = new int[] { 1, 2, 3 };
        string[] letters = new string[] { "a", "b", "c" };


        var q = from n in numbers
                from l in letters
                select new { n, l };

        /*
         *  1 - a
            1 - b
            1 - c
            2 - a
            2 - b
            2 - c
            3 - a
            3 - b
            3 - c

             */

        foreach (var item in q) {
            Console.WriteLine($"{item.n} - {item.l}");
        }

        List<Car> cars = Car.GetCars();

        List<Driver> drivers = Driver.GetDrivers();

        var query = from d in drivers
                    from c in cars //every driver connected to every car (cross join)
                    select new { c, d };
        foreach (var item in query) {
            Console.WriteLine($"{item.c.Brand} {item.c.Model} {item.d.Name} {item.d.Surname}");
        }
    }

    public static void Ex33() {
        /*
         * With the correct filters we can go from a the cross join to an outer join
         */

        /*
                    where
                   /     \                          select
                  /orderby\                        /      \
        from ----<--------->----------------------<        >
                  \  let  /                       \        /
                   \     /                         group by
                 join [into]
                     \ /
                     from

        */


        List<Car> cars = Car.GetCars();

        List<Driver> drivers = Driver.GetDrivers();

        var query = from d in drivers

                    from c in cars
                    where d.CarId != c.Id //we get the drivers connected to the cars they DON'T drive

                    select new { c, d };
        foreach (var item in query) {
            Console.WriteLine($"{item.d.Name} {item.d.Surname} DOES NOT DRIVE {item.c.Brand} {item.c.Model}");
        }
    }



    public static void Ex34() {
        //if you have a hyerarchical input
        //and you want to flatten it
        //you can use the from keyword again

        /*

         --------                    --------
         |      |                    |      |
         --------             --->   |      |
             |     ----------        |      |
             ------|        |        |      |
                   ----------        --------

        */

        /*
                    where
                   /     \                          select
                  /orderby\                        /      \
        from ----<--------->----------------------<        >
                  \  let  /                       \        /
                   \     /                         group by
                 join [into]
                     \ /
                     from

        */

        List<Musician> beatles = Musician.GetBeatles();

        var musiciansandinstrumentsflattened = from m in beatles
                                               from i in m.Instruments
                                               select new { m.Name, Instrument = i };
        foreach (var musician in musiciansandinstrumentsflattened) {
            Console.WriteLine(musician.Name + " plays " + musician.Instrument);
        }
        /*
         *  Paul plays Bass
            Paul plays Guitar
            Paul plays Vocals
            John plays Guitar
            John plays Piano
            John plays Vocals
            George plays Guitar
            George plays Vocals
            Ringo plays Drums
            Ringo plays Vocals
        */
    }

    public static void Ex35() {
        //another example of the from - from
        //to flatten a hyerarchical input

        /*

         --------                    --------
         |      |                    |      |
         --------             --->   |      |
             |     ----------        |      |
             ------|        |        |      |
                   ----------        --------

        */

        /*
                    where
                   /     \                          select
                  /orderby\                        /      \
        from ----<--------->----------------------<        > - into -
                  \  let  /                       \        /
                   \     /                         group by
                 join [into]
                     \ /
                     from

        */

        string[] names = { "John Mark", "Frank Steve Fanny", "Phillis James Mary Dave" };

        var q = from n in names
                from name in n.Split()
                select name;
        foreach (var item in q) {
            Console.WriteLine(item);
        }
    }

    public static void Ex36() {
        //in this last example, combining many different techniques,
        //we get a flat left join.
        //the DefaultIfEmpty method will return a list with a default value
        //should the list be empty 

        List<Car> cars = Car.GetCars();

        List<Driver> drivers = Driver.GetDrivers();

        IEnumerable<(Car Car, Driver Driver)> q1 =
            from c in cars

            join d in drivers
            on c.Id equals d.CarId
            into driversforcar

            from driverforcar in driversforcar.DefaultIfEmpty(new Driver() { Name = "No", Surname = "Driver" })

            select (Car: c, Driver: driverforcar);

        foreach (var item in q1) {
            Console.WriteLine(item.Car + " " + item.Driver);
        }
        /*
         *  1 Alfa Romeo 147 15000 0 - No Driver
            2 Alfa Romeo MiTo 16000 2 - Bob Builders
            2 Alfa Romeo MiTo 16000 6 - Frank Funnel
            2 Alfa Romeo MiTo 16000 7 - Donald Trump
            8 Alfa Romeo Giulietta 11000 0 - No Driver
            3 Audi A3 22000 0 - No Driver
            4 Audi A2 23000 4 - Marco Danielson
            4 Audi A2 23000 5 - Giulia Conte
            4 Audi A2 23000 9 - Kyle Korelson
            9 Audi A1 20000 3 - Candice Clarkson
            5 Citroen C1 11000 1 - Alice Anderson
            5 Citroen C1 11000 8 - Stan Lee
            6 Citroen C2 13000 0 - No Driver
            7 FIAT 500 14000 0 - No Driver
            10 FIAT Panda 9000 0 - No Driver
         */
    }

    // go to the labs and try SelectMany

    //then try the MegaChallenge!
}
