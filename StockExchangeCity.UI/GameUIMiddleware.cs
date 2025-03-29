using StockExchangeCity.UI.Biomes;
using StockExchangeCity.UI.WorldMaps;

namespace StockExchangeCity.UI
{
	public static class GameUIMiddleware
	{
		public static IServiceCollection UseGameUIDesignViews(this IServiceCollection services)
		{
			services.AddSingleton<BiomeCardView>();
			services.AddSingleton<WorldMapDesignView>();
			return services;
		}
	}
}
