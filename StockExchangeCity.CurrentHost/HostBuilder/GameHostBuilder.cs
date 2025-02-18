using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using StockExchangeCity.CurrentHost.Logger;
using StockExchangeCity.GameEntities.DataProviders;
using StockExchangeCity.GameUsers;

namespace StockExchangeCity.CurrentHost.HostBuilder
{
	public static class GameHostBuilder
	{
		public static IHostBuilder CreateGameHostBuilder(Action<IServiceCollection> serviceBuilder)
		{
			return Host.CreateDefaultBuilder()
				.ConfigureServices((context, services) =>
				{
					services.ConfigureGameHostServices();
					serviceBuilder(services);
				});
		}

		public static IServiceCollection ConfigureGameHostServices(this IServiceCollection services)
		{
			services.AddSingleton(provider => new Lazy<ILogger>(() => LoggerBuilder.CreateLogger(provider)));
			services.UseMapLoader();
			services.UseGameUsers();

			return services;
		}
	}

}
