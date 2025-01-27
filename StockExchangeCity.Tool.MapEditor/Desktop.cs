using StockExchangeCity.GameEntities.DataProviders.Abstractions;
using StockExchangeCity.GameEntities.Map;
using StockExchangeCity.Tool.MapEditor.ViewModels;
using StockExchangeCity.UI;

namespace StockExchangeCity.Tool.MapEditor
{
	public partial class Desktop : Form
	{
		private readonly IServiceProvider _serviceProvider;
		private readonly IBiomesDataProvider _biomsDataProvider;
		private readonly PanelWorldMap _panelWorldMap;
		private readonly List<Control> _propertiesControls;

		public Desktop(IServiceProvider serviceProvider,
			IBiomesDataProvider biomsDataProvider,
			PanelWorldMap panelWorldMap)
		{
			InitializeComponent();

			_serviceProvider = serviceProvider;
			_biomsDataProvider = biomsDataProvider;
			_panelWorldMap = panelWorldMap;

			_propertiesControls = new List<Control>
			{
				TxtColor,
				TxtHeightMin,
				TxtHeightMax,
				TxtTempMin,
				TxtTempMax,
				TxtHumidityMin,
				TxtHumidityMax,
				PanelBiomeColor,
			};
		}

		private void ApplyBiomeValue(TextBox textBox, Action<Biome, float> action)
		{
			var pBiome = ListBiomes.SelectedItem as BiomeViewModel;
			if (pBiome == null || !textBox.Enabled)
			{
				return;
			}

			var biome = pBiome.Biome;
			if (float.TryParse(textBox.Text, out var value))
			{
				action(biome, value);
				textBox.BackColor = SystemColors.Control;
			}
			else
			{
				textBox.BackColor = Color.MistyRose;
			}
		}

		private void EnableProperties(bool enable)
		{
			_propertiesControls.ForEach(x => x.Enabled = enable);
		}

		private void RestoreProperties()
		{
			_propertiesControls.ForEach(x =>
			{
				x.BackColor = SystemColors.Control;
				x.Text = string.Empty;
			});
		}

		private void ReloadBiomes()
		{
			Task.Run(_biomsDataProvider.LoadAsync).GetAwaiter().GetResult();

			EnableProperties(false);
			RestoreProperties();
			ListBiomes.Items.Clear();

			var biomes = _biomsDataProvider.Biomes;

			foreach (var biome in biomes)
			{
				ListBiomes.Items.Add(new BiomeViewModel
				{
					Biome = biome.Value,
					Name = biome.Value.Name,
				});
			}
		}

		private void Desktop_Load(object sender, EventArgs e)
		{
			ReloadBiomes();

			_panelWorldMap.Dock = DockStyle.Fill;
			_panelWorldMap.BorderStyle = BorderStyle.FixedSingle;
			_panelWorldMap.AutoScroll = false;
			_panelWorldMap.Margin = new Padding
			{
				All = 5
			};

			SplitContainerMapGen.Panel1.Controls.Add(_panelWorldMap);
		}

		private void ListBiomes_SelectedIndexChanged(object sender, EventArgs e)
		{
			EnableProperties(false);
			var pBiome = ListBiomes.SelectedItem as BiomeViewModel;
			var biome = pBiome.Biome;

			TxtColor.Text = biome.Color;
			TxtHeightMin.Text = biome.Height.Min.ToString();
			TxtHeightMax.Text = biome.Height.Max.ToString();
			TxtTempMin.Text = biome.Temperature.Min.ToString();
			TxtTempMax.Text = biome.Temperature.Max.ToString();
			TxtHumidityMin.Text = biome.Humidity.Min.ToString();
			TxtHumidityMax.Text = biome.Humidity.Max.ToString();
			ColorBiome.Color = ColorTranslator.FromHtml(biome.Color);
			PanelBiomeColor.BackColor = ColorBiome.Color;

			EnableProperties(true);
		}

		private void PanelBiomeColor_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (ColorBiome.ShowDialog() == DialogResult.OK)
			{
				PanelBiomeColor.BackColor = ColorBiome.Color;
				TxtColor.Text = ColorTranslator.ToHtml(ColorBiome.Color);
			}
		}

		private void TxtHeightMin_TextChanged(object sender, EventArgs e)
		{
			ApplyBiomeValue(TxtHeightMin, (biome, value) => biome.Height.Min = value);
		}

		private void TxtHeightMax_TextChanged(object sender, EventArgs e)
		{
			ApplyBiomeValue(TxtHeightMax, (biome, value) => biome.Height.Max = value);
		}

		private void TxtTempMin_TextChanged(object sender, EventArgs e)
		{
			ApplyBiomeValue(TxtTempMin, (biome, value) => biome.Temperature.Min = value);
		}

		private void TxtTempMax_TextChanged(object sender, EventArgs e)
		{
			ApplyBiomeValue(TxtTempMax, (biome, value) => biome.Temperature.Max = value);
		}

		private void TxtHumidityMin_TextChanged(object sender, EventArgs e)
		{
			ApplyBiomeValue(TxtHumidityMin, (biome, value) => biome.Humidity.Min = value);
		}

		private void TxtHumidityMax_TextChanged(object sender, EventArgs e)
		{
			ApplyBiomeValue(TxtHumidityMax, (biome, value) => biome.Humidity.Max = value);
		}

		private void TxtColor_TextChanged(object sender, EventArgs e)
		{
			var pBiome = ListBiomes.SelectedItem as BiomeViewModel;
			if (pBiome == null || !TxtColor.Enabled)
			{
				return;
			}

			try
			{
				var color = ColorTranslator.FromHtml(TxtColor.Text);
				ColorBiome.Color = color;
				PanelBiomeColor.BackColor = ColorBiome.Color;
			}
			catch
			{
				TxtColor.BackColor = Color.MistyRose;
			}
		}

		private void BtnSaveBiomes_Click(object sender, EventArgs e)
		{
			var result = MessageBox.Show("Вы действительно хотите сохранить изменения?", "Сохранить?",
				MessageBoxButtons.OKCancel);
			if (result != DialogResult.OK)
			{
				return;
			}

			Task.Run(_biomsDataProvider.SaveAsync).GetAwaiter().GetResult();
			ReloadBiomes();
		}
		private void BtnLoadBiomes_Click(object sender, EventArgs e)
		{
			var result = MessageBox.Show("Вы действительно хотите восстановить предыдущие значения?", "Восстановить?",
				MessageBoxButtons.OKCancel);
			if (result != DialogResult.OK)
			{
				return;
			}

			ReloadBiomes();
		}

		private void BtnGenerateMap_Click(object sender, EventArgs e)
		{

		}

	}
}
