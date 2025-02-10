using Microsoft.Extensions.Logging;
using StockExchangeCity.GameEntities.DataProviders.Abstractions;
using StockExchangeCity.GameEntities.DataProviders.Builders;
using StockExchangeCity.GameEntities.Map;
using StockExchangeCity.GameUsers;
using System.Buffers;

namespace StockExchangeCity.GameEntities.DataProviders.Maps
{
	internal class WorldMapAreasGenerator : IWorldMapAreasGenerator
	{
		private readonly ILogger _logger;
		private readonly IGameUsersRepository _users;
		private readonly IBiomesDataProvider _biomes;
		private readonly ArrayPool<Location> _locations;
		private readonly LocationBuilder _locationBuilder = new LocationBuilder(60);

		public WorldMapAreasGenerator(ILogger logger,
			IGameUsersRepository users,
			IBiomesDataProvider biomes)
		{
			_logger = logger;
			_users = users;
			_biomes = biomes;
		}

		public async Task<List<Area>> GenerateAsync(RectangleF rectangle)
		{
			return await GenerateAsync(
				rectangle.X,
				rectangle.Y,
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

				var areaColor = ColorTranslator.FromHtml(biome.Color);

				result.Add(new Area
				{
					Location = location,
					Biome = biome,
					Color = areaColor,
					Brush = new SolidBrush(areaColor),
					Bounds = new RectangleF
					{
						X = location.X,
						Y = location.Y,
						Width = 1,
						Height = 1,
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
