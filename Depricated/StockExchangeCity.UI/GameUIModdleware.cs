using Microsoft.Extensions.DependencyInjection;
using StockExchangeCity.UI.WorldMap;

namespace StockExchangeCity.UI
{
    public static class GameUIModdleware
	{
		public static IServiceCollection UseGameUI(this IServiceCollection services, string dataPath)
		{
			var imagesPath = Path.Combine(dataPath,"Images");

			services.AddTransient(sb => new PanelImagesView(dataPath));
			return services;
		}

		public static IServiceCollection UseGameUIDesign(this IServiceCollection services, string dataPath)
		{
			services.AddTransient<PanelWorldMapDesign>();
			return services;
		}

	}
}
