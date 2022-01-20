using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _053_委托的使用
{
    //定义一个委托跟函数差不多，区别在于
    //定义委托需要加上delegate关键字
    //委托的定义不需要函数体
    public delegate double MyDelegate(double x1, double x2);
    class Program
    {static double Multiply(double param1,double param2)
        {
            return param1 * param2;
        }
        static double Divide(double param1,double param2)
        {
            return param1 / param2;
        }
        static void Main(string[] args)
        {
            MyDelegate de; //利用我们定义的委托类型声明了一个新的变量
            de = Multiply;//当我们给一个委托的变量赋值的时候，返回值跟参数列表必须一样，否则无法赋值

            Console.WriteLine(de(2.0, 34.1));
            de = Divide;
            Console.WriteLine(de(2.0, 34.1));
            Console.ReadKey();
        }
    }
}
