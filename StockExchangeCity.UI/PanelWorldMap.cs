namespace StockExchangeCity.UI
{
	public class PanelWorldMap : Panel
	{
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

		}

		private void PanelWorldMap_OnMouseUp(object? sender, MouseEventArgs e)
		{

		}

		private void PanelWorldMap_OnMouseDown(object? sender, MouseEventArgs e)
		{

		}

		private void PanelWorldMap_OnPaint(object? sender, PaintEventArgs e)
		{
			var g = e.Graphics;


		}
	}
}
