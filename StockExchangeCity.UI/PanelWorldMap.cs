namespace StockExchangeCity.UI
{
	public class PanelWorldMap : Panel
	{
		private int _xOffset = 0;
		private int _yOffset = 0;
		private bool _mouseSet = false;

		public PanelWorldMap()
		{
			DoubleBuffered = true;
			Paint += PanelWorldMap_OnPaint;
			MouseDown += PanelWorldMap_OnMouseDown;
			MouseUp += PanelWorldMap_OnMouseUp;
			MouseMove += PanelWorldMap_OnMouseMove;
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
