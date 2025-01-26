using Microsoft.Extensions.DependencyInjection;
using StockExchangeCity.CurrentHost.HostBuilder;

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
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();
			var builder = GameHostBuilder.CreateHostBuilder(services =>
			{
				services.AddTransient<Desktop>();
				services.AddTransient<FormConnect>();
			});

			var host = builder.Build();


			GameHostBuilder.ServiceProvider = host.Services;
			var appForm = GameHostBuilder.ServiceProvider.GetRequiredService<Desktop>();

			Application.Run(appForm);
		}
	}
}