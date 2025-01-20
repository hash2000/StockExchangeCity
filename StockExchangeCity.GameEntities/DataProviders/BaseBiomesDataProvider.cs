using StockExchangeCity.GameEntities.Map;

namespace StockExchangeCity.GameEntities.DataProviders
{
	internal abstract class BaseBiomesDataProvider : IBiomesDataProvider
	{
		public abstract Dictionary<string, Biome> Biomes { get; }

		public abstract void Load();

		public Biome? Find(int height, float temperature, float humidity)
		{
			foreach (var biome in Biomes)
			{
				if (!biome.Value.Height.IsFits(height))
				{
					continue;
				}

				if (!biome.Value.Temperature.IsFits(temperature))
				{
					continue;
				}

				if (!biome.Value.Humidity.IsFits(humidity))
				{
					continue;
				}

				return biome.Value;
			}

			return null;
		}

	}
}
