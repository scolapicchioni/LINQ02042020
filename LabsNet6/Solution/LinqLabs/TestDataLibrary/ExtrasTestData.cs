using System.Text.Json;
using InfoSupport.KC.FoodForThought.Shared.Core.Models;

namespace TestDataLibrary;

public static class ExtrasTestData
{
	public static IEnumerable<Product> GetMilliwaysExtras()
	{
		IEnumerable<Product> result = new List<Product>() {
			new () { Naam = "Curry", Id = "curry", IsGeschiktVoor = GeschiktVoor.Vegan, IsGlutenVrij=true },
			new () { Naam = "Gesmolten", Id = "gesmolten", IsGeschiktVoor = GeschiktVoor.Vegetarian, IsGlutenVrij=true },
			new () { Naam = "Ketchup", Id = "ketchup", IsGeschiktVoor = GeschiktVoor.Vegan, IsGlutenVrij=true },
			new () { Naam = "Komkommer", Id = "komkommer", IsGeschiktVoor = GeschiktVoor.Vegan, IsGlutenVrij=true },
			new () { Naam = "Mayonaise", Id = "mayonaise", IsGeschiktVoor = GeschiktVoor.Omnivore, IsGlutenVrij=true },
			new () { Naam = "Melk", Id = "melk", IsGeschiktVoor = GeschiktVoor.Vegetarian, IsGlutenVrij=true },
			new () { Naam = "Mosterd", Id = "mosterd", IsGeschiktVoor = GeschiktVoor.Vegan, IsGlutenVrij=true },
			new () { Naam = "Peper", Id = "peper", IsGeschiktVoor = GeschiktVoor.Vegan, IsGlutenVrij=true },
			new () { Naam = "Pindasaus", Id = "pindasaus", IsGeschiktVoor = GeschiktVoor.Vegan, IsGlutenVrij=true },
			new () { Naam = "Tomaat", Id = "tomaat", IsGeschiktVoor = GeschiktVoor.Vegan, IsGlutenVrij=true },
			new () { Naam = "Zout", Id = "zout", IsGeschiktVoor = GeschiktVoor.Vegan, IsGlutenVrij=true }
		};
		return result;
	}

	public static IEnumerable<Product> GetFoodForThoughtExtras()
	{
		IEnumerable<Product> result = new List<Product>() {
			new () { Naam = "Komkommer", Id = "komkommer", IsGeschiktVoor = GeschiktVoor.Vegan, IsGlutenVrij=true },
			new () { Naam = "Peper", Id = "peper", IsGeschiktVoor = GeschiktVoor.Vegan, IsGlutenVrij=true },
			new () { Naam = "Tomaat", Id = "tomaat", IsGeschiktVoor = GeschiktVoor.Vegan, IsGlutenVrij=true },
			new () { Naam = "Zout", Id = "zout", IsGeschiktVoor = GeschiktVoor.Vegan, IsGlutenVrij=true }
		};
		return result;
	}

	public static IEnumerable<Product> GetMilliwaysSoortenBrood()
	{
		IEnumerable<Product> result = new List<Product>() {
			new(){Naam = "Bruin Broodje", Id = "bruin-broodje", IsGeschiktVoor = GeschiktVoor.Vegan, IsGlutenVrij=false },
			new(){Naam = "Chiabatta", Id = "chiabatta", IsGeschiktVoor = GeschiktVoor.Vegan, IsGlutenVrij=false },
			new(){Naam = "Pistolet bruin", Id = "pistolet-bruin", IsGeschiktVoor = GeschiktVoor.Vegan, IsGlutenVrij=false },
			new(){Naam = "Pistolet wit", Id = "pistolet-wit", IsGeschiktVoor = GeschiktVoor.Vegan, IsGlutenVrij=false },
			new(){Naam = "Stokbrood bruin", Id = "stokbrood-bruin", IsGeschiktVoor = GeschiktVoor.Vegan, IsGlutenVrij=false },
			new(){Naam = "Stokbrood wit", Id = "stokbrood-wit", IsGeschiktVoor = GeschiktVoor.Vegan, IsGlutenVrij=false },
			new(){Naam = "Waldkornbroodje", Id = "waldkornbroodje", IsGeschiktVoor = GeschiktVoor.Vegan, IsGlutenVrij=false },
			new(){Naam = "Wit broodje", Id = "wit-broodje", IsGeschiktVoor = GeschiktVoor.Vegan, IsGlutenVrij=false },
			new(){Naam = "Zachte bol bruin", Id = "zachte-bol-bruin", IsGeschiktVoor = GeschiktVoor.Vegan, IsGlutenVrij=false },
			new(){Naam = "Zachte bol wit", Id = "zachte-bol-wit", IsGeschiktVoor = GeschiktVoor.Vegan, IsGlutenVrij=false },
		};
		return result;
	}

	public static IEnumerable<Product> GetFoodForThoughtSoortenBrood()
	{
		IEnumerable<Product> result = new List<Product>() {
			new(){Naam = "Bruin Broodje", Id = "bruin-broodje", IsGeschiktVoor = "veganist", IsGlutenVrij=false },
			new(){Naam = "Pistolet bruin", Id = "pistolet-bruin", IsGeschiktVoor = "veganist", IsGlutenVrij=false },
			new(){Naam = "Pistolet wit", Id = "pistolet-wit", IsGeschiktVoor = "veganist", IsGlutenVrij=false },
			new(){Naam = "Waldkornbroodje", Id = "waldkornbroodje", IsGeschiktVoor = "veganist", IsGlutenVrij=false },
			new(){Naam = "Wit broodje", Id = "wit-broodje", IsGeschiktVoor = "veganist", IsGlutenVrij=false }
		};
		return result;
	}

	public static string GetMilliwaysExtrasAsJson()
	{
		return JsonSerializer.Serialize(GetMilliwaysExtras());
	}

	public static string GetFoodForThoughtExtrasAsJson()
	{
		return JsonSerializer.Serialize(GetFoodForThoughtExtras());
	}

	public static string GetMilliwaysSoortenBroodAsJson()
	{
		return JsonSerializer.Serialize(GetMilliwaysSoortenBrood());
	}

	public static string GetFoodForThoughtSoortenBroodAsJson()
	{
		return JsonSerializer.Serialize(GetFoodForThoughtSoortenBrood());
	}
}
