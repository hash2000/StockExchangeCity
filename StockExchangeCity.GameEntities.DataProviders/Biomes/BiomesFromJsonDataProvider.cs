using Newtonsoft.Json;
using StockExchangeCity.Data.Loaders;
using StockExchangeCity.GameEntities.Map;

namespace StockExchangeCity.GameEntities.DataProviders.Biomes
{
	internal class BiomesFromJsonDataProvider : BaseBiomesDataProvider
	{
		public override async Task SaveAsync()
		{
			//var biomes = new BiomesList
			//{
			//	Items = Biomes.ToList(),
			//};

			//var asText = JsonConvert.SerializeObject(biomes);
			//await File.WriteAllTextAsync(_biomesPath, asText);
		}

		public override async Task LoadAsync()
		{
			var bioms = JsonConvert.DeserializeObject<BiomesList>(await EmbeddedJsonLoader.GetPrefabsSource("biomes.json"));
			if (bioms?.Items == null)
			{
				return;
			}

			foreach (var item in bioms.Items)
			{
				if (FindByName(item.Name) != null)
				{
					RemoveByName(item.Name);
				}

				Biomes.Add(item);
			}
		}

	}

}
