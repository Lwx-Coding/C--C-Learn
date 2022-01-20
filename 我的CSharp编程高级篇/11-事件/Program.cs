using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_事件
{
    class Program
    {
        public delegate void MyDelegate();                     //定义了一个委托类型

        //public MyDelegate mydelegate;                         //声明了一个委托类型的变量，作为类的成员

        public event MyDelegate mydelegate;                //声明了一个委托类型的变量，作为类的成员    
        //事件的声明只能放在类里 自身发生改变只有自身知道，不能再外界调用
        //事件是一种特殊的委托，本质上和委托是一样东西，但是是受到限制的委托。
        //事件在外部不可用触发，只能在类的内部合适时机触发，委托可以在外部被触发，但是慎用
        static void Main(string[] args)
        {
            Program P=new Program();
            P.mydelegate = Test1;
            P.mydelegate();
            Console.ReadKey();
        }

        static void Test1()
        {
            Console.WriteLine("1");
        }
    }
}
