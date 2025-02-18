using Newtonsoft.Json;
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
			//var bioms = JsonConvert.DeserializeObject<BiomesList>(await EmbeddedJsonLoader);
			//if (bioms?.Items == null)
			//{
			//	return;
			//}

			//var fileName = new FileInfo(_biomesPath).Name;

			//foreach (var item in bioms.Items)
			//{
			//	if (FindByName(item.Name) != null)
			//	{
			//		RemoveByName(item.Name);
			//	}

			//	Biomes.Add(item);
			//}
		}

	}

}
