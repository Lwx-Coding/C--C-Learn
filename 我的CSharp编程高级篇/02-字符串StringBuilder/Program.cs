using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_字符串StringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb=new StringBuilder("www.devsiki.com");

            StringBuilder sb1=new StringBuilder(20);       //起始大小20

            StringBuilder sb2=new StringBuilder("www.devsiki.com,100");

            sb.Append("/xxx.html");
            //当我们需要对一个字符串进行频繁的删除添加操作的时候，用stringBuilder比较方便

            Console.WriteLine(sb.ToString());


            sb.Insert(0, "http://");
            Console.WriteLine(sb.ToString());

            sb.Remove(0, 3);
            Console.WriteLine(sb.ToString());

            sb.Replace(".", "");
            sb.Replace('/', '-');
            Console.WriteLine(sb);


            Console.ReadKey();
        }
    }
}
