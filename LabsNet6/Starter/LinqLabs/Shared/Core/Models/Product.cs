namespace InfoSupport.KC.FoodForThought.Shared.Core.Models;

public class Product
{
	public string Id { get; set; } = string.Empty;
	public string Naam { get; set; } = string.Empty;
	public string Categorie { get; set; } = string.Empty;
	public string Leverancier { get; set; } = string.Empty;
	public bool IsGlutenVrij { get; set; }
	public string IsGeschiktVoor { get; set; } = string.Empty;
	public string[]? SoortenBrood { get; set; } 
}

