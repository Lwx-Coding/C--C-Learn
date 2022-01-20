using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_接收用户输入的字符串
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();//用来接收用户输入的一行文字
            Console.WriteLine(str);

            string str1 = "123";
            int num = Convert.ToInt32(str1);   //这个方法可以把一个只含整数的字符串转换成int值
            num++;
            Console.WriteLine(num);

            string str2 = Console.ReadLine();
            int num1 = Convert.ToInt32(str2);
            num1++;
            Console.WriteLine(num1);

            string str3 = Console.ReadLine();
            double num2 = Convert.ToDouble(str3);
            Console.WriteLine(num2);

            Console.ReadKey();
        }
    }
}
