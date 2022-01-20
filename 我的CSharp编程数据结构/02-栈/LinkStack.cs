using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_栈
{
    class LinkStack<T> : IStackDS<T>
    {
        private Node<T> top;//栈顶元素结点
        private int count = 0;//栈中元素的个数

        public int Count
        {
            get { return count; }
        }

        public void Clear()
        {
            count = 0;
            top = null;
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
            return top.Data;
        }

        public T Pop()
        {
            Node<T> Temp = top;
            top = top.Next;
            count--;
            return Temp.Data;
        }

        public void Push(T item)
        {
            //把新添加的元素作为头结点(栈顶)
            Node<T> newNode=new Node<T>(item);
            newNode.Next = top;
            top = newNode;
            count++;
        }
    }
}
