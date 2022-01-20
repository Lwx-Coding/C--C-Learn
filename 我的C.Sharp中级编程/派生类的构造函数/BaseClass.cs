using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 派生类的构造函数
{
    class BaseClass
    {
        private int x;
        protected int z;  //和private差不多，唯一不同的是protected可以在子类中进行访问

        public BaseClass()
        {
            Console.WriteLine("base class 无参构造函数");
        }
        public BaseClass(int x)
        {
            this.x = x;
            Console.WriteLine("x赋值完毕"+x);
        }
    }
}
