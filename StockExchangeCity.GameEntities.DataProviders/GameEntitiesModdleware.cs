using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.ObjectPool;
using StockExchangeCity.GameEntities.DataProviders.Abstractions;
using StockExchangeCity.GameEntities.DataProviders.Biomes;
using StockExchangeCity.GameEntities.DataProviders.Maps;
using StockExchangeCity.GameEntities.Map;

namespace StockExchangeCity.GameEntities.DataProviders
{
	public static class GameEntitiesModdleware
	{
		public static IServiceCollection UseMapLoader(this IServiceCollection services, string dataPath)
		{
			services.AddSingleton<IMapsDataProvider, MapsDataProvider>();
			services.AddSingleton<IBiomesDataProvider>(sb => new BiomesFromJsonDataProvider(dataPath));
			services.TryAddSingleton<ObjectPoolProvider, DefaultObjectPoolProvider>();
			services.TryAddSingleton<ObjectPool<Location>>(sp =>
			{
				var provider = sp.GetRequiredService<ObjectPoolProvider>();
				return provider.Create<Location>();
			});
			return services;
		}
	}

}
