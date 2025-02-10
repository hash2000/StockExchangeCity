using System.Collections;
using System.Drawing;

namespace StockExchangeCity.Base.Collections
{
	public class QuadTree<T> : IEnumerable<T> where T : IQuadTreeItem
	{
		private const int MaxObjects = 4;
		private const int MaxLevels = 5;

		private readonly List<T> _objects = new();
		private readonly QuadTree<T>?[] _nodes = new QuadTree<T>[4];
		private readonly RectangleF _bounds;
		private readonly int _level;

		public RectangleF Bounds => _bounds;

		public QuadTree(RectangleF bounds, int level = 0)
		{
			_bounds = bounds;
			_level = level;
		}

		public void Clear()
		{
			_objects.Clear();
			for (int i = 0; i < _nodes.Length; i++)
			{
				_nodes[i]?.Clear();
				_nodes[i] = null;
			}
		}

		public void Insert(T item)
		{
			if (!_bounds.IntersectsWith(item.Bounds))
				return;

			if (_nodes[0] != null)
			{
				int index = GetIndex(item.Bounds);
				if (index != -1)
				{
					_nodes[index].Insert(item);
					return;
				}
			}

			_objects.Add(item);

			if (_objects.Count > MaxObjects && _level < MaxLevels && _nodes[0] == null)
			{
				Split();
				RedistributeObjects();
			}
		}

		public List<T> Query(RectangleF area)
		{
			List<T> result = new();
			Query(area, result);
			return result;
		}

		private void Query(RectangleF area, List<T> result)
		{
			if (!_bounds.IntersectsWith(area))
			{
				return;
			}

			foreach (T item in _objects)
			{
				if (area.IntersectsWith(item.Bounds))
				{
					result.Add(item);
				}
			}

			if (_nodes[0] == null) return;

			foreach (var node in _nodes)
			{
				node.Query(area, result);
			}
		}
		private void Split()
		{
			int subWidth = (int)_bounds.Width / 2;
			int subHeight = (int)_bounds.Height / 2;
			int x = (int)_bounds.X;
			int y = (int)_bounds.Y;

			_nodes[0] = new QuadTree<T>(new Rectangle(x, y, subWidth, subHeight), _level + 1);
			_nodes[1] = new QuadTree<T>(new Rectangle(x + subWidth, y, subWidth, subHeight), _level + 1);
			_nodes[2] = new QuadTree<T>(new Rectangle(x, y + subHeight, subWidth, subHeight), _level + 1);
			_nodes[3] = new QuadTree<T>(new Rectangle(x + subWidth, y + subHeight, subWidth, subHeight), _level + 1);
		}

		private void RedistributeObjects()
		{
			for (int i = _objects.Count - 1; i >= 0; i--)
			{
				T item = _objects[i];
				int index = GetIndex(item.Bounds);

				if (index != -1)
				{
					_nodes[index].Insert(item);
					_objects.RemoveAt(i);
				}
			}
		}

		private int GetIndex(RectangleF rect)
		{
			int index = -1;
			double verticalMidpoint = _bounds.X + (_bounds.Width / 2);
			double horizontalMidpoint = _bounds.Y + (_bounds.Height / 2);

			bool topQuadrant = rect.Y < horizontalMidpoint &&
				rect.Y + rect.Height < horizontalMidpoint;
			bool bottomQuadrant = rect.Y > horizontalMidpoint;

			if (rect.X < verticalMidpoint && rect.X + rect.Width < verticalMidpoint)
			{
				if (topQuadrant)
				{
					index = 0;
				}
				else if (bottomQuadrant)
				{
					index = 2;
				}
			}
			else if (rect.X > verticalMidpoint)
			{
				if (topQuadrant)
				{
					index = 1;
				}
				else if (bottomQuadrant)
				{
					index = 3;
				}
			}

			return index;
		}

		public IEnumerator<T> GetEnumerator()
		{
			foreach (T item in _objects)
			{
				yield return item;
			}

			if (_nodes[0] == null)
			{
				yield break;
			}

			foreach (var node in _nodes)
			{
				foreach (T childItem in node)
				{
					yield return childItem;
				}
			}
		}

		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
	}
}
