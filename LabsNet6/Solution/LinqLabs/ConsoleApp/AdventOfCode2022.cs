using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp {
    public class AdventOfCode2022 {
        //https://adventofcode.com/2022/day/1
        /*
         * --- Day 1: Calorie Counting ---
        Santa's reindeer typically eat regular reindeer food, but they need a lot of magical energy to deliver presents on Christmas. For that, their favorite snack is a special type of star fruit that only grows deep in the jungle. The Elves have brought you on their annual expedition to the grove where the fruit grows.

        To supply enough magical energy, the expedition needs to retrieve a minimum of fifty stars by December 25th. Although the Elves assure you that the grove has plenty of fruit, you decide to grab any fruit you see along the way, just in case.

        Collect stars by solving puzzles. Two puzzles will be made available on each day in the Advent calendar; the second puzzle is unlocked when you complete the first. Each puzzle grants one star. Good luck!

        The jungle must be too overgrown and difficult to navigate in vehicles or access from the air; the Elves' expedition traditionally goes on foot. As your boats approach land, the Elves begin taking inventory of their supplies. One important consideration is food - in particular, the number of Calories each Elf is carrying (your puzzle input).

        The Elves take turns writing down the number of Calories contained by the various meals, snacks, rations, etc. that they've brought with them, one item per line. Each Elf separates their own inventory from the previous Elf's inventory (if any) by a blank line.

        For example, suppose the Elves finish writing their items' Calories and end up with the following list:

        1000
        2000
        3000

        4000

        5000
        6000

        7000
        8000
        9000

        10000
        This list represents the Calories of the food carried by five Elves:

        The first Elf is carrying food with 1000, 2000, and 3000 Calories, a total of 6000 Calories.
        The second Elf is carrying one food item with 4000 Calories.
        The third Elf is carrying food with 5000 and 6000 Calories, a total of 11000 Calories.
        The fourth Elf is carrying food with 7000, 8000, and 9000 Calories, a total of 24000 Calories.
        The fifth Elf is carrying one food item with 10000 Calories.
        In case the Elves get hungry and need extra snacks, they need to know which Elf to ask: they'd like to know how many Calories are being carried by the Elf carrying the most Calories. In the example above, this is 24000 (carried by the fourth Elf).

        Find the Elf carrying the most Calories. How many total Calories is that Elf carrying?
         * */

        public static void Day01() {
            string input = $@"1000
2000
3000

4000

5000
6000

7000
8000
9000

10000";
            
            var caloriesForTopElves =
                from elf in input.Split(Environment.NewLine + Environment.NewLine)
                let calories = elf.Split(Environment.NewLine)
                                  .Select(int.Parse)
                                  .Sum()
                orderby calories descending
                select calories;
            
            var part1 = caloriesForTopElves.First();
            var part2 = caloriesForTopElves.Take(3).Sum();
            Console.WriteLine($"part1 = {part1}"); 
            Console.WriteLine($"part2 = {part2}");
        }

        //https://adventofcode.com/2022/day/6
        /*
         * --- Day 6: Tuning Trouble ---
        The preparations are finally complete; you and the Elves leave camp on foot and begin to make your way toward the star fruit grove.

        As you move through the dense undergrowth, one of the Elves gives you a handheld device. He says that it has many fancy features, but the most important one to set up right now is the communication system.

        However, because he's heard you have significant experience dealing with signal-based systems, he convinced the other Elves that it would be okay to give you their one malfunctioning device - surely you'll have no problem fixing it.

        As if inspired by comedic timing, the device emits a few colorful sparks.

        To be able to communicate with the Elves, the device needs to lock on to their signal. The signal is a series of seemingly-random characters that the device receives one at a time.

        To fix the communication system, you need to add a subroutine to the device that detects a start-of-packet marker in the datastream. In the protocol being used by the Elves, the start of a packet is indicated by a sequence of four characters that are all different.

        The device will send your subroutine a datastream buffer (your puzzle input); your subroutine needs to identify the first position where the four most recently received characters were all different. Specifically, it needs to report the number of characters from the beginning of the buffer to the end of the first such four-character marker.

        For example, suppose you receive the following datastream buffer:

        mjqjpqmgbljsphdztnvjfqwrcgsmlb
        After the first three characters (mjq) have been received, there haven't been enough characters received yet to find the marker. The first time a marker could occur is after the fourth character is received, making the most recent four characters mjqj. Because j is repeated, this isn't a marker.

        The first time a marker appears is after the seventh character arrives. Once it does, the last four characters received are jpqm, which are all different. In this case, your subroutine should report the value 7, because the first start-of-packet marker is complete after 7 characters have been processed.

        Here are a few more examples:

        bvwbjplbgvbhsrlpgdmjqwftvncz: first marker after character 5
        nppdvjthqldpwncqszvftbrmjlhg: first marker after character 6
        nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg: first marker after character 10
        zcfzfwzzqfrljwzlrfnpqdbhtmscgvjw: first marker after character 11
        How many characters need to be processed before the first start-of-packet marker is detected?
        */
        public static void Day06() {
            string input = "nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg";
            
            int part1 = GetStartMarker(4);
            int part2 = GetStartMarker(14);
            
            Console.WriteLine($"part 1 = {part1}");
            Console.WriteLine($"part 2 = {part2}");

            int GetStartMarker(int A) {
                return Enumerable.Range(A, input.Length - A)
                .First(i => input[(i - A)..i].Distinct().Count() == A);
            }
        }

    }
}
