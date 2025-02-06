using StockExchangeCity.Base.Coordinates;

namespace StockExchangeCity.Base.Collections
{
    public class QuadTree<T> where T : IPosition
	{
		private class Node
		{
			public float X, Y, Width, Height;
			public List<T> Items = new List<T>();
			public Node[] Children = new Node[4];
		}

		private Node _root;

		public QuadTree(float x, float y, float width, float height)
		{
			_root = new Node
			{
				X = x,
				Y = y,
				Width = width,
				Height = height
			};
		}

		public void Insert(float x, float y, T item)
		{
			Insert(_root, x, y, item);
		}

		private void Insert(Node node, float x, float y, T item)
		{
			if (node.Children == null)
			{
				node.Items.Add(item);

				// Примерное ограничение
				if (node.Items.Count > 4)
				{
					Split(node);
				}
			}
			else
			{
				int index = GetIndex(node, x, y);
				Insert(node.Children[index], x, y, item);
			}
		}

		public List<T> Query(float x, float y, float width, float height)
		{
			var result = new List<T>();
			Query(_root, x, y, width, height, result);
			return result;
		}

		private void Query(Node node, float x, float y, float width, float height, List<T> result)
		{
			if (node.X + node.Width < x ||
				node.Y + node.Height < y ||
				node.X > x + width ||
				node.Y > y + height)
			{
				return;
			}

			result.AddRange(node.Items);

			if (node.Children != null)
			{
				foreach (var child in node.Children)
				{
					Query(child, x, y, width, height, result);
				}
			}
		}

		private void Split(Node node)
		{
			float halfWidth = node.Width / 2;
			float halfHeight = node.Height / 2;

			node.Children = new Node[4];
			node.Children[0] = new Node
			{
				X = node.X,
				Y = node.Y,
				Width = halfWidth,
				Height = halfHeight
			};

			node.Children[1] = new Node
			{
				X = node.X + halfWidth,
				Y = node.Y,
				Width = halfWidth,
				Height = halfHeight
			};

			node.Children[2] = new Node
			{
				X = node.X,
				Y = node.Y + halfHeight,
				Width = halfWidth,
				Height = halfHeight
			};

			node.Children[3] = new Node
			{
				X = node.X + halfWidth,
				Y = node.Y + halfHeight,
				Width = halfWidth,
				Height = halfHeight
			};

			foreach (var item in node.Items)
			{
				// Определяем позицию элемента относительно дочерних нод
				int index = GetIndex(node, item.X, item.Y);

				// Рекурсивно вставляем элемент в соответствующую дочернюю ноду
				Insert(node.Children[index], item.X, item.Y, item);
			}

			node.Items.Clear();
		}

		private int GetIndex(Node node, float x, float y)
		{
			bool left = x < node.X + node.Width / 2;
			bool top = y < node.Y + node.Height / 2;

			if (left)
			{
				return top ? 0 : 2;
			}
			else
			{
				return top ? 1 : 3;
			}
		}
	}
}
