using Line = System.Collections.Generic.List<(int, int)>;
namespace ConsoleApp; 
public class ExtraOpdrachten {
    private static List<string> names = new List<string> {
"Dennis", "Mark", "Ruben", "Milan", "Xander", "Arjen",
"Maurice", "Stijn", "Raymon", "Lex", "Jort",
"Melissa", "Erik", "Youri", "Wouter", "Wesley",
"Wouter", "Jasper", "Jan", "Djurre", "Luuk", "Tim",
};
    /*
    Gegeven de lijst:
    new List<string> {
    "Dennis", "Mark", "Ruben", "Milan", "Xander", "Arjen",
    "Maurice", "Stijn", "Raymon", "Lex", "Jort",
    "Melissa", "Erik", "Youri", "Wouter", "Wesley",
    "Wouter", "Jasper", "Jan", "Djurre", "Luuk", "Tim",
    };
            Schrijf LINQ-queries voor de volgende vragen:
    1.	Alle voorletters van namen die een j bevatten:
            Resultaat:	'A','S','J','J','J','D'
    */
    public static void Opdracht01Method() {
        var q = names.Where(n => n.ToLower().Contains('j')).Select(n => n.First());
        foreach (var item in q) {
            Console.WriteLine(item);
        }
    }
    public static void Opdracht01Comprehension() {
        var q = from n in names
                where n.ToLower().Contains('j')
                select n.First();
        foreach (var item in q) {
            Console.WriteLine(item);
        }
    }

    /*
    2.	Het aantal letters van namen die met een ‘M’ beginnen, aflopend gesorteerd:
    Resultaat:	7, 7, 5, 4
    */
    public static void Opdracht02Methods() {
        var q = names.Where(n => n.ToLower().StartsWith('m')).OrderByDescending(n => n.Length).Select(n => n.Length);

        foreach (var item in q) {
            Console.WriteLine(item);
        }
    }

    public static void Opdracht02Comprehension() {
        var q = from n in names
                where n.ToLower().StartsWith('m')
                orderby n.Length descending
                select n.Length;

        foreach (var item in q) {
            Console.WriteLine(item);
        }
    }
    /*
    3.	Het aantal namen met resp. 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, etc. letters (als het er meer dan 0 zijn):
    Resultaat:	0, 0, 3, 4, 5, 8, 2, 0, 0, 0, …
    */
        public static void Opdracht03Methods() {
            var q = Enumerable.Range(1, names.Max(n => n.Length))
                              .Select(num => names.Count(n => n.Length == num));

            foreach (var item in q) {
                Console.WriteLine(item);
            }
        }
        public static void Opdracht03Comprehension() {
            var q = from num in Enumerable.Range(1, names.Max(n => n.Length))
                    select names.Count(n => n.Length == num);

            foreach (var item in q) {
                Console.WriteLine(item);
            }
        }
    /*
    4.	Alle kortste namen, met daaruit weggelaten de namen die een ‘m’ bevatten, alfabetisch gesorteerd:
    Resultaat:	"Jan", "Lex"
    */
    public static void Opdracht04Methods() {
        var q4 = names
                    .Select(name => new {name, shortestLength = names.Min(n => n.Length) })
                    .Where(item => item.name.Length == item.shortestLength && !item.name.ToLower().Contains('m'))
                    .OrderBy(name => name);
        foreach (var item in q4) {
            Console.WriteLine(item);
        }
    }
    public static void Opdracht04Comprehension() {
        var q4 = from name in names
                 let shortestLength = names.Min(n => n.Length)
                 where name.Length == shortestLength && !name.ToLower().Contains('m')
                 orderby name
                 select name;
        foreach (var item in q4) {
            Console.WriteLine(item);
        }
    }
    /*
    Probeer alle vragen met comprehension syntax te beantwoorden EN  probeer alle vragen met extension method syntax te beantwoorden.
    */


    /*
     * BONUS: Combining line segments
    We have tuples with x and y coordinates, representing points in a coordinate system. A line is represented with a list of two or more points. The input for this program consists of a list of lines (a list, made up of lists of tuples), for example: [[(1,2),(3,4)],[(5,6),(7,8)]]. This is a list of two lines which both consists of two points.

    Create a program that takes such a list as input. The program should then search for lines ending at a point that also marks the beginning of another line, and merge those lines. For example: [[(1,2),(3,4)],[(3,4),(5,6)]] becomes [[(1,2),(3,4),(5,6)]]. Two lines (with common start/end points) have merged into one line with three points.
    */

    public static void Bonus() {
        var inputList = new List<Line>
        {
            new Line { (1,2),(3,4) },
            new Line { (5,6),(10,20) },
            new Line { (3,4),(5,6) },
            new Line { (5,3),(1,2) },
            new Line { (10,20),(4,9) },
            new Line { (6,1),(7,5) },
        };

        var output = inputList.Aggregate(
                new List<Line>(),
                (List<Line> listAggregate, Line inputLine) =>
                    listAggregate
                        .Where(line => line.Last() != inputLine.First() &&
                                       inputLine.Last() != line.First())
                        .Append(listAggregate.Aggregate(inputLine, (Line lineAggregate, Line line) => {
                            if (lineAggregate.Last() == line.First())
                                return lineAggregate.Concat(line.Skip(1)).ToList();
                            else if (line.Last() == lineAggregate.First())
                                return line.Concat(lineAggregate.Skip(1)).ToList();
                            else
                                return lineAggregate;
                        }))
                        .ToList());
    }
}
