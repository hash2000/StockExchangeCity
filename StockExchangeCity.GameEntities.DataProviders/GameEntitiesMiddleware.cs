using StockExchangeCity.GameEntities.DataProviders.Abstractions;
using StockExchangeCity.GameEntities.DataProviders.Biomes;
using StockExchangeCity.GameEntities.DataProviders.Maps;

namespace StockExchangeCity.GameEntities.DataProviders
{
	public static class GameEntitiesMiddleware
	{
		public static IServiceCollection UseMapLoader(this IServiceCollection services)
		{
			services.AddSingleton<IBiomesDataProvider>(sb => new BiomesFromJsonDataProvider());
			services.AddSingleton<ISettlementDescriptorsDataProvider, SettlementDescriptorsDataProvider>();
			services.AddSingleton<IWorldMapAreasGenerator, WorldMapAreasGenerator>();
			services.AddSingleton<IWorldMapGenerator, WorldMapGenerator>();

			return services;
		}
	}

}
