using StockExchangeCity.GameEntities.DataProviders.Abstractions;
using StockExchangeCity.GameEntities.Map;
using Range = StockExchangeCity.GameEntities.Map.Range;

namespace StockExchangeCity.GameEntities.DataProviders.Biomes
{
	internal abstract class BaseBiomesDataProvider : IBiomesDataProvider
	{
		public abstract Dictionary<string, Biome> Biomes { get; }

		public abstract Task LoadInternalAsync();

		public abstract Task SaveAsync();

		public async Task LoadAsync()
		{
			await LoadInternalAsync();

			_sortedBiomes.Clear();

			foreach (var biome in Biomes.Values)
			{
				_sortedBiomes.Add(biome);
			}
		}

		private SortedSet<Biome> _sortedBiomes = new SortedSet<Biome>(Comparer<Biome>.Create((x, y) =>
		{
			var temp = x.Temperature.Min.CompareTo(y.Temperature.Min);
			if (temp != 0)
			{
				return temp;
			}

			var humidity = x.Humidity.Min.CompareTo(y.Humidity.Min);
			if (humidity != 0)
			{
				return humidity;
			}

			return x.Height.Min.CompareTo(y.Height.Min);
		}));

		public Biome? Find(int height, float temperature, float humidity)
		{
			if(_sortedBiomes.Count == 0)
			{
				return null;
			}

			foreach(var biome in _sortedBiomes)
			{
				if(biome.Height.IsFits(height) &&
					biome.Temperature.IsFits(temperature) && 
					biome.Humidity.IsFits(humidity))
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
