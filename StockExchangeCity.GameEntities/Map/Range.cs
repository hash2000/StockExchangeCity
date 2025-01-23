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

		public bool IsIntersect(Range range)
		{
			return IsFits(range.Min) || IsFits(range.Max);
		}

		public bool IsIncluded(Range range)
		{
			return IsFits(range.Min) && IsFits(range.Max);
		}
	}
}
