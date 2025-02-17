using StockExchangeCity.CurrentHost.HostBuilder;
using StockExchangeCity.Game.Tools.MapEditor.Views;

namespace StockExchangeCity.Game.Tools.MapEditor;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			})
			.ConfigureMauiHandlers(handles =>
			{
				handles.AddMauiControlsHandlers();
			});

		builder.Services.ConfigureGameHostServices();
		builder.Services.ConfigureMauiPages();

		return builder.Build();
	}

	public static IServiceCollection ConfigureMauiPages(this IServiceCollection services)
	{
		services.AddSingleton<BiomesPage>();
		return services;
	}
}
