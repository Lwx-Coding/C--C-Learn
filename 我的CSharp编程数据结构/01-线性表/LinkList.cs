using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_线性表
{
    class LinkList<T> : IListDS<T>    //alt+enter实现接口
    {
        private Node<T> head;    //存储一个头结点

        public LinkList()
        {
            head = null;
        }

        public T this[int index]
        {
            get
            {
                Node<T> temp = head;
                for (int i = 0; i < index; i++)
                    temp = temp.Next;
                return temp.Date;
            }
        }

        public void Add(T item)
        {
            Node<T> newNode = new Node<T>(item);   //根据新的数据创建一个新的结点
            //如果头结点为空 那么这个新的结点就是头结点
            if (head == null) head = newNode;
            else
            {//如果不为空，那么就把新来的添加到尾部
                //要访问到链表的尾结点
                Node<T> temp = head;
                while (temp.Next != null) temp = temp.Next;
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
            if (index == 0)
            {
                head = head.Next;
            }
            else
            {
                Node<T> preNode = head;
                for (int i = 1; i <= index - 1; i++)
                {
                    preNode = preNode.Next;
                }
                //经过index-1次的移动 preNode在index前一个位置
                data = preNode.Next.Date;
                preNode.Next = preNode.Next.Next;
            }
            return data;
        }

        public T GetEle(int index)
        {
            return this[index];
        }

        public int GetLength()
        {
            if (head == null) return 0;
            Node<T> temp = head;
            int count = 1;
            while (temp.Next != null)
            {
                temp = temp.Next;
                count++;
            }

            return count;
        }

        public void Insert(T item, int index)
        {
            Node<T> newNode=new Node<T>(item);
            if (index == 0)
            {
                newNode.Next = head;
                head = newNode;
            }
            else
            {
                Node<T> temp=head;
                for (int i = 1; i <= index - 1; i++) temp = temp.Next;
                //经过index-1次的遍历，temp为index的前一个
                newNode.Next = temp.Next;
                temp.Next = newNode;
            }
        }
        public bool IsEmpty()
        {
            return head == null;
        }

        public int Locate(T value)
        {
            Node<T> temp = head;
            if (temp == null) return -1;
            int index = 0;
            while (temp.Next != null)
            {
                if (temp.Date.Equals(value)) return index;
                temp = temp.Next;
                index++;

            }

            return -1;
        }

        public void Foreach()
        {
            Node<T> temp = head;
            while (temp.Next != null)
            {
                Console.WriteLine(temp.Date);
            }
        } 
    }
}
