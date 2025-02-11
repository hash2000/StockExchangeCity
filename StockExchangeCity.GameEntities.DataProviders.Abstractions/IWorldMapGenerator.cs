using SkiaSharp;
using StockExchangeCity.Base.Collections;
using StockExchangeCity.GameEntities.Map;

namespace StockExchangeCity.GameEntities.DataProviders.Abstractions
{
	public interface IWorldMapGenerator
	{
		SortedSet<QuadTree<Area>> Areas { get; }

		Task GenerateAsync(SKRect areaRect);

		QuadTree<Area>? Find(SKRect areaRect);

		void ClearArea(SKRect areaRect);

		void Clear();
	}
}
