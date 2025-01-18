using Microsoft.Extensions.Logging;

namespace StockExchangeCity.UI
{
	public partial class FormLog : Form
	{
		public FormLog()
		{
			InitializeComponent();
		}

		public void AppendLog(LogLevel logLevel, Exception? exception, string? msg)
		{
			if (!Visible)
			{
				Invoke((MethodInvoker)delegate
				{
					Show();
				});
			}

			TextLog.Invoke((MethodInvoker)delegate
			{
				TextLog.Text += $"[{logLevel}]: ";

				if (!string.IsNullOrEmpty(msg))
				{
					TextLog.Text += msg + " ";
				}

				if (exception != null)
				{
					TextLog.Text += $"<{exception}>";
				}

				TextLog.Text += "\r\n";
			});
		}

		private void BtClear_Click(object sender, EventArgs e)
		{
			TextLog.Invoke((MethodInvoker)delegate
			{
				TextLog.Clear();
			});
		}

		private void FormLog_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			Hide();
		}
	}
}
