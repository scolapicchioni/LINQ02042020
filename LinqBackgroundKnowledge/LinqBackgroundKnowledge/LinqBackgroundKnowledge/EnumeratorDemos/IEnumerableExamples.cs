using System;
using System.Collections;
using System.Collections.Generic;

namespace LinqBackgroundKnowledge.EnumeratorDemos {
    public static class IEnumerableExamples {
        public static void Example01() {
            int[] numbers = new int[10] { 6, 2, 9, 4, 2, 6, 9, 5, 3, 3 };

            foreach (int item in numbers) {
                Console.WriteLine(item);
            }

            List<int> numbers2 = new() { 6, 2, 9, 4, 2, 6, 9, 5, 3, 3 };
            numbers2.Add(66);
            foreach (int item in numbers2) {
                Console.WriteLine(item);
            }

            Stack<int> numbers3 = new Stack<int>();
            numbers3.Push(6);
            numbers3.Push(2);
            numbers3.Push(9);
            numbers3.Push(4);
            numbers3.Push(2);

            foreach (int item in numbers3) {
                Console.WriteLine(item);
            }


        }


        public static void Example02() {
            ItalianDays days = new ItalianDays();

            Console.WriteLine("*********** foreach ***************");
            foreach (string item in days) {
                Console.WriteLine($"\tThe foreach has gotten the {item} item");
            }

            Console.WriteLine("*********** GetEnumerator ***************");
            IEnumerator daysEnumerator = days.GetEnumerator();
            Console.WriteLine("*********** While ***************");
            while (daysEnumerator.MoveNext()) {
                object item = daysEnumerator.Current;
                Console.WriteLine($"\twhile has gotten {item}");
            }
        }

        public static void Example03() {
            ItalianDaysYield days = new ItalianDaysYield();

            //Console.WriteLine("*********** foreach ***************");
            //foreach (string item in days) {
            //    Console.WriteLine($"\tThe foreach has gotten the {item} item");
            //}

            Console.WriteLine("*********** GetEnumerator ***************");
            IEnumerator daysEnumerator = days.GetEnumerator();
            Console.WriteLine("*********** While ***************");
            while (daysEnumerator.MoveNext()) {
                object item = daysEnumerator.Current;
                Console.WriteLine($"\twhile has gotten {item}");
            }
        }
    }
}
