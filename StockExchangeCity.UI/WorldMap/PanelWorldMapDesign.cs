using StockExchangeCity.GameEntities.DataProviders.Abstractions;
using StockExchangeCity.GameEntities.Map;

namespace StockExchangeCity.UI.WorldMap
{
	public class PanelWorldMapDesign : Panel
	{
		private readonly IWorldMapAreasGenerator _mapAreas;
		private float _xOffset = 0;
		private float _yOffset = 0;
		private float _xOffsetStart = 0;
		private float _yOffsetStart = 0;
		private float _scrollOffset = 0;
		private MouseButtons _mouseSet = MouseButtons.None;
		private List<Area> _areas = new List<Area>();
		private RectangleF _areaRectWindow = new RectangleF();
		private RectangleF _areaRect = new RectangleF();

		private readonly Pen _biomeBorderPen = new Pen(Color.Black);
		private readonly Pen _selectedBorderPen = new Pen(Color.DarkRed, 3);

		public PanelWorldMapDesign(IWorldMapAreasGenerator mapsAreas)
		{
			_mapAreas = mapsAreas;
			DoubleBuffered = true;
			Paint += PanelWorldMap_OnPaint;
			MouseDown += PanelWorldMap_OnMouseDown;
			MouseUp += PanelWorldMap_OnMouseUp;
			MouseMove += PanelWorldMap_OnMouseMove;
			MouseWheel += PanelWorldMap_MouseWheel;
			InitializeAreaRects();
		}

		public async Task GenerateLocationAsync()
		{
			var area = await _mapAreas.GenerateAsync(_areaRect);
			_areas.AddRange(area);
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
			_areas.Clear();
			Refresh();
		}

		private void PanelWorldMap_MouseWheel(object? sender, MouseEventArgs e)
		{
			_scrollOffset -= e.Delta;
			UpdateAreaRectWindow();
			Refresh();
		}

		private void PanelWorldMap_OnMouseMove(object? sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right && _mouseSet == MouseButtons.Right)
			{
				_xOffset += _xOffsetStart - e.X;
				_yOffset += _yOffsetStart - e.Y;
				_xOffsetStart = e.X;
				_yOffsetStart = e.Y;
				UpdateAreaRectWindow();
				Refresh();
				return;
			}
		}

		private void PanelWorldMap_OnMouseUp(object? sender, MouseEventArgs e)
		{
			if (_mouseSet == MouseButtons.Right)
			{
				_xOffsetStart = e.X;
				_yOffsetStart = e.Y;
			}
			else if (_mouseSet == MouseButtons.Left)
			{
				var size = GetZoom();
				float worldX = (e.X + _xOffset) / size;
				float worldY = (e.Y + _yOffset) / size;

				// Выравниваем по сетке 128x128
				_areaRect.X = (int)(worldX / 128) * 128;
				_areaRect.Y = (int)(worldY / 128) * 128;

				if (worldX < 0) 
				{
					_areaRect.X -= 128;
				}

				if (worldY < 0)
				{
					_areaRect.Y -= 128;
				}

				UpdateAreaRectWindow();
				Refresh();
			}

			_mouseSet = MouseButtons.None;
		}

		private void PanelWorldMap_OnMouseDown(object? sender, MouseEventArgs e)
		{
			_mouseSet = e.Button;

			if (_mouseSet == MouseButtons.Right)
			{
				_xOffsetStart = e.X;
				_yOffsetStart = e.Y;
			}
		}

		private void PanelWorldMap_OnPaint(object? sender, PaintEventArgs e)
		{
			var g = e.Graphics;
			var size = GetZoom();

			foreach (var area in _areas)
			{
				var rect = new RectangleF
				{
					X = area.Location.X * size - _xOffset,
					Y = area.Location.Y * size - _yOffset,
					Width = size,
					Height = size,
				};

				using (var pen = new SolidBrush(area.Color))
				{
					g.FillRectangle(pen, rect);
				}

				g.DrawRectangle(_biomeBorderPen, rect);
			}

			g.DrawRectangle(_selectedBorderPen, _areaRectWindow);
		}

		private float GetZoom()
		{
			return 8f - _scrollOffset * 0.005f;
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
