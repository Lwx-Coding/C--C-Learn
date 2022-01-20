using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_使用stramReader和streamWrite读写文本文件
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建文本文件读取流
            //1 一行一行读取
            StreamReader reader=new StreamReader("TextFile1.txt");
            //while (true)
            //{
            //    string str = reader.ReadLine();//读取一行字符串
            //    if(str==null)break;
            //    Console.WriteLine(str);
            //}

            //2 直接全部读取
            //string str = reader.ReadToEnd();//读取到文本的结尾 读取文本中所有的字符
            //Console.WriteLine(str);

            //3 一个字符一个字符的读取
            //while (true)
            //{
            //    int res = reader.Read();//读取一个字符
            //    if (res == -1)
            //    {
            //        Console.WriteLine("读取完毕");
            //        break;
            //    }
            //    else
            //    {
            //        Console.Write((char)res);
            //    }
            //}

            //4.文本文件写入流
            StreamWriter writer=new StreamWriter("textFile2.txt");   //如果文件存在，那么文件会被覆盖
            while (true)
            {
                string message = Console.ReadLine();
                if(message=="q")break;
                writer.WriteLine(message);//写入一行数据并换行
            }

            writer.Close();
            reader.Close();
            Console.ReadKey();
        }
    }
}
