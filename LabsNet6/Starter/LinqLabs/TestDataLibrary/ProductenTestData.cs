using System.Text.Json;
using InfoSupport.KC.FoodForThought.Shared.Core.Models;

namespace TestDataLibrary;

/// <summary>
/// Products used as Test Data
/// </summary>
public static class ProductenTestData
{
	/// <summary>
	/// Products From Milliways
	/// </summary>
	/// <returns>Products From Milliways</returns>
	public static IEnumerable<Product> GetMilliwaysProducts()
	{
		IEnumerable<Product> products = new List<Product>() {
			new(){ Id = "vlees-kroket", Naam = "Vlees kroket", Categorie = "snacks", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Omnivore, IsGlutenVrij=false },
			new(){ Id = "vlees-kroket-glutenvrij", Naam = "Vlees kroket Glutenvrij", Categorie = "snacks", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Omnivore, IsGlutenVrij=true },
			new(){ Id = "bal-gehakt", Naam = "Bal Gehakt", Categorie = "snacks", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Omnivore, IsGlutenVrij=false },
			new(){ Id = "bamischijf", Naam = "Bamischijf", Categorie = "snacks", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Vegan, IsGlutenVrij=false },

			new(){ Id = "dobben-kroket", Naam = "Dobben kroket", Categorie = "snacks", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Omnivore, IsGlutenVrij=false},
			new(){ Id = "berenhap", Naam = "Berenhap", Categorie = "snacks", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Omnivore, IsGlutenVrij=false},
			new(){ Id = "bamischijf-orieentaal", Naam = "Bamischijf Orieentaal", Categorie = "snacks", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Vegan, IsGlutenVrij=false },

			new(){ Id = "goulash-kroket", Naam = "Goulash Kroket", Categorie = "snacks", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Omnivore, IsGlutenVrij=false },
			new(){ Id = "berenhap-speciaal", Naam = "Berenhap Speciaal", Categorie = "snacks", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Omnivore, IsGlutenVrij=false },
			new(){ Id = "kaassouffle", Naam = "Kaassouffle", Categorie = "snacks", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Vegetarian, IsGlutenVrij=false },
			new(){ Id = "kaassouffle-glutenvrij", Naam = "Kaassouffle Glutenvrij", Categorie = "snacks", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Vegetarian, IsGlutenVrij=true },

			new(){ Id = "kalfs-kroket", Naam = "Kalfs Kroket", Categorie = "snacks", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Omnivore, IsGlutenVrij=false },
			new(){ Id = "frikandel", Naam = "Frikandel", Categorie = "snacks", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Omnivore, IsGlutenVrij=false },
			new(){ Id = "frikandel-glutenvrij", Naam = "Frikandel Glutenvrij", Categorie = "snacks", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Omnivore, IsGlutenVrij=true },
			new(){ Id = "ham-kaassouffle", Naam = "Ham/Kaassouffle", Categorie = "snacks", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Omnivore, IsGlutenVrij=false },

			new(){ Id = "groente-kroket", Naam = "Groente kroket", Categorie = "snacks", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Vegan, IsGlutenVrij=false },
			new(){ Id = "sitostick", Naam = "Sitostick", Categorie = "snacks", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Omnivore, IsGlutenVrij=false },
			new(){ Id = "knackworst", Naam = "Knackworst", Categorie = "snacks", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Omnivore, IsGlutenVrij=false },
			new(){ Id = "kipnuggets", Naam = "Kipnuggets", Categorie = "snacks", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Omnivore, IsGlutenVrij=false },

			new(){ Id = "extra-snack-1", Naam = "Extra Snack 1", Categorie = "snacks", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Omnivore, IsGlutenVrij=false},
			new(){ Id = "extra-snack-2", Naam = "Extra Snack 2", Categorie = "snacks", Leverancier = "de-molen", IsGeschiktVoor = "pescetarier", IsGlutenVrij=true},


			new(){ Id = "jonge-kaas", Naam = "Jonge Kaas", Categorie = "broodjes", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Vegetarian, IsGlutenVrij=false, SoortenBrood=new[]{ "pistolet-bruin", "pistolet-wit", "waldkornbroodje" , "wit-broodje", "bruin-broodje" } },
			new(){ Id = "oude-kaas", Naam = "Oude Kaas", Categorie = "broodjes", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Vegetarian, IsGlutenVrij=false, SoortenBrood=new[]{ "pistolet-bruin", "pistolet-wit", "waldkornbroodje" , "wit-broodje", "bruin-broodje" } },
			new(){ Id = "ham", Naam = "Ham", Categorie = "broodjes", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Omnivore, IsGlutenVrij=false, SoortenBrood=new[]{ "pistolet-bruin", "pistolet-wit", "waldkornbroodje" , "wit-broodje", "bruin-broodje" } },
			new(){ Id = "ham-kaas", Naam = "Ham Kaas", Categorie = "broodjes", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Omnivore, IsGlutenVrij=false, SoortenBrood=new[]{ "pistolet-bruin", "pistolet-wit", "waldkornbroodje" , "wit-broodje", "bruin-broodje" } },
			new(){ Id = "gezond", Naam = "Gezond", Categorie = "broodjes", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Omnivore, IsGlutenVrij=false, SoortenBrood=new[]{ "pistolet-bruin", "pistolet-wit", "waldkornbroodje" , "wit-broodje", "bruin-broodje" } },
			new(){ Id = "kipfilet", Naam = "Kipfilet", Categorie = "broodjes", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Omnivore, IsGlutenVrij=false, SoortenBrood=new[]{ "pistolet-bruin", "pistolet-wit", "waldkornbroodje" , "wit-broodje", "bruin-broodje" } },
			new(){ Id = "fricandeau", Naam = "Fricandeau", Categorie = "broodjes", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Omnivore, IsGlutenVrij=false, SoortenBrood=new[]{ "pistolet-bruin", "pistolet-wit", "waldkornbroodje" , "wit-broodje", "bruin-broodje" } },
			new(){ Id = "rosbief", Naam = "Rosbief", Categorie = "broodjes", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Omnivore, IsGlutenVrij=false, SoortenBrood=new[]{ "pistolet-bruin", "pistolet-wit", "waldkornbroodje" , "wit-broodje", "bruin-broodje" } },
			new(){ Id = "salami", Naam = "Salami", Categorie = "broodjes", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Omnivore, IsGlutenVrij=false, SoortenBrood=new[]{ "pistolet-bruin", "pistolet-wit", "waldkornbroodje" , "wit-broodje", "bruin-broodje" } },
			new(){ Id = "roombrie", Naam = "Roombrie", Categorie = "broodjes", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Vegetarian, IsGlutenVrij=false, SoortenBrood=new[]{ "pistolet-bruin", "pistolet-wit", "waldkornbroodje" , "wit-broodje", "bruin-broodje" } },
			new(){ Id = "roomkaas", Naam = "Roomkaas", Categorie = "broodjes", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Vegetarian, IsGlutenVrij=false, SoortenBrood=new[]{ "pistolet-bruin", "pistolet-wit", "waldkornbroodje" , "wit-broodje", "bruin-broodje" } },
			new(){ Id = "filet-american", Naam = "Filet American", Categorie = "broodjes", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Omnivore, IsGlutenVrij=false, SoortenBrood=new[]{ "pistolet-bruin", "pistolet-wit", "waldkornbroodje" , "wit-broodje", "bruin-broodje" } },
			new(){ Id = "filet-american-speciaal", Naam = "Filet American", Categorie = "broodjes", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Omnivore, IsGlutenVrij=false, SoortenBrood=new[]{ "pistolet-bruin", "pistolet-wit", "waldkornbroodje" , "wit-broodje", "bruin-broodje" } },

			new(){ Id = "eiersalade", Naam = "Eiersalade", Categorie = "broodjes", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Omnivore, IsGlutenVrij=false, SoortenBrood=new[]{ "pistolet-bruin", "pistolet-wit", "waldkornbroodje" , "wit-broodje", "bruin-broodje" } },
			new(){ Id = "kip-kerrie-salade", Naam = "Kip Kerrie Salade", Categorie = "broodjes", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Omnivore, IsGlutenVrij=false, SoortenBrood=new[]{ "pistolet-bruin", "pistolet-wit", "waldkornbroodje" , "wit-broodje", "bruin-broodje" } },
			new(){ Id = "zalmsalade", Naam = "Zalmsalade", Categorie = "broodjes", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Omnivore, IsGlutenVrij=false, SoortenBrood=new[]{ "pistolet-bruin", "pistolet-wit", "waldkornbroodje" , "wit-broodje", "bruin-broodje" } },
			new(){ Id = "tonijnsalade", Naam = "Tonijnsalade", Categorie = "broodjes", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Omnivore, IsGlutenVrij=false, SoortenBrood=new[]{ "pistolet-bruin", "pistolet-wit", "waldkornbroodje" , "wit-broodje", "bruin-broodje" } },

			new(){ Id = "extra-broodje-1", Naam = "Extra Broodje 1", Categorie = "broodjes", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Vegetarian, IsGlutenVrij=false, SoortenBrood=new[]{ "pistolet-bruin", "pistolet-wit", "waldkornbroodje" , "wit-broodje", "bruin-broodje" } },
			new(){ Id = "extra-broodje-2", Naam = "Extra Broodje 2", Categorie = "broodjes", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Vegetarian, IsGlutenVrij=false, SoortenBrood=new[]{ "pistolet-bruin", "pistolet-wit", "waldkornbroodje" , "wit-broodje", "bruin-broodje" } },

			new(){ Id = "lunch-voor-gasten-1", Naam = "Lunch Voor Gasten 1", Categorie = "lunch-voor-gasten", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Vegetarian, IsGlutenVrij=false },
			new(){ Id = "lunch-voor-gasten-2", Naam = "Lunch Voor Gasten 2", Categorie = "lunch-voor-gasten", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Vegetarian, IsGlutenVrij=false },

			new(){ Id = "crustico-1", Naam = "Crustico 1", Categorie = "crusticos", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Vegetarian, IsGlutenVrij=false },
			new(){ Id = "crustico-2", Naam = "Crustico 2", Categorie = "crusticos", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Vegetarian, IsGlutenVrij=false },

			new(){ Id = "patat-1", Naam = "Patat 1", Categorie = "patat", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Vegetarian, IsGlutenVrij=true },
			new(){ Id = "patat-2", Naam = "Patat 2", Categorie = "patat", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Omnivore, IsGlutenVrij=false},

			//Schotels
			new(){ Id = "schotels-1", Naam = "Schotels 1", Categorie = "schotels", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Omnivore, IsGlutenVrij=false},
			new(){ Id = "schotels-2", Naam = "Schotels 2", Categorie = "schotels", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Omnivore, IsGlutenVrij=false},

			new(){ Id = "melk", Naam = "Melk", Categorie = "drankjes", Leverancier = "infosupport", IsGeschiktVoor = GeschiktVoor.Vegetarian, IsGlutenVrij=true},
			new(){ Id = "karnemelk", Naam = "Karnemelk", Categorie = "drankjes", Leverancier = "infosupport", IsGeschiktVoor = GeschiktVoor.Vegetarian, IsGlutenVrij=true},

			new(){ Id = "yoghurtje-rode-vruchten", Naam = "Yoghurtje Rode Vruchten", Categorie = "toetjes", Leverancier = "infosupport", IsGeschiktVoor = GeschiktVoor.Vegetarian, IsGlutenVrij=true},
			new(){ Id = "yoghurtje-tropische-vruchten", Naam = "Yoghurtje Tropische Vruchten", Categorie = "toetjes", Leverancier = "infosupport", IsGeschiktVoor = GeschiktVoor.Vegetarian, IsGlutenVrij=true},

		};
		return products;
	}
	/// <summary>
	/// Products From Food For Thought
	/// </summary>
	/// <returns>Products From Food For Thought</returns>
	public static IEnumerable<Product> GetFoodForThoughtProducts()
	{
		IEnumerable<Product> products = new List<Product>() {
			new(){ Id = "vlees-kroket", Naam = "Vlees kroket", Categorie = "snacks", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Omnivore, IsGlutenVrij=false },
			new(){ Id = "vlees-kroket-glutenvrij", Naam = "Vlees kroket Glutenvrij", Categorie = "snacks", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Omnivore, IsGlutenVrij=true },
			new(){ Id = "bal-gehakt", Naam = "Bal Gehakt", Categorie = "snacks", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Omnivore, IsGlutenVrij=false },
			new(){ Id = "bamischijf", Naam = "Bamischijf", Categorie = "snacks", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Vegan, IsGlutenVrij=false },

			new(){ Id = "dobben-kroket", Naam = "Dobben kroket", Categorie = "snacks", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Omnivore, IsGlutenVrij=false},
			new(){ Id = "berenhap", Naam = "Berenhap", Categorie = "snacks", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Omnivore, IsGlutenVrij=false},
			new(){ Id = "bamischijf-orieentaal", Naam = "Bamischijf Orieentaal", Categorie = "snacks", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Vegan, IsGlutenVrij=false },

			new(){ Id = "goulash-kroket", Naam = "Goulash Kroket", Categorie = "snacks", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Omnivore, IsGlutenVrij=false },
			new(){ Id = "berenhap-speciaal", Naam = "Berenhap Speciaal", Categorie = "snacks", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Omnivore, IsGlutenVrij=false },
			new(){ Id = "kaassouffle", Naam = "Kaassouffle", Categorie = "snacks", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Vegetarian, IsGlutenVrij=false },
			new(){ Id = "kaassouffle-glutenvrij", Naam = "Kaassouffle Glutenvrij", Categorie = "snacks", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Vegetarian, IsGlutenVrij=true },

			new(){ Id = "kalfs-kroket", Naam = "Kalfs Kroket", Categorie = "snacks", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Omnivore, IsGlutenVrij=false },
			new(){ Id = "frikandel", Naam = "Frikandel", Categorie = "snacks", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Omnivore, IsGlutenVrij=false },
			new(){ Id = "frikandel-glutenvrij", Naam = "Frikandel Glutenvrij", Categorie = "snacks", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Omnivore, IsGlutenVrij=true },
			new(){ Id = "ham-kaassouffle", Naam = "Ham/Kaassouffle", Categorie = "snacks", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Omnivore, IsGlutenVrij=false },

			new(){ Id = "groente-kroket", Naam = "Groente kroket", Categorie = "snacks", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Vegan, IsGlutenVrij=false },
			new(){ Id = "sitostick", Naam = "Sitostick", Categorie = "snacks", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Omnivore, IsGlutenVrij=false },
			new(){ Id = "knackworst", Naam = "Knackworst", Categorie = "snacks", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Omnivore, IsGlutenVrij=false },
			new(){ Id = "kipnuggets", Naam = "Kipnuggets", Categorie = "snacks", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Omnivore, IsGlutenVrij=false },

			new(){ Id = "jonge-kaas", Naam = "Jonge Kaas", Categorie = "broodjes", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Vegetarian, IsGlutenVrij=false, SoortenBrood=new[]{ "pistolet-bruin", "pistolet-wit", "waldkornbroodje" , "wit-broodje", "bruin-broodje" } },
			new(){ Id = "oude-kaas", Naam = "Oude Kaas", Categorie = "broodjes", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Vegetarian, IsGlutenVrij=false, SoortenBrood=new[]{ "pistolet-bruin", "pistolet-wit", "waldkornbroodje" , "wit-broodje", "bruin-broodje" } },
			new(){ Id = "ham", Naam = "Ham", Categorie = "broodjes", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Omnivore, IsGlutenVrij=false, SoortenBrood=new[]{ "pistolet-bruin", "pistolet-wit", "waldkornbroodje" , "wit-broodje", "bruin-broodje" } },
			new(){ Id = "ham-kaas", Naam = "Ham Kaas", Categorie = "broodjes", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Omnivore, IsGlutenVrij=false, SoortenBrood=new[]{ "pistolet-bruin", "pistolet-wit", "waldkornbroodje" , "wit-broodje", "bruin-broodje" } },
			new(){ Id = "gezond", Naam = "Gezond", Categorie = "broodjes", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Omnivore, IsGlutenVrij=false, SoortenBrood=new[]{ "pistolet-bruin", "pistolet-wit", "waldkornbroodje" , "wit-broodje", "bruin-broodje" } },
			new(){ Id = "kipfilet", Naam = "Kipfilet", Categorie = "broodjes", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Omnivore, IsGlutenVrij=false, SoortenBrood=new[]{ "pistolet-bruin", "pistolet-wit", "waldkornbroodje" , "wit-broodje", "bruin-broodje" } },
			new(){ Id = "fricandeau", Naam = "Fricandeau", Categorie = "broodjes", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Omnivore, IsGlutenVrij=false, SoortenBrood=new[]{ "pistolet-bruin", "pistolet-wit", "waldkornbroodje" , "wit-broodje", "bruin-broodje" } },
			new(){ Id = "rosbief", Naam = "Rosbief", Categorie = "broodjes", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Omnivore, IsGlutenVrij=false, SoortenBrood=new[]{ "pistolet-bruin", "pistolet-wit", "waldkornbroodje" , "wit-broodje", "bruin-broodje" } },
			new(){ Id = "salami", Naam = "Salami", Categorie = "broodjes", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Omnivore, IsGlutenVrij=false, SoortenBrood=new[]{ "pistolet-bruin", "pistolet-wit", "waldkornbroodje" , "wit-broodje", "bruin-broodje" } },
			new(){ Id = "roombrie", Naam = "Roombrie", Categorie = "broodjes", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Vegetarian, IsGlutenVrij=false, SoortenBrood=new[]{ "pistolet-bruin", "pistolet-wit", "waldkornbroodje" , "wit-broodje", "bruin-broodje" } },
			new(){ Id = "roomkaas", Naam = "Roomkaas", Categorie = "broodjes", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Vegetarian, IsGlutenVrij=false, SoortenBrood=new[]{ "pistolet-bruin", "pistolet-wit", "waldkornbroodje" , "wit-broodje", "bruin-broodje" } },
			new(){ Id = "filet-american", Naam = "Filet American", Categorie = "broodjes", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Omnivore, IsGlutenVrij=false, SoortenBrood=new[]{ "pistolet-bruin", "pistolet-wit", "waldkornbroodje" , "wit-broodje", "bruin-broodje" } },
			new(){ Id = "filet-american-speciaal", Naam = "Filet American", Categorie = "broodjes", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Omnivore, IsGlutenVrij=false, SoortenBrood=new[]{ "pistolet-bruin", "pistolet-wit", "waldkornbroodje" , "wit-broodje", "bruin-broodje" } },
			new(){ Id = "eiersalade", Naam = "Eiersalade", Categorie = "broodjes", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Omnivore, IsGlutenVrij=false, SoortenBrood=new[]{ "pistolet-bruin", "pistolet-wit", "waldkornbroodje" , "wit-broodje", "bruin-broodje" } },
			new(){ Id = "kip-kerrie-salade", Naam = "Kip Kerrie Salade", Categorie = "broodjes", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Omnivore, IsGlutenVrij=false, SoortenBrood=new[]{ "pistolet-bruin", "pistolet-wit", "waldkornbroodje" , "wit-broodje", "bruin-broodje" } },
			new(){ Id = "zalmsalade", Naam = "Zalmsalade", Categorie = "broodjes", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Omnivore, IsGlutenVrij=false, SoortenBrood=new[]{ "pistolet-bruin", "pistolet-wit", "waldkornbroodje" , "wit-broodje", "bruin-broodje" } },
			new(){ Id = "tonijnsalade", Naam = "Tonijnsalade", Categorie = "broodjes", Leverancier = "supersnacks", IsGeschiktVoor = GeschiktVoor.Omnivore, IsGlutenVrij=false, SoortenBrood=new[]{ "pistolet-bruin", "pistolet-wit", "waldkornbroodje" , "wit-broodje", "bruin-broodje" } },

			new(){ Id = "melk", Naam = "Melk", Categorie = "drankjes", Leverancier = "infosupport", IsGeschiktVoor = GeschiktVoor.Vegetarian, IsGlutenVrij=true},
			new(){ Id = "karnemelk", Naam = "Karnemelk", Categorie = "drankjes", Leverancier = "infosupport", IsGeschiktVoor = GeschiktVoor.Vegetarian, IsGlutenVrij=true},

			new(){ Id = "yoghurtje-rode-vruchten", Naam = "Yoghurtje Rode Vruchten", Categorie = "toetjes", Leverancier = "infosupport", IsGeschiktVoor = GeschiktVoor.Vegetarian, IsGlutenVrij=true},
			new(){ Id = "yoghurtje-tropische-vruchten", Naam = "Yoghurtje Tropische Vruchten", Categorie = "toetjes", Leverancier = "infosupport", IsGeschiktVoor = GeschiktVoor.Vegetarian, IsGlutenVrij=true},

		};
		return products;
	}
	/// <summary>
	/// List of all ProductId that our students may order
	/// </summary>
	/// <returns>List of all ProductId that our students may order</returns>
	public static IEnumerable<string> GetAllowedProductIds()
	{
		IEnumerable<string> allowedProducts = new[] {
			//drankjes
			"melk", "karnemelk",
			//toetjes
			"yoghurtje-rode-vruchten", "yoghurtje-tropische-vruchten",
			//snacks
			"vlees-kroket", "vlees-kroket-glutenvrij", "bal-gehakt", "bamischijf",
			"dobben-kroket", "berenhap", "bamischijf-orieentaal",
			"goulash-kroket", "berenhap-speciaal", "kaassouffle", "kaassouffle-glutenvrij",
			"kalfs-kroket", "frikandel", "frikandel-glutenvrij", "ham-kaassouffle",
			"groente-kroket", "sitostick", "knackworst", "kipnuggets",
			//broodjes
			"jonge-kaas", "oude-kaas", "ham", "ham-kaas", "gezond", "kipfilet", "fricandeau", "rosbief", "salami", "roombrie",
			"roomkaas", "filet-american", "filet-american-speciaal", "eiersalade", "kip-kerrie-salade", "zalmsalade", "tonijnsalade"
		};
		return allowedProducts;
	}
	/// <summary>
	/// Products from Milliways, serialized using System.Text.JsonSerializer
	/// </summary>
	/// <returns>Products from Milliways, serialized using System.Text.JsonSerializer</returns>

