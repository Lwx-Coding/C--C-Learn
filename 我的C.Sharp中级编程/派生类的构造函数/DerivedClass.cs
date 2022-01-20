using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 派生类的构造函数
{
    class DerivedClass:BaseClass 

    {
        private int y;
        public DerivedClass()
        {
            //调用父类的无参构造函数当我们没有在子类的构造函数中声明调用父类的构造函数，默认会调用父类的无参构造函数
            Console.WriteLine("这个是DerivedClass 无参数的构造函数");
        }
        public DerivedClass(int x, int y) : base(x)
        {
            this.y = y;
            Console.WriteLine(x);
            Console.WriteLine("y赋值完毕");
        }
    }
}
