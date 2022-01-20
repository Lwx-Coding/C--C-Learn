using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 我的C.Sharp中级编程
{
    class Customer
    {
        public string name;
        public string address;
        public int age;
        public string buytime;

        public void show()
        {
            Console.WriteLine("姓名:" + name);
            Console.WriteLine("地址:" + address);
            Console.WriteLine("年龄:" + age);
            Console.WriteLine("购买时间:" + buytime);

        }
    }
}
