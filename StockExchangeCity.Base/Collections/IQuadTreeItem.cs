using System.Drawing;

namespace StockExchangeCity.Base.Collections
{
	public interface IQuadTreeItem
	{
		RectangleF Bounds { get; }
	}
}
