using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_面向对象编程_继承
{
    class Boss:Enemy
    {
        public new void Move()
        {
            Console.WriteLine("这里是Boss的移动方法");
        }
        public void Attack()
        {
            AI();
            Move();
            Console.WriteLine("Boss正在攻击");
        }
    }
}
