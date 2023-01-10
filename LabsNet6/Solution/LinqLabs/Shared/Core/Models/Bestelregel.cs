namespace InfoSupport.KC.FoodForThought.Shared.Core.Models;

/// <summary>
/// Item in an Order
/// </summary>
public class Bestelregel
{
	/// <summary>
	/// Unique ID of this Order Item
	/// </summary>
	public Guid Id { get; set; } = Guid.NewGuid();
	/// <summary>
	/// ProductId (such as frikandel, ham-kaas and so on).
	/// </summary>
	public string Product { get; set; } = string.Empty;
	/// <summary>
	/// Quantity. It must be greater or equal to 1.
	/// </summary>
	public int Aantal { get; set; } = 1;
	/// <summary>
	/// If the item is a sandwich, this field contains the ID of the type of bread chosen by the student. Null if it's an item of a different category such as a snack, drink or anything else.
	/// </summary>
	public string? Brood { get; set; }
	/// <summary>
	/// List of Id of extras selected by the student. It could be null if no extra has been selected.
	/// </summary>
	public string[]? Extras { get; set; } 
	/// <summary>
	/// Field for eventual remarks. It could be null if no remark has been added by the student for this item.
	/// </summary>
	public string? Opmerkingen { get; set; }
}
