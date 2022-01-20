﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_栈
{
    class SeqStack<T> : IStackDS<T>
    {
        private T[] data;
        private int top;

        public SeqStack(int size)
        {
            data=new T[size];
            top = -1;
        }

        public SeqStack() : this(10)
        {
        }
        public int Count
        {
            get { return top + 1; }
        }

        public void Clear()
        {
            top = -1;
        }

        public int GetLength()
        {
            return Count;
        }

        public bool IsEmpty()
        {
            return Count == 0;
        }

        public T Peek()
        {
            return data[top];
        }

        public T Pop()
        {
            T temp = data[top];
            top--;
            return temp;
        }

        public void Push(T item)
        {
            data[top + 1] = item;
            top++;
        }
    }
}
