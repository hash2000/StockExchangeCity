namespace StockExchangeCity.UI.Biomes;

public partial class BiomeCardView : ContentView
{
	#region BiomeItem
	public static readonly BindableProperty BiomeItemProperty =
	BindableProperty.Create(
		nameof(BiomeItem), typeof(BiomeCardViewModel), typeof(BiomeCardView));

	public BiomeCardViewModel BiomeItem
	{
		get => (BiomeCardViewModel)GetValue(BiomeItemProperty);
		set => SetValue(BiomeItemProperty, value);
	}
	#endregion


	public BiomeCardView()
	{
		InitializeComponent();
	}

}