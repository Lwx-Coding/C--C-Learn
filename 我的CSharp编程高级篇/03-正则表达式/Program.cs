using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03_正则表达式
{
    class Program
    {
        static void Main(string[] args)
        {
            //定位元字符 ^ $
           // string s = "I am blue cat.";
            //string res = Regex.Replace(s, "^", "开始：");
            //Console.WriteLine(res);
            //string res1 = Regex.Replace(s, "$", "结束");
            //Console.WriteLine(res1);

        

            //string s = Console.ReadLine();
            //bool isMatch = true;//默认标志位，表示s是一个合法密码（全部是数字）
            //string pattern = @"^\d*$";//正则表达式
            //string pattern1 = @"^\d*";
            //isMatch = Regex.IsMatch(s, pattern1);
            //Console.WriteLine(isMatch);

            /*
             * 字符	说明
               .	

               \w	匹配字母、数字、下划线、汉字	(指大小写字母、0-9的数字、下划线_)
               \W	\w的补集	（ 除“大小写字母、0-9的数字、下划线_”之外）
               \s	匹配任意空白符	(包括换行符/n、回车符/r、制表符/t、垂直制表符/v、换页符/f)
               \S	\s的补集	(除\s定义的字符之外)
               \d	匹配数字	(0-9数字)
               \D	表示\d的补集	(除0-9数字之外)
               
               
               在正则表达式中，\是转义字符. * 是元字符 如果要表示一个\ . *字符的话，需要使用\\ \. \*
               
             */
            //string res = "I am a cat";
            //string pattern = @"[^ahou]";//它代表一个字符，除了ahou的任何一个
            //string s = Regex.Replace(res, pattern, "*");
            //Console.WriteLine(s);

            //重复描述字符
            //string qq1 = "234234";
            //string qq2 = "234234234234234";
            //string qq3 = "d423423423";
            //string pattern = @"^\d{5,12}$";
            //Console.WriteLine("qq1:" + Regex.IsMatch(qq1, pattern));
            //Console.WriteLine("qq2:" + Regex.IsMatch(qq2, pattern));
            //Console.WriteLine("qq3:" + Regex.IsMatch(qq3, pattern));

            //string s = "34 ((($$^# baga路口";
            //string pattern = @"\d|[a-z]";
            //MatchCollection col = Regex.Matches(s, pattern);
            //foreach (var match in col)
            //{
            //    Console.WriteLine(match.ToString());
            //}

            //string s = "zhangsan;lisi,wangwi.zhaoliu";
            //string pattern = @"[;,.]";
            //string pattern1 = @"[;][,][.]";
            //string[] resArray = Regex.Split(s, pattern);
            //foreach (var res in resArray)
            //{
            //    Console.WriteLine(res);
            //}

            //重复 多个字符 使用（abcd）{n}进行分组限定
            //string inputstr = Console.ReadLine();
            //string strGrounp2 = @"(ab\w{2}){2}";
            //Console.WriteLine("分组字符重复两次替换成555，结果是："+Regex.Replace(inputstr,strGrounp2,"55555"));

            Console.ReadKey();
        }
    }
}
