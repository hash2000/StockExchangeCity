using Microsoft.Extensions.Logging;
using StockExchangeCity.GameUsers;

namespace StockExchangeCity.GameEntities.DataProviders
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

		public async Task LoadAsync()
		{
			_logger.LogInformation("Загрузка карты мира");




		}
	}
}
