using System.Reflection;

namespace StockExchangeCity.Data.Loaders
{
	public static class ImagesLoader
	{
		public static ImageSource GetSource(string imageName)
		{
			return ImageSource.FromResource(
				$"{Assembly.GetExecutingAssembly().GetName().Name}.Resources.Images.{imageName}");
		}
	}
}
