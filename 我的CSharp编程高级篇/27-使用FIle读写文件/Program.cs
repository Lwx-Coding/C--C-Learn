using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_使用FIle读写文件
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //string[] strArray = File.ReadAllLines("TextFile1.txt");//读取文件，把每一行文本读取成一个字符串，最后组成一个字符串数组
            //foreach (var temp in strArray)
            //{
            //    Console.WriteLine(temp);
            //}

            //string s = File.ReadAllText("TextFile1.txt");
            //Console.WriteLine(s);

            //读取非文本文件
            //byte[] byteArray = File.ReadAllBytes("3.LINQ.png");
            //foreach (var t in byteArray)
            //{
            //    Console.WriteLine(t);
            //}

            File.WriteAllText("textFile2.txt","你好中国");
            File.WriteAllLines("filetext3.txt",new string[]{"134314","314134134","134134134"});

            byte[] data = File.ReadAllBytes("3.LINQ.png");
            File.WriteAllBytes("4.png",data);
            Console.ReadKey();
        }
    }
}
