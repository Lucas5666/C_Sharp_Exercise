﻿using System;
namespace Queue
{
	public class LinkQueue<T>:IQueue<T>
	{
        private Node<T> front;
        private Node<T> rear;
        private int count;//元素个数

		public LinkQueue()
		{
            front = null;
            rear = null;
            count = 0;
		}

        public int Count
        {
            get { return count; }
        }

        public void Clear()
        {
            front = rear = null;
            count = 0;
        }

        public T Dequeue()
        {
            if(count == 0)
            {
                Console.WriteLine("队列为空");
                return default(T);
            }
            else if(count == 1)
            {
                T temp = front.Data;
                front = rear = null;
                count = 0;
                return temp;
            }
            else
            {
                T temp = front.Data;
                front = front.Next;
                count--;
                return temp;

            }
        }

        public void Enqueue(T item)
        {
            Node<T> newNode = new Node<T>(item);

            if(count == 0)
            {
                front = newNode;
                rear = newNode;
                count = 1;
            }
            else
            {
                rear.Next = newNode;
                rear = newNode;
                count++;
            }
        }

        public int GetLength()
        {
            return count;
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        public T Peek()
        {
            if(front != null)
            {
                return front.Data;
            }
            else
            {
                return default(T);
            }
        }
    }
}

