using Microsoft.Extensions.Logging;
using SkiaSharp;
using StockExchangeCity.Base.Collections;
using StockExchangeCity.GameEntities.DataProviders.Abstractions;
using StockExchangeCity.GameEntities.Map;

namespace StockExchangeCity.GameEntities.DataProviders.Maps
{
	internal class WorldMapGenerator : IWorldMapGenerator
	{
		private readonly IWorldMapAreasGenerator _worldMapAreasGenerator;
		private readonly ILogger<WorldMapGenerator> _logger;

		private SortedSet<QuadTree<Area>> _areas =
			new SortedSet<QuadTree<Area>>(Comparer<QuadTree<Area>>.Create((left, right) =>
			{
				var cx = left.Bounds.Left.CompareTo(right.Bounds.Left);
				if (cx != 0)
				{
					return cx;
				}

				return left.Bounds.Top.CompareTo(right.Bounds.Top);
			}));

		public SortedSet<QuadTree<Area>> Areas => _areas;

		public WorldMapGenerator(IWorldMapAreasGenerator worldMapAreasGenerator,
			ILogger<WorldMapGenerator> logger)
		{
			_worldMapAreasGenerator = worldMapAreasGenerator;
			_logger = logger;
		}

		public void ClearArea(SKRect areaRect)
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

		public async Task GenerateAsync(SKRect areaRect)
		{
			var definedArea = Find(areaRect);
			if (definedArea != null)
			{
				_logger.LogWarning($"Область {areaRect.Left}, {areaRect.Top}, {areaRect.Width}, {areaRect.Height}");
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

		public QuadTree<Area>? Find(SKRect areaRect)
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
