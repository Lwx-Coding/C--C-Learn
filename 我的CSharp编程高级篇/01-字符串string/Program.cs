using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_字符串string
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s = "www.devsiki.com";
            //int length = s.Length;

            //if (s == "www.devsiki.com")
            //{
            //    Console.WriteLine("相同");
            //}
            //else
            //{
            //    Console.WriteLine("不相同");
            //}
            //Console.WriteLine(length);
            //s = "https://" + s;
            //Console.WriteLine(s);
            //char c = s[3];
            //Console.WriteLine(c);
            //for (int i = 0; i < s.Length; i++)
            //{
            //    Console.Write(s[i]);
            //}

            string s = "www.devsiki.com";
            int res = s.CompareTo("saki");
            Console.Write(res);
            string newStr = s.Replace('.', '-');
            Console.WriteLine(newStr);

            string[] strArray = s.Split('.');
            foreach (var temp in strArray)
            {
                Console.WriteLine(temp);
            }

            string str = s.Substring(4);
            Console.WriteLine(str);

            string str1 = s.Trim();
            Console.WriteLine(str1);

            int index = s.IndexOf("devsikid");
            Console.WriteLine(index);

            Console.ReadKey();


        }
    }
}
