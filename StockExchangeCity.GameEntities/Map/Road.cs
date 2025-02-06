namespace StockExchangeCity.GameEntities.Map
{
	/// <summary>
	/// Дорога
	/// </summary>
	public class Road
	{
		/// <summary>
		/// начальный НП
		/// </summary>
		public Settlement From { get; set; }

		/// <summary>
		/// конечный НП
		/// </summary>
		public Settlement To { get; set; }
	}
}
