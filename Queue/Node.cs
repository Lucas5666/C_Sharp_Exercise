using System;
namespace Queue
{
	public class Node<T>
	{
		private T data;
		private Node<T> next;

		public Node(T data)
		{
			this.data = data;
		}

		public T Data
		{
			get { return data; }
			set { data = value; }
		}

		public Node<T> Next
		{
			get { return this.next; }
			set { this.next = value; }
		}
	}
}

