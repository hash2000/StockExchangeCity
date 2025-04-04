using StockExchangeCity.GameEntities.DataProviders.Abstractions;
using StockExchangeCity.UI;
using StockExchangeCity.UI.Biomes;
using System.Collections.ObjectModel;

namespace StockExchangeCity.Game.Tools.MapEditor.Views;

public partial class BiomesPage : ContentPage
{
	private readonly IBiomesDataProvider _biomsDataProvider;
	private readonly ObservableItemsViewModel<BiomeCardViewModel> _biomesContext = new ObservableItemsViewModel<BiomeCardViewModel>();

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

		List<BiomeCardViewModel> biomeViewModel = new();
		
		foreach(var item in _biomsDataProvider.Biomes)
		{
			biomeViewModel.Add(new BiomeCardViewModel(item));
		}

		_biomesContext.Items = new ObservableCollection<BiomeCardViewModel>(biomeViewModel);
	}
}