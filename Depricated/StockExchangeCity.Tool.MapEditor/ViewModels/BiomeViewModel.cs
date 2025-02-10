using StockExchangeCity.GameEntities.Map;

namespace StockExchangeCity.Tool.MapEditor.ViewModels
{
	internal class BiomeViewModel
	{
		internal class Error
		{
			public bool IsTemperrature { get; set; } = false;

			public bool IsHeight { get; set; }

			public bool IsHumidity { get; set; }
		}

		public Error HasError { get; set; } = new Error();

		public Biome? Biome { get; set; }

		public string Name { get; set; }

		public override string ToString()
		{
			return Name;
		}
	}
}
