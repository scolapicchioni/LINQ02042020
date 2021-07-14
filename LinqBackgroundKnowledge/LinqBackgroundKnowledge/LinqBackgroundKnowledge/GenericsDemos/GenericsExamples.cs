using LinqBackgroundKnowledge.Models;

namespace LinqBackgroundKnowledge.GenericsDemos {
    public class GenericsExamples {
        // Back in my days, we had to use a collection that could contain anything.
        public static void Example01() {
            ArrayList list = new ArrayList();

            // This means that we had no compile time checking:
            // we could add anything we wanted
            list.Add(new Car());
            list.Add(1);
            list.Add("oh hi!");

            // And to get an item, we had to cast it and hope for the best
            ((Car)list.GetItemAt(0)).Price = 124;

        }

        public static void Example02() {
            // So some of us decided to write a bit more of code in order to have better compile time checks.
            // We had some code in a file and everytime we needed a specific collection,
            // we would take that code,
            // copy and past it
            // then search "object" and replace it with the type we wanted to work with
            ListOfCars list = new ListOfCars();

            list.Add(new Car());
            //list.Add(1); //this is not possible anymore
            //list.Add("oh hi!");

            list.GetItemAt(0).Price = 124; // we don't need a cast here

        }


        // This is auch a repetitive task that Microsoft has given us a language construct
        // to achieve the same result: generics
        public static void Example03() {
            // This can only work with cars
            GenericList<Car> list = new GenericList<Car>();

            list.Add(new Car());
            //list.Add(1);
            //list.Add("oh hi!");

            list.GetItemAt(0).Price = 124;

            // This can only work with int
            GenericList<int> numbers = new GenericList<int>();
            numbers.Add(1);
            int x = numbers.GetItemAt(0);

        }
    }
}
