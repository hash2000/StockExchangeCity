using StockExchangeCity.GameEntities.Map;
using Range = StockExchangeCity.GameEntities.Map.Range;

namespace StockExchangeCity.GameEntities.DataProviders.Abstractions
{
	public interface IBiomesDataProvider
	{
		Dictionary<string, Biome> Biomes { get; }

		Task LoadAsync();

		Task SaveAsync();

		Biome? Find(float height, float temperature, float humidity);

		List<Biome> FindByAnyOption(Range height, Range temperature, Range humidity);
	}
}
