using StockExchangeCity.GameEntities.Map;
using System.Drawing;

namespace StockExchangeCity.GameEntities.DataProviders.Abstractions
{
	public interface IWorldMapAreasGenerator
	{
		Task LoadAsync();

		Task SaveAsync();

		Task<List<Area>> GenerateAsync(float x, float y, float width, float height);

		Task<List<Area>> GenerateAsync(RectangleF rectangle);
	}
}
