namespace StockExchangeCity.GameEntities.DataProviders.Builders
{
	internal class Perlin2D
	{

		private int[] permutation;
		private int[] p;

		public Perlin2D(int seed)
		{
			var random = new Random(seed);
			permutation = new int[256];
			p = new int[512];

			for (int i = 0; i < 256; i++)
			{
				permutation[i] = i;
			}

			// Перемешиваем массив permutation
			for (int i = 0; i < 256; i++)
			{
				int j = random.Next(256);
				int temp = permutation[i];
				permutation[i] = permutation[j];
				permutation[j] = temp;
			}

			// Заполняем массив p
			for (int i = 0; i < 256; i++)
			{
				p[i] = permutation[i];
				p[i + 256] = permutation[i];
			}
		}

		private float Fade(float t)
		{
			return t * t * t * (t * (t * 6 - 15) + 10);
		}

		private float Lerp(float t, float a, float b)
		{
			return a + t * (b - a);
		}

		private float Grad(int hash, float x, float y)
		{
			int h = hash & 15;
			float u = h < 8 ? x : y;
			float v = h < 4 ? y : h == 12 || h == 14 ? x : 0;
			return ((h & 1) == 0 ? u : -u) + ((h & 2) == 0 ? v : -v);
		}

		public float Noise(float x, float y)
		{
			int X = (int)Math.Floor(x) & 255;
			int Y = (int)Math.Floor(y) & 255;

			x -= (float)Math.Floor(x);
			y -= (float)Math.Floor(y);

			float u = Fade(x);
			float v = Fade(y);

			int A = p[X] + Y;
			int B = p[X + 1] + Y;

			return Lerp(v, Lerp(u, Grad(p[A], x, y), Grad(p[B], x - 1, y)),
						   Lerp(u, Grad(p[A + 1], x, y - 1), Grad(p[B + 1], x - 1, y - 1)));
		}

	}
}
