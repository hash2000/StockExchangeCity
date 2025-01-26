using Microsoft.Extensions.Logging;
using StockExchangeCity.GameEntities.DataProviders.Abstractions;
using StockExchangeCity.GameEntities.Map;
using StockExchangeCity.GameUsers;

namespace StockExchangeCity.GameEntities.DataProviders.Maps
{
	internal class MapsDataProvider : IMapsDataProvider
	{
		private readonly ILogger _logger;
		private readonly IGameUsersRepository _users;

		public MapsDataProvider(ILogger logger, IGameUsersRepository users)
		{
			_logger = logger;
			_users = users;
		}

		public async Task Generate(List<Biome> biomes)
		{

		}

		public async Task LoadAsync()
		{
			_logger.LogInformation("Загрузка карты мира");




		}

		public async Task SaveAsync()
		{
		}
	}
}
