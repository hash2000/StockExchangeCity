using System.Collections.ObjectModel;

namespace StockExchangeCity.UI
{
    public class ObservableItemsViewModel<T> : BindableObject where T : class
	{
		private ObservableCollection<T> _items = new ObservableCollection<T>();

		public ObservableCollection<T> Items
		{
			get => _items;
			set
			{
				_items = value;
				OnPropertyChanged();
			}
		}

	}
}
