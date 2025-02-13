namespace StockExchangeCity.UI.Biomes;

public class BiomeCardView : ContentView
{
	#region Name
	public static readonly BindableProperty NameProperty = 
		BindableProperty.Create(
			nameof(Name), typeof(string), typeof(BiomeCardView), string.Empty);

	public string Name
	{
		get => (string)GetValue(NameProperty);
		set => SetValue(NameProperty, value);
	}
	#endregion

	#region HeightMin
	public static readonly BindableProperty HeightMinProperty =
		BindableProperty.Create(
			nameof(HeightMin), typeof(float), typeof(BiomeCardView), 0);

	public float HeightMin
	{
		get => (float)GetValue(HeightMinProperty);
		set => SetValue(HeightMinProperty, value);
	}
	#endregion

	#region HeightMax
	public static readonly BindableProperty HeightMaxProperty =
		BindableProperty.Create(
			nameof(HeightMax), typeof(float), typeof(BiomeCardView), 0);

	public float HeightMax
	{
		get => (float)GetValue(HeightMaxProperty);
		set => SetValue(HeightMaxProperty, value);
	}
	#endregion

	#region TemperatureMin
	public static readonly BindableProperty TemperatureMinProperty =
		BindableProperty.Create(
			nameof(TemperatureMin), typeof(float), typeof(BiomeCardView), 0);

	public float TemperatureMin
	{
		get => (float)GetValue(TemperatureMinProperty);
		set => SetValue(TemperatureMinProperty, value);
	}
	#endregion

	#region TemperatureMax
	public static readonly BindableProperty TemperatureMaxProperty =
		BindableProperty.Create(
			nameof(TemperatureMax), typeof(float), typeof(BiomeCardView), 0);

	public float TemperatureMax
	{
		get => (infloatt)GetValue(TemperatureMaxProperty);
		set => SetValue(TemperatureMaxProperty, value);
	}
	#endregion

	#region HumidityMin
	public static readonly BindableProperty HumidityMinProperty =
		BindableProperty.Create(
			nameof(HumidityMin), typeof(float), typeof(BiomeCardView), 0);

	public float HumidityMin
	{
		get => (float)GetValue(HumidityMinProperty);
		set => SetValue(HumidityMinProperty, value);
	}
	#endregion

	#region HumidityMax
	public static readonly BindableProperty HumidityMaxProperty =
		BindableProperty.Create(
			nameof(HumidityMax), typeof(float), typeof(BiomeCardView), 0);

	public float HumidityMax
	{
		get => (float)GetValue(HumidityMaxProperty);
		set => SetValue(HumidityMaxProperty, value);
	}
	#endregion

	#region Color
	public static readonly BindableProperty ColorProperty =
		BindableProperty.Create(
			nameof(Color), typeof(string), typeof(BiomeCardView), 0);

	public string Color
	{
		get => (string)GetValue(ColorProperty);
		set => SetValue(HumidityMaxProperty, value);
	}
	#endregion

	public BiomeCardView()
	{
		Content = new VerticalStackLayout
		{
			Children =
			{
				new Label
				{
					HorizontalOptions = LayoutOptions.Start,
					VerticalOptions = LayoutOptions.Center,
					Text = Name
				}
			}
		};
	}
}