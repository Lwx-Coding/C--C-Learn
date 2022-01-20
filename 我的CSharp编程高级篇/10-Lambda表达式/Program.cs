using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Lambda表达式
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lambda表达式可以用来代替匿名方法，所以一个lambda表达式也是定义了一个方法
            Func<int, int, int> plus = delegate(int arg1, int arg2)
            {
                Console.WriteLine(arg1 + arg2);
                return arg1 + arg2;
            };
            Func<int, int, int> pluss = (arg1, arg2) => //Lambda表达式的参数是不需要声明类型的
            {
                Console.WriteLine(arg1 + arg2);
                return arg1 + arg2;
            };

            Func<int, int> test2 = a => a + 1;//Lambda表达式的参数只有一个的时候，可以不加括号，当函数体的语句只有
                                              //一句话的时候，我们可以不加大括号也可以不加return语句
            Func<int, int> test3 = (a) =>
            {
                return a + 1;
            };
            plus(12, 43);
            pluss(24, 34);
            Console.WriteLine(test2(34));
            Console.WriteLine(test3(34));
            Console.ReadKey();
        }
    }
}
