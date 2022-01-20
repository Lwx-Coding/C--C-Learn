using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_面向对象编程_继承
{
    abstract class Bird  //一个抽象类 就是一个不完整的模板 要是子类只有部分进行重写，那么可以用抽象函数的方法，要是全部重写，可以用抽象类
    {
        private float speed;
        public void Eat()
        {

        }
        public abstract void Fly();//抽象函数不能标注函数主体

    }
}
