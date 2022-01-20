using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型类
{
    class MyList<T>where T:IComparable
    {
        private T[] array;
        private int count = 0;//表示当前添加的元素的个数

        public MyList(int size)
        {
            if (size >= 0)
            {
                array = new T[size];
            }
        }
        public MyList()
        {
            array = new T[0];
        }
        public int Capacity
        {
            get { return array.Length; }
        }
        public int Count
        {
            get { return count; }
        }
        public void Add(T item)
        {
            if(count==Capacity)//判断元素个数是否如根列表容量一样大
            {
                if (count == 0)
                {
                    array = new T[4];
                }
                else
                {
                    var newArray = new T[Capacity * 2];
                    Array.Copy(array, newArray, count);
                    array = newArray;
                }
            }
            array[count] = item;
            count++;
        }

        public T GetIem(int index)
        {
            if (index >= 0 && index <= count - 1)
            {
                return array[index];
            }
            else
            {
                throw new Exception("索引超出了范围");
            }
        }

        public T this[int index]
        {
            get { return GetIem(index); }//当我们通过索引器取值的时候
            set
            {
                if (index >= 0 && index <= count - 1)
                {
                    array[index] = value;
                }
                else
                {
                    throw new Exception("索引超出了范围");
                }
            }
        }

        public void Insert(int index,T item)
        {
            if (index >= 0 && index <= count - 1)
            {
                if (count == Capacity)
                {
                    var newArray = new T[Capacity * 2];
                    Array.Copy(array, newArray, count);
                    array = newArray;
                }
                for(int i = count - 1; i >= index; i--)
                {
                    array[i] = array[i-1];
                }
                array[index] = item;
                count++;
            }
            else
            {
                throw new Exception("索引超出范围");
            }
        }
        public void RemoveAt(int index)
        {
            if (index >= 0 && index <= count - 1)
            {
                for(int i = index + 1; i < count; i++)
                {
                    array[i - 1] = array[i];
                }
                count--;
            }
            else
            {
                throw new Exception("索引超出范围");
            }
        }
        public int LastindexOf(T item)
        {
            for(int i = count - 1; i >= 0; i--)
            {
                if (array[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }
        public int indexOf(T item)
        {
            for (int i = 0; i <count; i++)
            {
                if (array[i].Equals(item))
                {
                    return i;
                }
            }
            return -1;
        }

        public void sort()
        {
            for(int j = 0; j < count - 1; j++)
            {
                for (int i = j; i < count - 1; i++)
                {
                    if (array[i].CompareTo(array[j]) < 0)
                    {
                        T temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                } 
            }
        }
    }
   
}
