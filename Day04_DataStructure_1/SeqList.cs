using System;
namespace Day04_DataStructure_1
{
    //顺序表实现方式
    public class SeqList<T> : IListDS<T>
    {
        public T this[int index]
        {
            get
            {
                return GetEle(index);
            }

        }

        private T[] data;
        private int count = 0;

        public SeqList(int size)
        {
            data = new T[size];
        }

        public SeqList() : this(10)
        {

        }

        public void Add(T item)
        {
            if (count == data.Length)
                Console.WriteLine("The List is Full !!!");
            data[count] = item;
            count++;
        }

        public void Clear()
        {
            count = 0;
        }

        public T Delete(int index)
        {
            T temp = data[index];
            for(int i = index + 1;i < count; i++)
            {
                data[i - 1] = data[i];
            }
            count--;
            return temp;
        }

        public T GetEle(int index)
        {
            if (index >= 0 && index <= count - 1)
                return data[index];
            else
            {
                Console.WriteLine("Index does not exist");
                return default(T);
            }
        }

        public int GetLength()
        {
            return count;
        }

        public void Insert(T item, int index)
        {
            for(int i = count - 1 ; i >= index ; i--)
            {
                data[i + 1] = data[i];
            }
            data[index] = item;
            count++;
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        public int Locate(T value)
        {
            for(int i = 0;i < count; i++)
            {
                if (data[i].Equals(value))
                    return i;
            }
            return -1;
        }
    }
}

