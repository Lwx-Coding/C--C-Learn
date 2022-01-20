using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_面向对象编程_继承
{
    class Program
    {
        static void Main(string[] args)
        {
            //Boss boss = new Boss();
            //boss.AI();
            //boss.Attack();


            //父类用子类实例化  变量依然属于父类类型
            //Enemy enemy;
            //enemy = new Boss();     //向上转型，自动完成
            //enemy.Move();



            //子类无法通过父类实例化 但是如果父类本来就是用子类实例化的时候  通过强制类型转化
            //Enemy enemy =new Boss();
            //Boss boss = (Boss)enemy;
            //boss.Move();


            // Boss boss = (Boss)enemy;
            //boss.Attack();


            Console.ReadKey();
        }
    }
}
