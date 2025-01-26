using Microsoft.Extensions.DependencyInjection;
using StockExchangeCity.GameEntities.DataProviders.Abstractions;
using StockExchangeCity.GameEntities.DataProviders.Biomes;
using StockExchangeCity.GameEntities.DataProviders.Maps;

namespace StockExchangeCity.GameEntities.DataProviders
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
