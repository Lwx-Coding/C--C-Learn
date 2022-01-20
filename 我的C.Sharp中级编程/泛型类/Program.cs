using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型类
{
    class Program
    {
        public static string Getsum<T,T2,T3,T4>(T a,T b)
        {
            return a + "" + b;
        }
        static void Main(string[] args)
        {
            var o1 = new ClassA<int>(12, 34);
            string s = o1.getsum();
            Console.WriteLine(s);
            string s1 = Getsum<int,int,int,int>(34, 53);
            Console.WriteLine(s1);

            MyList<int> myList = new MyList<int>();
            myList.Add(12);
            myList.Add(2);
            myList.Add(42);
            myList.Add(15);
            myList.Add(62);
            myList.Add(17);
            myList.Insert(1, -1);
            for (int i = 0; i < myList.Count-1; i++)
            {
                Console.WriteLine(myList[i]);
            }
            Console.WriteLine(myList.indexOf(42));
            Console.WriteLine(myList.LastindexOf(42));
            myList.sort();
            Console.WriteLine();
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i-1]);
            }
            Console.ReadKey();
        }
    }
}
