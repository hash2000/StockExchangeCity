using Microsoft.Extensions.Logging;
using OpenTelemetry;
using OpenTelemetry.Logs;
using StockExchangeCity.UI;

namespace StockExchangeCity.CurrentHost.Logger
{
	public class LoggerProcessorForm : BaseProcessor<LogRecord>
	{
		private readonly ILogger _logger;
		private readonly FormLog _formLog;

		public LoggerProcessorForm(ILogger logger, FormLog formLog)
		{
			_logger = logger;
			_formLog = formLog;
		}

		public override void OnEnd(LogRecord data)
		{
			_logger.Log(data.LogLevel, data.Exception, data.Body);
			// TODO: это сильно медленно, нужно както ускорить
			//_formLog.AppendLog(data.LogLevel, data.Exception, data.Body);
			base.OnEnd(data);
		}
	}
}
