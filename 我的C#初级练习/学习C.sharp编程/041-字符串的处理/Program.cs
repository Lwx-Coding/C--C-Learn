using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _041_字符串的处理
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "    www.mifeof.COM    ";
            string res = str.ToLower();
            string res1 = str.ToUpper();
            string res2 = str.TrimStart();
            string res3 = str.TrimEnd();
            string res4 = str.Trim();
            string[] res5 = str.Split('.');
            Console.WriteLine(str);
            Console.WriteLine(res);
            Console.WriteLine(res1);
            Console.WriteLine(res2);
            Console.WriteLine(res3);
            Console.WriteLine(res4);
            foreach(string temp in res5)
            {
                Console.Write(temp);
            }
        }
    }
}
