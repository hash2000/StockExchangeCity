namespace StockExchangeCity.UI
{
	public class PanelImagesView : Panel
	{
		private readonly List<Bitmap> _images = new List<Bitmap>();
		private readonly string _imagesPath;

		public PanelImagesView(string imagesPath)
		{
			DoubleBuffered = true;
			_imagesPath = imagesPath;
		}

		public void LoadImages()
		{
			
		}
	}
}
