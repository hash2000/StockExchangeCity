namespace StockExchangeCity.UI.WorldMap
{
	public partial class PanelWorldMapDesign
	{
		private void InitializePainting()
		{
			DoubleBuffered = true; 
			Paint += PanelWorldMap_OnPaint;
		}

		private void PanelWorldMap_OnPaint(object? sender, PaintEventArgs e)
		{
			var g = e.Graphics;
			var size = GetZoom();

			foreach (var area in _mapAreas.Areas)
			{
				foreach (var item in area)
				{
					var rect = new RectangleF
					{
						X = item.Bounds.X * size - _xOffset,
						Y = item.Bounds.Y * size - _yOffset,
						Width = size,
						Height = size,
					};

					g.FillRectangle(item.Brush, rect);
					g.DrawRectangle(_biomeBorderPen, rect);
				}
			}

			g.DrawRectangle(_selectedBorderPen, _areaRectWindow);
		}
	}
}
