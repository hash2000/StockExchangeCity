namespace StockExchangeCity.GameEntities.Map
{
	public class Biome
	{
		public string Name { get; set; } = string.Empty;

		/// <summary>
		/// высота
		/// </summary>
		public Range Height { get; set; }

		/// <summary>
		/// температура
		/// </summary>
		public Range Temperature { get; set; }

		/// <summary>
		/// влажность
		/// </summary>
		public Range Humidity { get; set; }

		/// <summary>
		/// цвет
		/// </summary>
		public string Color { get; set; }

		public override string ToString()
		{
			return Name;
		}
	}
}
