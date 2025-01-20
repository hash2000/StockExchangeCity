using StockExchangeCity.GameEntities;
using StockExchangeCity.GameEntities.Map;
using System.Drawing;

namespace StockExchangeCity.Tool.MapEditor
{
	public partial class Desktop : Form
	{
		private readonly IServiceProvider _serviceProvider;
		private readonly IBiomesDataProvider _biomsDataProvider;

		public Desktop(IServiceProvider serviceProvider, IBiomesDataProvider biomsDataProvider)
		{
			InitializeComponent();

			_serviceProvider = serviceProvider;
			_biomsDataProvider = biomsDataProvider;
		}

		private void Desktop_Load(object sender, EventArgs e)
		{
			_biomsDataProvider.Load();
			var biomes = _biomsDataProvider.Biomes;
			foreach (var biome in biomes)
			{
				ListBiomes.Items.Add(biome.Value);
			}

		}

		private void ListBiomes_SelectedIndexChanged(object sender, EventArgs e)
		{
			var biome = ListBiomes.SelectedItem as Biome;

			TxtColor.Text = biome.Color;
			TxtHeightMin.Text = biome.Height.Min.ToString();
			TxtHeightMax.Text = biome.Height.Max.ToString();
			TxtTempMin.Text = biome.Temperature.Min.ToString();
			TxtTempMax.Text = biome.Temperature.Max.ToString();
			TxtHumedityMin.Text = biome.Humidity.Min.ToString();
			TxtHumedityMax.Text = biome.Humidity.Max.ToString();
			ColorBiome.Color = ColorTranslator.FromHtml(biome.Color);
			PanelBiomeColor.BackColor = ColorBiome.Color;
		}

		private void PanelBiomeColor_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if(ColorBiome.ShowDialog() == DialogResult.OK)
			{
				PanelBiomeColor.BackColor = ColorBiome.Color;
				TxtColor.Text = ColorTranslator.ToHtml(ColorBiome.Color);
			}
		}
	}
}
