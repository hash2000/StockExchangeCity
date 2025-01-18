using Microsoft.Extensions.Logging;
using StockExchangeCity.GameEntities.Map;
using StockExchangeCity.GameUsers;

namespace StockExchangeCity.GameEntities.Loaders
{
	internal class MapLoader : IMapLoader
	{
		private readonly ILogger _logger;
		private readonly IGameUsersRepository _users;



		public MapLoader(ILogger logger, IGameUsersRepository users)
		{
			_logger = logger;
			_users = users;
		}

		public async Task LoadAsync()
		{
			_logger.LogInformation("Загрузка карты мира");




		}
	}
}
