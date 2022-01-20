using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_多播委托
{
    class Program
    {
        static void Test1()
        {
            Console.WriteLine("Test1");
        }

        static void Test2()
        {
            Console.WriteLine("Test2");
        }
        static void Main(string[] args)
        {
            Action a = Test1;
            a += Test2;                    //添加一个委托的引用
            if (a != null)
            {
                a();           //当一个委托没有指向任何方法的时候，调用的话会出现异常
            }

            Delegate[] delegates = a.GetInvocationList();
            foreach (var de in delegates)
            {
                de.DynamicInvoke();
            }

            Console.ReadKey();
        }
    }
}
