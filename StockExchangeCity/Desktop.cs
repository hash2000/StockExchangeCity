using Microsoft.Extensions.DependencyInjection;
using StockExchangeCity.CurrentHost.HostBuilder;
using StockExchangeCity.Modules.Char;
using StockExchangeCity.UI;

namespace StockExchangeCity
{
	public partial class Desktop : Form
	{
		private readonly IServiceProvider _serviceProvider;

		public Desktop(IServiceProvider serviceProvider)
		{
			InitializeComponent();

			_serviceProvider = serviceProvider;
		}

		private void Descktop_Load(object sender, EventArgs e)
		{
			TabbarGame.SelectedTab = TabGameMap;

			GameHostBuilder.AddLog();
			LoadChars();
			LoadMaps();
		}

		private void LoadChars()
		{
			new PropertiesBuilder().Build(TreeCharProperties);
			TreeCharProperties.ExpandAll();
		}

		private void LoadMaps()
		{
			var gameMap = _serviceProvider.GetRequiredService<PanelWorldMap>();
			gameMap.Dock = DockStyle.Fill;
			TabGameMap.Controls.Add(gameMap);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			_serviceProvider.GetRequiredService<FormConnect>().ShowDialog();
		}

		private void BtLog_Click(object sender, EventArgs e)
		{
			var form = _serviceProvider.GetRequiredService<FormLog>();
			form.Show();
			form.Activate();
		}
	}
}
