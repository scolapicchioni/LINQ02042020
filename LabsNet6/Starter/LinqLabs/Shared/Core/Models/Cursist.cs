﻿namespace InfoSupport.KC.FoodForThought.Shared.Core.Models;

/// <summary>
/// Student ordering the products
/// </summary>
public class Cursist
{
	/// <summary>
	/// Unique Id generated by the client upon first use of the application on a given device
	/// </summary>
	public Guid Id { get; set; }
	/// <summary>
	/// Full name of the student (Name Surname)
	/// </summary>
	public string Naam { get; set; } = string.Empty;
	/// <summary>
	/// Cursuslokaal where the student ordering the products is to be located
	/// </summary>
	public string Lokaal { get; set; } = string.Empty;
	/// <summary>
	/// Wether this student is allergic to something, or has intolerances, or any other remarks they may want to communicate with the restaurant
	/// </summary>
	public string Allergieen { get; set; } = string.Empty;
}