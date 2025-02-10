namespace StockExchangeCity.UI.WorldMap
{
	public partial class PanelWorldMapDesign
	{
		private float _xOffset = 0;
		private float _yOffset = 0;
		private float _xOffsetStart = 0;
		private float _yOffsetStart = 0;
		private float _scrollOffset = 0;
		private MouseButtons _mouseSet = MouseButtons.None;

		private void InitializeMoseEvents()
		{
			MouseDown += PanelWorldMap_OnMouseDown;
			MouseUp += PanelWorldMap_OnMouseUp;
			MouseMove += PanelWorldMap_OnMouseMove;
			MouseWheel += PanelWorldMap_MouseWheel;
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

		private float GetZoom()
		{
			return 8f - _scrollOffset * 0.005f;
		}
	}
}
