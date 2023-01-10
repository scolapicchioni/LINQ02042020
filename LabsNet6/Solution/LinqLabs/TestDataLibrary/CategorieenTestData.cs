using System.Text.Json;
using InfoSupport.KC.FoodForThought.Shared.Core.Models;

namespace TestDataLibrary;

public static class CategorieenTestData
{
	public static IEnumerable<Categorie> GetMilliwaysCategories()
	{
		IEnumerable<Categorie> categories = new List<Categorie>() {
			new() { Naam = "Broodjes", Id = "broodjes", Extras = new[]{"komkommer", "tomaat" } },
			new() { Naam = "Crustico's", Id = "crusticos" },
			new() { Naam = "Lunch voor gasten", Id = "lunch-voor-gasten" },
			new() { Naam = "Patat", Id = "patat", Extras = new[]{ "mayonaise", "ketchup" } },
			new() { Naam = "Schotels", Id = "schotels", Extras = new[]{ "mosterd"} },
			new() { Naam = "Snacks", Id = "snacks", Extras = new[]{ "zout", "peper" } },
			new() { Naam = "Drankjes", Id = "drankjes"},
			new() { Naam = "Toetjes", Id = "toetjes"},
		};
		return categories;
	}
	public static IEnumerable<Categorie> GetFoodForThoughtCategories()
	{
		IEnumerable<Categorie> categories = new List<Categorie>() {
			new() { Naam = "Broodjes", Id = "broodjes", Extras = new[]{"komkommer", "tomaat" } },
			new() { Naam = "Snacks", Id = "snacks", Extras = new[]{ "zout", "peper" } },
			new() { Naam = "Drankjes", Id = "drankjes"},
			new() { Naam = "Toetjes", Id = "toetjes"},
		};
		return categories;
	}

	public static string GetMilliwaysCategoriesAsJson()
	{
		return JsonSerializer.Serialize(GetMilliwaysCategories());
	}
	public static string GetFoodForThoughtCategoriesAsJson()
	{
		return JsonSerializer.Serialize(GetFoodForThoughtCategories());
	}
}
