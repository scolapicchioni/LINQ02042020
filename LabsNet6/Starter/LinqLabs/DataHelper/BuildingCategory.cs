namespace DataHelper;

public class BuildingCategory {
    public string Category { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public override string ToString() => $"{Category} - {Description}";
}
