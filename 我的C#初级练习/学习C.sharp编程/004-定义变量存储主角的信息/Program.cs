using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_定义变量存储主角的信息
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "奥利给";
            int hp = 94;
            int level = 32;
            float exp = 34.2f;
            Console.WriteLine("姓名:{0}\n血量:{1}\n等级:{2}\n经验:{3}", name, hp, level, exp);
        }
    }
}
