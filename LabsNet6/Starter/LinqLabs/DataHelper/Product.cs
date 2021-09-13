namespace DataHelper;

public class Product {
    public int ID { get; set; }
    public string Name { get; set; } = string.Empty;

    public override string ToString() => $"{ID} - {Name}";
}
