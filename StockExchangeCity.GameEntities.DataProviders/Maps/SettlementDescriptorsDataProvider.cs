using StockExchangeCity.GameEntities.DataProviders.Abstractions;
using StockExchangeCity.GameEntities.Map;
using Range = StockExchangeCity.GameEntities.Map.Range;

namespace StockExchangeCity.GameEntities.DataProviders.Maps
{
	internal class SettlementDescriptorsDataProvider : ISettlementDescriptorsDataProvider
	{
		public List<SettlementDescriptor> SettlementDescriptors { get; } = new List<SettlementDescriptor>
		// TODO; test data
		{  
			new SettlementDescriptor { Type = 1, BiomeCount = new Range { Min = 3, Max = 5 }, RoadCount = new Range { Min = 3, Max = 5 }, SpawnChance = 1, MinDistanceBetweenSameType = 10 },
			new SettlementDescriptor { Type = 2, BiomeCount = new Range { Min = 2, Max = 4 }, RoadCount = new Range { Min = 2, Max = 4 }, SpawnChance = 2, MinDistanceBetweenSameType = 8 },
		};

		public async Task LoadAsync()
		{
		}

		public async Task SaveAsync()
		{

		}
	}
}
