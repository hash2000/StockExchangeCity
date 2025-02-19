using StockExchangeCity.Base.Generators;
using StockExchangeCity.GameEntities.Map;

namespace StockExchangeCity.GameEntities.DataProviders.Builders
{
	public class LocationBuilder
	{
		public float MinTemperature { get; set; } = -40;
		public float MaxTemperature { get; set; } = 30;
		public float MinHeight { get; set; } = 0;
		public float MaxHeight { get; set; } = 255;
		public float MinHumidity { get; set; } = 0;
		public float MaxHumidity { get; set; } = 100;
		public float HumidityCoefficient { get; set; } = 6f;

		public float NoiseScale = 0.05f;


		private readonly Perlin2D _heightNoise;
		private readonly Perlin2D _temperatureNoise;
		private readonly Perlin2D _humidityNoise;

		public LocationBuilder(int speed = 70)
		{
			_heightNoise = new Perlin2D(speed);
			_temperatureNoise = new Perlin2D(speed + 1);
			_humidityNoise = new Perlin2D(speed + 2);
		}

		public void Build(float xPos, float yPos, float mapWidth, float mapHeight, Action<MapLocation> action)
		{
			

			for (int x = 0; x < mapWidth; x++)
			{
				for (int y = 0; y < mapHeight; y++)
				{
					float worldX = x + xPos;
					float worldY = y + yPos;
					float worldXnoise = worldX * NoiseScale;
					float worldYnoise = worldY * NoiseScale;

					// Генерация высоты, температуры и влажности
					float heightValue = _heightNoise.Noise(worldXnoise, worldYnoise) * 127.5f + 127.5f;
					float temperatureValue = _temperatureNoise.Noise(worldXnoise, worldYnoise) * 35f - 5f;
					float humidityValue = _humidityNoise.Noise(worldXnoise, worldYnoise) * 50f + 50f;

					// Увеличиваем влажность на низких высотах
					if (heightValue < 70) 
					{
						// Увеличиваем влажность
						humidityValue += (70f - heightValue) * HumidityCoefficient ;
					}

					// Корректировка влажности в зависимости от температуры
					if (temperatureValue < 0f)
					{
						// Уменьшаем влажность при низких температурах
						humidityValue *= 0.8f; 
					}
					else if (temperatureValue > 20f)
					{
						// Увеличиваем влажность при высоких температурах
						humidityValue *= 1.2f; 
					}

					// Ограничиваем значения
					heightValue = Math.Clamp(heightValue, MinHeight, MaxHeight);
					temperatureValue = Math.Clamp(temperatureValue, MinTemperature, MaxTemperature);
					humidityValue = Math.Clamp(humidityValue, MinHumidity, MaxHumidity);

					var location = new MapLocation();

					location.Height = heightValue;
					location.Temperature = temperatureValue;
					location.Humidity = humidityValue;
					location.X = worldX;
					location.Y = worldY;

					action(location);
				}
			}
		}
	}
}
