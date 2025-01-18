using Microsoft.Extensions.Logging;
using StockExchangeCity.GameEntities;
using StockExchangeCity.GameUsers;

namespace StockExchangeCity
{
	public partial class FormConnect : Form
	{
		private readonly IMapLoader _mapLoader;
		private readonly IGameUsersRepository _users;
		private readonly ILogger _logger;

		public FormConnect(IMapLoader mapLoader, IGameUsersRepository users, ILogger logger)
		{
			InitializeComponent();

			_mapLoader = mapLoader;
			_users = users;
			_logger = logger;
		}

		private void BtConnect_Click(object sender, EventArgs e)
		{
			Task.Run(async () =>
			{
				var connectResult = await _users.ConnectAsync(TextToken.Text);
				if (!connectResult)
				{
					return;
				}

				await _mapLoader.LoadAsync();

				ConnectionCompete();
			});
		}

		private void ConnectionCompete()
		{
			Invoke((MethodInvoker)delegate
			{
				Close();
			});

			_logger.LogInformation("Подключение успешно завершено");
		}
	}
}
