using SkiaSharp;
using SkiaSharp.Views.Maui;

namespace StockExchangeCity.UI.WorldMaps;

public partial class WorldMapDesignView : ContentView
{
	private SKPoint? _touchLocation;

	public WorldMapDesignView()
	{
		InitializeComponent();
	}

	private void WorldMapCanvas_PaintSurface(object sender, SKPaintSurfaceEventArgs e)
	{
		var canvas = e.Surface.Canvas;
		//canvas.Clear(SKColors.DarkGreen);
    }

	private void WorldMapCanvas_Touch(object sender, SKTouchEventArgs e)
	{
		if (e.InContact)
			_touchLocation = e.Location;
		else
			_touchLocation = null;

		WorldMapCanvas.InvalidateSurface();

		e.Handled = true;
	}
}