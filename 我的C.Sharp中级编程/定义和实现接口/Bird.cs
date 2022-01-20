using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 定义和实现接口
{
    class Bird : IFly, iB  //接口的方法必须要实现
    {
        public void Fly()
        {
            throw new NotImplementedException();
        }

        public void method1()
        {
            throw new NotImplementedException();
        }

        public void method2()
        {
            throw new NotImplementedException();
        }

        public void MethodA()
        {
            throw new NotImplementedException();
        }
    }
}
