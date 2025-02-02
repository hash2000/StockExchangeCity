using StockExchangeCity.GameEntities.Map;

namespace StockExchangeCity.GameEntities.DataProviders.Abstractions
{
	public interface IMapsDataProvider
	{
		Task LoadAsync();

		Task SaveAsync();

		Task<List<Area>> GenerateAsync(float x, float y, float width, float height, int speed = 70);

		Task<List<Area>> GenerateAsync(RectangleF rectangle, int speed = 70);
	}
}
