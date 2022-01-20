using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_观察者设计模式_事件_猫捉老鼠
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat=new Cat("加菲猫","黄色");
            Mouse mouse1=new Mouse("米奇","黑色",cat);
            Mouse mouse2=new Mouse("唐老鸭","红色",cat);
            Mouse mouse3=new Mouse("xx","红色",cat);
            cat.CatComing();

            Console.ReadKey();
        }
    }
}
