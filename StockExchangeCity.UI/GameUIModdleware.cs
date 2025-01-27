using Microsoft.Extensions.DependencyInjection;

namespace StockExchangeCity.UI
{
	public static class GameUIModdleware
	{
		public static IServiceCollection UseGameUI(this IServiceCollection services, string dataPath)
		{
			var imagesPath = Path.Combine(dataPath,"Images");

			services.AddTransient<PanelWorldMap>();
			services.AddTransient(sb => new PanelImagesView(dataPath));
			return services;
		}

	}
}
