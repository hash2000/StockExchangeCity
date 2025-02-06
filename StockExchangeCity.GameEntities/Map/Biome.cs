namespace StockExchangeCity.GameEntities.Map
{
	/// <summary>
	/// Биом
	/// </summary>
	public class Biome
	{
		/// <summary>
		/// название биома
		/// </summary>
		public string Name { get; set; } = string.Empty;

		/// <summary>
		/// диапазон высот
		/// </summary>
		public Range Height { get; set; } 

		/// <summary>
		/// дипазон температур
		/// </summary>
		public Range Temperature { get; set; }

		/// <summary>
		/// диапазон влажности
		/// </summary>
		public Range Humidity { get; set; }

		/// <summary>
		/// цвет
		/// </summary>
		public string Color { get; set; }
	}
}
