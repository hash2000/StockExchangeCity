using StockExchangeCity.GameEntities.Map;

namespace StockExchangeCity.GameEntities.DataProviders.Builders
{
	public class LocationBuilder
	{
		public float TemperatureIncrement { get; set; } = 0.3f;
		public int TemperatureHeightMax { get; set; } = 60;
		public int TemperatureDefault { get; set; } = 20;
		public float TemperatureScale { get; set; } = 0.001f;

		public float HumidityTemperature { get; set; } = 1.3f;
		public float HumidityHeighTemperature { get; set; } = 23f;
		public float HumidityLowTemperature { get; set; } = 2f;
		public float HumidityHeight { get; set; } = 0.2f;
		public float HumidityScale { get; set; } = 0.003f;

		private readonly Perlin2D _noiseGen;

		private int _xPos = 0;
		private int _yPos = 0;
		private int _mapWidth = 0;
		private int _mapHeight = 0;
		private float _fluctuation = 0;
		private float _scale = 0.005f;
		private float _fluctuationMax = 0f;
		private int HeightMax = 255;

		public LocationBuilder(int x, int y, int width, int height, int speed = 70)
		{
			_noiseGen = new Perlin2D(speed);
			_xPos = x;
			_yPos = y;
			_mapWidth = width;
			_mapHeight = height;
		}

		public void Build(Action<Location> action)
		{
			for (int x = 0; x < _mapWidth; x++)
			{
				for (int y = 0; y < _mapHeight; y++)
				{
					int worldX = x + _xPos;
					int worldY = y + _yPos;

					float humidityNoise = _noiseGen.Noise(
						worldX * HumidityScale,
						worldY * HumidityScale * 100 - 50);

					float highNoise = _noiseGen.Noise(
						worldX * _scale,
						worldY * _scale);

					int height = (int)Math.Round(Map(highNoise, 0f, 1f, 0f, HeightMax));
					float temperature = CalcTemperature(worldX, worldY, height);
					float humidity = CalcHumidity(worldX, worldY, temperature);

					var location = new Location();

					location.Height = height;
					location.Temperature = temperature;
					location.Humidity = humidity;
					location.X = worldX;
					location.Y = worldY;

					action(location);
				}
			}
		}

		private static float Map(float value,
			float istart, float istop,
			float ostart, float ostop)
		{
			return ostart + (ostop - ostart) * ((value - istart) / (istop - istart));
		}

		private float CalcTemperature(int x, int y, int h)
		{
			var noise = _noiseGen.Noise(
				x * TemperatureScale,
				y * TemperatureScale * TemperatureHeightMax);
			var temperature = TemperatureDefault - Math.Abs(h - TemperatureHeightMax) *
				TemperatureIncrement + noise;

			return temperature;
		}

		private float CalcHumidity(int x, int y, float temp)
		{
			float humidityNoise = _noiseGen.Noise(
				x * HumidityScale,
				y * HumidityScale) * 100 - 50;

			if (temp > HumidityHeighTemperature)
				temp -= temp - HumidityHeighTemperature;
			else if (temp < HumidityLowTemperature)
				temp += HumidityLowTemperature - temp;

			return humidityNoise + temp * HumidityTemperature;
		}

	}
}
