using StockExchangeCity.GameEntities.DataProviders.Abstractions;
using StockExchangeCity.GameEntities.Map;

namespace StockExchangeCity.GameEntities.DataProviders.Maps
{
	internal class SettlementGenerator : ISettlementGenerator
	{
		private SortedSet<Biome> _biomes; // Список всех биомов
		private List<SettlementDescriptor> _settlements; // Описатели НП
		private Random _random;

		public SettlementGenerator(IBiomesDataProvider biomes, ISettlementDescriptorsDataProvider settlements)
		{
			_biomes = biomes.Biomes;
			_settlements = settlements.SettlementDescriptors;
			_random = new Random();
		}

		public async Task<List<Settlement>> Generate(int minDistance, int maxDistance)
		{
			List<Settlement> settlements = new List<Settlement>();

			foreach (var descriptor in _settlements.OrderBy(d => d.Type))
			{
				int settlementsToGenerate = _random.Next(1, descriptor.SpawnChance + 1);

				for (int i = 0; i < settlementsToGenerate; i++)
				{
					// Выбираем случайное количество биомов для НП
					int biomeCount = _random.Next(
						(int)descriptor.BiomeCount.Min, 
						(int)descriptor.BiomeCount.Max + 1);

					Settlement settlement = new Settlement
					{
						Id = settlements.Count + 1,
						Name = $"Settlement-{settlements.Count + 1}-{biomeCount}",
						Type = descriptor.Type
					};

					//// Выбираем случайные биомы для НП
					//for (int j = 0; j < biomeCount; j++)
					//{
					//	var availableBiomes = _biomes
					//		.Where(b => !settlements.Any(s => s.OccupiedBiomes.Contains(b.Location)))
					//		.ToList();

					//	if (availableBiomes.Any())
					//	{
					//		var selectedBiome = availableBiomes[_random.Next(availableBiomes.Count];
					//		settlement.OccupiedBiomes.Add(selectedBiome.Location);
					//	}
					//}

					// Проверяем, чтобы НП не находились слишком близко друг к другу
					if (!settlements.Any(s => IsTooClose(s, settlement, minDistance, maxDistance)))
					{
						settlements.Add(settlement);
					}
				}
			}

			return settlements;
		}

		private bool IsTooClose(Settlement existing, Settlement newSettlement, int minDistance, int maxDistance)
		{
			//foreach (var existingBiome in existing.OccupiedBiomes)
			//{
			//	foreach (var newBiome in newSettlement.OccupiedBiomes)
			//	{
			//		int distance = Math.Abs(existingBiome.X - newBiome.X) + Math.Abs(existingBiome.Y - newBiome.Y);
			//		if (distance < minDistance || distance > maxDistance)
			//		{
			//			return true;
			//		}
			//	}
			//}
			return false;
		}
	}
}
