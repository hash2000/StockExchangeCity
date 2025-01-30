using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using StockExchangeCity.CurrentHost.Logger;
using StockExchangeCity.GameEntities.DataProviders;
using StockExchangeCity.GameUsers;
using StockExchangeCity.UI;

namespace StockExchangeCity.CurrentHost.HostBuilder
{
	public static class GameHostBuilder
	{
		public static IServiceProvider? ServiceProvider { get; set; }

		private static readonly Lazy<ILogger> _logger = new Lazy<ILogger>(() => LoggerBuilder.CreateLogger(ServiceProvider));

		public static string GetDataPath()
		{
			var cwd = Directory.GetCurrentDirectory();
			var dataPath = Path.Combine(cwd, "StockExchangeCity.Data");
			return dataPath;
		}

		public static IHostBuilder CreateHostBuilder(Action<IServiceCollection> serviceBuilder)
		{
			var dataPath = GetDataPath();
			return Host.CreateDefaultBuilder()
				.ConfigureServices((context, services) =>
				{
					services.AddSingleton(provider => _logger.Value);
					services.AddSingleton<FormLog>();
					services.UseMapLoader(dataPath);
					services.UseGameUsers(dataPath);
					services.UseGameUI(dataPath);

					serviceBuilder(services);
				});
		}

		public static void AddLog()
		{
			var logform = ServiceProvider?.GetRequiredService<FormLog>();
			if (logform == null)
			{
				return;
			}

			logform.Show();
			logform.Hide();
		}

	}

}
