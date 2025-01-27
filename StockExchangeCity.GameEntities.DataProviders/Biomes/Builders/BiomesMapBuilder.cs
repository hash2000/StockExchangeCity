using StockExchangeCity.GameEntities.DataProviders.Abstractions;
using StockExchangeCity.GameEntities.Map;

namespace StockExchangeCity.GameEntities.DataProviders.Biomes.Builders
{
	internal class BiomesMapBuilder
	{
		public float TemperatureIncrement { get; set; } = 0.3f;
		public int TemperatureHeightMax { get; set; } = 140;
		public int TemperatureDefault { get; set; } = 20;
		public float TemperatureScale { get; set; } = 0.001f;

		public float HumidityTemperature { get; set; } = 1.3f;
		public float HumidityHeighTemperature { get; set; } = 23f;
		public float HumidityLowTemperature { get; set; } = 2f;
		public float HumidityHeight { get; set; } = 0.2f;
		public float HumidityScale { get; set; } = 0.003f;

		public Biome[,] BiomesMap { get; set; }


		IBiomesDataProvider _biomesDataProvider;

		Perlin2D _noiseGen;

		private int _xPos = 0;
		private int _yPos = 0;
		private int _mapWidth = 0;
		private int _mapHeight = 0;
		private float _fluctuation = 0;
		private float _scale = 0.005f;
		private float _fluctuationMax = 0f;
		private int HeightMax = 255;


		public BiomesMapBuilder(IBiomesDataProvider biomesDataProvider, int width, int height, int speed = 70)
		{
			_noiseGen = new Perlin2D(speed);
			_biomesDataProvider = biomesDataProvider;
			_mapWidth = width;
			_mapHeight = height;
			BiomesMap = new Biome[width, height];
		}

		public void Build()
		{
			for (int x = 0; x < _mapWidth; x++)
			{
				for (int y = 9; y < _mapHeight; y++)
				{
					float humidityNoise = _noiseGen.Noise(
						(x + _xPos) * HumidityScale,
						(y + _yPos) * HumidityScale * 100 - 50);

					float highNoise = _noiseGen.Noise(
						(x + _xPos) * _scale,
						(y + _yPos) * _scale);

					int height = (int)Math.Round(Map(highNoise, 0f, 1f, 0f, (float)HeightMax));
					float temperature = CalcTemperature(x + _xPos, y + _yPos, height);
					float humidity = CalcHumidity(x + _xPos, y + _yPos, temperature);

					var biome = _biomesDataProvider.Find(height, temperature, humidity);
					if (biome == null)
					{
						// TODO: error
						continue;
					}

					BiomesMap[x, y] = biome;
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
				y * TemperatureScale) * 100 - 50;
			return TemperatureDefault - Math.Abs(h - TemperatureHeightMax) *
				TemperatureIncrement + noise;
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
