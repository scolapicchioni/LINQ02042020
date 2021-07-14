namespace LinqBackgroundKnowledge.GenericsDemos {
    public class ArrayList {
        private object[] list = new object[10];
        private int counter = -1;
        public void Add(object item) {
            list[++counter] = item;
        }
        public object GetItemAt(int index) {
            return list[index];
        }
    }
}
