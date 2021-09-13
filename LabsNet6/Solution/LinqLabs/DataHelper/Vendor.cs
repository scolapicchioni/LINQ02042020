namespace DataHelper;

public class Vendor {
    public int ID { get; set; }
    public string Name { get; set; } = string.Empty;

    public override string ToString() => $"{ID} - {Name}";
}
