using StockExchangeCity.Base.Collections;
using System.Drawing;

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
		public Location Location { get; set; }

		/// <summary>
		/// биом
		/// </summary>
		public Biome Biome { get; set; }

		/// <summary>
		/// свеб на карте (берётся из биома)
		/// </summary>
		public Color Color { get; set; }

		//public Brush Brush { get; set; }

		public RectangleF Bounds {  get; set; }
	}
}
