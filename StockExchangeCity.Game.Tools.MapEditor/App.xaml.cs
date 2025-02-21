using System.Diagnostics;

namespace StockExchangeCity.Game.Tools.MapEditor
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

#if DEBUG
			// Вывод всех загруженных ресурсов
			// Проверка через 1 секунду после инициализации
			Dispatcher.StartTimer(TimeSpan.FromSeconds(1), () =>
			{
				Debug.WriteLine("Resources loaded: " +
					string.Join(", ", Current?.Resources?.MergedDictionaries.SelectMany(d => d.Keys)));
				return false;
			});

#endif
			MainPage = new AppShell();
		}
	}
}
