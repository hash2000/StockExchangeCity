using StockExchangeCity.GameEntities.Map;

namespace StockExchangeCity.UI.Biomes;

public partial class BiomeCardView : ContentView
{
	#region BiomeItem
	public static readonly BindableProperty BiomeItemProperty =
	BindableProperty.Create(
		nameof(BiomeItem), typeof(BiomeViewModel), typeof(BiomeCardView));

	public BiomeViewModel BiomeItem
	{
		get => (BiomeViewModel)GetValue(BiomeItemProperty);
		set => SetValue(BiomeItemProperty, value);
	}
	#endregion


	public BiomeCardView()
	{
		InitializeComponent();
	}

}