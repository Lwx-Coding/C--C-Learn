using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_面向对象编程_继承
{
    class Enemy
    {
        private float hp;
        private float speed;

        public float HP
        {
            get { return hp; }
            set { hp = value; }
        }

        public float Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public void AI()
        {
            Console.WriteLine("这里是Enemy1的共有ai方法");
        }

        public void Move()
        {
            Console.WriteLine("这里是Enemy1的共有move方法");
        }
        public void A()
        {
            Console.WriteLine("Enemy A");
        }

    }
}
