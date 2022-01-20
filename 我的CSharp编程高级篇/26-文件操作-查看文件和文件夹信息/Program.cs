using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_文件操作_查看文件和文件夹信息
{
    class Program
    {
        static void Main(string[] args)
        {
            //首先要把文件设置成始终复制到输出
            //这种是相对路径：就是找当前程序所在的路径
            FileInfo fileInfo=new FileInfo("TextFile1.txt");

            //绝对路径就是加上盘符 完整的路径名
            //里面有很多转义字符，所以在前面加上@,而且得在当前程序所在的路径下的txt文件
            FileInfo fileInfo1 = new FileInfo(@"D:\迅雷下载\Unity入门\我的CSharp编程高级篇\26-文件操作-查看文件和文件夹信息\bin\Debug\TextFile1.txt");
            
            Console.WriteLine(fileInfo.Exists);
            Console.WriteLine(fileInfo1.Exists);

            Console.WriteLine(fileInfo.Name);  //文件名.后缀

            Console.WriteLine(fileInfo.Directory);//取得文件所在路径

            Console.WriteLine(fileInfo.Length);//获取文件字符长度

            Console.WriteLine(fileInfo.IsReadOnly);    //是否文件是否只可读

            //fileInfo.Delete();                          //删除输出路径的文件，但是没有删除工程的文件，文件实际还存在

            //fileInfo.CopyTo("tt.txt");                   //复制一个一模一样的名字叫做tt.txt的文件

            FileInfo fileInfo2=new FileInfo("nb.txt");
            if (fileInfo2.Exists == false)
            {
                //文件不存在
                fileInfo2.Create();//创建当前文件
            }

            //fileInfo2.MoveTo("nb2.txt");   //相当于一个重命名操作

            //文件夹操作(目录操作)
            //查看Debug文件夹的信息  按照完整路径名创建
            DirectoryInfo dirinfo=new DirectoryInfo(@"D:\迅雷下载\Unity入门\我的CSharp编程高级篇\26-文件操作-查看文件和文件夹信息\bin\Debug");
            
            Console.WriteLine(dirinfo.Exists);//是否存在
            Console.WriteLine(dirinfo.Name);   //文件夹名称
            Console.WriteLine(dirinfo.Parent);   //父目录
            Console.WriteLine(dirinfo.Root);     //根目录
            Console.WriteLine(dirinfo.CreationTime);   //创建时间
            //dirinfo.CreateSubdirectory("bagayalu");   //创建子目录

            //相对路径
            DirectoryInfo dirinfo1=new DirectoryInfo("kkk");
            if (dirinfo1.Exists == false)
            {
                dirinfo1.Create();
            }

            Console.ReadKey();
        }
    }
}
