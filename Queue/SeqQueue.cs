using System;
namespace Queue
{
	public class SeqQueue<T>:IQueue<T>
	{
        private T[] data;
        private int count;//表示当前元素个数
        private int front;//队首(队首元素索引减1)
        private int rear;//队尾（队尾元素索引减1）

        public SeqQueue(int size)
        {
            data = new T[size];
            count = 0;
            front = -1;
            rear = -1;
           

        }

        public SeqQueue():this(10)
        {

        }


		
        public int Count
        {
            get
            {
                return count;
            }
        } 

        public void Clear()
        {
            count = 0;
            front = rear = -1;
        }

        public T Dequeue()
        {
            if(count > 0)
            {
                T temp = data[front + 1];
                //return data[front + 1];
                front++;
                count--;
                return temp;
            }
            else
            {
                Console.WriteLine("队列为空");
                return default(T);
            }
        }

        public void Enqueue(T item)
        {
            if(count == data.Length)
            {
                Console.WriteLine("队列已满");
            }
            else
            {
                if(rear == data.Length - 1)
                {
                    data[0] = item;
                    rear = 0;
                }
                else
                {
                    data[rear + 1] = item;
                    rear++;
                }
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
            return data[front + 1];
        }
    }
}

