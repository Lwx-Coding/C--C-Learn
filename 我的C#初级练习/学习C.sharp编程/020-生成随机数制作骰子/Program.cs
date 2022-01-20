using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _020_生成随机数制作骰子
{
    class Program
    {
        static void Main(string[] args)
        {
            Random shaizi = new Random();
            int num = shaizi.Next(1, 7);   //1-6
            Console.WriteLine("骰子的点数是:{0}", num);
            Console.ReadKey();
        }
    }
}
