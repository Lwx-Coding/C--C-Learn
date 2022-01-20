using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014_列表List的创建和使用
{
    class Program
    {
        static void Main(string[] args)//列表初始大小为4，如果加入的元素个数
            //超过了4，那么会翻倍成8，然后翻成16
        {
            List<int> scrollList = new List<int>();//创建了一个空的列表，通过类型后面的<>来表示这个列表存储的类型
            var scrollList1 = new List<int>();
            var scrollList2 = new List<int>() { 1, 2, 3 };
            Console.WriteLine("capacity:" + scrollList2.Capacity + "count:" + scrollList2.Count);
            scrollList2.Add(4);
            Console.WriteLine("capacity:" + scrollList2.Capacity + "count:" + scrollList2.Count);
            scrollList2.Add(5);
            Console.WriteLine("capacity:" + scrollList2.Capacity + "count:" + scrollList2.Count);
            scrollList2.Insert(4, -1);
            foreach(var temp in scrollList2)
            {
                Console.WriteLine(temp);
            }
            scrollList2.RemoveAt(0);
            foreach (var temp in scrollList2)
            {
                Console.WriteLine(temp);
            }
            int index = scrollList2.IndexOf(4);
            Console.WriteLine(index);
            Console.ReadKey();
        }
    }
}
