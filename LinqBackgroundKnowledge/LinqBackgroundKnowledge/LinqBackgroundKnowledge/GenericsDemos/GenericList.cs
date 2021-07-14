namespace LinqBackgroundKnowledge.GenericsDemos {
    //TheTypeOfTheItem is just a placeholder that will be replaced by the compiler
    public class GenericList<TheTypeOfTheItem> {
        private TheTypeOfTheItem[] list = new TheTypeOfTheItem[10];
        private int counter = -1;
        public void Add(TheTypeOfTheItem item) {
            list[++counter] = item;
        }
        public TheTypeOfTheItem GetItemAt(int index) {
            return list[index];
        }
    }
}
