using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Func委托
{
    class Program
    {
        static int Test1()
        {
            return 1;
        }

        static int Test2(string str)
        {
            Console.WriteLine(str);
            return 100;
        }

        static int Test3(int i, int j)
        {
            return i + j;
        }
        static void Main(string[] args)
        {
            Func<int> a = Test1;              //Func和Action一样，都是系统内置的。但是Func必须有一个返回值
            Console.WriteLine(a());
            Func<string, int> a1 = Test2;            //Func后面可以接很多类型 最后一个类型是返回类型，前面的类型是参数类型，同时，参数类型必须和方法的参数类型顺序保持一致
            Func<int, int, int> a2 = Test3;          //参数类型可以是0-16个，但是必须要有一个返回类型
            Console.WriteLine(a2(1, 2));
            Console.ReadKey();

        }
    }
}
