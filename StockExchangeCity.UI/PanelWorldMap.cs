using StockExchangeCity.GameEntities.DataProviders.Abstractions;

namespace StockExchangeCity.UI
{
	public class PanelWorldMap : Panel
	{
		private readonly IBiomesDataProvider _biomsDataProvider;
		private readonly IMapsDataProvider _mapsDataProvider;
		private int _xOffset = 0;
		private int _yOffset = 0;
		private bool _mouseSet = false;

		public PanelWorldMap(IBiomesDataProvider biomsDataProvider, IMapsDataProvider mapsDataProvider)
		{
			_biomsDataProvider = biomsDataProvider;
			_mapsDataProvider = mapsDataProvider;
			DoubleBuffered = true;
			Paint += PanelWorldMap_OnPaint;
			MouseDown += PanelWorldMap_OnMouseDown;
			MouseUp += PanelWorldMap_OnMouseUp;
			MouseMove += PanelWorldMap_OnMouseMove;
		}

		public void GenerateLocation(int x, int y, int width, int height)
		{

		}

		private void PanelWorldMap_OnMouseMove(object? sender, MouseEventArgs e)
		{
			if(e.Button == MouseButtons.Left)
			{

			}
		}

		private void PanelWorldMap_OnMouseUp(object? sender, MouseEventArgs e)
		{
			if (_mouseSet) { 
			
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
