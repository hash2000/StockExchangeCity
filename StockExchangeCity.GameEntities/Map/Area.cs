namespace StockExchangeCity.GameEntities.Map
{
	public class Area
	{
		public static int TileSizePX => 64;

		public Point Position { get; set; }

		public Bitmap? Bitmap { get; set; }

		public int XTiles { get; set; }

		public int YTiles { get; set; }

		public Handler? Handler { get; set; }
	}
}
