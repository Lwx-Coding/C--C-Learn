﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_队列
{
    class LinkQueue<T> : IQueue<T>
    {
        private Node<T> front;//头结点
        private Node<T> rear;//尾结点
        private int count;

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
            front = null;
            rear = null;
            count = 0;
        }

        public T Dequeue()
        {
            if (count == 0)
            {
                Console.WriteLine("队列为空！");
                return default(T);
            }
            else if (count == 1)
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
            Node<T> newNode=new Node<T>(item);
            if (count == 0)
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
            if (count == 0)
            {
                Console.WriteLine("队列为空！");
                return default(T);
            }
            else
            {
                T temp = front.Data;
                return temp;
            }
        }
    }
}
