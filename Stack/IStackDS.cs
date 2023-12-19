using System;
namespace Stack
{
	public interface IStackDS<T>
	{
		int Count { get;}
		int GetLength();
		bool IsEmpty();
		void Clear();
		void Push(T item);
		T Pop();
		T Peek();

	}
}

