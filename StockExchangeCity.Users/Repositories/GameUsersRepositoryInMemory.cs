using Microsoft.Extensions.Logging;

namespace StockExchangeCity.GameUsers.Repositories
{
	internal class GameUsersRepositoryInMemory : IGameUsersRepository
	{
		private readonly ILogger _logger;

		private User? _user;

		public User? User => _user;

		public GameUsersRepositoryInMemory(ILogger logger)
		{
			_logger = logger;
		}

		public async Task<bool> ConnectAsync(string token)
		{
			if (token.Equals("hash", StringComparison.InvariantCultureIgnoreCase))
			{
				_user = new User
				{
					NickName = "Hash2000",
					Id = Guid.Parse("E0BACC4A-27B4-4A95-9E50-B9737BDBE6F7"),
				};

				_logger.LogInformation($"{_user.NickName} подключился");
			
				return true;
			}

			return false;
		}
	}
}
