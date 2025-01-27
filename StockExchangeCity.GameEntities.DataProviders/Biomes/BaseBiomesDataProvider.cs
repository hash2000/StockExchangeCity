using StockExchangeCity.GameEntities.DataProviders.Abstractions;
using StockExchangeCity.GameEntities.Map;
using Range = StockExchangeCity.GameEntities.Map.Range;

namespace StockExchangeCity.GameEntities.DataProviders.Biomes
{
	internal abstract class BaseBiomesDataProvider : IBiomesDataProvider
	{
		public abstract Dictionary<string, Biome> Biomes { get; }

		public abstract Task LoadAsync();

		public abstract Task SaveAsync();

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

		public List<Biome> FindByAnyOption(Range height, Range temperature, Range humidity)
		{
			var result = new List<Biome>();

			foreach (var biome in Biomes)
			{
				if (!biome.Value.Height.IsIncluded(height))
				{
					result.Add(biome.Value);
					continue;
				}

				if (!biome.Value.Temperature.IsIncluded(temperature))
				{
					result.Add(biome.Value);
					continue;
				}

				if (!biome.Value.Humidity.IsIncluded(humidity))
				{
					result.Add(biome.Value);
					continue;
				}
			}

			return result;
		}
	}
}
