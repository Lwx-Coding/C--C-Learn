using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_观察者设计模式_事件_猫捉老鼠
{
    class Mouse
    {
        private string name;
        private string color;

        public Mouse(string name, string color,Cat cat)
        {
            this.name = name;
            this.color = color;
            cat.catCome += this.RunAway;//把自身逃跑的方法 注册进 猫里面 订阅消息
        }

        //逃跑功能
        public void RunAway()
        {
            Console.WriteLine(color+"的老鼠"+name+"说：猫来了，快跑啊，快跑！");
        }
    }
}
