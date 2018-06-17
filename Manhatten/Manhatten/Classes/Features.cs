using System;
using System.Collections;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Text;


namespace Manhatten
{
	public class Features
	{
		/// <summary>
		/// getters and setters for card values
		/// </summary>
		public Feature Feature{ get; set; }
		public Value Value { get; set; }

	}

	/// <summary>
	/// enumerator values for Suite type
	/// </summary>
	public enum Feature
	{
		Hearts,
		Diamonds,
		Spades,
		Clubs
	}

	/// <summary>
	/// enumerator values for Value type
	/// </summary>
	public enum Value
	{
		One = 1,
		Two,
		Three,
		Four,
		Five,
		Six,
		Seven,
		Eight,
		Nine,
		Jack = 10,
		Queen,
		King,
		Ace
	}
}
