using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using StockExchangeCity.GameEntities;
using StockExchangeCity.GameUsers;
using StockExchangeCity.UI.Logger;

namespace StockExchangeCity.UI.HostBuilder
{
	public static class GameHostBuilder
	{
		public static IServiceProvider? ServiceProvider { get; set; }

		private static readonly Lazy<ILogger> _logger = new Lazy<ILogger>(() => LoggerBuilder.CreateLogger(ServiceProvider));

		public static IHostBuilder CreateHostBuilder(Action<IServiceCollection> serviceBuilder)
		{
			var cwd = Directory.GetCurrentDirectory();
			var dataPath = Path.Combine(cwd, "StockExchangeCity.Data");

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

	}
}
