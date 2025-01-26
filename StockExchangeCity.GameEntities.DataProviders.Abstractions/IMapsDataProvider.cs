using StockExchangeCity.GameEntities.Map;

namespace StockExchangeCity.GameEntities.DataProviders.Abstractions
{
	public interface IMapsDataProvider
	{
		Task LoadAsync();

		Task SaveAsync();

		Task Generate(List<Biome> biomes);
	}
}
