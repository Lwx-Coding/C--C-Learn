using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_在字符串前面加上_
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "I am a handsome boy \n yeah! pretty handsome!";
            Console.WriteLine(str1);
            string str2= @"I am a handsome boy \n               
                           yeah! "" pretty handsome!";       //取消了转移字符那么如何输出"呢，用""  同时@字符可以让字符串能在多行进行定义
            Console.WriteLine(str2);
            //也可以方便路径的表示
            string str3 = "C:\\xx\\xx\\x.dox";
            Console.WriteLine(str3);
            string str4 = @"C:\xx\xx\x.dox";                //选中然后 crtl+k and ctrl+c注释多行  crtl+k and ctrl+u 取消注释多行 
            Console.WriteLine(str4);

            Console.ReadKey();
        }
    }
}
