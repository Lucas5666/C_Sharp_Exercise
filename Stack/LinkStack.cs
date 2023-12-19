using System;

namespace Stack
{
    public class LinkStack<T> : IStackDS<T>
    {
        private Node<T> top;//栈顶节点
        private int count = 0;//栈中元素的个数
        //取得栈中元素的个数
        int IStackDS<T>.Count
        {
            get
            {
                return count;
            }
        }

        void IStackDS<T>.Clear()
        {
            count = 0;
            top = null;
        }

        int IStackDS<T>.GetLength()
        {
            return count;
        }
        //判断是否为空
        bool IStackDS<T>.IsEmpty()
        {
            return count == 0;
        }

        T IStackDS<T>.Peek()
        {
            return top.Data;
        }

        T IStackDS<T>.Pop()
        {
            T data = top.Data;
            top = top.Next;
            count--;
            return data;
        }

        //入栈
        void IStackDS<T>.Push(T item)
        {
            Node<T> newNode = new Node<T>(item);
            newNode.Next = top;
            top = newNode;
            count++;
        }
    }
}

