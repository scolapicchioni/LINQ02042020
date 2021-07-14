using LinqBackgroundKnowledge.Models;

namespace LinqBackgroundKnowledge.GenericsDemos {
    public class ListOfCars {
        private Car[] list = new Car[10];
        private int counter = -1;
        public void Add(Car item) {
            list[++counter] = item;
        }
        public Car GetItemAt(int index) {
            return list[index];
        }
    }
}
