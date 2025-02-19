using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockExchangeCity.GameEntities.Map
{
	/// <summary>
	/// Населённый пункт
	/// </summary>
	public class Settlement
	{
		/// <summary>
		/// Уникальный идентификатор НП
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// Название НП
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Тип НП
		/// </summary>
		public int Type { get; set; }

		/// <summary>
		/// Биомы, которые занимает НП
		/// </summary>
		public List<MapLocation> OccupiedBiomes { get; set; } = new List<MapLocation>();

		/// <summary>
		/// Связанные НП
		/// </summary>
		public List<Settlement> ConnectedSettlements { get; set; } = new List<Settlement>();
	}
}
