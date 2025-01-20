using Microsoft.Extensions.DependencyInjection;
using StockExchangeCity.GameEntities.DataProviders;

namespace StockExchangeCity.GameEntities
{
	public static class GameEntitiesModdleware
	{
		public static IServiceCollection UseMapLoader(this IServiceCollection services, string dataPath)
		{
			services.AddSingleton<IMapsDataProvider, MapsDataProvider>();
			services.AddSingleton<IBiomesDataProvider>(sb => new BiomesFromJsonDataProvider(dataPath));
			return services;
		}
	}
}
