namespace StockExchangeCity.GameEntities.Map
{
	/// <summary>
	/// область на карте
	/// </summary>
	public class Area
	{
		/// <summary>
		/// описание локации
		/// </summary>
		public Location Location { get; set; }

		/// <summary>
		/// биом
		/// </summary>
		public Biome Biome { get; set; }

		/// <summary>
		/// свеб на карте (берётся из биома)
		/// </summary>
		public Color Color { get; set; }
	}
}
