using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_委托
{
    class Program
    {
        private delegate string GetAString();                             //定义了一个委托类型，这个委托类型的名字叫做GetAString
        static void Main(string[] args)
        {
            int x = 40;
            string s = x.ToString();     
            Console.WriteLine(s);

            GetAString a=new GetAString(x.ToString);   //a指向了x的Tostring方法
            GetAString a1 = x.ToString;                //第二种方法

            string s1 = a();                            //通过委托实例去调用 x中的tostring方法
            string s2 = a.Invoke();                     //通过Invoke方法调用a所应用的方法
            Console.WriteLine(s2);

            //使用委托类型作为方法的参数
            PrintSTring method = Method1;
            PrintStr(method);
            method = Method2;
            PrintStr(method);
            Console.ReadKey();
        }

        private delegate void PrintSTring();

        static void PrintStr(PrintSTring print)
        {
            print();
        }

        static void Method1()
        {
            Console.WriteLine("1");
        }

        static void Method2()
        {
            Console.WriteLine("2");
        }
    }
}
