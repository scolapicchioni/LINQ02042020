using DataHelper;

namespace ConsoleApp;

public static class AggregateOperators {

    public static void CountSyntax() {
        /*
         * How many employees do we have?
         */
        IEnumerable<Employee> employees = DataSource.Employees;

        int howManyEMployees = employees.Count();

        Console.WriteLine($"There are {howManyEMployees} employees.");
    }

    public static void CountConditional() {
        IEnumerable<Employee> employees = DataSource.Employees;
        /*
         * How many female employees do we have?
         */

        int howManyEMployees = employees.Count(e => e.Gender == 'F');

        Console.WriteLine($"There are {howManyEMployees} female employees.");
    }

    public static void SickLeaveHours() {
        IEnumerable<Employee> employees = DataSource.Employees;

        //How many employees have less than 21 sick leave hours?

        int count = employees.Count(employee => employee.SickLeaveHours < 21);

        Console.WriteLine($"Number of employees with less than 21 sick leave hours: {count}");
    }
    public static void SumSyntax() {
        IEnumerable<Employee> employees = DataSource.Employees;
        IEnumerable<int> sickLeaveHours = employees.Select(e => e.SickLeaveHours);

        /*
         * How many sick leave hours did our office experience in total?
         */

        int totalSickLeaveHours = sickLeaveHours.Sum();

        Console.WriteLine($"The total of sick leave hours is {totalSickLeaveHours}");
    }

    public static void SumProjection() {
        IEnumerable<Employee> employees = DataSource.Employees;
        /*
         * how many sick leave hours in total? Use the Sum with a projection.
         */


        int totalSickLeaveHours = employees.Sum(e => e.SickLeaveHours);

        Console.WriteLine($"The total of sick leave hours is {totalSickLeaveHours}");
    }


    public static void MinSyntax() {
        IEnumerable<DicePlayer> players = DataSource.DicePlayers;

        IEnumerable<int> scores = from p in players
                                  from d in p.DiceRolls
                                  select d.FirstDice + d.SecondDice;

        /*
         * what's the lowest score?
         */

        int minScore = scores.Min();

        Console.WriteLine($"The minimum score is {minScore}");

    }

    public static void MinProjection() {
        IEnumerable<DicePlayer> players = DataHelper.DataSource.DicePlayers;

        IEnumerable<(int First, int Second)> scores = from p in players
                                                      from d in p.DiceRolls
                                                      select (First: d.FirstDice, Second: d.SecondDice);

        /*
         * what's the lowest score?
         */

        int minScore = scores.Min(d => d.First + d.Second);

        Console.WriteLine($"The minimum score is {minScore}");
    }

    public static void MinBySyntax() {
        IEnumerable<DicePlayer> players = DataSource.DicePlayers;

        var playersWithTotalScore = players.Select(p => new { p.Name, Total = p.DiceRolls.Sum(r => r.FirstDice + r.SecondDice) });

        /*
         * who's the player with the lowest score?
         */
        
        var playerWithMinScore = playersWithTotalScore.MinBy(p => p.Total);

        Console.WriteLine($"The player with the lowest score is {playerWithMinScore}");
    }

    public static void MaxSyntax() {
        IEnumerable<Building> buildings = DataSource.Buildings;
        IEnumerable<decimal> prices = buildings.Select(b => b.Price);

        /*
         * Find the maximum price for the buildings 
         */

        decimal maxPrice = prices.Max();

        Console.WriteLine($"The maximum price is {maxPrice}");
    }


    public static void MaxProjection() {
        IEnumerable<Building> buildings = DataSource.Buildings;
        IEnumerable<string> categories = buildings.Select(b => b.Category);

        /*
         * Find the building catgory with the longest name
         */

        int longestLength = categories.Max(w => w.Length);

        Console.WriteLine($"The longest category is {longestLength} characters long.");

    }

    public static void MaxBySyntax() {
        IEnumerable<DicePlayer> players = DataSource.DicePlayers;

        /*
         * who's the player with the lowest score?
         */

        DicePlayer? playerWithHighestScore = players.MaxBy(p => p.DiceRolls.Sum(r=>r.FirstDice + r.SecondDice));

        Console.WriteLine($"The player with the highest score is {playerWithHighestScore}");
    }

    public static void AverageSyntax() {
        IEnumerable<DicePlayer> players = DataSource.DicePlayers;
        IEnumerable<int> firstDices = from p in DataSource.DicePlayers
                                      from d in p.DiceRolls
                                      select d.FirstDice;
        IEnumerable<int> secondDices = from p in DataSource.DicePlayers
                                       from d in p.DiceRolls
                                       select d.SecondDice;
        IEnumerable<int> allDices = firstDices.Concat(secondDices);

        /*
         * What's the average rolled dice?
         */

        double averageNum = allDices.Average();

        Console.WriteLine($"The average rolled dice is {averageNum:N}.");
    }

    public static void AverageProjection() {
        IEnumerable<string> words = DataSource.RoyalTitleWords;

        double averageLength = words.Average(w => w.Length);

        Console.WriteLine($"The average word length is {averageLength} characters.");

    }

    public static void SeededAggregate() {
        /*
         * Your Bank Account starts with a balance of 100 Euros.
         * You try to withdraw 7 times
         * The withdraw succeeds only if your current balance is greater or equal to 
         * the amount to withdraw.
         * What is the final balance of the bank account?
         * Use the Aggregate function
         */

        double startBalance = 100.0;

        int[] attemptedWithdrawals = { 20, 10, 40, 50, 10, 70, 30 };

        double endBalance =
            attemptedWithdrawals.Aggregate(startBalance,
                (balance, nextWithdrawal) =>
                    ((nextWithdrawal <= balance) ? (balance - nextWithdrawal) : balance));

        Console.WriteLine($"Ending balance: {endBalance}");

    }

    public static void NestedCount() {
        IEnumerable<DicePlayer> players = DataSource.DicePlayers;

        /*
         * How many times did each player roll the dice?
         * List its name and the number of times he rolled a dice
         */

        var diceCounts = from p in players
                         select (p.Name, RollCount: p.DiceRolls.Count() * 2);

        foreach (var player in diceCounts) {
            Console.WriteLine($"Name: {player.Name}, count: {player.RollCount}");
        }
    }

}
