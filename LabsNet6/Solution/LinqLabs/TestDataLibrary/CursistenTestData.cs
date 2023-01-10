using InfoSupport.KC.FoodForThought.Shared.Core.Models;

namespace TestDataLibrary;

public static class CursistenTestData
{
	public static Cursist GetValidCursist() {
		return new Cursist() { Id = Guid.NewGuid(), Naam = "John Doe", Lokaal = "Cursuslokaal 4.14", Allergieen = "Noten" };
	}
}
