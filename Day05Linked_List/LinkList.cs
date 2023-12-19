using System;
using System.Threading.Tasks;

namespace Day05Linked_List
{
    public class LinkList<T> : IListDS<T>
    {
        private Node<T> head;//存储头节点

        public LinkList()
        {
            head = null;
        }


        public T this[int index]
        {
            get
            {
                Node<T> temp = head;
                for (int i = 1; i <= index; i++)
                {
                    temp = temp.Next;
                }
                Node<T> preNode = temp;
                return temp.Data;
            }
        }

        public void Add(T item)
        {
            Node<T> newNode = new Node<T>(item);
            //如果头节点为空 新节点为头节点
            if(head == null)
            {
                head = newNode;
            }
            else
            {
                Node<T> temp = head;
                //访问链表的尾节点
                while (true)
                {
                    if(temp.Next != null)
                    {
                        temp = temp.Next;
                    }
                    else
                    {
                        break;
                    }
                }
                temp.Next = newNode;
            }

        }

        public void Clear()
        {
            head = null;
        }

        public T Delete(int index)
        {
            T data = default(T);

            if(index == 0)
            {
                data = head.Data;
                head = head.Next;
            }
            else
            {
                Node<T> temp = head;
                for (int i = 1; i <= index - 1; i++)
                {
                    temp = temp.Next;
                }
                Node<T> preNode = temp;
                Node<T> currentNode = temp.Next;
                data = currentNode.Data;
                Node<T> nextNode = temp.Next.Next;
                preNode.Next = nextNode;
            }
            return data;
        }

        public T GetEle(int index)
        {
            return this[index];
        }

        public int GetLength()
        {
            if (head == null)
            {
                return 0;
            }
            Node<T> temp = head;
            int count = 1;
            while (true)
            {
                if(temp.Next != null)
                {
                    count++;
                    temp = temp.Next;
                }
                else
                {
                    return count;
                }
                
            }
        }

        public void Insert(T item, int index)
        {
            Node<T> newNode = new Node<T>(item);
            if(index == 0)
            {
                newNode.Next = head;
                head = newNode;
            }
            else
            {
                Node<T> temp = head;
                for(int i = 1;i<= index - 1; i++)
                {
                    temp = temp.Next;
                }
                Node<T> preNode = temp;
                Node<T> currentNode = temp.Next;
                preNode.Next = newNode;
                newNode.Next = currentNode;
            }
        }

        public bool IsEmpty()
        {
            return head == null;
        }

        public int Locate(T value)
        {
            Node<T> temp = head;
            if(temp == null)
            {
                return -1;
            }
            else
            {
                int index = 0;
                while (true)
                {
                    if (temp.Data.Equals(value))
                    {
                        return index;
                    }
                    else
                    {
                        if (temp.Next != null)
                        {
                            temp = temp.Next;
                            index++;
                        }
                        else
                            break;
                    }
                }
                return -1;
            }
        }
    }
}

