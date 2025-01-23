using Newtonsoft.Json;
using StockExchangeCity.GameEntities.Map;

namespace StockExchangeCity.GameEntities.DataProviders
{
	internal class BiomesFromJsonDataProvider : BaseBiomesDataProvider
	{
		private readonly string _mapsPath;
		private readonly string _biomesPath;

		private readonly Dictionary<string, Biome> _biomes = new Dictionary<string, Biome>();

		public BiomesFromJsonDataProvider(string mapsPath)
		{
			_mapsPath = mapsPath;
			_biomesPath = Path.Combine(_mapsPath, "Prefabs/Biomes/biomes.json");
		}

		public override Dictionary<string, Biome> Biomes => _biomes;

		public override async Task SaveAsync()
		{
			var biomes = new Biomes
			{
				Items = Biomes.Values.ToList(),
			};

			var asText = JsonConvert.SerializeObject(biomes);
			await File.WriteAllTextAsync(_biomesPath, asText);
		}

		public override async Task LoadAsync()
		{
			var bioms = JsonConvert.DeserializeObject<Biomes>(await File.ReadAllTextAsync(_biomesPath));
			if (bioms?.Items == null)
			{
				return;
			}

			var fileName = new FileInfo(_biomesPath).Name;

			foreach (var item in bioms.Items)
			{
				if (_biomes.ContainsKey(item.Name))
				{
					_biomes[item.Name] = item;
				}
				else
				{
					_biomes.TryAdd(item.Name, item);
				}
			}
		}

	}

}
