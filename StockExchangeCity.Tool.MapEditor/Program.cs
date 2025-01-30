using Microsoft.Extensions.DependencyInjection;
using StockExchangeCity.CurrentHost.HostBuilder;
using StockExchangeCity.UI;

namespace StockExchangeCity.Tool.MapEditor
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
				var dataPath = GameHostBuilder.GetDataPath();
				services.UseGameUIDesign(dataPath);
				services.AddTransient<Desktop>();
			});

			var host = builder.Build();

			GameHostBuilder.ServiceProvider = host.Services;
			var appForm = GameHostBuilder.ServiceProvider.GetRequiredService<Desktop>();

			Application.Run(appForm);
		}
	}
}