using StockExchangeCity.GameEntities.Map;

namespace StockExchangeCity.GameEntities
{
	public interface IBiomesDataProvider
	{
		Dictionary<string, Biome> Biomes { get; }

		void Load();

		Biome? Find(int height, float temperature, float humidity);
	}
}
