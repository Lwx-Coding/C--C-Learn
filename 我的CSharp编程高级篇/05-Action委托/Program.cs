using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Action委托
{
    class Program
    {
        static void PrintString()
        {
            Console.WriteLine("hello world");
        }

        static void PrintInt(int i )
        {
            Console.WriteLine(i);
        }

        static void PrintString(string str)
        {
            Console.WriteLine(str);
        }

        static void PrintDoubleInt(int i, int j)
        {
            Console.WriteLine(i+j);
        }


        static void Main(string[] args)
        {
            Action a = PrintString;           //Action是系统内置的（预定义）一个委托类型，他可以指向一个没有返回值没有参数的方法
            Action<int> a1 = PrintInt;         //定义了一个Action委托，指向一个没有返回值，拥有一个参数的方法
            Action<string> a2 = PrintString;
            Action<int, int> a3 = PrintDoubleInt;
            a3(11, 22);
            Console.ReadKey();
        }
    }
}
