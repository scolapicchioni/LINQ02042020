using System;
using System.Collections;

namespace LinqBackgroundKnowledge.EnumeratorDemos {
    public class ItalianDaysYield : IEnumerable {
        private string day1 = "lunedi";
        private string day2 = "martedi";
        private string day3 = "mercoledi";
        private string day4 = "giovedi";
        private string day5 = "venerdi";
        private string day6 = "sabato";
        private string day7 = "domenica";

        public IEnumerator GetEnumerator() {
            Console.WriteLine($"GetEnumerator has been called. going to return {day1}");
            yield return day1;
            Console.WriteLine($"just returned {day1}");
            yield return day2;
            Console.WriteLine($"just returned {day2}");
            yield return day3;
            Console.WriteLine($"just returned {day3}");
            yield return day4;
            Console.WriteLine($"just returned {day4}");
            yield return day5;
            Console.WriteLine($"just returned {day5}");
            yield return day6;
            Console.WriteLine($"just returned {day6}");
            yield return day7;
            Console.WriteLine($"just returned {day7} - bye!");
        }
    }
}
