using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_线性表
{
    interface IListDS<T>
    {
        int GetLength();
        void Clear();
        bool IsEmpty();
        void Add(T item);
        void Insert(T item, int index);
        T Delete(int index);
        T this[int index] { get; }//索引器
        T GetEle(int index);
        int Locate(T value);

    }
}
