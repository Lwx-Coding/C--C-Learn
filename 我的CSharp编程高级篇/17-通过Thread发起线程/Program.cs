using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _17_通过Thread发起线程
{
    class Program
    {
        static void DownLoadFile(object FILENAME)     //线程的参数必须是object类 代表可以传入任何参数
        {
            Console.WriteLine("开始下载 线程ID:"+Thread.CurrentThread.ManagedThreadId+FILENAME);
            Thread.Sleep(1000);
            Console.WriteLine("下载完成 线程ID:" + Thread.CurrentThread.ManagedThreadId+FILENAME);
        }
        static void Main(string[] args)
        {
            Thread t = new Thread(DownLoadFile);      //创建出来Thread对象，这个线程并没有启动
            t.Start("xxx.种子");       //开始执行线程


            //Lambda表达式方法
            Thread T = new Thread(() =>
              {
                  Console.WriteLine("开始下载 线程ID:" + Thread.CurrentThread.ManagedThreadId);
                  Thread.Sleep(1000);
                  Console.WriteLine("下载完成 线程ID:" + Thread.CurrentThread.ManagedThreadId);
              });
            T.Start();

            //MyThred myThred=new MyThred("xxx.bt","http://www.xxx.con");
            //Thread tt=new Thread(myThred.DownLoad);//我们构造一个Thread对象的时候，可以传递一个静态方法，也可以传递一个对象的普通方法
            //tt.Start();




            //没有说明的Thread都是前台进程 前台进程就是进程
            //当前台进程执行完了，无论后台进程执行的怎么样，都会被强制关闭
            MyThred myThred1 = new MyThred("xxx.bt", "http://www.xxx.con");
            Thread tt1 = new Thread(myThred1.DownLoad);//我们构造一个Thread对象的时候，可以传递一个静态方法，也可以传递一个对象的普通方法
            tt1.IsBackground = true;
            tt1.Start();
            Console.WriteLine("main");

            //t.Abort();             //终止这个线程的执行
            t.Join();              //让当前线程休眠，等待t线程执行完，然后继续运行下面的代码
            Console.ReadKey();
        }
    }
}
