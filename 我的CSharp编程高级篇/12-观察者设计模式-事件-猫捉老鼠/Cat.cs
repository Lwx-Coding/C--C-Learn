using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_观察者设计模式_事件_猫捉老鼠
{
    class Cat
    {
        private string name;
        private string color;

        public Cat(string name, string color)
        {
            this.name = name;
            this.color = color;
        }

        //猫进屋（猫的状态发生改变）（被观察者的状态发生改变）
        //public void CatComing(Mouse mouse1,Mouse mouse2,Mouse mouse3)
        //{
        //    Console.WriteLine(color+"的猫"+name+"过来了。喵喵喵....");
        //    mouse1.RunAway();
        //    mouse2.RunAway();
        //    mouse3.RunAway();
        //}
        public void CatComing()
        {
            Console.WriteLine(color + "的猫" + name + "过来了。喵喵喵....");
            if (catCome != null)
                catCome();
        }
        public event Action catCome;       //声明一个事件，发布了一个消息
    }


}
