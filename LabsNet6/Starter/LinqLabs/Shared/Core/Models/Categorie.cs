namespace InfoSupport.KC.FoodForThought.Shared.Core.Models;

public class Categorie
{
	public string Id { get; set; } = string.Empty;
	public string Naam { get; set; } = string.Empty;
	public string[] Extras { get; set; } = Array.Empty<string>();
}

