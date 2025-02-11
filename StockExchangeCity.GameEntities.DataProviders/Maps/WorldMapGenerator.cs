using Microsoft.Extensions.Logging;
using StockExchangeCity.Base.Collections;
using StockExchangeCity.GameEntities.DataProviders.Abstractions;
using StockExchangeCity.GameEntities.Map;
using System.Drawing;

namespace StockExchangeCity.GameEntities.DataProviders.Maps
{
	internal class WorldMapGenerator : IWorldMapGenerator
	{
		private readonly IWorldMapAreasGenerator _worldMapAreasGenerator;
		private readonly ILogger<WorldMapGenerator> _logger;

		private SortedSet<QuadTree<Area>> _areas =
			new SortedSet<QuadTree<Area>>(Comparer<QuadTree<Area>>.Create((left, right) =>
			{
				var cx = left.Bounds.X.CompareTo(right.Bounds.X);
				if (cx != 0)
				{
					return cx;
				}

				return left.Bounds.Y.CompareTo(right.Bounds.Y);
			}));

		public SortedSet<QuadTree<Area>> Areas => _areas;

		public WorldMapGenerator(IWorldMapAreasGenerator worldMapAreasGenerator,
			ILogger<WorldMapGenerator> logger)
		{
			_worldMapAreasGenerator = worldMapAreasGenerator;
			_logger = logger;
		}

		public void ClearArea(RectangleF areaRect)
		{
			var area = Find(areaRect);
			if (area == null)
			{
				return;
			}

			_areas.Remove(area);
		}

		public void Clear()
		{
			_areas.Clear();
		}

		public async Task GenerateAsync(RectangleF areaRect)
		{
			var definedArea = Find(areaRect);
			if (definedArea != null)
			{
				_logger.LogWarning($"Область {areaRect.X}, {areaRect.Y}, {areaRect.Width}, {areaRect.Height}");
				return;
			}

			var rectAreas = await _worldMapAreasGenerator.GenerateAsync(areaRect);
			var quad = new QuadTree<Area>(areaRect);
			_areas.Add(quad);

			foreach (var item in rectAreas)
			{
				quad.Insert(item);
			}
		}

		public QuadTree<Area>? Find(RectangleF areaRect)
		{
			foreach (var item in _areas)
			{
				if (item.Bounds.IntersectsWith(areaRect))
				{
					return item;
				}
			}

			return null;
		}
	}
}
