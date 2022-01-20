using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _18_线程池
{
    class Program
    {
        static void ThreadMethod(object state)
        {
            Console.WriteLine("线程开始:" + Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(1000);
            Console.WriteLine("线程结束:" + Thread.CurrentThread.ManagedThreadId);
        }
        static void Main(string[] args)
        {
            ThreadPool.QueueUserWorkItem(ThreadMethod);  //开启一个工作线程
            ThreadPool.QueueUserWorkItem(ThreadMethod);
            ThreadPool.QueueUserWorkItem(ThreadMethod);
            ThreadPool.QueueUserWorkItem(ThreadMethod);
            ThreadPool.QueueUserWorkItem(ThreadMethod);
            ThreadPool.QueueUserWorkItem(ThreadMethod);
            Console.ReadKey();
        }
    }
}
