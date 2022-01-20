using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _03_队列
{
    class SeqQueue<T> : IQueue<T>
    {
        private T[] data;
        private int count;   //count表示有多少元素
        private int front;   //队首元素索引减1
        private int rear;

        public SeqQueue(int size)
        {
            data=new T[size];
            count = 0;
            front = -1;
            rear = -1;
        }

        public SeqQueue() : this(10)
        {

        }

        public int Count
        {
            get { return count; }
        }

        public void Clear()
        {
            count = 0;
            front = rear = -1;
        }

        public T Dequeue()
        {
            if (count > 0)
            {
                T temp = data[front + 1];
                front++;
                count--;
                return temp;
            }
            else
            {
                Console.WriteLine("队列为空，无法取得值！");
                return default(T);
            }
            
        }

        public void Enqueue(T item)
        {
            if (count == data.Length)
            {
                Console.WriteLine("队列已经满了，不可用添加新的数据");
            }
            else
            {
                if (rear == data.Length - 1)
                {
                    data[0] = item;
                    rear = 0;
                    count++;
                }
                else
                {
                    data[rear + 1] = item;
                    rear++;
                    count++;
                }

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
            if (count > 0)
            {
                T temp = data[front + 1];
                return temp;
            }
            else
            {
                Console.WriteLine("队列为空，无法取得值！");
                return default(T);
            }
        }
    }
}
