using StockExchangeCity.GameEntities.Map;

namespace StockExchangeCity.GameEntities.DataProviders.Abstractions
{
	public interface ISettlementDescriptorsDataProvider
	{
		List<SettlementDescriptor> SettlementDescriptors { get; }

		Task LoadAsync();

		Task SaveAsync();
	}
}
