namespace StockExchangeCity.GameEntities.Map
{
	/// <summary>
	/// Описатель населённого пункта
	/// </summary>
	public class SettlementDescriptor
	{
		/// <summary>
		/// тип НП
		/// </summary>
		public int Type { get; set; }

		/// <summary>
		/// минимальное и максимальное количество биомов
		/// </summary>
		public Range BiomeCount { get; set; }

		/// <summary>
		/// минимальное и максимальное количество дорог
		/// </summary>
		public Range RoadCount { get; set; }

		/// <summary>
		/// шанс появления (чем меньше число, тем выше шанс)
		/// </summary>
		public int SpawnChance { get; set; }

		/// <summary>
		/// минимальное расстояние между НП такого же типа
		/// </summary>
		public int MinDistanceBetweenSameType { get; set; }
	}
}
