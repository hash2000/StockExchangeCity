using StockExchangeCity.GameEntities.Map;

namespace StockExchangeCity.GameEntities.DataProviders.Abstractions
{
	public interface ISettlementGenerator
	{
		Task<List<Settlement>> Generate(int minDistance, int maxDistance);
	}
}
