using Microsoft.Extensions.Logging;
using StockExchangeCity.GameEntities.DataProviders.Abstractions;
using StockExchangeCity.GameUsers;

namespace StockExchangeCity
{
	public partial class FormConnect : Form
	{
		private readonly IWorldMapAreasGenerator _mapLoader;
		private readonly IGameUsersRepository _users;
		private readonly ILogger _logger;

		public FormConnect(IWorldMapAreasGenerator mapLoader, IGameUsersRepository users, ILogger logger)
		{
			InitializeComponent();

			_mapLoader = mapLoader;
			_users = users;
			_logger = logger;
		}

		private async void BtConnect_Click(object sender, EventArgs e)
		{
			var connectResult = await _users.ConnectAsync(TextToken.Text);
			if (!connectResult)
			{
				return;
			}

			await _mapLoader.LoadAsync();

			ConnectionCompete();
		}

		private void ConnectionCompete()
		{
			Close();

			_logger.LogInformation("Подключение успешно завершено");
		}
	}
}
