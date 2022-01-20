using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 密封类和密封方法
{
    class DerivedClass:BaseClass   //如果BaseClass声明了sealed密封类，则无法被继承
    {
        public sealed override void Move() //我们可以把重写方法声明为密封方法，表示该方法不可以被重写
        {
            base.Move();
        }//密封类可以直接定义，但是密封方法，只能在子类进行定义

    }
}
