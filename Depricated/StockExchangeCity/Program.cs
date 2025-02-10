using Microsoft.Extensions.DependencyInjection;
using StockExchangeCity.CurrentHost.HostBuilder;
using StockExchangeCity.UI;

namespace StockExchangeCity
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			ApplicationConfiguration.Initialize();
			var builder = GameHostBuilder.CreateHostBuilder(services =>
			{
				services.AddTransient<Desktop>();
				services.AddTransient<FormConnect>();
				services.AddSingleton<FormLog>();
			});

			var host = builder.Build();


			GameHostBuilder.ServiceProvider = host.Services;
			var appForm = GameHostBuilder.ServiceProvider.GetRequiredService<Desktop>();

			Application.Run(appForm);
		}
	}
}