	public static string GetMilliwaysProductsAsJson()
	{
		return JsonSerializer.Serialize(GetMilliwaysProducts());
	}
	/// <summary>
	/// Products from Food For Thought, serialized using System.Text.JsonSerializer
	/// </summary>
	/// <returns>Products from Food For Thought, serialized using System.Text.JsonSerializer</returns>
	public static string GetFoodForThoughtProductsAsJson()
	{
		return JsonSerializer.Serialize(GetFoodForThoughtProducts());
	}
	/// <summary>
	/// Products Ids our students may order, serialized using System.Text.JsonSerializer
	/// </summary>
	/// <returns>Products Ids our students may order, serialized using System.Text.JsonSerializer</returns>
	public static string GetAllowedProductIdsAsJson()
	{
		return JsonSerializer.Serialize(GetAllowedProductIds());
	}

	/// <summary>
	/// Get The Product Vlees Kroket, which is a snack
	/// </summary>
	/// <returns>Vlees Kroket Snack Product</returns>
	public static Product GetVleesKroket() {
		return GetFoodForThoughtProducts().First(p => p.Id == "vlees-kroket");
	}

	/// <summary>
	/// Get The Product Jonge Kaas, which is a sandwich
	/// </summary>
	/// <returns>Jonge Kaas Broodje Product</returns>
	public static Product GetJongeKaas()
	{
		return GetFoodForThoughtProducts().First(p => p.Id == "jonge-kaas");
	}
}
