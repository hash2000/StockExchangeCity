namespace StockExchangeCity.GameEntities.Map
{
	public class Range
	{
		public float Min { get; set; }

		public float Max { get; set; }

		public bool IsFits(float value)
		{
			return Min <= value && value <= Max;
		}
	}
}
