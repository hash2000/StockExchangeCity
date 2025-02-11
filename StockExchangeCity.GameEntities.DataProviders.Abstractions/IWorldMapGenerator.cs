using StockExchangeCity.Base.Collections;
using StockExchangeCity.GameEntities.Map;
using System.Drawing;

namespace StockExchangeCity.GameEntities.DataProviders.Abstractions
{
	public interface IWorldMapGenerator
	{
		SortedSet<QuadTree<Area>> Areas { get; }

		Task GenerateAsync(RectangleF areaRect);

		QuadTree<Area>? Find(RectangleF areaRect);

		void ClearArea(RectangleF areaRect);

		void Clear();
	}
}
