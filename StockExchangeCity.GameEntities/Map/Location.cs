namespace StockExchangeCity.GameEntities.Map
{
	/// <summary>
	/// Локация 
	/// - одна точка на карте, с характеристиками
	/// </summary>
	public class Location
	{
		/// <summary>
		/// позиция x
		/// </summary>
		public float X { get; set; }

		/// <summary>
		/// позиция y
		/// </summary>
		public float Y { get; set; }

		/// <summary>
		/// температура
		/// </summary>
		public float Temperature { get; set; }

		/// <summary>
		/// влажность
		/// </summary>
		public float Humidity { get; set; }

		/// <summary>
		/// высота
		/// </summary>
		public float Height { get; set; }
	}
}
