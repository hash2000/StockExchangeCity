using StockExchangeCity.GameEntities.Map;

namespace StockExchangeCity.GameEntities.DataProviders.Maps
{
	public class RoadGenerator
	{
		private List<Settlement> _settlements;
		private Random _random;

		public RoadGenerator(List<Settlement> settlements)
		{
			_settlements = settlements;
			_random = new Random();
		}

		public List<Road> GenerateRoads()
		{
			List<Road> roads = new List<Road>();

			foreach (var settlement in _settlements)
			{
				int roadCount = _random.Next(settlement.Type, settlement.Type + 3); // Примерная логика

				for (int i = 0; i < roadCount; i++)
				{
					var availableSettlements = _settlements
						.Where(s => s != settlement && !settlement.ConnectedSettlements.Contains(s))
						.ToList();

					if (availableSettlements.Any())
					{
						var targetSettlement = availableSettlements[_random.Next(availableSettlements.Count)];
						roads.Add(new Road { From = settlement, To = targetSettlement });
						settlement.ConnectedSettlements.Add(targetSettlement);
						targetSettlement.ConnectedSettlements.Add(settlement);
					}
				}
			}

			return roads;
		}
	}
}
