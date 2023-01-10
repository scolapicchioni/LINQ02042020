using System.Text.Json;
using InfoSupport.KC.FoodForThought.Shared.Core.Models;

namespace TestDataLibrary;

public class BestellingenTestData
{
	public static Bestelling GetValidBestellingVoorCursist(Guid cursistId)
	{
		return new Bestelling()
		{
			Cursist = new Cursist() { Id = cursistId, Naam = "Nico Jansen", Lokaal = "Lokaal 1", Allergieen = "pinda's!" },
			//Datum = DateTime.Now.Date.AddHours(9),
			Datum = DateOnly.FromDateTime(DateTime.Now),
			Id = Guid.Parse("6C02DF87-8B02-4BD0-8537-0A004CB5D6B4"),
			Bestelregels = new Bestelregel[] {
				GetFullBestelRegelForJongeKaas(),
				GetFullBestelRegelForVleesKroket()
			}
		};
	}

	public static string GetValidBestellingVoorCursistAsJson(Guid cursistId)
	{
		return JsonSerializer.Serialize(GetValidBestellingVoorCursist(cursistId));
	}

	public static Bestelregel GetNewBestelregelForJongeKaas()
	{
		return new Bestelregel() { Id = Guid.Parse("2652A743-8BD7-455B-833B-B6D44DADC824"), Product = "jonge-kaas", Aantal = 1, Brood = string.Empty, Extras = Array.Empty<string>(), Opmerkingen = string.Empty };
	}
	public static Bestelregel GetFullBestelRegelForJongeKaas()
	{
		return new Bestelregel() { Id = Guid.Parse("37A07D1A-353C-469B-BBFF-7B77F570C6E2"), Product = "jonge-kaas", Aantal = 5, Brood = "bruin-broodje", Extras = new string[] { "komkommer" }, Opmerkingen = "no mayo!" };
	}
	public static Bestelregel GetNewBestelRegelForVleesKroket()
	{
		return new Bestelregel() { Id = Guid.Parse("B415DC22-76C9-4387-9994-2006F447AFD3"), Product = "vlees-kroket", Aantal = 1, Brood = string.Empty, Extras = Array.Empty<string>(), Opmerkingen = string.Empty };
	}
	public static Bestelregel GetFullBestelRegelForVleesKroket()
	{
		return new Bestelregel() { Id = Guid.Parse("FA8E1CAF-2DEA-44D9-9EB0-43219406FB8C"), Product = "vlees-kroket", Aantal = 3, Brood = string.Empty, Extras = new string[] { "zout" }, Opmerkingen = "I SAID no mayo!" };
	}
	public static Bestelregel GetNewBestelregelForMelk()
	{
		return new Bestelregel() { Id = Guid.Parse("8F9C1B92-14FD-4C18-A5FF-ED4B7FE78571"), Product = "melk", Aantal = 1, Brood = string.Empty, Extras = Array.Empty<string>(), Opmerkingen = string.Empty };
	}
	public static Bestelregel GetFullBestelRegelForMelk()
	{
		return new Bestelregel() { Id = Guid.Parse("C6437CCF-E46F-4BC6-9277-27A37A45FC2E"), Product = "melk", Aantal = 5, Brood = string.Empty, Extras = Array.Empty<string>(), Opmerkingen = "no mayo!" };
	}
}
