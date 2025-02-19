using StockExchangeCity.GameEntities.Map;

namespace StockExchangeCity.UI.Biomes;

public partial class BiomeCardView : ContentView
{
	#region BiomeName
	public static readonly BindableProperty BiomeNameProperty =
		BindableProperty.Create(
			nameof(BiomeName), typeof(string), typeof(BiomeCardView), string.Empty);

	public string BiomeName
	{
		get => (string)GetValue(BiomeNameProperty);
		set => SetValue(BiomeNameProperty, value);
	}
	#endregion

	#region HeightMin
	public static readonly BindableProperty HeightMinProperty =
		BindableProperty.Create(
			nameof(HeightMin), typeof(float), typeof(BiomeCardView), 0f);

	public float HeightMin
	{
		get => (float)GetValue(HeightMinProperty);
		set => SetValue(HeightMinProperty, value);
	}
	#endregion

	#region HeightMax
	public static readonly BindableProperty HeightMaxProperty =
		BindableProperty.Create(
			nameof(HeightMax), typeof(float), typeof(BiomeCardView), 0f);

	public float HeightMax
	{
		get => (float)GetValue(HeightMaxProperty);
		set => SetValue(HeightMaxProperty, value);
	}
	#endregion

	#region TemperatureMin
	public static readonly BindableProperty TemperatureMinProperty =
		BindableProperty.Create(
			nameof(TemperatureMin), typeof(float), typeof(BiomeCardView), 0f);

	public float TemperatureMin
	{
		get => (float)GetValue(TemperatureMinProperty);
		set => SetValue(TemperatureMinProperty, value);
	}
	#endregion

	#region TemperatureMax
	public static readonly BindableProperty TemperatureMaxProperty =
		BindableProperty.Create(
			nameof(TemperatureMax), typeof(float), typeof(BiomeCardView), 0f);

	public float TemperatureMax
	{
		get => (float)GetValue(TemperatureMaxProperty);
		set => SetValue(TemperatureMaxProperty, value);
	}
	#endregion

	#region HumidityMin
	public static readonly BindableProperty HumidityMinProperty =
		BindableProperty.Create(
			nameof(HumidityMin), typeof(float), typeof(BiomeCardView), 0f);

	public float HumidityMin
	{
		get => (float)GetValue(HumidityMinProperty);
		set => SetValue(HumidityMinProperty, value);
	}
	#endregion

	#region HumidityMax
	public static readonly BindableProperty HumidityMaxProperty =
		BindableProperty.Create(
			nameof(HumidityMax), typeof(float), typeof(BiomeCardView), 0f);

	public float HumidityMax
	{
		get => (float)GetValue(HumidityMaxProperty);
		set => SetValue(HumidityMaxProperty, value);
	}
	#endregion

	#region BiomeColorHtml
	public static readonly BindableProperty BiomeColorHtmlProperty =
		BindableProperty.Create(
			nameof(BiomeColorHtml), typeof(string), typeof(BiomeCardView), String.Empty);

	public string BiomeColorHtml
	{
		get => (string)GetValue(BiomeColorHtmlProperty);
		set => SetValue(BiomeColorHtmlProperty, value);
	}
	#endregion

	#region BiomeColor
	public static readonly BindableProperty BiomeColorProperty =
		BindableProperty.Create(
			nameof(BiomeColor), typeof(Color), typeof(BiomeCardView), Colors.Black);

	public Color BiomeColor
	{
		get => (Color)GetValue(BiomeColorProperty);
		set => SetValue(HumidityMaxProperty, value);
	}
	#endregion

	#region CardColor
	public static readonly BindableProperty CardColorProperty =
	BindableProperty.Create(
		nameof(CardColor), typeof(Color), typeof(BiomeCardView), Colors.White);

	public Color CardColor
	{
		get => (Color)GetValue(CardColorProperty);
		set => SetValue(CardColorProperty, value);
	}
	#endregion

	#region CardBorderColor
	public static readonly BindableProperty CardBorderColorProperty =
	BindableProperty.Create(
		nameof(CardBorderColor), typeof(Color), typeof(BiomeCardView), Colors.DarkGray);

	public Color CardBorderColor
	{
		get => (Color)GetValue(CardBorderColorProperty);
		set => SetValue(CardBorderColorProperty, value);
	}
	#endregion

	#region BiomeItem
	public static readonly BindableProperty BiomeItemProperty =
	BindableProperty.Create(
		nameof(BiomeItem), typeof(Biome), typeof(BiomeCardView));

	public Biome BiomeItem
	{
		get => (Biome)GetValue(BiomeItemProperty);
		set
		{
			AppendModel(value);
			SetValue(BiomeItemProperty, value);
		}
	}
	#endregion


	public BiomeCardView()
	{
		InitializeComponent();
	}

	private void AppendModel(Biome biome)
	{
		BiomeName = biome.Name;
		BiomeColorHtml = biome.Color;
		HeightMin = biome.Height.Min;
		HeightMax = biome.Height.Max;
		TemperatureMin = biome.Temperature.Min;
		TemperatureMax = biome.Temperature.Max;
		HumidityMin = biome.Humidity.Min;
		HumidityMax = biome.Humidity.Max;
	}
}