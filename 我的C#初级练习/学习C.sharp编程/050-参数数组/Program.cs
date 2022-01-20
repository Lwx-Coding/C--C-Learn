using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _050_参数数组
{
    class Program
    {

        static int plus(params int[]array)
        {
            int num=0;
            for(int i = 0; i < array.Length; i++)
            {
                num += array[i];
            }
            return num;
        }
        static void Main(string[] args)
        {
            int num=plus(13, 35, 64);
            Console.WriteLine(num);

        }
    }
}
