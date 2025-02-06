namespace StockExchangeCity.GameEntities.DataProviders.Abstractions
{
	public interface IWorldMapGenerator
	{
		Task Generate(RectangleF areaRect);
	}
}
