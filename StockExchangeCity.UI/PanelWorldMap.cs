using StockExchangeCity.GameEntities.DataProviders.Abstractions;
using StockExchangeCity.GameEntities.Map;

namespace StockExchangeCity.UI
{
	public class PanelWorldMap : Panel
	{
		private readonly IMapsDataProvider _mapsDataProvider;
		private int _xOffset = 0;
		private int _yOffset = 0;
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
		}

		public async Task GenerateLocation(int x, int y, int width, int height)
		{
			var area = await _mapsDataProvider.GenerateAsync(0, 0, 128, 128);
			_areas.AddRange(area);
		}

		private void PanelWorldMap_OnMouseMove(object? sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{

			}
		}

		private void PanelWorldMap_OnMouseUp(object? sender, MouseEventArgs e)
		{
			if (_mouseSet)
			{

			}

			_mouseSet = false;
		}

		private void PanelWorldMap_OnMouseDown(object? sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				_mouseSet = true;
			}
		}

		private void PanelWorldMap_OnPaint(object? sender, PaintEventArgs e)
		{
			var g = e.Graphics;


		}
	}
}
