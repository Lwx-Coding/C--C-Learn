using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_队列
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.使用BCL中的队列
            //Queue<int> queue=new Queue<int>();
            //2.使用我们自己的队列
           // SeqQueue<int> queue=new SeqQueue<int>(30);
           //3.用我们自己的链队列
           LinkQueue<int> queue=new LinkQueue<int>();
            //入队(添加数据)
            queue.Enqueue(23);//队首
            queue.Enqueue(45);
            queue.Enqueue(67);
            queue.Enqueue(89);
            Console.WriteLine("现在队列的大小为:"+queue.Count);

            //出队 取得队首的数据 并删除
            int i = queue.Dequeue();
            Console.WriteLine("取得队首的数据为:"+i);
            Console.WriteLine("Dequeue后的队列长度为:"+queue.Count);
            int j = queue.Peek();
            Console.WriteLine("取得队首的数据为:" + j);
            Console.WriteLine("Peek后的队列长度为:" + queue.Count);
            queue.Clear();

            Console.WriteLine("Clear后的队列个数为:"+queue.Count);
            Console.ReadKey();
        }
    }
}
