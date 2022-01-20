#define IsTest1
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _15_特性
{
    //通过制定属性的名字，给属性赋值，这种叫做命名参数
    [MyTest("简单的特性类",ID =100)]//当我们使用特性的时候，后面的Attribute不需要写
    class Program
    {
        [Obsolete("这个方法过时了，请使用NewMethod",true)]
        static void OldMethod()
        {
            Console.WriteLine("OldMethod");
        }

        static void NewMethod()
        {
            Console.WriteLine("NewMethod");
        }
        [Conditional("IsTest1")]   //添加编译宏条件
        static void Test1()
        {
            Console.WriteLine("Test1");
        }

        static void Test2()
        {
            Console.WriteLine("Test2");
        }
        [DebuggerStepThrough]      //如果确认方法没有错误，可以添加语句让debug时跳过
        static void PrintOut(string str, [CallerFilePath] string fileName = "", [CallerLineNumber] int linenumber = 0,
            [CallerMemberName] string method = "")
        {
            Console.WriteLine(str);
            Console.WriteLine(fileName);
            Console.WriteLine(linenumber);
            Console.WriteLine(method);

        }
        static void Main(string[] args)
        {
            //OldMethod();=
            Test1();
            Test2();
            Test1();
            PrintOut("123");  //调用者特性

            Type type = typeof(Program);          //通过typeof+类名也可以获取type对象
            object[] array = type.GetCustomAttributes(false);
            MyTestAttribute mytest=array[0] as MyTestAttribute;
            Console.WriteLine(mytest.Description);
            Console.WriteLine(mytest.ID);
            Console.ReadKey();
        }
    }
}
