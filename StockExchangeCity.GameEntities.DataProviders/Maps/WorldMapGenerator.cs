using StockExchangeCity.GameEntities.DataProviders.Abstractions;
using StockExchangeCity.GameEntities.Map;

namespace StockExchangeCity.GameEntities.DataProviders.Maps
{
	internal class WorldMapGenerator : IWorldMapGenerator
	{
		private readonly IWorldMapAreasGenerator _worldMapAreasGenerator;

		private List<Area> _areas = new List<Area>();
		private Dictionary<float, Dictionary<float, Area>> _sortedAreas = new Dictionary<float, Dictionary<float, Area>>();

		public WorldMapGenerator(IWorldMapAreasGenerator worldMapAreasGenerator)
		{
			_worldMapAreasGenerator = worldMapAreasGenerator;
		}

		public async Task Generate(RectangleF areaRect)
		{
			var rectAreas = await _worldMapAreasGenerator.GenerateAsync(areaRect);
		}
	}
}
