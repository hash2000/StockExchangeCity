using StockExchangeCity.GameEntities.DataProviders.Abstractions;
using StockExchangeCity.GameEntities.Map;

namespace StockExchangeCity.UI
{
	public class PanelWorldMap : Panel
	{
		private readonly IMapsDataProvider _mapsDataProvider;
		private float _xOffset = 0;
		private float _yOffset = 0;
		private float _xOffsetStart = 0;
		private float _yOffsetStart = 0;
		private float _scrollOffset = 0;
		private bool _mouseSet = false;
		private List<Area> _areas = new List<Area>();

		public PanelWorldMap(IMapsDataProvider mapsDataProvider)
		{
			_mapsDataProvider = mapsDataProvider;
			DoubleBuffered = true;
			Paint += PanelWorldMap_OnPaint;
			MouseDown += PanelWorldMap_OnMouseDown;
			MouseUp += PanelWorldMap_OnMouseUp;
			MouseMove += PanelWorldMap_OnMouseMove;
			MouseWheel += PanelWorldMap_MouseWheel;
		}

		private void PanelWorldMap_MouseWheel(object? sender, MouseEventArgs e)
		{
			_scrollOffset -= e.Delta;
			Refresh();
		}

		public async Task GenerateLocation(int x, int y, int width, int height)
		{
			var area = await _mapsDataProvider.GenerateAsync(0, 0, 128, 128);
			_areas.AddRange(area);
			Refresh();
		}

		private void PanelWorldMap_OnMouseMove(object? sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left && _mouseSet)
			{
				_xOffset += _xOffsetStart - e.X;
				_yOffset += _yOffsetStart - e.Y;
				_xOffsetStart = e.X;
				_yOffsetStart = e.Y;
				Refresh();
			}
		}

		private void PanelWorldMap_OnMouseUp(object? sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				_mouseSet = false;
				_xOffsetStart = e.X;
				_yOffsetStart = e.Y;
			}
		}

		private void PanelWorldMap_OnMouseDown(object? sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				_mouseSet = true;
				_xOffsetStart = e.X;
				_yOffsetStart = e.Y;
			}
		}

		private void PanelWorldMap_OnPaint(object? sender, PaintEventArgs e)
		{
			var g = e.Graphics;
			var size = 8f - _scrollOffset * 0.001f;

			foreach (var area in _areas)
			{
				var rect = new RectangleF
				{
					X = area.Location.X * size - _xOffset,
					Y = area.Location.Y * size - _yOffset,
					Width = size,
					Height = size,
				};

				g.FillRectangle(new SolidBrush(area.Color), rect);
				g.DrawRectangle(new Pen(Color.Black), rect);
			}
		}
	}
}
