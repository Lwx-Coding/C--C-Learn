using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _28_使用FileStream读写文件
{
    class Program
    {
        static void Main(string[] args)
        {
            ////1.创建文件流 用来操作文件
            //FileStream stream=new FileStream("TextFile1.txt",FileMode.Open);
            ////2.读取或者写入数据
            //byte[] data=new byte[1024];             //数据容器
            ////1 byte=1 字节 1024byte=1kb 1024kb=1Mb 1024MB=1GB 1024GB=1TB
            //while (true)
            //{
            //    int length = stream.Read(data, 0, data.Length);   //如果达到流结尾，则返回0
            //    if (length == 0)
            //    {
            //        Console.WriteLine("读取结束");
            //        break;
            //    }
            //    for (int i = 0; i < length; i++)
            //    {
            //        Console.Write(data[i]+" ");
            //    }
            //}

            //使用FILEstream完成文件复制
            FileStream readStream=new FileStream("3.LINQ.png",FileMode.Open);
            FileStream writeStream=new FileStream("LINQ副本.png",FileMode.Create);

            byte[] data=new byte[1024];
            while (true)
            {
                int length = readStream.Read(data, 0, data.Length);
                if (length == 0)
                {
                    Console.WriteLine("复制完毕");
                    break;
                }
                else
                {
                    writeStream.Write(data,0,data.Length);
                }
            }
            writeStream.Close();
            readStream.Close();

            Console.ReadKey();
        }
    }
}
