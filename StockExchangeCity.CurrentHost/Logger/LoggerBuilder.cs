using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using OpenTelemetry.Resources;
using StockExchangeCity.UI;

namespace StockExchangeCity.CurrentHost.Logger
{
	public static class LoggerBuilder
	{
		private static readonly LoggerFactory _loggerFactory = new LoggerFactory();

		public static ILogger CreateLogger(IServiceProvider? serviceProvider)
		{
			var resource = ResourceBuilder
				.CreateDefault()
				.AddTelemetrySdk()
				.AddService("StockExchangeCity");

			return LoggerFactory
				.Create(builder =>
				{
					builder.AddOpenTelemetry(conf =>
					{
						conf.SetResourceBuilder(resource);
						conf.AddProcessor(new LoggerProcessorForm(
							_loggerFactory.CreateLogger("common"),
							serviceProvider?.GetRequiredService<FormLog>() ?? throw new ArgumentNullException("FormLog")));
					});
				})
				.CreateLogger("default");
		}


	}

}
