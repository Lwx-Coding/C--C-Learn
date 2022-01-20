using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _20_线程问题_争用条件
{
    class Program
    {
        static void ChangeState(object o)
        {
            MyThreadObject m=o as MyThreadObject;
            while (true)
            {
                lock (m)  //向系统申请可不可以 锁定m对象 如果m对象没有被锁定 那么就可以锁定m对象，如果m已经被锁定了，那么这个语句会暂停，直到申请到m对象
                {
                    m.ChangeState();  //在同一时刻 只有一个线程在执行这个方法
                }//释放对m的锁定
            }
        }
        //因为当一个线程执行的时候会锁定m对象，所以下一个要申请m的时候会等待前一个执行完。
        //所以循环一直下去，没有输出  如果没有锁，两者争夺m的控制权，可能会出现一方m刚赋值5，另一方开始做判断，那么这样就会达到判断条件，输出结果
        static void Main(string[] args)
        {

            //两个线程就是出争用，m的值会被修改
            //MyThreadObject m = new MyThreadObject();
            //Thread t=new Thread(m.ChangeState);
            //t.Start();   //传入参数
            //Thread t1 = new Thread(m.ChangeState);
            //t1.Start();   //传入参数


            //加了锁之后就不会出现这种情况
            MyThreadObject m = new MyThreadObject();
            Thread t = new Thread(ChangeState);
            t.Start(m);   //传入参数

            new Thread(ChangeState).Start(m);

            Console.ReadKey();
        }
    }
}
