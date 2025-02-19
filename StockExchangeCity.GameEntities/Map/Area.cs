using SkiaSharp;
using StockExchangeCity.Base.Collections;

namespace StockExchangeCity.GameEntities.Map
{
	/// <summary>
	/// область на карте
	/// </summary>
	public class Area : IQuadTreeItem
	{
		/// <summary>
		/// описание локации
		/// </summary>
		public MapLocation Location { get; set; }

		/// <summary>
		/// биом
		/// </summary>
		public Biome Biome { get; set; }

		/// <summary>
		/// свеб на карте (берётся из биома)
		/// </summary>
		public SKColor Color { get; set; }

		//public Brush Brush { get; set; }

		public SKRect Bounds {  get; set; }
	}
}
