using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_反射和特性
{
    class Myclass
    {
        private int id;
        private int age;
        public int number;
        public string Name { get; set; }
        public string Name2 { get; set; }
        public string Name3 { get; set; }

        public void Test1()
        {
            Console.WriteLine("1");
        }

        public void Test2()
        {
            Console.WriteLine("2");
        }

    }
}
