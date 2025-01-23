using StockExchangeCity.GameEntities;
using StockExchangeCity.GameEntities.Map;
using StockExchangeCity.Tool.MapEditor.ViewModels;

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
			}
			else
			{
				textBox.BackColor = Color.MistyRose;
			}
		}

		private void EnableProperties(bool enable)
		{
			TxtColor.Enabled = enable;
			TxtHeightMin.Enabled = enable;
			TxtHeightMax.Enabled = enable;
			TxtTempMin.Enabled = enable;
			TxtTempMax.Enabled = enable;
			TxtHumedityMin.Enabled = enable;
			TxtHumedityMax.Enabled = enable;
			PanelBiomeColor.Enabled = enable;
		}

		private void ReloadBiomes()
		{
			Task.Run(_biomsDataProvider.LoadAsync).GetAwaiter().GetResult();

			EnableProperties(false);
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
			TxtHumedityMin.Text = biome.Humidity.Min.ToString();
			TxtHumedityMax.Text = biome.Humidity.Max.ToString();
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

		private void TxtHumedityMin_TextChanged(object sender, EventArgs e)
		{
			ApplyBiomeValue(TxtHumedityMin, (biome, value) => biome.Humidity.Min = value);
		}

		private void TxtHumedityMax_TextChanged(object sender, EventArgs e)
		{
			ApplyBiomeValue(TxtHumedityMax, (biome, value) => biome.Humidity.Max = value);
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
	}
}
