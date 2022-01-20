using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型类
{
    class ClassA<T> //T代表一个数据类型，当你使用ClassA进行构造的时候，需要声明T的类型
    {
        private T a;
        private T b;

        public ClassA(T a, T b)
        {
            this.a = a;
            this.b = b;
        }
        public string getsum()
        {
            return a + "" + b;
        }
    }
}
