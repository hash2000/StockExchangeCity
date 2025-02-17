using StockExchangeCity.GameEntities.DataProviders.Abstractions;
using StockExchangeCity.GameEntities.Map;
using StockExchangeCity.UI;
using System.Collections.ObjectModel;

namespace StockExchangeCity.Game.Tools.MapEditor.Views;

public partial class BiomesPage : ContentPage
{
	private readonly IBiomesDataProvider _biomsDataProvider;
	private readonly ObservableItemsViewModel<Biome> _biomesContext = new ObservableItemsViewModel<Biome>();

	public BiomesPage(IBiomesDataProvider biomesDataProvider)
	{
		_biomsDataProvider = biomesDataProvider;

		InitializeComponent();
		BindingContext = _biomesContext;
		Loaded += BiomesPage_Loaded;
	}

	private async void BiomesPage_Loaded(object? sender, EventArgs e)
	{
		await _biomsDataProvider.LoadAsync();

		_biomesContext.Items = new ObservableCollection<Biome>(_biomsDataProvider.Biomes.ToList());
	}
}