using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_栈
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.使用BCL中的Stack<T>
            //Stack<char> stack=new Stack<char>();
            
            //2.使用我们自己的栈
            //IStackDS<char> stack=new SeqStack<char>(30);   //用类去实现接口

            //3.使用我们自己的链栈
            LinkStack<char> stack=new LinkStack<char>();

            stack.Push('a');
            stack.Push('b');
            stack.Push('c');
            Console.WriteLine(stack.Count);
            char temp = stack.Pop();   //取得栈顶数据 并把栈顶数据删除
            Console.WriteLine("pop取得的数据为:"+temp);
            Console.WriteLine("pop之后的数据个数为:"+stack.Count);
            char temp1 = stack.Peek();   //取得栈顶数据 不删除
            Console.WriteLine("Peek取得的数据为:" + temp1);
            Console.WriteLine("Peek之后的数据个数为:" + stack.Count);

            stack.Clear();
            Console.WriteLine("Clear之后的数据个数为:" + stack.Count);

            //Console.WriteLine("空栈状况下取得栈顶的值:"+stack.Peek());   //会出现异常

            Console.ReadKey();
        }
    }
}
