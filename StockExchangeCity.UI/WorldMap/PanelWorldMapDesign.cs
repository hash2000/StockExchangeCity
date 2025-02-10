using StockExchangeCity.GameEntities.DataProviders.Abstractions;

namespace StockExchangeCity.UI.WorldMap
{
	public partial class PanelWorldMapDesign : Panel
	{
		private readonly IWorldMapGenerator _mapAreas;
		private RectangleF _areaRectWindow = new RectangleF();
		private RectangleF _areaRect = new RectangleF();

		private readonly Pen _biomeBorderPen = new Pen(Color.Black);
		private readonly Pen _selectedBorderPen = new Pen(Color.DarkRed, 3);

		public PanelWorldMapDesign(IWorldMapGenerator mapsAreas)
		{
			_mapAreas = mapsAreas;
			InitializePainting();
			InitializeMoseEvents();
			InitializeAreaRects();
		}

		public async Task GenerateLocationAsync()
		{
			await _mapAreas.GenerateAsync(_areaRect);

			/*
			 // Генерация НП
				var settlementGenerator = new SettlementGenerator(biomes, descriptors);
				var settlements = settlementGenerator.GenerateSettlements(5, 15);

				// Генерация дорог
				var roadGenerator = new RoadGenerator(settlements);
				var roads = roadGenerator.GenerateRoads();

			// визуализация

			foreach (var settlement in settlements)
			{
				Console.WriteLine($"Settlement {settlement.Name} (Type {settlement.Type}) occupies biomes:");
				foreach (var biome in settlement.OccupiedBiomes)
				{
					Console.WriteLine($"  Biome at ({biome.X}, {biome.Y})");
				}
				Console.WriteLine($"Connected to: {string.Join(", ", settlement.ConnectedSettlements.Select(s => s.Name))}");
			}
			 */



			Refresh();
		}

		public void ClearAreas()
		{
			_mapAreas.ClearArea(_areaRect);
			Refresh();
		}

		private void InitializeAreaRects()
		{
			_areaRect.X = 0;
			_areaRect.Y = 0;
			_areaRect.Width = 128;
			_areaRect.Height = 128;
			UpdateAreaRectWindow();
		}

		private void UpdateAreaRectWindow()
		{
			var size = GetZoom();

			_areaRectWindow.X = _areaRect.X * size - _xOffset;
			_areaRectWindow.Y = _areaRect.Y * size - _yOffset;
			_areaRectWindow.Width = _areaRect.Width * size;
			_areaRectWindow.Height = _areaRect.Height * size;
		}

	}
}
