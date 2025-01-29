using Microsoft.Extensions.Logging;
using StockExchangeCity.GameEntities.DataProviders.Abstractions;
using StockExchangeCity.GameEntities.DataProviders.Builders;
using StockExchangeCity.GameEntities.Map;
using StockExchangeCity.GameUsers;
using System.Buffers;

namespace StockExchangeCity.GameEntities.DataProviders.Maps
{
	internal class MapsDataProvider : IMapsDataProvider
	{
		private readonly ILogger _logger;
		private readonly IGameUsersRepository _users;
		private readonly IBiomesDataProvider _biomes;
		private readonly ArrayPool<Location> _locations;

		public MapsDataProvider(ILogger logger,
			IGameUsersRepository users,
			IBiomesDataProvider biomes)
		{
			_logger = logger;
			_users = users;
			_biomes = biomes;
		}

		public async Task<List<Area>> GenerateAsync(int x, int y, int width, int height, int speed)
		{
			var builder = new LocationBuilder(x, y, width, height, speed);
			var result = new List<Area>(width * height);

			builder.Build((location) =>
			{
				var biome = _biomes.Find(
					location.Height,
					location.Temperature,
					location.Humidity);

				if (biome == null)
				{
					_logger.LogError($"Не удалось найти биом по высоте: {location.Height}, температуре: {location.Temperature}, влажности: {location.Humidity}");
					return;
				}

				result.Add(new Area
				{
					Location = location,
					Biome = biome,
					Color = ColorTranslator.FromHtml(biome.Color)
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
