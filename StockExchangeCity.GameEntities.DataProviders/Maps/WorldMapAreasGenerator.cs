using Microsoft.Extensions.Logging;
using SkiaSharp;
using StockExchangeCity.GameEntities.DataProviders.Abstractions;
using StockExchangeCity.GameEntities.DataProviders.Builders;
using StockExchangeCity.GameEntities.Map;

namespace StockExchangeCity.GameEntities.DataProviders.Maps
{
	internal class WorldMapAreasGenerator : IWorldMapAreasGenerator
	{
		private readonly ILogger _logger;
		private readonly IBiomesDataProvider _biomes;
		private readonly LocationBuilder _locationBuilder = new LocationBuilder(60);

		public WorldMapAreasGenerator(ILogger logger,
			IBiomesDataProvider biomes)
		{
			_logger = logger;
			_biomes = biomes;
		}

		public async Task<List<Area>> GenerateAsync(SKRect rectangle)
		{
			return await GenerateAsync(
				rectangle.Left,
				rectangle.Top,
				rectangle.Width,
				rectangle.Height);
		}

		public async Task<List<Area>> GenerateAsync(float x, float y, float width, float height)
		{
			var result = new List<Area>((int)Math.Round(width, 0) * (int)Math.Round(height));
			var defaultBiome = _biomes.FindByName("Desert");

			if (defaultBiome == null)
			{
				throw new ArgumentException("Undefined Default biome");
			}

 			_locationBuilder.Build(x, y, width, height, (location) =>
			{
				var biome = _biomes.Find(
					location.Height,
					location.Temperature,
					location.Humidity);

				if (biome == null)
				{
					biome = defaultBiome;
				}

				if (!SKColor.TryParse(biome.Color, out var areaColor))
				{
					areaColor = SKColors.DarkViolet;
				}

				result.Add(new Area
				{
					Location = location,
					Biome = biome,
					Color = areaColor,
				//	Brush = new SolidBrush(areaColor),
					Bounds = new SKRect
					{
						Left = location.X,
						Top = location.Y,
						Right = location.X + 1,
						Bottom =  location.Y + 1,
					}
				});
			});


			return result;
		}

		public async Task LoadAsync()
		{
			_logger.LogInformation("Загрузка карты мира");




		}

		public async Task SaveAsync()
		{
		}
	}
}
