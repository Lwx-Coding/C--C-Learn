using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _039_数组
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores ={ 23,43,53,545,54};//使用这种声明必须在声明时赋值
            int[] socres1 = new int[10];
            int[] scores2;
            scores2 = new int[10];
            int[] scores3 = new int[10] { 13, 43, 53, 54, 64, 54, 64, 54, 64, 54 };
            for(int i = 0; i < scores.Length; i++)
            {
                Console.Write(scores[i]);
            }
            for (int i = 0; i < 10; i++)
            {
                Console.Write(scores3[i]);
            }
            string[] strings = new string[] { "fff", "efef" };
            Console.WriteLine(strings[0]);
            foreach(int temp in scores3)
            {
                Console.WriteLine(temp);
            }

        }
    }
}
