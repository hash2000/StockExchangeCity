using StockExchangeCity.GameEntities.Map;

namespace StockExchangeCity.GameEntities.DataProviders.Abstractions
{
	public interface IMapsDataProvider
	{
		Task LoadAsync();

		Task SaveAsync();

		Task<List<Area>> GenerateAsync(int x, int y, int width, int height, int speed = 70);
	}
}
