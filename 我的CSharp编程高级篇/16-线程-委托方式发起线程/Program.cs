using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _16_线程_委托方式发起线程
{
    class Program
    {
        //一般我们会为比较耗时的操作 开启单独的线程去执行，比如下载操作
        static int Test(int i, string str)
        {
            Console.WriteLine("test"+i+str);
            Thread.Sleep(100);  //让当前线程休眠（暂停线程的执行） 单位ms
            return 100;
        }
        static void Main(string[] args)  //在main线程中执行 一个线程里面的语句执行顺序是从上往下的
        {
            //1.通过委托 开启线程
            // Func<int, string, int> a = Test;
            //IAsyncResult ar = a.BeginInvoke(100, "siki", null, null);  //开启一个新的线程去执行 a所引用的方法
            ////IAsyncResult 可以取得当前线程的状态
            ////可以认为线程是同步执行的（异步执行）同时
            //Console.WriteLine("main");

            ////while循环去判断线程是否结束
            //while (ar.IsCompleted == false)     //检测当前是否完成
            //{
            //    //没有完成的话
            //    Console.Write(".");
            //    Thread.Sleep(1);     //控制子线程的检测频率 10ms
            //}

            //int res = a.EndInvoke(ar);                  //获得异步线程的返回值
            //Console.WriteLine(res);


            //第二种方法
            //bool isEnd = ar.AsyncWaitHandle.WaitOne(1000);//1000ms表示时间，
            ////如果在1000ms内完成，就会在完成的时候返回 True。如果在1000ms内没有完成，就会在1000ms的时候返回false
            //if (isEnd)
            //{
            //    int res = a.EndInvoke(ar);
            //    Console.WriteLine(res);
            //}

            //第三种 通过回调函数 检测线程结束
            Func<int, string, int> a = Test;
            //倒数第二个参数是一个委托类型的参数，表示回调函数，就是当线程结束的时候会调用这个委托指向的方法
            //倒数第一个参数用来给回调函数传递参数
            IAsyncResult ar = a.BeginInvoke(100, "siki", OnCallBack, a);

            a.BeginInvoke(100, "siki", ar1 =>
            {
                int res = a.EndInvoke(ar1);
                Console.WriteLine(res + "在Lambda表达式中取得结果");
            }, null);

            Console.ReadKey();
        }

        static void OnCallBack(IAsyncResult ar)
        {
            Func<int, string, int> a = ar.AsyncState as Func<int, string, int>;
            int res = a.EndInvoke(ar);
            Console.WriteLine(res+"在回调函数中取得结果");
        }
    }
}
