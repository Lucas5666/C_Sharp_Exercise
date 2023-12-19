using System;
namespace Stack
{
	/// <summary>
	/// 链栈节点
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class Node<T>
	{
		private T data;
		private Node<T> next;

		public Node()
		{
			data = default(T);
			next = null;
		}

		public Node(T data)
		{
			this.data = data;
			next = null;
		}

		public Node(T data,Node<T> next)
		{
			this.data = data;
			this.next = next;
		}

		public Node(Node<T> next)
		{
            data = default(T);
            this.next = next;

        }

		public T Data
		{
			get
			{
				return data;
			}

			set
			{
				data = value;
			}
		}

		public Node<T> Next
		{
			get
			{
				return next;
			}
			set
			{
				next = value;
			}
		}



    }
}

