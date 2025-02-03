using StockExchangeCity.GameEntities.DataProviders.Abstractions;
using StockExchangeCity.GameEntities.Map;
using Range = StockExchangeCity.GameEntities.Map.Range;

namespace StockExchangeCity.GameEntities.DataProviders.Biomes
{
	internal abstract class BaseBiomesDataProvider : IBiomesDataProvider
	{
		public SortedSet<Biome> Biomes { get; } = new SortedSet<Biome>(Comparer<Biome>.Create((x, y) =>
		{
			var teight = x.Height.Min.CompareTo(y.Height.Min);
			if (teight != 0)
			{
				return teight;
			}

			var humidity = x.Humidity.Min.CompareTo(y.Humidity.Min);
			if (humidity != 0)
			{
				return humidity;
			}

			return x.Temperature.Min.CompareTo(y.Temperature.Min);
		}));

		public abstract Task LoadAsync();

		public abstract Task SaveAsync();

		public void RemoveByName(string name)
		{
			var items = Biomes.FirstOrDefault(x => x.Name == name);
			if (items != null)
			{
				Biomes.Remove(items);
			}
		}

		public Biome? FindByName(string name)
		{
			foreach (var item in Biomes)
			{
				if (item.Name.Equals(name, StringComparison.InvariantCultureIgnoreCase))
				{
					return item;
				}
			}

			return null;
		}

		public Biome? Find(float height, float temperature, float humidity)
		{
			if (Biomes.Count == 0)
			{
				return null;
			}

			foreach (var biome in Biomes)
			{
				if (biome.Height.IsFits(height) &&
					biome.Humidity.IsFits(humidity) &&
					biome.Temperature.IsFits(temperature))
				{
					return biome;
				}
			}

			return null;
		}

		public List<Biome> FindByAnyOption(Range height, Range temperature, Range humidity)
		{
			var result = new List<Biome>();

			foreach (var biome in Biomes)
			{
				if (!biome.Height.IsIncluded(height))
				{
					result.Add(biome);
					continue;
				}

				if (!biome.Humidity.IsIncluded(humidity))
				{
					result.Add(biome);
					continue;
				}

				if (!biome.Temperature.IsIncluded(temperature))
				{
					result.Add(biome);
					continue;
				}
			}

			return result;
		}
	}
}
