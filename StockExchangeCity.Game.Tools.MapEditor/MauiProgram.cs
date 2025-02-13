using Microsoft.Extensions.Logging;
using StockExchangeCity.CurrentHost.HostBuilder;

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

		return builder.Build();
	}
}
