//下面的是引入命名空间
using System;            
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//定义命名空间 从{开始，到}结束
namespace _001_我的第一个C.sharp编程
{

    //定义类
    class Program
    {
        //定义一个Main方法
        static void Main(string[] args)
        {
            //方法体         //ctrl+z撤销删除
            Console.Write("Hello world");
            Console.WriteLine("Hello world");//运行完后换行
            Console.WriteLine("hhhhh{0}+{1}={1}", 1, 23);   //替换值，标记0 是1 标记1是23
            Console.ReadKey();
 

        }
    }
}
