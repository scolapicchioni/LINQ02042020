using System.Text.Json.Serialization;

namespace InfoSupport.KC.FoodForThought.Shared.Core.Models;

/// <summary>
/// Order for a given Student
/// </summary>
public class Bestelling
{
	/// <summary>
	/// Unique Id for an Order
	/// </summary>
	public Guid Id { get; set; } = Guid.NewGuid();
	/// <summary>
	/// Student data
	/// </summary>
	public Cursist Cursist { get; set; } = null!;

	/// <summary>
	/// Date for this order instance
	/// </summary>
	public DateOnly Datum { get; set; } 
	/// <summary>
	/// List of Order Items
	/// </summary>
	public Bestelregel[] Bestelregels { get; set; } = null!;
}
