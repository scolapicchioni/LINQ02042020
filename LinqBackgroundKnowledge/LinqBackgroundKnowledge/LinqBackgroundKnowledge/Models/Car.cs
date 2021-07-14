namespace LinqBackgroundKnowledge.Models {
    public class Car {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }

        public override string ToString() {
            return $"{Id} - {Name} - {Brand} - {Price:C0}";
        }
    }
}
