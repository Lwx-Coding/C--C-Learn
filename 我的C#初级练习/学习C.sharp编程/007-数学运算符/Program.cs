using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_数学运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 45;
            int num2 = 15;
            //int res1;
            //res1 = num1 + num2;
            int res1 = num1 + num2;
            int res2 = num1 - num2;
            int res3 = num1 * num2;
            int res4 = num1 / num2;
            int res5 = num1 % num2;
            Console.WriteLine("加法的结果是:{0} \n减法的结果是:{1}\n乘法的结果是:{2} \n除法的结果是:{3}\n求余的结果是:{4}\n", res1, res2, res3, res4,res5);
            double res = 123.4 % 2;
            Console.WriteLine(res);    //类似java

            //关于加法运算符的运用
            //1.字符串相加
            string str1 = "刘文鑫";
            string str2 = "handsome";
            string str = str1 + str2;
            Console.WriteLine(str);
            //2.当字符串和一个数字相加的话，首先把数字变成字符串，然后连接起来
            string str3 = "123";
            int str4 = 456;
            string str5 = str3 + str4;
            Console.WriteLine(str5);
        }
    }
}
