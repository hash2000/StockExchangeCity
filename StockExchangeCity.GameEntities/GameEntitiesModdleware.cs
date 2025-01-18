using Microsoft.Extensions.DependencyInjection;
using StockExchangeCity.GameEntities.Loaders;

namespace StockExchangeCity.GameEntities
{
	public static class GameEntitiesModdleware
	{
		public static IServiceCollection UseMapLoader(this IServiceCollection services, string dataPath)
		{
			services.AddSingleton<IMapLoader, MapLoader>();
			return services;
		}
	}
}
