using Newtonsoft.Json;
using StockExchangeCity.GameEntities.Map;

namespace StockExchangeCity.GameEntities.DataProviders
{
	internal class BiomesFromJsonDataProvider : BaseBiomesDataProvider
	{
		private readonly string _mapsPath;
		private readonly Dictionary<string, Biome> _bioms = new Dictionary<string, Biome>();

		public BiomesFromJsonDataProvider(string mapsPath)
		{
			_mapsPath = mapsPath;
		}

		public override Dictionary<string, Biome> Biomes => _bioms;

		public override void Load()
		{
			var prefsPath = Path.Combine(_mapsPath, "Prefabs/Biomes/");
			var files = Directory.GetFiles(prefsPath, "*.json");
			foreach (var file in files)
			{
				var bioms = JsonConvert.DeserializeObject<Biomes>(File.ReadAllText(file));
				if (bioms != null)
				{
					var fileName = new FileInfo(file).Name;

					foreach(var item in bioms.Items)
					{
						if (_bioms.ContainsKey(item.Name)) 
						{
							_bioms[item.Name] = item;
						}
						else
						{
							_bioms.TryAdd(item.Name, item);
						}
					}
				}
			}
		}

	}

}
